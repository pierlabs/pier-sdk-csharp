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
    public interface ITokenApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Alterar token
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja modificado um token j\u00C3\u00A1 cadastrado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo identificador do token</param>
        /// <param name="token">Token (optional)</param>
        /// <param name="_base">C\u00C3\u00B3digo identificador da base (optional)</param>
        /// <param name="owner">Owner do token (optional)</param>
        /// <param name="status">Status do token (optional)</param>
        /// <param name="criadoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem criou o token (optional)</param>
        /// <param name="alteradoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem alterou o token (optional)</param>
        /// <returns>Token</returns>
        Token AlterarUsingPUT5 (long? id, string token = null, long? _base = null, string owner = null, string status = null, string criadoPor = null, string alteradoPor = null);
  
        /// <summary>
        /// Alterar token
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja modificado um token j\u00C3\u00A1 cadastrado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo identificador do token</param>
        /// <param name="token">Token (optional)</param>
        /// <param name="_base">C\u00C3\u00B3digo identificador da base (optional)</param>
        /// <param name="owner">Owner do token (optional)</param>
        /// <param name="status">Status do token (optional)</param>
        /// <param name="criadoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem criou o token (optional)</param>
        /// <param name="alteradoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem alterou o token (optional)</param>
        /// <returns>ApiResponse of Token</returns>
        ApiResponse<Token> AlterarUsingPUT5WithHttpInfo (long? id, string token = null, long? _base = null, string owner = null, string status = null, string criadoPor = null, string alteradoPor = null);
        
        /// <summary>
        /// /api/tokens/callback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bodyAccessToken">bodyAccessToken</param>
        /// <returns>BodyAccessToken</returns>
        BodyAccessToken CallbackUsingPOST (BodyAccessToken bodyAccessToken);
  
        /// <summary>
        /// /api/tokens/callback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bodyAccessToken">bodyAccessToken</param>
        /// <returns>ApiResponse of BodyAccessToken</returns>
        ApiResponse<BodyAccessToken> CallbackUsingPOSTWithHttpInfo (BodyAccessToken bodyAccessToken);
        
        /// <summary>
        /// Consultar token
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja consultado um token do emissor atrav\u00C3\u00A9s de um id especifico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do token (id).</param>
        /// <returns>Token</returns>
        Token ConsultarUsingGET14 (long? id);
  
        /// <summary>
        /// Consultar token
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja consultado um token do emissor atrav\u00C3\u00A9s de um id especifico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do token (id).</param>
        /// <returns>ApiResponse of Token</returns>
        ApiResponse<Token> ConsultarUsingGET14WithHttpInfo (long? id);
        
        /// <summary>
        /// Listar tokens
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os tokens existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo identificador do token (optional)</param>
        /// <param name="token">Token (optional)</param>
        /// <param name="_base">C\u00C3\u00B3digo identificador da base (optional)</param>
        /// <param name="owner">Owner do token (optional)</param>
        /// <param name="status">Status do token (optional)</param>
        /// <param name="criadoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem criou o token (optional)</param>
        /// <param name="dataCriacao">Data de cria\u00C3\u00A7\u00C3\u00A3o do token (optional)</param>
        /// <param name="alteradoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem alterou o token (optional)</param>
        /// <param name="dataModificacao">Data de modifica\u00C3\u00A7\u00C3\u00A3o do token (optional)</param>
        /// <returns>PageBases</returns>
        PageBases ListarUsingGET14 (int? page = null, int? limit = null, long? id = null, string token = null, long? _base = null, string owner = null, string status = null, string criadoPor = null, DateTime? dataCriacao = null, string alteradoPor = null, DateTime? dataModificacao = null);
  
        /// <summary>
        /// Listar tokens
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os tokens existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo identificador do token (optional)</param>
        /// <param name="token">Token (optional)</param>
        /// <param name="_base">C\u00C3\u00B3digo identificador da base (optional)</param>
        /// <param name="owner">Owner do token (optional)</param>
        /// <param name="status">Status do token (optional)</param>
        /// <param name="criadoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem criou o token (optional)</param>
        /// <param name="dataCriacao">Data de cria\u00C3\u00A7\u00C3\u00A3o do token (optional)</param>
        /// <param name="alteradoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem alterou o token (optional)</param>
        /// <param name="dataModificacao">Data de modifica\u00C3\u00A7\u00C3\u00A3o do token (optional)</param>
        /// <returns>ApiResponse of PageBases</returns>
        ApiResponse<PageBases> ListarUsingGET14WithHttpInfo (int? page = null, int? limit = null, long? id = null, string token = null, long? _base = null, string owner = null, string status = null, string criadoPor = null, DateTime? dataCriacao = null, string alteradoPor = null, DateTime? dataModificacao = null);
        
        /// <summary>
        /// Salvar token
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja adicionado um novo token
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">Token (optional)</param>
        /// <param name="_base">C\u00C3\u00B3digo identificador da base (optional)</param>
        /// <param name="owner">Owner do token (optional)</param>
        /// <param name="status">Status do token (optional)</param>
        /// <param name="criadoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem criou o token (optional)</param>
        /// <param name="alteradoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem alterou o token (optional)</param>
        /// <returns>Token</returns>
        Token SalvarUsingPOST5 (string token = null, long? _base = null, string owner = null, string status = null, string criadoPor = null, string alteradoPor = null);
  
        /// <summary>
        /// Salvar token
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja adicionado um novo token
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">Token (optional)</param>
        /// <param name="_base">C\u00C3\u00B3digo identificador da base (optional)</param>
        /// <param name="owner">Owner do token (optional)</param>
        /// <param name="status">Status do token (optional)</param>
        /// <param name="criadoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem criou o token (optional)</param>
        /// <param name="alteradoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem alterou o token (optional)</param>
        /// <returns>ApiResponse of Token</returns>
        ApiResponse<Token> SalvarUsingPOST5WithHttpInfo (string token = null, long? _base = null, string owner = null, string status = null, string criadoPor = null, string alteradoPor = null);
        
        /// <summary>
        /// /api/tokens/validar
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bodyAccessToken">bodyAccessToken</param>
        /// <returns>Object</returns>
        Object ValidarUsingPOST (BodyAccessToken bodyAccessToken);
  
        /// <summary>
        /// /api/tokens/validar
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bodyAccessToken">bodyAccessToken</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ValidarUsingPOSTWithHttpInfo (BodyAccessToken bodyAccessToken);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Alterar token
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja modificado um token j\u00C3\u00A1 cadastrado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo identificador do token</param>
        /// <param name="token">Token (optional)</param>
        /// <param name="_base">C\u00C3\u00B3digo identificador da base (optional)</param>
        /// <param name="owner">Owner do token (optional)</param>
        /// <param name="status">Status do token (optional)</param>
        /// <param name="criadoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem criou o token (optional)</param>
        /// <param name="alteradoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem alterou o token (optional)</param>
        /// <returns>Task of Token</returns>
        System.Threading.Tasks.Task<Token> AlterarUsingPUT5Async (long? id, string token = null, long? _base = null, string owner = null, string status = null, string criadoPor = null, string alteradoPor = null);

        /// <summary>
        /// Alterar token
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja modificado um token j\u00C3\u00A1 cadastrado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo identificador do token</param>
        /// <param name="token">Token (optional)</param>
        /// <param name="_base">C\u00C3\u00B3digo identificador da base (optional)</param>
        /// <param name="owner">Owner do token (optional)</param>
        /// <param name="status">Status do token (optional)</param>
        /// <param name="criadoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem criou o token (optional)</param>
        /// <param name="alteradoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem alterou o token (optional)</param>
        /// <returns>Task of ApiResponse (Token)</returns>
        System.Threading.Tasks.Task<ApiResponse<Token>> AlterarUsingPUT5AsyncWithHttpInfo (long? id, string token = null, long? _base = null, string owner = null, string status = null, string criadoPor = null, string alteradoPor = null);
        
        /// <summary>
        /// /api/tokens/callback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bodyAccessToken">bodyAccessToken</param>
        /// <returns>Task of BodyAccessToken</returns>
        System.Threading.Tasks.Task<BodyAccessToken> CallbackUsingPOSTAsync (BodyAccessToken bodyAccessToken);

        /// <summary>
        /// /api/tokens/callback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bodyAccessToken">bodyAccessToken</param>
        /// <returns>Task of ApiResponse (BodyAccessToken)</returns>
        System.Threading.Tasks.Task<ApiResponse<BodyAccessToken>> CallbackUsingPOSTAsyncWithHttpInfo (BodyAccessToken bodyAccessToken);
        
        /// <summary>
        /// Consultar token
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja consultado um token do emissor atrav\u00C3\u00A9s de um id especifico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do token (id).</param>
        /// <returns>Task of Token</returns>
        System.Threading.Tasks.Task<Token> ConsultarUsingGET14Async (long? id);

        /// <summary>
        /// Consultar token
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja consultado um token do emissor atrav\u00C3\u00A9s de um id especifico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do token (id).</param>
        /// <returns>Task of ApiResponse (Token)</returns>
        System.Threading.Tasks.Task<ApiResponse<Token>> ConsultarUsingGET14AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Listar tokens
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os tokens existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo identificador do token (optional)</param>
        /// <param name="token">Token (optional)</param>
        /// <param name="_base">C\u00C3\u00B3digo identificador da base (optional)</param>
        /// <param name="owner">Owner do token (optional)</param>
        /// <param name="status">Status do token (optional)</param>
        /// <param name="criadoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem criou o token (optional)</param>
        /// <param name="dataCriacao">Data de cria\u00C3\u00A7\u00C3\u00A3o do token (optional)</param>
        /// <param name="alteradoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem alterou o token (optional)</param>
        /// <param name="dataModificacao">Data de modifica\u00C3\u00A7\u00C3\u00A3o do token (optional)</param>
        /// <returns>Task of PageBases</returns>
        System.Threading.Tasks.Task<PageBases> ListarUsingGET14Async (int? page = null, int? limit = null, long? id = null, string token = null, long? _base = null, string owner = null, string status = null, string criadoPor = null, DateTime? dataCriacao = null, string alteradoPor = null, DateTime? dataModificacao = null);

        /// <summary>
        /// Listar tokens
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os tokens existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo identificador do token (optional)</param>
        /// <param name="token">Token (optional)</param>
        /// <param name="_base">C\u00C3\u00B3digo identificador da base (optional)</param>
        /// <param name="owner">Owner do token (optional)</param>
        /// <param name="status">Status do token (optional)</param>
        /// <param name="criadoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem criou o token (optional)</param>
        /// <param name="dataCriacao">Data de cria\u00C3\u00A7\u00C3\u00A3o do token (optional)</param>
        /// <param name="alteradoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem alterou o token (optional)</param>
        /// <param name="dataModificacao">Data de modifica\u00C3\u00A7\u00C3\u00A3o do token (optional)</param>
        /// <returns>Task of ApiResponse (PageBases)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageBases>> ListarUsingGET14AsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, string token = null, long? _base = null, string owner = null, string status = null, string criadoPor = null, DateTime? dataCriacao = null, string alteradoPor = null, DateTime? dataModificacao = null);
        
        /// <summary>
        /// Salvar token
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja adicionado um novo token
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">Token (optional)</param>
        /// <param name="_base">C\u00C3\u00B3digo identificador da base (optional)</param>
        /// <param name="owner">Owner do token (optional)</param>
        /// <param name="status">Status do token (optional)</param>
        /// <param name="criadoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem criou o token (optional)</param>
        /// <param name="alteradoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem alterou o token (optional)</param>
        /// <returns>Task of Token</returns>
        System.Threading.Tasks.Task<Token> SalvarUsingPOST5Async (string token = null, long? _base = null, string owner = null, string status = null, string criadoPor = null, string alteradoPor = null);

        /// <summary>
        /// Salvar token
        /// </summary>
        /// <remarks>
        /// Este recurso permite que seja adicionado um novo token
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">Token (optional)</param>
        /// <param name="_base">C\u00C3\u00B3digo identificador da base (optional)</param>
        /// <param name="owner">Owner do token (optional)</param>
        /// <param name="status">Status do token (optional)</param>
        /// <param name="criadoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem criou o token (optional)</param>
        /// <param name="alteradoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem alterou o token (optional)</param>
        /// <returns>Task of ApiResponse (Token)</returns>
        System.Threading.Tasks.Task<ApiResponse<Token>> SalvarUsingPOST5AsyncWithHttpInfo (string token = null, long? _base = null, string owner = null, string status = null, string criadoPor = null, string alteradoPor = null);
        
        /// <summary>
        /// /api/tokens/validar
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bodyAccessToken">bodyAccessToken</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ValidarUsingPOSTAsync (BodyAccessToken bodyAccessToken);

        /// <summary>
        /// /api/tokens/validar
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bodyAccessToken">bodyAccessToken</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ValidarUsingPOSTAsyncWithHttpInfo (BodyAccessToken bodyAccessToken);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TokenApi : ITokenApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TokenApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TokenApi(Configuration configuration = null)
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
        /// Alterar token Este recurso permite que seja modificado um token j\u00C3\u00A1 cadastrado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo identificador do token</param> 
        /// <param name="token">Token (optional)</param> 
        /// <param name="_base">C\u00C3\u00B3digo identificador da base (optional)</param> 
        /// <param name="owner">Owner do token (optional)</param> 
        /// <param name="status">Status do token (optional)</param> 
        /// <param name="criadoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem criou o token (optional)</param> 
        /// <param name="alteradoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem alterou o token (optional)</param> 
        /// <returns>Token</returns>
        public Token AlterarUsingPUT5 (long? id, string token = null, long? _base = null, string owner = null, string status = null, string criadoPor = null, string alteradoPor = null)
        {
             ApiResponse<Token> localVarResponse = AlterarUsingPUT5WithHttpInfo(id, token, _base, owner, status, criadoPor, alteradoPor);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar token Este recurso permite que seja modificado um token j\u00C3\u00A1 cadastrado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo identificador do token</param> 
        /// <param name="token">Token (optional)</param> 
        /// <param name="_base">C\u00C3\u00B3digo identificador da base (optional)</param> 
        /// <param name="owner">Owner do token (optional)</param> 
        /// <param name="status">Status do token (optional)</param> 
        /// <param name="criadoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem criou o token (optional)</param> 
        /// <param name="alteradoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem alterou o token (optional)</param> 
        /// <returns>ApiResponse of Token</returns>
        public ApiResponse< Token > AlterarUsingPUT5WithHttpInfo (long? id, string token = null, long? _base = null, string owner = null, string status = null, string criadoPor = null, string alteradoPor = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TokenApi->AlterarUsingPUT5");
            
    
            var localVarPath = "/api/tokens";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (token != null) localVarQueryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            if (_base != null) localVarQueryParams.Add("base", Configuration.ApiClient.ParameterToString(_base)); // query parameter
            if (owner != null) localVarQueryParams.Add("owner", Configuration.ApiClient.ParameterToString(owner)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (criadoPor != null) localVarQueryParams.Add("criadoPor", Configuration.ApiClient.ParameterToString(criadoPor)); // query parameter
            if (alteradoPor != null) localVarQueryParams.Add("alteradoPor", Configuration.ApiClient.ParameterToString(alteradoPor)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Token>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Token) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Token)));
            
        }

        
        /// <summary>
        /// Alterar token Este recurso permite que seja modificado um token j\u00C3\u00A1 cadastrado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo identificador do token</param>
        /// <param name="token">Token (optional)</param>
        /// <param name="_base">C\u00C3\u00B3digo identificador da base (optional)</param>
        /// <param name="owner">Owner do token (optional)</param>
        /// <param name="status">Status do token (optional)</param>
        /// <param name="criadoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem criou o token (optional)</param>
        /// <param name="alteradoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem alterou o token (optional)</param>
        /// <returns>Task of Token</returns>
        public async System.Threading.Tasks.Task<Token> AlterarUsingPUT5Async (long? id, string token = null, long? _base = null, string owner = null, string status = null, string criadoPor = null, string alteradoPor = null)
        {
             ApiResponse<Token> localVarResponse = await AlterarUsingPUT5AsyncWithHttpInfo(id, token, _base, owner, status, criadoPor, alteradoPor);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Alterar token Este recurso permite que seja modificado um token j\u00C3\u00A1 cadastrado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo identificador do token</param>
        /// <param name="token">Token (optional)</param>
        /// <param name="_base">C\u00C3\u00B3digo identificador da base (optional)</param>
        /// <param name="owner">Owner do token (optional)</param>
        /// <param name="status">Status do token (optional)</param>
        /// <param name="criadoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem criou o token (optional)</param>
        /// <param name="alteradoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem alterou o token (optional)</param>
        /// <returns>Task of ApiResponse (Token)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Token>> AlterarUsingPUT5AsyncWithHttpInfo (long? id, string token = null, long? _base = null, string owner = null, string status = null, string criadoPor = null, string alteradoPor = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT5");
            
    
            var localVarPath = "/api/tokens";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (token != null) localVarQueryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            if (_base != null) localVarQueryParams.Add("base", Configuration.ApiClient.ParameterToString(_base)); // query parameter
            if (owner != null) localVarQueryParams.Add("owner", Configuration.ApiClient.ParameterToString(owner)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (criadoPor != null) localVarQueryParams.Add("criadoPor", Configuration.ApiClient.ParameterToString(criadoPor)); // query parameter
            if (alteradoPor != null) localVarQueryParams.Add("alteradoPor", Configuration.ApiClient.ParameterToString(alteradoPor)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Token>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Token) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Token)));
            
        }
        
        /// <summary>
        /// /api/tokens/callback 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bodyAccessToken">bodyAccessToken</param> 
        /// <returns>BodyAccessToken</returns>
        public BodyAccessToken CallbackUsingPOST (BodyAccessToken bodyAccessToken)
        {
             ApiResponse<BodyAccessToken> localVarResponse = CallbackUsingPOSTWithHttpInfo(bodyAccessToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// /api/tokens/callback 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bodyAccessToken">bodyAccessToken</param> 
        /// <returns>ApiResponse of BodyAccessToken</returns>
        public ApiResponse< BodyAccessToken > CallbackUsingPOSTWithHttpInfo (BodyAccessToken bodyAccessToken)
        {
            
            // verify the required parameter 'bodyAccessToken' is set
            if (bodyAccessToken == null)
                throw new ApiException(400, "Missing required parameter 'bodyAccessToken' when calling TokenApi->CallbackUsingPOST");
            
    
            var localVarPath = "/api/tokens/callback";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (bodyAccessToken.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(bodyAccessToken); // http body (model) parameter
            }
            else
            {
                localVarPostBody = bodyAccessToken; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling CallbackUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CallbackUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BodyAccessToken>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BodyAccessToken) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BodyAccessToken)));
            
        }

        
        /// <summary>
        /// /api/tokens/callback 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bodyAccessToken">bodyAccessToken</param>
        /// <returns>Task of BodyAccessToken</returns>
        public async System.Threading.Tasks.Task<BodyAccessToken> CallbackUsingPOSTAsync (BodyAccessToken bodyAccessToken)
        {
             ApiResponse<BodyAccessToken> localVarResponse = await CallbackUsingPOSTAsyncWithHttpInfo(bodyAccessToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// /api/tokens/callback 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bodyAccessToken">bodyAccessToken</param>
        /// <returns>Task of ApiResponse (BodyAccessToken)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BodyAccessToken>> CallbackUsingPOSTAsyncWithHttpInfo (BodyAccessToken bodyAccessToken)
        {
            // verify the required parameter 'bodyAccessToken' is set
            if (bodyAccessToken == null) throw new ApiException(400, "Missing required parameter 'bodyAccessToken' when calling CallbackUsingPOST");
            
    
            var localVarPath = "/api/tokens/callback";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (bodyAccessToken.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(bodyAccessToken); // http body (model) parameter
            }
            else
            {
                localVarPostBody = bodyAccessToken; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling CallbackUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CallbackUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BodyAccessToken>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BodyAccessToken) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BodyAccessToken)));
            
        }
        
        /// <summary>
        /// Consultar token Este recurso permite que seja consultado um token do emissor atrav\u00C3\u00A9s de um id especifico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do token (id).</param> 
        /// <returns>Token</returns>
        public Token ConsultarUsingGET14 (long? id)
        {
             ApiResponse<Token> localVarResponse = ConsultarUsingGET14WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar token Este recurso permite que seja consultado um token do emissor atrav\u00C3\u00A9s de um id especifico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do token (id).</param> 
        /// <returns>ApiResponse of Token</returns>
        public ApiResponse< Token > ConsultarUsingGET14WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TokenApi->ConsultarUsingGET14");
            
    
            var localVarPath = "/api/tokens/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET14: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET14: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Token>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Token) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Token)));
            
        }

        
        /// <summary>
        /// Consultar token Este recurso permite que seja consultado um token do emissor atrav\u00C3\u00A9s de um id especifico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do token (id).</param>
        /// <returns>Task of Token</returns>
        public async System.Threading.Tasks.Task<Token> ConsultarUsingGET14Async (long? id)
        {
             ApiResponse<Token> localVarResponse = await ConsultarUsingGET14AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar token Este recurso permite que seja consultado um token do emissor atrav\u00C3\u00A9s de um id especifico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do token (id).</param>
        /// <returns>Task of ApiResponse (Token)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Token>> ConsultarUsingGET14AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET14");
            
    
            var localVarPath = "/api/tokens/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET14: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET14: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Token>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Token) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Token)));
            
        }
        
        /// <summary>
        /// Listar tokens Este recurso permite que sejam listados os tokens existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo identificador do token (optional)</param> 
        /// <param name="token">Token (optional)</param> 
        /// <param name="_base">C\u00C3\u00B3digo identificador da base (optional)</param> 
        /// <param name="owner">Owner do token (optional)</param> 
        /// <param name="status">Status do token (optional)</param> 
        /// <param name="criadoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem criou o token (optional)</param> 
        /// <param name="dataCriacao">Data de cria\u00C3\u00A7\u00C3\u00A3o do token (optional)</param> 
        /// <param name="alteradoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem alterou o token (optional)</param> 
        /// <param name="dataModificacao">Data de modifica\u00C3\u00A7\u00C3\u00A3o do token (optional)</param> 
        /// <returns>PageBases</returns>
        public PageBases ListarUsingGET14 (int? page = null, int? limit = null, long? id = null, string token = null, long? _base = null, string owner = null, string status = null, string criadoPor = null, DateTime? dataCriacao = null, string alteradoPor = null, DateTime? dataModificacao = null)
        {
             ApiResponse<PageBases> localVarResponse = ListarUsingGET14WithHttpInfo(page, limit, id, token, _base, owner, status, criadoPor, dataCriacao, alteradoPor, dataModificacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar tokens Este recurso permite que sejam listados os tokens existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo identificador do token (optional)</param> 
        /// <param name="token">Token (optional)</param> 
        /// <param name="_base">C\u00C3\u00B3digo identificador da base (optional)</param> 
        /// <param name="owner">Owner do token (optional)</param> 
        /// <param name="status">Status do token (optional)</param> 
        /// <param name="criadoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem criou o token (optional)</param> 
        /// <param name="dataCriacao">Data de cria\u00C3\u00A7\u00C3\u00A3o do token (optional)</param> 
        /// <param name="alteradoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem alterou o token (optional)</param> 
        /// <param name="dataModificacao">Data de modifica\u00C3\u00A7\u00C3\u00A3o do token (optional)</param> 
        /// <returns>ApiResponse of PageBases</returns>
        public ApiResponse< PageBases > ListarUsingGET14WithHttpInfo (int? page = null, int? limit = null, long? id = null, string token = null, long? _base = null, string owner = null, string status = null, string criadoPor = null, DateTime? dataCriacao = null, string alteradoPor = null, DateTime? dataModificacao = null)
        {
            
    
            var localVarPath = "/api/tokens";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (token != null) localVarQueryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            if (_base != null) localVarQueryParams.Add("base", Configuration.ApiClient.ParameterToString(_base)); // query parameter
            if (owner != null) localVarQueryParams.Add("owner", Configuration.ApiClient.ParameterToString(owner)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (criadoPor != null) localVarQueryParams.Add("criadoPor", Configuration.ApiClient.ParameterToString(criadoPor)); // query parameter
            if (dataCriacao != null) localVarQueryParams.Add("dataCriacao", Configuration.ApiClient.ParameterToString(dataCriacao)); // query parameter
            if (alteradoPor != null) localVarQueryParams.Add("alteradoPor", Configuration.ApiClient.ParameterToString(alteradoPor)); // query parameter
            if (dataModificacao != null) localVarQueryParams.Add("dataModificacao", Configuration.ApiClient.ParameterToString(dataModificacao)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET14: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET14: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageBases>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageBases) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageBases)));
            
        }

        
        /// <summary>
        /// Listar tokens Este recurso permite que sejam listados os tokens existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo identificador do token (optional)</param>
        /// <param name="token">Token (optional)</param>
        /// <param name="_base">C\u00C3\u00B3digo identificador da base (optional)</param>
        /// <param name="owner">Owner do token (optional)</param>
        /// <param name="status">Status do token (optional)</param>
        /// <param name="criadoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem criou o token (optional)</param>
        /// <param name="dataCriacao">Data de cria\u00C3\u00A7\u00C3\u00A3o do token (optional)</param>
        /// <param name="alteradoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem alterou o token (optional)</param>
        /// <param name="dataModificacao">Data de modifica\u00C3\u00A7\u00C3\u00A3o do token (optional)</param>
        /// <returns>Task of PageBases</returns>
        public async System.Threading.Tasks.Task<PageBases> ListarUsingGET14Async (int? page = null, int? limit = null, long? id = null, string token = null, long? _base = null, string owner = null, string status = null, string criadoPor = null, DateTime? dataCriacao = null, string alteradoPor = null, DateTime? dataModificacao = null)
        {
             ApiResponse<PageBases> localVarResponse = await ListarUsingGET14AsyncWithHttpInfo(page, limit, id, token, _base, owner, status, criadoPor, dataCriacao, alteradoPor, dataModificacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar tokens Este recurso permite que sejam listados os tokens existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo identificador do token (optional)</param>
        /// <param name="token">Token (optional)</param>
        /// <param name="_base">C\u00C3\u00B3digo identificador da base (optional)</param>
        /// <param name="owner">Owner do token (optional)</param>
        /// <param name="status">Status do token (optional)</param>
        /// <param name="criadoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem criou o token (optional)</param>
        /// <param name="dataCriacao">Data de cria\u00C3\u00A7\u00C3\u00A3o do token (optional)</param>
        /// <param name="alteradoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem alterou o token (optional)</param>
        /// <param name="dataModificacao">Data de modifica\u00C3\u00A7\u00C3\u00A3o do token (optional)</param>
        /// <returns>Task of ApiResponse (PageBases)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageBases>> ListarUsingGET14AsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, string token = null, long? _base = null, string owner = null, string status = null, string criadoPor = null, DateTime? dataCriacao = null, string alteradoPor = null, DateTime? dataModificacao = null)
        {
            
    
            var localVarPath = "/api/tokens";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (token != null) localVarQueryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            if (_base != null) localVarQueryParams.Add("base", Configuration.ApiClient.ParameterToString(_base)); // query parameter
            if (owner != null) localVarQueryParams.Add("owner", Configuration.ApiClient.ParameterToString(owner)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (criadoPor != null) localVarQueryParams.Add("criadoPor", Configuration.ApiClient.ParameterToString(criadoPor)); // query parameter
            if (dataCriacao != null) localVarQueryParams.Add("dataCriacao", Configuration.ApiClient.ParameterToString(dataCriacao)); // query parameter
            if (alteradoPor != null) localVarQueryParams.Add("alteradoPor", Configuration.ApiClient.ParameterToString(alteradoPor)); // query parameter
            if (dataModificacao != null) localVarQueryParams.Add("dataModificacao", Configuration.ApiClient.ParameterToString(dataModificacao)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET14: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET14: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageBases>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageBases) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageBases)));
            
        }
        
        /// <summary>
        /// Salvar token Este recurso permite que seja adicionado um novo token
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">Token (optional)</param> 
        /// <param name="_base">C\u00C3\u00B3digo identificador da base (optional)</param> 
        /// <param name="owner">Owner do token (optional)</param> 
        /// <param name="status">Status do token (optional)</param> 
        /// <param name="criadoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem criou o token (optional)</param> 
        /// <param name="alteradoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem alterou o token (optional)</param> 
        /// <returns>Token</returns>
        public Token SalvarUsingPOST5 (string token = null, long? _base = null, string owner = null, string status = null, string criadoPor = null, string alteradoPor = null)
        {
             ApiResponse<Token> localVarResponse = SalvarUsingPOST5WithHttpInfo(token, _base, owner, status, criadoPor, alteradoPor);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Salvar token Este recurso permite que seja adicionado um novo token
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">Token (optional)</param> 
        /// <param name="_base">C\u00C3\u00B3digo identificador da base (optional)</param> 
        /// <param name="owner">Owner do token (optional)</param> 
        /// <param name="status">Status do token (optional)</param> 
        /// <param name="criadoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem criou o token (optional)</param> 
        /// <param name="alteradoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem alterou o token (optional)</param> 
        /// <returns>ApiResponse of Token</returns>
        public ApiResponse< Token > SalvarUsingPOST5WithHttpInfo (string token = null, long? _base = null, string owner = null, string status = null, string criadoPor = null, string alteradoPor = null)
        {
            
    
            var localVarPath = "/api/tokens";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (token != null) localVarQueryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            if (_base != null) localVarQueryParams.Add("base", Configuration.ApiClient.ParameterToString(_base)); // query parameter
            if (owner != null) localVarQueryParams.Add("owner", Configuration.ApiClient.ParameterToString(owner)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (criadoPor != null) localVarQueryParams.Add("criadoPor", Configuration.ApiClient.ParameterToString(criadoPor)); // query parameter
            if (alteradoPor != null) localVarQueryParams.Add("alteradoPor", Configuration.ApiClient.ParameterToString(alteradoPor)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Token>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Token) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Token)));
            
        }

        
        /// <summary>
        /// Salvar token Este recurso permite que seja adicionado um novo token
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">Token (optional)</param>
        /// <param name="_base">C\u00C3\u00B3digo identificador da base (optional)</param>
        /// <param name="owner">Owner do token (optional)</param>
        /// <param name="status">Status do token (optional)</param>
        /// <param name="criadoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem criou o token (optional)</param>
        /// <param name="alteradoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem alterou o token (optional)</param>
        /// <returns>Task of Token</returns>
        public async System.Threading.Tasks.Task<Token> SalvarUsingPOST5Async (string token = null, long? _base = null, string owner = null, string status = null, string criadoPor = null, string alteradoPor = null)
        {
             ApiResponse<Token> localVarResponse = await SalvarUsingPOST5AsyncWithHttpInfo(token, _base, owner, status, criadoPor, alteradoPor);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Salvar token Este recurso permite que seja adicionado um novo token
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">Token (optional)</param>
        /// <param name="_base">C\u00C3\u00B3digo identificador da base (optional)</param>
        /// <param name="owner">Owner do token (optional)</param>
        /// <param name="status">Status do token (optional)</param>
        /// <param name="criadoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem criou o token (optional)</param>
        /// <param name="alteradoPor">Descri\u00C3\u00A7\u00C3\u00A3o de quem alterou o token (optional)</param>
        /// <returns>Task of ApiResponse (Token)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Token>> SalvarUsingPOST5AsyncWithHttpInfo (string token = null, long? _base = null, string owner = null, string status = null, string criadoPor = null, string alteradoPor = null)
        {
            
    
            var localVarPath = "/api/tokens";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (token != null) localVarQueryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            if (_base != null) localVarQueryParams.Add("base", Configuration.ApiClient.ParameterToString(_base)); // query parameter
            if (owner != null) localVarQueryParams.Add("owner", Configuration.ApiClient.ParameterToString(owner)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (criadoPor != null) localVarQueryParams.Add("criadoPor", Configuration.ApiClient.ParameterToString(criadoPor)); // query parameter
            if (alteradoPor != null) localVarQueryParams.Add("alteradoPor", Configuration.ApiClient.ParameterToString(alteradoPor)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Token>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Token) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Token)));
            
        }
        
        /// <summary>
        /// /api/tokens/validar 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bodyAccessToken">bodyAccessToken</param> 
        /// <returns>Object</returns>
        public Object ValidarUsingPOST (BodyAccessToken bodyAccessToken)
        {
             ApiResponse<Object> localVarResponse = ValidarUsingPOSTWithHttpInfo(bodyAccessToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// /api/tokens/validar 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bodyAccessToken">bodyAccessToken</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > ValidarUsingPOSTWithHttpInfo (BodyAccessToken bodyAccessToken)
        {
            
            // verify the required parameter 'bodyAccessToken' is set
            if (bodyAccessToken == null)
                throw new ApiException(400, "Missing required parameter 'bodyAccessToken' when calling TokenApi->ValidarUsingPOST");
            
    
            var localVarPath = "/api/tokens/validar";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (bodyAccessToken.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(bodyAccessToken); // http body (model) parameter
            }
            else
            {
                localVarPostBody = bodyAccessToken; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// /api/tokens/validar 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bodyAccessToken">bodyAccessToken</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ValidarUsingPOSTAsync (BodyAccessToken bodyAccessToken)
        {
             ApiResponse<Object> localVarResponse = await ValidarUsingPOSTAsyncWithHttpInfo(bodyAccessToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// /api/tokens/validar 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bodyAccessToken">bodyAccessToken</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ValidarUsingPOSTAsyncWithHttpInfo (BodyAccessToken bodyAccessToken)
        {
            // verify the required parameter 'bodyAccessToken' is set
            if (bodyAccessToken == null) throw new ApiException(400, "Missing required parameter 'bodyAccessToken' when calling ValidarUsingPOST");
            
    
            var localVarPath = "/api/tokens/validar";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (bodyAccessToken.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(bodyAccessToken); // http body (model) parameter
            }
            else
            {
                localVarPostBody = bodyAccessToken; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
    }
    
}
