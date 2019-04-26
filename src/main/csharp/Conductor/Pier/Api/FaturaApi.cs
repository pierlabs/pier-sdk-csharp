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
    public interface IFaturaApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Consulta fatura de um cliente
        /// </summary>
        /// <remarks>
        /// Consulta fatura de um cliente pela data de vencimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">Data Vencimento</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>FaturaDetalheResponse</returns>
        FaturaDetalheResponse ConsultarFatura (string dataVencimento, long? idConta);
  
        /// <summary>
        /// Consulta fatura de um cliente
        /// </summary>
        /// <remarks>
        /// Consulta fatura de um cliente pela data de vencimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">Data Vencimento</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>ApiResponse of FaturaDetalheResponse</returns>
        ApiResponse<FaturaDetalheResponse> ConsultarFaturaWithHttpInfo (string dataVencimento, long? idConta);
        
        /// <summary>
        /// Consulta fatura aberta de um cliente
        /// </summary>
        /// <remarks>
        /// Consulta fatura aberta de um cliente pela conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>FaturaAbertaResponse</returns>
        FaturaAbertaResponse ConsultarFaturaAberta (long? id);
  
        /// <summary>
        /// Consulta fatura aberta de um cliente
        /// </summary>
        /// <remarks>
        /// Consulta fatura aberta de um cliente pela conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>ApiResponse of FaturaAbertaResponse</returns>
        ApiResponse<FaturaAbertaResponse> ConsultarFaturaAbertaWithHttpInfo (long? id);
        
        /// <summary>
        /// Permite recuperar todas as faturas que j\u00E1 foram consolidadas (fechadas) para uma determinada conta.
        /// </summary>
        /// <remarks>
        /// Permite recuperar todas as faturas que j\u00E1 foram consolidadas (fechadas) para uma determinada conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="flagPerda">A flag indica se o retorno da consulta considera as faturas onde o seu status no momento do corte indicar perda. O retorno default considera os dois status, quando o valor for ATIVO s\u00F3 considera as faturas onde a flag de perda seja 1 (um) e o quando valor for INATIVO s\u00F3 considera as faturas onde a flag de perda seja  0 (zero).  (optional)</param>
        /// <returns>PageFaturaConsolidadaResponse</returns>
        PageFaturaConsolidadaResponse ConsultarFaturasFechadas (long? id, List<string> sort = null, int? page = null, int? limit = null, string flagPerda = null);
  
        /// <summary>
        /// Permite recuperar todas as faturas que j\u00E1 foram consolidadas (fechadas) para uma determinada conta.
        /// </summary>
        /// <remarks>
        /// Permite recuperar todas as faturas que j\u00E1 foram consolidadas (fechadas) para uma determinada conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="flagPerda">A flag indica se o retorno da consulta considera as faturas onde o seu status no momento do corte indicar perda. O retorno default considera os dois status, quando o valor for ATIVO s\u00F3 considera as faturas onde a flag de perda seja 1 (um) e o quando valor for INATIVO s\u00F3 considera as faturas onde a flag de perda seja  0 (zero).  (optional)</param>
        /// <returns>ApiResponse of PageFaturaConsolidadaResponse</returns>
        ApiResponse<PageFaturaConsolidadaResponse> ConsultarFaturasFechadasWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string flagPerda = null);
        
        /// <summary>
        /// Listar planos de parcelamento
        /// </summary>
        /// <remarks>
        /// Lista os planos de parcelamento da fatura de uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="dataVencimentoPadrao">Indica a data de vencimento padr\u00E3o das faturas</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PagePlanoParcelamentoResponse</returns>
        PagePlanoParcelamentoResponse ConsultarLancamentosFuturosFatura (long? id, string dataVencimentoPadrao, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Listar planos de parcelamento
        /// </summary>
        /// <remarks>
        /// Lista os planos de parcelamento da fatura de uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="dataVencimentoPadrao">Indica a data de vencimento padr\u00E3o das faturas</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PagePlanoParcelamentoResponse</returns>
        ApiResponse<PagePlanoParcelamentoResponse> ConsultarLancamentosFuturosFaturaWithHttpInfo (long? id, string dataVencimentoPadrao, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Envia 2\u00AA via de fatura por E-mail
        /// </summary>
        /// <remarks>
        /// Envia a segunda via da fatura para o e-mail informado/cadastrado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura (yyyy-MM-dd)</param>
        /// <param name="email">E-mail para envio da 2\u00AA via da fatura, caso n\u00E3o seja informado ser\u00E1 usado o e-mail cadastrado (optional)</param>
        /// <returns>Object</returns>
        Object EnviarFaturaEmail (long? id, string dataVencimento, string email = null);
  
        /// <summary>
        /// Envia 2\u00AA via de fatura por E-mail
        /// </summary>
        /// <remarks>
        /// Envia a segunda via da fatura para o e-mail informado/cadastrado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura (yyyy-MM-dd)</param>
        /// <param name="email">E-mail para envio da 2\u00AA via da fatura, caso n\u00E3o seja informado ser\u00E1 usado o e-mail cadastrado (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> EnviarFaturaEmailWithHttpInfo (long? id, string dataVencimento, string email = null);
        
        /// <summary>
        /// Listar faturas de um cliente
        /// </summary>
        /// <remarks>
        /// Lista faturas de um cliente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="situacaoProcessamento">Status do processamento das faturas. Valores possiveis [ABERTA, FECHADA, TODAS] (optional, default to TODAS)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageFaturaResponse</returns>
        PageFaturaResponse ListarFaturas (long? idConta, string situacaoProcessamento = null, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Listar faturas de um cliente
        /// </summary>
        /// <remarks>
        /// Lista faturas de um cliente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="situacaoProcessamento">Status do processamento das faturas. Valores possiveis [ABERTA, FECHADA, TODAS] (optional, default to TODAS)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageFaturaResponse</returns>
        ApiResponse<PageFaturaResponse> ListarFaturasWithHttpInfo (long? idConta, string situacaoProcessamento = null, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista as faturas futuras de um cliente
        /// </summary>
        /// <remarks>
        /// Lista as faturas futuras de um cliente pela conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageFaturaFuturaResponse</returns>
        PageFaturaFuturaResponse ListarFaturasFuturas (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista as faturas futuras de um cliente
        /// </summary>
        /// <remarks>
        /// Lista as faturas futuras de um cliente pela conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageFaturaFuturaResponse</returns>
        ApiResponse<PageFaturaFuturaResponse> ListarFaturasFuturasWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Permite visualizar o extrato da fatura em formato PDF
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o permite visualizar o extrato da fatura de uma determinada conta, em formato PDF. Quando ela for a fatura ativa, ou seja, a do m\u00EAs corrente, o pdf ser\u00E1 composto pelo extrato de lan\u00E7amentos e pela ficha de compensa\u00E7\u00E3o banc\u00E1ria. Quando for de uma fatura do hist\u00F3rico do cliente, o PDF ser\u00E1 composto apenas pelo extrato de transa\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura</param>
        /// <param name="flagApenasDemostrativo">Se o par\u00E2metro for verdadeiro a fatura ser\u00E1 exibida sem o boleto banc\u00E1rio. Caso o par\u00E2metro seja falso ou nulo a fatura ser\u00E1 exibida normalmente, com o boleto banc\u00E1rio (optional)</param>
        /// <param name="flagRegistraBoleto">Se o par\u00E2metro for verdadeiro o boleto banc\u00E1rio ser\u00E1 registrado antes de exibir a fatura. Caso o par\u00E2metro seja falso ou nulo o boleto o recurso n\u00E3o efetuar\u00E1 o registro do boleto banc\u00E1rio (optional)</param>
        /// <returns>Object</returns>
        Object VisualizarDocumento (long? id, string dataVencimento, bool? flagApenasDemostrativo = null, bool? flagRegistraBoleto = null);
  
        /// <summary>
        /// Permite visualizar o extrato da fatura em formato PDF
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o permite visualizar o extrato da fatura de uma determinada conta, em formato PDF. Quando ela for a fatura ativa, ou seja, a do m\u00EAs corrente, o pdf ser\u00E1 composto pelo extrato de lan\u00E7amentos e pela ficha de compensa\u00E7\u00E3o banc\u00E1ria. Quando for de uma fatura do hist\u00F3rico do cliente, o PDF ser\u00E1 composto apenas pelo extrato de transa\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura</param>
        /// <param name="flagApenasDemostrativo">Se o par\u00E2metro for verdadeiro a fatura ser\u00E1 exibida sem o boleto banc\u00E1rio. Caso o par\u00E2metro seja falso ou nulo a fatura ser\u00E1 exibida normalmente, com o boleto banc\u00E1rio (optional)</param>
        /// <param name="flagRegistraBoleto">Se o par\u00E2metro for verdadeiro o boleto banc\u00E1rio ser\u00E1 registrado antes de exibir a fatura. Caso o par\u00E2metro seja falso ou nulo o boleto o recurso n\u00E3o efetuar\u00E1 o registro do boleto banc\u00E1rio (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> VisualizarDocumentoWithHttpInfo (long? id, string dataVencimento, bool? flagApenasDemostrativo = null, bool? flagRegistraBoleto = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Consulta fatura de um cliente
        /// </summary>
        /// <remarks>
        /// Consulta fatura de um cliente pela data de vencimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">Data Vencimento</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of FaturaDetalheResponse</returns>
        System.Threading.Tasks.Task<FaturaDetalheResponse> ConsultarFaturaAsync (string dataVencimento, long? idConta);

        /// <summary>
        /// Consulta fatura de um cliente
        /// </summary>
        /// <remarks>
        /// Consulta fatura de um cliente pela data de vencimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">Data Vencimento</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of ApiResponse (FaturaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaturaDetalheResponse>> ConsultarFaturaAsyncWithHttpInfo (string dataVencimento, long? idConta);
        
        /// <summary>
        /// Consulta fatura aberta de um cliente
        /// </summary>
        /// <remarks>
        /// Consulta fatura aberta de um cliente pela conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of FaturaAbertaResponse</returns>
        System.Threading.Tasks.Task<FaturaAbertaResponse> ConsultarFaturaAbertaAsync (long? id);

        /// <summary>
        /// Consulta fatura aberta de um cliente
        /// </summary>
        /// <remarks>
        /// Consulta fatura aberta de um cliente pela conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of ApiResponse (FaturaAbertaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaturaAbertaResponse>> ConsultarFaturaAbertaAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Permite recuperar todas as faturas que j\u00E1 foram consolidadas (fechadas) para uma determinada conta.
        /// </summary>
        /// <remarks>
        /// Permite recuperar todas as faturas que j\u00E1 foram consolidadas (fechadas) para uma determinada conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="flagPerda">A flag indica se o retorno da consulta considera as faturas onde o seu status no momento do corte indicar perda. O retorno default considera os dois status, quando o valor for ATIVO s\u00F3 considera as faturas onde a flag de perda seja 1 (um) e o quando valor for INATIVO s\u00F3 considera as faturas onde a flag de perda seja  0 (zero).  (optional)</param>
        /// <returns>Task of PageFaturaConsolidadaResponse</returns>
        System.Threading.Tasks.Task<PageFaturaConsolidadaResponse> ConsultarFaturasFechadasAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string flagPerda = null);

        /// <summary>
        /// Permite recuperar todas as faturas que j\u00E1 foram consolidadas (fechadas) para uma determinada conta.
        /// </summary>
        /// <remarks>
        /// Permite recuperar todas as faturas que j\u00E1 foram consolidadas (fechadas) para uma determinada conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="flagPerda">A flag indica se o retorno da consulta considera as faturas onde o seu status no momento do corte indicar perda. O retorno default considera os dois status, quando o valor for ATIVO s\u00F3 considera as faturas onde a flag de perda seja 1 (um) e o quando valor for INATIVO s\u00F3 considera as faturas onde a flag de perda seja  0 (zero).  (optional)</param>
        /// <returns>Task of ApiResponse (PageFaturaConsolidadaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageFaturaConsolidadaResponse>> ConsultarFaturasFechadasAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string flagPerda = null);
        
        /// <summary>
        /// Listar planos de parcelamento
        /// </summary>
        /// <remarks>
        /// Lista os planos de parcelamento da fatura de uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="dataVencimentoPadrao">Indica a data de vencimento padr\u00E3o das faturas</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PagePlanoParcelamentoResponse</returns>
        System.Threading.Tasks.Task<PagePlanoParcelamentoResponse> ConsultarLancamentosFuturosFaturaAsync (long? id, string dataVencimentoPadrao, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Listar planos de parcelamento
        /// </summary>
        /// <remarks>
        /// Lista os planos de parcelamento da fatura de uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="dataVencimentoPadrao">Indica a data de vencimento padr\u00E3o das faturas</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PagePlanoParcelamentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePlanoParcelamentoResponse>> ConsultarLancamentosFuturosFaturaAsyncWithHttpInfo (long? id, string dataVencimentoPadrao, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Envia 2\u00AA via de fatura por E-mail
        /// </summary>
        /// <remarks>
        /// Envia a segunda via da fatura para o e-mail informado/cadastrado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura (yyyy-MM-dd)</param>
        /// <param name="email">E-mail para envio da 2\u00AA via da fatura, caso n\u00E3o seja informado ser\u00E1 usado o e-mail cadastrado (optional)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> EnviarFaturaEmailAsync (long? id, string dataVencimento, string email = null);

        /// <summary>
        /// Envia 2\u00AA via de fatura por E-mail
        /// </summary>
        /// <remarks>
        /// Envia a segunda via da fatura para o e-mail informado/cadastrado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura (yyyy-MM-dd)</param>
        /// <param name="email">E-mail para envio da 2\u00AA via da fatura, caso n\u00E3o seja informado ser\u00E1 usado o e-mail cadastrado (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> EnviarFaturaEmailAsyncWithHttpInfo (long? id, string dataVencimento, string email = null);
        
        /// <summary>
        /// Listar faturas de um cliente
        /// </summary>
        /// <remarks>
        /// Lista faturas de um cliente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="situacaoProcessamento">Status do processamento das faturas. Valores possiveis [ABERTA, FECHADA, TODAS] (optional, default to TODAS)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageFaturaResponse</returns>
        System.Threading.Tasks.Task<PageFaturaResponse> ListarFaturasAsync (long? idConta, string situacaoProcessamento = null, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Listar faturas de um cliente
        /// </summary>
        /// <remarks>
        /// Lista faturas de um cliente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="situacaoProcessamento">Status do processamento das faturas. Valores possiveis [ABERTA, FECHADA, TODAS] (optional, default to TODAS)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageFaturaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageFaturaResponse>> ListarFaturasAsyncWithHttpInfo (long? idConta, string situacaoProcessamento = null, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista as faturas futuras de um cliente
        /// </summary>
        /// <remarks>
        /// Lista as faturas futuras de um cliente pela conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageFaturaFuturaResponse</returns>
        System.Threading.Tasks.Task<PageFaturaFuturaResponse> ListarFaturasFuturasAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista as faturas futuras de um cliente
        /// </summary>
        /// <remarks>
        /// Lista as faturas futuras de um cliente pela conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageFaturaFuturaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageFaturaFuturaResponse>> ListarFaturasFuturasAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Permite visualizar o extrato da fatura em formato PDF
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o permite visualizar o extrato da fatura de uma determinada conta, em formato PDF. Quando ela for a fatura ativa, ou seja, a do m\u00EAs corrente, o pdf ser\u00E1 composto pelo extrato de lan\u00E7amentos e pela ficha de compensa\u00E7\u00E3o banc\u00E1ria. Quando for de uma fatura do hist\u00F3rico do cliente, o PDF ser\u00E1 composto apenas pelo extrato de transa\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura</param>
        /// <param name="flagApenasDemostrativo">Se o par\u00E2metro for verdadeiro a fatura ser\u00E1 exibida sem o boleto banc\u00E1rio. Caso o par\u00E2metro seja falso ou nulo a fatura ser\u00E1 exibida normalmente, com o boleto banc\u00E1rio (optional)</param>
        /// <param name="flagRegistraBoleto">Se o par\u00E2metro for verdadeiro o boleto banc\u00E1rio ser\u00E1 registrado antes de exibir a fatura. Caso o par\u00E2metro seja falso ou nulo o boleto o recurso n\u00E3o efetuar\u00E1 o registro do boleto banc\u00E1rio (optional)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> VisualizarDocumentoAsync (long? id, string dataVencimento, bool? flagApenasDemostrativo = null, bool? flagRegistraBoleto = null);

        /// <summary>
        /// Permite visualizar o extrato da fatura em formato PDF
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o permite visualizar o extrato da fatura de uma determinada conta, em formato PDF. Quando ela for a fatura ativa, ou seja, a do m\u00EAs corrente, o pdf ser\u00E1 composto pelo extrato de lan\u00E7amentos e pela ficha de compensa\u00E7\u00E3o banc\u00E1ria. Quando for de uma fatura do hist\u00F3rico do cliente, o PDF ser\u00E1 composto apenas pelo extrato de transa\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura</param>
        /// <param name="flagApenasDemostrativo">Se o par\u00E2metro for verdadeiro a fatura ser\u00E1 exibida sem o boleto banc\u00E1rio. Caso o par\u00E2metro seja falso ou nulo a fatura ser\u00E1 exibida normalmente, com o boleto banc\u00E1rio (optional)</param>
        /// <param name="flagRegistraBoleto">Se o par\u00E2metro for verdadeiro o boleto banc\u00E1rio ser\u00E1 registrado antes de exibir a fatura. Caso o par\u00E2metro seja falso ou nulo o boleto o recurso n\u00E3o efetuar\u00E1 o registro do boleto banc\u00E1rio (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> VisualizarDocumentoAsyncWithHttpInfo (long? id, string dataVencimento, bool? flagApenasDemostrativo = null, bool? flagRegistraBoleto = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FaturaApi : IFaturaApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FaturaApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FaturaApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FaturaApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FaturaApi(Configuration configuration = null)
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
        /// Consulta fatura de um cliente Consulta fatura de um cliente pela data de vencimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">Data Vencimento</param> 
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <returns>FaturaDetalheResponse</returns>
        public FaturaDetalheResponse ConsultarFatura (string dataVencimento, long? idConta)
        {
             ApiResponse<FaturaDetalheResponse> localVarResponse = ConsultarFaturaWithHttpInfo(dataVencimento, idConta);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta fatura de um cliente Consulta fatura de um cliente pela data de vencimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">Data Vencimento</param> 
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <returns>ApiResponse of FaturaDetalheResponse</returns>
        public ApiResponse< FaturaDetalheResponse > ConsultarFaturaWithHttpInfo (string dataVencimento, long? idConta)
        {
            
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null)
                throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling FaturaApi->ConsultarFatura");
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling FaturaApi->ConsultarFatura");
            
    
            var localVarPath = "/api/faturas/{dataVencimento}";
    
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
            if (dataVencimento != null) localVarPathParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // path parameter
            
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarFatura: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarFatura: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<FaturaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaturaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaturaDetalheResponse)));
            
        }

        
        /// <summary>
        /// Consulta fatura de um cliente Consulta fatura de um cliente pela data de vencimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">Data Vencimento</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of FaturaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<FaturaDetalheResponse> ConsultarFaturaAsync (string dataVencimento, long? idConta)
        {
             ApiResponse<FaturaDetalheResponse> localVarResponse = await ConsultarFaturaAsyncWithHttpInfo(dataVencimento, idConta);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta fatura de um cliente Consulta fatura de um cliente pela data de vencimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">Data Vencimento</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of ApiResponse (FaturaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaturaDetalheResponse>> ConsultarFaturaAsyncWithHttpInfo (string dataVencimento, long? idConta)
        {
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null) throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling ConsultarFatura");
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ConsultarFatura");
            
    
            var localVarPath = "/api/faturas/{dataVencimento}";
    
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
            if (dataVencimento != null) localVarPathParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // path parameter
            
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarFatura: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarFatura: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaturaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaturaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaturaDetalheResponse)));
            
        }
        
        /// <summary>
        /// Consulta fatura aberta de um cliente Consulta fatura aberta de um cliente pela conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <returns>FaturaAbertaResponse</returns>
        public FaturaAbertaResponse ConsultarFaturaAberta (long? id)
        {
             ApiResponse<FaturaAbertaResponse> localVarResponse = ConsultarFaturaAbertaWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta fatura aberta de um cliente Consulta fatura aberta de um cliente pela conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <returns>ApiResponse of FaturaAbertaResponse</returns>
        public ApiResponse< FaturaAbertaResponse > ConsultarFaturaAbertaWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FaturaApi->ConsultarFaturaAberta");
            
    
            var localVarPath = "/api/contas/{id}/faturas/abertas";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarFaturaAberta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarFaturaAberta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<FaturaAbertaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaturaAbertaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaturaAbertaResponse)));
            
        }

        
        /// <summary>
        /// Consulta fatura aberta de um cliente Consulta fatura aberta de um cliente pela conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of FaturaAbertaResponse</returns>
        public async System.Threading.Tasks.Task<FaturaAbertaResponse> ConsultarFaturaAbertaAsync (long? id)
        {
             ApiResponse<FaturaAbertaResponse> localVarResponse = await ConsultarFaturaAbertaAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta fatura aberta de um cliente Consulta fatura aberta de um cliente pela conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of ApiResponse (FaturaAbertaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaturaAbertaResponse>> ConsultarFaturaAbertaAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarFaturaAberta");
            
    
            var localVarPath = "/api/contas/{id}/faturas/abertas";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarFaturaAberta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarFaturaAberta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaturaAbertaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaturaAbertaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaturaAbertaResponse)));
            
        }
        
        /// <summary>
        /// Permite recuperar todas as faturas que j\u00E1 foram consolidadas (fechadas) para uma determinada conta. Permite recuperar todas as faturas que j\u00E1 foram consolidadas (fechadas) para uma determinada conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="flagPerda">A flag indica se o retorno da consulta considera as faturas onde o seu status no momento do corte indicar perda. O retorno default considera os dois status, quando o valor for ATIVO s\u00F3 considera as faturas onde a flag de perda seja 1 (um) e o quando valor for INATIVO s\u00F3 considera as faturas onde a flag de perda seja  0 (zero).  (optional)</param> 
        /// <returns>PageFaturaConsolidadaResponse</returns>
        public PageFaturaConsolidadaResponse ConsultarFaturasFechadas (long? id, List<string> sort = null, int? page = null, int? limit = null, string flagPerda = null)
        {
             ApiResponse<PageFaturaConsolidadaResponse> localVarResponse = ConsultarFaturasFechadasWithHttpInfo(id, sort, page, limit, flagPerda);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite recuperar todas as faturas que j\u00E1 foram consolidadas (fechadas) para uma determinada conta. Permite recuperar todas as faturas que j\u00E1 foram consolidadas (fechadas) para uma determinada conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="flagPerda">A flag indica se o retorno da consulta considera as faturas onde o seu status no momento do corte indicar perda. O retorno default considera os dois status, quando o valor for ATIVO s\u00F3 considera as faturas onde a flag de perda seja 1 (um) e o quando valor for INATIVO s\u00F3 considera as faturas onde a flag de perda seja  0 (zero).  (optional)</param> 
        /// <returns>ApiResponse of PageFaturaConsolidadaResponse</returns>
        public ApiResponse< PageFaturaConsolidadaResponse > ConsultarFaturasFechadasWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string flagPerda = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FaturaApi->ConsultarFaturasFechadas");
            
    
            var localVarPath = "/api/contas/{id}/faturas/fechadas";
    
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
            if (flagPerda != null) localVarQueryParams.Add("flagPerda", Configuration.ApiClient.ParameterToString(flagPerda)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarFaturasFechadas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarFaturasFechadas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageFaturaConsolidadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageFaturaConsolidadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageFaturaConsolidadaResponse)));
            
        }

        
        /// <summary>
        /// Permite recuperar todas as faturas que j\u00E1 foram consolidadas (fechadas) para uma determinada conta. Permite recuperar todas as faturas que j\u00E1 foram consolidadas (fechadas) para uma determinada conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="flagPerda">A flag indica se o retorno da consulta considera as faturas onde o seu status no momento do corte indicar perda. O retorno default considera os dois status, quando o valor for ATIVO s\u00F3 considera as faturas onde a flag de perda seja 1 (um) e o quando valor for INATIVO s\u00F3 considera as faturas onde a flag de perda seja  0 (zero).  (optional)</param>
        /// <returns>Task of PageFaturaConsolidadaResponse</returns>
        public async System.Threading.Tasks.Task<PageFaturaConsolidadaResponse> ConsultarFaturasFechadasAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string flagPerda = null)
        {
             ApiResponse<PageFaturaConsolidadaResponse> localVarResponse = await ConsultarFaturasFechadasAsyncWithHttpInfo(id, sort, page, limit, flagPerda);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite recuperar todas as faturas que j\u00E1 foram consolidadas (fechadas) para uma determinada conta. Permite recuperar todas as faturas que j\u00E1 foram consolidadas (fechadas) para uma determinada conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="flagPerda">A flag indica se o retorno da consulta considera as faturas onde o seu status no momento do corte indicar perda. O retorno default considera os dois status, quando o valor for ATIVO s\u00F3 considera as faturas onde a flag de perda seja 1 (um) e o quando valor for INATIVO s\u00F3 considera as faturas onde a flag de perda seja  0 (zero).  (optional)</param>
        /// <returns>Task of ApiResponse (PageFaturaConsolidadaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageFaturaConsolidadaResponse>> ConsultarFaturasFechadasAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string flagPerda = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarFaturasFechadas");
            
    
            var localVarPath = "/api/contas/{id}/faturas/fechadas";
    
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
            if (flagPerda != null) localVarQueryParams.Add("flagPerda", Configuration.ApiClient.ParameterToString(flagPerda)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarFaturasFechadas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarFaturasFechadas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageFaturaConsolidadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageFaturaConsolidadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageFaturaConsolidadaResponse)));
            
        }
        
        /// <summary>
        /// Listar planos de parcelamento Lista os planos de parcelamento da fatura de uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="dataVencimentoPadrao">Indica a data de vencimento padr\u00E3o das faturas</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PagePlanoParcelamentoResponse</returns>
        public PagePlanoParcelamentoResponse ConsultarLancamentosFuturosFatura (long? id, string dataVencimentoPadrao, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PagePlanoParcelamentoResponse> localVarResponse = ConsultarLancamentosFuturosFaturaWithHttpInfo(id, dataVencimentoPadrao, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar planos de parcelamento Lista os planos de parcelamento da fatura de uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="dataVencimentoPadrao">Indica a data de vencimento padr\u00E3o das faturas</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PagePlanoParcelamentoResponse</returns>
        public ApiResponse< PagePlanoParcelamentoResponse > ConsultarLancamentosFuturosFaturaWithHttpInfo (long? id, string dataVencimentoPadrao, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FaturaApi->ConsultarLancamentosFuturosFatura");
            
            // verify the required parameter 'dataVencimentoPadrao' is set
            if (dataVencimentoPadrao == null)
                throw new ApiException(400, "Missing required parameter 'dataVencimentoPadrao' when calling FaturaApi->ConsultarLancamentosFuturosFatura");
            
    
            var localVarPath = "/api/contas/{id}/faturas/planos-parcelamento";
    
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
            if (dataVencimentoPadrao != null) localVarQueryParams.Add("dataVencimentoPadrao", Configuration.ApiClient.ParameterToString(dataVencimentoPadrao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLancamentosFuturosFatura: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLancamentosFuturosFatura: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePlanoParcelamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePlanoParcelamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePlanoParcelamentoResponse)));
            
        }

        
        /// <summary>
        /// Listar planos de parcelamento Lista os planos de parcelamento da fatura de uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="dataVencimentoPadrao">Indica a data de vencimento padr\u00E3o das faturas</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PagePlanoParcelamentoResponse</returns>
        public async System.Threading.Tasks.Task<PagePlanoParcelamentoResponse> ConsultarLancamentosFuturosFaturaAsync (long? id, string dataVencimentoPadrao, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PagePlanoParcelamentoResponse> localVarResponse = await ConsultarLancamentosFuturosFaturaAsyncWithHttpInfo(id, dataVencimentoPadrao, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar planos de parcelamento Lista os planos de parcelamento da fatura de uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="dataVencimentoPadrao">Indica a data de vencimento padr\u00E3o das faturas</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PagePlanoParcelamentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePlanoParcelamentoResponse>> ConsultarLancamentosFuturosFaturaAsyncWithHttpInfo (long? id, string dataVencimentoPadrao, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarLancamentosFuturosFatura");
            // verify the required parameter 'dataVencimentoPadrao' is set
            if (dataVencimentoPadrao == null) throw new ApiException(400, "Missing required parameter 'dataVencimentoPadrao' when calling ConsultarLancamentosFuturosFatura");
            
    
            var localVarPath = "/api/contas/{id}/faturas/planos-parcelamento";
    
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
            if (dataVencimentoPadrao != null) localVarQueryParams.Add("dataVencimentoPadrao", Configuration.ApiClient.ParameterToString(dataVencimentoPadrao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLancamentosFuturosFatura: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLancamentosFuturosFatura: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePlanoParcelamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePlanoParcelamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePlanoParcelamentoResponse)));
            
        }
        
        /// <summary>
        /// Envia 2\u00AA via de fatura por E-mail Envia a segunda via da fatura para o e-mail informado/cadastrado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="dataVencimento">Data de Vencimento da fatura (yyyy-MM-dd)</param> 
        /// <param name="email">E-mail para envio da 2\u00AA via da fatura, caso n\u00E3o seja informado ser\u00E1 usado o e-mail cadastrado (optional)</param> 
        /// <returns>Object</returns>
        public Object EnviarFaturaEmail (long? id, string dataVencimento, string email = null)
        {
             ApiResponse<Object> localVarResponse = EnviarFaturaEmailWithHttpInfo(id, dataVencimento, email);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Envia 2\u00AA via de fatura por E-mail Envia a segunda via da fatura para o e-mail informado/cadastrado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="dataVencimento">Data de Vencimento da fatura (yyyy-MM-dd)</param> 
        /// <param name="email">E-mail para envio da 2\u00AA via da fatura, caso n\u00E3o seja informado ser\u00E1 usado o e-mail cadastrado (optional)</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > EnviarFaturaEmailWithHttpInfo (long? id, string dataVencimento, string email = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FaturaApi->EnviarFaturaEmail");
            
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null)
                throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling FaturaApi->EnviarFaturaEmail");
            
    
            var localVarPath = "/api/contas/{id}/faturas/{dataVencimento}/enviar-email";
    
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
            if (dataVencimento != null) localVarPathParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // path parameter
            
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling EnviarFaturaEmail: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EnviarFaturaEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Envia 2\u00AA via de fatura por E-mail Envia a segunda via da fatura para o e-mail informado/cadastrado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura (yyyy-MM-dd)</param>
        /// <param name="email">E-mail para envio da 2\u00AA via da fatura, caso n\u00E3o seja informado ser\u00E1 usado o e-mail cadastrado (optional)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> EnviarFaturaEmailAsync (long? id, string dataVencimento, string email = null)
        {
             ApiResponse<Object> localVarResponse = await EnviarFaturaEmailAsyncWithHttpInfo(id, dataVencimento, email);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Envia 2\u00AA via de fatura por E-mail Envia a segunda via da fatura para o e-mail informado/cadastrado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura (yyyy-MM-dd)</param>
        /// <param name="email">E-mail para envio da 2\u00AA via da fatura, caso n\u00E3o seja informado ser\u00E1 usado o e-mail cadastrado (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> EnviarFaturaEmailAsyncWithHttpInfo (long? id, string dataVencimento, string email = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EnviarFaturaEmail");
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null) throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling EnviarFaturaEmail");
            
    
            var localVarPath = "/api/contas/{id}/faturas/{dataVencimento}/enviar-email";
    
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
            if (dataVencimento != null) localVarPathParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // path parameter
            
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling EnviarFaturaEmail: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EnviarFaturaEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Listar faturas de um cliente Lista faturas de um cliente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="situacaoProcessamento">Status do processamento das faturas. Valores possiveis [ABERTA, FECHADA, TODAS] (optional, default to TODAS)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageFaturaResponse</returns>
        public PageFaturaResponse ListarFaturas (long? idConta, string situacaoProcessamento = null, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageFaturaResponse> localVarResponse = ListarFaturasWithHttpInfo(idConta, situacaoProcessamento, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar faturas de um cliente Lista faturas de um cliente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="situacaoProcessamento">Status do processamento das faturas. Valores possiveis [ABERTA, FECHADA, TODAS] (optional, default to TODAS)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageFaturaResponse</returns>
        public ApiResponse< PageFaturaResponse > ListarFaturasWithHttpInfo (long? idConta, string situacaoProcessamento = null, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling FaturaApi->ListarFaturas");
            
    
            var localVarPath = "/api/faturas";
    
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
            if (situacaoProcessamento != null) localVarQueryParams.Add("situacaoProcessamento", Configuration.ApiClient.ParameterToString(situacaoProcessamento)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageFaturaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageFaturaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageFaturaResponse)));
            
        }

        
        /// <summary>
        /// Listar faturas de um cliente Lista faturas de um cliente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="situacaoProcessamento">Status do processamento das faturas. Valores possiveis [ABERTA, FECHADA, TODAS] (optional, default to TODAS)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageFaturaResponse</returns>
        public async System.Threading.Tasks.Task<PageFaturaResponse> ListarFaturasAsync (long? idConta, string situacaoProcessamento = null, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageFaturaResponse> localVarResponse = await ListarFaturasAsyncWithHttpInfo(idConta, situacaoProcessamento, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar faturas de um cliente Lista faturas de um cliente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="situacaoProcessamento">Status do processamento das faturas. Valores possiveis [ABERTA, FECHADA, TODAS] (optional, default to TODAS)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageFaturaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageFaturaResponse>> ListarFaturasAsyncWithHttpInfo (long? idConta, string situacaoProcessamento = null, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ListarFaturas");
            
    
            var localVarPath = "/api/faturas";
    
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
            if (situacaoProcessamento != null) localVarQueryParams.Add("situacaoProcessamento", Configuration.ApiClient.ParameterToString(situacaoProcessamento)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageFaturaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageFaturaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageFaturaResponse)));
            
        }
        
        /// <summary>
        /// Lista as faturas futuras de um cliente Lista as faturas futuras de um cliente pela conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageFaturaFuturaResponse</returns>
        public PageFaturaFuturaResponse ListarFaturasFuturas (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageFaturaFuturaResponse> localVarResponse = ListarFaturasFuturasWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as faturas futuras de um cliente Lista as faturas futuras de um cliente pela conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageFaturaFuturaResponse</returns>
        public ApiResponse< PageFaturaFuturaResponse > ListarFaturasFuturasWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FaturaApi->ListarFaturasFuturas");
            
    
            var localVarPath = "/api/contas/{id}/faturas/futuras";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturasFuturas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturasFuturas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageFaturaFuturaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageFaturaFuturaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageFaturaFuturaResponse)));
            
        }

        
        /// <summary>
        /// Lista as faturas futuras de um cliente Lista as faturas futuras de um cliente pela conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageFaturaFuturaResponse</returns>
        public async System.Threading.Tasks.Task<PageFaturaFuturaResponse> ListarFaturasFuturasAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageFaturaFuturaResponse> localVarResponse = await ListarFaturasFuturasAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as faturas futuras de um cliente Lista as faturas futuras de um cliente pela conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageFaturaFuturaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageFaturaFuturaResponse>> ListarFaturasFuturasAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarFaturasFuturas");
            
    
            var localVarPath = "/api/contas/{id}/faturas/futuras";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturasFuturas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturasFuturas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageFaturaFuturaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageFaturaFuturaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageFaturaFuturaResponse)));
            
        }
        
        /// <summary>
        /// Permite visualizar o extrato da fatura em formato PDF Esta opera\u00E7\u00E3o permite visualizar o extrato da fatura de uma determinada conta, em formato PDF. Quando ela for a fatura ativa, ou seja, a do m\u00EAs corrente, o pdf ser\u00E1 composto pelo extrato de lan\u00E7amentos e pela ficha de compensa\u00E7\u00E3o banc\u00E1ria. Quando for de uma fatura do hist\u00F3rico do cliente, o PDF ser\u00E1 composto apenas pelo extrato de transa\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="dataVencimento">Data de Vencimento da fatura</param> 
        /// <param name="flagApenasDemostrativo">Se o par\u00E2metro for verdadeiro a fatura ser\u00E1 exibida sem o boleto banc\u00E1rio. Caso o par\u00E2metro seja falso ou nulo a fatura ser\u00E1 exibida normalmente, com o boleto banc\u00E1rio (optional)</param> 
        /// <param name="flagRegistraBoleto">Se o par\u00E2metro for verdadeiro o boleto banc\u00E1rio ser\u00E1 registrado antes de exibir a fatura. Caso o par\u00E2metro seja falso ou nulo o boleto o recurso n\u00E3o efetuar\u00E1 o registro do boleto banc\u00E1rio (optional)</param> 
        /// <returns>Object</returns>
        public Object VisualizarDocumento (long? id, string dataVencimento, bool? flagApenasDemostrativo = null, bool? flagRegistraBoleto = null)
        {
             ApiResponse<Object> localVarResponse = VisualizarDocumentoWithHttpInfo(id, dataVencimento, flagApenasDemostrativo, flagRegistraBoleto);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite visualizar o extrato da fatura em formato PDF Esta opera\u00E7\u00E3o permite visualizar o extrato da fatura de uma determinada conta, em formato PDF. Quando ela for a fatura ativa, ou seja, a do m\u00EAs corrente, o pdf ser\u00E1 composto pelo extrato de lan\u00E7amentos e pela ficha de compensa\u00E7\u00E3o banc\u00E1ria. Quando for de uma fatura do hist\u00F3rico do cliente, o PDF ser\u00E1 composto apenas pelo extrato de transa\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="dataVencimento">Data de Vencimento da fatura</param> 
        /// <param name="flagApenasDemostrativo">Se o par\u00E2metro for verdadeiro a fatura ser\u00E1 exibida sem o boleto banc\u00E1rio. Caso o par\u00E2metro seja falso ou nulo a fatura ser\u00E1 exibida normalmente, com o boleto banc\u00E1rio (optional)</param> 
        /// <param name="flagRegistraBoleto">Se o par\u00E2metro for verdadeiro o boleto banc\u00E1rio ser\u00E1 registrado antes de exibir a fatura. Caso o par\u00E2metro seja falso ou nulo o boleto o recurso n\u00E3o efetuar\u00E1 o registro do boleto banc\u00E1rio (optional)</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > VisualizarDocumentoWithHttpInfo (long? id, string dataVencimento, bool? flagApenasDemostrativo = null, bool? flagRegistraBoleto = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FaturaApi->VisualizarDocumento");
            
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null)
                throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling FaturaApi->VisualizarDocumento");
            
    
            var localVarPath = "/api/contas/{id}/faturas/{dataVencimento}/arquivo.pdf";
    
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
                "application/pdf"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (dataVencimento != null) localVarPathParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // path parameter
            
            if (flagApenasDemostrativo != null) localVarQueryParams.Add("flagApenasDemostrativo", Configuration.ApiClient.ParameterToString(flagApenasDemostrativo)); // query parameter
            if (flagRegistraBoleto != null) localVarQueryParams.Add("flagRegistraBoleto", Configuration.ApiClient.ParameterToString(flagRegistraBoleto)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling VisualizarDocumento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VisualizarDocumento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Permite visualizar o extrato da fatura em formato PDF Esta opera\u00E7\u00E3o permite visualizar o extrato da fatura de uma determinada conta, em formato PDF. Quando ela for a fatura ativa, ou seja, a do m\u00EAs corrente, o pdf ser\u00E1 composto pelo extrato de lan\u00E7amentos e pela ficha de compensa\u00E7\u00E3o banc\u00E1ria. Quando for de uma fatura do hist\u00F3rico do cliente, o PDF ser\u00E1 composto apenas pelo extrato de transa\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura</param>
        /// <param name="flagApenasDemostrativo">Se o par\u00E2metro for verdadeiro a fatura ser\u00E1 exibida sem o boleto banc\u00E1rio. Caso o par\u00E2metro seja falso ou nulo a fatura ser\u00E1 exibida normalmente, com o boleto banc\u00E1rio (optional)</param>
        /// <param name="flagRegistraBoleto">Se o par\u00E2metro for verdadeiro o boleto banc\u00E1rio ser\u00E1 registrado antes de exibir a fatura. Caso o par\u00E2metro seja falso ou nulo o boleto o recurso n\u00E3o efetuar\u00E1 o registro do boleto banc\u00E1rio (optional)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> VisualizarDocumentoAsync (long? id, string dataVencimento, bool? flagApenasDemostrativo = null, bool? flagRegistraBoleto = null)
        {
             ApiResponse<Object> localVarResponse = await VisualizarDocumentoAsyncWithHttpInfo(id, dataVencimento, flagApenasDemostrativo, flagRegistraBoleto);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite visualizar o extrato da fatura em formato PDF Esta opera\u00E7\u00E3o permite visualizar o extrato da fatura de uma determinada conta, em formato PDF. Quando ela for a fatura ativa, ou seja, a do m\u00EAs corrente, o pdf ser\u00E1 composto pelo extrato de lan\u00E7amentos e pela ficha de compensa\u00E7\u00E3o banc\u00E1ria. Quando for de uma fatura do hist\u00F3rico do cliente, o PDF ser\u00E1 composto apenas pelo extrato de transa\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura</param>
        /// <param name="flagApenasDemostrativo">Se o par\u00E2metro for verdadeiro a fatura ser\u00E1 exibida sem o boleto banc\u00E1rio. Caso o par\u00E2metro seja falso ou nulo a fatura ser\u00E1 exibida normalmente, com o boleto banc\u00E1rio (optional)</param>
        /// <param name="flagRegistraBoleto">Se o par\u00E2metro for verdadeiro o boleto banc\u00E1rio ser\u00E1 registrado antes de exibir a fatura. Caso o par\u00E2metro seja falso ou nulo o boleto o recurso n\u00E3o efetuar\u00E1 o registro do boleto banc\u00E1rio (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> VisualizarDocumentoAsyncWithHttpInfo (long? id, string dataVencimento, bool? flagApenasDemostrativo = null, bool? flagRegistraBoleto = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VisualizarDocumento");
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null) throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling VisualizarDocumento");
            
    
            var localVarPath = "/api/contas/{id}/faturas/{dataVencimento}/arquivo.pdf";
    
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
                "application/pdf"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (dataVencimento != null) localVarPathParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // path parameter
            
            if (flagApenasDemostrativo != null) localVarQueryParams.Add("flagApenasDemostrativo", Configuration.ApiClient.ParameterToString(flagApenasDemostrativo)); // query parameter
            if (flagRegistraBoleto != null) localVarQueryParams.Add("flagRegistraBoleto", Configuration.ApiClient.ParameterToString(flagRegistraBoleto)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling VisualizarDocumento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VisualizarDocumento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
    }
    
}
