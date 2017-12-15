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
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o da senha de um Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que o portador de um determinado cart\u00C3\u00A3o possa definir uma senha a sua escolha.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="senha">Senha para ser cadastrada ou alterada.</param>
        /// <returns>string</returns>
        string AlterarAlterarSenhaUsingPUT (long? id, string senha);
  
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o da senha de um Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que o portador de um determinado cart\u00C3\u00A3o possa definir uma senha a sua escolha.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="senha">Senha para ser cadastrada ou alterada.</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> AlterarAlterarSenhaUsingPUTWithHttpInfo (long? id, string senha);
        
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que uma Aplica\u00C3\u00A7\u00C3\u00A3o que realize a impress\u00C3\u00A3o de cart\u00C3\u00B5es possa indicar que um determinado idCartao fora impresso ou est\u00C3\u00A1 em processo de impress\u00C3\u00A3o. Para isso, basta informar o respectivo c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id) que deseja ter seu um determinado id_status_impressao atribu\u00C3\u00ADdo a ele. Por padr\u00C3\u00A3o, cart\u00C3\u00B5es provis\u00C3\u00B3rios ou que j\u00C3\u00A1 tenham sido inclu\u00C3\u00ADdos em um arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica ter\u00C3\u00A3o esta requisi\u00C3\u00A7\u00C3\u00A3o negada, se utilizada.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="idStatusImpressao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status Impress\u00C3\u00A3o (Id).</param>
        /// <returns>HistoricoImpressaoCartaoResponse</returns>
        HistoricoImpressaoCartaoResponse AlterarStatusImpressaoUsingPUT (long? id, long? idStatusImpressao);
  
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que uma Aplica\u00C3\u00A7\u00C3\u00A3o que realize a impress\u00C3\u00A3o de cart\u00C3\u00B5es possa indicar que um determinado idCartao fora impresso ou est\u00C3\u00A1 em processo de impress\u00C3\u00A3o. Para isso, basta informar o respectivo c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id) que deseja ter seu um determinado id_status_impressao atribu\u00C3\u00ADdo a ele. Por padr\u00C3\u00A3o, cart\u00C3\u00B5es provis\u00C3\u00B3rios ou que j\u00C3\u00A1 tenham sido inclu\u00C3\u00ADdos em um arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica ter\u00C3\u00A3o esta requisi\u00C3\u00A7\u00C3\u00A3o negada, se utilizada.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="idStatusImpressao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status Impress\u00C3\u00A3o (Id).</param>
        /// <returns>ApiResponse of HistoricoImpressaoCartaoResponse</returns>
        ApiResponse<HistoricoImpressaoCartaoResponse> AlterarStatusImpressaoUsingPUTWithHttpInfo (long? id, long? idStatusImpressao);
        
        /// <summary>
        /// Realiza a atribui\u00C3\u00A7\u00C3\u00A3o de um cart\u00C3\u00A3o pr\u00C3\u00A9-pago a uma pessoa
        /// </summary>
        /// <remarks>
        /// Esta m\u00C3\u00A9todo permite que um cart\u00C3\u00A3o pr\u00C3\u00A9-pago impresso de forma avulsa e an\u00C3\u00B4nimo seja atribu\u00C3\u00ADdo a uma pessoa para que esta passe a ser a portadora titular dele.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o de uma Pessoa (id).</param>
        /// <returns>CartaoResponse</returns>
        CartaoResponse AtribuirPessoaUsingPUT (long? id, long? idPessoa);
  
        /// <summary>
        /// Realiza a atribui\u00C3\u00A7\u00C3\u00A3o de um cart\u00C3\u00A3o pr\u00C3\u00A9-pago a uma pessoa
        /// </summary>
        /// <remarks>
        /// Esta m\u00C3\u00A9todo permite que um cart\u00C3\u00A3o pr\u00C3\u00A9-pago impresso de forma avulsa e an\u00C3\u00B4nimo seja atribu\u00C3\u00ADdo a uma pessoa para que esta passe a ser a portadora titular dele.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o de uma Pessoa (id).</param>
        /// <returns>ApiResponse of CartaoResponse</returns>
        ApiResponse<CartaoResponse> AtribuirPessoaUsingPUTWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// Realiza o bloqueio de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o do bloqueio (tempor\u00C3\u00A1rio) ou do cancelamento (definitivo) de um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id). Para isso, \u00C3\u00A9 preciso informar qual o motivo deste bloqueio que nada mais \u00C3\u00A9 do que atribuir um novo StatusCartao para ele dentre as op\u00C3\u00A7\u00C3\u00B5es praticadas pelo emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Cart\u00C3\u00A3o.</param>
        /// <param name="observacao">Texto informando uma observa\u00C3\u00A7\u00C3\u00A3o sobre o bloqueio.</param>
        /// <returns>CartaoResponse</returns>
        CartaoResponse BloquearUsingPOST (long? id, long? idStatus, string observacao);
  
        /// <summary>
        /// Realiza o bloqueio de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o do bloqueio (tempor\u00C3\u00A1rio) ou do cancelamento (definitivo) de um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id). Para isso, \u00C3\u00A9 preciso informar qual o motivo deste bloqueio que nada mais \u00C3\u00A9 do que atribuir um novo StatusCartao para ele dentre as op\u00C3\u00A7\u00C3\u00B5es praticadas pelo emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Cart\u00C3\u00A3o.</param>
        /// <param name="observacao">Texto informando uma observa\u00C3\u00A7\u00C3\u00A3o sobre o bloqueio.</param>
        /// <returns>ApiResponse of CartaoResponse</returns>
        ApiResponse<CartaoResponse> BloquearUsingPOSTWithHttpInfo (long? id, long? idStatus, string observacao);
        
        /// <summary>
        /// Realiza o cadastro da senha de um Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que o portador de um determinado cart\u00C3\u00A3o possa definir uma senha a sua escolha.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="senha">Senha para ser cadastrada ou alterada.</param>
        /// <returns>string</returns>
        string CadastrarAlterarSenhaUsingPOST (long? id, string senha);
  
        /// <summary>
        /// Realiza o cadastro da senha de um Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que o portador de um determinado cart\u00C3\u00A3o possa definir uma senha a sua escolha.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="senha">Senha para ser cadastrada ou alterada.</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> CadastrarAlterarSenhaUsingPOSTWithHttpInfo (long? id, string senha);
        
        /// <summary>
        /// Realiza o cancelamento de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o cancelamento de um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id). Para isso, \u00C3\u00A9 preciso informar qual o motivo deste bloqueio que nada mais \u00C3\u00A9 do que atribuir um novo StatusCartao para ele dentre as op\u00C3\u00A7\u00C3\u00B5es praticadas pelo emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Cart\u00C3\u00A3o.</param>
        /// <param name="observacao">Texto informando uma observa\u00C3\u00A7\u00C3\u00A3o sobre o cancelamento.</param>
        /// <returns>CartaoResponse</returns>
        CartaoResponse CancelarUsingPOST (long? id, long? idStatus, string observacao);
  
        /// <summary>
        /// Realiza o cancelamento de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o cancelamento de um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id). Para isso, \u00C3\u00A9 preciso informar qual o motivo deste bloqueio que nada mais \u00C3\u00A9 do que atribuir um novo StatusCartao para ele dentre as op\u00C3\u00A7\u00C3\u00B5es praticadas pelo emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Cart\u00C3\u00A3o.</param>
        /// <param name="observacao">Texto informando uma observa\u00C3\u00A7\u00C3\u00A3o sobre o cancelamento.</param>
        /// <returns>ApiResponse of CartaoResponse</returns>
        ApiResponse<CartaoResponse> CancelarUsingPOSTWithHttpInfo (long? id, long? idStatus, string observacao);
        
        /// <summary>
        /// Consultar os dados de impress\u00C3\u00A3o de um Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar os dados de impress\u00C3\u00A3o de um cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id).</param>
        /// <returns>DadosCartaoImpressaoResponse</returns>
        DadosCartaoImpressaoResponse ConsultarCartaoImpressaoUsingGET (long? id);
  
        /// <summary>
        /// Consultar os dados de impress\u00C3\u00A3o de um Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar os dados de impress\u00C3\u00A3o de um cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id).</param>
        /// <returns>ApiResponse of DadosCartaoImpressaoResponse</returns>
        ApiResponse<DadosCartaoImpressaoResponse> ConsultarCartaoImpressaoUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar Detalhes do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja consultado os dados necessarios de um cart\u00C3\u00A3o para executar servi\u00C3\u00A7os de autoriza\u00C3\u00A7\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>DadosCartaoResponse</returns>
        DadosCartaoResponse ConsultarDadosReaisCartaoUsingGET (long? id);
  
        /// <summary>
        /// Consultar Detalhes do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja consultado os dados necessarios de um cart\u00C3\u00A3o para executar servi\u00C3\u00A7os de autoriza\u00C3\u00A7\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>ApiResponse of DadosCartaoResponse</returns>
        ApiResponse<DadosCartaoResponse> ConsultarDadosReaisCartaoUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os limites do Portador do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os Limites configurados para o Portador de um determinado Cart\u00C3\u00A3o, seja ele o titular da conta ou um adicional, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>LimiteDisponibilidadeResponse</returns>
        LimiteDisponibilidadeResponse ConsultarLimiteDisponibilidadeUsingGET (long? id);
  
        /// <summary>
        /// Apresenta os limites do Portador do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os Limites configurados para o Portador de um determinado Cart\u00C3\u00A3o, seja ele o titular da conta ou um adicional, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>ApiResponse of LimiteDisponibilidadeResponse</returns>
        ApiResponse<LimiteDisponibilidadeResponse> ConsultarLimiteDisponibilidadeUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// Permite consultar um determinado Lote de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pago
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os cart\u00C3\u00B5es pr\u00C3\u00A9-pagos existentes na base do emissor atrav\u00C3\u00A9s do id do lote.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do lote de cart\u00C3\u00B5es (id)</param>
        /// <returns>LoteCartoesPrePagosResponse</returns>
        LoteCartoesPrePagosResponse ConsultarLotesCartoesPrePagosUsingGET (long? id);
  
        /// <summary>
        /// Permite consultar um determinado Lote de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pago
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os cart\u00C3\u00B5es pr\u00C3\u00A9-pagos existentes na base do emissor atrav\u00C3\u00A9s do id do lote.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do lote de cart\u00C3\u00B5es (id)</param>
        /// <returns>ApiResponse of LoteCartoesPrePagosResponse</returns>
        ApiResponse<LoteCartoesPrePagosResponse> ConsultarLotesCartoesPrePagosUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados do Portador do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es do Portador de um determinado Cart\u00C3\u00A3o a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>PortadorResponse</returns>
        PortadorResponse ConsultarPortadorUsingGET (long? id);
  
        /// <summary>
        /// Apresenta os dados do Portador do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es do Portador de um determinado Cart\u00C3\u00A3o a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>ApiResponse of PortadorResponse</returns>
        ApiResponse<PortadorResponse> ConsultarPortadorUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es b\u00C3\u00A1sicas de um determinado Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>CartaoDetalheResponse</returns>
        CartaoDetalheResponse ConsultarUsingGET7 (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es b\u00C3\u00A1sicas de um determinado Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>ApiResponse of CartaoDetalheResponse</returns>
        ApiResponse<CartaoDetalheResponse> ConsultarUsingGET7WithHttpInfo (long? id);
        
        /// <summary>
        /// Realiza o desbloqueio de um cart\u00C3\u00A3o bloqueado por tentativas de senha incorretas
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja desbloqueado um determinado cart\u00C3\u00A3o que foi bloqueado por tentativas de senha incorretas, a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>CartaoResponse</returns>
        CartaoResponse DesbloquearSenhaIncorretaUsingPOST (long? id);
  
        /// <summary>
        /// Realiza o desbloqueio de um cart\u00C3\u00A3o bloqueado por tentativas de senha incorretas
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja desbloqueado um determinado cart\u00C3\u00A3o que foi bloqueado por tentativas de senha incorretas, a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>ApiResponse of CartaoResponse</returns>
        ApiResponse<CartaoResponse> DesbloquearSenhaIncorretaUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// Realiza o desbloqueio de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja desbloqueado um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>CartaoResponse</returns>
        CartaoResponse DesbloquearUsingPOST (long? id);
  
        /// <summary>
        /// Realiza o desbloqueio de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja desbloqueado um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>ApiResponse of CartaoResponse</returns>
        ApiResponse<CartaoResponse> DesbloquearUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// Permite gerar um novo Lote de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pago
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores gerem uma determinada quantidade de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pagos, de forma n\u00C3\u00A3o nominal, os quais poder\u00C3\u00A3o ser comercializados e posteriormente vinculados a um cliente que o adquirir. Para isso, al\u00C3\u00A9m de definir quantos cart\u00C3\u00B5es dever\u00C3\u00A3o ser gerados, ser\u00C3\u00A1 poss\u00C3\u00ADvel definir qual a Origem Comercial, o Produto, o Tipo do Cart\u00C3\u00A3o, a Imagem e o Endere\u00C3\u00A7o para entrega dos Cart\u00C3\u00B5es presentes no lote gerado. Por padr\u00C3\u00A3o, todos os cart\u00C3\u00B5es ser\u00C3\u00A3o associados a um idPessoa fict\u00C3\u00ADcio e receber\u00C3\u00A1 um idConta \u00C3\u00BAnico para cada um deles. Feito isso, os Cart\u00C3\u00B5es gerados por esta opera\u00C3\u00A7\u00C3\u00A3o seguir\u00C3\u00A3o os mesmos processos de impress\u00C3\u00A3o via gr\u00C3\u00A1fica previamente definidos entre o Emissor e a Conductor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id). (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="idTipoCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idImagem">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Imagem (id). (optional)</param>
        /// <param name="idEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id). (optional)</param>
        /// <param name="quantidadeCartoes">N\u00C3\u00BAmero de cart\u00C3\u00B5es existentes no Lote. (optional)</param>
        /// <returns>LoteCartoesPrePagosResponse</returns>
        LoteCartoesPrePagosResponse GerarLotesCartoesPrePagosUsingPOST (long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null);
  
        /// <summary>
        /// Permite gerar um novo Lote de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pago
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores gerem uma determinada quantidade de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pagos, de forma n\u00C3\u00A3o nominal, os quais poder\u00C3\u00A3o ser comercializados e posteriormente vinculados a um cliente que o adquirir. Para isso, al\u00C3\u00A9m de definir quantos cart\u00C3\u00B5es dever\u00C3\u00A3o ser gerados, ser\u00C3\u00A1 poss\u00C3\u00ADvel definir qual a Origem Comercial, o Produto, o Tipo do Cart\u00C3\u00A3o, a Imagem e o Endere\u00C3\u00A7o para entrega dos Cart\u00C3\u00B5es presentes no lote gerado. Por padr\u00C3\u00A3o, todos os cart\u00C3\u00B5es ser\u00C3\u00A3o associados a um idPessoa fict\u00C3\u00ADcio e receber\u00C3\u00A1 um idConta \u00C3\u00BAnico para cada um deles. Feito isso, os Cart\u00C3\u00B5es gerados por esta opera\u00C3\u00A7\u00C3\u00A3o seguir\u00C3\u00A3o os mesmos processos de impress\u00C3\u00A3o via gr\u00C3\u00A1fica previamente definidos entre o Emissor e a Conductor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id). (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="idTipoCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idImagem">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Imagem (id). (optional)</param>
        /// <param name="idEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id). (optional)</param>
        /// <param name="quantidadeCartoes">N\u00C3\u00BAmero de cart\u00C3\u00B5es existentes no Lote. (optional)</param>
        /// <returns>ApiResponse of LoteCartoesPrePagosResponse</returns>
        ApiResponse<LoteCartoesPrePagosResponse> GerarLotesCartoesPrePagosUsingPOSTWithHttpInfo (long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null);
        
        /// <summary>
        /// Gerar uma nova via de Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores ou seus clientes possam solicitar a gera\u00C3\u00A7\u00C3\u00A3o de uma nova via de Cart\u00C3\u00A3o que ser\u00C3\u00A1 encaminhando para impress\u00C3\u00A3o e postagem de acordo com os fluxos padr\u00C3\u00B5es j\u00C3\u00A1 definidos pelo emissor. Para isso, \u00C3\u00A9 preciso que o cliente j\u00C3\u00A1 possua um cart\u00C3\u00A3o gerado e informar o C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o deste (idCartao) para que ele possa utilizar esta opera\u00C3\u00A7\u00C3\u00A3o. Assim, esta funcionalidade se aplica apenas para a gera\u00C3\u00A7\u00C3\u00A3o de cart\u00C3\u00B5es f\u00C3\u00ADsicos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id)</param>
        /// <returns>CartaoResponse</returns>
        CartaoResponse GerarNovaViaUsingPOST (long? id);
  
        /// <summary>
        /// Gerar uma nova via de Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores ou seus clientes possam solicitar a gera\u00C3\u00A7\u00C3\u00A3o de uma nova via de Cart\u00C3\u00A3o que ser\u00C3\u00A1 encaminhando para impress\u00C3\u00A3o e postagem de acordo com os fluxos padr\u00C3\u00B5es j\u00C3\u00A1 definidos pelo emissor. Para isso, \u00C3\u00A9 preciso que o cliente j\u00C3\u00A1 possua um cart\u00C3\u00A3o gerado e informar o C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o deste (idCartao) para que ele possa utilizar esta opera\u00C3\u00A7\u00C3\u00A3o. Assim, esta funcionalidade se aplica apenas para a gera\u00C3\u00A7\u00C3\u00A3o de cart\u00C3\u00B5es f\u00C3\u00ADsicos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id)</param>
        /// <returns>ApiResponse of CartaoResponse</returns>
        ApiResponse<CartaoResponse> GerarNovaViaUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// Adiciona tarifa de ajuste da segunda via do cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite adicionar tar\u00C3\u00ADfa de ajuste pela emiss\u00C3\u00A3o da segunda via do cart\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id).</param>
        /// <returns>Object</returns>
        Object LancarTarifaSegundaViaUsingPOST (long? id);
  
        /// <summary>
        /// Adiciona tarifa de ajuste da segunda via do cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite adicionar tar\u00C3\u00ADfa de ajuste pela emiss\u00C3\u00A3o da segunda via do cart\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id).</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> LancarTarifaSegundaViaUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// Permite listar os Lotes de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pago
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es pr\u00C3\u00A9-pagos existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id). (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="idTipoCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idImagem">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Imagem (id). (optional)</param>
        /// <param name="idEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id). (optional)</param>
        /// <param name="quantidadeCartoes">N\u00C3\u00BAmero de cart\u00C3\u00B5es existentes no Lote. (optional)</param>
        /// <param name="dataCadastro">Data de Cadastro do Lote de Cart\u00C3\u00B5es N\u00C3\u00A3o Nominais. (optional)</param>
        /// <param name="usuarioCadastro">Nome do Usu\u00C3\u00A1rio que criou o Lote. (optional)</param>
        /// <param name="statusProcessamento">Indica o Status de Processamento do Lote. (optional)</param>
        /// <returns>PageLoteCartoesPrePagosResponse</returns>
        PageLoteCartoesPrePagosResponse ListarLotesCartoesPrePagosUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string dataCadastro = null, string usuarioCadastro = null, int? statusProcessamento = null);
  
        /// <summary>
        /// Permite listar os Lotes de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pago
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es pr\u00C3\u00A9-pagos existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id). (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="idTipoCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idImagem">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Imagem (id). (optional)</param>
        /// <param name="idEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id). (optional)</param>
        /// <param name="quantidadeCartoes">N\u00C3\u00BAmero de cart\u00C3\u00B5es existentes no Lote. (optional)</param>
        /// <param name="dataCadastro">Data de Cadastro do Lote de Cart\u00C3\u00B5es N\u00C3\u00A3o Nominais. (optional)</param>
        /// <param name="usuarioCadastro">Nome do Usu\u00C3\u00A1rio que criou o Lote. (optional)</param>
        /// <param name="statusProcessamento">Indica o Status de Processamento do Lote. (optional)</param>
        /// <returns>ApiResponse of PageLoteCartoesPrePagosResponse</returns>
        ApiResponse<PageLoteCartoesPrePagosResponse> ListarLotesCartoesPrePagosUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string dataCadastro = null, string usuarioCadastro = null, int? statusProcessamento = null);
        
        /// <summary>
        /// Lista os Cart\u00C3\u00B5es gerados pelo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o cart\u00C3\u00A3o pertence (id) (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="tipoPortador">Apresenta o tipo do Portador do cart\u00C3\u00A3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional). (optional)</param>
        /// <param name="numeroCartao">Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome impresso no cart\u00C3\u00A3o. (optional)</param>
        /// <param name="dataGeracao">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param>
        /// <param name="dataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataValidade">Apresenta a data de validade do cart\u00C3\u00A3o em formato yyyy-MM, quando houver. (optional)</param>
        /// <param name="dataImpressao">Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica. (optional)</param>
        /// <param name="arquivoImpressao">Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver. (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial. (optional)</param>
        /// <param name="flagProvisorio">Quando ativa, indica que o cart\u00C3\u00A3o \u00C3\u00A9 provis\u00C3\u00B3rio. Ou seja, \u00C3\u00A9 um cart\u00C3\u00A3o para uso tempor\u00C3\u00A1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00C3\u00A3o definitivo. (optional)</param>
        /// <param name="codigoDesbloqueio">Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade. (optional)</param>
        /// <param name="sequencialCartao">N\u00C3\u00BAmero sequencial do cart\u00C3\u00A3o (optional)</param>
        /// <returns>PageCartaoResponse</returns>
        PageCartaoResponse ListarUsingGET7 (List<string> sort = null, int? page = null, int? limit = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? sequencialCartao = null);
  
        /// <summary>
        /// Lista os Cart\u00C3\u00B5es gerados pelo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o cart\u00C3\u00A3o pertence (id) (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="tipoPortador">Apresenta o tipo do Portador do cart\u00C3\u00A3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional). (optional)</param>
        /// <param name="numeroCartao">Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome impresso no cart\u00C3\u00A3o. (optional)</param>
        /// <param name="dataGeracao">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param>
        /// <param name="dataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataValidade">Apresenta a data de validade do cart\u00C3\u00A3o em formato yyyy-MM, quando houver. (optional)</param>
        /// <param name="dataImpressao">Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica. (optional)</param>
        /// <param name="arquivoImpressao">Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver. (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial. (optional)</param>
        /// <param name="flagProvisorio">Quando ativa, indica que o cart\u00C3\u00A3o \u00C3\u00A9 provis\u00C3\u00B3rio. Ou seja, \u00C3\u00A9 um cart\u00C3\u00A3o para uso tempor\u00C3\u00A1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00C3\u00A3o definitivo. (optional)</param>
        /// <param name="codigoDesbloqueio">Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade. (optional)</param>
        /// <param name="sequencialCartao">N\u00C3\u00BAmero sequencial do cart\u00C3\u00A3o (optional)</param>
        /// <returns>ApiResponse of PageCartaoResponse</returns>
        ApiResponse<PageCartaoResponse> ListarUsingGET7WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? sequencialCartao = null);
        
        /// <summary>
        /// Realiza a reativa\u00C3\u00A7\u00C3\u00A3o de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o da reativa\u00C3\u00A7\u00C3\u00A3o de um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>CartaoResponse</returns>
        CartaoResponse ReativarUsingPOST (long? id);
  
        /// <summary>
        /// Realiza a reativa\u00C3\u00A7\u00C3\u00A3o de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o da reativa\u00C3\u00A7\u00C3\u00A3o de um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>ApiResponse of CartaoResponse</returns>
        ApiResponse<CartaoResponse> ReativarUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// Permite validar os dados impressos em um cart\u00C3\u00A3o bandeirado
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir do envio dos dados sens\u00C3\u00ADveis impressos nele. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o para a realiza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00C3\u00B4nico (URA), dentre outras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="nomePortador">Nome do portador do cart\u00C3\u00A3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00C3\u00A3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00C3\u00B3digo de seguran\u00C3\u00A7a do cart\u00C3\u00A3o com tr\u00C3\u00AAs n\u00C3\u00BAmeros</param>
        /// <returns>ValidaCartaoResponse</returns>
        ValidaCartaoResponse ValidarDadosImpressosBandeiradoUsingGET (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);
  
        /// <summary>
        /// Permite validar os dados impressos em um cart\u00C3\u00A3o bandeirado
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir do envio dos dados sens\u00C3\u00ADveis impressos nele. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o para a realiza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00C3\u00B4nico (URA), dentre outras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="nomePortador">Nome do portador do cart\u00C3\u00A3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00C3\u00A3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00C3\u00B3digo de seguran\u00C3\u00A7a do cart\u00C3\u00A3o com tr\u00C3\u00AAs n\u00C3\u00BAmeros</param>
        /// <returns>ApiResponse of ValidaCartaoResponse</returns>
        ApiResponse<ValidaCartaoResponse> ValidarDadosImpressosBandeiradoUsingGETWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);
        
        /// <summary>
        /// Permite validar os dados impressos de um cartao n\u00C3\u00A3o bandeirado
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir do envio dos dados sens\u00C3\u00ADveis impressos nele. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o para a realiza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00C3\u00B4nico (URA), dentre outras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="nomePortador">Nome do portador do cart\u00C3\u00A3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00C3\u00A3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00C3\u00B3digo de seguran\u00C3\u00A7a do cart\u00C3\u00A3o com tr\u00C3\u00AAs n\u00C3\u00BAmeros</param>
        /// <returns>ValidaCartaoResponse</returns>
        ValidaCartaoResponse ValidarDadosImpressosNaoBandeiradoUsingGET (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);
  
        /// <summary>
        /// Permite validar os dados impressos de um cartao n\u00C3\u00A3o bandeirado
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir do envio dos dados sens\u00C3\u00ADveis impressos nele. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o para a realiza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00C3\u00B4nico (URA), dentre outras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="nomePortador">Nome do portador do cart\u00C3\u00A3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00C3\u00A3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00C3\u00B3digo de seguran\u00C3\u00A7a do cart\u00C3\u00A3o com tr\u00C3\u00AAs n\u00C3\u00BAmeros</param>
        /// <returns>ApiResponse of ValidaCartaoResponse</returns>
        ApiResponse<ValidaCartaoResponse> ValidarDadosImpressosNaoBandeiradoUsingGETWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);
        
        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o com bandeira Mastercard a partir do de55
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem o DE55 gerado a partir da leitura de um chip EMV de um Cart\u00C3\u00A3o com bandeira Mastercard a fim de verificar a sua autenticidade. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o antes de permitir que o portador realize transa\u00C3\u00A7\u00C3\u00B5es diversas, como as de compra e saque na modalidade d\u00C3\u00A9bito em conta corrente, dentre outras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="criptograma">Criptograma do cart\u00C3\u00A3o no formato de55</param>
        /// <returns>ValidaCartaoResponse</returns>
        ValidaCartaoResponse ValidarDe55CartaoMastercardUsingGET (string numeroCartao, string criptograma);
  
        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o com bandeira Mastercard a partir do de55
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem o DE55 gerado a partir da leitura de um chip EMV de um Cart\u00C3\u00A3o com bandeira Mastercard a fim de verificar a sua autenticidade. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o antes de permitir que o portador realize transa\u00C3\u00A7\u00C3\u00B5es diversas, como as de compra e saque na modalidade d\u00C3\u00A9bito em conta corrente, dentre outras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="criptograma">Criptograma do cart\u00C3\u00A3o no formato de55</param>
        /// <returns>ApiResponse of ValidaCartaoResponse</returns>
        ApiResponse<ValidaCartaoResponse> ValidarDe55CartaoMastercardUsingGETWithHttpInfo (string numeroCartao, string criptograma);
        
        /// <summary>
        /// Permite validar a senha de um Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir validar que a senha informada pelo portador de um determinado cart\u00C3\u00A3o est\u00C3\u00A1 correta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="senha">Senha para ser validada.</param>
        /// <returns>ValidaSenhaCartaoResponse</returns>
        ValidaSenhaCartaoResponse ValidarSenhaUsingGET (long? id, string senha);
  
        /// <summary>
        /// Permite validar a senha de um Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir validar que a senha informada pelo portador de um determinado cart\u00C3\u00A3o est\u00C3\u00A1 correta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="senha">Senha para ser validada.</param>
        /// <returns>ApiResponse of ValidaSenhaCartaoResponse</returns>
        ApiResponse<ValidaSenhaCartaoResponse> ValidarSenhaUsingGETWithHttpInfo (long? id, string senha);
        
        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o Bandeirado a partir da Tarja
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir da leitura da tarja magn\u00C3\u00A9tica do mesmo. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o antes de permitir que o portador realize transa\u00C3\u00A7\u00C3\u00B5es diversas, como as de compra e saque na modalidade d\u00C3\u00A9bito em conta corrente, dentre outras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="trilha1">Trilha 1 do cart\u00C3\u00A3o a ser validado</param>
        /// <param name="trilha2">Trilha 2 do cart\u00C3\u00A3o a ser validado</param>
        /// <returns>ValidaCartaoResponse</returns>
        ValidaCartaoResponse ValidarTarjaUsingGET (string numeroCartao, string trilha1, string trilha2);
  
        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o Bandeirado a partir da Tarja
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir da leitura da tarja magn\u00C3\u00A9tica do mesmo. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o antes de permitir que o portador realize transa\u00C3\u00A7\u00C3\u00B5es diversas, como as de compra e saque na modalidade d\u00C3\u00A9bito em conta corrente, dentre outras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="trilha1">Trilha 1 do cart\u00C3\u00A3o a ser validado</param>
        /// <param name="trilha2">Trilha 2 do cart\u00C3\u00A3o a ser validado</param>
        /// <returns>ApiResponse of ValidaCartaoResponse</returns>
        ApiResponse<ValidaCartaoResponse> ValidarTarjaUsingGETWithHttpInfo (string numeroCartao, string trilha1, string trilha2);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o da senha de um Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que o portador de um determinado cart\u00C3\u00A3o possa definir uma senha a sua escolha.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="senha">Senha para ser cadastrada ou alterada.</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> AlterarAlterarSenhaUsingPUTAsync (long? id, string senha);

        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o da senha de um Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que o portador de um determinado cart\u00C3\u00A3o possa definir uma senha a sua escolha.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="senha">Senha para ser cadastrada ou alterada.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> AlterarAlterarSenhaUsingPUTAsyncWithHttpInfo (long? id, string senha);
        
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que uma Aplica\u00C3\u00A7\u00C3\u00A3o que realize a impress\u00C3\u00A3o de cart\u00C3\u00B5es possa indicar que um determinado idCartao fora impresso ou est\u00C3\u00A1 em processo de impress\u00C3\u00A3o. Para isso, basta informar o respectivo c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id) que deseja ter seu um determinado id_status_impressao atribu\u00C3\u00ADdo a ele. Por padr\u00C3\u00A3o, cart\u00C3\u00B5es provis\u00C3\u00B3rios ou que j\u00C3\u00A1 tenham sido inclu\u00C3\u00ADdos em um arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica ter\u00C3\u00A3o esta requisi\u00C3\u00A7\u00C3\u00A3o negada, se utilizada.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="idStatusImpressao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status Impress\u00C3\u00A3o (Id).</param>
        /// <returns>Task of HistoricoImpressaoCartaoResponse</returns>
        System.Threading.Tasks.Task<HistoricoImpressaoCartaoResponse> AlterarStatusImpressaoUsingPUTAsync (long? id, long? idStatusImpressao);

        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que uma Aplica\u00C3\u00A7\u00C3\u00A3o que realize a impress\u00C3\u00A3o de cart\u00C3\u00B5es possa indicar que um determinado idCartao fora impresso ou est\u00C3\u00A1 em processo de impress\u00C3\u00A3o. Para isso, basta informar o respectivo c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id) que deseja ter seu um determinado id_status_impressao atribu\u00C3\u00ADdo a ele. Por padr\u00C3\u00A3o, cart\u00C3\u00B5es provis\u00C3\u00B3rios ou que j\u00C3\u00A1 tenham sido inclu\u00C3\u00ADdos em um arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica ter\u00C3\u00A3o esta requisi\u00C3\u00A7\u00C3\u00A3o negada, se utilizada.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="idStatusImpressao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status Impress\u00C3\u00A3o (Id).</param>
        /// <returns>Task of ApiResponse (HistoricoImpressaoCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<HistoricoImpressaoCartaoResponse>> AlterarStatusImpressaoUsingPUTAsyncWithHttpInfo (long? id, long? idStatusImpressao);
        
        /// <summary>
        /// Realiza a atribui\u00C3\u00A7\u00C3\u00A3o de um cart\u00C3\u00A3o pr\u00C3\u00A9-pago a uma pessoa
        /// </summary>
        /// <remarks>
        /// Esta m\u00C3\u00A9todo permite que um cart\u00C3\u00A3o pr\u00C3\u00A9-pago impresso de forma avulsa e an\u00C3\u00B4nimo seja atribu\u00C3\u00ADdo a uma pessoa para que esta passe a ser a portadora titular dele.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o de uma Pessoa (id).</param>
        /// <returns>Task of CartaoResponse</returns>
        System.Threading.Tasks.Task<CartaoResponse> AtribuirPessoaUsingPUTAsync (long? id, long? idPessoa);

        /// <summary>
        /// Realiza a atribui\u00C3\u00A7\u00C3\u00A3o de um cart\u00C3\u00A3o pr\u00C3\u00A9-pago a uma pessoa
        /// </summary>
        /// <remarks>
        /// Esta m\u00C3\u00A9todo permite que um cart\u00C3\u00A3o pr\u00C3\u00A9-pago impresso de forma avulsa e an\u00C3\u00B4nimo seja atribu\u00C3\u00ADdo a uma pessoa para que esta passe a ser a portadora titular dele.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o de uma Pessoa (id).</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> AtribuirPessoaUsingPUTAsyncWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// Realiza o bloqueio de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o do bloqueio (tempor\u00C3\u00A1rio) ou do cancelamento (definitivo) de um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id). Para isso, \u00C3\u00A9 preciso informar qual o motivo deste bloqueio que nada mais \u00C3\u00A9 do que atribuir um novo StatusCartao para ele dentre as op\u00C3\u00A7\u00C3\u00B5es praticadas pelo emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Cart\u00C3\u00A3o.</param>
        /// <param name="observacao">Texto informando uma observa\u00C3\u00A7\u00C3\u00A3o sobre o bloqueio.</param>
        /// <returns>Task of CartaoResponse</returns>
        System.Threading.Tasks.Task<CartaoResponse> BloquearUsingPOSTAsync (long? id, long? idStatus, string observacao);

        /// <summary>
        /// Realiza o bloqueio de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o do bloqueio (tempor\u00C3\u00A1rio) ou do cancelamento (definitivo) de um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id). Para isso, \u00C3\u00A9 preciso informar qual o motivo deste bloqueio que nada mais \u00C3\u00A9 do que atribuir um novo StatusCartao para ele dentre as op\u00C3\u00A7\u00C3\u00B5es praticadas pelo emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Cart\u00C3\u00A3o.</param>
        /// <param name="observacao">Texto informando uma observa\u00C3\u00A7\u00C3\u00A3o sobre o bloqueio.</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> BloquearUsingPOSTAsyncWithHttpInfo (long? id, long? idStatus, string observacao);
        
        /// <summary>
        /// Realiza o cadastro da senha de um Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que o portador de um determinado cart\u00C3\u00A3o possa definir uma senha a sua escolha.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="senha">Senha para ser cadastrada ou alterada.</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> CadastrarAlterarSenhaUsingPOSTAsync (long? id, string senha);

        /// <summary>
        /// Realiza o cadastro da senha de um Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que o portador de um determinado cart\u00C3\u00A3o possa definir uma senha a sua escolha.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="senha">Senha para ser cadastrada ou alterada.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> CadastrarAlterarSenhaUsingPOSTAsyncWithHttpInfo (long? id, string senha);
        
        /// <summary>
        /// Realiza o cancelamento de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o cancelamento de um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id). Para isso, \u00C3\u00A9 preciso informar qual o motivo deste bloqueio que nada mais \u00C3\u00A9 do que atribuir um novo StatusCartao para ele dentre as op\u00C3\u00A7\u00C3\u00B5es praticadas pelo emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Cart\u00C3\u00A3o.</param>
        /// <param name="observacao">Texto informando uma observa\u00C3\u00A7\u00C3\u00A3o sobre o cancelamento.</param>
        /// <returns>Task of CartaoResponse</returns>
        System.Threading.Tasks.Task<CartaoResponse> CancelarUsingPOSTAsync (long? id, long? idStatus, string observacao);

        /// <summary>
        /// Realiza o cancelamento de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o cancelamento de um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id). Para isso, \u00C3\u00A9 preciso informar qual o motivo deste bloqueio que nada mais \u00C3\u00A9 do que atribuir um novo StatusCartao para ele dentre as op\u00C3\u00A7\u00C3\u00B5es praticadas pelo emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Cart\u00C3\u00A3o.</param>
        /// <param name="observacao">Texto informando uma observa\u00C3\u00A7\u00C3\u00A3o sobre o cancelamento.</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> CancelarUsingPOSTAsyncWithHttpInfo (long? id, long? idStatus, string observacao);
        
        /// <summary>
        /// Consultar os dados de impress\u00C3\u00A3o de um Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar os dados de impress\u00C3\u00A3o de um cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of DadosCartaoImpressaoResponse</returns>
        System.Threading.Tasks.Task<DadosCartaoImpressaoResponse> ConsultarCartaoImpressaoUsingGETAsync (long? id);

        /// <summary>
        /// Consultar os dados de impress\u00C3\u00A3o de um Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar os dados de impress\u00C3\u00A3o de um cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (DadosCartaoImpressaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DadosCartaoImpressaoResponse>> ConsultarCartaoImpressaoUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar Detalhes do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja consultado os dados necessarios de um cart\u00C3\u00A3o para executar servi\u00C3\u00A7os de autoriza\u00C3\u00A7\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of DadosCartaoResponse</returns>
        System.Threading.Tasks.Task<DadosCartaoResponse> ConsultarDadosReaisCartaoUsingGETAsync (long? id);

        /// <summary>
        /// Consultar Detalhes do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja consultado os dados necessarios de um cart\u00C3\u00A3o para executar servi\u00C3\u00A7os de autoriza\u00C3\u00A7\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (DadosCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DadosCartaoResponse>> ConsultarDadosReaisCartaoUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os limites do Portador do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os Limites configurados para o Portador de um determinado Cart\u00C3\u00A3o, seja ele o titular da conta ou um adicional, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of LimiteDisponibilidadeResponse</returns>
        System.Threading.Tasks.Task<LimiteDisponibilidadeResponse> ConsultarLimiteDisponibilidadeUsingGETAsync (long? id);

        /// <summary>
        /// Apresenta os limites do Portador do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os Limites configurados para o Portador de um determinado Cart\u00C3\u00A3o, seja ele o titular da conta ou um adicional, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (LimiteDisponibilidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LimiteDisponibilidadeResponse>> ConsultarLimiteDisponibilidadeUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Permite consultar um determinado Lote de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pago
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os cart\u00C3\u00B5es pr\u00C3\u00A9-pagos existentes na base do emissor atrav\u00C3\u00A9s do id do lote.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do lote de cart\u00C3\u00B5es (id)</param>
        /// <returns>Task of LoteCartoesPrePagosResponse</returns>
        System.Threading.Tasks.Task<LoteCartoesPrePagosResponse> ConsultarLotesCartoesPrePagosUsingGETAsync (long? id);

        /// <summary>
        /// Permite consultar um determinado Lote de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pago
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os cart\u00C3\u00B5es pr\u00C3\u00A9-pagos existentes na base do emissor atrav\u00C3\u00A9s do id do lote.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do lote de cart\u00C3\u00B5es (id)</param>
        /// <returns>Task of ApiResponse (LoteCartoesPrePagosResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LoteCartoesPrePagosResponse>> ConsultarLotesCartoesPrePagosUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados do Portador do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es do Portador de um determinado Cart\u00C3\u00A3o a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of PortadorResponse</returns>
        System.Threading.Tasks.Task<PortadorResponse> ConsultarPortadorUsingGETAsync (long? id);

        /// <summary>
        /// Apresenta os dados do Portador do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es do Portador de um determinado Cart\u00C3\u00A3o a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (PortadorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortadorResponse>> ConsultarPortadorUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es b\u00C3\u00A1sicas de um determinado Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of CartaoDetalheResponse</returns>
        System.Threading.Tasks.Task<CartaoDetalheResponse> ConsultarUsingGET7Async (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es b\u00C3\u00A1sicas de um determinado Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (CartaoDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoDetalheResponse>> ConsultarUsingGET7AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Realiza o desbloqueio de um cart\u00C3\u00A3o bloqueado por tentativas de senha incorretas
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja desbloqueado um determinado cart\u00C3\u00A3o que foi bloqueado por tentativas de senha incorretas, a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of CartaoResponse</returns>
        System.Threading.Tasks.Task<CartaoResponse> DesbloquearSenhaIncorretaUsingPOSTAsync (long? id);

        /// <summary>
        /// Realiza o desbloqueio de um cart\u00C3\u00A3o bloqueado por tentativas de senha incorretas
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja desbloqueado um determinado cart\u00C3\u00A3o que foi bloqueado por tentativas de senha incorretas, a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> DesbloquearSenhaIncorretaUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Realiza o desbloqueio de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja desbloqueado um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of CartaoResponse</returns>
        System.Threading.Tasks.Task<CartaoResponse> DesbloquearUsingPOSTAsync (long? id);

        /// <summary>
        /// Realiza o desbloqueio de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja desbloqueado um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> DesbloquearUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Permite gerar um novo Lote de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pago
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores gerem uma determinada quantidade de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pagos, de forma n\u00C3\u00A3o nominal, os quais poder\u00C3\u00A3o ser comercializados e posteriormente vinculados a um cliente que o adquirir. Para isso, al\u00C3\u00A9m de definir quantos cart\u00C3\u00B5es dever\u00C3\u00A3o ser gerados, ser\u00C3\u00A1 poss\u00C3\u00ADvel definir qual a Origem Comercial, o Produto, o Tipo do Cart\u00C3\u00A3o, a Imagem e o Endere\u00C3\u00A7o para entrega dos Cart\u00C3\u00B5es presentes no lote gerado. Por padr\u00C3\u00A3o, todos os cart\u00C3\u00B5es ser\u00C3\u00A3o associados a um idPessoa fict\u00C3\u00ADcio e receber\u00C3\u00A1 um idConta \u00C3\u00BAnico para cada um deles. Feito isso, os Cart\u00C3\u00B5es gerados por esta opera\u00C3\u00A7\u00C3\u00A3o seguir\u00C3\u00A3o os mesmos processos de impress\u00C3\u00A3o via gr\u00C3\u00A1fica previamente definidos entre o Emissor e a Conductor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id). (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="idTipoCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idImagem">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Imagem (id). (optional)</param>
        /// <param name="idEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id). (optional)</param>
        /// <param name="quantidadeCartoes">N\u00C3\u00BAmero de cart\u00C3\u00B5es existentes no Lote. (optional)</param>
        /// <returns>Task of LoteCartoesPrePagosResponse</returns>
        System.Threading.Tasks.Task<LoteCartoesPrePagosResponse> GerarLotesCartoesPrePagosUsingPOSTAsync (long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null);

        /// <summary>
        /// Permite gerar um novo Lote de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pago
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores gerem uma determinada quantidade de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pagos, de forma n\u00C3\u00A3o nominal, os quais poder\u00C3\u00A3o ser comercializados e posteriormente vinculados a um cliente que o adquirir. Para isso, al\u00C3\u00A9m de definir quantos cart\u00C3\u00B5es dever\u00C3\u00A3o ser gerados, ser\u00C3\u00A1 poss\u00C3\u00ADvel definir qual a Origem Comercial, o Produto, o Tipo do Cart\u00C3\u00A3o, a Imagem e o Endere\u00C3\u00A7o para entrega dos Cart\u00C3\u00B5es presentes no lote gerado. Por padr\u00C3\u00A3o, todos os cart\u00C3\u00B5es ser\u00C3\u00A3o associados a um idPessoa fict\u00C3\u00ADcio e receber\u00C3\u00A1 um idConta \u00C3\u00BAnico para cada um deles. Feito isso, os Cart\u00C3\u00B5es gerados por esta opera\u00C3\u00A7\u00C3\u00A3o seguir\u00C3\u00A3o os mesmos processos de impress\u00C3\u00A3o via gr\u00C3\u00A1fica previamente definidos entre o Emissor e a Conductor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id). (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="idTipoCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idImagem">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Imagem (id). (optional)</param>
        /// <param name="idEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id). (optional)</param>
        /// <param name="quantidadeCartoes">N\u00C3\u00BAmero de cart\u00C3\u00B5es existentes no Lote. (optional)</param>
        /// <returns>Task of ApiResponse (LoteCartoesPrePagosResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LoteCartoesPrePagosResponse>> GerarLotesCartoesPrePagosUsingPOSTAsyncWithHttpInfo (long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null);
        
        /// <summary>
        /// Gerar uma nova via de Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores ou seus clientes possam solicitar a gera\u00C3\u00A7\u00C3\u00A3o de uma nova via de Cart\u00C3\u00A3o que ser\u00C3\u00A1 encaminhando para impress\u00C3\u00A3o e postagem de acordo com os fluxos padr\u00C3\u00B5es j\u00C3\u00A1 definidos pelo emissor. Para isso, \u00C3\u00A9 preciso que o cliente j\u00C3\u00A1 possua um cart\u00C3\u00A3o gerado e informar o C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o deste (idCartao) para que ele possa utilizar esta opera\u00C3\u00A7\u00C3\u00A3o. Assim, esta funcionalidade se aplica apenas para a gera\u00C3\u00A7\u00C3\u00A3o de cart\u00C3\u00B5es f\u00C3\u00ADsicos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id)</param>
        /// <returns>Task of CartaoResponse</returns>
        System.Threading.Tasks.Task<CartaoResponse> GerarNovaViaUsingPOSTAsync (long? id);

        /// <summary>
        /// Gerar uma nova via de Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores ou seus clientes possam solicitar a gera\u00C3\u00A7\u00C3\u00A3o de uma nova via de Cart\u00C3\u00A3o que ser\u00C3\u00A1 encaminhando para impress\u00C3\u00A3o e postagem de acordo com os fluxos padr\u00C3\u00B5es j\u00C3\u00A1 definidos pelo emissor. Para isso, \u00C3\u00A9 preciso que o cliente j\u00C3\u00A1 possua um cart\u00C3\u00A3o gerado e informar o C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o deste (idCartao) para que ele possa utilizar esta opera\u00C3\u00A7\u00C3\u00A3o. Assim, esta funcionalidade se aplica apenas para a gera\u00C3\u00A7\u00C3\u00A3o de cart\u00C3\u00B5es f\u00C3\u00ADsicos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id)</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> GerarNovaViaUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Adiciona tarifa de ajuste da segunda via do cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite adicionar tar\u00C3\u00ADfa de ajuste pela emiss\u00C3\u00A3o da segunda via do cart\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> LancarTarifaSegundaViaUsingPOSTAsync (long? id);

        /// <summary>
        /// Adiciona tarifa de ajuste da segunda via do cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite adicionar tar\u00C3\u00ADfa de ajuste pela emiss\u00C3\u00A3o da segunda via do cart\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> LancarTarifaSegundaViaUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Permite listar os Lotes de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pago
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es pr\u00C3\u00A9-pagos existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id). (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="idTipoCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idImagem">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Imagem (id). (optional)</param>
        /// <param name="idEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id). (optional)</param>
        /// <param name="quantidadeCartoes">N\u00C3\u00BAmero de cart\u00C3\u00B5es existentes no Lote. (optional)</param>
        /// <param name="dataCadastro">Data de Cadastro do Lote de Cart\u00C3\u00B5es N\u00C3\u00A3o Nominais. (optional)</param>
        /// <param name="usuarioCadastro">Nome do Usu\u00C3\u00A1rio que criou o Lote. (optional)</param>
        /// <param name="statusProcessamento">Indica o Status de Processamento do Lote. (optional)</param>
        /// <returns>Task of PageLoteCartoesPrePagosResponse</returns>
        System.Threading.Tasks.Task<PageLoteCartoesPrePagosResponse> ListarLotesCartoesPrePagosUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string dataCadastro = null, string usuarioCadastro = null, int? statusProcessamento = null);

        /// <summary>
        /// Permite listar os Lotes de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pago
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es pr\u00C3\u00A9-pagos existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id). (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="idTipoCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idImagem">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Imagem (id). (optional)</param>
        /// <param name="idEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id). (optional)</param>
        /// <param name="quantidadeCartoes">N\u00C3\u00BAmero de cart\u00C3\u00B5es existentes no Lote. (optional)</param>
        /// <param name="dataCadastro">Data de Cadastro do Lote de Cart\u00C3\u00B5es N\u00C3\u00A3o Nominais. (optional)</param>
        /// <param name="usuarioCadastro">Nome do Usu\u00C3\u00A1rio que criou o Lote. (optional)</param>
        /// <param name="statusProcessamento">Indica o Status de Processamento do Lote. (optional)</param>
        /// <returns>Task of ApiResponse (PageLoteCartoesPrePagosResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageLoteCartoesPrePagosResponse>> ListarLotesCartoesPrePagosUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string dataCadastro = null, string usuarioCadastro = null, int? statusProcessamento = null);
        
        /// <summary>
        /// Lista os Cart\u00C3\u00B5es gerados pelo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o cart\u00C3\u00A3o pertence (id) (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="tipoPortador">Apresenta o tipo do Portador do cart\u00C3\u00A3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional). (optional)</param>
        /// <param name="numeroCartao">Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome impresso no cart\u00C3\u00A3o. (optional)</param>
        /// <param name="dataGeracao">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param>
        /// <param name="dataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataValidade">Apresenta a data de validade do cart\u00C3\u00A3o em formato yyyy-MM, quando houver. (optional)</param>
        /// <param name="dataImpressao">Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica. (optional)</param>
        /// <param name="arquivoImpressao">Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver. (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial. (optional)</param>
        /// <param name="flagProvisorio">Quando ativa, indica que o cart\u00C3\u00A3o \u00C3\u00A9 provis\u00C3\u00B3rio. Ou seja, \u00C3\u00A9 um cart\u00C3\u00A3o para uso tempor\u00C3\u00A1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00C3\u00A3o definitivo. (optional)</param>
        /// <param name="codigoDesbloqueio">Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade. (optional)</param>
        /// <param name="sequencialCartao">N\u00C3\u00BAmero sequencial do cart\u00C3\u00A3o (optional)</param>
        /// <returns>Task of PageCartaoResponse</returns>
        System.Threading.Tasks.Task<PageCartaoResponse> ListarUsingGET7Async (List<string> sort = null, int? page = null, int? limit = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? sequencialCartao = null);

        /// <summary>
        /// Lista os Cart\u00C3\u00B5es gerados pelo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o cart\u00C3\u00A3o pertence (id) (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="tipoPortador">Apresenta o tipo do Portador do cart\u00C3\u00A3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional). (optional)</param>
        /// <param name="numeroCartao">Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome impresso no cart\u00C3\u00A3o. (optional)</param>
        /// <param name="dataGeracao">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param>
        /// <param name="dataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataValidade">Apresenta a data de validade do cart\u00C3\u00A3o em formato yyyy-MM, quando houver. (optional)</param>
        /// <param name="dataImpressao">Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica. (optional)</param>
        /// <param name="arquivoImpressao">Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver. (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial. (optional)</param>
        /// <param name="flagProvisorio">Quando ativa, indica que o cart\u00C3\u00A3o \u00C3\u00A9 provis\u00C3\u00B3rio. Ou seja, \u00C3\u00A9 um cart\u00C3\u00A3o para uso tempor\u00C3\u00A1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00C3\u00A3o definitivo. (optional)</param>
        /// <param name="codigoDesbloqueio">Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade. (optional)</param>
        /// <param name="sequencialCartao">N\u00C3\u00BAmero sequencial do cart\u00C3\u00A3o (optional)</param>
        /// <returns>Task of ApiResponse (PageCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCartaoResponse>> ListarUsingGET7AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? sequencialCartao = null);
        
        /// <summary>
        /// Realiza a reativa\u00C3\u00A7\u00C3\u00A3o de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o da reativa\u00C3\u00A7\u00C3\u00A3o de um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of CartaoResponse</returns>
        System.Threading.Tasks.Task<CartaoResponse> ReativarUsingPOSTAsync (long? id);

        /// <summary>
        /// Realiza a reativa\u00C3\u00A7\u00C3\u00A3o de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o da reativa\u00C3\u00A7\u00C3\u00A3o de um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> ReativarUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Permite validar os dados impressos em um cart\u00C3\u00A3o bandeirado
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir do envio dos dados sens\u00C3\u00ADveis impressos nele. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o para a realiza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00C3\u00B4nico (URA), dentre outras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="nomePortador">Nome do portador do cart\u00C3\u00A3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00C3\u00A3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00C3\u00B3digo de seguran\u00C3\u00A7a do cart\u00C3\u00A3o com tr\u00C3\u00AAs n\u00C3\u00BAmeros</param>
        /// <returns>Task of ValidaCartaoResponse</returns>
        System.Threading.Tasks.Task<ValidaCartaoResponse> ValidarDadosImpressosBandeiradoUsingGETAsync (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);

        /// <summary>
        /// Permite validar os dados impressos em um cart\u00C3\u00A3o bandeirado
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir do envio dos dados sens\u00C3\u00ADveis impressos nele. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o para a realiza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00C3\u00B4nico (URA), dentre outras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="nomePortador">Nome do portador do cart\u00C3\u00A3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00C3\u00A3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00C3\u00B3digo de seguran\u00C3\u00A7a do cart\u00C3\u00A3o com tr\u00C3\u00AAs n\u00C3\u00BAmeros</param>
        /// <returns>Task of ApiResponse (ValidaCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ValidaCartaoResponse>> ValidarDadosImpressosBandeiradoUsingGETAsyncWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);
        
        /// <summary>
        /// Permite validar os dados impressos de um cartao n\u00C3\u00A3o bandeirado
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir do envio dos dados sens\u00C3\u00ADveis impressos nele. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o para a realiza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00C3\u00B4nico (URA), dentre outras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="nomePortador">Nome do portador do cart\u00C3\u00A3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00C3\u00A3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00C3\u00B3digo de seguran\u00C3\u00A7a do cart\u00C3\u00A3o com tr\u00C3\u00AAs n\u00C3\u00BAmeros</param>
        /// <returns>Task of ValidaCartaoResponse</returns>
        System.Threading.Tasks.Task<ValidaCartaoResponse> ValidarDadosImpressosNaoBandeiradoUsingGETAsync (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);

        /// <summary>
        /// Permite validar os dados impressos de um cartao n\u00C3\u00A3o bandeirado
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir do envio dos dados sens\u00C3\u00ADveis impressos nele. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o para a realiza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00C3\u00B4nico (URA), dentre outras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="nomePortador">Nome do portador do cart\u00C3\u00A3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00C3\u00A3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00C3\u00B3digo de seguran\u00C3\u00A7a do cart\u00C3\u00A3o com tr\u00C3\u00AAs n\u00C3\u00BAmeros</param>
        /// <returns>Task of ApiResponse (ValidaCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ValidaCartaoResponse>> ValidarDadosImpressosNaoBandeiradoUsingGETAsyncWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);
        
        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o com bandeira Mastercard a partir do de55
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem o DE55 gerado a partir da leitura de um chip EMV de um Cart\u00C3\u00A3o com bandeira Mastercard a fim de verificar a sua autenticidade. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o antes de permitir que o portador realize transa\u00C3\u00A7\u00C3\u00B5es diversas, como as de compra e saque na modalidade d\u00C3\u00A9bito em conta corrente, dentre outras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="criptograma">Criptograma do cart\u00C3\u00A3o no formato de55</param>
        /// <returns>Task of ValidaCartaoResponse</returns>
        System.Threading.Tasks.Task<ValidaCartaoResponse> ValidarDe55CartaoMastercardUsingGETAsync (string numeroCartao, string criptograma);

        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o com bandeira Mastercard a partir do de55
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem o DE55 gerado a partir da leitura de um chip EMV de um Cart\u00C3\u00A3o com bandeira Mastercard a fim de verificar a sua autenticidade. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o antes de permitir que o portador realize transa\u00C3\u00A7\u00C3\u00B5es diversas, como as de compra e saque na modalidade d\u00C3\u00A9bito em conta corrente, dentre outras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="criptograma">Criptograma do cart\u00C3\u00A3o no formato de55</param>
        /// <returns>Task of ApiResponse (ValidaCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ValidaCartaoResponse>> ValidarDe55CartaoMastercardUsingGETAsyncWithHttpInfo (string numeroCartao, string criptograma);
        
        /// <summary>
        /// Permite validar a senha de um Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir validar que a senha informada pelo portador de um determinado cart\u00C3\u00A3o est\u00C3\u00A1 correta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="senha">Senha para ser validada.</param>
        /// <returns>Task of ValidaSenhaCartaoResponse</returns>
        System.Threading.Tasks.Task<ValidaSenhaCartaoResponse> ValidarSenhaUsingGETAsync (long? id, string senha);

        /// <summary>
        /// Permite validar a senha de um Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir validar que a senha informada pelo portador de um determinado cart\u00C3\u00A3o est\u00C3\u00A1 correta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="senha">Senha para ser validada.</param>
        /// <returns>Task of ApiResponse (ValidaSenhaCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ValidaSenhaCartaoResponse>> ValidarSenhaUsingGETAsyncWithHttpInfo (long? id, string senha);
        
        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o Bandeirado a partir da Tarja
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir da leitura da tarja magn\u00C3\u00A9tica do mesmo. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o antes de permitir que o portador realize transa\u00C3\u00A7\u00C3\u00B5es diversas, como as de compra e saque na modalidade d\u00C3\u00A9bito em conta corrente, dentre outras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="trilha1">Trilha 1 do cart\u00C3\u00A3o a ser validado</param>
        /// <param name="trilha2">Trilha 2 do cart\u00C3\u00A3o a ser validado</param>
        /// <returns>Task of ValidaCartaoResponse</returns>
        System.Threading.Tasks.Task<ValidaCartaoResponse> ValidarTarjaUsingGETAsync (string numeroCartao, string trilha1, string trilha2);

        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o Bandeirado a partir da Tarja
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir da leitura da tarja magn\u00C3\u00A9tica do mesmo. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o antes de permitir que o portador realize transa\u00C3\u00A7\u00C3\u00B5es diversas, como as de compra e saque na modalidade d\u00C3\u00A9bito em conta corrente, dentre outras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="trilha1">Trilha 1 do cart\u00C3\u00A3o a ser validado</param>
        /// <param name="trilha2">Trilha 2 do cart\u00C3\u00A3o a ser validado</param>
        /// <returns>Task of ApiResponse (ValidaCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ValidaCartaoResponse>> ValidarTarjaUsingGETAsyncWithHttpInfo (string numeroCartao, string trilha1, string trilha2);
        
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
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o da senha de um Cart\u00C3\u00A3o Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que o portador de um determinado cart\u00C3\u00A3o possa definir uma senha a sua escolha.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <param name="senha">Senha para ser cadastrada ou alterada.</param> 
        /// <returns>string</returns>
        public string AlterarAlterarSenhaUsingPUT (long? id, string senha)
        {
             ApiResponse<string> localVarResponse = AlterarAlterarSenhaUsingPUTWithHttpInfo(id, senha);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o da senha de um Cart\u00C3\u00A3o Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que o portador de um determinado cart\u00C3\u00A3o possa definir uma senha a sua escolha.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <param name="senha">Senha para ser cadastrada ou alterada.</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > AlterarAlterarSenhaUsingPUTWithHttpInfo (long? id, string senha)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->AlterarAlterarSenhaUsingPUT");
            
            // verify the required parameter 'senha' is set
            if (senha == null)
                throw new ApiException(400, "Missing required parameter 'senha' when calling CartaoApi->AlterarAlterarSenhaUsingPUT");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarAlterarSenhaUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarAlterarSenhaUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o da senha de um Cart\u00C3\u00A3o Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que o portador de um determinado cart\u00C3\u00A3o possa definir uma senha a sua escolha.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="senha">Senha para ser cadastrada ou alterada.</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> AlterarAlterarSenhaUsingPUTAsync (long? id, string senha)
        {
             ApiResponse<string> localVarResponse = await AlterarAlterarSenhaUsingPUTAsyncWithHttpInfo(id, senha);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o da senha de um Cart\u00C3\u00A3o Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que o portador de um determinado cart\u00C3\u00A3o possa definir uma senha a sua escolha.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="senha">Senha para ser cadastrada ou alterada.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> AlterarAlterarSenhaUsingPUTAsyncWithHttpInfo (long? id, string senha)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarAlterarSenhaUsingPUT");
            // verify the required parameter 'senha' is set
            if (senha == null) throw new ApiException(400, "Missing required parameter 'senha' when calling AlterarAlterarSenhaUsingPUT");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarAlterarSenhaUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarAlterarSenhaUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que uma Aplica\u00C3\u00A7\u00C3\u00A3o que realize a impress\u00C3\u00A3o de cart\u00C3\u00B5es possa indicar que um determinado idCartao fora impresso ou est\u00C3\u00A1 em processo de impress\u00C3\u00A3o. Para isso, basta informar o respectivo c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id) que deseja ter seu um determinado id_status_impressao atribu\u00C3\u00ADdo a ele. Por padr\u00C3\u00A3o, cart\u00C3\u00B5es provis\u00C3\u00B3rios ou que j\u00C3\u00A1 tenham sido inclu\u00C3\u00ADdos em um arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica ter\u00C3\u00A3o esta requisi\u00C3\u00A7\u00C3\u00A3o negada, se utilizada.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <param name="idStatusImpressao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status Impress\u00C3\u00A3o (Id).</param> 
        /// <returns>HistoricoImpressaoCartaoResponse</returns>
        public HistoricoImpressaoCartaoResponse AlterarStatusImpressaoUsingPUT (long? id, long? idStatusImpressao)
        {
             ApiResponse<HistoricoImpressaoCartaoResponse> localVarResponse = AlterarStatusImpressaoUsingPUTWithHttpInfo(id, idStatusImpressao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que uma Aplica\u00C3\u00A7\u00C3\u00A3o que realize a impress\u00C3\u00A3o de cart\u00C3\u00B5es possa indicar que um determinado idCartao fora impresso ou est\u00C3\u00A1 em processo de impress\u00C3\u00A3o. Para isso, basta informar o respectivo c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id) que deseja ter seu um determinado id_status_impressao atribu\u00C3\u00ADdo a ele. Por padr\u00C3\u00A3o, cart\u00C3\u00B5es provis\u00C3\u00B3rios ou que j\u00C3\u00A1 tenham sido inclu\u00C3\u00ADdos em um arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica ter\u00C3\u00A3o esta requisi\u00C3\u00A7\u00C3\u00A3o negada, se utilizada.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <param name="idStatusImpressao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status Impress\u00C3\u00A3o (Id).</param> 
        /// <returns>ApiResponse of HistoricoImpressaoCartaoResponse</returns>
        public ApiResponse< HistoricoImpressaoCartaoResponse > AlterarStatusImpressaoUsingPUTWithHttpInfo (long? id, long? idStatusImpressao)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->AlterarStatusImpressaoUsingPUT");
            
            // verify the required parameter 'idStatusImpressao' is set
            if (idStatusImpressao == null)
                throw new ApiException(400, "Missing required parameter 'idStatusImpressao' when calling CartaoApi->AlterarStatusImpressaoUsingPUT");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatusImpressaoUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatusImpressaoUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<HistoricoImpressaoCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HistoricoImpressaoCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(HistoricoImpressaoCartaoResponse)));
            
        }

        
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que uma Aplica\u00C3\u00A7\u00C3\u00A3o que realize a impress\u00C3\u00A3o de cart\u00C3\u00B5es possa indicar que um determinado idCartao fora impresso ou est\u00C3\u00A1 em processo de impress\u00C3\u00A3o. Para isso, basta informar o respectivo c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id) que deseja ter seu um determinado id_status_impressao atribu\u00C3\u00ADdo a ele. Por padr\u00C3\u00A3o, cart\u00C3\u00B5es provis\u00C3\u00B3rios ou que j\u00C3\u00A1 tenham sido inclu\u00C3\u00ADdos em um arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica ter\u00C3\u00A3o esta requisi\u00C3\u00A7\u00C3\u00A3o negada, se utilizada.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="idStatusImpressao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status Impress\u00C3\u00A3o (Id).</param>
        /// <returns>Task of HistoricoImpressaoCartaoResponse</returns>
        public async System.Threading.Tasks.Task<HistoricoImpressaoCartaoResponse> AlterarStatusImpressaoUsingPUTAsync (long? id, long? idStatusImpressao)
        {
             ApiResponse<HistoricoImpressaoCartaoResponse> localVarResponse = await AlterarStatusImpressaoUsingPUTAsyncWithHttpInfo(id, idStatusImpressao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que uma Aplica\u00C3\u00A7\u00C3\u00A3o que realize a impress\u00C3\u00A3o de cart\u00C3\u00B5es possa indicar que um determinado idCartao fora impresso ou est\u00C3\u00A1 em processo de impress\u00C3\u00A3o. Para isso, basta informar o respectivo c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id) que deseja ter seu um determinado id_status_impressao atribu\u00C3\u00ADdo a ele. Por padr\u00C3\u00A3o, cart\u00C3\u00B5es provis\u00C3\u00B3rios ou que j\u00C3\u00A1 tenham sido inclu\u00C3\u00ADdos em um arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica ter\u00C3\u00A3o esta requisi\u00C3\u00A7\u00C3\u00A3o negada, se utilizada.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="idStatusImpressao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status Impress\u00C3\u00A3o (Id).</param>
        /// <returns>Task of ApiResponse (HistoricoImpressaoCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<HistoricoImpressaoCartaoResponse>> AlterarStatusImpressaoUsingPUTAsyncWithHttpInfo (long? id, long? idStatusImpressao)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarStatusImpressaoUsingPUT");
            // verify the required parameter 'idStatusImpressao' is set
            if (idStatusImpressao == null) throw new ApiException(400, "Missing required parameter 'idStatusImpressao' when calling AlterarStatusImpressaoUsingPUT");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatusImpressaoUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatusImpressaoUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<HistoricoImpressaoCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HistoricoImpressaoCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(HistoricoImpressaoCartaoResponse)));
            
        }
        
        /// <summary>
        /// Realiza a atribui\u00C3\u00A7\u00C3\u00A3o de um cart\u00C3\u00A3o pr\u00C3\u00A9-pago a uma pessoa Esta m\u00C3\u00A9todo permite que um cart\u00C3\u00A3o pr\u00C3\u00A9-pago impresso de forma avulsa e an\u00C3\u00B4nimo seja atribu\u00C3\u00ADdo a uma pessoa para que esta passe a ser a portadora titular dele.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id)</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o de uma Pessoa (id).</param> 
        /// <returns>CartaoResponse</returns>
        public CartaoResponse AtribuirPessoaUsingPUT (long? id, long? idPessoa)
        {
             ApiResponse<CartaoResponse> localVarResponse = AtribuirPessoaUsingPUTWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a atribui\u00C3\u00A7\u00C3\u00A3o de um cart\u00C3\u00A3o pr\u00C3\u00A9-pago a uma pessoa Esta m\u00C3\u00A9todo permite que um cart\u00C3\u00A3o pr\u00C3\u00A9-pago impresso de forma avulsa e an\u00C3\u00B4nimo seja atribu\u00C3\u00ADdo a uma pessoa para que esta passe a ser a portadora titular dele.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id)</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o de uma Pessoa (id).</param> 
        /// <returns>ApiResponse of CartaoResponse</returns>
        public ApiResponse< CartaoResponse > AtribuirPessoaUsingPUTWithHttpInfo (long? id, long? idPessoa)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->AtribuirPessoaUsingPUT");
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling CartaoApi->AtribuirPessoaUsingPUT");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtribuirPessoaUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirPessoaUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }

        
        /// <summary>
        /// Realiza a atribui\u00C3\u00A7\u00C3\u00A3o de um cart\u00C3\u00A3o pr\u00C3\u00A9-pago a uma pessoa Esta m\u00C3\u00A9todo permite que um cart\u00C3\u00A3o pr\u00C3\u00A9-pago impresso de forma avulsa e an\u00C3\u00B4nimo seja atribu\u00C3\u00ADdo a uma pessoa para que esta passe a ser a portadora titular dele.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o de uma Pessoa (id).</param>
        /// <returns>Task of CartaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoResponse> AtribuirPessoaUsingPUTAsync (long? id, long? idPessoa)
        {
             ApiResponse<CartaoResponse> localVarResponse = await AtribuirPessoaUsingPUTAsyncWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a atribui\u00C3\u00A7\u00C3\u00A3o de um cart\u00C3\u00A3o pr\u00C3\u00A9-pago a uma pessoa Esta m\u00C3\u00A9todo permite que um cart\u00C3\u00A3o pr\u00C3\u00A9-pago impresso de forma avulsa e an\u00C3\u00B4nimo seja atribu\u00C3\u00ADdo a uma pessoa para que esta passe a ser a portadora titular dele.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o de uma Pessoa (id).</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> AtribuirPessoaUsingPUTAsyncWithHttpInfo (long? id, long? idPessoa)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtribuirPessoaUsingPUT");
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling AtribuirPessoaUsingPUT");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtribuirPessoaUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirPessoaUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }
        
        /// <summary>
        /// Realiza o bloqueio de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o do bloqueio (tempor\u00C3\u00A1rio) ou do cancelamento (definitivo) de um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id). Para isso, \u00C3\u00A9 preciso informar qual o motivo deste bloqueio que nada mais \u00C3\u00A9 do que atribuir um novo StatusCartao para ele dentre as op\u00C3\u00A7\u00C3\u00B5es praticadas pelo emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Cart\u00C3\u00A3o.</param> 
        /// <param name="observacao">Texto informando uma observa\u00C3\u00A7\u00C3\u00A3o sobre o bloqueio.</param> 
        /// <returns>CartaoResponse</returns>
        public CartaoResponse BloquearUsingPOST (long? id, long? idStatus, string observacao)
        {
             ApiResponse<CartaoResponse> localVarResponse = BloquearUsingPOSTWithHttpInfo(id, idStatus, observacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o bloqueio de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o do bloqueio (tempor\u00C3\u00A1rio) ou do cancelamento (definitivo) de um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id). Para isso, \u00C3\u00A9 preciso informar qual o motivo deste bloqueio que nada mais \u00C3\u00A9 do que atribuir um novo StatusCartao para ele dentre as op\u00C3\u00A7\u00C3\u00B5es praticadas pelo emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Cart\u00C3\u00A3o.</param> 
        /// <param name="observacao">Texto informando uma observa\u00C3\u00A7\u00C3\u00A3o sobre o bloqueio.</param> 
        /// <returns>ApiResponse of CartaoResponse</returns>
        public ApiResponse< CartaoResponse > BloquearUsingPOSTWithHttpInfo (long? id, long? idStatus, string observacao)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->BloquearUsingPOST");
            
            // verify the required parameter 'idStatus' is set
            if (idStatus == null)
                throw new ApiException(400, "Missing required parameter 'idStatus' when calling CartaoApi->BloquearUsingPOST");
            
            // verify the required parameter 'observacao' is set
            if (observacao == null)
                throw new ApiException(400, "Missing required parameter 'observacao' when calling CartaoApi->BloquearUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling BloquearUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling BloquearUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }

        
        /// <summary>
        /// Realiza o bloqueio de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o do bloqueio (tempor\u00C3\u00A1rio) ou do cancelamento (definitivo) de um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id). Para isso, \u00C3\u00A9 preciso informar qual o motivo deste bloqueio que nada mais \u00C3\u00A9 do que atribuir um novo StatusCartao para ele dentre as op\u00C3\u00A7\u00C3\u00B5es praticadas pelo emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Cart\u00C3\u00A3o.</param>
        /// <param name="observacao">Texto informando uma observa\u00C3\u00A7\u00C3\u00A3o sobre o bloqueio.</param>
        /// <returns>Task of CartaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoResponse> BloquearUsingPOSTAsync (long? id, long? idStatus, string observacao)
        {
             ApiResponse<CartaoResponse> localVarResponse = await BloquearUsingPOSTAsyncWithHttpInfo(id, idStatus, observacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o bloqueio de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o do bloqueio (tempor\u00C3\u00A1rio) ou do cancelamento (definitivo) de um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id). Para isso, \u00C3\u00A9 preciso informar qual o motivo deste bloqueio que nada mais \u00C3\u00A9 do que atribuir um novo StatusCartao para ele dentre as op\u00C3\u00A7\u00C3\u00B5es praticadas pelo emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Cart\u00C3\u00A3o.</param>
        /// <param name="observacao">Texto informando uma observa\u00C3\u00A7\u00C3\u00A3o sobre o bloqueio.</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> BloquearUsingPOSTAsyncWithHttpInfo (long? id, long? idStatus, string observacao)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling BloquearUsingPOST");
            // verify the required parameter 'idStatus' is set
            if (idStatus == null) throw new ApiException(400, "Missing required parameter 'idStatus' when calling BloquearUsingPOST");
            // verify the required parameter 'observacao' is set
            if (observacao == null) throw new ApiException(400, "Missing required parameter 'observacao' when calling BloquearUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling BloquearUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling BloquearUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro da senha de um Cart\u00C3\u00A3o Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que o portador de um determinado cart\u00C3\u00A3o possa definir uma senha a sua escolha.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <param name="senha">Senha para ser cadastrada ou alterada.</param> 
        /// <returns>string</returns>
        public string CadastrarAlterarSenhaUsingPOST (long? id, string senha)
        {
             ApiResponse<string> localVarResponse = CadastrarAlterarSenhaUsingPOSTWithHttpInfo(id, senha);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro da senha de um Cart\u00C3\u00A3o Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que o portador de um determinado cart\u00C3\u00A3o possa definir uma senha a sua escolha.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <param name="senha">Senha para ser cadastrada ou alterada.</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > CadastrarAlterarSenhaUsingPOSTWithHttpInfo (long? id, string senha)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->CadastrarAlterarSenhaUsingPOST");
            
            // verify the required parameter 'senha' is set
            if (senha == null)
                throw new ApiException(400, "Missing required parameter 'senha' when calling CartaoApi->CadastrarAlterarSenhaUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling CadastrarAlterarSenhaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarAlterarSenhaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro da senha de um Cart\u00C3\u00A3o Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que o portador de um determinado cart\u00C3\u00A3o possa definir uma senha a sua escolha.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="senha">Senha para ser cadastrada ou alterada.</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> CadastrarAlterarSenhaUsingPOSTAsync (long? id, string senha)
        {
             ApiResponse<string> localVarResponse = await CadastrarAlterarSenhaUsingPOSTAsyncWithHttpInfo(id, senha);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro da senha de um Cart\u00C3\u00A3o Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que o portador de um determinado cart\u00C3\u00A3o possa definir uma senha a sua escolha.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="senha">Senha para ser cadastrada ou alterada.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> CadastrarAlterarSenhaUsingPOSTAsyncWithHttpInfo (long? id, string senha)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CadastrarAlterarSenhaUsingPOST");
            // verify the required parameter 'senha' is set
            if (senha == null) throw new ApiException(400, "Missing required parameter 'senha' when calling CadastrarAlterarSenhaUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling CadastrarAlterarSenhaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarAlterarSenhaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Realiza o cancelamento de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o cancelamento de um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id). Para isso, \u00C3\u00A9 preciso informar qual o motivo deste bloqueio que nada mais \u00C3\u00A9 do que atribuir um novo StatusCartao para ele dentre as op\u00C3\u00A7\u00C3\u00B5es praticadas pelo emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Cart\u00C3\u00A3o.</param> 
        /// <param name="observacao">Texto informando uma observa\u00C3\u00A7\u00C3\u00A3o sobre o cancelamento.</param> 
        /// <returns>CartaoResponse</returns>
        public CartaoResponse CancelarUsingPOST (long? id, long? idStatus, string observacao)
        {
             ApiResponse<CartaoResponse> localVarResponse = CancelarUsingPOSTWithHttpInfo(id, idStatus, observacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cancelamento de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o cancelamento de um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id). Para isso, \u00C3\u00A9 preciso informar qual o motivo deste bloqueio que nada mais \u00C3\u00A9 do que atribuir um novo StatusCartao para ele dentre as op\u00C3\u00A7\u00C3\u00B5es praticadas pelo emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Cart\u00C3\u00A3o.</param> 
        /// <param name="observacao">Texto informando uma observa\u00C3\u00A7\u00C3\u00A3o sobre o cancelamento.</param> 
        /// <returns>ApiResponse of CartaoResponse</returns>
        public ApiResponse< CartaoResponse > CancelarUsingPOSTWithHttpInfo (long? id, long? idStatus, string observacao)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->CancelarUsingPOST");
            
            // verify the required parameter 'idStatus' is set
            if (idStatus == null)
                throw new ApiException(400, "Missing required parameter 'idStatus' when calling CartaoApi->CancelarUsingPOST");
            
            // verify the required parameter 'observacao' is set
            if (observacao == null)
                throw new ApiException(400, "Missing required parameter 'observacao' when calling CartaoApi->CancelarUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling CancelarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }

        
        /// <summary>
        /// Realiza o cancelamento de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o cancelamento de um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id). Para isso, \u00C3\u00A9 preciso informar qual o motivo deste bloqueio que nada mais \u00C3\u00A9 do que atribuir um novo StatusCartao para ele dentre as op\u00C3\u00A7\u00C3\u00B5es praticadas pelo emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Cart\u00C3\u00A3o.</param>
        /// <param name="observacao">Texto informando uma observa\u00C3\u00A7\u00C3\u00A3o sobre o cancelamento.</param>
        /// <returns>Task of CartaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoResponse> CancelarUsingPOSTAsync (long? id, long? idStatus, string observacao)
        {
             ApiResponse<CartaoResponse> localVarResponse = await CancelarUsingPOSTAsyncWithHttpInfo(id, idStatus, observacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cancelamento de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o cancelamento de um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id). Para isso, \u00C3\u00A9 preciso informar qual o motivo deste bloqueio que nada mais \u00C3\u00A9 do que atribuir um novo StatusCartao para ele dentre as op\u00C3\u00A7\u00C3\u00B5es praticadas pelo emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Cart\u00C3\u00A3o.</param>
        /// <param name="observacao">Texto informando uma observa\u00C3\u00A7\u00C3\u00A3o sobre o cancelamento.</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> CancelarUsingPOSTAsyncWithHttpInfo (long? id, long? idStatus, string observacao)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CancelarUsingPOST");
            // verify the required parameter 'idStatus' is set
            if (idStatus == null) throw new ApiException(400, "Missing required parameter 'idStatus' when calling CancelarUsingPOST");
            // verify the required parameter 'observacao' is set
            if (observacao == null) throw new ApiException(400, "Missing required parameter 'observacao' when calling CancelarUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling CancelarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }
        
        /// <summary>
        /// Consultar os dados de impress\u00C3\u00A3o de um Cart\u00C3\u00A3o Esse recurso permite consultar os dados de impress\u00C3\u00A3o de um cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id).</param> 
        /// <returns>DadosCartaoImpressaoResponse</returns>
        public DadosCartaoImpressaoResponse ConsultarCartaoImpressaoUsingGET (long? id)
        {
             ApiResponse<DadosCartaoImpressaoResponse> localVarResponse = ConsultarCartaoImpressaoUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar os dados de impress\u00C3\u00A3o de um Cart\u00C3\u00A3o Esse recurso permite consultar os dados de impress\u00C3\u00A3o de um cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id).</param> 
        /// <returns>ApiResponse of DadosCartaoImpressaoResponse</returns>
        public ApiResponse< DadosCartaoImpressaoResponse > ConsultarCartaoImpressaoUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->ConsultarCartaoImpressaoUsingGET");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCartaoImpressaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCartaoImpressaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DadosCartaoImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DadosCartaoImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DadosCartaoImpressaoResponse)));
            
        }

        
        /// <summary>
        /// Consultar os dados de impress\u00C3\u00A3o de um Cart\u00C3\u00A3o Esse recurso permite consultar os dados de impress\u00C3\u00A3o de um cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of DadosCartaoImpressaoResponse</returns>
        public async System.Threading.Tasks.Task<DadosCartaoImpressaoResponse> ConsultarCartaoImpressaoUsingGETAsync (long? id)
        {
             ApiResponse<DadosCartaoImpressaoResponse> localVarResponse = await ConsultarCartaoImpressaoUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar os dados de impress\u00C3\u00A3o de um Cart\u00C3\u00A3o Esse recurso permite consultar os dados de impress\u00C3\u00A3o de um cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (DadosCartaoImpressaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DadosCartaoImpressaoResponse>> ConsultarCartaoImpressaoUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarCartaoImpressaoUsingGET");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCartaoImpressaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCartaoImpressaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DadosCartaoImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DadosCartaoImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DadosCartaoImpressaoResponse)));
            
        }
        
        /// <summary>
        /// Consultar Detalhes do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que seja consultado os dados necessarios de um cart\u00C3\u00A3o para executar servi\u00C3\u00A7os de autoriza\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>DadosCartaoResponse</returns>
        public DadosCartaoResponse ConsultarDadosReaisCartaoUsingGET (long? id)
        {
             ApiResponse<DadosCartaoResponse> localVarResponse = ConsultarDadosReaisCartaoUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar Detalhes do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que seja consultado os dados necessarios de um cart\u00C3\u00A3o para executar servi\u00C3\u00A7os de autoriza\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>ApiResponse of DadosCartaoResponse</returns>
        public ApiResponse< DadosCartaoResponse > ConsultarDadosReaisCartaoUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->ConsultarDadosReaisCartaoUsingGET");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDadosReaisCartaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDadosReaisCartaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DadosCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DadosCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DadosCartaoResponse)));
            
        }

        
        /// <summary>
        /// Consultar Detalhes do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que seja consultado os dados necessarios de um cart\u00C3\u00A3o para executar servi\u00C3\u00A7os de autoriza\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of DadosCartaoResponse</returns>
        public async System.Threading.Tasks.Task<DadosCartaoResponse> ConsultarDadosReaisCartaoUsingGETAsync (long? id)
        {
             ApiResponse<DadosCartaoResponse> localVarResponse = await ConsultarDadosReaisCartaoUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar Detalhes do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que seja consultado os dados necessarios de um cart\u00C3\u00A3o para executar servi\u00C3\u00A7os de autoriza\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (DadosCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DadosCartaoResponse>> ConsultarDadosReaisCartaoUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarDadosReaisCartaoUsingGET");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDadosReaisCartaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDadosReaisCartaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DadosCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DadosCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DadosCartaoResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os limites do Portador do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar os Limites configurados para o Portador de um determinado Cart\u00C3\u00A3o, seja ele o titular da conta ou um adicional, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>LimiteDisponibilidadeResponse</returns>
        public LimiteDisponibilidadeResponse ConsultarLimiteDisponibilidadeUsingGET (long? id)
        {
             ApiResponse<LimiteDisponibilidadeResponse> localVarResponse = ConsultarLimiteDisponibilidadeUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os limites do Portador do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar os Limites configurados para o Portador de um determinado Cart\u00C3\u00A3o, seja ele o titular da conta ou um adicional, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>ApiResponse of LimiteDisponibilidadeResponse</returns>
        public ApiResponse< LimiteDisponibilidadeResponse > ConsultarLimiteDisponibilidadeUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->ConsultarLimiteDisponibilidadeUsingGET");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLimiteDisponibilidadeUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLimiteDisponibilidadeUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LimiteDisponibilidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LimiteDisponibilidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimiteDisponibilidadeResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os limites do Portador do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar os Limites configurados para o Portador de um determinado Cart\u00C3\u00A3o, seja ele o titular da conta ou um adicional, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of LimiteDisponibilidadeResponse</returns>
        public async System.Threading.Tasks.Task<LimiteDisponibilidadeResponse> ConsultarLimiteDisponibilidadeUsingGETAsync (long? id)
        {
             ApiResponse<LimiteDisponibilidadeResponse> localVarResponse = await ConsultarLimiteDisponibilidadeUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os limites do Portador do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar os Limites configurados para o Portador de um determinado Cart\u00C3\u00A3o, seja ele o titular da conta ou um adicional, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (LimiteDisponibilidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LimiteDisponibilidadeResponse>> ConsultarLimiteDisponibilidadeUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarLimiteDisponibilidadeUsingGET");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLimiteDisponibilidadeUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLimiteDisponibilidadeUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LimiteDisponibilidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LimiteDisponibilidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimiteDisponibilidadeResponse)));
            
        }
        
        /// <summary>
        /// Permite consultar um determinado Lote de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pago Este m\u00C3\u00A9todo permite consultar os cart\u00C3\u00B5es pr\u00C3\u00A9-pagos existentes na base do emissor atrav\u00C3\u00A9s do id do lote.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do lote de cart\u00C3\u00B5es (id)</param> 
        /// <returns>LoteCartoesPrePagosResponse</returns>
        public LoteCartoesPrePagosResponse ConsultarLotesCartoesPrePagosUsingGET (long? id)
        {
             ApiResponse<LoteCartoesPrePagosResponse> localVarResponse = ConsultarLotesCartoesPrePagosUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite consultar um determinado Lote de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pago Este m\u00C3\u00A9todo permite consultar os cart\u00C3\u00B5es pr\u00C3\u00A9-pagos existentes na base do emissor atrav\u00C3\u00A9s do id do lote.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do lote de cart\u00C3\u00B5es (id)</param> 
        /// <returns>ApiResponse of LoteCartoesPrePagosResponse</returns>
        public ApiResponse< LoteCartoesPrePagosResponse > ConsultarLotesCartoesPrePagosUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->ConsultarLotesCartoesPrePagosUsingGET");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLotesCartoesPrePagosUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLotesCartoesPrePagosUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LoteCartoesPrePagosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LoteCartoesPrePagosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LoteCartoesPrePagosResponse)));
            
        }

        
        /// <summary>
        /// Permite consultar um determinado Lote de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pago Este m\u00C3\u00A9todo permite consultar os cart\u00C3\u00B5es pr\u00C3\u00A9-pagos existentes na base do emissor atrav\u00C3\u00A9s do id do lote.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do lote de cart\u00C3\u00B5es (id)</param>
        /// <returns>Task of LoteCartoesPrePagosResponse</returns>
        public async System.Threading.Tasks.Task<LoteCartoesPrePagosResponse> ConsultarLotesCartoesPrePagosUsingGETAsync (long? id)
        {
             ApiResponse<LoteCartoesPrePagosResponse> localVarResponse = await ConsultarLotesCartoesPrePagosUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite consultar um determinado Lote de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pago Este m\u00C3\u00A9todo permite consultar os cart\u00C3\u00B5es pr\u00C3\u00A9-pagos existentes na base do emissor atrav\u00C3\u00A9s do id do lote.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do lote de cart\u00C3\u00B5es (id)</param>
        /// <returns>Task of ApiResponse (LoteCartoesPrePagosResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LoteCartoesPrePagosResponse>> ConsultarLotesCartoesPrePagosUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarLotesCartoesPrePagosUsingGET");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLotesCartoesPrePagosUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLotesCartoesPrePagosUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LoteCartoesPrePagosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LoteCartoesPrePagosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LoteCartoesPrePagosResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados do Portador do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es do Portador de um determinado Cart\u00C3\u00A3o a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>PortadorResponse</returns>
        public PortadorResponse ConsultarPortadorUsingGET (long? id)
        {
             ApiResponse<PortadorResponse> localVarResponse = ConsultarPortadorUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados do Portador do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es do Portador de um determinado Cart\u00C3\u00A3o a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>ApiResponse of PortadorResponse</returns>
        public ApiResponse< PortadorResponse > ConsultarPortadorUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->ConsultarPortadorUsingGET");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPortadorUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPortadorUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PortadorResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados do Portador do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es do Portador de um determinado Cart\u00C3\u00A3o a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of PortadorResponse</returns>
        public async System.Threading.Tasks.Task<PortadorResponse> ConsultarPortadorUsingGETAsync (long? id)
        {
             ApiResponse<PortadorResponse> localVarResponse = await ConsultarPortadorUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados do Portador do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es do Portador de um determinado Cart\u00C3\u00A3o a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (PortadorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PortadorResponse>> ConsultarPortadorUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarPortadorUsingGET");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPortadorUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPortadorUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PortadorResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es b\u00C3\u00A1sicas de um determinado Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>CartaoDetalheResponse</returns>
        public CartaoDetalheResponse ConsultarUsingGET7 (long? id)
        {
             ApiResponse<CartaoDetalheResponse> localVarResponse = ConsultarUsingGET7WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es b\u00C3\u00A1sicas de um determinado Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>ApiResponse of CartaoDetalheResponse</returns>
        public ApiResponse< CartaoDetalheResponse > ConsultarUsingGET7WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->ConsultarUsingGET7");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoDetalheResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es b\u00C3\u00A1sicas de um determinado Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of CartaoDetalheResponse</returns>
        public async System.Threading.Tasks.Task<CartaoDetalheResponse> ConsultarUsingGET7Async (long? id)
        {
             ApiResponse<CartaoDetalheResponse> localVarResponse = await ConsultarUsingGET7AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es b\u00C3\u00A1sicas de um determinado Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (CartaoDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoDetalheResponse>> ConsultarUsingGET7AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET7");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoDetalheResponse)));
            
        }
        
        /// <summary>
        /// Realiza o desbloqueio de um cart\u00C3\u00A3o bloqueado por tentativas de senha incorretas Este m\u00C3\u00A9todo permite que seja desbloqueado um determinado cart\u00C3\u00A3o que foi bloqueado por tentativas de senha incorretas, a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>CartaoResponse</returns>
        public CartaoResponse DesbloquearSenhaIncorretaUsingPOST (long? id)
        {
             ApiResponse<CartaoResponse> localVarResponse = DesbloquearSenhaIncorretaUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o desbloqueio de um cart\u00C3\u00A3o bloqueado por tentativas de senha incorretas Este m\u00C3\u00A9todo permite que seja desbloqueado um determinado cart\u00C3\u00A3o que foi bloqueado por tentativas de senha incorretas, a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>ApiResponse of CartaoResponse</returns>
        public ApiResponse< CartaoResponse > DesbloquearSenhaIncorretaUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->DesbloquearSenhaIncorretaUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearSenhaIncorretaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearSenhaIncorretaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }

        
        /// <summary>
        /// Realiza o desbloqueio de um cart\u00C3\u00A3o bloqueado por tentativas de senha incorretas Este m\u00C3\u00A9todo permite que seja desbloqueado um determinado cart\u00C3\u00A3o que foi bloqueado por tentativas de senha incorretas, a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of CartaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoResponse> DesbloquearSenhaIncorretaUsingPOSTAsync (long? id)
        {
             ApiResponse<CartaoResponse> localVarResponse = await DesbloquearSenhaIncorretaUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o desbloqueio de um cart\u00C3\u00A3o bloqueado por tentativas de senha incorretas Este m\u00C3\u00A9todo permite que seja desbloqueado um determinado cart\u00C3\u00A3o que foi bloqueado por tentativas de senha incorretas, a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> DesbloquearSenhaIncorretaUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesbloquearSenhaIncorretaUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearSenhaIncorretaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearSenhaIncorretaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }
        
        /// <summary>
        /// Realiza o desbloqueio de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que seja desbloqueado um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>CartaoResponse</returns>
        public CartaoResponse DesbloquearUsingPOST (long? id)
        {
             ApiResponse<CartaoResponse> localVarResponse = DesbloquearUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o desbloqueio de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que seja desbloqueado um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>ApiResponse of CartaoResponse</returns>
        public ApiResponse< CartaoResponse > DesbloquearUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->DesbloquearUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }

        
        /// <summary>
        /// Realiza o desbloqueio de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que seja desbloqueado um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of CartaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoResponse> DesbloquearUsingPOSTAsync (long? id)
        {
             ApiResponse<CartaoResponse> localVarResponse = await DesbloquearUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o desbloqueio de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que seja desbloqueado um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> DesbloquearUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesbloquearUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }
        
        /// <summary>
        /// Permite gerar um novo Lote de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pago Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores gerem uma determinada quantidade de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pagos, de forma n\u00C3\u00A3o nominal, os quais poder\u00C3\u00A3o ser comercializados e posteriormente vinculados a um cliente que o adquirir. Para isso, al\u00C3\u00A9m de definir quantos cart\u00C3\u00B5es dever\u00C3\u00A3o ser gerados, ser\u00C3\u00A1 poss\u00C3\u00ADvel definir qual a Origem Comercial, o Produto, o Tipo do Cart\u00C3\u00A3o, a Imagem e o Endere\u00C3\u00A7o para entrega dos Cart\u00C3\u00B5es presentes no lote gerado. Por padr\u00C3\u00A3o, todos os cart\u00C3\u00B5es ser\u00C3\u00A3o associados a um idPessoa fict\u00C3\u00ADcio e receber\u00C3\u00A1 um idConta \u00C3\u00BAnico para cada um deles. Feito isso, os Cart\u00C3\u00B5es gerados por esta opera\u00C3\u00A7\u00C3\u00A3o seguir\u00C3\u00A3o os mesmos processos de impress\u00C3\u00A3o via gr\u00C3\u00A1fica previamente definidos entre o Emissor e a Conductor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id). (optional)</param> 
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param> 
        /// <param name="idTipoCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Cart\u00C3\u00A3o (id). (optional)</param> 
        /// <param name="idImagem">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Imagem (id). (optional)</param> 
        /// <param name="idEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id). (optional)</param> 
        /// <param name="quantidadeCartoes">N\u00C3\u00BAmero de cart\u00C3\u00B5es existentes no Lote. (optional)</param> 
        /// <returns>LoteCartoesPrePagosResponse</returns>
        public LoteCartoesPrePagosResponse GerarLotesCartoesPrePagosUsingPOST (long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null)
        {
             ApiResponse<LoteCartoesPrePagosResponse> localVarResponse = GerarLotesCartoesPrePagosUsingPOSTWithHttpInfo(idOrigemComercial, idProduto, idTipoCartao, idImagem, idEndereco, quantidadeCartoes);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite gerar um novo Lote de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pago Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores gerem uma determinada quantidade de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pagos, de forma n\u00C3\u00A3o nominal, os quais poder\u00C3\u00A3o ser comercializados e posteriormente vinculados a um cliente que o adquirir. Para isso, al\u00C3\u00A9m de definir quantos cart\u00C3\u00B5es dever\u00C3\u00A3o ser gerados, ser\u00C3\u00A1 poss\u00C3\u00ADvel definir qual a Origem Comercial, o Produto, o Tipo do Cart\u00C3\u00A3o, a Imagem e o Endere\u00C3\u00A7o para entrega dos Cart\u00C3\u00B5es presentes no lote gerado. Por padr\u00C3\u00A3o, todos os cart\u00C3\u00B5es ser\u00C3\u00A3o associados a um idPessoa fict\u00C3\u00ADcio e receber\u00C3\u00A1 um idConta \u00C3\u00BAnico para cada um deles. Feito isso, os Cart\u00C3\u00B5es gerados por esta opera\u00C3\u00A7\u00C3\u00A3o seguir\u00C3\u00A3o os mesmos processos de impress\u00C3\u00A3o via gr\u00C3\u00A1fica previamente definidos entre o Emissor e a Conductor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id). (optional)</param> 
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param> 
        /// <param name="idTipoCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Cart\u00C3\u00A3o (id). (optional)</param> 
        /// <param name="idImagem">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Imagem (id). (optional)</param> 
        /// <param name="idEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id). (optional)</param> 
        /// <param name="quantidadeCartoes">N\u00C3\u00BAmero de cart\u00C3\u00B5es existentes no Lote. (optional)</param> 
        /// <returns>ApiResponse of LoteCartoesPrePagosResponse</returns>
        public ApiResponse< LoteCartoesPrePagosResponse > GerarLotesCartoesPrePagosUsingPOSTWithHttpInfo (long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null)
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarLotesCartoesPrePagosUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarLotesCartoesPrePagosUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LoteCartoesPrePagosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LoteCartoesPrePagosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LoteCartoesPrePagosResponse)));
            
        }

        
        /// <summary>
        /// Permite gerar um novo Lote de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pago Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores gerem uma determinada quantidade de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pagos, de forma n\u00C3\u00A3o nominal, os quais poder\u00C3\u00A3o ser comercializados e posteriormente vinculados a um cliente que o adquirir. Para isso, al\u00C3\u00A9m de definir quantos cart\u00C3\u00B5es dever\u00C3\u00A3o ser gerados, ser\u00C3\u00A1 poss\u00C3\u00ADvel definir qual a Origem Comercial, o Produto, o Tipo do Cart\u00C3\u00A3o, a Imagem e o Endere\u00C3\u00A7o para entrega dos Cart\u00C3\u00B5es presentes no lote gerado. Por padr\u00C3\u00A3o, todos os cart\u00C3\u00B5es ser\u00C3\u00A3o associados a um idPessoa fict\u00C3\u00ADcio e receber\u00C3\u00A1 um idConta \u00C3\u00BAnico para cada um deles. Feito isso, os Cart\u00C3\u00B5es gerados por esta opera\u00C3\u00A7\u00C3\u00A3o seguir\u00C3\u00A3o os mesmos processos de impress\u00C3\u00A3o via gr\u00C3\u00A1fica previamente definidos entre o Emissor e a Conductor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id). (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="idTipoCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idImagem">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Imagem (id). (optional)</param>
        /// <param name="idEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id). (optional)</param>
        /// <param name="quantidadeCartoes">N\u00C3\u00BAmero de cart\u00C3\u00B5es existentes no Lote. (optional)</param>
        /// <returns>Task of LoteCartoesPrePagosResponse</returns>
        public async System.Threading.Tasks.Task<LoteCartoesPrePagosResponse> GerarLotesCartoesPrePagosUsingPOSTAsync (long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null)
        {
             ApiResponse<LoteCartoesPrePagosResponse> localVarResponse = await GerarLotesCartoesPrePagosUsingPOSTAsyncWithHttpInfo(idOrigemComercial, idProduto, idTipoCartao, idImagem, idEndereco, quantidadeCartoes);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite gerar um novo Lote de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pago Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores gerem uma determinada quantidade de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pagos, de forma n\u00C3\u00A3o nominal, os quais poder\u00C3\u00A3o ser comercializados e posteriormente vinculados a um cliente que o adquirir. Para isso, al\u00C3\u00A9m de definir quantos cart\u00C3\u00B5es dever\u00C3\u00A3o ser gerados, ser\u00C3\u00A1 poss\u00C3\u00ADvel definir qual a Origem Comercial, o Produto, o Tipo do Cart\u00C3\u00A3o, a Imagem e o Endere\u00C3\u00A7o para entrega dos Cart\u00C3\u00B5es presentes no lote gerado. Por padr\u00C3\u00A3o, todos os cart\u00C3\u00B5es ser\u00C3\u00A3o associados a um idPessoa fict\u00C3\u00ADcio e receber\u00C3\u00A1 um idConta \u00C3\u00BAnico para cada um deles. Feito isso, os Cart\u00C3\u00B5es gerados por esta opera\u00C3\u00A7\u00C3\u00A3o seguir\u00C3\u00A3o os mesmos processos de impress\u00C3\u00A3o via gr\u00C3\u00A1fica previamente definidos entre o Emissor e a Conductor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id). (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="idTipoCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idImagem">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Imagem (id). (optional)</param>
        /// <param name="idEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id). (optional)</param>
        /// <param name="quantidadeCartoes">N\u00C3\u00BAmero de cart\u00C3\u00B5es existentes no Lote. (optional)</param>
        /// <returns>Task of ApiResponse (LoteCartoesPrePagosResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LoteCartoesPrePagosResponse>> GerarLotesCartoesPrePagosUsingPOSTAsyncWithHttpInfo (long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null)
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarLotesCartoesPrePagosUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarLotesCartoesPrePagosUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LoteCartoesPrePagosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LoteCartoesPrePagosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LoteCartoesPrePagosResponse)));
            
        }
        
        /// <summary>
        /// Gerar uma nova via de Cart\u00C3\u00A3o Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores ou seus clientes possam solicitar a gera\u00C3\u00A7\u00C3\u00A3o de uma nova via de Cart\u00C3\u00A3o que ser\u00C3\u00A1 encaminhando para impress\u00C3\u00A3o e postagem de acordo com os fluxos padr\u00C3\u00B5es j\u00C3\u00A1 definidos pelo emissor. Para isso, \u00C3\u00A9 preciso que o cliente j\u00C3\u00A1 possua um cart\u00C3\u00A3o gerado e informar o C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o deste (idCartao) para que ele possa utilizar esta opera\u00C3\u00A7\u00C3\u00A3o. Assim, esta funcionalidade se aplica apenas para a gera\u00C3\u00A7\u00C3\u00A3o de cart\u00C3\u00B5es f\u00C3\u00ADsicos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id)</param> 
        /// <returns>CartaoResponse</returns>
        public CartaoResponse GerarNovaViaUsingPOST (long? id)
        {
             ApiResponse<CartaoResponse> localVarResponse = GerarNovaViaUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gerar uma nova via de Cart\u00C3\u00A3o Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores ou seus clientes possam solicitar a gera\u00C3\u00A7\u00C3\u00A3o de uma nova via de Cart\u00C3\u00A3o que ser\u00C3\u00A1 encaminhando para impress\u00C3\u00A3o e postagem de acordo com os fluxos padr\u00C3\u00B5es j\u00C3\u00A1 definidos pelo emissor. Para isso, \u00C3\u00A9 preciso que o cliente j\u00C3\u00A1 possua um cart\u00C3\u00A3o gerado e informar o C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o deste (idCartao) para que ele possa utilizar esta opera\u00C3\u00A7\u00C3\u00A3o. Assim, esta funcionalidade se aplica apenas para a gera\u00C3\u00A7\u00C3\u00A3o de cart\u00C3\u00B5es f\u00C3\u00ADsicos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id)</param> 
        /// <returns>ApiResponse of CartaoResponse</returns>
        public ApiResponse< CartaoResponse > GerarNovaViaUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->GerarNovaViaUsingPOST");
            
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarNovaViaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarNovaViaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }

        
        /// <summary>
        /// Gerar uma nova via de Cart\u00C3\u00A3o Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores ou seus clientes possam solicitar a gera\u00C3\u00A7\u00C3\u00A3o de uma nova via de Cart\u00C3\u00A3o que ser\u00C3\u00A1 encaminhando para impress\u00C3\u00A3o e postagem de acordo com os fluxos padr\u00C3\u00B5es j\u00C3\u00A1 definidos pelo emissor. Para isso, \u00C3\u00A9 preciso que o cliente j\u00C3\u00A1 possua um cart\u00C3\u00A3o gerado e informar o C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o deste (idCartao) para que ele possa utilizar esta opera\u00C3\u00A7\u00C3\u00A3o. Assim, esta funcionalidade se aplica apenas para a gera\u00C3\u00A7\u00C3\u00A3o de cart\u00C3\u00B5es f\u00C3\u00ADsicos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id)</param>
        /// <returns>Task of CartaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoResponse> GerarNovaViaUsingPOSTAsync (long? id)
        {
             ApiResponse<CartaoResponse> localVarResponse = await GerarNovaViaUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gerar uma nova via de Cart\u00C3\u00A3o Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores ou seus clientes possam solicitar a gera\u00C3\u00A7\u00C3\u00A3o de uma nova via de Cart\u00C3\u00A3o que ser\u00C3\u00A1 encaminhando para impress\u00C3\u00A3o e postagem de acordo com os fluxos padr\u00C3\u00B5es j\u00C3\u00A1 definidos pelo emissor. Para isso, \u00C3\u00A9 preciso que o cliente j\u00C3\u00A1 possua um cart\u00C3\u00A3o gerado e informar o C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o deste (idCartao) para que ele possa utilizar esta opera\u00C3\u00A7\u00C3\u00A3o. Assim, esta funcionalidade se aplica apenas para a gera\u00C3\u00A7\u00C3\u00A3o de cart\u00C3\u00B5es f\u00C3\u00ADsicos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id)</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> GerarNovaViaUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GerarNovaViaUsingPOST");
            
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarNovaViaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarNovaViaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }
        
        /// <summary>
        /// Adiciona tarifa de ajuste da segunda via do cart\u00C3\u00A3o Esse recurso permite adicionar tar\u00C3\u00ADfa de ajuste pela emiss\u00C3\u00A3o da segunda via do cart\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id).</param> 
        /// <returns>Object</returns>
        public Object LancarTarifaSegundaViaUsingPOST (long? id)
        {
             ApiResponse<Object> localVarResponse = LancarTarifaSegundaViaUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Adiciona tarifa de ajuste da segunda via do cart\u00C3\u00A3o Esse recurso permite adicionar tar\u00C3\u00ADfa de ajuste pela emiss\u00C3\u00A3o da segunda via do cart\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id).</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > LancarTarifaSegundaViaUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->LancarTarifaSegundaViaUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling LancarTarifaSegundaViaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling LancarTarifaSegundaViaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Adiciona tarifa de ajuste da segunda via do cart\u00C3\u00A3o Esse recurso permite adicionar tar\u00C3\u00ADfa de ajuste pela emiss\u00C3\u00A3o da segunda via do cart\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> LancarTarifaSegundaViaUsingPOSTAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await LancarTarifaSegundaViaUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Adiciona tarifa de ajuste da segunda via do cart\u00C3\u00A3o Esse recurso permite adicionar tar\u00C3\u00ADfa de ajuste pela emiss\u00C3\u00A3o da segunda via do cart\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> LancarTarifaSegundaViaUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling LancarTarifaSegundaViaUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling LancarTarifaSegundaViaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling LancarTarifaSegundaViaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Permite listar os Lotes de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pago Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es pr\u00C3\u00A9-pagos existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id). (optional)</param> 
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param> 
        /// <param name="idTipoCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Cart\u00C3\u00A3o (id). (optional)</param> 
        /// <param name="idImagem">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Imagem (id). (optional)</param> 
        /// <param name="idEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id). (optional)</param> 
        /// <param name="quantidadeCartoes">N\u00C3\u00BAmero de cart\u00C3\u00B5es existentes no Lote. (optional)</param> 
        /// <param name="dataCadastro">Data de Cadastro do Lote de Cart\u00C3\u00B5es N\u00C3\u00A3o Nominais. (optional)</param> 
        /// <param name="usuarioCadastro">Nome do Usu\u00C3\u00A1rio que criou o Lote. (optional)</param> 
        /// <param name="statusProcessamento">Indica o Status de Processamento do Lote. (optional)</param> 
        /// <returns>PageLoteCartoesPrePagosResponse</returns>
        public PageLoteCartoesPrePagosResponse ListarLotesCartoesPrePagosUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string dataCadastro = null, string usuarioCadastro = null, int? statusProcessamento = null)
        {
             ApiResponse<PageLoteCartoesPrePagosResponse> localVarResponse = ListarLotesCartoesPrePagosUsingGETWithHttpInfo(sort, page, limit, idOrigemComercial, idProduto, idTipoCartao, idImagem, idEndereco, quantidadeCartoes, dataCadastro, usuarioCadastro, statusProcessamento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite listar os Lotes de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pago Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es pr\u00C3\u00A9-pagos existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id). (optional)</param> 
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param> 
        /// <param name="idTipoCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Cart\u00C3\u00A3o (id). (optional)</param> 
        /// <param name="idImagem">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Imagem (id). (optional)</param> 
        /// <param name="idEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id). (optional)</param> 
        /// <param name="quantidadeCartoes">N\u00C3\u00BAmero de cart\u00C3\u00B5es existentes no Lote. (optional)</param> 
        /// <param name="dataCadastro">Data de Cadastro do Lote de Cart\u00C3\u00B5es N\u00C3\u00A3o Nominais. (optional)</param> 
        /// <param name="usuarioCadastro">Nome do Usu\u00C3\u00A1rio que criou o Lote. (optional)</param> 
        /// <param name="statusProcessamento">Indica o Status de Processamento do Lote. (optional)</param> 
        /// <returns>ApiResponse of PageLoteCartoesPrePagosResponse</returns>
        public ApiResponse< PageLoteCartoesPrePagosResponse > ListarLotesCartoesPrePagosUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string dataCadastro = null, string usuarioCadastro = null, int? statusProcessamento = null)
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarLotesCartoesPrePagosUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarLotesCartoesPrePagosUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageLoteCartoesPrePagosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageLoteCartoesPrePagosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageLoteCartoesPrePagosResponse)));
            
        }

        
        /// <summary>
        /// Permite listar os Lotes de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pago Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es pr\u00C3\u00A9-pagos existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id). (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="idTipoCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idImagem">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Imagem (id). (optional)</param>
        /// <param name="idEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id). (optional)</param>
        /// <param name="quantidadeCartoes">N\u00C3\u00BAmero de cart\u00C3\u00B5es existentes no Lote. (optional)</param>
        /// <param name="dataCadastro">Data de Cadastro do Lote de Cart\u00C3\u00B5es N\u00C3\u00A3o Nominais. (optional)</param>
        /// <param name="usuarioCadastro">Nome do Usu\u00C3\u00A1rio que criou o Lote. (optional)</param>
        /// <param name="statusProcessamento">Indica o Status de Processamento do Lote. (optional)</param>
        /// <returns>Task of PageLoteCartoesPrePagosResponse</returns>
        public async System.Threading.Tasks.Task<PageLoteCartoesPrePagosResponse> ListarLotesCartoesPrePagosUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string dataCadastro = null, string usuarioCadastro = null, int? statusProcessamento = null)
        {
             ApiResponse<PageLoteCartoesPrePagosResponse> localVarResponse = await ListarLotesCartoesPrePagosUsingGETAsyncWithHttpInfo(sort, page, limit, idOrigemComercial, idProduto, idTipoCartao, idImagem, idEndereco, quantidadeCartoes, dataCadastro, usuarioCadastro, statusProcessamento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite listar os Lotes de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pago Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es pr\u00C3\u00A9-pagos existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id). (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="idTipoCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idImagem">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Imagem (id). (optional)</param>
        /// <param name="idEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id). (optional)</param>
        /// <param name="quantidadeCartoes">N\u00C3\u00BAmero de cart\u00C3\u00B5es existentes no Lote. (optional)</param>
        /// <param name="dataCadastro">Data de Cadastro do Lote de Cart\u00C3\u00B5es N\u00C3\u00A3o Nominais. (optional)</param>
        /// <param name="usuarioCadastro">Nome do Usu\u00C3\u00A1rio que criou o Lote. (optional)</param>
        /// <param name="statusProcessamento">Indica o Status de Processamento do Lote. (optional)</param>
        /// <returns>Task of ApiResponse (PageLoteCartoesPrePagosResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageLoteCartoesPrePagosResponse>> ListarLotesCartoesPrePagosUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string dataCadastro = null, string usuarioCadastro = null, int? statusProcessamento = null)
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarLotesCartoesPrePagosUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarLotesCartoesPrePagosUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageLoteCartoesPrePagosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageLoteCartoesPrePagosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageLoteCartoesPrePagosResponse)));
            
        }
        
        /// <summary>
        /// Lista os Cart\u00C3\u00B5es gerados pelo Emissor Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (optional)</param> 
        /// <param name="idEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param> 
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence (id). (optional)</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o cart\u00C3\u00A3o pertence (id) (optional)</param> 
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence (id). (optional)</param> 
        /// <param name="tipoPortador">Apresenta o tipo do Portador do cart\u00C3\u00A3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional). (optional)</param> 
        /// <param name="numeroCartao">Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="nomeImpresso">Apresenta o nome impresso no cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="dataGeracao">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param> 
        /// <param name="dataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param> 
        /// <param name="dataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param> 
        /// <param name="dataValidade">Apresenta a data de validade do cart\u00C3\u00A3o em formato yyyy-MM, quando houver. (optional)</param> 
        /// <param name="dataImpressao">Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica. (optional)</param> 
        /// <param name="arquivoImpressao">Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver. (optional)</param> 
        /// <param name="flagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial. (optional)</param> 
        /// <param name="flagProvisorio">Quando ativa, indica que o cart\u00C3\u00A3o \u00C3\u00A9 provis\u00C3\u00B3rio. Ou seja, \u00C3\u00A9 um cart\u00C3\u00A3o para uso tempor\u00C3\u00A1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00C3\u00A3o definitivo. (optional)</param> 
        /// <param name="codigoDesbloqueio">Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade. (optional)</param> 
        /// <param name="sequencialCartao">N\u00C3\u00BAmero sequencial do cart\u00C3\u00A3o (optional)</param> 
        /// <returns>PageCartaoResponse</returns>
        public PageCartaoResponse ListarUsingGET7 (List<string> sort = null, int? page = null, int? limit = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? sequencialCartao = null)
        {
             ApiResponse<PageCartaoResponse> localVarResponse = ListarUsingGET7WithHttpInfo(sort, page, limit, idStatusCartao, idEstagioCartao, idConta, idPessoa, idProduto, tipoPortador, numeroCartao, nomeImpresso, dataGeracao, dataStatusCartao, dataEstagioCartao, dataValidade, dataImpressao, arquivoImpressao, flagImpressaoOrigemComercial, flagProvisorio, codigoDesbloqueio, sequencialCartao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Cart\u00C3\u00B5es gerados pelo Emissor Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (optional)</param> 
        /// <param name="idEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param> 
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence (id). (optional)</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o cart\u00C3\u00A3o pertence (id) (optional)</param> 
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence (id). (optional)</param> 
        /// <param name="tipoPortador">Apresenta o tipo do Portador do cart\u00C3\u00A3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional). (optional)</param> 
        /// <param name="numeroCartao">Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="nomeImpresso">Apresenta o nome impresso no cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="dataGeracao">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param> 
        /// <param name="dataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param> 
        /// <param name="dataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param> 
        /// <param name="dataValidade">Apresenta a data de validade do cart\u00C3\u00A3o em formato yyyy-MM, quando houver. (optional)</param> 
        /// <param name="dataImpressao">Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica. (optional)</param> 
        /// <param name="arquivoImpressao">Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver. (optional)</param> 
        /// <param name="flagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial. (optional)</param> 
        /// <param name="flagProvisorio">Quando ativa, indica que o cart\u00C3\u00A3o \u00C3\u00A9 provis\u00C3\u00B3rio. Ou seja, \u00C3\u00A9 um cart\u00C3\u00A3o para uso tempor\u00C3\u00A1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00C3\u00A3o definitivo. (optional)</param> 
        /// <param name="codigoDesbloqueio">Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade. (optional)</param> 
        /// <param name="sequencialCartao">N\u00C3\u00BAmero sequencial do cart\u00C3\u00A3o (optional)</param> 
        /// <returns>ApiResponse of PageCartaoResponse</returns>
        public ApiResponse< PageCartaoResponse > ListarUsingGET7WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? sequencialCartao = null)
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCartaoResponse)));
            
        }

        
        /// <summary>
        /// Lista os Cart\u00C3\u00B5es gerados pelo Emissor Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o cart\u00C3\u00A3o pertence (id) (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="tipoPortador">Apresenta o tipo do Portador do cart\u00C3\u00A3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional). (optional)</param>
        /// <param name="numeroCartao">Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome impresso no cart\u00C3\u00A3o. (optional)</param>
        /// <param name="dataGeracao">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param>
        /// <param name="dataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataValidade">Apresenta a data de validade do cart\u00C3\u00A3o em formato yyyy-MM, quando houver. (optional)</param>
        /// <param name="dataImpressao">Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica. (optional)</param>
        /// <param name="arquivoImpressao">Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver. (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial. (optional)</param>
        /// <param name="flagProvisorio">Quando ativa, indica que o cart\u00C3\u00A3o \u00C3\u00A9 provis\u00C3\u00B3rio. Ou seja, \u00C3\u00A9 um cart\u00C3\u00A3o para uso tempor\u00C3\u00A1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00C3\u00A3o definitivo. (optional)</param>
        /// <param name="codigoDesbloqueio">Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade. (optional)</param>
        /// <param name="sequencialCartao">N\u00C3\u00BAmero sequencial do cart\u00C3\u00A3o (optional)</param>
        /// <returns>Task of PageCartaoResponse</returns>
        public async System.Threading.Tasks.Task<PageCartaoResponse> ListarUsingGET7Async (List<string> sort = null, int? page = null, int? limit = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? sequencialCartao = null)
        {
             ApiResponse<PageCartaoResponse> localVarResponse = await ListarUsingGET7AsyncWithHttpInfo(sort, page, limit, idStatusCartao, idEstagioCartao, idConta, idPessoa, idProduto, tipoPortador, numeroCartao, nomeImpresso, dataGeracao, dataStatusCartao, dataEstagioCartao, dataValidade, dataImpressao, arquivoImpressao, flagImpressaoOrigemComercial, flagProvisorio, codigoDesbloqueio, sequencialCartao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Cart\u00C3\u00B5es gerados pelo Emissor Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o cart\u00C3\u00A3o pertence (id) (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence (id). (optional)</param>
        /// <param name="tipoPortador">Apresenta o tipo do Portador do cart\u00C3\u00A3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional). (optional)</param>
        /// <param name="numeroCartao">Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome impresso no cart\u00C3\u00A3o. (optional)</param>
        /// <param name="dataGeracao">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (optional)</param>
        /// <param name="dataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (optional)</param>
        /// <param name="dataValidade">Apresenta a data de validade do cart\u00C3\u00A3o em formato yyyy-MM, quando houver. (optional)</param>
        /// <param name="dataImpressao">Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica. (optional)</param>
        /// <param name="arquivoImpressao">Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver. (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial. (optional)</param>
        /// <param name="flagProvisorio">Quando ativa, indica que o cart\u00C3\u00A3o \u00C3\u00A9 provis\u00C3\u00B3rio. Ou seja, \u00C3\u00A9 um cart\u00C3\u00A3o para uso tempor\u00C3\u00A1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00C3\u00A3o definitivo. (optional)</param>
        /// <param name="codigoDesbloqueio">Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade. (optional)</param>
        /// <param name="sequencialCartao">N\u00C3\u00BAmero sequencial do cart\u00C3\u00A3o (optional)</param>
        /// <returns>Task of ApiResponse (PageCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCartaoResponse>> ListarUsingGET7AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? sequencialCartao = null)
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCartaoResponse)));
            
        }
        
        /// <summary>
        /// Realiza a reativa\u00C3\u00A7\u00C3\u00A3o de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o da reativa\u00C3\u00A7\u00C3\u00A3o de um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>CartaoResponse</returns>
        public CartaoResponse ReativarUsingPOST (long? id)
        {
             ApiResponse<CartaoResponse> localVarResponse = ReativarUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a reativa\u00C3\u00A7\u00C3\u00A3o de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o da reativa\u00C3\u00A7\u00C3\u00A3o de um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>ApiResponse of CartaoResponse</returns>
        public ApiResponse< CartaoResponse > ReativarUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->ReativarUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ReativarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ReativarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }

        
        /// <summary>
        /// Realiza a reativa\u00C3\u00A7\u00C3\u00A3o de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o da reativa\u00C3\u00A7\u00C3\u00A3o de um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of CartaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoResponse> ReativarUsingPOSTAsync (long? id)
        {
             ApiResponse<CartaoResponse> localVarResponse = await ReativarUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a reativa\u00C3\u00A7\u00C3\u00A3o de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o da reativa\u00C3\u00A7\u00C3\u00A3o de um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> ReativarUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReativarUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ReativarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ReativarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }
        
        /// <summary>
        /// Permite validar os dados impressos em um cart\u00C3\u00A3o bandeirado Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir do envio dos dados sens\u00C3\u00ADveis impressos nele. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o para a realiza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00C3\u00B4nico (URA), dentre outras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param> 
        /// <param name="nomePortador">Nome do portador do cart\u00C3\u00A3o</param> 
        /// <param name="dataValidade">Data de validade do cart\u00C3\u00A3o no formato yyyy-MM</param> 
        /// <param name="codigoSeguranca">C\u00C3\u00B3digo de seguran\u00C3\u00A7a do cart\u00C3\u00A3o com tr\u00C3\u00AAs n\u00C3\u00BAmeros</param> 
        /// <returns>ValidaCartaoResponse</returns>
        public ValidaCartaoResponse ValidarDadosImpressosBandeiradoUsingGET (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
             ApiResponse<ValidaCartaoResponse> localVarResponse = ValidarDadosImpressosBandeiradoUsingGETWithHttpInfo(numeroCartao, nomePortador, dataValidade, codigoSeguranca);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite validar os dados impressos em um cart\u00C3\u00A3o bandeirado Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir do envio dos dados sens\u00C3\u00ADveis impressos nele. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o para a realiza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00C3\u00B4nico (URA), dentre outras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param> 
        /// <param name="nomePortador">Nome do portador do cart\u00C3\u00A3o</param> 
        /// <param name="dataValidade">Data de validade do cart\u00C3\u00A3o no formato yyyy-MM</param> 
        /// <param name="codigoSeguranca">C\u00C3\u00B3digo de seguran\u00C3\u00A7a do cart\u00C3\u00A3o com tr\u00C3\u00AAs n\u00C3\u00BAmeros</param> 
        /// <returns>ApiResponse of ValidaCartaoResponse</returns>
        public ApiResponse< ValidaCartaoResponse > ValidarDadosImpressosBandeiradoUsingGETWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
            
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null)
                throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling CartaoApi->ValidarDadosImpressosBandeiradoUsingGET");
            
            // verify the required parameter 'nomePortador' is set
            if (nomePortador == null)
                throw new ApiException(400, "Missing required parameter 'nomePortador' when calling CartaoApi->ValidarDadosImpressosBandeiradoUsingGET");
            
            // verify the required parameter 'dataValidade' is set
            if (dataValidade == null)
                throw new ApiException(400, "Missing required parameter 'dataValidade' when calling CartaoApi->ValidarDadosImpressosBandeiradoUsingGET");
            
            // verify the required parameter 'codigoSeguranca' is set
            if (codigoSeguranca == null)
                throw new ApiException(400, "Missing required parameter 'codigoSeguranca' when calling CartaoApi->ValidarDadosImpressosBandeiradoUsingGET");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosImpressosBandeiradoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosImpressosBandeiradoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ValidaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartaoResponse)));
            
        }

        
        /// <summary>
        /// Permite validar os dados impressos em um cart\u00C3\u00A3o bandeirado Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir do envio dos dados sens\u00C3\u00ADveis impressos nele. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o para a realiza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00C3\u00B4nico (URA), dentre outras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="nomePortador">Nome do portador do cart\u00C3\u00A3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00C3\u00A3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00C3\u00B3digo de seguran\u00C3\u00A7a do cart\u00C3\u00A3o com tr\u00C3\u00AAs n\u00C3\u00BAmeros</param>
        /// <returns>Task of ValidaCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ValidaCartaoResponse> ValidarDadosImpressosBandeiradoUsingGETAsync (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
             ApiResponse<ValidaCartaoResponse> localVarResponse = await ValidarDadosImpressosBandeiradoUsingGETAsyncWithHttpInfo(numeroCartao, nomePortador, dataValidade, codigoSeguranca);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite validar os dados impressos em um cart\u00C3\u00A3o bandeirado Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir do envio dos dados sens\u00C3\u00ADveis impressos nele. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o para a realiza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00C3\u00B4nico (URA), dentre outras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="nomePortador">Nome do portador do cart\u00C3\u00A3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00C3\u00A3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00C3\u00B3digo de seguran\u00C3\u00A7a do cart\u00C3\u00A3o com tr\u00C3\u00AAs n\u00C3\u00BAmeros</param>
        /// <returns>Task of ApiResponse (ValidaCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ValidaCartaoResponse>> ValidarDadosImpressosBandeiradoUsingGETAsyncWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null) throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling ValidarDadosImpressosBandeiradoUsingGET");
            // verify the required parameter 'nomePortador' is set
            if (nomePortador == null) throw new ApiException(400, "Missing required parameter 'nomePortador' when calling ValidarDadosImpressosBandeiradoUsingGET");
            // verify the required parameter 'dataValidade' is set
            if (dataValidade == null) throw new ApiException(400, "Missing required parameter 'dataValidade' when calling ValidarDadosImpressosBandeiradoUsingGET");
            // verify the required parameter 'codigoSeguranca' is set
            if (codigoSeguranca == null) throw new ApiException(400, "Missing required parameter 'codigoSeguranca' when calling ValidarDadosImpressosBandeiradoUsingGET");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosImpressosBandeiradoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosImpressosBandeiradoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ValidaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartaoResponse)));
            
        }
        
        /// <summary>
        /// Permite validar os dados impressos de um cartao n\u00C3\u00A3o bandeirado Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir do envio dos dados sens\u00C3\u00ADveis impressos nele. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o para a realiza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00C3\u00B4nico (URA), dentre outras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param> 
        /// <param name="nomePortador">Nome do portador do cart\u00C3\u00A3o</param> 
        /// <param name="dataValidade">Data de validade do cart\u00C3\u00A3o no formato yyyy-MM</param> 
        /// <param name="codigoSeguranca">C\u00C3\u00B3digo de seguran\u00C3\u00A7a do cart\u00C3\u00A3o com tr\u00C3\u00AAs n\u00C3\u00BAmeros</param> 
        /// <returns>ValidaCartaoResponse</returns>
        public ValidaCartaoResponse ValidarDadosImpressosNaoBandeiradoUsingGET (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
             ApiResponse<ValidaCartaoResponse> localVarResponse = ValidarDadosImpressosNaoBandeiradoUsingGETWithHttpInfo(numeroCartao, nomePortador, dataValidade, codigoSeguranca);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite validar os dados impressos de um cartao n\u00C3\u00A3o bandeirado Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir do envio dos dados sens\u00C3\u00ADveis impressos nele. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o para a realiza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00C3\u00B4nico (URA), dentre outras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param> 
        /// <param name="nomePortador">Nome do portador do cart\u00C3\u00A3o</param> 
        /// <param name="dataValidade">Data de validade do cart\u00C3\u00A3o no formato yyyy-MM</param> 
        /// <param name="codigoSeguranca">C\u00C3\u00B3digo de seguran\u00C3\u00A7a do cart\u00C3\u00A3o com tr\u00C3\u00AAs n\u00C3\u00BAmeros</param> 
        /// <returns>ApiResponse of ValidaCartaoResponse</returns>
        public ApiResponse< ValidaCartaoResponse > ValidarDadosImpressosNaoBandeiradoUsingGETWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
            
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null)
                throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling CartaoApi->ValidarDadosImpressosNaoBandeiradoUsingGET");
            
            // verify the required parameter 'nomePortador' is set
            if (nomePortador == null)
                throw new ApiException(400, "Missing required parameter 'nomePortador' when calling CartaoApi->ValidarDadosImpressosNaoBandeiradoUsingGET");
            
            // verify the required parameter 'dataValidade' is set
            if (dataValidade == null)
                throw new ApiException(400, "Missing required parameter 'dataValidade' when calling CartaoApi->ValidarDadosImpressosNaoBandeiradoUsingGET");
            
            // verify the required parameter 'codigoSeguranca' is set
            if (codigoSeguranca == null)
                throw new ApiException(400, "Missing required parameter 'codigoSeguranca' when calling CartaoApi->ValidarDadosImpressosNaoBandeiradoUsingGET");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosImpressosNaoBandeiradoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosImpressosNaoBandeiradoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ValidaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartaoResponse)));
            
        }

        
        /// <summary>
        /// Permite validar os dados impressos de um cartao n\u00C3\u00A3o bandeirado Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir do envio dos dados sens\u00C3\u00ADveis impressos nele. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o para a realiza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00C3\u00B4nico (URA), dentre outras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="nomePortador">Nome do portador do cart\u00C3\u00A3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00C3\u00A3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00C3\u00B3digo de seguran\u00C3\u00A7a do cart\u00C3\u00A3o com tr\u00C3\u00AAs n\u00C3\u00BAmeros</param>
        /// <returns>Task of ValidaCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ValidaCartaoResponse> ValidarDadosImpressosNaoBandeiradoUsingGETAsync (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
             ApiResponse<ValidaCartaoResponse> localVarResponse = await ValidarDadosImpressosNaoBandeiradoUsingGETAsyncWithHttpInfo(numeroCartao, nomePortador, dataValidade, codigoSeguranca);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite validar os dados impressos de um cartao n\u00C3\u00A3o bandeirado Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir do envio dos dados sens\u00C3\u00ADveis impressos nele. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o para a realiza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00C3\u00B4nico (URA), dentre outras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="nomePortador">Nome do portador do cart\u00C3\u00A3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00C3\u00A3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00C3\u00B3digo de seguran\u00C3\u00A7a do cart\u00C3\u00A3o com tr\u00C3\u00AAs n\u00C3\u00BAmeros</param>
        /// <returns>Task of ApiResponse (ValidaCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ValidaCartaoResponse>> ValidarDadosImpressosNaoBandeiradoUsingGETAsyncWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null) throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling ValidarDadosImpressosNaoBandeiradoUsingGET");
            // verify the required parameter 'nomePortador' is set
            if (nomePortador == null) throw new ApiException(400, "Missing required parameter 'nomePortador' when calling ValidarDadosImpressosNaoBandeiradoUsingGET");
            // verify the required parameter 'dataValidade' is set
            if (dataValidade == null) throw new ApiException(400, "Missing required parameter 'dataValidade' when calling ValidarDadosImpressosNaoBandeiradoUsingGET");
            // verify the required parameter 'codigoSeguranca' is set
            if (codigoSeguranca == null) throw new ApiException(400, "Missing required parameter 'codigoSeguranca' when calling ValidarDadosImpressosNaoBandeiradoUsingGET");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosImpressosNaoBandeiradoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosImpressosNaoBandeiradoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ValidaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartaoResponse)));
            
        }
        
        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o com bandeira Mastercard a partir do de55 Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem o DE55 gerado a partir da leitura de um chip EMV de um Cart\u00C3\u00A3o com bandeira Mastercard a fim de verificar a sua autenticidade. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o antes de permitir que o portador realize transa\u00C3\u00A7\u00C3\u00B5es diversas, como as de compra e saque na modalidade d\u00C3\u00A9bito em conta corrente, dentre outras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param> 
        /// <param name="criptograma">Criptograma do cart\u00C3\u00A3o no formato de55</param> 
        /// <returns>ValidaCartaoResponse</returns>
        public ValidaCartaoResponse ValidarDe55CartaoMastercardUsingGET (string numeroCartao, string criptograma)
        {
             ApiResponse<ValidaCartaoResponse> localVarResponse = ValidarDe55CartaoMastercardUsingGETWithHttpInfo(numeroCartao, criptograma);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o com bandeira Mastercard a partir do de55 Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem o DE55 gerado a partir da leitura de um chip EMV de um Cart\u00C3\u00A3o com bandeira Mastercard a fim de verificar a sua autenticidade. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o antes de permitir que o portador realize transa\u00C3\u00A7\u00C3\u00B5es diversas, como as de compra e saque na modalidade d\u00C3\u00A9bito em conta corrente, dentre outras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param> 
        /// <param name="criptograma">Criptograma do cart\u00C3\u00A3o no formato de55</param> 
        /// <returns>ApiResponse of ValidaCartaoResponse</returns>
        public ApiResponse< ValidaCartaoResponse > ValidarDe55CartaoMastercardUsingGETWithHttpInfo (string numeroCartao, string criptograma)
        {
            
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null)
                throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling CartaoApi->ValidarDe55CartaoMastercardUsingGET");
            
            // verify the required parameter 'criptograma' is set
            if (criptograma == null)
                throw new ApiException(400, "Missing required parameter 'criptograma' when calling CartaoApi->ValidarDe55CartaoMastercardUsingGET");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarDe55CartaoMastercardUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDe55CartaoMastercardUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ValidaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartaoResponse)));
            
        }

        
        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o com bandeira Mastercard a partir do de55 Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem o DE55 gerado a partir da leitura de um chip EMV de um Cart\u00C3\u00A3o com bandeira Mastercard a fim de verificar a sua autenticidade. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o antes de permitir que o portador realize transa\u00C3\u00A7\u00C3\u00B5es diversas, como as de compra e saque na modalidade d\u00C3\u00A9bito em conta corrente, dentre outras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="criptograma">Criptograma do cart\u00C3\u00A3o no formato de55</param>
        /// <returns>Task of ValidaCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ValidaCartaoResponse> ValidarDe55CartaoMastercardUsingGETAsync (string numeroCartao, string criptograma)
        {
             ApiResponse<ValidaCartaoResponse> localVarResponse = await ValidarDe55CartaoMastercardUsingGETAsyncWithHttpInfo(numeroCartao, criptograma);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o com bandeira Mastercard a partir do de55 Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem o DE55 gerado a partir da leitura de um chip EMV de um Cart\u00C3\u00A3o com bandeira Mastercard a fim de verificar a sua autenticidade. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o antes de permitir que o portador realize transa\u00C3\u00A7\u00C3\u00B5es diversas, como as de compra e saque na modalidade d\u00C3\u00A9bito em conta corrente, dentre outras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="criptograma">Criptograma do cart\u00C3\u00A3o no formato de55</param>
        /// <returns>Task of ApiResponse (ValidaCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ValidaCartaoResponse>> ValidarDe55CartaoMastercardUsingGETAsyncWithHttpInfo (string numeroCartao, string criptograma)
        {
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null) throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling ValidarDe55CartaoMastercardUsingGET");
            // verify the required parameter 'criptograma' is set
            if (criptograma == null) throw new ApiException(400, "Missing required parameter 'criptograma' when calling ValidarDe55CartaoMastercardUsingGET");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarDe55CartaoMastercardUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDe55CartaoMastercardUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ValidaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartaoResponse)));
            
        }
        
        /// <summary>
        /// Permite validar a senha de um Cart\u00C3\u00A3o Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir validar que a senha informada pelo portador de um determinado cart\u00C3\u00A3o est\u00C3\u00A1 correta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <param name="senha">Senha para ser validada.</param> 
        /// <returns>ValidaSenhaCartaoResponse</returns>
        public ValidaSenhaCartaoResponse ValidarSenhaUsingGET (long? id, string senha)
        {
             ApiResponse<ValidaSenhaCartaoResponse> localVarResponse = ValidarSenhaUsingGETWithHttpInfo(id, senha);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite validar a senha de um Cart\u00C3\u00A3o Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir validar que a senha informada pelo portador de um determinado cart\u00C3\u00A3o est\u00C3\u00A1 correta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <param name="senha">Senha para ser validada.</param> 
        /// <returns>ApiResponse of ValidaSenhaCartaoResponse</returns>
        public ApiResponse< ValidaSenhaCartaoResponse > ValidarSenhaUsingGETWithHttpInfo (long? id, string senha)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->ValidarSenhaUsingGET");
            
            // verify the required parameter 'senha' is set
            if (senha == null)
                throw new ApiException(400, "Missing required parameter 'senha' when calling CartaoApi->ValidarSenhaUsingGET");
            
    
            var localVarPath = "/api/cartoes/{id}/validar-senha";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ValidaSenhaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaSenhaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaSenhaCartaoResponse)));
            
        }

        
        /// <summary>
        /// Permite validar a senha de um Cart\u00C3\u00A3o Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir validar que a senha informada pelo portador de um determinado cart\u00C3\u00A3o est\u00C3\u00A1 correta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="senha">Senha para ser validada.</param>
        /// <returns>Task of ValidaSenhaCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ValidaSenhaCartaoResponse> ValidarSenhaUsingGETAsync (long? id, string senha)
        {
             ApiResponse<ValidaSenhaCartaoResponse> localVarResponse = await ValidarSenhaUsingGETAsyncWithHttpInfo(id, senha);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite validar a senha de um Cart\u00C3\u00A3o Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir validar que a senha informada pelo portador de um determinado cart\u00C3\u00A3o est\u00C3\u00A1 correta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="senha">Senha para ser validada.</param>
        /// <returns>Task of ApiResponse (ValidaSenhaCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ValidaSenhaCartaoResponse>> ValidarSenhaUsingGETAsyncWithHttpInfo (long? id, string senha)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ValidarSenhaUsingGET");
            // verify the required parameter 'senha' is set
            if (senha == null) throw new ApiException(400, "Missing required parameter 'senha' when calling ValidarSenhaUsingGET");
            
    
            var localVarPath = "/api/cartoes/{id}/validar-senha";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ValidaSenhaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaSenhaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaSenhaCartaoResponse)));
            
        }
        
        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o Bandeirado a partir da Tarja Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir da leitura da tarja magn\u00C3\u00A9tica do mesmo. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o antes de permitir que o portador realize transa\u00C3\u00A7\u00C3\u00B5es diversas, como as de compra e saque na modalidade d\u00C3\u00A9bito em conta corrente, dentre outras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param> 
        /// <param name="trilha1">Trilha 1 do cart\u00C3\u00A3o a ser validado</param> 
        /// <param name="trilha2">Trilha 2 do cart\u00C3\u00A3o a ser validado</param> 
        /// <returns>ValidaCartaoResponse</returns>
        public ValidaCartaoResponse ValidarTarjaUsingGET (string numeroCartao, string trilha1, string trilha2)
        {
             ApiResponse<ValidaCartaoResponse> localVarResponse = ValidarTarjaUsingGETWithHttpInfo(numeroCartao, trilha1, trilha2);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o Bandeirado a partir da Tarja Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir da leitura da tarja magn\u00C3\u00A9tica do mesmo. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o antes de permitir que o portador realize transa\u00C3\u00A7\u00C3\u00B5es diversas, como as de compra e saque na modalidade d\u00C3\u00A9bito em conta corrente, dentre outras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param> 
        /// <param name="trilha1">Trilha 1 do cart\u00C3\u00A3o a ser validado</param> 
        /// <param name="trilha2">Trilha 2 do cart\u00C3\u00A3o a ser validado</param> 
        /// <returns>ApiResponse of ValidaCartaoResponse</returns>
        public ApiResponse< ValidaCartaoResponse > ValidarTarjaUsingGETWithHttpInfo (string numeroCartao, string trilha1, string trilha2)
        {
            
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null)
                throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling CartaoApi->ValidarTarjaUsingGET");
            
            // verify the required parameter 'trilha1' is set
            if (trilha1 == null)
                throw new ApiException(400, "Missing required parameter 'trilha1' when calling CartaoApi->ValidarTarjaUsingGET");
            
            // verify the required parameter 'trilha2' is set
            if (trilha2 == null)
                throw new ApiException(400, "Missing required parameter 'trilha2' when calling CartaoApi->ValidarTarjaUsingGET");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarTarjaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarTarjaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ValidaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartaoResponse)));
            
        }

        
        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o Bandeirado a partir da Tarja Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir da leitura da tarja magn\u00C3\u00A9tica do mesmo. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o antes de permitir que o portador realize transa\u00C3\u00A7\u00C3\u00B5es diversas, como as de compra e saque na modalidade d\u00C3\u00A9bito em conta corrente, dentre outras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="trilha1">Trilha 1 do cart\u00C3\u00A3o a ser validado</param>
        /// <param name="trilha2">Trilha 2 do cart\u00C3\u00A3o a ser validado</param>
        /// <returns>Task of ValidaCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ValidaCartaoResponse> ValidarTarjaUsingGETAsync (string numeroCartao, string trilha1, string trilha2)
        {
             ApiResponse<ValidaCartaoResponse> localVarResponse = await ValidarTarjaUsingGETAsyncWithHttpInfo(numeroCartao, trilha1, trilha2);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o Bandeirado a partir da Tarja Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir da leitura da tarja magn\u00C3\u00A9tica do mesmo. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o antes de permitir que o portador realize transa\u00C3\u00A7\u00C3\u00B5es diversas, como as de compra e saque na modalidade d\u00C3\u00A9bito em conta corrente, dentre outras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="trilha1">Trilha 1 do cart\u00C3\u00A3o a ser validado</param>
        /// <param name="trilha2">Trilha 2 do cart\u00C3\u00A3o a ser validado</param>
        /// <returns>Task of ApiResponse (ValidaCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ValidaCartaoResponse>> ValidarTarjaUsingGETAsyncWithHttpInfo (string numeroCartao, string trilha1, string trilha2)
        {
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null) throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling ValidarTarjaUsingGET");
            // verify the required parameter 'trilha1' is set
            if (trilha1 == null) throw new ApiException(400, "Missing required parameter 'trilha1' when calling ValidarTarjaUsingGET");
            // verify the required parameter 'trilha2' is set
            if (trilha2 == null) throw new ApiException(400, "Missing required parameter 'trilha2' when calling ValidarTarjaUsingGET");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarTarjaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarTarjaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ValidaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartaoResponse)));
            
        }
        
    }
    
}
