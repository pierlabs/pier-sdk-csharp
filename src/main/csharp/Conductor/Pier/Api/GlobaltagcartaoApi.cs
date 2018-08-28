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
    public interface IGlobaltagcartaoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{cartao_resource_alterar_alterar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_alterar_alterar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_alterar_alterar_senha_param_id}}}</param>
        /// <param name="senha">{{{cartao_resource_alterar_alterar_senha_param_nova_senha}}}</param>
        /// <returns>string</returns>
        string AlterarAlterarSenhaUsingPUT (long? id, string senha);
  
        /// <summary>
        /// {{{cartao_resource_alterar_alterar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_alterar_alterar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_alterar_alterar_senha_param_id}}}</param>
        /// <param name="senha">{{{cartao_resource_alterar_alterar_senha_param_nova_senha}}}</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> AlterarAlterarSenhaUsingPUTWithHttpInfo (long? id, string senha);
        
        /// <summary>
        /// {{{cartao_resource_alterar_estagio}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_alterar_estagio_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_alterar_estagio_param_id}}}</param>
        /// <param name="update">{{{cartao_resource_alterar_estagio_param_id_estagio_cartao}}}</param>
        /// <returns>CartaoResponse</returns>
        CartaoResponse AlterarEstagioUsingPOST (long? id, EstagioCartaoUpdate update);
  
        /// <summary>
        /// {{{cartao_resource_alterar_estagio}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_alterar_estagio_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_alterar_estagio_param_id}}}</param>
        /// <param name="update">{{{cartao_resource_alterar_estagio_param_id_estagio_cartao}}}</param>
        /// <returns>ApiResponse of CartaoResponse</returns>
        ApiResponse<CartaoResponse> AlterarEstagioUsingPOSTWithHttpInfo (long? id, EstagioCartaoUpdate update);
        
        /// <summary>
        /// {{{cartao_resource_alterar_status_impressao}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_alterar_status_impressao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_alterar_status_impressao_param_id}}}</param>
        /// <param name="idStatusImpressao">{{{cartao_resource_alterar_status_impressao_param_id_status_impressao}}}</param>
        /// <returns>HistoricoImpressaoCartaoResponse</returns>
        HistoricoImpressaoCartaoResponse AlterarStatusImpressaoUsingPUT (long? id, long? idStatusImpressao);
  
        /// <summary>
        /// {{{cartao_resource_alterar_status_impressao}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_alterar_status_impressao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_alterar_status_impressao_param_id}}}</param>
        /// <param name="idStatusImpressao">{{{cartao_resource_alterar_status_impressao_param_id_status_impressao}}}</param>
        /// <returns>ApiResponse of HistoricoImpressaoCartaoResponse</returns>
        ApiResponse<HistoricoImpressaoCartaoResponse> AlterarStatusImpressaoUsingPUTWithHttpInfo (long? id, long? idStatusImpressao);
        
        /// <summary>
        /// {{{cartao_resource_atribuir_pessoa}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_atribuir_pessoa_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_atribuir_pessoa_param_id_cartao}}}</param>
        /// <param name="idPessoa">{{{cartao_resource_atribuir_pessoa_param_id_pessoa}}}</param>
        /// <returns>CartaoResponse</returns>
        CartaoResponse AtribuirPessoaUsingPUT (long? id, long? idPessoa);
  
        /// <summary>
        /// {{{cartao_resource_atribuir_pessoa}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_atribuir_pessoa_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_atribuir_pessoa_param_id_cartao}}}</param>
        /// <param name="idPessoa">{{{cartao_resource_atribuir_pessoa_param_id_pessoa}}}</param>
        /// <returns>ApiResponse of CartaoResponse</returns>
        ApiResponse<CartaoResponse> AtribuirPessoaUsingPUTWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// {{{cartao_resource_bloquear}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_bloquear_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_bloquear_param_id}}}</param>
        /// <param name="idStatus">{{{cartao_resource_bloquear_param_id_status}}}</param>
        /// <param name="observacao">{{{cartao_resource_bloquear_param_observacao}}}</param>
        /// <returns>CartaoResponse</returns>
        CartaoResponse BloquearUsingPOST (long? id, long? idStatus, string observacao);
  
        /// <summary>
        /// {{{cartao_resource_bloquear}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_bloquear_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_bloquear_param_id}}}</param>
        /// <param name="idStatus">{{{cartao_resource_bloquear_param_id_status}}}</param>
        /// <param name="observacao">{{{cartao_resource_bloquear_param_observacao}}}</param>
        /// <returns>ApiResponse of CartaoResponse</returns>
        ApiResponse<CartaoResponse> BloquearUsingPOSTWithHttpInfo (long? id, long? idStatus, string observacao);
        
        /// <summary>
        /// {{{cartao_resource_cadastrar_alterar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_cadastrar_alterar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_cadastrar_alterar_senha_param_id}}}</param>
        /// <param name="senha">{{{cartao_resource_cadastrar_alterar_senha_param_nova_senha}}}</param>
        /// <returns>string</returns>
        string CadastrarAlterarSenhaUsingPOST (long? id, string senha);
  
        /// <summary>
        /// {{{cartao_resource_cadastrar_alterar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_cadastrar_alterar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_cadastrar_alterar_senha_param_id}}}</param>
        /// <param name="senha">{{{cartao_resource_cadastrar_alterar_senha_param_nova_senha}}}</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> CadastrarAlterarSenhaUsingPOSTWithHttpInfo (long? id, string senha);
        
        /// <summary>
        /// {{{cartao_resource_cancelar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_cancelar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_cancelar_param_id}}}</param>
        /// <param name="idStatus">{{{cartao_resource_cancelar_param_id_status}}}</param>
        /// <param name="observacao">{{{cartao_resource_cancelar_param_observacao}}}</param>
        /// <returns>CartaoResponse</returns>
        CartaoResponse CancelarUsingPOST (long? id, long? idStatus, string observacao);
  
        /// <summary>
        /// {{{cartao_resource_cancelar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_cancelar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_cancelar_param_id}}}</param>
        /// <param name="idStatus">{{{cartao_resource_cancelar_param_id_status}}}</param>
        /// <param name="observacao">{{{cartao_resource_cancelar_param_observacao}}}</param>
        /// <returns>ApiResponse of CartaoResponse</returns>
        ApiResponse<CartaoResponse> CancelarUsingPOSTWithHttpInfo (long? id, long? idStatus, string observacao);
        
        /// <summary>
        /// {{{cartao_resource_consultar_cartao_impressao}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_consultar_cartao_impressao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_cartao_impressao_param_id}}}</param>
        /// <returns>DadosCartaoImpressaoResponse</returns>
        DadosCartaoImpressaoResponse ConsultarCartaoImpressaoUsingGET (long? id);
  
        /// <summary>
        /// {{{cartao_resource_consultar_cartao_impressao}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_consultar_cartao_impressao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_cartao_impressao_param_id}}}</param>
        /// <returns>ApiResponse of DadosCartaoImpressaoResponse</returns>
        ApiResponse<DadosCartaoImpressaoResponse> ConsultarCartaoImpressaoUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{cartao_resource_consultar_dados_reais_cartao}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_consultar_dados_reais_cartao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>DadosCartaoResponse</returns>
        DadosCartaoResponse ConsultarDadosReaisCartaoUsingGET (long? id);
  
        /// <summary>
        /// {{{cartao_resource_consultar_dados_reais_cartao}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_consultar_dados_reais_cartao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>ApiResponse of DadosCartaoResponse</returns>
        ApiResponse<DadosCartaoResponse> ConsultarDadosReaisCartaoUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{cartao_resource_consultar_limite_disponibilidade}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_consultar_limite_disponibilidade_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_limite_disponibilidade_param_id}}}</param>
        /// <returns>LimiteDisponibilidadeResponse</returns>
        LimiteDisponibilidadeResponse ConsultarLimiteDisponibilidadeUsingGET (long? id);
  
        /// <summary>
        /// {{{cartao_resource_consultar_limite_disponibilidade}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_consultar_limite_disponibilidade_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_limite_disponibilidade_param_id}}}</param>
        /// <returns>ApiResponse of LimiteDisponibilidadeResponse</returns>
        ApiResponse<LimiteDisponibilidadeResponse> ConsultarLimiteDisponibilidadeUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{cartao_resource_consultar_lotes_cartoes_pre_pagos}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_consultar_lotes_cartoes_pre_pagos_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_lotes_cartoes_pre_pagos_param_id_lote}}}</param>
        /// <returns>LoteCartoesPrePagosResponse</returns>
        LoteCartoesPrePagosResponse ConsultarLotesCartoesPrePagosUsingGET (long? id);
  
        /// <summary>
        /// {{{cartao_resource_consultar_lotes_cartoes_pre_pagos}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_consultar_lotes_cartoes_pre_pagos_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_lotes_cartoes_pre_pagos_param_id_lote}}}</param>
        /// <returns>ApiResponse of LoteCartoesPrePagosResponse</returns>
        ApiResponse<LoteCartoesPrePagosResponse> ConsultarLotesCartoesPrePagosUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{cartao_resource_consultar_portador}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_consultar_portador_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_portador_param_id}}}</param>
        /// <returns>PortadorResponse</returns>
        PortadorResponse ConsultarPortadorUsingGET (long? id);
  
        /// <summary>
        /// {{{cartao_resource_consultar_portador}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_consultar_portador_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_portador_param_id}}}</param>
        /// <returns>ApiResponse of PortadorResponse</returns>
        ApiResponse<PortadorResponse> ConsultarPortadorUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{cartao_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_param_id}}}</param>
        /// <returns>CartaoDetalheResponse</returns>
        CartaoDetalheResponse ConsultarUsingGET12 (long? id);
  
        /// <summary>
        /// {{{cartao_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of CartaoDetalheResponse</returns>
        ApiResponse<CartaoDetalheResponse> ConsultarUsingGET12WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{conta_resource_cadastrar_cartao_multiapp}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_cadastrar_cartao_multiapp_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartaoMultiAppPersist">cartaoMultiAppPersist</param>
        /// <returns>VinculoCartoesResponse</returns>
        VinculoCartoesResponse CriarCartoesMultiAppUsingPOST (CartaoMultiAppPersistValue cartaoMultiAppPersist);
  
        /// <summary>
        /// {{{conta_resource_cadastrar_cartao_multiapp}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_cadastrar_cartao_multiapp_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartaoMultiAppPersist">cartaoMultiAppPersist</param>
        /// <returns>ApiResponse of VinculoCartoesResponse</returns>
        ApiResponse<VinculoCartoesResponse> CriarCartoesMultiAppUsingPOSTWithHttpInfo (CartaoMultiAppPersistValue cartaoMultiAppPersist);
        
        /// <summary>
        /// {{{cartao_resource_desbloquear_senha_incorreta}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_desbloquear_senha_incorreta_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_desbloquear_senha_incorreta_param_id}}}</param>
        /// <returns>CartaoResponse</returns>
        CartaoResponse DesbloquearSenhaIncorretaUsingPOST (long? id);
  
        /// <summary>
        /// {{{cartao_resource_desbloquear_senha_incorreta}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_desbloquear_senha_incorreta_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_desbloquear_senha_incorreta_param_id}}}</param>
        /// <returns>ApiResponse of CartaoResponse</returns>
        ApiResponse<CartaoResponse> DesbloquearSenhaIncorretaUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{cartao_resource_desbloquear}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_desbloquear_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_desbloquear_param_id}}}</param>
        /// <returns>CartaoResponse</returns>
        CartaoResponse DesbloquearUsingPOST (long? id);
  
        /// <summary>
        /// {{{cartao_resource_desbloquear}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_desbloquear_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_desbloquear_param_id}}}</param>
        /// <returns>ApiResponse of CartaoResponse</returns>
        ApiResponse<CartaoResponse> DesbloquearUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{cartao_resource_gerar_lotes_cartoes_pre_pagos}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_gerar_lotes_cartoes_pre_pagos_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idOrigemComercial">{{{lote_cartoes_pre_pagos_persist_id_origem_comercial_value}}} (optional)</param>
        /// <param name="idProduto">{{{lote_cartoes_pre_pagos_persist_id_produto_value}}} (optional)</param>
        /// <param name="idTipoCartao">{{{lote_cartoes_pre_pagos_persist_id_tipo_cartao_value}}} (optional)</param>
        /// <param name="idImagem">{{{lote_cartoes_pre_pagos_persist_id_imagem_value}}} (optional)</param>
        /// <param name="idEndereco">{{{lote_cartoes_pre_pagos_persist_id_endereco_value}}} (optional)</param>
        /// <param name="quantidadeCartoes">{{{lote_cartoes_pre_pagos_persist_quantidade_cartoes_value}}} (optional)</param>
        /// <param name="identificadorExterno">{{{lote_cartoes_pre_pagos_persist_identificador_externo_value}}} (optional)</param>
        /// <returns>LoteCartoesPrePagosResponse</returns>
        LoteCartoesPrePagosResponse GerarLotesCartoesPrePagosUsingPOST (long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string identificadorExterno = null);
  
        /// <summary>
        /// {{{cartao_resource_gerar_lotes_cartoes_pre_pagos}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_gerar_lotes_cartoes_pre_pagos_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idOrigemComercial">{{{lote_cartoes_pre_pagos_persist_id_origem_comercial_value}}} (optional)</param>
        /// <param name="idProduto">{{{lote_cartoes_pre_pagos_persist_id_produto_value}}} (optional)</param>
        /// <param name="idTipoCartao">{{{lote_cartoes_pre_pagos_persist_id_tipo_cartao_value}}} (optional)</param>
        /// <param name="idImagem">{{{lote_cartoes_pre_pagos_persist_id_imagem_value}}} (optional)</param>
        /// <param name="idEndereco">{{{lote_cartoes_pre_pagos_persist_id_endereco_value}}} (optional)</param>
        /// <param name="quantidadeCartoes">{{{lote_cartoes_pre_pagos_persist_quantidade_cartoes_value}}} (optional)</param>
        /// <param name="identificadorExterno">{{{lote_cartoes_pre_pagos_persist_identificador_externo_value}}} (optional)</param>
        /// <returns>ApiResponse of LoteCartoesPrePagosResponse</returns>
        ApiResponse<LoteCartoesPrePagosResponse> GerarLotesCartoesPrePagosUsingPOSTWithHttpInfo (long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string identificadorExterno = null);
        
        /// <summary>
        /// {{{cartao_resource_gerar_nova_via_multiplo}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_gerar_nova_via_multiplo_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_gerar_nova_via_param_id_cartao}}}</param>
        /// <returns>CartaoMultiAppImpressaoResponse</returns>
        CartaoMultiAppImpressaoResponse GerarNovaViaCartaoMultiAppUsingPOST (long? id);
  
        /// <summary>
        /// {{{cartao_resource_gerar_nova_via_multiplo}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_gerar_nova_via_multiplo_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_gerar_nova_via_param_id_cartao}}}</param>
        /// <returns>ApiResponse of CartaoMultiAppImpressaoResponse</returns>
        ApiResponse<CartaoMultiAppImpressaoResponse> GerarNovaViaCartaoMultiAppUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{cartao_resource_gerar_nova_via}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_gerar_nova_via_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_gerar_nova_via_param_id_cartao}}}</param>
        /// <returns>CartaoResponse</returns>
        CartaoResponse GerarNovaViaUsingPOST (long? id);
  
        /// <summary>
        /// {{{cartao_resource_gerar_nova_via}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_gerar_nova_via_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_gerar_nova_via_param_id_cartao}}}</param>
        /// <returns>ApiResponse of CartaoResponse</returns>
        ApiResponse<CartaoResponse> GerarNovaViaUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{cartao_resource_lancar_tarifa_segunda_via}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_lancar_tarifa_segunda_via_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_lancar_tarifa_segunda_via_param_id}}}</param>
        /// <returns>Object</returns>
        Object LancarTarifaSegundaViaUsingPOST (long? id);
  
        /// <summary>
        /// {{{cartao_resource_lancar_tarifa_segunda_via}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_lancar_tarifa_segunda_via_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_lancar_tarifa_segunda_via_param_id}}}</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> LancarTarifaSegundaViaUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{cartao_resource_listar_lotes_cartoes_pre_pagos}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_listar_lotes_cartoes_pre_pagos_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idOrigemComercial">{{{lote_cartoes_pre_pagos_request_id_origem_comercial_value}}} (optional)</param>
        /// <param name="idProduto">{{{lote_cartoes_pre_pagos_request_id_produto_value}}} (optional)</param>
        /// <param name="idTipoCartao">{{{lote_cartoes_pre_pagos_request_id_tipo_cartao_value}}} (optional)</param>
        /// <param name="idImagem">{{{lote_cartoes_pre_pagos_request_id_imagem_value}}} (optional)</param>
        /// <param name="idEndereco">{{{lote_cartoes_pre_pagos_request_id_endereco_value}}} (optional)</param>
        /// <param name="quantidadeCartoes">{{{lote_cartoes_pre_pagos_request_quantidade_cartoes_value}}} (optional)</param>
        /// <param name="dataCadastro">{{{lote_cartoes_pre_pagos_request_data_cadastro_value}}} (optional)</param>
        /// <param name="usuarioCadastro">{{{lote_cartoes_pre_pagos_request_usuario_cadastro_value}}} (optional)</param>
        /// <param name="statusProcessamento">{{{lote_cartoes_pre_pagos_request_status_processamento_value}}} (optional)</param>
        /// <param name="identificadorExterno">{{{lote_cartoes_pre_pagos_request_identificador_externo_value}}} (optional)</param>
        /// <returns>PageLoteCartoesPrePagosResponse</returns>
        PageLoteCartoesPrePagosResponse ListarLotesCartoesPrePagosUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string dataCadastro = null, string usuarioCadastro = null, int? statusProcessamento = null, string identificadorExterno = null);
  
        /// <summary>
        /// {{{cartao_resource_listar_lotes_cartoes_pre_pagos}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_listar_lotes_cartoes_pre_pagos_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idOrigemComercial">{{{lote_cartoes_pre_pagos_request_id_origem_comercial_value}}} (optional)</param>
        /// <param name="idProduto">{{{lote_cartoes_pre_pagos_request_id_produto_value}}} (optional)</param>
        /// <param name="idTipoCartao">{{{lote_cartoes_pre_pagos_request_id_tipo_cartao_value}}} (optional)</param>
        /// <param name="idImagem">{{{lote_cartoes_pre_pagos_request_id_imagem_value}}} (optional)</param>
        /// <param name="idEndereco">{{{lote_cartoes_pre_pagos_request_id_endereco_value}}} (optional)</param>
        /// <param name="quantidadeCartoes">{{{lote_cartoes_pre_pagos_request_quantidade_cartoes_value}}} (optional)</param>
        /// <param name="dataCadastro">{{{lote_cartoes_pre_pagos_request_data_cadastro_value}}} (optional)</param>
        /// <param name="usuarioCadastro">{{{lote_cartoes_pre_pagos_request_usuario_cadastro_value}}} (optional)</param>
        /// <param name="statusProcessamento">{{{lote_cartoes_pre_pagos_request_status_processamento_value}}} (optional)</param>
        /// <param name="identificadorExterno">{{{lote_cartoes_pre_pagos_request_identificador_externo_value}}} (optional)</param>
        /// <returns>ApiResponse of PageLoteCartoesPrePagosResponse</returns>
        ApiResponse<PageLoteCartoesPrePagosResponse> ListarLotesCartoesPrePagosUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string dataCadastro = null, string usuarioCadastro = null, int? statusProcessamento = null, string identificadorExterno = null);
        
        /// <summary>
        /// {{{cartao_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idStatusCartao">{{{cartao_request_id_status_cartao_value}}} (optional)</param>
        /// <param name="idEstagioCartao">{{{cartao_request_id_estagio_cartao_value}}} (optional)</param>
        /// <param name="idConta">{{{cartao_request_id_conta_value}}} (optional)</param>
        /// <param name="idPessoa">{{{cartao_request_id_pessoa_value}}} (optional)</param>
        /// <param name="idProduto">{{{cartao_request_id_produto_value}}} (optional)</param>
        /// <param name="tipoPortador">{{{cartao_request_tipo_portador_value}}} (optional)</param>
        /// <param name="numeroCartao">{{{cartao_request_numero_cartao_value}}} (optional)</param>
        /// <param name="nomeImpresso">{{{cartao_request_nome_impresso_value}}} (optional)</param>
        /// <param name="dataGeracao">{{{cartao_request_data_geracao_value}}} (optional)</param>
        /// <param name="dataStatusCartao">{{{cartao_request_data_status_cartao_value}}} (optional)</param>
        /// <param name="dataEstagioCartao">{{{cartao_request_data_estagio_cartao_value}}} (optional)</param>
        /// <param name="dataValidade">{{{cartao_request_data_validade_value}}} (optional)</param>
        /// <param name="dataImpressao">{{{cartao_request_data_impressao_value}}} (optional)</param>
        /// <param name="arquivoImpressao">{{{cartao_request_arquivo_impressao_value}}} (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">{{{cartao_request_flag_impressao_origem_comercial_value}}} (optional)</param>
        /// <param name="flagProvisorio">{{{cartao_request_flag_provisorio_value}}} (optional)</param>
        /// <param name="codigoDesbloqueio">{{{cartao_request_codigo_desbloqueio_value}}} (optional)</param>
        /// <param name="sequencialCartao">{{{cartao_request_sequencial_cartao_value}}} (optional)</param>
        /// <param name="identificadorExterno">{{{cartao_request_identificador_externo_value}}} (optional)</param>
        /// <returns>PageCartaoResponse</returns>
        PageCartaoResponse ListarUsingGET12 (List<string> sort = null, int? page = null, int? limit = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? sequencialCartao = null, long? identificadorExterno = null);
  
        /// <summary>
        /// {{{cartao_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idStatusCartao">{{{cartao_request_id_status_cartao_value}}} (optional)</param>
        /// <param name="idEstagioCartao">{{{cartao_request_id_estagio_cartao_value}}} (optional)</param>
        /// <param name="idConta">{{{cartao_request_id_conta_value}}} (optional)</param>
        /// <param name="idPessoa">{{{cartao_request_id_pessoa_value}}} (optional)</param>
        /// <param name="idProduto">{{{cartao_request_id_produto_value}}} (optional)</param>
        /// <param name="tipoPortador">{{{cartao_request_tipo_portador_value}}} (optional)</param>
        /// <param name="numeroCartao">{{{cartao_request_numero_cartao_value}}} (optional)</param>
        /// <param name="nomeImpresso">{{{cartao_request_nome_impresso_value}}} (optional)</param>
        /// <param name="dataGeracao">{{{cartao_request_data_geracao_value}}} (optional)</param>
        /// <param name="dataStatusCartao">{{{cartao_request_data_status_cartao_value}}} (optional)</param>
        /// <param name="dataEstagioCartao">{{{cartao_request_data_estagio_cartao_value}}} (optional)</param>
        /// <param name="dataValidade">{{{cartao_request_data_validade_value}}} (optional)</param>
        /// <param name="dataImpressao">{{{cartao_request_data_impressao_value}}} (optional)</param>
        /// <param name="arquivoImpressao">{{{cartao_request_arquivo_impressao_value}}} (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">{{{cartao_request_flag_impressao_origem_comercial_value}}} (optional)</param>
        /// <param name="flagProvisorio">{{{cartao_request_flag_provisorio_value}}} (optional)</param>
        /// <param name="codigoDesbloqueio">{{{cartao_request_codigo_desbloqueio_value}}} (optional)</param>
        /// <param name="sequencialCartao">{{{cartao_request_sequencial_cartao_value}}} (optional)</param>
        /// <param name="identificadorExterno">{{{cartao_request_identificador_externo_value}}} (optional)</param>
        /// <returns>ApiResponse of PageCartaoResponse</returns>
        ApiResponse<PageCartaoResponse> ListarUsingGET12WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? sequencialCartao = null, long? identificadorExterno = null);
        
        /// <summary>
        /// {{{cartao_resource_reativar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_reativar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_reativar_param_id}}}</param>
        /// <returns>CartaoResponse</returns>
        CartaoResponse ReativarUsingPOST (long? id);
  
        /// <summary>
        /// {{{cartao_resource_reativar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_reativar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_reativar_param_id}}}</param>
        /// <returns>ApiResponse of CartaoResponse</returns>
        ApiResponse<CartaoResponse> ReativarUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{cartao_resource_validar_c_v_v}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_validar_c_v_v_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_validar_c_v_v_param_id}}}</param>
        /// <param name="validaCVV">validaCVV</param>
        /// <returns>string</returns>
        string ValidarCVVUsingPOST (long? id, ValidaCVVRequest validaCVV);
  
        /// <summary>
        /// {{{cartao_resource_validar_c_v_v}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_validar_c_v_v_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_validar_c_v_v_param_id}}}</param>
        /// <param name="validaCVV">validaCVV</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ValidarCVVUsingPOSTWithHttpInfo (long? id, ValidaCVVRequest validaCVV);
        
        /// <summary>
        /// {{{cartao_resource_validar_dados_impressos_bandeirado}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_validar_dados_impressos_bandeirado_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">{{{cartao_resource_validar_dados_impressos_bandeirado_param_numero_cartao}}}</param>
        /// <param name="nomePortador">{{{cartao_resource_validar_dados_impressos_bandeirado_param_nome_portador}}}</param>
        /// <param name="dataValidade">{{{cartao_resource_validar_dados_impressos_bandeirado_param_data_validade}}}</param>
        /// <param name="codigoSeguranca">{{{cartao_resource_validar_dados_impressos_bandeirado_param_codigo_seguranca}}}</param>
        /// <returns>ValidaCartaoResponse</returns>
        ValidaCartaoResponse ValidarDadosImpressosBandeiradoUsingGET (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);
  
        /// <summary>
        /// {{{cartao_resource_validar_dados_impressos_bandeirado}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_validar_dados_impressos_bandeirado_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">{{{cartao_resource_validar_dados_impressos_bandeirado_param_numero_cartao}}}</param>
        /// <param name="nomePortador">{{{cartao_resource_validar_dados_impressos_bandeirado_param_nome_portador}}}</param>
        /// <param name="dataValidade">{{{cartao_resource_validar_dados_impressos_bandeirado_param_data_validade}}}</param>
        /// <param name="codigoSeguranca">{{{cartao_resource_validar_dados_impressos_bandeirado_param_codigo_seguranca}}}</param>
        /// <returns>ApiResponse of ValidaCartaoResponse</returns>
        ApiResponse<ValidaCartaoResponse> ValidarDadosImpressosBandeiradoUsingGETWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);
        
        /// <summary>
        /// {{{cartao_resource_validar_dados_impressos_nao_bandeirado}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_validar_dados_impressos_nao_bandeirado_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">{{{cartao_resource_validar_dados_impressos_nao_bandeirado_param_numero_cartao}}}</param>
        /// <param name="nomePortador">{{{cartao_resource_validar_dados_impressos_nao_bandeirado_param_nome_portador}}}</param>
        /// <param name="dataValidade">{{{cartao_resource_validar_dados_impressos_nao_bandeirado_param_data_validade}}}</param>
        /// <param name="codigoSeguranca">{{{cartao_resource_validar_dados_impressos_nao_bandeirado_param_codigo_seguranca}}}</param>
        /// <returns>ValidaCartaoResponse</returns>
        ValidaCartaoResponse ValidarDadosImpressosNaoBandeiradoUsingGET (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);
  
        /// <summary>
        /// {{{cartao_resource_validar_dados_impressos_nao_bandeirado}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_validar_dados_impressos_nao_bandeirado_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">{{{cartao_resource_validar_dados_impressos_nao_bandeirado_param_numero_cartao}}}</param>
        /// <param name="nomePortador">{{{cartao_resource_validar_dados_impressos_nao_bandeirado_param_nome_portador}}}</param>
        /// <param name="dataValidade">{{{cartao_resource_validar_dados_impressos_nao_bandeirado_param_data_validade}}}</param>
        /// <param name="codigoSeguranca">{{{cartao_resource_validar_dados_impressos_nao_bandeirado_param_codigo_seguranca}}}</param>
        /// <returns>ApiResponse of ValidaCartaoResponse</returns>
        ApiResponse<ValidaCartaoResponse> ValidarDadosImpressosNaoBandeiradoUsingGETWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);
        
        /// <summary>
        /// {{{cartao_resource_validar_de55_cartao_mastercard}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_validar_de55_cartao_mastercard_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">{{{cartao_resource_validar_de55_cartao_mastercard_param_numero_cartao}}}</param>
        /// <param name="criptograma">{{{cartao_resource_validar_de55_cartao_mastercard_param_criptograma}}}</param>
        /// <returns>ValidaCartaoResponse</returns>
        ValidaCartaoResponse ValidarDe55CartaoMastercardUsingGET (string numeroCartao, string criptograma);
  
        /// <summary>
        /// {{{cartao_resource_validar_de55_cartao_mastercard}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_validar_de55_cartao_mastercard_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">{{{cartao_resource_validar_de55_cartao_mastercard_param_numero_cartao}}}</param>
        /// <param name="criptograma">{{{cartao_resource_validar_de55_cartao_mastercard_param_criptograma}}}</param>
        /// <returns>ApiResponse of ValidaCartaoResponse</returns>
        ApiResponse<ValidaCartaoResponse> ValidarDe55CartaoMastercardUsingGETWithHttpInfo (string numeroCartao, string criptograma);
        
        /// <summary>
        /// {{{cartao_resource_validar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_validar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_validar_senha_param_id}}}</param>
        /// <param name="senha">{{{cartao_resource_validar_senha_param_senha}}}</param>
        /// <returns>ValidaSenhaCartaoResponse</returns>
        ValidaSenhaCartaoResponse ValidarSenhaUsingGET (long? id, string senha);
  
        /// <summary>
        /// {{{cartao_resource_validar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_validar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_validar_senha_param_id}}}</param>
        /// <param name="senha">{{{cartao_resource_validar_senha_param_senha}}}</param>
        /// <returns>ApiResponse of ValidaSenhaCartaoResponse</returns>
        ApiResponse<ValidaSenhaCartaoResponse> ValidarSenhaUsingGETWithHttpInfo (long? id, string senha);
        
        /// <summary>
        /// {{{cartao_resource_validar_tarja}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_validar_tarja_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">{{{cartao_resource_validar_tarja_param_numero_cartao}}}</param>
        /// <param name="trilha1">{{{cartao_resource_validar_tarja_param_trilha1}}}</param>
        /// <param name="trilha2">{{{cartao_resource_validar_tarja_param_trilha2}}}</param>
        /// <returns>ValidaCartaoResponse</returns>
        ValidaCartaoResponse ValidarTarjaUsingGET (string numeroCartao, string trilha1, string trilha2);
  
        /// <summary>
        /// {{{cartao_resource_validar_tarja}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_validar_tarja_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">{{{cartao_resource_validar_tarja_param_numero_cartao}}}</param>
        /// <param name="trilha1">{{{cartao_resource_validar_tarja_param_trilha1}}}</param>
        /// <param name="trilha2">{{{cartao_resource_validar_tarja_param_trilha2}}}</param>
        /// <returns>ApiResponse of ValidaCartaoResponse</returns>
        ApiResponse<ValidaCartaoResponse> ValidarTarjaUsingGETWithHttpInfo (string numeroCartao, string trilha1, string trilha2);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{cartao_resource_alterar_alterar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_alterar_alterar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_alterar_alterar_senha_param_id}}}</param>
        /// <param name="senha">{{{cartao_resource_alterar_alterar_senha_param_nova_senha}}}</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> AlterarAlterarSenhaUsingPUTAsync (long? id, string senha);

        /// <summary>
        /// {{{cartao_resource_alterar_alterar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_alterar_alterar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_alterar_alterar_senha_param_id}}}</param>
        /// <param name="senha">{{{cartao_resource_alterar_alterar_senha_param_nova_senha}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> AlterarAlterarSenhaUsingPUTAsyncWithHttpInfo (long? id, string senha);
        
        /// <summary>
        /// {{{cartao_resource_alterar_estagio}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_alterar_estagio_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_alterar_estagio_param_id}}}</param>
        /// <param name="update">{{{cartao_resource_alterar_estagio_param_id_estagio_cartao}}}</param>
        /// <returns>Task of CartaoResponse</returns>
        System.Threading.Tasks.Task<CartaoResponse> AlterarEstagioUsingPOSTAsync (long? id, EstagioCartaoUpdate update);

        /// <summary>
        /// {{{cartao_resource_alterar_estagio}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_alterar_estagio_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_alterar_estagio_param_id}}}</param>
        /// <param name="update">{{{cartao_resource_alterar_estagio_param_id_estagio_cartao}}}</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> AlterarEstagioUsingPOSTAsyncWithHttpInfo (long? id, EstagioCartaoUpdate update);
        
        /// <summary>
        /// {{{cartao_resource_alterar_status_impressao}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_alterar_status_impressao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_alterar_status_impressao_param_id}}}</param>
        /// <param name="idStatusImpressao">{{{cartao_resource_alterar_status_impressao_param_id_status_impressao}}}</param>
        /// <returns>Task of HistoricoImpressaoCartaoResponse</returns>
        System.Threading.Tasks.Task<HistoricoImpressaoCartaoResponse> AlterarStatusImpressaoUsingPUTAsync (long? id, long? idStatusImpressao);

        /// <summary>
        /// {{{cartao_resource_alterar_status_impressao}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_alterar_status_impressao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_alterar_status_impressao_param_id}}}</param>
        /// <param name="idStatusImpressao">{{{cartao_resource_alterar_status_impressao_param_id_status_impressao}}}</param>
        /// <returns>Task of ApiResponse (HistoricoImpressaoCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<HistoricoImpressaoCartaoResponse>> AlterarStatusImpressaoUsingPUTAsyncWithHttpInfo (long? id, long? idStatusImpressao);
        
        /// <summary>
        /// {{{cartao_resource_atribuir_pessoa}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_atribuir_pessoa_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_atribuir_pessoa_param_id_cartao}}}</param>
        /// <param name="idPessoa">{{{cartao_resource_atribuir_pessoa_param_id_pessoa}}}</param>
        /// <returns>Task of CartaoResponse</returns>
        System.Threading.Tasks.Task<CartaoResponse> AtribuirPessoaUsingPUTAsync (long? id, long? idPessoa);

        /// <summary>
        /// {{{cartao_resource_atribuir_pessoa}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_atribuir_pessoa_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_atribuir_pessoa_param_id_cartao}}}</param>
        /// <param name="idPessoa">{{{cartao_resource_atribuir_pessoa_param_id_pessoa}}}</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> AtribuirPessoaUsingPUTAsyncWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// {{{cartao_resource_bloquear}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_bloquear_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_bloquear_param_id}}}</param>
        /// <param name="idStatus">{{{cartao_resource_bloquear_param_id_status}}}</param>
        /// <param name="observacao">{{{cartao_resource_bloquear_param_observacao}}}</param>
        /// <returns>Task of CartaoResponse</returns>
        System.Threading.Tasks.Task<CartaoResponse> BloquearUsingPOSTAsync (long? id, long? idStatus, string observacao);

        /// <summary>
        /// {{{cartao_resource_bloquear}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_bloquear_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_bloquear_param_id}}}</param>
        /// <param name="idStatus">{{{cartao_resource_bloquear_param_id_status}}}</param>
        /// <param name="observacao">{{{cartao_resource_bloquear_param_observacao}}}</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> BloquearUsingPOSTAsyncWithHttpInfo (long? id, long? idStatus, string observacao);
        
        /// <summary>
        /// {{{cartao_resource_cadastrar_alterar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_cadastrar_alterar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_cadastrar_alterar_senha_param_id}}}</param>
        /// <param name="senha">{{{cartao_resource_cadastrar_alterar_senha_param_nova_senha}}}</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> CadastrarAlterarSenhaUsingPOSTAsync (long? id, string senha);

        /// <summary>
        /// {{{cartao_resource_cadastrar_alterar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_cadastrar_alterar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_cadastrar_alterar_senha_param_id}}}</param>
        /// <param name="senha">{{{cartao_resource_cadastrar_alterar_senha_param_nova_senha}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> CadastrarAlterarSenhaUsingPOSTAsyncWithHttpInfo (long? id, string senha);
        
        /// <summary>
        /// {{{cartao_resource_cancelar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_cancelar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_cancelar_param_id}}}</param>
        /// <param name="idStatus">{{{cartao_resource_cancelar_param_id_status}}}</param>
        /// <param name="observacao">{{{cartao_resource_cancelar_param_observacao}}}</param>
        /// <returns>Task of CartaoResponse</returns>
        System.Threading.Tasks.Task<CartaoResponse> CancelarUsingPOSTAsync (long? id, long? idStatus, string observacao);

        /// <summary>
        /// {{{cartao_resource_cancelar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_cancelar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_cancelar_param_id}}}</param>
        /// <param name="idStatus">{{{cartao_resource_cancelar_param_id_status}}}</param>
        /// <param name="observacao">{{{cartao_resource_cancelar_param_observacao}}}</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> CancelarUsingPOSTAsyncWithHttpInfo (long? id, long? idStatus, string observacao);
        
        /// <summary>
        /// {{{cartao_resource_consultar_cartao_impressao}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_consultar_cartao_impressao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_cartao_impressao_param_id}}}</param>
        /// <returns>Task of DadosCartaoImpressaoResponse</returns>
        System.Threading.Tasks.Task<DadosCartaoImpressaoResponse> ConsultarCartaoImpressaoUsingGETAsync (long? id);

        /// <summary>
        /// {{{cartao_resource_consultar_cartao_impressao}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_consultar_cartao_impressao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_cartao_impressao_param_id}}}</param>
        /// <returns>Task of ApiResponse (DadosCartaoImpressaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DadosCartaoImpressaoResponse>> ConsultarCartaoImpressaoUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{cartao_resource_consultar_dados_reais_cartao}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_consultar_dados_reais_cartao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of DadosCartaoResponse</returns>
        System.Threading.Tasks.Task<DadosCartaoResponse> ConsultarDadosReaisCartaoUsingGETAsync (long? id);

        /// <summary>
        /// {{{cartao_resource_consultar_dados_reais_cartao}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_consultar_dados_reais_cartao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (DadosCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DadosCartaoResponse>> ConsultarDadosReaisCartaoUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{cartao_resource_consultar_limite_disponibilidade}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_consultar_limite_disponibilidade_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_limite_disponibilidade_param_id}}}</param>
        /// <returns>Task of LimiteDisponibilidadeResponse</returns>
        System.Threading.Tasks.Task<LimiteDisponibilidadeResponse> ConsultarLimiteDisponibilidadeUsingGETAsync (long? id);

        /// <summary>
        /// {{{cartao_resource_consultar_limite_disponibilidade}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_consultar_limite_disponibilidade_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_limite_disponibilidade_param_id}}}</param>
        /// <returns>Task of ApiResponse (LimiteDisponibilidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LimiteDisponibilidadeResponse>> ConsultarLimiteDisponibilidadeUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{cartao_resource_consultar_lotes_cartoes_pre_pagos}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_consultar_lotes_cartoes_pre_pagos_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_lotes_cartoes_pre_pagos_param_id_lote}}}</param>
        /// <returns>Task of LoteCartoesPrePagosResponse</returns>
        System.Threading.Tasks.Task<LoteCartoesPrePagosResponse> ConsultarLotesCartoesPrePagosUsingGETAsync (long? id);

        /// <summary>
        /// {{{cartao_resource_consultar_lotes_cartoes_pre_pagos}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_consultar_lotes_cartoes_pre_pagos_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_lotes_cartoes_pre_pagos_param_id_lote}}}</param>
        /// <returns>Task of ApiResponse (LoteCartoesPrePagosResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LoteCartoesPrePagosResponse>> ConsultarLotesCartoesPrePagosUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{cartao_resource_consultar_portador}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_consultar_portador_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_portador_param_id}}}</param>
        /// <returns>Task of PortadorResponse</returns>
        System.Threading.Tasks.Task<PortadorResponse> ConsultarPortadorUsingGETAsync (long? id);

        /// <summary>
        /// {{{cartao_resource_consultar_portador}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_consultar_portador_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_portador_param_id}}}</param>
        /// <returns>Task of ApiResponse (PortadorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortadorResponse>> ConsultarPortadorUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{cartao_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_param_id}}}</param>
        /// <returns>Task of CartaoDetalheResponse</returns>
        System.Threading.Tasks.Task<CartaoDetalheResponse> ConsultarUsingGET12Async (long? id);

        /// <summary>
        /// {{{cartao_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (CartaoDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoDetalheResponse>> ConsultarUsingGET12AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{conta_resource_cadastrar_cartao_multiapp}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_cadastrar_cartao_multiapp_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartaoMultiAppPersist">cartaoMultiAppPersist</param>
        /// <returns>Task of VinculoCartoesResponse</returns>
        System.Threading.Tasks.Task<VinculoCartoesResponse> CriarCartoesMultiAppUsingPOSTAsync (CartaoMultiAppPersistValue cartaoMultiAppPersist);

        /// <summary>
        /// {{{conta_resource_cadastrar_cartao_multiapp}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_resource_cadastrar_cartao_multiapp_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartaoMultiAppPersist">cartaoMultiAppPersist</param>
        /// <returns>Task of ApiResponse (VinculoCartoesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<VinculoCartoesResponse>> CriarCartoesMultiAppUsingPOSTAsyncWithHttpInfo (CartaoMultiAppPersistValue cartaoMultiAppPersist);
        
        /// <summary>
        /// {{{cartao_resource_desbloquear_senha_incorreta}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_desbloquear_senha_incorreta_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_desbloquear_senha_incorreta_param_id}}}</param>
        /// <returns>Task of CartaoResponse</returns>
        System.Threading.Tasks.Task<CartaoResponse> DesbloquearSenhaIncorretaUsingPOSTAsync (long? id);

        /// <summary>
        /// {{{cartao_resource_desbloquear_senha_incorreta}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_desbloquear_senha_incorreta_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_desbloquear_senha_incorreta_param_id}}}</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> DesbloquearSenhaIncorretaUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{cartao_resource_desbloquear}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_desbloquear_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_desbloquear_param_id}}}</param>
        /// <returns>Task of CartaoResponse</returns>
        System.Threading.Tasks.Task<CartaoResponse> DesbloquearUsingPOSTAsync (long? id);

        /// <summary>
        /// {{{cartao_resource_desbloquear}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_desbloquear_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_desbloquear_param_id}}}</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> DesbloquearUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{cartao_resource_gerar_lotes_cartoes_pre_pagos}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_gerar_lotes_cartoes_pre_pagos_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idOrigemComercial">{{{lote_cartoes_pre_pagos_persist_id_origem_comercial_value}}} (optional)</param>
        /// <param name="idProduto">{{{lote_cartoes_pre_pagos_persist_id_produto_value}}} (optional)</param>
        /// <param name="idTipoCartao">{{{lote_cartoes_pre_pagos_persist_id_tipo_cartao_value}}} (optional)</param>
        /// <param name="idImagem">{{{lote_cartoes_pre_pagos_persist_id_imagem_value}}} (optional)</param>
        /// <param name="idEndereco">{{{lote_cartoes_pre_pagos_persist_id_endereco_value}}} (optional)</param>
        /// <param name="quantidadeCartoes">{{{lote_cartoes_pre_pagos_persist_quantidade_cartoes_value}}} (optional)</param>
        /// <param name="identificadorExterno">{{{lote_cartoes_pre_pagos_persist_identificador_externo_value}}} (optional)</param>
        /// <returns>Task of LoteCartoesPrePagosResponse</returns>
        System.Threading.Tasks.Task<LoteCartoesPrePagosResponse> GerarLotesCartoesPrePagosUsingPOSTAsync (long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string identificadorExterno = null);

        /// <summary>
        /// {{{cartao_resource_gerar_lotes_cartoes_pre_pagos}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_gerar_lotes_cartoes_pre_pagos_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idOrigemComercial">{{{lote_cartoes_pre_pagos_persist_id_origem_comercial_value}}} (optional)</param>
        /// <param name="idProduto">{{{lote_cartoes_pre_pagos_persist_id_produto_value}}} (optional)</param>
        /// <param name="idTipoCartao">{{{lote_cartoes_pre_pagos_persist_id_tipo_cartao_value}}} (optional)</param>
        /// <param name="idImagem">{{{lote_cartoes_pre_pagos_persist_id_imagem_value}}} (optional)</param>
        /// <param name="idEndereco">{{{lote_cartoes_pre_pagos_persist_id_endereco_value}}} (optional)</param>
        /// <param name="quantidadeCartoes">{{{lote_cartoes_pre_pagos_persist_quantidade_cartoes_value}}} (optional)</param>
        /// <param name="identificadorExterno">{{{lote_cartoes_pre_pagos_persist_identificador_externo_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (LoteCartoesPrePagosResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LoteCartoesPrePagosResponse>> GerarLotesCartoesPrePagosUsingPOSTAsyncWithHttpInfo (long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string identificadorExterno = null);
        
        /// <summary>
        /// {{{cartao_resource_gerar_nova_via_multiplo}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_gerar_nova_via_multiplo_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_gerar_nova_via_param_id_cartao}}}</param>
        /// <returns>Task of CartaoMultiAppImpressaoResponse</returns>
        System.Threading.Tasks.Task<CartaoMultiAppImpressaoResponse> GerarNovaViaCartaoMultiAppUsingPOSTAsync (long? id);

        /// <summary>
        /// {{{cartao_resource_gerar_nova_via_multiplo}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_gerar_nova_via_multiplo_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_gerar_nova_via_param_id_cartao}}}</param>
        /// <returns>Task of ApiResponse (CartaoMultiAppImpressaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoMultiAppImpressaoResponse>> GerarNovaViaCartaoMultiAppUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{cartao_resource_gerar_nova_via}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_gerar_nova_via_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_gerar_nova_via_param_id_cartao}}}</param>
        /// <returns>Task of CartaoResponse</returns>
        System.Threading.Tasks.Task<CartaoResponse> GerarNovaViaUsingPOSTAsync (long? id);

        /// <summary>
        /// {{{cartao_resource_gerar_nova_via}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_gerar_nova_via_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_gerar_nova_via_param_id_cartao}}}</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> GerarNovaViaUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{cartao_resource_lancar_tarifa_segunda_via}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_lancar_tarifa_segunda_via_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_lancar_tarifa_segunda_via_param_id}}}</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> LancarTarifaSegundaViaUsingPOSTAsync (long? id);

        /// <summary>
        /// {{{cartao_resource_lancar_tarifa_segunda_via}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_lancar_tarifa_segunda_via_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_lancar_tarifa_segunda_via_param_id}}}</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> LancarTarifaSegundaViaUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{cartao_resource_listar_lotes_cartoes_pre_pagos}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_listar_lotes_cartoes_pre_pagos_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idOrigemComercial">{{{lote_cartoes_pre_pagos_request_id_origem_comercial_value}}} (optional)</param>
        /// <param name="idProduto">{{{lote_cartoes_pre_pagos_request_id_produto_value}}} (optional)</param>
        /// <param name="idTipoCartao">{{{lote_cartoes_pre_pagos_request_id_tipo_cartao_value}}} (optional)</param>
        /// <param name="idImagem">{{{lote_cartoes_pre_pagos_request_id_imagem_value}}} (optional)</param>
        /// <param name="idEndereco">{{{lote_cartoes_pre_pagos_request_id_endereco_value}}} (optional)</param>
        /// <param name="quantidadeCartoes">{{{lote_cartoes_pre_pagos_request_quantidade_cartoes_value}}} (optional)</param>
        /// <param name="dataCadastro">{{{lote_cartoes_pre_pagos_request_data_cadastro_value}}} (optional)</param>
        /// <param name="usuarioCadastro">{{{lote_cartoes_pre_pagos_request_usuario_cadastro_value}}} (optional)</param>
        /// <param name="statusProcessamento">{{{lote_cartoes_pre_pagos_request_status_processamento_value}}} (optional)</param>
        /// <param name="identificadorExterno">{{{lote_cartoes_pre_pagos_request_identificador_externo_value}}} (optional)</param>
        /// <returns>Task of PageLoteCartoesPrePagosResponse</returns>
        System.Threading.Tasks.Task<PageLoteCartoesPrePagosResponse> ListarLotesCartoesPrePagosUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string dataCadastro = null, string usuarioCadastro = null, int? statusProcessamento = null, string identificadorExterno = null);

        /// <summary>
        /// {{{cartao_resource_listar_lotes_cartoes_pre_pagos}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_listar_lotes_cartoes_pre_pagos_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idOrigemComercial">{{{lote_cartoes_pre_pagos_request_id_origem_comercial_value}}} (optional)</param>
        /// <param name="idProduto">{{{lote_cartoes_pre_pagos_request_id_produto_value}}} (optional)</param>
        /// <param name="idTipoCartao">{{{lote_cartoes_pre_pagos_request_id_tipo_cartao_value}}} (optional)</param>
        /// <param name="idImagem">{{{lote_cartoes_pre_pagos_request_id_imagem_value}}} (optional)</param>
        /// <param name="idEndereco">{{{lote_cartoes_pre_pagos_request_id_endereco_value}}} (optional)</param>
        /// <param name="quantidadeCartoes">{{{lote_cartoes_pre_pagos_request_quantidade_cartoes_value}}} (optional)</param>
        /// <param name="dataCadastro">{{{lote_cartoes_pre_pagos_request_data_cadastro_value}}} (optional)</param>
        /// <param name="usuarioCadastro">{{{lote_cartoes_pre_pagos_request_usuario_cadastro_value}}} (optional)</param>
        /// <param name="statusProcessamento">{{{lote_cartoes_pre_pagos_request_status_processamento_value}}} (optional)</param>
        /// <param name="identificadorExterno">{{{lote_cartoes_pre_pagos_request_identificador_externo_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageLoteCartoesPrePagosResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageLoteCartoesPrePagosResponse>> ListarLotesCartoesPrePagosUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string dataCadastro = null, string usuarioCadastro = null, int? statusProcessamento = null, string identificadorExterno = null);
        
        /// <summary>
        /// {{{cartao_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idStatusCartao">{{{cartao_request_id_status_cartao_value}}} (optional)</param>
        /// <param name="idEstagioCartao">{{{cartao_request_id_estagio_cartao_value}}} (optional)</param>
        /// <param name="idConta">{{{cartao_request_id_conta_value}}} (optional)</param>
        /// <param name="idPessoa">{{{cartao_request_id_pessoa_value}}} (optional)</param>
        /// <param name="idProduto">{{{cartao_request_id_produto_value}}} (optional)</param>
        /// <param name="tipoPortador">{{{cartao_request_tipo_portador_value}}} (optional)</param>
        /// <param name="numeroCartao">{{{cartao_request_numero_cartao_value}}} (optional)</param>
        /// <param name="nomeImpresso">{{{cartao_request_nome_impresso_value}}} (optional)</param>
        /// <param name="dataGeracao">{{{cartao_request_data_geracao_value}}} (optional)</param>
        /// <param name="dataStatusCartao">{{{cartao_request_data_status_cartao_value}}} (optional)</param>
        /// <param name="dataEstagioCartao">{{{cartao_request_data_estagio_cartao_value}}} (optional)</param>
        /// <param name="dataValidade">{{{cartao_request_data_validade_value}}} (optional)</param>
        /// <param name="dataImpressao">{{{cartao_request_data_impressao_value}}} (optional)</param>
        /// <param name="arquivoImpressao">{{{cartao_request_arquivo_impressao_value}}} (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">{{{cartao_request_flag_impressao_origem_comercial_value}}} (optional)</param>
        /// <param name="flagProvisorio">{{{cartao_request_flag_provisorio_value}}} (optional)</param>
        /// <param name="codigoDesbloqueio">{{{cartao_request_codigo_desbloqueio_value}}} (optional)</param>
        /// <param name="sequencialCartao">{{{cartao_request_sequencial_cartao_value}}} (optional)</param>
        /// <param name="identificadorExterno">{{{cartao_request_identificador_externo_value}}} (optional)</param>
        /// <returns>Task of PageCartaoResponse</returns>
        System.Threading.Tasks.Task<PageCartaoResponse> ListarUsingGET12Async (List<string> sort = null, int? page = null, int? limit = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? sequencialCartao = null, long? identificadorExterno = null);

        /// <summary>
        /// {{{cartao_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idStatusCartao">{{{cartao_request_id_status_cartao_value}}} (optional)</param>
        /// <param name="idEstagioCartao">{{{cartao_request_id_estagio_cartao_value}}} (optional)</param>
        /// <param name="idConta">{{{cartao_request_id_conta_value}}} (optional)</param>
        /// <param name="idPessoa">{{{cartao_request_id_pessoa_value}}} (optional)</param>
        /// <param name="idProduto">{{{cartao_request_id_produto_value}}} (optional)</param>
        /// <param name="tipoPortador">{{{cartao_request_tipo_portador_value}}} (optional)</param>
        /// <param name="numeroCartao">{{{cartao_request_numero_cartao_value}}} (optional)</param>
        /// <param name="nomeImpresso">{{{cartao_request_nome_impresso_value}}} (optional)</param>
        /// <param name="dataGeracao">{{{cartao_request_data_geracao_value}}} (optional)</param>
        /// <param name="dataStatusCartao">{{{cartao_request_data_status_cartao_value}}} (optional)</param>
        /// <param name="dataEstagioCartao">{{{cartao_request_data_estagio_cartao_value}}} (optional)</param>
        /// <param name="dataValidade">{{{cartao_request_data_validade_value}}} (optional)</param>
        /// <param name="dataImpressao">{{{cartao_request_data_impressao_value}}} (optional)</param>
        /// <param name="arquivoImpressao">{{{cartao_request_arquivo_impressao_value}}} (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">{{{cartao_request_flag_impressao_origem_comercial_value}}} (optional)</param>
        /// <param name="flagProvisorio">{{{cartao_request_flag_provisorio_value}}} (optional)</param>
        /// <param name="codigoDesbloqueio">{{{cartao_request_codigo_desbloqueio_value}}} (optional)</param>
        /// <param name="sequencialCartao">{{{cartao_request_sequencial_cartao_value}}} (optional)</param>
        /// <param name="identificadorExterno">{{{cartao_request_identificador_externo_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCartaoResponse>> ListarUsingGET12AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? sequencialCartao = null, long? identificadorExterno = null);
        
        /// <summary>
        /// {{{cartao_resource_reativar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_reativar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_reativar_param_id}}}</param>
        /// <returns>Task of CartaoResponse</returns>
        System.Threading.Tasks.Task<CartaoResponse> ReativarUsingPOSTAsync (long? id);

        /// <summary>
        /// {{{cartao_resource_reativar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_reativar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_reativar_param_id}}}</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> ReativarUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{cartao_resource_validar_c_v_v}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_validar_c_v_v_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_validar_c_v_v_param_id}}}</param>
        /// <param name="validaCVV">validaCVV</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ValidarCVVUsingPOSTAsync (long? id, ValidaCVVRequest validaCVV);

        /// <summary>
        /// {{{cartao_resource_validar_c_v_v}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_validar_c_v_v_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_validar_c_v_v_param_id}}}</param>
        /// <param name="validaCVV">validaCVV</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ValidarCVVUsingPOSTAsyncWithHttpInfo (long? id, ValidaCVVRequest validaCVV);
        
        /// <summary>
        /// {{{cartao_resource_validar_dados_impressos_bandeirado}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_validar_dados_impressos_bandeirado_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">{{{cartao_resource_validar_dados_impressos_bandeirado_param_numero_cartao}}}</param>
        /// <param name="nomePortador">{{{cartao_resource_validar_dados_impressos_bandeirado_param_nome_portador}}}</param>
        /// <param name="dataValidade">{{{cartao_resource_validar_dados_impressos_bandeirado_param_data_validade}}}</param>
        /// <param name="codigoSeguranca">{{{cartao_resource_validar_dados_impressos_bandeirado_param_codigo_seguranca}}}</param>
        /// <returns>Task of ValidaCartaoResponse</returns>
        System.Threading.Tasks.Task<ValidaCartaoResponse> ValidarDadosImpressosBandeiradoUsingGETAsync (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);

        /// <summary>
        /// {{{cartao_resource_validar_dados_impressos_bandeirado}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_validar_dados_impressos_bandeirado_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">{{{cartao_resource_validar_dados_impressos_bandeirado_param_numero_cartao}}}</param>
        /// <param name="nomePortador">{{{cartao_resource_validar_dados_impressos_bandeirado_param_nome_portador}}}</param>
        /// <param name="dataValidade">{{{cartao_resource_validar_dados_impressos_bandeirado_param_data_validade}}}</param>
        /// <param name="codigoSeguranca">{{{cartao_resource_validar_dados_impressos_bandeirado_param_codigo_seguranca}}}</param>
        /// <returns>Task of ApiResponse (ValidaCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ValidaCartaoResponse>> ValidarDadosImpressosBandeiradoUsingGETAsyncWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);
        
        /// <summary>
        /// {{{cartao_resource_validar_dados_impressos_nao_bandeirado}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_validar_dados_impressos_nao_bandeirado_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">{{{cartao_resource_validar_dados_impressos_nao_bandeirado_param_numero_cartao}}}</param>
        /// <param name="nomePortador">{{{cartao_resource_validar_dados_impressos_nao_bandeirado_param_nome_portador}}}</param>
        /// <param name="dataValidade">{{{cartao_resource_validar_dados_impressos_nao_bandeirado_param_data_validade}}}</param>
        /// <param name="codigoSeguranca">{{{cartao_resource_validar_dados_impressos_nao_bandeirado_param_codigo_seguranca}}}</param>
        /// <returns>Task of ValidaCartaoResponse</returns>
        System.Threading.Tasks.Task<ValidaCartaoResponse> ValidarDadosImpressosNaoBandeiradoUsingGETAsync (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);

        /// <summary>
        /// {{{cartao_resource_validar_dados_impressos_nao_bandeirado}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_validar_dados_impressos_nao_bandeirado_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">{{{cartao_resource_validar_dados_impressos_nao_bandeirado_param_numero_cartao}}}</param>
        /// <param name="nomePortador">{{{cartao_resource_validar_dados_impressos_nao_bandeirado_param_nome_portador}}}</param>
        /// <param name="dataValidade">{{{cartao_resource_validar_dados_impressos_nao_bandeirado_param_data_validade}}}</param>
        /// <param name="codigoSeguranca">{{{cartao_resource_validar_dados_impressos_nao_bandeirado_param_codigo_seguranca}}}</param>
        /// <returns>Task of ApiResponse (ValidaCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ValidaCartaoResponse>> ValidarDadosImpressosNaoBandeiradoUsingGETAsyncWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);
        
        /// <summary>
        /// {{{cartao_resource_validar_de55_cartao_mastercard}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_validar_de55_cartao_mastercard_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">{{{cartao_resource_validar_de55_cartao_mastercard_param_numero_cartao}}}</param>
        /// <param name="criptograma">{{{cartao_resource_validar_de55_cartao_mastercard_param_criptograma}}}</param>
        /// <returns>Task of ValidaCartaoResponse</returns>
        System.Threading.Tasks.Task<ValidaCartaoResponse> ValidarDe55CartaoMastercardUsingGETAsync (string numeroCartao, string criptograma);

        /// <summary>
        /// {{{cartao_resource_validar_de55_cartao_mastercard}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_validar_de55_cartao_mastercard_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">{{{cartao_resource_validar_de55_cartao_mastercard_param_numero_cartao}}}</param>
        /// <param name="criptograma">{{{cartao_resource_validar_de55_cartao_mastercard_param_criptograma}}}</param>
        /// <returns>Task of ApiResponse (ValidaCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ValidaCartaoResponse>> ValidarDe55CartaoMastercardUsingGETAsyncWithHttpInfo (string numeroCartao, string criptograma);
        
        /// <summary>
        /// {{{cartao_resource_validar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_validar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_validar_senha_param_id}}}</param>
        /// <param name="senha">{{{cartao_resource_validar_senha_param_senha}}}</param>
        /// <returns>Task of ValidaSenhaCartaoResponse</returns>
        System.Threading.Tasks.Task<ValidaSenhaCartaoResponse> ValidarSenhaUsingGETAsync (long? id, string senha);

        /// <summary>
        /// {{{cartao_resource_validar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_validar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_validar_senha_param_id}}}</param>
        /// <param name="senha">{{{cartao_resource_validar_senha_param_senha}}}</param>
        /// <returns>Task of ApiResponse (ValidaSenhaCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ValidaSenhaCartaoResponse>> ValidarSenhaUsingGETAsyncWithHttpInfo (long? id, string senha);
        
        /// <summary>
        /// {{{cartao_resource_validar_tarja}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_validar_tarja_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">{{{cartao_resource_validar_tarja_param_numero_cartao}}}</param>
        /// <param name="trilha1">{{{cartao_resource_validar_tarja_param_trilha1}}}</param>
        /// <param name="trilha2">{{{cartao_resource_validar_tarja_param_trilha2}}}</param>
        /// <returns>Task of ValidaCartaoResponse</returns>
        System.Threading.Tasks.Task<ValidaCartaoResponse> ValidarTarjaUsingGETAsync (string numeroCartao, string trilha1, string trilha2);

        /// <summary>
        /// {{{cartao_resource_validar_tarja}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_resource_validar_tarja_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">{{{cartao_resource_validar_tarja_param_numero_cartao}}}</param>
        /// <param name="trilha1">{{{cartao_resource_validar_tarja_param_trilha1}}}</param>
        /// <param name="trilha2">{{{cartao_resource_validar_tarja_param_trilha2}}}</param>
        /// <returns>Task of ApiResponse (ValidaCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ValidaCartaoResponse>> ValidarTarjaUsingGETAsyncWithHttpInfo (string numeroCartao, string trilha1, string trilha2);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltagcartaoApi : IGlobaltagcartaoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagcartaoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltagcartaoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagcartaoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltagcartaoApi(Configuration configuration = null)
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
        /// {{{cartao_resource_alterar_alterar_senha}}} {{{cartao_resource_alterar_alterar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_alterar_alterar_senha_param_id}}}</param> 
        /// <param name="senha">{{{cartao_resource_alterar_alterar_senha_param_nova_senha}}}</param> 
        /// <returns>string</returns>
        public string AlterarAlterarSenhaUsingPUT (long? id, string senha)
        {
             ApiResponse<string> localVarResponse = AlterarAlterarSenhaUsingPUTWithHttpInfo(id, senha);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_resource_alterar_alterar_senha}}} {{{cartao_resource_alterar_alterar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_alterar_alterar_senha_param_id}}}</param> 
        /// <param name="senha">{{{cartao_resource_alterar_alterar_senha_param_nova_senha}}}</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > AlterarAlterarSenhaUsingPUTWithHttpInfo (long? id, string senha)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcartaoApi->AlterarAlterarSenhaUsingPUT");
            
            // verify the required parameter 'senha' is set
            if (senha == null)
                throw new ApiException(400, "Missing required parameter 'senha' when calling GlobaltagcartaoApi->AlterarAlterarSenhaUsingPUT");
            
    
            var localVarPath = "/api/cartoes/{id}/alterar-senha";
    
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
            
            
            if (senha != null) localVarHeaderParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // header parameter
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarAlterarSenhaUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarAlterarSenhaUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// {{{cartao_resource_alterar_alterar_senha}}} {{{cartao_resource_alterar_alterar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_alterar_alterar_senha_param_id}}}</param>
        /// <param name="senha">{{{cartao_resource_alterar_alterar_senha_param_nova_senha}}}</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> AlterarAlterarSenhaUsingPUTAsync (long? id, string senha)
        {
             ApiResponse<string> localVarResponse = await AlterarAlterarSenhaUsingPUTAsyncWithHttpInfo(id, senha);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_resource_alterar_alterar_senha}}} {{{cartao_resource_alterar_alterar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_alterar_alterar_senha_param_id}}}</param>
        /// <param name="senha">{{{cartao_resource_alterar_alterar_senha_param_nova_senha}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> AlterarAlterarSenhaUsingPUTAsyncWithHttpInfo (long? id, string senha)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarAlterarSenhaUsingPUT");
            // verify the required parameter 'senha' is set
            if (senha == null) throw new ApiException(400, "Missing required parameter 'senha' when calling AlterarAlterarSenhaUsingPUT");
            
    
            var localVarPath = "/api/cartoes/{id}/alterar-senha";
    
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
            
            
            if (senha != null) localVarHeaderParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // header parameter
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarAlterarSenhaUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarAlterarSenhaUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// {{{cartao_resource_alterar_estagio}}} {{{cartao_resource_alterar_estagio_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_alterar_estagio_param_id}}}</param> 
        /// <param name="update">{{{cartao_resource_alterar_estagio_param_id_estagio_cartao}}}</param> 
        /// <returns>CartaoResponse</returns>
        public CartaoResponse AlterarEstagioUsingPOST (long? id, EstagioCartaoUpdate update)
        {
             ApiResponse<CartaoResponse> localVarResponse = AlterarEstagioUsingPOSTWithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_resource_alterar_estagio}}} {{{cartao_resource_alterar_estagio_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_alterar_estagio_param_id}}}</param> 
        /// <param name="update">{{{cartao_resource_alterar_estagio_param_id_estagio_cartao}}}</param> 
        /// <returns>ApiResponse of CartaoResponse</returns>
        public ApiResponse< CartaoResponse > AlterarEstagioUsingPOSTWithHttpInfo (long? id, EstagioCartaoUpdate update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcartaoApi->AlterarEstagioUsingPOST");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling GlobaltagcartaoApi->AlterarEstagioUsingPOST");
            
    
            var localVarPath = "/api/cartoes/{id}/alterar-estagio";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarEstagioUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarEstagioUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }

        
        /// <summary>
        /// {{{cartao_resource_alterar_estagio}}} {{{cartao_resource_alterar_estagio_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_alterar_estagio_param_id}}}</param>
        /// <param name="update">{{{cartao_resource_alterar_estagio_param_id_estagio_cartao}}}</param>
        /// <returns>Task of CartaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoResponse> AlterarEstagioUsingPOSTAsync (long? id, EstagioCartaoUpdate update)
        {
             ApiResponse<CartaoResponse> localVarResponse = await AlterarEstagioUsingPOSTAsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_resource_alterar_estagio}}} {{{cartao_resource_alterar_estagio_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_alterar_estagio_param_id}}}</param>
        /// <param name="update">{{{cartao_resource_alterar_estagio_param_id_estagio_cartao}}}</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> AlterarEstagioUsingPOSTAsyncWithHttpInfo (long? id, EstagioCartaoUpdate update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarEstagioUsingPOST");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AlterarEstagioUsingPOST");
            
    
            var localVarPath = "/api/cartoes/{id}/alterar-estagio";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarEstagioUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarEstagioUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }
        
        /// <summary>
        /// {{{cartao_resource_alterar_status_impressao}}} {{{cartao_resource_alterar_status_impressao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_alterar_status_impressao_param_id}}}</param> 
        /// <param name="idStatusImpressao">{{{cartao_resource_alterar_status_impressao_param_id_status_impressao}}}</param> 
        /// <returns>HistoricoImpressaoCartaoResponse</returns>
        public HistoricoImpressaoCartaoResponse AlterarStatusImpressaoUsingPUT (long? id, long? idStatusImpressao)
        {
             ApiResponse<HistoricoImpressaoCartaoResponse> localVarResponse = AlterarStatusImpressaoUsingPUTWithHttpInfo(id, idStatusImpressao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_resource_alterar_status_impressao}}} {{{cartao_resource_alterar_status_impressao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_alterar_status_impressao_param_id}}}</param> 
        /// <param name="idStatusImpressao">{{{cartao_resource_alterar_status_impressao_param_id_status_impressao}}}</param> 
        /// <returns>ApiResponse of HistoricoImpressaoCartaoResponse</returns>
        public ApiResponse< HistoricoImpressaoCartaoResponse > AlterarStatusImpressaoUsingPUTWithHttpInfo (long? id, long? idStatusImpressao)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcartaoApi->AlterarStatusImpressaoUsingPUT");
            
            // verify the required parameter 'idStatusImpressao' is set
            if (idStatusImpressao == null)
                throw new ApiException(400, "Missing required parameter 'idStatusImpressao' when calling GlobaltagcartaoApi->AlterarStatusImpressaoUsingPUT");
            
    
            var localVarPath = "/api/cartoes/{id}/alterar-status-impressao";
    
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
            
            if (idStatusImpressao != null) localVarQueryParams.Add("id_status_impressao", Configuration.ApiClient.ParameterToString(idStatusImpressao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatusImpressaoUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatusImpressaoUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<HistoricoImpressaoCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HistoricoImpressaoCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(HistoricoImpressaoCartaoResponse)));
            
        }

        
        /// <summary>
        /// {{{cartao_resource_alterar_status_impressao}}} {{{cartao_resource_alterar_status_impressao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_alterar_status_impressao_param_id}}}</param>
        /// <param name="idStatusImpressao">{{{cartao_resource_alterar_status_impressao_param_id_status_impressao}}}</param>
        /// <returns>Task of HistoricoImpressaoCartaoResponse</returns>
        public async System.Threading.Tasks.Task<HistoricoImpressaoCartaoResponse> AlterarStatusImpressaoUsingPUTAsync (long? id, long? idStatusImpressao)
        {
             ApiResponse<HistoricoImpressaoCartaoResponse> localVarResponse = await AlterarStatusImpressaoUsingPUTAsyncWithHttpInfo(id, idStatusImpressao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_resource_alterar_status_impressao}}} {{{cartao_resource_alterar_status_impressao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_alterar_status_impressao_param_id}}}</param>
        /// <param name="idStatusImpressao">{{{cartao_resource_alterar_status_impressao_param_id_status_impressao}}}</param>
        /// <returns>Task of ApiResponse (HistoricoImpressaoCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<HistoricoImpressaoCartaoResponse>> AlterarStatusImpressaoUsingPUTAsyncWithHttpInfo (long? id, long? idStatusImpressao)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarStatusImpressaoUsingPUT");
            // verify the required parameter 'idStatusImpressao' is set
            if (idStatusImpressao == null) throw new ApiException(400, "Missing required parameter 'idStatusImpressao' when calling AlterarStatusImpressaoUsingPUT");
            
    
            var localVarPath = "/api/cartoes/{id}/alterar-status-impressao";
    
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
            
            if (idStatusImpressao != null) localVarQueryParams.Add("id_status_impressao", Configuration.ApiClient.ParameterToString(idStatusImpressao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatusImpressaoUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatusImpressaoUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<HistoricoImpressaoCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HistoricoImpressaoCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(HistoricoImpressaoCartaoResponse)));
            
        }
        
        /// <summary>
        /// {{{cartao_resource_atribuir_pessoa}}} {{{cartao_resource_atribuir_pessoa_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_atribuir_pessoa_param_id_cartao}}}</param> 
        /// <param name="idPessoa">{{{cartao_resource_atribuir_pessoa_param_id_pessoa}}}</param> 
        /// <returns>CartaoResponse</returns>
        public CartaoResponse AtribuirPessoaUsingPUT (long? id, long? idPessoa)
        {
             ApiResponse<CartaoResponse> localVarResponse = AtribuirPessoaUsingPUTWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_resource_atribuir_pessoa}}} {{{cartao_resource_atribuir_pessoa_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_atribuir_pessoa_param_id_cartao}}}</param> 
        /// <param name="idPessoa">{{{cartao_resource_atribuir_pessoa_param_id_pessoa}}}</param> 
        /// <returns>ApiResponse of CartaoResponse</returns>
        public ApiResponse< CartaoResponse > AtribuirPessoaUsingPUTWithHttpInfo (long? id, long? idPessoa)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcartaoApi->AtribuirPessoaUsingPUT");
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling GlobaltagcartaoApi->AtribuirPessoaUsingPUT");
            
    
            var localVarPath = "/api/cartoes/{id}/atribuir-titular";
    
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirPessoaUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirPessoaUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }

        
        /// <summary>
        /// {{{cartao_resource_atribuir_pessoa}}} {{{cartao_resource_atribuir_pessoa_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_atribuir_pessoa_param_id_cartao}}}</param>
        /// <param name="idPessoa">{{{cartao_resource_atribuir_pessoa_param_id_pessoa}}}</param>
        /// <returns>Task of CartaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoResponse> AtribuirPessoaUsingPUTAsync (long? id, long? idPessoa)
        {
             ApiResponse<CartaoResponse> localVarResponse = await AtribuirPessoaUsingPUTAsyncWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_resource_atribuir_pessoa}}} {{{cartao_resource_atribuir_pessoa_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_atribuir_pessoa_param_id_cartao}}}</param>
        /// <param name="idPessoa">{{{cartao_resource_atribuir_pessoa_param_id_pessoa}}}</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> AtribuirPessoaUsingPUTAsyncWithHttpInfo (long? id, long? idPessoa)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtribuirPessoaUsingPUT");
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling AtribuirPessoaUsingPUT");
            
    
            var localVarPath = "/api/cartoes/{id}/atribuir-titular";
    
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirPessoaUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirPessoaUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }
        
        /// <summary>
        /// {{{cartao_resource_bloquear}}} {{{cartao_resource_bloquear_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_bloquear_param_id}}}</param> 
        /// <param name="idStatus">{{{cartao_resource_bloquear_param_id_status}}}</param> 
        /// <param name="observacao">{{{cartao_resource_bloquear_param_observacao}}}</param> 
        /// <returns>CartaoResponse</returns>
        public CartaoResponse BloquearUsingPOST (long? id, long? idStatus, string observacao)
        {
             ApiResponse<CartaoResponse> localVarResponse = BloquearUsingPOSTWithHttpInfo(id, idStatus, observacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_resource_bloquear}}} {{{cartao_resource_bloquear_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_bloquear_param_id}}}</param> 
        /// <param name="idStatus">{{{cartao_resource_bloquear_param_id_status}}}</param> 
        /// <param name="observacao">{{{cartao_resource_bloquear_param_observacao}}}</param> 
        /// <returns>ApiResponse of CartaoResponse</returns>
        public ApiResponse< CartaoResponse > BloquearUsingPOSTWithHttpInfo (long? id, long? idStatus, string observacao)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcartaoApi->BloquearUsingPOST");
            
            // verify the required parameter 'idStatus' is set
            if (idStatus == null)
                throw new ApiException(400, "Missing required parameter 'idStatus' when calling GlobaltagcartaoApi->BloquearUsingPOST");
            
            // verify the required parameter 'observacao' is set
            if (observacao == null)
                throw new ApiException(400, "Missing required parameter 'observacao' when calling GlobaltagcartaoApi->BloquearUsingPOST");
            
    
            var localVarPath = "/api/cartoes/{id}/bloquear";
    
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
            if (observacao != null) localVarQueryParams.Add("observacao", Configuration.ApiClient.ParameterToString(observacao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling BloquearUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling BloquearUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }

        
        /// <summary>
        /// {{{cartao_resource_bloquear}}} {{{cartao_resource_bloquear_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_bloquear_param_id}}}</param>
        /// <param name="idStatus">{{{cartao_resource_bloquear_param_id_status}}}</param>
        /// <param name="observacao">{{{cartao_resource_bloquear_param_observacao}}}</param>
        /// <returns>Task of CartaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoResponse> BloquearUsingPOSTAsync (long? id, long? idStatus, string observacao)
        {
             ApiResponse<CartaoResponse> localVarResponse = await BloquearUsingPOSTAsyncWithHttpInfo(id, idStatus, observacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_resource_bloquear}}} {{{cartao_resource_bloquear_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_bloquear_param_id}}}</param>
        /// <param name="idStatus">{{{cartao_resource_bloquear_param_id_status}}}</param>
        /// <param name="observacao">{{{cartao_resource_bloquear_param_observacao}}}</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> BloquearUsingPOSTAsyncWithHttpInfo (long? id, long? idStatus, string observacao)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling BloquearUsingPOST");
            // verify the required parameter 'idStatus' is set
            if (idStatus == null) throw new ApiException(400, "Missing required parameter 'idStatus' when calling BloquearUsingPOST");
            // verify the required parameter 'observacao' is set
            if (observacao == null) throw new ApiException(400, "Missing required parameter 'observacao' when calling BloquearUsingPOST");
            
    
            var localVarPath = "/api/cartoes/{id}/bloquear";
    
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
            if (observacao != null) localVarQueryParams.Add("observacao", Configuration.ApiClient.ParameterToString(observacao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling BloquearUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling BloquearUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }
        
        /// <summary>
        /// {{{cartao_resource_cadastrar_alterar_senha}}} {{{cartao_resource_cadastrar_alterar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_cadastrar_alterar_senha_param_id}}}</param> 
        /// <param name="senha">{{{cartao_resource_cadastrar_alterar_senha_param_nova_senha}}}</param> 
        /// <returns>string</returns>
        public string CadastrarAlterarSenhaUsingPOST (long? id, string senha)
        {
             ApiResponse<string> localVarResponse = CadastrarAlterarSenhaUsingPOSTWithHttpInfo(id, senha);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_resource_cadastrar_alterar_senha}}} {{{cartao_resource_cadastrar_alterar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_cadastrar_alterar_senha_param_id}}}</param> 
        /// <param name="senha">{{{cartao_resource_cadastrar_alterar_senha_param_nova_senha}}}</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > CadastrarAlterarSenhaUsingPOSTWithHttpInfo (long? id, string senha)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcartaoApi->CadastrarAlterarSenhaUsingPOST");
            
            // verify the required parameter 'senha' is set
            if (senha == null)
                throw new ApiException(400, "Missing required parameter 'senha' when calling GlobaltagcartaoApi->CadastrarAlterarSenhaUsingPOST");
            
    
            var localVarPath = "/api/cartoes/{id}/cadastrar-senha";
    
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
            
            
            if (senha != null) localVarHeaderParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // header parameter
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarAlterarSenhaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarAlterarSenhaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// {{{cartao_resource_cadastrar_alterar_senha}}} {{{cartao_resource_cadastrar_alterar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_cadastrar_alterar_senha_param_id}}}</param>
        /// <param name="senha">{{{cartao_resource_cadastrar_alterar_senha_param_nova_senha}}}</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> CadastrarAlterarSenhaUsingPOSTAsync (long? id, string senha)
        {
             ApiResponse<string> localVarResponse = await CadastrarAlterarSenhaUsingPOSTAsyncWithHttpInfo(id, senha);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_resource_cadastrar_alterar_senha}}} {{{cartao_resource_cadastrar_alterar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_cadastrar_alterar_senha_param_id}}}</param>
        /// <param name="senha">{{{cartao_resource_cadastrar_alterar_senha_param_nova_senha}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> CadastrarAlterarSenhaUsingPOSTAsyncWithHttpInfo (long? id, string senha)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CadastrarAlterarSenhaUsingPOST");
            // verify the required parameter 'senha' is set
            if (senha == null) throw new ApiException(400, "Missing required parameter 'senha' when calling CadastrarAlterarSenhaUsingPOST");
            
    
            var localVarPath = "/api/cartoes/{id}/cadastrar-senha";
    
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
            
            
            if (senha != null) localVarHeaderParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // header parameter
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarAlterarSenhaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarAlterarSenhaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// {{{cartao_resource_cancelar}}} {{{cartao_resource_cancelar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_cancelar_param_id}}}</param> 
        /// <param name="idStatus">{{{cartao_resource_cancelar_param_id_status}}}</param> 
        /// <param name="observacao">{{{cartao_resource_cancelar_param_observacao}}}</param> 
        /// <returns>CartaoResponse</returns>
        public CartaoResponse CancelarUsingPOST (long? id, long? idStatus, string observacao)
        {
             ApiResponse<CartaoResponse> localVarResponse = CancelarUsingPOSTWithHttpInfo(id, idStatus, observacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_resource_cancelar}}} {{{cartao_resource_cancelar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_cancelar_param_id}}}</param> 
        /// <param name="idStatus">{{{cartao_resource_cancelar_param_id_status}}}</param> 
        /// <param name="observacao">{{{cartao_resource_cancelar_param_observacao}}}</param> 
        /// <returns>ApiResponse of CartaoResponse</returns>
        public ApiResponse< CartaoResponse > CancelarUsingPOSTWithHttpInfo (long? id, long? idStatus, string observacao)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcartaoApi->CancelarUsingPOST");
            
            // verify the required parameter 'idStatus' is set
            if (idStatus == null)
                throw new ApiException(400, "Missing required parameter 'idStatus' when calling GlobaltagcartaoApi->CancelarUsingPOST");
            
            // verify the required parameter 'observacao' is set
            if (observacao == null)
                throw new ApiException(400, "Missing required parameter 'observacao' when calling GlobaltagcartaoApi->CancelarUsingPOST");
            
    
            var localVarPath = "/api/cartoes/{id}/cancelar";
    
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
            if (observacao != null) localVarQueryParams.Add("observacao", Configuration.ApiClient.ParameterToString(observacao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }

        
        /// <summary>
        /// {{{cartao_resource_cancelar}}} {{{cartao_resource_cancelar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_cancelar_param_id}}}</param>
        /// <param name="idStatus">{{{cartao_resource_cancelar_param_id_status}}}</param>
        /// <param name="observacao">{{{cartao_resource_cancelar_param_observacao}}}</param>
        /// <returns>Task of CartaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoResponse> CancelarUsingPOSTAsync (long? id, long? idStatus, string observacao)
        {
             ApiResponse<CartaoResponse> localVarResponse = await CancelarUsingPOSTAsyncWithHttpInfo(id, idStatus, observacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_resource_cancelar}}} {{{cartao_resource_cancelar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_cancelar_param_id}}}</param>
        /// <param name="idStatus">{{{cartao_resource_cancelar_param_id_status}}}</param>
        /// <param name="observacao">{{{cartao_resource_cancelar_param_observacao}}}</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> CancelarUsingPOSTAsyncWithHttpInfo (long? id, long? idStatus, string observacao)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CancelarUsingPOST");
            // verify the required parameter 'idStatus' is set
            if (idStatus == null) throw new ApiException(400, "Missing required parameter 'idStatus' when calling CancelarUsingPOST");
            // verify the required parameter 'observacao' is set
            if (observacao == null) throw new ApiException(400, "Missing required parameter 'observacao' when calling CancelarUsingPOST");
            
    
            var localVarPath = "/api/cartoes/{id}/cancelar";
    
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
            if (observacao != null) localVarQueryParams.Add("observacao", Configuration.ApiClient.ParameterToString(observacao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }
        
        /// <summary>
        /// {{{cartao_resource_consultar_cartao_impressao}}} {{{cartao_resource_consultar_cartao_impressao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_cartao_impressao_param_id}}}</param> 
        /// <returns>DadosCartaoImpressaoResponse</returns>
        public DadosCartaoImpressaoResponse ConsultarCartaoImpressaoUsingGET (long? id)
        {
             ApiResponse<DadosCartaoImpressaoResponse> localVarResponse = ConsultarCartaoImpressaoUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_resource_consultar_cartao_impressao}}} {{{cartao_resource_consultar_cartao_impressao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_cartao_impressao_param_id}}}</param> 
        /// <returns>ApiResponse of DadosCartaoImpressaoResponse</returns>
        public ApiResponse< DadosCartaoImpressaoResponse > ConsultarCartaoImpressaoUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcartaoApi->ConsultarCartaoImpressaoUsingGET");
            
    
            var localVarPath = "/api/cartoes/{id}/consultar-dados-impressao";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCartaoImpressaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCartaoImpressaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DadosCartaoImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DadosCartaoImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DadosCartaoImpressaoResponse)));
            
        }

        
        /// <summary>
        /// {{{cartao_resource_consultar_cartao_impressao}}} {{{cartao_resource_consultar_cartao_impressao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_cartao_impressao_param_id}}}</param>
        /// <returns>Task of DadosCartaoImpressaoResponse</returns>
        public async System.Threading.Tasks.Task<DadosCartaoImpressaoResponse> ConsultarCartaoImpressaoUsingGETAsync (long? id)
        {
             ApiResponse<DadosCartaoImpressaoResponse> localVarResponse = await ConsultarCartaoImpressaoUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_resource_consultar_cartao_impressao}}} {{{cartao_resource_consultar_cartao_impressao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_cartao_impressao_param_id}}}</param>
        /// <returns>Task of ApiResponse (DadosCartaoImpressaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DadosCartaoImpressaoResponse>> ConsultarCartaoImpressaoUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarCartaoImpressaoUsingGET");
            
    
            var localVarPath = "/api/cartoes/{id}/consultar-dados-impressao";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCartaoImpressaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCartaoImpressaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DadosCartaoImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DadosCartaoImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DadosCartaoImpressaoResponse)));
            
        }
        
        /// <summary>
        /// {{{cartao_resource_consultar_dados_reais_cartao}}} {{{cartao_resource_consultar_dados_reais_cartao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>DadosCartaoResponse</returns>
        public DadosCartaoResponse ConsultarDadosReaisCartaoUsingGET (long? id)
        {
             ApiResponse<DadosCartaoResponse> localVarResponse = ConsultarDadosReaisCartaoUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_resource_consultar_dados_reais_cartao}}} {{{cartao_resource_consultar_dados_reais_cartao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>ApiResponse of DadosCartaoResponse</returns>
        public ApiResponse< DadosCartaoResponse > ConsultarDadosReaisCartaoUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcartaoApi->ConsultarDadosReaisCartaoUsingGET");
            
    
            var localVarPath = "/api/cartoes/{id}/consultar-dados-reais";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDadosReaisCartaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDadosReaisCartaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DadosCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DadosCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DadosCartaoResponse)));
            
        }

        
        /// <summary>
        /// {{{cartao_resource_consultar_dados_reais_cartao}}} {{{cartao_resource_consultar_dados_reais_cartao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of DadosCartaoResponse</returns>
        public async System.Threading.Tasks.Task<DadosCartaoResponse> ConsultarDadosReaisCartaoUsingGETAsync (long? id)
        {
             ApiResponse<DadosCartaoResponse> localVarResponse = await ConsultarDadosReaisCartaoUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_resource_consultar_dados_reais_cartao}}} {{{cartao_resource_consultar_dados_reais_cartao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (DadosCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DadosCartaoResponse>> ConsultarDadosReaisCartaoUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarDadosReaisCartaoUsingGET");
            
    
            var localVarPath = "/api/cartoes/{id}/consultar-dados-reais";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDadosReaisCartaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDadosReaisCartaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DadosCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DadosCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DadosCartaoResponse)));
            
        }
        
        /// <summary>
        /// {{{cartao_resource_consultar_limite_disponibilidade}}} {{{cartao_resource_consultar_limite_disponibilidade_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_limite_disponibilidade_param_id}}}</param> 
        /// <returns>LimiteDisponibilidadeResponse</returns>
        public LimiteDisponibilidadeResponse ConsultarLimiteDisponibilidadeUsingGET (long? id)
        {
             ApiResponse<LimiteDisponibilidadeResponse> localVarResponse = ConsultarLimiteDisponibilidadeUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_resource_consultar_limite_disponibilidade}}} {{{cartao_resource_consultar_limite_disponibilidade_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_limite_disponibilidade_param_id}}}</param> 
        /// <returns>ApiResponse of LimiteDisponibilidadeResponse</returns>
        public ApiResponse< LimiteDisponibilidadeResponse > ConsultarLimiteDisponibilidadeUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcartaoApi->ConsultarLimiteDisponibilidadeUsingGET");
            
    
            var localVarPath = "/api/cartoes/{id}/limites-disponibilidades";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLimiteDisponibilidadeUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLimiteDisponibilidadeUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LimiteDisponibilidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LimiteDisponibilidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimiteDisponibilidadeResponse)));
            
        }

        
        /// <summary>
        /// {{{cartao_resource_consultar_limite_disponibilidade}}} {{{cartao_resource_consultar_limite_disponibilidade_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_limite_disponibilidade_param_id}}}</param>
        /// <returns>Task of LimiteDisponibilidadeResponse</returns>
        public async System.Threading.Tasks.Task<LimiteDisponibilidadeResponse> ConsultarLimiteDisponibilidadeUsingGETAsync (long? id)
        {
             ApiResponse<LimiteDisponibilidadeResponse> localVarResponse = await ConsultarLimiteDisponibilidadeUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_resource_consultar_limite_disponibilidade}}} {{{cartao_resource_consultar_limite_disponibilidade_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_limite_disponibilidade_param_id}}}</param>
        /// <returns>Task of ApiResponse (LimiteDisponibilidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LimiteDisponibilidadeResponse>> ConsultarLimiteDisponibilidadeUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarLimiteDisponibilidadeUsingGET");
            
    
            var localVarPath = "/api/cartoes/{id}/limites-disponibilidades";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLimiteDisponibilidadeUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLimiteDisponibilidadeUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LimiteDisponibilidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LimiteDisponibilidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimiteDisponibilidadeResponse)));
            
        }
        
        /// <summary>
        /// {{{cartao_resource_consultar_lotes_cartoes_pre_pagos}}} {{{cartao_resource_consultar_lotes_cartoes_pre_pagos_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_lotes_cartoes_pre_pagos_param_id_lote}}}</param> 
        /// <returns>LoteCartoesPrePagosResponse</returns>
        public LoteCartoesPrePagosResponse ConsultarLotesCartoesPrePagosUsingGET (long? id)
        {
             ApiResponse<LoteCartoesPrePagosResponse> localVarResponse = ConsultarLotesCartoesPrePagosUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_resource_consultar_lotes_cartoes_pre_pagos}}} {{{cartao_resource_consultar_lotes_cartoes_pre_pagos_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_lotes_cartoes_pre_pagos_param_id_lote}}}</param> 
        /// <returns>ApiResponse of LoteCartoesPrePagosResponse</returns>
        public ApiResponse< LoteCartoesPrePagosResponse > ConsultarLotesCartoesPrePagosUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcartaoApi->ConsultarLotesCartoesPrePagosUsingGET");
            
    
            var localVarPath = "/api/cartoes/lotes-cartoes-pre-pagos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLotesCartoesPrePagosUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLotesCartoesPrePagosUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LoteCartoesPrePagosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LoteCartoesPrePagosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LoteCartoesPrePagosResponse)));
            
        }

        
        /// <summary>
        /// {{{cartao_resource_consultar_lotes_cartoes_pre_pagos}}} {{{cartao_resource_consultar_lotes_cartoes_pre_pagos_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_lotes_cartoes_pre_pagos_param_id_lote}}}</param>
        /// <returns>Task of LoteCartoesPrePagosResponse</returns>
        public async System.Threading.Tasks.Task<LoteCartoesPrePagosResponse> ConsultarLotesCartoesPrePagosUsingGETAsync (long? id)
        {
             ApiResponse<LoteCartoesPrePagosResponse> localVarResponse = await ConsultarLotesCartoesPrePagosUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_resource_consultar_lotes_cartoes_pre_pagos}}} {{{cartao_resource_consultar_lotes_cartoes_pre_pagos_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_lotes_cartoes_pre_pagos_param_id_lote}}}</param>
        /// <returns>Task of ApiResponse (LoteCartoesPrePagosResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LoteCartoesPrePagosResponse>> ConsultarLotesCartoesPrePagosUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarLotesCartoesPrePagosUsingGET");
            
    
            var localVarPath = "/api/cartoes/lotes-cartoes-pre-pagos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLotesCartoesPrePagosUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLotesCartoesPrePagosUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LoteCartoesPrePagosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LoteCartoesPrePagosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LoteCartoesPrePagosResponse)));
            
        }
        
        /// <summary>
        /// {{{cartao_resource_consultar_portador}}} {{{cartao_resource_consultar_portador_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_portador_param_id}}}</param> 
        /// <returns>PortadorResponse</returns>
        public PortadorResponse ConsultarPortadorUsingGET (long? id)
        {
             ApiResponse<PortadorResponse> localVarResponse = ConsultarPortadorUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_resource_consultar_portador}}} {{{cartao_resource_consultar_portador_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_portador_param_id}}}</param> 
        /// <returns>ApiResponse of PortadorResponse</returns>
        public ApiResponse< PortadorResponse > ConsultarPortadorUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcartaoApi->ConsultarPortadorUsingGET");
            
    
            var localVarPath = "/api/cartoes/{id}/portadores";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPortadorUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPortadorUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PortadorResponse)));
            
        }

        
        /// <summary>
        /// {{{cartao_resource_consultar_portador}}} {{{cartao_resource_consultar_portador_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_portador_param_id}}}</param>
        /// <returns>Task of PortadorResponse</returns>
        public async System.Threading.Tasks.Task<PortadorResponse> ConsultarPortadorUsingGETAsync (long? id)
        {
             ApiResponse<PortadorResponse> localVarResponse = await ConsultarPortadorUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_resource_consultar_portador}}} {{{cartao_resource_consultar_portador_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_portador_param_id}}}</param>
        /// <returns>Task of ApiResponse (PortadorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PortadorResponse>> ConsultarPortadorUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarPortadorUsingGET");
            
    
            var localVarPath = "/api/cartoes/{id}/portadores";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPortadorUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPortadorUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PortadorResponse)));
            
        }
        
        /// <summary>
        /// {{{cartao_resource_consultar}}} {{{cartao_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_param_id}}}</param> 
        /// <returns>CartaoDetalheResponse</returns>
        public CartaoDetalheResponse ConsultarUsingGET12 (long? id)
        {
             ApiResponse<CartaoDetalheResponse> localVarResponse = ConsultarUsingGET12WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_resource_consultar}}} {{{cartao_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of CartaoDetalheResponse</returns>
        public ApiResponse< CartaoDetalheResponse > ConsultarUsingGET12WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcartaoApi->ConsultarUsingGET12");
            
    
            var localVarPath = "/api/cartoes/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET12: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET12: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoDetalheResponse)));
            
        }

        
        /// <summary>
        /// {{{cartao_resource_consultar}}} {{{cartao_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_param_id}}}</param>
        /// <returns>Task of CartaoDetalheResponse</returns>
        public async System.Threading.Tasks.Task<CartaoDetalheResponse> ConsultarUsingGET12Async (long? id)
        {
             ApiResponse<CartaoDetalheResponse> localVarResponse = await ConsultarUsingGET12AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_resource_consultar}}} {{{cartao_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (CartaoDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoDetalheResponse>> ConsultarUsingGET12AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET12");
            
    
            var localVarPath = "/api/cartoes/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET12: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET12: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoDetalheResponse)));
            
        }
        
        /// <summary>
        /// {{{conta_resource_cadastrar_cartao_multiapp}}} {{{conta_resource_cadastrar_cartao_multiapp_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartaoMultiAppPersist">cartaoMultiAppPersist</param> 
        /// <returns>VinculoCartoesResponse</returns>
        public VinculoCartoesResponse CriarCartoesMultiAppUsingPOST (CartaoMultiAppPersistValue cartaoMultiAppPersist)
        {
             ApiResponse<VinculoCartoesResponse> localVarResponse = CriarCartoesMultiAppUsingPOSTWithHttpInfo(cartaoMultiAppPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_resource_cadastrar_cartao_multiapp}}} {{{conta_resource_cadastrar_cartao_multiapp_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartaoMultiAppPersist">cartaoMultiAppPersist</param> 
        /// <returns>ApiResponse of VinculoCartoesResponse</returns>
        public ApiResponse< VinculoCartoesResponse > CriarCartoesMultiAppUsingPOSTWithHttpInfo (CartaoMultiAppPersistValue cartaoMultiAppPersist)
        {
            
            // verify the required parameter 'cartaoMultiAppPersist' is set
            if (cartaoMultiAppPersist == null)
                throw new ApiException(400, "Missing required parameter 'cartaoMultiAppPersist' when calling GlobaltagcartaoApi->CriarCartoesMultiAppUsingPOST");
            
    
            var localVarPath = "/api/cartoes/gerar-cartoes-multiapp";
    
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
            
            
            
            
            if (cartaoMultiAppPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cartaoMultiAppPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cartaoMultiAppPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CriarCartoesMultiAppUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CriarCartoesMultiAppUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<VinculoCartoesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VinculoCartoesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VinculoCartoesResponse)));
            
        }

        
        /// <summary>
        /// {{{conta_resource_cadastrar_cartao_multiapp}}} {{{conta_resource_cadastrar_cartao_multiapp_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartaoMultiAppPersist">cartaoMultiAppPersist</param>
        /// <returns>Task of VinculoCartoesResponse</returns>
        public async System.Threading.Tasks.Task<VinculoCartoesResponse> CriarCartoesMultiAppUsingPOSTAsync (CartaoMultiAppPersistValue cartaoMultiAppPersist)
        {
             ApiResponse<VinculoCartoesResponse> localVarResponse = await CriarCartoesMultiAppUsingPOSTAsyncWithHttpInfo(cartaoMultiAppPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_resource_cadastrar_cartao_multiapp}}} {{{conta_resource_cadastrar_cartao_multiapp_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartaoMultiAppPersist">cartaoMultiAppPersist</param>
        /// <returns>Task of ApiResponse (VinculoCartoesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VinculoCartoesResponse>> CriarCartoesMultiAppUsingPOSTAsyncWithHttpInfo (CartaoMultiAppPersistValue cartaoMultiAppPersist)
        {
            // verify the required parameter 'cartaoMultiAppPersist' is set
            if (cartaoMultiAppPersist == null) throw new ApiException(400, "Missing required parameter 'cartaoMultiAppPersist' when calling CriarCartoesMultiAppUsingPOST");
            
    
            var localVarPath = "/api/cartoes/gerar-cartoes-multiapp";
    
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
            
            
            
            
            if (cartaoMultiAppPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cartaoMultiAppPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cartaoMultiAppPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CriarCartoesMultiAppUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CriarCartoesMultiAppUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VinculoCartoesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VinculoCartoesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VinculoCartoesResponse)));
            
        }
        
        /// <summary>
        /// {{{cartao_resource_desbloquear_senha_incorreta}}} {{{cartao_resource_desbloquear_senha_incorreta_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_desbloquear_senha_incorreta_param_id}}}</param> 
        /// <returns>CartaoResponse</returns>
        public CartaoResponse DesbloquearSenhaIncorretaUsingPOST (long? id)
        {
             ApiResponse<CartaoResponse> localVarResponse = DesbloquearSenhaIncorretaUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_resource_desbloquear_senha_incorreta}}} {{{cartao_resource_desbloquear_senha_incorreta_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_desbloquear_senha_incorreta_param_id}}}</param> 
        /// <returns>ApiResponse of CartaoResponse</returns>
        public ApiResponse< CartaoResponse > DesbloquearSenhaIncorretaUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcartaoApi->DesbloquearSenhaIncorretaUsingPOST");
            
    
            var localVarPath = "/api/cartoes/{id}/desbloquear-senha-incorreta";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearSenhaIncorretaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearSenhaIncorretaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }

        
        /// <summary>
        /// {{{cartao_resource_desbloquear_senha_incorreta}}} {{{cartao_resource_desbloquear_senha_incorreta_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_desbloquear_senha_incorreta_param_id}}}</param>
        /// <returns>Task of CartaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoResponse> DesbloquearSenhaIncorretaUsingPOSTAsync (long? id)
        {
             ApiResponse<CartaoResponse> localVarResponse = await DesbloquearSenhaIncorretaUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_resource_desbloquear_senha_incorreta}}} {{{cartao_resource_desbloquear_senha_incorreta_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_desbloquear_senha_incorreta_param_id}}}</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> DesbloquearSenhaIncorretaUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesbloquearSenhaIncorretaUsingPOST");
            
    
            var localVarPath = "/api/cartoes/{id}/desbloquear-senha-incorreta";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearSenhaIncorretaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearSenhaIncorretaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }
        
        /// <summary>
        /// {{{cartao_resource_desbloquear}}} {{{cartao_resource_desbloquear_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_desbloquear_param_id}}}</param> 
        /// <returns>CartaoResponse</returns>
        public CartaoResponse DesbloquearUsingPOST (long? id)
        {
             ApiResponse<CartaoResponse> localVarResponse = DesbloquearUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_resource_desbloquear}}} {{{cartao_resource_desbloquear_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_desbloquear_param_id}}}</param> 
        /// <returns>ApiResponse of CartaoResponse</returns>
        public ApiResponse< CartaoResponse > DesbloquearUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcartaoApi->DesbloquearUsingPOST");
            
    
            var localVarPath = "/api/cartoes/{id}/desbloquear";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }

        
        /// <summary>
        /// {{{cartao_resource_desbloquear}}} {{{cartao_resource_desbloquear_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_desbloquear_param_id}}}</param>
        /// <returns>Task of CartaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoResponse> DesbloquearUsingPOSTAsync (long? id)
        {
             ApiResponse<CartaoResponse> localVarResponse = await DesbloquearUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_resource_desbloquear}}} {{{cartao_resource_desbloquear_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_desbloquear_param_id}}}</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> DesbloquearUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesbloquearUsingPOST");
            
    
            var localVarPath = "/api/cartoes/{id}/desbloquear";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }
        
        /// <summary>
        /// {{{cartao_resource_gerar_lotes_cartoes_pre_pagos}}} {{{cartao_resource_gerar_lotes_cartoes_pre_pagos_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idOrigemComercial">{{{lote_cartoes_pre_pagos_persist_id_origem_comercial_value}}} (optional)</param> 
        /// <param name="idProduto">{{{lote_cartoes_pre_pagos_persist_id_produto_value}}} (optional)</param> 
        /// <param name="idTipoCartao">{{{lote_cartoes_pre_pagos_persist_id_tipo_cartao_value}}} (optional)</param> 
        /// <param name="idImagem">{{{lote_cartoes_pre_pagos_persist_id_imagem_value}}} (optional)</param> 
        /// <param name="idEndereco">{{{lote_cartoes_pre_pagos_persist_id_endereco_value}}} (optional)</param> 
        /// <param name="quantidadeCartoes">{{{lote_cartoes_pre_pagos_persist_quantidade_cartoes_value}}} (optional)</param> 
        /// <param name="identificadorExterno">{{{lote_cartoes_pre_pagos_persist_identificador_externo_value}}} (optional)</param> 
        /// <returns>LoteCartoesPrePagosResponse</returns>
        public LoteCartoesPrePagosResponse GerarLotesCartoesPrePagosUsingPOST (long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string identificadorExterno = null)
        {
             ApiResponse<LoteCartoesPrePagosResponse> localVarResponse = GerarLotesCartoesPrePagosUsingPOSTWithHttpInfo(idOrigemComercial, idProduto, idTipoCartao, idImagem, idEndereco, quantidadeCartoes, identificadorExterno);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_resource_gerar_lotes_cartoes_pre_pagos}}} {{{cartao_resource_gerar_lotes_cartoes_pre_pagos_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idOrigemComercial">{{{lote_cartoes_pre_pagos_persist_id_origem_comercial_value}}} (optional)</param> 
        /// <param name="idProduto">{{{lote_cartoes_pre_pagos_persist_id_produto_value}}} (optional)</param> 
        /// <param name="idTipoCartao">{{{lote_cartoes_pre_pagos_persist_id_tipo_cartao_value}}} (optional)</param> 
        /// <param name="idImagem">{{{lote_cartoes_pre_pagos_persist_id_imagem_value}}} (optional)</param> 
        /// <param name="idEndereco">{{{lote_cartoes_pre_pagos_persist_id_endereco_value}}} (optional)</param> 
        /// <param name="quantidadeCartoes">{{{lote_cartoes_pre_pagos_persist_quantidade_cartoes_value}}} (optional)</param> 
        /// <param name="identificadorExterno">{{{lote_cartoes_pre_pagos_persist_identificador_externo_value}}} (optional)</param> 
        /// <returns>ApiResponse of LoteCartoesPrePagosResponse</returns>
        public ApiResponse< LoteCartoesPrePagosResponse > GerarLotesCartoesPrePagosUsingPOSTWithHttpInfo (long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string identificadorExterno = null)
        {
            
    
            var localVarPath = "/api/cartoes/lotes-cartoes-pre-pagos";
    
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
            
            if (idOrigemComercial != null) localVarQueryParams.Add("idOrigemComercial", Configuration.ApiClient.ParameterToString(idOrigemComercial)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (idTipoCartao != null) localVarQueryParams.Add("idTipoCartao", Configuration.ApiClient.ParameterToString(idTipoCartao)); // query parameter
            if (idImagem != null) localVarQueryParams.Add("idImagem", Configuration.ApiClient.ParameterToString(idImagem)); // query parameter
            if (idEndereco != null) localVarQueryParams.Add("idEndereco", Configuration.ApiClient.ParameterToString(idEndereco)); // query parameter
            if (quantidadeCartoes != null) localVarQueryParams.Add("quantidadeCartoes", Configuration.ApiClient.ParameterToString(quantidadeCartoes)); // query parameter
            if (identificadorExterno != null) localVarQueryParams.Add("identificadorExterno", Configuration.ApiClient.ParameterToString(identificadorExterno)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarLotesCartoesPrePagosUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarLotesCartoesPrePagosUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LoteCartoesPrePagosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LoteCartoesPrePagosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LoteCartoesPrePagosResponse)));
            
        }

        
        /// <summary>
        /// {{{cartao_resource_gerar_lotes_cartoes_pre_pagos}}} {{{cartao_resource_gerar_lotes_cartoes_pre_pagos_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idOrigemComercial">{{{lote_cartoes_pre_pagos_persist_id_origem_comercial_value}}} (optional)</param>
        /// <param name="idProduto">{{{lote_cartoes_pre_pagos_persist_id_produto_value}}} (optional)</param>
        /// <param name="idTipoCartao">{{{lote_cartoes_pre_pagos_persist_id_tipo_cartao_value}}} (optional)</param>
        /// <param name="idImagem">{{{lote_cartoes_pre_pagos_persist_id_imagem_value}}} (optional)</param>
        /// <param name="idEndereco">{{{lote_cartoes_pre_pagos_persist_id_endereco_value}}} (optional)</param>
        /// <param name="quantidadeCartoes">{{{lote_cartoes_pre_pagos_persist_quantidade_cartoes_value}}} (optional)</param>
        /// <param name="identificadorExterno">{{{lote_cartoes_pre_pagos_persist_identificador_externo_value}}} (optional)</param>
        /// <returns>Task of LoteCartoesPrePagosResponse</returns>
        public async System.Threading.Tasks.Task<LoteCartoesPrePagosResponse> GerarLotesCartoesPrePagosUsingPOSTAsync (long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string identificadorExterno = null)
        {
             ApiResponse<LoteCartoesPrePagosResponse> localVarResponse = await GerarLotesCartoesPrePagosUsingPOSTAsyncWithHttpInfo(idOrigemComercial, idProduto, idTipoCartao, idImagem, idEndereco, quantidadeCartoes, identificadorExterno);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_resource_gerar_lotes_cartoes_pre_pagos}}} {{{cartao_resource_gerar_lotes_cartoes_pre_pagos_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idOrigemComercial">{{{lote_cartoes_pre_pagos_persist_id_origem_comercial_value}}} (optional)</param>
        /// <param name="idProduto">{{{lote_cartoes_pre_pagos_persist_id_produto_value}}} (optional)</param>
        /// <param name="idTipoCartao">{{{lote_cartoes_pre_pagos_persist_id_tipo_cartao_value}}} (optional)</param>
        /// <param name="idImagem">{{{lote_cartoes_pre_pagos_persist_id_imagem_value}}} (optional)</param>
        /// <param name="idEndereco">{{{lote_cartoes_pre_pagos_persist_id_endereco_value}}} (optional)</param>
        /// <param name="quantidadeCartoes">{{{lote_cartoes_pre_pagos_persist_quantidade_cartoes_value}}} (optional)</param>
        /// <param name="identificadorExterno">{{{lote_cartoes_pre_pagos_persist_identificador_externo_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (LoteCartoesPrePagosResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LoteCartoesPrePagosResponse>> GerarLotesCartoesPrePagosUsingPOSTAsyncWithHttpInfo (long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string identificadorExterno = null)
        {
            
    
            var localVarPath = "/api/cartoes/lotes-cartoes-pre-pagos";
    
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
            
            if (idOrigemComercial != null) localVarQueryParams.Add("idOrigemComercial", Configuration.ApiClient.ParameterToString(idOrigemComercial)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (idTipoCartao != null) localVarQueryParams.Add("idTipoCartao", Configuration.ApiClient.ParameterToString(idTipoCartao)); // query parameter
            if (idImagem != null) localVarQueryParams.Add("idImagem", Configuration.ApiClient.ParameterToString(idImagem)); // query parameter
            if (idEndereco != null) localVarQueryParams.Add("idEndereco", Configuration.ApiClient.ParameterToString(idEndereco)); // query parameter
            if (quantidadeCartoes != null) localVarQueryParams.Add("quantidadeCartoes", Configuration.ApiClient.ParameterToString(quantidadeCartoes)); // query parameter
            if (identificadorExterno != null) localVarQueryParams.Add("identificadorExterno", Configuration.ApiClient.ParameterToString(identificadorExterno)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarLotesCartoesPrePagosUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarLotesCartoesPrePagosUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LoteCartoesPrePagosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LoteCartoesPrePagosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LoteCartoesPrePagosResponse)));
            
        }
        
        /// <summary>
        /// {{{cartao_resource_gerar_nova_via_multiplo}}} {{{cartao_resource_gerar_nova_via_multiplo_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_gerar_nova_via_param_id_cartao}}}</param> 
        /// <returns>CartaoMultiAppImpressaoResponse</returns>
        public CartaoMultiAppImpressaoResponse GerarNovaViaCartaoMultiAppUsingPOST (long? id)
        {
             ApiResponse<CartaoMultiAppImpressaoResponse> localVarResponse = GerarNovaViaCartaoMultiAppUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_resource_gerar_nova_via_multiplo}}} {{{cartao_resource_gerar_nova_via_multiplo_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_gerar_nova_via_param_id_cartao}}}</param> 
        /// <returns>ApiResponse of CartaoMultiAppImpressaoResponse</returns>
        public ApiResponse< CartaoMultiAppImpressaoResponse > GerarNovaViaCartaoMultiAppUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcartaoApi->GerarNovaViaCartaoMultiAppUsingPOST");
            
    
            var localVarPath = "/api/cartoes/{id}/gerar-nova-via-multiplo";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GerarNovaViaCartaoMultiAppUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarNovaViaCartaoMultiAppUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoMultiAppImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoMultiAppImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoMultiAppImpressaoResponse)));
            
        }

        
        /// <summary>
        /// {{{cartao_resource_gerar_nova_via_multiplo}}} {{{cartao_resource_gerar_nova_via_multiplo_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_gerar_nova_via_param_id_cartao}}}</param>
        /// <returns>Task of CartaoMultiAppImpressaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoMultiAppImpressaoResponse> GerarNovaViaCartaoMultiAppUsingPOSTAsync (long? id)
        {
             ApiResponse<CartaoMultiAppImpressaoResponse> localVarResponse = await GerarNovaViaCartaoMultiAppUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_resource_gerar_nova_via_multiplo}}} {{{cartao_resource_gerar_nova_via_multiplo_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_gerar_nova_via_param_id_cartao}}}</param>
        /// <returns>Task of ApiResponse (CartaoMultiAppImpressaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoMultiAppImpressaoResponse>> GerarNovaViaCartaoMultiAppUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GerarNovaViaCartaoMultiAppUsingPOST");
            
    
            var localVarPath = "/api/cartoes/{id}/gerar-nova-via-multiplo";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GerarNovaViaCartaoMultiAppUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarNovaViaCartaoMultiAppUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoMultiAppImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoMultiAppImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoMultiAppImpressaoResponse)));
            
        }
        
        /// <summary>
        /// {{{cartao_resource_gerar_nova_via}}} {{{cartao_resource_gerar_nova_via_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_gerar_nova_via_param_id_cartao}}}</param> 
        /// <returns>CartaoResponse</returns>
        public CartaoResponse GerarNovaViaUsingPOST (long? id)
        {
             ApiResponse<CartaoResponse> localVarResponse = GerarNovaViaUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_resource_gerar_nova_via}}} {{{cartao_resource_gerar_nova_via_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_gerar_nova_via_param_id_cartao}}}</param> 
        /// <returns>ApiResponse of CartaoResponse</returns>
        public ApiResponse< CartaoResponse > GerarNovaViaUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcartaoApi->GerarNovaViaUsingPOST");
            
    
            var localVarPath = "/api/cartoes/{id}/gerar-nova-via";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GerarNovaViaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarNovaViaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }

        
        /// <summary>
        /// {{{cartao_resource_gerar_nova_via}}} {{{cartao_resource_gerar_nova_via_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_gerar_nova_via_param_id_cartao}}}</param>
        /// <returns>Task of CartaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoResponse> GerarNovaViaUsingPOSTAsync (long? id)
        {
             ApiResponse<CartaoResponse> localVarResponse = await GerarNovaViaUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_resource_gerar_nova_via}}} {{{cartao_resource_gerar_nova_via_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_gerar_nova_via_param_id_cartao}}}</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> GerarNovaViaUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GerarNovaViaUsingPOST");
            
    
            var localVarPath = "/api/cartoes/{id}/gerar-nova-via";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GerarNovaViaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarNovaViaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }
        
        /// <summary>
        /// {{{cartao_resource_lancar_tarifa_segunda_via}}} {{{cartao_resource_lancar_tarifa_segunda_via_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_lancar_tarifa_segunda_via_param_id}}}</param> 
        /// <returns>Object</returns>
        public Object LancarTarifaSegundaViaUsingPOST (long? id)
        {
             ApiResponse<Object> localVarResponse = LancarTarifaSegundaViaUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_resource_lancar_tarifa_segunda_via}}} {{{cartao_resource_lancar_tarifa_segunda_via_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_lancar_tarifa_segunda_via_param_id}}}</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > LancarTarifaSegundaViaUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcartaoApi->LancarTarifaSegundaViaUsingPOST");
            
    
            var localVarPath = "/api/cartoes/{id}/lancar-tarifa-reemissao";
    
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
                throw new ApiException (localVarStatusCode, "Error calling LancarTarifaSegundaViaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling LancarTarifaSegundaViaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// {{{cartao_resource_lancar_tarifa_segunda_via}}} {{{cartao_resource_lancar_tarifa_segunda_via_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_lancar_tarifa_segunda_via_param_id}}}</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> LancarTarifaSegundaViaUsingPOSTAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await LancarTarifaSegundaViaUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_resource_lancar_tarifa_segunda_via}}} {{{cartao_resource_lancar_tarifa_segunda_via_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_lancar_tarifa_segunda_via_param_id}}}</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> LancarTarifaSegundaViaUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling LancarTarifaSegundaViaUsingPOST");
            
    
            var localVarPath = "/api/cartoes/{id}/lancar-tarifa-reemissao";
    
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
                throw new ApiException (localVarStatusCode, "Error calling LancarTarifaSegundaViaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling LancarTarifaSegundaViaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// {{{cartao_resource_listar_lotes_cartoes_pre_pagos}}} {{{cartao_resource_listar_lotes_cartoes_pre_pagos_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idOrigemComercial">{{{lote_cartoes_pre_pagos_request_id_origem_comercial_value}}} (optional)</param> 
        /// <param name="idProduto">{{{lote_cartoes_pre_pagos_request_id_produto_value}}} (optional)</param> 
        /// <param name="idTipoCartao">{{{lote_cartoes_pre_pagos_request_id_tipo_cartao_value}}} (optional)</param> 
        /// <param name="idImagem">{{{lote_cartoes_pre_pagos_request_id_imagem_value}}} (optional)</param> 
        /// <param name="idEndereco">{{{lote_cartoes_pre_pagos_request_id_endereco_value}}} (optional)</param> 
        /// <param name="quantidadeCartoes">{{{lote_cartoes_pre_pagos_request_quantidade_cartoes_value}}} (optional)</param> 
        /// <param name="dataCadastro">{{{lote_cartoes_pre_pagos_request_data_cadastro_value}}} (optional)</param> 
        /// <param name="usuarioCadastro">{{{lote_cartoes_pre_pagos_request_usuario_cadastro_value}}} (optional)</param> 
        /// <param name="statusProcessamento">{{{lote_cartoes_pre_pagos_request_status_processamento_value}}} (optional)</param> 
        /// <param name="identificadorExterno">{{{lote_cartoes_pre_pagos_request_identificador_externo_value}}} (optional)</param> 
        /// <returns>PageLoteCartoesPrePagosResponse</returns>
        public PageLoteCartoesPrePagosResponse ListarLotesCartoesPrePagosUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string dataCadastro = null, string usuarioCadastro = null, int? statusProcessamento = null, string identificadorExterno = null)
        {
             ApiResponse<PageLoteCartoesPrePagosResponse> localVarResponse = ListarLotesCartoesPrePagosUsingGETWithHttpInfo(sort, page, limit, idOrigemComercial, idProduto, idTipoCartao, idImagem, idEndereco, quantidadeCartoes, dataCadastro, usuarioCadastro, statusProcessamento, identificadorExterno);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_resource_listar_lotes_cartoes_pre_pagos}}} {{{cartao_resource_listar_lotes_cartoes_pre_pagos_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idOrigemComercial">{{{lote_cartoes_pre_pagos_request_id_origem_comercial_value}}} (optional)</param> 
        /// <param name="idProduto">{{{lote_cartoes_pre_pagos_request_id_produto_value}}} (optional)</param> 
        /// <param name="idTipoCartao">{{{lote_cartoes_pre_pagos_request_id_tipo_cartao_value}}} (optional)</param> 
        /// <param name="idImagem">{{{lote_cartoes_pre_pagos_request_id_imagem_value}}} (optional)</param> 
        /// <param name="idEndereco">{{{lote_cartoes_pre_pagos_request_id_endereco_value}}} (optional)</param> 
        /// <param name="quantidadeCartoes">{{{lote_cartoes_pre_pagos_request_quantidade_cartoes_value}}} (optional)</param> 
        /// <param name="dataCadastro">{{{lote_cartoes_pre_pagos_request_data_cadastro_value}}} (optional)</param> 
        /// <param name="usuarioCadastro">{{{lote_cartoes_pre_pagos_request_usuario_cadastro_value}}} (optional)</param> 
        /// <param name="statusProcessamento">{{{lote_cartoes_pre_pagos_request_status_processamento_value}}} (optional)</param> 
        /// <param name="identificadorExterno">{{{lote_cartoes_pre_pagos_request_identificador_externo_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageLoteCartoesPrePagosResponse</returns>
        public ApiResponse< PageLoteCartoesPrePagosResponse > ListarLotesCartoesPrePagosUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string dataCadastro = null, string usuarioCadastro = null, int? statusProcessamento = null, string identificadorExterno = null)
        {
            
    
            var localVarPath = "/api/cartoes/lotes-cartoes-pre-pagos";
    
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
            if (idOrigemComercial != null) localVarQueryParams.Add("idOrigemComercial", Configuration.ApiClient.ParameterToString(idOrigemComercial)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (idTipoCartao != null) localVarQueryParams.Add("idTipoCartao", Configuration.ApiClient.ParameterToString(idTipoCartao)); // query parameter
            if (idImagem != null) localVarQueryParams.Add("idImagem", Configuration.ApiClient.ParameterToString(idImagem)); // query parameter
            if (idEndereco != null) localVarQueryParams.Add("idEndereco", Configuration.ApiClient.ParameterToString(idEndereco)); // query parameter
            if (quantidadeCartoes != null) localVarQueryParams.Add("quantidadeCartoes", Configuration.ApiClient.ParameterToString(quantidadeCartoes)); // query parameter
            if (dataCadastro != null) localVarQueryParams.Add("dataCadastro", Configuration.ApiClient.ParameterToString(dataCadastro)); // query parameter
            if (usuarioCadastro != null) localVarQueryParams.Add("usuarioCadastro", Configuration.ApiClient.ParameterToString(usuarioCadastro)); // query parameter
            if (statusProcessamento != null) localVarQueryParams.Add("statusProcessamento", Configuration.ApiClient.ParameterToString(statusProcessamento)); // query parameter
            if (identificadorExterno != null) localVarQueryParams.Add("identificadorExterno", Configuration.ApiClient.ParameterToString(identificadorExterno)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarLotesCartoesPrePagosUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarLotesCartoesPrePagosUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageLoteCartoesPrePagosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageLoteCartoesPrePagosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageLoteCartoesPrePagosResponse)));
            
        }

        
        /// <summary>
        /// {{{cartao_resource_listar_lotes_cartoes_pre_pagos}}} {{{cartao_resource_listar_lotes_cartoes_pre_pagos_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idOrigemComercial">{{{lote_cartoes_pre_pagos_request_id_origem_comercial_value}}} (optional)</param>
        /// <param name="idProduto">{{{lote_cartoes_pre_pagos_request_id_produto_value}}} (optional)</param>
        /// <param name="idTipoCartao">{{{lote_cartoes_pre_pagos_request_id_tipo_cartao_value}}} (optional)</param>
        /// <param name="idImagem">{{{lote_cartoes_pre_pagos_request_id_imagem_value}}} (optional)</param>
        /// <param name="idEndereco">{{{lote_cartoes_pre_pagos_request_id_endereco_value}}} (optional)</param>
        /// <param name="quantidadeCartoes">{{{lote_cartoes_pre_pagos_request_quantidade_cartoes_value}}} (optional)</param>
        /// <param name="dataCadastro">{{{lote_cartoes_pre_pagos_request_data_cadastro_value}}} (optional)</param>
        /// <param name="usuarioCadastro">{{{lote_cartoes_pre_pagos_request_usuario_cadastro_value}}} (optional)</param>
        /// <param name="statusProcessamento">{{{lote_cartoes_pre_pagos_request_status_processamento_value}}} (optional)</param>
        /// <param name="identificadorExterno">{{{lote_cartoes_pre_pagos_request_identificador_externo_value}}} (optional)</param>
        /// <returns>Task of PageLoteCartoesPrePagosResponse</returns>
        public async System.Threading.Tasks.Task<PageLoteCartoesPrePagosResponse> ListarLotesCartoesPrePagosUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string dataCadastro = null, string usuarioCadastro = null, int? statusProcessamento = null, string identificadorExterno = null)
        {
             ApiResponse<PageLoteCartoesPrePagosResponse> localVarResponse = await ListarLotesCartoesPrePagosUsingGETAsyncWithHttpInfo(sort, page, limit, idOrigemComercial, idProduto, idTipoCartao, idImagem, idEndereco, quantidadeCartoes, dataCadastro, usuarioCadastro, statusProcessamento, identificadorExterno);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_resource_listar_lotes_cartoes_pre_pagos}}} {{{cartao_resource_listar_lotes_cartoes_pre_pagos_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idOrigemComercial">{{{lote_cartoes_pre_pagos_request_id_origem_comercial_value}}} (optional)</param>
        /// <param name="idProduto">{{{lote_cartoes_pre_pagos_request_id_produto_value}}} (optional)</param>
        /// <param name="idTipoCartao">{{{lote_cartoes_pre_pagos_request_id_tipo_cartao_value}}} (optional)</param>
        /// <param name="idImagem">{{{lote_cartoes_pre_pagos_request_id_imagem_value}}} (optional)</param>
        /// <param name="idEndereco">{{{lote_cartoes_pre_pagos_request_id_endereco_value}}} (optional)</param>
        /// <param name="quantidadeCartoes">{{{lote_cartoes_pre_pagos_request_quantidade_cartoes_value}}} (optional)</param>
        /// <param name="dataCadastro">{{{lote_cartoes_pre_pagos_request_data_cadastro_value}}} (optional)</param>
        /// <param name="usuarioCadastro">{{{lote_cartoes_pre_pagos_request_usuario_cadastro_value}}} (optional)</param>
        /// <param name="statusProcessamento">{{{lote_cartoes_pre_pagos_request_status_processamento_value}}} (optional)</param>
        /// <param name="identificadorExterno">{{{lote_cartoes_pre_pagos_request_identificador_externo_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageLoteCartoesPrePagosResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageLoteCartoesPrePagosResponse>> ListarLotesCartoesPrePagosUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string dataCadastro = null, string usuarioCadastro = null, int? statusProcessamento = null, string identificadorExterno = null)
        {
            
    
            var localVarPath = "/api/cartoes/lotes-cartoes-pre-pagos";
    
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
            if (idOrigemComercial != null) localVarQueryParams.Add("idOrigemComercial", Configuration.ApiClient.ParameterToString(idOrigemComercial)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (idTipoCartao != null) localVarQueryParams.Add("idTipoCartao", Configuration.ApiClient.ParameterToString(idTipoCartao)); // query parameter
            if (idImagem != null) localVarQueryParams.Add("idImagem", Configuration.ApiClient.ParameterToString(idImagem)); // query parameter
            if (idEndereco != null) localVarQueryParams.Add("idEndereco", Configuration.ApiClient.ParameterToString(idEndereco)); // query parameter
            if (quantidadeCartoes != null) localVarQueryParams.Add("quantidadeCartoes", Configuration.ApiClient.ParameterToString(quantidadeCartoes)); // query parameter
            if (dataCadastro != null) localVarQueryParams.Add("dataCadastro", Configuration.ApiClient.ParameterToString(dataCadastro)); // query parameter
            if (usuarioCadastro != null) localVarQueryParams.Add("usuarioCadastro", Configuration.ApiClient.ParameterToString(usuarioCadastro)); // query parameter
            if (statusProcessamento != null) localVarQueryParams.Add("statusProcessamento", Configuration.ApiClient.ParameterToString(statusProcessamento)); // query parameter
            if (identificadorExterno != null) localVarQueryParams.Add("identificadorExterno", Configuration.ApiClient.ParameterToString(identificadorExterno)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarLotesCartoesPrePagosUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarLotesCartoesPrePagosUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageLoteCartoesPrePagosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageLoteCartoesPrePagosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageLoteCartoesPrePagosResponse)));
            
        }
        
        /// <summary>
        /// {{{cartao_resource_listar}}} {{{cartao_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idStatusCartao">{{{cartao_request_id_status_cartao_value}}} (optional)</param> 
        /// <param name="idEstagioCartao">{{{cartao_request_id_estagio_cartao_value}}} (optional)</param> 
        /// <param name="idConta">{{{cartao_request_id_conta_value}}} (optional)</param> 
        /// <param name="idPessoa">{{{cartao_request_id_pessoa_value}}} (optional)</param> 
        /// <param name="idProduto">{{{cartao_request_id_produto_value}}} (optional)</param> 
        /// <param name="tipoPortador">{{{cartao_request_tipo_portador_value}}} (optional)</param> 
        /// <param name="numeroCartao">{{{cartao_request_numero_cartao_value}}} (optional)</param> 
        /// <param name="nomeImpresso">{{{cartao_request_nome_impresso_value}}} (optional)</param> 
        /// <param name="dataGeracao">{{{cartao_request_data_geracao_value}}} (optional)</param> 
        /// <param name="dataStatusCartao">{{{cartao_request_data_status_cartao_value}}} (optional)</param> 
        /// <param name="dataEstagioCartao">{{{cartao_request_data_estagio_cartao_value}}} (optional)</param> 
        /// <param name="dataValidade">{{{cartao_request_data_validade_value}}} (optional)</param> 
        /// <param name="dataImpressao">{{{cartao_request_data_impressao_value}}} (optional)</param> 
        /// <param name="arquivoImpressao">{{{cartao_request_arquivo_impressao_value}}} (optional)</param> 
        /// <param name="flagImpressaoOrigemComercial">{{{cartao_request_flag_impressao_origem_comercial_value}}} (optional)</param> 
        /// <param name="flagProvisorio">{{{cartao_request_flag_provisorio_value}}} (optional)</param> 
        /// <param name="codigoDesbloqueio">{{{cartao_request_codigo_desbloqueio_value}}} (optional)</param> 
        /// <param name="sequencialCartao">{{{cartao_request_sequencial_cartao_value}}} (optional)</param> 
        /// <param name="identificadorExterno">{{{cartao_request_identificador_externo_value}}} (optional)</param> 
        /// <returns>PageCartaoResponse</returns>
        public PageCartaoResponse ListarUsingGET12 (List<string> sort = null, int? page = null, int? limit = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? sequencialCartao = null, long? identificadorExterno = null)
        {
             ApiResponse<PageCartaoResponse> localVarResponse = ListarUsingGET12WithHttpInfo(sort, page, limit, idStatusCartao, idEstagioCartao, idConta, idPessoa, idProduto, tipoPortador, numeroCartao, nomeImpresso, dataGeracao, dataStatusCartao, dataEstagioCartao, dataValidade, dataImpressao, arquivoImpressao, flagImpressaoOrigemComercial, flagProvisorio, codigoDesbloqueio, sequencialCartao, identificadorExterno);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_resource_listar}}} {{{cartao_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idStatusCartao">{{{cartao_request_id_status_cartao_value}}} (optional)</param> 
        /// <param name="idEstagioCartao">{{{cartao_request_id_estagio_cartao_value}}} (optional)</param> 
        /// <param name="idConta">{{{cartao_request_id_conta_value}}} (optional)</param> 
        /// <param name="idPessoa">{{{cartao_request_id_pessoa_value}}} (optional)</param> 
        /// <param name="idProduto">{{{cartao_request_id_produto_value}}} (optional)</param> 
        /// <param name="tipoPortador">{{{cartao_request_tipo_portador_value}}} (optional)</param> 
        /// <param name="numeroCartao">{{{cartao_request_numero_cartao_value}}} (optional)</param> 
        /// <param name="nomeImpresso">{{{cartao_request_nome_impresso_value}}} (optional)</param> 
        /// <param name="dataGeracao">{{{cartao_request_data_geracao_value}}} (optional)</param> 
        /// <param name="dataStatusCartao">{{{cartao_request_data_status_cartao_value}}} (optional)</param> 
        /// <param name="dataEstagioCartao">{{{cartao_request_data_estagio_cartao_value}}} (optional)</param> 
        /// <param name="dataValidade">{{{cartao_request_data_validade_value}}} (optional)</param> 
        /// <param name="dataImpressao">{{{cartao_request_data_impressao_value}}} (optional)</param> 
        /// <param name="arquivoImpressao">{{{cartao_request_arquivo_impressao_value}}} (optional)</param> 
        /// <param name="flagImpressaoOrigemComercial">{{{cartao_request_flag_impressao_origem_comercial_value}}} (optional)</param> 
        /// <param name="flagProvisorio">{{{cartao_request_flag_provisorio_value}}} (optional)</param> 
        /// <param name="codigoDesbloqueio">{{{cartao_request_codigo_desbloqueio_value}}} (optional)</param> 
        /// <param name="sequencialCartao">{{{cartao_request_sequencial_cartao_value}}} (optional)</param> 
        /// <param name="identificadorExterno">{{{cartao_request_identificador_externo_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageCartaoResponse</returns>
        public ApiResponse< PageCartaoResponse > ListarUsingGET12WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? sequencialCartao = null, long? identificadorExterno = null)
        {
            
    
            var localVarPath = "/api/cartoes";
    
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
            if (idStatusCartao != null) localVarQueryParams.Add("idStatusCartao", Configuration.ApiClient.ParameterToString(idStatusCartao)); // query parameter
            if (idEstagioCartao != null) localVarQueryParams.Add("idEstagioCartao", Configuration.ApiClient.ParameterToString(idEstagioCartao)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (tipoPortador != null) localVarQueryParams.Add("tipoPortador", Configuration.ApiClient.ParameterToString(tipoPortador)); // query parameter
            if (numeroCartao != null) localVarQueryParams.Add("numeroCartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            if (nomeImpresso != null) localVarQueryParams.Add("nomeImpresso", Configuration.ApiClient.ParameterToString(nomeImpresso)); // query parameter
            if (dataGeracao != null) localVarQueryParams.Add("dataGeracao", Configuration.ApiClient.ParameterToString(dataGeracao)); // query parameter
            if (dataStatusCartao != null) localVarQueryParams.Add("dataStatusCartao", Configuration.ApiClient.ParameterToString(dataStatusCartao)); // query parameter
            if (dataEstagioCartao != null) localVarQueryParams.Add("dataEstagioCartao", Configuration.ApiClient.ParameterToString(dataEstagioCartao)); // query parameter
            if (dataValidade != null) localVarQueryParams.Add("dataValidade", Configuration.ApiClient.ParameterToString(dataValidade)); // query parameter
            if (dataImpressao != null) localVarQueryParams.Add("dataImpressao", Configuration.ApiClient.ParameterToString(dataImpressao)); // query parameter
            if (arquivoImpressao != null) localVarQueryParams.Add("arquivoImpressao", Configuration.ApiClient.ParameterToString(arquivoImpressao)); // query parameter
            if (flagImpressaoOrigemComercial != null) localVarQueryParams.Add("flagImpressaoOrigemComercial", Configuration.ApiClient.ParameterToString(flagImpressaoOrigemComercial)); // query parameter
            if (flagProvisorio != null) localVarQueryParams.Add("flagProvisorio", Configuration.ApiClient.ParameterToString(flagProvisorio)); // query parameter
            if (codigoDesbloqueio != null) localVarQueryParams.Add("codigoDesbloqueio", Configuration.ApiClient.ParameterToString(codigoDesbloqueio)); // query parameter
            if (sequencialCartao != null) localVarQueryParams.Add("sequencialCartao", Configuration.ApiClient.ParameterToString(sequencialCartao)); // query parameter
            if (identificadorExterno != null) localVarQueryParams.Add("identificadorExterno", Configuration.ApiClient.ParameterToString(identificadorExterno)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET12: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET12: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCartaoResponse)));
            
        }

        
        /// <summary>
        /// {{{cartao_resource_listar}}} {{{cartao_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idStatusCartao">{{{cartao_request_id_status_cartao_value}}} (optional)</param>
        /// <param name="idEstagioCartao">{{{cartao_request_id_estagio_cartao_value}}} (optional)</param>
        /// <param name="idConta">{{{cartao_request_id_conta_value}}} (optional)</param>
        /// <param name="idPessoa">{{{cartao_request_id_pessoa_value}}} (optional)</param>
        /// <param name="idProduto">{{{cartao_request_id_produto_value}}} (optional)</param>
        /// <param name="tipoPortador">{{{cartao_request_tipo_portador_value}}} (optional)</param>
        /// <param name="numeroCartao">{{{cartao_request_numero_cartao_value}}} (optional)</param>
        /// <param name="nomeImpresso">{{{cartao_request_nome_impresso_value}}} (optional)</param>
        /// <param name="dataGeracao">{{{cartao_request_data_geracao_value}}} (optional)</param>
        /// <param name="dataStatusCartao">{{{cartao_request_data_status_cartao_value}}} (optional)</param>
        /// <param name="dataEstagioCartao">{{{cartao_request_data_estagio_cartao_value}}} (optional)</param>
        /// <param name="dataValidade">{{{cartao_request_data_validade_value}}} (optional)</param>
        /// <param name="dataImpressao">{{{cartao_request_data_impressao_value}}} (optional)</param>
        /// <param name="arquivoImpressao">{{{cartao_request_arquivo_impressao_value}}} (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">{{{cartao_request_flag_impressao_origem_comercial_value}}} (optional)</param>
        /// <param name="flagProvisorio">{{{cartao_request_flag_provisorio_value}}} (optional)</param>
        /// <param name="codigoDesbloqueio">{{{cartao_request_codigo_desbloqueio_value}}} (optional)</param>
        /// <param name="sequencialCartao">{{{cartao_request_sequencial_cartao_value}}} (optional)</param>
        /// <param name="identificadorExterno">{{{cartao_request_identificador_externo_value}}} (optional)</param>
        /// <returns>Task of PageCartaoResponse</returns>
        public async System.Threading.Tasks.Task<PageCartaoResponse> ListarUsingGET12Async (List<string> sort = null, int? page = null, int? limit = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? sequencialCartao = null, long? identificadorExterno = null)
        {
             ApiResponse<PageCartaoResponse> localVarResponse = await ListarUsingGET12AsyncWithHttpInfo(sort, page, limit, idStatusCartao, idEstagioCartao, idConta, idPessoa, idProduto, tipoPortador, numeroCartao, nomeImpresso, dataGeracao, dataStatusCartao, dataEstagioCartao, dataValidade, dataImpressao, arquivoImpressao, flagImpressaoOrigemComercial, flagProvisorio, codigoDesbloqueio, sequencialCartao, identificadorExterno);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_resource_listar}}} {{{cartao_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idStatusCartao">{{{cartao_request_id_status_cartao_value}}} (optional)</param>
        /// <param name="idEstagioCartao">{{{cartao_request_id_estagio_cartao_value}}} (optional)</param>
        /// <param name="idConta">{{{cartao_request_id_conta_value}}} (optional)</param>
        /// <param name="idPessoa">{{{cartao_request_id_pessoa_value}}} (optional)</param>
        /// <param name="idProduto">{{{cartao_request_id_produto_value}}} (optional)</param>
        /// <param name="tipoPortador">{{{cartao_request_tipo_portador_value}}} (optional)</param>
        /// <param name="numeroCartao">{{{cartao_request_numero_cartao_value}}} (optional)</param>
        /// <param name="nomeImpresso">{{{cartao_request_nome_impresso_value}}} (optional)</param>
        /// <param name="dataGeracao">{{{cartao_request_data_geracao_value}}} (optional)</param>
        /// <param name="dataStatusCartao">{{{cartao_request_data_status_cartao_value}}} (optional)</param>
        /// <param name="dataEstagioCartao">{{{cartao_request_data_estagio_cartao_value}}} (optional)</param>
        /// <param name="dataValidade">{{{cartao_request_data_validade_value}}} (optional)</param>
        /// <param name="dataImpressao">{{{cartao_request_data_impressao_value}}} (optional)</param>
        /// <param name="arquivoImpressao">{{{cartao_request_arquivo_impressao_value}}} (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">{{{cartao_request_flag_impressao_origem_comercial_value}}} (optional)</param>
        /// <param name="flagProvisorio">{{{cartao_request_flag_provisorio_value}}} (optional)</param>
        /// <param name="codigoDesbloqueio">{{{cartao_request_codigo_desbloqueio_value}}} (optional)</param>
        /// <param name="sequencialCartao">{{{cartao_request_sequencial_cartao_value}}} (optional)</param>
        /// <param name="identificadorExterno">{{{cartao_request_identificador_externo_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCartaoResponse>> ListarUsingGET12AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? sequencialCartao = null, long? identificadorExterno = null)
        {
            
    
            var localVarPath = "/api/cartoes";
    
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
            if (idStatusCartao != null) localVarQueryParams.Add("idStatusCartao", Configuration.ApiClient.ParameterToString(idStatusCartao)); // query parameter
            if (idEstagioCartao != null) localVarQueryParams.Add("idEstagioCartao", Configuration.ApiClient.ParameterToString(idEstagioCartao)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (tipoPortador != null) localVarQueryParams.Add("tipoPortador", Configuration.ApiClient.ParameterToString(tipoPortador)); // query parameter
            if (numeroCartao != null) localVarQueryParams.Add("numeroCartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            if (nomeImpresso != null) localVarQueryParams.Add("nomeImpresso", Configuration.ApiClient.ParameterToString(nomeImpresso)); // query parameter
            if (dataGeracao != null) localVarQueryParams.Add("dataGeracao", Configuration.ApiClient.ParameterToString(dataGeracao)); // query parameter
            if (dataStatusCartao != null) localVarQueryParams.Add("dataStatusCartao", Configuration.ApiClient.ParameterToString(dataStatusCartao)); // query parameter
            if (dataEstagioCartao != null) localVarQueryParams.Add("dataEstagioCartao", Configuration.ApiClient.ParameterToString(dataEstagioCartao)); // query parameter
            if (dataValidade != null) localVarQueryParams.Add("dataValidade", Configuration.ApiClient.ParameterToString(dataValidade)); // query parameter
            if (dataImpressao != null) localVarQueryParams.Add("dataImpressao", Configuration.ApiClient.ParameterToString(dataImpressao)); // query parameter
            if (arquivoImpressao != null) localVarQueryParams.Add("arquivoImpressao", Configuration.ApiClient.ParameterToString(arquivoImpressao)); // query parameter
            if (flagImpressaoOrigemComercial != null) localVarQueryParams.Add("flagImpressaoOrigemComercial", Configuration.ApiClient.ParameterToString(flagImpressaoOrigemComercial)); // query parameter
            if (flagProvisorio != null) localVarQueryParams.Add("flagProvisorio", Configuration.ApiClient.ParameterToString(flagProvisorio)); // query parameter
            if (codigoDesbloqueio != null) localVarQueryParams.Add("codigoDesbloqueio", Configuration.ApiClient.ParameterToString(codigoDesbloqueio)); // query parameter
            if (sequencialCartao != null) localVarQueryParams.Add("sequencialCartao", Configuration.ApiClient.ParameterToString(sequencialCartao)); // query parameter
            if (identificadorExterno != null) localVarQueryParams.Add("identificadorExterno", Configuration.ApiClient.ParameterToString(identificadorExterno)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET12: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET12: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCartaoResponse)));
            
        }
        
        /// <summary>
        /// {{{cartao_resource_reativar}}} {{{cartao_resource_reativar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_reativar_param_id}}}</param> 
        /// <returns>CartaoResponse</returns>
        public CartaoResponse ReativarUsingPOST (long? id)
        {
             ApiResponse<CartaoResponse> localVarResponse = ReativarUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_resource_reativar}}} {{{cartao_resource_reativar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_reativar_param_id}}}</param> 
        /// <returns>ApiResponse of CartaoResponse</returns>
        public ApiResponse< CartaoResponse > ReativarUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcartaoApi->ReativarUsingPOST");
            
    
            var localVarPath = "/api/cartoes/{id}/reativar";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ReativarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ReativarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }

        
        /// <summary>
        /// {{{cartao_resource_reativar}}} {{{cartao_resource_reativar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_reativar_param_id}}}</param>
        /// <returns>Task of CartaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoResponse> ReativarUsingPOSTAsync (long? id)
        {
             ApiResponse<CartaoResponse> localVarResponse = await ReativarUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_resource_reativar}}} {{{cartao_resource_reativar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_reativar_param_id}}}</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> ReativarUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReativarUsingPOST");
            
    
            var localVarPath = "/api/cartoes/{id}/reativar";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ReativarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ReativarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }
        
        /// <summary>
        /// {{{cartao_resource_validar_c_v_v}}} {{{cartao_resource_validar_c_v_v_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_validar_c_v_v_param_id}}}</param> 
        /// <param name="validaCVV">validaCVV</param> 
        /// <returns>string</returns>
        public string ValidarCVVUsingPOST (long? id, ValidaCVVRequest validaCVV)
        {
             ApiResponse<string> localVarResponse = ValidarCVVUsingPOSTWithHttpInfo(id, validaCVV);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_resource_validar_c_v_v}}} {{{cartao_resource_validar_c_v_v_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_validar_c_v_v_param_id}}}</param> 
        /// <param name="validaCVV">validaCVV</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ValidarCVVUsingPOSTWithHttpInfo (long? id, ValidaCVVRequest validaCVV)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcartaoApi->ValidarCVVUsingPOST");
            
            // verify the required parameter 'validaCVV' is set
            if (validaCVV == null)
                throw new ApiException(400, "Missing required parameter 'validaCVV' when calling GlobaltagcartaoApi->ValidarCVVUsingPOST");
            
    
            var localVarPath = "/api/cartoes/{id}/validar-cvv";
    
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
            
            
            
            
            if (validaCVV.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(validaCVV); // http body (model) parameter
            }
            else
            {
                localVarPostBody = validaCVV; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarCVVUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarCVVUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// {{{cartao_resource_validar_c_v_v}}} {{{cartao_resource_validar_c_v_v_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_validar_c_v_v_param_id}}}</param>
        /// <param name="validaCVV">validaCVV</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ValidarCVVUsingPOSTAsync (long? id, ValidaCVVRequest validaCVV)
        {
             ApiResponse<string> localVarResponse = await ValidarCVVUsingPOSTAsyncWithHttpInfo(id, validaCVV);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_resource_validar_c_v_v}}} {{{cartao_resource_validar_c_v_v_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_validar_c_v_v_param_id}}}</param>
        /// <param name="validaCVV">validaCVV</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ValidarCVVUsingPOSTAsyncWithHttpInfo (long? id, ValidaCVVRequest validaCVV)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ValidarCVVUsingPOST");
            // verify the required parameter 'validaCVV' is set
            if (validaCVV == null) throw new ApiException(400, "Missing required parameter 'validaCVV' when calling ValidarCVVUsingPOST");
            
    
            var localVarPath = "/api/cartoes/{id}/validar-cvv";
    
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
            
            
            
            
            if (validaCVV.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(validaCVV); // http body (model) parameter
            }
            else
            {
                localVarPostBody = validaCVV; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarCVVUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarCVVUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// {{{cartao_resource_validar_dados_impressos_bandeirado}}} {{{cartao_resource_validar_dados_impressos_bandeirado_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">{{{cartao_resource_validar_dados_impressos_bandeirado_param_numero_cartao}}}</param> 
        /// <param name="nomePortador">{{{cartao_resource_validar_dados_impressos_bandeirado_param_nome_portador}}}</param> 
        /// <param name="dataValidade">{{{cartao_resource_validar_dados_impressos_bandeirado_param_data_validade}}}</param> 
        /// <param name="codigoSeguranca">{{{cartao_resource_validar_dados_impressos_bandeirado_param_codigo_seguranca}}}</param> 
        /// <returns>ValidaCartaoResponse</returns>
        public ValidaCartaoResponse ValidarDadosImpressosBandeiradoUsingGET (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
             ApiResponse<ValidaCartaoResponse> localVarResponse = ValidarDadosImpressosBandeiradoUsingGETWithHttpInfo(numeroCartao, nomePortador, dataValidade, codigoSeguranca);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_resource_validar_dados_impressos_bandeirado}}} {{{cartao_resource_validar_dados_impressos_bandeirado_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">{{{cartao_resource_validar_dados_impressos_bandeirado_param_numero_cartao}}}</param> 
        /// <param name="nomePortador">{{{cartao_resource_validar_dados_impressos_bandeirado_param_nome_portador}}}</param> 
        /// <param name="dataValidade">{{{cartao_resource_validar_dados_impressos_bandeirado_param_data_validade}}}</param> 
        /// <param name="codigoSeguranca">{{{cartao_resource_validar_dados_impressos_bandeirado_param_codigo_seguranca}}}</param> 
        /// <returns>ApiResponse of ValidaCartaoResponse</returns>
        public ApiResponse< ValidaCartaoResponse > ValidarDadosImpressosBandeiradoUsingGETWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
            
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null)
                throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling GlobaltagcartaoApi->ValidarDadosImpressosBandeiradoUsingGET");
            
            // verify the required parameter 'nomePortador' is set
            if (nomePortador == null)
                throw new ApiException(400, "Missing required parameter 'nomePortador' when calling GlobaltagcartaoApi->ValidarDadosImpressosBandeiradoUsingGET");
            
            // verify the required parameter 'dataValidade' is set
            if (dataValidade == null)
                throw new ApiException(400, "Missing required parameter 'dataValidade' when calling GlobaltagcartaoApi->ValidarDadosImpressosBandeiradoUsingGET");
            
            // verify the required parameter 'codigoSeguranca' is set
            if (codigoSeguranca == null)
                throw new ApiException(400, "Missing required parameter 'codigoSeguranca' when calling GlobaltagcartaoApi->ValidarDadosImpressosBandeiradoUsingGET");
            
    
            var localVarPath = "/api/cartoes/validar-dados-impressos-bandeirados";
    
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
            
            if (numeroCartao != null) localVarQueryParams.Add("numero_cartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            if (nomePortador != null) localVarQueryParams.Add("nome_portador", Configuration.ApiClient.ParameterToString(nomePortador)); // query parameter
            if (dataValidade != null) localVarQueryParams.Add("data_validade", Configuration.ApiClient.ParameterToString(dataValidade)); // query parameter
            if (codigoSeguranca != null) localVarQueryParams.Add("codigo_seguranca", Configuration.ApiClient.ParameterToString(codigoSeguranca)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosImpressosBandeiradoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosImpressosBandeiradoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ValidaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartaoResponse)));
            
        }

        
        /// <summary>
        /// {{{cartao_resource_validar_dados_impressos_bandeirado}}} {{{cartao_resource_validar_dados_impressos_bandeirado_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">{{{cartao_resource_validar_dados_impressos_bandeirado_param_numero_cartao}}}</param>
        /// <param name="nomePortador">{{{cartao_resource_validar_dados_impressos_bandeirado_param_nome_portador}}}</param>
        /// <param name="dataValidade">{{{cartao_resource_validar_dados_impressos_bandeirado_param_data_validade}}}</param>
        /// <param name="codigoSeguranca">{{{cartao_resource_validar_dados_impressos_bandeirado_param_codigo_seguranca}}}</param>
        /// <returns>Task of ValidaCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ValidaCartaoResponse> ValidarDadosImpressosBandeiradoUsingGETAsync (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
             ApiResponse<ValidaCartaoResponse> localVarResponse = await ValidarDadosImpressosBandeiradoUsingGETAsyncWithHttpInfo(numeroCartao, nomePortador, dataValidade, codigoSeguranca);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_resource_validar_dados_impressos_bandeirado}}} {{{cartao_resource_validar_dados_impressos_bandeirado_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">{{{cartao_resource_validar_dados_impressos_bandeirado_param_numero_cartao}}}</param>
        /// <param name="nomePortador">{{{cartao_resource_validar_dados_impressos_bandeirado_param_nome_portador}}}</param>
        /// <param name="dataValidade">{{{cartao_resource_validar_dados_impressos_bandeirado_param_data_validade}}}</param>
        /// <param name="codigoSeguranca">{{{cartao_resource_validar_dados_impressos_bandeirado_param_codigo_seguranca}}}</param>
        /// <returns>Task of ApiResponse (ValidaCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ValidaCartaoResponse>> ValidarDadosImpressosBandeiradoUsingGETAsyncWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null) throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling ValidarDadosImpressosBandeiradoUsingGET");
            // verify the required parameter 'nomePortador' is set
            if (nomePortador == null) throw new ApiException(400, "Missing required parameter 'nomePortador' when calling ValidarDadosImpressosBandeiradoUsingGET");
            // verify the required parameter 'dataValidade' is set
            if (dataValidade == null) throw new ApiException(400, "Missing required parameter 'dataValidade' when calling ValidarDadosImpressosBandeiradoUsingGET");
            // verify the required parameter 'codigoSeguranca' is set
            if (codigoSeguranca == null) throw new ApiException(400, "Missing required parameter 'codigoSeguranca' when calling ValidarDadosImpressosBandeiradoUsingGET");
            
    
            var localVarPath = "/api/cartoes/validar-dados-impressos-bandeirados";
    
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
            
            if (numeroCartao != null) localVarQueryParams.Add("numero_cartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            if (nomePortador != null) localVarQueryParams.Add("nome_portador", Configuration.ApiClient.ParameterToString(nomePortador)); // query parameter
            if (dataValidade != null) localVarQueryParams.Add("data_validade", Configuration.ApiClient.ParameterToString(dataValidade)); // query parameter
            if (codigoSeguranca != null) localVarQueryParams.Add("codigo_seguranca", Configuration.ApiClient.ParameterToString(codigoSeguranca)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosImpressosBandeiradoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosImpressosBandeiradoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ValidaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartaoResponse)));
            
        }
        
        /// <summary>
        /// {{{cartao_resource_validar_dados_impressos_nao_bandeirado}}} {{{cartao_resource_validar_dados_impressos_nao_bandeirado_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">{{{cartao_resource_validar_dados_impressos_nao_bandeirado_param_numero_cartao}}}</param> 
        /// <param name="nomePortador">{{{cartao_resource_validar_dados_impressos_nao_bandeirado_param_nome_portador}}}</param> 
        /// <param name="dataValidade">{{{cartao_resource_validar_dados_impressos_nao_bandeirado_param_data_validade}}}</param> 
        /// <param name="codigoSeguranca">{{{cartao_resource_validar_dados_impressos_nao_bandeirado_param_codigo_seguranca}}}</param> 
        /// <returns>ValidaCartaoResponse</returns>
        public ValidaCartaoResponse ValidarDadosImpressosNaoBandeiradoUsingGET (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
             ApiResponse<ValidaCartaoResponse> localVarResponse = ValidarDadosImpressosNaoBandeiradoUsingGETWithHttpInfo(numeroCartao, nomePortador, dataValidade, codigoSeguranca);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_resource_validar_dados_impressos_nao_bandeirado}}} {{{cartao_resource_validar_dados_impressos_nao_bandeirado_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">{{{cartao_resource_validar_dados_impressos_nao_bandeirado_param_numero_cartao}}}</param> 
        /// <param name="nomePortador">{{{cartao_resource_validar_dados_impressos_nao_bandeirado_param_nome_portador}}}</param> 
        /// <param name="dataValidade">{{{cartao_resource_validar_dados_impressos_nao_bandeirado_param_data_validade}}}</param> 
        /// <param name="codigoSeguranca">{{{cartao_resource_validar_dados_impressos_nao_bandeirado_param_codigo_seguranca}}}</param> 
        /// <returns>ApiResponse of ValidaCartaoResponse</returns>
        public ApiResponse< ValidaCartaoResponse > ValidarDadosImpressosNaoBandeiradoUsingGETWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
            
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null)
                throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling GlobaltagcartaoApi->ValidarDadosImpressosNaoBandeiradoUsingGET");
            
            // verify the required parameter 'nomePortador' is set
            if (nomePortador == null)
                throw new ApiException(400, "Missing required parameter 'nomePortador' when calling GlobaltagcartaoApi->ValidarDadosImpressosNaoBandeiradoUsingGET");
            
            // verify the required parameter 'dataValidade' is set
            if (dataValidade == null)
                throw new ApiException(400, "Missing required parameter 'dataValidade' when calling GlobaltagcartaoApi->ValidarDadosImpressosNaoBandeiradoUsingGET");
            
            // verify the required parameter 'codigoSeguranca' is set
            if (codigoSeguranca == null)
                throw new ApiException(400, "Missing required parameter 'codigoSeguranca' when calling GlobaltagcartaoApi->ValidarDadosImpressosNaoBandeiradoUsingGET");
            
    
            var localVarPath = "/api/cartoes/validar-dados-impressos-nao-bandeirados";
    
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
            
            if (numeroCartao != null) localVarQueryParams.Add("numero_cartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            if (nomePortador != null) localVarQueryParams.Add("nome_portador", Configuration.ApiClient.ParameterToString(nomePortador)); // query parameter
            if (dataValidade != null) localVarQueryParams.Add("data_validade", Configuration.ApiClient.ParameterToString(dataValidade)); // query parameter
            if (codigoSeguranca != null) localVarQueryParams.Add("codigo_seguranca", Configuration.ApiClient.ParameterToString(codigoSeguranca)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosImpressosNaoBandeiradoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosImpressosNaoBandeiradoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ValidaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartaoResponse)));
            
        }

        
        /// <summary>
        /// {{{cartao_resource_validar_dados_impressos_nao_bandeirado}}} {{{cartao_resource_validar_dados_impressos_nao_bandeirado_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">{{{cartao_resource_validar_dados_impressos_nao_bandeirado_param_numero_cartao}}}</param>
        /// <param name="nomePortador">{{{cartao_resource_validar_dados_impressos_nao_bandeirado_param_nome_portador}}}</param>
        /// <param name="dataValidade">{{{cartao_resource_validar_dados_impressos_nao_bandeirado_param_data_validade}}}</param>
        /// <param name="codigoSeguranca">{{{cartao_resource_validar_dados_impressos_nao_bandeirado_param_codigo_seguranca}}}</param>
        /// <returns>Task of ValidaCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ValidaCartaoResponse> ValidarDadosImpressosNaoBandeiradoUsingGETAsync (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
             ApiResponse<ValidaCartaoResponse> localVarResponse = await ValidarDadosImpressosNaoBandeiradoUsingGETAsyncWithHttpInfo(numeroCartao, nomePortador, dataValidade, codigoSeguranca);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_resource_validar_dados_impressos_nao_bandeirado}}} {{{cartao_resource_validar_dados_impressos_nao_bandeirado_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">{{{cartao_resource_validar_dados_impressos_nao_bandeirado_param_numero_cartao}}}</param>
        /// <param name="nomePortador">{{{cartao_resource_validar_dados_impressos_nao_bandeirado_param_nome_portador}}}</param>
        /// <param name="dataValidade">{{{cartao_resource_validar_dados_impressos_nao_bandeirado_param_data_validade}}}</param>
        /// <param name="codigoSeguranca">{{{cartao_resource_validar_dados_impressos_nao_bandeirado_param_codigo_seguranca}}}</param>
        /// <returns>Task of ApiResponse (ValidaCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ValidaCartaoResponse>> ValidarDadosImpressosNaoBandeiradoUsingGETAsyncWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null) throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling ValidarDadosImpressosNaoBandeiradoUsingGET");
            // verify the required parameter 'nomePortador' is set
            if (nomePortador == null) throw new ApiException(400, "Missing required parameter 'nomePortador' when calling ValidarDadosImpressosNaoBandeiradoUsingGET");
            // verify the required parameter 'dataValidade' is set
            if (dataValidade == null) throw new ApiException(400, "Missing required parameter 'dataValidade' when calling ValidarDadosImpressosNaoBandeiradoUsingGET");
            // verify the required parameter 'codigoSeguranca' is set
            if (codigoSeguranca == null) throw new ApiException(400, "Missing required parameter 'codigoSeguranca' when calling ValidarDadosImpressosNaoBandeiradoUsingGET");
            
    
            var localVarPath = "/api/cartoes/validar-dados-impressos-nao-bandeirados";
    
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
            
            if (numeroCartao != null) localVarQueryParams.Add("numero_cartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            if (nomePortador != null) localVarQueryParams.Add("nome_portador", Configuration.ApiClient.ParameterToString(nomePortador)); // query parameter
            if (dataValidade != null) localVarQueryParams.Add("data_validade", Configuration.ApiClient.ParameterToString(dataValidade)); // query parameter
            if (codigoSeguranca != null) localVarQueryParams.Add("codigo_seguranca", Configuration.ApiClient.ParameterToString(codigoSeguranca)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosImpressosNaoBandeiradoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosImpressosNaoBandeiradoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ValidaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartaoResponse)));
            
        }
        
        /// <summary>
        /// {{{cartao_resource_validar_de55_cartao_mastercard}}} {{{cartao_resource_validar_de55_cartao_mastercard_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">{{{cartao_resource_validar_de55_cartao_mastercard_param_numero_cartao}}}</param> 
        /// <param name="criptograma">{{{cartao_resource_validar_de55_cartao_mastercard_param_criptograma}}}</param> 
        /// <returns>ValidaCartaoResponse</returns>
        public ValidaCartaoResponse ValidarDe55CartaoMastercardUsingGET (string numeroCartao, string criptograma)
        {
             ApiResponse<ValidaCartaoResponse> localVarResponse = ValidarDe55CartaoMastercardUsingGETWithHttpInfo(numeroCartao, criptograma);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_resource_validar_de55_cartao_mastercard}}} {{{cartao_resource_validar_de55_cartao_mastercard_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">{{{cartao_resource_validar_de55_cartao_mastercard_param_numero_cartao}}}</param> 
        /// <param name="criptograma">{{{cartao_resource_validar_de55_cartao_mastercard_param_criptograma}}}</param> 
        /// <returns>ApiResponse of ValidaCartaoResponse</returns>
        public ApiResponse< ValidaCartaoResponse > ValidarDe55CartaoMastercardUsingGETWithHttpInfo (string numeroCartao, string criptograma)
        {
            
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null)
                throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling GlobaltagcartaoApi->ValidarDe55CartaoMastercardUsingGET");
            
            // verify the required parameter 'criptograma' is set
            if (criptograma == null)
                throw new ApiException(400, "Missing required parameter 'criptograma' when calling GlobaltagcartaoApi->ValidarDe55CartaoMastercardUsingGET");
            
    
            var localVarPath = "/api/cartoes/validar-de55-mastercard";
    
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
            
            if (numeroCartao != null) localVarQueryParams.Add("numero_cartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            if (criptograma != null) localVarQueryParams.Add("criptograma", Configuration.ApiClient.ParameterToString(criptograma)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDe55CartaoMastercardUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDe55CartaoMastercardUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ValidaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartaoResponse)));
            
        }

        
        /// <summary>
        /// {{{cartao_resource_validar_de55_cartao_mastercard}}} {{{cartao_resource_validar_de55_cartao_mastercard_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">{{{cartao_resource_validar_de55_cartao_mastercard_param_numero_cartao}}}</param>
        /// <param name="criptograma">{{{cartao_resource_validar_de55_cartao_mastercard_param_criptograma}}}</param>
        /// <returns>Task of ValidaCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ValidaCartaoResponse> ValidarDe55CartaoMastercardUsingGETAsync (string numeroCartao, string criptograma)
        {
             ApiResponse<ValidaCartaoResponse> localVarResponse = await ValidarDe55CartaoMastercardUsingGETAsyncWithHttpInfo(numeroCartao, criptograma);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_resource_validar_de55_cartao_mastercard}}} {{{cartao_resource_validar_de55_cartao_mastercard_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">{{{cartao_resource_validar_de55_cartao_mastercard_param_numero_cartao}}}</param>
        /// <param name="criptograma">{{{cartao_resource_validar_de55_cartao_mastercard_param_criptograma}}}</param>
        /// <returns>Task of ApiResponse (ValidaCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ValidaCartaoResponse>> ValidarDe55CartaoMastercardUsingGETAsyncWithHttpInfo (string numeroCartao, string criptograma)
        {
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null) throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling ValidarDe55CartaoMastercardUsingGET");
            // verify the required parameter 'criptograma' is set
            if (criptograma == null) throw new ApiException(400, "Missing required parameter 'criptograma' when calling ValidarDe55CartaoMastercardUsingGET");
            
    
            var localVarPath = "/api/cartoes/validar-de55-mastercard";
    
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
            
            if (numeroCartao != null) localVarQueryParams.Add("numero_cartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            if (criptograma != null) localVarQueryParams.Add("criptograma", Configuration.ApiClient.ParameterToString(criptograma)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDe55CartaoMastercardUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDe55CartaoMastercardUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ValidaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartaoResponse)));
            
        }
        
        /// <summary>
        /// {{{cartao_resource_validar_senha}}} {{{cartao_resource_validar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_validar_senha_param_id}}}</param> 
        /// <param name="senha">{{{cartao_resource_validar_senha_param_senha}}}</param> 
        /// <returns>ValidaSenhaCartaoResponse</returns>
        public ValidaSenhaCartaoResponse ValidarSenhaUsingGET (long? id, string senha)
        {
             ApiResponse<ValidaSenhaCartaoResponse> localVarResponse = ValidarSenhaUsingGETWithHttpInfo(id, senha);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_resource_validar_senha}}} {{{cartao_resource_validar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_validar_senha_param_id}}}</param> 
        /// <param name="senha">{{{cartao_resource_validar_senha_param_senha}}}</param> 
        /// <returns>ApiResponse of ValidaSenhaCartaoResponse</returns>
        public ApiResponse< ValidaSenhaCartaoResponse > ValidarSenhaUsingGETWithHttpInfo (long? id, string senha)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcartaoApi->ValidarSenhaUsingGET");
            
            // verify the required parameter 'senha' is set
            if (senha == null)
                throw new ApiException(400, "Missing required parameter 'senha' when calling GlobaltagcartaoApi->ValidarSenhaUsingGET");
            
    
            var localVarPath = "/api/cartoes/{id}/validar-senha";
    
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
            
            
            if (senha != null) localVarHeaderParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // header parameter
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ValidaSenhaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaSenhaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaSenhaCartaoResponse)));
            
        }

        
        /// <summary>
        /// {{{cartao_resource_validar_senha}}} {{{cartao_resource_validar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_validar_senha_param_id}}}</param>
        /// <param name="senha">{{{cartao_resource_validar_senha_param_senha}}}</param>
        /// <returns>Task of ValidaSenhaCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ValidaSenhaCartaoResponse> ValidarSenhaUsingGETAsync (long? id, string senha)
        {
             ApiResponse<ValidaSenhaCartaoResponse> localVarResponse = await ValidarSenhaUsingGETAsyncWithHttpInfo(id, senha);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_resource_validar_senha}}} {{{cartao_resource_validar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{cartao_resource_validar_senha_param_id}}}</param>
        /// <param name="senha">{{{cartao_resource_validar_senha_param_senha}}}</param>
        /// <returns>Task of ApiResponse (ValidaSenhaCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ValidaSenhaCartaoResponse>> ValidarSenhaUsingGETAsyncWithHttpInfo (long? id, string senha)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ValidarSenhaUsingGET");
            // verify the required parameter 'senha' is set
            if (senha == null) throw new ApiException(400, "Missing required parameter 'senha' when calling ValidarSenhaUsingGET");
            
    
            var localVarPath = "/api/cartoes/{id}/validar-senha";
    
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
            
            
            if (senha != null) localVarHeaderParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // header parameter
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ValidaSenhaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaSenhaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaSenhaCartaoResponse)));
            
        }
        
        /// <summary>
        /// {{{cartao_resource_validar_tarja}}} {{{cartao_resource_validar_tarja_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">{{{cartao_resource_validar_tarja_param_numero_cartao}}}</param> 
        /// <param name="trilha1">{{{cartao_resource_validar_tarja_param_trilha1}}}</param> 
        /// <param name="trilha2">{{{cartao_resource_validar_tarja_param_trilha2}}}</param> 
        /// <returns>ValidaCartaoResponse</returns>
        public ValidaCartaoResponse ValidarTarjaUsingGET (string numeroCartao, string trilha1, string trilha2)
        {
             ApiResponse<ValidaCartaoResponse> localVarResponse = ValidarTarjaUsingGETWithHttpInfo(numeroCartao, trilha1, trilha2);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_resource_validar_tarja}}} {{{cartao_resource_validar_tarja_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">{{{cartao_resource_validar_tarja_param_numero_cartao}}}</param> 
        /// <param name="trilha1">{{{cartao_resource_validar_tarja_param_trilha1}}}</param> 
        /// <param name="trilha2">{{{cartao_resource_validar_tarja_param_trilha2}}}</param> 
        /// <returns>ApiResponse of ValidaCartaoResponse</returns>
        public ApiResponse< ValidaCartaoResponse > ValidarTarjaUsingGETWithHttpInfo (string numeroCartao, string trilha1, string trilha2)
        {
            
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null)
                throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling GlobaltagcartaoApi->ValidarTarjaUsingGET");
            
            // verify the required parameter 'trilha1' is set
            if (trilha1 == null)
                throw new ApiException(400, "Missing required parameter 'trilha1' when calling GlobaltagcartaoApi->ValidarTarjaUsingGET");
            
            // verify the required parameter 'trilha2' is set
            if (trilha2 == null)
                throw new ApiException(400, "Missing required parameter 'trilha2' when calling GlobaltagcartaoApi->ValidarTarjaUsingGET");
            
    
            var localVarPath = "/api/cartoes/validar-tarja";
    
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
            
            if (numeroCartao != null) localVarQueryParams.Add("numero_cartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            if (trilha1 != null) localVarQueryParams.Add("trilha1", Configuration.ApiClient.ParameterToString(trilha1)); // query parameter
            if (trilha2 != null) localVarQueryParams.Add("trilha2", Configuration.ApiClient.ParameterToString(trilha2)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarTarjaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarTarjaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ValidaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartaoResponse)));
            
        }

        
        /// <summary>
        /// {{{cartao_resource_validar_tarja}}} {{{cartao_resource_validar_tarja_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">{{{cartao_resource_validar_tarja_param_numero_cartao}}}</param>
        /// <param name="trilha1">{{{cartao_resource_validar_tarja_param_trilha1}}}</param>
        /// <param name="trilha2">{{{cartao_resource_validar_tarja_param_trilha2}}}</param>
        /// <returns>Task of ValidaCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ValidaCartaoResponse> ValidarTarjaUsingGETAsync (string numeroCartao, string trilha1, string trilha2)
        {
             ApiResponse<ValidaCartaoResponse> localVarResponse = await ValidarTarjaUsingGETAsyncWithHttpInfo(numeroCartao, trilha1, trilha2);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_resource_validar_tarja}}} {{{cartao_resource_validar_tarja_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">{{{cartao_resource_validar_tarja_param_numero_cartao}}}</param>
        /// <param name="trilha1">{{{cartao_resource_validar_tarja_param_trilha1}}}</param>
        /// <param name="trilha2">{{{cartao_resource_validar_tarja_param_trilha2}}}</param>
        /// <returns>Task of ApiResponse (ValidaCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ValidaCartaoResponse>> ValidarTarjaUsingGETAsyncWithHttpInfo (string numeroCartao, string trilha1, string trilha2)
        {
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null) throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling ValidarTarjaUsingGET");
            // verify the required parameter 'trilha1' is set
            if (trilha1 == null) throw new ApiException(400, "Missing required parameter 'trilha1' when calling ValidarTarjaUsingGET");
            // verify the required parameter 'trilha2' is set
            if (trilha2 == null) throw new ApiException(400, "Missing required parameter 'trilha2' when calling ValidarTarjaUsingGET");
            
    
            var localVarPath = "/api/cartoes/validar-tarja";
    
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
            
            if (numeroCartao != null) localVarQueryParams.Add("numero_cartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            if (trilha1 != null) localVarQueryParams.Add("trilha1", Configuration.ApiClient.ParameterToString(trilha1)); // query parameter
            if (trilha2 != null) localVarQueryParams.Add("trilha2", Configuration.ApiClient.ParameterToString(trilha2)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarTarjaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarTarjaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ValidaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartaoResponse)));
            
        }
        
    }
    
}
