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
    public interface IUserApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Update the users registered in the base
        /// </summary>
        /// <remarks>
        /// This method update the users
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the User (id)</param>
        /// <param name="update">update</param>
        /// <returns>UsuarioResponse</returns>
        UsuarioResponse Alterar (long? id, UserUpdate update);
  
        /// <summary>
        /// Update the users registered in the base
        /// </summary>
        /// <remarks>
        /// This method update the users
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the User (id)</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of UsuarioResponse</returns>
        ApiResponse<UsuarioResponse> AlterarWithHttpInfo (long? id, UserUpdate update);
        
        /// <summary>
        /// Update the user&#39;s password in the vase of the PIER or WS
        /// </summary>
        /// <remarks>
        /// This method allows to update the user&#39;s password
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the User (id)</param>
        /// <param name="senhaAtual">Current Password</param>
        /// <param name="senhaNova">New Password</param>
        /// <returns>string</returns>
        string AlterarSenha (long? id, string senhaAtual, string senhaNova);
  
        /// <summary>
        /// Update the user&#39;s password in the vase of the PIER or WS
        /// </summary>
        /// <remarks>
        /// This method allows to update the user&#39;s password
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the User (id)</param>
        /// <param name="senhaAtual">Current Password</param>
        /// <param name="senhaNova">New Password</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> AlterarSenhaWithHttpInfo (long? id, string senhaAtual, string senhaNova);
        
        /// <summary>
        /// Update the password of the user
        /// </summary>
        /// <remarks>
        /// This method updates the password of the user
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">Login of the user</param>
        /// <param name="senhaNova">New password</param>
        /// <returns>string</returns>
        string AlterarSenhaLogin (string login, string senhaNova);
  
        /// <summary>
        /// Update the password of the user
        /// </summary>
        /// <remarks>
        /// This method updates the password of the user
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">Login of the user</param>
        /// <param name="senhaNova">New password</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> AlterarSenhaLoginWithHttpInfo (string login, string senhaNova);
        
        /// <summary>
        /// Activate the users registered in the base of the PIER or WS
        /// </summary>
        /// <remarks>
        /// this method activate the users
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the user (id)</param>
        /// <returns>UsuarioResponse</returns>
        UsuarioResponse AtivarUsuario (long? id);
  
        /// <summary>
        /// Activate the users registered in the base of the PIER or WS
        /// </summary>
        /// <remarks>
        /// this method activate the users
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the user (id)</param>
        /// <returns>ApiResponse of UsuarioResponse</returns>
        ApiResponse<UsuarioResponse> AtivarUsuarioWithHttpInfo (long? id);
        
        /// <summary>
        /// Updates user device
        /// </summary>
        /// <remarks>
        /// This feature allows you to update the user&#39;s device
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Access control identifier</param>
        /// <param name="update">update</param>
        /// <returns>ControleSegurancaDispositivoResponse</returns>
        ControleSegurancaDispositivoResponse Atualizar (long? id, UsuarioDispositivoUpdate update);
  
        /// <summary>
        /// Updates user device
        /// </summary>
        /// <remarks>
        /// This feature allows you to update the user&#39;s device
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Access control identifier</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of ControleSegurancaDispositivoResponse</returns>
        ApiResponse<ControleSegurancaDispositivoResponse> AtualizarWithHttpInfo (long? id, UsuarioDispositivoUpdate update);
        
        /// <summary>
        /// User device query
        /// </summary>
        /// <remarks>
        /// This method allows you to query the user device
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idUsuario">User Id</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>PageControleSegurancaDispositivoResponse</returns>
        PageControleSegurancaDispositivoResponse Consultar (long? idUsuario, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// User device query
        /// </summary>
        /// <remarks>
        /// This method allows you to query the user device
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idUsuario">User Id</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageControleSegurancaDispositivoResponse</returns>
        ApiResponse<PageControleSegurancaDispositivoResponse> ConsultarWithHttpInfo (long? idUsuario, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lists accounts linked to the user
        /// </summary>
        /// <remarks>
        /// This feature allows you to list the accounts linked to the user by ID
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">User Id</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>PageUsuarioContasResponse</returns>
        PageUsuarioContasResponse ConsultarContasVinculadas (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lists accounts linked to the user
        /// </summary>
        /// <remarks>
        /// This feature allows you to list the accounts linked to the user by ID
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">User Id</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageUsuarioContasResponse</returns>
        ApiResponse<PageUsuarioContasResponse> ConsultarContasVinculadasWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// List the dates of a determined user in the base of PIER or WS
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve the information of a determined user using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the user (id)</param>
        /// <returns>UsuarioResponse</returns>
        UsuarioResponse Consultar_0 (long? id);
  
        /// <summary>
        /// List the dates of a determined user in the base of PIER or WS
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve the information of a determined user using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the user (id)</param>
        /// <returns>ApiResponse of UsuarioResponse</returns>
        ApiResponse<UsuarioResponse> Consultar_0WithHttpInfo (long? id);
        
        /// <summary>
        /// Removes the user&#39;s device
        /// </summary>
        /// <remarks>
        /// This feature allows you to remove the user&#39;s device
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Access control identifier</param>
        /// <returns>ControleSegurancaDispositivoResponse</returns>
        ControleSegurancaDispositivoResponse Deletar (long? id);
  
        /// <summary>
        /// Removes the user&#39;s device
        /// </summary>
        /// <remarks>
        /// This feature allows you to remove the user&#39;s device
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Access control identifier</param>
        /// <returns>ApiResponse of ControleSegurancaDispositivoResponse</returns>
        ApiResponse<ControleSegurancaDispositivoResponse> DeletarWithHttpInfo (long? id);
        
        /// <summary>
        /// Disable the user registered in the base of the PIER or WS
        /// </summary>
        /// <remarks>
        /// This method disables the users
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the User (id)</param>
        /// <returns>UsuarioResponse</returns>
        UsuarioResponse DesativarUsuario (long? id);
  
        /// <summary>
        /// Disable the user registered in the base of the PIER or WS
        /// </summary>
        /// <remarks>
        /// This method disables the users
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the User (id)</param>
        /// <returns>ApiResponse of UsuarioResponse</returns>
        ApiResponse<UsuarioResponse> DesativarUsuarioWithHttpInfo (long? id);
        
        /// <summary>
        /// List the users registered in the base of the PIER or WS
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the existing users in the base of the PIER
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Name of the user (optional)</param>
        /// <param name="cpf">User CPF (optional)</param>
        /// <param name="email">Email of the user (optional)</param>
        /// <param name="status">Status of the user (optional)</param>
        /// <returns>PageUsuarioResponse</returns>
        PageUsuarioResponse Listar (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string cpf = null, string email = null, string status = null);
  
        /// <summary>
        /// List the users registered in the base of the PIER or WS
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the existing users in the base of the PIER
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Name of the user (optional)</param>
        /// <param name="cpf">User CPF (optional)</param>
        /// <param name="email">Email of the user (optional)</param>
        /// <param name="status">Status of the user (optional)</param>
        /// <returns>ApiResponse of PageUsuarioResponse</returns>
        ApiResponse<PageUsuarioResponse> ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string cpf = null, string email = null, string status = null);
        
        /// <summary>
        /// Retrieve the user&#39;s password in the base or WS
        /// </summary>
        /// <remarks>
        /// This resource allows to retrieve the user&#39;s password
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the user (id)</param>
        /// <returns>string</returns>
        string RecuperarSenha (long? id);
  
        /// <summary>
        /// Retrieve the user&#39;s password in the base or WS
        /// </summary>
        /// <remarks>
        /// This resource allows to retrieve the user&#39;s password
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the user (id)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> RecuperarSenhaWithHttpInfo (long? id);
        
        /// <summary>
        /// Register user&#39;s device
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar o dispositivo do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ControleSegurancaDispositivoResponse</returns>
        ControleSegurancaDispositivoResponse Salvar (UsuarioDispositivoPersist persist);
  
        /// <summary>
        /// Register user&#39;s device
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar o dispositivo do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of ControleSegurancaDispositivoResponse</returns>
        ApiResponse<ControleSegurancaDispositivoResponse> SalvarWithHttpInfo (UsuarioDispositivoPersist persist);
        
        /// <summary>
        /// Create user in the base
        /// </summary>
        /// <remarks>
        /// This resource allows to create users
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>UsuarioResponse</returns>
        UsuarioResponse Salvar_0 (UsuarioPersist persist);
  
        /// <summary>
        /// Create user in the base
        /// </summary>
        /// <remarks>
        /// This resource allows to create users
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of UsuarioResponse</returns>
        ApiResponse<UsuarioResponse> Salvar_0WithHttpInfo (UsuarioPersist persist);
        
        /// <summary>
        /// Validate the password of the user in the base of the PIER or WS
        /// </summary>
        /// <remarks>
        /// This method allows to validate the passaword of the user
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">Password of the user</param>
        /// <param name="id">Identification Code of the user (id)</param>
        /// <returns>string</returns>
        string ValidarSenha (string senha, long? id);
  
        /// <summary>
        /// Validate the password of the user in the base of the PIER or WS
        /// </summary>
        /// <remarks>
        /// This method allows to validate the passaword of the user
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">Password of the user</param>
        /// <param name="id">Identification Code of the user (id)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ValidarSenhaWithHttpInfo (string senha, long? id);
        
        /// <summary>
        /// Validate the user&#39;s strong password
        /// </summary>
        /// <remarks>
        /// This feature allows you to validate if the user password is a strong password
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">User password</param>
        /// <param name="usuarioSenhaFortePersist">platform id</param>
        /// <returns>string</returns>
        string ValidarSenhaForte (string senha, StrongPassword usuarioSenhaFortePersist);
  
        /// <summary>
        /// Validate the user&#39;s strong password
        /// </summary>
        /// <remarks>
        /// This feature allows you to validate if the user password is a strong password
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">User password</param>
        /// <param name="usuarioSenhaFortePersist">platform id</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ValidarSenhaForteWithHttpInfo (string senha, StrongPassword usuarioSenhaFortePersist);
        
        /// <summary>
        /// Make login with validation of the user&#39;s password registered in the base of the PIER or WS
        /// </summary>
        /// <remarks>
        /// The resource allost to make the login of the user through the password defined by the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">Login identifier of the user (login)</param>
        /// <param name="senha">User Password</param>
        /// <param name="request">request (optional)</param>
        /// <returns>Object</returns>
        Object ValidarSenhaLogin (string login, string senha, ValidarSenhaLoginRequest request = null);
  
        /// <summary>
        /// Make login with validation of the user&#39;s password registered in the base of the PIER or WS
        /// </summary>
        /// <remarks>
        /// The resource allost to make the login of the user through the password defined by the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">Login identifier of the user (login)</param>
        /// <param name="senha">User Password</param>
        /// <param name="request">request (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ValidarSenhaLoginWithHttpInfo (string login, string senha, ValidarSenhaLoginRequest request = null);
        
        /// <summary>
        /// User associated with existing accounts
        /// </summary>
        /// <remarks>
        /// This method lets you associate a user with existing accounts
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">User Identification Code (id)</param>
        /// <returns>string</returns>
        string VincularContas (long? id);
  
        /// <summary>
        /// User associated with existing accounts
        /// </summary>
        /// <remarks>
        /// This method lets you associate a user with existing accounts
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">User Identification Code (id)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> VincularContasWithHttpInfo (long? id);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Update the users registered in the base
        /// </summary>
        /// <remarks>
        /// This method update the users
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the User (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of UsuarioResponse</returns>
        System.Threading.Tasks.Task<UsuarioResponse> AlterarAsync (long? id, UserUpdate update);

        /// <summary>
        /// Update the users registered in the base
        /// </summary>
        /// <remarks>
        /// This method update the users
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the User (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> AlterarAsyncWithHttpInfo (long? id, UserUpdate update);
        
        /// <summary>
        /// Update the user&#39;s password in the vase of the PIER or WS
        /// </summary>
        /// <remarks>
        /// This method allows to update the user&#39;s password
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the User (id)</param>
        /// <param name="senhaAtual">Current Password</param>
        /// <param name="senhaNova">New Password</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> AlterarSenhaAsync (long? id, string senhaAtual, string senhaNova);

        /// <summary>
        /// Update the user&#39;s password in the vase of the PIER or WS
        /// </summary>
        /// <remarks>
        /// This method allows to update the user&#39;s password
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the User (id)</param>
        /// <param name="senhaAtual">Current Password</param>
        /// <param name="senhaNova">New Password</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> AlterarSenhaAsyncWithHttpInfo (long? id, string senhaAtual, string senhaNova);
        
        /// <summary>
        /// Update the password of the user
        /// </summary>
        /// <remarks>
        /// This method updates the password of the user
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">Login of the user</param>
        /// <param name="senhaNova">New password</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> AlterarSenhaLoginAsync (string login, string senhaNova);

        /// <summary>
        /// Update the password of the user
        /// </summary>
        /// <remarks>
        /// This method updates the password of the user
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">Login of the user</param>
        /// <param name="senhaNova">New password</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> AlterarSenhaLoginAsyncWithHttpInfo (string login, string senhaNova);
        
        /// <summary>
        /// Activate the users registered in the base of the PIER or WS
        /// </summary>
        /// <remarks>
        /// this method activate the users
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the user (id)</param>
        /// <returns>Task of UsuarioResponse</returns>
        System.Threading.Tasks.Task<UsuarioResponse> AtivarUsuarioAsync (long? id);

        /// <summary>
        /// Activate the users registered in the base of the PIER or WS
        /// </summary>
        /// <remarks>
        /// this method activate the users
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the user (id)</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> AtivarUsuarioAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Updates user device
        /// </summary>
        /// <remarks>
        /// This feature allows you to update the user&#39;s device
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Access control identifier</param>
        /// <param name="update">update</param>
        /// <returns>Task of ControleSegurancaDispositivoResponse</returns>
        System.Threading.Tasks.Task<ControleSegurancaDispositivoResponse> AtualizarAsync (long? id, UsuarioDispositivoUpdate update);

        /// <summary>
        /// Updates user device
        /// </summary>
        /// <remarks>
        /// This feature allows you to update the user&#39;s device
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Access control identifier</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (ControleSegurancaDispositivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ControleSegurancaDispositivoResponse>> AtualizarAsyncWithHttpInfo (long? id, UsuarioDispositivoUpdate update);
        
        /// <summary>
        /// User device query
        /// </summary>
        /// <remarks>
        /// This method allows you to query the user device
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idUsuario">User Id</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageControleSegurancaDispositivoResponse</returns>
        System.Threading.Tasks.Task<PageControleSegurancaDispositivoResponse> ConsultarAsync (long? idUsuario, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// User device query
        /// </summary>
        /// <remarks>
        /// This method allows you to query the user device
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idUsuario">User Id</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageControleSegurancaDispositivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageControleSegurancaDispositivoResponse>> ConsultarAsyncWithHttpInfo (long? idUsuario, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lists accounts linked to the user
        /// </summary>
        /// <remarks>
        /// This feature allows you to list the accounts linked to the user by ID
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">User Id</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageUsuarioContasResponse</returns>
        System.Threading.Tasks.Task<PageUsuarioContasResponse> ConsultarContasVinculadasAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lists accounts linked to the user
        /// </summary>
        /// <remarks>
        /// This feature allows you to list the accounts linked to the user by ID
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">User Id</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageUsuarioContasResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageUsuarioContasResponse>> ConsultarContasVinculadasAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// List the dates of a determined user in the base of PIER or WS
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve the information of a determined user using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the user (id)</param>
        /// <returns>Task of UsuarioResponse</returns>
        System.Threading.Tasks.Task<UsuarioResponse> Consultar_0Async (long? id);

        /// <summary>
        /// List the dates of a determined user in the base of PIER or WS
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve the information of a determined user using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the user (id)</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> Consultar_0AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Removes the user&#39;s device
        /// </summary>
        /// <remarks>
        /// This feature allows you to remove the user&#39;s device
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Access control identifier</param>
        /// <returns>Task of ControleSegurancaDispositivoResponse</returns>
        System.Threading.Tasks.Task<ControleSegurancaDispositivoResponse> DeletarAsync (long? id);

        /// <summary>
        /// Removes the user&#39;s device
        /// </summary>
        /// <remarks>
        /// This feature allows you to remove the user&#39;s device
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Access control identifier</param>
        /// <returns>Task of ApiResponse (ControleSegurancaDispositivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ControleSegurancaDispositivoResponse>> DeletarAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Disable the user registered in the base of the PIER or WS
        /// </summary>
        /// <remarks>
        /// This method disables the users
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the User (id)</param>
        /// <returns>Task of UsuarioResponse</returns>
        System.Threading.Tasks.Task<UsuarioResponse> DesativarUsuarioAsync (long? id);

        /// <summary>
        /// Disable the user registered in the base of the PIER or WS
        /// </summary>
        /// <remarks>
        /// This method disables the users
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the User (id)</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> DesativarUsuarioAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// List the users registered in the base of the PIER or WS
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the existing users in the base of the PIER
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Name of the user (optional)</param>
        /// <param name="cpf">User CPF (optional)</param>
        /// <param name="email">Email of the user (optional)</param>
        /// <param name="status">Status of the user (optional)</param>
        /// <returns>Task of PageUsuarioResponse</returns>
        System.Threading.Tasks.Task<PageUsuarioResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string cpf = null, string email = null, string status = null);

        /// <summary>
        /// List the users registered in the base of the PIER or WS
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the existing users in the base of the PIER
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Name of the user (optional)</param>
        /// <param name="cpf">User CPF (optional)</param>
        /// <param name="email">Email of the user (optional)</param>
        /// <param name="status">Status of the user (optional)</param>
        /// <returns>Task of ApiResponse (PageUsuarioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageUsuarioResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string cpf = null, string email = null, string status = null);
        
        /// <summary>
        /// Retrieve the user&#39;s password in the base or WS
        /// </summary>
        /// <remarks>
        /// This resource allows to retrieve the user&#39;s password
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the user (id)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> RecuperarSenhaAsync (long? id);

        /// <summary>
        /// Retrieve the user&#39;s password in the base or WS
        /// </summary>
        /// <remarks>
        /// This resource allows to retrieve the user&#39;s password
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the user (id)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> RecuperarSenhaAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Register user&#39;s device
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar o dispositivo do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ControleSegurancaDispositivoResponse</returns>
        System.Threading.Tasks.Task<ControleSegurancaDispositivoResponse> SalvarAsync (UsuarioDispositivoPersist persist);

        /// <summary>
        /// Register user&#39;s device
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar o dispositivo do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (ControleSegurancaDispositivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ControleSegurancaDispositivoResponse>> SalvarAsyncWithHttpInfo (UsuarioDispositivoPersist persist);
        
        /// <summary>
        /// Create user in the base
        /// </summary>
        /// <remarks>
        /// This resource allows to create users
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of UsuarioResponse</returns>
        System.Threading.Tasks.Task<UsuarioResponse> Salvar_0Async (UsuarioPersist persist);

        /// <summary>
        /// Create user in the base
        /// </summary>
        /// <remarks>
        /// This resource allows to create users
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> Salvar_0AsyncWithHttpInfo (UsuarioPersist persist);
        
        /// <summary>
        /// Validate the password of the user in the base of the PIER or WS
        /// </summary>
        /// <remarks>
        /// This method allows to validate the passaword of the user
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">Password of the user</param>
        /// <param name="id">Identification Code of the user (id)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ValidarSenhaAsync (string senha, long? id);

        /// <summary>
        /// Validate the password of the user in the base of the PIER or WS
        /// </summary>
        /// <remarks>
        /// This method allows to validate the passaword of the user
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">Password of the user</param>
        /// <param name="id">Identification Code of the user (id)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ValidarSenhaAsyncWithHttpInfo (string senha, long? id);
        
        /// <summary>
        /// Validate the user&#39;s strong password
        /// </summary>
        /// <remarks>
        /// This feature allows you to validate if the user password is a strong password
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">User password</param>
        /// <param name="usuarioSenhaFortePersist">platform id</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ValidarSenhaForteAsync (string senha, StrongPassword usuarioSenhaFortePersist);

        /// <summary>
        /// Validate the user&#39;s strong password
        /// </summary>
        /// <remarks>
        /// This feature allows you to validate if the user password is a strong password
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">User password</param>
        /// <param name="usuarioSenhaFortePersist">platform id</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ValidarSenhaForteAsyncWithHttpInfo (string senha, StrongPassword usuarioSenhaFortePersist);
        
        /// <summary>
        /// Make login with validation of the user&#39;s password registered in the base of the PIER or WS
        /// </summary>
        /// <remarks>
        /// The resource allost to make the login of the user through the password defined by the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">Login identifier of the user (login)</param>
        /// <param name="senha">User Password</param>
        /// <param name="request">request (optional)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ValidarSenhaLoginAsync (string login, string senha, ValidarSenhaLoginRequest request = null);

        /// <summary>
        /// Make login with validation of the user&#39;s password registered in the base of the PIER or WS
        /// </summary>
        /// <remarks>
        /// The resource allost to make the login of the user through the password defined by the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">Login identifier of the user (login)</param>
        /// <param name="senha">User Password</param>
        /// <param name="request">request (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ValidarSenhaLoginAsyncWithHttpInfo (string login, string senha, ValidarSenhaLoginRequest request = null);
        
        /// <summary>
        /// User associated with existing accounts
        /// </summary>
        /// <remarks>
        /// This method lets you associate a user with existing accounts
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">User Identification Code (id)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> VincularContasAsync (long? id);

        /// <summary>
        /// User associated with existing accounts
        /// </summary>
        /// <remarks>
        /// This method lets you associate a user with existing accounts
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">User Identification Code (id)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> VincularContasAsyncWithHttpInfo (long? id);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserApi : IUserApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UserApi(Configuration configuration = null)
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
        /// Update the users registered in the base This method update the users
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the User (id)</param> 
        /// <param name="update">update</param> 
        /// <returns>UsuarioResponse</returns>
        public UsuarioResponse Alterar (long? id, UserUpdate update)
        {
             ApiResponse<UsuarioResponse> localVarResponse = AlterarWithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the users registered in the base This method update the users
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the User (id)</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of UsuarioResponse</returns>
        public ApiResponse< UsuarioResponse > AlterarWithHttpInfo (long? id, UserUpdate update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling UserApi->Alterar");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling UserApi->Alterar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }

        
        /// <summary>
        /// Update the users registered in the base This method update the users
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the User (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of UsuarioResponse</returns>
        public async System.Threading.Tasks.Task<UsuarioResponse> AlterarAsync (long? id, UserUpdate update)
        {
             ApiResponse<UsuarioResponse> localVarResponse = await AlterarAsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the users registered in the base This method update the users
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the User (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> AlterarAsyncWithHttpInfo (long? id, UserUpdate update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Alterar");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling Alterar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }
        
        /// <summary>
        /// Update the user&#39;s password in the vase of the PIER or WS This method allows to update the user&#39;s password
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the User (id)</param> 
        /// <param name="senhaAtual">Current Password</param> 
        /// <param name="senhaNova">New Password</param> 
        /// <returns>string</returns>
        public string AlterarSenha (long? id, string senhaAtual, string senhaNova)
        {
             ApiResponse<string> localVarResponse = AlterarSenhaWithHttpInfo(id, senhaAtual, senhaNova);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the user&#39;s password in the vase of the PIER or WS This method allows to update the user&#39;s password
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the User (id)</param> 
        /// <param name="senhaAtual">Current Password</param> 
        /// <param name="senhaNova">New Password</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > AlterarSenhaWithHttpInfo (long? id, string senhaAtual, string senhaNova)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling UserApi->AlterarSenha");
            
            // verify the required parameter 'senhaAtual' is set
            if (senhaAtual == null)
                throw new ApiException(400, "Missing required parameter 'senhaAtual' when calling UserApi->AlterarSenha");
            
            // verify the required parameter 'senhaNova' is set
            if (senhaNova == null)
                throw new ApiException(400, "Missing required parameter 'senhaNova' when calling UserApi->AlterarSenha");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenha: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenha: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Update the user&#39;s password in the vase of the PIER or WS This method allows to update the user&#39;s password
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the User (id)</param>
        /// <param name="senhaAtual">Current Password</param>
        /// <param name="senhaNova">New Password</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> AlterarSenhaAsync (long? id, string senhaAtual, string senhaNova)
        {
             ApiResponse<string> localVarResponse = await AlterarSenhaAsyncWithHttpInfo(id, senhaAtual, senhaNova);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the user&#39;s password in the vase of the PIER or WS This method allows to update the user&#39;s password
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the User (id)</param>
        /// <param name="senhaAtual">Current Password</param>
        /// <param name="senhaNova">New Password</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> AlterarSenhaAsyncWithHttpInfo (long? id, string senhaAtual, string senhaNova)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarSenha");
            // verify the required parameter 'senhaAtual' is set
            if (senhaAtual == null) throw new ApiException(400, "Missing required parameter 'senhaAtual' when calling AlterarSenha");
            // verify the required parameter 'senhaNova' is set
            if (senhaNova == null) throw new ApiException(400, "Missing required parameter 'senhaNova' when calling AlterarSenha");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenha: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenha: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Update the password of the user This method updates the password of the user
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">Login of the user</param> 
        /// <param name="senhaNova">New password</param> 
        /// <returns>string</returns>
        public string AlterarSenhaLogin (string login, string senhaNova)
        {
             ApiResponse<string> localVarResponse = AlterarSenhaLoginWithHttpInfo(login, senhaNova);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the password of the user This method updates the password of the user
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">Login of the user</param> 
        /// <param name="senhaNova">New password</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > AlterarSenhaLoginWithHttpInfo (string login, string senhaNova)
        {
            
            // verify the required parameter 'login' is set
            if (login == null)
                throw new ApiException(400, "Missing required parameter 'login' when calling UserApi->AlterarSenhaLogin");
            
            // verify the required parameter 'senhaNova' is set
            if (senhaNova == null)
                throw new ApiException(400, "Missing required parameter 'senhaNova' when calling UserApi->AlterarSenhaLogin");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenhaLogin: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenhaLogin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Update the password of the user This method updates the password of the user
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">Login of the user</param>
        /// <param name="senhaNova">New password</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> AlterarSenhaLoginAsync (string login, string senhaNova)
        {
             ApiResponse<string> localVarResponse = await AlterarSenhaLoginAsyncWithHttpInfo(login, senhaNova);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the password of the user This method updates the password of the user
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">Login of the user</param>
        /// <param name="senhaNova">New password</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> AlterarSenhaLoginAsyncWithHttpInfo (string login, string senhaNova)
        {
            // verify the required parameter 'login' is set
            if (login == null) throw new ApiException(400, "Missing required parameter 'login' when calling AlterarSenhaLogin");
            // verify the required parameter 'senhaNova' is set
            if (senhaNova == null) throw new ApiException(400, "Missing required parameter 'senhaNova' when calling AlterarSenhaLogin");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenhaLogin: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenhaLogin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Activate the users registered in the base of the PIER or WS this method activate the users
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the user (id)</param> 
        /// <returns>UsuarioResponse</returns>
        public UsuarioResponse AtivarUsuario (long? id)
        {
             ApiResponse<UsuarioResponse> localVarResponse = AtivarUsuarioWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Activate the users registered in the base of the PIER or WS this method activate the users
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the user (id)</param> 
        /// <returns>ApiResponse of UsuarioResponse</returns>
        public ApiResponse< UsuarioResponse > AtivarUsuarioWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling UserApi->AtivarUsuario");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtivarUsuario: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarUsuario: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }

        
        /// <summary>
        /// Activate the users registered in the base of the PIER or WS this method activate the users
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the user (id)</param>
        /// <returns>Task of UsuarioResponse</returns>
        public async System.Threading.Tasks.Task<UsuarioResponse> AtivarUsuarioAsync (long? id)
        {
             ApiResponse<UsuarioResponse> localVarResponse = await AtivarUsuarioAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Activate the users registered in the base of the PIER or WS this method activate the users
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the user (id)</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> AtivarUsuarioAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtivarUsuario");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtivarUsuario: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarUsuario: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }
        
        /// <summary>
        /// Updates user device This feature allows you to update the user&#39;s device
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Access control identifier</param> 
        /// <param name="update">update</param> 
        /// <returns>ControleSegurancaDispositivoResponse</returns>
        public ControleSegurancaDispositivoResponse Atualizar (long? id, UsuarioDispositivoUpdate update)
        {
             ApiResponse<ControleSegurancaDispositivoResponse> localVarResponse = AtualizarWithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Updates user device This feature allows you to update the user&#39;s device
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Access control identifier</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of ControleSegurancaDispositivoResponse</returns>
        public ApiResponse< ControleSegurancaDispositivoResponse > AtualizarWithHttpInfo (long? id, UsuarioDispositivoUpdate update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling UserApi->Atualizar");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling UserApi->Atualizar");
            
    
            var localVarPath = "/api/controles-seguranca-dispositivos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling Atualizar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Atualizar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ControleSegurancaDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleSegurancaDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleSegurancaDispositivoResponse)));
            
        }

        
        /// <summary>
        /// Updates user device This feature allows you to update the user&#39;s device
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Access control identifier</param>
        /// <param name="update">update</param>
        /// <returns>Task of ControleSegurancaDispositivoResponse</returns>
        public async System.Threading.Tasks.Task<ControleSegurancaDispositivoResponse> AtualizarAsync (long? id, UsuarioDispositivoUpdate update)
        {
             ApiResponse<ControleSegurancaDispositivoResponse> localVarResponse = await AtualizarAsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Updates user device This feature allows you to update the user&#39;s device
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Access control identifier</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (ControleSegurancaDispositivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ControleSegurancaDispositivoResponse>> AtualizarAsyncWithHttpInfo (long? id, UsuarioDispositivoUpdate update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Atualizar");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling Atualizar");
            
    
            var localVarPath = "/api/controles-seguranca-dispositivos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling Atualizar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Atualizar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ControleSegurancaDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleSegurancaDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleSegurancaDispositivoResponse)));
            
        }
        
        /// <summary>
        /// User device query This method allows you to query the user device
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idUsuario">User Id</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>PageControleSegurancaDispositivoResponse</returns>
        public PageControleSegurancaDispositivoResponse Consultar (long? idUsuario, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageControleSegurancaDispositivoResponse> localVarResponse = ConsultarWithHttpInfo(idUsuario, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// User device query This method allows you to query the user device
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idUsuario">User Id</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageControleSegurancaDispositivoResponse</returns>
        public ApiResponse< PageControleSegurancaDispositivoResponse > ConsultarWithHttpInfo (long? idUsuario, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'idUsuario' is set
            if (idUsuario == null)
                throw new ApiException(400, "Missing required parameter 'idUsuario' when calling UserApi->Consultar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageControleSegurancaDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageControleSegurancaDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageControleSegurancaDispositivoResponse)));
            
        }

        
        /// <summary>
        /// User device query This method allows you to query the user device
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idUsuario">User Id</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageControleSegurancaDispositivoResponse</returns>
        public async System.Threading.Tasks.Task<PageControleSegurancaDispositivoResponse> ConsultarAsync (long? idUsuario, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageControleSegurancaDispositivoResponse> localVarResponse = await ConsultarAsyncWithHttpInfo(idUsuario, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// User device query This method allows you to query the user device
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idUsuario">User Id</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageControleSegurancaDispositivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageControleSegurancaDispositivoResponse>> ConsultarAsyncWithHttpInfo (long? idUsuario, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'idUsuario' is set
            if (idUsuario == null) throw new ApiException(400, "Missing required parameter 'idUsuario' when calling Consultar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageControleSegurancaDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageControleSegurancaDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageControleSegurancaDispositivoResponse)));
            
        }
        
        /// <summary>
        /// Lists accounts linked to the user This feature allows you to list the accounts linked to the user by ID
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">User Id</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>PageUsuarioContasResponse</returns>
        public PageUsuarioContasResponse ConsultarContasVinculadas (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageUsuarioContasResponse> localVarResponse = ConsultarContasVinculadasWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lists accounts linked to the user This feature allows you to list the accounts linked to the user by ID
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">User Id</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageUsuarioContasResponse</returns>
        public ApiResponse< PageUsuarioContasResponse > ConsultarContasVinculadasWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling UserApi->ConsultarContasVinculadas");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarContasVinculadas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarContasVinculadas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageUsuarioContasResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageUsuarioContasResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageUsuarioContasResponse)));
            
        }

        
        /// <summary>
        /// Lists accounts linked to the user This feature allows you to list the accounts linked to the user by ID
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">User Id</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageUsuarioContasResponse</returns>
        public async System.Threading.Tasks.Task<PageUsuarioContasResponse> ConsultarContasVinculadasAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageUsuarioContasResponse> localVarResponse = await ConsultarContasVinculadasAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lists accounts linked to the user This feature allows you to list the accounts linked to the user by ID
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">User Id</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageUsuarioContasResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageUsuarioContasResponse>> ConsultarContasVinculadasAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarContasVinculadas");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarContasVinculadas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarContasVinculadas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageUsuarioContasResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageUsuarioContasResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageUsuarioContasResponse)));
            
        }
        
        /// <summary>
        /// List the dates of a determined user in the base of PIER or WS This method allows to retrieve the information of a determined user using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the user (id)</param> 
        /// <returns>UsuarioResponse</returns>
        public UsuarioResponse Consultar_0 (long? id)
        {
             ApiResponse<UsuarioResponse> localVarResponse = Consultar_0WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the dates of a determined user in the base of PIER or WS This method allows to retrieve the information of a determined user using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the user (id)</param> 
        /// <returns>ApiResponse of UsuarioResponse</returns>
        public ApiResponse< UsuarioResponse > Consultar_0WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling UserApi->Consultar_0");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }

        
        /// <summary>
        /// List the dates of a determined user in the base of PIER or WS This method allows to retrieve the information of a determined user using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the user (id)</param>
        /// <returns>Task of UsuarioResponse</returns>
        public async System.Threading.Tasks.Task<UsuarioResponse> Consultar_0Async (long? id)
        {
             ApiResponse<UsuarioResponse> localVarResponse = await Consultar_0AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the dates of a determined user in the base of PIER or WS This method allows to retrieve the information of a determined user using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the user (id)</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> Consultar_0AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar_0");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }
        
        /// <summary>
        /// Removes the user&#39;s device This feature allows you to remove the user&#39;s device
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Access control identifier</param> 
        /// <returns>ControleSegurancaDispositivoResponse</returns>
        public ControleSegurancaDispositivoResponse Deletar (long? id)
        {
             ApiResponse<ControleSegurancaDispositivoResponse> localVarResponse = DeletarWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Removes the user&#39;s device This feature allows you to remove the user&#39;s device
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Access control identifier</param> 
        /// <returns>ApiResponse of ControleSegurancaDispositivoResponse</returns>
        public ApiResponse< ControleSegurancaDispositivoResponse > DeletarWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling UserApi->Deletar");
            
    
            var localVarPath = "/api/controles-seguranca-dispositivos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling Deletar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Deletar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ControleSegurancaDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleSegurancaDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleSegurancaDispositivoResponse)));
            
        }

        
        /// <summary>
        /// Removes the user&#39;s device This feature allows you to remove the user&#39;s device
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Access control identifier</param>
        /// <returns>Task of ControleSegurancaDispositivoResponse</returns>
        public async System.Threading.Tasks.Task<ControleSegurancaDispositivoResponse> DeletarAsync (long? id)
        {
             ApiResponse<ControleSegurancaDispositivoResponse> localVarResponse = await DeletarAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Removes the user&#39;s device This feature allows you to remove the user&#39;s device
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Access control identifier</param>
        /// <returns>Task of ApiResponse (ControleSegurancaDispositivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ControleSegurancaDispositivoResponse>> DeletarAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Deletar");
            
    
            var localVarPath = "/api/controles-seguranca-dispositivos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling Deletar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Deletar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ControleSegurancaDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleSegurancaDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleSegurancaDispositivoResponse)));
            
        }
        
        /// <summary>
        /// Disable the user registered in the base of the PIER or WS This method disables the users
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the User (id)</param> 
        /// <returns>UsuarioResponse</returns>
        public UsuarioResponse DesativarUsuario (long? id)
        {
             ApiResponse<UsuarioResponse> localVarResponse = DesativarUsuarioWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Disable the user registered in the base of the PIER or WS This method disables the users
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the User (id)</param> 
        /// <returns>ApiResponse of UsuarioResponse</returns>
        public ApiResponse< UsuarioResponse > DesativarUsuarioWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling UserApi->DesativarUsuario");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesativarUsuario: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarUsuario: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }

        
        /// <summary>
        /// Disable the user registered in the base of the PIER or WS This method disables the users
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the User (id)</param>
        /// <returns>Task of UsuarioResponse</returns>
        public async System.Threading.Tasks.Task<UsuarioResponse> DesativarUsuarioAsync (long? id)
        {
             ApiResponse<UsuarioResponse> localVarResponse = await DesativarUsuarioAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Disable the user registered in the base of the PIER or WS This method disables the users
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the User (id)</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> DesativarUsuarioAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesativarUsuario");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesativarUsuario: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarUsuario: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }
        
        /// <summary>
        /// List the users registered in the base of the PIER or WS This method allows to be listed the existing users in the base of the PIER
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="nome">Name of the user (optional)</param> 
        /// <param name="cpf">User CPF (optional)</param> 
        /// <param name="email">Email of the user (optional)</param> 
        /// <param name="status">Status of the user (optional)</param> 
        /// <returns>PageUsuarioResponse</returns>
        public PageUsuarioResponse Listar (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string cpf = null, string email = null, string status = null)
        {
             ApiResponse<PageUsuarioResponse> localVarResponse = ListarWithHttpInfo(sort, page, limit, nome, cpf, email, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the users registered in the base of the PIER or WS This method allows to be listed the existing users in the base of the PIER
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="nome">Name of the user (optional)</param> 
        /// <param name="cpf">User CPF (optional)</param> 
        /// <param name="email">Email of the user (optional)</param> 
        /// <param name="status">Status of the user (optional)</param> 
        /// <returns>ApiResponse of PageUsuarioResponse</returns>
        public ApiResponse< PageUsuarioResponse > ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string cpf = null, string email = null, string status = null)
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
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageUsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageUsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageUsuarioResponse)));
            
        }

        
        /// <summary>
        /// List the users registered in the base of the PIER or WS This method allows to be listed the existing users in the base of the PIER
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Name of the user (optional)</param>
        /// <param name="cpf">User CPF (optional)</param>
        /// <param name="email">Email of the user (optional)</param>
        /// <param name="status">Status of the user (optional)</param>
        /// <returns>Task of PageUsuarioResponse</returns>
        public async System.Threading.Tasks.Task<PageUsuarioResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string cpf = null, string email = null, string status = null)
        {
             ApiResponse<PageUsuarioResponse> localVarResponse = await ListarAsyncWithHttpInfo(sort, page, limit, nome, cpf, email, status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the users registered in the base of the PIER or WS This method allows to be listed the existing users in the base of the PIER
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Name of the user (optional)</param>
        /// <param name="cpf">User CPF (optional)</param>
        /// <param name="email">Email of the user (optional)</param>
        /// <param name="status">Status of the user (optional)</param>
        /// <returns>Task of ApiResponse (PageUsuarioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageUsuarioResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string cpf = null, string email = null, string status = null)
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
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageUsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageUsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageUsuarioResponse)));
            
        }
        
        /// <summary>
        /// Retrieve the user&#39;s password in the base or WS This resource allows to retrieve the user&#39;s password
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the user (id)</param> 
        /// <returns>string</returns>
        public string RecuperarSenha (long? id)
        {
             ApiResponse<string> localVarResponse = RecuperarSenhaWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve the user&#39;s password in the base or WS This resource allows to retrieve the user&#39;s password
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the user (id)</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > RecuperarSenhaWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling UserApi->RecuperarSenha");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling RecuperarSenha: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RecuperarSenha: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Retrieve the user&#39;s password in the base or WS This resource allows to retrieve the user&#39;s password
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the user (id)</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> RecuperarSenhaAsync (long? id)
        {
             ApiResponse<string> localVarResponse = await RecuperarSenhaAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve the user&#39;s password in the base or WS This resource allows to retrieve the user&#39;s password
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the user (id)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> RecuperarSenhaAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RecuperarSenha");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling RecuperarSenha: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RecuperarSenha: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Register user&#39;s device Este recurso permite cadastrar o dispositivo do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ControleSegurancaDispositivoResponse</returns>
        public ControleSegurancaDispositivoResponse Salvar (UsuarioDispositivoPersist persist)
        {
             ApiResponse<ControleSegurancaDispositivoResponse> localVarResponse = SalvarWithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Register user&#39;s device Este recurso permite cadastrar o dispositivo do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of ControleSegurancaDispositivoResponse</returns>
        public ApiResponse< ControleSegurancaDispositivoResponse > SalvarWithHttpInfo (UsuarioDispositivoPersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling UserApi->Salvar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ControleSegurancaDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleSegurancaDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleSegurancaDispositivoResponse)));
            
        }

        
        /// <summary>
        /// Register user&#39;s device Este recurso permite cadastrar o dispositivo do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ControleSegurancaDispositivoResponse</returns>
        public async System.Threading.Tasks.Task<ControleSegurancaDispositivoResponse> SalvarAsync (UsuarioDispositivoPersist persist)
        {
             ApiResponse<ControleSegurancaDispositivoResponse> localVarResponse = await SalvarAsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Register user&#39;s device Este recurso permite cadastrar o dispositivo do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (ControleSegurancaDispositivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ControleSegurancaDispositivoResponse>> SalvarAsyncWithHttpInfo (UsuarioDispositivoPersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling Salvar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ControleSegurancaDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleSegurancaDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleSegurancaDispositivoResponse)));
            
        }
        
        /// <summary>
        /// Create user in the base This resource allows to create users
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>UsuarioResponse</returns>
        public UsuarioResponse Salvar_0 (UsuarioPersist persist)
        {
             ApiResponse<UsuarioResponse> localVarResponse = Salvar_0WithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create user in the base This resource allows to create users
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of UsuarioResponse</returns>
        public ApiResponse< UsuarioResponse > Salvar_0WithHttpInfo (UsuarioPersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling UserApi->Salvar_0");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Salvar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }

        
        /// <summary>
        /// Create user in the base This resource allows to create users
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of UsuarioResponse</returns>
        public async System.Threading.Tasks.Task<UsuarioResponse> Salvar_0Async (UsuarioPersist persist)
        {
             ApiResponse<UsuarioResponse> localVarResponse = await Salvar_0AsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create user in the base This resource allows to create users
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> Salvar_0AsyncWithHttpInfo (UsuarioPersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling Salvar_0");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Salvar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }
        
        /// <summary>
        /// Validate the password of the user in the base of the PIER or WS This method allows to validate the passaword of the user
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">Password of the user</param> 
        /// <param name="id">Identification Code of the user (id)</param> 
        /// <returns>string</returns>
        public string ValidarSenha (string senha, long? id)
        {
             ApiResponse<string> localVarResponse = ValidarSenhaWithHttpInfo(senha, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Validate the password of the user in the base of the PIER or WS This method allows to validate the passaword of the user
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">Password of the user</param> 
        /// <param name="id">Identification Code of the user (id)</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ValidarSenhaWithHttpInfo (string senha, long? id)
        {
            
            // verify the required parameter 'senha' is set
            if (senha == null)
                throw new ApiException(400, "Missing required parameter 'senha' when calling UserApi->ValidarSenha");
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling UserApi->ValidarSenha");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenha: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenha: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Validate the password of the user in the base of the PIER or WS This method allows to validate the passaword of the user
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">Password of the user</param>
        /// <param name="id">Identification Code of the user (id)</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ValidarSenhaAsync (string senha, long? id)
        {
             ApiResponse<string> localVarResponse = await ValidarSenhaAsyncWithHttpInfo(senha, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Validate the password of the user in the base of the PIER or WS This method allows to validate the passaword of the user
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">Password of the user</param>
        /// <param name="id">Identification Code of the user (id)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ValidarSenhaAsyncWithHttpInfo (string senha, long? id)
        {
            // verify the required parameter 'senha' is set
            if (senha == null) throw new ApiException(400, "Missing required parameter 'senha' when calling ValidarSenha");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ValidarSenha");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenha: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenha: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Validate the user&#39;s strong password This feature allows you to validate if the user password is a strong password
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">User password</param> 
        /// <param name="usuarioSenhaFortePersist">platform id</param> 
        /// <returns>string</returns>
        public string ValidarSenhaForte (string senha, StrongPassword usuarioSenhaFortePersist)
        {
             ApiResponse<string> localVarResponse = ValidarSenhaForteWithHttpInfo(senha, usuarioSenhaFortePersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Validate the user&#39;s strong password This feature allows you to validate if the user password is a strong password
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">User password</param> 
        /// <param name="usuarioSenhaFortePersist">platform id</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ValidarSenhaForteWithHttpInfo (string senha, StrongPassword usuarioSenhaFortePersist)
        {
            
            // verify the required parameter 'senha' is set
            if (senha == null)
                throw new ApiException(400, "Missing required parameter 'senha' when calling UserApi->ValidarSenhaForte");
            
            // verify the required parameter 'usuarioSenhaFortePersist' is set
            if (usuarioSenhaFortePersist == null)
                throw new ApiException(400, "Missing required parameter 'usuarioSenhaFortePersist' when calling UserApi->ValidarSenhaForte");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaForte: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaForte: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Validate the user&#39;s strong password This feature allows you to validate if the user password is a strong password
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">User password</param>
        /// <param name="usuarioSenhaFortePersist">platform id</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ValidarSenhaForteAsync (string senha, StrongPassword usuarioSenhaFortePersist)
        {
             ApiResponse<string> localVarResponse = await ValidarSenhaForteAsyncWithHttpInfo(senha, usuarioSenhaFortePersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Validate the user&#39;s strong password This feature allows you to validate if the user password is a strong password
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">User password</param>
        /// <param name="usuarioSenhaFortePersist">platform id</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ValidarSenhaForteAsyncWithHttpInfo (string senha, StrongPassword usuarioSenhaFortePersist)
        {
            // verify the required parameter 'senha' is set
            if (senha == null) throw new ApiException(400, "Missing required parameter 'senha' when calling ValidarSenhaForte");
            // verify the required parameter 'usuarioSenhaFortePersist' is set
            if (usuarioSenhaFortePersist == null) throw new ApiException(400, "Missing required parameter 'usuarioSenhaFortePersist' when calling ValidarSenhaForte");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaForte: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaForte: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Make login with validation of the user&#39;s password registered in the base of the PIER or WS The resource allost to make the login of the user through the password defined by the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">Login identifier of the user (login)</param> 
        /// <param name="senha">User Password</param> 
        /// <param name="request">request (optional)</param> 
        /// <returns>Object</returns>
        public Object ValidarSenhaLogin (string login, string senha, ValidarSenhaLoginRequest request = null)
        {
             ApiResponse<Object> localVarResponse = ValidarSenhaLoginWithHttpInfo(login, senha, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Make login with validation of the user&#39;s password registered in the base of the PIER or WS The resource allost to make the login of the user through the password defined by the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">Login identifier of the user (login)</param> 
        /// <param name="senha">User Password</param> 
        /// <param name="request">request (optional)</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > ValidarSenhaLoginWithHttpInfo (string login, string senha, ValidarSenhaLoginRequest request = null)
        {
            
            // verify the required parameter 'login' is set
            if (login == null)
                throw new ApiException(400, "Missing required parameter 'login' when calling UserApi->ValidarSenhaLogin");
            
            // verify the required parameter 'senha' is set
            if (senha == null)
                throw new ApiException(400, "Missing required parameter 'senha' when calling UserApi->ValidarSenhaLogin");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaLogin: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaLogin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Make login with validation of the user&#39;s password registered in the base of the PIER or WS The resource allost to make the login of the user through the password defined by the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">Login identifier of the user (login)</param>
        /// <param name="senha">User Password</param>
        /// <param name="request">request (optional)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ValidarSenhaLoginAsync (string login, string senha, ValidarSenhaLoginRequest request = null)
        {
             ApiResponse<Object> localVarResponse = await ValidarSenhaLoginAsyncWithHttpInfo(login, senha, request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Make login with validation of the user&#39;s password registered in the base of the PIER or WS The resource allost to make the login of the user through the password defined by the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">Login identifier of the user (login)</param>
        /// <param name="senha">User Password</param>
        /// <param name="request">request (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ValidarSenhaLoginAsyncWithHttpInfo (string login, string senha, ValidarSenhaLoginRequest request = null)
        {
            // verify the required parameter 'login' is set
            if (login == null) throw new ApiException(400, "Missing required parameter 'login' when calling ValidarSenhaLogin");
            // verify the required parameter 'senha' is set
            if (senha == null) throw new ApiException(400, "Missing required parameter 'senha' when calling ValidarSenhaLogin");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaLogin: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaLogin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// User associated with existing accounts This method lets you associate a user with existing accounts
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">User Identification Code (id)</param> 
        /// <returns>string</returns>
        public string VincularContas (long? id)
        {
             ApiResponse<string> localVarResponse = VincularContasWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// User associated with existing accounts This method lets you associate a user with existing accounts
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">User Identification Code (id)</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > VincularContasWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling UserApi->VincularContas");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling VincularContas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VincularContas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// User associated with existing accounts This method lets you associate a user with existing accounts
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">User Identification Code (id)</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> VincularContasAsync (long? id)
        {
             ApiResponse<string> localVarResponse = await VincularContasAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// User associated with existing accounts This method lets you associate a user with existing accounts
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">User Identification Code (id)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> VincularContasAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VincularContas");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling VincularContas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VincularContas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
    }
    
}
