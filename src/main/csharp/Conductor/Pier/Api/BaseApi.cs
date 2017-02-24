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
    public interface IBaseApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Alterar base
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja modificado uma base j\u00C3\u00A1 cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo identificador da base</param>
        /// <param name="servidor">IP do servidor</param>
        /// <param name="usuario">Nome do usu\u00C3\u00A1rio</param>
        /// <param name="senha">Senha</param>
        /// <param name="nomeBase">Nome da base</param>
        /// <param name="senhaCriptografada">senha Criptografada</param>
        /// <param name="domain">Dom\u00C3\u00ADnio da base</param>
        /// <param name="nomeBaseControleAcesso">Nome da base de controle acesso</param>
        /// <param name="servidorControleAcesso">Servidor do controle de acesso</param>
        /// <param name="idEmissor">C\u00C3\u00B3digo do identificador do emissor (optional)</param>
        /// <returns>ModelBase</returns>
        ModelBase AlterarUsingPUT (long? id, string servidor, string usuario, string senha, string nomeBase, bool? senhaCriptografada, string domain, string nomeBaseControleAcesso, string servidorControleAcesso, long? idEmissor = null);
  
        /// <summary>
        /// Alterar base
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja modificado uma base j\u00C3\u00A1 cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo identificador da base</param>
        /// <param name="servidor">IP do servidor</param>
        /// <param name="usuario">Nome do usu\u00C3\u00A1rio</param>
        /// <param name="senha">Senha</param>
        /// <param name="nomeBase">Nome da base</param>
        /// <param name="senhaCriptografada">senha Criptografada</param>
        /// <param name="domain">Dom\u00C3\u00ADnio da base</param>
        /// <param name="nomeBaseControleAcesso">Nome da base de controle acesso</param>
        /// <param name="servidorControleAcesso">Servidor do controle de acesso</param>
        /// <param name="idEmissor">C\u00C3\u00B3digo do identificador do emissor (optional)</param>
        /// <returns>ApiResponse of ModelBase</returns>
        ApiResponse<ModelBase> AlterarUsingPUTWithHttpInfo (long? id, string servidor, string usuario, string senha, string nomeBase, bool? senhaCriptografada, string domain, string nomeBaseControleAcesso, string servidorControleAcesso, long? idEmissor = null);
        
        /// <summary>
        /// Limpar mapa de bases
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>BodyAccessToken</returns>
        BodyAccessToken ClearUsingGET ();
  
        /// <summary>
        /// Limpar mapa de bases
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of BodyAccessToken</returns>
        ApiResponse<BodyAccessToken> ClearUsingGETWithHttpInfo ();
        
        /// <summary>
        /// Consultar base
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja consultada uma base do emissor atrav\u00C3\u00A9s de um id especifico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da base (id).</param>
        /// <returns>ModelBase</returns>
        ModelBase ConsultarUsingGET1 (long? id);
  
        /// <summary>
        /// Consultar base
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja consultada uma base do emissor atrav\u00C3\u00A9s de um id especifico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da base (id).</param>
        /// <returns>ApiResponse of ModelBase</returns>
        ApiResponse<ModelBase> ConsultarUsingGET1WithHttpInfo (long? id);
        
        /// <summary>
        /// Listar bases
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listadas as bases existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo identificador da base (optional)</param>
        /// <param name="servidor">IP do servidor (optional)</param>
        /// <param name="usuario">Nome do usu\u00C3\u00A1rio (optional)</param>
        /// <param name="senha">Senha (optional)</param>
        /// <param name="nomeBase">Nome da base (optional)</param>
        /// <param name="senhaCriptografada">senha Criptografada (optional)</param>
        /// <param name="domain">Dom\u00C3\u00ADnio da base (optional)</param>
        /// <param name="nomeBaseControleAcesso">Nome da base de controle acesso (optional)</param>
        /// <param name="idEmissor">C\u00C3\u00B3digo do identificador do emissor (optional)</param>
        /// <param name="servidorControleAcesso">Servidor do controle de acesso (optional)</param>
        /// <returns>PageBases</returns>
        PageBases ListarUsingGET1 (int? page = null, int? limit = null, long? id = null, string servidor = null, string usuario = null, string senha = null, string nomeBase = null, bool? senhaCriptografada = null, string domain = null, string nomeBaseControleAcesso = null, long? idEmissor = null, string servidorControleAcesso = null);
  
        /// <summary>
        /// Listar bases
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listadas as bases existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo identificador da base (optional)</param>
        /// <param name="servidor">IP do servidor (optional)</param>
        /// <param name="usuario">Nome do usu\u00C3\u00A1rio (optional)</param>
        /// <param name="senha">Senha (optional)</param>
        /// <param name="nomeBase">Nome da base (optional)</param>
        /// <param name="senhaCriptografada">senha Criptografada (optional)</param>
        /// <param name="domain">Dom\u00C3\u00ADnio da base (optional)</param>
        /// <param name="nomeBaseControleAcesso">Nome da base de controle acesso (optional)</param>
        /// <param name="idEmissor">C\u00C3\u00B3digo do identificador do emissor (optional)</param>
        /// <param name="servidorControleAcesso">Servidor do controle de acesso (optional)</param>
        /// <returns>ApiResponse of PageBases</returns>
        ApiResponse<PageBases> ListarUsingGET1WithHttpInfo (int? page = null, int? limit = null, long? id = null, string servidor = null, string usuario = null, string senha = null, string nomeBase = null, bool? senhaCriptografada = null, string domain = null, string nomeBaseControleAcesso = null, long? idEmissor = null, string servidorControleAcesso = null);
        
        /// <summary>
        /// Salvar base
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja adicionado uma nova base
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="servidor">IP do servidor</param>
        /// <param name="usuario">Nome do usu\u00C3\u00A1rio</param>
        /// <param name="senha">Senha</param>
        /// <param name="nomeBase">Nome da base</param>
        /// <param name="senhaCriptografada">senha Criptografada</param>
        /// <param name="domain">Dom\u00C3\u00ADnio da base</param>
        /// <param name="nomeBaseControleAcesso">Nome da base de controle acesso</param>
        /// <param name="servidorControleAcesso">Servidor do controle de acesso</param>
        /// <param name="idEmissor">C\u00C3\u00B3digo do identificador do emissor (optional)</param>
        /// <returns>ModelBase</returns>
        ModelBase SalvarUsingPOST1 (string servidor, string usuario, string senha, string nomeBase, bool? senhaCriptografada, string domain, string nomeBaseControleAcesso, string servidorControleAcesso, long? idEmissor = null);
  
        /// <summary>
        /// Salvar base
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja adicionado uma nova base
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="servidor">IP do servidor</param>
        /// <param name="usuario">Nome do usu\u00C3\u00A1rio</param>
        /// <param name="senha">Senha</param>
        /// <param name="nomeBase">Nome da base</param>
        /// <param name="senhaCriptografada">senha Criptografada</param>
        /// <param name="domain">Dom\u00C3\u00ADnio da base</param>
        /// <param name="nomeBaseControleAcesso">Nome da base de controle acesso</param>
        /// <param name="servidorControleAcesso">Servidor do controle de acesso</param>
        /// <param name="idEmissor">C\u00C3\u00B3digo do identificador do emissor (optional)</param>
        /// <returns>ApiResponse of ModelBase</returns>
        ApiResponse<ModelBase> SalvarUsingPOST1WithHttpInfo (string servidor, string usuario, string senha, string nomeBase, bool? senhaCriptografada, string domain, string nomeBaseControleAcesso, string servidorControleAcesso, long? idEmissor = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Alterar base
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja modificado uma base j\u00C3\u00A1 cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo identificador da base</param>
        /// <param name="servidor">IP do servidor</param>
        /// <param name="usuario">Nome do usu\u00C3\u00A1rio</param>
        /// <param name="senha">Senha</param>
        /// <param name="nomeBase">Nome da base</param>
        /// <param name="senhaCriptografada">senha Criptografada</param>
        /// <param name="domain">Dom\u00C3\u00ADnio da base</param>
        /// <param name="nomeBaseControleAcesso">Nome da base de controle acesso</param>
        /// <param name="servidorControleAcesso">Servidor do controle de acesso</param>
        /// <param name="idEmissor">C\u00C3\u00B3digo do identificador do emissor (optional)</param>
        /// <returns>Task of ModelBase</returns>
        System.Threading.Tasks.Task<ModelBase> AlterarUsingPUTAsync (long? id, string servidor, string usuario, string senha, string nomeBase, bool? senhaCriptografada, string domain, string nomeBaseControleAcesso, string servidorControleAcesso, long? idEmissor = null);

        /// <summary>
        /// Alterar base
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja modificado uma base j\u00C3\u00A1 cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo identificador da base</param>
        /// <param name="servidor">IP do servidor</param>
        /// <param name="usuario">Nome do usu\u00C3\u00A1rio</param>
        /// <param name="senha">Senha</param>
        /// <param name="nomeBase">Nome da base</param>
        /// <param name="senhaCriptografada">senha Criptografada</param>
        /// <param name="domain">Dom\u00C3\u00ADnio da base</param>
        /// <param name="nomeBaseControleAcesso">Nome da base de controle acesso</param>
        /// <param name="servidorControleAcesso">Servidor do controle de acesso</param>
        /// <param name="idEmissor">C\u00C3\u00B3digo do identificador do emissor (optional)</param>
        /// <returns>Task of ApiResponse (ModelBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<ModelBase>> AlterarUsingPUTAsyncWithHttpInfo (long? id, string servidor, string usuario, string senha, string nomeBase, bool? senhaCriptografada, string domain, string nomeBaseControleAcesso, string servidorControleAcesso, long? idEmissor = null);
        
        /// <summary>
        /// Limpar mapa de bases
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of BodyAccessToken</returns>
        System.Threading.Tasks.Task<BodyAccessToken> ClearUsingGETAsync ();

        /// <summary>
        /// Limpar mapa de bases
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (BodyAccessToken)</returns>
        System.Threading.Tasks.Task<ApiResponse<BodyAccessToken>> ClearUsingGETAsyncWithHttpInfo ();
        
        /// <summary>
        /// Consultar base
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja consultada uma base do emissor atrav\u00C3\u00A9s de um id especifico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da base (id).</param>
        /// <returns>Task of ModelBase</returns>
        System.Threading.Tasks.Task<ModelBase> ConsultarUsingGET1Async (long? id);

        /// <summary>
        /// Consultar base
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja consultada uma base do emissor atrav\u00C3\u00A9s de um id especifico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da base (id).</param>
        /// <returns>Task of ApiResponse (ModelBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<ModelBase>> ConsultarUsingGET1AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Listar bases
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listadas as bases existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo identificador da base (optional)</param>
        /// <param name="servidor">IP do servidor (optional)</param>
        /// <param name="usuario">Nome do usu\u00C3\u00A1rio (optional)</param>
        /// <param name="senha">Senha (optional)</param>
        /// <param name="nomeBase">Nome da base (optional)</param>
        /// <param name="senhaCriptografada">senha Criptografada (optional)</param>
        /// <param name="domain">Dom\u00C3\u00ADnio da base (optional)</param>
        /// <param name="nomeBaseControleAcesso">Nome da base de controle acesso (optional)</param>
        /// <param name="idEmissor">C\u00C3\u00B3digo do identificador do emissor (optional)</param>
        /// <param name="servidorControleAcesso">Servidor do controle de acesso (optional)</param>
        /// <returns>Task of PageBases</returns>
        System.Threading.Tasks.Task<PageBases> ListarUsingGET1Async (int? page = null, int? limit = null, long? id = null, string servidor = null, string usuario = null, string senha = null, string nomeBase = null, bool? senhaCriptografada = null, string domain = null, string nomeBaseControleAcesso = null, long? idEmissor = null, string servidorControleAcesso = null);

        /// <summary>
        /// Listar bases
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listadas as bases existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo identificador da base (optional)</param>
        /// <param name="servidor">IP do servidor (optional)</param>
        /// <param name="usuario">Nome do usu\u00C3\u00A1rio (optional)</param>
        /// <param name="senha">Senha (optional)</param>
        /// <param name="nomeBase">Nome da base (optional)</param>
        /// <param name="senhaCriptografada">senha Criptografada (optional)</param>
        /// <param name="domain">Dom\u00C3\u00ADnio da base (optional)</param>
        /// <param name="nomeBaseControleAcesso">Nome da base de controle acesso (optional)</param>
        /// <param name="idEmissor">C\u00C3\u00B3digo do identificador do emissor (optional)</param>
        /// <param name="servidorControleAcesso">Servidor do controle de acesso (optional)</param>
        /// <returns>Task of ApiResponse (PageBases)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageBases>> ListarUsingGET1AsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, string servidor = null, string usuario = null, string senha = null, string nomeBase = null, bool? senhaCriptografada = null, string domain = null, string nomeBaseControleAcesso = null, long? idEmissor = null, string servidorControleAcesso = null);
        
        /// <summary>
        /// Salvar base
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja adicionado uma nova base
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="servidor">IP do servidor</param>
        /// <param name="usuario">Nome do usu\u00C3\u00A1rio</param>
        /// <param name="senha">Senha</param>
        /// <param name="nomeBase">Nome da base</param>
        /// <param name="senhaCriptografada">senha Criptografada</param>
        /// <param name="domain">Dom\u00C3\u00ADnio da base</param>
        /// <param name="nomeBaseControleAcesso">Nome da base de controle acesso</param>
        /// <param name="servidorControleAcesso">Servidor do controle de acesso</param>
        /// <param name="idEmissor">C\u00C3\u00B3digo do identificador do emissor (optional)</param>
        /// <returns>Task of ModelBase</returns>
        System.Threading.Tasks.Task<ModelBase> SalvarUsingPOST1Async (string servidor, string usuario, string senha, string nomeBase, bool? senhaCriptografada, string domain, string nomeBaseControleAcesso, string servidorControleAcesso, long? idEmissor = null);

        /// <summary>
        /// Salvar base
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja adicionado uma nova base
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="servidor">IP do servidor</param>
        /// <param name="usuario">Nome do usu\u00C3\u00A1rio</param>
        /// <param name="senha">Senha</param>
        /// <param name="nomeBase">Nome da base</param>
        /// <param name="senhaCriptografada">senha Criptografada</param>
        /// <param name="domain">Dom\u00C3\u00ADnio da base</param>
        /// <param name="nomeBaseControleAcesso">Nome da base de controle acesso</param>
        /// <param name="servidorControleAcesso">Servidor do controle de acesso</param>
        /// <param name="idEmissor">C\u00C3\u00B3digo do identificador do emissor (optional)</param>
        /// <returns>Task of ApiResponse (ModelBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<ModelBase>> SalvarUsingPOST1AsyncWithHttpInfo (string servidor, string usuario, string senha, string nomeBase, bool? senhaCriptografada, string domain, string nomeBaseControleAcesso, string servidorControleAcesso, long? idEmissor = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BaseApi : IBaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BaseApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BaseApi(Configuration configuration = null)
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
        /// Alterar base Este recurso permite que seja modificado uma base j\u00C3\u00A1 cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo identificador da base</param> 
        /// <param name="servidor">IP do servidor</param> 
        /// <param name="usuario">Nome do usu\u00C3\u00A1rio</param> 
        /// <param name="senha">Senha</param> 
        /// <param name="nomeBase">Nome da base</param> 
        /// <param name="senhaCriptografada">senha Criptografada</param> 
        /// <param name="domain">Dom\u00C3\u00ADnio da base</param> 
        /// <param name="nomeBaseControleAcesso">Nome da base de controle acesso</param> 
        /// <param name="servidorControleAcesso">Servidor do controle de acesso</param> 
        /// <param name="idEmissor">C\u00C3\u00B3digo do identificador do emissor (optional)</param> 
        /// <returns>ModelBase</returns>
        public ModelBase AlterarUsingPUT (long? id, string servidor, string usuario, string senha, string nomeBase, bool? senhaCriptografada, string domain, string nomeBaseControleAcesso, string servidorControleAcesso, long? idEmissor = null)
        {
             ApiResponse<ModelBase> localVarResponse = AlterarUsingPUTWithHttpInfo(id, servidor, usuario, senha, nomeBase, senhaCriptografada, domain, nomeBaseControleAcesso, servidorControleAcesso, idEmissor);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar base Este recurso permite que seja modificado uma base j\u00C3\u00A1 cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo identificador da base</param> 
        /// <param name="servidor">IP do servidor</param> 
        /// <param name="usuario">Nome do usu\u00C3\u00A1rio</param> 
        /// <param name="senha">Senha</param> 
        /// <param name="nomeBase">Nome da base</param> 
        /// <param name="senhaCriptografada">senha Criptografada</param> 
        /// <param name="domain">Dom\u00C3\u00ADnio da base</param> 
        /// <param name="nomeBaseControleAcesso">Nome da base de controle acesso</param> 
        /// <param name="servidorControleAcesso">Servidor do controle de acesso</param> 
        /// <param name="idEmissor">C\u00C3\u00B3digo do identificador do emissor (optional)</param> 
        /// <returns>ApiResponse of ModelBase</returns>
        public ApiResponse< ModelBase > AlterarUsingPUTWithHttpInfo (long? id, string servidor, string usuario, string senha, string nomeBase, bool? senhaCriptografada, string domain, string nomeBaseControleAcesso, string servidorControleAcesso, long? idEmissor = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BaseApi->AlterarUsingPUT");
            
            // verify the required parameter 'servidor' is set
            if (servidor == null)
                throw new ApiException(400, "Missing required parameter 'servidor' when calling BaseApi->AlterarUsingPUT");
            
            // verify the required parameter 'usuario' is set
            if (usuario == null)
                throw new ApiException(400, "Missing required parameter 'usuario' when calling BaseApi->AlterarUsingPUT");
            
            // verify the required parameter 'senha' is set
            if (senha == null)
                throw new ApiException(400, "Missing required parameter 'senha' when calling BaseApi->AlterarUsingPUT");
            
            // verify the required parameter 'nomeBase' is set
            if (nomeBase == null)
                throw new ApiException(400, "Missing required parameter 'nomeBase' when calling BaseApi->AlterarUsingPUT");
            
            // verify the required parameter 'senhaCriptografada' is set
            if (senhaCriptografada == null)
                throw new ApiException(400, "Missing required parameter 'senhaCriptografada' when calling BaseApi->AlterarUsingPUT");
            
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new ApiException(400, "Missing required parameter 'domain' when calling BaseApi->AlterarUsingPUT");
            
            // verify the required parameter 'nomeBaseControleAcesso' is set
            if (nomeBaseControleAcesso == null)
                throw new ApiException(400, "Missing required parameter 'nomeBaseControleAcesso' when calling BaseApi->AlterarUsingPUT");
            
            // verify the required parameter 'servidorControleAcesso' is set
            if (servidorControleAcesso == null)
                throw new ApiException(400, "Missing required parameter 'servidorControleAcesso' when calling BaseApi->AlterarUsingPUT");
            
    
            var localVarPath = "/api/bases";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (servidor != null) localVarQueryParams.Add("servidor", Configuration.ApiClient.ParameterToString(servidor)); // query parameter
            if (usuario != null) localVarQueryParams.Add("usuario", Configuration.ApiClient.ParameterToString(usuario)); // query parameter
            if (senha != null) localVarQueryParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // query parameter
            if (nomeBase != null) localVarQueryParams.Add("nomeBase", Configuration.ApiClient.ParameterToString(nomeBase)); // query parameter
            if (senhaCriptografada != null) localVarQueryParams.Add("senhaCriptografada", Configuration.ApiClient.ParameterToString(senhaCriptografada)); // query parameter
            if (domain != null) localVarQueryParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // query parameter
            if (nomeBaseControleAcesso != null) localVarQueryParams.Add("nomeBaseControleAcesso", Configuration.ApiClient.ParameterToString(nomeBaseControleAcesso)); // query parameter
            if (idEmissor != null) localVarQueryParams.Add("idEmissor", Configuration.ApiClient.ParameterToString(idEmissor)); // query parameter
            if (servidorControleAcesso != null) localVarQueryParams.Add("servidorControleAcesso", Configuration.ApiClient.ParameterToString(servidorControleAcesso)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ModelBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ModelBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModelBase)));
            
        }

        
        /// <summary>
        /// Alterar base Este recurso permite que seja modificado uma base j\u00C3\u00A1 cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo identificador da base</param>
        /// <param name="servidor">IP do servidor</param>
        /// <param name="usuario">Nome do usu\u00C3\u00A1rio</param>
        /// <param name="senha">Senha</param>
        /// <param name="nomeBase">Nome da base</param>
        /// <param name="senhaCriptografada">senha Criptografada</param>
        /// <param name="domain">Dom\u00C3\u00ADnio da base</param>
        /// <param name="nomeBaseControleAcesso">Nome da base de controle acesso</param>
        /// <param name="servidorControleAcesso">Servidor do controle de acesso</param>
        /// <param name="idEmissor">C\u00C3\u00B3digo do identificador do emissor (optional)</param>
        /// <returns>Task of ModelBase</returns>
        public async System.Threading.Tasks.Task<ModelBase> AlterarUsingPUTAsync (long? id, string servidor, string usuario, string senha, string nomeBase, bool? senhaCriptografada, string domain, string nomeBaseControleAcesso, string servidorControleAcesso, long? idEmissor = null)
        {
             ApiResponse<ModelBase> localVarResponse = await AlterarUsingPUTAsyncWithHttpInfo(id, servidor, usuario, senha, nomeBase, senhaCriptografada, domain, nomeBaseControleAcesso, servidorControleAcesso, idEmissor);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Alterar base Este recurso permite que seja modificado uma base j\u00C3\u00A1 cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo identificador da base</param>
        /// <param name="servidor">IP do servidor</param>
        /// <param name="usuario">Nome do usu\u00C3\u00A1rio</param>
        /// <param name="senha">Senha</param>
        /// <param name="nomeBase">Nome da base</param>
        /// <param name="senhaCriptografada">senha Criptografada</param>
        /// <param name="domain">Dom\u00C3\u00ADnio da base</param>
        /// <param name="nomeBaseControleAcesso">Nome da base de controle acesso</param>
        /// <param name="servidorControleAcesso">Servidor do controle de acesso</param>
        /// <param name="idEmissor">C\u00C3\u00B3digo do identificador do emissor (optional)</param>
        /// <returns>Task of ApiResponse (ModelBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ModelBase>> AlterarUsingPUTAsyncWithHttpInfo (long? id, string servidor, string usuario, string senha, string nomeBase, bool? senhaCriptografada, string domain, string nomeBaseControleAcesso, string servidorControleAcesso, long? idEmissor = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT");
            // verify the required parameter 'servidor' is set
            if (servidor == null) throw new ApiException(400, "Missing required parameter 'servidor' when calling AlterarUsingPUT");
            // verify the required parameter 'usuario' is set
            if (usuario == null) throw new ApiException(400, "Missing required parameter 'usuario' when calling AlterarUsingPUT");
            // verify the required parameter 'senha' is set
            if (senha == null) throw new ApiException(400, "Missing required parameter 'senha' when calling AlterarUsingPUT");
            // verify the required parameter 'nomeBase' is set
            if (nomeBase == null) throw new ApiException(400, "Missing required parameter 'nomeBase' when calling AlterarUsingPUT");
            // verify the required parameter 'senhaCriptografada' is set
            if (senhaCriptografada == null) throw new ApiException(400, "Missing required parameter 'senhaCriptografada' when calling AlterarUsingPUT");
            // verify the required parameter 'domain' is set
            if (domain == null) throw new ApiException(400, "Missing required parameter 'domain' when calling AlterarUsingPUT");
            // verify the required parameter 'nomeBaseControleAcesso' is set
            if (nomeBaseControleAcesso == null) throw new ApiException(400, "Missing required parameter 'nomeBaseControleAcesso' when calling AlterarUsingPUT");
            // verify the required parameter 'servidorControleAcesso' is set
            if (servidorControleAcesso == null) throw new ApiException(400, "Missing required parameter 'servidorControleAcesso' when calling AlterarUsingPUT");
            
    
            var localVarPath = "/api/bases";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (servidor != null) localVarQueryParams.Add("servidor", Configuration.ApiClient.ParameterToString(servidor)); // query parameter
            if (usuario != null) localVarQueryParams.Add("usuario", Configuration.ApiClient.ParameterToString(usuario)); // query parameter
            if (senha != null) localVarQueryParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // query parameter
            if (nomeBase != null) localVarQueryParams.Add("nomeBase", Configuration.ApiClient.ParameterToString(nomeBase)); // query parameter
            if (senhaCriptografada != null) localVarQueryParams.Add("senhaCriptografada", Configuration.ApiClient.ParameterToString(senhaCriptografada)); // query parameter
            if (domain != null) localVarQueryParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // query parameter
            if (nomeBaseControleAcesso != null) localVarQueryParams.Add("nomeBaseControleAcesso", Configuration.ApiClient.ParameterToString(nomeBaseControleAcesso)); // query parameter
            if (idEmissor != null) localVarQueryParams.Add("idEmissor", Configuration.ApiClient.ParameterToString(idEmissor)); // query parameter
            if (servidorControleAcesso != null) localVarQueryParams.Add("servidorControleAcesso", Configuration.ApiClient.ParameterToString(servidorControleAcesso)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ModelBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ModelBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModelBase)));
            
        }
        
        /// <summary>
        /// Limpar mapa de bases 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>BodyAccessToken</returns>
        public BodyAccessToken ClearUsingGET ()
        {
             ApiResponse<BodyAccessToken> localVarResponse = ClearUsingGETWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Limpar mapa de bases 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of BodyAccessToken</returns>
        public ApiResponse< BodyAccessToken > ClearUsingGETWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/bases/clear";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling ClearUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ClearUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BodyAccessToken>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BodyAccessToken) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BodyAccessToken)));
            
        }

        
        /// <summary>
        /// Limpar mapa de bases 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of BodyAccessToken</returns>
        public async System.Threading.Tasks.Task<BodyAccessToken> ClearUsingGETAsync ()
        {
             ApiResponse<BodyAccessToken> localVarResponse = await ClearUsingGETAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Limpar mapa de bases 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (BodyAccessToken)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BodyAccessToken>> ClearUsingGETAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/bases/clear";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling ClearUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ClearUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BodyAccessToken>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BodyAccessToken) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BodyAccessToken)));
            
        }
        
        /// <summary>
        /// Consultar base Este recurso permite que seja consultada uma base do emissor atrav\u00C3\u00A9s de um id especifico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da base (id).</param> 
        /// <returns>ModelBase</returns>
        public ModelBase ConsultarUsingGET1 (long? id)
        {
             ApiResponse<ModelBase> localVarResponse = ConsultarUsingGET1WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar base Este recurso permite que seja consultada uma base do emissor atrav\u00C3\u00A9s de um id especifico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da base (id).</param> 
        /// <returns>ApiResponse of ModelBase</returns>
        public ApiResponse< ModelBase > ConsultarUsingGET1WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BaseApi->ConsultarUsingGET1");
            
    
            var localVarPath = "/api/bases/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ModelBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ModelBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModelBase)));
            
        }

        
        /// <summary>
        /// Consultar base Este recurso permite que seja consultada uma base do emissor atrav\u00C3\u00A9s de um id especifico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da base (id).</param>
        /// <returns>Task of ModelBase</returns>
        public async System.Threading.Tasks.Task<ModelBase> ConsultarUsingGET1Async (long? id)
        {
             ApiResponse<ModelBase> localVarResponse = await ConsultarUsingGET1AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar base Este recurso permite que seja consultada uma base do emissor atrav\u00C3\u00A9s de um id especifico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da base (id).</param>
        /// <returns>Task of ApiResponse (ModelBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ModelBase>> ConsultarUsingGET1AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET1");
            
    
            var localVarPath = "/api/bases/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ModelBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ModelBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModelBase)));
            
        }
        
        /// <summary>
        /// Listar bases Este recurso permite que sejam listadas as bases existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo identificador da base (optional)</param> 
        /// <param name="servidor">IP do servidor (optional)</param> 
        /// <param name="usuario">Nome do usu\u00C3\u00A1rio (optional)</param> 
        /// <param name="senha">Senha (optional)</param> 
        /// <param name="nomeBase">Nome da base (optional)</param> 
        /// <param name="senhaCriptografada">senha Criptografada (optional)</param> 
        /// <param name="domain">Dom\u00C3\u00ADnio da base (optional)</param> 
        /// <param name="nomeBaseControleAcesso">Nome da base de controle acesso (optional)</param> 
        /// <param name="idEmissor">C\u00C3\u00B3digo do identificador do emissor (optional)</param> 
        /// <param name="servidorControleAcesso">Servidor do controle de acesso (optional)</param> 
        /// <returns>PageBases</returns>
        public PageBases ListarUsingGET1 (int? page = null, int? limit = null, long? id = null, string servidor = null, string usuario = null, string senha = null, string nomeBase = null, bool? senhaCriptografada = null, string domain = null, string nomeBaseControleAcesso = null, long? idEmissor = null, string servidorControleAcesso = null)
        {
             ApiResponse<PageBases> localVarResponse = ListarUsingGET1WithHttpInfo(page, limit, id, servidor, usuario, senha, nomeBase, senhaCriptografada, domain, nomeBaseControleAcesso, idEmissor, servidorControleAcesso);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar bases Este recurso permite que sejam listadas as bases existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo identificador da base (optional)</param> 
        /// <param name="servidor">IP do servidor (optional)</param> 
        /// <param name="usuario">Nome do usu\u00C3\u00A1rio (optional)</param> 
        /// <param name="senha">Senha (optional)</param> 
        /// <param name="nomeBase">Nome da base (optional)</param> 
        /// <param name="senhaCriptografada">senha Criptografada (optional)</param> 
        /// <param name="domain">Dom\u00C3\u00ADnio da base (optional)</param> 
        /// <param name="nomeBaseControleAcesso">Nome da base de controle acesso (optional)</param> 
        /// <param name="idEmissor">C\u00C3\u00B3digo do identificador do emissor (optional)</param> 
        /// <param name="servidorControleAcesso">Servidor do controle de acesso (optional)</param> 
        /// <returns>ApiResponse of PageBases</returns>
        public ApiResponse< PageBases > ListarUsingGET1WithHttpInfo (int? page = null, int? limit = null, long? id = null, string servidor = null, string usuario = null, string senha = null, string nomeBase = null, bool? senhaCriptografada = null, string domain = null, string nomeBaseControleAcesso = null, long? idEmissor = null, string servidorControleAcesso = null)
        {
            
    
            var localVarPath = "/api/bases";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (servidor != null) localVarQueryParams.Add("servidor", Configuration.ApiClient.ParameterToString(servidor)); // query parameter
            if (usuario != null) localVarQueryParams.Add("usuario", Configuration.ApiClient.ParameterToString(usuario)); // query parameter
            if (senha != null) localVarQueryParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // query parameter
            if (nomeBase != null) localVarQueryParams.Add("nomeBase", Configuration.ApiClient.ParameterToString(nomeBase)); // query parameter
            if (senhaCriptografada != null) localVarQueryParams.Add("senhaCriptografada", Configuration.ApiClient.ParameterToString(senhaCriptografada)); // query parameter
            if (domain != null) localVarQueryParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // query parameter
            if (nomeBaseControleAcesso != null) localVarQueryParams.Add("nomeBaseControleAcesso", Configuration.ApiClient.ParameterToString(nomeBaseControleAcesso)); // query parameter
            if (idEmissor != null) localVarQueryParams.Add("idEmissor", Configuration.ApiClient.ParameterToString(idEmissor)); // query parameter
            if (servidorControleAcesso != null) localVarQueryParams.Add("servidorControleAcesso", Configuration.ApiClient.ParameterToString(servidorControleAcesso)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageBases>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageBases) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageBases)));
            
        }

        
        /// <summary>
        /// Listar bases Este recurso permite que sejam listadas as bases existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo identificador da base (optional)</param>
        /// <param name="servidor">IP do servidor (optional)</param>
        /// <param name="usuario">Nome do usu\u00C3\u00A1rio (optional)</param>
        /// <param name="senha">Senha (optional)</param>
        /// <param name="nomeBase">Nome da base (optional)</param>
        /// <param name="senhaCriptografada">senha Criptografada (optional)</param>
        /// <param name="domain">Dom\u00C3\u00ADnio da base (optional)</param>
        /// <param name="nomeBaseControleAcesso">Nome da base de controle acesso (optional)</param>
        /// <param name="idEmissor">C\u00C3\u00B3digo do identificador do emissor (optional)</param>
        /// <param name="servidorControleAcesso">Servidor do controle de acesso (optional)</param>
        /// <returns>Task of PageBases</returns>
        public async System.Threading.Tasks.Task<PageBases> ListarUsingGET1Async (int? page = null, int? limit = null, long? id = null, string servidor = null, string usuario = null, string senha = null, string nomeBase = null, bool? senhaCriptografada = null, string domain = null, string nomeBaseControleAcesso = null, long? idEmissor = null, string servidorControleAcesso = null)
        {
             ApiResponse<PageBases> localVarResponse = await ListarUsingGET1AsyncWithHttpInfo(page, limit, id, servidor, usuario, senha, nomeBase, senhaCriptografada, domain, nomeBaseControleAcesso, idEmissor, servidorControleAcesso);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar bases Este recurso permite que sejam listadas as bases existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo identificador da base (optional)</param>
        /// <param name="servidor">IP do servidor (optional)</param>
        /// <param name="usuario">Nome do usu\u00C3\u00A1rio (optional)</param>
        /// <param name="senha">Senha (optional)</param>
        /// <param name="nomeBase">Nome da base (optional)</param>
        /// <param name="senhaCriptografada">senha Criptografada (optional)</param>
        /// <param name="domain">Dom\u00C3\u00ADnio da base (optional)</param>
        /// <param name="nomeBaseControleAcesso">Nome da base de controle acesso (optional)</param>
        /// <param name="idEmissor">C\u00C3\u00B3digo do identificador do emissor (optional)</param>
        /// <param name="servidorControleAcesso">Servidor do controle de acesso (optional)</param>
        /// <returns>Task of ApiResponse (PageBases)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageBases>> ListarUsingGET1AsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, string servidor = null, string usuario = null, string senha = null, string nomeBase = null, bool? senhaCriptografada = null, string domain = null, string nomeBaseControleAcesso = null, long? idEmissor = null, string servidorControleAcesso = null)
        {
            
    
            var localVarPath = "/api/bases";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (servidor != null) localVarQueryParams.Add("servidor", Configuration.ApiClient.ParameterToString(servidor)); // query parameter
            if (usuario != null) localVarQueryParams.Add("usuario", Configuration.ApiClient.ParameterToString(usuario)); // query parameter
            if (senha != null) localVarQueryParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // query parameter
            if (nomeBase != null) localVarQueryParams.Add("nomeBase", Configuration.ApiClient.ParameterToString(nomeBase)); // query parameter
            if (senhaCriptografada != null) localVarQueryParams.Add("senhaCriptografada", Configuration.ApiClient.ParameterToString(senhaCriptografada)); // query parameter
            if (domain != null) localVarQueryParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // query parameter
            if (nomeBaseControleAcesso != null) localVarQueryParams.Add("nomeBaseControleAcesso", Configuration.ApiClient.ParameterToString(nomeBaseControleAcesso)); // query parameter
            if (idEmissor != null) localVarQueryParams.Add("idEmissor", Configuration.ApiClient.ParameterToString(idEmissor)); // query parameter
            if (servidorControleAcesso != null) localVarQueryParams.Add("servidorControleAcesso", Configuration.ApiClient.ParameterToString(servidorControleAcesso)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageBases>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageBases) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageBases)));
            
        }
        
        /// <summary>
        /// Salvar base Este recurso permite que seja adicionado uma nova base
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="servidor">IP do servidor</param> 
        /// <param name="usuario">Nome do usu\u00C3\u00A1rio</param> 
        /// <param name="senha">Senha</param> 
        /// <param name="nomeBase">Nome da base</param> 
        /// <param name="senhaCriptografada">senha Criptografada</param> 
        /// <param name="domain">Dom\u00C3\u00ADnio da base</param> 
        /// <param name="nomeBaseControleAcesso">Nome da base de controle acesso</param> 
        /// <param name="servidorControleAcesso">Servidor do controle de acesso</param> 
        /// <param name="idEmissor">C\u00C3\u00B3digo do identificador do emissor (optional)</param> 
        /// <returns>ModelBase</returns>
        public ModelBase SalvarUsingPOST1 (string servidor, string usuario, string senha, string nomeBase, bool? senhaCriptografada, string domain, string nomeBaseControleAcesso, string servidorControleAcesso, long? idEmissor = null)
        {
             ApiResponse<ModelBase> localVarResponse = SalvarUsingPOST1WithHttpInfo(servidor, usuario, senha, nomeBase, senhaCriptografada, domain, nomeBaseControleAcesso, servidorControleAcesso, idEmissor);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Salvar base Este recurso permite que seja adicionado uma nova base
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="servidor">IP do servidor</param> 
        /// <param name="usuario">Nome do usu\u00C3\u00A1rio</param> 
        /// <param name="senha">Senha</param> 
        /// <param name="nomeBase">Nome da base</param> 
        /// <param name="senhaCriptografada">senha Criptografada</param> 
        /// <param name="domain">Dom\u00C3\u00ADnio da base</param> 
        /// <param name="nomeBaseControleAcesso">Nome da base de controle acesso</param> 
        /// <param name="servidorControleAcesso">Servidor do controle de acesso</param> 
        /// <param name="idEmissor">C\u00C3\u00B3digo do identificador do emissor (optional)</param> 
        /// <returns>ApiResponse of ModelBase</returns>
        public ApiResponse< ModelBase > SalvarUsingPOST1WithHttpInfo (string servidor, string usuario, string senha, string nomeBase, bool? senhaCriptografada, string domain, string nomeBaseControleAcesso, string servidorControleAcesso, long? idEmissor = null)
        {
            
            // verify the required parameter 'servidor' is set
            if (servidor == null)
                throw new ApiException(400, "Missing required parameter 'servidor' when calling BaseApi->SalvarUsingPOST1");
            
            // verify the required parameter 'usuario' is set
            if (usuario == null)
                throw new ApiException(400, "Missing required parameter 'usuario' when calling BaseApi->SalvarUsingPOST1");
            
            // verify the required parameter 'senha' is set
            if (senha == null)
                throw new ApiException(400, "Missing required parameter 'senha' when calling BaseApi->SalvarUsingPOST1");
            
            // verify the required parameter 'nomeBase' is set
            if (nomeBase == null)
                throw new ApiException(400, "Missing required parameter 'nomeBase' when calling BaseApi->SalvarUsingPOST1");
            
            // verify the required parameter 'senhaCriptografada' is set
            if (senhaCriptografada == null)
                throw new ApiException(400, "Missing required parameter 'senhaCriptografada' when calling BaseApi->SalvarUsingPOST1");
            
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new ApiException(400, "Missing required parameter 'domain' when calling BaseApi->SalvarUsingPOST1");
            
            // verify the required parameter 'nomeBaseControleAcesso' is set
            if (nomeBaseControleAcesso == null)
                throw new ApiException(400, "Missing required parameter 'nomeBaseControleAcesso' when calling BaseApi->SalvarUsingPOST1");
            
            // verify the required parameter 'servidorControleAcesso' is set
            if (servidorControleAcesso == null)
                throw new ApiException(400, "Missing required parameter 'servidorControleAcesso' when calling BaseApi->SalvarUsingPOST1");
            
    
            var localVarPath = "/api/bases";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (servidor != null) localVarQueryParams.Add("servidor", Configuration.ApiClient.ParameterToString(servidor)); // query parameter
            if (usuario != null) localVarQueryParams.Add("usuario", Configuration.ApiClient.ParameterToString(usuario)); // query parameter
            if (senha != null) localVarQueryParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // query parameter
            if (nomeBase != null) localVarQueryParams.Add("nomeBase", Configuration.ApiClient.ParameterToString(nomeBase)); // query parameter
            if (senhaCriptografada != null) localVarQueryParams.Add("senhaCriptografada", Configuration.ApiClient.ParameterToString(senhaCriptografada)); // query parameter
            if (domain != null) localVarQueryParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // query parameter
            if (nomeBaseControleAcesso != null) localVarQueryParams.Add("nomeBaseControleAcesso", Configuration.ApiClient.ParameterToString(nomeBaseControleAcesso)); // query parameter
            if (idEmissor != null) localVarQueryParams.Add("idEmissor", Configuration.ApiClient.ParameterToString(idEmissor)); // query parameter
            if (servidorControleAcesso != null) localVarQueryParams.Add("servidorControleAcesso", Configuration.ApiClient.ParameterToString(servidorControleAcesso)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ModelBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ModelBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModelBase)));
            
        }

        
        /// <summary>
        /// Salvar base Este recurso permite que seja adicionado uma nova base
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="servidor">IP do servidor</param>
        /// <param name="usuario">Nome do usu\u00C3\u00A1rio</param>
        /// <param name="senha">Senha</param>
        /// <param name="nomeBase">Nome da base</param>
        /// <param name="senhaCriptografada">senha Criptografada</param>
        /// <param name="domain">Dom\u00C3\u00ADnio da base</param>
        /// <param name="nomeBaseControleAcesso">Nome da base de controle acesso</param>
        /// <param name="servidorControleAcesso">Servidor do controle de acesso</param>
        /// <param name="idEmissor">C\u00C3\u00B3digo do identificador do emissor (optional)</param>
        /// <returns>Task of ModelBase</returns>
        public async System.Threading.Tasks.Task<ModelBase> SalvarUsingPOST1Async (string servidor, string usuario, string senha, string nomeBase, bool? senhaCriptografada, string domain, string nomeBaseControleAcesso, string servidorControleAcesso, long? idEmissor = null)
        {
             ApiResponse<ModelBase> localVarResponse = await SalvarUsingPOST1AsyncWithHttpInfo(servidor, usuario, senha, nomeBase, senhaCriptografada, domain, nomeBaseControleAcesso, servidorControleAcesso, idEmissor);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Salvar base Este recurso permite que seja adicionado uma nova base
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="servidor">IP do servidor</param>
        /// <param name="usuario">Nome do usu\u00C3\u00A1rio</param>
        /// <param name="senha">Senha</param>
        /// <param name="nomeBase">Nome da base</param>
        /// <param name="senhaCriptografada">senha Criptografada</param>
        /// <param name="domain">Dom\u00C3\u00ADnio da base</param>
        /// <param name="nomeBaseControleAcesso">Nome da base de controle acesso</param>
        /// <param name="servidorControleAcesso">Servidor do controle de acesso</param>
        /// <param name="idEmissor">C\u00C3\u00B3digo do identificador do emissor (optional)</param>
        /// <returns>Task of ApiResponse (ModelBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ModelBase>> SalvarUsingPOST1AsyncWithHttpInfo (string servidor, string usuario, string senha, string nomeBase, bool? senhaCriptografada, string domain, string nomeBaseControleAcesso, string servidorControleAcesso, long? idEmissor = null)
        {
            // verify the required parameter 'servidor' is set
            if (servidor == null) throw new ApiException(400, "Missing required parameter 'servidor' when calling SalvarUsingPOST1");
            // verify the required parameter 'usuario' is set
            if (usuario == null) throw new ApiException(400, "Missing required parameter 'usuario' when calling SalvarUsingPOST1");
            // verify the required parameter 'senha' is set
            if (senha == null) throw new ApiException(400, "Missing required parameter 'senha' when calling SalvarUsingPOST1");
            // verify the required parameter 'nomeBase' is set
            if (nomeBase == null) throw new ApiException(400, "Missing required parameter 'nomeBase' when calling SalvarUsingPOST1");
            // verify the required parameter 'senhaCriptografada' is set
            if (senhaCriptografada == null) throw new ApiException(400, "Missing required parameter 'senhaCriptografada' when calling SalvarUsingPOST1");
            // verify the required parameter 'domain' is set
            if (domain == null) throw new ApiException(400, "Missing required parameter 'domain' when calling SalvarUsingPOST1");
            // verify the required parameter 'nomeBaseControleAcesso' is set
            if (nomeBaseControleAcesso == null) throw new ApiException(400, "Missing required parameter 'nomeBaseControleAcesso' when calling SalvarUsingPOST1");
            // verify the required parameter 'servidorControleAcesso' is set
            if (servidorControleAcesso == null) throw new ApiException(400, "Missing required parameter 'servidorControleAcesso' when calling SalvarUsingPOST1");
            
    
            var localVarPath = "/api/bases";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (servidor != null) localVarQueryParams.Add("servidor", Configuration.ApiClient.ParameterToString(servidor)); // query parameter
            if (usuario != null) localVarQueryParams.Add("usuario", Configuration.ApiClient.ParameterToString(usuario)); // query parameter
            if (senha != null) localVarQueryParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // query parameter
            if (nomeBase != null) localVarQueryParams.Add("nomeBase", Configuration.ApiClient.ParameterToString(nomeBase)); // query parameter
            if (senhaCriptografada != null) localVarQueryParams.Add("senhaCriptografada", Configuration.ApiClient.ParameterToString(senhaCriptografada)); // query parameter
            if (domain != null) localVarQueryParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // query parameter
            if (nomeBaseControleAcesso != null) localVarQueryParams.Add("nomeBaseControleAcesso", Configuration.ApiClient.ParameterToString(nomeBaseControleAcesso)); // query parameter
            if (idEmissor != null) localVarQueryParams.Add("idEmissor", Configuration.ApiClient.ParameterToString(idEmissor)); // query parameter
            if (servidorControleAcesso != null) localVarQueryParams.Add("servidorControleAcesso", Configuration.ApiClient.ParameterToString(servidorControleAcesso)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ModelBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ModelBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModelBase)));
            
        }
        
    }
    
}
