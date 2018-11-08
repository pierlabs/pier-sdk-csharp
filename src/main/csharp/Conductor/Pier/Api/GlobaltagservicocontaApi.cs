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
    public interface IGlobaltagservicocontaApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{servico_conta_resource_aderir_pacote_tarifa}}}
        /// </summary>
        /// <remarks>
        /// {{{servico_conta_resource_aderir_pacote_tarifa_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{servico_conta_resource_aderir_pacote_tarifa_param_id}}}</param>
        /// <param name="adesaoPacoteTarifaPersist">adesaoPacoteTarifaPersist</param>
        /// <returns>AdesaoPacoteTarifaResponse</returns>
        AdesaoPacoteTarifaResponse AderirPacoteTarifaUsingPOST (long? id, AdesaoPacoteTarifaPersistencia adesaoPacoteTarifaPersist);
  
        /// <summary>
        /// {{{servico_conta_resource_aderir_pacote_tarifa}}}
        /// </summary>
        /// <remarks>
        /// {{{servico_conta_resource_aderir_pacote_tarifa_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{servico_conta_resource_aderir_pacote_tarifa_param_id}}}</param>
        /// <param name="adesaoPacoteTarifaPersist">adesaoPacoteTarifaPersist</param>
        /// <returns>ApiResponse of AdesaoPacoteTarifaResponse</returns>
        ApiResponse<AdesaoPacoteTarifaResponse> AderirPacoteTarifaUsingPOSTWithHttpInfo (long? id, AdesaoPacoteTarifaPersistencia adesaoPacoteTarifaPersist);
        
        /// <summary>
        /// {{{conta_resource_ativar_anuidade}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_ativar_anuidade_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_ativar_anuidade_param_id}}}</param>
        /// <param name="idAnuidade">{{{anuidade_request_id_anuidade_value}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="DDD">{{{anuidade_request_d_d_d_value}}} (optional)</param>
        /// <param name="celular">{{{anuidade_request_celular_value}}} (optional)</param>
        /// <param name="idOperadora">{{{anuidade_request_id_operadora_value}}} (optional)</param>
        /// <param name="idOrigemComercial">{{{anuidade_request_id_origem_comercial_value}}} (optional)</param>
        /// <returns>Object</returns>
        Object AtivarAnuidadeUsingPOST (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null);
  
        /// <summary>
        /// {{{conta_resource_ativar_anuidade}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_ativar_anuidade_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_ativar_anuidade_param_id}}}</param>
        /// <param name="idAnuidade">{{{anuidade_request_id_anuidade_value}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="DDD">{{{anuidade_request_d_d_d_value}}} (optional)</param>
        /// <param name="celular">{{{anuidade_request_celular_value}}} (optional)</param>
        /// <param name="idOperadora">{{{anuidade_request_id_operadora_value}}} (optional)</param>
        /// <param name="idOrigemComercial">{{{anuidade_request_id_origem_comercial_value}}} (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> AtivarAnuidadeUsingPOSTWithHttpInfo (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null);
        
        /// <summary>
        /// {{{conta_resource_ativar_envio_fatura_email}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_ativar_envio_fatura_email_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_ativar_envio_fatura_email_param_id}}}</param>
        /// <returns>Object</returns>
        Object AtivarEnvioFaturaEmailUsingPOST (long? id);
  
        /// <summary>
        /// {{{conta_resource_ativar_envio_fatura_email}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_ativar_envio_fatura_email_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_ativar_envio_fatura_email_param_id}}}</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> AtivarEnvioFaturaEmailUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{conta_resource_desativar_envio_fatura_email}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_desativar_envio_fatura_email_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_desativar_envio_fatura_email_param_id}}}</param>
        /// <returns>Object</returns>
        Object DesativarEnvioFaturaEmailUsingPOST (long? id);
  
        /// <summary>
        /// {{{conta_resource_desativar_envio_fatura_email}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_desativar_envio_fatura_email_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_desativar_envio_fatura_email_param_id}}}</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> DesativarEnvioFaturaEmailUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{servico_conta_resource_desativar}}}
        /// </summary>
        /// <remarks>
        /// {{{servico_conta_resource_desativar}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{servico_conta_resource_param_id}}}</param>
        /// <returns>Object</returns>
        Object DesativarUsingDELETE (long? id);
  
        /// <summary>
        /// {{{servico_conta_resource_desativar}}}
        /// </summary>
        /// <remarks>
        /// {{{servico_conta_resource_desativar}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{servico_conta_resource_param_id}}}</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> DesativarUsingDELETEWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{anuidade_resource_listar_anuidades}}}
        /// </summary>
        /// <remarks>
        /// {{{anuidade_resource_listar_anuidades_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>PageAnuidadeResponse</returns>
        PageAnuidadeResponse ListarAnuidadesUsingGET (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{anuidade_resource_listar_anuidades}}}
        /// </summary>
        /// <remarks>
        /// {{{anuidade_resource_listar_anuidades_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of PageAnuidadeResponse</returns>
        ApiResponse<PageAnuidadeResponse> ListarAnuidadesUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{operadora_resource_listar_operadoras_telefonicas}}}
        /// </summary>
        /// <remarks>
        /// {{{operadora_resource_listar_operadoras_telefonicas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>PageOperadoraResponse</returns>
        PageOperadoraResponse ListarOperadorasTelefonicasUsingGET (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{operadora_resource_listar_operadoras_telefonicas}}}
        /// </summary>
        /// <remarks>
        /// {{{operadora_resource_listar_operadoras_telefonicas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of PageOperadoraResponse</returns>
        ApiResponse<PageOperadoraResponse> ListarOperadorasTelefonicasUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{tipo_servico_resource_listar_tipo_servico}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_servico_resource_listar_tipo_servico_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>PageTipoServicoResponse</returns>
        PageTipoServicoResponse ListarTipoServicoUsingGET (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{tipo_servico_resource_listar_tipo_servico}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_servico_resource_listar_tipo_servico_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of PageTipoServicoResponse</returns>
        ApiResponse<PageTipoServicoResponse> ListarTipoServicoUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{servico_conta_resource_listar_servico_conta}}}
        /// </summary>
        /// <remarks>
        /// {{{servico_conta_resource_listar_servico_conta}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idConta">{{{servico_conta_request_id_conta_value}}} (optional)</param>
        /// <param name="idTipoServico">{{{servico_conta_request_id_tipo_servico_value}}} (optional)</param>
        /// <returns>PageServicoContaResponse</returns>
        PageServicoContaResponse ListarUsingGET41 (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idTipoServico = null);
  
        /// <summary>
        /// {{{servico_conta_resource_listar_servico_conta}}}
        /// </summary>
        /// <remarks>
        /// {{{servico_conta_resource_listar_servico_conta}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idConta">{{{servico_conta_request_id_conta_value}}} (optional)</param>
        /// <param name="idTipoServico">{{{servico_conta_request_id_tipo_servico_value}}} (optional)</param>
        /// <returns>ApiResponse of PageServicoContaResponse</returns>
        ApiResponse<PageServicoContaResponse> ListarUsingGET41WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idTipoServico = null);
        
        /// <summary>
        /// {{{servico_conta_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{servico_conta_resource_salvar}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="servicoContaPersist">servicoContaPersist</param>
        /// <returns>Object</returns>
        Object SalvarUsingPOST24 (ServicoContaPersistValue servicoContaPersist);
  
        /// <summary>
        /// {{{servico_conta_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{servico_conta_resource_salvar}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="servicoContaPersist">servicoContaPersist</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> SalvarUsingPOST24WithHttpInfo (ServicoContaPersistValue servicoContaPersist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{servico_conta_resource_aderir_pacote_tarifa}}}
        /// </summary>
        /// <remarks>
        /// {{{servico_conta_resource_aderir_pacote_tarifa_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{servico_conta_resource_aderir_pacote_tarifa_param_id}}}</param>
        /// <param name="adesaoPacoteTarifaPersist">adesaoPacoteTarifaPersist</param>
        /// <returns>Task of AdesaoPacoteTarifaResponse</returns>
        System.Threading.Tasks.Task<AdesaoPacoteTarifaResponse> AderirPacoteTarifaUsingPOSTAsync (long? id, AdesaoPacoteTarifaPersistencia adesaoPacoteTarifaPersist);

        /// <summary>
        /// {{{servico_conta_resource_aderir_pacote_tarifa}}}
        /// </summary>
        /// <remarks>
        /// {{{servico_conta_resource_aderir_pacote_tarifa_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{servico_conta_resource_aderir_pacote_tarifa_param_id}}}</param>
        /// <param name="adesaoPacoteTarifaPersist">adesaoPacoteTarifaPersist</param>
        /// <returns>Task of ApiResponse (AdesaoPacoteTarifaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdesaoPacoteTarifaResponse>> AderirPacoteTarifaUsingPOSTAsyncWithHttpInfo (long? id, AdesaoPacoteTarifaPersistencia adesaoPacoteTarifaPersist);
        
        /// <summary>
        /// {{{conta_resource_ativar_anuidade}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_ativar_anuidade_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_ativar_anuidade_param_id}}}</param>
        /// <param name="idAnuidade">{{{anuidade_request_id_anuidade_value}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="DDD">{{{anuidade_request_d_d_d_value}}} (optional)</param>
        /// <param name="celular">{{{anuidade_request_celular_value}}} (optional)</param>
        /// <param name="idOperadora">{{{anuidade_request_id_operadora_value}}} (optional)</param>
        /// <param name="idOrigemComercial">{{{anuidade_request_id_origem_comercial_value}}} (optional)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> AtivarAnuidadeUsingPOSTAsync (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null);

        /// <summary>
        /// {{{conta_resource_ativar_anuidade}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_ativar_anuidade_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_ativar_anuidade_param_id}}}</param>
        /// <param name="idAnuidade">{{{anuidade_request_id_anuidade_value}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="DDD">{{{anuidade_request_d_d_d_value}}} (optional)</param>
        /// <param name="celular">{{{anuidade_request_celular_value}}} (optional)</param>
        /// <param name="idOperadora">{{{anuidade_request_id_operadora_value}}} (optional)</param>
        /// <param name="idOrigemComercial">{{{anuidade_request_id_origem_comercial_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AtivarAnuidadeUsingPOSTAsyncWithHttpInfo (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null);
        
        /// <summary>
        /// {{{conta_resource_ativar_envio_fatura_email}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_ativar_envio_fatura_email_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_ativar_envio_fatura_email_param_id}}}</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> AtivarEnvioFaturaEmailUsingPOSTAsync (long? id);

        /// <summary>
        /// {{{conta_resource_ativar_envio_fatura_email}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_ativar_envio_fatura_email_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_ativar_envio_fatura_email_param_id}}}</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AtivarEnvioFaturaEmailUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{conta_resource_desativar_envio_fatura_email}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_desativar_envio_fatura_email_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_desativar_envio_fatura_email_param_id}}}</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> DesativarEnvioFaturaEmailUsingPOSTAsync (long? id);

        /// <summary>
        /// {{{conta_resource_desativar_envio_fatura_email}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_desativar_envio_fatura_email_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_desativar_envio_fatura_email_param_id}}}</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DesativarEnvioFaturaEmailUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{servico_conta_resource_desativar}}}
        /// </summary>
        /// <remarks>
        /// {{{servico_conta_resource_desativar}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{servico_conta_resource_param_id}}}</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> DesativarUsingDELETEAsync (long? id);

        /// <summary>
        /// {{{servico_conta_resource_desativar}}}
        /// </summary>
        /// <remarks>
        /// {{{servico_conta_resource_desativar}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{servico_conta_resource_param_id}}}</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DesativarUsingDELETEAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{anuidade_resource_listar_anuidades}}}
        /// </summary>
        /// <remarks>
        /// {{{anuidade_resource_listar_anuidades_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageAnuidadeResponse</returns>
        System.Threading.Tasks.Task<PageAnuidadeResponse> ListarAnuidadesUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{anuidade_resource_listar_anuidades}}}
        /// </summary>
        /// <remarks>
        /// {{{anuidade_resource_listar_anuidades_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageAnuidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageAnuidadeResponse>> ListarAnuidadesUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{operadora_resource_listar_operadoras_telefonicas}}}
        /// </summary>
        /// <remarks>
        /// {{{operadora_resource_listar_operadoras_telefonicas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageOperadoraResponse</returns>
        System.Threading.Tasks.Task<PageOperadoraResponse> ListarOperadorasTelefonicasUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{operadora_resource_listar_operadoras_telefonicas}}}
        /// </summary>
        /// <remarks>
        /// {{{operadora_resource_listar_operadoras_telefonicas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageOperadoraResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageOperadoraResponse>> ListarOperadorasTelefonicasUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{tipo_servico_resource_listar_tipo_servico}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_servico_resource_listar_tipo_servico_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageTipoServicoResponse</returns>
        System.Threading.Tasks.Task<PageTipoServicoResponse> ListarTipoServicoUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{tipo_servico_resource_listar_tipo_servico}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_servico_resource_listar_tipo_servico_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoServicoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoServicoResponse>> ListarTipoServicoUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{servico_conta_resource_listar_servico_conta}}}
        /// </summary>
        /// <remarks>
        /// {{{servico_conta_resource_listar_servico_conta}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idConta">{{{servico_conta_request_id_conta_value}}} (optional)</param>
        /// <param name="idTipoServico">{{{servico_conta_request_id_tipo_servico_value}}} (optional)</param>
        /// <returns>Task of PageServicoContaResponse</returns>
        System.Threading.Tasks.Task<PageServicoContaResponse> ListarUsingGET41Async (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idTipoServico = null);

        /// <summary>
        /// {{{servico_conta_resource_listar_servico_conta}}}
        /// </summary>
        /// <remarks>
        /// {{{servico_conta_resource_listar_servico_conta}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idConta">{{{servico_conta_request_id_conta_value}}} (optional)</param>
        /// <param name="idTipoServico">{{{servico_conta_request_id_tipo_servico_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageServicoContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageServicoContaResponse>> ListarUsingGET41AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idTipoServico = null);
        
        /// <summary>
        /// {{{servico_conta_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{servico_conta_resource_salvar}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="servicoContaPersist">servicoContaPersist</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> SalvarUsingPOST24Async (ServicoContaPersistValue servicoContaPersist);

        /// <summary>
        /// {{{servico_conta_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{servico_conta_resource_salvar}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="servicoContaPersist">servicoContaPersist</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SalvarUsingPOST24AsyncWithHttpInfo (ServicoContaPersistValue servicoContaPersist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltagservicocontaApi : IGlobaltagservicocontaApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagservicocontaApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltagservicocontaApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagservicocontaApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltagservicocontaApi(Configuration configuration = null)
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
        /// {{{servico_conta_resource_aderir_pacote_tarifa}}} {{{servico_conta_resource_aderir_pacote_tarifa_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{servico_conta_resource_aderir_pacote_tarifa_param_id}}}</param> 
        /// <param name="adesaoPacoteTarifaPersist">adesaoPacoteTarifaPersist</param> 
        /// <returns>AdesaoPacoteTarifaResponse</returns>
        public AdesaoPacoteTarifaResponse AderirPacoteTarifaUsingPOST (long? id, AdesaoPacoteTarifaPersistencia adesaoPacoteTarifaPersist)
        {
             ApiResponse<AdesaoPacoteTarifaResponse> localVarResponse = AderirPacoteTarifaUsingPOSTWithHttpInfo(id, adesaoPacoteTarifaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{servico_conta_resource_aderir_pacote_tarifa}}} {{{servico_conta_resource_aderir_pacote_tarifa_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{servico_conta_resource_aderir_pacote_tarifa_param_id}}}</param> 
        /// <param name="adesaoPacoteTarifaPersist">adesaoPacoteTarifaPersist</param> 
        /// <returns>ApiResponse of AdesaoPacoteTarifaResponse</returns>
        public ApiResponse< AdesaoPacoteTarifaResponse > AderirPacoteTarifaUsingPOSTWithHttpInfo (long? id, AdesaoPacoteTarifaPersistencia adesaoPacoteTarifaPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagservicocontaApi->AderirPacoteTarifaUsingPOST");
            
            // verify the required parameter 'adesaoPacoteTarifaPersist' is set
            if (adesaoPacoteTarifaPersist == null)
                throw new ApiException(400, "Missing required parameter 'adesaoPacoteTarifaPersist' when calling GlobaltagservicocontaApi->AderirPacoteTarifaUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/adesoes-pacotes-tarifas";
    
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
            
            
            
            
            if (adesaoPacoteTarifaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(adesaoPacoteTarifaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = adesaoPacoteTarifaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AderirPacoteTarifaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AderirPacoteTarifaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdesaoPacoteTarifaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdesaoPacoteTarifaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdesaoPacoteTarifaResponse)));
            
        }

        
        /// <summary>
        /// {{{servico_conta_resource_aderir_pacote_tarifa}}} {{{servico_conta_resource_aderir_pacote_tarifa_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{servico_conta_resource_aderir_pacote_tarifa_param_id}}}</param>
        /// <param name="adesaoPacoteTarifaPersist">adesaoPacoteTarifaPersist</param>
        /// <returns>Task of AdesaoPacoteTarifaResponse</returns>
        public async System.Threading.Tasks.Task<AdesaoPacoteTarifaResponse> AderirPacoteTarifaUsingPOSTAsync (long? id, AdesaoPacoteTarifaPersistencia adesaoPacoteTarifaPersist)
        {
             ApiResponse<AdesaoPacoteTarifaResponse> localVarResponse = await AderirPacoteTarifaUsingPOSTAsyncWithHttpInfo(id, adesaoPacoteTarifaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{servico_conta_resource_aderir_pacote_tarifa}}} {{{servico_conta_resource_aderir_pacote_tarifa_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{servico_conta_resource_aderir_pacote_tarifa_param_id}}}</param>
        /// <param name="adesaoPacoteTarifaPersist">adesaoPacoteTarifaPersist</param>
        /// <returns>Task of ApiResponse (AdesaoPacoteTarifaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdesaoPacoteTarifaResponse>> AderirPacoteTarifaUsingPOSTAsyncWithHttpInfo (long? id, AdesaoPacoteTarifaPersistencia adesaoPacoteTarifaPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AderirPacoteTarifaUsingPOST");
            // verify the required parameter 'adesaoPacoteTarifaPersist' is set
            if (adesaoPacoteTarifaPersist == null) throw new ApiException(400, "Missing required parameter 'adesaoPacoteTarifaPersist' when calling AderirPacoteTarifaUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/adesoes-pacotes-tarifas";
    
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
            
            
            
            
            if (adesaoPacoteTarifaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(adesaoPacoteTarifaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = adesaoPacoteTarifaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AderirPacoteTarifaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AderirPacoteTarifaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdesaoPacoteTarifaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdesaoPacoteTarifaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdesaoPacoteTarifaResponse)));
            
        }
        
        /// <summary>
        /// {{{conta_resource_ativar_anuidade}}} {{{conta_resource_ativar_anuidade_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_ativar_anuidade_param_id}}}</param> 
        /// <param name="idAnuidade">{{{anuidade_request_id_anuidade_value}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="DDD">{{{anuidade_request_d_d_d_value}}} (optional)</param> 
        /// <param name="celular">{{{anuidade_request_celular_value}}} (optional)</param> 
        /// <param name="idOperadora">{{{anuidade_request_id_operadora_value}}} (optional)</param> 
        /// <param name="idOrigemComercial">{{{anuidade_request_id_origem_comercial_value}}} (optional)</param> 
        /// <returns>Object</returns>
        public Object AtivarAnuidadeUsingPOST (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null)
        {
             ApiResponse<Object> localVarResponse = AtivarAnuidadeUsingPOSTWithHttpInfo(id, idAnuidade, sort, page, limit, DDD, celular, idOperadora, idOrigemComercial);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_resource_ativar_anuidade}}} {{{conta_resource_ativar_anuidade_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_ativar_anuidade_param_id}}}</param> 
        /// <param name="idAnuidade">{{{anuidade_request_id_anuidade_value}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="DDD">{{{anuidade_request_d_d_d_value}}} (optional)</param> 
        /// <param name="celular">{{{anuidade_request_celular_value}}} (optional)</param> 
        /// <param name="idOperadora">{{{anuidade_request_id_operadora_value}}} (optional)</param> 
        /// <param name="idOrigemComercial">{{{anuidade_request_id_origem_comercial_value}}} (optional)</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > AtivarAnuidadeUsingPOSTWithHttpInfo (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagservicocontaApi->AtivarAnuidadeUsingPOST");
            
            // verify the required parameter 'idAnuidade' is set
            if (idAnuidade == null)
                throw new ApiException(400, "Missing required parameter 'idAnuidade' when calling GlobaltagservicocontaApi->AtivarAnuidadeUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/atribuir-anuidade";
    
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
            if (idAnuidade != null) localVarQueryParams.Add("idAnuidade", Configuration.ApiClient.ParameterToString(idAnuidade)); // query parameter
            if (DDD != null) localVarQueryParams.Add("DDD", Configuration.ApiClient.ParameterToString(DDD)); // query parameter
            if (celular != null) localVarQueryParams.Add("celular", Configuration.ApiClient.ParameterToString(celular)); // query parameter
            if (idOperadora != null) localVarQueryParams.Add("idOperadora", Configuration.ApiClient.ParameterToString(idOperadora)); // query parameter
            if (idOrigemComercial != null) localVarQueryParams.Add("idOrigemComercial", Configuration.ApiClient.ParameterToString(idOrigemComercial)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtivarAnuidadeUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarAnuidadeUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// {{{conta_resource_ativar_anuidade}}} {{{conta_resource_ativar_anuidade_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_ativar_anuidade_param_id}}}</param>
        /// <param name="idAnuidade">{{{anuidade_request_id_anuidade_value}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="DDD">{{{anuidade_request_d_d_d_value}}} (optional)</param>
        /// <param name="celular">{{{anuidade_request_celular_value}}} (optional)</param>
        /// <param name="idOperadora">{{{anuidade_request_id_operadora_value}}} (optional)</param>
        /// <param name="idOrigemComercial">{{{anuidade_request_id_origem_comercial_value}}} (optional)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> AtivarAnuidadeUsingPOSTAsync (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null)
        {
             ApiResponse<Object> localVarResponse = await AtivarAnuidadeUsingPOSTAsyncWithHttpInfo(id, idAnuidade, sort, page, limit, DDD, celular, idOperadora, idOrigemComercial);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_resource_ativar_anuidade}}} {{{conta_resource_ativar_anuidade_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_ativar_anuidade_param_id}}}</param>
        /// <param name="idAnuidade">{{{anuidade_request_id_anuidade_value}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="DDD">{{{anuidade_request_d_d_d_value}}} (optional)</param>
        /// <param name="celular">{{{anuidade_request_celular_value}}} (optional)</param>
        /// <param name="idOperadora">{{{anuidade_request_id_operadora_value}}} (optional)</param>
        /// <param name="idOrigemComercial">{{{anuidade_request_id_origem_comercial_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AtivarAnuidadeUsingPOSTAsyncWithHttpInfo (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtivarAnuidadeUsingPOST");
            // verify the required parameter 'idAnuidade' is set
            if (idAnuidade == null) throw new ApiException(400, "Missing required parameter 'idAnuidade' when calling AtivarAnuidadeUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/atribuir-anuidade";
    
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
            if (idAnuidade != null) localVarQueryParams.Add("idAnuidade", Configuration.ApiClient.ParameterToString(idAnuidade)); // query parameter
            if (DDD != null) localVarQueryParams.Add("DDD", Configuration.ApiClient.ParameterToString(DDD)); // query parameter
            if (celular != null) localVarQueryParams.Add("celular", Configuration.ApiClient.ParameterToString(celular)); // query parameter
            if (idOperadora != null) localVarQueryParams.Add("idOperadora", Configuration.ApiClient.ParameterToString(idOperadora)); // query parameter
            if (idOrigemComercial != null) localVarQueryParams.Add("idOrigemComercial", Configuration.ApiClient.ParameterToString(idOrigemComercial)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtivarAnuidadeUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarAnuidadeUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// {{{conta_resource_ativar_envio_fatura_email}}} {{{conta_resource_ativar_envio_fatura_email_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_ativar_envio_fatura_email_param_id}}}</param> 
        /// <returns>Object</returns>
        public Object AtivarEnvioFaturaEmailUsingPOST (long? id)
        {
             ApiResponse<Object> localVarResponse = AtivarEnvioFaturaEmailUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_resource_ativar_envio_fatura_email}}} {{{conta_resource_ativar_envio_fatura_email_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_ativar_envio_fatura_email_param_id}}}</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > AtivarEnvioFaturaEmailUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagservicocontaApi->AtivarEnvioFaturaEmailUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/ativar-fatura-email";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtivarEnvioFaturaEmailUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarEnvioFaturaEmailUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// {{{conta_resource_ativar_envio_fatura_email}}} {{{conta_resource_ativar_envio_fatura_email_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_ativar_envio_fatura_email_param_id}}}</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> AtivarEnvioFaturaEmailUsingPOSTAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await AtivarEnvioFaturaEmailUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_resource_ativar_envio_fatura_email}}} {{{conta_resource_ativar_envio_fatura_email_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_ativar_envio_fatura_email_param_id}}}</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AtivarEnvioFaturaEmailUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtivarEnvioFaturaEmailUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/ativar-fatura-email";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtivarEnvioFaturaEmailUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarEnvioFaturaEmailUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// {{{conta_resource_desativar_envio_fatura_email}}} {{{conta_resource_desativar_envio_fatura_email_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_desativar_envio_fatura_email_param_id}}}</param> 
        /// <returns>Object</returns>
        public Object DesativarEnvioFaturaEmailUsingPOST (long? id)
        {
             ApiResponse<Object> localVarResponse = DesativarEnvioFaturaEmailUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_resource_desativar_envio_fatura_email}}} {{{conta_resource_desativar_envio_fatura_email_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_desativar_envio_fatura_email_param_id}}}</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > DesativarEnvioFaturaEmailUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagservicocontaApi->DesativarEnvioFaturaEmailUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/desativar-fatura-email";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesativarEnvioFaturaEmailUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarEnvioFaturaEmailUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// {{{conta_resource_desativar_envio_fatura_email}}} {{{conta_resource_desativar_envio_fatura_email_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_desativar_envio_fatura_email_param_id}}}</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> DesativarEnvioFaturaEmailUsingPOSTAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await DesativarEnvioFaturaEmailUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_resource_desativar_envio_fatura_email}}} {{{conta_resource_desativar_envio_fatura_email_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_desativar_envio_fatura_email_param_id}}}</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DesativarEnvioFaturaEmailUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesativarEnvioFaturaEmailUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/desativar-fatura-email";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesativarEnvioFaturaEmailUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarEnvioFaturaEmailUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// {{{servico_conta_resource_desativar}}} {{{servico_conta_resource_desativar}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{servico_conta_resource_param_id}}}</param> 
        /// <returns>Object</returns>
        public Object DesativarUsingDELETE (long? id)
        {
             ApiResponse<Object> localVarResponse = DesativarUsingDELETEWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{servico_conta_resource_desativar}}} {{{servico_conta_resource_desativar}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{servico_conta_resource_param_id}}}</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > DesativarUsingDELETEWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagservicocontaApi->DesativarUsingDELETE");
            
    
            var localVarPath = "/api/contas/servicos/{id}";
    
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesativarUsingDELETE: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarUsingDELETE: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// {{{servico_conta_resource_desativar}}} {{{servico_conta_resource_desativar}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{servico_conta_resource_param_id}}}</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> DesativarUsingDELETEAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await DesativarUsingDELETEAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{servico_conta_resource_desativar}}} {{{servico_conta_resource_desativar}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{servico_conta_resource_param_id}}}</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DesativarUsingDELETEAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesativarUsingDELETE");
            
    
            var localVarPath = "/api/contas/servicos/{id}";
    
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesativarUsingDELETE: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarUsingDELETE: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// {{{anuidade_resource_listar_anuidades}}} {{{anuidade_resource_listar_anuidades_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>PageAnuidadeResponse</returns>
        public PageAnuidadeResponse ListarAnuidadesUsingGET (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageAnuidadeResponse> localVarResponse = ListarAnuidadesUsingGETWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{anuidade_resource_listar_anuidades}}} {{{anuidade_resource_listar_anuidades_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>ApiResponse of PageAnuidadeResponse</returns>
        public ApiResponse< PageAnuidadeResponse > ListarAnuidadesUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/anuidades";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarAnuidadesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAnuidadesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageAnuidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAnuidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAnuidadeResponse)));
            
        }

        
        /// <summary>
        /// {{{anuidade_resource_listar_anuidades}}} {{{anuidade_resource_listar_anuidades_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageAnuidadeResponse</returns>
        public async System.Threading.Tasks.Task<PageAnuidadeResponse> ListarAnuidadesUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageAnuidadeResponse> localVarResponse = await ListarAnuidadesUsingGETAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{anuidade_resource_listar_anuidades}}} {{{anuidade_resource_listar_anuidades_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageAnuidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageAnuidadeResponse>> ListarAnuidadesUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/anuidades";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarAnuidadesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAnuidadesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageAnuidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAnuidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAnuidadeResponse)));
            
        }
        
        /// <summary>
        /// {{{operadora_resource_listar_operadoras_telefonicas}}} {{{operadora_resource_listar_operadoras_telefonicas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>PageOperadoraResponse</returns>
        public PageOperadoraResponse ListarOperadorasTelefonicasUsingGET (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageOperadoraResponse> localVarResponse = ListarOperadorasTelefonicasUsingGETWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{operadora_resource_listar_operadoras_telefonicas}}} {{{operadora_resource_listar_operadoras_telefonicas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>ApiResponse of PageOperadoraResponse</returns>
        public ApiResponse< PageOperadoraResponse > ListarOperadorasTelefonicasUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/operadoras-telefonicas";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarOperadorasTelefonicasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarOperadorasTelefonicasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageOperadoraResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOperadoraResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOperadoraResponse)));
            
        }

        
        /// <summary>
        /// {{{operadora_resource_listar_operadoras_telefonicas}}} {{{operadora_resource_listar_operadoras_telefonicas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageOperadoraResponse</returns>
        public async System.Threading.Tasks.Task<PageOperadoraResponse> ListarOperadorasTelefonicasUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageOperadoraResponse> localVarResponse = await ListarOperadorasTelefonicasUsingGETAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{operadora_resource_listar_operadoras_telefonicas}}} {{{operadora_resource_listar_operadoras_telefonicas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageOperadoraResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageOperadoraResponse>> ListarOperadorasTelefonicasUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/operadoras-telefonicas";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarOperadorasTelefonicasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarOperadorasTelefonicasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageOperadoraResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOperadoraResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOperadoraResponse)));
            
        }
        
        /// <summary>
        /// {{{tipo_servico_resource_listar_tipo_servico}}} {{{tipo_servico_resource_listar_tipo_servico_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>PageTipoServicoResponse</returns>
        public PageTipoServicoResponse ListarTipoServicoUsingGET (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTipoServicoResponse> localVarResponse = ListarTipoServicoUsingGETWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{tipo_servico_resource_listar_tipo_servico}}} {{{tipo_servico_resource_listar_tipo_servico_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>ApiResponse of PageTipoServicoResponse</returns>
        public ApiResponse< PageTipoServicoResponse > ListarTipoServicoUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/tipos-servicos";
    
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
                "*/*"
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTipoServicoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTipoServicoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoServicoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoServicoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoServicoResponse)));
            
        }

        
        /// <summary>
        /// {{{tipo_servico_resource_listar_tipo_servico}}} {{{tipo_servico_resource_listar_tipo_servico_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageTipoServicoResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoServicoResponse> ListarTipoServicoUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTipoServicoResponse> localVarResponse = await ListarTipoServicoUsingGETAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{tipo_servico_resource_listar_tipo_servico}}} {{{tipo_servico_resource_listar_tipo_servico_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoServicoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoServicoResponse>> ListarTipoServicoUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/tipos-servicos";
    
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
                "*/*"
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTipoServicoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTipoServicoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoServicoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoServicoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoServicoResponse)));
            
        }
        
        /// <summary>
        /// {{{servico_conta_resource_listar_servico_conta}}} {{{servico_conta_resource_listar_servico_conta}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idConta">{{{servico_conta_request_id_conta_value}}} (optional)</param> 
        /// <param name="idTipoServico">{{{servico_conta_request_id_tipo_servico_value}}} (optional)</param> 
        /// <returns>PageServicoContaResponse</returns>
        public PageServicoContaResponse ListarUsingGET41 (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idTipoServico = null)
        {
             ApiResponse<PageServicoContaResponse> localVarResponse = ListarUsingGET41WithHttpInfo(sort, page, limit, idConta, idTipoServico);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{servico_conta_resource_listar_servico_conta}}} {{{servico_conta_resource_listar_servico_conta}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idConta">{{{servico_conta_request_id_conta_value}}} (optional)</param> 
        /// <param name="idTipoServico">{{{servico_conta_request_id_tipo_servico_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageServicoContaResponse</returns>
        public ApiResponse< PageServicoContaResponse > ListarUsingGET41WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idTipoServico = null)
        {
            
    
            var localVarPath = "/api/contas/servicos";
    
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
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (idTipoServico != null) localVarQueryParams.Add("idTipoServico", Configuration.ApiClient.ParameterToString(idTipoServico)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET41: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET41: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageServicoContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageServicoContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageServicoContaResponse)));
            
        }

        
        /// <summary>
        /// {{{servico_conta_resource_listar_servico_conta}}} {{{servico_conta_resource_listar_servico_conta}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idConta">{{{servico_conta_request_id_conta_value}}} (optional)</param>
        /// <param name="idTipoServico">{{{servico_conta_request_id_tipo_servico_value}}} (optional)</param>
        /// <returns>Task of PageServicoContaResponse</returns>
        public async System.Threading.Tasks.Task<PageServicoContaResponse> ListarUsingGET41Async (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idTipoServico = null)
        {
             ApiResponse<PageServicoContaResponse> localVarResponse = await ListarUsingGET41AsyncWithHttpInfo(sort, page, limit, idConta, idTipoServico);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{servico_conta_resource_listar_servico_conta}}} {{{servico_conta_resource_listar_servico_conta}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idConta">{{{servico_conta_request_id_conta_value}}} (optional)</param>
        /// <param name="idTipoServico">{{{servico_conta_request_id_tipo_servico_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageServicoContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageServicoContaResponse>> ListarUsingGET41AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idTipoServico = null)
        {
            
    
            var localVarPath = "/api/contas/servicos";
    
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
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (idTipoServico != null) localVarQueryParams.Add("idTipoServico", Configuration.ApiClient.ParameterToString(idTipoServico)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET41: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET41: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageServicoContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageServicoContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageServicoContaResponse)));
            
        }
        
        /// <summary>
        /// {{{servico_conta_resource_salvar}}} {{{servico_conta_resource_salvar}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="servicoContaPersist">servicoContaPersist</param> 
        /// <returns>Object</returns>
        public Object SalvarUsingPOST24 (ServicoContaPersistValue servicoContaPersist)
        {
             ApiResponse<Object> localVarResponse = SalvarUsingPOST24WithHttpInfo(servicoContaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{servico_conta_resource_salvar}}} {{{servico_conta_resource_salvar}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="servicoContaPersist">servicoContaPersist</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > SalvarUsingPOST24WithHttpInfo (ServicoContaPersistValue servicoContaPersist)
        {
            
            // verify the required parameter 'servicoContaPersist' is set
            if (servicoContaPersist == null)
                throw new ApiException(400, "Missing required parameter 'servicoContaPersist' when calling GlobaltagservicocontaApi->SalvarUsingPOST24");
            
    
            var localVarPath = "/api/contas/servicos";
    
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
            
            
            
            
            if (servicoContaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(servicoContaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = servicoContaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST24: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST24: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// {{{servico_conta_resource_salvar}}} {{{servico_conta_resource_salvar}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="servicoContaPersist">servicoContaPersist</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> SalvarUsingPOST24Async (ServicoContaPersistValue servicoContaPersist)
        {
             ApiResponse<Object> localVarResponse = await SalvarUsingPOST24AsyncWithHttpInfo(servicoContaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{servico_conta_resource_salvar}}} {{{servico_conta_resource_salvar}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="servicoContaPersist">servicoContaPersist</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> SalvarUsingPOST24AsyncWithHttpInfo (ServicoContaPersistValue servicoContaPersist)
        {
            // verify the required parameter 'servicoContaPersist' is set
            if (servicoContaPersist == null) throw new ApiException(400, "Missing required parameter 'servicoContaPersist' when calling SalvarUsingPOST24");
            
    
            var localVarPath = "/api/contas/servicos";
    
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
            
            
            
            
            if (servicoContaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(servicoContaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = servicoContaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST24: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST24: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
    }
    
}
