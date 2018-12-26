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
        /// Lan\u00E7a um ajuste para a conta do id informado
        /// </summary>
        /// <remarks>
        /// Este recurso insere um ajuste para a conta do id informado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idTipoAjuste">C\u00F3digo identificador do tipo de ajuste</param>
        /// <param name="dataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</param>
        /// <param name="valorAjuste">Valor do ajuste</param>
        /// <param name="login">login (optional)</param>
        /// <param name="identificadorExterno">Identificador Externo (optional)</param>
        /// <param name="idTransacaoOriginal">Identificador da transa\u00E7\u00E3o original (estorno) (optional)</param>
        /// <param name="idEstabelecimento">Identificador do estabelecimento quando o pagamento for efetuado em loja (optional)</param>
        /// <returns>AjusteFinanceiroResponse</returns>
        AjusteFinanceiroResponse AjustarConta (long? id, long? idTipoAjuste, string dataAjuste, double? valorAjuste, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null, long? idEstabelecimento = null);
  
        /// <summary>
        /// Lan\u00E7a um ajuste para a conta do id informado
        /// </summary>
        /// <remarks>
        /// Este recurso insere um ajuste para a conta do id informado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idTipoAjuste">C\u00F3digo identificador do tipo de ajuste</param>
        /// <param name="dataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</param>
        /// <param name="valorAjuste">Valor do ajuste</param>
        /// <param name="login">login (optional)</param>
        /// <param name="identificadorExterno">Identificador Externo (optional)</param>
        /// <param name="idTransacaoOriginal">Identificador da transa\u00E7\u00E3o original (estorno) (optional)</param>
        /// <param name="idEstabelecimento">Identificador do estabelecimento quando o pagamento for efetuado em loja (optional)</param>
        /// <returns>ApiResponse of AjusteFinanceiroResponse</returns>
        ApiResponse<AjusteFinanceiroResponse> AjustarContaWithHttpInfo (long? id, long? idTipoAjuste, string dataAjuste, double? valorAjuste, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null, long? idEstabelecimento = null);
        
        /// <summary>
        /// Altera o produto associado \u00E0 conta
        /// </summary>
        /// <remarks>
        /// O recurso permite fazer modifica\u00E7\u00E3o do produto associado \u00E0 conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="request">request</param>
        /// <returns>string</returns>
        string AlterarProduto (long? id, AlterarProdutoRequest request);
  
        /// <summary>
        /// Altera o produto associado \u00E0 conta
        /// </summary>
        /// <remarks>
        /// O recurso permite fazer modifica\u00E7\u00E3o do produto associado \u00E0 conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> AlterarProdutoWithHttpInfo (long? id, AlterarProdutoRequest request);
        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o de uma Pessoa tilular da conta
        /// </summary>
        /// <remarks>
        /// Esta m\u00E9todo permite altera a pessoa de uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de identifica\u00E7\u00E3o de uma Pessoa (id)</param>
        /// <returns>ContaResponse</returns>
        ContaResponse AlterarTitular (long? id, long? idPessoa);
  
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o de uma Pessoa tilular da conta
        /// </summary>
        /// <remarks>
        /// Esta m\u00E9todo permite altera a pessoa de uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de identifica\u00E7\u00E3o de uma Pessoa (id)</param>
        /// <returns>ApiResponse of ContaResponse</returns>
        ApiResponse<ContaResponse> AlterarTitularWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o do dia de vencimento das faturas da conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite alterar o vencimento para no m\u00E1ximo at\u00E9 30 dias ap\u00F3s data atual de uma conta especifica no PIER, respeitando o par\u00E2metro de intervalor entre as modifica\u00E7\u00F5es do vencimento informado pelo emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="novoDiaVencimento">Novo dia de vencimento</param>
        /// <returns>ContaResponse</returns>
        ContaResponse AlterarVencimento (long? id, int? novoDiaVencimento);
  
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o do dia de vencimento das faturas da conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite alterar o vencimento para no m\u00E1ximo at\u00E9 30 dias ap\u00F3s data atual de uma conta especifica no PIER, respeitando o par\u00E2metro de intervalor entre as modifica\u00E7\u00F5es do vencimento informado pelo emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="novoDiaVencimento">Novo dia de vencimento</param>
        /// <returns>ApiResponse of ContaResponse</returns>
        ApiResponse<ContaResponse> AlterarVencimentoWithHttpInfo (long? id, int? novoDiaVencimento);
        
        /// <summary>
        /// Atribuir Anuidade
        /// </summary>
        /// <remarks>
        /// Esse recurso permite configurar qual a regra de Anuidade que ser\u00E1 atribu\u00EDda a uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idAnuidade">Identificador da anuidade</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="DDD">DDD do celular (optional)</param>
        /// <param name="celular">N\u00FAmero do celular (optional)</param>
        /// <param name="idOperadora">Identificador da operadora do celular (optional)</param>
        /// <param name="idOrigemComercial">Identificador da origem comercial (optional)</param>
        /// <returns>Object</returns>
        Object AtivarAnuidade (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null);
  
        /// <summary>
        /// Atribuir Anuidade
        /// </summary>
        /// <remarks>
        /// Esse recurso permite configurar qual a regra de Anuidade que ser\u00E1 atribu\u00EDda a uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idAnuidade">Identificador da anuidade</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="DDD">DDD do celular (optional)</param>
        /// <param name="celular">N\u00FAmero do celular (optional)</param>
        /// <param name="idOperadora">Identificador da operadora do celular (optional)</param>
        /// <param name="idOrigemComercial">Identificador da origem comercial (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> AtivarAnuidadeWithHttpInfo (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null);
        
        /// <summary>
        /// Ativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <remarks>
        /// Este recurso ativa o servi\u00E7o de envio de fatura por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Object</returns>
        Object AtivarEnvioFaturaEmail (long? id);
  
        /// <summary>
        /// Ativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <remarks>
        /// Este recurso ativa o servi\u00E7o de envio de fatura por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> AtivarEnvioFaturaEmailWithHttpInfo (long? id);
        
        /// <summary>
        /// Realiza a atualiza\u00E7\u00E3o parcial da conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite realizar a atualiza\u00E7\u00E3o parcial da conta. Isso indica dizer que apenas os campos informados na requisi\u00E7\u00E3o ser\u00E3o atualizados, sendo ignorados os demais
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="contaPartialUpdate">contaPartialUpdate</param>
        /// <returns>ContaResponse</returns>
        ContaResponse AtualizarParcial (long? id, ContaPartialUpdate contaPartialUpdate);
  
        /// <summary>
        /// Realiza a atualiza\u00E7\u00E3o parcial da conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite realizar a atualiza\u00E7\u00E3o parcial da conta. Isso indica dizer que apenas os campos informados na requisi\u00E7\u00E3o ser\u00E3o atualizados, sendo ignorados os demais
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="contaPartialUpdate">contaPartialUpdate</param>
        /// <returns>ApiResponse of ContaResponse</returns>
        ApiResponse<ContaResponse> AtualizarParcialWithHttpInfo (long? id, ContaPartialUpdate contaPartialUpdate);
        
        /// <summary>
        /// Realiza o bloqueio de uma determinada Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite a realiza\u00E7\u00E3o do bloqueio de uma determinada conta a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Novo Status Conta</param>
        /// <returns>ContaResponse</returns>
        ContaResponse Bloquear (long? id, long? idStatus);
  
        /// <summary>
        /// Realiza o bloqueio de uma determinada Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite a realiza\u00E7\u00E3o do bloqueio de uma determinada conta a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Novo Status Conta</param>
        /// <returns>ApiResponse of ContaResponse</returns>
        ApiResponse<ContaResponse> BloquearWithHttpInfo (long? id, long? idStatus);
        
        /// <summary>
        /// Cadastro ades\u00E3o de pagamento no s\u00E1bado
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar uma ades\u00E3o de pagamento no s\u00E1bado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id da conta</param>
        /// <returns>AdesaoPagamentoSabadoResponse</returns>
        AdesaoPagamentoSabadoResponse Cadastrar (long? id);
  
        /// <summary>
        /// Cadastro ades\u00E3o de pagamento no s\u00E1bado
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar uma ades\u00E3o de pagamento no s\u00E1bado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id da conta</param>
        /// <returns>ApiResponse of AdesaoPagamentoSabadoResponse</returns>
        ApiResponse<AdesaoPagamentoSabadoResponse> CadastrarWithHttpInfo (long? id);
        
        /// <summary>
        /// Realiza o cancelamento de uma determinada Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite a realiza\u00E7\u00E3o do cancelamento de uma determinada conta a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Novo Status Conta</param>
        /// <returns>ContaResponse</returns>
        ContaResponse Cancelar (long? id, long? idStatus);
  
        /// <summary>
        /// Realiza o cancelamento de uma determinada Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite a realiza\u00E7\u00E3o do cancelamento de uma determinada conta a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Novo Status Conta</param>
        /// <returns>ApiResponse of ContaResponse</returns>
        ApiResponse<ContaResponse> CancelarWithHttpInfo (long? id, long? idStatus);
        
        /// <summary>
        /// Consulta ades\u00E3o de pagamento no s\u00E1bado
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar uma ades\u00E3o de pagamento no s\u00E1bado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id da conta</param>
        /// <param name="dataVencimento">Data de vencimento da ades\u00E3o</param>
        /// <returns>AdesaoPagamentoSabadoResponse</returns>
        AdesaoPagamentoSabadoResponse Consultar (long? id, string dataVencimento);
  
        /// <summary>
        /// Consulta ades\u00E3o de pagamento no s\u00E1bado
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar uma ades\u00E3o de pagamento no s\u00E1bado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id da conta</param>
        /// <param name="dataVencimento">Data de vencimento da ades\u00E3o</param>
        /// <returns>ApiResponse of AdesaoPagamentoSabadoResponse</returns>
        ApiResponse<AdesaoPagamentoSabadoResponse> ConsultarWithHttpInfo (long? id, string dataVencimento);
        
        /// <summary>
        /// Apresenta a data m\u00E1xima para pagamento da fatura em atraso para receber o benef\u00EDcio
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar se o cliente tem direito ao benef\u00EDcio de pagamento em atraso, em loja, at\u00E9 o s\u00E1bado subsequente ao vencimento, ficando isento do pagamento de multa, encargos, mora e IOF
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>BeneficioPagamentoAtrasoResponse</returns>
        BeneficioPagamentoAtrasoResponse ConsultarBeneficioPagamentoAtraso (long? id);
  
        /// <summary>
        /// Apresenta a data m\u00E1xima para pagamento da fatura em atraso para receber o benef\u00EDcio
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar se o cliente tem direito ao benef\u00EDcio de pagamento em atraso, em loja, at\u00E9 o s\u00E1bado subsequente ao vencimento, ficando isento do pagamento de multa, encargos, mora e IOF
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>ApiResponse of BeneficioPagamentoAtrasoResponse</returns>
        ApiResponse<BeneficioPagamentoAtrasoResponse> ConsultarBeneficioPagamentoAtrasoWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta os dados de um determinado boleto da fatura
        /// </summary>
        /// <remarks>
        /// Este recurso consulta um boleto da fatura
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>BoletoResponse</returns>
        BoletoResponse ConsultarBoletoEmitido (long? id);
  
        /// <summary>
        /// Consulta os dados de um determinado boleto da fatura
        /// </summary>
        /// <remarks>
        /// Este recurso consulta um boleto da fatura
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>ApiResponse of BoletoResponse</returns>
        ApiResponse<BoletoResponse> ConsultarBoletoEmitidoWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta a d\u00EDvida atualizada do cliente
        /// </summary>
        /// <remarks>
        /// Este recurso consulta a d\u00EDvida atualizada do cliente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Data do vencimento (optional)</param>
        /// <param name="idEscritorioCobranca">C\u00F3digo de identifica\u00E7\u00E3o do escrit\u00F3rio de cobran\u00E7a (optional)</param>
        /// <returns>DividaClienteResponse</returns>
        DividaClienteResponse ConsultarDividaAtualizadaCliente (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, long? idEscritorioCobranca = null);
  
        /// <summary>
        /// Consulta a d\u00EDvida atualizada do cliente
        /// </summary>
        /// <remarks>
        /// Este recurso consulta a d\u00EDvida atualizada do cliente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Data do vencimento (optional)</param>
        /// <param name="idEscritorioCobranca">C\u00F3digo de identifica\u00E7\u00E3o do escrit\u00F3rio de cobran\u00E7a (optional)</param>
        /// <returns>ApiResponse of DividaClienteResponse</returns>
        ApiResponse<DividaClienteResponse> ConsultarDividaAtualizadaClienteWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, long? idEscritorioCobranca = null);
        
        /// <summary>
        /// Consulta uma transa\u00E7\u00E3o processada da conta.
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar os detalhes de uma transa\u00E7\u00E3o processada pertencente a uma conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="idTransacao">C\u00F3digo de Identifica\u00E7\u00E3o da transa\u00E7\u00E3o (id).</param>
        /// <returns>TransacoesCorrentesResponse</returns>
        TransacoesCorrentesResponse ConsultarProcessada (long? id, long? idTransacao);
  
        /// <summary>
        /// Consulta uma transa\u00E7\u00E3o processada da conta.
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar os detalhes de uma transa\u00E7\u00E3o processada pertencente a uma conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="idTransacao">C\u00F3digo de Identifica\u00E7\u00E3o da transa\u00E7\u00E3o (id).</param>
        /// <returns>ApiResponse of TransacoesCorrentesResponse</returns>
        ApiResponse<TransacoesCorrentesResponse> ConsultarProcessadaWithHttpInfo (long? id, long? idTransacao);
        
        /// <summary>
        /// Permite consultar a partir do ID da conta as taxas e tarifas
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores consultem as taxas e tarifas da conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da conta a ser consultada</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageTaxasRefinanciamentoResponse</returns>
        PageTaxasRefinanciamentoResponse ConsultarTaxasTarifas (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Permite consultar a partir do ID da conta as taxas e tarifas
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores consultem as taxas e tarifas da conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da conta a ser consultada</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageTaxasRefinanciamentoResponse</returns>
        ApiResponse<PageTaxasRefinanciamentoResponse> ConsultarTaxasTarifasWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Apresenta dados de um determinado tipo de fun\u00E7\u00E3o para contas
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar dados de um determinado tipo de fun\u00E7\u00E3o para contas a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo de fun\u00E7\u00E3o para contas (id)</param>
        /// <returns>string</returns>
        string Consultar_0 (int? id);
  
        /// <summary>
        /// Apresenta dados de um determinado tipo de fun\u00E7\u00E3o para contas
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar dados de um determinado tipo de fun\u00E7\u00E3o para contas a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo de fun\u00E7\u00E3o para contas (id)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> Consultar_0WithHttpInfo (int? id);
        
        /// <summary>
        /// Apresenta dados de uma determinada conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar dados de uma determinada conta a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>ContaDetalheResponse</returns>
        ContaDetalheResponse Consultar_1 (long? id);
  
        /// <summary>
        /// Apresenta dados de uma determinada conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar dados de uma determinada conta a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>ApiResponse of ContaDetalheResponse</returns>
        ApiResponse<ContaDetalheResponse> Consultar_1WithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta os detalhes de uma determinada transfer\u00EAncia
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os detalhes de uma determinada transfer\u00EAncia de cr\u00E9dito realizada entre contas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idTransferencia">C\u00F3digo de Identifica\u00E7\u00E3o da transfer\u00EAncia (id_transferencia)</param>
        /// <returns>TransferenciaDetalheResponse</returns>
        TransferenciaDetalheResponse Consultar_2 (long? id, long? idTransferencia);
  
        /// <summary>
        /// Consulta os detalhes de uma determinada transfer\u00EAncia
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os detalhes de uma determinada transfer\u00EAncia de cr\u00E9dito realizada entre contas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idTransferencia">C\u00F3digo de Identifica\u00E7\u00E3o da transfer\u00EAncia (id_transferencia)</param>
        /// <returns>ApiResponse of TransferenciaDetalheResponse</returns>
        ApiResponse<TransferenciaDetalheResponse> Consultar_2WithHttpInfo (long? id, long? idTransferencia);
        
        /// <summary>
        /// Cadastrar contas MultiApp
        /// </summary>
        /// <remarks>
        /// Este recurso permite o cadastro de contas MultiApp
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaMultiAppPersist">contaMultiAppPersist</param>
        /// <returns>ContaMultiAppResponse</returns>
        ContaMultiAppResponse CriarContasMultiApp (ContaMultiAppPersist contaMultiAppPersist);
  
        /// <summary>
        /// Cadastrar contas MultiApp
        /// </summary>
        /// <remarks>
        /// Este recurso permite o cadastro de contas MultiApp
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaMultiAppPersist">contaMultiAppPersist</param>
        /// <returns>ApiResponse of ContaMultiAppResponse</returns>
        ApiResponse<ContaMultiAppResponse> CriarContasMultiAppWithHttpInfo (ContaMultiAppPersist contaMultiAppPersist);
        
        /// <summary>
        /// Desativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <remarks>
        /// Este recurso desativa o servi\u00E7o de envio de fatura por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Object</returns>
        Object DesativarEnvioFaturaEmail (long? id);
  
        /// <summary>
        /// Desativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <remarks>
        /// Este recurso desativa o servi\u00E7o de envio de fatura por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> DesativarEnvioFaturaEmailWithHttpInfo (long? id);
        
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
        BoletoResponse GerarBoletoRecarga (long? id, double? valor, string dataVencimento);
  
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
        ApiResponse<BoletoResponse> GerarBoletoRecargaWithHttpInfo (long? id, double? valor, string dataVencimento);
        
        /// <summary>
        /// Realiza a gera\u00E7\u00E3o de um novo cart\u00E3o para impress\u00E3o avulsa
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja gerado um novo Cart\u00E3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00E3o que dever\u00E1 ser gerado para impress\u00E3o. Esta funcionalidade poder\u00E1 ser utilizada para realizar a impress\u00E3o de cart\u00F5es em Lojas, Quiosques, Escrit\u00F3rios, Terminais de Auto Atendimento, ou outro local que o Emissor escolher, desde que se possua uma impressora de Cart\u00F5es habilidade para o fazer, no local
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <param name="idTipoPlastico">C\u00F3digo de identifica\u00E7\u00E3o do TipoPlastico (id) (optional)</param>
        /// <returns>CartaoImpressaoResponse</returns>
        CartaoImpressaoResponse GerarCartao (long? id, long? idPessoa, long? idTipoPlastico = null);
  
        /// <summary>
        /// Realiza a gera\u00E7\u00E3o de um novo cart\u00E3o para impress\u00E3o avulsa
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja gerado um novo Cart\u00E3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00E3o que dever\u00E1 ser gerado para impress\u00E3o. Esta funcionalidade poder\u00E1 ser utilizada para realizar a impress\u00E3o de cart\u00F5es em Lojas, Quiosques, Escrit\u00F3rios, Terminais de Auto Atendimento, ou outro local que o Emissor escolher, desde que se possua uma impressora de Cart\u00F5es habilidade para o fazer, no local
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <param name="idTipoPlastico">C\u00F3digo de identifica\u00E7\u00E3o do TipoPlastico (id) (optional)</param>
        /// <returns>ApiResponse of CartaoImpressaoResponse</returns>
        ApiResponse<CartaoImpressaoResponse> GerarCartaoWithHttpInfo (long? id, long? idPessoa, long? idTipoPlastico = null);
        
        /// <summary>
        /// Realiza o envio para gera\u00E7\u00E3o de um novo cart\u00E3o na gr\u00E1fica
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja gerado um novo Cart\u00E3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00E3o que dever\u00E1 ser gerado para impress\u00E3o. Esta funcionalidade poder\u00E1 ser utilizada para impress\u00E3o de cart\u00F5es em gr\u00E1fica
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="cartaoEmbossingRequest">cartaoEmbossingRequest</param>
        /// <returns>CartaoEmbossingResponse</returns>
        CartaoEmbossingResponse GerarCartaoEmbossing (long? id, CartaoEmbossingRequest cartaoEmbossingRequest);
  
        /// <summary>
        /// Realiza o envio para gera\u00E7\u00E3o de um novo cart\u00E3o na gr\u00E1fica
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja gerado um novo Cart\u00E3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00E3o que dever\u00E1 ser gerado para impress\u00E3o. Esta funcionalidade poder\u00E1 ser utilizada para impress\u00E3o de cart\u00F5es em gr\u00E1fica
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="cartaoEmbossingRequest">cartaoEmbossingRequest</param>
        /// <returns>ApiResponse of CartaoEmbossingResponse</returns>
        ApiResponse<CartaoEmbossingResponse> GerarCartaoEmbossingWithHttpInfo (long? id, CartaoEmbossingRequest cartaoEmbossingRequest);
        
        /// <summary>
        /// Realiza a gera\u00E7\u00E3o de um cart\u00E3o provisorio
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja gerado um cart\u00E3o provis\u00F3rio para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>CartaoImpressaoProvisorioResponse</returns>
        CartaoImpressaoProvisorioResponse GerarCartaoProvisorio (long? id);
  
        /// <summary>
        /// Realiza a gera\u00E7\u00E3o de um cart\u00E3o provisorio
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja gerado um cart\u00E3o provis\u00F3rio para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>ApiResponse of CartaoImpressaoProvisorioResponse</returns>
        ApiResponse<CartaoImpressaoProvisorioResponse> GerarCartaoProvisorioWithHttpInfo (long? id);
        
        /// <summary>
        /// Realiza a gera\u00E7\u00E3o de um cart\u00E3o virtual
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja gerado um Cart\u00E3o virtual para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id). Esta funcionalidade poder\u00E1 ser utilizada para realizar a cria\u00E7\u00E3o de cart\u00F5es virtuaes atraves de um app
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="dataValidade">Data de Validade</param>
        /// <returns>CartaoImpressaoResponse</returns>
        CartaoImpressaoResponse GerarCartaoVirtual (long? id, string dataValidade);
  
        /// <summary>
        /// Realiza a gera\u00E7\u00E3o de um cart\u00E3o virtual
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja gerado um Cart\u00E3o virtual para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id). Esta funcionalidade poder\u00E1 ser utilizada para realizar a cria\u00E7\u00E3o de cart\u00F5es virtuaes atraves de um app
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="dataValidade">Data de Validade</param>
        /// <returns>ApiResponse of CartaoImpressaoResponse</returns>
        ApiResponse<CartaoImpressaoResponse> GerarCartaoVirtualWithHttpInfo (long? id, string dataValidade);
        
        /// <summary>
        /// Lista contas existentes na base de dados do Emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar contas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto ao qual a conta faz parte. (id) (optional)</param>
        /// <param name="idOrigemComercial">C\u00F3digo de Identifica\u00E7\u00E3o da Origem Comercial (id) que deu origem a Conta (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa Titular da Conta (id) (optional)</param>
        /// <param name="idStatusConta">C\u00F3digo de Identifica\u00E7\u00E3o do status da conta (optional)</param>
        /// <param name="diaVencimento">Apresenta o dia de vencimento (optional)</param>
        /// <param name="melhorDiaCompra">Apresenta o melhor dia de compra (optional)</param>
        /// <param name="dataStatusConta">Apresenta a data em que o idStatusConta atual fora atribu\u00EDdo para ela (optional)</param>
        /// <param name="dataCadastro">Apresenta a data em que o cart\u00E3o foi gerado (optional)</param>
        /// <param name="dataUltimaAlteracaoVencimento">Apresenta a data da ultima altera\u00E7\u00E3o de vencimento (optional)</param>
        /// <param name="funcaoAtiva"> (optional)</param>
        /// <returns>PageContaResponse</returns>
        PageContaResponse Listar (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, string dataStatusConta = null, string dataCadastro = null, string dataUltimaAlteracaoVencimento = null, string funcaoAtiva = null);
  
        /// <summary>
        /// Lista contas existentes na base de dados do Emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar contas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto ao qual a conta faz parte. (id) (optional)</param>
        /// <param name="idOrigemComercial">C\u00F3digo de Identifica\u00E7\u00E3o da Origem Comercial (id) que deu origem a Conta (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa Titular da Conta (id) (optional)</param>
        /// <param name="idStatusConta">C\u00F3digo de Identifica\u00E7\u00E3o do status da conta (optional)</param>
        /// <param name="diaVencimento">Apresenta o dia de vencimento (optional)</param>
        /// <param name="melhorDiaCompra">Apresenta o melhor dia de compra (optional)</param>
        /// <param name="dataStatusConta">Apresenta a data em que o idStatusConta atual fora atribu\u00EDdo para ela (optional)</param>
        /// <param name="dataCadastro">Apresenta a data em que o cart\u00E3o foi gerado (optional)</param>
        /// <param name="dataUltimaAlteracaoVencimento">Apresenta a data da ultima altera\u00E7\u00E3o de vencimento (optional)</param>
        /// <param name="funcaoAtiva"> (optional)</param>
        /// <returns>ApiResponse of PageContaResponse</returns>
        ApiResponse<PageContaResponse> ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, string dataStatusConta = null, string dataCadastro = null, string dataUltimaAlteracaoVencimento = null, string funcaoAtiva = null);
        
        /// <summary>
        /// Lista o hist\u00F3rico de altera\u00E7\u00F5es de limites da conta
        /// </summary>
        /// <remarks>
        /// Este recurso consulta o hist\u00F3rico com as altera\u00E7\u00F5es de limites da conta informada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageHistoricoEventosResponse</returns>
        PageHistoricoEventosResponse ListarHistoricoAlteracoesLimites (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista o hist\u00F3rico de altera\u00E7\u00F5es de limites da conta
        /// </summary>
        /// <remarks>
        /// Este recurso consulta o hist\u00F3rico com as altera\u00E7\u00F5es de limites da conta informada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageHistoricoEventosResponse</returns>
        ApiResponse<PageHistoricoEventosResponse> ListarHistoricoAlteracoesLimitesWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista o hist\u00F3rico de entradas/sa\u00EDdas de assessorias de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Permite listar todos os registros de entrada e sa\u00EDda da Conta em arquivos de integra\u00E7\u00E3o com empresas de assessorias de cobran\u00E7a a partir do c\u00F3digo de identifica\u00E7\u00E3o da conta (idConta)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageHistoricoAssessoriaResponse</returns>
        PageHistoricoAssessoriaResponse ListarHistoricoAssessoria (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista o hist\u00F3rico de entradas/sa\u00EDdas de assessorias de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Permite listar todos os registros de entrada e sa\u00EDda da Conta em arquivos de integra\u00E7\u00E3o com empresas de assessorias de cobran\u00E7a a partir do c\u00F3digo de identifica\u00E7\u00E3o da conta (idConta)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageHistoricoAssessoriaResponse</returns>
        ApiResponse<PageHistoricoAssessoriaResponse> ListarHistoricoAssessoriaWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista o historico de atrasos das faturas
        /// </summary>
        /// <remarks>
        /// Este recurso lista o hist\u00F3rico do pagamento de faturas em atraso
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageHistoricoAtrasoFaturaResponse</returns>
        PageHistoricoAtrasoFaturaResponse ListarHistoricoAtrasosFaturas (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista o historico de atrasos das faturas
        /// </summary>
        /// <remarks>
        /// Este recurso lista o hist\u00F3rico do pagamento de faturas em atraso
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageHistoricoAtrasoFaturaResponse</returns>
        ApiResponse<PageHistoricoAtrasoFaturaResponse> ListarHistoricoAtrasosFaturasWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista as transa\u00E7\u00F5es n\u00E3o processadas da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas todas as transa\u00E7\u00F5es n\u00E3o processadas da Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataInicio">Data de in\u00EDcio da consulta do extrato no formato yyyy-MM-dd (Par\u00E2mentro Ignorado se dataFim n\u00E3o for definida) (optional)</param>
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Par\u00E2mentro Ignorado se dataInicio n\u00E3o for definida) (optional)</param>
        /// <returns>PageTransacaoNaoProcessadaResponse</returns>
        PageTransacaoNaoProcessadaResponse ListarNaoProcessadas (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null);
  
        /// <summary>
        /// Lista as transa\u00E7\u00F5es n\u00E3o processadas da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas todas as transa\u00E7\u00F5es n\u00E3o processadas da Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataInicio">Data de in\u00EDcio da consulta do extrato no formato yyyy-MM-dd (Par\u00E2mentro Ignorado se dataFim n\u00E3o for definida) (optional)</param>
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Par\u00E2mentro Ignorado se dataInicio n\u00E3o for definida) (optional)</param>
        /// <returns>ApiResponse of PageTransacaoNaoProcessadaResponse</returns>
        ApiResponse<PageTransacaoNaoProcessadaResponse> ListarNaoProcessadasWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null);
        
        /// <summary>
        /// Lista as transa\u00E7\u00F5es processadas da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas todas as transa\u00E7\u00F5es processadas da Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Data de vencimento do extrato no formato yyyy-MM-dd (optional)</param>
        /// <param name="dataInicio">Data de in\u00EDcio da consulta do extrato no formato yyyy-MM-dd (Ignorado quando o par\u00E2mentro dataVencimento \u00E9 usado) (optional)</param>
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Ignorado quando o par\u00E2mentro dataVencimento \u00E9 usado) (optional)</param>
        /// <param name="idTipoTransacao">transacoes_processadas_request_tipo_transacao (optional)</param>
        /// <param name="recuperaEncargos">Adiciona as transa\u00E7\u00F5es de encargos na consulta (optional)</param>
        /// <returns>PageTransacoesCorrentesResponse</returns>
        PageTransacoesCorrentesResponse ListarProcessadas (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, int? recuperaEncargos = null);
  
        /// <summary>
        /// Lista as transa\u00E7\u00F5es processadas da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas todas as transa\u00E7\u00F5es processadas da Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Data de vencimento do extrato no formato yyyy-MM-dd (optional)</param>
        /// <param name="dataInicio">Data de in\u00EDcio da consulta do extrato no formato yyyy-MM-dd (Ignorado quando o par\u00E2mentro dataVencimento \u00E9 usado) (optional)</param>
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Ignorado quando o par\u00E2mentro dataVencimento \u00E9 usado) (optional)</param>
        /// <param name="idTipoTransacao">transacoes_processadas_request_tipo_transacao (optional)</param>
        /// <param name="recuperaEncargos">Adiciona as transa\u00E7\u00F5es de encargos na consulta (optional)</param>
        /// <returns>ApiResponse of PageTransacoesCorrentesResponse</returns>
        ApiResponse<PageTransacoesCorrentesResponse> ListarProcessadasWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, int? recuperaEncargos = null);
        
        /// <summary>
        /// Lista os tipos de fun\u00E7\u00F5es para contas do Emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os tipos de fun\u00E7\u00F5es para as contas do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>string</returns>
        string Listar_0 ();
  
        /// <summary>
        /// Lista os tipos de fun\u00E7\u00F5es para contas do Emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os tipos de fun\u00E7\u00F5es para as contas do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> Listar_0WithHttpInfo ();
        
        /// <summary>
        /// Lista as transa\u00E7\u00F5es n\u00E3o processadas e processadas da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas todas as transa\u00E7\u00F5es n\u00E3o processadas e processadas da Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Data de vencimento do extrato no formato yyyy-MM-dd (optional)</param>
        /// <param name="dataInicio">Data de in\u00EDcio da consulta do extrato no formato yyyy-MM-dd (Ignorado quando o par\u00E2mentro dataVencimento \u00E9 usado) (optional)</param>
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Ignorado quando o par\u00E2mentro dataVencimento \u00E9 usado) (optional)</param>
        /// <param name="idTipoTransacao">transacoes_processadas_request_tipo_transacao (optional)</param>
        /// <param name="flagCredito">Flag que indica se a transa\u00E7\u00E3o \u00E9 cr\u00E9dito (optional)</param>
        /// <param name="flagFaturado">Flag que indica se a transa\u00E7\u00E3o foi faturada (optional)</param>
        /// <param name="flagProcessada">Flag que indica se a transa\u00E7\u00E3o foi processada (optional)</param>
        /// <param name="status">Status da transa\u00E7\u00E3o (optional)</param>
        /// <param name="plano">Plano da transa\u00E7\u00E3o (optional)</param>
        /// <param name="codigoMCC">C\u00F3digo MCC da transa\u00E7\u00E3o (optional)</param>
        /// <param name="grupoMCC">Grupo MCC da transa\u00E7\u00E3o (optional)</param>
        /// <returns>PageTransacaoProcessadaNaoProcessadaResponse</returns>
        PageTransacaoProcessadaNaoProcessadaResponse Listar_1 (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, bool? flagCredito = null, bool? flagFaturado = null, bool? flagProcessada = null, int? status = null, int? plano = null, long? codigoMCC = null, long? grupoMCC = null);
  
        /// <summary>
        /// Lista as transa\u00E7\u00F5es n\u00E3o processadas e processadas da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas todas as transa\u00E7\u00F5es n\u00E3o processadas e processadas da Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Data de vencimento do extrato no formato yyyy-MM-dd (optional)</param>
        /// <param name="dataInicio">Data de in\u00EDcio da consulta do extrato no formato yyyy-MM-dd (Ignorado quando o par\u00E2mentro dataVencimento \u00E9 usado) (optional)</param>
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Ignorado quando o par\u00E2mentro dataVencimento \u00E9 usado) (optional)</param>
        /// <param name="idTipoTransacao">transacoes_processadas_request_tipo_transacao (optional)</param>
        /// <param name="flagCredito">Flag que indica se a transa\u00E7\u00E3o \u00E9 cr\u00E9dito (optional)</param>
        /// <param name="flagFaturado">Flag que indica se a transa\u00E7\u00E3o foi faturada (optional)</param>
        /// <param name="flagProcessada">Flag que indica se a transa\u00E7\u00E3o foi processada (optional)</param>
        /// <param name="status">Status da transa\u00E7\u00E3o (optional)</param>
        /// <param name="plano">Plano da transa\u00E7\u00E3o (optional)</param>
        /// <param name="codigoMCC">C\u00F3digo MCC da transa\u00E7\u00E3o (optional)</param>
        /// <param name="grupoMCC">Grupo MCC da transa\u00E7\u00E3o (optional)</param>
        /// <returns>ApiResponse of PageTransacaoProcessadaNaoProcessadaResponse</returns>
        ApiResponse<PageTransacaoProcessadaNaoProcessadaResponse> Listar_1WithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, bool? flagCredito = null, bool? flagFaturado = null, bool? flagProcessada = null, int? status = null, int? plano = null, long? codigoMCC = null, long? grupoMCC = null);
        
        /// <summary>
        /// Lista as transfer\u00EAncias realizadas pela conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as transfer\u00EAncias realizadas pela conta existentes na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTransferencia">C\u00F3digo de identifica\u00E7\u00E3o da transfer\u00EAncia (id) (optional)</param>
        /// <param name="idContaOrigem">C\u00F3digo de identifica\u00E7\u00E3o da conta em que o valor ser\u00E1 debitado para a transfer\u00EAncia. (id) (optional)</param>
        /// <param name="idContaDestino">C\u00F3digo de identifica\u00E7\u00E3o da conta em que o valor ser\u00E1 creditado para a transfer\u00EAncia. (id) (optional)</param>
        /// <param name="valorTransferencia">Valor estabelecido para ser transferido (optional)</param>
        /// <param name="dataTransferencia">Data estabelecida para ocorrer a transfer\u00EAncia (optional)</param>
        /// <returns>PageTransferenciaResponse</returns>
        PageTransferenciaResponse Listar_2 (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, string dataTransferencia = null);
  
        /// <summary>
        /// Lista as transfer\u00EAncias realizadas pela conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as transfer\u00EAncias realizadas pela conta existentes na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTransferencia">C\u00F3digo de identifica\u00E7\u00E3o da transfer\u00EAncia (id) (optional)</param>
        /// <param name="idContaOrigem">C\u00F3digo de identifica\u00E7\u00E3o da conta em que o valor ser\u00E1 debitado para a transfer\u00EAncia. (id) (optional)</param>
        /// <param name="idContaDestino">C\u00F3digo de identifica\u00E7\u00E3o da conta em que o valor ser\u00E1 creditado para a transfer\u00EAncia. (id) (optional)</param>
        /// <param name="valorTransferencia">Valor estabelecido para ser transferido (optional)</param>
        /// <param name="dataTransferencia">Data estabelecida para ocorrer a transfer\u00EAncia (optional)</param>
        /// <returns>ApiResponse of PageTransferenciaResponse</returns>
        ApiResponse<PageTransferenciaResponse> Listar_2WithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, string dataTransferencia = null);
        
        /// <summary>
        /// Realiza a reativa\u00E7\u00E3o de contas
        /// </summary>
        /// <remarks>
        /// Este recurso permite reativar contas. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Object</returns>
        Object Reativar (long? id);
  
        /// <summary>
        /// Realiza a reativa\u00E7\u00E3o de contas
        /// </summary>
        /// <remarks>
        /// Este recurso permite reativar contas. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ReativarWithHttpInfo (long? id);
        
        /// <summary>
        /// Realiza o cadastro de uma nova conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar uma nova conta para uma pessoa j\u00E1 existente na base de dados do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaPersist">contaPersist</param>
        /// <returns>ContaResponse</returns>
        ContaResponse Salvar (ContaPersist contaPersist);
  
        /// <summary>
        /// Realiza o cadastro de uma nova conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar uma nova conta para uma pessoa j\u00E1 existente na base de dados do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaPersist">contaPersist</param>
        /// <returns>ApiResponse of ContaResponse</returns>
        ApiResponse<ContaResponse> SalvarWithHttpInfo (ContaPersist contaPersist);
        
        /// <summary>
        /// Realiza um cadastro de uma nova ades\u00E3o do servi\u00E7o
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar uma nova ades\u00E3o de servi\u00E7o na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="adesaoServicoPersist">adesaoServicoPersist</param>
        /// <returns>AdesaoServicoResponse</returns>
        AdesaoServicoResponse SalvarAdesaoServicos (long? id, AdesaoServicoPersist adesaoServicoPersist);
  
        /// <summary>
        /// Realiza um cadastro de uma nova ades\u00E3o do servi\u00E7o
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar uma nova ades\u00E3o de servi\u00E7o na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="adesaoServicoPersist">adesaoServicoPersist</param>
        /// <returns>ApiResponse of AdesaoServicoResponse</returns>
        ApiResponse<AdesaoServicoResponse> SalvarAdesaoServicosWithHttpInfo (long? id, AdesaoServicoPersist adesaoServicoPersist);
        
        /// <summary>
        /// Simula valores de presta\u00E7\u00F5es de empr\u00E9stimos/financiamentos
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o pode ser utilizada para simular opera\u00E7\u00F5es financeiras a partir de informa\u00E7\u00F5es fornecidas pelo usu\u00E1rio. Os c\u00E1lculos gerados devem ser considerados apenas como refer\u00EAncia para as situa\u00E7\u00F5es reais e n\u00E3o como valores oficiais
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="request">request</param>
        /// <returns>EmprestimoPessoalResponse</returns>
        EmprestimoPessoalResponse SimularEmprestimoFinanciamento (long? id, EmprestimoPessoalRequest request);
  
        /// <summary>
        /// Simula valores de presta\u00E7\u00F5es de empr\u00E9stimos/financiamentos
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o pode ser utilizada para simular opera\u00E7\u00F5es financeiras a partir de informa\u00E7\u00F5es fornecidas pelo usu\u00E1rio. Os c\u00E1lculos gerados devem ser considerados apenas como refer\u00EAncia para as situa\u00E7\u00F5es reais e n\u00E3o como valores oficiais
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of EmprestimoPessoalResponse</returns>
        ApiResponse<EmprestimoPessoalResponse> SimularEmprestimoFinanciamentoWithHttpInfo (long? id, EmprestimoPessoalRequest request);
        
        /// <summary>
        /// Permite listar uma linha do tempo com os eventos da conta
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir a listagem, em formato de timeline, dos eventos vinculados a uma detemrinada conta. Transa\u00E7\u00F5es, fechamento da fatura, pagamentos, gera\u00E7\u00E3o de cart\u00F5es e altera\u00E7\u00E3o de limite s\u00E3o exemplos de eventos contemplados por esta funcionalidade. Neste m\u00E9todo, as opera\u00E7\u00F5es s\u00E3o ordenadas de forma decrescente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageTransacaoResponse</returns>
        PageTransacaoResponse Transacoes (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Permite listar uma linha do tempo com os eventos da conta
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir a listagem, em formato de timeline, dos eventos vinculados a uma detemrinada conta. Transa\u00E7\u00F5es, fechamento da fatura, pagamentos, gera\u00E7\u00E3o de cart\u00F5es e altera\u00E7\u00E3o de limite s\u00E3o exemplos de eventos contemplados por esta funcionalidade. Neste m\u00E9todo, as opera\u00E7\u00F5es s\u00E3o ordenadas de forma decrescente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageTransacaoResponse</returns>
        ApiResponse<PageTransacaoResponse> TransacoesWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Realiza uma transfer\u00EAncia de Cr\u00E9dito para outro cliente do mesmo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que um portador de um cart\u00E3o possa realizar auma transfer\u00EAncia de cr\u00E9dito para outro cliente do mesmo emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta do cliente portador do cart\u00E3o que ser\u00E1 debitado (id)</param>
        /// <param name="idContaDestino">C\u00F3digo de Identifica\u00E7\u00E3o do cliente portador do cart\u00E3o que ser\u00E1 creditado (id)</param>
        /// <param name="valorTransferencia">Valor da Transfer\u00EAncia</param>
        /// <returns>TransferenciaDetalheResponse</returns>
        TransferenciaDetalheResponse Transferir (long? id, long? idContaDestino, double? valorTransferencia);
  
        /// <summary>
        /// Realiza uma transfer\u00EAncia de Cr\u00E9dito para outro cliente do mesmo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que um portador de um cart\u00E3o possa realizar auma transfer\u00EAncia de cr\u00E9dito para outro cliente do mesmo emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta do cliente portador do cart\u00E3o que ser\u00E1 debitado (id)</param>
        /// <param name="idContaDestino">C\u00F3digo de Identifica\u00E7\u00E3o do cliente portador do cart\u00E3o que ser\u00E1 creditado (id)</param>
        /// <param name="valorTransferencia">Valor da Transfer\u00EAncia</param>
        /// <returns>ApiResponse of TransferenciaDetalheResponse</returns>
        ApiResponse<TransferenciaDetalheResponse> TransferirWithHttpInfo (long? id, long? idContaDestino, double? valorTransferencia);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Lan\u00E7a um ajuste para a conta do id informado
        /// </summary>
        /// <remarks>
        /// Este recurso insere um ajuste para a conta do id informado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idTipoAjuste">C\u00F3digo identificador do tipo de ajuste</param>
        /// <param name="dataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</param>
        /// <param name="valorAjuste">Valor do ajuste</param>
        /// <param name="login">login (optional)</param>
        /// <param name="identificadorExterno">Identificador Externo (optional)</param>
        /// <param name="idTransacaoOriginal">Identificador da transa\u00E7\u00E3o original (estorno) (optional)</param>
        /// <param name="idEstabelecimento">Identificador do estabelecimento quando o pagamento for efetuado em loja (optional)</param>
        /// <returns>Task of AjusteFinanceiroResponse</returns>
        System.Threading.Tasks.Task<AjusteFinanceiroResponse> AjustarContaAsync (long? id, long? idTipoAjuste, string dataAjuste, double? valorAjuste, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null, long? idEstabelecimento = null);

        /// <summary>
        /// Lan\u00E7a um ajuste para a conta do id informado
        /// </summary>
        /// <remarks>
        /// Este recurso insere um ajuste para a conta do id informado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idTipoAjuste">C\u00F3digo identificador do tipo de ajuste</param>
        /// <param name="dataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</param>
        /// <param name="valorAjuste">Valor do ajuste</param>
        /// <param name="login">login (optional)</param>
        /// <param name="identificadorExterno">Identificador Externo (optional)</param>
        /// <param name="idTransacaoOriginal">Identificador da transa\u00E7\u00E3o original (estorno) (optional)</param>
        /// <param name="idEstabelecimento">Identificador do estabelecimento quando o pagamento for efetuado em loja (optional)</param>
        /// <returns>Task of ApiResponse (AjusteFinanceiroResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AjusteFinanceiroResponse>> AjustarContaAsyncWithHttpInfo (long? id, long? idTipoAjuste, string dataAjuste, double? valorAjuste, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null, long? idEstabelecimento = null);
        
        /// <summary>
        /// Altera o produto associado \u00E0 conta
        /// </summary>
        /// <remarks>
        /// O recurso permite fazer modifica\u00E7\u00E3o do produto associado \u00E0 conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="request">request</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> AlterarProdutoAsync (long? id, AlterarProdutoRequest request);

        /// <summary>
        /// Altera o produto associado \u00E0 conta
        /// </summary>
        /// <remarks>
        /// O recurso permite fazer modifica\u00E7\u00E3o do produto associado \u00E0 conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> AlterarProdutoAsyncWithHttpInfo (long? id, AlterarProdutoRequest request);
        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o de uma Pessoa tilular da conta
        /// </summary>
        /// <remarks>
        /// Esta m\u00E9todo permite altera a pessoa de uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de identifica\u00E7\u00E3o de uma Pessoa (id)</param>
        /// <returns>Task of ContaResponse</returns>
        System.Threading.Tasks.Task<ContaResponse> AlterarTitularAsync (long? id, long? idPessoa);

        /// <summary>
        /// Realiza a altera\u00E7\u00E3o de uma Pessoa tilular da conta
        /// </summary>
        /// <remarks>
        /// Esta m\u00E9todo permite altera a pessoa de uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de identifica\u00E7\u00E3o de uma Pessoa (id)</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaResponse>> AlterarTitularAsyncWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o do dia de vencimento das faturas da conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite alterar o vencimento para no m\u00E1ximo at\u00E9 30 dias ap\u00F3s data atual de uma conta especifica no PIER, respeitando o par\u00E2metro de intervalor entre as modifica\u00E7\u00F5es do vencimento informado pelo emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="novoDiaVencimento">Novo dia de vencimento</param>
        /// <returns>Task of ContaResponse</returns>
        System.Threading.Tasks.Task<ContaResponse> AlterarVencimentoAsync (long? id, int? novoDiaVencimento);

        /// <summary>
        /// Realiza a altera\u00E7\u00E3o do dia de vencimento das faturas da conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite alterar o vencimento para no m\u00E1ximo at\u00E9 30 dias ap\u00F3s data atual de uma conta especifica no PIER, respeitando o par\u00E2metro de intervalor entre as modifica\u00E7\u00F5es do vencimento informado pelo emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="novoDiaVencimento">Novo dia de vencimento</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaResponse>> AlterarVencimentoAsyncWithHttpInfo (long? id, int? novoDiaVencimento);
        
        /// <summary>
        /// Atribuir Anuidade
        /// </summary>
        /// <remarks>
        /// Esse recurso permite configurar qual a regra de Anuidade que ser\u00E1 atribu\u00EDda a uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idAnuidade">Identificador da anuidade</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="DDD">DDD do celular (optional)</param>
        /// <param name="celular">N\u00FAmero do celular (optional)</param>
        /// <param name="idOperadora">Identificador da operadora do celular (optional)</param>
        /// <param name="idOrigemComercial">Identificador da origem comercial (optional)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> AtivarAnuidadeAsync (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null);

        /// <summary>
        /// Atribuir Anuidade
        /// </summary>
        /// <remarks>
        /// Esse recurso permite configurar qual a regra de Anuidade que ser\u00E1 atribu\u00EDda a uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idAnuidade">Identificador da anuidade</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="DDD">DDD do celular (optional)</param>
        /// <param name="celular">N\u00FAmero do celular (optional)</param>
        /// <param name="idOperadora">Identificador da operadora do celular (optional)</param>
        /// <param name="idOrigemComercial">Identificador da origem comercial (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AtivarAnuidadeAsyncWithHttpInfo (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null);
        
        /// <summary>
        /// Ativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <remarks>
        /// Este recurso ativa o servi\u00E7o de envio de fatura por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> AtivarEnvioFaturaEmailAsync (long? id);

        /// <summary>
        /// Ativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <remarks>
        /// Este recurso ativa o servi\u00E7o de envio de fatura por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AtivarEnvioFaturaEmailAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Realiza a atualiza\u00E7\u00E3o parcial da conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite realizar a atualiza\u00E7\u00E3o parcial da conta. Isso indica dizer que apenas os campos informados na requisi\u00E7\u00E3o ser\u00E3o atualizados, sendo ignorados os demais
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="contaPartialUpdate">contaPartialUpdate</param>
        /// <returns>Task of ContaResponse</returns>
        System.Threading.Tasks.Task<ContaResponse> AtualizarParcialAsync (long? id, ContaPartialUpdate contaPartialUpdate);

        /// <summary>
        /// Realiza a atualiza\u00E7\u00E3o parcial da conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite realizar a atualiza\u00E7\u00E3o parcial da conta. Isso indica dizer que apenas os campos informados na requisi\u00E7\u00E3o ser\u00E3o atualizados, sendo ignorados os demais
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="contaPartialUpdate">contaPartialUpdate</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaResponse>> AtualizarParcialAsyncWithHttpInfo (long? id, ContaPartialUpdate contaPartialUpdate);
        
        /// <summary>
        /// Realiza o bloqueio de uma determinada Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite a realiza\u00E7\u00E3o do bloqueio de uma determinada conta a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Novo Status Conta</param>
        /// <returns>Task of ContaResponse</returns>
        System.Threading.Tasks.Task<ContaResponse> BloquearAsync (long? id, long? idStatus);

        /// <summary>
        /// Realiza o bloqueio de uma determinada Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite a realiza\u00E7\u00E3o do bloqueio de uma determinada conta a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Novo Status Conta</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaResponse>> BloquearAsyncWithHttpInfo (long? id, long? idStatus);
        
        /// <summary>
        /// Cadastro ades\u00E3o de pagamento no s\u00E1bado
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar uma ades\u00E3o de pagamento no s\u00E1bado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id da conta</param>
        /// <returns>Task of AdesaoPagamentoSabadoResponse</returns>
        System.Threading.Tasks.Task<AdesaoPagamentoSabadoResponse> CadastrarAsync (long? id);

        /// <summary>
        /// Cadastro ades\u00E3o de pagamento no s\u00E1bado
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar uma ades\u00E3o de pagamento no s\u00E1bado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id da conta</param>
        /// <returns>Task of ApiResponse (AdesaoPagamentoSabadoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdesaoPagamentoSabadoResponse>> CadastrarAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Realiza o cancelamento de uma determinada Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite a realiza\u00E7\u00E3o do cancelamento de uma determinada conta a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Novo Status Conta</param>
        /// <returns>Task of ContaResponse</returns>
        System.Threading.Tasks.Task<ContaResponse> CancelarAsync (long? id, long? idStatus);

        /// <summary>
        /// Realiza o cancelamento de uma determinada Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite a realiza\u00E7\u00E3o do cancelamento de uma determinada conta a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Novo Status Conta</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaResponse>> CancelarAsyncWithHttpInfo (long? id, long? idStatus);
        
        /// <summary>
        /// Consulta ades\u00E3o de pagamento no s\u00E1bado
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar uma ades\u00E3o de pagamento no s\u00E1bado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id da conta</param>
        /// <param name="dataVencimento">Data de vencimento da ades\u00E3o</param>
        /// <returns>Task of AdesaoPagamentoSabadoResponse</returns>
        System.Threading.Tasks.Task<AdesaoPagamentoSabadoResponse> ConsultarAsync (long? id, string dataVencimento);

        /// <summary>
        /// Consulta ades\u00E3o de pagamento no s\u00E1bado
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar uma ades\u00E3o de pagamento no s\u00E1bado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id da conta</param>
        /// <param name="dataVencimento">Data de vencimento da ades\u00E3o</param>
        /// <returns>Task of ApiResponse (AdesaoPagamentoSabadoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdesaoPagamentoSabadoResponse>> ConsultarAsyncWithHttpInfo (long? id, string dataVencimento);
        
        /// <summary>
        /// Apresenta a data m\u00E1xima para pagamento da fatura em atraso para receber o benef\u00EDcio
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar se o cliente tem direito ao benef\u00EDcio de pagamento em atraso, em loja, at\u00E9 o s\u00E1bado subsequente ao vencimento, ficando isento do pagamento de multa, encargos, mora e IOF
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of BeneficioPagamentoAtrasoResponse</returns>
        System.Threading.Tasks.Task<BeneficioPagamentoAtrasoResponse> ConsultarBeneficioPagamentoAtrasoAsync (long? id);

        /// <summary>
        /// Apresenta a data m\u00E1xima para pagamento da fatura em atraso para receber o benef\u00EDcio
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar se o cliente tem direito ao benef\u00EDcio de pagamento em atraso, em loja, at\u00E9 o s\u00E1bado subsequente ao vencimento, ficando isento do pagamento de multa, encargos, mora e IOF
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of ApiResponse (BeneficioPagamentoAtrasoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BeneficioPagamentoAtrasoResponse>> ConsultarBeneficioPagamentoAtrasoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta os dados de um determinado boleto da fatura
        /// </summary>
        /// <remarks>
        /// Este recurso consulta um boleto da fatura
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Task of BoletoResponse</returns>
        System.Threading.Tasks.Task<BoletoResponse> ConsultarBoletoEmitidoAsync (long? id);

        /// <summary>
        /// Consulta os dados de um determinado boleto da fatura
        /// </summary>
        /// <remarks>
        /// Este recurso consulta um boleto da fatura
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Task of ApiResponse (BoletoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BoletoResponse>> ConsultarBoletoEmitidoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta a d\u00EDvida atualizada do cliente
        /// </summary>
        /// <remarks>
        /// Este recurso consulta a d\u00EDvida atualizada do cliente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Data do vencimento (optional)</param>
        /// <param name="idEscritorioCobranca">C\u00F3digo de identifica\u00E7\u00E3o do escrit\u00F3rio de cobran\u00E7a (optional)</param>
        /// <returns>Task of DividaClienteResponse</returns>
        System.Threading.Tasks.Task<DividaClienteResponse> ConsultarDividaAtualizadaClienteAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, long? idEscritorioCobranca = null);

        /// <summary>
        /// Consulta a d\u00EDvida atualizada do cliente
        /// </summary>
        /// <remarks>
        /// Este recurso consulta a d\u00EDvida atualizada do cliente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Data do vencimento (optional)</param>
        /// <param name="idEscritorioCobranca">C\u00F3digo de identifica\u00E7\u00E3o do escrit\u00F3rio de cobran\u00E7a (optional)</param>
        /// <returns>Task of ApiResponse (DividaClienteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DividaClienteResponse>> ConsultarDividaAtualizadaClienteAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, long? idEscritorioCobranca = null);
        
        /// <summary>
        /// Consulta uma transa\u00E7\u00E3o processada da conta.
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar os detalhes de uma transa\u00E7\u00E3o processada pertencente a uma conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="idTransacao">C\u00F3digo de Identifica\u00E7\u00E3o da transa\u00E7\u00E3o (id).</param>
        /// <returns>Task of TransacoesCorrentesResponse</returns>
        System.Threading.Tasks.Task<TransacoesCorrentesResponse> ConsultarProcessadaAsync (long? id, long? idTransacao);

        /// <summary>
        /// Consulta uma transa\u00E7\u00E3o processada da conta.
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar os detalhes de uma transa\u00E7\u00E3o processada pertencente a uma conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="idTransacao">C\u00F3digo de Identifica\u00E7\u00E3o da transa\u00E7\u00E3o (id).</param>
        /// <returns>Task of ApiResponse (TransacoesCorrentesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransacoesCorrentesResponse>> ConsultarProcessadaAsyncWithHttpInfo (long? id, long? idTransacao);
        
        /// <summary>
        /// Permite consultar a partir do ID da conta as taxas e tarifas
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores consultem as taxas e tarifas da conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da conta a ser consultada</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageTaxasRefinanciamentoResponse</returns>
        System.Threading.Tasks.Task<PageTaxasRefinanciamentoResponse> ConsultarTaxasTarifasAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Permite consultar a partir do ID da conta as taxas e tarifas
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores consultem as taxas e tarifas da conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da conta a ser consultada</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTaxasRefinanciamentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTaxasRefinanciamentoResponse>> ConsultarTaxasTarifasAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Apresenta dados de um determinado tipo de fun\u00E7\u00E3o para contas
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar dados de um determinado tipo de fun\u00E7\u00E3o para contas a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo de fun\u00E7\u00E3o para contas (id)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> Consultar_0Async (int? id);

        /// <summary>
        /// Apresenta dados de um determinado tipo de fun\u00E7\u00E3o para contas
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar dados de um determinado tipo de fun\u00E7\u00E3o para contas a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo de fun\u00E7\u00E3o para contas (id)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> Consultar_0AsyncWithHttpInfo (int? id);
        
        /// <summary>
        /// Apresenta dados de uma determinada conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar dados de uma determinada conta a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of ContaDetalheResponse</returns>
        System.Threading.Tasks.Task<ContaDetalheResponse> Consultar_1Async (long? id);

        /// <summary>
        /// Apresenta dados de uma determinada conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar dados de uma determinada conta a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of ApiResponse (ContaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaDetalheResponse>> Consultar_1AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta os detalhes de uma determinada transfer\u00EAncia
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os detalhes de uma determinada transfer\u00EAncia de cr\u00E9dito realizada entre contas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idTransferencia">C\u00F3digo de Identifica\u00E7\u00E3o da transfer\u00EAncia (id_transferencia)</param>
        /// <returns>Task of TransferenciaDetalheResponse</returns>
        System.Threading.Tasks.Task<TransferenciaDetalheResponse> Consultar_2Async (long? id, long? idTransferencia);

        /// <summary>
        /// Consulta os detalhes de uma determinada transfer\u00EAncia
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os detalhes de uma determinada transfer\u00EAncia de cr\u00E9dito realizada entre contas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idTransferencia">C\u00F3digo de Identifica\u00E7\u00E3o da transfer\u00EAncia (id_transferencia)</param>
        /// <returns>Task of ApiResponse (TransferenciaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransferenciaDetalheResponse>> Consultar_2AsyncWithHttpInfo (long? id, long? idTransferencia);
        
        /// <summary>
        /// Cadastrar contas MultiApp
        /// </summary>
        /// <remarks>
        /// Este recurso permite o cadastro de contas MultiApp
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaMultiAppPersist">contaMultiAppPersist</param>
        /// <returns>Task of ContaMultiAppResponse</returns>
        System.Threading.Tasks.Task<ContaMultiAppResponse> CriarContasMultiAppAsync (ContaMultiAppPersist contaMultiAppPersist);

        /// <summary>
        /// Cadastrar contas MultiApp
        /// </summary>
        /// <remarks>
        /// Este recurso permite o cadastro de contas MultiApp
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaMultiAppPersist">contaMultiAppPersist</param>
        /// <returns>Task of ApiResponse (ContaMultiAppResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaMultiAppResponse>> CriarContasMultiAppAsyncWithHttpInfo (ContaMultiAppPersist contaMultiAppPersist);
        
        /// <summary>
        /// Desativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <remarks>
        /// Este recurso desativa o servi\u00E7o de envio de fatura por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> DesativarEnvioFaturaEmailAsync (long? id);

        /// <summary>
        /// Desativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <remarks>
        /// Este recurso desativa o servi\u00E7o de envio de fatura por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DesativarEnvioFaturaEmailAsyncWithHttpInfo (long? id);
        
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
        System.Threading.Tasks.Task<BoletoResponse> GerarBoletoRecargaAsync (long? id, double? valor, string dataVencimento);

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
        System.Threading.Tasks.Task<ApiResponse<BoletoResponse>> GerarBoletoRecargaAsyncWithHttpInfo (long? id, double? valor, string dataVencimento);
        
        /// <summary>
        /// Realiza a gera\u00E7\u00E3o de um novo cart\u00E3o para impress\u00E3o avulsa
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja gerado um novo Cart\u00E3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00E3o que dever\u00E1 ser gerado para impress\u00E3o. Esta funcionalidade poder\u00E1 ser utilizada para realizar a impress\u00E3o de cart\u00F5es em Lojas, Quiosques, Escrit\u00F3rios, Terminais de Auto Atendimento, ou outro local que o Emissor escolher, desde que se possua uma impressora de Cart\u00F5es habilidade para o fazer, no local
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <param name="idTipoPlastico">C\u00F3digo de identifica\u00E7\u00E3o do TipoPlastico (id) (optional)</param>
        /// <returns>Task of CartaoImpressaoResponse</returns>
        System.Threading.Tasks.Task<CartaoImpressaoResponse> GerarCartaoAsync (long? id, long? idPessoa, long? idTipoPlastico = null);

        /// <summary>
        /// Realiza a gera\u00E7\u00E3o de um novo cart\u00E3o para impress\u00E3o avulsa
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja gerado um novo Cart\u00E3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00E3o que dever\u00E1 ser gerado para impress\u00E3o. Esta funcionalidade poder\u00E1 ser utilizada para realizar a impress\u00E3o de cart\u00F5es em Lojas, Quiosques, Escrit\u00F3rios, Terminais de Auto Atendimento, ou outro local que o Emissor escolher, desde que se possua uma impressora de Cart\u00F5es habilidade para o fazer, no local
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <param name="idTipoPlastico">C\u00F3digo de identifica\u00E7\u00E3o do TipoPlastico (id) (optional)</param>
        /// <returns>Task of ApiResponse (CartaoImpressaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoImpressaoResponse>> GerarCartaoAsyncWithHttpInfo (long? id, long? idPessoa, long? idTipoPlastico = null);
        
        /// <summary>
        /// Realiza o envio para gera\u00E7\u00E3o de um novo cart\u00E3o na gr\u00E1fica
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja gerado um novo Cart\u00E3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00E3o que dever\u00E1 ser gerado para impress\u00E3o. Esta funcionalidade poder\u00E1 ser utilizada para impress\u00E3o de cart\u00F5es em gr\u00E1fica
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="cartaoEmbossingRequest">cartaoEmbossingRequest</param>
        /// <returns>Task of CartaoEmbossingResponse</returns>
        System.Threading.Tasks.Task<CartaoEmbossingResponse> GerarCartaoEmbossingAsync (long? id, CartaoEmbossingRequest cartaoEmbossingRequest);

        /// <summary>
        /// Realiza o envio para gera\u00E7\u00E3o de um novo cart\u00E3o na gr\u00E1fica
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja gerado um novo Cart\u00E3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00E3o que dever\u00E1 ser gerado para impress\u00E3o. Esta funcionalidade poder\u00E1 ser utilizada para impress\u00E3o de cart\u00F5es em gr\u00E1fica
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="cartaoEmbossingRequest">cartaoEmbossingRequest</param>
        /// <returns>Task of ApiResponse (CartaoEmbossingResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoEmbossingResponse>> GerarCartaoEmbossingAsyncWithHttpInfo (long? id, CartaoEmbossingRequest cartaoEmbossingRequest);
        
        /// <summary>
        /// Realiza a gera\u00E7\u00E3o de um cart\u00E3o provisorio
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja gerado um cart\u00E3o provis\u00F3rio para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of CartaoImpressaoProvisorioResponse</returns>
        System.Threading.Tasks.Task<CartaoImpressaoProvisorioResponse> GerarCartaoProvisorioAsync (long? id);

        /// <summary>
        /// Realiza a gera\u00E7\u00E3o de um cart\u00E3o provisorio
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja gerado um cart\u00E3o provis\u00F3rio para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of ApiResponse (CartaoImpressaoProvisorioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoImpressaoProvisorioResponse>> GerarCartaoProvisorioAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Realiza a gera\u00E7\u00E3o de um cart\u00E3o virtual
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja gerado um Cart\u00E3o virtual para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id). Esta funcionalidade poder\u00E1 ser utilizada para realizar a cria\u00E7\u00E3o de cart\u00F5es virtuaes atraves de um app
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="dataValidade">Data de Validade</param>
        /// <returns>Task of CartaoImpressaoResponse</returns>
        System.Threading.Tasks.Task<CartaoImpressaoResponse> GerarCartaoVirtualAsync (long? id, string dataValidade);

        /// <summary>
        /// Realiza a gera\u00E7\u00E3o de um cart\u00E3o virtual
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja gerado um Cart\u00E3o virtual para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id). Esta funcionalidade poder\u00E1 ser utilizada para realizar a cria\u00E7\u00E3o de cart\u00F5es virtuaes atraves de um app
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="dataValidade">Data de Validade</param>
        /// <returns>Task of ApiResponse (CartaoImpressaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoImpressaoResponse>> GerarCartaoVirtualAsyncWithHttpInfo (long? id, string dataValidade);
        
        /// <summary>
        /// Lista contas existentes na base de dados do Emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar contas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto ao qual a conta faz parte. (id) (optional)</param>
        /// <param name="idOrigemComercial">C\u00F3digo de Identifica\u00E7\u00E3o da Origem Comercial (id) que deu origem a Conta (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa Titular da Conta (id) (optional)</param>
        /// <param name="idStatusConta">C\u00F3digo de Identifica\u00E7\u00E3o do status da conta (optional)</param>
        /// <param name="diaVencimento">Apresenta o dia de vencimento (optional)</param>
        /// <param name="melhorDiaCompra">Apresenta o melhor dia de compra (optional)</param>
        /// <param name="dataStatusConta">Apresenta a data em que o idStatusConta atual fora atribu\u00EDdo para ela (optional)</param>
        /// <param name="dataCadastro">Apresenta a data em que o cart\u00E3o foi gerado (optional)</param>
        /// <param name="dataUltimaAlteracaoVencimento">Apresenta a data da ultima altera\u00E7\u00E3o de vencimento (optional)</param>
        /// <param name="funcaoAtiva"> (optional)</param>
        /// <returns>Task of PageContaResponse</returns>
        System.Threading.Tasks.Task<PageContaResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, string dataStatusConta = null, string dataCadastro = null, string dataUltimaAlteracaoVencimento = null, string funcaoAtiva = null);

        /// <summary>
        /// Lista contas existentes na base de dados do Emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar contas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto ao qual a conta faz parte. (id) (optional)</param>
        /// <param name="idOrigemComercial">C\u00F3digo de Identifica\u00E7\u00E3o da Origem Comercial (id) que deu origem a Conta (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa Titular da Conta (id) (optional)</param>
        /// <param name="idStatusConta">C\u00F3digo de Identifica\u00E7\u00E3o do status da conta (optional)</param>
        /// <param name="diaVencimento">Apresenta o dia de vencimento (optional)</param>
        /// <param name="melhorDiaCompra">Apresenta o melhor dia de compra (optional)</param>
        /// <param name="dataStatusConta">Apresenta a data em que o idStatusConta atual fora atribu\u00EDdo para ela (optional)</param>
        /// <param name="dataCadastro">Apresenta a data em que o cart\u00E3o foi gerado (optional)</param>
        /// <param name="dataUltimaAlteracaoVencimento">Apresenta a data da ultima altera\u00E7\u00E3o de vencimento (optional)</param>
        /// <param name="funcaoAtiva"> (optional)</param>
        /// <returns>Task of ApiResponse (PageContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageContaResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, string dataStatusConta = null, string dataCadastro = null, string dataUltimaAlteracaoVencimento = null, string funcaoAtiva = null);
        
        /// <summary>
        /// Lista o hist\u00F3rico de altera\u00E7\u00F5es de limites da conta
        /// </summary>
        /// <remarks>
        /// Este recurso consulta o hist\u00F3rico com as altera\u00E7\u00F5es de limites da conta informada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageHistoricoEventosResponse</returns>
        System.Threading.Tasks.Task<PageHistoricoEventosResponse> ListarHistoricoAlteracoesLimitesAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista o hist\u00F3rico de altera\u00E7\u00F5es de limites da conta
        /// </summary>
        /// <remarks>
        /// Este recurso consulta o hist\u00F3rico com as altera\u00E7\u00F5es de limites da conta informada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoEventosResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageHistoricoEventosResponse>> ListarHistoricoAlteracoesLimitesAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista o hist\u00F3rico de entradas/sa\u00EDdas de assessorias de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Permite listar todos os registros de entrada e sa\u00EDda da Conta em arquivos de integra\u00E7\u00E3o com empresas de assessorias de cobran\u00E7a a partir do c\u00F3digo de identifica\u00E7\u00E3o da conta (idConta)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageHistoricoAssessoriaResponse</returns>
        System.Threading.Tasks.Task<PageHistoricoAssessoriaResponse> ListarHistoricoAssessoriaAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista o hist\u00F3rico de entradas/sa\u00EDdas de assessorias de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Permite listar todos os registros de entrada e sa\u00EDda da Conta em arquivos de integra\u00E7\u00E3o com empresas de assessorias de cobran\u00E7a a partir do c\u00F3digo de identifica\u00E7\u00E3o da conta (idConta)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoAssessoriaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageHistoricoAssessoriaResponse>> ListarHistoricoAssessoriaAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista o historico de atrasos das faturas
        /// </summary>
        /// <remarks>
        /// Este recurso lista o hist\u00F3rico do pagamento de faturas em atraso
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageHistoricoAtrasoFaturaResponse</returns>
        System.Threading.Tasks.Task<PageHistoricoAtrasoFaturaResponse> ListarHistoricoAtrasosFaturasAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista o historico de atrasos das faturas
        /// </summary>
        /// <remarks>
        /// Este recurso lista o hist\u00F3rico do pagamento de faturas em atraso
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoAtrasoFaturaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageHistoricoAtrasoFaturaResponse>> ListarHistoricoAtrasosFaturasAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista as transa\u00E7\u00F5es n\u00E3o processadas da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas todas as transa\u00E7\u00F5es n\u00E3o processadas da Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataInicio">Data de in\u00EDcio da consulta do extrato no formato yyyy-MM-dd (Par\u00E2mentro Ignorado se dataFim n\u00E3o for definida) (optional)</param>
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Par\u00E2mentro Ignorado se dataInicio n\u00E3o for definida) (optional)</param>
        /// <returns>Task of PageTransacaoNaoProcessadaResponse</returns>
        System.Threading.Tasks.Task<PageTransacaoNaoProcessadaResponse> ListarNaoProcessadasAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null);

        /// <summary>
        /// Lista as transa\u00E7\u00F5es n\u00E3o processadas da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas todas as transa\u00E7\u00F5es n\u00E3o processadas da Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataInicio">Data de in\u00EDcio da consulta do extrato no formato yyyy-MM-dd (Par\u00E2mentro Ignorado se dataFim n\u00E3o for definida) (optional)</param>
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Par\u00E2mentro Ignorado se dataInicio n\u00E3o for definida) (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacaoNaoProcessadaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransacaoNaoProcessadaResponse>> ListarNaoProcessadasAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null);
        
        /// <summary>
        /// Lista as transa\u00E7\u00F5es processadas da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas todas as transa\u00E7\u00F5es processadas da Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Data de vencimento do extrato no formato yyyy-MM-dd (optional)</param>
        /// <param name="dataInicio">Data de in\u00EDcio da consulta do extrato no formato yyyy-MM-dd (Ignorado quando o par\u00E2mentro dataVencimento \u00E9 usado) (optional)</param>
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Ignorado quando o par\u00E2mentro dataVencimento \u00E9 usado) (optional)</param>
        /// <param name="idTipoTransacao">transacoes_processadas_request_tipo_transacao (optional)</param>
        /// <param name="recuperaEncargos">Adiciona as transa\u00E7\u00F5es de encargos na consulta (optional)</param>
        /// <returns>Task of PageTransacoesCorrentesResponse</returns>
        System.Threading.Tasks.Task<PageTransacoesCorrentesResponse> ListarProcessadasAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, int? recuperaEncargos = null);

        /// <summary>
        /// Lista as transa\u00E7\u00F5es processadas da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas todas as transa\u00E7\u00F5es processadas da Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Data de vencimento do extrato no formato yyyy-MM-dd (optional)</param>
        /// <param name="dataInicio">Data de in\u00EDcio da consulta do extrato no formato yyyy-MM-dd (Ignorado quando o par\u00E2mentro dataVencimento \u00E9 usado) (optional)</param>
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Ignorado quando o par\u00E2mentro dataVencimento \u00E9 usado) (optional)</param>
        /// <param name="idTipoTransacao">transacoes_processadas_request_tipo_transacao (optional)</param>
        /// <param name="recuperaEncargos">Adiciona as transa\u00E7\u00F5es de encargos na consulta (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacoesCorrentesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransacoesCorrentesResponse>> ListarProcessadasAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, int? recuperaEncargos = null);
        
        /// <summary>
        /// Lista os tipos de fun\u00E7\u00F5es para contas do Emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os tipos de fun\u00E7\u00F5es para as contas do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> Listar_0Async ();

        /// <summary>
        /// Lista os tipos de fun\u00E7\u00F5es para contas do Emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os tipos de fun\u00E7\u00F5es para as contas do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> Listar_0AsyncWithHttpInfo ();
        
        /// <summary>
        /// Lista as transa\u00E7\u00F5es n\u00E3o processadas e processadas da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas todas as transa\u00E7\u00F5es n\u00E3o processadas e processadas da Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Data de vencimento do extrato no formato yyyy-MM-dd (optional)</param>
        /// <param name="dataInicio">Data de in\u00EDcio da consulta do extrato no formato yyyy-MM-dd (Ignorado quando o par\u00E2mentro dataVencimento \u00E9 usado) (optional)</param>
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Ignorado quando o par\u00E2mentro dataVencimento \u00E9 usado) (optional)</param>
        /// <param name="idTipoTransacao">transacoes_processadas_request_tipo_transacao (optional)</param>
        /// <param name="flagCredito">Flag que indica se a transa\u00E7\u00E3o \u00E9 cr\u00E9dito (optional)</param>
        /// <param name="flagFaturado">Flag que indica se a transa\u00E7\u00E3o foi faturada (optional)</param>
        /// <param name="flagProcessada">Flag que indica se a transa\u00E7\u00E3o foi processada (optional)</param>
        /// <param name="status">Status da transa\u00E7\u00E3o (optional)</param>
        /// <param name="plano">Plano da transa\u00E7\u00E3o (optional)</param>
        /// <param name="codigoMCC">C\u00F3digo MCC da transa\u00E7\u00E3o (optional)</param>
        /// <param name="grupoMCC">Grupo MCC da transa\u00E7\u00E3o (optional)</param>
        /// <returns>Task of PageTransacaoProcessadaNaoProcessadaResponse</returns>
        System.Threading.Tasks.Task<PageTransacaoProcessadaNaoProcessadaResponse> Listar_1Async (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, bool? flagCredito = null, bool? flagFaturado = null, bool? flagProcessada = null, int? status = null, int? plano = null, long? codigoMCC = null, long? grupoMCC = null);

        /// <summary>
        /// Lista as transa\u00E7\u00F5es n\u00E3o processadas e processadas da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas todas as transa\u00E7\u00F5es n\u00E3o processadas e processadas da Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Data de vencimento do extrato no formato yyyy-MM-dd (optional)</param>
        /// <param name="dataInicio">Data de in\u00EDcio da consulta do extrato no formato yyyy-MM-dd (Ignorado quando o par\u00E2mentro dataVencimento \u00E9 usado) (optional)</param>
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Ignorado quando o par\u00E2mentro dataVencimento \u00E9 usado) (optional)</param>
        /// <param name="idTipoTransacao">transacoes_processadas_request_tipo_transacao (optional)</param>
        /// <param name="flagCredito">Flag que indica se a transa\u00E7\u00E3o \u00E9 cr\u00E9dito (optional)</param>
        /// <param name="flagFaturado">Flag que indica se a transa\u00E7\u00E3o foi faturada (optional)</param>
        /// <param name="flagProcessada">Flag que indica se a transa\u00E7\u00E3o foi processada (optional)</param>
        /// <param name="status">Status da transa\u00E7\u00E3o (optional)</param>
        /// <param name="plano">Plano da transa\u00E7\u00E3o (optional)</param>
        /// <param name="codigoMCC">C\u00F3digo MCC da transa\u00E7\u00E3o (optional)</param>
        /// <param name="grupoMCC">Grupo MCC da transa\u00E7\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacaoProcessadaNaoProcessadaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransacaoProcessadaNaoProcessadaResponse>> Listar_1AsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, bool? flagCredito = null, bool? flagFaturado = null, bool? flagProcessada = null, int? status = null, int? plano = null, long? codigoMCC = null, long? grupoMCC = null);
        
        /// <summary>
        /// Lista as transfer\u00EAncias realizadas pela conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as transfer\u00EAncias realizadas pela conta existentes na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTransferencia">C\u00F3digo de identifica\u00E7\u00E3o da transfer\u00EAncia (id) (optional)</param>
        /// <param name="idContaOrigem">C\u00F3digo de identifica\u00E7\u00E3o da conta em que o valor ser\u00E1 debitado para a transfer\u00EAncia. (id) (optional)</param>
        /// <param name="idContaDestino">C\u00F3digo de identifica\u00E7\u00E3o da conta em que o valor ser\u00E1 creditado para a transfer\u00EAncia. (id) (optional)</param>
        /// <param name="valorTransferencia">Valor estabelecido para ser transferido (optional)</param>
        /// <param name="dataTransferencia">Data estabelecida para ocorrer a transfer\u00EAncia (optional)</param>
        /// <returns>Task of PageTransferenciaResponse</returns>
        System.Threading.Tasks.Task<PageTransferenciaResponse> Listar_2Async (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, string dataTransferencia = null);

        /// <summary>
        /// Lista as transfer\u00EAncias realizadas pela conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as transfer\u00EAncias realizadas pela conta existentes na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTransferencia">C\u00F3digo de identifica\u00E7\u00E3o da transfer\u00EAncia (id) (optional)</param>
        /// <param name="idContaOrigem">C\u00F3digo de identifica\u00E7\u00E3o da conta em que o valor ser\u00E1 debitado para a transfer\u00EAncia. (id) (optional)</param>
        /// <param name="idContaDestino">C\u00F3digo de identifica\u00E7\u00E3o da conta em que o valor ser\u00E1 creditado para a transfer\u00EAncia. (id) (optional)</param>
        /// <param name="valorTransferencia">Valor estabelecido para ser transferido (optional)</param>
        /// <param name="dataTransferencia">Data estabelecida para ocorrer a transfer\u00EAncia (optional)</param>
        /// <returns>Task of ApiResponse (PageTransferenciaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransferenciaResponse>> Listar_2AsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, string dataTransferencia = null);
        
        /// <summary>
        /// Realiza a reativa\u00E7\u00E3o de contas
        /// </summary>
        /// <remarks>
        /// Este recurso permite reativar contas. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ReativarAsync (long? id);

        /// <summary>
        /// Realiza a reativa\u00E7\u00E3o de contas
        /// </summary>
        /// <remarks>
        /// Este recurso permite reativar contas. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ReativarAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Realiza o cadastro de uma nova conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar uma nova conta para uma pessoa j\u00E1 existente na base de dados do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaPersist">contaPersist</param>
        /// <returns>Task of ContaResponse</returns>
        System.Threading.Tasks.Task<ContaResponse> SalvarAsync (ContaPersist contaPersist);

        /// <summary>
        /// Realiza o cadastro de uma nova conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar uma nova conta para uma pessoa j\u00E1 existente na base de dados do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaPersist">contaPersist</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaResponse>> SalvarAsyncWithHttpInfo (ContaPersist contaPersist);
        
        /// <summary>
        /// Realiza um cadastro de uma nova ades\u00E3o do servi\u00E7o
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar uma nova ades\u00E3o de servi\u00E7o na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="adesaoServicoPersist">adesaoServicoPersist</param>
        /// <returns>Task of AdesaoServicoResponse</returns>
        System.Threading.Tasks.Task<AdesaoServicoResponse> SalvarAdesaoServicosAsync (long? id, AdesaoServicoPersist adesaoServicoPersist);

        /// <summary>
        /// Realiza um cadastro de uma nova ades\u00E3o do servi\u00E7o
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar uma nova ades\u00E3o de servi\u00E7o na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="adesaoServicoPersist">adesaoServicoPersist</param>
        /// <returns>Task of ApiResponse (AdesaoServicoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdesaoServicoResponse>> SalvarAdesaoServicosAsyncWithHttpInfo (long? id, AdesaoServicoPersist adesaoServicoPersist);
        
        /// <summary>
        /// Simula valores de presta\u00E7\u00F5es de empr\u00E9stimos/financiamentos
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o pode ser utilizada para simular opera\u00E7\u00F5es financeiras a partir de informa\u00E7\u00F5es fornecidas pelo usu\u00E1rio. Os c\u00E1lculos gerados devem ser considerados apenas como refer\u00EAncia para as situa\u00E7\u00F5es reais e n\u00E3o como valores oficiais
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="request">request</param>
        /// <returns>Task of EmprestimoPessoalResponse</returns>
        System.Threading.Tasks.Task<EmprestimoPessoalResponse> SimularEmprestimoFinanciamentoAsync (long? id, EmprestimoPessoalRequest request);

        /// <summary>
        /// Simula valores de presta\u00E7\u00F5es de empr\u00E9stimos/financiamentos
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o pode ser utilizada para simular opera\u00E7\u00F5es financeiras a partir de informa\u00E7\u00F5es fornecidas pelo usu\u00E1rio. Os c\u00E1lculos gerados devem ser considerados apenas como refer\u00EAncia para as situa\u00E7\u00F5es reais e n\u00E3o como valores oficiais
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (EmprestimoPessoalResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmprestimoPessoalResponse>> SimularEmprestimoFinanciamentoAsyncWithHttpInfo (long? id, EmprestimoPessoalRequest request);
        
        /// <summary>
        /// Permite listar uma linha do tempo com os eventos da conta
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir a listagem, em formato de timeline, dos eventos vinculados a uma detemrinada conta. Transa\u00E7\u00F5es, fechamento da fatura, pagamentos, gera\u00E7\u00E3o de cart\u00F5es e altera\u00E7\u00E3o de limite s\u00E3o exemplos de eventos contemplados por esta funcionalidade. Neste m\u00E9todo, as opera\u00E7\u00F5es s\u00E3o ordenadas de forma decrescente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageTransacaoResponse</returns>
        System.Threading.Tasks.Task<PageTransacaoResponse> TransacoesAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Permite listar uma linha do tempo com os eventos da conta
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir a listagem, em formato de timeline, dos eventos vinculados a uma detemrinada conta. Transa\u00E7\u00F5es, fechamento da fatura, pagamentos, gera\u00E7\u00E3o de cart\u00F5es e altera\u00E7\u00E3o de limite s\u00E3o exemplos de eventos contemplados por esta funcionalidade. Neste m\u00E9todo, as opera\u00E7\u00F5es s\u00E3o ordenadas de forma decrescente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransacaoResponse>> TransacoesAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Realiza uma transfer\u00EAncia de Cr\u00E9dito para outro cliente do mesmo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que um portador de um cart\u00E3o possa realizar auma transfer\u00EAncia de cr\u00E9dito para outro cliente do mesmo emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta do cliente portador do cart\u00E3o que ser\u00E1 debitado (id)</param>
        /// <param name="idContaDestino">C\u00F3digo de Identifica\u00E7\u00E3o do cliente portador do cart\u00E3o que ser\u00E1 creditado (id)</param>
        /// <param name="valorTransferencia">Valor da Transfer\u00EAncia</param>
        /// <returns>Task of TransferenciaDetalheResponse</returns>
        System.Threading.Tasks.Task<TransferenciaDetalheResponse> TransferirAsync (long? id, long? idContaDestino, double? valorTransferencia);

        /// <summary>
        /// Realiza uma transfer\u00EAncia de Cr\u00E9dito para outro cliente do mesmo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que um portador de um cart\u00E3o possa realizar auma transfer\u00EAncia de cr\u00E9dito para outro cliente do mesmo emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta do cliente portador do cart\u00E3o que ser\u00E1 debitado (id)</param>
        /// <param name="idContaDestino">C\u00F3digo de Identifica\u00E7\u00E3o do cliente portador do cart\u00E3o que ser\u00E1 creditado (id)</param>
        /// <param name="valorTransferencia">Valor da Transfer\u00EAncia</param>
        /// <returns>Task of ApiResponse (TransferenciaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransferenciaDetalheResponse>> TransferirAsyncWithHttpInfo (long? id, long? idContaDestino, double? valorTransferencia);
        
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
        /// Lan\u00E7a um ajuste para a conta do id informado Este recurso insere um ajuste para a conta do id informado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="idTipoAjuste">C\u00F3digo identificador do tipo de ajuste</param> 
        /// <param name="dataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</param> 
        /// <param name="valorAjuste">Valor do ajuste</param> 
        /// <param name="login">login (optional)</param> 
        /// <param name="identificadorExterno">Identificador Externo (optional)</param> 
        /// <param name="idTransacaoOriginal">Identificador da transa\u00E7\u00E3o original (estorno) (optional)</param> 
        /// <param name="idEstabelecimento">Identificador do estabelecimento quando o pagamento for efetuado em loja (optional)</param> 
        /// <returns>AjusteFinanceiroResponse</returns>
        public AjusteFinanceiroResponse AjustarConta (long? id, long? idTipoAjuste, string dataAjuste, double? valorAjuste, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null, long? idEstabelecimento = null)
        {
             ApiResponse<AjusteFinanceiroResponse> localVarResponse = AjustarContaWithHttpInfo(id, idTipoAjuste, dataAjuste, valorAjuste, login, identificadorExterno, idTransacaoOriginal, idEstabelecimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lan\u00E7a um ajuste para a conta do id informado Este recurso insere um ajuste para a conta do id informado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="idTipoAjuste">C\u00F3digo identificador do tipo de ajuste</param> 
        /// <param name="dataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</param> 
        /// <param name="valorAjuste">Valor do ajuste</param> 
        /// <param name="login">login (optional)</param> 
        /// <param name="identificadorExterno">Identificador Externo (optional)</param> 
        /// <param name="idTransacaoOriginal">Identificador da transa\u00E7\u00E3o original (estorno) (optional)</param> 
        /// <param name="idEstabelecimento">Identificador do estabelecimento quando o pagamento for efetuado em loja (optional)</param> 
        /// <returns>ApiResponse of AjusteFinanceiroResponse</returns>
        public ApiResponse< AjusteFinanceiroResponse > AjustarContaWithHttpInfo (long? id, long? idTipoAjuste, string dataAjuste, double? valorAjuste, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null, long? idEstabelecimento = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->AjustarConta");
            
            // verify the required parameter 'idTipoAjuste' is set
            if (idTipoAjuste == null)
                throw new ApiException(400, "Missing required parameter 'idTipoAjuste' when calling ContaApi->AjustarConta");
            
            // verify the required parameter 'dataAjuste' is set
            if (dataAjuste == null)
                throw new ApiException(400, "Missing required parameter 'dataAjuste' when calling ContaApi->AjustarConta");
            
            // verify the required parameter 'valorAjuste' is set
            if (valorAjuste == null)
                throw new ApiException(400, "Missing required parameter 'valorAjuste' when calling ContaApi->AjustarConta");
            
    
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
            if (idTransacaoOriginal != null) localVarQueryParams.Add("idTransacaoOriginal", Configuration.ApiClient.ParameterToString(idTransacaoOriginal)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            
            if (login != null) localVarHeaderParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // header parameter
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AjustarConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AjustarConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AjusteFinanceiroResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AjusteFinanceiroResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AjusteFinanceiroResponse)));
            
        }

        
        /// <summary>
        /// Lan\u00E7a um ajuste para a conta do id informado Este recurso insere um ajuste para a conta do id informado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idTipoAjuste">C\u00F3digo identificador do tipo de ajuste</param>
        /// <param name="dataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</param>
        /// <param name="valorAjuste">Valor do ajuste</param>
        /// <param name="login">login (optional)</param>
        /// <param name="identificadorExterno">Identificador Externo (optional)</param>
        /// <param name="idTransacaoOriginal">Identificador da transa\u00E7\u00E3o original (estorno) (optional)</param>
        /// <param name="idEstabelecimento">Identificador do estabelecimento quando o pagamento for efetuado em loja (optional)</param>
        /// <returns>Task of AjusteFinanceiroResponse</returns>
        public async System.Threading.Tasks.Task<AjusteFinanceiroResponse> AjustarContaAsync (long? id, long? idTipoAjuste, string dataAjuste, double? valorAjuste, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null, long? idEstabelecimento = null)
        {
             ApiResponse<AjusteFinanceiroResponse> localVarResponse = await AjustarContaAsyncWithHttpInfo(id, idTipoAjuste, dataAjuste, valorAjuste, login, identificadorExterno, idTransacaoOriginal, idEstabelecimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lan\u00E7a um ajuste para a conta do id informado Este recurso insere um ajuste para a conta do id informado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idTipoAjuste">C\u00F3digo identificador do tipo de ajuste</param>
        /// <param name="dataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</param>
        /// <param name="valorAjuste">Valor do ajuste</param>
        /// <param name="login">login (optional)</param>
        /// <param name="identificadorExterno">Identificador Externo (optional)</param>
        /// <param name="idTransacaoOriginal">Identificador da transa\u00E7\u00E3o original (estorno) (optional)</param>
        /// <param name="idEstabelecimento">Identificador do estabelecimento quando o pagamento for efetuado em loja (optional)</param>
        /// <returns>Task of ApiResponse (AjusteFinanceiroResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AjusteFinanceiroResponse>> AjustarContaAsyncWithHttpInfo (long? id, long? idTipoAjuste, string dataAjuste, double? valorAjuste, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null, long? idEstabelecimento = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AjustarConta");
            // verify the required parameter 'idTipoAjuste' is set
            if (idTipoAjuste == null) throw new ApiException(400, "Missing required parameter 'idTipoAjuste' when calling AjustarConta");
            // verify the required parameter 'dataAjuste' is set
            if (dataAjuste == null) throw new ApiException(400, "Missing required parameter 'dataAjuste' when calling AjustarConta");
            // verify the required parameter 'valorAjuste' is set
            if (valorAjuste == null) throw new ApiException(400, "Missing required parameter 'valorAjuste' when calling AjustarConta");
            
    
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
            if (idTransacaoOriginal != null) localVarQueryParams.Add("idTransacaoOriginal", Configuration.ApiClient.ParameterToString(idTransacaoOriginal)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            
            if (login != null) localVarHeaderParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // header parameter
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AjustarConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AjustarConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AjusteFinanceiroResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AjusteFinanceiroResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AjusteFinanceiroResponse)));
            
        }
        
        /// <summary>
        /// Altera o produto associado \u00E0 conta O recurso permite fazer modifica\u00E7\u00E3o do produto associado \u00E0 conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="request">request</param> 
        /// <returns>string</returns>
        public string AlterarProduto (long? id, AlterarProdutoRequest request)
        {
             ApiResponse<string> localVarResponse = AlterarProdutoWithHttpInfo(id, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera o produto associado \u00E0 conta O recurso permite fazer modifica\u00E7\u00E3o do produto associado \u00E0 conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="request">request</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > AlterarProdutoWithHttpInfo (long? id, AlterarProdutoRequest request)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->AlterarProduto");
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling ContaApi->AlterarProduto");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarProduto: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarProduto: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Altera o produto associado \u00E0 conta O recurso permite fazer modifica\u00E7\u00E3o do produto associado \u00E0 conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="request">request</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> AlterarProdutoAsync (long? id, AlterarProdutoRequest request)
        {
             ApiResponse<string> localVarResponse = await AlterarProdutoAsyncWithHttpInfo(id, request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera o produto associado \u00E0 conta O recurso permite fazer modifica\u00E7\u00E3o do produto associado \u00E0 conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> AlterarProdutoAsyncWithHttpInfo (long? id, AlterarProdutoRequest request)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarProduto");
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling AlterarProduto");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarProduto: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarProduto: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o de uma Pessoa tilular da conta Esta m\u00E9todo permite altera a pessoa de uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id)</param> 
        /// <param name="idPessoa">C\u00F3digo de identifica\u00E7\u00E3o de uma Pessoa (id)</param> 
        /// <returns>ContaResponse</returns>
        public ContaResponse AlterarTitular (long? id, long? idPessoa)
        {
             ApiResponse<ContaResponse> localVarResponse = AlterarTitularWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a altera\u00E7\u00E3o de uma Pessoa tilular da conta Esta m\u00E9todo permite altera a pessoa de uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id)</param> 
        /// <param name="idPessoa">C\u00F3digo de identifica\u00E7\u00E3o de uma Pessoa (id)</param> 
        /// <returns>ApiResponse of ContaResponse</returns>
        public ApiResponse< ContaResponse > AlterarTitularWithHttpInfo (long? id, long? idPessoa)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->AlterarTitular");
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling ContaApi->AlterarTitular");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarTitular: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTitular: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }

        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o de uma Pessoa tilular da conta Esta m\u00E9todo permite altera a pessoa de uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de identifica\u00E7\u00E3o de uma Pessoa (id)</param>
        /// <returns>Task of ContaResponse</returns>
        public async System.Threading.Tasks.Task<ContaResponse> AlterarTitularAsync (long? id, long? idPessoa)
        {
             ApiResponse<ContaResponse> localVarResponse = await AlterarTitularAsyncWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a altera\u00E7\u00E3o de uma Pessoa tilular da conta Esta m\u00E9todo permite altera a pessoa de uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de identifica\u00E7\u00E3o de uma Pessoa (id)</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaResponse>> AlterarTitularAsyncWithHttpInfo (long? id, long? idPessoa)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarTitular");
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling AlterarTitular");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarTitular: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTitular: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }
        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o do dia de vencimento das faturas da conta Esse recurso permite alterar o vencimento para no m\u00E1ximo at\u00E9 30 dias ap\u00F3s data atual de uma conta especifica no PIER, respeitando o par\u00E2metro de intervalor entre as modifica\u00E7\u00F5es do vencimento informado pelo emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="novoDiaVencimento">Novo dia de vencimento</param> 
        /// <returns>ContaResponse</returns>
        public ContaResponse AlterarVencimento (long? id, int? novoDiaVencimento)
        {
             ApiResponse<ContaResponse> localVarResponse = AlterarVencimentoWithHttpInfo(id, novoDiaVencimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a altera\u00E7\u00E3o do dia de vencimento das faturas da conta Esse recurso permite alterar o vencimento para no m\u00E1ximo at\u00E9 30 dias ap\u00F3s data atual de uma conta especifica no PIER, respeitando o par\u00E2metro de intervalor entre as modifica\u00E7\u00F5es do vencimento informado pelo emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="novoDiaVencimento">Novo dia de vencimento</param> 
        /// <returns>ApiResponse of ContaResponse</returns>
        public ApiResponse< ContaResponse > AlterarVencimentoWithHttpInfo (long? id, int? novoDiaVencimento)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->AlterarVencimento");
            
            // verify the required parameter 'novoDiaVencimento' is set
            if (novoDiaVencimento == null)
                throw new ApiException(400, "Missing required parameter 'novoDiaVencimento' when calling ContaApi->AlterarVencimento");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarVencimento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarVencimento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }

        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o do dia de vencimento das faturas da conta Esse recurso permite alterar o vencimento para no m\u00E1ximo at\u00E9 30 dias ap\u00F3s data atual de uma conta especifica no PIER, respeitando o par\u00E2metro de intervalor entre as modifica\u00E7\u00F5es do vencimento informado pelo emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="novoDiaVencimento">Novo dia de vencimento</param>
        /// <returns>Task of ContaResponse</returns>
        public async System.Threading.Tasks.Task<ContaResponse> AlterarVencimentoAsync (long? id, int? novoDiaVencimento)
        {
             ApiResponse<ContaResponse> localVarResponse = await AlterarVencimentoAsyncWithHttpInfo(id, novoDiaVencimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a altera\u00E7\u00E3o do dia de vencimento das faturas da conta Esse recurso permite alterar o vencimento para no m\u00E1ximo at\u00E9 30 dias ap\u00F3s data atual de uma conta especifica no PIER, respeitando o par\u00E2metro de intervalor entre as modifica\u00E7\u00F5es do vencimento informado pelo emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="novoDiaVencimento">Novo dia de vencimento</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaResponse>> AlterarVencimentoAsyncWithHttpInfo (long? id, int? novoDiaVencimento)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarVencimento");
            // verify the required parameter 'novoDiaVencimento' is set
            if (novoDiaVencimento == null) throw new ApiException(400, "Missing required parameter 'novoDiaVencimento' when calling AlterarVencimento");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarVencimento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarVencimento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }
        
        /// <summary>
        /// Atribuir Anuidade Esse recurso permite configurar qual a regra de Anuidade que ser\u00E1 atribu\u00EDda a uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="idAnuidade">Identificador da anuidade</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="DDD">DDD do celular (optional)</param> 
        /// <param name="celular">N\u00FAmero do celular (optional)</param> 
        /// <param name="idOperadora">Identificador da operadora do celular (optional)</param> 
        /// <param name="idOrigemComercial">Identificador da origem comercial (optional)</param> 
        /// <returns>Object</returns>
        public Object AtivarAnuidade (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null)
        {
             ApiResponse<Object> localVarResponse = AtivarAnuidadeWithHttpInfo(id, idAnuidade, sort, page, limit, DDD, celular, idOperadora, idOrigemComercial);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atribuir Anuidade Esse recurso permite configurar qual a regra de Anuidade que ser\u00E1 atribu\u00EDda a uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="idAnuidade">Identificador da anuidade</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="DDD">DDD do celular (optional)</param> 
        /// <param name="celular">N\u00FAmero do celular (optional)</param> 
        /// <param name="idOperadora">Identificador da operadora do celular (optional)</param> 
        /// <param name="idOrigemComercial">Identificador da origem comercial (optional)</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > AtivarAnuidadeWithHttpInfo (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->AtivarAnuidade");
            
            // verify the required parameter 'idAnuidade' is set
            if (idAnuidade == null)
                throw new ApiException(400, "Missing required parameter 'idAnuidade' when calling ContaApi->AtivarAnuidade");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtivarAnuidade: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarAnuidade: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Atribuir Anuidade Esse recurso permite configurar qual a regra de Anuidade que ser\u00E1 atribu\u00EDda a uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idAnuidade">Identificador da anuidade</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="DDD">DDD do celular (optional)</param>
        /// <param name="celular">N\u00FAmero do celular (optional)</param>
        /// <param name="idOperadora">Identificador da operadora do celular (optional)</param>
        /// <param name="idOrigemComercial">Identificador da origem comercial (optional)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> AtivarAnuidadeAsync (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null)
        {
             ApiResponse<Object> localVarResponse = await AtivarAnuidadeAsyncWithHttpInfo(id, idAnuidade, sort, page, limit, DDD, celular, idOperadora, idOrigemComercial);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atribuir Anuidade Esse recurso permite configurar qual a regra de Anuidade que ser\u00E1 atribu\u00EDda a uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idAnuidade">Identificador da anuidade</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="DDD">DDD do celular (optional)</param>
        /// <param name="celular">N\u00FAmero do celular (optional)</param>
        /// <param name="idOperadora">Identificador da operadora do celular (optional)</param>
        /// <param name="idOrigemComercial">Identificador da origem comercial (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AtivarAnuidadeAsyncWithHttpInfo (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtivarAnuidade");
            // verify the required parameter 'idAnuidade' is set
            if (idAnuidade == null) throw new ApiException(400, "Missing required parameter 'idAnuidade' when calling AtivarAnuidade");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtivarAnuidade: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarAnuidade: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Ativa o servi\u00E7o de envio de fatura por email Este recurso ativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <returns>Object</returns>
        public Object AtivarEnvioFaturaEmail (long? id)
        {
             ApiResponse<Object> localVarResponse = AtivarEnvioFaturaEmailWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Ativa o servi\u00E7o de envio de fatura por email Este recurso ativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > AtivarEnvioFaturaEmailWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->AtivarEnvioFaturaEmail");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtivarEnvioFaturaEmail: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarEnvioFaturaEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Ativa o servi\u00E7o de envio de fatura por email Este recurso ativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> AtivarEnvioFaturaEmailAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await AtivarEnvioFaturaEmailAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Ativa o servi\u00E7o de envio de fatura por email Este recurso ativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AtivarEnvioFaturaEmailAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtivarEnvioFaturaEmail");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtivarEnvioFaturaEmail: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarEnvioFaturaEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Realiza a atualiza\u00E7\u00E3o parcial da conta Esse recurso permite realizar a atualiza\u00E7\u00E3o parcial da conta. Isso indica dizer que apenas os campos informados na requisi\u00E7\u00E3o ser\u00E3o atualizados, sendo ignorados os demais
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="contaPartialUpdate">contaPartialUpdate</param> 
        /// <returns>ContaResponse</returns>
        public ContaResponse AtualizarParcial (long? id, ContaPartialUpdate contaPartialUpdate)
        {
             ApiResponse<ContaResponse> localVarResponse = AtualizarParcialWithHttpInfo(id, contaPartialUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a atualiza\u00E7\u00E3o parcial da conta Esse recurso permite realizar a atualiza\u00E7\u00E3o parcial da conta. Isso indica dizer que apenas os campos informados na requisi\u00E7\u00E3o ser\u00E3o atualizados, sendo ignorados os demais
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="contaPartialUpdate">contaPartialUpdate</param> 
        /// <returns>ApiResponse of ContaResponse</returns>
        public ApiResponse< ContaResponse > AtualizarParcialWithHttpInfo (long? id, ContaPartialUpdate contaPartialUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->AtualizarParcial");
            
            // verify the required parameter 'contaPartialUpdate' is set
            if (contaPartialUpdate == null)
                throw new ApiException(400, "Missing required parameter 'contaPartialUpdate' when calling ContaApi->AtualizarParcial");
            
    
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
            
            
            
            
            if (contaPartialUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contaPartialUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contaPartialUpdate; // byte array
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
    
            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }

        
        /// <summary>
        /// Realiza a atualiza\u00E7\u00E3o parcial da conta Esse recurso permite realizar a atualiza\u00E7\u00E3o parcial da conta. Isso indica dizer que apenas os campos informados na requisi\u00E7\u00E3o ser\u00E3o atualizados, sendo ignorados os demais
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="contaPartialUpdate">contaPartialUpdate</param>
        /// <returns>Task of ContaResponse</returns>
        public async System.Threading.Tasks.Task<ContaResponse> AtualizarParcialAsync (long? id, ContaPartialUpdate contaPartialUpdate)
        {
             ApiResponse<ContaResponse> localVarResponse = await AtualizarParcialAsyncWithHttpInfo(id, contaPartialUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a atualiza\u00E7\u00E3o parcial da conta Esse recurso permite realizar a atualiza\u00E7\u00E3o parcial da conta. Isso indica dizer que apenas os campos informados na requisi\u00E7\u00E3o ser\u00E3o atualizados, sendo ignorados os demais
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="contaPartialUpdate">contaPartialUpdate</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaResponse>> AtualizarParcialAsyncWithHttpInfo (long? id, ContaPartialUpdate contaPartialUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarParcial");
            // verify the required parameter 'contaPartialUpdate' is set
            if (contaPartialUpdate == null) throw new ApiException(400, "Missing required parameter 'contaPartialUpdate' when calling AtualizarParcial");
            
    
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
            
            
            
            
            if (contaPartialUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contaPartialUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contaPartialUpdate; // byte array
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

            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }
        
        /// <summary>
        /// Realiza o bloqueio de uma determinada Conta Este m\u00E9todo permite a realiza\u00E7\u00E3o do bloqueio de uma determinada conta a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="idStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Novo Status Conta</param> 
        /// <returns>ContaResponse</returns>
        public ContaResponse Bloquear (long? id, long? idStatus)
        {
             ApiResponse<ContaResponse> localVarResponse = BloquearWithHttpInfo(id, idStatus);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o bloqueio de uma determinada Conta Este m\u00E9todo permite a realiza\u00E7\u00E3o do bloqueio de uma determinada conta a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="idStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Novo Status Conta</param> 
        /// <returns>ApiResponse of ContaResponse</returns>
        public ApiResponse< ContaResponse > BloquearWithHttpInfo (long? id, long? idStatus)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->Bloquear");
            
            // verify the required parameter 'idStatus' is set
            if (idStatus == null)
                throw new ApiException(400, "Missing required parameter 'idStatus' when calling ContaApi->Bloquear");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Bloquear: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Bloquear: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }

        
        /// <summary>
        /// Realiza o bloqueio de uma determinada Conta Este m\u00E9todo permite a realiza\u00E7\u00E3o do bloqueio de uma determinada conta a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Novo Status Conta</param>
        /// <returns>Task of ContaResponse</returns>
        public async System.Threading.Tasks.Task<ContaResponse> BloquearAsync (long? id, long? idStatus)
        {
             ApiResponse<ContaResponse> localVarResponse = await BloquearAsyncWithHttpInfo(id, idStatus);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o bloqueio de uma determinada Conta Este m\u00E9todo permite a realiza\u00E7\u00E3o do bloqueio de uma determinada conta a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Novo Status Conta</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaResponse>> BloquearAsyncWithHttpInfo (long? id, long? idStatus)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Bloquear");
            // verify the required parameter 'idStatus' is set
            if (idStatus == null) throw new ApiException(400, "Missing required parameter 'idStatus' when calling Bloquear");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Bloquear: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Bloquear: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }
        
        /// <summary>
        /// Cadastro ades\u00E3o de pagamento no s\u00E1bado Este recurso permite cadastrar uma ades\u00E3o de pagamento no s\u00E1bado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id da conta</param> 
        /// <returns>AdesaoPagamentoSabadoResponse</returns>
        public AdesaoPagamentoSabadoResponse Cadastrar (long? id)
        {
             ApiResponse<AdesaoPagamentoSabadoResponse> localVarResponse = CadastrarWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastro ades\u00E3o de pagamento no s\u00E1bado Este recurso permite cadastrar uma ades\u00E3o de pagamento no s\u00E1bado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id da conta</param> 
        /// <returns>ApiResponse of AdesaoPagamentoSabadoResponse</returns>
        public ApiResponse< AdesaoPagamentoSabadoResponse > CadastrarWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->Cadastrar");
            
    
            var localVarPath = "/api/adesoes-pagamentos-sabados";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Cadastrar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Cadastrar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdesaoPagamentoSabadoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdesaoPagamentoSabadoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdesaoPagamentoSabadoResponse)));
            
        }

        
        /// <summary>
        /// Cadastro ades\u00E3o de pagamento no s\u00E1bado Este recurso permite cadastrar uma ades\u00E3o de pagamento no s\u00E1bado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id da conta</param>
        /// <returns>Task of AdesaoPagamentoSabadoResponse</returns>
        public async System.Threading.Tasks.Task<AdesaoPagamentoSabadoResponse> CadastrarAsync (long? id)
        {
             ApiResponse<AdesaoPagamentoSabadoResponse> localVarResponse = await CadastrarAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastro ades\u00E3o de pagamento no s\u00E1bado Este recurso permite cadastrar uma ades\u00E3o de pagamento no s\u00E1bado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id da conta</param>
        /// <returns>Task of ApiResponse (AdesaoPagamentoSabadoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdesaoPagamentoSabadoResponse>> CadastrarAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Cadastrar");
            
    
            var localVarPath = "/api/adesoes-pagamentos-sabados";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Cadastrar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Cadastrar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdesaoPagamentoSabadoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdesaoPagamentoSabadoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdesaoPagamentoSabadoResponse)));
            
        }
        
        /// <summary>
        /// Realiza o cancelamento de uma determinada Conta Este m\u00E9todo permite a realiza\u00E7\u00E3o do cancelamento de uma determinada conta a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="idStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Novo Status Conta</param> 
        /// <returns>ContaResponse</returns>
        public ContaResponse Cancelar (long? id, long? idStatus)
        {
             ApiResponse<ContaResponse> localVarResponse = CancelarWithHttpInfo(id, idStatus);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cancelamento de uma determinada Conta Este m\u00E9todo permite a realiza\u00E7\u00E3o do cancelamento de uma determinada conta a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="idStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Novo Status Conta</param> 
        /// <returns>ApiResponse of ContaResponse</returns>
        public ApiResponse< ContaResponse > CancelarWithHttpInfo (long? id, long? idStatus)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->Cancelar");
            
            // verify the required parameter 'idStatus' is set
            if (idStatus == null)
                throw new ApiException(400, "Missing required parameter 'idStatus' when calling ContaApi->Cancelar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Cancelar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Cancelar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }

        
        /// <summary>
        /// Realiza o cancelamento de uma determinada Conta Este m\u00E9todo permite a realiza\u00E7\u00E3o do cancelamento de uma determinada conta a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Novo Status Conta</param>
        /// <returns>Task of ContaResponse</returns>
        public async System.Threading.Tasks.Task<ContaResponse> CancelarAsync (long? id, long? idStatus)
        {
             ApiResponse<ContaResponse> localVarResponse = await CancelarAsyncWithHttpInfo(id, idStatus);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cancelamento de uma determinada Conta Este m\u00E9todo permite a realiza\u00E7\u00E3o do cancelamento de uma determinada conta a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Novo Status Conta</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaResponse>> CancelarAsyncWithHttpInfo (long? id, long? idStatus)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Cancelar");
            // verify the required parameter 'idStatus' is set
            if (idStatus == null) throw new ApiException(400, "Missing required parameter 'idStatus' when calling Cancelar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Cancelar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Cancelar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }
        
        /// <summary>
        /// Consulta ades\u00E3o de pagamento no s\u00E1bado Este recurso permite consultar uma ades\u00E3o de pagamento no s\u00E1bado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id da conta</param> 
        /// <param name="dataVencimento">Data de vencimento da ades\u00E3o</param> 
        /// <returns>AdesaoPagamentoSabadoResponse</returns>
        public AdesaoPagamentoSabadoResponse Consultar (long? id, string dataVencimento)
        {
             ApiResponse<AdesaoPagamentoSabadoResponse> localVarResponse = ConsultarWithHttpInfo(id, dataVencimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta ades\u00E3o de pagamento no s\u00E1bado Este recurso permite consultar uma ades\u00E3o de pagamento no s\u00E1bado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id da conta</param> 
        /// <param name="dataVencimento">Data de vencimento da ades\u00E3o</param> 
        /// <returns>ApiResponse of AdesaoPagamentoSabadoResponse</returns>
        public ApiResponse< AdesaoPagamentoSabadoResponse > ConsultarWithHttpInfo (long? id, string dataVencimento)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->Consultar");
            
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null)
                throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling ContaApi->Consultar");
            
    
            var localVarPath = "/api/adesoes-pagamentos-sabados";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdesaoPagamentoSabadoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdesaoPagamentoSabadoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdesaoPagamentoSabadoResponse)));
            
        }

        
        /// <summary>
        /// Consulta ades\u00E3o de pagamento no s\u00E1bado Este recurso permite consultar uma ades\u00E3o de pagamento no s\u00E1bado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id da conta</param>
        /// <param name="dataVencimento">Data de vencimento da ades\u00E3o</param>
        /// <returns>Task of AdesaoPagamentoSabadoResponse</returns>
        public async System.Threading.Tasks.Task<AdesaoPagamentoSabadoResponse> ConsultarAsync (long? id, string dataVencimento)
        {
             ApiResponse<AdesaoPagamentoSabadoResponse> localVarResponse = await ConsultarAsyncWithHttpInfo(id, dataVencimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta ades\u00E3o de pagamento no s\u00E1bado Este recurso permite consultar uma ades\u00E3o de pagamento no s\u00E1bado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id da conta</param>
        /// <param name="dataVencimento">Data de vencimento da ades\u00E3o</param>
        /// <returns>Task of ApiResponse (AdesaoPagamentoSabadoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdesaoPagamentoSabadoResponse>> ConsultarAsyncWithHttpInfo (long? id, string dataVencimento)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar");
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null) throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling Consultar");
            
    
            var localVarPath = "/api/adesoes-pagamentos-sabados";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdesaoPagamentoSabadoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdesaoPagamentoSabadoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdesaoPagamentoSabadoResponse)));
            
        }
        
        /// <summary>
        /// Apresenta a data m\u00E1xima para pagamento da fatura em atraso para receber o benef\u00EDcio Este m\u00E9todo permite consultar se o cliente tem direito ao benef\u00EDcio de pagamento em atraso, em loja, at\u00E9 o s\u00E1bado subsequente ao vencimento, ficando isento do pagamento de multa, encargos, mora e IOF
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <returns>BeneficioPagamentoAtrasoResponse</returns>
        public BeneficioPagamentoAtrasoResponse ConsultarBeneficioPagamentoAtraso (long? id)
        {
             ApiResponse<BeneficioPagamentoAtrasoResponse> localVarResponse = ConsultarBeneficioPagamentoAtrasoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta a data m\u00E1xima para pagamento da fatura em atraso para receber o benef\u00EDcio Este m\u00E9todo permite consultar se o cliente tem direito ao benef\u00EDcio de pagamento em atraso, em loja, at\u00E9 o s\u00E1bado subsequente ao vencimento, ficando isento do pagamento de multa, encargos, mora e IOF
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <returns>ApiResponse of BeneficioPagamentoAtrasoResponse</returns>
        public ApiResponse< BeneficioPagamentoAtrasoResponse > ConsultarBeneficioPagamentoAtrasoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ConsultarBeneficioPagamentoAtraso");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBeneficioPagamentoAtraso: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBeneficioPagamentoAtraso: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BeneficioPagamentoAtrasoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BeneficioPagamentoAtrasoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BeneficioPagamentoAtrasoResponse)));
            
        }

        
        /// <summary>
        /// Apresenta a data m\u00E1xima para pagamento da fatura em atraso para receber o benef\u00EDcio Este m\u00E9todo permite consultar se o cliente tem direito ao benef\u00EDcio de pagamento em atraso, em loja, at\u00E9 o s\u00E1bado subsequente ao vencimento, ficando isento do pagamento de multa, encargos, mora e IOF
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of BeneficioPagamentoAtrasoResponse</returns>
        public async System.Threading.Tasks.Task<BeneficioPagamentoAtrasoResponse> ConsultarBeneficioPagamentoAtrasoAsync (long? id)
        {
             ApiResponse<BeneficioPagamentoAtrasoResponse> localVarResponse = await ConsultarBeneficioPagamentoAtrasoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta a data m\u00E1xima para pagamento da fatura em atraso para receber o benef\u00EDcio Este m\u00E9todo permite consultar se o cliente tem direito ao benef\u00EDcio de pagamento em atraso, em loja, at\u00E9 o s\u00E1bado subsequente ao vencimento, ficando isento do pagamento de multa, encargos, mora e IOF
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of ApiResponse (BeneficioPagamentoAtrasoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BeneficioPagamentoAtrasoResponse>> ConsultarBeneficioPagamentoAtrasoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarBeneficioPagamentoAtraso");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBeneficioPagamentoAtraso: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBeneficioPagamentoAtraso: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public BoletoResponse ConsultarBoletoEmitido (long? id)
        {
             ApiResponse<BoletoResponse> localVarResponse = ConsultarBoletoEmitidoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta os dados de um determinado boleto da fatura Este recurso consulta um boleto da fatura
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <returns>ApiResponse of BoletoResponse</returns>
        public ApiResponse< BoletoResponse > ConsultarBoletoEmitidoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ConsultarBoletoEmitido");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBoletoEmitido: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBoletoEmitido: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<BoletoResponse> ConsultarBoletoEmitidoAsync (long? id)
        {
             ApiResponse<BoletoResponse> localVarResponse = await ConsultarBoletoEmitidoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta os dados de um determinado boleto da fatura Este recurso consulta um boleto da fatura
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Task of ApiResponse (BoletoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BoletoResponse>> ConsultarBoletoEmitidoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarBoletoEmitido");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBoletoEmitido: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBoletoEmitido: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoResponse)));
            
        }
        
        /// <summary>
        /// Consulta a d\u00EDvida atualizada do cliente Este recurso consulta a d\u00EDvida atualizada do cliente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="dataVencimento">Data do vencimento (optional)</param> 
        /// <param name="idEscritorioCobranca">C\u00F3digo de identifica\u00E7\u00E3o do escrit\u00F3rio de cobran\u00E7a (optional)</param> 
        /// <returns>DividaClienteResponse</returns>
        public DividaClienteResponse ConsultarDividaAtualizadaCliente (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, long? idEscritorioCobranca = null)
        {
             ApiResponse<DividaClienteResponse> localVarResponse = ConsultarDividaAtualizadaClienteWithHttpInfo(id, sort, page, limit, dataVencimento, idEscritorioCobranca);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta a d\u00EDvida atualizada do cliente Este recurso consulta a d\u00EDvida atualizada do cliente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="dataVencimento">Data do vencimento (optional)</param> 
        /// <param name="idEscritorioCobranca">C\u00F3digo de identifica\u00E7\u00E3o do escrit\u00F3rio de cobran\u00E7a (optional)</param> 
        /// <returns>ApiResponse of DividaClienteResponse</returns>
        public ApiResponse< DividaClienteResponse > ConsultarDividaAtualizadaClienteWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, long? idEscritorioCobranca = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ConsultarDividaAtualizadaCliente");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDividaAtualizadaCliente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDividaAtualizadaCliente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DividaClienteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DividaClienteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DividaClienteResponse)));
            
        }

        
        /// <summary>
        /// Consulta a d\u00EDvida atualizada do cliente Este recurso consulta a d\u00EDvida atualizada do cliente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Data do vencimento (optional)</param>
        /// <param name="idEscritorioCobranca">C\u00F3digo de identifica\u00E7\u00E3o do escrit\u00F3rio de cobran\u00E7a (optional)</param>
        /// <returns>Task of DividaClienteResponse</returns>
        public async System.Threading.Tasks.Task<DividaClienteResponse> ConsultarDividaAtualizadaClienteAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, long? idEscritorioCobranca = null)
        {
             ApiResponse<DividaClienteResponse> localVarResponse = await ConsultarDividaAtualizadaClienteAsyncWithHttpInfo(id, sort, page, limit, dataVencimento, idEscritorioCobranca);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta a d\u00EDvida atualizada do cliente Este recurso consulta a d\u00EDvida atualizada do cliente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Data do vencimento (optional)</param>
        /// <param name="idEscritorioCobranca">C\u00F3digo de identifica\u00E7\u00E3o do escrit\u00F3rio de cobran\u00E7a (optional)</param>
        /// <returns>Task of ApiResponse (DividaClienteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DividaClienteResponse>> ConsultarDividaAtualizadaClienteAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, long? idEscritorioCobranca = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarDividaAtualizadaCliente");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDividaAtualizadaCliente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDividaAtualizadaCliente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DividaClienteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DividaClienteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DividaClienteResponse)));
            
        }
        
        /// <summary>
        /// Consulta uma transa\u00E7\u00E3o processada da conta. Este recurso permite consultar os detalhes de uma transa\u00E7\u00E3o processada pertencente a uma conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id).</param> 
        /// <param name="idTransacao">C\u00F3digo de Identifica\u00E7\u00E3o da transa\u00E7\u00E3o (id).</param> 
        /// <returns>TransacoesCorrentesResponse</returns>
        public TransacoesCorrentesResponse ConsultarProcessada (long? id, long? idTransacao)
        {
             ApiResponse<TransacoesCorrentesResponse> localVarResponse = ConsultarProcessadaWithHttpInfo(id, idTransacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta uma transa\u00E7\u00E3o processada da conta. Este recurso permite consultar os detalhes de uma transa\u00E7\u00E3o processada pertencente a uma conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id).</param> 
        /// <param name="idTransacao">C\u00F3digo de Identifica\u00E7\u00E3o da transa\u00E7\u00E3o (id).</param> 
        /// <returns>ApiResponse of TransacoesCorrentesResponse</returns>
        public ApiResponse< TransacoesCorrentesResponse > ConsultarProcessadaWithHttpInfo (long? id, long? idTransacao)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ConsultarProcessada");
            
            // verify the required parameter 'idTransacao' is set
            if (idTransacao == null)
                throw new ApiException(400, "Missing required parameter 'idTransacao' when calling ContaApi->ConsultarProcessada");
            
    
            var localVarPath = "/api/contas/{id}/transacoes-processadas/{idTransacao}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (idTransacao != null) localVarPathParams.Add("idTransacao", Configuration.ApiClient.ParameterToString(idTransacao)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarProcessada: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarProcessada: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransacoesCorrentesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacoesCorrentesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacoesCorrentesResponse)));
            
        }

        
        /// <summary>
        /// Consulta uma transa\u00E7\u00E3o processada da conta. Este recurso permite consultar os detalhes de uma transa\u00E7\u00E3o processada pertencente a uma conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="idTransacao">C\u00F3digo de Identifica\u00E7\u00E3o da transa\u00E7\u00E3o (id).</param>
        /// <returns>Task of TransacoesCorrentesResponse</returns>
        public async System.Threading.Tasks.Task<TransacoesCorrentesResponse> ConsultarProcessadaAsync (long? id, long? idTransacao)
        {
             ApiResponse<TransacoesCorrentesResponse> localVarResponse = await ConsultarProcessadaAsyncWithHttpInfo(id, idTransacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta uma transa\u00E7\u00E3o processada da conta. Este recurso permite consultar os detalhes de uma transa\u00E7\u00E3o processada pertencente a uma conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="idTransacao">C\u00F3digo de Identifica\u00E7\u00E3o da transa\u00E7\u00E3o (id).</param>
        /// <returns>Task of ApiResponse (TransacoesCorrentesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransacoesCorrentesResponse>> ConsultarProcessadaAsyncWithHttpInfo (long? id, long? idTransacao)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarProcessada");
            // verify the required parameter 'idTransacao' is set
            if (idTransacao == null) throw new ApiException(400, "Missing required parameter 'idTransacao' when calling ConsultarProcessada");
            
    
            var localVarPath = "/api/contas/{id}/transacoes-processadas/{idTransacao}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (idTransacao != null) localVarPathParams.Add("idTransacao", Configuration.ApiClient.ParameterToString(idTransacao)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarProcessada: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarProcessada: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransacoesCorrentesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacoesCorrentesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacoesCorrentesResponse)));
            
        }
        
        /// <summary>
        /// Permite consultar a partir do ID da conta as taxas e tarifas Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores consultem as taxas e tarifas da conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da conta a ser consultada</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageTaxasRefinanciamentoResponse</returns>
        public PageTaxasRefinanciamentoResponse ConsultarTaxasTarifas (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTaxasRefinanciamentoResponse> localVarResponse = ConsultarTaxasTarifasWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite consultar a partir do ID da conta as taxas e tarifas Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores consultem as taxas e tarifas da conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da conta a ser consultada</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageTaxasRefinanciamentoResponse</returns>
        public ApiResponse< PageTaxasRefinanciamentoResponse > ConsultarTaxasTarifasWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ConsultarTaxasTarifas");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxasTarifas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxasTarifas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTaxasRefinanciamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTaxasRefinanciamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTaxasRefinanciamentoResponse)));
            
        }

        
        /// <summary>
        /// Permite consultar a partir do ID da conta as taxas e tarifas Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores consultem as taxas e tarifas da conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da conta a ser consultada</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageTaxasRefinanciamentoResponse</returns>
        public async System.Threading.Tasks.Task<PageTaxasRefinanciamentoResponse> ConsultarTaxasTarifasAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTaxasRefinanciamentoResponse> localVarResponse = await ConsultarTaxasTarifasAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite consultar a partir do ID da conta as taxas e tarifas Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores consultem as taxas e tarifas da conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da conta a ser consultada</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTaxasRefinanciamentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTaxasRefinanciamentoResponse>> ConsultarTaxasTarifasAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarTaxasTarifas");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxasTarifas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxasTarifas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTaxasRefinanciamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTaxasRefinanciamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTaxasRefinanciamentoResponse)));
            
        }
        
        /// <summary>
        /// Apresenta dados de um determinado tipo de fun\u00E7\u00E3o para contas Este m\u00E9todo permite consultar dados de um determinado tipo de fun\u00E7\u00E3o para contas a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo de fun\u00E7\u00E3o para contas (id)</param> 
        /// <returns>string</returns>
        public string Consultar_0 (int? id)
        {
             ApiResponse<string> localVarResponse = Consultar_0WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta dados de um determinado tipo de fun\u00E7\u00E3o para contas Este m\u00E9todo permite consultar dados de um determinado tipo de fun\u00E7\u00E3o para contas a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo de fun\u00E7\u00E3o para contas (id)</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > Consultar_0WithHttpInfo (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->Consultar_0");
            
    
            var localVarPath = "/api/contas/tipos-funcoes/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Apresenta dados de um determinado tipo de fun\u00E7\u00E3o para contas Este m\u00E9todo permite consultar dados de um determinado tipo de fun\u00E7\u00E3o para contas a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo de fun\u00E7\u00E3o para contas (id)</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> Consultar_0Async (int? id)
        {
             ApiResponse<string> localVarResponse = await Consultar_0AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta dados de um determinado tipo de fun\u00E7\u00E3o para contas Este m\u00E9todo permite consultar dados de um determinado tipo de fun\u00E7\u00E3o para contas a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo de fun\u00E7\u00E3o para contas (id)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> Consultar_0AsyncWithHttpInfo (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar_0");
            
    
            var localVarPath = "/api/contas/tipos-funcoes/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Apresenta dados de uma determinada conta Este m\u00E9todo permite consultar dados de uma determinada conta a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <returns>ContaDetalheResponse</returns>
        public ContaDetalheResponse Consultar_1 (long? id)
        {
             ApiResponse<ContaDetalheResponse> localVarResponse = Consultar_1WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta dados de uma determinada conta Este m\u00E9todo permite consultar dados de uma determinada conta a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <returns>ApiResponse of ContaDetalheResponse</returns>
        public ApiResponse< ContaDetalheResponse > Consultar_1WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->Consultar_1");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaDetalheResponse)));
            
        }

        
        /// <summary>
        /// Apresenta dados de uma determinada conta Este m\u00E9todo permite consultar dados de uma determinada conta a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of ContaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<ContaDetalheResponse> Consultar_1Async (long? id)
        {
             ApiResponse<ContaDetalheResponse> localVarResponse = await Consultar_1AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta dados de uma determinada conta Este m\u00E9todo permite consultar dados de uma determinada conta a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of ApiResponse (ContaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaDetalheResponse>> Consultar_1AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar_1");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaDetalheResponse)));
            
        }
        
        /// <summary>
        /// Consulta os detalhes de uma determinada transfer\u00EAncia Este m\u00E9todo permite consultar os detalhes de uma determinada transfer\u00EAncia de cr\u00E9dito realizada entre contas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="idTransferencia">C\u00F3digo de Identifica\u00E7\u00E3o da transfer\u00EAncia (id_transferencia)</param> 
        /// <returns>TransferenciaDetalheResponse</returns>
        public TransferenciaDetalheResponse Consultar_2 (long? id, long? idTransferencia)
        {
             ApiResponse<TransferenciaDetalheResponse> localVarResponse = Consultar_2WithHttpInfo(id, idTransferencia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta os detalhes de uma determinada transfer\u00EAncia Este m\u00E9todo permite consultar os detalhes de uma determinada transfer\u00EAncia de cr\u00E9dito realizada entre contas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="idTransferencia">C\u00F3digo de Identifica\u00E7\u00E3o da transfer\u00EAncia (id_transferencia)</param> 
        /// <returns>ApiResponse of TransferenciaDetalheResponse</returns>
        public ApiResponse< TransferenciaDetalheResponse > Consultar_2WithHttpInfo (long? id, long? idTransferencia)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->Consultar_2");
            
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null)
                throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling ContaApi->Consultar_2");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransferenciaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaDetalheResponse)));
            
        }

        
        /// <summary>
        /// Consulta os detalhes de uma determinada transfer\u00EAncia Este m\u00E9todo permite consultar os detalhes de uma determinada transfer\u00EAncia de cr\u00E9dito realizada entre contas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idTransferencia">C\u00F3digo de Identifica\u00E7\u00E3o da transfer\u00EAncia (id_transferencia)</param>
        /// <returns>Task of TransferenciaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<TransferenciaDetalheResponse> Consultar_2Async (long? id, long? idTransferencia)
        {
             ApiResponse<TransferenciaDetalheResponse> localVarResponse = await Consultar_2AsyncWithHttpInfo(id, idTransferencia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta os detalhes de uma determinada transfer\u00EAncia Este m\u00E9todo permite consultar os detalhes de uma determinada transfer\u00EAncia de cr\u00E9dito realizada entre contas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idTransferencia">C\u00F3digo de Identifica\u00E7\u00E3o da transfer\u00EAncia (id_transferencia)</param>
        /// <returns>Task of ApiResponse (TransferenciaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransferenciaDetalheResponse>> Consultar_2AsyncWithHttpInfo (long? id, long? idTransferencia)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar_2");
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null) throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling Consultar_2");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransferenciaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaDetalheResponse)));
            
        }
        
        /// <summary>
        /// Cadastrar contas MultiApp Este recurso permite o cadastro de contas MultiApp
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaMultiAppPersist">contaMultiAppPersist</param> 
        /// <returns>ContaMultiAppResponse</returns>
        public ContaMultiAppResponse CriarContasMultiApp (ContaMultiAppPersist contaMultiAppPersist)
        {
             ApiResponse<ContaMultiAppResponse> localVarResponse = CriarContasMultiAppWithHttpInfo(contaMultiAppPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastrar contas MultiApp Este recurso permite o cadastro de contas MultiApp
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaMultiAppPersist">contaMultiAppPersist</param> 
        /// <returns>ApiResponse of ContaMultiAppResponse</returns>
        public ApiResponse< ContaMultiAppResponse > CriarContasMultiAppWithHttpInfo (ContaMultiAppPersist contaMultiAppPersist)
        {
            
            // verify the required parameter 'contaMultiAppPersist' is set
            if (contaMultiAppPersist == null)
                throw new ApiException(400, "Missing required parameter 'contaMultiAppPersist' when calling ContaApi->CriarContasMultiApp");
            
    
            var localVarPath = "/api/contas/cadastrar-conta-multiapp";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (contaMultiAppPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contaMultiAppPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contaMultiAppPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CriarContasMultiApp: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CriarContasMultiApp: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaMultiAppResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaMultiAppResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaMultiAppResponse)));
            
        }

        
        /// <summary>
        /// Cadastrar contas MultiApp Este recurso permite o cadastro de contas MultiApp
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaMultiAppPersist">contaMultiAppPersist</param>
        /// <returns>Task of ContaMultiAppResponse</returns>
        public async System.Threading.Tasks.Task<ContaMultiAppResponse> CriarContasMultiAppAsync (ContaMultiAppPersist contaMultiAppPersist)
        {
             ApiResponse<ContaMultiAppResponse> localVarResponse = await CriarContasMultiAppAsyncWithHttpInfo(contaMultiAppPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastrar contas MultiApp Este recurso permite o cadastro de contas MultiApp
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaMultiAppPersist">contaMultiAppPersist</param>
        /// <returns>Task of ApiResponse (ContaMultiAppResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaMultiAppResponse>> CriarContasMultiAppAsyncWithHttpInfo (ContaMultiAppPersist contaMultiAppPersist)
        {
            // verify the required parameter 'contaMultiAppPersist' is set
            if (contaMultiAppPersist == null) throw new ApiException(400, "Missing required parameter 'contaMultiAppPersist' when calling CriarContasMultiApp");
            
    
            var localVarPath = "/api/contas/cadastrar-conta-multiapp";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (contaMultiAppPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contaMultiAppPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contaMultiAppPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CriarContasMultiApp: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CriarContasMultiApp: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaMultiAppResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaMultiAppResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaMultiAppResponse)));
            
        }
        
        /// <summary>
        /// Desativa o servi\u00E7o de envio de fatura por email Este recurso desativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <returns>Object</returns>
        public Object DesativarEnvioFaturaEmail (long? id)
        {
             ApiResponse<Object> localVarResponse = DesativarEnvioFaturaEmailWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Desativa o servi\u00E7o de envio de fatura por email Este recurso desativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > DesativarEnvioFaturaEmailWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->DesativarEnvioFaturaEmail");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesativarEnvioFaturaEmail: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarEnvioFaturaEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Desativa o servi\u00E7o de envio de fatura por email Este recurso desativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> DesativarEnvioFaturaEmailAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await DesativarEnvioFaturaEmailAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Desativa o servi\u00E7o de envio de fatura por email Este recurso desativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DesativarEnvioFaturaEmailAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesativarEnvioFaturaEmail");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesativarEnvioFaturaEmail: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarEnvioFaturaEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public BoletoResponse GerarBoletoRecarga (long? id, double? valor, string dataVencimento)
        {
             ApiResponse<BoletoResponse> localVarResponse = GerarBoletoRecargaWithHttpInfo(id, valor, dataVencimento);
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
        public ApiResponse< BoletoResponse > GerarBoletoRecargaWithHttpInfo (long? id, double? valor, string dataVencimento)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->GerarBoletoRecarga");
            
            // verify the required parameter 'valor' is set
            if (valor == null)
                throw new ApiException(400, "Missing required parameter 'valor' when calling ContaApi->GerarBoletoRecarga");
            
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null)
                throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling ContaApi->GerarBoletoRecarga");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoRecarga: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoRecarga: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<BoletoResponse> GerarBoletoRecargaAsync (long? id, double? valor, string dataVencimento)
        {
             ApiResponse<BoletoResponse> localVarResponse = await GerarBoletoRecargaAsyncWithHttpInfo(id, valor, dataVencimento);
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
        public async System.Threading.Tasks.Task<ApiResponse<BoletoResponse>> GerarBoletoRecargaAsyncWithHttpInfo (long? id, double? valor, string dataVencimento)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GerarBoletoRecarga");
            // verify the required parameter 'valor' is set
            if (valor == null) throw new ApiException(400, "Missing required parameter 'valor' when calling GerarBoletoRecarga");
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null) throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling GerarBoletoRecarga");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoRecarga: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoRecarga: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoResponse)));
            
        }
        
        /// <summary>
        /// Realiza a gera\u00E7\u00E3o de um novo cart\u00E3o para impress\u00E3o avulsa Este recurso permite que seja gerado um novo Cart\u00E3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00E3o que dever\u00E1 ser gerado para impress\u00E3o. Esta funcionalidade poder\u00E1 ser utilizada para realizar a impress\u00E3o de cart\u00F5es em Lojas, Quiosques, Escrit\u00F3rios, Terminais de Auto Atendimento, ou outro local que o Emissor escolher, desde que se possua uma impressora de Cart\u00F5es habilidade para o fazer, no local
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="idPessoa">C\u00F3digo de identifica\u00E7\u00E3o da pessoa (id)</param> 
        /// <param name="idTipoPlastico">C\u00F3digo de identifica\u00E7\u00E3o do TipoPlastico (id) (optional)</param> 
        /// <returns>CartaoImpressaoResponse</returns>
        public CartaoImpressaoResponse GerarCartao (long? id, long? idPessoa, long? idTipoPlastico = null)
        {
             ApiResponse<CartaoImpressaoResponse> localVarResponse = GerarCartaoWithHttpInfo(id, idPessoa, idTipoPlastico);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a gera\u00E7\u00E3o de um novo cart\u00E3o para impress\u00E3o avulsa Este recurso permite que seja gerado um novo Cart\u00E3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00E3o que dever\u00E1 ser gerado para impress\u00E3o. Esta funcionalidade poder\u00E1 ser utilizada para realizar a impress\u00E3o de cart\u00F5es em Lojas, Quiosques, Escrit\u00F3rios, Terminais de Auto Atendimento, ou outro local que o Emissor escolher, desde que se possua uma impressora de Cart\u00F5es habilidade para o fazer, no local
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="idPessoa">C\u00F3digo de identifica\u00E7\u00E3o da pessoa (id)</param> 
        /// <param name="idTipoPlastico">C\u00F3digo de identifica\u00E7\u00E3o do TipoPlastico (id) (optional)</param> 
        /// <returns>ApiResponse of CartaoImpressaoResponse</returns>
        public ApiResponse< CartaoImpressaoResponse > GerarCartaoWithHttpInfo (long? id, long? idPessoa, long? idTipoPlastico = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->GerarCartao");
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling ContaApi->GerarCartao");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GerarCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoImpressaoResponse)));
            
        }

        
        /// <summary>
        /// Realiza a gera\u00E7\u00E3o de um novo cart\u00E3o para impress\u00E3o avulsa Este recurso permite que seja gerado um novo Cart\u00E3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00E3o que dever\u00E1 ser gerado para impress\u00E3o. Esta funcionalidade poder\u00E1 ser utilizada para realizar a impress\u00E3o de cart\u00F5es em Lojas, Quiosques, Escrit\u00F3rios, Terminais de Auto Atendimento, ou outro local que o Emissor escolher, desde que se possua uma impressora de Cart\u00F5es habilidade para o fazer, no local
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <param name="idTipoPlastico">C\u00F3digo de identifica\u00E7\u00E3o do TipoPlastico (id) (optional)</param>
        /// <returns>Task of CartaoImpressaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoImpressaoResponse> GerarCartaoAsync (long? id, long? idPessoa, long? idTipoPlastico = null)
        {
             ApiResponse<CartaoImpressaoResponse> localVarResponse = await GerarCartaoAsyncWithHttpInfo(id, idPessoa, idTipoPlastico);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a gera\u00E7\u00E3o de um novo cart\u00E3o para impress\u00E3o avulsa Este recurso permite que seja gerado um novo Cart\u00E3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00E3o que dever\u00E1 ser gerado para impress\u00E3o. Esta funcionalidade poder\u00E1 ser utilizada para realizar a impress\u00E3o de cart\u00F5es em Lojas, Quiosques, Escrit\u00F3rios, Terminais de Auto Atendimento, ou outro local que o Emissor escolher, desde que se possua uma impressora de Cart\u00F5es habilidade para o fazer, no local
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <param name="idTipoPlastico">C\u00F3digo de identifica\u00E7\u00E3o do TipoPlastico (id) (optional)</param>
        /// <returns>Task of ApiResponse (CartaoImpressaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoImpressaoResponse>> GerarCartaoAsyncWithHttpInfo (long? id, long? idPessoa, long? idTipoPlastico = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GerarCartao");
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling GerarCartao");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GerarCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoImpressaoResponse)));
            
        }
        
        /// <summary>
        /// Realiza o envio para gera\u00E7\u00E3o de um novo cart\u00E3o na gr\u00E1fica Este recurso permite que seja gerado um novo Cart\u00E3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00E3o que dever\u00E1 ser gerado para impress\u00E3o. Esta funcionalidade poder\u00E1 ser utilizada para impress\u00E3o de cart\u00F5es em gr\u00E1fica
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="cartaoEmbossingRequest">cartaoEmbossingRequest</param> 
        /// <returns>CartaoEmbossingResponse</returns>
        public CartaoEmbossingResponse GerarCartaoEmbossing (long? id, CartaoEmbossingRequest cartaoEmbossingRequest)
        {
             ApiResponse<CartaoEmbossingResponse> localVarResponse = GerarCartaoEmbossingWithHttpInfo(id, cartaoEmbossingRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o envio para gera\u00E7\u00E3o de um novo cart\u00E3o na gr\u00E1fica Este recurso permite que seja gerado um novo Cart\u00E3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00E3o que dever\u00E1 ser gerado para impress\u00E3o. Esta funcionalidade poder\u00E1 ser utilizada para impress\u00E3o de cart\u00F5es em gr\u00E1fica
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="cartaoEmbossingRequest">cartaoEmbossingRequest</param> 
        /// <returns>ApiResponse of CartaoEmbossingResponse</returns>
        public ApiResponse< CartaoEmbossingResponse > GerarCartaoEmbossingWithHttpInfo (long? id, CartaoEmbossingRequest cartaoEmbossingRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->GerarCartaoEmbossing");
            
            // verify the required parameter 'cartaoEmbossingRequest' is set
            if (cartaoEmbossingRequest == null)
                throw new ApiException(400, "Missing required parameter 'cartaoEmbossingRequest' when calling ContaApi->GerarCartaoEmbossing");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoEmbossing: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoEmbossing: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoEmbossingResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoEmbossingResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoEmbossingResponse)));
            
        }

        
        /// <summary>
        /// Realiza o envio para gera\u00E7\u00E3o de um novo cart\u00E3o na gr\u00E1fica Este recurso permite que seja gerado um novo Cart\u00E3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00E3o que dever\u00E1 ser gerado para impress\u00E3o. Esta funcionalidade poder\u00E1 ser utilizada para impress\u00E3o de cart\u00F5es em gr\u00E1fica
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="cartaoEmbossingRequest">cartaoEmbossingRequest</param>
        /// <returns>Task of CartaoEmbossingResponse</returns>
        public async System.Threading.Tasks.Task<CartaoEmbossingResponse> GerarCartaoEmbossingAsync (long? id, CartaoEmbossingRequest cartaoEmbossingRequest)
        {
             ApiResponse<CartaoEmbossingResponse> localVarResponse = await GerarCartaoEmbossingAsyncWithHttpInfo(id, cartaoEmbossingRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o envio para gera\u00E7\u00E3o de um novo cart\u00E3o na gr\u00E1fica Este recurso permite que seja gerado um novo Cart\u00E3o para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id), o idPessoa do Portador e o idTipoPlastico do Cart\u00E3o que dever\u00E1 ser gerado para impress\u00E3o. Esta funcionalidade poder\u00E1 ser utilizada para impress\u00E3o de cart\u00F5es em gr\u00E1fica
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="cartaoEmbossingRequest">cartaoEmbossingRequest</param>
        /// <returns>Task of ApiResponse (CartaoEmbossingResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoEmbossingResponse>> GerarCartaoEmbossingAsyncWithHttpInfo (long? id, CartaoEmbossingRequest cartaoEmbossingRequest)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GerarCartaoEmbossing");
            // verify the required parameter 'cartaoEmbossingRequest' is set
            if (cartaoEmbossingRequest == null) throw new ApiException(400, "Missing required parameter 'cartaoEmbossingRequest' when calling GerarCartaoEmbossing");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoEmbossing: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoEmbossing: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoEmbossingResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoEmbossingResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoEmbossingResponse)));
            
        }
        
        /// <summary>
        /// Realiza a gera\u00E7\u00E3o de um cart\u00E3o provisorio Este recurso permite que seja gerado um cart\u00E3o provis\u00F3rio para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <returns>CartaoImpressaoProvisorioResponse</returns>
        public CartaoImpressaoProvisorioResponse GerarCartaoProvisorio (long? id)
        {
             ApiResponse<CartaoImpressaoProvisorioResponse> localVarResponse = GerarCartaoProvisorioWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a gera\u00E7\u00E3o de um cart\u00E3o provisorio Este recurso permite que seja gerado um cart\u00E3o provis\u00F3rio para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <returns>ApiResponse of CartaoImpressaoProvisorioResponse</returns>
        public ApiResponse< CartaoImpressaoProvisorioResponse > GerarCartaoProvisorioWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->GerarCartaoProvisorio");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoProvisorio: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoProvisorio: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoImpressaoProvisorioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoImpressaoProvisorioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoImpressaoProvisorioResponse)));
            
        }

        
        /// <summary>
        /// Realiza a gera\u00E7\u00E3o de um cart\u00E3o provisorio Este recurso permite que seja gerado um cart\u00E3o provis\u00F3rio para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of CartaoImpressaoProvisorioResponse</returns>
        public async System.Threading.Tasks.Task<CartaoImpressaoProvisorioResponse> GerarCartaoProvisorioAsync (long? id)
        {
             ApiResponse<CartaoImpressaoProvisorioResponse> localVarResponse = await GerarCartaoProvisorioAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a gera\u00E7\u00E3o de um cart\u00E3o provisorio Este recurso permite que seja gerado um cart\u00E3o provis\u00F3rio para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of ApiResponse (CartaoImpressaoProvisorioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoImpressaoProvisorioResponse>> GerarCartaoProvisorioAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GerarCartaoProvisorio");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoProvisorio: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoProvisorio: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoImpressaoProvisorioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoImpressaoProvisorioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoImpressaoProvisorioResponse)));
            
        }
        
        /// <summary>
        /// Realiza a gera\u00E7\u00E3o de um cart\u00E3o virtual Este recurso permite que seja gerado um Cart\u00E3o virtual para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id). Esta funcionalidade poder\u00E1 ser utilizada para realizar a cria\u00E7\u00E3o de cart\u00F5es virtuaes atraves de um app
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="dataValidade">Data de Validade</param> 
        /// <returns>CartaoImpressaoResponse</returns>
        public CartaoImpressaoResponse GerarCartaoVirtual (long? id, string dataValidade)
        {
             ApiResponse<CartaoImpressaoResponse> localVarResponse = GerarCartaoVirtualWithHttpInfo(id, dataValidade);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a gera\u00E7\u00E3o de um cart\u00E3o virtual Este recurso permite que seja gerado um Cart\u00E3o virtual para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id). Esta funcionalidade poder\u00E1 ser utilizada para realizar a cria\u00E7\u00E3o de cart\u00F5es virtuaes atraves de um app
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="dataValidade">Data de Validade</param> 
        /// <returns>ApiResponse of CartaoImpressaoResponse</returns>
        public ApiResponse< CartaoImpressaoResponse > GerarCartaoVirtualWithHttpInfo (long? id, string dataValidade)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->GerarCartaoVirtual");
            
            // verify the required parameter 'dataValidade' is set
            if (dataValidade == null)
                throw new ApiException(400, "Missing required parameter 'dataValidade' when calling ContaApi->GerarCartaoVirtual");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoVirtual: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoVirtual: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoImpressaoResponse)));
            
        }

        
        /// <summary>
        /// Realiza a gera\u00E7\u00E3o de um cart\u00E3o virtual Este recurso permite que seja gerado um Cart\u00E3o virtual para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id). Esta funcionalidade poder\u00E1 ser utilizada para realizar a cria\u00E7\u00E3o de cart\u00F5es virtuaes atraves de um app
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="dataValidade">Data de Validade</param>
        /// <returns>Task of CartaoImpressaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoImpressaoResponse> GerarCartaoVirtualAsync (long? id, string dataValidade)
        {
             ApiResponse<CartaoImpressaoResponse> localVarResponse = await GerarCartaoVirtualAsyncWithHttpInfo(id, dataValidade);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a gera\u00E7\u00E3o de um cart\u00E3o virtual Este recurso permite que seja gerado um Cart\u00E3o virtual para um determinado Portador que esteja vinculado a uma Conta. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id). Esta funcionalidade poder\u00E1 ser utilizada para realizar a cria\u00E7\u00E3o de cart\u00F5es virtuaes atraves de um app
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="dataValidade">Data de Validade</param>
        /// <returns>Task of ApiResponse (CartaoImpressaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoImpressaoResponse>> GerarCartaoVirtualAsyncWithHttpInfo (long? id, string dataValidade)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GerarCartaoVirtual");
            // verify the required parameter 'dataValidade' is set
            if (dataValidade == null) throw new ApiException(400, "Missing required parameter 'dataValidade' when calling GerarCartaoVirtual");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoVirtual: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoVirtual: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoImpressaoResponse)));
            
        }
        
        /// <summary>
        /// Lista contas existentes na base de dados do Emissor Este recurso permite listar contas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto ao qual a conta faz parte. (id) (optional)</param> 
        /// <param name="idOrigemComercial">C\u00F3digo de Identifica\u00E7\u00E3o da Origem Comercial (id) que deu origem a Conta (optional)</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa Titular da Conta (id) (optional)</param> 
        /// <param name="idStatusConta">C\u00F3digo de Identifica\u00E7\u00E3o do status da conta (optional)</param> 
        /// <param name="diaVencimento">Apresenta o dia de vencimento (optional)</param> 
        /// <param name="melhorDiaCompra">Apresenta o melhor dia de compra (optional)</param> 
        /// <param name="dataStatusConta">Apresenta a data em que o idStatusConta atual fora atribu\u00EDdo para ela (optional)</param> 
        /// <param name="dataCadastro">Apresenta a data em que o cart\u00E3o foi gerado (optional)</param> 
        /// <param name="dataUltimaAlteracaoVencimento">Apresenta a data da ultima altera\u00E7\u00E3o de vencimento (optional)</param> 
        /// <param name="funcaoAtiva"> (optional)</param> 
        /// <returns>PageContaResponse</returns>
        public PageContaResponse Listar (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, string dataStatusConta = null, string dataCadastro = null, string dataUltimaAlteracaoVencimento = null, string funcaoAtiva = null)
        {
             ApiResponse<PageContaResponse> localVarResponse = ListarWithHttpInfo(sort, page, limit, idProduto, idOrigemComercial, idPessoa, idStatusConta, diaVencimento, melhorDiaCompra, dataStatusConta, dataCadastro, dataUltimaAlteracaoVencimento, funcaoAtiva);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista contas existentes na base de dados do Emissor Este recurso permite listar contas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto ao qual a conta faz parte. (id) (optional)</param> 
        /// <param name="idOrigemComercial">C\u00F3digo de Identifica\u00E7\u00E3o da Origem Comercial (id) que deu origem a Conta (optional)</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa Titular da Conta (id) (optional)</param> 
        /// <param name="idStatusConta">C\u00F3digo de Identifica\u00E7\u00E3o do status da conta (optional)</param> 
        /// <param name="diaVencimento">Apresenta o dia de vencimento (optional)</param> 
        /// <param name="melhorDiaCompra">Apresenta o melhor dia de compra (optional)</param> 
        /// <param name="dataStatusConta">Apresenta a data em que o idStatusConta atual fora atribu\u00EDdo para ela (optional)</param> 
        /// <param name="dataCadastro">Apresenta a data em que o cart\u00E3o foi gerado (optional)</param> 
        /// <param name="dataUltimaAlteracaoVencimento">Apresenta a data da ultima altera\u00E7\u00E3o de vencimento (optional)</param> 
        /// <param name="funcaoAtiva"> (optional)</param> 
        /// <returns>ApiResponse of PageContaResponse</returns>
        public ApiResponse< PageContaResponse > ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, string dataStatusConta = null, string dataCadastro = null, string dataUltimaAlteracaoVencimento = null, string funcaoAtiva = null)
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
            if (funcaoAtiva != null) localVarQueryParams.Add("funcaoAtiva", Configuration.ApiClient.ParameterToString(funcaoAtiva)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaResponse)));
            
        }

        
        /// <summary>
        /// Lista contas existentes na base de dados do Emissor Este recurso permite listar contas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto ao qual a conta faz parte. (id) (optional)</param>
        /// <param name="idOrigemComercial">C\u00F3digo de Identifica\u00E7\u00E3o da Origem Comercial (id) que deu origem a Conta (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa Titular da Conta (id) (optional)</param>
        /// <param name="idStatusConta">C\u00F3digo de Identifica\u00E7\u00E3o do status da conta (optional)</param>
        /// <param name="diaVencimento">Apresenta o dia de vencimento (optional)</param>
        /// <param name="melhorDiaCompra">Apresenta o melhor dia de compra (optional)</param>
        /// <param name="dataStatusConta">Apresenta a data em que o idStatusConta atual fora atribu\u00EDdo para ela (optional)</param>
        /// <param name="dataCadastro">Apresenta a data em que o cart\u00E3o foi gerado (optional)</param>
        /// <param name="dataUltimaAlteracaoVencimento">Apresenta a data da ultima altera\u00E7\u00E3o de vencimento (optional)</param>
        /// <param name="funcaoAtiva"> (optional)</param>
        /// <returns>Task of PageContaResponse</returns>
        public async System.Threading.Tasks.Task<PageContaResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, string dataStatusConta = null, string dataCadastro = null, string dataUltimaAlteracaoVencimento = null, string funcaoAtiva = null)
        {
             ApiResponse<PageContaResponse> localVarResponse = await ListarAsyncWithHttpInfo(sort, page, limit, idProduto, idOrigemComercial, idPessoa, idStatusConta, diaVencimento, melhorDiaCompra, dataStatusConta, dataCadastro, dataUltimaAlteracaoVencimento, funcaoAtiva);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista contas existentes na base de dados do Emissor Este recurso permite listar contas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto ao qual a conta faz parte. (id) (optional)</param>
        /// <param name="idOrigemComercial">C\u00F3digo de Identifica\u00E7\u00E3o da Origem Comercial (id) que deu origem a Conta (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa Titular da Conta (id) (optional)</param>
        /// <param name="idStatusConta">C\u00F3digo de Identifica\u00E7\u00E3o do status da conta (optional)</param>
        /// <param name="diaVencimento">Apresenta o dia de vencimento (optional)</param>
        /// <param name="melhorDiaCompra">Apresenta o melhor dia de compra (optional)</param>
        /// <param name="dataStatusConta">Apresenta a data em que o idStatusConta atual fora atribu\u00EDdo para ela (optional)</param>
        /// <param name="dataCadastro">Apresenta a data em que o cart\u00E3o foi gerado (optional)</param>
        /// <param name="dataUltimaAlteracaoVencimento">Apresenta a data da ultima altera\u00E7\u00E3o de vencimento (optional)</param>
        /// <param name="funcaoAtiva"> (optional)</param>
        /// <returns>Task of ApiResponse (PageContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageContaResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, string dataStatusConta = null, string dataCadastro = null, string dataUltimaAlteracaoVencimento = null, string funcaoAtiva = null)
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
            if (funcaoAtiva != null) localVarQueryParams.Add("funcaoAtiva", Configuration.ApiClient.ParameterToString(funcaoAtiva)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaResponse)));
            
        }
        
        /// <summary>
        /// Lista o hist\u00F3rico de altera\u00E7\u00F5es de limites da conta Este recurso consulta o hist\u00F3rico com as altera\u00E7\u00F5es de limites da conta informada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageHistoricoEventosResponse</returns>
        public PageHistoricoEventosResponse ListarHistoricoAlteracoesLimites (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageHistoricoEventosResponse> localVarResponse = ListarHistoricoAlteracoesLimitesWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista o hist\u00F3rico de altera\u00E7\u00F5es de limites da conta Este recurso consulta o hist\u00F3rico com as altera\u00E7\u00F5es de limites da conta informada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageHistoricoEventosResponse</returns>
        public ApiResponse< PageHistoricoEventosResponse > ListarHistoricoAlteracoesLimitesWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ListarHistoricoAlteracoesLimites");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAlteracoesLimites: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAlteracoesLimites: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageHistoricoEventosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoEventosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoEventosResponse)));
            
        }

        
        /// <summary>
        /// Lista o hist\u00F3rico de altera\u00E7\u00F5es de limites da conta Este recurso consulta o hist\u00F3rico com as altera\u00E7\u00F5es de limites da conta informada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageHistoricoEventosResponse</returns>
        public async System.Threading.Tasks.Task<PageHistoricoEventosResponse> ListarHistoricoAlteracoesLimitesAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageHistoricoEventosResponse> localVarResponse = await ListarHistoricoAlteracoesLimitesAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista o hist\u00F3rico de altera\u00E7\u00F5es de limites da conta Este recurso consulta o hist\u00F3rico com as altera\u00E7\u00F5es de limites da conta informada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoEventosResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageHistoricoEventosResponse>> ListarHistoricoAlteracoesLimitesAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarHistoricoAlteracoesLimites");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAlteracoesLimites: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAlteracoesLimites: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageHistoricoEventosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoEventosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoEventosResponse)));
            
        }
        
        /// <summary>
        /// Lista o hist\u00F3rico de entradas/sa\u00EDdas de assessorias de cobran\u00E7a Permite listar todos os registros de entrada e sa\u00EDda da Conta em arquivos de integra\u00E7\u00E3o com empresas de assessorias de cobran\u00E7a a partir do c\u00F3digo de identifica\u00E7\u00E3o da conta (idConta)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageHistoricoAssessoriaResponse</returns>
        public PageHistoricoAssessoriaResponse ListarHistoricoAssessoria (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageHistoricoAssessoriaResponse> localVarResponse = ListarHistoricoAssessoriaWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista o hist\u00F3rico de entradas/sa\u00EDdas de assessorias de cobran\u00E7a Permite listar todos os registros de entrada e sa\u00EDda da Conta em arquivos de integra\u00E7\u00E3o com empresas de assessorias de cobran\u00E7a a partir do c\u00F3digo de identifica\u00E7\u00E3o da conta (idConta)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageHistoricoAssessoriaResponse</returns>
        public ApiResponse< PageHistoricoAssessoriaResponse > ListarHistoricoAssessoriaWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ListarHistoricoAssessoria");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAssessoria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAssessoria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageHistoricoAssessoriaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoAssessoriaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoAssessoriaResponse)));
            
        }

        
        /// <summary>
        /// Lista o hist\u00F3rico de entradas/sa\u00EDdas de assessorias de cobran\u00E7a Permite listar todos os registros de entrada e sa\u00EDda da Conta em arquivos de integra\u00E7\u00E3o com empresas de assessorias de cobran\u00E7a a partir do c\u00F3digo de identifica\u00E7\u00E3o da conta (idConta)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageHistoricoAssessoriaResponse</returns>
        public async System.Threading.Tasks.Task<PageHistoricoAssessoriaResponse> ListarHistoricoAssessoriaAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageHistoricoAssessoriaResponse> localVarResponse = await ListarHistoricoAssessoriaAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista o hist\u00F3rico de entradas/sa\u00EDdas de assessorias de cobran\u00E7a Permite listar todos os registros de entrada e sa\u00EDda da Conta em arquivos de integra\u00E7\u00E3o com empresas de assessorias de cobran\u00E7a a partir do c\u00F3digo de identifica\u00E7\u00E3o da conta (idConta)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoAssessoriaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageHistoricoAssessoriaResponse>> ListarHistoricoAssessoriaAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarHistoricoAssessoria");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAssessoria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAssessoria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageHistoricoAssessoriaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoAssessoriaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoAssessoriaResponse)));
            
        }
        
        /// <summary>
        /// Lista o historico de atrasos das faturas Este recurso lista o hist\u00F3rico do pagamento de faturas em atraso
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageHistoricoAtrasoFaturaResponse</returns>
        public PageHistoricoAtrasoFaturaResponse ListarHistoricoAtrasosFaturas (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageHistoricoAtrasoFaturaResponse> localVarResponse = ListarHistoricoAtrasosFaturasWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista o historico de atrasos das faturas Este recurso lista o hist\u00F3rico do pagamento de faturas em atraso
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageHistoricoAtrasoFaturaResponse</returns>
        public ApiResponse< PageHistoricoAtrasoFaturaResponse > ListarHistoricoAtrasosFaturasWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ListarHistoricoAtrasosFaturas");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAtrasosFaturas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAtrasosFaturas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageHistoricoAtrasoFaturaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoAtrasoFaturaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoAtrasoFaturaResponse)));
            
        }

        
        /// <summary>
        /// Lista o historico de atrasos das faturas Este recurso lista o hist\u00F3rico do pagamento de faturas em atraso
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageHistoricoAtrasoFaturaResponse</returns>
        public async System.Threading.Tasks.Task<PageHistoricoAtrasoFaturaResponse> ListarHistoricoAtrasosFaturasAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageHistoricoAtrasoFaturaResponse> localVarResponse = await ListarHistoricoAtrasosFaturasAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista o historico de atrasos das faturas Este recurso lista o hist\u00F3rico do pagamento de faturas em atraso
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoAtrasoFaturaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageHistoricoAtrasoFaturaResponse>> ListarHistoricoAtrasosFaturasAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarHistoricoAtrasosFaturas");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAtrasosFaturas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAtrasosFaturas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageHistoricoAtrasoFaturaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoAtrasoFaturaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoAtrasoFaturaResponse)));
            
        }
        
        /// <summary>
        /// Lista as transa\u00E7\u00F5es n\u00E3o processadas da conta Este m\u00E9todo permite que sejam listadas todas as transa\u00E7\u00F5es n\u00E3o processadas da Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="dataInicio">Data de in\u00EDcio da consulta do extrato no formato yyyy-MM-dd (Par\u00E2mentro Ignorado se dataFim n\u00E3o for definida) (optional)</param> 
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Par\u00E2mentro Ignorado se dataInicio n\u00E3o for definida) (optional)</param> 
        /// <returns>PageTransacaoNaoProcessadaResponse</returns>
        public PageTransacaoNaoProcessadaResponse ListarNaoProcessadas (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null)
        {
             ApiResponse<PageTransacaoNaoProcessadaResponse> localVarResponse = ListarNaoProcessadasWithHttpInfo(id, sort, page, limit, dataInicio, dataFim);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as transa\u00E7\u00F5es n\u00E3o processadas da conta Este m\u00E9todo permite que sejam listadas todas as transa\u00E7\u00F5es n\u00E3o processadas da Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="dataInicio">Data de in\u00EDcio da consulta do extrato no formato yyyy-MM-dd (Par\u00E2mentro Ignorado se dataFim n\u00E3o for definida) (optional)</param> 
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Par\u00E2mentro Ignorado se dataInicio n\u00E3o for definida) (optional)</param> 
        /// <returns>ApiResponse of PageTransacaoNaoProcessadaResponse</returns>
        public ApiResponse< PageTransacaoNaoProcessadaResponse > ListarNaoProcessadasWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ListarNaoProcessadas");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarNaoProcessadas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarNaoProcessadas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTransacaoNaoProcessadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacaoNaoProcessadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacaoNaoProcessadaResponse)));
            
        }

        
        /// <summary>
        /// Lista as transa\u00E7\u00F5es n\u00E3o processadas da conta Este m\u00E9todo permite que sejam listadas todas as transa\u00E7\u00F5es n\u00E3o processadas da Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataInicio">Data de in\u00EDcio da consulta do extrato no formato yyyy-MM-dd (Par\u00E2mentro Ignorado se dataFim n\u00E3o for definida) (optional)</param>
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Par\u00E2mentro Ignorado se dataInicio n\u00E3o for definida) (optional)</param>
        /// <returns>Task of PageTransacaoNaoProcessadaResponse</returns>
        public async System.Threading.Tasks.Task<PageTransacaoNaoProcessadaResponse> ListarNaoProcessadasAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null)
        {
             ApiResponse<PageTransacaoNaoProcessadaResponse> localVarResponse = await ListarNaoProcessadasAsyncWithHttpInfo(id, sort, page, limit, dataInicio, dataFim);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as transa\u00E7\u00F5es n\u00E3o processadas da conta Este m\u00E9todo permite que sejam listadas todas as transa\u00E7\u00F5es n\u00E3o processadas da Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataInicio">Data de in\u00EDcio da consulta do extrato no formato yyyy-MM-dd (Par\u00E2mentro Ignorado se dataFim n\u00E3o for definida) (optional)</param>
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Par\u00E2mentro Ignorado se dataInicio n\u00E3o for definida) (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacaoNaoProcessadaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransacaoNaoProcessadaResponse>> ListarNaoProcessadasAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarNaoProcessadas");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarNaoProcessadas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarNaoProcessadas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTransacaoNaoProcessadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacaoNaoProcessadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacaoNaoProcessadaResponse)));
            
        }
        
        /// <summary>
        /// Lista as transa\u00E7\u00F5es processadas da conta Este m\u00E9todo permite que sejam listadas todas as transa\u00E7\u00F5es processadas da Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id).</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="dataVencimento">Data de vencimento do extrato no formato yyyy-MM-dd (optional)</param> 
        /// <param name="dataInicio">Data de in\u00EDcio da consulta do extrato no formato yyyy-MM-dd (Ignorado quando o par\u00E2mentro dataVencimento \u00E9 usado) (optional)</param> 
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Ignorado quando o par\u00E2mentro dataVencimento \u00E9 usado) (optional)</param> 
        /// <param name="idTipoTransacao">transacoes_processadas_request_tipo_transacao (optional)</param> 
        /// <param name="recuperaEncargos">Adiciona as transa\u00E7\u00F5es de encargos na consulta (optional)</param> 
        /// <returns>PageTransacoesCorrentesResponse</returns>
        public PageTransacoesCorrentesResponse ListarProcessadas (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, int? recuperaEncargos = null)
        {
             ApiResponse<PageTransacoesCorrentesResponse> localVarResponse = ListarProcessadasWithHttpInfo(id, sort, page, limit, dataVencimento, dataInicio, dataFim, idTipoTransacao, recuperaEncargos);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as transa\u00E7\u00F5es processadas da conta Este m\u00E9todo permite que sejam listadas todas as transa\u00E7\u00F5es processadas da Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id).</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="dataVencimento">Data de vencimento do extrato no formato yyyy-MM-dd (optional)</param> 
        /// <param name="dataInicio">Data de in\u00EDcio da consulta do extrato no formato yyyy-MM-dd (Ignorado quando o par\u00E2mentro dataVencimento \u00E9 usado) (optional)</param> 
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Ignorado quando o par\u00E2mentro dataVencimento \u00E9 usado) (optional)</param> 
        /// <param name="idTipoTransacao">transacoes_processadas_request_tipo_transacao (optional)</param> 
        /// <param name="recuperaEncargos">Adiciona as transa\u00E7\u00F5es de encargos na consulta (optional)</param> 
        /// <returns>ApiResponse of PageTransacoesCorrentesResponse</returns>
        public ApiResponse< PageTransacoesCorrentesResponse > ListarProcessadasWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, int? recuperaEncargos = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->ListarProcessadas");
            
    
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
            if (idTipoTransacao != null) localVarQueryParams.Add("idTipoTransacao", Configuration.ApiClient.ParameterToString(idTipoTransacao)); // query parameter
            if (recuperaEncargos != null) localVarQueryParams.Add("recuperaEncargos", Configuration.ApiClient.ParameterToString(recuperaEncargos)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarProcessadas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarProcessadas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTransacoesCorrentesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacoesCorrentesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacoesCorrentesResponse)));
            
        }

        
        /// <summary>
        /// Lista as transa\u00E7\u00F5es processadas da conta Este m\u00E9todo permite que sejam listadas todas as transa\u00E7\u00F5es processadas da Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Data de vencimento do extrato no formato yyyy-MM-dd (optional)</param>
        /// <param name="dataInicio">Data de in\u00EDcio da consulta do extrato no formato yyyy-MM-dd (Ignorado quando o par\u00E2mentro dataVencimento \u00E9 usado) (optional)</param>
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Ignorado quando o par\u00E2mentro dataVencimento \u00E9 usado) (optional)</param>
        /// <param name="idTipoTransacao">transacoes_processadas_request_tipo_transacao (optional)</param>
        /// <param name="recuperaEncargos">Adiciona as transa\u00E7\u00F5es de encargos na consulta (optional)</param>
        /// <returns>Task of PageTransacoesCorrentesResponse</returns>
        public async System.Threading.Tasks.Task<PageTransacoesCorrentesResponse> ListarProcessadasAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, int? recuperaEncargos = null)
        {
             ApiResponse<PageTransacoesCorrentesResponse> localVarResponse = await ListarProcessadasAsyncWithHttpInfo(id, sort, page, limit, dataVencimento, dataInicio, dataFim, idTipoTransacao, recuperaEncargos);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as transa\u00E7\u00F5es processadas da conta Este m\u00E9todo permite que sejam listadas todas as transa\u00E7\u00F5es processadas da Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Data de vencimento do extrato no formato yyyy-MM-dd (optional)</param>
        /// <param name="dataInicio">Data de in\u00EDcio da consulta do extrato no formato yyyy-MM-dd (Ignorado quando o par\u00E2mentro dataVencimento \u00E9 usado) (optional)</param>
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Ignorado quando o par\u00E2mentro dataVencimento \u00E9 usado) (optional)</param>
        /// <param name="idTipoTransacao">transacoes_processadas_request_tipo_transacao (optional)</param>
        /// <param name="recuperaEncargos">Adiciona as transa\u00E7\u00F5es de encargos na consulta (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacoesCorrentesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransacoesCorrentesResponse>> ListarProcessadasAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, int? recuperaEncargos = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarProcessadas");
            
    
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
            if (idTipoTransacao != null) localVarQueryParams.Add("idTipoTransacao", Configuration.ApiClient.ParameterToString(idTipoTransacao)); // query parameter
            if (recuperaEncargos != null) localVarQueryParams.Add("recuperaEncargos", Configuration.ApiClient.ParameterToString(recuperaEncargos)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarProcessadas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarProcessadas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTransacoesCorrentesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacoesCorrentesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacoesCorrentesResponse)));
            
        }
        
        /// <summary>
        /// Lista os tipos de fun\u00E7\u00F5es para contas do Emissor Este recurso permite listar os tipos de fun\u00E7\u00F5es para as contas do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>string</returns>
        public string Listar_0 ()
        {
             ApiResponse<string> localVarResponse = Listar_0WithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os tipos de fun\u00E7\u00F5es para contas do Emissor Este recurso permite listar os tipos de fun\u00E7\u00F5es para as contas do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > Listar_0WithHttpInfo ()
        {
            
    
            var localVarPath = "/api/contas/tipos-funcoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Lista os tipos de fun\u00E7\u00F5es para contas do Emissor Este recurso permite listar os tipos de fun\u00E7\u00F5es para as contas do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> Listar_0Async ()
        {
             ApiResponse<string> localVarResponse = await Listar_0AsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os tipos de fun\u00E7\u00F5es para contas do Emissor Este recurso permite listar os tipos de fun\u00E7\u00F5es para as contas do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> Listar_0AsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/contas/tipos-funcoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Lista as transa\u00E7\u00F5es n\u00E3o processadas e processadas da conta Este m\u00E9todo permite que sejam listadas todas as transa\u00E7\u00F5es n\u00E3o processadas e processadas da Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="dataVencimento">Data de vencimento do extrato no formato yyyy-MM-dd (optional)</param> 
        /// <param name="dataInicio">Data de in\u00EDcio da consulta do extrato no formato yyyy-MM-dd (Ignorado quando o par\u00E2mentro dataVencimento \u00E9 usado) (optional)</param> 
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Ignorado quando o par\u00E2mentro dataVencimento \u00E9 usado) (optional)</param> 
        /// <param name="idTipoTransacao">transacoes_processadas_request_tipo_transacao (optional)</param> 
        /// <param name="flagCredito">Flag que indica se a transa\u00E7\u00E3o \u00E9 cr\u00E9dito (optional)</param> 
        /// <param name="flagFaturado">Flag que indica se a transa\u00E7\u00E3o foi faturada (optional)</param> 
        /// <param name="flagProcessada">Flag que indica se a transa\u00E7\u00E3o foi processada (optional)</param> 
        /// <param name="status">Status da transa\u00E7\u00E3o (optional)</param> 
        /// <param name="plano">Plano da transa\u00E7\u00E3o (optional)</param> 
        /// <param name="codigoMCC">C\u00F3digo MCC da transa\u00E7\u00E3o (optional)</param> 
        /// <param name="grupoMCC">Grupo MCC da transa\u00E7\u00E3o (optional)</param> 
        /// <returns>PageTransacaoProcessadaNaoProcessadaResponse</returns>
        public PageTransacaoProcessadaNaoProcessadaResponse Listar_1 (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, bool? flagCredito = null, bool? flagFaturado = null, bool? flagProcessada = null, int? status = null, int? plano = null, long? codigoMCC = null, long? grupoMCC = null)
        {
             ApiResponse<PageTransacaoProcessadaNaoProcessadaResponse> localVarResponse = Listar_1WithHttpInfo(id, sort, page, limit, dataVencimento, dataInicio, dataFim, idTipoTransacao, flagCredito, flagFaturado, flagProcessada, status, plano, codigoMCC, grupoMCC);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as transa\u00E7\u00F5es n\u00E3o processadas e processadas da conta Este m\u00E9todo permite que sejam listadas todas as transa\u00E7\u00F5es n\u00E3o processadas e processadas da Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="dataVencimento">Data de vencimento do extrato no formato yyyy-MM-dd (optional)</param> 
        /// <param name="dataInicio">Data de in\u00EDcio da consulta do extrato no formato yyyy-MM-dd (Ignorado quando o par\u00E2mentro dataVencimento \u00E9 usado) (optional)</param> 
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Ignorado quando o par\u00E2mentro dataVencimento \u00E9 usado) (optional)</param> 
        /// <param name="idTipoTransacao">transacoes_processadas_request_tipo_transacao (optional)</param> 
        /// <param name="flagCredito">Flag que indica se a transa\u00E7\u00E3o \u00E9 cr\u00E9dito (optional)</param> 
        /// <param name="flagFaturado">Flag que indica se a transa\u00E7\u00E3o foi faturada (optional)</param> 
        /// <param name="flagProcessada">Flag que indica se a transa\u00E7\u00E3o foi processada (optional)</param> 
        /// <param name="status">Status da transa\u00E7\u00E3o (optional)</param> 
        /// <param name="plano">Plano da transa\u00E7\u00E3o (optional)</param> 
        /// <param name="codigoMCC">C\u00F3digo MCC da transa\u00E7\u00E3o (optional)</param> 
        /// <param name="grupoMCC">Grupo MCC da transa\u00E7\u00E3o (optional)</param> 
        /// <returns>ApiResponse of PageTransacaoProcessadaNaoProcessadaResponse</returns>
        public ApiResponse< PageTransacaoProcessadaNaoProcessadaResponse > Listar_1WithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, bool? flagCredito = null, bool? flagFaturado = null, bool? flagProcessada = null, int? status = null, int? plano = null, long? codigoMCC = null, long? grupoMCC = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->Listar_1");
            
    
            var localVarPath = "/api/contas/{id}/transacoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
            if (idTipoTransacao != null) localVarQueryParams.Add("idTipoTransacao", Configuration.ApiClient.ParameterToString(idTipoTransacao)); // query parameter
            if (flagCredito != null) localVarQueryParams.Add("flagCredito", Configuration.ApiClient.ParameterToString(flagCredito)); // query parameter
            if (flagFaturado != null) localVarQueryParams.Add("flagFaturado", Configuration.ApiClient.ParameterToString(flagFaturado)); // query parameter
            if (flagProcessada != null) localVarQueryParams.Add("flagProcessada", Configuration.ApiClient.ParameterToString(flagProcessada)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (plano != null) localVarQueryParams.Add("plano", Configuration.ApiClient.ParameterToString(plano)); // query parameter
            if (codigoMCC != null) localVarQueryParams.Add("codigoMCC", Configuration.ApiClient.ParameterToString(codigoMCC)); // query parameter
            if (grupoMCC != null) localVarQueryParams.Add("grupoMCC", Configuration.ApiClient.ParameterToString(grupoMCC)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTransacaoProcessadaNaoProcessadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacaoProcessadaNaoProcessadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacaoProcessadaNaoProcessadaResponse)));
            
        }

        
        /// <summary>
        /// Lista as transa\u00E7\u00F5es n\u00E3o processadas e processadas da conta Este m\u00E9todo permite que sejam listadas todas as transa\u00E7\u00F5es n\u00E3o processadas e processadas da Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Data de vencimento do extrato no formato yyyy-MM-dd (optional)</param>
        /// <param name="dataInicio">Data de in\u00EDcio da consulta do extrato no formato yyyy-MM-dd (Ignorado quando o par\u00E2mentro dataVencimento \u00E9 usado) (optional)</param>
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Ignorado quando o par\u00E2mentro dataVencimento \u00E9 usado) (optional)</param>
        /// <param name="idTipoTransacao">transacoes_processadas_request_tipo_transacao (optional)</param>
        /// <param name="flagCredito">Flag que indica se a transa\u00E7\u00E3o \u00E9 cr\u00E9dito (optional)</param>
        /// <param name="flagFaturado">Flag que indica se a transa\u00E7\u00E3o foi faturada (optional)</param>
        /// <param name="flagProcessada">Flag que indica se a transa\u00E7\u00E3o foi processada (optional)</param>
        /// <param name="status">Status da transa\u00E7\u00E3o (optional)</param>
        /// <param name="plano">Plano da transa\u00E7\u00E3o (optional)</param>
        /// <param name="codigoMCC">C\u00F3digo MCC da transa\u00E7\u00E3o (optional)</param>
        /// <param name="grupoMCC">Grupo MCC da transa\u00E7\u00E3o (optional)</param>
        /// <returns>Task of PageTransacaoProcessadaNaoProcessadaResponse</returns>
        public async System.Threading.Tasks.Task<PageTransacaoProcessadaNaoProcessadaResponse> Listar_1Async (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, bool? flagCredito = null, bool? flagFaturado = null, bool? flagProcessada = null, int? status = null, int? plano = null, long? codigoMCC = null, long? grupoMCC = null)
        {
             ApiResponse<PageTransacaoProcessadaNaoProcessadaResponse> localVarResponse = await Listar_1AsyncWithHttpInfo(id, sort, page, limit, dataVencimento, dataInicio, dataFim, idTipoTransacao, flagCredito, flagFaturado, flagProcessada, status, plano, codigoMCC, grupoMCC);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as transa\u00E7\u00F5es n\u00E3o processadas e processadas da conta Este m\u00E9todo permite que sejam listadas todas as transa\u00E7\u00F5es n\u00E3o processadas e processadas da Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Data de vencimento do extrato no formato yyyy-MM-dd (optional)</param>
        /// <param name="dataInicio">Data de in\u00EDcio da consulta do extrato no formato yyyy-MM-dd (Ignorado quando o par\u00E2mentro dataVencimento \u00E9 usado) (optional)</param>
        /// <param name="dataFim">Data fim da consulta do extrato no formato yyyy-MM-dd  (Ignorado quando o par\u00E2mentro dataVencimento \u00E9 usado) (optional)</param>
        /// <param name="idTipoTransacao">transacoes_processadas_request_tipo_transacao (optional)</param>
        /// <param name="flagCredito">Flag que indica se a transa\u00E7\u00E3o \u00E9 cr\u00E9dito (optional)</param>
        /// <param name="flagFaturado">Flag que indica se a transa\u00E7\u00E3o foi faturada (optional)</param>
        /// <param name="flagProcessada">Flag que indica se a transa\u00E7\u00E3o foi processada (optional)</param>
        /// <param name="status">Status da transa\u00E7\u00E3o (optional)</param>
        /// <param name="plano">Plano da transa\u00E7\u00E3o (optional)</param>
        /// <param name="codigoMCC">C\u00F3digo MCC da transa\u00E7\u00E3o (optional)</param>
        /// <param name="grupoMCC">Grupo MCC da transa\u00E7\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacaoProcessadaNaoProcessadaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransacaoProcessadaNaoProcessadaResponse>> Listar_1AsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, bool? flagCredito = null, bool? flagFaturado = null, bool? flagProcessada = null, int? status = null, int? plano = null, long? codigoMCC = null, long? grupoMCC = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Listar_1");
            
    
            var localVarPath = "/api/contas/{id}/transacoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
            if (idTipoTransacao != null) localVarQueryParams.Add("idTipoTransacao", Configuration.ApiClient.ParameterToString(idTipoTransacao)); // query parameter
            if (flagCredito != null) localVarQueryParams.Add("flagCredito", Configuration.ApiClient.ParameterToString(flagCredito)); // query parameter
            if (flagFaturado != null) localVarQueryParams.Add("flagFaturado", Configuration.ApiClient.ParameterToString(flagFaturado)); // query parameter
            if (flagProcessada != null) localVarQueryParams.Add("flagProcessada", Configuration.ApiClient.ParameterToString(flagProcessada)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (plano != null) localVarQueryParams.Add("plano", Configuration.ApiClient.ParameterToString(plano)); // query parameter
            if (codigoMCC != null) localVarQueryParams.Add("codigoMCC", Configuration.ApiClient.ParameterToString(codigoMCC)); // query parameter
            if (grupoMCC != null) localVarQueryParams.Add("grupoMCC", Configuration.ApiClient.ParameterToString(grupoMCC)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTransacaoProcessadaNaoProcessadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacaoProcessadaNaoProcessadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacaoProcessadaNaoProcessadaResponse)));
            
        }
        
        /// <summary>
        /// Lista as transfer\u00EAncias realizadas pela conta Este m\u00E9todo permite que sejam listadas as transfer\u00EAncias realizadas pela conta existentes na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idTransferencia">C\u00F3digo de identifica\u00E7\u00E3o da transfer\u00EAncia (id) (optional)</param> 
        /// <param name="idContaOrigem">C\u00F3digo de identifica\u00E7\u00E3o da conta em que o valor ser\u00E1 debitado para a transfer\u00EAncia. (id) (optional)</param> 
        /// <param name="idContaDestino">C\u00F3digo de identifica\u00E7\u00E3o da conta em que o valor ser\u00E1 creditado para a transfer\u00EAncia. (id) (optional)</param> 
        /// <param name="valorTransferencia">Valor estabelecido para ser transferido (optional)</param> 
        /// <param name="dataTransferencia">Data estabelecida para ocorrer a transfer\u00EAncia (optional)</param> 
        /// <returns>PageTransferenciaResponse</returns>
        public PageTransferenciaResponse Listar_2 (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, string dataTransferencia = null)
        {
             ApiResponse<PageTransferenciaResponse> localVarResponse = Listar_2WithHttpInfo(id, sort, page, limit, idTransferencia, idContaOrigem, idContaDestino, valorTransferencia, dataTransferencia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as transfer\u00EAncias realizadas pela conta Este m\u00E9todo permite que sejam listadas as transfer\u00EAncias realizadas pela conta existentes na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idTransferencia">C\u00F3digo de identifica\u00E7\u00E3o da transfer\u00EAncia (id) (optional)</param> 
        /// <param name="idContaOrigem">C\u00F3digo de identifica\u00E7\u00E3o da conta em que o valor ser\u00E1 debitado para a transfer\u00EAncia. (id) (optional)</param> 
        /// <param name="idContaDestino">C\u00F3digo de identifica\u00E7\u00E3o da conta em que o valor ser\u00E1 creditado para a transfer\u00EAncia. (id) (optional)</param> 
        /// <param name="valorTransferencia">Valor estabelecido para ser transferido (optional)</param> 
        /// <param name="dataTransferencia">Data estabelecida para ocorrer a transfer\u00EAncia (optional)</param> 
        /// <returns>ApiResponse of PageTransferenciaResponse</returns>
        public ApiResponse< PageTransferenciaResponse > Listar_2WithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, string dataTransferencia = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->Listar_2");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Listar_2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTransferenciaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransferenciaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransferenciaResponse)));
            
        }

        
        /// <summary>
        /// Lista as transfer\u00EAncias realizadas pela conta Este m\u00E9todo permite que sejam listadas as transfer\u00EAncias realizadas pela conta existentes na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTransferencia">C\u00F3digo de identifica\u00E7\u00E3o da transfer\u00EAncia (id) (optional)</param>
        /// <param name="idContaOrigem">C\u00F3digo de identifica\u00E7\u00E3o da conta em que o valor ser\u00E1 debitado para a transfer\u00EAncia. (id) (optional)</param>
        /// <param name="idContaDestino">C\u00F3digo de identifica\u00E7\u00E3o da conta em que o valor ser\u00E1 creditado para a transfer\u00EAncia. (id) (optional)</param>
        /// <param name="valorTransferencia">Valor estabelecido para ser transferido (optional)</param>
        /// <param name="dataTransferencia">Data estabelecida para ocorrer a transfer\u00EAncia (optional)</param>
        /// <returns>Task of PageTransferenciaResponse</returns>
        public async System.Threading.Tasks.Task<PageTransferenciaResponse> Listar_2Async (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, string dataTransferencia = null)
        {
             ApiResponse<PageTransferenciaResponse> localVarResponse = await Listar_2AsyncWithHttpInfo(id, sort, page, limit, idTransferencia, idContaOrigem, idContaDestino, valorTransferencia, dataTransferencia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as transfer\u00EAncias realizadas pela conta Este m\u00E9todo permite que sejam listadas as transfer\u00EAncias realizadas pela conta existentes na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTransferencia">C\u00F3digo de identifica\u00E7\u00E3o da transfer\u00EAncia (id) (optional)</param>
        /// <param name="idContaOrigem">C\u00F3digo de identifica\u00E7\u00E3o da conta em que o valor ser\u00E1 debitado para a transfer\u00EAncia. (id) (optional)</param>
        /// <param name="idContaDestino">C\u00F3digo de identifica\u00E7\u00E3o da conta em que o valor ser\u00E1 creditado para a transfer\u00EAncia. (id) (optional)</param>
        /// <param name="valorTransferencia">Valor estabelecido para ser transferido (optional)</param>
        /// <param name="dataTransferencia">Data estabelecida para ocorrer a transfer\u00EAncia (optional)</param>
        /// <returns>Task of ApiResponse (PageTransferenciaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransferenciaResponse>> Listar_2AsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, string dataTransferencia = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Listar_2");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Listar_2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTransferenciaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransferenciaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransferenciaResponse)));
            
        }
        
        /// <summary>
        /// Realiza a reativa\u00E7\u00E3o de contas Este recurso permite reativar contas. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <returns>Object</returns>
        public Object Reativar (long? id)
        {
             ApiResponse<Object> localVarResponse = ReativarWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a reativa\u00E7\u00E3o de contas Este recurso permite reativar contas. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > ReativarWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->Reativar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Reativar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Reativar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Realiza a reativa\u00E7\u00E3o de contas Este recurso permite reativar contas. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ReativarAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await ReativarAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a reativa\u00E7\u00E3o de contas Este recurso permite reativar contas. Para isso, ser\u00E1 preciso informar o c\u00F3digo de identifica\u00E7\u00E3o da Conta (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ReativarAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Reativar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Reativar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Reativar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro de uma nova conta Esse recurso permite cadastrar uma nova conta para uma pessoa j\u00E1 existente na base de dados do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaPersist">contaPersist</param> 
        /// <returns>ContaResponse</returns>
        public ContaResponse Salvar (ContaPersist contaPersist)
        {
             ApiResponse<ContaResponse> localVarResponse = SalvarWithHttpInfo(contaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro de uma nova conta Esse recurso permite cadastrar uma nova conta para uma pessoa j\u00E1 existente na base de dados do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaPersist">contaPersist</param> 
        /// <returns>ApiResponse of ContaResponse</returns>
        public ApiResponse< ContaResponse > SalvarWithHttpInfo (ContaPersist contaPersist)
        {
            
            // verify the required parameter 'contaPersist' is set
            if (contaPersist == null)
                throw new ApiException(400, "Missing required parameter 'contaPersist' when calling ContaApi->Salvar");
            
    
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
            
            
            
            
            if (contaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro de uma nova conta Esse recurso permite cadastrar uma nova conta para uma pessoa j\u00E1 existente na base de dados do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaPersist">contaPersist</param>
        /// <returns>Task of ContaResponse</returns>
        public async System.Threading.Tasks.Task<ContaResponse> SalvarAsync (ContaPersist contaPersist)
        {
             ApiResponse<ContaResponse> localVarResponse = await SalvarAsyncWithHttpInfo(contaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro de uma nova conta Esse recurso permite cadastrar uma nova conta para uma pessoa j\u00E1 existente na base de dados do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaPersist">contaPersist</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaResponse>> SalvarAsyncWithHttpInfo (ContaPersist contaPersist)
        {
            // verify the required parameter 'contaPersist' is set
            if (contaPersist == null) throw new ApiException(400, "Missing required parameter 'contaPersist' when calling Salvar");
            
    
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
            
            
            
            
            if (contaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }
        
        /// <summary>
        /// Realiza um cadastro de uma nova ades\u00E3o do servi\u00E7o Este recurso permite cadastrar uma nova ades\u00E3o de servi\u00E7o na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param> 
        /// <param name="adesaoServicoPersist">adesaoServicoPersist</param> 
        /// <returns>AdesaoServicoResponse</returns>
        public AdesaoServicoResponse SalvarAdesaoServicos (long? id, AdesaoServicoPersist adesaoServicoPersist)
        {
             ApiResponse<AdesaoServicoResponse> localVarResponse = SalvarAdesaoServicosWithHttpInfo(id, adesaoServicoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza um cadastro de uma nova ades\u00E3o do servi\u00E7o Este recurso permite cadastrar uma nova ades\u00E3o de servi\u00E7o na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param> 
        /// <param name="adesaoServicoPersist">adesaoServicoPersist</param> 
        /// <returns>ApiResponse of AdesaoServicoResponse</returns>
        public ApiResponse< AdesaoServicoResponse > SalvarAdesaoServicosWithHttpInfo (long? id, AdesaoServicoPersist adesaoServicoPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->SalvarAdesaoServicos");
            
            // verify the required parameter 'adesaoServicoPersist' is set
            if (adesaoServicoPersist == null)
                throw new ApiException(400, "Missing required parameter 'adesaoServicoPersist' when calling ContaApi->SalvarAdesaoServicos");
            
    
            var localVarPath = "/api/contas/{id}/adesoes-servicos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            if (adesaoServicoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(adesaoServicoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = adesaoServicoPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarAdesaoServicos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarAdesaoServicos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdesaoServicoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdesaoServicoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdesaoServicoResponse)));
            
        }

        
        /// <summary>
        /// Realiza um cadastro de uma nova ades\u00E3o do servi\u00E7o Este recurso permite cadastrar uma nova ades\u00E3o de servi\u00E7o na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="adesaoServicoPersist">adesaoServicoPersist</param>
        /// <returns>Task of AdesaoServicoResponse</returns>
        public async System.Threading.Tasks.Task<AdesaoServicoResponse> SalvarAdesaoServicosAsync (long? id, AdesaoServicoPersist adesaoServicoPersist)
        {
             ApiResponse<AdesaoServicoResponse> localVarResponse = await SalvarAdesaoServicosAsyncWithHttpInfo(id, adesaoServicoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza um cadastro de uma nova ades\u00E3o do servi\u00E7o Este recurso permite cadastrar uma nova ades\u00E3o de servi\u00E7o na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="adesaoServicoPersist">adesaoServicoPersist</param>
        /// <returns>Task of ApiResponse (AdesaoServicoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdesaoServicoResponse>> SalvarAdesaoServicosAsyncWithHttpInfo (long? id, AdesaoServicoPersist adesaoServicoPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SalvarAdesaoServicos");
            // verify the required parameter 'adesaoServicoPersist' is set
            if (adesaoServicoPersist == null) throw new ApiException(400, "Missing required parameter 'adesaoServicoPersist' when calling SalvarAdesaoServicos");
            
    
            var localVarPath = "/api/contas/{id}/adesoes-servicos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            if (adesaoServicoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(adesaoServicoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = adesaoServicoPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarAdesaoServicos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarAdesaoServicos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdesaoServicoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdesaoServicoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdesaoServicoResponse)));
            
        }
        
        /// <summary>
        /// Simula valores de presta\u00E7\u00F5es de empr\u00E9stimos/financiamentos Esta opera\u00E7\u00E3o pode ser utilizada para simular opera\u00E7\u00F5es financeiras a partir de informa\u00E7\u00F5es fornecidas pelo usu\u00E1rio. Os c\u00E1lculos gerados devem ser considerados apenas como refer\u00EAncia para as situa\u00E7\u00F5es reais e n\u00E3o como valores oficiais
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="request">request</param> 
        /// <returns>EmprestimoPessoalResponse</returns>
        public EmprestimoPessoalResponse SimularEmprestimoFinanciamento (long? id, EmprestimoPessoalRequest request)
        {
             ApiResponse<EmprestimoPessoalResponse> localVarResponse = SimularEmprestimoFinanciamentoWithHttpInfo(id, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Simula valores de presta\u00E7\u00F5es de empr\u00E9stimos/financiamentos Esta opera\u00E7\u00E3o pode ser utilizada para simular opera\u00E7\u00F5es financeiras a partir de informa\u00E7\u00F5es fornecidas pelo usu\u00E1rio. Os c\u00E1lculos gerados devem ser considerados apenas como refer\u00EAncia para as situa\u00E7\u00F5es reais e n\u00E3o como valores oficiais
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="request">request</param> 
        /// <returns>ApiResponse of EmprestimoPessoalResponse</returns>
        public ApiResponse< EmprestimoPessoalResponse > SimularEmprestimoFinanciamentoWithHttpInfo (long? id, EmprestimoPessoalRequest request)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->SimularEmprestimoFinanciamento");
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling ContaApi->SimularEmprestimoFinanciamento");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SimularEmprestimoFinanciamento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularEmprestimoFinanciamento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EmprestimoPessoalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmprestimoPessoalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmprestimoPessoalResponse)));
            
        }

        
        /// <summary>
        /// Simula valores de presta\u00E7\u00F5es de empr\u00E9stimos/financiamentos Esta opera\u00E7\u00E3o pode ser utilizada para simular opera\u00E7\u00F5es financeiras a partir de informa\u00E7\u00F5es fornecidas pelo usu\u00E1rio. Os c\u00E1lculos gerados devem ser considerados apenas como refer\u00EAncia para as situa\u00E7\u00F5es reais e n\u00E3o como valores oficiais
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="request">request</param>
        /// <returns>Task of EmprestimoPessoalResponse</returns>
        public async System.Threading.Tasks.Task<EmprestimoPessoalResponse> SimularEmprestimoFinanciamentoAsync (long? id, EmprestimoPessoalRequest request)
        {
             ApiResponse<EmprestimoPessoalResponse> localVarResponse = await SimularEmprestimoFinanciamentoAsyncWithHttpInfo(id, request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Simula valores de presta\u00E7\u00F5es de empr\u00E9stimos/financiamentos Esta opera\u00E7\u00E3o pode ser utilizada para simular opera\u00E7\u00F5es financeiras a partir de informa\u00E7\u00F5es fornecidas pelo usu\u00E1rio. Os c\u00E1lculos gerados devem ser considerados apenas como refer\u00EAncia para as situa\u00E7\u00F5es reais e n\u00E3o como valores oficiais
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (EmprestimoPessoalResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmprestimoPessoalResponse>> SimularEmprestimoFinanciamentoAsyncWithHttpInfo (long? id, EmprestimoPessoalRequest request)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SimularEmprestimoFinanciamento");
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling SimularEmprestimoFinanciamento");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SimularEmprestimoFinanciamento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularEmprestimoFinanciamento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmprestimoPessoalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmprestimoPessoalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmprestimoPessoalResponse)));
            
        }
        
        /// <summary>
        /// Permite listar uma linha do tempo com os eventos da conta Esta opera\u00E7\u00E3o tem como objetivo permitir a listagem, em formato de timeline, dos eventos vinculados a uma detemrinada conta. Transa\u00E7\u00F5es, fechamento da fatura, pagamentos, gera\u00E7\u00E3o de cart\u00F5es e altera\u00E7\u00E3o de limite s\u00E3o exemplos de eventos contemplados por esta funcionalidade. Neste m\u00E9todo, as opera\u00E7\u00F5es s\u00E3o ordenadas de forma decrescente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageTransacaoResponse</returns>
        public PageTransacaoResponse Transacoes (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTransacaoResponse> localVarResponse = TransacoesWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite listar uma linha do tempo com os eventos da conta Esta opera\u00E7\u00E3o tem como objetivo permitir a listagem, em formato de timeline, dos eventos vinculados a uma detemrinada conta. Transa\u00E7\u00F5es, fechamento da fatura, pagamentos, gera\u00E7\u00E3o de cart\u00F5es e altera\u00E7\u00E3o de limite s\u00E3o exemplos de eventos contemplados por esta funcionalidade. Neste m\u00E9todo, as opera\u00E7\u00F5es s\u00E3o ordenadas de forma decrescente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageTransacaoResponse</returns>
        public ApiResponse< PageTransacaoResponse > TransacoesWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->Transacoes");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Transacoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Transacoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTransacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacaoResponse)));
            
        }

        
        /// <summary>
        /// Permite listar uma linha do tempo com os eventos da conta Esta opera\u00E7\u00E3o tem como objetivo permitir a listagem, em formato de timeline, dos eventos vinculados a uma detemrinada conta. Transa\u00E7\u00F5es, fechamento da fatura, pagamentos, gera\u00E7\u00E3o de cart\u00F5es e altera\u00E7\u00E3o de limite s\u00E3o exemplos de eventos contemplados por esta funcionalidade. Neste m\u00E9todo, as opera\u00E7\u00F5es s\u00E3o ordenadas de forma decrescente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageTransacaoResponse</returns>
        public async System.Threading.Tasks.Task<PageTransacaoResponse> TransacoesAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTransacaoResponse> localVarResponse = await TransacoesAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite listar uma linha do tempo com os eventos da conta Esta opera\u00E7\u00E3o tem como objetivo permitir a listagem, em formato de timeline, dos eventos vinculados a uma detemrinada conta. Transa\u00E7\u00F5es, fechamento da fatura, pagamentos, gera\u00E7\u00E3o de cart\u00F5es e altera\u00E7\u00E3o de limite s\u00E3o exemplos de eventos contemplados por esta funcionalidade. Neste m\u00E9todo, as opera\u00E7\u00F5es s\u00E3o ordenadas de forma decrescente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransacaoResponse>> TransacoesAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Transacoes");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Transacoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Transacoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTransacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacaoResponse)));
            
        }
        
        /// <summary>
        /// Realiza uma transfer\u00EAncia de Cr\u00E9dito para outro cliente do mesmo Emissor Este m\u00E9todo permite que um portador de um cart\u00E3o possa realizar auma transfer\u00EAncia de cr\u00E9dito para outro cliente do mesmo emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta do cliente portador do cart\u00E3o que ser\u00E1 debitado (id)</param> 
        /// <param name="idContaDestino">C\u00F3digo de Identifica\u00E7\u00E3o do cliente portador do cart\u00E3o que ser\u00E1 creditado (id)</param> 
        /// <param name="valorTransferencia">Valor da Transfer\u00EAncia</param> 
        /// <returns>TransferenciaDetalheResponse</returns>
        public TransferenciaDetalheResponse Transferir (long? id, long? idContaDestino, double? valorTransferencia)
        {
             ApiResponse<TransferenciaDetalheResponse> localVarResponse = TransferirWithHttpInfo(id, idContaDestino, valorTransferencia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza uma transfer\u00EAncia de Cr\u00E9dito para outro cliente do mesmo Emissor Este m\u00E9todo permite que um portador de um cart\u00E3o possa realizar auma transfer\u00EAncia de cr\u00E9dito para outro cliente do mesmo emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta do cliente portador do cart\u00E3o que ser\u00E1 debitado (id)</param> 
        /// <param name="idContaDestino">C\u00F3digo de Identifica\u00E7\u00E3o do cliente portador do cart\u00E3o que ser\u00E1 creditado (id)</param> 
        /// <param name="valorTransferencia">Valor da Transfer\u00EAncia</param> 
        /// <returns>ApiResponse of TransferenciaDetalheResponse</returns>
        public ApiResponse< TransferenciaDetalheResponse > TransferirWithHttpInfo (long? id, long? idContaDestino, double? valorTransferencia)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->Transferir");
            
            // verify the required parameter 'idContaDestino' is set
            if (idContaDestino == null)
                throw new ApiException(400, "Missing required parameter 'idContaDestino' when calling ContaApi->Transferir");
            
            // verify the required parameter 'valorTransferencia' is set
            if (valorTransferencia == null)
                throw new ApiException(400, "Missing required parameter 'valorTransferencia' when calling ContaApi->Transferir");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Transferir: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Transferir: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransferenciaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaDetalheResponse)));
            
        }

        
        /// <summary>
        /// Realiza uma transfer\u00EAncia de Cr\u00E9dito para outro cliente do mesmo Emissor Este m\u00E9todo permite que um portador de um cart\u00E3o possa realizar auma transfer\u00EAncia de cr\u00E9dito para outro cliente do mesmo emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta do cliente portador do cart\u00E3o que ser\u00E1 debitado (id)</param>
        /// <param name="idContaDestino">C\u00F3digo de Identifica\u00E7\u00E3o do cliente portador do cart\u00E3o que ser\u00E1 creditado (id)</param>
        /// <param name="valorTransferencia">Valor da Transfer\u00EAncia</param>
        /// <returns>Task of TransferenciaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<TransferenciaDetalheResponse> TransferirAsync (long? id, long? idContaDestino, double? valorTransferencia)
        {
             ApiResponse<TransferenciaDetalheResponse> localVarResponse = await TransferirAsyncWithHttpInfo(id, idContaDestino, valorTransferencia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza uma transfer\u00EAncia de Cr\u00E9dito para outro cliente do mesmo Emissor Este m\u00E9todo permite que um portador de um cart\u00E3o possa realizar auma transfer\u00EAncia de cr\u00E9dito para outro cliente do mesmo emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta do cliente portador do cart\u00E3o que ser\u00E1 debitado (id)</param>
        /// <param name="idContaDestino">C\u00F3digo de Identifica\u00E7\u00E3o do cliente portador do cart\u00E3o que ser\u00E1 creditado (id)</param>
        /// <param name="valorTransferencia">Valor da Transfer\u00EAncia</param>
        /// <returns>Task of ApiResponse (TransferenciaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransferenciaDetalheResponse>> TransferirAsyncWithHttpInfo (long? id, long? idContaDestino, double? valorTransferencia)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Transferir");
            // verify the required parameter 'idContaDestino' is set
            if (idContaDestino == null) throw new ApiException(400, "Missing required parameter 'idContaDestino' when calling Transferir");
            // verify the required parameter 'valorTransferencia' is set
            if (valorTransferencia == null) throw new ApiException(400, "Missing required parameter 'valorTransferencia' when calling Transferir");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Transferir: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Transferir: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransferenciaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaDetalheResponse)));
            
        }
        
    }
    
}
