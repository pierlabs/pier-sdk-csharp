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
    public interface IControleCartaoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Altera qualquer parte do log de configura\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Esse m\u00E9todo permite alterar qualquer parte da configura\u00E7\u00E3o de bloqueio do cart\u00E3o ao validar o ticket de transa\u00E7\u00E3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConfiguracaoCartao">C\u00F3digo da configura\u00E7\u00E3o controle cart\u00E3o</param>
        /// <param name="id">id</param>
        /// <param name="configuracaoControleCartaoUpdate">configuracaoControleCartaoUpdate</param>
        /// <returns>ConfiguracaoControleCartaoResponse</returns>
        ConfiguracaoControleCartaoResponse AlterarConfiguracaoControleCartao (long? idConfiguracaoCartao, long? id, ConfiguracaoControleCartaoUpdate configuracaoControleCartaoUpdate);
  
        /// <summary>
        /// Altera qualquer parte do log de configura\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Esse m\u00E9todo permite alterar qualquer parte da configura\u00E7\u00E3o de bloqueio do cart\u00E3o ao validar o ticket de transa\u00E7\u00E3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConfiguracaoCartao">C\u00F3digo da configura\u00E7\u00E3o controle cart\u00E3o</param>
        /// <param name="id">id</param>
        /// <param name="configuracaoControleCartaoUpdate">configuracaoControleCartaoUpdate</param>
        /// <returns>ApiResponse of ConfiguracaoControleCartaoResponse</returns>
        ApiResponse<ConfiguracaoControleCartaoResponse> AlterarConfiguracaoControleCartaoWithHttpInfo (long? idConfiguracaoCartao, long? id, ConfiguracaoControleCartaoUpdate configuracaoControleCartaoUpdate);
        
        /// <summary>
        /// Altera um controle de limites de um cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja alterado o controle de limites de um cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="idControleLimite">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites do cart\u00E3o (id)</param>
        /// <param name="controleLimitesCartaoUpdate">controleLimitesCartaoUpdate</param>
        /// <returns>ControleLimiteCartaoResponse</returns>
        ControleLimiteCartaoResponse AlterarControleDeLimite (long? id, long? idControleLimite, ControleLimiteCartaoUpdate controleLimitesCartaoUpdate);
  
        /// <summary>
        /// Altera um controle de limites de um cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja alterado o controle de limites de um cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="idControleLimite">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites do cart\u00E3o (id)</param>
        /// <param name="controleLimitesCartaoUpdate">controleLimitesCartaoUpdate</param>
        /// <returns>ApiResponse of ControleLimiteCartaoResponse</returns>
        ApiResponse<ControleLimiteCartaoResponse> AlterarControleDeLimiteWithHttpInfo (long? id, long? idControleLimite, ControleLimiteCartaoUpdate controleLimitesCartaoUpdate);
        
        /// <summary>
        /// Ativa um controle de limites de um cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja ativado o controle de limites de um cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="idControleLimite">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites do cart\u00E3o (id)</param>
        /// <returns>ControleLimiteCartaoResponse</returns>
        ControleLimiteCartaoResponse AtivarControleDeLimite (long? id, long? idControleLimite);
  
        /// <summary>
        /// Ativa um controle de limites de um cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja ativado o controle de limites de um cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="idControleLimite">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites do cart\u00E3o (id)</param>
        /// <returns>ApiResponse of ControleLimiteCartaoResponse</returns>
        ApiResponse<ControleLimiteCartaoResponse> AtivarControleDeLimiteWithHttpInfo (long? id, long? idControleLimite);
        
        /// <summary>
        /// Exibe as configura\u00E7\u00F5es de bloqueio para um cart\u00E3o espec\u00EDfico.
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar a informa\u00E7\u00E3o da permiss\u00E3o em transa\u00E7\u00F5es de um certo Cart\u00E3o do c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConfiguracaoCartao">C\u00F3digo da configura\u00E7\u00E3o controle cart\u00E3o</param>
        /// <param name="id">id</param>
        /// <returns>ConfiguracaoControleCartaoResponse</returns>
        ConfiguracaoControleCartaoResponse ConsultarConfiguracaoControleCartao (long? idConfiguracaoCartao, long? id);
  
        /// <summary>
        /// Exibe as configura\u00E7\u00F5es de bloqueio para um cart\u00E3o espec\u00EDfico.
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar a informa\u00E7\u00E3o da permiss\u00E3o em transa\u00E7\u00F5es de um certo Cart\u00E3o do c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConfiguracaoCartao">C\u00F3digo da configura\u00E7\u00E3o controle cart\u00E3o</param>
        /// <param name="id">id</param>
        /// <returns>ApiResponse of ConfiguracaoControleCartaoResponse</returns>
        ApiResponse<ConfiguracaoControleCartaoResponse> ConsultarConfiguracaoControleCartaoWithHttpInfo (long? idConfiguracaoCartao, long? id);
        
        /// <summary>
        /// Apresenta o controle de limites do cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja mostrado o controle de limites do cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="idControleLimite">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites do cart\u00E3o (id)</param>
        /// <returns>ControleLimiteCartaoResponse</returns>
        ControleLimiteCartaoResponse ConsultarControleDeLimite (long? id, long? idControleLimite);
  
        /// <summary>
        /// Apresenta o controle de limites do cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja mostrado o controle de limites do cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="idControleLimite">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites do cart\u00E3o (id)</param>
        /// <returns>ApiResponse of ControleLimiteCartaoResponse</returns>
        ApiResponse<ControleLimiteCartaoResponse> ConsultarControleDeLimiteWithHttpInfo (long? id, long? idControleLimite);
        
        /// <summary>
        /// Exibe todos os mcc de bloqueio vinculado a um cart\u00E3o espec\u00EDfico.
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar a informa\u00E7\u00E3o de todos os mcc que est\u00E3o vinculado a um Cart\u00E3o pelo seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de controle de grupo MCC do cart\u00E3o.</param>
        /// <param name="idControleCartaoGrupoMCC">idControleCartaoGrupoMCC</param>
        /// <returns>ControleCartaoGrupoMCCResponse</returns>
        ControleCartaoGrupoMCCResponse ConsultarControleGrupoMCCPorCartao (long? id, long? idControleCartaoGrupoMCC);
  
        /// <summary>
        /// Exibe todos os mcc de bloqueio vinculado a um cart\u00E3o espec\u00EDfico.
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar a informa\u00E7\u00E3o de todos os mcc que est\u00E3o vinculado a um Cart\u00E3o pelo seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de controle de grupo MCC do cart\u00E3o.</param>
        /// <param name="idControleCartaoGrupoMCC">idControleCartaoGrupoMCC</param>
        /// <returns>ApiResponse of ControleCartaoGrupoMCCResponse</returns>
        ApiResponse<ControleCartaoGrupoMCCResponse> ConsultarControleGrupoMCCPorCartaoWithHttpInfo (long? id, long? idControleCartaoGrupoMCC);
        
        /// <summary>
        /// Deletar uma configura\u00E7\u00E3o de um cart\u00E3o.
        /// </summary>
        /// <remarks>
        /// O metodo Deleta a configura\u00E7\u00E3o que est\u00E1 vinculada ao cart\u00E3o e deixar sem bloqueio nas transa\u00E7\u00F5es relacionadas ao mesmo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConfiguracaoCartao">C\u00F3digo da configura\u00E7\u00E3o controle cart\u00E3o</param>
        /// <param name="id">id</param>
        /// <returns>ConfiguracaoControleCartaoResponse</returns>
        ConfiguracaoControleCartaoResponse DeletarConfiguracaoControleCartao (long? idConfiguracaoCartao, long? id);
  
        /// <summary>
        /// Deletar uma configura\u00E7\u00E3o de um cart\u00E3o.
        /// </summary>
        /// <remarks>
        /// O metodo Deleta a configura\u00E7\u00E3o que est\u00E1 vinculada ao cart\u00E3o e deixar sem bloqueio nas transa\u00E7\u00F5es relacionadas ao mesmo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConfiguracaoCartao">C\u00F3digo da configura\u00E7\u00E3o controle cart\u00E3o</param>
        /// <param name="id">id</param>
        /// <returns>ApiResponse of ConfiguracaoControleCartaoResponse</returns>
        ApiResponse<ConfiguracaoControleCartaoResponse> DeletarConfiguracaoControleCartaoWithHttpInfo (long? idConfiguracaoCartao, long? id);
        
        /// <summary>
        /// Deletar o vinculo do mcc com um cart\u00E3o.
        /// </summary>
        /// <remarks>
        /// O metodo Deleta o vinculo do cart\u00E3o com o grupo MCC, deixando livre para transacionar de qualquer bloqueio para aquele grupo de mcc.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de controle de grupo MCC do cart\u00E3o.</param>
        /// <param name="idControleCartaoGrupoMCC">idControleCartaoGrupoMCC</param>
        /// <returns>ControleCartaoGrupoMCCResponse</returns>
        ControleCartaoGrupoMCCResponse DeletarControleGrupoMCCPorCartao (long? id, long? idControleCartaoGrupoMCC);
  
        /// <summary>
        /// Deletar o vinculo do mcc com um cart\u00E3o.
        /// </summary>
        /// <remarks>
        /// O metodo Deleta o vinculo do cart\u00E3o com o grupo MCC, deixando livre para transacionar de qualquer bloqueio para aquele grupo de mcc.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de controle de grupo MCC do cart\u00E3o.</param>
        /// <param name="idControleCartaoGrupoMCC">idControleCartaoGrupoMCC</param>
        /// <returns>ApiResponse of ControleCartaoGrupoMCCResponse</returns>
        ApiResponse<ControleCartaoGrupoMCCResponse> DeletarControleGrupoMCCPorCartaoWithHttpInfo (long? id, long? idControleCartaoGrupoMCC);
        
        /// <summary>
        /// Desativa um controle de limites de um cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja desativado o controle de limites de um cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="idControleLimite">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites do cart\u00E3o (id)</param>
        /// <returns>ControleLimiteCartaoResponse</returns>
        ControleLimiteCartaoResponse DesativarControleDeLimite (long? id, long? idControleLimite);
  
        /// <summary>
        /// Desativa um controle de limites de um cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja desativado o controle de limites de um cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="idControleLimite">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites do cart\u00E3o (id)</param>
        /// <returns>ApiResponse of ControleLimiteCartaoResponse</returns>
        ApiResponse<ControleLimiteCartaoResponse> DesativarControleDeLimiteWithHttpInfo (long? id, long? idControleLimite);
        
        /// <summary>
        /// Lista os cart\u00F5es configurados pelo remetente
        /// </summary>
        /// <remarks>
        /// Esse m\u00E9todo permite listar os cart\u00F5es configurados para bloqueios de transa\u00E7\u00E3o na base do remetente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">C\u00F3digo Identificador do cartao na base (id) (optional)</param>
        /// <param name="permiteEcommerce">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es ecommerce (optional)</param>
        /// <param name="permiteSaque">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es de saque (optional)</param>
        /// <param name="permiteWallet">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es por meio wallet (optional)</param>
        /// <param name="permiteControleMCC">Indica se o cart\u00E3o est\u00E1 ativo para controle por grupos de MCCs (optional)</param>
        /// <param name="permiteCompraInternacional">Indica se o cart\u00E3o est\u00E1 habilitado/desabilitado para transa\u00E7\u00F5es internacionais (optional)</param>
        /// <returns>PageConfiguracaoControleCartaoResponse</returns>
        PageConfiguracaoControleCartaoResponse ListarConfiguracaoControleCartao (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, bool? permiteEcommerce = null, bool? permiteSaque = null, bool? permiteWallet = null, bool? permiteControleMCC = null, bool? permiteCompraInternacional = null);
  
        /// <summary>
        /// Lista os cart\u00F5es configurados pelo remetente
        /// </summary>
        /// <remarks>
        /// Esse m\u00E9todo permite listar os cart\u00F5es configurados para bloqueios de transa\u00E7\u00E3o na base do remetente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">C\u00F3digo Identificador do cartao na base (id) (optional)</param>
        /// <param name="permiteEcommerce">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es ecommerce (optional)</param>
        /// <param name="permiteSaque">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es de saque (optional)</param>
        /// <param name="permiteWallet">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es por meio wallet (optional)</param>
        /// <param name="permiteControleMCC">Indica se o cart\u00E3o est\u00E1 ativo para controle por grupos de MCCs (optional)</param>
        /// <param name="permiteCompraInternacional">Indica se o cart\u00E3o est\u00E1 habilitado/desabilitado para transa\u00E7\u00F5es internacionais (optional)</param>
        /// <returns>ApiResponse of PageConfiguracaoControleCartaoResponse</returns>
        ApiResponse<PageConfiguracaoControleCartaoResponse> ListarConfiguracaoControleCartaoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, bool? permiteEcommerce = null, bool? permiteSaque = null, bool? permiteWallet = null, bool? permiteControleMCC = null, bool? permiteCompraInternacional = null);
        
        /// <summary>
        /// Lista os cart\u00F5es vinculados aos estabelecimentos.
        /// </summary>
        /// <remarks>
        /// Esse m\u00E9todo permite listar os cart\u00F5es registrados respectivamente para grupos MCC.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">C\u00F3digo Identificador do cartao na base (id) (optional)</param>
        /// <param name="idGrupoMCC">C\u00F3digo Identificador do grupo mcc na base. (optional)</param>
        /// <returns>PageControleCartaoGrupoMCCResponse</returns>
        PageControleCartaoGrupoMCCResponse ListarControleGrupoMCCPorCartao (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, long? idGrupoMCC = null);
  
        /// <summary>
        /// Lista os cart\u00F5es vinculados aos estabelecimentos.
        /// </summary>
        /// <remarks>
        /// Esse m\u00E9todo permite listar os cart\u00F5es registrados respectivamente para grupos MCC.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">C\u00F3digo Identificador do cartao na base (id) (optional)</param>
        /// <param name="idGrupoMCC">C\u00F3digo Identificador do grupo mcc na base. (optional)</param>
        /// <returns>ApiResponse of PageControleCartaoGrupoMCCResponse</returns>
        ApiResponse<PageControleCartaoGrupoMCCResponse> ListarControleGrupoMCCPorCartaoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, long? idGrupoMCC = null);
        
        /// <summary>
        /// Lista o controle de limites dos cart\u00F5es
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados todos os controles de limites por cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">Id do cart\u00E3o (optional)</param>
        /// <returns>PageControleLimiteCartaoResponse</returns>
        PageControleLimiteCartaoResponse ListarControlesDeLimites (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null);
  
        /// <summary>
        /// Lista o controle de limites dos cart\u00F5es
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados todos os controles de limites por cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">Id do cart\u00E3o (optional)</param>
        /// <returns>ApiResponse of PageControleLimiteCartaoResponse</returns>
        ApiResponse<PageControleLimiteCartaoResponse> ListarControlesDeLimitesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null);
        
        /// <summary>
        /// Registra a configura\u00E7\u00E3o do cart\u00E3o.
        /// </summary>
        /// <remarks>
        /// O m\u00E9todo registra a configura\u00E7\u00E3o do bloqueio ou n\u00E3o algum tipo de transa\u00E7\u00E3o de uma determinada carta portadora.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="configuracaoControleCartaoPersist">configuracaoControleCartaoPersist</param>
        /// <returns>ConfiguracaoControleCartaoResponse</returns>
        ConfiguracaoControleCartaoResponse SalvarConfiguracaoControleCartao (long? id, ConfiguracaoControleCartaoPersist configuracaoControleCartaoPersist);
  
        /// <summary>
        /// Registra a configura\u00E7\u00E3o do cart\u00E3o.
        /// </summary>
        /// <remarks>
        /// O m\u00E9todo registra a configura\u00E7\u00E3o do bloqueio ou n\u00E3o algum tipo de transa\u00E7\u00E3o de uma determinada carta portadora.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="configuracaoControleCartaoPersist">configuracaoControleCartaoPersist</param>
        /// <returns>ApiResponse of ConfiguracaoControleCartaoResponse</returns>
        ApiResponse<ConfiguracaoControleCartaoResponse> SalvarConfiguracaoControleCartaoWithHttpInfo (long? id, ConfiguracaoControleCartaoPersist configuracaoControleCartaoPersist);
        
        /// <summary>
        /// Cadastra um controle de limites para um cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja cadastrado um controle de limites para um cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="controleLimitesCartaoPersist">controleLimitesCartaoPersist</param>
        /// <returns>ControleLimiteCartaoResponse</returns>
        ControleLimiteCartaoResponse SalvarControleDeLimite (long? id, ControleLimitesCartaoPersist controleLimitesCartaoPersist);
  
        /// <summary>
        /// Cadastra um controle de limites para um cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja cadastrado um controle de limites para um cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="controleLimitesCartaoPersist">controleLimitesCartaoPersist</param>
        /// <returns>ApiResponse of ControleLimiteCartaoResponse</returns>
        ApiResponse<ControleLimiteCartaoResponse> SalvarControleDeLimiteWithHttpInfo (long? id, ControleLimitesCartaoPersist controleLimitesCartaoPersist);
        
        /// <summary>
        /// Registra o grupo mcc ao cart\u00E3o.
        /// </summary>
        /// <remarks>
        /// Cria o vinculo de grupo mcc com o cart\u00E3o para controle transa\u00E7\u00F5es por grupo de mcc.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="controleCartaoMCCPersist">controleCartaoMCCPersist</param>
        /// <returns>ControleCartaoGrupoMCCResponse</returns>
        ControleCartaoGrupoMCCResponse SalvarControleGrupoMCCPorCartao (long? id, ControleCartaoGrupoMCCPersist controleCartaoMCCPersist);
  
        /// <summary>
        /// Registra o grupo mcc ao cart\u00E3o.
        /// </summary>
        /// <remarks>
        /// Cria o vinculo de grupo mcc com o cart\u00E3o para controle transa\u00E7\u00F5es por grupo de mcc.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="controleCartaoMCCPersist">controleCartaoMCCPersist</param>
        /// <returns>ApiResponse of ControleCartaoGrupoMCCResponse</returns>
        ApiResponse<ControleCartaoGrupoMCCResponse> SalvarControleGrupoMCCPorCartaoWithHttpInfo (long? id, ControleCartaoGrupoMCCPersist controleCartaoMCCPersist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Altera qualquer parte do log de configura\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Esse m\u00E9todo permite alterar qualquer parte da configura\u00E7\u00E3o de bloqueio do cart\u00E3o ao validar o ticket de transa\u00E7\u00E3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConfiguracaoCartao">C\u00F3digo da configura\u00E7\u00E3o controle cart\u00E3o</param>
        /// <param name="id">id</param>
        /// <param name="configuracaoControleCartaoUpdate">configuracaoControleCartaoUpdate</param>
        /// <returns>Task of ConfiguracaoControleCartaoResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoControleCartaoResponse> AlterarConfiguracaoControleCartaoAsync (long? idConfiguracaoCartao, long? id, ConfiguracaoControleCartaoUpdate configuracaoControleCartaoUpdate);

        /// <summary>
        /// Altera qualquer parte do log de configura\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Esse m\u00E9todo permite alterar qualquer parte da configura\u00E7\u00E3o de bloqueio do cart\u00E3o ao validar o ticket de transa\u00E7\u00E3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConfiguracaoCartao">C\u00F3digo da configura\u00E7\u00E3o controle cart\u00E3o</param>
        /// <param name="id">id</param>
        /// <param name="configuracaoControleCartaoUpdate">configuracaoControleCartaoUpdate</param>
        /// <returns>Task of ApiResponse (ConfiguracaoControleCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoControleCartaoResponse>> AlterarConfiguracaoControleCartaoAsyncWithHttpInfo (long? idConfiguracaoCartao, long? id, ConfiguracaoControleCartaoUpdate configuracaoControleCartaoUpdate);
        
        /// <summary>
        /// Altera um controle de limites de um cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja alterado o controle de limites de um cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="idControleLimite">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites do cart\u00E3o (id)</param>
        /// <param name="controleLimitesCartaoUpdate">controleLimitesCartaoUpdate</param>
        /// <returns>Task of ControleLimiteCartaoResponse</returns>
        System.Threading.Tasks.Task<ControleLimiteCartaoResponse> AlterarControleDeLimiteAsync (long? id, long? idControleLimite, ControleLimiteCartaoUpdate controleLimitesCartaoUpdate);

        /// <summary>
        /// Altera um controle de limites de um cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja alterado o controle de limites de um cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="idControleLimite">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites do cart\u00E3o (id)</param>
        /// <param name="controleLimitesCartaoUpdate">controleLimitesCartaoUpdate</param>
        /// <returns>Task of ApiResponse (ControleLimiteCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ControleLimiteCartaoResponse>> AlterarControleDeLimiteAsyncWithHttpInfo (long? id, long? idControleLimite, ControleLimiteCartaoUpdate controleLimitesCartaoUpdate);
        
        /// <summary>
        /// Ativa um controle de limites de um cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja ativado o controle de limites de um cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="idControleLimite">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites do cart\u00E3o (id)</param>
        /// <returns>Task of ControleLimiteCartaoResponse</returns>
        System.Threading.Tasks.Task<ControleLimiteCartaoResponse> AtivarControleDeLimiteAsync (long? id, long? idControleLimite);

        /// <summary>
        /// Ativa um controle de limites de um cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja ativado o controle de limites de um cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="idControleLimite">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites do cart\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (ControleLimiteCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ControleLimiteCartaoResponse>> AtivarControleDeLimiteAsyncWithHttpInfo (long? id, long? idControleLimite);
        
        /// <summary>
        /// Exibe as configura\u00E7\u00F5es de bloqueio para um cart\u00E3o espec\u00EDfico.
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar a informa\u00E7\u00E3o da permiss\u00E3o em transa\u00E7\u00F5es de um certo Cart\u00E3o do c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConfiguracaoCartao">C\u00F3digo da configura\u00E7\u00E3o controle cart\u00E3o</param>
        /// <param name="id">id</param>
        /// <returns>Task of ConfiguracaoControleCartaoResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoControleCartaoResponse> ConsultarConfiguracaoControleCartaoAsync (long? idConfiguracaoCartao, long? id);

        /// <summary>
        /// Exibe as configura\u00E7\u00F5es de bloqueio para um cart\u00E3o espec\u00EDfico.
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar a informa\u00E7\u00E3o da permiss\u00E3o em transa\u00E7\u00F5es de um certo Cart\u00E3o do c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConfiguracaoCartao">C\u00F3digo da configura\u00E7\u00E3o controle cart\u00E3o</param>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (ConfiguracaoControleCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoControleCartaoResponse>> ConsultarConfiguracaoControleCartaoAsyncWithHttpInfo (long? idConfiguracaoCartao, long? id);
        
        /// <summary>
        /// Apresenta o controle de limites do cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja mostrado o controle de limites do cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="idControleLimite">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites do cart\u00E3o (id)</param>
        /// <returns>Task of ControleLimiteCartaoResponse</returns>
        System.Threading.Tasks.Task<ControleLimiteCartaoResponse> ConsultarControleDeLimiteAsync (long? id, long? idControleLimite);

        /// <summary>
        /// Apresenta o controle de limites do cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja mostrado o controle de limites do cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="idControleLimite">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites do cart\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (ControleLimiteCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ControleLimiteCartaoResponse>> ConsultarControleDeLimiteAsyncWithHttpInfo (long? id, long? idControleLimite);
        
        /// <summary>
        /// Exibe todos os mcc de bloqueio vinculado a um cart\u00E3o espec\u00EDfico.
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar a informa\u00E7\u00E3o de todos os mcc que est\u00E3o vinculado a um Cart\u00E3o pelo seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de controle de grupo MCC do cart\u00E3o.</param>
        /// <param name="idControleCartaoGrupoMCC">idControleCartaoGrupoMCC</param>
        /// <returns>Task of ControleCartaoGrupoMCCResponse</returns>
        System.Threading.Tasks.Task<ControleCartaoGrupoMCCResponse> ConsultarControleGrupoMCCPorCartaoAsync (long? id, long? idControleCartaoGrupoMCC);

        /// <summary>
        /// Exibe todos os mcc de bloqueio vinculado a um cart\u00E3o espec\u00EDfico.
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar a informa\u00E7\u00E3o de todos os mcc que est\u00E3o vinculado a um Cart\u00E3o pelo seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de controle de grupo MCC do cart\u00E3o.</param>
        /// <param name="idControleCartaoGrupoMCC">idControleCartaoGrupoMCC</param>
        /// <returns>Task of ApiResponse (ControleCartaoGrupoMCCResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ControleCartaoGrupoMCCResponse>> ConsultarControleGrupoMCCPorCartaoAsyncWithHttpInfo (long? id, long? idControleCartaoGrupoMCC);
        
        /// <summary>
        /// Deletar uma configura\u00E7\u00E3o de um cart\u00E3o.
        /// </summary>
        /// <remarks>
        /// O metodo Deleta a configura\u00E7\u00E3o que est\u00E1 vinculada ao cart\u00E3o e deixar sem bloqueio nas transa\u00E7\u00F5es relacionadas ao mesmo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConfiguracaoCartao">C\u00F3digo da configura\u00E7\u00E3o controle cart\u00E3o</param>
        /// <param name="id">id</param>
        /// <returns>Task of ConfiguracaoControleCartaoResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoControleCartaoResponse> DeletarConfiguracaoControleCartaoAsync (long? idConfiguracaoCartao, long? id);

        /// <summary>
        /// Deletar uma configura\u00E7\u00E3o de um cart\u00E3o.
        /// </summary>
        /// <remarks>
        /// O metodo Deleta a configura\u00E7\u00E3o que est\u00E1 vinculada ao cart\u00E3o e deixar sem bloqueio nas transa\u00E7\u00F5es relacionadas ao mesmo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConfiguracaoCartao">C\u00F3digo da configura\u00E7\u00E3o controle cart\u00E3o</param>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (ConfiguracaoControleCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoControleCartaoResponse>> DeletarConfiguracaoControleCartaoAsyncWithHttpInfo (long? idConfiguracaoCartao, long? id);
        
        /// <summary>
        /// Deletar o vinculo do mcc com um cart\u00E3o.
        /// </summary>
        /// <remarks>
        /// O metodo Deleta o vinculo do cart\u00E3o com o grupo MCC, deixando livre para transacionar de qualquer bloqueio para aquele grupo de mcc.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de controle de grupo MCC do cart\u00E3o.</param>
        /// <param name="idControleCartaoGrupoMCC">idControleCartaoGrupoMCC</param>
        /// <returns>Task of ControleCartaoGrupoMCCResponse</returns>
        System.Threading.Tasks.Task<ControleCartaoGrupoMCCResponse> DeletarControleGrupoMCCPorCartaoAsync (long? id, long? idControleCartaoGrupoMCC);

        /// <summary>
        /// Deletar o vinculo do mcc com um cart\u00E3o.
        /// </summary>
        /// <remarks>
        /// O metodo Deleta o vinculo do cart\u00E3o com o grupo MCC, deixando livre para transacionar de qualquer bloqueio para aquele grupo de mcc.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de controle de grupo MCC do cart\u00E3o.</param>
        /// <param name="idControleCartaoGrupoMCC">idControleCartaoGrupoMCC</param>
        /// <returns>Task of ApiResponse (ControleCartaoGrupoMCCResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ControleCartaoGrupoMCCResponse>> DeletarControleGrupoMCCPorCartaoAsyncWithHttpInfo (long? id, long? idControleCartaoGrupoMCC);
        
        /// <summary>
        /// Desativa um controle de limites de um cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja desativado o controle de limites de um cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="idControleLimite">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites do cart\u00E3o (id)</param>
        /// <returns>Task of ControleLimiteCartaoResponse</returns>
        System.Threading.Tasks.Task<ControleLimiteCartaoResponse> DesativarControleDeLimiteAsync (long? id, long? idControleLimite);

        /// <summary>
        /// Desativa um controle de limites de um cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja desativado o controle de limites de um cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="idControleLimite">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites do cart\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (ControleLimiteCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ControleLimiteCartaoResponse>> DesativarControleDeLimiteAsyncWithHttpInfo (long? id, long? idControleLimite);
        
        /// <summary>
        /// Lista os cart\u00F5es configurados pelo remetente
        /// </summary>
        /// <remarks>
        /// Esse m\u00E9todo permite listar os cart\u00F5es configurados para bloqueios de transa\u00E7\u00E3o na base do remetente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">C\u00F3digo Identificador do cartao na base (id) (optional)</param>
        /// <param name="permiteEcommerce">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es ecommerce (optional)</param>
        /// <param name="permiteSaque">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es de saque (optional)</param>
        /// <param name="permiteWallet">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es por meio wallet (optional)</param>
        /// <param name="permiteControleMCC">Indica se o cart\u00E3o est\u00E1 ativo para controle por grupos de MCCs (optional)</param>
        /// <param name="permiteCompraInternacional">Indica se o cart\u00E3o est\u00E1 habilitado/desabilitado para transa\u00E7\u00F5es internacionais (optional)</param>
        /// <returns>Task of PageConfiguracaoControleCartaoResponse</returns>
        System.Threading.Tasks.Task<PageConfiguracaoControleCartaoResponse> ListarConfiguracaoControleCartaoAsync (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, bool? permiteEcommerce = null, bool? permiteSaque = null, bool? permiteWallet = null, bool? permiteControleMCC = null, bool? permiteCompraInternacional = null);

        /// <summary>
        /// Lista os cart\u00F5es configurados pelo remetente
        /// </summary>
        /// <remarks>
        /// Esse m\u00E9todo permite listar os cart\u00F5es configurados para bloqueios de transa\u00E7\u00E3o na base do remetente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">C\u00F3digo Identificador do cartao na base (id) (optional)</param>
        /// <param name="permiteEcommerce">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es ecommerce (optional)</param>
        /// <param name="permiteSaque">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es de saque (optional)</param>
        /// <param name="permiteWallet">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es por meio wallet (optional)</param>
        /// <param name="permiteControleMCC">Indica se o cart\u00E3o est\u00E1 ativo para controle por grupos de MCCs (optional)</param>
        /// <param name="permiteCompraInternacional">Indica se o cart\u00E3o est\u00E1 habilitado/desabilitado para transa\u00E7\u00F5es internacionais (optional)</param>
        /// <returns>Task of ApiResponse (PageConfiguracaoControleCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageConfiguracaoControleCartaoResponse>> ListarConfiguracaoControleCartaoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, bool? permiteEcommerce = null, bool? permiteSaque = null, bool? permiteWallet = null, bool? permiteControleMCC = null, bool? permiteCompraInternacional = null);
        
        /// <summary>
        /// Lista os cart\u00F5es vinculados aos estabelecimentos.
        /// </summary>
        /// <remarks>
        /// Esse m\u00E9todo permite listar os cart\u00F5es registrados respectivamente para grupos MCC.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">C\u00F3digo Identificador do cartao na base (id) (optional)</param>
        /// <param name="idGrupoMCC">C\u00F3digo Identificador do grupo mcc na base. (optional)</param>
        /// <returns>Task of PageControleCartaoGrupoMCCResponse</returns>
        System.Threading.Tasks.Task<PageControleCartaoGrupoMCCResponse> ListarControleGrupoMCCPorCartaoAsync (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, long? idGrupoMCC = null);

        /// <summary>
        /// Lista os cart\u00F5es vinculados aos estabelecimentos.
        /// </summary>
        /// <remarks>
        /// Esse m\u00E9todo permite listar os cart\u00F5es registrados respectivamente para grupos MCC.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">C\u00F3digo Identificador do cartao na base (id) (optional)</param>
        /// <param name="idGrupoMCC">C\u00F3digo Identificador do grupo mcc na base. (optional)</param>
        /// <returns>Task of ApiResponse (PageControleCartaoGrupoMCCResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageControleCartaoGrupoMCCResponse>> ListarControleGrupoMCCPorCartaoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, long? idGrupoMCC = null);
        
        /// <summary>
        /// Lista o controle de limites dos cart\u00F5es
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados todos os controles de limites por cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">Id do cart\u00E3o (optional)</param>
        /// <returns>Task of PageControleLimiteCartaoResponse</returns>
        System.Threading.Tasks.Task<PageControleLimiteCartaoResponse> ListarControlesDeLimitesAsync (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null);

        /// <summary>
        /// Lista o controle de limites dos cart\u00F5es
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados todos os controles de limites por cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">Id do cart\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (PageControleLimiteCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageControleLimiteCartaoResponse>> ListarControlesDeLimitesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null);
        
        /// <summary>
        /// Registra a configura\u00E7\u00E3o do cart\u00E3o.
        /// </summary>
        /// <remarks>
        /// O m\u00E9todo registra a configura\u00E7\u00E3o do bloqueio ou n\u00E3o algum tipo de transa\u00E7\u00E3o de uma determinada carta portadora.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="configuracaoControleCartaoPersist">configuracaoControleCartaoPersist</param>
        /// <returns>Task of ConfiguracaoControleCartaoResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoControleCartaoResponse> SalvarConfiguracaoControleCartaoAsync (long? id, ConfiguracaoControleCartaoPersist configuracaoControleCartaoPersist);

        /// <summary>
        /// Registra a configura\u00E7\u00E3o do cart\u00E3o.
        /// </summary>
        /// <remarks>
        /// O m\u00E9todo registra a configura\u00E7\u00E3o do bloqueio ou n\u00E3o algum tipo de transa\u00E7\u00E3o de uma determinada carta portadora.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="configuracaoControleCartaoPersist">configuracaoControleCartaoPersist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoControleCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoControleCartaoResponse>> SalvarConfiguracaoControleCartaoAsyncWithHttpInfo (long? id, ConfiguracaoControleCartaoPersist configuracaoControleCartaoPersist);
        
        /// <summary>
        /// Cadastra um controle de limites para um cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja cadastrado um controle de limites para um cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="controleLimitesCartaoPersist">controleLimitesCartaoPersist</param>
        /// <returns>Task of ControleLimiteCartaoResponse</returns>
        System.Threading.Tasks.Task<ControleLimiteCartaoResponse> SalvarControleDeLimiteAsync (long? id, ControleLimitesCartaoPersist controleLimitesCartaoPersist);

        /// <summary>
        /// Cadastra um controle de limites para um cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja cadastrado um controle de limites para um cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="controleLimitesCartaoPersist">controleLimitesCartaoPersist</param>
        /// <returns>Task of ApiResponse (ControleLimiteCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ControleLimiteCartaoResponse>> SalvarControleDeLimiteAsyncWithHttpInfo (long? id, ControleLimitesCartaoPersist controleLimitesCartaoPersist);
        
        /// <summary>
        /// Registra o grupo mcc ao cart\u00E3o.
        /// </summary>
        /// <remarks>
        /// Cria o vinculo de grupo mcc com o cart\u00E3o para controle transa\u00E7\u00F5es por grupo de mcc.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="controleCartaoMCCPersist">controleCartaoMCCPersist</param>
        /// <returns>Task of ControleCartaoGrupoMCCResponse</returns>
        System.Threading.Tasks.Task<ControleCartaoGrupoMCCResponse> SalvarControleGrupoMCCPorCartaoAsync (long? id, ControleCartaoGrupoMCCPersist controleCartaoMCCPersist);

        /// <summary>
        /// Registra o grupo mcc ao cart\u00E3o.
        /// </summary>
        /// <remarks>
        /// Cria o vinculo de grupo mcc com o cart\u00E3o para controle transa\u00E7\u00F5es por grupo de mcc.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="controleCartaoMCCPersist">controleCartaoMCCPersist</param>
        /// <returns>Task of ApiResponse (ControleCartaoGrupoMCCResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ControleCartaoGrupoMCCResponse>> SalvarControleGrupoMCCPorCartaoAsyncWithHttpInfo (long? id, ControleCartaoGrupoMCCPersist controleCartaoMCCPersist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ControleCartaoApi : IControleCartaoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ControleCartaoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ControleCartaoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ControleCartaoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ControleCartaoApi(Configuration configuration = null)
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
        /// Altera qualquer parte do log de configura\u00E7\u00E3o Esse m\u00E9todo permite alterar qualquer parte da configura\u00E7\u00E3o de bloqueio do cart\u00E3o ao validar o ticket de transa\u00E7\u00E3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConfiguracaoCartao">C\u00F3digo da configura\u00E7\u00E3o controle cart\u00E3o</param> 
        /// <param name="id">id</param> 
        /// <param name="configuracaoControleCartaoUpdate">configuracaoControleCartaoUpdate</param> 
        /// <returns>ConfiguracaoControleCartaoResponse</returns>
        public ConfiguracaoControleCartaoResponse AlterarConfiguracaoControleCartao (long? idConfiguracaoCartao, long? id, ConfiguracaoControleCartaoUpdate configuracaoControleCartaoUpdate)
        {
             ApiResponse<ConfiguracaoControleCartaoResponse> localVarResponse = AlterarConfiguracaoControleCartaoWithHttpInfo(idConfiguracaoCartao, id, configuracaoControleCartaoUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera qualquer parte do log de configura\u00E7\u00E3o Esse m\u00E9todo permite alterar qualquer parte da configura\u00E7\u00E3o de bloqueio do cart\u00E3o ao validar o ticket de transa\u00E7\u00E3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConfiguracaoCartao">C\u00F3digo da configura\u00E7\u00E3o controle cart\u00E3o</param> 
        /// <param name="id">id</param> 
        /// <param name="configuracaoControleCartaoUpdate">configuracaoControleCartaoUpdate</param> 
        /// <returns>ApiResponse of ConfiguracaoControleCartaoResponse</returns>
        public ApiResponse< ConfiguracaoControleCartaoResponse > AlterarConfiguracaoControleCartaoWithHttpInfo (long? idConfiguracaoCartao, long? id, ConfiguracaoControleCartaoUpdate configuracaoControleCartaoUpdate)
        {
            
            // verify the required parameter 'idConfiguracaoCartao' is set
            if (idConfiguracaoCartao == null)
                throw new ApiException(400, "Missing required parameter 'idConfiguracaoCartao' when calling ControleCartaoApi->AlterarConfiguracaoControleCartao");
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ControleCartaoApi->AlterarConfiguracaoControleCartao");
            
            // verify the required parameter 'configuracaoControleCartaoUpdate' is set
            if (configuracaoControleCartaoUpdate == null)
                throw new ApiException(400, "Missing required parameter 'configuracaoControleCartaoUpdate' when calling ControleCartaoApi->AlterarConfiguracaoControleCartao");
            
    
            var localVarPath = "/api/cartoes/{id}/controles-configuracoes/{idConfiguracaoCartao}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConfiguracaoCartao != null) localVarPathParams.Add("idConfiguracaoCartao", Configuration.ApiClient.ParameterToString(idConfiguracaoCartao)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            if (configuracaoControleCartaoUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(configuracaoControleCartaoUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = configuracaoControleCartaoUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarConfiguracaoControleCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarConfiguracaoControleCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConfiguracaoControleCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoControleCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoControleCartaoResponse)));
            
        }

        
        /// <summary>
        /// Altera qualquer parte do log de configura\u00E7\u00E3o Esse m\u00E9todo permite alterar qualquer parte da configura\u00E7\u00E3o de bloqueio do cart\u00E3o ao validar o ticket de transa\u00E7\u00E3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConfiguracaoCartao">C\u00F3digo da configura\u00E7\u00E3o controle cart\u00E3o</param>
        /// <param name="id">id</param>
        /// <param name="configuracaoControleCartaoUpdate">configuracaoControleCartaoUpdate</param>
        /// <returns>Task of ConfiguracaoControleCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoControleCartaoResponse> AlterarConfiguracaoControleCartaoAsync (long? idConfiguracaoCartao, long? id, ConfiguracaoControleCartaoUpdate configuracaoControleCartaoUpdate)
        {
             ApiResponse<ConfiguracaoControleCartaoResponse> localVarResponse = await AlterarConfiguracaoControleCartaoAsyncWithHttpInfo(idConfiguracaoCartao, id, configuracaoControleCartaoUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera qualquer parte do log de configura\u00E7\u00E3o Esse m\u00E9todo permite alterar qualquer parte da configura\u00E7\u00E3o de bloqueio do cart\u00E3o ao validar o ticket de transa\u00E7\u00E3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConfiguracaoCartao">C\u00F3digo da configura\u00E7\u00E3o controle cart\u00E3o</param>
        /// <param name="id">id</param>
        /// <param name="configuracaoControleCartaoUpdate">configuracaoControleCartaoUpdate</param>
        /// <returns>Task of ApiResponse (ConfiguracaoControleCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfiguracaoControleCartaoResponse>> AlterarConfiguracaoControleCartaoAsyncWithHttpInfo (long? idConfiguracaoCartao, long? id, ConfiguracaoControleCartaoUpdate configuracaoControleCartaoUpdate)
        {
            // verify the required parameter 'idConfiguracaoCartao' is set
            if (idConfiguracaoCartao == null) throw new ApiException(400, "Missing required parameter 'idConfiguracaoCartao' when calling AlterarConfiguracaoControleCartao");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarConfiguracaoControleCartao");
            // verify the required parameter 'configuracaoControleCartaoUpdate' is set
            if (configuracaoControleCartaoUpdate == null) throw new ApiException(400, "Missing required parameter 'configuracaoControleCartaoUpdate' when calling AlterarConfiguracaoControleCartao");
            
    
            var localVarPath = "/api/cartoes/{id}/controles-configuracoes/{idConfiguracaoCartao}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConfiguracaoCartao != null) localVarPathParams.Add("idConfiguracaoCartao", Configuration.ApiClient.ParameterToString(idConfiguracaoCartao)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            if (configuracaoControleCartaoUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(configuracaoControleCartaoUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = configuracaoControleCartaoUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarConfiguracaoControleCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarConfiguracaoControleCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfiguracaoControleCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoControleCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoControleCartaoResponse)));
            
        }
        
        /// <summary>
        /// Altera um controle de limites de um cart\u00E3o Este recurso permite que seja alterado o controle de limites de um cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param> 
        /// <param name="idControleLimite">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites do cart\u00E3o (id)</param> 
        /// <param name="controleLimitesCartaoUpdate">controleLimitesCartaoUpdate</param> 
        /// <returns>ControleLimiteCartaoResponse</returns>
        public ControleLimiteCartaoResponse AlterarControleDeLimite (long? id, long? idControleLimite, ControleLimiteCartaoUpdate controleLimitesCartaoUpdate)
        {
             ApiResponse<ControleLimiteCartaoResponse> localVarResponse = AlterarControleDeLimiteWithHttpInfo(id, idControleLimite, controleLimitesCartaoUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera um controle de limites de um cart\u00E3o Este recurso permite que seja alterado o controle de limites de um cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param> 
        /// <param name="idControleLimite">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites do cart\u00E3o (id)</param> 
        /// <param name="controleLimitesCartaoUpdate">controleLimitesCartaoUpdate</param> 
        /// <returns>ApiResponse of ControleLimiteCartaoResponse</returns>
        public ApiResponse< ControleLimiteCartaoResponse > AlterarControleDeLimiteWithHttpInfo (long? id, long? idControleLimite, ControleLimiteCartaoUpdate controleLimitesCartaoUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ControleCartaoApi->AlterarControleDeLimite");
            
            // verify the required parameter 'idControleLimite' is set
            if (idControleLimite == null)
                throw new ApiException(400, "Missing required parameter 'idControleLimite' when calling ControleCartaoApi->AlterarControleDeLimite");
            
            // verify the required parameter 'controleLimitesCartaoUpdate' is set
            if (controleLimitesCartaoUpdate == null)
                throw new ApiException(400, "Missing required parameter 'controleLimitesCartaoUpdate' when calling ControleCartaoApi->AlterarControleDeLimite");
            
    
            var localVarPath = "/api/cartoes/{id}/controles-limites/{idControleLimite}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idControleLimite != null) localVarPathParams.Add("idControleLimite", Configuration.ApiClient.ParameterToString(idControleLimite)); // path parameter
            
            
            
            
            if (controleLimitesCartaoUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(controleLimitesCartaoUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = controleLimitesCartaoUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarControleDeLimite: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarControleDeLimite: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ControleLimiteCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleLimiteCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleLimiteCartaoResponse)));
            
        }

        
        /// <summary>
        /// Altera um controle de limites de um cart\u00E3o Este recurso permite que seja alterado o controle de limites de um cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="idControleLimite">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites do cart\u00E3o (id)</param>
        /// <param name="controleLimitesCartaoUpdate">controleLimitesCartaoUpdate</param>
        /// <returns>Task of ControleLimiteCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ControleLimiteCartaoResponse> AlterarControleDeLimiteAsync (long? id, long? idControleLimite, ControleLimiteCartaoUpdate controleLimitesCartaoUpdate)
        {
             ApiResponse<ControleLimiteCartaoResponse> localVarResponse = await AlterarControleDeLimiteAsyncWithHttpInfo(id, idControleLimite, controleLimitesCartaoUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera um controle de limites de um cart\u00E3o Este recurso permite que seja alterado o controle de limites de um cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="idControleLimite">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites do cart\u00E3o (id)</param>
        /// <param name="controleLimitesCartaoUpdate">controleLimitesCartaoUpdate</param>
        /// <returns>Task of ApiResponse (ControleLimiteCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ControleLimiteCartaoResponse>> AlterarControleDeLimiteAsyncWithHttpInfo (long? id, long? idControleLimite, ControleLimiteCartaoUpdate controleLimitesCartaoUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarControleDeLimite");
            // verify the required parameter 'idControleLimite' is set
            if (idControleLimite == null) throw new ApiException(400, "Missing required parameter 'idControleLimite' when calling AlterarControleDeLimite");
            // verify the required parameter 'controleLimitesCartaoUpdate' is set
            if (controleLimitesCartaoUpdate == null) throw new ApiException(400, "Missing required parameter 'controleLimitesCartaoUpdate' when calling AlterarControleDeLimite");
            
    
            var localVarPath = "/api/cartoes/{id}/controles-limites/{idControleLimite}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idControleLimite != null) localVarPathParams.Add("idControleLimite", Configuration.ApiClient.ParameterToString(idControleLimite)); // path parameter
            
            
            
            
            if (controleLimitesCartaoUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(controleLimitesCartaoUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = controleLimitesCartaoUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarControleDeLimite: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarControleDeLimite: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ControleLimiteCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleLimiteCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleLimiteCartaoResponse)));
            
        }
        
        /// <summary>
        /// Ativa um controle de limites de um cart\u00E3o Este recurso permite que seja ativado o controle de limites de um cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param> 
        /// <param name="idControleLimite">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites do cart\u00E3o (id)</param> 
        /// <returns>ControleLimiteCartaoResponse</returns>
        public ControleLimiteCartaoResponse AtivarControleDeLimite (long? id, long? idControleLimite)
        {
             ApiResponse<ControleLimiteCartaoResponse> localVarResponse = AtivarControleDeLimiteWithHttpInfo(id, idControleLimite);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Ativa um controle de limites de um cart\u00E3o Este recurso permite que seja ativado o controle de limites de um cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param> 
        /// <param name="idControleLimite">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites do cart\u00E3o (id)</param> 
        /// <returns>ApiResponse of ControleLimiteCartaoResponse</returns>
        public ApiResponse< ControleLimiteCartaoResponse > AtivarControleDeLimiteWithHttpInfo (long? id, long? idControleLimite)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ControleCartaoApi->AtivarControleDeLimite");
            
            // verify the required parameter 'idControleLimite' is set
            if (idControleLimite == null)
                throw new ApiException(400, "Missing required parameter 'idControleLimite' when calling ControleCartaoApi->AtivarControleDeLimite");
            
    
            var localVarPath = "/api/cartoes/{id}/controles-limites/{idControleLimite}/ativar";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idControleLimite != null) localVarPathParams.Add("idControleLimite", Configuration.ApiClient.ParameterToString(idControleLimite)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtivarControleDeLimite: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarControleDeLimite: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ControleLimiteCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleLimiteCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleLimiteCartaoResponse)));
            
        }

        
        /// <summary>
        /// Ativa um controle de limites de um cart\u00E3o Este recurso permite que seja ativado o controle de limites de um cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="idControleLimite">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites do cart\u00E3o (id)</param>
        /// <returns>Task of ControleLimiteCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ControleLimiteCartaoResponse> AtivarControleDeLimiteAsync (long? id, long? idControleLimite)
        {
             ApiResponse<ControleLimiteCartaoResponse> localVarResponse = await AtivarControleDeLimiteAsyncWithHttpInfo(id, idControleLimite);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Ativa um controle de limites de um cart\u00E3o Este recurso permite que seja ativado o controle de limites de um cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="idControleLimite">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites do cart\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (ControleLimiteCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ControleLimiteCartaoResponse>> AtivarControleDeLimiteAsyncWithHttpInfo (long? id, long? idControleLimite)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtivarControleDeLimite");
            // verify the required parameter 'idControleLimite' is set
            if (idControleLimite == null) throw new ApiException(400, "Missing required parameter 'idControleLimite' when calling AtivarControleDeLimite");
            
    
            var localVarPath = "/api/cartoes/{id}/controles-limites/{idControleLimite}/ativar";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idControleLimite != null) localVarPathParams.Add("idControleLimite", Configuration.ApiClient.ParameterToString(idControleLimite)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtivarControleDeLimite: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarControleDeLimite: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ControleLimiteCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleLimiteCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleLimiteCartaoResponse)));
            
        }
        
        /// <summary>
        /// Exibe as configura\u00E7\u00F5es de bloqueio para um cart\u00E3o espec\u00EDfico. Este m\u00E9todo permite consultar a informa\u00E7\u00E3o da permiss\u00E3o em transa\u00E7\u00F5es de um certo Cart\u00E3o do c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConfiguracaoCartao">C\u00F3digo da configura\u00E7\u00E3o controle cart\u00E3o</param> 
        /// <param name="id">id</param> 
        /// <returns>ConfiguracaoControleCartaoResponse</returns>
        public ConfiguracaoControleCartaoResponse ConsultarConfiguracaoControleCartao (long? idConfiguracaoCartao, long? id)
        {
             ApiResponse<ConfiguracaoControleCartaoResponse> localVarResponse = ConsultarConfiguracaoControleCartaoWithHttpInfo(idConfiguracaoCartao, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Exibe as configura\u00E7\u00F5es de bloqueio para um cart\u00E3o espec\u00EDfico. Este m\u00E9todo permite consultar a informa\u00E7\u00E3o da permiss\u00E3o em transa\u00E7\u00F5es de um certo Cart\u00E3o do c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConfiguracaoCartao">C\u00F3digo da configura\u00E7\u00E3o controle cart\u00E3o</param> 
        /// <param name="id">id</param> 
        /// <returns>ApiResponse of ConfiguracaoControleCartaoResponse</returns>
        public ApiResponse< ConfiguracaoControleCartaoResponse > ConsultarConfiguracaoControleCartaoWithHttpInfo (long? idConfiguracaoCartao, long? id)
        {
            
            // verify the required parameter 'idConfiguracaoCartao' is set
            if (idConfiguracaoCartao == null)
                throw new ApiException(400, "Missing required parameter 'idConfiguracaoCartao' when calling ControleCartaoApi->ConsultarConfiguracaoControleCartao");
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ControleCartaoApi->ConsultarConfiguracaoControleCartao");
            
    
            var localVarPath = "/api/cartoes/{id}/controles-configuracoes/{idConfiguracaoCartao}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConfiguracaoCartao != null) localVarPathParams.Add("idConfiguracaoCartao", Configuration.ApiClient.ParameterToString(idConfiguracaoCartao)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarConfiguracaoControleCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarConfiguracaoControleCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConfiguracaoControleCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoControleCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoControleCartaoResponse)));
            
        }

        
        /// <summary>
        /// Exibe as configura\u00E7\u00F5es de bloqueio para um cart\u00E3o espec\u00EDfico. Este m\u00E9todo permite consultar a informa\u00E7\u00E3o da permiss\u00E3o em transa\u00E7\u00F5es de um certo Cart\u00E3o do c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConfiguracaoCartao">C\u00F3digo da configura\u00E7\u00E3o controle cart\u00E3o</param>
        /// <param name="id">id</param>
        /// <returns>Task of ConfiguracaoControleCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoControleCartaoResponse> ConsultarConfiguracaoControleCartaoAsync (long? idConfiguracaoCartao, long? id)
        {
             ApiResponse<ConfiguracaoControleCartaoResponse> localVarResponse = await ConsultarConfiguracaoControleCartaoAsyncWithHttpInfo(idConfiguracaoCartao, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Exibe as configura\u00E7\u00F5es de bloqueio para um cart\u00E3o espec\u00EDfico. Este m\u00E9todo permite consultar a informa\u00E7\u00E3o da permiss\u00E3o em transa\u00E7\u00F5es de um certo Cart\u00E3o do c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConfiguracaoCartao">C\u00F3digo da configura\u00E7\u00E3o controle cart\u00E3o</param>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (ConfiguracaoControleCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfiguracaoControleCartaoResponse>> ConsultarConfiguracaoControleCartaoAsyncWithHttpInfo (long? idConfiguracaoCartao, long? id)
        {
            // verify the required parameter 'idConfiguracaoCartao' is set
            if (idConfiguracaoCartao == null) throw new ApiException(400, "Missing required parameter 'idConfiguracaoCartao' when calling ConsultarConfiguracaoControleCartao");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarConfiguracaoControleCartao");
            
    
            var localVarPath = "/api/cartoes/{id}/controles-configuracoes/{idConfiguracaoCartao}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConfiguracaoCartao != null) localVarPathParams.Add("idConfiguracaoCartao", Configuration.ApiClient.ParameterToString(idConfiguracaoCartao)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarConfiguracaoControleCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarConfiguracaoControleCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfiguracaoControleCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoControleCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoControleCartaoResponse)));
            
        }
        
        /// <summary>
        /// Apresenta o controle de limites do cart\u00E3o Este recurso permite que seja mostrado o controle de limites do cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param> 
        /// <param name="idControleLimite">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites do cart\u00E3o (id)</param> 
        /// <returns>ControleLimiteCartaoResponse</returns>
        public ControleLimiteCartaoResponse ConsultarControleDeLimite (long? id, long? idControleLimite)
        {
             ApiResponse<ControleLimiteCartaoResponse> localVarResponse = ConsultarControleDeLimiteWithHttpInfo(id, idControleLimite);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta o controle de limites do cart\u00E3o Este recurso permite que seja mostrado o controle de limites do cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param> 
        /// <param name="idControleLimite">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites do cart\u00E3o (id)</param> 
        /// <returns>ApiResponse of ControleLimiteCartaoResponse</returns>
        public ApiResponse< ControleLimiteCartaoResponse > ConsultarControleDeLimiteWithHttpInfo (long? id, long? idControleLimite)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ControleCartaoApi->ConsultarControleDeLimite");
            
            // verify the required parameter 'idControleLimite' is set
            if (idControleLimite == null)
                throw new ApiException(400, "Missing required parameter 'idControleLimite' when calling ControleCartaoApi->ConsultarControleDeLimite");
            
    
            var localVarPath = "/api/cartoes/{id}/controles-limites/{idControleLimite}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idControleLimite != null) localVarPathParams.Add("idControleLimite", Configuration.ApiClient.ParameterToString(idControleLimite)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarControleDeLimite: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarControleDeLimite: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ControleLimiteCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleLimiteCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleLimiteCartaoResponse)));
            
        }

        
        /// <summary>
        /// Apresenta o controle de limites do cart\u00E3o Este recurso permite que seja mostrado o controle de limites do cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="idControleLimite">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites do cart\u00E3o (id)</param>
        /// <returns>Task of ControleLimiteCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ControleLimiteCartaoResponse> ConsultarControleDeLimiteAsync (long? id, long? idControleLimite)
        {
             ApiResponse<ControleLimiteCartaoResponse> localVarResponse = await ConsultarControleDeLimiteAsyncWithHttpInfo(id, idControleLimite);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta o controle de limites do cart\u00E3o Este recurso permite que seja mostrado o controle de limites do cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="idControleLimite">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites do cart\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (ControleLimiteCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ControleLimiteCartaoResponse>> ConsultarControleDeLimiteAsyncWithHttpInfo (long? id, long? idControleLimite)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarControleDeLimite");
            // verify the required parameter 'idControleLimite' is set
            if (idControleLimite == null) throw new ApiException(400, "Missing required parameter 'idControleLimite' when calling ConsultarControleDeLimite");
            
    
            var localVarPath = "/api/cartoes/{id}/controles-limites/{idControleLimite}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idControleLimite != null) localVarPathParams.Add("idControleLimite", Configuration.ApiClient.ParameterToString(idControleLimite)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarControleDeLimite: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarControleDeLimite: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ControleLimiteCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleLimiteCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleLimiteCartaoResponse)));
            
        }
        
        /// <summary>
        /// Exibe todos os mcc de bloqueio vinculado a um cart\u00E3o espec\u00EDfico. Este m\u00E9todo permite consultar a informa\u00E7\u00E3o de todos os mcc que est\u00E3o vinculado a um Cart\u00E3o pelo seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de controle de grupo MCC do cart\u00E3o.</param> 
        /// <param name="idControleCartaoGrupoMCC">idControleCartaoGrupoMCC</param> 
        /// <returns>ControleCartaoGrupoMCCResponse</returns>
        public ControleCartaoGrupoMCCResponse ConsultarControleGrupoMCCPorCartao (long? id, long? idControleCartaoGrupoMCC)
        {
             ApiResponse<ControleCartaoGrupoMCCResponse> localVarResponse = ConsultarControleGrupoMCCPorCartaoWithHttpInfo(id, idControleCartaoGrupoMCC);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Exibe todos os mcc de bloqueio vinculado a um cart\u00E3o espec\u00EDfico. Este m\u00E9todo permite consultar a informa\u00E7\u00E3o de todos os mcc que est\u00E3o vinculado a um Cart\u00E3o pelo seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de controle de grupo MCC do cart\u00E3o.</param> 
        /// <param name="idControleCartaoGrupoMCC">idControleCartaoGrupoMCC</param> 
        /// <returns>ApiResponse of ControleCartaoGrupoMCCResponse</returns>
        public ApiResponse< ControleCartaoGrupoMCCResponse > ConsultarControleGrupoMCCPorCartaoWithHttpInfo (long? id, long? idControleCartaoGrupoMCC)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ControleCartaoApi->ConsultarControleGrupoMCCPorCartao");
            
            // verify the required parameter 'idControleCartaoGrupoMCC' is set
            if (idControleCartaoGrupoMCC == null)
                throw new ApiException(400, "Missing required parameter 'idControleCartaoGrupoMCC' when calling ControleCartaoApi->ConsultarControleGrupoMCCPorCartao");
            
    
            var localVarPath = "/api/cartoes/{id}/controles-grupomcc/{idControleCartaoGrupoMCC}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idControleCartaoGrupoMCC != null) localVarPathParams.Add("idControleCartaoGrupoMCC", Configuration.ApiClient.ParameterToString(idControleCartaoGrupoMCC)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarControleGrupoMCCPorCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarControleGrupoMCCPorCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ControleCartaoGrupoMCCResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleCartaoGrupoMCCResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleCartaoGrupoMCCResponse)));
            
        }

        
        /// <summary>
        /// Exibe todos os mcc de bloqueio vinculado a um cart\u00E3o espec\u00EDfico. Este m\u00E9todo permite consultar a informa\u00E7\u00E3o de todos os mcc que est\u00E3o vinculado a um Cart\u00E3o pelo seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de controle de grupo MCC do cart\u00E3o.</param>
        /// <param name="idControleCartaoGrupoMCC">idControleCartaoGrupoMCC</param>
        /// <returns>Task of ControleCartaoGrupoMCCResponse</returns>
        public async System.Threading.Tasks.Task<ControleCartaoGrupoMCCResponse> ConsultarControleGrupoMCCPorCartaoAsync (long? id, long? idControleCartaoGrupoMCC)
        {
             ApiResponse<ControleCartaoGrupoMCCResponse> localVarResponse = await ConsultarControleGrupoMCCPorCartaoAsyncWithHttpInfo(id, idControleCartaoGrupoMCC);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Exibe todos os mcc de bloqueio vinculado a um cart\u00E3o espec\u00EDfico. Este m\u00E9todo permite consultar a informa\u00E7\u00E3o de todos os mcc que est\u00E3o vinculado a um Cart\u00E3o pelo seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de controle de grupo MCC do cart\u00E3o.</param>
        /// <param name="idControleCartaoGrupoMCC">idControleCartaoGrupoMCC</param>
        /// <returns>Task of ApiResponse (ControleCartaoGrupoMCCResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ControleCartaoGrupoMCCResponse>> ConsultarControleGrupoMCCPorCartaoAsyncWithHttpInfo (long? id, long? idControleCartaoGrupoMCC)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarControleGrupoMCCPorCartao");
            // verify the required parameter 'idControleCartaoGrupoMCC' is set
            if (idControleCartaoGrupoMCC == null) throw new ApiException(400, "Missing required parameter 'idControleCartaoGrupoMCC' when calling ConsultarControleGrupoMCCPorCartao");
            
    
            var localVarPath = "/api/cartoes/{id}/controles-grupomcc/{idControleCartaoGrupoMCC}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idControleCartaoGrupoMCC != null) localVarPathParams.Add("idControleCartaoGrupoMCC", Configuration.ApiClient.ParameterToString(idControleCartaoGrupoMCC)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarControleGrupoMCCPorCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarControleGrupoMCCPorCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ControleCartaoGrupoMCCResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleCartaoGrupoMCCResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleCartaoGrupoMCCResponse)));
            
        }
        
        /// <summary>
        /// Deletar uma configura\u00E7\u00E3o de um cart\u00E3o. O metodo Deleta a configura\u00E7\u00E3o que est\u00E1 vinculada ao cart\u00E3o e deixar sem bloqueio nas transa\u00E7\u00F5es relacionadas ao mesmo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConfiguracaoCartao">C\u00F3digo da configura\u00E7\u00E3o controle cart\u00E3o</param> 
        /// <param name="id">id</param> 
        /// <returns>ConfiguracaoControleCartaoResponse</returns>
        public ConfiguracaoControleCartaoResponse DeletarConfiguracaoControleCartao (long? idConfiguracaoCartao, long? id)
        {
             ApiResponse<ConfiguracaoControleCartaoResponse> localVarResponse = DeletarConfiguracaoControleCartaoWithHttpInfo(idConfiguracaoCartao, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Deletar uma configura\u00E7\u00E3o de um cart\u00E3o. O metodo Deleta a configura\u00E7\u00E3o que est\u00E1 vinculada ao cart\u00E3o e deixar sem bloqueio nas transa\u00E7\u00F5es relacionadas ao mesmo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConfiguracaoCartao">C\u00F3digo da configura\u00E7\u00E3o controle cart\u00E3o</param> 
        /// <param name="id">id</param> 
        /// <returns>ApiResponse of ConfiguracaoControleCartaoResponse</returns>
        public ApiResponse< ConfiguracaoControleCartaoResponse > DeletarConfiguracaoControleCartaoWithHttpInfo (long? idConfiguracaoCartao, long? id)
        {
            
            // verify the required parameter 'idConfiguracaoCartao' is set
            if (idConfiguracaoCartao == null)
                throw new ApiException(400, "Missing required parameter 'idConfiguracaoCartao' when calling ControleCartaoApi->DeletarConfiguracaoControleCartao");
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ControleCartaoApi->DeletarConfiguracaoControleCartao");
            
    
            var localVarPath = "/api/cartoes/{id}/controles-configuracoes/{idConfiguracaoCartao}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConfiguracaoCartao != null) localVarPathParams.Add("idConfiguracaoCartao", Configuration.ApiClient.ParameterToString(idConfiguracaoCartao)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeletarConfiguracaoControleCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletarConfiguracaoControleCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConfiguracaoControleCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoControleCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoControleCartaoResponse)));
            
        }

        
        /// <summary>
        /// Deletar uma configura\u00E7\u00E3o de um cart\u00E3o. O metodo Deleta a configura\u00E7\u00E3o que est\u00E1 vinculada ao cart\u00E3o e deixar sem bloqueio nas transa\u00E7\u00F5es relacionadas ao mesmo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConfiguracaoCartao">C\u00F3digo da configura\u00E7\u00E3o controle cart\u00E3o</param>
        /// <param name="id">id</param>
        /// <returns>Task of ConfiguracaoControleCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoControleCartaoResponse> DeletarConfiguracaoControleCartaoAsync (long? idConfiguracaoCartao, long? id)
        {
             ApiResponse<ConfiguracaoControleCartaoResponse> localVarResponse = await DeletarConfiguracaoControleCartaoAsyncWithHttpInfo(idConfiguracaoCartao, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Deletar uma configura\u00E7\u00E3o de um cart\u00E3o. O metodo Deleta a configura\u00E7\u00E3o que est\u00E1 vinculada ao cart\u00E3o e deixar sem bloqueio nas transa\u00E7\u00F5es relacionadas ao mesmo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConfiguracaoCartao">C\u00F3digo da configura\u00E7\u00E3o controle cart\u00E3o</param>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (ConfiguracaoControleCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfiguracaoControleCartaoResponse>> DeletarConfiguracaoControleCartaoAsyncWithHttpInfo (long? idConfiguracaoCartao, long? id)
        {
            // verify the required parameter 'idConfiguracaoCartao' is set
            if (idConfiguracaoCartao == null) throw new ApiException(400, "Missing required parameter 'idConfiguracaoCartao' when calling DeletarConfiguracaoControleCartao");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeletarConfiguracaoControleCartao");
            
    
            var localVarPath = "/api/cartoes/{id}/controles-configuracoes/{idConfiguracaoCartao}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConfiguracaoCartao != null) localVarPathParams.Add("idConfiguracaoCartao", Configuration.ApiClient.ParameterToString(idConfiguracaoCartao)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeletarConfiguracaoControleCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletarConfiguracaoControleCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfiguracaoControleCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoControleCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoControleCartaoResponse)));
            
        }
        
        /// <summary>
        /// Deletar o vinculo do mcc com um cart\u00E3o. O metodo Deleta o vinculo do cart\u00E3o com o grupo MCC, deixando livre para transacionar de qualquer bloqueio para aquele grupo de mcc.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de controle de grupo MCC do cart\u00E3o.</param> 
        /// <param name="idControleCartaoGrupoMCC">idControleCartaoGrupoMCC</param> 
        /// <returns>ControleCartaoGrupoMCCResponse</returns>
        public ControleCartaoGrupoMCCResponse DeletarControleGrupoMCCPorCartao (long? id, long? idControleCartaoGrupoMCC)
        {
             ApiResponse<ControleCartaoGrupoMCCResponse> localVarResponse = DeletarControleGrupoMCCPorCartaoWithHttpInfo(id, idControleCartaoGrupoMCC);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Deletar o vinculo do mcc com um cart\u00E3o. O metodo Deleta o vinculo do cart\u00E3o com o grupo MCC, deixando livre para transacionar de qualquer bloqueio para aquele grupo de mcc.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de controle de grupo MCC do cart\u00E3o.</param> 
        /// <param name="idControleCartaoGrupoMCC">idControleCartaoGrupoMCC</param> 
        /// <returns>ApiResponse of ControleCartaoGrupoMCCResponse</returns>
        public ApiResponse< ControleCartaoGrupoMCCResponse > DeletarControleGrupoMCCPorCartaoWithHttpInfo (long? id, long? idControleCartaoGrupoMCC)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ControleCartaoApi->DeletarControleGrupoMCCPorCartao");
            
            // verify the required parameter 'idControleCartaoGrupoMCC' is set
            if (idControleCartaoGrupoMCC == null)
                throw new ApiException(400, "Missing required parameter 'idControleCartaoGrupoMCC' when calling ControleCartaoApi->DeletarControleGrupoMCCPorCartao");
            
    
            var localVarPath = "/api/cartoes/{id}/controles-grupomcc/{idControleCartaoGrupoMCC}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idControleCartaoGrupoMCC != null) localVarPathParams.Add("idControleCartaoGrupoMCC", Configuration.ApiClient.ParameterToString(idControleCartaoGrupoMCC)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeletarControleGrupoMCCPorCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletarControleGrupoMCCPorCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ControleCartaoGrupoMCCResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleCartaoGrupoMCCResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleCartaoGrupoMCCResponse)));
            
        }

        
        /// <summary>
        /// Deletar o vinculo do mcc com um cart\u00E3o. O metodo Deleta o vinculo do cart\u00E3o com o grupo MCC, deixando livre para transacionar de qualquer bloqueio para aquele grupo de mcc.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de controle de grupo MCC do cart\u00E3o.</param>
        /// <param name="idControleCartaoGrupoMCC">idControleCartaoGrupoMCC</param>
        /// <returns>Task of ControleCartaoGrupoMCCResponse</returns>
        public async System.Threading.Tasks.Task<ControleCartaoGrupoMCCResponse> DeletarControleGrupoMCCPorCartaoAsync (long? id, long? idControleCartaoGrupoMCC)
        {
             ApiResponse<ControleCartaoGrupoMCCResponse> localVarResponse = await DeletarControleGrupoMCCPorCartaoAsyncWithHttpInfo(id, idControleCartaoGrupoMCC);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Deletar o vinculo do mcc com um cart\u00E3o. O metodo Deleta o vinculo do cart\u00E3o com o grupo MCC, deixando livre para transacionar de qualquer bloqueio para aquele grupo de mcc.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de controle de grupo MCC do cart\u00E3o.</param>
        /// <param name="idControleCartaoGrupoMCC">idControleCartaoGrupoMCC</param>
        /// <returns>Task of ApiResponse (ControleCartaoGrupoMCCResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ControleCartaoGrupoMCCResponse>> DeletarControleGrupoMCCPorCartaoAsyncWithHttpInfo (long? id, long? idControleCartaoGrupoMCC)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeletarControleGrupoMCCPorCartao");
            // verify the required parameter 'idControleCartaoGrupoMCC' is set
            if (idControleCartaoGrupoMCC == null) throw new ApiException(400, "Missing required parameter 'idControleCartaoGrupoMCC' when calling DeletarControleGrupoMCCPorCartao");
            
    
            var localVarPath = "/api/cartoes/{id}/controles-grupomcc/{idControleCartaoGrupoMCC}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idControleCartaoGrupoMCC != null) localVarPathParams.Add("idControleCartaoGrupoMCC", Configuration.ApiClient.ParameterToString(idControleCartaoGrupoMCC)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeletarControleGrupoMCCPorCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletarControleGrupoMCCPorCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ControleCartaoGrupoMCCResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleCartaoGrupoMCCResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleCartaoGrupoMCCResponse)));
            
        }
        
        /// <summary>
        /// Desativa um controle de limites de um cart\u00E3o Este recurso permite que seja desativado o controle de limites de um cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param> 
        /// <param name="idControleLimite">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites do cart\u00E3o (id)</param> 
        /// <returns>ControleLimiteCartaoResponse</returns>
        public ControleLimiteCartaoResponse DesativarControleDeLimite (long? id, long? idControleLimite)
        {
             ApiResponse<ControleLimiteCartaoResponse> localVarResponse = DesativarControleDeLimiteWithHttpInfo(id, idControleLimite);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Desativa um controle de limites de um cart\u00E3o Este recurso permite que seja desativado o controle de limites de um cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param> 
        /// <param name="idControleLimite">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites do cart\u00E3o (id)</param> 
        /// <returns>ApiResponse of ControleLimiteCartaoResponse</returns>
        public ApiResponse< ControleLimiteCartaoResponse > DesativarControleDeLimiteWithHttpInfo (long? id, long? idControleLimite)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ControleCartaoApi->DesativarControleDeLimite");
            
            // verify the required parameter 'idControleLimite' is set
            if (idControleLimite == null)
                throw new ApiException(400, "Missing required parameter 'idControleLimite' when calling ControleCartaoApi->DesativarControleDeLimite");
            
    
            var localVarPath = "/api/cartoes/{id}/controles-limites/{idControleLimite}/desativar";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idControleLimite != null) localVarPathParams.Add("idControleLimite", Configuration.ApiClient.ParameterToString(idControleLimite)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesativarControleDeLimite: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarControleDeLimite: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ControleLimiteCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleLimiteCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleLimiteCartaoResponse)));
            
        }

        
        /// <summary>
        /// Desativa um controle de limites de um cart\u00E3o Este recurso permite que seja desativado o controle de limites de um cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="idControleLimite">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites do cart\u00E3o (id)</param>
        /// <returns>Task of ControleLimiteCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ControleLimiteCartaoResponse> DesativarControleDeLimiteAsync (long? id, long? idControleLimite)
        {
             ApiResponse<ControleLimiteCartaoResponse> localVarResponse = await DesativarControleDeLimiteAsyncWithHttpInfo(id, idControleLimite);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Desativa um controle de limites de um cart\u00E3o Este recurso permite que seja desativado o controle de limites de um cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="idControleLimite">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites do cart\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (ControleLimiteCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ControleLimiteCartaoResponse>> DesativarControleDeLimiteAsyncWithHttpInfo (long? id, long? idControleLimite)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesativarControleDeLimite");
            // verify the required parameter 'idControleLimite' is set
            if (idControleLimite == null) throw new ApiException(400, "Missing required parameter 'idControleLimite' when calling DesativarControleDeLimite");
            
    
            var localVarPath = "/api/cartoes/{id}/controles-limites/{idControleLimite}/desativar";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idControleLimite != null) localVarPathParams.Add("idControleLimite", Configuration.ApiClient.ParameterToString(idControleLimite)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesativarControleDeLimite: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarControleDeLimite: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ControleLimiteCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleLimiteCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleLimiteCartaoResponse)));
            
        }
        
        /// <summary>
        /// Lista os cart\u00F5es configurados pelo remetente Esse m\u00E9todo permite listar os cart\u00F5es configurados para bloqueios de transa\u00E7\u00E3o na base do remetente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idCartao">C\u00F3digo Identificador do cartao na base (id) (optional)</param> 
        /// <param name="permiteEcommerce">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es ecommerce (optional)</param> 
        /// <param name="permiteSaque">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es de saque (optional)</param> 
        /// <param name="permiteWallet">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es por meio wallet (optional)</param> 
        /// <param name="permiteControleMCC">Indica se o cart\u00E3o est\u00E1 ativo para controle por grupos de MCCs (optional)</param> 
        /// <param name="permiteCompraInternacional">Indica se o cart\u00E3o est\u00E1 habilitado/desabilitado para transa\u00E7\u00F5es internacionais (optional)</param> 
        /// <returns>PageConfiguracaoControleCartaoResponse</returns>
        public PageConfiguracaoControleCartaoResponse ListarConfiguracaoControleCartao (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, bool? permiteEcommerce = null, bool? permiteSaque = null, bool? permiteWallet = null, bool? permiteControleMCC = null, bool? permiteCompraInternacional = null)
        {
             ApiResponse<PageConfiguracaoControleCartaoResponse> localVarResponse = ListarConfiguracaoControleCartaoWithHttpInfo(sort, page, limit, idCartao, permiteEcommerce, permiteSaque, permiteWallet, permiteControleMCC, permiteCompraInternacional);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os cart\u00F5es configurados pelo remetente Esse m\u00E9todo permite listar os cart\u00F5es configurados para bloqueios de transa\u00E7\u00E3o na base do remetente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idCartao">C\u00F3digo Identificador do cartao na base (id) (optional)</param> 
        /// <param name="permiteEcommerce">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es ecommerce (optional)</param> 
        /// <param name="permiteSaque">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es de saque (optional)</param> 
        /// <param name="permiteWallet">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es por meio wallet (optional)</param> 
        /// <param name="permiteControleMCC">Indica se o cart\u00E3o est\u00E1 ativo para controle por grupos de MCCs (optional)</param> 
        /// <param name="permiteCompraInternacional">Indica se o cart\u00E3o est\u00E1 habilitado/desabilitado para transa\u00E7\u00F5es internacionais (optional)</param> 
        /// <returns>ApiResponse of PageConfiguracaoControleCartaoResponse</returns>
        public ApiResponse< PageConfiguracaoControleCartaoResponse > ListarConfiguracaoControleCartaoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, bool? permiteEcommerce = null, bool? permiteSaque = null, bool? permiteWallet = null, bool? permiteControleMCC = null, bool? permiteCompraInternacional = null)
        {
            
    
            var localVarPath = "/api/cartoes/controles-configuracoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idCartao != null) localVarQueryParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // query parameter
            if (permiteEcommerce != null) localVarQueryParams.Add("permiteEcommerce", Configuration.ApiClient.ParameterToString(permiteEcommerce)); // query parameter
            if (permiteSaque != null) localVarQueryParams.Add("permiteSaque", Configuration.ApiClient.ParameterToString(permiteSaque)); // query parameter
            if (permiteWallet != null) localVarQueryParams.Add("permiteWallet", Configuration.ApiClient.ParameterToString(permiteWallet)); // query parameter
            if (permiteControleMCC != null) localVarQueryParams.Add("permiteControleMCC", Configuration.ApiClient.ParameterToString(permiteControleMCC)); // query parameter
            if (permiteCompraInternacional != null) localVarQueryParams.Add("permiteCompraInternacional", Configuration.ApiClient.ParameterToString(permiteCompraInternacional)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarConfiguracaoControleCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarConfiguracaoControleCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageConfiguracaoControleCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageConfiguracaoControleCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageConfiguracaoControleCartaoResponse)));
            
        }

        
        /// <summary>
        /// Lista os cart\u00F5es configurados pelo remetente Esse m\u00E9todo permite listar os cart\u00F5es configurados para bloqueios de transa\u00E7\u00E3o na base do remetente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">C\u00F3digo Identificador do cartao na base (id) (optional)</param>
        /// <param name="permiteEcommerce">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es ecommerce (optional)</param>
        /// <param name="permiteSaque">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es de saque (optional)</param>
        /// <param name="permiteWallet">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es por meio wallet (optional)</param>
        /// <param name="permiteControleMCC">Indica se o cart\u00E3o est\u00E1 ativo para controle por grupos de MCCs (optional)</param>
        /// <param name="permiteCompraInternacional">Indica se o cart\u00E3o est\u00E1 habilitado/desabilitado para transa\u00E7\u00F5es internacionais (optional)</param>
        /// <returns>Task of PageConfiguracaoControleCartaoResponse</returns>
        public async System.Threading.Tasks.Task<PageConfiguracaoControleCartaoResponse> ListarConfiguracaoControleCartaoAsync (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, bool? permiteEcommerce = null, bool? permiteSaque = null, bool? permiteWallet = null, bool? permiteControleMCC = null, bool? permiteCompraInternacional = null)
        {
             ApiResponse<PageConfiguracaoControleCartaoResponse> localVarResponse = await ListarConfiguracaoControleCartaoAsyncWithHttpInfo(sort, page, limit, idCartao, permiteEcommerce, permiteSaque, permiteWallet, permiteControleMCC, permiteCompraInternacional);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os cart\u00F5es configurados pelo remetente Esse m\u00E9todo permite listar os cart\u00F5es configurados para bloqueios de transa\u00E7\u00E3o na base do remetente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">C\u00F3digo Identificador do cartao na base (id) (optional)</param>
        /// <param name="permiteEcommerce">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es ecommerce (optional)</param>
        /// <param name="permiteSaque">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es de saque (optional)</param>
        /// <param name="permiteWallet">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es por meio wallet (optional)</param>
        /// <param name="permiteControleMCC">Indica se o cart\u00E3o est\u00E1 ativo para controle por grupos de MCCs (optional)</param>
        /// <param name="permiteCompraInternacional">Indica se o cart\u00E3o est\u00E1 habilitado/desabilitado para transa\u00E7\u00F5es internacionais (optional)</param>
        /// <returns>Task of ApiResponse (PageConfiguracaoControleCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageConfiguracaoControleCartaoResponse>> ListarConfiguracaoControleCartaoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, bool? permiteEcommerce = null, bool? permiteSaque = null, bool? permiteWallet = null, bool? permiteControleMCC = null, bool? permiteCompraInternacional = null)
        {
            
    
            var localVarPath = "/api/cartoes/controles-configuracoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idCartao != null) localVarQueryParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // query parameter
            if (permiteEcommerce != null) localVarQueryParams.Add("permiteEcommerce", Configuration.ApiClient.ParameterToString(permiteEcommerce)); // query parameter
            if (permiteSaque != null) localVarQueryParams.Add("permiteSaque", Configuration.ApiClient.ParameterToString(permiteSaque)); // query parameter
            if (permiteWallet != null) localVarQueryParams.Add("permiteWallet", Configuration.ApiClient.ParameterToString(permiteWallet)); // query parameter
            if (permiteControleMCC != null) localVarQueryParams.Add("permiteControleMCC", Configuration.ApiClient.ParameterToString(permiteControleMCC)); // query parameter
            if (permiteCompraInternacional != null) localVarQueryParams.Add("permiteCompraInternacional", Configuration.ApiClient.ParameterToString(permiteCompraInternacional)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarConfiguracaoControleCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarConfiguracaoControleCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageConfiguracaoControleCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageConfiguracaoControleCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageConfiguracaoControleCartaoResponse)));
            
        }
        
        /// <summary>
        /// Lista os cart\u00F5es vinculados aos estabelecimentos. Esse m\u00E9todo permite listar os cart\u00F5es registrados respectivamente para grupos MCC.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idCartao">C\u00F3digo Identificador do cartao na base (id) (optional)</param> 
        /// <param name="idGrupoMCC">C\u00F3digo Identificador do grupo mcc na base. (optional)</param> 
        /// <returns>PageControleCartaoGrupoMCCResponse</returns>
        public PageControleCartaoGrupoMCCResponse ListarControleGrupoMCCPorCartao (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, long? idGrupoMCC = null)
        {
             ApiResponse<PageControleCartaoGrupoMCCResponse> localVarResponse = ListarControleGrupoMCCPorCartaoWithHttpInfo(sort, page, limit, idCartao, idGrupoMCC);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os cart\u00F5es vinculados aos estabelecimentos. Esse m\u00E9todo permite listar os cart\u00F5es registrados respectivamente para grupos MCC.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idCartao">C\u00F3digo Identificador do cartao na base (id) (optional)</param> 
        /// <param name="idGrupoMCC">C\u00F3digo Identificador do grupo mcc na base. (optional)</param> 
        /// <returns>ApiResponse of PageControleCartaoGrupoMCCResponse</returns>
        public ApiResponse< PageControleCartaoGrupoMCCResponse > ListarControleGrupoMCCPorCartaoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, long? idGrupoMCC = null)
        {
            
    
            var localVarPath = "/api/cartoes/controles-grupomcc";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idCartao != null) localVarQueryParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // query parameter
            if (idGrupoMCC != null) localVarQueryParams.Add("idGrupoMCC", Configuration.ApiClient.ParameterToString(idGrupoMCC)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarControleGrupoMCCPorCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarControleGrupoMCCPorCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageControleCartaoGrupoMCCResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageControleCartaoGrupoMCCResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageControleCartaoGrupoMCCResponse)));
            
        }

        
        /// <summary>
        /// Lista os cart\u00F5es vinculados aos estabelecimentos. Esse m\u00E9todo permite listar os cart\u00F5es registrados respectivamente para grupos MCC.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">C\u00F3digo Identificador do cartao na base (id) (optional)</param>
        /// <param name="idGrupoMCC">C\u00F3digo Identificador do grupo mcc na base. (optional)</param>
        /// <returns>Task of PageControleCartaoGrupoMCCResponse</returns>
        public async System.Threading.Tasks.Task<PageControleCartaoGrupoMCCResponse> ListarControleGrupoMCCPorCartaoAsync (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, long? idGrupoMCC = null)
        {
             ApiResponse<PageControleCartaoGrupoMCCResponse> localVarResponse = await ListarControleGrupoMCCPorCartaoAsyncWithHttpInfo(sort, page, limit, idCartao, idGrupoMCC);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os cart\u00F5es vinculados aos estabelecimentos. Esse m\u00E9todo permite listar os cart\u00F5es registrados respectivamente para grupos MCC.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">C\u00F3digo Identificador do cartao na base (id) (optional)</param>
        /// <param name="idGrupoMCC">C\u00F3digo Identificador do grupo mcc na base. (optional)</param>
        /// <returns>Task of ApiResponse (PageControleCartaoGrupoMCCResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageControleCartaoGrupoMCCResponse>> ListarControleGrupoMCCPorCartaoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, long? idGrupoMCC = null)
        {
            
    
            var localVarPath = "/api/cartoes/controles-grupomcc";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idCartao != null) localVarQueryParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // query parameter
            if (idGrupoMCC != null) localVarQueryParams.Add("idGrupoMCC", Configuration.ApiClient.ParameterToString(idGrupoMCC)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarControleGrupoMCCPorCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarControleGrupoMCCPorCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageControleCartaoGrupoMCCResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageControleCartaoGrupoMCCResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageControleCartaoGrupoMCCResponse)));
            
        }
        
        /// <summary>
        /// Lista o controle de limites dos cart\u00F5es Este recurso permite que sejam listados todos os controles de limites por cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idCartao">Id do cart\u00E3o (optional)</param> 
        /// <returns>PageControleLimiteCartaoResponse</returns>
        public PageControleLimiteCartaoResponse ListarControlesDeLimites (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null)
        {
             ApiResponse<PageControleLimiteCartaoResponse> localVarResponse = ListarControlesDeLimitesWithHttpInfo(sort, page, limit, idCartao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista o controle de limites dos cart\u00F5es Este recurso permite que sejam listados todos os controles de limites por cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idCartao">Id do cart\u00E3o (optional)</param> 
        /// <returns>ApiResponse of PageControleLimiteCartaoResponse</returns>
        public ApiResponse< PageControleLimiteCartaoResponse > ListarControlesDeLimitesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null)
        {
            
    
            var localVarPath = "/api/cartoes/controles-limites";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idCartao != null) localVarQueryParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarControlesDeLimites: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarControlesDeLimites: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageControleLimiteCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageControleLimiteCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageControleLimiteCartaoResponse)));
            
        }

        
        /// <summary>
        /// Lista o controle de limites dos cart\u00F5es Este recurso permite que sejam listados todos os controles de limites por cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">Id do cart\u00E3o (optional)</param>
        /// <returns>Task of PageControleLimiteCartaoResponse</returns>
        public async System.Threading.Tasks.Task<PageControleLimiteCartaoResponse> ListarControlesDeLimitesAsync (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null)
        {
             ApiResponse<PageControleLimiteCartaoResponse> localVarResponse = await ListarControlesDeLimitesAsyncWithHttpInfo(sort, page, limit, idCartao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista o controle de limites dos cart\u00F5es Este recurso permite que sejam listados todos os controles de limites por cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">Id do cart\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (PageControleLimiteCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageControleLimiteCartaoResponse>> ListarControlesDeLimitesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null)
        {
            
    
            var localVarPath = "/api/cartoes/controles-limites";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idCartao != null) localVarQueryParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarControlesDeLimites: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarControlesDeLimites: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageControleLimiteCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageControleLimiteCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageControleLimiteCartaoResponse)));
            
        }
        
        /// <summary>
        /// Registra a configura\u00E7\u00E3o do cart\u00E3o. O m\u00E9todo registra a configura\u00E7\u00E3o do bloqueio ou n\u00E3o algum tipo de transa\u00E7\u00E3o de uma determinada carta portadora.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="configuracaoControleCartaoPersist">configuracaoControleCartaoPersist</param> 
        /// <returns>ConfiguracaoControleCartaoResponse</returns>
        public ConfiguracaoControleCartaoResponse SalvarConfiguracaoControleCartao (long? id, ConfiguracaoControleCartaoPersist configuracaoControleCartaoPersist)
        {
             ApiResponse<ConfiguracaoControleCartaoResponse> localVarResponse = SalvarConfiguracaoControleCartaoWithHttpInfo(id, configuracaoControleCartaoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Registra a configura\u00E7\u00E3o do cart\u00E3o. O m\u00E9todo registra a configura\u00E7\u00E3o do bloqueio ou n\u00E3o algum tipo de transa\u00E7\u00E3o de uma determinada carta portadora.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="configuracaoControleCartaoPersist">configuracaoControleCartaoPersist</param> 
        /// <returns>ApiResponse of ConfiguracaoControleCartaoResponse</returns>
        public ApiResponse< ConfiguracaoControleCartaoResponse > SalvarConfiguracaoControleCartaoWithHttpInfo (long? id, ConfiguracaoControleCartaoPersist configuracaoControleCartaoPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ControleCartaoApi->SalvarConfiguracaoControleCartao");
            
            // verify the required parameter 'configuracaoControleCartaoPersist' is set
            if (configuracaoControleCartaoPersist == null)
                throw new ApiException(400, "Missing required parameter 'configuracaoControleCartaoPersist' when calling ControleCartaoApi->SalvarConfiguracaoControleCartao");
            
    
            var localVarPath = "/api/cartoes/{id}/controles-configuracoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (configuracaoControleCartaoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(configuracaoControleCartaoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = configuracaoControleCartaoPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarConfiguracaoControleCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarConfiguracaoControleCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConfiguracaoControleCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoControleCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoControleCartaoResponse)));
            
        }

        
        /// <summary>
        /// Registra a configura\u00E7\u00E3o do cart\u00E3o. O m\u00E9todo registra a configura\u00E7\u00E3o do bloqueio ou n\u00E3o algum tipo de transa\u00E7\u00E3o de uma determinada carta portadora.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="configuracaoControleCartaoPersist">configuracaoControleCartaoPersist</param>
        /// <returns>Task of ConfiguracaoControleCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoControleCartaoResponse> SalvarConfiguracaoControleCartaoAsync (long? id, ConfiguracaoControleCartaoPersist configuracaoControleCartaoPersist)
        {
             ApiResponse<ConfiguracaoControleCartaoResponse> localVarResponse = await SalvarConfiguracaoControleCartaoAsyncWithHttpInfo(id, configuracaoControleCartaoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Registra a configura\u00E7\u00E3o do cart\u00E3o. O m\u00E9todo registra a configura\u00E7\u00E3o do bloqueio ou n\u00E3o algum tipo de transa\u00E7\u00E3o de uma determinada carta portadora.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="configuracaoControleCartaoPersist">configuracaoControleCartaoPersist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoControleCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfiguracaoControleCartaoResponse>> SalvarConfiguracaoControleCartaoAsyncWithHttpInfo (long? id, ConfiguracaoControleCartaoPersist configuracaoControleCartaoPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SalvarConfiguracaoControleCartao");
            // verify the required parameter 'configuracaoControleCartaoPersist' is set
            if (configuracaoControleCartaoPersist == null) throw new ApiException(400, "Missing required parameter 'configuracaoControleCartaoPersist' when calling SalvarConfiguracaoControleCartao");
            
    
            var localVarPath = "/api/cartoes/{id}/controles-configuracoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (configuracaoControleCartaoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(configuracaoControleCartaoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = configuracaoControleCartaoPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarConfiguracaoControleCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarConfiguracaoControleCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfiguracaoControleCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoControleCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoControleCartaoResponse)));
            
        }
        
        /// <summary>
        /// Cadastra um controle de limites para um cart\u00E3o Este recurso permite que seja cadastrado um controle de limites para um cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param> 
        /// <param name="controleLimitesCartaoPersist">controleLimitesCartaoPersist</param> 
        /// <returns>ControleLimiteCartaoResponse</returns>
        public ControleLimiteCartaoResponse SalvarControleDeLimite (long? id, ControleLimitesCartaoPersist controleLimitesCartaoPersist)
        {
             ApiResponse<ControleLimiteCartaoResponse> localVarResponse = SalvarControleDeLimiteWithHttpInfo(id, controleLimitesCartaoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastra um controle de limites para um cart\u00E3o Este recurso permite que seja cadastrado um controle de limites para um cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param> 
        /// <param name="controleLimitesCartaoPersist">controleLimitesCartaoPersist</param> 
        /// <returns>ApiResponse of ControleLimiteCartaoResponse</returns>
        public ApiResponse< ControleLimiteCartaoResponse > SalvarControleDeLimiteWithHttpInfo (long? id, ControleLimitesCartaoPersist controleLimitesCartaoPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ControleCartaoApi->SalvarControleDeLimite");
            
            // verify the required parameter 'controleLimitesCartaoPersist' is set
            if (controleLimitesCartaoPersist == null)
                throw new ApiException(400, "Missing required parameter 'controleLimitesCartaoPersist' when calling ControleCartaoApi->SalvarControleDeLimite");
            
    
            var localVarPath = "/api/cartoes/{id}/controles-limites";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (controleLimitesCartaoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(controleLimitesCartaoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = controleLimitesCartaoPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarControleDeLimite: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarControleDeLimite: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ControleLimiteCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleLimiteCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleLimiteCartaoResponse)));
            
        }

        
        /// <summary>
        /// Cadastra um controle de limites para um cart\u00E3o Este recurso permite que seja cadastrado um controle de limites para um cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="controleLimitesCartaoPersist">controleLimitesCartaoPersist</param>
        /// <returns>Task of ControleLimiteCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ControleLimiteCartaoResponse> SalvarControleDeLimiteAsync (long? id, ControleLimitesCartaoPersist controleLimitesCartaoPersist)
        {
             ApiResponse<ControleLimiteCartaoResponse> localVarResponse = await SalvarControleDeLimiteAsyncWithHttpInfo(id, controleLimitesCartaoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastra um controle de limites para um cart\u00E3o Este recurso permite que seja cadastrado um controle de limites para um cart\u00E3o, o controle de limites tem por finalidade gerenciar a utiliza\u00E7\u00E3o do limite dipon\u00EDvel global da conta, limitando o gasto di\u00E1rio, semanal ou mensal, por cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</param>
        /// <param name="controleLimitesCartaoPersist">controleLimitesCartaoPersist</param>
        /// <returns>Task of ApiResponse (ControleLimiteCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ControleLimiteCartaoResponse>> SalvarControleDeLimiteAsyncWithHttpInfo (long? id, ControleLimitesCartaoPersist controleLimitesCartaoPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SalvarControleDeLimite");
            // verify the required parameter 'controleLimitesCartaoPersist' is set
            if (controleLimitesCartaoPersist == null) throw new ApiException(400, "Missing required parameter 'controleLimitesCartaoPersist' when calling SalvarControleDeLimite");
            
    
            var localVarPath = "/api/cartoes/{id}/controles-limites";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (controleLimitesCartaoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(controleLimitesCartaoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = controleLimitesCartaoPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarControleDeLimite: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarControleDeLimite: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ControleLimiteCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleLimiteCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleLimiteCartaoResponse)));
            
        }
        
        /// <summary>
        /// Registra o grupo mcc ao cart\u00E3o. Cria o vinculo de grupo mcc com o cart\u00E3o para controle transa\u00E7\u00F5es por grupo de mcc.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="controleCartaoMCCPersist">controleCartaoMCCPersist</param> 
        /// <returns>ControleCartaoGrupoMCCResponse</returns>
        public ControleCartaoGrupoMCCResponse SalvarControleGrupoMCCPorCartao (long? id, ControleCartaoGrupoMCCPersist controleCartaoMCCPersist)
        {
             ApiResponse<ControleCartaoGrupoMCCResponse> localVarResponse = SalvarControleGrupoMCCPorCartaoWithHttpInfo(id, controleCartaoMCCPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Registra o grupo mcc ao cart\u00E3o. Cria o vinculo de grupo mcc com o cart\u00E3o para controle transa\u00E7\u00F5es por grupo de mcc.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="controleCartaoMCCPersist">controleCartaoMCCPersist</param> 
        /// <returns>ApiResponse of ControleCartaoGrupoMCCResponse</returns>
        public ApiResponse< ControleCartaoGrupoMCCResponse > SalvarControleGrupoMCCPorCartaoWithHttpInfo (long? id, ControleCartaoGrupoMCCPersist controleCartaoMCCPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ControleCartaoApi->SalvarControleGrupoMCCPorCartao");
            
            // verify the required parameter 'controleCartaoMCCPersist' is set
            if (controleCartaoMCCPersist == null)
                throw new ApiException(400, "Missing required parameter 'controleCartaoMCCPersist' when calling ControleCartaoApi->SalvarControleGrupoMCCPorCartao");
            
    
            var localVarPath = "/api/cartoes/{id}/controles-grupomcc";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (controleCartaoMCCPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(controleCartaoMCCPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = controleCartaoMCCPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarControleGrupoMCCPorCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarControleGrupoMCCPorCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ControleCartaoGrupoMCCResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleCartaoGrupoMCCResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleCartaoGrupoMCCResponse)));
            
        }

        
        /// <summary>
        /// Registra o grupo mcc ao cart\u00E3o. Cria o vinculo de grupo mcc com o cart\u00E3o para controle transa\u00E7\u00F5es por grupo de mcc.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="controleCartaoMCCPersist">controleCartaoMCCPersist</param>
        /// <returns>Task of ControleCartaoGrupoMCCResponse</returns>
        public async System.Threading.Tasks.Task<ControleCartaoGrupoMCCResponse> SalvarControleGrupoMCCPorCartaoAsync (long? id, ControleCartaoGrupoMCCPersist controleCartaoMCCPersist)
        {
             ApiResponse<ControleCartaoGrupoMCCResponse> localVarResponse = await SalvarControleGrupoMCCPorCartaoAsyncWithHttpInfo(id, controleCartaoMCCPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Registra o grupo mcc ao cart\u00E3o. Cria o vinculo de grupo mcc com o cart\u00E3o para controle transa\u00E7\u00F5es por grupo de mcc.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="controleCartaoMCCPersist">controleCartaoMCCPersist</param>
        /// <returns>Task of ApiResponse (ControleCartaoGrupoMCCResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ControleCartaoGrupoMCCResponse>> SalvarControleGrupoMCCPorCartaoAsyncWithHttpInfo (long? id, ControleCartaoGrupoMCCPersist controleCartaoMCCPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SalvarControleGrupoMCCPorCartao");
            // verify the required parameter 'controleCartaoMCCPersist' is set
            if (controleCartaoMCCPersist == null) throw new ApiException(400, "Missing required parameter 'controleCartaoMCCPersist' when calling SalvarControleGrupoMCCPorCartao");
            
    
            var localVarPath = "/api/cartoes/{id}/controles-grupomcc";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (controleCartaoMCCPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(controleCartaoMCCPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = controleCartaoMCCPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarControleGrupoMCCPorCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarControleGrupoMCCPorCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ControleCartaoGrupoMCCResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleCartaoGrupoMCCResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleCartaoGrupoMCCResponse)));
            
        }
        
    }
    
}
