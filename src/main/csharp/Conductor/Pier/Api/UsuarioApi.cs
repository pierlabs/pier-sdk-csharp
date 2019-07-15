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
    public interface IUsuarioApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Alterar senha do usu\u00E1rio na base do PIER ou WS
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o da senha do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <param name="senhaAtual">Senha Atual</param>
        /// <param name="senhaNova">Senha Nova</param>
        /// <returns>string</returns>
        string AlterarSenha1 (long? id, string senhaAtual, string senhaNova);
  
        /// <summary>
        /// Alterar senha do usu\u00E1rio na base do PIER ou WS
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o da senha do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <param name="senhaAtual">Senha Atual</param>
        /// <param name="senhaNova">Senha Nova</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> AlterarSenha1WithHttpInfo (long? id, string senhaAtual, string senhaNova);
        
        /// <summary>
        /// Alterar senha do usu\u00E1rio
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o da senha do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">Login do usu\u00E1rio</param>
        /// <param name="senhaNova">Senha Nova</param>
        /// <returns>string</returns>
        string AlterarSenhaPorLogin (string login, string senhaNova);
  
        /// <summary>
        /// Alterar senha do usu\u00E1rio
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o da senha do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">Login do usu\u00E1rio</param>
        /// <param name="senhaNova">Senha Nova</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> AlterarSenhaPorLoginWithHttpInfo (string login, string senhaNova);
        
        /// <summary>
        /// Altera os usu\u00E1rios cadastrados na base
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o dos usu\u00E1rios
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <param name="update">update</param>
        /// <returns>UsuarioResponse</returns>
        UsuarioResponse AlterarUsuario (long? id, UsuarioUpdate update);
  
        /// <summary>
        /// Altera os usu\u00E1rios cadastrados na base
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o dos usu\u00E1rios
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of UsuarioResponse</returns>
        ApiResponse<UsuarioResponse> AlterarUsuarioWithHttpInfo (long? id, UsuarioUpdate update);
        
        /// <summary>
        /// Ativa os usu\u00E1rios cadastrados na base do PIER ou WS
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a ativa\u00E7\u00E3o dos usu\u00E1rios
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <returns>UsuarioResponse</returns>
        UsuarioResponse AtivarUsuario (long? id);
  
        /// <summary>
        /// Ativa os usu\u00E1rios cadastrados na base do PIER ou WS
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a ativa\u00E7\u00E3o dos usu\u00E1rios
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <returns>ApiResponse of UsuarioResponse</returns>
        ApiResponse<UsuarioResponse> AtivarUsuarioWithHttpInfo (long? id);
        
        /// <summary>
        /// Atualiza dispositivo do usu\u00E1rio
        /// </summary>
        /// <remarks>
        /// Este recurso permite atualizar o dispositivo do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do controle de acesso</param>
        /// <param name="update">update</param>
        /// <returns>ControleSegurancaDispositivoResponse</returns>
        ControleSegurancaDispositivoResponse AtualizarControleSegurancaDispositivo (long? id, UsuarioDispositivoUpdate update);
  
        /// <summary>
        /// Atualiza dispositivo do usu\u00E1rio
        /// </summary>
        /// <remarks>
        /// Este recurso permite atualizar o dispositivo do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do controle de acesso</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of ControleSegurancaDispositivoResponse</returns>
        ApiResponse<ControleSegurancaDispositivoResponse> AtualizarControleSegurancaDispositivoWithHttpInfo (long? id, UsuarioDispositivoUpdate update);
        
        /// <summary>
        /// Lista as contas vinculadas ao usu\u00E1rio
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as contas vinculadas ao usu\u00E1rio por ID
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID do usu\u00E1rio</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageUsuarioContasResponse</returns>
        PageUsuarioContasResponse ConsultarContasVinculadas (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista as contas vinculadas ao usu\u00E1rio
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as contas vinculadas ao usu\u00E1rio por ID
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID do usu\u00E1rio</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageUsuarioContasResponse</returns>
        ApiResponse<PageUsuarioContasResponse> ConsultarContasVinculadasWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Consulta dispositivo do usu\u00E1rio
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar o dispositivo do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idUsuario">idUsuario</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageControleSegurancaDispositivoResponse</returns>
        PageControleSegurancaDispositivoResponse ConsultarControleSegurancaDispositivo (long? idUsuario, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Consulta dispositivo do usu\u00E1rio
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar o dispositivo do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idUsuario">idUsuario</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageControleSegurancaDispositivoResponse</returns>
        ApiResponse<PageControleSegurancaDispositivoResponse> ConsultarControleSegurancaDispositivoWithHttpInfo (long? idUsuario, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Apresenta os dados de um determinado Usu\u00E1rio na base do PIER ou WS
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar as informa\u00E7\u00F5es de um determinado Usu\u00E1rio a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do us\u00E1rio para consultar</param>
        /// <returns>UsuarioResponse</returns>
        UsuarioResponse ConsultarUsuario (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Usu\u00E1rio na base do PIER ou WS
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar as informa\u00E7\u00F5es de um determinado Usu\u00E1rio a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do us\u00E1rio para consultar</param>
        /// <returns>ApiResponse of UsuarioResponse</returns>
        ApiResponse<UsuarioResponse> ConsultarUsuarioWithHttpInfo (long? id);
        
        /// <summary>
        /// Remove o dispositivo do usu\u00E1rio
        /// </summary>
        /// <remarks>
        /// Este recurso permite remover o dispositivo do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do controle de acesso</param>
        /// <returns>ControleSegurancaDispositivoResponse</returns>
        ControleSegurancaDispositivoResponse DeletarControleSeguranca (long? id);
  
        /// <summary>
        /// Remove o dispositivo do usu\u00E1rio
        /// </summary>
        /// <remarks>
        /// Este recurso permite remover o dispositivo do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do controle de acesso</param>
        /// <returns>ApiResponse of ControleSegurancaDispositivoResponse</returns>
        ApiResponse<ControleSegurancaDispositivoResponse> DeletarControleSegurancaWithHttpInfo (long? id);
        
        /// <summary>
        /// Desativa os usu\u00E1rios cadastrados na base do PIER ou WS
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a desativa\u00E7\u00E3o dos usu\u00E1rios
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <returns>UsuarioResponse</returns>
        UsuarioResponse DesativarUsuario (long? id);
  
        /// <summary>
        /// Desativa os usu\u00E1rios cadastrados na base do PIER ou WS
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a desativa\u00E7\u00E3o dos usu\u00E1rios
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <returns>ApiResponse of UsuarioResponse</returns>
        ApiResponse<UsuarioResponse> DesativarUsuarioWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista os Usu\u00E1rios cadastrados na base do PIER ou WS
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os usu\u00E1rios existentes na base do PIER
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do Usuario (optional)</param>
        /// <param name="cpf">CPF do Usuario (optional)</param>
        /// <param name="email">Email do Usuario (optional)</param>
        /// <param name="status">Status do Usuario (optional)</param>
        /// <returns>PageUsuarioResponse</returns>
        PageUsuarioResponse ListarUsuarios (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string cpf = null, string email = null, string status = null);
  
        /// <summary>
        /// Lista os Usu\u00E1rios cadastrados na base do PIER ou WS
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os usu\u00E1rios existentes na base do PIER
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do Usuario (optional)</param>
        /// <param name="cpf">CPF do Usuario (optional)</param>
        /// <param name="email">Email do Usuario (optional)</param>
        /// <param name="status">Status do Usuario (optional)</param>
        /// <returns>ApiResponse of PageUsuarioResponse</returns>
        ApiResponse<PageUsuarioResponse> ListarUsuariosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string cpf = null, string email = null, string status = null);
        
        /// <summary>
        /// Recuperar senha do usu\u00E1rio na base do PIER ou WS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite recuperar a senha do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <returns>string</returns>
        string RecuperarSenha (long? id);
  
        /// <summary>
        /// Recuperar senha do usu\u00E1rio na base do PIER ou WS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite recuperar a senha do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> RecuperarSenhaWithHttpInfo (long? id);
        
        /// <summary>
        /// Cadastra dispositivo do usu\u00E1rio
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar o dispositivo do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ControleSegurancaDispositivoResponse</returns>
        ControleSegurancaDispositivoResponse SalvarControleSegurancaDispositivo (UsuarioDispositivoPersist persist);
  
        /// <summary>
        /// Cadastra dispositivo do usu\u00E1rio
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar o dispositivo do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of ControleSegurancaDispositivoResponse</returns>
        ApiResponse<ControleSegurancaDispositivoResponse> SalvarControleSegurancaDispositivoWithHttpInfo (UsuarioDispositivoPersist persist);
        
        /// <summary>
        /// Cadastra Usu\u00E1rio na base
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar usu\u00E1rios
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>UsuarioResponse</returns>
        UsuarioResponse SalvarUsuario (UsuarioPersist persist);
  
        /// <summary>
        /// Cadastra Usu\u00E1rio na base
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar usu\u00E1rios
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of UsuarioResponse</returns>
        ApiResponse<UsuarioResponse> SalvarUsuarioWithHttpInfo (UsuarioPersist persist);
        
        /// <summary>
        /// Validar a senha do usu\u00E1rio na base do PIER ou WS
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite validar a senha do usu\u00E1rio)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">Senha do usu\u00E1rio</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <returns>string</returns>
        string ValidarSenha1 (string senha, long? id);
  
        /// <summary>
        /// Validar a senha do usu\u00E1rio na base do PIER ou WS
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite validar a senha do usu\u00E1rio)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">Senha do usu\u00E1rio</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ValidarSenha1WithHttpInfo (string senha, long? id);
        
        /// <summary>
        /// Validar senha forte do usu\u00E1rio
        /// </summary>
        /// <remarks>
        /// Este recurso permite validar se a senha do us\u00FAario \u00E9 uma senha forte
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">Senha do usu\u00E1rio</param>
        /// <param name="usuarioSenhaFortePersist">Id da plataforma</param>
        /// <returns>string</returns>
        string ValidarSenhaForte (string senha, SenhaForte usuarioSenhaFortePersist);
  
        /// <summary>
        /// Validar senha forte do usu\u00E1rio
        /// </summary>
        /// <remarks>
        /// Este recurso permite validar se a senha do us\u00FAario \u00E9 uma senha forte
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">Senha do usu\u00E1rio</param>
        /// <param name="usuarioSenhaFortePersist">Id da plataforma</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ValidarSenhaForteWithHttpInfo (string senha, SenhaForte usuarioSenhaFortePersist);
        
        /// <summary>
        /// Realiza login com valida\u00E7\u00E3o de senha dos usu\u00E1rios cadastrados na base do PIER ou WS
        /// </summary>
        /// <remarks>
        /// O recurso permite fazer login do usu\u00E1rio atrav\u00E9s da senha definida pelo emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">Login identificador do usu\u00E1rio (login)</param>
        /// <param name="senha">Senha do usu\u00E1rio</param>
        /// <param name="request">request (optional)</param>
        /// <returns>Object</returns>
        Object ValidarSenhaPorLogin (string login, string senha, ValidarSenhaLoginRequest request = null);
  
        /// <summary>
        /// Realiza login com valida\u00E7\u00E3o de senha dos usu\u00E1rios cadastrados na base do PIER ou WS
        /// </summary>
        /// <remarks>
        /// O recurso permite fazer login do usu\u00E1rio atrav\u00E9s da senha definida pelo emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">Login identificador do usu\u00E1rio (login)</param>
        /// <param name="senha">Senha do usu\u00E1rio</param>
        /// <param name="request">request (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ValidarSenhaPorLoginWithHttpInfo (string login, string senha, ValidarSenhaLoginRequest request = null);
        
        /// <summary>
        /// Associa o usu\u00E1rio \u00E1 contas existentes
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite associar um usu\u00E1rio \u00E1 contas existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <returns>string</returns>
        string VincularContas (long? id);
  
        /// <summary>
        /// Associa o usu\u00E1rio \u00E1 contas existentes
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite associar um usu\u00E1rio \u00E1 contas existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> VincularContasWithHttpInfo (long? id);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Alterar senha do usu\u00E1rio na base do PIER ou WS
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o da senha do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <param name="senhaAtual">Senha Atual</param>
        /// <param name="senhaNova">Senha Nova</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> AlterarSenha1Async (long? id, string senhaAtual, string senhaNova);

        /// <summary>
        /// Alterar senha do usu\u00E1rio na base do PIER ou WS
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o da senha do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <param name="senhaAtual">Senha Atual</param>
        /// <param name="senhaNova">Senha Nova</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> AlterarSenha1AsyncWithHttpInfo (long? id, string senhaAtual, string senhaNova);
        
        /// <summary>
        /// Alterar senha do usu\u00E1rio
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o da senha do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">Login do usu\u00E1rio</param>
        /// <param name="senhaNova">Senha Nova</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> AlterarSenhaPorLoginAsync (string login, string senhaNova);

        /// <summary>
        /// Alterar senha do usu\u00E1rio
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o da senha do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">Login do usu\u00E1rio</param>
        /// <param name="senhaNova">Senha Nova</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> AlterarSenhaPorLoginAsyncWithHttpInfo (string login, string senhaNova);
        
        /// <summary>
        /// Altera os usu\u00E1rios cadastrados na base
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o dos usu\u00E1rios
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of UsuarioResponse</returns>
        System.Threading.Tasks.Task<UsuarioResponse> AlterarUsuarioAsync (long? id, UsuarioUpdate update);

        /// <summary>
        /// Altera os usu\u00E1rios cadastrados na base
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o dos usu\u00E1rios
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> AlterarUsuarioAsyncWithHttpInfo (long? id, UsuarioUpdate update);
        
        /// <summary>
        /// Ativa os usu\u00E1rios cadastrados na base do PIER ou WS
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a ativa\u00E7\u00E3o dos usu\u00E1rios
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <returns>Task of UsuarioResponse</returns>
        System.Threading.Tasks.Task<UsuarioResponse> AtivarUsuarioAsync (long? id);

        /// <summary>
        /// Ativa os usu\u00E1rios cadastrados na base do PIER ou WS
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a ativa\u00E7\u00E3o dos usu\u00E1rios
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> AtivarUsuarioAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Atualiza dispositivo do usu\u00E1rio
        /// </summary>
        /// <remarks>
        /// Este recurso permite atualizar o dispositivo do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do controle de acesso</param>
        /// <param name="update">update</param>
        /// <returns>Task of ControleSegurancaDispositivoResponse</returns>
        System.Threading.Tasks.Task<ControleSegurancaDispositivoResponse> AtualizarControleSegurancaDispositivoAsync (long? id, UsuarioDispositivoUpdate update);

        /// <summary>
        /// Atualiza dispositivo do usu\u00E1rio
        /// </summary>
        /// <remarks>
        /// Este recurso permite atualizar o dispositivo do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do controle de acesso</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (ControleSegurancaDispositivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ControleSegurancaDispositivoResponse>> AtualizarControleSegurancaDispositivoAsyncWithHttpInfo (long? id, UsuarioDispositivoUpdate update);
        
        /// <summary>
        /// Lista as contas vinculadas ao usu\u00E1rio
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as contas vinculadas ao usu\u00E1rio por ID
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID do usu\u00E1rio</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageUsuarioContasResponse</returns>
        System.Threading.Tasks.Task<PageUsuarioContasResponse> ConsultarContasVinculadasAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista as contas vinculadas ao usu\u00E1rio
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as contas vinculadas ao usu\u00E1rio por ID
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID do usu\u00E1rio</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageUsuarioContasResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageUsuarioContasResponse>> ConsultarContasVinculadasAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Consulta dispositivo do usu\u00E1rio
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar o dispositivo do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idUsuario">idUsuario</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageControleSegurancaDispositivoResponse</returns>
        System.Threading.Tasks.Task<PageControleSegurancaDispositivoResponse> ConsultarControleSegurancaDispositivoAsync (long? idUsuario, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Consulta dispositivo do usu\u00E1rio
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar o dispositivo do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idUsuario">idUsuario</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageControleSegurancaDispositivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageControleSegurancaDispositivoResponse>> ConsultarControleSegurancaDispositivoAsyncWithHttpInfo (long? idUsuario, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Apresenta os dados de um determinado Usu\u00E1rio na base do PIER ou WS
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar as informa\u00E7\u00F5es de um determinado Usu\u00E1rio a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do us\u00E1rio para consultar</param>
        /// <returns>Task of UsuarioResponse</returns>
        System.Threading.Tasks.Task<UsuarioResponse> ConsultarUsuarioAsync (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Usu\u00E1rio na base do PIER ou WS
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar as informa\u00E7\u00F5es de um determinado Usu\u00E1rio a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do us\u00E1rio para consultar</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> ConsultarUsuarioAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Remove o dispositivo do usu\u00E1rio
        /// </summary>
        /// <remarks>
        /// Este recurso permite remover o dispositivo do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do controle de acesso</param>
        /// <returns>Task of ControleSegurancaDispositivoResponse</returns>
        System.Threading.Tasks.Task<ControleSegurancaDispositivoResponse> DeletarControleSegurancaAsync (long? id);

        /// <summary>
        /// Remove o dispositivo do usu\u00E1rio
        /// </summary>
        /// <remarks>
        /// Este recurso permite remover o dispositivo do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do controle de acesso</param>
        /// <returns>Task of ApiResponse (ControleSegurancaDispositivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ControleSegurancaDispositivoResponse>> DeletarControleSegurancaAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Desativa os usu\u00E1rios cadastrados na base do PIER ou WS
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a desativa\u00E7\u00E3o dos usu\u00E1rios
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <returns>Task of UsuarioResponse</returns>
        System.Threading.Tasks.Task<UsuarioResponse> DesativarUsuarioAsync (long? id);

        /// <summary>
        /// Desativa os usu\u00E1rios cadastrados na base do PIER ou WS
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a desativa\u00E7\u00E3o dos usu\u00E1rios
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> DesativarUsuarioAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista os Usu\u00E1rios cadastrados na base do PIER ou WS
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os usu\u00E1rios existentes na base do PIER
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do Usuario (optional)</param>
        /// <param name="cpf">CPF do Usuario (optional)</param>
        /// <param name="email">Email do Usuario (optional)</param>
        /// <param name="status">Status do Usuario (optional)</param>
        /// <returns>Task of PageUsuarioResponse</returns>
        System.Threading.Tasks.Task<PageUsuarioResponse> ListarUsuariosAsync (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string cpf = null, string email = null, string status = null);

        /// <summary>
        /// Lista os Usu\u00E1rios cadastrados na base do PIER ou WS
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os usu\u00E1rios existentes na base do PIER
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do Usuario (optional)</param>
        /// <param name="cpf">CPF do Usuario (optional)</param>
        /// <param name="email">Email do Usuario (optional)</param>
        /// <param name="status">Status do Usuario (optional)</param>
        /// <returns>Task of ApiResponse (PageUsuarioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageUsuarioResponse>> ListarUsuariosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string cpf = null, string email = null, string status = null);
        
        /// <summary>
        /// Recuperar senha do usu\u00E1rio na base do PIER ou WS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite recuperar a senha do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> RecuperarSenhaAsync (long? id);

        /// <summary>
        /// Recuperar senha do usu\u00E1rio na base do PIER ou WS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite recuperar a senha do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> RecuperarSenhaAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Cadastra dispositivo do usu\u00E1rio
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar o dispositivo do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ControleSegurancaDispositivoResponse</returns>
        System.Threading.Tasks.Task<ControleSegurancaDispositivoResponse> SalvarControleSegurancaDispositivoAsync (UsuarioDispositivoPersist persist);

        /// <summary>
        /// Cadastra dispositivo do usu\u00E1rio
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar o dispositivo do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (ControleSegurancaDispositivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ControleSegurancaDispositivoResponse>> SalvarControleSegurancaDispositivoAsyncWithHttpInfo (UsuarioDispositivoPersist persist);
        
        /// <summary>
        /// Cadastra Usu\u00E1rio na base
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar usu\u00E1rios
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of UsuarioResponse</returns>
        System.Threading.Tasks.Task<UsuarioResponse> SalvarUsuarioAsync (UsuarioPersist persist);

        /// <summary>
        /// Cadastra Usu\u00E1rio na base
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar usu\u00E1rios
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> SalvarUsuarioAsyncWithHttpInfo (UsuarioPersist persist);
        
        /// <summary>
        /// Validar a senha do usu\u00E1rio na base do PIER ou WS
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite validar a senha do usu\u00E1rio)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">Senha do usu\u00E1rio</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ValidarSenha1Async (string senha, long? id);

        /// <summary>
        /// Validar a senha do usu\u00E1rio na base do PIER ou WS
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite validar a senha do usu\u00E1rio)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">Senha do usu\u00E1rio</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ValidarSenha1AsyncWithHttpInfo (string senha, long? id);
        
        /// <summary>
        /// Validar senha forte do usu\u00E1rio
        /// </summary>
        /// <remarks>
        /// Este recurso permite validar se a senha do us\u00FAario \u00E9 uma senha forte
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">Senha do usu\u00E1rio</param>
        /// <param name="usuarioSenhaFortePersist">Id da plataforma</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ValidarSenhaForteAsync (string senha, SenhaForte usuarioSenhaFortePersist);

        /// <summary>
        /// Validar senha forte do usu\u00E1rio
        /// </summary>
        /// <remarks>
        /// Este recurso permite validar se a senha do us\u00FAario \u00E9 uma senha forte
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">Senha do usu\u00E1rio</param>
        /// <param name="usuarioSenhaFortePersist">Id da plataforma</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ValidarSenhaForteAsyncWithHttpInfo (string senha, SenhaForte usuarioSenhaFortePersist);
        
        /// <summary>
        /// Realiza login com valida\u00E7\u00E3o de senha dos usu\u00E1rios cadastrados na base do PIER ou WS
        /// </summary>
        /// <remarks>
        /// O recurso permite fazer login do usu\u00E1rio atrav\u00E9s da senha definida pelo emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">Login identificador do usu\u00E1rio (login)</param>
        /// <param name="senha">Senha do usu\u00E1rio</param>
        /// <param name="request">request (optional)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ValidarSenhaPorLoginAsync (string login, string senha, ValidarSenhaLoginRequest request = null);

        /// <summary>
        /// Realiza login com valida\u00E7\u00E3o de senha dos usu\u00E1rios cadastrados na base do PIER ou WS
        /// </summary>
        /// <remarks>
        /// O recurso permite fazer login do usu\u00E1rio atrav\u00E9s da senha definida pelo emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">Login identificador do usu\u00E1rio (login)</param>
        /// <param name="senha">Senha do usu\u00E1rio</param>
        /// <param name="request">request (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ValidarSenhaPorLoginAsyncWithHttpInfo (string login, string senha, ValidarSenhaLoginRequest request = null);
        
        /// <summary>
        /// Associa o usu\u00E1rio \u00E1 contas existentes
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite associar um usu\u00E1rio \u00E1 contas existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> VincularContasAsync (long? id);

        /// <summary>
        /// Associa o usu\u00E1rio \u00E1 contas existentes
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite associar um usu\u00E1rio \u00E1 contas existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> VincularContasAsyncWithHttpInfo (long? id);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UsuarioApi : IUsuarioApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsuarioApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsuarioApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsuarioApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UsuarioApi(Configuration configuration = null)
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
        /// Alterar senha do usu\u00E1rio na base do PIER ou WS Este m\u00E9todo realiza a altera\u00E7\u00E3o da senha do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param> 
        /// <param name="senhaAtual">Senha Atual</param> 
        /// <param name="senhaNova">Senha Nova</param> 
        /// <returns>string</returns>
        public string AlterarSenha1 (long? id, string senhaAtual, string senhaNova)
        {
             ApiResponse<string> localVarResponse = AlterarSenha1WithHttpInfo(id, senhaAtual, senhaNova);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar senha do usu\u00E1rio na base do PIER ou WS Este m\u00E9todo realiza a altera\u00E7\u00E3o da senha do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param> 
        /// <param name="senhaAtual">Senha Atual</param> 
        /// <param name="senhaNova">Senha Nova</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > AlterarSenha1WithHttpInfo (long? id, string senhaAtual, string senhaNova)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling UsuarioApi->AlterarSenha1");
            
            // verify the required parameter 'senhaAtual' is set
            if (senhaAtual == null)
                throw new ApiException(400, "Missing required parameter 'senhaAtual' when calling UsuarioApi->AlterarSenha1");
            
            // verify the required parameter 'senhaNova' is set
            if (senhaNova == null)
                throw new ApiException(400, "Missing required parameter 'senhaNova' when calling UsuarioApi->AlterarSenha1");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenha1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenha1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Alterar senha do usu\u00E1rio na base do PIER ou WS Este m\u00E9todo realiza a altera\u00E7\u00E3o da senha do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <param name="senhaAtual">Senha Atual</param>
        /// <param name="senhaNova">Senha Nova</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> AlterarSenha1Async (long? id, string senhaAtual, string senhaNova)
        {
             ApiResponse<string> localVarResponse = await AlterarSenha1AsyncWithHttpInfo(id, senhaAtual, senhaNova);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Alterar senha do usu\u00E1rio na base do PIER ou WS Este m\u00E9todo realiza a altera\u00E7\u00E3o da senha do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <param name="senhaAtual">Senha Atual</param>
        /// <param name="senhaNova">Senha Nova</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> AlterarSenha1AsyncWithHttpInfo (long? id, string senhaAtual, string senhaNova)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarSenha1");
            // verify the required parameter 'senhaAtual' is set
            if (senhaAtual == null) throw new ApiException(400, "Missing required parameter 'senhaAtual' when calling AlterarSenha1");
            // verify the required parameter 'senhaNova' is set
            if (senhaNova == null) throw new ApiException(400, "Missing required parameter 'senhaNova' when calling AlterarSenha1");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenha1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenha1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Alterar senha do usu\u00E1rio Este m\u00E9todo realiza a altera\u00E7\u00E3o da senha do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">Login do usu\u00E1rio</param> 
        /// <param name="senhaNova">Senha Nova</param> 
        /// <returns>string</returns>
        public string AlterarSenhaPorLogin (string login, string senhaNova)
        {
             ApiResponse<string> localVarResponse = AlterarSenhaPorLoginWithHttpInfo(login, senhaNova);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar senha do usu\u00E1rio Este m\u00E9todo realiza a altera\u00E7\u00E3o da senha do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">Login do usu\u00E1rio</param> 
        /// <param name="senhaNova">Senha Nova</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > AlterarSenhaPorLoginWithHttpInfo (string login, string senhaNova)
        {
            
            // verify the required parameter 'login' is set
            if (login == null)
                throw new ApiException(400, "Missing required parameter 'login' when calling UsuarioApi->AlterarSenhaPorLogin");
            
            // verify the required parameter 'senhaNova' is set
            if (senhaNova == null)
                throw new ApiException(400, "Missing required parameter 'senhaNova' when calling UsuarioApi->AlterarSenhaPorLogin");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenhaPorLogin: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenhaPorLogin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Alterar senha do usu\u00E1rio Este m\u00E9todo realiza a altera\u00E7\u00E3o da senha do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">Login do usu\u00E1rio</param>
        /// <param name="senhaNova">Senha Nova</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> AlterarSenhaPorLoginAsync (string login, string senhaNova)
        {
             ApiResponse<string> localVarResponse = await AlterarSenhaPorLoginAsyncWithHttpInfo(login, senhaNova);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Alterar senha do usu\u00E1rio Este m\u00E9todo realiza a altera\u00E7\u00E3o da senha do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">Login do usu\u00E1rio</param>
        /// <param name="senhaNova">Senha Nova</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> AlterarSenhaPorLoginAsyncWithHttpInfo (string login, string senhaNova)
        {
            // verify the required parameter 'login' is set
            if (login == null) throw new ApiException(400, "Missing required parameter 'login' when calling AlterarSenhaPorLogin");
            // verify the required parameter 'senhaNova' is set
            if (senhaNova == null) throw new ApiException(400, "Missing required parameter 'senhaNova' when calling AlterarSenhaPorLogin");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenhaPorLogin: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenhaPorLogin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Altera os usu\u00E1rios cadastrados na base Este m\u00E9todo realiza a altera\u00E7\u00E3o dos usu\u00E1rios
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param> 
        /// <param name="update">update</param> 
        /// <returns>UsuarioResponse</returns>
        public UsuarioResponse AlterarUsuario (long? id, UsuarioUpdate update)
        {
             ApiResponse<UsuarioResponse> localVarResponse = AlterarUsuarioWithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera os usu\u00E1rios cadastrados na base Este m\u00E9todo realiza a altera\u00E7\u00E3o dos usu\u00E1rios
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of UsuarioResponse</returns>
        public ApiResponse< UsuarioResponse > AlterarUsuarioWithHttpInfo (long? id, UsuarioUpdate update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling UsuarioApi->AlterarUsuario");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling UsuarioApi->AlterarUsuario");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsuario: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsuario: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }

        
        /// <summary>
        /// Altera os usu\u00E1rios cadastrados na base Este m\u00E9todo realiza a altera\u00E7\u00E3o dos usu\u00E1rios
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of UsuarioResponse</returns>
        public async System.Threading.Tasks.Task<UsuarioResponse> AlterarUsuarioAsync (long? id, UsuarioUpdate update)
        {
             ApiResponse<UsuarioResponse> localVarResponse = await AlterarUsuarioAsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera os usu\u00E1rios cadastrados na base Este m\u00E9todo realiza a altera\u00E7\u00E3o dos usu\u00E1rios
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> AlterarUsuarioAsyncWithHttpInfo (long? id, UsuarioUpdate update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsuario");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AlterarUsuario");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsuario: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsuario: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }
        
        /// <summary>
        /// Ativa os usu\u00E1rios cadastrados na base do PIER ou WS Este m\u00E9todo realiza a ativa\u00E7\u00E3o dos usu\u00E1rios
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param> 
        /// <returns>UsuarioResponse</returns>
        public UsuarioResponse AtivarUsuario (long? id)
        {
             ApiResponse<UsuarioResponse> localVarResponse = AtivarUsuarioWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Ativa os usu\u00E1rios cadastrados na base do PIER ou WS Este m\u00E9todo realiza a ativa\u00E7\u00E3o dos usu\u00E1rios
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param> 
        /// <returns>ApiResponse of UsuarioResponse</returns>
        public ApiResponse< UsuarioResponse > AtivarUsuarioWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling UsuarioApi->AtivarUsuario");
            
    
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
        /// Ativa os usu\u00E1rios cadastrados na base do PIER ou WS Este m\u00E9todo realiza a ativa\u00E7\u00E3o dos usu\u00E1rios
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <returns>Task of UsuarioResponse</returns>
        public async System.Threading.Tasks.Task<UsuarioResponse> AtivarUsuarioAsync (long? id)
        {
             ApiResponse<UsuarioResponse> localVarResponse = await AtivarUsuarioAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Ativa os usu\u00E1rios cadastrados na base do PIER ou WS Este m\u00E9todo realiza a ativa\u00E7\u00E3o dos usu\u00E1rios
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
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
        /// Atualiza dispositivo do usu\u00E1rio Este recurso permite atualizar o dispositivo do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do controle de acesso</param> 
        /// <param name="update">update</param> 
        /// <returns>ControleSegurancaDispositivoResponse</returns>
        public ControleSegurancaDispositivoResponse AtualizarControleSegurancaDispositivo (long? id, UsuarioDispositivoUpdate update)
        {
             ApiResponse<ControleSegurancaDispositivoResponse> localVarResponse = AtualizarControleSegurancaDispositivoWithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualiza dispositivo do usu\u00E1rio Este recurso permite atualizar o dispositivo do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do controle de acesso</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of ControleSegurancaDispositivoResponse</returns>
        public ApiResponse< ControleSegurancaDispositivoResponse > AtualizarControleSegurancaDispositivoWithHttpInfo (long? id, UsuarioDispositivoUpdate update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling UsuarioApi->AtualizarControleSegurancaDispositivo");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling UsuarioApi->AtualizarControleSegurancaDispositivo");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtualizarControleSegurancaDispositivo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarControleSegurancaDispositivo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ControleSegurancaDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleSegurancaDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleSegurancaDispositivoResponse)));
            
        }

        
        /// <summary>
        /// Atualiza dispositivo do usu\u00E1rio Este recurso permite atualizar o dispositivo do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do controle de acesso</param>
        /// <param name="update">update</param>
        /// <returns>Task of ControleSegurancaDispositivoResponse</returns>
        public async System.Threading.Tasks.Task<ControleSegurancaDispositivoResponse> AtualizarControleSegurancaDispositivoAsync (long? id, UsuarioDispositivoUpdate update)
        {
             ApiResponse<ControleSegurancaDispositivoResponse> localVarResponse = await AtualizarControleSegurancaDispositivoAsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualiza dispositivo do usu\u00E1rio Este recurso permite atualizar o dispositivo do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do controle de acesso</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (ControleSegurancaDispositivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ControleSegurancaDispositivoResponse>> AtualizarControleSegurancaDispositivoAsyncWithHttpInfo (long? id, UsuarioDispositivoUpdate update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarControleSegurancaDispositivo");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AtualizarControleSegurancaDispositivo");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtualizarControleSegurancaDispositivo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarControleSegurancaDispositivo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ControleSegurancaDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleSegurancaDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleSegurancaDispositivoResponse)));
            
        }
        
        /// <summary>
        /// Lista as contas vinculadas ao usu\u00E1rio Este recurso permite listar as contas vinculadas ao usu\u00E1rio por ID
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID do usu\u00E1rio</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageUsuarioContasResponse</returns>
        public PageUsuarioContasResponse ConsultarContasVinculadas (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageUsuarioContasResponse> localVarResponse = ConsultarContasVinculadasWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as contas vinculadas ao usu\u00E1rio Este recurso permite listar as contas vinculadas ao usu\u00E1rio por ID
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID do usu\u00E1rio</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageUsuarioContasResponse</returns>
        public ApiResponse< PageUsuarioContasResponse > ConsultarContasVinculadasWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling UsuarioApi->ConsultarContasVinculadas");
            
    
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
        /// Lista as contas vinculadas ao usu\u00E1rio Este recurso permite listar as contas vinculadas ao usu\u00E1rio por ID
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID do usu\u00E1rio</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageUsuarioContasResponse</returns>
        public async System.Threading.Tasks.Task<PageUsuarioContasResponse> ConsultarContasVinculadasAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageUsuarioContasResponse> localVarResponse = await ConsultarContasVinculadasAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as contas vinculadas ao usu\u00E1rio Este recurso permite listar as contas vinculadas ao usu\u00E1rio por ID
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID do usu\u00E1rio</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
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
        /// Consulta dispositivo do usu\u00E1rio Este m\u00E9todo permite consultar o dispositivo do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idUsuario">idUsuario</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageControleSegurancaDispositivoResponse</returns>
        public PageControleSegurancaDispositivoResponse ConsultarControleSegurancaDispositivo (long? idUsuario, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageControleSegurancaDispositivoResponse> localVarResponse = ConsultarControleSegurancaDispositivoWithHttpInfo(idUsuario, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta dispositivo do usu\u00E1rio Este m\u00E9todo permite consultar o dispositivo do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idUsuario">idUsuario</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageControleSegurancaDispositivoResponse</returns>
        public ApiResponse< PageControleSegurancaDispositivoResponse > ConsultarControleSegurancaDispositivoWithHttpInfo (long? idUsuario, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'idUsuario' is set
            if (idUsuario == null)
                throw new ApiException(400, "Missing required parameter 'idUsuario' when calling UsuarioApi->ConsultarControleSegurancaDispositivo");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarControleSegurancaDispositivo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarControleSegurancaDispositivo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageControleSegurancaDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageControleSegurancaDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageControleSegurancaDispositivoResponse)));
            
        }

        
        /// <summary>
        /// Consulta dispositivo do usu\u00E1rio Este m\u00E9todo permite consultar o dispositivo do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idUsuario">idUsuario</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageControleSegurancaDispositivoResponse</returns>
        public async System.Threading.Tasks.Task<PageControleSegurancaDispositivoResponse> ConsultarControleSegurancaDispositivoAsync (long? idUsuario, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageControleSegurancaDispositivoResponse> localVarResponse = await ConsultarControleSegurancaDispositivoAsyncWithHttpInfo(idUsuario, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta dispositivo do usu\u00E1rio Este m\u00E9todo permite consultar o dispositivo do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idUsuario">idUsuario</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageControleSegurancaDispositivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageControleSegurancaDispositivoResponse>> ConsultarControleSegurancaDispositivoAsyncWithHttpInfo (long? idUsuario, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'idUsuario' is set
            if (idUsuario == null) throw new ApiException(400, "Missing required parameter 'idUsuario' when calling ConsultarControleSegurancaDispositivo");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarControleSegurancaDispositivo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarControleSegurancaDispositivo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageControleSegurancaDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageControleSegurancaDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageControleSegurancaDispositivoResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado Usu\u00E1rio na base do PIER ou WS Este m\u00E9todo permite consultar as informa\u00E7\u00F5es de um determinado Usu\u00E1rio a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do us\u00E1rio para consultar</param> 
        /// <returns>UsuarioResponse</returns>
        public UsuarioResponse ConsultarUsuario (long? id)
        {
             ApiResponse<UsuarioResponse> localVarResponse = ConsultarUsuarioWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Usu\u00E1rio na base do PIER ou WS Este m\u00E9todo permite consultar as informa\u00E7\u00F5es de um determinado Usu\u00E1rio a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do us\u00E1rio para consultar</param> 
        /// <returns>ApiResponse of UsuarioResponse</returns>
        public ApiResponse< UsuarioResponse > ConsultarUsuarioWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling UsuarioApi->ConsultarUsuario");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsuario: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsuario: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Usu\u00E1rio na base do PIER ou WS Este m\u00E9todo permite consultar as informa\u00E7\u00F5es de um determinado Usu\u00E1rio a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do us\u00E1rio para consultar</param>
        /// <returns>Task of UsuarioResponse</returns>
        public async System.Threading.Tasks.Task<UsuarioResponse> ConsultarUsuarioAsync (long? id)
        {
             ApiResponse<UsuarioResponse> localVarResponse = await ConsultarUsuarioAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Usu\u00E1rio na base do PIER ou WS Este m\u00E9todo permite consultar as informa\u00E7\u00F5es de um determinado Usu\u00E1rio a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do us\u00E1rio para consultar</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> ConsultarUsuarioAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsuario");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsuario: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsuario: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }
        
        /// <summary>
        /// Remove o dispositivo do usu\u00E1rio Este recurso permite remover o dispositivo do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do controle de acesso</param> 
        /// <returns>ControleSegurancaDispositivoResponse</returns>
        public ControleSegurancaDispositivoResponse DeletarControleSeguranca (long? id)
        {
             ApiResponse<ControleSegurancaDispositivoResponse> localVarResponse = DeletarControleSegurancaWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Remove o dispositivo do usu\u00E1rio Este recurso permite remover o dispositivo do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do controle de acesso</param> 
        /// <returns>ApiResponse of ControleSegurancaDispositivoResponse</returns>
        public ApiResponse< ControleSegurancaDispositivoResponse > DeletarControleSegurancaWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling UsuarioApi->DeletarControleSeguranca");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling DeletarControleSeguranca: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletarControleSeguranca: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ControleSegurancaDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleSegurancaDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleSegurancaDispositivoResponse)));
            
        }

        
        /// <summary>
        /// Remove o dispositivo do usu\u00E1rio Este recurso permite remover o dispositivo do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do controle de acesso</param>
        /// <returns>Task of ControleSegurancaDispositivoResponse</returns>
        public async System.Threading.Tasks.Task<ControleSegurancaDispositivoResponse> DeletarControleSegurancaAsync (long? id)
        {
             ApiResponse<ControleSegurancaDispositivoResponse> localVarResponse = await DeletarControleSegurancaAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Remove o dispositivo do usu\u00E1rio Este recurso permite remover o dispositivo do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do controle de acesso</param>
        /// <returns>Task of ApiResponse (ControleSegurancaDispositivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ControleSegurancaDispositivoResponse>> DeletarControleSegurancaAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeletarControleSeguranca");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling DeletarControleSeguranca: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletarControleSeguranca: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ControleSegurancaDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleSegurancaDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleSegurancaDispositivoResponse)));
            
        }
        
        /// <summary>
        /// Desativa os usu\u00E1rios cadastrados na base do PIER ou WS Este m\u00E9todo realiza a desativa\u00E7\u00E3o dos usu\u00E1rios
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param> 
        /// <returns>UsuarioResponse</returns>
        public UsuarioResponse DesativarUsuario (long? id)
        {
             ApiResponse<UsuarioResponse> localVarResponse = DesativarUsuarioWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Desativa os usu\u00E1rios cadastrados na base do PIER ou WS Este m\u00E9todo realiza a desativa\u00E7\u00E3o dos usu\u00E1rios
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param> 
        /// <returns>ApiResponse of UsuarioResponse</returns>
        public ApiResponse< UsuarioResponse > DesativarUsuarioWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling UsuarioApi->DesativarUsuario");
            
    
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
        /// Desativa os usu\u00E1rios cadastrados na base do PIER ou WS Este m\u00E9todo realiza a desativa\u00E7\u00E3o dos usu\u00E1rios
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <returns>Task of UsuarioResponse</returns>
        public async System.Threading.Tasks.Task<UsuarioResponse> DesativarUsuarioAsync (long? id)
        {
             ApiResponse<UsuarioResponse> localVarResponse = await DesativarUsuarioAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Desativa os usu\u00E1rios cadastrados na base do PIER ou WS Este m\u00E9todo realiza a desativa\u00E7\u00E3o dos usu\u00E1rios
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
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
        /// Lista os Usu\u00E1rios cadastrados na base do PIER ou WS Este m\u00E9todo permite que sejam listados os usu\u00E1rios existentes na base do PIER
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="nome">Nome do Usuario (optional)</param> 
        /// <param name="cpf">CPF do Usuario (optional)</param> 
        /// <param name="email">Email do Usuario (optional)</param> 
        /// <param name="status">Status do Usuario (optional)</param> 
        /// <returns>PageUsuarioResponse</returns>
        public PageUsuarioResponse ListarUsuarios (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string cpf = null, string email = null, string status = null)
        {
             ApiResponse<PageUsuarioResponse> localVarResponse = ListarUsuariosWithHttpInfo(sort, page, limit, nome, cpf, email, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Usu\u00E1rios cadastrados na base do PIER ou WS Este m\u00E9todo permite que sejam listados os usu\u00E1rios existentes na base do PIER
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="nome">Nome do Usuario (optional)</param> 
        /// <param name="cpf">CPF do Usuario (optional)</param> 
        /// <param name="email">Email do Usuario (optional)</param> 
        /// <param name="status">Status do Usuario (optional)</param> 
        /// <returns>ApiResponse of PageUsuarioResponse</returns>
        public ApiResponse< PageUsuarioResponse > ListarUsuariosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string cpf = null, string email = null, string status = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsuarios: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsuarios: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageUsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageUsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageUsuarioResponse)));
            
        }

        
        /// <summary>
        /// Lista os Usu\u00E1rios cadastrados na base do PIER ou WS Este m\u00E9todo permite que sejam listados os usu\u00E1rios existentes na base do PIER
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do Usuario (optional)</param>
        /// <param name="cpf">CPF do Usuario (optional)</param>
        /// <param name="email">Email do Usuario (optional)</param>
        /// <param name="status">Status do Usuario (optional)</param>
        /// <returns>Task of PageUsuarioResponse</returns>
        public async System.Threading.Tasks.Task<PageUsuarioResponse> ListarUsuariosAsync (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string cpf = null, string email = null, string status = null)
        {
             ApiResponse<PageUsuarioResponse> localVarResponse = await ListarUsuariosAsyncWithHttpInfo(sort, page, limit, nome, cpf, email, status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Usu\u00E1rios cadastrados na base do PIER ou WS Este m\u00E9todo permite que sejam listados os usu\u00E1rios existentes na base do PIER
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do Usuario (optional)</param>
        /// <param name="cpf">CPF do Usuario (optional)</param>
        /// <param name="email">Email do Usuario (optional)</param>
        /// <param name="status">Status do Usuario (optional)</param>
        /// <returns>Task of ApiResponse (PageUsuarioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageUsuarioResponse>> ListarUsuariosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string cpf = null, string email = null, string status = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsuarios: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsuarios: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageUsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageUsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageUsuarioResponse)));
            
        }
        
        /// <summary>
        /// Recuperar senha do usu\u00E1rio na base do PIER ou WS Esse recurso permite recuperar a senha do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param> 
        /// <returns>string</returns>
        public string RecuperarSenha (long? id)
        {
             ApiResponse<string> localVarResponse = RecuperarSenhaWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Recuperar senha do usu\u00E1rio na base do PIER ou WS Esse recurso permite recuperar a senha do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > RecuperarSenhaWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling UsuarioApi->RecuperarSenha");
            
    
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
        /// Recuperar senha do usu\u00E1rio na base do PIER ou WS Esse recurso permite recuperar a senha do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> RecuperarSenhaAsync (long? id)
        {
             ApiResponse<string> localVarResponse = await RecuperarSenhaAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Recuperar senha do usu\u00E1rio na base do PIER ou WS Esse recurso permite recuperar a senha do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
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
        /// Cadastra dispositivo do usu\u00E1rio Este recurso permite cadastrar o dispositivo do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ControleSegurancaDispositivoResponse</returns>
        public ControleSegurancaDispositivoResponse SalvarControleSegurancaDispositivo (UsuarioDispositivoPersist persist)
        {
             ApiResponse<ControleSegurancaDispositivoResponse> localVarResponse = SalvarControleSegurancaDispositivoWithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastra dispositivo do usu\u00E1rio Este recurso permite cadastrar o dispositivo do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of ControleSegurancaDispositivoResponse</returns>
        public ApiResponse< ControleSegurancaDispositivoResponse > SalvarControleSegurancaDispositivoWithHttpInfo (UsuarioDispositivoPersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling UsuarioApi->SalvarControleSegurancaDispositivo");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarControleSegurancaDispositivo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarControleSegurancaDispositivo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ControleSegurancaDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleSegurancaDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleSegurancaDispositivoResponse)));
            
        }

        
        /// <summary>
        /// Cadastra dispositivo do usu\u00E1rio Este recurso permite cadastrar o dispositivo do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ControleSegurancaDispositivoResponse</returns>
        public async System.Threading.Tasks.Task<ControleSegurancaDispositivoResponse> SalvarControleSegurancaDispositivoAsync (UsuarioDispositivoPersist persist)
        {
             ApiResponse<ControleSegurancaDispositivoResponse> localVarResponse = await SalvarControleSegurancaDispositivoAsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastra dispositivo do usu\u00E1rio Este recurso permite cadastrar o dispositivo do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (ControleSegurancaDispositivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ControleSegurancaDispositivoResponse>> SalvarControleSegurancaDispositivoAsyncWithHttpInfo (UsuarioDispositivoPersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarControleSegurancaDispositivo");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarControleSegurancaDispositivo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarControleSegurancaDispositivo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ControleSegurancaDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleSegurancaDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleSegurancaDispositivoResponse)));
            
        }
        
        /// <summary>
        /// Cadastra Usu\u00E1rio na base Esse recurso permite cadastrar usu\u00E1rios
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>UsuarioResponse</returns>
        public UsuarioResponse SalvarUsuario (UsuarioPersist persist)
        {
             ApiResponse<UsuarioResponse> localVarResponse = SalvarUsuarioWithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastra Usu\u00E1rio na base Esse recurso permite cadastrar usu\u00E1rios
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of UsuarioResponse</returns>
        public ApiResponse< UsuarioResponse > SalvarUsuarioWithHttpInfo (UsuarioPersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling UsuarioApi->SalvarUsuario");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsuario: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsuario: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }

        
        /// <summary>
        /// Cadastra Usu\u00E1rio na base Esse recurso permite cadastrar usu\u00E1rios
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of UsuarioResponse</returns>
        public async System.Threading.Tasks.Task<UsuarioResponse> SalvarUsuarioAsync (UsuarioPersist persist)
        {
             ApiResponse<UsuarioResponse> localVarResponse = await SalvarUsuarioAsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastra Usu\u00E1rio na base Esse recurso permite cadastrar usu\u00E1rios
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> SalvarUsuarioAsyncWithHttpInfo (UsuarioPersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarUsuario");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsuario: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsuario: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }
        
        /// <summary>
        /// Validar a senha do usu\u00E1rio na base do PIER ou WS Este m\u00E9todo permite validar a senha do usu\u00E1rio)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">Senha do usu\u00E1rio</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param> 
        /// <returns>string</returns>
        public string ValidarSenha1 (string senha, long? id)
        {
             ApiResponse<string> localVarResponse = ValidarSenha1WithHttpInfo(senha, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Validar a senha do usu\u00E1rio na base do PIER ou WS Este m\u00E9todo permite validar a senha do usu\u00E1rio)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">Senha do usu\u00E1rio</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ValidarSenha1WithHttpInfo (string senha, long? id)
        {
            
            // verify the required parameter 'senha' is set
            if (senha == null)
                throw new ApiException(400, "Missing required parameter 'senha' when calling UsuarioApi->ValidarSenha1");
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling UsuarioApi->ValidarSenha1");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenha1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenha1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Validar a senha do usu\u00E1rio na base do PIER ou WS Este m\u00E9todo permite validar a senha do usu\u00E1rio)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">Senha do usu\u00E1rio</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ValidarSenha1Async (string senha, long? id)
        {
             ApiResponse<string> localVarResponse = await ValidarSenha1AsyncWithHttpInfo(senha, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Validar a senha do usu\u00E1rio na base do PIER ou WS Este m\u00E9todo permite validar a senha do usu\u00E1rio)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">Senha do usu\u00E1rio</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ValidarSenha1AsyncWithHttpInfo (string senha, long? id)
        {
            // verify the required parameter 'senha' is set
            if (senha == null) throw new ApiException(400, "Missing required parameter 'senha' when calling ValidarSenha1");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ValidarSenha1");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenha1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenha1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Validar senha forte do usu\u00E1rio Este recurso permite validar se a senha do us\u00FAario \u00E9 uma senha forte
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">Senha do usu\u00E1rio</param> 
        /// <param name="usuarioSenhaFortePersist">Id da plataforma</param> 
        /// <returns>string</returns>
        public string ValidarSenhaForte (string senha, SenhaForte usuarioSenhaFortePersist)
        {
             ApiResponse<string> localVarResponse = ValidarSenhaForteWithHttpInfo(senha, usuarioSenhaFortePersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Validar senha forte do usu\u00E1rio Este recurso permite validar se a senha do us\u00FAario \u00E9 uma senha forte
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">Senha do usu\u00E1rio</param> 
        /// <param name="usuarioSenhaFortePersist">Id da plataforma</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ValidarSenhaForteWithHttpInfo (string senha, SenhaForte usuarioSenhaFortePersist)
        {
            
            // verify the required parameter 'senha' is set
            if (senha == null)
                throw new ApiException(400, "Missing required parameter 'senha' when calling UsuarioApi->ValidarSenhaForte");
            
            // verify the required parameter 'usuarioSenhaFortePersist' is set
            if (usuarioSenhaFortePersist == null)
                throw new ApiException(400, "Missing required parameter 'usuarioSenhaFortePersist' when calling UsuarioApi->ValidarSenhaForte");
            
    
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
        /// Validar senha forte do usu\u00E1rio Este recurso permite validar se a senha do us\u00FAario \u00E9 uma senha forte
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">Senha do usu\u00E1rio</param>
        /// <param name="usuarioSenhaFortePersist">Id da plataforma</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ValidarSenhaForteAsync (string senha, SenhaForte usuarioSenhaFortePersist)
        {
             ApiResponse<string> localVarResponse = await ValidarSenhaForteAsyncWithHttpInfo(senha, usuarioSenhaFortePersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Validar senha forte do usu\u00E1rio Este recurso permite validar se a senha do us\u00FAario \u00E9 uma senha forte
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">Senha do usu\u00E1rio</param>
        /// <param name="usuarioSenhaFortePersist">Id da plataforma</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ValidarSenhaForteAsyncWithHttpInfo (string senha, SenhaForte usuarioSenhaFortePersist)
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
        /// Realiza login com valida\u00E7\u00E3o de senha dos usu\u00E1rios cadastrados na base do PIER ou WS O recurso permite fazer login do usu\u00E1rio atrav\u00E9s da senha definida pelo emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">Login identificador do usu\u00E1rio (login)</param> 
        /// <param name="senha">Senha do usu\u00E1rio</param> 
        /// <param name="request">request (optional)</param> 
        /// <returns>Object</returns>
        public Object ValidarSenhaPorLogin (string login, string senha, ValidarSenhaLoginRequest request = null)
        {
             ApiResponse<Object> localVarResponse = ValidarSenhaPorLoginWithHttpInfo(login, senha, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza login com valida\u00E7\u00E3o de senha dos usu\u00E1rios cadastrados na base do PIER ou WS O recurso permite fazer login do usu\u00E1rio atrav\u00E9s da senha definida pelo emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">Login identificador do usu\u00E1rio (login)</param> 
        /// <param name="senha">Senha do usu\u00E1rio</param> 
        /// <param name="request">request (optional)</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > ValidarSenhaPorLoginWithHttpInfo (string login, string senha, ValidarSenhaLoginRequest request = null)
        {
            
            // verify the required parameter 'login' is set
            if (login == null)
                throw new ApiException(400, "Missing required parameter 'login' when calling UsuarioApi->ValidarSenhaPorLogin");
            
            // verify the required parameter 'senha' is set
            if (senha == null)
                throw new ApiException(400, "Missing required parameter 'senha' when calling UsuarioApi->ValidarSenhaPorLogin");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaPorLogin: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaPorLogin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Realiza login com valida\u00E7\u00E3o de senha dos usu\u00E1rios cadastrados na base do PIER ou WS O recurso permite fazer login do usu\u00E1rio atrav\u00E9s da senha definida pelo emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">Login identificador do usu\u00E1rio (login)</param>
        /// <param name="senha">Senha do usu\u00E1rio</param>
        /// <param name="request">request (optional)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ValidarSenhaPorLoginAsync (string login, string senha, ValidarSenhaLoginRequest request = null)
        {
             ApiResponse<Object> localVarResponse = await ValidarSenhaPorLoginAsyncWithHttpInfo(login, senha, request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza login com valida\u00E7\u00E3o de senha dos usu\u00E1rios cadastrados na base do PIER ou WS O recurso permite fazer login do usu\u00E1rio atrav\u00E9s da senha definida pelo emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">Login identificador do usu\u00E1rio (login)</param>
        /// <param name="senha">Senha do usu\u00E1rio</param>
        /// <param name="request">request (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ValidarSenhaPorLoginAsyncWithHttpInfo (string login, string senha, ValidarSenhaLoginRequest request = null)
        {
            // verify the required parameter 'login' is set
            if (login == null) throw new ApiException(400, "Missing required parameter 'login' when calling ValidarSenhaPorLogin");
            // verify the required parameter 'senha' is set
            if (senha == null) throw new ApiException(400, "Missing required parameter 'senha' when calling ValidarSenhaPorLogin");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaPorLogin: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaPorLogin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Associa o usu\u00E1rio \u00E1 contas existentes Este m\u00E9todo permite associar um usu\u00E1rio \u00E1 contas existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param> 
        /// <returns>string</returns>
        public string VincularContas (long? id)
        {
             ApiResponse<string> localVarResponse = VincularContasWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Associa o usu\u00E1rio \u00E1 contas existentes Este m\u00E9todo permite associar um usu\u00E1rio \u00E1 contas existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > VincularContasWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling UsuarioApi->VincularContas");
            
    
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
        /// Associa o usu\u00E1rio \u00E1 contas existentes Este m\u00E9todo permite associar um usu\u00E1rio \u00E1 contas existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> VincularContasAsync (long? id)
        {
             ApiResponse<string> localVarResponse = await VincularContasAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Associa o usu\u00E1rio \u00E1 contas existentes Este m\u00E9todo permite associar um usu\u00E1rio \u00E1 contas existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</param>
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
