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
        /// Realiza a altera\u00E7\u00E3o de um est\u00E1gio de cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Esta m\u00E9todo permite que seja alterado o est\u00E1gio do cart\u00E3o para um outro informado na requisi\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="update">C\u00F3digo de identifica\u00E7\u00E3o de um est\u00E1gio de cartao (est\u00E1gio)</param>
        /// <returns>CartaoResponse</returns>
        CartaoResponse AlterarEstagio (long? id, EstagioCartaoUpdate update);
  
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o de um est\u00E1gio de cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Esta m\u00E9todo permite que seja alterado o est\u00E1gio do cart\u00E3o para um outro informado na requisi\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="update">C\u00F3digo de identifica\u00E7\u00E3o de um est\u00E1gio de cartao (est\u00E1gio)</param>
        /// <returns>ApiResponse of CartaoResponse</returns>
        ApiResponse<CartaoResponse> AlterarEstagioWithHttpInfo (long? id, EstagioCartaoUpdate update);
        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o da senha de um Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que o portador de um determinado cart\u00E3o possa definir uma senha a sua escolha
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="senha">Senha para ser cadastrada ou alterada</param>
        /// <returns>string</returns>
        string AlterarSenha (long? id, string senha);
  
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o da senha de um Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que o portador de um determinado cart\u00E3o possa definir uma senha a sua escolha
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="senha">Senha para ser cadastrada ou alterada</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> AlterarSenhaWithHttpInfo (long? id, string senha);
        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o do Status de Impress\u00E3o do Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que uma Aplica\u00E7\u00E3o que realize a impress\u00E3o de cart\u00F5es possa indicar que um determinado idCartao fora impresso ou est\u00E1 em processo de impress\u00E3o. Para isso, basta informar o respectivo c\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id) que deseja ter seu um determinado id_status_impressao atribu\u00EDdo a ele. Por padr\u00E3o, cart\u00F5es provis\u00F3rios ou que j\u00E1 tenham sido inclu\u00EDdos em um arquivo para impress\u00E3o via gr\u00E1fica ter\u00E3o esta requisi\u00E7\u00E3o negada, se utilizada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="idStatusImpressao">C\u00F3digo de Identifica\u00E7\u00E3o do Status Impress\u00E3o (Id)</param>
        /// <returns>HistoricoImpressaoCartaoResponse</returns>
        HistoricoImpressaoCartaoResponse AlterarStatusImpressao (long? id, long? idStatusImpressao);
  
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o do Status de Impress\u00E3o do Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que uma Aplica\u00E7\u00E3o que realize a impress\u00E3o de cart\u00F5es possa indicar que um determinado idCartao fora impresso ou est\u00E1 em processo de impress\u00E3o. Para isso, basta informar o respectivo c\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id) que deseja ter seu um determinado id_status_impressao atribu\u00EDdo a ele. Por padr\u00E3o, cart\u00F5es provis\u00F3rios ou que j\u00E1 tenham sido inclu\u00EDdos em um arquivo para impress\u00E3o via gr\u00E1fica ter\u00E3o esta requisi\u00E7\u00E3o negada, se utilizada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="idStatusImpressao">C\u00F3digo de Identifica\u00E7\u00E3o do Status Impress\u00E3o (Id)</param>
        /// <returns>ApiResponse of HistoricoImpressaoCartaoResponse</returns>
        ApiResponse<HistoricoImpressaoCartaoResponse> AlterarStatusImpressaoWithHttpInfo (long? id, long? idStatusImpressao);
        
        /// <summary>
        /// Realiza a atribui\u00E7\u00E3o de um cart\u00E3o pr\u00E9-pago a uma pessoa
        /// </summary>
        /// <remarks>
        /// Esta m\u00E9todo permite que um cart\u00E3o pr\u00E9-pago impresso de forma avulsa e an\u00F4nimo seja atribu\u00EDdo a uma pessoa para que esta passe a ser a portadora titular dele
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="idPessoa">C\u00F3digo de identifica\u00E7\u00E3o de uma Pessoa (id)</param>
        /// <returns>CartaoResponse</returns>
        CartaoResponse AtribuirPessoa (long? id, long? idPessoa);
  
        /// <summary>
        /// Realiza a atribui\u00E7\u00E3o de um cart\u00E3o pr\u00E9-pago a uma pessoa
        /// </summary>
        /// <remarks>
        /// Esta m\u00E9todo permite que um cart\u00E3o pr\u00E9-pago impresso de forma avulsa e an\u00F4nimo seja atribu\u00EDdo a uma pessoa para que esta passe a ser a portadora titular dele
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="idPessoa">C\u00F3digo de identifica\u00E7\u00E3o de uma Pessoa (id)</param>
        /// <returns>ApiResponse of CartaoResponse</returns>
        ApiResponse<CartaoResponse> AtribuirPessoaWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// Realiza o bloqueio de um determinado Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite a realiza\u00E7\u00E3o do bloqueio (tempor\u00E1rio) ou do cancelamento (definitivo) de um determinado cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id). Para isso, \u00E9 preciso informar qual o motivo deste bloqueio que nada mais \u00E9 do que atribuir um novo StatusCartao para ele dentre as op\u00E7\u00F5es praticadas pelo emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="idStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Novo Status Cart\u00E3o</param>
        /// <param name="observacao">Texto informando uma observa\u00E7\u00E3o sobre o bloqueio</param>
        /// <returns>CartaoResponse</returns>
        CartaoResponse BloquearCartao (long? id, long? idStatus, string observacao);
  
        /// <summary>
        /// Realiza o bloqueio de um determinado Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite a realiza\u00E7\u00E3o do bloqueio (tempor\u00E1rio) ou do cancelamento (definitivo) de um determinado cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id). Para isso, \u00E9 preciso informar qual o motivo deste bloqueio que nada mais \u00E9 do que atribuir um novo StatusCartao para ele dentre as op\u00E7\u00F5es praticadas pelo emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="idStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Novo Status Cart\u00E3o</param>
        /// <param name="observacao">Texto informando uma observa\u00E7\u00E3o sobre o bloqueio</param>
        /// <returns>ApiResponse of CartaoResponse</returns>
        ApiResponse<CartaoResponse> BloquearCartaoWithHttpInfo (long? id, long? idStatus, string observacao);
        
        /// <summary>
        /// Realiza o cadastro da senha de um Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que o portador de um determinado cart\u00E3o possa definir uma senha a sua escolha
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="senha">Senha para ser cadastrada ou alterada</param>
        /// <returns>string</returns>
        string CadastrarSenha (long? id, string senha);
  
        /// <summary>
        /// Realiza o cadastro da senha de um Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que o portador de um determinado cart\u00E3o possa definir uma senha a sua escolha
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="senha">Senha para ser cadastrada ou alterada</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> CadastrarSenhaWithHttpInfo (long? id, string senha);
        
        /// <summary>
        /// Realiza o cancelamento de um determinado Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite a realiza\u00E7\u00E3o cancelamento de um determinado cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id). Para isso, \u00E9 preciso informar qual o motivo deste bloqueio que nada mais \u00E9 do que atribuir um novo StatusCartao para ele dentre as op\u00E7\u00F5es praticadas pelo emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="idStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Novo Status Cart\u00E3o</param>
        /// <param name="observacao">Texto informando uma observa\u00E7\u00E3o sobre o cancelamento</param>
        /// <returns>CartaoResponse</returns>
        CartaoResponse CancelarCartao (long? id, long? idStatus, string observacao);
  
        /// <summary>
        /// Realiza o cancelamento de um determinado Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite a realiza\u00E7\u00E3o cancelamento de um determinado cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id). Para isso, \u00E9 preciso informar qual o motivo deste bloqueio que nada mais \u00E9 do que atribuir um novo StatusCartao para ele dentre as op\u00E7\u00F5es praticadas pelo emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="idStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Novo Status Cart\u00E3o</param>
        /// <param name="observacao">Texto informando uma observa\u00E7\u00E3o sobre o cancelamento</param>
        /// <returns>ApiResponse of CartaoResponse</returns>
        ApiResponse<CartaoResponse> CancelarCartaoWithHttpInfo (long? id, long? idStatus, string observacao);
        
        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar as informa\u00E7\u00F5es b\u00E1sicas de um determinado Cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>CartaoDetalheResponse</returns>
        CartaoDetalheResponse ConsultarCartao (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar as informa\u00E7\u00F5es b\u00E1sicas de um determinado Cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>ApiResponse of CartaoDetalheResponse</returns>
        ApiResponse<CartaoDetalheResponse> ConsultarCartaoWithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar os dados de impress\u00E3o de um Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar os dados de impress\u00E3o de um cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <returns>DadosCartaoImpressaoResponse</returns>
        DadosCartaoImpressaoResponse ConsultarDadosImpressao (long? id);
  
        /// <summary>
        /// Consultar os dados de impress\u00E3o de um Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar os dados de impress\u00E3o de um cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <returns>ApiResponse of DadosCartaoImpressaoResponse</returns>
        ApiResponse<DadosCartaoImpressaoResponse> ConsultarDadosImpressaoWithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar Detalhes do Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja consultado os dados necessarios de um cart\u00E3o para executar servi\u00E7os de autoriza\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>DadosCartaoResponse</returns>
        DadosCartaoResponse ConsultarDadosReaisCartao (long? id);
  
        /// <summary>
        /// Consultar Detalhes do Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja consultado os dados necessarios de um cart\u00E3o para executar servi\u00E7os de autoriza\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>ApiResponse of DadosCartaoResponse</returns>
        ApiResponse<DadosCartaoResponse> ConsultarDadosReaisCartaoWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os limites do Portador do Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os Limites configurados para o Portador de um determinado Cart\u00E3o, seja ele o titular da conta ou um adicional, a partir do c\u00F3digo de identifica\u00E7\u00E3o do Cart\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>LimiteDisponibilidadeResponse</returns>
        LimiteDisponibilidadeResponse ConsultarLimitesDisponiveis (long? id);
  
        /// <summary>
        /// Apresenta os limites do Portador do Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os Limites configurados para o Portador de um determinado Cart\u00E3o, seja ele o titular da conta ou um adicional, a partir do c\u00F3digo de identifica\u00E7\u00E3o do Cart\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>ApiResponse of LimiteDisponibilidadeResponse</returns>
        ApiResponse<LimiteDisponibilidadeResponse> ConsultarLimitesDisponiveisWithHttpInfo (long? id);
        
        /// <summary>
        /// Permite consultar um determinado Lote de Cart\u00F5es Pr\u00E9-Pago
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os cart\u00F5es pr\u00E9-pagos existentes na base do emissor atrav\u00E9s do id do lote
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do lote de cart\u00F5es (id)</param>
        /// <returns>LoteCartoesPrePagosResponse</returns>
        LoteCartoesPrePagosResponse ConsultarLoteCartoesPrePagos (long? id);
  
        /// <summary>
        /// Permite consultar um determinado Lote de Cart\u00F5es Pr\u00E9-Pago
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os cart\u00F5es pr\u00E9-pagos existentes na base do emissor atrav\u00E9s do id do lote
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do lote de cart\u00F5es (id)</param>
        /// <returns>ApiResponse of LoteCartoesPrePagosResponse</returns>
        ApiResponse<LoteCartoesPrePagosResponse> ConsultarLoteCartoesPrePagosWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados do Portador do Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar as informa\u00E7\u00F5es do Portador de um determinado Cart\u00E3o a partir do c\u00F3digo de identifica\u00E7\u00E3o do Cart\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>PortadorResponse</returns>
        PortadorResponse ConsultarPortador (long? id);
  
        /// <summary>
        /// Apresenta os dados do Portador do Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar as informa\u00E7\u00F5es do Portador de um determinado Cart\u00E3o a partir do c\u00F3digo de identifica\u00E7\u00E3o do Cart\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>ApiResponse of PortadorResponse</returns>
        ApiResponse<PortadorResponse> ConsultarPortadorWithHttpInfo (long? id);
        
        /// <summary>
        /// Cadastrar cart\u00F5es MultiApp
        /// </summary>
        /// <remarks>
        /// Este recurso permite o cadastro de cart\u00F5es MultiApp
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartaoMultiAppPersist">cartaoMultiAppPersist</param>
        /// <returns>VinculoCartoesResponse</returns>
        VinculoCartoesResponse CriarCartoesMultiApp (CartaoMultiAppPersist cartaoMultiAppPersist);
  
        /// <summary>
        /// Cadastrar cart\u00F5es MultiApp
        /// </summary>
        /// <remarks>
        /// Este recurso permite o cadastro de cart\u00F5es MultiApp
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartaoMultiAppPersist">cartaoMultiAppPersist</param>
        /// <returns>ApiResponse of VinculoCartoesResponse</returns>
        ApiResponse<VinculoCartoesResponse> CriarCartoesMultiAppWithHttpInfo (CartaoMultiAppPersist cartaoMultiAppPersist);
        
        /// <summary>
        /// Realiza o desbloqueio de um determinado Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja desbloqueado um determinado cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>CartaoResponse</returns>
        CartaoResponse DesbloquearCartao (long? id);
  
        /// <summary>
        /// Realiza o desbloqueio de um determinado Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja desbloqueado um determinado cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>ApiResponse of CartaoResponse</returns>
        ApiResponse<CartaoResponse> DesbloquearCartaoWithHttpInfo (long? id);
        
        /// <summary>
        /// Permite gerar um novo Lote de Cart\u00F5es Pr\u00E9-Pago
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores gerem uma determinada quantidade de Cart\u00F5es Pr\u00E9-Pagos, de forma n\u00E3o nominal, os quais poder\u00E3o ser comercializados e posteriormente vinculados a um cliente que o adquirir. Para isso, al\u00E9m de definir quantos cart\u00F5es dever\u00E3o ser gerados, ser\u00E1 poss\u00EDvel definir qual a Origem Comercial, o Produto, o Tipo do Cart\u00E3o, a Imagem e o Endere\u00E7o para entrega dos Cart\u00F5es presentes no lote gerado. Por padr\u00E3o, todos os cart\u00F5es ser\u00E3o associados a um idPessoa fict\u00EDcio e receber\u00E1 um idConta \u00FAnico para cada um deles. Feito isso, os Cart\u00F5es gerados por esta opera\u00E7\u00E3o seguir\u00E3o os mesmos processos de impress\u00E3o via gr\u00E1fica previamente definidos entre o Emissor e a Conductor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idOrigemComercial">C\u00F3digo de Identifica\u00E7\u00E3o da Origem Comercial (id) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (optional)</param>
        /// <param name="idTipoCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Cart\u00E3o (id) (optional)</param>
        /// <param name="idImagem">C\u00F3digo de Identifica\u00E7\u00E3o da Imagem (id) (optional)</param>
        /// <param name="idEndereco">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id) (optional)</param>
        /// <param name="quantidadeCartoes">N\u00FAmero de cart\u00F5es existentes no Lote (optional)</param>
        /// <param name="identificadorExterno">N\u00FAmero de identifica\u00E7\u00E3o externo (utilizado pelo emissor) (optional)</param>
        /// <returns>LoteCartoesPrePagosResponse</returns>
        LoteCartoesPrePagosResponse GerarLoteCartoesPrePagos (long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string identificadorExterno = null);
  
        /// <summary>
        /// Permite gerar um novo Lote de Cart\u00F5es Pr\u00E9-Pago
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores gerem uma determinada quantidade de Cart\u00F5es Pr\u00E9-Pagos, de forma n\u00E3o nominal, os quais poder\u00E3o ser comercializados e posteriormente vinculados a um cliente que o adquirir. Para isso, al\u00E9m de definir quantos cart\u00F5es dever\u00E3o ser gerados, ser\u00E1 poss\u00EDvel definir qual a Origem Comercial, o Produto, o Tipo do Cart\u00E3o, a Imagem e o Endere\u00E7o para entrega dos Cart\u00F5es presentes no lote gerado. Por padr\u00E3o, todos os cart\u00F5es ser\u00E3o associados a um idPessoa fict\u00EDcio e receber\u00E1 um idConta \u00FAnico para cada um deles. Feito isso, os Cart\u00F5es gerados por esta opera\u00E7\u00E3o seguir\u00E3o os mesmos processos de impress\u00E3o via gr\u00E1fica previamente definidos entre o Emissor e a Conductor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idOrigemComercial">C\u00F3digo de Identifica\u00E7\u00E3o da Origem Comercial (id) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (optional)</param>
        /// <param name="idTipoCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Cart\u00E3o (id) (optional)</param>
        /// <param name="idImagem">C\u00F3digo de Identifica\u00E7\u00E3o da Imagem (id) (optional)</param>
        /// <param name="idEndereco">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id) (optional)</param>
        /// <param name="quantidadeCartoes">N\u00FAmero de cart\u00F5es existentes no Lote (optional)</param>
        /// <param name="identificadorExterno">N\u00FAmero de identifica\u00E7\u00E3o externo (utilizado pelo emissor) (optional)</param>
        /// <returns>ApiResponse of LoteCartoesPrePagosResponse</returns>
        ApiResponse<LoteCartoesPrePagosResponse> GerarLoteCartoesPrePagosWithHttpInfo (long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string identificadorExterno = null);
        
        /// <summary>
        /// Gerar uma nova via de Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores ou seus clientes possam solicitar a gera\u00E7\u00E3o de uma nova via de Cart\u00E3o que ser\u00E1 encaminhando para impress\u00E3o e postagem de acordo com os fluxos padr\u00F5es j\u00E1 definidos pelo emissor. Para isso, \u00E9 preciso que o cliente j\u00E1 possua um cart\u00E3o gerado e informar o C\u00F3digo de Identifica\u00E7\u00E3o deste (idCartao) para que ele possa utilizar esta opera\u00E7\u00E3o. Assim, esta funcionalidade se aplica apenas para a gera\u00E7\u00E3o de cart\u00F5es f\u00EDsicos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="idImagem">C\u00F3digo de Identifica\u00E7\u00E3o da imagem do cart\u00E3o (id) (optional)</param>
        /// <returns>CartaoImpressaoResponse</returns>
        CartaoImpressaoResponse GerarNovaViaCartao (long? id, long? idImagem = null);
  
        /// <summary>
        /// Gerar uma nova via de Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores ou seus clientes possam solicitar a gera\u00E7\u00E3o de uma nova via de Cart\u00E3o que ser\u00E1 encaminhando para impress\u00E3o e postagem de acordo com os fluxos padr\u00F5es j\u00E1 definidos pelo emissor. Para isso, \u00E9 preciso que o cliente j\u00E1 possua um cart\u00E3o gerado e informar o C\u00F3digo de Identifica\u00E7\u00E3o deste (idCartao) para que ele possa utilizar esta opera\u00E7\u00E3o. Assim, esta funcionalidade se aplica apenas para a gera\u00E7\u00E3o de cart\u00F5es f\u00EDsicos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="idImagem">C\u00F3digo de Identifica\u00E7\u00E3o da imagem do cart\u00E3o (id) (optional)</param>
        /// <returns>ApiResponse of CartaoImpressaoResponse</returns>
        ApiResponse<CartaoImpressaoResponse> GerarNovaViaCartaoWithHttpInfo (long? id, long? idImagem = null);
        
        /// <summary>
        /// Gerar nova via de cart\u00E3o m\u00FAltiplo
        /// </summary>
        /// <remarks>
        /// Este recurso permite gerar uma nova via de cart\u00E3o m\u00FAltiplo (com dois produtos relacionados)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>CartaoMultiAppImpressaoResponse</returns>
        CartaoMultiAppImpressaoResponse GerarNovaViaCartaoMultiApp (long? id);
  
        /// <summary>
        /// Gerar nova via de cart\u00E3o m\u00FAltiplo
        /// </summary>
        /// <remarks>
        /// Este recurso permite gerar uma nova via de cart\u00E3o m\u00FAltiplo (com dois produtos relacionados)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>ApiResponse of CartaoMultiAppImpressaoResponse</returns>
        ApiResponse<CartaoMultiAppImpressaoResponse> GerarNovaViaCartaoMultiAppWithHttpInfo (long? id);
        
        /// <summary>
        /// Adiciona tarifa de ajuste da segunda via do cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite adicionar tar\u00EDfa de ajuste pela emiss\u00E3o da segunda via do cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <returns>Object</returns>
        Object LancarTarifaReemissao (long? id);
  
        /// <summary>
        /// Adiciona tarifa de ajuste da segunda via do cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite adicionar tar\u00EDfa de ajuste pela emiss\u00E3o da segunda via do cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> LancarTarifaReemissaoWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista os Cart\u00F5es gerados pelo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os cart\u00F5es existentes na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Status do Cart\u00E3o (id) (optional)</param>
        /// <param name="idEstagioCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Est\u00E1gio de Impress\u00E3o do Cart\u00E3o (id) (optional)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta a qual o cart\u00E3o pertence (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o cart\u00E3o pertence (id) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto a qual o cart\u00E3o pertence (id) (optional)</param>
        /// <param name="tipoPortador">Mostre o tipo do titular do cart\u00E3o, sendo: (&#39;T&#39;: titular, &#39;A&#39;: adicional) (optional)</param>
        /// <param name="numeroCartao">Apresenta o n\u00FAmero do cart\u00E3o (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome impresso no cart\u00E3o (optional)</param>
        /// <param name="dataGeracao">Apresenta a data em que o cart\u00E3o foi gerado (optional)</param>
        /// <param name="dataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00E3o fora aplicado, quando houver (optional)</param>
        /// <param name="dataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00E3o fora aplicado, quando houver (optional)</param>
        /// <param name="dataValidade">Mostrar a data da expira\u00E7\u00E3o do cart\u00E3o no formato aaaa-MM, quando houver (optional)</param>
        /// <param name="dataImpressao">Apresenta a data em que o cart\u00E3o fora impresso, caso impress\u00E3o em loja, ou a data em que ele fora inclu\u00EDdo no arquivo para impress\u00E3o via gr\u00E1fica (optional)</param>
        /// <param name="arquivoImpressao">Apresenta o nome do arquivo onde o cart\u00E3o fora inclu\u00EDdo para impress\u00E3o por uma gr\u00E1fica, quando houver (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00E3o fora impresso na Origem Comercial (optional)</param>
        /// <param name="flagProvisorio">Quando ativa, indica que o cart\u00E3o \u00E9 provis\u00F3rio. Ou seja, \u00E9 um cart\u00E3o para uso tempor\u00E1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00E3o definitivo (optional)</param>
        /// <param name="codigoDesbloqueio">Apresenta um c\u00F3digo espec\u00EDfico para ser utilizado como vari\u00E1vel no processo de desbloqueio do cart\u00E3o para emissores que querem usar esta funcionalidade (optional)</param>
        /// <param name="sequencialCartao">N\u00FAmero sequencial do cart\u00E3o (optional)</param>
        /// <param name="identificadorExterno">Identificador externo do cart\u00E3o (optional)</param>
        /// <returns>PageCartaoResponse</returns>
        PageCartaoResponse ListarCartoes (List<string> sort = null, int? page = null, int? limit = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? sequencialCartao = null, long? identificadorExterno = null);
  
        /// <summary>
        /// Lista os Cart\u00F5es gerados pelo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os cart\u00F5es existentes na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Status do Cart\u00E3o (id) (optional)</param>
        /// <param name="idEstagioCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Est\u00E1gio de Impress\u00E3o do Cart\u00E3o (id) (optional)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta a qual o cart\u00E3o pertence (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o cart\u00E3o pertence (id) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto a qual o cart\u00E3o pertence (id) (optional)</param>
        /// <param name="tipoPortador">Mostre o tipo do titular do cart\u00E3o, sendo: (&#39;T&#39;: titular, &#39;A&#39;: adicional) (optional)</param>
        /// <param name="numeroCartao">Apresenta o n\u00FAmero do cart\u00E3o (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome impresso no cart\u00E3o (optional)</param>
        /// <param name="dataGeracao">Apresenta a data em que o cart\u00E3o foi gerado (optional)</param>
        /// <param name="dataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00E3o fora aplicado, quando houver (optional)</param>
        /// <param name="dataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00E3o fora aplicado, quando houver (optional)</param>
        /// <param name="dataValidade">Mostrar a data da expira\u00E7\u00E3o do cart\u00E3o no formato aaaa-MM, quando houver (optional)</param>
        /// <param name="dataImpressao">Apresenta a data em que o cart\u00E3o fora impresso, caso impress\u00E3o em loja, ou a data em que ele fora inclu\u00EDdo no arquivo para impress\u00E3o via gr\u00E1fica (optional)</param>
        /// <param name="arquivoImpressao">Apresenta o nome do arquivo onde o cart\u00E3o fora inclu\u00EDdo para impress\u00E3o por uma gr\u00E1fica, quando houver (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00E3o fora impresso na Origem Comercial (optional)</param>
        /// <param name="flagProvisorio">Quando ativa, indica que o cart\u00E3o \u00E9 provis\u00F3rio. Ou seja, \u00E9 um cart\u00E3o para uso tempor\u00E1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00E3o definitivo (optional)</param>
        /// <param name="codigoDesbloqueio">Apresenta um c\u00F3digo espec\u00EDfico para ser utilizado como vari\u00E1vel no processo de desbloqueio do cart\u00E3o para emissores que querem usar esta funcionalidade (optional)</param>
        /// <param name="sequencialCartao">N\u00FAmero sequencial do cart\u00E3o (optional)</param>
        /// <param name="identificadorExterno">Identificador externo do cart\u00E3o (optional)</param>
        /// <returns>ApiResponse of PageCartaoResponse</returns>
        ApiResponse<PageCartaoResponse> ListarCartoesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? sequencialCartao = null, long? identificadorExterno = null);
        
        /// <summary>
        /// Permite listar os Lotes de Cart\u00F5es Pr\u00E9-Pago
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os cart\u00F5es pr\u00E9-pagos existentes na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idOrigemComercial">C\u00F3digo de Identifica\u00E7\u00E3o da Origem Comercial (id) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (optional)</param>
        /// <param name="idTipoCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Cart\u00E3o (id) (optional)</param>
        /// <param name="idImagem">C\u00F3digo de Identifica\u00E7\u00E3o da Imagem (id) (optional)</param>
        /// <param name="idEndereco">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id) (optional)</param>
        /// <param name="quantidadeCartoes">N\u00FAmero de cart\u00F5es existentes no Lote (optional)</param>
        /// <param name="dataCadastro">Data de Cadastro do Lote de Cart\u00F5es N\u00E3o Nominais (optional)</param>
        /// <param name="usuarioCadastro">Nome do Usu\u00E1rio que criou o Lote (optional)</param>
        /// <param name="statusProcessamento">Indica o Status de Processamento do Lote (optional)</param>
        /// <param name="identificadorExterno">N\u00FAmero de identifica\u00E7\u00E3o externo (utilizado pelo emissor) (optional)</param>
        /// <returns>PageLoteCartoesPrePagosResponse</returns>
        PageLoteCartoesPrePagosResponse ListarLotesCartoesPrePagos (List<string> sort = null, int? page = null, int? limit = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string dataCadastro = null, string usuarioCadastro = null, int? statusProcessamento = null, string identificadorExterno = null);
  
        /// <summary>
        /// Permite listar os Lotes de Cart\u00F5es Pr\u00E9-Pago
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os cart\u00F5es pr\u00E9-pagos existentes na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idOrigemComercial">C\u00F3digo de Identifica\u00E7\u00E3o da Origem Comercial (id) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (optional)</param>
        /// <param name="idTipoCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Cart\u00E3o (id) (optional)</param>
        /// <param name="idImagem">C\u00F3digo de Identifica\u00E7\u00E3o da Imagem (id) (optional)</param>
        /// <param name="idEndereco">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id) (optional)</param>
        /// <param name="quantidadeCartoes">N\u00FAmero de cart\u00F5es existentes no Lote (optional)</param>
        /// <param name="dataCadastro">Data de Cadastro do Lote de Cart\u00F5es N\u00E3o Nominais (optional)</param>
        /// <param name="usuarioCadastro">Nome do Usu\u00E1rio que criou o Lote (optional)</param>
        /// <param name="statusProcessamento">Indica o Status de Processamento do Lote (optional)</param>
        /// <param name="identificadorExterno">N\u00FAmero de identifica\u00E7\u00E3o externo (utilizado pelo emissor) (optional)</param>
        /// <returns>ApiResponse of PageLoteCartoesPrePagosResponse</returns>
        ApiResponse<PageLoteCartoesPrePagosResponse> ListarLotesCartoesPrePagosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string dataCadastro = null, string usuarioCadastro = null, int? statusProcessamento = null, string identificadorExterno = null);
        
        /// <summary>
        /// Realiza a reativa\u00E7\u00E3o de um determinado Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite a realiza\u00E7\u00E3o da reativa\u00E7\u00E3o de um determinado cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>CartaoResponse</returns>
        CartaoResponse ReativarCartao (long? id);
  
        /// <summary>
        /// Realiza a reativa\u00E7\u00E3o de um determinado Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite a realiza\u00E7\u00E3o da reativa\u00E7\u00E3o de um determinado cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>ApiResponse of CartaoResponse</returns>
        ApiResponse<CartaoResponse> ReativarCartaoWithHttpInfo (long? id);
        
        /// <summary>
        /// Realiza o desbloqueio de um cart\u00E3o bloqueado por tentativas de senha incorretas
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja desbloqueado um determinado cart\u00E3o que foi bloqueado por tentativas de senha incorretas, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>CartaoResponse</returns>
        CartaoResponse ResetarTentativasSenhaIncorreta (long? id);
  
        /// <summary>
        /// Realiza o desbloqueio de um cart\u00E3o bloqueado por tentativas de senha incorretas
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja desbloqueado um determinado cart\u00E3o que foi bloqueado por tentativas de senha incorretas, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>ApiResponse of CartaoResponse</returns>
        ApiResponse<CartaoResponse> ResetarTentativasSenhaIncorretaWithHttpInfo (long? id);
        
        /// <summary>
        /// Validar CVV do cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite a valida\u00E7\u00E3o do cvv de um cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="validaCVV">validaCVV</param>
        /// <returns>string</returns>
        string ValidarCVV (long? id, ValidaCVVRequest validaCVV);
  
        /// <summary>
        /// Validar CVV do cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite a valida\u00E7\u00E3o do cvv de um cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="validaCVV">validaCVV</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ValidarCVVWithHttpInfo (long? id, ValidaCVVRequest validaCVV);
        
        /// <summary>
        /// Permite validar um Cart\u00E3o com bandeira Mastercard a partir do de55
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores validem o DE55 gerado a partir da leitura de um chip EMV de um Cart\u00E3o com bandeira Mastercard a fim de verificar a sua autenticidade. A utiliza\u00E7\u00E3o desde m\u00E9todo tem diversas aplica\u00E7\u00F5es, sendo a principal delas a de Identifica\u00E7\u00E3o Positiva do Cart\u00E3o antes de permitir que o portador realize transa\u00E7\u00F5es diversas, como as de compra e saque na modalidade d\u00E9bito em conta corrente, dentre outras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00FAmero do cart\u00E3o a ser validado</param>
        /// <param name="criptograma">Criptograma do cart\u00E3o no formato de55</param>
        /// <returns>ValidaCartaoResponse</returns>
        ValidaCartaoResponse ValidarDE55Mastercard (string numeroCartao, string criptograma);
  
        /// <summary>
        /// Permite validar um Cart\u00E3o com bandeira Mastercard a partir do de55
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores validem o DE55 gerado a partir da leitura de um chip EMV de um Cart\u00E3o com bandeira Mastercard a fim de verificar a sua autenticidade. A utiliza\u00E7\u00E3o desde m\u00E9todo tem diversas aplica\u00E7\u00F5es, sendo a principal delas a de Identifica\u00E7\u00E3o Positiva do Cart\u00E3o antes de permitir que o portador realize transa\u00E7\u00F5es diversas, como as de compra e saque na modalidade d\u00E9bito em conta corrente, dentre outras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00FAmero do cart\u00E3o a ser validado</param>
        /// <param name="criptograma">Criptograma do cart\u00E3o no formato de55</param>
        /// <returns>ApiResponse of ValidaCartaoResponse</returns>
        ApiResponse<ValidaCartaoResponse> ValidarDE55MastercardWithHttpInfo (string numeroCartao, string criptograma);
        
        /// <summary>
        /// Permite validar os dados impressos em um cart\u00E3o bandeirado
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00E3o a partir do envio dos dados sens\u00EDveis impressos nele. A utiliza\u00E7\u00E3o desde m\u00E9todo tem diversas aplica\u00E7\u00F5es, sendo a principal delas a de Identifica\u00E7\u00E3o Positiva do Cart\u00E3o para a realiza\u00E7\u00E3o de transa\u00E7\u00F5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00F4nico (URA), dentre outras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00FAmero do cart\u00E3o a ser validado</param>
        /// <param name="nomePortador">Nome do portador do cart\u00E3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00E3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00F3digo de seguran\u00E7a do cart\u00E3o com tr\u00EAs n\u00FAmeros</param>
        /// <returns>ValidaCartaoResponse</returns>
        ValidaCartaoResponse ValidarDadosCartaoBandeirado (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);
  
        /// <summary>
        /// Permite validar os dados impressos em um cart\u00E3o bandeirado
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00E3o a partir do envio dos dados sens\u00EDveis impressos nele. A utiliza\u00E7\u00E3o desde m\u00E9todo tem diversas aplica\u00E7\u00F5es, sendo a principal delas a de Identifica\u00E7\u00E3o Positiva do Cart\u00E3o para a realiza\u00E7\u00E3o de transa\u00E7\u00F5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00F4nico (URA), dentre outras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00FAmero do cart\u00E3o a ser validado</param>
        /// <param name="nomePortador">Nome do portador do cart\u00E3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00E3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00F3digo de seguran\u00E7a do cart\u00E3o com tr\u00EAs n\u00FAmeros</param>
        /// <returns>ApiResponse of ValidaCartaoResponse</returns>
        ApiResponse<ValidaCartaoResponse> ValidarDadosCartaoBandeiradoWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);
        
        /// <summary>
        /// Permite validar os dados impressos de um cartao n\u00E3o bandeirado
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00E3o a partir do envio dos dados sens\u00EDveis impressos nele. A utiliza\u00E7\u00E3o desde m\u00E9todo tem diversas aplica\u00E7\u00F5es, sendo a principal delas a de Identifica\u00E7\u00E3o Positiva do Cart\u00E3o para a realiza\u00E7\u00E3o de transa\u00E7\u00F5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00F4nico (URA), dentre outras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00FAmero do cart\u00E3o a ser validado</param>
        /// <param name="nomePortador">Nome do portador do cart\u00E3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00E3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00F3digo de seguran\u00E7a do cart\u00E3o com tr\u00EAs n\u00FAmeros</param>
        /// <returns>ValidaCartaoResponse</returns>
        ValidaCartaoResponse ValidarDadosCartaoPrivate (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);
  
        /// <summary>
        /// Permite validar os dados impressos de um cartao n\u00E3o bandeirado
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00E3o a partir do envio dos dados sens\u00EDveis impressos nele. A utiliza\u00E7\u00E3o desde m\u00E9todo tem diversas aplica\u00E7\u00F5es, sendo a principal delas a de Identifica\u00E7\u00E3o Positiva do Cart\u00E3o para a realiza\u00E7\u00E3o de transa\u00E7\u00F5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00F4nico (URA), dentre outras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00FAmero do cart\u00E3o a ser validado</param>
        /// <param name="nomePortador">Nome do portador do cart\u00E3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00E3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00F3digo de seguran\u00E7a do cart\u00E3o com tr\u00EAs n\u00FAmeros</param>
        /// <returns>ApiResponse of ValidaCartaoResponse</returns>
        ApiResponse<ValidaCartaoResponse> ValidarDadosCartaoPrivateWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);
        
        /// <summary>
        /// Permite validar a senha de um Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir validar que a senha informada pelo portador de um determinado cart\u00E3o est\u00E1 correta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="senhaDTO">Representa o DTO de senha para usu\u00E1rio</param>
        /// <returns>ValidaSenhaCartaoResponse</returns>
        ValidaSenhaCartaoResponse ValidarSenha (long? id, SenhaDTO senhaDTO);
  
        /// <summary>
        /// Permite validar a senha de um Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir validar que a senha informada pelo portador de um determinado cart\u00E3o est\u00E1 correta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="senhaDTO">Representa o DTO de senha para usu\u00E1rio</param>
        /// <returns>ApiResponse of ValidaSenhaCartaoResponse</returns>
        ApiResponse<ValidaSenhaCartaoResponse> ValidarSenhaWithHttpInfo (long? id, SenhaDTO senhaDTO);
        
        /// <summary>
        /// Permite validar um Cart\u00E3o Bandeirado a partir da Tarja
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00E3o a partir da leitura da tarja magn\u00E9tica do mesmo. A utiliza\u00E7\u00E3o desde m\u00E9todo tem diversas aplica\u00E7\u00F5es, sendo a principal delas a de Identifica\u00E7\u00E3o Positiva do Cart\u00E3o antes de permitir que o portador realize transa\u00E7\u00F5es diversas, como as de compra e saque na modalidade d\u00E9bito em conta corrente, dentre outras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00FAmero do cart\u00E3o a ser validado</param>
        /// <param name="trilha1">Trilha 1 do cart\u00E3o a ser validado</param>
        /// <param name="trilha2">Trilha 2 do cart\u00E3o a ser validado</param>
        /// <returns>ValidaCartaoResponse</returns>
        ValidaCartaoResponse ValidarTarja (string numeroCartao, string trilha1, string trilha2);
  
        /// <summary>
        /// Permite validar um Cart\u00E3o Bandeirado a partir da Tarja
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00E3o a partir da leitura da tarja magn\u00E9tica do mesmo. A utiliza\u00E7\u00E3o desde m\u00E9todo tem diversas aplica\u00E7\u00F5es, sendo a principal delas a de Identifica\u00E7\u00E3o Positiva do Cart\u00E3o antes de permitir que o portador realize transa\u00E7\u00F5es diversas, como as de compra e saque na modalidade d\u00E9bito em conta corrente, dentre outras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00FAmero do cart\u00E3o a ser validado</param>
        /// <param name="trilha1">Trilha 1 do cart\u00E3o a ser validado</param>
        /// <param name="trilha2">Trilha 2 do cart\u00E3o a ser validado</param>
        /// <returns>ApiResponse of ValidaCartaoResponse</returns>
        ApiResponse<ValidaCartaoResponse> ValidarTarjaWithHttpInfo (string numeroCartao, string trilha1, string trilha2);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o de um est\u00E1gio de cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Esta m\u00E9todo permite que seja alterado o est\u00E1gio do cart\u00E3o para um outro informado na requisi\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="update">C\u00F3digo de identifica\u00E7\u00E3o de um est\u00E1gio de cartao (est\u00E1gio)</param>
        /// <returns>Task of CartaoResponse</returns>
        System.Threading.Tasks.Task<CartaoResponse> AlterarEstagioAsync (long? id, EstagioCartaoUpdate update);

        /// <summary>
        /// Realiza a altera\u00E7\u00E3o de um est\u00E1gio de cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Esta m\u00E9todo permite que seja alterado o est\u00E1gio do cart\u00E3o para um outro informado na requisi\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="update">C\u00F3digo de identifica\u00E7\u00E3o de um est\u00E1gio de cartao (est\u00E1gio)</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> AlterarEstagioAsyncWithHttpInfo (long? id, EstagioCartaoUpdate update);
        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o da senha de um Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que o portador de um determinado cart\u00E3o possa definir uma senha a sua escolha
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="senha">Senha para ser cadastrada ou alterada</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> AlterarSenhaAsync (long? id, string senha);

        /// <summary>
        /// Realiza a altera\u00E7\u00E3o da senha de um Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que o portador de um determinado cart\u00E3o possa definir uma senha a sua escolha
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="senha">Senha para ser cadastrada ou alterada</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> AlterarSenhaAsyncWithHttpInfo (long? id, string senha);
        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o do Status de Impress\u00E3o do Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que uma Aplica\u00E7\u00E3o que realize a impress\u00E3o de cart\u00F5es possa indicar que um determinado idCartao fora impresso ou est\u00E1 em processo de impress\u00E3o. Para isso, basta informar o respectivo c\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id) que deseja ter seu um determinado id_status_impressao atribu\u00EDdo a ele. Por padr\u00E3o, cart\u00F5es provis\u00F3rios ou que j\u00E1 tenham sido inclu\u00EDdos em um arquivo para impress\u00E3o via gr\u00E1fica ter\u00E3o esta requisi\u00E7\u00E3o negada, se utilizada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="idStatusImpressao">C\u00F3digo de Identifica\u00E7\u00E3o do Status Impress\u00E3o (Id)</param>
        /// <returns>Task of HistoricoImpressaoCartaoResponse</returns>
        System.Threading.Tasks.Task<HistoricoImpressaoCartaoResponse> AlterarStatusImpressaoAsync (long? id, long? idStatusImpressao);

        /// <summary>
        /// Realiza a altera\u00E7\u00E3o do Status de Impress\u00E3o do Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que uma Aplica\u00E7\u00E3o que realize a impress\u00E3o de cart\u00F5es possa indicar que um determinado idCartao fora impresso ou est\u00E1 em processo de impress\u00E3o. Para isso, basta informar o respectivo c\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id) que deseja ter seu um determinado id_status_impressao atribu\u00EDdo a ele. Por padr\u00E3o, cart\u00F5es provis\u00F3rios ou que j\u00E1 tenham sido inclu\u00EDdos em um arquivo para impress\u00E3o via gr\u00E1fica ter\u00E3o esta requisi\u00E7\u00E3o negada, se utilizada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="idStatusImpressao">C\u00F3digo de Identifica\u00E7\u00E3o do Status Impress\u00E3o (Id)</param>
        /// <returns>Task of ApiResponse (HistoricoImpressaoCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<HistoricoImpressaoCartaoResponse>> AlterarStatusImpressaoAsyncWithHttpInfo (long? id, long? idStatusImpressao);
        
        /// <summary>
        /// Realiza a atribui\u00E7\u00E3o de um cart\u00E3o pr\u00E9-pago a uma pessoa
        /// </summary>
        /// <remarks>
        /// Esta m\u00E9todo permite que um cart\u00E3o pr\u00E9-pago impresso de forma avulsa e an\u00F4nimo seja atribu\u00EDdo a uma pessoa para que esta passe a ser a portadora titular dele
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="idPessoa">C\u00F3digo de identifica\u00E7\u00E3o de uma Pessoa (id)</param>
        /// <returns>Task of CartaoResponse</returns>
        System.Threading.Tasks.Task<CartaoResponse> AtribuirPessoaAsync (long? id, long? idPessoa);

        /// <summary>
        /// Realiza a atribui\u00E7\u00E3o de um cart\u00E3o pr\u00E9-pago a uma pessoa
        /// </summary>
        /// <remarks>
        /// Esta m\u00E9todo permite que um cart\u00E3o pr\u00E9-pago impresso de forma avulsa e an\u00F4nimo seja atribu\u00EDdo a uma pessoa para que esta passe a ser a portadora titular dele
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="idPessoa">C\u00F3digo de identifica\u00E7\u00E3o de uma Pessoa (id)</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> AtribuirPessoaAsyncWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// Realiza o bloqueio de um determinado Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite a realiza\u00E7\u00E3o do bloqueio (tempor\u00E1rio) ou do cancelamento (definitivo) de um determinado cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id). Para isso, \u00E9 preciso informar qual o motivo deste bloqueio que nada mais \u00E9 do que atribuir um novo StatusCartao para ele dentre as op\u00E7\u00F5es praticadas pelo emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="idStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Novo Status Cart\u00E3o</param>
        /// <param name="observacao">Texto informando uma observa\u00E7\u00E3o sobre o bloqueio</param>
        /// <returns>Task of CartaoResponse</returns>
        System.Threading.Tasks.Task<CartaoResponse> BloquearCartaoAsync (long? id, long? idStatus, string observacao);

        /// <summary>
        /// Realiza o bloqueio de um determinado Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite a realiza\u00E7\u00E3o do bloqueio (tempor\u00E1rio) ou do cancelamento (definitivo) de um determinado cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id). Para isso, \u00E9 preciso informar qual o motivo deste bloqueio que nada mais \u00E9 do que atribuir um novo StatusCartao para ele dentre as op\u00E7\u00F5es praticadas pelo emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="idStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Novo Status Cart\u00E3o</param>
        /// <param name="observacao">Texto informando uma observa\u00E7\u00E3o sobre o bloqueio</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> BloquearCartaoAsyncWithHttpInfo (long? id, long? idStatus, string observacao);
        
        /// <summary>
        /// Realiza o cadastro da senha de um Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que o portador de um determinado cart\u00E3o possa definir uma senha a sua escolha
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="senha">Senha para ser cadastrada ou alterada</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> CadastrarSenhaAsync (long? id, string senha);

        /// <summary>
        /// Realiza o cadastro da senha de um Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que o portador de um determinado cart\u00E3o possa definir uma senha a sua escolha
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="senha">Senha para ser cadastrada ou alterada</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> CadastrarSenhaAsyncWithHttpInfo (long? id, string senha);
        
        /// <summary>
        /// Realiza o cancelamento de um determinado Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite a realiza\u00E7\u00E3o cancelamento de um determinado cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id). Para isso, \u00E9 preciso informar qual o motivo deste bloqueio que nada mais \u00E9 do que atribuir um novo StatusCartao para ele dentre as op\u00E7\u00F5es praticadas pelo emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="idStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Novo Status Cart\u00E3o</param>
        /// <param name="observacao">Texto informando uma observa\u00E7\u00E3o sobre o cancelamento</param>
        /// <returns>Task of CartaoResponse</returns>
        System.Threading.Tasks.Task<CartaoResponse> CancelarCartaoAsync (long? id, long? idStatus, string observacao);

        /// <summary>
        /// Realiza o cancelamento de um determinado Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite a realiza\u00E7\u00E3o cancelamento de um determinado cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id). Para isso, \u00E9 preciso informar qual o motivo deste bloqueio que nada mais \u00E9 do que atribuir um novo StatusCartao para ele dentre as op\u00E7\u00F5es praticadas pelo emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="idStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Novo Status Cart\u00E3o</param>
        /// <param name="observacao">Texto informando uma observa\u00E7\u00E3o sobre o cancelamento</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> CancelarCartaoAsyncWithHttpInfo (long? id, long? idStatus, string observacao);
        
        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar as informa\u00E7\u00F5es b\u00E1sicas de um determinado Cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>Task of CartaoDetalheResponse</returns>
        System.Threading.Tasks.Task<CartaoDetalheResponse> ConsultarCartaoAsync (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar as informa\u00E7\u00F5es b\u00E1sicas de um determinado Cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (CartaoDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoDetalheResponse>> ConsultarCartaoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar os dados de impress\u00E3o de um Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar os dados de impress\u00E3o de um cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <returns>Task of DadosCartaoImpressaoResponse</returns>
        System.Threading.Tasks.Task<DadosCartaoImpressaoResponse> ConsultarDadosImpressaoAsync (long? id);

        /// <summary>
        /// Consultar os dados de impress\u00E3o de um Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar os dados de impress\u00E3o de um cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (DadosCartaoImpressaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DadosCartaoImpressaoResponse>> ConsultarDadosImpressaoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar Detalhes do Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja consultado os dados necessarios de um cart\u00E3o para executar servi\u00E7os de autoriza\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of DadosCartaoResponse</returns>
        System.Threading.Tasks.Task<DadosCartaoResponse> ConsultarDadosReaisCartaoAsync (long? id);

        /// <summary>
        /// Consultar Detalhes do Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja consultado os dados necessarios de um cart\u00E3o para executar servi\u00E7os de autoriza\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (DadosCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DadosCartaoResponse>> ConsultarDadosReaisCartaoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os limites do Portador do Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os Limites configurados para o Portador de um determinado Cart\u00E3o, seja ele o titular da conta ou um adicional, a partir do c\u00F3digo de identifica\u00E7\u00E3o do Cart\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>Task of LimiteDisponibilidadeResponse</returns>
        System.Threading.Tasks.Task<LimiteDisponibilidadeResponse> ConsultarLimitesDisponiveisAsync (long? id);

        /// <summary>
        /// Apresenta os limites do Portador do Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os Limites configurados para o Portador de um determinado Cart\u00E3o, seja ele o titular da conta ou um adicional, a partir do c\u00F3digo de identifica\u00E7\u00E3o do Cart\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (LimiteDisponibilidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LimiteDisponibilidadeResponse>> ConsultarLimitesDisponiveisAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Permite consultar um determinado Lote de Cart\u00F5es Pr\u00E9-Pago
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os cart\u00F5es pr\u00E9-pagos existentes na base do emissor atrav\u00E9s do id do lote
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do lote de cart\u00F5es (id)</param>
        /// <returns>Task of LoteCartoesPrePagosResponse</returns>
        System.Threading.Tasks.Task<LoteCartoesPrePagosResponse> ConsultarLoteCartoesPrePagosAsync (long? id);

        /// <summary>
        /// Permite consultar um determinado Lote de Cart\u00F5es Pr\u00E9-Pago
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os cart\u00F5es pr\u00E9-pagos existentes na base do emissor atrav\u00E9s do id do lote
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do lote de cart\u00F5es (id)</param>
        /// <returns>Task of ApiResponse (LoteCartoesPrePagosResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LoteCartoesPrePagosResponse>> ConsultarLoteCartoesPrePagosAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados do Portador do Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar as informa\u00E7\u00F5es do Portador de um determinado Cart\u00E3o a partir do c\u00F3digo de identifica\u00E7\u00E3o do Cart\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>Task of PortadorResponse</returns>
        System.Threading.Tasks.Task<PortadorResponse> ConsultarPortadorAsync (long? id);

        /// <summary>
        /// Apresenta os dados do Portador do Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar as informa\u00E7\u00F5es do Portador de um determinado Cart\u00E3o a partir do c\u00F3digo de identifica\u00E7\u00E3o do Cart\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (PortadorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortadorResponse>> ConsultarPortadorAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Cadastrar cart\u00F5es MultiApp
        /// </summary>
        /// <remarks>
        /// Este recurso permite o cadastro de cart\u00F5es MultiApp
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartaoMultiAppPersist">cartaoMultiAppPersist</param>
        /// <returns>Task of VinculoCartoesResponse</returns>
        System.Threading.Tasks.Task<VinculoCartoesResponse> CriarCartoesMultiAppAsync (CartaoMultiAppPersist cartaoMultiAppPersist);

        /// <summary>
        /// Cadastrar cart\u00F5es MultiApp
        /// </summary>
        /// <remarks>
        /// Este recurso permite o cadastro de cart\u00F5es MultiApp
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartaoMultiAppPersist">cartaoMultiAppPersist</param>
        /// <returns>Task of ApiResponse (VinculoCartoesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<VinculoCartoesResponse>> CriarCartoesMultiAppAsyncWithHttpInfo (CartaoMultiAppPersist cartaoMultiAppPersist);
        
        /// <summary>
        /// Realiza o desbloqueio de um determinado Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja desbloqueado um determinado cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>Task of CartaoResponse</returns>
        System.Threading.Tasks.Task<CartaoResponse> DesbloquearCartaoAsync (long? id);

        /// <summary>
        /// Realiza o desbloqueio de um determinado Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja desbloqueado um determinado cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> DesbloquearCartaoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Permite gerar um novo Lote de Cart\u00F5es Pr\u00E9-Pago
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores gerem uma determinada quantidade de Cart\u00F5es Pr\u00E9-Pagos, de forma n\u00E3o nominal, os quais poder\u00E3o ser comercializados e posteriormente vinculados a um cliente que o adquirir. Para isso, al\u00E9m de definir quantos cart\u00F5es dever\u00E3o ser gerados, ser\u00E1 poss\u00EDvel definir qual a Origem Comercial, o Produto, o Tipo do Cart\u00E3o, a Imagem e o Endere\u00E7o para entrega dos Cart\u00F5es presentes no lote gerado. Por padr\u00E3o, todos os cart\u00F5es ser\u00E3o associados a um idPessoa fict\u00EDcio e receber\u00E1 um idConta \u00FAnico para cada um deles. Feito isso, os Cart\u00F5es gerados por esta opera\u00E7\u00E3o seguir\u00E3o os mesmos processos de impress\u00E3o via gr\u00E1fica previamente definidos entre o Emissor e a Conductor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idOrigemComercial">C\u00F3digo de Identifica\u00E7\u00E3o da Origem Comercial (id) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (optional)</param>
        /// <param name="idTipoCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Cart\u00E3o (id) (optional)</param>
        /// <param name="idImagem">C\u00F3digo de Identifica\u00E7\u00E3o da Imagem (id) (optional)</param>
        /// <param name="idEndereco">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id) (optional)</param>
        /// <param name="quantidadeCartoes">N\u00FAmero de cart\u00F5es existentes no Lote (optional)</param>
        /// <param name="identificadorExterno">N\u00FAmero de identifica\u00E7\u00E3o externo (utilizado pelo emissor) (optional)</param>
        /// <returns>Task of LoteCartoesPrePagosResponse</returns>
        System.Threading.Tasks.Task<LoteCartoesPrePagosResponse> GerarLoteCartoesPrePagosAsync (long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string identificadorExterno = null);

        /// <summary>
        /// Permite gerar um novo Lote de Cart\u00F5es Pr\u00E9-Pago
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores gerem uma determinada quantidade de Cart\u00F5es Pr\u00E9-Pagos, de forma n\u00E3o nominal, os quais poder\u00E3o ser comercializados e posteriormente vinculados a um cliente que o adquirir. Para isso, al\u00E9m de definir quantos cart\u00F5es dever\u00E3o ser gerados, ser\u00E1 poss\u00EDvel definir qual a Origem Comercial, o Produto, o Tipo do Cart\u00E3o, a Imagem e o Endere\u00E7o para entrega dos Cart\u00F5es presentes no lote gerado. Por padr\u00E3o, todos os cart\u00F5es ser\u00E3o associados a um idPessoa fict\u00EDcio e receber\u00E1 um idConta \u00FAnico para cada um deles. Feito isso, os Cart\u00F5es gerados por esta opera\u00E7\u00E3o seguir\u00E3o os mesmos processos de impress\u00E3o via gr\u00E1fica previamente definidos entre o Emissor e a Conductor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idOrigemComercial">C\u00F3digo de Identifica\u00E7\u00E3o da Origem Comercial (id) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (optional)</param>
        /// <param name="idTipoCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Cart\u00E3o (id) (optional)</param>
        /// <param name="idImagem">C\u00F3digo de Identifica\u00E7\u00E3o da Imagem (id) (optional)</param>
        /// <param name="idEndereco">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id) (optional)</param>
        /// <param name="quantidadeCartoes">N\u00FAmero de cart\u00F5es existentes no Lote (optional)</param>
        /// <param name="identificadorExterno">N\u00FAmero de identifica\u00E7\u00E3o externo (utilizado pelo emissor) (optional)</param>
        /// <returns>Task of ApiResponse (LoteCartoesPrePagosResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LoteCartoesPrePagosResponse>> GerarLoteCartoesPrePagosAsyncWithHttpInfo (long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string identificadorExterno = null);
        
        /// <summary>
        /// Gerar uma nova via de Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores ou seus clientes possam solicitar a gera\u00E7\u00E3o de uma nova via de Cart\u00E3o que ser\u00E1 encaminhando para impress\u00E3o e postagem de acordo com os fluxos padr\u00F5es j\u00E1 definidos pelo emissor. Para isso, \u00E9 preciso que o cliente j\u00E1 possua um cart\u00E3o gerado e informar o C\u00F3digo de Identifica\u00E7\u00E3o deste (idCartao) para que ele possa utilizar esta opera\u00E7\u00E3o. Assim, esta funcionalidade se aplica apenas para a gera\u00E7\u00E3o de cart\u00F5es f\u00EDsicos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="idImagem">C\u00F3digo de Identifica\u00E7\u00E3o da imagem do cart\u00E3o (id) (optional)</param>
        /// <returns>Task of CartaoImpressaoResponse</returns>
        System.Threading.Tasks.Task<CartaoImpressaoResponse> GerarNovaViaCartaoAsync (long? id, long? idImagem = null);

        /// <summary>
        /// Gerar uma nova via de Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores ou seus clientes possam solicitar a gera\u00E7\u00E3o de uma nova via de Cart\u00E3o que ser\u00E1 encaminhando para impress\u00E3o e postagem de acordo com os fluxos padr\u00F5es j\u00E1 definidos pelo emissor. Para isso, \u00E9 preciso que o cliente j\u00E1 possua um cart\u00E3o gerado e informar o C\u00F3digo de Identifica\u00E7\u00E3o deste (idCartao) para que ele possa utilizar esta opera\u00E7\u00E3o. Assim, esta funcionalidade se aplica apenas para a gera\u00E7\u00E3o de cart\u00F5es f\u00EDsicos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="idImagem">C\u00F3digo de Identifica\u00E7\u00E3o da imagem do cart\u00E3o (id) (optional)</param>
        /// <returns>Task of ApiResponse (CartaoImpressaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoImpressaoResponse>> GerarNovaViaCartaoAsyncWithHttpInfo (long? id, long? idImagem = null);
        
        /// <summary>
        /// Gerar nova via de cart\u00E3o m\u00FAltiplo
        /// </summary>
        /// <remarks>
        /// Este recurso permite gerar uma nova via de cart\u00E3o m\u00FAltiplo (com dois produtos relacionados)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>Task of CartaoMultiAppImpressaoResponse</returns>
        System.Threading.Tasks.Task<CartaoMultiAppImpressaoResponse> GerarNovaViaCartaoMultiAppAsync (long? id);

        /// <summary>
        /// Gerar nova via de cart\u00E3o m\u00FAltiplo
        /// </summary>
        /// <remarks>
        /// Este recurso permite gerar uma nova via de cart\u00E3o m\u00FAltiplo (com dois produtos relacionados)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (CartaoMultiAppImpressaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoMultiAppImpressaoResponse>> GerarNovaViaCartaoMultiAppAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Adiciona tarifa de ajuste da segunda via do cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite adicionar tar\u00EDfa de ajuste pela emiss\u00E3o da segunda via do cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> LancarTarifaReemissaoAsync (long? id);

        /// <summary>
        /// Adiciona tarifa de ajuste da segunda via do cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite adicionar tar\u00EDfa de ajuste pela emiss\u00E3o da segunda via do cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> LancarTarifaReemissaoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista os Cart\u00F5es gerados pelo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os cart\u00F5es existentes na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Status do Cart\u00E3o (id) (optional)</param>
        /// <param name="idEstagioCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Est\u00E1gio de Impress\u00E3o do Cart\u00E3o (id) (optional)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta a qual o cart\u00E3o pertence (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o cart\u00E3o pertence (id) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto a qual o cart\u00E3o pertence (id) (optional)</param>
        /// <param name="tipoPortador">Mostre o tipo do titular do cart\u00E3o, sendo: (&#39;T&#39;: titular, &#39;A&#39;: adicional) (optional)</param>
        /// <param name="numeroCartao">Apresenta o n\u00FAmero do cart\u00E3o (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome impresso no cart\u00E3o (optional)</param>
        /// <param name="dataGeracao">Apresenta a data em que o cart\u00E3o foi gerado (optional)</param>
        /// <param name="dataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00E3o fora aplicado, quando houver (optional)</param>
        /// <param name="dataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00E3o fora aplicado, quando houver (optional)</param>
        /// <param name="dataValidade">Mostrar a data da expira\u00E7\u00E3o do cart\u00E3o no formato aaaa-MM, quando houver (optional)</param>
        /// <param name="dataImpressao">Apresenta a data em que o cart\u00E3o fora impresso, caso impress\u00E3o em loja, ou a data em que ele fora inclu\u00EDdo no arquivo para impress\u00E3o via gr\u00E1fica (optional)</param>
        /// <param name="arquivoImpressao">Apresenta o nome do arquivo onde o cart\u00E3o fora inclu\u00EDdo para impress\u00E3o por uma gr\u00E1fica, quando houver (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00E3o fora impresso na Origem Comercial (optional)</param>
        /// <param name="flagProvisorio">Quando ativa, indica que o cart\u00E3o \u00E9 provis\u00F3rio. Ou seja, \u00E9 um cart\u00E3o para uso tempor\u00E1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00E3o definitivo (optional)</param>
        /// <param name="codigoDesbloqueio">Apresenta um c\u00F3digo espec\u00EDfico para ser utilizado como vari\u00E1vel no processo de desbloqueio do cart\u00E3o para emissores que querem usar esta funcionalidade (optional)</param>
        /// <param name="sequencialCartao">N\u00FAmero sequencial do cart\u00E3o (optional)</param>
        /// <param name="identificadorExterno">Identificador externo do cart\u00E3o (optional)</param>
        /// <returns>Task of PageCartaoResponse</returns>
        System.Threading.Tasks.Task<PageCartaoResponse> ListarCartoesAsync (List<string> sort = null, int? page = null, int? limit = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? sequencialCartao = null, long? identificadorExterno = null);

        /// <summary>
        /// Lista os Cart\u00F5es gerados pelo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os cart\u00F5es existentes na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Status do Cart\u00E3o (id) (optional)</param>
        /// <param name="idEstagioCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Est\u00E1gio de Impress\u00E3o do Cart\u00E3o (id) (optional)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta a qual o cart\u00E3o pertence (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o cart\u00E3o pertence (id) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto a qual o cart\u00E3o pertence (id) (optional)</param>
        /// <param name="tipoPortador">Mostre o tipo do titular do cart\u00E3o, sendo: (&#39;T&#39;: titular, &#39;A&#39;: adicional) (optional)</param>
        /// <param name="numeroCartao">Apresenta o n\u00FAmero do cart\u00E3o (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome impresso no cart\u00E3o (optional)</param>
        /// <param name="dataGeracao">Apresenta a data em que o cart\u00E3o foi gerado (optional)</param>
        /// <param name="dataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00E3o fora aplicado, quando houver (optional)</param>
        /// <param name="dataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00E3o fora aplicado, quando houver (optional)</param>
        /// <param name="dataValidade">Mostrar a data da expira\u00E7\u00E3o do cart\u00E3o no formato aaaa-MM, quando houver (optional)</param>
        /// <param name="dataImpressao">Apresenta a data em que o cart\u00E3o fora impresso, caso impress\u00E3o em loja, ou a data em que ele fora inclu\u00EDdo no arquivo para impress\u00E3o via gr\u00E1fica (optional)</param>
        /// <param name="arquivoImpressao">Apresenta o nome do arquivo onde o cart\u00E3o fora inclu\u00EDdo para impress\u00E3o por uma gr\u00E1fica, quando houver (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00E3o fora impresso na Origem Comercial (optional)</param>
        /// <param name="flagProvisorio">Quando ativa, indica que o cart\u00E3o \u00E9 provis\u00F3rio. Ou seja, \u00E9 um cart\u00E3o para uso tempor\u00E1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00E3o definitivo (optional)</param>
        /// <param name="codigoDesbloqueio">Apresenta um c\u00F3digo espec\u00EDfico para ser utilizado como vari\u00E1vel no processo de desbloqueio do cart\u00E3o para emissores que querem usar esta funcionalidade (optional)</param>
        /// <param name="sequencialCartao">N\u00FAmero sequencial do cart\u00E3o (optional)</param>
        /// <param name="identificadorExterno">Identificador externo do cart\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (PageCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCartaoResponse>> ListarCartoesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? sequencialCartao = null, long? identificadorExterno = null);
        
        /// <summary>
        /// Permite listar os Lotes de Cart\u00F5es Pr\u00E9-Pago
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os cart\u00F5es pr\u00E9-pagos existentes na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idOrigemComercial">C\u00F3digo de Identifica\u00E7\u00E3o da Origem Comercial (id) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (optional)</param>
        /// <param name="idTipoCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Cart\u00E3o (id) (optional)</param>
        /// <param name="idImagem">C\u00F3digo de Identifica\u00E7\u00E3o da Imagem (id) (optional)</param>
        /// <param name="idEndereco">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id) (optional)</param>
        /// <param name="quantidadeCartoes">N\u00FAmero de cart\u00F5es existentes no Lote (optional)</param>
        /// <param name="dataCadastro">Data de Cadastro do Lote de Cart\u00F5es N\u00E3o Nominais (optional)</param>
        /// <param name="usuarioCadastro">Nome do Usu\u00E1rio que criou o Lote (optional)</param>
        /// <param name="statusProcessamento">Indica o Status de Processamento do Lote (optional)</param>
        /// <param name="identificadorExterno">N\u00FAmero de identifica\u00E7\u00E3o externo (utilizado pelo emissor) (optional)</param>
        /// <returns>Task of PageLoteCartoesPrePagosResponse</returns>
        System.Threading.Tasks.Task<PageLoteCartoesPrePagosResponse> ListarLotesCartoesPrePagosAsync (List<string> sort = null, int? page = null, int? limit = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string dataCadastro = null, string usuarioCadastro = null, int? statusProcessamento = null, string identificadorExterno = null);

        /// <summary>
        /// Permite listar os Lotes de Cart\u00F5es Pr\u00E9-Pago
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os cart\u00F5es pr\u00E9-pagos existentes na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idOrigemComercial">C\u00F3digo de Identifica\u00E7\u00E3o da Origem Comercial (id) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (optional)</param>
        /// <param name="idTipoCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Cart\u00E3o (id) (optional)</param>
        /// <param name="idImagem">C\u00F3digo de Identifica\u00E7\u00E3o da Imagem (id) (optional)</param>
        /// <param name="idEndereco">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id) (optional)</param>
        /// <param name="quantidadeCartoes">N\u00FAmero de cart\u00F5es existentes no Lote (optional)</param>
        /// <param name="dataCadastro">Data de Cadastro do Lote de Cart\u00F5es N\u00E3o Nominais (optional)</param>
        /// <param name="usuarioCadastro">Nome do Usu\u00E1rio que criou o Lote (optional)</param>
        /// <param name="statusProcessamento">Indica o Status de Processamento do Lote (optional)</param>
        /// <param name="identificadorExterno">N\u00FAmero de identifica\u00E7\u00E3o externo (utilizado pelo emissor) (optional)</param>
        /// <returns>Task of ApiResponse (PageLoteCartoesPrePagosResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageLoteCartoesPrePagosResponse>> ListarLotesCartoesPrePagosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string dataCadastro = null, string usuarioCadastro = null, int? statusProcessamento = null, string identificadorExterno = null);
        
        /// <summary>
        /// Realiza a reativa\u00E7\u00E3o de um determinado Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite a realiza\u00E7\u00E3o da reativa\u00E7\u00E3o de um determinado cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>Task of CartaoResponse</returns>
        System.Threading.Tasks.Task<CartaoResponse> ReativarCartaoAsync (long? id);

        /// <summary>
        /// Realiza a reativa\u00E7\u00E3o de um determinado Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite a realiza\u00E7\u00E3o da reativa\u00E7\u00E3o de um determinado cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> ReativarCartaoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Realiza o desbloqueio de um cart\u00E3o bloqueado por tentativas de senha incorretas
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja desbloqueado um determinado cart\u00E3o que foi bloqueado por tentativas de senha incorretas, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>Task of CartaoResponse</returns>
        System.Threading.Tasks.Task<CartaoResponse> ResetarTentativasSenhaIncorretaAsync (long? id);

        /// <summary>
        /// Realiza o desbloqueio de um cart\u00E3o bloqueado por tentativas de senha incorretas
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja desbloqueado um determinado cart\u00E3o que foi bloqueado por tentativas de senha incorretas, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> ResetarTentativasSenhaIncorretaAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Validar CVV do cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite a valida\u00E7\u00E3o do cvv de um cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="validaCVV">validaCVV</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ValidarCVVAsync (long? id, ValidaCVVRequest validaCVV);

        /// <summary>
        /// Validar CVV do cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite a valida\u00E7\u00E3o do cvv de um cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="validaCVV">validaCVV</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ValidarCVVAsyncWithHttpInfo (long? id, ValidaCVVRequest validaCVV);
        
        /// <summary>
        /// Permite validar um Cart\u00E3o com bandeira Mastercard a partir do de55
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores validem o DE55 gerado a partir da leitura de um chip EMV de um Cart\u00E3o com bandeira Mastercard a fim de verificar a sua autenticidade. A utiliza\u00E7\u00E3o desde m\u00E9todo tem diversas aplica\u00E7\u00F5es, sendo a principal delas a de Identifica\u00E7\u00E3o Positiva do Cart\u00E3o antes de permitir que o portador realize transa\u00E7\u00F5es diversas, como as de compra e saque na modalidade d\u00E9bito em conta corrente, dentre outras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00FAmero do cart\u00E3o a ser validado</param>
        /// <param name="criptograma">Criptograma do cart\u00E3o no formato de55</param>
        /// <returns>Task of ValidaCartaoResponse</returns>
        System.Threading.Tasks.Task<ValidaCartaoResponse> ValidarDE55MastercardAsync (string numeroCartao, string criptograma);

        /// <summary>
        /// Permite validar um Cart\u00E3o com bandeira Mastercard a partir do de55
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores validem o DE55 gerado a partir da leitura de um chip EMV de um Cart\u00E3o com bandeira Mastercard a fim de verificar a sua autenticidade. A utiliza\u00E7\u00E3o desde m\u00E9todo tem diversas aplica\u00E7\u00F5es, sendo a principal delas a de Identifica\u00E7\u00E3o Positiva do Cart\u00E3o antes de permitir que o portador realize transa\u00E7\u00F5es diversas, como as de compra e saque na modalidade d\u00E9bito em conta corrente, dentre outras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00FAmero do cart\u00E3o a ser validado</param>
        /// <param name="criptograma">Criptograma do cart\u00E3o no formato de55</param>
        /// <returns>Task of ApiResponse (ValidaCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ValidaCartaoResponse>> ValidarDE55MastercardAsyncWithHttpInfo (string numeroCartao, string criptograma);
        
        /// <summary>
        /// Permite validar os dados impressos em um cart\u00E3o bandeirado
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00E3o a partir do envio dos dados sens\u00EDveis impressos nele. A utiliza\u00E7\u00E3o desde m\u00E9todo tem diversas aplica\u00E7\u00F5es, sendo a principal delas a de Identifica\u00E7\u00E3o Positiva do Cart\u00E3o para a realiza\u00E7\u00E3o de transa\u00E7\u00F5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00F4nico (URA), dentre outras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00FAmero do cart\u00E3o a ser validado</param>
        /// <param name="nomePortador">Nome do portador do cart\u00E3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00E3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00F3digo de seguran\u00E7a do cart\u00E3o com tr\u00EAs n\u00FAmeros</param>
        /// <returns>Task of ValidaCartaoResponse</returns>
        System.Threading.Tasks.Task<ValidaCartaoResponse> ValidarDadosCartaoBandeiradoAsync (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);

        /// <summary>
        /// Permite validar os dados impressos em um cart\u00E3o bandeirado
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00E3o a partir do envio dos dados sens\u00EDveis impressos nele. A utiliza\u00E7\u00E3o desde m\u00E9todo tem diversas aplica\u00E7\u00F5es, sendo a principal delas a de Identifica\u00E7\u00E3o Positiva do Cart\u00E3o para a realiza\u00E7\u00E3o de transa\u00E7\u00F5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00F4nico (URA), dentre outras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00FAmero do cart\u00E3o a ser validado</param>
        /// <param name="nomePortador">Nome do portador do cart\u00E3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00E3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00F3digo de seguran\u00E7a do cart\u00E3o com tr\u00EAs n\u00FAmeros</param>
        /// <returns>Task of ApiResponse (ValidaCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ValidaCartaoResponse>> ValidarDadosCartaoBandeiradoAsyncWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);
        
        /// <summary>
        /// Permite validar os dados impressos de um cartao n\u00E3o bandeirado
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00E3o a partir do envio dos dados sens\u00EDveis impressos nele. A utiliza\u00E7\u00E3o desde m\u00E9todo tem diversas aplica\u00E7\u00F5es, sendo a principal delas a de Identifica\u00E7\u00E3o Positiva do Cart\u00E3o para a realiza\u00E7\u00E3o de transa\u00E7\u00F5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00F4nico (URA), dentre outras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00FAmero do cart\u00E3o a ser validado</param>
        /// <param name="nomePortador">Nome do portador do cart\u00E3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00E3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00F3digo de seguran\u00E7a do cart\u00E3o com tr\u00EAs n\u00FAmeros</param>
        /// <returns>Task of ValidaCartaoResponse</returns>
        System.Threading.Tasks.Task<ValidaCartaoResponse> ValidarDadosCartaoPrivateAsync (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);

        /// <summary>
        /// Permite validar os dados impressos de um cartao n\u00E3o bandeirado
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00E3o a partir do envio dos dados sens\u00EDveis impressos nele. A utiliza\u00E7\u00E3o desde m\u00E9todo tem diversas aplica\u00E7\u00F5es, sendo a principal delas a de Identifica\u00E7\u00E3o Positiva do Cart\u00E3o para a realiza\u00E7\u00E3o de transa\u00E7\u00F5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00F4nico (URA), dentre outras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00FAmero do cart\u00E3o a ser validado</param>
        /// <param name="nomePortador">Nome do portador do cart\u00E3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00E3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00F3digo de seguran\u00E7a do cart\u00E3o com tr\u00EAs n\u00FAmeros</param>
        /// <returns>Task of ApiResponse (ValidaCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ValidaCartaoResponse>> ValidarDadosCartaoPrivateAsyncWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);
        
        /// <summary>
        /// Permite validar a senha de um Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir validar que a senha informada pelo portador de um determinado cart\u00E3o est\u00E1 correta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="senhaDTO">Representa o DTO de senha para usu\u00E1rio</param>
        /// <returns>Task of ValidaSenhaCartaoResponse</returns>
        System.Threading.Tasks.Task<ValidaSenhaCartaoResponse> ValidarSenhaAsync (long? id, SenhaDTO senhaDTO);

        /// <summary>
        /// Permite validar a senha de um Cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir validar que a senha informada pelo portador de um determinado cart\u00E3o est\u00E1 correta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="senhaDTO">Representa o DTO de senha para usu\u00E1rio</param>
        /// <returns>Task of ApiResponse (ValidaSenhaCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ValidaSenhaCartaoResponse>> ValidarSenhaAsyncWithHttpInfo (long? id, SenhaDTO senhaDTO);
        
        /// <summary>
        /// Permite validar um Cart\u00E3o Bandeirado a partir da Tarja
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00E3o a partir da leitura da tarja magn\u00E9tica do mesmo. A utiliza\u00E7\u00E3o desde m\u00E9todo tem diversas aplica\u00E7\u00F5es, sendo a principal delas a de Identifica\u00E7\u00E3o Positiva do Cart\u00E3o antes de permitir que o portador realize transa\u00E7\u00F5es diversas, como as de compra e saque na modalidade d\u00E9bito em conta corrente, dentre outras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00FAmero do cart\u00E3o a ser validado</param>
        /// <param name="trilha1">Trilha 1 do cart\u00E3o a ser validado</param>
        /// <param name="trilha2">Trilha 2 do cart\u00E3o a ser validado</param>
        /// <returns>Task of ValidaCartaoResponse</returns>
        System.Threading.Tasks.Task<ValidaCartaoResponse> ValidarTarjaAsync (string numeroCartao, string trilha1, string trilha2);

        /// <summary>
        /// Permite validar um Cart\u00E3o Bandeirado a partir da Tarja
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00E3o a partir da leitura da tarja magn\u00E9tica do mesmo. A utiliza\u00E7\u00E3o desde m\u00E9todo tem diversas aplica\u00E7\u00F5es, sendo a principal delas a de Identifica\u00E7\u00E3o Positiva do Cart\u00E3o antes de permitir que o portador realize transa\u00E7\u00F5es diversas, como as de compra e saque na modalidade d\u00E9bito em conta corrente, dentre outras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00FAmero do cart\u00E3o a ser validado</param>
        /// <param name="trilha1">Trilha 1 do cart\u00E3o a ser validado</param>
        /// <param name="trilha2">Trilha 2 do cart\u00E3o a ser validado</param>
        /// <returns>Task of ApiResponse (ValidaCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ValidaCartaoResponse>> ValidarTarjaAsyncWithHttpInfo (string numeroCartao, string trilha1, string trilha2);
        
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
        /// Realiza a altera\u00E7\u00E3o de um est\u00E1gio de cart\u00E3o Esta m\u00E9todo permite que seja alterado o est\u00E1gio do cart\u00E3o para um outro informado na requisi\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param> 
        /// <param name="update">C\u00F3digo de identifica\u00E7\u00E3o de um est\u00E1gio de cartao (est\u00E1gio)</param> 
        /// <returns>CartaoResponse</returns>
        public CartaoResponse AlterarEstagio (long? id, EstagioCartaoUpdate update)
        {
             ApiResponse<CartaoResponse> localVarResponse = AlterarEstagioWithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a altera\u00E7\u00E3o de um est\u00E1gio de cart\u00E3o Esta m\u00E9todo permite que seja alterado o est\u00E1gio do cart\u00E3o para um outro informado na requisi\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param> 
        /// <param name="update">C\u00F3digo de identifica\u00E7\u00E3o de um est\u00E1gio de cartao (est\u00E1gio)</param> 
        /// <returns>ApiResponse of CartaoResponse</returns>
        public ApiResponse< CartaoResponse > AlterarEstagioWithHttpInfo (long? id, EstagioCartaoUpdate update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->AlterarEstagio");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling CartaoApi->AlterarEstagio");
            
    
            var localVarPath = "/api/cartoes/{id}/alterar-estagio";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (update.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(update); // http body (model) parameter
            }
            else
            {
                localVarPostBody = update; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarEstagio: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarEstagio: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }

        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o de um est\u00E1gio de cart\u00E3o Esta m\u00E9todo permite que seja alterado o est\u00E1gio do cart\u00E3o para um outro informado na requisi\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="update">C\u00F3digo de identifica\u00E7\u00E3o de um est\u00E1gio de cartao (est\u00E1gio)</param>
        /// <returns>Task of CartaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoResponse> AlterarEstagioAsync (long? id, EstagioCartaoUpdate update)
        {
             ApiResponse<CartaoResponse> localVarResponse = await AlterarEstagioAsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a altera\u00E7\u00E3o de um est\u00E1gio de cart\u00E3o Esta m\u00E9todo permite que seja alterado o est\u00E1gio do cart\u00E3o para um outro informado na requisi\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="update">C\u00F3digo de identifica\u00E7\u00E3o de um est\u00E1gio de cartao (est\u00E1gio)</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> AlterarEstagioAsyncWithHttpInfo (long? id, EstagioCartaoUpdate update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarEstagio");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AlterarEstagio");
            
    
            var localVarPath = "/api/cartoes/{id}/alterar-estagio";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (update.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(update); // http body (model) parameter
            }
            else
            {
                localVarPostBody = update; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarEstagio: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarEstagio: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }
        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o da senha de um Cart\u00E3o Esta opera\u00E7\u00E3o tem como objetivo permitir que o portador de um determinado cart\u00E3o possa definir uma senha a sua escolha
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param> 
        /// <param name="senha">Senha para ser cadastrada ou alterada</param> 
        /// <returns>string</returns>
        public string AlterarSenha (long? id, string senha)
        {
             ApiResponse<string> localVarResponse = AlterarSenhaWithHttpInfo(id, senha);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a altera\u00E7\u00E3o da senha de um Cart\u00E3o Esta opera\u00E7\u00E3o tem como objetivo permitir que o portador de um determinado cart\u00E3o possa definir uma senha a sua escolha
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param> 
        /// <param name="senha">Senha para ser cadastrada ou alterada</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > AlterarSenhaWithHttpInfo (long? id, string senha)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->AlterarSenha");
            
            // verify the required parameter 'senha' is set
            if (senha == null)
                throw new ApiException(400, "Missing required parameter 'senha' when calling CartaoApi->AlterarSenha");
            
    
            var localVarPath = "/api/cartoes/{id}/alterar-senha";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            if (senha != null) localVarHeaderParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // header parameter
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenha: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenha: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o da senha de um Cart\u00E3o Esta opera\u00E7\u00E3o tem como objetivo permitir que o portador de um determinado cart\u00E3o possa definir uma senha a sua escolha
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="senha">Senha para ser cadastrada ou alterada</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> AlterarSenhaAsync (long? id, string senha)
        {
             ApiResponse<string> localVarResponse = await AlterarSenhaAsyncWithHttpInfo(id, senha);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a altera\u00E7\u00E3o da senha de um Cart\u00E3o Esta opera\u00E7\u00E3o tem como objetivo permitir que o portador de um determinado cart\u00E3o possa definir uma senha a sua escolha
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="senha">Senha para ser cadastrada ou alterada</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> AlterarSenhaAsyncWithHttpInfo (long? id, string senha)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarSenha");
            // verify the required parameter 'senha' is set
            if (senha == null) throw new ApiException(400, "Missing required parameter 'senha' when calling AlterarSenha");
            
    
            var localVarPath = "/api/cartoes/{id}/alterar-senha";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            if (senha != null) localVarHeaderParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // header parameter
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenha: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenha: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o do Status de Impress\u00E3o do Cart\u00E3o Este m\u00E9todo permite que uma Aplica\u00E7\u00E3o que realize a impress\u00E3o de cart\u00F5es possa indicar que um determinado idCartao fora impresso ou est\u00E1 em processo de impress\u00E3o. Para isso, basta informar o respectivo c\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id) que deseja ter seu um determinado id_status_impressao atribu\u00EDdo a ele. Por padr\u00E3o, cart\u00F5es provis\u00F3rios ou que j\u00E1 tenham sido inclu\u00EDdos em um arquivo para impress\u00E3o via gr\u00E1fica ter\u00E3o esta requisi\u00E7\u00E3o negada, se utilizada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param> 
        /// <param name="idStatusImpressao">C\u00F3digo de Identifica\u00E7\u00E3o do Status Impress\u00E3o (Id)</param> 
        /// <returns>HistoricoImpressaoCartaoResponse</returns>
        public HistoricoImpressaoCartaoResponse AlterarStatusImpressao (long? id, long? idStatusImpressao)
        {
             ApiResponse<HistoricoImpressaoCartaoResponse> localVarResponse = AlterarStatusImpressaoWithHttpInfo(id, idStatusImpressao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a altera\u00E7\u00E3o do Status de Impress\u00E3o do Cart\u00E3o Este m\u00E9todo permite que uma Aplica\u00E7\u00E3o que realize a impress\u00E3o de cart\u00F5es possa indicar que um determinado idCartao fora impresso ou est\u00E1 em processo de impress\u00E3o. Para isso, basta informar o respectivo c\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id) que deseja ter seu um determinado id_status_impressao atribu\u00EDdo a ele. Por padr\u00E3o, cart\u00F5es provis\u00F3rios ou que j\u00E1 tenham sido inclu\u00EDdos em um arquivo para impress\u00E3o via gr\u00E1fica ter\u00E3o esta requisi\u00E7\u00E3o negada, se utilizada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param> 
        /// <param name="idStatusImpressao">C\u00F3digo de Identifica\u00E7\u00E3o do Status Impress\u00E3o (Id)</param> 
        /// <returns>ApiResponse of HistoricoImpressaoCartaoResponse</returns>
        public ApiResponse< HistoricoImpressaoCartaoResponse > AlterarStatusImpressaoWithHttpInfo (long? id, long? idStatusImpressao)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->AlterarStatusImpressao");
            
            // verify the required parameter 'idStatusImpressao' is set
            if (idStatusImpressao == null)
                throw new ApiException(400, "Missing required parameter 'idStatusImpressao' when calling CartaoApi->AlterarStatusImpressao");
            
    
            var localVarPath = "/api/cartoes/{id}/alterar-status-impressao";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            if (idStatusImpressao != null) localVarQueryParams.Add("id_status_impressao", Configuration.ApiClient.ParameterToString(idStatusImpressao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatusImpressao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatusImpressao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<HistoricoImpressaoCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HistoricoImpressaoCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(HistoricoImpressaoCartaoResponse)));
            
        }

        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o do Status de Impress\u00E3o do Cart\u00E3o Este m\u00E9todo permite que uma Aplica\u00E7\u00E3o que realize a impress\u00E3o de cart\u00F5es possa indicar que um determinado idCartao fora impresso ou est\u00E1 em processo de impress\u00E3o. Para isso, basta informar o respectivo c\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id) que deseja ter seu um determinado id_status_impressao atribu\u00EDdo a ele. Por padr\u00E3o, cart\u00F5es provis\u00F3rios ou que j\u00E1 tenham sido inclu\u00EDdos em um arquivo para impress\u00E3o via gr\u00E1fica ter\u00E3o esta requisi\u00E7\u00E3o negada, se utilizada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="idStatusImpressao">C\u00F3digo de Identifica\u00E7\u00E3o do Status Impress\u00E3o (Id)</param>
        /// <returns>Task of HistoricoImpressaoCartaoResponse</returns>
        public async System.Threading.Tasks.Task<HistoricoImpressaoCartaoResponse> AlterarStatusImpressaoAsync (long? id, long? idStatusImpressao)
        {
             ApiResponse<HistoricoImpressaoCartaoResponse> localVarResponse = await AlterarStatusImpressaoAsyncWithHttpInfo(id, idStatusImpressao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a altera\u00E7\u00E3o do Status de Impress\u00E3o do Cart\u00E3o Este m\u00E9todo permite que uma Aplica\u00E7\u00E3o que realize a impress\u00E3o de cart\u00F5es possa indicar que um determinado idCartao fora impresso ou est\u00E1 em processo de impress\u00E3o. Para isso, basta informar o respectivo c\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id) que deseja ter seu um determinado id_status_impressao atribu\u00EDdo a ele. Por padr\u00E3o, cart\u00F5es provis\u00F3rios ou que j\u00E1 tenham sido inclu\u00EDdos em um arquivo para impress\u00E3o via gr\u00E1fica ter\u00E3o esta requisi\u00E7\u00E3o negada, se utilizada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="idStatusImpressao">C\u00F3digo de Identifica\u00E7\u00E3o do Status Impress\u00E3o (Id)</param>
        /// <returns>Task of ApiResponse (HistoricoImpressaoCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<HistoricoImpressaoCartaoResponse>> AlterarStatusImpressaoAsyncWithHttpInfo (long? id, long? idStatusImpressao)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarStatusImpressao");
            // verify the required parameter 'idStatusImpressao' is set
            if (idStatusImpressao == null) throw new ApiException(400, "Missing required parameter 'idStatusImpressao' when calling AlterarStatusImpressao");
            
    
            var localVarPath = "/api/cartoes/{id}/alterar-status-impressao";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            if (idStatusImpressao != null) localVarQueryParams.Add("id_status_impressao", Configuration.ApiClient.ParameterToString(idStatusImpressao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatusImpressao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatusImpressao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<HistoricoImpressaoCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HistoricoImpressaoCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(HistoricoImpressaoCartaoResponse)));
            
        }
        
        /// <summary>
        /// Realiza a atribui\u00E7\u00E3o de um cart\u00E3o pr\u00E9-pago a uma pessoa Esta m\u00E9todo permite que um cart\u00E3o pr\u00E9-pago impresso de forma avulsa e an\u00F4nimo seja atribu\u00EDdo a uma pessoa para que esta passe a ser a portadora titular dele
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param> 
        /// <param name="idPessoa">C\u00F3digo de identifica\u00E7\u00E3o de uma Pessoa (id)</param> 
        /// <returns>CartaoResponse</returns>
        public CartaoResponse AtribuirPessoa (long? id, long? idPessoa)
        {
             ApiResponse<CartaoResponse> localVarResponse = AtribuirPessoaWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a atribui\u00E7\u00E3o de um cart\u00E3o pr\u00E9-pago a uma pessoa Esta m\u00E9todo permite que um cart\u00E3o pr\u00E9-pago impresso de forma avulsa e an\u00F4nimo seja atribu\u00EDdo a uma pessoa para que esta passe a ser a portadora titular dele
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param> 
        /// <param name="idPessoa">C\u00F3digo de identifica\u00E7\u00E3o de uma Pessoa (id)</param> 
        /// <returns>ApiResponse of CartaoResponse</returns>
        public ApiResponse< CartaoResponse > AtribuirPessoaWithHttpInfo (long? id, long? idPessoa)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->AtribuirPessoa");
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling CartaoApi->AtribuirPessoa");
            
    
            var localVarPath = "/api/cartoes/{id}/atribuir-titular";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirPessoa: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirPessoa: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }

        
        /// <summary>
        /// Realiza a atribui\u00E7\u00E3o de um cart\u00E3o pr\u00E9-pago a uma pessoa Esta m\u00E9todo permite que um cart\u00E3o pr\u00E9-pago impresso de forma avulsa e an\u00F4nimo seja atribu\u00EDdo a uma pessoa para que esta passe a ser a portadora titular dele
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="idPessoa">C\u00F3digo de identifica\u00E7\u00E3o de uma Pessoa (id)</param>
        /// <returns>Task of CartaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoResponse> AtribuirPessoaAsync (long? id, long? idPessoa)
        {
             ApiResponse<CartaoResponse> localVarResponse = await AtribuirPessoaAsyncWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a atribui\u00E7\u00E3o de um cart\u00E3o pr\u00E9-pago a uma pessoa Esta m\u00E9todo permite que um cart\u00E3o pr\u00E9-pago impresso de forma avulsa e an\u00F4nimo seja atribu\u00EDdo a uma pessoa para que esta passe a ser a portadora titular dele
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="idPessoa">C\u00F3digo de identifica\u00E7\u00E3o de uma Pessoa (id)</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> AtribuirPessoaAsyncWithHttpInfo (long? id, long? idPessoa)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtribuirPessoa");
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling AtribuirPessoa");
            
    
            var localVarPath = "/api/cartoes/{id}/atribuir-titular";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirPessoa: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirPessoa: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }
        
        /// <summary>
        /// Realiza o bloqueio de um determinado Cart\u00E3o Este m\u00E9todo permite a realiza\u00E7\u00E3o do bloqueio (tempor\u00E1rio) ou do cancelamento (definitivo) de um determinado cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id). Para isso, \u00E9 preciso informar qual o motivo deste bloqueio que nada mais \u00E9 do que atribuir um novo StatusCartao para ele dentre as op\u00E7\u00F5es praticadas pelo emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param> 
        /// <param name="idStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Novo Status Cart\u00E3o</param> 
        /// <param name="observacao">Texto informando uma observa\u00E7\u00E3o sobre o bloqueio</param> 
        /// <returns>CartaoResponse</returns>
        public CartaoResponse BloquearCartao (long? id, long? idStatus, string observacao)
        {
             ApiResponse<CartaoResponse> localVarResponse = BloquearCartaoWithHttpInfo(id, idStatus, observacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o bloqueio de um determinado Cart\u00E3o Este m\u00E9todo permite a realiza\u00E7\u00E3o do bloqueio (tempor\u00E1rio) ou do cancelamento (definitivo) de um determinado cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id). Para isso, \u00E9 preciso informar qual o motivo deste bloqueio que nada mais \u00E9 do que atribuir um novo StatusCartao para ele dentre as op\u00E7\u00F5es praticadas pelo emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param> 
        /// <param name="idStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Novo Status Cart\u00E3o</param> 
        /// <param name="observacao">Texto informando uma observa\u00E7\u00E3o sobre o bloqueio</param> 
        /// <returns>ApiResponse of CartaoResponse</returns>
        public ApiResponse< CartaoResponse > BloquearCartaoWithHttpInfo (long? id, long? idStatus, string observacao)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->BloquearCartao");
            
            // verify the required parameter 'idStatus' is set
            if (idStatus == null)
                throw new ApiException(400, "Missing required parameter 'idStatus' when calling CartaoApi->BloquearCartao");
            
            // verify the required parameter 'observacao' is set
            if (observacao == null)
                throw new ApiException(400, "Missing required parameter 'observacao' when calling CartaoApi->BloquearCartao");
            
    
            var localVarPath = "/api/cartoes/{id}/bloquear";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (observacao != null) localVarQueryParams.Add("observacao", Configuration.ApiClient.ParameterToString(observacao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling BloquearCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling BloquearCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }

        
        /// <summary>
        /// Realiza o bloqueio de um determinado Cart\u00E3o Este m\u00E9todo permite a realiza\u00E7\u00E3o do bloqueio (tempor\u00E1rio) ou do cancelamento (definitivo) de um determinado cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id). Para isso, \u00E9 preciso informar qual o motivo deste bloqueio que nada mais \u00E9 do que atribuir um novo StatusCartao para ele dentre as op\u00E7\u00F5es praticadas pelo emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="idStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Novo Status Cart\u00E3o</param>
        /// <param name="observacao">Texto informando uma observa\u00E7\u00E3o sobre o bloqueio</param>
        /// <returns>Task of CartaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoResponse> BloquearCartaoAsync (long? id, long? idStatus, string observacao)
        {
             ApiResponse<CartaoResponse> localVarResponse = await BloquearCartaoAsyncWithHttpInfo(id, idStatus, observacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o bloqueio de um determinado Cart\u00E3o Este m\u00E9todo permite a realiza\u00E7\u00E3o do bloqueio (tempor\u00E1rio) ou do cancelamento (definitivo) de um determinado cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id). Para isso, \u00E9 preciso informar qual o motivo deste bloqueio que nada mais \u00E9 do que atribuir um novo StatusCartao para ele dentre as op\u00E7\u00F5es praticadas pelo emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="idStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Novo Status Cart\u00E3o</param>
        /// <param name="observacao">Texto informando uma observa\u00E7\u00E3o sobre o bloqueio</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> BloquearCartaoAsyncWithHttpInfo (long? id, long? idStatus, string observacao)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling BloquearCartao");
            // verify the required parameter 'idStatus' is set
            if (idStatus == null) throw new ApiException(400, "Missing required parameter 'idStatus' when calling BloquearCartao");
            // verify the required parameter 'observacao' is set
            if (observacao == null) throw new ApiException(400, "Missing required parameter 'observacao' when calling BloquearCartao");
            
    
            var localVarPath = "/api/cartoes/{id}/bloquear";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (observacao != null) localVarQueryParams.Add("observacao", Configuration.ApiClient.ParameterToString(observacao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling BloquearCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling BloquearCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro da senha de um Cart\u00E3o Esta opera\u00E7\u00E3o tem como objetivo permitir que o portador de um determinado cart\u00E3o possa definir uma senha a sua escolha
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param> 
        /// <param name="senha">Senha para ser cadastrada ou alterada</param> 
        /// <returns>string</returns>
        public string CadastrarSenha (long? id, string senha)
        {
             ApiResponse<string> localVarResponse = CadastrarSenhaWithHttpInfo(id, senha);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro da senha de um Cart\u00E3o Esta opera\u00E7\u00E3o tem como objetivo permitir que o portador de um determinado cart\u00E3o possa definir uma senha a sua escolha
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param> 
        /// <param name="senha">Senha para ser cadastrada ou alterada</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > CadastrarSenhaWithHttpInfo (long? id, string senha)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->CadastrarSenha");
            
            // verify the required parameter 'senha' is set
            if (senha == null)
                throw new ApiException(400, "Missing required parameter 'senha' when calling CartaoApi->CadastrarSenha");
            
    
            var localVarPath = "/api/cartoes/{id}/cadastrar-senha";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            if (senha != null) localVarHeaderParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // header parameter
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarSenha: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarSenha: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro da senha de um Cart\u00E3o Esta opera\u00E7\u00E3o tem como objetivo permitir que o portador de um determinado cart\u00E3o possa definir uma senha a sua escolha
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="senha">Senha para ser cadastrada ou alterada</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> CadastrarSenhaAsync (long? id, string senha)
        {
             ApiResponse<string> localVarResponse = await CadastrarSenhaAsyncWithHttpInfo(id, senha);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro da senha de um Cart\u00E3o Esta opera\u00E7\u00E3o tem como objetivo permitir que o portador de um determinado cart\u00E3o possa definir uma senha a sua escolha
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="senha">Senha para ser cadastrada ou alterada</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> CadastrarSenhaAsyncWithHttpInfo (long? id, string senha)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CadastrarSenha");
            // verify the required parameter 'senha' is set
            if (senha == null) throw new ApiException(400, "Missing required parameter 'senha' when calling CadastrarSenha");
            
    
            var localVarPath = "/api/cartoes/{id}/cadastrar-senha";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            if (senha != null) localVarHeaderParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // header parameter
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarSenha: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarSenha: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Realiza o cancelamento de um determinado Cart\u00E3o Este m\u00E9todo permite a realiza\u00E7\u00E3o cancelamento de um determinado cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id). Para isso, \u00E9 preciso informar qual o motivo deste bloqueio que nada mais \u00E9 do que atribuir um novo StatusCartao para ele dentre as op\u00E7\u00F5es praticadas pelo emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param> 
        /// <param name="idStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Novo Status Cart\u00E3o</param> 
        /// <param name="observacao">Texto informando uma observa\u00E7\u00E3o sobre o cancelamento</param> 
        /// <returns>CartaoResponse</returns>
        public CartaoResponse CancelarCartao (long? id, long? idStatus, string observacao)
        {
             ApiResponse<CartaoResponse> localVarResponse = CancelarCartaoWithHttpInfo(id, idStatus, observacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cancelamento de um determinado Cart\u00E3o Este m\u00E9todo permite a realiza\u00E7\u00E3o cancelamento de um determinado cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id). Para isso, \u00E9 preciso informar qual o motivo deste bloqueio que nada mais \u00E9 do que atribuir um novo StatusCartao para ele dentre as op\u00E7\u00F5es praticadas pelo emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param> 
        /// <param name="idStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Novo Status Cart\u00E3o</param> 
        /// <param name="observacao">Texto informando uma observa\u00E7\u00E3o sobre o cancelamento</param> 
        /// <returns>ApiResponse of CartaoResponse</returns>
        public ApiResponse< CartaoResponse > CancelarCartaoWithHttpInfo (long? id, long? idStatus, string observacao)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->CancelarCartao");
            
            // verify the required parameter 'idStatus' is set
            if (idStatus == null)
                throw new ApiException(400, "Missing required parameter 'idStatus' when calling CartaoApi->CancelarCartao");
            
            // verify the required parameter 'observacao' is set
            if (observacao == null)
                throw new ApiException(400, "Missing required parameter 'observacao' when calling CartaoApi->CancelarCartao");
            
    
            var localVarPath = "/api/cartoes/{id}/cancelar";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (observacao != null) localVarQueryParams.Add("observacao", Configuration.ApiClient.ParameterToString(observacao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }

        
        /// <summary>
        /// Realiza o cancelamento de um determinado Cart\u00E3o Este m\u00E9todo permite a realiza\u00E7\u00E3o cancelamento de um determinado cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id). Para isso, \u00E9 preciso informar qual o motivo deste bloqueio que nada mais \u00E9 do que atribuir um novo StatusCartao para ele dentre as op\u00E7\u00F5es praticadas pelo emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="idStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Novo Status Cart\u00E3o</param>
        /// <param name="observacao">Texto informando uma observa\u00E7\u00E3o sobre o cancelamento</param>
        /// <returns>Task of CartaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoResponse> CancelarCartaoAsync (long? id, long? idStatus, string observacao)
        {
             ApiResponse<CartaoResponse> localVarResponse = await CancelarCartaoAsyncWithHttpInfo(id, idStatus, observacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cancelamento de um determinado Cart\u00E3o Este m\u00E9todo permite a realiza\u00E7\u00E3o cancelamento de um determinado cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id). Para isso, \u00E9 preciso informar qual o motivo deste bloqueio que nada mais \u00E9 do que atribuir um novo StatusCartao para ele dentre as op\u00E7\u00F5es praticadas pelo emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="idStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Novo Status Cart\u00E3o</param>
        /// <param name="observacao">Texto informando uma observa\u00E7\u00E3o sobre o cancelamento</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> CancelarCartaoAsyncWithHttpInfo (long? id, long? idStatus, string observacao)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CancelarCartao");
            // verify the required parameter 'idStatus' is set
            if (idStatus == null) throw new ApiException(400, "Missing required parameter 'idStatus' when calling CancelarCartao");
            // verify the required parameter 'observacao' is set
            if (observacao == null) throw new ApiException(400, "Missing required parameter 'observacao' when calling CancelarCartao");
            
    
            var localVarPath = "/api/cartoes/{id}/cancelar";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (observacao != null) localVarQueryParams.Add("observacao", Configuration.ApiClient.ParameterToString(observacao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00E3o Este m\u00E9todo permite consultar as informa\u00E7\u00F5es b\u00E1sicas de um determinado Cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param> 
        /// <returns>CartaoDetalheResponse</returns>
        public CartaoDetalheResponse ConsultarCartao (long? id)
        {
             ApiResponse<CartaoDetalheResponse> localVarResponse = ConsultarCartaoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00E3o Este m\u00E9todo permite consultar as informa\u00E7\u00F5es b\u00E1sicas de um determinado Cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param> 
        /// <returns>ApiResponse of CartaoDetalheResponse</returns>
        public ApiResponse< CartaoDetalheResponse > ConsultarCartaoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->ConsultarCartao");
            
    
            var localVarPath = "/api/cartoes/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoDetalheResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00E3o Este m\u00E9todo permite consultar as informa\u00E7\u00F5es b\u00E1sicas de um determinado Cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>Task of CartaoDetalheResponse</returns>
        public async System.Threading.Tasks.Task<CartaoDetalheResponse> ConsultarCartaoAsync (long? id)
        {
             ApiResponse<CartaoDetalheResponse> localVarResponse = await ConsultarCartaoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00E3o Este m\u00E9todo permite consultar as informa\u00E7\u00F5es b\u00E1sicas de um determinado Cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (CartaoDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoDetalheResponse>> ConsultarCartaoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarCartao");
            
    
            var localVarPath = "/api/cartoes/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoDetalheResponse)));
            
        }
        
        /// <summary>
        /// Consultar os dados de impress\u00E3o de um Cart\u00E3o Esse recurso permite consultar os dados de impress\u00E3o de um cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param> 
        /// <returns>DadosCartaoImpressaoResponse</returns>
        public DadosCartaoImpressaoResponse ConsultarDadosImpressao (long? id)
        {
             ApiResponse<DadosCartaoImpressaoResponse> localVarResponse = ConsultarDadosImpressaoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar os dados de impress\u00E3o de um Cart\u00E3o Esse recurso permite consultar os dados de impress\u00E3o de um cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param> 
        /// <returns>ApiResponse of DadosCartaoImpressaoResponse</returns>
        public ApiResponse< DadosCartaoImpressaoResponse > ConsultarDadosImpressaoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->ConsultarDadosImpressao");
            
    
            var localVarPath = "/api/cartoes/{id}/consultar-dados-impressao";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDadosImpressao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDadosImpressao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DadosCartaoImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DadosCartaoImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DadosCartaoImpressaoResponse)));
            
        }

        
        /// <summary>
        /// Consultar os dados de impress\u00E3o de um Cart\u00E3o Esse recurso permite consultar os dados de impress\u00E3o de um cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <returns>Task of DadosCartaoImpressaoResponse</returns>
        public async System.Threading.Tasks.Task<DadosCartaoImpressaoResponse> ConsultarDadosImpressaoAsync (long? id)
        {
             ApiResponse<DadosCartaoImpressaoResponse> localVarResponse = await ConsultarDadosImpressaoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar os dados de impress\u00E3o de um Cart\u00E3o Esse recurso permite consultar os dados de impress\u00E3o de um cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (DadosCartaoImpressaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DadosCartaoImpressaoResponse>> ConsultarDadosImpressaoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarDadosImpressao");
            
    
            var localVarPath = "/api/cartoes/{id}/consultar-dados-impressao";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDadosImpressao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDadosImpressao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DadosCartaoImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DadosCartaoImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DadosCartaoImpressaoResponse)));
            
        }
        
        /// <summary>
        /// Consultar Detalhes do Cart\u00E3o Este m\u00E9todo permite que seja consultado os dados necessarios de um cart\u00E3o para executar servi\u00E7os de autoriza\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>DadosCartaoResponse</returns>
        public DadosCartaoResponse ConsultarDadosReaisCartao (long? id)
        {
             ApiResponse<DadosCartaoResponse> localVarResponse = ConsultarDadosReaisCartaoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar Detalhes do Cart\u00E3o Este m\u00E9todo permite que seja consultado os dados necessarios de um cart\u00E3o para executar servi\u00E7os de autoriza\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>ApiResponse of DadosCartaoResponse</returns>
        public ApiResponse< DadosCartaoResponse > ConsultarDadosReaisCartaoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->ConsultarDadosReaisCartao");
            
    
            var localVarPath = "/api/cartoes/{id}/consultar-dados-reais";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDadosReaisCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDadosReaisCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DadosCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DadosCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DadosCartaoResponse)));
            
        }

        
        /// <summary>
        /// Consultar Detalhes do Cart\u00E3o Este m\u00E9todo permite que seja consultado os dados necessarios de um cart\u00E3o para executar servi\u00E7os de autoriza\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of DadosCartaoResponse</returns>
        public async System.Threading.Tasks.Task<DadosCartaoResponse> ConsultarDadosReaisCartaoAsync (long? id)
        {
             ApiResponse<DadosCartaoResponse> localVarResponse = await ConsultarDadosReaisCartaoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar Detalhes do Cart\u00E3o Este m\u00E9todo permite que seja consultado os dados necessarios de um cart\u00E3o para executar servi\u00E7os de autoriza\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (DadosCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DadosCartaoResponse>> ConsultarDadosReaisCartaoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarDadosReaisCartao");
            
    
            var localVarPath = "/api/cartoes/{id}/consultar-dados-reais";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDadosReaisCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDadosReaisCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DadosCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DadosCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DadosCartaoResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os limites do Portador do Cart\u00E3o Este m\u00E9todo permite consultar os Limites configurados para o Portador de um determinado Cart\u00E3o, seja ele o titular da conta ou um adicional, a partir do c\u00F3digo de identifica\u00E7\u00E3o do Cart\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param> 
        /// <returns>LimiteDisponibilidadeResponse</returns>
        public LimiteDisponibilidadeResponse ConsultarLimitesDisponiveis (long? id)
        {
             ApiResponse<LimiteDisponibilidadeResponse> localVarResponse = ConsultarLimitesDisponiveisWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os limites do Portador do Cart\u00E3o Este m\u00E9todo permite consultar os Limites configurados para o Portador de um determinado Cart\u00E3o, seja ele o titular da conta ou um adicional, a partir do c\u00F3digo de identifica\u00E7\u00E3o do Cart\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param> 
        /// <returns>ApiResponse of LimiteDisponibilidadeResponse</returns>
        public ApiResponse< LimiteDisponibilidadeResponse > ConsultarLimitesDisponiveisWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->ConsultarLimitesDisponiveis");
            
    
            var localVarPath = "/api/cartoes/{id}/limites-disponibilidades";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLimitesDisponiveis: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLimitesDisponiveis: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LimiteDisponibilidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LimiteDisponibilidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimiteDisponibilidadeResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os limites do Portador do Cart\u00E3o Este m\u00E9todo permite consultar os Limites configurados para o Portador de um determinado Cart\u00E3o, seja ele o titular da conta ou um adicional, a partir do c\u00F3digo de identifica\u00E7\u00E3o do Cart\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>Task of LimiteDisponibilidadeResponse</returns>
        public async System.Threading.Tasks.Task<LimiteDisponibilidadeResponse> ConsultarLimitesDisponiveisAsync (long? id)
        {
             ApiResponse<LimiteDisponibilidadeResponse> localVarResponse = await ConsultarLimitesDisponiveisAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os limites do Portador do Cart\u00E3o Este m\u00E9todo permite consultar os Limites configurados para o Portador de um determinado Cart\u00E3o, seja ele o titular da conta ou um adicional, a partir do c\u00F3digo de identifica\u00E7\u00E3o do Cart\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (LimiteDisponibilidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LimiteDisponibilidadeResponse>> ConsultarLimitesDisponiveisAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarLimitesDisponiveis");
            
    
            var localVarPath = "/api/cartoes/{id}/limites-disponibilidades";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLimitesDisponiveis: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLimitesDisponiveis: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LimiteDisponibilidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LimiteDisponibilidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimiteDisponibilidadeResponse)));
            
        }
        
        /// <summary>
        /// Permite consultar um determinado Lote de Cart\u00F5es Pr\u00E9-Pago Este m\u00E9todo permite consultar os cart\u00F5es pr\u00E9-pagos existentes na base do emissor atrav\u00E9s do id do lote
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do lote de cart\u00F5es (id)</param> 
        /// <returns>LoteCartoesPrePagosResponse</returns>
        public LoteCartoesPrePagosResponse ConsultarLoteCartoesPrePagos (long? id)
        {
             ApiResponse<LoteCartoesPrePagosResponse> localVarResponse = ConsultarLoteCartoesPrePagosWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite consultar um determinado Lote de Cart\u00F5es Pr\u00E9-Pago Este m\u00E9todo permite consultar os cart\u00F5es pr\u00E9-pagos existentes na base do emissor atrav\u00E9s do id do lote
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do lote de cart\u00F5es (id)</param> 
        /// <returns>ApiResponse of LoteCartoesPrePagosResponse</returns>
        public ApiResponse< LoteCartoesPrePagosResponse > ConsultarLoteCartoesPrePagosWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->ConsultarLoteCartoesPrePagos");
            
    
            var localVarPath = "/api/cartoes/lotes-cartoes-pre-pagos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLoteCartoesPrePagos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLoteCartoesPrePagos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LoteCartoesPrePagosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LoteCartoesPrePagosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LoteCartoesPrePagosResponse)));
            
        }

        
        /// <summary>
        /// Permite consultar um determinado Lote de Cart\u00F5es Pr\u00E9-Pago Este m\u00E9todo permite consultar os cart\u00F5es pr\u00E9-pagos existentes na base do emissor atrav\u00E9s do id do lote
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do lote de cart\u00F5es (id)</param>
        /// <returns>Task of LoteCartoesPrePagosResponse</returns>
        public async System.Threading.Tasks.Task<LoteCartoesPrePagosResponse> ConsultarLoteCartoesPrePagosAsync (long? id)
        {
             ApiResponse<LoteCartoesPrePagosResponse> localVarResponse = await ConsultarLoteCartoesPrePagosAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite consultar um determinado Lote de Cart\u00F5es Pr\u00E9-Pago Este m\u00E9todo permite consultar os cart\u00F5es pr\u00E9-pagos existentes na base do emissor atrav\u00E9s do id do lote
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do lote de cart\u00F5es (id)</param>
        /// <returns>Task of ApiResponse (LoteCartoesPrePagosResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LoteCartoesPrePagosResponse>> ConsultarLoteCartoesPrePagosAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarLoteCartoesPrePagos");
            
    
            var localVarPath = "/api/cartoes/lotes-cartoes-pre-pagos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLoteCartoesPrePagos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLoteCartoesPrePagos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LoteCartoesPrePagosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LoteCartoesPrePagosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LoteCartoesPrePagosResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados do Portador do Cart\u00E3o Este m\u00E9todo permite consultar as informa\u00E7\u00F5es do Portador de um determinado Cart\u00E3o a partir do c\u00F3digo de identifica\u00E7\u00E3o do Cart\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param> 
        /// <returns>PortadorResponse</returns>
        public PortadorResponse ConsultarPortador (long? id)
        {
             ApiResponse<PortadorResponse> localVarResponse = ConsultarPortadorWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados do Portador do Cart\u00E3o Este m\u00E9todo permite consultar as informa\u00E7\u00F5es do Portador de um determinado Cart\u00E3o a partir do c\u00F3digo de identifica\u00E7\u00E3o do Cart\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param> 
        /// <returns>ApiResponse of PortadorResponse</returns>
        public ApiResponse< PortadorResponse > ConsultarPortadorWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->ConsultarPortador");
            
    
            var localVarPath = "/api/cartoes/{id}/portadores";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPortador: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPortador: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PortadorResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados do Portador do Cart\u00E3o Este m\u00E9todo permite consultar as informa\u00E7\u00F5es do Portador de um determinado Cart\u00E3o a partir do c\u00F3digo de identifica\u00E7\u00E3o do Cart\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>Task of PortadorResponse</returns>
        public async System.Threading.Tasks.Task<PortadorResponse> ConsultarPortadorAsync (long? id)
        {
             ApiResponse<PortadorResponse> localVarResponse = await ConsultarPortadorAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados do Portador do Cart\u00E3o Este m\u00E9todo permite consultar as informa\u00E7\u00F5es do Portador de um determinado Cart\u00E3o a partir do c\u00F3digo de identifica\u00E7\u00E3o do Cart\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (PortadorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PortadorResponse>> ConsultarPortadorAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarPortador");
            
    
            var localVarPath = "/api/cartoes/{id}/portadores";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPortador: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPortador: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PortadorResponse)));
            
        }
        
        /// <summary>
        /// Cadastrar cart\u00F5es MultiApp Este recurso permite o cadastro de cart\u00F5es MultiApp
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartaoMultiAppPersist">cartaoMultiAppPersist</param> 
        /// <returns>VinculoCartoesResponse</returns>
        public VinculoCartoesResponse CriarCartoesMultiApp (CartaoMultiAppPersist cartaoMultiAppPersist)
        {
             ApiResponse<VinculoCartoesResponse> localVarResponse = CriarCartoesMultiAppWithHttpInfo(cartaoMultiAppPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastrar cart\u00F5es MultiApp Este recurso permite o cadastro de cart\u00F5es MultiApp
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartaoMultiAppPersist">cartaoMultiAppPersist</param> 
        /// <returns>ApiResponse of VinculoCartoesResponse</returns>
        public ApiResponse< VinculoCartoesResponse > CriarCartoesMultiAppWithHttpInfo (CartaoMultiAppPersist cartaoMultiAppPersist)
        {
            
            // verify the required parameter 'cartaoMultiAppPersist' is set
            if (cartaoMultiAppPersist == null)
                throw new ApiException(400, "Missing required parameter 'cartaoMultiAppPersist' when calling CartaoApi->CriarCartoesMultiApp");
            
    
            var localVarPath = "/api/cartoes/gerar-cartoes-multiapp";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (cartaoMultiAppPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cartaoMultiAppPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cartaoMultiAppPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CriarCartoesMultiApp: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CriarCartoesMultiApp: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<VinculoCartoesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VinculoCartoesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VinculoCartoesResponse)));
            
        }

        
        /// <summary>
        /// Cadastrar cart\u00F5es MultiApp Este recurso permite o cadastro de cart\u00F5es MultiApp
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartaoMultiAppPersist">cartaoMultiAppPersist</param>
        /// <returns>Task of VinculoCartoesResponse</returns>
        public async System.Threading.Tasks.Task<VinculoCartoesResponse> CriarCartoesMultiAppAsync (CartaoMultiAppPersist cartaoMultiAppPersist)
        {
             ApiResponse<VinculoCartoesResponse> localVarResponse = await CriarCartoesMultiAppAsyncWithHttpInfo(cartaoMultiAppPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastrar cart\u00F5es MultiApp Este recurso permite o cadastro de cart\u00F5es MultiApp
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartaoMultiAppPersist">cartaoMultiAppPersist</param>
        /// <returns>Task of ApiResponse (VinculoCartoesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VinculoCartoesResponse>> CriarCartoesMultiAppAsyncWithHttpInfo (CartaoMultiAppPersist cartaoMultiAppPersist)
        {
            // verify the required parameter 'cartaoMultiAppPersist' is set
            if (cartaoMultiAppPersist == null) throw new ApiException(400, "Missing required parameter 'cartaoMultiAppPersist' when calling CriarCartoesMultiApp");
            
    
            var localVarPath = "/api/cartoes/gerar-cartoes-multiapp";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (cartaoMultiAppPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cartaoMultiAppPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cartaoMultiAppPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CriarCartoesMultiApp: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CriarCartoesMultiApp: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VinculoCartoesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VinculoCartoesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VinculoCartoesResponse)));
            
        }
        
        /// <summary>
        /// Realiza o desbloqueio de um determinado Cart\u00E3o Este m\u00E9todo permite que seja desbloqueado um determinado cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param> 
        /// <returns>CartaoResponse</returns>
        public CartaoResponse DesbloquearCartao (long? id)
        {
             ApiResponse<CartaoResponse> localVarResponse = DesbloquearCartaoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o desbloqueio de um determinado Cart\u00E3o Este m\u00E9todo permite que seja desbloqueado um determinado cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param> 
        /// <returns>ApiResponse of CartaoResponse</returns>
        public ApiResponse< CartaoResponse > DesbloquearCartaoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->DesbloquearCartao");
            
    
            var localVarPath = "/api/cartoes/{id}/desbloquear";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }

        
        /// <summary>
        /// Realiza o desbloqueio de um determinado Cart\u00E3o Este m\u00E9todo permite que seja desbloqueado um determinado cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>Task of CartaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoResponse> DesbloquearCartaoAsync (long? id)
        {
             ApiResponse<CartaoResponse> localVarResponse = await DesbloquearCartaoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o desbloqueio de um determinado Cart\u00E3o Este m\u00E9todo permite que seja desbloqueado um determinado cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> DesbloquearCartaoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesbloquearCartao");
            
    
            var localVarPath = "/api/cartoes/{id}/desbloquear";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }
        
        /// <summary>
        /// Permite gerar um novo Lote de Cart\u00F5es Pr\u00E9-Pago Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores gerem uma determinada quantidade de Cart\u00F5es Pr\u00E9-Pagos, de forma n\u00E3o nominal, os quais poder\u00E3o ser comercializados e posteriormente vinculados a um cliente que o adquirir. Para isso, al\u00E9m de definir quantos cart\u00F5es dever\u00E3o ser gerados, ser\u00E1 poss\u00EDvel definir qual a Origem Comercial, o Produto, o Tipo do Cart\u00E3o, a Imagem e o Endere\u00E7o para entrega dos Cart\u00F5es presentes no lote gerado. Por padr\u00E3o, todos os cart\u00F5es ser\u00E3o associados a um idPessoa fict\u00EDcio e receber\u00E1 um idConta \u00FAnico para cada um deles. Feito isso, os Cart\u00F5es gerados por esta opera\u00E7\u00E3o seguir\u00E3o os mesmos processos de impress\u00E3o via gr\u00E1fica previamente definidos entre o Emissor e a Conductor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idOrigemComercial">C\u00F3digo de Identifica\u00E7\u00E3o da Origem Comercial (id) (optional)</param> 
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (optional)</param> 
        /// <param name="idTipoCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Cart\u00E3o (id) (optional)</param> 
        /// <param name="idImagem">C\u00F3digo de Identifica\u00E7\u00E3o da Imagem (id) (optional)</param> 
        /// <param name="idEndereco">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id) (optional)</param> 
        /// <param name="quantidadeCartoes">N\u00FAmero de cart\u00F5es existentes no Lote (optional)</param> 
        /// <param name="identificadorExterno">N\u00FAmero de identifica\u00E7\u00E3o externo (utilizado pelo emissor) (optional)</param> 
        /// <returns>LoteCartoesPrePagosResponse</returns>
        public LoteCartoesPrePagosResponse GerarLoteCartoesPrePagos (long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string identificadorExterno = null)
        {
             ApiResponse<LoteCartoesPrePagosResponse> localVarResponse = GerarLoteCartoesPrePagosWithHttpInfo(idOrigemComercial, idProduto, idTipoCartao, idImagem, idEndereco, quantidadeCartoes, identificadorExterno);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite gerar um novo Lote de Cart\u00F5es Pr\u00E9-Pago Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores gerem uma determinada quantidade de Cart\u00F5es Pr\u00E9-Pagos, de forma n\u00E3o nominal, os quais poder\u00E3o ser comercializados e posteriormente vinculados a um cliente que o adquirir. Para isso, al\u00E9m de definir quantos cart\u00F5es dever\u00E3o ser gerados, ser\u00E1 poss\u00EDvel definir qual a Origem Comercial, o Produto, o Tipo do Cart\u00E3o, a Imagem e o Endere\u00E7o para entrega dos Cart\u00F5es presentes no lote gerado. Por padr\u00E3o, todos os cart\u00F5es ser\u00E3o associados a um idPessoa fict\u00EDcio e receber\u00E1 um idConta \u00FAnico para cada um deles. Feito isso, os Cart\u00F5es gerados por esta opera\u00E7\u00E3o seguir\u00E3o os mesmos processos de impress\u00E3o via gr\u00E1fica previamente definidos entre o Emissor e a Conductor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idOrigemComercial">C\u00F3digo de Identifica\u00E7\u00E3o da Origem Comercial (id) (optional)</param> 
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (optional)</param> 
        /// <param name="idTipoCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Cart\u00E3o (id) (optional)</param> 
        /// <param name="idImagem">C\u00F3digo de Identifica\u00E7\u00E3o da Imagem (id) (optional)</param> 
        /// <param name="idEndereco">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id) (optional)</param> 
        /// <param name="quantidadeCartoes">N\u00FAmero de cart\u00F5es existentes no Lote (optional)</param> 
        /// <param name="identificadorExterno">N\u00FAmero de identifica\u00E7\u00E3o externo (utilizado pelo emissor) (optional)</param> 
        /// <returns>ApiResponse of LoteCartoesPrePagosResponse</returns>
        public ApiResponse< LoteCartoesPrePagosResponse > GerarLoteCartoesPrePagosWithHttpInfo (long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string identificadorExterno = null)
        {
            
    
            var localVarPath = "/api/cartoes/lotes-cartoes-pre-pagos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (idOrigemComercial != null) localVarQueryParams.Add("idOrigemComercial", Configuration.ApiClient.ParameterToString(idOrigemComercial)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (idTipoCartao != null) localVarQueryParams.Add("idTipoCartao", Configuration.ApiClient.ParameterToString(idTipoCartao)); // query parameter
            if (idImagem != null) localVarQueryParams.Add("idImagem", Configuration.ApiClient.ParameterToString(idImagem)); // query parameter
            if (idEndereco != null) localVarQueryParams.Add("idEndereco", Configuration.ApiClient.ParameterToString(idEndereco)); // query parameter
            if (quantidadeCartoes != null) localVarQueryParams.Add("quantidadeCartoes", Configuration.ApiClient.ParameterToString(quantidadeCartoes)); // query parameter
            if (identificadorExterno != null) localVarQueryParams.Add("identificadorExterno", Configuration.ApiClient.ParameterToString(identificadorExterno)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarLoteCartoesPrePagos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarLoteCartoesPrePagos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LoteCartoesPrePagosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LoteCartoesPrePagosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LoteCartoesPrePagosResponse)));
            
        }

        
        /// <summary>
        /// Permite gerar um novo Lote de Cart\u00F5es Pr\u00E9-Pago Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores gerem uma determinada quantidade de Cart\u00F5es Pr\u00E9-Pagos, de forma n\u00E3o nominal, os quais poder\u00E3o ser comercializados e posteriormente vinculados a um cliente que o adquirir. Para isso, al\u00E9m de definir quantos cart\u00F5es dever\u00E3o ser gerados, ser\u00E1 poss\u00EDvel definir qual a Origem Comercial, o Produto, o Tipo do Cart\u00E3o, a Imagem e o Endere\u00E7o para entrega dos Cart\u00F5es presentes no lote gerado. Por padr\u00E3o, todos os cart\u00F5es ser\u00E3o associados a um idPessoa fict\u00EDcio e receber\u00E1 um idConta \u00FAnico para cada um deles. Feito isso, os Cart\u00F5es gerados por esta opera\u00E7\u00E3o seguir\u00E3o os mesmos processos de impress\u00E3o via gr\u00E1fica previamente definidos entre o Emissor e a Conductor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idOrigemComercial">C\u00F3digo de Identifica\u00E7\u00E3o da Origem Comercial (id) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (optional)</param>
        /// <param name="idTipoCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Cart\u00E3o (id) (optional)</param>
        /// <param name="idImagem">C\u00F3digo de Identifica\u00E7\u00E3o da Imagem (id) (optional)</param>
        /// <param name="idEndereco">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id) (optional)</param>
        /// <param name="quantidadeCartoes">N\u00FAmero de cart\u00F5es existentes no Lote (optional)</param>
        /// <param name="identificadorExterno">N\u00FAmero de identifica\u00E7\u00E3o externo (utilizado pelo emissor) (optional)</param>
        /// <returns>Task of LoteCartoesPrePagosResponse</returns>
        public async System.Threading.Tasks.Task<LoteCartoesPrePagosResponse> GerarLoteCartoesPrePagosAsync (long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string identificadorExterno = null)
        {
             ApiResponse<LoteCartoesPrePagosResponse> localVarResponse = await GerarLoteCartoesPrePagosAsyncWithHttpInfo(idOrigemComercial, idProduto, idTipoCartao, idImagem, idEndereco, quantidadeCartoes, identificadorExterno);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite gerar um novo Lote de Cart\u00F5es Pr\u00E9-Pago Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores gerem uma determinada quantidade de Cart\u00F5es Pr\u00E9-Pagos, de forma n\u00E3o nominal, os quais poder\u00E3o ser comercializados e posteriormente vinculados a um cliente que o adquirir. Para isso, al\u00E9m de definir quantos cart\u00F5es dever\u00E3o ser gerados, ser\u00E1 poss\u00EDvel definir qual a Origem Comercial, o Produto, o Tipo do Cart\u00E3o, a Imagem e o Endere\u00E7o para entrega dos Cart\u00F5es presentes no lote gerado. Por padr\u00E3o, todos os cart\u00F5es ser\u00E3o associados a um idPessoa fict\u00EDcio e receber\u00E1 um idConta \u00FAnico para cada um deles. Feito isso, os Cart\u00F5es gerados por esta opera\u00E7\u00E3o seguir\u00E3o os mesmos processos de impress\u00E3o via gr\u00E1fica previamente definidos entre o Emissor e a Conductor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idOrigemComercial">C\u00F3digo de Identifica\u00E7\u00E3o da Origem Comercial (id) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (optional)</param>
        /// <param name="idTipoCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Cart\u00E3o (id) (optional)</param>
        /// <param name="idImagem">C\u00F3digo de Identifica\u00E7\u00E3o da Imagem (id) (optional)</param>
        /// <param name="idEndereco">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id) (optional)</param>
        /// <param name="quantidadeCartoes">N\u00FAmero de cart\u00F5es existentes no Lote (optional)</param>
        /// <param name="identificadorExterno">N\u00FAmero de identifica\u00E7\u00E3o externo (utilizado pelo emissor) (optional)</param>
        /// <returns>Task of ApiResponse (LoteCartoesPrePagosResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LoteCartoesPrePagosResponse>> GerarLoteCartoesPrePagosAsyncWithHttpInfo (long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string identificadorExterno = null)
        {
            
    
            var localVarPath = "/api/cartoes/lotes-cartoes-pre-pagos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (idOrigemComercial != null) localVarQueryParams.Add("idOrigemComercial", Configuration.ApiClient.ParameterToString(idOrigemComercial)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (idTipoCartao != null) localVarQueryParams.Add("idTipoCartao", Configuration.ApiClient.ParameterToString(idTipoCartao)); // query parameter
            if (idImagem != null) localVarQueryParams.Add("idImagem", Configuration.ApiClient.ParameterToString(idImagem)); // query parameter
            if (idEndereco != null) localVarQueryParams.Add("idEndereco", Configuration.ApiClient.ParameterToString(idEndereco)); // query parameter
            if (quantidadeCartoes != null) localVarQueryParams.Add("quantidadeCartoes", Configuration.ApiClient.ParameterToString(quantidadeCartoes)); // query parameter
            if (identificadorExterno != null) localVarQueryParams.Add("identificadorExterno", Configuration.ApiClient.ParameterToString(identificadorExterno)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarLoteCartoesPrePagos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarLoteCartoesPrePagos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LoteCartoesPrePagosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LoteCartoesPrePagosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LoteCartoesPrePagosResponse)));
            
        }
        
        /// <summary>
        /// Gerar uma nova via de Cart\u00E3o Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores ou seus clientes possam solicitar a gera\u00E7\u00E3o de uma nova via de Cart\u00E3o que ser\u00E1 encaminhando para impress\u00E3o e postagem de acordo com os fluxos padr\u00F5es j\u00E1 definidos pelo emissor. Para isso, \u00E9 preciso que o cliente j\u00E1 possua um cart\u00E3o gerado e informar o C\u00F3digo de Identifica\u00E7\u00E3o deste (idCartao) para que ele possa utilizar esta opera\u00E7\u00E3o. Assim, esta funcionalidade se aplica apenas para a gera\u00E7\u00E3o de cart\u00F5es f\u00EDsicos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param> 
        /// <param name="idImagem">C\u00F3digo de Identifica\u00E7\u00E3o da imagem do cart\u00E3o (id) (optional)</param> 
        /// <returns>CartaoImpressaoResponse</returns>
        public CartaoImpressaoResponse GerarNovaViaCartao (long? id, long? idImagem = null)
        {
             ApiResponse<CartaoImpressaoResponse> localVarResponse = GerarNovaViaCartaoWithHttpInfo(id, idImagem);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gerar uma nova via de Cart\u00E3o Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores ou seus clientes possam solicitar a gera\u00E7\u00E3o de uma nova via de Cart\u00E3o que ser\u00E1 encaminhando para impress\u00E3o e postagem de acordo com os fluxos padr\u00F5es j\u00E1 definidos pelo emissor. Para isso, \u00E9 preciso que o cliente j\u00E1 possua um cart\u00E3o gerado e informar o C\u00F3digo de Identifica\u00E7\u00E3o deste (idCartao) para que ele possa utilizar esta opera\u00E7\u00E3o. Assim, esta funcionalidade se aplica apenas para a gera\u00E7\u00E3o de cart\u00F5es f\u00EDsicos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param> 
        /// <param name="idImagem">C\u00F3digo de Identifica\u00E7\u00E3o da imagem do cart\u00E3o (id) (optional)</param> 
        /// <returns>ApiResponse of CartaoImpressaoResponse</returns>
        public ApiResponse< CartaoImpressaoResponse > GerarNovaViaCartaoWithHttpInfo (long? id, long? idImagem = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->GerarNovaViaCartao");
            
    
            var localVarPath = "/api/cartoes/{id}/gerar-nova-via";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            if (idImagem != null) localVarQueryParams.Add("idImagem", Configuration.ApiClient.ParameterToString(idImagem)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarNovaViaCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarNovaViaCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoImpressaoResponse)));
            
        }

        
        /// <summary>
        /// Gerar uma nova via de Cart\u00E3o Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores ou seus clientes possam solicitar a gera\u00E7\u00E3o de uma nova via de Cart\u00E3o que ser\u00E1 encaminhando para impress\u00E3o e postagem de acordo com os fluxos padr\u00F5es j\u00E1 definidos pelo emissor. Para isso, \u00E9 preciso que o cliente j\u00E1 possua um cart\u00E3o gerado e informar o C\u00F3digo de Identifica\u00E7\u00E3o deste (idCartao) para que ele possa utilizar esta opera\u00E7\u00E3o. Assim, esta funcionalidade se aplica apenas para a gera\u00E7\u00E3o de cart\u00F5es f\u00EDsicos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="idImagem">C\u00F3digo de Identifica\u00E7\u00E3o da imagem do cart\u00E3o (id) (optional)</param>
        /// <returns>Task of CartaoImpressaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoImpressaoResponse> GerarNovaViaCartaoAsync (long? id, long? idImagem = null)
        {
             ApiResponse<CartaoImpressaoResponse> localVarResponse = await GerarNovaViaCartaoAsyncWithHttpInfo(id, idImagem);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gerar uma nova via de Cart\u00E3o Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores ou seus clientes possam solicitar a gera\u00E7\u00E3o de uma nova via de Cart\u00E3o que ser\u00E1 encaminhando para impress\u00E3o e postagem de acordo com os fluxos padr\u00F5es j\u00E1 definidos pelo emissor. Para isso, \u00E9 preciso que o cliente j\u00E1 possua um cart\u00E3o gerado e informar o C\u00F3digo de Identifica\u00E7\u00E3o deste (idCartao) para que ele possa utilizar esta opera\u00E7\u00E3o. Assim, esta funcionalidade se aplica apenas para a gera\u00E7\u00E3o de cart\u00F5es f\u00EDsicos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="idImagem">C\u00F3digo de Identifica\u00E7\u00E3o da imagem do cart\u00E3o (id) (optional)</param>
        /// <returns>Task of ApiResponse (CartaoImpressaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoImpressaoResponse>> GerarNovaViaCartaoAsyncWithHttpInfo (long? id, long? idImagem = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GerarNovaViaCartao");
            
    
            var localVarPath = "/api/cartoes/{id}/gerar-nova-via";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            if (idImagem != null) localVarQueryParams.Add("idImagem", Configuration.ApiClient.ParameterToString(idImagem)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarNovaViaCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarNovaViaCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoImpressaoResponse)));
            
        }
        
        /// <summary>
        /// Gerar nova via de cart\u00E3o m\u00FAltiplo Este recurso permite gerar uma nova via de cart\u00E3o m\u00FAltiplo (com dois produtos relacionados)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param> 
        /// <returns>CartaoMultiAppImpressaoResponse</returns>
        public CartaoMultiAppImpressaoResponse GerarNovaViaCartaoMultiApp (long? id)
        {
             ApiResponse<CartaoMultiAppImpressaoResponse> localVarResponse = GerarNovaViaCartaoMultiAppWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gerar nova via de cart\u00E3o m\u00FAltiplo Este recurso permite gerar uma nova via de cart\u00E3o m\u00FAltiplo (com dois produtos relacionados)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param> 
        /// <returns>ApiResponse of CartaoMultiAppImpressaoResponse</returns>
        public ApiResponse< CartaoMultiAppImpressaoResponse > GerarNovaViaCartaoMultiAppWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->GerarNovaViaCartaoMultiApp");
            
    
            var localVarPath = "/api/cartoes/{id}/gerar-nova-via-multiplo";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GerarNovaViaCartaoMultiApp: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarNovaViaCartaoMultiApp: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoMultiAppImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoMultiAppImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoMultiAppImpressaoResponse)));
            
        }

        
        /// <summary>
        /// Gerar nova via de cart\u00E3o m\u00FAltiplo Este recurso permite gerar uma nova via de cart\u00E3o m\u00FAltiplo (com dois produtos relacionados)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>Task of CartaoMultiAppImpressaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoMultiAppImpressaoResponse> GerarNovaViaCartaoMultiAppAsync (long? id)
        {
             ApiResponse<CartaoMultiAppImpressaoResponse> localVarResponse = await GerarNovaViaCartaoMultiAppAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gerar nova via de cart\u00E3o m\u00FAltiplo Este recurso permite gerar uma nova via de cart\u00E3o m\u00FAltiplo (com dois produtos relacionados)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (CartaoMultiAppImpressaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoMultiAppImpressaoResponse>> GerarNovaViaCartaoMultiAppAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GerarNovaViaCartaoMultiApp");
            
    
            var localVarPath = "/api/cartoes/{id}/gerar-nova-via-multiplo";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GerarNovaViaCartaoMultiApp: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarNovaViaCartaoMultiApp: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoMultiAppImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoMultiAppImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoMultiAppImpressaoResponse)));
            
        }
        
        /// <summary>
        /// Adiciona tarifa de ajuste da segunda via do cart\u00E3o Esse recurso permite adicionar tar\u00EDfa de ajuste pela emiss\u00E3o da segunda via do cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param> 
        /// <returns>Object</returns>
        public Object LancarTarifaReemissao (long? id)
        {
             ApiResponse<Object> localVarResponse = LancarTarifaReemissaoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Adiciona tarifa de ajuste da segunda via do cart\u00E3o Esse recurso permite adicionar tar\u00EDfa de ajuste pela emiss\u00E3o da segunda via do cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > LancarTarifaReemissaoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->LancarTarifaReemissao");
            
    
            var localVarPath = "/api/cartoes/{id}/lancar-tarifa-reemissao";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling LancarTarifaReemissao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling LancarTarifaReemissao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Adiciona tarifa de ajuste da segunda via do cart\u00E3o Esse recurso permite adicionar tar\u00EDfa de ajuste pela emiss\u00E3o da segunda via do cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> LancarTarifaReemissaoAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await LancarTarifaReemissaoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Adiciona tarifa de ajuste da segunda via do cart\u00E3o Esse recurso permite adicionar tar\u00EDfa de ajuste pela emiss\u00E3o da segunda via do cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> LancarTarifaReemissaoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling LancarTarifaReemissao");
            
    
            var localVarPath = "/api/cartoes/{id}/lancar-tarifa-reemissao";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling LancarTarifaReemissao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling LancarTarifaReemissao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Lista os Cart\u00F5es gerados pelo Emissor Este m\u00E9todo permite que sejam listados os cart\u00F5es existentes na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idStatusCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Status do Cart\u00E3o (id) (optional)</param> 
        /// <param name="idEstagioCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Est\u00E1gio de Impress\u00E3o do Cart\u00E3o (id) (optional)</param> 
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta a qual o cart\u00E3o pertence (id) (optional)</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o cart\u00E3o pertence (id) (optional)</param> 
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto a qual o cart\u00E3o pertence (id) (optional)</param> 
        /// <param name="tipoPortador">Mostre o tipo do titular do cart\u00E3o, sendo: (&#39;T&#39;: titular, &#39;A&#39;: adicional) (optional)</param> 
        /// <param name="numeroCartao">Apresenta o n\u00FAmero do cart\u00E3o (optional)</param> 
        /// <param name="nomeImpresso">Apresenta o nome impresso no cart\u00E3o (optional)</param> 
        /// <param name="dataGeracao">Apresenta a data em que o cart\u00E3o foi gerado (optional)</param> 
        /// <param name="dataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00E3o fora aplicado, quando houver (optional)</param> 
        /// <param name="dataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00E3o fora aplicado, quando houver (optional)</param> 
        /// <param name="dataValidade">Mostrar a data da expira\u00E7\u00E3o do cart\u00E3o no formato aaaa-MM, quando houver (optional)</param> 
        /// <param name="dataImpressao">Apresenta a data em que o cart\u00E3o fora impresso, caso impress\u00E3o em loja, ou a data em que ele fora inclu\u00EDdo no arquivo para impress\u00E3o via gr\u00E1fica (optional)</param> 
        /// <param name="arquivoImpressao">Apresenta o nome do arquivo onde o cart\u00E3o fora inclu\u00EDdo para impress\u00E3o por uma gr\u00E1fica, quando houver (optional)</param> 
        /// <param name="flagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00E3o fora impresso na Origem Comercial (optional)</param> 
        /// <param name="flagProvisorio">Quando ativa, indica que o cart\u00E3o \u00E9 provis\u00F3rio. Ou seja, \u00E9 um cart\u00E3o para uso tempor\u00E1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00E3o definitivo (optional)</param> 
        /// <param name="codigoDesbloqueio">Apresenta um c\u00F3digo espec\u00EDfico para ser utilizado como vari\u00E1vel no processo de desbloqueio do cart\u00E3o para emissores que querem usar esta funcionalidade (optional)</param> 
        /// <param name="sequencialCartao">N\u00FAmero sequencial do cart\u00E3o (optional)</param> 
        /// <param name="identificadorExterno">Identificador externo do cart\u00E3o (optional)</param> 
        /// <returns>PageCartaoResponse</returns>
        public PageCartaoResponse ListarCartoes (List<string> sort = null, int? page = null, int? limit = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? sequencialCartao = null, long? identificadorExterno = null)
        {
             ApiResponse<PageCartaoResponse> localVarResponse = ListarCartoesWithHttpInfo(sort, page, limit, idStatusCartao, idEstagioCartao, idConta, idPessoa, idProduto, tipoPortador, numeroCartao, nomeImpresso, dataGeracao, dataStatusCartao, dataEstagioCartao, dataValidade, dataImpressao, arquivoImpressao, flagImpressaoOrigemComercial, flagProvisorio, codigoDesbloqueio, sequencialCartao, identificadorExterno);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Cart\u00F5es gerados pelo Emissor Este m\u00E9todo permite que sejam listados os cart\u00F5es existentes na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idStatusCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Status do Cart\u00E3o (id) (optional)</param> 
        /// <param name="idEstagioCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Est\u00E1gio de Impress\u00E3o do Cart\u00E3o (id) (optional)</param> 
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta a qual o cart\u00E3o pertence (id) (optional)</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o cart\u00E3o pertence (id) (optional)</param> 
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto a qual o cart\u00E3o pertence (id) (optional)</param> 
        /// <param name="tipoPortador">Mostre o tipo do titular do cart\u00E3o, sendo: (&#39;T&#39;: titular, &#39;A&#39;: adicional) (optional)</param> 
        /// <param name="numeroCartao">Apresenta o n\u00FAmero do cart\u00E3o (optional)</param> 
        /// <param name="nomeImpresso">Apresenta o nome impresso no cart\u00E3o (optional)</param> 
        /// <param name="dataGeracao">Apresenta a data em que o cart\u00E3o foi gerado (optional)</param> 
        /// <param name="dataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00E3o fora aplicado, quando houver (optional)</param> 
        /// <param name="dataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00E3o fora aplicado, quando houver (optional)</param> 
        /// <param name="dataValidade">Mostrar a data da expira\u00E7\u00E3o do cart\u00E3o no formato aaaa-MM, quando houver (optional)</param> 
        /// <param name="dataImpressao">Apresenta a data em que o cart\u00E3o fora impresso, caso impress\u00E3o em loja, ou a data em que ele fora inclu\u00EDdo no arquivo para impress\u00E3o via gr\u00E1fica (optional)</param> 
        /// <param name="arquivoImpressao">Apresenta o nome do arquivo onde o cart\u00E3o fora inclu\u00EDdo para impress\u00E3o por uma gr\u00E1fica, quando houver (optional)</param> 
        /// <param name="flagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00E3o fora impresso na Origem Comercial (optional)</param> 
        /// <param name="flagProvisorio">Quando ativa, indica que o cart\u00E3o \u00E9 provis\u00F3rio. Ou seja, \u00E9 um cart\u00E3o para uso tempor\u00E1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00E3o definitivo (optional)</param> 
        /// <param name="codigoDesbloqueio">Apresenta um c\u00F3digo espec\u00EDfico para ser utilizado como vari\u00E1vel no processo de desbloqueio do cart\u00E3o para emissores que querem usar esta funcionalidade (optional)</param> 
        /// <param name="sequencialCartao">N\u00FAmero sequencial do cart\u00E3o (optional)</param> 
        /// <param name="identificadorExterno">Identificador externo do cart\u00E3o (optional)</param> 
        /// <returns>ApiResponse of PageCartaoResponse</returns>
        public ApiResponse< PageCartaoResponse > ListarCartoesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? sequencialCartao = null, long? identificadorExterno = null)
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
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
            if (sequencialCartao != null) localVarQueryParams.Add("sequencialCartao", Configuration.ApiClient.ParameterToString(sequencialCartao)); // query parameter
            if (identificadorExterno != null) localVarQueryParams.Add("identificadorExterno", Configuration.ApiClient.ParameterToString(identificadorExterno)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarCartoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarCartoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCartaoResponse)));
            
        }

        
        /// <summary>
        /// Lista os Cart\u00F5es gerados pelo Emissor Este m\u00E9todo permite que sejam listados os cart\u00F5es existentes na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Status do Cart\u00E3o (id) (optional)</param>
        /// <param name="idEstagioCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Est\u00E1gio de Impress\u00E3o do Cart\u00E3o (id) (optional)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta a qual o cart\u00E3o pertence (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o cart\u00E3o pertence (id) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto a qual o cart\u00E3o pertence (id) (optional)</param>
        /// <param name="tipoPortador">Mostre o tipo do titular do cart\u00E3o, sendo: (&#39;T&#39;: titular, &#39;A&#39;: adicional) (optional)</param>
        /// <param name="numeroCartao">Apresenta o n\u00FAmero do cart\u00E3o (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome impresso no cart\u00E3o (optional)</param>
        /// <param name="dataGeracao">Apresenta a data em que o cart\u00E3o foi gerado (optional)</param>
        /// <param name="dataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00E3o fora aplicado, quando houver (optional)</param>
        /// <param name="dataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00E3o fora aplicado, quando houver (optional)</param>
        /// <param name="dataValidade">Mostrar a data da expira\u00E7\u00E3o do cart\u00E3o no formato aaaa-MM, quando houver (optional)</param>
        /// <param name="dataImpressao">Apresenta a data em que o cart\u00E3o fora impresso, caso impress\u00E3o em loja, ou a data em que ele fora inclu\u00EDdo no arquivo para impress\u00E3o via gr\u00E1fica (optional)</param>
        /// <param name="arquivoImpressao">Apresenta o nome do arquivo onde o cart\u00E3o fora inclu\u00EDdo para impress\u00E3o por uma gr\u00E1fica, quando houver (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00E3o fora impresso na Origem Comercial (optional)</param>
        /// <param name="flagProvisorio">Quando ativa, indica que o cart\u00E3o \u00E9 provis\u00F3rio. Ou seja, \u00E9 um cart\u00E3o para uso tempor\u00E1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00E3o definitivo (optional)</param>
        /// <param name="codigoDesbloqueio">Apresenta um c\u00F3digo espec\u00EDfico para ser utilizado como vari\u00E1vel no processo de desbloqueio do cart\u00E3o para emissores que querem usar esta funcionalidade (optional)</param>
        /// <param name="sequencialCartao">N\u00FAmero sequencial do cart\u00E3o (optional)</param>
        /// <param name="identificadorExterno">Identificador externo do cart\u00E3o (optional)</param>
        /// <returns>Task of PageCartaoResponse</returns>
        public async System.Threading.Tasks.Task<PageCartaoResponse> ListarCartoesAsync (List<string> sort = null, int? page = null, int? limit = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? sequencialCartao = null, long? identificadorExterno = null)
        {
             ApiResponse<PageCartaoResponse> localVarResponse = await ListarCartoesAsyncWithHttpInfo(sort, page, limit, idStatusCartao, idEstagioCartao, idConta, idPessoa, idProduto, tipoPortador, numeroCartao, nomeImpresso, dataGeracao, dataStatusCartao, dataEstagioCartao, dataValidade, dataImpressao, arquivoImpressao, flagImpressaoOrigemComercial, flagProvisorio, codigoDesbloqueio, sequencialCartao, identificadorExterno);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Cart\u00F5es gerados pelo Emissor Este m\u00E9todo permite que sejam listados os cart\u00F5es existentes na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Status do Cart\u00E3o (id) (optional)</param>
        /// <param name="idEstagioCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Est\u00E1gio de Impress\u00E3o do Cart\u00E3o (id) (optional)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta a qual o cart\u00E3o pertence (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o cart\u00E3o pertence (id) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto a qual o cart\u00E3o pertence (id) (optional)</param>
        /// <param name="tipoPortador">Mostre o tipo do titular do cart\u00E3o, sendo: (&#39;T&#39;: titular, &#39;A&#39;: adicional) (optional)</param>
        /// <param name="numeroCartao">Apresenta o n\u00FAmero do cart\u00E3o (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome impresso no cart\u00E3o (optional)</param>
        /// <param name="dataGeracao">Apresenta a data em que o cart\u00E3o foi gerado (optional)</param>
        /// <param name="dataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00E3o fora aplicado, quando houver (optional)</param>
        /// <param name="dataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00E3o fora aplicado, quando houver (optional)</param>
        /// <param name="dataValidade">Mostrar a data da expira\u00E7\u00E3o do cart\u00E3o no formato aaaa-MM, quando houver (optional)</param>
        /// <param name="dataImpressao">Apresenta a data em que o cart\u00E3o fora impresso, caso impress\u00E3o em loja, ou a data em que ele fora inclu\u00EDdo no arquivo para impress\u00E3o via gr\u00E1fica (optional)</param>
        /// <param name="arquivoImpressao">Apresenta o nome do arquivo onde o cart\u00E3o fora inclu\u00EDdo para impress\u00E3o por uma gr\u00E1fica, quando houver (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00E3o fora impresso na Origem Comercial (optional)</param>
        /// <param name="flagProvisorio">Quando ativa, indica que o cart\u00E3o \u00E9 provis\u00F3rio. Ou seja, \u00E9 um cart\u00E3o para uso tempor\u00E1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00E3o definitivo (optional)</param>
        /// <param name="codigoDesbloqueio">Apresenta um c\u00F3digo espec\u00EDfico para ser utilizado como vari\u00E1vel no processo de desbloqueio do cart\u00E3o para emissores que querem usar esta funcionalidade (optional)</param>
        /// <param name="sequencialCartao">N\u00FAmero sequencial do cart\u00E3o (optional)</param>
        /// <param name="identificadorExterno">Identificador externo do cart\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (PageCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCartaoResponse>> ListarCartoesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? sequencialCartao = null, long? identificadorExterno = null)
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
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
            if (sequencialCartao != null) localVarQueryParams.Add("sequencialCartao", Configuration.ApiClient.ParameterToString(sequencialCartao)); // query parameter
            if (identificadorExterno != null) localVarQueryParams.Add("identificadorExterno", Configuration.ApiClient.ParameterToString(identificadorExterno)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarCartoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarCartoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCartaoResponse)));
            
        }
        
        /// <summary>
        /// Permite listar os Lotes de Cart\u00F5es Pr\u00E9-Pago Este m\u00E9todo permite que sejam listados os cart\u00F5es pr\u00E9-pagos existentes na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idOrigemComercial">C\u00F3digo de Identifica\u00E7\u00E3o da Origem Comercial (id) (optional)</param> 
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (optional)</param> 
        /// <param name="idTipoCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Cart\u00E3o (id) (optional)</param> 
        /// <param name="idImagem">C\u00F3digo de Identifica\u00E7\u00E3o da Imagem (id) (optional)</param> 
        /// <param name="idEndereco">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id) (optional)</param> 
        /// <param name="quantidadeCartoes">N\u00FAmero de cart\u00F5es existentes no Lote (optional)</param> 
        /// <param name="dataCadastro">Data de Cadastro do Lote de Cart\u00F5es N\u00E3o Nominais (optional)</param> 
        /// <param name="usuarioCadastro">Nome do Usu\u00E1rio que criou o Lote (optional)</param> 
        /// <param name="statusProcessamento">Indica o Status de Processamento do Lote (optional)</param> 
        /// <param name="identificadorExterno">N\u00FAmero de identifica\u00E7\u00E3o externo (utilizado pelo emissor) (optional)</param> 
        /// <returns>PageLoteCartoesPrePagosResponse</returns>
        public PageLoteCartoesPrePagosResponse ListarLotesCartoesPrePagos (List<string> sort = null, int? page = null, int? limit = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string dataCadastro = null, string usuarioCadastro = null, int? statusProcessamento = null, string identificadorExterno = null)
        {
             ApiResponse<PageLoteCartoesPrePagosResponse> localVarResponse = ListarLotesCartoesPrePagosWithHttpInfo(sort, page, limit, idOrigemComercial, idProduto, idTipoCartao, idImagem, idEndereco, quantidadeCartoes, dataCadastro, usuarioCadastro, statusProcessamento, identificadorExterno);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite listar os Lotes de Cart\u00F5es Pr\u00E9-Pago Este m\u00E9todo permite que sejam listados os cart\u00F5es pr\u00E9-pagos existentes na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idOrigemComercial">C\u00F3digo de Identifica\u00E7\u00E3o da Origem Comercial (id) (optional)</param> 
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (optional)</param> 
        /// <param name="idTipoCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Cart\u00E3o (id) (optional)</param> 
        /// <param name="idImagem">C\u00F3digo de Identifica\u00E7\u00E3o da Imagem (id) (optional)</param> 
        /// <param name="idEndereco">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id) (optional)</param> 
        /// <param name="quantidadeCartoes">N\u00FAmero de cart\u00F5es existentes no Lote (optional)</param> 
        /// <param name="dataCadastro">Data de Cadastro do Lote de Cart\u00F5es N\u00E3o Nominais (optional)</param> 
        /// <param name="usuarioCadastro">Nome do Usu\u00E1rio que criou o Lote (optional)</param> 
        /// <param name="statusProcessamento">Indica o Status de Processamento do Lote (optional)</param> 
        /// <param name="identificadorExterno">N\u00FAmero de identifica\u00E7\u00E3o externo (utilizado pelo emissor) (optional)</param> 
        /// <returns>ApiResponse of PageLoteCartoesPrePagosResponse</returns>
        public ApiResponse< PageLoteCartoesPrePagosResponse > ListarLotesCartoesPrePagosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string dataCadastro = null, string usuarioCadastro = null, int? statusProcessamento = null, string identificadorExterno = null)
        {
            
    
            var localVarPath = "/api/cartoes/lotes-cartoes-pre-pagos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idOrigemComercial != null) localVarQueryParams.Add("idOrigemComercial", Configuration.ApiClient.ParameterToString(idOrigemComercial)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (idTipoCartao != null) localVarQueryParams.Add("idTipoCartao", Configuration.ApiClient.ParameterToString(idTipoCartao)); // query parameter
            if (idImagem != null) localVarQueryParams.Add("idImagem", Configuration.ApiClient.ParameterToString(idImagem)); // query parameter
            if (idEndereco != null) localVarQueryParams.Add("idEndereco", Configuration.ApiClient.ParameterToString(idEndereco)); // query parameter
            if (quantidadeCartoes != null) localVarQueryParams.Add("quantidadeCartoes", Configuration.ApiClient.ParameterToString(quantidadeCartoes)); // query parameter
            if (dataCadastro != null) localVarQueryParams.Add("dataCadastro", Configuration.ApiClient.ParameterToString(dataCadastro)); // query parameter
            if (usuarioCadastro != null) localVarQueryParams.Add("usuarioCadastro", Configuration.ApiClient.ParameterToString(usuarioCadastro)); // query parameter
            if (statusProcessamento != null) localVarQueryParams.Add("statusProcessamento", Configuration.ApiClient.ParameterToString(statusProcessamento)); // query parameter
            if (identificadorExterno != null) localVarQueryParams.Add("identificadorExterno", Configuration.ApiClient.ParameterToString(identificadorExterno)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarLotesCartoesPrePagos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarLotesCartoesPrePagos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageLoteCartoesPrePagosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageLoteCartoesPrePagosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageLoteCartoesPrePagosResponse)));
            
        }

        
        /// <summary>
        /// Permite listar os Lotes de Cart\u00F5es Pr\u00E9-Pago Este m\u00E9todo permite que sejam listados os cart\u00F5es pr\u00E9-pagos existentes na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idOrigemComercial">C\u00F3digo de Identifica\u00E7\u00E3o da Origem Comercial (id) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (optional)</param>
        /// <param name="idTipoCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Cart\u00E3o (id) (optional)</param>
        /// <param name="idImagem">C\u00F3digo de Identifica\u00E7\u00E3o da Imagem (id) (optional)</param>
        /// <param name="idEndereco">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id) (optional)</param>
        /// <param name="quantidadeCartoes">N\u00FAmero de cart\u00F5es existentes no Lote (optional)</param>
        /// <param name="dataCadastro">Data de Cadastro do Lote de Cart\u00F5es N\u00E3o Nominais (optional)</param>
        /// <param name="usuarioCadastro">Nome do Usu\u00E1rio que criou o Lote (optional)</param>
        /// <param name="statusProcessamento">Indica o Status de Processamento do Lote (optional)</param>
        /// <param name="identificadorExterno">N\u00FAmero de identifica\u00E7\u00E3o externo (utilizado pelo emissor) (optional)</param>
        /// <returns>Task of PageLoteCartoesPrePagosResponse</returns>
        public async System.Threading.Tasks.Task<PageLoteCartoesPrePagosResponse> ListarLotesCartoesPrePagosAsync (List<string> sort = null, int? page = null, int? limit = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string dataCadastro = null, string usuarioCadastro = null, int? statusProcessamento = null, string identificadorExterno = null)
        {
             ApiResponse<PageLoteCartoesPrePagosResponse> localVarResponse = await ListarLotesCartoesPrePagosAsyncWithHttpInfo(sort, page, limit, idOrigemComercial, idProduto, idTipoCartao, idImagem, idEndereco, quantidadeCartoes, dataCadastro, usuarioCadastro, statusProcessamento, identificadorExterno);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite listar os Lotes de Cart\u00F5es Pr\u00E9-Pago Este m\u00E9todo permite que sejam listados os cart\u00F5es pr\u00E9-pagos existentes na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idOrigemComercial">C\u00F3digo de Identifica\u00E7\u00E3o da Origem Comercial (id) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (optional)</param>
        /// <param name="idTipoCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Cart\u00E3o (id) (optional)</param>
        /// <param name="idImagem">C\u00F3digo de Identifica\u00E7\u00E3o da Imagem (id) (optional)</param>
        /// <param name="idEndereco">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id) (optional)</param>
        /// <param name="quantidadeCartoes">N\u00FAmero de cart\u00F5es existentes no Lote (optional)</param>
        /// <param name="dataCadastro">Data de Cadastro do Lote de Cart\u00F5es N\u00E3o Nominais (optional)</param>
        /// <param name="usuarioCadastro">Nome do Usu\u00E1rio que criou o Lote (optional)</param>
        /// <param name="statusProcessamento">Indica o Status de Processamento do Lote (optional)</param>
        /// <param name="identificadorExterno">N\u00FAmero de identifica\u00E7\u00E3o externo (utilizado pelo emissor) (optional)</param>
        /// <returns>Task of ApiResponse (PageLoteCartoesPrePagosResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageLoteCartoesPrePagosResponse>> ListarLotesCartoesPrePagosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string dataCadastro = null, string usuarioCadastro = null, int? statusProcessamento = null, string identificadorExterno = null)
        {
            
    
            var localVarPath = "/api/cartoes/lotes-cartoes-pre-pagos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idOrigemComercial != null) localVarQueryParams.Add("idOrigemComercial", Configuration.ApiClient.ParameterToString(idOrigemComercial)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (idTipoCartao != null) localVarQueryParams.Add("idTipoCartao", Configuration.ApiClient.ParameterToString(idTipoCartao)); // query parameter
            if (idImagem != null) localVarQueryParams.Add("idImagem", Configuration.ApiClient.ParameterToString(idImagem)); // query parameter
            if (idEndereco != null) localVarQueryParams.Add("idEndereco", Configuration.ApiClient.ParameterToString(idEndereco)); // query parameter
            if (quantidadeCartoes != null) localVarQueryParams.Add("quantidadeCartoes", Configuration.ApiClient.ParameterToString(quantidadeCartoes)); // query parameter
            if (dataCadastro != null) localVarQueryParams.Add("dataCadastro", Configuration.ApiClient.ParameterToString(dataCadastro)); // query parameter
            if (usuarioCadastro != null) localVarQueryParams.Add("usuarioCadastro", Configuration.ApiClient.ParameterToString(usuarioCadastro)); // query parameter
            if (statusProcessamento != null) localVarQueryParams.Add("statusProcessamento", Configuration.ApiClient.ParameterToString(statusProcessamento)); // query parameter
            if (identificadorExterno != null) localVarQueryParams.Add("identificadorExterno", Configuration.ApiClient.ParameterToString(identificadorExterno)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarLotesCartoesPrePagos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarLotesCartoesPrePagos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageLoteCartoesPrePagosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageLoteCartoesPrePagosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageLoteCartoesPrePagosResponse)));
            
        }
        
        /// <summary>
        /// Realiza a reativa\u00E7\u00E3o de um determinado Cart\u00E3o Este m\u00E9todo permite a realiza\u00E7\u00E3o da reativa\u00E7\u00E3o de um determinado cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param> 
        /// <returns>CartaoResponse</returns>
        public CartaoResponse ReativarCartao (long? id)
        {
             ApiResponse<CartaoResponse> localVarResponse = ReativarCartaoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a reativa\u00E7\u00E3o de um determinado Cart\u00E3o Este m\u00E9todo permite a realiza\u00E7\u00E3o da reativa\u00E7\u00E3o de um determinado cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param> 
        /// <returns>ApiResponse of CartaoResponse</returns>
        public ApiResponse< CartaoResponse > ReativarCartaoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->ReativarCartao");
            
    
            var localVarPath = "/api/cartoes/{id}/reativar";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ReativarCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ReativarCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }

        
        /// <summary>
        /// Realiza a reativa\u00E7\u00E3o de um determinado Cart\u00E3o Este m\u00E9todo permite a realiza\u00E7\u00E3o da reativa\u00E7\u00E3o de um determinado cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>Task of CartaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoResponse> ReativarCartaoAsync (long? id)
        {
             ApiResponse<CartaoResponse> localVarResponse = await ReativarCartaoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a reativa\u00E7\u00E3o de um determinado Cart\u00E3o Este m\u00E9todo permite a realiza\u00E7\u00E3o da reativa\u00E7\u00E3o de um determinado cart\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> ReativarCartaoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReativarCartao");
            
    
            var localVarPath = "/api/cartoes/{id}/reativar";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ReativarCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ReativarCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }
        
        /// <summary>
        /// Realiza o desbloqueio de um cart\u00E3o bloqueado por tentativas de senha incorretas Este m\u00E9todo permite que seja desbloqueado um determinado cart\u00E3o que foi bloqueado por tentativas de senha incorretas, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param> 
        /// <returns>CartaoResponse</returns>
        public CartaoResponse ResetarTentativasSenhaIncorreta (long? id)
        {
             ApiResponse<CartaoResponse> localVarResponse = ResetarTentativasSenhaIncorretaWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o desbloqueio de um cart\u00E3o bloqueado por tentativas de senha incorretas Este m\u00E9todo permite que seja desbloqueado um determinado cart\u00E3o que foi bloqueado por tentativas de senha incorretas, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param> 
        /// <returns>ApiResponse of CartaoResponse</returns>
        public ApiResponse< CartaoResponse > ResetarTentativasSenhaIncorretaWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->ResetarTentativasSenhaIncorreta");
            
    
            var localVarPath = "/api/cartoes/{id}/desbloquear-senha-incorreta";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ResetarTentativasSenhaIncorreta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ResetarTentativasSenhaIncorreta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }

        
        /// <summary>
        /// Realiza o desbloqueio de um cart\u00E3o bloqueado por tentativas de senha incorretas Este m\u00E9todo permite que seja desbloqueado um determinado cart\u00E3o que foi bloqueado por tentativas de senha incorretas, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>Task of CartaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoResponse> ResetarTentativasSenhaIncorretaAsync (long? id)
        {
             ApiResponse<CartaoResponse> localVarResponse = await ResetarTentativasSenhaIncorretaAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o desbloqueio de um cart\u00E3o bloqueado por tentativas de senha incorretas Este m\u00E9todo permite que seja desbloqueado um determinado cart\u00E3o que foi bloqueado por tentativas de senha incorretas, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> ResetarTentativasSenhaIncorretaAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ResetarTentativasSenhaIncorreta");
            
    
            var localVarPath = "/api/cartoes/{id}/desbloquear-senha-incorreta";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ResetarTentativasSenhaIncorreta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ResetarTentativasSenhaIncorreta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }
        
        /// <summary>
        /// Validar CVV do cart\u00E3o Esse recurso permite a valida\u00E7\u00E3o do cvv de um cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param> 
        /// <param name="validaCVV">validaCVV</param> 
        /// <returns>string</returns>
        public string ValidarCVV (long? id, ValidaCVVRequest validaCVV)
        {
             ApiResponse<string> localVarResponse = ValidarCVVWithHttpInfo(id, validaCVV);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Validar CVV do cart\u00E3o Esse recurso permite a valida\u00E7\u00E3o do cvv de um cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param> 
        /// <param name="validaCVV">validaCVV</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ValidarCVVWithHttpInfo (long? id, ValidaCVVRequest validaCVV)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->ValidarCVV");
            
            // verify the required parameter 'validaCVV' is set
            if (validaCVV == null)
                throw new ApiException(400, "Missing required parameter 'validaCVV' when calling CartaoApi->ValidarCVV");
            
    
            var localVarPath = "/api/cartoes/{id}/validar-cvv";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (validaCVV.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(validaCVV); // http body (model) parameter
            }
            else
            {
                localVarPostBody = validaCVV; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarCVV: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarCVV: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Validar CVV do cart\u00E3o Esse recurso permite a valida\u00E7\u00E3o do cvv de um cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="validaCVV">validaCVV</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ValidarCVVAsync (long? id, ValidaCVVRequest validaCVV)
        {
             ApiResponse<string> localVarResponse = await ValidarCVVAsyncWithHttpInfo(id, validaCVV);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Validar CVV do cart\u00E3o Esse recurso permite a valida\u00E7\u00E3o do cvv de um cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="validaCVV">validaCVV</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ValidarCVVAsyncWithHttpInfo (long? id, ValidaCVVRequest validaCVV)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ValidarCVV");
            // verify the required parameter 'validaCVV' is set
            if (validaCVV == null) throw new ApiException(400, "Missing required parameter 'validaCVV' when calling ValidarCVV");
            
    
            var localVarPath = "/api/cartoes/{id}/validar-cvv";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (validaCVV.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(validaCVV); // http body (model) parameter
            }
            else
            {
                localVarPostBody = validaCVV; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarCVV: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarCVV: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Permite validar um Cart\u00E3o com bandeira Mastercard a partir do de55 Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores validem o DE55 gerado a partir da leitura de um chip EMV de um Cart\u00E3o com bandeira Mastercard a fim de verificar a sua autenticidade. A utiliza\u00E7\u00E3o desde m\u00E9todo tem diversas aplica\u00E7\u00F5es, sendo a principal delas a de Identifica\u00E7\u00E3o Positiva do Cart\u00E3o antes de permitir que o portador realize transa\u00E7\u00F5es diversas, como as de compra e saque na modalidade d\u00E9bito em conta corrente, dentre outras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00FAmero do cart\u00E3o a ser validado</param> 
        /// <param name="criptograma">Criptograma do cart\u00E3o no formato de55</param> 
        /// <returns>ValidaCartaoResponse</returns>
        public ValidaCartaoResponse ValidarDE55Mastercard (string numeroCartao, string criptograma)
        {
             ApiResponse<ValidaCartaoResponse> localVarResponse = ValidarDE55MastercardWithHttpInfo(numeroCartao, criptograma);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite validar um Cart\u00E3o com bandeira Mastercard a partir do de55 Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores validem o DE55 gerado a partir da leitura de um chip EMV de um Cart\u00E3o com bandeira Mastercard a fim de verificar a sua autenticidade. A utiliza\u00E7\u00E3o desde m\u00E9todo tem diversas aplica\u00E7\u00F5es, sendo a principal delas a de Identifica\u00E7\u00E3o Positiva do Cart\u00E3o antes de permitir que o portador realize transa\u00E7\u00F5es diversas, como as de compra e saque na modalidade d\u00E9bito em conta corrente, dentre outras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00FAmero do cart\u00E3o a ser validado</param> 
        /// <param name="criptograma">Criptograma do cart\u00E3o no formato de55</param> 
        /// <returns>ApiResponse of ValidaCartaoResponse</returns>
        public ApiResponse< ValidaCartaoResponse > ValidarDE55MastercardWithHttpInfo (string numeroCartao, string criptograma)
        {
            
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null)
                throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling CartaoApi->ValidarDE55Mastercard");
            
            // verify the required parameter 'criptograma' is set
            if (criptograma == null)
                throw new ApiException(400, "Missing required parameter 'criptograma' when calling CartaoApi->ValidarDE55Mastercard");
            
    
            var localVarPath = "/api/cartoes/validar-de55-mastercard";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (numeroCartao != null) localVarQueryParams.Add("numero_cartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            if (criptograma != null) localVarQueryParams.Add("criptograma", Configuration.ApiClient.ParameterToString(criptograma)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDE55Mastercard: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDE55Mastercard: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ValidaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartaoResponse)));
            
        }

        
        /// <summary>
        /// Permite validar um Cart\u00E3o com bandeira Mastercard a partir do de55 Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores validem o DE55 gerado a partir da leitura de um chip EMV de um Cart\u00E3o com bandeira Mastercard a fim de verificar a sua autenticidade. A utiliza\u00E7\u00E3o desde m\u00E9todo tem diversas aplica\u00E7\u00F5es, sendo a principal delas a de Identifica\u00E7\u00E3o Positiva do Cart\u00E3o antes de permitir que o portador realize transa\u00E7\u00F5es diversas, como as de compra e saque na modalidade d\u00E9bito em conta corrente, dentre outras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00FAmero do cart\u00E3o a ser validado</param>
        /// <param name="criptograma">Criptograma do cart\u00E3o no formato de55</param>
        /// <returns>Task of ValidaCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ValidaCartaoResponse> ValidarDE55MastercardAsync (string numeroCartao, string criptograma)
        {
             ApiResponse<ValidaCartaoResponse> localVarResponse = await ValidarDE55MastercardAsyncWithHttpInfo(numeroCartao, criptograma);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite validar um Cart\u00E3o com bandeira Mastercard a partir do de55 Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores validem o DE55 gerado a partir da leitura de um chip EMV de um Cart\u00E3o com bandeira Mastercard a fim de verificar a sua autenticidade. A utiliza\u00E7\u00E3o desde m\u00E9todo tem diversas aplica\u00E7\u00F5es, sendo a principal delas a de Identifica\u00E7\u00E3o Positiva do Cart\u00E3o antes de permitir que o portador realize transa\u00E7\u00F5es diversas, como as de compra e saque na modalidade d\u00E9bito em conta corrente, dentre outras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00FAmero do cart\u00E3o a ser validado</param>
        /// <param name="criptograma">Criptograma do cart\u00E3o no formato de55</param>
        /// <returns>Task of ApiResponse (ValidaCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ValidaCartaoResponse>> ValidarDE55MastercardAsyncWithHttpInfo (string numeroCartao, string criptograma)
        {
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null) throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling ValidarDE55Mastercard");
            // verify the required parameter 'criptograma' is set
            if (criptograma == null) throw new ApiException(400, "Missing required parameter 'criptograma' when calling ValidarDE55Mastercard");
            
    
            var localVarPath = "/api/cartoes/validar-de55-mastercard";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (numeroCartao != null) localVarQueryParams.Add("numero_cartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            if (criptograma != null) localVarQueryParams.Add("criptograma", Configuration.ApiClient.ParameterToString(criptograma)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDE55Mastercard: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDE55Mastercard: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ValidaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartaoResponse)));
            
        }
        
        /// <summary>
        /// Permite validar os dados impressos em um cart\u00E3o bandeirado Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00E3o a partir do envio dos dados sens\u00EDveis impressos nele. A utiliza\u00E7\u00E3o desde m\u00E9todo tem diversas aplica\u00E7\u00F5es, sendo a principal delas a de Identifica\u00E7\u00E3o Positiva do Cart\u00E3o para a realiza\u00E7\u00E3o de transa\u00E7\u00F5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00F4nico (URA), dentre outras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00FAmero do cart\u00E3o a ser validado</param> 
        /// <param name="nomePortador">Nome do portador do cart\u00E3o</param> 
        /// <param name="dataValidade">Data de validade do cart\u00E3o no formato yyyy-MM</param> 
        /// <param name="codigoSeguranca">C\u00F3digo de seguran\u00E7a do cart\u00E3o com tr\u00EAs n\u00FAmeros</param> 
        /// <returns>ValidaCartaoResponse</returns>
        public ValidaCartaoResponse ValidarDadosCartaoBandeirado (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
             ApiResponse<ValidaCartaoResponse> localVarResponse = ValidarDadosCartaoBandeiradoWithHttpInfo(numeroCartao, nomePortador, dataValidade, codigoSeguranca);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite validar os dados impressos em um cart\u00E3o bandeirado Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00E3o a partir do envio dos dados sens\u00EDveis impressos nele. A utiliza\u00E7\u00E3o desde m\u00E9todo tem diversas aplica\u00E7\u00F5es, sendo a principal delas a de Identifica\u00E7\u00E3o Positiva do Cart\u00E3o para a realiza\u00E7\u00E3o de transa\u00E7\u00F5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00F4nico (URA), dentre outras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00FAmero do cart\u00E3o a ser validado</param> 
        /// <param name="nomePortador">Nome do portador do cart\u00E3o</param> 
        /// <param name="dataValidade">Data de validade do cart\u00E3o no formato yyyy-MM</param> 
        /// <param name="codigoSeguranca">C\u00F3digo de seguran\u00E7a do cart\u00E3o com tr\u00EAs n\u00FAmeros</param> 
        /// <returns>ApiResponse of ValidaCartaoResponse</returns>
        public ApiResponse< ValidaCartaoResponse > ValidarDadosCartaoBandeiradoWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
            
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null)
                throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling CartaoApi->ValidarDadosCartaoBandeirado");
            
            // verify the required parameter 'nomePortador' is set
            if (nomePortador == null)
                throw new ApiException(400, "Missing required parameter 'nomePortador' when calling CartaoApi->ValidarDadosCartaoBandeirado");
            
            // verify the required parameter 'dataValidade' is set
            if (dataValidade == null)
                throw new ApiException(400, "Missing required parameter 'dataValidade' when calling CartaoApi->ValidarDadosCartaoBandeirado");
            
            // verify the required parameter 'codigoSeguranca' is set
            if (codigoSeguranca == null)
                throw new ApiException(400, "Missing required parameter 'codigoSeguranca' when calling CartaoApi->ValidarDadosCartaoBandeirado");
            
    
            var localVarPath = "/api/cartoes/validar-dados-impressos-bandeirados";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (numeroCartao != null) localVarQueryParams.Add("numero_cartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            if (nomePortador != null) localVarQueryParams.Add("nome_portador", Configuration.ApiClient.ParameterToString(nomePortador)); // query parameter
            if (dataValidade != null) localVarQueryParams.Add("data_validade", Configuration.ApiClient.ParameterToString(dataValidade)); // query parameter
            if (codigoSeguranca != null) localVarQueryParams.Add("codigo_seguranca", Configuration.ApiClient.ParameterToString(codigoSeguranca)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosCartaoBandeirado: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosCartaoBandeirado: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ValidaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartaoResponse)));
            
        }

        
        /// <summary>
        /// Permite validar os dados impressos em um cart\u00E3o bandeirado Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00E3o a partir do envio dos dados sens\u00EDveis impressos nele. A utiliza\u00E7\u00E3o desde m\u00E9todo tem diversas aplica\u00E7\u00F5es, sendo a principal delas a de Identifica\u00E7\u00E3o Positiva do Cart\u00E3o para a realiza\u00E7\u00E3o de transa\u00E7\u00F5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00F4nico (URA), dentre outras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00FAmero do cart\u00E3o a ser validado</param>
        /// <param name="nomePortador">Nome do portador do cart\u00E3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00E3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00F3digo de seguran\u00E7a do cart\u00E3o com tr\u00EAs n\u00FAmeros</param>
        /// <returns>Task of ValidaCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ValidaCartaoResponse> ValidarDadosCartaoBandeiradoAsync (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
             ApiResponse<ValidaCartaoResponse> localVarResponse = await ValidarDadosCartaoBandeiradoAsyncWithHttpInfo(numeroCartao, nomePortador, dataValidade, codigoSeguranca);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite validar os dados impressos em um cart\u00E3o bandeirado Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00E3o a partir do envio dos dados sens\u00EDveis impressos nele. A utiliza\u00E7\u00E3o desde m\u00E9todo tem diversas aplica\u00E7\u00F5es, sendo a principal delas a de Identifica\u00E7\u00E3o Positiva do Cart\u00E3o para a realiza\u00E7\u00E3o de transa\u00E7\u00F5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00F4nico (URA), dentre outras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00FAmero do cart\u00E3o a ser validado</param>
        /// <param name="nomePortador">Nome do portador do cart\u00E3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00E3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00F3digo de seguran\u00E7a do cart\u00E3o com tr\u00EAs n\u00FAmeros</param>
        /// <returns>Task of ApiResponse (ValidaCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ValidaCartaoResponse>> ValidarDadosCartaoBandeiradoAsyncWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null) throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling ValidarDadosCartaoBandeirado");
            // verify the required parameter 'nomePortador' is set
            if (nomePortador == null) throw new ApiException(400, "Missing required parameter 'nomePortador' when calling ValidarDadosCartaoBandeirado");
            // verify the required parameter 'dataValidade' is set
            if (dataValidade == null) throw new ApiException(400, "Missing required parameter 'dataValidade' when calling ValidarDadosCartaoBandeirado");
            // verify the required parameter 'codigoSeguranca' is set
            if (codigoSeguranca == null) throw new ApiException(400, "Missing required parameter 'codigoSeguranca' when calling ValidarDadosCartaoBandeirado");
            
    
            var localVarPath = "/api/cartoes/validar-dados-impressos-bandeirados";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (numeroCartao != null) localVarQueryParams.Add("numero_cartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            if (nomePortador != null) localVarQueryParams.Add("nome_portador", Configuration.ApiClient.ParameterToString(nomePortador)); // query parameter
            if (dataValidade != null) localVarQueryParams.Add("data_validade", Configuration.ApiClient.ParameterToString(dataValidade)); // query parameter
            if (codigoSeguranca != null) localVarQueryParams.Add("codigo_seguranca", Configuration.ApiClient.ParameterToString(codigoSeguranca)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosCartaoBandeirado: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosCartaoBandeirado: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ValidaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartaoResponse)));
            
        }
        
        /// <summary>
        /// Permite validar os dados impressos de um cartao n\u00E3o bandeirado Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00E3o a partir do envio dos dados sens\u00EDveis impressos nele. A utiliza\u00E7\u00E3o desde m\u00E9todo tem diversas aplica\u00E7\u00F5es, sendo a principal delas a de Identifica\u00E7\u00E3o Positiva do Cart\u00E3o para a realiza\u00E7\u00E3o de transa\u00E7\u00F5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00F4nico (URA), dentre outras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00FAmero do cart\u00E3o a ser validado</param> 
        /// <param name="nomePortador">Nome do portador do cart\u00E3o</param> 
        /// <param name="dataValidade">Data de validade do cart\u00E3o no formato yyyy-MM</param> 
        /// <param name="codigoSeguranca">C\u00F3digo de seguran\u00E7a do cart\u00E3o com tr\u00EAs n\u00FAmeros</param> 
        /// <returns>ValidaCartaoResponse</returns>
        public ValidaCartaoResponse ValidarDadosCartaoPrivate (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
             ApiResponse<ValidaCartaoResponse> localVarResponse = ValidarDadosCartaoPrivateWithHttpInfo(numeroCartao, nomePortador, dataValidade, codigoSeguranca);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite validar os dados impressos de um cartao n\u00E3o bandeirado Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00E3o a partir do envio dos dados sens\u00EDveis impressos nele. A utiliza\u00E7\u00E3o desde m\u00E9todo tem diversas aplica\u00E7\u00F5es, sendo a principal delas a de Identifica\u00E7\u00E3o Positiva do Cart\u00E3o para a realiza\u00E7\u00E3o de transa\u00E7\u00F5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00F4nico (URA), dentre outras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00FAmero do cart\u00E3o a ser validado</param> 
        /// <param name="nomePortador">Nome do portador do cart\u00E3o</param> 
        /// <param name="dataValidade">Data de validade do cart\u00E3o no formato yyyy-MM</param> 
        /// <param name="codigoSeguranca">C\u00F3digo de seguran\u00E7a do cart\u00E3o com tr\u00EAs n\u00FAmeros</param> 
        /// <returns>ApiResponse of ValidaCartaoResponse</returns>
        public ApiResponse< ValidaCartaoResponse > ValidarDadosCartaoPrivateWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
            
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null)
                throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling CartaoApi->ValidarDadosCartaoPrivate");
            
            // verify the required parameter 'nomePortador' is set
            if (nomePortador == null)
                throw new ApiException(400, "Missing required parameter 'nomePortador' when calling CartaoApi->ValidarDadosCartaoPrivate");
            
            // verify the required parameter 'dataValidade' is set
            if (dataValidade == null)
                throw new ApiException(400, "Missing required parameter 'dataValidade' when calling CartaoApi->ValidarDadosCartaoPrivate");
            
            // verify the required parameter 'codigoSeguranca' is set
            if (codigoSeguranca == null)
                throw new ApiException(400, "Missing required parameter 'codigoSeguranca' when calling CartaoApi->ValidarDadosCartaoPrivate");
            
    
            var localVarPath = "/api/cartoes/validar-dados-impressos-nao-bandeirados";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (numeroCartao != null) localVarQueryParams.Add("numero_cartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            if (nomePortador != null) localVarQueryParams.Add("nome_portador", Configuration.ApiClient.ParameterToString(nomePortador)); // query parameter
            if (dataValidade != null) localVarQueryParams.Add("data_validade", Configuration.ApiClient.ParameterToString(dataValidade)); // query parameter
            if (codigoSeguranca != null) localVarQueryParams.Add("codigo_seguranca", Configuration.ApiClient.ParameterToString(codigoSeguranca)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosCartaoPrivate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosCartaoPrivate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ValidaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartaoResponse)));
            
        }

        
        /// <summary>
        /// Permite validar os dados impressos de um cartao n\u00E3o bandeirado Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00E3o a partir do envio dos dados sens\u00EDveis impressos nele. A utiliza\u00E7\u00E3o desde m\u00E9todo tem diversas aplica\u00E7\u00F5es, sendo a principal delas a de Identifica\u00E7\u00E3o Positiva do Cart\u00E3o para a realiza\u00E7\u00E3o de transa\u00E7\u00F5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00F4nico (URA), dentre outras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00FAmero do cart\u00E3o a ser validado</param>
        /// <param name="nomePortador">Nome do portador do cart\u00E3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00E3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00F3digo de seguran\u00E7a do cart\u00E3o com tr\u00EAs n\u00FAmeros</param>
        /// <returns>Task of ValidaCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ValidaCartaoResponse> ValidarDadosCartaoPrivateAsync (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
             ApiResponse<ValidaCartaoResponse> localVarResponse = await ValidarDadosCartaoPrivateAsyncWithHttpInfo(numeroCartao, nomePortador, dataValidade, codigoSeguranca);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite validar os dados impressos de um cartao n\u00E3o bandeirado Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00E3o a partir do envio dos dados sens\u00EDveis impressos nele. A utiliza\u00E7\u00E3o desde m\u00E9todo tem diversas aplica\u00E7\u00F5es, sendo a principal delas a de Identifica\u00E7\u00E3o Positiva do Cart\u00E3o para a realiza\u00E7\u00E3o de transa\u00E7\u00F5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00F4nico (URA), dentre outras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00FAmero do cart\u00E3o a ser validado</param>
        /// <param name="nomePortador">Nome do portador do cart\u00E3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00E3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00F3digo de seguran\u00E7a do cart\u00E3o com tr\u00EAs n\u00FAmeros</param>
        /// <returns>Task of ApiResponse (ValidaCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ValidaCartaoResponse>> ValidarDadosCartaoPrivateAsyncWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null) throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling ValidarDadosCartaoPrivate");
            // verify the required parameter 'nomePortador' is set
            if (nomePortador == null) throw new ApiException(400, "Missing required parameter 'nomePortador' when calling ValidarDadosCartaoPrivate");
            // verify the required parameter 'dataValidade' is set
            if (dataValidade == null) throw new ApiException(400, "Missing required parameter 'dataValidade' when calling ValidarDadosCartaoPrivate");
            // verify the required parameter 'codigoSeguranca' is set
            if (codigoSeguranca == null) throw new ApiException(400, "Missing required parameter 'codigoSeguranca' when calling ValidarDadosCartaoPrivate");
            
    
            var localVarPath = "/api/cartoes/validar-dados-impressos-nao-bandeirados";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (numeroCartao != null) localVarQueryParams.Add("numero_cartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            if (nomePortador != null) localVarQueryParams.Add("nome_portador", Configuration.ApiClient.ParameterToString(nomePortador)); // query parameter
            if (dataValidade != null) localVarQueryParams.Add("data_validade", Configuration.ApiClient.ParameterToString(dataValidade)); // query parameter
            if (codigoSeguranca != null) localVarQueryParams.Add("codigo_seguranca", Configuration.ApiClient.ParameterToString(codigoSeguranca)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosCartaoPrivate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosCartaoPrivate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ValidaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartaoResponse)));
            
        }
        
        /// <summary>
        /// Permite validar a senha de um Cart\u00E3o Esta opera\u00E7\u00E3o tem como objetivo permitir validar que a senha informada pelo portador de um determinado cart\u00E3o est\u00E1 correta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param> 
        /// <param name="senhaDTO">Representa o DTO de senha para usu\u00E1rio</param> 
        /// <returns>ValidaSenhaCartaoResponse</returns>
        public ValidaSenhaCartaoResponse ValidarSenha (long? id, SenhaDTO senhaDTO)
        {
             ApiResponse<ValidaSenhaCartaoResponse> localVarResponse = ValidarSenhaWithHttpInfo(id, senhaDTO);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite validar a senha de um Cart\u00E3o Esta opera\u00E7\u00E3o tem como objetivo permitir validar que a senha informada pelo portador de um determinado cart\u00E3o est\u00E1 correta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param> 
        /// <param name="senhaDTO">Representa o DTO de senha para usu\u00E1rio</param> 
        /// <returns>ApiResponse of ValidaSenhaCartaoResponse</returns>
        public ApiResponse< ValidaSenhaCartaoResponse > ValidarSenhaWithHttpInfo (long? id, SenhaDTO senhaDTO)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->ValidarSenha");
            
            // verify the required parameter 'senhaDTO' is set
            if (senhaDTO == null)
                throw new ApiException(400, "Missing required parameter 'senhaDTO' when calling CartaoApi->ValidarSenha");
            
    
            var localVarPath = "/api/cartoes/{id}/validar-senha";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (senhaDTO.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(senhaDTO); // http body (model) parameter
            }
            else
            {
                localVarPostBody = senhaDTO; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenha: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenha: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ValidaSenhaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaSenhaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaSenhaCartaoResponse)));
            
        }

        
        /// <summary>
        /// Permite validar a senha de um Cart\u00E3o Esta opera\u00E7\u00E3o tem como objetivo permitir validar que a senha informada pelo portador de um determinado cart\u00E3o est\u00E1 correta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="senhaDTO">Representa o DTO de senha para usu\u00E1rio</param>
        /// <returns>Task of ValidaSenhaCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ValidaSenhaCartaoResponse> ValidarSenhaAsync (long? id, SenhaDTO senhaDTO)
        {
             ApiResponse<ValidaSenhaCartaoResponse> localVarResponse = await ValidarSenhaAsyncWithHttpInfo(id, senhaDTO);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite validar a senha de um Cart\u00E3o Esta opera\u00E7\u00E3o tem como objetivo permitir validar que a senha informada pelo portador de um determinado cart\u00E3o est\u00E1 correta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id)</param>
        /// <param name="senhaDTO">Representa o DTO de senha para usu\u00E1rio</param>
        /// <returns>Task of ApiResponse (ValidaSenhaCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ValidaSenhaCartaoResponse>> ValidarSenhaAsyncWithHttpInfo (long? id, SenhaDTO senhaDTO)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ValidarSenha");
            // verify the required parameter 'senhaDTO' is set
            if (senhaDTO == null) throw new ApiException(400, "Missing required parameter 'senhaDTO' when calling ValidarSenha");
            
    
            var localVarPath = "/api/cartoes/{id}/validar-senha";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (senhaDTO.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(senhaDTO); // http body (model) parameter
            }
            else
            {
                localVarPostBody = senhaDTO; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenha: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenha: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ValidaSenhaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaSenhaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaSenhaCartaoResponse)));
            
        }
        
        /// <summary>
        /// Permite validar um Cart\u00E3o Bandeirado a partir da Tarja Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00E3o a partir da leitura da tarja magn\u00E9tica do mesmo. A utiliza\u00E7\u00E3o desde m\u00E9todo tem diversas aplica\u00E7\u00F5es, sendo a principal delas a de Identifica\u00E7\u00E3o Positiva do Cart\u00E3o antes de permitir que o portador realize transa\u00E7\u00F5es diversas, como as de compra e saque na modalidade d\u00E9bito em conta corrente, dentre outras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00FAmero do cart\u00E3o a ser validado</param> 
        /// <param name="trilha1">Trilha 1 do cart\u00E3o a ser validado</param> 
        /// <param name="trilha2">Trilha 2 do cart\u00E3o a ser validado</param> 
        /// <returns>ValidaCartaoResponse</returns>
        public ValidaCartaoResponse ValidarTarja (string numeroCartao, string trilha1, string trilha2)
        {
             ApiResponse<ValidaCartaoResponse> localVarResponse = ValidarTarjaWithHttpInfo(numeroCartao, trilha1, trilha2);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite validar um Cart\u00E3o Bandeirado a partir da Tarja Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00E3o a partir da leitura da tarja magn\u00E9tica do mesmo. A utiliza\u00E7\u00E3o desde m\u00E9todo tem diversas aplica\u00E7\u00F5es, sendo a principal delas a de Identifica\u00E7\u00E3o Positiva do Cart\u00E3o antes de permitir que o portador realize transa\u00E7\u00F5es diversas, como as de compra e saque na modalidade d\u00E9bito em conta corrente, dentre outras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00FAmero do cart\u00E3o a ser validado</param> 
        /// <param name="trilha1">Trilha 1 do cart\u00E3o a ser validado</param> 
        /// <param name="trilha2">Trilha 2 do cart\u00E3o a ser validado</param> 
        /// <returns>ApiResponse of ValidaCartaoResponse</returns>
        public ApiResponse< ValidaCartaoResponse > ValidarTarjaWithHttpInfo (string numeroCartao, string trilha1, string trilha2)
        {
            
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null)
                throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling CartaoApi->ValidarTarja");
            
            // verify the required parameter 'trilha1' is set
            if (trilha1 == null)
                throw new ApiException(400, "Missing required parameter 'trilha1' when calling CartaoApi->ValidarTarja");
            
            // verify the required parameter 'trilha2' is set
            if (trilha2 == null)
                throw new ApiException(400, "Missing required parameter 'trilha2' when calling CartaoApi->ValidarTarja");
            
    
            var localVarPath = "/api/cartoes/validar-tarja";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (numeroCartao != null) localVarQueryParams.Add("numero_cartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            if (trilha1 != null) localVarQueryParams.Add("trilha1", Configuration.ApiClient.ParameterToString(trilha1)); // query parameter
            if (trilha2 != null) localVarQueryParams.Add("trilha2", Configuration.ApiClient.ParameterToString(trilha2)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarTarja: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarTarja: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ValidaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartaoResponse)));
            
        }

        
        /// <summary>
        /// Permite validar um Cart\u00E3o Bandeirado a partir da Tarja Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00E3o a partir da leitura da tarja magn\u00E9tica do mesmo. A utiliza\u00E7\u00E3o desde m\u00E9todo tem diversas aplica\u00E7\u00F5es, sendo a principal delas a de Identifica\u00E7\u00E3o Positiva do Cart\u00E3o antes de permitir que o portador realize transa\u00E7\u00F5es diversas, como as de compra e saque na modalidade d\u00E9bito em conta corrente, dentre outras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00FAmero do cart\u00E3o a ser validado</param>
        /// <param name="trilha1">Trilha 1 do cart\u00E3o a ser validado</param>
        /// <param name="trilha2">Trilha 2 do cart\u00E3o a ser validado</param>
        /// <returns>Task of ValidaCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ValidaCartaoResponse> ValidarTarjaAsync (string numeroCartao, string trilha1, string trilha2)
        {
             ApiResponse<ValidaCartaoResponse> localVarResponse = await ValidarTarjaAsyncWithHttpInfo(numeroCartao, trilha1, trilha2);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite validar um Cart\u00E3o Bandeirado a partir da Tarja Esta opera\u00E7\u00E3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00E3o a partir da leitura da tarja magn\u00E9tica do mesmo. A utiliza\u00E7\u00E3o desde m\u00E9todo tem diversas aplica\u00E7\u00F5es, sendo a principal delas a de Identifica\u00E7\u00E3o Positiva do Cart\u00E3o antes de permitir que o portador realize transa\u00E7\u00F5es diversas, como as de compra e saque na modalidade d\u00E9bito em conta corrente, dentre outras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00FAmero do cart\u00E3o a ser validado</param>
        /// <param name="trilha1">Trilha 1 do cart\u00E3o a ser validado</param>
        /// <param name="trilha2">Trilha 2 do cart\u00E3o a ser validado</param>
        /// <returns>Task of ApiResponse (ValidaCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ValidaCartaoResponse>> ValidarTarjaAsyncWithHttpInfo (string numeroCartao, string trilha1, string trilha2)
        {
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null) throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling ValidarTarja");
            // verify the required parameter 'trilha1' is set
            if (trilha1 == null) throw new ApiException(400, "Missing required parameter 'trilha1' when calling ValidarTarja");
            // verify the required parameter 'trilha2' is set
            if (trilha2 == null) throw new ApiException(400, "Missing required parameter 'trilha2' when calling ValidarTarja");
            
    
            var localVarPath = "/api/cartoes/validar-tarja";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (numeroCartao != null) localVarQueryParams.Add("numero_cartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            if (trilha1 != null) localVarQueryParams.Add("trilha1", Configuration.ApiClient.ParameterToString(trilha1)); // query parameter
            if (trilha2 != null) localVarQueryParams.Add("trilha2", Configuration.ApiClient.ParameterToString(trilha2)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarTarja: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarTarja: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ValidaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartaoResponse)));
            
        }
        
    }
    
}
