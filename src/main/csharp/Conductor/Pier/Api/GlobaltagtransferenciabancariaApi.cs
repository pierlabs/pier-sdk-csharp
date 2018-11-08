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
    public interface IGlobaltagtransferenciabancariaApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_atualizar_taxas_juros_contas}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_atualizar_taxas_juros_contas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_salvar_taxas_juros_contas_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>TaxaJurosContaResponse</returns>
        TaxaJurosContaResponse AtualizarTaxasJurosContasUsingPUT (long? id, TaxaJurosContaPersistValue update);
  
        /// <summary>
        /// {{{transferencia_bancaria_resource_atualizar_taxas_juros_contas}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_atualizar_taxas_juros_contas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_salvar_taxas_juros_contas_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of TaxaJurosContaResponse</returns>
        ApiResponse<TaxaJurosContaResponse> AtualizarTaxasJurosContasUsingPUTWithHttpInfo (long? id, TaxaJurosContaPersistValue update);
        
        /// <summary>
        /// {{{conta_bancaria_resource_atualizar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_bancaria_resource_atualizar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_bancaria_resource_atualizar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>ContaBancariaPortadorResponse</returns>
        ContaBancariaPortadorResponse AtualizarUsingPUT (long? id, ContaBancariaPortadorUpdateValue update);
  
        /// <summary>
        /// {{{conta_bancaria_resource_atualizar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_bancaria_resource_atualizar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_bancaria_resource_atualizar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of ContaBancariaPortadorResponse</returns>
        ApiResponse<ContaBancariaPortadorResponse> AtualizarUsingPUTWithHttpInfo (long? id, ContaBancariaPortadorUpdateValue update);
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_cancelar_transferencia_credito_conta_bancaria}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_cancelar_transferencia_credito_conta_bancaria_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">{{{transferencia_bancaria_resource_cancelar_transferencia_credito_conta_bancaria_param_id_transferencia}}}</param>
        /// <returns>string</returns>
        string CancelarTransferenciaCreditoContaBancariaUsingPOST (long? idTransferencia);
  
        /// <summary>
        /// {{{transferencia_bancaria_resource_cancelar_transferencia_credito_conta_bancaria}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_cancelar_transferencia_credito_conta_bancaria_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">{{{transferencia_bancaria_resource_cancelar_transferencia_credito_conta_bancaria_param_id_transferencia}}}</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> CancelarTransferenciaCreditoContaBancariaUsingPOSTWithHttpInfo (long? idTransferencia);
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_confirmar_transferencia_credito_conta_bancaria}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_confirmar_transferencia_credito_conta_bancaria_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">{{{transferencia_bancaria_resource_confirmar_transferencia_credito_conta_bancaria_param_id_transferencia}}}</param>
        /// <returns>string</returns>
        string ConfirmarTransferenciaCreditoContaBancariaUsingPOST (long? idTransferencia);
  
        /// <summary>
        /// {{{transferencia_bancaria_resource_confirmar_transferencia_credito_conta_bancaria}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_confirmar_transferencia_credito_conta_bancaria_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">{{{transferencia_bancaria_resource_confirmar_transferencia_credito_conta_bancaria_param_id_transferencia}}}</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ConfirmarTransferenciaCreditoContaBancariaUsingPOSTWithHttpInfo (long? idTransferencia);
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_consultar_taxas_juros_contas}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_consultar_taxas_juros_contas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_salvar_taxas_juros_contas_param_id}}}</param>
        /// <param name="numeroMesesCarencia">numeroMesesCarencia</param>
        /// <returns>TaxaJurosContaResponse</returns>
        TaxaJurosContaResponse ConsultarTaxasJurosContasUsingGET (long? id, int? numeroMesesCarencia);
  
        /// <summary>
        /// {{{transferencia_bancaria_resource_consultar_taxas_juros_contas}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_consultar_taxas_juros_contas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_salvar_taxas_juros_contas_param_id}}}</param>
        /// <param name="numeroMesesCarencia">numeroMesesCarencia</param>
        /// <returns>ApiResponse of TaxaJurosContaResponse</returns>
        ApiResponse<TaxaJurosContaResponse> ConsultarTaxasJurosContasUsingGETWithHttpInfo (long? id, int? numeroMesesCarencia);
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_consultar_transferencia_bancaria}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_consultar_transferencia_bancaria_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">{{{transferencia_bancaria_resource_consultar_transferencia_bancaria_param_id_transferencia}}}</param>
        /// <returns>TransferenciaCreditoContaBancariaResponse</returns>
        TransferenciaCreditoContaBancariaResponse ConsultarTransferenciaBancariaUsingGET (long? idTransferencia);
  
        /// <summary>
        /// {{{transferencia_bancaria_resource_consultar_transferencia_bancaria}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_consultar_transferencia_bancaria_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">{{{transferencia_bancaria_resource_consultar_transferencia_bancaria_param_id_transferencia}}}</param>
        /// <returns>ApiResponse of TransferenciaCreditoContaBancariaResponse</returns>
        ApiResponse<TransferenciaCreditoContaBancariaResponse> ConsultarTransferenciaBancariaUsingGETWithHttpInfo (long? idTransferencia);
        
        /// <summary>
        /// {{{conta_bancaria_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_bancaria_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_bancaria_resource_consultar_param_id}}}</param>
        /// <returns>ContaBancariaPortadorResponse</returns>
        ContaBancariaPortadorResponse ConsultarUsingGET11 (long? id);
  
        /// <summary>
        /// {{{conta_bancaria_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_bancaria_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_bancaria_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of ContaBancariaPortadorResponse</returns>
        ApiResponse<ContaBancariaPortadorResponse> ConsultarUsingGET11WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_consultar_param_id}}}</param>
        /// <param name="idTransferencia">{{{transferencia_bancaria_resource_consultar_param_id_evento}}}</param>
        /// <param name="idContaBancariaDestino">{{{transferencia_bancaria_resource_consultar_param_id_conta_portador}}} (optional)</param>
        /// <returns>TransferenciaBancariaResponse</returns>
        TransferenciaBancariaResponse ConsultarUsingGET46 (long? id, long? idTransferencia, long? idContaBancariaDestino = null);
  
        /// <summary>
        /// {{{transferencia_bancaria_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_consultar_param_id}}}</param>
        /// <param name="idTransferencia">{{{transferencia_bancaria_resource_consultar_param_id_evento}}}</param>
        /// <param name="idContaBancariaDestino">{{{transferencia_bancaria_resource_consultar_param_id_conta_portador}}} (optional)</param>
        /// <returns>ApiResponse of TransferenciaBancariaResponse</returns>
        ApiResponse<TransferenciaBancariaResponse> ConsultarUsingGET46WithHttpInfo (long? id, long? idTransferencia, long? idContaBancariaDestino = null);
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_listar_transferencia_bancaria}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_listar_transferencia_bancaria_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idConta">{{{transferencia_credito_conta_bancaria_request_id_conta_value}}} (optional)</param>
        /// <param name="dataSolicitacaoInicial">{{{transferencia_credito_conta_bancaria_request_data_solicitacao_inicial_value}}} (optional)</param>
        /// <param name="dataSolicitacaoFinal">{{{transferencia_credito_conta_bancaria_request_data_solicitacao_final_value}}} (optional)</param>
        /// <param name="status">{{{transferencia_credito_conta_bancaria_request_status_value}}} (optional)</param>
        /// <returns>PageTransferenciaCreditoContaBancariaResponse</returns>
        PageTransferenciaCreditoContaBancariaResponse ListarTransferenciaBancariaUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataSolicitacaoInicial = null, string dataSolicitacaoFinal = null, int? status = null);
  
        /// <summary>
        /// {{{transferencia_bancaria_resource_listar_transferencia_bancaria}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_listar_transferencia_bancaria_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idConta">{{{transferencia_credito_conta_bancaria_request_id_conta_value}}} (optional)</param>
        /// <param name="dataSolicitacaoInicial">{{{transferencia_credito_conta_bancaria_request_data_solicitacao_inicial_value}}} (optional)</param>
        /// <param name="dataSolicitacaoFinal">{{{transferencia_credito_conta_bancaria_request_data_solicitacao_final_value}}} (optional)</param>
        /// <param name="status">{{{transferencia_credito_conta_bancaria_request_status_value}}} (optional)</param>
        /// <returns>ApiResponse of PageTransferenciaCreditoContaBancariaResponse</returns>
        ApiResponse<PageTransferenciaCreditoContaBancariaResponse> ListarTransferenciaBancariaUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataSolicitacaoInicial = null, string dataSolicitacaoFinal = null, int? status = null);
        
        /// <summary>
        /// {{{conta_bancaria_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_bancaria_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{conta_bancaria_portador_listar_request_id_conta_value}}} (optional)</param>
        /// <param name="nomeAgencia">{{{conta_bancaria_portador_listar_request_nome_agencia_value}}} (optional)</param>
        /// <param name="banco">{{{conta_bancaria_portador_listar_request_codigo_banco_value}}} (optional)</param>
        /// <param name="numeroAgencia">{{{conta_bancaria_portador_listar_request_numero_agencia_value}}} (optional)</param>
        /// <param name="numeroConta">{{{conta_bancaria_portador_listar_request_numero_conta_value}}} (optional)</param>
        /// <param name="flagAtivo">{{{conta_bancaria_portador_listar_request_flag_ativo_value}}} (optional)</param>
        /// <param name="flagContaOrigemDoc">{{{conta_bancaria_portador_listar_request_flag_conta_origem_doc_value}}} (optional)</param>
        /// <param name="idPessoaFisica">{{{conta_bancaria_portador_listar_request_id_pessoa_fisica_value}}} (optional)</param>
        /// <param name="favorecido">{{{conta_bancaria_portador_listar_request_favorecido_value}}} (optional)</param>
        /// <param name="numeroReceiraFederal">{{{conta_bancaria_portador_listar_request_numero_receira_federal_value}}} (optional)</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>PageContaBancariaPortadorResponse</returns>
        PageContaBancariaPortadorResponse ListarUsingGET13 (long? idConta = null, string nomeAgencia = null, long? banco = null, string numeroAgencia = null, string numeroConta = null, int? flagAtivo = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{conta_bancaria_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_bancaria_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{conta_bancaria_portador_listar_request_id_conta_value}}} (optional)</param>
        /// <param name="nomeAgencia">{{{conta_bancaria_portador_listar_request_nome_agencia_value}}} (optional)</param>
        /// <param name="banco">{{{conta_bancaria_portador_listar_request_codigo_banco_value}}} (optional)</param>
        /// <param name="numeroAgencia">{{{conta_bancaria_portador_listar_request_numero_agencia_value}}} (optional)</param>
        /// <param name="numeroConta">{{{conta_bancaria_portador_listar_request_numero_conta_value}}} (optional)</param>
        /// <param name="flagAtivo">{{{conta_bancaria_portador_listar_request_flag_ativo_value}}} (optional)</param>
        /// <param name="flagContaOrigemDoc">{{{conta_bancaria_portador_listar_request_flag_conta_origem_doc_value}}} (optional)</param>
        /// <param name="idPessoaFisica">{{{conta_bancaria_portador_listar_request_id_pessoa_fisica_value}}} (optional)</param>
        /// <param name="favorecido">{{{conta_bancaria_portador_listar_request_favorecido_value}}} (optional)</param>
        /// <param name="numeroReceiraFederal">{{{conta_bancaria_portador_listar_request_numero_receira_federal_value}}} (optional)</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of PageContaBancariaPortadorResponse</returns>
        ApiResponse<PageContaBancariaPortadorResponse> ListarUsingGET13WithHttpInfo (long? idConta = null, string nomeAgencia = null, long? banco = null, string numeroAgencia = null, string numeroConta = null, int? flagAtivo = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_listar_param_id}}}</param>
        /// <param name="idContaBancariaDestino">{{{transferencia_bancaria_resource_listar_param_id_conta_portador}}} (optional)</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>PageTransferenciaBancariaResponse</returns>
        PageTransferenciaBancariaResponse ListarUsingGET56 (long? id, long? idContaBancariaDestino = null, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{transferencia_bancaria_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_listar_param_id}}}</param>
        /// <param name="idContaBancariaDestino">{{{transferencia_bancaria_resource_listar_param_id_conta_portador}}} (optional)</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of PageTransferenciaBancariaResponse</returns>
        ApiResponse<PageTransferenciaBancariaResponse> ListarUsingGET56WithHttpInfo (long? id, long? idContaBancariaDestino = null, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_salvar_taxas_juros_contas}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_salvar_taxas_juros_contas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_salvar_taxas_juros_contas_param_id}}}</param>
        /// <param name="persist">persist</param>
        /// <returns>TaxaJurosContaResponse</returns>
        TaxaJurosContaResponse SalvarTaxasJurosContasUsingPOST (long? id, TaxaJurosContaPersistValue persist);
  
        /// <summary>
        /// {{{transferencia_bancaria_resource_salvar_taxas_juros_contas}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_salvar_taxas_juros_contas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_salvar_taxas_juros_contas_param_id}}}</param>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of TaxaJurosContaResponse</returns>
        ApiResponse<TaxaJurosContaResponse> SalvarTaxasJurosContasUsingPOSTWithHttpInfo (long? id, TaxaJurosContaPersistValue persist);
        
        /// <summary>
        /// {{{conta_bancaria_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_bancaria_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ContaBancariaPortadorResponse</returns>
        ContaBancariaPortadorResponse SalvarUsingPOST6 (ContaBancariaPortadorPersistValue persist);
  
        /// <summary>
        /// {{{conta_bancaria_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_bancaria_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of ContaBancariaPortadorResponse</returns>
        ApiResponse<ContaBancariaPortadorResponse> SalvarUsingPOST6WithHttpInfo (ContaBancariaPortadorPersistValue persist);
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_simular_transferencia_bancaria}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_simular_transferencia_bancaria_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>PlanoParcelamentoTransferenciaCreditoContaBancariaResponse</returns>
        PlanoParcelamentoTransferenciaCreditoContaBancariaResponse SimularTransferenciaBancariaUsingPOST (PlanoParcelamentoTransferenciaCreditoContaBancariaRequest request);
  
        /// <summary>
        /// {{{transferencia_bancaria_resource_simular_transferencia_bancaria}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_simular_transferencia_bancaria_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of PlanoParcelamentoTransferenciaCreditoContaBancariaResponse</returns>
        ApiResponse<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse> SimularTransferenciaBancariaUsingPOSTWithHttpInfo (PlanoParcelamentoTransferenciaCreditoContaBancariaRequest request);
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_transferencia_credito_conta_bancaria}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_transferencia_credito_conta_bancaria_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>TransferenciaCreditoContaBancariaResponse</returns>
        TransferenciaCreditoContaBancariaResponse TransferenciaCreditoContaBancariaUsingPOST (TransferenciaCreditoContaBancariaPersistValue persist);
  
        /// <summary>
        /// {{{transferencia_bancaria_resource_transferencia_credito_conta_bancaria}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_transferencia_credito_conta_bancaria_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of TransferenciaCreditoContaBancariaResponse</returns>
        ApiResponse<TransferenciaCreditoContaBancariaResponse> TransferenciaCreditoContaBancariaUsingPOSTWithHttpInfo (TransferenciaCreditoContaBancariaPersistValue persist);
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_transferir}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_transferir_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_transferir_param_id}}}</param>
        /// <param name="transferenciaBancariaPersist">transferenciaBancariaPersist</param>
        /// <returns>TransferenciaBancariaResponse</returns>
        TransferenciaBancariaResponse TransferirUsingPOST (long? id, TransferenciaBancariaPersistValue transferenciaBancariaPersist);
  
        /// <summary>
        /// {{{transferencia_bancaria_resource_transferir}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_transferir_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_transferir_param_id}}}</param>
        /// <param name="transferenciaBancariaPersist">transferenciaBancariaPersist</param>
        /// <returns>ApiResponse of TransferenciaBancariaResponse</returns>
        ApiResponse<TransferenciaBancariaResponse> TransferirUsingPOSTWithHttpInfo (long? id, TransferenciaBancariaPersistValue transferenciaBancariaPersist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_atualizar_taxas_juros_contas}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_atualizar_taxas_juros_contas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_salvar_taxas_juros_contas_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of TaxaJurosContaResponse</returns>
        System.Threading.Tasks.Task<TaxaJurosContaResponse> AtualizarTaxasJurosContasUsingPUTAsync (long? id, TaxaJurosContaPersistValue update);

        /// <summary>
        /// {{{transferencia_bancaria_resource_atualizar_taxas_juros_contas}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_atualizar_taxas_juros_contas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_salvar_taxas_juros_contas_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (TaxaJurosContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TaxaJurosContaResponse>> AtualizarTaxasJurosContasUsingPUTAsyncWithHttpInfo (long? id, TaxaJurosContaPersistValue update);
        
        /// <summary>
        /// {{{conta_bancaria_resource_atualizar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_bancaria_resource_atualizar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_bancaria_resource_atualizar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of ContaBancariaPortadorResponse</returns>
        System.Threading.Tasks.Task<ContaBancariaPortadorResponse> AtualizarUsingPUTAsync (long? id, ContaBancariaPortadorUpdateValue update);

        /// <summary>
        /// {{{conta_bancaria_resource_atualizar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_bancaria_resource_atualizar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_bancaria_resource_atualizar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (ContaBancariaPortadorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaBancariaPortadorResponse>> AtualizarUsingPUTAsyncWithHttpInfo (long? id, ContaBancariaPortadorUpdateValue update);
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_cancelar_transferencia_credito_conta_bancaria}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_cancelar_transferencia_credito_conta_bancaria_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">{{{transferencia_bancaria_resource_cancelar_transferencia_credito_conta_bancaria_param_id_transferencia}}}</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> CancelarTransferenciaCreditoContaBancariaUsingPOSTAsync (long? idTransferencia);

        /// <summary>
        /// {{{transferencia_bancaria_resource_cancelar_transferencia_credito_conta_bancaria}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_cancelar_transferencia_credito_conta_bancaria_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">{{{transferencia_bancaria_resource_cancelar_transferencia_credito_conta_bancaria_param_id_transferencia}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> CancelarTransferenciaCreditoContaBancariaUsingPOSTAsyncWithHttpInfo (long? idTransferencia);
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_confirmar_transferencia_credito_conta_bancaria}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_confirmar_transferencia_credito_conta_bancaria_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">{{{transferencia_bancaria_resource_confirmar_transferencia_credito_conta_bancaria_param_id_transferencia}}}</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ConfirmarTransferenciaCreditoContaBancariaUsingPOSTAsync (long? idTransferencia);

        /// <summary>
        /// {{{transferencia_bancaria_resource_confirmar_transferencia_credito_conta_bancaria}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_confirmar_transferencia_credito_conta_bancaria_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">{{{transferencia_bancaria_resource_confirmar_transferencia_credito_conta_bancaria_param_id_transferencia}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ConfirmarTransferenciaCreditoContaBancariaUsingPOSTAsyncWithHttpInfo (long? idTransferencia);
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_consultar_taxas_juros_contas}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_consultar_taxas_juros_contas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_salvar_taxas_juros_contas_param_id}}}</param>
        /// <param name="numeroMesesCarencia">numeroMesesCarencia</param>
        /// <returns>Task of TaxaJurosContaResponse</returns>
        System.Threading.Tasks.Task<TaxaJurosContaResponse> ConsultarTaxasJurosContasUsingGETAsync (long? id, int? numeroMesesCarencia);

        /// <summary>
        /// {{{transferencia_bancaria_resource_consultar_taxas_juros_contas}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_consultar_taxas_juros_contas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_salvar_taxas_juros_contas_param_id}}}</param>
        /// <param name="numeroMesesCarencia">numeroMesesCarencia</param>
        /// <returns>Task of ApiResponse (TaxaJurosContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TaxaJurosContaResponse>> ConsultarTaxasJurosContasUsingGETAsyncWithHttpInfo (long? id, int? numeroMesesCarencia);
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_consultar_transferencia_bancaria}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_consultar_transferencia_bancaria_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">{{{transferencia_bancaria_resource_consultar_transferencia_bancaria_param_id_transferencia}}}</param>
        /// <returns>Task of TransferenciaCreditoContaBancariaResponse</returns>
        System.Threading.Tasks.Task<TransferenciaCreditoContaBancariaResponse> ConsultarTransferenciaBancariaUsingGETAsync (long? idTransferencia);

        /// <summary>
        /// {{{transferencia_bancaria_resource_consultar_transferencia_bancaria}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_consultar_transferencia_bancaria_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">{{{transferencia_bancaria_resource_consultar_transferencia_bancaria_param_id_transferencia}}}</param>
        /// <returns>Task of ApiResponse (TransferenciaCreditoContaBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransferenciaCreditoContaBancariaResponse>> ConsultarTransferenciaBancariaUsingGETAsyncWithHttpInfo (long? idTransferencia);
        
        /// <summary>
        /// {{{conta_bancaria_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_bancaria_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_bancaria_resource_consultar_param_id}}}</param>
        /// <returns>Task of ContaBancariaPortadorResponse</returns>
        System.Threading.Tasks.Task<ContaBancariaPortadorResponse> ConsultarUsingGET11Async (long? id);

        /// <summary>
        /// {{{conta_bancaria_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_bancaria_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_bancaria_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (ContaBancariaPortadorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaBancariaPortadorResponse>> ConsultarUsingGET11AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_consultar_param_id}}}</param>
        /// <param name="idTransferencia">{{{transferencia_bancaria_resource_consultar_param_id_evento}}}</param>
        /// <param name="idContaBancariaDestino">{{{transferencia_bancaria_resource_consultar_param_id_conta_portador}}} (optional)</param>
        /// <returns>Task of TransferenciaBancariaResponse</returns>
        System.Threading.Tasks.Task<TransferenciaBancariaResponse> ConsultarUsingGET46Async (long? id, long? idTransferencia, long? idContaBancariaDestino = null);

        /// <summary>
        /// {{{transferencia_bancaria_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_consultar_param_id}}}</param>
        /// <param name="idTransferencia">{{{transferencia_bancaria_resource_consultar_param_id_evento}}}</param>
        /// <param name="idContaBancariaDestino">{{{transferencia_bancaria_resource_consultar_param_id_conta_portador}}} (optional)</param>
        /// <returns>Task of ApiResponse (TransferenciaBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransferenciaBancariaResponse>> ConsultarUsingGET46AsyncWithHttpInfo (long? id, long? idTransferencia, long? idContaBancariaDestino = null);
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_listar_transferencia_bancaria}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_listar_transferencia_bancaria_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idConta">{{{transferencia_credito_conta_bancaria_request_id_conta_value}}} (optional)</param>
        /// <param name="dataSolicitacaoInicial">{{{transferencia_credito_conta_bancaria_request_data_solicitacao_inicial_value}}} (optional)</param>
        /// <param name="dataSolicitacaoFinal">{{{transferencia_credito_conta_bancaria_request_data_solicitacao_final_value}}} (optional)</param>
        /// <param name="status">{{{transferencia_credito_conta_bancaria_request_status_value}}} (optional)</param>
        /// <returns>Task of PageTransferenciaCreditoContaBancariaResponse</returns>
        System.Threading.Tasks.Task<PageTransferenciaCreditoContaBancariaResponse> ListarTransferenciaBancariaUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataSolicitacaoInicial = null, string dataSolicitacaoFinal = null, int? status = null);

        /// <summary>
        /// {{{transferencia_bancaria_resource_listar_transferencia_bancaria}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_listar_transferencia_bancaria_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idConta">{{{transferencia_credito_conta_bancaria_request_id_conta_value}}} (optional)</param>
        /// <param name="dataSolicitacaoInicial">{{{transferencia_credito_conta_bancaria_request_data_solicitacao_inicial_value}}} (optional)</param>
        /// <param name="dataSolicitacaoFinal">{{{transferencia_credito_conta_bancaria_request_data_solicitacao_final_value}}} (optional)</param>
        /// <param name="status">{{{transferencia_credito_conta_bancaria_request_status_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTransferenciaCreditoContaBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransferenciaCreditoContaBancariaResponse>> ListarTransferenciaBancariaUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataSolicitacaoInicial = null, string dataSolicitacaoFinal = null, int? status = null);
        
        /// <summary>
        /// {{{conta_bancaria_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_bancaria_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{conta_bancaria_portador_listar_request_id_conta_value}}} (optional)</param>
        /// <param name="nomeAgencia">{{{conta_bancaria_portador_listar_request_nome_agencia_value}}} (optional)</param>
        /// <param name="banco">{{{conta_bancaria_portador_listar_request_codigo_banco_value}}} (optional)</param>
        /// <param name="numeroAgencia">{{{conta_bancaria_portador_listar_request_numero_agencia_value}}} (optional)</param>
        /// <param name="numeroConta">{{{conta_bancaria_portador_listar_request_numero_conta_value}}} (optional)</param>
        /// <param name="flagAtivo">{{{conta_bancaria_portador_listar_request_flag_ativo_value}}} (optional)</param>
        /// <param name="flagContaOrigemDoc">{{{conta_bancaria_portador_listar_request_flag_conta_origem_doc_value}}} (optional)</param>
        /// <param name="idPessoaFisica">{{{conta_bancaria_portador_listar_request_id_pessoa_fisica_value}}} (optional)</param>
        /// <param name="favorecido">{{{conta_bancaria_portador_listar_request_favorecido_value}}} (optional)</param>
        /// <param name="numeroReceiraFederal">{{{conta_bancaria_portador_listar_request_numero_receira_federal_value}}} (optional)</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageContaBancariaPortadorResponse</returns>
        System.Threading.Tasks.Task<PageContaBancariaPortadorResponse> ListarUsingGET13Async (long? idConta = null, string nomeAgencia = null, long? banco = null, string numeroAgencia = null, string numeroConta = null, int? flagAtivo = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{conta_bancaria_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_bancaria_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{conta_bancaria_portador_listar_request_id_conta_value}}} (optional)</param>
        /// <param name="nomeAgencia">{{{conta_bancaria_portador_listar_request_nome_agencia_value}}} (optional)</param>
        /// <param name="banco">{{{conta_bancaria_portador_listar_request_codigo_banco_value}}} (optional)</param>
        /// <param name="numeroAgencia">{{{conta_bancaria_portador_listar_request_numero_agencia_value}}} (optional)</param>
        /// <param name="numeroConta">{{{conta_bancaria_portador_listar_request_numero_conta_value}}} (optional)</param>
        /// <param name="flagAtivo">{{{conta_bancaria_portador_listar_request_flag_ativo_value}}} (optional)</param>
        /// <param name="flagContaOrigemDoc">{{{conta_bancaria_portador_listar_request_flag_conta_origem_doc_value}}} (optional)</param>
        /// <param name="idPessoaFisica">{{{conta_bancaria_portador_listar_request_id_pessoa_fisica_value}}} (optional)</param>
        /// <param name="favorecido">{{{conta_bancaria_portador_listar_request_favorecido_value}}} (optional)</param>
        /// <param name="numeroReceiraFederal">{{{conta_bancaria_portador_listar_request_numero_receira_federal_value}}} (optional)</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageContaBancariaPortadorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageContaBancariaPortadorResponse>> ListarUsingGET13AsyncWithHttpInfo (long? idConta = null, string nomeAgencia = null, long? banco = null, string numeroAgencia = null, string numeroConta = null, int? flagAtivo = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_listar_param_id}}}</param>
        /// <param name="idContaBancariaDestino">{{{transferencia_bancaria_resource_listar_param_id_conta_portador}}} (optional)</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageTransferenciaBancariaResponse</returns>
        System.Threading.Tasks.Task<PageTransferenciaBancariaResponse> ListarUsingGET56Async (long? id, long? idContaBancariaDestino = null, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{transferencia_bancaria_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_listar_param_id}}}</param>
        /// <param name="idContaBancariaDestino">{{{transferencia_bancaria_resource_listar_param_id_conta_portador}}} (optional)</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTransferenciaBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransferenciaBancariaResponse>> ListarUsingGET56AsyncWithHttpInfo (long? id, long? idContaBancariaDestino = null, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_salvar_taxas_juros_contas}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_salvar_taxas_juros_contas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_salvar_taxas_juros_contas_param_id}}}</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of TaxaJurosContaResponse</returns>
        System.Threading.Tasks.Task<TaxaJurosContaResponse> SalvarTaxasJurosContasUsingPOSTAsync (long? id, TaxaJurosContaPersistValue persist);

        /// <summary>
        /// {{{transferencia_bancaria_resource_salvar_taxas_juros_contas}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_salvar_taxas_juros_contas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_salvar_taxas_juros_contas_param_id}}}</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TaxaJurosContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TaxaJurosContaResponse>> SalvarTaxasJurosContasUsingPOSTAsyncWithHttpInfo (long? id, TaxaJurosContaPersistValue persist);
        
        /// <summary>
        /// {{{conta_bancaria_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_bancaria_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ContaBancariaPortadorResponse</returns>
        System.Threading.Tasks.Task<ContaBancariaPortadorResponse> SalvarUsingPOST6Async (ContaBancariaPortadorPersistValue persist);

        /// <summary>
        /// {{{conta_bancaria_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_bancaria_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (ContaBancariaPortadorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaBancariaPortadorResponse>> SalvarUsingPOST6AsyncWithHttpInfo (ContaBancariaPortadorPersistValue persist);
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_simular_transferencia_bancaria}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_simular_transferencia_bancaria_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of PlanoParcelamentoTransferenciaCreditoContaBancariaResponse</returns>
        System.Threading.Tasks.Task<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse> SimularTransferenciaBancariaUsingPOSTAsync (PlanoParcelamentoTransferenciaCreditoContaBancariaRequest request);

        /// <summary>
        /// {{{transferencia_bancaria_resource_simular_transferencia_bancaria}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_simular_transferencia_bancaria_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (PlanoParcelamentoTransferenciaCreditoContaBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse>> SimularTransferenciaBancariaUsingPOSTAsyncWithHttpInfo (PlanoParcelamentoTransferenciaCreditoContaBancariaRequest request);
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_transferencia_credito_conta_bancaria}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_transferencia_credito_conta_bancaria_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of TransferenciaCreditoContaBancariaResponse</returns>
        System.Threading.Tasks.Task<TransferenciaCreditoContaBancariaResponse> TransferenciaCreditoContaBancariaUsingPOSTAsync (TransferenciaCreditoContaBancariaPersistValue persist);

        /// <summary>
        /// {{{transferencia_bancaria_resource_transferencia_credito_conta_bancaria}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_transferencia_credito_conta_bancaria_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TransferenciaCreditoContaBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransferenciaCreditoContaBancariaResponse>> TransferenciaCreditoContaBancariaUsingPOSTAsyncWithHttpInfo (TransferenciaCreditoContaBancariaPersistValue persist);
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_transferir}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_transferir_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_transferir_param_id}}}</param>
        /// <param name="transferenciaBancariaPersist">transferenciaBancariaPersist</param>
        /// <returns>Task of TransferenciaBancariaResponse</returns>
        System.Threading.Tasks.Task<TransferenciaBancariaResponse> TransferirUsingPOSTAsync (long? id, TransferenciaBancariaPersistValue transferenciaBancariaPersist);

        /// <summary>
        /// {{{transferencia_bancaria_resource_transferir}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_bancaria_resource_transferir_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_transferir_param_id}}}</param>
        /// <param name="transferenciaBancariaPersist">transferenciaBancariaPersist</param>
        /// <returns>Task of ApiResponse (TransferenciaBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransferenciaBancariaResponse>> TransferirUsingPOSTAsyncWithHttpInfo (long? id, TransferenciaBancariaPersistValue transferenciaBancariaPersist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltagtransferenciabancariaApi : IGlobaltagtransferenciabancariaApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagtransferenciabancariaApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltagtransferenciabancariaApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagtransferenciabancariaApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltagtransferenciabancariaApi(Configuration configuration = null)
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
        /// {{{transferencia_bancaria_resource_atualizar_taxas_juros_contas}}} {{{transferencia_bancaria_resource_atualizar_taxas_juros_contas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_salvar_taxas_juros_contas_param_id}}}</param> 
        /// <param name="update">update</param> 
        /// <returns>TaxaJurosContaResponse</returns>
        public TaxaJurosContaResponse AtualizarTaxasJurosContasUsingPUT (long? id, TaxaJurosContaPersistValue update)
        {
             ApiResponse<TaxaJurosContaResponse> localVarResponse = AtualizarTaxasJurosContasUsingPUTWithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{transferencia_bancaria_resource_atualizar_taxas_juros_contas}}} {{{transferencia_bancaria_resource_atualizar_taxas_juros_contas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_salvar_taxas_juros_contas_param_id}}}</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of TaxaJurosContaResponse</returns>
        public ApiResponse< TaxaJurosContaResponse > AtualizarTaxasJurosContasUsingPUTWithHttpInfo (long? id, TaxaJurosContaPersistValue update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagtransferenciabancariaApi->AtualizarTaxasJurosContasUsingPUT");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling GlobaltagtransferenciabancariaApi->AtualizarTaxasJurosContasUsingPUT");
            
    
            var localVarPath = "/api/contas/{id}/taxas-transferencias";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtualizarTaxasJurosContasUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarTaxasJurosContasUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TaxaJurosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TaxaJurosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TaxaJurosContaResponse)));
            
        }

        
        /// <summary>
        /// {{{transferencia_bancaria_resource_atualizar_taxas_juros_contas}}} {{{transferencia_bancaria_resource_atualizar_taxas_juros_contas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_salvar_taxas_juros_contas_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of TaxaJurosContaResponse</returns>
        public async System.Threading.Tasks.Task<TaxaJurosContaResponse> AtualizarTaxasJurosContasUsingPUTAsync (long? id, TaxaJurosContaPersistValue update)
        {
             ApiResponse<TaxaJurosContaResponse> localVarResponse = await AtualizarTaxasJurosContasUsingPUTAsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{transferencia_bancaria_resource_atualizar_taxas_juros_contas}}} {{{transferencia_bancaria_resource_atualizar_taxas_juros_contas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_salvar_taxas_juros_contas_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (TaxaJurosContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TaxaJurosContaResponse>> AtualizarTaxasJurosContasUsingPUTAsyncWithHttpInfo (long? id, TaxaJurosContaPersistValue update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarTaxasJurosContasUsingPUT");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AtualizarTaxasJurosContasUsingPUT");
            
    
            var localVarPath = "/api/contas/{id}/taxas-transferencias";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtualizarTaxasJurosContasUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarTaxasJurosContasUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TaxaJurosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TaxaJurosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TaxaJurosContaResponse)));
            
        }
        
        /// <summary>
        /// {{{conta_bancaria_resource_atualizar}}} {{{conta_bancaria_resource_atualizar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_bancaria_resource_atualizar_param_id}}}</param> 
        /// <param name="update">update</param> 
        /// <returns>ContaBancariaPortadorResponse</returns>
        public ContaBancariaPortadorResponse AtualizarUsingPUT (long? id, ContaBancariaPortadorUpdateValue update)
        {
             ApiResponse<ContaBancariaPortadorResponse> localVarResponse = AtualizarUsingPUTWithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_bancaria_resource_atualizar}}} {{{conta_bancaria_resource_atualizar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_bancaria_resource_atualizar_param_id}}}</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of ContaBancariaPortadorResponse</returns>
        public ApiResponse< ContaBancariaPortadorResponse > AtualizarUsingPUTWithHttpInfo (long? id, ContaBancariaPortadorUpdateValue update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagtransferenciabancariaApi->AtualizarUsingPUT");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling GlobaltagtransferenciabancariaApi->AtualizarUsingPUT");
            
    
            var localVarPath = "/api/contas-bancarias-portador/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaBancariaPortadorResponse)));
            
        }

        
        /// <summary>
        /// {{{conta_bancaria_resource_atualizar}}} {{{conta_bancaria_resource_atualizar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_bancaria_resource_atualizar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of ContaBancariaPortadorResponse</returns>
        public async System.Threading.Tasks.Task<ContaBancariaPortadorResponse> AtualizarUsingPUTAsync (long? id, ContaBancariaPortadorUpdateValue update)
        {
             ApiResponse<ContaBancariaPortadorResponse> localVarResponse = await AtualizarUsingPUTAsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_bancaria_resource_atualizar}}} {{{conta_bancaria_resource_atualizar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_bancaria_resource_atualizar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (ContaBancariaPortadorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaBancariaPortadorResponse>> AtualizarUsingPUTAsyncWithHttpInfo (long? id, ContaBancariaPortadorUpdateValue update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarUsingPUT");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AtualizarUsingPUT");
            
    
            var localVarPath = "/api/contas-bancarias-portador/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaBancariaPortadorResponse)));
            
        }
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_cancelar_transferencia_credito_conta_bancaria}}} {{{transferencia_bancaria_resource_cancelar_transferencia_credito_conta_bancaria_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">{{{transferencia_bancaria_resource_cancelar_transferencia_credito_conta_bancaria_param_id_transferencia}}}</param> 
        /// <returns>string</returns>
        public string CancelarTransferenciaCreditoContaBancariaUsingPOST (long? idTransferencia)
        {
             ApiResponse<string> localVarResponse = CancelarTransferenciaCreditoContaBancariaUsingPOSTWithHttpInfo(idTransferencia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{transferencia_bancaria_resource_cancelar_transferencia_credito_conta_bancaria}}} {{{transferencia_bancaria_resource_cancelar_transferencia_credito_conta_bancaria_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">{{{transferencia_bancaria_resource_cancelar_transferencia_credito_conta_bancaria_param_id_transferencia}}}</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > CancelarTransferenciaCreditoContaBancariaUsingPOSTWithHttpInfo (long? idTransferencia)
        {
            
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null)
                throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling GlobaltagtransferenciabancariaApi->CancelarTransferenciaCreditoContaBancariaUsingPOST");
            
    
            var localVarPath = "/api/transferencias-creditos-contas-bancarias/{idTransferencia}/cancelar";
    
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
            if (idTransferencia != null) localVarPathParams.Add("idTransferencia", Configuration.ApiClient.ParameterToString(idTransferencia)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarTransferenciaCreditoContaBancariaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarTransferenciaCreditoContaBancariaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// {{{transferencia_bancaria_resource_cancelar_transferencia_credito_conta_bancaria}}} {{{transferencia_bancaria_resource_cancelar_transferencia_credito_conta_bancaria_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">{{{transferencia_bancaria_resource_cancelar_transferencia_credito_conta_bancaria_param_id_transferencia}}}</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> CancelarTransferenciaCreditoContaBancariaUsingPOSTAsync (long? idTransferencia)
        {
             ApiResponse<string> localVarResponse = await CancelarTransferenciaCreditoContaBancariaUsingPOSTAsyncWithHttpInfo(idTransferencia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{transferencia_bancaria_resource_cancelar_transferencia_credito_conta_bancaria}}} {{{transferencia_bancaria_resource_cancelar_transferencia_credito_conta_bancaria_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">{{{transferencia_bancaria_resource_cancelar_transferencia_credito_conta_bancaria_param_id_transferencia}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> CancelarTransferenciaCreditoContaBancariaUsingPOSTAsyncWithHttpInfo (long? idTransferencia)
        {
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null) throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling CancelarTransferenciaCreditoContaBancariaUsingPOST");
            
    
            var localVarPath = "/api/transferencias-creditos-contas-bancarias/{idTransferencia}/cancelar";
    
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
            if (idTransferencia != null) localVarPathParams.Add("idTransferencia", Configuration.ApiClient.ParameterToString(idTransferencia)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarTransferenciaCreditoContaBancariaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarTransferenciaCreditoContaBancariaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_confirmar_transferencia_credito_conta_bancaria}}} {{{transferencia_bancaria_resource_confirmar_transferencia_credito_conta_bancaria_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">{{{transferencia_bancaria_resource_confirmar_transferencia_credito_conta_bancaria_param_id_transferencia}}}</param> 
        /// <returns>string</returns>
        public string ConfirmarTransferenciaCreditoContaBancariaUsingPOST (long? idTransferencia)
        {
             ApiResponse<string> localVarResponse = ConfirmarTransferenciaCreditoContaBancariaUsingPOSTWithHttpInfo(idTransferencia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{transferencia_bancaria_resource_confirmar_transferencia_credito_conta_bancaria}}} {{{transferencia_bancaria_resource_confirmar_transferencia_credito_conta_bancaria_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">{{{transferencia_bancaria_resource_confirmar_transferencia_credito_conta_bancaria_param_id_transferencia}}}</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ConfirmarTransferenciaCreditoContaBancariaUsingPOSTWithHttpInfo (long? idTransferencia)
        {
            
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null)
                throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling GlobaltagtransferenciabancariaApi->ConfirmarTransferenciaCreditoContaBancariaUsingPOST");
            
    
            var localVarPath = "/api/transferencias-creditos-contas-bancarias/{idTransferencia}/confirmar";
    
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
            if (idTransferencia != null) localVarPathParams.Add("idTransferencia", Configuration.ApiClient.ParameterToString(idTransferencia)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConfirmarTransferenciaCreditoContaBancariaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfirmarTransferenciaCreditoContaBancariaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// {{{transferencia_bancaria_resource_confirmar_transferencia_credito_conta_bancaria}}} {{{transferencia_bancaria_resource_confirmar_transferencia_credito_conta_bancaria_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">{{{transferencia_bancaria_resource_confirmar_transferencia_credito_conta_bancaria_param_id_transferencia}}}</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ConfirmarTransferenciaCreditoContaBancariaUsingPOSTAsync (long? idTransferencia)
        {
             ApiResponse<string> localVarResponse = await ConfirmarTransferenciaCreditoContaBancariaUsingPOSTAsyncWithHttpInfo(idTransferencia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{transferencia_bancaria_resource_confirmar_transferencia_credito_conta_bancaria}}} {{{transferencia_bancaria_resource_confirmar_transferencia_credito_conta_bancaria_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">{{{transferencia_bancaria_resource_confirmar_transferencia_credito_conta_bancaria_param_id_transferencia}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ConfirmarTransferenciaCreditoContaBancariaUsingPOSTAsyncWithHttpInfo (long? idTransferencia)
        {
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null) throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling ConfirmarTransferenciaCreditoContaBancariaUsingPOST");
            
    
            var localVarPath = "/api/transferencias-creditos-contas-bancarias/{idTransferencia}/confirmar";
    
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
            if (idTransferencia != null) localVarPathParams.Add("idTransferencia", Configuration.ApiClient.ParameterToString(idTransferencia)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConfirmarTransferenciaCreditoContaBancariaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfirmarTransferenciaCreditoContaBancariaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_consultar_taxas_juros_contas}}} {{{transferencia_bancaria_resource_consultar_taxas_juros_contas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_salvar_taxas_juros_contas_param_id}}}</param> 
        /// <param name="numeroMesesCarencia">numeroMesesCarencia</param> 
        /// <returns>TaxaJurosContaResponse</returns>
        public TaxaJurosContaResponse ConsultarTaxasJurosContasUsingGET (long? id, int? numeroMesesCarencia)
        {
             ApiResponse<TaxaJurosContaResponse> localVarResponse = ConsultarTaxasJurosContasUsingGETWithHttpInfo(id, numeroMesesCarencia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{transferencia_bancaria_resource_consultar_taxas_juros_contas}}} {{{transferencia_bancaria_resource_consultar_taxas_juros_contas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_salvar_taxas_juros_contas_param_id}}}</param> 
        /// <param name="numeroMesesCarencia">numeroMesesCarencia</param> 
        /// <returns>ApiResponse of TaxaJurosContaResponse</returns>
        public ApiResponse< TaxaJurosContaResponse > ConsultarTaxasJurosContasUsingGETWithHttpInfo (long? id, int? numeroMesesCarencia)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagtransferenciabancariaApi->ConsultarTaxasJurosContasUsingGET");
            
            // verify the required parameter 'numeroMesesCarencia' is set
            if (numeroMesesCarencia == null)
                throw new ApiException(400, "Missing required parameter 'numeroMesesCarencia' when calling GlobaltagtransferenciabancariaApi->ConsultarTaxasJurosContasUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/taxas-transferencias";
    
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
            
            if (numeroMesesCarencia != null) localVarQueryParams.Add("numeroMesesCarencia", Configuration.ApiClient.ParameterToString(numeroMesesCarencia)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxasJurosContasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxasJurosContasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TaxaJurosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TaxaJurosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TaxaJurosContaResponse)));
            
        }

        
        /// <summary>
        /// {{{transferencia_bancaria_resource_consultar_taxas_juros_contas}}} {{{transferencia_bancaria_resource_consultar_taxas_juros_contas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_salvar_taxas_juros_contas_param_id}}}</param>
        /// <param name="numeroMesesCarencia">numeroMesesCarencia</param>
        /// <returns>Task of TaxaJurosContaResponse</returns>
        public async System.Threading.Tasks.Task<TaxaJurosContaResponse> ConsultarTaxasJurosContasUsingGETAsync (long? id, int? numeroMesesCarencia)
        {
             ApiResponse<TaxaJurosContaResponse> localVarResponse = await ConsultarTaxasJurosContasUsingGETAsyncWithHttpInfo(id, numeroMesesCarencia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{transferencia_bancaria_resource_consultar_taxas_juros_contas}}} {{{transferencia_bancaria_resource_consultar_taxas_juros_contas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_salvar_taxas_juros_contas_param_id}}}</param>
        /// <param name="numeroMesesCarencia">numeroMesesCarencia</param>
        /// <returns>Task of ApiResponse (TaxaJurosContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TaxaJurosContaResponse>> ConsultarTaxasJurosContasUsingGETAsyncWithHttpInfo (long? id, int? numeroMesesCarencia)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarTaxasJurosContasUsingGET");
            // verify the required parameter 'numeroMesesCarencia' is set
            if (numeroMesesCarencia == null) throw new ApiException(400, "Missing required parameter 'numeroMesesCarencia' when calling ConsultarTaxasJurosContasUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/taxas-transferencias";
    
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
            
            if (numeroMesesCarencia != null) localVarQueryParams.Add("numeroMesesCarencia", Configuration.ApiClient.ParameterToString(numeroMesesCarencia)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxasJurosContasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxasJurosContasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TaxaJurosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TaxaJurosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TaxaJurosContaResponse)));
            
        }
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_consultar_transferencia_bancaria}}} {{{transferencia_bancaria_resource_consultar_transferencia_bancaria_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">{{{transferencia_bancaria_resource_consultar_transferencia_bancaria_param_id_transferencia}}}</param> 
        /// <returns>TransferenciaCreditoContaBancariaResponse</returns>
        public TransferenciaCreditoContaBancariaResponse ConsultarTransferenciaBancariaUsingGET (long? idTransferencia)
        {
             ApiResponse<TransferenciaCreditoContaBancariaResponse> localVarResponse = ConsultarTransferenciaBancariaUsingGETWithHttpInfo(idTransferencia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{transferencia_bancaria_resource_consultar_transferencia_bancaria}}} {{{transferencia_bancaria_resource_consultar_transferencia_bancaria_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">{{{transferencia_bancaria_resource_consultar_transferencia_bancaria_param_id_transferencia}}}</param> 
        /// <returns>ApiResponse of TransferenciaCreditoContaBancariaResponse</returns>
        public ApiResponse< TransferenciaCreditoContaBancariaResponse > ConsultarTransferenciaBancariaUsingGETWithHttpInfo (long? idTransferencia)
        {
            
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null)
                throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling GlobaltagtransferenciabancariaApi->ConsultarTransferenciaBancariaUsingGET");
            
    
            var localVarPath = "/api/transferencias-creditos-contas-bancarias/{idTransferencia}";
    
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
            if (idTransferencia != null) localVarPathParams.Add("idTransferencia", Configuration.ApiClient.ParameterToString(idTransferencia)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTransferenciaBancariaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTransferenciaBancariaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransferenciaCreditoContaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaCreditoContaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaCreditoContaBancariaResponse)));
            
        }

        
        /// <summary>
        /// {{{transferencia_bancaria_resource_consultar_transferencia_bancaria}}} {{{transferencia_bancaria_resource_consultar_transferencia_bancaria_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">{{{transferencia_bancaria_resource_consultar_transferencia_bancaria_param_id_transferencia}}}</param>
        /// <returns>Task of TransferenciaCreditoContaBancariaResponse</returns>
        public async System.Threading.Tasks.Task<TransferenciaCreditoContaBancariaResponse> ConsultarTransferenciaBancariaUsingGETAsync (long? idTransferencia)
        {
             ApiResponse<TransferenciaCreditoContaBancariaResponse> localVarResponse = await ConsultarTransferenciaBancariaUsingGETAsyncWithHttpInfo(idTransferencia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{transferencia_bancaria_resource_consultar_transferencia_bancaria}}} {{{transferencia_bancaria_resource_consultar_transferencia_bancaria_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">{{{transferencia_bancaria_resource_consultar_transferencia_bancaria_param_id_transferencia}}}</param>
        /// <returns>Task of ApiResponse (TransferenciaCreditoContaBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransferenciaCreditoContaBancariaResponse>> ConsultarTransferenciaBancariaUsingGETAsyncWithHttpInfo (long? idTransferencia)
        {
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null) throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling ConsultarTransferenciaBancariaUsingGET");
            
    
            var localVarPath = "/api/transferencias-creditos-contas-bancarias/{idTransferencia}";
    
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
            if (idTransferencia != null) localVarPathParams.Add("idTransferencia", Configuration.ApiClient.ParameterToString(idTransferencia)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTransferenciaBancariaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTransferenciaBancariaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransferenciaCreditoContaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaCreditoContaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaCreditoContaBancariaResponse)));
            
        }
        
        /// <summary>
        /// {{{conta_bancaria_resource_consultar}}} {{{conta_bancaria_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_bancaria_resource_consultar_param_id}}}</param> 
        /// <returns>ContaBancariaPortadorResponse</returns>
        public ContaBancariaPortadorResponse ConsultarUsingGET11 (long? id)
        {
             ApiResponse<ContaBancariaPortadorResponse> localVarResponse = ConsultarUsingGET11WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_bancaria_resource_consultar}}} {{{conta_bancaria_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_bancaria_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of ContaBancariaPortadorResponse</returns>
        public ApiResponse< ContaBancariaPortadorResponse > ConsultarUsingGET11WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagtransferenciabancariaApi->ConsultarUsingGET11");
            
    
            var localVarPath = "/api/contas-bancarias-portador/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET11: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET11: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaBancariaPortadorResponse)));
            
        }

        
        /// <summary>
        /// {{{conta_bancaria_resource_consultar}}} {{{conta_bancaria_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_bancaria_resource_consultar_param_id}}}</param>
        /// <returns>Task of ContaBancariaPortadorResponse</returns>
        public async System.Threading.Tasks.Task<ContaBancariaPortadorResponse> ConsultarUsingGET11Async (long? id)
        {
             ApiResponse<ContaBancariaPortadorResponse> localVarResponse = await ConsultarUsingGET11AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_bancaria_resource_consultar}}} {{{conta_bancaria_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_bancaria_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (ContaBancariaPortadorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaBancariaPortadorResponse>> ConsultarUsingGET11AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET11");
            
    
            var localVarPath = "/api/contas-bancarias-portador/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET11: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET11: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaBancariaPortadorResponse)));
            
        }
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_consultar}}} {{{transferencia_bancaria_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_consultar_param_id}}}</param> 
        /// <param name="idTransferencia">{{{transferencia_bancaria_resource_consultar_param_id_evento}}}</param> 
        /// <param name="idContaBancariaDestino">{{{transferencia_bancaria_resource_consultar_param_id_conta_portador}}} (optional)</param> 
        /// <returns>TransferenciaBancariaResponse</returns>
        public TransferenciaBancariaResponse ConsultarUsingGET46 (long? id, long? idTransferencia, long? idContaBancariaDestino = null)
        {
             ApiResponse<TransferenciaBancariaResponse> localVarResponse = ConsultarUsingGET46WithHttpInfo(id, idTransferencia, idContaBancariaDestino);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{transferencia_bancaria_resource_consultar}}} {{{transferencia_bancaria_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_consultar_param_id}}}</param> 
        /// <param name="idTransferencia">{{{transferencia_bancaria_resource_consultar_param_id_evento}}}</param> 
        /// <param name="idContaBancariaDestino">{{{transferencia_bancaria_resource_consultar_param_id_conta_portador}}} (optional)</param> 
        /// <returns>ApiResponse of TransferenciaBancariaResponse</returns>
        public ApiResponse< TransferenciaBancariaResponse > ConsultarUsingGET46WithHttpInfo (long? id, long? idTransferencia, long? idContaBancariaDestino = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagtransferenciabancariaApi->ConsultarUsingGET46");
            
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null)
                throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling GlobaltagtransferenciabancariaApi->ConsultarUsingGET46");
            
    
            var localVarPath = "/api/contas/{id}/transferencias-creditos-contas-bancarias/{id_transferencia}";
    
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
            if (idTransferencia != null) localVarPathParams.Add("id_transferencia", Configuration.ApiClient.ParameterToString(idTransferencia)); // path parameter
            
            if (idContaBancariaDestino != null) localVarQueryParams.Add("id_conta_bancaria_destino", Configuration.ApiClient.ParameterToString(idContaBancariaDestino)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET46: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET46: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransferenciaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaBancariaResponse)));
            
        }

        
        /// <summary>
        /// {{{transferencia_bancaria_resource_consultar}}} {{{transferencia_bancaria_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_consultar_param_id}}}</param>
        /// <param name="idTransferencia">{{{transferencia_bancaria_resource_consultar_param_id_evento}}}</param>
        /// <param name="idContaBancariaDestino">{{{transferencia_bancaria_resource_consultar_param_id_conta_portador}}} (optional)</param>
        /// <returns>Task of TransferenciaBancariaResponse</returns>
        public async System.Threading.Tasks.Task<TransferenciaBancariaResponse> ConsultarUsingGET46Async (long? id, long? idTransferencia, long? idContaBancariaDestino = null)
        {
             ApiResponse<TransferenciaBancariaResponse> localVarResponse = await ConsultarUsingGET46AsyncWithHttpInfo(id, idTransferencia, idContaBancariaDestino);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{transferencia_bancaria_resource_consultar}}} {{{transferencia_bancaria_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_consultar_param_id}}}</param>
        /// <param name="idTransferencia">{{{transferencia_bancaria_resource_consultar_param_id_evento}}}</param>
        /// <param name="idContaBancariaDestino">{{{transferencia_bancaria_resource_consultar_param_id_conta_portador}}} (optional)</param>
        /// <returns>Task of ApiResponse (TransferenciaBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransferenciaBancariaResponse>> ConsultarUsingGET46AsyncWithHttpInfo (long? id, long? idTransferencia, long? idContaBancariaDestino = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET46");
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null) throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling ConsultarUsingGET46");
            
    
            var localVarPath = "/api/contas/{id}/transferencias-creditos-contas-bancarias/{id_transferencia}";
    
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
            if (idTransferencia != null) localVarPathParams.Add("id_transferencia", Configuration.ApiClient.ParameterToString(idTransferencia)); // path parameter
            
            if (idContaBancariaDestino != null) localVarQueryParams.Add("id_conta_bancaria_destino", Configuration.ApiClient.ParameterToString(idContaBancariaDestino)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET46: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET46: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransferenciaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaBancariaResponse)));
            
        }
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_listar_transferencia_bancaria}}} {{{transferencia_bancaria_resource_listar_transferencia_bancaria_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idConta">{{{transferencia_credito_conta_bancaria_request_id_conta_value}}} (optional)</param> 
        /// <param name="dataSolicitacaoInicial">{{{transferencia_credito_conta_bancaria_request_data_solicitacao_inicial_value}}} (optional)</param> 
        /// <param name="dataSolicitacaoFinal">{{{transferencia_credito_conta_bancaria_request_data_solicitacao_final_value}}} (optional)</param> 
        /// <param name="status">{{{transferencia_credito_conta_bancaria_request_status_value}}} (optional)</param> 
        /// <returns>PageTransferenciaCreditoContaBancariaResponse</returns>
        public PageTransferenciaCreditoContaBancariaResponse ListarTransferenciaBancariaUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataSolicitacaoInicial = null, string dataSolicitacaoFinal = null, int? status = null)
        {
             ApiResponse<PageTransferenciaCreditoContaBancariaResponse> localVarResponse = ListarTransferenciaBancariaUsingGETWithHttpInfo(sort, page, limit, idConta, dataSolicitacaoInicial, dataSolicitacaoFinal, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{transferencia_bancaria_resource_listar_transferencia_bancaria}}} {{{transferencia_bancaria_resource_listar_transferencia_bancaria_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idConta">{{{transferencia_credito_conta_bancaria_request_id_conta_value}}} (optional)</param> 
        /// <param name="dataSolicitacaoInicial">{{{transferencia_credito_conta_bancaria_request_data_solicitacao_inicial_value}}} (optional)</param> 
        /// <param name="dataSolicitacaoFinal">{{{transferencia_credito_conta_bancaria_request_data_solicitacao_final_value}}} (optional)</param> 
        /// <param name="status">{{{transferencia_credito_conta_bancaria_request_status_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageTransferenciaCreditoContaBancariaResponse</returns>
        public ApiResponse< PageTransferenciaCreditoContaBancariaResponse > ListarTransferenciaBancariaUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataSolicitacaoInicial = null, string dataSolicitacaoFinal = null, int? status = null)
        {
            
    
            var localVarPath = "/api/transferencias-creditos-contas-bancarias";
    
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
            if (dataSolicitacaoInicial != null) localVarQueryParams.Add("dataSolicitacaoInicial", Configuration.ApiClient.ParameterToString(dataSolicitacaoInicial)); // query parameter
            if (dataSolicitacaoFinal != null) localVarQueryParams.Add("dataSolicitacaoFinal", Configuration.ApiClient.ParameterToString(dataSolicitacaoFinal)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTransferenciaBancariaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTransferenciaBancariaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTransferenciaCreditoContaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransferenciaCreditoContaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransferenciaCreditoContaBancariaResponse)));
            
        }

        
        /// <summary>
        /// {{{transferencia_bancaria_resource_listar_transferencia_bancaria}}} {{{transferencia_bancaria_resource_listar_transferencia_bancaria_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idConta">{{{transferencia_credito_conta_bancaria_request_id_conta_value}}} (optional)</param>
        /// <param name="dataSolicitacaoInicial">{{{transferencia_credito_conta_bancaria_request_data_solicitacao_inicial_value}}} (optional)</param>
        /// <param name="dataSolicitacaoFinal">{{{transferencia_credito_conta_bancaria_request_data_solicitacao_final_value}}} (optional)</param>
        /// <param name="status">{{{transferencia_credito_conta_bancaria_request_status_value}}} (optional)</param>
        /// <returns>Task of PageTransferenciaCreditoContaBancariaResponse</returns>
        public async System.Threading.Tasks.Task<PageTransferenciaCreditoContaBancariaResponse> ListarTransferenciaBancariaUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataSolicitacaoInicial = null, string dataSolicitacaoFinal = null, int? status = null)
        {
             ApiResponse<PageTransferenciaCreditoContaBancariaResponse> localVarResponse = await ListarTransferenciaBancariaUsingGETAsyncWithHttpInfo(sort, page, limit, idConta, dataSolicitacaoInicial, dataSolicitacaoFinal, status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{transferencia_bancaria_resource_listar_transferencia_bancaria}}} {{{transferencia_bancaria_resource_listar_transferencia_bancaria_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idConta">{{{transferencia_credito_conta_bancaria_request_id_conta_value}}} (optional)</param>
        /// <param name="dataSolicitacaoInicial">{{{transferencia_credito_conta_bancaria_request_data_solicitacao_inicial_value}}} (optional)</param>
        /// <param name="dataSolicitacaoFinal">{{{transferencia_credito_conta_bancaria_request_data_solicitacao_final_value}}} (optional)</param>
        /// <param name="status">{{{transferencia_credito_conta_bancaria_request_status_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTransferenciaCreditoContaBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransferenciaCreditoContaBancariaResponse>> ListarTransferenciaBancariaUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataSolicitacaoInicial = null, string dataSolicitacaoFinal = null, int? status = null)
        {
            
    
            var localVarPath = "/api/transferencias-creditos-contas-bancarias";
    
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
            if (dataSolicitacaoInicial != null) localVarQueryParams.Add("dataSolicitacaoInicial", Configuration.ApiClient.ParameterToString(dataSolicitacaoInicial)); // query parameter
            if (dataSolicitacaoFinal != null) localVarQueryParams.Add("dataSolicitacaoFinal", Configuration.ApiClient.ParameterToString(dataSolicitacaoFinal)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTransferenciaBancariaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTransferenciaBancariaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTransferenciaCreditoContaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransferenciaCreditoContaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransferenciaCreditoContaBancariaResponse)));
            
        }
        
        /// <summary>
        /// {{{conta_bancaria_resource_listar}}} {{{conta_bancaria_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{conta_bancaria_portador_listar_request_id_conta_value}}} (optional)</param> 
        /// <param name="nomeAgencia">{{{conta_bancaria_portador_listar_request_nome_agencia_value}}} (optional)</param> 
        /// <param name="banco">{{{conta_bancaria_portador_listar_request_codigo_banco_value}}} (optional)</param> 
        /// <param name="numeroAgencia">{{{conta_bancaria_portador_listar_request_numero_agencia_value}}} (optional)</param> 
        /// <param name="numeroConta">{{{conta_bancaria_portador_listar_request_numero_conta_value}}} (optional)</param> 
        /// <param name="flagAtivo">{{{conta_bancaria_portador_listar_request_flag_ativo_value}}} (optional)</param> 
        /// <param name="flagContaOrigemDoc">{{{conta_bancaria_portador_listar_request_flag_conta_origem_doc_value}}} (optional)</param> 
        /// <param name="idPessoaFisica">{{{conta_bancaria_portador_listar_request_id_pessoa_fisica_value}}} (optional)</param> 
        /// <param name="favorecido">{{{conta_bancaria_portador_listar_request_favorecido_value}}} (optional)</param> 
        /// <param name="numeroReceiraFederal">{{{conta_bancaria_portador_listar_request_numero_receira_federal_value}}} (optional)</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>PageContaBancariaPortadorResponse</returns>
        public PageContaBancariaPortadorResponse ListarUsingGET13 (long? idConta = null, string nomeAgencia = null, long? banco = null, string numeroAgencia = null, string numeroConta = null, int? flagAtivo = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageContaBancariaPortadorResponse> localVarResponse = ListarUsingGET13WithHttpInfo(idConta, nomeAgencia, banco, numeroAgencia, numeroConta, flagAtivo, flagContaOrigemDoc, idPessoaFisica, favorecido, numeroReceiraFederal, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_bancaria_resource_listar}}} {{{conta_bancaria_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{conta_bancaria_portador_listar_request_id_conta_value}}} (optional)</param> 
        /// <param name="nomeAgencia">{{{conta_bancaria_portador_listar_request_nome_agencia_value}}} (optional)</param> 
        /// <param name="banco">{{{conta_bancaria_portador_listar_request_codigo_banco_value}}} (optional)</param> 
        /// <param name="numeroAgencia">{{{conta_bancaria_portador_listar_request_numero_agencia_value}}} (optional)</param> 
        /// <param name="numeroConta">{{{conta_bancaria_portador_listar_request_numero_conta_value}}} (optional)</param> 
        /// <param name="flagAtivo">{{{conta_bancaria_portador_listar_request_flag_ativo_value}}} (optional)</param> 
        /// <param name="flagContaOrigemDoc">{{{conta_bancaria_portador_listar_request_flag_conta_origem_doc_value}}} (optional)</param> 
        /// <param name="idPessoaFisica">{{{conta_bancaria_portador_listar_request_id_pessoa_fisica_value}}} (optional)</param> 
        /// <param name="favorecido">{{{conta_bancaria_portador_listar_request_favorecido_value}}} (optional)</param> 
        /// <param name="numeroReceiraFederal">{{{conta_bancaria_portador_listar_request_numero_receira_federal_value}}} (optional)</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>ApiResponse of PageContaBancariaPortadorResponse</returns>
        public ApiResponse< PageContaBancariaPortadorResponse > ListarUsingGET13WithHttpInfo (long? idConta = null, string nomeAgencia = null, long? banco = null, string numeroAgencia = null, string numeroConta = null, int? flagAtivo = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/contas-bancarias-portador";
    
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
            if (nomeAgencia != null) localVarQueryParams.Add("nomeAgencia", Configuration.ApiClient.ParameterToString(nomeAgencia)); // query parameter
            if (banco != null) localVarQueryParams.Add("banco", Configuration.ApiClient.ParameterToString(banco)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroConta != null) localVarQueryParams.Add("numeroConta", Configuration.ApiClient.ParameterToString(numeroConta)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            if (flagContaOrigemDoc != null) localVarQueryParams.Add("flagContaOrigemDoc", Configuration.ApiClient.ParameterToString(flagContaOrigemDoc)); // query parameter
            if (idPessoaFisica != null) localVarQueryParams.Add("idPessoaFisica", Configuration.ApiClient.ParameterToString(idPessoaFisica)); // query parameter
            if (favorecido != null) localVarQueryParams.Add("favorecido", Configuration.ApiClient.ParameterToString(favorecido)); // query parameter
            if (numeroReceiraFederal != null) localVarQueryParams.Add("numeroReceiraFederal", Configuration.ApiClient.ParameterToString(numeroReceiraFederal)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET13: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET13: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaBancariaPortadorResponse)));
            
        }

        
        /// <summary>
        /// {{{conta_bancaria_resource_listar}}} {{{conta_bancaria_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{conta_bancaria_portador_listar_request_id_conta_value}}} (optional)</param>
        /// <param name="nomeAgencia">{{{conta_bancaria_portador_listar_request_nome_agencia_value}}} (optional)</param>
        /// <param name="banco">{{{conta_bancaria_portador_listar_request_codigo_banco_value}}} (optional)</param>
        /// <param name="numeroAgencia">{{{conta_bancaria_portador_listar_request_numero_agencia_value}}} (optional)</param>
        /// <param name="numeroConta">{{{conta_bancaria_portador_listar_request_numero_conta_value}}} (optional)</param>
        /// <param name="flagAtivo">{{{conta_bancaria_portador_listar_request_flag_ativo_value}}} (optional)</param>
        /// <param name="flagContaOrigemDoc">{{{conta_bancaria_portador_listar_request_flag_conta_origem_doc_value}}} (optional)</param>
        /// <param name="idPessoaFisica">{{{conta_bancaria_portador_listar_request_id_pessoa_fisica_value}}} (optional)</param>
        /// <param name="favorecido">{{{conta_bancaria_portador_listar_request_favorecido_value}}} (optional)</param>
        /// <param name="numeroReceiraFederal">{{{conta_bancaria_portador_listar_request_numero_receira_federal_value}}} (optional)</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageContaBancariaPortadorResponse</returns>
        public async System.Threading.Tasks.Task<PageContaBancariaPortadorResponse> ListarUsingGET13Async (long? idConta = null, string nomeAgencia = null, long? banco = null, string numeroAgencia = null, string numeroConta = null, int? flagAtivo = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageContaBancariaPortadorResponse> localVarResponse = await ListarUsingGET13AsyncWithHttpInfo(idConta, nomeAgencia, banco, numeroAgencia, numeroConta, flagAtivo, flagContaOrigemDoc, idPessoaFisica, favorecido, numeroReceiraFederal, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_bancaria_resource_listar}}} {{{conta_bancaria_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{conta_bancaria_portador_listar_request_id_conta_value}}} (optional)</param>
        /// <param name="nomeAgencia">{{{conta_bancaria_portador_listar_request_nome_agencia_value}}} (optional)</param>
        /// <param name="banco">{{{conta_bancaria_portador_listar_request_codigo_banco_value}}} (optional)</param>
        /// <param name="numeroAgencia">{{{conta_bancaria_portador_listar_request_numero_agencia_value}}} (optional)</param>
        /// <param name="numeroConta">{{{conta_bancaria_portador_listar_request_numero_conta_value}}} (optional)</param>
        /// <param name="flagAtivo">{{{conta_bancaria_portador_listar_request_flag_ativo_value}}} (optional)</param>
        /// <param name="flagContaOrigemDoc">{{{conta_bancaria_portador_listar_request_flag_conta_origem_doc_value}}} (optional)</param>
        /// <param name="idPessoaFisica">{{{conta_bancaria_portador_listar_request_id_pessoa_fisica_value}}} (optional)</param>
        /// <param name="favorecido">{{{conta_bancaria_portador_listar_request_favorecido_value}}} (optional)</param>
        /// <param name="numeroReceiraFederal">{{{conta_bancaria_portador_listar_request_numero_receira_federal_value}}} (optional)</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageContaBancariaPortadorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageContaBancariaPortadorResponse>> ListarUsingGET13AsyncWithHttpInfo (long? idConta = null, string nomeAgencia = null, long? banco = null, string numeroAgencia = null, string numeroConta = null, int? flagAtivo = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/contas-bancarias-portador";
    
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
            if (nomeAgencia != null) localVarQueryParams.Add("nomeAgencia", Configuration.ApiClient.ParameterToString(nomeAgencia)); // query parameter
            if (banco != null) localVarQueryParams.Add("banco", Configuration.ApiClient.ParameterToString(banco)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroConta != null) localVarQueryParams.Add("numeroConta", Configuration.ApiClient.ParameterToString(numeroConta)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            if (flagContaOrigemDoc != null) localVarQueryParams.Add("flagContaOrigemDoc", Configuration.ApiClient.ParameterToString(flagContaOrigemDoc)); // query parameter
            if (idPessoaFisica != null) localVarQueryParams.Add("idPessoaFisica", Configuration.ApiClient.ParameterToString(idPessoaFisica)); // query parameter
            if (favorecido != null) localVarQueryParams.Add("favorecido", Configuration.ApiClient.ParameterToString(favorecido)); // query parameter
            if (numeroReceiraFederal != null) localVarQueryParams.Add("numeroReceiraFederal", Configuration.ApiClient.ParameterToString(numeroReceiraFederal)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET13: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET13: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaBancariaPortadorResponse)));
            
        }
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_listar}}} {{{transferencia_bancaria_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_listar_param_id}}}</param> 
        /// <param name="idContaBancariaDestino">{{{transferencia_bancaria_resource_listar_param_id_conta_portador}}} (optional)</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>PageTransferenciaBancariaResponse</returns>
        public PageTransferenciaBancariaResponse ListarUsingGET56 (long? id, long? idContaBancariaDestino = null, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTransferenciaBancariaResponse> localVarResponse = ListarUsingGET56WithHttpInfo(id, idContaBancariaDestino, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{transferencia_bancaria_resource_listar}}} {{{transferencia_bancaria_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_listar_param_id}}}</param> 
        /// <param name="idContaBancariaDestino">{{{transferencia_bancaria_resource_listar_param_id_conta_portador}}} (optional)</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>ApiResponse of PageTransferenciaBancariaResponse</returns>
        public ApiResponse< PageTransferenciaBancariaResponse > ListarUsingGET56WithHttpInfo (long? id, long? idContaBancariaDestino = null, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagtransferenciabancariaApi->ListarUsingGET56");
            
    
            var localVarPath = "/api/contas/{id}/transferencias-creditos-contas-bancarias";
    
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
            
            if (idContaBancariaDestino != null) localVarQueryParams.Add("id_conta_bancaria_destino", Configuration.ApiClient.ParameterToString(idContaBancariaDestino)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET56: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET56: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTransferenciaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransferenciaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransferenciaBancariaResponse)));
            
        }

        
        /// <summary>
        /// {{{transferencia_bancaria_resource_listar}}} {{{transferencia_bancaria_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_listar_param_id}}}</param>
        /// <param name="idContaBancariaDestino">{{{transferencia_bancaria_resource_listar_param_id_conta_portador}}} (optional)</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageTransferenciaBancariaResponse</returns>
        public async System.Threading.Tasks.Task<PageTransferenciaBancariaResponse> ListarUsingGET56Async (long? id, long? idContaBancariaDestino = null, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTransferenciaBancariaResponse> localVarResponse = await ListarUsingGET56AsyncWithHttpInfo(id, idContaBancariaDestino, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{transferencia_bancaria_resource_listar}}} {{{transferencia_bancaria_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_listar_param_id}}}</param>
        /// <param name="idContaBancariaDestino">{{{transferencia_bancaria_resource_listar_param_id_conta_portador}}} (optional)</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTransferenciaBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransferenciaBancariaResponse>> ListarUsingGET56AsyncWithHttpInfo (long? id, long? idContaBancariaDestino = null, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarUsingGET56");
            
    
            var localVarPath = "/api/contas/{id}/transferencias-creditos-contas-bancarias";
    
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
            
            if (idContaBancariaDestino != null) localVarQueryParams.Add("id_conta_bancaria_destino", Configuration.ApiClient.ParameterToString(idContaBancariaDestino)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET56: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET56: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTransferenciaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransferenciaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransferenciaBancariaResponse)));
            
        }
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_salvar_taxas_juros_contas}}} {{{transferencia_bancaria_resource_salvar_taxas_juros_contas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_salvar_taxas_juros_contas_param_id}}}</param> 
        /// <param name="persist">persist</param> 
        /// <returns>TaxaJurosContaResponse</returns>
        public TaxaJurosContaResponse SalvarTaxasJurosContasUsingPOST (long? id, TaxaJurosContaPersistValue persist)
        {
             ApiResponse<TaxaJurosContaResponse> localVarResponse = SalvarTaxasJurosContasUsingPOSTWithHttpInfo(id, persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{transferencia_bancaria_resource_salvar_taxas_juros_contas}}} {{{transferencia_bancaria_resource_salvar_taxas_juros_contas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_salvar_taxas_juros_contas_param_id}}}</param> 
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of TaxaJurosContaResponse</returns>
        public ApiResponse< TaxaJurosContaResponse > SalvarTaxasJurosContasUsingPOSTWithHttpInfo (long? id, TaxaJurosContaPersistValue persist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagtransferenciabancariaApi->SalvarTaxasJurosContasUsingPOST");
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling GlobaltagtransferenciabancariaApi->SalvarTaxasJurosContasUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/taxas-transferencias";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarTaxasJurosContasUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarTaxasJurosContasUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TaxaJurosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TaxaJurosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TaxaJurosContaResponse)));
            
        }

        
        /// <summary>
        /// {{{transferencia_bancaria_resource_salvar_taxas_juros_contas}}} {{{transferencia_bancaria_resource_salvar_taxas_juros_contas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_salvar_taxas_juros_contas_param_id}}}</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of TaxaJurosContaResponse</returns>
        public async System.Threading.Tasks.Task<TaxaJurosContaResponse> SalvarTaxasJurosContasUsingPOSTAsync (long? id, TaxaJurosContaPersistValue persist)
        {
             ApiResponse<TaxaJurosContaResponse> localVarResponse = await SalvarTaxasJurosContasUsingPOSTAsyncWithHttpInfo(id, persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{transferencia_bancaria_resource_salvar_taxas_juros_contas}}} {{{transferencia_bancaria_resource_salvar_taxas_juros_contas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_salvar_taxas_juros_contas_param_id}}}</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TaxaJurosContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TaxaJurosContaResponse>> SalvarTaxasJurosContasUsingPOSTAsyncWithHttpInfo (long? id, TaxaJurosContaPersistValue persist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SalvarTaxasJurosContasUsingPOST");
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarTaxasJurosContasUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/taxas-transferencias";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarTaxasJurosContasUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarTaxasJurosContasUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TaxaJurosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TaxaJurosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TaxaJurosContaResponse)));
            
        }
        
        /// <summary>
        /// {{{conta_bancaria_resource_salvar}}} {{{conta_bancaria_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ContaBancariaPortadorResponse</returns>
        public ContaBancariaPortadorResponse SalvarUsingPOST6 (ContaBancariaPortadorPersistValue persist)
        {
             ApiResponse<ContaBancariaPortadorResponse> localVarResponse = SalvarUsingPOST6WithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_bancaria_resource_salvar}}} {{{conta_bancaria_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of ContaBancariaPortadorResponse</returns>
        public ApiResponse< ContaBancariaPortadorResponse > SalvarUsingPOST6WithHttpInfo (ContaBancariaPortadorPersistValue persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling GlobaltagtransferenciabancariaApi->SalvarUsingPOST6");
            
    
            var localVarPath = "/api/contas-bancarias-portador";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaBancariaPortadorResponse)));
            
        }

        
        /// <summary>
        /// {{{conta_bancaria_resource_salvar}}} {{{conta_bancaria_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ContaBancariaPortadorResponse</returns>
        public async System.Threading.Tasks.Task<ContaBancariaPortadorResponse> SalvarUsingPOST6Async (ContaBancariaPortadorPersistValue persist)
        {
             ApiResponse<ContaBancariaPortadorResponse> localVarResponse = await SalvarUsingPOST6AsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_bancaria_resource_salvar}}} {{{conta_bancaria_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (ContaBancariaPortadorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaBancariaPortadorResponse>> SalvarUsingPOST6AsyncWithHttpInfo (ContaBancariaPortadorPersistValue persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarUsingPOST6");
            
    
            var localVarPath = "/api/contas-bancarias-portador";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaBancariaPortadorResponse)));
            
        }
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_simular_transferencia_bancaria}}} {{{transferencia_bancaria_resource_simular_transferencia_bancaria_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>PlanoParcelamentoTransferenciaCreditoContaBancariaResponse</returns>
        public PlanoParcelamentoTransferenciaCreditoContaBancariaResponse SimularTransferenciaBancariaUsingPOST (PlanoParcelamentoTransferenciaCreditoContaBancariaRequest request)
        {
             ApiResponse<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse> localVarResponse = SimularTransferenciaBancariaUsingPOSTWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{transferencia_bancaria_resource_simular_transferencia_bancaria}}} {{{transferencia_bancaria_resource_simular_transferencia_bancaria_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>ApiResponse of PlanoParcelamentoTransferenciaCreditoContaBancariaResponse</returns>
        public ApiResponse< PlanoParcelamentoTransferenciaCreditoContaBancariaResponse > SimularTransferenciaBancariaUsingPOSTWithHttpInfo (PlanoParcelamentoTransferenciaCreditoContaBancariaRequest request)
        {
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling GlobaltagtransferenciabancariaApi->SimularTransferenciaBancariaUsingPOST");
            
    
            var localVarPath = "/api/simular-transferencias-creditos-contas-bancarias";
    
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
            
            
            
            
            if (request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SimularTransferenciaBancariaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularTransferenciaBancariaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PlanoParcelamentoTransferenciaCreditoContaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PlanoParcelamentoTransferenciaCreditoContaBancariaResponse)));
            
        }

        
        /// <summary>
        /// {{{transferencia_bancaria_resource_simular_transferencia_bancaria}}} {{{transferencia_bancaria_resource_simular_transferencia_bancaria_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of PlanoParcelamentoTransferenciaCreditoContaBancariaResponse</returns>
        public async System.Threading.Tasks.Task<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse> SimularTransferenciaBancariaUsingPOSTAsync (PlanoParcelamentoTransferenciaCreditoContaBancariaRequest request)
        {
             ApiResponse<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse> localVarResponse = await SimularTransferenciaBancariaUsingPOSTAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{transferencia_bancaria_resource_simular_transferencia_bancaria}}} {{{transferencia_bancaria_resource_simular_transferencia_bancaria_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (PlanoParcelamentoTransferenciaCreditoContaBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse>> SimularTransferenciaBancariaUsingPOSTAsyncWithHttpInfo (PlanoParcelamentoTransferenciaCreditoContaBancariaRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling SimularTransferenciaBancariaUsingPOST");
            
    
            var localVarPath = "/api/simular-transferencias-creditos-contas-bancarias";
    
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
            
            
            
            
            if (request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SimularTransferenciaBancariaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularTransferenciaBancariaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PlanoParcelamentoTransferenciaCreditoContaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PlanoParcelamentoTransferenciaCreditoContaBancariaResponse)));
            
        }
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_transferencia_credito_conta_bancaria}}} {{{transferencia_bancaria_resource_transferencia_credito_conta_bancaria_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>TransferenciaCreditoContaBancariaResponse</returns>
        public TransferenciaCreditoContaBancariaResponse TransferenciaCreditoContaBancariaUsingPOST (TransferenciaCreditoContaBancariaPersistValue persist)
        {
             ApiResponse<TransferenciaCreditoContaBancariaResponse> localVarResponse = TransferenciaCreditoContaBancariaUsingPOSTWithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{transferencia_bancaria_resource_transferencia_credito_conta_bancaria}}} {{{transferencia_bancaria_resource_transferencia_credito_conta_bancaria_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of TransferenciaCreditoContaBancariaResponse</returns>
        public ApiResponse< TransferenciaCreditoContaBancariaResponse > TransferenciaCreditoContaBancariaUsingPOSTWithHttpInfo (TransferenciaCreditoContaBancariaPersistValue persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling GlobaltagtransferenciabancariaApi->TransferenciaCreditoContaBancariaUsingPOST");
            
    
            var localVarPath = "/api/transferencias-creditos-contas-bancarias";
    
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
                throw new ApiException (localVarStatusCode, "Error calling TransferenciaCreditoContaBancariaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TransferenciaCreditoContaBancariaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransferenciaCreditoContaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaCreditoContaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaCreditoContaBancariaResponse)));
            
        }

        
        /// <summary>
        /// {{{transferencia_bancaria_resource_transferencia_credito_conta_bancaria}}} {{{transferencia_bancaria_resource_transferencia_credito_conta_bancaria_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of TransferenciaCreditoContaBancariaResponse</returns>
        public async System.Threading.Tasks.Task<TransferenciaCreditoContaBancariaResponse> TransferenciaCreditoContaBancariaUsingPOSTAsync (TransferenciaCreditoContaBancariaPersistValue persist)
        {
             ApiResponse<TransferenciaCreditoContaBancariaResponse> localVarResponse = await TransferenciaCreditoContaBancariaUsingPOSTAsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{transferencia_bancaria_resource_transferencia_credito_conta_bancaria}}} {{{transferencia_bancaria_resource_transferencia_credito_conta_bancaria_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TransferenciaCreditoContaBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransferenciaCreditoContaBancariaResponse>> TransferenciaCreditoContaBancariaUsingPOSTAsyncWithHttpInfo (TransferenciaCreditoContaBancariaPersistValue persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling TransferenciaCreditoContaBancariaUsingPOST");
            
    
            var localVarPath = "/api/transferencias-creditos-contas-bancarias";
    
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
                throw new ApiException (localVarStatusCode, "Error calling TransferenciaCreditoContaBancariaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TransferenciaCreditoContaBancariaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransferenciaCreditoContaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaCreditoContaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaCreditoContaBancariaResponse)));
            
        }
        
        /// <summary>
        /// {{{transferencia_bancaria_resource_transferir}}} {{{transferencia_bancaria_resource_transferir_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_transferir_param_id}}}</param> 
        /// <param name="transferenciaBancariaPersist">transferenciaBancariaPersist</param> 
        /// <returns>TransferenciaBancariaResponse</returns>
        public TransferenciaBancariaResponse TransferirUsingPOST (long? id, TransferenciaBancariaPersistValue transferenciaBancariaPersist)
        {
             ApiResponse<TransferenciaBancariaResponse> localVarResponse = TransferirUsingPOSTWithHttpInfo(id, transferenciaBancariaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{transferencia_bancaria_resource_transferir}}} {{{transferencia_bancaria_resource_transferir_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_transferir_param_id}}}</param> 
        /// <param name="transferenciaBancariaPersist">transferenciaBancariaPersist</param> 
        /// <returns>ApiResponse of TransferenciaBancariaResponse</returns>
        public ApiResponse< TransferenciaBancariaResponse > TransferirUsingPOSTWithHttpInfo (long? id, TransferenciaBancariaPersistValue transferenciaBancariaPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagtransferenciabancariaApi->TransferirUsingPOST");
            
            // verify the required parameter 'transferenciaBancariaPersist' is set
            if (transferenciaBancariaPersist == null)
                throw new ApiException(400, "Missing required parameter 'transferenciaBancariaPersist' when calling GlobaltagtransferenciabancariaApi->TransferirUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/transferencias-creditos-contas-bancarias";
    
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
            
            
            
            
            if (transferenciaBancariaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(transferenciaBancariaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transferenciaBancariaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling TransferirUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TransferirUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransferenciaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaBancariaResponse)));
            
        }

        
        /// <summary>
        /// {{{transferencia_bancaria_resource_transferir}}} {{{transferencia_bancaria_resource_transferir_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_transferir_param_id}}}</param>
        /// <param name="transferenciaBancariaPersist">transferenciaBancariaPersist</param>
        /// <returns>Task of TransferenciaBancariaResponse</returns>
        public async System.Threading.Tasks.Task<TransferenciaBancariaResponse> TransferirUsingPOSTAsync (long? id, TransferenciaBancariaPersistValue transferenciaBancariaPersist)
        {
             ApiResponse<TransferenciaBancariaResponse> localVarResponse = await TransferirUsingPOSTAsyncWithHttpInfo(id, transferenciaBancariaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{transferencia_bancaria_resource_transferir}}} {{{transferencia_bancaria_resource_transferir_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_bancaria_resource_transferir_param_id}}}</param>
        /// <param name="transferenciaBancariaPersist">transferenciaBancariaPersist</param>
        /// <returns>Task of ApiResponse (TransferenciaBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransferenciaBancariaResponse>> TransferirUsingPOSTAsyncWithHttpInfo (long? id, TransferenciaBancariaPersistValue transferenciaBancariaPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TransferirUsingPOST");
            // verify the required parameter 'transferenciaBancariaPersist' is set
            if (transferenciaBancariaPersist == null) throw new ApiException(400, "Missing required parameter 'transferenciaBancariaPersist' when calling TransferirUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/transferencias-creditos-contas-bancarias";
    
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
            
            
            
            
            if (transferenciaBancariaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(transferenciaBancariaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transferenciaBancariaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling TransferirUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TransferirUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransferenciaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaBancariaResponse)));
            
        }
        
    }
    
}
