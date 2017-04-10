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
    public interface IContaApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Lan\u00C3\u00A7a um ajuste para a conta do id informado
        /// </summary>
        /// <remarks>
        /// Este recurso insere um ajuste para a conta do id informado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idTipoAjuste">C\u00C3\u00B3digo identificador do tipo de ajuste.</param>
        /// <param name="dataAjuste">Data do ajuste.</param>
        /// <param name="valorAjuste">Valor do ajuste</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>AjusteResponse</returns>
        AjusteResponse AjustarContaUsingPOST (long? id, long? idTipoAjuste, DateTime? dataAjuste, double? valorAjuste, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lan\u00C3\u00A7a um ajuste para a conta do id informado
        /// </summary>
        /// <remarks>
        /// Este recurso insere um ajuste para a conta do id informado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idTipoAjuste">C\u00C3\u00B3digo identificador do tipo de ajuste.</param>
        /// <param name="dataAjuste">Data do ajuste.</param>
        /// <param name="valorAjuste">Valor do ajuste</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>ApiResponse of AjusteResponse</returns>
        ApiResponse<AjusteResponse> AjustarContaUsingPOSTWithHttpInfo (long? id, long? idTipoAjuste, DateTime? dataAjuste, double? valorAjuste, int? page = null, int? limit = null);
        
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o dos limites da conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite realizar a altera\u00C3\u00A7\u00C3\u00A3o dos Limites de uma determinada Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="limiteGlobal">Apresenta o valor do limite de cr\u00C3\u00A9dito que o portador do cart\u00C3\u00A3o possui.</param>
        /// <param name="limiteCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para uso exclusivo em Compras Nacionais.</param>
        /// <param name="limiteParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para realizar transa\u00C3\u00A7\u00C3\u00B5es de compras parceladas.</param>
        /// <param name="limiteParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que portador pode acumular a partir da soma das parcelas das compras que forem realizadas nesta modalidade.</param>
        /// <param name="limiteSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional.</param>
        /// <param name="limiteSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional dentro de cada ciclo de faturamento.</param>
        /// <param name="limiteConsignado">Quando utilizado pelo emissor, este campo apresenta o valor da margem de cr\u00C3\u00A9dito que ele poder\u00C3\u00A1 utilizar para ser cobrado de forma consignada (desconto em folha) em seu sal\u00C3\u00A1rio/vencimentos.</param>
        /// <param name="limiteInternacionalCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para uso exclusivo em Compras Internacionais.</param>
        /// <param name="limiteInternacionalParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para realizar transa\u00C3\u00A7\u00C3\u00B5es Internacionais de Compras Parceladas.</param>
        /// <param name="limiteInternacionalParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que portador pode acumular a partir da soma das parcelas das compras internacionais que forem realizadas nesta modalidade.</param>
        /// <param name="limiteInternacionalSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Internacional.</param>
        /// <param name="limiteInternacionalSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Internacional dentro de cada ciclo de faturamento.</param>
        /// <returns>LimiteDisponibilidade</returns>
        LimiteDisponibilidade AlterarLimiteUsingPUT (long? id, double? limiteGlobal, double? limiteCompra, double? limiteParcelado, double? limiteParcelas, double? limiteSaqueGlobal, double? limiteSaquePeriodo, double? limiteConsignado, double? limiteInternacionalCompra, double? limiteInternacionalParcelado, double? limiteInternacionalParcelas, double? limiteInternacionalSaqueGlobal, double? limiteInternacionalSaquePeriodo);
  
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o dos limites da conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite realizar a altera\u00C3\u00A7\u00C3\u00A3o dos Limites de uma determinada Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="limiteGlobal">Apresenta o valor do limite de cr\u00C3\u00A9dito que o portador do cart\u00C3\u00A3o possui.</param>
        /// <param name="limiteCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para uso exclusivo em Compras Nacionais.</param>
        /// <param name="limiteParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para realizar transa\u00C3\u00A7\u00C3\u00B5es de compras parceladas.</param>
        /// <param name="limiteParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que portador pode acumular a partir da soma das parcelas das compras que forem realizadas nesta modalidade.</param>
        /// <param name="limiteSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional.</param>
        /// <param name="limiteSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional dentro de cada ciclo de faturamento.</param>
        /// <param name="limiteConsignado">Quando utilizado pelo emissor, este campo apresenta o valor da margem de cr\u00C3\u00A9dito que ele poder\u00C3\u00A1 utilizar para ser cobrado de forma consignada (desconto em folha) em seu sal\u00C3\u00A1rio/vencimentos.</param>
        /// <param name="limiteInternacionalCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para uso exclusivo em Compras Internacionais.</param>
        /// <param name="limiteInternacionalParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para realizar transa\u00C3\u00A7\u00C3\u00B5es Internacionais de Compras Parceladas.</param>
        /// <param name="limiteInternacionalParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que portador pode acumular a partir da soma das parcelas das compras internacionais que forem realizadas nesta modalidade.</param>
        /// <param name="limiteInternacionalSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Internacional.</param>
        /// <param name="limiteInternacionalSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Internacional dentro de cada ciclo de faturamento.</param>
        /// <returns>ApiResponse of LimiteDisponibilidade</returns>
        ApiResponse<LimiteDisponibilidade> AlterarLimiteUsingPUTWithHttpInfo (long? id, double? limiteGlobal, double? limiteCompra, double? limiteParcelado, double? limiteParcelas, double? limiteSaqueGlobal, double? limiteSaquePeriodo, double? limiteConsignado, double? limiteInternacionalCompra, double? limiteInternacionalParcelado, double? limiteInternacionalParcelas, double? limiteInternacionalSaqueGlobal, double? limiteInternacionalSaquePeriodo);
        
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o do dia de vencimento das faturas da conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite alterar o vencimento de uma conta especifica.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="novoDiaVencimento">Novo dia de vencimento.</param>
        /// <returns>Conta</returns>
        Conta AlterarVencimentoUsingPUT (long? id, int? novoDiaVencimento);
  
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o do dia de vencimento das faturas da conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite alterar o vencimento de uma conta especifica.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="novoDiaVencimento">Novo dia de vencimento.</param>
        /// <returns>ApiResponse of Conta</returns>
        ApiResponse<Conta> AlterarVencimentoUsingPUTWithHttpInfo (long? id, int? novoDiaVencimento);
        
        /// <summary>
        ///  Ativa o servi\u00C3\u00A7o de envio de fatura por email
        /// </summary>
        /// <remarks>
        /// Este recurso ativa o servi\u00C3\u00A7o de envio de fatura por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>Object</returns>
        Object AtivarEnvioFaturaEmailUsingPOST (long? id);
  
        /// <summary>
        ///  Ativa o servi\u00C3\u00A7o de envio de fatura por email
        /// </summary>
        /// <remarks>
        /// Este recurso ativa o servi\u00C3\u00A7o de envio de fatura por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> AtivarEnvioFaturaEmailUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta os dados de um determinado boleto da fatura
        /// </summary>
        /// <remarks>
        /// Este recurso consulta um boleto da fatura
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>BoletoDeFatura</returns>
        BoletoDeFatura ConsultarBoletoEmitidoUsingGET (long? id);
  
        /// <summary>
        /// Consulta os dados de um determinado boleto da fatura
        /// </summary>
        /// <remarks>
        /// Este recurso consulta um boleto da fatura
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>ApiResponse of BoletoDeFatura</returns>
        ApiResponse<BoletoDeFatura> ConsultarBoletoEmitidoUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta a d\u00C3\u00ADvida atualizada do cliente
        /// </summary>
        /// <remarks>
        /// Este recurso consulta a d\u00C3\u00ADvida atualizada do cliente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataVencimento">Data do vencimento (optional)</param>
        /// <param name="idEscritorioCobranca">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do escrit\u00C3\u00B3rio de cobran\u00C3\u00A7a (optional)</param>
        /// <returns>DividaClienteResponse</returns>
        DividaClienteResponse ConsultarDividaAtualizadaClienteUsingGET (long? id, int? page = null, int? limit = null, DateTime? dataVencimento = null, long? idEscritorioCobranca = null);
  
        /// <summary>
        /// Consulta a d\u00C3\u00ADvida atualizada do cliente
        /// </summary>
        /// <remarks>
        /// Este recurso consulta a d\u00C3\u00ADvida atualizada do cliente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataVencimento">Data do vencimento (optional)</param>
        /// <param name="idEscritorioCobranca">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do escrit\u00C3\u00B3rio de cobran\u00C3\u00A7a (optional)</param>
        /// <returns>ApiResponse of DividaClienteResponse</returns>
        ApiResponse<DividaClienteResponse> ConsultarDividaAtualizadaClienteUsingGETWithHttpInfo (long? id, int? page = null, int? limit = null, DateTime? dataVencimento = null, long? idEscritorioCobranca = null);
        
        /// <summary>
        /// Consultar a fatura consignadas abertas da conta
        /// </summary>
        /// <remarks>
        /// Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar a fatura consignada em aberto
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="dataVencimento">Data Vencimento.</param>
        /// <returns>FaturaConsignadaResponse</returns>
        FaturaConsignadaResponse ConsultarFaturaConsignadaAbertaUsingGET (long? id, DateTime? dataVencimento);
  
        /// <summary>
        /// Consultar a fatura consignadas abertas da conta
        /// </summary>
        /// <remarks>
        /// Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar a fatura consignada em aberto
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="dataVencimento">Data Vencimento.</param>
        /// <returns>ApiResponse of FaturaConsignadaResponse</returns>
        ApiResponse<FaturaConsignadaResponse> ConsultarFaturaConsignadaAbertaUsingGETWithHttpInfo (long? id, DateTime? dataVencimento);
        
        /// <summary>
        /// Apresenta dados de uma determinada fatura consignada
        /// </summary>
        /// <remarks>
        /// Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar uma fatura, atrav\u00C3\u00A9s do id da conta e o id da fatura.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idFatura">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da fatura (id_fatura).</param>
        /// <returns>FaturaConsignadaDetalheResponse</returns>
        FaturaConsignadaDetalheResponse ConsultarFaturaConsignadaUsingGET (long? id, long? idFatura);
  
        /// <summary>
        /// Apresenta dados de uma determinada fatura consignada
        /// </summary>
        /// <remarks>
        /// Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar uma fatura, atrav\u00C3\u00A9s do id da conta e o id da fatura.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idFatura">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da fatura (id_fatura).</param>
        /// <returns>ApiResponse of FaturaConsignadaDetalheResponse</returns>
        ApiResponse<FaturaConsignadaDetalheResponse> ConsultarFaturaConsignadaUsingGETWithHttpInfo (long? id, long? idFatura);
        
        /// <summary>
        /// Consultar Fatura da Conta
        /// </summary>
        /// <remarks>
        /// Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar os detalhes de uma fatura vinculados a uma determinada conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idFatura">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da fatura (id_fatura).</param>
        /// <returns>DetalhesFaturaResponse</returns>
        DetalhesFaturaResponse ConsultarFaturaUsingGET (long? id, long? idFatura);
  
        /// <summary>
        /// Consultar Fatura da Conta
        /// </summary>
        /// <remarks>
        /// Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar os detalhes de uma fatura vinculados a uma determinada conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idFatura">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da fatura (id_fatura).</param>
        /// <returns>ApiResponse of DetalhesFaturaResponse</returns>
        ApiResponse<DetalhesFaturaResponse> ConsultarFaturaUsingGETWithHttpInfo (long? id, long? idFatura);
        
        /// <summary>
        /// Consultar Lan\u00C3\u00A7amentos Futuros da Fatura de uma Conta
        /// </summary>
        /// <remarks>
        /// Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar os detalhes dos lan\u00C3\u00A7amentos futuros de uma fatura vinculados a uma determinada conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idFatura">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da fatura (id_fatura).</param>
        /// <returns>DetalhesFaturaResponse</returns>
        DetalhesFaturaResponse ConsultarLancamentosFuturosFaturaUsingGET (long? id, long? idFatura);
  
        /// <summary>
        /// Consultar Lan\u00C3\u00A7amentos Futuros da Fatura de uma Conta
        /// </summary>
        /// <remarks>
        /// Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar os detalhes dos lan\u00C3\u00A7amentos futuros de uma fatura vinculados a uma determinada conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idFatura">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da fatura (id_fatura).</param>
        /// <returns>ApiResponse of DetalhesFaturaResponse</returns>
        ApiResponse<DetalhesFaturaResponse> ConsultarLancamentosFuturosFaturaUsingGETWithHttpInfo (long? id, long? idFatura);
        
        /// <summary>
        /// Apresenta os limites da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os Limites configurados para uma determinada Conta, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>LimiteDisponibilidade</returns>
        LimiteDisponibilidade ConsultarLimiteDisponibilidadeUsingGET1 (long? id);
  
        /// <summary>
        /// Apresenta os limites da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os Limites configurados para uma determinada Conta, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>ApiResponse of LimiteDisponibilidade</returns>
        ApiResponse<LimiteDisponibilidade> ConsultarLimiteDisponibilidadeUsingGET1WithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta os detalhes de uma determinada transfer\u00C3\u00AAncia
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os detalhes de uma determinada transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito realizada entre contas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idTransferencia">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id_transferencia).</param>
        /// <returns>PageTransferencias</returns>
        PageTransferencias ConsultarUsingGET21 (long? id, long? idTransferencia);
  
        /// <summary>
        /// Consulta os detalhes de uma determinada transfer\u00C3\u00AAncia
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os detalhes de uma determinada transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito realizada entre contas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idTransferencia">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id_transferencia).</param>
        /// <returns>ApiResponse of PageTransferencias</returns>
        ApiResponse<PageTransferencias> ConsultarUsingGET21WithHttpInfo (long? id, long? idTransferencia);
        
        /// <summary>
        /// Apresenta dados de uma determinada conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar dados de uma determinada conta a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>Conta</returns>
        Conta ConsultarUsingGET3 (long? id);
  
        /// <summary>
        /// Apresenta dados de uma determinada conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar dados de uma determinada conta a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>ApiResponse of Conta</returns>
        ApiResponse<Conta> ConsultarUsingGET3WithHttpInfo (long? id);
        
        /// <summary>
        /// Desativa o servi\u00C3\u00A7o de envio de fatura por email
        /// </summary>
        /// <remarks>
        /// Este recurso desativa o servi\u00C3\u00A7o de envio de fatura por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>Object</returns>
        Object DesativarEnvioFaturaEmailUsingPOST (long? id);
  
        /// <summary>
        /// Desativa o servi\u00C3\u00A7o de envio de fatura por email
        /// </summary>
        /// <remarks>
        /// Este recurso desativa o servi\u00C3\u00A7o de envio de fatura por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> DesativarEnvioFaturaEmailUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// Gera um boleto de recarga
        /// </summary>
        /// <remarks>
        /// Este recurso gera um boleto de recarga
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="valor"></param>
        /// <param name="dataVencimento"></param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>BoletoDeFatura</returns>
        BoletoDeFatura GerarBoletoRecargaUsingPOST (long? id, double? valor, DateTime? dataVencimento, int? page = null, int? limit = null);
  
        /// <summary>
        /// Gera um boleto de recarga
        /// </summary>
        /// <remarks>
        /// Este recurso gera um boleto de recarga
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="valor"></param>
        /// <param name="dataVencimento"></param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>ApiResponse of BoletoDeFatura</returns>
        ApiResponse<BoletoDeFatura> GerarBoletoRecargaUsingPOSTWithHttpInfo (long? id, double? valor, DateTime? dataVencimento, int? page = null, int? limit = null);
        
        /// <summary>
        /// Realiza a gera\u00C3\u00A7\u00C3\u00A3o de um novo cart\u00C3\u00A3o para impress\u00C3\u00A3o avulsa
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja gerado um novo Cart\u00C3\u00A3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00C3\u00A3o que dever\u00C3\u00A1 ser gerado para impress\u00C3\u00A3o. Esta funcionalidade poder\u00C3\u00A1 ser utilizada para realizar a impress\u00C3\u00A3o de cart\u00C3\u00B5es em Lojas, Quiosques, Escrit\u00C3\u00B3rios, Terminais de Auto Atendimento, ou outro local que o Emissor escolher, desde que se possua uma impressora de Cart\u00C3\u00B5es habilidade para o fazer, no local.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da pessoa (id).</param>
        /// <param name="idTipoPlastico">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do TipoPlastico (id). (optional)</param>
        /// <returns>CartaoImpressao</returns>
        CartaoImpressao GerarCartaoUsingPOST (long? id, long? idPessoa, long? idTipoPlastico = null);
  
        /// <summary>
        /// Realiza a gera\u00C3\u00A7\u00C3\u00A3o de um novo cart\u00C3\u00A3o para impress\u00C3\u00A3o avulsa
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja gerado um novo Cart\u00C3\u00A3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00C3\u00A3o que dever\u00C3\u00A1 ser gerado para impress\u00C3\u00A3o. Esta funcionalidade poder\u00C3\u00A1 ser utilizada para realizar a impress\u00C3\u00A3o de cart\u00C3\u00B5es em Lojas, Quiosques, Escrit\u00C3\u00B3rios, Terminais de Auto Atendimento, ou outro local que o Emissor escolher, desde que se possua uma impressora de Cart\u00C3\u00B5es habilidade para o fazer, no local.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da pessoa (id).</param>
        /// <param name="idTipoPlastico">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do TipoPlastico (id). (optional)</param>
        /// <returns>ApiResponse of CartaoImpressao</returns>
        ApiResponse<CartaoImpressao> GerarCartaoUsingPOSTWithHttpInfo (long? id, long? idPessoa, long? idTipoPlastico = null);
        
        /// <summary>
        /// Lista as faturas consignadas da conta
        /// </summary>
        /// <remarks>
        /// Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar todo o Hist\u00C3\u00B3rico de Faturas vinculados a uma determinada Conta, independentemente do valor delas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataVencimento">Apresenta a data de vencimento da fatura. (optional)</param>
        /// <returns>PageFaturasConsignadas</returns>
        PageFaturasConsignadas ListarFaturasConsignadasUsingGET (long? id, int? page = null, int? limit = null, DateTime? dataVencimento = null);
  
        /// <summary>
        /// Lista as faturas consignadas da conta
        /// </summary>
        /// <remarks>
        /// Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar todo o Hist\u00C3\u00B3rico de Faturas vinculados a uma determinada Conta, independentemente do valor delas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataVencimento">Apresenta a data de vencimento da fatura. (optional)</param>
        /// <returns>ApiResponse of PageFaturasConsignadas</returns>
        ApiResponse<PageFaturasConsignadas> ListarFaturasConsignadasUsingGETWithHttpInfo (long? id, int? page = null, int? limit = null, DateTime? dataVencimento = null);
        
        /// <summary>
        /// Lista as faturas da conta
        /// </summary>
        /// <remarks>
        /// Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar todo o Hist\u00C3\u00B3rico de Faturas vinculados a uma determinada Conta, independentemente do valor delas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataVencimento">Data de Vencimento da Fatura. (optional)</param>
        /// <returns>PageFaturas</returns>
        PageFaturas ListarFaturasUsingGET (long? id, int? page = null, int? limit = null, DateTime? dataVencimento = null);
  
        /// <summary>
        /// Lista as faturas da conta
        /// </summary>
        /// <remarks>
        /// Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar todo o Hist\u00C3\u00B3rico de Faturas vinculados a uma determinada Conta, independentemente do valor delas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataVencimento">Data de Vencimento da Fatura. (optional)</param>
        /// <returns>ApiResponse of PageFaturas</returns>
        ApiResponse<PageFaturas> ListarFaturasUsingGETWithHttpInfo (long? id, int? page = null, int? limit = null, DateTime? dataVencimento = null);
        
        /// <summary>
        /// Lista o hist\u00C3\u00B3rico de altera\u00C3\u00A7\u00C3\u00B5es de limites da conta
        /// </summary>
        /// <remarks>
        /// Este recurso consulta o hist\u00C3\u00B3rico com as altera\u00C3\u00A7\u00C3\u00B5es de limites da conta informada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>PageHistoricoEventos</returns>
        PageHistoricoEventos ListarHistoricoAlteracoesLimitesUsingGET (long? id, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista o hist\u00C3\u00B3rico de altera\u00C3\u00A7\u00C3\u00B5es de limites da conta
        /// </summary>
        /// <remarks>
        /// Este recurso consulta o hist\u00C3\u00B3rico com as altera\u00C3\u00A7\u00C3\u00B5es de limites da conta informada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>ApiResponse of PageHistoricoEventos</returns>
        ApiResponse<PageHistoricoEventos> ListarHistoricoAlteracoesLimitesUsingGETWithHttpInfo (long? id, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista o hist\u00C3\u00B3rico de entradas/sa\u00C3\u00ADdas de assessorias de cobran\u00C3\u00A7a
        /// </summary>
        /// <remarks>
        /// Permite listar todos os registros de entrada e sa\u00C3\u00ADda da Conta em arquivos de integra\u00C3\u00A7\u00C3\u00A3o com empresas de assessorias de cobran\u00C3\u00A7a a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (idConta).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>LinkPageHistoricoAssessoriaResponse</returns>
        LinkPageHistoricoAssessoriaResponse ListarHistoricoAssessoriaUsingGET (long? id, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista o hist\u00C3\u00B3rico de entradas/sa\u00C3\u00ADdas de assessorias de cobran\u00C3\u00A7a
        /// </summary>
        /// <remarks>
        /// Permite listar todos os registros de entrada e sa\u00C3\u00ADda da Conta em arquivos de integra\u00C3\u00A7\u00C3\u00A3o com empresas de assessorias de cobran\u00C3\u00A7a a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (idConta).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>ApiResponse of LinkPageHistoricoAssessoriaResponse</returns>
        ApiResponse<LinkPageHistoricoAssessoriaResponse> ListarHistoricoAssessoriaUsingGETWithHttpInfo (long? id, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista o historico de atrasos das faturas
        /// </summary>
        /// <remarks>
        /// Este recurso lista o hist\u00C3\u00B3rico do pagamento de faturas em atraso
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>PageHistoricoAtraso</returns>
        PageHistoricoAtraso ListarHistoricoAtrasosFaturasUsingGET (long? id);
  
        /// <summary>
        /// Lista o historico de atrasos das faturas
        /// </summary>
        /// <remarks>
        /// Este recurso lista o hist\u00C3\u00B3rico do pagamento de faturas em atraso
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>ApiResponse of PageHistoricoAtraso</returns>
        ApiResponse<PageHistoricoAtraso> ListarHistoricoAtrasosFaturasUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista as transa\u00C3\u00A7\u00C3\u00B5es n\u00C3\u00A3o processadas da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas todas as transa\u00C3\u00A7\u00C3\u00B5es n\u00C3\u00A3o processadas da Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>PageTransacoesCorrentes</returns>
        PageTransacoesCorrentes ListarNaoProcessadasUsingGET (long? id, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista as transa\u00C3\u00A7\u00C3\u00B5es n\u00C3\u00A3o processadas da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas todas as transa\u00C3\u00A7\u00C3\u00B5es n\u00C3\u00A3o processadas da Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>ApiResponse of PageTransacoesCorrentes</returns>
        ApiResponse<PageTransacoesCorrentes> ListarNaoProcessadasUsingGETWithHttpInfo (long? id, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista as transa\u00C3\u00A7\u00C3\u00B5es processadas da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas todas as transa\u00C3\u00A7\u00C3\u00B5es processadas da Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataVencimento">Data de vencimento do extrato no formato yyyy-MM-dd. (optional)</param>
        /// <returns>PageTransacoesCorrentes</returns>
        PageTransacoesCorrentes ListarProcessadasUsingGET (long? id, int? page = null, int? limit = null, DateTime? dataVencimento = null);
  
        /// <summary>
        /// Lista as transa\u00C3\u00A7\u00C3\u00B5es processadas da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas todas as transa\u00C3\u00A7\u00C3\u00B5es processadas da Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataVencimento">Data de vencimento do extrato no formato yyyy-MM-dd. (optional)</param>
        /// <returns>ApiResponse of PageTransacoesCorrentes</returns>
        ApiResponse<PageTransacoesCorrentes> ListarProcessadasUsingGETWithHttpInfo (long? id, int? page = null, int? limit = null, DateTime? dataVencimento = null);
        
        /// <summary>
        /// Lista as transfer\u00C3\u00AAncias realizadas pela conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as transfer\u00C3\u00AAncias realizadas pela conta existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="idTransferencia">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id). (optional)</param>
        /// <param name="idContaOrigem">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 debitado para a transfer\u00C3\u00AAncia. (id). (optional)</param>
        /// <param name="idContaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 creditado para a transfer\u00C3\u00AAncia. (id). (optional)</param>
        /// <param name="valorTransferencia">Valor estabelecido para ser transferido. (optional)</param>
        /// <param name="dataTransferencia">Data estabelecida para ocorrer a transfer\u00C3\u00AAncia. (optional)</param>
        /// <returns>PageTransferencias</returns>
        PageTransferencias ListarUsingGET20 (long? id, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, DateTime? dataTransferencia = null);
  
        /// <summary>
        /// Lista as transfer\u00C3\u00AAncias realizadas pela conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as transfer\u00C3\u00AAncias realizadas pela conta existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="idTransferencia">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id). (optional)</param>
        /// <param name="idContaOrigem">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 debitado para a transfer\u00C3\u00AAncia. (id). (optional)</param>
        /// <param name="idContaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 creditado para a transfer\u00C3\u00AAncia. (id). (optional)</param>
        /// <param name="valorTransferencia">Valor estabelecido para ser transferido. (optional)</param>
        /// <param name="dataTransferencia">Data estabelecida para ocorrer a transfer\u00C3\u00AAncia. (optional)</param>
        /// <returns>ApiResponse of PageTransferencias</returns>
        ApiResponse<PageTransferencias> ListarUsingGET20WithHttpInfo (long? id, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, DateTime? dataTransferencia = null);
        
        /// <summary>
        /// Lista contas existentes na base de dados do Emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar contas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do produto ao qual a conta faz parte. (id). (optional)</param>
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id) que deu origem a Conta. (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa Titular da Conta (id). (optional)</param>
        /// <param name="idStatusConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="diaVencimento">Apresenta o dia de vencimento. (optional)</param>
        /// <param name="melhorDiaCompra">Apresenta o melhor dia de compra. (optional)</param>
        /// <param name="dataStatusConta">Apresenta a data em que o idStatusConta atual fora atribu\u00C3\u00ADdo para ela. (optional)</param>
        /// <param name="dataCadastro">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param>
        /// <param name="dataUltimaAlteracaoVencimento">Apresenta a data da ultima altera\u00C3\u00A7\u00C3\u00A3o de vencimento. (optional)</param>
        /// <returns>PageContas</returns>
        PageContas ListarUsingGET3 (int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, DateTime? dataStatusConta = null, DateTime? dataCadastro = null, DateTime? dataUltimaAlteracaoVencimento = null);
  
        /// <summary>
        /// Lista contas existentes na base de dados do Emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar contas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do produto ao qual a conta faz parte. (id). (optional)</param>
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id) que deu origem a Conta. (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa Titular da Conta (id). (optional)</param>
        /// <param name="idStatusConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="diaVencimento">Apresenta o dia de vencimento. (optional)</param>
        /// <param name="melhorDiaCompra">Apresenta o melhor dia de compra. (optional)</param>
        /// <param name="dataStatusConta">Apresenta a data em que o idStatusConta atual fora atribu\u00C3\u00ADdo para ela. (optional)</param>
        /// <param name="dataCadastro">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param>
        /// <param name="dataUltimaAlteracaoVencimento">Apresenta a data da ultima altera\u00C3\u00A7\u00C3\u00A3o de vencimento. (optional)</param>
        /// <returns>ApiResponse of PageContas</returns>
        ApiResponse<PageContas> ListarUsingGET3WithHttpInfo (int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, DateTime? dataStatusConta = null, DateTime? dataCadastro = null, DateTime? dataUltimaAlteracaoVencimento = null);
        
        /// <summary>
        /// Realiza a reativa\u00C3\u00A7\u00C3\u00A3o de contas que foram desativadas por inadimpl\u00C3\u00AAncia
        /// </summary>
        /// <remarks>
        /// Este recurso permite reativar contas que foram desativadas por inadimpl\u00C3\u00AAncia. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Object</returns>
        Object ReativarUsingPOST (long? id);
  
        /// <summary>
        /// Realiza a reativa\u00C3\u00A7\u00C3\u00A3o de contas que foram desativadas por inadimpl\u00C3\u00AAncia
        /// </summary>
        /// <remarks>
        /// Este recurso permite reativar contas que foram desativadas por inadimpl\u00C3\u00AAncia. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ReativarUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// Permite listar uma linha do tempo com os eventos da conta
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir a listagem, em formato de timeline, dos eventos vinculados a uma detemrinada conta. Transa\u00C3\u00A7\u00C3\u00B5es, fechamento da fatura, pagamentos, gera\u00C3\u00A7\u00C3\u00A3o de cart\u00C3\u00B5es e altera\u00C3\u00A7\u00C3\u00A3o de limite s\u00C3\u00A3o exemplos de eventos contemplados por esta funcionalidade. Neste m\u00C3\u00A9todo, as opera\u00C3\u00A7\u00C3\u00B5es s\u00C3\u00A3o ordenadas de forma decrescente.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>PageTransacaoResponse</returns>
        PageTransacaoResponse TransacoesUsingGET (long? id, int? page = null, int? limit = null);
  
        /// <summary>
        /// Permite listar uma linha do tempo com os eventos da conta
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir a listagem, em formato de timeline, dos eventos vinculados a uma detemrinada conta. Transa\u00C3\u00A7\u00C3\u00B5es, fechamento da fatura, pagamentos, gera\u00C3\u00A7\u00C3\u00A3o de cart\u00C3\u00B5es e altera\u00C3\u00A7\u00C3\u00A3o de limite s\u00C3\u00A3o exemplos de eventos contemplados por esta funcionalidade. Neste m\u00C3\u00A9todo, as opera\u00C3\u00A7\u00C3\u00B5es s\u00C3\u00A3o ordenadas de forma decrescente.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>ApiResponse of PageTransacaoResponse</returns>
        ApiResponse<PageTransacaoResponse> TransacoesUsingGETWithHttpInfo (long? id, int? page = null, int? limit = null);
        
        /// <summary>
        /// Realiza uma transfer\u00C3\u00AAncia de Cr\u00C3\u00A9dito para outro cliente do mesmo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que um portador de um cart\u00C3\u00A3o possa realizar auma transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para outro cliente do mesmo emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do cliente portador do cart\u00C3\u00A3o que ser\u00C3\u00A1 debitado (id).</param>
        /// <param name="idContaDestino">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do cliente portador do cart\u00C3\u00A3o que ser\u00C3\u00A1 creditado (id).</param>
        /// <param name="valorTransferencia">Valor da Transfer\u00C3\u00AAncia.</param>
        /// <returns>PageTransferencias</returns>
        PageTransferencias TransferirUsingPOST1 (long? id, long? idContaDestino, double? valorTransferencia);
  
        /// <summary>
        /// Realiza uma transfer\u00C3\u00AAncia de Cr\u00C3\u00A9dito para outro cliente do mesmo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que um portador de um cart\u00C3\u00A3o possa realizar auma transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para outro cliente do mesmo emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do cliente portador do cart\u00C3\u00A3o que ser\u00C3\u00A1 debitado (id).</param>
        /// <param name="idContaDestino">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do cliente portador do cart\u00C3\u00A3o que ser\u00C3\u00A1 creditado (id).</param>
        /// <param name="valorTransferencia">Valor da Transfer\u00C3\u00AAncia.</param>
        /// <returns>ApiResponse of PageTransferencias</returns>
        ApiResponse<PageTransferencias> TransferirUsingPOST1WithHttpInfo (long? id, long? idContaDestino, double? valorTransferencia);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Lan\u00C3\u00A7a um ajuste para a conta do id informado
        /// </summary>
        /// <remarks>
        /// Este recurso insere um ajuste para a conta do id informado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idTipoAjuste">C\u00C3\u00B3digo identificador do tipo de ajuste.</param>
        /// <param name="dataAjuste">Data do ajuste.</param>
        /// <param name="valorAjuste">Valor do ajuste</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of AjusteResponse</returns>
        System.Threading.Tasks.Task<AjusteResponse> AjustarContaUsingPOSTAsync (long? id, long? idTipoAjuste, DateTime? dataAjuste, double? valorAjuste, int? page = null, int? limit = null);

        /// <summary>
        /// Lan\u00C3\u00A7a um ajuste para a conta do id informado
        /// </summary>
        /// <remarks>
        /// Este recurso insere um ajuste para a conta do id informado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idTipoAjuste">C\u00C3\u00B3digo identificador do tipo de ajuste.</param>
        /// <param name="dataAjuste">Data do ajuste.</param>
        /// <param name="valorAjuste">Valor do ajuste</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ApiResponse (AjusteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AjusteResponse>> AjustarContaUsingPOSTAsyncWithHttpInfo (long? id, long? idTipoAjuste, DateTime? dataAjuste, double? valorAjuste, int? page = null, int? limit = null);
        
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o dos limites da conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite realizar a altera\u00C3\u00A7\u00C3\u00A3o dos Limites de uma determinada Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="limiteGlobal">Apresenta o valor do limite de cr\u00C3\u00A9dito que o portador do cart\u00C3\u00A3o possui.</param>
        /// <param name="limiteCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para uso exclusivo em Compras Nacionais.</param>
        /// <param name="limiteParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para realizar transa\u00C3\u00A7\u00C3\u00B5es de compras parceladas.</param>
        /// <param name="limiteParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que portador pode acumular a partir da soma das parcelas das compras que forem realizadas nesta modalidade.</param>
        /// <param name="limiteSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional.</param>
        /// <param name="limiteSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional dentro de cada ciclo de faturamento.</param>
        /// <param name="limiteConsignado">Quando utilizado pelo emissor, este campo apresenta o valor da margem de cr\u00C3\u00A9dito que ele poder\u00C3\u00A1 utilizar para ser cobrado de forma consignada (desconto em folha) em seu sal\u00C3\u00A1rio/vencimentos.</param>
        /// <param name="limiteInternacionalCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para uso exclusivo em Compras Internacionais.</param>
        /// <param name="limiteInternacionalParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para realizar transa\u00C3\u00A7\u00C3\u00B5es Internacionais de Compras Parceladas.</param>
        /// <param name="limiteInternacionalParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que portador pode acumular a partir da soma das parcelas das compras internacionais que forem realizadas nesta modalidade.</param>
        /// <param name="limiteInternacionalSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Internacional.</param>
        /// <param name="limiteInternacionalSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Internacional dentro de cada ciclo de faturamento.</param>
        /// <returns>Task of LimiteDisponibilidade</returns>
        System.Threading.Tasks.Task<LimiteDisponibilidade> AlterarLimiteUsingPUTAsync (long? id, double? limiteGlobal, double? limiteCompra, double? limiteParcelado, double? limiteParcelas, double? limiteSaqueGlobal, double? limiteSaquePeriodo, double? limiteConsignado, double? limiteInternacionalCompra, double? limiteInternacionalParcelado, double? limiteInternacionalParcelas, double? limiteInternacionalSaqueGlobal, double? limiteInternacionalSaquePeriodo);

        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o dos limites da conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite realizar a altera\u00C3\u00A7\u00C3\u00A3o dos Limites de uma determinada Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="limiteGlobal">Apresenta o valor do limite de cr\u00C3\u00A9dito que o portador do cart\u00C3\u00A3o possui.</param>
        /// <param name="limiteCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para uso exclusivo em Compras Nacionais.</param>
        /// <param name="limiteParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para realizar transa\u00C3\u00A7\u00C3\u00B5es de compras parceladas.</param>
        /// <param name="limiteParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que portador pode acumular a partir da soma das parcelas das compras que forem realizadas nesta modalidade.</param>
        /// <param name="limiteSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional.</param>
        /// <param name="limiteSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional dentro de cada ciclo de faturamento.</param>
        /// <param name="limiteConsignado">Quando utilizado pelo emissor, este campo apresenta o valor da margem de cr\u00C3\u00A9dito que ele poder\u00C3\u00A1 utilizar para ser cobrado de forma consignada (desconto em folha) em seu sal\u00C3\u00A1rio/vencimentos.</param>
        /// <param name="limiteInternacionalCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para uso exclusivo em Compras Internacionais.</param>
        /// <param name="limiteInternacionalParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para realizar transa\u00C3\u00A7\u00C3\u00B5es Internacionais de Compras Parceladas.</param>
        /// <param name="limiteInternacionalParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que portador pode acumular a partir da soma das parcelas das compras internacionais que forem realizadas nesta modalidade.</param>
        /// <param name="limiteInternacionalSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Internacional.</param>
        /// <param name="limiteInternacionalSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Internacional dentro de cada ciclo de faturamento.</param>
        /// <returns>Task of ApiResponse (LimiteDisponibilidade)</returns>
        System.Threading.Tasks.Task<ApiResponse<LimiteDisponibilidade>> AlterarLimiteUsingPUTAsyncWithHttpInfo (long? id, double? limiteGlobal, double? limiteCompra, double? limiteParcelado, double? limiteParcelas, double? limiteSaqueGlobal, double? limiteSaquePeriodo, double? limiteConsignado, double? limiteInternacionalCompra, double? limiteInternacionalParcelado, double? limiteInternacionalParcelas, double? limiteInternacionalSaqueGlobal, double? limiteInternacionalSaquePeriodo);
        
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o do dia de vencimento das faturas da conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite alterar o vencimento de uma conta especifica.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="novoDiaVencimento">Novo dia de vencimento.</param>
        /// <returns>Task of Conta</returns>
        System.Threading.Tasks.Task<Conta> AlterarVencimentoUsingPUTAsync (long? id, int? novoDiaVencimento);

        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o do dia de vencimento das faturas da conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite alterar o vencimento de uma conta especifica.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="novoDiaVencimento">Novo dia de vencimento.</param>
        /// <returns>Task of ApiResponse (Conta)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conta>> AlterarVencimentoUsingPUTAsyncWithHttpInfo (long? id, int? novoDiaVencimento);
        
        /// <summary>
        ///  Ativa o servi\u00C3\u00A7o de envio de fatura por email
        /// </summary>
        /// <remarks>
        /// Este recurso ativa o servi\u00C3\u00A7o de envio de fatura por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> AtivarEnvioFaturaEmailUsingPOSTAsync (long? id);

        /// <summary>
        ///  Ativa o servi\u00C3\u00A7o de envio de fatura por email
        /// </summary>
        /// <remarks>
        /// Este recurso ativa o servi\u00C3\u00A7o de envio de fatura por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AtivarEnvioFaturaEmailUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta os dados de um determinado boleto da fatura
        /// </summary>
        /// <remarks>
        /// Este recurso consulta um boleto da fatura
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Task of BoletoDeFatura</returns>
        System.Threading.Tasks.Task<BoletoDeFatura> ConsultarBoletoEmitidoUsingGETAsync (long? id);

        /// <summary>
        /// Consulta os dados de um determinado boleto da fatura
        /// </summary>
        /// <remarks>
        /// Este recurso consulta um boleto da fatura
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Task of ApiResponse (BoletoDeFatura)</returns>
        System.Threading.Tasks.Task<ApiResponse<BoletoDeFatura>> ConsultarBoletoEmitidoUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta a d\u00C3\u00ADvida atualizada do cliente
        /// </summary>
        /// <remarks>
        /// Este recurso consulta a d\u00C3\u00ADvida atualizada do cliente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataVencimento">Data do vencimento (optional)</param>
        /// <param name="idEscritorioCobranca">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do escrit\u00C3\u00B3rio de cobran\u00C3\u00A7a (optional)</param>
        /// <returns>Task of DividaClienteResponse</returns>
        System.Threading.Tasks.Task<DividaClienteResponse> ConsultarDividaAtualizadaClienteUsingGETAsync (long? id, int? page = null, int? limit = null, DateTime? dataVencimento = null, long? idEscritorioCobranca = null);

        /// <summary>
        /// Consulta a d\u00C3\u00ADvida atualizada do cliente
        /// </summary>
        /// <remarks>
        /// Este recurso consulta a d\u00C3\u00ADvida atualizada do cliente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataVencimento">Data do vencimento (optional)</param>
        /// <param name="idEscritorioCobranca">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do escrit\u00C3\u00B3rio de cobran\u00C3\u00A7a (optional)</param>
        /// <returns>Task of ApiResponse (DividaClienteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DividaClienteResponse>> ConsultarDividaAtualizadaClienteUsingGETAsyncWithHttpInfo (long? id, int? page = null, int? limit = null, DateTime? dataVencimento = null, long? idEscritorioCobranca = null);
        
        /// <summary>
        /// Consultar a fatura consignadas abertas da conta
        /// </summary>
        /// <remarks>
        /// Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar a fatura consignada em aberto
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="dataVencimento">Data Vencimento.</param>
        /// <returns>Task of FaturaConsignadaResponse</returns>
        System.Threading.Tasks.Task<FaturaConsignadaResponse> ConsultarFaturaConsignadaAbertaUsingGETAsync (long? id, DateTime? dataVencimento);

        /// <summary>
        /// Consultar a fatura consignadas abertas da conta
        /// </summary>
        /// <remarks>
        /// Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar a fatura consignada em aberto
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="dataVencimento">Data Vencimento.</param>
        /// <returns>Task of ApiResponse (FaturaConsignadaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaturaConsignadaResponse>> ConsultarFaturaConsignadaAbertaUsingGETAsyncWithHttpInfo (long? id, DateTime? dataVencimento);
        
        /// <summary>
        /// Apresenta dados de uma determinada fatura consignada
        /// </summary>
        /// <remarks>
        /// Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar uma fatura, atrav\u00C3\u00A9s do id da conta e o id da fatura.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idFatura">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da fatura (id_fatura).</param>
        /// <returns>Task of FaturaConsignadaDetalheResponse</returns>
        System.Threading.Tasks.Task<FaturaConsignadaDetalheResponse> ConsultarFaturaConsignadaUsingGETAsync (long? id, long? idFatura);

        /// <summary>
        /// Apresenta dados de uma determinada fatura consignada
        /// </summary>
        /// <remarks>
        /// Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar uma fatura, atrav\u00C3\u00A9s do id da conta e o id da fatura.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idFatura">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da fatura (id_fatura).</param>
        /// <returns>Task of ApiResponse (FaturaConsignadaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaturaConsignadaDetalheResponse>> ConsultarFaturaConsignadaUsingGETAsyncWithHttpInfo (long? id, long? idFatura);
        
        /// <summary>
        /// Consultar Fatura da Conta
        /// </summary>
        /// <remarks>
        /// Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar os detalhes de uma fatura vinculados a uma determinada conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idFatura">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da fatura (id_fatura).</param>
        /// <returns>Task of DetalhesFaturaResponse</returns>
        System.Threading.Tasks.Task<DetalhesFaturaResponse> ConsultarFaturaUsingGETAsync (long? id, long? idFatura);

        /// <summary>
        /// Consultar Fatura da Conta
        /// </summary>
        /// <remarks>
        /// Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar os detalhes de uma fatura vinculados a uma determinada conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idFatura">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da fatura (id_fatura).</param>
        /// <returns>Task of ApiResponse (DetalhesFaturaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DetalhesFaturaResponse>> ConsultarFaturaUsingGETAsyncWithHttpInfo (long? id, long? idFatura);
        
        /// <summary>
        /// Consultar Lan\u00C3\u00A7amentos Futuros da Fatura de uma Conta
        /// </summary>
        /// <remarks>
        /// Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar os detalhes dos lan\u00C3\u00A7amentos futuros de uma fatura vinculados a uma determinada conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idFatura">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da fatura (id_fatura).</param>
        /// <returns>Task of DetalhesFaturaResponse</returns>
        System.Threading.Tasks.Task<DetalhesFaturaResponse> ConsultarLancamentosFuturosFaturaUsingGETAsync (long? id, long? idFatura);

        /// <summary>
        /// Consultar Lan\u00C3\u00A7amentos Futuros da Fatura de uma Conta
        /// </summary>
        /// <remarks>
        /// Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar os detalhes dos lan\u00C3\u00A7amentos futuros de uma fatura vinculados a uma determinada conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idFatura">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da fatura (id_fatura).</param>
        /// <returns>Task of ApiResponse (DetalhesFaturaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DetalhesFaturaResponse>> ConsultarLancamentosFuturosFaturaUsingGETAsyncWithHttpInfo (long? id, long? idFatura);
        
        /// <summary>
        /// Apresenta os limites da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os Limites configurados para uma determinada Conta, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Task of LimiteDisponibilidade</returns>
        System.Threading.Tasks.Task<LimiteDisponibilidade> ConsultarLimiteDisponibilidadeUsingGET1Async (long? id);

        /// <summary>
        /// Apresenta os limites da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os Limites configurados para uma determinada Conta, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Task of ApiResponse (LimiteDisponibilidade)</returns>
        System.Threading.Tasks.Task<ApiResponse<LimiteDisponibilidade>> ConsultarLimiteDisponibilidadeUsingGET1AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta os detalhes de uma determinada transfer\u00C3\u00AAncia
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os detalhes de uma determinada transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito realizada entre contas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idTransferencia">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id_transferencia).</param>
        /// <returns>Task of PageTransferencias</returns>
        System.Threading.Tasks.Task<PageTransferencias> ConsultarUsingGET21Async (long? id, long? idTransferencia);

        /// <summary>
        /// Consulta os detalhes de uma determinada transfer\u00C3\u00AAncia
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os detalhes de uma determinada transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito realizada entre contas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idTransferencia">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id_transferencia).</param>
        /// <returns>Task of ApiResponse (PageTransferencias)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransferencias>> ConsultarUsingGET21AsyncWithHttpInfo (long? id, long? idTransferencia);
        
        /// <summary>
        /// Apresenta dados de uma determinada conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar dados de uma determinada conta a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>Task of Conta</returns>
        System.Threading.Tasks.Task<Conta> ConsultarUsingGET3Async (long? id);

        /// <summary>
        /// Apresenta dados de uma determinada conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar dados de uma determinada conta a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>Task of ApiResponse (Conta)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conta>> ConsultarUsingGET3AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Desativa o servi\u00C3\u00A7o de envio de fatura por email
        /// </summary>
        /// <remarks>
        /// Este recurso desativa o servi\u00C3\u00A7o de envio de fatura por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> DesativarEnvioFaturaEmailUsingPOSTAsync (long? id);

        /// <summary>
        /// Desativa o servi\u00C3\u00A7o de envio de fatura por email
        /// </summary>
        /// <remarks>
        /// Este recurso desativa o servi\u00C3\u00A7o de envio de fatura por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DesativarEnvioFaturaEmailUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Gera um boleto de recarga
        /// </summary>
        /// <remarks>
        /// Este recurso gera um boleto de recarga
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="valor"></param>
        /// <param name="dataVencimento"></param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of BoletoDeFatura</returns>
        System.Threading.Tasks.Task<BoletoDeFatura> GerarBoletoRecargaUsingPOSTAsync (long? id, double? valor, DateTime? dataVencimento, int? page = null, int? limit = null);

        /// <summary>
        /// Gera um boleto de recarga
        /// </summary>
        /// <remarks>
        /// Este recurso gera um boleto de recarga
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="valor"></param>
        /// <param name="dataVencimento"></param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ApiResponse (BoletoDeFatura)</returns>
        System.Threading.Tasks.Task<ApiResponse<BoletoDeFatura>> GerarBoletoRecargaUsingPOSTAsyncWithHttpInfo (long? id, double? valor, DateTime? dataVencimento, int? page = null, int? limit = null);
        
        /// <summary>
        /// Realiza a gera\u00C3\u00A7\u00C3\u00A3o de um novo cart\u00C3\u00A3o para impress\u00C3\u00A3o avulsa
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja gerado um novo Cart\u00C3\u00A3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00C3\u00A3o que dever\u00C3\u00A1 ser gerado para impress\u00C3\u00A3o. Esta funcionalidade poder\u00C3\u00A1 ser utilizada para realizar a impress\u00C3\u00A3o de cart\u00C3\u00B5es em Lojas, Quiosques, Escrit\u00C3\u00B3rios, Terminais de Auto Atendimento, ou outro local que o Emissor escolher, desde que se possua uma impressora de Cart\u00C3\u00B5es habilidade para o fazer, no local.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da pessoa (id).</param>
        /// <param name="idTipoPlastico">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do TipoPlastico (id). (optional)</param>
        /// <returns>Task of CartaoImpressao</returns>
        System.Threading.Tasks.Task<CartaoImpressao> GerarCartaoUsingPOSTAsync (long? id, long? idPessoa, long? idTipoPlastico = null);

        /// <summary>
        /// Realiza a gera\u00C3\u00A7\u00C3\u00A3o de um novo cart\u00C3\u00A3o para impress\u00C3\u00A3o avulsa
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja gerado um novo Cart\u00C3\u00A3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00C3\u00A3o que dever\u00C3\u00A1 ser gerado para impress\u00C3\u00A3o. Esta funcionalidade poder\u00C3\u00A1 ser utilizada para realizar a impress\u00C3\u00A3o de cart\u00C3\u00B5es em Lojas, Quiosques, Escrit\u00C3\u00B3rios, Terminais de Auto Atendimento, ou outro local que o Emissor escolher, desde que se possua uma impressora de Cart\u00C3\u00B5es habilidade para o fazer, no local.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da pessoa (id).</param>
        /// <param name="idTipoPlastico">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do TipoPlastico (id). (optional)</param>
        /// <returns>Task of ApiResponse (CartaoImpressao)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoImpressao>> GerarCartaoUsingPOSTAsyncWithHttpInfo (long? id, long? idPessoa, long? idTipoPlastico = null);
        
        /// <summary>
        /// Lista as faturas consignadas da conta
        /// </summary>
        /// <remarks>
        /// Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar todo o Hist\u00C3\u00B3rico de Faturas vinculados a uma determinada Conta, independentemente do valor delas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataVencimento">Apresenta a data de vencimento da fatura. (optional)</param>
        /// <returns>Task of PageFaturasConsignadas</returns>
        System.Threading.Tasks.Task<PageFaturasConsignadas> ListarFaturasConsignadasUsingGETAsync (long? id, int? page = null, int? limit = null, DateTime? dataVencimento = null);

        /// <summary>
        /// Lista as faturas consignadas da conta
        /// </summary>
        /// <remarks>
        /// Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar todo o Hist\u00C3\u00B3rico de Faturas vinculados a uma determinada Conta, independentemente do valor delas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataVencimento">Apresenta a data de vencimento da fatura. (optional)</param>
        /// <returns>Task of ApiResponse (PageFaturasConsignadas)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageFaturasConsignadas>> ListarFaturasConsignadasUsingGETAsyncWithHttpInfo (long? id, int? page = null, int? limit = null, DateTime? dataVencimento = null);
        
        /// <summary>
        /// Lista as faturas da conta
        /// </summary>
        /// <remarks>
        /// Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar todo o Hist\u00C3\u00B3rico de Faturas vinculados a uma determinada Conta, independentemente do valor delas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataVencimento">Data de Vencimento da Fatura. (optional)</param>
        /// <returns>Task of PageFaturas</returns>
        System.Threading.Tasks.Task<PageFaturas> ListarFaturasUsingGETAsync (long? id, int? page = null, int? limit = null, DateTime? dataVencimento = null);

        /// <summary>
        /// Lista as faturas da conta
        /// </summary>
        /// <remarks>
        /// Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar todo o Hist\u00C3\u00B3rico de Faturas vinculados a uma determinada Conta, independentemente do valor delas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataVencimento">Data de Vencimento da Fatura. (optional)</param>
        /// <returns>Task of ApiResponse (PageFaturas)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageFaturas>> ListarFaturasUsingGETAsyncWithHttpInfo (long? id, int? page = null, int? limit = null, DateTime? dataVencimento = null);
        
        /// <summary>
        /// Lista o hist\u00C3\u00B3rico de altera\u00C3\u00A7\u00C3\u00B5es de limites da conta
        /// </summary>
        /// <remarks>
        /// Este recurso consulta o hist\u00C3\u00B3rico com as altera\u00C3\u00A7\u00C3\u00B5es de limites da conta informada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of PageHistoricoEventos</returns>
        System.Threading.Tasks.Task<PageHistoricoEventos> ListarHistoricoAlteracoesLimitesUsingGETAsync (long? id, int? page = null, int? limit = null);

        /// <summary>
        /// Lista o hist\u00C3\u00B3rico de altera\u00C3\u00A7\u00C3\u00B5es de limites da conta
        /// </summary>
        /// <remarks>
        /// Este recurso consulta o hist\u00C3\u00B3rico com as altera\u00C3\u00A7\u00C3\u00B5es de limites da conta informada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoEventos)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageHistoricoEventos>> ListarHistoricoAlteracoesLimitesUsingGETAsyncWithHttpInfo (long? id, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista o hist\u00C3\u00B3rico de entradas/sa\u00C3\u00ADdas de assessorias de cobran\u00C3\u00A7a
        /// </summary>
        /// <remarks>
        /// Permite listar todos os registros de entrada e sa\u00C3\u00ADda da Conta em arquivos de integra\u00C3\u00A7\u00C3\u00A3o com empresas de assessorias de cobran\u00C3\u00A7a a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (idConta).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of LinkPageHistoricoAssessoriaResponse</returns>
        System.Threading.Tasks.Task<LinkPageHistoricoAssessoriaResponse> ListarHistoricoAssessoriaUsingGETAsync (long? id, int? page = null, int? limit = null);

        /// <summary>
        /// Lista o hist\u00C3\u00B3rico de entradas/sa\u00C3\u00ADdas de assessorias de cobran\u00C3\u00A7a
        /// </summary>
        /// <remarks>
        /// Permite listar todos os registros de entrada e sa\u00C3\u00ADda da Conta em arquivos de integra\u00C3\u00A7\u00C3\u00A3o com empresas de assessorias de cobran\u00C3\u00A7a a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (idConta).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ApiResponse (LinkPageHistoricoAssessoriaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LinkPageHistoricoAssessoriaResponse>> ListarHistoricoAssessoriaUsingGETAsyncWithHttpInfo (long? id, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista o historico de atrasos das faturas
        /// </summary>
        /// <remarks>
        /// Este recurso lista o hist\u00C3\u00B3rico do pagamento de faturas em atraso
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Task of PageHistoricoAtraso</returns>
        System.Threading.Tasks.Task<PageHistoricoAtraso> ListarHistoricoAtrasosFaturasUsingGETAsync (long? id);

        /// <summary>
        /// Lista o historico de atrasos das faturas
        /// </summary>
        /// <remarks>
        /// Este recurso lista o hist\u00C3\u00B3rico do pagamento de faturas em atraso
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Task of ApiResponse (PageHistoricoAtraso)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageHistoricoAtraso>> ListarHistoricoAtrasosFaturasUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista as transa\u00C3\u00A7\u00C3\u00B5es n\u00C3\u00A3o processadas da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas todas as transa\u00C3\u00A7\u00C3\u00B5es n\u00C3\u00A3o processadas da Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of PageTransacoesCorrentes</returns>
        System.Threading.Tasks.Task<PageTransacoesCorrentes> ListarNaoProcessadasUsingGETAsync (long? id, int? page = null, int? limit = null);

        /// <summary>
        /// Lista as transa\u00C3\u00A7\u00C3\u00B5es n\u00C3\u00A3o processadas da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas todas as transa\u00C3\u00A7\u00C3\u00B5es n\u00C3\u00A3o processadas da Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacoesCorrentes)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransacoesCorrentes>> ListarNaoProcessadasUsingGETAsyncWithHttpInfo (long? id, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista as transa\u00C3\u00A7\u00C3\u00B5es processadas da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas todas as transa\u00C3\u00A7\u00C3\u00B5es processadas da Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataVencimento">Data de vencimento do extrato no formato yyyy-MM-dd. (optional)</param>
        /// <returns>Task of PageTransacoesCorrentes</returns>
        System.Threading.Tasks.Task<PageTransacoesCorrentes> ListarProcessadasUsingGETAsync (long? id, int? page = null, int? limit = null, DateTime? dataVencimento = null);

        /// <summary>
        /// Lista as transa\u00C3\u00A7\u00C3\u00B5es processadas da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas todas as transa\u00C3\u00A7\u00C3\u00B5es processadas da Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataVencimento">Data de vencimento do extrato no formato yyyy-MM-dd. (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacoesCorrentes)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransacoesCorrentes>> ListarProcessadasUsingGETAsyncWithHttpInfo (long? id, int? page = null, int? limit = null, DateTime? dataVencimento = null);
        
        /// <summary>
        /// Lista as transfer\u00C3\u00AAncias realizadas pela conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as transfer\u00C3\u00AAncias realizadas pela conta existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="idTransferencia">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id). (optional)</param>
        /// <param name="idContaOrigem">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 debitado para a transfer\u00C3\u00AAncia. (id). (optional)</param>
        /// <param name="idContaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 creditado para a transfer\u00C3\u00AAncia. (id). (optional)</param>
        /// <param name="valorTransferencia">Valor estabelecido para ser transferido. (optional)</param>
        /// <param name="dataTransferencia">Data estabelecida para ocorrer a transfer\u00C3\u00AAncia. (optional)</param>
        /// <returns>Task of PageTransferencias</returns>
        System.Threading.Tasks.Task<PageTransferencias> ListarUsingGET20Async (long? id, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, DateTime? dataTransferencia = null);

        /// <summary>
        /// Lista as transfer\u00C3\u00AAncias realizadas pela conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as transfer\u00C3\u00AAncias realizadas pela conta existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="idTransferencia">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id). (optional)</param>
        /// <param name="idContaOrigem">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 debitado para a transfer\u00C3\u00AAncia. (id). (optional)</param>
        /// <param name="idContaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 creditado para a transfer\u00C3\u00AAncia. (id). (optional)</param>
        /// <param name="valorTransferencia">Valor estabelecido para ser transferido. (optional)</param>
        /// <param name="dataTransferencia">Data estabelecida para ocorrer a transfer\u00C3\u00AAncia. (optional)</param>
        /// <returns>Task of ApiResponse (PageTransferencias)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransferencias>> ListarUsingGET20AsyncWithHttpInfo (long? id, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, DateTime? dataTransferencia = null);
        
        /// <summary>
        /// Lista contas existentes na base de dados do Emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar contas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do produto ao qual a conta faz parte. (id). (optional)</param>
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id) que deu origem a Conta. (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa Titular da Conta (id). (optional)</param>
        /// <param name="idStatusConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="diaVencimento">Apresenta o dia de vencimento. (optional)</param>
        /// <param name="melhorDiaCompra">Apresenta o melhor dia de compra. (optional)</param>
        /// <param name="dataStatusConta">Apresenta a data em que o idStatusConta atual fora atribu\u00C3\u00ADdo para ela. (optional)</param>
        /// <param name="dataCadastro">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param>
        /// <param name="dataUltimaAlteracaoVencimento">Apresenta a data da ultima altera\u00C3\u00A7\u00C3\u00A3o de vencimento. (optional)</param>
        /// <returns>Task of PageContas</returns>
        System.Threading.Tasks.Task<PageContas> ListarUsingGET3Async (int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, DateTime? dataStatusConta = null, DateTime? dataCadastro = null, DateTime? dataUltimaAlteracaoVencimento = null);

        /// <summary>
        /// Lista contas existentes na base de dados do Emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar contas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do produto ao qual a conta faz parte. (id). (optional)</param>
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id) que deu origem a Conta. (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa Titular da Conta (id). (optional)</param>
        /// <param name="idStatusConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="diaVencimento">Apresenta o dia de vencimento. (optional)</param>
        /// <param name="melhorDiaCompra">Apresenta o melhor dia de compra. (optional)</param>
        /// <param name="dataStatusConta">Apresenta a data em que o idStatusConta atual fora atribu\u00C3\u00ADdo para ela. (optional)</param>
        /// <param name="dataCadastro">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param>
        /// <param name="dataUltimaAlteracaoVencimento">Apresenta a data da ultima altera\u00C3\u00A7\u00C3\u00A3o de vencimento. (optional)</param>
        /// <returns>Task of ApiResponse (PageContas)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageContas>> ListarUsingGET3AsyncWithHttpInfo (int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, DateTime? dataStatusConta = null, DateTime? dataCadastro = null, DateTime? dataUltimaAlteracaoVencimento = null);
        
        /// <summary>
        /// Realiza a reativa\u00C3\u00A7\u00C3\u00A3o de contas que foram desativadas por inadimpl\u00C3\u00AAncia
        /// </summary>
        /// <remarks>
        /// Este recurso permite reativar contas que foram desativadas por inadimpl\u00C3\u00AAncia. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ReativarUsingPOSTAsync (long? id);

        /// <summary>
        /// Realiza a reativa\u00C3\u00A7\u00C3\u00A3o de contas que foram desativadas por inadimpl\u00C3\u00AAncia
        /// </summary>
        /// <remarks>
        /// Este recurso permite reativar contas que foram desativadas por inadimpl\u00C3\u00AAncia. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ReativarUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Permite listar uma linha do tempo com os eventos da conta
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir a listagem, em formato de timeline, dos eventos vinculados a uma detemrinada conta. Transa\u00C3\u00A7\u00C3\u00B5es, fechamento da fatura, pagamentos, gera\u00C3\u00A7\u00C3\u00A3o de cart\u00C3\u00B5es e altera\u00C3\u00A7\u00C3\u00A3o de limite s\u00C3\u00A3o exemplos de eventos contemplados por esta funcionalidade. Neste m\u00C3\u00A9todo, as opera\u00C3\u00A7\u00C3\u00B5es s\u00C3\u00A3o ordenadas de forma decrescente.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of PageTransacaoResponse</returns>
        System.Threading.Tasks.Task<PageTransacaoResponse> TransacoesUsingGETAsync (long? id, int? page = null, int? limit = null);

        /// <summary>
        /// Permite listar uma linha do tempo com os eventos da conta
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir a listagem, em formato de timeline, dos eventos vinculados a uma detemrinada conta. Transa\u00C3\u00A7\u00C3\u00B5es, fechamento da fatura, pagamentos, gera\u00C3\u00A7\u00C3\u00A3o de cart\u00C3\u00B5es e altera\u00C3\u00A7\u00C3\u00A3o de limite s\u00C3\u00A3o exemplos de eventos contemplados por esta funcionalidade. Neste m\u00C3\u00A9todo, as opera\u00C3\u00A7\u00C3\u00B5es s\u00C3\u00A3o ordenadas de forma decrescente.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransacaoResponse>> TransacoesUsingGETAsyncWithHttpInfo (long? id, int? page = null, int? limit = null);
        
        /// <summary>
        /// Realiza uma transfer\u00C3\u00AAncia de Cr\u00C3\u00A9dito para outro cliente do mesmo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que um portador de um cart\u00C3\u00A3o possa realizar auma transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para outro cliente do mesmo emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do cliente portador do cart\u00C3\u00A3o que ser\u00C3\u00A1 debitado (id).</param>
        /// <param name="idContaDestino">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do cliente portador do cart\u00C3\u00A3o que ser\u00C3\u00A1 creditado (id).</param>
        /// <param name="valorTransferencia">Valor da Transfer\u00C3\u00AAncia.</param>
        /// <returns>Task of PageTransferencias</returns>
        System.Threading.Tasks.Task<PageTransferencias> TransferirUsingPOST1Async (long? id, long? idContaDestino, double? valorTransferencia);

        /// <summary>
        /// Realiza uma transfer\u00C3\u00AAncia de Cr\u00C3\u00A9dito para outro cliente do mesmo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que um portador de um cart\u00C3\u00A3o possa realizar auma transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para outro cliente do mesmo emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do cliente portador do cart\u00C3\u00A3o que ser\u00C3\u00A1 debitado (id).</param>
        /// <param name="idContaDestino">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do cliente portador do cart\u00C3\u00A3o que ser\u00C3\u00A1 creditado (id).</param>
        /// <param name="valorTransferencia">Valor da Transfer\u00C3\u00AAncia.</param>
        /// <returns>Task of ApiResponse (PageTransferencias)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransferencias>> TransferirUsingPOST1AsyncWithHttpInfo (long? id, long? idContaDestino, double? valorTransferencia);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ContaApi : IContaApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ContaApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ContaApi(Configuration configuration = null)
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
        /// Lan\u00C3\u00A7a um ajuste para a conta do id informado Este recurso insere um ajuste para a conta do id informado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="idTipoAjuste">C\u00C3\u00B3digo identificador do tipo de ajuste.</param> 
        /// <param name="dataAjuste">Data do ajuste.</param> 
        /// <param name="valorAjuste">Valor do ajuste</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <returns>AjusteResponse</returns>
        public AjusteResponse AjustarContaUsingPOST (long? id, long? idTipoAjuste, DateTime? dataAjuste, double? valorAjuste, int? page = null, int? limit = null)
        {
             ApiResponse<AjusteResponse> localVarResponse = AjustarContaUsingPOSTWithHttpInfo(id, idTipoAjuste, dataAjuste, valorAjuste, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lan\u00C3\u00A7a um ajuste para a conta do id informado Este recurso insere um ajuste para a conta do id informado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="idTipoAjuste">C\u00C3\u00B3digo identificador do tipo de ajuste.</param> 
        /// <param name="dataAjuste">Data do ajuste.</param> 
        /// <param name="valorAjuste">Valor do ajuste</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <returns>ApiResponse of AjusteResponse</returns>
        public ApiResponse< AjusteResponse > AjustarContaUsingPOSTWithHttpInfo (long? id, long? idTipoAjuste, DateTime? dataAjuste, double? valorAjuste, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->AjustarContaUsingPOST");
            
            // verify the required parameter 'idTipoAjuste' is set
            if (idTipoAjuste == null)
                throw new ApiException(400, "Missing required parameter 'idTipoAjuste' when calling ContaApi->AjustarContaUsingPOST");
            
            // verify the required parameter 'dataAjuste' is set
            if (dataAjuste == null)
                throw new ApiException(400, "Missing required parameter 'dataAjuste' when calling ContaApi->AjustarContaUsingPOST");
            
            // verify the required parameter 'valorAjuste' is set
            if (valorAjuste == null)
                throw new ApiException(400, "Missing required parameter 'valorAjuste' when calling ContaApi->AjustarContaUsingPOST");
            
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (idTipoAjuste != null) localVarQueryParams.Add("idTipoAjuste", Configuration.ApiClient.ParameterToString(idTipoAjuste)); // query parameter
            if (dataAjuste != null) localVarQueryParams.Add("dataAjuste", Configuration.ApiClient.ParameterToString(dataAjuste)); // query parameter
            if (valorAjuste != null) localVarQueryParams.Add("valorAjuste", Configuration.ApiClient.ParameterToString(valorAjuste)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AjustarContaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AjustarContaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AjusteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AjusteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AjusteResponse)));
            
        }

        
        /// <summary>
        /// Lan\u00C3\u00A7a um ajuste para a conta do id informado Este recurso insere um ajuste para a conta do id informado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idTipoAjuste">C\u00C3\u00B3digo identificador do tipo de ajuste.</param>
        /// <param name="dataAjuste">Data do ajuste.</param>
        /// <param name="valorAjuste">Valor do ajuste</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of AjusteResponse</returns>
        public async System.Threading.Tasks.Task<AjusteResponse> AjustarContaUsingPOSTAsync (long? id, long? idTipoAjuste, DateTime? dataAjuste, double? valorAjuste, int? page = null, int? limit = null)
        {
             ApiResponse<AjusteResponse> localVarResponse = await AjustarContaUsingPOSTAsyncWithHttpInfo(id, idTipoAjuste, dataAjuste, valorAjuste, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lan\u00C3\u00A7a um ajuste para a conta do id informado Este recurso insere um ajuste para a conta do id informado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idTipoAjuste">C\u00C3\u00B3digo identificador do tipo de ajuste.</param>
        /// <param name="dataAjuste">Data do ajuste.</param>
        /// <param name="valorAjuste">Valor do ajuste</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ApiResponse (AjusteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AjusteResponse>> AjustarContaUsingPOSTAsyncWithHttpInfo (long? id, long? idTipoAjuste, DateTime? dataAjuste, double? valorAjuste, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AjustarContaUsingPOST");
            // verify the required parameter 'idTipoAjuste' is set
            if (idTipoAjuste == null) throw new ApiException(400, "Missing required parameter 'idTipoAjuste' when calling AjustarContaUsingPOST");
            // verify the required parameter 'dataAjuste' is set
            if (dataAjuste == null) throw new ApiException(400, "Missing required parameter 'dataAjuste' when calling AjustarContaUsingPOST");
            // verify the required parameter 'valorAjuste' is set
            if (valorAjuste == null) throw new ApiException(400, "Missing required parameter 'valorAjuste' when calling AjustarContaUsingPOST");
            
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (idTipoAjuste != null) localVarQueryParams.Add("idTipoAjuste", Configuration.ApiClient.ParameterToString(idTipoAjuste)); // query parameter
            if (dataAjuste != null) localVarQueryParams.Add("dataAjuste", Configuration.ApiClient.ParameterToString(dataAjuste)); // query parameter
            if (valorAjuste != null) localVarQueryParams.Add("valorAjuste", Configuration.ApiClient.ParameterToString(valorAjuste)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AjustarContaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AjustarContaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AjusteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AjusteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AjusteResponse)));
            
        }
        
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o dos limites da conta Esse recurso permite realizar a altera\u00C3\u00A7\u00C3\u00A3o dos Limites de uma determinada Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="limiteGlobal">Apresenta o valor do limite de cr\u00C3\u00A9dito que o portador do cart\u00C3\u00A3o possui.</param> 
        /// <param name="limiteCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para uso exclusivo em Compras Nacionais.</param> 
        /// <param name="limiteParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para realizar transa\u00C3\u00A7\u00C3\u00B5es de compras parceladas.</param> 
        /// <param name="limiteParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que portador pode acumular a partir da soma das parcelas das compras que forem realizadas nesta modalidade.</param> 
        /// <param name="limiteSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional.</param> 
        /// <param name="limiteSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional dentro de cada ciclo de faturamento.</param> 
        /// <param name="limiteConsignado">Quando utilizado pelo emissor, este campo apresenta o valor da margem de cr\u00C3\u00A9dito que ele poder\u00C3\u00A1 utilizar para ser cobrado de forma consignada (desconto em folha) em seu sal\u00C3\u00A1rio/vencimentos.</param> 
        /// <param name="limiteInternacionalCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para uso exclusivo em Compras Internacionais.</param> 
        /// <param name="limiteInternacionalParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para realizar transa\u00C3\u00A7\u00C3\u00B5es Internacionais de Compras Parceladas.</param> 
        /// <param name="limiteInternacionalParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que portador pode acumular a partir da soma das parcelas das compras internacionais que forem realizadas nesta modalidade.</param> 
        /// <param name="limiteInternacionalSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Internacional.</param> 
        /// <param name="limiteInternacionalSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Internacional dentro de cada ciclo de faturamento.</param> 
        /// <returns>LimiteDisponibilidade</returns>
        public LimiteDisponibilidade AlterarLimiteUsingPUT (long? id, double? limiteGlobal, double? limiteCompra, double? limiteParcelado, double? limiteParcelas, double? limiteSaqueGlobal, double? limiteSaquePeriodo, double? limiteConsignado, double? limiteInternacionalCompra, double? limiteInternacionalParcelado, double? limiteInternacionalParcelas, double? limiteInternacionalSaqueGlobal, double? limiteInternacionalSaquePeriodo)
        {
             ApiResponse<LimiteDisponibilidade> localVarResponse = AlterarLimiteUsingPUTWithHttpInfo(id, limiteGlobal, limiteCompra, limiteParcelado, limiteParcelas, limiteSaqueGlobal, limiteSaquePeriodo, limiteConsignado, limiteInternacionalCompra, limiteInternacionalParcelado, limiteInternacionalParcelas, limiteInternacionalSaqueGlobal, limiteInternacionalSaquePeriodo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o dos limites da conta Esse recurso permite realizar a altera\u00C3\u00A7\u00C3\u00A3o dos Limites de uma determinada Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="limiteGlobal">Apresenta o valor do limite de cr\u00C3\u00A9dito que o portador do cart\u00C3\u00A3o possui.</param> 
        /// <param name="limiteCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para uso exclusivo em Compras Nacionais.</param> 
        /// <param name="limiteParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para realizar transa\u00C3\u00A7\u00C3\u00B5es de compras parceladas.</param> 
        /// <param name="limiteParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que portador pode acumular a partir da soma das parcelas das compras que forem realizadas nesta modalidade.</param> 
        /// <param name="limiteSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional.</param> 
        /// <param name="limiteSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional dentro de cada ciclo de faturamento.</param> 
        /// <param name="limiteConsignado">Quando utilizado pelo emissor, este campo apresenta o valor da margem de cr\u00C3\u00A9dito que ele poder\u00C3\u00A1 utilizar para ser cobrado de forma consignada (desconto em folha) em seu sal\u00C3\u00A1rio/vencimentos.</param> 
        /// <param name="limiteInternacionalCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para uso exclusivo em Compras Internacionais.</param> 
        /// <param name="limiteInternacionalParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para realizar transa\u00C3\u00A7\u00C3\u00B5es Internacionais de Compras Parceladas.</param> 
        /// <param name="limiteInternacionalParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que portador pode acumular a partir da soma das parcelas das compras internacionais que forem realizadas nesta modalidade.</param> 
        /// <param name="limiteInternacionalSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Internacional.</param> 
        /// <param name="limiteInternacionalSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Internacional dentro de cada ciclo de faturamento.</param> 
        /// <returns>ApiResponse of LimiteDisponibilidade</returns>
        public ApiResponse< LimiteDisponibilidade > AlterarLimiteUsingPUTWithHttpInfo (long? id, double? limiteGlobal, double? limiteCompra, double? limiteParcelado, double? limiteParcelas, double? limiteSaqueGlobal, double? limiteSaquePeriodo, double? limiteConsignado, double? limiteInternacionalCompra, double? limiteInternacionalParcelado, double? limiteInternacionalParcelas, double? limiteInternacionalSaqueGlobal, double? limiteInternacionalSaquePeriodo)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->AlterarLimiteUsingPUT");
            
            // verify the required parameter 'limiteGlobal' is set
            if (limiteGlobal == null)
                throw new ApiException(400, "Missing required parameter 'limiteGlobal' when calling ContaApi->AlterarLimiteUsingPUT");
            
            // verify the required parameter 'limiteCompra' is set
            if (limiteCompra == null)
                throw new ApiException(400, "Missing required parameter 'limiteCompra' when calling ContaApi->AlterarLimiteUsingPUT");
            
            // verify the required parameter 'limiteParcelado' is set
            if (limiteParcelado == null)
                throw new ApiException(400, "Missing required parameter 'limiteParcelado' when calling ContaApi->AlterarLimiteUsingPUT");
            
            // verify the required parameter 'limiteParcelas' is set
            if (limiteParcelas == null)
                throw new ApiException(400, "Missing required parameter 'limiteParcelas' when calling ContaApi->AlterarLimiteUsingPUT");
            
            // verify the required parameter 'limiteSaqueGlobal' is set
            if (limiteSaqueGlobal == null)
                throw new ApiException(400, "Missing required parameter 'limiteSaqueGlobal' when calling ContaApi->AlterarLimiteUsingPUT");
            
            // verify the required parameter 'limiteSaquePeriodo' is set
            if (limiteSaquePeriodo == null)
                throw new ApiException(400, "Missing required parameter 'limiteSaquePeriodo' when calling ContaApi->AlterarLimiteUsingPUT");
            
            // verify the required parameter 'limiteConsignado' is set
            if (limiteConsignado == null)
                throw new ApiException(400, "Missing required parameter 'limiteConsignado' when calling ContaApi->AlterarLimiteUsingPUT");
            
            // verify the required parameter 'limiteInternacionalCompra' is set
            if (limiteInternacionalCompra == null)
                throw new ApiException(400, "Missing required parameter 'limiteInternacionalCompra' when calling ContaApi->AlterarLimiteUsingPUT");
            
            // verify the required parameter 'limiteInternacionalParcelado' is set
            if (limiteInternacionalParcelado == null)
                throw new ApiException(400, "Missing required parameter 'limiteInternacionalParcelado' when calling ContaApi->AlterarLimiteUsingPUT");
            
            // verify the required parameter 'limiteInternacionalParcelas' is set
            if (limiteInternacionalParcelas == null)
                throw new ApiException(400, "Missing required parameter 'limiteInternacionalParcelas' when calling ContaApi->AlterarLimiteUsingPUT");
            
            // verify the required parameter 'limiteInternacionalSaqueGlobal' is set
            if (limiteInternacionalSaqueGlobal == null)
                throw new ApiException(400, "Missing required parameter 'limiteInternacionalSaqueGlobal' when calling ContaApi->AlterarLimiteUsingPUT");
            
            // verify the required parameter 'limiteInternacionalSaquePeriodo' is set
            if (limiteInternacionalSaquePeriodo == null)
                throw new ApiException(400, "Missing required parameter 'limiteInternacionalSaquePeriodo' when calling ContaApi->AlterarLimiteUsingPUT");
            
    
            var localVarPath = "/api/contas/{id}/alterar-limites";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (limiteGlobal != null) localVarQueryParams.Add("limiteGlobal", Configuration.ApiClient.ParameterToString(limiteGlobal)); // query parameter
            if (limiteCompra != null) localVarQueryParams.Add("limiteCompra", Configuration.ApiClient.ParameterToString(limiteCompra)); // query parameter
            if (limiteParcelado != null) localVarQueryParams.Add("limiteParcelado", Configuration.ApiClient.ParameterToString(limiteParcelado)); // query parameter
            if (limiteParcelas != null) localVarQueryParams.Add("limiteParcelas", Configuration.ApiClient.ParameterToString(limiteParcelas)); // query parameter
            if (limiteSaqueGlobal != null) localVarQueryParams.Add("limiteSaqueGlobal", Configuration.ApiClient.ParameterToString(limiteSaqueGlobal)); // query parameter
            if (limiteSaquePeriodo != null) localVarQueryParams.Add("limiteSaquePeriodo", Configuration.ApiClient.ParameterToString(limiteSaquePeriodo)); // query parameter
            if (limiteConsignado != null) localVarQueryParams.Add("limiteConsignado", Configuration.ApiClient.ParameterToString(limiteConsignado)); // query parameter
            if (limiteInternacionalCompra != null) localVarQueryParams.Add("limiteInternacionalCompra", Configuration.ApiClient.ParameterToString(limiteInternacionalCompra)); // query parameter
            if (limiteInternacionalParcelado != null) localVarQueryParams.Add("limiteInternacionalParcelado", Configuration.ApiClient.ParameterToString(limiteInternacionalParcelado)); // query parameter
            if (limiteInternacionalParcelas != null) localVarQueryParams.Add("limiteInternacionalParcelas", Configuration.ApiClient.ParameterToString(limiteInternacionalParcelas)); // query parameter
            if (limiteInternacionalSaqueGlobal != null) localVarQueryParams.Add("limiteInternacionalSaqueGlobal", Configuration.ApiClient.ParameterToString(limiteInternacionalSaqueGlobal)); // query parameter
            if (limiteInternacionalSaquePeriodo != null) localVarQueryParams.Add("limiteInternacionalSaquePeriodo", Configuration.ApiClient.ParameterToString(limiteInternacionalSaquePeriodo)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarLimiteUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarLimiteUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LimiteDisponibilidade>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LimiteDisponibilidade) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimiteDisponibilidade)));
            
        }

        
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o dos limites da conta Esse recurso permite realizar a altera\u00C3\u00A7\u00C3\u00A3o dos Limites de uma determinada Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="limiteGlobal">Apresenta o valor do limite de cr\u00C3\u00A9dito que o portador do cart\u00C3\u00A3o possui.</param>
        /// <param name="limiteCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para uso exclusivo em Compras Nacionais.</param>
        /// <param name="limiteParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para realizar transa\u00C3\u00A7\u00C3\u00B5es de compras parceladas.</param>
        /// <param name="limiteParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que portador pode acumular a partir da soma das parcelas das compras que forem realizadas nesta modalidade.</param>
        /// <param name="limiteSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional.</param>
        /// <param name="limiteSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional dentro de cada ciclo de faturamento.</param>
        /// <param name="limiteConsignado">Quando utilizado pelo emissor, este campo apresenta o valor da margem de cr\u00C3\u00A9dito que ele poder\u00C3\u00A1 utilizar para ser cobrado de forma consignada (desconto em folha) em seu sal\u00C3\u00A1rio/vencimentos.</param>
        /// <param name="limiteInternacionalCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para uso exclusivo em Compras Internacionais.</param>
        /// <param name="limiteInternacionalParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para realizar transa\u00C3\u00A7\u00C3\u00B5es Internacionais de Compras Parceladas.</param>
        /// <param name="limiteInternacionalParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que portador pode acumular a partir da soma das parcelas das compras internacionais que forem realizadas nesta modalidade.</param>
        /// <param name="limiteInternacionalSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Internacional.</param>
        /// <param name="limiteInternacionalSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Internacional dentro de cada ciclo de faturamento.</param>
        /// <returns>Task of LimiteDisponibilidade</returns>
        public async System.Threading.Tasks.Task<LimiteDisponibilidade> AlterarLimiteUsingPUTAsync (long? id, double? limiteGlobal, double? limiteCompra, double? limiteParcelado, double? limiteParcelas, double? limiteSaqueGlobal, double? limiteSaquePeriodo, double? limiteConsignado, double? limiteInternacionalCompra, double? limiteInternacionalParcelado, double? limiteInternacionalParcelas, double? limiteInternacionalSaqueGlobal, double? limiteInternacionalSaquePeriodo)
        {
             ApiResponse<LimiteDisponibilidade> localVarResponse = await AlterarLimiteUsingPUTAsyncWithHttpInfo(id, limiteGlobal, limiteCompra, limiteParcelado, limiteParcelas, limiteSaqueGlobal, limiteSaquePeriodo, limiteConsignado, limiteInternacionalCompra, limiteInternacionalParcelado, limiteInternacionalParcelas, limiteInternacionalSaqueGlobal, limiteInternacionalSaquePeriodo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o dos limites da conta Esse recurso permite realizar a altera\u00C3\u00A7\u00C3\u00A3o dos Limites de uma determinada Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="limiteGlobal">Apresenta o valor do limite de cr\u00C3\u00A9dito que o portador do cart\u00C3\u00A3o possui.</param>
        /// <param name="limiteCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para uso exclusivo em Compras Nacionais.</param>
        /// <param name="limiteParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para realizar transa\u00C3\u00A7\u00C3\u00B5es de compras parceladas.</param>
        /// <param name="limiteParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que portador pode acumular a partir da soma das parcelas das compras que forem realizadas nesta modalidade.</param>
        /// <param name="limiteSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional.</param>
        /// <param name="limiteSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional dentro de cada ciclo de faturamento.</param>
        /// <param name="limiteConsignado">Quando utilizado pelo emissor, este campo apresenta o valor da margem de cr\u00C3\u00A9dito que ele poder\u00C3\u00A1 utilizar para ser cobrado de forma consignada (desconto em folha) em seu sal\u00C3\u00A1rio/vencimentos.</param>
        /// <param name="limiteInternacionalCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para uso exclusivo em Compras Internacionais.</param>
        /// <param name="limiteInternacionalParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para realizar transa\u00C3\u00A7\u00C3\u00B5es Internacionais de Compras Parceladas.</param>
        /// <param name="limiteInternacionalParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que portador pode acumular a partir da soma das parcelas das compras internacionais que forem realizadas nesta modalidade.</param>
        /// <param name="limiteInternacionalSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Internacional.</param>
        /// <param name="limiteInternacionalSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Internacional dentro de cada ciclo de faturamento.</param>
        /// <returns>Task of ApiResponse (LimiteDisponibilidade)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LimiteDisponibilidade>> AlterarLimiteUsingPUTAsyncWithHttpInfo (long? id, double? limiteGlobal, double? limiteCompra, double? limiteParcelado, double? limiteParcelas, double? limiteSaqueGlobal, double? limiteSaquePeriodo, double? limiteConsignado, double? limiteInternacionalCompra, double? limiteInternacionalParcelado, double? limiteInternacionalParcelas, double? limiteInternacionalSaqueGlobal, double? limiteInternacionalSaquePeriodo)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarLimiteUsingPUT");
            // verify the required parameter 'limiteGlobal' is set
            if (limiteGlobal == null) throw new ApiException(400, "Missing required parameter 'limiteGlobal' when calling AlterarLimiteUsingPUT");
            // verify the required parameter 'limiteCompra' is set
            if (limiteCompra == null) throw new ApiException(400, "Missing required parameter 'limiteCompra' when calling AlterarLimiteUsingPUT");
            // verify the required parameter 'limiteParcelado' is set
            if (limiteParcelado == null) throw new ApiException(400, "Missing required parameter 'limiteParcelado' when calling AlterarLimiteUsingPUT");
            // verify the required parameter 'limiteParcelas' is set
            if (limiteParcelas == null) throw new ApiException(400, "Missing required parameter 'limiteParcelas' when calling AlterarLimiteUsingPUT");
            // verify the required parameter 'limiteSaqueGlobal' is set
            if (limiteSaqueGlobal == null) throw new ApiException(400, "Missing required parameter 'limiteSaqueGlobal' when calling AlterarLimiteUsingPUT");
            // verify the required parameter 'limiteSaquePeriodo' is set
            if (limiteSaquePeriodo == null) throw new ApiException(400, "Missing required parameter 'limiteSaquePeriodo' when calling AlterarLimiteUsingPUT");
            // verify the required parameter 'limiteConsignado' is set
            if (limiteConsignado == null) throw new ApiException(400, "Missing required parameter 'limiteConsignado' when calling AlterarLimiteUsingPUT");
            // verify the required parameter 'limiteInternacionalCompra' is set
            if (limiteInternacionalCompra == null) throw new ApiException(400, "Missing required parameter 'limiteInternacionalCompra' when calling AlterarLimiteUsingPUT");
            // verify the required parameter 'limiteInternacionalParcelado' is set
            if (limiteInternacionalParcelado == null) throw new ApiException(400, "Missing required parameter 'limiteInternacionalParcelado' when calling AlterarLimiteUsingPUT");
            // verify the required parameter 'limiteInternacionalParcelas' is set
            if (limiteInternacionalParcelas == null) throw new ApiException(400, "Missing required parameter 'limiteInternacionalParcelas' when calling AlterarLimiteUsingPUT");
            // verify the required parameter 'limiteInternacionalSaqueGlobal' is set
            if (limiteInternacionalSaqueGlobal == null) throw new ApiException(400, "Missing required parameter 'limiteInternacionalSaqueGlobal' when calling AlterarLimiteUsingPUT");
            // verify the required parameter 'limiteInternacionalSaquePeriodo' is set
            if (limiteInternacionalSaquePeriodo == null) throw new ApiException(400, "Missing required parameter 'limiteInternacionalSaquePeriodo' when calling AlterarLimiteUsingPUT");
            
    
            var localVarPath = "/api/contas/{id}/alterar-limites";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (limiteGlobal != null) localVarQueryParams.Add("limiteGlobal", Configuration.ApiClient.ParameterToString(limiteGlobal)); // query parameter
            if (limiteCompra != null) localVarQueryParams.Add("limiteCompra", Configuration.ApiClient.ParameterToString(limiteCompra)); // query parameter
            if (limiteParcelado != null) localVarQueryParams.Add("limiteParcelado", Configuration.ApiClient.ParameterToString(limiteParcelado)); // query parameter
            if (limiteParcelas != null) localVarQueryParams.Add("limiteParcelas", Configuration.ApiClient.ParameterToString(limiteParcelas)); // query parameter
            if (limiteSaqueGlobal != null) localVarQueryParams.Add("limiteSaqueGlobal", Configuration.ApiClient.ParameterToString(limiteSaqueGlobal)); // query parameter
            if (limiteSaquePeriodo != null) localVarQueryParams.Add("limiteSaquePeriodo", Configuration.ApiClient.ParameterToString(limiteSaquePeriodo)); // query parameter
            if (limiteConsignado != null) localVarQueryParams.Add("limiteConsignado", Configuration.ApiClient.ParameterToString(limiteConsignado)); // query parameter
            if (limiteInternacionalCompra != null) localVarQueryParams.Add("limiteInternacionalCompra", Configuration.ApiClient.ParameterToString(limiteInternacionalCompra)); // query parameter
            if (limiteInternacionalParcelado != null) localVarQueryParams.Add("limiteInternacionalParcelado", Configuration.ApiClient.ParameterToString(limiteInternacionalParcelado)); // query parameter
            if (limiteInternacionalParcelas != null) localVarQueryParams.Add("limiteInternacionalParcelas", Configuration.ApiClient.ParameterToString(limiteInternacionalParcelas)); // query parameter
            if (limiteInternacionalSaqueGlobal != null) localVarQueryParams.Add("limiteInternacionalSaqueGlobal", Configuration.ApiClient.ParameterToString(limiteInternacionalSaqueGlobal)); // query parameter
            if (limiteInternacionalSaquePeriodo != null) localVarQueryParams.Add("limiteInternacionalSaquePeriodo", Configuration.ApiClient.ParameterToString(limiteInternacionalSaquePeriodo)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarLimiteUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarLimiteUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LimiteDisponibilidade>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LimiteDisponibilidade) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimiteDisponibilidade)));
            
        }
        
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o do dia de vencimento das faturas da conta Esse recurso permite alterar o vencimento de uma conta especifica.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="novoDiaVencimento">Novo dia de vencimento.</param> 
        /// <returns>Conta</returns>
        public Conta AlterarVencimentoUsingPUT (long? id, int? novoDiaVencimento)
        {
             ApiResponse<Conta> localVarResponse = AlterarVencimentoUsingPUTWithHttpInfo(id, novoDiaVencimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o do dia de vencimento das faturas da conta Esse recurso permite alterar o vencimento de uma conta especifica.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="novoDiaVencimento">Novo dia de vencimento.</param> 
        /// <returns>ApiResponse of Conta</returns>
        public ApiResponse< Conta > AlterarVencimentoUsingPUTWithHttpInfo (long? id, int? novoDiaVencimento)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->AlterarVencimentoUsingPUT");
            
            // verify the required parameter 'novoDiaVencimento' is set
            if (novoDiaVencimento == null)
                throw new ApiException(400, "Missing required parameter 'novoDiaVencimento' when calling ContaApi->AlterarVencimentoUsingPUT");
            
    
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
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarVencimentoUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarVencimentoUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Conta>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conta) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conta)));
            
        }

        
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o do dia de vencimento das faturas da conta Esse recurso permite alterar o vencimento de uma conta especifica.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="novoDiaVencimento">Novo dia de vencimento.</param>
        /// <returns>Task of Conta</returns>
        public async System.Threading.Tasks.Task<Conta> AlterarVencimentoUsingPUTAsync (long? id, int? novoDiaVencimento)
        {
             ApiResponse<Conta> localVarResponse = await AlterarVencimentoUsingPUTAsyncWithHttpInfo(id, novoDiaVencimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o do dia de vencimento das faturas da conta Esse recurso permite alterar o vencimento de uma conta especifica.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="novoDiaVencimento">Novo dia de vencimento.</param>
        /// <returns>Task of ApiResponse (Conta)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conta>> AlterarVencimentoUsingPUTAsyncWithHttpInfo (long? id, int? novoDiaVencimento)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarVencimentoUsingPUT");
            // verify the required parameter 'novoDiaVencimento' is set
            if (novoDiaVencimento == null) throw new ApiException(400, "Missing required parameter 'novoDiaVencimento' when calling AlterarVencimentoUsingPUT");
            
    
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
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarVencimentoUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarVencimentoUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conta>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conta) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conta)));
            
        }
        
        /// <summary>
        ///  Ativa o servi\u00C3\u00A7o de envio de fatura por email Este recurso ativa o servi\u00C3\u00A7o de envio de fatura por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <returns>Object</returns>
        public Object AtivarEnvioFaturaEmailUsingPOST (long? id)
        {
             ApiResponse<Object> localVarResponse = AtivarEnvioFaturaEmailUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Ativa o servi\u00C3\u00A7o de envio de fatura por email Este recurso ativa o servi\u00C3\u00A7o de envio de fatura por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > AtivarEnvioFaturaEmailUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->AtivarEnvioFaturaEmailUsingPOST");
            
    
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
            
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtivarEnvioFaturaEmailUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarEnvioFaturaEmailUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        ///  Ativa o servi\u00C3\u00A7o de envio de fatura por email Este recurso ativa o servi\u00C3\u00A7o de envio de fatura por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> AtivarEnvioFaturaEmailUsingPOSTAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await AtivarEnvioFaturaEmailUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Ativa o servi\u00C3\u00A7o de envio de fatura por email Este recurso ativa o servi\u00C3\u00A7o de envio de fatura por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AtivarEnvioFaturaEmailUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtivarEnvioFaturaEmailUsingPOST");
            
    
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
            
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtivarEnvioFaturaEmailUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarEnvioFaturaEmailUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Consulta os dados de um determinado boleto da fatura Este recurso consulta um boleto da fatura
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <returns>BoletoDeFatura</returns>
        public BoletoDeFatura ConsultarBoletoEmitidoUsingGET (long? id)
        {
             ApiResponse<BoletoDeFatura> localVarResponse = ConsultarBoletoEmitidoUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta os dados de um determinado boleto da fatura Este recurso consulta um boleto da fatura
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <returns>ApiResponse of BoletoDeFatura</returns>
        public ApiResponse< BoletoDeFatura > ConsultarBoletoEmitidoUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ConsultarBoletoEmitidoUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/faturas/consultar-ficha-compensacao";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBoletoEmitidoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBoletoEmitidoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BoletoDeFatura>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoDeFatura) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoDeFatura)));
            
        }

        
        /// <summary>
        /// Consulta os dados de um determinado boleto da fatura Este recurso consulta um boleto da fatura
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Task of BoletoDeFatura</returns>
        public async System.Threading.Tasks.Task<BoletoDeFatura> ConsultarBoletoEmitidoUsingGETAsync (long? id)
        {
             ApiResponse<BoletoDeFatura> localVarResponse = await ConsultarBoletoEmitidoUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta os dados de um determinado boleto da fatura Este recurso consulta um boleto da fatura
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Task of ApiResponse (BoletoDeFatura)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BoletoDeFatura>> ConsultarBoletoEmitidoUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarBoletoEmitidoUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/faturas/consultar-ficha-compensacao";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBoletoEmitidoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBoletoEmitidoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BoletoDeFatura>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoDeFatura) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoDeFatura)));
            
        }
        
        /// <summary>
        /// Consulta a d\u00C3\u00ADvida atualizada do cliente Este recurso consulta a d\u00C3\u00ADvida atualizada do cliente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="dataVencimento">Data do vencimento (optional)</param> 
        /// <param name="idEscritorioCobranca">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do escrit\u00C3\u00B3rio de cobran\u00C3\u00A7a (optional)</param> 
        /// <returns>DividaClienteResponse</returns>
        public DividaClienteResponse ConsultarDividaAtualizadaClienteUsingGET (long? id, int? page = null, int? limit = null, DateTime? dataVencimento = null, long? idEscritorioCobranca = null)
        {
             ApiResponse<DividaClienteResponse> localVarResponse = ConsultarDividaAtualizadaClienteUsingGETWithHttpInfo(id, page, limit, dataVencimento, idEscritorioCobranca);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta a d\u00C3\u00ADvida atualizada do cliente Este recurso consulta a d\u00C3\u00ADvida atualizada do cliente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="dataVencimento">Data do vencimento (optional)</param> 
        /// <param name="idEscritorioCobranca">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do escrit\u00C3\u00B3rio de cobran\u00C3\u00A7a (optional)</param> 
        /// <returns>ApiResponse of DividaClienteResponse</returns>
        public ApiResponse< DividaClienteResponse > ConsultarDividaAtualizadaClienteUsingGETWithHttpInfo (long? id, int? page = null, int? limit = null, DateTime? dataVencimento = null, long? idEscritorioCobranca = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ConsultarDividaAtualizadaClienteUsingGET");
            
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            if (idEscritorioCobranca != null) localVarQueryParams.Add("idEscritorioCobranca", Configuration.ApiClient.ParameterToString(idEscritorioCobranca)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDividaAtualizadaClienteUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDividaAtualizadaClienteUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DividaClienteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DividaClienteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DividaClienteResponse)));
            
        }

        
        /// <summary>
        /// Consulta a d\u00C3\u00ADvida atualizada do cliente Este recurso consulta a d\u00C3\u00ADvida atualizada do cliente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataVencimento">Data do vencimento (optional)</param>
        /// <param name="idEscritorioCobranca">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do escrit\u00C3\u00B3rio de cobran\u00C3\u00A7a (optional)</param>
        /// <returns>Task of DividaClienteResponse</returns>
        public async System.Threading.Tasks.Task<DividaClienteResponse> ConsultarDividaAtualizadaClienteUsingGETAsync (long? id, int? page = null, int? limit = null, DateTime? dataVencimento = null, long? idEscritorioCobranca = null)
        {
             ApiResponse<DividaClienteResponse> localVarResponse = await ConsultarDividaAtualizadaClienteUsingGETAsyncWithHttpInfo(id, page, limit, dataVencimento, idEscritorioCobranca);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta a d\u00C3\u00ADvida atualizada do cliente Este recurso consulta a d\u00C3\u00ADvida atualizada do cliente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataVencimento">Data do vencimento (optional)</param>
        /// <param name="idEscritorioCobranca">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do escrit\u00C3\u00B3rio de cobran\u00C3\u00A7a (optional)</param>
        /// <returns>Task of ApiResponse (DividaClienteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DividaClienteResponse>> ConsultarDividaAtualizadaClienteUsingGETAsyncWithHttpInfo (long? id, int? page = null, int? limit = null, DateTime? dataVencimento = null, long? idEscritorioCobranca = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarDividaAtualizadaClienteUsingGET");
            
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            if (idEscritorioCobranca != null) localVarQueryParams.Add("idEscritorioCobranca", Configuration.ApiClient.ParameterToString(idEscritorioCobranca)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDividaAtualizadaClienteUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDividaAtualizadaClienteUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DividaClienteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DividaClienteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DividaClienteResponse)));
            
        }
        
        /// <summary>
        /// Consultar a fatura consignadas abertas da conta Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar a fatura consignada em aberto
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="dataVencimento">Data Vencimento.</param> 
        /// <returns>FaturaConsignadaResponse</returns>
        public FaturaConsignadaResponse ConsultarFaturaConsignadaAbertaUsingGET (long? id, DateTime? dataVencimento)
        {
             ApiResponse<FaturaConsignadaResponse> localVarResponse = ConsultarFaturaConsignadaAbertaUsingGETWithHttpInfo(id, dataVencimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar a fatura consignadas abertas da conta Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar a fatura consignada em aberto
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="dataVencimento">Data Vencimento.</param> 
        /// <returns>ApiResponse of FaturaConsignadaResponse</returns>
        public ApiResponse< FaturaConsignadaResponse > ConsultarFaturaConsignadaAbertaUsingGETWithHttpInfo (long? id, DateTime? dataVencimento)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ConsultarFaturaConsignadaAbertaUsingGET");
            
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null)
                throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling ContaApi->ConsultarFaturaConsignadaAbertaUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/faturas-consignadas/consultar-fatura-aberta";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarFaturaConsignadaAbertaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarFaturaConsignadaAbertaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<FaturaConsignadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaturaConsignadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaturaConsignadaResponse)));
            
        }

        
        /// <summary>
        /// Consultar a fatura consignadas abertas da conta Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar a fatura consignada em aberto
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="dataVencimento">Data Vencimento.</param>
        /// <returns>Task of FaturaConsignadaResponse</returns>
        public async System.Threading.Tasks.Task<FaturaConsignadaResponse> ConsultarFaturaConsignadaAbertaUsingGETAsync (long? id, DateTime? dataVencimento)
        {
             ApiResponse<FaturaConsignadaResponse> localVarResponse = await ConsultarFaturaConsignadaAbertaUsingGETAsyncWithHttpInfo(id, dataVencimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar a fatura consignadas abertas da conta Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar a fatura consignada em aberto
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="dataVencimento">Data Vencimento.</param>
        /// <returns>Task of ApiResponse (FaturaConsignadaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaturaConsignadaResponse>> ConsultarFaturaConsignadaAbertaUsingGETAsyncWithHttpInfo (long? id, DateTime? dataVencimento)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarFaturaConsignadaAbertaUsingGET");
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null) throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling ConsultarFaturaConsignadaAbertaUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/faturas-consignadas/consultar-fatura-aberta";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarFaturaConsignadaAbertaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarFaturaConsignadaAbertaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaturaConsignadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaturaConsignadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaturaConsignadaResponse)));
            
        }
        
        /// <summary>
        /// Apresenta dados de uma determinada fatura consignada Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar uma fatura, atrav\u00C3\u00A9s do id da conta e o id da fatura.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="idFatura">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da fatura (id_fatura).</param> 
        /// <returns>FaturaConsignadaDetalheResponse</returns>
        public FaturaConsignadaDetalheResponse ConsultarFaturaConsignadaUsingGET (long? id, long? idFatura)
        {
             ApiResponse<FaturaConsignadaDetalheResponse> localVarResponse = ConsultarFaturaConsignadaUsingGETWithHttpInfo(id, idFatura);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta dados de uma determinada fatura consignada Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar uma fatura, atrav\u00C3\u00A9s do id da conta e o id da fatura.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="idFatura">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da fatura (id_fatura).</param> 
        /// <returns>ApiResponse of FaturaConsignadaDetalheResponse</returns>
        public ApiResponse< FaturaConsignadaDetalheResponse > ConsultarFaturaConsignadaUsingGETWithHttpInfo (long? id, long? idFatura)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ConsultarFaturaConsignadaUsingGET");
            
            // verify the required parameter 'idFatura' is set
            if (idFatura == null)
                throw new ApiException(400, "Missing required parameter 'idFatura' when calling ContaApi->ConsultarFaturaConsignadaUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/faturas-consignadas/{id_fatura}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (idFatura != null) localVarPathParams.Add("id_fatura", Configuration.ApiClient.ParameterToString(idFatura)); // path parameter
            
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarFaturaConsignadaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarFaturaConsignadaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<FaturaConsignadaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaturaConsignadaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaturaConsignadaDetalheResponse)));
            
        }

        
        /// <summary>
        /// Apresenta dados de uma determinada fatura consignada Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar uma fatura, atrav\u00C3\u00A9s do id da conta e o id da fatura.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idFatura">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da fatura (id_fatura).</param>
        /// <returns>Task of FaturaConsignadaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<FaturaConsignadaDetalheResponse> ConsultarFaturaConsignadaUsingGETAsync (long? id, long? idFatura)
        {
             ApiResponse<FaturaConsignadaDetalheResponse> localVarResponse = await ConsultarFaturaConsignadaUsingGETAsyncWithHttpInfo(id, idFatura);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta dados de uma determinada fatura consignada Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar uma fatura, atrav\u00C3\u00A9s do id da conta e o id da fatura.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idFatura">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da fatura (id_fatura).</param>
        /// <returns>Task of ApiResponse (FaturaConsignadaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaturaConsignadaDetalheResponse>> ConsultarFaturaConsignadaUsingGETAsyncWithHttpInfo (long? id, long? idFatura)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarFaturaConsignadaUsingGET");
            // verify the required parameter 'idFatura' is set
            if (idFatura == null) throw new ApiException(400, "Missing required parameter 'idFatura' when calling ConsultarFaturaConsignadaUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/faturas-consignadas/{id_fatura}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (idFatura != null) localVarPathParams.Add("id_fatura", Configuration.ApiClient.ParameterToString(idFatura)); // path parameter
            
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarFaturaConsignadaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarFaturaConsignadaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaturaConsignadaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaturaConsignadaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaturaConsignadaDetalheResponse)));
            
        }
        
        /// <summary>
        /// Consultar Fatura da Conta Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar os detalhes de uma fatura vinculados a uma determinada conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="idFatura">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da fatura (id_fatura).</param> 
        /// <returns>DetalhesFaturaResponse</returns>
        public DetalhesFaturaResponse ConsultarFaturaUsingGET (long? id, long? idFatura)
        {
             ApiResponse<DetalhesFaturaResponse> localVarResponse = ConsultarFaturaUsingGETWithHttpInfo(id, idFatura);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar Fatura da Conta Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar os detalhes de uma fatura vinculados a uma determinada conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="idFatura">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da fatura (id_fatura).</param> 
        /// <returns>ApiResponse of DetalhesFaturaResponse</returns>
        public ApiResponse< DetalhesFaturaResponse > ConsultarFaturaUsingGETWithHttpInfo (long? id, long? idFatura)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ConsultarFaturaUsingGET");
            
            // verify the required parameter 'idFatura' is set
            if (idFatura == null)
                throw new ApiException(400, "Missing required parameter 'idFatura' when calling ContaApi->ConsultarFaturaUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/faturas/{id_fatura}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (idFatura != null) localVarPathParams.Add("id_fatura", Configuration.ApiClient.ParameterToString(idFatura)); // path parameter
            
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarFaturaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarFaturaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DetalhesFaturaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DetalhesFaturaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DetalhesFaturaResponse)));
            
        }

        
        /// <summary>
        /// Consultar Fatura da Conta Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar os detalhes de uma fatura vinculados a uma determinada conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idFatura">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da fatura (id_fatura).</param>
        /// <returns>Task of DetalhesFaturaResponse</returns>
        public async System.Threading.Tasks.Task<DetalhesFaturaResponse> ConsultarFaturaUsingGETAsync (long? id, long? idFatura)
        {
             ApiResponse<DetalhesFaturaResponse> localVarResponse = await ConsultarFaturaUsingGETAsyncWithHttpInfo(id, idFatura);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar Fatura da Conta Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar os detalhes de uma fatura vinculados a uma determinada conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idFatura">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da fatura (id_fatura).</param>
        /// <returns>Task of ApiResponse (DetalhesFaturaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DetalhesFaturaResponse>> ConsultarFaturaUsingGETAsyncWithHttpInfo (long? id, long? idFatura)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarFaturaUsingGET");
            // verify the required parameter 'idFatura' is set
            if (idFatura == null) throw new ApiException(400, "Missing required parameter 'idFatura' when calling ConsultarFaturaUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/faturas/{id_fatura}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (idFatura != null) localVarPathParams.Add("id_fatura", Configuration.ApiClient.ParameterToString(idFatura)); // path parameter
            
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarFaturaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarFaturaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DetalhesFaturaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DetalhesFaturaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DetalhesFaturaResponse)));
            
        }
        
        /// <summary>
        /// Consultar Lan\u00C3\u00A7amentos Futuros da Fatura de uma Conta Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar os detalhes dos lan\u00C3\u00A7amentos futuros de uma fatura vinculados a uma determinada conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="idFatura">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da fatura (id_fatura).</param> 
        /// <returns>DetalhesFaturaResponse</returns>
        public DetalhesFaturaResponse ConsultarLancamentosFuturosFaturaUsingGET (long? id, long? idFatura)
        {
             ApiResponse<DetalhesFaturaResponse> localVarResponse = ConsultarLancamentosFuturosFaturaUsingGETWithHttpInfo(id, idFatura);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar Lan\u00C3\u00A7amentos Futuros da Fatura de uma Conta Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar os detalhes dos lan\u00C3\u00A7amentos futuros de uma fatura vinculados a uma determinada conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="idFatura">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da fatura (id_fatura).</param> 
        /// <returns>ApiResponse of DetalhesFaturaResponse</returns>
        public ApiResponse< DetalhesFaturaResponse > ConsultarLancamentosFuturosFaturaUsingGETWithHttpInfo (long? id, long? idFatura)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ConsultarLancamentosFuturosFaturaUsingGET");
            
            // verify the required parameter 'idFatura' is set
            if (idFatura == null)
                throw new ApiException(400, "Missing required parameter 'idFatura' when calling ContaApi->ConsultarLancamentosFuturosFaturaUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/faturas/{id_fatura}/lancamentos-futuros";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (idFatura != null) localVarPathParams.Add("id_fatura", Configuration.ApiClient.ParameterToString(idFatura)); // path parameter
            
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLancamentosFuturosFaturaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLancamentosFuturosFaturaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DetalhesFaturaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DetalhesFaturaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DetalhesFaturaResponse)));
            
        }

        
        /// <summary>
        /// Consultar Lan\u00C3\u00A7amentos Futuros da Fatura de uma Conta Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar os detalhes dos lan\u00C3\u00A7amentos futuros de uma fatura vinculados a uma determinada conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idFatura">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da fatura (id_fatura).</param>
        /// <returns>Task of DetalhesFaturaResponse</returns>
        public async System.Threading.Tasks.Task<DetalhesFaturaResponse> ConsultarLancamentosFuturosFaturaUsingGETAsync (long? id, long? idFatura)
        {
             ApiResponse<DetalhesFaturaResponse> localVarResponse = await ConsultarLancamentosFuturosFaturaUsingGETAsyncWithHttpInfo(id, idFatura);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar Lan\u00C3\u00A7amentos Futuros da Fatura de uma Conta Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar os detalhes dos lan\u00C3\u00A7amentos futuros de uma fatura vinculados a uma determinada conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idFatura">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da fatura (id_fatura).</param>
        /// <returns>Task of ApiResponse (DetalhesFaturaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DetalhesFaturaResponse>> ConsultarLancamentosFuturosFaturaUsingGETAsyncWithHttpInfo (long? id, long? idFatura)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarLancamentosFuturosFaturaUsingGET");
            // verify the required parameter 'idFatura' is set
            if (idFatura == null) throw new ApiException(400, "Missing required parameter 'idFatura' when calling ConsultarLancamentosFuturosFaturaUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/faturas/{id_fatura}/lancamentos-futuros";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (idFatura != null) localVarPathParams.Add("id_fatura", Configuration.ApiClient.ParameterToString(idFatura)); // path parameter
            
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLancamentosFuturosFaturaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLancamentosFuturosFaturaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DetalhesFaturaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DetalhesFaturaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DetalhesFaturaResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os limites da conta Este m\u00C3\u00A9todo permite consultar os Limites configurados para uma determinada Conta, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <returns>LimiteDisponibilidade</returns>
        public LimiteDisponibilidade ConsultarLimiteDisponibilidadeUsingGET1 (long? id)
        {
             ApiResponse<LimiteDisponibilidade> localVarResponse = ConsultarLimiteDisponibilidadeUsingGET1WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os limites da conta Este m\u00C3\u00A9todo permite consultar os Limites configurados para uma determinada Conta, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <returns>ApiResponse of LimiteDisponibilidade</returns>
        public ApiResponse< LimiteDisponibilidade > ConsultarLimiteDisponibilidadeUsingGET1WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ConsultarLimiteDisponibilidadeUsingGET1");
            
    
            var localVarPath = "/api/contas/{id}/limites-disponibilidades";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLimiteDisponibilidadeUsingGET1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLimiteDisponibilidadeUsingGET1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LimiteDisponibilidade>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LimiteDisponibilidade) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimiteDisponibilidade)));
            
        }

        
        /// <summary>
        /// Apresenta os limites da conta Este m\u00C3\u00A9todo permite consultar os Limites configurados para uma determinada Conta, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Task of LimiteDisponibilidade</returns>
        public async System.Threading.Tasks.Task<LimiteDisponibilidade> ConsultarLimiteDisponibilidadeUsingGET1Async (long? id)
        {
             ApiResponse<LimiteDisponibilidade> localVarResponse = await ConsultarLimiteDisponibilidadeUsingGET1AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os limites da conta Este m\u00C3\u00A9todo permite consultar os Limites configurados para uma determinada Conta, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Task of ApiResponse (LimiteDisponibilidade)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LimiteDisponibilidade>> ConsultarLimiteDisponibilidadeUsingGET1AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarLimiteDisponibilidadeUsingGET1");
            
    
            var localVarPath = "/api/contas/{id}/limites-disponibilidades";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLimiteDisponibilidadeUsingGET1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLimiteDisponibilidadeUsingGET1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LimiteDisponibilidade>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LimiteDisponibilidade) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimiteDisponibilidade)));
            
        }
        
        /// <summary>
        /// Consulta os detalhes de uma determinada transfer\u00C3\u00AAncia Este m\u00C3\u00A9todo permite consultar os detalhes de uma determinada transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito realizada entre contas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="idTransferencia">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id_transferencia).</param> 
        /// <returns>PageTransferencias</returns>
        public PageTransferencias ConsultarUsingGET21 (long? id, long? idTransferencia)
        {
             ApiResponse<PageTransferencias> localVarResponse = ConsultarUsingGET21WithHttpInfo(id, idTransferencia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta os detalhes de uma determinada transfer\u00C3\u00AAncia Este m\u00C3\u00A9todo permite consultar os detalhes de uma determinada transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito realizada entre contas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="idTransferencia">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id_transferencia).</param> 
        /// <returns>ApiResponse of PageTransferencias</returns>
        public ApiResponse< PageTransferencias > ConsultarUsingGET21WithHttpInfo (long? id, long? idTransferencia)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ConsultarUsingGET21");
            
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null)
                throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling ContaApi->ConsultarUsingGET21");
            
    
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
            
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET21: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET21: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTransferencias>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransferencias) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransferencias)));
            
        }

        
        /// <summary>
        /// Consulta os detalhes de uma determinada transfer\u00C3\u00AAncia Este m\u00C3\u00A9todo permite consultar os detalhes de uma determinada transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito realizada entre contas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idTransferencia">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id_transferencia).</param>
        /// <returns>Task of PageTransferencias</returns>
        public async System.Threading.Tasks.Task<PageTransferencias> ConsultarUsingGET21Async (long? id, long? idTransferencia)
        {
             ApiResponse<PageTransferencias> localVarResponse = await ConsultarUsingGET21AsyncWithHttpInfo(id, idTransferencia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta os detalhes de uma determinada transfer\u00C3\u00AAncia Este m\u00C3\u00A9todo permite consultar os detalhes de uma determinada transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito realizada entre contas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idTransferencia">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id_transferencia).</param>
        /// <returns>Task of ApiResponse (PageTransferencias)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransferencias>> ConsultarUsingGET21AsyncWithHttpInfo (long? id, long? idTransferencia)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET21");
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null) throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling ConsultarUsingGET21");
            
    
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
            
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET21: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET21: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTransferencias>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransferencias) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransferencias)));
            
        }
        
        /// <summary>
        /// Apresenta dados de uma determinada conta Este m\u00C3\u00A9todo permite consultar dados de uma determinada conta a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <returns>Conta</returns>
        public Conta ConsultarUsingGET3 (long? id)
        {
             ApiResponse<Conta> localVarResponse = ConsultarUsingGET3WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta dados de uma determinada conta Este m\u00C3\u00A9todo permite consultar dados de uma determinada conta a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <returns>ApiResponse of Conta</returns>
        public ApiResponse< Conta > ConsultarUsingGET3WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ConsultarUsingGET3");
            
    
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
            
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Conta>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conta) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conta)));
            
        }

        
        /// <summary>
        /// Apresenta dados de uma determinada conta Este m\u00C3\u00A9todo permite consultar dados de uma determinada conta a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>Task of Conta</returns>
        public async System.Threading.Tasks.Task<Conta> ConsultarUsingGET3Async (long? id)
        {
             ApiResponse<Conta> localVarResponse = await ConsultarUsingGET3AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta dados de uma determinada conta Este m\u00C3\u00A9todo permite consultar dados de uma determinada conta a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>Task of ApiResponse (Conta)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conta>> ConsultarUsingGET3AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET3");
            
    
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
            
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conta>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conta) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conta)));
            
        }
        
        /// <summary>
        /// Desativa o servi\u00C3\u00A7o de envio de fatura por email Este recurso desativa o servi\u00C3\u00A7o de envio de fatura por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <returns>Object</returns>
        public Object DesativarEnvioFaturaEmailUsingPOST (long? id)
        {
             ApiResponse<Object> localVarResponse = DesativarEnvioFaturaEmailUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Desativa o servi\u00C3\u00A7o de envio de fatura por email Este recurso desativa o servi\u00C3\u00A7o de envio de fatura por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > DesativarEnvioFaturaEmailUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->DesativarEnvioFaturaEmailUsingPOST");
            
    
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
            
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesativarEnvioFaturaEmailUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarEnvioFaturaEmailUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Desativa o servi\u00C3\u00A7o de envio de fatura por email Este recurso desativa o servi\u00C3\u00A7o de envio de fatura por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> DesativarEnvioFaturaEmailUsingPOSTAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await DesativarEnvioFaturaEmailUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Desativa o servi\u00C3\u00A7o de envio de fatura por email Este recurso desativa o servi\u00C3\u00A7o de envio de fatura por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DesativarEnvioFaturaEmailUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesativarEnvioFaturaEmailUsingPOST");
            
    
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
            
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesativarEnvioFaturaEmailUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarEnvioFaturaEmailUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Gera um boleto de recarga Este recurso gera um boleto de recarga
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="valor"></param> 
        /// <param name="dataVencimento"></param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <returns>BoletoDeFatura</returns>
        public BoletoDeFatura GerarBoletoRecargaUsingPOST (long? id, double? valor, DateTime? dataVencimento, int? page = null, int? limit = null)
        {
             ApiResponse<BoletoDeFatura> localVarResponse = GerarBoletoRecargaUsingPOSTWithHttpInfo(id, valor, dataVencimento, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gera um boleto de recarga Este recurso gera um boleto de recarga
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="valor"></param> 
        /// <param name="dataVencimento"></param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <returns>ApiResponse of BoletoDeFatura</returns>
        public ApiResponse< BoletoDeFatura > GerarBoletoRecargaUsingPOSTWithHttpInfo (long? id, double? valor, DateTime? dataVencimento, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->GerarBoletoRecargaUsingPOST");
            
            // verify the required parameter 'valor' is set
            if (valor == null)
                throw new ApiException(400, "Missing required parameter 'valor' when calling ContaApi->GerarBoletoRecargaUsingPOST");
            
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null)
                throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling ContaApi->GerarBoletoRecargaUsingPOST");
            
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (valor != null) localVarQueryParams.Add("valor", Configuration.ApiClient.ParameterToString(valor)); // query parameter
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoRecargaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoRecargaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BoletoDeFatura>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoDeFatura) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoDeFatura)));
            
        }

        
        /// <summary>
        /// Gera um boleto de recarga Este recurso gera um boleto de recarga
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="valor"></param>
        /// <param name="dataVencimento"></param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of BoletoDeFatura</returns>
        public async System.Threading.Tasks.Task<BoletoDeFatura> GerarBoletoRecargaUsingPOSTAsync (long? id, double? valor, DateTime? dataVencimento, int? page = null, int? limit = null)
        {
             ApiResponse<BoletoDeFatura> localVarResponse = await GerarBoletoRecargaUsingPOSTAsyncWithHttpInfo(id, valor, dataVencimento, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gera um boleto de recarga Este recurso gera um boleto de recarga
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="valor"></param>
        /// <param name="dataVencimento"></param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ApiResponse (BoletoDeFatura)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BoletoDeFatura>> GerarBoletoRecargaUsingPOSTAsyncWithHttpInfo (long? id, double? valor, DateTime? dataVencimento, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GerarBoletoRecargaUsingPOST");
            // verify the required parameter 'valor' is set
            if (valor == null) throw new ApiException(400, "Missing required parameter 'valor' when calling GerarBoletoRecargaUsingPOST");
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null) throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling GerarBoletoRecargaUsingPOST");
            
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (valor != null) localVarQueryParams.Add("valor", Configuration.ApiClient.ParameterToString(valor)); // query parameter
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoRecargaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoRecargaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BoletoDeFatura>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoDeFatura) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoDeFatura)));
            
        }
        
        /// <summary>
        /// Realiza a gera\u00C3\u00A7\u00C3\u00A3o de um novo cart\u00C3\u00A3o para impress\u00C3\u00A3o avulsa Este recurso permite que seja gerado um novo Cart\u00C3\u00A3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00C3\u00A3o que dever\u00C3\u00A1 ser gerado para impress\u00C3\u00A3o. Esta funcionalidade poder\u00C3\u00A1 ser utilizada para realizar a impress\u00C3\u00A3o de cart\u00C3\u00B5es em Lojas, Quiosques, Escrit\u00C3\u00B3rios, Terminais de Auto Atendimento, ou outro local que o Emissor escolher, desde que se possua uma impressora de Cart\u00C3\u00B5es habilidade para o fazer, no local.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da pessoa (id).</param> 
        /// <param name="idTipoPlastico">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do TipoPlastico (id). (optional)</param> 
        /// <returns>CartaoImpressao</returns>
        public CartaoImpressao GerarCartaoUsingPOST (long? id, long? idPessoa, long? idTipoPlastico = null)
        {
             ApiResponse<CartaoImpressao> localVarResponse = GerarCartaoUsingPOSTWithHttpInfo(id, idPessoa, idTipoPlastico);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a gera\u00C3\u00A7\u00C3\u00A3o de um novo cart\u00C3\u00A3o para impress\u00C3\u00A3o avulsa Este recurso permite que seja gerado um novo Cart\u00C3\u00A3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00C3\u00A3o que dever\u00C3\u00A1 ser gerado para impress\u00C3\u00A3o. Esta funcionalidade poder\u00C3\u00A1 ser utilizada para realizar a impress\u00C3\u00A3o de cart\u00C3\u00B5es em Lojas, Quiosques, Escrit\u00C3\u00B3rios, Terminais de Auto Atendimento, ou outro local que o Emissor escolher, desde que se possua uma impressora de Cart\u00C3\u00B5es habilidade para o fazer, no local.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da pessoa (id).</param> 
        /// <param name="idTipoPlastico">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do TipoPlastico (id). (optional)</param> 
        /// <returns>ApiResponse of CartaoImpressao</returns>
        public ApiResponse< CartaoImpressao > GerarCartaoUsingPOSTWithHttpInfo (long? id, long? idPessoa, long? idTipoPlastico = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->GerarCartaoUsingPOST");
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling ContaApi->GerarCartaoUsingPOST");
            
    
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
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoImpressao>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoImpressao) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoImpressao)));
            
        }

        
        /// <summary>
        /// Realiza a gera\u00C3\u00A7\u00C3\u00A3o de um novo cart\u00C3\u00A3o para impress\u00C3\u00A3o avulsa Este recurso permite que seja gerado um novo Cart\u00C3\u00A3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00C3\u00A3o que dever\u00C3\u00A1 ser gerado para impress\u00C3\u00A3o. Esta funcionalidade poder\u00C3\u00A1 ser utilizada para realizar a impress\u00C3\u00A3o de cart\u00C3\u00B5es em Lojas, Quiosques, Escrit\u00C3\u00B3rios, Terminais de Auto Atendimento, ou outro local que o Emissor escolher, desde que se possua uma impressora de Cart\u00C3\u00B5es habilidade para o fazer, no local.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da pessoa (id).</param>
        /// <param name="idTipoPlastico">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do TipoPlastico (id). (optional)</param>
        /// <returns>Task of CartaoImpressao</returns>
        public async System.Threading.Tasks.Task<CartaoImpressao> GerarCartaoUsingPOSTAsync (long? id, long? idPessoa, long? idTipoPlastico = null)
        {
             ApiResponse<CartaoImpressao> localVarResponse = await GerarCartaoUsingPOSTAsyncWithHttpInfo(id, idPessoa, idTipoPlastico);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a gera\u00C3\u00A7\u00C3\u00A3o de um novo cart\u00C3\u00A3o para impress\u00C3\u00A3o avulsa Este recurso permite que seja gerado um novo Cart\u00C3\u00A3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00C3\u00A3o que dever\u00C3\u00A1 ser gerado para impress\u00C3\u00A3o. Esta funcionalidade poder\u00C3\u00A1 ser utilizada para realizar a impress\u00C3\u00A3o de cart\u00C3\u00B5es em Lojas, Quiosques, Escrit\u00C3\u00B3rios, Terminais de Auto Atendimento, ou outro local que o Emissor escolher, desde que se possua uma impressora de Cart\u00C3\u00B5es habilidade para o fazer, no local.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da pessoa (id).</param>
        /// <param name="idTipoPlastico">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do TipoPlastico (id). (optional)</param>
        /// <returns>Task of ApiResponse (CartaoImpressao)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoImpressao>> GerarCartaoUsingPOSTAsyncWithHttpInfo (long? id, long? idPessoa, long? idTipoPlastico = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GerarCartaoUsingPOST");
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling GerarCartaoUsingPOST");
            
    
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
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoImpressao>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoImpressao) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoImpressao)));
            
        }
        
        /// <summary>
        /// Lista as faturas consignadas da conta Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar todo o Hist\u00C3\u00B3rico de Faturas vinculados a uma determinada Conta, independentemente do valor delas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="dataVencimento">Apresenta a data de vencimento da fatura. (optional)</param> 
        /// <returns>PageFaturasConsignadas</returns>
        public PageFaturasConsignadas ListarFaturasConsignadasUsingGET (long? id, int? page = null, int? limit = null, DateTime? dataVencimento = null)
        {
             ApiResponse<PageFaturasConsignadas> localVarResponse = ListarFaturasConsignadasUsingGETWithHttpInfo(id, page, limit, dataVencimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as faturas consignadas da conta Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar todo o Hist\u00C3\u00B3rico de Faturas vinculados a uma determinada Conta, independentemente do valor delas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="dataVencimento">Apresenta a data de vencimento da fatura. (optional)</param> 
        /// <returns>ApiResponse of PageFaturasConsignadas</returns>
        public ApiResponse< PageFaturasConsignadas > ListarFaturasConsignadasUsingGETWithHttpInfo (long? id, int? page = null, int? limit = null, DateTime? dataVencimento = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ListarFaturasConsignadasUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/faturas-consignadas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturasConsignadasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturasConsignadasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageFaturasConsignadas>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageFaturasConsignadas) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageFaturasConsignadas)));
            
        }

        
        /// <summary>
        /// Lista as faturas consignadas da conta Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar todo o Hist\u00C3\u00B3rico de Faturas vinculados a uma determinada Conta, independentemente do valor delas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataVencimento">Apresenta a data de vencimento da fatura. (optional)</param>
        /// <returns>Task of PageFaturasConsignadas</returns>
        public async System.Threading.Tasks.Task<PageFaturasConsignadas> ListarFaturasConsignadasUsingGETAsync (long? id, int? page = null, int? limit = null, DateTime? dataVencimento = null)
        {
             ApiResponse<PageFaturasConsignadas> localVarResponse = await ListarFaturasConsignadasUsingGETAsyncWithHttpInfo(id, page, limit, dataVencimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as faturas consignadas da conta Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar todo o Hist\u00C3\u00B3rico de Faturas vinculados a uma determinada Conta, independentemente do valor delas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataVencimento">Apresenta a data de vencimento da fatura. (optional)</param>
        /// <returns>Task of ApiResponse (PageFaturasConsignadas)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageFaturasConsignadas>> ListarFaturasConsignadasUsingGETAsyncWithHttpInfo (long? id, int? page = null, int? limit = null, DateTime? dataVencimento = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarFaturasConsignadasUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/faturas-consignadas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturasConsignadasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturasConsignadasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageFaturasConsignadas>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageFaturasConsignadas) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageFaturasConsignadas)));
            
        }
        
        /// <summary>
        /// Lista as faturas da conta Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar todo o Hist\u00C3\u00B3rico de Faturas vinculados a uma determinada Conta, independentemente do valor delas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="dataVencimento">Data de Vencimento da Fatura. (optional)</param> 
        /// <returns>PageFaturas</returns>
        public PageFaturas ListarFaturasUsingGET (long? id, int? page = null, int? limit = null, DateTime? dataVencimento = null)
        {
             ApiResponse<PageFaturas> localVarResponse = ListarFaturasUsingGETWithHttpInfo(id, page, limit, dataVencimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as faturas da conta Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar todo o Hist\u00C3\u00B3rico de Faturas vinculados a uma determinada Conta, independentemente do valor delas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="dataVencimento">Data de Vencimento da Fatura. (optional)</param> 
        /// <returns>ApiResponse of PageFaturas</returns>
        public ApiResponse< PageFaturas > ListarFaturasUsingGETWithHttpInfo (long? id, int? page = null, int? limit = null, DateTime? dataVencimento = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ListarFaturasUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/faturas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageFaturas>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageFaturas) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageFaturas)));
            
        }

        
        /// <summary>
        /// Lista as faturas da conta Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar todo o Hist\u00C3\u00B3rico de Faturas vinculados a uma determinada Conta, independentemente do valor delas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataVencimento">Data de Vencimento da Fatura. (optional)</param>
        /// <returns>Task of PageFaturas</returns>
        public async System.Threading.Tasks.Task<PageFaturas> ListarFaturasUsingGETAsync (long? id, int? page = null, int? limit = null, DateTime? dataVencimento = null)
        {
             ApiResponse<PageFaturas> localVarResponse = await ListarFaturasUsingGETAsyncWithHttpInfo(id, page, limit, dataVencimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as faturas da conta Atrav\u00C3\u00A9s desta opera\u00C3\u00A7\u00C3\u00A3o os Emissores ou Portadores poder\u00C3\u00A3o consultar todo o Hist\u00C3\u00B3rico de Faturas vinculados a uma determinada Conta, independentemente do valor delas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataVencimento">Data de Vencimento da Fatura. (optional)</param>
        /// <returns>Task of ApiResponse (PageFaturas)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageFaturas>> ListarFaturasUsingGETAsyncWithHttpInfo (long? id, int? page = null, int? limit = null, DateTime? dataVencimento = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarFaturasUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/faturas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageFaturas>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageFaturas) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageFaturas)));
            
        }
        
        /// <summary>
        /// Lista o hist\u00C3\u00B3rico de altera\u00C3\u00A7\u00C3\u00B5es de limites da conta Este recurso consulta o hist\u00C3\u00B3rico com as altera\u00C3\u00A7\u00C3\u00B5es de limites da conta informada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <returns>PageHistoricoEventos</returns>
        public PageHistoricoEventos ListarHistoricoAlteracoesLimitesUsingGET (long? id, int? page = null, int? limit = null)
        {
             ApiResponse<PageHistoricoEventos> localVarResponse = ListarHistoricoAlteracoesLimitesUsingGETWithHttpInfo(id, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista o hist\u00C3\u00B3rico de altera\u00C3\u00A7\u00C3\u00B5es de limites da conta Este recurso consulta o hist\u00C3\u00B3rico com as altera\u00C3\u00A7\u00C3\u00B5es de limites da conta informada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <returns>ApiResponse of PageHistoricoEventos</returns>
        public ApiResponse< PageHistoricoEventos > ListarHistoricoAlteracoesLimitesUsingGETWithHttpInfo (long? id, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ListarHistoricoAlteracoesLimitesUsingGET");
            
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAlteracoesLimitesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAlteracoesLimitesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageHistoricoEventos>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoEventos) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoEventos)));
            
        }

        
        /// <summary>
        /// Lista o hist\u00C3\u00B3rico de altera\u00C3\u00A7\u00C3\u00B5es de limites da conta Este recurso consulta o hist\u00C3\u00B3rico com as altera\u00C3\u00A7\u00C3\u00B5es de limites da conta informada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of PageHistoricoEventos</returns>
        public async System.Threading.Tasks.Task<PageHistoricoEventos> ListarHistoricoAlteracoesLimitesUsingGETAsync (long? id, int? page = null, int? limit = null)
        {
             ApiResponse<PageHistoricoEventos> localVarResponse = await ListarHistoricoAlteracoesLimitesUsingGETAsyncWithHttpInfo(id, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista o hist\u00C3\u00B3rico de altera\u00C3\u00A7\u00C3\u00B5es de limites da conta Este recurso consulta o hist\u00C3\u00B3rico com as altera\u00C3\u00A7\u00C3\u00B5es de limites da conta informada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoEventos)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageHistoricoEventos>> ListarHistoricoAlteracoesLimitesUsingGETAsyncWithHttpInfo (long? id, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarHistoricoAlteracoesLimitesUsingGET");
            
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAlteracoesLimitesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAlteracoesLimitesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageHistoricoEventos>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoEventos) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoEventos)));
            
        }
        
        /// <summary>
        /// Lista o hist\u00C3\u00B3rico de entradas/sa\u00C3\u00ADdas de assessorias de cobran\u00C3\u00A7a Permite listar todos os registros de entrada e sa\u00C3\u00ADda da Conta em arquivos de integra\u00C3\u00A7\u00C3\u00A3o com empresas de assessorias de cobran\u00C3\u00A7a a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (idConta).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <returns>LinkPageHistoricoAssessoriaResponse</returns>
        public LinkPageHistoricoAssessoriaResponse ListarHistoricoAssessoriaUsingGET (long? id, int? page = null, int? limit = null)
        {
             ApiResponse<LinkPageHistoricoAssessoriaResponse> localVarResponse = ListarHistoricoAssessoriaUsingGETWithHttpInfo(id, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista o hist\u00C3\u00B3rico de entradas/sa\u00C3\u00ADdas de assessorias de cobran\u00C3\u00A7a Permite listar todos os registros de entrada e sa\u00C3\u00ADda da Conta em arquivos de integra\u00C3\u00A7\u00C3\u00A3o com empresas de assessorias de cobran\u00C3\u00A7a a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (idConta).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <returns>ApiResponse of LinkPageHistoricoAssessoriaResponse</returns>
        public ApiResponse< LinkPageHistoricoAssessoriaResponse > ListarHistoricoAssessoriaUsingGETWithHttpInfo (long? id, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ListarHistoricoAssessoriaUsingGET");
            
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAssessoriaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAssessoriaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LinkPageHistoricoAssessoriaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LinkPageHistoricoAssessoriaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LinkPageHistoricoAssessoriaResponse)));
            
        }

        
        /// <summary>
        /// Lista o hist\u00C3\u00B3rico de entradas/sa\u00C3\u00ADdas de assessorias de cobran\u00C3\u00A7a Permite listar todos os registros de entrada e sa\u00C3\u00ADda da Conta em arquivos de integra\u00C3\u00A7\u00C3\u00A3o com empresas de assessorias de cobran\u00C3\u00A7a a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (idConta).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of LinkPageHistoricoAssessoriaResponse</returns>
        public async System.Threading.Tasks.Task<LinkPageHistoricoAssessoriaResponse> ListarHistoricoAssessoriaUsingGETAsync (long? id, int? page = null, int? limit = null)
        {
             ApiResponse<LinkPageHistoricoAssessoriaResponse> localVarResponse = await ListarHistoricoAssessoriaUsingGETAsyncWithHttpInfo(id, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista o hist\u00C3\u00B3rico de entradas/sa\u00C3\u00ADdas de assessorias de cobran\u00C3\u00A7a Permite listar todos os registros de entrada e sa\u00C3\u00ADda da Conta em arquivos de integra\u00C3\u00A7\u00C3\u00A3o com empresas de assessorias de cobran\u00C3\u00A7a a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (idConta).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ApiResponse (LinkPageHistoricoAssessoriaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LinkPageHistoricoAssessoriaResponse>> ListarHistoricoAssessoriaUsingGETAsyncWithHttpInfo (long? id, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarHistoricoAssessoriaUsingGET");
            
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAssessoriaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAssessoriaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LinkPageHistoricoAssessoriaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LinkPageHistoricoAssessoriaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LinkPageHistoricoAssessoriaResponse)));
            
        }
        
        /// <summary>
        /// Lista o historico de atrasos das faturas Este recurso lista o hist\u00C3\u00B3rico do pagamento de faturas em atraso
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <returns>PageHistoricoAtraso</returns>
        public PageHistoricoAtraso ListarHistoricoAtrasosFaturasUsingGET (long? id)
        {
             ApiResponse<PageHistoricoAtraso> localVarResponse = ListarHistoricoAtrasosFaturasUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista o historico de atrasos das faturas Este recurso lista o hist\u00C3\u00B3rico do pagamento de faturas em atraso
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <returns>ApiResponse of PageHistoricoAtraso</returns>
        public ApiResponse< PageHistoricoAtraso > ListarHistoricoAtrasosFaturasUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ListarHistoricoAtrasosFaturasUsingGET");
            
    
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
            
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAtrasosFaturasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAtrasosFaturasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageHistoricoAtraso>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoAtraso) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoAtraso)));
            
        }

        
        /// <summary>
        /// Lista o historico de atrasos das faturas Este recurso lista o hist\u00C3\u00B3rico do pagamento de faturas em atraso
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Task of PageHistoricoAtraso</returns>
        public async System.Threading.Tasks.Task<PageHistoricoAtraso> ListarHistoricoAtrasosFaturasUsingGETAsync (long? id)
        {
             ApiResponse<PageHistoricoAtraso> localVarResponse = await ListarHistoricoAtrasosFaturasUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista o historico de atrasos das faturas Este recurso lista o hist\u00C3\u00B3rico do pagamento de faturas em atraso
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Task of ApiResponse (PageHistoricoAtraso)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageHistoricoAtraso>> ListarHistoricoAtrasosFaturasUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarHistoricoAtrasosFaturasUsingGET");
            
    
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
            
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAtrasosFaturasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAtrasosFaturasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageHistoricoAtraso>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoAtraso) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoAtraso)));
            
        }
        
        /// <summary>
        /// Lista as transa\u00C3\u00A7\u00C3\u00B5es n\u00C3\u00A3o processadas da conta Este m\u00C3\u00A9todo permite que sejam listadas todas as transa\u00C3\u00A7\u00C3\u00B5es n\u00C3\u00A3o processadas da Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <returns>PageTransacoesCorrentes</returns>
        public PageTransacoesCorrentes ListarNaoProcessadasUsingGET (long? id, int? page = null, int? limit = null)
        {
             ApiResponse<PageTransacoesCorrentes> localVarResponse = ListarNaoProcessadasUsingGETWithHttpInfo(id, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as transa\u00C3\u00A7\u00C3\u00B5es n\u00C3\u00A3o processadas da conta Este m\u00C3\u00A9todo permite que sejam listadas todas as transa\u00C3\u00A7\u00C3\u00B5es n\u00C3\u00A3o processadas da Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <returns>ApiResponse of PageTransacoesCorrentes</returns>
        public ApiResponse< PageTransacoesCorrentes > ListarNaoProcessadasUsingGETWithHttpInfo (long? id, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ListarNaoProcessadasUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/transacoes/nao-processadas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarNaoProcessadasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarNaoProcessadasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTransacoesCorrentes>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacoesCorrentes) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacoesCorrentes)));
            
        }

        
        /// <summary>
        /// Lista as transa\u00C3\u00A7\u00C3\u00B5es n\u00C3\u00A3o processadas da conta Este m\u00C3\u00A9todo permite que sejam listadas todas as transa\u00C3\u00A7\u00C3\u00B5es n\u00C3\u00A3o processadas da Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of PageTransacoesCorrentes</returns>
        public async System.Threading.Tasks.Task<PageTransacoesCorrentes> ListarNaoProcessadasUsingGETAsync (long? id, int? page = null, int? limit = null)
        {
             ApiResponse<PageTransacoesCorrentes> localVarResponse = await ListarNaoProcessadasUsingGETAsyncWithHttpInfo(id, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as transa\u00C3\u00A7\u00C3\u00B5es n\u00C3\u00A3o processadas da conta Este m\u00C3\u00A9todo permite que sejam listadas todas as transa\u00C3\u00A7\u00C3\u00B5es n\u00C3\u00A3o processadas da Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacoesCorrentes)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransacoesCorrentes>> ListarNaoProcessadasUsingGETAsyncWithHttpInfo (long? id, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarNaoProcessadasUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/transacoes/nao-processadas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarNaoProcessadasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarNaoProcessadasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTransacoesCorrentes>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacoesCorrentes) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacoesCorrentes)));
            
        }
        
        /// <summary>
        /// Lista as transa\u00C3\u00A7\u00C3\u00B5es processadas da conta Este m\u00C3\u00A9todo permite que sejam listadas todas as transa\u00C3\u00A7\u00C3\u00B5es processadas da Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="dataVencimento">Data de vencimento do extrato no formato yyyy-MM-dd. (optional)</param> 
        /// <returns>PageTransacoesCorrentes</returns>
        public PageTransacoesCorrentes ListarProcessadasUsingGET (long? id, int? page = null, int? limit = null, DateTime? dataVencimento = null)
        {
             ApiResponse<PageTransacoesCorrentes> localVarResponse = ListarProcessadasUsingGETWithHttpInfo(id, page, limit, dataVencimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as transa\u00C3\u00A7\u00C3\u00B5es processadas da conta Este m\u00C3\u00A9todo permite que sejam listadas todas as transa\u00C3\u00A7\u00C3\u00B5es processadas da Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="dataVencimento">Data de vencimento do extrato no formato yyyy-MM-dd. (optional)</param> 
        /// <returns>ApiResponse of PageTransacoesCorrentes</returns>
        public ApiResponse< PageTransacoesCorrentes > ListarProcessadasUsingGETWithHttpInfo (long? id, int? page = null, int? limit = null, DateTime? dataVencimento = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ListarProcessadasUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/transacoes/processadas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarProcessadasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarProcessadasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTransacoesCorrentes>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacoesCorrentes) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacoesCorrentes)));
            
        }

        
        /// <summary>
        /// Lista as transa\u00C3\u00A7\u00C3\u00B5es processadas da conta Este m\u00C3\u00A9todo permite que sejam listadas todas as transa\u00C3\u00A7\u00C3\u00B5es processadas da Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataVencimento">Data de vencimento do extrato no formato yyyy-MM-dd. (optional)</param>
        /// <returns>Task of PageTransacoesCorrentes</returns>
        public async System.Threading.Tasks.Task<PageTransacoesCorrentes> ListarProcessadasUsingGETAsync (long? id, int? page = null, int? limit = null, DateTime? dataVencimento = null)
        {
             ApiResponse<PageTransacoesCorrentes> localVarResponse = await ListarProcessadasUsingGETAsyncWithHttpInfo(id, page, limit, dataVencimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as transa\u00C3\u00A7\u00C3\u00B5es processadas da conta Este m\u00C3\u00A9todo permite que sejam listadas todas as transa\u00C3\u00A7\u00C3\u00B5es processadas da Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataVencimento">Data de vencimento do extrato no formato yyyy-MM-dd. (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacoesCorrentes)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransacoesCorrentes>> ListarProcessadasUsingGETAsyncWithHttpInfo (long? id, int? page = null, int? limit = null, DateTime? dataVencimento = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarProcessadasUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/transacoes/processadas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarProcessadasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarProcessadasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTransacoesCorrentes>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacoesCorrentes) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacoesCorrentes)));
            
        }
        
        /// <summary>
        /// Lista as transfer\u00C3\u00AAncias realizadas pela conta Este m\u00C3\u00A9todo permite que sejam listadas as transfer\u00C3\u00AAncias realizadas pela conta existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="idTransferencia">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id). (optional)</param> 
        /// <param name="idContaOrigem">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 debitado para a transfer\u00C3\u00AAncia. (id). (optional)</param> 
        /// <param name="idContaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 creditado para a transfer\u00C3\u00AAncia. (id). (optional)</param> 
        /// <param name="valorTransferencia">Valor estabelecido para ser transferido. (optional)</param> 
        /// <param name="dataTransferencia">Data estabelecida para ocorrer a transfer\u00C3\u00AAncia. (optional)</param> 
        /// <returns>PageTransferencias</returns>
        public PageTransferencias ListarUsingGET20 (long? id, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, DateTime? dataTransferencia = null)
        {
             ApiResponse<PageTransferencias> localVarResponse = ListarUsingGET20WithHttpInfo(id, page, limit, idTransferencia, idContaOrigem, idContaDestino, valorTransferencia, dataTransferencia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as transfer\u00C3\u00AAncias realizadas pela conta Este m\u00C3\u00A9todo permite que sejam listadas as transfer\u00C3\u00AAncias realizadas pela conta existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="idTransferencia">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id). (optional)</param> 
        /// <param name="idContaOrigem">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 debitado para a transfer\u00C3\u00AAncia. (id). (optional)</param> 
        /// <param name="idContaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 creditado para a transfer\u00C3\u00AAncia. (id). (optional)</param> 
        /// <param name="valorTransferencia">Valor estabelecido para ser transferido. (optional)</param> 
        /// <param name="dataTransferencia">Data estabelecida para ocorrer a transfer\u00C3\u00AAncia. (optional)</param> 
        /// <returns>ApiResponse of PageTransferencias</returns>
        public ApiResponse< PageTransferencias > ListarUsingGET20WithHttpInfo (long? id, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, DateTime? dataTransferencia = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ListarUsingGET20");
            
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (idTransferencia != null) localVarQueryParams.Add("idTransferencia", Configuration.ApiClient.ParameterToString(idTransferencia)); // query parameter
            if (idContaOrigem != null) localVarQueryParams.Add("idContaOrigem", Configuration.ApiClient.ParameterToString(idContaOrigem)); // query parameter
            if (idContaDestino != null) localVarQueryParams.Add("idContaDestino", Configuration.ApiClient.ParameterToString(idContaDestino)); // query parameter
            if (valorTransferencia != null) localVarQueryParams.Add("valorTransferencia", Configuration.ApiClient.ParameterToString(valorTransferencia)); // query parameter
            if (dataTransferencia != null) localVarQueryParams.Add("dataTransferencia", Configuration.ApiClient.ParameterToString(dataTransferencia)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET20: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET20: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTransferencias>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransferencias) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransferencias)));
            
        }

        
        /// <summary>
        /// Lista as transfer\u00C3\u00AAncias realizadas pela conta Este m\u00C3\u00A9todo permite que sejam listadas as transfer\u00C3\u00AAncias realizadas pela conta existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="idTransferencia">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id). (optional)</param>
        /// <param name="idContaOrigem">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 debitado para a transfer\u00C3\u00AAncia. (id). (optional)</param>
        /// <param name="idContaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 creditado para a transfer\u00C3\u00AAncia. (id). (optional)</param>
        /// <param name="valorTransferencia">Valor estabelecido para ser transferido. (optional)</param>
        /// <param name="dataTransferencia">Data estabelecida para ocorrer a transfer\u00C3\u00AAncia. (optional)</param>
        /// <returns>Task of PageTransferencias</returns>
        public async System.Threading.Tasks.Task<PageTransferencias> ListarUsingGET20Async (long? id, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, DateTime? dataTransferencia = null)
        {
             ApiResponse<PageTransferencias> localVarResponse = await ListarUsingGET20AsyncWithHttpInfo(id, page, limit, idTransferencia, idContaOrigem, idContaDestino, valorTransferencia, dataTransferencia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as transfer\u00C3\u00AAncias realizadas pela conta Este m\u00C3\u00A9todo permite que sejam listadas as transfer\u00C3\u00AAncias realizadas pela conta existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="idTransferencia">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id). (optional)</param>
        /// <param name="idContaOrigem">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 debitado para a transfer\u00C3\u00AAncia. (id). (optional)</param>
        /// <param name="idContaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 creditado para a transfer\u00C3\u00AAncia. (id). (optional)</param>
        /// <param name="valorTransferencia">Valor estabelecido para ser transferido. (optional)</param>
        /// <param name="dataTransferencia">Data estabelecida para ocorrer a transfer\u00C3\u00AAncia. (optional)</param>
        /// <returns>Task of ApiResponse (PageTransferencias)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransferencias>> ListarUsingGET20AsyncWithHttpInfo (long? id, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, DateTime? dataTransferencia = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarUsingGET20");
            
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (idTransferencia != null) localVarQueryParams.Add("idTransferencia", Configuration.ApiClient.ParameterToString(idTransferencia)); // query parameter
            if (idContaOrigem != null) localVarQueryParams.Add("idContaOrigem", Configuration.ApiClient.ParameterToString(idContaOrigem)); // query parameter
            if (idContaDestino != null) localVarQueryParams.Add("idContaDestino", Configuration.ApiClient.ParameterToString(idContaDestino)); // query parameter
            if (valorTransferencia != null) localVarQueryParams.Add("valorTransferencia", Configuration.ApiClient.ParameterToString(valorTransferencia)); // query parameter
            if (dataTransferencia != null) localVarQueryParams.Add("dataTransferencia", Configuration.ApiClient.ParameterToString(dataTransferencia)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET20: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET20: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTransferencias>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransferencias) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransferencias)));
            
        }
        
        /// <summary>
        /// Lista contas existentes na base de dados do Emissor Este recurso permite listar contas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="idProduto">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do produto ao qual a conta faz parte. (id). (optional)</param> 
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id) que deu origem a Conta. (optional)</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa Titular da Conta (id). (optional)</param> 
        /// <param name="idStatusConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence (id). (optional)</param> 
        /// <param name="diaVencimento">Apresenta o dia de vencimento. (optional)</param> 
        /// <param name="melhorDiaCompra">Apresenta o melhor dia de compra. (optional)</param> 
        /// <param name="dataStatusConta">Apresenta a data em que o idStatusConta atual fora atribu\u00C3\u00ADdo para ela. (optional)</param> 
        /// <param name="dataCadastro">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param> 
        /// <param name="dataUltimaAlteracaoVencimento">Apresenta a data da ultima altera\u00C3\u00A7\u00C3\u00A3o de vencimento. (optional)</param> 
        /// <returns>PageContas</returns>
        public PageContas ListarUsingGET3 (int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, DateTime? dataStatusConta = null, DateTime? dataCadastro = null, DateTime? dataUltimaAlteracaoVencimento = null)
        {
             ApiResponse<PageContas> localVarResponse = ListarUsingGET3WithHttpInfo(page, limit, idProduto, idOrigemComercial, idPessoa, idStatusConta, diaVencimento, melhorDiaCompra, dataStatusConta, dataCadastro, dataUltimaAlteracaoVencimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista contas existentes na base de dados do Emissor Este recurso permite listar contas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="idProduto">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do produto ao qual a conta faz parte. (id). (optional)</param> 
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id) que deu origem a Conta. (optional)</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa Titular da Conta (id). (optional)</param> 
        /// <param name="idStatusConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence (id). (optional)</param> 
        /// <param name="diaVencimento">Apresenta o dia de vencimento. (optional)</param> 
        /// <param name="melhorDiaCompra">Apresenta o melhor dia de compra. (optional)</param> 
        /// <param name="dataStatusConta">Apresenta a data em que o idStatusConta atual fora atribu\u00C3\u00ADdo para ela. (optional)</param> 
        /// <param name="dataCadastro">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param> 
        /// <param name="dataUltimaAlteracaoVencimento">Apresenta a data da ultima altera\u00C3\u00A7\u00C3\u00A3o de vencimento. (optional)</param> 
        /// <returns>ApiResponse of PageContas</returns>
        public ApiResponse< PageContas > ListarUsingGET3WithHttpInfo (int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, DateTime? dataStatusConta = null, DateTime? dataCadastro = null, DateTime? dataUltimaAlteracaoVencimento = null)
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
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageContas>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContas) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContas)));
            
        }

        
        /// <summary>
        /// Lista contas existentes na base de dados do Emissor Este recurso permite listar contas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do produto ao qual a conta faz parte. (id). (optional)</param>
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id) que deu origem a Conta. (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa Titular da Conta (id). (optional)</param>
        /// <param name="idStatusConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="diaVencimento">Apresenta o dia de vencimento. (optional)</param>
        /// <param name="melhorDiaCompra">Apresenta o melhor dia de compra. (optional)</param>
        /// <param name="dataStatusConta">Apresenta a data em que o idStatusConta atual fora atribu\u00C3\u00ADdo para ela. (optional)</param>
        /// <param name="dataCadastro">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param>
        /// <param name="dataUltimaAlteracaoVencimento">Apresenta a data da ultima altera\u00C3\u00A7\u00C3\u00A3o de vencimento. (optional)</param>
        /// <returns>Task of PageContas</returns>
        public async System.Threading.Tasks.Task<PageContas> ListarUsingGET3Async (int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, DateTime? dataStatusConta = null, DateTime? dataCadastro = null, DateTime? dataUltimaAlteracaoVencimento = null)
        {
             ApiResponse<PageContas> localVarResponse = await ListarUsingGET3AsyncWithHttpInfo(page, limit, idProduto, idOrigemComercial, idPessoa, idStatusConta, diaVencimento, melhorDiaCompra, dataStatusConta, dataCadastro, dataUltimaAlteracaoVencimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista contas existentes na base de dados do Emissor Este recurso permite listar contas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do produto ao qual a conta faz parte. (id). (optional)</param>
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id) que deu origem a Conta. (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa Titular da Conta (id). (optional)</param>
        /// <param name="idStatusConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="diaVencimento">Apresenta o dia de vencimento. (optional)</param>
        /// <param name="melhorDiaCompra">Apresenta o melhor dia de compra. (optional)</param>
        /// <param name="dataStatusConta">Apresenta a data em que o idStatusConta atual fora atribu\u00C3\u00ADdo para ela. (optional)</param>
        /// <param name="dataCadastro">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param>
        /// <param name="dataUltimaAlteracaoVencimento">Apresenta a data da ultima altera\u00C3\u00A7\u00C3\u00A3o de vencimento. (optional)</param>
        /// <returns>Task of ApiResponse (PageContas)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageContas>> ListarUsingGET3AsyncWithHttpInfo (int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, DateTime? dataStatusConta = null, DateTime? dataCadastro = null, DateTime? dataUltimaAlteracaoVencimento = null)
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
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageContas>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContas) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContas)));
            
        }
        
        /// <summary>
        /// Realiza a reativa\u00C3\u00A7\u00C3\u00A3o de contas que foram desativadas por inadimpl\u00C3\u00AAncia Este recurso permite reativar contas que foram desativadas por inadimpl\u00C3\u00AAncia. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <returns>Object</returns>
        public Object ReativarUsingPOST (long? id)
        {
             ApiResponse<Object> localVarResponse = ReativarUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a reativa\u00C3\u00A7\u00C3\u00A3o de contas que foram desativadas por inadimpl\u00C3\u00AAncia Este recurso permite reativar contas que foram desativadas por inadimpl\u00C3\u00AAncia. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > ReativarUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ReativarUsingPOST");
            
    
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
            
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ReativarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ReativarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Realiza a reativa\u00C3\u00A7\u00C3\u00A3o de contas que foram desativadas por inadimpl\u00C3\u00AAncia Este recurso permite reativar contas que foram desativadas por inadimpl\u00C3\u00AAncia. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ReativarUsingPOSTAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await ReativarUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a reativa\u00C3\u00A7\u00C3\u00A3o de contas que foram desativadas por inadimpl\u00C3\u00AAncia Este recurso permite reativar contas que foram desativadas por inadimpl\u00C3\u00AAncia. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ReativarUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReativarUsingPOST");
            
    
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
            
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ReativarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ReativarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Permite listar uma linha do tempo com os eventos da conta Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir a listagem, em formato de timeline, dos eventos vinculados a uma detemrinada conta. Transa\u00C3\u00A7\u00C3\u00B5es, fechamento da fatura, pagamentos, gera\u00C3\u00A7\u00C3\u00A3o de cart\u00C3\u00B5es e altera\u00C3\u00A7\u00C3\u00A3o de limite s\u00C3\u00A3o exemplos de eventos contemplados por esta funcionalidade. Neste m\u00C3\u00A9todo, as opera\u00C3\u00A7\u00C3\u00B5es s\u00C3\u00A3o ordenadas de forma decrescente.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <returns>PageTransacaoResponse</returns>
        public PageTransacaoResponse TransacoesUsingGET (long? id, int? page = null, int? limit = null)
        {
             ApiResponse<PageTransacaoResponse> localVarResponse = TransacoesUsingGETWithHttpInfo(id, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite listar uma linha do tempo com os eventos da conta Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir a listagem, em formato de timeline, dos eventos vinculados a uma detemrinada conta. Transa\u00C3\u00A7\u00C3\u00B5es, fechamento da fatura, pagamentos, gera\u00C3\u00A7\u00C3\u00A3o de cart\u00C3\u00B5es e altera\u00C3\u00A7\u00C3\u00A3o de limite s\u00C3\u00A3o exemplos de eventos contemplados por esta funcionalidade. Neste m\u00C3\u00A9todo, as opera\u00C3\u00A7\u00C3\u00B5es s\u00C3\u00A3o ordenadas de forma decrescente.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <returns>ApiResponse of PageTransacaoResponse</returns>
        public ApiResponse< PageTransacaoResponse > TransacoesUsingGETWithHttpInfo (long? id, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->TransacoesUsingGET");
            
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling TransacoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TransacoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTransacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacaoResponse)));
            
        }

        
        /// <summary>
        /// Permite listar uma linha do tempo com os eventos da conta Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir a listagem, em formato de timeline, dos eventos vinculados a uma detemrinada conta. Transa\u00C3\u00A7\u00C3\u00B5es, fechamento da fatura, pagamentos, gera\u00C3\u00A7\u00C3\u00A3o de cart\u00C3\u00B5es e altera\u00C3\u00A7\u00C3\u00A3o de limite s\u00C3\u00A3o exemplos de eventos contemplados por esta funcionalidade. Neste m\u00C3\u00A9todo, as opera\u00C3\u00A7\u00C3\u00B5es s\u00C3\u00A3o ordenadas de forma decrescente.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of PageTransacaoResponse</returns>
        public async System.Threading.Tasks.Task<PageTransacaoResponse> TransacoesUsingGETAsync (long? id, int? page = null, int? limit = null)
        {
             ApiResponse<PageTransacaoResponse> localVarResponse = await TransacoesUsingGETAsyncWithHttpInfo(id, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite listar uma linha do tempo com os eventos da conta Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir a listagem, em formato de timeline, dos eventos vinculados a uma detemrinada conta. Transa\u00C3\u00A7\u00C3\u00B5es, fechamento da fatura, pagamentos, gera\u00C3\u00A7\u00C3\u00A3o de cart\u00C3\u00B5es e altera\u00C3\u00A7\u00C3\u00A3o de limite s\u00C3\u00A3o exemplos de eventos contemplados por esta funcionalidade. Neste m\u00C3\u00A9todo, as opera\u00C3\u00A7\u00C3\u00B5es s\u00C3\u00A3o ordenadas de forma decrescente.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransacaoResponse>> TransacoesUsingGETAsyncWithHttpInfo (long? id, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TransacoesUsingGET");
            
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling TransacoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TransacoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTransacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacaoResponse)));
            
        }
        
        /// <summary>
        /// Realiza uma transfer\u00C3\u00AAncia de Cr\u00C3\u00A9dito para outro cliente do mesmo Emissor Este m\u00C3\u00A9todo permite que um portador de um cart\u00C3\u00A3o possa realizar auma transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para outro cliente do mesmo emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do cliente portador do cart\u00C3\u00A3o que ser\u00C3\u00A1 debitado (id).</param> 
        /// <param name="idContaDestino">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do cliente portador do cart\u00C3\u00A3o que ser\u00C3\u00A1 creditado (id).</param> 
        /// <param name="valorTransferencia">Valor da Transfer\u00C3\u00AAncia.</param> 
        /// <returns>PageTransferencias</returns>
        public PageTransferencias TransferirUsingPOST1 (long? id, long? idContaDestino, double? valorTransferencia)
        {
             ApiResponse<PageTransferencias> localVarResponse = TransferirUsingPOST1WithHttpInfo(id, idContaDestino, valorTransferencia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza uma transfer\u00C3\u00AAncia de Cr\u00C3\u00A9dito para outro cliente do mesmo Emissor Este m\u00C3\u00A9todo permite que um portador de um cart\u00C3\u00A3o possa realizar auma transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para outro cliente do mesmo emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do cliente portador do cart\u00C3\u00A3o que ser\u00C3\u00A1 debitado (id).</param> 
        /// <param name="idContaDestino">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do cliente portador do cart\u00C3\u00A3o que ser\u00C3\u00A1 creditado (id).</param> 
        /// <param name="valorTransferencia">Valor da Transfer\u00C3\u00AAncia.</param> 
        /// <returns>ApiResponse of PageTransferencias</returns>
        public ApiResponse< PageTransferencias > TransferirUsingPOST1WithHttpInfo (long? id, long? idContaDestino, double? valorTransferencia)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->TransferirUsingPOST1");
            
            // verify the required parameter 'idContaDestino' is set
            if (idContaDestino == null)
                throw new ApiException(400, "Missing required parameter 'idContaDestino' when calling ContaApi->TransferirUsingPOST1");
            
            // verify the required parameter 'valorTransferencia' is set
            if (valorTransferencia == null)
                throw new ApiException(400, "Missing required parameter 'valorTransferencia' when calling ContaApi->TransferirUsingPOST1");
            
    
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
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling TransferirUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TransferirUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTransferencias>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransferencias) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransferencias)));
            
        }

        
        /// <summary>
        /// Realiza uma transfer\u00C3\u00AAncia de Cr\u00C3\u00A9dito para outro cliente do mesmo Emissor Este m\u00C3\u00A9todo permite que um portador de um cart\u00C3\u00A3o possa realizar auma transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para outro cliente do mesmo emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do cliente portador do cart\u00C3\u00A3o que ser\u00C3\u00A1 debitado (id).</param>
        /// <param name="idContaDestino">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do cliente portador do cart\u00C3\u00A3o que ser\u00C3\u00A1 creditado (id).</param>
        /// <param name="valorTransferencia">Valor da Transfer\u00C3\u00AAncia.</param>
        /// <returns>Task of PageTransferencias</returns>
        public async System.Threading.Tasks.Task<PageTransferencias> TransferirUsingPOST1Async (long? id, long? idContaDestino, double? valorTransferencia)
        {
             ApiResponse<PageTransferencias> localVarResponse = await TransferirUsingPOST1AsyncWithHttpInfo(id, idContaDestino, valorTransferencia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza uma transfer\u00C3\u00AAncia de Cr\u00C3\u00A9dito para outro cliente do mesmo Emissor Este m\u00C3\u00A9todo permite que um portador de um cart\u00C3\u00A3o possa realizar auma transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para outro cliente do mesmo emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do cliente portador do cart\u00C3\u00A3o que ser\u00C3\u00A1 debitado (id).</param>
        /// <param name="idContaDestino">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do cliente portador do cart\u00C3\u00A3o que ser\u00C3\u00A1 creditado (id).</param>
        /// <param name="valorTransferencia">Valor da Transfer\u00C3\u00AAncia.</param>
        /// <returns>Task of ApiResponse (PageTransferencias)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransferencias>> TransferirUsingPOST1AsyncWithHttpInfo (long? id, long? idContaDestino, double? valorTransferencia)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TransferirUsingPOST1");
            // verify the required parameter 'idContaDestino' is set
            if (idContaDestino == null) throw new ApiException(400, "Missing required parameter 'idContaDestino' when calling TransferirUsingPOST1");
            // verify the required parameter 'valorTransferencia' is set
            if (valorTransferencia == null) throw new ApiException(400, "Missing required parameter 'valorTransferencia' when calling TransferirUsingPOST1");
            
    
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
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling TransferirUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TransferirUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTransferencias>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransferencias) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransferencias)));
            
        }
        
    }
    
}
