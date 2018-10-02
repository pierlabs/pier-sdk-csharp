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
    public interface IGlobaltagestabelecimentoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{origem_comercial_resource_alterar_origem_comercial}}}
        /// </summary>
        /// <remarks>
        /// {{{origem_comercial_resource_alterar_origem_comercial_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{origem_comercial_resource_alterar_origem_comercial_param_id}}}</param>
        /// <param name="origemComercialUpdate">origemComercialUpdate</param>
        /// <returns>OrigemComercialResponse</returns>
        OrigemComercialResponse AlterarOrigemComercialUsingPUT (long? id, OrigemComercialUpdate origemComercialUpdate);
  
        /// <summary>
        /// {{{origem_comercial_resource_alterar_origem_comercial}}}
        /// </summary>
        /// <remarks>
        /// {{{origem_comercial_resource_alterar_origem_comercial_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{origem_comercial_resource_alterar_origem_comercial_param_id}}}</param>
        /// <param name="origemComercialUpdate">origemComercialUpdate</param>
        /// <returns>ApiResponse of OrigemComercialResponse</returns>
        ApiResponse<OrigemComercialResponse> AlterarOrigemComercialUsingPUTWithHttpInfo (long? id, OrigemComercialUpdate origemComercialUpdate);
        
        /// <summary>
        /// {{{operacao_credor_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{operacao_credor_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{operacao_credor_resource_alterar_param_id}}}</param>
        /// <param name="operacaoCredorUpdate">operacaoCredorUpdate</param>
        /// <returns>OperacaoCredorResponse</returns>
        OperacaoCredorResponse AlterarUsingPUT10 (long? id, OperacaoCredorUpdate operacaoCredorUpdate);
  
        /// <summary>
        /// {{{operacao_credor_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{operacao_credor_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{operacao_credor_resource_alterar_param_id}}}</param>
        /// <param name="operacaoCredorUpdate">operacaoCredorUpdate</param>
        /// <returns>ApiResponse of OperacaoCredorResponse</returns>
        ApiResponse<OperacaoCredorResponse> AlterarUsingPUT10WithHttpInfo (long? id, OperacaoCredorUpdate operacaoCredorUpdate);
        
        /// <summary>
        /// {{{telefone_estabelecimento_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{telefone_estabelecimento_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{telefone_estabelecimento_resource_alterar_param_id}}}</param>
        /// <param name="telefoneEstabelecimentoUpdate">telefoneEstabelecimentoUpdate</param>
        /// <returns>TelefoneEstabelecimentoResponse</returns>
        TelefoneEstabelecimentoResponse AlterarUsingPUT14 (long? id, TelefoneEstabelecimentoUpdate telefoneEstabelecimentoUpdate);
  
        /// <summary>
        /// {{{telefone_estabelecimento_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{telefone_estabelecimento_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{telefone_estabelecimento_resource_alterar_param_id}}}</param>
        /// <param name="telefoneEstabelecimentoUpdate">telefoneEstabelecimentoUpdate</param>
        /// <returns>ApiResponse of TelefoneEstabelecimentoResponse</returns>
        ApiResponse<TelefoneEstabelecimentoResponse> AlterarUsingPUT14WithHttpInfo (long? id, TelefoneEstabelecimentoUpdate telefoneEstabelecimentoUpdate);
        
        /// <summary>
        /// {{{terminal_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{terminal_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{terminal_resource_alterar_param_id}}}</param>
        /// <param name="terminalUpdate">terminalUpdate</param>
        /// <returns>TerminalResponse</returns>
        TerminalResponse AlterarUsingPUT16 (long? id, TerminalUpdateValue terminalUpdate);
  
        /// <summary>
        /// {{{terminal_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{terminal_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{terminal_resource_alterar_param_id}}}</param>
        /// <param name="terminalUpdate">terminalUpdate</param>
        /// <returns>ApiResponse of TerminalResponse</returns>
        ApiResponse<TerminalResponse> AlterarUsingPUT16WithHttpInfo (long? id, TerminalUpdateValue terminalUpdate);
        
        /// <summary>
        /// {{{estabelecimento_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{estabelecimento_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{estabelecimento_resource_alterar_param_id_estabelecimento}}}</param>
        /// <param name="update">update</param>
        /// <returns>EstabelecimentoResponse</returns>
        EstabelecimentoResponse AlterarUsingPUT5 (long? id, EstabelecimentoUpdate update);
  
        /// <summary>
        /// {{{estabelecimento_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{estabelecimento_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{estabelecimento_resource_alterar_param_id_estabelecimento}}}</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of EstabelecimentoResponse</returns>
        ApiResponse<EstabelecimentoResponse> AlterarUsingPUT5WithHttpInfo (long? id, EstabelecimentoUpdate update);
        
        /// <summary>
        /// {{{grupo_economico_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{grupo_economico_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{grupo_economico_resource_alterar_param_id}}}</param>
        /// <param name="grupoEconomicoDTO">grupoEconomicoDTO</param>
        /// <returns>GrupoEconomicoResponse</returns>
        GrupoEconomicoResponse AlterarUsingPUT7 (long? id, GrupoEconomicoDTO grupoEconomicoDTO);
  
        /// <summary>
        /// {{{grupo_economico_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{grupo_economico_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{grupo_economico_resource_alterar_param_id}}}</param>
        /// <param name="grupoEconomicoDTO">grupoEconomicoDTO</param>
        /// <returns>ApiResponse of GrupoEconomicoResponse</returns>
        ApiResponse<GrupoEconomicoResponse> AlterarUsingPUT7WithHttpInfo (long? id, GrupoEconomicoDTO grupoEconomicoDTO);
        
        /// <summary>
        /// {{{maquineta_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{maquineta_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{maquineta_resource_alterar_param_id}}}</param>
        /// <param name="maquinetaUpdate">maquinetaUpdate</param>
        /// <returns>MaquinetaResponse</returns>
        MaquinetaResponse AlterarUsingPUT9 (long? id, MaquinetaUpdate maquinetaUpdate);
  
        /// <summary>
        /// {{{maquineta_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{maquineta_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{maquineta_resource_alterar_param_id}}}</param>
        /// <param name="maquinetaUpdate">maquinetaUpdate</param>
        /// <returns>ApiResponse of MaquinetaResponse</returns>
        ApiResponse<MaquinetaResponse> AlterarUsingPUT9WithHttpInfo (long? id, MaquinetaUpdate maquinetaUpdate);
        
        /// <summary>
        /// {{{origem_comercial_resource_cadastrar_origem_comercial}}}
        /// </summary>
        /// <remarks>
        /// {{{origem_comercial_resource_cadastrar_origem_comercial_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origemComercialPersist">origemComercialPersist</param>
        /// <returns>OrigemComercialResponse</returns>
        OrigemComercialResponse CadastrarOrigemComercialUsingPOST (OrigemComercialPersist origemComercialPersist);
  
        /// <summary>
        /// {{{origem_comercial_resource_cadastrar_origem_comercial}}}
        /// </summary>
        /// <remarks>
        /// {{{origem_comercial_resource_cadastrar_origem_comercial_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origemComercialPersist">origemComercialPersist</param>
        /// <returns>ApiResponse of OrigemComercialResponse</returns>
        ApiResponse<OrigemComercialResponse> CadastrarOrigemComercialUsingPOSTWithHttpInfo (OrigemComercialPersist origemComercialPersist);
        
        /// <summary>
        /// {{{estabelecimento_resource_cadastrar}}}
        /// </summary>
        /// <remarks>
        /// {{{estabelecimento_resource_cadastrar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>EstabelecimentoResponse</returns>
        EstabelecimentoResponse CadastrarUsingPOST3 (EstabelecimentoPersist persist);
  
        /// <summary>
        /// {{{estabelecimento_resource_cadastrar}}}
        /// </summary>
        /// <remarks>
        /// {{{estabelecimento_resource_cadastrar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of EstabelecimentoResponse</returns>
        ApiResponse<EstabelecimentoResponse> CadastrarUsingPOST3WithHttpInfo (EstabelecimentoPersist persist);
        
        /// <summary>
        /// {{{grupo_economico_resource_cadastrar}}}
        /// </summary>
        /// <remarks>
        /// {{{grupo_economico_resource_cadastrar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoEconomicoDTO">GrupoEconomicoDTO</param>
        /// <returns>GrupoEconomicoResponse</returns>
        GrupoEconomicoResponse CadastrarUsingPOST4 (GrupoEconomicoDTO grupoEconomicoDTO);
  
        /// <summary>
        /// {{{grupo_economico_resource_cadastrar}}}
        /// </summary>
        /// <remarks>
        /// {{{grupo_economico_resource_cadastrar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoEconomicoDTO">GrupoEconomicoDTO</param>
        /// <returns>ApiResponse of GrupoEconomicoResponse</returns>
        ApiResponse<GrupoEconomicoResponse> CadastrarUsingPOST4WithHttpInfo (GrupoEconomicoDTO grupoEconomicoDTO);
        
        /// <summary>
        /// {{{operacao_resource_consulta_operacao}}}
        /// </summary>
        /// <remarks>
        /// {{{operacao_resource_consulta_operacao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{operacao_resource_consulta_operacao_param_id_operacao}}}</param>
        /// <returns>DetalheOperacaoResponse</returns>
        DetalheOperacaoResponse ConsultaOperacaoUsingGET (long? id);
  
        /// <summary>
        /// {{{operacao_resource_consulta_operacao}}}
        /// </summary>
        /// <remarks>
        /// {{{operacao_resource_consulta_operacao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{operacao_resource_consulta_operacao_param_id_operacao}}}</param>
        /// <returns>ApiResponse of DetalheOperacaoResponse</returns>
        ApiResponse<DetalheOperacaoResponse> ConsultaOperacaoUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{origem_comercial_resource_consultar_origem_comercial}}}
        /// </summary>
        /// <remarks>
        /// {{{origem_comercial_resource_consultar_origem_comercial_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{origem_comercial_resource_consultar_origem_comercial_param_id}}}</param>
        /// <returns>OrigemComercialResponse</returns>
        OrigemComercialResponse ConsultarOrigemComercialUsingGET (long? id);
  
        /// <summary>
        /// {{{origem_comercial_resource_consultar_origem_comercial}}}
        /// </summary>
        /// <remarks>
        /// {{{origem_comercial_resource_consultar_origem_comercial_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{origem_comercial_resource_consultar_origem_comercial_param_id}}}</param>
        /// <returns>ApiResponse of OrigemComercialResponse</returns>
        ApiResponse<OrigemComercialResponse> ConsultarOrigemComercialUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{estabelecimento_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{estabelecimento_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{estabelecimento_resource_consultar_param_id_estabelecimento}}}</param>
        /// <returns>EstabelecimentoResponse</returns>
        EstabelecimentoResponse ConsultarUsingGET18 (long? id);
  
        /// <summary>
        /// {{{estabelecimento_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{estabelecimento_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{estabelecimento_resource_consultar_param_id_estabelecimento}}}</param>
        /// <returns>ApiResponse of EstabelecimentoResponse</returns>
        ApiResponse<EstabelecimentoResponse> ConsultarUsingGET18WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{grupo_economico_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{grupo_economico_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{grupo_economico_resource_consultar_param_id}}}</param>
        /// <returns>GrupoEconomicoResponse</returns>
        GrupoEconomicoResponse ConsultarUsingGET20 (long? id);
  
        /// <summary>
        /// {{{grupo_economico_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{grupo_economico_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{grupo_economico_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of GrupoEconomicoResponse</returns>
        ApiResponse<GrupoEconomicoResponse> ConsultarUsingGET20WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{maquineta_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{maquineta_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{maquineta_resource_consultar_param_id}}}</param>
        /// <returns>MaquinetaResponse</returns>
        MaquinetaResponse ConsultarUsingGET22 (long? id);
  
        /// <summary>
        /// {{{maquineta_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{maquineta_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{maquineta_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of MaquinetaResponse</returns>
        ApiResponse<MaquinetaResponse> ConsultarUsingGET22WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{operacao_credor_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{operacao_credor_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{operacao_credor_resource_consultar_param_id}}}</param>
        /// <returns>OperacaoCredorResponse</returns>
        OperacaoCredorResponse ConsultarUsingGET23 (long? id);
  
        /// <summary>
        /// {{{operacao_credor_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{operacao_credor_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{operacao_credor_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of OperacaoCredorResponse</returns>
        ApiResponse<OperacaoCredorResponse> ConsultarUsingGET23WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{telefone_estabelecimento_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{telefone_estabelecimento_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{telefone_estabelecimento_resource_consultar_param_id}}}</param>
        /// <returns>TelefoneEstabelecimentoResponse</returns>
        TelefoneEstabelecimentoResponse ConsultarUsingGET34 (long? id);
  
        /// <summary>
        /// {{{telefone_estabelecimento_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{telefone_estabelecimento_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{telefone_estabelecimento_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of TelefoneEstabelecimentoResponse</returns>
        ApiResponse<TelefoneEstabelecimentoResponse> ConsultarUsingGET34WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{terminal_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{terminal_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{terminal_resource_consultar_param_id}}}</param>
        /// <returns>TerminalResponse</returns>
        TerminalResponse ConsultarUsingGET36 (long? id);
  
        /// <summary>
        /// {{{terminal_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{terminal_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{terminal_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of TerminalResponse</returns>
        ApiResponse<TerminalResponse> ConsultarUsingGET36WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_estabelecimento_adquirente_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_estabelecimento_adquirente_resource_consultar_param_id}}}</param>
        /// <returns>VinculoEstabelecimentoAdquirenteResponse</returns>
        VinculoEstabelecimentoAdquirenteResponse ConsultarUsingGET47 (long? id);
  
        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_estabelecimento_adquirente_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_estabelecimento_adquirente_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of VinculoEstabelecimentoAdquirenteResponse</returns>
        ApiResponse<VinculoEstabelecimentoAdquirenteResponse> ConsultarUsingGET47WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_desabilitar_vinculo}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_estabelecimento_adquirente_resource_desabilitar_vinculo_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_estabelecimento_adquirente_resource_desabilitar_vinculo_param_id}}}</param>
        /// <returns>Object</returns>
        Object DesabilitarVinculoUsingPOST (long? id);
  
        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_desabilitar_vinculo}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_estabelecimento_adquirente_resource_desabilitar_vinculo_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_estabelecimento_adquirente_resource_desabilitar_vinculo_param_id}}}</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> DesabilitarVinculoUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{vinculo_operacao_resource_desabilitar_vinculo}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_operacao_resource_desabilitar_vinculo_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_operacao_resource_desabilitar_vinculo_param_id}}}</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>Object</returns>
        Object DesabilitarVinculoUsingPOST1 (long? id, VinculoOperacaoPersist vinculoOperacaoPersist);
  
        /// <summary>
        /// {{{vinculo_operacao_resource_desabilitar_vinculo}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_operacao_resource_desabilitar_vinculo_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_operacao_resource_desabilitar_vinculo_param_id}}}</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> DesabilitarVinculoUsingPOST1WithHttpInfo (long? id, VinculoOperacaoPersist vinculoOperacaoPersist);
        
        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_habilitar_vinculo}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_estabelecimento_adquirente_resource_habilitar_vinculo_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_estabelecimento_adquirente_resource_habilitar_vinculo_param_id}}}</param>
        /// <returns>Object</returns>
        Object HabilitarVinculoUsingPOST (long? id);
  
        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_habilitar_vinculo}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_estabelecimento_adquirente_resource_habilitar_vinculo_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_estabelecimento_adquirente_resource_habilitar_vinculo_param_id}}}</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> HabilitarVinculoUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{vinculo_operacao_resource_habilitar_vinculo}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_operacao_resource_habilitar_vinculo_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_operacao_resource_habilitar_vinculo_param_id}}}</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>Object</returns>
        Object HabilitarVinculoUsingPOST1 (long? id, VinculoOperacaoPersist vinculoOperacaoPersist);
  
        /// <summary>
        /// {{{vinculo_operacao_resource_habilitar_vinculo}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_operacao_resource_habilitar_vinculo_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_operacao_resource_habilitar_vinculo_param_id}}}</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> HabilitarVinculoUsingPOST1WithHttpInfo (long? id, VinculoOperacaoPersist vinculoOperacaoPersist);
        
        /// <summary>
        /// {{{operacao_resource_lista_operacao}}}
        /// </summary>
        /// <remarks>
        /// {{{operacao_resource_lista_operacao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idOperacao">{{{operacao_request_id_operacao_value}}} (optional)</param>
        /// <param name="codigoProcessamento">{{{operacao_request_codigo_processamento_value}}} (optional)</param>
        /// <param name="nomeOperacao">{{{operacao_request_nome_operacao_value}}} (optional)</param>
        /// <returns>PageOperacaoResponse</returns>
        PageOperacaoResponse ListaOperacaoUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, string codigoProcessamento = null, string nomeOperacao = null);
  
        /// <summary>
        /// {{{operacao_resource_lista_operacao}}}
        /// </summary>
        /// <remarks>
        /// {{{operacao_resource_lista_operacao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idOperacao">{{{operacao_request_id_operacao_value}}} (optional)</param>
        /// <param name="codigoProcessamento">{{{operacao_request_codigo_processamento_value}}} (optional)</param>
        /// <param name="nomeOperacao">{{{operacao_request_nome_operacao_value}}} (optional)</param>
        /// <returns>ApiResponse of PageOperacaoResponse</returns>
        ApiResponse<PageOperacaoResponse> ListaOperacaoUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, string codigoProcessamento = null, string nomeOperacao = null);
        
        /// <summary>
        /// {{{m_c_c_resource_listar_m_c_c}}}
        /// </summary>
        /// <remarks>
        /// {{{m_c_c_resource_listar_m_c_c_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>PageMCCResponse</returns>
        PageMCCResponse ListarMCCUsingGET (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{m_c_c_resource_listar_m_c_c}}}
        /// </summary>
        /// <remarks>
        /// {{{m_c_c_resource_listar_m_c_c_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of PageMCCResponse</returns>
        ApiResponse<PageMCCResponse> ListarMCCUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{origem_comercial_resource_listar_origens_comerciais}}}
        /// </summary>
        /// <remarks>
        /// {{{origem_comercial_resource_listar_origens_comerciais_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{origem_comercial_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{origem_comercial_request_nome_value}}} (optional)</param>
        /// <param name="status">{{{origem_comercial_request_status_value}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{origem_comercial_request_id_estabelecimento_value}}} (optional)</param>
        /// <param name="idProduto">{{{origem_comercial_request_id_produto_value}}} (optional)</param>
        /// <param name="descricao">{{{origem_comercial_request_descricao_value}}} (optional)</param>
        /// <param name="idTipoOrigemComercial">{{{origem_comercial_request_id_tipo_origem_comercial_value}}} (optional)</param>
        /// <param name="idGrupoOrigemComercial">{{{origem_comercial_request_id_grupo_origem_comercial_value}}} (optional)</param>
        /// <param name="flagPreAprovado">{{{origem_comercial_request_flag_pre_aprovado_value}}} (optional)</param>
        /// <param name="flagAprovacaoImediata">{{{origem_comercial_request_flag_aprovacao_imediata_value}}} (optional)</param>
        /// <param name="nomeFantasiaPlastico">{{{origem_comercial_request_nome_fantasia_plastico_value}}} (optional)</param>
        /// <param name="flagCartaoProvisorio">{{{origem_comercial_request_flag_cartao_provisorio_value}}} (optional)</param>
        /// <param name="flagCartaoDefinitivo">{{{origem_comercial_request_flag_cartao_definitivo_value}}} (optional)</param>
        /// <param name="usuario">{{{origem_comercial_request_usuario_value}}} (optional)</param>
        /// <param name="senha">{{{origem_comercial_request_senha_value}}} (optional)</param>
        /// <param name="flagOrigemExterna">{{{origem_comercial_request_flag_origem_externa_value}}} (optional)</param>
        /// <param name="flagModificado">{{{origem_comercial_request_flag_modificado_value}}} (optional)</param>
        /// <param name="flagEnviaFaturaUsuario">{{{origem_comercial_request_flag_envia_fatura_usuario_value}}} (optional)</param>
        /// <param name="flagCreditoFaturamento">{{{origem_comercial_request_flag_credito_faturamento_value}}} (optional)</param>
        /// <param name="flagConcedeLimiteProvisorio">{{{origem_comercial_request_flag_concede_limite_provisorio_value}}} (optional)</param>
        /// <param name="flagDigitalizarDoc">{{{origem_comercial_request_flag_digitalizar_doc_value}}} (optional)</param>
        /// <param name="flagEmbossingLoja">{{{origem_comercial_request_flag_embossing_loja_value}}} (optional)</param>
        /// <param name="flagConsultaPrevia">{{{origem_comercial_request_flag_consulta_previa_value}}} (optional)</param>
        /// <param name="tipoPessoa">{{{origem_comercial_request_tipo_pessoa_value}}} (optional)</param>
        /// <returns>PageOrigemComercialResponse</returns>
        PageOrigemComercialResponse ListarOrigensComerciaisUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null, long? idEstabelecimento = null, long? idProduto = null, string descricao = null, long? idTipoOrigemComercial = null, long? idGrupoOrigemComercial = null, bool? flagPreAprovado = null, bool? flagAprovacaoImediata = null, string nomeFantasiaPlastico = null, bool? flagCartaoProvisorio = null, bool? flagCartaoDefinitivo = null, string usuario = null, string senha = null, bool? flagOrigemExterna = null, bool? flagModificado = null, bool? flagEnviaFaturaUsuario = null, bool? flagCreditoFaturamento = null, bool? flagConcedeLimiteProvisorio = null, bool? flagDigitalizarDoc = null, bool? flagEmbossingLoja = null, bool? flagConsultaPrevia = null, string tipoPessoa = null);
  
        /// <summary>
        /// {{{origem_comercial_resource_listar_origens_comerciais}}}
        /// </summary>
        /// <remarks>
        /// {{{origem_comercial_resource_listar_origens_comerciais_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{origem_comercial_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{origem_comercial_request_nome_value}}} (optional)</param>
        /// <param name="status">{{{origem_comercial_request_status_value}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{origem_comercial_request_id_estabelecimento_value}}} (optional)</param>
        /// <param name="idProduto">{{{origem_comercial_request_id_produto_value}}} (optional)</param>
        /// <param name="descricao">{{{origem_comercial_request_descricao_value}}} (optional)</param>
        /// <param name="idTipoOrigemComercial">{{{origem_comercial_request_id_tipo_origem_comercial_value}}} (optional)</param>
        /// <param name="idGrupoOrigemComercial">{{{origem_comercial_request_id_grupo_origem_comercial_value}}} (optional)</param>
        /// <param name="flagPreAprovado">{{{origem_comercial_request_flag_pre_aprovado_value}}} (optional)</param>
        /// <param name="flagAprovacaoImediata">{{{origem_comercial_request_flag_aprovacao_imediata_value}}} (optional)</param>
        /// <param name="nomeFantasiaPlastico">{{{origem_comercial_request_nome_fantasia_plastico_value}}} (optional)</param>
        /// <param name="flagCartaoProvisorio">{{{origem_comercial_request_flag_cartao_provisorio_value}}} (optional)</param>
        /// <param name="flagCartaoDefinitivo">{{{origem_comercial_request_flag_cartao_definitivo_value}}} (optional)</param>
        /// <param name="usuario">{{{origem_comercial_request_usuario_value}}} (optional)</param>
        /// <param name="senha">{{{origem_comercial_request_senha_value}}} (optional)</param>
        /// <param name="flagOrigemExterna">{{{origem_comercial_request_flag_origem_externa_value}}} (optional)</param>
        /// <param name="flagModificado">{{{origem_comercial_request_flag_modificado_value}}} (optional)</param>
        /// <param name="flagEnviaFaturaUsuario">{{{origem_comercial_request_flag_envia_fatura_usuario_value}}} (optional)</param>
        /// <param name="flagCreditoFaturamento">{{{origem_comercial_request_flag_credito_faturamento_value}}} (optional)</param>
        /// <param name="flagConcedeLimiteProvisorio">{{{origem_comercial_request_flag_concede_limite_provisorio_value}}} (optional)</param>
        /// <param name="flagDigitalizarDoc">{{{origem_comercial_request_flag_digitalizar_doc_value}}} (optional)</param>
        /// <param name="flagEmbossingLoja">{{{origem_comercial_request_flag_embossing_loja_value}}} (optional)</param>
        /// <param name="flagConsultaPrevia">{{{origem_comercial_request_flag_consulta_previa_value}}} (optional)</param>
        /// <param name="tipoPessoa">{{{origem_comercial_request_tipo_pessoa_value}}} (optional)</param>
        /// <returns>ApiResponse of PageOrigemComercialResponse</returns>
        ApiResponse<PageOrigemComercialResponse> ListarOrigensComerciaisUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null, long? idEstabelecimento = null, long? idProduto = null, string descricao = null, long? idTipoOrigemComercial = null, long? idGrupoOrigemComercial = null, bool? flagPreAprovado = null, bool? flagAprovacaoImediata = null, string nomeFantasiaPlastico = null, bool? flagCartaoProvisorio = null, bool? flagCartaoDefinitivo = null, string usuario = null, string senha = null, bool? flagOrigemExterna = null, bool? flagModificado = null, bool? flagEnviaFaturaUsuario = null, bool? flagCreditoFaturamento = null, bool? flagConcedeLimiteProvisorio = null, bool? flagDigitalizarDoc = null, bool? flagEmbossingLoja = null, bool? flagConsultaPrevia = null, string tipoPessoa = null);
        
        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_listar_tipos_adquirentes}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_estabelecimento_adquirente_resource_listar_tipos_adquirentes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>PageEntidadeResponse</returns>
        PageEntidadeResponse ListarTiposAdquirentesUsingGET (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_listar_tipos_adquirentes}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_estabelecimento_adquirente_resource_listar_tipos_adquirentes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of PageEntidadeResponse</returns>
        ApiResponse<PageEntidadeResponse> ListarTiposAdquirentesUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{tipo_estabelecimento_resource_listar_tipos_estabelecimentos}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_estabelecimento_resource_listar_tipos_estabelecimentos_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="descricao">{{{tipo_estabelecimento_request_descricao_value}}} (optional)</param>
        /// <returns>PageTipoEstabelecimentoResponse</returns>
        PageTipoEstabelecimentoResponse ListarTiposEstabelecimentosUsingGET (List<string> sort = null, int? page = null, int? limit = null, string descricao = null);
  
        /// <summary>
        /// {{{tipo_estabelecimento_resource_listar_tipos_estabelecimentos}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_estabelecimento_resource_listar_tipos_estabelecimentos_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="descricao">{{{tipo_estabelecimento_request_descricao_value}}} (optional)</param>
        /// <returns>ApiResponse of PageTipoEstabelecimentoResponse</returns>
        ApiResponse<PageTipoEstabelecimentoResponse> ListarTiposEstabelecimentosUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null);
        
        /// <summary>
        /// {{{maquineta_resource_listar_tipos_maquinetas}}}
        /// </summary>
        /// <remarks>
        /// {{{maquineta_resource_listar_tipos_maquinetas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        PageCampoCodificadoDescricaoResponse ListarTiposMaquinetasUsingGET (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{maquineta_resource_listar_tipos_maquinetas}}}
        /// </summary>
        /// <remarks>
        /// {{{maquineta_resource_listar_tipos_maquinetas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        ApiResponse<PageCampoCodificadoDescricaoResponse> ListarTiposMaquinetasUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{tipo_origem_comercial_resource_listar_tipos_origens_comerciais}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_origem_comercial_resource_listar_tipos_origens_comerciais_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{tipo_origem_comercial_request_nome_value}}} (optional)</param>
        /// <returns>PageTipoOrigemComercialResponse</returns>
        PageTipoOrigemComercialResponse ListarTiposOrigensComerciaisUsingGET (List<string> sort = null, int? page = null, int? limit = null, string nome = null);
  
        /// <summary>
        /// {{{tipo_origem_comercial_resource_listar_tipos_origens_comerciais}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_origem_comercial_resource_listar_tipos_origens_comerciais_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{tipo_origem_comercial_request_nome_value}}} (optional)</param>
        /// <returns>ApiResponse of PageTipoOrigemComercialResponse</returns>
        ApiResponse<PageTipoOrigemComercialResponse> ListarTiposOrigensComerciaisUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null);
        
        /// <summary>
        /// {{{terminal_resource_listar_tipos_terminais}}}
        /// </summary>
        /// <remarks>
        /// {{{terminal_resource_listar_tipos_terminais_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>PageTipoTerminalResponse</returns>
        PageTipoTerminalResponse ListarTiposTerminaisUsingGET (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{terminal_resource_listar_tipos_terminais}}}
        /// </summary>
        /// <remarks>
        /// {{{terminal_resource_listar_tipos_terminais_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of PageTipoTerminalResponse</returns>
        ApiResponse<PageTipoTerminalResponse> ListarTiposTerminaisUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{estabelecimento_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{estabelecimento_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{estabelecimento_request_id_value}}} (optional)</param>
        /// <param name="idGrupoEconomico">{{{estabelecimento_request_id_grupo_economico_value}}} (optional)</param>
        /// <param name="numeroReceitaFederal">{{{estabelecimento_request_numero_receita_federal_value}}} (optional)</param>
        /// <param name="nome">{{{estabelecimento_request_nome_value}}} (optional)</param>
        /// <param name="descricao">{{{estabelecimento_request_descricao_value}}} (optional)</param>
        /// <param name="nomeFantasia">{{{estabelecimento_request_nome_fantasia_value}}} (optional)</param>
        /// <param name="cep">{{{estabelecimento_request_cep_value}}} (optional)</param>
        /// <param name="nomeLogradouro">{{{estabelecimento_request_nome_logradouro_value}}} (optional)</param>
        /// <param name="numeroEndereco">{{{estabelecimento_request_numero_endereco_value}}} (optional)</param>
        /// <param name="complemento">{{{estabelecimento_request_complemento_value}}} (optional)</param>
        /// <param name="bairro">{{{estabelecimento_request_bairro_value}}} (optional)</param>
        /// <param name="cidade">{{{estabelecimento_request_cidade_value}}} (optional)</param>
        /// <param name="uf">{{{estabelecimento_request_uf_value}}} (optional)</param>
        /// <param name="pais">{{{estabelecimento_request_pais_value}}} (optional)</param>
        /// <param name="dataCadastramento">{{{estabelecimento_request_data_cadastramento_value}}} (optional)</param>
        /// <param name="contato">{{{estabelecimento_request_contato_value}}} (optional)</param>
        /// <param name="email">{{{estabelecimento_request_email_value}}} (optional)</param>
        /// <param name="flagArquivoSecrFazenda">{{{estabelecimento_request_flag_arquivo_secr_fazenda_value}}} (optional)</param>
        /// <param name="flagCartaoDigitado">{{{estabelecimento_request_flag_cartao_digitado_value}}} (optional)</param>
        /// <param name="inativo">{{{estabelecimento_request_inativo_value}}} (optional)</param>
        /// <param name="idPais">{{{estabelecimento_request_id_pais_value}}} (optional)</param>
        /// <param name="mcc">{{{estabelecimento_request_mcc_value}}} (optional)</param>
        /// <param name="idTipoEstabelecimento">{{{estabelecimento_request_id_tipo_estabelecimento_value}}} (optional)</param>
        /// <param name="correspondencia">{{{estabelecimento_request_correspondencia_value}}} (optional)</param>
        /// <param name="idMoeda">{{{estabelecimento_request_id_moeda_value}}} (optional)</param>
        /// <param name="tipoPagamento">{{{estabelecimento_request_tipo_pagamento_value}}} (optional)</param>
        /// <param name="numeroEstabelecimento">{{{estabelecimento_request_numero_estabelecimento_value}}} (optional)</param>
        /// <param name="cep2">{{{estabelecimento_request_cep2_value}}} (optional)</param>
        /// <param name="nomeLogradouro2">{{{estabelecimento_request_nome_logradouro2_value}}} (optional)</param>
        /// <param name="numeroEndereco2">{{{estabelecimento_request_numero_endereco2_value}}} (optional)</param>
        /// <param name="complemento2">{{{estabelecimento_request_complemento2_value}}} (optional)</param>
        /// <param name="bairro2">{{{estabelecimento_request_bairro2_value}}} (optional)</param>
        /// <param name="cidade2">{{{estabelecimento_request_cidade2_value}}} (optional)</param>
        /// <param name="uf2">{{{estabelecimento_request_uf2_value}}} (optional)</param>
        /// <param name="flagMatriz">{{{estabelecimento_request_flag_matriz_value}}} (optional)</param>
        /// <returns>PageEstabelecimentoResponse</returns>
        PageEstabelecimentoResponse ListarUsingGET22 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idGrupoEconomico = null, string numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, int? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null, long? idPais = null, long? mcc = null, long? idTipoEstabelecimento = null, int? correspondencia = null, long? idMoeda = null, string tipoPagamento = null, string numeroEstabelecimento = null, string cep2 = null, string nomeLogradouro2 = null, int? numeroEndereco2 = null, string complemento2 = null, string bairro2 = null, string cidade2 = null, string uf2 = null, int? flagMatriz = null);
  
        /// <summary>
        /// {{{estabelecimento_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{estabelecimento_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{estabelecimento_request_id_value}}} (optional)</param>
        /// <param name="idGrupoEconomico">{{{estabelecimento_request_id_grupo_economico_value}}} (optional)</param>
        /// <param name="numeroReceitaFederal">{{{estabelecimento_request_numero_receita_federal_value}}} (optional)</param>
        /// <param name="nome">{{{estabelecimento_request_nome_value}}} (optional)</param>
        /// <param name="descricao">{{{estabelecimento_request_descricao_value}}} (optional)</param>
        /// <param name="nomeFantasia">{{{estabelecimento_request_nome_fantasia_value}}} (optional)</param>
        /// <param name="cep">{{{estabelecimento_request_cep_value}}} (optional)</param>
        /// <param name="nomeLogradouro">{{{estabelecimento_request_nome_logradouro_value}}} (optional)</param>
        /// <param name="numeroEndereco">{{{estabelecimento_request_numero_endereco_value}}} (optional)</param>
        /// <param name="complemento">{{{estabelecimento_request_complemento_value}}} (optional)</param>
        /// <param name="bairro">{{{estabelecimento_request_bairro_value}}} (optional)</param>
        /// <param name="cidade">{{{estabelecimento_request_cidade_value}}} (optional)</param>
        /// <param name="uf">{{{estabelecimento_request_uf_value}}} (optional)</param>
        /// <param name="pais">{{{estabelecimento_request_pais_value}}} (optional)</param>
        /// <param name="dataCadastramento">{{{estabelecimento_request_data_cadastramento_value}}} (optional)</param>
        /// <param name="contato">{{{estabelecimento_request_contato_value}}} (optional)</param>
        /// <param name="email">{{{estabelecimento_request_email_value}}} (optional)</param>
        /// <param name="flagArquivoSecrFazenda">{{{estabelecimento_request_flag_arquivo_secr_fazenda_value}}} (optional)</param>
        /// <param name="flagCartaoDigitado">{{{estabelecimento_request_flag_cartao_digitado_value}}} (optional)</param>
        /// <param name="inativo">{{{estabelecimento_request_inativo_value}}} (optional)</param>
        /// <param name="idPais">{{{estabelecimento_request_id_pais_value}}} (optional)</param>
        /// <param name="mcc">{{{estabelecimento_request_mcc_value}}} (optional)</param>
        /// <param name="idTipoEstabelecimento">{{{estabelecimento_request_id_tipo_estabelecimento_value}}} (optional)</param>
        /// <param name="correspondencia">{{{estabelecimento_request_correspondencia_value}}} (optional)</param>
        /// <param name="idMoeda">{{{estabelecimento_request_id_moeda_value}}} (optional)</param>
        /// <param name="tipoPagamento">{{{estabelecimento_request_tipo_pagamento_value}}} (optional)</param>
        /// <param name="numeroEstabelecimento">{{{estabelecimento_request_numero_estabelecimento_value}}} (optional)</param>
        /// <param name="cep2">{{{estabelecimento_request_cep2_value}}} (optional)</param>
        /// <param name="nomeLogradouro2">{{{estabelecimento_request_nome_logradouro2_value}}} (optional)</param>
        /// <param name="numeroEndereco2">{{{estabelecimento_request_numero_endereco2_value}}} (optional)</param>
        /// <param name="complemento2">{{{estabelecimento_request_complemento2_value}}} (optional)</param>
        /// <param name="bairro2">{{{estabelecimento_request_bairro2_value}}} (optional)</param>
        /// <param name="cidade2">{{{estabelecimento_request_cidade2_value}}} (optional)</param>
        /// <param name="uf2">{{{estabelecimento_request_uf2_value}}} (optional)</param>
        /// <param name="flagMatriz">{{{estabelecimento_request_flag_matriz_value}}} (optional)</param>
        /// <returns>ApiResponse of PageEstabelecimentoResponse</returns>
        ApiResponse<PageEstabelecimentoResponse> ListarUsingGET22WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idGrupoEconomico = null, string numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, int? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null, long? idPais = null, long? mcc = null, long? idTipoEstabelecimento = null, int? correspondencia = null, long? idMoeda = null, string tipoPagamento = null, string numeroEstabelecimento = null, string cep2 = null, string nomeLogradouro2 = null, int? numeroEndereco2 = null, string complemento2 = null, string bairro2 = null, string cidade2 = null, string uf2 = null, int? flagMatriz = null);
        
        /// <summary>
        /// {{{grupo_economico_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{grupo_economico_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="razaoSocial">{{{grupo_economico_request_razao_social_value}}} (optional)</param>
        /// <param name="nomeCredor">{{{grupo_economico_request_nome_credor_value}}} (optional)</param>
        /// <param name="numeroReceitaFederal">{{{grupo_economico_request_numero_receita_federal_value}}} (optional)</param>
        /// <param name="inscricaoEstadual">{{{grupo_economico_request_inscricao_estadual_value}}} (optional)</param>
        /// <param name="contato">{{{grupo_economico_request_contato_value}}} (optional)</param>
        /// <param name="banco">{{{grupo_economico_request_banco_value}}} (optional)</param>
        /// <param name="agencia">{{{grupo_economico_request_agencia_value}}} (optional)</param>
        /// <param name="digitoAgencia">{{{grupo_economico_request_digito_agencia_value}}} (optional)</param>
        /// <param name="contaCorrente">{{{grupo_economico_request_conta_corrente_value}}} (optional)</param>
        /// <param name="digitoContaCorrente">{{{grupo_economico_request_digito_conta_corrente_value}}} (optional)</param>
        /// <param name="periodicidade">{{{grupo_economico_request_periodicidade_value}}} (optional)</param>
        /// <param name="pagamentoSemanal">{{{grupo_economico_request_pagamento_semanal_value}}} (optional)</param>
        /// <param name="pagamentoMensal">{{{grupo_economico_request_pagamento_mensal_value}}} (optional)</param>
        /// <param name="pagamentoDecendialPrimeiro">{{{grupo_economico_request_pagamento_decendial_primeiro_value}}} (optional)</param>
        /// <param name="pagamentoDecendialSegundo">{{{grupo_economico_request_pagamento_decendial_segundo_value}}} (optional)</param>
        /// <param name="pagamentoDecendialTerceiro">{{{grupo_economico_request_pagamento_decendial_terceiro_value}}} (optional)</param>
        /// <param name="pagamentoQuinzenalPrimeiro">{{{grupo_economico_request_pagamento_quinzenal_primeiro_value}}} (optional)</param>
        /// <param name="pagamentoQuinzenalSegundo">{{{grupo_economico_request_pagamento_quinzenal_segundo_value}}} (optional)</param>
        /// <param name="percentualRAV">{{{grupo_economico_request_percentual_r_a_v_value}}} (optional)</param>
        /// <param name="recebeRAV">{{{grupo_economico_request_recebe_r_a_v_value}}} (optional)</param>
        /// <param name="percentualMultiplica">{{{grupo_economico_request_percentual_multiplica_value}}} (optional)</param>
        /// <param name="taxaAdm">{{{grupo_economico_request_taxa_adm_value}}} (optional)</param>
        /// <param name="taxaBanco">{{{grupo_economico_request_taxa_banco_value}}} (optional)</param>
        /// <param name="limiteRAV">{{{grupo_economico_request_limite_r_a_v_value}}} (optional)</param>
        /// <param name="idCredorRAV">{{{grupo_economico_request_id_credor_r_a_v_value}}} (optional)</param>
        /// <returns>PageGrupoEconomicoResponse</returns>
        PageGrupoEconomicoResponse ListarUsingGET25 (List<string> sort = null, int? page = null, int? limit = null, string razaoSocial = null, string nomeCredor = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, string periodicidade = null, string pagamentoSemanal = null, int? pagamentoMensal = null, int? pagamentoDecendialPrimeiro = null, int? pagamentoDecendialSegundo = null, int? pagamentoDecendialTerceiro = null, int? pagamentoQuinzenalPrimeiro = null, int? pagamentoQuinzenalSegundo = null, double? percentualRAV = null, string recebeRAV = null, double? percentualMultiplica = null, double? taxaAdm = null, double? taxaBanco = null, double? limiteRAV = null, long? idCredorRAV = null);
  
        /// <summary>
        /// {{{grupo_economico_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{grupo_economico_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="razaoSocial">{{{grupo_economico_request_razao_social_value}}} (optional)</param>
        /// <param name="nomeCredor">{{{grupo_economico_request_nome_credor_value}}} (optional)</param>
        /// <param name="numeroReceitaFederal">{{{grupo_economico_request_numero_receita_federal_value}}} (optional)</param>
        /// <param name="inscricaoEstadual">{{{grupo_economico_request_inscricao_estadual_value}}} (optional)</param>
        /// <param name="contato">{{{grupo_economico_request_contato_value}}} (optional)</param>
        /// <param name="banco">{{{grupo_economico_request_banco_value}}} (optional)</param>
        /// <param name="agencia">{{{grupo_economico_request_agencia_value}}} (optional)</param>
        /// <param name="digitoAgencia">{{{grupo_economico_request_digito_agencia_value}}} (optional)</param>
        /// <param name="contaCorrente">{{{grupo_economico_request_conta_corrente_value}}} (optional)</param>
        /// <param name="digitoContaCorrente">{{{grupo_economico_request_digito_conta_corrente_value}}} (optional)</param>
        /// <param name="periodicidade">{{{grupo_economico_request_periodicidade_value}}} (optional)</param>
        /// <param name="pagamentoSemanal">{{{grupo_economico_request_pagamento_semanal_value}}} (optional)</param>
        /// <param name="pagamentoMensal">{{{grupo_economico_request_pagamento_mensal_value}}} (optional)</param>
        /// <param name="pagamentoDecendialPrimeiro">{{{grupo_economico_request_pagamento_decendial_primeiro_value}}} (optional)</param>
        /// <param name="pagamentoDecendialSegundo">{{{grupo_economico_request_pagamento_decendial_segundo_value}}} (optional)</param>
        /// <param name="pagamentoDecendialTerceiro">{{{grupo_economico_request_pagamento_decendial_terceiro_value}}} (optional)</param>
        /// <param name="pagamentoQuinzenalPrimeiro">{{{grupo_economico_request_pagamento_quinzenal_primeiro_value}}} (optional)</param>
        /// <param name="pagamentoQuinzenalSegundo">{{{grupo_economico_request_pagamento_quinzenal_segundo_value}}} (optional)</param>
        /// <param name="percentualRAV">{{{grupo_economico_request_percentual_r_a_v_value}}} (optional)</param>
        /// <param name="recebeRAV">{{{grupo_economico_request_recebe_r_a_v_value}}} (optional)</param>
        /// <param name="percentualMultiplica">{{{grupo_economico_request_percentual_multiplica_value}}} (optional)</param>
        /// <param name="taxaAdm">{{{grupo_economico_request_taxa_adm_value}}} (optional)</param>
        /// <param name="taxaBanco">{{{grupo_economico_request_taxa_banco_value}}} (optional)</param>
        /// <param name="limiteRAV">{{{grupo_economico_request_limite_r_a_v_value}}} (optional)</param>
        /// <param name="idCredorRAV">{{{grupo_economico_request_id_credor_r_a_v_value}}} (optional)</param>
        /// <returns>ApiResponse of PageGrupoEconomicoResponse</returns>
        ApiResponse<PageGrupoEconomicoResponse> ListarUsingGET25WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string razaoSocial = null, string nomeCredor = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, string periodicidade = null, string pagamentoSemanal = null, int? pagamentoMensal = null, int? pagamentoDecendialPrimeiro = null, int? pagamentoDecendialSegundo = null, int? pagamentoDecendialTerceiro = null, int? pagamentoQuinzenalPrimeiro = null, int? pagamentoQuinzenalSegundo = null, double? percentualRAV = null, string recebeRAV = null, double? percentualMultiplica = null, double? taxaAdm = null, double? taxaBanco = null, double? limiteRAV = null, long? idCredorRAV = null);
        
        /// <summary>
        /// {{{grupo_origem_comercial_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{grupo_origem_comercial_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{grupo_origem_comercial_request_nome_value}}} (optional)</param>
        /// <returns>PageGrupoOrigemComercialResponse</returns>
        PageGrupoOrigemComercialResponse ListarUsingGET26 (List<string> sort = null, int? page = null, int? limit = null, string nome = null);
  
        /// <summary>
        /// {{{grupo_origem_comercial_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{grupo_origem_comercial_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{grupo_origem_comercial_request_nome_value}}} (optional)</param>
        /// <returns>ApiResponse of PageGrupoOrigemComercialResponse</returns>
        ApiResponse<PageGrupoOrigemComercialResponse> ListarUsingGET26WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null);
        
        /// <summary>
        /// {{{maquineta_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{maquineta_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{maquineta_request_id_estabelecimento_value}}} (optional)</param>
        /// <returns>PageMaquinetaResponse</returns>
        PageMaquinetaResponse ListarUsingGET28 (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null);
  
        /// <summary>
        /// {{{maquineta_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{maquineta_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{maquineta_request_id_estabelecimento_value}}} (optional)</param>
        /// <returns>ApiResponse of PageMaquinetaResponse</returns>
        ApiResponse<PageMaquinetaResponse> ListarUsingGET28WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null);
        
        /// <summary>
        /// {{{moeda_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{moeda_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="codigoMoeda">{{{moeda_request_codigo_moeda_value}}} (optional)</param>
        /// <param name="simbolo">{{{moeda_request_simbolo_value}}} (optional)</param>
        /// <param name="descricao">{{{moeda_request_descricao_value}}} (optional)</param>
        /// <returns>PageMoedaResponse</returns>
        PageMoedaResponse ListarUsingGET29 (List<string> sort = null, int? page = null, int? limit = null, string codigoMoeda = null, string simbolo = null, string descricao = null);
  
        /// <summary>
        /// {{{moeda_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{moeda_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="codigoMoeda">{{{moeda_request_codigo_moeda_value}}} (optional)</param>
        /// <param name="simbolo">{{{moeda_request_simbolo_value}}} (optional)</param>
        /// <param name="descricao">{{{moeda_request_descricao_value}}} (optional)</param>
        /// <returns>ApiResponse of PageMoedaResponse</returns>
        ApiResponse<PageMoedaResponse> ListarUsingGET29WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string codigoMoeda = null, string simbolo = null, string descricao = null);
        
        /// <summary>
        /// {{{operacao_credor_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{operacao_credor_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idOperacao">{{{operacao_credor_request_id_operacao_value}}} (optional)</param>
        /// <param name="idCredor">{{{operacao_credor_request_id_credor_value}}} (optional)</param>
        /// <param name="idProduto">{{{operacao_credor_request_id_produto_value}}} (optional)</param>
        /// <returns>PageOperacaoCredorResponse</returns>
        PageOperacaoCredorResponse ListarUsingGET30 (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, long? idCredor = null, long? idProduto = null);
  
        /// <summary>
        /// {{{operacao_credor_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{operacao_credor_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idOperacao">{{{operacao_credor_request_id_operacao_value}}} (optional)</param>
        /// <param name="idCredor">{{{operacao_credor_request_id_credor_value}}} (optional)</param>
        /// <param name="idProduto">{{{operacao_credor_request_id_produto_value}}} (optional)</param>
        /// <returns>ApiResponse of PageOperacaoCredorResponse</returns>
        ApiResponse<PageOperacaoCredorResponse> ListarUsingGET30WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, long? idCredor = null, long? idProduto = null);
        
        /// <summary>
        /// {{{telefone_estabelecimento_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{telefone_estabelecimento_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{telefone_estabelecimento_request_id_estabelecimento_value}}} (optional)</param>
        /// <returns>PageTelefoneEstabelecimentoResponse</returns>
        PageTelefoneEstabelecimentoResponse ListarUsingGET44 (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null);
  
        /// <summary>
        /// {{{telefone_estabelecimento_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{telefone_estabelecimento_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{telefone_estabelecimento_request_id_estabelecimento_value}}} (optional)</param>
        /// <returns>ApiResponse of PageTelefoneEstabelecimentoResponse</returns>
        ApiResponse<PageTelefoneEstabelecimentoResponse> ListarUsingGET44WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null);
        
        /// <summary>
        /// {{{terminal_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{terminal_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{terminal_request_id_value}}} (optional)</param>
        /// <param name="terminal">{{{terminal_request_terminal_value}}} (optional)</param>
        /// <param name="numeroEstabelecimento">{{{terminal_request_numero_estabelecimento_value}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{terminal_request_id_estabelecimento_value}}} (optional)</param>
        /// <returns>PageTerminalResponse</returns>
        PageTerminalResponse ListarUsingGET46 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null);
  
        /// <summary>
        /// {{{terminal_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{terminal_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{terminal_request_id_value}}} (optional)</param>
        /// <param name="terminal">{{{terminal_request_terminal_value}}} (optional)</param>
        /// <param name="numeroEstabelecimento">{{{terminal_request_numero_estabelecimento_value}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{terminal_request_id_estabelecimento_value}}} (optional)</param>
        /// <returns>ApiResponse of PageTerminalResponse</returns>
        ApiResponse<PageTerminalResponse> ListarUsingGET46WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null);
        
        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_estabelecimento_adquirente_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idAdquirente">{{{vinculo_estabelecimento_adquirente_request_id_adquirente_value}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{vinculo_estabelecimento_adquirente_request_id_estabelecimento_value}}} (optional)</param>
        /// <param name="codigoEstabelecimentoAdquirente">{{{vinculo_estabelecimento_adquirente_request_codigo_estabelecimento_adquirente_value}}} (optional)</param>
        /// <returns>PageVinculoEstabelecimentoAdquirenteResponse</returns>
        PageVinculoEstabelecimentoAdquirenteResponse ListarUsingGET58 (List<string> sort = null, int? page = null, int? limit = null, long? idAdquirente = null, long? idEstabelecimento = null, string codigoEstabelecimentoAdquirente = null);
  
        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_estabelecimento_adquirente_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idAdquirente">{{{vinculo_estabelecimento_adquirente_request_id_adquirente_value}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{vinculo_estabelecimento_adquirente_request_id_estabelecimento_value}}} (optional)</param>
        /// <param name="codigoEstabelecimentoAdquirente">{{{vinculo_estabelecimento_adquirente_request_codigo_estabelecimento_adquirente_value}}} (optional)</param>
        /// <returns>ApiResponse of PageVinculoEstabelecimentoAdquirenteResponse</returns>
        ApiResponse<PageVinculoEstabelecimentoAdquirenteResponse> ListarUsingGET58WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idAdquirente = null, long? idEstabelecimento = null, string codigoEstabelecimentoAdquirente = null);
        
        /// <summary>
        /// {{{vinculo_operacao_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_operacao_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_operacao_resource_listar_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idProduto">{{{vinculo_operacao_request_id_produto_value}}} (optional)</param>
        /// <param name="idOperacao">{{{vinculo_operacao_request_id_operacao_value}}} (optional)</param>
        /// <param name="codigoMCC">{{{vinculo_operacao_request_codigo_m_c_c_value}}} (optional)</param>
        /// <returns>PageVinculoOperacaoResponse</returns>
        PageVinculoOperacaoResponse ListarUsingGET59 (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOperacao = null, int? codigoMCC = null);
  
        /// <summary>
        /// {{{vinculo_operacao_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_operacao_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_operacao_resource_listar_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idProduto">{{{vinculo_operacao_request_id_produto_value}}} (optional)</param>
        /// <param name="idOperacao">{{{vinculo_operacao_request_id_operacao_value}}} (optional)</param>
        /// <param name="codigoMCC">{{{vinculo_operacao_request_codigo_m_c_c_value}}} (optional)</param>
        /// <returns>ApiResponse of PageVinculoOperacaoResponse</returns>
        ApiResponse<PageVinculoOperacaoResponse> ListarUsingGET59WithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOperacao = null, int? codigoMCC = null);
        
        /// <summary>
        /// {{{maquineta_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{maquineta_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maquinetaPersist">maquinetaPersist</param>
        /// <returns>MaquinetaResponse</returns>
        MaquinetaResponse SalvarUsingPOST17 (MaquinetaPersist maquinetaPersist);
  
        /// <summary>
        /// {{{maquineta_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{maquineta_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maquinetaPersist">maquinetaPersist</param>
        /// <returns>ApiResponse of MaquinetaResponse</returns>
        ApiResponse<MaquinetaResponse> SalvarUsingPOST17WithHttpInfo (MaquinetaPersist maquinetaPersist);
        
        /// <summary>
        /// {{{operacao_credor_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{operacao_credor_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operacaoCredorPersist">operacaoCredorPersist</param>
        /// <returns>OperacaoCredorResponse</returns>
        OperacaoCredorResponse SalvarUsingPOST18 (OperacaoCredorPersist operacaoCredorPersist);
  
        /// <summary>
        /// {{{operacao_credor_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{operacao_credor_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operacaoCredorPersist">operacaoCredorPersist</param>
        /// <returns>ApiResponse of OperacaoCredorResponse</returns>
        ApiResponse<OperacaoCredorResponse> SalvarUsingPOST18WithHttpInfo (OperacaoCredorPersist operacaoCredorPersist);
        
        /// <summary>
        /// {{{telefone_estabelecimento_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{telefone_estabelecimento_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="telefoneEstabelecimentoPersist">telefoneEstabelecimentoPersist</param>
        /// <returns>TelefoneEstabelecimentoResponse</returns>
        TelefoneEstabelecimentoResponse SalvarUsingPOST23 (TelefoneEstabelecimentoPersist telefoneEstabelecimentoPersist);
  
        /// <summary>
        /// {{{telefone_estabelecimento_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{telefone_estabelecimento_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="telefoneEstabelecimentoPersist">telefoneEstabelecimentoPersist</param>
        /// <returns>ApiResponse of TelefoneEstabelecimentoResponse</returns>
        ApiResponse<TelefoneEstabelecimentoResponse> SalvarUsingPOST23WithHttpInfo (TelefoneEstabelecimentoPersist telefoneEstabelecimentoPersist);
        
        /// <summary>
        /// {{{terminal_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{terminal_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminalPersist">terminalPersist</param>
        /// <returns>TerminalResponse</returns>
        TerminalResponse SalvarUsingPOST25 (TerminalPersist terminalPersist);
  
        /// <summary>
        /// {{{terminal_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{terminal_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminalPersist">terminalPersist</param>
        /// <returns>ApiResponse of TerminalResponse</returns>
        ApiResponse<TerminalResponse> SalvarUsingPOST25WithHttpInfo (TerminalPersist terminalPersist);
        
        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_estabelecimento_adquirente_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vinculoEstabelecimentoAdquirentePersist">vinculoEstabelecimentoAdquirentePersist</param>
        /// <returns>VinculoEstabelecimentoAdquirenteResponse</returns>
        VinculoEstabelecimentoAdquirenteResponse SalvarUsingPOST29 (VinculoEstabelecimentoAdquirentePersist vinculoEstabelecimentoAdquirentePersist);
  
        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_estabelecimento_adquirente_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vinculoEstabelecimentoAdquirentePersist">vinculoEstabelecimentoAdquirentePersist</param>
        /// <returns>ApiResponse of VinculoEstabelecimentoAdquirenteResponse</returns>
        ApiResponse<VinculoEstabelecimentoAdquirenteResponse> SalvarUsingPOST29WithHttpInfo (VinculoEstabelecimentoAdquirentePersist vinculoEstabelecimentoAdquirentePersist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{origem_comercial_resource_alterar_origem_comercial}}}
        /// </summary>
        /// <remarks>
        /// {{{origem_comercial_resource_alterar_origem_comercial_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{origem_comercial_resource_alterar_origem_comercial_param_id}}}</param>
        /// <param name="origemComercialUpdate">origemComercialUpdate</param>
        /// <returns>Task of OrigemComercialResponse</returns>
        System.Threading.Tasks.Task<OrigemComercialResponse> AlterarOrigemComercialUsingPUTAsync (long? id, OrigemComercialUpdate origemComercialUpdate);

        /// <summary>
        /// {{{origem_comercial_resource_alterar_origem_comercial}}}
        /// </summary>
        /// <remarks>
        /// {{{origem_comercial_resource_alterar_origem_comercial_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{origem_comercial_resource_alterar_origem_comercial_param_id}}}</param>
        /// <param name="origemComercialUpdate">origemComercialUpdate</param>
        /// <returns>Task of ApiResponse (OrigemComercialResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrigemComercialResponse>> AlterarOrigemComercialUsingPUTAsyncWithHttpInfo (long? id, OrigemComercialUpdate origemComercialUpdate);
        
        /// <summary>
        /// {{{operacao_credor_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{operacao_credor_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{operacao_credor_resource_alterar_param_id}}}</param>
        /// <param name="operacaoCredorUpdate">operacaoCredorUpdate</param>
        /// <returns>Task of OperacaoCredorResponse</returns>
        System.Threading.Tasks.Task<OperacaoCredorResponse> AlterarUsingPUT10Async (long? id, OperacaoCredorUpdate operacaoCredorUpdate);

        /// <summary>
        /// {{{operacao_credor_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{operacao_credor_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{operacao_credor_resource_alterar_param_id}}}</param>
        /// <param name="operacaoCredorUpdate">operacaoCredorUpdate</param>
        /// <returns>Task of ApiResponse (OperacaoCredorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperacaoCredorResponse>> AlterarUsingPUT10AsyncWithHttpInfo (long? id, OperacaoCredorUpdate operacaoCredorUpdate);
        
        /// <summary>
        /// {{{telefone_estabelecimento_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{telefone_estabelecimento_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{telefone_estabelecimento_resource_alterar_param_id}}}</param>
        /// <param name="telefoneEstabelecimentoUpdate">telefoneEstabelecimentoUpdate</param>
        /// <returns>Task of TelefoneEstabelecimentoResponse</returns>
        System.Threading.Tasks.Task<TelefoneEstabelecimentoResponse> AlterarUsingPUT14Async (long? id, TelefoneEstabelecimentoUpdate telefoneEstabelecimentoUpdate);

        /// <summary>
        /// {{{telefone_estabelecimento_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{telefone_estabelecimento_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{telefone_estabelecimento_resource_alterar_param_id}}}</param>
        /// <param name="telefoneEstabelecimentoUpdate">telefoneEstabelecimentoUpdate</param>
        /// <returns>Task of ApiResponse (TelefoneEstabelecimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TelefoneEstabelecimentoResponse>> AlterarUsingPUT14AsyncWithHttpInfo (long? id, TelefoneEstabelecimentoUpdate telefoneEstabelecimentoUpdate);
        
        /// <summary>
        /// {{{terminal_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{terminal_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{terminal_resource_alterar_param_id}}}</param>
        /// <param name="terminalUpdate">terminalUpdate</param>
        /// <returns>Task of TerminalResponse</returns>
        System.Threading.Tasks.Task<TerminalResponse> AlterarUsingPUT16Async (long? id, TerminalUpdateValue terminalUpdate);

        /// <summary>
        /// {{{terminal_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{terminal_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{terminal_resource_alterar_param_id}}}</param>
        /// <param name="terminalUpdate">terminalUpdate</param>
        /// <returns>Task of ApiResponse (TerminalResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TerminalResponse>> AlterarUsingPUT16AsyncWithHttpInfo (long? id, TerminalUpdateValue terminalUpdate);
        
        /// <summary>
        /// {{{estabelecimento_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{estabelecimento_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{estabelecimento_resource_alterar_param_id_estabelecimento}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of EstabelecimentoResponse</returns>
        System.Threading.Tasks.Task<EstabelecimentoResponse> AlterarUsingPUT5Async (long? id, EstabelecimentoUpdate update);

        /// <summary>
        /// {{{estabelecimento_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{estabelecimento_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{estabelecimento_resource_alterar_param_id_estabelecimento}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (EstabelecimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EstabelecimentoResponse>> AlterarUsingPUT5AsyncWithHttpInfo (long? id, EstabelecimentoUpdate update);
        
        /// <summary>
        /// {{{grupo_economico_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{grupo_economico_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{grupo_economico_resource_alterar_param_id}}}</param>
        /// <param name="grupoEconomicoDTO">grupoEconomicoDTO</param>
        /// <returns>Task of GrupoEconomicoResponse</returns>
        System.Threading.Tasks.Task<GrupoEconomicoResponse> AlterarUsingPUT7Async (long? id, GrupoEconomicoDTO grupoEconomicoDTO);

        /// <summary>
        /// {{{grupo_economico_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{grupo_economico_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{grupo_economico_resource_alterar_param_id}}}</param>
        /// <param name="grupoEconomicoDTO">grupoEconomicoDTO</param>
        /// <returns>Task of ApiResponse (GrupoEconomicoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GrupoEconomicoResponse>> AlterarUsingPUT7AsyncWithHttpInfo (long? id, GrupoEconomicoDTO grupoEconomicoDTO);
        
        /// <summary>
        /// {{{maquineta_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{maquineta_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{maquineta_resource_alterar_param_id}}}</param>
        /// <param name="maquinetaUpdate">maquinetaUpdate</param>
        /// <returns>Task of MaquinetaResponse</returns>
        System.Threading.Tasks.Task<MaquinetaResponse> AlterarUsingPUT9Async (long? id, MaquinetaUpdate maquinetaUpdate);

        /// <summary>
        /// {{{maquineta_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{maquineta_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{maquineta_resource_alterar_param_id}}}</param>
        /// <param name="maquinetaUpdate">maquinetaUpdate</param>
        /// <returns>Task of ApiResponse (MaquinetaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MaquinetaResponse>> AlterarUsingPUT9AsyncWithHttpInfo (long? id, MaquinetaUpdate maquinetaUpdate);
        
        /// <summary>
        /// {{{origem_comercial_resource_cadastrar_origem_comercial}}}
        /// </summary>
        /// <remarks>
        /// {{{origem_comercial_resource_cadastrar_origem_comercial_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origemComercialPersist">origemComercialPersist</param>
        /// <returns>Task of OrigemComercialResponse</returns>
        System.Threading.Tasks.Task<OrigemComercialResponse> CadastrarOrigemComercialUsingPOSTAsync (OrigemComercialPersist origemComercialPersist);

        /// <summary>
        /// {{{origem_comercial_resource_cadastrar_origem_comercial}}}
        /// </summary>
        /// <remarks>
        /// {{{origem_comercial_resource_cadastrar_origem_comercial_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origemComercialPersist">origemComercialPersist</param>
        /// <returns>Task of ApiResponse (OrigemComercialResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrigemComercialResponse>> CadastrarOrigemComercialUsingPOSTAsyncWithHttpInfo (OrigemComercialPersist origemComercialPersist);
        
        /// <summary>
        /// {{{estabelecimento_resource_cadastrar}}}
        /// </summary>
        /// <remarks>
        /// {{{estabelecimento_resource_cadastrar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of EstabelecimentoResponse</returns>
        System.Threading.Tasks.Task<EstabelecimentoResponse> CadastrarUsingPOST3Async (EstabelecimentoPersist persist);

        /// <summary>
        /// {{{estabelecimento_resource_cadastrar}}}
        /// </summary>
        /// <remarks>
        /// {{{estabelecimento_resource_cadastrar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (EstabelecimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EstabelecimentoResponse>> CadastrarUsingPOST3AsyncWithHttpInfo (EstabelecimentoPersist persist);
        
        /// <summary>
        /// {{{grupo_economico_resource_cadastrar}}}
        /// </summary>
        /// <remarks>
        /// {{{grupo_economico_resource_cadastrar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoEconomicoDTO">GrupoEconomicoDTO</param>
        /// <returns>Task of GrupoEconomicoResponse</returns>
        System.Threading.Tasks.Task<GrupoEconomicoResponse> CadastrarUsingPOST4Async (GrupoEconomicoDTO grupoEconomicoDTO);

        /// <summary>
        /// {{{grupo_economico_resource_cadastrar}}}
        /// </summary>
        /// <remarks>
        /// {{{grupo_economico_resource_cadastrar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoEconomicoDTO">GrupoEconomicoDTO</param>
        /// <returns>Task of ApiResponse (GrupoEconomicoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GrupoEconomicoResponse>> CadastrarUsingPOST4AsyncWithHttpInfo (GrupoEconomicoDTO grupoEconomicoDTO);
        
        /// <summary>
        /// {{{operacao_resource_consulta_operacao}}}
        /// </summary>
        /// <remarks>
        /// {{{operacao_resource_consulta_operacao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{operacao_resource_consulta_operacao_param_id_operacao}}}</param>
        /// <returns>Task of DetalheOperacaoResponse</returns>
        System.Threading.Tasks.Task<DetalheOperacaoResponse> ConsultaOperacaoUsingGETAsync (long? id);

        /// <summary>
        /// {{{operacao_resource_consulta_operacao}}}
        /// </summary>
        /// <remarks>
        /// {{{operacao_resource_consulta_operacao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{operacao_resource_consulta_operacao_param_id_operacao}}}</param>
        /// <returns>Task of ApiResponse (DetalheOperacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DetalheOperacaoResponse>> ConsultaOperacaoUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{origem_comercial_resource_consultar_origem_comercial}}}
        /// </summary>
        /// <remarks>
        /// {{{origem_comercial_resource_consultar_origem_comercial_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{origem_comercial_resource_consultar_origem_comercial_param_id}}}</param>
        /// <returns>Task of OrigemComercialResponse</returns>
        System.Threading.Tasks.Task<OrigemComercialResponse> ConsultarOrigemComercialUsingGETAsync (long? id);

        /// <summary>
        /// {{{origem_comercial_resource_consultar_origem_comercial}}}
        /// </summary>
        /// <remarks>
        /// {{{origem_comercial_resource_consultar_origem_comercial_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{origem_comercial_resource_consultar_origem_comercial_param_id}}}</param>
        /// <returns>Task of ApiResponse (OrigemComercialResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrigemComercialResponse>> ConsultarOrigemComercialUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{estabelecimento_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{estabelecimento_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{estabelecimento_resource_consultar_param_id_estabelecimento}}}</param>
        /// <returns>Task of EstabelecimentoResponse</returns>
        System.Threading.Tasks.Task<EstabelecimentoResponse> ConsultarUsingGET18Async (long? id);

        /// <summary>
        /// {{{estabelecimento_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{estabelecimento_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{estabelecimento_resource_consultar_param_id_estabelecimento}}}</param>
        /// <returns>Task of ApiResponse (EstabelecimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EstabelecimentoResponse>> ConsultarUsingGET18AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{grupo_economico_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{grupo_economico_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{grupo_economico_resource_consultar_param_id}}}</param>
        /// <returns>Task of GrupoEconomicoResponse</returns>
        System.Threading.Tasks.Task<GrupoEconomicoResponse> ConsultarUsingGET20Async (long? id);

        /// <summary>
        /// {{{grupo_economico_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{grupo_economico_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{grupo_economico_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (GrupoEconomicoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GrupoEconomicoResponse>> ConsultarUsingGET20AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{maquineta_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{maquineta_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{maquineta_resource_consultar_param_id}}}</param>
        /// <returns>Task of MaquinetaResponse</returns>
        System.Threading.Tasks.Task<MaquinetaResponse> ConsultarUsingGET22Async (long? id);

        /// <summary>
        /// {{{maquineta_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{maquineta_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{maquineta_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (MaquinetaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MaquinetaResponse>> ConsultarUsingGET22AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{operacao_credor_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{operacao_credor_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{operacao_credor_resource_consultar_param_id}}}</param>
        /// <returns>Task of OperacaoCredorResponse</returns>
        System.Threading.Tasks.Task<OperacaoCredorResponse> ConsultarUsingGET23Async (long? id);

        /// <summary>
        /// {{{operacao_credor_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{operacao_credor_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{operacao_credor_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (OperacaoCredorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperacaoCredorResponse>> ConsultarUsingGET23AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{telefone_estabelecimento_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{telefone_estabelecimento_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{telefone_estabelecimento_resource_consultar_param_id}}}</param>
        /// <returns>Task of TelefoneEstabelecimentoResponse</returns>
        System.Threading.Tasks.Task<TelefoneEstabelecimentoResponse> ConsultarUsingGET34Async (long? id);

        /// <summary>
        /// {{{telefone_estabelecimento_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{telefone_estabelecimento_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{telefone_estabelecimento_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (TelefoneEstabelecimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TelefoneEstabelecimentoResponse>> ConsultarUsingGET34AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{terminal_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{terminal_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{terminal_resource_consultar_param_id}}}</param>
        /// <returns>Task of TerminalResponse</returns>
        System.Threading.Tasks.Task<TerminalResponse> ConsultarUsingGET36Async (long? id);

        /// <summary>
        /// {{{terminal_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{terminal_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{terminal_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (TerminalResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TerminalResponse>> ConsultarUsingGET36AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_estabelecimento_adquirente_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_estabelecimento_adquirente_resource_consultar_param_id}}}</param>
        /// <returns>Task of VinculoEstabelecimentoAdquirenteResponse</returns>
        System.Threading.Tasks.Task<VinculoEstabelecimentoAdquirenteResponse> ConsultarUsingGET47Async (long? id);

        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_estabelecimento_adquirente_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_estabelecimento_adquirente_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (VinculoEstabelecimentoAdquirenteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<VinculoEstabelecimentoAdquirenteResponse>> ConsultarUsingGET47AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_desabilitar_vinculo}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_estabelecimento_adquirente_resource_desabilitar_vinculo_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_estabelecimento_adquirente_resource_desabilitar_vinculo_param_id}}}</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> DesabilitarVinculoUsingPOSTAsync (long? id);

        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_desabilitar_vinculo}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_estabelecimento_adquirente_resource_desabilitar_vinculo_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_estabelecimento_adquirente_resource_desabilitar_vinculo_param_id}}}</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DesabilitarVinculoUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{vinculo_operacao_resource_desabilitar_vinculo}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_operacao_resource_desabilitar_vinculo_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_operacao_resource_desabilitar_vinculo_param_id}}}</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> DesabilitarVinculoUsingPOST1Async (long? id, VinculoOperacaoPersist vinculoOperacaoPersist);

        /// <summary>
        /// {{{vinculo_operacao_resource_desabilitar_vinculo}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_operacao_resource_desabilitar_vinculo_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_operacao_resource_desabilitar_vinculo_param_id}}}</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DesabilitarVinculoUsingPOST1AsyncWithHttpInfo (long? id, VinculoOperacaoPersist vinculoOperacaoPersist);
        
        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_habilitar_vinculo}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_estabelecimento_adquirente_resource_habilitar_vinculo_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_estabelecimento_adquirente_resource_habilitar_vinculo_param_id}}}</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> HabilitarVinculoUsingPOSTAsync (long? id);

        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_habilitar_vinculo}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_estabelecimento_adquirente_resource_habilitar_vinculo_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_estabelecimento_adquirente_resource_habilitar_vinculo_param_id}}}</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> HabilitarVinculoUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{vinculo_operacao_resource_habilitar_vinculo}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_operacao_resource_habilitar_vinculo_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_operacao_resource_habilitar_vinculo_param_id}}}</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> HabilitarVinculoUsingPOST1Async (long? id, VinculoOperacaoPersist vinculoOperacaoPersist);

        /// <summary>
        /// {{{vinculo_operacao_resource_habilitar_vinculo}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_operacao_resource_habilitar_vinculo_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_operacao_resource_habilitar_vinculo_param_id}}}</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> HabilitarVinculoUsingPOST1AsyncWithHttpInfo (long? id, VinculoOperacaoPersist vinculoOperacaoPersist);
        
        /// <summary>
        /// {{{operacao_resource_lista_operacao}}}
        /// </summary>
        /// <remarks>
        /// {{{operacao_resource_lista_operacao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idOperacao">{{{operacao_request_id_operacao_value}}} (optional)</param>
        /// <param name="codigoProcessamento">{{{operacao_request_codigo_processamento_value}}} (optional)</param>
        /// <param name="nomeOperacao">{{{operacao_request_nome_operacao_value}}} (optional)</param>
        /// <returns>Task of PageOperacaoResponse</returns>
        System.Threading.Tasks.Task<PageOperacaoResponse> ListaOperacaoUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, string codigoProcessamento = null, string nomeOperacao = null);

        /// <summary>
        /// {{{operacao_resource_lista_operacao}}}
        /// </summary>
        /// <remarks>
        /// {{{operacao_resource_lista_operacao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idOperacao">{{{operacao_request_id_operacao_value}}} (optional)</param>
        /// <param name="codigoProcessamento">{{{operacao_request_codigo_processamento_value}}} (optional)</param>
        /// <param name="nomeOperacao">{{{operacao_request_nome_operacao_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageOperacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageOperacaoResponse>> ListaOperacaoUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, string codigoProcessamento = null, string nomeOperacao = null);
        
        /// <summary>
        /// {{{m_c_c_resource_listar_m_c_c}}}
        /// </summary>
        /// <remarks>
        /// {{{m_c_c_resource_listar_m_c_c_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageMCCResponse</returns>
        System.Threading.Tasks.Task<PageMCCResponse> ListarMCCUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{m_c_c_resource_listar_m_c_c}}}
        /// </summary>
        /// <remarks>
        /// {{{m_c_c_resource_listar_m_c_c_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageMCCResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageMCCResponse>> ListarMCCUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{origem_comercial_resource_listar_origens_comerciais}}}
        /// </summary>
        /// <remarks>
        /// {{{origem_comercial_resource_listar_origens_comerciais_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{origem_comercial_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{origem_comercial_request_nome_value}}} (optional)</param>
        /// <param name="status">{{{origem_comercial_request_status_value}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{origem_comercial_request_id_estabelecimento_value}}} (optional)</param>
        /// <param name="idProduto">{{{origem_comercial_request_id_produto_value}}} (optional)</param>
        /// <param name="descricao">{{{origem_comercial_request_descricao_value}}} (optional)</param>
        /// <param name="idTipoOrigemComercial">{{{origem_comercial_request_id_tipo_origem_comercial_value}}} (optional)</param>
        /// <param name="idGrupoOrigemComercial">{{{origem_comercial_request_id_grupo_origem_comercial_value}}} (optional)</param>
        /// <param name="flagPreAprovado">{{{origem_comercial_request_flag_pre_aprovado_value}}} (optional)</param>
        /// <param name="flagAprovacaoImediata">{{{origem_comercial_request_flag_aprovacao_imediata_value}}} (optional)</param>
        /// <param name="nomeFantasiaPlastico">{{{origem_comercial_request_nome_fantasia_plastico_value}}} (optional)</param>
        /// <param name="flagCartaoProvisorio">{{{origem_comercial_request_flag_cartao_provisorio_value}}} (optional)</param>
        /// <param name="flagCartaoDefinitivo">{{{origem_comercial_request_flag_cartao_definitivo_value}}} (optional)</param>
        /// <param name="usuario">{{{origem_comercial_request_usuario_value}}} (optional)</param>
        /// <param name="senha">{{{origem_comercial_request_senha_value}}} (optional)</param>
        /// <param name="flagOrigemExterna">{{{origem_comercial_request_flag_origem_externa_value}}} (optional)</param>
        /// <param name="flagModificado">{{{origem_comercial_request_flag_modificado_value}}} (optional)</param>
        /// <param name="flagEnviaFaturaUsuario">{{{origem_comercial_request_flag_envia_fatura_usuario_value}}} (optional)</param>
        /// <param name="flagCreditoFaturamento">{{{origem_comercial_request_flag_credito_faturamento_value}}} (optional)</param>
        /// <param name="flagConcedeLimiteProvisorio">{{{origem_comercial_request_flag_concede_limite_provisorio_value}}} (optional)</param>
        /// <param name="flagDigitalizarDoc">{{{origem_comercial_request_flag_digitalizar_doc_value}}} (optional)</param>
        /// <param name="flagEmbossingLoja">{{{origem_comercial_request_flag_embossing_loja_value}}} (optional)</param>
        /// <param name="flagConsultaPrevia">{{{origem_comercial_request_flag_consulta_previa_value}}} (optional)</param>
        /// <param name="tipoPessoa">{{{origem_comercial_request_tipo_pessoa_value}}} (optional)</param>
        /// <returns>Task of PageOrigemComercialResponse</returns>
        System.Threading.Tasks.Task<PageOrigemComercialResponse> ListarOrigensComerciaisUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null, long? idEstabelecimento = null, long? idProduto = null, string descricao = null, long? idTipoOrigemComercial = null, long? idGrupoOrigemComercial = null, bool? flagPreAprovado = null, bool? flagAprovacaoImediata = null, string nomeFantasiaPlastico = null, bool? flagCartaoProvisorio = null, bool? flagCartaoDefinitivo = null, string usuario = null, string senha = null, bool? flagOrigemExterna = null, bool? flagModificado = null, bool? flagEnviaFaturaUsuario = null, bool? flagCreditoFaturamento = null, bool? flagConcedeLimiteProvisorio = null, bool? flagDigitalizarDoc = null, bool? flagEmbossingLoja = null, bool? flagConsultaPrevia = null, string tipoPessoa = null);

        /// <summary>
        /// {{{origem_comercial_resource_listar_origens_comerciais}}}
        /// </summary>
        /// <remarks>
        /// {{{origem_comercial_resource_listar_origens_comerciais_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{origem_comercial_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{origem_comercial_request_nome_value}}} (optional)</param>
        /// <param name="status">{{{origem_comercial_request_status_value}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{origem_comercial_request_id_estabelecimento_value}}} (optional)</param>
        /// <param name="idProduto">{{{origem_comercial_request_id_produto_value}}} (optional)</param>
        /// <param name="descricao">{{{origem_comercial_request_descricao_value}}} (optional)</param>
        /// <param name="idTipoOrigemComercial">{{{origem_comercial_request_id_tipo_origem_comercial_value}}} (optional)</param>
        /// <param name="idGrupoOrigemComercial">{{{origem_comercial_request_id_grupo_origem_comercial_value}}} (optional)</param>
        /// <param name="flagPreAprovado">{{{origem_comercial_request_flag_pre_aprovado_value}}} (optional)</param>
        /// <param name="flagAprovacaoImediata">{{{origem_comercial_request_flag_aprovacao_imediata_value}}} (optional)</param>
        /// <param name="nomeFantasiaPlastico">{{{origem_comercial_request_nome_fantasia_plastico_value}}} (optional)</param>
        /// <param name="flagCartaoProvisorio">{{{origem_comercial_request_flag_cartao_provisorio_value}}} (optional)</param>
        /// <param name="flagCartaoDefinitivo">{{{origem_comercial_request_flag_cartao_definitivo_value}}} (optional)</param>
        /// <param name="usuario">{{{origem_comercial_request_usuario_value}}} (optional)</param>
        /// <param name="senha">{{{origem_comercial_request_senha_value}}} (optional)</param>
        /// <param name="flagOrigemExterna">{{{origem_comercial_request_flag_origem_externa_value}}} (optional)</param>
        /// <param name="flagModificado">{{{origem_comercial_request_flag_modificado_value}}} (optional)</param>
        /// <param name="flagEnviaFaturaUsuario">{{{origem_comercial_request_flag_envia_fatura_usuario_value}}} (optional)</param>
        /// <param name="flagCreditoFaturamento">{{{origem_comercial_request_flag_credito_faturamento_value}}} (optional)</param>
        /// <param name="flagConcedeLimiteProvisorio">{{{origem_comercial_request_flag_concede_limite_provisorio_value}}} (optional)</param>
        /// <param name="flagDigitalizarDoc">{{{origem_comercial_request_flag_digitalizar_doc_value}}} (optional)</param>
        /// <param name="flagEmbossingLoja">{{{origem_comercial_request_flag_embossing_loja_value}}} (optional)</param>
        /// <param name="flagConsultaPrevia">{{{origem_comercial_request_flag_consulta_previa_value}}} (optional)</param>
        /// <param name="tipoPessoa">{{{origem_comercial_request_tipo_pessoa_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageOrigemComercialResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageOrigemComercialResponse>> ListarOrigensComerciaisUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null, long? idEstabelecimento = null, long? idProduto = null, string descricao = null, long? idTipoOrigemComercial = null, long? idGrupoOrigemComercial = null, bool? flagPreAprovado = null, bool? flagAprovacaoImediata = null, string nomeFantasiaPlastico = null, bool? flagCartaoProvisorio = null, bool? flagCartaoDefinitivo = null, string usuario = null, string senha = null, bool? flagOrigemExterna = null, bool? flagModificado = null, bool? flagEnviaFaturaUsuario = null, bool? flagCreditoFaturamento = null, bool? flagConcedeLimiteProvisorio = null, bool? flagDigitalizarDoc = null, bool? flagEmbossingLoja = null, bool? flagConsultaPrevia = null, string tipoPessoa = null);
        
        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_listar_tipos_adquirentes}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_estabelecimento_adquirente_resource_listar_tipos_adquirentes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageEntidadeResponse</returns>
        System.Threading.Tasks.Task<PageEntidadeResponse> ListarTiposAdquirentesUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_listar_tipos_adquirentes}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_estabelecimento_adquirente_resource_listar_tipos_adquirentes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageEntidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageEntidadeResponse>> ListarTiposAdquirentesUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{tipo_estabelecimento_resource_listar_tipos_estabelecimentos}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_estabelecimento_resource_listar_tipos_estabelecimentos_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="descricao">{{{tipo_estabelecimento_request_descricao_value}}} (optional)</param>
        /// <returns>Task of PageTipoEstabelecimentoResponse</returns>
        System.Threading.Tasks.Task<PageTipoEstabelecimentoResponse> ListarTiposEstabelecimentosUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, string descricao = null);

        /// <summary>
        /// {{{tipo_estabelecimento_resource_listar_tipos_estabelecimentos}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_estabelecimento_resource_listar_tipos_estabelecimentos_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="descricao">{{{tipo_estabelecimento_request_descricao_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoEstabelecimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoEstabelecimentoResponse>> ListarTiposEstabelecimentosUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null);
        
        /// <summary>
        /// {{{maquineta_resource_listar_tipos_maquinetas}}}
        /// </summary>
        /// <remarks>
        /// {{{maquineta_resource_listar_tipos_maquinetas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarTiposMaquinetasUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{maquineta_resource_listar_tipos_maquinetas}}}
        /// </summary>
        /// <remarks>
        /// {{{maquineta_resource_listar_tipos_maquinetas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarTiposMaquinetasUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{tipo_origem_comercial_resource_listar_tipos_origens_comerciais}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_origem_comercial_resource_listar_tipos_origens_comerciais_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{tipo_origem_comercial_request_nome_value}}} (optional)</param>
        /// <returns>Task of PageTipoOrigemComercialResponse</returns>
        System.Threading.Tasks.Task<PageTipoOrigemComercialResponse> ListarTiposOrigensComerciaisUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, string nome = null);

        /// <summary>
        /// {{{tipo_origem_comercial_resource_listar_tipos_origens_comerciais}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_origem_comercial_resource_listar_tipos_origens_comerciais_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{tipo_origem_comercial_request_nome_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoOrigemComercialResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoOrigemComercialResponse>> ListarTiposOrigensComerciaisUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null);
        
        /// <summary>
        /// {{{terminal_resource_listar_tipos_terminais}}}
        /// </summary>
        /// <remarks>
        /// {{{terminal_resource_listar_tipos_terminais_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageTipoTerminalResponse</returns>
        System.Threading.Tasks.Task<PageTipoTerminalResponse> ListarTiposTerminaisUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{terminal_resource_listar_tipos_terminais}}}
        /// </summary>
        /// <remarks>
        /// {{{terminal_resource_listar_tipos_terminais_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoTerminalResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoTerminalResponse>> ListarTiposTerminaisUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{estabelecimento_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{estabelecimento_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{estabelecimento_request_id_value}}} (optional)</param>
        /// <param name="idGrupoEconomico">{{{estabelecimento_request_id_grupo_economico_value}}} (optional)</param>
        /// <param name="numeroReceitaFederal">{{{estabelecimento_request_numero_receita_federal_value}}} (optional)</param>
        /// <param name="nome">{{{estabelecimento_request_nome_value}}} (optional)</param>
        /// <param name="descricao">{{{estabelecimento_request_descricao_value}}} (optional)</param>
        /// <param name="nomeFantasia">{{{estabelecimento_request_nome_fantasia_value}}} (optional)</param>
        /// <param name="cep">{{{estabelecimento_request_cep_value}}} (optional)</param>
        /// <param name="nomeLogradouro">{{{estabelecimento_request_nome_logradouro_value}}} (optional)</param>
        /// <param name="numeroEndereco">{{{estabelecimento_request_numero_endereco_value}}} (optional)</param>
        /// <param name="complemento">{{{estabelecimento_request_complemento_value}}} (optional)</param>
        /// <param name="bairro">{{{estabelecimento_request_bairro_value}}} (optional)</param>
        /// <param name="cidade">{{{estabelecimento_request_cidade_value}}} (optional)</param>
        /// <param name="uf">{{{estabelecimento_request_uf_value}}} (optional)</param>
        /// <param name="pais">{{{estabelecimento_request_pais_value}}} (optional)</param>
        /// <param name="dataCadastramento">{{{estabelecimento_request_data_cadastramento_value}}} (optional)</param>
        /// <param name="contato">{{{estabelecimento_request_contato_value}}} (optional)</param>
        /// <param name="email">{{{estabelecimento_request_email_value}}} (optional)</param>
        /// <param name="flagArquivoSecrFazenda">{{{estabelecimento_request_flag_arquivo_secr_fazenda_value}}} (optional)</param>
        /// <param name="flagCartaoDigitado">{{{estabelecimento_request_flag_cartao_digitado_value}}} (optional)</param>
        /// <param name="inativo">{{{estabelecimento_request_inativo_value}}} (optional)</param>
        /// <param name="idPais">{{{estabelecimento_request_id_pais_value}}} (optional)</param>
        /// <param name="mcc">{{{estabelecimento_request_mcc_value}}} (optional)</param>
        /// <param name="idTipoEstabelecimento">{{{estabelecimento_request_id_tipo_estabelecimento_value}}} (optional)</param>
        /// <param name="correspondencia">{{{estabelecimento_request_correspondencia_value}}} (optional)</param>
        /// <param name="idMoeda">{{{estabelecimento_request_id_moeda_value}}} (optional)</param>
        /// <param name="tipoPagamento">{{{estabelecimento_request_tipo_pagamento_value}}} (optional)</param>
        /// <param name="numeroEstabelecimento">{{{estabelecimento_request_numero_estabelecimento_value}}} (optional)</param>
        /// <param name="cep2">{{{estabelecimento_request_cep2_value}}} (optional)</param>
        /// <param name="nomeLogradouro2">{{{estabelecimento_request_nome_logradouro2_value}}} (optional)</param>
        /// <param name="numeroEndereco2">{{{estabelecimento_request_numero_endereco2_value}}} (optional)</param>
        /// <param name="complemento2">{{{estabelecimento_request_complemento2_value}}} (optional)</param>
        /// <param name="bairro2">{{{estabelecimento_request_bairro2_value}}} (optional)</param>
        /// <param name="cidade2">{{{estabelecimento_request_cidade2_value}}} (optional)</param>
        /// <param name="uf2">{{{estabelecimento_request_uf2_value}}} (optional)</param>
        /// <param name="flagMatriz">{{{estabelecimento_request_flag_matriz_value}}} (optional)</param>
        /// <returns>Task of PageEstabelecimentoResponse</returns>
        System.Threading.Tasks.Task<PageEstabelecimentoResponse> ListarUsingGET22Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idGrupoEconomico = null, string numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, int? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null, long? idPais = null, long? mcc = null, long? idTipoEstabelecimento = null, int? correspondencia = null, long? idMoeda = null, string tipoPagamento = null, string numeroEstabelecimento = null, string cep2 = null, string nomeLogradouro2 = null, int? numeroEndereco2 = null, string complemento2 = null, string bairro2 = null, string cidade2 = null, string uf2 = null, int? flagMatriz = null);

        /// <summary>
        /// {{{estabelecimento_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{estabelecimento_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{estabelecimento_request_id_value}}} (optional)</param>
        /// <param name="idGrupoEconomico">{{{estabelecimento_request_id_grupo_economico_value}}} (optional)</param>
        /// <param name="numeroReceitaFederal">{{{estabelecimento_request_numero_receita_federal_value}}} (optional)</param>
        /// <param name="nome">{{{estabelecimento_request_nome_value}}} (optional)</param>
        /// <param name="descricao">{{{estabelecimento_request_descricao_value}}} (optional)</param>
        /// <param name="nomeFantasia">{{{estabelecimento_request_nome_fantasia_value}}} (optional)</param>
        /// <param name="cep">{{{estabelecimento_request_cep_value}}} (optional)</param>
        /// <param name="nomeLogradouro">{{{estabelecimento_request_nome_logradouro_value}}} (optional)</param>
        /// <param name="numeroEndereco">{{{estabelecimento_request_numero_endereco_value}}} (optional)</param>
        /// <param name="complemento">{{{estabelecimento_request_complemento_value}}} (optional)</param>
        /// <param name="bairro">{{{estabelecimento_request_bairro_value}}} (optional)</param>
        /// <param name="cidade">{{{estabelecimento_request_cidade_value}}} (optional)</param>
        /// <param name="uf">{{{estabelecimento_request_uf_value}}} (optional)</param>
        /// <param name="pais">{{{estabelecimento_request_pais_value}}} (optional)</param>
        /// <param name="dataCadastramento">{{{estabelecimento_request_data_cadastramento_value}}} (optional)</param>
        /// <param name="contato">{{{estabelecimento_request_contato_value}}} (optional)</param>
        /// <param name="email">{{{estabelecimento_request_email_value}}} (optional)</param>
        /// <param name="flagArquivoSecrFazenda">{{{estabelecimento_request_flag_arquivo_secr_fazenda_value}}} (optional)</param>
        /// <param name="flagCartaoDigitado">{{{estabelecimento_request_flag_cartao_digitado_value}}} (optional)</param>
        /// <param name="inativo">{{{estabelecimento_request_inativo_value}}} (optional)</param>
        /// <param name="idPais">{{{estabelecimento_request_id_pais_value}}} (optional)</param>
        /// <param name="mcc">{{{estabelecimento_request_mcc_value}}} (optional)</param>
        /// <param name="idTipoEstabelecimento">{{{estabelecimento_request_id_tipo_estabelecimento_value}}} (optional)</param>
        /// <param name="correspondencia">{{{estabelecimento_request_correspondencia_value}}} (optional)</param>
        /// <param name="idMoeda">{{{estabelecimento_request_id_moeda_value}}} (optional)</param>
        /// <param name="tipoPagamento">{{{estabelecimento_request_tipo_pagamento_value}}} (optional)</param>
        /// <param name="numeroEstabelecimento">{{{estabelecimento_request_numero_estabelecimento_value}}} (optional)</param>
        /// <param name="cep2">{{{estabelecimento_request_cep2_value}}} (optional)</param>
        /// <param name="nomeLogradouro2">{{{estabelecimento_request_nome_logradouro2_value}}} (optional)</param>
        /// <param name="numeroEndereco2">{{{estabelecimento_request_numero_endereco2_value}}} (optional)</param>
        /// <param name="complemento2">{{{estabelecimento_request_complemento2_value}}} (optional)</param>
        /// <param name="bairro2">{{{estabelecimento_request_bairro2_value}}} (optional)</param>
        /// <param name="cidade2">{{{estabelecimento_request_cidade2_value}}} (optional)</param>
        /// <param name="uf2">{{{estabelecimento_request_uf2_value}}} (optional)</param>
        /// <param name="flagMatriz">{{{estabelecimento_request_flag_matriz_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageEstabelecimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageEstabelecimentoResponse>> ListarUsingGET22AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idGrupoEconomico = null, string numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, int? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null, long? idPais = null, long? mcc = null, long? idTipoEstabelecimento = null, int? correspondencia = null, long? idMoeda = null, string tipoPagamento = null, string numeroEstabelecimento = null, string cep2 = null, string nomeLogradouro2 = null, int? numeroEndereco2 = null, string complemento2 = null, string bairro2 = null, string cidade2 = null, string uf2 = null, int? flagMatriz = null);
        
        /// <summary>
        /// {{{grupo_economico_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{grupo_economico_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="razaoSocial">{{{grupo_economico_request_razao_social_value}}} (optional)</param>
        /// <param name="nomeCredor">{{{grupo_economico_request_nome_credor_value}}} (optional)</param>
        /// <param name="numeroReceitaFederal">{{{grupo_economico_request_numero_receita_federal_value}}} (optional)</param>
        /// <param name="inscricaoEstadual">{{{grupo_economico_request_inscricao_estadual_value}}} (optional)</param>
        /// <param name="contato">{{{grupo_economico_request_contato_value}}} (optional)</param>
        /// <param name="banco">{{{grupo_economico_request_banco_value}}} (optional)</param>
        /// <param name="agencia">{{{grupo_economico_request_agencia_value}}} (optional)</param>
        /// <param name="digitoAgencia">{{{grupo_economico_request_digito_agencia_value}}} (optional)</param>
        /// <param name="contaCorrente">{{{grupo_economico_request_conta_corrente_value}}} (optional)</param>
        /// <param name="digitoContaCorrente">{{{grupo_economico_request_digito_conta_corrente_value}}} (optional)</param>
        /// <param name="periodicidade">{{{grupo_economico_request_periodicidade_value}}} (optional)</param>
        /// <param name="pagamentoSemanal">{{{grupo_economico_request_pagamento_semanal_value}}} (optional)</param>
        /// <param name="pagamentoMensal">{{{grupo_economico_request_pagamento_mensal_value}}} (optional)</param>
        /// <param name="pagamentoDecendialPrimeiro">{{{grupo_economico_request_pagamento_decendial_primeiro_value}}} (optional)</param>
        /// <param name="pagamentoDecendialSegundo">{{{grupo_economico_request_pagamento_decendial_segundo_value}}} (optional)</param>
        /// <param name="pagamentoDecendialTerceiro">{{{grupo_economico_request_pagamento_decendial_terceiro_value}}} (optional)</param>
        /// <param name="pagamentoQuinzenalPrimeiro">{{{grupo_economico_request_pagamento_quinzenal_primeiro_value}}} (optional)</param>
        /// <param name="pagamentoQuinzenalSegundo">{{{grupo_economico_request_pagamento_quinzenal_segundo_value}}} (optional)</param>
        /// <param name="percentualRAV">{{{grupo_economico_request_percentual_r_a_v_value}}} (optional)</param>
        /// <param name="recebeRAV">{{{grupo_economico_request_recebe_r_a_v_value}}} (optional)</param>
        /// <param name="percentualMultiplica">{{{grupo_economico_request_percentual_multiplica_value}}} (optional)</param>
        /// <param name="taxaAdm">{{{grupo_economico_request_taxa_adm_value}}} (optional)</param>
        /// <param name="taxaBanco">{{{grupo_economico_request_taxa_banco_value}}} (optional)</param>
        /// <param name="limiteRAV">{{{grupo_economico_request_limite_r_a_v_value}}} (optional)</param>
        /// <param name="idCredorRAV">{{{grupo_economico_request_id_credor_r_a_v_value}}} (optional)</param>
        /// <returns>Task of PageGrupoEconomicoResponse</returns>
        System.Threading.Tasks.Task<PageGrupoEconomicoResponse> ListarUsingGET25Async (List<string> sort = null, int? page = null, int? limit = null, string razaoSocial = null, string nomeCredor = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, string periodicidade = null, string pagamentoSemanal = null, int? pagamentoMensal = null, int? pagamentoDecendialPrimeiro = null, int? pagamentoDecendialSegundo = null, int? pagamentoDecendialTerceiro = null, int? pagamentoQuinzenalPrimeiro = null, int? pagamentoQuinzenalSegundo = null, double? percentualRAV = null, string recebeRAV = null, double? percentualMultiplica = null, double? taxaAdm = null, double? taxaBanco = null, double? limiteRAV = null, long? idCredorRAV = null);

        /// <summary>
        /// {{{grupo_economico_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{grupo_economico_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="razaoSocial">{{{grupo_economico_request_razao_social_value}}} (optional)</param>
        /// <param name="nomeCredor">{{{grupo_economico_request_nome_credor_value}}} (optional)</param>
        /// <param name="numeroReceitaFederal">{{{grupo_economico_request_numero_receita_federal_value}}} (optional)</param>
        /// <param name="inscricaoEstadual">{{{grupo_economico_request_inscricao_estadual_value}}} (optional)</param>
        /// <param name="contato">{{{grupo_economico_request_contato_value}}} (optional)</param>
        /// <param name="banco">{{{grupo_economico_request_banco_value}}} (optional)</param>
        /// <param name="agencia">{{{grupo_economico_request_agencia_value}}} (optional)</param>
        /// <param name="digitoAgencia">{{{grupo_economico_request_digito_agencia_value}}} (optional)</param>
        /// <param name="contaCorrente">{{{grupo_economico_request_conta_corrente_value}}} (optional)</param>
        /// <param name="digitoContaCorrente">{{{grupo_economico_request_digito_conta_corrente_value}}} (optional)</param>
        /// <param name="periodicidade">{{{grupo_economico_request_periodicidade_value}}} (optional)</param>
        /// <param name="pagamentoSemanal">{{{grupo_economico_request_pagamento_semanal_value}}} (optional)</param>
        /// <param name="pagamentoMensal">{{{grupo_economico_request_pagamento_mensal_value}}} (optional)</param>
        /// <param name="pagamentoDecendialPrimeiro">{{{grupo_economico_request_pagamento_decendial_primeiro_value}}} (optional)</param>
        /// <param name="pagamentoDecendialSegundo">{{{grupo_economico_request_pagamento_decendial_segundo_value}}} (optional)</param>
        /// <param name="pagamentoDecendialTerceiro">{{{grupo_economico_request_pagamento_decendial_terceiro_value}}} (optional)</param>
        /// <param name="pagamentoQuinzenalPrimeiro">{{{grupo_economico_request_pagamento_quinzenal_primeiro_value}}} (optional)</param>
        /// <param name="pagamentoQuinzenalSegundo">{{{grupo_economico_request_pagamento_quinzenal_segundo_value}}} (optional)</param>
        /// <param name="percentualRAV">{{{grupo_economico_request_percentual_r_a_v_value}}} (optional)</param>
        /// <param name="recebeRAV">{{{grupo_economico_request_recebe_r_a_v_value}}} (optional)</param>
        /// <param name="percentualMultiplica">{{{grupo_economico_request_percentual_multiplica_value}}} (optional)</param>
        /// <param name="taxaAdm">{{{grupo_economico_request_taxa_adm_value}}} (optional)</param>
        /// <param name="taxaBanco">{{{grupo_economico_request_taxa_banco_value}}} (optional)</param>
        /// <param name="limiteRAV">{{{grupo_economico_request_limite_r_a_v_value}}} (optional)</param>
        /// <param name="idCredorRAV">{{{grupo_economico_request_id_credor_r_a_v_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageGrupoEconomicoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageGrupoEconomicoResponse>> ListarUsingGET25AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string razaoSocial = null, string nomeCredor = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, string periodicidade = null, string pagamentoSemanal = null, int? pagamentoMensal = null, int? pagamentoDecendialPrimeiro = null, int? pagamentoDecendialSegundo = null, int? pagamentoDecendialTerceiro = null, int? pagamentoQuinzenalPrimeiro = null, int? pagamentoQuinzenalSegundo = null, double? percentualRAV = null, string recebeRAV = null, double? percentualMultiplica = null, double? taxaAdm = null, double? taxaBanco = null, double? limiteRAV = null, long? idCredorRAV = null);
        
        /// <summary>
        /// {{{grupo_origem_comercial_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{grupo_origem_comercial_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{grupo_origem_comercial_request_nome_value}}} (optional)</param>
        /// <returns>Task of PageGrupoOrigemComercialResponse</returns>
        System.Threading.Tasks.Task<PageGrupoOrigemComercialResponse> ListarUsingGET26Async (List<string> sort = null, int? page = null, int? limit = null, string nome = null);

        /// <summary>
        /// {{{grupo_origem_comercial_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{grupo_origem_comercial_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{grupo_origem_comercial_request_nome_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageGrupoOrigemComercialResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageGrupoOrigemComercialResponse>> ListarUsingGET26AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null);
        
        /// <summary>
        /// {{{maquineta_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{maquineta_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{maquineta_request_id_estabelecimento_value}}} (optional)</param>
        /// <returns>Task of PageMaquinetaResponse</returns>
        System.Threading.Tasks.Task<PageMaquinetaResponse> ListarUsingGET28Async (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null);

        /// <summary>
        /// {{{maquineta_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{maquineta_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{maquineta_request_id_estabelecimento_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageMaquinetaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageMaquinetaResponse>> ListarUsingGET28AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null);
        
        /// <summary>
        /// {{{moeda_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{moeda_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="codigoMoeda">{{{moeda_request_codigo_moeda_value}}} (optional)</param>
        /// <param name="simbolo">{{{moeda_request_simbolo_value}}} (optional)</param>
        /// <param name="descricao">{{{moeda_request_descricao_value}}} (optional)</param>
        /// <returns>Task of PageMoedaResponse</returns>
        System.Threading.Tasks.Task<PageMoedaResponse> ListarUsingGET29Async (List<string> sort = null, int? page = null, int? limit = null, string codigoMoeda = null, string simbolo = null, string descricao = null);

        /// <summary>
        /// {{{moeda_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{moeda_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="codigoMoeda">{{{moeda_request_codigo_moeda_value}}} (optional)</param>
        /// <param name="simbolo">{{{moeda_request_simbolo_value}}} (optional)</param>
        /// <param name="descricao">{{{moeda_request_descricao_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageMoedaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageMoedaResponse>> ListarUsingGET29AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string codigoMoeda = null, string simbolo = null, string descricao = null);
        
        /// <summary>
        /// {{{operacao_credor_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{operacao_credor_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idOperacao">{{{operacao_credor_request_id_operacao_value}}} (optional)</param>
        /// <param name="idCredor">{{{operacao_credor_request_id_credor_value}}} (optional)</param>
        /// <param name="idProduto">{{{operacao_credor_request_id_produto_value}}} (optional)</param>
        /// <returns>Task of PageOperacaoCredorResponse</returns>
        System.Threading.Tasks.Task<PageOperacaoCredorResponse> ListarUsingGET30Async (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, long? idCredor = null, long? idProduto = null);

        /// <summary>
        /// {{{operacao_credor_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{operacao_credor_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idOperacao">{{{operacao_credor_request_id_operacao_value}}} (optional)</param>
        /// <param name="idCredor">{{{operacao_credor_request_id_credor_value}}} (optional)</param>
        /// <param name="idProduto">{{{operacao_credor_request_id_produto_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageOperacaoCredorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageOperacaoCredorResponse>> ListarUsingGET30AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, long? idCredor = null, long? idProduto = null);
        
        /// <summary>
        /// {{{telefone_estabelecimento_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{telefone_estabelecimento_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{telefone_estabelecimento_request_id_estabelecimento_value}}} (optional)</param>
        /// <returns>Task of PageTelefoneEstabelecimentoResponse</returns>
        System.Threading.Tasks.Task<PageTelefoneEstabelecimentoResponse> ListarUsingGET44Async (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null);

        /// <summary>
        /// {{{telefone_estabelecimento_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{telefone_estabelecimento_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{telefone_estabelecimento_request_id_estabelecimento_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTelefoneEstabelecimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTelefoneEstabelecimentoResponse>> ListarUsingGET44AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null);
        
        /// <summary>
        /// {{{terminal_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{terminal_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{terminal_request_id_value}}} (optional)</param>
        /// <param name="terminal">{{{terminal_request_terminal_value}}} (optional)</param>
        /// <param name="numeroEstabelecimento">{{{terminal_request_numero_estabelecimento_value}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{terminal_request_id_estabelecimento_value}}} (optional)</param>
        /// <returns>Task of PageTerminalResponse</returns>
        System.Threading.Tasks.Task<PageTerminalResponse> ListarUsingGET46Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null);

        /// <summary>
        /// {{{terminal_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{terminal_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{terminal_request_id_value}}} (optional)</param>
        /// <param name="terminal">{{{terminal_request_terminal_value}}} (optional)</param>
        /// <param name="numeroEstabelecimento">{{{terminal_request_numero_estabelecimento_value}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{terminal_request_id_estabelecimento_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTerminalResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTerminalResponse>> ListarUsingGET46AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null);
        
        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_estabelecimento_adquirente_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idAdquirente">{{{vinculo_estabelecimento_adquirente_request_id_adquirente_value}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{vinculo_estabelecimento_adquirente_request_id_estabelecimento_value}}} (optional)</param>
        /// <param name="codigoEstabelecimentoAdquirente">{{{vinculo_estabelecimento_adquirente_request_codigo_estabelecimento_adquirente_value}}} (optional)</param>
        /// <returns>Task of PageVinculoEstabelecimentoAdquirenteResponse</returns>
        System.Threading.Tasks.Task<PageVinculoEstabelecimentoAdquirenteResponse> ListarUsingGET58Async (List<string> sort = null, int? page = null, int? limit = null, long? idAdquirente = null, long? idEstabelecimento = null, string codigoEstabelecimentoAdquirente = null);

        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_estabelecimento_adquirente_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idAdquirente">{{{vinculo_estabelecimento_adquirente_request_id_adquirente_value}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{vinculo_estabelecimento_adquirente_request_id_estabelecimento_value}}} (optional)</param>
        /// <param name="codigoEstabelecimentoAdquirente">{{{vinculo_estabelecimento_adquirente_request_codigo_estabelecimento_adquirente_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageVinculoEstabelecimentoAdquirenteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageVinculoEstabelecimentoAdquirenteResponse>> ListarUsingGET58AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idAdquirente = null, long? idEstabelecimento = null, string codigoEstabelecimentoAdquirente = null);
        
        /// <summary>
        /// {{{vinculo_operacao_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_operacao_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_operacao_resource_listar_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idProduto">{{{vinculo_operacao_request_id_produto_value}}} (optional)</param>
        /// <param name="idOperacao">{{{vinculo_operacao_request_id_operacao_value}}} (optional)</param>
        /// <param name="codigoMCC">{{{vinculo_operacao_request_codigo_m_c_c_value}}} (optional)</param>
        /// <returns>Task of PageVinculoOperacaoResponse</returns>
        System.Threading.Tasks.Task<PageVinculoOperacaoResponse> ListarUsingGET59Async (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOperacao = null, int? codigoMCC = null);

        /// <summary>
        /// {{{vinculo_operacao_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_operacao_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_operacao_resource_listar_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idProduto">{{{vinculo_operacao_request_id_produto_value}}} (optional)</param>
        /// <param name="idOperacao">{{{vinculo_operacao_request_id_operacao_value}}} (optional)</param>
        /// <param name="codigoMCC">{{{vinculo_operacao_request_codigo_m_c_c_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageVinculoOperacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageVinculoOperacaoResponse>> ListarUsingGET59AsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOperacao = null, int? codigoMCC = null);
        
        /// <summary>
        /// {{{maquineta_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{maquineta_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maquinetaPersist">maquinetaPersist</param>
        /// <returns>Task of MaquinetaResponse</returns>
        System.Threading.Tasks.Task<MaquinetaResponse> SalvarUsingPOST17Async (MaquinetaPersist maquinetaPersist);

        /// <summary>
        /// {{{maquineta_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{maquineta_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maquinetaPersist">maquinetaPersist</param>
        /// <returns>Task of ApiResponse (MaquinetaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MaquinetaResponse>> SalvarUsingPOST17AsyncWithHttpInfo (MaquinetaPersist maquinetaPersist);
        
        /// <summary>
        /// {{{operacao_credor_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{operacao_credor_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operacaoCredorPersist">operacaoCredorPersist</param>
        /// <returns>Task of OperacaoCredorResponse</returns>
        System.Threading.Tasks.Task<OperacaoCredorResponse> SalvarUsingPOST18Async (OperacaoCredorPersist operacaoCredorPersist);

        /// <summary>
        /// {{{operacao_credor_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{operacao_credor_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operacaoCredorPersist">operacaoCredorPersist</param>
        /// <returns>Task of ApiResponse (OperacaoCredorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperacaoCredorResponse>> SalvarUsingPOST18AsyncWithHttpInfo (OperacaoCredorPersist operacaoCredorPersist);
        
        /// <summary>
        /// {{{telefone_estabelecimento_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{telefone_estabelecimento_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="telefoneEstabelecimentoPersist">telefoneEstabelecimentoPersist</param>
        /// <returns>Task of TelefoneEstabelecimentoResponse</returns>
        System.Threading.Tasks.Task<TelefoneEstabelecimentoResponse> SalvarUsingPOST23Async (TelefoneEstabelecimentoPersist telefoneEstabelecimentoPersist);

        /// <summary>
        /// {{{telefone_estabelecimento_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{telefone_estabelecimento_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="telefoneEstabelecimentoPersist">telefoneEstabelecimentoPersist</param>
        /// <returns>Task of ApiResponse (TelefoneEstabelecimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TelefoneEstabelecimentoResponse>> SalvarUsingPOST23AsyncWithHttpInfo (TelefoneEstabelecimentoPersist telefoneEstabelecimentoPersist);
        
        /// <summary>
        /// {{{terminal_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{terminal_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminalPersist">terminalPersist</param>
        /// <returns>Task of TerminalResponse</returns>
        System.Threading.Tasks.Task<TerminalResponse> SalvarUsingPOST25Async (TerminalPersist terminalPersist);

        /// <summary>
        /// {{{terminal_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{terminal_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminalPersist">terminalPersist</param>
        /// <returns>Task of ApiResponse (TerminalResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TerminalResponse>> SalvarUsingPOST25AsyncWithHttpInfo (TerminalPersist terminalPersist);
        
        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_estabelecimento_adquirente_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vinculoEstabelecimentoAdquirentePersist">vinculoEstabelecimentoAdquirentePersist</param>
        /// <returns>Task of VinculoEstabelecimentoAdquirenteResponse</returns>
        System.Threading.Tasks.Task<VinculoEstabelecimentoAdquirenteResponse> SalvarUsingPOST29Async (VinculoEstabelecimentoAdquirentePersist vinculoEstabelecimentoAdquirentePersist);

        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{vinculo_estabelecimento_adquirente_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vinculoEstabelecimentoAdquirentePersist">vinculoEstabelecimentoAdquirentePersist</param>
        /// <returns>Task of ApiResponse (VinculoEstabelecimentoAdquirenteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<VinculoEstabelecimentoAdquirenteResponse>> SalvarUsingPOST29AsyncWithHttpInfo (VinculoEstabelecimentoAdquirentePersist vinculoEstabelecimentoAdquirentePersist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltagestabelecimentoApi : IGlobaltagestabelecimentoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagestabelecimentoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltagestabelecimentoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagestabelecimentoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltagestabelecimentoApi(Configuration configuration = null)
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
        /// {{{origem_comercial_resource_alterar_origem_comercial}}} {{{origem_comercial_resource_alterar_origem_comercial_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{origem_comercial_resource_alterar_origem_comercial_param_id}}}</param> 
        /// <param name="origemComercialUpdate">origemComercialUpdate</param> 
        /// <returns>OrigemComercialResponse</returns>
        public OrigemComercialResponse AlterarOrigemComercialUsingPUT (long? id, OrigemComercialUpdate origemComercialUpdate)
        {
             ApiResponse<OrigemComercialResponse> localVarResponse = AlterarOrigemComercialUsingPUTWithHttpInfo(id, origemComercialUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{origem_comercial_resource_alterar_origem_comercial}}} {{{origem_comercial_resource_alterar_origem_comercial_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{origem_comercial_resource_alterar_origem_comercial_param_id}}}</param> 
        /// <param name="origemComercialUpdate">origemComercialUpdate</param> 
        /// <returns>ApiResponse of OrigemComercialResponse</returns>
        public ApiResponse< OrigemComercialResponse > AlterarOrigemComercialUsingPUTWithHttpInfo (long? id, OrigemComercialUpdate origemComercialUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagestabelecimentoApi->AlterarOrigemComercialUsingPUT");
            
            // verify the required parameter 'origemComercialUpdate' is set
            if (origemComercialUpdate == null)
                throw new ApiException(400, "Missing required parameter 'origemComercialUpdate' when calling GlobaltagestabelecimentoApi->AlterarOrigemComercialUsingPUT");
            
    
            var localVarPath = "/api/origens-comerciais/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (origemComercialUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(origemComercialUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = origemComercialUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarOrigemComercialUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarOrigemComercialUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OrigemComercialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrigemComercialResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrigemComercialResponse)));
            
        }

        
        /// <summary>
        /// {{{origem_comercial_resource_alterar_origem_comercial}}} {{{origem_comercial_resource_alterar_origem_comercial_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{origem_comercial_resource_alterar_origem_comercial_param_id}}}</param>
        /// <param name="origemComercialUpdate">origemComercialUpdate</param>
        /// <returns>Task of OrigemComercialResponse</returns>
        public async System.Threading.Tasks.Task<OrigemComercialResponse> AlterarOrigemComercialUsingPUTAsync (long? id, OrigemComercialUpdate origemComercialUpdate)
        {
             ApiResponse<OrigemComercialResponse> localVarResponse = await AlterarOrigemComercialUsingPUTAsyncWithHttpInfo(id, origemComercialUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{origem_comercial_resource_alterar_origem_comercial}}} {{{origem_comercial_resource_alterar_origem_comercial_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{origem_comercial_resource_alterar_origem_comercial_param_id}}}</param>
        /// <param name="origemComercialUpdate">origemComercialUpdate</param>
        /// <returns>Task of ApiResponse (OrigemComercialResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrigemComercialResponse>> AlterarOrigemComercialUsingPUTAsyncWithHttpInfo (long? id, OrigemComercialUpdate origemComercialUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarOrigemComercialUsingPUT");
            // verify the required parameter 'origemComercialUpdate' is set
            if (origemComercialUpdate == null) throw new ApiException(400, "Missing required parameter 'origemComercialUpdate' when calling AlterarOrigemComercialUsingPUT");
            
    
            var localVarPath = "/api/origens-comerciais/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (origemComercialUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(origemComercialUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = origemComercialUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarOrigemComercialUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarOrigemComercialUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrigemComercialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrigemComercialResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrigemComercialResponse)));
            
        }
        
        /// <summary>
        /// {{{operacao_credor_resource_alterar}}} {{{operacao_credor_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{operacao_credor_resource_alterar_param_id}}}</param> 
        /// <param name="operacaoCredorUpdate">operacaoCredorUpdate</param> 
        /// <returns>OperacaoCredorResponse</returns>
        public OperacaoCredorResponse AlterarUsingPUT10 (long? id, OperacaoCredorUpdate operacaoCredorUpdate)
        {
             ApiResponse<OperacaoCredorResponse> localVarResponse = AlterarUsingPUT10WithHttpInfo(id, operacaoCredorUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{operacao_credor_resource_alterar}}} {{{operacao_credor_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{operacao_credor_resource_alterar_param_id}}}</param> 
        /// <param name="operacaoCredorUpdate">operacaoCredorUpdate</param> 
        /// <returns>ApiResponse of OperacaoCredorResponse</returns>
        public ApiResponse< OperacaoCredorResponse > AlterarUsingPUT10WithHttpInfo (long? id, OperacaoCredorUpdate operacaoCredorUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagestabelecimentoApi->AlterarUsingPUT10");
            
            // verify the required parameter 'operacaoCredorUpdate' is set
            if (operacaoCredorUpdate == null)
                throw new ApiException(400, "Missing required parameter 'operacaoCredorUpdate' when calling GlobaltagestabelecimentoApi->AlterarUsingPUT10");
            
    
            var localVarPath = "/api/regras-operacoes-estabelecimentos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (operacaoCredorUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(operacaoCredorUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = operacaoCredorUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT10: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT10: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OperacaoCredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OperacaoCredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperacaoCredorResponse)));
            
        }

        
        /// <summary>
        /// {{{operacao_credor_resource_alterar}}} {{{operacao_credor_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{operacao_credor_resource_alterar_param_id}}}</param>
        /// <param name="operacaoCredorUpdate">operacaoCredorUpdate</param>
        /// <returns>Task of OperacaoCredorResponse</returns>
        public async System.Threading.Tasks.Task<OperacaoCredorResponse> AlterarUsingPUT10Async (long? id, OperacaoCredorUpdate operacaoCredorUpdate)
        {
             ApiResponse<OperacaoCredorResponse> localVarResponse = await AlterarUsingPUT10AsyncWithHttpInfo(id, operacaoCredorUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{operacao_credor_resource_alterar}}} {{{operacao_credor_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{operacao_credor_resource_alterar_param_id}}}</param>
        /// <param name="operacaoCredorUpdate">operacaoCredorUpdate</param>
        /// <returns>Task of ApiResponse (OperacaoCredorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OperacaoCredorResponse>> AlterarUsingPUT10AsyncWithHttpInfo (long? id, OperacaoCredorUpdate operacaoCredorUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT10");
            // verify the required parameter 'operacaoCredorUpdate' is set
            if (operacaoCredorUpdate == null) throw new ApiException(400, "Missing required parameter 'operacaoCredorUpdate' when calling AlterarUsingPUT10");
            
    
            var localVarPath = "/api/regras-operacoes-estabelecimentos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (operacaoCredorUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(operacaoCredorUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = operacaoCredorUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT10: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT10: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OperacaoCredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OperacaoCredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperacaoCredorResponse)));
            
        }
        
        /// <summary>
        /// {{{telefone_estabelecimento_resource_alterar}}} {{{telefone_estabelecimento_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{telefone_estabelecimento_resource_alterar_param_id}}}</param> 
        /// <param name="telefoneEstabelecimentoUpdate">telefoneEstabelecimentoUpdate</param> 
        /// <returns>TelefoneEstabelecimentoResponse</returns>
        public TelefoneEstabelecimentoResponse AlterarUsingPUT14 (long? id, TelefoneEstabelecimentoUpdate telefoneEstabelecimentoUpdate)
        {
             ApiResponse<TelefoneEstabelecimentoResponse> localVarResponse = AlterarUsingPUT14WithHttpInfo(id, telefoneEstabelecimentoUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{telefone_estabelecimento_resource_alterar}}} {{{telefone_estabelecimento_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{telefone_estabelecimento_resource_alterar_param_id}}}</param> 
        /// <param name="telefoneEstabelecimentoUpdate">telefoneEstabelecimentoUpdate</param> 
        /// <returns>ApiResponse of TelefoneEstabelecimentoResponse</returns>
        public ApiResponse< TelefoneEstabelecimentoResponse > AlterarUsingPUT14WithHttpInfo (long? id, TelefoneEstabelecimentoUpdate telefoneEstabelecimentoUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagestabelecimentoApi->AlterarUsingPUT14");
            
            // verify the required parameter 'telefoneEstabelecimentoUpdate' is set
            if (telefoneEstabelecimentoUpdate == null)
                throw new ApiException(400, "Missing required parameter 'telefoneEstabelecimentoUpdate' when calling GlobaltagestabelecimentoApi->AlterarUsingPUT14");
            
    
            var localVarPath = "/api/telefones-estabelecimentos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (telefoneEstabelecimentoUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(telefoneEstabelecimentoUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = telefoneEstabelecimentoUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT14: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT14: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TelefoneEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneEstabelecimentoResponse)));
            
        }

        
        /// <summary>
        /// {{{telefone_estabelecimento_resource_alterar}}} {{{telefone_estabelecimento_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{telefone_estabelecimento_resource_alterar_param_id}}}</param>
        /// <param name="telefoneEstabelecimentoUpdate">telefoneEstabelecimentoUpdate</param>
        /// <returns>Task of TelefoneEstabelecimentoResponse</returns>
        public async System.Threading.Tasks.Task<TelefoneEstabelecimentoResponse> AlterarUsingPUT14Async (long? id, TelefoneEstabelecimentoUpdate telefoneEstabelecimentoUpdate)
        {
             ApiResponse<TelefoneEstabelecimentoResponse> localVarResponse = await AlterarUsingPUT14AsyncWithHttpInfo(id, telefoneEstabelecimentoUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{telefone_estabelecimento_resource_alterar}}} {{{telefone_estabelecimento_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{telefone_estabelecimento_resource_alterar_param_id}}}</param>
        /// <param name="telefoneEstabelecimentoUpdate">telefoneEstabelecimentoUpdate</param>
        /// <returns>Task of ApiResponse (TelefoneEstabelecimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TelefoneEstabelecimentoResponse>> AlterarUsingPUT14AsyncWithHttpInfo (long? id, TelefoneEstabelecimentoUpdate telefoneEstabelecimentoUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT14");
            // verify the required parameter 'telefoneEstabelecimentoUpdate' is set
            if (telefoneEstabelecimentoUpdate == null) throw new ApiException(400, "Missing required parameter 'telefoneEstabelecimentoUpdate' when calling AlterarUsingPUT14");
            
    
            var localVarPath = "/api/telefones-estabelecimentos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (telefoneEstabelecimentoUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(telefoneEstabelecimentoUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = telefoneEstabelecimentoUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT14: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT14: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TelefoneEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneEstabelecimentoResponse)));
            
        }
        
        /// <summary>
        /// {{{terminal_resource_alterar}}} {{{terminal_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{terminal_resource_alterar_param_id}}}</param> 
        /// <param name="terminalUpdate">terminalUpdate</param> 
        /// <returns>TerminalResponse</returns>
        public TerminalResponse AlterarUsingPUT16 (long? id, TerminalUpdateValue terminalUpdate)
        {
             ApiResponse<TerminalResponse> localVarResponse = AlterarUsingPUT16WithHttpInfo(id, terminalUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{terminal_resource_alterar}}} {{{terminal_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{terminal_resource_alterar_param_id}}}</param> 
        /// <param name="terminalUpdate">terminalUpdate</param> 
        /// <returns>ApiResponse of TerminalResponse</returns>
        public ApiResponse< TerminalResponse > AlterarUsingPUT16WithHttpInfo (long? id, TerminalUpdateValue terminalUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagestabelecimentoApi->AlterarUsingPUT16");
            
            // verify the required parameter 'terminalUpdate' is set
            if (terminalUpdate == null)
                throw new ApiException(400, "Missing required parameter 'terminalUpdate' when calling GlobaltagestabelecimentoApi->AlterarUsingPUT16");
            
    
            var localVarPath = "/api/terminais/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (terminalUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(terminalUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = terminalUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT16: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT16: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TerminalResponse)));
            
        }

        
        /// <summary>
        /// {{{terminal_resource_alterar}}} {{{terminal_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{terminal_resource_alterar_param_id}}}</param>
        /// <param name="terminalUpdate">terminalUpdate</param>
        /// <returns>Task of TerminalResponse</returns>
        public async System.Threading.Tasks.Task<TerminalResponse> AlterarUsingPUT16Async (long? id, TerminalUpdateValue terminalUpdate)
        {
             ApiResponse<TerminalResponse> localVarResponse = await AlterarUsingPUT16AsyncWithHttpInfo(id, terminalUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{terminal_resource_alterar}}} {{{terminal_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{terminal_resource_alterar_param_id}}}</param>
        /// <param name="terminalUpdate">terminalUpdate</param>
        /// <returns>Task of ApiResponse (TerminalResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TerminalResponse>> AlterarUsingPUT16AsyncWithHttpInfo (long? id, TerminalUpdateValue terminalUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT16");
            // verify the required parameter 'terminalUpdate' is set
            if (terminalUpdate == null) throw new ApiException(400, "Missing required parameter 'terminalUpdate' when calling AlterarUsingPUT16");
            
    
            var localVarPath = "/api/terminais/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (terminalUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(terminalUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = terminalUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT16: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT16: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TerminalResponse)));
            
        }
        
        /// <summary>
        /// {{{estabelecimento_resource_alterar}}} {{{estabelecimento_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{estabelecimento_resource_alterar_param_id_estabelecimento}}}</param> 
        /// <param name="update">update</param> 
        /// <returns>EstabelecimentoResponse</returns>
        public EstabelecimentoResponse AlterarUsingPUT5 (long? id, EstabelecimentoUpdate update)
        {
             ApiResponse<EstabelecimentoResponse> localVarResponse = AlterarUsingPUT5WithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{estabelecimento_resource_alterar}}} {{{estabelecimento_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{estabelecimento_resource_alterar_param_id_estabelecimento}}}</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of EstabelecimentoResponse</returns>
        public ApiResponse< EstabelecimentoResponse > AlterarUsingPUT5WithHttpInfo (long? id, EstabelecimentoUpdate update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagestabelecimentoApi->AlterarUsingPUT5");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling GlobaltagestabelecimentoApi->AlterarUsingPUT5");
            
    
            var localVarPath = "/api/estabelecimentos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstabelecimentoResponse)));
            
        }

        
        /// <summary>
        /// {{{estabelecimento_resource_alterar}}} {{{estabelecimento_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{estabelecimento_resource_alterar_param_id_estabelecimento}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of EstabelecimentoResponse</returns>
        public async System.Threading.Tasks.Task<EstabelecimentoResponse> AlterarUsingPUT5Async (long? id, EstabelecimentoUpdate update)
        {
             ApiResponse<EstabelecimentoResponse> localVarResponse = await AlterarUsingPUT5AsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{estabelecimento_resource_alterar}}} {{{estabelecimento_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{estabelecimento_resource_alterar_param_id_estabelecimento}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (EstabelecimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EstabelecimentoResponse>> AlterarUsingPUT5AsyncWithHttpInfo (long? id, EstabelecimentoUpdate update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT5");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AlterarUsingPUT5");
            
    
            var localVarPath = "/api/estabelecimentos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstabelecimentoResponse)));
            
        }
        
        /// <summary>
        /// {{{grupo_economico_resource_alterar}}} {{{grupo_economico_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{grupo_economico_resource_alterar_param_id}}}</param> 
        /// <param name="grupoEconomicoDTO">grupoEconomicoDTO</param> 
        /// <returns>GrupoEconomicoResponse</returns>
        public GrupoEconomicoResponse AlterarUsingPUT7 (long? id, GrupoEconomicoDTO grupoEconomicoDTO)
        {
             ApiResponse<GrupoEconomicoResponse> localVarResponse = AlterarUsingPUT7WithHttpInfo(id, grupoEconomicoDTO);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{grupo_economico_resource_alterar}}} {{{grupo_economico_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{grupo_economico_resource_alterar_param_id}}}</param> 
        /// <param name="grupoEconomicoDTO">grupoEconomicoDTO</param> 
        /// <returns>ApiResponse of GrupoEconomicoResponse</returns>
        public ApiResponse< GrupoEconomicoResponse > AlterarUsingPUT7WithHttpInfo (long? id, GrupoEconomicoDTO grupoEconomicoDTO)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagestabelecimentoApi->AlterarUsingPUT7");
            
            // verify the required parameter 'grupoEconomicoDTO' is set
            if (grupoEconomicoDTO == null)
                throw new ApiException(400, "Missing required parameter 'grupoEconomicoDTO' when calling GlobaltagestabelecimentoApi->AlterarUsingPUT7");
            
    
            var localVarPath = "/api/grupos-economicos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (grupoEconomicoDTO.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(grupoEconomicoDTO); // http body (model) parameter
            }
            else
            {
                localVarPostBody = grupoEconomicoDTO; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<GrupoEconomicoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GrupoEconomicoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GrupoEconomicoResponse)));
            
        }

        
        /// <summary>
        /// {{{grupo_economico_resource_alterar}}} {{{grupo_economico_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{grupo_economico_resource_alterar_param_id}}}</param>
        /// <param name="grupoEconomicoDTO">grupoEconomicoDTO</param>
        /// <returns>Task of GrupoEconomicoResponse</returns>
        public async System.Threading.Tasks.Task<GrupoEconomicoResponse> AlterarUsingPUT7Async (long? id, GrupoEconomicoDTO grupoEconomicoDTO)
        {
             ApiResponse<GrupoEconomicoResponse> localVarResponse = await AlterarUsingPUT7AsyncWithHttpInfo(id, grupoEconomicoDTO);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{grupo_economico_resource_alterar}}} {{{grupo_economico_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{grupo_economico_resource_alterar_param_id}}}</param>
        /// <param name="grupoEconomicoDTO">grupoEconomicoDTO</param>
        /// <returns>Task of ApiResponse (GrupoEconomicoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GrupoEconomicoResponse>> AlterarUsingPUT7AsyncWithHttpInfo (long? id, GrupoEconomicoDTO grupoEconomicoDTO)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT7");
            // verify the required parameter 'grupoEconomicoDTO' is set
            if (grupoEconomicoDTO == null) throw new ApiException(400, "Missing required parameter 'grupoEconomicoDTO' when calling AlterarUsingPUT7");
            
    
            var localVarPath = "/api/grupos-economicos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (grupoEconomicoDTO.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(grupoEconomicoDTO); // http body (model) parameter
            }
            else
            {
                localVarPostBody = grupoEconomicoDTO; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GrupoEconomicoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GrupoEconomicoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GrupoEconomicoResponse)));
            
        }
        
        /// <summary>
        /// {{{maquineta_resource_alterar}}} {{{maquineta_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{maquineta_resource_alterar_param_id}}}</param> 
        /// <param name="maquinetaUpdate">maquinetaUpdate</param> 
        /// <returns>MaquinetaResponse</returns>
        public MaquinetaResponse AlterarUsingPUT9 (long? id, MaquinetaUpdate maquinetaUpdate)
        {
             ApiResponse<MaquinetaResponse> localVarResponse = AlterarUsingPUT9WithHttpInfo(id, maquinetaUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{maquineta_resource_alterar}}} {{{maquineta_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{maquineta_resource_alterar_param_id}}}</param> 
        /// <param name="maquinetaUpdate">maquinetaUpdate</param> 
        /// <returns>ApiResponse of MaquinetaResponse</returns>
        public ApiResponse< MaquinetaResponse > AlterarUsingPUT9WithHttpInfo (long? id, MaquinetaUpdate maquinetaUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagestabelecimentoApi->AlterarUsingPUT9");
            
            // verify the required parameter 'maquinetaUpdate' is set
            if (maquinetaUpdate == null)
                throw new ApiException(400, "Missing required parameter 'maquinetaUpdate' when calling GlobaltagestabelecimentoApi->AlterarUsingPUT9");
            
    
            var localVarPath = "/api/maquinetas/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (maquinetaUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(maquinetaUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = maquinetaUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT9: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT9: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<MaquinetaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MaquinetaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaquinetaResponse)));
            
        }

        
        /// <summary>
        /// {{{maquineta_resource_alterar}}} {{{maquineta_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{maquineta_resource_alterar_param_id}}}</param>
        /// <param name="maquinetaUpdate">maquinetaUpdate</param>
        /// <returns>Task of MaquinetaResponse</returns>
        public async System.Threading.Tasks.Task<MaquinetaResponse> AlterarUsingPUT9Async (long? id, MaquinetaUpdate maquinetaUpdate)
        {
             ApiResponse<MaquinetaResponse> localVarResponse = await AlterarUsingPUT9AsyncWithHttpInfo(id, maquinetaUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{maquineta_resource_alterar}}} {{{maquineta_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{maquineta_resource_alterar_param_id}}}</param>
        /// <param name="maquinetaUpdate">maquinetaUpdate</param>
        /// <returns>Task of ApiResponse (MaquinetaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MaquinetaResponse>> AlterarUsingPUT9AsyncWithHttpInfo (long? id, MaquinetaUpdate maquinetaUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT9");
            // verify the required parameter 'maquinetaUpdate' is set
            if (maquinetaUpdate == null) throw new ApiException(400, "Missing required parameter 'maquinetaUpdate' when calling AlterarUsingPUT9");
            
    
            var localVarPath = "/api/maquinetas/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (maquinetaUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(maquinetaUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = maquinetaUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT9: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT9: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MaquinetaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MaquinetaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaquinetaResponse)));
            
        }
        
        /// <summary>
        /// {{{origem_comercial_resource_cadastrar_origem_comercial}}} {{{origem_comercial_resource_cadastrar_origem_comercial_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origemComercialPersist">origemComercialPersist</param> 
        /// <returns>OrigemComercialResponse</returns>
        public OrigemComercialResponse CadastrarOrigemComercialUsingPOST (OrigemComercialPersist origemComercialPersist)
        {
             ApiResponse<OrigemComercialResponse> localVarResponse = CadastrarOrigemComercialUsingPOSTWithHttpInfo(origemComercialPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{origem_comercial_resource_cadastrar_origem_comercial}}} {{{origem_comercial_resource_cadastrar_origem_comercial_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origemComercialPersist">origemComercialPersist</param> 
        /// <returns>ApiResponse of OrigemComercialResponse</returns>
        public ApiResponse< OrigemComercialResponse > CadastrarOrigemComercialUsingPOSTWithHttpInfo (OrigemComercialPersist origemComercialPersist)
        {
            
            // verify the required parameter 'origemComercialPersist' is set
            if (origemComercialPersist == null)
                throw new ApiException(400, "Missing required parameter 'origemComercialPersist' when calling GlobaltagestabelecimentoApi->CadastrarOrigemComercialUsingPOST");
            
    
            var localVarPath = "/api/origens-comerciais";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (origemComercialPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(origemComercialPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = origemComercialPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarOrigemComercialUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarOrigemComercialUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OrigemComercialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrigemComercialResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrigemComercialResponse)));
            
        }

        
        /// <summary>
        /// {{{origem_comercial_resource_cadastrar_origem_comercial}}} {{{origem_comercial_resource_cadastrar_origem_comercial_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origemComercialPersist">origemComercialPersist</param>
        /// <returns>Task of OrigemComercialResponse</returns>
        public async System.Threading.Tasks.Task<OrigemComercialResponse> CadastrarOrigemComercialUsingPOSTAsync (OrigemComercialPersist origemComercialPersist)
        {
             ApiResponse<OrigemComercialResponse> localVarResponse = await CadastrarOrigemComercialUsingPOSTAsyncWithHttpInfo(origemComercialPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{origem_comercial_resource_cadastrar_origem_comercial}}} {{{origem_comercial_resource_cadastrar_origem_comercial_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origemComercialPersist">origemComercialPersist</param>
        /// <returns>Task of ApiResponse (OrigemComercialResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrigemComercialResponse>> CadastrarOrigemComercialUsingPOSTAsyncWithHttpInfo (OrigemComercialPersist origemComercialPersist)
        {
            // verify the required parameter 'origemComercialPersist' is set
            if (origemComercialPersist == null) throw new ApiException(400, "Missing required parameter 'origemComercialPersist' when calling CadastrarOrigemComercialUsingPOST");
            
    
            var localVarPath = "/api/origens-comerciais";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (origemComercialPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(origemComercialPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = origemComercialPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarOrigemComercialUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarOrigemComercialUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrigemComercialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrigemComercialResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrigemComercialResponse)));
            
        }
        
        /// <summary>
        /// {{{estabelecimento_resource_cadastrar}}} {{{estabelecimento_resource_cadastrar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>EstabelecimentoResponse</returns>
        public EstabelecimentoResponse CadastrarUsingPOST3 (EstabelecimentoPersist persist)
        {
             ApiResponse<EstabelecimentoResponse> localVarResponse = CadastrarUsingPOST3WithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{estabelecimento_resource_cadastrar}}} {{{estabelecimento_resource_cadastrar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of EstabelecimentoResponse</returns>
        public ApiResponse< EstabelecimentoResponse > CadastrarUsingPOST3WithHttpInfo (EstabelecimentoPersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling GlobaltagestabelecimentoApi->CadastrarUsingPOST3");
            
    
            var localVarPath = "/api/estabelecimentos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstabelecimentoResponse)));
            
        }

        
        /// <summary>
        /// {{{estabelecimento_resource_cadastrar}}} {{{estabelecimento_resource_cadastrar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of EstabelecimentoResponse</returns>
        public async System.Threading.Tasks.Task<EstabelecimentoResponse> CadastrarUsingPOST3Async (EstabelecimentoPersist persist)
        {
             ApiResponse<EstabelecimentoResponse> localVarResponse = await CadastrarUsingPOST3AsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{estabelecimento_resource_cadastrar}}} {{{estabelecimento_resource_cadastrar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (EstabelecimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EstabelecimentoResponse>> CadastrarUsingPOST3AsyncWithHttpInfo (EstabelecimentoPersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling CadastrarUsingPOST3");
            
    
            var localVarPath = "/api/estabelecimentos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstabelecimentoResponse)));
            
        }
        
        /// <summary>
        /// {{{grupo_economico_resource_cadastrar}}} {{{grupo_economico_resource_cadastrar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoEconomicoDTO">GrupoEconomicoDTO</param> 
        /// <returns>GrupoEconomicoResponse</returns>
        public GrupoEconomicoResponse CadastrarUsingPOST4 (GrupoEconomicoDTO grupoEconomicoDTO)
        {
             ApiResponse<GrupoEconomicoResponse> localVarResponse = CadastrarUsingPOST4WithHttpInfo(grupoEconomicoDTO);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{grupo_economico_resource_cadastrar}}} {{{grupo_economico_resource_cadastrar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoEconomicoDTO">GrupoEconomicoDTO</param> 
        /// <returns>ApiResponse of GrupoEconomicoResponse</returns>
        public ApiResponse< GrupoEconomicoResponse > CadastrarUsingPOST4WithHttpInfo (GrupoEconomicoDTO grupoEconomicoDTO)
        {
            
            // verify the required parameter 'grupoEconomicoDTO' is set
            if (grupoEconomicoDTO == null)
                throw new ApiException(400, "Missing required parameter 'grupoEconomicoDTO' when calling GlobaltagestabelecimentoApi->CadastrarUsingPOST4");
            
    
            var localVarPath = "/api/grupos-economicos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (grupoEconomicoDTO.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(grupoEconomicoDTO); // http body (model) parameter
            }
            else
            {
                localVarPostBody = grupoEconomicoDTO; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST4: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST4: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<GrupoEconomicoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GrupoEconomicoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GrupoEconomicoResponse)));
            
        }

        
        /// <summary>
        /// {{{grupo_economico_resource_cadastrar}}} {{{grupo_economico_resource_cadastrar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoEconomicoDTO">GrupoEconomicoDTO</param>
        /// <returns>Task of GrupoEconomicoResponse</returns>
        public async System.Threading.Tasks.Task<GrupoEconomicoResponse> CadastrarUsingPOST4Async (GrupoEconomicoDTO grupoEconomicoDTO)
        {
             ApiResponse<GrupoEconomicoResponse> localVarResponse = await CadastrarUsingPOST4AsyncWithHttpInfo(grupoEconomicoDTO);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{grupo_economico_resource_cadastrar}}} {{{grupo_economico_resource_cadastrar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoEconomicoDTO">GrupoEconomicoDTO</param>
        /// <returns>Task of ApiResponse (GrupoEconomicoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GrupoEconomicoResponse>> CadastrarUsingPOST4AsyncWithHttpInfo (GrupoEconomicoDTO grupoEconomicoDTO)
        {
            // verify the required parameter 'grupoEconomicoDTO' is set
            if (grupoEconomicoDTO == null) throw new ApiException(400, "Missing required parameter 'grupoEconomicoDTO' when calling CadastrarUsingPOST4");
            
    
            var localVarPath = "/api/grupos-economicos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (grupoEconomicoDTO.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(grupoEconomicoDTO); // http body (model) parameter
            }
            else
            {
                localVarPostBody = grupoEconomicoDTO; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST4: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST4: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GrupoEconomicoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GrupoEconomicoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GrupoEconomicoResponse)));
            
        }
        
        /// <summary>
        /// {{{operacao_resource_consulta_operacao}}} {{{operacao_resource_consulta_operacao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{operacao_resource_consulta_operacao_param_id_operacao}}}</param> 
        /// <returns>DetalheOperacaoResponse</returns>
        public DetalheOperacaoResponse ConsultaOperacaoUsingGET (long? id)
        {
             ApiResponse<DetalheOperacaoResponse> localVarResponse = ConsultaOperacaoUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{operacao_resource_consulta_operacao}}} {{{operacao_resource_consulta_operacao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{operacao_resource_consulta_operacao_param_id_operacao}}}</param> 
        /// <returns>ApiResponse of DetalheOperacaoResponse</returns>
        public ApiResponse< DetalheOperacaoResponse > ConsultaOperacaoUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagestabelecimentoApi->ConsultaOperacaoUsingGET");
            
    
            var localVarPath = "/api/tipos-operacoes-estabelecimentos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultaOperacaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultaOperacaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DetalheOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DetalheOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DetalheOperacaoResponse)));
            
        }

        
        /// <summary>
        /// {{{operacao_resource_consulta_operacao}}} {{{operacao_resource_consulta_operacao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{operacao_resource_consulta_operacao_param_id_operacao}}}</param>
        /// <returns>Task of DetalheOperacaoResponse</returns>
        public async System.Threading.Tasks.Task<DetalheOperacaoResponse> ConsultaOperacaoUsingGETAsync (long? id)
        {
             ApiResponse<DetalheOperacaoResponse> localVarResponse = await ConsultaOperacaoUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{operacao_resource_consulta_operacao}}} {{{operacao_resource_consulta_operacao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{operacao_resource_consulta_operacao_param_id_operacao}}}</param>
        /// <returns>Task of ApiResponse (DetalheOperacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DetalheOperacaoResponse>> ConsultaOperacaoUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultaOperacaoUsingGET");
            
    
            var localVarPath = "/api/tipos-operacoes-estabelecimentos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultaOperacaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultaOperacaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DetalheOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DetalheOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DetalheOperacaoResponse)));
            
        }
        
        /// <summary>
        /// {{{origem_comercial_resource_consultar_origem_comercial}}} {{{origem_comercial_resource_consultar_origem_comercial_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{origem_comercial_resource_consultar_origem_comercial_param_id}}}</param> 
        /// <returns>OrigemComercialResponse</returns>
        public OrigemComercialResponse ConsultarOrigemComercialUsingGET (long? id)
        {
             ApiResponse<OrigemComercialResponse> localVarResponse = ConsultarOrigemComercialUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{origem_comercial_resource_consultar_origem_comercial}}} {{{origem_comercial_resource_consultar_origem_comercial_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{origem_comercial_resource_consultar_origem_comercial_param_id}}}</param> 
        /// <returns>ApiResponse of OrigemComercialResponse</returns>
        public ApiResponse< OrigemComercialResponse > ConsultarOrigemComercialUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagestabelecimentoApi->ConsultarOrigemComercialUsingGET");
            
    
            var localVarPath = "/api/origens-comerciais/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarOrigemComercialUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarOrigemComercialUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OrigemComercialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrigemComercialResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrigemComercialResponse)));
            
        }

        
        /// <summary>
        /// {{{origem_comercial_resource_consultar_origem_comercial}}} {{{origem_comercial_resource_consultar_origem_comercial_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{origem_comercial_resource_consultar_origem_comercial_param_id}}}</param>
        /// <returns>Task of OrigemComercialResponse</returns>
        public async System.Threading.Tasks.Task<OrigemComercialResponse> ConsultarOrigemComercialUsingGETAsync (long? id)
        {
             ApiResponse<OrigemComercialResponse> localVarResponse = await ConsultarOrigemComercialUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{origem_comercial_resource_consultar_origem_comercial}}} {{{origem_comercial_resource_consultar_origem_comercial_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{origem_comercial_resource_consultar_origem_comercial_param_id}}}</param>
        /// <returns>Task of ApiResponse (OrigemComercialResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrigemComercialResponse>> ConsultarOrigemComercialUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarOrigemComercialUsingGET");
            
    
            var localVarPath = "/api/origens-comerciais/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarOrigemComercialUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarOrigemComercialUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrigemComercialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrigemComercialResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrigemComercialResponse)));
            
        }
        
        /// <summary>
        /// {{{estabelecimento_resource_consultar}}} {{{estabelecimento_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{estabelecimento_resource_consultar_param_id_estabelecimento}}}</param> 
        /// <returns>EstabelecimentoResponse</returns>
        public EstabelecimentoResponse ConsultarUsingGET18 (long? id)
        {
             ApiResponse<EstabelecimentoResponse> localVarResponse = ConsultarUsingGET18WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{estabelecimento_resource_consultar}}} {{{estabelecimento_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{estabelecimento_resource_consultar_param_id_estabelecimento}}}</param> 
        /// <returns>ApiResponse of EstabelecimentoResponse</returns>
        public ApiResponse< EstabelecimentoResponse > ConsultarUsingGET18WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagestabelecimentoApi->ConsultarUsingGET18");
            
    
            var localVarPath = "/api/estabelecimentos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET18: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET18: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstabelecimentoResponse)));
            
        }

        
        /// <summary>
        /// {{{estabelecimento_resource_consultar}}} {{{estabelecimento_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{estabelecimento_resource_consultar_param_id_estabelecimento}}}</param>
        /// <returns>Task of EstabelecimentoResponse</returns>
        public async System.Threading.Tasks.Task<EstabelecimentoResponse> ConsultarUsingGET18Async (long? id)
        {
             ApiResponse<EstabelecimentoResponse> localVarResponse = await ConsultarUsingGET18AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{estabelecimento_resource_consultar}}} {{{estabelecimento_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{estabelecimento_resource_consultar_param_id_estabelecimento}}}</param>
        /// <returns>Task of ApiResponse (EstabelecimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EstabelecimentoResponse>> ConsultarUsingGET18AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET18");
            
    
            var localVarPath = "/api/estabelecimentos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET18: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET18: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstabelecimentoResponse)));
            
        }
        
        /// <summary>
        /// {{{grupo_economico_resource_consultar}}} {{{grupo_economico_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{grupo_economico_resource_consultar_param_id}}}</param> 
        /// <returns>GrupoEconomicoResponse</returns>
        public GrupoEconomicoResponse ConsultarUsingGET20 (long? id)
        {
             ApiResponse<GrupoEconomicoResponse> localVarResponse = ConsultarUsingGET20WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{grupo_economico_resource_consultar}}} {{{grupo_economico_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{grupo_economico_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of GrupoEconomicoResponse</returns>
        public ApiResponse< GrupoEconomicoResponse > ConsultarUsingGET20WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagestabelecimentoApi->ConsultarUsingGET20");
            
    
            var localVarPath = "/api/grupos-economicos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET20: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET20: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<GrupoEconomicoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GrupoEconomicoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GrupoEconomicoResponse)));
            
        }

        
        /// <summary>
        /// {{{grupo_economico_resource_consultar}}} {{{grupo_economico_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{grupo_economico_resource_consultar_param_id}}}</param>
        /// <returns>Task of GrupoEconomicoResponse</returns>
        public async System.Threading.Tasks.Task<GrupoEconomicoResponse> ConsultarUsingGET20Async (long? id)
        {
             ApiResponse<GrupoEconomicoResponse> localVarResponse = await ConsultarUsingGET20AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{grupo_economico_resource_consultar}}} {{{grupo_economico_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{grupo_economico_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (GrupoEconomicoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GrupoEconomicoResponse>> ConsultarUsingGET20AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET20");
            
    
            var localVarPath = "/api/grupos-economicos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET20: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET20: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GrupoEconomicoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GrupoEconomicoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GrupoEconomicoResponse)));
            
        }
        
        /// <summary>
        /// {{{maquineta_resource_consultar}}} {{{maquineta_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{maquineta_resource_consultar_param_id}}}</param> 
        /// <returns>MaquinetaResponse</returns>
        public MaquinetaResponse ConsultarUsingGET22 (long? id)
        {
             ApiResponse<MaquinetaResponse> localVarResponse = ConsultarUsingGET22WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{maquineta_resource_consultar}}} {{{maquineta_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{maquineta_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of MaquinetaResponse</returns>
        public ApiResponse< MaquinetaResponse > ConsultarUsingGET22WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagestabelecimentoApi->ConsultarUsingGET22");
            
    
            var localVarPath = "/api/maquinetas/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET22: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET22: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<MaquinetaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MaquinetaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaquinetaResponse)));
            
        }

        
        /// <summary>
        /// {{{maquineta_resource_consultar}}} {{{maquineta_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{maquineta_resource_consultar_param_id}}}</param>
        /// <returns>Task of MaquinetaResponse</returns>
        public async System.Threading.Tasks.Task<MaquinetaResponse> ConsultarUsingGET22Async (long? id)
        {
             ApiResponse<MaquinetaResponse> localVarResponse = await ConsultarUsingGET22AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{maquineta_resource_consultar}}} {{{maquineta_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{maquineta_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (MaquinetaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MaquinetaResponse>> ConsultarUsingGET22AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET22");
            
    
            var localVarPath = "/api/maquinetas/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET22: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET22: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MaquinetaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MaquinetaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaquinetaResponse)));
            
        }
        
        /// <summary>
        /// {{{operacao_credor_resource_consultar}}} {{{operacao_credor_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{operacao_credor_resource_consultar_param_id}}}</param> 
        /// <returns>OperacaoCredorResponse</returns>
        public OperacaoCredorResponse ConsultarUsingGET23 (long? id)
        {
             ApiResponse<OperacaoCredorResponse> localVarResponse = ConsultarUsingGET23WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{operacao_credor_resource_consultar}}} {{{operacao_credor_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{operacao_credor_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of OperacaoCredorResponse</returns>
        public ApiResponse< OperacaoCredorResponse > ConsultarUsingGET23WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagestabelecimentoApi->ConsultarUsingGET23");
            
    
            var localVarPath = "/api/regras-operacoes-estabelecimentos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET23: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET23: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OperacaoCredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OperacaoCredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperacaoCredorResponse)));
            
        }

        
        /// <summary>
        /// {{{operacao_credor_resource_consultar}}} {{{operacao_credor_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{operacao_credor_resource_consultar_param_id}}}</param>
        /// <returns>Task of OperacaoCredorResponse</returns>
        public async System.Threading.Tasks.Task<OperacaoCredorResponse> ConsultarUsingGET23Async (long? id)
        {
             ApiResponse<OperacaoCredorResponse> localVarResponse = await ConsultarUsingGET23AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{operacao_credor_resource_consultar}}} {{{operacao_credor_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{operacao_credor_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (OperacaoCredorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OperacaoCredorResponse>> ConsultarUsingGET23AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET23");
            
    
            var localVarPath = "/api/regras-operacoes-estabelecimentos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET23: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET23: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OperacaoCredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OperacaoCredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperacaoCredorResponse)));
            
        }
        
        /// <summary>
        /// {{{telefone_estabelecimento_resource_consultar}}} {{{telefone_estabelecimento_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{telefone_estabelecimento_resource_consultar_param_id}}}</param> 
        /// <returns>TelefoneEstabelecimentoResponse</returns>
        public TelefoneEstabelecimentoResponse ConsultarUsingGET34 (long? id)
        {
             ApiResponse<TelefoneEstabelecimentoResponse> localVarResponse = ConsultarUsingGET34WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{telefone_estabelecimento_resource_consultar}}} {{{telefone_estabelecimento_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{telefone_estabelecimento_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of TelefoneEstabelecimentoResponse</returns>
        public ApiResponse< TelefoneEstabelecimentoResponse > ConsultarUsingGET34WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagestabelecimentoApi->ConsultarUsingGET34");
            
    
            var localVarPath = "/api/telefones-estabelecimentos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET34: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET34: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TelefoneEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneEstabelecimentoResponse)));
            
        }

        
        /// <summary>
        /// {{{telefone_estabelecimento_resource_consultar}}} {{{telefone_estabelecimento_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{telefone_estabelecimento_resource_consultar_param_id}}}</param>
        /// <returns>Task of TelefoneEstabelecimentoResponse</returns>
        public async System.Threading.Tasks.Task<TelefoneEstabelecimentoResponse> ConsultarUsingGET34Async (long? id)
        {
             ApiResponse<TelefoneEstabelecimentoResponse> localVarResponse = await ConsultarUsingGET34AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{telefone_estabelecimento_resource_consultar}}} {{{telefone_estabelecimento_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{telefone_estabelecimento_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (TelefoneEstabelecimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TelefoneEstabelecimentoResponse>> ConsultarUsingGET34AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET34");
            
    
            var localVarPath = "/api/telefones-estabelecimentos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET34: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET34: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TelefoneEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneEstabelecimentoResponse)));
            
        }
        
        /// <summary>
        /// {{{terminal_resource_consultar}}} {{{terminal_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{terminal_resource_consultar_param_id}}}</param> 
        /// <returns>TerminalResponse</returns>
        public TerminalResponse ConsultarUsingGET36 (long? id)
        {
             ApiResponse<TerminalResponse> localVarResponse = ConsultarUsingGET36WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{terminal_resource_consultar}}} {{{terminal_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{terminal_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of TerminalResponse</returns>
        public ApiResponse< TerminalResponse > ConsultarUsingGET36WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagestabelecimentoApi->ConsultarUsingGET36");
            
    
            var localVarPath = "/api/terminais/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
    
            return new ApiResponse<TerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TerminalResponse)));
            
        }

        
        /// <summary>
        /// {{{terminal_resource_consultar}}} {{{terminal_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{terminal_resource_consultar_param_id}}}</param>
        /// <returns>Task of TerminalResponse</returns>
        public async System.Threading.Tasks.Task<TerminalResponse> ConsultarUsingGET36Async (long? id)
        {
             ApiResponse<TerminalResponse> localVarResponse = await ConsultarUsingGET36AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{terminal_resource_consultar}}} {{{terminal_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{terminal_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (TerminalResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TerminalResponse>> ConsultarUsingGET36AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET36");
            
    
            var localVarPath = "/api/terminais/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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

            return new ApiResponse<TerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TerminalResponse)));
            
        }
        
        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_consultar}}} {{{vinculo_estabelecimento_adquirente_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_estabelecimento_adquirente_resource_consultar_param_id}}}</param> 
        /// <returns>VinculoEstabelecimentoAdquirenteResponse</returns>
        public VinculoEstabelecimentoAdquirenteResponse ConsultarUsingGET47 (long? id)
        {
             ApiResponse<VinculoEstabelecimentoAdquirenteResponse> localVarResponse = ConsultarUsingGET47WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_consultar}}} {{{vinculo_estabelecimento_adquirente_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_estabelecimento_adquirente_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of VinculoEstabelecimentoAdquirenteResponse</returns>
        public ApiResponse< VinculoEstabelecimentoAdquirenteResponse > ConsultarUsingGET47WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagestabelecimentoApi->ConsultarUsingGET47");
            
    
            var localVarPath = "/api/adquirentes-estabelecimento/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET47: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET47: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<VinculoEstabelecimentoAdquirenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VinculoEstabelecimentoAdquirenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VinculoEstabelecimentoAdquirenteResponse)));
            
        }

        
        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_consultar}}} {{{vinculo_estabelecimento_adquirente_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_estabelecimento_adquirente_resource_consultar_param_id}}}</param>
        /// <returns>Task of VinculoEstabelecimentoAdquirenteResponse</returns>
        public async System.Threading.Tasks.Task<VinculoEstabelecimentoAdquirenteResponse> ConsultarUsingGET47Async (long? id)
        {
             ApiResponse<VinculoEstabelecimentoAdquirenteResponse> localVarResponse = await ConsultarUsingGET47AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_consultar}}} {{{vinculo_estabelecimento_adquirente_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_estabelecimento_adquirente_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (VinculoEstabelecimentoAdquirenteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VinculoEstabelecimentoAdquirenteResponse>> ConsultarUsingGET47AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET47");
            
    
            var localVarPath = "/api/adquirentes-estabelecimento/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET47: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET47: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VinculoEstabelecimentoAdquirenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VinculoEstabelecimentoAdquirenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VinculoEstabelecimentoAdquirenteResponse)));
            
        }
        
        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_desabilitar_vinculo}}} {{{vinculo_estabelecimento_adquirente_resource_desabilitar_vinculo_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_estabelecimento_adquirente_resource_desabilitar_vinculo_param_id}}}</param> 
        /// <returns>Object</returns>
        public Object DesabilitarVinculoUsingPOST (long? id)
        {
             ApiResponse<Object> localVarResponse = DesabilitarVinculoUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_desabilitar_vinculo}}} {{{vinculo_estabelecimento_adquirente_resource_desabilitar_vinculo_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_estabelecimento_adquirente_resource_desabilitar_vinculo_param_id}}}</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > DesabilitarVinculoUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagestabelecimentoApi->DesabilitarVinculoUsingPOST");
            
    
            var localVarPath = "/api/adquirentes-estabelecimento/{id}/desabilitar";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling DesabilitarVinculoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesabilitarVinculoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_desabilitar_vinculo}}} {{{vinculo_estabelecimento_adquirente_resource_desabilitar_vinculo_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_estabelecimento_adquirente_resource_desabilitar_vinculo_param_id}}}</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> DesabilitarVinculoUsingPOSTAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await DesabilitarVinculoUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_desabilitar_vinculo}}} {{{vinculo_estabelecimento_adquirente_resource_desabilitar_vinculo_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_estabelecimento_adquirente_resource_desabilitar_vinculo_param_id}}}</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DesabilitarVinculoUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesabilitarVinculoUsingPOST");
            
    
            var localVarPath = "/api/adquirentes-estabelecimento/{id}/desabilitar";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling DesabilitarVinculoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesabilitarVinculoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// {{{vinculo_operacao_resource_desabilitar_vinculo}}} {{{vinculo_operacao_resource_desabilitar_vinculo_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_operacao_resource_desabilitar_vinculo_param_id}}}</param> 
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param> 
        /// <returns>Object</returns>
        public Object DesabilitarVinculoUsingPOST1 (long? id, VinculoOperacaoPersist vinculoOperacaoPersist)
        {
             ApiResponse<Object> localVarResponse = DesabilitarVinculoUsingPOST1WithHttpInfo(id, vinculoOperacaoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{vinculo_operacao_resource_desabilitar_vinculo}}} {{{vinculo_operacao_resource_desabilitar_vinculo_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_operacao_resource_desabilitar_vinculo_param_id}}}</param> 
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > DesabilitarVinculoUsingPOST1WithHttpInfo (long? id, VinculoOperacaoPersist vinculoOperacaoPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagestabelecimentoApi->DesabilitarVinculoUsingPOST1");
            
            // verify the required parameter 'vinculoOperacaoPersist' is set
            if (vinculoOperacaoPersist == null)
                throw new ApiException(400, "Missing required parameter 'vinculoOperacaoPersist' when calling GlobaltagestabelecimentoApi->DesabilitarVinculoUsingPOST1");
            
    
            var localVarPath = "/api/estabelecimentos/{id}/desabilitar-operacao";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (vinculoOperacaoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(vinculoOperacaoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = vinculoOperacaoPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesabilitarVinculoUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesabilitarVinculoUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// {{{vinculo_operacao_resource_desabilitar_vinculo}}} {{{vinculo_operacao_resource_desabilitar_vinculo_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_operacao_resource_desabilitar_vinculo_param_id}}}</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> DesabilitarVinculoUsingPOST1Async (long? id, VinculoOperacaoPersist vinculoOperacaoPersist)
        {
             ApiResponse<Object> localVarResponse = await DesabilitarVinculoUsingPOST1AsyncWithHttpInfo(id, vinculoOperacaoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{vinculo_operacao_resource_desabilitar_vinculo}}} {{{vinculo_operacao_resource_desabilitar_vinculo_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_operacao_resource_desabilitar_vinculo_param_id}}}</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DesabilitarVinculoUsingPOST1AsyncWithHttpInfo (long? id, VinculoOperacaoPersist vinculoOperacaoPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesabilitarVinculoUsingPOST1");
            // verify the required parameter 'vinculoOperacaoPersist' is set
            if (vinculoOperacaoPersist == null) throw new ApiException(400, "Missing required parameter 'vinculoOperacaoPersist' when calling DesabilitarVinculoUsingPOST1");
            
    
            var localVarPath = "/api/estabelecimentos/{id}/desabilitar-operacao";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (vinculoOperacaoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(vinculoOperacaoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = vinculoOperacaoPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesabilitarVinculoUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesabilitarVinculoUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_habilitar_vinculo}}} {{{vinculo_estabelecimento_adquirente_resource_habilitar_vinculo_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_estabelecimento_adquirente_resource_habilitar_vinculo_param_id}}}</param> 
        /// <returns>Object</returns>
        public Object HabilitarVinculoUsingPOST (long? id)
        {
             ApiResponse<Object> localVarResponse = HabilitarVinculoUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_habilitar_vinculo}}} {{{vinculo_estabelecimento_adquirente_resource_habilitar_vinculo_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_estabelecimento_adquirente_resource_habilitar_vinculo_param_id}}}</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > HabilitarVinculoUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagestabelecimentoApi->HabilitarVinculoUsingPOST");
            
    
            var localVarPath = "/api/adquirentes-estabelecimento/{id}/habilitar";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling HabilitarVinculoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling HabilitarVinculoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_habilitar_vinculo}}} {{{vinculo_estabelecimento_adquirente_resource_habilitar_vinculo_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_estabelecimento_adquirente_resource_habilitar_vinculo_param_id}}}</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> HabilitarVinculoUsingPOSTAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await HabilitarVinculoUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_habilitar_vinculo}}} {{{vinculo_estabelecimento_adquirente_resource_habilitar_vinculo_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_estabelecimento_adquirente_resource_habilitar_vinculo_param_id}}}</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> HabilitarVinculoUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling HabilitarVinculoUsingPOST");
            
    
            var localVarPath = "/api/adquirentes-estabelecimento/{id}/habilitar";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling HabilitarVinculoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling HabilitarVinculoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// {{{vinculo_operacao_resource_habilitar_vinculo}}} {{{vinculo_operacao_resource_habilitar_vinculo_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_operacao_resource_habilitar_vinculo_param_id}}}</param> 
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param> 
        /// <returns>Object</returns>
        public Object HabilitarVinculoUsingPOST1 (long? id, VinculoOperacaoPersist vinculoOperacaoPersist)
        {
             ApiResponse<Object> localVarResponse = HabilitarVinculoUsingPOST1WithHttpInfo(id, vinculoOperacaoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{vinculo_operacao_resource_habilitar_vinculo}}} {{{vinculo_operacao_resource_habilitar_vinculo_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_operacao_resource_habilitar_vinculo_param_id}}}</param> 
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > HabilitarVinculoUsingPOST1WithHttpInfo (long? id, VinculoOperacaoPersist vinculoOperacaoPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagestabelecimentoApi->HabilitarVinculoUsingPOST1");
            
            // verify the required parameter 'vinculoOperacaoPersist' is set
            if (vinculoOperacaoPersist == null)
                throw new ApiException(400, "Missing required parameter 'vinculoOperacaoPersist' when calling GlobaltagestabelecimentoApi->HabilitarVinculoUsingPOST1");
            
    
            var localVarPath = "/api/estabelecimentos/{id}/habilitar-operacao";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (vinculoOperacaoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(vinculoOperacaoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = vinculoOperacaoPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling HabilitarVinculoUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling HabilitarVinculoUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// {{{vinculo_operacao_resource_habilitar_vinculo}}} {{{vinculo_operacao_resource_habilitar_vinculo_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_operacao_resource_habilitar_vinculo_param_id}}}</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> HabilitarVinculoUsingPOST1Async (long? id, VinculoOperacaoPersist vinculoOperacaoPersist)
        {
             ApiResponse<Object> localVarResponse = await HabilitarVinculoUsingPOST1AsyncWithHttpInfo(id, vinculoOperacaoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{vinculo_operacao_resource_habilitar_vinculo}}} {{{vinculo_operacao_resource_habilitar_vinculo_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_operacao_resource_habilitar_vinculo_param_id}}}</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> HabilitarVinculoUsingPOST1AsyncWithHttpInfo (long? id, VinculoOperacaoPersist vinculoOperacaoPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling HabilitarVinculoUsingPOST1");
            // verify the required parameter 'vinculoOperacaoPersist' is set
            if (vinculoOperacaoPersist == null) throw new ApiException(400, "Missing required parameter 'vinculoOperacaoPersist' when calling HabilitarVinculoUsingPOST1");
            
    
            var localVarPath = "/api/estabelecimentos/{id}/habilitar-operacao";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (vinculoOperacaoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(vinculoOperacaoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = vinculoOperacaoPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling HabilitarVinculoUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling HabilitarVinculoUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// {{{operacao_resource_lista_operacao}}} {{{operacao_resource_lista_operacao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idOperacao">{{{operacao_request_id_operacao_value}}} (optional)</param> 
        /// <param name="codigoProcessamento">{{{operacao_request_codigo_processamento_value}}} (optional)</param> 
        /// <param name="nomeOperacao">{{{operacao_request_nome_operacao_value}}} (optional)</param> 
        /// <returns>PageOperacaoResponse</returns>
        public PageOperacaoResponse ListaOperacaoUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, string codigoProcessamento = null, string nomeOperacao = null)
        {
             ApiResponse<PageOperacaoResponse> localVarResponse = ListaOperacaoUsingGETWithHttpInfo(sort, page, limit, idOperacao, codigoProcessamento, nomeOperacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{operacao_resource_lista_operacao}}} {{{operacao_resource_lista_operacao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idOperacao">{{{operacao_request_id_operacao_value}}} (optional)</param> 
        /// <param name="codigoProcessamento">{{{operacao_request_codigo_processamento_value}}} (optional)</param> 
        /// <param name="nomeOperacao">{{{operacao_request_nome_operacao_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageOperacaoResponse</returns>
        public ApiResponse< PageOperacaoResponse > ListaOperacaoUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, string codigoProcessamento = null, string nomeOperacao = null)
        {
            
    
            var localVarPath = "/api/tipos-operacoes-estabelecimentos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idOperacao != null) localVarQueryParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // query parameter
            if (codigoProcessamento != null) localVarQueryParams.Add("codigoProcessamento", Configuration.ApiClient.ParameterToString(codigoProcessamento)); // query parameter
            if (nomeOperacao != null) localVarQueryParams.Add("nomeOperacao", Configuration.ApiClient.ParameterToString(nomeOperacao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListaOperacaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListaOperacaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOperacaoResponse)));
            
        }

        
        /// <summary>
        /// {{{operacao_resource_lista_operacao}}} {{{operacao_resource_lista_operacao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idOperacao">{{{operacao_request_id_operacao_value}}} (optional)</param>
        /// <param name="codigoProcessamento">{{{operacao_request_codigo_processamento_value}}} (optional)</param>
        /// <param name="nomeOperacao">{{{operacao_request_nome_operacao_value}}} (optional)</param>
        /// <returns>Task of PageOperacaoResponse</returns>
        public async System.Threading.Tasks.Task<PageOperacaoResponse> ListaOperacaoUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, string codigoProcessamento = null, string nomeOperacao = null)
        {
             ApiResponse<PageOperacaoResponse> localVarResponse = await ListaOperacaoUsingGETAsyncWithHttpInfo(sort, page, limit, idOperacao, codigoProcessamento, nomeOperacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{operacao_resource_lista_operacao}}} {{{operacao_resource_lista_operacao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idOperacao">{{{operacao_request_id_operacao_value}}} (optional)</param>
        /// <param name="codigoProcessamento">{{{operacao_request_codigo_processamento_value}}} (optional)</param>
        /// <param name="nomeOperacao">{{{operacao_request_nome_operacao_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageOperacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageOperacaoResponse>> ListaOperacaoUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, string codigoProcessamento = null, string nomeOperacao = null)
        {
            
    
            var localVarPath = "/api/tipos-operacoes-estabelecimentos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idOperacao != null) localVarQueryParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // query parameter
            if (codigoProcessamento != null) localVarQueryParams.Add("codigoProcessamento", Configuration.ApiClient.ParameterToString(codigoProcessamento)); // query parameter
            if (nomeOperacao != null) localVarQueryParams.Add("nomeOperacao", Configuration.ApiClient.ParameterToString(nomeOperacao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListaOperacaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListaOperacaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOperacaoResponse)));
            
        }
        
        /// <summary>
        /// {{{m_c_c_resource_listar_m_c_c}}} {{{m_c_c_resource_listar_m_c_c_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>PageMCCResponse</returns>
        public PageMCCResponse ListarMCCUsingGET (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageMCCResponse> localVarResponse = ListarMCCUsingGETWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{m_c_c_resource_listar_m_c_c}}} {{{m_c_c_resource_listar_m_c_c_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>ApiResponse of PageMCCResponse</returns>
        public ApiResponse< PageMCCResponse > ListarMCCUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/mcc-estabelecimentos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ListarMCCUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarMCCUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageMCCResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageMCCResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageMCCResponse)));
            
        }

        
        /// <summary>
        /// {{{m_c_c_resource_listar_m_c_c}}} {{{m_c_c_resource_listar_m_c_c_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageMCCResponse</returns>
        public async System.Threading.Tasks.Task<PageMCCResponse> ListarMCCUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageMCCResponse> localVarResponse = await ListarMCCUsingGETAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{m_c_c_resource_listar_m_c_c}}} {{{m_c_c_resource_listar_m_c_c_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageMCCResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageMCCResponse>> ListarMCCUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/mcc-estabelecimentos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ListarMCCUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarMCCUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageMCCResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageMCCResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageMCCResponse)));
            
        }
        
        /// <summary>
        /// {{{origem_comercial_resource_listar_origens_comerciais}}} {{{origem_comercial_resource_listar_origens_comerciais_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{origem_comercial_request_id_value}}} (optional)</param> 
        /// <param name="nome">{{{origem_comercial_request_nome_value}}} (optional)</param> 
        /// <param name="status">{{{origem_comercial_request_status_value}}} (optional)</param> 
        /// <param name="idEstabelecimento">{{{origem_comercial_request_id_estabelecimento_value}}} (optional)</param> 
        /// <param name="idProduto">{{{origem_comercial_request_id_produto_value}}} (optional)</param> 
        /// <param name="descricao">{{{origem_comercial_request_descricao_value}}} (optional)</param> 
        /// <param name="idTipoOrigemComercial">{{{origem_comercial_request_id_tipo_origem_comercial_value}}} (optional)</param> 
        /// <param name="idGrupoOrigemComercial">{{{origem_comercial_request_id_grupo_origem_comercial_value}}} (optional)</param> 
        /// <param name="flagPreAprovado">{{{origem_comercial_request_flag_pre_aprovado_value}}} (optional)</param> 
        /// <param name="flagAprovacaoImediata">{{{origem_comercial_request_flag_aprovacao_imediata_value}}} (optional)</param> 
        /// <param name="nomeFantasiaPlastico">{{{origem_comercial_request_nome_fantasia_plastico_value}}} (optional)</param> 
        /// <param name="flagCartaoProvisorio">{{{origem_comercial_request_flag_cartao_provisorio_value}}} (optional)</param> 
        /// <param name="flagCartaoDefinitivo">{{{origem_comercial_request_flag_cartao_definitivo_value}}} (optional)</param> 
        /// <param name="usuario">{{{origem_comercial_request_usuario_value}}} (optional)</param> 
        /// <param name="senha">{{{origem_comercial_request_senha_value}}} (optional)</param> 
        /// <param name="flagOrigemExterna">{{{origem_comercial_request_flag_origem_externa_value}}} (optional)</param> 
        /// <param name="flagModificado">{{{origem_comercial_request_flag_modificado_value}}} (optional)</param> 
        /// <param name="flagEnviaFaturaUsuario">{{{origem_comercial_request_flag_envia_fatura_usuario_value}}} (optional)</param> 
        /// <param name="flagCreditoFaturamento">{{{origem_comercial_request_flag_credito_faturamento_value}}} (optional)</param> 
        /// <param name="flagConcedeLimiteProvisorio">{{{origem_comercial_request_flag_concede_limite_provisorio_value}}} (optional)</param> 
        /// <param name="flagDigitalizarDoc">{{{origem_comercial_request_flag_digitalizar_doc_value}}} (optional)</param> 
        /// <param name="flagEmbossingLoja">{{{origem_comercial_request_flag_embossing_loja_value}}} (optional)</param> 
        /// <param name="flagConsultaPrevia">{{{origem_comercial_request_flag_consulta_previa_value}}} (optional)</param> 
        /// <param name="tipoPessoa">{{{origem_comercial_request_tipo_pessoa_value}}} (optional)</param> 
        /// <returns>PageOrigemComercialResponse</returns>
        public PageOrigemComercialResponse ListarOrigensComerciaisUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null, long? idEstabelecimento = null, long? idProduto = null, string descricao = null, long? idTipoOrigemComercial = null, long? idGrupoOrigemComercial = null, bool? flagPreAprovado = null, bool? flagAprovacaoImediata = null, string nomeFantasiaPlastico = null, bool? flagCartaoProvisorio = null, bool? flagCartaoDefinitivo = null, string usuario = null, string senha = null, bool? flagOrigemExterna = null, bool? flagModificado = null, bool? flagEnviaFaturaUsuario = null, bool? flagCreditoFaturamento = null, bool? flagConcedeLimiteProvisorio = null, bool? flagDigitalizarDoc = null, bool? flagEmbossingLoja = null, bool? flagConsultaPrevia = null, string tipoPessoa = null)
        {
             ApiResponse<PageOrigemComercialResponse> localVarResponse = ListarOrigensComerciaisUsingGETWithHttpInfo(sort, page, limit, id, nome, status, idEstabelecimento, idProduto, descricao, idTipoOrigemComercial, idGrupoOrigemComercial, flagPreAprovado, flagAprovacaoImediata, nomeFantasiaPlastico, flagCartaoProvisorio, flagCartaoDefinitivo, usuario, senha, flagOrigemExterna, flagModificado, flagEnviaFaturaUsuario, flagCreditoFaturamento, flagConcedeLimiteProvisorio, flagDigitalizarDoc, flagEmbossingLoja, flagConsultaPrevia, tipoPessoa);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{origem_comercial_resource_listar_origens_comerciais}}} {{{origem_comercial_resource_listar_origens_comerciais_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{origem_comercial_request_id_value}}} (optional)</param> 
        /// <param name="nome">{{{origem_comercial_request_nome_value}}} (optional)</param> 
        /// <param name="status">{{{origem_comercial_request_status_value}}} (optional)</param> 
        /// <param name="idEstabelecimento">{{{origem_comercial_request_id_estabelecimento_value}}} (optional)</param> 
        /// <param name="idProduto">{{{origem_comercial_request_id_produto_value}}} (optional)</param> 
        /// <param name="descricao">{{{origem_comercial_request_descricao_value}}} (optional)</param> 
        /// <param name="idTipoOrigemComercial">{{{origem_comercial_request_id_tipo_origem_comercial_value}}} (optional)</param> 
        /// <param name="idGrupoOrigemComercial">{{{origem_comercial_request_id_grupo_origem_comercial_value}}} (optional)</param> 
        /// <param name="flagPreAprovado">{{{origem_comercial_request_flag_pre_aprovado_value}}} (optional)</param> 
        /// <param name="flagAprovacaoImediata">{{{origem_comercial_request_flag_aprovacao_imediata_value}}} (optional)</param> 
        /// <param name="nomeFantasiaPlastico">{{{origem_comercial_request_nome_fantasia_plastico_value}}} (optional)</param> 
        /// <param name="flagCartaoProvisorio">{{{origem_comercial_request_flag_cartao_provisorio_value}}} (optional)</param> 
        /// <param name="flagCartaoDefinitivo">{{{origem_comercial_request_flag_cartao_definitivo_value}}} (optional)</param> 
        /// <param name="usuario">{{{origem_comercial_request_usuario_value}}} (optional)</param> 
        /// <param name="senha">{{{origem_comercial_request_senha_value}}} (optional)</param> 
        /// <param name="flagOrigemExterna">{{{origem_comercial_request_flag_origem_externa_value}}} (optional)</param> 
        /// <param name="flagModificado">{{{origem_comercial_request_flag_modificado_value}}} (optional)</param> 
        /// <param name="flagEnviaFaturaUsuario">{{{origem_comercial_request_flag_envia_fatura_usuario_value}}} (optional)</param> 
        /// <param name="flagCreditoFaturamento">{{{origem_comercial_request_flag_credito_faturamento_value}}} (optional)</param> 
        /// <param name="flagConcedeLimiteProvisorio">{{{origem_comercial_request_flag_concede_limite_provisorio_value}}} (optional)</param> 
        /// <param name="flagDigitalizarDoc">{{{origem_comercial_request_flag_digitalizar_doc_value}}} (optional)</param> 
        /// <param name="flagEmbossingLoja">{{{origem_comercial_request_flag_embossing_loja_value}}} (optional)</param> 
        /// <param name="flagConsultaPrevia">{{{origem_comercial_request_flag_consulta_previa_value}}} (optional)</param> 
        /// <param name="tipoPessoa">{{{origem_comercial_request_tipo_pessoa_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageOrigemComercialResponse</returns>
        public ApiResponse< PageOrigemComercialResponse > ListarOrigensComerciaisUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null, long? idEstabelecimento = null, long? idProduto = null, string descricao = null, long? idTipoOrigemComercial = null, long? idGrupoOrigemComercial = null, bool? flagPreAprovado = null, bool? flagAprovacaoImediata = null, string nomeFantasiaPlastico = null, bool? flagCartaoProvisorio = null, bool? flagCartaoDefinitivo = null, string usuario = null, string senha = null, bool? flagOrigemExterna = null, bool? flagModificado = null, bool? flagEnviaFaturaUsuario = null, bool? flagCreditoFaturamento = null, bool? flagConcedeLimiteProvisorio = null, bool? flagDigitalizarDoc = null, bool? flagEmbossingLoja = null, bool? flagConsultaPrevia = null, string tipoPessoa = null)
        {
            
    
            var localVarPath = "/api/origens-comerciais";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (idTipoOrigemComercial != null) localVarQueryParams.Add("idTipoOrigemComercial", Configuration.ApiClient.ParameterToString(idTipoOrigemComercial)); // query parameter
            if (idGrupoOrigemComercial != null) localVarQueryParams.Add("idGrupoOrigemComercial", Configuration.ApiClient.ParameterToString(idGrupoOrigemComercial)); // query parameter
            if (flagPreAprovado != null) localVarQueryParams.Add("flagPreAprovado", Configuration.ApiClient.ParameterToString(flagPreAprovado)); // query parameter
            if (flagAprovacaoImediata != null) localVarQueryParams.Add("flagAprovacaoImediata", Configuration.ApiClient.ParameterToString(flagAprovacaoImediata)); // query parameter
            if (nomeFantasiaPlastico != null) localVarQueryParams.Add("nomeFantasiaPlastico", Configuration.ApiClient.ParameterToString(nomeFantasiaPlastico)); // query parameter
            if (flagCartaoProvisorio != null) localVarQueryParams.Add("flagCartaoProvisorio", Configuration.ApiClient.ParameterToString(flagCartaoProvisorio)); // query parameter
            if (flagCartaoDefinitivo != null) localVarQueryParams.Add("flagCartaoDefinitivo", Configuration.ApiClient.ParameterToString(flagCartaoDefinitivo)); // query parameter
            if (usuario != null) localVarQueryParams.Add("usuario", Configuration.ApiClient.ParameterToString(usuario)); // query parameter
            if (senha != null) localVarQueryParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // query parameter
            if (flagOrigemExterna != null) localVarQueryParams.Add("flagOrigemExterna", Configuration.ApiClient.ParameterToString(flagOrigemExterna)); // query parameter
            if (flagModificado != null) localVarQueryParams.Add("flagModificado", Configuration.ApiClient.ParameterToString(flagModificado)); // query parameter
            if (flagEnviaFaturaUsuario != null) localVarQueryParams.Add("flagEnviaFaturaUsuario", Configuration.ApiClient.ParameterToString(flagEnviaFaturaUsuario)); // query parameter
            if (flagCreditoFaturamento != null) localVarQueryParams.Add("flagCreditoFaturamento", Configuration.ApiClient.ParameterToString(flagCreditoFaturamento)); // query parameter
            if (flagConcedeLimiteProvisorio != null) localVarQueryParams.Add("flagConcedeLimiteProvisorio", Configuration.ApiClient.ParameterToString(flagConcedeLimiteProvisorio)); // query parameter
            if (flagDigitalizarDoc != null) localVarQueryParams.Add("flagDigitalizarDoc", Configuration.ApiClient.ParameterToString(flagDigitalizarDoc)); // query parameter
            if (flagEmbossingLoja != null) localVarQueryParams.Add("flagEmbossingLoja", Configuration.ApiClient.ParameterToString(flagEmbossingLoja)); // query parameter
            if (flagConsultaPrevia != null) localVarQueryParams.Add("flagConsultaPrevia", Configuration.ApiClient.ParameterToString(flagConsultaPrevia)); // query parameter
            if (tipoPessoa != null) localVarQueryParams.Add("tipoPessoa", Configuration.ApiClient.ParameterToString(tipoPessoa)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarOrigensComerciaisUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarOrigensComerciaisUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageOrigemComercialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOrigemComercialResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOrigemComercialResponse)));
            
        }

        
        /// <summary>
        /// {{{origem_comercial_resource_listar_origens_comerciais}}} {{{origem_comercial_resource_listar_origens_comerciais_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{origem_comercial_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{origem_comercial_request_nome_value}}} (optional)</param>
        /// <param name="status">{{{origem_comercial_request_status_value}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{origem_comercial_request_id_estabelecimento_value}}} (optional)</param>
        /// <param name="idProduto">{{{origem_comercial_request_id_produto_value}}} (optional)</param>
        /// <param name="descricao">{{{origem_comercial_request_descricao_value}}} (optional)</param>
        /// <param name="idTipoOrigemComercial">{{{origem_comercial_request_id_tipo_origem_comercial_value}}} (optional)</param>
        /// <param name="idGrupoOrigemComercial">{{{origem_comercial_request_id_grupo_origem_comercial_value}}} (optional)</param>
        /// <param name="flagPreAprovado">{{{origem_comercial_request_flag_pre_aprovado_value}}} (optional)</param>
        /// <param name="flagAprovacaoImediata">{{{origem_comercial_request_flag_aprovacao_imediata_value}}} (optional)</param>
        /// <param name="nomeFantasiaPlastico">{{{origem_comercial_request_nome_fantasia_plastico_value}}} (optional)</param>
        /// <param name="flagCartaoProvisorio">{{{origem_comercial_request_flag_cartao_provisorio_value}}} (optional)</param>
        /// <param name="flagCartaoDefinitivo">{{{origem_comercial_request_flag_cartao_definitivo_value}}} (optional)</param>
        /// <param name="usuario">{{{origem_comercial_request_usuario_value}}} (optional)</param>
        /// <param name="senha">{{{origem_comercial_request_senha_value}}} (optional)</param>
        /// <param name="flagOrigemExterna">{{{origem_comercial_request_flag_origem_externa_value}}} (optional)</param>
        /// <param name="flagModificado">{{{origem_comercial_request_flag_modificado_value}}} (optional)</param>
        /// <param name="flagEnviaFaturaUsuario">{{{origem_comercial_request_flag_envia_fatura_usuario_value}}} (optional)</param>
        /// <param name="flagCreditoFaturamento">{{{origem_comercial_request_flag_credito_faturamento_value}}} (optional)</param>
        /// <param name="flagConcedeLimiteProvisorio">{{{origem_comercial_request_flag_concede_limite_provisorio_value}}} (optional)</param>
        /// <param name="flagDigitalizarDoc">{{{origem_comercial_request_flag_digitalizar_doc_value}}} (optional)</param>
        /// <param name="flagEmbossingLoja">{{{origem_comercial_request_flag_embossing_loja_value}}} (optional)</param>
        /// <param name="flagConsultaPrevia">{{{origem_comercial_request_flag_consulta_previa_value}}} (optional)</param>
        /// <param name="tipoPessoa">{{{origem_comercial_request_tipo_pessoa_value}}} (optional)</param>
        /// <returns>Task of PageOrigemComercialResponse</returns>
        public async System.Threading.Tasks.Task<PageOrigemComercialResponse> ListarOrigensComerciaisUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null, long? idEstabelecimento = null, long? idProduto = null, string descricao = null, long? idTipoOrigemComercial = null, long? idGrupoOrigemComercial = null, bool? flagPreAprovado = null, bool? flagAprovacaoImediata = null, string nomeFantasiaPlastico = null, bool? flagCartaoProvisorio = null, bool? flagCartaoDefinitivo = null, string usuario = null, string senha = null, bool? flagOrigemExterna = null, bool? flagModificado = null, bool? flagEnviaFaturaUsuario = null, bool? flagCreditoFaturamento = null, bool? flagConcedeLimiteProvisorio = null, bool? flagDigitalizarDoc = null, bool? flagEmbossingLoja = null, bool? flagConsultaPrevia = null, string tipoPessoa = null)
        {
             ApiResponse<PageOrigemComercialResponse> localVarResponse = await ListarOrigensComerciaisUsingGETAsyncWithHttpInfo(sort, page, limit, id, nome, status, idEstabelecimento, idProduto, descricao, idTipoOrigemComercial, idGrupoOrigemComercial, flagPreAprovado, flagAprovacaoImediata, nomeFantasiaPlastico, flagCartaoProvisorio, flagCartaoDefinitivo, usuario, senha, flagOrigemExterna, flagModificado, flagEnviaFaturaUsuario, flagCreditoFaturamento, flagConcedeLimiteProvisorio, flagDigitalizarDoc, flagEmbossingLoja, flagConsultaPrevia, tipoPessoa);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{origem_comercial_resource_listar_origens_comerciais}}} {{{origem_comercial_resource_listar_origens_comerciais_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{origem_comercial_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{origem_comercial_request_nome_value}}} (optional)</param>
        /// <param name="status">{{{origem_comercial_request_status_value}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{origem_comercial_request_id_estabelecimento_value}}} (optional)</param>
        /// <param name="idProduto">{{{origem_comercial_request_id_produto_value}}} (optional)</param>
        /// <param name="descricao">{{{origem_comercial_request_descricao_value}}} (optional)</param>
        /// <param name="idTipoOrigemComercial">{{{origem_comercial_request_id_tipo_origem_comercial_value}}} (optional)</param>
        /// <param name="idGrupoOrigemComercial">{{{origem_comercial_request_id_grupo_origem_comercial_value}}} (optional)</param>
        /// <param name="flagPreAprovado">{{{origem_comercial_request_flag_pre_aprovado_value}}} (optional)</param>
        /// <param name="flagAprovacaoImediata">{{{origem_comercial_request_flag_aprovacao_imediata_value}}} (optional)</param>
        /// <param name="nomeFantasiaPlastico">{{{origem_comercial_request_nome_fantasia_plastico_value}}} (optional)</param>
        /// <param name="flagCartaoProvisorio">{{{origem_comercial_request_flag_cartao_provisorio_value}}} (optional)</param>
        /// <param name="flagCartaoDefinitivo">{{{origem_comercial_request_flag_cartao_definitivo_value}}} (optional)</param>
        /// <param name="usuario">{{{origem_comercial_request_usuario_value}}} (optional)</param>
        /// <param name="senha">{{{origem_comercial_request_senha_value}}} (optional)</param>
        /// <param name="flagOrigemExterna">{{{origem_comercial_request_flag_origem_externa_value}}} (optional)</param>
        /// <param name="flagModificado">{{{origem_comercial_request_flag_modificado_value}}} (optional)</param>
        /// <param name="flagEnviaFaturaUsuario">{{{origem_comercial_request_flag_envia_fatura_usuario_value}}} (optional)</param>
        /// <param name="flagCreditoFaturamento">{{{origem_comercial_request_flag_credito_faturamento_value}}} (optional)</param>
        /// <param name="flagConcedeLimiteProvisorio">{{{origem_comercial_request_flag_concede_limite_provisorio_value}}} (optional)</param>
        /// <param name="flagDigitalizarDoc">{{{origem_comercial_request_flag_digitalizar_doc_value}}} (optional)</param>
        /// <param name="flagEmbossingLoja">{{{origem_comercial_request_flag_embossing_loja_value}}} (optional)</param>
        /// <param name="flagConsultaPrevia">{{{origem_comercial_request_flag_consulta_previa_value}}} (optional)</param>
        /// <param name="tipoPessoa">{{{origem_comercial_request_tipo_pessoa_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageOrigemComercialResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageOrigemComercialResponse>> ListarOrigensComerciaisUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null, long? idEstabelecimento = null, long? idProduto = null, string descricao = null, long? idTipoOrigemComercial = null, long? idGrupoOrigemComercial = null, bool? flagPreAprovado = null, bool? flagAprovacaoImediata = null, string nomeFantasiaPlastico = null, bool? flagCartaoProvisorio = null, bool? flagCartaoDefinitivo = null, string usuario = null, string senha = null, bool? flagOrigemExterna = null, bool? flagModificado = null, bool? flagEnviaFaturaUsuario = null, bool? flagCreditoFaturamento = null, bool? flagConcedeLimiteProvisorio = null, bool? flagDigitalizarDoc = null, bool? flagEmbossingLoja = null, bool? flagConsultaPrevia = null, string tipoPessoa = null)
        {
            
    
            var localVarPath = "/api/origens-comerciais";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (idTipoOrigemComercial != null) localVarQueryParams.Add("idTipoOrigemComercial", Configuration.ApiClient.ParameterToString(idTipoOrigemComercial)); // query parameter
            if (idGrupoOrigemComercial != null) localVarQueryParams.Add("idGrupoOrigemComercial", Configuration.ApiClient.ParameterToString(idGrupoOrigemComercial)); // query parameter
            if (flagPreAprovado != null) localVarQueryParams.Add("flagPreAprovado", Configuration.ApiClient.ParameterToString(flagPreAprovado)); // query parameter
            if (flagAprovacaoImediata != null) localVarQueryParams.Add("flagAprovacaoImediata", Configuration.ApiClient.ParameterToString(flagAprovacaoImediata)); // query parameter
            if (nomeFantasiaPlastico != null) localVarQueryParams.Add("nomeFantasiaPlastico", Configuration.ApiClient.ParameterToString(nomeFantasiaPlastico)); // query parameter
            if (flagCartaoProvisorio != null) localVarQueryParams.Add("flagCartaoProvisorio", Configuration.ApiClient.ParameterToString(flagCartaoProvisorio)); // query parameter
            if (flagCartaoDefinitivo != null) localVarQueryParams.Add("flagCartaoDefinitivo", Configuration.ApiClient.ParameterToString(flagCartaoDefinitivo)); // query parameter
            if (usuario != null) localVarQueryParams.Add("usuario", Configuration.ApiClient.ParameterToString(usuario)); // query parameter
            if (senha != null) localVarQueryParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // query parameter
            if (flagOrigemExterna != null) localVarQueryParams.Add("flagOrigemExterna", Configuration.ApiClient.ParameterToString(flagOrigemExterna)); // query parameter
            if (flagModificado != null) localVarQueryParams.Add("flagModificado", Configuration.ApiClient.ParameterToString(flagModificado)); // query parameter
            if (flagEnviaFaturaUsuario != null) localVarQueryParams.Add("flagEnviaFaturaUsuario", Configuration.ApiClient.ParameterToString(flagEnviaFaturaUsuario)); // query parameter
            if (flagCreditoFaturamento != null) localVarQueryParams.Add("flagCreditoFaturamento", Configuration.ApiClient.ParameterToString(flagCreditoFaturamento)); // query parameter
            if (flagConcedeLimiteProvisorio != null) localVarQueryParams.Add("flagConcedeLimiteProvisorio", Configuration.ApiClient.ParameterToString(flagConcedeLimiteProvisorio)); // query parameter
            if (flagDigitalizarDoc != null) localVarQueryParams.Add("flagDigitalizarDoc", Configuration.ApiClient.ParameterToString(flagDigitalizarDoc)); // query parameter
            if (flagEmbossingLoja != null) localVarQueryParams.Add("flagEmbossingLoja", Configuration.ApiClient.ParameterToString(flagEmbossingLoja)); // query parameter
            if (flagConsultaPrevia != null) localVarQueryParams.Add("flagConsultaPrevia", Configuration.ApiClient.ParameterToString(flagConsultaPrevia)); // query parameter
            if (tipoPessoa != null) localVarQueryParams.Add("tipoPessoa", Configuration.ApiClient.ParameterToString(tipoPessoa)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarOrigensComerciaisUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarOrigensComerciaisUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageOrigemComercialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOrigemComercialResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOrigemComercialResponse)));
            
        }
        
        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_listar_tipos_adquirentes}}} {{{vinculo_estabelecimento_adquirente_resource_listar_tipos_adquirentes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>PageEntidadeResponse</returns>
        public PageEntidadeResponse ListarTiposAdquirentesUsingGET (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageEntidadeResponse> localVarResponse = ListarTiposAdquirentesUsingGETWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_listar_tipos_adquirentes}}} {{{vinculo_estabelecimento_adquirente_resource_listar_tipos_adquirentes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>ApiResponse of PageEntidadeResponse</returns>
        public ApiResponse< PageEntidadeResponse > ListarTiposAdquirentesUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/tipos-adquirentes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposAdquirentesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposAdquirentesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageEntidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEntidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEntidadeResponse)));
            
        }

        
        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_listar_tipos_adquirentes}}} {{{vinculo_estabelecimento_adquirente_resource_listar_tipos_adquirentes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageEntidadeResponse</returns>
        public async System.Threading.Tasks.Task<PageEntidadeResponse> ListarTiposAdquirentesUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageEntidadeResponse> localVarResponse = await ListarTiposAdquirentesUsingGETAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_listar_tipos_adquirentes}}} {{{vinculo_estabelecimento_adquirente_resource_listar_tipos_adquirentes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageEntidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageEntidadeResponse>> ListarTiposAdquirentesUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/tipos-adquirentes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposAdquirentesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposAdquirentesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageEntidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEntidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEntidadeResponse)));
            
        }
        
        /// <summary>
        /// {{{tipo_estabelecimento_resource_listar_tipos_estabelecimentos}}} {{{tipo_estabelecimento_resource_listar_tipos_estabelecimentos_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="descricao">{{{tipo_estabelecimento_request_descricao_value}}} (optional)</param> 
        /// <returns>PageTipoEstabelecimentoResponse</returns>
        public PageTipoEstabelecimentoResponse ListarTiposEstabelecimentosUsingGET (List<string> sort = null, int? page = null, int? limit = null, string descricao = null)
        {
             ApiResponse<PageTipoEstabelecimentoResponse> localVarResponse = ListarTiposEstabelecimentosUsingGETWithHttpInfo(sort, page, limit, descricao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{tipo_estabelecimento_resource_listar_tipos_estabelecimentos}}} {{{tipo_estabelecimento_resource_listar_tipos_estabelecimentos_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="descricao">{{{tipo_estabelecimento_request_descricao_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageTipoEstabelecimentoResponse</returns>
        public ApiResponse< PageTipoEstabelecimentoResponse > ListarTiposEstabelecimentosUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/tipos-estabelecimentos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposEstabelecimentosUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposEstabelecimentosUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoEstabelecimentoResponse)));
            
        }

        
        /// <summary>
        /// {{{tipo_estabelecimento_resource_listar_tipos_estabelecimentos}}} {{{tipo_estabelecimento_resource_listar_tipos_estabelecimentos_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="descricao">{{{tipo_estabelecimento_request_descricao_value}}} (optional)</param>
        /// <returns>Task of PageTipoEstabelecimentoResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoEstabelecimentoResponse> ListarTiposEstabelecimentosUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, string descricao = null)
        {
             ApiResponse<PageTipoEstabelecimentoResponse> localVarResponse = await ListarTiposEstabelecimentosUsingGETAsyncWithHttpInfo(sort, page, limit, descricao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{tipo_estabelecimento_resource_listar_tipos_estabelecimentos}}} {{{tipo_estabelecimento_resource_listar_tipos_estabelecimentos_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="descricao">{{{tipo_estabelecimento_request_descricao_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoEstabelecimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoEstabelecimentoResponse>> ListarTiposEstabelecimentosUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/tipos-estabelecimentos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposEstabelecimentosUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposEstabelecimentosUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoEstabelecimentoResponse)));
            
        }
        
        /// <summary>
        /// {{{maquineta_resource_listar_tipos_maquinetas}}} {{{maquineta_resource_listar_tipos_maquinetas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        public PageCampoCodificadoDescricaoResponse ListarTiposMaquinetasUsingGET (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = ListarTiposMaquinetasUsingGETWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{maquineta_resource_listar_tipos_maquinetas}}} {{{maquineta_resource_listar_tipos_maquinetas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        public ApiResponse< PageCampoCodificadoDescricaoResponse > ListarTiposMaquinetasUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/tipos-maquinetas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposMaquinetasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposMaquinetasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCampoCodificadoDescricaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCampoCodificadoDescricaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCampoCodificadoDescricaoResponse)));
            
        }

        
        /// <summary>
        /// {{{maquineta_resource_listar_tipos_maquinetas}}} {{{maquineta_resource_listar_tipos_maquinetas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        public async System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarTiposMaquinetasUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = await ListarTiposMaquinetasUsingGETAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{maquineta_resource_listar_tipos_maquinetas}}} {{{maquineta_resource_listar_tipos_maquinetas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarTiposMaquinetasUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/tipos-maquinetas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposMaquinetasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposMaquinetasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCampoCodificadoDescricaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCampoCodificadoDescricaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCampoCodificadoDescricaoResponse)));
            
        }
        
        /// <summary>
        /// {{{tipo_origem_comercial_resource_listar_tipos_origens_comerciais}}} {{{tipo_origem_comercial_resource_listar_tipos_origens_comerciais_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="nome">{{{tipo_origem_comercial_request_nome_value}}} (optional)</param> 
        /// <returns>PageTipoOrigemComercialResponse</returns>
        public PageTipoOrigemComercialResponse ListarTiposOrigensComerciaisUsingGET (List<string> sort = null, int? page = null, int? limit = null, string nome = null)
        {
             ApiResponse<PageTipoOrigemComercialResponse> localVarResponse = ListarTiposOrigensComerciaisUsingGETWithHttpInfo(sort, page, limit, nome);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{tipo_origem_comercial_resource_listar_tipos_origens_comerciais}}} {{{tipo_origem_comercial_resource_listar_tipos_origens_comerciais_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="nome">{{{tipo_origem_comercial_request_nome_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageTipoOrigemComercialResponse</returns>
        public ApiResponse< PageTipoOrigemComercialResponse > ListarTiposOrigensComerciaisUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null)
        {
            
    
            var localVarPath = "/api/tipos-origens-comerciais";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposOrigensComerciaisUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposOrigensComerciaisUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoOrigemComercialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoOrigemComercialResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoOrigemComercialResponse)));
            
        }

        
        /// <summary>
        /// {{{tipo_origem_comercial_resource_listar_tipos_origens_comerciais}}} {{{tipo_origem_comercial_resource_listar_tipos_origens_comerciais_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{tipo_origem_comercial_request_nome_value}}} (optional)</param>
        /// <returns>Task of PageTipoOrigemComercialResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoOrigemComercialResponse> ListarTiposOrigensComerciaisUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, string nome = null)
        {
             ApiResponse<PageTipoOrigemComercialResponse> localVarResponse = await ListarTiposOrigensComerciaisUsingGETAsyncWithHttpInfo(sort, page, limit, nome);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{tipo_origem_comercial_resource_listar_tipos_origens_comerciais}}} {{{tipo_origem_comercial_resource_listar_tipos_origens_comerciais_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{tipo_origem_comercial_request_nome_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoOrigemComercialResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoOrigemComercialResponse>> ListarTiposOrigensComerciaisUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null)
        {
            
    
            var localVarPath = "/api/tipos-origens-comerciais";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposOrigensComerciaisUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposOrigensComerciaisUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoOrigemComercialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoOrigemComercialResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoOrigemComercialResponse)));
            
        }
        
        /// <summary>
        /// {{{terminal_resource_listar_tipos_terminais}}} {{{terminal_resource_listar_tipos_terminais_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>PageTipoTerminalResponse</returns>
        public PageTipoTerminalResponse ListarTiposTerminaisUsingGET (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTipoTerminalResponse> localVarResponse = ListarTiposTerminaisUsingGETWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{terminal_resource_listar_tipos_terminais}}} {{{terminal_resource_listar_tipos_terminais_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>ApiResponse of PageTipoTerminalResponse</returns>
        public ApiResponse< PageTipoTerminalResponse > ListarTiposTerminaisUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/tipos-terminais-estabelecimento";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposTerminaisUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposTerminaisUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoTerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoTerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoTerminalResponse)));
            
        }

        
        /// <summary>
        /// {{{terminal_resource_listar_tipos_terminais}}} {{{terminal_resource_listar_tipos_terminais_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageTipoTerminalResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoTerminalResponse> ListarTiposTerminaisUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTipoTerminalResponse> localVarResponse = await ListarTiposTerminaisUsingGETAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{terminal_resource_listar_tipos_terminais}}} {{{terminal_resource_listar_tipos_terminais_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoTerminalResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoTerminalResponse>> ListarTiposTerminaisUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/tipos-terminais-estabelecimento";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposTerminaisUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposTerminaisUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoTerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoTerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoTerminalResponse)));
            
        }
        
        /// <summary>
        /// {{{estabelecimento_resource_listar}}} {{{estabelecimento_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{estabelecimento_request_id_value}}} (optional)</param> 
        /// <param name="idGrupoEconomico">{{{estabelecimento_request_id_grupo_economico_value}}} (optional)</param> 
        /// <param name="numeroReceitaFederal">{{{estabelecimento_request_numero_receita_federal_value}}} (optional)</param> 
        /// <param name="nome">{{{estabelecimento_request_nome_value}}} (optional)</param> 
        /// <param name="descricao">{{{estabelecimento_request_descricao_value}}} (optional)</param> 
        /// <param name="nomeFantasia">{{{estabelecimento_request_nome_fantasia_value}}} (optional)</param> 
        /// <param name="cep">{{{estabelecimento_request_cep_value}}} (optional)</param> 
        /// <param name="nomeLogradouro">{{{estabelecimento_request_nome_logradouro_value}}} (optional)</param> 
        /// <param name="numeroEndereco">{{{estabelecimento_request_numero_endereco_value}}} (optional)</param> 
        /// <param name="complemento">{{{estabelecimento_request_complemento_value}}} (optional)</param> 
        /// <param name="bairro">{{{estabelecimento_request_bairro_value}}} (optional)</param> 
        /// <param name="cidade">{{{estabelecimento_request_cidade_value}}} (optional)</param> 
        /// <param name="uf">{{{estabelecimento_request_uf_value}}} (optional)</param> 
        /// <param name="pais">{{{estabelecimento_request_pais_value}}} (optional)</param> 
        /// <param name="dataCadastramento">{{{estabelecimento_request_data_cadastramento_value}}} (optional)</param> 
        /// <param name="contato">{{{estabelecimento_request_contato_value}}} (optional)</param> 
        /// <param name="email">{{{estabelecimento_request_email_value}}} (optional)</param> 
        /// <param name="flagArquivoSecrFazenda">{{{estabelecimento_request_flag_arquivo_secr_fazenda_value}}} (optional)</param> 
        /// <param name="flagCartaoDigitado">{{{estabelecimento_request_flag_cartao_digitado_value}}} (optional)</param> 
        /// <param name="inativo">{{{estabelecimento_request_inativo_value}}} (optional)</param> 
        /// <param name="idPais">{{{estabelecimento_request_id_pais_value}}} (optional)</param> 
        /// <param name="mcc">{{{estabelecimento_request_mcc_value}}} (optional)</param> 
        /// <param name="idTipoEstabelecimento">{{{estabelecimento_request_id_tipo_estabelecimento_value}}} (optional)</param> 
        /// <param name="correspondencia">{{{estabelecimento_request_correspondencia_value}}} (optional)</param> 
        /// <param name="idMoeda">{{{estabelecimento_request_id_moeda_value}}} (optional)</param> 
        /// <param name="tipoPagamento">{{{estabelecimento_request_tipo_pagamento_value}}} (optional)</param> 
        /// <param name="numeroEstabelecimento">{{{estabelecimento_request_numero_estabelecimento_value}}} (optional)</param> 
        /// <param name="cep2">{{{estabelecimento_request_cep2_value}}} (optional)</param> 
        /// <param name="nomeLogradouro2">{{{estabelecimento_request_nome_logradouro2_value}}} (optional)</param> 
        /// <param name="numeroEndereco2">{{{estabelecimento_request_numero_endereco2_value}}} (optional)</param> 
        /// <param name="complemento2">{{{estabelecimento_request_complemento2_value}}} (optional)</param> 
        /// <param name="bairro2">{{{estabelecimento_request_bairro2_value}}} (optional)</param> 
        /// <param name="cidade2">{{{estabelecimento_request_cidade2_value}}} (optional)</param> 
        /// <param name="uf2">{{{estabelecimento_request_uf2_value}}} (optional)</param> 
        /// <param name="flagMatriz">{{{estabelecimento_request_flag_matriz_value}}} (optional)</param> 
        /// <returns>PageEstabelecimentoResponse</returns>
        public PageEstabelecimentoResponse ListarUsingGET22 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idGrupoEconomico = null, string numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, int? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null, long? idPais = null, long? mcc = null, long? idTipoEstabelecimento = null, int? correspondencia = null, long? idMoeda = null, string tipoPagamento = null, string numeroEstabelecimento = null, string cep2 = null, string nomeLogradouro2 = null, int? numeroEndereco2 = null, string complemento2 = null, string bairro2 = null, string cidade2 = null, string uf2 = null, int? flagMatriz = null)
        {
             ApiResponse<PageEstabelecimentoResponse> localVarResponse = ListarUsingGET22WithHttpInfo(sort, page, limit, id, idGrupoEconomico, numeroReceitaFederal, nome, descricao, nomeFantasia, cep, nomeLogradouro, numeroEndereco, complemento, bairro, cidade, uf, pais, dataCadastramento, contato, email, flagArquivoSecrFazenda, flagCartaoDigitado, inativo, idPais, mcc, idTipoEstabelecimento, correspondencia, idMoeda, tipoPagamento, numeroEstabelecimento, cep2, nomeLogradouro2, numeroEndereco2, complemento2, bairro2, cidade2, uf2, flagMatriz);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{estabelecimento_resource_listar}}} {{{estabelecimento_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{estabelecimento_request_id_value}}} (optional)</param> 
        /// <param name="idGrupoEconomico">{{{estabelecimento_request_id_grupo_economico_value}}} (optional)</param> 
        /// <param name="numeroReceitaFederal">{{{estabelecimento_request_numero_receita_federal_value}}} (optional)</param> 
        /// <param name="nome">{{{estabelecimento_request_nome_value}}} (optional)</param> 
        /// <param name="descricao">{{{estabelecimento_request_descricao_value}}} (optional)</param> 
        /// <param name="nomeFantasia">{{{estabelecimento_request_nome_fantasia_value}}} (optional)</param> 
        /// <param name="cep">{{{estabelecimento_request_cep_value}}} (optional)</param> 
        /// <param name="nomeLogradouro">{{{estabelecimento_request_nome_logradouro_value}}} (optional)</param> 
        /// <param name="numeroEndereco">{{{estabelecimento_request_numero_endereco_value}}} (optional)</param> 
        /// <param name="complemento">{{{estabelecimento_request_complemento_value}}} (optional)</param> 
        /// <param name="bairro">{{{estabelecimento_request_bairro_value}}} (optional)</param> 
        /// <param name="cidade">{{{estabelecimento_request_cidade_value}}} (optional)</param> 
        /// <param name="uf">{{{estabelecimento_request_uf_value}}} (optional)</param> 
        /// <param name="pais">{{{estabelecimento_request_pais_value}}} (optional)</param> 
        /// <param name="dataCadastramento">{{{estabelecimento_request_data_cadastramento_value}}} (optional)</param> 
        /// <param name="contato">{{{estabelecimento_request_contato_value}}} (optional)</param> 
        /// <param name="email">{{{estabelecimento_request_email_value}}} (optional)</param> 
        /// <param name="flagArquivoSecrFazenda">{{{estabelecimento_request_flag_arquivo_secr_fazenda_value}}} (optional)</param> 
        /// <param name="flagCartaoDigitado">{{{estabelecimento_request_flag_cartao_digitado_value}}} (optional)</param> 
        /// <param name="inativo">{{{estabelecimento_request_inativo_value}}} (optional)</param> 
        /// <param name="idPais">{{{estabelecimento_request_id_pais_value}}} (optional)</param> 
        /// <param name="mcc">{{{estabelecimento_request_mcc_value}}} (optional)</param> 
        /// <param name="idTipoEstabelecimento">{{{estabelecimento_request_id_tipo_estabelecimento_value}}} (optional)</param> 
        /// <param name="correspondencia">{{{estabelecimento_request_correspondencia_value}}} (optional)</param> 
        /// <param name="idMoeda">{{{estabelecimento_request_id_moeda_value}}} (optional)</param> 
        /// <param name="tipoPagamento">{{{estabelecimento_request_tipo_pagamento_value}}} (optional)</param> 
        /// <param name="numeroEstabelecimento">{{{estabelecimento_request_numero_estabelecimento_value}}} (optional)</param> 
        /// <param name="cep2">{{{estabelecimento_request_cep2_value}}} (optional)</param> 
        /// <param name="nomeLogradouro2">{{{estabelecimento_request_nome_logradouro2_value}}} (optional)</param> 
        /// <param name="numeroEndereco2">{{{estabelecimento_request_numero_endereco2_value}}} (optional)</param> 
        /// <param name="complemento2">{{{estabelecimento_request_complemento2_value}}} (optional)</param> 
        /// <param name="bairro2">{{{estabelecimento_request_bairro2_value}}} (optional)</param> 
        /// <param name="cidade2">{{{estabelecimento_request_cidade2_value}}} (optional)</param> 
        /// <param name="uf2">{{{estabelecimento_request_uf2_value}}} (optional)</param> 
        /// <param name="flagMatriz">{{{estabelecimento_request_flag_matriz_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageEstabelecimentoResponse</returns>
        public ApiResponse< PageEstabelecimentoResponse > ListarUsingGET22WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idGrupoEconomico = null, string numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, int? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null, long? idPais = null, long? mcc = null, long? idTipoEstabelecimento = null, int? correspondencia = null, long? idMoeda = null, string tipoPagamento = null, string numeroEstabelecimento = null, string cep2 = null, string nomeLogradouro2 = null, int? numeroEndereco2 = null, string complemento2 = null, string bairro2 = null, string cidade2 = null, string uf2 = null, int? flagMatriz = null)
        {
            
    
            var localVarPath = "/api/estabelecimentos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idGrupoEconomico != null) localVarQueryParams.Add("idGrupoEconomico", Configuration.ApiClient.ParameterToString(idGrupoEconomico)); // query parameter
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (nomeFantasia != null) localVarQueryParams.Add("nomeFantasia", Configuration.ApiClient.ParameterToString(nomeFantasia)); // query parameter
            if (cep != null) localVarQueryParams.Add("cep", Configuration.ApiClient.ParameterToString(cep)); // query parameter
            if (nomeLogradouro != null) localVarQueryParams.Add("nomeLogradouro", Configuration.ApiClient.ParameterToString(nomeLogradouro)); // query parameter
            if (numeroEndereco != null) localVarQueryParams.Add("numeroEndereco", Configuration.ApiClient.ParameterToString(numeroEndereco)); // query parameter
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            if (bairro != null) localVarQueryParams.Add("bairro", Configuration.ApiClient.ParameterToString(bairro)); // query parameter
            if (cidade != null) localVarQueryParams.Add("cidade", Configuration.ApiClient.ParameterToString(cidade)); // query parameter
            if (uf != null) localVarQueryParams.Add("uf", Configuration.ApiClient.ParameterToString(uf)); // query parameter
            if (pais != null) localVarQueryParams.Add("pais", Configuration.ApiClient.ParameterToString(pais)); // query parameter
            if (dataCadastramento != null) localVarQueryParams.Add("dataCadastramento", Configuration.ApiClient.ParameterToString(dataCadastramento)); // query parameter
            if (contato != null) localVarQueryParams.Add("contato", Configuration.ApiClient.ParameterToString(contato)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (flagArquivoSecrFazenda != null) localVarQueryParams.Add("flagArquivoSecrFazenda", Configuration.ApiClient.ParameterToString(flagArquivoSecrFazenda)); // query parameter
            if (flagCartaoDigitado != null) localVarQueryParams.Add("flagCartaoDigitado", Configuration.ApiClient.ParameterToString(flagCartaoDigitado)); // query parameter
            if (inativo != null) localVarQueryParams.Add("inativo", Configuration.ApiClient.ParameterToString(inativo)); // query parameter
            if (idPais != null) localVarQueryParams.Add("idPais", Configuration.ApiClient.ParameterToString(idPais)); // query parameter
            if (mcc != null) localVarQueryParams.Add("mcc", Configuration.ApiClient.ParameterToString(mcc)); // query parameter
            if (idTipoEstabelecimento != null) localVarQueryParams.Add("idTipoEstabelecimento", Configuration.ApiClient.ParameterToString(idTipoEstabelecimento)); // query parameter
            if (correspondencia != null) localVarQueryParams.Add("correspondencia", Configuration.ApiClient.ParameterToString(correspondencia)); // query parameter
            if (idMoeda != null) localVarQueryParams.Add("idMoeda", Configuration.ApiClient.ParameterToString(idMoeda)); // query parameter
            if (tipoPagamento != null) localVarQueryParams.Add("tipoPagamento", Configuration.ApiClient.ParameterToString(tipoPagamento)); // query parameter
            if (numeroEstabelecimento != null) localVarQueryParams.Add("numeroEstabelecimento", Configuration.ApiClient.ParameterToString(numeroEstabelecimento)); // query parameter
            if (cep2 != null) localVarQueryParams.Add("cep2", Configuration.ApiClient.ParameterToString(cep2)); // query parameter
            if (nomeLogradouro2 != null) localVarQueryParams.Add("nomeLogradouro2", Configuration.ApiClient.ParameterToString(nomeLogradouro2)); // query parameter
            if (numeroEndereco2 != null) localVarQueryParams.Add("numeroEndereco2", Configuration.ApiClient.ParameterToString(numeroEndereco2)); // query parameter
            if (complemento2 != null) localVarQueryParams.Add("complemento2", Configuration.ApiClient.ParameterToString(complemento2)); // query parameter
            if (bairro2 != null) localVarQueryParams.Add("bairro2", Configuration.ApiClient.ParameterToString(bairro2)); // query parameter
            if (cidade2 != null) localVarQueryParams.Add("cidade2", Configuration.ApiClient.ParameterToString(cidade2)); // query parameter
            if (uf2 != null) localVarQueryParams.Add("uf2", Configuration.ApiClient.ParameterToString(uf2)); // query parameter
            if (flagMatriz != null) localVarQueryParams.Add("flagMatriz", Configuration.ApiClient.ParameterToString(flagMatriz)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET22: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET22: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEstabelecimentoResponse)));
            
        }

        
        /// <summary>
        /// {{{estabelecimento_resource_listar}}} {{{estabelecimento_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{estabelecimento_request_id_value}}} (optional)</param>
        /// <param name="idGrupoEconomico">{{{estabelecimento_request_id_grupo_economico_value}}} (optional)</param>
        /// <param name="numeroReceitaFederal">{{{estabelecimento_request_numero_receita_federal_value}}} (optional)</param>
        /// <param name="nome">{{{estabelecimento_request_nome_value}}} (optional)</param>
        /// <param name="descricao">{{{estabelecimento_request_descricao_value}}} (optional)</param>
        /// <param name="nomeFantasia">{{{estabelecimento_request_nome_fantasia_value}}} (optional)</param>
        /// <param name="cep">{{{estabelecimento_request_cep_value}}} (optional)</param>
        /// <param name="nomeLogradouro">{{{estabelecimento_request_nome_logradouro_value}}} (optional)</param>
        /// <param name="numeroEndereco">{{{estabelecimento_request_numero_endereco_value}}} (optional)</param>
        /// <param name="complemento">{{{estabelecimento_request_complemento_value}}} (optional)</param>
        /// <param name="bairro">{{{estabelecimento_request_bairro_value}}} (optional)</param>
        /// <param name="cidade">{{{estabelecimento_request_cidade_value}}} (optional)</param>
        /// <param name="uf">{{{estabelecimento_request_uf_value}}} (optional)</param>
        /// <param name="pais">{{{estabelecimento_request_pais_value}}} (optional)</param>
        /// <param name="dataCadastramento">{{{estabelecimento_request_data_cadastramento_value}}} (optional)</param>
        /// <param name="contato">{{{estabelecimento_request_contato_value}}} (optional)</param>
        /// <param name="email">{{{estabelecimento_request_email_value}}} (optional)</param>
        /// <param name="flagArquivoSecrFazenda">{{{estabelecimento_request_flag_arquivo_secr_fazenda_value}}} (optional)</param>
        /// <param name="flagCartaoDigitado">{{{estabelecimento_request_flag_cartao_digitado_value}}} (optional)</param>
        /// <param name="inativo">{{{estabelecimento_request_inativo_value}}} (optional)</param>
        /// <param name="idPais">{{{estabelecimento_request_id_pais_value}}} (optional)</param>
        /// <param name="mcc">{{{estabelecimento_request_mcc_value}}} (optional)</param>
        /// <param name="idTipoEstabelecimento">{{{estabelecimento_request_id_tipo_estabelecimento_value}}} (optional)</param>
        /// <param name="correspondencia">{{{estabelecimento_request_correspondencia_value}}} (optional)</param>
        /// <param name="idMoeda">{{{estabelecimento_request_id_moeda_value}}} (optional)</param>
        /// <param name="tipoPagamento">{{{estabelecimento_request_tipo_pagamento_value}}} (optional)</param>
        /// <param name="numeroEstabelecimento">{{{estabelecimento_request_numero_estabelecimento_value}}} (optional)</param>
        /// <param name="cep2">{{{estabelecimento_request_cep2_value}}} (optional)</param>
        /// <param name="nomeLogradouro2">{{{estabelecimento_request_nome_logradouro2_value}}} (optional)</param>
        /// <param name="numeroEndereco2">{{{estabelecimento_request_numero_endereco2_value}}} (optional)</param>
        /// <param name="complemento2">{{{estabelecimento_request_complemento2_value}}} (optional)</param>
        /// <param name="bairro2">{{{estabelecimento_request_bairro2_value}}} (optional)</param>
        /// <param name="cidade2">{{{estabelecimento_request_cidade2_value}}} (optional)</param>
        /// <param name="uf2">{{{estabelecimento_request_uf2_value}}} (optional)</param>
        /// <param name="flagMatriz">{{{estabelecimento_request_flag_matriz_value}}} (optional)</param>
        /// <returns>Task of PageEstabelecimentoResponse</returns>
        public async System.Threading.Tasks.Task<PageEstabelecimentoResponse> ListarUsingGET22Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idGrupoEconomico = null, string numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, int? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null, long? idPais = null, long? mcc = null, long? idTipoEstabelecimento = null, int? correspondencia = null, long? idMoeda = null, string tipoPagamento = null, string numeroEstabelecimento = null, string cep2 = null, string nomeLogradouro2 = null, int? numeroEndereco2 = null, string complemento2 = null, string bairro2 = null, string cidade2 = null, string uf2 = null, int? flagMatriz = null)
        {
             ApiResponse<PageEstabelecimentoResponse> localVarResponse = await ListarUsingGET22AsyncWithHttpInfo(sort, page, limit, id, idGrupoEconomico, numeroReceitaFederal, nome, descricao, nomeFantasia, cep, nomeLogradouro, numeroEndereco, complemento, bairro, cidade, uf, pais, dataCadastramento, contato, email, flagArquivoSecrFazenda, flagCartaoDigitado, inativo, idPais, mcc, idTipoEstabelecimento, correspondencia, idMoeda, tipoPagamento, numeroEstabelecimento, cep2, nomeLogradouro2, numeroEndereco2, complemento2, bairro2, cidade2, uf2, flagMatriz);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{estabelecimento_resource_listar}}} {{{estabelecimento_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{estabelecimento_request_id_value}}} (optional)</param>
        /// <param name="idGrupoEconomico">{{{estabelecimento_request_id_grupo_economico_value}}} (optional)</param>
        /// <param name="numeroReceitaFederal">{{{estabelecimento_request_numero_receita_federal_value}}} (optional)</param>
        /// <param name="nome">{{{estabelecimento_request_nome_value}}} (optional)</param>
        /// <param name="descricao">{{{estabelecimento_request_descricao_value}}} (optional)</param>
        /// <param name="nomeFantasia">{{{estabelecimento_request_nome_fantasia_value}}} (optional)</param>
        /// <param name="cep">{{{estabelecimento_request_cep_value}}} (optional)</param>
        /// <param name="nomeLogradouro">{{{estabelecimento_request_nome_logradouro_value}}} (optional)</param>
        /// <param name="numeroEndereco">{{{estabelecimento_request_numero_endereco_value}}} (optional)</param>
        /// <param name="complemento">{{{estabelecimento_request_complemento_value}}} (optional)</param>
        /// <param name="bairro">{{{estabelecimento_request_bairro_value}}} (optional)</param>
        /// <param name="cidade">{{{estabelecimento_request_cidade_value}}} (optional)</param>
        /// <param name="uf">{{{estabelecimento_request_uf_value}}} (optional)</param>
        /// <param name="pais">{{{estabelecimento_request_pais_value}}} (optional)</param>
        /// <param name="dataCadastramento">{{{estabelecimento_request_data_cadastramento_value}}} (optional)</param>
        /// <param name="contato">{{{estabelecimento_request_contato_value}}} (optional)</param>
        /// <param name="email">{{{estabelecimento_request_email_value}}} (optional)</param>
        /// <param name="flagArquivoSecrFazenda">{{{estabelecimento_request_flag_arquivo_secr_fazenda_value}}} (optional)</param>
        /// <param name="flagCartaoDigitado">{{{estabelecimento_request_flag_cartao_digitado_value}}} (optional)</param>
        /// <param name="inativo">{{{estabelecimento_request_inativo_value}}} (optional)</param>
        /// <param name="idPais">{{{estabelecimento_request_id_pais_value}}} (optional)</param>
        /// <param name="mcc">{{{estabelecimento_request_mcc_value}}} (optional)</param>
        /// <param name="idTipoEstabelecimento">{{{estabelecimento_request_id_tipo_estabelecimento_value}}} (optional)</param>
        /// <param name="correspondencia">{{{estabelecimento_request_correspondencia_value}}} (optional)</param>
        /// <param name="idMoeda">{{{estabelecimento_request_id_moeda_value}}} (optional)</param>
        /// <param name="tipoPagamento">{{{estabelecimento_request_tipo_pagamento_value}}} (optional)</param>
        /// <param name="numeroEstabelecimento">{{{estabelecimento_request_numero_estabelecimento_value}}} (optional)</param>
        /// <param name="cep2">{{{estabelecimento_request_cep2_value}}} (optional)</param>
        /// <param name="nomeLogradouro2">{{{estabelecimento_request_nome_logradouro2_value}}} (optional)</param>
        /// <param name="numeroEndereco2">{{{estabelecimento_request_numero_endereco2_value}}} (optional)</param>
        /// <param name="complemento2">{{{estabelecimento_request_complemento2_value}}} (optional)</param>
        /// <param name="bairro2">{{{estabelecimento_request_bairro2_value}}} (optional)</param>
        /// <param name="cidade2">{{{estabelecimento_request_cidade2_value}}} (optional)</param>
        /// <param name="uf2">{{{estabelecimento_request_uf2_value}}} (optional)</param>
        /// <param name="flagMatriz">{{{estabelecimento_request_flag_matriz_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageEstabelecimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageEstabelecimentoResponse>> ListarUsingGET22AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idGrupoEconomico = null, string numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, int? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null, long? idPais = null, long? mcc = null, long? idTipoEstabelecimento = null, int? correspondencia = null, long? idMoeda = null, string tipoPagamento = null, string numeroEstabelecimento = null, string cep2 = null, string nomeLogradouro2 = null, int? numeroEndereco2 = null, string complemento2 = null, string bairro2 = null, string cidade2 = null, string uf2 = null, int? flagMatriz = null)
        {
            
    
            var localVarPath = "/api/estabelecimentos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idGrupoEconomico != null) localVarQueryParams.Add("idGrupoEconomico", Configuration.ApiClient.ParameterToString(idGrupoEconomico)); // query parameter
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (nomeFantasia != null) localVarQueryParams.Add("nomeFantasia", Configuration.ApiClient.ParameterToString(nomeFantasia)); // query parameter
            if (cep != null) localVarQueryParams.Add("cep", Configuration.ApiClient.ParameterToString(cep)); // query parameter
            if (nomeLogradouro != null) localVarQueryParams.Add("nomeLogradouro", Configuration.ApiClient.ParameterToString(nomeLogradouro)); // query parameter
            if (numeroEndereco != null) localVarQueryParams.Add("numeroEndereco", Configuration.ApiClient.ParameterToString(numeroEndereco)); // query parameter
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            if (bairro != null) localVarQueryParams.Add("bairro", Configuration.ApiClient.ParameterToString(bairro)); // query parameter
            if (cidade != null) localVarQueryParams.Add("cidade", Configuration.ApiClient.ParameterToString(cidade)); // query parameter
            if (uf != null) localVarQueryParams.Add("uf", Configuration.ApiClient.ParameterToString(uf)); // query parameter
            if (pais != null) localVarQueryParams.Add("pais", Configuration.ApiClient.ParameterToString(pais)); // query parameter
            if (dataCadastramento != null) localVarQueryParams.Add("dataCadastramento", Configuration.ApiClient.ParameterToString(dataCadastramento)); // query parameter
            if (contato != null) localVarQueryParams.Add("contato", Configuration.ApiClient.ParameterToString(contato)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (flagArquivoSecrFazenda != null) localVarQueryParams.Add("flagArquivoSecrFazenda", Configuration.ApiClient.ParameterToString(flagArquivoSecrFazenda)); // query parameter
            if (flagCartaoDigitado != null) localVarQueryParams.Add("flagCartaoDigitado", Configuration.ApiClient.ParameterToString(flagCartaoDigitado)); // query parameter
            if (inativo != null) localVarQueryParams.Add("inativo", Configuration.ApiClient.ParameterToString(inativo)); // query parameter
            if (idPais != null) localVarQueryParams.Add("idPais", Configuration.ApiClient.ParameterToString(idPais)); // query parameter
            if (mcc != null) localVarQueryParams.Add("mcc", Configuration.ApiClient.ParameterToString(mcc)); // query parameter
            if (idTipoEstabelecimento != null) localVarQueryParams.Add("idTipoEstabelecimento", Configuration.ApiClient.ParameterToString(idTipoEstabelecimento)); // query parameter
            if (correspondencia != null) localVarQueryParams.Add("correspondencia", Configuration.ApiClient.ParameterToString(correspondencia)); // query parameter
            if (idMoeda != null) localVarQueryParams.Add("idMoeda", Configuration.ApiClient.ParameterToString(idMoeda)); // query parameter
            if (tipoPagamento != null) localVarQueryParams.Add("tipoPagamento", Configuration.ApiClient.ParameterToString(tipoPagamento)); // query parameter
            if (numeroEstabelecimento != null) localVarQueryParams.Add("numeroEstabelecimento", Configuration.ApiClient.ParameterToString(numeroEstabelecimento)); // query parameter
            if (cep2 != null) localVarQueryParams.Add("cep2", Configuration.ApiClient.ParameterToString(cep2)); // query parameter
            if (nomeLogradouro2 != null) localVarQueryParams.Add("nomeLogradouro2", Configuration.ApiClient.ParameterToString(nomeLogradouro2)); // query parameter
            if (numeroEndereco2 != null) localVarQueryParams.Add("numeroEndereco2", Configuration.ApiClient.ParameterToString(numeroEndereco2)); // query parameter
            if (complemento2 != null) localVarQueryParams.Add("complemento2", Configuration.ApiClient.ParameterToString(complemento2)); // query parameter
            if (bairro2 != null) localVarQueryParams.Add("bairro2", Configuration.ApiClient.ParameterToString(bairro2)); // query parameter
            if (cidade2 != null) localVarQueryParams.Add("cidade2", Configuration.ApiClient.ParameterToString(cidade2)); // query parameter
            if (uf2 != null) localVarQueryParams.Add("uf2", Configuration.ApiClient.ParameterToString(uf2)); // query parameter
            if (flagMatriz != null) localVarQueryParams.Add("flagMatriz", Configuration.ApiClient.ParameterToString(flagMatriz)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET22: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET22: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEstabelecimentoResponse)));
            
        }
        
        /// <summary>
        /// {{{grupo_economico_resource_listar}}} {{{grupo_economico_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="razaoSocial">{{{grupo_economico_request_razao_social_value}}} (optional)</param> 
        /// <param name="nomeCredor">{{{grupo_economico_request_nome_credor_value}}} (optional)</param> 
        /// <param name="numeroReceitaFederal">{{{grupo_economico_request_numero_receita_federal_value}}} (optional)</param> 
        /// <param name="inscricaoEstadual">{{{grupo_economico_request_inscricao_estadual_value}}} (optional)</param> 
        /// <param name="contato">{{{grupo_economico_request_contato_value}}} (optional)</param> 
        /// <param name="banco">{{{grupo_economico_request_banco_value}}} (optional)</param> 
        /// <param name="agencia">{{{grupo_economico_request_agencia_value}}} (optional)</param> 
        /// <param name="digitoAgencia">{{{grupo_economico_request_digito_agencia_value}}} (optional)</param> 
        /// <param name="contaCorrente">{{{grupo_economico_request_conta_corrente_value}}} (optional)</param> 
        /// <param name="digitoContaCorrente">{{{grupo_economico_request_digito_conta_corrente_value}}} (optional)</param> 
        /// <param name="periodicidade">{{{grupo_economico_request_periodicidade_value}}} (optional)</param> 
        /// <param name="pagamentoSemanal">{{{grupo_economico_request_pagamento_semanal_value}}} (optional)</param> 
        /// <param name="pagamentoMensal">{{{grupo_economico_request_pagamento_mensal_value}}} (optional)</param> 
        /// <param name="pagamentoDecendialPrimeiro">{{{grupo_economico_request_pagamento_decendial_primeiro_value}}} (optional)</param> 
        /// <param name="pagamentoDecendialSegundo">{{{grupo_economico_request_pagamento_decendial_segundo_value}}} (optional)</param> 
        /// <param name="pagamentoDecendialTerceiro">{{{grupo_economico_request_pagamento_decendial_terceiro_value}}} (optional)</param> 
        /// <param name="pagamentoQuinzenalPrimeiro">{{{grupo_economico_request_pagamento_quinzenal_primeiro_value}}} (optional)</param> 
        /// <param name="pagamentoQuinzenalSegundo">{{{grupo_economico_request_pagamento_quinzenal_segundo_value}}} (optional)</param> 
        /// <param name="percentualRAV">{{{grupo_economico_request_percentual_r_a_v_value}}} (optional)</param> 
        /// <param name="recebeRAV">{{{grupo_economico_request_recebe_r_a_v_value}}} (optional)</param> 
        /// <param name="percentualMultiplica">{{{grupo_economico_request_percentual_multiplica_value}}} (optional)</param> 
        /// <param name="taxaAdm">{{{grupo_economico_request_taxa_adm_value}}} (optional)</param> 
        /// <param name="taxaBanco">{{{grupo_economico_request_taxa_banco_value}}} (optional)</param> 
        /// <param name="limiteRAV">{{{grupo_economico_request_limite_r_a_v_value}}} (optional)</param> 
        /// <param name="idCredorRAV">{{{grupo_economico_request_id_credor_r_a_v_value}}} (optional)</param> 
        /// <returns>PageGrupoEconomicoResponse</returns>
        public PageGrupoEconomicoResponse ListarUsingGET25 (List<string> sort = null, int? page = null, int? limit = null, string razaoSocial = null, string nomeCredor = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, string periodicidade = null, string pagamentoSemanal = null, int? pagamentoMensal = null, int? pagamentoDecendialPrimeiro = null, int? pagamentoDecendialSegundo = null, int? pagamentoDecendialTerceiro = null, int? pagamentoQuinzenalPrimeiro = null, int? pagamentoQuinzenalSegundo = null, double? percentualRAV = null, string recebeRAV = null, double? percentualMultiplica = null, double? taxaAdm = null, double? taxaBanco = null, double? limiteRAV = null, long? idCredorRAV = null)
        {
             ApiResponse<PageGrupoEconomicoResponse> localVarResponse = ListarUsingGET25WithHttpInfo(sort, page, limit, razaoSocial, nomeCredor, numeroReceitaFederal, inscricaoEstadual, contato, banco, agencia, digitoAgencia, contaCorrente, digitoContaCorrente, periodicidade, pagamentoSemanal, pagamentoMensal, pagamentoDecendialPrimeiro, pagamentoDecendialSegundo, pagamentoDecendialTerceiro, pagamentoQuinzenalPrimeiro, pagamentoQuinzenalSegundo, percentualRAV, recebeRAV, percentualMultiplica, taxaAdm, taxaBanco, limiteRAV, idCredorRAV);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{grupo_economico_resource_listar}}} {{{grupo_economico_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="razaoSocial">{{{grupo_economico_request_razao_social_value}}} (optional)</param> 
        /// <param name="nomeCredor">{{{grupo_economico_request_nome_credor_value}}} (optional)</param> 
        /// <param name="numeroReceitaFederal">{{{grupo_economico_request_numero_receita_federal_value}}} (optional)</param> 
        /// <param name="inscricaoEstadual">{{{grupo_economico_request_inscricao_estadual_value}}} (optional)</param> 
        /// <param name="contato">{{{grupo_economico_request_contato_value}}} (optional)</param> 
        /// <param name="banco">{{{grupo_economico_request_banco_value}}} (optional)</param> 
        /// <param name="agencia">{{{grupo_economico_request_agencia_value}}} (optional)</param> 
        /// <param name="digitoAgencia">{{{grupo_economico_request_digito_agencia_value}}} (optional)</param> 
        /// <param name="contaCorrente">{{{grupo_economico_request_conta_corrente_value}}} (optional)</param> 
        /// <param name="digitoContaCorrente">{{{grupo_economico_request_digito_conta_corrente_value}}} (optional)</param> 
        /// <param name="periodicidade">{{{grupo_economico_request_periodicidade_value}}} (optional)</param> 
        /// <param name="pagamentoSemanal">{{{grupo_economico_request_pagamento_semanal_value}}} (optional)</param> 
        /// <param name="pagamentoMensal">{{{grupo_economico_request_pagamento_mensal_value}}} (optional)</param> 
        /// <param name="pagamentoDecendialPrimeiro">{{{grupo_economico_request_pagamento_decendial_primeiro_value}}} (optional)</param> 
        /// <param name="pagamentoDecendialSegundo">{{{grupo_economico_request_pagamento_decendial_segundo_value}}} (optional)</param> 
        /// <param name="pagamentoDecendialTerceiro">{{{grupo_economico_request_pagamento_decendial_terceiro_value}}} (optional)</param> 
        /// <param name="pagamentoQuinzenalPrimeiro">{{{grupo_economico_request_pagamento_quinzenal_primeiro_value}}} (optional)</param> 
        /// <param name="pagamentoQuinzenalSegundo">{{{grupo_economico_request_pagamento_quinzenal_segundo_value}}} (optional)</param> 
        /// <param name="percentualRAV">{{{grupo_economico_request_percentual_r_a_v_value}}} (optional)</param> 
        /// <param name="recebeRAV">{{{grupo_economico_request_recebe_r_a_v_value}}} (optional)</param> 
        /// <param name="percentualMultiplica">{{{grupo_economico_request_percentual_multiplica_value}}} (optional)</param> 
        /// <param name="taxaAdm">{{{grupo_economico_request_taxa_adm_value}}} (optional)</param> 
        /// <param name="taxaBanco">{{{grupo_economico_request_taxa_banco_value}}} (optional)</param> 
        /// <param name="limiteRAV">{{{grupo_economico_request_limite_r_a_v_value}}} (optional)</param> 
        /// <param name="idCredorRAV">{{{grupo_economico_request_id_credor_r_a_v_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageGrupoEconomicoResponse</returns>
        public ApiResponse< PageGrupoEconomicoResponse > ListarUsingGET25WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string razaoSocial = null, string nomeCredor = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, string periodicidade = null, string pagamentoSemanal = null, int? pagamentoMensal = null, int? pagamentoDecendialPrimeiro = null, int? pagamentoDecendialSegundo = null, int? pagamentoDecendialTerceiro = null, int? pagamentoQuinzenalPrimeiro = null, int? pagamentoQuinzenalSegundo = null, double? percentualRAV = null, string recebeRAV = null, double? percentualMultiplica = null, double? taxaAdm = null, double? taxaBanco = null, double? limiteRAV = null, long? idCredorRAV = null)
        {
            
    
            var localVarPath = "/api/grupos-economicos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (razaoSocial != null) localVarQueryParams.Add("razaoSocial", Configuration.ApiClient.ParameterToString(razaoSocial)); // query parameter
            if (nomeCredor != null) localVarQueryParams.Add("nomeCredor", Configuration.ApiClient.ParameterToString(nomeCredor)); // query parameter
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (inscricaoEstadual != null) localVarQueryParams.Add("inscricaoEstadual", Configuration.ApiClient.ParameterToString(inscricaoEstadual)); // query parameter
            if (contato != null) localVarQueryParams.Add("contato", Configuration.ApiClient.ParameterToString(contato)); // query parameter
            if (banco != null) localVarQueryParams.Add("banco", Configuration.ApiClient.ParameterToString(banco)); // query parameter
            if (agencia != null) localVarQueryParams.Add("agencia", Configuration.ApiClient.ParameterToString(agencia)); // query parameter
            if (digitoAgencia != null) localVarQueryParams.Add("digitoAgencia", Configuration.ApiClient.ParameterToString(digitoAgencia)); // query parameter
            if (contaCorrente != null) localVarQueryParams.Add("contaCorrente", Configuration.ApiClient.ParameterToString(contaCorrente)); // query parameter
            if (digitoContaCorrente != null) localVarQueryParams.Add("digitoContaCorrente", Configuration.ApiClient.ParameterToString(digitoContaCorrente)); // query parameter
            if (periodicidade != null) localVarQueryParams.Add("periodicidade", Configuration.ApiClient.ParameterToString(periodicidade)); // query parameter
            if (pagamentoSemanal != null) localVarQueryParams.Add("pagamentoSemanal", Configuration.ApiClient.ParameterToString(pagamentoSemanal)); // query parameter
            if (pagamentoMensal != null) localVarQueryParams.Add("pagamentoMensal", Configuration.ApiClient.ParameterToString(pagamentoMensal)); // query parameter
            if (pagamentoDecendialPrimeiro != null) localVarQueryParams.Add("pagamentoDecendialPrimeiro", Configuration.ApiClient.ParameterToString(pagamentoDecendialPrimeiro)); // query parameter
            if (pagamentoDecendialSegundo != null) localVarQueryParams.Add("pagamentoDecendialSegundo", Configuration.ApiClient.ParameterToString(pagamentoDecendialSegundo)); // query parameter
            if (pagamentoDecendialTerceiro != null) localVarQueryParams.Add("pagamentoDecendialTerceiro", Configuration.ApiClient.ParameterToString(pagamentoDecendialTerceiro)); // query parameter
            if (pagamentoQuinzenalPrimeiro != null) localVarQueryParams.Add("pagamentoQuinzenalPrimeiro", Configuration.ApiClient.ParameterToString(pagamentoQuinzenalPrimeiro)); // query parameter
            if (pagamentoQuinzenalSegundo != null) localVarQueryParams.Add("pagamentoQuinzenalSegundo", Configuration.ApiClient.ParameterToString(pagamentoQuinzenalSegundo)); // query parameter
            if (percentualRAV != null) localVarQueryParams.Add("percentualRAV", Configuration.ApiClient.ParameterToString(percentualRAV)); // query parameter
            if (recebeRAV != null) localVarQueryParams.Add("recebeRAV", Configuration.ApiClient.ParameterToString(recebeRAV)); // query parameter
            if (percentualMultiplica != null) localVarQueryParams.Add("percentualMultiplica", Configuration.ApiClient.ParameterToString(percentualMultiplica)); // query parameter
            if (taxaAdm != null) localVarQueryParams.Add("taxaAdm", Configuration.ApiClient.ParameterToString(taxaAdm)); // query parameter
            if (taxaBanco != null) localVarQueryParams.Add("taxaBanco", Configuration.ApiClient.ParameterToString(taxaBanco)); // query parameter
            if (limiteRAV != null) localVarQueryParams.Add("limiteRAV", Configuration.ApiClient.ParameterToString(limiteRAV)); // query parameter
            if (idCredorRAV != null) localVarQueryParams.Add("idCredorRAV", Configuration.ApiClient.ParameterToString(idCredorRAV)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET25: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET25: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageGrupoEconomicoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageGrupoEconomicoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageGrupoEconomicoResponse)));
            
        }

        
        /// <summary>
        /// {{{grupo_economico_resource_listar}}} {{{grupo_economico_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="razaoSocial">{{{grupo_economico_request_razao_social_value}}} (optional)</param>
        /// <param name="nomeCredor">{{{grupo_economico_request_nome_credor_value}}} (optional)</param>
        /// <param name="numeroReceitaFederal">{{{grupo_economico_request_numero_receita_federal_value}}} (optional)</param>
        /// <param name="inscricaoEstadual">{{{grupo_economico_request_inscricao_estadual_value}}} (optional)</param>
        /// <param name="contato">{{{grupo_economico_request_contato_value}}} (optional)</param>
        /// <param name="banco">{{{grupo_economico_request_banco_value}}} (optional)</param>
        /// <param name="agencia">{{{grupo_economico_request_agencia_value}}} (optional)</param>
        /// <param name="digitoAgencia">{{{grupo_economico_request_digito_agencia_value}}} (optional)</param>
        /// <param name="contaCorrente">{{{grupo_economico_request_conta_corrente_value}}} (optional)</param>
        /// <param name="digitoContaCorrente">{{{grupo_economico_request_digito_conta_corrente_value}}} (optional)</param>
        /// <param name="periodicidade">{{{grupo_economico_request_periodicidade_value}}} (optional)</param>
        /// <param name="pagamentoSemanal">{{{grupo_economico_request_pagamento_semanal_value}}} (optional)</param>
        /// <param name="pagamentoMensal">{{{grupo_economico_request_pagamento_mensal_value}}} (optional)</param>
        /// <param name="pagamentoDecendialPrimeiro">{{{grupo_economico_request_pagamento_decendial_primeiro_value}}} (optional)</param>
        /// <param name="pagamentoDecendialSegundo">{{{grupo_economico_request_pagamento_decendial_segundo_value}}} (optional)</param>
        /// <param name="pagamentoDecendialTerceiro">{{{grupo_economico_request_pagamento_decendial_terceiro_value}}} (optional)</param>
        /// <param name="pagamentoQuinzenalPrimeiro">{{{grupo_economico_request_pagamento_quinzenal_primeiro_value}}} (optional)</param>
        /// <param name="pagamentoQuinzenalSegundo">{{{grupo_economico_request_pagamento_quinzenal_segundo_value}}} (optional)</param>
        /// <param name="percentualRAV">{{{grupo_economico_request_percentual_r_a_v_value}}} (optional)</param>
        /// <param name="recebeRAV">{{{grupo_economico_request_recebe_r_a_v_value}}} (optional)</param>
        /// <param name="percentualMultiplica">{{{grupo_economico_request_percentual_multiplica_value}}} (optional)</param>
        /// <param name="taxaAdm">{{{grupo_economico_request_taxa_adm_value}}} (optional)</param>
        /// <param name="taxaBanco">{{{grupo_economico_request_taxa_banco_value}}} (optional)</param>
        /// <param name="limiteRAV">{{{grupo_economico_request_limite_r_a_v_value}}} (optional)</param>
        /// <param name="idCredorRAV">{{{grupo_economico_request_id_credor_r_a_v_value}}} (optional)</param>
        /// <returns>Task of PageGrupoEconomicoResponse</returns>
        public async System.Threading.Tasks.Task<PageGrupoEconomicoResponse> ListarUsingGET25Async (List<string> sort = null, int? page = null, int? limit = null, string razaoSocial = null, string nomeCredor = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, string periodicidade = null, string pagamentoSemanal = null, int? pagamentoMensal = null, int? pagamentoDecendialPrimeiro = null, int? pagamentoDecendialSegundo = null, int? pagamentoDecendialTerceiro = null, int? pagamentoQuinzenalPrimeiro = null, int? pagamentoQuinzenalSegundo = null, double? percentualRAV = null, string recebeRAV = null, double? percentualMultiplica = null, double? taxaAdm = null, double? taxaBanco = null, double? limiteRAV = null, long? idCredorRAV = null)
        {
             ApiResponse<PageGrupoEconomicoResponse> localVarResponse = await ListarUsingGET25AsyncWithHttpInfo(sort, page, limit, razaoSocial, nomeCredor, numeroReceitaFederal, inscricaoEstadual, contato, banco, agencia, digitoAgencia, contaCorrente, digitoContaCorrente, periodicidade, pagamentoSemanal, pagamentoMensal, pagamentoDecendialPrimeiro, pagamentoDecendialSegundo, pagamentoDecendialTerceiro, pagamentoQuinzenalPrimeiro, pagamentoQuinzenalSegundo, percentualRAV, recebeRAV, percentualMultiplica, taxaAdm, taxaBanco, limiteRAV, idCredorRAV);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{grupo_economico_resource_listar}}} {{{grupo_economico_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="razaoSocial">{{{grupo_economico_request_razao_social_value}}} (optional)</param>
        /// <param name="nomeCredor">{{{grupo_economico_request_nome_credor_value}}} (optional)</param>
        /// <param name="numeroReceitaFederal">{{{grupo_economico_request_numero_receita_federal_value}}} (optional)</param>
        /// <param name="inscricaoEstadual">{{{grupo_economico_request_inscricao_estadual_value}}} (optional)</param>
        /// <param name="contato">{{{grupo_economico_request_contato_value}}} (optional)</param>
        /// <param name="banco">{{{grupo_economico_request_banco_value}}} (optional)</param>
        /// <param name="agencia">{{{grupo_economico_request_agencia_value}}} (optional)</param>
        /// <param name="digitoAgencia">{{{grupo_economico_request_digito_agencia_value}}} (optional)</param>
        /// <param name="contaCorrente">{{{grupo_economico_request_conta_corrente_value}}} (optional)</param>
        /// <param name="digitoContaCorrente">{{{grupo_economico_request_digito_conta_corrente_value}}} (optional)</param>
        /// <param name="periodicidade">{{{grupo_economico_request_periodicidade_value}}} (optional)</param>
        /// <param name="pagamentoSemanal">{{{grupo_economico_request_pagamento_semanal_value}}} (optional)</param>
        /// <param name="pagamentoMensal">{{{grupo_economico_request_pagamento_mensal_value}}} (optional)</param>
        /// <param name="pagamentoDecendialPrimeiro">{{{grupo_economico_request_pagamento_decendial_primeiro_value}}} (optional)</param>
        /// <param name="pagamentoDecendialSegundo">{{{grupo_economico_request_pagamento_decendial_segundo_value}}} (optional)</param>
        /// <param name="pagamentoDecendialTerceiro">{{{grupo_economico_request_pagamento_decendial_terceiro_value}}} (optional)</param>
        /// <param name="pagamentoQuinzenalPrimeiro">{{{grupo_economico_request_pagamento_quinzenal_primeiro_value}}} (optional)</param>
        /// <param name="pagamentoQuinzenalSegundo">{{{grupo_economico_request_pagamento_quinzenal_segundo_value}}} (optional)</param>
        /// <param name="percentualRAV">{{{grupo_economico_request_percentual_r_a_v_value}}} (optional)</param>
        /// <param name="recebeRAV">{{{grupo_economico_request_recebe_r_a_v_value}}} (optional)</param>
        /// <param name="percentualMultiplica">{{{grupo_economico_request_percentual_multiplica_value}}} (optional)</param>
        /// <param name="taxaAdm">{{{grupo_economico_request_taxa_adm_value}}} (optional)</param>
        /// <param name="taxaBanco">{{{grupo_economico_request_taxa_banco_value}}} (optional)</param>
        /// <param name="limiteRAV">{{{grupo_economico_request_limite_r_a_v_value}}} (optional)</param>
        /// <param name="idCredorRAV">{{{grupo_economico_request_id_credor_r_a_v_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageGrupoEconomicoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageGrupoEconomicoResponse>> ListarUsingGET25AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string razaoSocial = null, string nomeCredor = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, string periodicidade = null, string pagamentoSemanal = null, int? pagamentoMensal = null, int? pagamentoDecendialPrimeiro = null, int? pagamentoDecendialSegundo = null, int? pagamentoDecendialTerceiro = null, int? pagamentoQuinzenalPrimeiro = null, int? pagamentoQuinzenalSegundo = null, double? percentualRAV = null, string recebeRAV = null, double? percentualMultiplica = null, double? taxaAdm = null, double? taxaBanco = null, double? limiteRAV = null, long? idCredorRAV = null)
        {
            
    
            var localVarPath = "/api/grupos-economicos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (razaoSocial != null) localVarQueryParams.Add("razaoSocial", Configuration.ApiClient.ParameterToString(razaoSocial)); // query parameter
            if (nomeCredor != null) localVarQueryParams.Add("nomeCredor", Configuration.ApiClient.ParameterToString(nomeCredor)); // query parameter
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (inscricaoEstadual != null) localVarQueryParams.Add("inscricaoEstadual", Configuration.ApiClient.ParameterToString(inscricaoEstadual)); // query parameter
            if (contato != null) localVarQueryParams.Add("contato", Configuration.ApiClient.ParameterToString(contato)); // query parameter
            if (banco != null) localVarQueryParams.Add("banco", Configuration.ApiClient.ParameterToString(banco)); // query parameter
            if (agencia != null) localVarQueryParams.Add("agencia", Configuration.ApiClient.ParameterToString(agencia)); // query parameter
            if (digitoAgencia != null) localVarQueryParams.Add("digitoAgencia", Configuration.ApiClient.ParameterToString(digitoAgencia)); // query parameter
            if (contaCorrente != null) localVarQueryParams.Add("contaCorrente", Configuration.ApiClient.ParameterToString(contaCorrente)); // query parameter
            if (digitoContaCorrente != null) localVarQueryParams.Add("digitoContaCorrente", Configuration.ApiClient.ParameterToString(digitoContaCorrente)); // query parameter
            if (periodicidade != null) localVarQueryParams.Add("periodicidade", Configuration.ApiClient.ParameterToString(periodicidade)); // query parameter
            if (pagamentoSemanal != null) localVarQueryParams.Add("pagamentoSemanal", Configuration.ApiClient.ParameterToString(pagamentoSemanal)); // query parameter
            if (pagamentoMensal != null) localVarQueryParams.Add("pagamentoMensal", Configuration.ApiClient.ParameterToString(pagamentoMensal)); // query parameter
            if (pagamentoDecendialPrimeiro != null) localVarQueryParams.Add("pagamentoDecendialPrimeiro", Configuration.ApiClient.ParameterToString(pagamentoDecendialPrimeiro)); // query parameter
            if (pagamentoDecendialSegundo != null) localVarQueryParams.Add("pagamentoDecendialSegundo", Configuration.ApiClient.ParameterToString(pagamentoDecendialSegundo)); // query parameter
            if (pagamentoDecendialTerceiro != null) localVarQueryParams.Add("pagamentoDecendialTerceiro", Configuration.ApiClient.ParameterToString(pagamentoDecendialTerceiro)); // query parameter
            if (pagamentoQuinzenalPrimeiro != null) localVarQueryParams.Add("pagamentoQuinzenalPrimeiro", Configuration.ApiClient.ParameterToString(pagamentoQuinzenalPrimeiro)); // query parameter
            if (pagamentoQuinzenalSegundo != null) localVarQueryParams.Add("pagamentoQuinzenalSegundo", Configuration.ApiClient.ParameterToString(pagamentoQuinzenalSegundo)); // query parameter
            if (percentualRAV != null) localVarQueryParams.Add("percentualRAV", Configuration.ApiClient.ParameterToString(percentualRAV)); // query parameter
            if (recebeRAV != null) localVarQueryParams.Add("recebeRAV", Configuration.ApiClient.ParameterToString(recebeRAV)); // query parameter
            if (percentualMultiplica != null) localVarQueryParams.Add("percentualMultiplica", Configuration.ApiClient.ParameterToString(percentualMultiplica)); // query parameter
            if (taxaAdm != null) localVarQueryParams.Add("taxaAdm", Configuration.ApiClient.ParameterToString(taxaAdm)); // query parameter
            if (taxaBanco != null) localVarQueryParams.Add("taxaBanco", Configuration.ApiClient.ParameterToString(taxaBanco)); // query parameter
            if (limiteRAV != null) localVarQueryParams.Add("limiteRAV", Configuration.ApiClient.ParameterToString(limiteRAV)); // query parameter
            if (idCredorRAV != null) localVarQueryParams.Add("idCredorRAV", Configuration.ApiClient.ParameterToString(idCredorRAV)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET25: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET25: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageGrupoEconomicoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageGrupoEconomicoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageGrupoEconomicoResponse)));
            
        }
        
        /// <summary>
        /// {{{grupo_origem_comercial_resource_listar}}} {{{grupo_origem_comercial_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="nome">{{{grupo_origem_comercial_request_nome_value}}} (optional)</param> 
        /// <returns>PageGrupoOrigemComercialResponse</returns>
        public PageGrupoOrigemComercialResponse ListarUsingGET26 (List<string> sort = null, int? page = null, int? limit = null, string nome = null)
        {
             ApiResponse<PageGrupoOrigemComercialResponse> localVarResponse = ListarUsingGET26WithHttpInfo(sort, page, limit, nome);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{grupo_origem_comercial_resource_listar}}} {{{grupo_origem_comercial_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="nome">{{{grupo_origem_comercial_request_nome_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageGrupoOrigemComercialResponse</returns>
        public ApiResponse< PageGrupoOrigemComercialResponse > ListarUsingGET26WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null)
        {
            
    
            var localVarPath = "/api/grupos-origens-comerciais";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET26: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET26: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageGrupoOrigemComercialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageGrupoOrigemComercialResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageGrupoOrigemComercialResponse)));
            
        }

        
        /// <summary>
        /// {{{grupo_origem_comercial_resource_listar}}} {{{grupo_origem_comercial_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{grupo_origem_comercial_request_nome_value}}} (optional)</param>
        /// <returns>Task of PageGrupoOrigemComercialResponse</returns>
        public async System.Threading.Tasks.Task<PageGrupoOrigemComercialResponse> ListarUsingGET26Async (List<string> sort = null, int? page = null, int? limit = null, string nome = null)
        {
             ApiResponse<PageGrupoOrigemComercialResponse> localVarResponse = await ListarUsingGET26AsyncWithHttpInfo(sort, page, limit, nome);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{grupo_origem_comercial_resource_listar}}} {{{grupo_origem_comercial_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{grupo_origem_comercial_request_nome_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageGrupoOrigemComercialResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageGrupoOrigemComercialResponse>> ListarUsingGET26AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null)
        {
            
    
            var localVarPath = "/api/grupos-origens-comerciais";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET26: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET26: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageGrupoOrigemComercialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageGrupoOrigemComercialResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageGrupoOrigemComercialResponse)));
            
        }
        
        /// <summary>
        /// {{{maquineta_resource_listar}}} {{{maquineta_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idEstabelecimento">{{{maquineta_request_id_estabelecimento_value}}} (optional)</param> 
        /// <returns>PageMaquinetaResponse</returns>
        public PageMaquinetaResponse ListarUsingGET28 (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null)
        {
             ApiResponse<PageMaquinetaResponse> localVarResponse = ListarUsingGET28WithHttpInfo(sort, page, limit, idEstabelecimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{maquineta_resource_listar}}} {{{maquineta_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idEstabelecimento">{{{maquineta_request_id_estabelecimento_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageMaquinetaResponse</returns>
        public ApiResponse< PageMaquinetaResponse > ListarUsingGET28WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null)
        {
            
    
            var localVarPath = "/api/maquinetas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET28: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET28: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageMaquinetaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageMaquinetaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageMaquinetaResponse)));
            
        }

        
        /// <summary>
        /// {{{maquineta_resource_listar}}} {{{maquineta_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{maquineta_request_id_estabelecimento_value}}} (optional)</param>
        /// <returns>Task of PageMaquinetaResponse</returns>
        public async System.Threading.Tasks.Task<PageMaquinetaResponse> ListarUsingGET28Async (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null)
        {
             ApiResponse<PageMaquinetaResponse> localVarResponse = await ListarUsingGET28AsyncWithHttpInfo(sort, page, limit, idEstabelecimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{maquineta_resource_listar}}} {{{maquineta_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{maquineta_request_id_estabelecimento_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageMaquinetaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageMaquinetaResponse>> ListarUsingGET28AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null)
        {
            
    
            var localVarPath = "/api/maquinetas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET28: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET28: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageMaquinetaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageMaquinetaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageMaquinetaResponse)));
            
        }
        
        /// <summary>
        /// {{{moeda_resource_listar}}} {{{moeda_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="codigoMoeda">{{{moeda_request_codigo_moeda_value}}} (optional)</param> 
        /// <param name="simbolo">{{{moeda_request_simbolo_value}}} (optional)</param> 
        /// <param name="descricao">{{{moeda_request_descricao_value}}} (optional)</param> 
        /// <returns>PageMoedaResponse</returns>
        public PageMoedaResponse ListarUsingGET29 (List<string> sort = null, int? page = null, int? limit = null, string codigoMoeda = null, string simbolo = null, string descricao = null)
        {
             ApiResponse<PageMoedaResponse> localVarResponse = ListarUsingGET29WithHttpInfo(sort, page, limit, codigoMoeda, simbolo, descricao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{moeda_resource_listar}}} {{{moeda_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="codigoMoeda">{{{moeda_request_codigo_moeda_value}}} (optional)</param> 
        /// <param name="simbolo">{{{moeda_request_simbolo_value}}} (optional)</param> 
        /// <param name="descricao">{{{moeda_request_descricao_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageMoedaResponse</returns>
        public ApiResponse< PageMoedaResponse > ListarUsingGET29WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string codigoMoeda = null, string simbolo = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/tipos-moedas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (codigoMoeda != null) localVarQueryParams.Add("codigoMoeda", Configuration.ApiClient.ParameterToString(codigoMoeda)); // query parameter
            if (simbolo != null) localVarQueryParams.Add("simbolo", Configuration.ApiClient.ParameterToString(simbolo)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET29: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET29: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageMoedaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageMoedaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageMoedaResponse)));
            
        }

        
        /// <summary>
        /// {{{moeda_resource_listar}}} {{{moeda_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="codigoMoeda">{{{moeda_request_codigo_moeda_value}}} (optional)</param>
        /// <param name="simbolo">{{{moeda_request_simbolo_value}}} (optional)</param>
        /// <param name="descricao">{{{moeda_request_descricao_value}}} (optional)</param>
        /// <returns>Task of PageMoedaResponse</returns>
        public async System.Threading.Tasks.Task<PageMoedaResponse> ListarUsingGET29Async (List<string> sort = null, int? page = null, int? limit = null, string codigoMoeda = null, string simbolo = null, string descricao = null)
        {
             ApiResponse<PageMoedaResponse> localVarResponse = await ListarUsingGET29AsyncWithHttpInfo(sort, page, limit, codigoMoeda, simbolo, descricao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{moeda_resource_listar}}} {{{moeda_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="codigoMoeda">{{{moeda_request_codigo_moeda_value}}} (optional)</param>
        /// <param name="simbolo">{{{moeda_request_simbolo_value}}} (optional)</param>
        /// <param name="descricao">{{{moeda_request_descricao_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageMoedaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageMoedaResponse>> ListarUsingGET29AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string codigoMoeda = null, string simbolo = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/tipos-moedas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (codigoMoeda != null) localVarQueryParams.Add("codigoMoeda", Configuration.ApiClient.ParameterToString(codigoMoeda)); // query parameter
            if (simbolo != null) localVarQueryParams.Add("simbolo", Configuration.ApiClient.ParameterToString(simbolo)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET29: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET29: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageMoedaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageMoedaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageMoedaResponse)));
            
        }
        
        /// <summary>
        /// {{{operacao_credor_resource_listar}}} {{{operacao_credor_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idOperacao">{{{operacao_credor_request_id_operacao_value}}} (optional)</param> 
        /// <param name="idCredor">{{{operacao_credor_request_id_credor_value}}} (optional)</param> 
        /// <param name="idProduto">{{{operacao_credor_request_id_produto_value}}} (optional)</param> 
        /// <returns>PageOperacaoCredorResponse</returns>
        public PageOperacaoCredorResponse ListarUsingGET30 (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, long? idCredor = null, long? idProduto = null)
        {
             ApiResponse<PageOperacaoCredorResponse> localVarResponse = ListarUsingGET30WithHttpInfo(sort, page, limit, idOperacao, idCredor, idProduto);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{operacao_credor_resource_listar}}} {{{operacao_credor_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idOperacao">{{{operacao_credor_request_id_operacao_value}}} (optional)</param> 
        /// <param name="idCredor">{{{operacao_credor_request_id_credor_value}}} (optional)</param> 
        /// <param name="idProduto">{{{operacao_credor_request_id_produto_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageOperacaoCredorResponse</returns>
        public ApiResponse< PageOperacaoCredorResponse > ListarUsingGET30WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, long? idCredor = null, long? idProduto = null)
        {
            
    
            var localVarPath = "/api/regras-operacoes-estabelecimentos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idOperacao != null) localVarQueryParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // query parameter
            if (idCredor != null) localVarQueryParams.Add("idCredor", Configuration.ApiClient.ParameterToString(idCredor)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET30: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET30: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageOperacaoCredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOperacaoCredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOperacaoCredorResponse)));
            
        }

        
        /// <summary>
        /// {{{operacao_credor_resource_listar}}} {{{operacao_credor_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idOperacao">{{{operacao_credor_request_id_operacao_value}}} (optional)</param>
        /// <param name="idCredor">{{{operacao_credor_request_id_credor_value}}} (optional)</param>
        /// <param name="idProduto">{{{operacao_credor_request_id_produto_value}}} (optional)</param>
        /// <returns>Task of PageOperacaoCredorResponse</returns>
        public async System.Threading.Tasks.Task<PageOperacaoCredorResponse> ListarUsingGET30Async (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, long? idCredor = null, long? idProduto = null)
        {
             ApiResponse<PageOperacaoCredorResponse> localVarResponse = await ListarUsingGET30AsyncWithHttpInfo(sort, page, limit, idOperacao, idCredor, idProduto);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{operacao_credor_resource_listar}}} {{{operacao_credor_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idOperacao">{{{operacao_credor_request_id_operacao_value}}} (optional)</param>
        /// <param name="idCredor">{{{operacao_credor_request_id_credor_value}}} (optional)</param>
        /// <param name="idProduto">{{{operacao_credor_request_id_produto_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageOperacaoCredorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageOperacaoCredorResponse>> ListarUsingGET30AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, long? idCredor = null, long? idProduto = null)
        {
            
    
            var localVarPath = "/api/regras-operacoes-estabelecimentos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idOperacao != null) localVarQueryParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // query parameter
            if (idCredor != null) localVarQueryParams.Add("idCredor", Configuration.ApiClient.ParameterToString(idCredor)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET30: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET30: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageOperacaoCredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOperacaoCredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOperacaoCredorResponse)));
            
        }
        
        /// <summary>
        /// {{{telefone_estabelecimento_resource_listar}}} {{{telefone_estabelecimento_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idEstabelecimento">{{{telefone_estabelecimento_request_id_estabelecimento_value}}} (optional)</param> 
        /// <returns>PageTelefoneEstabelecimentoResponse</returns>
        public PageTelefoneEstabelecimentoResponse ListarUsingGET44 (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null)
        {
             ApiResponse<PageTelefoneEstabelecimentoResponse> localVarResponse = ListarUsingGET44WithHttpInfo(sort, page, limit, idEstabelecimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{telefone_estabelecimento_resource_listar}}} {{{telefone_estabelecimento_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idEstabelecimento">{{{telefone_estabelecimento_request_id_estabelecimento_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageTelefoneEstabelecimentoResponse</returns>
        public ApiResponse< PageTelefoneEstabelecimentoResponse > ListarUsingGET44WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null)
        {
            
    
            var localVarPath = "/api/telefones-estabelecimentos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET44: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET44: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTelefoneEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTelefoneEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTelefoneEstabelecimentoResponse)));
            
        }

        
        /// <summary>
        /// {{{telefone_estabelecimento_resource_listar}}} {{{telefone_estabelecimento_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{telefone_estabelecimento_request_id_estabelecimento_value}}} (optional)</param>
        /// <returns>Task of PageTelefoneEstabelecimentoResponse</returns>
        public async System.Threading.Tasks.Task<PageTelefoneEstabelecimentoResponse> ListarUsingGET44Async (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null)
        {
             ApiResponse<PageTelefoneEstabelecimentoResponse> localVarResponse = await ListarUsingGET44AsyncWithHttpInfo(sort, page, limit, idEstabelecimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{telefone_estabelecimento_resource_listar}}} {{{telefone_estabelecimento_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{telefone_estabelecimento_request_id_estabelecimento_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTelefoneEstabelecimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTelefoneEstabelecimentoResponse>> ListarUsingGET44AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null)
        {
            
    
            var localVarPath = "/api/telefones-estabelecimentos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET44: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET44: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTelefoneEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTelefoneEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTelefoneEstabelecimentoResponse)));
            
        }
        
        /// <summary>
        /// {{{terminal_resource_listar}}} {{{terminal_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{terminal_request_id_value}}} (optional)</param> 
        /// <param name="terminal">{{{terminal_request_terminal_value}}} (optional)</param> 
        /// <param name="numeroEstabelecimento">{{{terminal_request_numero_estabelecimento_value}}} (optional)</param> 
        /// <param name="idEstabelecimento">{{{terminal_request_id_estabelecimento_value}}} (optional)</param> 
        /// <returns>PageTerminalResponse</returns>
        public PageTerminalResponse ListarUsingGET46 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null)
        {
             ApiResponse<PageTerminalResponse> localVarResponse = ListarUsingGET46WithHttpInfo(sort, page, limit, id, terminal, numeroEstabelecimento, idEstabelecimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{terminal_resource_listar}}} {{{terminal_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{terminal_request_id_value}}} (optional)</param> 
        /// <param name="terminal">{{{terminal_request_terminal_value}}} (optional)</param> 
        /// <param name="numeroEstabelecimento">{{{terminal_request_numero_estabelecimento_value}}} (optional)</param> 
        /// <param name="idEstabelecimento">{{{terminal_request_id_estabelecimento_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageTerminalResponse</returns>
        public ApiResponse< PageTerminalResponse > ListarUsingGET46WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null)
        {
            
    
            var localVarPath = "/api/terminais";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (terminal != null) localVarQueryParams.Add("terminal", Configuration.ApiClient.ParameterToString(terminal)); // query parameter
            if (numeroEstabelecimento != null) localVarQueryParams.Add("numeroEstabelecimento", Configuration.ApiClient.ParameterToString(numeroEstabelecimento)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET46: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET46: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTerminalResponse)));
            
        }

        
        /// <summary>
        /// {{{terminal_resource_listar}}} {{{terminal_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{terminal_request_id_value}}} (optional)</param>
        /// <param name="terminal">{{{terminal_request_terminal_value}}} (optional)</param>
        /// <param name="numeroEstabelecimento">{{{terminal_request_numero_estabelecimento_value}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{terminal_request_id_estabelecimento_value}}} (optional)</param>
        /// <returns>Task of PageTerminalResponse</returns>
        public async System.Threading.Tasks.Task<PageTerminalResponse> ListarUsingGET46Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null)
        {
             ApiResponse<PageTerminalResponse> localVarResponse = await ListarUsingGET46AsyncWithHttpInfo(sort, page, limit, id, terminal, numeroEstabelecimento, idEstabelecimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{terminal_resource_listar}}} {{{terminal_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{terminal_request_id_value}}} (optional)</param>
        /// <param name="terminal">{{{terminal_request_terminal_value}}} (optional)</param>
        /// <param name="numeroEstabelecimento">{{{terminal_request_numero_estabelecimento_value}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{terminal_request_id_estabelecimento_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTerminalResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTerminalResponse>> ListarUsingGET46AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null)
        {
            
    
            var localVarPath = "/api/terminais";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (terminal != null) localVarQueryParams.Add("terminal", Configuration.ApiClient.ParameterToString(terminal)); // query parameter
            if (numeroEstabelecimento != null) localVarQueryParams.Add("numeroEstabelecimento", Configuration.ApiClient.ParameterToString(numeroEstabelecimento)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET46: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET46: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTerminalResponse)));
            
        }
        
        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_listar}}} {{{vinculo_estabelecimento_adquirente_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idAdquirente">{{{vinculo_estabelecimento_adquirente_request_id_adquirente_value}}} (optional)</param> 
        /// <param name="idEstabelecimento">{{{vinculo_estabelecimento_adquirente_request_id_estabelecimento_value}}} (optional)</param> 
        /// <param name="codigoEstabelecimentoAdquirente">{{{vinculo_estabelecimento_adquirente_request_codigo_estabelecimento_adquirente_value}}} (optional)</param> 
        /// <returns>PageVinculoEstabelecimentoAdquirenteResponse</returns>
        public PageVinculoEstabelecimentoAdquirenteResponse ListarUsingGET58 (List<string> sort = null, int? page = null, int? limit = null, long? idAdquirente = null, long? idEstabelecimento = null, string codigoEstabelecimentoAdquirente = null)
        {
             ApiResponse<PageVinculoEstabelecimentoAdquirenteResponse> localVarResponse = ListarUsingGET58WithHttpInfo(sort, page, limit, idAdquirente, idEstabelecimento, codigoEstabelecimentoAdquirente);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_listar}}} {{{vinculo_estabelecimento_adquirente_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idAdquirente">{{{vinculo_estabelecimento_adquirente_request_id_adquirente_value}}} (optional)</param> 
        /// <param name="idEstabelecimento">{{{vinculo_estabelecimento_adquirente_request_id_estabelecimento_value}}} (optional)</param> 
        /// <param name="codigoEstabelecimentoAdquirente">{{{vinculo_estabelecimento_adquirente_request_codigo_estabelecimento_adquirente_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageVinculoEstabelecimentoAdquirenteResponse</returns>
        public ApiResponse< PageVinculoEstabelecimentoAdquirenteResponse > ListarUsingGET58WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idAdquirente = null, long? idEstabelecimento = null, string codigoEstabelecimentoAdquirente = null)
        {
            
    
            var localVarPath = "/api/adquirentes-estabelecimento";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idAdquirente != null) localVarQueryParams.Add("idAdquirente", Configuration.ApiClient.ParameterToString(idAdquirente)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            if (codigoEstabelecimentoAdquirente != null) localVarQueryParams.Add("codigoEstabelecimentoAdquirente", Configuration.ApiClient.ParameterToString(codigoEstabelecimentoAdquirente)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET58: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET58: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageVinculoEstabelecimentoAdquirenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageVinculoEstabelecimentoAdquirenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageVinculoEstabelecimentoAdquirenteResponse)));
            
        }

        
        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_listar}}} {{{vinculo_estabelecimento_adquirente_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idAdquirente">{{{vinculo_estabelecimento_adquirente_request_id_adquirente_value}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{vinculo_estabelecimento_adquirente_request_id_estabelecimento_value}}} (optional)</param>
        /// <param name="codigoEstabelecimentoAdquirente">{{{vinculo_estabelecimento_adquirente_request_codigo_estabelecimento_adquirente_value}}} (optional)</param>
        /// <returns>Task of PageVinculoEstabelecimentoAdquirenteResponse</returns>
        public async System.Threading.Tasks.Task<PageVinculoEstabelecimentoAdquirenteResponse> ListarUsingGET58Async (List<string> sort = null, int? page = null, int? limit = null, long? idAdquirente = null, long? idEstabelecimento = null, string codigoEstabelecimentoAdquirente = null)
        {
             ApiResponse<PageVinculoEstabelecimentoAdquirenteResponse> localVarResponse = await ListarUsingGET58AsyncWithHttpInfo(sort, page, limit, idAdquirente, idEstabelecimento, codigoEstabelecimentoAdquirente);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_listar}}} {{{vinculo_estabelecimento_adquirente_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idAdquirente">{{{vinculo_estabelecimento_adquirente_request_id_adquirente_value}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{vinculo_estabelecimento_adquirente_request_id_estabelecimento_value}}} (optional)</param>
        /// <param name="codigoEstabelecimentoAdquirente">{{{vinculo_estabelecimento_adquirente_request_codigo_estabelecimento_adquirente_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageVinculoEstabelecimentoAdquirenteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageVinculoEstabelecimentoAdquirenteResponse>> ListarUsingGET58AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idAdquirente = null, long? idEstabelecimento = null, string codigoEstabelecimentoAdquirente = null)
        {
            
    
            var localVarPath = "/api/adquirentes-estabelecimento";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idAdquirente != null) localVarQueryParams.Add("idAdquirente", Configuration.ApiClient.ParameterToString(idAdquirente)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            if (codigoEstabelecimentoAdquirente != null) localVarQueryParams.Add("codigoEstabelecimentoAdquirente", Configuration.ApiClient.ParameterToString(codigoEstabelecimentoAdquirente)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET58: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET58: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageVinculoEstabelecimentoAdquirenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageVinculoEstabelecimentoAdquirenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageVinculoEstabelecimentoAdquirenteResponse)));
            
        }
        
        /// <summary>
        /// {{{vinculo_operacao_resource_listar}}} {{{vinculo_operacao_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_operacao_resource_listar_param_id}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idProduto">{{{vinculo_operacao_request_id_produto_value}}} (optional)</param> 
        /// <param name="idOperacao">{{{vinculo_operacao_request_id_operacao_value}}} (optional)</param> 
        /// <param name="codigoMCC">{{{vinculo_operacao_request_codigo_m_c_c_value}}} (optional)</param> 
        /// <returns>PageVinculoOperacaoResponse</returns>
        public PageVinculoOperacaoResponse ListarUsingGET59 (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOperacao = null, int? codigoMCC = null)
        {
             ApiResponse<PageVinculoOperacaoResponse> localVarResponse = ListarUsingGET59WithHttpInfo(id, sort, page, limit, idProduto, idOperacao, codigoMCC);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{vinculo_operacao_resource_listar}}} {{{vinculo_operacao_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_operacao_resource_listar_param_id}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idProduto">{{{vinculo_operacao_request_id_produto_value}}} (optional)</param> 
        /// <param name="idOperacao">{{{vinculo_operacao_request_id_operacao_value}}} (optional)</param> 
        /// <param name="codigoMCC">{{{vinculo_operacao_request_codigo_m_c_c_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageVinculoOperacaoResponse</returns>
        public ApiResponse< PageVinculoOperacaoResponse > ListarUsingGET59WithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOperacao = null, int? codigoMCC = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagestabelecimentoApi->ListarUsingGET59");
            
    
            var localVarPath = "/api/estabelecimentos/{id}/operacoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (idOperacao != null) localVarQueryParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // query parameter
            if (codigoMCC != null) localVarQueryParams.Add("codigoMCC", Configuration.ApiClient.ParameterToString(codigoMCC)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET59: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET59: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageVinculoOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageVinculoOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageVinculoOperacaoResponse)));
            
        }

        
        /// <summary>
        /// {{{vinculo_operacao_resource_listar}}} {{{vinculo_operacao_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_operacao_resource_listar_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idProduto">{{{vinculo_operacao_request_id_produto_value}}} (optional)</param>
        /// <param name="idOperacao">{{{vinculo_operacao_request_id_operacao_value}}} (optional)</param>
        /// <param name="codigoMCC">{{{vinculo_operacao_request_codigo_m_c_c_value}}} (optional)</param>
        /// <returns>Task of PageVinculoOperacaoResponse</returns>
        public async System.Threading.Tasks.Task<PageVinculoOperacaoResponse> ListarUsingGET59Async (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOperacao = null, int? codigoMCC = null)
        {
             ApiResponse<PageVinculoOperacaoResponse> localVarResponse = await ListarUsingGET59AsyncWithHttpInfo(id, sort, page, limit, idProduto, idOperacao, codigoMCC);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{vinculo_operacao_resource_listar}}} {{{vinculo_operacao_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{vinculo_operacao_resource_listar_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idProduto">{{{vinculo_operacao_request_id_produto_value}}} (optional)</param>
        /// <param name="idOperacao">{{{vinculo_operacao_request_id_operacao_value}}} (optional)</param>
        /// <param name="codigoMCC">{{{vinculo_operacao_request_codigo_m_c_c_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageVinculoOperacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageVinculoOperacaoResponse>> ListarUsingGET59AsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOperacao = null, int? codigoMCC = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarUsingGET59");
            
    
            var localVarPath = "/api/estabelecimentos/{id}/operacoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (idOperacao != null) localVarQueryParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // query parameter
            if (codigoMCC != null) localVarQueryParams.Add("codigoMCC", Configuration.ApiClient.ParameterToString(codigoMCC)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET59: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET59: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageVinculoOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageVinculoOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageVinculoOperacaoResponse)));
            
        }
        
        /// <summary>
        /// {{{maquineta_resource_salvar}}} {{{maquineta_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maquinetaPersist">maquinetaPersist</param> 
        /// <returns>MaquinetaResponse</returns>
        public MaquinetaResponse SalvarUsingPOST17 (MaquinetaPersist maquinetaPersist)
        {
             ApiResponse<MaquinetaResponse> localVarResponse = SalvarUsingPOST17WithHttpInfo(maquinetaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{maquineta_resource_salvar}}} {{{maquineta_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maquinetaPersist">maquinetaPersist</param> 
        /// <returns>ApiResponse of MaquinetaResponse</returns>
        public ApiResponse< MaquinetaResponse > SalvarUsingPOST17WithHttpInfo (MaquinetaPersist maquinetaPersist)
        {
            
            // verify the required parameter 'maquinetaPersist' is set
            if (maquinetaPersist == null)
                throw new ApiException(400, "Missing required parameter 'maquinetaPersist' when calling GlobaltagestabelecimentoApi->SalvarUsingPOST17");
            
    
            var localVarPath = "/api/maquinetas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (maquinetaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(maquinetaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = maquinetaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST17: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST17: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<MaquinetaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MaquinetaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaquinetaResponse)));
            
        }

        
        /// <summary>
        /// {{{maquineta_resource_salvar}}} {{{maquineta_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maquinetaPersist">maquinetaPersist</param>
        /// <returns>Task of MaquinetaResponse</returns>
        public async System.Threading.Tasks.Task<MaquinetaResponse> SalvarUsingPOST17Async (MaquinetaPersist maquinetaPersist)
        {
             ApiResponse<MaquinetaResponse> localVarResponse = await SalvarUsingPOST17AsyncWithHttpInfo(maquinetaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{maquineta_resource_salvar}}} {{{maquineta_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maquinetaPersist">maquinetaPersist</param>
        /// <returns>Task of ApiResponse (MaquinetaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MaquinetaResponse>> SalvarUsingPOST17AsyncWithHttpInfo (MaquinetaPersist maquinetaPersist)
        {
            // verify the required parameter 'maquinetaPersist' is set
            if (maquinetaPersist == null) throw new ApiException(400, "Missing required parameter 'maquinetaPersist' when calling SalvarUsingPOST17");
            
    
            var localVarPath = "/api/maquinetas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (maquinetaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(maquinetaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = maquinetaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST17: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST17: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MaquinetaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MaquinetaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaquinetaResponse)));
            
        }
        
        /// <summary>
        /// {{{operacao_credor_resource_salvar}}} {{{operacao_credor_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operacaoCredorPersist">operacaoCredorPersist</param> 
        /// <returns>OperacaoCredorResponse</returns>
        public OperacaoCredorResponse SalvarUsingPOST18 (OperacaoCredorPersist operacaoCredorPersist)
        {
             ApiResponse<OperacaoCredorResponse> localVarResponse = SalvarUsingPOST18WithHttpInfo(operacaoCredorPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{operacao_credor_resource_salvar}}} {{{operacao_credor_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operacaoCredorPersist">operacaoCredorPersist</param> 
        /// <returns>ApiResponse of OperacaoCredorResponse</returns>
        public ApiResponse< OperacaoCredorResponse > SalvarUsingPOST18WithHttpInfo (OperacaoCredorPersist operacaoCredorPersist)
        {
            
            // verify the required parameter 'operacaoCredorPersist' is set
            if (operacaoCredorPersist == null)
                throw new ApiException(400, "Missing required parameter 'operacaoCredorPersist' when calling GlobaltagestabelecimentoApi->SalvarUsingPOST18");
            
    
            var localVarPath = "/api/regras-operacoes-estabelecimentos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (operacaoCredorPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(operacaoCredorPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = operacaoCredorPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST18: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST18: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OperacaoCredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OperacaoCredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperacaoCredorResponse)));
            
        }

        
        /// <summary>
        /// {{{operacao_credor_resource_salvar}}} {{{operacao_credor_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operacaoCredorPersist">operacaoCredorPersist</param>
        /// <returns>Task of OperacaoCredorResponse</returns>
        public async System.Threading.Tasks.Task<OperacaoCredorResponse> SalvarUsingPOST18Async (OperacaoCredorPersist operacaoCredorPersist)
        {
             ApiResponse<OperacaoCredorResponse> localVarResponse = await SalvarUsingPOST18AsyncWithHttpInfo(operacaoCredorPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{operacao_credor_resource_salvar}}} {{{operacao_credor_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operacaoCredorPersist">operacaoCredorPersist</param>
        /// <returns>Task of ApiResponse (OperacaoCredorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OperacaoCredorResponse>> SalvarUsingPOST18AsyncWithHttpInfo (OperacaoCredorPersist operacaoCredorPersist)
        {
            // verify the required parameter 'operacaoCredorPersist' is set
            if (operacaoCredorPersist == null) throw new ApiException(400, "Missing required parameter 'operacaoCredorPersist' when calling SalvarUsingPOST18");
            
    
            var localVarPath = "/api/regras-operacoes-estabelecimentos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (operacaoCredorPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(operacaoCredorPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = operacaoCredorPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST18: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST18: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OperacaoCredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OperacaoCredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperacaoCredorResponse)));
            
        }
        
        /// <summary>
        /// {{{telefone_estabelecimento_resource_salvar}}} {{{telefone_estabelecimento_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="telefoneEstabelecimentoPersist">telefoneEstabelecimentoPersist</param> 
        /// <returns>TelefoneEstabelecimentoResponse</returns>
        public TelefoneEstabelecimentoResponse SalvarUsingPOST23 (TelefoneEstabelecimentoPersist telefoneEstabelecimentoPersist)
        {
             ApiResponse<TelefoneEstabelecimentoResponse> localVarResponse = SalvarUsingPOST23WithHttpInfo(telefoneEstabelecimentoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{telefone_estabelecimento_resource_salvar}}} {{{telefone_estabelecimento_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="telefoneEstabelecimentoPersist">telefoneEstabelecimentoPersist</param> 
        /// <returns>ApiResponse of TelefoneEstabelecimentoResponse</returns>
        public ApiResponse< TelefoneEstabelecimentoResponse > SalvarUsingPOST23WithHttpInfo (TelefoneEstabelecimentoPersist telefoneEstabelecimentoPersist)
        {
            
            // verify the required parameter 'telefoneEstabelecimentoPersist' is set
            if (telefoneEstabelecimentoPersist == null)
                throw new ApiException(400, "Missing required parameter 'telefoneEstabelecimentoPersist' when calling GlobaltagestabelecimentoApi->SalvarUsingPOST23");
            
    
            var localVarPath = "/api/telefones-estabelecimentos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (telefoneEstabelecimentoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(telefoneEstabelecimentoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = telefoneEstabelecimentoPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST23: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST23: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TelefoneEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneEstabelecimentoResponse)));
            
        }

        
        /// <summary>
        /// {{{telefone_estabelecimento_resource_salvar}}} {{{telefone_estabelecimento_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="telefoneEstabelecimentoPersist">telefoneEstabelecimentoPersist</param>
        /// <returns>Task of TelefoneEstabelecimentoResponse</returns>
        public async System.Threading.Tasks.Task<TelefoneEstabelecimentoResponse> SalvarUsingPOST23Async (TelefoneEstabelecimentoPersist telefoneEstabelecimentoPersist)
        {
             ApiResponse<TelefoneEstabelecimentoResponse> localVarResponse = await SalvarUsingPOST23AsyncWithHttpInfo(telefoneEstabelecimentoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{telefone_estabelecimento_resource_salvar}}} {{{telefone_estabelecimento_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="telefoneEstabelecimentoPersist">telefoneEstabelecimentoPersist</param>
        /// <returns>Task of ApiResponse (TelefoneEstabelecimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TelefoneEstabelecimentoResponse>> SalvarUsingPOST23AsyncWithHttpInfo (TelefoneEstabelecimentoPersist telefoneEstabelecimentoPersist)
        {
            // verify the required parameter 'telefoneEstabelecimentoPersist' is set
            if (telefoneEstabelecimentoPersist == null) throw new ApiException(400, "Missing required parameter 'telefoneEstabelecimentoPersist' when calling SalvarUsingPOST23");
            
    
            var localVarPath = "/api/telefones-estabelecimentos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (telefoneEstabelecimentoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(telefoneEstabelecimentoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = telefoneEstabelecimentoPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST23: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST23: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TelefoneEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneEstabelecimentoResponse)));
            
        }
        
        /// <summary>
        /// {{{terminal_resource_salvar}}} {{{terminal_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminalPersist">terminalPersist</param> 
        /// <returns>TerminalResponse</returns>
        public TerminalResponse SalvarUsingPOST25 (TerminalPersist terminalPersist)
        {
             ApiResponse<TerminalResponse> localVarResponse = SalvarUsingPOST25WithHttpInfo(terminalPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{terminal_resource_salvar}}} {{{terminal_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminalPersist">terminalPersist</param> 
        /// <returns>ApiResponse of TerminalResponse</returns>
        public ApiResponse< TerminalResponse > SalvarUsingPOST25WithHttpInfo (TerminalPersist terminalPersist)
        {
            
            // verify the required parameter 'terminalPersist' is set
            if (terminalPersist == null)
                throw new ApiException(400, "Missing required parameter 'terminalPersist' when calling GlobaltagestabelecimentoApi->SalvarUsingPOST25");
            
    
            var localVarPath = "/api/terminais";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (terminalPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(terminalPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = terminalPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST25: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST25: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TerminalResponse)));
            
        }

        
        /// <summary>
        /// {{{terminal_resource_salvar}}} {{{terminal_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminalPersist">terminalPersist</param>
        /// <returns>Task of TerminalResponse</returns>
        public async System.Threading.Tasks.Task<TerminalResponse> SalvarUsingPOST25Async (TerminalPersist terminalPersist)
        {
             ApiResponse<TerminalResponse> localVarResponse = await SalvarUsingPOST25AsyncWithHttpInfo(terminalPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{terminal_resource_salvar}}} {{{terminal_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminalPersist">terminalPersist</param>
        /// <returns>Task of ApiResponse (TerminalResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TerminalResponse>> SalvarUsingPOST25AsyncWithHttpInfo (TerminalPersist terminalPersist)
        {
            // verify the required parameter 'terminalPersist' is set
            if (terminalPersist == null) throw new ApiException(400, "Missing required parameter 'terminalPersist' when calling SalvarUsingPOST25");
            
    
            var localVarPath = "/api/terminais";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (terminalPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(terminalPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = terminalPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST25: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST25: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TerminalResponse)));
            
        }
        
        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_salvar}}} {{{vinculo_estabelecimento_adquirente_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vinculoEstabelecimentoAdquirentePersist">vinculoEstabelecimentoAdquirentePersist</param> 
        /// <returns>VinculoEstabelecimentoAdquirenteResponse</returns>
        public VinculoEstabelecimentoAdquirenteResponse SalvarUsingPOST29 (VinculoEstabelecimentoAdquirentePersist vinculoEstabelecimentoAdquirentePersist)
        {
             ApiResponse<VinculoEstabelecimentoAdquirenteResponse> localVarResponse = SalvarUsingPOST29WithHttpInfo(vinculoEstabelecimentoAdquirentePersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_salvar}}} {{{vinculo_estabelecimento_adquirente_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vinculoEstabelecimentoAdquirentePersist">vinculoEstabelecimentoAdquirentePersist</param> 
        /// <returns>ApiResponse of VinculoEstabelecimentoAdquirenteResponse</returns>
        public ApiResponse< VinculoEstabelecimentoAdquirenteResponse > SalvarUsingPOST29WithHttpInfo (VinculoEstabelecimentoAdquirentePersist vinculoEstabelecimentoAdquirentePersist)
        {
            
            // verify the required parameter 'vinculoEstabelecimentoAdquirentePersist' is set
            if (vinculoEstabelecimentoAdquirentePersist == null)
                throw new ApiException(400, "Missing required parameter 'vinculoEstabelecimentoAdquirentePersist' when calling GlobaltagestabelecimentoApi->SalvarUsingPOST29");
            
    
            var localVarPath = "/api/adquirentes-estabelecimento";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (vinculoEstabelecimentoAdquirentePersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(vinculoEstabelecimentoAdquirentePersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = vinculoEstabelecimentoAdquirentePersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST29: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST29: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<VinculoEstabelecimentoAdquirenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VinculoEstabelecimentoAdquirenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VinculoEstabelecimentoAdquirenteResponse)));
            
        }

        
        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_salvar}}} {{{vinculo_estabelecimento_adquirente_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vinculoEstabelecimentoAdquirentePersist">vinculoEstabelecimentoAdquirentePersist</param>
        /// <returns>Task of VinculoEstabelecimentoAdquirenteResponse</returns>
        public async System.Threading.Tasks.Task<VinculoEstabelecimentoAdquirenteResponse> SalvarUsingPOST29Async (VinculoEstabelecimentoAdquirentePersist vinculoEstabelecimentoAdquirentePersist)
        {
             ApiResponse<VinculoEstabelecimentoAdquirenteResponse> localVarResponse = await SalvarUsingPOST29AsyncWithHttpInfo(vinculoEstabelecimentoAdquirentePersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{vinculo_estabelecimento_adquirente_resource_salvar}}} {{{vinculo_estabelecimento_adquirente_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vinculoEstabelecimentoAdquirentePersist">vinculoEstabelecimentoAdquirentePersist</param>
        /// <returns>Task of ApiResponse (VinculoEstabelecimentoAdquirenteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VinculoEstabelecimentoAdquirenteResponse>> SalvarUsingPOST29AsyncWithHttpInfo (VinculoEstabelecimentoAdquirentePersist vinculoEstabelecimentoAdquirentePersist)
        {
            // verify the required parameter 'vinculoEstabelecimentoAdquirentePersist' is set
            if (vinculoEstabelecimentoAdquirentePersist == null) throw new ApiException(400, "Missing required parameter 'vinculoEstabelecimentoAdquirentePersist' when calling SalvarUsingPOST29");
            
    
            var localVarPath = "/api/adquirentes-estabelecimento";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (vinculoEstabelecimentoAdquirentePersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(vinculoEstabelecimentoAdquirentePersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = vinculoEstabelecimentoAdquirentePersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST29: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST29: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VinculoEstabelecimentoAdquirenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VinculoEstabelecimentoAdquirenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VinculoEstabelecimentoAdquirenteResponse)));
            
        }
        
    }
    
}
