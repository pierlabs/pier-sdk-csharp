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
    public interface IStatusParametroApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Apresenta os dados de um determinado Estagio Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Est\u00E1gio de Entrega do Cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Est\u00E1gio de Entrega do Cart\u00E3o (id)</param>
        /// <returns>EstagioCartaoResponse</returns>
        EstagioCartaoResponse ConsultarEstagioCartao (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Estagio Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Est\u00E1gio de Entrega do Cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Est\u00E1gio de Entrega do Cart\u00E3o (id)</param>
        /// <returns>ApiResponse of EstagioCartaoResponse</returns>
        ApiResponse<EstagioCartaoResponse> ConsultarEstagioCartaoWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Status Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Status de Cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Est\u00E1gio de Entrega do Cart\u00E3o (id)</param>
        /// <returns>StatusCartaoResponse</returns>
        StatusCartaoResponse ConsultarStatusCartao (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Status Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Status de Cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Est\u00E1gio de Entrega do Cart\u00E3o (id)</param>
        /// <returns>ApiResponse of StatusCartaoResponse</returns>
        ApiResponse<StatusCartaoResponse> ConsultarStatusCartaoWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Status Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Status Conta a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Status da Conta (id)</param>
        /// <returns>StatusContaResponse</returns>
        StatusContaResponse ConsultarStatusConta (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Status Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Status Conta a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Status da Conta (id)</param>
        /// <returns>ApiResponse of StatusContaResponse</returns>
        ApiResponse<StatusContaResponse> ConsultarStatusContaWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Status Impress\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Status de Impress\u00E3o do Cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Status de Impress\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>StatusImpressaoResponse</returns>
        StatusImpressaoResponse ConsultarStatusImpressaoCartao (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Status Impress\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Status de Impress\u00E3o do Cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Status de Impress\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>ApiResponse of StatusImpressaoResponse</returns>
        ApiResponse<StatusImpressaoResponse> ConsultarStatusImpressaoCartaoWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista as op\u00E7\u00F5es de Est\u00E1gios do Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as op\u00E7\u00F5es de Est\u00E1gio de Entrega que podem ser atribu\u00EDdas aos Cart\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id do est\u00E1gio cart\u00E3o (optional)</param>
        /// <param name="nome">Nome do est\u00E1gio cart\u00E3o (optional)</param>
        /// <returns>PageEstagioCartaoResponse</returns>
        PageEstagioCartaoResponse ListarEstagiosCartoes (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
  
        /// <summary>
        /// Lista as op\u00E7\u00F5es de Est\u00E1gios do Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as op\u00E7\u00F5es de Est\u00E1gio de Entrega que podem ser atribu\u00EDdas aos Cart\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id do est\u00E1gio cart\u00E3o (optional)</param>
        /// <param name="nome">Nome do est\u00E1gio cart\u00E3o (optional)</param>
        /// <returns>ApiResponse of PageEstagioCartaoResponse</returns>
        ApiResponse<PageEstagioCartaoResponse> ListarEstagiosCartoesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
        
        /// <summary>
        /// Listar status CNAB sumarizados
        /// </summary>
        /// <remarks>
        /// Lista os status CNAB sumarizados existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageTipoBoletoResponse</returns>
        PageTipoBoletoResponse ListarStatusCNABSumarizados (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Listar status CNAB sumarizados
        /// </summary>
        /// <remarks>
        /// Lista os status CNAB sumarizados existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageTipoBoletoResponse</returns>
        ApiResponse<PageTipoBoletoResponse> ListarStatusCNABSumarizadosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista as op\u00E7\u00F5es de Status do Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00EDdas aos Cart\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Status do Cart\u00E3o (id) (optional)</param>
        /// <param name="nome">Nome atribu\u00EDdo ao Status de Entrega do Cart\u00E3o (optional)</param>
        /// <param name="permiteDesbloquear">Par\u00E2metro que define se o status do cart\u00E3o permite a reativa\u00E7\u00E3o do cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Par\u00E2metro que define se o status do cart\u00E3o permite a reativa\u00E7\u00E3o do cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Par\u00E2metro que define se o status do cart\u00E3o permite a reativa\u00E7\u00E3o do cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="cobrarTarifaAoEmitirNovaVia">Par\u00E2metro que define se o status do cart\u00E3o permite a reativa\u00E7\u00E3o do cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <returns>PageStatusCartaoResponse</returns>
        PageStatusCartaoResponse ListarStatusCartoes (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteDesbloquear = null, int? permiteAtribuirComoBloqueio = null, int? permiteAtribuirComoCancelamento = null, int? cobrarTarifaAoEmitirNovaVia = null);
  
        /// <summary>
        /// Lista as op\u00E7\u00F5es de Status do Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00EDdas aos Cart\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Status do Cart\u00E3o (id) (optional)</param>
        /// <param name="nome">Nome atribu\u00EDdo ao Status de Entrega do Cart\u00E3o (optional)</param>
        /// <param name="permiteDesbloquear">Par\u00E2metro que define se o status do cart\u00E3o permite a reativa\u00E7\u00E3o do cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Par\u00E2metro que define se o status do cart\u00E3o permite a reativa\u00E7\u00E3o do cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Par\u00E2metro que define se o status do cart\u00E3o permite a reativa\u00E7\u00E3o do cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="cobrarTarifaAoEmitirNovaVia">Par\u00E2metro que define se o status do cart\u00E3o permite a reativa\u00E7\u00E3o do cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <returns>ApiResponse of PageStatusCartaoResponse</returns>
        ApiResponse<PageStatusCartaoResponse> ListarStatusCartoesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteDesbloquear = null, int? permiteAtribuirComoBloqueio = null, int? permiteAtribuirComoCancelamento = null, int? cobrarTarifaAoEmitirNovaVia = null);
        
        /// <summary>
        /// Lista os Status Contas cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Status Contas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Status da Conta (id) (optional)</param>
        /// <param name="nome">Nome atribu\u00EDdo ao Status da Conta (optional)</param>
        /// <param name="permiteAlterarVencimento">Par\u00E2metro que define se o Status da conta permite a solicita\u00E7\u00E3o da altera\u00E7\u00E3o do Dia para Vencimento das Faturas, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteAlterarLimite">Par\u00E2metro que define se o Status da conta permite altera\u00E7\u00E3o de Limites, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteEmitirNovaViaCartao">Par\u00E2metro que define se o Status da conta permite solicitar uma nova via de Cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteFazerTransferencia">Par\u00E2metro que define se o Status da conta permite originar Transfer\u00EAncias de Cr\u00E9dito para outras Contas do mesmo Emissor ou para uma Conta Banc\u00E1ria, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteReceberTransferencia">Par\u00E2metro que define se o Status da conta permite  receber Transfer\u00EAncias de Cr\u00E9dito originadas de outras Contas do mesmo emissor, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteCriarAcordoCobranca">Par\u00E2metro que define se o Status da conta permite ter um Acordo de Cobran\u00E7a de D\u00EDvida criado para ela, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Par\u00E2metro que define se o Status da conta permite ser atribu\u00EDdo para Bloquear temporariamente uma Conta, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteDesbloquear">Par\u00E2metro que define se o Status da conta permite ser desbloqueada, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Par\u00E2metro que define se o Status da conta permite ser atribu\u00EDdo para realizar o cancelamento definitivo de uma conta, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <returns>PageStatusContaResponse</returns>
        PageStatusContaResponse ListarStatusConta (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteAlterarVencimento = null, int? permiteAlterarLimite = null, int? permiteEmitirNovaViaCartao = null, int? permiteFazerTransferencia = null, int? permiteReceberTransferencia = null, int? permiteCriarAcordoCobranca = null, int? permiteAtribuirComoBloqueio = null, int? permiteDesbloquear = null, int? permiteAtribuirComoCancelamento = null);
  
        /// <summary>
        /// Lista os Status Contas cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Status Contas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Status da Conta (id) (optional)</param>
        /// <param name="nome">Nome atribu\u00EDdo ao Status da Conta (optional)</param>
        /// <param name="permiteAlterarVencimento">Par\u00E2metro que define se o Status da conta permite a solicita\u00E7\u00E3o da altera\u00E7\u00E3o do Dia para Vencimento das Faturas, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteAlterarLimite">Par\u00E2metro que define se o Status da conta permite altera\u00E7\u00E3o de Limites, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteEmitirNovaViaCartao">Par\u00E2metro que define se o Status da conta permite solicitar uma nova via de Cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteFazerTransferencia">Par\u00E2metro que define se o Status da conta permite originar Transfer\u00EAncias de Cr\u00E9dito para outras Contas do mesmo Emissor ou para uma Conta Banc\u00E1ria, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteReceberTransferencia">Par\u00E2metro que define se o Status da conta permite  receber Transfer\u00EAncias de Cr\u00E9dito originadas de outras Contas do mesmo emissor, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteCriarAcordoCobranca">Par\u00E2metro que define se o Status da conta permite ter um Acordo de Cobran\u00E7a de D\u00EDvida criado para ela, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Par\u00E2metro que define se o Status da conta permite ser atribu\u00EDdo para Bloquear temporariamente uma Conta, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteDesbloquear">Par\u00E2metro que define se o Status da conta permite ser desbloqueada, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Par\u00E2metro que define se o Status da conta permite ser atribu\u00EDdo para realizar o cancelamento definitivo de uma conta, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <returns>ApiResponse of PageStatusContaResponse</returns>
        ApiResponse<PageStatusContaResponse> ListarStatusContaWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteAlterarVencimento = null, int? permiteAlterarLimite = null, int? permiteEmitirNovaViaCartao = null, int? permiteFazerTransferencia = null, int? permiteReceberTransferencia = null, int? permiteCriarAcordoCobranca = null, int? permiteAtribuirComoBloqueio = null, int? permiteDesbloquear = null, int? permiteAtribuirComoCancelamento = null);
        
        /// <summary>
        /// Lista as op\u00E7\u00F5es de Status Impress\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as op\u00E7\u00F5es de Status Impress\u00E3o que podem ser atribu\u00EDdas aos Cart\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id do est\u00E1gio cart\u00E3o (optional)</param>
        /// <param name="nome">Nome do status impress\u00E3o (optional)</param>
        /// <returns>PageStatusImpressaoResponse</returns>
        PageStatusImpressaoResponse ListarStatusImpressaoCartao (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
  
        /// <summary>
        /// Lista as op\u00E7\u00F5es de Status Impress\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as op\u00E7\u00F5es de Status Impress\u00E3o que podem ser atribu\u00EDdas aos Cart\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id do est\u00E1gio cart\u00E3o (optional)</param>
        /// <param name="nome">Nome do status impress\u00E3o (optional)</param>
        /// <returns>ApiResponse of PageStatusImpressaoResponse</returns>
        ApiResponse<PageStatusImpressaoResponse> ListarStatusImpressaoCartaoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Apresenta os dados de um determinado Estagio Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Est\u00E1gio de Entrega do Cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Est\u00E1gio de Entrega do Cart\u00E3o (id)</param>
        /// <returns>Task of EstagioCartaoResponse</returns>
        System.Threading.Tasks.Task<EstagioCartaoResponse> ConsultarEstagioCartaoAsync (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Estagio Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Est\u00E1gio de Entrega do Cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Est\u00E1gio de Entrega do Cart\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (EstagioCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EstagioCartaoResponse>> ConsultarEstagioCartaoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Status Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Status de Cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Est\u00E1gio de Entrega do Cart\u00E3o (id)</param>
        /// <returns>Task of StatusCartaoResponse</returns>
        System.Threading.Tasks.Task<StatusCartaoResponse> ConsultarStatusCartaoAsync (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Status Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Status de Cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Est\u00E1gio de Entrega do Cart\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (StatusCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StatusCartaoResponse>> ConsultarStatusCartaoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Status Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Status Conta a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Status da Conta (id)</param>
        /// <returns>Task of StatusContaResponse</returns>
        System.Threading.Tasks.Task<StatusContaResponse> ConsultarStatusContaAsync (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Status Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Status Conta a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Status da Conta (id)</param>
        /// <returns>Task of ApiResponse (StatusContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StatusContaResponse>> ConsultarStatusContaAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Status Impress\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Status de Impress\u00E3o do Cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Status de Impress\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>Task of StatusImpressaoResponse</returns>
        System.Threading.Tasks.Task<StatusImpressaoResponse> ConsultarStatusImpressaoCartaoAsync (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Status Impress\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Status de Impress\u00E3o do Cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Status de Impress\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (StatusImpressaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StatusImpressaoResponse>> ConsultarStatusImpressaoCartaoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista as op\u00E7\u00F5es de Est\u00E1gios do Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as op\u00E7\u00F5es de Est\u00E1gio de Entrega que podem ser atribu\u00EDdas aos Cart\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id do est\u00E1gio cart\u00E3o (optional)</param>
        /// <param name="nome">Nome do est\u00E1gio cart\u00E3o (optional)</param>
        /// <returns>Task of PageEstagioCartaoResponse</returns>
        System.Threading.Tasks.Task<PageEstagioCartaoResponse> ListarEstagiosCartoesAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);

        /// <summary>
        /// Lista as op\u00E7\u00F5es de Est\u00E1gios do Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as op\u00E7\u00F5es de Est\u00E1gio de Entrega que podem ser atribu\u00EDdas aos Cart\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id do est\u00E1gio cart\u00E3o (optional)</param>
        /// <param name="nome">Nome do est\u00E1gio cart\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (PageEstagioCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageEstagioCartaoResponse>> ListarEstagiosCartoesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
        
        /// <summary>
        /// Listar status CNAB sumarizados
        /// </summary>
        /// <remarks>
        /// Lista os status CNAB sumarizados existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageTipoBoletoResponse</returns>
        System.Threading.Tasks.Task<PageTipoBoletoResponse> ListarStatusCNABSumarizadosAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Listar status CNAB sumarizados
        /// </summary>
        /// <remarks>
        /// Lista os status CNAB sumarizados existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoBoletoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoBoletoResponse>> ListarStatusCNABSumarizadosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista as op\u00E7\u00F5es de Status do Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00EDdas aos Cart\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Status do Cart\u00E3o (id) (optional)</param>
        /// <param name="nome">Nome atribu\u00EDdo ao Status de Entrega do Cart\u00E3o (optional)</param>
        /// <param name="permiteDesbloquear">Par\u00E2metro que define se o status do cart\u00E3o permite a reativa\u00E7\u00E3o do cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Par\u00E2metro que define se o status do cart\u00E3o permite a reativa\u00E7\u00E3o do cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Par\u00E2metro que define se o status do cart\u00E3o permite a reativa\u00E7\u00E3o do cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="cobrarTarifaAoEmitirNovaVia">Par\u00E2metro que define se o status do cart\u00E3o permite a reativa\u00E7\u00E3o do cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <returns>Task of PageStatusCartaoResponse</returns>
        System.Threading.Tasks.Task<PageStatusCartaoResponse> ListarStatusCartoesAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteDesbloquear = null, int? permiteAtribuirComoBloqueio = null, int? permiteAtribuirComoCancelamento = null, int? cobrarTarifaAoEmitirNovaVia = null);

        /// <summary>
        /// Lista as op\u00E7\u00F5es de Status do Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00EDdas aos Cart\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Status do Cart\u00E3o (id) (optional)</param>
        /// <param name="nome">Nome atribu\u00EDdo ao Status de Entrega do Cart\u00E3o (optional)</param>
        /// <param name="permiteDesbloquear">Par\u00E2metro que define se o status do cart\u00E3o permite a reativa\u00E7\u00E3o do cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Par\u00E2metro que define se o status do cart\u00E3o permite a reativa\u00E7\u00E3o do cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Par\u00E2metro que define se o status do cart\u00E3o permite a reativa\u00E7\u00E3o do cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="cobrarTarifaAoEmitirNovaVia">Par\u00E2metro que define se o status do cart\u00E3o permite a reativa\u00E7\u00E3o do cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageStatusCartaoResponse>> ListarStatusCartoesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteDesbloquear = null, int? permiteAtribuirComoBloqueio = null, int? permiteAtribuirComoCancelamento = null, int? cobrarTarifaAoEmitirNovaVia = null);
        
        /// <summary>
        /// Lista os Status Contas cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Status Contas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Status da Conta (id) (optional)</param>
        /// <param name="nome">Nome atribu\u00EDdo ao Status da Conta (optional)</param>
        /// <param name="permiteAlterarVencimento">Par\u00E2metro que define se o Status da conta permite a solicita\u00E7\u00E3o da altera\u00E7\u00E3o do Dia para Vencimento das Faturas, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteAlterarLimite">Par\u00E2metro que define se o Status da conta permite altera\u00E7\u00E3o de Limites, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteEmitirNovaViaCartao">Par\u00E2metro que define se o Status da conta permite solicitar uma nova via de Cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteFazerTransferencia">Par\u00E2metro que define se o Status da conta permite originar Transfer\u00EAncias de Cr\u00E9dito para outras Contas do mesmo Emissor ou para uma Conta Banc\u00E1ria, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteReceberTransferencia">Par\u00E2metro que define se o Status da conta permite  receber Transfer\u00EAncias de Cr\u00E9dito originadas de outras Contas do mesmo emissor, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteCriarAcordoCobranca">Par\u00E2metro que define se o Status da conta permite ter um Acordo de Cobran\u00E7a de D\u00EDvida criado para ela, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Par\u00E2metro que define se o Status da conta permite ser atribu\u00EDdo para Bloquear temporariamente uma Conta, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteDesbloquear">Par\u00E2metro que define se o Status da conta permite ser desbloqueada, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Par\u00E2metro que define se o Status da conta permite ser atribu\u00EDdo para realizar o cancelamento definitivo de uma conta, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <returns>Task of PageStatusContaResponse</returns>
        System.Threading.Tasks.Task<PageStatusContaResponse> ListarStatusContaAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteAlterarVencimento = null, int? permiteAlterarLimite = null, int? permiteEmitirNovaViaCartao = null, int? permiteFazerTransferencia = null, int? permiteReceberTransferencia = null, int? permiteCriarAcordoCobranca = null, int? permiteAtribuirComoBloqueio = null, int? permiteDesbloquear = null, int? permiteAtribuirComoCancelamento = null);

        /// <summary>
        /// Lista os Status Contas cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Status Contas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Status da Conta (id) (optional)</param>
        /// <param name="nome">Nome atribu\u00EDdo ao Status da Conta (optional)</param>
        /// <param name="permiteAlterarVencimento">Par\u00E2metro que define se o Status da conta permite a solicita\u00E7\u00E3o da altera\u00E7\u00E3o do Dia para Vencimento das Faturas, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteAlterarLimite">Par\u00E2metro que define se o Status da conta permite altera\u00E7\u00E3o de Limites, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteEmitirNovaViaCartao">Par\u00E2metro que define se o Status da conta permite solicitar uma nova via de Cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteFazerTransferencia">Par\u00E2metro que define se o Status da conta permite originar Transfer\u00EAncias de Cr\u00E9dito para outras Contas do mesmo Emissor ou para uma Conta Banc\u00E1ria, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteReceberTransferencia">Par\u00E2metro que define se o Status da conta permite  receber Transfer\u00EAncias de Cr\u00E9dito originadas de outras Contas do mesmo emissor, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteCriarAcordoCobranca">Par\u00E2metro que define se o Status da conta permite ter um Acordo de Cobran\u00E7a de D\u00EDvida criado para ela, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Par\u00E2metro que define se o Status da conta permite ser atribu\u00EDdo para Bloquear temporariamente uma Conta, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteDesbloquear">Par\u00E2metro que define se o Status da conta permite ser desbloqueada, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Par\u00E2metro que define se o Status da conta permite ser atribu\u00EDdo para realizar o cancelamento definitivo de uma conta, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageStatusContaResponse>> ListarStatusContaAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteAlterarVencimento = null, int? permiteAlterarLimite = null, int? permiteEmitirNovaViaCartao = null, int? permiteFazerTransferencia = null, int? permiteReceberTransferencia = null, int? permiteCriarAcordoCobranca = null, int? permiteAtribuirComoBloqueio = null, int? permiteDesbloquear = null, int? permiteAtribuirComoCancelamento = null);
        
        /// <summary>
        /// Lista as op\u00E7\u00F5es de Status Impress\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as op\u00E7\u00F5es de Status Impress\u00E3o que podem ser atribu\u00EDdas aos Cart\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id do est\u00E1gio cart\u00E3o (optional)</param>
        /// <param name="nome">Nome do status impress\u00E3o (optional)</param>
        /// <returns>Task of PageStatusImpressaoResponse</returns>
        System.Threading.Tasks.Task<PageStatusImpressaoResponse> ListarStatusImpressaoCartaoAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);

        /// <summary>
        /// Lista as op\u00E7\u00F5es de Status Impress\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as op\u00E7\u00F5es de Status Impress\u00E3o que podem ser atribu\u00EDdas aos Cart\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id do est\u00E1gio cart\u00E3o (optional)</param>
        /// <param name="nome">Nome do status impress\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusImpressaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageStatusImpressaoResponse>> ListarStatusImpressaoCartaoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class StatusParametroApi : IStatusParametroApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusParametroApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StatusParametroApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusParametroApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public StatusParametroApi(Configuration configuration = null)
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
        /// Apresenta os dados de um determinado Estagio Cart\u00E3o Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Est\u00E1gio de Entrega do Cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Est\u00E1gio de Entrega do Cart\u00E3o (id)</param> 
        /// <returns>EstagioCartaoResponse</returns>
        public EstagioCartaoResponse ConsultarEstagioCartao (long? id)
        {
             ApiResponse<EstagioCartaoResponse> localVarResponse = ConsultarEstagioCartaoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Estagio Cart\u00E3o Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Est\u00E1gio de Entrega do Cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Est\u00E1gio de Entrega do Cart\u00E3o (id)</param> 
        /// <returns>ApiResponse of EstagioCartaoResponse</returns>
        public ApiResponse< EstagioCartaoResponse > ConsultarEstagioCartaoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling StatusParametroApi->ConsultarEstagioCartao");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarEstagioCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarEstagioCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EstagioCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstagioCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstagioCartaoResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Estagio Cart\u00E3o Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Est\u00E1gio de Entrega do Cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Est\u00E1gio de Entrega do Cart\u00E3o (id)</param>
        /// <returns>Task of EstagioCartaoResponse</returns>
        public async System.Threading.Tasks.Task<EstagioCartaoResponse> ConsultarEstagioCartaoAsync (long? id)
        {
             ApiResponse<EstagioCartaoResponse> localVarResponse = await ConsultarEstagioCartaoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Estagio Cart\u00E3o Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Est\u00E1gio de Entrega do Cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Est\u00E1gio de Entrega do Cart\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (EstagioCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EstagioCartaoResponse>> ConsultarEstagioCartaoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarEstagioCartao");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarEstagioCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarEstagioCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EstagioCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstagioCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstagioCartaoResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado Status Cart\u00E3o Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Status de Cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Est\u00E1gio de Entrega do Cart\u00E3o (id)</param> 
        /// <returns>StatusCartaoResponse</returns>
        public StatusCartaoResponse ConsultarStatusCartao (long? id)
        {
             ApiResponse<StatusCartaoResponse> localVarResponse = ConsultarStatusCartaoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Status Cart\u00E3o Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Status de Cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Est\u00E1gio de Entrega do Cart\u00E3o (id)</param> 
        /// <returns>ApiResponse of StatusCartaoResponse</returns>
        public ApiResponse< StatusCartaoResponse > ConsultarStatusCartaoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling StatusParametroApi->ConsultarStatusCartao");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<StatusCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusCartaoResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Status Cart\u00E3o Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Status de Cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Est\u00E1gio de Entrega do Cart\u00E3o (id)</param>
        /// <returns>Task of StatusCartaoResponse</returns>
        public async System.Threading.Tasks.Task<StatusCartaoResponse> ConsultarStatusCartaoAsync (long? id)
        {
             ApiResponse<StatusCartaoResponse> localVarResponse = await ConsultarStatusCartaoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Status Cart\u00E3o Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Status de Cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Est\u00E1gio de Entrega do Cart\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (StatusCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StatusCartaoResponse>> ConsultarStatusCartaoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarStatusCartao");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StatusCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusCartaoResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado Status Conta Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Status Conta a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Status da Conta (id)</param> 
        /// <returns>StatusContaResponse</returns>
        public StatusContaResponse ConsultarStatusConta (long? id)
        {
             ApiResponse<StatusContaResponse> localVarResponse = ConsultarStatusContaWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Status Conta Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Status Conta a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Status da Conta (id)</param> 
        /// <returns>ApiResponse of StatusContaResponse</returns>
        public ApiResponse< StatusContaResponse > ConsultarStatusContaWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling StatusParametroApi->ConsultarStatusConta");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<StatusContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusContaResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Status Conta Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Status Conta a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Status da Conta (id)</param>
        /// <returns>Task of StatusContaResponse</returns>
        public async System.Threading.Tasks.Task<StatusContaResponse> ConsultarStatusContaAsync (long? id)
        {
             ApiResponse<StatusContaResponse> localVarResponse = await ConsultarStatusContaAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Status Conta Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Status Conta a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Status da Conta (id)</param>
        /// <returns>Task of ApiResponse (StatusContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StatusContaResponse>> ConsultarStatusContaAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarStatusConta");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StatusContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusContaResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado Status Impress\u00E3o Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Status de Impress\u00E3o do Cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Status de Impress\u00E3o do Cart\u00E3o (id)</param> 
        /// <returns>StatusImpressaoResponse</returns>
        public StatusImpressaoResponse ConsultarStatusImpressaoCartao (long? id)
        {
             ApiResponse<StatusImpressaoResponse> localVarResponse = ConsultarStatusImpressaoCartaoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Status Impress\u00E3o Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Status de Impress\u00E3o do Cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Status de Impress\u00E3o do Cart\u00E3o (id)</param> 
        /// <returns>ApiResponse of StatusImpressaoResponse</returns>
        public ApiResponse< StatusImpressaoResponse > ConsultarStatusImpressaoCartaoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling StatusParametroApi->ConsultarStatusImpressaoCartao");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusImpressaoCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusImpressaoCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<StatusImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusImpressaoResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Status Impress\u00E3o Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Status de Impress\u00E3o do Cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Status de Impress\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>Task of StatusImpressaoResponse</returns>
        public async System.Threading.Tasks.Task<StatusImpressaoResponse> ConsultarStatusImpressaoCartaoAsync (long? id)
        {
             ApiResponse<StatusImpressaoResponse> localVarResponse = await ConsultarStatusImpressaoCartaoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Status Impress\u00E3o Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Status de Impress\u00E3o do Cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Status de Impress\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (StatusImpressaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StatusImpressaoResponse>> ConsultarStatusImpressaoCartaoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarStatusImpressaoCartao");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusImpressaoCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusImpressaoCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StatusImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusImpressaoResponse)));
            
        }
        
        /// <summary>
        /// Lista as op\u00E7\u00F5es de Est\u00E1gios do Cart\u00E3o Este m\u00E9todo permite que sejam listadas as op\u00E7\u00F5es de Est\u00E1gio de Entrega que podem ser atribu\u00EDdas aos Cart\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Id do est\u00E1gio cart\u00E3o (optional)</param> 
        /// <param name="nome">Nome do est\u00E1gio cart\u00E3o (optional)</param> 
        /// <returns>PageEstagioCartaoResponse</returns>
        public PageEstagioCartaoResponse ListarEstagiosCartoes (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageEstagioCartaoResponse> localVarResponse = ListarEstagiosCartoesWithHttpInfo(sort, page, limit, id, nome);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as op\u00E7\u00F5es de Est\u00E1gios do Cart\u00E3o Este m\u00E9todo permite que sejam listadas as op\u00E7\u00F5es de Est\u00E1gio de Entrega que podem ser atribu\u00EDdas aos Cart\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Id do est\u00E1gio cart\u00E3o (optional)</param> 
        /// <param name="nome">Nome do est\u00E1gio cart\u00E3o (optional)</param> 
        /// <returns>ApiResponse of PageEstagioCartaoResponse</returns>
        public ApiResponse< PageEstagioCartaoResponse > ListarEstagiosCartoesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarEstagiosCartoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarEstagiosCartoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageEstagioCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEstagioCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEstagioCartaoResponse)));
            
        }

        
        /// <summary>
        /// Lista as op\u00E7\u00F5es de Est\u00E1gios do Cart\u00E3o Este m\u00E9todo permite que sejam listadas as op\u00E7\u00F5es de Est\u00E1gio de Entrega que podem ser atribu\u00EDdas aos Cart\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id do est\u00E1gio cart\u00E3o (optional)</param>
        /// <param name="nome">Nome do est\u00E1gio cart\u00E3o (optional)</param>
        /// <returns>Task of PageEstagioCartaoResponse</returns>
        public async System.Threading.Tasks.Task<PageEstagioCartaoResponse> ListarEstagiosCartoesAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageEstagioCartaoResponse> localVarResponse = await ListarEstagiosCartoesAsyncWithHttpInfo(sort, page, limit, id, nome);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as op\u00E7\u00F5es de Est\u00E1gios do Cart\u00E3o Este m\u00E9todo permite que sejam listadas as op\u00E7\u00F5es de Est\u00E1gio de Entrega que podem ser atribu\u00EDdas aos Cart\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id do est\u00E1gio cart\u00E3o (optional)</param>
        /// <param name="nome">Nome do est\u00E1gio cart\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (PageEstagioCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageEstagioCartaoResponse>> ListarEstagiosCartoesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarEstagiosCartoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarEstagiosCartoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageEstagioCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEstagioCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEstagioCartaoResponse)));
            
        }
        
        /// <summary>
        /// Listar status CNAB sumarizados Lista os status CNAB sumarizados existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageTipoBoletoResponse</returns>
        public PageTipoBoletoResponse ListarStatusCNABSumarizados (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTipoBoletoResponse> localVarResponse = ListarStatusCNABSumarizadosWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar status CNAB sumarizados Lista os status CNAB sumarizados existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageTipoBoletoResponse</returns>
        public ApiResponse< PageTipoBoletoResponse > ListarStatusCNABSumarizadosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/status-cnab-sumarizados";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCNABSumarizados: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCNABSumarizados: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoBoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoBoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoBoletoResponse)));
            
        }

        
        /// <summary>
        /// Listar status CNAB sumarizados Lista os status CNAB sumarizados existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageTipoBoletoResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoBoletoResponse> ListarStatusCNABSumarizadosAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTipoBoletoResponse> localVarResponse = await ListarStatusCNABSumarizadosAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar status CNAB sumarizados Lista os status CNAB sumarizados existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoBoletoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoBoletoResponse>> ListarStatusCNABSumarizadosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/status-cnab-sumarizados";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCNABSumarizados: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCNABSumarizados: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoBoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoBoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoBoletoResponse)));
            
        }
        
        /// <summary>
        /// Lista as op\u00E7\u00F5es de Status do Cart\u00E3o Este m\u00E9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00EDdas aos Cart\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Status do Cart\u00E3o (id) (optional)</param> 
        /// <param name="nome">Nome atribu\u00EDdo ao Status de Entrega do Cart\u00E3o (optional)</param> 
        /// <param name="permiteDesbloquear">Par\u00E2metro que define se o status do cart\u00E3o permite a reativa\u00E7\u00E3o do cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param> 
        /// <param name="permiteAtribuirComoBloqueio">Par\u00E2metro que define se o status do cart\u00E3o permite a reativa\u00E7\u00E3o do cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param> 
        /// <param name="permiteAtribuirComoCancelamento">Par\u00E2metro que define se o status do cart\u00E3o permite a reativa\u00E7\u00E3o do cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param> 
        /// <param name="cobrarTarifaAoEmitirNovaVia">Par\u00E2metro que define se o status do cart\u00E3o permite a reativa\u00E7\u00E3o do cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param> 
        /// <returns>PageStatusCartaoResponse</returns>
        public PageStatusCartaoResponse ListarStatusCartoes (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteDesbloquear = null, int? permiteAtribuirComoBloqueio = null, int? permiteAtribuirComoCancelamento = null, int? cobrarTarifaAoEmitirNovaVia = null)
        {
             ApiResponse<PageStatusCartaoResponse> localVarResponse = ListarStatusCartoesWithHttpInfo(sort, page, limit, id, nome, permiteDesbloquear, permiteAtribuirComoBloqueio, permiteAtribuirComoCancelamento, cobrarTarifaAoEmitirNovaVia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as op\u00E7\u00F5es de Status do Cart\u00E3o Este m\u00E9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00EDdas aos Cart\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Status do Cart\u00E3o (id) (optional)</param> 
        /// <param name="nome">Nome atribu\u00EDdo ao Status de Entrega do Cart\u00E3o (optional)</param> 
        /// <param name="permiteDesbloquear">Par\u00E2metro que define se o status do cart\u00E3o permite a reativa\u00E7\u00E3o do cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param> 
        /// <param name="permiteAtribuirComoBloqueio">Par\u00E2metro que define se o status do cart\u00E3o permite a reativa\u00E7\u00E3o do cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param> 
        /// <param name="permiteAtribuirComoCancelamento">Par\u00E2metro que define se o status do cart\u00E3o permite a reativa\u00E7\u00E3o do cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param> 
        /// <param name="cobrarTarifaAoEmitirNovaVia">Par\u00E2metro que define se o status do cart\u00E3o permite a reativa\u00E7\u00E3o do cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param> 
        /// <returns>ApiResponse of PageStatusCartaoResponse</returns>
        public ApiResponse< PageStatusCartaoResponse > ListarStatusCartoesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteDesbloquear = null, int? permiteAtribuirComoBloqueio = null, int? permiteAtribuirComoCancelamento = null, int? cobrarTarifaAoEmitirNovaVia = null)
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (permiteDesbloquear != null) localVarQueryParams.Add("permiteDesbloquear", Configuration.ApiClient.ParameterToString(permiteDesbloquear)); // query parameter
            if (permiteAtribuirComoBloqueio != null) localVarQueryParams.Add("permiteAtribuirComoBloqueio", Configuration.ApiClient.ParameterToString(permiteAtribuirComoBloqueio)); // query parameter
            if (permiteAtribuirComoCancelamento != null) localVarQueryParams.Add("permiteAtribuirComoCancelamento", Configuration.ApiClient.ParameterToString(permiteAtribuirComoCancelamento)); // query parameter
            if (cobrarTarifaAoEmitirNovaVia != null) localVarQueryParams.Add("cobrarTarifaAoEmitirNovaVia", Configuration.ApiClient.ParameterToString(cobrarTarifaAoEmitirNovaVia)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCartoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCartoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageStatusCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusCartaoResponse)));
            
        }

        
        /// <summary>
        /// Lista as op\u00E7\u00F5es de Status do Cart\u00E3o Este m\u00E9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00EDdas aos Cart\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Status do Cart\u00E3o (id) (optional)</param>
        /// <param name="nome">Nome atribu\u00EDdo ao Status de Entrega do Cart\u00E3o (optional)</param>
        /// <param name="permiteDesbloquear">Par\u00E2metro que define se o status do cart\u00E3o permite a reativa\u00E7\u00E3o do cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Par\u00E2metro que define se o status do cart\u00E3o permite a reativa\u00E7\u00E3o do cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Par\u00E2metro que define se o status do cart\u00E3o permite a reativa\u00E7\u00E3o do cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="cobrarTarifaAoEmitirNovaVia">Par\u00E2metro que define se o status do cart\u00E3o permite a reativa\u00E7\u00E3o do cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <returns>Task of PageStatusCartaoResponse</returns>
        public async System.Threading.Tasks.Task<PageStatusCartaoResponse> ListarStatusCartoesAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteDesbloquear = null, int? permiteAtribuirComoBloqueio = null, int? permiteAtribuirComoCancelamento = null, int? cobrarTarifaAoEmitirNovaVia = null)
        {
             ApiResponse<PageStatusCartaoResponse> localVarResponse = await ListarStatusCartoesAsyncWithHttpInfo(sort, page, limit, id, nome, permiteDesbloquear, permiteAtribuirComoBloqueio, permiteAtribuirComoCancelamento, cobrarTarifaAoEmitirNovaVia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as op\u00E7\u00F5es de Status do Cart\u00E3o Este m\u00E9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00EDdas aos Cart\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Status do Cart\u00E3o (id) (optional)</param>
        /// <param name="nome">Nome atribu\u00EDdo ao Status de Entrega do Cart\u00E3o (optional)</param>
        /// <param name="permiteDesbloquear">Par\u00E2metro que define se o status do cart\u00E3o permite a reativa\u00E7\u00E3o do cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Par\u00E2metro que define se o status do cart\u00E3o permite a reativa\u00E7\u00E3o do cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Par\u00E2metro que define se o status do cart\u00E3o permite a reativa\u00E7\u00E3o do cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="cobrarTarifaAoEmitirNovaVia">Par\u00E2metro que define se o status do cart\u00E3o permite a reativa\u00E7\u00E3o do cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageStatusCartaoResponse>> ListarStatusCartoesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteDesbloquear = null, int? permiteAtribuirComoBloqueio = null, int? permiteAtribuirComoCancelamento = null, int? cobrarTarifaAoEmitirNovaVia = null)
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (permiteDesbloquear != null) localVarQueryParams.Add("permiteDesbloquear", Configuration.ApiClient.ParameterToString(permiteDesbloquear)); // query parameter
            if (permiteAtribuirComoBloqueio != null) localVarQueryParams.Add("permiteAtribuirComoBloqueio", Configuration.ApiClient.ParameterToString(permiteAtribuirComoBloqueio)); // query parameter
            if (permiteAtribuirComoCancelamento != null) localVarQueryParams.Add("permiteAtribuirComoCancelamento", Configuration.ApiClient.ParameterToString(permiteAtribuirComoCancelamento)); // query parameter
            if (cobrarTarifaAoEmitirNovaVia != null) localVarQueryParams.Add("cobrarTarifaAoEmitirNovaVia", Configuration.ApiClient.ParameterToString(cobrarTarifaAoEmitirNovaVia)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCartoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCartoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageStatusCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusCartaoResponse)));
            
        }
        
        /// <summary>
        /// Lista os Status Contas cadastrados para o Emissor Este m\u00E9todo permite que sejam listados os Status Contas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Status da Conta (id) (optional)</param> 
        /// <param name="nome">Nome atribu\u00EDdo ao Status da Conta (optional)</param> 
        /// <param name="permiteAlterarVencimento">Par\u00E2metro que define se o Status da conta permite a solicita\u00E7\u00E3o da altera\u00E7\u00E3o do Dia para Vencimento das Faturas, sendo: 0: Inativo e 1: Ativo (optional)</param> 
        /// <param name="permiteAlterarLimite">Par\u00E2metro que define se o Status da conta permite altera\u00E7\u00E3o de Limites, sendo: 0: Inativo e 1: Ativo (optional)</param> 
        /// <param name="permiteEmitirNovaViaCartao">Par\u00E2metro que define se o Status da conta permite solicitar uma nova via de Cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param> 
        /// <param name="permiteFazerTransferencia">Par\u00E2metro que define se o Status da conta permite originar Transfer\u00EAncias de Cr\u00E9dito para outras Contas do mesmo Emissor ou para uma Conta Banc\u00E1ria, sendo: 0: Inativo e 1: Ativo (optional)</param> 
        /// <param name="permiteReceberTransferencia">Par\u00E2metro que define se o Status da conta permite  receber Transfer\u00EAncias de Cr\u00E9dito originadas de outras Contas do mesmo emissor, sendo: 0: Inativo e 1: Ativo (optional)</param> 
        /// <param name="permiteCriarAcordoCobranca">Par\u00E2metro que define se o Status da conta permite ter um Acordo de Cobran\u00E7a de D\u00EDvida criado para ela, sendo: 0: Inativo e 1: Ativo (optional)</param> 
        /// <param name="permiteAtribuirComoBloqueio">Par\u00E2metro que define se o Status da conta permite ser atribu\u00EDdo para Bloquear temporariamente uma Conta, sendo: 0: Inativo e 1: Ativo (optional)</param> 
        /// <param name="permiteDesbloquear">Par\u00E2metro que define se o Status da conta permite ser desbloqueada, sendo: 0: Inativo e 1: Ativo (optional)</param> 
        /// <param name="permiteAtribuirComoCancelamento">Par\u00E2metro que define se o Status da conta permite ser atribu\u00EDdo para realizar o cancelamento definitivo de uma conta, sendo: 0: Inativo e 1: Ativo (optional)</param> 
        /// <returns>PageStatusContaResponse</returns>
        public PageStatusContaResponse ListarStatusConta (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteAlterarVencimento = null, int? permiteAlterarLimite = null, int? permiteEmitirNovaViaCartao = null, int? permiteFazerTransferencia = null, int? permiteReceberTransferencia = null, int? permiteCriarAcordoCobranca = null, int? permiteAtribuirComoBloqueio = null, int? permiteDesbloquear = null, int? permiteAtribuirComoCancelamento = null)
        {
             ApiResponse<PageStatusContaResponse> localVarResponse = ListarStatusContaWithHttpInfo(sort, page, limit, id, nome, permiteAlterarVencimento, permiteAlterarLimite, permiteEmitirNovaViaCartao, permiteFazerTransferencia, permiteReceberTransferencia, permiteCriarAcordoCobranca, permiteAtribuirComoBloqueio, permiteDesbloquear, permiteAtribuirComoCancelamento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Status Contas cadastrados para o Emissor Este m\u00E9todo permite que sejam listados os Status Contas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Status da Conta (id) (optional)</param> 
        /// <param name="nome">Nome atribu\u00EDdo ao Status da Conta (optional)</param> 
        /// <param name="permiteAlterarVencimento">Par\u00E2metro que define se o Status da conta permite a solicita\u00E7\u00E3o da altera\u00E7\u00E3o do Dia para Vencimento das Faturas, sendo: 0: Inativo e 1: Ativo (optional)</param> 
        /// <param name="permiteAlterarLimite">Par\u00E2metro que define se o Status da conta permite altera\u00E7\u00E3o de Limites, sendo: 0: Inativo e 1: Ativo (optional)</param> 
        /// <param name="permiteEmitirNovaViaCartao">Par\u00E2metro que define se o Status da conta permite solicitar uma nova via de Cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param> 
        /// <param name="permiteFazerTransferencia">Par\u00E2metro que define se o Status da conta permite originar Transfer\u00EAncias de Cr\u00E9dito para outras Contas do mesmo Emissor ou para uma Conta Banc\u00E1ria, sendo: 0: Inativo e 1: Ativo (optional)</param> 
        /// <param name="permiteReceberTransferencia">Par\u00E2metro que define se o Status da conta permite  receber Transfer\u00EAncias de Cr\u00E9dito originadas de outras Contas do mesmo emissor, sendo: 0: Inativo e 1: Ativo (optional)</param> 
        /// <param name="permiteCriarAcordoCobranca">Par\u00E2metro que define se o Status da conta permite ter um Acordo de Cobran\u00E7a de D\u00EDvida criado para ela, sendo: 0: Inativo e 1: Ativo (optional)</param> 
        /// <param name="permiteAtribuirComoBloqueio">Par\u00E2metro que define se o Status da conta permite ser atribu\u00EDdo para Bloquear temporariamente uma Conta, sendo: 0: Inativo e 1: Ativo (optional)</param> 
        /// <param name="permiteDesbloquear">Par\u00E2metro que define se o Status da conta permite ser desbloqueada, sendo: 0: Inativo e 1: Ativo (optional)</param> 
        /// <param name="permiteAtribuirComoCancelamento">Par\u00E2metro que define se o Status da conta permite ser atribu\u00EDdo para realizar o cancelamento definitivo de uma conta, sendo: 0: Inativo e 1: Ativo (optional)</param> 
        /// <returns>ApiResponse of PageStatusContaResponse</returns>
        public ApiResponse< PageStatusContaResponse > ListarStatusContaWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteAlterarVencimento = null, int? permiteAlterarLimite = null, int? permiteEmitirNovaViaCartao = null, int? permiteFazerTransferencia = null, int? permiteReceberTransferencia = null, int? permiteCriarAcordoCobranca = null, int? permiteAtribuirComoBloqueio = null, int? permiteDesbloquear = null, int? permiteAtribuirComoCancelamento = null)
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (permiteAlterarVencimento != null) localVarQueryParams.Add("permiteAlterarVencimento", Configuration.ApiClient.ParameterToString(permiteAlterarVencimento)); // query parameter
            if (permiteAlterarLimite != null) localVarQueryParams.Add("permiteAlterarLimite", Configuration.ApiClient.ParameterToString(permiteAlterarLimite)); // query parameter
            if (permiteEmitirNovaViaCartao != null) localVarQueryParams.Add("permiteEmitirNovaViaCartao", Configuration.ApiClient.ParameterToString(permiteEmitirNovaViaCartao)); // query parameter
            if (permiteFazerTransferencia != null) localVarQueryParams.Add("permiteFazerTransferencia", Configuration.ApiClient.ParameterToString(permiteFazerTransferencia)); // query parameter
            if (permiteReceberTransferencia != null) localVarQueryParams.Add("permiteReceberTransferencia", Configuration.ApiClient.ParameterToString(permiteReceberTransferencia)); // query parameter
            if (permiteCriarAcordoCobranca != null) localVarQueryParams.Add("permiteCriarAcordoCobranca", Configuration.ApiClient.ParameterToString(permiteCriarAcordoCobranca)); // query parameter
            if (permiteAtribuirComoBloqueio != null) localVarQueryParams.Add("permiteAtribuirComoBloqueio", Configuration.ApiClient.ParameterToString(permiteAtribuirComoBloqueio)); // query parameter
            if (permiteDesbloquear != null) localVarQueryParams.Add("permiteDesbloquear", Configuration.ApiClient.ParameterToString(permiteDesbloquear)); // query parameter
            if (permiteAtribuirComoCancelamento != null) localVarQueryParams.Add("permiteAtribuirComoCancelamento", Configuration.ApiClient.ParameterToString(permiteAtribuirComoCancelamento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageStatusContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusContaResponse)));
            
        }

        
        /// <summary>
        /// Lista os Status Contas cadastrados para o Emissor Este m\u00E9todo permite que sejam listados os Status Contas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Status da Conta (id) (optional)</param>
        /// <param name="nome">Nome atribu\u00EDdo ao Status da Conta (optional)</param>
        /// <param name="permiteAlterarVencimento">Par\u00E2metro que define se o Status da conta permite a solicita\u00E7\u00E3o da altera\u00E7\u00E3o do Dia para Vencimento das Faturas, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteAlterarLimite">Par\u00E2metro que define se o Status da conta permite altera\u00E7\u00E3o de Limites, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteEmitirNovaViaCartao">Par\u00E2metro que define se o Status da conta permite solicitar uma nova via de Cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteFazerTransferencia">Par\u00E2metro que define se o Status da conta permite originar Transfer\u00EAncias de Cr\u00E9dito para outras Contas do mesmo Emissor ou para uma Conta Banc\u00E1ria, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteReceberTransferencia">Par\u00E2metro que define se o Status da conta permite  receber Transfer\u00EAncias de Cr\u00E9dito originadas de outras Contas do mesmo emissor, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteCriarAcordoCobranca">Par\u00E2metro que define se o Status da conta permite ter um Acordo de Cobran\u00E7a de D\u00EDvida criado para ela, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Par\u00E2metro que define se o Status da conta permite ser atribu\u00EDdo para Bloquear temporariamente uma Conta, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteDesbloquear">Par\u00E2metro que define se o Status da conta permite ser desbloqueada, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Par\u00E2metro que define se o Status da conta permite ser atribu\u00EDdo para realizar o cancelamento definitivo de uma conta, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <returns>Task of PageStatusContaResponse</returns>
        public async System.Threading.Tasks.Task<PageStatusContaResponse> ListarStatusContaAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteAlterarVencimento = null, int? permiteAlterarLimite = null, int? permiteEmitirNovaViaCartao = null, int? permiteFazerTransferencia = null, int? permiteReceberTransferencia = null, int? permiteCriarAcordoCobranca = null, int? permiteAtribuirComoBloqueio = null, int? permiteDesbloquear = null, int? permiteAtribuirComoCancelamento = null)
        {
             ApiResponse<PageStatusContaResponse> localVarResponse = await ListarStatusContaAsyncWithHttpInfo(sort, page, limit, id, nome, permiteAlterarVencimento, permiteAlterarLimite, permiteEmitirNovaViaCartao, permiteFazerTransferencia, permiteReceberTransferencia, permiteCriarAcordoCobranca, permiteAtribuirComoBloqueio, permiteDesbloquear, permiteAtribuirComoCancelamento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Status Contas cadastrados para o Emissor Este m\u00E9todo permite que sejam listados os Status Contas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Status da Conta (id) (optional)</param>
        /// <param name="nome">Nome atribu\u00EDdo ao Status da Conta (optional)</param>
        /// <param name="permiteAlterarVencimento">Par\u00E2metro que define se o Status da conta permite a solicita\u00E7\u00E3o da altera\u00E7\u00E3o do Dia para Vencimento das Faturas, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteAlterarLimite">Par\u00E2metro que define se o Status da conta permite altera\u00E7\u00E3o de Limites, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteEmitirNovaViaCartao">Par\u00E2metro que define se o Status da conta permite solicitar uma nova via de Cart\u00E3o, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteFazerTransferencia">Par\u00E2metro que define se o Status da conta permite originar Transfer\u00EAncias de Cr\u00E9dito para outras Contas do mesmo Emissor ou para uma Conta Banc\u00E1ria, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteReceberTransferencia">Par\u00E2metro que define se o Status da conta permite  receber Transfer\u00EAncias de Cr\u00E9dito originadas de outras Contas do mesmo emissor, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteCriarAcordoCobranca">Par\u00E2metro que define se o Status da conta permite ter um Acordo de Cobran\u00E7a de D\u00EDvida criado para ela, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Par\u00E2metro que define se o Status da conta permite ser atribu\u00EDdo para Bloquear temporariamente uma Conta, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteDesbloquear">Par\u00E2metro que define se o Status da conta permite ser desbloqueada, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Par\u00E2metro que define se o Status da conta permite ser atribu\u00EDdo para realizar o cancelamento definitivo de uma conta, sendo: 0: Inativo e 1: Ativo (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageStatusContaResponse>> ListarStatusContaAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteAlterarVencimento = null, int? permiteAlterarLimite = null, int? permiteEmitirNovaViaCartao = null, int? permiteFazerTransferencia = null, int? permiteReceberTransferencia = null, int? permiteCriarAcordoCobranca = null, int? permiteAtribuirComoBloqueio = null, int? permiteDesbloquear = null, int? permiteAtribuirComoCancelamento = null)
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (permiteAlterarVencimento != null) localVarQueryParams.Add("permiteAlterarVencimento", Configuration.ApiClient.ParameterToString(permiteAlterarVencimento)); // query parameter
            if (permiteAlterarLimite != null) localVarQueryParams.Add("permiteAlterarLimite", Configuration.ApiClient.ParameterToString(permiteAlterarLimite)); // query parameter
            if (permiteEmitirNovaViaCartao != null) localVarQueryParams.Add("permiteEmitirNovaViaCartao", Configuration.ApiClient.ParameterToString(permiteEmitirNovaViaCartao)); // query parameter
            if (permiteFazerTransferencia != null) localVarQueryParams.Add("permiteFazerTransferencia", Configuration.ApiClient.ParameterToString(permiteFazerTransferencia)); // query parameter
            if (permiteReceberTransferencia != null) localVarQueryParams.Add("permiteReceberTransferencia", Configuration.ApiClient.ParameterToString(permiteReceberTransferencia)); // query parameter
            if (permiteCriarAcordoCobranca != null) localVarQueryParams.Add("permiteCriarAcordoCobranca", Configuration.ApiClient.ParameterToString(permiteCriarAcordoCobranca)); // query parameter
            if (permiteAtribuirComoBloqueio != null) localVarQueryParams.Add("permiteAtribuirComoBloqueio", Configuration.ApiClient.ParameterToString(permiteAtribuirComoBloqueio)); // query parameter
            if (permiteDesbloquear != null) localVarQueryParams.Add("permiteDesbloquear", Configuration.ApiClient.ParameterToString(permiteDesbloquear)); // query parameter
            if (permiteAtribuirComoCancelamento != null) localVarQueryParams.Add("permiteAtribuirComoCancelamento", Configuration.ApiClient.ParameterToString(permiteAtribuirComoCancelamento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageStatusContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusContaResponse)));
            
        }
        
        /// <summary>
        /// Lista as op\u00E7\u00F5es de Status Impress\u00E3o Este m\u00E9todo permite que sejam listadas as op\u00E7\u00F5es de Status Impress\u00E3o que podem ser atribu\u00EDdas aos Cart\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Id do est\u00E1gio cart\u00E3o (optional)</param> 
        /// <param name="nome">Nome do status impress\u00E3o (optional)</param> 
        /// <returns>PageStatusImpressaoResponse</returns>
        public PageStatusImpressaoResponse ListarStatusImpressaoCartao (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageStatusImpressaoResponse> localVarResponse = ListarStatusImpressaoCartaoWithHttpInfo(sort, page, limit, id, nome);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as op\u00E7\u00F5es de Status Impress\u00E3o Este m\u00E9todo permite que sejam listadas as op\u00E7\u00F5es de Status Impress\u00E3o que podem ser atribu\u00EDdas aos Cart\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Id do est\u00E1gio cart\u00E3o (optional)</param> 
        /// <param name="nome">Nome do status impress\u00E3o (optional)</param> 
        /// <returns>ApiResponse of PageStatusImpressaoResponse</returns>
        public ApiResponse< PageStatusImpressaoResponse > ListarStatusImpressaoCartaoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusImpressaoCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusImpressaoCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageStatusImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusImpressaoResponse)));
            
        }

        
        /// <summary>
        /// Lista as op\u00E7\u00F5es de Status Impress\u00E3o Este m\u00E9todo permite que sejam listadas as op\u00E7\u00F5es de Status Impress\u00E3o que podem ser atribu\u00EDdas aos Cart\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id do est\u00E1gio cart\u00E3o (optional)</param>
        /// <param name="nome">Nome do status impress\u00E3o (optional)</param>
        /// <returns>Task of PageStatusImpressaoResponse</returns>
        public async System.Threading.Tasks.Task<PageStatusImpressaoResponse> ListarStatusImpressaoCartaoAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageStatusImpressaoResponse> localVarResponse = await ListarStatusImpressaoCartaoAsyncWithHttpInfo(sort, page, limit, id, nome);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as op\u00E7\u00F5es de Status Impress\u00E3o Este m\u00E9todo permite que sejam listadas as op\u00E7\u00F5es de Status Impress\u00E3o que podem ser atribu\u00EDdas aos Cart\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id do est\u00E1gio cart\u00E3o (optional)</param>
        /// <param name="nome">Nome do status impress\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusImpressaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageStatusImpressaoResponse>> ListarStatusImpressaoCartaoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusImpressaoCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusImpressaoCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageStatusImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusImpressaoResponse)));
            
        }
        
    }
    
}
