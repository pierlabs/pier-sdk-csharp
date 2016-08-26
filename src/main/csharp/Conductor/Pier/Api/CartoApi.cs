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
    public interface ICartoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es b\u00C3\u00A1sicas de um determinado Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>OrigemComercial</returns>
        OrigemComercial ConsultarUsingGET (long? idCartao);
  
        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es b\u00C3\u00A1sicas de um determinado Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>ApiResponse of OrigemComercial</returns>
        ApiResponse<OrigemComercial> ConsultarUsingGETWithHttpInfo (long? idCartao);
        
        /// <summary>
        /// Lista os Cart\u00C3\u00B5es gerados pelo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="portador">Indica qual \u00C3\u00A9 a rela\u00C3\u00A7\u00C3\u00A3o do portador do cart\u00C3\u00A3o com a conta. Quando \u00E2\u0080\u00981\u00E2\u0080\u0099, corresponde ao seu titular. Quando diferente disso, corresponde a um cart\u00C3\u00A3o adicional. (optional)</param>
        /// <param name="numeroCartao">Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="dataGeracao">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param>
        /// <param name="dataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataValidade">Apresenta a data de validade do cart\u00C3\u00A3o em formato AAAA-MM, quando houver. (optional)</param>
        /// <param name="dataImpressao">Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica. (optional)</param>
        /// <param name="arquivoImpressao">Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver. (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial. (optional)</param>
        /// <param name="flagProvisorio">Quando ativa, indica que o cart\u00C3\u00A3o \u00C3\u00A9 provis\u00C3\u00B3rio. Ou seja, \u00C3\u00A9 um cart\u00C3\u00A3o para uso tempor\u00C3\u00A1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00C3\u00A3o definitivo. (optional)</param>
        /// <param name="codigoDesbloqueio">Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>ListaDeCartes</returns>
        ListaDeCartes ListarUsingGET (long? idCartao = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, int? portador = null, string numeroCartao = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista os Cart\u00C3\u00B5es gerados pelo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="portador">Indica qual \u00C3\u00A9 a rela\u00C3\u00A7\u00C3\u00A3o do portador do cart\u00C3\u00A3o com a conta. Quando \u00E2\u0080\u00981\u00E2\u0080\u0099, corresponde ao seu titular. Quando diferente disso, corresponde a um cart\u00C3\u00A3o adicional. (optional)</param>
        /// <param name="numeroCartao">Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="dataGeracao">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param>
        /// <param name="dataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataValidade">Apresenta a data de validade do cart\u00C3\u00A3o em formato AAAA-MM, quando houver. (optional)</param>
        /// <param name="dataImpressao">Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica. (optional)</param>
        /// <param name="arquivoImpressao">Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver. (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial. (optional)</param>
        /// <param name="flagProvisorio">Quando ativa, indica que o cart\u00C3\u00A3o \u00C3\u00A9 provis\u00C3\u00B3rio. Ou seja, \u00C3\u00A9 um cart\u00C3\u00A3o para uso tempor\u00C3\u00A1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00C3\u00A3o definitivo. (optional)</param>
        /// <param name="codigoDesbloqueio">Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>ApiResponse of ListaDeCartes</returns>
        ApiResponse<ListaDeCartes> ListarUsingGETWithHttpInfo (long? idCartao = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, int? portador = null, string numeroCartao = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? page = null, int? limit = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es b\u00C3\u00A1sicas de um determinado Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of OrigemComercial</returns>
        System.Threading.Tasks.Task<OrigemComercial> ConsultarUsingGETAsync (long? idCartao);

        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es b\u00C3\u00A1sicas de um determinado Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (OrigemComercial)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrigemComercial>> ConsultarUsingGETAsyncWithHttpInfo (long? idCartao);
        
        /// <summary>
        /// Lista os Cart\u00C3\u00B5es gerados pelo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="portador">Indica qual \u00C3\u00A9 a rela\u00C3\u00A7\u00C3\u00A3o do portador do cart\u00C3\u00A3o com a conta. Quando \u00E2\u0080\u00981\u00E2\u0080\u0099, corresponde ao seu titular. Quando diferente disso, corresponde a um cart\u00C3\u00A3o adicional. (optional)</param>
        /// <param name="numeroCartao">Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="dataGeracao">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param>
        /// <param name="dataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataValidade">Apresenta a data de validade do cart\u00C3\u00A3o em formato AAAA-MM, quando houver. (optional)</param>
        /// <param name="dataImpressao">Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica. (optional)</param>
        /// <param name="arquivoImpressao">Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver. (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial. (optional)</param>
        /// <param name="flagProvisorio">Quando ativa, indica que o cart\u00C3\u00A3o \u00C3\u00A9 provis\u00C3\u00B3rio. Ou seja, \u00C3\u00A9 um cart\u00C3\u00A3o para uso tempor\u00C3\u00A1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00C3\u00A3o definitivo. (optional)</param>
        /// <param name="codigoDesbloqueio">Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ListaDeCartes</returns>
        System.Threading.Tasks.Task<ListaDeCartes> ListarUsingGETAsync (long? idCartao = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, int? portador = null, string numeroCartao = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista os Cart\u00C3\u00B5es gerados pelo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="portador">Indica qual \u00C3\u00A9 a rela\u00C3\u00A7\u00C3\u00A3o do portador do cart\u00C3\u00A3o com a conta. Quando \u00E2\u0080\u00981\u00E2\u0080\u0099, corresponde ao seu titular. Quando diferente disso, corresponde a um cart\u00C3\u00A3o adicional. (optional)</param>
        /// <param name="numeroCartao">Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="dataGeracao">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param>
        /// <param name="dataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataValidade">Apresenta a data de validade do cart\u00C3\u00A3o em formato AAAA-MM, quando houver. (optional)</param>
        /// <param name="dataImpressao">Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica. (optional)</param>
        /// <param name="arquivoImpressao">Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver. (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial. (optional)</param>
        /// <param name="flagProvisorio">Quando ativa, indica que o cart\u00C3\u00A3o \u00C3\u00A9 provis\u00C3\u00B3rio. Ou seja, \u00C3\u00A9 um cart\u00C3\u00A3o para uso tempor\u00C3\u00A1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00C3\u00A3o definitivo. (optional)</param>
        /// <param name="codigoDesbloqueio">Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ApiResponse (ListaDeCartes)</returns>
        System.Threading.Tasks.Task<ApiResponse<ListaDeCartes>> ListarUsingGETAsyncWithHttpInfo (long? idCartao = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, int? portador = null, string numeroCartao = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? page = null, int? limit = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CartoApi : ICartoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CartoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CartoApi(Configuration configuration = null)
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
        /// Apresenta os dados de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es b\u00C3\u00A1sicas de um determinado Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>OrigemComercial</returns>
        public OrigemComercial ConsultarUsingGET (long? idCartao)
        {
             ApiResponse<OrigemComercial> localVarResponse = ConsultarUsingGETWithHttpInfo(idCartao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es b\u00C3\u00A1sicas de um determinado Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>ApiResponse of OrigemComercial</returns>
        public ApiResponse< OrigemComercial > ConsultarUsingGETWithHttpInfo (long? idCartao)
        {
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling CartoApi->ConsultarUsingGET");
            
    
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
    
            return new ApiResponse<OrigemComercial>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrigemComercial) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrigemComercial)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es b\u00C3\u00A1sicas de um determinado Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of OrigemComercial</returns>
        public async System.Threading.Tasks.Task<OrigemComercial> ConsultarUsingGETAsync (long? idCartao)
        {
             ApiResponse<OrigemComercial> localVarResponse = await ConsultarUsingGETAsyncWithHttpInfo(idCartao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es b\u00C3\u00A1sicas de um determinado Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (OrigemComercial)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrigemComercial>> ConsultarUsingGETAsyncWithHttpInfo (long? idCartao)
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

            return new ApiResponse<OrigemComercial>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrigemComercial) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrigemComercial)));
            
        }
        
        /// <summary>
        /// Lista os Cart\u00C3\u00B5es gerados pelo Emissor Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param> 
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (optional)</param> 
        /// <param name="idEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param> 
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence (id). (optional)</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o cart\u00C3\u00A3o pertence (id). (optional)</param> 
        /// <param name="portador">Indica qual \u00C3\u00A9 a rela\u00C3\u00A7\u00C3\u00A3o do portador do cart\u00C3\u00A3o com a conta. Quando \u00E2\u0080\u00981\u00E2\u0080\u0099, corresponde ao seu titular. Quando diferente disso, corresponde a um cart\u00C3\u00A3o adicional. (optional)</param> 
        /// <param name="numeroCartao">Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="dataGeracao">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param> 
        /// <param name="dataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param> 
        /// <param name="dataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param> 
        /// <param name="dataValidade">Apresenta a data de validade do cart\u00C3\u00A3o em formato AAAA-MM, quando houver. (optional)</param> 
        /// <param name="dataImpressao">Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica. (optional)</param> 
        /// <param name="arquivoImpressao">Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver. (optional)</param> 
        /// <param name="flagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial. (optional)</param> 
        /// <param name="flagProvisorio">Quando ativa, indica que o cart\u00C3\u00A3o \u00C3\u00A9 provis\u00C3\u00B3rio. Ou seja, \u00C3\u00A9 um cart\u00C3\u00A3o para uso tempor\u00C3\u00A1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00C3\u00A3o definitivo. (optional)</param> 
        /// <param name="codigoDesbloqueio">Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <returns>ListaDeCartes</returns>
        public ListaDeCartes ListarUsingGET (long? idCartao = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, int? portador = null, string numeroCartao = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? page = null, int? limit = null)
        {
             ApiResponse<ListaDeCartes> localVarResponse = ListarUsingGETWithHttpInfo(idCartao, idStatusCartao, idEstagioCartao, idConta, idPessoa, portador, numeroCartao, dataGeracao, dataStatusCartao, dataEstagioCartao, dataValidade, dataImpressao, arquivoImpressao, flagImpressaoOrigemComercial, flagProvisorio, codigoDesbloqueio, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Cart\u00C3\u00B5es gerados pelo Emissor Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param> 
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (optional)</param> 
        /// <param name="idEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param> 
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence (id). (optional)</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o cart\u00C3\u00A3o pertence (id). (optional)</param> 
        /// <param name="portador">Indica qual \u00C3\u00A9 a rela\u00C3\u00A7\u00C3\u00A3o do portador do cart\u00C3\u00A3o com a conta. Quando \u00E2\u0080\u00981\u00E2\u0080\u0099, corresponde ao seu titular. Quando diferente disso, corresponde a um cart\u00C3\u00A3o adicional. (optional)</param> 
        /// <param name="numeroCartao">Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="dataGeracao">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param> 
        /// <param name="dataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param> 
        /// <param name="dataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param> 
        /// <param name="dataValidade">Apresenta a data de validade do cart\u00C3\u00A3o em formato AAAA-MM, quando houver. (optional)</param> 
        /// <param name="dataImpressao">Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica. (optional)</param> 
        /// <param name="arquivoImpressao">Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver. (optional)</param> 
        /// <param name="flagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial. (optional)</param> 
        /// <param name="flagProvisorio">Quando ativa, indica que o cart\u00C3\u00A3o \u00C3\u00A9 provis\u00C3\u00B3rio. Ou seja, \u00C3\u00A9 um cart\u00C3\u00A3o para uso tempor\u00C3\u00A1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00C3\u00A3o definitivo. (optional)</param> 
        /// <param name="codigoDesbloqueio">Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <returns>ApiResponse of ListaDeCartes</returns>
        public ApiResponse< ListaDeCartes > ListarUsingGETWithHttpInfo (long? idCartao = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, int? portador = null, string numeroCartao = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? page = null, int? limit = null)
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
            
            if (idCartao != null) localVarQueryParams.Add("id_cartao", Configuration.ApiClient.ParameterToString(idCartao)); // query parameter
            if (idStatusCartao != null) localVarQueryParams.Add("id_status_cartao", Configuration.ApiClient.ParameterToString(idStatusCartao)); // query parameter
            if (idEstagioCartao != null) localVarQueryParams.Add("id_estagio_cartao", Configuration.ApiClient.ParameterToString(idEstagioCartao)); // query parameter
            if (idConta != null) localVarQueryParams.Add("id_conta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("id_pessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (portador != null) localVarQueryParams.Add("portador", Configuration.ApiClient.ParameterToString(portador)); // query parameter
            if (numeroCartao != null) localVarQueryParams.Add("numero_cartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            if (dataGeracao != null) localVarQueryParams.Add("data_geracao", Configuration.ApiClient.ParameterToString(dataGeracao)); // query parameter
            if (dataStatusCartao != null) localVarQueryParams.Add("data_status_cartao", Configuration.ApiClient.ParameterToString(dataStatusCartao)); // query parameter
            if (dataEstagioCartao != null) localVarQueryParams.Add("data_estagio_cartao", Configuration.ApiClient.ParameterToString(dataEstagioCartao)); // query parameter
            if (dataValidade != null) localVarQueryParams.Add("data_validade", Configuration.ApiClient.ParameterToString(dataValidade)); // query parameter
            if (dataImpressao != null) localVarQueryParams.Add("data_impressao", Configuration.ApiClient.ParameterToString(dataImpressao)); // query parameter
            if (arquivoImpressao != null) localVarQueryParams.Add("arquivo_impressao", Configuration.ApiClient.ParameterToString(arquivoImpressao)); // query parameter
            if (flagImpressaoOrigemComercial != null) localVarQueryParams.Add("flag_impressao_origem_comercial", Configuration.ApiClient.ParameterToString(flagImpressaoOrigemComercial)); // query parameter
            if (flagProvisorio != null) localVarQueryParams.Add("flag_provisorio", Configuration.ApiClient.ParameterToString(flagProvisorio)); // query parameter
            if (codigoDesbloqueio != null) localVarQueryParams.Add("codigo_desbloqueio", Configuration.ApiClient.ParameterToString(codigoDesbloqueio)); // query parameter
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
    
            return new ApiResponse<ListaDeCartes>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ListaDeCartes) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ListaDeCartes)));
            
        }

        
        /// <summary>
        /// Lista os Cart\u00C3\u00B5es gerados pelo Emissor Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="portador">Indica qual \u00C3\u00A9 a rela\u00C3\u00A7\u00C3\u00A3o do portador do cart\u00C3\u00A3o com a conta. Quando \u00E2\u0080\u00981\u00E2\u0080\u0099, corresponde ao seu titular. Quando diferente disso, corresponde a um cart\u00C3\u00A3o adicional. (optional)</param>
        /// <param name="numeroCartao">Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="dataGeracao">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param>
        /// <param name="dataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataValidade">Apresenta a data de validade do cart\u00C3\u00A3o em formato AAAA-MM, quando houver. (optional)</param>
        /// <param name="dataImpressao">Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica. (optional)</param>
        /// <param name="arquivoImpressao">Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver. (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial. (optional)</param>
        /// <param name="flagProvisorio">Quando ativa, indica que o cart\u00C3\u00A3o \u00C3\u00A9 provis\u00C3\u00B3rio. Ou seja, \u00C3\u00A9 um cart\u00C3\u00A3o para uso tempor\u00C3\u00A1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00C3\u00A3o definitivo. (optional)</param>
        /// <param name="codigoDesbloqueio">Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ListaDeCartes</returns>
        public async System.Threading.Tasks.Task<ListaDeCartes> ListarUsingGETAsync (long? idCartao = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, int? portador = null, string numeroCartao = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? page = null, int? limit = null)
        {
             ApiResponse<ListaDeCartes> localVarResponse = await ListarUsingGETAsyncWithHttpInfo(idCartao, idStatusCartao, idEstagioCartao, idConta, idPessoa, portador, numeroCartao, dataGeracao, dataStatusCartao, dataEstagioCartao, dataValidade, dataImpressao, arquivoImpressao, flagImpressaoOrigemComercial, flagProvisorio, codigoDesbloqueio, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Cart\u00C3\u00B5es gerados pelo Emissor Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="portador">Indica qual \u00C3\u00A9 a rela\u00C3\u00A7\u00C3\u00A3o do portador do cart\u00C3\u00A3o com a conta. Quando \u00E2\u0080\u00981\u00E2\u0080\u0099, corresponde ao seu titular. Quando diferente disso, corresponde a um cart\u00C3\u00A3o adicional. (optional)</param>
        /// <param name="numeroCartao">Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="dataGeracao">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param>
        /// <param name="dataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataValidade">Apresenta a data de validade do cart\u00C3\u00A3o em formato AAAA-MM, quando houver. (optional)</param>
        /// <param name="dataImpressao">Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica. (optional)</param>
        /// <param name="arquivoImpressao">Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver. (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial. (optional)</param>
        /// <param name="flagProvisorio">Quando ativa, indica que o cart\u00C3\u00A3o \u00C3\u00A9 provis\u00C3\u00B3rio. Ou seja, \u00C3\u00A9 um cart\u00C3\u00A3o para uso tempor\u00C3\u00A1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00C3\u00A3o definitivo. (optional)</param>
        /// <param name="codigoDesbloqueio">Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ApiResponse (ListaDeCartes)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ListaDeCartes>> ListarUsingGETAsyncWithHttpInfo (long? idCartao = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, int? portador = null, string numeroCartao = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? page = null, int? limit = null)
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
            
            if (idCartao != null) localVarQueryParams.Add("id_cartao", Configuration.ApiClient.ParameterToString(idCartao)); // query parameter
            if (idStatusCartao != null) localVarQueryParams.Add("id_status_cartao", Configuration.ApiClient.ParameterToString(idStatusCartao)); // query parameter
            if (idEstagioCartao != null) localVarQueryParams.Add("id_estagio_cartao", Configuration.ApiClient.ParameterToString(idEstagioCartao)); // query parameter
            if (idConta != null) localVarQueryParams.Add("id_conta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("id_pessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (portador != null) localVarQueryParams.Add("portador", Configuration.ApiClient.ParameterToString(portador)); // query parameter
            if (numeroCartao != null) localVarQueryParams.Add("numero_cartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            if (dataGeracao != null) localVarQueryParams.Add("data_geracao", Configuration.ApiClient.ParameterToString(dataGeracao)); // query parameter
            if (dataStatusCartao != null) localVarQueryParams.Add("data_status_cartao", Configuration.ApiClient.ParameterToString(dataStatusCartao)); // query parameter
            if (dataEstagioCartao != null) localVarQueryParams.Add("data_estagio_cartao", Configuration.ApiClient.ParameterToString(dataEstagioCartao)); // query parameter
            if (dataValidade != null) localVarQueryParams.Add("data_validade", Configuration.ApiClient.ParameterToString(dataValidade)); // query parameter
            if (dataImpressao != null) localVarQueryParams.Add("data_impressao", Configuration.ApiClient.ParameterToString(dataImpressao)); // query parameter
            if (arquivoImpressao != null) localVarQueryParams.Add("arquivo_impressao", Configuration.ApiClient.ParameterToString(arquivoImpressao)); // query parameter
            if (flagImpressaoOrigemComercial != null) localVarQueryParams.Add("flag_impressao_origem_comercial", Configuration.ApiClient.ParameterToString(flagImpressaoOrigemComercial)); // query parameter
            if (flagProvisorio != null) localVarQueryParams.Add("flag_provisorio", Configuration.ApiClient.ParameterToString(flagProvisorio)); // query parameter
            if (codigoDesbloqueio != null) localVarQueryParams.Add("codigo_desbloqueio", Configuration.ApiClient.ParameterToString(codigoDesbloqueio)); // query parameter
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

            return new ApiResponse<ListaDeCartes>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ListaDeCartes) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ListaDeCartes)));
            
        }
        
    }
    
}
