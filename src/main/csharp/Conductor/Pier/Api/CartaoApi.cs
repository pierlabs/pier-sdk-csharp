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
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que uma Aplica\u00C3\u00A7\u00C3\u00A3o que realize a impress\u00C3\u00A3o de cart\u00C3\u00B5es possa indicar que um determinado idCartao fora impresso ou est\u00C3\u00A1 em processo de impress\u00C3\u00A3o. Para isso, basta informar o respectivo c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id) que deseja ter seu um determinado id_status_impressao atribu\u00C3\u00ADdo a ele. Por padr\u00C3\u00A3o, cart\u00C3\u00B5es provis\u00C3\u00B3rios ou que j\u00C3\u00A1 tenham sido inclu\u00C3\u00ADdos em um arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica ter\u00C3\u00A3o esta requisi\u00C3\u00A7\u00C3\u00A3o negada, se utilizada.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="idStatusImpressao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status Impress\u00C3\u00A3o (Id).</param>
        /// <returns>HistoricoImpressaoCartao</returns>
        HistoricoImpressaoCartao AlterarStatusImpressaoUsingPUT (long? id, long? idStatusImpressao);
  
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que uma Aplica\u00C3\u00A7\u00C3\u00A3o que realize a impress\u00C3\u00A3o de cart\u00C3\u00B5es possa indicar que um determinado idCartao fora impresso ou est\u00C3\u00A1 em processo de impress\u00C3\u00A3o. Para isso, basta informar o respectivo c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id) que deseja ter seu um determinado id_status_impressao atribu\u00C3\u00ADdo a ele. Por padr\u00C3\u00A3o, cart\u00C3\u00B5es provis\u00C3\u00B3rios ou que j\u00C3\u00A1 tenham sido inclu\u00C3\u00ADdos em um arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica ter\u00C3\u00A3o esta requisi\u00C3\u00A7\u00C3\u00A3o negada, se utilizada.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="idStatusImpressao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status Impress\u00C3\u00A3o (Id).</param>
        /// <returns>ApiResponse of HistoricoImpressaoCartao</returns>
        ApiResponse<HistoricoImpressaoCartao> AlterarStatusImpressaoUsingPUTWithHttpInfo (long? id, long? idStatusImpressao);
        
        /// <summary>
        /// Realiza a atribui\u00C3\u00A7\u00C3\u00A3o de um cart\u00C3\u00A3o pr\u00C3\u00A9-pago a uma pessoa
        /// </summary>
        /// <remarks>
        /// Esta m\u00C3\u00A9todo permite que um cart\u00C3\u00A3o pr\u00C3\u00A9-pago impresso de forma avulsa e an\u00C3\u00B4nimo seja atribu\u00C3\u00ADdo a uma pessoa para que esta passe a ser a portadora titular dele.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o de uma Pessoa (id).</param>
        /// <returns>Cartao</returns>
        Cartao AtribuirPessoaUsingPUT (long? id, long? idPessoa);
  
        /// <summary>
        /// Realiza a atribui\u00C3\u00A7\u00C3\u00A3o de um cart\u00C3\u00A3o pr\u00C3\u00A9-pago a uma pessoa
        /// </summary>
        /// <remarks>
        /// Esta m\u00C3\u00A9todo permite que um cart\u00C3\u00A3o pr\u00C3\u00A9-pago impresso de forma avulsa e an\u00C3\u00B4nimo seja atribu\u00C3\u00ADdo a uma pessoa para que esta passe a ser a portadora titular dele.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o de uma Pessoa (id).</param>
        /// <returns>ApiResponse of Cartao</returns>
        ApiResponse<Cartao> AtribuirPessoaUsingPUTWithHttpInfo (long? id, long? idPessoa);
        
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
        /// <returns>Cartao</returns>
        Cartao BloquearUsingPUT (long? id, long? idStatus, string observacao);
  
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
        /// <returns>ApiResponse of Cartao</returns>
        ApiResponse<Cartao> BloquearUsingPUTWithHttpInfo (long? id, long? idStatus, string observacao);
        
        /// <summary>
        /// Realiza o cadastro ou altera\u00C3\u00A7\u00C3\u00A3o da senha de um Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que o portador de um determinado cart\u00C3\u00A3o possa definir uma senha a sua escolha.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="senha">Senha para ser cadastrada ou alterada.</param>
        /// <returns>string</returns>
        string CadastrarAlterarSenhaUsingPUT (long? id, string senha);
  
        /// <summary>
        /// Realiza o cadastro ou altera\u00C3\u00A7\u00C3\u00A3o da senha de um Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que o portador de um determinado cart\u00C3\u00A3o possa definir uma senha a sua escolha.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="senha">Senha para ser cadastrada ou alterada.</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> CadastrarAlterarSenhaUsingPUTWithHttpInfo (long? id, string senha);
        
        /// <summary>
        /// Apresenta os limites do Portador do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os Limites configurados para o Portador de um determinado Cart\u00C3\u00A3o, seja ele o titular da conta ou um adicional, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>LimiteDisponibilidade</returns>
        LimiteDisponibilidade ConsultarLimiteDisponibilidadeUsingGET (long? id);
  
        /// <summary>
        /// Apresenta os limites do Portador do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os Limites configurados para o Portador de um determinado Cart\u00C3\u00A3o, seja ele o titular da conta ou um adicional, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>ApiResponse of LimiteDisponibilidade</returns>
        ApiResponse<LimiteDisponibilidade> ConsultarLimiteDisponibilidadeUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados do Portador do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es do Portador de um determinado Cart\u00C3\u00A3o a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Portador</returns>
        Portador ConsultarPortadorUsingGET (long? id);
  
        /// <summary>
        /// Apresenta os dados do Portador do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es do Portador de um determinado Cart\u00C3\u00A3o a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>ApiResponse of Portador</returns>
        ApiResponse<Portador> ConsultarPortadorUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es b\u00C3\u00A1sicas de um determinado Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Cartao</returns>
        Cartao ConsultarUsingGET (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es b\u00C3\u00A1sicas de um determinado Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>ApiResponse of Cartao</returns>
        ApiResponse<Cartao> ConsultarUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// Realiza o desbloqueio de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja desbloqueado um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Cartao</returns>
        Cartao DesbloquearUsingPUT (long? id);
  
        /// <summary>
        /// Realiza o desbloqueio de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja desbloqueado um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>ApiResponse of Cartao</returns>
        ApiResponse<Cartao> DesbloquearUsingPUTWithHttpInfo (long? id);
        
        /// <summary>
        /// Permite listar os Lotes de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pago
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es pr\u00C3\u00A9-pagos existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Lote de Cart\u00C3\u00B5es N\u00C3\u00A3o Nominais (id). (optional)</param>
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id). (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="idTipoCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idImagem">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Imagem (id). (optional)</param>
        /// <param name="idEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id). (optional)</param>
        /// <param name="quantidadeCartoes">N\u00C3\u00BAmero de cart\u00C3\u00B5es existentes no Lote. (optional)</param>
        /// <param name="dataCadastroLote">Data de Cadastro do Lote de Cart\u00C3\u00B5es N\u00C3\u00A3o Nominais. (optional)</param>
        /// <param name="usuarioCadastro">Nome do Usu\u00C3\u00A1rio que criou o Lote. (optional)</param>
        /// <param name="flagProcessado">Indica o Status de Processamento do Lote. (optional)</param>
        /// <returns>PageCartoes</returns>
        PageCartoes ListarLotesCartoesPrePagosUsingGET (int? page = null, int? limit = null, long? id = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, DateTime? dataCadastroLote = null, string usuarioCadastro = null, int? flagProcessado = null);
  
        /// <summary>
        /// Permite listar os Lotes de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pago
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es pr\u00C3\u00A9-pagos existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Lote de Cart\u00C3\u00B5es N\u00C3\u00A3o Nominais (id). (optional)</param>
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id). (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="idTipoCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idImagem">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Imagem (id). (optional)</param>
        /// <param name="idEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id). (optional)</param>
        /// <param name="quantidadeCartoes">N\u00C3\u00BAmero de cart\u00C3\u00B5es existentes no Lote. (optional)</param>
        /// <param name="dataCadastroLote">Data de Cadastro do Lote de Cart\u00C3\u00B5es N\u00C3\u00A3o Nominais. (optional)</param>
        /// <param name="usuarioCadastro">Nome do Usu\u00C3\u00A1rio que criou o Lote. (optional)</param>
        /// <param name="flagProcessado">Indica o Status de Processamento do Lote. (optional)</param>
        /// <returns>ApiResponse of PageCartoes</returns>
        ApiResponse<PageCartoes> ListarLotesCartoesPrePagosUsingGETWithHttpInfo (int? page = null, int? limit = null, long? id = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, DateTime? dataCadastroLote = null, string usuarioCadastro = null, int? flagProcessado = null);
        
        /// <summary>
        /// Lista os Cart\u00C3\u00B5es gerados pelo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
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
        /// <returns>PageCartoes</returns>
        PageCartoes ListarUsingGET (int? page = null, int? limit = null, long? id = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, DateTime? dataGeracao = null, DateTime? dataStatusCartao = null, DateTime? dataEstagioCartao = null, string dataValidade = null, DateTime? dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null);
  
        /// <summary>
        /// Lista os Cart\u00C3\u00B5es gerados pelo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
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
        /// <returns>ApiResponse of PageCartoes</returns>
        ApiResponse<PageCartoes> ListarUsingGETWithHttpInfo (int? page = null, int? limit = null, long? id = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, DateTime? dataGeracao = null, DateTime? dataStatusCartao = null, DateTime? dataEstagioCartao = null, string dataValidade = null, DateTime? dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null);
        
        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o com bandeira Mastercard a partir do chip
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem o criptograma gerado a partir da leitura de um chip EMV de um Cart\u00C3\u00A3o com bandeira Mastercard a fim de verificar a sua autenticidade. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o antes de permitir que o portador realize transa\u00C3\u00A7\u00C3\u00B5es diversas, como as de compra e saque na modalidade d\u00C3\u00A9bito em conta corrente, dentre outras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="criptograma">Criptograma do cart\u00C3\u00A3o no formato de55</param>
        /// <returns>ValidaCartao</returns>
        ValidaCartao ValidarCartaoChipBandeiradoUsingGET (string numeroCartao, string criptograma);
  
        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o com bandeira Mastercard a partir do chip
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem o criptograma gerado a partir da leitura de um chip EMV de um Cart\u00C3\u00A3o com bandeira Mastercard a fim de verificar a sua autenticidade. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o antes de permitir que o portador realize transa\u00C3\u00A7\u00C3\u00B5es diversas, como as de compra e saque na modalidade d\u00C3\u00A9bito em conta corrente, dentre outras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="criptograma">Criptograma do cart\u00C3\u00A3o no formato de55</param>
        /// <returns>ApiResponse of ValidaCartao</returns>
        ApiResponse<ValidaCartao> ValidarCartaoChipBandeiradoUsingGETWithHttpInfo (string numeroCartao, string criptograma);
        
        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o bandeirado a partir dos dados Impressos
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir do envio dos dados sens\u00C3\u00ADveis impressos nele. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o para a realiza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00C3\u00B4nico (URA), dentre outras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="nomePortador">Nome do portador do cart\u00C3\u00A3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00C3\u00A3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00C3\u00B3digo de seguran\u00C3\u00A7a do cart\u00C3\u00A3o com tr\u00C3\u00AAs n\u00C3\u00BAmeros</param>
        /// <returns>ValidaCartao</returns>
        ValidaCartao ValidarCartaoDigitadoBandeiradoUsingGET (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);
  
        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o bandeirado a partir dos dados Impressos
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir do envio dos dados sens\u00C3\u00ADveis impressos nele. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o para a realiza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00C3\u00B4nico (URA), dentre outras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="nomePortador">Nome do portador do cart\u00C3\u00A3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00C3\u00A3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00C3\u00B3digo de seguran\u00C3\u00A7a do cart\u00C3\u00A3o com tr\u00C3\u00AAs n\u00C3\u00BAmeros</param>
        /// <returns>ApiResponse of ValidaCartao</returns>
        ApiResponse<ValidaCartao> ValidarCartaoDigitadoBandeiradoUsingGETWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);
        
        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o a partir dos dados Impressos
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir do envio dos dados sens\u00C3\u00ADveis impressos nele. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o para a realiza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00C3\u00B4nico (URA), dentre outras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="nomePortador">Nome do portador do cart\u00C3\u00A3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00C3\u00A3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00C3\u00B3digo de seguran\u00C3\u00A7a do cart\u00C3\u00A3o com tr\u00C3\u00AAs n\u00C3\u00BAmeros</param>
        /// <returns>ValidaCartao</returns>
        ValidaCartao ValidarCartaoDigitadoNaoBandeiradoUsingGET (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);
  
        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o a partir dos dados Impressos
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir do envio dos dados sens\u00C3\u00ADveis impressos nele. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o para a realiza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00C3\u00B4nico (URA), dentre outras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="nomePortador">Nome do portador do cart\u00C3\u00A3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00C3\u00A3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00C3\u00B3digo de seguran\u00C3\u00A7a do cart\u00C3\u00A3o com tr\u00C3\u00AAs n\u00C3\u00BAmeros</param>
        /// <returns>ApiResponse of ValidaCartao</returns>
        ApiResponse<ValidaCartao> ValidarCartaoDigitadoNaoBandeiradoUsingGETWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);
        
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
        /// <returns>ValidaCartao</returns>
        ValidaCartao ValidarCartaoTarjaBandeiradoUsingGET (string numeroCartao, string trilha1, string trilha2);
  
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
        /// <returns>ApiResponse of ValidaCartao</returns>
        ApiResponse<ValidaCartao> ValidarCartaoTarjaBandeiradoUsingGETWithHttpInfo (string numeroCartao, string trilha1, string trilha2);
        
        /// <summary>
        /// Permite validar a senha de um Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir validar que a senha informada pelo portador de um determinado cart\u00C3\u00A3o est\u00C3\u00A1 correta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="senha">Senha para ser validada.</param>
        /// <returns>string</returns>
        string ValidarSenhaUsingGET (long? id, string senha);
  
        /// <summary>
        /// Permite validar a senha de um Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir validar que a senha informada pelo portador de um determinado cart\u00C3\u00A3o est\u00C3\u00A1 correta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="senha">Senha para ser validada.</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ValidarSenhaUsingGETWithHttpInfo (long? id, string senha);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que uma Aplica\u00C3\u00A7\u00C3\u00A3o que realize a impress\u00C3\u00A3o de cart\u00C3\u00B5es possa indicar que um determinado idCartao fora impresso ou est\u00C3\u00A1 em processo de impress\u00C3\u00A3o. Para isso, basta informar o respectivo c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id) que deseja ter seu um determinado id_status_impressao atribu\u00C3\u00ADdo a ele. Por padr\u00C3\u00A3o, cart\u00C3\u00B5es provis\u00C3\u00B3rios ou que j\u00C3\u00A1 tenham sido inclu\u00C3\u00ADdos em um arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica ter\u00C3\u00A3o esta requisi\u00C3\u00A7\u00C3\u00A3o negada, se utilizada.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="idStatusImpressao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status Impress\u00C3\u00A3o (Id).</param>
        /// <returns>Task of HistoricoImpressaoCartao</returns>
        System.Threading.Tasks.Task<HistoricoImpressaoCartao> AlterarStatusImpressaoUsingPUTAsync (long? id, long? idStatusImpressao);

        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que uma Aplica\u00C3\u00A7\u00C3\u00A3o que realize a impress\u00C3\u00A3o de cart\u00C3\u00B5es possa indicar que um determinado idCartao fora impresso ou est\u00C3\u00A1 em processo de impress\u00C3\u00A3o. Para isso, basta informar o respectivo c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id) que deseja ter seu um determinado id_status_impressao atribu\u00C3\u00ADdo a ele. Por padr\u00C3\u00A3o, cart\u00C3\u00B5es provis\u00C3\u00B3rios ou que j\u00C3\u00A1 tenham sido inclu\u00C3\u00ADdos em um arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica ter\u00C3\u00A3o esta requisi\u00C3\u00A7\u00C3\u00A3o negada, se utilizada.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="idStatusImpressao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status Impress\u00C3\u00A3o (Id).</param>
        /// <returns>Task of ApiResponse (HistoricoImpressaoCartao)</returns>
        System.Threading.Tasks.Task<ApiResponse<HistoricoImpressaoCartao>> AlterarStatusImpressaoUsingPUTAsyncWithHttpInfo (long? id, long? idStatusImpressao);
        
        /// <summary>
        /// Realiza a atribui\u00C3\u00A7\u00C3\u00A3o de um cart\u00C3\u00A3o pr\u00C3\u00A9-pago a uma pessoa
        /// </summary>
        /// <remarks>
        /// Esta m\u00C3\u00A9todo permite que um cart\u00C3\u00A3o pr\u00C3\u00A9-pago impresso de forma avulsa e an\u00C3\u00B4nimo seja atribu\u00C3\u00ADdo a uma pessoa para que esta passe a ser a portadora titular dele.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o de uma Pessoa (id).</param>
        /// <returns>Task of Cartao</returns>
        System.Threading.Tasks.Task<Cartao> AtribuirPessoaUsingPUTAsync (long? id, long? idPessoa);

        /// <summary>
        /// Realiza a atribui\u00C3\u00A7\u00C3\u00A3o de um cart\u00C3\u00A3o pr\u00C3\u00A9-pago a uma pessoa
        /// </summary>
        /// <remarks>
        /// Esta m\u00C3\u00A9todo permite que um cart\u00C3\u00A3o pr\u00C3\u00A9-pago impresso de forma avulsa e an\u00C3\u00B4nimo seja atribu\u00C3\u00ADdo a uma pessoa para que esta passe a ser a portadora titular dele.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o de uma Pessoa (id).</param>
        /// <returns>Task of ApiResponse (Cartao)</returns>
        System.Threading.Tasks.Task<ApiResponse<Cartao>> AtribuirPessoaUsingPUTAsyncWithHttpInfo (long? id, long? idPessoa);
        
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
        /// <returns>Task of Cartao</returns>
        System.Threading.Tasks.Task<Cartao> BloquearUsingPUTAsync (long? id, long? idStatus, string observacao);

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
        /// <returns>Task of ApiResponse (Cartao)</returns>
        System.Threading.Tasks.Task<ApiResponse<Cartao>> BloquearUsingPUTAsyncWithHttpInfo (long? id, long? idStatus, string observacao);
        
        /// <summary>
        /// Realiza o cadastro ou altera\u00C3\u00A7\u00C3\u00A3o da senha de um Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que o portador de um determinado cart\u00C3\u00A3o possa definir uma senha a sua escolha.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="senha">Senha para ser cadastrada ou alterada.</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> CadastrarAlterarSenhaUsingPUTAsync (long? id, string senha);

        /// <summary>
        /// Realiza o cadastro ou altera\u00C3\u00A7\u00C3\u00A3o da senha de um Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que o portador de um determinado cart\u00C3\u00A3o possa definir uma senha a sua escolha.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="senha">Senha para ser cadastrada ou alterada.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> CadastrarAlterarSenhaUsingPUTAsyncWithHttpInfo (long? id, string senha);
        
        /// <summary>
        /// Apresenta os limites do Portador do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os Limites configurados para o Portador de um determinado Cart\u00C3\u00A3o, seja ele o titular da conta ou um adicional, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of LimiteDisponibilidade</returns>
        System.Threading.Tasks.Task<LimiteDisponibilidade> ConsultarLimiteDisponibilidadeUsingGETAsync (long? id);

        /// <summary>
        /// Apresenta os limites do Portador do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os Limites configurados para o Portador de um determinado Cart\u00C3\u00A3o, seja ele o titular da conta ou um adicional, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (LimiteDisponibilidade)</returns>
        System.Threading.Tasks.Task<ApiResponse<LimiteDisponibilidade>> ConsultarLimiteDisponibilidadeUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados do Portador do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es do Portador de um determinado Cart\u00C3\u00A3o a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of Portador</returns>
        System.Threading.Tasks.Task<Portador> ConsultarPortadorUsingGETAsync (long? id);

        /// <summary>
        /// Apresenta os dados do Portador do Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es do Portador de um determinado Cart\u00C3\u00A3o a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (Portador)</returns>
        System.Threading.Tasks.Task<ApiResponse<Portador>> ConsultarPortadorUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es b\u00C3\u00A1sicas de um determinado Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of Cartao</returns>
        System.Threading.Tasks.Task<Cartao> ConsultarUsingGETAsync (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es b\u00C3\u00A1sicas de um determinado Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (Cartao)</returns>
        System.Threading.Tasks.Task<ApiResponse<Cartao>> ConsultarUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Realiza o desbloqueio de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja desbloqueado um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of Cartao</returns>
        System.Threading.Tasks.Task<Cartao> DesbloquearUsingPUTAsync (long? id);

        /// <summary>
        /// Realiza o desbloqueio de um determinado Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja desbloqueado um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (Cartao)</returns>
        System.Threading.Tasks.Task<ApiResponse<Cartao>> DesbloquearUsingPUTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Permite listar os Lotes de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pago
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es pr\u00C3\u00A9-pagos existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Lote de Cart\u00C3\u00B5es N\u00C3\u00A3o Nominais (id). (optional)</param>
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id). (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="idTipoCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idImagem">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Imagem (id). (optional)</param>
        /// <param name="idEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id). (optional)</param>
        /// <param name="quantidadeCartoes">N\u00C3\u00BAmero de cart\u00C3\u00B5es existentes no Lote. (optional)</param>
        /// <param name="dataCadastroLote">Data de Cadastro do Lote de Cart\u00C3\u00B5es N\u00C3\u00A3o Nominais. (optional)</param>
        /// <param name="usuarioCadastro">Nome do Usu\u00C3\u00A1rio que criou o Lote. (optional)</param>
        /// <param name="flagProcessado">Indica o Status de Processamento do Lote. (optional)</param>
        /// <returns>Task of PageCartoes</returns>
        System.Threading.Tasks.Task<PageCartoes> ListarLotesCartoesPrePagosUsingGETAsync (int? page = null, int? limit = null, long? id = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, DateTime? dataCadastroLote = null, string usuarioCadastro = null, int? flagProcessado = null);

        /// <summary>
        /// Permite listar os Lotes de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pago
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es pr\u00C3\u00A9-pagos existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Lote de Cart\u00C3\u00B5es N\u00C3\u00A3o Nominais (id). (optional)</param>
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id). (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="idTipoCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idImagem">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Imagem (id). (optional)</param>
        /// <param name="idEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id). (optional)</param>
        /// <param name="quantidadeCartoes">N\u00C3\u00BAmero de cart\u00C3\u00B5es existentes no Lote. (optional)</param>
        /// <param name="dataCadastroLote">Data de Cadastro do Lote de Cart\u00C3\u00B5es N\u00C3\u00A3o Nominais. (optional)</param>
        /// <param name="usuarioCadastro">Nome do Usu\u00C3\u00A1rio que criou o Lote. (optional)</param>
        /// <param name="flagProcessado">Indica o Status de Processamento do Lote. (optional)</param>
        /// <returns>Task of ApiResponse (PageCartoes)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCartoes>> ListarLotesCartoesPrePagosUsingGETAsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, DateTime? dataCadastroLote = null, string usuarioCadastro = null, int? flagProcessado = null);
        
        /// <summary>
        /// Lista os Cart\u00C3\u00B5es gerados pelo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
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
        /// <returns>Task of PageCartoes</returns>
        System.Threading.Tasks.Task<PageCartoes> ListarUsingGETAsync (int? page = null, int? limit = null, long? id = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, DateTime? dataGeracao = null, DateTime? dataStatusCartao = null, DateTime? dataEstagioCartao = null, string dataValidade = null, DateTime? dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null);

        /// <summary>
        /// Lista os Cart\u00C3\u00B5es gerados pelo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
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
        /// <returns>Task of ApiResponse (PageCartoes)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCartoes>> ListarUsingGETAsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, DateTime? dataGeracao = null, DateTime? dataStatusCartao = null, DateTime? dataEstagioCartao = null, string dataValidade = null, DateTime? dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null);
        
        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o com bandeira Mastercard a partir do chip
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem o criptograma gerado a partir da leitura de um chip EMV de um Cart\u00C3\u00A3o com bandeira Mastercard a fim de verificar a sua autenticidade. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o antes de permitir que o portador realize transa\u00C3\u00A7\u00C3\u00B5es diversas, como as de compra e saque na modalidade d\u00C3\u00A9bito em conta corrente, dentre outras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="criptograma">Criptograma do cart\u00C3\u00A3o no formato de55</param>
        /// <returns>Task of ValidaCartao</returns>
        System.Threading.Tasks.Task<ValidaCartao> ValidarCartaoChipBandeiradoUsingGETAsync (string numeroCartao, string criptograma);

        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o com bandeira Mastercard a partir do chip
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem o criptograma gerado a partir da leitura de um chip EMV de um Cart\u00C3\u00A3o com bandeira Mastercard a fim de verificar a sua autenticidade. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o antes de permitir que o portador realize transa\u00C3\u00A7\u00C3\u00B5es diversas, como as de compra e saque na modalidade d\u00C3\u00A9bito em conta corrente, dentre outras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="criptograma">Criptograma do cart\u00C3\u00A3o no formato de55</param>
        /// <returns>Task of ApiResponse (ValidaCartao)</returns>
        System.Threading.Tasks.Task<ApiResponse<ValidaCartao>> ValidarCartaoChipBandeiradoUsingGETAsyncWithHttpInfo (string numeroCartao, string criptograma);
        
        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o bandeirado a partir dos dados Impressos
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir do envio dos dados sens\u00C3\u00ADveis impressos nele. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o para a realiza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00C3\u00B4nico (URA), dentre outras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="nomePortador">Nome do portador do cart\u00C3\u00A3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00C3\u00A3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00C3\u00B3digo de seguran\u00C3\u00A7a do cart\u00C3\u00A3o com tr\u00C3\u00AAs n\u00C3\u00BAmeros</param>
        /// <returns>Task of ValidaCartao</returns>
        System.Threading.Tasks.Task<ValidaCartao> ValidarCartaoDigitadoBandeiradoUsingGETAsync (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);

        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o bandeirado a partir dos dados Impressos
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir do envio dos dados sens\u00C3\u00ADveis impressos nele. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o para a realiza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00C3\u00B4nico (URA), dentre outras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="nomePortador">Nome do portador do cart\u00C3\u00A3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00C3\u00A3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00C3\u00B3digo de seguran\u00C3\u00A7a do cart\u00C3\u00A3o com tr\u00C3\u00AAs n\u00C3\u00BAmeros</param>
        /// <returns>Task of ApiResponse (ValidaCartao)</returns>
        System.Threading.Tasks.Task<ApiResponse<ValidaCartao>> ValidarCartaoDigitadoBandeiradoUsingGETAsyncWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);
        
        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o a partir dos dados Impressos
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir do envio dos dados sens\u00C3\u00ADveis impressos nele. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o para a realiza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00C3\u00B4nico (URA), dentre outras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="nomePortador">Nome do portador do cart\u00C3\u00A3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00C3\u00A3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00C3\u00B3digo de seguran\u00C3\u00A7a do cart\u00C3\u00A3o com tr\u00C3\u00AAs n\u00C3\u00BAmeros</param>
        /// <returns>Task of ValidaCartao</returns>
        System.Threading.Tasks.Task<ValidaCartao> ValidarCartaoDigitadoNaoBandeiradoUsingGETAsync (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);

        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o a partir dos dados Impressos
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir do envio dos dados sens\u00C3\u00ADveis impressos nele. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o para a realiza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00C3\u00B4nico (URA), dentre outras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="nomePortador">Nome do portador do cart\u00C3\u00A3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00C3\u00A3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00C3\u00B3digo de seguran\u00C3\u00A7a do cart\u00C3\u00A3o com tr\u00C3\u00AAs n\u00C3\u00BAmeros</param>
        /// <returns>Task of ApiResponse (ValidaCartao)</returns>
        System.Threading.Tasks.Task<ApiResponse<ValidaCartao>> ValidarCartaoDigitadoNaoBandeiradoUsingGETAsyncWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);
        
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
        /// <returns>Task of ValidaCartao</returns>
        System.Threading.Tasks.Task<ValidaCartao> ValidarCartaoTarjaBandeiradoUsingGETAsync (string numeroCartao, string trilha1, string trilha2);

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
        /// <returns>Task of ApiResponse (ValidaCartao)</returns>
        System.Threading.Tasks.Task<ApiResponse<ValidaCartao>> ValidarCartaoTarjaBandeiradoUsingGETAsyncWithHttpInfo (string numeroCartao, string trilha1, string trilha2);
        
        /// <summary>
        /// Permite validar a senha de um Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir validar que a senha informada pelo portador de um determinado cart\u00C3\u00A3o est\u00C3\u00A1 correta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="senha">Senha para ser validada.</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ValidarSenhaUsingGETAsync (long? id, string senha);

        /// <summary>
        /// Permite validar a senha de um Cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir validar que a senha informada pelo portador de um determinado cart\u00C3\u00A3o est\u00C3\u00A1 correta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="senha">Senha para ser validada.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ValidarSenhaUsingGETAsyncWithHttpInfo (long? id, string senha);
        
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
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que uma Aplica\u00C3\u00A7\u00C3\u00A3o que realize a impress\u00C3\u00A3o de cart\u00C3\u00B5es possa indicar que um determinado idCartao fora impresso ou est\u00C3\u00A1 em processo de impress\u00C3\u00A3o. Para isso, basta informar o respectivo c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id) que deseja ter seu um determinado id_status_impressao atribu\u00C3\u00ADdo a ele. Por padr\u00C3\u00A3o, cart\u00C3\u00B5es provis\u00C3\u00B3rios ou que j\u00C3\u00A1 tenham sido inclu\u00C3\u00ADdos em um arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica ter\u00C3\u00A3o esta requisi\u00C3\u00A7\u00C3\u00A3o negada, se utilizada.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <param name="idStatusImpressao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status Impress\u00C3\u00A3o (Id).</param> 
        /// <returns>HistoricoImpressaoCartao</returns>
        public HistoricoImpressaoCartao AlterarStatusImpressaoUsingPUT (long? id, long? idStatusImpressao)
        {
             ApiResponse<HistoricoImpressaoCartao> localVarResponse = AlterarStatusImpressaoUsingPUTWithHttpInfo(id, idStatusImpressao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que uma Aplica\u00C3\u00A7\u00C3\u00A3o que realize a impress\u00C3\u00A3o de cart\u00C3\u00B5es possa indicar que um determinado idCartao fora impresso ou est\u00C3\u00A1 em processo de impress\u00C3\u00A3o. Para isso, basta informar o respectivo c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id) que deseja ter seu um determinado id_status_impressao atribu\u00C3\u00ADdo a ele. Por padr\u00C3\u00A3o, cart\u00C3\u00B5es provis\u00C3\u00B3rios ou que j\u00C3\u00A1 tenham sido inclu\u00C3\u00ADdos em um arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica ter\u00C3\u00A3o esta requisi\u00C3\u00A7\u00C3\u00A3o negada, se utilizada.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <param name="idStatusImpressao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status Impress\u00C3\u00A3o (Id).</param> 
        /// <returns>ApiResponse of HistoricoImpressaoCartao</returns>
        public ApiResponse< HistoricoImpressaoCartao > AlterarStatusImpressaoUsingPUTWithHttpInfo (long? id, long? idStatusImpressao)
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatusImpressaoUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatusImpressaoUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<HistoricoImpressaoCartao>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HistoricoImpressaoCartao) Configuration.ApiClient.Deserialize(localVarResponse, typeof(HistoricoImpressaoCartao)));
            
        }

        
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que uma Aplica\u00C3\u00A7\u00C3\u00A3o que realize a impress\u00C3\u00A3o de cart\u00C3\u00B5es possa indicar que um determinado idCartao fora impresso ou est\u00C3\u00A1 em processo de impress\u00C3\u00A3o. Para isso, basta informar o respectivo c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id) que deseja ter seu um determinado id_status_impressao atribu\u00C3\u00ADdo a ele. Por padr\u00C3\u00A3o, cart\u00C3\u00B5es provis\u00C3\u00B3rios ou que j\u00C3\u00A1 tenham sido inclu\u00C3\u00ADdos em um arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica ter\u00C3\u00A3o esta requisi\u00C3\u00A7\u00C3\u00A3o negada, se utilizada.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="idStatusImpressao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status Impress\u00C3\u00A3o (Id).</param>
        /// <returns>Task of HistoricoImpressaoCartao</returns>
        public async System.Threading.Tasks.Task<HistoricoImpressaoCartao> AlterarStatusImpressaoUsingPUTAsync (long? id, long? idStatusImpressao)
        {
             ApiResponse<HistoricoImpressaoCartao> localVarResponse = await AlterarStatusImpressaoUsingPUTAsyncWithHttpInfo(id, idStatusImpressao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que uma Aplica\u00C3\u00A7\u00C3\u00A3o que realize a impress\u00C3\u00A3o de cart\u00C3\u00B5es possa indicar que um determinado idCartao fora impresso ou est\u00C3\u00A1 em processo de impress\u00C3\u00A3o. Para isso, basta informar o respectivo c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id) que deseja ter seu um determinado id_status_impressao atribu\u00C3\u00ADdo a ele. Por padr\u00C3\u00A3o, cart\u00C3\u00B5es provis\u00C3\u00B3rios ou que j\u00C3\u00A1 tenham sido inclu\u00C3\u00ADdos em um arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica ter\u00C3\u00A3o esta requisi\u00C3\u00A7\u00C3\u00A3o negada, se utilizada.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="idStatusImpressao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status Impress\u00C3\u00A3o (Id).</param>
        /// <returns>Task of ApiResponse (HistoricoImpressaoCartao)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<HistoricoImpressaoCartao>> AlterarStatusImpressaoUsingPUTAsyncWithHttpInfo (long? id, long? idStatusImpressao)
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatusImpressaoUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatusImpressaoUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<HistoricoImpressaoCartao>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HistoricoImpressaoCartao) Configuration.ApiClient.Deserialize(localVarResponse, typeof(HistoricoImpressaoCartao)));
            
        }
        
        /// <summary>
        /// Realiza a atribui\u00C3\u00A7\u00C3\u00A3o de um cart\u00C3\u00A3o pr\u00C3\u00A9-pago a uma pessoa Esta m\u00C3\u00A9todo permite que um cart\u00C3\u00A3o pr\u00C3\u00A9-pago impresso de forma avulsa e an\u00C3\u00B4nimo seja atribu\u00C3\u00ADdo a uma pessoa para que esta passe a ser a portadora titular dele.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id)</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o de uma Pessoa (id).</param> 
        /// <returns>Cartao</returns>
        public Cartao AtribuirPessoaUsingPUT (long? id, long? idPessoa)
        {
             ApiResponse<Cartao> localVarResponse = AtribuirPessoaUsingPUTWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a atribui\u00C3\u00A7\u00C3\u00A3o de um cart\u00C3\u00A3o pr\u00C3\u00A9-pago a uma pessoa Esta m\u00C3\u00A9todo permite que um cart\u00C3\u00A3o pr\u00C3\u00A9-pago impresso de forma avulsa e an\u00C3\u00B4nimo seja atribu\u00C3\u00ADdo a uma pessoa para que esta passe a ser a portadora titular dele.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id)</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o de uma Pessoa (id).</param> 
        /// <returns>ApiResponse of Cartao</returns>
        public ApiResponse< Cartao > AtribuirPessoaUsingPUTWithHttpInfo (long? id, long? idPessoa)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->AtribuirPessoaUsingPUT");
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling CartaoApi->AtribuirPessoaUsingPUT");
            
    
            var localVarPath = "/api/cartoes/{id}/atribuir-pessoa";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
                throw new ApiException (localVarStatusCode, "Error calling AtribuirPessoaUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirPessoaUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Cartao>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Cartao) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Cartao)));
            
        }

        
        /// <summary>
        /// Realiza a atribui\u00C3\u00A7\u00C3\u00A3o de um cart\u00C3\u00A3o pr\u00C3\u00A9-pago a uma pessoa Esta m\u00C3\u00A9todo permite que um cart\u00C3\u00A3o pr\u00C3\u00A9-pago impresso de forma avulsa e an\u00C3\u00B4nimo seja atribu\u00C3\u00ADdo a uma pessoa para que esta passe a ser a portadora titular dele.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o de uma Pessoa (id).</param>
        /// <returns>Task of Cartao</returns>
        public async System.Threading.Tasks.Task<Cartao> AtribuirPessoaUsingPUTAsync (long? id, long? idPessoa)
        {
             ApiResponse<Cartao> localVarResponse = await AtribuirPessoaUsingPUTAsyncWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a atribui\u00C3\u00A7\u00C3\u00A3o de um cart\u00C3\u00A3o pr\u00C3\u00A9-pago a uma pessoa Esta m\u00C3\u00A9todo permite que um cart\u00C3\u00A3o pr\u00C3\u00A9-pago impresso de forma avulsa e an\u00C3\u00B4nimo seja atribu\u00C3\u00ADdo a uma pessoa para que esta passe a ser a portadora titular dele.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o de uma Pessoa (id).</param>
        /// <returns>Task of ApiResponse (Cartao)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Cartao>> AtribuirPessoaUsingPUTAsyncWithHttpInfo (long? id, long? idPessoa)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtribuirPessoaUsingPUT");
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling AtribuirPessoaUsingPUT");
            
    
            var localVarPath = "/api/cartoes/{id}/atribuir-pessoa";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
                throw new ApiException (localVarStatusCode, "Error calling AtribuirPessoaUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirPessoaUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Cartao>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Cartao) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Cartao)));
            
        }
        
        /// <summary>
        /// Realiza o bloqueio de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o do bloqueio (tempor\u00C3\u00A1rio) ou do cancelamento (definitivo) de um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id). Para isso, \u00C3\u00A9 preciso informar qual o motivo deste bloqueio que nada mais \u00C3\u00A9 do que atribuir um novo StatusCartao para ele dentre as op\u00C3\u00A7\u00C3\u00B5es praticadas pelo emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Cart\u00C3\u00A3o.</param> 
        /// <param name="observacao">Texto informando uma observa\u00C3\u00A7\u00C3\u00A3o sobre o bloqueio.</param> 
        /// <returns>Cartao</returns>
        public Cartao BloquearUsingPUT (long? id, long? idStatus, string observacao)
        {
             ApiResponse<Cartao> localVarResponse = BloquearUsingPUTWithHttpInfo(id, idStatus, observacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o bloqueio de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o do bloqueio (tempor\u00C3\u00A1rio) ou do cancelamento (definitivo) de um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id). Para isso, \u00C3\u00A9 preciso informar qual o motivo deste bloqueio que nada mais \u00C3\u00A9 do que atribuir um novo StatusCartao para ele dentre as op\u00C3\u00A7\u00C3\u00B5es praticadas pelo emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Cart\u00C3\u00A3o.</param> 
        /// <param name="observacao">Texto informando uma observa\u00C3\u00A7\u00C3\u00A3o sobre o bloqueio.</param> 
        /// <returns>ApiResponse of Cartao</returns>
        public ApiResponse< Cartao > BloquearUsingPUTWithHttpInfo (long? id, long? idStatus, string observacao)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->BloquearUsingPUT");
            
            // verify the required parameter 'idStatus' is set
            if (idStatus == null)
                throw new ApiException(400, "Missing required parameter 'idStatus' when calling CartaoApi->BloquearUsingPUT");
            
            // verify the required parameter 'observacao' is set
            if (observacao == null)
                throw new ApiException(400, "Missing required parameter 'observacao' when calling CartaoApi->BloquearUsingPUT");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling BloquearUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling BloquearUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Cartao>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Cartao) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Cartao)));
            
        }

        
        /// <summary>
        /// Realiza o bloqueio de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o do bloqueio (tempor\u00C3\u00A1rio) ou do cancelamento (definitivo) de um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id). Para isso, \u00C3\u00A9 preciso informar qual o motivo deste bloqueio que nada mais \u00C3\u00A9 do que atribuir um novo StatusCartao para ele dentre as op\u00C3\u00A7\u00C3\u00B5es praticadas pelo emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Cart\u00C3\u00A3o.</param>
        /// <param name="observacao">Texto informando uma observa\u00C3\u00A7\u00C3\u00A3o sobre o bloqueio.</param>
        /// <returns>Task of Cartao</returns>
        public async System.Threading.Tasks.Task<Cartao> BloquearUsingPUTAsync (long? id, long? idStatus, string observacao)
        {
             ApiResponse<Cartao> localVarResponse = await BloquearUsingPUTAsyncWithHttpInfo(id, idStatus, observacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o bloqueio de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite a realiza\u00C3\u00A7\u00C3\u00A3o do bloqueio (tempor\u00C3\u00A1rio) ou do cancelamento (definitivo) de um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id). Para isso, \u00C3\u00A9 preciso informar qual o motivo deste bloqueio que nada mais \u00C3\u00A9 do que atribuir um novo StatusCartao para ele dentre as op\u00C3\u00A7\u00C3\u00B5es praticadas pelo emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Novo Status Cart\u00C3\u00A3o.</param>
        /// <param name="observacao">Texto informando uma observa\u00C3\u00A7\u00C3\u00A3o sobre o bloqueio.</param>
        /// <returns>Task of ApiResponse (Cartao)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Cartao>> BloquearUsingPUTAsyncWithHttpInfo (long? id, long? idStatus, string observacao)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling BloquearUsingPUT");
            // verify the required parameter 'idStatus' is set
            if (idStatus == null) throw new ApiException(400, "Missing required parameter 'idStatus' when calling BloquearUsingPUT");
            // verify the required parameter 'observacao' is set
            if (observacao == null) throw new ApiException(400, "Missing required parameter 'observacao' when calling BloquearUsingPUT");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling BloquearUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling BloquearUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Cartao>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Cartao) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Cartao)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro ou altera\u00C3\u00A7\u00C3\u00A3o da senha de um Cart\u00C3\u00A3o Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que o portador de um determinado cart\u00C3\u00A3o possa definir uma senha a sua escolha.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <param name="senha">Senha para ser cadastrada ou alterada.</param> 
        /// <returns>string</returns>
        public string CadastrarAlterarSenhaUsingPUT (long? id, string senha)
        {
             ApiResponse<string> localVarResponse = CadastrarAlterarSenhaUsingPUTWithHttpInfo(id, senha);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro ou altera\u00C3\u00A7\u00C3\u00A3o da senha de um Cart\u00C3\u00A3o Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que o portador de um determinado cart\u00C3\u00A3o possa definir uma senha a sua escolha.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <param name="senha">Senha para ser cadastrada ou alterada.</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > CadastrarAlterarSenhaUsingPUTWithHttpInfo (long? id, string senha)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->CadastrarAlterarSenhaUsingPUT");
            
            // verify the required parameter 'senha' is set
            if (senha == null)
                throw new ApiException(400, "Missing required parameter 'senha' when calling CartaoApi->CadastrarAlterarSenhaUsingPUT");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling CadastrarAlterarSenhaUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarAlterarSenhaUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro ou altera\u00C3\u00A7\u00C3\u00A3o da senha de um Cart\u00C3\u00A3o Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que o portador de um determinado cart\u00C3\u00A3o possa definir uma senha a sua escolha.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="senha">Senha para ser cadastrada ou alterada.</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> CadastrarAlterarSenhaUsingPUTAsync (long? id, string senha)
        {
             ApiResponse<string> localVarResponse = await CadastrarAlterarSenhaUsingPUTAsyncWithHttpInfo(id, senha);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro ou altera\u00C3\u00A7\u00C3\u00A3o da senha de um Cart\u00C3\u00A3o Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que o portador de um determinado cart\u00C3\u00A3o possa definir uma senha a sua escolha.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="senha">Senha para ser cadastrada ou alterada.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> CadastrarAlterarSenhaUsingPUTAsyncWithHttpInfo (long? id, string senha)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CadastrarAlterarSenhaUsingPUT");
            // verify the required parameter 'senha' is set
            if (senha == null) throw new ApiException(400, "Missing required parameter 'senha' when calling CadastrarAlterarSenhaUsingPUT");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling CadastrarAlterarSenhaUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarAlterarSenhaUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Apresenta os limites do Portador do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar os Limites configurados para o Portador de um determinado Cart\u00C3\u00A3o, seja ele o titular da conta ou um adicional, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>LimiteDisponibilidade</returns>
        public LimiteDisponibilidade ConsultarLimiteDisponibilidadeUsingGET (long? id)
        {
             ApiResponse<LimiteDisponibilidade> localVarResponse = ConsultarLimiteDisponibilidadeUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os limites do Portador do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar os Limites configurados para o Portador de um determinado Cart\u00C3\u00A3o, seja ele o titular da conta ou um adicional, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>ApiResponse of LimiteDisponibilidade</returns>
        public ApiResponse< LimiteDisponibilidade > ConsultarLimiteDisponibilidadeUsingGETWithHttpInfo (long? id)
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLimiteDisponibilidadeUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLimiteDisponibilidadeUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LimiteDisponibilidade>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LimiteDisponibilidade) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimiteDisponibilidade)));
            
        }

        
        /// <summary>
        /// Apresenta os limites do Portador do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar os Limites configurados para o Portador de um determinado Cart\u00C3\u00A3o, seja ele o titular da conta ou um adicional, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of LimiteDisponibilidade</returns>
        public async System.Threading.Tasks.Task<LimiteDisponibilidade> ConsultarLimiteDisponibilidadeUsingGETAsync (long? id)
        {
             ApiResponse<LimiteDisponibilidade> localVarResponse = await ConsultarLimiteDisponibilidadeUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os limites do Portador do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar os Limites configurados para o Portador de um determinado Cart\u00C3\u00A3o, seja ele o titular da conta ou um adicional, a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (LimiteDisponibilidade)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LimiteDisponibilidade>> ConsultarLimiteDisponibilidadeUsingGETAsyncWithHttpInfo (long? id)
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLimiteDisponibilidadeUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLimiteDisponibilidadeUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LimiteDisponibilidade>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LimiteDisponibilidade) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimiteDisponibilidade)));
            
        }
        
        /// <summary>
        /// Apresenta os dados do Portador do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es do Portador de um determinado Cart\u00C3\u00A3o a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>Portador</returns>
        public Portador ConsultarPortadorUsingGET (long? id)
        {
             ApiResponse<Portador> localVarResponse = ConsultarPortadorUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados do Portador do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es do Portador de um determinado Cart\u00C3\u00A3o a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>ApiResponse of Portador</returns>
        public ApiResponse< Portador > ConsultarPortadorUsingGETWithHttpInfo (long? id)
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
        /// Apresenta os dados do Portador do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es do Portador de um determinado Cart\u00C3\u00A3o a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of Portador</returns>
        public async System.Threading.Tasks.Task<Portador> ConsultarPortadorUsingGETAsync (long? id)
        {
             ApiResponse<Portador> localVarResponse = await ConsultarPortadorUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados do Portador do Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es do Portador de um determinado Cart\u00C3\u00A3o a partir do c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (Portador)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Portador>> ConsultarPortadorUsingGETAsyncWithHttpInfo (long? id)
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
        /// Apresenta os dados de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es b\u00C3\u00A1sicas de um determinado Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>Cartao</returns>
        public Cartao ConsultarUsingGET (long? id)
        {
             ApiResponse<Cartao> localVarResponse = ConsultarUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es b\u00C3\u00A1sicas de um determinado Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>ApiResponse of Cartao</returns>
        public ApiResponse< Cartao > ConsultarUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->ConsultarUsingGET");
            
    
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
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of Cartao</returns>
        public async System.Threading.Tasks.Task<Cartao> ConsultarUsingGETAsync (long? id)
        {
             ApiResponse<Cartao> localVarResponse = await ConsultarUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es b\u00C3\u00A1sicas de um determinado Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (Cartao)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Cartao>> ConsultarUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET");
            
    
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
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>Cartao</returns>
        public Cartao DesbloquearUsingPUT (long? id)
        {
             ApiResponse<Cartao> localVarResponse = DesbloquearUsingPUTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o desbloqueio de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que seja desbloqueado um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>ApiResponse of Cartao</returns>
        public ApiResponse< Cartao > DesbloquearUsingPUTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CartaoApi->DesbloquearUsingPUT");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Cartao>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Cartao) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Cartao)));
            
        }

        
        /// <summary>
        /// Realiza o desbloqueio de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que seja desbloqueado um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of Cartao</returns>
        public async System.Threading.Tasks.Task<Cartao> DesbloquearUsingPUTAsync (long? id)
        {
             ApiResponse<Cartao> localVarResponse = await DesbloquearUsingPUTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o desbloqueio de um determinado Cart\u00C3\u00A3o Este m\u00C3\u00A9todo permite que seja desbloqueado um determinado cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (Cartao)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Cartao>> DesbloquearUsingPUTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesbloquearUsingPUT");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Cartao>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Cartao) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Cartao)));
            
        }
        
        /// <summary>
        /// Permite listar os Lotes de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pago Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es pr\u00C3\u00A9-pagos existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Lote de Cart\u00C3\u00B5es N\u00C3\u00A3o Nominais (id). (optional)</param> 
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id). (optional)</param> 
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param> 
        /// <param name="idTipoCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Cart\u00C3\u00A3o (id). (optional)</param> 
        /// <param name="idImagem">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Imagem (id). (optional)</param> 
        /// <param name="idEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id). (optional)</param> 
        /// <param name="quantidadeCartoes">N\u00C3\u00BAmero de cart\u00C3\u00B5es existentes no Lote. (optional)</param> 
        /// <param name="dataCadastroLote">Data de Cadastro do Lote de Cart\u00C3\u00B5es N\u00C3\u00A3o Nominais. (optional)</param> 
        /// <param name="usuarioCadastro">Nome do Usu\u00C3\u00A1rio que criou o Lote. (optional)</param> 
        /// <param name="flagProcessado">Indica o Status de Processamento do Lote. (optional)</param> 
        /// <returns>PageCartoes</returns>
        public PageCartoes ListarLotesCartoesPrePagosUsingGET (int? page = null, int? limit = null, long? id = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, DateTime? dataCadastroLote = null, string usuarioCadastro = null, int? flagProcessado = null)
        {
             ApiResponse<PageCartoes> localVarResponse = ListarLotesCartoesPrePagosUsingGETWithHttpInfo(page, limit, id, idOrigemComercial, idProduto, idTipoCartao, idImagem, idEndereco, quantidadeCartoes, dataCadastroLote, usuarioCadastro, flagProcessado);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite listar os Lotes de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pago Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es pr\u00C3\u00A9-pagos existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Lote de Cart\u00C3\u00B5es N\u00C3\u00A3o Nominais (id). (optional)</param> 
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id). (optional)</param> 
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param> 
        /// <param name="idTipoCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Cart\u00C3\u00A3o (id). (optional)</param> 
        /// <param name="idImagem">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Imagem (id). (optional)</param> 
        /// <param name="idEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id). (optional)</param> 
        /// <param name="quantidadeCartoes">N\u00C3\u00BAmero de cart\u00C3\u00B5es existentes no Lote. (optional)</param> 
        /// <param name="dataCadastroLote">Data de Cadastro do Lote de Cart\u00C3\u00B5es N\u00C3\u00A3o Nominais. (optional)</param> 
        /// <param name="usuarioCadastro">Nome do Usu\u00C3\u00A1rio que criou o Lote. (optional)</param> 
        /// <param name="flagProcessado">Indica o Status de Processamento do Lote. (optional)</param> 
        /// <returns>ApiResponse of PageCartoes</returns>
        public ApiResponse< PageCartoes > ListarLotesCartoesPrePagosUsingGETWithHttpInfo (int? page = null, int? limit = null, long? id = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, DateTime? dataCadastroLote = null, string usuarioCadastro = null, int? flagProcessado = null)
        {
            
    
            var localVarPath = "/api/cartoes/pre-pagos/lotes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idOrigemComercial != null) localVarQueryParams.Add("idOrigemComercial", Configuration.ApiClient.ParameterToString(idOrigemComercial)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (idTipoCartao != null) localVarQueryParams.Add("idTipoCartao", Configuration.ApiClient.ParameterToString(idTipoCartao)); // query parameter
            if (idImagem != null) localVarQueryParams.Add("idImagem", Configuration.ApiClient.ParameterToString(idImagem)); // query parameter
            if (idEndereco != null) localVarQueryParams.Add("idEndereco", Configuration.ApiClient.ParameterToString(idEndereco)); // query parameter
            if (quantidadeCartoes != null) localVarQueryParams.Add("quantidadeCartoes", Configuration.ApiClient.ParameterToString(quantidadeCartoes)); // query parameter
            if (dataCadastroLote != null) localVarQueryParams.Add("dataCadastroLote", Configuration.ApiClient.ParameterToString(dataCadastroLote)); // query parameter
            if (usuarioCadastro != null) localVarQueryParams.Add("usuarioCadastro", Configuration.ApiClient.ParameterToString(usuarioCadastro)); // query parameter
            if (flagProcessado != null) localVarQueryParams.Add("flagProcessado", Configuration.ApiClient.ParameterToString(flagProcessado)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling ListarLotesCartoesPrePagosUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarLotesCartoesPrePagosUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCartoes>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCartoes) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCartoes)));
            
        }

        
        /// <summary>
        /// Permite listar os Lotes de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pago Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es pr\u00C3\u00A9-pagos existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Lote de Cart\u00C3\u00B5es N\u00C3\u00A3o Nominais (id). (optional)</param>
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id). (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="idTipoCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idImagem">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Imagem (id). (optional)</param>
        /// <param name="idEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id). (optional)</param>
        /// <param name="quantidadeCartoes">N\u00C3\u00BAmero de cart\u00C3\u00B5es existentes no Lote. (optional)</param>
        /// <param name="dataCadastroLote">Data de Cadastro do Lote de Cart\u00C3\u00B5es N\u00C3\u00A3o Nominais. (optional)</param>
        /// <param name="usuarioCadastro">Nome do Usu\u00C3\u00A1rio que criou o Lote. (optional)</param>
        /// <param name="flagProcessado">Indica o Status de Processamento do Lote. (optional)</param>
        /// <returns>Task of PageCartoes</returns>
        public async System.Threading.Tasks.Task<PageCartoes> ListarLotesCartoesPrePagosUsingGETAsync (int? page = null, int? limit = null, long? id = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, DateTime? dataCadastroLote = null, string usuarioCadastro = null, int? flagProcessado = null)
        {
             ApiResponse<PageCartoes> localVarResponse = await ListarLotesCartoesPrePagosUsingGETAsyncWithHttpInfo(page, limit, id, idOrigemComercial, idProduto, idTipoCartao, idImagem, idEndereco, quantidadeCartoes, dataCadastroLote, usuarioCadastro, flagProcessado);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite listar os Lotes de Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pago Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es pr\u00C3\u00A9-pagos existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Lote de Cart\u00C3\u00B5es N\u00C3\u00A3o Nominais (id). (optional)</param>
        /// <param name="idOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id). (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="idTipoCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="idImagem">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Imagem (id). (optional)</param>
        /// <param name="idEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id). (optional)</param>
        /// <param name="quantidadeCartoes">N\u00C3\u00BAmero de cart\u00C3\u00B5es existentes no Lote. (optional)</param>
        /// <param name="dataCadastroLote">Data de Cadastro do Lote de Cart\u00C3\u00B5es N\u00C3\u00A3o Nominais. (optional)</param>
        /// <param name="usuarioCadastro">Nome do Usu\u00C3\u00A1rio que criou o Lote. (optional)</param>
        /// <param name="flagProcessado">Indica o Status de Processamento do Lote. (optional)</param>
        /// <returns>Task of ApiResponse (PageCartoes)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCartoes>> ListarLotesCartoesPrePagosUsingGETAsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, DateTime? dataCadastroLote = null, string usuarioCadastro = null, int? flagProcessado = null)
        {
            
    
            var localVarPath = "/api/cartoes/pre-pagos/lotes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idOrigemComercial != null) localVarQueryParams.Add("idOrigemComercial", Configuration.ApiClient.ParameterToString(idOrigemComercial)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (idTipoCartao != null) localVarQueryParams.Add("idTipoCartao", Configuration.ApiClient.ParameterToString(idTipoCartao)); // query parameter
            if (idImagem != null) localVarQueryParams.Add("idImagem", Configuration.ApiClient.ParameterToString(idImagem)); // query parameter
            if (idEndereco != null) localVarQueryParams.Add("idEndereco", Configuration.ApiClient.ParameterToString(idEndereco)); // query parameter
            if (quantidadeCartoes != null) localVarQueryParams.Add("quantidadeCartoes", Configuration.ApiClient.ParameterToString(quantidadeCartoes)); // query parameter
            if (dataCadastroLote != null) localVarQueryParams.Add("dataCadastroLote", Configuration.ApiClient.ParameterToString(dataCadastroLote)); // query parameter
            if (usuarioCadastro != null) localVarQueryParams.Add("usuarioCadastro", Configuration.ApiClient.ParameterToString(usuarioCadastro)); // query parameter
            if (flagProcessado != null) localVarQueryParams.Add("flagProcessado", Configuration.ApiClient.ParameterToString(flagProcessado)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling ListarLotesCartoesPrePagosUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarLotesCartoesPrePagosUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCartoes>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCartoes) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCartoes)));
            
        }
        
        /// <summary>
        /// Lista os Cart\u00C3\u00B5es gerados pelo Emissor Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param> 
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
        /// <returns>PageCartoes</returns>
        public PageCartoes ListarUsingGET (int? page = null, int? limit = null, long? id = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, DateTime? dataGeracao = null, DateTime? dataStatusCartao = null, DateTime? dataEstagioCartao = null, string dataValidade = null, DateTime? dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null)
        {
             ApiResponse<PageCartoes> localVarResponse = ListarUsingGETWithHttpInfo(page, limit, id, idStatusCartao, idEstagioCartao, idConta, idPessoa, idProduto, tipoPortador, numeroCartao, nomeImpresso, dataGeracao, dataStatusCartao, dataEstagioCartao, dataValidade, dataImpressao, arquivoImpressao, flagImpressaoOrigemComercial, flagProvisorio, codigoDesbloqueio);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Cart\u00C3\u00B5es gerados pelo Emissor Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param> 
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
        /// <returns>ApiResponse of PageCartoes</returns>
        public ApiResponse< PageCartoes > ListarUsingGETWithHttpInfo (int? page = null, int? limit = null, long? id = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, DateTime? dataGeracao = null, DateTime? dataStatusCartao = null, DateTime? dataEstagioCartao = null, string dataValidade = null, DateTime? dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null)
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
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
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
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
        /// <returns>Task of PageCartoes</returns>
        public async System.Threading.Tasks.Task<PageCartoes> ListarUsingGETAsync (int? page = null, int? limit = null, long? id = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, DateTime? dataGeracao = null, DateTime? dataStatusCartao = null, DateTime? dataEstagioCartao = null, string dataValidade = null, DateTime? dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null)
        {
             ApiResponse<PageCartoes> localVarResponse = await ListarUsingGETAsyncWithHttpInfo(page, limit, id, idStatusCartao, idEstagioCartao, idConta, idPessoa, idProduto, tipoPortador, numeroCartao, nomeImpresso, dataGeracao, dataStatusCartao, dataEstagioCartao, dataValidade, dataImpressao, arquivoImpressao, flagImpressaoOrigemComercial, flagProvisorio, codigoDesbloqueio);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Cart\u00C3\u00B5es gerados pelo Emissor Este m\u00C3\u00A9todo permite que sejam listados os cart\u00C3\u00B5es existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (optional)</param>
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
        /// <returns>Task of ApiResponse (PageCartoes)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCartoes>> ListarUsingGETAsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, DateTime? dataGeracao = null, DateTime? dataStatusCartao = null, DateTime? dataEstagioCartao = null, string dataValidade = null, DateTime? dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null)
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
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
        
        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o com bandeira Mastercard a partir do chip Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem o criptograma gerado a partir da leitura de um chip EMV de um Cart\u00C3\u00A3o com bandeira Mastercard a fim de verificar a sua autenticidade. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o antes de permitir que o portador realize transa\u00C3\u00A7\u00C3\u00B5es diversas, como as de compra e saque na modalidade d\u00C3\u00A9bito em conta corrente, dentre outras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param> 
        /// <param name="criptograma">Criptograma do cart\u00C3\u00A3o no formato de55</param> 
        /// <returns>ValidaCartao</returns>
        public ValidaCartao ValidarCartaoChipBandeiradoUsingGET (string numeroCartao, string criptograma)
        {
             ApiResponse<ValidaCartao> localVarResponse = ValidarCartaoChipBandeiradoUsingGETWithHttpInfo(numeroCartao, criptograma);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o com bandeira Mastercard a partir do chip Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem o criptograma gerado a partir da leitura de um chip EMV de um Cart\u00C3\u00A3o com bandeira Mastercard a fim de verificar a sua autenticidade. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o antes de permitir que o portador realize transa\u00C3\u00A7\u00C3\u00B5es diversas, como as de compra e saque na modalidade d\u00C3\u00A9bito em conta corrente, dentre outras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param> 
        /// <param name="criptograma">Criptograma do cart\u00C3\u00A3o no formato de55</param> 
        /// <returns>ApiResponse of ValidaCartao</returns>
        public ApiResponse< ValidaCartao > ValidarCartaoChipBandeiradoUsingGETWithHttpInfo (string numeroCartao, string criptograma)
        {
            
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null)
                throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling CartaoApi->ValidarCartaoChipBandeiradoUsingGET");
            
            // verify the required parameter 'criptograma' is set
            if (criptograma == null)
                throw new ApiException(400, "Missing required parameter 'criptograma' when calling CartaoApi->ValidarCartaoChipBandeiradoUsingGET");
            
    
            var localVarPath = "/api/cartoes/bandeirados/validar-chip";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarCartaoChipBandeiradoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarCartaoChipBandeiradoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ValidaCartao>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartao) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartao)));
            
        }

        
        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o com bandeira Mastercard a partir do chip Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem o criptograma gerado a partir da leitura de um chip EMV de um Cart\u00C3\u00A3o com bandeira Mastercard a fim de verificar a sua autenticidade. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o antes de permitir que o portador realize transa\u00C3\u00A7\u00C3\u00B5es diversas, como as de compra e saque na modalidade d\u00C3\u00A9bito em conta corrente, dentre outras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="criptograma">Criptograma do cart\u00C3\u00A3o no formato de55</param>
        /// <returns>Task of ValidaCartao</returns>
        public async System.Threading.Tasks.Task<ValidaCartao> ValidarCartaoChipBandeiradoUsingGETAsync (string numeroCartao, string criptograma)
        {
             ApiResponse<ValidaCartao> localVarResponse = await ValidarCartaoChipBandeiradoUsingGETAsyncWithHttpInfo(numeroCartao, criptograma);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o com bandeira Mastercard a partir do chip Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem o criptograma gerado a partir da leitura de um chip EMV de um Cart\u00C3\u00A3o com bandeira Mastercard a fim de verificar a sua autenticidade. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o antes de permitir que o portador realize transa\u00C3\u00A7\u00C3\u00B5es diversas, como as de compra e saque na modalidade d\u00C3\u00A9bito em conta corrente, dentre outras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="criptograma">Criptograma do cart\u00C3\u00A3o no formato de55</param>
        /// <returns>Task of ApiResponse (ValidaCartao)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ValidaCartao>> ValidarCartaoChipBandeiradoUsingGETAsyncWithHttpInfo (string numeroCartao, string criptograma)
        {
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null) throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling ValidarCartaoChipBandeiradoUsingGET");
            // verify the required parameter 'criptograma' is set
            if (criptograma == null) throw new ApiException(400, "Missing required parameter 'criptograma' when calling ValidarCartaoChipBandeiradoUsingGET");
            
    
            var localVarPath = "/api/cartoes/bandeirados/validar-chip";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarCartaoChipBandeiradoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarCartaoChipBandeiradoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ValidaCartao>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartao) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartao)));
            
        }
        
        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o bandeirado a partir dos dados Impressos Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir do envio dos dados sens\u00C3\u00ADveis impressos nele. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o para a realiza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00C3\u00B4nico (URA), dentre outras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param> 
        /// <param name="nomePortador">Nome do portador do cart\u00C3\u00A3o</param> 
        /// <param name="dataValidade">Data de validade do cart\u00C3\u00A3o no formato yyyy-MM</param> 
        /// <param name="codigoSeguranca">C\u00C3\u00B3digo de seguran\u00C3\u00A7a do cart\u00C3\u00A3o com tr\u00C3\u00AAs n\u00C3\u00BAmeros</param> 
        /// <returns>ValidaCartao</returns>
        public ValidaCartao ValidarCartaoDigitadoBandeiradoUsingGET (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
             ApiResponse<ValidaCartao> localVarResponse = ValidarCartaoDigitadoBandeiradoUsingGETWithHttpInfo(numeroCartao, nomePortador, dataValidade, codigoSeguranca);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o bandeirado a partir dos dados Impressos Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir do envio dos dados sens\u00C3\u00ADveis impressos nele. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o para a realiza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00C3\u00B4nico (URA), dentre outras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param> 
        /// <param name="nomePortador">Nome do portador do cart\u00C3\u00A3o</param> 
        /// <param name="dataValidade">Data de validade do cart\u00C3\u00A3o no formato yyyy-MM</param> 
        /// <param name="codigoSeguranca">C\u00C3\u00B3digo de seguran\u00C3\u00A7a do cart\u00C3\u00A3o com tr\u00C3\u00AAs n\u00C3\u00BAmeros</param> 
        /// <returns>ApiResponse of ValidaCartao</returns>
        public ApiResponse< ValidaCartao > ValidarCartaoDigitadoBandeiradoUsingGETWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
            
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null)
                throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling CartaoApi->ValidarCartaoDigitadoBandeiradoUsingGET");
            
            // verify the required parameter 'nomePortador' is set
            if (nomePortador == null)
                throw new ApiException(400, "Missing required parameter 'nomePortador' when calling CartaoApi->ValidarCartaoDigitadoBandeiradoUsingGET");
            
            // verify the required parameter 'dataValidade' is set
            if (dataValidade == null)
                throw new ApiException(400, "Missing required parameter 'dataValidade' when calling CartaoApi->ValidarCartaoDigitadoBandeiradoUsingGET");
            
            // verify the required parameter 'codigoSeguranca' is set
            if (codigoSeguranca == null)
                throw new ApiException(400, "Missing required parameter 'codigoSeguranca' when calling CartaoApi->ValidarCartaoDigitadoBandeiradoUsingGET");
            
    
            var localVarPath = "/api/cartoes/bandeirados/validar-digitado";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarCartaoDigitadoBandeiradoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarCartaoDigitadoBandeiradoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ValidaCartao>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartao) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartao)));
            
        }

        
        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o bandeirado a partir dos dados Impressos Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir do envio dos dados sens\u00C3\u00ADveis impressos nele. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o para a realiza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00C3\u00B4nico (URA), dentre outras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="nomePortador">Nome do portador do cart\u00C3\u00A3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00C3\u00A3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00C3\u00B3digo de seguran\u00C3\u00A7a do cart\u00C3\u00A3o com tr\u00C3\u00AAs n\u00C3\u00BAmeros</param>
        /// <returns>Task of ValidaCartao</returns>
        public async System.Threading.Tasks.Task<ValidaCartao> ValidarCartaoDigitadoBandeiradoUsingGETAsync (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
             ApiResponse<ValidaCartao> localVarResponse = await ValidarCartaoDigitadoBandeiradoUsingGETAsyncWithHttpInfo(numeroCartao, nomePortador, dataValidade, codigoSeguranca);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o bandeirado a partir dos dados Impressos Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir do envio dos dados sens\u00C3\u00ADveis impressos nele. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o para a realiza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00C3\u00B4nico (URA), dentre outras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="nomePortador">Nome do portador do cart\u00C3\u00A3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00C3\u00A3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00C3\u00B3digo de seguran\u00C3\u00A7a do cart\u00C3\u00A3o com tr\u00C3\u00AAs n\u00C3\u00BAmeros</param>
        /// <returns>Task of ApiResponse (ValidaCartao)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ValidaCartao>> ValidarCartaoDigitadoBandeiradoUsingGETAsyncWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null) throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling ValidarCartaoDigitadoBandeiradoUsingGET");
            // verify the required parameter 'nomePortador' is set
            if (nomePortador == null) throw new ApiException(400, "Missing required parameter 'nomePortador' when calling ValidarCartaoDigitadoBandeiradoUsingGET");
            // verify the required parameter 'dataValidade' is set
            if (dataValidade == null) throw new ApiException(400, "Missing required parameter 'dataValidade' when calling ValidarCartaoDigitadoBandeiradoUsingGET");
            // verify the required parameter 'codigoSeguranca' is set
            if (codigoSeguranca == null) throw new ApiException(400, "Missing required parameter 'codigoSeguranca' when calling ValidarCartaoDigitadoBandeiradoUsingGET");
            
    
            var localVarPath = "/api/cartoes/bandeirados/validar-digitado";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarCartaoDigitadoBandeiradoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarCartaoDigitadoBandeiradoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ValidaCartao>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartao) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartao)));
            
        }
        
        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o a partir dos dados Impressos Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir do envio dos dados sens\u00C3\u00ADveis impressos nele. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o para a realiza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00C3\u00B4nico (URA), dentre outras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param> 
        /// <param name="nomePortador">Nome do portador do cart\u00C3\u00A3o</param> 
        /// <param name="dataValidade">Data de validade do cart\u00C3\u00A3o no formato yyyy-MM</param> 
        /// <param name="codigoSeguranca">C\u00C3\u00B3digo de seguran\u00C3\u00A7a do cart\u00C3\u00A3o com tr\u00C3\u00AAs n\u00C3\u00BAmeros</param> 
        /// <returns>ValidaCartao</returns>
        public ValidaCartao ValidarCartaoDigitadoNaoBandeiradoUsingGET (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
             ApiResponse<ValidaCartao> localVarResponse = ValidarCartaoDigitadoNaoBandeiradoUsingGETWithHttpInfo(numeroCartao, nomePortador, dataValidade, codigoSeguranca);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o a partir dos dados Impressos Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir do envio dos dados sens\u00C3\u00ADveis impressos nele. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o para a realiza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00C3\u00B4nico (URA), dentre outras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param> 
        /// <param name="nomePortador">Nome do portador do cart\u00C3\u00A3o</param> 
        /// <param name="dataValidade">Data de validade do cart\u00C3\u00A3o no formato yyyy-MM</param> 
        /// <param name="codigoSeguranca">C\u00C3\u00B3digo de seguran\u00C3\u00A7a do cart\u00C3\u00A3o com tr\u00C3\u00AAs n\u00C3\u00BAmeros</param> 
        /// <returns>ApiResponse of ValidaCartao</returns>
        public ApiResponse< ValidaCartao > ValidarCartaoDigitadoNaoBandeiradoUsingGETWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
            
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null)
                throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling CartaoApi->ValidarCartaoDigitadoNaoBandeiradoUsingGET");
            
            // verify the required parameter 'nomePortador' is set
            if (nomePortador == null)
                throw new ApiException(400, "Missing required parameter 'nomePortador' when calling CartaoApi->ValidarCartaoDigitadoNaoBandeiradoUsingGET");
            
            // verify the required parameter 'dataValidade' is set
            if (dataValidade == null)
                throw new ApiException(400, "Missing required parameter 'dataValidade' when calling CartaoApi->ValidarCartaoDigitadoNaoBandeiradoUsingGET");
            
            // verify the required parameter 'codigoSeguranca' is set
            if (codigoSeguranca == null)
                throw new ApiException(400, "Missing required parameter 'codigoSeguranca' when calling CartaoApi->ValidarCartaoDigitadoNaoBandeiradoUsingGET");
            
    
            var localVarPath = "/api/cartoes/nao-bandeirados/validar-digitado";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarCartaoDigitadoNaoBandeiradoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarCartaoDigitadoNaoBandeiradoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ValidaCartao>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartao) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartao)));
            
        }

        
        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o a partir dos dados Impressos Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir do envio dos dados sens\u00C3\u00ADveis impressos nele. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o para a realiza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00C3\u00B4nico (URA), dentre outras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="nomePortador">Nome do portador do cart\u00C3\u00A3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00C3\u00A3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00C3\u00B3digo de seguran\u00C3\u00A7a do cart\u00C3\u00A3o com tr\u00C3\u00AAs n\u00C3\u00BAmeros</param>
        /// <returns>Task of ValidaCartao</returns>
        public async System.Threading.Tasks.Task<ValidaCartao> ValidarCartaoDigitadoNaoBandeiradoUsingGETAsync (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
             ApiResponse<ValidaCartao> localVarResponse = await ValidarCartaoDigitadoNaoBandeiradoUsingGETAsyncWithHttpInfo(numeroCartao, nomePortador, dataValidade, codigoSeguranca);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o a partir dos dados Impressos Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir do envio dos dados sens\u00C3\u00ADveis impressos nele. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o para a realiza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es e-commerce ou por meio de Centrais de Atendimento Eletr\u00C3\u00B4nico (URA), dentre outras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="nomePortador">Nome do portador do cart\u00C3\u00A3o</param>
        /// <param name="dataValidade">Data de validade do cart\u00C3\u00A3o no formato yyyy-MM</param>
        /// <param name="codigoSeguranca">C\u00C3\u00B3digo de seguran\u00C3\u00A7a do cart\u00C3\u00A3o com tr\u00C3\u00AAs n\u00C3\u00BAmeros</param>
        /// <returns>Task of ApiResponse (ValidaCartao)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ValidaCartao>> ValidarCartaoDigitadoNaoBandeiradoUsingGETAsyncWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null) throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling ValidarCartaoDigitadoNaoBandeiradoUsingGET");
            // verify the required parameter 'nomePortador' is set
            if (nomePortador == null) throw new ApiException(400, "Missing required parameter 'nomePortador' when calling ValidarCartaoDigitadoNaoBandeiradoUsingGET");
            // verify the required parameter 'dataValidade' is set
            if (dataValidade == null) throw new ApiException(400, "Missing required parameter 'dataValidade' when calling ValidarCartaoDigitadoNaoBandeiradoUsingGET");
            // verify the required parameter 'codigoSeguranca' is set
            if (codigoSeguranca == null) throw new ApiException(400, "Missing required parameter 'codigoSeguranca' when calling ValidarCartaoDigitadoNaoBandeiradoUsingGET");
            
    
            var localVarPath = "/api/cartoes/nao-bandeirados/validar-digitado";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarCartaoDigitadoNaoBandeiradoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarCartaoDigitadoNaoBandeiradoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ValidaCartao>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartao) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartao)));
            
        }
        
        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o Bandeirado a partir da Tarja Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir da leitura da tarja magn\u00C3\u00A9tica do mesmo. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o antes de permitir que o portador realize transa\u00C3\u00A7\u00C3\u00B5es diversas, como as de compra e saque na modalidade d\u00C3\u00A9bito em conta corrente, dentre outras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param> 
        /// <param name="trilha1">Trilha 1 do cart\u00C3\u00A3o a ser validado</param> 
        /// <param name="trilha2">Trilha 2 do cart\u00C3\u00A3o a ser validado</param> 
        /// <returns>ValidaCartao</returns>
        public ValidaCartao ValidarCartaoTarjaBandeiradoUsingGET (string numeroCartao, string trilha1, string trilha2)
        {
             ApiResponse<ValidaCartao> localVarResponse = ValidarCartaoTarjaBandeiradoUsingGETWithHttpInfo(numeroCartao, trilha1, trilha2);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o Bandeirado a partir da Tarja Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir da leitura da tarja magn\u00C3\u00A9tica do mesmo. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o antes de permitir que o portador realize transa\u00C3\u00A7\u00C3\u00B5es diversas, como as de compra e saque na modalidade d\u00C3\u00A9bito em conta corrente, dentre outras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param> 
        /// <param name="trilha1">Trilha 1 do cart\u00C3\u00A3o a ser validado</param> 
        /// <param name="trilha2">Trilha 2 do cart\u00C3\u00A3o a ser validado</param> 
        /// <returns>ApiResponse of ValidaCartao</returns>
        public ApiResponse< ValidaCartao > ValidarCartaoTarjaBandeiradoUsingGETWithHttpInfo (string numeroCartao, string trilha1, string trilha2)
        {
            
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null)
                throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling CartaoApi->ValidarCartaoTarjaBandeiradoUsingGET");
            
            // verify the required parameter 'trilha1' is set
            if (trilha1 == null)
                throw new ApiException(400, "Missing required parameter 'trilha1' when calling CartaoApi->ValidarCartaoTarjaBandeiradoUsingGET");
            
            // verify the required parameter 'trilha2' is set
            if (trilha2 == null)
                throw new ApiException(400, "Missing required parameter 'trilha2' when calling CartaoApi->ValidarCartaoTarjaBandeiradoUsingGET");
            
    
            var localVarPath = "/api/cartoes/bandeirados/validar-tarja";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarCartaoTarjaBandeiradoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarCartaoTarjaBandeiradoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ValidaCartao>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartao) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartao)));
            
        }

        
        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o Bandeirado a partir da Tarja Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir da leitura da tarja magn\u00C3\u00A9tica do mesmo. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o antes de permitir que o portador realize transa\u00C3\u00A7\u00C3\u00B5es diversas, como as de compra e saque na modalidade d\u00C3\u00A9bito em conta corrente, dentre outras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="trilha1">Trilha 1 do cart\u00C3\u00A3o a ser validado</param>
        /// <param name="trilha2">Trilha 2 do cart\u00C3\u00A3o a ser validado</param>
        /// <returns>Task of ValidaCartao</returns>
        public async System.Threading.Tasks.Task<ValidaCartao> ValidarCartaoTarjaBandeiradoUsingGETAsync (string numeroCartao, string trilha1, string trilha2)
        {
             ApiResponse<ValidaCartao> localVarResponse = await ValidarCartaoTarjaBandeiradoUsingGETAsyncWithHttpInfo(numeroCartao, trilha1, trilha2);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite validar um Cart\u00C3\u00A3o Bandeirado a partir da Tarja Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir que os Emissores validem a autenticidade de um determinado Cart\u00C3\u00A3o a partir da leitura da tarja magn\u00C3\u00A9tica do mesmo. A utiliza\u00C3\u00A7\u00C3\u00A3o desde m\u00C3\u00A9todo tem diversas aplica\u00C3\u00A7\u00C3\u00B5es, sendo a principal delas a de Identifica\u00C3\u00A7\u00C3\u00A3o Positiva do Cart\u00C3\u00A3o antes de permitir que o portador realize transa\u00C3\u00A7\u00C3\u00B5es diversas, como as de compra e saque na modalidade d\u00C3\u00A9bito em conta corrente, dentre outras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o a ser validado.</param>
        /// <param name="trilha1">Trilha 1 do cart\u00C3\u00A3o a ser validado</param>
        /// <param name="trilha2">Trilha 2 do cart\u00C3\u00A3o a ser validado</param>
        /// <returns>Task of ApiResponse (ValidaCartao)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ValidaCartao>> ValidarCartaoTarjaBandeiradoUsingGETAsyncWithHttpInfo (string numeroCartao, string trilha1, string trilha2)
        {
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null) throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling ValidarCartaoTarjaBandeiradoUsingGET");
            // verify the required parameter 'trilha1' is set
            if (trilha1 == null) throw new ApiException(400, "Missing required parameter 'trilha1' when calling ValidarCartaoTarjaBandeiradoUsingGET");
            // verify the required parameter 'trilha2' is set
            if (trilha2 == null) throw new ApiException(400, "Missing required parameter 'trilha2' when calling ValidarCartaoTarjaBandeiradoUsingGET");
            
    
            var localVarPath = "/api/cartoes/bandeirados/validar-tarja";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarCartaoTarjaBandeiradoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarCartaoTarjaBandeiradoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ValidaCartao>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartao) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartao)));
            
        }
        
        /// <summary>
        /// Permite validar a senha de um Cart\u00C3\u00A3o Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir validar que a senha informada pelo portador de um determinado cart\u00C3\u00A3o est\u00C3\u00A1 correta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <param name="senha">Senha para ser validada.</param> 
        /// <returns>string</returns>
        public string ValidarSenhaUsingGET (long? id, string senha)
        {
             ApiResponse<string> localVarResponse = ValidarSenhaUsingGETWithHttpInfo(id, senha);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite validar a senha de um Cart\u00C3\u00A3o Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir validar que a senha informada pelo portador de um determinado cart\u00C3\u00A3o est\u00C3\u00A1 correta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param> 
        /// <param name="senha">Senha para ser validada.</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ValidarSenhaUsingGETWithHttpInfo (long? id, string senha)
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Permite validar a senha de um Cart\u00C3\u00A3o Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir validar que a senha informada pelo portador de um determinado cart\u00C3\u00A3o est\u00C3\u00A1 correta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="senha">Senha para ser validada.</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ValidarSenhaUsingGETAsync (long? id, string senha)
        {
             ApiResponse<string> localVarResponse = await ValidarSenhaUsingGETAsyncWithHttpInfo(id, senha);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite validar a senha de um Cart\u00C3\u00A3o Esta opera\u00C3\u00A7\u00C3\u00A3o tem como objetivo permitir validar que a senha informada pelo portador de um determinado cart\u00C3\u00A3o est\u00C3\u00A1 correta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</param>
        /// <param name="senha">Senha para ser validada.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ValidarSenhaUsingGETAsyncWithHttpInfo (long? id, string senha)
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
    }
    
}
