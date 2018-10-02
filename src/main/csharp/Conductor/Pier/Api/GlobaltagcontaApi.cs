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
    public interface IGlobaltagcontaApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{conta_resource_ajustar_conta}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_ajustar_conta_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_ajustar_conta_param_id}}}</param>
        /// <param name="idTipoAjuste">{{{ajuste_persist_id_tipo_ajuste_value}}}</param>
        /// <param name="dataAjuste">{{{ajuste_persist_data_ajuste_value}}}</param>
        /// <param name="valorAjuste">{{{ajuste_persist_valor_ajuste_value}}}</param>
        /// <param name="login">login (optional)</param>
        /// <param name="identificadorExterno">{{{ajuste_persist_identificador_externo_value}}} (optional)</param>
        /// <param name="idTransacaoOriginal">{{{ajuste_persist_id_transacao_original}}} (optional)</param>
        /// <returns>AjusteFinanceiroResponse</returns>
        AjusteFinanceiroResponse AjustarContaUsingPOST1 (long? id, long? idTipoAjuste, string dataAjuste, double? valorAjuste, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null);
  
        /// <summary>
        /// {{{conta_resource_ajustar_conta}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_ajustar_conta_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_ajustar_conta_param_id}}}</param>
        /// <param name="idTipoAjuste">{{{ajuste_persist_id_tipo_ajuste_value}}}</param>
        /// <param name="dataAjuste">{{{ajuste_persist_data_ajuste_value}}}</param>
        /// <param name="valorAjuste">{{{ajuste_persist_valor_ajuste_value}}}</param>
        /// <param name="login">login (optional)</param>
        /// <param name="identificadorExterno">{{{ajuste_persist_identificador_externo_value}}} (optional)</param>
        /// <param name="idTransacaoOriginal">{{{ajuste_persist_id_transacao_original}}} (optional)</param>
        /// <returns>ApiResponse of AjusteFinanceiroResponse</returns>
        ApiResponse<AjusteFinanceiroResponse> AjustarContaUsingPOST1WithHttpInfo (long? id, long? idTipoAjuste, string dataAjuste, double? valorAjuste, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null);
        
        /// <summary>
        /// {{{conta_resource_alterar_produto}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_alterar_produto_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_alterar_produto_param_id}}}</param>
        /// <param name="request">request</param>
        /// <returns>string</returns>
        string AlterarProdutoUsingPOST (long? id, AlterarProdutoRequest request);
  
        /// <summary>
        /// {{{conta_resource_alterar_produto}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_alterar_produto_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_alterar_produto_param_id}}}</param>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> AlterarProdutoUsingPOSTWithHttpInfo (long? id, AlterarProdutoRequest request);
        
        /// <summary>
        /// {{{conta_resource_alterar_titular}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_alterar_titular_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_alterar_titular_param_id_conta}}}</param>
        /// <param name="idPessoa">{{{conta_resource_alterar_titular_param_id_pessoa}}}</param>
        /// <returns>ContaResponse</returns>
        ContaResponse AlterarTitularUsingPOST (long? id, long? idPessoa);
  
        /// <summary>
        /// {{{conta_resource_alterar_titular}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_alterar_titular_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_alterar_titular_param_id_conta}}}</param>
        /// <param name="idPessoa">{{{conta_resource_alterar_titular_param_id_pessoa}}}</param>
        /// <returns>ApiResponse of ContaResponse</returns>
        ApiResponse<ContaResponse> AlterarTitularUsingPOSTWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// {{{conta_resource_alterar_vencimento}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_alterar_vencimento_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_alterar_vencimento_param_id}}}</param>
        /// <param name="novoDiaVencimento">{{{conta_resource_alterar_vencimento_param_novo_dia_vencimento}}}</param>
        /// <returns>ContaResponse</returns>
        ContaResponse AlterarVencimentoUsingPUT (long? id, int? novoDiaVencimento);
  
        /// <summary>
        /// {{{conta_resource_alterar_vencimento}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_alterar_vencimento_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_alterar_vencimento_param_id}}}</param>
        /// <param name="novoDiaVencimento">{{{conta_resource_alterar_vencimento_param_novo_dia_vencimento}}}</param>
        /// <returns>ApiResponse of ContaResponse</returns>
        ApiResponse<ContaResponse> AlterarVencimentoUsingPUTWithHttpInfo (long? id, int? novoDiaVencimento);
        
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
        /// {{{conta_resource_bloquear}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_bloquear_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_bloquear_param_id}}}</param>
        /// <param name="idStatus">{{{conta_resource_bloquear_param_id_status}}}</param>
        /// <returns>ContaResponse</returns>
        ContaResponse BloquearUsingPOST1 (long? id, long? idStatus);
  
        /// <summary>
        /// {{{conta_resource_bloquear}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_bloquear_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_bloquear_param_id}}}</param>
        /// <param name="idStatus">{{{conta_resource_bloquear_param_id_status}}}</param>
        /// <returns>ApiResponse of ContaResponse</returns>
        ApiResponse<ContaResponse> BloquearUsingPOST1WithHttpInfo (long? id, long? idStatus);
        
        /// <summary>
        /// {{{aderir_pagamento_sabado_recurso_cadastrar}}}
        /// </summary>
        /// <remarks>
        /// {{{aderir_pagamento_sabado_recurso_cadastrar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{aderir_pagamento_sabado_recurso_cadastrar_param_id}}}</param>
        /// <returns>AdesaoPagamentoSabadoResponse</returns>
        AdesaoPagamentoSabadoResponse CadastrarUsingPOST (long? id);
  
        /// <summary>
        /// {{{aderir_pagamento_sabado_recurso_cadastrar}}}
        /// </summary>
        /// <remarks>
        /// {{{aderir_pagamento_sabado_recurso_cadastrar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{aderir_pagamento_sabado_recurso_cadastrar_param_id}}}</param>
        /// <returns>ApiResponse of AdesaoPagamentoSabadoResponse</returns>
        ApiResponse<AdesaoPagamentoSabadoResponse> CadastrarUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{conta_resource_cancelar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_cancelar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_cancelar_param_id}}}</param>
        /// <param name="idStatus">{{{conta_resource_cancelar_param_id_status}}}</param>
        /// <returns>ContaResponse</returns>
        ContaResponse CancelarUsingPOST1 (long? id, long? idStatus);
  
        /// <summary>
        /// {{{conta_resource_cancelar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_cancelar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_cancelar_param_id}}}</param>
        /// <param name="idStatus">{{{conta_resource_cancelar_param_id_status}}}</param>
        /// <returns>ApiResponse of ContaResponse</returns>
        ApiResponse<ContaResponse> CancelarUsingPOST1WithHttpInfo (long? id, long? idStatus);
        
        /// <summary>
        /// {{{conta_resource_consultar_beneficio_pagamento_atraso}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_consultar_beneficio_pagamento_atraso_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_beneficio_pagamento_atraso_param_id}}}</param>
        /// <returns>BeneficioPagamentoAtrasoResponse</returns>
        BeneficioPagamentoAtrasoResponse ConsultarBeneficioPagamentoAtrasoUsingGET (long? id);
  
        /// <summary>
        /// {{{conta_resource_consultar_beneficio_pagamento_atraso}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_consultar_beneficio_pagamento_atraso_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_beneficio_pagamento_atraso_param_id}}}</param>
        /// <returns>ApiResponse of BeneficioPagamentoAtrasoResponse</returns>
        ApiResponse<BeneficioPagamentoAtrasoResponse> ConsultarBeneficioPagamentoAtrasoUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{conta_resource_consultar_boleto_emitido}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_consultar_boleto_emitido_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_boleto_emitido_param_id}}}</param>
        /// <returns>BoletoResponse</returns>
        BoletoResponse ConsultarBoletoEmitidoUsingGET (long? id);
  
        /// <summary>
        /// {{{conta_resource_consultar_boleto_emitido}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_consultar_boleto_emitido_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_boleto_emitido_param_id}}}</param>
        /// <returns>ApiResponse of BoletoResponse</returns>
        ApiResponse<BoletoResponse> ConsultarBoletoEmitidoUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{conta_resource_consultar_divida_atualizada_cliente}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_consultar_divida_atualizada_cliente_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_divida_atualizada_cliente_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataVencimento">{{{divida_cliente_request_data_vencimento_value}}} (optional)</param>
        /// <param name="idEscritorioCobranca">{{{divida_cliente_request_id_escritorio_cobranca_value}}} (optional)</param>
        /// <returns>DividaClienteResponse</returns>
        DividaClienteResponse ConsultarDividaAtualizadaClienteUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, long? idEscritorioCobranca = null);
  
        /// <summary>
        /// {{{conta_resource_consultar_divida_atualizada_cliente}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_consultar_divida_atualizada_cliente_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_divida_atualizada_cliente_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataVencimento">{{{divida_cliente_request_data_vencimento_value}}} (optional)</param>
        /// <param name="idEscritorioCobranca">{{{divida_cliente_request_id_escritorio_cobranca_value}}} (optional)</param>
        /// <returns>ApiResponse of DividaClienteResponse</returns>
        ApiResponse<DividaClienteResponse> ConsultarDividaAtualizadaClienteUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, long? idEscritorioCobranca = null);
        
        /// <summary>
        /// {{{conta_resource_consultar_taxas_tarifas}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_consultar_taxas_tarifas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_taxas_tarifas_param_id_conta}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>PageTaxasRefinanciamentoResponse</returns>
        PageTaxasRefinanciamentoResponse ConsultarTaxasTarifasUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{conta_resource_consultar_taxas_tarifas}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_consultar_taxas_tarifas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_taxas_tarifas_param_id_conta}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of PageTaxasRefinanciamentoResponse</returns>
        ApiResponse<PageTaxasRefinanciamentoResponse> ConsultarTaxasTarifasUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{aderir_pagamento_sabado_recurso_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{aderir_pagamento_sabado_recurso_consultar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{aderir_pagamento_sabado_recurso_consultar_param_id}}}</param>
        /// <param name="dataVencimento">{{{aderir_pagamento_sabado_recurso_consultar_param_data_vencimento}}}</param>
        /// <returns>AdesaoPagamentoSabadoResponse</returns>
        AdesaoPagamentoSabadoResponse ConsultarUsingGET1 (long? id, string dataVencimento);
  
        /// <summary>
        /// {{{aderir_pagamento_sabado_recurso_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{aderir_pagamento_sabado_recurso_consultar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{aderir_pagamento_sabado_recurso_consultar_param_id}}}</param>
        /// <param name="dataVencimento">{{{aderir_pagamento_sabado_recurso_consultar_param_data_vencimento}}}</param>
        /// <returns>ApiResponse of AdesaoPagamentoSabadoResponse</returns>
        ApiResponse<AdesaoPagamentoSabadoResponse> ConsultarUsingGET1WithHttpInfo (long? id, string dataVencimento);
        
        /// <summary>
        /// {{{conta_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_param_id}}}</param>
        /// <returns>ContaDetalheResponse</returns>
        ContaDetalheResponse ConsultarUsingGET13 (long? id);
  
        /// <summary>
        /// {{{conta_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of ContaDetalheResponse</returns>
        ApiResponse<ContaDetalheResponse> ConsultarUsingGET13WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{transferencia_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_resource_consultar_param_id_conta}}}</param>
        /// <param name="idTransferencia">{{{transferencia_resource_consultar_param_id_transferencia}}}</param>
        /// <returns>TransferenciaDetalheResponse</returns>
        TransferenciaDetalheResponse ConsultarUsingGET45 (long? id, long? idTransferencia);
  
        /// <summary>
        /// {{{transferencia_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_resource_consultar_param_id_conta}}}</param>
        /// <param name="idTransferencia">{{{transferencia_resource_consultar_param_id_transferencia}}}</param>
        /// <returns>ApiResponse of TransferenciaDetalheResponse</returns>
        ApiResponse<TransferenciaDetalheResponse> ConsultarUsingGET45WithHttpInfo (long? id, long? idTransferencia);
        
        /// <summary>
        /// {{{conta_resource_cadastrar_conta_multiapp}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_cadastrar_conta_multiapp_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaMultiAppPersist">contaMultiAppPersist</param>
        /// <returns>ContaMultiAppResponse</returns>
        ContaMultiAppResponse CriarContasMultiAppUsingPOST (ContaMultiAppPersistValue contaMultiAppPersist);
  
        /// <summary>
        /// {{{conta_resource_cadastrar_conta_multiapp}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_cadastrar_conta_multiapp_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaMultiAppPersist">contaMultiAppPersist</param>
        /// <returns>ApiResponse of ContaMultiAppResponse</returns>
        ApiResponse<ContaMultiAppResponse> CriarContasMultiAppUsingPOSTWithHttpInfo (ContaMultiAppPersistValue contaMultiAppPersist);
        
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
        /// {{{conta_resource_gerar_boleto_recarga}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_gerar_boleto_recarga_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_boleto_recarga_param_id}}}</param>
        /// <param name="valor">{{{boleto_recarga_request_valor_value}}}</param>
        /// <param name="dataVencimento">{{{boleto_recarga_request_data_vencimento_value}}}</param>
        /// <returns>BoletoResponse</returns>
        BoletoResponse GerarBoletoRecargaUsingPOST (long? id, double? valor, string dataVencimento);
  
        /// <summary>
        /// {{{conta_resource_gerar_boleto_recarga}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_gerar_boleto_recarga_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_boleto_recarga_param_id}}}</param>
        /// <param name="valor">{{{boleto_recarga_request_valor_value}}}</param>
        /// <param name="dataVencimento">{{{boleto_recarga_request_data_vencimento_value}}}</param>
        /// <returns>ApiResponse of BoletoResponse</returns>
        ApiResponse<BoletoResponse> GerarBoletoRecargaUsingPOSTWithHttpInfo (long? id, double? valor, string dataVencimento);
        
        /// <summary>
        /// {{{conta_resource_gerar_cartao_embossing}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_gerar_cartao_embossing_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_cartao_embossing_param_id}}}</param>
        /// <param name="cartaoEmbossingRequest">cartaoEmbossingRequest</param>
        /// <returns>CartaoEmbossingResponse</returns>
        CartaoEmbossingResponse GerarCartaoEmbossingUsingPOST (long? id, CartaoEmbossingRequest cartaoEmbossingRequest);
  
        /// <summary>
        /// {{{conta_resource_gerar_cartao_embossing}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_gerar_cartao_embossing_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_cartao_embossing_param_id}}}</param>
        /// <param name="cartaoEmbossingRequest">cartaoEmbossingRequest</param>
        /// <returns>ApiResponse of CartaoEmbossingResponse</returns>
        ApiResponse<CartaoEmbossingResponse> GerarCartaoEmbossingUsingPOSTWithHttpInfo (long? id, CartaoEmbossingRequest cartaoEmbossingRequest);
        
        /// <summary>
        /// {{{conta_resource_gerar_cartao_provisorio}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_gerar_cartao_provisorio_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_cartao_provisorio_param_id_conta}}}</param>
        /// <returns>CartaoImpressaoProvisorioResponse</returns>
        CartaoImpressaoProvisorioResponse GerarCartaoProvisorioUsingPOST (long? id);
  
        /// <summary>
        /// {{{conta_resource_gerar_cartao_provisorio}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_gerar_cartao_provisorio_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_cartao_provisorio_param_id_conta}}}</param>
        /// <returns>ApiResponse of CartaoImpressaoProvisorioResponse</returns>
        ApiResponse<CartaoImpressaoProvisorioResponse> GerarCartaoProvisorioUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{conta_resource_gerar_cartao}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_gerar_cartao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_cartao_param_id}}}</param>
        /// <param name="idPessoa">{{{conta_resource_gerar_cartao_param_id_pessoa}}}</param>
        /// <param name="idTipoPlastico">{{{conta_resource_gerar_cartao_param_id_tipo_plastico}}} (optional)</param>
        /// <returns>CartaoImpressaoResponse</returns>
        CartaoImpressaoResponse GerarCartaoUsingPOST (long? id, long? idPessoa, long? idTipoPlastico = null);
  
        /// <summary>
        /// {{{conta_resource_gerar_cartao}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_gerar_cartao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_cartao_param_id}}}</param>
        /// <param name="idPessoa">{{{conta_resource_gerar_cartao_param_id_pessoa}}}</param>
        /// <param name="idTipoPlastico">{{{conta_resource_gerar_cartao_param_id_tipo_plastico}}} (optional)</param>
        /// <returns>ApiResponse of CartaoImpressaoResponse</returns>
        ApiResponse<CartaoImpressaoResponse> GerarCartaoUsingPOSTWithHttpInfo (long? id, long? idPessoa, long? idTipoPlastico = null);
        
        /// <summary>
        /// {{{conta_resource_gerar_cartao_virtual}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_gerar_cartao_virtual_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_cartao_virtual_param_id}}}</param>
        /// <param name="dataValidade">{{{conta_resource_gerar_cartao_virtual_param_data_validade}}}</param>
        /// <returns>CartaoImpressaoResponse</returns>
        CartaoImpressaoResponse GerarCartaoVirtualUsingPOST (long? id, string dataValidade);
  
        /// <summary>
        /// {{{conta_resource_gerar_cartao_virtual}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_gerar_cartao_virtual_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_cartao_virtual_param_id}}}</param>
        /// <param name="dataValidade">{{{conta_resource_gerar_cartao_virtual_param_data_validade}}}</param>
        /// <returns>ApiResponse of CartaoImpressaoResponse</returns>
        ApiResponse<CartaoImpressaoResponse> GerarCartaoVirtualUsingPOSTWithHttpInfo (long? id, string dataValidade);
        
        /// <summary>
        /// {{{conta_resource_listar_historico_alteracoes_limites}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_listar_historico_alteracoes_limites_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_listar_historico_alteracoes_limites_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>PageHistoricoEventosResponse</returns>
        PageHistoricoEventosResponse ListarHistoricoAlteracoesLimitesUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{conta_resource_listar_historico_alteracoes_limites}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_listar_historico_alteracoes_limites_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_listar_historico_alteracoes_limites_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of PageHistoricoEventosResponse</returns>
        ApiResponse<PageHistoricoEventosResponse> ListarHistoricoAlteracoesLimitesUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{conta_resource_listar_historico_assessoria}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_listar_historico_assessoria_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_listar_historico_assessoria_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>PageHistoricoAssessoriaResponse</returns>
        PageHistoricoAssessoriaResponse ListarHistoricoAssessoriaUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{conta_resource_listar_historico_assessoria}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_listar_historico_assessoria_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_listar_historico_assessoria_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of PageHistoricoAssessoriaResponse</returns>
        ApiResponse<PageHistoricoAssessoriaResponse> ListarHistoricoAssessoriaUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{conta_resource_listar_historico_atrasos_faturas}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_listar_historico_atrasos_faturas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_listar_historico_atrasos_faturas_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>PageHistoricoAtrasoFaturaResponse</returns>
        PageHistoricoAtrasoFaturaResponse ListarHistoricoAtrasosFaturasUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{conta_resource_listar_historico_atrasos_faturas}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_listar_historico_atrasos_faturas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_listar_historico_atrasos_faturas_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of PageHistoricoAtrasoFaturaResponse</returns>
        ApiResponse<PageHistoricoAtrasoFaturaResponse> ListarHistoricoAtrasosFaturasUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{transacoes_correntes_resource_listar_nao_processadas}}}
        /// </summary>
        /// <remarks>
        /// {{{transacoes_correntes_resource_listar_nao_processadas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transacoes_correntes_resource_listar_nao_processadas_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataInicio">{{{transacoes_nao_processadas_request_data_inicio_value}}} (optional)</param>
        /// <param name="dataFim">{{{transacoes_nao_processadas_request_data_fim_value}}} (optional)</param>
        /// <returns>PageTransacaoNaoProcessadaResponse</returns>
        PageTransacaoNaoProcessadaResponse ListarNaoProcessadasUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null);
  
        /// <summary>
        /// {{{transacoes_correntes_resource_listar_nao_processadas}}}
        /// </summary>
        /// <remarks>
        /// {{{transacoes_correntes_resource_listar_nao_processadas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transacoes_correntes_resource_listar_nao_processadas_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataInicio">{{{transacoes_nao_processadas_request_data_inicio_value}}} (optional)</param>
        /// <param name="dataFim">{{{transacoes_nao_processadas_request_data_fim_value}}} (optional)</param>
        /// <returns>ApiResponse of PageTransacaoNaoProcessadaResponse</returns>
        ApiResponse<PageTransacaoNaoProcessadaResponse> ListarNaoProcessadasUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null);
        
        /// <summary>
        /// {{{transacoes_correntes_resource_listar_processadas}}}
        /// </summary>
        /// <remarks>
        /// {{{transacoes_correntes_resource_listar_processadas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transacoes_correntes_resource_listar_processadas_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataVencimento">{{{transacoes_processadas_request_data_vencimento_value}}} (optional)</param>
        /// <param name="dataInicio">{{{transacoes_processadas_request_data_inicio_value}}} (optional)</param>
        /// <param name="dataFim">{{{transacoes_processadas_request_data_fim_value}}} (optional)</param>
        /// <param name="idTipoTransacao">{{{transacoes_processadas_request_tipo_transacao}}} (optional)</param>
        /// <param name="recuperaEncargos">{{{transacoes_processadas_request_recupera_encargos}}} (optional)</param>
        /// <returns>PageTransacoesCorrentesResponse</returns>
        PageTransacoesCorrentesResponse ListarProcessadasUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, int? recuperaEncargos = null);
  
        /// <summary>
        /// {{{transacoes_correntes_resource_listar_processadas}}}
        /// </summary>
        /// <remarks>
        /// {{{transacoes_correntes_resource_listar_processadas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transacoes_correntes_resource_listar_processadas_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataVencimento">{{{transacoes_processadas_request_data_vencimento_value}}} (optional)</param>
        /// <param name="dataInicio">{{{transacoes_processadas_request_data_inicio_value}}} (optional)</param>
        /// <param name="dataFim">{{{transacoes_processadas_request_data_fim_value}}} (optional)</param>
        /// <param name="idTipoTransacao">{{{transacoes_processadas_request_tipo_transacao}}} (optional)</param>
        /// <param name="recuperaEncargos">{{{transacoes_processadas_request_recupera_encargos}}} (optional)</param>
        /// <returns>ApiResponse of PageTransacoesCorrentesResponse</returns>
        ApiResponse<PageTransacoesCorrentesResponse> ListarProcessadasUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, int? recuperaEncargos = null);
        
        /// <summary>
        /// {{{conta_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idProduto">{{{conta_request_id_produto_value}}} (optional)</param>
        /// <param name="idOrigemComercial">{{{conta_request_id_origem_comercial_value}}} (optional)</param>
        /// <param name="idPessoa">{{{conta_request_id_pessoa_value}}} (optional)</param>
        /// <param name="idStatusConta">{{{conta_request_id_status_conta_value}}} (optional)</param>
        /// <param name="diaVencimento">{{{conta_request_dia_vencimento_value}}} (optional)</param>
        /// <param name="melhorDiaCompra">{{{conta_request_melhor_dia_compra_value}}} (optional)</param>
        /// <param name="dataStatusConta">{{{conta_request_data_status_conta_value}}} (optional)</param>
        /// <param name="dataCadastro">{{{conta_request_data_cadastro_value}}} (optional)</param>
        /// <param name="dataUltimaAlteracaoVencimento">{{{conta_request_data_ultima_alteracao_vencimento_value}}} (optional)</param>
        /// <returns>PageContaResponse</returns>
        PageContaResponse ListarUsingGET17 (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, string dataStatusConta = null, string dataCadastro = null, string dataUltimaAlteracaoVencimento = null);
  
        /// <summary>
        /// {{{conta_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idProduto">{{{conta_request_id_produto_value}}} (optional)</param>
        /// <param name="idOrigemComercial">{{{conta_request_id_origem_comercial_value}}} (optional)</param>
        /// <param name="idPessoa">{{{conta_request_id_pessoa_value}}} (optional)</param>
        /// <param name="idStatusConta">{{{conta_request_id_status_conta_value}}} (optional)</param>
        /// <param name="diaVencimento">{{{conta_request_dia_vencimento_value}}} (optional)</param>
        /// <param name="melhorDiaCompra">{{{conta_request_melhor_dia_compra_value}}} (optional)</param>
        /// <param name="dataStatusConta">{{{conta_request_data_status_conta_value}}} (optional)</param>
        /// <param name="dataCadastro">{{{conta_request_data_cadastro_value}}} (optional)</param>
        /// <param name="dataUltimaAlteracaoVencimento">{{{conta_request_data_ultima_alteracao_vencimento_value}}} (optional)</param>
        /// <returns>ApiResponse of PageContaResponse</returns>
        ApiResponse<PageContaResponse> ListarUsingGET17WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, string dataStatusConta = null, string dataCadastro = null, string dataUltimaAlteracaoVencimento = null);
        
        /// <summary>
        /// {{{transacoes_correntes_resource_listar_nao_processadas_e_processadas}}}
        /// </summary>
        /// <remarks>
        /// {{{transacoes_correntes_resource_listar_nao_processadas_e_processadas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transacoes_correntes_resource_listar_nao_processadas_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataVencimento">{{{transacoes_processadas_request_data_vencimento_value}}} (optional)</param>
        /// <param name="dataInicio">{{{transacoes_processadas_request_data_inicio_value}}} (optional)</param>
        /// <param name="dataFim">{{{transacoes_processadas_request_data_fim_value}}} (optional)</param>
        /// <param name="idTipoTransacao">{{{transacoes_processadas_request_tipo_transacao}}} (optional)</param>
        /// <param name="flagCredito">{{{transacoes_processadas_request_flag_credito}}} (optional)</param>
        /// <param name="flagFaturado">{{{transacoes_processadas_request_flag_faturado}}} (optional)</param>
        /// <param name="flagProcessada">{{{transacoes_processadas_request_flag_processada}}} (optional)</param>
        /// <param name="status">{{{transacoes_processadas_request_status}}} (optional)</param>
        /// <param name="plano">{{{transacoes_processadas_request_plano}}} (optional)</param>
        /// <param name="codigoMCC">{{{transacoes_processadas_request_codigo_mcc}}} (optional)</param>
        /// <param name="grupoMCC">{{{transacoes_processadas_request_grupo_mcc}}} (optional)</param>
        /// <returns>PageTransacaoProcessadaNaoProcessadaResponse</returns>
        PageTransacaoProcessadaNaoProcessadaResponse ListarUsingGET53 (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, bool? flagCredito = null, bool? flagFaturado = null, bool? flagProcessada = null, int? status = null, int? plano = null, long? codigoMCC = null, long? grupoMCC = null);
  
        /// <summary>
        /// {{{transacoes_correntes_resource_listar_nao_processadas_e_processadas}}}
        /// </summary>
        /// <remarks>
        /// {{{transacoes_correntes_resource_listar_nao_processadas_e_processadas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transacoes_correntes_resource_listar_nao_processadas_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataVencimento">{{{transacoes_processadas_request_data_vencimento_value}}} (optional)</param>
        /// <param name="dataInicio">{{{transacoes_processadas_request_data_inicio_value}}} (optional)</param>
        /// <param name="dataFim">{{{transacoes_processadas_request_data_fim_value}}} (optional)</param>
        /// <param name="idTipoTransacao">{{{transacoes_processadas_request_tipo_transacao}}} (optional)</param>
        /// <param name="flagCredito">{{{transacoes_processadas_request_flag_credito}}} (optional)</param>
        /// <param name="flagFaturado">{{{transacoes_processadas_request_flag_faturado}}} (optional)</param>
        /// <param name="flagProcessada">{{{transacoes_processadas_request_flag_processada}}} (optional)</param>
        /// <param name="status">{{{transacoes_processadas_request_status}}} (optional)</param>
        /// <param name="plano">{{{transacoes_processadas_request_plano}}} (optional)</param>
        /// <param name="codigoMCC">{{{transacoes_processadas_request_codigo_mcc}}} (optional)</param>
        /// <param name="grupoMCC">{{{transacoes_processadas_request_grupo_mcc}}} (optional)</param>
        /// <returns>ApiResponse of PageTransacaoProcessadaNaoProcessadaResponse</returns>
        ApiResponse<PageTransacaoProcessadaNaoProcessadaResponse> ListarUsingGET53WithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, bool? flagCredito = null, bool? flagFaturado = null, bool? flagProcessada = null, int? status = null, int? plano = null, long? codigoMCC = null, long? grupoMCC = null);
        
        /// <summary>
        /// {{{transferencia_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_resource_listar_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTransferencia">{{{transferencia_request_id_transferencia_value}}} (optional)</param>
        /// <param name="idContaOrigem">{{{transferencia_request_id_conta_origem_value}}} (optional)</param>
        /// <param name="idContaDestino">{{{transferencia_request_id_conta_destino_value}}} (optional)</param>
        /// <param name="valorTransferencia">{{{transferencia_request_valor_transferencia_value}}} (optional)</param>
        /// <param name="dataTransferencia">{{{transferencia_request_data_transferencia_value}}} (optional)</param>
        /// <returns>PageTransferenciaResponse</returns>
        PageTransferenciaResponse ListarUsingGET55 (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, string dataTransferencia = null);
  
        /// <summary>
        /// {{{transferencia_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_resource_listar_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTransferencia">{{{transferencia_request_id_transferencia_value}}} (optional)</param>
        /// <param name="idContaOrigem">{{{transferencia_request_id_conta_origem_value}}} (optional)</param>
        /// <param name="idContaDestino">{{{transferencia_request_id_conta_destino_value}}} (optional)</param>
        /// <param name="valorTransferencia">{{{transferencia_request_valor_transferencia_value}}} (optional)</param>
        /// <param name="dataTransferencia">{{{transferencia_request_data_transferencia_value}}} (optional)</param>
        /// <returns>ApiResponse of PageTransferenciaResponse</returns>
        ApiResponse<PageTransferenciaResponse> ListarUsingGET55WithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, string dataTransferencia = null);
        
        /// <summary>
        /// {{{conta_resource_reativar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_reativar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_reativar_param_id}}}</param>
        /// <returns>Object</returns>
        Object ReativarUsingPOST1 (long? id);
  
        /// <summary>
        /// {{{conta_resource_reativar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_reativar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_reativar_param_id}}}</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ReativarUsingPOST1WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{conta_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaPersist">contaPersist</param>
        /// <returns>ContaResponse</returns>
        ContaResponse SalvarUsingPOST7 (ContaPersistValue contaPersist);
  
        /// <summary>
        /// {{{conta_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaPersist">contaPersist</param>
        /// <returns>ApiResponse of ContaResponse</returns>
        ApiResponse<ContaResponse> SalvarUsingPOST7WithHttpInfo (ContaPersistValue contaPersist);
        
        /// <summary>
        /// {{{financiamento_resource_simular_emprestimo_financiamento}}}
        /// </summary>
        /// <remarks>
        /// {{{financiamento_resource_simular_emprestimo_financiamento_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{financiamento_resource_simular_emprestimo_financiamento_param_id_conta}}}</param>
        /// <param name="request">request</param>
        /// <returns>EmprestimoPessoalResponse</returns>
        EmprestimoPessoalResponse SimularEmprestimoFinanciamentoUsingPOST (long? id, EmprestimoPessoalRequest request);
  
        /// <summary>
        /// {{{financiamento_resource_simular_emprestimo_financiamento}}}
        /// </summary>
        /// <remarks>
        /// {{{financiamento_resource_simular_emprestimo_financiamento_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{financiamento_resource_simular_emprestimo_financiamento_param_id_conta}}}</param>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of EmprestimoPessoalResponse</returns>
        ApiResponse<EmprestimoPessoalResponse> SimularEmprestimoFinanciamentoUsingPOSTWithHttpInfo (long? id, EmprestimoPessoalRequest request);
        
        /// <summary>
        /// {{{conta_resource_transacoes}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_transacoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_transacoes_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>PageTransacaoResponse</returns>
        PageTransacaoResponse TransacoesUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{conta_resource_transacoes}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_transacoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_transacoes_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of PageTransacaoResponse</returns>
        ApiResponse<PageTransacaoResponse> TransacoesUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{transferencia_resource_transferir}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_resource_transferir_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_resource_transferir_param_id_conta_origem}}}</param>
        /// <param name="idContaDestino">{{{transferencia_resource_transferir_param_id_conta_destino}}}</param>
        /// <param name="valorTransferencia">{{{transferencia_resource_transferir_param_valor_transferencia}}}</param>
        /// <returns>TransferenciaDetalheResponse</returns>
        TransferenciaDetalheResponse TransferirUsingPOST1 (long? id, long? idContaDestino, double? valorTransferencia);
  
        /// <summary>
        /// {{{transferencia_resource_transferir}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_resource_transferir_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_resource_transferir_param_id_conta_origem}}}</param>
        /// <param name="idContaDestino">{{{transferencia_resource_transferir_param_id_conta_destino}}}</param>
        /// <param name="valorTransferencia">{{{transferencia_resource_transferir_param_valor_transferencia}}}</param>
        /// <returns>ApiResponse of TransferenciaDetalheResponse</returns>
        ApiResponse<TransferenciaDetalheResponse> TransferirUsingPOST1WithHttpInfo (long? id, long? idContaDestino, double? valorTransferencia);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{conta_resource_ajustar_conta}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_ajustar_conta_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_ajustar_conta_param_id}}}</param>
        /// <param name="idTipoAjuste">{{{ajuste_persist_id_tipo_ajuste_value}}}</param>
        /// <param name="dataAjuste">{{{ajuste_persist_data_ajuste_value}}}</param>
        /// <param name="valorAjuste">{{{ajuste_persist_valor_ajuste_value}}}</param>
        /// <param name="login">login (optional)</param>
        /// <param name="identificadorExterno">{{{ajuste_persist_identificador_externo_value}}} (optional)</param>
        /// <param name="idTransacaoOriginal">{{{ajuste_persist_id_transacao_original}}} (optional)</param>
        /// <returns>Task of AjusteFinanceiroResponse</returns>
        System.Threading.Tasks.Task<AjusteFinanceiroResponse> AjustarContaUsingPOST1Async (long? id, long? idTipoAjuste, string dataAjuste, double? valorAjuste, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null);

        /// <summary>
        /// {{{conta_resource_ajustar_conta}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_ajustar_conta_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_ajustar_conta_param_id}}}</param>
        /// <param name="idTipoAjuste">{{{ajuste_persist_id_tipo_ajuste_value}}}</param>
        /// <param name="dataAjuste">{{{ajuste_persist_data_ajuste_value}}}</param>
        /// <param name="valorAjuste">{{{ajuste_persist_valor_ajuste_value}}}</param>
        /// <param name="login">login (optional)</param>
        /// <param name="identificadorExterno">{{{ajuste_persist_identificador_externo_value}}} (optional)</param>
        /// <param name="idTransacaoOriginal">{{{ajuste_persist_id_transacao_original}}} (optional)</param>
        /// <returns>Task of ApiResponse (AjusteFinanceiroResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AjusteFinanceiroResponse>> AjustarContaUsingPOST1AsyncWithHttpInfo (long? id, long? idTipoAjuste, string dataAjuste, double? valorAjuste, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null);
        
        /// <summary>
        /// {{{conta_resource_alterar_produto}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_alterar_produto_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_alterar_produto_param_id}}}</param>
        /// <param name="request">request</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> AlterarProdutoUsingPOSTAsync (long? id, AlterarProdutoRequest request);

        /// <summary>
        /// {{{conta_resource_alterar_produto}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_alterar_produto_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_alterar_produto_param_id}}}</param>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> AlterarProdutoUsingPOSTAsyncWithHttpInfo (long? id, AlterarProdutoRequest request);
        
        /// <summary>
        /// {{{conta_resource_alterar_titular}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_alterar_titular_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_alterar_titular_param_id_conta}}}</param>
        /// <param name="idPessoa">{{{conta_resource_alterar_titular_param_id_pessoa}}}</param>
        /// <returns>Task of ContaResponse</returns>
        System.Threading.Tasks.Task<ContaResponse> AlterarTitularUsingPOSTAsync (long? id, long? idPessoa);

        /// <summary>
        /// {{{conta_resource_alterar_titular}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_alterar_titular_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_alterar_titular_param_id_conta}}}</param>
        /// <param name="idPessoa">{{{conta_resource_alterar_titular_param_id_pessoa}}}</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaResponse>> AlterarTitularUsingPOSTAsyncWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// {{{conta_resource_alterar_vencimento}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_alterar_vencimento_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_alterar_vencimento_param_id}}}</param>
        /// <param name="novoDiaVencimento">{{{conta_resource_alterar_vencimento_param_novo_dia_vencimento}}}</param>
        /// <returns>Task of ContaResponse</returns>
        System.Threading.Tasks.Task<ContaResponse> AlterarVencimentoUsingPUTAsync (long? id, int? novoDiaVencimento);

        /// <summary>
        /// {{{conta_resource_alterar_vencimento}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_alterar_vencimento_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_alterar_vencimento_param_id}}}</param>
        /// <param name="novoDiaVencimento">{{{conta_resource_alterar_vencimento_param_novo_dia_vencimento}}}</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaResponse>> AlterarVencimentoUsingPUTAsyncWithHttpInfo (long? id, int? novoDiaVencimento);
        
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
        /// {{{conta_resource_bloquear}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_bloquear_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_bloquear_param_id}}}</param>
        /// <param name="idStatus">{{{conta_resource_bloquear_param_id_status}}}</param>
        /// <returns>Task of ContaResponse</returns>
        System.Threading.Tasks.Task<ContaResponse> BloquearUsingPOST1Async (long? id, long? idStatus);

        /// <summary>
        /// {{{conta_resource_bloquear}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_bloquear_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_bloquear_param_id}}}</param>
        /// <param name="idStatus">{{{conta_resource_bloquear_param_id_status}}}</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaResponse>> BloquearUsingPOST1AsyncWithHttpInfo (long? id, long? idStatus);
        
        /// <summary>
        /// {{{aderir_pagamento_sabado_recurso_cadastrar}}}
        /// </summary>
        /// <remarks>
        /// {{{aderir_pagamento_sabado_recurso_cadastrar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{aderir_pagamento_sabado_recurso_cadastrar_param_id}}}</param>
        /// <returns>Task of AdesaoPagamentoSabadoResponse</returns>
        System.Threading.Tasks.Task<AdesaoPagamentoSabadoResponse> CadastrarUsingPOSTAsync (long? id);

        /// <summary>
        /// {{{aderir_pagamento_sabado_recurso_cadastrar}}}
        /// </summary>
        /// <remarks>
        /// {{{aderir_pagamento_sabado_recurso_cadastrar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{aderir_pagamento_sabado_recurso_cadastrar_param_id}}}</param>
        /// <returns>Task of ApiResponse (AdesaoPagamentoSabadoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdesaoPagamentoSabadoResponse>> CadastrarUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{conta_resource_cancelar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_cancelar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_cancelar_param_id}}}</param>
        /// <param name="idStatus">{{{conta_resource_cancelar_param_id_status}}}</param>
        /// <returns>Task of ContaResponse</returns>
        System.Threading.Tasks.Task<ContaResponse> CancelarUsingPOST1Async (long? id, long? idStatus);

        /// <summary>
        /// {{{conta_resource_cancelar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_cancelar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_cancelar_param_id}}}</param>
        /// <param name="idStatus">{{{conta_resource_cancelar_param_id_status}}}</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaResponse>> CancelarUsingPOST1AsyncWithHttpInfo (long? id, long? idStatus);
        
        /// <summary>
        /// {{{conta_resource_consultar_beneficio_pagamento_atraso}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_consultar_beneficio_pagamento_atraso_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_beneficio_pagamento_atraso_param_id}}}</param>
        /// <returns>Task of BeneficioPagamentoAtrasoResponse</returns>
        System.Threading.Tasks.Task<BeneficioPagamentoAtrasoResponse> ConsultarBeneficioPagamentoAtrasoUsingGETAsync (long? id);

        /// <summary>
        /// {{{conta_resource_consultar_beneficio_pagamento_atraso}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_consultar_beneficio_pagamento_atraso_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_beneficio_pagamento_atraso_param_id}}}</param>
        /// <returns>Task of ApiResponse (BeneficioPagamentoAtrasoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BeneficioPagamentoAtrasoResponse>> ConsultarBeneficioPagamentoAtrasoUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{conta_resource_consultar_boleto_emitido}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_consultar_boleto_emitido_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_boleto_emitido_param_id}}}</param>
        /// <returns>Task of BoletoResponse</returns>
        System.Threading.Tasks.Task<BoletoResponse> ConsultarBoletoEmitidoUsingGETAsync (long? id);

        /// <summary>
        /// {{{conta_resource_consultar_boleto_emitido}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_consultar_boleto_emitido_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_boleto_emitido_param_id}}}</param>
        /// <returns>Task of ApiResponse (BoletoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BoletoResponse>> ConsultarBoletoEmitidoUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{conta_resource_consultar_divida_atualizada_cliente}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_consultar_divida_atualizada_cliente_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_divida_atualizada_cliente_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataVencimento">{{{divida_cliente_request_data_vencimento_value}}} (optional)</param>
        /// <param name="idEscritorioCobranca">{{{divida_cliente_request_id_escritorio_cobranca_value}}} (optional)</param>
        /// <returns>Task of DividaClienteResponse</returns>
        System.Threading.Tasks.Task<DividaClienteResponse> ConsultarDividaAtualizadaClienteUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, long? idEscritorioCobranca = null);

        /// <summary>
        /// {{{conta_resource_consultar_divida_atualizada_cliente}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_consultar_divida_atualizada_cliente_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_divida_atualizada_cliente_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataVencimento">{{{divida_cliente_request_data_vencimento_value}}} (optional)</param>
        /// <param name="idEscritorioCobranca">{{{divida_cliente_request_id_escritorio_cobranca_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (DividaClienteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DividaClienteResponse>> ConsultarDividaAtualizadaClienteUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, long? idEscritorioCobranca = null);
        
        /// <summary>
        /// {{{conta_resource_consultar_taxas_tarifas}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_consultar_taxas_tarifas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_taxas_tarifas_param_id_conta}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageTaxasRefinanciamentoResponse</returns>
        System.Threading.Tasks.Task<PageTaxasRefinanciamentoResponse> ConsultarTaxasTarifasUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{conta_resource_consultar_taxas_tarifas}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_consultar_taxas_tarifas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_taxas_tarifas_param_id_conta}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTaxasRefinanciamentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTaxasRefinanciamentoResponse>> ConsultarTaxasTarifasUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{aderir_pagamento_sabado_recurso_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{aderir_pagamento_sabado_recurso_consultar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{aderir_pagamento_sabado_recurso_consultar_param_id}}}</param>
        /// <param name="dataVencimento">{{{aderir_pagamento_sabado_recurso_consultar_param_data_vencimento}}}</param>
        /// <returns>Task of AdesaoPagamentoSabadoResponse</returns>
        System.Threading.Tasks.Task<AdesaoPagamentoSabadoResponse> ConsultarUsingGET1Async (long? id, string dataVencimento);

        /// <summary>
        /// {{{aderir_pagamento_sabado_recurso_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{aderir_pagamento_sabado_recurso_consultar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{aderir_pagamento_sabado_recurso_consultar_param_id}}}</param>
        /// <param name="dataVencimento">{{{aderir_pagamento_sabado_recurso_consultar_param_data_vencimento}}}</param>
        /// <returns>Task of ApiResponse (AdesaoPagamentoSabadoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdesaoPagamentoSabadoResponse>> ConsultarUsingGET1AsyncWithHttpInfo (long? id, string dataVencimento);
        
        /// <summary>
        /// {{{conta_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_param_id}}}</param>
        /// <returns>Task of ContaDetalheResponse</returns>
        System.Threading.Tasks.Task<ContaDetalheResponse> ConsultarUsingGET13Async (long? id);

        /// <summary>
        /// {{{conta_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (ContaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaDetalheResponse>> ConsultarUsingGET13AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{transferencia_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_resource_consultar_param_id_conta}}}</param>
        /// <param name="idTransferencia">{{{transferencia_resource_consultar_param_id_transferencia}}}</param>
        /// <returns>Task of TransferenciaDetalheResponse</returns>
        System.Threading.Tasks.Task<TransferenciaDetalheResponse> ConsultarUsingGET45Async (long? id, long? idTransferencia);

        /// <summary>
        /// {{{transferencia_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_resource_consultar_param_id_conta}}}</param>
        /// <param name="idTransferencia">{{{transferencia_resource_consultar_param_id_transferencia}}}</param>
        /// <returns>Task of ApiResponse (TransferenciaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransferenciaDetalheResponse>> ConsultarUsingGET45AsyncWithHttpInfo (long? id, long? idTransferencia);
        
        /// <summary>
        /// {{{conta_resource_cadastrar_conta_multiapp}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_cadastrar_conta_multiapp_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaMultiAppPersist">contaMultiAppPersist</param>
        /// <returns>Task of ContaMultiAppResponse</returns>
        System.Threading.Tasks.Task<ContaMultiAppResponse> CriarContasMultiAppUsingPOSTAsync (ContaMultiAppPersistValue contaMultiAppPersist);

        /// <summary>
        /// {{{conta_resource_cadastrar_conta_multiapp}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_cadastrar_conta_multiapp_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaMultiAppPersist">contaMultiAppPersist</param>
        /// <returns>Task of ApiResponse (ContaMultiAppResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaMultiAppResponse>> CriarContasMultiAppUsingPOSTAsyncWithHttpInfo (ContaMultiAppPersistValue contaMultiAppPersist);
        
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
        /// {{{conta_resource_gerar_boleto_recarga}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_gerar_boleto_recarga_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_boleto_recarga_param_id}}}</param>
        /// <param name="valor">{{{boleto_recarga_request_valor_value}}}</param>
        /// <param name="dataVencimento">{{{boleto_recarga_request_data_vencimento_value}}}</param>
        /// <returns>Task of BoletoResponse</returns>
        System.Threading.Tasks.Task<BoletoResponse> GerarBoletoRecargaUsingPOSTAsync (long? id, double? valor, string dataVencimento);

        /// <summary>
        /// {{{conta_resource_gerar_boleto_recarga}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_gerar_boleto_recarga_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_boleto_recarga_param_id}}}</param>
        /// <param name="valor">{{{boleto_recarga_request_valor_value}}}</param>
        /// <param name="dataVencimento">{{{boleto_recarga_request_data_vencimento_value}}}</param>
        /// <returns>Task of ApiResponse (BoletoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BoletoResponse>> GerarBoletoRecargaUsingPOSTAsyncWithHttpInfo (long? id, double? valor, string dataVencimento);
        
        /// <summary>
        /// {{{conta_resource_gerar_cartao_embossing}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_gerar_cartao_embossing_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_cartao_embossing_param_id}}}</param>
        /// <param name="cartaoEmbossingRequest">cartaoEmbossingRequest</param>
        /// <returns>Task of CartaoEmbossingResponse</returns>
        System.Threading.Tasks.Task<CartaoEmbossingResponse> GerarCartaoEmbossingUsingPOSTAsync (long? id, CartaoEmbossingRequest cartaoEmbossingRequest);

        /// <summary>
        /// {{{conta_resource_gerar_cartao_embossing}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_gerar_cartao_embossing_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_cartao_embossing_param_id}}}</param>
        /// <param name="cartaoEmbossingRequest">cartaoEmbossingRequest</param>
        /// <returns>Task of ApiResponse (CartaoEmbossingResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoEmbossingResponse>> GerarCartaoEmbossingUsingPOSTAsyncWithHttpInfo (long? id, CartaoEmbossingRequest cartaoEmbossingRequest);
        
        /// <summary>
        /// {{{conta_resource_gerar_cartao_provisorio}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_gerar_cartao_provisorio_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_cartao_provisorio_param_id_conta}}}</param>
        /// <returns>Task of CartaoImpressaoProvisorioResponse</returns>
        System.Threading.Tasks.Task<CartaoImpressaoProvisorioResponse> GerarCartaoProvisorioUsingPOSTAsync (long? id);

        /// <summary>
        /// {{{conta_resource_gerar_cartao_provisorio}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_gerar_cartao_provisorio_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_cartao_provisorio_param_id_conta}}}</param>
        /// <returns>Task of ApiResponse (CartaoImpressaoProvisorioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoImpressaoProvisorioResponse>> GerarCartaoProvisorioUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{conta_resource_gerar_cartao}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_gerar_cartao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_cartao_param_id}}}</param>
        /// <param name="idPessoa">{{{conta_resource_gerar_cartao_param_id_pessoa}}}</param>
        /// <param name="idTipoPlastico">{{{conta_resource_gerar_cartao_param_id_tipo_plastico}}} (optional)</param>
        /// <returns>Task of CartaoImpressaoResponse</returns>
        System.Threading.Tasks.Task<CartaoImpressaoResponse> GerarCartaoUsingPOSTAsync (long? id, long? idPessoa, long? idTipoPlastico = null);

        /// <summary>
        /// {{{conta_resource_gerar_cartao}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_gerar_cartao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_cartao_param_id}}}</param>
        /// <param name="idPessoa">{{{conta_resource_gerar_cartao_param_id_pessoa}}}</param>
        /// <param name="idTipoPlastico">{{{conta_resource_gerar_cartao_param_id_tipo_plastico}}} (optional)</param>
        /// <returns>Task of ApiResponse (CartaoImpressaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoImpressaoResponse>> GerarCartaoUsingPOSTAsyncWithHttpInfo (long? id, long? idPessoa, long? idTipoPlastico = null);
        
        /// <summary>
        /// {{{conta_resource_gerar_cartao_virtual}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_gerar_cartao_virtual_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_cartao_virtual_param_id}}}</param>
        /// <param name="dataValidade">{{{conta_resource_gerar_cartao_virtual_param_data_validade}}}</param>
        /// <returns>Task of CartaoImpressaoResponse</returns>
        System.Threading.Tasks.Task<CartaoImpressaoResponse> GerarCartaoVirtualUsingPOSTAsync (long? id, string dataValidade);

        /// <summary>
        /// {{{conta_resource_gerar_cartao_virtual}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_gerar_cartao_virtual_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_cartao_virtual_param_id}}}</param>
        /// <param name="dataValidade">{{{conta_resource_gerar_cartao_virtual_param_data_validade}}}</param>
        /// <returns>Task of ApiResponse (CartaoImpressaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoImpressaoResponse>> GerarCartaoVirtualUsingPOSTAsyncWithHttpInfo (long? id, string dataValidade);
        
        /// <summary>
        /// {{{conta_resource_listar_historico_alteracoes_limites}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_listar_historico_alteracoes_limites_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_listar_historico_alteracoes_limites_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageHistoricoEventosResponse</returns>
        System.Threading.Tasks.Task<PageHistoricoEventosResponse> ListarHistoricoAlteracoesLimitesUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{conta_resource_listar_historico_alteracoes_limites}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_listar_historico_alteracoes_limites_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_listar_historico_alteracoes_limites_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoEventosResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageHistoricoEventosResponse>> ListarHistoricoAlteracoesLimitesUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{conta_resource_listar_historico_assessoria}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_listar_historico_assessoria_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_listar_historico_assessoria_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageHistoricoAssessoriaResponse</returns>
        System.Threading.Tasks.Task<PageHistoricoAssessoriaResponse> ListarHistoricoAssessoriaUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{conta_resource_listar_historico_assessoria}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_listar_historico_assessoria_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_listar_historico_assessoria_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoAssessoriaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageHistoricoAssessoriaResponse>> ListarHistoricoAssessoriaUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{conta_resource_listar_historico_atrasos_faturas}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_listar_historico_atrasos_faturas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_listar_historico_atrasos_faturas_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageHistoricoAtrasoFaturaResponse</returns>
        System.Threading.Tasks.Task<PageHistoricoAtrasoFaturaResponse> ListarHistoricoAtrasosFaturasUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{conta_resource_listar_historico_atrasos_faturas}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_listar_historico_atrasos_faturas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_listar_historico_atrasos_faturas_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoAtrasoFaturaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageHistoricoAtrasoFaturaResponse>> ListarHistoricoAtrasosFaturasUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{transacoes_correntes_resource_listar_nao_processadas}}}
        /// </summary>
        /// <remarks>
        /// {{{transacoes_correntes_resource_listar_nao_processadas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transacoes_correntes_resource_listar_nao_processadas_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataInicio">{{{transacoes_nao_processadas_request_data_inicio_value}}} (optional)</param>
        /// <param name="dataFim">{{{transacoes_nao_processadas_request_data_fim_value}}} (optional)</param>
        /// <returns>Task of PageTransacaoNaoProcessadaResponse</returns>
        System.Threading.Tasks.Task<PageTransacaoNaoProcessadaResponse> ListarNaoProcessadasUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null);

        /// <summary>
        /// {{{transacoes_correntes_resource_listar_nao_processadas}}}
        /// </summary>
        /// <remarks>
        /// {{{transacoes_correntes_resource_listar_nao_processadas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transacoes_correntes_resource_listar_nao_processadas_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataInicio">{{{transacoes_nao_processadas_request_data_inicio_value}}} (optional)</param>
        /// <param name="dataFim">{{{transacoes_nao_processadas_request_data_fim_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacaoNaoProcessadaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransacaoNaoProcessadaResponse>> ListarNaoProcessadasUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null);
        
        /// <summary>
        /// {{{transacoes_correntes_resource_listar_processadas}}}
        /// </summary>
        /// <remarks>
        /// {{{transacoes_correntes_resource_listar_processadas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transacoes_correntes_resource_listar_processadas_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataVencimento">{{{transacoes_processadas_request_data_vencimento_value}}} (optional)</param>
        /// <param name="dataInicio">{{{transacoes_processadas_request_data_inicio_value}}} (optional)</param>
        /// <param name="dataFim">{{{transacoes_processadas_request_data_fim_value}}} (optional)</param>
        /// <param name="idTipoTransacao">{{{transacoes_processadas_request_tipo_transacao}}} (optional)</param>
        /// <param name="recuperaEncargos">{{{transacoes_processadas_request_recupera_encargos}}} (optional)</param>
        /// <returns>Task of PageTransacoesCorrentesResponse</returns>
        System.Threading.Tasks.Task<PageTransacoesCorrentesResponse> ListarProcessadasUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, int? recuperaEncargos = null);

        /// <summary>
        /// {{{transacoes_correntes_resource_listar_processadas}}}
        /// </summary>
        /// <remarks>
        /// {{{transacoes_correntes_resource_listar_processadas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transacoes_correntes_resource_listar_processadas_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataVencimento">{{{transacoes_processadas_request_data_vencimento_value}}} (optional)</param>
        /// <param name="dataInicio">{{{transacoes_processadas_request_data_inicio_value}}} (optional)</param>
        /// <param name="dataFim">{{{transacoes_processadas_request_data_fim_value}}} (optional)</param>
        /// <param name="idTipoTransacao">{{{transacoes_processadas_request_tipo_transacao}}} (optional)</param>
        /// <param name="recuperaEncargos">{{{transacoes_processadas_request_recupera_encargos}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacoesCorrentesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransacoesCorrentesResponse>> ListarProcessadasUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, int? recuperaEncargos = null);
        
        /// <summary>
        /// {{{conta_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idProduto">{{{conta_request_id_produto_value}}} (optional)</param>
        /// <param name="idOrigemComercial">{{{conta_request_id_origem_comercial_value}}} (optional)</param>
        /// <param name="idPessoa">{{{conta_request_id_pessoa_value}}} (optional)</param>
        /// <param name="idStatusConta">{{{conta_request_id_status_conta_value}}} (optional)</param>
        /// <param name="diaVencimento">{{{conta_request_dia_vencimento_value}}} (optional)</param>
        /// <param name="melhorDiaCompra">{{{conta_request_melhor_dia_compra_value}}} (optional)</param>
        /// <param name="dataStatusConta">{{{conta_request_data_status_conta_value}}} (optional)</param>
        /// <param name="dataCadastro">{{{conta_request_data_cadastro_value}}} (optional)</param>
        /// <param name="dataUltimaAlteracaoVencimento">{{{conta_request_data_ultima_alteracao_vencimento_value}}} (optional)</param>
        /// <returns>Task of PageContaResponse</returns>
        System.Threading.Tasks.Task<PageContaResponse> ListarUsingGET17Async (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, string dataStatusConta = null, string dataCadastro = null, string dataUltimaAlteracaoVencimento = null);

        /// <summary>
        /// {{{conta_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idProduto">{{{conta_request_id_produto_value}}} (optional)</param>
        /// <param name="idOrigemComercial">{{{conta_request_id_origem_comercial_value}}} (optional)</param>
        /// <param name="idPessoa">{{{conta_request_id_pessoa_value}}} (optional)</param>
        /// <param name="idStatusConta">{{{conta_request_id_status_conta_value}}} (optional)</param>
        /// <param name="diaVencimento">{{{conta_request_dia_vencimento_value}}} (optional)</param>
        /// <param name="melhorDiaCompra">{{{conta_request_melhor_dia_compra_value}}} (optional)</param>
        /// <param name="dataStatusConta">{{{conta_request_data_status_conta_value}}} (optional)</param>
        /// <param name="dataCadastro">{{{conta_request_data_cadastro_value}}} (optional)</param>
        /// <param name="dataUltimaAlteracaoVencimento">{{{conta_request_data_ultima_alteracao_vencimento_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageContaResponse>> ListarUsingGET17AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, string dataStatusConta = null, string dataCadastro = null, string dataUltimaAlteracaoVencimento = null);
        
        /// <summary>
        /// {{{transacoes_correntes_resource_listar_nao_processadas_e_processadas}}}
        /// </summary>
        /// <remarks>
        /// {{{transacoes_correntes_resource_listar_nao_processadas_e_processadas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transacoes_correntes_resource_listar_nao_processadas_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataVencimento">{{{transacoes_processadas_request_data_vencimento_value}}} (optional)</param>
        /// <param name="dataInicio">{{{transacoes_processadas_request_data_inicio_value}}} (optional)</param>
        /// <param name="dataFim">{{{transacoes_processadas_request_data_fim_value}}} (optional)</param>
        /// <param name="idTipoTransacao">{{{transacoes_processadas_request_tipo_transacao}}} (optional)</param>
        /// <param name="flagCredito">{{{transacoes_processadas_request_flag_credito}}} (optional)</param>
        /// <param name="flagFaturado">{{{transacoes_processadas_request_flag_faturado}}} (optional)</param>
        /// <param name="flagProcessada">{{{transacoes_processadas_request_flag_processada}}} (optional)</param>
        /// <param name="status">{{{transacoes_processadas_request_status}}} (optional)</param>
        /// <param name="plano">{{{transacoes_processadas_request_plano}}} (optional)</param>
        /// <param name="codigoMCC">{{{transacoes_processadas_request_codigo_mcc}}} (optional)</param>
        /// <param name="grupoMCC">{{{transacoes_processadas_request_grupo_mcc}}} (optional)</param>
        /// <returns>Task of PageTransacaoProcessadaNaoProcessadaResponse</returns>
        System.Threading.Tasks.Task<PageTransacaoProcessadaNaoProcessadaResponse> ListarUsingGET53Async (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, bool? flagCredito = null, bool? flagFaturado = null, bool? flagProcessada = null, int? status = null, int? plano = null, long? codigoMCC = null, long? grupoMCC = null);

        /// <summary>
        /// {{{transacoes_correntes_resource_listar_nao_processadas_e_processadas}}}
        /// </summary>
        /// <remarks>
        /// {{{transacoes_correntes_resource_listar_nao_processadas_e_processadas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transacoes_correntes_resource_listar_nao_processadas_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataVencimento">{{{transacoes_processadas_request_data_vencimento_value}}} (optional)</param>
        /// <param name="dataInicio">{{{transacoes_processadas_request_data_inicio_value}}} (optional)</param>
        /// <param name="dataFim">{{{transacoes_processadas_request_data_fim_value}}} (optional)</param>
        /// <param name="idTipoTransacao">{{{transacoes_processadas_request_tipo_transacao}}} (optional)</param>
        /// <param name="flagCredito">{{{transacoes_processadas_request_flag_credito}}} (optional)</param>
        /// <param name="flagFaturado">{{{transacoes_processadas_request_flag_faturado}}} (optional)</param>
        /// <param name="flagProcessada">{{{transacoes_processadas_request_flag_processada}}} (optional)</param>
        /// <param name="status">{{{transacoes_processadas_request_status}}} (optional)</param>
        /// <param name="plano">{{{transacoes_processadas_request_plano}}} (optional)</param>
        /// <param name="codigoMCC">{{{transacoes_processadas_request_codigo_mcc}}} (optional)</param>
        /// <param name="grupoMCC">{{{transacoes_processadas_request_grupo_mcc}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacaoProcessadaNaoProcessadaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransacaoProcessadaNaoProcessadaResponse>> ListarUsingGET53AsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, bool? flagCredito = null, bool? flagFaturado = null, bool? flagProcessada = null, int? status = null, int? plano = null, long? codigoMCC = null, long? grupoMCC = null);
        
        /// <summary>
        /// {{{transferencia_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_resource_listar_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTransferencia">{{{transferencia_request_id_transferencia_value}}} (optional)</param>
        /// <param name="idContaOrigem">{{{transferencia_request_id_conta_origem_value}}} (optional)</param>
        /// <param name="idContaDestino">{{{transferencia_request_id_conta_destino_value}}} (optional)</param>
        /// <param name="valorTransferencia">{{{transferencia_request_valor_transferencia_value}}} (optional)</param>
        /// <param name="dataTransferencia">{{{transferencia_request_data_transferencia_value}}} (optional)</param>
        /// <returns>Task of PageTransferenciaResponse</returns>
        System.Threading.Tasks.Task<PageTransferenciaResponse> ListarUsingGET55Async (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, string dataTransferencia = null);

        /// <summary>
        /// {{{transferencia_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_resource_listar_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTransferencia">{{{transferencia_request_id_transferencia_value}}} (optional)</param>
        /// <param name="idContaOrigem">{{{transferencia_request_id_conta_origem_value}}} (optional)</param>
        /// <param name="idContaDestino">{{{transferencia_request_id_conta_destino_value}}} (optional)</param>
        /// <param name="valorTransferencia">{{{transferencia_request_valor_transferencia_value}}} (optional)</param>
        /// <param name="dataTransferencia">{{{transferencia_request_data_transferencia_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTransferenciaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransferenciaResponse>> ListarUsingGET55AsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, string dataTransferencia = null);
        
        /// <summary>
        /// {{{conta_resource_reativar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_reativar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_reativar_param_id}}}</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ReativarUsingPOST1Async (long? id);

        /// <summary>
        /// {{{conta_resource_reativar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_reativar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_reativar_param_id}}}</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ReativarUsingPOST1AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{conta_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaPersist">contaPersist</param>
        /// <returns>Task of ContaResponse</returns>
        System.Threading.Tasks.Task<ContaResponse> SalvarUsingPOST7Async (ContaPersistValue contaPersist);

        /// <summary>
        /// {{{conta_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaPersist">contaPersist</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaResponse>> SalvarUsingPOST7AsyncWithHttpInfo (ContaPersistValue contaPersist);
        
        /// <summary>
        /// {{{financiamento_resource_simular_emprestimo_financiamento}}}
        /// </summary>
        /// <remarks>
        /// {{{financiamento_resource_simular_emprestimo_financiamento_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{financiamento_resource_simular_emprestimo_financiamento_param_id_conta}}}</param>
        /// <param name="request">request</param>
        /// <returns>Task of EmprestimoPessoalResponse</returns>
        System.Threading.Tasks.Task<EmprestimoPessoalResponse> SimularEmprestimoFinanciamentoUsingPOSTAsync (long? id, EmprestimoPessoalRequest request);

        /// <summary>
        /// {{{financiamento_resource_simular_emprestimo_financiamento}}}
        /// </summary>
        /// <remarks>
        /// {{{financiamento_resource_simular_emprestimo_financiamento_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{financiamento_resource_simular_emprestimo_financiamento_param_id_conta}}}</param>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (EmprestimoPessoalResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmprestimoPessoalResponse>> SimularEmprestimoFinanciamentoUsingPOSTAsyncWithHttpInfo (long? id, EmprestimoPessoalRequest request);
        
        /// <summary>
        /// {{{conta_resource_transacoes}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_transacoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_transacoes_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageTransacaoResponse</returns>
        System.Threading.Tasks.Task<PageTransacaoResponse> TransacoesUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{conta_resource_transacoes}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_transacoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_transacoes_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransacaoResponse>> TransacoesUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{transferencia_resource_transferir}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_resource_transferir_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_resource_transferir_param_id_conta_origem}}}</param>
        /// <param name="idContaDestino">{{{transferencia_resource_transferir_param_id_conta_destino}}}</param>
        /// <param name="valorTransferencia">{{{transferencia_resource_transferir_param_valor_transferencia}}}</param>
        /// <returns>Task of TransferenciaDetalheResponse</returns>
        System.Threading.Tasks.Task<TransferenciaDetalheResponse> TransferirUsingPOST1Async (long? id, long? idContaDestino, double? valorTransferencia);

        /// <summary>
        /// {{{transferencia_resource_transferir}}}
        /// </summary>
        /// <remarks>
        /// {{{transferencia_resource_transferir_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_resource_transferir_param_id_conta_origem}}}</param>
        /// <param name="idContaDestino">{{{transferencia_resource_transferir_param_id_conta_destino}}}</param>
        /// <param name="valorTransferencia">{{{transferencia_resource_transferir_param_valor_transferencia}}}</param>
        /// <returns>Task of ApiResponse (TransferenciaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransferenciaDetalheResponse>> TransferirUsingPOST1AsyncWithHttpInfo (long? id, long? idContaDestino, double? valorTransferencia);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltagcontaApi : IGlobaltagcontaApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagcontaApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltagcontaApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagcontaApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltagcontaApi(Configuration configuration = null)
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
        /// {{{conta_resource_ajustar_conta}}} {{{conta_resource_ajustar_conta_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_ajustar_conta_param_id}}}</param> 
        /// <param name="idTipoAjuste">{{{ajuste_persist_id_tipo_ajuste_value}}}</param> 
        /// <param name="dataAjuste">{{{ajuste_persist_data_ajuste_value}}}</param> 
        /// <param name="valorAjuste">{{{ajuste_persist_valor_ajuste_value}}}</param> 
        /// <param name="login">login (optional)</param> 
        /// <param name="identificadorExterno">{{{ajuste_persist_identificador_externo_value}}} (optional)</param> 
        /// <param name="idTransacaoOriginal">{{{ajuste_persist_id_transacao_original}}} (optional)</param> 
        /// <returns>AjusteFinanceiroResponse</returns>
        public AjusteFinanceiroResponse AjustarContaUsingPOST1 (long? id, long? idTipoAjuste, string dataAjuste, double? valorAjuste, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null)
        {
             ApiResponse<AjusteFinanceiroResponse> localVarResponse = AjustarContaUsingPOST1WithHttpInfo(id, idTipoAjuste, dataAjuste, valorAjuste, login, identificadorExterno, idTransacaoOriginal);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_resource_ajustar_conta}}} {{{conta_resource_ajustar_conta_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_ajustar_conta_param_id}}}</param> 
        /// <param name="idTipoAjuste">{{{ajuste_persist_id_tipo_ajuste_value}}}</param> 
        /// <param name="dataAjuste">{{{ajuste_persist_data_ajuste_value}}}</param> 
        /// <param name="valorAjuste">{{{ajuste_persist_valor_ajuste_value}}}</param> 
        /// <param name="login">login (optional)</param> 
        /// <param name="identificadorExterno">{{{ajuste_persist_identificador_externo_value}}} (optional)</param> 
        /// <param name="idTransacaoOriginal">{{{ajuste_persist_id_transacao_original}}} (optional)</param> 
        /// <returns>ApiResponse of AjusteFinanceiroResponse</returns>
        public ApiResponse< AjusteFinanceiroResponse > AjustarContaUsingPOST1WithHttpInfo (long? id, long? idTipoAjuste, string dataAjuste, double? valorAjuste, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->AjustarContaUsingPOST1");
            
            // verify the required parameter 'idTipoAjuste' is set
            if (idTipoAjuste == null)
                throw new ApiException(400, "Missing required parameter 'idTipoAjuste' when calling GlobaltagcontaApi->AjustarContaUsingPOST1");
            
            // verify the required parameter 'dataAjuste' is set
            if (dataAjuste == null)
                throw new ApiException(400, "Missing required parameter 'dataAjuste' when calling GlobaltagcontaApi->AjustarContaUsingPOST1");
            
            // verify the required parameter 'valorAjuste' is set
            if (valorAjuste == null)
                throw new ApiException(400, "Missing required parameter 'valorAjuste' when calling GlobaltagcontaApi->AjustarContaUsingPOST1");
            
    
            var localVarPath = "/api/contas/{id}/ajustes-financeiros";
    
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
            
            if (idTipoAjuste != null) localVarQueryParams.Add("idTipoAjuste", Configuration.ApiClient.ParameterToString(idTipoAjuste)); // query parameter
            if (dataAjuste != null) localVarQueryParams.Add("dataAjuste", Configuration.ApiClient.ParameterToString(dataAjuste)); // query parameter
            if (valorAjuste != null) localVarQueryParams.Add("valorAjuste", Configuration.ApiClient.ParameterToString(valorAjuste)); // query parameter
            if (identificadorExterno != null) localVarQueryParams.Add("identificadorExterno", Configuration.ApiClient.ParameterToString(identificadorExterno)); // query parameter
            if (idTransacaoOriginal != null) localVarQueryParams.Add("idTransacaoOriginal", Configuration.ApiClient.ParameterToString(idTransacaoOriginal)); // query parameter
            
            if (login != null) localVarHeaderParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // header parameter
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AjustarContaUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AjustarContaUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AjusteFinanceiroResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AjusteFinanceiroResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AjusteFinanceiroResponse)));
            
        }

        
        /// <summary>
        /// {{{conta_resource_ajustar_conta}}} {{{conta_resource_ajustar_conta_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_ajustar_conta_param_id}}}</param>
        /// <param name="idTipoAjuste">{{{ajuste_persist_id_tipo_ajuste_value}}}</param>
        /// <param name="dataAjuste">{{{ajuste_persist_data_ajuste_value}}}</param>
        /// <param name="valorAjuste">{{{ajuste_persist_valor_ajuste_value}}}</param>
        /// <param name="login">login (optional)</param>
        /// <param name="identificadorExterno">{{{ajuste_persist_identificador_externo_value}}} (optional)</param>
        /// <param name="idTransacaoOriginal">{{{ajuste_persist_id_transacao_original}}} (optional)</param>
        /// <returns>Task of AjusteFinanceiroResponse</returns>
        public async System.Threading.Tasks.Task<AjusteFinanceiroResponse> AjustarContaUsingPOST1Async (long? id, long? idTipoAjuste, string dataAjuste, double? valorAjuste, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null)
        {
             ApiResponse<AjusteFinanceiroResponse> localVarResponse = await AjustarContaUsingPOST1AsyncWithHttpInfo(id, idTipoAjuste, dataAjuste, valorAjuste, login, identificadorExterno, idTransacaoOriginal);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_resource_ajustar_conta}}} {{{conta_resource_ajustar_conta_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_ajustar_conta_param_id}}}</param>
        /// <param name="idTipoAjuste">{{{ajuste_persist_id_tipo_ajuste_value}}}</param>
        /// <param name="dataAjuste">{{{ajuste_persist_data_ajuste_value}}}</param>
        /// <param name="valorAjuste">{{{ajuste_persist_valor_ajuste_value}}}</param>
        /// <param name="login">login (optional)</param>
        /// <param name="identificadorExterno">{{{ajuste_persist_identificador_externo_value}}} (optional)</param>
        /// <param name="idTransacaoOriginal">{{{ajuste_persist_id_transacao_original}}} (optional)</param>
        /// <returns>Task of ApiResponse (AjusteFinanceiroResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AjusteFinanceiroResponse>> AjustarContaUsingPOST1AsyncWithHttpInfo (long? id, long? idTipoAjuste, string dataAjuste, double? valorAjuste, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AjustarContaUsingPOST1");
            // verify the required parameter 'idTipoAjuste' is set
            if (idTipoAjuste == null) throw new ApiException(400, "Missing required parameter 'idTipoAjuste' when calling AjustarContaUsingPOST1");
            // verify the required parameter 'dataAjuste' is set
            if (dataAjuste == null) throw new ApiException(400, "Missing required parameter 'dataAjuste' when calling AjustarContaUsingPOST1");
            // verify the required parameter 'valorAjuste' is set
            if (valorAjuste == null) throw new ApiException(400, "Missing required parameter 'valorAjuste' when calling AjustarContaUsingPOST1");
            
    
            var localVarPath = "/api/contas/{id}/ajustes-financeiros";
    
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
            
            if (idTipoAjuste != null) localVarQueryParams.Add("idTipoAjuste", Configuration.ApiClient.ParameterToString(idTipoAjuste)); // query parameter
            if (dataAjuste != null) localVarQueryParams.Add("dataAjuste", Configuration.ApiClient.ParameterToString(dataAjuste)); // query parameter
            if (valorAjuste != null) localVarQueryParams.Add("valorAjuste", Configuration.ApiClient.ParameterToString(valorAjuste)); // query parameter
            if (identificadorExterno != null) localVarQueryParams.Add("identificadorExterno", Configuration.ApiClient.ParameterToString(identificadorExterno)); // query parameter
            if (idTransacaoOriginal != null) localVarQueryParams.Add("idTransacaoOriginal", Configuration.ApiClient.ParameterToString(idTransacaoOriginal)); // query parameter
            
            if (login != null) localVarHeaderParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // header parameter
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AjustarContaUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AjustarContaUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AjusteFinanceiroResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AjusteFinanceiroResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AjusteFinanceiroResponse)));
            
        }
        
        /// <summary>
        /// {{{conta_resource_alterar_produto}}} {{{conta_resource_alterar_produto_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_alterar_produto_param_id}}}</param> 
        /// <param name="request">request</param> 
        /// <returns>string</returns>
        public string AlterarProdutoUsingPOST (long? id, AlterarProdutoRequest request)
        {
             ApiResponse<string> localVarResponse = AlterarProdutoUsingPOSTWithHttpInfo(id, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_resource_alterar_produto}}} {{{conta_resource_alterar_produto_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_alterar_produto_param_id}}}</param> 
        /// <param name="request">request</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > AlterarProdutoUsingPOSTWithHttpInfo (long? id, AlterarProdutoRequest request)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->AlterarProdutoUsingPOST");
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling GlobaltagcontaApi->AlterarProdutoUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/alterar-produto";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarProdutoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarProdutoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// {{{conta_resource_alterar_produto}}} {{{conta_resource_alterar_produto_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_alterar_produto_param_id}}}</param>
        /// <param name="request">request</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> AlterarProdutoUsingPOSTAsync (long? id, AlterarProdutoRequest request)
        {
             ApiResponse<string> localVarResponse = await AlterarProdutoUsingPOSTAsyncWithHttpInfo(id, request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_resource_alterar_produto}}} {{{conta_resource_alterar_produto_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_alterar_produto_param_id}}}</param>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> AlterarProdutoUsingPOSTAsyncWithHttpInfo (long? id, AlterarProdutoRequest request)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarProdutoUsingPOST");
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling AlterarProdutoUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/alterar-produto";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarProdutoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarProdutoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// {{{conta_resource_alterar_titular}}} {{{conta_resource_alterar_titular_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_alterar_titular_param_id_conta}}}</param> 
        /// <param name="idPessoa">{{{conta_resource_alterar_titular_param_id_pessoa}}}</param> 
        /// <returns>ContaResponse</returns>
        public ContaResponse AlterarTitularUsingPOST (long? id, long? idPessoa)
        {
             ApiResponse<ContaResponse> localVarResponse = AlterarTitularUsingPOSTWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_resource_alterar_titular}}} {{{conta_resource_alterar_titular_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_alterar_titular_param_id_conta}}}</param> 
        /// <param name="idPessoa">{{{conta_resource_alterar_titular_param_id_pessoa}}}</param> 
        /// <returns>ApiResponse of ContaResponse</returns>
        public ApiResponse< ContaResponse > AlterarTitularUsingPOSTWithHttpInfo (long? id, long? idPessoa)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->AlterarTitularUsingPOST");
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling GlobaltagcontaApi->AlterarTitularUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/alterar-titular";
    
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
            
            if (idPessoa != null) localVarQueryParams.Add("id_pessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTitularUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTitularUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }

        
        /// <summary>
        /// {{{conta_resource_alterar_titular}}} {{{conta_resource_alterar_titular_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_alterar_titular_param_id_conta}}}</param>
        /// <param name="idPessoa">{{{conta_resource_alterar_titular_param_id_pessoa}}}</param>
        /// <returns>Task of ContaResponse</returns>
        public async System.Threading.Tasks.Task<ContaResponse> AlterarTitularUsingPOSTAsync (long? id, long? idPessoa)
        {
             ApiResponse<ContaResponse> localVarResponse = await AlterarTitularUsingPOSTAsyncWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_resource_alterar_titular}}} {{{conta_resource_alterar_titular_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_alterar_titular_param_id_conta}}}</param>
        /// <param name="idPessoa">{{{conta_resource_alterar_titular_param_id_pessoa}}}</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaResponse>> AlterarTitularUsingPOSTAsyncWithHttpInfo (long? id, long? idPessoa)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarTitularUsingPOST");
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling AlterarTitularUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/alterar-titular";
    
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
            
            if (idPessoa != null) localVarQueryParams.Add("id_pessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTitularUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTitularUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }
        
        /// <summary>
        /// {{{conta_resource_alterar_vencimento}}} {{{conta_resource_alterar_vencimento_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_alterar_vencimento_param_id}}}</param> 
        /// <param name="novoDiaVencimento">{{{conta_resource_alterar_vencimento_param_novo_dia_vencimento}}}</param> 
        /// <returns>ContaResponse</returns>
        public ContaResponse AlterarVencimentoUsingPUT (long? id, int? novoDiaVencimento)
        {
             ApiResponse<ContaResponse> localVarResponse = AlterarVencimentoUsingPUTWithHttpInfo(id, novoDiaVencimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_resource_alterar_vencimento}}} {{{conta_resource_alterar_vencimento_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_alterar_vencimento_param_id}}}</param> 
        /// <param name="novoDiaVencimento">{{{conta_resource_alterar_vencimento_param_novo_dia_vencimento}}}</param> 
        /// <returns>ApiResponse of ContaResponse</returns>
        public ApiResponse< ContaResponse > AlterarVencimentoUsingPUTWithHttpInfo (long? id, int? novoDiaVencimento)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->AlterarVencimentoUsingPUT");
            
            // verify the required parameter 'novoDiaVencimento' is set
            if (novoDiaVencimento == null)
                throw new ApiException(400, "Missing required parameter 'novoDiaVencimento' when calling GlobaltagcontaApi->AlterarVencimentoUsingPUT");
            
    
            var localVarPath = "/api/contas/{id}/alterar-vencimento";
    
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
            
            if (novoDiaVencimento != null) localVarQueryParams.Add("novo_dia_vencimento", Configuration.ApiClient.ParameterToString(novoDiaVencimento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarVencimentoUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarVencimentoUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }

        
        /// <summary>
        /// {{{conta_resource_alterar_vencimento}}} {{{conta_resource_alterar_vencimento_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_alterar_vencimento_param_id}}}</param>
        /// <param name="novoDiaVencimento">{{{conta_resource_alterar_vencimento_param_novo_dia_vencimento}}}</param>
        /// <returns>Task of ContaResponse</returns>
        public async System.Threading.Tasks.Task<ContaResponse> AlterarVencimentoUsingPUTAsync (long? id, int? novoDiaVencimento)
        {
             ApiResponse<ContaResponse> localVarResponse = await AlterarVencimentoUsingPUTAsyncWithHttpInfo(id, novoDiaVencimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_resource_alterar_vencimento}}} {{{conta_resource_alterar_vencimento_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_alterar_vencimento_param_id}}}</param>
        /// <param name="novoDiaVencimento">{{{conta_resource_alterar_vencimento_param_novo_dia_vencimento}}}</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaResponse>> AlterarVencimentoUsingPUTAsyncWithHttpInfo (long? id, int? novoDiaVencimento)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarVencimentoUsingPUT");
            // verify the required parameter 'novoDiaVencimento' is set
            if (novoDiaVencimento == null) throw new ApiException(400, "Missing required parameter 'novoDiaVencimento' when calling AlterarVencimentoUsingPUT");
            
    
            var localVarPath = "/api/contas/{id}/alterar-vencimento";
    
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
            
            if (novoDiaVencimento != null) localVarQueryParams.Add("novo_dia_vencimento", Configuration.ApiClient.ParameterToString(novoDiaVencimento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarVencimentoUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarVencimentoUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
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
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->AtivarAnuidadeUsingPOST");
            
            // verify the required parameter 'idAnuidade' is set
            if (idAnuidade == null)
                throw new ApiException(400, "Missing required parameter 'idAnuidade' when calling GlobaltagcontaApi->AtivarAnuidadeUsingPOST");
            
    
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
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->AtivarEnvioFaturaEmailUsingPOST");
            
    
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
        /// {{{conta_resource_bloquear}}} {{{conta_resource_bloquear_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_bloquear_param_id}}}</param> 
        /// <param name="idStatus">{{{conta_resource_bloquear_param_id_status}}}</param> 
        /// <returns>ContaResponse</returns>
        public ContaResponse BloquearUsingPOST1 (long? id, long? idStatus)
        {
             ApiResponse<ContaResponse> localVarResponse = BloquearUsingPOST1WithHttpInfo(id, idStatus);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_resource_bloquear}}} {{{conta_resource_bloquear_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_bloquear_param_id}}}</param> 
        /// <param name="idStatus">{{{conta_resource_bloquear_param_id_status}}}</param> 
        /// <returns>ApiResponse of ContaResponse</returns>
        public ApiResponse< ContaResponse > BloquearUsingPOST1WithHttpInfo (long? id, long? idStatus)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->BloquearUsingPOST1");
            
            // verify the required parameter 'idStatus' is set
            if (idStatus == null)
                throw new ApiException(400, "Missing required parameter 'idStatus' when calling GlobaltagcontaApi->BloquearUsingPOST1");
            
    
            var localVarPath = "/api/contas/{id}/bloquear";
    
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
            
            if (idStatus != null) localVarQueryParams.Add("id_status", Configuration.ApiClient.ParameterToString(idStatus)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling BloquearUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling BloquearUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }

        
        /// <summary>
        /// {{{conta_resource_bloquear}}} {{{conta_resource_bloquear_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_bloquear_param_id}}}</param>
        /// <param name="idStatus">{{{conta_resource_bloquear_param_id_status}}}</param>
        /// <returns>Task of ContaResponse</returns>
        public async System.Threading.Tasks.Task<ContaResponse> BloquearUsingPOST1Async (long? id, long? idStatus)
        {
             ApiResponse<ContaResponse> localVarResponse = await BloquearUsingPOST1AsyncWithHttpInfo(id, idStatus);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_resource_bloquear}}} {{{conta_resource_bloquear_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_bloquear_param_id}}}</param>
        /// <param name="idStatus">{{{conta_resource_bloquear_param_id_status}}}</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaResponse>> BloquearUsingPOST1AsyncWithHttpInfo (long? id, long? idStatus)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling BloquearUsingPOST1");
            // verify the required parameter 'idStatus' is set
            if (idStatus == null) throw new ApiException(400, "Missing required parameter 'idStatus' when calling BloquearUsingPOST1");
            
    
            var localVarPath = "/api/contas/{id}/bloquear";
    
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
            
            if (idStatus != null) localVarQueryParams.Add("id_status", Configuration.ApiClient.ParameterToString(idStatus)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling BloquearUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling BloquearUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }
        
        /// <summary>
        /// {{{aderir_pagamento_sabado_recurso_cadastrar}}} {{{aderir_pagamento_sabado_recurso_cadastrar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{aderir_pagamento_sabado_recurso_cadastrar_param_id}}}</param> 
        /// <returns>AdesaoPagamentoSabadoResponse</returns>
        public AdesaoPagamentoSabadoResponse CadastrarUsingPOST (long? id)
        {
             ApiResponse<AdesaoPagamentoSabadoResponse> localVarResponse = CadastrarUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{aderir_pagamento_sabado_recurso_cadastrar}}} {{{aderir_pagamento_sabado_recurso_cadastrar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{aderir_pagamento_sabado_recurso_cadastrar_param_id}}}</param> 
        /// <returns>ApiResponse of AdesaoPagamentoSabadoResponse</returns>
        public ApiResponse< AdesaoPagamentoSabadoResponse > CadastrarUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->CadastrarUsingPOST");
            
    
            var localVarPath = "/api/adesoes-pagamentos-sabados";
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdesaoPagamentoSabadoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdesaoPagamentoSabadoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdesaoPagamentoSabadoResponse)));
            
        }

        
        /// <summary>
        /// {{{aderir_pagamento_sabado_recurso_cadastrar}}} {{{aderir_pagamento_sabado_recurso_cadastrar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{aderir_pagamento_sabado_recurso_cadastrar_param_id}}}</param>
        /// <returns>Task of AdesaoPagamentoSabadoResponse</returns>
        public async System.Threading.Tasks.Task<AdesaoPagamentoSabadoResponse> CadastrarUsingPOSTAsync (long? id)
        {
             ApiResponse<AdesaoPagamentoSabadoResponse> localVarResponse = await CadastrarUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{aderir_pagamento_sabado_recurso_cadastrar}}} {{{aderir_pagamento_sabado_recurso_cadastrar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{aderir_pagamento_sabado_recurso_cadastrar_param_id}}}</param>
        /// <returns>Task of ApiResponse (AdesaoPagamentoSabadoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdesaoPagamentoSabadoResponse>> CadastrarUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CadastrarUsingPOST");
            
    
            var localVarPath = "/api/adesoes-pagamentos-sabados";
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdesaoPagamentoSabadoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdesaoPagamentoSabadoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdesaoPagamentoSabadoResponse)));
            
        }
        
        /// <summary>
        /// {{{conta_resource_cancelar}}} {{{conta_resource_cancelar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_cancelar_param_id}}}</param> 
        /// <param name="idStatus">{{{conta_resource_cancelar_param_id_status}}}</param> 
        /// <returns>ContaResponse</returns>
        public ContaResponse CancelarUsingPOST1 (long? id, long? idStatus)
        {
             ApiResponse<ContaResponse> localVarResponse = CancelarUsingPOST1WithHttpInfo(id, idStatus);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_resource_cancelar}}} {{{conta_resource_cancelar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_cancelar_param_id}}}</param> 
        /// <param name="idStatus">{{{conta_resource_cancelar_param_id_status}}}</param> 
        /// <returns>ApiResponse of ContaResponse</returns>
        public ApiResponse< ContaResponse > CancelarUsingPOST1WithHttpInfo (long? id, long? idStatus)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->CancelarUsingPOST1");
            
            // verify the required parameter 'idStatus' is set
            if (idStatus == null)
                throw new ApiException(400, "Missing required parameter 'idStatus' when calling GlobaltagcontaApi->CancelarUsingPOST1");
            
    
            var localVarPath = "/api/contas/{id}/cancelar";
    
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
            
            if (idStatus != null) localVarQueryParams.Add("id_status", Configuration.ApiClient.ParameterToString(idStatus)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }

        
        /// <summary>
        /// {{{conta_resource_cancelar}}} {{{conta_resource_cancelar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_cancelar_param_id}}}</param>
        /// <param name="idStatus">{{{conta_resource_cancelar_param_id_status}}}</param>
        /// <returns>Task of ContaResponse</returns>
        public async System.Threading.Tasks.Task<ContaResponse> CancelarUsingPOST1Async (long? id, long? idStatus)
        {
             ApiResponse<ContaResponse> localVarResponse = await CancelarUsingPOST1AsyncWithHttpInfo(id, idStatus);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_resource_cancelar}}} {{{conta_resource_cancelar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_cancelar_param_id}}}</param>
        /// <param name="idStatus">{{{conta_resource_cancelar_param_id_status}}}</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaResponse>> CancelarUsingPOST1AsyncWithHttpInfo (long? id, long? idStatus)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CancelarUsingPOST1");
            // verify the required parameter 'idStatus' is set
            if (idStatus == null) throw new ApiException(400, "Missing required parameter 'idStatus' when calling CancelarUsingPOST1");
            
    
            var localVarPath = "/api/contas/{id}/cancelar";
    
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
            
            if (idStatus != null) localVarQueryParams.Add("id_status", Configuration.ApiClient.ParameterToString(idStatus)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }
        
        /// <summary>
        /// {{{conta_resource_consultar_beneficio_pagamento_atraso}}} {{{conta_resource_consultar_beneficio_pagamento_atraso_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_beneficio_pagamento_atraso_param_id}}}</param> 
        /// <returns>BeneficioPagamentoAtrasoResponse</returns>
        public BeneficioPagamentoAtrasoResponse ConsultarBeneficioPagamentoAtrasoUsingGET (long? id)
        {
             ApiResponse<BeneficioPagamentoAtrasoResponse> localVarResponse = ConsultarBeneficioPagamentoAtrasoUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_resource_consultar_beneficio_pagamento_atraso}}} {{{conta_resource_consultar_beneficio_pagamento_atraso_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_beneficio_pagamento_atraso_param_id}}}</param> 
        /// <returns>ApiResponse of BeneficioPagamentoAtrasoResponse</returns>
        public ApiResponse< BeneficioPagamentoAtrasoResponse > ConsultarBeneficioPagamentoAtrasoUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->ConsultarBeneficioPagamentoAtrasoUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/consultar-beneficio-pagamento-atraso";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBeneficioPagamentoAtrasoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBeneficioPagamentoAtrasoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BeneficioPagamentoAtrasoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BeneficioPagamentoAtrasoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BeneficioPagamentoAtrasoResponse)));
            
        }

        
        /// <summary>
        /// {{{conta_resource_consultar_beneficio_pagamento_atraso}}} {{{conta_resource_consultar_beneficio_pagamento_atraso_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_beneficio_pagamento_atraso_param_id}}}</param>
        /// <returns>Task of BeneficioPagamentoAtrasoResponse</returns>
        public async System.Threading.Tasks.Task<BeneficioPagamentoAtrasoResponse> ConsultarBeneficioPagamentoAtrasoUsingGETAsync (long? id)
        {
             ApiResponse<BeneficioPagamentoAtrasoResponse> localVarResponse = await ConsultarBeneficioPagamentoAtrasoUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_resource_consultar_beneficio_pagamento_atraso}}} {{{conta_resource_consultar_beneficio_pagamento_atraso_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_beneficio_pagamento_atraso_param_id}}}</param>
        /// <returns>Task of ApiResponse (BeneficioPagamentoAtrasoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BeneficioPagamentoAtrasoResponse>> ConsultarBeneficioPagamentoAtrasoUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarBeneficioPagamentoAtrasoUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/consultar-beneficio-pagamento-atraso";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBeneficioPagamentoAtrasoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBeneficioPagamentoAtrasoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BeneficioPagamentoAtrasoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BeneficioPagamentoAtrasoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BeneficioPagamentoAtrasoResponse)));
            
        }
        
        /// <summary>
        /// {{{conta_resource_consultar_boleto_emitido}}} {{{conta_resource_consultar_boleto_emitido_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_boleto_emitido_param_id}}}</param> 
        /// <returns>BoletoResponse</returns>
        public BoletoResponse ConsultarBoletoEmitidoUsingGET (long? id)
        {
             ApiResponse<BoletoResponse> localVarResponse = ConsultarBoletoEmitidoUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_resource_consultar_boleto_emitido}}} {{{conta_resource_consultar_boleto_emitido_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_boleto_emitido_param_id}}}</param> 
        /// <returns>ApiResponse of BoletoResponse</returns>
        public ApiResponse< BoletoResponse > ConsultarBoletoEmitidoUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->ConsultarBoletoEmitidoUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/consultar-dados-pagamento-fatura";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBoletoEmitidoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBoletoEmitidoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoResponse)));
            
        }

        
        /// <summary>
        /// {{{conta_resource_consultar_boleto_emitido}}} {{{conta_resource_consultar_boleto_emitido_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_boleto_emitido_param_id}}}</param>
        /// <returns>Task of BoletoResponse</returns>
        public async System.Threading.Tasks.Task<BoletoResponse> ConsultarBoletoEmitidoUsingGETAsync (long? id)
        {
             ApiResponse<BoletoResponse> localVarResponse = await ConsultarBoletoEmitidoUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_resource_consultar_boleto_emitido}}} {{{conta_resource_consultar_boleto_emitido_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_boleto_emitido_param_id}}}</param>
        /// <returns>Task of ApiResponse (BoletoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BoletoResponse>> ConsultarBoletoEmitidoUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarBoletoEmitidoUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/consultar-dados-pagamento-fatura";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBoletoEmitidoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBoletoEmitidoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoResponse)));
            
        }
        
        /// <summary>
        /// {{{conta_resource_consultar_divida_atualizada_cliente}}} {{{conta_resource_consultar_divida_atualizada_cliente_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_divida_atualizada_cliente_param_id}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="dataVencimento">{{{divida_cliente_request_data_vencimento_value}}} (optional)</param> 
        /// <param name="idEscritorioCobranca">{{{divida_cliente_request_id_escritorio_cobranca_value}}} (optional)</param> 
        /// <returns>DividaClienteResponse</returns>
        public DividaClienteResponse ConsultarDividaAtualizadaClienteUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, long? idEscritorioCobranca = null)
        {
             ApiResponse<DividaClienteResponse> localVarResponse = ConsultarDividaAtualizadaClienteUsingGETWithHttpInfo(id, sort, page, limit, dataVencimento, idEscritorioCobranca);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_resource_consultar_divida_atualizada_cliente}}} {{{conta_resource_consultar_divida_atualizada_cliente_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_divida_atualizada_cliente_param_id}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="dataVencimento">{{{divida_cliente_request_data_vencimento_value}}} (optional)</param> 
        /// <param name="idEscritorioCobranca">{{{divida_cliente_request_id_escritorio_cobranca_value}}} (optional)</param> 
        /// <returns>ApiResponse of DividaClienteResponse</returns>
        public ApiResponse< DividaClienteResponse > ConsultarDividaAtualizadaClienteUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, long? idEscritorioCobranca = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->ConsultarDividaAtualizadaClienteUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/recuperar-divida-atualizada";
    
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
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            if (idEscritorioCobranca != null) localVarQueryParams.Add("idEscritorioCobranca", Configuration.ApiClient.ParameterToString(idEscritorioCobranca)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDividaAtualizadaClienteUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDividaAtualizadaClienteUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DividaClienteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DividaClienteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DividaClienteResponse)));
            
        }

        
        /// <summary>
        /// {{{conta_resource_consultar_divida_atualizada_cliente}}} {{{conta_resource_consultar_divida_atualizada_cliente_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_divida_atualizada_cliente_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataVencimento">{{{divida_cliente_request_data_vencimento_value}}} (optional)</param>
        /// <param name="idEscritorioCobranca">{{{divida_cliente_request_id_escritorio_cobranca_value}}} (optional)</param>
        /// <returns>Task of DividaClienteResponse</returns>
        public async System.Threading.Tasks.Task<DividaClienteResponse> ConsultarDividaAtualizadaClienteUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, long? idEscritorioCobranca = null)
        {
             ApiResponse<DividaClienteResponse> localVarResponse = await ConsultarDividaAtualizadaClienteUsingGETAsyncWithHttpInfo(id, sort, page, limit, dataVencimento, idEscritorioCobranca);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_resource_consultar_divida_atualizada_cliente}}} {{{conta_resource_consultar_divida_atualizada_cliente_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_divida_atualizada_cliente_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataVencimento">{{{divida_cliente_request_data_vencimento_value}}} (optional)</param>
        /// <param name="idEscritorioCobranca">{{{divida_cliente_request_id_escritorio_cobranca_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (DividaClienteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DividaClienteResponse>> ConsultarDividaAtualizadaClienteUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, long? idEscritorioCobranca = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarDividaAtualizadaClienteUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/recuperar-divida-atualizada";
    
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
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            if (idEscritorioCobranca != null) localVarQueryParams.Add("idEscritorioCobranca", Configuration.ApiClient.ParameterToString(idEscritorioCobranca)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDividaAtualizadaClienteUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDividaAtualizadaClienteUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DividaClienteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DividaClienteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DividaClienteResponse)));
            
        }
        
        /// <summary>
        /// {{{conta_resource_consultar_taxas_tarifas}}} {{{conta_resource_consultar_taxas_tarifas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_taxas_tarifas_param_id_conta}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>PageTaxasRefinanciamentoResponse</returns>
        public PageTaxasRefinanciamentoResponse ConsultarTaxasTarifasUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTaxasRefinanciamentoResponse> localVarResponse = ConsultarTaxasTarifasUsingGETWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_resource_consultar_taxas_tarifas}}} {{{conta_resource_consultar_taxas_tarifas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_taxas_tarifas_param_id_conta}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>ApiResponse of PageTaxasRefinanciamentoResponse</returns>
        public ApiResponse< PageTaxasRefinanciamentoResponse > ConsultarTaxasTarifasUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->ConsultarTaxasTarifasUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/consultar-taxas-tarifas";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxasTarifasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxasTarifasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTaxasRefinanciamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTaxasRefinanciamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTaxasRefinanciamentoResponse)));
            
        }

        
        /// <summary>
        /// {{{conta_resource_consultar_taxas_tarifas}}} {{{conta_resource_consultar_taxas_tarifas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_taxas_tarifas_param_id_conta}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageTaxasRefinanciamentoResponse</returns>
        public async System.Threading.Tasks.Task<PageTaxasRefinanciamentoResponse> ConsultarTaxasTarifasUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTaxasRefinanciamentoResponse> localVarResponse = await ConsultarTaxasTarifasUsingGETAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_resource_consultar_taxas_tarifas}}} {{{conta_resource_consultar_taxas_tarifas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_taxas_tarifas_param_id_conta}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTaxasRefinanciamentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTaxasRefinanciamentoResponse>> ConsultarTaxasTarifasUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarTaxasTarifasUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/consultar-taxas-tarifas";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxasTarifasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxasTarifasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTaxasRefinanciamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTaxasRefinanciamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTaxasRefinanciamentoResponse)));
            
        }
        
        /// <summary>
        /// {{{aderir_pagamento_sabado_recurso_consultar}}} {{{aderir_pagamento_sabado_recurso_consultar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{aderir_pagamento_sabado_recurso_consultar_param_id}}}</param> 
        /// <param name="dataVencimento">{{{aderir_pagamento_sabado_recurso_consultar_param_data_vencimento}}}</param> 
        /// <returns>AdesaoPagamentoSabadoResponse</returns>
        public AdesaoPagamentoSabadoResponse ConsultarUsingGET1 (long? id, string dataVencimento)
        {
             ApiResponse<AdesaoPagamentoSabadoResponse> localVarResponse = ConsultarUsingGET1WithHttpInfo(id, dataVencimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{aderir_pagamento_sabado_recurso_consultar}}} {{{aderir_pagamento_sabado_recurso_consultar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{aderir_pagamento_sabado_recurso_consultar_param_id}}}</param> 
        /// <param name="dataVencimento">{{{aderir_pagamento_sabado_recurso_consultar_param_data_vencimento}}}</param> 
        /// <returns>ApiResponse of AdesaoPagamentoSabadoResponse</returns>
        public ApiResponse< AdesaoPagamentoSabadoResponse > ConsultarUsingGET1WithHttpInfo (long? id, string dataVencimento)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->ConsultarUsingGET1");
            
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null)
                throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling GlobaltagcontaApi->ConsultarUsingGET1");
            
    
            var localVarPath = "/api/adesoes-pagamentos-sabados";
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdesaoPagamentoSabadoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdesaoPagamentoSabadoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdesaoPagamentoSabadoResponse)));
            
        }

        
        /// <summary>
        /// {{{aderir_pagamento_sabado_recurso_consultar}}} {{{aderir_pagamento_sabado_recurso_consultar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{aderir_pagamento_sabado_recurso_consultar_param_id}}}</param>
        /// <param name="dataVencimento">{{{aderir_pagamento_sabado_recurso_consultar_param_data_vencimento}}}</param>
        /// <returns>Task of AdesaoPagamentoSabadoResponse</returns>
        public async System.Threading.Tasks.Task<AdesaoPagamentoSabadoResponse> ConsultarUsingGET1Async (long? id, string dataVencimento)
        {
             ApiResponse<AdesaoPagamentoSabadoResponse> localVarResponse = await ConsultarUsingGET1AsyncWithHttpInfo(id, dataVencimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{aderir_pagamento_sabado_recurso_consultar}}} {{{aderir_pagamento_sabado_recurso_consultar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{aderir_pagamento_sabado_recurso_consultar_param_id}}}</param>
        /// <param name="dataVencimento">{{{aderir_pagamento_sabado_recurso_consultar_param_data_vencimento}}}</param>
        /// <returns>Task of ApiResponse (AdesaoPagamentoSabadoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdesaoPagamentoSabadoResponse>> ConsultarUsingGET1AsyncWithHttpInfo (long? id, string dataVencimento)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET1");
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null) throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling ConsultarUsingGET1");
            
    
            var localVarPath = "/api/adesoes-pagamentos-sabados";
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdesaoPagamentoSabadoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdesaoPagamentoSabadoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdesaoPagamentoSabadoResponse)));
            
        }
        
        /// <summary>
        /// {{{conta_resource_consultar}}} {{{conta_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_param_id}}}</param> 
        /// <returns>ContaDetalheResponse</returns>
        public ContaDetalheResponse ConsultarUsingGET13 (long? id)
        {
             ApiResponse<ContaDetalheResponse> localVarResponse = ConsultarUsingGET13WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_resource_consultar}}} {{{conta_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of ContaDetalheResponse</returns>
        public ApiResponse< ContaDetalheResponse > ConsultarUsingGET13WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->ConsultarUsingGET13");
            
    
            var localVarPath = "/api/contas/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET13: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET13: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaDetalheResponse)));
            
        }

        
        /// <summary>
        /// {{{conta_resource_consultar}}} {{{conta_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_param_id}}}</param>
        /// <returns>Task of ContaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<ContaDetalheResponse> ConsultarUsingGET13Async (long? id)
        {
             ApiResponse<ContaDetalheResponse> localVarResponse = await ConsultarUsingGET13AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_resource_consultar}}} {{{conta_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (ContaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaDetalheResponse>> ConsultarUsingGET13AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET13");
            
    
            var localVarPath = "/api/contas/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET13: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET13: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaDetalheResponse)));
            
        }
        
        /// <summary>
        /// {{{transferencia_resource_consultar}}} {{{transferencia_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_resource_consultar_param_id_conta}}}</param> 
        /// <param name="idTransferencia">{{{transferencia_resource_consultar_param_id_transferencia}}}</param> 
        /// <returns>TransferenciaDetalheResponse</returns>
        public TransferenciaDetalheResponse ConsultarUsingGET45 (long? id, long? idTransferencia)
        {
             ApiResponse<TransferenciaDetalheResponse> localVarResponse = ConsultarUsingGET45WithHttpInfo(id, idTransferencia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{transferencia_resource_consultar}}} {{{transferencia_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_resource_consultar_param_id_conta}}}</param> 
        /// <param name="idTransferencia">{{{transferencia_resource_consultar_param_id_transferencia}}}</param> 
        /// <returns>ApiResponse of TransferenciaDetalheResponse</returns>
        public ApiResponse< TransferenciaDetalheResponse > ConsultarUsingGET45WithHttpInfo (long? id, long? idTransferencia)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->ConsultarUsingGET45");
            
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null)
                throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling GlobaltagcontaApi->ConsultarUsingGET45");
            
    
            var localVarPath = "/api/contas/{id}/transferencias-creditos-cartoes/{id_transferencia}";
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET45: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET45: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransferenciaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaDetalheResponse)));
            
        }

        
        /// <summary>
        /// {{{transferencia_resource_consultar}}} {{{transferencia_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_resource_consultar_param_id_conta}}}</param>
        /// <param name="idTransferencia">{{{transferencia_resource_consultar_param_id_transferencia}}}</param>
        /// <returns>Task of TransferenciaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<TransferenciaDetalheResponse> ConsultarUsingGET45Async (long? id, long? idTransferencia)
        {
             ApiResponse<TransferenciaDetalheResponse> localVarResponse = await ConsultarUsingGET45AsyncWithHttpInfo(id, idTransferencia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{transferencia_resource_consultar}}} {{{transferencia_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_resource_consultar_param_id_conta}}}</param>
        /// <param name="idTransferencia">{{{transferencia_resource_consultar_param_id_transferencia}}}</param>
        /// <returns>Task of ApiResponse (TransferenciaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransferenciaDetalheResponse>> ConsultarUsingGET45AsyncWithHttpInfo (long? id, long? idTransferencia)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET45");
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null) throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling ConsultarUsingGET45");
            
    
            var localVarPath = "/api/contas/{id}/transferencias-creditos-cartoes/{id_transferencia}";
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET45: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET45: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransferenciaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaDetalheResponse)));
            
        }
        
        /// <summary>
        /// {{{conta_resource_cadastrar_conta_multiapp}}} {{{conta_resource_cadastrar_conta_multiapp_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaMultiAppPersist">contaMultiAppPersist</param> 
        /// <returns>ContaMultiAppResponse</returns>
        public ContaMultiAppResponse CriarContasMultiAppUsingPOST (ContaMultiAppPersistValue contaMultiAppPersist)
        {
             ApiResponse<ContaMultiAppResponse> localVarResponse = CriarContasMultiAppUsingPOSTWithHttpInfo(contaMultiAppPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_resource_cadastrar_conta_multiapp}}} {{{conta_resource_cadastrar_conta_multiapp_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaMultiAppPersist">contaMultiAppPersist</param> 
        /// <returns>ApiResponse of ContaMultiAppResponse</returns>
        public ApiResponse< ContaMultiAppResponse > CriarContasMultiAppUsingPOSTWithHttpInfo (ContaMultiAppPersistValue contaMultiAppPersist)
        {
            
            // verify the required parameter 'contaMultiAppPersist' is set
            if (contaMultiAppPersist == null)
                throw new ApiException(400, "Missing required parameter 'contaMultiAppPersist' when calling GlobaltagcontaApi->CriarContasMultiAppUsingPOST");
            
    
            var localVarPath = "/api/contas/cadastrar-conta-multiapp";
    
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
            
            
            
            
            if (contaMultiAppPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contaMultiAppPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contaMultiAppPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CriarContasMultiAppUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CriarContasMultiAppUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaMultiAppResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaMultiAppResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaMultiAppResponse)));
            
        }

        
        /// <summary>
        /// {{{conta_resource_cadastrar_conta_multiapp}}} {{{conta_resource_cadastrar_conta_multiapp_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaMultiAppPersist">contaMultiAppPersist</param>
        /// <returns>Task of ContaMultiAppResponse</returns>
        public async System.Threading.Tasks.Task<ContaMultiAppResponse> CriarContasMultiAppUsingPOSTAsync (ContaMultiAppPersistValue contaMultiAppPersist)
        {
             ApiResponse<ContaMultiAppResponse> localVarResponse = await CriarContasMultiAppUsingPOSTAsyncWithHttpInfo(contaMultiAppPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_resource_cadastrar_conta_multiapp}}} {{{conta_resource_cadastrar_conta_multiapp_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaMultiAppPersist">contaMultiAppPersist</param>
        /// <returns>Task of ApiResponse (ContaMultiAppResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaMultiAppResponse>> CriarContasMultiAppUsingPOSTAsyncWithHttpInfo (ContaMultiAppPersistValue contaMultiAppPersist)
        {
            // verify the required parameter 'contaMultiAppPersist' is set
            if (contaMultiAppPersist == null) throw new ApiException(400, "Missing required parameter 'contaMultiAppPersist' when calling CriarContasMultiAppUsingPOST");
            
    
            var localVarPath = "/api/contas/cadastrar-conta-multiapp";
    
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
            
            
            
            
            if (contaMultiAppPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contaMultiAppPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contaMultiAppPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CriarContasMultiAppUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CriarContasMultiAppUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaMultiAppResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaMultiAppResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaMultiAppResponse)));
            
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
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->DesativarEnvioFaturaEmailUsingPOST");
            
    
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
        /// {{{conta_resource_gerar_boleto_recarga}}} {{{conta_resource_gerar_boleto_recarga_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_boleto_recarga_param_id}}}</param> 
        /// <param name="valor">{{{boleto_recarga_request_valor_value}}}</param> 
        /// <param name="dataVencimento">{{{boleto_recarga_request_data_vencimento_value}}}</param> 
        /// <returns>BoletoResponse</returns>
        public BoletoResponse GerarBoletoRecargaUsingPOST (long? id, double? valor, string dataVencimento)
        {
             ApiResponse<BoletoResponse> localVarResponse = GerarBoletoRecargaUsingPOSTWithHttpInfo(id, valor, dataVencimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_resource_gerar_boleto_recarga}}} {{{conta_resource_gerar_boleto_recarga_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_boleto_recarga_param_id}}}</param> 
        /// <param name="valor">{{{boleto_recarga_request_valor_value}}}</param> 
        /// <param name="dataVencimento">{{{boleto_recarga_request_data_vencimento_value}}}</param> 
        /// <returns>ApiResponse of BoletoResponse</returns>
        public ApiResponse< BoletoResponse > GerarBoletoRecargaUsingPOSTWithHttpInfo (long? id, double? valor, string dataVencimento)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->GerarBoletoRecargaUsingPOST");
            
            // verify the required parameter 'valor' is set
            if (valor == null)
                throw new ApiException(400, "Missing required parameter 'valor' when calling GlobaltagcontaApi->GerarBoletoRecargaUsingPOST");
            
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null)
                throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling GlobaltagcontaApi->GerarBoletoRecargaUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/gerar-boleto-recarga";
    
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
            
            if (valor != null) localVarQueryParams.Add("valor", Configuration.ApiClient.ParameterToString(valor)); // query parameter
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoRecargaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoRecargaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoResponse)));
            
        }

        
        /// <summary>
        /// {{{conta_resource_gerar_boleto_recarga}}} {{{conta_resource_gerar_boleto_recarga_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_boleto_recarga_param_id}}}</param>
        /// <param name="valor">{{{boleto_recarga_request_valor_value}}}</param>
        /// <param name="dataVencimento">{{{boleto_recarga_request_data_vencimento_value}}}</param>
        /// <returns>Task of BoletoResponse</returns>
        public async System.Threading.Tasks.Task<BoletoResponse> GerarBoletoRecargaUsingPOSTAsync (long? id, double? valor, string dataVencimento)
        {
             ApiResponse<BoletoResponse> localVarResponse = await GerarBoletoRecargaUsingPOSTAsyncWithHttpInfo(id, valor, dataVencimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_resource_gerar_boleto_recarga}}} {{{conta_resource_gerar_boleto_recarga_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_boleto_recarga_param_id}}}</param>
        /// <param name="valor">{{{boleto_recarga_request_valor_value}}}</param>
        /// <param name="dataVencimento">{{{boleto_recarga_request_data_vencimento_value}}}</param>
        /// <returns>Task of ApiResponse (BoletoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BoletoResponse>> GerarBoletoRecargaUsingPOSTAsyncWithHttpInfo (long? id, double? valor, string dataVencimento)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GerarBoletoRecargaUsingPOST");
            // verify the required parameter 'valor' is set
            if (valor == null) throw new ApiException(400, "Missing required parameter 'valor' when calling GerarBoletoRecargaUsingPOST");
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null) throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling GerarBoletoRecargaUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/gerar-boleto-recarga";
    
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
            
            if (valor != null) localVarQueryParams.Add("valor", Configuration.ApiClient.ParameterToString(valor)); // query parameter
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoRecargaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoRecargaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoResponse)));
            
        }
        
        /// <summary>
        /// {{{conta_resource_gerar_cartao_embossing}}} {{{conta_resource_gerar_cartao_embossing_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_cartao_embossing_param_id}}}</param> 
        /// <param name="cartaoEmbossingRequest">cartaoEmbossingRequest</param> 
        /// <returns>CartaoEmbossingResponse</returns>
        public CartaoEmbossingResponse GerarCartaoEmbossingUsingPOST (long? id, CartaoEmbossingRequest cartaoEmbossingRequest)
        {
             ApiResponse<CartaoEmbossingResponse> localVarResponse = GerarCartaoEmbossingUsingPOSTWithHttpInfo(id, cartaoEmbossingRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_resource_gerar_cartao_embossing}}} {{{conta_resource_gerar_cartao_embossing_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_cartao_embossing_param_id}}}</param> 
        /// <param name="cartaoEmbossingRequest">cartaoEmbossingRequest</param> 
        /// <returns>ApiResponse of CartaoEmbossingResponse</returns>
        public ApiResponse< CartaoEmbossingResponse > GerarCartaoEmbossingUsingPOSTWithHttpInfo (long? id, CartaoEmbossingRequest cartaoEmbossingRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->GerarCartaoEmbossingUsingPOST");
            
            // verify the required parameter 'cartaoEmbossingRequest' is set
            if (cartaoEmbossingRequest == null)
                throw new ApiException(400, "Missing required parameter 'cartaoEmbossingRequest' when calling GlobaltagcontaApi->GerarCartaoEmbossingUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/gerar-cartao-grafica";
    
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
            
            
            
            
            if (cartaoEmbossingRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cartaoEmbossingRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cartaoEmbossingRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoEmbossingUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoEmbossingUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoEmbossingResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoEmbossingResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoEmbossingResponse)));
            
        }

        
        /// <summary>
        /// {{{conta_resource_gerar_cartao_embossing}}} {{{conta_resource_gerar_cartao_embossing_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_cartao_embossing_param_id}}}</param>
        /// <param name="cartaoEmbossingRequest">cartaoEmbossingRequest</param>
        /// <returns>Task of CartaoEmbossingResponse</returns>
        public async System.Threading.Tasks.Task<CartaoEmbossingResponse> GerarCartaoEmbossingUsingPOSTAsync (long? id, CartaoEmbossingRequest cartaoEmbossingRequest)
        {
             ApiResponse<CartaoEmbossingResponse> localVarResponse = await GerarCartaoEmbossingUsingPOSTAsyncWithHttpInfo(id, cartaoEmbossingRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_resource_gerar_cartao_embossing}}} {{{conta_resource_gerar_cartao_embossing_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_cartao_embossing_param_id}}}</param>
        /// <param name="cartaoEmbossingRequest">cartaoEmbossingRequest</param>
        /// <returns>Task of ApiResponse (CartaoEmbossingResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoEmbossingResponse>> GerarCartaoEmbossingUsingPOSTAsyncWithHttpInfo (long? id, CartaoEmbossingRequest cartaoEmbossingRequest)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GerarCartaoEmbossingUsingPOST");
            // verify the required parameter 'cartaoEmbossingRequest' is set
            if (cartaoEmbossingRequest == null) throw new ApiException(400, "Missing required parameter 'cartaoEmbossingRequest' when calling GerarCartaoEmbossingUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/gerar-cartao-grafica";
    
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
            
            
            
            
            if (cartaoEmbossingRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cartaoEmbossingRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cartaoEmbossingRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoEmbossingUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoEmbossingUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoEmbossingResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoEmbossingResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoEmbossingResponse)));
            
        }
        
        /// <summary>
        /// {{{conta_resource_gerar_cartao_provisorio}}} {{{conta_resource_gerar_cartao_provisorio_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_cartao_provisorio_param_id_conta}}}</param> 
        /// <returns>CartaoImpressaoProvisorioResponse</returns>
        public CartaoImpressaoProvisorioResponse GerarCartaoProvisorioUsingPOST (long? id)
        {
             ApiResponse<CartaoImpressaoProvisorioResponse> localVarResponse = GerarCartaoProvisorioUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_resource_gerar_cartao_provisorio}}} {{{conta_resource_gerar_cartao_provisorio_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_cartao_provisorio_param_id_conta}}}</param> 
        /// <returns>ApiResponse of CartaoImpressaoProvisorioResponse</returns>
        public ApiResponse< CartaoImpressaoProvisorioResponse > GerarCartaoProvisorioUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->GerarCartaoProvisorioUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/gerar-cartao-provisorio";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoProvisorioUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoProvisorioUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoImpressaoProvisorioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoImpressaoProvisorioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoImpressaoProvisorioResponse)));
            
        }

        
        /// <summary>
        /// {{{conta_resource_gerar_cartao_provisorio}}} {{{conta_resource_gerar_cartao_provisorio_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_cartao_provisorio_param_id_conta}}}</param>
        /// <returns>Task of CartaoImpressaoProvisorioResponse</returns>
        public async System.Threading.Tasks.Task<CartaoImpressaoProvisorioResponse> GerarCartaoProvisorioUsingPOSTAsync (long? id)
        {
             ApiResponse<CartaoImpressaoProvisorioResponse> localVarResponse = await GerarCartaoProvisorioUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_resource_gerar_cartao_provisorio}}} {{{conta_resource_gerar_cartao_provisorio_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_cartao_provisorio_param_id_conta}}}</param>
        /// <returns>Task of ApiResponse (CartaoImpressaoProvisorioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoImpressaoProvisorioResponse>> GerarCartaoProvisorioUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GerarCartaoProvisorioUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/gerar-cartao-provisorio";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoProvisorioUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoProvisorioUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoImpressaoProvisorioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoImpressaoProvisorioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoImpressaoProvisorioResponse)));
            
        }
        
        /// <summary>
        /// {{{conta_resource_gerar_cartao}}} {{{conta_resource_gerar_cartao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_cartao_param_id}}}</param> 
        /// <param name="idPessoa">{{{conta_resource_gerar_cartao_param_id_pessoa}}}</param> 
        /// <param name="idTipoPlastico">{{{conta_resource_gerar_cartao_param_id_tipo_plastico}}} (optional)</param> 
        /// <returns>CartaoImpressaoResponse</returns>
        public CartaoImpressaoResponse GerarCartaoUsingPOST (long? id, long? idPessoa, long? idTipoPlastico = null)
        {
             ApiResponse<CartaoImpressaoResponse> localVarResponse = GerarCartaoUsingPOSTWithHttpInfo(id, idPessoa, idTipoPlastico);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_resource_gerar_cartao}}} {{{conta_resource_gerar_cartao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_cartao_param_id}}}</param> 
        /// <param name="idPessoa">{{{conta_resource_gerar_cartao_param_id_pessoa}}}</param> 
        /// <param name="idTipoPlastico">{{{conta_resource_gerar_cartao_param_id_tipo_plastico}}} (optional)</param> 
        /// <returns>ApiResponse of CartaoImpressaoResponse</returns>
        public ApiResponse< CartaoImpressaoResponse > GerarCartaoUsingPOSTWithHttpInfo (long? id, long? idPessoa, long? idTipoPlastico = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->GerarCartaoUsingPOST");
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling GlobaltagcontaApi->GerarCartaoUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/pessoas/{id_pessoa}/gerar-cartao";
    
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
            if (idPessoa != null) localVarPathParams.Add("id_pessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // path parameter
            
            if (idTipoPlastico != null) localVarQueryParams.Add("id_tipo_plastico", Configuration.ApiClient.ParameterToString(idTipoPlastico)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoImpressaoResponse)));
            
        }

        
        /// <summary>
        /// {{{conta_resource_gerar_cartao}}} {{{conta_resource_gerar_cartao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_cartao_param_id}}}</param>
        /// <param name="idPessoa">{{{conta_resource_gerar_cartao_param_id_pessoa}}}</param>
        /// <param name="idTipoPlastico">{{{conta_resource_gerar_cartao_param_id_tipo_plastico}}} (optional)</param>
        /// <returns>Task of CartaoImpressaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoImpressaoResponse> GerarCartaoUsingPOSTAsync (long? id, long? idPessoa, long? idTipoPlastico = null)
        {
             ApiResponse<CartaoImpressaoResponse> localVarResponse = await GerarCartaoUsingPOSTAsyncWithHttpInfo(id, idPessoa, idTipoPlastico);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_resource_gerar_cartao}}} {{{conta_resource_gerar_cartao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_cartao_param_id}}}</param>
        /// <param name="idPessoa">{{{conta_resource_gerar_cartao_param_id_pessoa}}}</param>
        /// <param name="idTipoPlastico">{{{conta_resource_gerar_cartao_param_id_tipo_plastico}}} (optional)</param>
        /// <returns>Task of ApiResponse (CartaoImpressaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoImpressaoResponse>> GerarCartaoUsingPOSTAsyncWithHttpInfo (long? id, long? idPessoa, long? idTipoPlastico = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GerarCartaoUsingPOST");
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling GerarCartaoUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/pessoas/{id_pessoa}/gerar-cartao";
    
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
            if (idPessoa != null) localVarPathParams.Add("id_pessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // path parameter
            
            if (idTipoPlastico != null) localVarQueryParams.Add("id_tipo_plastico", Configuration.ApiClient.ParameterToString(idTipoPlastico)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoImpressaoResponse)));
            
        }
        
        /// <summary>
        /// {{{conta_resource_gerar_cartao_virtual}}} {{{conta_resource_gerar_cartao_virtual_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_cartao_virtual_param_id}}}</param> 
        /// <param name="dataValidade">{{{conta_resource_gerar_cartao_virtual_param_data_validade}}}</param> 
        /// <returns>CartaoImpressaoResponse</returns>
        public CartaoImpressaoResponse GerarCartaoVirtualUsingPOST (long? id, string dataValidade)
        {
             ApiResponse<CartaoImpressaoResponse> localVarResponse = GerarCartaoVirtualUsingPOSTWithHttpInfo(id, dataValidade);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_resource_gerar_cartao_virtual}}} {{{conta_resource_gerar_cartao_virtual_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_cartao_virtual_param_id}}}</param> 
        /// <param name="dataValidade">{{{conta_resource_gerar_cartao_virtual_param_data_validade}}}</param> 
        /// <returns>ApiResponse of CartaoImpressaoResponse</returns>
        public ApiResponse< CartaoImpressaoResponse > GerarCartaoVirtualUsingPOSTWithHttpInfo (long? id, string dataValidade)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->GerarCartaoVirtualUsingPOST");
            
            // verify the required parameter 'dataValidade' is set
            if (dataValidade == null)
                throw new ApiException(400, "Missing required parameter 'dataValidade' when calling GlobaltagcontaApi->GerarCartaoVirtualUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/gerar-cartao-virtual";
    
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
            
            if (dataValidade != null) localVarQueryParams.Add("dataValidade", Configuration.ApiClient.ParameterToString(dataValidade)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoVirtualUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoVirtualUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoImpressaoResponse)));
            
        }

        
        /// <summary>
        /// {{{conta_resource_gerar_cartao_virtual}}} {{{conta_resource_gerar_cartao_virtual_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_cartao_virtual_param_id}}}</param>
        /// <param name="dataValidade">{{{conta_resource_gerar_cartao_virtual_param_data_validade}}}</param>
        /// <returns>Task of CartaoImpressaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoImpressaoResponse> GerarCartaoVirtualUsingPOSTAsync (long? id, string dataValidade)
        {
             ApiResponse<CartaoImpressaoResponse> localVarResponse = await GerarCartaoVirtualUsingPOSTAsyncWithHttpInfo(id, dataValidade);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_resource_gerar_cartao_virtual}}} {{{conta_resource_gerar_cartao_virtual_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_gerar_cartao_virtual_param_id}}}</param>
        /// <param name="dataValidade">{{{conta_resource_gerar_cartao_virtual_param_data_validade}}}</param>
        /// <returns>Task of ApiResponse (CartaoImpressaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoImpressaoResponse>> GerarCartaoVirtualUsingPOSTAsyncWithHttpInfo (long? id, string dataValidade)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GerarCartaoVirtualUsingPOST");
            // verify the required parameter 'dataValidade' is set
            if (dataValidade == null) throw new ApiException(400, "Missing required parameter 'dataValidade' when calling GerarCartaoVirtualUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/gerar-cartao-virtual";
    
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
            
            if (dataValidade != null) localVarQueryParams.Add("dataValidade", Configuration.ApiClient.ParameterToString(dataValidade)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoVirtualUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoVirtualUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoImpressaoResponse)));
            
        }
        
        /// <summary>
        /// {{{conta_resource_listar_historico_alteracoes_limites}}} {{{conta_resource_listar_historico_alteracoes_limites_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_listar_historico_alteracoes_limites_param_id}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>PageHistoricoEventosResponse</returns>
        public PageHistoricoEventosResponse ListarHistoricoAlteracoesLimitesUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageHistoricoEventosResponse> localVarResponse = ListarHistoricoAlteracoesLimitesUsingGETWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_resource_listar_historico_alteracoes_limites}}} {{{conta_resource_listar_historico_alteracoes_limites_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_listar_historico_alteracoes_limites_param_id}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>ApiResponse of PageHistoricoEventosResponse</returns>
        public ApiResponse< PageHistoricoEventosResponse > ListarHistoricoAlteracoesLimitesUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->ListarHistoricoAlteracoesLimitesUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/historicos-alteracoes-limites";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAlteracoesLimitesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAlteracoesLimitesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageHistoricoEventosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoEventosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoEventosResponse)));
            
        }

        
        /// <summary>
        /// {{{conta_resource_listar_historico_alteracoes_limites}}} {{{conta_resource_listar_historico_alteracoes_limites_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_listar_historico_alteracoes_limites_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageHistoricoEventosResponse</returns>
        public async System.Threading.Tasks.Task<PageHistoricoEventosResponse> ListarHistoricoAlteracoesLimitesUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageHistoricoEventosResponse> localVarResponse = await ListarHistoricoAlteracoesLimitesUsingGETAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_resource_listar_historico_alteracoes_limites}}} {{{conta_resource_listar_historico_alteracoes_limites_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_listar_historico_alteracoes_limites_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoEventosResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageHistoricoEventosResponse>> ListarHistoricoAlteracoesLimitesUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarHistoricoAlteracoesLimitesUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/historicos-alteracoes-limites";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAlteracoesLimitesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAlteracoesLimitesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageHistoricoEventosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoEventosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoEventosResponse)));
            
        }
        
        /// <summary>
        /// {{{conta_resource_listar_historico_assessoria}}} {{{conta_resource_listar_historico_assessoria_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_listar_historico_assessoria_param_id}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>PageHistoricoAssessoriaResponse</returns>
        public PageHistoricoAssessoriaResponse ListarHistoricoAssessoriaUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageHistoricoAssessoriaResponse> localVarResponse = ListarHistoricoAssessoriaUsingGETWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_resource_listar_historico_assessoria}}} {{{conta_resource_listar_historico_assessoria_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_listar_historico_assessoria_param_id}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>ApiResponse of PageHistoricoAssessoriaResponse</returns>
        public ApiResponse< PageHistoricoAssessoriaResponse > ListarHistoricoAssessoriaUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->ListarHistoricoAssessoriaUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/historicos-assessorias-cobranca";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAssessoriaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAssessoriaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageHistoricoAssessoriaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoAssessoriaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoAssessoriaResponse)));
            
        }

        
        /// <summary>
        /// {{{conta_resource_listar_historico_assessoria}}} {{{conta_resource_listar_historico_assessoria_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_listar_historico_assessoria_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageHistoricoAssessoriaResponse</returns>
        public async System.Threading.Tasks.Task<PageHistoricoAssessoriaResponse> ListarHistoricoAssessoriaUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageHistoricoAssessoriaResponse> localVarResponse = await ListarHistoricoAssessoriaUsingGETAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_resource_listar_historico_assessoria}}} {{{conta_resource_listar_historico_assessoria_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_listar_historico_assessoria_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoAssessoriaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageHistoricoAssessoriaResponse>> ListarHistoricoAssessoriaUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarHistoricoAssessoriaUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/historicos-assessorias-cobranca";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAssessoriaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAssessoriaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageHistoricoAssessoriaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoAssessoriaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoAssessoriaResponse)));
            
        }
        
        /// <summary>
        /// {{{conta_resource_listar_historico_atrasos_faturas}}} {{{conta_resource_listar_historico_atrasos_faturas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_listar_historico_atrasos_faturas_param_id}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>PageHistoricoAtrasoFaturaResponse</returns>
        public PageHistoricoAtrasoFaturaResponse ListarHistoricoAtrasosFaturasUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageHistoricoAtrasoFaturaResponse> localVarResponse = ListarHistoricoAtrasosFaturasUsingGETWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_resource_listar_historico_atrasos_faturas}}} {{{conta_resource_listar_historico_atrasos_faturas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_listar_historico_atrasos_faturas_param_id}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>ApiResponse of PageHistoricoAtrasoFaturaResponse</returns>
        public ApiResponse< PageHistoricoAtrasoFaturaResponse > ListarHistoricoAtrasosFaturasUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->ListarHistoricoAtrasosFaturasUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/historicos-faturas-atrasos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAtrasosFaturasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAtrasosFaturasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageHistoricoAtrasoFaturaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoAtrasoFaturaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoAtrasoFaturaResponse)));
            
        }

        
        /// <summary>
        /// {{{conta_resource_listar_historico_atrasos_faturas}}} {{{conta_resource_listar_historico_atrasos_faturas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_listar_historico_atrasos_faturas_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageHistoricoAtrasoFaturaResponse</returns>
        public async System.Threading.Tasks.Task<PageHistoricoAtrasoFaturaResponse> ListarHistoricoAtrasosFaturasUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageHistoricoAtrasoFaturaResponse> localVarResponse = await ListarHistoricoAtrasosFaturasUsingGETAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_resource_listar_historico_atrasos_faturas}}} {{{conta_resource_listar_historico_atrasos_faturas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_listar_historico_atrasos_faturas_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoAtrasoFaturaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageHistoricoAtrasoFaturaResponse>> ListarHistoricoAtrasosFaturasUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarHistoricoAtrasosFaturasUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/historicos-faturas-atrasos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAtrasosFaturasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAtrasosFaturasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageHistoricoAtrasoFaturaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoAtrasoFaturaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoAtrasoFaturaResponse)));
            
        }
        
        /// <summary>
        /// {{{transacoes_correntes_resource_listar_nao_processadas}}} {{{transacoes_correntes_resource_listar_nao_processadas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transacoes_correntes_resource_listar_nao_processadas_param_id}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="dataInicio">{{{transacoes_nao_processadas_request_data_inicio_value}}} (optional)</param> 
        /// <param name="dataFim">{{{transacoes_nao_processadas_request_data_fim_value}}} (optional)</param> 
        /// <returns>PageTransacaoNaoProcessadaResponse</returns>
        public PageTransacaoNaoProcessadaResponse ListarNaoProcessadasUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null)
        {
             ApiResponse<PageTransacaoNaoProcessadaResponse> localVarResponse = ListarNaoProcessadasUsingGETWithHttpInfo(id, sort, page, limit, dataInicio, dataFim);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{transacoes_correntes_resource_listar_nao_processadas}}} {{{transacoes_correntes_resource_listar_nao_processadas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transacoes_correntes_resource_listar_nao_processadas_param_id}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="dataInicio">{{{transacoes_nao_processadas_request_data_inicio_value}}} (optional)</param> 
        /// <param name="dataFim">{{{transacoes_nao_processadas_request_data_fim_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageTransacaoNaoProcessadaResponse</returns>
        public ApiResponse< PageTransacaoNaoProcessadaResponse > ListarNaoProcessadasUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->ListarNaoProcessadasUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/transacoes/listar-nao-processadas";
    
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
            if (dataInicio != null) localVarQueryParams.Add("dataInicio", Configuration.ApiClient.ParameterToString(dataInicio)); // query parameter
            if (dataFim != null) localVarQueryParams.Add("dataFim", Configuration.ApiClient.ParameterToString(dataFim)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarNaoProcessadasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarNaoProcessadasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTransacaoNaoProcessadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacaoNaoProcessadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacaoNaoProcessadaResponse)));
            
        }

        
        /// <summary>
        /// {{{transacoes_correntes_resource_listar_nao_processadas}}} {{{transacoes_correntes_resource_listar_nao_processadas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transacoes_correntes_resource_listar_nao_processadas_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataInicio">{{{transacoes_nao_processadas_request_data_inicio_value}}} (optional)</param>
        /// <param name="dataFim">{{{transacoes_nao_processadas_request_data_fim_value}}} (optional)</param>
        /// <returns>Task of PageTransacaoNaoProcessadaResponse</returns>
        public async System.Threading.Tasks.Task<PageTransacaoNaoProcessadaResponse> ListarNaoProcessadasUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null)
        {
             ApiResponse<PageTransacaoNaoProcessadaResponse> localVarResponse = await ListarNaoProcessadasUsingGETAsyncWithHttpInfo(id, sort, page, limit, dataInicio, dataFim);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{transacoes_correntes_resource_listar_nao_processadas}}} {{{transacoes_correntes_resource_listar_nao_processadas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transacoes_correntes_resource_listar_nao_processadas_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataInicio">{{{transacoes_nao_processadas_request_data_inicio_value}}} (optional)</param>
        /// <param name="dataFim">{{{transacoes_nao_processadas_request_data_fim_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacaoNaoProcessadaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransacaoNaoProcessadaResponse>> ListarNaoProcessadasUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarNaoProcessadasUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/transacoes/listar-nao-processadas";
    
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
            if (dataInicio != null) localVarQueryParams.Add("dataInicio", Configuration.ApiClient.ParameterToString(dataInicio)); // query parameter
            if (dataFim != null) localVarQueryParams.Add("dataFim", Configuration.ApiClient.ParameterToString(dataFim)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarNaoProcessadasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarNaoProcessadasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTransacaoNaoProcessadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacaoNaoProcessadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacaoNaoProcessadaResponse)));
            
        }
        
        /// <summary>
        /// {{{transacoes_correntes_resource_listar_processadas}}} {{{transacoes_correntes_resource_listar_processadas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transacoes_correntes_resource_listar_processadas_param_id}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="dataVencimento">{{{transacoes_processadas_request_data_vencimento_value}}} (optional)</param> 
        /// <param name="dataInicio">{{{transacoes_processadas_request_data_inicio_value}}} (optional)</param> 
        /// <param name="dataFim">{{{transacoes_processadas_request_data_fim_value}}} (optional)</param> 
        /// <param name="idTipoTransacao">{{{transacoes_processadas_request_tipo_transacao}}} (optional)</param> 
        /// <param name="recuperaEncargos">{{{transacoes_processadas_request_recupera_encargos}}} (optional)</param> 
        /// <returns>PageTransacoesCorrentesResponse</returns>
        public PageTransacoesCorrentesResponse ListarProcessadasUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, int? recuperaEncargos = null)
        {
             ApiResponse<PageTransacoesCorrentesResponse> localVarResponse = ListarProcessadasUsingGETWithHttpInfo(id, sort, page, limit, dataVencimento, dataInicio, dataFim, idTipoTransacao, recuperaEncargos);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{transacoes_correntes_resource_listar_processadas}}} {{{transacoes_correntes_resource_listar_processadas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transacoes_correntes_resource_listar_processadas_param_id}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="dataVencimento">{{{transacoes_processadas_request_data_vencimento_value}}} (optional)</param> 
        /// <param name="dataInicio">{{{transacoes_processadas_request_data_inicio_value}}} (optional)</param> 
        /// <param name="dataFim">{{{transacoes_processadas_request_data_fim_value}}} (optional)</param> 
        /// <param name="idTipoTransacao">{{{transacoes_processadas_request_tipo_transacao}}} (optional)</param> 
        /// <param name="recuperaEncargos">{{{transacoes_processadas_request_recupera_encargos}}} (optional)</param> 
        /// <returns>ApiResponse of PageTransacoesCorrentesResponse</returns>
        public ApiResponse< PageTransacoesCorrentesResponse > ListarProcessadasUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, int? recuperaEncargos = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->ListarProcessadasUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/transacoes/listar-processadas";
    
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
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            if (dataInicio != null) localVarQueryParams.Add("dataInicio", Configuration.ApiClient.ParameterToString(dataInicio)); // query parameter
            if (dataFim != null) localVarQueryParams.Add("dataFim", Configuration.ApiClient.ParameterToString(dataFim)); // query parameter
            if (idTipoTransacao != null) localVarQueryParams.Add("idTipoTransacao", Configuration.ApiClient.ParameterToString(idTipoTransacao)); // query parameter
            if (recuperaEncargos != null) localVarQueryParams.Add("recuperaEncargos", Configuration.ApiClient.ParameterToString(recuperaEncargos)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarProcessadasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarProcessadasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTransacoesCorrentesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacoesCorrentesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacoesCorrentesResponse)));
            
        }

        
        /// <summary>
        /// {{{transacoes_correntes_resource_listar_processadas}}} {{{transacoes_correntes_resource_listar_processadas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transacoes_correntes_resource_listar_processadas_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataVencimento">{{{transacoes_processadas_request_data_vencimento_value}}} (optional)</param>
        /// <param name="dataInicio">{{{transacoes_processadas_request_data_inicio_value}}} (optional)</param>
        /// <param name="dataFim">{{{transacoes_processadas_request_data_fim_value}}} (optional)</param>
        /// <param name="idTipoTransacao">{{{transacoes_processadas_request_tipo_transacao}}} (optional)</param>
        /// <param name="recuperaEncargos">{{{transacoes_processadas_request_recupera_encargos}}} (optional)</param>
        /// <returns>Task of PageTransacoesCorrentesResponse</returns>
        public async System.Threading.Tasks.Task<PageTransacoesCorrentesResponse> ListarProcessadasUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, int? recuperaEncargos = null)
        {
             ApiResponse<PageTransacoesCorrentesResponse> localVarResponse = await ListarProcessadasUsingGETAsyncWithHttpInfo(id, sort, page, limit, dataVencimento, dataInicio, dataFim, idTipoTransacao, recuperaEncargos);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{transacoes_correntes_resource_listar_processadas}}} {{{transacoes_correntes_resource_listar_processadas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transacoes_correntes_resource_listar_processadas_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataVencimento">{{{transacoes_processadas_request_data_vencimento_value}}} (optional)</param>
        /// <param name="dataInicio">{{{transacoes_processadas_request_data_inicio_value}}} (optional)</param>
        /// <param name="dataFim">{{{transacoes_processadas_request_data_fim_value}}} (optional)</param>
        /// <param name="idTipoTransacao">{{{transacoes_processadas_request_tipo_transacao}}} (optional)</param>
        /// <param name="recuperaEncargos">{{{transacoes_processadas_request_recupera_encargos}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacoesCorrentesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransacoesCorrentesResponse>> ListarProcessadasUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, int? recuperaEncargos = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarProcessadasUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/transacoes/listar-processadas";
    
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
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            if (dataInicio != null) localVarQueryParams.Add("dataInicio", Configuration.ApiClient.ParameterToString(dataInicio)); // query parameter
            if (dataFim != null) localVarQueryParams.Add("dataFim", Configuration.ApiClient.ParameterToString(dataFim)); // query parameter
            if (idTipoTransacao != null) localVarQueryParams.Add("idTipoTransacao", Configuration.ApiClient.ParameterToString(idTipoTransacao)); // query parameter
            if (recuperaEncargos != null) localVarQueryParams.Add("recuperaEncargos", Configuration.ApiClient.ParameterToString(recuperaEncargos)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarProcessadasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarProcessadasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTransacoesCorrentesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacoesCorrentesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacoesCorrentesResponse)));
            
        }
        
        /// <summary>
        /// {{{conta_resource_listar}}} {{{conta_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idProduto">{{{conta_request_id_produto_value}}} (optional)</param> 
        /// <param name="idOrigemComercial">{{{conta_request_id_origem_comercial_value}}} (optional)</param> 
        /// <param name="idPessoa">{{{conta_request_id_pessoa_value}}} (optional)</param> 
        /// <param name="idStatusConta">{{{conta_request_id_status_conta_value}}} (optional)</param> 
        /// <param name="diaVencimento">{{{conta_request_dia_vencimento_value}}} (optional)</param> 
        /// <param name="melhorDiaCompra">{{{conta_request_melhor_dia_compra_value}}} (optional)</param> 
        /// <param name="dataStatusConta">{{{conta_request_data_status_conta_value}}} (optional)</param> 
        /// <param name="dataCadastro">{{{conta_request_data_cadastro_value}}} (optional)</param> 
        /// <param name="dataUltimaAlteracaoVencimento">{{{conta_request_data_ultima_alteracao_vencimento_value}}} (optional)</param> 
        /// <returns>PageContaResponse</returns>
        public PageContaResponse ListarUsingGET17 (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, string dataStatusConta = null, string dataCadastro = null, string dataUltimaAlteracaoVencimento = null)
        {
             ApiResponse<PageContaResponse> localVarResponse = ListarUsingGET17WithHttpInfo(sort, page, limit, idProduto, idOrigemComercial, idPessoa, idStatusConta, diaVencimento, melhorDiaCompra, dataStatusConta, dataCadastro, dataUltimaAlteracaoVencimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_resource_listar}}} {{{conta_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idProduto">{{{conta_request_id_produto_value}}} (optional)</param> 
        /// <param name="idOrigemComercial">{{{conta_request_id_origem_comercial_value}}} (optional)</param> 
        /// <param name="idPessoa">{{{conta_request_id_pessoa_value}}} (optional)</param> 
        /// <param name="idStatusConta">{{{conta_request_id_status_conta_value}}} (optional)</param> 
        /// <param name="diaVencimento">{{{conta_request_dia_vencimento_value}}} (optional)</param> 
        /// <param name="melhorDiaCompra">{{{conta_request_melhor_dia_compra_value}}} (optional)</param> 
        /// <param name="dataStatusConta">{{{conta_request_data_status_conta_value}}} (optional)</param> 
        /// <param name="dataCadastro">{{{conta_request_data_cadastro_value}}} (optional)</param> 
        /// <param name="dataUltimaAlteracaoVencimento">{{{conta_request_data_ultima_alteracao_vencimento_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageContaResponse</returns>
        public ApiResponse< PageContaResponse > ListarUsingGET17WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, string dataStatusConta = null, string dataCadastro = null, string dataUltimaAlteracaoVencimento = null)
        {
            
    
            var localVarPath = "/api/contas";
    
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
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (idOrigemComercial != null) localVarQueryParams.Add("idOrigemComercial", Configuration.ApiClient.ParameterToString(idOrigemComercial)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (idStatusConta != null) localVarQueryParams.Add("idStatusConta", Configuration.ApiClient.ParameterToString(idStatusConta)); // query parameter
            if (diaVencimento != null) localVarQueryParams.Add("diaVencimento", Configuration.ApiClient.ParameterToString(diaVencimento)); // query parameter
            if (melhorDiaCompra != null) localVarQueryParams.Add("melhorDiaCompra", Configuration.ApiClient.ParameterToString(melhorDiaCompra)); // query parameter
            if (dataStatusConta != null) localVarQueryParams.Add("dataStatusConta", Configuration.ApiClient.ParameterToString(dataStatusConta)); // query parameter
            if (dataCadastro != null) localVarQueryParams.Add("dataCadastro", Configuration.ApiClient.ParameterToString(dataCadastro)); // query parameter
            if (dataUltimaAlteracaoVencimento != null) localVarQueryParams.Add("dataUltimaAlteracaoVencimento", Configuration.ApiClient.ParameterToString(dataUltimaAlteracaoVencimento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET17: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET17: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaResponse)));
            
        }

        
        /// <summary>
        /// {{{conta_resource_listar}}} {{{conta_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idProduto">{{{conta_request_id_produto_value}}} (optional)</param>
        /// <param name="idOrigemComercial">{{{conta_request_id_origem_comercial_value}}} (optional)</param>
        /// <param name="idPessoa">{{{conta_request_id_pessoa_value}}} (optional)</param>
        /// <param name="idStatusConta">{{{conta_request_id_status_conta_value}}} (optional)</param>
        /// <param name="diaVencimento">{{{conta_request_dia_vencimento_value}}} (optional)</param>
        /// <param name="melhorDiaCompra">{{{conta_request_melhor_dia_compra_value}}} (optional)</param>
        /// <param name="dataStatusConta">{{{conta_request_data_status_conta_value}}} (optional)</param>
        /// <param name="dataCadastro">{{{conta_request_data_cadastro_value}}} (optional)</param>
        /// <param name="dataUltimaAlteracaoVencimento">{{{conta_request_data_ultima_alteracao_vencimento_value}}} (optional)</param>
        /// <returns>Task of PageContaResponse</returns>
        public async System.Threading.Tasks.Task<PageContaResponse> ListarUsingGET17Async (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, string dataStatusConta = null, string dataCadastro = null, string dataUltimaAlteracaoVencimento = null)
        {
             ApiResponse<PageContaResponse> localVarResponse = await ListarUsingGET17AsyncWithHttpInfo(sort, page, limit, idProduto, idOrigemComercial, idPessoa, idStatusConta, diaVencimento, melhorDiaCompra, dataStatusConta, dataCadastro, dataUltimaAlteracaoVencimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_resource_listar}}} {{{conta_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idProduto">{{{conta_request_id_produto_value}}} (optional)</param>
        /// <param name="idOrigemComercial">{{{conta_request_id_origem_comercial_value}}} (optional)</param>
        /// <param name="idPessoa">{{{conta_request_id_pessoa_value}}} (optional)</param>
        /// <param name="idStatusConta">{{{conta_request_id_status_conta_value}}} (optional)</param>
        /// <param name="diaVencimento">{{{conta_request_dia_vencimento_value}}} (optional)</param>
        /// <param name="melhorDiaCompra">{{{conta_request_melhor_dia_compra_value}}} (optional)</param>
        /// <param name="dataStatusConta">{{{conta_request_data_status_conta_value}}} (optional)</param>
        /// <param name="dataCadastro">{{{conta_request_data_cadastro_value}}} (optional)</param>
        /// <param name="dataUltimaAlteracaoVencimento">{{{conta_request_data_ultima_alteracao_vencimento_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageContaResponse>> ListarUsingGET17AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, string dataStatusConta = null, string dataCadastro = null, string dataUltimaAlteracaoVencimento = null)
        {
            
    
            var localVarPath = "/api/contas";
    
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
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (idOrigemComercial != null) localVarQueryParams.Add("idOrigemComercial", Configuration.ApiClient.ParameterToString(idOrigemComercial)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (idStatusConta != null) localVarQueryParams.Add("idStatusConta", Configuration.ApiClient.ParameterToString(idStatusConta)); // query parameter
            if (diaVencimento != null) localVarQueryParams.Add("diaVencimento", Configuration.ApiClient.ParameterToString(diaVencimento)); // query parameter
            if (melhorDiaCompra != null) localVarQueryParams.Add("melhorDiaCompra", Configuration.ApiClient.ParameterToString(melhorDiaCompra)); // query parameter
            if (dataStatusConta != null) localVarQueryParams.Add("dataStatusConta", Configuration.ApiClient.ParameterToString(dataStatusConta)); // query parameter
            if (dataCadastro != null) localVarQueryParams.Add("dataCadastro", Configuration.ApiClient.ParameterToString(dataCadastro)); // query parameter
            if (dataUltimaAlteracaoVencimento != null) localVarQueryParams.Add("dataUltimaAlteracaoVencimento", Configuration.ApiClient.ParameterToString(dataUltimaAlteracaoVencimento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET17: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET17: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaResponse)));
            
        }
        
        /// <summary>
        /// {{{transacoes_correntes_resource_listar_nao_processadas_e_processadas}}} {{{transacoes_correntes_resource_listar_nao_processadas_e_processadas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transacoes_correntes_resource_listar_nao_processadas_param_id}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="dataVencimento">{{{transacoes_processadas_request_data_vencimento_value}}} (optional)</param> 
        /// <param name="dataInicio">{{{transacoes_processadas_request_data_inicio_value}}} (optional)</param> 
        /// <param name="dataFim">{{{transacoes_processadas_request_data_fim_value}}} (optional)</param> 
        /// <param name="idTipoTransacao">{{{transacoes_processadas_request_tipo_transacao}}} (optional)</param> 
        /// <param name="flagCredito">{{{transacoes_processadas_request_flag_credito}}} (optional)</param> 
        /// <param name="flagFaturado">{{{transacoes_processadas_request_flag_faturado}}} (optional)</param> 
        /// <param name="flagProcessada">{{{transacoes_processadas_request_flag_processada}}} (optional)</param> 
        /// <param name="status">{{{transacoes_processadas_request_status}}} (optional)</param> 
        /// <param name="plano">{{{transacoes_processadas_request_plano}}} (optional)</param> 
        /// <param name="codigoMCC">{{{transacoes_processadas_request_codigo_mcc}}} (optional)</param> 
        /// <param name="grupoMCC">{{{transacoes_processadas_request_grupo_mcc}}} (optional)</param> 
        /// <returns>PageTransacaoProcessadaNaoProcessadaResponse</returns>
        public PageTransacaoProcessadaNaoProcessadaResponse ListarUsingGET53 (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, bool? flagCredito = null, bool? flagFaturado = null, bool? flagProcessada = null, int? status = null, int? plano = null, long? codigoMCC = null, long? grupoMCC = null)
        {
             ApiResponse<PageTransacaoProcessadaNaoProcessadaResponse> localVarResponse = ListarUsingGET53WithHttpInfo(id, sort, page, limit, dataVencimento, dataInicio, dataFim, idTipoTransacao, flagCredito, flagFaturado, flagProcessada, status, plano, codigoMCC, grupoMCC);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{transacoes_correntes_resource_listar_nao_processadas_e_processadas}}} {{{transacoes_correntes_resource_listar_nao_processadas_e_processadas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transacoes_correntes_resource_listar_nao_processadas_param_id}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="dataVencimento">{{{transacoes_processadas_request_data_vencimento_value}}} (optional)</param> 
        /// <param name="dataInicio">{{{transacoes_processadas_request_data_inicio_value}}} (optional)</param> 
        /// <param name="dataFim">{{{transacoes_processadas_request_data_fim_value}}} (optional)</param> 
        /// <param name="idTipoTransacao">{{{transacoes_processadas_request_tipo_transacao}}} (optional)</param> 
        /// <param name="flagCredito">{{{transacoes_processadas_request_flag_credito}}} (optional)</param> 
        /// <param name="flagFaturado">{{{transacoes_processadas_request_flag_faturado}}} (optional)</param> 
        /// <param name="flagProcessada">{{{transacoes_processadas_request_flag_processada}}} (optional)</param> 
        /// <param name="status">{{{transacoes_processadas_request_status}}} (optional)</param> 
        /// <param name="plano">{{{transacoes_processadas_request_plano}}} (optional)</param> 
        /// <param name="codigoMCC">{{{transacoes_processadas_request_codigo_mcc}}} (optional)</param> 
        /// <param name="grupoMCC">{{{transacoes_processadas_request_grupo_mcc}}} (optional)</param> 
        /// <returns>ApiResponse of PageTransacaoProcessadaNaoProcessadaResponse</returns>
        public ApiResponse< PageTransacaoProcessadaNaoProcessadaResponse > ListarUsingGET53WithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, bool? flagCredito = null, bool? flagFaturado = null, bool? flagProcessada = null, int? status = null, int? plano = null, long? codigoMCC = null, long? grupoMCC = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->ListarUsingGET53");
            
    
            var localVarPath = "/api/contas/{id}/transacoes";
    
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
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            if (dataInicio != null) localVarQueryParams.Add("dataInicio", Configuration.ApiClient.ParameterToString(dataInicio)); // query parameter
            if (dataFim != null) localVarQueryParams.Add("dataFim", Configuration.ApiClient.ParameterToString(dataFim)); // query parameter
            if (idTipoTransacao != null) localVarQueryParams.Add("idTipoTransacao", Configuration.ApiClient.ParameterToString(idTipoTransacao)); // query parameter
            if (flagCredito != null) localVarQueryParams.Add("flagCredito", Configuration.ApiClient.ParameterToString(flagCredito)); // query parameter
            if (flagFaturado != null) localVarQueryParams.Add("flagFaturado", Configuration.ApiClient.ParameterToString(flagFaturado)); // query parameter
            if (flagProcessada != null) localVarQueryParams.Add("flagProcessada", Configuration.ApiClient.ParameterToString(flagProcessada)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (plano != null) localVarQueryParams.Add("plano", Configuration.ApiClient.ParameterToString(plano)); // query parameter
            if (codigoMCC != null) localVarQueryParams.Add("codigoMCC", Configuration.ApiClient.ParameterToString(codigoMCC)); // query parameter
            if (grupoMCC != null) localVarQueryParams.Add("grupoMCC", Configuration.ApiClient.ParameterToString(grupoMCC)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET53: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET53: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTransacaoProcessadaNaoProcessadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacaoProcessadaNaoProcessadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacaoProcessadaNaoProcessadaResponse)));
            
        }

        
        /// <summary>
        /// {{{transacoes_correntes_resource_listar_nao_processadas_e_processadas}}} {{{transacoes_correntes_resource_listar_nao_processadas_e_processadas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transacoes_correntes_resource_listar_nao_processadas_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataVencimento">{{{transacoes_processadas_request_data_vencimento_value}}} (optional)</param>
        /// <param name="dataInicio">{{{transacoes_processadas_request_data_inicio_value}}} (optional)</param>
        /// <param name="dataFim">{{{transacoes_processadas_request_data_fim_value}}} (optional)</param>
        /// <param name="idTipoTransacao">{{{transacoes_processadas_request_tipo_transacao}}} (optional)</param>
        /// <param name="flagCredito">{{{transacoes_processadas_request_flag_credito}}} (optional)</param>
        /// <param name="flagFaturado">{{{transacoes_processadas_request_flag_faturado}}} (optional)</param>
        /// <param name="flagProcessada">{{{transacoes_processadas_request_flag_processada}}} (optional)</param>
        /// <param name="status">{{{transacoes_processadas_request_status}}} (optional)</param>
        /// <param name="plano">{{{transacoes_processadas_request_plano}}} (optional)</param>
        /// <param name="codigoMCC">{{{transacoes_processadas_request_codigo_mcc}}} (optional)</param>
        /// <param name="grupoMCC">{{{transacoes_processadas_request_grupo_mcc}}} (optional)</param>
        /// <returns>Task of PageTransacaoProcessadaNaoProcessadaResponse</returns>
        public async System.Threading.Tasks.Task<PageTransacaoProcessadaNaoProcessadaResponse> ListarUsingGET53Async (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, bool? flagCredito = null, bool? flagFaturado = null, bool? flagProcessada = null, int? status = null, int? plano = null, long? codigoMCC = null, long? grupoMCC = null)
        {
             ApiResponse<PageTransacaoProcessadaNaoProcessadaResponse> localVarResponse = await ListarUsingGET53AsyncWithHttpInfo(id, sort, page, limit, dataVencimento, dataInicio, dataFim, idTipoTransacao, flagCredito, flagFaturado, flagProcessada, status, plano, codigoMCC, grupoMCC);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{transacoes_correntes_resource_listar_nao_processadas_e_processadas}}} {{{transacoes_correntes_resource_listar_nao_processadas_e_processadas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transacoes_correntes_resource_listar_nao_processadas_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataVencimento">{{{transacoes_processadas_request_data_vencimento_value}}} (optional)</param>
        /// <param name="dataInicio">{{{transacoes_processadas_request_data_inicio_value}}} (optional)</param>
        /// <param name="dataFim">{{{transacoes_processadas_request_data_fim_value}}} (optional)</param>
        /// <param name="idTipoTransacao">{{{transacoes_processadas_request_tipo_transacao}}} (optional)</param>
        /// <param name="flagCredito">{{{transacoes_processadas_request_flag_credito}}} (optional)</param>
        /// <param name="flagFaturado">{{{transacoes_processadas_request_flag_faturado}}} (optional)</param>
        /// <param name="flagProcessada">{{{transacoes_processadas_request_flag_processada}}} (optional)</param>
        /// <param name="status">{{{transacoes_processadas_request_status}}} (optional)</param>
        /// <param name="plano">{{{transacoes_processadas_request_plano}}} (optional)</param>
        /// <param name="codigoMCC">{{{transacoes_processadas_request_codigo_mcc}}} (optional)</param>
        /// <param name="grupoMCC">{{{transacoes_processadas_request_grupo_mcc}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacaoProcessadaNaoProcessadaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransacaoProcessadaNaoProcessadaResponse>> ListarUsingGET53AsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, bool? flagCredito = null, bool? flagFaturado = null, bool? flagProcessada = null, int? status = null, int? plano = null, long? codigoMCC = null, long? grupoMCC = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarUsingGET53");
            
    
            var localVarPath = "/api/contas/{id}/transacoes";
    
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
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            if (dataInicio != null) localVarQueryParams.Add("dataInicio", Configuration.ApiClient.ParameterToString(dataInicio)); // query parameter
            if (dataFim != null) localVarQueryParams.Add("dataFim", Configuration.ApiClient.ParameterToString(dataFim)); // query parameter
            if (idTipoTransacao != null) localVarQueryParams.Add("idTipoTransacao", Configuration.ApiClient.ParameterToString(idTipoTransacao)); // query parameter
            if (flagCredito != null) localVarQueryParams.Add("flagCredito", Configuration.ApiClient.ParameterToString(flagCredito)); // query parameter
            if (flagFaturado != null) localVarQueryParams.Add("flagFaturado", Configuration.ApiClient.ParameterToString(flagFaturado)); // query parameter
            if (flagProcessada != null) localVarQueryParams.Add("flagProcessada", Configuration.ApiClient.ParameterToString(flagProcessada)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (plano != null) localVarQueryParams.Add("plano", Configuration.ApiClient.ParameterToString(plano)); // query parameter
            if (codigoMCC != null) localVarQueryParams.Add("codigoMCC", Configuration.ApiClient.ParameterToString(codigoMCC)); // query parameter
            if (grupoMCC != null) localVarQueryParams.Add("grupoMCC", Configuration.ApiClient.ParameterToString(grupoMCC)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET53: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET53: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTransacaoProcessadaNaoProcessadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacaoProcessadaNaoProcessadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacaoProcessadaNaoProcessadaResponse)));
            
        }
        
        /// <summary>
        /// {{{transferencia_resource_listar}}} {{{transferencia_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_resource_listar_param_id}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idTransferencia">{{{transferencia_request_id_transferencia_value}}} (optional)</param> 
        /// <param name="idContaOrigem">{{{transferencia_request_id_conta_origem_value}}} (optional)</param> 
        /// <param name="idContaDestino">{{{transferencia_request_id_conta_destino_value}}} (optional)</param> 
        /// <param name="valorTransferencia">{{{transferencia_request_valor_transferencia_value}}} (optional)</param> 
        /// <param name="dataTransferencia">{{{transferencia_request_data_transferencia_value}}} (optional)</param> 
        /// <returns>PageTransferenciaResponse</returns>
        public PageTransferenciaResponse ListarUsingGET55 (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, string dataTransferencia = null)
        {
             ApiResponse<PageTransferenciaResponse> localVarResponse = ListarUsingGET55WithHttpInfo(id, sort, page, limit, idTransferencia, idContaOrigem, idContaDestino, valorTransferencia, dataTransferencia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{transferencia_resource_listar}}} {{{transferencia_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_resource_listar_param_id}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idTransferencia">{{{transferencia_request_id_transferencia_value}}} (optional)</param> 
        /// <param name="idContaOrigem">{{{transferencia_request_id_conta_origem_value}}} (optional)</param> 
        /// <param name="idContaDestino">{{{transferencia_request_id_conta_destino_value}}} (optional)</param> 
        /// <param name="valorTransferencia">{{{transferencia_request_valor_transferencia_value}}} (optional)</param> 
        /// <param name="dataTransferencia">{{{transferencia_request_data_transferencia_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageTransferenciaResponse</returns>
        public ApiResponse< PageTransferenciaResponse > ListarUsingGET55WithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, string dataTransferencia = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->ListarUsingGET55");
            
    
            var localVarPath = "/api/contas/{id}/transferencias-creditos-cartoes";
    
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
            if (idTransferencia != null) localVarQueryParams.Add("idTransferencia", Configuration.ApiClient.ParameterToString(idTransferencia)); // query parameter
            if (idContaOrigem != null) localVarQueryParams.Add("idContaOrigem", Configuration.ApiClient.ParameterToString(idContaOrigem)); // query parameter
            if (idContaDestino != null) localVarQueryParams.Add("idContaDestino", Configuration.ApiClient.ParameterToString(idContaDestino)); // query parameter
            if (valorTransferencia != null) localVarQueryParams.Add("valorTransferencia", Configuration.ApiClient.ParameterToString(valorTransferencia)); // query parameter
            if (dataTransferencia != null) localVarQueryParams.Add("dataTransferencia", Configuration.ApiClient.ParameterToString(dataTransferencia)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET55: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET55: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTransferenciaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransferenciaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransferenciaResponse)));
            
        }

        
        /// <summary>
        /// {{{transferencia_resource_listar}}} {{{transferencia_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_resource_listar_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTransferencia">{{{transferencia_request_id_transferencia_value}}} (optional)</param>
        /// <param name="idContaOrigem">{{{transferencia_request_id_conta_origem_value}}} (optional)</param>
        /// <param name="idContaDestino">{{{transferencia_request_id_conta_destino_value}}} (optional)</param>
        /// <param name="valorTransferencia">{{{transferencia_request_valor_transferencia_value}}} (optional)</param>
        /// <param name="dataTransferencia">{{{transferencia_request_data_transferencia_value}}} (optional)</param>
        /// <returns>Task of PageTransferenciaResponse</returns>
        public async System.Threading.Tasks.Task<PageTransferenciaResponse> ListarUsingGET55Async (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, string dataTransferencia = null)
        {
             ApiResponse<PageTransferenciaResponse> localVarResponse = await ListarUsingGET55AsyncWithHttpInfo(id, sort, page, limit, idTransferencia, idContaOrigem, idContaDestino, valorTransferencia, dataTransferencia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{transferencia_resource_listar}}} {{{transferencia_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_resource_listar_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTransferencia">{{{transferencia_request_id_transferencia_value}}} (optional)</param>
        /// <param name="idContaOrigem">{{{transferencia_request_id_conta_origem_value}}} (optional)</param>
        /// <param name="idContaDestino">{{{transferencia_request_id_conta_destino_value}}} (optional)</param>
        /// <param name="valorTransferencia">{{{transferencia_request_valor_transferencia_value}}} (optional)</param>
        /// <param name="dataTransferencia">{{{transferencia_request_data_transferencia_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTransferenciaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransferenciaResponse>> ListarUsingGET55AsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, string dataTransferencia = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarUsingGET55");
            
    
            var localVarPath = "/api/contas/{id}/transferencias-creditos-cartoes";
    
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
            if (idTransferencia != null) localVarQueryParams.Add("idTransferencia", Configuration.ApiClient.ParameterToString(idTransferencia)); // query parameter
            if (idContaOrigem != null) localVarQueryParams.Add("idContaOrigem", Configuration.ApiClient.ParameterToString(idContaOrigem)); // query parameter
            if (idContaDestino != null) localVarQueryParams.Add("idContaDestino", Configuration.ApiClient.ParameterToString(idContaDestino)); // query parameter
            if (valorTransferencia != null) localVarQueryParams.Add("valorTransferencia", Configuration.ApiClient.ParameterToString(valorTransferencia)); // query parameter
            if (dataTransferencia != null) localVarQueryParams.Add("dataTransferencia", Configuration.ApiClient.ParameterToString(dataTransferencia)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET55: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET55: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTransferenciaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransferenciaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransferenciaResponse)));
            
        }
        
        /// <summary>
        /// {{{conta_resource_reativar}}} {{{conta_resource_reativar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_reativar_param_id}}}</param> 
        /// <returns>Object</returns>
        public Object ReativarUsingPOST1 (long? id)
        {
             ApiResponse<Object> localVarResponse = ReativarUsingPOST1WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_resource_reativar}}} {{{conta_resource_reativar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_reativar_param_id}}}</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > ReativarUsingPOST1WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->ReativarUsingPOST1");
            
    
            var localVarPath = "/api/contas/{id}/reativar";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ReativarUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ReativarUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// {{{conta_resource_reativar}}} {{{conta_resource_reativar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_reativar_param_id}}}</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ReativarUsingPOST1Async (long? id)
        {
             ApiResponse<Object> localVarResponse = await ReativarUsingPOST1AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_resource_reativar}}} {{{conta_resource_reativar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_reativar_param_id}}}</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ReativarUsingPOST1AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReativarUsingPOST1");
            
    
            var localVarPath = "/api/contas/{id}/reativar";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ReativarUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ReativarUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// {{{conta_resource_salvar}}} {{{conta_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaPersist">contaPersist</param> 
        /// <returns>ContaResponse</returns>
        public ContaResponse SalvarUsingPOST7 (ContaPersistValue contaPersist)
        {
             ApiResponse<ContaResponse> localVarResponse = SalvarUsingPOST7WithHttpInfo(contaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_resource_salvar}}} {{{conta_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaPersist">contaPersist</param> 
        /// <returns>ApiResponse of ContaResponse</returns>
        public ApiResponse< ContaResponse > SalvarUsingPOST7WithHttpInfo (ContaPersistValue contaPersist)
        {
            
            // verify the required parameter 'contaPersist' is set
            if (contaPersist == null)
                throw new ApiException(400, "Missing required parameter 'contaPersist' when calling GlobaltagcontaApi->SalvarUsingPOST7");
            
    
            var localVarPath = "/api/contas";
    
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
            
            
            
            
            if (contaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }

        
        /// <summary>
        /// {{{conta_resource_salvar}}} {{{conta_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaPersist">contaPersist</param>
        /// <returns>Task of ContaResponse</returns>
        public async System.Threading.Tasks.Task<ContaResponse> SalvarUsingPOST7Async (ContaPersistValue contaPersist)
        {
             ApiResponse<ContaResponse> localVarResponse = await SalvarUsingPOST7AsyncWithHttpInfo(contaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_resource_salvar}}} {{{conta_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaPersist">contaPersist</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaResponse>> SalvarUsingPOST7AsyncWithHttpInfo (ContaPersistValue contaPersist)
        {
            // verify the required parameter 'contaPersist' is set
            if (contaPersist == null) throw new ApiException(400, "Missing required parameter 'contaPersist' when calling SalvarUsingPOST7");
            
    
            var localVarPath = "/api/contas";
    
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
            
            
            
            
            if (contaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }
        
        /// <summary>
        /// {{{financiamento_resource_simular_emprestimo_financiamento}}} {{{financiamento_resource_simular_emprestimo_financiamento_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{financiamento_resource_simular_emprestimo_financiamento_param_id_conta}}}</param> 
        /// <param name="request">request</param> 
        /// <returns>EmprestimoPessoalResponse</returns>
        public EmprestimoPessoalResponse SimularEmprestimoFinanciamentoUsingPOST (long? id, EmprestimoPessoalRequest request)
        {
             ApiResponse<EmprestimoPessoalResponse> localVarResponse = SimularEmprestimoFinanciamentoUsingPOSTWithHttpInfo(id, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{financiamento_resource_simular_emprestimo_financiamento}}} {{{financiamento_resource_simular_emprestimo_financiamento_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{financiamento_resource_simular_emprestimo_financiamento_param_id_conta}}}</param> 
        /// <param name="request">request</param> 
        /// <returns>ApiResponse of EmprestimoPessoalResponse</returns>
        public ApiResponse< EmprestimoPessoalResponse > SimularEmprestimoFinanciamentoUsingPOSTWithHttpInfo (long? id, EmprestimoPessoalRequest request)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->SimularEmprestimoFinanciamentoUsingPOST");
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling GlobaltagcontaApi->SimularEmprestimoFinanciamentoUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/simular-emprestimos-financiamentos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SimularEmprestimoFinanciamentoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularEmprestimoFinanciamentoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EmprestimoPessoalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmprestimoPessoalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmprestimoPessoalResponse)));
            
        }

        
        /// <summary>
        /// {{{financiamento_resource_simular_emprestimo_financiamento}}} {{{financiamento_resource_simular_emprestimo_financiamento_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{financiamento_resource_simular_emprestimo_financiamento_param_id_conta}}}</param>
        /// <param name="request">request</param>
        /// <returns>Task of EmprestimoPessoalResponse</returns>
        public async System.Threading.Tasks.Task<EmprestimoPessoalResponse> SimularEmprestimoFinanciamentoUsingPOSTAsync (long? id, EmprestimoPessoalRequest request)
        {
             ApiResponse<EmprestimoPessoalResponse> localVarResponse = await SimularEmprestimoFinanciamentoUsingPOSTAsyncWithHttpInfo(id, request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{financiamento_resource_simular_emprestimo_financiamento}}} {{{financiamento_resource_simular_emprestimo_financiamento_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{financiamento_resource_simular_emprestimo_financiamento_param_id_conta}}}</param>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (EmprestimoPessoalResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmprestimoPessoalResponse>> SimularEmprestimoFinanciamentoUsingPOSTAsyncWithHttpInfo (long? id, EmprestimoPessoalRequest request)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SimularEmprestimoFinanciamentoUsingPOST");
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling SimularEmprestimoFinanciamentoUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/simular-emprestimos-financiamentos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SimularEmprestimoFinanciamentoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularEmprestimoFinanciamentoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmprestimoPessoalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmprestimoPessoalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmprestimoPessoalResponse)));
            
        }
        
        /// <summary>
        /// {{{conta_resource_transacoes}}} {{{conta_resource_transacoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_transacoes_param_id}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>PageTransacaoResponse</returns>
        public PageTransacaoResponse TransacoesUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTransacaoResponse> localVarResponse = TransacoesUsingGETWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_resource_transacoes}}} {{{conta_resource_transacoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_transacoes_param_id}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>ApiResponse of PageTransacaoResponse</returns>
        public ApiResponse< PageTransacaoResponse > TransacoesUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->TransacoesUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/timeline";
    
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
                throw new ApiException (localVarStatusCode, "Error calling TransacoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TransacoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTransacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacaoResponse)));
            
        }

        
        /// <summary>
        /// {{{conta_resource_transacoes}}} {{{conta_resource_transacoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_transacoes_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageTransacaoResponse</returns>
        public async System.Threading.Tasks.Task<PageTransacaoResponse> TransacoesUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTransacaoResponse> localVarResponse = await TransacoesUsingGETAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_resource_transacoes}}} {{{conta_resource_transacoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_resource_transacoes_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransacaoResponse>> TransacoesUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TransacoesUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/timeline";
    
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
                throw new ApiException (localVarStatusCode, "Error calling TransacoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TransacoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTransacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacaoResponse)));
            
        }
        
        /// <summary>
        /// {{{transferencia_resource_transferir}}} {{{transferencia_resource_transferir_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_resource_transferir_param_id_conta_origem}}}</param> 
        /// <param name="idContaDestino">{{{transferencia_resource_transferir_param_id_conta_destino}}}</param> 
        /// <param name="valorTransferencia">{{{transferencia_resource_transferir_param_valor_transferencia}}}</param> 
        /// <returns>TransferenciaDetalheResponse</returns>
        public TransferenciaDetalheResponse TransferirUsingPOST1 (long? id, long? idContaDestino, double? valorTransferencia)
        {
             ApiResponse<TransferenciaDetalheResponse> localVarResponse = TransferirUsingPOST1WithHttpInfo(id, idContaDestino, valorTransferencia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{transferencia_resource_transferir}}} {{{transferencia_resource_transferir_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_resource_transferir_param_id_conta_origem}}}</param> 
        /// <param name="idContaDestino">{{{transferencia_resource_transferir_param_id_conta_destino}}}</param> 
        /// <param name="valorTransferencia">{{{transferencia_resource_transferir_param_valor_transferencia}}}</param> 
        /// <returns>ApiResponse of TransferenciaDetalheResponse</returns>
        public ApiResponse< TransferenciaDetalheResponse > TransferirUsingPOST1WithHttpInfo (long? id, long? idContaDestino, double? valorTransferencia)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcontaApi->TransferirUsingPOST1");
            
            // verify the required parameter 'idContaDestino' is set
            if (idContaDestino == null)
                throw new ApiException(400, "Missing required parameter 'idContaDestino' when calling GlobaltagcontaApi->TransferirUsingPOST1");
            
            // verify the required parameter 'valorTransferencia' is set
            if (valorTransferencia == null)
                throw new ApiException(400, "Missing required parameter 'valorTransferencia' when calling GlobaltagcontaApi->TransferirUsingPOST1");
            
    
            var localVarPath = "/api/contas/{id}/transferencias-creditos-cartoes";
    
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
            
            if (idContaDestino != null) localVarQueryParams.Add("id_conta_destino", Configuration.ApiClient.ParameterToString(idContaDestino)); // query parameter
            if (valorTransferencia != null) localVarQueryParams.Add("valor_transferencia", Configuration.ApiClient.ParameterToString(valorTransferencia)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling TransferirUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TransferirUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransferenciaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaDetalheResponse)));
            
        }

        
        /// <summary>
        /// {{{transferencia_resource_transferir}}} {{{transferencia_resource_transferir_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_resource_transferir_param_id_conta_origem}}}</param>
        /// <param name="idContaDestino">{{{transferencia_resource_transferir_param_id_conta_destino}}}</param>
        /// <param name="valorTransferencia">{{{transferencia_resource_transferir_param_valor_transferencia}}}</param>
        /// <returns>Task of TransferenciaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<TransferenciaDetalheResponse> TransferirUsingPOST1Async (long? id, long? idContaDestino, double? valorTransferencia)
        {
             ApiResponse<TransferenciaDetalheResponse> localVarResponse = await TransferirUsingPOST1AsyncWithHttpInfo(id, idContaDestino, valorTransferencia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{transferencia_resource_transferir}}} {{{transferencia_resource_transferir_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{transferencia_resource_transferir_param_id_conta_origem}}}</param>
        /// <param name="idContaDestino">{{{transferencia_resource_transferir_param_id_conta_destino}}}</param>
        /// <param name="valorTransferencia">{{{transferencia_resource_transferir_param_valor_transferencia}}}</param>
        /// <returns>Task of ApiResponse (TransferenciaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransferenciaDetalheResponse>> TransferirUsingPOST1AsyncWithHttpInfo (long? id, long? idContaDestino, double? valorTransferencia)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TransferirUsingPOST1");
            // verify the required parameter 'idContaDestino' is set
            if (idContaDestino == null) throw new ApiException(400, "Missing required parameter 'idContaDestino' when calling TransferirUsingPOST1");
            // verify the required parameter 'valorTransferencia' is set
            if (valorTransferencia == null) throw new ApiException(400, "Missing required parameter 'valorTransferencia' when calling TransferirUsingPOST1");
            
    
            var localVarPath = "/api/contas/{id}/transferencias-creditos-cartoes";
    
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
            
            if (idContaDestino != null) localVarQueryParams.Add("id_conta_destino", Configuration.ApiClient.ParameterToString(idContaDestino)); // query parameter
            if (valorTransferencia != null) localVarQueryParams.Add("valor_transferencia", Configuration.ApiClient.ParameterToString(valorTransferencia)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling TransferirUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TransferirUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransferenciaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaDetalheResponse)));
            
        }
        
    }
    
}
