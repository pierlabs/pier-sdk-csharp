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
    public interface IOportunidadeApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Altera as oportunidades
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o das oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da oportunidade (id)</param>
        /// <param name="update">update</param>
        /// <returns>OportunidadeResponse</returns>
        OportunidadeResponse AlterarOportunidade (long? id, OportunidadeUpdate update);
  
        /// <summary>
        /// Altera as oportunidades
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o das oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da oportunidade (id)</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of OportunidadeResponse</returns>
        ApiResponse<OportunidadeResponse> AlterarOportunidadeWithHttpInfo (long? id, OportunidadeUpdate update);
        
        /// <summary>
        /// Altera o status do tipo oportunidade
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o do status do tipo oportunidade
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <param name="idStatus">C\u00F3digo de identifica\u00E7\u00E3o do status do tipo oportunidade (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>StatusOportunidadeResponse</returns>
        StatusOportunidadeResponse AlterarStatusTiposOportunidades (long? id, long? idStatus, StatusOportunidade persist);
  
        /// <summary>
        /// Altera o status do tipo oportunidade
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o do status do tipo oportunidade
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <param name="idStatus">C\u00F3digo de identifica\u00E7\u00E3o do status do tipo oportunidade (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of StatusOportunidadeResponse</returns>
        ApiResponse<StatusOportunidadeResponse> AlterarStatusTiposOportunidadesWithHttpInfo (long? id, long? idStatus, StatusOportunidade persist);
        
        /// <summary>
        /// Altera os tipos oportunidades
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o dos tipos oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>TipoOportunidadeResponse</returns>
        TipoOportunidadeResponse AlterarTipoOportunidade (long? id, TipoOportunidade persist);
  
        /// <summary>
        /// Altera os tipos oportunidades
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o dos tipos oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of TipoOportunidadeResponse</returns>
        ApiResponse<TipoOportunidadeResponse> AlterarTipoOportunidadeWithHttpInfo (long? id, TipoOportunidade persist);
        
        /// <summary>
        /// Apresenta dados de uma determinada oportunidade
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de uma determinada oportunidade a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da oportunidade (id)</param>
        /// <returns>OportunidadeResponse</returns>
        OportunidadeResponse ConsultarOportunidade (long? id);
  
        /// <summary>
        /// Apresenta dados de uma determinada oportunidade
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de uma determinada oportunidade a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da oportunidade (id)</param>
        /// <returns>ApiResponse of OportunidadeResponse</returns>
        ApiResponse<OportunidadeResponse> ConsultarOportunidadeWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta dados de um determinado status do tipo oportunidade
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado status do tipo oportunidade a partir de seu codigo de identifica\u00E7\u00E3o (idStatus)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <param name="idStatus">C\u00F3digo de identifica\u00E7\u00E3o do status (idStatus)</param>
        /// <returns>StatusOportunidadeResponse</returns>
        StatusOportunidadeResponse ConsultarStatusTiposOportunidades (long? id, long? idStatus);
  
        /// <summary>
        /// Apresenta dados de um determinado status do tipo oportunidade
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado status do tipo oportunidade a partir de seu codigo de identifica\u00E7\u00E3o (idStatus)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <param name="idStatus">C\u00F3digo de identifica\u00E7\u00E3o do status (idStatus)</param>
        /// <returns>ApiResponse of StatusOportunidadeResponse</returns>
        ApiResponse<StatusOportunidadeResponse> ConsultarStatusTiposOportunidadesWithHttpInfo (long? id, long? idStatus);
        
        /// <summary>
        /// Apresenta dados de um determinado tipo oportunidade
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado tipo oportunidade a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <returns>TipoOportunidadeResponse</returns>
        TipoOportunidadeResponse ConsultarTipoOportunidade (long? id);
  
        /// <summary>
        /// Apresenta dados de um determinado tipo oportunidade
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado tipo oportunidade a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <returns>ApiResponse of TipoOportunidadeResponse</returns>
        ApiResponse<TipoOportunidadeResponse> ConsultarTipoOportunidadeWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista as auditorias das oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as auditorias das oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusOportunidade">C\u00F3digo identificador do status oportunidade (optional)</param>
        /// <param name="dataCadastro">Data do cadastro da oportunidade (optional)</param>
        /// <param name="dataAtualizacao">Data da atualiza\u00E7\u00E3o da oportunidade (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00FAmero receita federal do cliente ao qual ser\u00E1 ofertada a oportunidade (optional)</param>
        /// <param name="dataInicioVigencia">In\u00EDcio da vig\u00EAncia da oportunidade (optional)</param>
        /// <param name="datatFimVigencia">Fim da vig\u00EAncia da oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se a oportunidade est\u00E1 ativa (optional)</param>
        /// <param name="revDate">Data da auditoria (optional)</param>
        /// <param name="revType">Tipo da auditoria (optional)</param>
        /// <param name="revUser">Usu\u00E1rio da auditoria (optional)</param>
        /// <returns>PageOportunidadeAUDResponse</returns>
        PageOportunidadeAUDResponse ListarAuditoriasOportunidades (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string datatFimVigencia = null, bool? flagAtivo = null, string revDate = null, string revType = null, string revUser = null);
  
        /// <summary>
        /// Lista as auditorias das oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as auditorias das oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusOportunidade">C\u00F3digo identificador do status oportunidade (optional)</param>
        /// <param name="dataCadastro">Data do cadastro da oportunidade (optional)</param>
        /// <param name="dataAtualizacao">Data da atualiza\u00E7\u00E3o da oportunidade (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00FAmero receita federal do cliente ao qual ser\u00E1 ofertada a oportunidade (optional)</param>
        /// <param name="dataInicioVigencia">In\u00EDcio da vig\u00EAncia da oportunidade (optional)</param>
        /// <param name="datatFimVigencia">Fim da vig\u00EAncia da oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se a oportunidade est\u00E1 ativa (optional)</param>
        /// <param name="revDate">Data da auditoria (optional)</param>
        /// <param name="revType">Tipo da auditoria (optional)</param>
        /// <param name="revUser">Usu\u00E1rio da auditoria (optional)</param>
        /// <returns>ApiResponse of PageOportunidadeAUDResponse</returns>
        ApiResponse<PageOportunidadeAUDResponse> ListarAuditoriasOportunidadesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string datatFimVigencia = null, bool? flagAtivo = null, string revDate = null, string revType = null, string revUser = null);
        
        /// <summary>
        /// Lista as auditorias dos status oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os status oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="revType">C\u00F3digo que representa o tipo de a\u00E7\u00E3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="revDate">Data da a\u00E7\u00E3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="id">C\u00F3digo identificador do status oportunidade (optional)</param>
        /// <param name="idTipoOportunidade">C\u00F3digo identificador do tipo oportunidade (optional)</param>
        /// <param name="nome">Nome do status oportunidade (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do status oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se o status oportunidade est\u00E1 ativo (optional)</param>
        /// <param name="revUser">Usu\u00E1rio da auditoria (optional)</param>
        /// <returns>PageStatusOportunidadeAUDResponse</returns>
        PageStatusOportunidadeAUDResponse ListarAuditoriasStatusTiposOportunidades (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, long? idTipoOportunidade = null, string nome = null, string descricao = null, bool? flagAtivo = null, string revUser = null);
  
        /// <summary>
        /// Lista as auditorias dos status oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os status oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="revType">C\u00F3digo que representa o tipo de a\u00E7\u00E3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="revDate">Data da a\u00E7\u00E3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="id">C\u00F3digo identificador do status oportunidade (optional)</param>
        /// <param name="idTipoOportunidade">C\u00F3digo identificador do tipo oportunidade (optional)</param>
        /// <param name="nome">Nome do status oportunidade (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do status oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se o status oportunidade est\u00E1 ativo (optional)</param>
        /// <param name="revUser">Usu\u00E1rio da auditoria (optional)</param>
        /// <returns>ApiResponse of PageStatusOportunidadeAUDResponse</returns>
        ApiResponse<PageStatusOportunidadeAUDResponse> ListarAuditoriasStatusTiposOportunidadesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, long? idTipoOportunidade = null, string nome = null, string descricao = null, bool? flagAtivo = null, string revUser = null);
        
        /// <summary>
        /// Lista as auditorias dos tipos oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os tipos oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="revType">C\u00F3digo que representa o tipo de a\u00E7\u00E3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="revDate">Data da a\u00E7\u00E3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="id">C\u00F3digo identificador do tipo oportunidade no qual foi realizado a a\u00E7\u00E3o (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo oportunidade no qual foi realizado a a\u00E7\u00E3o (optional)</param>
        /// <param name="flagAtivo">Atributo que representa se o tipo oportunidade est\u00E1 ativo (optional)</param>
        /// <param name="revUser">Usu\u00E1rio da auditoria (optional)</param>
        /// <returns>PageTipoOportunidadeAUDResponse</returns>
        PageTipoOportunidadeAUDResponse ListarAuditoriasTiposOportunidades (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, string descricao = null, bool? flagAtivo = null, string revUser = null);
  
        /// <summary>
        /// Lista as auditorias dos tipos oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os tipos oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="revType">C\u00F3digo que representa o tipo de a\u00E7\u00E3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="revDate">Data da a\u00E7\u00E3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="id">C\u00F3digo identificador do tipo oportunidade no qual foi realizado a a\u00E7\u00E3o (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo oportunidade no qual foi realizado a a\u00E7\u00E3o (optional)</param>
        /// <param name="flagAtivo">Atributo que representa se o tipo oportunidade est\u00E1 ativo (optional)</param>
        /// <param name="revUser">Usu\u00E1rio da auditoria (optional)</param>
        /// <returns>ApiResponse of PageTipoOportunidadeAUDResponse</returns>
        ApiResponse<PageTipoOportunidadeAUDResponse> ListarAuditoriasTiposOportunidadesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, string descricao = null, bool? flagAtivo = null, string revUser = null);
        
        /// <summary>
        /// Lista as oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusOportunidade">C\u00F3digo identificador do status oportunidade (optional)</param>
        /// <param name="dataCadastro">Data do cadastro da oportunidade (optional)</param>
        /// <param name="dataAtualizacao">Data da atualiza\u00E7\u00E3o da oportunidade (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00FAmero receita federal do cliente ao qual ser\u00E1 ofertada a oportunidade (optional)</param>
        /// <param name="dataInicioVigencia">Data de in\u00EDcio da vig\u00EAncia da oportunidade (optional)</param>
        /// <param name="dataFimVigencia">Data do fim da vig\u00EAncia da oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se a oportunidade est\u00E1 ativa (optional)</param>
        /// <returns>PageOportunidadeResponse</returns>
        PageOportunidadeResponse ListarOportunidades (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string dataFimVigencia = null, bool? flagAtivo = null);
  
        /// <summary>
        /// Lista as oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusOportunidade">C\u00F3digo identificador do status oportunidade (optional)</param>
        /// <param name="dataCadastro">Data do cadastro da oportunidade (optional)</param>
        /// <param name="dataAtualizacao">Data da atualiza\u00E7\u00E3o da oportunidade (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00FAmero receita federal do cliente ao qual ser\u00E1 ofertada a oportunidade (optional)</param>
        /// <param name="dataInicioVigencia">Data de in\u00EDcio da vig\u00EAncia da oportunidade (optional)</param>
        /// <param name="dataFimVigencia">Data do fim da vig\u00EAncia da oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se a oportunidade est\u00E1 ativa (optional)</param>
        /// <returns>ApiResponse of PageOportunidadeResponse</returns>
        ApiResponse<PageOportunidadeResponse> ListarOportunidadesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string dataFimVigencia = null, bool? flagAtivo = null);
        
        /// <summary>
        /// Lista os status do tipo oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os status do tipo oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do status oportunidade (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do status oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se o status oportunidade est\u00E1 ativo (optional)</param>
        /// <returns>PageStatusOportunidadeResponse</returns>
        PageStatusOportunidadeResponse ListarStatusTiposOportunidades (long? id, List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null, bool? flagAtivo = null);
  
        /// <summary>
        /// Lista os status do tipo oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os status do tipo oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do status oportunidade (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do status oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se o status oportunidade est\u00E1 ativo (optional)</param>
        /// <returns>ApiResponse of PageStatusOportunidadeResponse</returns>
        ApiResponse<PageStatusOportunidadeResponse> ListarStatusTiposOportunidadesWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null, bool? flagAtivo = null);
        
        /// <summary>
        /// Lista os tipos oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os tipos oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se o tipo oportunidade est\u00E1 ativo (optional)</param>
        /// <returns>PageTipoOportunidadeResponse</returns>
        PageTipoOportunidadeResponse ListarTiposOportunidades (List<string> sort = null, int? page = null, int? limit = null, string descricao = null, bool? flagAtivo = null);
  
        /// <summary>
        /// Lista os tipos oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os tipos oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se o tipo oportunidade est\u00E1 ativo (optional)</param>
        /// <returns>ApiResponse of PageTipoOportunidadeResponse</returns>
        ApiResponse<PageTipoOportunidadeResponse> ListarTiposOportunidadesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null, bool? flagAtivo = null);
        
        /// <summary>
        /// Cadastra as oportunidades
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>OportunidadeResponse</returns>
        OportunidadeResponse SalvarOportunidade (OportunidadePersist persist);
  
        /// <summary>
        /// Cadastra as oportunidades
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of OportunidadeResponse</returns>
        ApiResponse<OportunidadeResponse> SalvarOportunidadeWithHttpInfo (OportunidadePersist persist);
        
        /// <summary>
        /// Cadastra status para o tipo oportunidade
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar status para o tipo oportunidade
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>StatusOportunidadeResponse</returns>
        StatusOportunidadeResponse SalvarStatusTiposOportunidades (long? id, StatusOportunidade persist);
  
        /// <summary>
        /// Cadastra status para o tipo oportunidade
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar status para o tipo oportunidade
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of StatusOportunidadeResponse</returns>
        ApiResponse<StatusOportunidadeResponse> SalvarStatusTiposOportunidadesWithHttpInfo (long? id, StatusOportunidade persist);
        
        /// <summary>
        /// Cadastra tipos oportunidades
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar tipos oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>TipoOportunidadeResponse</returns>
        TipoOportunidadeResponse SalvarTipoOportunidade (TipoOportunidade persist);
  
        /// <summary>
        /// Cadastra tipos oportunidades
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar tipos oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of TipoOportunidadeResponse</returns>
        ApiResponse<TipoOportunidadeResponse> SalvarTipoOportunidadeWithHttpInfo (TipoOportunidade persist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Altera as oportunidades
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o das oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da oportunidade (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of OportunidadeResponse</returns>
        System.Threading.Tasks.Task<OportunidadeResponse> AlterarOportunidadeAsync (long? id, OportunidadeUpdate update);

        /// <summary>
        /// Altera as oportunidades
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o das oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da oportunidade (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (OportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OportunidadeResponse>> AlterarOportunidadeAsyncWithHttpInfo (long? id, OportunidadeUpdate update);
        
        /// <summary>
        /// Altera o status do tipo oportunidade
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o do status do tipo oportunidade
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <param name="idStatus">C\u00F3digo de identifica\u00E7\u00E3o do status do tipo oportunidade (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of StatusOportunidadeResponse</returns>
        System.Threading.Tasks.Task<StatusOportunidadeResponse> AlterarStatusTiposOportunidadesAsync (long? id, long? idStatus, StatusOportunidade persist);

        /// <summary>
        /// Altera o status do tipo oportunidade
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o do status do tipo oportunidade
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <param name="idStatus">C\u00F3digo de identifica\u00E7\u00E3o do status do tipo oportunidade (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (StatusOportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StatusOportunidadeResponse>> AlterarStatusTiposOportunidadesAsyncWithHttpInfo (long? id, long? idStatus, StatusOportunidade persist);
        
        /// <summary>
        /// Altera os tipos oportunidades
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o dos tipos oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of TipoOportunidadeResponse</returns>
        System.Threading.Tasks.Task<TipoOportunidadeResponse> AlterarTipoOportunidadeAsync (long? id, TipoOportunidade persist);

        /// <summary>
        /// Altera os tipos oportunidades
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o dos tipos oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TipoOportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoOportunidadeResponse>> AlterarTipoOportunidadeAsyncWithHttpInfo (long? id, TipoOportunidade persist);
        
        /// <summary>
        /// Apresenta dados de uma determinada oportunidade
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de uma determinada oportunidade a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da oportunidade (id)</param>
        /// <returns>Task of OportunidadeResponse</returns>
        System.Threading.Tasks.Task<OportunidadeResponse> ConsultarOportunidadeAsync (long? id);

        /// <summary>
        /// Apresenta dados de uma determinada oportunidade
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de uma determinada oportunidade a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da oportunidade (id)</param>
        /// <returns>Task of ApiResponse (OportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OportunidadeResponse>> ConsultarOportunidadeAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta dados de um determinado status do tipo oportunidade
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado status do tipo oportunidade a partir de seu codigo de identifica\u00E7\u00E3o (idStatus)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <param name="idStatus">C\u00F3digo de identifica\u00E7\u00E3o do status (idStatus)</param>
        /// <returns>Task of StatusOportunidadeResponse</returns>
        System.Threading.Tasks.Task<StatusOportunidadeResponse> ConsultarStatusTiposOportunidadesAsync (long? id, long? idStatus);

        /// <summary>
        /// Apresenta dados de um determinado status do tipo oportunidade
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado status do tipo oportunidade a partir de seu codigo de identifica\u00E7\u00E3o (idStatus)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <param name="idStatus">C\u00F3digo de identifica\u00E7\u00E3o do status (idStatus)</param>
        /// <returns>Task of ApiResponse (StatusOportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StatusOportunidadeResponse>> ConsultarStatusTiposOportunidadesAsyncWithHttpInfo (long? id, long? idStatus);
        
        /// <summary>
        /// Apresenta dados de um determinado tipo oportunidade
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado tipo oportunidade a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <returns>Task of TipoOportunidadeResponse</returns>
        System.Threading.Tasks.Task<TipoOportunidadeResponse> ConsultarTipoOportunidadeAsync (long? id);

        /// <summary>
        /// Apresenta dados de um determinado tipo oportunidade
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado tipo oportunidade a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <returns>Task of ApiResponse (TipoOportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoOportunidadeResponse>> ConsultarTipoOportunidadeAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista as auditorias das oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as auditorias das oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusOportunidade">C\u00F3digo identificador do status oportunidade (optional)</param>
        /// <param name="dataCadastro">Data do cadastro da oportunidade (optional)</param>
        /// <param name="dataAtualizacao">Data da atualiza\u00E7\u00E3o da oportunidade (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00FAmero receita federal do cliente ao qual ser\u00E1 ofertada a oportunidade (optional)</param>
        /// <param name="dataInicioVigencia">In\u00EDcio da vig\u00EAncia da oportunidade (optional)</param>
        /// <param name="datatFimVigencia">Fim da vig\u00EAncia da oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se a oportunidade est\u00E1 ativa (optional)</param>
        /// <param name="revDate">Data da auditoria (optional)</param>
        /// <param name="revType">Tipo da auditoria (optional)</param>
        /// <param name="revUser">Usu\u00E1rio da auditoria (optional)</param>
        /// <returns>Task of PageOportunidadeAUDResponse</returns>
        System.Threading.Tasks.Task<PageOportunidadeAUDResponse> ListarAuditoriasOportunidadesAsync (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string datatFimVigencia = null, bool? flagAtivo = null, string revDate = null, string revType = null, string revUser = null);

        /// <summary>
        /// Lista as auditorias das oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as auditorias das oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusOportunidade">C\u00F3digo identificador do status oportunidade (optional)</param>
        /// <param name="dataCadastro">Data do cadastro da oportunidade (optional)</param>
        /// <param name="dataAtualizacao">Data da atualiza\u00E7\u00E3o da oportunidade (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00FAmero receita federal do cliente ao qual ser\u00E1 ofertada a oportunidade (optional)</param>
        /// <param name="dataInicioVigencia">In\u00EDcio da vig\u00EAncia da oportunidade (optional)</param>
        /// <param name="datatFimVigencia">Fim da vig\u00EAncia da oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se a oportunidade est\u00E1 ativa (optional)</param>
        /// <param name="revDate">Data da auditoria (optional)</param>
        /// <param name="revType">Tipo da auditoria (optional)</param>
        /// <param name="revUser">Usu\u00E1rio da auditoria (optional)</param>
        /// <returns>Task of ApiResponse (PageOportunidadeAUDResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageOportunidadeAUDResponse>> ListarAuditoriasOportunidadesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string datatFimVigencia = null, bool? flagAtivo = null, string revDate = null, string revType = null, string revUser = null);
        
        /// <summary>
        /// Lista as auditorias dos status oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os status oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="revType">C\u00F3digo que representa o tipo de a\u00E7\u00E3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="revDate">Data da a\u00E7\u00E3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="id">C\u00F3digo identificador do status oportunidade (optional)</param>
        /// <param name="idTipoOportunidade">C\u00F3digo identificador do tipo oportunidade (optional)</param>
        /// <param name="nome">Nome do status oportunidade (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do status oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se o status oportunidade est\u00E1 ativo (optional)</param>
        /// <param name="revUser">Usu\u00E1rio da auditoria (optional)</param>
        /// <returns>Task of PageStatusOportunidadeAUDResponse</returns>
        System.Threading.Tasks.Task<PageStatusOportunidadeAUDResponse> ListarAuditoriasStatusTiposOportunidadesAsync (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, long? idTipoOportunidade = null, string nome = null, string descricao = null, bool? flagAtivo = null, string revUser = null);

        /// <summary>
        /// Lista as auditorias dos status oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os status oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="revType">C\u00F3digo que representa o tipo de a\u00E7\u00E3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="revDate">Data da a\u00E7\u00E3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="id">C\u00F3digo identificador do status oportunidade (optional)</param>
        /// <param name="idTipoOportunidade">C\u00F3digo identificador do tipo oportunidade (optional)</param>
        /// <param name="nome">Nome do status oportunidade (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do status oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se o status oportunidade est\u00E1 ativo (optional)</param>
        /// <param name="revUser">Usu\u00E1rio da auditoria (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusOportunidadeAUDResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageStatusOportunidadeAUDResponse>> ListarAuditoriasStatusTiposOportunidadesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, long? idTipoOportunidade = null, string nome = null, string descricao = null, bool? flagAtivo = null, string revUser = null);
        
        /// <summary>
        /// Lista as auditorias dos tipos oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os tipos oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="revType">C\u00F3digo que representa o tipo de a\u00E7\u00E3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="revDate">Data da a\u00E7\u00E3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="id">C\u00F3digo identificador do tipo oportunidade no qual foi realizado a a\u00E7\u00E3o (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo oportunidade no qual foi realizado a a\u00E7\u00E3o (optional)</param>
        /// <param name="flagAtivo">Atributo que representa se o tipo oportunidade est\u00E1 ativo (optional)</param>
        /// <param name="revUser">Usu\u00E1rio da auditoria (optional)</param>
        /// <returns>Task of PageTipoOportunidadeAUDResponse</returns>
        System.Threading.Tasks.Task<PageTipoOportunidadeAUDResponse> ListarAuditoriasTiposOportunidadesAsync (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, string descricao = null, bool? flagAtivo = null, string revUser = null);

        /// <summary>
        /// Lista as auditorias dos tipos oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os tipos oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="revType">C\u00F3digo que representa o tipo de a\u00E7\u00E3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="revDate">Data da a\u00E7\u00E3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="id">C\u00F3digo identificador do tipo oportunidade no qual foi realizado a a\u00E7\u00E3o (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo oportunidade no qual foi realizado a a\u00E7\u00E3o (optional)</param>
        /// <param name="flagAtivo">Atributo que representa se o tipo oportunidade est\u00E1 ativo (optional)</param>
        /// <param name="revUser">Usu\u00E1rio da auditoria (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoOportunidadeAUDResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoOportunidadeAUDResponse>> ListarAuditoriasTiposOportunidadesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, string descricao = null, bool? flagAtivo = null, string revUser = null);
        
        /// <summary>
        /// Lista as oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusOportunidade">C\u00F3digo identificador do status oportunidade (optional)</param>
        /// <param name="dataCadastro">Data do cadastro da oportunidade (optional)</param>
        /// <param name="dataAtualizacao">Data da atualiza\u00E7\u00E3o da oportunidade (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00FAmero receita federal do cliente ao qual ser\u00E1 ofertada a oportunidade (optional)</param>
        /// <param name="dataInicioVigencia">Data de in\u00EDcio da vig\u00EAncia da oportunidade (optional)</param>
        /// <param name="dataFimVigencia">Data do fim da vig\u00EAncia da oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se a oportunidade est\u00E1 ativa (optional)</param>
        /// <returns>Task of PageOportunidadeResponse</returns>
        System.Threading.Tasks.Task<PageOportunidadeResponse> ListarOportunidadesAsync (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string dataFimVigencia = null, bool? flagAtivo = null);

        /// <summary>
        /// Lista as oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusOportunidade">C\u00F3digo identificador do status oportunidade (optional)</param>
        /// <param name="dataCadastro">Data do cadastro da oportunidade (optional)</param>
        /// <param name="dataAtualizacao">Data da atualiza\u00E7\u00E3o da oportunidade (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00FAmero receita federal do cliente ao qual ser\u00E1 ofertada a oportunidade (optional)</param>
        /// <param name="dataInicioVigencia">Data de in\u00EDcio da vig\u00EAncia da oportunidade (optional)</param>
        /// <param name="dataFimVigencia">Data do fim da vig\u00EAncia da oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se a oportunidade est\u00E1 ativa (optional)</param>
        /// <returns>Task of ApiResponse (PageOportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageOportunidadeResponse>> ListarOportunidadesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string dataFimVigencia = null, bool? flagAtivo = null);
        
        /// <summary>
        /// Lista os status do tipo oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os status do tipo oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do status oportunidade (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do status oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se o status oportunidade est\u00E1 ativo (optional)</param>
        /// <returns>Task of PageStatusOportunidadeResponse</returns>
        System.Threading.Tasks.Task<PageStatusOportunidadeResponse> ListarStatusTiposOportunidadesAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null, bool? flagAtivo = null);

        /// <summary>
        /// Lista os status do tipo oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os status do tipo oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do status oportunidade (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do status oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se o status oportunidade est\u00E1 ativo (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusOportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageStatusOportunidadeResponse>> ListarStatusTiposOportunidadesAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null, bool? flagAtivo = null);
        
        /// <summary>
        /// Lista os tipos oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os tipos oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se o tipo oportunidade est\u00E1 ativo (optional)</param>
        /// <returns>Task of PageTipoOportunidadeResponse</returns>
        System.Threading.Tasks.Task<PageTipoOportunidadeResponse> ListarTiposOportunidadesAsync (List<string> sort = null, int? page = null, int? limit = null, string descricao = null, bool? flagAtivo = null);

        /// <summary>
        /// Lista os tipos oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os tipos oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se o tipo oportunidade est\u00E1 ativo (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoOportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoOportunidadeResponse>> ListarTiposOportunidadesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null, bool? flagAtivo = null);
        
        /// <summary>
        /// Cadastra as oportunidades
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of OportunidadeResponse</returns>
        System.Threading.Tasks.Task<OportunidadeResponse> SalvarOportunidadeAsync (OportunidadePersist persist);

        /// <summary>
        /// Cadastra as oportunidades
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (OportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OportunidadeResponse>> SalvarOportunidadeAsyncWithHttpInfo (OportunidadePersist persist);
        
        /// <summary>
        /// Cadastra status para o tipo oportunidade
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar status para o tipo oportunidade
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of StatusOportunidadeResponse</returns>
        System.Threading.Tasks.Task<StatusOportunidadeResponse> SalvarStatusTiposOportunidadesAsync (long? id, StatusOportunidade persist);

        /// <summary>
        /// Cadastra status para o tipo oportunidade
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar status para o tipo oportunidade
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (StatusOportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StatusOportunidadeResponse>> SalvarStatusTiposOportunidadesAsyncWithHttpInfo (long? id, StatusOportunidade persist);
        
        /// <summary>
        /// Cadastra tipos oportunidades
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar tipos oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of TipoOportunidadeResponse</returns>
        System.Threading.Tasks.Task<TipoOportunidadeResponse> SalvarTipoOportunidadeAsync (TipoOportunidade persist);

        /// <summary>
        /// Cadastra tipos oportunidades
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar tipos oportunidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TipoOportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoOportunidadeResponse>> SalvarTipoOportunidadeAsyncWithHttpInfo (TipoOportunidade persist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OportunidadeApi : IOportunidadeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OportunidadeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OportunidadeApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OportunidadeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OportunidadeApi(Configuration configuration = null)
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
        /// Altera as oportunidades Este m\u00E9todo realiza a altera\u00E7\u00E3o das oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da oportunidade (id)</param> 
        /// <param name="update">update</param> 
        /// <returns>OportunidadeResponse</returns>
        public OportunidadeResponse AlterarOportunidade (long? id, OportunidadeUpdate update)
        {
             ApiResponse<OportunidadeResponse> localVarResponse = AlterarOportunidadeWithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera as oportunidades Este m\u00E9todo realiza a altera\u00E7\u00E3o das oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da oportunidade (id)</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of OportunidadeResponse</returns>
        public ApiResponse< OportunidadeResponse > AlterarOportunidadeWithHttpInfo (long? id, OportunidadeUpdate update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OportunidadeApi->AlterarOportunidade");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling OportunidadeApi->AlterarOportunidade");
            
    
            var localVarPath = "/api/oportunidades/{id}";
    
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarOportunidade: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarOportunidade: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OportunidadeResponse)));
            
        }

        
        /// <summary>
        /// Altera as oportunidades Este m\u00E9todo realiza a altera\u00E7\u00E3o das oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da oportunidade (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of OportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<OportunidadeResponse> AlterarOportunidadeAsync (long? id, OportunidadeUpdate update)
        {
             ApiResponse<OportunidadeResponse> localVarResponse = await AlterarOportunidadeAsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera as oportunidades Este m\u00E9todo realiza a altera\u00E7\u00E3o das oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da oportunidade (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (OportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OportunidadeResponse>> AlterarOportunidadeAsyncWithHttpInfo (long? id, OportunidadeUpdate update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarOportunidade");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AlterarOportunidade");
            
    
            var localVarPath = "/api/oportunidades/{id}";
    
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarOportunidade: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarOportunidade: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OportunidadeResponse)));
            
        }
        
        /// <summary>
        /// Altera o status do tipo oportunidade Este m\u00E9todo realiza a altera\u00E7\u00E3o do status do tipo oportunidade
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param> 
        /// <param name="idStatus">C\u00F3digo de identifica\u00E7\u00E3o do status do tipo oportunidade (id)</param> 
        /// <param name="persist">persist</param> 
        /// <returns>StatusOportunidadeResponse</returns>
        public StatusOportunidadeResponse AlterarStatusTiposOportunidades (long? id, long? idStatus, StatusOportunidade persist)
        {
             ApiResponse<StatusOportunidadeResponse> localVarResponse = AlterarStatusTiposOportunidadesWithHttpInfo(id, idStatus, persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera o status do tipo oportunidade Este m\u00E9todo realiza a altera\u00E7\u00E3o do status do tipo oportunidade
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param> 
        /// <param name="idStatus">C\u00F3digo de identifica\u00E7\u00E3o do status do tipo oportunidade (id)</param> 
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of StatusOportunidadeResponse</returns>
        public ApiResponse< StatusOportunidadeResponse > AlterarStatusTiposOportunidadesWithHttpInfo (long? id, long? idStatus, StatusOportunidade persist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OportunidadeApi->AlterarStatusTiposOportunidades");
            
            // verify the required parameter 'idStatus' is set
            if (idStatus == null)
                throw new ApiException(400, "Missing required parameter 'idStatus' when calling OportunidadeApi->AlterarStatusTiposOportunidades");
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling OportunidadeApi->AlterarStatusTiposOportunidades");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}/status/{idStatus}";
    
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
            if (idStatus != null) localVarPathParams.Add("idStatus", Configuration.ApiClient.ParameterToString(idStatus)); // path parameter
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatusTiposOportunidades: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatusTiposOportunidades: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<StatusOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusOportunidadeResponse)));
            
        }

        
        /// <summary>
        /// Altera o status do tipo oportunidade Este m\u00E9todo realiza a altera\u00E7\u00E3o do status do tipo oportunidade
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <param name="idStatus">C\u00F3digo de identifica\u00E7\u00E3o do status do tipo oportunidade (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of StatusOportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<StatusOportunidadeResponse> AlterarStatusTiposOportunidadesAsync (long? id, long? idStatus, StatusOportunidade persist)
        {
             ApiResponse<StatusOportunidadeResponse> localVarResponse = await AlterarStatusTiposOportunidadesAsyncWithHttpInfo(id, idStatus, persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera o status do tipo oportunidade Este m\u00E9todo realiza a altera\u00E7\u00E3o do status do tipo oportunidade
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <param name="idStatus">C\u00F3digo de identifica\u00E7\u00E3o do status do tipo oportunidade (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (StatusOportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StatusOportunidadeResponse>> AlterarStatusTiposOportunidadesAsyncWithHttpInfo (long? id, long? idStatus, StatusOportunidade persist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarStatusTiposOportunidades");
            // verify the required parameter 'idStatus' is set
            if (idStatus == null) throw new ApiException(400, "Missing required parameter 'idStatus' when calling AlterarStatusTiposOportunidades");
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling AlterarStatusTiposOportunidades");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}/status/{idStatus}";
    
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
            if (idStatus != null) localVarPathParams.Add("idStatus", Configuration.ApiClient.ParameterToString(idStatus)); // path parameter
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatusTiposOportunidades: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatusTiposOportunidades: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StatusOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusOportunidadeResponse)));
            
        }
        
        /// <summary>
        /// Altera os tipos oportunidades Este m\u00E9todo realiza a altera\u00E7\u00E3o dos tipos oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do tipo oportunidade (id)</param> 
        /// <param name="persist">persist</param> 
        /// <returns>TipoOportunidadeResponse</returns>
        public TipoOportunidadeResponse AlterarTipoOportunidade (long? id, TipoOportunidade persist)
        {
             ApiResponse<TipoOportunidadeResponse> localVarResponse = AlterarTipoOportunidadeWithHttpInfo(id, persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera os tipos oportunidades Este m\u00E9todo realiza a altera\u00E7\u00E3o dos tipos oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do tipo oportunidade (id)</param> 
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of TipoOportunidadeResponse</returns>
        public ApiResponse< TipoOportunidadeResponse > AlterarTipoOportunidadeWithHttpInfo (long? id, TipoOportunidade persist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OportunidadeApi->AlterarTipoOportunidade");
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling OportunidadeApi->AlterarTipoOportunidade");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTipoOportunidade: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTipoOportunidade: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoOportunidadeResponse)));
            
        }

        
        /// <summary>
        /// Altera os tipos oportunidades Este m\u00E9todo realiza a altera\u00E7\u00E3o dos tipos oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of TipoOportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<TipoOportunidadeResponse> AlterarTipoOportunidadeAsync (long? id, TipoOportunidade persist)
        {
             ApiResponse<TipoOportunidadeResponse> localVarResponse = await AlterarTipoOportunidadeAsyncWithHttpInfo(id, persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera os tipos oportunidades Este m\u00E9todo realiza a altera\u00E7\u00E3o dos tipos oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TipoOportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoOportunidadeResponse>> AlterarTipoOportunidadeAsyncWithHttpInfo (long? id, TipoOportunidade persist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarTipoOportunidade");
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling AlterarTipoOportunidade");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTipoOportunidade: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTipoOportunidade: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoOportunidadeResponse)));
            
        }
        
        /// <summary>
        /// Apresenta dados de uma determinada oportunidade Este recurso permite consultar dados de uma determinada oportunidade a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da oportunidade (id)</param> 
        /// <returns>OportunidadeResponse</returns>
        public OportunidadeResponse ConsultarOportunidade (long? id)
        {
             ApiResponse<OportunidadeResponse> localVarResponse = ConsultarOportunidadeWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta dados de uma determinada oportunidade Este recurso permite consultar dados de uma determinada oportunidade a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da oportunidade (id)</param> 
        /// <returns>ApiResponse of OportunidadeResponse</returns>
        public ApiResponse< OportunidadeResponse > ConsultarOportunidadeWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OportunidadeApi->ConsultarOportunidade");
            
    
            var localVarPath = "/api/oportunidades/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarOportunidade: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarOportunidade: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OportunidadeResponse)));
            
        }

        
        /// <summary>
        /// Apresenta dados de uma determinada oportunidade Este recurso permite consultar dados de uma determinada oportunidade a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da oportunidade (id)</param>
        /// <returns>Task of OportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<OportunidadeResponse> ConsultarOportunidadeAsync (long? id)
        {
             ApiResponse<OportunidadeResponse> localVarResponse = await ConsultarOportunidadeAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta dados de uma determinada oportunidade Este recurso permite consultar dados de uma determinada oportunidade a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da oportunidade (id)</param>
        /// <returns>Task of ApiResponse (OportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OportunidadeResponse>> ConsultarOportunidadeAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarOportunidade");
            
    
            var localVarPath = "/api/oportunidades/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarOportunidade: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarOportunidade: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OportunidadeResponse)));
            
        }
        
        /// <summary>
        /// Apresenta dados de um determinado status do tipo oportunidade Este recurso permite consultar dados de um determinado status do tipo oportunidade a partir de seu codigo de identifica\u00E7\u00E3o (idStatus)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param> 
        /// <param name="idStatus">C\u00F3digo de identifica\u00E7\u00E3o do status (idStatus)</param> 
        /// <returns>StatusOportunidadeResponse</returns>
        public StatusOportunidadeResponse ConsultarStatusTiposOportunidades (long? id, long? idStatus)
        {
             ApiResponse<StatusOportunidadeResponse> localVarResponse = ConsultarStatusTiposOportunidadesWithHttpInfo(id, idStatus);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta dados de um determinado status do tipo oportunidade Este recurso permite consultar dados de um determinado status do tipo oportunidade a partir de seu codigo de identifica\u00E7\u00E3o (idStatus)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param> 
        /// <param name="idStatus">C\u00F3digo de identifica\u00E7\u00E3o do status (idStatus)</param> 
        /// <returns>ApiResponse of StatusOportunidadeResponse</returns>
        public ApiResponse< StatusOportunidadeResponse > ConsultarStatusTiposOportunidadesWithHttpInfo (long? id, long? idStatus)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OportunidadeApi->ConsultarStatusTiposOportunidades");
            
            // verify the required parameter 'idStatus' is set
            if (idStatus == null)
                throw new ApiException(400, "Missing required parameter 'idStatus' when calling OportunidadeApi->ConsultarStatusTiposOportunidades");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}/status/{idStatus}";
    
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
            if (idStatus != null) localVarPathParams.Add("idStatus", Configuration.ApiClient.ParameterToString(idStatus)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusTiposOportunidades: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusTiposOportunidades: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<StatusOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusOportunidadeResponse)));
            
        }

        
        /// <summary>
        /// Apresenta dados de um determinado status do tipo oportunidade Este recurso permite consultar dados de um determinado status do tipo oportunidade a partir de seu codigo de identifica\u00E7\u00E3o (idStatus)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <param name="idStatus">C\u00F3digo de identifica\u00E7\u00E3o do status (idStatus)</param>
        /// <returns>Task of StatusOportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<StatusOportunidadeResponse> ConsultarStatusTiposOportunidadesAsync (long? id, long? idStatus)
        {
             ApiResponse<StatusOportunidadeResponse> localVarResponse = await ConsultarStatusTiposOportunidadesAsyncWithHttpInfo(id, idStatus);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta dados de um determinado status do tipo oportunidade Este recurso permite consultar dados de um determinado status do tipo oportunidade a partir de seu codigo de identifica\u00E7\u00E3o (idStatus)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <param name="idStatus">C\u00F3digo de identifica\u00E7\u00E3o do status (idStatus)</param>
        /// <returns>Task of ApiResponse (StatusOportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StatusOportunidadeResponse>> ConsultarStatusTiposOportunidadesAsyncWithHttpInfo (long? id, long? idStatus)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarStatusTiposOportunidades");
            // verify the required parameter 'idStatus' is set
            if (idStatus == null) throw new ApiException(400, "Missing required parameter 'idStatus' when calling ConsultarStatusTiposOportunidades");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}/status/{idStatus}";
    
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
            if (idStatus != null) localVarPathParams.Add("idStatus", Configuration.ApiClient.ParameterToString(idStatus)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusTiposOportunidades: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusTiposOportunidades: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StatusOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusOportunidadeResponse)));
            
        }
        
        /// <summary>
        /// Apresenta dados de um determinado tipo oportunidade Este recurso permite consultar dados de um determinado tipo oportunidade a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param> 
        /// <returns>TipoOportunidadeResponse</returns>
        public TipoOportunidadeResponse ConsultarTipoOportunidade (long? id)
        {
             ApiResponse<TipoOportunidadeResponse> localVarResponse = ConsultarTipoOportunidadeWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta dados de um determinado tipo oportunidade Este recurso permite consultar dados de um determinado tipo oportunidade a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param> 
        /// <returns>ApiResponse of TipoOportunidadeResponse</returns>
        public ApiResponse< TipoOportunidadeResponse > ConsultarTipoOportunidadeWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OportunidadeApi->ConsultarTipoOportunidade");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTipoOportunidade: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTipoOportunidade: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoOportunidadeResponse)));
            
        }

        
        /// <summary>
        /// Apresenta dados de um determinado tipo oportunidade Este recurso permite consultar dados de um determinado tipo oportunidade a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <returns>Task of TipoOportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<TipoOportunidadeResponse> ConsultarTipoOportunidadeAsync (long? id)
        {
             ApiResponse<TipoOportunidadeResponse> localVarResponse = await ConsultarTipoOportunidadeAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta dados de um determinado tipo oportunidade Este recurso permite consultar dados de um determinado tipo oportunidade a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <returns>Task of ApiResponse (TipoOportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoOportunidadeResponse>> ConsultarTipoOportunidadeAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarTipoOportunidade");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTipoOportunidade: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTipoOportunidade: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoOportunidadeResponse)));
            
        }
        
        /// <summary>
        /// Lista as auditorias das oportunidades Este recurso permite listar as auditorias das oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idStatusOportunidade">C\u00F3digo identificador do status oportunidade (optional)</param> 
        /// <param name="dataCadastro">Data do cadastro da oportunidade (optional)</param> 
        /// <param name="dataAtualizacao">Data da atualiza\u00E7\u00E3o da oportunidade (optional)</param> 
        /// <param name="numeroReceitaFederal">N\u00FAmero receita federal do cliente ao qual ser\u00E1 ofertada a oportunidade (optional)</param> 
        /// <param name="dataInicioVigencia">In\u00EDcio da vig\u00EAncia da oportunidade (optional)</param> 
        /// <param name="datatFimVigencia">Fim da vig\u00EAncia da oportunidade (optional)</param> 
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se a oportunidade est\u00E1 ativa (optional)</param> 
        /// <param name="revDate">Data da auditoria (optional)</param> 
        /// <param name="revType">Tipo da auditoria (optional)</param> 
        /// <param name="revUser">Usu\u00E1rio da auditoria (optional)</param> 
        /// <returns>PageOportunidadeAUDResponse</returns>
        public PageOportunidadeAUDResponse ListarAuditoriasOportunidades (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string datatFimVigencia = null, bool? flagAtivo = null, string revDate = null, string revType = null, string revUser = null)
        {
             ApiResponse<PageOportunidadeAUDResponse> localVarResponse = ListarAuditoriasOportunidadesWithHttpInfo(sort, page, limit, idStatusOportunidade, dataCadastro, dataAtualizacao, numeroReceitaFederal, dataInicioVigencia, datatFimVigencia, flagAtivo, revDate, revType, revUser);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as auditorias das oportunidades Este recurso permite listar as auditorias das oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idStatusOportunidade">C\u00F3digo identificador do status oportunidade (optional)</param> 
        /// <param name="dataCadastro">Data do cadastro da oportunidade (optional)</param> 
        /// <param name="dataAtualizacao">Data da atualiza\u00E7\u00E3o da oportunidade (optional)</param> 
        /// <param name="numeroReceitaFederal">N\u00FAmero receita federal do cliente ao qual ser\u00E1 ofertada a oportunidade (optional)</param> 
        /// <param name="dataInicioVigencia">In\u00EDcio da vig\u00EAncia da oportunidade (optional)</param> 
        /// <param name="datatFimVigencia">Fim da vig\u00EAncia da oportunidade (optional)</param> 
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se a oportunidade est\u00E1 ativa (optional)</param> 
        /// <param name="revDate">Data da auditoria (optional)</param> 
        /// <param name="revType">Tipo da auditoria (optional)</param> 
        /// <param name="revUser">Usu\u00E1rio da auditoria (optional)</param> 
        /// <returns>ApiResponse of PageOportunidadeAUDResponse</returns>
        public ApiResponse< PageOportunidadeAUDResponse > ListarAuditoriasOportunidadesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string datatFimVigencia = null, bool? flagAtivo = null, string revDate = null, string revType = null, string revUser = null)
        {
            
    
            var localVarPath = "/api/auditorias-oportunidades";
    
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
            if (idStatusOportunidade != null) localVarQueryParams.Add("idStatusOportunidade", Configuration.ApiClient.ParameterToString(idStatusOportunidade)); // query parameter
            if (dataCadastro != null) localVarQueryParams.Add("dataCadastro", Configuration.ApiClient.ParameterToString(dataCadastro)); // query parameter
            if (dataAtualizacao != null) localVarQueryParams.Add("dataAtualizacao", Configuration.ApiClient.ParameterToString(dataAtualizacao)); // query parameter
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (dataInicioVigencia != null) localVarQueryParams.Add("dataInicioVigencia", Configuration.ApiClient.ParameterToString(dataInicioVigencia)); // query parameter
            if (datatFimVigencia != null) localVarQueryParams.Add("datatFimVigencia", Configuration.ApiClient.ParameterToString(datatFimVigencia)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            if (revDate != null) localVarQueryParams.Add("revDate", Configuration.ApiClient.ParameterToString(revDate)); // query parameter
            if (revType != null) localVarQueryParams.Add("revType", Configuration.ApiClient.ParameterToString(revType)); // query parameter
            if (revUser != null) localVarQueryParams.Add("revUser", Configuration.ApiClient.ParameterToString(revUser)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditoriasOportunidades: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditoriasOportunidades: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageOportunidadeAUDResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOportunidadeAUDResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOportunidadeAUDResponse)));
            
        }

        
        /// <summary>
        /// Lista as auditorias das oportunidades Este recurso permite listar as auditorias das oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusOportunidade">C\u00F3digo identificador do status oportunidade (optional)</param>
        /// <param name="dataCadastro">Data do cadastro da oportunidade (optional)</param>
        /// <param name="dataAtualizacao">Data da atualiza\u00E7\u00E3o da oportunidade (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00FAmero receita federal do cliente ao qual ser\u00E1 ofertada a oportunidade (optional)</param>
        /// <param name="dataInicioVigencia">In\u00EDcio da vig\u00EAncia da oportunidade (optional)</param>
        /// <param name="datatFimVigencia">Fim da vig\u00EAncia da oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se a oportunidade est\u00E1 ativa (optional)</param>
        /// <param name="revDate">Data da auditoria (optional)</param>
        /// <param name="revType">Tipo da auditoria (optional)</param>
        /// <param name="revUser">Usu\u00E1rio da auditoria (optional)</param>
        /// <returns>Task of PageOportunidadeAUDResponse</returns>
        public async System.Threading.Tasks.Task<PageOportunidadeAUDResponse> ListarAuditoriasOportunidadesAsync (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string datatFimVigencia = null, bool? flagAtivo = null, string revDate = null, string revType = null, string revUser = null)
        {
             ApiResponse<PageOportunidadeAUDResponse> localVarResponse = await ListarAuditoriasOportunidadesAsyncWithHttpInfo(sort, page, limit, idStatusOportunidade, dataCadastro, dataAtualizacao, numeroReceitaFederal, dataInicioVigencia, datatFimVigencia, flagAtivo, revDate, revType, revUser);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as auditorias das oportunidades Este recurso permite listar as auditorias das oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusOportunidade">C\u00F3digo identificador do status oportunidade (optional)</param>
        /// <param name="dataCadastro">Data do cadastro da oportunidade (optional)</param>
        /// <param name="dataAtualizacao">Data da atualiza\u00E7\u00E3o da oportunidade (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00FAmero receita federal do cliente ao qual ser\u00E1 ofertada a oportunidade (optional)</param>
        /// <param name="dataInicioVigencia">In\u00EDcio da vig\u00EAncia da oportunidade (optional)</param>
        /// <param name="datatFimVigencia">Fim da vig\u00EAncia da oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se a oportunidade est\u00E1 ativa (optional)</param>
        /// <param name="revDate">Data da auditoria (optional)</param>
        /// <param name="revType">Tipo da auditoria (optional)</param>
        /// <param name="revUser">Usu\u00E1rio da auditoria (optional)</param>
        /// <returns>Task of ApiResponse (PageOportunidadeAUDResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageOportunidadeAUDResponse>> ListarAuditoriasOportunidadesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string datatFimVigencia = null, bool? flagAtivo = null, string revDate = null, string revType = null, string revUser = null)
        {
            
    
            var localVarPath = "/api/auditorias-oportunidades";
    
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
            if (idStatusOportunidade != null) localVarQueryParams.Add("idStatusOportunidade", Configuration.ApiClient.ParameterToString(idStatusOportunidade)); // query parameter
            if (dataCadastro != null) localVarQueryParams.Add("dataCadastro", Configuration.ApiClient.ParameterToString(dataCadastro)); // query parameter
            if (dataAtualizacao != null) localVarQueryParams.Add("dataAtualizacao", Configuration.ApiClient.ParameterToString(dataAtualizacao)); // query parameter
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (dataInicioVigencia != null) localVarQueryParams.Add("dataInicioVigencia", Configuration.ApiClient.ParameterToString(dataInicioVigencia)); // query parameter
            if (datatFimVigencia != null) localVarQueryParams.Add("datatFimVigencia", Configuration.ApiClient.ParameterToString(datatFimVigencia)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            if (revDate != null) localVarQueryParams.Add("revDate", Configuration.ApiClient.ParameterToString(revDate)); // query parameter
            if (revType != null) localVarQueryParams.Add("revType", Configuration.ApiClient.ParameterToString(revType)); // query parameter
            if (revUser != null) localVarQueryParams.Add("revUser", Configuration.ApiClient.ParameterToString(revUser)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditoriasOportunidades: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditoriasOportunidades: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageOportunidadeAUDResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOportunidadeAUDResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOportunidadeAUDResponse)));
            
        }
        
        /// <summary>
        /// Lista as auditorias dos status oportunidades Este recurso permite listar os status oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="revType">C\u00F3digo que representa o tipo de a\u00E7\u00E3o realizada no recurso de tipos oportunidades (optional)</param> 
        /// <param name="revDate">Data da a\u00E7\u00E3o realizada no recurso de tipos oportunidades (optional)</param> 
        /// <param name="id">C\u00F3digo identificador do status oportunidade (optional)</param> 
        /// <param name="idTipoOportunidade">C\u00F3digo identificador do tipo oportunidade (optional)</param> 
        /// <param name="nome">Nome do status oportunidade (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do status oportunidade (optional)</param> 
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se o status oportunidade est\u00E1 ativo (optional)</param> 
        /// <param name="revUser">Usu\u00E1rio da auditoria (optional)</param> 
        /// <returns>PageStatusOportunidadeAUDResponse</returns>
        public PageStatusOportunidadeAUDResponse ListarAuditoriasStatusTiposOportunidades (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, long? idTipoOportunidade = null, string nome = null, string descricao = null, bool? flagAtivo = null, string revUser = null)
        {
             ApiResponse<PageStatusOportunidadeAUDResponse> localVarResponse = ListarAuditoriasStatusTiposOportunidadesWithHttpInfo(sort, page, limit, revType, revDate, id, idTipoOportunidade, nome, descricao, flagAtivo, revUser);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as auditorias dos status oportunidades Este recurso permite listar os status oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="revType">C\u00F3digo que representa o tipo de a\u00E7\u00E3o realizada no recurso de tipos oportunidades (optional)</param> 
        /// <param name="revDate">Data da a\u00E7\u00E3o realizada no recurso de tipos oportunidades (optional)</param> 
        /// <param name="id">C\u00F3digo identificador do status oportunidade (optional)</param> 
        /// <param name="idTipoOportunidade">C\u00F3digo identificador do tipo oportunidade (optional)</param> 
        /// <param name="nome">Nome do status oportunidade (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do status oportunidade (optional)</param> 
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se o status oportunidade est\u00E1 ativo (optional)</param> 
        /// <param name="revUser">Usu\u00E1rio da auditoria (optional)</param> 
        /// <returns>ApiResponse of PageStatusOportunidadeAUDResponse</returns>
        public ApiResponse< PageStatusOportunidadeAUDResponse > ListarAuditoriasStatusTiposOportunidadesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, long? idTipoOportunidade = null, string nome = null, string descricao = null, bool? flagAtivo = null, string revUser = null)
        {
            
    
            var localVarPath = "/api/auditorias-status-oportunidades";
    
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
            if (revType != null) localVarQueryParams.Add("revType", Configuration.ApiClient.ParameterToString(revType)); // query parameter
            if (revDate != null) localVarQueryParams.Add("revDate", Configuration.ApiClient.ParameterToString(revDate)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (idTipoOportunidade != null) localVarQueryParams.Add("idTipoOportunidade", Configuration.ApiClient.ParameterToString(idTipoOportunidade)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            if (revUser != null) localVarQueryParams.Add("revUser", Configuration.ApiClient.ParameterToString(revUser)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditoriasStatusTiposOportunidades: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditoriasStatusTiposOportunidades: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageStatusOportunidadeAUDResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusOportunidadeAUDResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusOportunidadeAUDResponse)));
            
        }

        
        /// <summary>
        /// Lista as auditorias dos status oportunidades Este recurso permite listar os status oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="revType">C\u00F3digo que representa o tipo de a\u00E7\u00E3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="revDate">Data da a\u00E7\u00E3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="id">C\u00F3digo identificador do status oportunidade (optional)</param>
        /// <param name="idTipoOportunidade">C\u00F3digo identificador do tipo oportunidade (optional)</param>
        /// <param name="nome">Nome do status oportunidade (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do status oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se o status oportunidade est\u00E1 ativo (optional)</param>
        /// <param name="revUser">Usu\u00E1rio da auditoria (optional)</param>
        /// <returns>Task of PageStatusOportunidadeAUDResponse</returns>
        public async System.Threading.Tasks.Task<PageStatusOportunidadeAUDResponse> ListarAuditoriasStatusTiposOportunidadesAsync (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, long? idTipoOportunidade = null, string nome = null, string descricao = null, bool? flagAtivo = null, string revUser = null)
        {
             ApiResponse<PageStatusOportunidadeAUDResponse> localVarResponse = await ListarAuditoriasStatusTiposOportunidadesAsyncWithHttpInfo(sort, page, limit, revType, revDate, id, idTipoOportunidade, nome, descricao, flagAtivo, revUser);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as auditorias dos status oportunidades Este recurso permite listar os status oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="revType">C\u00F3digo que representa o tipo de a\u00E7\u00E3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="revDate">Data da a\u00E7\u00E3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="id">C\u00F3digo identificador do status oportunidade (optional)</param>
        /// <param name="idTipoOportunidade">C\u00F3digo identificador do tipo oportunidade (optional)</param>
        /// <param name="nome">Nome do status oportunidade (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do status oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se o status oportunidade est\u00E1 ativo (optional)</param>
        /// <param name="revUser">Usu\u00E1rio da auditoria (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusOportunidadeAUDResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageStatusOportunidadeAUDResponse>> ListarAuditoriasStatusTiposOportunidadesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, long? idTipoOportunidade = null, string nome = null, string descricao = null, bool? flagAtivo = null, string revUser = null)
        {
            
    
            var localVarPath = "/api/auditorias-status-oportunidades";
    
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
            if (revType != null) localVarQueryParams.Add("revType", Configuration.ApiClient.ParameterToString(revType)); // query parameter
            if (revDate != null) localVarQueryParams.Add("revDate", Configuration.ApiClient.ParameterToString(revDate)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (idTipoOportunidade != null) localVarQueryParams.Add("idTipoOportunidade", Configuration.ApiClient.ParameterToString(idTipoOportunidade)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            if (revUser != null) localVarQueryParams.Add("revUser", Configuration.ApiClient.ParameterToString(revUser)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditoriasStatusTiposOportunidades: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditoriasStatusTiposOportunidades: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageStatusOportunidadeAUDResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusOportunidadeAUDResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusOportunidadeAUDResponse)));
            
        }
        
        /// <summary>
        /// Lista as auditorias dos tipos oportunidades Este recurso permite listar os tipos oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="revType">C\u00F3digo que representa o tipo de a\u00E7\u00E3o realizada no recurso de tipos oportunidades (optional)</param> 
        /// <param name="revDate">Data da a\u00E7\u00E3o realizada no recurso de tipos oportunidades (optional)</param> 
        /// <param name="id">C\u00F3digo identificador do tipo oportunidade no qual foi realizado a a\u00E7\u00E3o (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo oportunidade no qual foi realizado a a\u00E7\u00E3o (optional)</param> 
        /// <param name="flagAtivo">Atributo que representa se o tipo oportunidade est\u00E1 ativo (optional)</param> 
        /// <param name="revUser">Usu\u00E1rio da auditoria (optional)</param> 
        /// <returns>PageTipoOportunidadeAUDResponse</returns>
        public PageTipoOportunidadeAUDResponse ListarAuditoriasTiposOportunidades (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, string descricao = null, bool? flagAtivo = null, string revUser = null)
        {
             ApiResponse<PageTipoOportunidadeAUDResponse> localVarResponse = ListarAuditoriasTiposOportunidadesWithHttpInfo(sort, page, limit, revType, revDate, id, descricao, flagAtivo, revUser);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as auditorias dos tipos oportunidades Este recurso permite listar os tipos oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="revType">C\u00F3digo que representa o tipo de a\u00E7\u00E3o realizada no recurso de tipos oportunidades (optional)</param> 
        /// <param name="revDate">Data da a\u00E7\u00E3o realizada no recurso de tipos oportunidades (optional)</param> 
        /// <param name="id">C\u00F3digo identificador do tipo oportunidade no qual foi realizado a a\u00E7\u00E3o (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo oportunidade no qual foi realizado a a\u00E7\u00E3o (optional)</param> 
        /// <param name="flagAtivo">Atributo que representa se o tipo oportunidade est\u00E1 ativo (optional)</param> 
        /// <param name="revUser">Usu\u00E1rio da auditoria (optional)</param> 
        /// <returns>ApiResponse of PageTipoOportunidadeAUDResponse</returns>
        public ApiResponse< PageTipoOportunidadeAUDResponse > ListarAuditoriasTiposOportunidadesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, string descricao = null, bool? flagAtivo = null, string revUser = null)
        {
            
    
            var localVarPath = "/api/auditorias-tipos-oportunidades";
    
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
            if (revType != null) localVarQueryParams.Add("revType", Configuration.ApiClient.ParameterToString(revType)); // query parameter
            if (revDate != null) localVarQueryParams.Add("revDate", Configuration.ApiClient.ParameterToString(revDate)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            if (revUser != null) localVarQueryParams.Add("revUser", Configuration.ApiClient.ParameterToString(revUser)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditoriasTiposOportunidades: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditoriasTiposOportunidades: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoOportunidadeAUDResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoOportunidadeAUDResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoOportunidadeAUDResponse)));
            
        }

        
        /// <summary>
        /// Lista as auditorias dos tipos oportunidades Este recurso permite listar os tipos oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="revType">C\u00F3digo que representa o tipo de a\u00E7\u00E3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="revDate">Data da a\u00E7\u00E3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="id">C\u00F3digo identificador do tipo oportunidade no qual foi realizado a a\u00E7\u00E3o (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo oportunidade no qual foi realizado a a\u00E7\u00E3o (optional)</param>
        /// <param name="flagAtivo">Atributo que representa se o tipo oportunidade est\u00E1 ativo (optional)</param>
        /// <param name="revUser">Usu\u00E1rio da auditoria (optional)</param>
        /// <returns>Task of PageTipoOportunidadeAUDResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoOportunidadeAUDResponse> ListarAuditoriasTiposOportunidadesAsync (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, string descricao = null, bool? flagAtivo = null, string revUser = null)
        {
             ApiResponse<PageTipoOportunidadeAUDResponse> localVarResponse = await ListarAuditoriasTiposOportunidadesAsyncWithHttpInfo(sort, page, limit, revType, revDate, id, descricao, flagAtivo, revUser);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as auditorias dos tipos oportunidades Este recurso permite listar os tipos oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="revType">C\u00F3digo que representa o tipo de a\u00E7\u00E3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="revDate">Data da a\u00E7\u00E3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="id">C\u00F3digo identificador do tipo oportunidade no qual foi realizado a a\u00E7\u00E3o (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo oportunidade no qual foi realizado a a\u00E7\u00E3o (optional)</param>
        /// <param name="flagAtivo">Atributo que representa se o tipo oportunidade est\u00E1 ativo (optional)</param>
        /// <param name="revUser">Usu\u00E1rio da auditoria (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoOportunidadeAUDResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoOportunidadeAUDResponse>> ListarAuditoriasTiposOportunidadesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, string descricao = null, bool? flagAtivo = null, string revUser = null)
        {
            
    
            var localVarPath = "/api/auditorias-tipos-oportunidades";
    
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
            if (revType != null) localVarQueryParams.Add("revType", Configuration.ApiClient.ParameterToString(revType)); // query parameter
            if (revDate != null) localVarQueryParams.Add("revDate", Configuration.ApiClient.ParameterToString(revDate)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            if (revUser != null) localVarQueryParams.Add("revUser", Configuration.ApiClient.ParameterToString(revUser)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditoriasTiposOportunidades: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditoriasTiposOportunidades: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoOportunidadeAUDResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoOportunidadeAUDResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoOportunidadeAUDResponse)));
            
        }
        
        /// <summary>
        /// Lista as oportunidades Este recurso permite listar as oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idStatusOportunidade">C\u00F3digo identificador do status oportunidade (optional)</param> 
        /// <param name="dataCadastro">Data do cadastro da oportunidade (optional)</param> 
        /// <param name="dataAtualizacao">Data da atualiza\u00E7\u00E3o da oportunidade (optional)</param> 
        /// <param name="numeroReceitaFederal">N\u00FAmero receita federal do cliente ao qual ser\u00E1 ofertada a oportunidade (optional)</param> 
        /// <param name="dataInicioVigencia">Data de in\u00EDcio da vig\u00EAncia da oportunidade (optional)</param> 
        /// <param name="dataFimVigencia">Data do fim da vig\u00EAncia da oportunidade (optional)</param> 
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se a oportunidade est\u00E1 ativa (optional)</param> 
        /// <returns>PageOportunidadeResponse</returns>
        public PageOportunidadeResponse ListarOportunidades (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string dataFimVigencia = null, bool? flagAtivo = null)
        {
             ApiResponse<PageOportunidadeResponse> localVarResponse = ListarOportunidadesWithHttpInfo(sort, page, limit, idStatusOportunidade, dataCadastro, dataAtualizacao, numeroReceitaFederal, dataInicioVigencia, dataFimVigencia, flagAtivo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as oportunidades Este recurso permite listar as oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idStatusOportunidade">C\u00F3digo identificador do status oportunidade (optional)</param> 
        /// <param name="dataCadastro">Data do cadastro da oportunidade (optional)</param> 
        /// <param name="dataAtualizacao">Data da atualiza\u00E7\u00E3o da oportunidade (optional)</param> 
        /// <param name="numeroReceitaFederal">N\u00FAmero receita federal do cliente ao qual ser\u00E1 ofertada a oportunidade (optional)</param> 
        /// <param name="dataInicioVigencia">Data de in\u00EDcio da vig\u00EAncia da oportunidade (optional)</param> 
        /// <param name="dataFimVigencia">Data do fim da vig\u00EAncia da oportunidade (optional)</param> 
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se a oportunidade est\u00E1 ativa (optional)</param> 
        /// <returns>ApiResponse of PageOportunidadeResponse</returns>
        public ApiResponse< PageOportunidadeResponse > ListarOportunidadesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string dataFimVigencia = null, bool? flagAtivo = null)
        {
            
    
            var localVarPath = "/api/oportunidades";
    
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
            if (idStatusOportunidade != null) localVarQueryParams.Add("idStatusOportunidade", Configuration.ApiClient.ParameterToString(idStatusOportunidade)); // query parameter
            if (dataCadastro != null) localVarQueryParams.Add("dataCadastro", Configuration.ApiClient.ParameterToString(dataCadastro)); // query parameter
            if (dataAtualizacao != null) localVarQueryParams.Add("dataAtualizacao", Configuration.ApiClient.ParameterToString(dataAtualizacao)); // query parameter
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (dataInicioVigencia != null) localVarQueryParams.Add("dataInicioVigencia", Configuration.ApiClient.ParameterToString(dataInicioVigencia)); // query parameter
            if (dataFimVigencia != null) localVarQueryParams.Add("dataFimVigencia", Configuration.ApiClient.ParameterToString(dataFimVigencia)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarOportunidades: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarOportunidades: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOportunidadeResponse)));
            
        }

        
        /// <summary>
        /// Lista as oportunidades Este recurso permite listar as oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusOportunidade">C\u00F3digo identificador do status oportunidade (optional)</param>
        /// <param name="dataCadastro">Data do cadastro da oportunidade (optional)</param>
        /// <param name="dataAtualizacao">Data da atualiza\u00E7\u00E3o da oportunidade (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00FAmero receita federal do cliente ao qual ser\u00E1 ofertada a oportunidade (optional)</param>
        /// <param name="dataInicioVigencia">Data de in\u00EDcio da vig\u00EAncia da oportunidade (optional)</param>
        /// <param name="dataFimVigencia">Data do fim da vig\u00EAncia da oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se a oportunidade est\u00E1 ativa (optional)</param>
        /// <returns>Task of PageOportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<PageOportunidadeResponse> ListarOportunidadesAsync (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string dataFimVigencia = null, bool? flagAtivo = null)
        {
             ApiResponse<PageOportunidadeResponse> localVarResponse = await ListarOportunidadesAsyncWithHttpInfo(sort, page, limit, idStatusOportunidade, dataCadastro, dataAtualizacao, numeroReceitaFederal, dataInicioVigencia, dataFimVigencia, flagAtivo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as oportunidades Este recurso permite listar as oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusOportunidade">C\u00F3digo identificador do status oportunidade (optional)</param>
        /// <param name="dataCadastro">Data do cadastro da oportunidade (optional)</param>
        /// <param name="dataAtualizacao">Data da atualiza\u00E7\u00E3o da oportunidade (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00FAmero receita federal do cliente ao qual ser\u00E1 ofertada a oportunidade (optional)</param>
        /// <param name="dataInicioVigencia">Data de in\u00EDcio da vig\u00EAncia da oportunidade (optional)</param>
        /// <param name="dataFimVigencia">Data do fim da vig\u00EAncia da oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se a oportunidade est\u00E1 ativa (optional)</param>
        /// <returns>Task of ApiResponse (PageOportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageOportunidadeResponse>> ListarOportunidadesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string dataFimVigencia = null, bool? flagAtivo = null)
        {
            
    
            var localVarPath = "/api/oportunidades";
    
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
            if (idStatusOportunidade != null) localVarQueryParams.Add("idStatusOportunidade", Configuration.ApiClient.ParameterToString(idStatusOportunidade)); // query parameter
            if (dataCadastro != null) localVarQueryParams.Add("dataCadastro", Configuration.ApiClient.ParameterToString(dataCadastro)); // query parameter
            if (dataAtualizacao != null) localVarQueryParams.Add("dataAtualizacao", Configuration.ApiClient.ParameterToString(dataAtualizacao)); // query parameter
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (dataInicioVigencia != null) localVarQueryParams.Add("dataInicioVigencia", Configuration.ApiClient.ParameterToString(dataInicioVigencia)); // query parameter
            if (dataFimVigencia != null) localVarQueryParams.Add("dataFimVigencia", Configuration.ApiClient.ParameterToString(dataFimVigencia)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarOportunidades: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarOportunidades: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOportunidadeResponse)));
            
        }
        
        /// <summary>
        /// Lista os status do tipo oportunidades Este recurso permite listar os status do tipo oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="nome">Nome do status oportunidade (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do status oportunidade (optional)</param> 
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se o status oportunidade est\u00E1 ativo (optional)</param> 
        /// <returns>PageStatusOportunidadeResponse</returns>
        public PageStatusOportunidadeResponse ListarStatusTiposOportunidades (long? id, List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null, bool? flagAtivo = null)
        {
             ApiResponse<PageStatusOportunidadeResponse> localVarResponse = ListarStatusTiposOportunidadesWithHttpInfo(id, sort, page, limit, nome, descricao, flagAtivo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os status do tipo oportunidades Este recurso permite listar os status do tipo oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="nome">Nome do status oportunidade (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do status oportunidade (optional)</param> 
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se o status oportunidade est\u00E1 ativo (optional)</param> 
        /// <returns>ApiResponse of PageStatusOportunidadeResponse</returns>
        public ApiResponse< PageStatusOportunidadeResponse > ListarStatusTiposOportunidadesWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null, bool? flagAtivo = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OportunidadeApi->ListarStatusTiposOportunidades");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}/status";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusTiposOportunidades: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusTiposOportunidades: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageStatusOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusOportunidadeResponse)));
            
        }

        
        /// <summary>
        /// Lista os status do tipo oportunidades Este recurso permite listar os status do tipo oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do status oportunidade (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do status oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se o status oportunidade est\u00E1 ativo (optional)</param>
        /// <returns>Task of PageStatusOportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<PageStatusOportunidadeResponse> ListarStatusTiposOportunidadesAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null, bool? flagAtivo = null)
        {
             ApiResponse<PageStatusOportunidadeResponse> localVarResponse = await ListarStatusTiposOportunidadesAsyncWithHttpInfo(id, sort, page, limit, nome, descricao, flagAtivo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os status do tipo oportunidades Este recurso permite listar os status do tipo oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do status oportunidade (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do status oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se o status oportunidade est\u00E1 ativo (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusOportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageStatusOportunidadeResponse>> ListarStatusTiposOportunidadesAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null, bool? flagAtivo = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarStatusTiposOportunidades");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}/status";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusTiposOportunidades: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusTiposOportunidades: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageStatusOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusOportunidadeResponse)));
            
        }
        
        /// <summary>
        /// Lista os tipos oportunidades Este recurso permite listar os tipos oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo oportunidade (optional)</param> 
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se o tipo oportunidade est\u00E1 ativo (optional)</param> 
        /// <returns>PageTipoOportunidadeResponse</returns>
        public PageTipoOportunidadeResponse ListarTiposOportunidades (List<string> sort = null, int? page = null, int? limit = null, string descricao = null, bool? flagAtivo = null)
        {
             ApiResponse<PageTipoOportunidadeResponse> localVarResponse = ListarTiposOportunidadesWithHttpInfo(sort, page, limit, descricao, flagAtivo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os tipos oportunidades Este recurso permite listar os tipos oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo oportunidade (optional)</param> 
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se o tipo oportunidade est\u00E1 ativo (optional)</param> 
        /// <returns>ApiResponse of PageTipoOportunidadeResponse</returns>
        public ApiResponse< PageTipoOportunidadeResponse > ListarTiposOportunidadesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null, bool? flagAtivo = null)
        {
            
    
            var localVarPath = "/api/tipos-oportunidades";
    
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
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposOportunidades: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposOportunidades: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoOportunidadeResponse)));
            
        }

        
        /// <summary>
        /// Lista os tipos oportunidades Este recurso permite listar os tipos oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se o tipo oportunidade est\u00E1 ativo (optional)</param>
        /// <returns>Task of PageTipoOportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoOportunidadeResponse> ListarTiposOportunidadesAsync (List<string> sort = null, int? page = null, int? limit = null, string descricao = null, bool? flagAtivo = null)
        {
             ApiResponse<PageTipoOportunidadeResponse> localVarResponse = await ListarTiposOportunidadesAsyncWithHttpInfo(sort, page, limit, descricao, flagAtivo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os tipos oportunidades Este recurso permite listar os tipos oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00E7\u00E3o se o tipo oportunidade est\u00E1 ativo (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoOportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoOportunidadeResponse>> ListarTiposOportunidadesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null, bool? flagAtivo = null)
        {
            
    
            var localVarPath = "/api/tipos-oportunidades";
    
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
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposOportunidades: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposOportunidades: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoOportunidadeResponse)));
            
        }
        
        /// <summary>
        /// Cadastra as oportunidades Esse recurso permite cadastrar oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>OportunidadeResponse</returns>
        public OportunidadeResponse SalvarOportunidade (OportunidadePersist persist)
        {
             ApiResponse<OportunidadeResponse> localVarResponse = SalvarOportunidadeWithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastra as oportunidades Esse recurso permite cadastrar oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of OportunidadeResponse</returns>
        public ApiResponse< OportunidadeResponse > SalvarOportunidadeWithHttpInfo (OportunidadePersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling OportunidadeApi->SalvarOportunidade");
            
    
            var localVarPath = "/api/oportunidades";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarOportunidade: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarOportunidade: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OportunidadeResponse)));
            
        }

        
        /// <summary>
        /// Cadastra as oportunidades Esse recurso permite cadastrar oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of OportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<OportunidadeResponse> SalvarOportunidadeAsync (OportunidadePersist persist)
        {
             ApiResponse<OportunidadeResponse> localVarResponse = await SalvarOportunidadeAsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastra as oportunidades Esse recurso permite cadastrar oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (OportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OportunidadeResponse>> SalvarOportunidadeAsyncWithHttpInfo (OportunidadePersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarOportunidade");
            
    
            var localVarPath = "/api/oportunidades";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarOportunidade: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarOportunidade: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OportunidadeResponse)));
            
        }
        
        /// <summary>
        /// Cadastra status para o tipo oportunidade Esse recurso permite cadastrar status para o tipo oportunidade
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param> 
        /// <param name="persist">persist</param> 
        /// <returns>StatusOportunidadeResponse</returns>
        public StatusOportunidadeResponse SalvarStatusTiposOportunidades (long? id, StatusOportunidade persist)
        {
             ApiResponse<StatusOportunidadeResponse> localVarResponse = SalvarStatusTiposOportunidadesWithHttpInfo(id, persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastra status para o tipo oportunidade Esse recurso permite cadastrar status para o tipo oportunidade
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param> 
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of StatusOportunidadeResponse</returns>
        public ApiResponse< StatusOportunidadeResponse > SalvarStatusTiposOportunidadesWithHttpInfo (long? id, StatusOportunidade persist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OportunidadeApi->SalvarStatusTiposOportunidades");
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling OportunidadeApi->SalvarStatusTiposOportunidades");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}/status";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarStatusTiposOportunidades: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarStatusTiposOportunidades: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<StatusOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusOportunidadeResponse)));
            
        }

        
        /// <summary>
        /// Cadastra status para o tipo oportunidade Esse recurso permite cadastrar status para o tipo oportunidade
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of StatusOportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<StatusOportunidadeResponse> SalvarStatusTiposOportunidadesAsync (long? id, StatusOportunidade persist)
        {
             ApiResponse<StatusOportunidadeResponse> localVarResponse = await SalvarStatusTiposOportunidadesAsyncWithHttpInfo(id, persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastra status para o tipo oportunidade Esse recurso permite cadastrar status para o tipo oportunidade
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo oportunidade (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (StatusOportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StatusOportunidadeResponse>> SalvarStatusTiposOportunidadesAsyncWithHttpInfo (long? id, StatusOportunidade persist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SalvarStatusTiposOportunidades");
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarStatusTiposOportunidades");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}/status";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarStatusTiposOportunidades: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarStatusTiposOportunidades: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StatusOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusOportunidadeResponse)));
            
        }
        
        /// <summary>
        /// Cadastra tipos oportunidades Esse recurso permite cadastrar tipos oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>TipoOportunidadeResponse</returns>
        public TipoOportunidadeResponse SalvarTipoOportunidade (TipoOportunidade persist)
        {
             ApiResponse<TipoOportunidadeResponse> localVarResponse = SalvarTipoOportunidadeWithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastra tipos oportunidades Esse recurso permite cadastrar tipos oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of TipoOportunidadeResponse</returns>
        public ApiResponse< TipoOportunidadeResponse > SalvarTipoOportunidadeWithHttpInfo (TipoOportunidade persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling OportunidadeApi->SalvarTipoOportunidade");
            
    
            var localVarPath = "/api/tipos-oportunidades";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarTipoOportunidade: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarTipoOportunidade: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoOportunidadeResponse)));
            
        }

        
        /// <summary>
        /// Cadastra tipos oportunidades Esse recurso permite cadastrar tipos oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of TipoOportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<TipoOportunidadeResponse> SalvarTipoOportunidadeAsync (TipoOportunidade persist)
        {
             ApiResponse<TipoOportunidadeResponse> localVarResponse = await SalvarTipoOportunidadeAsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastra tipos oportunidades Esse recurso permite cadastrar tipos oportunidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TipoOportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoOportunidadeResponse>> SalvarTipoOportunidadeAsyncWithHttpInfo (TipoOportunidade persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarTipoOportunidade");
            
    
            var localVarPath = "/api/tipos-oportunidades";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarTipoOportunidade: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarTipoOportunidade: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoOportunidadeResponse)));
            
        }
        
    }
    
}
