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
    public interface IGlobaltagstatusparametroApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{estagio_cartao_resource_consultar_estagio_cartao}}}
        /// </summary>
        /// <remarks>
        /// {{{estagio_cartao_resource_consultar_estagio_cartao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{estagio_cartao_resource_consultar_estagio_cartao_param_id}}}</param>
        /// <returns>EstagioCartaoResponse</returns>
        EstagioCartaoResponse ConsultarEstagioCartaoUsingGET (long? id);
  
        /// <summary>
        /// {{{estagio_cartao_resource_consultar_estagio_cartao}}}
        /// </summary>
        /// <remarks>
        /// {{{estagio_cartao_resource_consultar_estagio_cartao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{estagio_cartao_resource_consultar_estagio_cartao_param_id}}}</param>
        /// <returns>ApiResponse of EstagioCartaoResponse</returns>
        ApiResponse<EstagioCartaoResponse> ConsultarEstagioCartaoUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{status_cartao_resource_consultar_status_cartao}}}
        /// </summary>
        /// <remarks>
        /// {{{status_cartao_resource_consultar_status_cartao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{status_cartao_resource_consultar_status_cartao_param_id}}}</param>
        /// <returns>StatusCartaoResponse</returns>
        StatusCartaoResponse ConsultarStatusCartaoUsingGET (long? id);
  
        /// <summary>
        /// {{{status_cartao_resource_consultar_status_cartao}}}
        /// </summary>
        /// <remarks>
        /// {{{status_cartao_resource_consultar_status_cartao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{status_cartao_resource_consultar_status_cartao_param_id}}}</param>
        /// <returns>ApiResponse of StatusCartaoResponse</returns>
        ApiResponse<StatusCartaoResponse> ConsultarStatusCartaoUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{status_conta_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{status_conta_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{status_conta_resource_consultar_param_id}}}</param>
        /// <returns>StatusContaResponse</returns>
        StatusContaResponse ConsultarUsingGET36 (long? id);
  
        /// <summary>
        /// {{{status_conta_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{status_conta_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{status_conta_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of StatusContaResponse</returns>
        ApiResponse<StatusContaResponse> ConsultarUsingGET36WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{status_impressao_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{status_impressao_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{status_impressao_resource_consultar_param_id}}}</param>
        /// <returns>StatusImpressaoResponse</returns>
        StatusImpressaoResponse ConsultarUsingGET37 (long? id);
  
        /// <summary>
        /// {{{status_impressao_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{status_impressao_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{status_impressao_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of StatusImpressaoResponse</returns>
        ApiResponse<StatusImpressaoResponse> ConsultarUsingGET37WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{estagio_cartao_resource_listar_estagios_cartoes}}}
        /// </summary>
        /// <remarks>
        /// {{{estagio_cartao_resource_listar_estagios_cartoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{estagio_cartao_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{estagio_cartao_request_nome_value}}} (optional)</param>
        /// <returns>PageEstagioCartaoResponse</returns>
        PageEstagioCartaoResponse ListarEstagiosCartoesUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
  
        /// <summary>
        /// {{{estagio_cartao_resource_listar_estagios_cartoes}}}
        /// </summary>
        /// <remarks>
        /// {{{estagio_cartao_resource_listar_estagios_cartoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{estagio_cartao_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{estagio_cartao_request_nome_value}}} (optional)</param>
        /// <returns>ApiResponse of PageEstagioCartaoResponse</returns>
        ApiResponse<PageEstagioCartaoResponse> ListarEstagiosCartoesUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
        
        /// <summary>
        /// {{{status_cnab_sumarizado_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{status_cnab_sumarizado_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>PageTipoBoletoResponse</returns>
        PageTipoBoletoResponse ListarStatusCNABSumarizadosUsingGET (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{status_cnab_sumarizado_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{status_cnab_sumarizado_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of PageTipoBoletoResponse</returns>
        ApiResponse<PageTipoBoletoResponse> ListarStatusCNABSumarizadosUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{status_cartao_resource_listar_status_cartoes}}}
        /// </summary>
        /// <remarks>
        /// {{{status_cartao_resource_listar_status_cartoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{status_cartao_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{status_cartao_request_nome_value}}} (optional)</param>
        /// <param name="permiteDesbloquear">{{{status_cartao_request_permite_desbloquear_value}}} (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">{{{status_cartao_request_permite_atribuir_como_bloqueio_value}}} (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">{{{status_cartao_request_permite_atribuir_como_cancelamento_value}}} (optional)</param>
        /// <param name="cobrarTarifaAoEmitirNovaVia">{{{status_cartao_request_cobrar_tarifa_ao_emitir_nova_via_value}}} (optional)</param>
        /// <returns>PageStatusCartaoResponse</returns>
        PageStatusCartaoResponse ListarStatusCartoesUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteDesbloquear = null, int? permiteAtribuirComoBloqueio = null, int? permiteAtribuirComoCancelamento = null, int? cobrarTarifaAoEmitirNovaVia = null);
  
        /// <summary>
        /// {{{status_cartao_resource_listar_status_cartoes}}}
        /// </summary>
        /// <remarks>
        /// {{{status_cartao_resource_listar_status_cartoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{status_cartao_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{status_cartao_request_nome_value}}} (optional)</param>
        /// <param name="permiteDesbloquear">{{{status_cartao_request_permite_desbloquear_value}}} (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">{{{status_cartao_request_permite_atribuir_como_bloqueio_value}}} (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">{{{status_cartao_request_permite_atribuir_como_cancelamento_value}}} (optional)</param>
        /// <param name="cobrarTarifaAoEmitirNovaVia">{{{status_cartao_request_cobrar_tarifa_ao_emitir_nova_via_value}}} (optional)</param>
        /// <returns>ApiResponse of PageStatusCartaoResponse</returns>
        ApiResponse<PageStatusCartaoResponse> ListarStatusCartoesUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteDesbloquear = null, int? permiteAtribuirComoBloqueio = null, int? permiteAtribuirComoCancelamento = null, int? cobrarTarifaAoEmitirNovaVia = null);
        
        /// <summary>
        /// {{{status_conta_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{status_conta_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{status_conta_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{status_conta_request_nome_value}}} (optional)</param>
        /// <param name="permiteAlterarVencimento">{{{status_conta_request_permite_alterar_vencimento_value}}} (optional)</param>
        /// <param name="permiteAlterarLimite">{{{status_conta_request_permite_alterar_limite_value}}} (optional)</param>
        /// <param name="permiteEmitirNovaViaCartao">{{{status_conta_request_permite_emitir_nova_via_cartao_value}}} (optional)</param>
        /// <param name="permiteFazerTransferencia">{{{status_conta_request_permite_fazer_transferencia_value}}} (optional)</param>
        /// <param name="permiteReceberTransferencia">{{{status_conta_request_permite_receber_transferencia_value}}} (optional)</param>
        /// <param name="permiteCriarAcordoCobranca">{{{status_conta_request_permite_criar_acordo_cobranca_value}}} (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">{{{status_conta_request_permite_atribuir_como_bloqueio_value}}} (optional)</param>
        /// <param name="permiteDesbloquear">{{{status_conta_request_permite_desbloquear_value}}} (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">{{{status_conta_request_permite_atribuir_como_cancelamento_value}}} (optional)</param>
        /// <returns>PageStatusContaResponse</returns>
        PageStatusContaResponse ListarUsingGET44 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteAlterarVencimento = null, int? permiteAlterarLimite = null, int? permiteEmitirNovaViaCartao = null, int? permiteFazerTransferencia = null, int? permiteReceberTransferencia = null, int? permiteCriarAcordoCobranca = null, int? permiteAtribuirComoBloqueio = null, int? permiteDesbloquear = null, int? permiteAtribuirComoCancelamento = null);
  
        /// <summary>
        /// {{{status_conta_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{status_conta_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{status_conta_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{status_conta_request_nome_value}}} (optional)</param>
        /// <param name="permiteAlterarVencimento">{{{status_conta_request_permite_alterar_vencimento_value}}} (optional)</param>
        /// <param name="permiteAlterarLimite">{{{status_conta_request_permite_alterar_limite_value}}} (optional)</param>
        /// <param name="permiteEmitirNovaViaCartao">{{{status_conta_request_permite_emitir_nova_via_cartao_value}}} (optional)</param>
        /// <param name="permiteFazerTransferencia">{{{status_conta_request_permite_fazer_transferencia_value}}} (optional)</param>
        /// <param name="permiteReceberTransferencia">{{{status_conta_request_permite_receber_transferencia_value}}} (optional)</param>
        /// <param name="permiteCriarAcordoCobranca">{{{status_conta_request_permite_criar_acordo_cobranca_value}}} (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">{{{status_conta_request_permite_atribuir_como_bloqueio_value}}} (optional)</param>
        /// <param name="permiteDesbloquear">{{{status_conta_request_permite_desbloquear_value}}} (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">{{{status_conta_request_permite_atribuir_como_cancelamento_value}}} (optional)</param>
        /// <returns>ApiResponse of PageStatusContaResponse</returns>
        ApiResponse<PageStatusContaResponse> ListarUsingGET44WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteAlterarVencimento = null, int? permiteAlterarLimite = null, int? permiteEmitirNovaViaCartao = null, int? permiteFazerTransferencia = null, int? permiteReceberTransferencia = null, int? permiteCriarAcordoCobranca = null, int? permiteAtribuirComoBloqueio = null, int? permiteDesbloquear = null, int? permiteAtribuirComoCancelamento = null);
        
        /// <summary>
        /// {{{status_impressao_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{status_impressao_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{status_impressao_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{status_impressao_request_nome_value}}} (optional)</param>
        /// <returns>PageStatusImpressaoResponse</returns>
        PageStatusImpressaoResponse ListarUsingGET45 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
  
        /// <summary>
        /// {{{status_impressao_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{status_impressao_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{status_impressao_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{status_impressao_request_nome_value}}} (optional)</param>
        /// <returns>ApiResponse of PageStatusImpressaoResponse</returns>
        ApiResponse<PageStatusImpressaoResponse> ListarUsingGET45WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{estagio_cartao_resource_consultar_estagio_cartao}}}
        /// </summary>
        /// <remarks>
        /// {{{estagio_cartao_resource_consultar_estagio_cartao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{estagio_cartao_resource_consultar_estagio_cartao_param_id}}}</param>
        /// <returns>Task of EstagioCartaoResponse</returns>
        System.Threading.Tasks.Task<EstagioCartaoResponse> ConsultarEstagioCartaoUsingGETAsync (long? id);

        /// <summary>
        /// {{{estagio_cartao_resource_consultar_estagio_cartao}}}
        /// </summary>
        /// <remarks>
        /// {{{estagio_cartao_resource_consultar_estagio_cartao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{estagio_cartao_resource_consultar_estagio_cartao_param_id}}}</param>
        /// <returns>Task of ApiResponse (EstagioCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EstagioCartaoResponse>> ConsultarEstagioCartaoUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{status_cartao_resource_consultar_status_cartao}}}
        /// </summary>
        /// <remarks>
        /// {{{status_cartao_resource_consultar_status_cartao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{status_cartao_resource_consultar_status_cartao_param_id}}}</param>
        /// <returns>Task of StatusCartaoResponse</returns>
        System.Threading.Tasks.Task<StatusCartaoResponse> ConsultarStatusCartaoUsingGETAsync (long? id);

        /// <summary>
        /// {{{status_cartao_resource_consultar_status_cartao}}}
        /// </summary>
        /// <remarks>
        /// {{{status_cartao_resource_consultar_status_cartao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{status_cartao_resource_consultar_status_cartao_param_id}}}</param>
        /// <returns>Task of ApiResponse (StatusCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StatusCartaoResponse>> ConsultarStatusCartaoUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{status_conta_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{status_conta_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{status_conta_resource_consultar_param_id}}}</param>
        /// <returns>Task of StatusContaResponse</returns>
        System.Threading.Tasks.Task<StatusContaResponse> ConsultarUsingGET36Async (long? id);

        /// <summary>
        /// {{{status_conta_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{status_conta_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{status_conta_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (StatusContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StatusContaResponse>> ConsultarUsingGET36AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{status_impressao_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{status_impressao_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{status_impressao_resource_consultar_param_id}}}</param>
        /// <returns>Task of StatusImpressaoResponse</returns>
        System.Threading.Tasks.Task<StatusImpressaoResponse> ConsultarUsingGET37Async (long? id);

        /// <summary>
        /// {{{status_impressao_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{status_impressao_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{status_impressao_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (StatusImpressaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StatusImpressaoResponse>> ConsultarUsingGET37AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{estagio_cartao_resource_listar_estagios_cartoes}}}
        /// </summary>
        /// <remarks>
        /// {{{estagio_cartao_resource_listar_estagios_cartoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{estagio_cartao_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{estagio_cartao_request_nome_value}}} (optional)</param>
        /// <returns>Task of PageEstagioCartaoResponse</returns>
        System.Threading.Tasks.Task<PageEstagioCartaoResponse> ListarEstagiosCartoesUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);

        /// <summary>
        /// {{{estagio_cartao_resource_listar_estagios_cartoes}}}
        /// </summary>
        /// <remarks>
        /// {{{estagio_cartao_resource_listar_estagios_cartoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{estagio_cartao_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{estagio_cartao_request_nome_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageEstagioCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageEstagioCartaoResponse>> ListarEstagiosCartoesUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
        
        /// <summary>
        /// {{{status_cnab_sumarizado_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{status_cnab_sumarizado_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageTipoBoletoResponse</returns>
        System.Threading.Tasks.Task<PageTipoBoletoResponse> ListarStatusCNABSumarizadosUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{status_cnab_sumarizado_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{status_cnab_sumarizado_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoBoletoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoBoletoResponse>> ListarStatusCNABSumarizadosUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{status_cartao_resource_listar_status_cartoes}}}
        /// </summary>
        /// <remarks>
        /// {{{status_cartao_resource_listar_status_cartoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{status_cartao_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{status_cartao_request_nome_value}}} (optional)</param>
        /// <param name="permiteDesbloquear">{{{status_cartao_request_permite_desbloquear_value}}} (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">{{{status_cartao_request_permite_atribuir_como_bloqueio_value}}} (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">{{{status_cartao_request_permite_atribuir_como_cancelamento_value}}} (optional)</param>
        /// <param name="cobrarTarifaAoEmitirNovaVia">{{{status_cartao_request_cobrar_tarifa_ao_emitir_nova_via_value}}} (optional)</param>
        /// <returns>Task of PageStatusCartaoResponse</returns>
        System.Threading.Tasks.Task<PageStatusCartaoResponse> ListarStatusCartoesUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteDesbloquear = null, int? permiteAtribuirComoBloqueio = null, int? permiteAtribuirComoCancelamento = null, int? cobrarTarifaAoEmitirNovaVia = null);

        /// <summary>
        /// {{{status_cartao_resource_listar_status_cartoes}}}
        /// </summary>
        /// <remarks>
        /// {{{status_cartao_resource_listar_status_cartoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{status_cartao_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{status_cartao_request_nome_value}}} (optional)</param>
        /// <param name="permiteDesbloquear">{{{status_cartao_request_permite_desbloquear_value}}} (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">{{{status_cartao_request_permite_atribuir_como_bloqueio_value}}} (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">{{{status_cartao_request_permite_atribuir_como_cancelamento_value}}} (optional)</param>
        /// <param name="cobrarTarifaAoEmitirNovaVia">{{{status_cartao_request_cobrar_tarifa_ao_emitir_nova_via_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageStatusCartaoResponse>> ListarStatusCartoesUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteDesbloquear = null, int? permiteAtribuirComoBloqueio = null, int? permiteAtribuirComoCancelamento = null, int? cobrarTarifaAoEmitirNovaVia = null);
        
        /// <summary>
        /// {{{status_conta_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{status_conta_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{status_conta_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{status_conta_request_nome_value}}} (optional)</param>
        /// <param name="permiteAlterarVencimento">{{{status_conta_request_permite_alterar_vencimento_value}}} (optional)</param>
        /// <param name="permiteAlterarLimite">{{{status_conta_request_permite_alterar_limite_value}}} (optional)</param>
        /// <param name="permiteEmitirNovaViaCartao">{{{status_conta_request_permite_emitir_nova_via_cartao_value}}} (optional)</param>
        /// <param name="permiteFazerTransferencia">{{{status_conta_request_permite_fazer_transferencia_value}}} (optional)</param>
        /// <param name="permiteReceberTransferencia">{{{status_conta_request_permite_receber_transferencia_value}}} (optional)</param>
        /// <param name="permiteCriarAcordoCobranca">{{{status_conta_request_permite_criar_acordo_cobranca_value}}} (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">{{{status_conta_request_permite_atribuir_como_bloqueio_value}}} (optional)</param>
        /// <param name="permiteDesbloquear">{{{status_conta_request_permite_desbloquear_value}}} (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">{{{status_conta_request_permite_atribuir_como_cancelamento_value}}} (optional)</param>
        /// <returns>Task of PageStatusContaResponse</returns>
        System.Threading.Tasks.Task<PageStatusContaResponse> ListarUsingGET44Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteAlterarVencimento = null, int? permiteAlterarLimite = null, int? permiteEmitirNovaViaCartao = null, int? permiteFazerTransferencia = null, int? permiteReceberTransferencia = null, int? permiteCriarAcordoCobranca = null, int? permiteAtribuirComoBloqueio = null, int? permiteDesbloquear = null, int? permiteAtribuirComoCancelamento = null);

        /// <summary>
        /// {{{status_conta_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{status_conta_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{status_conta_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{status_conta_request_nome_value}}} (optional)</param>
        /// <param name="permiteAlterarVencimento">{{{status_conta_request_permite_alterar_vencimento_value}}} (optional)</param>
        /// <param name="permiteAlterarLimite">{{{status_conta_request_permite_alterar_limite_value}}} (optional)</param>
        /// <param name="permiteEmitirNovaViaCartao">{{{status_conta_request_permite_emitir_nova_via_cartao_value}}} (optional)</param>
        /// <param name="permiteFazerTransferencia">{{{status_conta_request_permite_fazer_transferencia_value}}} (optional)</param>
        /// <param name="permiteReceberTransferencia">{{{status_conta_request_permite_receber_transferencia_value}}} (optional)</param>
        /// <param name="permiteCriarAcordoCobranca">{{{status_conta_request_permite_criar_acordo_cobranca_value}}} (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">{{{status_conta_request_permite_atribuir_como_bloqueio_value}}} (optional)</param>
        /// <param name="permiteDesbloquear">{{{status_conta_request_permite_desbloquear_value}}} (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">{{{status_conta_request_permite_atribuir_como_cancelamento_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageStatusContaResponse>> ListarUsingGET44AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteAlterarVencimento = null, int? permiteAlterarLimite = null, int? permiteEmitirNovaViaCartao = null, int? permiteFazerTransferencia = null, int? permiteReceberTransferencia = null, int? permiteCriarAcordoCobranca = null, int? permiteAtribuirComoBloqueio = null, int? permiteDesbloquear = null, int? permiteAtribuirComoCancelamento = null);
        
        /// <summary>
        /// {{{status_impressao_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{status_impressao_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{status_impressao_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{status_impressao_request_nome_value}}} (optional)</param>
        /// <returns>Task of PageStatusImpressaoResponse</returns>
        System.Threading.Tasks.Task<PageStatusImpressaoResponse> ListarUsingGET45Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);

        /// <summary>
        /// {{{status_impressao_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{status_impressao_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{status_impressao_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{status_impressao_request_nome_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusImpressaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageStatusImpressaoResponse>> ListarUsingGET45AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltagstatusparametroApi : IGlobaltagstatusparametroApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagstatusparametroApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltagstatusparametroApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagstatusparametroApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltagstatusparametroApi(Configuration configuration = null)
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
        /// {{{estagio_cartao_resource_consultar_estagio_cartao}}} {{{estagio_cartao_resource_consultar_estagio_cartao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{estagio_cartao_resource_consultar_estagio_cartao_param_id}}}</param> 
        /// <returns>EstagioCartaoResponse</returns>
        public EstagioCartaoResponse ConsultarEstagioCartaoUsingGET (long? id)
        {
             ApiResponse<EstagioCartaoResponse> localVarResponse = ConsultarEstagioCartaoUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{estagio_cartao_resource_consultar_estagio_cartao}}} {{{estagio_cartao_resource_consultar_estagio_cartao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{estagio_cartao_resource_consultar_estagio_cartao_param_id}}}</param> 
        /// <returns>ApiResponse of EstagioCartaoResponse</returns>
        public ApiResponse< EstagioCartaoResponse > ConsultarEstagioCartaoUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagstatusparametroApi->ConsultarEstagioCartaoUsingGET");
            
    
            var localVarPath = "/api/estagios-cartoes/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarEstagioCartaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarEstagioCartaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EstagioCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstagioCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstagioCartaoResponse)));
            
        }

        
        /// <summary>
        /// {{{estagio_cartao_resource_consultar_estagio_cartao}}} {{{estagio_cartao_resource_consultar_estagio_cartao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{estagio_cartao_resource_consultar_estagio_cartao_param_id}}}</param>
        /// <returns>Task of EstagioCartaoResponse</returns>
        public async System.Threading.Tasks.Task<EstagioCartaoResponse> ConsultarEstagioCartaoUsingGETAsync (long? id)
        {
             ApiResponse<EstagioCartaoResponse> localVarResponse = await ConsultarEstagioCartaoUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{estagio_cartao_resource_consultar_estagio_cartao}}} {{{estagio_cartao_resource_consultar_estagio_cartao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{estagio_cartao_resource_consultar_estagio_cartao_param_id}}}</param>
        /// <returns>Task of ApiResponse (EstagioCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EstagioCartaoResponse>> ConsultarEstagioCartaoUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarEstagioCartaoUsingGET");
            
    
            var localVarPath = "/api/estagios-cartoes/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarEstagioCartaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarEstagioCartaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EstagioCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstagioCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstagioCartaoResponse)));
            
        }
        
        /// <summary>
        /// {{{status_cartao_resource_consultar_status_cartao}}} {{{status_cartao_resource_consultar_status_cartao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{status_cartao_resource_consultar_status_cartao_param_id}}}</param> 
        /// <returns>StatusCartaoResponse</returns>
        public StatusCartaoResponse ConsultarStatusCartaoUsingGET (long? id)
        {
             ApiResponse<StatusCartaoResponse> localVarResponse = ConsultarStatusCartaoUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{status_cartao_resource_consultar_status_cartao}}} {{{status_cartao_resource_consultar_status_cartao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{status_cartao_resource_consultar_status_cartao_param_id}}}</param> 
        /// <returns>ApiResponse of StatusCartaoResponse</returns>
        public ApiResponse< StatusCartaoResponse > ConsultarStatusCartaoUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagstatusparametroApi->ConsultarStatusCartaoUsingGET");
            
    
            var localVarPath = "/api/status-cartoes/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusCartaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusCartaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<StatusCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusCartaoResponse)));
            
        }

        
        /// <summary>
        /// {{{status_cartao_resource_consultar_status_cartao}}} {{{status_cartao_resource_consultar_status_cartao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{status_cartao_resource_consultar_status_cartao_param_id}}}</param>
        /// <returns>Task of StatusCartaoResponse</returns>
        public async System.Threading.Tasks.Task<StatusCartaoResponse> ConsultarStatusCartaoUsingGETAsync (long? id)
        {
             ApiResponse<StatusCartaoResponse> localVarResponse = await ConsultarStatusCartaoUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{status_cartao_resource_consultar_status_cartao}}} {{{status_cartao_resource_consultar_status_cartao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{status_cartao_resource_consultar_status_cartao_param_id}}}</param>
        /// <returns>Task of ApiResponse (StatusCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StatusCartaoResponse>> ConsultarStatusCartaoUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarStatusCartaoUsingGET");
            
    
            var localVarPath = "/api/status-cartoes/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusCartaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusCartaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StatusCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusCartaoResponse)));
            
        }
        
        /// <summary>
        /// {{{status_conta_resource_consultar}}} {{{status_conta_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{status_conta_resource_consultar_param_id}}}</param> 
        /// <returns>StatusContaResponse</returns>
        public StatusContaResponse ConsultarUsingGET36 (long? id)
        {
             ApiResponse<StatusContaResponse> localVarResponse = ConsultarUsingGET36WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{status_conta_resource_consultar}}} {{{status_conta_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{status_conta_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of StatusContaResponse</returns>
        public ApiResponse< StatusContaResponse > ConsultarUsingGET36WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagstatusparametroApi->ConsultarUsingGET36");
            
    
            var localVarPath = "/api/status-contas/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET36: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET36: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<StatusContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusContaResponse)));
            
        }

        
        /// <summary>
        /// {{{status_conta_resource_consultar}}} {{{status_conta_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{status_conta_resource_consultar_param_id}}}</param>
        /// <returns>Task of StatusContaResponse</returns>
        public async System.Threading.Tasks.Task<StatusContaResponse> ConsultarUsingGET36Async (long? id)
        {
             ApiResponse<StatusContaResponse> localVarResponse = await ConsultarUsingGET36AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{status_conta_resource_consultar}}} {{{status_conta_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{status_conta_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (StatusContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StatusContaResponse>> ConsultarUsingGET36AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET36");
            
    
            var localVarPath = "/api/status-contas/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET36: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET36: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StatusContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusContaResponse)));
            
        }
        
        /// <summary>
        /// {{{status_impressao_resource_consultar}}} {{{status_impressao_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{status_impressao_resource_consultar_param_id}}}</param> 
        /// <returns>StatusImpressaoResponse</returns>
        public StatusImpressaoResponse ConsultarUsingGET37 (long? id)
        {
             ApiResponse<StatusImpressaoResponse> localVarResponse = ConsultarUsingGET37WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{status_impressao_resource_consultar}}} {{{status_impressao_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{status_impressao_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of StatusImpressaoResponse</returns>
        public ApiResponse< StatusImpressaoResponse > ConsultarUsingGET37WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagstatusparametroApi->ConsultarUsingGET37");
            
    
            var localVarPath = "/api/status-impressoes/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET37: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET37: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<StatusImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusImpressaoResponse)));
            
        }

        
        /// <summary>
        /// {{{status_impressao_resource_consultar}}} {{{status_impressao_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{status_impressao_resource_consultar_param_id}}}</param>
        /// <returns>Task of StatusImpressaoResponse</returns>
        public async System.Threading.Tasks.Task<StatusImpressaoResponse> ConsultarUsingGET37Async (long? id)
        {
             ApiResponse<StatusImpressaoResponse> localVarResponse = await ConsultarUsingGET37AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{status_impressao_resource_consultar}}} {{{status_impressao_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{status_impressao_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (StatusImpressaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StatusImpressaoResponse>> ConsultarUsingGET37AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET37");
            
    
            var localVarPath = "/api/status-impressoes/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET37: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET37: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StatusImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusImpressaoResponse)));
            
        }
        
        /// <summary>
        /// {{{estagio_cartao_resource_listar_estagios_cartoes}}} {{{estagio_cartao_resource_listar_estagios_cartoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{estagio_cartao_request_id_value}}} (optional)</param> 
        /// <param name="nome">{{{estagio_cartao_request_nome_value}}} (optional)</param> 
        /// <returns>PageEstagioCartaoResponse</returns>
        public PageEstagioCartaoResponse ListarEstagiosCartoesUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageEstagioCartaoResponse> localVarResponse = ListarEstagiosCartoesUsingGETWithHttpInfo(sort, page, limit, id, nome);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{estagio_cartao_resource_listar_estagios_cartoes}}} {{{estagio_cartao_resource_listar_estagios_cartoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{estagio_cartao_request_id_value}}} (optional)</param> 
        /// <param name="nome">{{{estagio_cartao_request_nome_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageEstagioCartaoResponse</returns>
        public ApiResponse< PageEstagioCartaoResponse > ListarEstagiosCartoesUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
            
    
            var localVarPath = "/api/estagios-cartoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarEstagiosCartoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarEstagiosCartoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageEstagioCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEstagioCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEstagioCartaoResponse)));
            
        }

        
        /// <summary>
        /// {{{estagio_cartao_resource_listar_estagios_cartoes}}} {{{estagio_cartao_resource_listar_estagios_cartoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{estagio_cartao_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{estagio_cartao_request_nome_value}}} (optional)</param>
        /// <returns>Task of PageEstagioCartaoResponse</returns>
        public async System.Threading.Tasks.Task<PageEstagioCartaoResponse> ListarEstagiosCartoesUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageEstagioCartaoResponse> localVarResponse = await ListarEstagiosCartoesUsingGETAsyncWithHttpInfo(sort, page, limit, id, nome);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{estagio_cartao_resource_listar_estagios_cartoes}}} {{{estagio_cartao_resource_listar_estagios_cartoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{estagio_cartao_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{estagio_cartao_request_nome_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageEstagioCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageEstagioCartaoResponse>> ListarEstagiosCartoesUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
            
    
            var localVarPath = "/api/estagios-cartoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarEstagiosCartoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarEstagiosCartoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageEstagioCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEstagioCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEstagioCartaoResponse)));
            
        }
        
        /// <summary>
        /// {{{status_cnab_sumarizado_resource_listar}}} {{{status_cnab_sumarizado_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>PageTipoBoletoResponse</returns>
        public PageTipoBoletoResponse ListarStatusCNABSumarizadosUsingGET (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTipoBoletoResponse> localVarResponse = ListarStatusCNABSumarizadosUsingGETWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{status_cnab_sumarizado_resource_listar}}} {{{status_cnab_sumarizado_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>ApiResponse of PageTipoBoletoResponse</returns>
        public ApiResponse< PageTipoBoletoResponse > ListarStatusCNABSumarizadosUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/status-cnab-sumarizados";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCNABSumarizadosUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCNABSumarizadosUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoBoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoBoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoBoletoResponse)));
            
        }

        
        /// <summary>
        /// {{{status_cnab_sumarizado_resource_listar}}} {{{status_cnab_sumarizado_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageTipoBoletoResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoBoletoResponse> ListarStatusCNABSumarizadosUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTipoBoletoResponse> localVarResponse = await ListarStatusCNABSumarizadosUsingGETAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{status_cnab_sumarizado_resource_listar}}} {{{status_cnab_sumarizado_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoBoletoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoBoletoResponse>> ListarStatusCNABSumarizadosUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/status-cnab-sumarizados";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCNABSumarizadosUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCNABSumarizadosUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoBoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoBoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoBoletoResponse)));
            
        }
        
        /// <summary>
        /// {{{status_cartao_resource_listar_status_cartoes}}} {{{status_cartao_resource_listar_status_cartoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{status_cartao_request_id_value}}} (optional)</param> 
        /// <param name="nome">{{{status_cartao_request_nome_value}}} (optional)</param> 
        /// <param name="permiteDesbloquear">{{{status_cartao_request_permite_desbloquear_value}}} (optional)</param> 
        /// <param name="permiteAtribuirComoBloqueio">{{{status_cartao_request_permite_atribuir_como_bloqueio_value}}} (optional)</param> 
        /// <param name="permiteAtribuirComoCancelamento">{{{status_cartao_request_permite_atribuir_como_cancelamento_value}}} (optional)</param> 
        /// <param name="cobrarTarifaAoEmitirNovaVia">{{{status_cartao_request_cobrar_tarifa_ao_emitir_nova_via_value}}} (optional)</param> 
        /// <returns>PageStatusCartaoResponse</returns>
        public PageStatusCartaoResponse ListarStatusCartoesUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteDesbloquear = null, int? permiteAtribuirComoBloqueio = null, int? permiteAtribuirComoCancelamento = null, int? cobrarTarifaAoEmitirNovaVia = null)
        {
             ApiResponse<PageStatusCartaoResponse> localVarResponse = ListarStatusCartoesUsingGETWithHttpInfo(sort, page, limit, id, nome, permiteDesbloquear, permiteAtribuirComoBloqueio, permiteAtribuirComoCancelamento, cobrarTarifaAoEmitirNovaVia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{status_cartao_resource_listar_status_cartoes}}} {{{status_cartao_resource_listar_status_cartoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{status_cartao_request_id_value}}} (optional)</param> 
        /// <param name="nome">{{{status_cartao_request_nome_value}}} (optional)</param> 
        /// <param name="permiteDesbloquear">{{{status_cartao_request_permite_desbloquear_value}}} (optional)</param> 
        /// <param name="permiteAtribuirComoBloqueio">{{{status_cartao_request_permite_atribuir_como_bloqueio_value}}} (optional)</param> 
        /// <param name="permiteAtribuirComoCancelamento">{{{status_cartao_request_permite_atribuir_como_cancelamento_value}}} (optional)</param> 
        /// <param name="cobrarTarifaAoEmitirNovaVia">{{{status_cartao_request_cobrar_tarifa_ao_emitir_nova_via_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageStatusCartaoResponse</returns>
        public ApiResponse< PageStatusCartaoResponse > ListarStatusCartoesUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteDesbloquear = null, int? permiteAtribuirComoBloqueio = null, int? permiteAtribuirComoCancelamento = null, int? cobrarTarifaAoEmitirNovaVia = null)
        {
            
    
            var localVarPath = "/api/status-cartoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (permiteDesbloquear != null) localVarQueryParams.Add("permiteDesbloquear", Configuration.ApiClient.ParameterToString(permiteDesbloquear)); // query parameter
            if (permiteAtribuirComoBloqueio != null) localVarQueryParams.Add("permiteAtribuirComoBloqueio", Configuration.ApiClient.ParameterToString(permiteAtribuirComoBloqueio)); // query parameter
            if (permiteAtribuirComoCancelamento != null) localVarQueryParams.Add("permiteAtribuirComoCancelamento", Configuration.ApiClient.ParameterToString(permiteAtribuirComoCancelamento)); // query parameter
            if (cobrarTarifaAoEmitirNovaVia != null) localVarQueryParams.Add("cobrarTarifaAoEmitirNovaVia", Configuration.ApiClient.ParameterToString(cobrarTarifaAoEmitirNovaVia)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCartoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCartoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageStatusCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusCartaoResponse)));
            
        }

        
        /// <summary>
        /// {{{status_cartao_resource_listar_status_cartoes}}} {{{status_cartao_resource_listar_status_cartoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{status_cartao_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{status_cartao_request_nome_value}}} (optional)</param>
        /// <param name="permiteDesbloquear">{{{status_cartao_request_permite_desbloquear_value}}} (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">{{{status_cartao_request_permite_atribuir_como_bloqueio_value}}} (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">{{{status_cartao_request_permite_atribuir_como_cancelamento_value}}} (optional)</param>
        /// <param name="cobrarTarifaAoEmitirNovaVia">{{{status_cartao_request_cobrar_tarifa_ao_emitir_nova_via_value}}} (optional)</param>
        /// <returns>Task of PageStatusCartaoResponse</returns>
        public async System.Threading.Tasks.Task<PageStatusCartaoResponse> ListarStatusCartoesUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteDesbloquear = null, int? permiteAtribuirComoBloqueio = null, int? permiteAtribuirComoCancelamento = null, int? cobrarTarifaAoEmitirNovaVia = null)
        {
             ApiResponse<PageStatusCartaoResponse> localVarResponse = await ListarStatusCartoesUsingGETAsyncWithHttpInfo(sort, page, limit, id, nome, permiteDesbloquear, permiteAtribuirComoBloqueio, permiteAtribuirComoCancelamento, cobrarTarifaAoEmitirNovaVia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{status_cartao_resource_listar_status_cartoes}}} {{{status_cartao_resource_listar_status_cartoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{status_cartao_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{status_cartao_request_nome_value}}} (optional)</param>
        /// <param name="permiteDesbloquear">{{{status_cartao_request_permite_desbloquear_value}}} (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">{{{status_cartao_request_permite_atribuir_como_bloqueio_value}}} (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">{{{status_cartao_request_permite_atribuir_como_cancelamento_value}}} (optional)</param>
        /// <param name="cobrarTarifaAoEmitirNovaVia">{{{status_cartao_request_cobrar_tarifa_ao_emitir_nova_via_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageStatusCartaoResponse>> ListarStatusCartoesUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteDesbloquear = null, int? permiteAtribuirComoBloqueio = null, int? permiteAtribuirComoCancelamento = null, int? cobrarTarifaAoEmitirNovaVia = null)
        {
            
    
            var localVarPath = "/api/status-cartoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (permiteDesbloquear != null) localVarQueryParams.Add("permiteDesbloquear", Configuration.ApiClient.ParameterToString(permiteDesbloquear)); // query parameter
            if (permiteAtribuirComoBloqueio != null) localVarQueryParams.Add("permiteAtribuirComoBloqueio", Configuration.ApiClient.ParameterToString(permiteAtribuirComoBloqueio)); // query parameter
            if (permiteAtribuirComoCancelamento != null) localVarQueryParams.Add("permiteAtribuirComoCancelamento", Configuration.ApiClient.ParameterToString(permiteAtribuirComoCancelamento)); // query parameter
            if (cobrarTarifaAoEmitirNovaVia != null) localVarQueryParams.Add("cobrarTarifaAoEmitirNovaVia", Configuration.ApiClient.ParameterToString(cobrarTarifaAoEmitirNovaVia)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCartoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCartoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageStatusCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusCartaoResponse)));
            
        }
        
        /// <summary>
        /// {{{status_conta_resource_listar}}} {{{status_conta_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{status_conta_request_id_value}}} (optional)</param> 
        /// <param name="nome">{{{status_conta_request_nome_value}}} (optional)</param> 
        /// <param name="permiteAlterarVencimento">{{{status_conta_request_permite_alterar_vencimento_value}}} (optional)</param> 
        /// <param name="permiteAlterarLimite">{{{status_conta_request_permite_alterar_limite_value}}} (optional)</param> 
        /// <param name="permiteEmitirNovaViaCartao">{{{status_conta_request_permite_emitir_nova_via_cartao_value}}} (optional)</param> 
        /// <param name="permiteFazerTransferencia">{{{status_conta_request_permite_fazer_transferencia_value}}} (optional)</param> 
        /// <param name="permiteReceberTransferencia">{{{status_conta_request_permite_receber_transferencia_value}}} (optional)</param> 
        /// <param name="permiteCriarAcordoCobranca">{{{status_conta_request_permite_criar_acordo_cobranca_value}}} (optional)</param> 
        /// <param name="permiteAtribuirComoBloqueio">{{{status_conta_request_permite_atribuir_como_bloqueio_value}}} (optional)</param> 
        /// <param name="permiteDesbloquear">{{{status_conta_request_permite_desbloquear_value}}} (optional)</param> 
        /// <param name="permiteAtribuirComoCancelamento">{{{status_conta_request_permite_atribuir_como_cancelamento_value}}} (optional)</param> 
        /// <returns>PageStatusContaResponse</returns>
        public PageStatusContaResponse ListarUsingGET44 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteAlterarVencimento = null, int? permiteAlterarLimite = null, int? permiteEmitirNovaViaCartao = null, int? permiteFazerTransferencia = null, int? permiteReceberTransferencia = null, int? permiteCriarAcordoCobranca = null, int? permiteAtribuirComoBloqueio = null, int? permiteDesbloquear = null, int? permiteAtribuirComoCancelamento = null)
        {
             ApiResponse<PageStatusContaResponse> localVarResponse = ListarUsingGET44WithHttpInfo(sort, page, limit, id, nome, permiteAlterarVencimento, permiteAlterarLimite, permiteEmitirNovaViaCartao, permiteFazerTransferencia, permiteReceberTransferencia, permiteCriarAcordoCobranca, permiteAtribuirComoBloqueio, permiteDesbloquear, permiteAtribuirComoCancelamento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{status_conta_resource_listar}}} {{{status_conta_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{status_conta_request_id_value}}} (optional)</param> 
        /// <param name="nome">{{{status_conta_request_nome_value}}} (optional)</param> 
        /// <param name="permiteAlterarVencimento">{{{status_conta_request_permite_alterar_vencimento_value}}} (optional)</param> 
        /// <param name="permiteAlterarLimite">{{{status_conta_request_permite_alterar_limite_value}}} (optional)</param> 
        /// <param name="permiteEmitirNovaViaCartao">{{{status_conta_request_permite_emitir_nova_via_cartao_value}}} (optional)</param> 
        /// <param name="permiteFazerTransferencia">{{{status_conta_request_permite_fazer_transferencia_value}}} (optional)</param> 
        /// <param name="permiteReceberTransferencia">{{{status_conta_request_permite_receber_transferencia_value}}} (optional)</param> 
        /// <param name="permiteCriarAcordoCobranca">{{{status_conta_request_permite_criar_acordo_cobranca_value}}} (optional)</param> 
        /// <param name="permiteAtribuirComoBloqueio">{{{status_conta_request_permite_atribuir_como_bloqueio_value}}} (optional)</param> 
        /// <param name="permiteDesbloquear">{{{status_conta_request_permite_desbloquear_value}}} (optional)</param> 
        /// <param name="permiteAtribuirComoCancelamento">{{{status_conta_request_permite_atribuir_como_cancelamento_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageStatusContaResponse</returns>
        public ApiResponse< PageStatusContaResponse > ListarUsingGET44WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteAlterarVencimento = null, int? permiteAlterarLimite = null, int? permiteEmitirNovaViaCartao = null, int? permiteFazerTransferencia = null, int? permiteReceberTransferencia = null, int? permiteCriarAcordoCobranca = null, int? permiteAtribuirComoBloqueio = null, int? permiteDesbloquear = null, int? permiteAtribuirComoCancelamento = null)
        {
            
    
            var localVarPath = "/api/status-contas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (permiteAlterarVencimento != null) localVarQueryParams.Add("permiteAlterarVencimento", Configuration.ApiClient.ParameterToString(permiteAlterarVencimento)); // query parameter
            if (permiteAlterarLimite != null) localVarQueryParams.Add("permiteAlterarLimite", Configuration.ApiClient.ParameterToString(permiteAlterarLimite)); // query parameter
            if (permiteEmitirNovaViaCartao != null) localVarQueryParams.Add("permiteEmitirNovaViaCartao", Configuration.ApiClient.ParameterToString(permiteEmitirNovaViaCartao)); // query parameter
            if (permiteFazerTransferencia != null) localVarQueryParams.Add("permiteFazerTransferencia", Configuration.ApiClient.ParameterToString(permiteFazerTransferencia)); // query parameter
            if (permiteReceberTransferencia != null) localVarQueryParams.Add("permiteReceberTransferencia", Configuration.ApiClient.ParameterToString(permiteReceberTransferencia)); // query parameter
            if (permiteCriarAcordoCobranca != null) localVarQueryParams.Add("permiteCriarAcordoCobranca", Configuration.ApiClient.ParameterToString(permiteCriarAcordoCobranca)); // query parameter
            if (permiteAtribuirComoBloqueio != null) localVarQueryParams.Add("permiteAtribuirComoBloqueio", Configuration.ApiClient.ParameterToString(permiteAtribuirComoBloqueio)); // query parameter
            if (permiteDesbloquear != null) localVarQueryParams.Add("permiteDesbloquear", Configuration.ApiClient.ParameterToString(permiteDesbloquear)); // query parameter
            if (permiteAtribuirComoCancelamento != null) localVarQueryParams.Add("permiteAtribuirComoCancelamento", Configuration.ApiClient.ParameterToString(permiteAtribuirComoCancelamento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET44: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET44: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageStatusContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusContaResponse)));
            
        }

        
        /// <summary>
        /// {{{status_conta_resource_listar}}} {{{status_conta_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{status_conta_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{status_conta_request_nome_value}}} (optional)</param>
        /// <param name="permiteAlterarVencimento">{{{status_conta_request_permite_alterar_vencimento_value}}} (optional)</param>
        /// <param name="permiteAlterarLimite">{{{status_conta_request_permite_alterar_limite_value}}} (optional)</param>
        /// <param name="permiteEmitirNovaViaCartao">{{{status_conta_request_permite_emitir_nova_via_cartao_value}}} (optional)</param>
        /// <param name="permiteFazerTransferencia">{{{status_conta_request_permite_fazer_transferencia_value}}} (optional)</param>
        /// <param name="permiteReceberTransferencia">{{{status_conta_request_permite_receber_transferencia_value}}} (optional)</param>
        /// <param name="permiteCriarAcordoCobranca">{{{status_conta_request_permite_criar_acordo_cobranca_value}}} (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">{{{status_conta_request_permite_atribuir_como_bloqueio_value}}} (optional)</param>
        /// <param name="permiteDesbloquear">{{{status_conta_request_permite_desbloquear_value}}} (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">{{{status_conta_request_permite_atribuir_como_cancelamento_value}}} (optional)</param>
        /// <returns>Task of PageStatusContaResponse</returns>
        public async System.Threading.Tasks.Task<PageStatusContaResponse> ListarUsingGET44Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteAlterarVencimento = null, int? permiteAlterarLimite = null, int? permiteEmitirNovaViaCartao = null, int? permiteFazerTransferencia = null, int? permiteReceberTransferencia = null, int? permiteCriarAcordoCobranca = null, int? permiteAtribuirComoBloqueio = null, int? permiteDesbloquear = null, int? permiteAtribuirComoCancelamento = null)
        {
             ApiResponse<PageStatusContaResponse> localVarResponse = await ListarUsingGET44AsyncWithHttpInfo(sort, page, limit, id, nome, permiteAlterarVencimento, permiteAlterarLimite, permiteEmitirNovaViaCartao, permiteFazerTransferencia, permiteReceberTransferencia, permiteCriarAcordoCobranca, permiteAtribuirComoBloqueio, permiteDesbloquear, permiteAtribuirComoCancelamento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{status_conta_resource_listar}}} {{{status_conta_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{status_conta_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{status_conta_request_nome_value}}} (optional)</param>
        /// <param name="permiteAlterarVencimento">{{{status_conta_request_permite_alterar_vencimento_value}}} (optional)</param>
        /// <param name="permiteAlterarLimite">{{{status_conta_request_permite_alterar_limite_value}}} (optional)</param>
        /// <param name="permiteEmitirNovaViaCartao">{{{status_conta_request_permite_emitir_nova_via_cartao_value}}} (optional)</param>
        /// <param name="permiteFazerTransferencia">{{{status_conta_request_permite_fazer_transferencia_value}}} (optional)</param>
        /// <param name="permiteReceberTransferencia">{{{status_conta_request_permite_receber_transferencia_value}}} (optional)</param>
        /// <param name="permiteCriarAcordoCobranca">{{{status_conta_request_permite_criar_acordo_cobranca_value}}} (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">{{{status_conta_request_permite_atribuir_como_bloqueio_value}}} (optional)</param>
        /// <param name="permiteDesbloquear">{{{status_conta_request_permite_desbloquear_value}}} (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">{{{status_conta_request_permite_atribuir_como_cancelamento_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageStatusContaResponse>> ListarUsingGET44AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteAlterarVencimento = null, int? permiteAlterarLimite = null, int? permiteEmitirNovaViaCartao = null, int? permiteFazerTransferencia = null, int? permiteReceberTransferencia = null, int? permiteCriarAcordoCobranca = null, int? permiteAtribuirComoBloqueio = null, int? permiteDesbloquear = null, int? permiteAtribuirComoCancelamento = null)
        {
            
    
            var localVarPath = "/api/status-contas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (permiteAlterarVencimento != null) localVarQueryParams.Add("permiteAlterarVencimento", Configuration.ApiClient.ParameterToString(permiteAlterarVencimento)); // query parameter
            if (permiteAlterarLimite != null) localVarQueryParams.Add("permiteAlterarLimite", Configuration.ApiClient.ParameterToString(permiteAlterarLimite)); // query parameter
            if (permiteEmitirNovaViaCartao != null) localVarQueryParams.Add("permiteEmitirNovaViaCartao", Configuration.ApiClient.ParameterToString(permiteEmitirNovaViaCartao)); // query parameter
            if (permiteFazerTransferencia != null) localVarQueryParams.Add("permiteFazerTransferencia", Configuration.ApiClient.ParameterToString(permiteFazerTransferencia)); // query parameter
            if (permiteReceberTransferencia != null) localVarQueryParams.Add("permiteReceberTransferencia", Configuration.ApiClient.ParameterToString(permiteReceberTransferencia)); // query parameter
            if (permiteCriarAcordoCobranca != null) localVarQueryParams.Add("permiteCriarAcordoCobranca", Configuration.ApiClient.ParameterToString(permiteCriarAcordoCobranca)); // query parameter
            if (permiteAtribuirComoBloqueio != null) localVarQueryParams.Add("permiteAtribuirComoBloqueio", Configuration.ApiClient.ParameterToString(permiteAtribuirComoBloqueio)); // query parameter
            if (permiteDesbloquear != null) localVarQueryParams.Add("permiteDesbloquear", Configuration.ApiClient.ParameterToString(permiteDesbloquear)); // query parameter
            if (permiteAtribuirComoCancelamento != null) localVarQueryParams.Add("permiteAtribuirComoCancelamento", Configuration.ApiClient.ParameterToString(permiteAtribuirComoCancelamento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET44: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET44: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageStatusContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusContaResponse)));
            
        }
        
        /// <summary>
        /// {{{status_impressao_resource_listar}}} {{{status_impressao_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{status_impressao_request_id_value}}} (optional)</param> 
        /// <param name="nome">{{{status_impressao_request_nome_value}}} (optional)</param> 
        /// <returns>PageStatusImpressaoResponse</returns>
        public PageStatusImpressaoResponse ListarUsingGET45 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageStatusImpressaoResponse> localVarResponse = ListarUsingGET45WithHttpInfo(sort, page, limit, id, nome);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{status_impressao_resource_listar}}} {{{status_impressao_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{status_impressao_request_id_value}}} (optional)</param> 
        /// <param name="nome">{{{status_impressao_request_nome_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageStatusImpressaoResponse</returns>
        public ApiResponse< PageStatusImpressaoResponse > ListarUsingGET45WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
            
    
            var localVarPath = "/api/status-impressoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET45: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET45: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageStatusImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusImpressaoResponse)));
            
        }

        
        /// <summary>
        /// {{{status_impressao_resource_listar}}} {{{status_impressao_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{status_impressao_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{status_impressao_request_nome_value}}} (optional)</param>
        /// <returns>Task of PageStatusImpressaoResponse</returns>
        public async System.Threading.Tasks.Task<PageStatusImpressaoResponse> ListarUsingGET45Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageStatusImpressaoResponse> localVarResponse = await ListarUsingGET45AsyncWithHttpInfo(sort, page, limit, id, nome);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{status_impressao_resource_listar}}} {{{status_impressao_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{status_impressao_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{status_impressao_request_nome_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusImpressaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageStatusImpressaoResponse>> ListarUsingGET45AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
            
    
            var localVarPath = "/api/status-impressoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET45: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET45: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageStatusImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusImpressaoResponse)));
            
        }
        
    }
    
}
