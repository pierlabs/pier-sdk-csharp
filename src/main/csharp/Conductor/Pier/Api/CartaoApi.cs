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
    public interface ICartaoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Apresenta os limites do Portador do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os Limites configurados para o Portador de um determinado Cart\u00C3\u00A3o, seja ele o titular da conta ou um adicional, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Limites</returns>
        Limites ConsultarLimiteUsingGET (long? idCartao);
  
        /// <summary>
        /// Apresenta os limites do Portador do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os Limites configurados para o Portador de um determinado Cart\u00C3\u00A3o, seja ele o titular da conta ou um adicional, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>ApiResponse of Limites</returns>
        ApiResponse<Limites> ConsultarLimiteUsingGETWithHttpInfo (long? idCartao);
        
        /// <summary>
        /// Apresenta os dados do Portador do Cart\u00C3\u00A3o 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es do Portador de um determinado Cart\u00C3\u00A3o a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Portador</returns>
        Portador ConsultarPortadorUsingGET (long? idCartao);
  
        /// <summary>
        /// Apresenta os dados do Portador do Cart\u00C3\u00A3o 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es do Portador de um determinado Cart\u00C3\u00A3o a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>ApiResponse of Portador</returns>
        ApiResponse<Portador> ConsultarPortadorUsingGETWithHttpInfo (long? idCartao);
        
        /// <summary>
        /// Apresenta os saldos dispon\u00C3\u00ADveis para o Portador do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os saldos dispon\u00C3\u00ADveis para uso pelo Portador de um determinado Cart\u00C3\u00A3o, seja ele o titular da conta ou um adicional, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Saldos</returns>
        Saldos ConsultarSaldoUsingGET (long? idCartao);
  
        /// <summary>
        /// Apresenta os saldos dispon\u00C3\u00ADveis para o Portador do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os saldos dispon\u00C3\u00ADveis para uso pelo Portador de um determinado Cart\u00C3\u00A3o, seja ele o titular da conta ou um adicional, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>ApiResponse of Saldos</returns>
        ApiResponse<Saldos> ConsultarSaldoUsingGETWithHttpInfo (long? idCartao);
        
        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es b\u00C3\u00A1sicas de um determinado Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Cartao</returns>
        Cartao ConsultarUsingGET (long? idCartao);
  
        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es b\u00C3\u00A1sicas de um determinado Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>ApiResponse of Cartao</returns>
        ApiResponse<Cartao> ConsultarUsingGETWithHttpInfo (long? idCartao);
        
        /// <summary>
        /// Realiza o desbloqueio de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja desbloqueado um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Cartao</returns>
        Cartao DebloquearUsingGET (long? idCartao);
  
        /// <summary>
        /// Realiza o desbloqueio de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja desbloqueado um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>ApiResponse of Cartao</returns>
        ApiResponse<Cartao> DebloquearUsingGETWithHttpInfo (long? idCartao);
        
        /// <summary>
        /// Lista os Cart\u00C3\u00B5es gerados pelo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o cart\u00C3\u00A3o pertence (id) (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="tipoPortador">Indica qual \u00C3\u00A9 a rela\u00C3\u00A7\u00C3\u00A3o do portador do cart\u00C3\u00A3o com a conta. Quando &#39;1&#39;, corresponde ao seu titular. Quando diferente disso, corresponde a um cart\u00C3\u00A3o adicional. (optional)</param>
        /// <param name="numeroCartao">Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome impresso no cart\u00C3\u00A3o. (optional)</param>
        /// <param name="dataGeracao">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param>
        /// <param name="dataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataValidade">Apresenta a data de validade do cart\u00C3\u00A3o em formato aaaa-MM, quando houver. (optional)</param>
        /// <param name="dataImpressao">Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica. (optional)</param>
        /// <param name="arquivoImpressao">Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver. (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial. (optional)</param>
        /// <param name="flagProvisorio">Quando ativa, indica que o cart\u00C3\u00A3o \u00C3\u00A9 provis\u00C3\u00B3rio. Ou seja, \u00C3\u00A9 um cart\u00C3\u00A3o para uso tempor\u00C3\u00A1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00C3\u00A3o definitivo. (optional)</param>
        /// <param name="codigoDesbloqueio">Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>PageCartoes</returns>
        PageCartoes ListarUsingGET (long? id = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, DateTime? dataGeracao = null, DateTime? dataStatusCartao = null, DateTime? dataEstagioCartao = null, string dataValidade = null, DateTime? dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista os Cart\u00C3\u00B5es gerados pelo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o cart\u00C3\u00A3o pertence (id) (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="tipoPortador">Indica qual \u00C3\u00A9 a rela\u00C3\u00A7\u00C3\u00A3o do portador do cart\u00C3\u00A3o com a conta. Quando &#39;1&#39;, corresponde ao seu titular. Quando diferente disso, corresponde a um cart\u00C3\u00A3o adicional. (optional)</param>
        /// <param name="numeroCartao">Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome impresso no cart\u00C3\u00A3o. (optional)</param>
        /// <param name="dataGeracao">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param>
        /// <param name="dataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataValidade">Apresenta a data de validade do cart\u00C3\u00A3o em formato aaaa-MM, quando houver. (optional)</param>
        /// <param name="dataImpressao">Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica. (optional)</param>
        /// <param name="arquivoImpressao">Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver. (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial. (optional)</param>
        /// <param name="flagProvisorio">Quando ativa, indica que o cart\u00C3\u00A3o \u00C3\u00A9 provis\u00C3\u00B3rio. Ou seja, \u00C3\u00A9 um cart\u00C3\u00A3o para uso tempor\u00C3\u00A1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00C3\u00A3o definitivo. (optional)</param>
        /// <param name="codigoDesbloqueio">Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>ApiResponse of PageCartoes</returns>
        ApiResponse<PageCartoes> ListarUsingGETWithHttpInfo (long? id = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, DateTime? dataGeracao = null, DateTime? dataStatusCartao = null, DateTime? dataEstagioCartao = null, string dataValidade = null, DateTime? dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? page = null, int? limit = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Apresenta os limites do Portador do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os Limites configurados para o Portador de um determinado Cart\u00C3\u00A3o, seja ele o titular da conta ou um adicional, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of Limites</returns>
        System.Threading.Tasks.Task<Limites> ConsultarLimiteUsingGETAsync (long? idCartao);

        /// <summary>
        /// Apresenta os limites do Portador do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os Limites configurados para o Portador de um determinado Cart\u00C3\u00A3o, seja ele o titular da conta ou um adicional, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (Limites)</returns>
        System.Threading.Tasks.Task<ApiResponse<Limites>> ConsultarLimiteUsingGETAsyncWithHttpInfo (long? idCartao);
        
        /// <summary>
        /// Apresenta os dados do Portador do Cart\u00C3\u00A3o 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es do Portador de um determinado Cart\u00C3\u00A3o a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of Portador</returns>
        System.Threading.Tasks.Task<Portador> ConsultarPortadorUsingGETAsync (long? idCartao);

        /// <summary>
        /// Apresenta os dados do Portador do Cart\u00C3\u00A3o 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es do Portador de um determinado Cart\u00C3\u00A3o a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (Portador)</returns>
        System.Threading.Tasks.Task<ApiResponse<Portador>> ConsultarPortadorUsingGETAsyncWithHttpInfo (long? idCartao);
        
        /// <summary>
        /// Apresenta os saldos dispon\u00C3\u00ADveis para o Portador do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os saldos dispon\u00C3\u00ADveis para uso pelo Portador de um determinado Cart\u00C3\u00A3o, seja ele o titular da conta ou um adicional, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of Saldos</returns>
        System.Threading.Tasks.Task<Saldos> ConsultarSaldoUsingGETAsync (long? idCartao);

        /// <summary>
        /// Apresenta os saldos dispon\u00C3\u00ADveis para o Portador do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os saldos dispon\u00C3\u00ADveis para uso pelo Portador de um determinado Cart\u00C3\u00A3o, seja ele o titular da conta ou um adicional, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (Saldos)</returns>
        System.Threading.Tasks.Task<ApiResponse<Saldos>> ConsultarSaldoUsingGETAsyncWithHttpInfo (long? idCartao);
        
        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es b\u00C3\u00A1sicas de um determinado Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of Cartao</returns>
        System.Threading.Tasks.Task<Cartao> ConsultarUsingGETAsync (long? idCartao);

        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es b\u00C3\u00A1sicas de um determinado Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (Cartao)</returns>
        System.Threading.Tasks.Task<ApiResponse<Cartao>> ConsultarUsingGETAsyncWithHttpInfo (long? idCartao);
        
        /// <summary>
        /// Realiza o desbloqueio de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja desbloqueado um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of Cartao</returns>
        System.Threading.Tasks.Task<Cartao> DebloquearUsingGETAsync (long? idCartao);

        /// <summary>
        /// Realiza o desbloqueio de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja desbloqueado um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (Cartao)</returns>
        System.Threading.Tasks.Task<ApiResponse<Cartao>> DebloquearUsingGETAsyncWithHttpInfo (long? idCartao);
        
        /// <summary>
        /// Lista os Cart\u00C3\u00B5es gerados pelo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o cart\u00C3\u00A3o pertence (id) (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="tipoPortador">Indica qual \u00C3\u00A9 a rela\u00C3\u00A7\u00C3\u00A3o do portador do cart\u00C3\u00A3o com a conta. Quando &#39;1&#39;, corresponde ao seu titular. Quando diferente disso, corresponde a um cart\u00C3\u00A3o adicional. (optional)</param>
        /// <param name="numeroCartao">Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome impresso no cart\u00C3\u00A3o. (optional)</param>
        /// <param name="dataGeracao">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param>
        /// <param name="dataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataValidade">Apresenta a data de validade do cart\u00C3\u00A3o em formato aaaa-MM, quando houver. (optional)</param>
        /// <param name="dataImpressao">Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica. (optional)</param>
        /// <param name="arquivoImpressao">Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver. (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial. (optional)</param>
        /// <param name="flagProvisorio">Quando ativa, indica que o cart\u00C3\u00A3o \u00C3\u00A9 provis\u00C3\u00B3rio. Ou seja, \u00C3\u00A9 um cart\u00C3\u00A3o para uso tempor\u00C3\u00A1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00C3\u00A3o definitivo. (optional)</param>
        /// <param name="codigoDesbloqueio">Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of PageCartoes</returns>
        System.Threading.Tasks.Task<PageCartoes> ListarUsingGETAsync (long? id = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, DateTime? dataGeracao = null, DateTime? dataStatusCartao = null, DateTime? dataEstagioCartao = null, string dataValidade = null, DateTime? dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista os Cart\u00C3\u00B5es gerados pelo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o cart\u00C3\u00A3o pertence (id) (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="tipoPortador">Indica qual \u00C3\u00A9 a rela\u00C3\u00A7\u00C3\u00A3o do portador do cart\u00C3\u00A3o com a conta. Quando &#39;1&#39;, corresponde ao seu titular. Quando diferente disso, corresponde a um cart\u00C3\u00A3o adicional. (optional)</param>
        /// <param name="numeroCartao">Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome impresso no cart\u00C3\u00A3o. (optional)</param>
        /// <param name="dataGeracao">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param>
        /// <param name="dataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataValidade">Apresenta a data de validade do cart\u00C3\u00A3o em formato aaaa-MM, quando houver. (optional)</param>
        /// <param name="dataImpressao">Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica. (optional)</param>
        /// <param name="arquivoImpressao">Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver. (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial. (optional)</param>
        /// <param name="flagProvisorio">Quando ativa, indica que o cart\u00C3\u00A3o \u00C3\u00A9 provis\u00C3\u00B3rio. Ou seja, \u00C3\u00A9 um cart\u00C3\u00A3o para uso tempor\u00C3\u00A1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00C3\u00A3o definitivo. (optional)</param>
        /// <param name="codigoDesbloqueio">Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ApiResponse (PageCartoes)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCartoes>> ListarUsingGETAsyncWithHttpInfo (long? id = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, DateTime? dataGeracao = null, DateTime? dataStatusCartao = null, DateTime? dataEstagioCartao = null, string dataValidade = null, DateTime? dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? page = null, int? limit = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CartaoApi : ICartaoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CartaoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CartaoApi(Configuration configuration = null)
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
        /// Apresenta os limites do Portador do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar os Limites configurados para o Portador de um determinado Cart\u00C3\u00A3o, seja ele o titular da conta ou um adicional, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>Limites</returns>
        public Limites ConsultarLimiteUsingGET (long? idCartao)
        {
             ApiResponse<Limites> localVarResponse = ConsultarLimiteUsingGETWithHttpInfo(idCartao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os limites do Portador do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar os Limites configurados para o Portador de um determinado Cart\u00C3\u00A3o, seja ele o titular da conta ou um adicional, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>ApiResponse of Limites</returns>
        public ApiResponse< Limites > ConsultarLimiteUsingGETWithHttpInfo (long? idCartao)
        {
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling CartaoApi->ConsultarLimiteUsingGET");
            
    
            var localVarPath = "/api/cartoes/{id_cartao}/limites";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idCartao != null) localVarPathParams.Add("id_cartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLimiteUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLimiteUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Limites>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Limites) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Limites)));
            
        }

        
        /// <summary>
        /// Apresenta os limites do Portador do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar os Limites configurados para o Portador de um determinado Cart\u00C3\u00A3o, seja ele o titular da conta ou um adicional, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of Limites</returns>
        public async System.Threading.Tasks.Task<Limites> ConsultarLimiteUsingGETAsync (long? idCartao)
        {
             ApiResponse<Limites> localVarResponse = await ConsultarLimiteUsingGETAsyncWithHttpInfo(idCartao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os limites do Portador do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar os Limites configurados para o Portador de um determinado Cart\u00C3\u00A3o, seja ele o titular da conta ou um adicional, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (Limites)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Limites>> ConsultarLimiteUsingGETAsyncWithHttpInfo (long? idCartao)
        {
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling ConsultarLimiteUsingGET");
            
    
            var localVarPath = "/api/cartoes/{id_cartao}/limites";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idCartao != null) localVarPathParams.Add("id_cartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLimiteUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLimiteUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Limites>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Limites) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Limites)));
            
        }
        
        /// <summary>
        /// Apresenta os dados do Portador do Cart\u00C3\u00A3o  Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es do Portador de um determinado Cart\u00C3\u00A3o a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>Portador</returns>
        public Portador ConsultarPortadorUsingGET (long? idCartao)
        {
             ApiResponse<Portador> localVarResponse = ConsultarPortadorUsingGETWithHttpInfo(idCartao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados do Portador do Cart\u00C3\u00A3o  Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es do Portador de um determinado Cart\u00C3\u00A3o a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>ApiResponse of Portador</returns>
        public ApiResponse< Portador > ConsultarPortadorUsingGETWithHttpInfo (long? idCartao)
        {
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling CartaoApi->ConsultarPortadorUsingGET");
            
    
            var localVarPath = "/api/cartoes/{id_cartao}/portadores";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idCartao != null) localVarPathParams.Add("id_cartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPortadorUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPortadorUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Portador>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Portador) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Portador)));
            
        }

        
        /// <summary>
        /// Apresenta os dados do Portador do Cart\u00C3\u00A3o  Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es do Portador de um determinado Cart\u00C3\u00A3o a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of Portador</returns>
        public async System.Threading.Tasks.Task<Portador> ConsultarPortadorUsingGETAsync (long? idCartao)
        {
             ApiResponse<Portador> localVarResponse = await ConsultarPortadorUsingGETAsyncWithHttpInfo(idCartao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados do Portador do Cart\u00C3\u00A3o  Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es do Portador de um determinado Cart\u00C3\u00A3o a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (Portador)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Portador>> ConsultarPortadorUsingGETAsyncWithHttpInfo (long? idCartao)
        {
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling ConsultarPortadorUsingGET");
            
    
            var localVarPath = "/api/cartoes/{id_cartao}/portadores";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idCartao != null) localVarPathParams.Add("id_cartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPortadorUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPortadorUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Portador>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Portador) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Portador)));
            
        }
        
        /// <summary>
        /// Apresenta os saldos dispon\u00C3\u00ADveis para o Portador do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar os saldos dispon\u00C3\u00ADveis para uso pelo Portador de um determinado Cart\u00C3\u00A3o, seja ele o titular da conta ou um adicional, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>Saldos</returns>
        public Saldos ConsultarSaldoUsingGET (long? idCartao)
        {
             ApiResponse<Saldos> localVarResponse = ConsultarSaldoUsingGETWithHttpInfo(idCartao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os saldos dispon\u00C3\u00ADveis para o Portador do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar os saldos dispon\u00C3\u00ADveis para uso pelo Portador de um determinado Cart\u00C3\u00A3o, seja ele o titular da conta ou um adicional, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>ApiResponse of Saldos</returns>
        public ApiResponse< Saldos > ConsultarSaldoUsingGETWithHttpInfo (long? idCartao)
        {
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling CartaoApi->ConsultarSaldoUsingGET");
            
    
            var localVarPath = "/api/cartoes/{id_cartao}/saldos-disponiveis";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idCartao != null) localVarPathParams.Add("id_cartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarSaldoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarSaldoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Saldos>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Saldos) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Saldos)));
            
        }

        
        /// <summary>
        /// Apresenta os saldos dispon\u00C3\u00ADveis para o Portador do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar os saldos dispon\u00C3\u00ADveis para uso pelo Portador de um determinado Cart\u00C3\u00A3o, seja ele o titular da conta ou um adicional, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of Saldos</returns>
        public async System.Threading.Tasks.Task<Saldos> ConsultarSaldoUsingGETAsync (long? idCartao)
        {
             ApiResponse<Saldos> localVarResponse = await ConsultarSaldoUsingGETAsyncWithHttpInfo(idCartao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os saldos dispon\u00C3\u00ADveis para o Portador do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar os saldos dispon\u00C3\u00ADveis para uso pelo Portador de um determinado Cart\u00C3\u00A3o, seja ele o titular da conta ou um adicional, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (Saldos)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Saldos>> ConsultarSaldoUsingGETAsyncWithHttpInfo (long? idCartao)
        {
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling ConsultarSaldoUsingGET");
            
    
            var localVarPath = "/api/cartoes/{id_cartao}/saldos-disponiveis";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idCartao != null) localVarPathParams.Add("id_cartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarSaldoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarSaldoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Saldos>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Saldos) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Saldos)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es b\u00C3\u00A1sicas de um determinado Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>Cartao</returns>
        public Cartao ConsultarUsingGET (long? idCartao)
        {
             ApiResponse<Cartao> localVarResponse = ConsultarUsingGETWithHttpInfo(idCartao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es b\u00C3\u00A1sicas de um determinado Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>ApiResponse of Cartao</returns>
        public ApiResponse< Cartao > ConsultarUsingGETWithHttpInfo (long? idCartao)
        {
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling CartaoApi->ConsultarUsingGET");
            
    
            var localVarPath = "/api/cartoes/{id_cartao}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idCartao != null) localVarPathParams.Add("id_cartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Cartao>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Cartao) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Cartao)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es b\u00C3\u00A1sicas de um determinado Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of Cartao</returns>
        public async System.Threading.Tasks.Task<Cartao> ConsultarUsingGETAsync (long? idCartao)
        {
             ApiResponse<Cartao> localVarResponse = await ConsultarUsingGETAsyncWithHttpInfo(idCartao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es b\u00C3\u00A1sicas de um determinado Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (Cartao)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Cartao>> ConsultarUsingGETAsyncWithHttpInfo (long? idCartao)
        {
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling ConsultarUsingGET");
            
    
            var localVarPath = "/api/cartoes/{id_cartao}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idCartao != null) localVarPathParams.Add("id_cartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Cartao>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Cartao) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Cartao)));
            
        }
        
        /// <summary>
        /// Realiza o desbloqueio de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que seja desbloqueado um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>Cartao</returns>
        public Cartao DebloquearUsingGET (long? idCartao)
        {
             ApiResponse<Cartao> localVarResponse = DebloquearUsingGETWithHttpInfo(idCartao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o desbloqueio de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que seja desbloqueado um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>ApiResponse of Cartao</returns>
        public ApiResponse< Cartao > DebloquearUsingGETWithHttpInfo (long? idCartao)
        {
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling CartaoApi->DebloquearUsingGET");
            
    
            var localVarPath = "/api/cartoes/{id_cartao}/desbloqueio";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idCartao != null) localVarPathParams.Add("id_cartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DebloquearUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DebloquearUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Cartao>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Cartao) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Cartao)));
            
        }

        
        /// <summary>
        /// Realiza o desbloqueio de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que seja desbloqueado um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of Cartao</returns>
        public async System.Threading.Tasks.Task<Cartao> DebloquearUsingGETAsync (long? idCartao)
        {
             ApiResponse<Cartao> localVarResponse = await DebloquearUsingGETAsyncWithHttpInfo(idCartao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o desbloqueio de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que seja desbloqueado um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (Cartao)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Cartao>> DebloquearUsingGETAsyncWithHttpInfo (long? idCartao)
        {
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling DebloquearUsingGET");
            
    
            var localVarPath = "/api/cartoes/{id_cartao}/desbloqueio";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idCartao != null) localVarPathParams.Add("id_cartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DebloquearUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DebloquearUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Cartao>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Cartao) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Cartao)));
            
        }
        
        /// <summary>
        /// Lista os Cart\u00C3\u00B5es gerados pelo Emissor Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param> 
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (optional)</param> 
        /// <param name="idEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param> 
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence (id). (optional)</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o cart\u00C3\u00A3o pertence (id) (optional)</param> 
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence (id). (optional)</param> 
        /// <param name="tipoPortador">Indica qual \u00C3\u00A9 a rela\u00C3\u00A7\u00C3\u00A3o do portador do cart\u00C3\u00A3o com a conta. Quando &#39;1&#39;, corresponde ao seu titular. Quando diferente disso, corresponde a um cart\u00C3\u00A3o adicional. (optional)</param> 
        /// <param name="numeroCartao">Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="nomeImpresso">Apresenta o nome impresso no cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="dataGeracao">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param> 
        /// <param name="dataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param> 
        /// <param name="dataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param> 
        /// <param name="dataValidade">Apresenta a data de validade do cart\u00C3\u00A3o em formato aaaa-MM, quando houver. (optional)</param> 
        /// <param name="dataImpressao">Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica. (optional)</param> 
        /// <param name="arquivoImpressao">Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver. (optional)</param> 
        /// <param name="flagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial. (optional)</param> 
        /// <param name="flagProvisorio">Quando ativa, indica que o cart\u00C3\u00A3o \u00C3\u00A9 provis\u00C3\u00B3rio. Ou seja, \u00C3\u00A9 um cart\u00C3\u00A3o para uso tempor\u00C3\u00A1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00C3\u00A3o definitivo. (optional)</param> 
        /// <param name="codigoDesbloqueio">Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <returns>PageCartoes</returns>
        public PageCartoes ListarUsingGET (long? id = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, DateTime? dataGeracao = null, DateTime? dataStatusCartao = null, DateTime? dataEstagioCartao = null, string dataValidade = null, DateTime? dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCartoes> localVarResponse = ListarUsingGETWithHttpInfo(id, idStatusCartao, idEstagioCartao, idConta, idPessoa, idProduto, tipoPortador, numeroCartao, nomeImpresso, dataGeracao, dataStatusCartao, dataEstagioCartao, dataValidade, dataImpressao, arquivoImpressao, flagImpressaoOrigemComercial, flagProvisorio, codigoDesbloqueio, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Cart\u00C3\u00B5es gerados pelo Emissor Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param> 
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (optional)</param> 
        /// <param name="idEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param> 
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence (id). (optional)</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o cart\u00C3\u00A3o pertence (id) (optional)</param> 
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence (id). (optional)</param> 
        /// <param name="tipoPortador">Indica qual \u00C3\u00A9 a rela\u00C3\u00A7\u00C3\u00A3o do portador do cart\u00C3\u00A3o com a conta. Quando &#39;1&#39;, corresponde ao seu titular. Quando diferente disso, corresponde a um cart\u00C3\u00A3o adicional. (optional)</param> 
        /// <param name="numeroCartao">Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="nomeImpresso">Apresenta o nome impresso no cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="dataGeracao">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param> 
        /// <param name="dataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param> 
        /// <param name="dataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param> 
        /// <param name="dataValidade">Apresenta a data de validade do cart\u00C3\u00A3o em formato aaaa-MM, quando houver. (optional)</param> 
        /// <param name="dataImpressao">Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica. (optional)</param> 
        /// <param name="arquivoImpressao">Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver. (optional)</param> 
        /// <param name="flagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial. (optional)</param> 
        /// <param name="flagProvisorio">Quando ativa, indica que o cart\u00C3\u00A3o \u00C3\u00A9 provis\u00C3\u00B3rio. Ou seja, \u00C3\u00A9 um cart\u00C3\u00A3o para uso tempor\u00C3\u00A1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00C3\u00A3o definitivo. (optional)</param> 
        /// <param name="codigoDesbloqueio">Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <returns>ApiResponse of PageCartoes</returns>
        public ApiResponse< PageCartoes > ListarUsingGETWithHttpInfo (long? id = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, DateTime? dataGeracao = null, DateTime? dataStatusCartao = null, DateTime? dataEstagioCartao = null, string dataValidade = null, DateTime? dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? page = null, int? limit = null)
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCartoes>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCartoes) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCartoes)));
            
        }

        
        /// <summary>
        /// Lista os Cart\u00C3\u00B5es gerados pelo Emissor Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o cart\u00C3\u00A3o pertence (id) (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="tipoPortador">Indica qual \u00C3\u00A9 a rela\u00C3\u00A7\u00C3\u00A3o do portador do cart\u00C3\u00A3o com a conta. Quando &#39;1&#39;, corresponde ao seu titular. Quando diferente disso, corresponde a um cart\u00C3\u00A3o adicional. (optional)</param>
        /// <param name="numeroCartao">Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome impresso no cart\u00C3\u00A3o. (optional)</param>
        /// <param name="dataGeracao">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param>
        /// <param name="dataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataValidade">Apresenta a data de validade do cart\u00C3\u00A3o em formato aaaa-MM, quando houver. (optional)</param>
        /// <param name="dataImpressao">Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica. (optional)</param>
        /// <param name="arquivoImpressao">Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver. (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial. (optional)</param>
        /// <param name="flagProvisorio">Quando ativa, indica que o cart\u00C3\u00A3o \u00C3\u00A9 provis\u00C3\u00B3rio. Ou seja, \u00C3\u00A9 um cart\u00C3\u00A3o para uso tempor\u00C3\u00A1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00C3\u00A3o definitivo. (optional)</param>
        /// <param name="codigoDesbloqueio">Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of PageCartoes</returns>
        public async System.Threading.Tasks.Task<PageCartoes> ListarUsingGETAsync (long? id = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, DateTime? dataGeracao = null, DateTime? dataStatusCartao = null, DateTime? dataEstagioCartao = null, string dataValidade = null, DateTime? dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCartoes> localVarResponse = await ListarUsingGETAsyncWithHttpInfo(id, idStatusCartao, idEstagioCartao, idConta, idPessoa, idProduto, tipoPortador, numeroCartao, nomeImpresso, dataGeracao, dataStatusCartao, dataEstagioCartao, dataValidade, dataImpressao, arquivoImpressao, flagImpressaoOrigemComercial, flagProvisorio, codigoDesbloqueio, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Cart\u00C3\u00B5es gerados pelo Emissor Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o cart\u00C3\u00A3o pertence (id) (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="tipoPortador">Indica qual \u00C3\u00A9 a rela\u00C3\u00A7\u00C3\u00A3o do portador do cart\u00C3\u00A3o com a conta. Quando &#39;1&#39;, corresponde ao seu titular. Quando diferente disso, corresponde a um cart\u00C3\u00A3o adicional. (optional)</param>
        /// <param name="numeroCartao">Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome impresso no cart\u00C3\u00A3o. (optional)</param>
        /// <param name="dataGeracao">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param>
        /// <param name="dataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataValidade">Apresenta a data de validade do cart\u00C3\u00A3o em formato aaaa-MM, quando houver. (optional)</param>
        /// <param name="dataImpressao">Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica. (optional)</param>
        /// <param name="arquivoImpressao">Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver. (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial. (optional)</param>
        /// <param name="flagProvisorio">Quando ativa, indica que o cart\u00C3\u00A3o \u00C3\u00A9 provis\u00C3\u00B3rio. Ou seja, \u00C3\u00A9 um cart\u00C3\u00A3o para uso tempor\u00C3\u00A1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00C3\u00A3o definitivo. (optional)</param>
        /// <param name="codigoDesbloqueio">Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ApiResponse (PageCartoes)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCartoes>> ListarUsingGETAsyncWithHttpInfo (long? id = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, DateTime? dataGeracao = null, DateTime? dataStatusCartao = null, DateTime? dataEstagioCartao = null, string dataValidade = null, DateTime? dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? page = null, int? limit = null)
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCartoes>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCartoes) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCartoes)));
            
        }
        
    }
    
}
