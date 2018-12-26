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
        /// Altera o status de uma proposta
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o altera o status de uma proposta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Proposta (id)</param>
        /// <param name="update">update</param>
        /// <returns>PropostaResponse</returns>
        PropostaResponse Alterar (long? id, StatusPropostaUpdate update);
  
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
        ApiResponse<PropostaResponse> AlterarWithHttpInfo (long? id, StatusPropostaUpdate update);
        
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
        PropostaResponse AlterarParcial (long? id, PropostaParcialUpdate propostaParcialUpdate);
  
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
        ApiResponse<PropostaResponse> AlterarParcialWithHttpInfo (long? id, PropostaParcialUpdate propostaParcialUpdate);
        
        /// <summary>
        /// Busca uma proposta pelo seu identificador
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o busca uma proposta pelo seu identificador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Proposta (id)</param>
        /// <returns>PropostaResponse</returns>
        PropostaResponse Consultar (long? id);
  
        /// <summary>
        /// Busca uma proposta pelo seu identificador
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o busca uma proposta pelo seu identificador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Proposta (id)</param>
        /// <returns>ApiResponse of PropostaResponse</returns>
        ApiResponse<PropostaResponse> ConsultarWithHttpInfo (long? id);
        
        /// <summary>
        /// Cria\u00E7\u00E3o de documento proposta
        /// </summary>
        /// <remarks>
        /// Cria um documento proposta e envia o arquivo relacionado a ele para o armazenamento na nuvem
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>DocumentoPropostaResponse</returns>
        DocumentoPropostaResponse EnviarDocumentoProposta (DocumentoPropostaPersist persist);
  
        /// <summary>
        /// Cria\u00E7\u00E3o de documento proposta
        /// </summary>
        /// <remarks>
        /// Cria um documento proposta e envia o arquivo relacionado a ele para o armazenamento na nuvem
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of DocumentoPropostaResponse</returns>
        ApiResponse<DocumentoPropostaResponse> EnviarDocumentoPropostaWithHttpInfo (DocumentoPropostaPersist persist);
        
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
        PagePropostaResponse Listar (List<string> sort = null, int? page = null, int? limit = null, int? status = null, long? idPessoaFisica = null);
  
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
        ApiResponse<PagePropostaResponse> ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, int? status = null, long? idPessoaFisica = null);
        
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
        PageDocumentoCreditoResponse ListarDocumentosCredito (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, int? tela = null, int? doc = null, long? idAtividadeDeCredito = null, int? obrigatorio = null);
  
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
        ApiResponse<PageDocumentoCreditoResponse> ListarDocumentosCreditoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, int? tela = null, int? doc = null, long? idAtividadeDeCredito = null, int? obrigatorio = null);
        
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
        PageDocumentoPropostaResponse ListarDocumentosProposta (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idProposta = null, long? idDocumentosCredito = null, long? idStatusDocumentosCredito = null, long? idCondicoesDocumentosCredito = null, long? idTipoDocumentoCredito = null, long? idPessoaFisica = null, long? idLogAtendimento = null, string responsavel = null, int? flagDocumentoDigitalizado = null, string documentoDigitalizado = null, long? seqAnaliseCondicao = null, string observacao = null, string dataStatus = null);
  
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
        ApiResponse<PageDocumentoPropostaResponse> ListarDocumentosPropostaWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idProposta = null, long? idDocumentosCredito = null, long? idStatusDocumentosCredito = null, long? idCondicoesDocumentosCredito = null, long? idTipoDocumentoCredito = null, long? idPessoaFisica = null, long? idLogAtendimento = null, string responsavel = null, int? flagDocumentoDigitalizado = null, string documentoDigitalizado = null, long? seqAnaliseCondicao = null, string observacao = null, string dataStatus = null);
        
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
        PageStatusPropostaResponse ListarStatusProposta (List<string> sort = null, int? page = null, int? limit = null, int? status = null, bool? flagPermiteAlteracao = null);
  
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
        ApiResponse<PageStatusPropostaResponse> ListarStatusPropostaWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, int? status = null, bool? flagPermiteAlteracao = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
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
        System.Threading.Tasks.Task<PropostaResponse> AlterarAsync (long? id, StatusPropostaUpdate update);

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
        System.Threading.Tasks.Task<ApiResponse<PropostaResponse>> AlterarAsyncWithHttpInfo (long? id, StatusPropostaUpdate update);
        
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
        System.Threading.Tasks.Task<PropostaResponse> AlterarParcialAsync (long? id, PropostaParcialUpdate propostaParcialUpdate);

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
        System.Threading.Tasks.Task<ApiResponse<PropostaResponse>> AlterarParcialAsyncWithHttpInfo (long? id, PropostaParcialUpdate propostaParcialUpdate);
        
        /// <summary>
        /// Busca uma proposta pelo seu identificador
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o busca uma proposta pelo seu identificador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Proposta (id)</param>
        /// <returns>Task of PropostaResponse</returns>
        System.Threading.Tasks.Task<PropostaResponse> ConsultarAsync (long? id);

        /// <summary>
        /// Busca uma proposta pelo seu identificador
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o busca uma proposta pelo seu identificador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Proposta (id)</param>
        /// <returns>Task of ApiResponse (PropostaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PropostaResponse>> ConsultarAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Cria\u00E7\u00E3o de documento proposta
        /// </summary>
        /// <remarks>
        /// Cria um documento proposta e envia o arquivo relacionado a ele para o armazenamento na nuvem
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of DocumentoPropostaResponse</returns>
        System.Threading.Tasks.Task<DocumentoPropostaResponse> EnviarDocumentoPropostaAsync (DocumentoPropostaPersist persist);

        /// <summary>
        /// Cria\u00E7\u00E3o de documento proposta
        /// </summary>
        /// <remarks>
        /// Cria um documento proposta e envia o arquivo relacionado a ele para o armazenamento na nuvem
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DocumentoPropostaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentoPropostaResponse>> EnviarDocumentoPropostaAsyncWithHttpInfo (DocumentoPropostaPersist persist);
        
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
        System.Threading.Tasks.Task<PagePropostaResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, int? status = null, long? idPessoaFisica = null);

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
        System.Threading.Tasks.Task<ApiResponse<PagePropostaResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, int? status = null, long? idPessoaFisica = null);
        
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
        System.Threading.Tasks.Task<PageDocumentoCreditoResponse> ListarDocumentosCreditoAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, int? tela = null, int? doc = null, long? idAtividadeDeCredito = null, int? obrigatorio = null);

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
        System.Threading.Tasks.Task<ApiResponse<PageDocumentoCreditoResponse>> ListarDocumentosCreditoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, int? tela = null, int? doc = null, long? idAtividadeDeCredito = null, int? obrigatorio = null);
        
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
        System.Threading.Tasks.Task<PageDocumentoPropostaResponse> ListarDocumentosPropostaAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idProposta = null, long? idDocumentosCredito = null, long? idStatusDocumentosCredito = null, long? idCondicoesDocumentosCredito = null, long? idTipoDocumentoCredito = null, long? idPessoaFisica = null, long? idLogAtendimento = null, string responsavel = null, int? flagDocumentoDigitalizado = null, string documentoDigitalizado = null, long? seqAnaliseCondicao = null, string observacao = null, string dataStatus = null);

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
        System.Threading.Tasks.Task<ApiResponse<PageDocumentoPropostaResponse>> ListarDocumentosPropostaAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idProposta = null, long? idDocumentosCredito = null, long? idStatusDocumentosCredito = null, long? idCondicoesDocumentosCredito = null, long? idTipoDocumentoCredito = null, long? idPessoaFisica = null, long? idLogAtendimento = null, string responsavel = null, int? flagDocumentoDigitalizado = null, string documentoDigitalizado = null, long? seqAnaliseCondicao = null, string observacao = null, string dataStatus = null);
        
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
        System.Threading.Tasks.Task<PageStatusPropostaResponse> ListarStatusPropostaAsync (List<string> sort = null, int? page = null, int? limit = null, int? status = null, bool? flagPermiteAlteracao = null);

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
        System.Threading.Tasks.Task<ApiResponse<PageStatusPropostaResponse>> ListarStatusPropostaAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, int? status = null, bool? flagPermiteAlteracao = null);
        
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
        /// Altera o status de uma proposta Este servi\u00E7o altera o status de uma proposta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Proposta (id)</param> 
        /// <param name="update">update</param> 
        /// <returns>PropostaResponse</returns>
        public PropostaResponse Alterar (long? id, StatusPropostaUpdate update)
        {
             ApiResponse<PropostaResponse> localVarResponse = AlterarWithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera o status de uma proposta Este servi\u00E7o altera o status de uma proposta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Proposta (id)</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of PropostaResponse</returns>
        public ApiResponse< PropostaResponse > AlterarWithHttpInfo (long? id, StatusPropostaUpdate update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PropostaApi->Alterar");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling PropostaApi->Alterar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<PropostaResponse> AlterarAsync (long? id, StatusPropostaUpdate update)
        {
             ApiResponse<PropostaResponse> localVarResponse = await AlterarAsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera o status de uma proposta Este servi\u00E7o altera o status de uma proposta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Proposta (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (PropostaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PropostaResponse>> AlterarAsyncWithHttpInfo (long? id, StatusPropostaUpdate update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Alterar");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling Alterar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        /// <returns>PropostaResponse</returns>
        public PropostaResponse AlterarParcial (long? id, PropostaParcialUpdate propostaParcialUpdate)
        {
             ApiResponse<PropostaResponse> localVarResponse = AlterarParcialWithHttpInfo(id, propostaParcialUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera parcialmente a proposta. Este recurso permite alterar os campos de uma proposta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Indentificador da proposta.</param> 
        /// <param name="propostaParcialUpdate">propostaParcialUpdate</param> 
        /// <returns>ApiResponse of PropostaResponse</returns>
        public ApiResponse< PropostaResponse > AlterarParcialWithHttpInfo (long? id, PropostaParcialUpdate propostaParcialUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PropostaApi->AlterarParcial");
            
            // verify the required parameter 'propostaParcialUpdate' is set
            if (propostaParcialUpdate == null)
                throw new ApiException(400, "Missing required parameter 'propostaParcialUpdate' when calling PropostaApi->AlterarParcial");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarParcial: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarParcial: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<PropostaResponse> AlterarParcialAsync (long? id, PropostaParcialUpdate propostaParcialUpdate)
        {
             ApiResponse<PropostaResponse> localVarResponse = await AlterarParcialAsyncWithHttpInfo(id, propostaParcialUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera parcialmente a proposta. Este recurso permite alterar os campos de uma proposta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Indentificador da proposta.</param>
        /// <param name="propostaParcialUpdate">propostaParcialUpdate</param>
        /// <returns>Task of ApiResponse (PropostaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PropostaResponse>> AlterarParcialAsyncWithHttpInfo (long? id, PropostaParcialUpdate propostaParcialUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarParcial");
            // verify the required parameter 'propostaParcialUpdate' is set
            if (propostaParcialUpdate == null) throw new ApiException(400, "Missing required parameter 'propostaParcialUpdate' when calling AlterarParcial");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarParcial: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarParcial: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public PropostaResponse Consultar (long? id)
        {
             ApiResponse<PropostaResponse> localVarResponse = ConsultarWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Busca uma proposta pelo seu identificador Este servi\u00E7o busca uma proposta pelo seu identificador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Proposta (id)</param> 
        /// <returns>ApiResponse of PropostaResponse</returns>
        public ApiResponse< PropostaResponse > ConsultarWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PropostaApi->Consultar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<PropostaResponse> ConsultarAsync (long? id)
        {
             ApiResponse<PropostaResponse> localVarResponse = await ConsultarAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Busca uma proposta pelo seu identificador Este servi\u00E7o busca uma proposta pelo seu identificador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Proposta (id)</param>
        /// <returns>Task of ApiResponse (PropostaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PropostaResponse>> ConsultarAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public DocumentoPropostaResponse EnviarDocumentoProposta (DocumentoPropostaPersist persist)
        {
             ApiResponse<DocumentoPropostaResponse> localVarResponse = EnviarDocumentoPropostaWithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cria\u00E7\u00E3o de documento proposta Cria um documento proposta e envia o arquivo relacionado a ele para o armazenamento na nuvem
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of DocumentoPropostaResponse</returns>
        public ApiResponse< DocumentoPropostaResponse > EnviarDocumentoPropostaWithHttpInfo (DocumentoPropostaPersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling PropostaApi->EnviarDocumentoProposta");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling EnviarDocumentoProposta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EnviarDocumentoProposta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<DocumentoPropostaResponse> EnviarDocumentoPropostaAsync (DocumentoPropostaPersist persist)
        {
             ApiResponse<DocumentoPropostaResponse> localVarResponse = await EnviarDocumentoPropostaAsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cria\u00E7\u00E3o de documento proposta Cria um documento proposta e envia o arquivo relacionado a ele para o armazenamento na nuvem
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DocumentoPropostaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentoPropostaResponse>> EnviarDocumentoPropostaAsyncWithHttpInfo (DocumentoPropostaPersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling EnviarDocumentoProposta");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling EnviarDocumentoProposta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EnviarDocumentoProposta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentoPropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoPropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoPropostaResponse)));
            
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
        public PagePropostaResponse Listar (List<string> sort = null, int? page = null, int? limit = null, int? status = null, long? idPessoaFisica = null)
        {
             ApiResponse<PagePropostaResponse> localVarResponse = ListarWithHttpInfo(sort, page, limit, status, idPessoaFisica);
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
        public ApiResponse< PagePropostaResponse > ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, int? status = null, long? idPessoaFisica = null)
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
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<PagePropostaResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, int? status = null, long? idPessoaFisica = null)
        {
             ApiResponse<PagePropostaResponse> localVarResponse = await ListarAsyncWithHttpInfo(sort, page, limit, status, idPessoaFisica);
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
        public async System.Threading.Tasks.Task<ApiResponse<PagePropostaResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, int? status = null, long? idPessoaFisica = null)
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
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePropostaResponse)));
            
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
        public PageDocumentoCreditoResponse ListarDocumentosCredito (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, int? tela = null, int? doc = null, long? idAtividadeDeCredito = null, int? obrigatorio = null)
        {
             ApiResponse<PageDocumentoCreditoResponse> localVarResponse = ListarDocumentosCreditoWithHttpInfo(sort, page, limit, id, descricao, tela, doc, idAtividadeDeCredito, obrigatorio);
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
        public ApiResponse< PageDocumentoCreditoResponse > ListarDocumentosCreditoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, int? tela = null, int? doc = null, long? idAtividadeDeCredito = null, int? obrigatorio = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarDocumentosCredito: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarDocumentosCredito: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<PageDocumentoCreditoResponse> ListarDocumentosCreditoAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, int? tela = null, int? doc = null, long? idAtividadeDeCredito = null, int? obrigatorio = null)
        {
             ApiResponse<PageDocumentoCreditoResponse> localVarResponse = await ListarDocumentosCreditoAsyncWithHttpInfo(sort, page, limit, id, descricao, tela, doc, idAtividadeDeCredito, obrigatorio);
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
        public async System.Threading.Tasks.Task<ApiResponse<PageDocumentoCreditoResponse>> ListarDocumentosCreditoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, int? tela = null, int? doc = null, long? idAtividadeDeCredito = null, int? obrigatorio = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarDocumentosCredito: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarDocumentosCredito: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public PageDocumentoPropostaResponse ListarDocumentosProposta (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idProposta = null, long? idDocumentosCredito = null, long? idStatusDocumentosCredito = null, long? idCondicoesDocumentosCredito = null, long? idTipoDocumentoCredito = null, long? idPessoaFisica = null, long? idLogAtendimento = null, string responsavel = null, int? flagDocumentoDigitalizado = null, string documentoDigitalizado = null, long? seqAnaliseCondicao = null, string observacao = null, string dataStatus = null)
        {
             ApiResponse<PageDocumentoPropostaResponse> localVarResponse = ListarDocumentosPropostaWithHttpInfo(sort, page, limit, id, idProposta, idDocumentosCredito, idStatusDocumentosCredito, idCondicoesDocumentosCredito, idTipoDocumentoCredito, idPessoaFisica, idLogAtendimento, responsavel, flagDocumentoDigitalizado, documentoDigitalizado, seqAnaliseCondicao, observacao, dataStatus);
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
        public ApiResponse< PageDocumentoPropostaResponse > ListarDocumentosPropostaWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idProposta = null, long? idDocumentosCredito = null, long? idStatusDocumentosCredito = null, long? idCondicoesDocumentosCredito = null, long? idTipoDocumentoCredito = null, long? idPessoaFisica = null, long? idLogAtendimento = null, string responsavel = null, int? flagDocumentoDigitalizado = null, string documentoDigitalizado = null, long? seqAnaliseCondicao = null, string observacao = null, string dataStatus = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarDocumentosProposta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarDocumentosProposta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<PageDocumentoPropostaResponse> ListarDocumentosPropostaAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idProposta = null, long? idDocumentosCredito = null, long? idStatusDocumentosCredito = null, long? idCondicoesDocumentosCredito = null, long? idTipoDocumentoCredito = null, long? idPessoaFisica = null, long? idLogAtendimento = null, string responsavel = null, int? flagDocumentoDigitalizado = null, string documentoDigitalizado = null, long? seqAnaliseCondicao = null, string observacao = null, string dataStatus = null)
        {
             ApiResponse<PageDocumentoPropostaResponse> localVarResponse = await ListarDocumentosPropostaAsyncWithHttpInfo(sort, page, limit, id, idProposta, idDocumentosCredito, idStatusDocumentosCredito, idCondicoesDocumentosCredito, idTipoDocumentoCredito, idPessoaFisica, idLogAtendimento, responsavel, flagDocumentoDigitalizado, documentoDigitalizado, seqAnaliseCondicao, observacao, dataStatus);
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
        public async System.Threading.Tasks.Task<ApiResponse<PageDocumentoPropostaResponse>> ListarDocumentosPropostaAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idProposta = null, long? idDocumentosCredito = null, long? idStatusDocumentosCredito = null, long? idCondicoesDocumentosCredito = null, long? idTipoDocumentoCredito = null, long? idPessoaFisica = null, long? idLogAtendimento = null, string responsavel = null, int? flagDocumentoDigitalizado = null, string documentoDigitalizado = null, long? seqAnaliseCondicao = null, string observacao = null, string dataStatus = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarDocumentosProposta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarDocumentosProposta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageDocumentoPropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDocumentoPropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDocumentoPropostaResponse)));
            
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
        public PageStatusPropostaResponse ListarStatusProposta (List<string> sort = null, int? page = null, int? limit = null, int? status = null, bool? flagPermiteAlteracao = null)
        {
             ApiResponse<PageStatusPropostaResponse> localVarResponse = ListarStatusPropostaWithHttpInfo(sort, page, limit, status, flagPermiteAlteracao);
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
        public ApiResponse< PageStatusPropostaResponse > ListarStatusPropostaWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, int? status = null, bool? flagPermiteAlteracao = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusProposta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusProposta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<PageStatusPropostaResponse> ListarStatusPropostaAsync (List<string> sort = null, int? page = null, int? limit = null, int? status = null, bool? flagPermiteAlteracao = null)
        {
             ApiResponse<PageStatusPropostaResponse> localVarResponse = await ListarStatusPropostaAsyncWithHttpInfo(sort, page, limit, status, flagPermiteAlteracao);
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
        public async System.Threading.Tasks.Task<ApiResponse<PageStatusPropostaResponse>> ListarStatusPropostaAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, int? status = null, bool? flagPermiteAlteracao = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusProposta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusProposta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageStatusPropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusPropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusPropostaResponse)));
            
        }
        
    }
    
}
