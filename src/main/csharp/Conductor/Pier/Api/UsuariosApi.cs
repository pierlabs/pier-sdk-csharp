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
    public interface IUsuariosApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Alterar senha do usu\u00C3\u00A1rio
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o da senha do usu\u00C3\u00A1rio.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param>
        /// <param name="senhaAtual">Senha Atual</param>
        /// <param name="senhaNova">Senha Nova</param>
        /// <returns>string</returns>
        string AlterarSenhaUsingPUT (long? id, string senhaAtual, string senhaNova);
  
        /// <summary>
        /// Alterar senha do usu\u00C3\u00A1rio
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o da senha do usu\u00C3\u00A1rio.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param>
        /// <param name="senhaAtual">Senha Atual</param>
        /// <param name="senhaNova">Senha Nova</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> AlterarSenhaUsingPUTWithHttpInfo (long? id, string senhaAtual, string senhaNova);
        
        /// <summary>
        /// Alterar os usu\u00C3\u00A1rios cadastrados
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos usu\u00C3\u00A1rios.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param>
        /// <param name="update">update</param>
        /// <returns>Usuario</returns>
        Usuario AlterarUsingPUT6 (long? id, Usuario update);
  
        /// <summary>
        /// Alterar os usu\u00C3\u00A1rios cadastrados
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos usu\u00C3\u00A1rios.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of Usuario</returns>
        ApiResponse<Usuario> AlterarUsingPUT6WithHttpInfo (long? id, Usuario update);
        
        /// <summary>
        /// Apresenta os dados de um determinado Usu\u00C3\u00A1rio
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es de um determinado Usu\u00C3\u00A1rio a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param>
        /// <returns>Usuario</returns>
        Usuario ConsultarUsingGET16 (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Usu\u00C3\u00A1rio
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es de um determinado Usu\u00C3\u00A1rio a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param>
        /// <returns>ApiResponse of Usuario</returns>
        ApiResponse<Usuario> ConsultarUsingGET16WithHttpInfo (long? id);
        
        /// <summary>
        /// Lista os Usu\u00C3\u00A1rios cadastrados
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os usu\u00C3\u00A1rios existentes na base do PIER.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">Id do Usuario (optional)</param>
        /// <param name="nome">Nome do Usuario (optional)</param>
        /// <param name="cpf">CPF do Usuario (optional)</param>
        /// <param name="email">Email do Usuario (optional)</param>
        /// <param name="status">Status do Usuario (optional)</param>
        /// <returns>PageUsuarios</returns>
        PageUsuarios ListarUsingGET16 (int? page = null, int? limit = null, long? id = null, string nome = null, string cpf = null, string email = null, string status = null);
  
        /// <summary>
        /// Lista os Usu\u00C3\u00A1rios cadastrados
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os usu\u00C3\u00A1rios existentes na base do PIER.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">Id do Usuario (optional)</param>
        /// <param name="nome">Nome do Usuario (optional)</param>
        /// <param name="cpf">CPF do Usuario (optional)</param>
        /// <param name="email">Email do Usuario (optional)</param>
        /// <param name="status">Status do Usuario (optional)</param>
        /// <returns>ApiResponse of PageUsuarios</returns>
        ApiResponse<PageUsuarios> ListarUsingGET16WithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null, string cpf = null, string email = null, string status = null);
        
        /// <summary>
        /// Recuperar senha do usu\u00C3\u00A1rio
        /// </summary>
        /// <remarks>
        /// Esse recurso permite recuperar a senha do usu\u00C3\u00A1rio.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param>
        /// <returns>string</returns>
        string RecuperarSenhaUsingPOST (long? id);
  
        /// <summary>
        /// Recuperar senha do usu\u00C3\u00A1rio
        /// </summary>
        /// <remarks>
        /// Esse recurso permite recuperar a senha do usu\u00C3\u00A1rio.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> RecuperarSenhaUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// Cadastrar Usu\u00C3\u00A1rio
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar usu\u00C3\u00A1rios.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Usuario</returns>
        Usuario SalvarUsingPOST6 (Usuario persist);
  
        /// <summary>
        /// Cadastrar Usu\u00C3\u00A1rio
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar usu\u00C3\u00A1rios.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of Usuario</returns>
        ApiResponse<Usuario> SalvarUsingPOST6WithHttpInfo (Usuario persist);
        
        /// <summary>
        /// Validar a senha do usu\u00C3\u00A1rio
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite validar a senha do usu\u00C3\u00A1rio).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">Senha do usu\u00C3\u00A1rio</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param>
        /// <returns>string</returns>
        string ValidarSenhaUsingGET1 (string senha, long? id);
  
        /// <summary>
        /// Validar a senha do usu\u00C3\u00A1rio
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite validar a senha do usu\u00C3\u00A1rio).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">Senha do usu\u00C3\u00A1rio</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ValidarSenhaUsingGET1WithHttpInfo (string senha, long? id);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Alterar senha do usu\u00C3\u00A1rio
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o da senha do usu\u00C3\u00A1rio.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param>
        /// <param name="senhaAtual">Senha Atual</param>
        /// <param name="senhaNova">Senha Nova</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> AlterarSenhaUsingPUTAsync (long? id, string senhaAtual, string senhaNova);

        /// <summary>
        /// Alterar senha do usu\u00C3\u00A1rio
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o da senha do usu\u00C3\u00A1rio.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param>
        /// <param name="senhaAtual">Senha Atual</param>
        /// <param name="senhaNova">Senha Nova</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> AlterarSenhaUsingPUTAsyncWithHttpInfo (long? id, string senhaAtual, string senhaNova);
        
        /// <summary>
        /// Alterar os usu\u00C3\u00A1rios cadastrados
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos usu\u00C3\u00A1rios.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param>
        /// <param name="update">update</param>
        /// <returns>Task of Usuario</returns>
        System.Threading.Tasks.Task<Usuario> AlterarUsingPUT6Async (long? id, Usuario update);

        /// <summary>
        /// Alterar os usu\u00C3\u00A1rios cadastrados
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos usu\u00C3\u00A1rios.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (Usuario)</returns>
        System.Threading.Tasks.Task<ApiResponse<Usuario>> AlterarUsingPUT6AsyncWithHttpInfo (long? id, Usuario update);
        
        /// <summary>
        /// Apresenta os dados de um determinado Usu\u00C3\u00A1rio
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es de um determinado Usu\u00C3\u00A1rio a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param>
        /// <returns>Task of Usuario</returns>
        System.Threading.Tasks.Task<Usuario> ConsultarUsingGET16Async (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Usu\u00C3\u00A1rio
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es de um determinado Usu\u00C3\u00A1rio a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param>
        /// <returns>Task of ApiResponse (Usuario)</returns>
        System.Threading.Tasks.Task<ApiResponse<Usuario>> ConsultarUsingGET16AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista os Usu\u00C3\u00A1rios cadastrados
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os usu\u00C3\u00A1rios existentes na base do PIER.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">Id do Usuario (optional)</param>
        /// <param name="nome">Nome do Usuario (optional)</param>
        /// <param name="cpf">CPF do Usuario (optional)</param>
        /// <param name="email">Email do Usuario (optional)</param>
        /// <param name="status">Status do Usuario (optional)</param>
        /// <returns>Task of PageUsuarios</returns>
        System.Threading.Tasks.Task<PageUsuarios> ListarUsingGET16Async (int? page = null, int? limit = null, long? id = null, string nome = null, string cpf = null, string email = null, string status = null);

        /// <summary>
        /// Lista os Usu\u00C3\u00A1rios cadastrados
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os usu\u00C3\u00A1rios existentes na base do PIER.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">Id do Usuario (optional)</param>
        /// <param name="nome">Nome do Usuario (optional)</param>
        /// <param name="cpf">CPF do Usuario (optional)</param>
        /// <param name="email">Email do Usuario (optional)</param>
        /// <param name="status">Status do Usuario (optional)</param>
        /// <returns>Task of ApiResponse (PageUsuarios)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageUsuarios>> ListarUsingGET16AsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null, string cpf = null, string email = null, string status = null);
        
        /// <summary>
        /// Recuperar senha do usu\u00C3\u00A1rio
        /// </summary>
        /// <remarks>
        /// Esse recurso permite recuperar a senha do usu\u00C3\u00A1rio.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> RecuperarSenhaUsingPOSTAsync (long? id);

        /// <summary>
        /// Recuperar senha do usu\u00C3\u00A1rio
        /// </summary>
        /// <remarks>
        /// Esse recurso permite recuperar a senha do usu\u00C3\u00A1rio.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> RecuperarSenhaUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Cadastrar Usu\u00C3\u00A1rio
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar usu\u00C3\u00A1rios.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of Usuario</returns>
        System.Threading.Tasks.Task<Usuario> SalvarUsingPOST6Async (Usuario persist);

        /// <summary>
        /// Cadastrar Usu\u00C3\u00A1rio
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar usu\u00C3\u00A1rios.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (Usuario)</returns>
        System.Threading.Tasks.Task<ApiResponse<Usuario>> SalvarUsingPOST6AsyncWithHttpInfo (Usuario persist);
        
        /// <summary>
        /// Validar a senha do usu\u00C3\u00A1rio
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite validar a senha do usu\u00C3\u00A1rio).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">Senha do usu\u00C3\u00A1rio</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ValidarSenhaUsingGET1Async (string senha, long? id);

        /// <summary>
        /// Validar a senha do usu\u00C3\u00A1rio
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite validar a senha do usu\u00C3\u00A1rio).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">Senha do usu\u00C3\u00A1rio</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ValidarSenhaUsingGET1AsyncWithHttpInfo (string senha, long? id);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UsuariosApi : IUsuariosApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsuariosApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsuariosApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsuariosApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UsuariosApi(Configuration configuration = null)
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
        /// Alterar senha do usu\u00C3\u00A1rio Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o da senha do usu\u00C3\u00A1rio.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param> 
        /// <param name="senhaAtual">Senha Atual</param> 
        /// <param name="senhaNova">Senha Nova</param> 
        /// <returns>string</returns>
        public string AlterarSenhaUsingPUT (long? id, string senhaAtual, string senhaNova)
        {
             ApiResponse<string> localVarResponse = AlterarSenhaUsingPUTWithHttpInfo(id, senhaAtual, senhaNova);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar senha do usu\u00C3\u00A1rio Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o da senha do usu\u00C3\u00A1rio.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param> 
        /// <param name="senhaAtual">Senha Atual</param> 
        /// <param name="senhaNova">Senha Nova</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > AlterarSenhaUsingPUTWithHttpInfo (long? id, string senhaAtual, string senhaNova)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling UsuariosApi->AlterarSenhaUsingPUT");
            
            // verify the required parameter 'senhaAtual' is set
            if (senhaAtual == null)
                throw new ApiException(400, "Missing required parameter 'senhaAtual' when calling UsuariosApi->AlterarSenhaUsingPUT");
            
            // verify the required parameter 'senhaNova' is set
            if (senhaNova == null)
                throw new ApiException(400, "Missing required parameter 'senhaNova' when calling UsuariosApi->AlterarSenhaUsingPUT");
            
    
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
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
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
        /// Alterar senha do usu\u00C3\u00A1rio Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o da senha do usu\u00C3\u00A1rio.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param>
        /// <param name="senhaAtual">Senha Atual</param>
        /// <param name="senhaNova">Senha Nova</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> AlterarSenhaUsingPUTAsync (long? id, string senhaAtual, string senhaNova)
        {
             ApiResponse<string> localVarResponse = await AlterarSenhaUsingPUTAsyncWithHttpInfo(id, senhaAtual, senhaNova);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Alterar senha do usu\u00C3\u00A1rio Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o da senha do usu\u00C3\u00A1rio.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param>
        /// <param name="senhaAtual">Senha Atual</param>
        /// <param name="senhaNova">Senha Nova</param>
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
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

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
        /// Alterar os usu\u00C3\u00A1rios cadastrados Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos usu\u00C3\u00A1rios.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param> 
        /// <param name="update">update</param> 
        /// <returns>Usuario</returns>
        public Usuario AlterarUsingPUT6 (long? id, Usuario update)
        {
             ApiResponse<Usuario> localVarResponse = AlterarUsingPUT6WithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar os usu\u00C3\u00A1rios cadastrados Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos usu\u00C3\u00A1rios.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of Usuario</returns>
        public ApiResponse< Usuario > AlterarUsingPUT6WithHttpInfo (long? id, Usuario update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling UsuariosApi->AlterarUsingPUT6");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling UsuariosApi->AlterarUsingPUT6");
            
    
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

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Usuario>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Usuario) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Usuario)));
            
        }

        
        /// <summary>
        /// Alterar os usu\u00C3\u00A1rios cadastrados Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos usu\u00C3\u00A1rios.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param>
        /// <param name="update">update</param>
        /// <returns>Task of Usuario</returns>
        public async System.Threading.Tasks.Task<Usuario> AlterarUsingPUT6Async (long? id, Usuario update)
        {
             ApiResponse<Usuario> localVarResponse = await AlterarUsingPUT6AsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Alterar os usu\u00C3\u00A1rios cadastrados Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos usu\u00C3\u00A1rios.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (Usuario)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Usuario>> AlterarUsingPUT6AsyncWithHttpInfo (long? id, Usuario update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT6");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AlterarUsingPUT6");
            
    
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

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Usuario>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Usuario) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Usuario)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado Usu\u00C3\u00A1rio Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es de um determinado Usu\u00C3\u00A1rio a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param> 
        /// <returns>Usuario</returns>
        public Usuario ConsultarUsingGET16 (long? id)
        {
             ApiResponse<Usuario> localVarResponse = ConsultarUsingGET16WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Usu\u00C3\u00A1rio Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es de um determinado Usu\u00C3\u00A1rio a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param> 
        /// <returns>ApiResponse of Usuario</returns>
        public ApiResponse< Usuario > ConsultarUsingGET16WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling UsuariosApi->ConsultarUsingGET16");
            
    
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
            
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET16: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET16: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Usuario>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Usuario) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Usuario)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Usu\u00C3\u00A1rio Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es de um determinado Usu\u00C3\u00A1rio a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param>
        /// <returns>Task of Usuario</returns>
        public async System.Threading.Tasks.Task<Usuario> ConsultarUsingGET16Async (long? id)
        {
             ApiResponse<Usuario> localVarResponse = await ConsultarUsingGET16AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Usu\u00C3\u00A1rio Este m\u00C3\u00A9todo permite consultar as informa\u00C3\u00A7\u00C3\u00B5es de um determinado Usu\u00C3\u00A1rio a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param>
        /// <returns>Task of ApiResponse (Usuario)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Usuario>> ConsultarUsingGET16AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET16");
            
    
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
            
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET16: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET16: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Usuario>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Usuario) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Usuario)));
            
        }
        
        /// <summary>
        /// Lista os Usu\u00C3\u00A1rios cadastrados Este m\u00C3\u00A9todo permite que sejam listados os usu\u00C3\u00A1rios existentes na base do PIER.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="id">Id do Usuario (optional)</param> 
        /// <param name="nome">Nome do Usuario (optional)</param> 
        /// <param name="cpf">CPF do Usuario (optional)</param> 
        /// <param name="email">Email do Usuario (optional)</param> 
        /// <param name="status">Status do Usuario (optional)</param> 
        /// <returns>PageUsuarios</returns>
        public PageUsuarios ListarUsingGET16 (int? page = null, int? limit = null, long? id = null, string nome = null, string cpf = null, string email = null, string status = null)
        {
             ApiResponse<PageUsuarios> localVarResponse = ListarUsingGET16WithHttpInfo(page, limit, id, nome, cpf, email, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Usu\u00C3\u00A1rios cadastrados Este m\u00C3\u00A9todo permite que sejam listados os usu\u00C3\u00A1rios existentes na base do PIER.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="id">Id do Usuario (optional)</param> 
        /// <param name="nome">Nome do Usuario (optional)</param> 
        /// <param name="cpf">CPF do Usuario (optional)</param> 
        /// <param name="email">Email do Usuario (optional)</param> 
        /// <param name="status">Status do Usuario (optional)</param> 
        /// <returns>ApiResponse of PageUsuarios</returns>
        public ApiResponse< PageUsuarios > ListarUsingGET16WithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null, string cpf = null, string email = null, string status = null)
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET16: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET16: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageUsuarios>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageUsuarios) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageUsuarios)));
            
        }

        
        /// <summary>
        /// Lista os Usu\u00C3\u00A1rios cadastrados Este m\u00C3\u00A9todo permite que sejam listados os usu\u00C3\u00A1rios existentes na base do PIER.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">Id do Usuario (optional)</param>
        /// <param name="nome">Nome do Usuario (optional)</param>
        /// <param name="cpf">CPF do Usuario (optional)</param>
        /// <param name="email">Email do Usuario (optional)</param>
        /// <param name="status">Status do Usuario (optional)</param>
        /// <returns>Task of PageUsuarios</returns>
        public async System.Threading.Tasks.Task<PageUsuarios> ListarUsingGET16Async (int? page = null, int? limit = null, long? id = null, string nome = null, string cpf = null, string email = null, string status = null)
        {
             ApiResponse<PageUsuarios> localVarResponse = await ListarUsingGET16AsyncWithHttpInfo(page, limit, id, nome, cpf, email, status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Usu\u00C3\u00A1rios cadastrados Este m\u00C3\u00A9todo permite que sejam listados os usu\u00C3\u00A1rios existentes na base do PIER.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">Id do Usuario (optional)</param>
        /// <param name="nome">Nome do Usuario (optional)</param>
        /// <param name="cpf">CPF do Usuario (optional)</param>
        /// <param name="email">Email do Usuario (optional)</param>
        /// <param name="status">Status do Usuario (optional)</param>
        /// <returns>Task of ApiResponse (PageUsuarios)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageUsuarios>> ListarUsingGET16AsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null, string cpf = null, string email = null, string status = null)
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET16: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET16: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageUsuarios>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageUsuarios) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageUsuarios)));
            
        }
        
        /// <summary>
        /// Recuperar senha do usu\u00C3\u00A1rio Esse recurso permite recuperar a senha do usu\u00C3\u00A1rio.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param> 
        /// <returns>string</returns>
        public string RecuperarSenhaUsingPOST (long? id)
        {
             ApiResponse<string> localVarResponse = RecuperarSenhaUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Recuperar senha do usu\u00C3\u00A1rio Esse recurso permite recuperar a senha do usu\u00C3\u00A1rio.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > RecuperarSenhaUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling UsuariosApi->RecuperarSenhaUsingPOST");
            
    
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
            
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
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
        /// Recuperar senha do usu\u00C3\u00A1rio Esse recurso permite recuperar a senha do usu\u00C3\u00A1rio.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> RecuperarSenhaUsingPOSTAsync (long? id)
        {
             ApiResponse<string> localVarResponse = await RecuperarSenhaUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Recuperar senha do usu\u00C3\u00A1rio Esse recurso permite recuperar a senha do usu\u00C3\u00A1rio.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param>
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
            
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

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
        /// Cadastrar Usu\u00C3\u00A1rio Esse recurso permite cadastrar usu\u00C3\u00A1rios.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>Usuario</returns>
        public Usuario SalvarUsingPOST6 (Usuario persist)
        {
             ApiResponse<Usuario> localVarResponse = SalvarUsingPOST6WithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastrar Usu\u00C3\u00A1rio Esse recurso permite cadastrar usu\u00C3\u00A1rios.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of Usuario</returns>
        public ApiResponse< Usuario > SalvarUsingPOST6WithHttpInfo (Usuario persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling UsuariosApi->SalvarUsingPOST6");
            
    
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

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
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
    
            return new ApiResponse<Usuario>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Usuario) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Usuario)));
            
        }

        
        /// <summary>
        /// Cadastrar Usu\u00C3\u00A1rio Esse recurso permite cadastrar usu\u00C3\u00A1rios.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of Usuario</returns>
        public async System.Threading.Tasks.Task<Usuario> SalvarUsingPOST6Async (Usuario persist)
        {
             ApiResponse<Usuario> localVarResponse = await SalvarUsingPOST6AsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastrar Usu\u00C3\u00A1rio Esse recurso permite cadastrar usu\u00C3\u00A1rios.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (Usuario)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Usuario>> SalvarUsingPOST6AsyncWithHttpInfo (Usuario persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarUsingPOST6");
            
    
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

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
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

            return new ApiResponse<Usuario>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Usuario) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Usuario)));
            
        }
        
        /// <summary>
        /// Validar a senha do usu\u00C3\u00A1rio Este m\u00C3\u00A9todo permite validar a senha do usu\u00C3\u00A1rio).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">Senha do usu\u00C3\u00A1rio</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param> 
        /// <returns>string</returns>
        public string ValidarSenhaUsingGET1 (string senha, long? id)
        {
             ApiResponse<string> localVarResponse = ValidarSenhaUsingGET1WithHttpInfo(senha, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Validar a senha do usu\u00C3\u00A1rio Este m\u00C3\u00A9todo permite validar a senha do usu\u00C3\u00A1rio).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">Senha do usu\u00C3\u00A1rio</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ValidarSenhaUsingGET1WithHttpInfo (string senha, long? id)
        {
            
            // verify the required parameter 'senha' is set
            if (senha == null)
                throw new ApiException(400, "Missing required parameter 'senha' when calling UsuariosApi->ValidarSenhaUsingGET1");
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling UsuariosApi->ValidarSenhaUsingGET1");
            
    
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
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
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
        /// Validar a senha do usu\u00C3\u00A1rio Este m\u00C3\u00A9todo permite validar a senha do usu\u00C3\u00A1rio).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">Senha do usu\u00C3\u00A1rio</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ValidarSenhaUsingGET1Async (string senha, long? id)
        {
             ApiResponse<string> localVarResponse = await ValidarSenhaUsingGET1AsyncWithHttpInfo(senha, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Validar a senha do usu\u00C3\u00A1rio Este m\u00C3\u00A9todo permite validar a senha do usu\u00C3\u00A1rio).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">Senha do usu\u00C3\u00A1rio</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Usu\u00C3\u00A1rio (id).</param>
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
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

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
        
    }
    
}
