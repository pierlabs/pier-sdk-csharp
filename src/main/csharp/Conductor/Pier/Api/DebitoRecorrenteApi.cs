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
    public interface IDebitoRecorrenteApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Aderir ao d\u00E9bito recorrente
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que um determinado tipo d\u00E9bito recorrente seja adicionado a uma determinada conta, para que o mesmo passe a ser cobrado na fatura do cliente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>ContaDebitoRecorrenteResponse</returns>
        ContaDebitoRecorrenteResponse AderirDebitoRecorrente (ContaDebitoRecorrente contaDebitoRecorrentePersist);
  
        /// <summary>
        /// Aderir ao d\u00E9bito recorrente
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que um determinado tipo d\u00E9bito recorrente seja adicionado a uma determinada conta, para que o mesmo passe a ser cobrado na fatura do cliente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>ApiResponse of ContaDebitoRecorrenteResponse</returns>
        ApiResponse<ContaDebitoRecorrenteResponse> AderirDebitoRecorrenteWithHttpInfo (ContaDebitoRecorrente contaDebitoRecorrentePersist);
        
        /// <summary>
        /// Atualiza parcialmente um d\u00E9bito recorrente por portador de uma determinada conta
        /// </summary>
        /// <remarks>
        /// Este recurso permite atualizar parcialmente um d\u00E9bito recorrente por portador de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador da conta</param>
        /// <param name="idRegistro">C\u00F3digo identificador do registro</param>
        /// <param name="portadorDebitoRecorrenteUpdate">portadorDebitoRecorrenteUpdate</param>
        /// <returns>PortadorDebitoRecorrenteResponse</returns>
        PortadorDebitoRecorrenteResponse AtualizarParcialPortadorDebitoRecorrente (long? id, long? idRegistro, PortadorDebitoRecorrenteUpdate portadorDebitoRecorrenteUpdate);
  
        /// <summary>
        /// Atualiza parcialmente um d\u00E9bito recorrente por portador de uma determinada conta
        /// </summary>
        /// <remarks>
        /// Este recurso permite atualizar parcialmente um d\u00E9bito recorrente por portador de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador da conta</param>
        /// <param name="idRegistro">C\u00F3digo identificador do registro</param>
        /// <param name="portadorDebitoRecorrenteUpdate">portadorDebitoRecorrenteUpdate</param>
        /// <returns>ApiResponse of PortadorDebitoRecorrenteResponse</returns>
        ApiResponse<PortadorDebitoRecorrenteResponse> AtualizarParcialPortadorDebitoRecorrenteWithHttpInfo (long? id, long? idRegistro, PortadorDebitoRecorrenteUpdate portadorDebitoRecorrenteUpdate);
        
        /// <summary>
        /// Cancelar o d\u00E9bito recorrente
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite cancelar um tipo d\u00E9bito recorrente de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do d\u00E9bito recorrente (id)</param>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>ContaDebitoRecorrenteResponse</returns>
        ContaDebitoRecorrenteResponse CancelarDebitoRecorrente (long? id, ContaDebitoRecorrente contaDebitoRecorrentePersist);
  
        /// <summary>
        /// Cancelar o d\u00E9bito recorrente
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite cancelar um tipo d\u00E9bito recorrente de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do d\u00E9bito recorrente (id)</param>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>ApiResponse of ContaDebitoRecorrenteResponse</returns>
        ApiResponse<ContaDebitoRecorrenteResponse> CancelarDebitoRecorrenteWithHttpInfo (long? id, ContaDebitoRecorrente contaDebitoRecorrentePersist);
        
        /// <summary>
        /// Lista os d\u00E9bitos recorrentes de uma Conta
        /// </summary>
        /// <remarks>
        /// A entidade D\u00E9bito Recorrente trata dos registros contratados por um determinado cliente (idConta) onde a cobran\u00E7a dele se d\u00E1 de forma cont\u00EDnua, consistindo em uma assinatura ou pagamento de mensalidades. Isso significa que, enquanto o servi\u00E7o continuar a ser prestado, o cliente dever\u00E1 continuar realizando os pagamentos.  A determina\u00E7\u00E3o de quanto tempo essa rela\u00E7\u00E3o ir\u00E1 durar \u00E9 feita em contrato. Na maioria das vezes, existe um per\u00EDodo m\u00EDnimo e, caso o servi\u00E7o seja cancelado ou o pagamento n\u00E3o seja realizado,  o status do D\u00E9bito Recorrente ter\u00E1 a FlagAtivo com valor false. Assim, este m\u00E9todo lista todas as opera\u00E7\u00F5es de D\u00E9bitos Recorrentes que um determinado idConta j\u00E1 contratou, esteja ele ativo ou n\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta (id) (optional)</param>
        /// <param name="idTipoDebitoRecorrente">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id) (optional)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataHoraInicio">Data e hora inicio do d\u00E9bito recorrente yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <param name="dataHoraFim">Data e hora fim do d\u00E9bito recorrente yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <param name="ativo">Identifica se o d\u00E9bito recorrente est\u00E1 ativo (optional)</param>
        /// <param name="dataHoraUltimoPagamento">Data e hora do \u00FAltimo pagamento efetuado yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <returns>PageContaDebitoRecorrenteResponse</returns>
        PageContaDebitoRecorrenteResponse Listar (long? idConta = null, long? idTipoDebitoRecorrente = null, List<string> sort = null, int? page = null, int? limit = null, string dataHoraInicio = null, string dataHoraFim = null, bool? ativo = null, string dataHoraUltimoPagamento = null);
  
        /// <summary>
        /// Lista os d\u00E9bitos recorrentes de uma Conta
        /// </summary>
        /// <remarks>
        /// A entidade D\u00E9bito Recorrente trata dos registros contratados por um determinado cliente (idConta) onde a cobran\u00E7a dele se d\u00E1 de forma cont\u00EDnua, consistindo em uma assinatura ou pagamento de mensalidades. Isso significa que, enquanto o servi\u00E7o continuar a ser prestado, o cliente dever\u00E1 continuar realizando os pagamentos.  A determina\u00E7\u00E3o de quanto tempo essa rela\u00E7\u00E3o ir\u00E1 durar \u00E9 feita em contrato. Na maioria das vezes, existe um per\u00EDodo m\u00EDnimo e, caso o servi\u00E7o seja cancelado ou o pagamento n\u00E3o seja realizado,  o status do D\u00E9bito Recorrente ter\u00E1 a FlagAtivo com valor false. Assim, este m\u00E9todo lista todas as opera\u00E7\u00F5es de D\u00E9bitos Recorrentes que um determinado idConta j\u00E1 contratou, esteja ele ativo ou n\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta (id) (optional)</param>
        /// <param name="idTipoDebitoRecorrente">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id) (optional)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataHoraInicio">Data e hora inicio do d\u00E9bito recorrente yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <param name="dataHoraFim">Data e hora fim do d\u00E9bito recorrente yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <param name="ativo">Identifica se o d\u00E9bito recorrente est\u00E1 ativo (optional)</param>
        /// <param name="dataHoraUltimoPagamento">Data e hora do \u00FAltimo pagamento efetuado yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <returns>ApiResponse of PageContaDebitoRecorrenteResponse</returns>
        ApiResponse<PageContaDebitoRecorrenteResponse> ListarWithHttpInfo (long? idConta = null, long? idTipoDebitoRecorrente = null, List<string> sort = null, int? page = null, int? limit = null, string dataHoraInicio = null, string dataHoraFim = null, bool? ativo = null, string dataHoraUltimoPagamento = null);
        
        /// <summary>
        /// Lista os d\u00E9bitos recorrentes por portador de uma determinada conta
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar os d\u00E9bitos recorrentes por portador de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador da conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PagePortadorDebitoRecorrenteResponse</returns>
        PagePortadorDebitoRecorrenteResponse ListarPortadorDebitoRecorrente (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista os d\u00E9bitos recorrentes por portador de uma determinada conta
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar os d\u00E9bitos recorrentes por portador de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador da conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PagePortadorDebitoRecorrenteResponse</returns>
        ApiResponse<PagePortadorDebitoRecorrenteResponse> ListarPortadorDebitoRecorrenteWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar Tipos Debitos Recorrentes
        /// </summary>
        /// <remarks>
        /// Para os emissores que utilizam a entidade Debitos Recorrentes precisam previamente solicitar a Conductor o cadastro de quais Tipos eles poder\u00E3o comercializar. Por isso, este recurso tem como objetivo apresentar todos os Tipos de D\u00E9bitos Recorrentes que est\u00E3o cadastrados para um determinado Emissor, independente do status dele
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de d\u00E9bito recorrente (optional)</param>
        /// <param name="valor">Valor do tipo de d\u00E9bito recorrente (optional)</param>
        /// <param name="flagAtivo">Flag que identifica se o tipo d\u00E9bito recorrente est\u00E1 ativo (optional)</param>
        /// <returns>PageTipoDebitoRecorrenteResponse</returns>
        PageTipoDebitoRecorrenteResponse Listar_0 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, double? valor = null, bool? flagAtivo = null);
  
        /// <summary>
        /// Listar Tipos Debitos Recorrentes
        /// </summary>
        /// <remarks>
        /// Para os emissores que utilizam a entidade Debitos Recorrentes precisam previamente solicitar a Conductor o cadastro de quais Tipos eles poder\u00E3o comercializar. Por isso, este recurso tem como objetivo apresentar todos os Tipos de D\u00E9bitos Recorrentes que est\u00E3o cadastrados para um determinado Emissor, independente do status dele
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de d\u00E9bito recorrente (optional)</param>
        /// <param name="valor">Valor do tipo de d\u00E9bito recorrente (optional)</param>
        /// <param name="flagAtivo">Flag que identifica se o tipo d\u00E9bito recorrente est\u00E1 ativo (optional)</param>
        /// <returns>ApiResponse of PageTipoDebitoRecorrenteResponse</returns>
        ApiResponse<PageTipoDebitoRecorrenteResponse> Listar_0WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, double? valor = null, bool? flagAtivo = null);
        
        /// <summary>
        /// Salva os d\u00E9bitos recorrentes por portador de uma determinada conta
        /// </summary>
        /// <remarks>
        /// Este recurso permite salvar os d\u00E9bitos recorrentes por portador de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador da conta</param>
        /// <param name="portadorDebitoRecorrentePersist">portadorDebitoRecorrentePersist</param>
        /// <returns>PortadorDebitoRecorrenteResponse</returns>
        PortadorDebitoRecorrenteResponse SalvarPortadorDebitoRecorrente (long? id, PortadorDebitoRecorrentePersist portadorDebitoRecorrentePersist);
  
        /// <summary>
        /// Salva os d\u00E9bitos recorrentes por portador de uma determinada conta
        /// </summary>
        /// <remarks>
        /// Este recurso permite salvar os d\u00E9bitos recorrentes por portador de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador da conta</param>
        /// <param name="portadorDebitoRecorrentePersist">portadorDebitoRecorrentePersist</param>
        /// <returns>ApiResponse of PortadorDebitoRecorrenteResponse</returns>
        ApiResponse<PortadorDebitoRecorrenteResponse> SalvarPortadorDebitoRecorrenteWithHttpInfo (long? id, PortadorDebitoRecorrentePersist portadorDebitoRecorrentePersist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Aderir ao d\u00E9bito recorrente
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que um determinado tipo d\u00E9bito recorrente seja adicionado a uma determinada conta, para que o mesmo passe a ser cobrado na fatura do cliente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>Task of ContaDebitoRecorrenteResponse</returns>
        System.Threading.Tasks.Task<ContaDebitoRecorrenteResponse> AderirDebitoRecorrenteAsync (ContaDebitoRecorrente contaDebitoRecorrentePersist);

        /// <summary>
        /// Aderir ao d\u00E9bito recorrente
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que um determinado tipo d\u00E9bito recorrente seja adicionado a uma determinada conta, para que o mesmo passe a ser cobrado na fatura do cliente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>Task of ApiResponse (ContaDebitoRecorrenteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaDebitoRecorrenteResponse>> AderirDebitoRecorrenteAsyncWithHttpInfo (ContaDebitoRecorrente contaDebitoRecorrentePersist);
        
        /// <summary>
        /// Atualiza parcialmente um d\u00E9bito recorrente por portador de uma determinada conta
        /// </summary>
        /// <remarks>
        /// Este recurso permite atualizar parcialmente um d\u00E9bito recorrente por portador de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador da conta</param>
        /// <param name="idRegistro">C\u00F3digo identificador do registro</param>
        /// <param name="portadorDebitoRecorrenteUpdate">portadorDebitoRecorrenteUpdate</param>
        /// <returns>Task of PortadorDebitoRecorrenteResponse</returns>
        System.Threading.Tasks.Task<PortadorDebitoRecorrenteResponse> AtualizarParcialPortadorDebitoRecorrenteAsync (long? id, long? idRegistro, PortadorDebitoRecorrenteUpdate portadorDebitoRecorrenteUpdate);

        /// <summary>
        /// Atualiza parcialmente um d\u00E9bito recorrente por portador de uma determinada conta
        /// </summary>
        /// <remarks>
        /// Este recurso permite atualizar parcialmente um d\u00E9bito recorrente por portador de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador da conta</param>
        /// <param name="idRegistro">C\u00F3digo identificador do registro</param>
        /// <param name="portadorDebitoRecorrenteUpdate">portadorDebitoRecorrenteUpdate</param>
        /// <returns>Task of ApiResponse (PortadorDebitoRecorrenteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortadorDebitoRecorrenteResponse>> AtualizarParcialPortadorDebitoRecorrenteAsyncWithHttpInfo (long? id, long? idRegistro, PortadorDebitoRecorrenteUpdate portadorDebitoRecorrenteUpdate);
        
        /// <summary>
        /// Cancelar o d\u00E9bito recorrente
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite cancelar um tipo d\u00E9bito recorrente de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do d\u00E9bito recorrente (id)</param>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>Task of ContaDebitoRecorrenteResponse</returns>
        System.Threading.Tasks.Task<ContaDebitoRecorrenteResponse> CancelarDebitoRecorrenteAsync (long? id, ContaDebitoRecorrente contaDebitoRecorrentePersist);

        /// <summary>
        /// Cancelar o d\u00E9bito recorrente
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite cancelar um tipo d\u00E9bito recorrente de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do d\u00E9bito recorrente (id)</param>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>Task of ApiResponse (ContaDebitoRecorrenteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaDebitoRecorrenteResponse>> CancelarDebitoRecorrenteAsyncWithHttpInfo (long? id, ContaDebitoRecorrente contaDebitoRecorrentePersist);
        
        /// <summary>
        /// Lista os d\u00E9bitos recorrentes de uma Conta
        /// </summary>
        /// <remarks>
        /// A entidade D\u00E9bito Recorrente trata dos registros contratados por um determinado cliente (idConta) onde a cobran\u00E7a dele se d\u00E1 de forma cont\u00EDnua, consistindo em uma assinatura ou pagamento de mensalidades. Isso significa que, enquanto o servi\u00E7o continuar a ser prestado, o cliente dever\u00E1 continuar realizando os pagamentos.  A determina\u00E7\u00E3o de quanto tempo essa rela\u00E7\u00E3o ir\u00E1 durar \u00E9 feita em contrato. Na maioria das vezes, existe um per\u00EDodo m\u00EDnimo e, caso o servi\u00E7o seja cancelado ou o pagamento n\u00E3o seja realizado,  o status do D\u00E9bito Recorrente ter\u00E1 a FlagAtivo com valor false. Assim, este m\u00E9todo lista todas as opera\u00E7\u00F5es de D\u00E9bitos Recorrentes que um determinado idConta j\u00E1 contratou, esteja ele ativo ou n\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta (id) (optional)</param>
        /// <param name="idTipoDebitoRecorrente">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id) (optional)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataHoraInicio">Data e hora inicio do d\u00E9bito recorrente yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <param name="dataHoraFim">Data e hora fim do d\u00E9bito recorrente yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <param name="ativo">Identifica se o d\u00E9bito recorrente est\u00E1 ativo (optional)</param>
        /// <param name="dataHoraUltimoPagamento">Data e hora do \u00FAltimo pagamento efetuado yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <returns>Task of PageContaDebitoRecorrenteResponse</returns>
        System.Threading.Tasks.Task<PageContaDebitoRecorrenteResponse> ListarAsync (long? idConta = null, long? idTipoDebitoRecorrente = null, List<string> sort = null, int? page = null, int? limit = null, string dataHoraInicio = null, string dataHoraFim = null, bool? ativo = null, string dataHoraUltimoPagamento = null);

        /// <summary>
        /// Lista os d\u00E9bitos recorrentes de uma Conta
        /// </summary>
        /// <remarks>
        /// A entidade D\u00E9bito Recorrente trata dos registros contratados por um determinado cliente (idConta) onde a cobran\u00E7a dele se d\u00E1 de forma cont\u00EDnua, consistindo em uma assinatura ou pagamento de mensalidades. Isso significa que, enquanto o servi\u00E7o continuar a ser prestado, o cliente dever\u00E1 continuar realizando os pagamentos.  A determina\u00E7\u00E3o de quanto tempo essa rela\u00E7\u00E3o ir\u00E1 durar \u00E9 feita em contrato. Na maioria das vezes, existe um per\u00EDodo m\u00EDnimo e, caso o servi\u00E7o seja cancelado ou o pagamento n\u00E3o seja realizado,  o status do D\u00E9bito Recorrente ter\u00E1 a FlagAtivo com valor false. Assim, este m\u00E9todo lista todas as opera\u00E7\u00F5es de D\u00E9bitos Recorrentes que um determinado idConta j\u00E1 contratou, esteja ele ativo ou n\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta (id) (optional)</param>
        /// <param name="idTipoDebitoRecorrente">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id) (optional)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataHoraInicio">Data e hora inicio do d\u00E9bito recorrente yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <param name="dataHoraFim">Data e hora fim do d\u00E9bito recorrente yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <param name="ativo">Identifica se o d\u00E9bito recorrente est\u00E1 ativo (optional)</param>
        /// <param name="dataHoraUltimoPagamento">Data e hora do \u00FAltimo pagamento efetuado yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <returns>Task of ApiResponse (PageContaDebitoRecorrenteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageContaDebitoRecorrenteResponse>> ListarAsyncWithHttpInfo (long? idConta = null, long? idTipoDebitoRecorrente = null, List<string> sort = null, int? page = null, int? limit = null, string dataHoraInicio = null, string dataHoraFim = null, bool? ativo = null, string dataHoraUltimoPagamento = null);
        
        /// <summary>
        /// Lista os d\u00E9bitos recorrentes por portador de uma determinada conta
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar os d\u00E9bitos recorrentes por portador de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador da conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PagePortadorDebitoRecorrenteResponse</returns>
        System.Threading.Tasks.Task<PagePortadorDebitoRecorrenteResponse> ListarPortadorDebitoRecorrenteAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista os d\u00E9bitos recorrentes por portador de uma determinada conta
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar os d\u00E9bitos recorrentes por portador de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador da conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PagePortadorDebitoRecorrenteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePortadorDebitoRecorrenteResponse>> ListarPortadorDebitoRecorrenteAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar Tipos Debitos Recorrentes
        /// </summary>
        /// <remarks>
        /// Para os emissores que utilizam a entidade Debitos Recorrentes precisam previamente solicitar a Conductor o cadastro de quais Tipos eles poder\u00E3o comercializar. Por isso, este recurso tem como objetivo apresentar todos os Tipos de D\u00E9bitos Recorrentes que est\u00E3o cadastrados para um determinado Emissor, independente do status dele
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de d\u00E9bito recorrente (optional)</param>
        /// <param name="valor">Valor do tipo de d\u00E9bito recorrente (optional)</param>
        /// <param name="flagAtivo">Flag que identifica se o tipo d\u00E9bito recorrente est\u00E1 ativo (optional)</param>
        /// <returns>Task of PageTipoDebitoRecorrenteResponse</returns>
        System.Threading.Tasks.Task<PageTipoDebitoRecorrenteResponse> Listar_0Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, double? valor = null, bool? flagAtivo = null);

        /// <summary>
        /// Listar Tipos Debitos Recorrentes
        /// </summary>
        /// <remarks>
        /// Para os emissores que utilizam a entidade Debitos Recorrentes precisam previamente solicitar a Conductor o cadastro de quais Tipos eles poder\u00E3o comercializar. Por isso, este recurso tem como objetivo apresentar todos os Tipos de D\u00E9bitos Recorrentes que est\u00E3o cadastrados para um determinado Emissor, independente do status dele
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de d\u00E9bito recorrente (optional)</param>
        /// <param name="valor">Valor do tipo de d\u00E9bito recorrente (optional)</param>
        /// <param name="flagAtivo">Flag que identifica se o tipo d\u00E9bito recorrente est\u00E1 ativo (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoDebitoRecorrenteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoDebitoRecorrenteResponse>> Listar_0AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, double? valor = null, bool? flagAtivo = null);
        
        /// <summary>
        /// Salva os d\u00E9bitos recorrentes por portador de uma determinada conta
        /// </summary>
        /// <remarks>
        /// Este recurso permite salvar os d\u00E9bitos recorrentes por portador de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador da conta</param>
        /// <param name="portadorDebitoRecorrentePersist">portadorDebitoRecorrentePersist</param>
        /// <returns>Task of PortadorDebitoRecorrenteResponse</returns>
        System.Threading.Tasks.Task<PortadorDebitoRecorrenteResponse> SalvarPortadorDebitoRecorrenteAsync (long? id, PortadorDebitoRecorrentePersist portadorDebitoRecorrentePersist);

        /// <summary>
        /// Salva os d\u00E9bitos recorrentes por portador de uma determinada conta
        /// </summary>
        /// <remarks>
        /// Este recurso permite salvar os d\u00E9bitos recorrentes por portador de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador da conta</param>
        /// <param name="portadorDebitoRecorrentePersist">portadorDebitoRecorrentePersist</param>
        /// <returns>Task of ApiResponse (PortadorDebitoRecorrenteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortadorDebitoRecorrenteResponse>> SalvarPortadorDebitoRecorrenteAsyncWithHttpInfo (long? id, PortadorDebitoRecorrentePersist portadorDebitoRecorrentePersist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DebitoRecorrenteApi : IDebitoRecorrenteApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DebitoRecorrenteApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DebitoRecorrenteApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DebitoRecorrenteApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DebitoRecorrenteApi(Configuration configuration = null)
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
        /// Aderir ao d\u00E9bito recorrente Este m\u00E9todo permite que um determinado tipo d\u00E9bito recorrente seja adicionado a uma determinada conta, para que o mesmo passe a ser cobrado na fatura do cliente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param> 
        /// <returns>ContaDebitoRecorrenteResponse</returns>
        public ContaDebitoRecorrenteResponse AderirDebitoRecorrente (ContaDebitoRecorrente contaDebitoRecorrentePersist)
        {
             ApiResponse<ContaDebitoRecorrenteResponse> localVarResponse = AderirDebitoRecorrenteWithHttpInfo(contaDebitoRecorrentePersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Aderir ao d\u00E9bito recorrente Este m\u00E9todo permite que um determinado tipo d\u00E9bito recorrente seja adicionado a uma determinada conta, para que o mesmo passe a ser cobrado na fatura do cliente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param> 
        /// <returns>ApiResponse of ContaDebitoRecorrenteResponse</returns>
        public ApiResponse< ContaDebitoRecorrenteResponse > AderirDebitoRecorrenteWithHttpInfo (ContaDebitoRecorrente contaDebitoRecorrentePersist)
        {
            
            // verify the required parameter 'contaDebitoRecorrentePersist' is set
            if (contaDebitoRecorrentePersist == null)
                throw new ApiException(400, "Missing required parameter 'contaDebitoRecorrentePersist' when calling DebitoRecorrenteApi->AderirDebitoRecorrente");
            
    
            var localVarPath = "/api/debitos-recorrentes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (contaDebitoRecorrentePersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contaDebitoRecorrentePersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contaDebitoRecorrentePersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AderirDebitoRecorrente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AderirDebitoRecorrente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaDebitoRecorrenteResponse)));
            
        }

        
        /// <summary>
        /// Aderir ao d\u00E9bito recorrente Este m\u00E9todo permite que um determinado tipo d\u00E9bito recorrente seja adicionado a uma determinada conta, para que o mesmo passe a ser cobrado na fatura do cliente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>Task of ContaDebitoRecorrenteResponse</returns>
        public async System.Threading.Tasks.Task<ContaDebitoRecorrenteResponse> AderirDebitoRecorrenteAsync (ContaDebitoRecorrente contaDebitoRecorrentePersist)
        {
             ApiResponse<ContaDebitoRecorrenteResponse> localVarResponse = await AderirDebitoRecorrenteAsyncWithHttpInfo(contaDebitoRecorrentePersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Aderir ao d\u00E9bito recorrente Este m\u00E9todo permite que um determinado tipo d\u00E9bito recorrente seja adicionado a uma determinada conta, para que o mesmo passe a ser cobrado na fatura do cliente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>Task of ApiResponse (ContaDebitoRecorrenteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaDebitoRecorrenteResponse>> AderirDebitoRecorrenteAsyncWithHttpInfo (ContaDebitoRecorrente contaDebitoRecorrentePersist)
        {
            // verify the required parameter 'contaDebitoRecorrentePersist' is set
            if (contaDebitoRecorrentePersist == null) throw new ApiException(400, "Missing required parameter 'contaDebitoRecorrentePersist' when calling AderirDebitoRecorrente");
            
    
            var localVarPath = "/api/debitos-recorrentes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (contaDebitoRecorrentePersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contaDebitoRecorrentePersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contaDebitoRecorrentePersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AderirDebitoRecorrente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AderirDebitoRecorrente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaDebitoRecorrenteResponse)));
            
        }
        
        /// <summary>
        /// Atualiza parcialmente um d\u00E9bito recorrente por portador de uma determinada conta Este recurso permite atualizar parcialmente um d\u00E9bito recorrente por portador de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador da conta</param> 
        /// <param name="idRegistro">C\u00F3digo identificador do registro</param> 
        /// <param name="portadorDebitoRecorrenteUpdate">portadorDebitoRecorrenteUpdate</param> 
        /// <returns>PortadorDebitoRecorrenteResponse</returns>
        public PortadorDebitoRecorrenteResponse AtualizarParcialPortadorDebitoRecorrente (long? id, long? idRegistro, PortadorDebitoRecorrenteUpdate portadorDebitoRecorrenteUpdate)
        {
             ApiResponse<PortadorDebitoRecorrenteResponse> localVarResponse = AtualizarParcialPortadorDebitoRecorrenteWithHttpInfo(id, idRegistro, portadorDebitoRecorrenteUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualiza parcialmente um d\u00E9bito recorrente por portador de uma determinada conta Este recurso permite atualizar parcialmente um d\u00E9bito recorrente por portador de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador da conta</param> 
        /// <param name="idRegistro">C\u00F3digo identificador do registro</param> 
        /// <param name="portadorDebitoRecorrenteUpdate">portadorDebitoRecorrenteUpdate</param> 
        /// <returns>ApiResponse of PortadorDebitoRecorrenteResponse</returns>
        public ApiResponse< PortadorDebitoRecorrenteResponse > AtualizarParcialPortadorDebitoRecorrenteWithHttpInfo (long? id, long? idRegistro, PortadorDebitoRecorrenteUpdate portadorDebitoRecorrenteUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DebitoRecorrenteApi->AtualizarParcialPortadorDebitoRecorrente");
            
            // verify the required parameter 'idRegistro' is set
            if (idRegistro == null)
                throw new ApiException(400, "Missing required parameter 'idRegistro' when calling DebitoRecorrenteApi->AtualizarParcialPortadorDebitoRecorrente");
            
            // verify the required parameter 'portadorDebitoRecorrenteUpdate' is set
            if (portadorDebitoRecorrenteUpdate == null)
                throw new ApiException(400, "Missing required parameter 'portadorDebitoRecorrenteUpdate' when calling DebitoRecorrenteApi->AtualizarParcialPortadorDebitoRecorrente");
            
    
            var localVarPath = "/api/contas/{id}/portadores/debitos-recorrentes/{idRegistro}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idRegistro != null) localVarPathParams.Add("idRegistro", Configuration.ApiClient.ParameterToString(idRegistro)); // path parameter
            
            
            
            
            if (portadorDebitoRecorrenteUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(portadorDebitoRecorrenteUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = portadorDebitoRecorrenteUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarParcialPortadorDebitoRecorrente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarParcialPortadorDebitoRecorrente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PortadorDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PortadorDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PortadorDebitoRecorrenteResponse)));
            
        }

        
        /// <summary>
        /// Atualiza parcialmente um d\u00E9bito recorrente por portador de uma determinada conta Este recurso permite atualizar parcialmente um d\u00E9bito recorrente por portador de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador da conta</param>
        /// <param name="idRegistro">C\u00F3digo identificador do registro</param>
        /// <param name="portadorDebitoRecorrenteUpdate">portadorDebitoRecorrenteUpdate</param>
        /// <returns>Task of PortadorDebitoRecorrenteResponse</returns>
        public async System.Threading.Tasks.Task<PortadorDebitoRecorrenteResponse> AtualizarParcialPortadorDebitoRecorrenteAsync (long? id, long? idRegistro, PortadorDebitoRecorrenteUpdate portadorDebitoRecorrenteUpdate)
        {
             ApiResponse<PortadorDebitoRecorrenteResponse> localVarResponse = await AtualizarParcialPortadorDebitoRecorrenteAsyncWithHttpInfo(id, idRegistro, portadorDebitoRecorrenteUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualiza parcialmente um d\u00E9bito recorrente por portador de uma determinada conta Este recurso permite atualizar parcialmente um d\u00E9bito recorrente por portador de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador da conta</param>
        /// <param name="idRegistro">C\u00F3digo identificador do registro</param>
        /// <param name="portadorDebitoRecorrenteUpdate">portadorDebitoRecorrenteUpdate</param>
        /// <returns>Task of ApiResponse (PortadorDebitoRecorrenteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PortadorDebitoRecorrenteResponse>> AtualizarParcialPortadorDebitoRecorrenteAsyncWithHttpInfo (long? id, long? idRegistro, PortadorDebitoRecorrenteUpdate portadorDebitoRecorrenteUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarParcialPortadorDebitoRecorrente");
            // verify the required parameter 'idRegistro' is set
            if (idRegistro == null) throw new ApiException(400, "Missing required parameter 'idRegistro' when calling AtualizarParcialPortadorDebitoRecorrente");
            // verify the required parameter 'portadorDebitoRecorrenteUpdate' is set
            if (portadorDebitoRecorrenteUpdate == null) throw new ApiException(400, "Missing required parameter 'portadorDebitoRecorrenteUpdate' when calling AtualizarParcialPortadorDebitoRecorrente");
            
    
            var localVarPath = "/api/contas/{id}/portadores/debitos-recorrentes/{idRegistro}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idRegistro != null) localVarPathParams.Add("idRegistro", Configuration.ApiClient.ParameterToString(idRegistro)); // path parameter
            
            
            
            
            if (portadorDebitoRecorrenteUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(portadorDebitoRecorrenteUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = portadorDebitoRecorrenteUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarParcialPortadorDebitoRecorrente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarParcialPortadorDebitoRecorrente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PortadorDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PortadorDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PortadorDebitoRecorrenteResponse)));
            
        }
        
        /// <summary>
        /// Cancelar o d\u00E9bito recorrente Este m\u00E9todo permite cancelar um tipo d\u00E9bito recorrente de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do d\u00E9bito recorrente (id)</param> 
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param> 
        /// <returns>ContaDebitoRecorrenteResponse</returns>
        public ContaDebitoRecorrenteResponse CancelarDebitoRecorrente (long? id, ContaDebitoRecorrente contaDebitoRecorrentePersist)
        {
             ApiResponse<ContaDebitoRecorrenteResponse> localVarResponse = CancelarDebitoRecorrenteWithHttpInfo(id, contaDebitoRecorrentePersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cancelar o d\u00E9bito recorrente Este m\u00E9todo permite cancelar um tipo d\u00E9bito recorrente de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do d\u00E9bito recorrente (id)</param> 
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param> 
        /// <returns>ApiResponse of ContaDebitoRecorrenteResponse</returns>
        public ApiResponse< ContaDebitoRecorrenteResponse > CancelarDebitoRecorrenteWithHttpInfo (long? id, ContaDebitoRecorrente contaDebitoRecorrentePersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DebitoRecorrenteApi->CancelarDebitoRecorrente");
            
            // verify the required parameter 'contaDebitoRecorrentePersist' is set
            if (contaDebitoRecorrentePersist == null)
                throw new ApiException(400, "Missing required parameter 'contaDebitoRecorrentePersist' when calling DebitoRecorrenteApi->CancelarDebitoRecorrente");
            
    
            var localVarPath = "/api/debitos-recorrentes/{id}/cancelar";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (contaDebitoRecorrentePersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contaDebitoRecorrentePersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contaDebitoRecorrentePersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarDebitoRecorrente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarDebitoRecorrente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaDebitoRecorrenteResponse)));
            
        }

        
        /// <summary>
        /// Cancelar o d\u00E9bito recorrente Este m\u00E9todo permite cancelar um tipo d\u00E9bito recorrente de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do d\u00E9bito recorrente (id)</param>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>Task of ContaDebitoRecorrenteResponse</returns>
        public async System.Threading.Tasks.Task<ContaDebitoRecorrenteResponse> CancelarDebitoRecorrenteAsync (long? id, ContaDebitoRecorrente contaDebitoRecorrentePersist)
        {
             ApiResponse<ContaDebitoRecorrenteResponse> localVarResponse = await CancelarDebitoRecorrenteAsyncWithHttpInfo(id, contaDebitoRecorrentePersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cancelar o d\u00E9bito recorrente Este m\u00E9todo permite cancelar um tipo d\u00E9bito recorrente de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do d\u00E9bito recorrente (id)</param>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>Task of ApiResponse (ContaDebitoRecorrenteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaDebitoRecorrenteResponse>> CancelarDebitoRecorrenteAsyncWithHttpInfo (long? id, ContaDebitoRecorrente contaDebitoRecorrentePersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CancelarDebitoRecorrente");
            // verify the required parameter 'contaDebitoRecorrentePersist' is set
            if (contaDebitoRecorrentePersist == null) throw new ApiException(400, "Missing required parameter 'contaDebitoRecorrentePersist' when calling CancelarDebitoRecorrente");
            
    
            var localVarPath = "/api/debitos-recorrentes/{id}/cancelar";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (contaDebitoRecorrentePersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contaDebitoRecorrentePersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contaDebitoRecorrentePersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarDebitoRecorrente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarDebitoRecorrente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaDebitoRecorrenteResponse)));
            
        }
        
        /// <summary>
        /// Lista os d\u00E9bitos recorrentes de uma Conta A entidade D\u00E9bito Recorrente trata dos registros contratados por um determinado cliente (idConta) onde a cobran\u00E7a dele se d\u00E1 de forma cont\u00EDnua, consistindo em uma assinatura ou pagamento de mensalidades. Isso significa que, enquanto o servi\u00E7o continuar a ser prestado, o cliente dever\u00E1 continuar realizando os pagamentos.  A determina\u00E7\u00E3o de quanto tempo essa rela\u00E7\u00E3o ir\u00E1 durar \u00E9 feita em contrato. Na maioria das vezes, existe um per\u00EDodo m\u00EDnimo e, caso o servi\u00E7o seja cancelado ou o pagamento n\u00E3o seja realizado,  o status do D\u00E9bito Recorrente ter\u00E1 a FlagAtivo com valor false. Assim, este m\u00E9todo lista todas as opera\u00E7\u00F5es de D\u00E9bitos Recorrentes que um determinado idConta j\u00E1 contratou, esteja ele ativo ou n\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta (id) (optional)</param> 
        /// <param name="idTipoDebitoRecorrente">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id) (optional)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="dataHoraInicio">Data e hora inicio do d\u00E9bito recorrente yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param> 
        /// <param name="dataHoraFim">Data e hora fim do d\u00E9bito recorrente yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param> 
        /// <param name="ativo">Identifica se o d\u00E9bito recorrente est\u00E1 ativo (optional)</param> 
        /// <param name="dataHoraUltimoPagamento">Data e hora do \u00FAltimo pagamento efetuado yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param> 
        /// <returns>PageContaDebitoRecorrenteResponse</returns>
        public PageContaDebitoRecorrenteResponse Listar (long? idConta = null, long? idTipoDebitoRecorrente = null, List<string> sort = null, int? page = null, int? limit = null, string dataHoraInicio = null, string dataHoraFim = null, bool? ativo = null, string dataHoraUltimoPagamento = null)
        {
             ApiResponse<PageContaDebitoRecorrenteResponse> localVarResponse = ListarWithHttpInfo(idConta, idTipoDebitoRecorrente, sort, page, limit, dataHoraInicio, dataHoraFim, ativo, dataHoraUltimoPagamento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os d\u00E9bitos recorrentes de uma Conta A entidade D\u00E9bito Recorrente trata dos registros contratados por um determinado cliente (idConta) onde a cobran\u00E7a dele se d\u00E1 de forma cont\u00EDnua, consistindo em uma assinatura ou pagamento de mensalidades. Isso significa que, enquanto o servi\u00E7o continuar a ser prestado, o cliente dever\u00E1 continuar realizando os pagamentos.  A determina\u00E7\u00E3o de quanto tempo essa rela\u00E7\u00E3o ir\u00E1 durar \u00E9 feita em contrato. Na maioria das vezes, existe um per\u00EDodo m\u00EDnimo e, caso o servi\u00E7o seja cancelado ou o pagamento n\u00E3o seja realizado,  o status do D\u00E9bito Recorrente ter\u00E1 a FlagAtivo com valor false. Assim, este m\u00E9todo lista todas as opera\u00E7\u00F5es de D\u00E9bitos Recorrentes que um determinado idConta j\u00E1 contratou, esteja ele ativo ou n\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta (id) (optional)</param> 
        /// <param name="idTipoDebitoRecorrente">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id) (optional)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="dataHoraInicio">Data e hora inicio do d\u00E9bito recorrente yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param> 
        /// <param name="dataHoraFim">Data e hora fim do d\u00E9bito recorrente yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param> 
        /// <param name="ativo">Identifica se o d\u00E9bito recorrente est\u00E1 ativo (optional)</param> 
        /// <param name="dataHoraUltimoPagamento">Data e hora do \u00FAltimo pagamento efetuado yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param> 
        /// <returns>ApiResponse of PageContaDebitoRecorrenteResponse</returns>
        public ApiResponse< PageContaDebitoRecorrenteResponse > ListarWithHttpInfo (long? idConta = null, long? idTipoDebitoRecorrente = null, List<string> sort = null, int? page = null, int? limit = null, string dataHoraInicio = null, string dataHoraFim = null, bool? ativo = null, string dataHoraUltimoPagamento = null)
        {
            
    
            var localVarPath = "/api/debitos-recorrentes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (idTipoDebitoRecorrente != null) localVarQueryParams.Add("idTipoDebitoRecorrente", Configuration.ApiClient.ParameterToString(idTipoDebitoRecorrente)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (dataHoraInicio != null) localVarQueryParams.Add("dataHoraInicio", Configuration.ApiClient.ParameterToString(dataHoraInicio)); // query parameter
            if (dataHoraFim != null) localVarQueryParams.Add("dataHoraFim", Configuration.ApiClient.ParameterToString(dataHoraFim)); // query parameter
            if (ativo != null) localVarQueryParams.Add("ativo", Configuration.ApiClient.ParameterToString(ativo)); // query parameter
            if (dataHoraUltimoPagamento != null) localVarQueryParams.Add("dataHoraUltimoPagamento", Configuration.ApiClient.ParameterToString(dataHoraUltimoPagamento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageContaDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaDebitoRecorrenteResponse)));
            
        }

        
        /// <summary>
        /// Lista os d\u00E9bitos recorrentes de uma Conta A entidade D\u00E9bito Recorrente trata dos registros contratados por um determinado cliente (idConta) onde a cobran\u00E7a dele se d\u00E1 de forma cont\u00EDnua, consistindo em uma assinatura ou pagamento de mensalidades. Isso significa que, enquanto o servi\u00E7o continuar a ser prestado, o cliente dever\u00E1 continuar realizando os pagamentos.  A determina\u00E7\u00E3o de quanto tempo essa rela\u00E7\u00E3o ir\u00E1 durar \u00E9 feita em contrato. Na maioria das vezes, existe um per\u00EDodo m\u00EDnimo e, caso o servi\u00E7o seja cancelado ou o pagamento n\u00E3o seja realizado,  o status do D\u00E9bito Recorrente ter\u00E1 a FlagAtivo com valor false. Assim, este m\u00E9todo lista todas as opera\u00E7\u00F5es de D\u00E9bitos Recorrentes que um determinado idConta j\u00E1 contratou, esteja ele ativo ou n\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta (id) (optional)</param>
        /// <param name="idTipoDebitoRecorrente">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id) (optional)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataHoraInicio">Data e hora inicio do d\u00E9bito recorrente yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <param name="dataHoraFim">Data e hora fim do d\u00E9bito recorrente yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <param name="ativo">Identifica se o d\u00E9bito recorrente est\u00E1 ativo (optional)</param>
        /// <param name="dataHoraUltimoPagamento">Data e hora do \u00FAltimo pagamento efetuado yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <returns>Task of PageContaDebitoRecorrenteResponse</returns>
        public async System.Threading.Tasks.Task<PageContaDebitoRecorrenteResponse> ListarAsync (long? idConta = null, long? idTipoDebitoRecorrente = null, List<string> sort = null, int? page = null, int? limit = null, string dataHoraInicio = null, string dataHoraFim = null, bool? ativo = null, string dataHoraUltimoPagamento = null)
        {
             ApiResponse<PageContaDebitoRecorrenteResponse> localVarResponse = await ListarAsyncWithHttpInfo(idConta, idTipoDebitoRecorrente, sort, page, limit, dataHoraInicio, dataHoraFim, ativo, dataHoraUltimoPagamento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os d\u00E9bitos recorrentes de uma Conta A entidade D\u00E9bito Recorrente trata dos registros contratados por um determinado cliente (idConta) onde a cobran\u00E7a dele se d\u00E1 de forma cont\u00EDnua, consistindo em uma assinatura ou pagamento de mensalidades. Isso significa que, enquanto o servi\u00E7o continuar a ser prestado, o cliente dever\u00E1 continuar realizando os pagamentos.  A determina\u00E7\u00E3o de quanto tempo essa rela\u00E7\u00E3o ir\u00E1 durar \u00E9 feita em contrato. Na maioria das vezes, existe um per\u00EDodo m\u00EDnimo e, caso o servi\u00E7o seja cancelado ou o pagamento n\u00E3o seja realizado,  o status do D\u00E9bito Recorrente ter\u00E1 a FlagAtivo com valor false. Assim, este m\u00E9todo lista todas as opera\u00E7\u00F5es de D\u00E9bitos Recorrentes que um determinado idConta j\u00E1 contratou, esteja ele ativo ou n\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta (id) (optional)</param>
        /// <param name="idTipoDebitoRecorrente">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id) (optional)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataHoraInicio">Data e hora inicio do d\u00E9bito recorrente yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <param name="dataHoraFim">Data e hora fim do d\u00E9bito recorrente yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <param name="ativo">Identifica se o d\u00E9bito recorrente est\u00E1 ativo (optional)</param>
        /// <param name="dataHoraUltimoPagamento">Data e hora do \u00FAltimo pagamento efetuado yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <returns>Task of ApiResponse (PageContaDebitoRecorrenteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageContaDebitoRecorrenteResponse>> ListarAsyncWithHttpInfo (long? idConta = null, long? idTipoDebitoRecorrente = null, List<string> sort = null, int? page = null, int? limit = null, string dataHoraInicio = null, string dataHoraFim = null, bool? ativo = null, string dataHoraUltimoPagamento = null)
        {
            
    
            var localVarPath = "/api/debitos-recorrentes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (idTipoDebitoRecorrente != null) localVarQueryParams.Add("idTipoDebitoRecorrente", Configuration.ApiClient.ParameterToString(idTipoDebitoRecorrente)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (dataHoraInicio != null) localVarQueryParams.Add("dataHoraInicio", Configuration.ApiClient.ParameterToString(dataHoraInicio)); // query parameter
            if (dataHoraFim != null) localVarQueryParams.Add("dataHoraFim", Configuration.ApiClient.ParameterToString(dataHoraFim)); // query parameter
            if (ativo != null) localVarQueryParams.Add("ativo", Configuration.ApiClient.ParameterToString(ativo)); // query parameter
            if (dataHoraUltimoPagamento != null) localVarQueryParams.Add("dataHoraUltimoPagamento", Configuration.ApiClient.ParameterToString(dataHoraUltimoPagamento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageContaDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaDebitoRecorrenteResponse)));
            
        }
        
        /// <summary>
        /// Lista os d\u00E9bitos recorrentes por portador de uma determinada conta Este recurso permite consultar os d\u00E9bitos recorrentes por portador de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador da conta</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PagePortadorDebitoRecorrenteResponse</returns>
        public PagePortadorDebitoRecorrenteResponse ListarPortadorDebitoRecorrente (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PagePortadorDebitoRecorrenteResponse> localVarResponse = ListarPortadorDebitoRecorrenteWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os d\u00E9bitos recorrentes por portador de uma determinada conta Este recurso permite consultar os d\u00E9bitos recorrentes por portador de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador da conta</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PagePortadorDebitoRecorrenteResponse</returns>
        public ApiResponse< PagePortadorDebitoRecorrenteResponse > ListarPortadorDebitoRecorrenteWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DebitoRecorrenteApi->ListarPortadorDebitoRecorrente");
            
    
            var localVarPath = "/api/contas/{id}/portadores/debitos-recorrentes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ListarPortadorDebitoRecorrente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPortadorDebitoRecorrente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePortadorDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePortadorDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePortadorDebitoRecorrenteResponse)));
            
        }

        
        /// <summary>
        /// Lista os d\u00E9bitos recorrentes por portador de uma determinada conta Este recurso permite consultar os d\u00E9bitos recorrentes por portador de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador da conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PagePortadorDebitoRecorrenteResponse</returns>
        public async System.Threading.Tasks.Task<PagePortadorDebitoRecorrenteResponse> ListarPortadorDebitoRecorrenteAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PagePortadorDebitoRecorrenteResponse> localVarResponse = await ListarPortadorDebitoRecorrenteAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os d\u00E9bitos recorrentes por portador de uma determinada conta Este recurso permite consultar os d\u00E9bitos recorrentes por portador de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador da conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PagePortadorDebitoRecorrenteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePortadorDebitoRecorrenteResponse>> ListarPortadorDebitoRecorrenteAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarPortadorDebitoRecorrente");
            
    
            var localVarPath = "/api/contas/{id}/portadores/debitos-recorrentes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ListarPortadorDebitoRecorrente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPortadorDebitoRecorrente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePortadorDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePortadorDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePortadorDebitoRecorrenteResponse)));
            
        }
        
        /// <summary>
        /// Listar Tipos Debitos Recorrentes Para os emissores que utilizam a entidade Debitos Recorrentes precisam previamente solicitar a Conductor o cadastro de quais Tipos eles poder\u00E3o comercializar. Por isso, este recurso tem como objetivo apresentar todos os Tipos de D\u00E9bitos Recorrentes que est\u00E3o cadastrados para um determinado Emissor, independente do status dele
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id) (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de d\u00E9bito recorrente (optional)</param> 
        /// <param name="valor">Valor do tipo de d\u00E9bito recorrente (optional)</param> 
        /// <param name="flagAtivo">Flag que identifica se o tipo d\u00E9bito recorrente est\u00E1 ativo (optional)</param> 
        /// <returns>PageTipoDebitoRecorrenteResponse</returns>
        public PageTipoDebitoRecorrenteResponse Listar_0 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, double? valor = null, bool? flagAtivo = null)
        {
             ApiResponse<PageTipoDebitoRecorrenteResponse> localVarResponse = Listar_0WithHttpInfo(sort, page, limit, id, descricao, valor, flagAtivo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar Tipos Debitos Recorrentes Para os emissores que utilizam a entidade Debitos Recorrentes precisam previamente solicitar a Conductor o cadastro de quais Tipos eles poder\u00E3o comercializar. Por isso, este recurso tem como objetivo apresentar todos os Tipos de D\u00E9bitos Recorrentes que est\u00E3o cadastrados para um determinado Emissor, independente do status dele
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id) (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de d\u00E9bito recorrente (optional)</param> 
        /// <param name="valor">Valor do tipo de d\u00E9bito recorrente (optional)</param> 
        /// <param name="flagAtivo">Flag que identifica se o tipo d\u00E9bito recorrente est\u00E1 ativo (optional)</param> 
        /// <returns>ApiResponse of PageTipoDebitoRecorrenteResponse</returns>
        public ApiResponse< PageTipoDebitoRecorrenteResponse > Listar_0WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, double? valor = null, bool? flagAtivo = null)
        {
            
    
            var localVarPath = "/api/tipos-debitos-recorrentes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (valor != null) localVarQueryParams.Add("valor", Configuration.ApiClient.ParameterToString(valor)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoDebitoRecorrenteResponse)));
            
        }

        
        /// <summary>
        /// Listar Tipos Debitos Recorrentes Para os emissores que utilizam a entidade Debitos Recorrentes precisam previamente solicitar a Conductor o cadastro de quais Tipos eles poder\u00E3o comercializar. Por isso, este recurso tem como objetivo apresentar todos os Tipos de D\u00E9bitos Recorrentes que est\u00E3o cadastrados para um determinado Emissor, independente do status dele
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de d\u00E9bito recorrente (optional)</param>
        /// <param name="valor">Valor do tipo de d\u00E9bito recorrente (optional)</param>
        /// <param name="flagAtivo">Flag que identifica se o tipo d\u00E9bito recorrente est\u00E1 ativo (optional)</param>
        /// <returns>Task of PageTipoDebitoRecorrenteResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoDebitoRecorrenteResponse> Listar_0Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, double? valor = null, bool? flagAtivo = null)
        {
             ApiResponse<PageTipoDebitoRecorrenteResponse> localVarResponse = await Listar_0AsyncWithHttpInfo(sort, page, limit, id, descricao, valor, flagAtivo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar Tipos Debitos Recorrentes Para os emissores que utilizam a entidade Debitos Recorrentes precisam previamente solicitar a Conductor o cadastro de quais Tipos eles poder\u00E3o comercializar. Por isso, este recurso tem como objetivo apresentar todos os Tipos de D\u00E9bitos Recorrentes que est\u00E3o cadastrados para um determinado Emissor, independente do status dele
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de d\u00E9bito recorrente (optional)</param>
        /// <param name="valor">Valor do tipo de d\u00E9bito recorrente (optional)</param>
        /// <param name="flagAtivo">Flag que identifica se o tipo d\u00E9bito recorrente est\u00E1 ativo (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoDebitoRecorrenteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoDebitoRecorrenteResponse>> Listar_0AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, double? valor = null, bool? flagAtivo = null)
        {
            
    
            var localVarPath = "/api/tipos-debitos-recorrentes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (valor != null) localVarQueryParams.Add("valor", Configuration.ApiClient.ParameterToString(valor)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoDebitoRecorrenteResponse)));
            
        }
        
        /// <summary>
        /// Salva os d\u00E9bitos recorrentes por portador de uma determinada conta Este recurso permite salvar os d\u00E9bitos recorrentes por portador de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador da conta</param> 
        /// <param name="portadorDebitoRecorrentePersist">portadorDebitoRecorrentePersist</param> 
        /// <returns>PortadorDebitoRecorrenteResponse</returns>
        public PortadorDebitoRecorrenteResponse SalvarPortadorDebitoRecorrente (long? id, PortadorDebitoRecorrentePersist portadorDebitoRecorrentePersist)
        {
             ApiResponse<PortadorDebitoRecorrenteResponse> localVarResponse = SalvarPortadorDebitoRecorrenteWithHttpInfo(id, portadorDebitoRecorrentePersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Salva os d\u00E9bitos recorrentes por portador de uma determinada conta Este recurso permite salvar os d\u00E9bitos recorrentes por portador de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador da conta</param> 
        /// <param name="portadorDebitoRecorrentePersist">portadorDebitoRecorrentePersist</param> 
        /// <returns>ApiResponse of PortadorDebitoRecorrenteResponse</returns>
        public ApiResponse< PortadorDebitoRecorrenteResponse > SalvarPortadorDebitoRecorrenteWithHttpInfo (long? id, PortadorDebitoRecorrentePersist portadorDebitoRecorrentePersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DebitoRecorrenteApi->SalvarPortadorDebitoRecorrente");
            
            // verify the required parameter 'portadorDebitoRecorrentePersist' is set
            if (portadorDebitoRecorrentePersist == null)
                throw new ApiException(400, "Missing required parameter 'portadorDebitoRecorrentePersist' when calling DebitoRecorrenteApi->SalvarPortadorDebitoRecorrente");
            
    
            var localVarPath = "/api/contas/{id}/portadores/debitos-recorrentes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (portadorDebitoRecorrentePersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(portadorDebitoRecorrentePersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = portadorDebitoRecorrentePersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPortadorDebitoRecorrente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPortadorDebitoRecorrente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PortadorDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PortadorDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PortadorDebitoRecorrenteResponse)));
            
        }

        
        /// <summary>
        /// Salva os d\u00E9bitos recorrentes por portador de uma determinada conta Este recurso permite salvar os d\u00E9bitos recorrentes por portador de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador da conta</param>
        /// <param name="portadorDebitoRecorrentePersist">portadorDebitoRecorrentePersist</param>
        /// <returns>Task of PortadorDebitoRecorrenteResponse</returns>
        public async System.Threading.Tasks.Task<PortadorDebitoRecorrenteResponse> SalvarPortadorDebitoRecorrenteAsync (long? id, PortadorDebitoRecorrentePersist portadorDebitoRecorrentePersist)
        {
             ApiResponse<PortadorDebitoRecorrenteResponse> localVarResponse = await SalvarPortadorDebitoRecorrenteAsyncWithHttpInfo(id, portadorDebitoRecorrentePersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Salva os d\u00E9bitos recorrentes por portador de uma determinada conta Este recurso permite salvar os d\u00E9bitos recorrentes por portador de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador da conta</param>
        /// <param name="portadorDebitoRecorrentePersist">portadorDebitoRecorrentePersist</param>
        /// <returns>Task of ApiResponse (PortadorDebitoRecorrenteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PortadorDebitoRecorrenteResponse>> SalvarPortadorDebitoRecorrenteAsyncWithHttpInfo (long? id, PortadorDebitoRecorrentePersist portadorDebitoRecorrentePersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SalvarPortadorDebitoRecorrente");
            // verify the required parameter 'portadorDebitoRecorrentePersist' is set
            if (portadorDebitoRecorrentePersist == null) throw new ApiException(400, "Missing required parameter 'portadorDebitoRecorrentePersist' when calling SalvarPortadorDebitoRecorrente");
            
    
            var localVarPath = "/api/contas/{id}/portadores/debitos-recorrentes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (portadorDebitoRecorrentePersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(portadorDebitoRecorrentePersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = portadorDebitoRecorrentePersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPortadorDebitoRecorrente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPortadorDebitoRecorrente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PortadorDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PortadorDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PortadorDebitoRecorrenteResponse)));
            
        }
        
    }
    
}
