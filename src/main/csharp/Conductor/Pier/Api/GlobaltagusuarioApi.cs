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
    public interface IGlobaltagusuarioApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{usuario_resource_alterar_senha_login}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_alterar_senha_login_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">{{{usuario_resource_alterar_senha_login_param_login}}}</param>
        /// <param name="senhaNova">{{{usuario_resource_alterar_senha_login_param_senha_nova}}}</param>
        /// <returns>string</returns>
        string AlterarSenhaLoginUsingPOST (string login, string senhaNova);
  
        /// <summary>
        /// {{{usuario_resource_alterar_senha_login}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_alterar_senha_login_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">{{{usuario_resource_alterar_senha_login_param_login}}}</param>
        /// <param name="senhaNova">{{{usuario_resource_alterar_senha_login_param_senha_nova}}}</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> AlterarSenhaLoginUsingPOSTWithHttpInfo (string login, string senhaNova);
        
        /// <summary>
        /// {{{usuario_resource_alterar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_alterar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_alterar_senha_param_id}}}</param>
        /// <param name="senhaAtual">{{{usuario_resource_alterar_senha_param_senha_atual}}}</param>
        /// <param name="senhaNova">{{{usuario_resource_alterar_senha_param_senha_nova}}}</param>
        /// <returns>string</returns>
        string AlterarSenhaUsingPUT (long? id, string senhaAtual, string senhaNova);
  
        /// <summary>
        /// {{{usuario_resource_alterar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_alterar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_alterar_senha_param_id}}}</param>
        /// <param name="senhaAtual">{{{usuario_resource_alterar_senha_param_senha_atual}}}</param>
        /// <param name="senhaNova">{{{usuario_resource_alterar_senha_param_senha_nova}}}</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> AlterarSenhaUsingPUTWithHttpInfo (long? id, string senhaAtual, string senhaNova);
        
        /// <summary>
        /// {{{usuario_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_alterar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>UsuarioResponse</returns>
        UsuarioResponse AlterarUsingPUT23 (long? id, UsuarioUpdateValue update);
  
        /// <summary>
        /// {{{usuario_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_alterar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of UsuarioResponse</returns>
        ApiResponse<UsuarioResponse> AlterarUsingPUT23WithHttpInfo (long? id, UsuarioUpdateValue update);
        
        /// <summary>
        /// {{{usuario_resource_ativar_usuario}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_ativar_usuario_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_ativar_usuario_param_id}}}</param>
        /// <returns>UsuarioResponse</returns>
        UsuarioResponse AtivarUsuarioUsingPOST1 (long? id);
  
        /// <summary>
        /// {{{usuario_resource_ativar_usuario}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_ativar_usuario_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_ativar_usuario_param_id}}}</param>
        /// <returns>ApiResponse of UsuarioResponse</returns>
        ApiResponse<UsuarioResponse> AtivarUsuarioUsingPOST1WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{controle_seguranca_dispositivo_atualizar}}}
        /// </summary>
        /// <remarks>
        /// {{{controle_seguranca_dispositivo_atualizar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="update">update</param>
        /// <returns>ControleSegurancaDispositivoResponse</returns>
        ControleSegurancaDispositivoResponse AtualizarUsingPUT3 (ControleSegurancaDispositivoUpdateValor update);
  
        /// <summary>
        /// {{{controle_seguranca_dispositivo_atualizar}}}
        /// </summary>
        /// <remarks>
        /// {{{controle_seguranca_dispositivo_atualizar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of ControleSegurancaDispositivoResponse</returns>
        ApiResponse<ControleSegurancaDispositivoResponse> AtualizarUsingPUT3WithHttpInfo (ControleSegurancaDispositivoUpdateValor update);
        
        /// <summary>
        /// {{{usuario_recurso_listar_por_id_usuario}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_recurso_listar_por_id_usuario_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_recurso_listar_por_id_param_id_usuario}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>PageUsuarioContasResponse</returns>
        PageUsuarioContasResponse ConsultarContasVinculadasUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{usuario_recurso_listar_por_id_usuario}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_recurso_listar_por_id_usuario_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_recurso_listar_por_id_param_id_usuario}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of PageUsuarioContasResponse</returns>
        ApiResponse<PageUsuarioContasResponse> ConsultarContasVinculadasUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{controle_seguranca_dispositivo_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{controle_seguranca_dispositivo_consultar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idUsuario">{{{usuario_resource_consultar_param_idUsuario}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>PageControleSegurancaDispositivoResponse</returns>
        PageControleSegurancaDispositivoResponse ConsultarUsingGET17 (long? idUsuario, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{controle_seguranca_dispositivo_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{controle_seguranca_dispositivo_consultar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idUsuario">{{{usuario_resource_consultar_param_idUsuario}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of PageControleSegurancaDispositivoResponse</returns>
        ApiResponse<PageControleSegurancaDispositivoResponse> ConsultarUsingGET17WithHttpInfo (long? idUsuario, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{usuario_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_consultar_param_id}}}</param>
        /// <returns>UsuarioResponse</returns>
        UsuarioResponse ConsultarUsingGET53 (long? id);
  
        /// <summary>
        /// {{{usuario_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of UsuarioResponse</returns>
        ApiResponse<UsuarioResponse> ConsultarUsingGET53WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{usuario_resource_desativar_usuario}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_desativar_usuario_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_desativar_usuario_param_id}}}</param>
        /// <returns>UsuarioResponse</returns>
        UsuarioResponse DesativarUsuarioUsingPOST1 (long? id);
  
        /// <summary>
        /// {{{usuario_resource_desativar_usuario}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_desativar_usuario_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_desativar_usuario_param_id}}}</param>
        /// <returns>ApiResponse of UsuarioResponse</returns>
        ApiResponse<UsuarioResponse> DesativarUsuarioUsingPOST1WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{usuario_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{usuario_request_nome_value}}} (optional)</param>
        /// <param name="cpf">{{{usuario_request_cpf_value}}} (optional)</param>
        /// <param name="email">{{{usuario_request_email_value}}} (optional)</param>
        /// <param name="status">{{{usuario_request_status_value}}} (optional)</param>
        /// <returns>PageUsuarioResponse</returns>
        PageUsuarioResponse ListarUsingGET65 (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string cpf = null, string email = null, string status = null);
  
        /// <summary>
        /// {{{usuario_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{usuario_request_nome_value}}} (optional)</param>
        /// <param name="cpf">{{{usuario_request_cpf_value}}} (optional)</param>
        /// <param name="email">{{{usuario_request_email_value}}} (optional)</param>
        /// <param name="status">{{{usuario_request_status_value}}} (optional)</param>
        /// <returns>ApiResponse of PageUsuarioResponse</returns>
        ApiResponse<PageUsuarioResponse> ListarUsingGET65WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string cpf = null, string email = null, string status = null);
        
        /// <summary>
        /// {{{usuario_resource_recuperar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_recuperar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_recuperar_senha_param_id}}}</param>
        /// <returns>string</returns>
        string RecuperarSenhaUsingPOST (long? id);
  
        /// <summary>
        /// {{{usuario_resource_recuperar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_recuperar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_recuperar_senha_param_id}}}</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> RecuperarSenhaUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{controle_seguranca_dispositivo_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{controle_seguranca_dispositivo_salvar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ControleSegurancaDispositivoResponse</returns>
        ControleSegurancaDispositivoResponse SalvarUsingPOST10 (ControleSegurancaDispositivoPersistencia persist);
  
        /// <summary>
        /// {{{controle_seguranca_dispositivo_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{controle_seguranca_dispositivo_salvar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of ControleSegurancaDispositivoResponse</returns>
        ApiResponse<ControleSegurancaDispositivoResponse> SalvarUsingPOST10WithHttpInfo (ControleSegurancaDispositivoPersistencia persist);
        
        /// <summary>
        /// {{{usuario_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>UsuarioResponse</returns>
        UsuarioResponse SalvarUsingPOST34 (UsuarioPersistencia persist);
  
        /// <summary>
        /// {{{usuario_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of UsuarioResponse</returns>
        ApiResponse<UsuarioResponse> SalvarUsingPOST34WithHttpInfo (UsuarioPersistencia persist);
        
        /// <summary>
        /// {{{usuario_resource_validar_senha_forte}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_validar_senha_forte_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">{{{usuario_resource_validar_senha_forte_param_senha}}}</param>
        /// <param name="usuarioSenhaFortePersist">{{{usuario_resource_validar_senha_forte_param_id_plataforma}}}</param>
        /// <returns>string</returns>
        string ValidarSenhaForteUsingPOST (string senha, UsuarioSenhaFortePersistencia usuarioSenhaFortePersist);
  
        /// <summary>
        /// {{{usuario_resource_validar_senha_forte}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_validar_senha_forte_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">{{{usuario_resource_validar_senha_forte_param_senha}}}</param>
        /// <param name="usuarioSenhaFortePersist">{{{usuario_resource_validar_senha_forte_param_id_plataforma}}}</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ValidarSenhaForteUsingPOSTWithHttpInfo (string senha, UsuarioSenhaFortePersistencia usuarioSenhaFortePersist);
        
        /// <summary>
        /// {{{usuario_resource_validar_senha_login}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_validar_senha_login_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">{{{usuario_resource_validar_senha_login_param_login}}}</param>
        /// <param name="senha">{{{usuario_resource_validar_senha_login_param_senha}}}</param>
        /// <returns>Object</returns>
        Object ValidarSenhaLoginUsingPOST (string login, string senha);
  
        /// <summary>
        /// {{{usuario_resource_validar_senha_login}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_validar_senha_login_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">{{{usuario_resource_validar_senha_login_param_login}}}</param>
        /// <param name="senha">{{{usuario_resource_validar_senha_login_param_senha}}}</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ValidarSenhaLoginUsingPOSTWithHttpInfo (string login, string senha);
        
        /// <summary>
        /// {{{usuario_resource_validar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_validar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">{{{usuario_resource_validar_senha_param_senha}}}</param>
        /// <param name="id">{{{usuario_resource_validar_senha_param_id}}}</param>
        /// <returns>string</returns>
        string ValidarSenhaUsingGET1 (string senha, long? id);
  
        /// <summary>
        /// {{{usuario_resource_validar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_validar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">{{{usuario_resource_validar_senha_param_senha}}}</param>
        /// <param name="id">{{{usuario_resource_validar_senha_param_id}}}</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ValidarSenhaUsingGET1WithHttpInfo (string senha, long? id);
        
        /// <summary>
        /// {{{usuario_recurso_vincular_usuarios}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_recurso_vincular_usuarios_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_recurso_vincular_usuarios_param_id}}}</param>
        /// <returns>string</returns>
        string VincularContasUsingPOST (long? id);
  
        /// <summary>
        /// {{{usuario_recurso_vincular_usuarios}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_recurso_vincular_usuarios_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_recurso_vincular_usuarios_param_id}}}</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> VincularContasUsingPOSTWithHttpInfo (long? id);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{usuario_resource_alterar_senha_login}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_alterar_senha_login_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">{{{usuario_resource_alterar_senha_login_param_login}}}</param>
        /// <param name="senhaNova">{{{usuario_resource_alterar_senha_login_param_senha_nova}}}</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> AlterarSenhaLoginUsingPOSTAsync (string login, string senhaNova);

        /// <summary>
        /// {{{usuario_resource_alterar_senha_login}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_alterar_senha_login_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">{{{usuario_resource_alterar_senha_login_param_login}}}</param>
        /// <param name="senhaNova">{{{usuario_resource_alterar_senha_login_param_senha_nova}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> AlterarSenhaLoginUsingPOSTAsyncWithHttpInfo (string login, string senhaNova);
        
        /// <summary>
        /// {{{usuario_resource_alterar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_alterar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_alterar_senha_param_id}}}</param>
        /// <param name="senhaAtual">{{{usuario_resource_alterar_senha_param_senha_atual}}}</param>
        /// <param name="senhaNova">{{{usuario_resource_alterar_senha_param_senha_nova}}}</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> AlterarSenhaUsingPUTAsync (long? id, string senhaAtual, string senhaNova);

        /// <summary>
        /// {{{usuario_resource_alterar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_alterar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_alterar_senha_param_id}}}</param>
        /// <param name="senhaAtual">{{{usuario_resource_alterar_senha_param_senha_atual}}}</param>
        /// <param name="senhaNova">{{{usuario_resource_alterar_senha_param_senha_nova}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> AlterarSenhaUsingPUTAsyncWithHttpInfo (long? id, string senhaAtual, string senhaNova);
        
        /// <summary>
        /// {{{usuario_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_alterar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of UsuarioResponse</returns>
        System.Threading.Tasks.Task<UsuarioResponse> AlterarUsingPUT23Async (long? id, UsuarioUpdateValue update);

        /// <summary>
        /// {{{usuario_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_alterar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> AlterarUsingPUT23AsyncWithHttpInfo (long? id, UsuarioUpdateValue update);
        
        /// <summary>
        /// {{{usuario_resource_ativar_usuario}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_ativar_usuario_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_ativar_usuario_param_id}}}</param>
        /// <returns>Task of UsuarioResponse</returns>
        System.Threading.Tasks.Task<UsuarioResponse> AtivarUsuarioUsingPOST1Async (long? id);

        /// <summary>
        /// {{{usuario_resource_ativar_usuario}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_ativar_usuario_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_ativar_usuario_param_id}}}</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> AtivarUsuarioUsingPOST1AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{controle_seguranca_dispositivo_atualizar}}}
        /// </summary>
        /// <remarks>
        /// {{{controle_seguranca_dispositivo_atualizar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="update">update</param>
        /// <returns>Task of ControleSegurancaDispositivoResponse</returns>
        System.Threading.Tasks.Task<ControleSegurancaDispositivoResponse> AtualizarUsingPUT3Async (ControleSegurancaDispositivoUpdateValor update);

        /// <summary>
        /// {{{controle_seguranca_dispositivo_atualizar}}}
        /// </summary>
        /// <remarks>
        /// {{{controle_seguranca_dispositivo_atualizar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (ControleSegurancaDispositivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ControleSegurancaDispositivoResponse>> AtualizarUsingPUT3AsyncWithHttpInfo (ControleSegurancaDispositivoUpdateValor update);
        
        /// <summary>
        /// {{{usuario_recurso_listar_por_id_usuario}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_recurso_listar_por_id_usuario_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_recurso_listar_por_id_param_id_usuario}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageUsuarioContasResponse</returns>
        System.Threading.Tasks.Task<PageUsuarioContasResponse> ConsultarContasVinculadasUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{usuario_recurso_listar_por_id_usuario}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_recurso_listar_por_id_usuario_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_recurso_listar_por_id_param_id_usuario}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageUsuarioContasResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageUsuarioContasResponse>> ConsultarContasVinculadasUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{controle_seguranca_dispositivo_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{controle_seguranca_dispositivo_consultar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idUsuario">{{{usuario_resource_consultar_param_idUsuario}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageControleSegurancaDispositivoResponse</returns>
        System.Threading.Tasks.Task<PageControleSegurancaDispositivoResponse> ConsultarUsingGET17Async (long? idUsuario, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{controle_seguranca_dispositivo_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{controle_seguranca_dispositivo_consultar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idUsuario">{{{usuario_resource_consultar_param_idUsuario}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageControleSegurancaDispositivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageControleSegurancaDispositivoResponse>> ConsultarUsingGET17AsyncWithHttpInfo (long? idUsuario, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{usuario_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_consultar_param_id}}}</param>
        /// <returns>Task of UsuarioResponse</returns>
        System.Threading.Tasks.Task<UsuarioResponse> ConsultarUsingGET53Async (long? id);

        /// <summary>
        /// {{{usuario_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> ConsultarUsingGET53AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{usuario_resource_desativar_usuario}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_desativar_usuario_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_desativar_usuario_param_id}}}</param>
        /// <returns>Task of UsuarioResponse</returns>
        System.Threading.Tasks.Task<UsuarioResponse> DesativarUsuarioUsingPOST1Async (long? id);

        /// <summary>
        /// {{{usuario_resource_desativar_usuario}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_desativar_usuario_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_desativar_usuario_param_id}}}</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> DesativarUsuarioUsingPOST1AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{usuario_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{usuario_request_nome_value}}} (optional)</param>
        /// <param name="cpf">{{{usuario_request_cpf_value}}} (optional)</param>
        /// <param name="email">{{{usuario_request_email_value}}} (optional)</param>
        /// <param name="status">{{{usuario_request_status_value}}} (optional)</param>
        /// <returns>Task of PageUsuarioResponse</returns>
        System.Threading.Tasks.Task<PageUsuarioResponse> ListarUsingGET65Async (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string cpf = null, string email = null, string status = null);

        /// <summary>
        /// {{{usuario_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{usuario_request_nome_value}}} (optional)</param>
        /// <param name="cpf">{{{usuario_request_cpf_value}}} (optional)</param>
        /// <param name="email">{{{usuario_request_email_value}}} (optional)</param>
        /// <param name="status">{{{usuario_request_status_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageUsuarioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageUsuarioResponse>> ListarUsingGET65AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string cpf = null, string email = null, string status = null);
        
        /// <summary>
        /// {{{usuario_resource_recuperar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_recuperar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_recuperar_senha_param_id}}}</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> RecuperarSenhaUsingPOSTAsync (long? id);

        /// <summary>
        /// {{{usuario_resource_recuperar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_recuperar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_recuperar_senha_param_id}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> RecuperarSenhaUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{controle_seguranca_dispositivo_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{controle_seguranca_dispositivo_salvar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ControleSegurancaDispositivoResponse</returns>
        System.Threading.Tasks.Task<ControleSegurancaDispositivoResponse> SalvarUsingPOST10Async (ControleSegurancaDispositivoPersistencia persist);

        /// <summary>
        /// {{{controle_seguranca_dispositivo_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{controle_seguranca_dispositivo_salvar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (ControleSegurancaDispositivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ControleSegurancaDispositivoResponse>> SalvarUsingPOST10AsyncWithHttpInfo (ControleSegurancaDispositivoPersistencia persist);
        
        /// <summary>
        /// {{{usuario_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of UsuarioResponse</returns>
        System.Threading.Tasks.Task<UsuarioResponse> SalvarUsingPOST34Async (UsuarioPersistencia persist);

        /// <summary>
        /// {{{usuario_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> SalvarUsingPOST34AsyncWithHttpInfo (UsuarioPersistencia persist);
        
        /// <summary>
        /// {{{usuario_resource_validar_senha_forte}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_validar_senha_forte_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">{{{usuario_resource_validar_senha_forte_param_senha}}}</param>
        /// <param name="usuarioSenhaFortePersist">{{{usuario_resource_validar_senha_forte_param_id_plataforma}}}</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ValidarSenhaForteUsingPOSTAsync (string senha, UsuarioSenhaFortePersistencia usuarioSenhaFortePersist);

        /// <summary>
        /// {{{usuario_resource_validar_senha_forte}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_validar_senha_forte_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">{{{usuario_resource_validar_senha_forte_param_senha}}}</param>
        /// <param name="usuarioSenhaFortePersist">{{{usuario_resource_validar_senha_forte_param_id_plataforma}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ValidarSenhaForteUsingPOSTAsyncWithHttpInfo (string senha, UsuarioSenhaFortePersistencia usuarioSenhaFortePersist);
        
        /// <summary>
        /// {{{usuario_resource_validar_senha_login}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_validar_senha_login_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">{{{usuario_resource_validar_senha_login_param_login}}}</param>
        /// <param name="senha">{{{usuario_resource_validar_senha_login_param_senha}}}</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ValidarSenhaLoginUsingPOSTAsync (string login, string senha);

        /// <summary>
        /// {{{usuario_resource_validar_senha_login}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_validar_senha_login_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">{{{usuario_resource_validar_senha_login_param_login}}}</param>
        /// <param name="senha">{{{usuario_resource_validar_senha_login_param_senha}}}</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ValidarSenhaLoginUsingPOSTAsyncWithHttpInfo (string login, string senha);
        
        /// <summary>
        /// {{{usuario_resource_validar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_validar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">{{{usuario_resource_validar_senha_param_senha}}}</param>
        /// <param name="id">{{{usuario_resource_validar_senha_param_id}}}</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ValidarSenhaUsingGET1Async (string senha, long? id);

        /// <summary>
        /// {{{usuario_resource_validar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_validar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">{{{usuario_resource_validar_senha_param_senha}}}</param>
        /// <param name="id">{{{usuario_resource_validar_senha_param_id}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ValidarSenhaUsingGET1AsyncWithHttpInfo (string senha, long? id);
        
        /// <summary>
        /// {{{usuario_recurso_vincular_usuarios}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_recurso_vincular_usuarios_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_recurso_vincular_usuarios_param_id}}}</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> VincularContasUsingPOSTAsync (long? id);

        /// <summary>
        /// {{{usuario_recurso_vincular_usuarios}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_recurso_vincular_usuarios_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_recurso_vincular_usuarios_param_id}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> VincularContasUsingPOSTAsyncWithHttpInfo (long? id);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltagusuarioApi : IGlobaltagusuarioApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagusuarioApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltagusuarioApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagusuarioApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltagusuarioApi(Configuration configuration = null)
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
        /// {{{usuario_resource_alterar_senha_login}}} {{{usuario_resource_alterar_senha_login_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">{{{usuario_resource_alterar_senha_login_param_login}}}</param> 
        /// <param name="senhaNova">{{{usuario_resource_alterar_senha_login_param_senha_nova}}}</param> 
        /// <returns>string</returns>
        public string AlterarSenhaLoginUsingPOST (string login, string senhaNova)
        {
             ApiResponse<string> localVarResponse = AlterarSenhaLoginUsingPOSTWithHttpInfo(login, senhaNova);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{usuario_resource_alterar_senha_login}}} {{{usuario_resource_alterar_senha_login_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">{{{usuario_resource_alterar_senha_login_param_login}}}</param> 
        /// <param name="senhaNova">{{{usuario_resource_alterar_senha_login_param_senha_nova}}}</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > AlterarSenhaLoginUsingPOSTWithHttpInfo (string login, string senhaNova)
        {
            
            // verify the required parameter 'login' is set
            if (login == null)
                throw new ApiException(400, "Missing required parameter 'login' when calling GlobaltagusuarioApi->AlterarSenhaLoginUsingPOST");
            
            // verify the required parameter 'senhaNova' is set
            if (senhaNova == null)
                throw new ApiException(400, "Missing required parameter 'senhaNova' when calling GlobaltagusuarioApi->AlterarSenhaLoginUsingPOST");
            
    
            var localVarPath = "/api/usuarios/{login}/alterar-senha";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (login != null) localVarPathParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // path parameter
            
            
            if (senhaNova != null) localVarHeaderParams.Add("senhaNova", Configuration.ApiClient.ParameterToString(senhaNova)); // header parameter
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenhaLoginUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenhaLoginUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// {{{usuario_resource_alterar_senha_login}}} {{{usuario_resource_alterar_senha_login_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">{{{usuario_resource_alterar_senha_login_param_login}}}</param>
        /// <param name="senhaNova">{{{usuario_resource_alterar_senha_login_param_senha_nova}}}</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> AlterarSenhaLoginUsingPOSTAsync (string login, string senhaNova)
        {
             ApiResponse<string> localVarResponse = await AlterarSenhaLoginUsingPOSTAsyncWithHttpInfo(login, senhaNova);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{usuario_resource_alterar_senha_login}}} {{{usuario_resource_alterar_senha_login_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">{{{usuario_resource_alterar_senha_login_param_login}}}</param>
        /// <param name="senhaNova">{{{usuario_resource_alterar_senha_login_param_senha_nova}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> AlterarSenhaLoginUsingPOSTAsyncWithHttpInfo (string login, string senhaNova)
        {
            // verify the required parameter 'login' is set
            if (login == null) throw new ApiException(400, "Missing required parameter 'login' when calling AlterarSenhaLoginUsingPOST");
            // verify the required parameter 'senhaNova' is set
            if (senhaNova == null) throw new ApiException(400, "Missing required parameter 'senhaNova' when calling AlterarSenhaLoginUsingPOST");
            
    
            var localVarPath = "/api/usuarios/{login}/alterar-senha";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (login != null) localVarPathParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // path parameter
            
            
            if (senhaNova != null) localVarHeaderParams.Add("senhaNova", Configuration.ApiClient.ParameterToString(senhaNova)); // header parameter
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenhaLoginUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenhaLoginUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// {{{usuario_resource_alterar_senha}}} {{{usuario_resource_alterar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_alterar_senha_param_id}}}</param> 
        /// <param name="senhaAtual">{{{usuario_resource_alterar_senha_param_senha_atual}}}</param> 
        /// <param name="senhaNova">{{{usuario_resource_alterar_senha_param_senha_nova}}}</param> 
        /// <returns>string</returns>
        public string AlterarSenhaUsingPUT (long? id, string senhaAtual, string senhaNova)
        {
             ApiResponse<string> localVarResponse = AlterarSenhaUsingPUTWithHttpInfo(id, senhaAtual, senhaNova);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{usuario_resource_alterar_senha}}} {{{usuario_resource_alterar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_alterar_senha_param_id}}}</param> 
        /// <param name="senhaAtual">{{{usuario_resource_alterar_senha_param_senha_atual}}}</param> 
        /// <param name="senhaNova">{{{usuario_resource_alterar_senha_param_senha_nova}}}</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > AlterarSenhaUsingPUTWithHttpInfo (long? id, string senhaAtual, string senhaNova)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagusuarioApi->AlterarSenhaUsingPUT");
            
            // verify the required parameter 'senhaAtual' is set
            if (senhaAtual == null)
                throw new ApiException(400, "Missing required parameter 'senhaAtual' when calling GlobaltagusuarioApi->AlterarSenhaUsingPUT");
            
            // verify the required parameter 'senhaNova' is set
            if (senhaNova == null)
                throw new ApiException(400, "Missing required parameter 'senhaNova' when calling GlobaltagusuarioApi->AlterarSenhaUsingPUT");
            
    
            var localVarPath = "/api/usuarios/{id}/alterar-senha";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            if (senhaAtual != null) localVarHeaderParams.Add("senha_atual", Configuration.ApiClient.ParameterToString(senhaAtual)); // header parameter
            if (senhaNova != null) localVarHeaderParams.Add("senha_nova", Configuration.ApiClient.ParameterToString(senhaNova)); // header parameter
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenhaUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenhaUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// {{{usuario_resource_alterar_senha}}} {{{usuario_resource_alterar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_alterar_senha_param_id}}}</param>
        /// <param name="senhaAtual">{{{usuario_resource_alterar_senha_param_senha_atual}}}</param>
        /// <param name="senhaNova">{{{usuario_resource_alterar_senha_param_senha_nova}}}</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> AlterarSenhaUsingPUTAsync (long? id, string senhaAtual, string senhaNova)
        {
             ApiResponse<string> localVarResponse = await AlterarSenhaUsingPUTAsyncWithHttpInfo(id, senhaAtual, senhaNova);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{usuario_resource_alterar_senha}}} {{{usuario_resource_alterar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_alterar_senha_param_id}}}</param>
        /// <param name="senhaAtual">{{{usuario_resource_alterar_senha_param_senha_atual}}}</param>
        /// <param name="senhaNova">{{{usuario_resource_alterar_senha_param_senha_nova}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> AlterarSenhaUsingPUTAsyncWithHttpInfo (long? id, string senhaAtual, string senhaNova)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarSenhaUsingPUT");
            // verify the required parameter 'senhaAtual' is set
            if (senhaAtual == null) throw new ApiException(400, "Missing required parameter 'senhaAtual' when calling AlterarSenhaUsingPUT");
            // verify the required parameter 'senhaNova' is set
            if (senhaNova == null) throw new ApiException(400, "Missing required parameter 'senhaNova' when calling AlterarSenhaUsingPUT");
            
    
            var localVarPath = "/api/usuarios/{id}/alterar-senha";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            if (senhaAtual != null) localVarHeaderParams.Add("senha_atual", Configuration.ApiClient.ParameterToString(senhaAtual)); // header parameter
            if (senhaNova != null) localVarHeaderParams.Add("senha_nova", Configuration.ApiClient.ParameterToString(senhaNova)); // header parameter
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenhaUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenhaUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// {{{usuario_resource_alterar}}} {{{usuario_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_alterar_param_id}}}</param> 
        /// <param name="update">update</param> 
        /// <returns>UsuarioResponse</returns>
        public UsuarioResponse AlterarUsingPUT23 (long? id, UsuarioUpdateValue update)
        {
             ApiResponse<UsuarioResponse> localVarResponse = AlterarUsingPUT23WithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{usuario_resource_alterar}}} {{{usuario_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_alterar_param_id}}}</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of UsuarioResponse</returns>
        public ApiResponse< UsuarioResponse > AlterarUsingPUT23WithHttpInfo (long? id, UsuarioUpdateValue update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagusuarioApi->AlterarUsingPUT23");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling GlobaltagusuarioApi->AlterarUsingPUT23");
            
    
            var localVarPath = "/api/usuarios/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT23: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT23: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }

        
        /// <summary>
        /// {{{usuario_resource_alterar}}} {{{usuario_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_alterar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of UsuarioResponse</returns>
        public async System.Threading.Tasks.Task<UsuarioResponse> AlterarUsingPUT23Async (long? id, UsuarioUpdateValue update)
        {
             ApiResponse<UsuarioResponse> localVarResponse = await AlterarUsingPUT23AsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{usuario_resource_alterar}}} {{{usuario_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_alterar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> AlterarUsingPUT23AsyncWithHttpInfo (long? id, UsuarioUpdateValue update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT23");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AlterarUsingPUT23");
            
    
            var localVarPath = "/api/usuarios/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT23: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT23: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }
        
        /// <summary>
        /// {{{usuario_resource_ativar_usuario}}} {{{usuario_resource_ativar_usuario_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_ativar_usuario_param_id}}}</param> 
        /// <returns>UsuarioResponse</returns>
        public UsuarioResponse AtivarUsuarioUsingPOST1 (long? id)
        {
             ApiResponse<UsuarioResponse> localVarResponse = AtivarUsuarioUsingPOST1WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{usuario_resource_ativar_usuario}}} {{{usuario_resource_ativar_usuario_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_ativar_usuario_param_id}}}</param> 
        /// <returns>ApiResponse of UsuarioResponse</returns>
        public ApiResponse< UsuarioResponse > AtivarUsuarioUsingPOST1WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagusuarioApi->AtivarUsuarioUsingPOST1");
            
    
            var localVarPath = "/api/usuarios/{id}/ativar-usuario";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling AtivarUsuarioUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarUsuarioUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }

        
        /// <summary>
        /// {{{usuario_resource_ativar_usuario}}} {{{usuario_resource_ativar_usuario_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_ativar_usuario_param_id}}}</param>
        /// <returns>Task of UsuarioResponse</returns>
        public async System.Threading.Tasks.Task<UsuarioResponse> AtivarUsuarioUsingPOST1Async (long? id)
        {
             ApiResponse<UsuarioResponse> localVarResponse = await AtivarUsuarioUsingPOST1AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{usuario_resource_ativar_usuario}}} {{{usuario_resource_ativar_usuario_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_ativar_usuario_param_id}}}</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> AtivarUsuarioUsingPOST1AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtivarUsuarioUsingPOST1");
            
    
            var localVarPath = "/api/usuarios/{id}/ativar-usuario";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling AtivarUsuarioUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarUsuarioUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }
        
        /// <summary>
        /// {{{controle_seguranca_dispositivo_atualizar}}} {{{controle_seguranca_dispositivo_atualizar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="update">update</param> 
        /// <returns>ControleSegurancaDispositivoResponse</returns>
        public ControleSegurancaDispositivoResponse AtualizarUsingPUT3 (ControleSegurancaDispositivoUpdateValor update)
        {
             ApiResponse<ControleSegurancaDispositivoResponse> localVarResponse = AtualizarUsingPUT3WithHttpInfo(update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{controle_seguranca_dispositivo_atualizar}}} {{{controle_seguranca_dispositivo_atualizar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of ControleSegurancaDispositivoResponse</returns>
        public ApiResponse< ControleSegurancaDispositivoResponse > AtualizarUsingPUT3WithHttpInfo (ControleSegurancaDispositivoUpdateValor update)
        {
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling GlobaltagusuarioApi->AtualizarUsingPUT3");
            
    
            var localVarPath = "/api/controles-seguranca-dispositivos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ControleSegurancaDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleSegurancaDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleSegurancaDispositivoResponse)));
            
        }

        
        /// <summary>
        /// {{{controle_seguranca_dispositivo_atualizar}}} {{{controle_seguranca_dispositivo_atualizar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="update">update</param>
        /// <returns>Task of ControleSegurancaDispositivoResponse</returns>
        public async System.Threading.Tasks.Task<ControleSegurancaDispositivoResponse> AtualizarUsingPUT3Async (ControleSegurancaDispositivoUpdateValor update)
        {
             ApiResponse<ControleSegurancaDispositivoResponse> localVarResponse = await AtualizarUsingPUT3AsyncWithHttpInfo(update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{controle_seguranca_dispositivo_atualizar}}} {{{controle_seguranca_dispositivo_atualizar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (ControleSegurancaDispositivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ControleSegurancaDispositivoResponse>> AtualizarUsingPUT3AsyncWithHttpInfo (ControleSegurancaDispositivoUpdateValor update)
        {
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AtualizarUsingPUT3");
            
    
            var localVarPath = "/api/controles-seguranca-dispositivos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ControleSegurancaDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleSegurancaDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleSegurancaDispositivoResponse)));
            
        }
        
        /// <summary>
        /// {{{usuario_recurso_listar_por_id_usuario}}} {{{usuario_recurso_listar_por_id_usuario_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_recurso_listar_por_id_param_id_usuario}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>PageUsuarioContasResponse</returns>
        public PageUsuarioContasResponse ConsultarContasVinculadasUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageUsuarioContasResponse> localVarResponse = ConsultarContasVinculadasUsingGETWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{usuario_recurso_listar_por_id_usuario}}} {{{usuario_recurso_listar_por_id_usuario_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_recurso_listar_por_id_param_id_usuario}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>ApiResponse of PageUsuarioContasResponse</returns>
        public ApiResponse< PageUsuarioContasResponse > ConsultarContasVinculadasUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagusuarioApi->ConsultarContasVinculadasUsingGET");
            
    
            var localVarPath = "/api/usuarios/{id}/vincular-contas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarContasVinculadasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarContasVinculadasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageUsuarioContasResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageUsuarioContasResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageUsuarioContasResponse)));
            
        }

        
        /// <summary>
        /// {{{usuario_recurso_listar_por_id_usuario}}} {{{usuario_recurso_listar_por_id_usuario_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_recurso_listar_por_id_param_id_usuario}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageUsuarioContasResponse</returns>
        public async System.Threading.Tasks.Task<PageUsuarioContasResponse> ConsultarContasVinculadasUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageUsuarioContasResponse> localVarResponse = await ConsultarContasVinculadasUsingGETAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{usuario_recurso_listar_por_id_usuario}}} {{{usuario_recurso_listar_por_id_usuario_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_recurso_listar_por_id_param_id_usuario}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageUsuarioContasResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageUsuarioContasResponse>> ConsultarContasVinculadasUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarContasVinculadasUsingGET");
            
    
            var localVarPath = "/api/usuarios/{id}/vincular-contas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarContasVinculadasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarContasVinculadasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageUsuarioContasResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageUsuarioContasResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageUsuarioContasResponse)));
            
        }
        
        /// <summary>
        /// {{{controle_seguranca_dispositivo_consultar}}} {{{controle_seguranca_dispositivo_consultar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idUsuario">{{{usuario_resource_consultar_param_idUsuario}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>PageControleSegurancaDispositivoResponse</returns>
        public PageControleSegurancaDispositivoResponse ConsultarUsingGET17 (long? idUsuario, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageControleSegurancaDispositivoResponse> localVarResponse = ConsultarUsingGET17WithHttpInfo(idUsuario, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{controle_seguranca_dispositivo_consultar}}} {{{controle_seguranca_dispositivo_consultar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idUsuario">{{{usuario_resource_consultar_param_idUsuario}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>ApiResponse of PageControleSegurancaDispositivoResponse</returns>
        public ApiResponse< PageControleSegurancaDispositivoResponse > ConsultarUsingGET17WithHttpInfo (long? idUsuario, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'idUsuario' is set
            if (idUsuario == null)
                throw new ApiException(400, "Missing required parameter 'idUsuario' when calling GlobaltagusuarioApi->ConsultarUsingGET17");
            
    
            var localVarPath = "/api/controles-seguranca-dispositivos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (idUsuario != null) localVarQueryParams.Add("idUsuario", Configuration.ApiClient.ParameterToString(idUsuario)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET17: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET17: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageControleSegurancaDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageControleSegurancaDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageControleSegurancaDispositivoResponse)));
            
        }

        
        /// <summary>
        /// {{{controle_seguranca_dispositivo_consultar}}} {{{controle_seguranca_dispositivo_consultar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idUsuario">{{{usuario_resource_consultar_param_idUsuario}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageControleSegurancaDispositivoResponse</returns>
        public async System.Threading.Tasks.Task<PageControleSegurancaDispositivoResponse> ConsultarUsingGET17Async (long? idUsuario, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageControleSegurancaDispositivoResponse> localVarResponse = await ConsultarUsingGET17AsyncWithHttpInfo(idUsuario, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{controle_seguranca_dispositivo_consultar}}} {{{controle_seguranca_dispositivo_consultar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idUsuario">{{{usuario_resource_consultar_param_idUsuario}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageControleSegurancaDispositivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageControleSegurancaDispositivoResponse>> ConsultarUsingGET17AsyncWithHttpInfo (long? idUsuario, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'idUsuario' is set
            if (idUsuario == null) throw new ApiException(400, "Missing required parameter 'idUsuario' when calling ConsultarUsingGET17");
            
    
            var localVarPath = "/api/controles-seguranca-dispositivos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (idUsuario != null) localVarQueryParams.Add("idUsuario", Configuration.ApiClient.ParameterToString(idUsuario)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET17: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET17: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageControleSegurancaDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageControleSegurancaDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageControleSegurancaDispositivoResponse)));
            
        }
        
        /// <summary>
        /// {{{usuario_resource_consultar}}} {{{usuario_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_consultar_param_id}}}</param> 
        /// <returns>UsuarioResponse</returns>
        public UsuarioResponse ConsultarUsingGET53 (long? id)
        {
             ApiResponse<UsuarioResponse> localVarResponse = ConsultarUsingGET53WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{usuario_resource_consultar}}} {{{usuario_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of UsuarioResponse</returns>
        public ApiResponse< UsuarioResponse > ConsultarUsingGET53WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagusuarioApi->ConsultarUsingGET53");
            
    
            var localVarPath = "/api/usuarios/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET53: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET53: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }

        
        /// <summary>
        /// {{{usuario_resource_consultar}}} {{{usuario_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_consultar_param_id}}}</param>
        /// <returns>Task of UsuarioResponse</returns>
        public async System.Threading.Tasks.Task<UsuarioResponse> ConsultarUsingGET53Async (long? id)
        {
             ApiResponse<UsuarioResponse> localVarResponse = await ConsultarUsingGET53AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{usuario_resource_consultar}}} {{{usuario_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> ConsultarUsingGET53AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET53");
            
    
            var localVarPath = "/api/usuarios/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET53: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET53: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }
        
        /// <summary>
        /// {{{usuario_resource_desativar_usuario}}} {{{usuario_resource_desativar_usuario_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_desativar_usuario_param_id}}}</param> 
        /// <returns>UsuarioResponse</returns>
        public UsuarioResponse DesativarUsuarioUsingPOST1 (long? id)
        {
             ApiResponse<UsuarioResponse> localVarResponse = DesativarUsuarioUsingPOST1WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{usuario_resource_desativar_usuario}}} {{{usuario_resource_desativar_usuario_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_desativar_usuario_param_id}}}</param> 
        /// <returns>ApiResponse of UsuarioResponse</returns>
        public ApiResponse< UsuarioResponse > DesativarUsuarioUsingPOST1WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagusuarioApi->DesativarUsuarioUsingPOST1");
            
    
            var localVarPath = "/api/usuarios/{id}/desativar-usuario";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling DesativarUsuarioUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarUsuarioUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }

        
        /// <summary>
        /// {{{usuario_resource_desativar_usuario}}} {{{usuario_resource_desativar_usuario_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_desativar_usuario_param_id}}}</param>
        /// <returns>Task of UsuarioResponse</returns>
        public async System.Threading.Tasks.Task<UsuarioResponse> DesativarUsuarioUsingPOST1Async (long? id)
        {
             ApiResponse<UsuarioResponse> localVarResponse = await DesativarUsuarioUsingPOST1AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{usuario_resource_desativar_usuario}}} {{{usuario_resource_desativar_usuario_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_desativar_usuario_param_id}}}</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> DesativarUsuarioUsingPOST1AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesativarUsuarioUsingPOST1");
            
    
            var localVarPath = "/api/usuarios/{id}/desativar-usuario";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling DesativarUsuarioUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarUsuarioUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }
        
        /// <summary>
        /// {{{usuario_resource_listar}}} {{{usuario_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="nome">{{{usuario_request_nome_value}}} (optional)</param> 
        /// <param name="cpf">{{{usuario_request_cpf_value}}} (optional)</param> 
        /// <param name="email">{{{usuario_request_email_value}}} (optional)</param> 
        /// <param name="status">{{{usuario_request_status_value}}} (optional)</param> 
        /// <returns>PageUsuarioResponse</returns>
        public PageUsuarioResponse ListarUsingGET65 (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string cpf = null, string email = null, string status = null)
        {
             ApiResponse<PageUsuarioResponse> localVarResponse = ListarUsingGET65WithHttpInfo(sort, page, limit, nome, cpf, email, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{usuario_resource_listar}}} {{{usuario_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="nome">{{{usuario_request_nome_value}}} (optional)</param> 
        /// <param name="cpf">{{{usuario_request_cpf_value}}} (optional)</param> 
        /// <param name="email">{{{usuario_request_email_value}}} (optional)</param> 
        /// <param name="status">{{{usuario_request_status_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageUsuarioResponse</returns>
        public ApiResponse< PageUsuarioResponse > ListarUsingGET65WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string cpf = null, string email = null, string status = null)
        {
            
    
            var localVarPath = "/api/usuarios";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET65: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET65: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageUsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageUsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageUsuarioResponse)));
            
        }

        
        /// <summary>
        /// {{{usuario_resource_listar}}} {{{usuario_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{usuario_request_nome_value}}} (optional)</param>
        /// <param name="cpf">{{{usuario_request_cpf_value}}} (optional)</param>
        /// <param name="email">{{{usuario_request_email_value}}} (optional)</param>
        /// <param name="status">{{{usuario_request_status_value}}} (optional)</param>
        /// <returns>Task of PageUsuarioResponse</returns>
        public async System.Threading.Tasks.Task<PageUsuarioResponse> ListarUsingGET65Async (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string cpf = null, string email = null, string status = null)
        {
             ApiResponse<PageUsuarioResponse> localVarResponse = await ListarUsingGET65AsyncWithHttpInfo(sort, page, limit, nome, cpf, email, status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{usuario_resource_listar}}} {{{usuario_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{usuario_request_nome_value}}} (optional)</param>
        /// <param name="cpf">{{{usuario_request_cpf_value}}} (optional)</param>
        /// <param name="email">{{{usuario_request_email_value}}} (optional)</param>
        /// <param name="status">{{{usuario_request_status_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageUsuarioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageUsuarioResponse>> ListarUsingGET65AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string cpf = null, string email = null, string status = null)
        {
            
    
            var localVarPath = "/api/usuarios";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET65: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET65: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageUsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageUsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageUsuarioResponse)));
            
        }
        
        /// <summary>
        /// {{{usuario_resource_recuperar_senha}}} {{{usuario_resource_recuperar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_recuperar_senha_param_id}}}</param> 
        /// <returns>string</returns>
        public string RecuperarSenhaUsingPOST (long? id)
        {
             ApiResponse<string> localVarResponse = RecuperarSenhaUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{usuario_resource_recuperar_senha}}} {{{usuario_resource_recuperar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_recuperar_senha_param_id}}}</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > RecuperarSenhaUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagusuarioApi->RecuperarSenhaUsingPOST");
            
    
            var localVarPath = "/api/usuarios/{id}/recuperar-senha";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling RecuperarSenhaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RecuperarSenhaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// {{{usuario_resource_recuperar_senha}}} {{{usuario_resource_recuperar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_recuperar_senha_param_id}}}</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> RecuperarSenhaUsingPOSTAsync (long? id)
        {
             ApiResponse<string> localVarResponse = await RecuperarSenhaUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{usuario_resource_recuperar_senha}}} {{{usuario_resource_recuperar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_recuperar_senha_param_id}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> RecuperarSenhaUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RecuperarSenhaUsingPOST");
            
    
            var localVarPath = "/api/usuarios/{id}/recuperar-senha";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling RecuperarSenhaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RecuperarSenhaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// {{{controle_seguranca_dispositivo_salvar}}} {{{controle_seguranca_dispositivo_salvar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ControleSegurancaDispositivoResponse</returns>
        public ControleSegurancaDispositivoResponse SalvarUsingPOST10 (ControleSegurancaDispositivoPersistencia persist)
        {
             ApiResponse<ControleSegurancaDispositivoResponse> localVarResponse = SalvarUsingPOST10WithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{controle_seguranca_dispositivo_salvar}}} {{{controle_seguranca_dispositivo_salvar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of ControleSegurancaDispositivoResponse</returns>
        public ApiResponse< ControleSegurancaDispositivoResponse > SalvarUsingPOST10WithHttpInfo (ControleSegurancaDispositivoPersistencia persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling GlobaltagusuarioApi->SalvarUsingPOST10");
            
    
            var localVarPath = "/api/controles-seguranca-dispositivos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST10: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST10: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ControleSegurancaDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleSegurancaDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleSegurancaDispositivoResponse)));
            
        }

        
        /// <summary>
        /// {{{controle_seguranca_dispositivo_salvar}}} {{{controle_seguranca_dispositivo_salvar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ControleSegurancaDispositivoResponse</returns>
        public async System.Threading.Tasks.Task<ControleSegurancaDispositivoResponse> SalvarUsingPOST10Async (ControleSegurancaDispositivoPersistencia persist)
        {
             ApiResponse<ControleSegurancaDispositivoResponse> localVarResponse = await SalvarUsingPOST10AsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{controle_seguranca_dispositivo_salvar}}} {{{controle_seguranca_dispositivo_salvar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (ControleSegurancaDispositivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ControleSegurancaDispositivoResponse>> SalvarUsingPOST10AsyncWithHttpInfo (ControleSegurancaDispositivoPersistencia persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarUsingPOST10");
            
    
            var localVarPath = "/api/controles-seguranca-dispositivos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST10: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST10: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ControleSegurancaDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleSegurancaDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleSegurancaDispositivoResponse)));
            
        }
        
        /// <summary>
        /// {{{usuario_resource_salvar}}} {{{usuario_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>UsuarioResponse</returns>
        public UsuarioResponse SalvarUsingPOST34 (UsuarioPersistencia persist)
        {
             ApiResponse<UsuarioResponse> localVarResponse = SalvarUsingPOST34WithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{usuario_resource_salvar}}} {{{usuario_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of UsuarioResponse</returns>
        public ApiResponse< UsuarioResponse > SalvarUsingPOST34WithHttpInfo (UsuarioPersistencia persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling GlobaltagusuarioApi->SalvarUsingPOST34");
            
    
            var localVarPath = "/api/usuarios";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST34: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST34: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }

        
        /// <summary>
        /// {{{usuario_resource_salvar}}} {{{usuario_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of UsuarioResponse</returns>
        public async System.Threading.Tasks.Task<UsuarioResponse> SalvarUsingPOST34Async (UsuarioPersistencia persist)
        {
             ApiResponse<UsuarioResponse> localVarResponse = await SalvarUsingPOST34AsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{usuario_resource_salvar}}} {{{usuario_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> SalvarUsingPOST34AsyncWithHttpInfo (UsuarioPersistencia persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarUsingPOST34");
            
    
            var localVarPath = "/api/usuarios";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST34: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST34: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }
        
        /// <summary>
        /// {{{usuario_resource_validar_senha_forte}}} {{{usuario_resource_validar_senha_forte_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">{{{usuario_resource_validar_senha_forte_param_senha}}}</param> 
        /// <param name="usuarioSenhaFortePersist">{{{usuario_resource_validar_senha_forte_param_id_plataforma}}}</param> 
        /// <returns>string</returns>
        public string ValidarSenhaForteUsingPOST (string senha, UsuarioSenhaFortePersistencia usuarioSenhaFortePersist)
        {
             ApiResponse<string> localVarResponse = ValidarSenhaForteUsingPOSTWithHttpInfo(senha, usuarioSenhaFortePersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{usuario_resource_validar_senha_forte}}} {{{usuario_resource_validar_senha_forte_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">{{{usuario_resource_validar_senha_forte_param_senha}}}</param> 
        /// <param name="usuarioSenhaFortePersist">{{{usuario_resource_validar_senha_forte_param_id_plataforma}}}</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ValidarSenhaForteUsingPOSTWithHttpInfo (string senha, UsuarioSenhaFortePersistencia usuarioSenhaFortePersist)
        {
            
            // verify the required parameter 'senha' is set
            if (senha == null)
                throw new ApiException(400, "Missing required parameter 'senha' when calling GlobaltagusuarioApi->ValidarSenhaForteUsingPOST");
            
            // verify the required parameter 'usuarioSenhaFortePersist' is set
            if (usuarioSenhaFortePersist == null)
                throw new ApiException(400, "Missing required parameter 'usuarioSenhaFortePersist' when calling GlobaltagusuarioApi->ValidarSenhaForteUsingPOST");
            
    
            var localVarPath = "/api/usuarios/validar-senha-forte";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            if (senha != null) localVarHeaderParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // header parameter
            
            
            if (usuarioSenhaFortePersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(usuarioSenhaFortePersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = usuarioSenhaFortePersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaForteUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaForteUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// {{{usuario_resource_validar_senha_forte}}} {{{usuario_resource_validar_senha_forte_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">{{{usuario_resource_validar_senha_forte_param_senha}}}</param>
        /// <param name="usuarioSenhaFortePersist">{{{usuario_resource_validar_senha_forte_param_id_plataforma}}}</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ValidarSenhaForteUsingPOSTAsync (string senha, UsuarioSenhaFortePersistencia usuarioSenhaFortePersist)
        {
             ApiResponse<string> localVarResponse = await ValidarSenhaForteUsingPOSTAsyncWithHttpInfo(senha, usuarioSenhaFortePersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{usuario_resource_validar_senha_forte}}} {{{usuario_resource_validar_senha_forte_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">{{{usuario_resource_validar_senha_forte_param_senha}}}</param>
        /// <param name="usuarioSenhaFortePersist">{{{usuario_resource_validar_senha_forte_param_id_plataforma}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ValidarSenhaForteUsingPOSTAsyncWithHttpInfo (string senha, UsuarioSenhaFortePersistencia usuarioSenhaFortePersist)
        {
            // verify the required parameter 'senha' is set
            if (senha == null) throw new ApiException(400, "Missing required parameter 'senha' when calling ValidarSenhaForteUsingPOST");
            // verify the required parameter 'usuarioSenhaFortePersist' is set
            if (usuarioSenhaFortePersist == null) throw new ApiException(400, "Missing required parameter 'usuarioSenhaFortePersist' when calling ValidarSenhaForteUsingPOST");
            
    
            var localVarPath = "/api/usuarios/validar-senha-forte";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            if (senha != null) localVarHeaderParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // header parameter
            
            
            if (usuarioSenhaFortePersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(usuarioSenhaFortePersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = usuarioSenhaFortePersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaForteUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaForteUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// {{{usuario_resource_validar_senha_login}}} {{{usuario_resource_validar_senha_login_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">{{{usuario_resource_validar_senha_login_param_login}}}</param> 
        /// <param name="senha">{{{usuario_resource_validar_senha_login_param_senha}}}</param> 
        /// <returns>Object</returns>
        public Object ValidarSenhaLoginUsingPOST (string login, string senha)
        {
             ApiResponse<Object> localVarResponse = ValidarSenhaLoginUsingPOSTWithHttpInfo(login, senha);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{usuario_resource_validar_senha_login}}} {{{usuario_resource_validar_senha_login_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">{{{usuario_resource_validar_senha_login_param_login}}}</param> 
        /// <param name="senha">{{{usuario_resource_validar_senha_login_param_senha}}}</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > ValidarSenhaLoginUsingPOSTWithHttpInfo (string login, string senha)
        {
            
            // verify the required parameter 'login' is set
            if (login == null)
                throw new ApiException(400, "Missing required parameter 'login' when calling GlobaltagusuarioApi->ValidarSenhaLoginUsingPOST");
            
            // verify the required parameter 'senha' is set
            if (senha == null)
                throw new ApiException(400, "Missing required parameter 'senha' when calling GlobaltagusuarioApi->ValidarSenhaLoginUsingPOST");
            
    
            var localVarPath = "/api/usuarios/{login}/validar-senha";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (login != null) localVarPathParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // path parameter
            
            
            if (senha != null) localVarHeaderParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // header parameter
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaLoginUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaLoginUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// {{{usuario_resource_validar_senha_login}}} {{{usuario_resource_validar_senha_login_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">{{{usuario_resource_validar_senha_login_param_login}}}</param>
        /// <param name="senha">{{{usuario_resource_validar_senha_login_param_senha}}}</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ValidarSenhaLoginUsingPOSTAsync (string login, string senha)
        {
             ApiResponse<Object> localVarResponse = await ValidarSenhaLoginUsingPOSTAsyncWithHttpInfo(login, senha);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{usuario_resource_validar_senha_login}}} {{{usuario_resource_validar_senha_login_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">{{{usuario_resource_validar_senha_login_param_login}}}</param>
        /// <param name="senha">{{{usuario_resource_validar_senha_login_param_senha}}}</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ValidarSenhaLoginUsingPOSTAsyncWithHttpInfo (string login, string senha)
        {
            // verify the required parameter 'login' is set
            if (login == null) throw new ApiException(400, "Missing required parameter 'login' when calling ValidarSenhaLoginUsingPOST");
            // verify the required parameter 'senha' is set
            if (senha == null) throw new ApiException(400, "Missing required parameter 'senha' when calling ValidarSenhaLoginUsingPOST");
            
    
            var localVarPath = "/api/usuarios/{login}/validar-senha";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (login != null) localVarPathParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // path parameter
            
            
            if (senha != null) localVarHeaderParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // header parameter
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaLoginUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaLoginUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// {{{usuario_resource_validar_senha}}} {{{usuario_resource_validar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">{{{usuario_resource_validar_senha_param_senha}}}</param> 
        /// <param name="id">{{{usuario_resource_validar_senha_param_id}}}</param> 
        /// <returns>string</returns>
        public string ValidarSenhaUsingGET1 (string senha, long? id)
        {
             ApiResponse<string> localVarResponse = ValidarSenhaUsingGET1WithHttpInfo(senha, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{usuario_resource_validar_senha}}} {{{usuario_resource_validar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">{{{usuario_resource_validar_senha_param_senha}}}</param> 
        /// <param name="id">{{{usuario_resource_validar_senha_param_id}}}</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ValidarSenhaUsingGET1WithHttpInfo (string senha, long? id)
        {
            
            // verify the required parameter 'senha' is set
            if (senha == null)
                throw new ApiException(400, "Missing required parameter 'senha' when calling GlobaltagusuarioApi->ValidarSenhaUsingGET1");
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagusuarioApi->ValidarSenhaUsingGET1");
            
    
            var localVarPath = "/api/usuarios/{id}/validar-senha";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaUsingGET1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaUsingGET1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// {{{usuario_resource_validar_senha}}} {{{usuario_resource_validar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">{{{usuario_resource_validar_senha_param_senha}}}</param>
        /// <param name="id">{{{usuario_resource_validar_senha_param_id}}}</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ValidarSenhaUsingGET1Async (string senha, long? id)
        {
             ApiResponse<string> localVarResponse = await ValidarSenhaUsingGET1AsyncWithHttpInfo(senha, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{usuario_resource_validar_senha}}} {{{usuario_resource_validar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">{{{usuario_resource_validar_senha_param_senha}}}</param>
        /// <param name="id">{{{usuario_resource_validar_senha_param_id}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ValidarSenhaUsingGET1AsyncWithHttpInfo (string senha, long? id)
        {
            // verify the required parameter 'senha' is set
            if (senha == null) throw new ApiException(400, "Missing required parameter 'senha' when calling ValidarSenhaUsingGET1");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ValidarSenhaUsingGET1");
            
    
            var localVarPath = "/api/usuarios/{id}/validar-senha";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaUsingGET1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaUsingGET1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// {{{usuario_recurso_vincular_usuarios}}} {{{usuario_recurso_vincular_usuarios_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_recurso_vincular_usuarios_param_id}}}</param> 
        /// <returns>string</returns>
        public string VincularContasUsingPOST (long? id)
        {
             ApiResponse<string> localVarResponse = VincularContasUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{usuario_recurso_vincular_usuarios}}} {{{usuario_recurso_vincular_usuarios_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_recurso_vincular_usuarios_param_id}}}</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > VincularContasUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagusuarioApi->VincularContasUsingPOST");
            
    
            var localVarPath = "/api/usuarios/{id}/vincular-usuarios";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling VincularContasUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VincularContasUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// {{{usuario_recurso_vincular_usuarios}}} {{{usuario_recurso_vincular_usuarios_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_recurso_vincular_usuarios_param_id}}}</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> VincularContasUsingPOSTAsync (long? id)
        {
             ApiResponse<string> localVarResponse = await VincularContasUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{usuario_recurso_vincular_usuarios}}} {{{usuario_recurso_vincular_usuarios_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_recurso_vincular_usuarios_param_id}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> VincularContasUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VincularContasUsingPOST");
            
    
            var localVarPath = "/api/usuarios/{id}/vincular-usuarios";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling VincularContasUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VincularContasUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
    }
    
}
