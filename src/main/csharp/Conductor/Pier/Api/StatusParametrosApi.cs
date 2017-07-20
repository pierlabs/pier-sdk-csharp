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
    public interface IStatusParametrosApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Apresenta os dados de um determinado Estagio Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o (id).</param>
        /// <returns>EstagioCartaoResponse</returns>
        EstagioCartaoResponse ConsultarEstagioCartaoUsingGET (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Estagio Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o (id).</param>
        /// <returns>ApiResponse of EstagioCartaoResponse</returns>
        ApiResponse<EstagioCartaoResponse> ConsultarEstagioCartaoUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Status Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status de Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o (id).</param>
        /// <returns>StatusCartaoResponse</returns>
        StatusCartaoResponse ConsultarStatusCartaoUsingGET (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Status Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status de Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o (id).</param>
        /// <returns>ApiResponse of StatusCartaoResponse</returns>
        ApiResponse<StatusCartaoResponse> ConsultarStatusCartaoUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Status Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status Conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id).</param>
        /// <returns>StatusContaResponse</returns>
        StatusContaResponse ConsultarUsingGET14 (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Status Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status Conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id).</param>
        /// <returns>ApiResponse of StatusContaResponse</returns>
        ApiResponse<StatusContaResponse> ConsultarUsingGET14WithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Status Impress\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>StatusImpressaoResponse</returns>
        StatusImpressaoResponse ConsultarUsingGET15 (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Status Impress\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>ApiResponse of StatusImpressaoResponse</returns>
        ApiResponse<StatusImpressaoResponse> ConsultarUsingGET15WithHttpInfo (long? id);
        
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gios do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gio de Entrega que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="nome">Nome do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <returns>PageEstagioCartaoResponse</returns>
        PageEstagioCartaoResponse ListarEstagiosCartoesUsingGET (int? page = null, int? limit = null, long? id = null, string nome = null);
  
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gios do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gio de Entrega que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="nome">Nome do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <returns>ApiResponse of PageEstagioCartaoResponse</returns>
        ApiResponse<PageEstagioCartaoResponse> ListarEstagiosCartoesUsingGETWithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null);
        
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id)  (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagCancelaCartao">Quando ativa, indica que ao ser atribu\u00C3\u00ADdo um idStatusCartao com essa caracter\u00C3\u00ADstica, o cart\u00C3\u00A3o ter\u00C3\u00A1 o seu idStatusCartao alterado para o que fora escolhido. Caso contr\u00C3\u00A1rio, o idStatusCartao s\u00C3\u00B3 ser\u00C3\u00A1 alterado ap\u00C3\u00B3s o desbloqueio de um novo cart\u00C3\u00A3o do mesmo Portador e Conta. (optional)</param>
        /// <param name="flagCancelaNoDesbloqueio">Quando ativa, indica que o cart\u00C3\u00A3o ativo que o portador possuir na mesma conta do cart\u00C3\u00A3o a ser desbloqueado, e que o status dele possua essa caracter\u00C3\u00ADstica, dever\u00C3\u00A1 ser cancelado quando um novo cart\u00C3\u00A3o for desbloqueado. (optional)</param>
        /// <param name="idStatusDestinoDesbloqueio">Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo aos cart\u00C3\u00B5es que forem cancelados devido ao desbloqueio de um novo cart\u00C3\u00A3o. (optional)</param>
        /// <param name="idStatusDestinoConta">Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo a conta, caso ela seja cancelada devido ao bloqueio de um cart\u00C3\u00A3o quando for utilizado um idStatusCartao no processo de Bloqueio que possua essa caracter\u00C3\u00ADstica. (optional)</param>
        /// <param name="flagCobraTarifa">Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, incluir\u00C3\u00A3o a cobran\u00C3\u00A7a de uma tarifa para a conta de acordo com os valores definidos nos par\u00C3\u00A2metros do emissor. (optional)</param>
        /// <param name="flagPermiteNovaViaCartao">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a solicita\u00C3\u00A7\u00C3\u00A3o de uma nova via, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagPermiteDesbloqueio">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o desbloqueio, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagCancelamento">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o cancelamento, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagPermiteBloqueio">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o Bloqueio, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagReativar">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <returns>PageStatusCartaoResponse</returns>
        PageStatusCartaoResponse ListarStatusCartoesUsingGET (int? page = null, int? limit = null, long? id = null, string nome = null, int? flagCancelaCartao = null, int? flagCancelaNoDesbloqueio = null, long? idStatusDestinoDesbloqueio = null, long? idStatusDestinoConta = null, int? flagCobraTarifa = null, int? flagPermiteNovaViaCartao = null, int? flagPermiteDesbloqueio = null, int? flagCancelamento = null, int? flagPermiteBloqueio = null, int? flagReativar = null);
  
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id)  (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagCancelaCartao">Quando ativa, indica que ao ser atribu\u00C3\u00ADdo um idStatusCartao com essa caracter\u00C3\u00ADstica, o cart\u00C3\u00A3o ter\u00C3\u00A1 o seu idStatusCartao alterado para o que fora escolhido. Caso contr\u00C3\u00A1rio, o idStatusCartao s\u00C3\u00B3 ser\u00C3\u00A1 alterado ap\u00C3\u00B3s o desbloqueio de um novo cart\u00C3\u00A3o do mesmo Portador e Conta. (optional)</param>
        /// <param name="flagCancelaNoDesbloqueio">Quando ativa, indica que o cart\u00C3\u00A3o ativo que o portador possuir na mesma conta do cart\u00C3\u00A3o a ser desbloqueado, e que o status dele possua essa caracter\u00C3\u00ADstica, dever\u00C3\u00A1 ser cancelado quando um novo cart\u00C3\u00A3o for desbloqueado. (optional)</param>
        /// <param name="idStatusDestinoDesbloqueio">Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo aos cart\u00C3\u00B5es que forem cancelados devido ao desbloqueio de um novo cart\u00C3\u00A3o. (optional)</param>
        /// <param name="idStatusDestinoConta">Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo a conta, caso ela seja cancelada devido ao bloqueio de um cart\u00C3\u00A3o quando for utilizado um idStatusCartao no processo de Bloqueio que possua essa caracter\u00C3\u00ADstica. (optional)</param>
        /// <param name="flagCobraTarifa">Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, incluir\u00C3\u00A3o a cobran\u00C3\u00A7a de uma tarifa para a conta de acordo com os valores definidos nos par\u00C3\u00A2metros do emissor. (optional)</param>
        /// <param name="flagPermiteNovaViaCartao">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a solicita\u00C3\u00A7\u00C3\u00A3o de uma nova via, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagPermiteDesbloqueio">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o desbloqueio, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagCancelamento">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o cancelamento, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagPermiteBloqueio">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o Bloqueio, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagReativar">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <returns>ApiResponse of PageStatusCartaoResponse</returns>
        ApiResponse<PageStatusCartaoResponse> ListarStatusCartoesUsingGETWithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null, int? flagCancelaCartao = null, int? flagCancelaNoDesbloqueio = null, long? idStatusDestinoDesbloqueio = null, long? idStatusDestinoConta = null, int? flagCobraTarifa = null, int? flagPermiteNovaViaCartao = null, int? flagPermiteDesbloqueio = null, int? flagCancelamento = null, int? flagPermiteBloqueio = null, int? flagReativar = null);
        
        /// <summary>
        /// Lista os Status Contas cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Status Contas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id). (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status da Conta. (optional)</param>
        /// <param name="flagAlteraLimite">Par\u00C3\u00A2metro que define se o Status da Conta permite realizar a Altera\u00C3\u00A7\u00C3\u00A3o de Limites do Portador, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="mensagemConsultaNegada">Apresenta o texto com o motivo que ser\u00C3\u00A1 apresentado na resposta as opera\u00C3\u00A7\u00C3\u00B5es de Listar e Consultar LimitesDisponibilidades. (optional)</param>
        /// <param name="flagPermiteNovaViaCartao">Par\u00C3\u00A2metro que define se o Status da conta permite a solicita\u00C3\u00A7\u00C3\u00A3o de um novo cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagFazTransferencia">Par\u00C3\u00A2metro que define se o Status da conta permite fazer transferencia, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagRecebeTransferencia">Par\u00C3\u00A2metro que define se o Status da conta permite receber transferencia, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagPermiteBloqueio">Par\u00C3\u00A2metro que define se o Status da conta permite receber bloqueio, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagPermiteDesbloqueio">Par\u00C3\u00A2metro que define se o Status da conta permite receber desbloqueio, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagCancelaConta">Par\u00C3\u00A2metro que define se o Status da conta permite receber cancelamento, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <returns>PageStatusContaResponse</returns>
        PageStatusContaResponse ListarUsingGET20 (int? page = null, int? limit = null, long? id = null, string nome = null, int? flagAlteraLimite = null, string mensagemConsultaNegada = null, int? flagPermiteNovaViaCartao = null, int? flagFazTransferencia = null, int? flagRecebeTransferencia = null, int? flagPermiteBloqueio = null, int? flagPermiteDesbloqueio = null, int? flagCancelaConta = null);
  
        /// <summary>
        /// Lista os Status Contas cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Status Contas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id). (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status da Conta. (optional)</param>
        /// <param name="flagAlteraLimite">Par\u00C3\u00A2metro que define se o Status da Conta permite realizar a Altera\u00C3\u00A7\u00C3\u00A3o de Limites do Portador, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="mensagemConsultaNegada">Apresenta o texto com o motivo que ser\u00C3\u00A1 apresentado na resposta as opera\u00C3\u00A7\u00C3\u00B5es de Listar e Consultar LimitesDisponibilidades. (optional)</param>
        /// <param name="flagPermiteNovaViaCartao">Par\u00C3\u00A2metro que define se o Status da conta permite a solicita\u00C3\u00A7\u00C3\u00A3o de um novo cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagFazTransferencia">Par\u00C3\u00A2metro que define se o Status da conta permite fazer transferencia, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagRecebeTransferencia">Par\u00C3\u00A2metro que define se o Status da conta permite receber transferencia, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagPermiteBloqueio">Par\u00C3\u00A2metro que define se o Status da conta permite receber bloqueio, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagPermiteDesbloqueio">Par\u00C3\u00A2metro que define se o Status da conta permite receber desbloqueio, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagCancelaConta">Par\u00C3\u00A2metro que define se o Status da conta permite receber cancelamento, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <returns>ApiResponse of PageStatusContaResponse</returns>
        ApiResponse<PageStatusContaResponse> ListarUsingGET20WithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null, int? flagAlteraLimite = null, string mensagemConsultaNegada = null, int? flagPermiteNovaViaCartao = null, int? flagFazTransferencia = null, int? flagRecebeTransferencia = null, int? flagPermiteBloqueio = null, int? flagPermiteDesbloqueio = null, int? flagCancelaConta = null);
        
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status Impress\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Status Impress\u00C3\u00A3o que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="nome">Nome do status impress\u00C3\u00A3o (optional)</param>
        /// <returns>PageStatusImpressaoResponse</returns>
        PageStatusImpressaoResponse ListarUsingGET21 (int? page = null, int? limit = null, long? id = null, string nome = null);
  
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status Impress\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Status Impress\u00C3\u00A3o que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="nome">Nome do status impress\u00C3\u00A3o (optional)</param>
        /// <returns>ApiResponse of PageStatusImpressaoResponse</returns>
        ApiResponse<PageStatusImpressaoResponse> ListarUsingGET21WithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Apresenta os dados de um determinado Estagio Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of EstagioCartaoResponse</returns>
        System.Threading.Tasks.Task<EstagioCartaoResponse> ConsultarEstagioCartaoUsingGETAsync (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Estagio Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (EstagioCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EstagioCartaoResponse>> ConsultarEstagioCartaoUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Status Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status de Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of StatusCartaoResponse</returns>
        System.Threading.Tasks.Task<StatusCartaoResponse> ConsultarStatusCartaoUsingGETAsync (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Status Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status de Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (StatusCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StatusCartaoResponse>> ConsultarStatusCartaoUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Status Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status Conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id).</param>
        /// <returns>Task of StatusContaResponse</returns>
        System.Threading.Tasks.Task<StatusContaResponse> ConsultarUsingGET14Async (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Status Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status Conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id).</param>
        /// <returns>Task of ApiResponse (StatusContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StatusContaResponse>> ConsultarUsingGET14AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Status Impress\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of StatusImpressaoResponse</returns>
        System.Threading.Tasks.Task<StatusImpressaoResponse> ConsultarUsingGET15Async (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Status Impress\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (StatusImpressaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StatusImpressaoResponse>> ConsultarUsingGET15AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gios do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gio de Entrega que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="nome">Nome do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <returns>Task of PageEstagioCartaoResponse</returns>
        System.Threading.Tasks.Task<PageEstagioCartaoResponse> ListarEstagiosCartoesUsingGETAsync (int? page = null, int? limit = null, long? id = null, string nome = null);

        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gios do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gio de Entrega que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="nome">Nome do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <returns>Task of ApiResponse (PageEstagioCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageEstagioCartaoResponse>> ListarEstagiosCartoesUsingGETAsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null);
        
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id)  (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagCancelaCartao">Quando ativa, indica que ao ser atribu\u00C3\u00ADdo um idStatusCartao com essa caracter\u00C3\u00ADstica, o cart\u00C3\u00A3o ter\u00C3\u00A1 o seu idStatusCartao alterado para o que fora escolhido. Caso contr\u00C3\u00A1rio, o idStatusCartao s\u00C3\u00B3 ser\u00C3\u00A1 alterado ap\u00C3\u00B3s o desbloqueio de um novo cart\u00C3\u00A3o do mesmo Portador e Conta. (optional)</param>
        /// <param name="flagCancelaNoDesbloqueio">Quando ativa, indica que o cart\u00C3\u00A3o ativo que o portador possuir na mesma conta do cart\u00C3\u00A3o a ser desbloqueado, e que o status dele possua essa caracter\u00C3\u00ADstica, dever\u00C3\u00A1 ser cancelado quando um novo cart\u00C3\u00A3o for desbloqueado. (optional)</param>
        /// <param name="idStatusDestinoDesbloqueio">Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo aos cart\u00C3\u00B5es que forem cancelados devido ao desbloqueio de um novo cart\u00C3\u00A3o. (optional)</param>
        /// <param name="idStatusDestinoConta">Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo a conta, caso ela seja cancelada devido ao bloqueio de um cart\u00C3\u00A3o quando for utilizado um idStatusCartao no processo de Bloqueio que possua essa caracter\u00C3\u00ADstica. (optional)</param>
        /// <param name="flagCobraTarifa">Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, incluir\u00C3\u00A3o a cobran\u00C3\u00A7a de uma tarifa para a conta de acordo com os valores definidos nos par\u00C3\u00A2metros do emissor. (optional)</param>
        /// <param name="flagPermiteNovaViaCartao">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a solicita\u00C3\u00A7\u00C3\u00A3o de uma nova via, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagPermiteDesbloqueio">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o desbloqueio, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagCancelamento">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o cancelamento, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagPermiteBloqueio">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o Bloqueio, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagReativar">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <returns>Task of PageStatusCartaoResponse</returns>
        System.Threading.Tasks.Task<PageStatusCartaoResponse> ListarStatusCartoesUsingGETAsync (int? page = null, int? limit = null, long? id = null, string nome = null, int? flagCancelaCartao = null, int? flagCancelaNoDesbloqueio = null, long? idStatusDestinoDesbloqueio = null, long? idStatusDestinoConta = null, int? flagCobraTarifa = null, int? flagPermiteNovaViaCartao = null, int? flagPermiteDesbloqueio = null, int? flagCancelamento = null, int? flagPermiteBloqueio = null, int? flagReativar = null);

        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id)  (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagCancelaCartao">Quando ativa, indica que ao ser atribu\u00C3\u00ADdo um idStatusCartao com essa caracter\u00C3\u00ADstica, o cart\u00C3\u00A3o ter\u00C3\u00A1 o seu idStatusCartao alterado para o que fora escolhido. Caso contr\u00C3\u00A1rio, o idStatusCartao s\u00C3\u00B3 ser\u00C3\u00A1 alterado ap\u00C3\u00B3s o desbloqueio de um novo cart\u00C3\u00A3o do mesmo Portador e Conta. (optional)</param>
        /// <param name="flagCancelaNoDesbloqueio">Quando ativa, indica que o cart\u00C3\u00A3o ativo que o portador possuir na mesma conta do cart\u00C3\u00A3o a ser desbloqueado, e que o status dele possua essa caracter\u00C3\u00ADstica, dever\u00C3\u00A1 ser cancelado quando um novo cart\u00C3\u00A3o for desbloqueado. (optional)</param>
        /// <param name="idStatusDestinoDesbloqueio">Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo aos cart\u00C3\u00B5es que forem cancelados devido ao desbloqueio de um novo cart\u00C3\u00A3o. (optional)</param>
        /// <param name="idStatusDestinoConta">Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo a conta, caso ela seja cancelada devido ao bloqueio de um cart\u00C3\u00A3o quando for utilizado um idStatusCartao no processo de Bloqueio que possua essa caracter\u00C3\u00ADstica. (optional)</param>
        /// <param name="flagCobraTarifa">Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, incluir\u00C3\u00A3o a cobran\u00C3\u00A7a de uma tarifa para a conta de acordo com os valores definidos nos par\u00C3\u00A2metros do emissor. (optional)</param>
        /// <param name="flagPermiteNovaViaCartao">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a solicita\u00C3\u00A7\u00C3\u00A3o de uma nova via, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagPermiteDesbloqueio">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o desbloqueio, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagCancelamento">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o cancelamento, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagPermiteBloqueio">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o Bloqueio, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagReativar">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageStatusCartaoResponse>> ListarStatusCartoesUsingGETAsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null, int? flagCancelaCartao = null, int? flagCancelaNoDesbloqueio = null, long? idStatusDestinoDesbloqueio = null, long? idStatusDestinoConta = null, int? flagCobraTarifa = null, int? flagPermiteNovaViaCartao = null, int? flagPermiteDesbloqueio = null, int? flagCancelamento = null, int? flagPermiteBloqueio = null, int? flagReativar = null);
        
        /// <summary>
        /// Lista os Status Contas cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Status Contas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id). (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status da Conta. (optional)</param>
        /// <param name="flagAlteraLimite">Par\u00C3\u00A2metro que define se o Status da Conta permite realizar a Altera\u00C3\u00A7\u00C3\u00A3o de Limites do Portador, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="mensagemConsultaNegada">Apresenta o texto com o motivo que ser\u00C3\u00A1 apresentado na resposta as opera\u00C3\u00A7\u00C3\u00B5es de Listar e Consultar LimitesDisponibilidades. (optional)</param>
        /// <param name="flagPermiteNovaViaCartao">Par\u00C3\u00A2metro que define se o Status da conta permite a solicita\u00C3\u00A7\u00C3\u00A3o de um novo cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagFazTransferencia">Par\u00C3\u00A2metro que define se o Status da conta permite fazer transferencia, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagRecebeTransferencia">Par\u00C3\u00A2metro que define se o Status da conta permite receber transferencia, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagPermiteBloqueio">Par\u00C3\u00A2metro que define se o Status da conta permite receber bloqueio, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagPermiteDesbloqueio">Par\u00C3\u00A2metro que define se o Status da conta permite receber desbloqueio, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagCancelaConta">Par\u00C3\u00A2metro que define se o Status da conta permite receber cancelamento, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <returns>Task of PageStatusContaResponse</returns>
        System.Threading.Tasks.Task<PageStatusContaResponse> ListarUsingGET20Async (int? page = null, int? limit = null, long? id = null, string nome = null, int? flagAlteraLimite = null, string mensagemConsultaNegada = null, int? flagPermiteNovaViaCartao = null, int? flagFazTransferencia = null, int? flagRecebeTransferencia = null, int? flagPermiteBloqueio = null, int? flagPermiteDesbloqueio = null, int? flagCancelaConta = null);

        /// <summary>
        /// Lista os Status Contas cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Status Contas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id). (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status da Conta. (optional)</param>
        /// <param name="flagAlteraLimite">Par\u00C3\u00A2metro que define se o Status da Conta permite realizar a Altera\u00C3\u00A7\u00C3\u00A3o de Limites do Portador, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="mensagemConsultaNegada">Apresenta o texto com o motivo que ser\u00C3\u00A1 apresentado na resposta as opera\u00C3\u00A7\u00C3\u00B5es de Listar e Consultar LimitesDisponibilidades. (optional)</param>
        /// <param name="flagPermiteNovaViaCartao">Par\u00C3\u00A2metro que define se o Status da conta permite a solicita\u00C3\u00A7\u00C3\u00A3o de um novo cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagFazTransferencia">Par\u00C3\u00A2metro que define se o Status da conta permite fazer transferencia, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagRecebeTransferencia">Par\u00C3\u00A2metro que define se o Status da conta permite receber transferencia, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagPermiteBloqueio">Par\u00C3\u00A2metro que define se o Status da conta permite receber bloqueio, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagPermiteDesbloqueio">Par\u00C3\u00A2metro que define se o Status da conta permite receber desbloqueio, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagCancelaConta">Par\u00C3\u00A2metro que define se o Status da conta permite receber cancelamento, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageStatusContaResponse>> ListarUsingGET20AsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null, int? flagAlteraLimite = null, string mensagemConsultaNegada = null, int? flagPermiteNovaViaCartao = null, int? flagFazTransferencia = null, int? flagRecebeTransferencia = null, int? flagPermiteBloqueio = null, int? flagPermiteDesbloqueio = null, int? flagCancelaConta = null);
        
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status Impress\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Status Impress\u00C3\u00A3o que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="nome">Nome do status impress\u00C3\u00A3o (optional)</param>
        /// <returns>Task of PageStatusImpressaoResponse</returns>
        System.Threading.Tasks.Task<PageStatusImpressaoResponse> ListarUsingGET21Async (int? page = null, int? limit = null, long? id = null, string nome = null);

        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status Impress\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Status Impress\u00C3\u00A3o que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="nome">Nome do status impress\u00C3\u00A3o (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusImpressaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageStatusImpressaoResponse>> ListarUsingGET21AsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class StatusParametrosApi : IStatusParametrosApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusParametrosApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StatusParametrosApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusParametrosApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public StatusParametrosApi(Configuration configuration = null)
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
        /// Apresenta os dados de um determinado Estagio Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>EstagioCartaoResponse</returns>
        public EstagioCartaoResponse ConsultarEstagioCartaoUsingGET (long? id)
        {
             ApiResponse<EstagioCartaoResponse> localVarResponse = ConsultarEstagioCartaoUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Estagio Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>ApiResponse of EstagioCartaoResponse</returns>
        public ApiResponse< EstagioCartaoResponse > ConsultarEstagioCartaoUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling StatusParametrosApi->ConsultarEstagioCartaoUsingGET");
            
    
            var localVarPath = "/api/estagios-cartoes/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarEstagioCartaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarEstagioCartaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EstagioCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstagioCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstagioCartaoResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Estagio Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of EstagioCartaoResponse</returns>
        public async System.Threading.Tasks.Task<EstagioCartaoResponse> ConsultarEstagioCartaoUsingGETAsync (long? id)
        {
             ApiResponse<EstagioCartaoResponse> localVarResponse = await ConsultarEstagioCartaoUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Estagio Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (EstagioCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EstagioCartaoResponse>> ConsultarEstagioCartaoUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarEstagioCartaoUsingGET");
            
    
            var localVarPath = "/api/estagios-cartoes/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarEstagioCartaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarEstagioCartaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EstagioCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstagioCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstagioCartaoResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado Status Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status de Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>StatusCartaoResponse</returns>
        public StatusCartaoResponse ConsultarStatusCartaoUsingGET (long? id)
        {
             ApiResponse<StatusCartaoResponse> localVarResponse = ConsultarStatusCartaoUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Status Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status de Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>ApiResponse of StatusCartaoResponse</returns>
        public ApiResponse< StatusCartaoResponse > ConsultarStatusCartaoUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling StatusParametrosApi->ConsultarStatusCartaoUsingGET");
            
    
            var localVarPath = "/api/status-cartoes/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusCartaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusCartaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<StatusCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusCartaoResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Status Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status de Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of StatusCartaoResponse</returns>
        public async System.Threading.Tasks.Task<StatusCartaoResponse> ConsultarStatusCartaoUsingGETAsync (long? id)
        {
             ApiResponse<StatusCartaoResponse> localVarResponse = await ConsultarStatusCartaoUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Status Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status de Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (StatusCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StatusCartaoResponse>> ConsultarStatusCartaoUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarStatusCartaoUsingGET");
            
    
            var localVarPath = "/api/status-cartoes/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusCartaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusCartaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StatusCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusCartaoResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado Status Conta Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status Conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id).</param> 
        /// <returns>StatusContaResponse</returns>
        public StatusContaResponse ConsultarUsingGET14 (long? id)
        {
             ApiResponse<StatusContaResponse> localVarResponse = ConsultarUsingGET14WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Status Conta Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status Conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id).</param> 
        /// <returns>ApiResponse of StatusContaResponse</returns>
        public ApiResponse< StatusContaResponse > ConsultarUsingGET14WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling StatusParametrosApi->ConsultarUsingGET14");
            
    
            var localVarPath = "/api/status-contas/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET14: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET14: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<StatusContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusContaResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Status Conta Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status Conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id).</param>
        /// <returns>Task of StatusContaResponse</returns>
        public async System.Threading.Tasks.Task<StatusContaResponse> ConsultarUsingGET14Async (long? id)
        {
             ApiResponse<StatusContaResponse> localVarResponse = await ConsultarUsingGET14AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Status Conta Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status Conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id).</param>
        /// <returns>Task of ApiResponse (StatusContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StatusContaResponse>> ConsultarUsingGET14AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET14");
            
    
            var localVarPath = "/api/status-contas/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET14: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET14: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StatusContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusContaResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado Status Impress\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>StatusImpressaoResponse</returns>
        public StatusImpressaoResponse ConsultarUsingGET15 (long? id)
        {
             ApiResponse<StatusImpressaoResponse> localVarResponse = ConsultarUsingGET15WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Status Impress\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>ApiResponse of StatusImpressaoResponse</returns>
        public ApiResponse< StatusImpressaoResponse > ConsultarUsingGET15WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling StatusParametrosApi->ConsultarUsingGET15");
            
    
            var localVarPath = "/api/status-impressoes/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET15: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET15: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<StatusImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusImpressaoResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Status Impress\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of StatusImpressaoResponse</returns>
        public async System.Threading.Tasks.Task<StatusImpressaoResponse> ConsultarUsingGET15Async (long? id)
        {
             ApiResponse<StatusImpressaoResponse> localVarResponse = await ConsultarUsingGET15AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Status Impress\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (StatusImpressaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StatusImpressaoResponse>> ConsultarUsingGET15AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET15");
            
    
            var localVarPath = "/api/status-impressoes/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET15: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET15: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StatusImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusImpressaoResponse)));
            
        }
        
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gios do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gio de Entrega que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param> 
        /// <param name="nome">Nome do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param> 
        /// <returns>PageEstagioCartaoResponse</returns>
        public PageEstagioCartaoResponse ListarEstagiosCartoesUsingGET (int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageEstagioCartaoResponse> localVarResponse = ListarEstagiosCartoesUsingGETWithHttpInfo(page, limit, id, nome);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gios do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gio de Entrega que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param> 
        /// <param name="nome">Nome do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param> 
        /// <returns>ApiResponse of PageEstagioCartaoResponse</returns>
        public ApiResponse< PageEstagioCartaoResponse > ListarEstagiosCartoesUsingGETWithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null)
        {
            
    
            var localVarPath = "/api/estagios-cartoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarEstagiosCartoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarEstagiosCartoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageEstagioCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEstagioCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEstagioCartaoResponse)));
            
        }

        
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gios do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gio de Entrega que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="nome">Nome do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <returns>Task of PageEstagioCartaoResponse</returns>
        public async System.Threading.Tasks.Task<PageEstagioCartaoResponse> ListarEstagiosCartoesUsingGETAsync (int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageEstagioCartaoResponse> localVarResponse = await ListarEstagiosCartoesUsingGETAsyncWithHttpInfo(page, limit, id, nome);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gios do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gio de Entrega que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="nome">Nome do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <returns>Task of ApiResponse (PageEstagioCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageEstagioCartaoResponse>> ListarEstagiosCartoesUsingGETAsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null)
        {
            
    
            var localVarPath = "/api/estagios-cartoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarEstagiosCartoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarEstagiosCartoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageEstagioCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEstagioCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEstagioCartaoResponse)));
            
        }
        
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id)  (optional)</param> 
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="flagCancelaCartao">Quando ativa, indica que ao ser atribu\u00C3\u00ADdo um idStatusCartao com essa caracter\u00C3\u00ADstica, o cart\u00C3\u00A3o ter\u00C3\u00A1 o seu idStatusCartao alterado para o que fora escolhido. Caso contr\u00C3\u00A1rio, o idStatusCartao s\u00C3\u00B3 ser\u00C3\u00A1 alterado ap\u00C3\u00B3s o desbloqueio de um novo cart\u00C3\u00A3o do mesmo Portador e Conta. (optional)</param> 
        /// <param name="flagCancelaNoDesbloqueio">Quando ativa, indica que o cart\u00C3\u00A3o ativo que o portador possuir na mesma conta do cart\u00C3\u00A3o a ser desbloqueado, e que o status dele possua essa caracter\u00C3\u00ADstica, dever\u00C3\u00A1 ser cancelado quando um novo cart\u00C3\u00A3o for desbloqueado. (optional)</param> 
        /// <param name="idStatusDestinoDesbloqueio">Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo aos cart\u00C3\u00B5es que forem cancelados devido ao desbloqueio de um novo cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="idStatusDestinoConta">Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo a conta, caso ela seja cancelada devido ao bloqueio de um cart\u00C3\u00A3o quando for utilizado um idStatusCartao no processo de Bloqueio que possua essa caracter\u00C3\u00ADstica. (optional)</param> 
        /// <param name="flagCobraTarifa">Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, incluir\u00C3\u00A3o a cobran\u00C3\u00A7a de uma tarifa para a conta de acordo com os valores definidos nos par\u00C3\u00A2metros do emissor. (optional)</param> 
        /// <param name="flagPermiteNovaViaCartao">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a solicita\u00C3\u00A7\u00C3\u00A3o de uma nova via, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="flagPermiteDesbloqueio">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o desbloqueio, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="flagCancelamento">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o cancelamento, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="flagPermiteBloqueio">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o Bloqueio, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="flagReativar">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <returns>PageStatusCartaoResponse</returns>
        public PageStatusCartaoResponse ListarStatusCartoesUsingGET (int? page = null, int? limit = null, long? id = null, string nome = null, int? flagCancelaCartao = null, int? flagCancelaNoDesbloqueio = null, long? idStatusDestinoDesbloqueio = null, long? idStatusDestinoConta = null, int? flagCobraTarifa = null, int? flagPermiteNovaViaCartao = null, int? flagPermiteDesbloqueio = null, int? flagCancelamento = null, int? flagPermiteBloqueio = null, int? flagReativar = null)
        {
             ApiResponse<PageStatusCartaoResponse> localVarResponse = ListarStatusCartoesUsingGETWithHttpInfo(page, limit, id, nome, flagCancelaCartao, flagCancelaNoDesbloqueio, idStatusDestinoDesbloqueio, idStatusDestinoConta, flagCobraTarifa, flagPermiteNovaViaCartao, flagPermiteDesbloqueio, flagCancelamento, flagPermiteBloqueio, flagReativar);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id)  (optional)</param> 
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="flagCancelaCartao">Quando ativa, indica que ao ser atribu\u00C3\u00ADdo um idStatusCartao com essa caracter\u00C3\u00ADstica, o cart\u00C3\u00A3o ter\u00C3\u00A1 o seu idStatusCartao alterado para o que fora escolhido. Caso contr\u00C3\u00A1rio, o idStatusCartao s\u00C3\u00B3 ser\u00C3\u00A1 alterado ap\u00C3\u00B3s o desbloqueio de um novo cart\u00C3\u00A3o do mesmo Portador e Conta. (optional)</param> 
        /// <param name="flagCancelaNoDesbloqueio">Quando ativa, indica que o cart\u00C3\u00A3o ativo que o portador possuir na mesma conta do cart\u00C3\u00A3o a ser desbloqueado, e que o status dele possua essa caracter\u00C3\u00ADstica, dever\u00C3\u00A1 ser cancelado quando um novo cart\u00C3\u00A3o for desbloqueado. (optional)</param> 
        /// <param name="idStatusDestinoDesbloqueio">Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo aos cart\u00C3\u00B5es que forem cancelados devido ao desbloqueio de um novo cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="idStatusDestinoConta">Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo a conta, caso ela seja cancelada devido ao bloqueio de um cart\u00C3\u00A3o quando for utilizado um idStatusCartao no processo de Bloqueio que possua essa caracter\u00C3\u00ADstica. (optional)</param> 
        /// <param name="flagCobraTarifa">Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, incluir\u00C3\u00A3o a cobran\u00C3\u00A7a de uma tarifa para a conta de acordo com os valores definidos nos par\u00C3\u00A2metros do emissor. (optional)</param> 
        /// <param name="flagPermiteNovaViaCartao">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a solicita\u00C3\u00A7\u00C3\u00A3o de uma nova via, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="flagPermiteDesbloqueio">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o desbloqueio, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="flagCancelamento">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o cancelamento, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="flagPermiteBloqueio">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o Bloqueio, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="flagReativar">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <returns>ApiResponse of PageStatusCartaoResponse</returns>
        public ApiResponse< PageStatusCartaoResponse > ListarStatusCartoesUsingGETWithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null, int? flagCancelaCartao = null, int? flagCancelaNoDesbloqueio = null, long? idStatusDestinoDesbloqueio = null, long? idStatusDestinoConta = null, int? flagCobraTarifa = null, int? flagPermiteNovaViaCartao = null, int? flagPermiteDesbloqueio = null, int? flagCancelamento = null, int? flagPermiteBloqueio = null, int? flagReativar = null)
        {
            
    
            var localVarPath = "/api/status-cartoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (flagCancelaCartao != null) localVarQueryParams.Add("flagCancelaCartao", Configuration.ApiClient.ParameterToString(flagCancelaCartao)); // query parameter
            if (flagCancelaNoDesbloqueio != null) localVarQueryParams.Add("flagCancelaNoDesbloqueio", Configuration.ApiClient.ParameterToString(flagCancelaNoDesbloqueio)); // query parameter
            if (idStatusDestinoDesbloqueio != null) localVarQueryParams.Add("idStatusDestinoDesbloqueio", Configuration.ApiClient.ParameterToString(idStatusDestinoDesbloqueio)); // query parameter
            if (idStatusDestinoConta != null) localVarQueryParams.Add("idStatusDestinoConta", Configuration.ApiClient.ParameterToString(idStatusDestinoConta)); // query parameter
            if (flagCobraTarifa != null) localVarQueryParams.Add("flagCobraTarifa", Configuration.ApiClient.ParameterToString(flagCobraTarifa)); // query parameter
            if (flagPermiteNovaViaCartao != null) localVarQueryParams.Add("flagPermiteNovaViaCartao", Configuration.ApiClient.ParameterToString(flagPermiteNovaViaCartao)); // query parameter
            if (flagPermiteDesbloqueio != null) localVarQueryParams.Add("flagPermiteDesbloqueio", Configuration.ApiClient.ParameterToString(flagPermiteDesbloqueio)); // query parameter
            if (flagCancelamento != null) localVarQueryParams.Add("flagCancelamento", Configuration.ApiClient.ParameterToString(flagCancelamento)); // query parameter
            if (flagPermiteBloqueio != null) localVarQueryParams.Add("flagPermiteBloqueio", Configuration.ApiClient.ParameterToString(flagPermiteBloqueio)); // query parameter
            if (flagReativar != null) localVarQueryParams.Add("flagReativar", Configuration.ApiClient.ParameterToString(flagReativar)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCartoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCartoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageStatusCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusCartaoResponse)));
            
        }

        
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id)  (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagCancelaCartao">Quando ativa, indica que ao ser atribu\u00C3\u00ADdo um idStatusCartao com essa caracter\u00C3\u00ADstica, o cart\u00C3\u00A3o ter\u00C3\u00A1 o seu idStatusCartao alterado para o que fora escolhido. Caso contr\u00C3\u00A1rio, o idStatusCartao s\u00C3\u00B3 ser\u00C3\u00A1 alterado ap\u00C3\u00B3s o desbloqueio de um novo cart\u00C3\u00A3o do mesmo Portador e Conta. (optional)</param>
        /// <param name="flagCancelaNoDesbloqueio">Quando ativa, indica que o cart\u00C3\u00A3o ativo que o portador possuir na mesma conta do cart\u00C3\u00A3o a ser desbloqueado, e que o status dele possua essa caracter\u00C3\u00ADstica, dever\u00C3\u00A1 ser cancelado quando um novo cart\u00C3\u00A3o for desbloqueado. (optional)</param>
        /// <param name="idStatusDestinoDesbloqueio">Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo aos cart\u00C3\u00B5es que forem cancelados devido ao desbloqueio de um novo cart\u00C3\u00A3o. (optional)</param>
        /// <param name="idStatusDestinoConta">Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo a conta, caso ela seja cancelada devido ao bloqueio de um cart\u00C3\u00A3o quando for utilizado um idStatusCartao no processo de Bloqueio que possua essa caracter\u00C3\u00ADstica. (optional)</param>
        /// <param name="flagCobraTarifa">Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, incluir\u00C3\u00A3o a cobran\u00C3\u00A7a de uma tarifa para a conta de acordo com os valores definidos nos par\u00C3\u00A2metros do emissor. (optional)</param>
        /// <param name="flagPermiteNovaViaCartao">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a solicita\u00C3\u00A7\u00C3\u00A3o de uma nova via, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagPermiteDesbloqueio">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o desbloqueio, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagCancelamento">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o cancelamento, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagPermiteBloqueio">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o Bloqueio, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagReativar">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <returns>Task of PageStatusCartaoResponse</returns>
        public async System.Threading.Tasks.Task<PageStatusCartaoResponse> ListarStatusCartoesUsingGETAsync (int? page = null, int? limit = null, long? id = null, string nome = null, int? flagCancelaCartao = null, int? flagCancelaNoDesbloqueio = null, long? idStatusDestinoDesbloqueio = null, long? idStatusDestinoConta = null, int? flagCobraTarifa = null, int? flagPermiteNovaViaCartao = null, int? flagPermiteDesbloqueio = null, int? flagCancelamento = null, int? flagPermiteBloqueio = null, int? flagReativar = null)
        {
             ApiResponse<PageStatusCartaoResponse> localVarResponse = await ListarStatusCartoesUsingGETAsyncWithHttpInfo(page, limit, id, nome, flagCancelaCartao, flagCancelaNoDesbloqueio, idStatusDestinoDesbloqueio, idStatusDestinoConta, flagCobraTarifa, flagPermiteNovaViaCartao, flagPermiteDesbloqueio, flagCancelamento, flagPermiteBloqueio, flagReativar);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id)  (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagCancelaCartao">Quando ativa, indica que ao ser atribu\u00C3\u00ADdo um idStatusCartao com essa caracter\u00C3\u00ADstica, o cart\u00C3\u00A3o ter\u00C3\u00A1 o seu idStatusCartao alterado para o que fora escolhido. Caso contr\u00C3\u00A1rio, o idStatusCartao s\u00C3\u00B3 ser\u00C3\u00A1 alterado ap\u00C3\u00B3s o desbloqueio de um novo cart\u00C3\u00A3o do mesmo Portador e Conta. (optional)</param>
        /// <param name="flagCancelaNoDesbloqueio">Quando ativa, indica que o cart\u00C3\u00A3o ativo que o portador possuir na mesma conta do cart\u00C3\u00A3o a ser desbloqueado, e que o status dele possua essa caracter\u00C3\u00ADstica, dever\u00C3\u00A1 ser cancelado quando um novo cart\u00C3\u00A3o for desbloqueado. (optional)</param>
        /// <param name="idStatusDestinoDesbloqueio">Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo aos cart\u00C3\u00B5es que forem cancelados devido ao desbloqueio de um novo cart\u00C3\u00A3o. (optional)</param>
        /// <param name="idStatusDestinoConta">Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo a conta, caso ela seja cancelada devido ao bloqueio de um cart\u00C3\u00A3o quando for utilizado um idStatusCartao no processo de Bloqueio que possua essa caracter\u00C3\u00ADstica. (optional)</param>
        /// <param name="flagCobraTarifa">Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, incluir\u00C3\u00A3o a cobran\u00C3\u00A7a de uma tarifa para a conta de acordo com os valores definidos nos par\u00C3\u00A2metros do emissor. (optional)</param>
        /// <param name="flagPermiteNovaViaCartao">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a solicita\u00C3\u00A7\u00C3\u00A3o de uma nova via, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagPermiteDesbloqueio">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o desbloqueio, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagCancelamento">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o cancelamento, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagPermiteBloqueio">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o Bloqueio, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagReativar">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageStatusCartaoResponse>> ListarStatusCartoesUsingGETAsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null, int? flagCancelaCartao = null, int? flagCancelaNoDesbloqueio = null, long? idStatusDestinoDesbloqueio = null, long? idStatusDestinoConta = null, int? flagCobraTarifa = null, int? flagPermiteNovaViaCartao = null, int? flagPermiteDesbloqueio = null, int? flagCancelamento = null, int? flagPermiteBloqueio = null, int? flagReativar = null)
        {
            
    
            var localVarPath = "/api/status-cartoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (flagCancelaCartao != null) localVarQueryParams.Add("flagCancelaCartao", Configuration.ApiClient.ParameterToString(flagCancelaCartao)); // query parameter
            if (flagCancelaNoDesbloqueio != null) localVarQueryParams.Add("flagCancelaNoDesbloqueio", Configuration.ApiClient.ParameterToString(flagCancelaNoDesbloqueio)); // query parameter
            if (idStatusDestinoDesbloqueio != null) localVarQueryParams.Add("idStatusDestinoDesbloqueio", Configuration.ApiClient.ParameterToString(idStatusDestinoDesbloqueio)); // query parameter
            if (idStatusDestinoConta != null) localVarQueryParams.Add("idStatusDestinoConta", Configuration.ApiClient.ParameterToString(idStatusDestinoConta)); // query parameter
            if (flagCobraTarifa != null) localVarQueryParams.Add("flagCobraTarifa", Configuration.ApiClient.ParameterToString(flagCobraTarifa)); // query parameter
            if (flagPermiteNovaViaCartao != null) localVarQueryParams.Add("flagPermiteNovaViaCartao", Configuration.ApiClient.ParameterToString(flagPermiteNovaViaCartao)); // query parameter
            if (flagPermiteDesbloqueio != null) localVarQueryParams.Add("flagPermiteDesbloqueio", Configuration.ApiClient.ParameterToString(flagPermiteDesbloqueio)); // query parameter
            if (flagCancelamento != null) localVarQueryParams.Add("flagCancelamento", Configuration.ApiClient.ParameterToString(flagCancelamento)); // query parameter
            if (flagPermiteBloqueio != null) localVarQueryParams.Add("flagPermiteBloqueio", Configuration.ApiClient.ParameterToString(flagPermiteBloqueio)); // query parameter
            if (flagReativar != null) localVarQueryParams.Add("flagReativar", Configuration.ApiClient.ParameterToString(flagReativar)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCartoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCartoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageStatusCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusCartaoResponse)));
            
        }
        
        /// <summary>
        /// Lista os Status Contas cadastrados para o Emissor Este m\u00C3\u00A9todo permite que sejam listados os Status Contas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id). (optional)</param> 
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status da Conta. (optional)</param> 
        /// <param name="flagAlteraLimite">Par\u00C3\u00A2metro que define se o Status da Conta permite realizar a Altera\u00C3\u00A7\u00C3\u00A3o de Limites do Portador, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="mensagemConsultaNegada">Apresenta o texto com o motivo que ser\u00C3\u00A1 apresentado na resposta as opera\u00C3\u00A7\u00C3\u00B5es de Listar e Consultar LimitesDisponibilidades. (optional)</param> 
        /// <param name="flagPermiteNovaViaCartao">Par\u00C3\u00A2metro que define se o Status da conta permite a solicita\u00C3\u00A7\u00C3\u00A3o de um novo cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="flagFazTransferencia">Par\u00C3\u00A2metro que define se o Status da conta permite fazer transferencia, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="flagRecebeTransferencia">Par\u00C3\u00A2metro que define se o Status da conta permite receber transferencia, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="flagPermiteBloqueio">Par\u00C3\u00A2metro que define se o Status da conta permite receber bloqueio, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="flagPermiteDesbloqueio">Par\u00C3\u00A2metro que define se o Status da conta permite receber desbloqueio, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="flagCancelaConta">Par\u00C3\u00A2metro que define se o Status da conta permite receber cancelamento, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <returns>PageStatusContaResponse</returns>
        public PageStatusContaResponse ListarUsingGET20 (int? page = null, int? limit = null, long? id = null, string nome = null, int? flagAlteraLimite = null, string mensagemConsultaNegada = null, int? flagPermiteNovaViaCartao = null, int? flagFazTransferencia = null, int? flagRecebeTransferencia = null, int? flagPermiteBloqueio = null, int? flagPermiteDesbloqueio = null, int? flagCancelaConta = null)
        {
             ApiResponse<PageStatusContaResponse> localVarResponse = ListarUsingGET20WithHttpInfo(page, limit, id, nome, flagAlteraLimite, mensagemConsultaNegada, flagPermiteNovaViaCartao, flagFazTransferencia, flagRecebeTransferencia, flagPermiteBloqueio, flagPermiteDesbloqueio, flagCancelaConta);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Status Contas cadastrados para o Emissor Este m\u00C3\u00A9todo permite que sejam listados os Status Contas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id). (optional)</param> 
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status da Conta. (optional)</param> 
        /// <param name="flagAlteraLimite">Par\u00C3\u00A2metro que define se o Status da Conta permite realizar a Altera\u00C3\u00A7\u00C3\u00A3o de Limites do Portador, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="mensagemConsultaNegada">Apresenta o texto com o motivo que ser\u00C3\u00A1 apresentado na resposta as opera\u00C3\u00A7\u00C3\u00B5es de Listar e Consultar LimitesDisponibilidades. (optional)</param> 
        /// <param name="flagPermiteNovaViaCartao">Par\u00C3\u00A2metro que define se o Status da conta permite a solicita\u00C3\u00A7\u00C3\u00A3o de um novo cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="flagFazTransferencia">Par\u00C3\u00A2metro que define se o Status da conta permite fazer transferencia, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="flagRecebeTransferencia">Par\u00C3\u00A2metro que define se o Status da conta permite receber transferencia, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="flagPermiteBloqueio">Par\u00C3\u00A2metro que define se o Status da conta permite receber bloqueio, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="flagPermiteDesbloqueio">Par\u00C3\u00A2metro que define se o Status da conta permite receber desbloqueio, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="flagCancelaConta">Par\u00C3\u00A2metro que define se o Status da conta permite receber cancelamento, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <returns>ApiResponse of PageStatusContaResponse</returns>
        public ApiResponse< PageStatusContaResponse > ListarUsingGET20WithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null, int? flagAlteraLimite = null, string mensagemConsultaNegada = null, int? flagPermiteNovaViaCartao = null, int? flagFazTransferencia = null, int? flagRecebeTransferencia = null, int? flagPermiteBloqueio = null, int? flagPermiteDesbloqueio = null, int? flagCancelaConta = null)
        {
            
    
            var localVarPath = "/api/status-contas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (flagAlteraLimite != null) localVarQueryParams.Add("flagAlteraLimite", Configuration.ApiClient.ParameterToString(flagAlteraLimite)); // query parameter
            if (mensagemConsultaNegada != null) localVarQueryParams.Add("mensagemConsultaNegada", Configuration.ApiClient.ParameterToString(mensagemConsultaNegada)); // query parameter
            if (flagPermiteNovaViaCartao != null) localVarQueryParams.Add("flagPermiteNovaViaCartao", Configuration.ApiClient.ParameterToString(flagPermiteNovaViaCartao)); // query parameter
            if (flagFazTransferencia != null) localVarQueryParams.Add("flagFazTransferencia", Configuration.ApiClient.ParameterToString(flagFazTransferencia)); // query parameter
            if (flagRecebeTransferencia != null) localVarQueryParams.Add("flagRecebeTransferencia", Configuration.ApiClient.ParameterToString(flagRecebeTransferencia)); // query parameter
            if (flagPermiteBloqueio != null) localVarQueryParams.Add("flagPermiteBloqueio", Configuration.ApiClient.ParameterToString(flagPermiteBloqueio)); // query parameter
            if (flagPermiteDesbloqueio != null) localVarQueryParams.Add("flagPermiteDesbloqueio", Configuration.ApiClient.ParameterToString(flagPermiteDesbloqueio)); // query parameter
            if (flagCancelaConta != null) localVarQueryParams.Add("flagCancelaConta", Configuration.ApiClient.ParameterToString(flagCancelaConta)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET20: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET20: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageStatusContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusContaResponse)));
            
        }

        
        /// <summary>
        /// Lista os Status Contas cadastrados para o Emissor Este m\u00C3\u00A9todo permite que sejam listados os Status Contas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id). (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status da Conta. (optional)</param>
        /// <param name="flagAlteraLimite">Par\u00C3\u00A2metro que define se o Status da Conta permite realizar a Altera\u00C3\u00A7\u00C3\u00A3o de Limites do Portador, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="mensagemConsultaNegada">Apresenta o texto com o motivo que ser\u00C3\u00A1 apresentado na resposta as opera\u00C3\u00A7\u00C3\u00B5es de Listar e Consultar LimitesDisponibilidades. (optional)</param>
        /// <param name="flagPermiteNovaViaCartao">Par\u00C3\u00A2metro que define se o Status da conta permite a solicita\u00C3\u00A7\u00C3\u00A3o de um novo cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagFazTransferencia">Par\u00C3\u00A2metro que define se o Status da conta permite fazer transferencia, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagRecebeTransferencia">Par\u00C3\u00A2metro que define se o Status da conta permite receber transferencia, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagPermiteBloqueio">Par\u00C3\u00A2metro que define se o Status da conta permite receber bloqueio, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagPermiteDesbloqueio">Par\u00C3\u00A2metro que define se o Status da conta permite receber desbloqueio, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagCancelaConta">Par\u00C3\u00A2metro que define se o Status da conta permite receber cancelamento, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <returns>Task of PageStatusContaResponse</returns>
        public async System.Threading.Tasks.Task<PageStatusContaResponse> ListarUsingGET20Async (int? page = null, int? limit = null, long? id = null, string nome = null, int? flagAlteraLimite = null, string mensagemConsultaNegada = null, int? flagPermiteNovaViaCartao = null, int? flagFazTransferencia = null, int? flagRecebeTransferencia = null, int? flagPermiteBloqueio = null, int? flagPermiteDesbloqueio = null, int? flagCancelaConta = null)
        {
             ApiResponse<PageStatusContaResponse> localVarResponse = await ListarUsingGET20AsyncWithHttpInfo(page, limit, id, nome, flagAlteraLimite, mensagemConsultaNegada, flagPermiteNovaViaCartao, flagFazTransferencia, flagRecebeTransferencia, flagPermiteBloqueio, flagPermiteDesbloqueio, flagCancelaConta);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Status Contas cadastrados para o Emissor Este m\u00C3\u00A9todo permite que sejam listados os Status Contas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id). (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status da Conta. (optional)</param>
        /// <param name="flagAlteraLimite">Par\u00C3\u00A2metro que define se o Status da Conta permite realizar a Altera\u00C3\u00A7\u00C3\u00A3o de Limites do Portador, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="mensagemConsultaNegada">Apresenta o texto com o motivo que ser\u00C3\u00A1 apresentado na resposta as opera\u00C3\u00A7\u00C3\u00B5es de Listar e Consultar LimitesDisponibilidades. (optional)</param>
        /// <param name="flagPermiteNovaViaCartao">Par\u00C3\u00A2metro que define se o Status da conta permite a solicita\u00C3\u00A7\u00C3\u00A3o de um novo cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagFazTransferencia">Par\u00C3\u00A2metro que define se o Status da conta permite fazer transferencia, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagRecebeTransferencia">Par\u00C3\u00A2metro que define se o Status da conta permite receber transferencia, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagPermiteBloqueio">Par\u00C3\u00A2metro que define se o Status da conta permite receber bloqueio, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagPermiteDesbloqueio">Par\u00C3\u00A2metro que define se o Status da conta permite receber desbloqueio, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="flagCancelaConta">Par\u00C3\u00A2metro que define se o Status da conta permite receber cancelamento, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageStatusContaResponse>> ListarUsingGET20AsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null, int? flagAlteraLimite = null, string mensagemConsultaNegada = null, int? flagPermiteNovaViaCartao = null, int? flagFazTransferencia = null, int? flagRecebeTransferencia = null, int? flagPermiteBloqueio = null, int? flagPermiteDesbloqueio = null, int? flagCancelaConta = null)
        {
            
    
            var localVarPath = "/api/status-contas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (flagAlteraLimite != null) localVarQueryParams.Add("flagAlteraLimite", Configuration.ApiClient.ParameterToString(flagAlteraLimite)); // query parameter
            if (mensagemConsultaNegada != null) localVarQueryParams.Add("mensagemConsultaNegada", Configuration.ApiClient.ParameterToString(mensagemConsultaNegada)); // query parameter
            if (flagPermiteNovaViaCartao != null) localVarQueryParams.Add("flagPermiteNovaViaCartao", Configuration.ApiClient.ParameterToString(flagPermiteNovaViaCartao)); // query parameter
            if (flagFazTransferencia != null) localVarQueryParams.Add("flagFazTransferencia", Configuration.ApiClient.ParameterToString(flagFazTransferencia)); // query parameter
            if (flagRecebeTransferencia != null) localVarQueryParams.Add("flagRecebeTransferencia", Configuration.ApiClient.ParameterToString(flagRecebeTransferencia)); // query parameter
            if (flagPermiteBloqueio != null) localVarQueryParams.Add("flagPermiteBloqueio", Configuration.ApiClient.ParameterToString(flagPermiteBloqueio)); // query parameter
            if (flagPermiteDesbloqueio != null) localVarQueryParams.Add("flagPermiteDesbloqueio", Configuration.ApiClient.ParameterToString(flagPermiteDesbloqueio)); // query parameter
            if (flagCancelaConta != null) localVarQueryParams.Add("flagCancelaConta", Configuration.ApiClient.ParameterToString(flagCancelaConta)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET20: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET20: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageStatusContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusContaResponse)));
            
        }
        
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status Impress\u00C3\u00A3o Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Status Impress\u00C3\u00A3o que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param> 
        /// <param name="nome">Nome do status impress\u00C3\u00A3o (optional)</param> 
        /// <returns>PageStatusImpressaoResponse</returns>
        public PageStatusImpressaoResponse ListarUsingGET21 (int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageStatusImpressaoResponse> localVarResponse = ListarUsingGET21WithHttpInfo(page, limit, id, nome);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status Impress\u00C3\u00A3o Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Status Impress\u00C3\u00A3o que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param> 
        /// <param name="nome">Nome do status impress\u00C3\u00A3o (optional)</param> 
        /// <returns>ApiResponse of PageStatusImpressaoResponse</returns>
        public ApiResponse< PageStatusImpressaoResponse > ListarUsingGET21WithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null)
        {
            
    
            var localVarPath = "/api/status-impressoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET21: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET21: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageStatusImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusImpressaoResponse)));
            
        }

        
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status Impress\u00C3\u00A3o Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Status Impress\u00C3\u00A3o que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="nome">Nome do status impress\u00C3\u00A3o (optional)</param>
        /// <returns>Task of PageStatusImpressaoResponse</returns>
        public async System.Threading.Tasks.Task<PageStatusImpressaoResponse> ListarUsingGET21Async (int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageStatusImpressaoResponse> localVarResponse = await ListarUsingGET21AsyncWithHttpInfo(page, limit, id, nome);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status Impress\u00C3\u00A3o Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Status Impress\u00C3\u00A3o que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="nome">Nome do status impress\u00C3\u00A3o (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusImpressaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageStatusImpressaoResponse>> ListarUsingGET21AsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null)
        {
            
    
            var localVarPath = "/api/status-impressoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET21: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET21: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageStatusImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusImpressaoResponse)));
            
        }
        
    }
    
}
