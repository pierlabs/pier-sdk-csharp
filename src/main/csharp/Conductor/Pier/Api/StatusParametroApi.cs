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
        StatusContaResponse ConsultarUsingGET23 (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Status Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status Conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id).</param>
        /// <returns>ApiResponse of StatusContaResponse</returns>
        ApiResponse<StatusContaResponse> ConsultarUsingGET23WithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Status Impress\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>StatusImpressaoResponse</returns>
        StatusImpressaoResponse ConsultarUsingGET24 (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Status Impress\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>ApiResponse of StatusImpressaoResponse</returns>
        ApiResponse<StatusImpressaoResponse> ConsultarUsingGET24WithHttpInfo (long? id);
        
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gios do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gio de Entrega que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="nome">Nome do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <returns>PageEstagioCartaoResponse</returns>
        PageEstagioCartaoResponse ListarEstagiosCartoesUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
  
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gios do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gio de Entrega que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="nome">Nome do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <returns>ApiResponse of PageEstagioCartaoResponse</returns>
        ApiResponse<PageEstagioCartaoResponse> ListarEstagiosCartoesUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
        
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id)  (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (optional)</param>
        /// <param name="permiteDesbloquear">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="cobrarTarifaAoEmitirNovaVia">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <returns>PageStatusCartaoResponse</returns>
        PageStatusCartaoResponse ListarStatusCartoesUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteDesbloquear = null, int? permiteAtribuirComoBloqueio = null, int? permiteAtribuirComoCancelamento = null, int? cobrarTarifaAoEmitirNovaVia = null);
  
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id)  (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (optional)</param>
        /// <param name="permiteDesbloquear">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="cobrarTarifaAoEmitirNovaVia">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <returns>ApiResponse of PageStatusCartaoResponse</returns>
        ApiResponse<PageStatusCartaoResponse> ListarStatusCartoesUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteDesbloquear = null, int? permiteAtribuirComoBloqueio = null, int? permiteAtribuirComoCancelamento = null, int? cobrarTarifaAoEmitirNovaVia = null);
        
        /// <summary>
        /// Lista os tipos de transa\u00C3\u00A7\u00C3\u00B5es
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os tipos de transa\u00C3\u00A7\u00C3\u00B5es dispon\u00C3\u00ADveis.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        List<Object> ListarTiposEventosTransacoesUsingGET ();
  
        /// <summary>
        /// Lista os tipos de transa\u00C3\u00A7\u00C3\u00B5es
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os tipos de transa\u00C3\u00A7\u00C3\u00B5es dispon\u00C3\u00ADveis.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        ApiResponse<List<Object>> ListarTiposEventosTransacoesUsingGETWithHttpInfo ();
        
        /// <summary>
        /// Lista os Status Contas cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Status Contas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id). (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status da Conta. (optional)</param>
        /// <param name="permiteAlterarVencimento">Par\u00C3\u00A2metro que define se o Status da conta permite a solicita\u00C3\u00A7\u00C3\u00A3o da altera\u00C3\u00A7\u00C3\u00A3o do Dia para Vencimento das Faturas, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteAlterarLimite">Par\u00C3\u00A2metro que define se o Status da conta permite altera\u00C3\u00A7\u00C3\u00A3o de Limites, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteEmitirNovaViaCartao">Par\u00C3\u00A2metro que define se o Status da conta permite solicitar uma nova via de Cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteFazerTransferencia">Par\u00C3\u00A2metro que define se o Status da conta permite originar Transfer\u00C3\u00AAncias de Cr\u00C3\u00A9dito para outras Contas do mesmo Emissor ou para uma Conta Banc\u00C3\u00A1ria, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteReceberTransferencia">Par\u00C3\u00A2metro que define se o Status da conta permite  receber Transfer\u00C3\u00AAncias de Cr\u00C3\u00A9dito originadas de outras Contas do mesmo emissor, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteCriarAcordoCobranca">Par\u00C3\u00A2metro que define se o Status da conta permite ter um Acordo de Cobran\u00C3\u00A7a de D\u00C3\u00ADvida criado para ela, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Par\u00C3\u00A2metro que define se o Status da conta permite ser atribu\u00C3\u00ADdo para Bloquear temporariamente uma Conta, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteDesbloquear">Par\u00C3\u00A2metro que define se o Status da conta permite ser desbloqueada, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Par\u00C3\u00A2metro que define se o Status da conta permite ser atribu\u00C3\u00ADdo para realizar o cancelamento definitivo de uma conta, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <returns>PageStatusContaResponse</returns>
        PageStatusContaResponse ListarUsingGET30 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteAlterarVencimento = null, int? permiteAlterarLimite = null, int? permiteEmitirNovaViaCartao = null, int? permiteFazerTransferencia = null, int? permiteReceberTransferencia = null, int? permiteCriarAcordoCobranca = null, int? permiteAtribuirComoBloqueio = null, int? permiteDesbloquear = null, int? permiteAtribuirComoCancelamento = null);
  
        /// <summary>
        /// Lista os Status Contas cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Status Contas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id). (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status da Conta. (optional)</param>
        /// <param name="permiteAlterarVencimento">Par\u00C3\u00A2metro que define se o Status da conta permite a solicita\u00C3\u00A7\u00C3\u00A3o da altera\u00C3\u00A7\u00C3\u00A3o do Dia para Vencimento das Faturas, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteAlterarLimite">Par\u00C3\u00A2metro que define se o Status da conta permite altera\u00C3\u00A7\u00C3\u00A3o de Limites, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteEmitirNovaViaCartao">Par\u00C3\u00A2metro que define se o Status da conta permite solicitar uma nova via de Cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteFazerTransferencia">Par\u00C3\u00A2metro que define se o Status da conta permite originar Transfer\u00C3\u00AAncias de Cr\u00C3\u00A9dito para outras Contas do mesmo Emissor ou para uma Conta Banc\u00C3\u00A1ria, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteReceberTransferencia">Par\u00C3\u00A2metro que define se o Status da conta permite  receber Transfer\u00C3\u00AAncias de Cr\u00C3\u00A9dito originadas de outras Contas do mesmo emissor, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteCriarAcordoCobranca">Par\u00C3\u00A2metro que define se o Status da conta permite ter um Acordo de Cobran\u00C3\u00A7a de D\u00C3\u00ADvida criado para ela, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Par\u00C3\u00A2metro que define se o Status da conta permite ser atribu\u00C3\u00ADdo para Bloquear temporariamente uma Conta, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteDesbloquear">Par\u00C3\u00A2metro que define se o Status da conta permite ser desbloqueada, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Par\u00C3\u00A2metro que define se o Status da conta permite ser atribu\u00C3\u00ADdo para realizar o cancelamento definitivo de uma conta, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <returns>ApiResponse of PageStatusContaResponse</returns>
        ApiResponse<PageStatusContaResponse> ListarUsingGET30WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteAlterarVencimento = null, int? permiteAlterarLimite = null, int? permiteEmitirNovaViaCartao = null, int? permiteFazerTransferencia = null, int? permiteReceberTransferencia = null, int? permiteCriarAcordoCobranca = null, int? permiteAtribuirComoBloqueio = null, int? permiteDesbloquear = null, int? permiteAtribuirComoCancelamento = null);
        
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status Impress\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Status Impress\u00C3\u00A3o que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="nome">Nome do status impress\u00C3\u00A3o (optional)</param>
        /// <returns>PageStatusImpressaoResponse</returns>
        PageStatusImpressaoResponse ListarUsingGET31 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
  
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status Impress\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Status Impress\u00C3\u00A3o que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="nome">Nome do status impress\u00C3\u00A3o (optional)</param>
        /// <returns>ApiResponse of PageStatusImpressaoResponse</returns>
        ApiResponse<PageStatusImpressaoResponse> ListarUsingGET31WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
        
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
        System.Threading.Tasks.Task<StatusContaResponse> ConsultarUsingGET23Async (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Status Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status Conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id).</param>
        /// <returns>Task of ApiResponse (StatusContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StatusContaResponse>> ConsultarUsingGET23AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Status Impress\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of StatusImpressaoResponse</returns>
        System.Threading.Tasks.Task<StatusImpressaoResponse> ConsultarUsingGET24Async (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Status Impress\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (StatusImpressaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StatusImpressaoResponse>> ConsultarUsingGET24AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gios do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gio de Entrega que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="nome">Nome do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <returns>Task of PageEstagioCartaoResponse</returns>
        System.Threading.Tasks.Task<PageEstagioCartaoResponse> ListarEstagiosCartoesUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);

        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gios do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gio de Entrega que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="nome">Nome do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <returns>Task of ApiResponse (PageEstagioCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageEstagioCartaoResponse>> ListarEstagiosCartoesUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
        
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id)  (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (optional)</param>
        /// <param name="permiteDesbloquear">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="cobrarTarifaAoEmitirNovaVia">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <returns>Task of PageStatusCartaoResponse</returns>
        System.Threading.Tasks.Task<PageStatusCartaoResponse> ListarStatusCartoesUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteDesbloquear = null, int? permiteAtribuirComoBloqueio = null, int? permiteAtribuirComoCancelamento = null, int? cobrarTarifaAoEmitirNovaVia = null);

        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id)  (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (optional)</param>
        /// <param name="permiteDesbloquear">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="cobrarTarifaAoEmitirNovaVia">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageStatusCartaoResponse>> ListarStatusCartoesUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteDesbloquear = null, int? permiteAtribuirComoBloqueio = null, int? permiteAtribuirComoCancelamento = null, int? cobrarTarifaAoEmitirNovaVia = null);
        
        /// <summary>
        /// Lista os tipos de transa\u00C3\u00A7\u00C3\u00B5es
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os tipos de transa\u00C3\u00A7\u00C3\u00B5es dispon\u00C3\u00ADveis.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Object&gt;</returns>
        System.Threading.Tasks.Task<List<Object>> ListarTiposEventosTransacoesUsingGETAsync ();

        /// <summary>
        /// Lista os tipos de transa\u00C3\u00A7\u00C3\u00B5es
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os tipos de transa\u00C3\u00A7\u00C3\u00B5es dispon\u00C3\u00ADveis.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Object>>> ListarTiposEventosTransacoesUsingGETAsyncWithHttpInfo ();
        
        /// <summary>
        /// Lista os Status Contas cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Status Contas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id). (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status da Conta. (optional)</param>
        /// <param name="permiteAlterarVencimento">Par\u00C3\u00A2metro que define se o Status da conta permite a solicita\u00C3\u00A7\u00C3\u00A3o da altera\u00C3\u00A7\u00C3\u00A3o do Dia para Vencimento das Faturas, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteAlterarLimite">Par\u00C3\u00A2metro que define se o Status da conta permite altera\u00C3\u00A7\u00C3\u00A3o de Limites, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteEmitirNovaViaCartao">Par\u00C3\u00A2metro que define se o Status da conta permite solicitar uma nova via de Cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteFazerTransferencia">Par\u00C3\u00A2metro que define se o Status da conta permite originar Transfer\u00C3\u00AAncias de Cr\u00C3\u00A9dito para outras Contas do mesmo Emissor ou para uma Conta Banc\u00C3\u00A1ria, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteReceberTransferencia">Par\u00C3\u00A2metro que define se o Status da conta permite  receber Transfer\u00C3\u00AAncias de Cr\u00C3\u00A9dito originadas de outras Contas do mesmo emissor, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteCriarAcordoCobranca">Par\u00C3\u00A2metro que define se o Status da conta permite ter um Acordo de Cobran\u00C3\u00A7a de D\u00C3\u00ADvida criado para ela, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Par\u00C3\u00A2metro que define se o Status da conta permite ser atribu\u00C3\u00ADdo para Bloquear temporariamente uma Conta, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteDesbloquear">Par\u00C3\u00A2metro que define se o Status da conta permite ser desbloqueada, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Par\u00C3\u00A2metro que define se o Status da conta permite ser atribu\u00C3\u00ADdo para realizar o cancelamento definitivo de uma conta, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <returns>Task of PageStatusContaResponse</returns>
        System.Threading.Tasks.Task<PageStatusContaResponse> ListarUsingGET30Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteAlterarVencimento = null, int? permiteAlterarLimite = null, int? permiteEmitirNovaViaCartao = null, int? permiteFazerTransferencia = null, int? permiteReceberTransferencia = null, int? permiteCriarAcordoCobranca = null, int? permiteAtribuirComoBloqueio = null, int? permiteDesbloquear = null, int? permiteAtribuirComoCancelamento = null);

        /// <summary>
        /// Lista os Status Contas cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Status Contas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id). (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status da Conta. (optional)</param>
        /// <param name="permiteAlterarVencimento">Par\u00C3\u00A2metro que define se o Status da conta permite a solicita\u00C3\u00A7\u00C3\u00A3o da altera\u00C3\u00A7\u00C3\u00A3o do Dia para Vencimento das Faturas, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteAlterarLimite">Par\u00C3\u00A2metro que define se o Status da conta permite altera\u00C3\u00A7\u00C3\u00A3o de Limites, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteEmitirNovaViaCartao">Par\u00C3\u00A2metro que define se o Status da conta permite solicitar uma nova via de Cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteFazerTransferencia">Par\u00C3\u00A2metro que define se o Status da conta permite originar Transfer\u00C3\u00AAncias de Cr\u00C3\u00A9dito para outras Contas do mesmo Emissor ou para uma Conta Banc\u00C3\u00A1ria, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteReceberTransferencia">Par\u00C3\u00A2metro que define se o Status da conta permite  receber Transfer\u00C3\u00AAncias de Cr\u00C3\u00A9dito originadas de outras Contas do mesmo emissor, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteCriarAcordoCobranca">Par\u00C3\u00A2metro que define se o Status da conta permite ter um Acordo de Cobran\u00C3\u00A7a de D\u00C3\u00ADvida criado para ela, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Par\u00C3\u00A2metro que define se o Status da conta permite ser atribu\u00C3\u00ADdo para Bloquear temporariamente uma Conta, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteDesbloquear">Par\u00C3\u00A2metro que define se o Status da conta permite ser desbloqueada, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Par\u00C3\u00A2metro que define se o Status da conta permite ser atribu\u00C3\u00ADdo para realizar o cancelamento definitivo de uma conta, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageStatusContaResponse>> ListarUsingGET30AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteAlterarVencimento = null, int? permiteAlterarLimite = null, int? permiteEmitirNovaViaCartao = null, int? permiteFazerTransferencia = null, int? permiteReceberTransferencia = null, int? permiteCriarAcordoCobranca = null, int? permiteAtribuirComoBloqueio = null, int? permiteDesbloquear = null, int? permiteAtribuirComoCancelamento = null);
        
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status Impress\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Status Impress\u00C3\u00A3o que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="nome">Nome do status impress\u00C3\u00A3o (optional)</param>
        /// <returns>Task of PageStatusImpressaoResponse</returns>
        System.Threading.Tasks.Task<PageStatusImpressaoResponse> ListarUsingGET31Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);

        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status Impress\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Status Impress\u00C3\u00A3o que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="nome">Nome do status impress\u00C3\u00A3o (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusImpressaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageStatusImpressaoResponse>> ListarUsingGET31AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
        
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
                throw new ApiException(400, "Missing required parameter 'id' when calling StatusParametroApi->ConsultarEstagioCartaoUsingGET");
            
    
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
                throw new ApiException(400, "Missing required parameter 'id' when calling StatusParametroApi->ConsultarStatusCartaoUsingGET");
            
    
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
        public StatusContaResponse ConsultarUsingGET23 (long? id)
        {
             ApiResponse<StatusContaResponse> localVarResponse = ConsultarUsingGET23WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Status Conta Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status Conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id).</param> 
        /// <returns>ApiResponse of StatusContaResponse</returns>
        public ApiResponse< StatusContaResponse > ConsultarUsingGET23WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling StatusParametroApi->ConsultarUsingGET23");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET23: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET23: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<StatusContaResponse> ConsultarUsingGET23Async (long? id)
        {
             ApiResponse<StatusContaResponse> localVarResponse = await ConsultarUsingGET23AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Status Conta Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status Conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id).</param>
        /// <returns>Task of ApiResponse (StatusContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StatusContaResponse>> ConsultarUsingGET23AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET23");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET23: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET23: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public StatusImpressaoResponse ConsultarUsingGET24 (long? id)
        {
             ApiResponse<StatusImpressaoResponse> localVarResponse = ConsultarUsingGET24WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Status Impress\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>ApiResponse of StatusImpressaoResponse</returns>
        public ApiResponse< StatusImpressaoResponse > ConsultarUsingGET24WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling StatusParametroApi->ConsultarUsingGET24");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET24: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET24: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<StatusImpressaoResponse> ConsultarUsingGET24Async (long? id)
        {
             ApiResponse<StatusImpressaoResponse> localVarResponse = await ConsultarUsingGET24AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Status Impress\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (StatusImpressaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StatusImpressaoResponse>> ConsultarUsingGET24AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET24");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET24: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET24: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StatusImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusImpressaoResponse)));
            
        }
        
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gios do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gio de Entrega que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param> 
        /// <param name="nome">Nome do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param> 
        /// <returns>PageEstagioCartaoResponse</returns>
        public PageEstagioCartaoResponse ListarEstagiosCartoesUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageEstagioCartaoResponse> localVarResponse = ListarEstagiosCartoesUsingGETWithHttpInfo(sort, page, limit, id, nome);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gios do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gio de Entrega que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param> 
        /// <param name="nome">Nome do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param> 
        /// <returns>ApiResponse of PageEstagioCartaoResponse</returns>
        public ApiResponse< PageEstagioCartaoResponse > ListarEstagiosCartoesUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
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
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="nome">Nome do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <returns>Task of PageEstagioCartaoResponse</returns>
        public async System.Threading.Tasks.Task<PageEstagioCartaoResponse> ListarEstagiosCartoesUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageEstagioCartaoResponse> localVarResponse = await ListarEstagiosCartoesUsingGETAsyncWithHttpInfo(sort, page, limit, id, nome);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gios do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gio de Entrega que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="nome">Nome do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <returns>Task of ApiResponse (PageEstagioCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageEstagioCartaoResponse>> ListarEstagiosCartoesUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
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
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id)  (optional)</param> 
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="permiteDesbloquear">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="permiteAtribuirComoBloqueio">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="permiteAtribuirComoCancelamento">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="cobrarTarifaAoEmitirNovaVia">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <returns>PageStatusCartaoResponse</returns>
        public PageStatusCartaoResponse ListarStatusCartoesUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteDesbloquear = null, int? permiteAtribuirComoBloqueio = null, int? permiteAtribuirComoCancelamento = null, int? cobrarTarifaAoEmitirNovaVia = null)
        {
             ApiResponse<PageStatusCartaoResponse> localVarResponse = ListarStatusCartoesUsingGETWithHttpInfo(sort, page, limit, id, nome, permiteDesbloquear, permiteAtribuirComoBloqueio, permiteAtribuirComoCancelamento, cobrarTarifaAoEmitirNovaVia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id)  (optional)</param> 
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="permiteDesbloquear">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="permiteAtribuirComoBloqueio">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="permiteAtribuirComoCancelamento">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="cobrarTarifaAoEmitirNovaVia">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <returns>ApiResponse of PageStatusCartaoResponse</returns>
        public ApiResponse< PageStatusCartaoResponse > ListarStatusCartoesUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteDesbloquear = null, int? permiteAtribuirComoBloqueio = null, int? permiteAtribuirComoCancelamento = null, int? cobrarTarifaAoEmitirNovaVia = null)
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
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id)  (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (optional)</param>
        /// <param name="permiteDesbloquear">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="cobrarTarifaAoEmitirNovaVia">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <returns>Task of PageStatusCartaoResponse</returns>
        public async System.Threading.Tasks.Task<PageStatusCartaoResponse> ListarStatusCartoesUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteDesbloquear = null, int? permiteAtribuirComoBloqueio = null, int? permiteAtribuirComoCancelamento = null, int? cobrarTarifaAoEmitirNovaVia = null)
        {
             ApiResponse<PageStatusCartaoResponse> localVarResponse = await ListarStatusCartoesUsingGETAsyncWithHttpInfo(sort, page, limit, id, nome, permiteDesbloquear, permiteAtribuirComoBloqueio, permiteAtribuirComoCancelamento, cobrarTarifaAoEmitirNovaVia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id)  (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (optional)</param>
        /// <param name="permiteDesbloquear">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="cobrarTarifaAoEmitirNovaVia">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageStatusCartaoResponse>> ListarStatusCartoesUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteDesbloquear = null, int? permiteAtribuirComoBloqueio = null, int? permiteAtribuirComoCancelamento = null, int? cobrarTarifaAoEmitirNovaVia = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCartoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCartoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageStatusCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusCartaoResponse)));
            
        }
        
        /// <summary>
        /// Lista os tipos de transa\u00C3\u00A7\u00C3\u00B5es Esse recurso permite listar os tipos de transa\u00C3\u00A7\u00C3\u00B5es dispon\u00C3\u00ADveis.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        public List<Object> ListarTiposEventosTransacoesUsingGET ()
        {
             ApiResponse<List<Object>> localVarResponse = ListarTiposEventosTransacoesUsingGETWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os tipos de transa\u00C3\u00A7\u00C3\u00B5es Esse recurso permite listar os tipos de transa\u00C3\u00A7\u00C3\u00B5es dispon\u00C3\u00ADveis.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        public ApiResponse< List<Object> > ListarTiposEventosTransacoesUsingGETWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/tipos-eventos-transacoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposEventosTransacoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposEventosTransacoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
            
        }

        
        /// <summary>
        /// Lista os tipos de transa\u00C3\u00A7\u00C3\u00B5es Esse recurso permite listar os tipos de transa\u00C3\u00A7\u00C3\u00B5es dispon\u00C3\u00ADveis.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Object&gt;</returns>
        public async System.Threading.Tasks.Task<List<Object>> ListarTiposEventosTransacoesUsingGETAsync ()
        {
             ApiResponse<List<Object>> localVarResponse = await ListarTiposEventosTransacoesUsingGETAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os tipos de transa\u00C3\u00A7\u00C3\u00B5es Esse recurso permite listar os tipos de transa\u00C3\u00A7\u00C3\u00B5es dispon\u00C3\u00ADveis.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Object>>> ListarTiposEventosTransacoesUsingGETAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/tipos-eventos-transacoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposEventosTransacoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposEventosTransacoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
            
        }
        
        /// <summary>
        /// Lista os Status Contas cadastrados para o Emissor Este m\u00C3\u00A9todo permite que sejam listados os Status Contas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id). (optional)</param> 
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status da Conta. (optional)</param> 
        /// <param name="permiteAlterarVencimento">Par\u00C3\u00A2metro que define se o Status da conta permite a solicita\u00C3\u00A7\u00C3\u00A3o da altera\u00C3\u00A7\u00C3\u00A3o do Dia para Vencimento das Faturas, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="permiteAlterarLimite">Par\u00C3\u00A2metro que define se o Status da conta permite altera\u00C3\u00A7\u00C3\u00A3o de Limites, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="permiteEmitirNovaViaCartao">Par\u00C3\u00A2metro que define se o Status da conta permite solicitar uma nova via de Cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="permiteFazerTransferencia">Par\u00C3\u00A2metro que define se o Status da conta permite originar Transfer\u00C3\u00AAncias de Cr\u00C3\u00A9dito para outras Contas do mesmo Emissor ou para uma Conta Banc\u00C3\u00A1ria, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="permiteReceberTransferencia">Par\u00C3\u00A2metro que define se o Status da conta permite  receber Transfer\u00C3\u00AAncias de Cr\u00C3\u00A9dito originadas de outras Contas do mesmo emissor, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="permiteCriarAcordoCobranca">Par\u00C3\u00A2metro que define se o Status da conta permite ter um Acordo de Cobran\u00C3\u00A7a de D\u00C3\u00ADvida criado para ela, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="permiteAtribuirComoBloqueio">Par\u00C3\u00A2metro que define se o Status da conta permite ser atribu\u00C3\u00ADdo para Bloquear temporariamente uma Conta, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="permiteDesbloquear">Par\u00C3\u00A2metro que define se o Status da conta permite ser desbloqueada, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="permiteAtribuirComoCancelamento">Par\u00C3\u00A2metro que define se o Status da conta permite ser atribu\u00C3\u00ADdo para realizar o cancelamento definitivo de uma conta, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <returns>PageStatusContaResponse</returns>
        public PageStatusContaResponse ListarUsingGET30 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteAlterarVencimento = null, int? permiteAlterarLimite = null, int? permiteEmitirNovaViaCartao = null, int? permiteFazerTransferencia = null, int? permiteReceberTransferencia = null, int? permiteCriarAcordoCobranca = null, int? permiteAtribuirComoBloqueio = null, int? permiteDesbloquear = null, int? permiteAtribuirComoCancelamento = null)
        {
             ApiResponse<PageStatusContaResponse> localVarResponse = ListarUsingGET30WithHttpInfo(sort, page, limit, id, nome, permiteAlterarVencimento, permiteAlterarLimite, permiteEmitirNovaViaCartao, permiteFazerTransferencia, permiteReceberTransferencia, permiteCriarAcordoCobranca, permiteAtribuirComoBloqueio, permiteDesbloquear, permiteAtribuirComoCancelamento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Status Contas cadastrados para o Emissor Este m\u00C3\u00A9todo permite que sejam listados os Status Contas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id). (optional)</param> 
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status da Conta. (optional)</param> 
        /// <param name="permiteAlterarVencimento">Par\u00C3\u00A2metro que define se o Status da conta permite a solicita\u00C3\u00A7\u00C3\u00A3o da altera\u00C3\u00A7\u00C3\u00A3o do Dia para Vencimento das Faturas, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="permiteAlterarLimite">Par\u00C3\u00A2metro que define se o Status da conta permite altera\u00C3\u00A7\u00C3\u00A3o de Limites, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="permiteEmitirNovaViaCartao">Par\u00C3\u00A2metro que define se o Status da conta permite solicitar uma nova via de Cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="permiteFazerTransferencia">Par\u00C3\u00A2metro que define se o Status da conta permite originar Transfer\u00C3\u00AAncias de Cr\u00C3\u00A9dito para outras Contas do mesmo Emissor ou para uma Conta Banc\u00C3\u00A1ria, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="permiteReceberTransferencia">Par\u00C3\u00A2metro que define se o Status da conta permite  receber Transfer\u00C3\u00AAncias de Cr\u00C3\u00A9dito originadas de outras Contas do mesmo emissor, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="permiteCriarAcordoCobranca">Par\u00C3\u00A2metro que define se o Status da conta permite ter um Acordo de Cobran\u00C3\u00A7a de D\u00C3\u00ADvida criado para ela, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="permiteAtribuirComoBloqueio">Par\u00C3\u00A2metro que define se o Status da conta permite ser atribu\u00C3\u00ADdo para Bloquear temporariamente uma Conta, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="permiteDesbloquear">Par\u00C3\u00A2metro que define se o Status da conta permite ser desbloqueada, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="permiteAtribuirComoCancelamento">Par\u00C3\u00A2metro que define se o Status da conta permite ser atribu\u00C3\u00ADdo para realizar o cancelamento definitivo de uma conta, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <returns>ApiResponse of PageStatusContaResponse</returns>
        public ApiResponse< PageStatusContaResponse > ListarUsingGET30WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteAlterarVencimento = null, int? permiteAlterarLimite = null, int? permiteEmitirNovaViaCartao = null, int? permiteFazerTransferencia = null, int? permiteReceberTransferencia = null, int? permiteCriarAcordoCobranca = null, int? permiteAtribuirComoBloqueio = null, int? permiteDesbloquear = null, int? permiteAtribuirComoCancelamento = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET30: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET30: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageStatusContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusContaResponse)));
            
        }

        
        /// <summary>
        /// Lista os Status Contas cadastrados para o Emissor Este m\u00C3\u00A9todo permite que sejam listados os Status Contas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id). (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status da Conta. (optional)</param>
        /// <param name="permiteAlterarVencimento">Par\u00C3\u00A2metro que define se o Status da conta permite a solicita\u00C3\u00A7\u00C3\u00A3o da altera\u00C3\u00A7\u00C3\u00A3o do Dia para Vencimento das Faturas, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteAlterarLimite">Par\u00C3\u00A2metro que define se o Status da conta permite altera\u00C3\u00A7\u00C3\u00A3o de Limites, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteEmitirNovaViaCartao">Par\u00C3\u00A2metro que define se o Status da conta permite solicitar uma nova via de Cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteFazerTransferencia">Par\u00C3\u00A2metro que define se o Status da conta permite originar Transfer\u00C3\u00AAncias de Cr\u00C3\u00A9dito para outras Contas do mesmo Emissor ou para uma Conta Banc\u00C3\u00A1ria, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteReceberTransferencia">Par\u00C3\u00A2metro que define se o Status da conta permite  receber Transfer\u00C3\u00AAncias de Cr\u00C3\u00A9dito originadas de outras Contas do mesmo emissor, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteCriarAcordoCobranca">Par\u00C3\u00A2metro que define se o Status da conta permite ter um Acordo de Cobran\u00C3\u00A7a de D\u00C3\u00ADvida criado para ela, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Par\u00C3\u00A2metro que define se o Status da conta permite ser atribu\u00C3\u00ADdo para Bloquear temporariamente uma Conta, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteDesbloquear">Par\u00C3\u00A2metro que define se o Status da conta permite ser desbloqueada, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Par\u00C3\u00A2metro que define se o Status da conta permite ser atribu\u00C3\u00ADdo para realizar o cancelamento definitivo de uma conta, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <returns>Task of PageStatusContaResponse</returns>
        public async System.Threading.Tasks.Task<PageStatusContaResponse> ListarUsingGET30Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteAlterarVencimento = null, int? permiteAlterarLimite = null, int? permiteEmitirNovaViaCartao = null, int? permiteFazerTransferencia = null, int? permiteReceberTransferencia = null, int? permiteCriarAcordoCobranca = null, int? permiteAtribuirComoBloqueio = null, int? permiteDesbloquear = null, int? permiteAtribuirComoCancelamento = null)
        {
             ApiResponse<PageStatusContaResponse> localVarResponse = await ListarUsingGET30AsyncWithHttpInfo(sort, page, limit, id, nome, permiteAlterarVencimento, permiteAlterarLimite, permiteEmitirNovaViaCartao, permiteFazerTransferencia, permiteReceberTransferencia, permiteCriarAcordoCobranca, permiteAtribuirComoBloqueio, permiteDesbloquear, permiteAtribuirComoCancelamento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Status Contas cadastrados para o Emissor Este m\u00C3\u00A9todo permite que sejam listados os Status Contas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id). (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status da Conta. (optional)</param>
        /// <param name="permiteAlterarVencimento">Par\u00C3\u00A2metro que define se o Status da conta permite a solicita\u00C3\u00A7\u00C3\u00A3o da altera\u00C3\u00A7\u00C3\u00A3o do Dia para Vencimento das Faturas, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteAlterarLimite">Par\u00C3\u00A2metro que define se o Status da conta permite altera\u00C3\u00A7\u00C3\u00A3o de Limites, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteEmitirNovaViaCartao">Par\u00C3\u00A2metro que define se o Status da conta permite solicitar uma nova via de Cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteFazerTransferencia">Par\u00C3\u00A2metro que define se o Status da conta permite originar Transfer\u00C3\u00AAncias de Cr\u00C3\u00A9dito para outras Contas do mesmo Emissor ou para uma Conta Banc\u00C3\u00A1ria, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteReceberTransferencia">Par\u00C3\u00A2metro que define se o Status da conta permite  receber Transfer\u00C3\u00AAncias de Cr\u00C3\u00A9dito originadas de outras Contas do mesmo emissor, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteCriarAcordoCobranca">Par\u00C3\u00A2metro que define se o Status da conta permite ter um Acordo de Cobran\u00C3\u00A7a de D\u00C3\u00ADvida criado para ela, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Par\u00C3\u00A2metro que define se o Status da conta permite ser atribu\u00C3\u00ADdo para Bloquear temporariamente uma Conta, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteDesbloquear">Par\u00C3\u00A2metro que define se o Status da conta permite ser desbloqueada, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Par\u00C3\u00A2metro que define se o Status da conta permite ser atribu\u00C3\u00ADdo para realizar o cancelamento definitivo de uma conta, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageStatusContaResponse>> ListarUsingGET30AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteAlterarVencimento = null, int? permiteAlterarLimite = null, int? permiteEmitirNovaViaCartao = null, int? permiteFazerTransferencia = null, int? permiteReceberTransferencia = null, int? permiteCriarAcordoCobranca = null, int? permiteAtribuirComoBloqueio = null, int? permiteDesbloquear = null, int? permiteAtribuirComoCancelamento = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET30: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET30: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageStatusContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusContaResponse)));
            
        }
        
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status Impress\u00C3\u00A3o Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Status Impress\u00C3\u00A3o que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param> 
        /// <param name="nome">Nome do status impress\u00C3\u00A3o (optional)</param> 
        /// <returns>PageStatusImpressaoResponse</returns>
        public PageStatusImpressaoResponse ListarUsingGET31 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageStatusImpressaoResponse> localVarResponse = ListarUsingGET31WithHttpInfo(sort, page, limit, id, nome);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status Impress\u00C3\u00A3o Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Status Impress\u00C3\u00A3o que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param> 
        /// <param name="nome">Nome do status impress\u00C3\u00A3o (optional)</param> 
        /// <returns>ApiResponse of PageStatusImpressaoResponse</returns>
        public ApiResponse< PageStatusImpressaoResponse > ListarUsingGET31WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET31: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET31: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageStatusImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusImpressaoResponse)));
            
        }

        
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status Impress\u00C3\u00A3o Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Status Impress\u00C3\u00A3o que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="nome">Nome do status impress\u00C3\u00A3o (optional)</param>
        /// <returns>Task of PageStatusImpressaoResponse</returns>
        public async System.Threading.Tasks.Task<PageStatusImpressaoResponse> ListarUsingGET31Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageStatusImpressaoResponse> localVarResponse = await ListarUsingGET31AsyncWithHttpInfo(sort, page, limit, id, nome);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status Impress\u00C3\u00A3o Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Status Impress\u00C3\u00A3o que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="nome">Nome do status impress\u00C3\u00A3o (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusImpressaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageStatusImpressaoResponse>> ListarUsingGET31AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET31: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET31: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageStatusImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusImpressaoResponse)));
            
        }
        
    }
    
}
