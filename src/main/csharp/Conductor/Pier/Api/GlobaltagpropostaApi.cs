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
    public interface IGlobaltagpropostaApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{proposta_resource_alterar_status}}}
        /// </summary>
        /// <remarks>
        /// {{{proposta_resource_alterar_status_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{proposta_resource_alterar_status_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>PropostaResponse</returns>
        PropostaResponse AlterarUsingPOST (long? id, StatusPropostaUpdate update);
  
        /// <summary>
        /// {{{proposta_resource_alterar_status}}}
        /// </summary>
        /// <remarks>
        /// {{{proposta_resource_alterar_status_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{proposta_resource_alterar_status_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of PropostaResponse</returns>
        ApiResponse<PropostaResponse> AlterarUsingPOSTWithHttpInfo (long? id, StatusPropostaUpdate update);
        
        /// <summary>
        /// {{{proposta_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{proposta_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{proposta_resource_consultar_param_id}}}</param>
        /// <returns>PropostaResponse</returns>
        PropostaResponse ConsultarUsingGET30 (long? id);
  
        /// <summary>
        /// {{{proposta_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{proposta_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{proposta_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of PropostaResponse</returns>
        ApiResponse<PropostaResponse> ConsultarUsingGET30WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{documento_proposta_resource_enviar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_proposta_resource_enviar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>DocumentoPropostaResponse</returns>
        DocumentoPropostaResponse EnviarDocumentoPropostaUsingPOST (DocumentoPropostaPersist persist);
  
        /// <summary>
        /// {{{documento_proposta_resource_enviar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_proposta_resource_enviar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of DocumentoPropostaResponse</returns>
        ApiResponse<DocumentoPropostaResponse> EnviarDocumentoPropostaUsingPOSTWithHttpInfo (DocumentoPropostaPersist persist);
        
        /// <summary>
        /// {{{documento_proposta_resource_listar_documentos_credito}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_proposta_resource_listar_documentos_credito_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{documento_credito_request_id_value}}} (optional)</param>
        /// <param name="descricao">{{{documento_credito_request_descricao_value}}} (optional)</param>
        /// <param name="tela">{{{documento_credito_request_flag_tela_value}}} (optional)</param>
        /// <param name="doc">{{{documento_credito_request_flag_doc_value}}} (optional)</param>
        /// <param name="idAtividadeDeCredito">{{{documento_credito_request_id_atividade_credito_value}}} (optional)</param>
        /// <param name="obrigatorio">{{{documento_credito_request_flag_obrigatorio_value}}} (optional)</param>
        /// <returns>PageDocumentoCreditoResponse</returns>
        PageDocumentoCreditoResponse ListarDocumentosCreditoUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, int? tela = null, int? doc = null, long? idAtividadeDeCredito = null, int? obrigatorio = null);
  
        /// <summary>
        /// {{{documento_proposta_resource_listar_documentos_credito}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_proposta_resource_listar_documentos_credito_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{documento_credito_request_id_value}}} (optional)</param>
        /// <param name="descricao">{{{documento_credito_request_descricao_value}}} (optional)</param>
        /// <param name="tela">{{{documento_credito_request_flag_tela_value}}} (optional)</param>
        /// <param name="doc">{{{documento_credito_request_flag_doc_value}}} (optional)</param>
        /// <param name="idAtividadeDeCredito">{{{documento_credito_request_id_atividade_credito_value}}} (optional)</param>
        /// <param name="obrigatorio">{{{documento_credito_request_flag_obrigatorio_value}}} (optional)</param>
        /// <returns>ApiResponse of PageDocumentoCreditoResponse</returns>
        ApiResponse<PageDocumentoCreditoResponse> ListarDocumentosCreditoUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, int? tela = null, int? doc = null, long? idAtividadeDeCredito = null, int? obrigatorio = null);
        
        /// <summary>
        /// {{{documento_proposta_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_proposta_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{documento_proposta_request_id_value}}} (optional)</param>
        /// <param name="idProposta">{{{documento_proposta_request_id_proposta_value}}} (optional)</param>
        /// <param name="idDocumentosCredito">{{{documento_proposta_request_id_tipo_documento_value}}} (optional)</param>
        /// <param name="idStatusDocumentosCredito">{{{documento_proposta_request_id_status_documento_credito_value}}} (optional)</param>
        /// <param name="idCondicoesDocumentosCredito">{{{documento_proposta_request_id_condicao_documento_credito_value}}} (optional)</param>
        /// <param name="idTipoDocumentoCredito">{{{documento_proposta_request_id_tipo_documento_credito_value}}} (optional)</param>
        /// <param name="idPessoaFisica">{{{documento_proposta_request_id_pessoa_fisica_value}}} (optional)</param>
        /// <param name="idLogAtendimento">{{{documento_proposta_request_id_log_atendimento_value}}} (optional)</param>
        /// <param name="responsavel">{{{documento_proposta_request_responsavel_value}}} (optional)</param>
        /// <param name="flagDocumentoDigitalizado">{{{documento_proposta_request_flag_documento_digitalizado_value}}} (optional)</param>
        /// <param name="documentoDigitalizado">{{{documento_proposta_request_documento_digitalizado_value}}} (optional)</param>
        /// <param name="seqAnaliseCondicao">{{{documento_proposta_request_seq_analise_condicao_value}}} (optional)</param>
        /// <param name="observacao">{{{documento_proposta_request_observacao_value}}} (optional)</param>
        /// <param name="dataStatus">{{{documento_proposta_request_data_status_value}}} (optional)</param>
        /// <returns>PageDocumentoPropostaResponse</returns>
        PageDocumentoPropostaResponse ListarDocumentosPropostaUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idProposta = null, long? idDocumentosCredito = null, long? idStatusDocumentosCredito = null, long? idCondicoesDocumentosCredito = null, long? idTipoDocumentoCredito = null, long? idPessoaFisica = null, long? idLogAtendimento = null, string responsavel = null, int? flagDocumentoDigitalizado = null, string documentoDigitalizado = null, long? seqAnaliseCondicao = null, string observacao = null, string dataStatus = null);
  
        /// <summary>
        /// {{{documento_proposta_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_proposta_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{documento_proposta_request_id_value}}} (optional)</param>
        /// <param name="idProposta">{{{documento_proposta_request_id_proposta_value}}} (optional)</param>
        /// <param name="idDocumentosCredito">{{{documento_proposta_request_id_tipo_documento_value}}} (optional)</param>
        /// <param name="idStatusDocumentosCredito">{{{documento_proposta_request_id_status_documento_credito_value}}} (optional)</param>
        /// <param name="idCondicoesDocumentosCredito">{{{documento_proposta_request_id_condicao_documento_credito_value}}} (optional)</param>
        /// <param name="idTipoDocumentoCredito">{{{documento_proposta_request_id_tipo_documento_credito_value}}} (optional)</param>
        /// <param name="idPessoaFisica">{{{documento_proposta_request_id_pessoa_fisica_value}}} (optional)</param>
        /// <param name="idLogAtendimento">{{{documento_proposta_request_id_log_atendimento_value}}} (optional)</param>
        /// <param name="responsavel">{{{documento_proposta_request_responsavel_value}}} (optional)</param>
        /// <param name="flagDocumentoDigitalizado">{{{documento_proposta_request_flag_documento_digitalizado_value}}} (optional)</param>
        /// <param name="documentoDigitalizado">{{{documento_proposta_request_documento_digitalizado_value}}} (optional)</param>
        /// <param name="seqAnaliseCondicao">{{{documento_proposta_request_seq_analise_condicao_value}}} (optional)</param>
        /// <param name="observacao">{{{documento_proposta_request_observacao_value}}} (optional)</param>
        /// <param name="dataStatus">{{{documento_proposta_request_data_status_value}}} (optional)</param>
        /// <returns>ApiResponse of PageDocumentoPropostaResponse</returns>
        ApiResponse<PageDocumentoPropostaResponse> ListarDocumentosPropostaUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idProposta = null, long? idDocumentosCredito = null, long? idStatusDocumentosCredito = null, long? idCondicoesDocumentosCredito = null, long? idTipoDocumentoCredito = null, long? idPessoaFisica = null, long? idLogAtendimento = null, string responsavel = null, int? flagDocumentoDigitalizado = null, string documentoDigitalizado = null, long? seqAnaliseCondicao = null, string observacao = null, string dataStatus = null);
        
        /// <summary>
        /// {{{proposta_resource_listar_status}}}
        /// </summary>
        /// <remarks>
        /// {{{proposta_resource_listar_status_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="status">{{{status_proposta_request_status_value}}} (optional)</param>
        /// <param name="flagPermiteAlteracao">{{{status_proposta_request_flag_permite_alteracao_value}}} (optional)</param>
        /// <returns>PageStatusPropostaResponse</returns>
        PageStatusPropostaResponse ListarStatusPropostaUsingGET (List<string> sort = null, int? page = null, int? limit = null, int? status = null, bool? flagPermiteAlteracao = null);
  
        /// <summary>
        /// {{{proposta_resource_listar_status}}}
        /// </summary>
        /// <remarks>
        /// {{{proposta_resource_listar_status_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="status">{{{status_proposta_request_status_value}}} (optional)</param>
        /// <param name="flagPermiteAlteracao">{{{status_proposta_request_flag_permite_alteracao_value}}} (optional)</param>
        /// <returns>ApiResponse of PageStatusPropostaResponse</returns>
        ApiResponse<PageStatusPropostaResponse> ListarStatusPropostaUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, int? status = null, bool? flagPermiteAlteracao = null);
        
        /// <summary>
        /// {{{proposta_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{proposta_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="status">{{{proposta_request_status_value}}} (optional)</param>
        /// <returns>PagePropostaResponse</returns>
        PagePropostaResponse ListarUsingGET38 (List<string> sort = null, int? page = null, int? limit = null, int? status = null);
  
        /// <summary>
        /// {{{proposta_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{proposta_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="status">{{{proposta_request_status_value}}} (optional)</param>
        /// <returns>ApiResponse of PagePropostaResponse</returns>
        ApiResponse<PagePropostaResponse> ListarUsingGET38WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, int? status = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{proposta_resource_alterar_status}}}
        /// </summary>
        /// <remarks>
        /// {{{proposta_resource_alterar_status_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{proposta_resource_alterar_status_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of PropostaResponse</returns>
        System.Threading.Tasks.Task<PropostaResponse> AlterarUsingPOSTAsync (long? id, StatusPropostaUpdate update);

        /// <summary>
        /// {{{proposta_resource_alterar_status}}}
        /// </summary>
        /// <remarks>
        /// {{{proposta_resource_alterar_status_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{proposta_resource_alterar_status_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (PropostaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PropostaResponse>> AlterarUsingPOSTAsyncWithHttpInfo (long? id, StatusPropostaUpdate update);
        
        /// <summary>
        /// {{{proposta_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{proposta_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{proposta_resource_consultar_param_id}}}</param>
        /// <returns>Task of PropostaResponse</returns>
        System.Threading.Tasks.Task<PropostaResponse> ConsultarUsingGET30Async (long? id);

        /// <summary>
        /// {{{proposta_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{proposta_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{proposta_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (PropostaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PropostaResponse>> ConsultarUsingGET30AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{documento_proposta_resource_enviar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_proposta_resource_enviar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of DocumentoPropostaResponse</returns>
        System.Threading.Tasks.Task<DocumentoPropostaResponse> EnviarDocumentoPropostaUsingPOSTAsync (DocumentoPropostaPersist persist);

        /// <summary>
        /// {{{documento_proposta_resource_enviar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_proposta_resource_enviar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DocumentoPropostaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentoPropostaResponse>> EnviarDocumentoPropostaUsingPOSTAsyncWithHttpInfo (DocumentoPropostaPersist persist);
        
        /// <summary>
        /// {{{documento_proposta_resource_listar_documentos_credito}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_proposta_resource_listar_documentos_credito_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{documento_credito_request_id_value}}} (optional)</param>
        /// <param name="descricao">{{{documento_credito_request_descricao_value}}} (optional)</param>
        /// <param name="tela">{{{documento_credito_request_flag_tela_value}}} (optional)</param>
        /// <param name="doc">{{{documento_credito_request_flag_doc_value}}} (optional)</param>
        /// <param name="idAtividadeDeCredito">{{{documento_credito_request_id_atividade_credito_value}}} (optional)</param>
        /// <param name="obrigatorio">{{{documento_credito_request_flag_obrigatorio_value}}} (optional)</param>
        /// <returns>Task of PageDocumentoCreditoResponse</returns>
        System.Threading.Tasks.Task<PageDocumentoCreditoResponse> ListarDocumentosCreditoUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, int? tela = null, int? doc = null, long? idAtividadeDeCredito = null, int? obrigatorio = null);

        /// <summary>
        /// {{{documento_proposta_resource_listar_documentos_credito}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_proposta_resource_listar_documentos_credito_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{documento_credito_request_id_value}}} (optional)</param>
        /// <param name="descricao">{{{documento_credito_request_descricao_value}}} (optional)</param>
        /// <param name="tela">{{{documento_credito_request_flag_tela_value}}} (optional)</param>
        /// <param name="doc">{{{documento_credito_request_flag_doc_value}}} (optional)</param>
        /// <param name="idAtividadeDeCredito">{{{documento_credito_request_id_atividade_credito_value}}} (optional)</param>
        /// <param name="obrigatorio">{{{documento_credito_request_flag_obrigatorio_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageDocumentoCreditoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageDocumentoCreditoResponse>> ListarDocumentosCreditoUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, int? tela = null, int? doc = null, long? idAtividadeDeCredito = null, int? obrigatorio = null);
        
        /// <summary>
        /// {{{documento_proposta_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_proposta_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{documento_proposta_request_id_value}}} (optional)</param>
        /// <param name="idProposta">{{{documento_proposta_request_id_proposta_value}}} (optional)</param>
        /// <param name="idDocumentosCredito">{{{documento_proposta_request_id_tipo_documento_value}}} (optional)</param>
        /// <param name="idStatusDocumentosCredito">{{{documento_proposta_request_id_status_documento_credito_value}}} (optional)</param>
        /// <param name="idCondicoesDocumentosCredito">{{{documento_proposta_request_id_condicao_documento_credito_value}}} (optional)</param>
        /// <param name="idTipoDocumentoCredito">{{{documento_proposta_request_id_tipo_documento_credito_value}}} (optional)</param>
        /// <param name="idPessoaFisica">{{{documento_proposta_request_id_pessoa_fisica_value}}} (optional)</param>
        /// <param name="idLogAtendimento">{{{documento_proposta_request_id_log_atendimento_value}}} (optional)</param>
        /// <param name="responsavel">{{{documento_proposta_request_responsavel_value}}} (optional)</param>
        /// <param name="flagDocumentoDigitalizado">{{{documento_proposta_request_flag_documento_digitalizado_value}}} (optional)</param>
        /// <param name="documentoDigitalizado">{{{documento_proposta_request_documento_digitalizado_value}}} (optional)</param>
        /// <param name="seqAnaliseCondicao">{{{documento_proposta_request_seq_analise_condicao_value}}} (optional)</param>
        /// <param name="observacao">{{{documento_proposta_request_observacao_value}}} (optional)</param>
        /// <param name="dataStatus">{{{documento_proposta_request_data_status_value}}} (optional)</param>
        /// <returns>Task of PageDocumentoPropostaResponse</returns>
        System.Threading.Tasks.Task<PageDocumentoPropostaResponse> ListarDocumentosPropostaUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idProposta = null, long? idDocumentosCredito = null, long? idStatusDocumentosCredito = null, long? idCondicoesDocumentosCredito = null, long? idTipoDocumentoCredito = null, long? idPessoaFisica = null, long? idLogAtendimento = null, string responsavel = null, int? flagDocumentoDigitalizado = null, string documentoDigitalizado = null, long? seqAnaliseCondicao = null, string observacao = null, string dataStatus = null);

        /// <summary>
        /// {{{documento_proposta_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_proposta_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{documento_proposta_request_id_value}}} (optional)</param>
        /// <param name="idProposta">{{{documento_proposta_request_id_proposta_value}}} (optional)</param>
        /// <param name="idDocumentosCredito">{{{documento_proposta_request_id_tipo_documento_value}}} (optional)</param>
        /// <param name="idStatusDocumentosCredito">{{{documento_proposta_request_id_status_documento_credito_value}}} (optional)</param>
        /// <param name="idCondicoesDocumentosCredito">{{{documento_proposta_request_id_condicao_documento_credito_value}}} (optional)</param>
        /// <param name="idTipoDocumentoCredito">{{{documento_proposta_request_id_tipo_documento_credito_value}}} (optional)</param>
        /// <param name="idPessoaFisica">{{{documento_proposta_request_id_pessoa_fisica_value}}} (optional)</param>
        /// <param name="idLogAtendimento">{{{documento_proposta_request_id_log_atendimento_value}}} (optional)</param>
        /// <param name="responsavel">{{{documento_proposta_request_responsavel_value}}} (optional)</param>
        /// <param name="flagDocumentoDigitalizado">{{{documento_proposta_request_flag_documento_digitalizado_value}}} (optional)</param>
        /// <param name="documentoDigitalizado">{{{documento_proposta_request_documento_digitalizado_value}}} (optional)</param>
        /// <param name="seqAnaliseCondicao">{{{documento_proposta_request_seq_analise_condicao_value}}} (optional)</param>
        /// <param name="observacao">{{{documento_proposta_request_observacao_value}}} (optional)</param>
        /// <param name="dataStatus">{{{documento_proposta_request_data_status_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageDocumentoPropostaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageDocumentoPropostaResponse>> ListarDocumentosPropostaUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idProposta = null, long? idDocumentosCredito = null, long? idStatusDocumentosCredito = null, long? idCondicoesDocumentosCredito = null, long? idTipoDocumentoCredito = null, long? idPessoaFisica = null, long? idLogAtendimento = null, string responsavel = null, int? flagDocumentoDigitalizado = null, string documentoDigitalizado = null, long? seqAnaliseCondicao = null, string observacao = null, string dataStatus = null);
        
        /// <summary>
        /// {{{proposta_resource_listar_status}}}
        /// </summary>
        /// <remarks>
        /// {{{proposta_resource_listar_status_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="status">{{{status_proposta_request_status_value}}} (optional)</param>
        /// <param name="flagPermiteAlteracao">{{{status_proposta_request_flag_permite_alteracao_value}}} (optional)</param>
        /// <returns>Task of PageStatusPropostaResponse</returns>
        System.Threading.Tasks.Task<PageStatusPropostaResponse> ListarStatusPropostaUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, int? status = null, bool? flagPermiteAlteracao = null);

        /// <summary>
        /// {{{proposta_resource_listar_status}}}
        /// </summary>
        /// <remarks>
        /// {{{proposta_resource_listar_status_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="status">{{{status_proposta_request_status_value}}} (optional)</param>
        /// <param name="flagPermiteAlteracao">{{{status_proposta_request_flag_permite_alteracao_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusPropostaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageStatusPropostaResponse>> ListarStatusPropostaUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, int? status = null, bool? flagPermiteAlteracao = null);
        
        /// <summary>
        /// {{{proposta_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{proposta_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="status">{{{proposta_request_status_value}}} (optional)</param>
        /// <returns>Task of PagePropostaResponse</returns>
        System.Threading.Tasks.Task<PagePropostaResponse> ListarUsingGET38Async (List<string> sort = null, int? page = null, int? limit = null, int? status = null);

        /// <summary>
        /// {{{proposta_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{proposta_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="status">{{{proposta_request_status_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PagePropostaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePropostaResponse>> ListarUsingGET38AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, int? status = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltagpropostaApi : IGlobaltagpropostaApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagpropostaApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltagpropostaApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagpropostaApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltagpropostaApi(Configuration configuration = null)
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
        /// {{{proposta_resource_alterar_status}}} {{{proposta_resource_alterar_status_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{proposta_resource_alterar_status_param_id}}}</param> 
        /// <param name="update">update</param> 
        /// <returns>PropostaResponse</returns>
        public PropostaResponse AlterarUsingPOST (long? id, StatusPropostaUpdate update)
        {
             ApiResponse<PropostaResponse> localVarResponse = AlterarUsingPOSTWithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{proposta_resource_alterar_status}}} {{{proposta_resource_alterar_status_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{proposta_resource_alterar_status_param_id}}}</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of PropostaResponse</returns>
        public ApiResponse< PropostaResponse > AlterarUsingPOSTWithHttpInfo (long? id, StatusPropostaUpdate update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagpropostaApi->AlterarUsingPOST");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling GlobaltagpropostaApi->AlterarUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropostaResponse)));
            
        }

        
        /// <summary>
        /// {{{proposta_resource_alterar_status}}} {{{proposta_resource_alterar_status_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{proposta_resource_alterar_status_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of PropostaResponse</returns>
        public async System.Threading.Tasks.Task<PropostaResponse> AlterarUsingPOSTAsync (long? id, StatusPropostaUpdate update)
        {
             ApiResponse<PropostaResponse> localVarResponse = await AlterarUsingPOSTAsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{proposta_resource_alterar_status}}} {{{proposta_resource_alterar_status_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{proposta_resource_alterar_status_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (PropostaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PropostaResponse>> AlterarUsingPOSTAsyncWithHttpInfo (long? id, StatusPropostaUpdate update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPOST");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AlterarUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropostaResponse)));
            
        }
        
        /// <summary>
        /// {{{proposta_resource_consultar}}} {{{proposta_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{proposta_resource_consultar_param_id}}}</param> 
        /// <returns>PropostaResponse</returns>
        public PropostaResponse ConsultarUsingGET30 (long? id)
        {
             ApiResponse<PropostaResponse> localVarResponse = ConsultarUsingGET30WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{proposta_resource_consultar}}} {{{proposta_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{proposta_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of PropostaResponse</returns>
        public ApiResponse< PropostaResponse > ConsultarUsingGET30WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagpropostaApi->ConsultarUsingGET30");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET30: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET30: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropostaResponse)));
            
        }

        
        /// <summary>
        /// {{{proposta_resource_consultar}}} {{{proposta_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{proposta_resource_consultar_param_id}}}</param>
        /// <returns>Task of PropostaResponse</returns>
        public async System.Threading.Tasks.Task<PropostaResponse> ConsultarUsingGET30Async (long? id)
        {
             ApiResponse<PropostaResponse> localVarResponse = await ConsultarUsingGET30AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{proposta_resource_consultar}}} {{{proposta_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{proposta_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (PropostaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PropostaResponse>> ConsultarUsingGET30AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET30");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET30: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET30: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropostaResponse)));
            
        }
        
        /// <summary>
        /// {{{documento_proposta_resource_enviar}}} {{{documento_proposta_resource_enviar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>DocumentoPropostaResponse</returns>
        public DocumentoPropostaResponse EnviarDocumentoPropostaUsingPOST (DocumentoPropostaPersist persist)
        {
             ApiResponse<DocumentoPropostaResponse> localVarResponse = EnviarDocumentoPropostaUsingPOSTWithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{documento_proposta_resource_enviar}}} {{{documento_proposta_resource_enviar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of DocumentoPropostaResponse</returns>
        public ApiResponse< DocumentoPropostaResponse > EnviarDocumentoPropostaUsingPOSTWithHttpInfo (DocumentoPropostaPersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling GlobaltagpropostaApi->EnviarDocumentoPropostaUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling EnviarDocumentoPropostaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EnviarDocumentoPropostaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DocumentoPropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoPropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoPropostaResponse)));
            
        }

        
        /// <summary>
        /// {{{documento_proposta_resource_enviar}}} {{{documento_proposta_resource_enviar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of DocumentoPropostaResponse</returns>
        public async System.Threading.Tasks.Task<DocumentoPropostaResponse> EnviarDocumentoPropostaUsingPOSTAsync (DocumentoPropostaPersist persist)
        {
             ApiResponse<DocumentoPropostaResponse> localVarResponse = await EnviarDocumentoPropostaUsingPOSTAsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{documento_proposta_resource_enviar}}} {{{documento_proposta_resource_enviar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DocumentoPropostaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentoPropostaResponse>> EnviarDocumentoPropostaUsingPOSTAsyncWithHttpInfo (DocumentoPropostaPersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling EnviarDocumentoPropostaUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling EnviarDocumentoPropostaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EnviarDocumentoPropostaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentoPropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoPropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoPropostaResponse)));
            
        }
        
        /// <summary>
        /// {{{documento_proposta_resource_listar_documentos_credito}}} {{{documento_proposta_resource_listar_documentos_credito_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{documento_credito_request_id_value}}} (optional)</param> 
        /// <param name="descricao">{{{documento_credito_request_descricao_value}}} (optional)</param> 
        /// <param name="tela">{{{documento_credito_request_flag_tela_value}}} (optional)</param> 
        /// <param name="doc">{{{documento_credito_request_flag_doc_value}}} (optional)</param> 
        /// <param name="idAtividadeDeCredito">{{{documento_credito_request_id_atividade_credito_value}}} (optional)</param> 
        /// <param name="obrigatorio">{{{documento_credito_request_flag_obrigatorio_value}}} (optional)</param> 
        /// <returns>PageDocumentoCreditoResponse</returns>
        public PageDocumentoCreditoResponse ListarDocumentosCreditoUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, int? tela = null, int? doc = null, long? idAtividadeDeCredito = null, int? obrigatorio = null)
        {
             ApiResponse<PageDocumentoCreditoResponse> localVarResponse = ListarDocumentosCreditoUsingGETWithHttpInfo(sort, page, limit, id, descricao, tela, doc, idAtividadeDeCredito, obrigatorio);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{documento_proposta_resource_listar_documentos_credito}}} {{{documento_proposta_resource_listar_documentos_credito_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{documento_credito_request_id_value}}} (optional)</param> 
        /// <param name="descricao">{{{documento_credito_request_descricao_value}}} (optional)</param> 
        /// <param name="tela">{{{documento_credito_request_flag_tela_value}}} (optional)</param> 
        /// <param name="doc">{{{documento_credito_request_flag_doc_value}}} (optional)</param> 
        /// <param name="idAtividadeDeCredito">{{{documento_credito_request_id_atividade_credito_value}}} (optional)</param> 
        /// <param name="obrigatorio">{{{documento_credito_request_flag_obrigatorio_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageDocumentoCreditoResponse</returns>
        public ApiResponse< PageDocumentoCreditoResponse > ListarDocumentosCreditoUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, int? tela = null, int? doc = null, long? idAtividadeDeCredito = null, int? obrigatorio = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarDocumentosCreditoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarDocumentosCreditoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageDocumentoCreditoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDocumentoCreditoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDocumentoCreditoResponse)));
            
        }

        
        /// <summary>
        /// {{{documento_proposta_resource_listar_documentos_credito}}} {{{documento_proposta_resource_listar_documentos_credito_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{documento_credito_request_id_value}}} (optional)</param>
        /// <param name="descricao">{{{documento_credito_request_descricao_value}}} (optional)</param>
        /// <param name="tela">{{{documento_credito_request_flag_tela_value}}} (optional)</param>
        /// <param name="doc">{{{documento_credito_request_flag_doc_value}}} (optional)</param>
        /// <param name="idAtividadeDeCredito">{{{documento_credito_request_id_atividade_credito_value}}} (optional)</param>
        /// <param name="obrigatorio">{{{documento_credito_request_flag_obrigatorio_value}}} (optional)</param>
        /// <returns>Task of PageDocumentoCreditoResponse</returns>
        public async System.Threading.Tasks.Task<PageDocumentoCreditoResponse> ListarDocumentosCreditoUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, int? tela = null, int? doc = null, long? idAtividadeDeCredito = null, int? obrigatorio = null)
        {
             ApiResponse<PageDocumentoCreditoResponse> localVarResponse = await ListarDocumentosCreditoUsingGETAsyncWithHttpInfo(sort, page, limit, id, descricao, tela, doc, idAtividadeDeCredito, obrigatorio);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{documento_proposta_resource_listar_documentos_credito}}} {{{documento_proposta_resource_listar_documentos_credito_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{documento_credito_request_id_value}}} (optional)</param>
        /// <param name="descricao">{{{documento_credito_request_descricao_value}}} (optional)</param>
        /// <param name="tela">{{{documento_credito_request_flag_tela_value}}} (optional)</param>
        /// <param name="doc">{{{documento_credito_request_flag_doc_value}}} (optional)</param>
        /// <param name="idAtividadeDeCredito">{{{documento_credito_request_id_atividade_credito_value}}} (optional)</param>
        /// <param name="obrigatorio">{{{documento_credito_request_flag_obrigatorio_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageDocumentoCreditoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageDocumentoCreditoResponse>> ListarDocumentosCreditoUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, int? tela = null, int? doc = null, long? idAtividadeDeCredito = null, int? obrigatorio = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarDocumentosCreditoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarDocumentosCreditoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageDocumentoCreditoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDocumentoCreditoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDocumentoCreditoResponse)));
            
        }
        
        /// <summary>
        /// {{{documento_proposta_resource_listar}}} {{{documento_proposta_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{documento_proposta_request_id_value}}} (optional)</param> 
        /// <param name="idProposta">{{{documento_proposta_request_id_proposta_value}}} (optional)</param> 
        /// <param name="idDocumentosCredito">{{{documento_proposta_request_id_tipo_documento_value}}} (optional)</param> 
        /// <param name="idStatusDocumentosCredito">{{{documento_proposta_request_id_status_documento_credito_value}}} (optional)</param> 
        /// <param name="idCondicoesDocumentosCredito">{{{documento_proposta_request_id_condicao_documento_credito_value}}} (optional)</param> 
        /// <param name="idTipoDocumentoCredito">{{{documento_proposta_request_id_tipo_documento_credito_value}}} (optional)</param> 
        /// <param name="idPessoaFisica">{{{documento_proposta_request_id_pessoa_fisica_value}}} (optional)</param> 
        /// <param name="idLogAtendimento">{{{documento_proposta_request_id_log_atendimento_value}}} (optional)</param> 
        /// <param name="responsavel">{{{documento_proposta_request_responsavel_value}}} (optional)</param> 
        /// <param name="flagDocumentoDigitalizado">{{{documento_proposta_request_flag_documento_digitalizado_value}}} (optional)</param> 
        /// <param name="documentoDigitalizado">{{{documento_proposta_request_documento_digitalizado_value}}} (optional)</param> 
        /// <param name="seqAnaliseCondicao">{{{documento_proposta_request_seq_analise_condicao_value}}} (optional)</param> 
        /// <param name="observacao">{{{documento_proposta_request_observacao_value}}} (optional)</param> 
        /// <param name="dataStatus">{{{documento_proposta_request_data_status_value}}} (optional)</param> 
        /// <returns>PageDocumentoPropostaResponse</returns>
        public PageDocumentoPropostaResponse ListarDocumentosPropostaUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idProposta = null, long? idDocumentosCredito = null, long? idStatusDocumentosCredito = null, long? idCondicoesDocumentosCredito = null, long? idTipoDocumentoCredito = null, long? idPessoaFisica = null, long? idLogAtendimento = null, string responsavel = null, int? flagDocumentoDigitalizado = null, string documentoDigitalizado = null, long? seqAnaliseCondicao = null, string observacao = null, string dataStatus = null)
        {
             ApiResponse<PageDocumentoPropostaResponse> localVarResponse = ListarDocumentosPropostaUsingGETWithHttpInfo(sort, page, limit, id, idProposta, idDocumentosCredito, idStatusDocumentosCredito, idCondicoesDocumentosCredito, idTipoDocumentoCredito, idPessoaFisica, idLogAtendimento, responsavel, flagDocumentoDigitalizado, documentoDigitalizado, seqAnaliseCondicao, observacao, dataStatus);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{documento_proposta_resource_listar}}} {{{documento_proposta_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{documento_proposta_request_id_value}}} (optional)</param> 
        /// <param name="idProposta">{{{documento_proposta_request_id_proposta_value}}} (optional)</param> 
        /// <param name="idDocumentosCredito">{{{documento_proposta_request_id_tipo_documento_value}}} (optional)</param> 
        /// <param name="idStatusDocumentosCredito">{{{documento_proposta_request_id_status_documento_credito_value}}} (optional)</param> 
        /// <param name="idCondicoesDocumentosCredito">{{{documento_proposta_request_id_condicao_documento_credito_value}}} (optional)</param> 
        /// <param name="idTipoDocumentoCredito">{{{documento_proposta_request_id_tipo_documento_credito_value}}} (optional)</param> 
        /// <param name="idPessoaFisica">{{{documento_proposta_request_id_pessoa_fisica_value}}} (optional)</param> 
        /// <param name="idLogAtendimento">{{{documento_proposta_request_id_log_atendimento_value}}} (optional)</param> 
        /// <param name="responsavel">{{{documento_proposta_request_responsavel_value}}} (optional)</param> 
        /// <param name="flagDocumentoDigitalizado">{{{documento_proposta_request_flag_documento_digitalizado_value}}} (optional)</param> 
        /// <param name="documentoDigitalizado">{{{documento_proposta_request_documento_digitalizado_value}}} (optional)</param> 
        /// <param name="seqAnaliseCondicao">{{{documento_proposta_request_seq_analise_condicao_value}}} (optional)</param> 
        /// <param name="observacao">{{{documento_proposta_request_observacao_value}}} (optional)</param> 
        /// <param name="dataStatus">{{{documento_proposta_request_data_status_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageDocumentoPropostaResponse</returns>
        public ApiResponse< PageDocumentoPropostaResponse > ListarDocumentosPropostaUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idProposta = null, long? idDocumentosCredito = null, long? idStatusDocumentosCredito = null, long? idCondicoesDocumentosCredito = null, long? idTipoDocumentoCredito = null, long? idPessoaFisica = null, long? idLogAtendimento = null, string responsavel = null, int? flagDocumentoDigitalizado = null, string documentoDigitalizado = null, long? seqAnaliseCondicao = null, string observacao = null, string dataStatus = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarDocumentosPropostaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarDocumentosPropostaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageDocumentoPropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDocumentoPropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDocumentoPropostaResponse)));
            
        }

        
        /// <summary>
        /// {{{documento_proposta_resource_listar}}} {{{documento_proposta_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{documento_proposta_request_id_value}}} (optional)</param>
        /// <param name="idProposta">{{{documento_proposta_request_id_proposta_value}}} (optional)</param>
        /// <param name="idDocumentosCredito">{{{documento_proposta_request_id_tipo_documento_value}}} (optional)</param>
        /// <param name="idStatusDocumentosCredito">{{{documento_proposta_request_id_status_documento_credito_value}}} (optional)</param>
        /// <param name="idCondicoesDocumentosCredito">{{{documento_proposta_request_id_condicao_documento_credito_value}}} (optional)</param>
        /// <param name="idTipoDocumentoCredito">{{{documento_proposta_request_id_tipo_documento_credito_value}}} (optional)</param>
        /// <param name="idPessoaFisica">{{{documento_proposta_request_id_pessoa_fisica_value}}} (optional)</param>
        /// <param name="idLogAtendimento">{{{documento_proposta_request_id_log_atendimento_value}}} (optional)</param>
        /// <param name="responsavel">{{{documento_proposta_request_responsavel_value}}} (optional)</param>
        /// <param name="flagDocumentoDigitalizado">{{{documento_proposta_request_flag_documento_digitalizado_value}}} (optional)</param>
        /// <param name="documentoDigitalizado">{{{documento_proposta_request_documento_digitalizado_value}}} (optional)</param>
        /// <param name="seqAnaliseCondicao">{{{documento_proposta_request_seq_analise_condicao_value}}} (optional)</param>
        /// <param name="observacao">{{{documento_proposta_request_observacao_value}}} (optional)</param>
        /// <param name="dataStatus">{{{documento_proposta_request_data_status_value}}} (optional)</param>
        /// <returns>Task of PageDocumentoPropostaResponse</returns>
        public async System.Threading.Tasks.Task<PageDocumentoPropostaResponse> ListarDocumentosPropostaUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idProposta = null, long? idDocumentosCredito = null, long? idStatusDocumentosCredito = null, long? idCondicoesDocumentosCredito = null, long? idTipoDocumentoCredito = null, long? idPessoaFisica = null, long? idLogAtendimento = null, string responsavel = null, int? flagDocumentoDigitalizado = null, string documentoDigitalizado = null, long? seqAnaliseCondicao = null, string observacao = null, string dataStatus = null)
        {
             ApiResponse<PageDocumentoPropostaResponse> localVarResponse = await ListarDocumentosPropostaUsingGETAsyncWithHttpInfo(sort, page, limit, id, idProposta, idDocumentosCredito, idStatusDocumentosCredito, idCondicoesDocumentosCredito, idTipoDocumentoCredito, idPessoaFisica, idLogAtendimento, responsavel, flagDocumentoDigitalizado, documentoDigitalizado, seqAnaliseCondicao, observacao, dataStatus);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{documento_proposta_resource_listar}}} {{{documento_proposta_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{documento_proposta_request_id_value}}} (optional)</param>
        /// <param name="idProposta">{{{documento_proposta_request_id_proposta_value}}} (optional)</param>
        /// <param name="idDocumentosCredito">{{{documento_proposta_request_id_tipo_documento_value}}} (optional)</param>
        /// <param name="idStatusDocumentosCredito">{{{documento_proposta_request_id_status_documento_credito_value}}} (optional)</param>
        /// <param name="idCondicoesDocumentosCredito">{{{documento_proposta_request_id_condicao_documento_credito_value}}} (optional)</param>
        /// <param name="idTipoDocumentoCredito">{{{documento_proposta_request_id_tipo_documento_credito_value}}} (optional)</param>
        /// <param name="idPessoaFisica">{{{documento_proposta_request_id_pessoa_fisica_value}}} (optional)</param>
        /// <param name="idLogAtendimento">{{{documento_proposta_request_id_log_atendimento_value}}} (optional)</param>
        /// <param name="responsavel">{{{documento_proposta_request_responsavel_value}}} (optional)</param>
        /// <param name="flagDocumentoDigitalizado">{{{documento_proposta_request_flag_documento_digitalizado_value}}} (optional)</param>
        /// <param name="documentoDigitalizado">{{{documento_proposta_request_documento_digitalizado_value}}} (optional)</param>
        /// <param name="seqAnaliseCondicao">{{{documento_proposta_request_seq_analise_condicao_value}}} (optional)</param>
        /// <param name="observacao">{{{documento_proposta_request_observacao_value}}} (optional)</param>
        /// <param name="dataStatus">{{{documento_proposta_request_data_status_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageDocumentoPropostaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageDocumentoPropostaResponse>> ListarDocumentosPropostaUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idProposta = null, long? idDocumentosCredito = null, long? idStatusDocumentosCredito = null, long? idCondicoesDocumentosCredito = null, long? idTipoDocumentoCredito = null, long? idPessoaFisica = null, long? idLogAtendimento = null, string responsavel = null, int? flagDocumentoDigitalizado = null, string documentoDigitalizado = null, long? seqAnaliseCondicao = null, string observacao = null, string dataStatus = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarDocumentosPropostaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarDocumentosPropostaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageDocumentoPropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDocumentoPropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDocumentoPropostaResponse)));
            
        }
        
        /// <summary>
        /// {{{proposta_resource_listar_status}}} {{{proposta_resource_listar_status_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="status">{{{status_proposta_request_status_value}}} (optional)</param> 
        /// <param name="flagPermiteAlteracao">{{{status_proposta_request_flag_permite_alteracao_value}}} (optional)</param> 
        /// <returns>PageStatusPropostaResponse</returns>
        public PageStatusPropostaResponse ListarStatusPropostaUsingGET (List<string> sort = null, int? page = null, int? limit = null, int? status = null, bool? flagPermiteAlteracao = null)
        {
             ApiResponse<PageStatusPropostaResponse> localVarResponse = ListarStatusPropostaUsingGETWithHttpInfo(sort, page, limit, status, flagPermiteAlteracao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{proposta_resource_listar_status}}} {{{proposta_resource_listar_status_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="status">{{{status_proposta_request_status_value}}} (optional)</param> 
        /// <param name="flagPermiteAlteracao">{{{status_proposta_request_flag_permite_alteracao_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageStatusPropostaResponse</returns>
        public ApiResponse< PageStatusPropostaResponse > ListarStatusPropostaUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, int? status = null, bool? flagPermiteAlteracao = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusPropostaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusPropostaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageStatusPropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusPropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusPropostaResponse)));
            
        }

        
        /// <summary>
        /// {{{proposta_resource_listar_status}}} {{{proposta_resource_listar_status_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="status">{{{status_proposta_request_status_value}}} (optional)</param>
        /// <param name="flagPermiteAlteracao">{{{status_proposta_request_flag_permite_alteracao_value}}} (optional)</param>
        /// <returns>Task of PageStatusPropostaResponse</returns>
        public async System.Threading.Tasks.Task<PageStatusPropostaResponse> ListarStatusPropostaUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, int? status = null, bool? flagPermiteAlteracao = null)
        {
             ApiResponse<PageStatusPropostaResponse> localVarResponse = await ListarStatusPropostaUsingGETAsyncWithHttpInfo(sort, page, limit, status, flagPermiteAlteracao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{proposta_resource_listar_status}}} {{{proposta_resource_listar_status_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="status">{{{status_proposta_request_status_value}}} (optional)</param>
        /// <param name="flagPermiteAlteracao">{{{status_proposta_request_flag_permite_alteracao_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusPropostaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageStatusPropostaResponse>> ListarStatusPropostaUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, int? status = null, bool? flagPermiteAlteracao = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusPropostaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusPropostaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageStatusPropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusPropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusPropostaResponse)));
            
        }
        
        /// <summary>
        /// {{{proposta_resource_listar}}} {{{proposta_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="status">{{{proposta_request_status_value}}} (optional)</param> 
        /// <returns>PagePropostaResponse</returns>
        public PagePropostaResponse ListarUsingGET38 (List<string> sort = null, int? page = null, int? limit = null, int? status = null)
        {
             ApiResponse<PagePropostaResponse> localVarResponse = ListarUsingGET38WithHttpInfo(sort, page, limit, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{proposta_resource_listar}}} {{{proposta_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="status">{{{proposta_request_status_value}}} (optional)</param> 
        /// <returns>ApiResponse of PagePropostaResponse</returns>
        public ApiResponse< PagePropostaResponse > ListarUsingGET38WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, int? status = null)
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET38: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET38: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePropostaResponse)));
            
        }

        
        /// <summary>
        /// {{{proposta_resource_listar}}} {{{proposta_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="status">{{{proposta_request_status_value}}} (optional)</param>
        /// <returns>Task of PagePropostaResponse</returns>
        public async System.Threading.Tasks.Task<PagePropostaResponse> ListarUsingGET38Async (List<string> sort = null, int? page = null, int? limit = null, int? status = null)
        {
             ApiResponse<PagePropostaResponse> localVarResponse = await ListarUsingGET38AsyncWithHttpInfo(sort, page, limit, status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{proposta_resource_listar}}} {{{proposta_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="status">{{{proposta_request_status_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PagePropostaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePropostaResponse>> ListarUsingGET38AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, int? status = null)
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET38: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET38: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePropostaResponse)));
            
        }
        
    }
    
}
