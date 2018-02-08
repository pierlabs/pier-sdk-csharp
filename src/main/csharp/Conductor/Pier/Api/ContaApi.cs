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
        /// <param name="dataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ.</param>
        /// <param name="valorAjuste">Valor do ajuste</param>
        /// <param name="identificadorExterno">Identificador Externo (optional)</param>
        /// <returns>AjusteFinanceiroResponse</returns>
        AjusteFinanceiroResponse AjustarContaUsingPOST1 (long? id, long? idTipoAjuste, string dataAjuste, double? valorAjuste, string identificadorExterno = null);
  
        /// <summary>
        /// Lan\u00C3\u00A7a um ajuste para a conta do id informado
        /// </summary>
        /// <remarks>
        /// Este recurso insere um ajuste para a conta do id informado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idTipoAjuste">C\u00C3\u00B3digo identificador do tipo de ajuste.</param>
        /// <param name="dataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ.</param>
        /// <param name="valorAjuste">Valor do ajuste</param>
        /// <param name="identificadorExterno">Identificador Externo (optional)</param>
        /// <returns>ApiResponse of AjusteFinanceiroResponse</returns>
        ApiResponse<AjusteFinanceiroResponse> AjustarContaUsingPOST1WithHttpInfo (long? id, long? idTipoAjuste, string dataAjuste, double? valorAjuste, string identificadorExterno = null);
        
        /// <summary>
        /// Altera o produto associado \u00C3\u00A0 conta.
        /// </summary>
        /// <remarks>
        /// O recurso permite fazer modifica\u00C3\u00A7\u00C3\u00A3o do produto associado \u00C3\u00A0 conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="request">request</param>
        /// <returns>string</returns>
        string AlterarProdutoUsingPOST (long? id, AlterarProdutoRequest request);
  
        /// <summary>
        /// Altera o produto associado \u00C3\u00A0 conta.
        /// </summary>
        /// <remarks>
        /// O recurso permite fazer modifica\u00C3\u00A7\u00C3\u00A3o do produto associado \u00C3\u00A0 conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> AlterarProdutoUsingPOSTWithHttpInfo (long? id, AlterarProdutoRequest request);
        
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o de uma Pessoa tilular da conta
        /// </summary>
        /// <remarks>
        /// Esta m\u00C3\u00A9todo permite altera a pessoa de uma conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o de uma Pessoa (id).</param>
        /// <returns>ContaResponse</returns>
        ContaResponse AlterarTitularUsingPOST (long? id, long? idPessoa);
  
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o de uma Pessoa tilular da conta
        /// </summary>
        /// <remarks>
        /// Esta m\u00C3\u00A9todo permite altera a pessoa de uma conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o de uma Pessoa (id).</param>
        /// <returns>ApiResponse of ContaResponse</returns>
        ApiResponse<ContaResponse> AlterarTitularUsingPOSTWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o do dia de vencimento das faturas da conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite alterar o vencimento para no m\u00C3\u00A1ximo at\u00C3\u00A9 30 dias ap\u00C3\u00B3s data atual de uma conta especifica no PIER, respeitando o par\u00C3\u00A2metro de intervalor entre as modifica\u00C3\u00A7\u00C3\u00B5es do vencimento informado pelo emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="novoDiaVencimento">Novo dia de vencimento.</param>
        /// <returns>ContaResponse</returns>
        ContaResponse AlterarVencimentoUsingPUT (long? id, int? novoDiaVencimento);
  
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o do dia de vencimento das faturas da conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite alterar o vencimento para no m\u00C3\u00A1ximo at\u00C3\u00A9 30 dias ap\u00C3\u00B3s data atual de uma conta especifica no PIER, respeitando o par\u00C3\u00A2metro de intervalor entre as modifica\u00C3\u00A7\u00C3\u00B5es do vencimento informado pelo emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="novoDiaVencimento">Novo dia de vencimento.</param>
        /// <returns>ApiResponse of ContaResponse</returns>
        ApiResponse<ContaResponse> AlterarVencimentoUsingPUTWithHttpInfo (long? id, int? novoDiaVencimento);
        
        /// <summary>
        /// Atribuir Anuidade
        /// </summary>
        /// <remarks>
        /// Esse recurso permite configurar qual a regra de Anuidade que ser\u00C3\u00A1 atribu\u00C3\u00ADda a uma determinada Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idAnuidade">Identificador da anuidade</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="DDD">DDD do celular (optional)</param>
        /// <param name="celular">N\u00C3\u00BAmero do celular (optional)</param>
        /// <param name="idOperadora">Identificador da operadora do celular (optional)</param>
        /// <param name="idOrigemComercial">Identificador da origem comercial (optional)</param>
        /// <returns>Object</returns>
        Object AtivarAnuidadeUsingPOST (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null);
  
        /// <summary>
        /// Atribuir Anuidade
        /// </summary>
        /// <remarks>
        /// Esse recurso permite configurar qual a regra de Anuidade que ser\u00C3\u00A1 atribu\u00C3\u00ADda a uma determinada Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idAnuidade">Identificador da anuidade</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="DDD">DDD do celular (optional)</param>
        /// <param name="celular">N\u00C3\u00BAmero do celular (optional)</param>
        /// <param name="idOperadora">Identificador da operadora do celular (optional)</param>
        /// <param name="idOrigemComercial">Identificador da origem comercial (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> AtivarAnuidadeUsingPOSTWithHttpInfo (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null);
        
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
        /// Realiza o bloqueio de uma determinada Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o do bloqueio de uma determinada conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Conta.</param>
        /// <returns>ContaResponse</returns>
        ContaResponse BloquearUsingPOST1 (long? id, long? idStatus);
  
        /// <summary>
        /// Realiza o bloqueio de uma determinada Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o do bloqueio de uma determinada conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Conta.</param>
        /// <returns>ApiResponse of ContaResponse</returns>
        ApiResponse<ContaResponse> BloquearUsingPOST1WithHttpInfo (long? id, long? idStatus);
        
        /// <summary>
        /// Realiza o cancelamento de uma determinada Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o do cancelamento de uma determinada conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Conta.</param>
        /// <returns>ContaResponse</returns>
        ContaResponse CancelarUsingPOST1 (long? id, long? idStatus);
  
        /// <summary>
        /// Realiza o cancelamento de uma determinada Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o do cancelamento de uma determinada conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Conta.</param>
        /// <returns>ApiResponse of ContaResponse</returns>
        ApiResponse<ContaResponse> CancelarUsingPOST1WithHttpInfo (long? id, long? idStatus);
        
        /// <summary>
        /// Apresenta a data m\u00C3\u00A1xima para pagamento da fatura em atraso para receber o benef\u00C3\u00ADcio.
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar se o cliente tem direito ao benef\u00C3\u00ADcio de pagamento em atraso, em loja, at\u00C3\u00A9 o s\u00C3\u00A1bado subsequente ao vencimento, ficando isento do pagamento de multa, encargos, mora e IOF.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>BeneficioPagamentoAtrasoResponse</returns>
        BeneficioPagamentoAtrasoResponse ConsultarBeneficioPagamentoAtrasoUsingGET (long? id);
  
        /// <summary>
        /// Apresenta a data m\u00C3\u00A1xima para pagamento da fatura em atraso para receber o benef\u00C3\u00ADcio.
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar se o cliente tem direito ao benef\u00C3\u00ADcio de pagamento em atraso, em loja, at\u00C3\u00A9 o s\u00C3\u00A1bado subsequente ao vencimento, ficando isento do pagamento de multa, encargos, mora e IOF.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>ApiResponse of BeneficioPagamentoAtrasoResponse</returns>
        ApiResponse<BeneficioPagamentoAtrasoResponse> ConsultarBeneficioPagamentoAtrasoUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta os dados de um determinado boleto da fatura
        /// </summary>
        /// <remarks>
        /// Este recurso consulta um boleto da fatura
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>BoletoResponse</returns>
        BoletoResponse ConsultarBoletoEmitidoUsingGET (long? id);
  
        /// <summary>
        /// Consulta os dados de um determinado boleto da fatura
        /// </summary>
        /// <remarks>
        /// Este recurso consulta um boleto da fatura
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>ApiResponse of BoletoResponse</returns>
        ApiResponse<BoletoResponse> ConsultarBoletoEmitidoUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta a d\u00C3\u00ADvida atualizada do cliente
        /// </summary>
        /// <remarks>
        /// Este recurso consulta a d\u00C3\u00ADvida atualizada do cliente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataVencimento">Data do vencimento (optional)</param>
        /// <param name="idEscritorioCobranca">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do escrit\u00C3\u00B3rio de cobran\u00C3\u00A7a (optional)</param>
        /// <returns>DividaClienteResponse</returns>
        DividaClienteResponse ConsultarDividaAtualizadaClienteUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, long? idEscritorioCobranca = null);
  
        /// <summary>
        /// Consulta a d\u00C3\u00ADvida atualizada do cliente
        /// </summary>
        /// <remarks>
        /// Este recurso consulta a d\u00C3\u00ADvida atualizada do cliente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataVencimento">Data do vencimento (optional)</param>
        /// <param name="idEscritorioCobranca">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do escrit\u00C3\u00B3rio de cobran\u00C3\u00A7a (optional)</param>
        /// <returns>ApiResponse of DividaClienteResponse</returns>
        ApiResponse<DividaClienteResponse> ConsultarDividaAtualizadaClienteUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, long? idEscritorioCobranca = null);
        
        /// <summary>
        /// Permite consultar a partir do ID da conta as taxas e tarifas
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores consultem as taxas e tarifas da conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da conta a ser consultada.</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageTaxasRefinanciamentoResponse</returns>
        PageTaxasRefinanciamentoResponse ConsultarTaxasTarifasUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Permite consultar a partir do ID da conta as taxas e tarifas
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores consultem as taxas e tarifas da conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da conta a ser consultada.</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageTaxasRefinanciamentoResponse</returns>
        ApiResponse<PageTaxasRefinanciamentoResponse> ConsultarTaxasTarifasUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Apresenta dados de uma determinada conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar dados de uma determinada conta a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>ContaDetalheResponse</returns>
        ContaDetalheResponse ConsultarUsingGET12 (long? id);
  
        /// <summary>
        /// Apresenta dados de uma determinada conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar dados de uma determinada conta a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>ApiResponse of ContaDetalheResponse</returns>
        ApiResponse<ContaDetalheResponse> ConsultarUsingGET12WithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta os detalhes de uma determinada transfer\u00C3\u00AAncia
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os detalhes de uma determinada transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito realizada entre contas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idTransferencia">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id_transferencia).</param>
        /// <returns>TransferenciaDetalheResponse</returns>
        TransferenciaDetalheResponse ConsultarUsingGET41 (long? id, long? idTransferencia);
  
        /// <summary>
        /// Consulta os detalhes de uma determinada transfer\u00C3\u00AAncia
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os detalhes de uma determinada transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito realizada entre contas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idTransferencia">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id_transferencia).</param>
        /// <returns>ApiResponse of TransferenciaDetalheResponse</returns>
        ApiResponse<TransferenciaDetalheResponse> ConsultarUsingGET41WithHttpInfo (long? id, long? idTransferencia);
        
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
        /// <param name="valor">Atributo que representa o valor do Boleto Emitido</param>
        /// <param name="dataVencimento">Atributo que representa a data de vencimento do boleto</param>
        /// <returns>BoletoResponse</returns>
        BoletoResponse GerarBoletoRecargaUsingPOST (long? id, double? valor, string dataVencimento);
  
        /// <summary>
        /// Gera um boleto de recarga
        /// </summary>
        /// <remarks>
        /// Este recurso gera um boleto de recarga
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="valor">Atributo que representa o valor do Boleto Emitido</param>
        /// <param name="dataVencimento">Atributo que representa a data de vencimento do boleto</param>
        /// <returns>ApiResponse of BoletoResponse</returns>
        ApiResponse<BoletoResponse> GerarBoletoRecargaUsingPOSTWithHttpInfo (long? id, double? valor, string dataVencimento);
        
        /// <summary>
        /// Realiza o envio para gera\u00C3\u00A7\u00C3\u00A3o de um novo cart\u00C3\u00A3o na gr\u00C3\u00A1fica
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja gerado um novo Cart\u00C3\u00A3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00C3\u00A3o que dever\u00C3\u00A1 ser gerado para impress\u00C3\u00A3o. Esta funcionalidade poder\u00C3\u00A1 ser utilizada para impress\u00C3\u00A3o de cart\u00C3\u00B5es em gr\u00C3\u00A1fica.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="cartaoEmbossingRequest">cartaoEmbossingRequest</param>
        /// <returns>CartaoEmbossingResponse</returns>
        CartaoEmbossingResponse GerarCartaoEmbossingUsingPOST (long? id, CartaoEmbossingRequest cartaoEmbossingRequest);
  
        /// <summary>
        /// Realiza o envio para gera\u00C3\u00A7\u00C3\u00A3o de um novo cart\u00C3\u00A3o na gr\u00C3\u00A1fica
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja gerado um novo Cart\u00C3\u00A3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00C3\u00A3o que dever\u00C3\u00A1 ser gerado para impress\u00C3\u00A3o. Esta funcionalidade poder\u00C3\u00A1 ser utilizada para impress\u00C3\u00A3o de cart\u00C3\u00B5es em gr\u00C3\u00A1fica.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="cartaoEmbossingRequest">cartaoEmbossingRequest</param>
        /// <returns>ApiResponse of CartaoEmbossingResponse</returns>
        ApiResponse<CartaoEmbossingResponse> GerarCartaoEmbossingUsingPOSTWithHttpInfo (long? id, CartaoEmbossingRequest cartaoEmbossingRequest);
        
        /// <summary>
        /// Realiza a gera\u00C3\u00A7\u00C3\u00A3o de um cart\u00C3\u00A3o provisorio
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja gerado um cart\u00C3\u00A3o provis\u00C3\u00B3rio para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>CartaoImpressaoProvisorioResponse</returns>
        CartaoImpressaoProvisorioResponse GerarCartaoProvisorioUsingPOST (long? id);
  
        /// <summary>
        /// Realiza a gera\u00C3\u00A7\u00C3\u00A3o de um cart\u00C3\u00A3o provisorio
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja gerado um cart\u00C3\u00A3o provis\u00C3\u00B3rio para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>ApiResponse of CartaoImpressaoProvisorioResponse</returns>
        ApiResponse<CartaoImpressaoProvisorioResponse> GerarCartaoProvisorioUsingPOSTWithHttpInfo (long? id);
        
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
        /// <returns>CartaoImpressaoResponse</returns>
        CartaoImpressaoResponse GerarCartaoUsingPOST (long? id, long? idPessoa, long? idTipoPlastico = null);
  
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
        /// <returns>ApiResponse of CartaoImpressaoResponse</returns>
        ApiResponse<CartaoImpressaoResponse> GerarCartaoUsingPOSTWithHttpInfo (long? id, long? idPessoa, long? idTipoPlastico = null);
        
        /// <summary>
        /// Realiza a gera\u00C3\u00A7\u00C3\u00A3o de um cart\u00C3\u00A3o virtual
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja gerado um Cart\u00C3\u00A3o virtual para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id). Esta funcionalidade poder\u00C3\u00A1 ser utilizada para realizar a cria\u00C3\u00A7\u00C3\u00A3o de cart\u00C3\u00B5es virtuaes atraves de um app.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="dataValidade">Data de Validade</param>
        /// <returns>CartaoImpressaoResponse</returns>
        CartaoImpressaoResponse GerarCartaoVirtualUsingPOST (long? id, string dataValidade);
  
        /// <summary>
        /// Realiza a gera\u00C3\u00A7\u00C3\u00A3o de um cart\u00C3\u00A3o virtual
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja gerado um Cart\u00C3\u00A3o virtual para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id). Esta funcionalidade poder\u00C3\u00A1 ser utilizada para realizar a cria\u00C3\u00A7\u00C3\u00A3o de cart\u00C3\u00B5es virtuaes atraves de um app.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="dataValidade">Data de Validade</param>
        /// <returns>ApiResponse of CartaoImpressaoResponse</returns>
        ApiResponse<CartaoImpressaoResponse> GerarCartaoVirtualUsingPOSTWithHttpInfo (long? id, string dataValidade);
        
        /// <summary>
        /// Lista o hist\u00C3\u00B3rico de altera\u00C3\u00A7\u00C3\u00B5es de limites da conta
        /// </summary>
        /// <remarks>
        /// Este recurso consulta o hist\u00C3\u00B3rico com as altera\u00C3\u00A7\u00C3\u00B5es de limites da conta informada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageHistoricoEventosResponse</returns>
        PageHistoricoEventosResponse ListarHistoricoAlteracoesLimitesUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista o hist\u00C3\u00B3rico de altera\u00C3\u00A7\u00C3\u00B5es de limites da conta
        /// </summary>
        /// <remarks>
        /// Este recurso consulta o hist\u00C3\u00B3rico com as altera\u00C3\u00A7\u00C3\u00B5es de limites da conta informada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageHistoricoEventosResponse</returns>
        ApiResponse<PageHistoricoEventosResponse> ListarHistoricoAlteracoesLimitesUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista o hist\u00C3\u00B3rico de entradas/sa\u00C3\u00ADdas de assessorias de cobran\u00C3\u00A7a
        /// </summary>
        /// <remarks>
        /// Permite listar todos os registros de entrada e sa\u00C3\u00ADda da Conta em arquivos de integra\u00C3\u00A7\u00C3\u00A3o com empresas de assessorias de cobran\u00C3\u00A7a a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (idConta).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageHistoricoAssessoriaResponse</returns>
        PageHistoricoAssessoriaResponse ListarHistoricoAssessoriaUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista o hist\u00C3\u00B3rico de entradas/sa\u00C3\u00ADdas de assessorias de cobran\u00C3\u00A7a
        /// </summary>
        /// <remarks>
        /// Permite listar todos os registros de entrada e sa\u00C3\u00ADda da Conta em arquivos de integra\u00C3\u00A7\u00C3\u00A3o com empresas de assessorias de cobran\u00C3\u00A7a a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (idConta).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageHistoricoAssessoriaResponse</returns>
        ApiResponse<PageHistoricoAssessoriaResponse> ListarHistoricoAssessoriaUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista o historico de atrasos das faturas
        /// </summary>
        /// <remarks>
        /// Este recurso lista o hist\u00C3\u00B3rico do pagamento de faturas em atraso
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageHistoricoAtrasoFaturaResponse</returns>
        PageHistoricoAtrasoFaturaResponse ListarHistoricoAtrasosFaturasUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista o historico de atrasos das faturas
        /// </summary>
        /// <remarks>
        /// Este recurso lista o hist\u00C3\u00B3rico do pagamento de faturas em atraso
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageHistoricoAtrasoFaturaResponse</returns>
        ApiResponse<PageHistoricoAtrasoFaturaResponse> ListarHistoricoAtrasosFaturasUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista as transa\u00C3\u00A7\u00C3\u00B5es n\u00C3\u00A3o processadas da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas todas as transa\u00C3\u00A7\u00C3\u00B5es n\u00C3\u00A3o processadas da Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataInicio">Data de in\u00C3\u00ADcio da consulta do extrato no formato yyyy-MM-dd (Par\u00C3\u00A2mentro Ignorado se dataFim n\u00C3\u00A3o for definida). (optional)</param>
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Par\u00C3\u00A2mentro Ignorado se dataInicio n\u00C3\u00A3o for definida). (optional)</param>
        /// <returns>PageTransacaoNaoProcessadaResponse</returns>
        PageTransacaoNaoProcessadaResponse ListarNaoProcessadasUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null);
  
        /// <summary>
        /// Lista as transa\u00C3\u00A7\u00C3\u00B5es n\u00C3\u00A3o processadas da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas todas as transa\u00C3\u00A7\u00C3\u00B5es n\u00C3\u00A3o processadas da Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataInicio">Data de in\u00C3\u00ADcio da consulta do extrato no formato yyyy-MM-dd (Par\u00C3\u00A2mentro Ignorado se dataFim n\u00C3\u00A3o for definida). (optional)</param>
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Par\u00C3\u00A2mentro Ignorado se dataInicio n\u00C3\u00A3o for definida). (optional)</param>
        /// <returns>ApiResponse of PageTransacaoNaoProcessadaResponse</returns>
        ApiResponse<PageTransacaoNaoProcessadaResponse> ListarNaoProcessadasUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null);
        
        /// <summary>
        /// Lista as transa\u00C3\u00A7\u00C3\u00B5es processadas da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas todas as transa\u00C3\u00A7\u00C3\u00B5es processadas da Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataVencimento">Data de vencimento do extrato no formato yyyy-MM-dd. (optional)</param>
        /// <param name="dataInicio">Data de in\u00C3\u00ADcio da consulta do extrato no formato yyyy-MM-dd (Ignorado quando o par\u00C3\u00A2mentro dataVencimento \u00C3\u00A9 usado). (optional)</param>
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Ignorado quando o par\u00C3\u00A2mentro dataVencimento \u00C3\u00A9 usado). (optional)</param>
        /// <returns>PageTransacoesCorrentesResponse</returns>
        PageTransacoesCorrentesResponse ListarProcessadasUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null);
  
        /// <summary>
        /// Lista as transa\u00C3\u00A7\u00C3\u00B5es processadas da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas todas as transa\u00C3\u00A7\u00C3\u00B5es processadas da Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataVencimento">Data de vencimento do extrato no formato yyyy-MM-dd. (optional)</param>
        /// <param name="dataInicio">Data de in\u00C3\u00ADcio da consulta do extrato no formato yyyy-MM-dd (Ignorado quando o par\u00C3\u00A2mentro dataVencimento \u00C3\u00A9 usado). (optional)</param>
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Ignorado quando o par\u00C3\u00A2mentro dataVencimento \u00C3\u00A9 usado). (optional)</param>
        /// <returns>ApiResponse of PageTransacoesCorrentesResponse</returns>
        ApiResponse<PageTransacoesCorrentesResponse> ListarProcessadasUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null);
        
        /// <summary>
        /// Lista contas existentes na base de dados do Emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar contas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do produto ao qual a conta faz parte. (id). (optional)</param>
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id) que deu origem a Conta. (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa Titular da Conta (id). (optional)</param>
        /// <param name="idStatusConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do status da conta. (optional)</param>
        /// <param name="diaVencimento">Apresenta o dia de vencimento. (optional)</param>
        /// <param name="melhorDiaCompra">Apresenta o melhor dia de compra. (optional)</param>
        /// <param name="dataStatusConta">Apresenta a data em que o idStatusConta atual fora atribu\u00C3\u00ADdo para ela. (optional)</param>
        /// <param name="dataCadastro">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param>
        /// <param name="dataUltimaAlteracaoVencimento">Apresenta a data da ultima altera\u00C3\u00A7\u00C3\u00A3o de vencimento. (optional)</param>
        /// <returns>PageContaResponse</returns>
        PageContaResponse ListarUsingGET16 (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, string dataStatusConta = null, string dataCadastro = null, string dataUltimaAlteracaoVencimento = null);
  
        /// <summary>
        /// Lista contas existentes na base de dados do Emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar contas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do produto ao qual a conta faz parte. (id). (optional)</param>
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id) que deu origem a Conta. (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa Titular da Conta (id). (optional)</param>
        /// <param name="idStatusConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do status da conta. (optional)</param>
        /// <param name="diaVencimento">Apresenta o dia de vencimento. (optional)</param>
        /// <param name="melhorDiaCompra">Apresenta o melhor dia de compra. (optional)</param>
        /// <param name="dataStatusConta">Apresenta a data em que o idStatusConta atual fora atribu\u00C3\u00ADdo para ela. (optional)</param>
        /// <param name="dataCadastro">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param>
        /// <param name="dataUltimaAlteracaoVencimento">Apresenta a data da ultima altera\u00C3\u00A7\u00C3\u00A3o de vencimento. (optional)</param>
        /// <returns>ApiResponse of PageContaResponse</returns>
        ApiResponse<PageContaResponse> ListarUsingGET16WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, string dataStatusConta = null, string dataCadastro = null, string dataUltimaAlteracaoVencimento = null);
        
        /// <summary>
        /// Lista as transfer\u00C3\u00AAncias realizadas pela conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as transfer\u00C3\u00AAncias realizadas pela conta existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTransferencia">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id). (optional)</param>
        /// <param name="idContaOrigem">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 debitado para a transfer\u00C3\u00AAncia. (id). (optional)</param>
        /// <param name="idContaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 creditado para a transfer\u00C3\u00AAncia. (id). (optional)</param>
        /// <param name="valorTransferencia">Valor estabelecido para ser transferido. (optional)</param>
        /// <param name="dataTransferencia">Data estabelecida para ocorrer a transfer\u00C3\u00AAncia. (optional)</param>
        /// <returns>PageTransferenciaResponse</returns>
        PageTransferenciaResponse ListarUsingGET48 (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, string dataTransferencia = null);
  
        /// <summary>
        /// Lista as transfer\u00C3\u00AAncias realizadas pela conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as transfer\u00C3\u00AAncias realizadas pela conta existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTransferencia">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id). (optional)</param>
        /// <param name="idContaOrigem">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 debitado para a transfer\u00C3\u00AAncia. (id). (optional)</param>
        /// <param name="idContaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 creditado para a transfer\u00C3\u00AAncia. (id). (optional)</param>
        /// <param name="valorTransferencia">Valor estabelecido para ser transferido. (optional)</param>
        /// <param name="dataTransferencia">Data estabelecida para ocorrer a transfer\u00C3\u00AAncia. (optional)</param>
        /// <returns>ApiResponse of PageTransferenciaResponse</returns>
        ApiResponse<PageTransferenciaResponse> ListarUsingGET48WithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, string dataTransferencia = null);
        
        /// <summary>
        /// Realiza a reativa\u00C3\u00A7\u00C3\u00A3o de contas.
        /// </summary>
        /// <remarks>
        /// Este recurso permite reativar contas. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Object</returns>
        Object ReativarUsingPOST1 (long? id);
  
        /// <summary>
        /// Realiza a reativa\u00C3\u00A7\u00C3\u00A3o de contas.
        /// </summary>
        /// <remarks>
        /// Este recurso permite reativar contas. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ReativarUsingPOST1WithHttpInfo (long? id);
        
        /// <summary>
        /// Simula valores de presta\u00C3\u00A7\u00C3\u00B5es de empr\u00C3\u00A9stimos/financiamentos
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o pode ser utilizada para simular opera\u00C3\u00A7\u00C3\u00B5es financeiras a partir de informa\u00C3\u00A7\u00C3\u00B5es fornecidas pelo usu\u00C3\u00A1rio. Os c\u00C3\u00A1lculos gerados devem ser considerados apenas como refer\u00C3\u00AAncia para as situa\u00C3\u00A7\u00C3\u00B5es reais e n\u00C3\u00A3o como valores oficiais.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="request">request</param>
        /// <returns>EmprestimoPessoalResponse</returns>
        EmprestimoPessoalResponse SimularEmprestimoFinanciamentoUsingPOST (long? id, EmprestimoPessoalRequest request);
  
        /// <summary>
        /// Simula valores de presta\u00C3\u00A7\u00C3\u00B5es de empr\u00C3\u00A9stimos/financiamentos
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o pode ser utilizada para simular opera\u00C3\u00A7\u00C3\u00B5es financeiras a partir de informa\u00C3\u00A7\u00C3\u00B5es fornecidas pelo usu\u00C3\u00A1rio. Os c\u00C3\u00A1lculos gerados devem ser considerados apenas como refer\u00C3\u00AAncia para as situa\u00C3\u00A7\u00C3\u00B5es reais e n\u00C3\u00A3o como valores oficiais.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of EmprestimoPessoalResponse</returns>
        ApiResponse<EmprestimoPessoalResponse> SimularEmprestimoFinanciamentoUsingPOSTWithHttpInfo (long? id, EmprestimoPessoalRequest request);
        
        /// <summary>
        /// Permite listar uma linha do tempo com os eventos da conta
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir a listagem, em formato de timeline, dos eventos vinculados a uma detemrinada conta. Transa\u00C3\u00A7\u00C3\u00B5es, fechamento da fatura, pagamentos, gera\u00C3\u00A7\u00C3\u00A3o de cart\u00C3\u00B5es e altera\u00C3\u00A7\u00C3\u00A3o de limite s\u00C3\u00A3o exemplos de eventos contemplados por esta funcionalidade. Neste m\u00C3\u00A9todo, as opera\u00C3\u00A7\u00C3\u00B5es s\u00C3\u00A3o ordenadas de forma decrescente.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageTransacaoResponse</returns>
        PageTransacaoResponse TransacoesUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Permite listar uma linha do tempo com os eventos da conta
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir a listagem, em formato de timeline, dos eventos vinculados a uma detemrinada conta. Transa\u00C3\u00A7\u00C3\u00B5es, fechamento da fatura, pagamentos, gera\u00C3\u00A7\u00C3\u00A3o de cart\u00C3\u00B5es e altera\u00C3\u00A7\u00C3\u00A3o de limite s\u00C3\u00A3o exemplos de eventos contemplados por esta funcionalidade. Neste m\u00C3\u00A9todo, as opera\u00C3\u00A7\u00C3\u00B5es s\u00C3\u00A3o ordenadas de forma decrescente.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageTransacaoResponse</returns>
        ApiResponse<PageTransacaoResponse> TransacoesUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Realiza uma transfer\u00C3\u00AAncia de Cr\u00C3\u00A9dito para outro cliente do mesmo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que um portador de um cart\u00C3\u00A3o possa realizar auma transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para outro cliente do mesmo emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta do cliente portador do cart\u00C3\u00A3o que ser\u00C3\u00A1 debitado (id).</param>
        /// <param name="idContaDestino">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do cliente portador do cart\u00C3\u00A3o que ser\u00C3\u00A1 creditado (id).</param>
        /// <param name="valorTransferencia">Valor da Transfer\u00C3\u00AAncia.</param>
        /// <returns>TransferenciaDetalheResponse</returns>
        TransferenciaDetalheResponse TransferirUsingPOST1 (long? id, long? idContaDestino, double? valorTransferencia);
  
        /// <summary>
        /// Realiza uma transfer\u00C3\u00AAncia de Cr\u00C3\u00A9dito para outro cliente do mesmo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que um portador de um cart\u00C3\u00A3o possa realizar auma transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para outro cliente do mesmo emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta do cliente portador do cart\u00C3\u00A3o que ser\u00C3\u00A1 debitado (id).</param>
        /// <param name="idContaDestino">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do cliente portador do cart\u00C3\u00A3o que ser\u00C3\u00A1 creditado (id).</param>
        /// <param name="valorTransferencia">Valor da Transfer\u00C3\u00AAncia.</param>
        /// <returns>ApiResponse of TransferenciaDetalheResponse</returns>
        ApiResponse<TransferenciaDetalheResponse> TransferirUsingPOST1WithHttpInfo (long? id, long? idContaDestino, double? valorTransferencia);
        
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
        /// <param name="dataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ.</param>
        /// <param name="valorAjuste">Valor do ajuste</param>
        /// <param name="identificadorExterno">Identificador Externo (optional)</param>
        /// <returns>Task of AjusteFinanceiroResponse</returns>
        System.Threading.Tasks.Task<AjusteFinanceiroResponse> AjustarContaUsingPOST1Async (long? id, long? idTipoAjuste, string dataAjuste, double? valorAjuste, string identificadorExterno = null);

        /// <summary>
        /// Lan\u00C3\u00A7a um ajuste para a conta do id informado
        /// </summary>
        /// <remarks>
        /// Este recurso insere um ajuste para a conta do id informado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idTipoAjuste">C\u00C3\u00B3digo identificador do tipo de ajuste.</param>
        /// <param name="dataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ.</param>
        /// <param name="valorAjuste">Valor do ajuste</param>
        /// <param name="identificadorExterno">Identificador Externo (optional)</param>
        /// <returns>Task of ApiResponse (AjusteFinanceiroResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AjusteFinanceiroResponse>> AjustarContaUsingPOST1AsyncWithHttpInfo (long? id, long? idTipoAjuste, string dataAjuste, double? valorAjuste, string identificadorExterno = null);
        
        /// <summary>
        /// Altera o produto associado \u00C3\u00A0 conta.
        /// </summary>
        /// <remarks>
        /// O recurso permite fazer modifica\u00C3\u00A7\u00C3\u00A3o do produto associado \u00C3\u00A0 conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="request">request</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> AlterarProdutoUsingPOSTAsync (long? id, AlterarProdutoRequest request);

        /// <summary>
        /// Altera o produto associado \u00C3\u00A0 conta.
        /// </summary>
        /// <remarks>
        /// O recurso permite fazer modifica\u00C3\u00A7\u00C3\u00A3o do produto associado \u00C3\u00A0 conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> AlterarProdutoUsingPOSTAsyncWithHttpInfo (long? id, AlterarProdutoRequest request);
        
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o de uma Pessoa tilular da conta
        /// </summary>
        /// <remarks>
        /// Esta m\u00C3\u00A9todo permite altera a pessoa de uma conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o de uma Pessoa (id).</param>
        /// <returns>Task of ContaResponse</returns>
        System.Threading.Tasks.Task<ContaResponse> AlterarTitularUsingPOSTAsync (long? id, long? idPessoa);

        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o de uma Pessoa tilular da conta
        /// </summary>
        /// <remarks>
        /// Esta m\u00C3\u00A9todo permite altera a pessoa de uma conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o de uma Pessoa (id).</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaResponse>> AlterarTitularUsingPOSTAsyncWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o do dia de vencimento das faturas da conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite alterar o vencimento para no m\u00C3\u00A1ximo at\u00C3\u00A9 30 dias ap\u00C3\u00B3s data atual de uma conta especifica no PIER, respeitando o par\u00C3\u00A2metro de intervalor entre as modifica\u00C3\u00A7\u00C3\u00B5es do vencimento informado pelo emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="novoDiaVencimento">Novo dia de vencimento.</param>
        /// <returns>Task of ContaResponse</returns>
        System.Threading.Tasks.Task<ContaResponse> AlterarVencimentoUsingPUTAsync (long? id, int? novoDiaVencimento);

        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o do dia de vencimento das faturas da conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite alterar o vencimento para no m\u00C3\u00A1ximo at\u00C3\u00A9 30 dias ap\u00C3\u00B3s data atual de uma conta especifica no PIER, respeitando o par\u00C3\u00A2metro de intervalor entre as modifica\u00C3\u00A7\u00C3\u00B5es do vencimento informado pelo emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="novoDiaVencimento">Novo dia de vencimento.</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaResponse>> AlterarVencimentoUsingPUTAsyncWithHttpInfo (long? id, int? novoDiaVencimento);
        
        /// <summary>
        /// Atribuir Anuidade
        /// </summary>
        /// <remarks>
        /// Esse recurso permite configurar qual a regra de Anuidade que ser\u00C3\u00A1 atribu\u00C3\u00ADda a uma determinada Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idAnuidade">Identificador da anuidade</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="DDD">DDD do celular (optional)</param>
        /// <param name="celular">N\u00C3\u00BAmero do celular (optional)</param>
        /// <param name="idOperadora">Identificador da operadora do celular (optional)</param>
        /// <param name="idOrigemComercial">Identificador da origem comercial (optional)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> AtivarAnuidadeUsingPOSTAsync (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null);

        /// <summary>
        /// Atribuir Anuidade
        /// </summary>
        /// <remarks>
        /// Esse recurso permite configurar qual a regra de Anuidade que ser\u00C3\u00A1 atribu\u00C3\u00ADda a uma determinada Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idAnuidade">Identificador da anuidade</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="DDD">DDD do celular (optional)</param>
        /// <param name="celular">N\u00C3\u00BAmero do celular (optional)</param>
        /// <param name="idOperadora">Identificador da operadora do celular (optional)</param>
        /// <param name="idOrigemComercial">Identificador da origem comercial (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AtivarAnuidadeUsingPOSTAsyncWithHttpInfo (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null);
        
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
        /// Realiza o bloqueio de uma determinada Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o do bloqueio de uma determinada conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Conta.</param>
        /// <returns>Task of ContaResponse</returns>
        System.Threading.Tasks.Task<ContaResponse> BloquearUsingPOST1Async (long? id, long? idStatus);

        /// <summary>
        /// Realiza o bloqueio de uma determinada Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o do bloqueio de uma determinada conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Conta.</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaResponse>> BloquearUsingPOST1AsyncWithHttpInfo (long? id, long? idStatus);
        
        /// <summary>
        /// Realiza o cancelamento de uma determinada Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o do cancelamento de uma determinada conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Conta.</param>
        /// <returns>Task of ContaResponse</returns>
        System.Threading.Tasks.Task<ContaResponse> CancelarUsingPOST1Async (long? id, long? idStatus);

        /// <summary>
        /// Realiza o cancelamento de uma determinada Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o do cancelamento de uma determinada conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Conta.</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaResponse>> CancelarUsingPOST1AsyncWithHttpInfo (long? id, long? idStatus);
        
        /// <summary>
        /// Apresenta a data m\u00C3\u00A1xima para pagamento da fatura em atraso para receber o benef\u00C3\u00ADcio.
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar se o cliente tem direito ao benef\u00C3\u00ADcio de pagamento em atraso, em loja, at\u00C3\u00A9 o s\u00C3\u00A1bado subsequente ao vencimento, ficando isento do pagamento de multa, encargos, mora e IOF.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>Task of BeneficioPagamentoAtrasoResponse</returns>
        System.Threading.Tasks.Task<BeneficioPagamentoAtrasoResponse> ConsultarBeneficioPagamentoAtrasoUsingGETAsync (long? id);

        /// <summary>
        /// Apresenta a data m\u00C3\u00A1xima para pagamento da fatura em atraso para receber o benef\u00C3\u00ADcio.
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar se o cliente tem direito ao benef\u00C3\u00ADcio de pagamento em atraso, em loja, at\u00C3\u00A9 o s\u00C3\u00A1bado subsequente ao vencimento, ficando isento do pagamento de multa, encargos, mora e IOF.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>Task of ApiResponse (BeneficioPagamentoAtrasoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BeneficioPagamentoAtrasoResponse>> ConsultarBeneficioPagamentoAtrasoUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta os dados de um determinado boleto da fatura
        /// </summary>
        /// <remarks>
        /// Este recurso consulta um boleto da fatura
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Task of BoletoResponse</returns>
        System.Threading.Tasks.Task<BoletoResponse> ConsultarBoletoEmitidoUsingGETAsync (long? id);

        /// <summary>
        /// Consulta os dados de um determinado boleto da fatura
        /// </summary>
        /// <remarks>
        /// Este recurso consulta um boleto da fatura
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Task of ApiResponse (BoletoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BoletoResponse>> ConsultarBoletoEmitidoUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta a d\u00C3\u00ADvida atualizada do cliente
        /// </summary>
        /// <remarks>
        /// Este recurso consulta a d\u00C3\u00ADvida atualizada do cliente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataVencimento">Data do vencimento (optional)</param>
        /// <param name="idEscritorioCobranca">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do escrit\u00C3\u00B3rio de cobran\u00C3\u00A7a (optional)</param>
        /// <returns>Task of DividaClienteResponse</returns>
        System.Threading.Tasks.Task<DividaClienteResponse> ConsultarDividaAtualizadaClienteUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, long? idEscritorioCobranca = null);

        /// <summary>
        /// Consulta a d\u00C3\u00ADvida atualizada do cliente
        /// </summary>
        /// <remarks>
        /// Este recurso consulta a d\u00C3\u00ADvida atualizada do cliente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataVencimento">Data do vencimento (optional)</param>
        /// <param name="idEscritorioCobranca">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do escrit\u00C3\u00B3rio de cobran\u00C3\u00A7a (optional)</param>
        /// <returns>Task of ApiResponse (DividaClienteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DividaClienteResponse>> ConsultarDividaAtualizadaClienteUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, long? idEscritorioCobranca = null);
        
        /// <summary>
        /// Permite consultar a partir do ID da conta as taxas e tarifas
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores consultem as taxas e tarifas da conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da conta a ser consultada.</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageTaxasRefinanciamentoResponse</returns>
        System.Threading.Tasks.Task<PageTaxasRefinanciamentoResponse> ConsultarTaxasTarifasUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Permite consultar a partir do ID da conta as taxas e tarifas
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores consultem as taxas e tarifas da conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da conta a ser consultada.</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTaxasRefinanciamentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTaxasRefinanciamentoResponse>> ConsultarTaxasTarifasUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Apresenta dados de uma determinada conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar dados de uma determinada conta a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>Task of ContaDetalheResponse</returns>
        System.Threading.Tasks.Task<ContaDetalheResponse> ConsultarUsingGET12Async (long? id);

        /// <summary>
        /// Apresenta dados de uma determinada conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar dados de uma determinada conta a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>Task of ApiResponse (ContaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaDetalheResponse>> ConsultarUsingGET12AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta os detalhes de uma determinada transfer\u00C3\u00AAncia
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os detalhes de uma determinada transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito realizada entre contas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idTransferencia">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id_transferencia).</param>
        /// <returns>Task of TransferenciaDetalheResponse</returns>
        System.Threading.Tasks.Task<TransferenciaDetalheResponse> ConsultarUsingGET41Async (long? id, long? idTransferencia);

        /// <summary>
        /// Consulta os detalhes de uma determinada transfer\u00C3\u00AAncia
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os detalhes de uma determinada transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito realizada entre contas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idTransferencia">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id_transferencia).</param>
        /// <returns>Task of ApiResponse (TransferenciaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransferenciaDetalheResponse>> ConsultarUsingGET41AsyncWithHttpInfo (long? id, long? idTransferencia);
        
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
        /// <param name="valor">Atributo que representa o valor do Boleto Emitido</param>
        /// <param name="dataVencimento">Atributo que representa a data de vencimento do boleto</param>
        /// <returns>Task of BoletoResponse</returns>
        System.Threading.Tasks.Task<BoletoResponse> GerarBoletoRecargaUsingPOSTAsync (long? id, double? valor, string dataVencimento);

        /// <summary>
        /// Gera um boleto de recarga
        /// </summary>
        /// <remarks>
        /// Este recurso gera um boleto de recarga
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="valor">Atributo que representa o valor do Boleto Emitido</param>
        /// <param name="dataVencimento">Atributo que representa a data de vencimento do boleto</param>
        /// <returns>Task of ApiResponse (BoletoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BoletoResponse>> GerarBoletoRecargaUsingPOSTAsyncWithHttpInfo (long? id, double? valor, string dataVencimento);
        
        /// <summary>
        /// Realiza o envio para gera\u00C3\u00A7\u00C3\u00A3o de um novo cart\u00C3\u00A3o na gr\u00C3\u00A1fica
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja gerado um novo Cart\u00C3\u00A3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00C3\u00A3o que dever\u00C3\u00A1 ser gerado para impress\u00C3\u00A3o. Esta funcionalidade poder\u00C3\u00A1 ser utilizada para impress\u00C3\u00A3o de cart\u00C3\u00B5es em gr\u00C3\u00A1fica.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="cartaoEmbossingRequest">cartaoEmbossingRequest</param>
        /// <returns>Task of CartaoEmbossingResponse</returns>
        System.Threading.Tasks.Task<CartaoEmbossingResponse> GerarCartaoEmbossingUsingPOSTAsync (long? id, CartaoEmbossingRequest cartaoEmbossingRequest);

        /// <summary>
        /// Realiza o envio para gera\u00C3\u00A7\u00C3\u00A3o de um novo cart\u00C3\u00A3o na gr\u00C3\u00A1fica
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja gerado um novo Cart\u00C3\u00A3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00C3\u00A3o que dever\u00C3\u00A1 ser gerado para impress\u00C3\u00A3o. Esta funcionalidade poder\u00C3\u00A1 ser utilizada para impress\u00C3\u00A3o de cart\u00C3\u00B5es em gr\u00C3\u00A1fica.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="cartaoEmbossingRequest">cartaoEmbossingRequest</param>
        /// <returns>Task of ApiResponse (CartaoEmbossingResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoEmbossingResponse>> GerarCartaoEmbossingUsingPOSTAsyncWithHttpInfo (long? id, CartaoEmbossingRequest cartaoEmbossingRequest);
        
        /// <summary>
        /// Realiza a gera\u00C3\u00A7\u00C3\u00A3o de um cart\u00C3\u00A3o provisorio
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja gerado um cart\u00C3\u00A3o provis\u00C3\u00B3rio para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>Task of CartaoImpressaoProvisorioResponse</returns>
        System.Threading.Tasks.Task<CartaoImpressaoProvisorioResponse> GerarCartaoProvisorioUsingPOSTAsync (long? id);

        /// <summary>
        /// Realiza a gera\u00C3\u00A7\u00C3\u00A3o de um cart\u00C3\u00A3o provisorio
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja gerado um cart\u00C3\u00A3o provis\u00C3\u00B3rio para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>Task of ApiResponse (CartaoImpressaoProvisorioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoImpressaoProvisorioResponse>> GerarCartaoProvisorioUsingPOSTAsyncWithHttpInfo (long? id);
        
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
        /// <returns>Task of CartaoImpressaoResponse</returns>
        System.Threading.Tasks.Task<CartaoImpressaoResponse> GerarCartaoUsingPOSTAsync (long? id, long? idPessoa, long? idTipoPlastico = null);

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
        /// <returns>Task of ApiResponse (CartaoImpressaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoImpressaoResponse>> GerarCartaoUsingPOSTAsyncWithHttpInfo (long? id, long? idPessoa, long? idTipoPlastico = null);
        
        /// <summary>
        /// Realiza a gera\u00C3\u00A7\u00C3\u00A3o de um cart\u00C3\u00A3o virtual
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja gerado um Cart\u00C3\u00A3o virtual para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id). Esta funcionalidade poder\u00C3\u00A1 ser utilizada para realizar a cria\u00C3\u00A7\u00C3\u00A3o de cart\u00C3\u00B5es virtuaes atraves de um app.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="dataValidade">Data de Validade</param>
        /// <returns>Task of CartaoImpressaoResponse</returns>
        System.Threading.Tasks.Task<CartaoImpressaoResponse> GerarCartaoVirtualUsingPOSTAsync (long? id, string dataValidade);

        /// <summary>
        /// Realiza a gera\u00C3\u00A7\u00C3\u00A3o de um cart\u00C3\u00A3o virtual
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja gerado um Cart\u00C3\u00A3o virtual para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id). Esta funcionalidade poder\u00C3\u00A1 ser utilizada para realizar a cria\u00C3\u00A7\u00C3\u00A3o de cart\u00C3\u00B5es virtuaes atraves de um app.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="dataValidade">Data de Validade</param>
        /// <returns>Task of ApiResponse (CartaoImpressaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoImpressaoResponse>> GerarCartaoVirtualUsingPOSTAsyncWithHttpInfo (long? id, string dataValidade);
        
        /// <summary>
        /// Lista o hist\u00C3\u00B3rico de altera\u00C3\u00A7\u00C3\u00B5es de limites da conta
        /// </summary>
        /// <remarks>
        /// Este recurso consulta o hist\u00C3\u00B3rico com as altera\u00C3\u00A7\u00C3\u00B5es de limites da conta informada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageHistoricoEventosResponse</returns>
        System.Threading.Tasks.Task<PageHistoricoEventosResponse> ListarHistoricoAlteracoesLimitesUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista o hist\u00C3\u00B3rico de altera\u00C3\u00A7\u00C3\u00B5es de limites da conta
        /// </summary>
        /// <remarks>
        /// Este recurso consulta o hist\u00C3\u00B3rico com as altera\u00C3\u00A7\u00C3\u00B5es de limites da conta informada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoEventosResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageHistoricoEventosResponse>> ListarHistoricoAlteracoesLimitesUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista o hist\u00C3\u00B3rico de entradas/sa\u00C3\u00ADdas de assessorias de cobran\u00C3\u00A7a
        /// </summary>
        /// <remarks>
        /// Permite listar todos os registros de entrada e sa\u00C3\u00ADda da Conta em arquivos de integra\u00C3\u00A7\u00C3\u00A3o com empresas de assessorias de cobran\u00C3\u00A7a a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (idConta).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageHistoricoAssessoriaResponse</returns>
        System.Threading.Tasks.Task<PageHistoricoAssessoriaResponse> ListarHistoricoAssessoriaUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista o hist\u00C3\u00B3rico de entradas/sa\u00C3\u00ADdas de assessorias de cobran\u00C3\u00A7a
        /// </summary>
        /// <remarks>
        /// Permite listar todos os registros de entrada e sa\u00C3\u00ADda da Conta em arquivos de integra\u00C3\u00A7\u00C3\u00A3o com empresas de assessorias de cobran\u00C3\u00A7a a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (idConta).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoAssessoriaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageHistoricoAssessoriaResponse>> ListarHistoricoAssessoriaUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista o historico de atrasos das faturas
        /// </summary>
        /// <remarks>
        /// Este recurso lista o hist\u00C3\u00B3rico do pagamento de faturas em atraso
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageHistoricoAtrasoFaturaResponse</returns>
        System.Threading.Tasks.Task<PageHistoricoAtrasoFaturaResponse> ListarHistoricoAtrasosFaturasUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista o historico de atrasos das faturas
        /// </summary>
        /// <remarks>
        /// Este recurso lista o hist\u00C3\u00B3rico do pagamento de faturas em atraso
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoAtrasoFaturaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageHistoricoAtrasoFaturaResponse>> ListarHistoricoAtrasosFaturasUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista as transa\u00C3\u00A7\u00C3\u00B5es n\u00C3\u00A3o processadas da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas todas as transa\u00C3\u00A7\u00C3\u00B5es n\u00C3\u00A3o processadas da Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataInicio">Data de in\u00C3\u00ADcio da consulta do extrato no formato yyyy-MM-dd (Par\u00C3\u00A2mentro Ignorado se dataFim n\u00C3\u00A3o for definida). (optional)</param>
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Par\u00C3\u00A2mentro Ignorado se dataInicio n\u00C3\u00A3o for definida). (optional)</param>
        /// <returns>Task of PageTransacaoNaoProcessadaResponse</returns>
        System.Threading.Tasks.Task<PageTransacaoNaoProcessadaResponse> ListarNaoProcessadasUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null);

        /// <summary>
        /// Lista as transa\u00C3\u00A7\u00C3\u00B5es n\u00C3\u00A3o processadas da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas todas as transa\u00C3\u00A7\u00C3\u00B5es n\u00C3\u00A3o processadas da Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataInicio">Data de in\u00C3\u00ADcio da consulta do extrato no formato yyyy-MM-dd (Par\u00C3\u00A2mentro Ignorado se dataFim n\u00C3\u00A3o for definida). (optional)</param>
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Par\u00C3\u00A2mentro Ignorado se dataInicio n\u00C3\u00A3o for definida). (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacaoNaoProcessadaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransacaoNaoProcessadaResponse>> ListarNaoProcessadasUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null);
        
        /// <summary>
        /// Lista as transa\u00C3\u00A7\u00C3\u00B5es processadas da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas todas as transa\u00C3\u00A7\u00C3\u00B5es processadas da Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataVencimento">Data de vencimento do extrato no formato yyyy-MM-dd. (optional)</param>
        /// <param name="dataInicio">Data de in\u00C3\u00ADcio da consulta do extrato no formato yyyy-MM-dd (Ignorado quando o par\u00C3\u00A2mentro dataVencimento \u00C3\u00A9 usado). (optional)</param>
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Ignorado quando o par\u00C3\u00A2mentro dataVencimento \u00C3\u00A9 usado). (optional)</param>
        /// <returns>Task of PageTransacoesCorrentesResponse</returns>
        System.Threading.Tasks.Task<PageTransacoesCorrentesResponse> ListarProcessadasUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null);

        /// <summary>
        /// Lista as transa\u00C3\u00A7\u00C3\u00B5es processadas da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas todas as transa\u00C3\u00A7\u00C3\u00B5es processadas da Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataVencimento">Data de vencimento do extrato no formato yyyy-MM-dd. (optional)</param>
        /// <param name="dataInicio">Data de in\u00C3\u00ADcio da consulta do extrato no formato yyyy-MM-dd (Ignorado quando o par\u00C3\u00A2mentro dataVencimento \u00C3\u00A9 usado). (optional)</param>
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Ignorado quando o par\u00C3\u00A2mentro dataVencimento \u00C3\u00A9 usado). (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacoesCorrentesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransacoesCorrentesResponse>> ListarProcessadasUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null);
        
        /// <summary>
        /// Lista contas existentes na base de dados do Emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar contas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do produto ao qual a conta faz parte. (id). (optional)</param>
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id) que deu origem a Conta. (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa Titular da Conta (id). (optional)</param>
        /// <param name="idStatusConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do status da conta. (optional)</param>
        /// <param name="diaVencimento">Apresenta o dia de vencimento. (optional)</param>
        /// <param name="melhorDiaCompra">Apresenta o melhor dia de compra. (optional)</param>
        /// <param name="dataStatusConta">Apresenta a data em que o idStatusConta atual fora atribu\u00C3\u00ADdo para ela. (optional)</param>
        /// <param name="dataCadastro">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param>
        /// <param name="dataUltimaAlteracaoVencimento">Apresenta a data da ultima altera\u00C3\u00A7\u00C3\u00A3o de vencimento. (optional)</param>
        /// <returns>Task of PageContaResponse</returns>
        System.Threading.Tasks.Task<PageContaResponse> ListarUsingGET16Async (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, string dataStatusConta = null, string dataCadastro = null, string dataUltimaAlteracaoVencimento = null);

        /// <summary>
        /// Lista contas existentes na base de dados do Emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar contas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do produto ao qual a conta faz parte. (id). (optional)</param>
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id) que deu origem a Conta. (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa Titular da Conta (id). (optional)</param>
        /// <param name="idStatusConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do status da conta. (optional)</param>
        /// <param name="diaVencimento">Apresenta o dia de vencimento. (optional)</param>
        /// <param name="melhorDiaCompra">Apresenta o melhor dia de compra. (optional)</param>
        /// <param name="dataStatusConta">Apresenta a data em que o idStatusConta atual fora atribu\u00C3\u00ADdo para ela. (optional)</param>
        /// <param name="dataCadastro">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param>
        /// <param name="dataUltimaAlteracaoVencimento">Apresenta a data da ultima altera\u00C3\u00A7\u00C3\u00A3o de vencimento. (optional)</param>
        /// <returns>Task of ApiResponse (PageContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageContaResponse>> ListarUsingGET16AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, string dataStatusConta = null, string dataCadastro = null, string dataUltimaAlteracaoVencimento = null);
        
        /// <summary>
        /// Lista as transfer\u00C3\u00AAncias realizadas pela conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as transfer\u00C3\u00AAncias realizadas pela conta existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTransferencia">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id). (optional)</param>
        /// <param name="idContaOrigem">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 debitado para a transfer\u00C3\u00AAncia. (id). (optional)</param>
        /// <param name="idContaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 creditado para a transfer\u00C3\u00AAncia. (id). (optional)</param>
        /// <param name="valorTransferencia">Valor estabelecido para ser transferido. (optional)</param>
        /// <param name="dataTransferencia">Data estabelecida para ocorrer a transfer\u00C3\u00AAncia. (optional)</param>
        /// <returns>Task of PageTransferenciaResponse</returns>
        System.Threading.Tasks.Task<PageTransferenciaResponse> ListarUsingGET48Async (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, string dataTransferencia = null);

        /// <summary>
        /// Lista as transfer\u00C3\u00AAncias realizadas pela conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as transfer\u00C3\u00AAncias realizadas pela conta existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTransferencia">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id). (optional)</param>
        /// <param name="idContaOrigem">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 debitado para a transfer\u00C3\u00AAncia. (id). (optional)</param>
        /// <param name="idContaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 creditado para a transfer\u00C3\u00AAncia. (id). (optional)</param>
        /// <param name="valorTransferencia">Valor estabelecido para ser transferido. (optional)</param>
        /// <param name="dataTransferencia">Data estabelecida para ocorrer a transfer\u00C3\u00AAncia. (optional)</param>
        /// <returns>Task of ApiResponse (PageTransferenciaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransferenciaResponse>> ListarUsingGET48AsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, string dataTransferencia = null);
        
        /// <summary>
        /// Realiza a reativa\u00C3\u00A7\u00C3\u00A3o de contas.
        /// </summary>
        /// <remarks>
        /// Este recurso permite reativar contas. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ReativarUsingPOST1Async (long? id);

        /// <summary>
        /// Realiza a reativa\u00C3\u00A7\u00C3\u00A3o de contas.
        /// </summary>
        /// <remarks>
        /// Este recurso permite reativar contas. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ReativarUsingPOST1AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Simula valores de presta\u00C3\u00A7\u00C3\u00B5es de empr\u00C3\u00A9stimos/financiamentos
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o pode ser utilizada para simular opera\u00C3\u00A7\u00C3\u00B5es financeiras a partir de informa\u00C3\u00A7\u00C3\u00B5es fornecidas pelo usu\u00C3\u00A1rio. Os c\u00C3\u00A1lculos gerados devem ser considerados apenas como refer\u00C3\u00AAncia para as situa\u00C3\u00A7\u00C3\u00B5es reais e n\u00C3\u00A3o como valores oficiais.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="request">request</param>
        /// <returns>Task of EmprestimoPessoalResponse</returns>
        System.Threading.Tasks.Task<EmprestimoPessoalResponse> SimularEmprestimoFinanciamentoUsingPOSTAsync (long? id, EmprestimoPessoalRequest request);

        /// <summary>
        /// Simula valores de presta\u00C3\u00A7\u00C3\u00B5es de empr\u00C3\u00A9stimos/financiamentos
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o pode ser utilizada para simular opera\u00C3\u00A7\u00C3\u00B5es financeiras a partir de informa\u00C3\u00A7\u00C3\u00B5es fornecidas pelo usu\u00C3\u00A1rio. Os c\u00C3\u00A1lculos gerados devem ser considerados apenas como refer\u00C3\u00AAncia para as situa\u00C3\u00A7\u00C3\u00B5es reais e n\u00C3\u00A3o como valores oficiais.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (EmprestimoPessoalResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmprestimoPessoalResponse>> SimularEmprestimoFinanciamentoUsingPOSTAsyncWithHttpInfo (long? id, EmprestimoPessoalRequest request);
        
        /// <summary>
        /// Permite listar uma linha do tempo com os eventos da conta
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir a listagem, em formato de timeline, dos eventos vinculados a uma detemrinada conta. Transa\u00C3\u00A7\u00C3\u00B5es, fechamento da fatura, pagamentos, gera\u00C3\u00A7\u00C3\u00A3o de cart\u00C3\u00B5es e altera\u00C3\u00A7\u00C3\u00A3o de limite s\u00C3\u00A3o exemplos de eventos contemplados por esta funcionalidade. Neste m\u00C3\u00A9todo, as opera\u00C3\u00A7\u00C3\u00B5es s\u00C3\u00A3o ordenadas de forma decrescente.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageTransacaoResponse</returns>
        System.Threading.Tasks.Task<PageTransacaoResponse> TransacoesUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Permite listar uma linha do tempo com os eventos da conta
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir a listagem, em formato de timeline, dos eventos vinculados a uma detemrinada conta. Transa\u00C3\u00A7\u00C3\u00B5es, fechamento da fatura, pagamentos, gera\u00C3\u00A7\u00C3\u00A3o de cart\u00C3\u00B5es e altera\u00C3\u00A7\u00C3\u00A3o de limite s\u00C3\u00A3o exemplos de eventos contemplados por esta funcionalidade. Neste m\u00C3\u00A9todo, as opera\u00C3\u00A7\u00C3\u00B5es s\u00C3\u00A3o ordenadas de forma decrescente.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransacaoResponse>> TransacoesUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Realiza uma transfer\u00C3\u00AAncia de Cr\u00C3\u00A9dito para outro cliente do mesmo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que um portador de um cart\u00C3\u00A3o possa realizar auma transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para outro cliente do mesmo emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta do cliente portador do cart\u00C3\u00A3o que ser\u00C3\u00A1 debitado (id).</param>
        /// <param name="idContaDestino">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do cliente portador do cart\u00C3\u00A3o que ser\u00C3\u00A1 creditado (id).</param>
        /// <param name="valorTransferencia">Valor da Transfer\u00C3\u00AAncia.</param>
        /// <returns>Task of TransferenciaDetalheResponse</returns>
        System.Threading.Tasks.Task<TransferenciaDetalheResponse> TransferirUsingPOST1Async (long? id, long? idContaDestino, double? valorTransferencia);

        /// <summary>
        /// Realiza uma transfer\u00C3\u00AAncia de Cr\u00C3\u00A9dito para outro cliente do mesmo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que um portador de um cart\u00C3\u00A3o possa realizar auma transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para outro cliente do mesmo emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta do cliente portador do cart\u00C3\u00A3o que ser\u00C3\u00A1 debitado (id).</param>
        /// <param name="idContaDestino">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do cliente portador do cart\u00C3\u00A3o que ser\u00C3\u00A1 creditado (id).</param>
        /// <param name="valorTransferencia">Valor da Transfer\u00C3\u00AAncia.</param>
        /// <returns>Task of ApiResponse (TransferenciaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransferenciaDetalheResponse>> TransferirUsingPOST1AsyncWithHttpInfo (long? id, long? idContaDestino, double? valorTransferencia);
        
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
        /// <param name="dataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ.</param> 
        /// <param name="valorAjuste">Valor do ajuste</param> 
        /// <param name="identificadorExterno">Identificador Externo (optional)</param> 
        /// <returns>AjusteFinanceiroResponse</returns>
        public AjusteFinanceiroResponse AjustarContaUsingPOST1 (long? id, long? idTipoAjuste, string dataAjuste, double? valorAjuste, string identificadorExterno = null)
        {
             ApiResponse<AjusteFinanceiroResponse> localVarResponse = AjustarContaUsingPOST1WithHttpInfo(id, idTipoAjuste, dataAjuste, valorAjuste, identificadorExterno);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lan\u00C3\u00A7a um ajuste para a conta do id informado Este recurso insere um ajuste para a conta do id informado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="idTipoAjuste">C\u00C3\u00B3digo identificador do tipo de ajuste.</param> 
        /// <param name="dataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ.</param> 
        /// <param name="valorAjuste">Valor do ajuste</param> 
        /// <param name="identificadorExterno">Identificador Externo (optional)</param> 
        /// <returns>ApiResponse of AjusteFinanceiroResponse</returns>
        public ApiResponse< AjusteFinanceiroResponse > AjustarContaUsingPOST1WithHttpInfo (long? id, long? idTipoAjuste, string dataAjuste, double? valorAjuste, string identificadorExterno = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->AjustarContaUsingPOST1");
            
            // verify the required parameter 'idTipoAjuste' is set
            if (idTipoAjuste == null)
                throw new ApiException(400, "Missing required parameter 'idTipoAjuste' when calling ContaApi->AjustarContaUsingPOST1");
            
            // verify the required parameter 'dataAjuste' is set
            if (dataAjuste == null)
                throw new ApiException(400, "Missing required parameter 'dataAjuste' when calling ContaApi->AjustarContaUsingPOST1");
            
            // verify the required parameter 'valorAjuste' is set
            if (valorAjuste == null)
                throw new ApiException(400, "Missing required parameter 'valorAjuste' when calling ContaApi->AjustarContaUsingPOST1");
            
    
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
            
            if (idTipoAjuste != null) localVarQueryParams.Add("idTipoAjuste", Configuration.ApiClient.ParameterToString(idTipoAjuste)); // query parameter
            if (dataAjuste != null) localVarQueryParams.Add("dataAjuste", Configuration.ApiClient.ParameterToString(dataAjuste)); // query parameter
            if (valorAjuste != null) localVarQueryParams.Add("valorAjuste", Configuration.ApiClient.ParameterToString(valorAjuste)); // query parameter
            if (identificadorExterno != null) localVarQueryParams.Add("identificadorExterno", Configuration.ApiClient.ParameterToString(identificadorExterno)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AjustarContaUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AjustarContaUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AjusteFinanceiroResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AjusteFinanceiroResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AjusteFinanceiroResponse)));
            
        }

        
        /// <summary>
        /// Lan\u00C3\u00A7a um ajuste para a conta do id informado Este recurso insere um ajuste para a conta do id informado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idTipoAjuste">C\u00C3\u00B3digo identificador do tipo de ajuste.</param>
        /// <param name="dataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ.</param>
        /// <param name="valorAjuste">Valor do ajuste</param>
        /// <param name="identificadorExterno">Identificador Externo (optional)</param>
        /// <returns>Task of AjusteFinanceiroResponse</returns>
        public async System.Threading.Tasks.Task<AjusteFinanceiroResponse> AjustarContaUsingPOST1Async (long? id, long? idTipoAjuste, string dataAjuste, double? valorAjuste, string identificadorExterno = null)
        {
             ApiResponse<AjusteFinanceiroResponse> localVarResponse = await AjustarContaUsingPOST1AsyncWithHttpInfo(id, idTipoAjuste, dataAjuste, valorAjuste, identificadorExterno);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lan\u00C3\u00A7a um ajuste para a conta do id informado Este recurso insere um ajuste para a conta do id informado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idTipoAjuste">C\u00C3\u00B3digo identificador do tipo de ajuste.</param>
        /// <param name="dataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ.</param>
        /// <param name="valorAjuste">Valor do ajuste</param>
        /// <param name="identificadorExterno">Identificador Externo (optional)</param>
        /// <returns>Task of ApiResponse (AjusteFinanceiroResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AjusteFinanceiroResponse>> AjustarContaUsingPOST1AsyncWithHttpInfo (long? id, long? idTipoAjuste, string dataAjuste, double? valorAjuste, string identificadorExterno = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AjustarContaUsingPOST1");
            // verify the required parameter 'idTipoAjuste' is set
            if (idTipoAjuste == null) throw new ApiException(400, "Missing required parameter 'idTipoAjuste' when calling AjustarContaUsingPOST1");
            // verify the required parameter 'dataAjuste' is set
            if (dataAjuste == null) throw new ApiException(400, "Missing required parameter 'dataAjuste' when calling AjustarContaUsingPOST1");
            // verify the required parameter 'valorAjuste' is set
            if (valorAjuste == null) throw new ApiException(400, "Missing required parameter 'valorAjuste' when calling AjustarContaUsingPOST1");
            
    
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
            
            if (idTipoAjuste != null) localVarQueryParams.Add("idTipoAjuste", Configuration.ApiClient.ParameterToString(idTipoAjuste)); // query parameter
            if (dataAjuste != null) localVarQueryParams.Add("dataAjuste", Configuration.ApiClient.ParameterToString(dataAjuste)); // query parameter
            if (valorAjuste != null) localVarQueryParams.Add("valorAjuste", Configuration.ApiClient.ParameterToString(valorAjuste)); // query parameter
            if (identificadorExterno != null) localVarQueryParams.Add("identificadorExterno", Configuration.ApiClient.ParameterToString(identificadorExterno)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AjustarContaUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AjustarContaUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AjusteFinanceiroResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AjusteFinanceiroResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AjusteFinanceiroResponse)));
            
        }
        
        /// <summary>
        /// Altera o produto associado \u00C3\u00A0 conta. O recurso permite fazer modifica\u00C3\u00A7\u00C3\u00A3o do produto associado \u00C3\u00A0 conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="request">request</param> 
        /// <returns>string</returns>
        public string AlterarProdutoUsingPOST (long? id, AlterarProdutoRequest request)
        {
             ApiResponse<string> localVarResponse = AlterarProdutoUsingPOSTWithHttpInfo(id, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera o produto associado \u00C3\u00A0 conta. O recurso permite fazer modifica\u00C3\u00A7\u00C3\u00A3o do produto associado \u00C3\u00A0 conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="request">request</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > AlterarProdutoUsingPOSTWithHttpInfo (long? id, AlterarProdutoRequest request)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->AlterarProdutoUsingPOST");
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling ContaApi->AlterarProdutoUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/alterar-produto";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarProdutoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarProdutoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Altera o produto associado \u00C3\u00A0 conta. O recurso permite fazer modifica\u00C3\u00A7\u00C3\u00A3o do produto associado \u00C3\u00A0 conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="request">request</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> AlterarProdutoUsingPOSTAsync (long? id, AlterarProdutoRequest request)
        {
             ApiResponse<string> localVarResponse = await AlterarProdutoUsingPOSTAsyncWithHttpInfo(id, request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera o produto associado \u00C3\u00A0 conta. O recurso permite fazer modifica\u00C3\u00A7\u00C3\u00A3o do produto associado \u00C3\u00A0 conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> AlterarProdutoUsingPOSTAsyncWithHttpInfo (long? id, AlterarProdutoRequest request)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarProdutoUsingPOST");
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling AlterarProdutoUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/alterar-produto";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarProdutoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarProdutoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o de uma Pessoa tilular da conta Esta m\u00C3\u00A9todo permite altera a pessoa de uma conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id)</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o de uma Pessoa (id).</param> 
        /// <returns>ContaResponse</returns>
        public ContaResponse AlterarTitularUsingPOST (long? id, long? idPessoa)
        {
             ApiResponse<ContaResponse> localVarResponse = AlterarTitularUsingPOSTWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o de uma Pessoa tilular da conta Esta m\u00C3\u00A9todo permite altera a pessoa de uma conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id)</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o de uma Pessoa (id).</param> 
        /// <returns>ApiResponse of ContaResponse</returns>
        public ApiResponse< ContaResponse > AlterarTitularUsingPOSTWithHttpInfo (long? id, long? idPessoa)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->AlterarTitularUsingPOST");
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling ContaApi->AlterarTitularUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/alterar-titular";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTitularUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTitularUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }

        
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o de uma Pessoa tilular da conta Esta m\u00C3\u00A9todo permite altera a pessoa de uma conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o de uma Pessoa (id).</param>
        /// <returns>Task of ContaResponse</returns>
        public async System.Threading.Tasks.Task<ContaResponse> AlterarTitularUsingPOSTAsync (long? id, long? idPessoa)
        {
             ApiResponse<ContaResponse> localVarResponse = await AlterarTitularUsingPOSTAsyncWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o de uma Pessoa tilular da conta Esta m\u00C3\u00A9todo permite altera a pessoa de uma conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o de uma Pessoa (id).</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaResponse>> AlterarTitularUsingPOSTAsyncWithHttpInfo (long? id, long? idPessoa)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarTitularUsingPOST");
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling AlterarTitularUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/alterar-titular";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTitularUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTitularUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }
        
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o do dia de vencimento das faturas da conta Esse recurso permite alterar o vencimento para no m\u00C3\u00A1ximo at\u00C3\u00A9 30 dias ap\u00C3\u00B3s data atual de uma conta especifica no PIER, respeitando o par\u00C3\u00A2metro de intervalor entre as modifica\u00C3\u00A7\u00C3\u00B5es do vencimento informado pelo emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="novoDiaVencimento">Novo dia de vencimento.</param> 
        /// <returns>ContaResponse</returns>
        public ContaResponse AlterarVencimentoUsingPUT (long? id, int? novoDiaVencimento)
        {
             ApiResponse<ContaResponse> localVarResponse = AlterarVencimentoUsingPUTWithHttpInfo(id, novoDiaVencimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o do dia de vencimento das faturas da conta Esse recurso permite alterar o vencimento para no m\u00C3\u00A1ximo at\u00C3\u00A9 30 dias ap\u00C3\u00B3s data atual de uma conta especifica no PIER, respeitando o par\u00C3\u00A2metro de intervalor entre as modifica\u00C3\u00A7\u00C3\u00B5es do vencimento informado pelo emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="novoDiaVencimento">Novo dia de vencimento.</param> 
        /// <returns>ApiResponse of ContaResponse</returns>
        public ApiResponse< ContaResponse > AlterarVencimentoUsingPUTWithHttpInfo (long? id, int? novoDiaVencimento)
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarVencimentoUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarVencimentoUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }

        
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o do dia de vencimento das faturas da conta Esse recurso permite alterar o vencimento para no m\u00C3\u00A1ximo at\u00C3\u00A9 30 dias ap\u00C3\u00B3s data atual de uma conta especifica no PIER, respeitando o par\u00C3\u00A2metro de intervalor entre as modifica\u00C3\u00A7\u00C3\u00B5es do vencimento informado pelo emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="novoDiaVencimento">Novo dia de vencimento.</param>
        /// <returns>Task of ContaResponse</returns>
        public async System.Threading.Tasks.Task<ContaResponse> AlterarVencimentoUsingPUTAsync (long? id, int? novoDiaVencimento)
        {
             ApiResponse<ContaResponse> localVarResponse = await AlterarVencimentoUsingPUTAsyncWithHttpInfo(id, novoDiaVencimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o do dia de vencimento das faturas da conta Esse recurso permite alterar o vencimento para no m\u00C3\u00A1ximo at\u00C3\u00A9 30 dias ap\u00C3\u00B3s data atual de uma conta especifica no PIER, respeitando o par\u00C3\u00A2metro de intervalor entre as modifica\u00C3\u00A7\u00C3\u00B5es do vencimento informado pelo emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="novoDiaVencimento">Novo dia de vencimento.</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaResponse>> AlterarVencimentoUsingPUTAsyncWithHttpInfo (long? id, int? novoDiaVencimento)
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarVencimentoUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarVencimentoUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }
        
        /// <summary>
        /// Atribuir Anuidade Esse recurso permite configurar qual a regra de Anuidade que ser\u00C3\u00A1 atribu\u00C3\u00ADda a uma determinada Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="idAnuidade">Identificador da anuidade</param> 
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="DDD">DDD do celular (optional)</param> 
        /// <param name="celular">N\u00C3\u00BAmero do celular (optional)</param> 
        /// <param name="idOperadora">Identificador da operadora do celular (optional)</param> 
        /// <param name="idOrigemComercial">Identificador da origem comercial (optional)</param> 
        /// <returns>Object</returns>
        public Object AtivarAnuidadeUsingPOST (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null)
        {
             ApiResponse<Object> localVarResponse = AtivarAnuidadeUsingPOSTWithHttpInfo(id, idAnuidade, sort, page, limit, DDD, celular, idOperadora, idOrigemComercial);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atribuir Anuidade Esse recurso permite configurar qual a regra de Anuidade que ser\u00C3\u00A1 atribu\u00C3\u00ADda a uma determinada Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="idAnuidade">Identificador da anuidade</param> 
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="DDD">DDD do celular (optional)</param> 
        /// <param name="celular">N\u00C3\u00BAmero do celular (optional)</param> 
        /// <param name="idOperadora">Identificador da operadora do celular (optional)</param> 
        /// <param name="idOrigemComercial">Identificador da origem comercial (optional)</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > AtivarAnuidadeUsingPOSTWithHttpInfo (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->AtivarAnuidadeUsingPOST");
            
            // verify the required parameter 'idAnuidade' is set
            if (idAnuidade == null)
                throw new ApiException(400, "Missing required parameter 'idAnuidade' when calling ContaApi->AtivarAnuidadeUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/atribuir-anuidade";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
            if (idAnuidade != null) localVarQueryParams.Add("idAnuidade", Configuration.ApiClient.ParameterToString(idAnuidade)); // query parameter
            if (DDD != null) localVarQueryParams.Add("DDD", Configuration.ApiClient.ParameterToString(DDD)); // query parameter
            if (celular != null) localVarQueryParams.Add("celular", Configuration.ApiClient.ParameterToString(celular)); // query parameter
            if (idOperadora != null) localVarQueryParams.Add("idOperadora", Configuration.ApiClient.ParameterToString(idOperadora)); // query parameter
            if (idOrigemComercial != null) localVarQueryParams.Add("idOrigemComercial", Configuration.ApiClient.ParameterToString(idOrigemComercial)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtivarAnuidadeUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarAnuidadeUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Atribuir Anuidade Esse recurso permite configurar qual a regra de Anuidade que ser\u00C3\u00A1 atribu\u00C3\u00ADda a uma determinada Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idAnuidade">Identificador da anuidade</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="DDD">DDD do celular (optional)</param>
        /// <param name="celular">N\u00C3\u00BAmero do celular (optional)</param>
        /// <param name="idOperadora">Identificador da operadora do celular (optional)</param>
        /// <param name="idOrigemComercial">Identificador da origem comercial (optional)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> AtivarAnuidadeUsingPOSTAsync (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null)
        {
             ApiResponse<Object> localVarResponse = await AtivarAnuidadeUsingPOSTAsyncWithHttpInfo(id, idAnuidade, sort, page, limit, DDD, celular, idOperadora, idOrigemComercial);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atribuir Anuidade Esse recurso permite configurar qual a regra de Anuidade que ser\u00C3\u00A1 atribu\u00C3\u00ADda a uma determinada Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idAnuidade">Identificador da anuidade</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="DDD">DDD do celular (optional)</param>
        /// <param name="celular">N\u00C3\u00BAmero do celular (optional)</param>
        /// <param name="idOperadora">Identificador da operadora do celular (optional)</param>
        /// <param name="idOrigemComercial">Identificador da origem comercial (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AtivarAnuidadeUsingPOSTAsyncWithHttpInfo (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtivarAnuidadeUsingPOST");
            // verify the required parameter 'idAnuidade' is set
            if (idAnuidade == null) throw new ApiException(400, "Missing required parameter 'idAnuidade' when calling AtivarAnuidadeUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/atribuir-anuidade";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
            if (idAnuidade != null) localVarQueryParams.Add("idAnuidade", Configuration.ApiClient.ParameterToString(idAnuidade)); // query parameter
            if (DDD != null) localVarQueryParams.Add("DDD", Configuration.ApiClient.ParameterToString(DDD)); // query parameter
            if (celular != null) localVarQueryParams.Add("celular", Configuration.ApiClient.ParameterToString(celular)); // query parameter
            if (idOperadora != null) localVarQueryParams.Add("idOperadora", Configuration.ApiClient.ParameterToString(idOperadora)); // query parameter
            if (idOrigemComercial != null) localVarQueryParams.Add("idOrigemComercial", Configuration.ApiClient.ParameterToString(idOrigemComercial)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtivarAnuidadeUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarAnuidadeUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
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
        /// Realiza o bloqueio de uma determinada Conta Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o do bloqueio de uma determinada conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Conta.</param> 
        /// <returns>ContaResponse</returns>
        public ContaResponse BloquearUsingPOST1 (long? id, long? idStatus)
        {
             ApiResponse<ContaResponse> localVarResponse = BloquearUsingPOST1WithHttpInfo(id, idStatus);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o bloqueio de uma determinada Conta Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o do bloqueio de uma determinada conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Conta.</param> 
        /// <returns>ApiResponse of ContaResponse</returns>
        public ApiResponse< ContaResponse > BloquearUsingPOST1WithHttpInfo (long? id, long? idStatus)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->BloquearUsingPOST1");
            
            // verify the required parameter 'idStatus' is set
            if (idStatus == null)
                throw new ApiException(400, "Missing required parameter 'idStatus' when calling ContaApi->BloquearUsingPOST1");
            
    
            var localVarPath = "/api/contas/{id}/bloquear";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling BloquearUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling BloquearUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }

        
        /// <summary>
        /// Realiza o bloqueio de uma determinada Conta Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o do bloqueio de uma determinada conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Conta.</param>
        /// <returns>Task of ContaResponse</returns>
        public async System.Threading.Tasks.Task<ContaResponse> BloquearUsingPOST1Async (long? id, long? idStatus)
        {
             ApiResponse<ContaResponse> localVarResponse = await BloquearUsingPOST1AsyncWithHttpInfo(id, idStatus);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o bloqueio de uma determinada Conta Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o do bloqueio de uma determinada conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Conta.</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaResponse>> BloquearUsingPOST1AsyncWithHttpInfo (long? id, long? idStatus)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling BloquearUsingPOST1");
            // verify the required parameter 'idStatus' is set
            if (idStatus == null) throw new ApiException(400, "Missing required parameter 'idStatus' when calling BloquearUsingPOST1");
            
    
            var localVarPath = "/api/contas/{id}/bloquear";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling BloquearUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling BloquearUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }
        
        /// <summary>
        /// Realiza o cancelamento de uma determinada Conta Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o do cancelamento de uma determinada conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Conta.</param> 
        /// <returns>ContaResponse</returns>
        public ContaResponse CancelarUsingPOST1 (long? id, long? idStatus)
        {
             ApiResponse<ContaResponse> localVarResponse = CancelarUsingPOST1WithHttpInfo(id, idStatus);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cancelamento de uma determinada Conta Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o do cancelamento de uma determinada conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Conta.</param> 
        /// <returns>ApiResponse of ContaResponse</returns>
        public ApiResponse< ContaResponse > CancelarUsingPOST1WithHttpInfo (long? id, long? idStatus)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->CancelarUsingPOST1");
            
            // verify the required parameter 'idStatus' is set
            if (idStatus == null)
                throw new ApiException(400, "Missing required parameter 'idStatus' when calling ContaApi->CancelarUsingPOST1");
            
    
            var localVarPath = "/api/contas/{id}/cancelar";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }

        
        /// <summary>
        /// Realiza o cancelamento de uma determinada Conta Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o do cancelamento de uma determinada conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Conta.</param>
        /// <returns>Task of ContaResponse</returns>
        public async System.Threading.Tasks.Task<ContaResponse> CancelarUsingPOST1Async (long? id, long? idStatus)
        {
             ApiResponse<ContaResponse> localVarResponse = await CancelarUsingPOST1AsyncWithHttpInfo(id, idStatus);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cancelamento de uma determinada Conta Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o do cancelamento de uma determinada conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Conta.</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaResponse>> CancelarUsingPOST1AsyncWithHttpInfo (long? id, long? idStatus)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CancelarUsingPOST1");
            // verify the required parameter 'idStatus' is set
            if (idStatus == null) throw new ApiException(400, "Missing required parameter 'idStatus' when calling CancelarUsingPOST1");
            
    
            var localVarPath = "/api/contas/{id}/cancelar";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }
        
        /// <summary>
        /// Apresenta a data m\u00C3\u00A1xima para pagamento da fatura em atraso para receber o benef\u00C3\u00ADcio. Este m\u00C3\u00A9todo permite consultar se o cliente tem direito ao benef\u00C3\u00ADcio de pagamento em atraso, em loja, at\u00C3\u00A9 o s\u00C3\u00A1bado subsequente ao vencimento, ficando isento do pagamento de multa, encargos, mora e IOF.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <returns>BeneficioPagamentoAtrasoResponse</returns>
        public BeneficioPagamentoAtrasoResponse ConsultarBeneficioPagamentoAtrasoUsingGET (long? id)
        {
             ApiResponse<BeneficioPagamentoAtrasoResponse> localVarResponse = ConsultarBeneficioPagamentoAtrasoUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta a data m\u00C3\u00A1xima para pagamento da fatura em atraso para receber o benef\u00C3\u00ADcio. Este m\u00C3\u00A9todo permite consultar se o cliente tem direito ao benef\u00C3\u00ADcio de pagamento em atraso, em loja, at\u00C3\u00A9 o s\u00C3\u00A1bado subsequente ao vencimento, ficando isento do pagamento de multa, encargos, mora e IOF.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <returns>ApiResponse of BeneficioPagamentoAtrasoResponse</returns>
        public ApiResponse< BeneficioPagamentoAtrasoResponse > ConsultarBeneficioPagamentoAtrasoUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ConsultarBeneficioPagamentoAtrasoUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/consultar-beneficio-pagamento-atraso";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBeneficioPagamentoAtrasoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBeneficioPagamentoAtrasoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BeneficioPagamentoAtrasoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BeneficioPagamentoAtrasoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BeneficioPagamentoAtrasoResponse)));
            
        }

        
        /// <summary>
        /// Apresenta a data m\u00C3\u00A1xima para pagamento da fatura em atraso para receber o benef\u00C3\u00ADcio. Este m\u00C3\u00A9todo permite consultar se o cliente tem direito ao benef\u00C3\u00ADcio de pagamento em atraso, em loja, at\u00C3\u00A9 o s\u00C3\u00A1bado subsequente ao vencimento, ficando isento do pagamento de multa, encargos, mora e IOF.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>Task of BeneficioPagamentoAtrasoResponse</returns>
        public async System.Threading.Tasks.Task<BeneficioPagamentoAtrasoResponse> ConsultarBeneficioPagamentoAtrasoUsingGETAsync (long? id)
        {
             ApiResponse<BeneficioPagamentoAtrasoResponse> localVarResponse = await ConsultarBeneficioPagamentoAtrasoUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta a data m\u00C3\u00A1xima para pagamento da fatura em atraso para receber o benef\u00C3\u00ADcio. Este m\u00C3\u00A9todo permite consultar se o cliente tem direito ao benef\u00C3\u00ADcio de pagamento em atraso, em loja, at\u00C3\u00A9 o s\u00C3\u00A1bado subsequente ao vencimento, ficando isento do pagamento de multa, encargos, mora e IOF.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>Task of ApiResponse (BeneficioPagamentoAtrasoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BeneficioPagamentoAtrasoResponse>> ConsultarBeneficioPagamentoAtrasoUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarBeneficioPagamentoAtrasoUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/consultar-beneficio-pagamento-atraso";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBeneficioPagamentoAtrasoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBeneficioPagamentoAtrasoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BeneficioPagamentoAtrasoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BeneficioPagamentoAtrasoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BeneficioPagamentoAtrasoResponse)));
            
        }
        
        /// <summary>
        /// Consulta os dados de um determinado boleto da fatura Este recurso consulta um boleto da fatura
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <returns>BoletoResponse</returns>
        public BoletoResponse ConsultarBoletoEmitidoUsingGET (long? id)
        {
             ApiResponse<BoletoResponse> localVarResponse = ConsultarBoletoEmitidoUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta os dados de um determinado boleto da fatura Este recurso consulta um boleto da fatura
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <returns>ApiResponse of BoletoResponse</returns>
        public ApiResponse< BoletoResponse > ConsultarBoletoEmitidoUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ConsultarBoletoEmitidoUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/consultar-dados-pagamento-fatura";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBoletoEmitidoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBoletoEmitidoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoResponse)));
            
        }

        
        /// <summary>
        /// Consulta os dados de um determinado boleto da fatura Este recurso consulta um boleto da fatura
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Task of BoletoResponse</returns>
        public async System.Threading.Tasks.Task<BoletoResponse> ConsultarBoletoEmitidoUsingGETAsync (long? id)
        {
             ApiResponse<BoletoResponse> localVarResponse = await ConsultarBoletoEmitidoUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta os dados de um determinado boleto da fatura Este recurso consulta um boleto da fatura
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Task of ApiResponse (BoletoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BoletoResponse>> ConsultarBoletoEmitidoUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarBoletoEmitidoUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/consultar-dados-pagamento-fatura";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBoletoEmitidoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBoletoEmitidoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoResponse)));
            
        }
        
        /// <summary>
        /// Consulta a d\u00C3\u00ADvida atualizada do cliente Este recurso consulta a d\u00C3\u00ADvida atualizada do cliente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="dataVencimento">Data do vencimento (optional)</param> 
        /// <param name="idEscritorioCobranca">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do escrit\u00C3\u00B3rio de cobran\u00C3\u00A7a (optional)</param> 
        /// <returns>DividaClienteResponse</returns>
        public DividaClienteResponse ConsultarDividaAtualizadaClienteUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, long? idEscritorioCobranca = null)
        {
             ApiResponse<DividaClienteResponse> localVarResponse = ConsultarDividaAtualizadaClienteUsingGETWithHttpInfo(id, sort, page, limit, dataVencimento, idEscritorioCobranca);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta a d\u00C3\u00ADvida atualizada do cliente Este recurso consulta a d\u00C3\u00ADvida atualizada do cliente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="dataVencimento">Data do vencimento (optional)</param> 
        /// <param name="idEscritorioCobranca">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do escrit\u00C3\u00B3rio de cobran\u00C3\u00A7a (optional)</param> 
        /// <returns>ApiResponse of DividaClienteResponse</returns>
        public ApiResponse< DividaClienteResponse > ConsultarDividaAtualizadaClienteUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, long? idEscritorioCobranca = null)
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            if (idEscritorioCobranca != null) localVarQueryParams.Add("idEscritorioCobranca", Configuration.ApiClient.ParameterToString(idEscritorioCobranca)); // query parameter
            
            
            
            

            
    
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
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataVencimento">Data do vencimento (optional)</param>
        /// <param name="idEscritorioCobranca">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do escrit\u00C3\u00B3rio de cobran\u00C3\u00A7a (optional)</param>
        /// <returns>Task of DividaClienteResponse</returns>
        public async System.Threading.Tasks.Task<DividaClienteResponse> ConsultarDividaAtualizadaClienteUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, long? idEscritorioCobranca = null)
        {
             ApiResponse<DividaClienteResponse> localVarResponse = await ConsultarDividaAtualizadaClienteUsingGETAsyncWithHttpInfo(id, sort, page, limit, dataVencimento, idEscritorioCobranca);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta a d\u00C3\u00ADvida atualizada do cliente Este recurso consulta a d\u00C3\u00ADvida atualizada do cliente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataVencimento">Data do vencimento (optional)</param>
        /// <param name="idEscritorioCobranca">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do escrit\u00C3\u00B3rio de cobran\u00C3\u00A7a (optional)</param>
        /// <returns>Task of ApiResponse (DividaClienteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DividaClienteResponse>> ConsultarDividaAtualizadaClienteUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, long? idEscritorioCobranca = null)
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            if (idEscritorioCobranca != null) localVarQueryParams.Add("idEscritorioCobranca", Configuration.ApiClient.ParameterToString(idEscritorioCobranca)); // query parameter
            
            
            
            

            

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
        /// Permite consultar a partir do ID da conta as taxas e tarifas Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores consultem as taxas e tarifas da conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da conta a ser consultada.</param> 
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageTaxasRefinanciamentoResponse</returns>
        public PageTaxasRefinanciamentoResponse ConsultarTaxasTarifasUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTaxasRefinanciamentoResponse> localVarResponse = ConsultarTaxasTarifasUsingGETWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite consultar a partir do ID da conta as taxas e tarifas Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores consultem as taxas e tarifas da conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da conta a ser consultada.</param> 
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageTaxasRefinanciamentoResponse</returns>
        public ApiResponse< PageTaxasRefinanciamentoResponse > ConsultarTaxasTarifasUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ConsultarTaxasTarifasUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/consultar-taxas-tarifas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxasTarifasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxasTarifasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTaxasRefinanciamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTaxasRefinanciamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTaxasRefinanciamentoResponse)));
            
        }

        
        /// <summary>
        /// Permite consultar a partir do ID da conta as taxas e tarifas Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores consultem as taxas e tarifas da conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da conta a ser consultada.</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageTaxasRefinanciamentoResponse</returns>
        public async System.Threading.Tasks.Task<PageTaxasRefinanciamentoResponse> ConsultarTaxasTarifasUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTaxasRefinanciamentoResponse> localVarResponse = await ConsultarTaxasTarifasUsingGETAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite consultar a partir do ID da conta as taxas e tarifas Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores consultem as taxas e tarifas da conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da conta a ser consultada.</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTaxasRefinanciamentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTaxasRefinanciamentoResponse>> ConsultarTaxasTarifasUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarTaxasTarifasUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/consultar-taxas-tarifas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxasTarifasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxasTarifasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTaxasRefinanciamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTaxasRefinanciamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTaxasRefinanciamentoResponse)));
            
        }
        
        /// <summary>
        /// Apresenta dados de uma determinada conta Este m\u00C3\u00A9todo permite consultar dados de uma determinada conta a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <returns>ContaDetalheResponse</returns>
        public ContaDetalheResponse ConsultarUsingGET12 (long? id)
        {
             ApiResponse<ContaDetalheResponse> localVarResponse = ConsultarUsingGET12WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta dados de uma determinada conta Este m\u00C3\u00A9todo permite consultar dados de uma determinada conta a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <returns>ApiResponse of ContaDetalheResponse</returns>
        public ApiResponse< ContaDetalheResponse > ConsultarUsingGET12WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ConsultarUsingGET12");
            
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET12: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET12: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaDetalheResponse)));
            
        }

        
        /// <summary>
        /// Apresenta dados de uma determinada conta Este m\u00C3\u00A9todo permite consultar dados de uma determinada conta a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>Task of ContaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<ContaDetalheResponse> ConsultarUsingGET12Async (long? id)
        {
             ApiResponse<ContaDetalheResponse> localVarResponse = await ConsultarUsingGET12AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta dados de uma determinada conta Este m\u00C3\u00A9todo permite consultar dados de uma determinada conta a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>Task of ApiResponse (ContaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaDetalheResponse>> ConsultarUsingGET12AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET12");
            
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET12: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET12: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaDetalheResponse)));
            
        }
        
        /// <summary>
        /// Consulta os detalhes de uma determinada transfer\u00C3\u00AAncia Este m\u00C3\u00A9todo permite consultar os detalhes de uma determinada transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito realizada entre contas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="idTransferencia">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id_transferencia).</param> 
        /// <returns>TransferenciaDetalheResponse</returns>
        public TransferenciaDetalheResponse ConsultarUsingGET41 (long? id, long? idTransferencia)
        {
             ApiResponse<TransferenciaDetalheResponse> localVarResponse = ConsultarUsingGET41WithHttpInfo(id, idTransferencia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta os detalhes de uma determinada transfer\u00C3\u00AAncia Este m\u00C3\u00A9todo permite consultar os detalhes de uma determinada transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito realizada entre contas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="idTransferencia">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id_transferencia).</param> 
        /// <returns>ApiResponse of TransferenciaDetalheResponse</returns>
        public ApiResponse< TransferenciaDetalheResponse > ConsultarUsingGET41WithHttpInfo (long? id, long? idTransferencia)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ConsultarUsingGET41");
            
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null)
                throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling ContaApi->ConsultarUsingGET41");
            
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET41: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET41: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransferenciaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaDetalheResponse)));
            
        }

        
        /// <summary>
        /// Consulta os detalhes de uma determinada transfer\u00C3\u00AAncia Este m\u00C3\u00A9todo permite consultar os detalhes de uma determinada transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito realizada entre contas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idTransferencia">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id_transferencia).</param>
        /// <returns>Task of TransferenciaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<TransferenciaDetalheResponse> ConsultarUsingGET41Async (long? id, long? idTransferencia)
        {
             ApiResponse<TransferenciaDetalheResponse> localVarResponse = await ConsultarUsingGET41AsyncWithHttpInfo(id, idTransferencia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta os detalhes de uma determinada transfer\u00C3\u00AAncia Este m\u00C3\u00A9todo permite consultar os detalhes de uma determinada transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito realizada entre contas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idTransferencia">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id_transferencia).</param>
        /// <returns>Task of ApiResponse (TransferenciaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransferenciaDetalheResponse>> ConsultarUsingGET41AsyncWithHttpInfo (long? id, long? idTransferencia)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET41");
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null) throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling ConsultarUsingGET41");
            
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET41: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET41: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransferenciaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaDetalheResponse)));
            
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
        /// <param name="valor">Atributo que representa o valor do Boleto Emitido</param> 
        /// <param name="dataVencimento">Atributo que representa a data de vencimento do boleto</param> 
        /// <returns>BoletoResponse</returns>
        public BoletoResponse GerarBoletoRecargaUsingPOST (long? id, double? valor, string dataVencimento)
        {
             ApiResponse<BoletoResponse> localVarResponse = GerarBoletoRecargaUsingPOSTWithHttpInfo(id, valor, dataVencimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gera um boleto de recarga Este recurso gera um boleto de recarga
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="valor">Atributo que representa o valor do Boleto Emitido</param> 
        /// <param name="dataVencimento">Atributo que representa a data de vencimento do boleto</param> 
        /// <returns>ApiResponse of BoletoResponse</returns>
        public ApiResponse< BoletoResponse > GerarBoletoRecargaUsingPOSTWithHttpInfo (long? id, double? valor, string dataVencimento)
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
            
            if (valor != null) localVarQueryParams.Add("valor", Configuration.ApiClient.ParameterToString(valor)); // query parameter
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoRecargaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoRecargaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoResponse)));
            
        }

        
        /// <summary>
        /// Gera um boleto de recarga Este recurso gera um boleto de recarga
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="valor">Atributo que representa o valor do Boleto Emitido</param>
        /// <param name="dataVencimento">Atributo que representa a data de vencimento do boleto</param>
        /// <returns>Task of BoletoResponse</returns>
        public async System.Threading.Tasks.Task<BoletoResponse> GerarBoletoRecargaUsingPOSTAsync (long? id, double? valor, string dataVencimento)
        {
             ApiResponse<BoletoResponse> localVarResponse = await GerarBoletoRecargaUsingPOSTAsyncWithHttpInfo(id, valor, dataVencimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gera um boleto de recarga Este recurso gera um boleto de recarga
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="valor">Atributo que representa o valor do Boleto Emitido</param>
        /// <param name="dataVencimento">Atributo que representa a data de vencimento do boleto</param>
        /// <returns>Task of ApiResponse (BoletoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BoletoResponse>> GerarBoletoRecargaUsingPOSTAsyncWithHttpInfo (long? id, double? valor, string dataVencimento)
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
            
            if (valor != null) localVarQueryParams.Add("valor", Configuration.ApiClient.ParameterToString(valor)); // query parameter
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoRecargaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoRecargaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoResponse)));
            
        }
        
        /// <summary>
        /// Realiza o envio para gera\u00C3\u00A7\u00C3\u00A3o de um novo cart\u00C3\u00A3o na gr\u00C3\u00A1fica Este recurso permite que seja gerado um novo Cart\u00C3\u00A3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00C3\u00A3o que dever\u00C3\u00A1 ser gerado para impress\u00C3\u00A3o. Esta funcionalidade poder\u00C3\u00A1 ser utilizada para impress\u00C3\u00A3o de cart\u00C3\u00B5es em gr\u00C3\u00A1fica.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="cartaoEmbossingRequest">cartaoEmbossingRequest</param> 
        /// <returns>CartaoEmbossingResponse</returns>
        public CartaoEmbossingResponse GerarCartaoEmbossingUsingPOST (long? id, CartaoEmbossingRequest cartaoEmbossingRequest)
        {
             ApiResponse<CartaoEmbossingResponse> localVarResponse = GerarCartaoEmbossingUsingPOSTWithHttpInfo(id, cartaoEmbossingRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o envio para gera\u00C3\u00A7\u00C3\u00A3o de um novo cart\u00C3\u00A3o na gr\u00C3\u00A1fica Este recurso permite que seja gerado um novo Cart\u00C3\u00A3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00C3\u00A3o que dever\u00C3\u00A1 ser gerado para impress\u00C3\u00A3o. Esta funcionalidade poder\u00C3\u00A1 ser utilizada para impress\u00C3\u00A3o de cart\u00C3\u00B5es em gr\u00C3\u00A1fica.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="cartaoEmbossingRequest">cartaoEmbossingRequest</param> 
        /// <returns>ApiResponse of CartaoEmbossingResponse</returns>
        public ApiResponse< CartaoEmbossingResponse > GerarCartaoEmbossingUsingPOSTWithHttpInfo (long? id, CartaoEmbossingRequest cartaoEmbossingRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->GerarCartaoEmbossingUsingPOST");
            
            // verify the required parameter 'cartaoEmbossingRequest' is set
            if (cartaoEmbossingRequest == null)
                throw new ApiException(400, "Missing required parameter 'cartaoEmbossingRequest' when calling ContaApi->GerarCartaoEmbossingUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/gerar-cartao-grafica";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            if (cartaoEmbossingRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cartaoEmbossingRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cartaoEmbossingRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoEmbossingUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoEmbossingUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoEmbossingResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoEmbossingResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoEmbossingResponse)));
            
        }

        
        /// <summary>
        /// Realiza o envio para gera\u00C3\u00A7\u00C3\u00A3o de um novo cart\u00C3\u00A3o na gr\u00C3\u00A1fica Este recurso permite que seja gerado um novo Cart\u00C3\u00A3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00C3\u00A3o que dever\u00C3\u00A1 ser gerado para impress\u00C3\u00A3o. Esta funcionalidade poder\u00C3\u00A1 ser utilizada para impress\u00C3\u00A3o de cart\u00C3\u00B5es em gr\u00C3\u00A1fica.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="cartaoEmbossingRequest">cartaoEmbossingRequest</param>
        /// <returns>Task of CartaoEmbossingResponse</returns>
        public async System.Threading.Tasks.Task<CartaoEmbossingResponse> GerarCartaoEmbossingUsingPOSTAsync (long? id, CartaoEmbossingRequest cartaoEmbossingRequest)
        {
             ApiResponse<CartaoEmbossingResponse> localVarResponse = await GerarCartaoEmbossingUsingPOSTAsyncWithHttpInfo(id, cartaoEmbossingRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o envio para gera\u00C3\u00A7\u00C3\u00A3o de um novo cart\u00C3\u00A3o na gr\u00C3\u00A1fica Este recurso permite que seja gerado um novo Cart\u00C3\u00A3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00C3\u00A3o que dever\u00C3\u00A1 ser gerado para impress\u00C3\u00A3o. Esta funcionalidade poder\u00C3\u00A1 ser utilizada para impress\u00C3\u00A3o de cart\u00C3\u00B5es em gr\u00C3\u00A1fica.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="cartaoEmbossingRequest">cartaoEmbossingRequest</param>
        /// <returns>Task of ApiResponse (CartaoEmbossingResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoEmbossingResponse>> GerarCartaoEmbossingUsingPOSTAsyncWithHttpInfo (long? id, CartaoEmbossingRequest cartaoEmbossingRequest)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GerarCartaoEmbossingUsingPOST");
            // verify the required parameter 'cartaoEmbossingRequest' is set
            if (cartaoEmbossingRequest == null) throw new ApiException(400, "Missing required parameter 'cartaoEmbossingRequest' when calling GerarCartaoEmbossingUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/gerar-cartao-grafica";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            if (cartaoEmbossingRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cartaoEmbossingRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cartaoEmbossingRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoEmbossingUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoEmbossingUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoEmbossingResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoEmbossingResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoEmbossingResponse)));
            
        }
        
        /// <summary>
        /// Realiza a gera\u00C3\u00A7\u00C3\u00A3o de um cart\u00C3\u00A3o provisorio Este recurso permite que seja gerado um cart\u00C3\u00A3o provis\u00C3\u00B3rio para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <returns>CartaoImpressaoProvisorioResponse</returns>
        public CartaoImpressaoProvisorioResponse GerarCartaoProvisorioUsingPOST (long? id)
        {
             ApiResponse<CartaoImpressaoProvisorioResponse> localVarResponse = GerarCartaoProvisorioUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a gera\u00C3\u00A7\u00C3\u00A3o de um cart\u00C3\u00A3o provisorio Este recurso permite que seja gerado um cart\u00C3\u00A3o provis\u00C3\u00B3rio para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <returns>ApiResponse of CartaoImpressaoProvisorioResponse</returns>
        public ApiResponse< CartaoImpressaoProvisorioResponse > GerarCartaoProvisorioUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->GerarCartaoProvisorioUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/gerar-cartao-provisorio";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoProvisorioUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoProvisorioUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoImpressaoProvisorioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoImpressaoProvisorioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoImpressaoProvisorioResponse)));
            
        }

        
        /// <summary>
        /// Realiza a gera\u00C3\u00A7\u00C3\u00A3o de um cart\u00C3\u00A3o provisorio Este recurso permite que seja gerado um cart\u00C3\u00A3o provis\u00C3\u00B3rio para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>Task of CartaoImpressaoProvisorioResponse</returns>
        public async System.Threading.Tasks.Task<CartaoImpressaoProvisorioResponse> GerarCartaoProvisorioUsingPOSTAsync (long? id)
        {
             ApiResponse<CartaoImpressaoProvisorioResponse> localVarResponse = await GerarCartaoProvisorioUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a gera\u00C3\u00A7\u00C3\u00A3o de um cart\u00C3\u00A3o provisorio Este recurso permite que seja gerado um cart\u00C3\u00A3o provis\u00C3\u00B3rio para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <returns>Task of ApiResponse (CartaoImpressaoProvisorioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoImpressaoProvisorioResponse>> GerarCartaoProvisorioUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GerarCartaoProvisorioUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/gerar-cartao-provisorio";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoProvisorioUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoProvisorioUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoImpressaoProvisorioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoImpressaoProvisorioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoImpressaoProvisorioResponse)));
            
        }
        
        /// <summary>
        /// Realiza a gera\u00C3\u00A7\u00C3\u00A3o de um novo cart\u00C3\u00A3o para impress\u00C3\u00A3o avulsa Este recurso permite que seja gerado um novo Cart\u00C3\u00A3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00C3\u00A3o que dever\u00C3\u00A1 ser gerado para impress\u00C3\u00A3o. Esta funcionalidade poder\u00C3\u00A1 ser utilizada para realizar a impress\u00C3\u00A3o de cart\u00C3\u00B5es em Lojas, Quiosques, Escrit\u00C3\u00B3rios, Terminais de Auto Atendimento, ou outro local que o Emissor escolher, desde que se possua uma impressora de Cart\u00C3\u00B5es habilidade para o fazer, no local.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da pessoa (id).</param> 
        /// <param name="idTipoPlastico">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do TipoPlastico (id). (optional)</param> 
        /// <returns>CartaoImpressaoResponse</returns>
        public CartaoImpressaoResponse GerarCartaoUsingPOST (long? id, long? idPessoa, long? idTipoPlastico = null)
        {
             ApiResponse<CartaoImpressaoResponse> localVarResponse = GerarCartaoUsingPOSTWithHttpInfo(id, idPessoa, idTipoPlastico);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a gera\u00C3\u00A7\u00C3\u00A3o de um novo cart\u00C3\u00A3o para impress\u00C3\u00A3o avulsa Este recurso permite que seja gerado um novo Cart\u00C3\u00A3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00C3\u00A3o que dever\u00C3\u00A1 ser gerado para impress\u00C3\u00A3o. Esta funcionalidade poder\u00C3\u00A1 ser utilizada para realizar a impress\u00C3\u00A3o de cart\u00C3\u00B5es em Lojas, Quiosques, Escrit\u00C3\u00B3rios, Terminais de Auto Atendimento, ou outro local que o Emissor escolher, desde que se possua uma impressora de Cart\u00C3\u00B5es habilidade para o fazer, no local.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da pessoa (id).</param> 
        /// <param name="idTipoPlastico">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do TipoPlastico (id). (optional)</param> 
        /// <returns>ApiResponse of CartaoImpressaoResponse</returns>
        public ApiResponse< CartaoImpressaoResponse > GerarCartaoUsingPOSTWithHttpInfo (long? id, long? idPessoa, long? idTipoPlastico = null)
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoImpressaoResponse)));
            
        }

        
        /// <summary>
        /// Realiza a gera\u00C3\u00A7\u00C3\u00A3o de um novo cart\u00C3\u00A3o para impress\u00C3\u00A3o avulsa Este recurso permite que seja gerado um novo Cart\u00C3\u00A3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00C3\u00A3o que dever\u00C3\u00A1 ser gerado para impress\u00C3\u00A3o. Esta funcionalidade poder\u00C3\u00A1 ser utilizada para realizar a impress\u00C3\u00A3o de cart\u00C3\u00B5es em Lojas, Quiosques, Escrit\u00C3\u00B3rios, Terminais de Auto Atendimento, ou outro local que o Emissor escolher, desde que se possua uma impressora de Cart\u00C3\u00B5es habilidade para o fazer, no local.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da pessoa (id).</param>
        /// <param name="idTipoPlastico">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do TipoPlastico (id). (optional)</param>
        /// <returns>Task of CartaoImpressaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoImpressaoResponse> GerarCartaoUsingPOSTAsync (long? id, long? idPessoa, long? idTipoPlastico = null)
        {
             ApiResponse<CartaoImpressaoResponse> localVarResponse = await GerarCartaoUsingPOSTAsyncWithHttpInfo(id, idPessoa, idTipoPlastico);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a gera\u00C3\u00A7\u00C3\u00A3o de um novo cart\u00C3\u00A3o para impress\u00C3\u00A3o avulsa Este recurso permite que seja gerado um novo Cart\u00C3\u00A3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00C3\u00A3o que dever\u00C3\u00A1 ser gerado para impress\u00C3\u00A3o. Esta funcionalidade poder\u00C3\u00A1 ser utilizada para realizar a impress\u00C3\u00A3o de cart\u00C3\u00B5es em Lojas, Quiosques, Escrit\u00C3\u00B3rios, Terminais de Auto Atendimento, ou outro local que o Emissor escolher, desde que se possua uma impressora de Cart\u00C3\u00B5es habilidade para o fazer, no local.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da pessoa (id).</param>
        /// <param name="idTipoPlastico">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do TipoPlastico (id). (optional)</param>
        /// <returns>Task of ApiResponse (CartaoImpressaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoImpressaoResponse>> GerarCartaoUsingPOSTAsyncWithHttpInfo (long? id, long? idPessoa, long? idTipoPlastico = null)
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoImpressaoResponse)));
            
        }
        
        /// <summary>
        /// Realiza a gera\u00C3\u00A7\u00C3\u00A3o de um cart\u00C3\u00A3o virtual Este recurso permite que seja gerado um Cart\u00C3\u00A3o virtual para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id). Esta funcionalidade poder\u00C3\u00A1 ser utilizada para realizar a cria\u00C3\u00A7\u00C3\u00A3o de cart\u00C3\u00B5es virtuaes atraves de um app.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="dataValidade">Data de Validade</param> 
        /// <returns>CartaoImpressaoResponse</returns>
        public CartaoImpressaoResponse GerarCartaoVirtualUsingPOST (long? id, string dataValidade)
        {
             ApiResponse<CartaoImpressaoResponse> localVarResponse = GerarCartaoVirtualUsingPOSTWithHttpInfo(id, dataValidade);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a gera\u00C3\u00A7\u00C3\u00A3o de um cart\u00C3\u00A3o virtual Este recurso permite que seja gerado um Cart\u00C3\u00A3o virtual para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id). Esta funcionalidade poder\u00C3\u00A1 ser utilizada para realizar a cria\u00C3\u00A7\u00C3\u00A3o de cart\u00C3\u00B5es virtuaes atraves de um app.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="dataValidade">Data de Validade</param> 
        /// <returns>ApiResponse of CartaoImpressaoResponse</returns>
        public ApiResponse< CartaoImpressaoResponse > GerarCartaoVirtualUsingPOSTWithHttpInfo (long? id, string dataValidade)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->GerarCartaoVirtualUsingPOST");
            
            // verify the required parameter 'dataValidade' is set
            if (dataValidade == null)
                throw new ApiException(400, "Missing required parameter 'dataValidade' when calling ContaApi->GerarCartaoVirtualUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/gerar-cartao-virtual";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (dataValidade != null) localVarQueryParams.Add("dataValidade", Configuration.ApiClient.ParameterToString(dataValidade)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoVirtualUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoVirtualUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoImpressaoResponse)));
            
        }

        
        /// <summary>
        /// Realiza a gera\u00C3\u00A7\u00C3\u00A3o de um cart\u00C3\u00A3o virtual Este recurso permite que seja gerado um Cart\u00C3\u00A3o virtual para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id). Esta funcionalidade poder\u00C3\u00A1 ser utilizada para realizar a cria\u00C3\u00A7\u00C3\u00A3o de cart\u00C3\u00B5es virtuaes atraves de um app.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="dataValidade">Data de Validade</param>
        /// <returns>Task of CartaoImpressaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoImpressaoResponse> GerarCartaoVirtualUsingPOSTAsync (long? id, string dataValidade)
        {
             ApiResponse<CartaoImpressaoResponse> localVarResponse = await GerarCartaoVirtualUsingPOSTAsyncWithHttpInfo(id, dataValidade);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a gera\u00C3\u00A7\u00C3\u00A3o de um cart\u00C3\u00A3o virtual Este recurso permite que seja gerado um Cart\u00C3\u00A3o virtual para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id). Esta funcionalidade poder\u00C3\u00A1 ser utilizada para realizar a cria\u00C3\u00A7\u00C3\u00A3o de cart\u00C3\u00B5es virtuaes atraves de um app.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="dataValidade">Data de Validade</param>
        /// <returns>Task of ApiResponse (CartaoImpressaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoImpressaoResponse>> GerarCartaoVirtualUsingPOSTAsyncWithHttpInfo (long? id, string dataValidade)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GerarCartaoVirtualUsingPOST");
            // verify the required parameter 'dataValidade' is set
            if (dataValidade == null) throw new ApiException(400, "Missing required parameter 'dataValidade' when calling GerarCartaoVirtualUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/gerar-cartao-virtual";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (dataValidade != null) localVarQueryParams.Add("dataValidade", Configuration.ApiClient.ParameterToString(dataValidade)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoVirtualUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoVirtualUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoImpressaoResponse)));
            
        }
        
        /// <summary>
        /// Lista o hist\u00C3\u00B3rico de altera\u00C3\u00A7\u00C3\u00B5es de limites da conta Este recurso consulta o hist\u00C3\u00B3rico com as altera\u00C3\u00A7\u00C3\u00B5es de limites da conta informada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageHistoricoEventosResponse</returns>
        public PageHistoricoEventosResponse ListarHistoricoAlteracoesLimitesUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageHistoricoEventosResponse> localVarResponse = ListarHistoricoAlteracoesLimitesUsingGETWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista o hist\u00C3\u00B3rico de altera\u00C3\u00A7\u00C3\u00B5es de limites da conta Este recurso consulta o hist\u00C3\u00B3rico com as altera\u00C3\u00A7\u00C3\u00B5es de limites da conta informada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageHistoricoEventosResponse</returns>
        public ApiResponse< PageHistoricoEventosResponse > ListarHistoricoAlteracoesLimitesUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAlteracoesLimitesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAlteracoesLimitesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageHistoricoEventosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoEventosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoEventosResponse)));
            
        }

        
        /// <summary>
        /// Lista o hist\u00C3\u00B3rico de altera\u00C3\u00A7\u00C3\u00B5es de limites da conta Este recurso consulta o hist\u00C3\u00B3rico com as altera\u00C3\u00A7\u00C3\u00B5es de limites da conta informada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageHistoricoEventosResponse</returns>
        public async System.Threading.Tasks.Task<PageHistoricoEventosResponse> ListarHistoricoAlteracoesLimitesUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageHistoricoEventosResponse> localVarResponse = await ListarHistoricoAlteracoesLimitesUsingGETAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista o hist\u00C3\u00B3rico de altera\u00C3\u00A7\u00C3\u00B5es de limites da conta Este recurso consulta o hist\u00C3\u00B3rico com as altera\u00C3\u00A7\u00C3\u00B5es de limites da conta informada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoEventosResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageHistoricoEventosResponse>> ListarHistoricoAlteracoesLimitesUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAlteracoesLimitesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAlteracoesLimitesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageHistoricoEventosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoEventosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoEventosResponse)));
            
        }
        
        /// <summary>
        /// Lista o hist\u00C3\u00B3rico de entradas/sa\u00C3\u00ADdas de assessorias de cobran\u00C3\u00A7a Permite listar todos os registros de entrada e sa\u00C3\u00ADda da Conta em arquivos de integra\u00C3\u00A7\u00C3\u00A3o com empresas de assessorias de cobran\u00C3\u00A7a a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (idConta).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageHistoricoAssessoriaResponse</returns>
        public PageHistoricoAssessoriaResponse ListarHistoricoAssessoriaUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageHistoricoAssessoriaResponse> localVarResponse = ListarHistoricoAssessoriaUsingGETWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista o hist\u00C3\u00B3rico de entradas/sa\u00C3\u00ADdas de assessorias de cobran\u00C3\u00A7a Permite listar todos os registros de entrada e sa\u00C3\u00ADda da Conta em arquivos de integra\u00C3\u00A7\u00C3\u00A3o com empresas de assessorias de cobran\u00C3\u00A7a a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (idConta).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageHistoricoAssessoriaResponse</returns>
        public ApiResponse< PageHistoricoAssessoriaResponse > ListarHistoricoAssessoriaUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAssessoriaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAssessoriaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageHistoricoAssessoriaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoAssessoriaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoAssessoriaResponse)));
            
        }

        
        /// <summary>
        /// Lista o hist\u00C3\u00B3rico de entradas/sa\u00C3\u00ADdas de assessorias de cobran\u00C3\u00A7a Permite listar todos os registros de entrada e sa\u00C3\u00ADda da Conta em arquivos de integra\u00C3\u00A7\u00C3\u00A3o com empresas de assessorias de cobran\u00C3\u00A7a a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (idConta).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageHistoricoAssessoriaResponse</returns>
        public async System.Threading.Tasks.Task<PageHistoricoAssessoriaResponse> ListarHistoricoAssessoriaUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageHistoricoAssessoriaResponse> localVarResponse = await ListarHistoricoAssessoriaUsingGETAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista o hist\u00C3\u00B3rico de entradas/sa\u00C3\u00ADdas de assessorias de cobran\u00C3\u00A7a Permite listar todos os registros de entrada e sa\u00C3\u00ADda da Conta em arquivos de integra\u00C3\u00A7\u00C3\u00A3o com empresas de assessorias de cobran\u00C3\u00A7a a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (idConta).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoAssessoriaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageHistoricoAssessoriaResponse>> ListarHistoricoAssessoriaUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAssessoriaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAssessoriaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageHistoricoAssessoriaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoAssessoriaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoAssessoriaResponse)));
            
        }
        
        /// <summary>
        /// Lista o historico de atrasos das faturas Este recurso lista o hist\u00C3\u00B3rico do pagamento de faturas em atraso
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageHistoricoAtrasoFaturaResponse</returns>
        public PageHistoricoAtrasoFaturaResponse ListarHistoricoAtrasosFaturasUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageHistoricoAtrasoFaturaResponse> localVarResponse = ListarHistoricoAtrasosFaturasUsingGETWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista o historico de atrasos das faturas Este recurso lista o hist\u00C3\u00B3rico do pagamento de faturas em atraso
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageHistoricoAtrasoFaturaResponse</returns>
        public ApiResponse< PageHistoricoAtrasoFaturaResponse > ListarHistoricoAtrasosFaturasUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAtrasosFaturasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAtrasosFaturasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageHistoricoAtrasoFaturaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoAtrasoFaturaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoAtrasoFaturaResponse)));
            
        }

        
        /// <summary>
        /// Lista o historico de atrasos das faturas Este recurso lista o hist\u00C3\u00B3rico do pagamento de faturas em atraso
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageHistoricoAtrasoFaturaResponse</returns>
        public async System.Threading.Tasks.Task<PageHistoricoAtrasoFaturaResponse> ListarHistoricoAtrasosFaturasUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageHistoricoAtrasoFaturaResponse> localVarResponse = await ListarHistoricoAtrasosFaturasUsingGETAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista o historico de atrasos das faturas Este recurso lista o hist\u00C3\u00B3rico do pagamento de faturas em atraso
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoAtrasoFaturaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageHistoricoAtrasoFaturaResponse>> ListarHistoricoAtrasosFaturasUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAtrasosFaturasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAtrasosFaturasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageHistoricoAtrasoFaturaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoAtrasoFaturaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoAtrasoFaturaResponse)));
            
        }
        
        /// <summary>
        /// Lista as transa\u00C3\u00A7\u00C3\u00B5es n\u00C3\u00A3o processadas da conta Este m\u00C3\u00A9todo permite que sejam listadas todas as transa\u00C3\u00A7\u00C3\u00B5es n\u00C3\u00A3o processadas da Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="dataInicio">Data de in\u00C3\u00ADcio da consulta do extrato no formato yyyy-MM-dd (Par\u00C3\u00A2mentro Ignorado se dataFim n\u00C3\u00A3o for definida). (optional)</param> 
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Par\u00C3\u00A2mentro Ignorado se dataInicio n\u00C3\u00A3o for definida). (optional)</param> 
        /// <returns>PageTransacaoNaoProcessadaResponse</returns>
        public PageTransacaoNaoProcessadaResponse ListarNaoProcessadasUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null)
        {
             ApiResponse<PageTransacaoNaoProcessadaResponse> localVarResponse = ListarNaoProcessadasUsingGETWithHttpInfo(id, sort, page, limit, dataInicio, dataFim);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as transa\u00C3\u00A7\u00C3\u00B5es n\u00C3\u00A3o processadas da conta Este m\u00C3\u00A9todo permite que sejam listadas todas as transa\u00C3\u00A7\u00C3\u00B5es n\u00C3\u00A3o processadas da Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="dataInicio">Data de in\u00C3\u00ADcio da consulta do extrato no formato yyyy-MM-dd (Par\u00C3\u00A2mentro Ignorado se dataFim n\u00C3\u00A3o for definida). (optional)</param> 
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Par\u00C3\u00A2mentro Ignorado se dataInicio n\u00C3\u00A3o for definida). (optional)</param> 
        /// <returns>ApiResponse of PageTransacaoNaoProcessadaResponse</returns>
        public ApiResponse< PageTransacaoNaoProcessadaResponse > ListarNaoProcessadasUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ListarNaoProcessadasUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/transacoes/listar-nao-processadas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
            if (dataInicio != null) localVarQueryParams.Add("dataInicio", Configuration.ApiClient.ParameterToString(dataInicio)); // query parameter
            if (dataFim != null) localVarQueryParams.Add("dataFim", Configuration.ApiClient.ParameterToString(dataFim)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarNaoProcessadasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarNaoProcessadasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTransacaoNaoProcessadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacaoNaoProcessadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacaoNaoProcessadaResponse)));
            
        }

        
        /// <summary>
        /// Lista as transa\u00C3\u00A7\u00C3\u00B5es n\u00C3\u00A3o processadas da conta Este m\u00C3\u00A9todo permite que sejam listadas todas as transa\u00C3\u00A7\u00C3\u00B5es n\u00C3\u00A3o processadas da Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataInicio">Data de in\u00C3\u00ADcio da consulta do extrato no formato yyyy-MM-dd (Par\u00C3\u00A2mentro Ignorado se dataFim n\u00C3\u00A3o for definida). (optional)</param>
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Par\u00C3\u00A2mentro Ignorado se dataInicio n\u00C3\u00A3o for definida). (optional)</param>
        /// <returns>Task of PageTransacaoNaoProcessadaResponse</returns>
        public async System.Threading.Tasks.Task<PageTransacaoNaoProcessadaResponse> ListarNaoProcessadasUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null)
        {
             ApiResponse<PageTransacaoNaoProcessadaResponse> localVarResponse = await ListarNaoProcessadasUsingGETAsyncWithHttpInfo(id, sort, page, limit, dataInicio, dataFim);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as transa\u00C3\u00A7\u00C3\u00B5es n\u00C3\u00A3o processadas da conta Este m\u00C3\u00A9todo permite que sejam listadas todas as transa\u00C3\u00A7\u00C3\u00B5es n\u00C3\u00A3o processadas da Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataInicio">Data de in\u00C3\u00ADcio da consulta do extrato no formato yyyy-MM-dd (Par\u00C3\u00A2mentro Ignorado se dataFim n\u00C3\u00A3o for definida). (optional)</param>
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Par\u00C3\u00A2mentro Ignorado se dataInicio n\u00C3\u00A3o for definida). (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacaoNaoProcessadaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransacaoNaoProcessadaResponse>> ListarNaoProcessadasUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarNaoProcessadasUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/transacoes/listar-nao-processadas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
            if (dataInicio != null) localVarQueryParams.Add("dataInicio", Configuration.ApiClient.ParameterToString(dataInicio)); // query parameter
            if (dataFim != null) localVarQueryParams.Add("dataFim", Configuration.ApiClient.ParameterToString(dataFim)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarNaoProcessadasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarNaoProcessadasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTransacaoNaoProcessadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacaoNaoProcessadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacaoNaoProcessadaResponse)));
            
        }
        
        /// <summary>
        /// Lista as transa\u00C3\u00A7\u00C3\u00B5es processadas da conta Este m\u00C3\u00A9todo permite que sejam listadas todas as transa\u00C3\u00A7\u00C3\u00B5es processadas da Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="dataVencimento">Data de vencimento do extrato no formato yyyy-MM-dd. (optional)</param> 
        /// <param name="dataInicio">Data de in\u00C3\u00ADcio da consulta do extrato no formato yyyy-MM-dd (Ignorado quando o par\u00C3\u00A2mentro dataVencimento \u00C3\u00A9 usado). (optional)</param> 
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Ignorado quando o par\u00C3\u00A2mentro dataVencimento \u00C3\u00A9 usado). (optional)</param> 
        /// <returns>PageTransacoesCorrentesResponse</returns>
        public PageTransacoesCorrentesResponse ListarProcessadasUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null)
        {
             ApiResponse<PageTransacoesCorrentesResponse> localVarResponse = ListarProcessadasUsingGETWithHttpInfo(id, sort, page, limit, dataVencimento, dataInicio, dataFim);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as transa\u00C3\u00A7\u00C3\u00B5es processadas da conta Este m\u00C3\u00A9todo permite que sejam listadas todas as transa\u00C3\u00A7\u00C3\u00B5es processadas da Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="dataVencimento">Data de vencimento do extrato no formato yyyy-MM-dd. (optional)</param> 
        /// <param name="dataInicio">Data de in\u00C3\u00ADcio da consulta do extrato no formato yyyy-MM-dd (Ignorado quando o par\u00C3\u00A2mentro dataVencimento \u00C3\u00A9 usado). (optional)</param> 
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Ignorado quando o par\u00C3\u00A2mentro dataVencimento \u00C3\u00A9 usado). (optional)</param> 
        /// <returns>ApiResponse of PageTransacoesCorrentesResponse</returns>
        public ApiResponse< PageTransacoesCorrentesResponse > ListarProcessadasUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ListarProcessadasUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/transacoes/listar-processadas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            if (dataInicio != null) localVarQueryParams.Add("dataInicio", Configuration.ApiClient.ParameterToString(dataInicio)); // query parameter
            if (dataFim != null) localVarQueryParams.Add("dataFim", Configuration.ApiClient.ParameterToString(dataFim)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarProcessadasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarProcessadasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTransacoesCorrentesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacoesCorrentesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacoesCorrentesResponse)));
            
        }

        
        /// <summary>
        /// Lista as transa\u00C3\u00A7\u00C3\u00B5es processadas da conta Este m\u00C3\u00A9todo permite que sejam listadas todas as transa\u00C3\u00A7\u00C3\u00B5es processadas da Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataVencimento">Data de vencimento do extrato no formato yyyy-MM-dd. (optional)</param>
        /// <param name="dataInicio">Data de in\u00C3\u00ADcio da consulta do extrato no formato yyyy-MM-dd (Ignorado quando o par\u00C3\u00A2mentro dataVencimento \u00C3\u00A9 usado). (optional)</param>
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Ignorado quando o par\u00C3\u00A2mentro dataVencimento \u00C3\u00A9 usado). (optional)</param>
        /// <returns>Task of PageTransacoesCorrentesResponse</returns>
        public async System.Threading.Tasks.Task<PageTransacoesCorrentesResponse> ListarProcessadasUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null)
        {
             ApiResponse<PageTransacoesCorrentesResponse> localVarResponse = await ListarProcessadasUsingGETAsyncWithHttpInfo(id, sort, page, limit, dataVencimento, dataInicio, dataFim);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as transa\u00C3\u00A7\u00C3\u00B5es processadas da conta Este m\u00C3\u00A9todo permite que sejam listadas todas as transa\u00C3\u00A7\u00C3\u00B5es processadas da Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataVencimento">Data de vencimento do extrato no formato yyyy-MM-dd. (optional)</param>
        /// <param name="dataInicio">Data de in\u00C3\u00ADcio da consulta do extrato no formato yyyy-MM-dd (Ignorado quando o par\u00C3\u00A2mentro dataVencimento \u00C3\u00A9 usado). (optional)</param>
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Ignorado quando o par\u00C3\u00A2mentro dataVencimento \u00C3\u00A9 usado). (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacoesCorrentesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransacoesCorrentesResponse>> ListarProcessadasUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarProcessadasUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/transacoes/listar-processadas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            if (dataInicio != null) localVarQueryParams.Add("dataInicio", Configuration.ApiClient.ParameterToString(dataInicio)); // query parameter
            if (dataFim != null) localVarQueryParams.Add("dataFim", Configuration.ApiClient.ParameterToString(dataFim)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarProcessadasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarProcessadasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTransacoesCorrentesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacoesCorrentesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacoesCorrentesResponse)));
            
        }
        
        /// <summary>
        /// Lista contas existentes na base de dados do Emissor Este recurso permite listar contas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idProduto">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do produto ao qual a conta faz parte. (id). (optional)</param> 
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id) que deu origem a Conta. (optional)</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa Titular da Conta (id). (optional)</param> 
        /// <param name="idStatusConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do status da conta. (optional)</param> 
        /// <param name="diaVencimento">Apresenta o dia de vencimento. (optional)</param> 
        /// <param name="melhorDiaCompra">Apresenta o melhor dia de compra. (optional)</param> 
        /// <param name="dataStatusConta">Apresenta a data em que o idStatusConta atual fora atribu\u00C3\u00ADdo para ela. (optional)</param> 
        /// <param name="dataCadastro">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param> 
        /// <param name="dataUltimaAlteracaoVencimento">Apresenta a data da ultima altera\u00C3\u00A7\u00C3\u00A3o de vencimento. (optional)</param> 
        /// <returns>PageContaResponse</returns>
        public PageContaResponse ListarUsingGET16 (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, string dataStatusConta = null, string dataCadastro = null, string dataUltimaAlteracaoVencimento = null)
        {
             ApiResponse<PageContaResponse> localVarResponse = ListarUsingGET16WithHttpInfo(sort, page, limit, idProduto, idOrigemComercial, idPessoa, idStatusConta, diaVencimento, melhorDiaCompra, dataStatusConta, dataCadastro, dataUltimaAlteracaoVencimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista contas existentes na base de dados do Emissor Este recurso permite listar contas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idProduto">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do produto ao qual a conta faz parte. (id). (optional)</param> 
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id) que deu origem a Conta. (optional)</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa Titular da Conta (id). (optional)</param> 
        /// <param name="idStatusConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do status da conta. (optional)</param> 
        /// <param name="diaVencimento">Apresenta o dia de vencimento. (optional)</param> 
        /// <param name="melhorDiaCompra">Apresenta o melhor dia de compra. (optional)</param> 
        /// <param name="dataStatusConta">Apresenta a data em que o idStatusConta atual fora atribu\u00C3\u00ADdo para ela. (optional)</param> 
        /// <param name="dataCadastro">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param> 
        /// <param name="dataUltimaAlteracaoVencimento">Apresenta a data da ultima altera\u00C3\u00A7\u00C3\u00A3o de vencimento. (optional)</param> 
        /// <returns>ApiResponse of PageContaResponse</returns>
        public ApiResponse< PageContaResponse > ListarUsingGET16WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, string dataStatusConta = null, string dataCadastro = null, string dataUltimaAlteracaoVencimento = null)
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET16: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET16: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaResponse)));
            
        }

        
        /// <summary>
        /// Lista contas existentes na base de dados do Emissor Este recurso permite listar contas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do produto ao qual a conta faz parte. (id). (optional)</param>
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id) que deu origem a Conta. (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa Titular da Conta (id). (optional)</param>
        /// <param name="idStatusConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do status da conta. (optional)</param>
        /// <param name="diaVencimento">Apresenta o dia de vencimento. (optional)</param>
        /// <param name="melhorDiaCompra">Apresenta o melhor dia de compra. (optional)</param>
        /// <param name="dataStatusConta">Apresenta a data em que o idStatusConta atual fora atribu\u00C3\u00ADdo para ela. (optional)</param>
        /// <param name="dataCadastro">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param>
        /// <param name="dataUltimaAlteracaoVencimento">Apresenta a data da ultima altera\u00C3\u00A7\u00C3\u00A3o de vencimento. (optional)</param>
        /// <returns>Task of PageContaResponse</returns>
        public async System.Threading.Tasks.Task<PageContaResponse> ListarUsingGET16Async (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, string dataStatusConta = null, string dataCadastro = null, string dataUltimaAlteracaoVencimento = null)
        {
             ApiResponse<PageContaResponse> localVarResponse = await ListarUsingGET16AsyncWithHttpInfo(sort, page, limit, idProduto, idOrigemComercial, idPessoa, idStatusConta, diaVencimento, melhorDiaCompra, dataStatusConta, dataCadastro, dataUltimaAlteracaoVencimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista contas existentes na base de dados do Emissor Este recurso permite listar contas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do produto ao qual a conta faz parte. (id). (optional)</param>
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id) que deu origem a Conta. (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa Titular da Conta (id). (optional)</param>
        /// <param name="idStatusConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do status da conta. (optional)</param>
        /// <param name="diaVencimento">Apresenta o dia de vencimento. (optional)</param>
        /// <param name="melhorDiaCompra">Apresenta o melhor dia de compra. (optional)</param>
        /// <param name="dataStatusConta">Apresenta a data em que o idStatusConta atual fora atribu\u00C3\u00ADdo para ela. (optional)</param>
        /// <param name="dataCadastro">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param>
        /// <param name="dataUltimaAlteracaoVencimento">Apresenta a data da ultima altera\u00C3\u00A7\u00C3\u00A3o de vencimento. (optional)</param>
        /// <returns>Task of ApiResponse (PageContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageContaResponse>> ListarUsingGET16AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, string dataStatusConta = null, string dataCadastro = null, string dataUltimaAlteracaoVencimento = null)
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET16: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET16: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaResponse)));
            
        }
        
        /// <summary>
        /// Lista as transfer\u00C3\u00AAncias realizadas pela conta Este m\u00C3\u00A9todo permite que sejam listadas as transfer\u00C3\u00AAncias realizadas pela conta existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idTransferencia">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id). (optional)</param> 
        /// <param name="idContaOrigem">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 debitado para a transfer\u00C3\u00AAncia. (id). (optional)</param> 
        /// <param name="idContaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 creditado para a transfer\u00C3\u00AAncia. (id). (optional)</param> 
        /// <param name="valorTransferencia">Valor estabelecido para ser transferido. (optional)</param> 
        /// <param name="dataTransferencia">Data estabelecida para ocorrer a transfer\u00C3\u00AAncia. (optional)</param> 
        /// <returns>PageTransferenciaResponse</returns>
        public PageTransferenciaResponse ListarUsingGET48 (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, string dataTransferencia = null)
        {
             ApiResponse<PageTransferenciaResponse> localVarResponse = ListarUsingGET48WithHttpInfo(id, sort, page, limit, idTransferencia, idContaOrigem, idContaDestino, valorTransferencia, dataTransferencia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as transfer\u00C3\u00AAncias realizadas pela conta Este m\u00C3\u00A9todo permite que sejam listadas as transfer\u00C3\u00AAncias realizadas pela conta existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idTransferencia">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id). (optional)</param> 
        /// <param name="idContaOrigem">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 debitado para a transfer\u00C3\u00AAncia. (id). (optional)</param> 
        /// <param name="idContaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 creditado para a transfer\u00C3\u00AAncia. (id). (optional)</param> 
        /// <param name="valorTransferencia">Valor estabelecido para ser transferido. (optional)</param> 
        /// <param name="dataTransferencia">Data estabelecida para ocorrer a transfer\u00C3\u00AAncia. (optional)</param> 
        /// <returns>ApiResponse of PageTransferenciaResponse</returns>
        public ApiResponse< PageTransferenciaResponse > ListarUsingGET48WithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, string dataTransferencia = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ListarUsingGET48");
            
    
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (idTransferencia != null) localVarQueryParams.Add("idTransferencia", Configuration.ApiClient.ParameterToString(idTransferencia)); // query parameter
            if (idContaOrigem != null) localVarQueryParams.Add("idContaOrigem", Configuration.ApiClient.ParameterToString(idContaOrigem)); // query parameter
            if (idContaDestino != null) localVarQueryParams.Add("idContaDestino", Configuration.ApiClient.ParameterToString(idContaDestino)); // query parameter
            if (valorTransferencia != null) localVarQueryParams.Add("valorTransferencia", Configuration.ApiClient.ParameterToString(valorTransferencia)); // query parameter
            if (dataTransferencia != null) localVarQueryParams.Add("dataTransferencia", Configuration.ApiClient.ParameterToString(dataTransferencia)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET48: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET48: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTransferenciaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransferenciaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransferenciaResponse)));
            
        }

        
        /// <summary>
        /// Lista as transfer\u00C3\u00AAncias realizadas pela conta Este m\u00C3\u00A9todo permite que sejam listadas as transfer\u00C3\u00AAncias realizadas pela conta existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTransferencia">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id). (optional)</param>
        /// <param name="idContaOrigem">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 debitado para a transfer\u00C3\u00AAncia. (id). (optional)</param>
        /// <param name="idContaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 creditado para a transfer\u00C3\u00AAncia. (id). (optional)</param>
        /// <param name="valorTransferencia">Valor estabelecido para ser transferido. (optional)</param>
        /// <param name="dataTransferencia">Data estabelecida para ocorrer a transfer\u00C3\u00AAncia. (optional)</param>
        /// <returns>Task of PageTransferenciaResponse</returns>
        public async System.Threading.Tasks.Task<PageTransferenciaResponse> ListarUsingGET48Async (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, string dataTransferencia = null)
        {
             ApiResponse<PageTransferenciaResponse> localVarResponse = await ListarUsingGET48AsyncWithHttpInfo(id, sort, page, limit, idTransferencia, idContaOrigem, idContaDestino, valorTransferencia, dataTransferencia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as transfer\u00C3\u00AAncias realizadas pela conta Este m\u00C3\u00A9todo permite que sejam listadas as transfer\u00C3\u00AAncias realizadas pela conta existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTransferencia">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id). (optional)</param>
        /// <param name="idContaOrigem">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 debitado para a transfer\u00C3\u00AAncia. (id). (optional)</param>
        /// <param name="idContaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 creditado para a transfer\u00C3\u00AAncia. (id). (optional)</param>
        /// <param name="valorTransferencia">Valor estabelecido para ser transferido. (optional)</param>
        /// <param name="dataTransferencia">Data estabelecida para ocorrer a transfer\u00C3\u00AAncia. (optional)</param>
        /// <returns>Task of ApiResponse (PageTransferenciaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransferenciaResponse>> ListarUsingGET48AsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, string dataTransferencia = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarUsingGET48");
            
    
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (idTransferencia != null) localVarQueryParams.Add("idTransferencia", Configuration.ApiClient.ParameterToString(idTransferencia)); // query parameter
            if (idContaOrigem != null) localVarQueryParams.Add("idContaOrigem", Configuration.ApiClient.ParameterToString(idContaOrigem)); // query parameter
            if (idContaDestino != null) localVarQueryParams.Add("idContaDestino", Configuration.ApiClient.ParameterToString(idContaDestino)); // query parameter
            if (valorTransferencia != null) localVarQueryParams.Add("valorTransferencia", Configuration.ApiClient.ParameterToString(valorTransferencia)); // query parameter
            if (dataTransferencia != null) localVarQueryParams.Add("dataTransferencia", Configuration.ApiClient.ParameterToString(dataTransferencia)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET48: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET48: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTransferenciaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransferenciaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransferenciaResponse)));
            
        }
        
        /// <summary>
        /// Realiza a reativa\u00C3\u00A7\u00C3\u00A3o de contas. Este recurso permite reativar contas. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <returns>Object</returns>
        public Object ReativarUsingPOST1 (long? id)
        {
             ApiResponse<Object> localVarResponse = ReativarUsingPOST1WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a reativa\u00C3\u00A7\u00C3\u00A3o de contas. Este recurso permite reativar contas. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > ReativarUsingPOST1WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ReativarUsingPOST1");
            
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ReativarUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ReativarUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Realiza a reativa\u00C3\u00A7\u00C3\u00A3o de contas. Este recurso permite reativar contas. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ReativarUsingPOST1Async (long? id)
        {
             ApiResponse<Object> localVarResponse = await ReativarUsingPOST1AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a reativa\u00C3\u00A7\u00C3\u00A3o de contas. Este recurso permite reativar contas. Para isso, ser\u00C3\u00A1 preciso informar o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ReativarUsingPOST1AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReativarUsingPOST1");
            
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ReativarUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ReativarUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Simula valores de presta\u00C3\u00A7\u00C3\u00B5es de empr\u00C3\u00A9stimos/financiamentos Esta opera\u00C3\u00A7\u00C3\u00A3o pode ser utilizada para simular opera\u00C3\u00A7\u00C3\u00B5es financeiras a partir de informa\u00C3\u00A7\u00C3\u00B5es fornecidas pelo usu\u00C3\u00A1rio. Os c\u00C3\u00A1lculos gerados devem ser considerados apenas como refer\u00C3\u00AAncia para as situa\u00C3\u00A7\u00C3\u00B5es reais e n\u00C3\u00A3o como valores oficiais.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="request">request</param> 
        /// <returns>EmprestimoPessoalResponse</returns>
        public EmprestimoPessoalResponse SimularEmprestimoFinanciamentoUsingPOST (long? id, EmprestimoPessoalRequest request)
        {
             ApiResponse<EmprestimoPessoalResponse> localVarResponse = SimularEmprestimoFinanciamentoUsingPOSTWithHttpInfo(id, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Simula valores de presta\u00C3\u00A7\u00C3\u00B5es de empr\u00C3\u00A9stimos/financiamentos Esta opera\u00C3\u00A7\u00C3\u00A3o pode ser utilizada para simular opera\u00C3\u00A7\u00C3\u00B5es financeiras a partir de informa\u00C3\u00A7\u00C3\u00B5es fornecidas pelo usu\u00C3\u00A1rio. Os c\u00C3\u00A1lculos gerados devem ser considerados apenas como refer\u00C3\u00AAncia para as situa\u00C3\u00A7\u00C3\u00B5es reais e n\u00C3\u00A3o como valores oficiais.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="request">request</param> 
        /// <returns>ApiResponse of EmprestimoPessoalResponse</returns>
        public ApiResponse< EmprestimoPessoalResponse > SimularEmprestimoFinanciamentoUsingPOSTWithHttpInfo (long? id, EmprestimoPessoalRequest request)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->SimularEmprestimoFinanciamentoUsingPOST");
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling ContaApi->SimularEmprestimoFinanciamentoUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/simular-emprestimos-financiamentos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling SimularEmprestimoFinanciamentoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularEmprestimoFinanciamentoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EmprestimoPessoalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmprestimoPessoalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmprestimoPessoalResponse)));
            
        }

        
        /// <summary>
        /// Simula valores de presta\u00C3\u00A7\u00C3\u00B5es de empr\u00C3\u00A9stimos/financiamentos Esta opera\u00C3\u00A7\u00C3\u00A3o pode ser utilizada para simular opera\u00C3\u00A7\u00C3\u00B5es financeiras a partir de informa\u00C3\u00A7\u00C3\u00B5es fornecidas pelo usu\u00C3\u00A1rio. Os c\u00C3\u00A1lculos gerados devem ser considerados apenas como refer\u00C3\u00AAncia para as situa\u00C3\u00A7\u00C3\u00B5es reais e n\u00C3\u00A3o como valores oficiais.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="request">request</param>
        /// <returns>Task of EmprestimoPessoalResponse</returns>
        public async System.Threading.Tasks.Task<EmprestimoPessoalResponse> SimularEmprestimoFinanciamentoUsingPOSTAsync (long? id, EmprestimoPessoalRequest request)
        {
             ApiResponse<EmprestimoPessoalResponse> localVarResponse = await SimularEmprestimoFinanciamentoUsingPOSTAsyncWithHttpInfo(id, request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Simula valores de presta\u00C3\u00A7\u00C3\u00B5es de empr\u00C3\u00A9stimos/financiamentos Esta opera\u00C3\u00A7\u00C3\u00A3o pode ser utilizada para simular opera\u00C3\u00A7\u00C3\u00B5es financeiras a partir de informa\u00C3\u00A7\u00C3\u00B5es fornecidas pelo usu\u00C3\u00A1rio. Os c\u00C3\u00A1lculos gerados devem ser considerados apenas como refer\u00C3\u00AAncia para as situa\u00C3\u00A7\u00C3\u00B5es reais e n\u00C3\u00A3o como valores oficiais.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (EmprestimoPessoalResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmprestimoPessoalResponse>> SimularEmprestimoFinanciamentoUsingPOSTAsyncWithHttpInfo (long? id, EmprestimoPessoalRequest request)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SimularEmprestimoFinanciamentoUsingPOST");
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling SimularEmprestimoFinanciamentoUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/simular-emprestimos-financiamentos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling SimularEmprestimoFinanciamentoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularEmprestimoFinanciamentoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmprestimoPessoalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmprestimoPessoalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmprestimoPessoalResponse)));
            
        }
        
        /// <summary>
        /// Permite listar uma linha do tempo com os eventos da conta Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir a listagem, em formato de timeline, dos eventos vinculados a uma detemrinada conta. Transa\u00C3\u00A7\u00C3\u00B5es, fechamento da fatura, pagamentos, gera\u00C3\u00A7\u00C3\u00A3o de cart\u00C3\u00B5es e altera\u00C3\u00A7\u00C3\u00A3o de limite s\u00C3\u00A3o exemplos de eventos contemplados por esta funcionalidade. Neste m\u00C3\u00A9todo, as opera\u00C3\u00A7\u00C3\u00B5es s\u00C3\u00A3o ordenadas de forma decrescente.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageTransacaoResponse</returns>
        public PageTransacaoResponse TransacoesUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTransacaoResponse> localVarResponse = TransacoesUsingGETWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite listar uma linha do tempo com os eventos da conta Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir a listagem, em formato de timeline, dos eventos vinculados a uma detemrinada conta. Transa\u00C3\u00A7\u00C3\u00B5es, fechamento da fatura, pagamentos, gera\u00C3\u00A7\u00C3\u00A3o de cart\u00C3\u00B5es e altera\u00C3\u00A7\u00C3\u00A3o de limite s\u00C3\u00A3o exemplos de eventos contemplados por esta funcionalidade. Neste m\u00C3\u00A9todo, as opera\u00C3\u00A7\u00C3\u00B5es s\u00C3\u00A3o ordenadas de forma decrescente.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageTransacaoResponse</returns>
        public ApiResponse< PageTransacaoResponse > TransacoesUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
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
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageTransacaoResponse</returns>
        public async System.Threading.Tasks.Task<PageTransacaoResponse> TransacoesUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTransacaoResponse> localVarResponse = await TransacoesUsingGETAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite listar uma linha do tempo com os eventos da conta Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir a listagem, em formato de timeline, dos eventos vinculados a uma detemrinada conta. Transa\u00C3\u00A7\u00C3\u00B5es, fechamento da fatura, pagamentos, gera\u00C3\u00A7\u00C3\u00A3o de cart\u00C3\u00B5es e altera\u00C3\u00A7\u00C3\u00A3o de limite s\u00C3\u00A3o exemplos de eventos contemplados por esta funcionalidade. Neste m\u00C3\u00A9todo, as opera\u00C3\u00A7\u00C3\u00B5es s\u00C3\u00A3o ordenadas de forma decrescente.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransacaoResponse>> TransacoesUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

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
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta do cliente portador do cart\u00C3\u00A3o que ser\u00C3\u00A1 debitado (id).</param> 
        /// <param name="idContaDestino">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do cliente portador do cart\u00C3\u00A3o que ser\u00C3\u00A1 creditado (id).</param> 
        /// <param name="valorTransferencia">Valor da Transfer\u00C3\u00AAncia.</param> 
        /// <returns>TransferenciaDetalheResponse</returns>
        public TransferenciaDetalheResponse TransferirUsingPOST1 (long? id, long? idContaDestino, double? valorTransferencia)
        {
             ApiResponse<TransferenciaDetalheResponse> localVarResponse = TransferirUsingPOST1WithHttpInfo(id, idContaDestino, valorTransferencia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza uma transfer\u00C3\u00AAncia de Cr\u00C3\u00A9dito para outro cliente do mesmo Emissor Este m\u00C3\u00A9todo permite que um portador de um cart\u00C3\u00A3o possa realizar auma transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para outro cliente do mesmo emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta do cliente portador do cart\u00C3\u00A3o que ser\u00C3\u00A1 debitado (id).</param> 
        /// <param name="idContaDestino">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do cliente portador do cart\u00C3\u00A3o que ser\u00C3\u00A1 creditado (id).</param> 
        /// <param name="valorTransferencia">Valor da Transfer\u00C3\u00AAncia.</param> 
        /// <returns>ApiResponse of TransferenciaDetalheResponse</returns>
        public ApiResponse< TransferenciaDetalheResponse > TransferirUsingPOST1WithHttpInfo (long? id, long? idContaDestino, double? valorTransferencia)
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling TransferirUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TransferirUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransferenciaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaDetalheResponse)));
            
        }

        
        /// <summary>
        /// Realiza uma transfer\u00C3\u00AAncia de Cr\u00C3\u00A9dito para outro cliente do mesmo Emissor Este m\u00C3\u00A9todo permite que um portador de um cart\u00C3\u00A3o possa realizar auma transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para outro cliente do mesmo emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta do cliente portador do cart\u00C3\u00A3o que ser\u00C3\u00A1 debitado (id).</param>
        /// <param name="idContaDestino">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do cliente portador do cart\u00C3\u00A3o que ser\u00C3\u00A1 creditado (id).</param>
        /// <param name="valorTransferencia">Valor da Transfer\u00C3\u00AAncia.</param>
        /// <returns>Task of TransferenciaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<TransferenciaDetalheResponse> TransferirUsingPOST1Async (long? id, long? idContaDestino, double? valorTransferencia)
        {
             ApiResponse<TransferenciaDetalheResponse> localVarResponse = await TransferirUsingPOST1AsyncWithHttpInfo(id, idContaDestino, valorTransferencia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza uma transfer\u00C3\u00AAncia de Cr\u00C3\u00A9dito para outro cliente do mesmo Emissor Este m\u00C3\u00A9todo permite que um portador de um cart\u00C3\u00A3o possa realizar auma transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para outro cliente do mesmo emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta do cliente portador do cart\u00C3\u00A3o que ser\u00C3\u00A1 debitado (id).</param>
        /// <param name="idContaDestino">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do cliente portador do cart\u00C3\u00A3o que ser\u00C3\u00A1 creditado (id).</param>
        /// <param name="valorTransferencia">Valor da Transfer\u00C3\u00AAncia.</param>
        /// <returns>Task of ApiResponse (TransferenciaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransferenciaDetalheResponse>> TransferirUsingPOST1AsyncWithHttpInfo (long? id, long? idContaDestino, double? valorTransferencia)
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling TransferirUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TransferirUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransferenciaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaDetalheResponse)));
            
        }
        
    }
    
}
