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
    public interface IPropostaApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Altera parcialmente a proposta.
        /// </summary>
        /// <remarks>
        /// Este recurso permite alterar os campos de uma proposta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Indentificador da proposta.</param>
        /// <param name="propostaParcialUpdate">propostaParcialUpdate</param>
        /// <returns>PropostaResponse</returns>
        PropostaResponse AlterarPropostaParcialmente (long? id, PropostaParcialUpdate propostaParcialUpdate);
  
        /// <summary>
        /// Altera parcialmente a proposta.
        /// </summary>
        /// <remarks>
        /// Este recurso permite alterar os campos de uma proposta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Indentificador da proposta.</param>
        /// <param name="propostaParcialUpdate">propostaParcialUpdate</param>
        /// <returns>ApiResponse of PropostaResponse</returns>
        ApiResponse<PropostaResponse> AlterarPropostaParcialmenteWithHttpInfo (long? id, PropostaParcialUpdate propostaParcialUpdate);
        
        /// <summary>
        /// Altera o status de uma proposta
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o altera o status de uma proposta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Proposta (id)</param>
        /// <param name="update">update</param>
        /// <returns>PropostaResponse</returns>
        PropostaResponse AlterarStatusProposta (long? id, StatusPropostaUpdate update);
  
        /// <summary>
        /// Altera o status de uma proposta
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o altera o status de uma proposta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Proposta (id)</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of PropostaResponse</returns>
        ApiResponse<PropostaResponse> AlterarStatusPropostaWithHttpInfo (long? id, StatusPropostaUpdate update);
        
        /// <summary>
        /// Busca uma proposta pelo seu identificador
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o busca uma proposta pelo seu identificador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Proposta (id)</param>
        /// <returns>PropostaResponse</returns>
        PropostaResponse ConsultarProposta (long? id);
  
        /// <summary>
        /// Busca uma proposta pelo seu identificador
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o busca uma proposta pelo seu identificador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Proposta (id)</param>
        /// <returns>ApiResponse of PropostaResponse</returns>
        ApiResponse<PropostaResponse> ConsultarPropostaWithHttpInfo (long? id);
        
        /// <summary>
        /// Cria\u00E7\u00E3o de documento proposta
        /// </summary>
        /// <remarks>
        /// Cria um documento proposta e envia o arquivo relacionado a ele para o armazenamento na nuvem
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>DocumentoPropostaResponse</returns>
        DocumentoPropostaResponse EnviarDocumentoDeProposta (DocumentoPropostaPersist persist);
  
        /// <summary>
        /// Cria\u00E7\u00E3o de documento proposta
        /// </summary>
        /// <remarks>
        /// Cria um documento proposta e envia o arquivo relacionado a ele para o armazenamento na nuvem
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of DocumentoPropostaResponse</returns>
        ApiResponse<DocumentoPropostaResponse> EnviarDocumentoDePropostaWithHttpInfo (DocumentoPropostaPersist persist);
        
        /// <summary>
        /// Lista Documento Cr\u00E9dito
        /// </summary>
        /// <remarks>
        /// Lista os documentos cr\u00E9dito que s\u00E3o os tipos de documentos proposta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do documento cr\u00E9dito(id) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de documento cr\u00E9dito (optional)</param>
        /// <param name="tela">Sinaliza a flag tela  (optional)</param>
        /// <param name="doc">Sinaliza a flag doc (optional)</param>
        /// <param name="idAtividadeDeCredito">C\u00F3digo de identifica\u00E7\u00E3o da atividade de cr\u00E9dito (optional)</param>
        /// <param name="obrigatorio">Sinaliza a flag obrigaroio (optional)</param>
        /// <returns>PageDocumentoCreditoResponse</returns>
        PageDocumentoCreditoResponse ListarDocumentosDeCredito (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, int? tela = null, int? doc = null, long? idAtividadeDeCredito = null, int? obrigatorio = null);
  
        /// <summary>
        /// Lista Documento Cr\u00E9dito
        /// </summary>
        /// <remarks>
        /// Lista os documentos cr\u00E9dito que s\u00E3o os tipos de documentos proposta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do documento cr\u00E9dito(id) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de documento cr\u00E9dito (optional)</param>
        /// <param name="tela">Sinaliza a flag tela  (optional)</param>
        /// <param name="doc">Sinaliza a flag doc (optional)</param>
        /// <param name="idAtividadeDeCredito">C\u00F3digo de identifica\u00E7\u00E3o da atividade de cr\u00E9dito (optional)</param>
        /// <param name="obrigatorio">Sinaliza a flag obrigaroio (optional)</param>
        /// <returns>ApiResponse of PageDocumentoCreditoResponse</returns>
        ApiResponse<PageDocumentoCreditoResponse> ListarDocumentosDeCreditoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, int? tela = null, int? doc = null, long? idAtividadeDeCredito = null, int? obrigatorio = null);
        
        /// <summary>
        /// Lista Documentos proposta
        /// </summary>
        /// <remarks>
        /// Lista os documentos proposta filtrados
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do documento proposta(id) (optional)</param>
        /// <param name="idProposta">C\u00F3digo de identifica\u00E7\u00E3o da proposta(id) (optional)</param>
        /// <param name="idDocumentosCredito">C\u00F3digo de identifica\u00E7\u00E3o para o tipo do documento (optional)</param>
        /// <param name="idStatusDocumentosCredito">C\u00F3digo de identifica\u00E7\u00E3o do Status do documento cr\u00E9dito (optional)</param>
        /// <param name="idCondicoesDocumentosCredito">C\u00F3digo de identifica\u00E7\u00E3o da condi\u00E7\u00E3o do documento cr\u00E9dito (optional)</param>
        /// <param name="idTipoDocumentoCredito">C\u00F3digo de identifica\u00E7\u00E3o do tipo do documento cr\u00E9dito (optional)</param>
        /// <param name="idPessoaFisica">C\u00F3digo de identifica\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="idLogAtendimento">C\u00F3digo de identifica\u00E7\u00E3o do Log de Atendimento (optional)</param>
        /// <param name="responsavel">Respons\u00E1vel (optional)</param>
        /// <param name="flagDocumentoDigitalizado">Indica se o documento ser\u00E1 digitalizado (optional)</param>
        /// <param name="documentoDigitalizado">Nome do documento digitalizado (optional)</param>
        /// <param name="seqAnaliseCondicao">C\u00F3digo de sequ\u00EAncia de analise de condi\u00E7\u00E3o (optional)</param>
        /// <param name="observacao">Observa\u00E7\u00E3o (optional)</param>
        /// <param name="dataStatus">Data de status (optional)</param>
        /// <returns>PageDocumentoPropostaResponse</returns>
        PageDocumentoPropostaResponse ListarDocumentosDeProposta (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idProposta = null, long? idDocumentosCredito = null, long? idStatusDocumentosCredito = null, long? idCondicoesDocumentosCredito = null, long? idTipoDocumentoCredito = null, long? idPessoaFisica = null, long? idLogAtendimento = null, string responsavel = null, int? flagDocumentoDigitalizado = null, string documentoDigitalizado = null, long? seqAnaliseCondicao = null, string observacao = null, string dataStatus = null);
  
        /// <summary>
        /// Lista Documentos proposta
        /// </summary>
        /// <remarks>
        /// Lista os documentos proposta filtrados
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do documento proposta(id) (optional)</param>
        /// <param name="idProposta">C\u00F3digo de identifica\u00E7\u00E3o da proposta(id) (optional)</param>
        /// <param name="idDocumentosCredito">C\u00F3digo de identifica\u00E7\u00E3o para o tipo do documento (optional)</param>
        /// <param name="idStatusDocumentosCredito">C\u00F3digo de identifica\u00E7\u00E3o do Status do documento cr\u00E9dito (optional)</param>
        /// <param name="idCondicoesDocumentosCredito">C\u00F3digo de identifica\u00E7\u00E3o da condi\u00E7\u00E3o do documento cr\u00E9dito (optional)</param>
        /// <param name="idTipoDocumentoCredito">C\u00F3digo de identifica\u00E7\u00E3o do tipo do documento cr\u00E9dito (optional)</param>
        /// <param name="idPessoaFisica">C\u00F3digo de identifica\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="idLogAtendimento">C\u00F3digo de identifica\u00E7\u00E3o do Log de Atendimento (optional)</param>
        /// <param name="responsavel">Respons\u00E1vel (optional)</param>
        /// <param name="flagDocumentoDigitalizado">Indica se o documento ser\u00E1 digitalizado (optional)</param>
        /// <param name="documentoDigitalizado">Nome do documento digitalizado (optional)</param>
        /// <param name="seqAnaliseCondicao">C\u00F3digo de sequ\u00EAncia de analise de condi\u00E7\u00E3o (optional)</param>
        /// <param name="observacao">Observa\u00E7\u00E3o (optional)</param>
        /// <param name="dataStatus">Data de status (optional)</param>
        /// <returns>ApiResponse of PageDocumentoPropostaResponse</returns>
        ApiResponse<PageDocumentoPropostaResponse> ListarDocumentosDePropostaWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idProposta = null, long? idDocumentosCredito = null, long? idStatusDocumentosCredito = null, long? idCondicoesDocumentosCredito = null, long? idTipoDocumentoCredito = null, long? idPessoaFisica = null, long? idLogAtendimento = null, string responsavel = null, int? flagDocumentoDigitalizado = null, string documentoDigitalizado = null, long? seqAnaliseCondicao = null, string observacao = null, string dataStatus = null);
        
        /// <summary>
        /// Lista todas as propostas
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o lista todas as propostas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="status">Status da proposta (optional)</param>
        /// <param name="idPessoaFisica">Identificador da Pessoa Fisica (optional)</param>
        /// <returns>PagePropostaResponse</returns>
        PagePropostaResponse ListarPropostas (List<string> sort = null, int? page = null, int? limit = null, int? status = null, long? idPessoaFisica = null);
  
        /// <summary>
        /// Lista todas as propostas
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o lista todas as propostas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="status">Status da proposta (optional)</param>
        /// <param name="idPessoaFisica">Identificador da Pessoa Fisica (optional)</param>
        /// <returns>ApiResponse of PagePropostaResponse</returns>
        ApiResponse<PagePropostaResponse> ListarPropostasWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, int? status = null, long? idPessoaFisica = null);
        
        /// <summary>
        /// Lista todos os status poss\u00EDveis nas propostas existentes
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o lista todos os status poss\u00EDveis nas propostas existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="status">Status da proposta (optional)</param>
        /// <param name="flagPermiteAlteracao">Flag que permite a altera\u00E7\u00E3o do status da proposta (optional)</param>
        /// <returns>PageStatusPropostaResponse</returns>
        PageStatusPropostaResponse ListarStatusPropostas (List<string> sort = null, int? page = null, int? limit = null, int? status = null, bool? flagPermiteAlteracao = null);
  
        /// <summary>
        /// Lista todos os status poss\u00EDveis nas propostas existentes
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o lista todos os status poss\u00EDveis nas propostas existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="status">Status da proposta (optional)</param>
        /// <param name="flagPermiteAlteracao">Flag que permite a altera\u00E7\u00E3o do status da proposta (optional)</param>
        /// <returns>ApiResponse of PageStatusPropostaResponse</returns>
        ApiResponse<PageStatusPropostaResponse> ListarStatusPropostasWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, int? status = null, bool? flagPermiteAlteracao = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Altera parcialmente a proposta.
        /// </summary>
        /// <remarks>
        /// Este recurso permite alterar os campos de uma proposta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Indentificador da proposta.</param>
        /// <param name="propostaParcialUpdate">propostaParcialUpdate</param>
        /// <returns>Task of PropostaResponse</returns>
        System.Threading.Tasks.Task<PropostaResponse> AlterarPropostaParcialmenteAsync (long? id, PropostaParcialUpdate propostaParcialUpdate);

        /// <summary>
        /// Altera parcialmente a proposta.
        /// </summary>
        /// <remarks>
        /// Este recurso permite alterar os campos de uma proposta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Indentificador da proposta.</param>
        /// <param name="propostaParcialUpdate">propostaParcialUpdate</param>
        /// <returns>Task of ApiResponse (PropostaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PropostaResponse>> AlterarPropostaParcialmenteAsyncWithHttpInfo (long? id, PropostaParcialUpdate propostaParcialUpdate);
        
        /// <summary>
        /// Altera o status de uma proposta
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o altera o status de uma proposta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Proposta (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of PropostaResponse</returns>
        System.Threading.Tasks.Task<PropostaResponse> AlterarStatusPropostaAsync (long? id, StatusPropostaUpdate update);

        /// <summary>
        /// Altera o status de uma proposta
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o altera o status de uma proposta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Proposta (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (PropostaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PropostaResponse>> AlterarStatusPropostaAsyncWithHttpInfo (long? id, StatusPropostaUpdate update);
        
        /// <summary>
        /// Busca uma proposta pelo seu identificador
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o busca uma proposta pelo seu identificador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Proposta (id)</param>
        /// <returns>Task of PropostaResponse</returns>
        System.Threading.Tasks.Task<PropostaResponse> ConsultarPropostaAsync (long? id);

        /// <summary>
        /// Busca uma proposta pelo seu identificador
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o busca uma proposta pelo seu identificador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Proposta (id)</param>
        /// <returns>Task of ApiResponse (PropostaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PropostaResponse>> ConsultarPropostaAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Cria\u00E7\u00E3o de documento proposta
        /// </summary>
        /// <remarks>
        /// Cria um documento proposta e envia o arquivo relacionado a ele para o armazenamento na nuvem
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of DocumentoPropostaResponse</returns>
        System.Threading.Tasks.Task<DocumentoPropostaResponse> EnviarDocumentoDePropostaAsync (DocumentoPropostaPersist persist);

        /// <summary>
        /// Cria\u00E7\u00E3o de documento proposta
        /// </summary>
        /// <remarks>
        /// Cria um documento proposta e envia o arquivo relacionado a ele para o armazenamento na nuvem
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DocumentoPropostaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentoPropostaResponse>> EnviarDocumentoDePropostaAsyncWithHttpInfo (DocumentoPropostaPersist persist);
        
        /// <summary>
        /// Lista Documento Cr\u00E9dito
        /// </summary>
        /// <remarks>
        /// Lista os documentos cr\u00E9dito que s\u00E3o os tipos de documentos proposta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do documento cr\u00E9dito(id) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de documento cr\u00E9dito (optional)</param>
        /// <param name="tela">Sinaliza a flag tela  (optional)</param>
        /// <param name="doc">Sinaliza a flag doc (optional)</param>
        /// <param name="idAtividadeDeCredito">C\u00F3digo de identifica\u00E7\u00E3o da atividade de cr\u00E9dito (optional)</param>
        /// <param name="obrigatorio">Sinaliza a flag obrigaroio (optional)</param>
        /// <returns>Task of PageDocumentoCreditoResponse</returns>
        System.Threading.Tasks.Task<PageDocumentoCreditoResponse> ListarDocumentosDeCreditoAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, int? tela = null, int? doc = null, long? idAtividadeDeCredito = null, int? obrigatorio = null);

        /// <summary>
        /// Lista Documento Cr\u00E9dito
        /// </summary>
        /// <remarks>
        /// Lista os documentos cr\u00E9dito que s\u00E3o os tipos de documentos proposta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do documento cr\u00E9dito(id) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de documento cr\u00E9dito (optional)</param>
        /// <param name="tela">Sinaliza a flag tela  (optional)</param>
        /// <param name="doc">Sinaliza a flag doc (optional)</param>
        /// <param name="idAtividadeDeCredito">C\u00F3digo de identifica\u00E7\u00E3o da atividade de cr\u00E9dito (optional)</param>
        /// <param name="obrigatorio">Sinaliza a flag obrigaroio (optional)</param>
        /// <returns>Task of ApiResponse (PageDocumentoCreditoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageDocumentoCreditoResponse>> ListarDocumentosDeCreditoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, int? tela = null, int? doc = null, long? idAtividadeDeCredito = null, int? obrigatorio = null);
        
        /// <summary>
        /// Lista Documentos proposta
        /// </summary>
        /// <remarks>
        /// Lista os documentos proposta filtrados
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do documento proposta(id) (optional)</param>
        /// <param name="idProposta">C\u00F3digo de identifica\u00E7\u00E3o da proposta(id) (optional)</param>
        /// <param name="idDocumentosCredito">C\u00F3digo de identifica\u00E7\u00E3o para o tipo do documento (optional)</param>
        /// <param name="idStatusDocumentosCredito">C\u00F3digo de identifica\u00E7\u00E3o do Status do documento cr\u00E9dito (optional)</param>
        /// <param name="idCondicoesDocumentosCredito">C\u00F3digo de identifica\u00E7\u00E3o da condi\u00E7\u00E3o do documento cr\u00E9dito (optional)</param>
        /// <param name="idTipoDocumentoCredito">C\u00F3digo de identifica\u00E7\u00E3o do tipo do documento cr\u00E9dito (optional)</param>
        /// <param name="idPessoaFisica">C\u00F3digo de identifica\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="idLogAtendimento">C\u00F3digo de identifica\u00E7\u00E3o do Log de Atendimento (optional)</param>
        /// <param name="responsavel">Respons\u00E1vel (optional)</param>
        /// <param name="flagDocumentoDigitalizado">Indica se o documento ser\u00E1 digitalizado (optional)</param>
        /// <param name="documentoDigitalizado">Nome do documento digitalizado (optional)</param>
        /// <param name="seqAnaliseCondicao">C\u00F3digo de sequ\u00EAncia de analise de condi\u00E7\u00E3o (optional)</param>
        /// <param name="observacao">Observa\u00E7\u00E3o (optional)</param>
        /// <param name="dataStatus">Data de status (optional)</param>
        /// <returns>Task of PageDocumentoPropostaResponse</returns>
        System.Threading.Tasks.Task<PageDocumentoPropostaResponse> ListarDocumentosDePropostaAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idProposta = null, long? idDocumentosCredito = null, long? idStatusDocumentosCredito = null, long? idCondicoesDocumentosCredito = null, long? idTipoDocumentoCredito = null, long? idPessoaFisica = null, long? idLogAtendimento = null, string responsavel = null, int? flagDocumentoDigitalizado = null, string documentoDigitalizado = null, long? seqAnaliseCondicao = null, string observacao = null, string dataStatus = null);

        /// <summary>
        /// Lista Documentos proposta
        /// </summary>
        /// <remarks>
        /// Lista os documentos proposta filtrados
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do documento proposta(id) (optional)</param>
        /// <param name="idProposta">C\u00F3digo de identifica\u00E7\u00E3o da proposta(id) (optional)</param>
        /// <param name="idDocumentosCredito">C\u00F3digo de identifica\u00E7\u00E3o para o tipo do documento (optional)</param>
        /// <param name="idStatusDocumentosCredito">C\u00F3digo de identifica\u00E7\u00E3o do Status do documento cr\u00E9dito (optional)</param>
        /// <param name="idCondicoesDocumentosCredito">C\u00F3digo de identifica\u00E7\u00E3o da condi\u00E7\u00E3o do documento cr\u00E9dito (optional)</param>
        /// <param name="idTipoDocumentoCredito">C\u00F3digo de identifica\u00E7\u00E3o do tipo do documento cr\u00E9dito (optional)</param>
        /// <param name="idPessoaFisica">C\u00F3digo de identifica\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="idLogAtendimento">C\u00F3digo de identifica\u00E7\u00E3o do Log de Atendimento (optional)</param>
        /// <param name="responsavel">Respons\u00E1vel (optional)</param>
        /// <param name="flagDocumentoDigitalizado">Indica se o documento ser\u00E1 digitalizado (optional)</param>
        /// <param name="documentoDigitalizado">Nome do documento digitalizado (optional)</param>
        /// <param name="seqAnaliseCondicao">C\u00F3digo de sequ\u00EAncia de analise de condi\u00E7\u00E3o (optional)</param>
        /// <param name="observacao">Observa\u00E7\u00E3o (optional)</param>
        /// <param name="dataStatus">Data de status (optional)</param>
        /// <returns>Task of ApiResponse (PageDocumentoPropostaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageDocumentoPropostaResponse>> ListarDocumentosDePropostaAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idProposta = null, long? idDocumentosCredito = null, long? idStatusDocumentosCredito = null, long? idCondicoesDocumentosCredito = null, long? idTipoDocumentoCredito = null, long? idPessoaFisica = null, long? idLogAtendimento = null, string responsavel = null, int? flagDocumentoDigitalizado = null, string documentoDigitalizado = null, long? seqAnaliseCondicao = null, string observacao = null, string dataStatus = null);
        
        /// <summary>
        /// Lista todas as propostas
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o lista todas as propostas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="status">Status da proposta (optional)</param>
        /// <param name="idPessoaFisica">Identificador da Pessoa Fisica (optional)</param>
        /// <returns>Task of PagePropostaResponse</returns>
        System.Threading.Tasks.Task<PagePropostaResponse> ListarPropostasAsync (List<string> sort = null, int? page = null, int? limit = null, int? status = null, long? idPessoaFisica = null);

        /// <summary>
        /// Lista todas as propostas
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o lista todas as propostas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="status">Status da proposta (optional)</param>
        /// <param name="idPessoaFisica">Identificador da Pessoa Fisica (optional)</param>
        /// <returns>Task of ApiResponse (PagePropostaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePropostaResponse>> ListarPropostasAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, int? status = null, long? idPessoaFisica = null);
        
        /// <summary>
        /// Lista todos os status poss\u00EDveis nas propostas existentes
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o lista todos os status poss\u00EDveis nas propostas existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="status">Status da proposta (optional)</param>
        /// <param name="flagPermiteAlteracao">Flag que permite a altera\u00E7\u00E3o do status da proposta (optional)</param>
        /// <returns>Task of PageStatusPropostaResponse</returns>
        System.Threading.Tasks.Task<PageStatusPropostaResponse> ListarStatusPropostasAsync (List<string> sort = null, int? page = null, int? limit = null, int? status = null, bool? flagPermiteAlteracao = null);

        /// <summary>
        /// Lista todos os status poss\u00EDveis nas propostas existentes
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o lista todos os status poss\u00EDveis nas propostas existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="status">Status da proposta (optional)</param>
        /// <param name="flagPermiteAlteracao">Flag que permite a altera\u00E7\u00E3o do status da proposta (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusPropostaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageStatusPropostaResponse>> ListarStatusPropostasAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, int? status = null, bool? flagPermiteAlteracao = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PropostaApi : IPropostaApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropostaApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PropostaApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PropostaApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PropostaApi(Configuration configuration = null)
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
        /// Altera parcialmente a proposta. Este recurso permite alterar os campos de uma proposta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Indentificador da proposta.</param> 
        /// <param name="propostaParcialUpdate">propostaParcialUpdate</param> 
        /// <returns>PropostaResponse</returns>
        public PropostaResponse AlterarPropostaParcialmente (long? id, PropostaParcialUpdate propostaParcialUpdate)
        {
             ApiResponse<PropostaResponse> localVarResponse = AlterarPropostaParcialmenteWithHttpInfo(id, propostaParcialUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera parcialmente a proposta. Este recurso permite alterar os campos de uma proposta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Indentificador da proposta.</param> 
        /// <param name="propostaParcialUpdate">propostaParcialUpdate</param> 
        /// <returns>ApiResponse of PropostaResponse</returns>
        public ApiResponse< PropostaResponse > AlterarPropostaParcialmenteWithHttpInfo (long? id, PropostaParcialUpdate propostaParcialUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PropostaApi->AlterarPropostaParcialmente");
            
            // verify the required parameter 'propostaParcialUpdate' is set
            if (propostaParcialUpdate == null)
                throw new ApiException(400, "Missing required parameter 'propostaParcialUpdate' when calling PropostaApi->AlterarPropostaParcialmente");
            
    
            var localVarPath = "/api/propostas/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (propostaParcialUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(propostaParcialUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = propostaParcialUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarPropostaParcialmente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarPropostaParcialmente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropostaResponse)));
            
        }

        
        /// <summary>
        /// Altera parcialmente a proposta. Este recurso permite alterar os campos de uma proposta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Indentificador da proposta.</param>
        /// <param name="propostaParcialUpdate">propostaParcialUpdate</param>
        /// <returns>Task of PropostaResponse</returns>
        public async System.Threading.Tasks.Task<PropostaResponse> AlterarPropostaParcialmenteAsync (long? id, PropostaParcialUpdate propostaParcialUpdate)
        {
             ApiResponse<PropostaResponse> localVarResponse = await AlterarPropostaParcialmenteAsyncWithHttpInfo(id, propostaParcialUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera parcialmente a proposta. Este recurso permite alterar os campos de uma proposta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Indentificador da proposta.</param>
        /// <param name="propostaParcialUpdate">propostaParcialUpdate</param>
        /// <returns>Task of ApiResponse (PropostaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PropostaResponse>> AlterarPropostaParcialmenteAsyncWithHttpInfo (long? id, PropostaParcialUpdate propostaParcialUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarPropostaParcialmente");
            // verify the required parameter 'propostaParcialUpdate' is set
            if (propostaParcialUpdate == null) throw new ApiException(400, "Missing required parameter 'propostaParcialUpdate' when calling AlterarPropostaParcialmente");
            
    
            var localVarPath = "/api/propostas/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (propostaParcialUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(propostaParcialUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = propostaParcialUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarPropostaParcialmente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarPropostaParcialmente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropostaResponse)));
            
        }
        
        /// <summary>
        /// Altera o status de uma proposta Este servi\u00E7o altera o status de uma proposta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Proposta (id)</param> 
        /// <param name="update">update</param> 
        /// <returns>PropostaResponse</returns>
        public PropostaResponse AlterarStatusProposta (long? id, StatusPropostaUpdate update)
        {
             ApiResponse<PropostaResponse> localVarResponse = AlterarStatusPropostaWithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera o status de uma proposta Este servi\u00E7o altera o status de uma proposta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Proposta (id)</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of PropostaResponse</returns>
        public ApiResponse< PropostaResponse > AlterarStatusPropostaWithHttpInfo (long? id, StatusPropostaUpdate update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PropostaApi->AlterarStatusProposta");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling PropostaApi->AlterarStatusProposta");
            
    
            var localVarPath = "/api/propostas/{id}/alterar-status";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatusProposta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatusProposta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropostaResponse)));
            
        }

        
        /// <summary>
        /// Altera o status de uma proposta Este servi\u00E7o altera o status de uma proposta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Proposta (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of PropostaResponse</returns>
        public async System.Threading.Tasks.Task<PropostaResponse> AlterarStatusPropostaAsync (long? id, StatusPropostaUpdate update)
        {
             ApiResponse<PropostaResponse> localVarResponse = await AlterarStatusPropostaAsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera o status de uma proposta Este servi\u00E7o altera o status de uma proposta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Proposta (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (PropostaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PropostaResponse>> AlterarStatusPropostaAsyncWithHttpInfo (long? id, StatusPropostaUpdate update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarStatusProposta");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AlterarStatusProposta");
            
    
            var localVarPath = "/api/propostas/{id}/alterar-status";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatusProposta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatusProposta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropostaResponse)));
            
        }
        
        /// <summary>
        /// Busca uma proposta pelo seu identificador Este servi\u00E7o busca uma proposta pelo seu identificador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Proposta (id)</param> 
        /// <returns>PropostaResponse</returns>
        public PropostaResponse ConsultarProposta (long? id)
        {
             ApiResponse<PropostaResponse> localVarResponse = ConsultarPropostaWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Busca uma proposta pelo seu identificador Este servi\u00E7o busca uma proposta pelo seu identificador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Proposta (id)</param> 
        /// <returns>ApiResponse of PropostaResponse</returns>
        public ApiResponse< PropostaResponse > ConsultarPropostaWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PropostaApi->ConsultarProposta");
            
    
            var localVarPath = "/api/propostas/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarProposta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarProposta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropostaResponse)));
            
        }

        
        /// <summary>
        /// Busca uma proposta pelo seu identificador Este servi\u00E7o busca uma proposta pelo seu identificador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Proposta (id)</param>
        /// <returns>Task of PropostaResponse</returns>
        public async System.Threading.Tasks.Task<PropostaResponse> ConsultarPropostaAsync (long? id)
        {
             ApiResponse<PropostaResponse> localVarResponse = await ConsultarPropostaAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Busca uma proposta pelo seu identificador Este servi\u00E7o busca uma proposta pelo seu identificador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Proposta (id)</param>
        /// <returns>Task of ApiResponse (PropostaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PropostaResponse>> ConsultarPropostaAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarProposta");
            
    
            var localVarPath = "/api/propostas/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarProposta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarProposta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropostaResponse)));
            
        }
        
        /// <summary>
        /// Cria\u00E7\u00E3o de documento proposta Cria um documento proposta e envia o arquivo relacionado a ele para o armazenamento na nuvem
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>DocumentoPropostaResponse</returns>
        public DocumentoPropostaResponse EnviarDocumentoDeProposta (DocumentoPropostaPersist persist)
        {
             ApiResponse<DocumentoPropostaResponse> localVarResponse = EnviarDocumentoDePropostaWithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cria\u00E7\u00E3o de documento proposta Cria um documento proposta e envia o arquivo relacionado a ele para o armazenamento na nuvem
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of DocumentoPropostaResponse</returns>
        public ApiResponse< DocumentoPropostaResponse > EnviarDocumentoDePropostaWithHttpInfo (DocumentoPropostaPersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling PropostaApi->EnviarDocumentoDeProposta");
            
    
            var localVarPath = "/api/documentos-propostas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling EnviarDocumentoDeProposta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EnviarDocumentoDeProposta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DocumentoPropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoPropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoPropostaResponse)));
            
        }

        
        /// <summary>
        /// Cria\u00E7\u00E3o de documento proposta Cria um documento proposta e envia o arquivo relacionado a ele para o armazenamento na nuvem
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of DocumentoPropostaResponse</returns>
        public async System.Threading.Tasks.Task<DocumentoPropostaResponse> EnviarDocumentoDePropostaAsync (DocumentoPropostaPersist persist)
        {
             ApiResponse<DocumentoPropostaResponse> localVarResponse = await EnviarDocumentoDePropostaAsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cria\u00E7\u00E3o de documento proposta Cria um documento proposta e envia o arquivo relacionado a ele para o armazenamento na nuvem
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DocumentoPropostaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentoPropostaResponse>> EnviarDocumentoDePropostaAsyncWithHttpInfo (DocumentoPropostaPersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling EnviarDocumentoDeProposta");
            
    
            var localVarPath = "/api/documentos-propostas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling EnviarDocumentoDeProposta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EnviarDocumentoDeProposta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentoPropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoPropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoPropostaResponse)));
            
        }
        
        /// <summary>
        /// Lista Documento Cr\u00E9dito Lista os documentos cr\u00E9dito que s\u00E3o os tipos de documentos proposta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do documento cr\u00E9dito(id) (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de documento cr\u00E9dito (optional)</param> 
        /// <param name="tela">Sinaliza a flag tela  (optional)</param> 
        /// <param name="doc">Sinaliza a flag doc (optional)</param> 
        /// <param name="idAtividadeDeCredito">C\u00F3digo de identifica\u00E7\u00E3o da atividade de cr\u00E9dito (optional)</param> 
        /// <param name="obrigatorio">Sinaliza a flag obrigaroio (optional)</param> 
        /// <returns>PageDocumentoCreditoResponse</returns>
        public PageDocumentoCreditoResponse ListarDocumentosDeCredito (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, int? tela = null, int? doc = null, long? idAtividadeDeCredito = null, int? obrigatorio = null)
        {
             ApiResponse<PageDocumentoCreditoResponse> localVarResponse = ListarDocumentosDeCreditoWithHttpInfo(sort, page, limit, id, descricao, tela, doc, idAtividadeDeCredito, obrigatorio);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista Documento Cr\u00E9dito Lista os documentos cr\u00E9dito que s\u00E3o os tipos de documentos proposta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do documento cr\u00E9dito(id) (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de documento cr\u00E9dito (optional)</param> 
        /// <param name="tela">Sinaliza a flag tela  (optional)</param> 
        /// <param name="doc">Sinaliza a flag doc (optional)</param> 
        /// <param name="idAtividadeDeCredito">C\u00F3digo de identifica\u00E7\u00E3o da atividade de cr\u00E9dito (optional)</param> 
        /// <param name="obrigatorio">Sinaliza a flag obrigaroio (optional)</param> 
        /// <returns>ApiResponse of PageDocumentoCreditoResponse</returns>
        public ApiResponse< PageDocumentoCreditoResponse > ListarDocumentosDeCreditoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, int? tela = null, int? doc = null, long? idAtividadeDeCredito = null, int? obrigatorio = null)
        {
            
    
            var localVarPath = "/api/documentos-creditos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (tela != null) localVarQueryParams.Add("tela", Configuration.ApiClient.ParameterToString(tela)); // query parameter
            if (doc != null) localVarQueryParams.Add("doc", Configuration.ApiClient.ParameterToString(doc)); // query parameter
            if (idAtividadeDeCredito != null) localVarQueryParams.Add("idAtividadeDeCredito", Configuration.ApiClient.ParameterToString(idAtividadeDeCredito)); // query parameter
            if (obrigatorio != null) localVarQueryParams.Add("obrigatorio", Configuration.ApiClient.ParameterToString(obrigatorio)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarDocumentosDeCredito: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarDocumentosDeCredito: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageDocumentoCreditoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDocumentoCreditoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDocumentoCreditoResponse)));
            
        }

        
        /// <summary>
        /// Lista Documento Cr\u00E9dito Lista os documentos cr\u00E9dito que s\u00E3o os tipos de documentos proposta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do documento cr\u00E9dito(id) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de documento cr\u00E9dito (optional)</param>
        /// <param name="tela">Sinaliza a flag tela  (optional)</param>
        /// <param name="doc">Sinaliza a flag doc (optional)</param>
        /// <param name="idAtividadeDeCredito">C\u00F3digo de identifica\u00E7\u00E3o da atividade de cr\u00E9dito (optional)</param>
        /// <param name="obrigatorio">Sinaliza a flag obrigaroio (optional)</param>
        /// <returns>Task of PageDocumentoCreditoResponse</returns>
        public async System.Threading.Tasks.Task<PageDocumentoCreditoResponse> ListarDocumentosDeCreditoAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, int? tela = null, int? doc = null, long? idAtividadeDeCredito = null, int? obrigatorio = null)
        {
             ApiResponse<PageDocumentoCreditoResponse> localVarResponse = await ListarDocumentosDeCreditoAsyncWithHttpInfo(sort, page, limit, id, descricao, tela, doc, idAtividadeDeCredito, obrigatorio);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista Documento Cr\u00E9dito Lista os documentos cr\u00E9dito que s\u00E3o os tipos de documentos proposta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do documento cr\u00E9dito(id) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de documento cr\u00E9dito (optional)</param>
        /// <param name="tela">Sinaliza a flag tela  (optional)</param>
        /// <param name="doc">Sinaliza a flag doc (optional)</param>
        /// <param name="idAtividadeDeCredito">C\u00F3digo de identifica\u00E7\u00E3o da atividade de cr\u00E9dito (optional)</param>
        /// <param name="obrigatorio">Sinaliza a flag obrigaroio (optional)</param>
        /// <returns>Task of ApiResponse (PageDocumentoCreditoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageDocumentoCreditoResponse>> ListarDocumentosDeCreditoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, int? tela = null, int? doc = null, long? idAtividadeDeCredito = null, int? obrigatorio = null)
        {
            
    
            var localVarPath = "/api/documentos-creditos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (tela != null) localVarQueryParams.Add("tela", Configuration.ApiClient.ParameterToString(tela)); // query parameter
            if (doc != null) localVarQueryParams.Add("doc", Configuration.ApiClient.ParameterToString(doc)); // query parameter
            if (idAtividadeDeCredito != null) localVarQueryParams.Add("idAtividadeDeCredito", Configuration.ApiClient.ParameterToString(idAtividadeDeCredito)); // query parameter
            if (obrigatorio != null) localVarQueryParams.Add("obrigatorio", Configuration.ApiClient.ParameterToString(obrigatorio)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarDocumentosDeCredito: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarDocumentosDeCredito: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageDocumentoCreditoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDocumentoCreditoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDocumentoCreditoResponse)));
            
        }
        
        /// <summary>
        /// Lista Documentos proposta Lista os documentos proposta filtrados
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do documento proposta(id) (optional)</param> 
        /// <param name="idProposta">C\u00F3digo de identifica\u00E7\u00E3o da proposta(id) (optional)</param> 
        /// <param name="idDocumentosCredito">C\u00F3digo de identifica\u00E7\u00E3o para o tipo do documento (optional)</param> 
        /// <param name="idStatusDocumentosCredito">C\u00F3digo de identifica\u00E7\u00E3o do Status do documento cr\u00E9dito (optional)</param> 
        /// <param name="idCondicoesDocumentosCredito">C\u00F3digo de identifica\u00E7\u00E3o da condi\u00E7\u00E3o do documento cr\u00E9dito (optional)</param> 
        /// <param name="idTipoDocumentoCredito">C\u00F3digo de identifica\u00E7\u00E3o do tipo do documento cr\u00E9dito (optional)</param> 
        /// <param name="idPessoaFisica">C\u00F3digo de identifica\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param> 
        /// <param name="idLogAtendimento">C\u00F3digo de identifica\u00E7\u00E3o do Log de Atendimento (optional)</param> 
        /// <param name="responsavel">Respons\u00E1vel (optional)</param> 
        /// <param name="flagDocumentoDigitalizado">Indica se o documento ser\u00E1 digitalizado (optional)</param> 
        /// <param name="documentoDigitalizado">Nome do documento digitalizado (optional)</param> 
        /// <param name="seqAnaliseCondicao">C\u00F3digo de sequ\u00EAncia de analise de condi\u00E7\u00E3o (optional)</param> 
        /// <param name="observacao">Observa\u00E7\u00E3o (optional)</param> 
        /// <param name="dataStatus">Data de status (optional)</param> 
        /// <returns>PageDocumentoPropostaResponse</returns>
        public PageDocumentoPropostaResponse ListarDocumentosDeProposta (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idProposta = null, long? idDocumentosCredito = null, long? idStatusDocumentosCredito = null, long? idCondicoesDocumentosCredito = null, long? idTipoDocumentoCredito = null, long? idPessoaFisica = null, long? idLogAtendimento = null, string responsavel = null, int? flagDocumentoDigitalizado = null, string documentoDigitalizado = null, long? seqAnaliseCondicao = null, string observacao = null, string dataStatus = null)
        {
             ApiResponse<PageDocumentoPropostaResponse> localVarResponse = ListarDocumentosDePropostaWithHttpInfo(sort, page, limit, id, idProposta, idDocumentosCredito, idStatusDocumentosCredito, idCondicoesDocumentosCredito, idTipoDocumentoCredito, idPessoaFisica, idLogAtendimento, responsavel, flagDocumentoDigitalizado, documentoDigitalizado, seqAnaliseCondicao, observacao, dataStatus);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista Documentos proposta Lista os documentos proposta filtrados
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do documento proposta(id) (optional)</param> 
        /// <param name="idProposta">C\u00F3digo de identifica\u00E7\u00E3o da proposta(id) (optional)</param> 
        /// <param name="idDocumentosCredito">C\u00F3digo de identifica\u00E7\u00E3o para o tipo do documento (optional)</param> 
        /// <param name="idStatusDocumentosCredito">C\u00F3digo de identifica\u00E7\u00E3o do Status do documento cr\u00E9dito (optional)</param> 
        /// <param name="idCondicoesDocumentosCredito">C\u00F3digo de identifica\u00E7\u00E3o da condi\u00E7\u00E3o do documento cr\u00E9dito (optional)</param> 
        /// <param name="idTipoDocumentoCredito">C\u00F3digo de identifica\u00E7\u00E3o do tipo do documento cr\u00E9dito (optional)</param> 
        /// <param name="idPessoaFisica">C\u00F3digo de identifica\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param> 
        /// <param name="idLogAtendimento">C\u00F3digo de identifica\u00E7\u00E3o do Log de Atendimento (optional)</param> 
        /// <param name="responsavel">Respons\u00E1vel (optional)</param> 
        /// <param name="flagDocumentoDigitalizado">Indica se o documento ser\u00E1 digitalizado (optional)</param> 
        /// <param name="documentoDigitalizado">Nome do documento digitalizado (optional)</param> 
        /// <param name="seqAnaliseCondicao">C\u00F3digo de sequ\u00EAncia de analise de condi\u00E7\u00E3o (optional)</param> 
        /// <param name="observacao">Observa\u00E7\u00E3o (optional)</param> 
        /// <param name="dataStatus">Data de status (optional)</param> 
        /// <returns>ApiResponse of PageDocumentoPropostaResponse</returns>
        public ApiResponse< PageDocumentoPropostaResponse > ListarDocumentosDePropostaWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idProposta = null, long? idDocumentosCredito = null, long? idStatusDocumentosCredito = null, long? idCondicoesDocumentosCredito = null, long? idTipoDocumentoCredito = null, long? idPessoaFisica = null, long? idLogAtendimento = null, string responsavel = null, int? flagDocumentoDigitalizado = null, string documentoDigitalizado = null, long? seqAnaliseCondicao = null, string observacao = null, string dataStatus = null)
        {
            
    
            var localVarPath = "/api/documentos-propostas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idProposta != null) localVarQueryParams.Add("idProposta", Configuration.ApiClient.ParameterToString(idProposta)); // query parameter
            if (idDocumentosCredito != null) localVarQueryParams.Add("idDocumentosCredito", Configuration.ApiClient.ParameterToString(idDocumentosCredito)); // query parameter
            if (idStatusDocumentosCredito != null) localVarQueryParams.Add("idStatusDocumentosCredito", Configuration.ApiClient.ParameterToString(idStatusDocumentosCredito)); // query parameter
            if (idCondicoesDocumentosCredito != null) localVarQueryParams.Add("idCondicoesDocumentosCredito", Configuration.ApiClient.ParameterToString(idCondicoesDocumentosCredito)); // query parameter
            if (idTipoDocumentoCredito != null) localVarQueryParams.Add("idTipoDocumentoCredito", Configuration.ApiClient.ParameterToString(idTipoDocumentoCredito)); // query parameter
            if (idPessoaFisica != null) localVarQueryParams.Add("idPessoaFisica", Configuration.ApiClient.ParameterToString(idPessoaFisica)); // query parameter
            if (idLogAtendimento != null) localVarQueryParams.Add("idLogAtendimento", Configuration.ApiClient.ParameterToString(idLogAtendimento)); // query parameter
            if (responsavel != null) localVarQueryParams.Add("responsavel", Configuration.ApiClient.ParameterToString(responsavel)); // query parameter
            if (flagDocumentoDigitalizado != null) localVarQueryParams.Add("flagDocumentoDigitalizado", Configuration.ApiClient.ParameterToString(flagDocumentoDigitalizado)); // query parameter
            if (documentoDigitalizado != null) localVarQueryParams.Add("documentoDigitalizado", Configuration.ApiClient.ParameterToString(documentoDigitalizado)); // query parameter
            if (seqAnaliseCondicao != null) localVarQueryParams.Add("seqAnaliseCondicao", Configuration.ApiClient.ParameterToString(seqAnaliseCondicao)); // query parameter
            if (observacao != null) localVarQueryParams.Add("observacao", Configuration.ApiClient.ParameterToString(observacao)); // query parameter
            if (dataStatus != null) localVarQueryParams.Add("dataStatus", Configuration.ApiClient.ParameterToString(dataStatus)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarDocumentosDeProposta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarDocumentosDeProposta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageDocumentoPropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDocumentoPropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDocumentoPropostaResponse)));
            
        }

        
        /// <summary>
        /// Lista Documentos proposta Lista os documentos proposta filtrados
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do documento proposta(id) (optional)</param>
        /// <param name="idProposta">C\u00F3digo de identifica\u00E7\u00E3o da proposta(id) (optional)</param>
        /// <param name="idDocumentosCredito">C\u00F3digo de identifica\u00E7\u00E3o para o tipo do documento (optional)</param>
        /// <param name="idStatusDocumentosCredito">C\u00F3digo de identifica\u00E7\u00E3o do Status do documento cr\u00E9dito (optional)</param>
        /// <param name="idCondicoesDocumentosCredito">C\u00F3digo de identifica\u00E7\u00E3o da condi\u00E7\u00E3o do documento cr\u00E9dito (optional)</param>
        /// <param name="idTipoDocumentoCredito">C\u00F3digo de identifica\u00E7\u00E3o do tipo do documento cr\u00E9dito (optional)</param>
        /// <param name="idPessoaFisica">C\u00F3digo de identifica\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="idLogAtendimento">C\u00F3digo de identifica\u00E7\u00E3o do Log de Atendimento (optional)</param>
        /// <param name="responsavel">Respons\u00E1vel (optional)</param>
        /// <param name="flagDocumentoDigitalizado">Indica se o documento ser\u00E1 digitalizado (optional)</param>
        /// <param name="documentoDigitalizado">Nome do documento digitalizado (optional)</param>
        /// <param name="seqAnaliseCondicao">C\u00F3digo de sequ\u00EAncia de analise de condi\u00E7\u00E3o (optional)</param>
        /// <param name="observacao">Observa\u00E7\u00E3o (optional)</param>
        /// <param name="dataStatus">Data de status (optional)</param>
        /// <returns>Task of PageDocumentoPropostaResponse</returns>
        public async System.Threading.Tasks.Task<PageDocumentoPropostaResponse> ListarDocumentosDePropostaAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idProposta = null, long? idDocumentosCredito = null, long? idStatusDocumentosCredito = null, long? idCondicoesDocumentosCredito = null, long? idTipoDocumentoCredito = null, long? idPessoaFisica = null, long? idLogAtendimento = null, string responsavel = null, int? flagDocumentoDigitalizado = null, string documentoDigitalizado = null, long? seqAnaliseCondicao = null, string observacao = null, string dataStatus = null)
        {
             ApiResponse<PageDocumentoPropostaResponse> localVarResponse = await ListarDocumentosDePropostaAsyncWithHttpInfo(sort, page, limit, id, idProposta, idDocumentosCredito, idStatusDocumentosCredito, idCondicoesDocumentosCredito, idTipoDocumentoCredito, idPessoaFisica, idLogAtendimento, responsavel, flagDocumentoDigitalizado, documentoDigitalizado, seqAnaliseCondicao, observacao, dataStatus);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista Documentos proposta Lista os documentos proposta filtrados
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do documento proposta(id) (optional)</param>
        /// <param name="idProposta">C\u00F3digo de identifica\u00E7\u00E3o da proposta(id) (optional)</param>
        /// <param name="idDocumentosCredito">C\u00F3digo de identifica\u00E7\u00E3o para o tipo do documento (optional)</param>
        /// <param name="idStatusDocumentosCredito">C\u00F3digo de identifica\u00E7\u00E3o do Status do documento cr\u00E9dito (optional)</param>
        /// <param name="idCondicoesDocumentosCredito">C\u00F3digo de identifica\u00E7\u00E3o da condi\u00E7\u00E3o do documento cr\u00E9dito (optional)</param>
        /// <param name="idTipoDocumentoCredito">C\u00F3digo de identifica\u00E7\u00E3o do tipo do documento cr\u00E9dito (optional)</param>
        /// <param name="idPessoaFisica">C\u00F3digo de identifica\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="idLogAtendimento">C\u00F3digo de identifica\u00E7\u00E3o do Log de Atendimento (optional)</param>
        /// <param name="responsavel">Respons\u00E1vel (optional)</param>
        /// <param name="flagDocumentoDigitalizado">Indica se o documento ser\u00E1 digitalizado (optional)</param>
        /// <param name="documentoDigitalizado">Nome do documento digitalizado (optional)</param>
        /// <param name="seqAnaliseCondicao">C\u00F3digo de sequ\u00EAncia de analise de condi\u00E7\u00E3o (optional)</param>
        /// <param name="observacao">Observa\u00E7\u00E3o (optional)</param>
        /// <param name="dataStatus">Data de status (optional)</param>
        /// <returns>Task of ApiResponse (PageDocumentoPropostaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageDocumentoPropostaResponse>> ListarDocumentosDePropostaAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idProposta = null, long? idDocumentosCredito = null, long? idStatusDocumentosCredito = null, long? idCondicoesDocumentosCredito = null, long? idTipoDocumentoCredito = null, long? idPessoaFisica = null, long? idLogAtendimento = null, string responsavel = null, int? flagDocumentoDigitalizado = null, string documentoDigitalizado = null, long? seqAnaliseCondicao = null, string observacao = null, string dataStatus = null)
        {
            
    
            var localVarPath = "/api/documentos-propostas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idProposta != null) localVarQueryParams.Add("idProposta", Configuration.ApiClient.ParameterToString(idProposta)); // query parameter
            if (idDocumentosCredito != null) localVarQueryParams.Add("idDocumentosCredito", Configuration.ApiClient.ParameterToString(idDocumentosCredito)); // query parameter
            if (idStatusDocumentosCredito != null) localVarQueryParams.Add("idStatusDocumentosCredito", Configuration.ApiClient.ParameterToString(idStatusDocumentosCredito)); // query parameter
            if (idCondicoesDocumentosCredito != null) localVarQueryParams.Add("idCondicoesDocumentosCredito", Configuration.ApiClient.ParameterToString(idCondicoesDocumentosCredito)); // query parameter
            if (idTipoDocumentoCredito != null) localVarQueryParams.Add("idTipoDocumentoCredito", Configuration.ApiClient.ParameterToString(idTipoDocumentoCredito)); // query parameter
            if (idPessoaFisica != null) localVarQueryParams.Add("idPessoaFisica", Configuration.ApiClient.ParameterToString(idPessoaFisica)); // query parameter
            if (idLogAtendimento != null) localVarQueryParams.Add("idLogAtendimento", Configuration.ApiClient.ParameterToString(idLogAtendimento)); // query parameter
            if (responsavel != null) localVarQueryParams.Add("responsavel", Configuration.ApiClient.ParameterToString(responsavel)); // query parameter
            if (flagDocumentoDigitalizado != null) localVarQueryParams.Add("flagDocumentoDigitalizado", Configuration.ApiClient.ParameterToString(flagDocumentoDigitalizado)); // query parameter
            if (documentoDigitalizado != null) localVarQueryParams.Add("documentoDigitalizado", Configuration.ApiClient.ParameterToString(documentoDigitalizado)); // query parameter
            if (seqAnaliseCondicao != null) localVarQueryParams.Add("seqAnaliseCondicao", Configuration.ApiClient.ParameterToString(seqAnaliseCondicao)); // query parameter
            if (observacao != null) localVarQueryParams.Add("observacao", Configuration.ApiClient.ParameterToString(observacao)); // query parameter
            if (dataStatus != null) localVarQueryParams.Add("dataStatus", Configuration.ApiClient.ParameterToString(dataStatus)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarDocumentosDeProposta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarDocumentosDeProposta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageDocumentoPropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDocumentoPropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDocumentoPropostaResponse)));
            
        }
        
        /// <summary>
        /// Lista todas as propostas Este servi\u00E7o lista todas as propostas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="status">Status da proposta (optional)</param> 
        /// <param name="idPessoaFisica">Identificador da Pessoa Fisica (optional)</param> 
        /// <returns>PagePropostaResponse</returns>
        public PagePropostaResponse ListarPropostas (List<string> sort = null, int? page = null, int? limit = null, int? status = null, long? idPessoaFisica = null)
        {
             ApiResponse<PagePropostaResponse> localVarResponse = ListarPropostasWithHttpInfo(sort, page, limit, status, idPessoaFisica);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista todas as propostas Este servi\u00E7o lista todas as propostas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="status">Status da proposta (optional)</param> 
        /// <param name="idPessoaFisica">Identificador da Pessoa Fisica (optional)</param> 
        /// <returns>ApiResponse of PagePropostaResponse</returns>
        public ApiResponse< PagePropostaResponse > ListarPropostasWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, int? status = null, long? idPessoaFisica = null)
        {
            
    
            var localVarPath = "/api/propostas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (idPessoaFisica != null) localVarQueryParams.Add("idPessoaFisica", Configuration.ApiClient.ParameterToString(idPessoaFisica)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarPropostas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPropostas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePropostaResponse)));
            
        }

        
        /// <summary>
        /// Lista todas as propostas Este servi\u00E7o lista todas as propostas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="status">Status da proposta (optional)</param>
        /// <param name="idPessoaFisica">Identificador da Pessoa Fisica (optional)</param>
        /// <returns>Task of PagePropostaResponse</returns>
        public async System.Threading.Tasks.Task<PagePropostaResponse> ListarPropostasAsync (List<string> sort = null, int? page = null, int? limit = null, int? status = null, long? idPessoaFisica = null)
        {
             ApiResponse<PagePropostaResponse> localVarResponse = await ListarPropostasAsyncWithHttpInfo(sort, page, limit, status, idPessoaFisica);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista todas as propostas Este servi\u00E7o lista todas as propostas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="status">Status da proposta (optional)</param>
        /// <param name="idPessoaFisica">Identificador da Pessoa Fisica (optional)</param>
        /// <returns>Task of ApiResponse (PagePropostaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePropostaResponse>> ListarPropostasAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, int? status = null, long? idPessoaFisica = null)
        {
            
    
            var localVarPath = "/api/propostas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (idPessoaFisica != null) localVarQueryParams.Add("idPessoaFisica", Configuration.ApiClient.ParameterToString(idPessoaFisica)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarPropostas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPropostas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePropostaResponse)));
            
        }
        
        /// <summary>
        /// Lista todos os status poss\u00EDveis nas propostas existentes Este servi\u00E7o lista todos os status poss\u00EDveis nas propostas existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="status">Status da proposta (optional)</param> 
        /// <param name="flagPermiteAlteracao">Flag que permite a altera\u00E7\u00E3o do status da proposta (optional)</param> 
        /// <returns>PageStatusPropostaResponse</returns>
        public PageStatusPropostaResponse ListarStatusPropostas (List<string> sort = null, int? page = null, int? limit = null, int? status = null, bool? flagPermiteAlteracao = null)
        {
             ApiResponse<PageStatusPropostaResponse> localVarResponse = ListarStatusPropostasWithHttpInfo(sort, page, limit, status, flagPermiteAlteracao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista todos os status poss\u00EDveis nas propostas existentes Este servi\u00E7o lista todos os status poss\u00EDveis nas propostas existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="status">Status da proposta (optional)</param> 
        /// <param name="flagPermiteAlteracao">Flag que permite a altera\u00E7\u00E3o do status da proposta (optional)</param> 
        /// <returns>ApiResponse of PageStatusPropostaResponse</returns>
        public ApiResponse< PageStatusPropostaResponse > ListarStatusPropostasWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, int? status = null, bool? flagPermiteAlteracao = null)
        {
            
    
            var localVarPath = "/api/status-propostas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (flagPermiteAlteracao != null) localVarQueryParams.Add("flagPermiteAlteracao", Configuration.ApiClient.ParameterToString(flagPermiteAlteracao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusPropostas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusPropostas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageStatusPropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusPropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusPropostaResponse)));
            
        }

        
        /// <summary>
        /// Lista todos os status poss\u00EDveis nas propostas existentes Este servi\u00E7o lista todos os status poss\u00EDveis nas propostas existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="status">Status da proposta (optional)</param>
        /// <param name="flagPermiteAlteracao">Flag que permite a altera\u00E7\u00E3o do status da proposta (optional)</param>
        /// <returns>Task of PageStatusPropostaResponse</returns>
        public async System.Threading.Tasks.Task<PageStatusPropostaResponse> ListarStatusPropostasAsync (List<string> sort = null, int? page = null, int? limit = null, int? status = null, bool? flagPermiteAlteracao = null)
        {
             ApiResponse<PageStatusPropostaResponse> localVarResponse = await ListarStatusPropostasAsyncWithHttpInfo(sort, page, limit, status, flagPermiteAlteracao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista todos os status poss\u00EDveis nas propostas existentes Este servi\u00E7o lista todos os status poss\u00EDveis nas propostas existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="status">Status da proposta (optional)</param>
        /// <param name="flagPermiteAlteracao">Flag que permite a altera\u00E7\u00E3o do status da proposta (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusPropostaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageStatusPropostaResponse>> ListarStatusPropostasAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, int? status = null, bool? flagPermiteAlteracao = null)
        {
            
    
            var localVarPath = "/api/status-propostas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (flagPermiteAlteracao != null) localVarQueryParams.Add("flagPermiteAlteracao", Configuration.ApiClient.ParameterToString(flagPermiteAlteracao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusPropostas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusPropostas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageStatusPropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusPropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusPropostaResponse)));
            
        }
        
    }
    
}
