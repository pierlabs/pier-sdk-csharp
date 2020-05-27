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
    public interface IFraudeApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Altera motivo fraude
        /// </summary>
        /// <remarks>
        /// Recurso altera\u00E7\u00F5es dos motivos fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="motivoFraudeUpdate">motivoFraudeUpdate</param>
        /// <returns>MotivoFraudeResponse</returns>
        MotivoFraudeResponse AlterarMotivoFraude (long? id, MotivoFraudeUpdate motivoFraudeUpdate);
  
        /// <summary>
        /// Altera motivo fraude
        /// </summary>
        /// <remarks>
        /// Recurso altera\u00E7\u00F5es dos motivos fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="motivoFraudeUpdate">motivoFraudeUpdate</param>
        /// <returns>ApiResponse of MotivoFraudeResponse</returns>
        ApiResponse<MotivoFraudeResponse> AlterarMotivoFraudeWithHttpInfo (long? id, MotivoFraudeUpdate motivoFraudeUpdate);
        
        /// <summary>
        /// Altera suspeita de fraude
        /// </summary>
        /// <remarks>
        /// Recurso para alterar uma suspeita de fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da Suspeita de Fraude</param>
        /// <param name="suspeitaFraudeUpdate">suspeitaFraudeUpdate</param>
        /// <returns>SuspeitaFraudeResponse</returns>
        SuspeitaFraudeResponse AlterarSuspeitaFraude (long? id, SuspeitaFraudeUpdate suspeitaFraudeUpdate);
  
        /// <summary>
        /// Altera suspeita de fraude
        /// </summary>
        /// <remarks>
        /// Recurso para alterar uma suspeita de fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da Suspeita de Fraude</param>
        /// <param name="suspeitaFraudeUpdate">suspeitaFraudeUpdate</param>
        /// <returns>ApiResponse of SuspeitaFraudeResponse</returns>
        ApiResponse<SuspeitaFraudeResponse> AlterarSuspeitaFraudeWithHttpInfo (long? id, SuspeitaFraudeUpdate suspeitaFraudeUpdate);
        
        /// <summary>
        /// Cadastra motivo fraude
        /// </summary>
        /// <remarks>
        /// Recurso para cadastrar os motivos fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="motivoFraudePersist">motivoFraudePersist</param>
        /// <returns>MotivoFraudeResponse</returns>
        MotivoFraudeResponse CadastrarMotivoFraude (MotivoFraudePersist motivoFraudePersist);
  
        /// <summary>
        /// Cadastra motivo fraude
        /// </summary>
        /// <remarks>
        /// Recurso para cadastrar os motivos fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="motivoFraudePersist">motivoFraudePersist</param>
        /// <returns>ApiResponse of MotivoFraudeResponse</returns>
        ApiResponse<MotivoFraudeResponse> CadastrarMotivoFraudeWithHttpInfo (MotivoFraudePersist motivoFraudePersist);
        
        /// <summary>
        /// Consulta motivo fraude
        /// </summary>
        /// <remarks>
        /// Recurso para consultar os motivos fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>MotivoFraudeResponse</returns>
        MotivoFraudeResponse ConsultarMotivoFraude (long? id);
  
        /// <summary>
        /// Consulta motivo fraude
        /// </summary>
        /// <remarks>
        /// Recurso para consultar os motivos fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>ApiResponse of MotivoFraudeResponse</returns>
        ApiResponse<MotivoFraudeResponse> ConsultarMotivoFraudeWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta suspeita de fraude
        /// </summary>
        /// <remarks>
        /// Recurso para consultar suspeitas de fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da Suspeita de Fraude</param>
        /// <returns>SuspeitaFraudeResponse</returns>
        SuspeitaFraudeResponse ConsultarSuspeitaFraude (long? id);
  
        /// <summary>
        /// Consulta suspeita de fraude
        /// </summary>
        /// <remarks>
        /// Recurso para consultar suspeitas de fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da Suspeita de Fraude</param>
        /// <returns>ApiResponse of SuspeitaFraudeResponse</returns>
        ApiResponse<SuspeitaFraudeResponse> ConsultarSuspeitaFraudeWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista motivo fraude
        /// </summary>
        /// <remarks>
        /// Recurso que lista os motivos fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o motivo fraude (optional)</param>
        /// <returns>PageMotivoFraudeResponse</returns>
        PageMotivoFraudeResponse ListarMotivoFraude (List<string> sort = null, int? page = null, int? limit = null, string descricao = null);
  
        /// <summary>
        /// Lista motivo fraude
        /// </summary>
        /// <remarks>
        /// Recurso que lista os motivos fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o motivo fraude (optional)</param>
        /// <returns>ApiResponse of PageMotivoFraudeResponse</returns>
        ApiResponse<PageMotivoFraudeResponse> ListarMotivoFraudeWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null);
        
        /// <summary>
        /// Lista suspeitas de fraude
        /// </summary>
        /// <remarks>
        /// Recursos para listagens das suspeitas de fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idMotivoFraude">C\u00F3digo de identifica\u00E7\u00E3o do motivo da suspeita de fraude (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de identifica\u00E7\u00E3o da pessoa com suspeita de fraude (optional)</param>
        /// <param name="dataSuspeitaFraudeInicial">Data in\u00EDcio do per\u00EDodo da consulta (optional)</param>
        /// <param name="dataSuspeitaFraudeFinal">Data fim do per\u00EDodo da consulta (optional)</param>
        /// <returns>PageSuspeitaFraudeResponse</returns>
        PageSuspeitaFraudeResponse ListarSuspeitaFraude (List<string> sort = null, int? page = null, int? limit = null, long? idMotivoFraude = null, long? idPessoa = null, string dataSuspeitaFraudeInicial = null, string dataSuspeitaFraudeFinal = null);
  
        /// <summary>
        /// Lista suspeitas de fraude
        /// </summary>
        /// <remarks>
        /// Recursos para listagens das suspeitas de fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idMotivoFraude">C\u00F3digo de identifica\u00E7\u00E3o do motivo da suspeita de fraude (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de identifica\u00E7\u00E3o da pessoa com suspeita de fraude (optional)</param>
        /// <param name="dataSuspeitaFraudeInicial">Data in\u00EDcio do per\u00EDodo da consulta (optional)</param>
        /// <param name="dataSuspeitaFraudeFinal">Data fim do per\u00EDodo da consulta (optional)</param>
        /// <returns>ApiResponse of PageSuspeitaFraudeResponse</returns>
        ApiResponse<PageSuspeitaFraudeResponse> ListarSuspeitaFraudeWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idMotivoFraude = null, long? idPessoa = null, string dataSuspeitaFraudeInicial = null, string dataSuspeitaFraudeFinal = null);
        
        /// <summary>
        /// Cadastra suspeita de fraude
        /// </summary>
        /// <remarks>
        /// Recurso para cadastrar as suspeitas de fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="suspeitaFraudePersist">suspeitaFraudePersist</param>
        /// <returns>SuspeitaFraudeResponse</returns>
        SuspeitaFraudeResponse SalvarSuspeitaFraude (SuspeitaFraudePersist suspeitaFraudePersist);
  
        /// <summary>
        /// Cadastra suspeita de fraude
        /// </summary>
        /// <remarks>
        /// Recurso para cadastrar as suspeitas de fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="suspeitaFraudePersist">suspeitaFraudePersist</param>
        /// <returns>ApiResponse of SuspeitaFraudeResponse</returns>
        ApiResponse<SuspeitaFraudeResponse> SalvarSuspeitaFraudeWithHttpInfo (SuspeitaFraudePersist suspeitaFraudePersist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Altera motivo fraude
        /// </summary>
        /// <remarks>
        /// Recurso altera\u00E7\u00F5es dos motivos fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="motivoFraudeUpdate">motivoFraudeUpdate</param>
        /// <returns>Task of MotivoFraudeResponse</returns>
        System.Threading.Tasks.Task<MotivoFraudeResponse> AlterarMotivoFraudeAsync (long? id, MotivoFraudeUpdate motivoFraudeUpdate);

        /// <summary>
        /// Altera motivo fraude
        /// </summary>
        /// <remarks>
        /// Recurso altera\u00E7\u00F5es dos motivos fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="motivoFraudeUpdate">motivoFraudeUpdate</param>
        /// <returns>Task of ApiResponse (MotivoFraudeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MotivoFraudeResponse>> AlterarMotivoFraudeAsyncWithHttpInfo (long? id, MotivoFraudeUpdate motivoFraudeUpdate);
        
        /// <summary>
        /// Altera suspeita de fraude
        /// </summary>
        /// <remarks>
        /// Recurso para alterar uma suspeita de fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da Suspeita de Fraude</param>
        /// <param name="suspeitaFraudeUpdate">suspeitaFraudeUpdate</param>
        /// <returns>Task of SuspeitaFraudeResponse</returns>
        System.Threading.Tasks.Task<SuspeitaFraudeResponse> AlterarSuspeitaFraudeAsync (long? id, SuspeitaFraudeUpdate suspeitaFraudeUpdate);

        /// <summary>
        /// Altera suspeita de fraude
        /// </summary>
        /// <remarks>
        /// Recurso para alterar uma suspeita de fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da Suspeita de Fraude</param>
        /// <param name="suspeitaFraudeUpdate">suspeitaFraudeUpdate</param>
        /// <returns>Task of ApiResponse (SuspeitaFraudeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SuspeitaFraudeResponse>> AlterarSuspeitaFraudeAsyncWithHttpInfo (long? id, SuspeitaFraudeUpdate suspeitaFraudeUpdate);
        
        /// <summary>
        /// Cadastra motivo fraude
        /// </summary>
        /// <remarks>
        /// Recurso para cadastrar os motivos fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="motivoFraudePersist">motivoFraudePersist</param>
        /// <returns>Task of MotivoFraudeResponse</returns>
        System.Threading.Tasks.Task<MotivoFraudeResponse> CadastrarMotivoFraudeAsync (MotivoFraudePersist motivoFraudePersist);

        /// <summary>
        /// Cadastra motivo fraude
        /// </summary>
        /// <remarks>
        /// Recurso para cadastrar os motivos fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="motivoFraudePersist">motivoFraudePersist</param>
        /// <returns>Task of ApiResponse (MotivoFraudeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MotivoFraudeResponse>> CadastrarMotivoFraudeAsyncWithHttpInfo (MotivoFraudePersist motivoFraudePersist);
        
        /// <summary>
        /// Consulta motivo fraude
        /// </summary>
        /// <remarks>
        /// Recurso para consultar os motivos fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of MotivoFraudeResponse</returns>
        System.Threading.Tasks.Task<MotivoFraudeResponse> ConsultarMotivoFraudeAsync (long? id);

        /// <summary>
        /// Consulta motivo fraude
        /// </summary>
        /// <remarks>
        /// Recurso para consultar os motivos fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (MotivoFraudeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MotivoFraudeResponse>> ConsultarMotivoFraudeAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta suspeita de fraude
        /// </summary>
        /// <remarks>
        /// Recurso para consultar suspeitas de fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da Suspeita de Fraude</param>
        /// <returns>Task of SuspeitaFraudeResponse</returns>
        System.Threading.Tasks.Task<SuspeitaFraudeResponse> ConsultarSuspeitaFraudeAsync (long? id);

        /// <summary>
        /// Consulta suspeita de fraude
        /// </summary>
        /// <remarks>
        /// Recurso para consultar suspeitas de fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da Suspeita de Fraude</param>
        /// <returns>Task of ApiResponse (SuspeitaFraudeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SuspeitaFraudeResponse>> ConsultarSuspeitaFraudeAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista motivo fraude
        /// </summary>
        /// <remarks>
        /// Recurso que lista os motivos fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o motivo fraude (optional)</param>
        /// <returns>Task of PageMotivoFraudeResponse</returns>
        System.Threading.Tasks.Task<PageMotivoFraudeResponse> ListarMotivoFraudeAsync (List<string> sort = null, int? page = null, int? limit = null, string descricao = null);

        /// <summary>
        /// Lista motivo fraude
        /// </summary>
        /// <remarks>
        /// Recurso que lista os motivos fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o motivo fraude (optional)</param>
        /// <returns>Task of ApiResponse (PageMotivoFraudeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageMotivoFraudeResponse>> ListarMotivoFraudeAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null);
        
        /// <summary>
        /// Lista suspeitas de fraude
        /// </summary>
        /// <remarks>
        /// Recursos para listagens das suspeitas de fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idMotivoFraude">C\u00F3digo de identifica\u00E7\u00E3o do motivo da suspeita de fraude (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de identifica\u00E7\u00E3o da pessoa com suspeita de fraude (optional)</param>
        /// <param name="dataSuspeitaFraudeInicial">Data in\u00EDcio do per\u00EDodo da consulta (optional)</param>
        /// <param name="dataSuspeitaFraudeFinal">Data fim do per\u00EDodo da consulta (optional)</param>
        /// <returns>Task of PageSuspeitaFraudeResponse</returns>
        System.Threading.Tasks.Task<PageSuspeitaFraudeResponse> ListarSuspeitaFraudeAsync (List<string> sort = null, int? page = null, int? limit = null, long? idMotivoFraude = null, long? idPessoa = null, string dataSuspeitaFraudeInicial = null, string dataSuspeitaFraudeFinal = null);

        /// <summary>
        /// Lista suspeitas de fraude
        /// </summary>
        /// <remarks>
        /// Recursos para listagens das suspeitas de fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idMotivoFraude">C\u00F3digo de identifica\u00E7\u00E3o do motivo da suspeita de fraude (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de identifica\u00E7\u00E3o da pessoa com suspeita de fraude (optional)</param>
        /// <param name="dataSuspeitaFraudeInicial">Data in\u00EDcio do per\u00EDodo da consulta (optional)</param>
        /// <param name="dataSuspeitaFraudeFinal">Data fim do per\u00EDodo da consulta (optional)</param>
        /// <returns>Task of ApiResponse (PageSuspeitaFraudeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageSuspeitaFraudeResponse>> ListarSuspeitaFraudeAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idMotivoFraude = null, long? idPessoa = null, string dataSuspeitaFraudeInicial = null, string dataSuspeitaFraudeFinal = null);
        
        /// <summary>
        /// Cadastra suspeita de fraude
        /// </summary>
        /// <remarks>
        /// Recurso para cadastrar as suspeitas de fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="suspeitaFraudePersist">suspeitaFraudePersist</param>
        /// <returns>Task of SuspeitaFraudeResponse</returns>
        System.Threading.Tasks.Task<SuspeitaFraudeResponse> SalvarSuspeitaFraudeAsync (SuspeitaFraudePersist suspeitaFraudePersist);

        /// <summary>
        /// Cadastra suspeita de fraude
        /// </summary>
        /// <remarks>
        /// Recurso para cadastrar as suspeitas de fraude
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="suspeitaFraudePersist">suspeitaFraudePersist</param>
        /// <returns>Task of ApiResponse (SuspeitaFraudeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SuspeitaFraudeResponse>> SalvarSuspeitaFraudeAsyncWithHttpInfo (SuspeitaFraudePersist suspeitaFraudePersist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FraudeApi : IFraudeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FraudeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FraudeApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FraudeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FraudeApi(Configuration configuration = null)
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
        /// Altera motivo fraude Recurso altera\u00E7\u00F5es dos motivos fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="motivoFraudeUpdate">motivoFraudeUpdate</param> 
        /// <returns>MotivoFraudeResponse</returns>
        public MotivoFraudeResponse AlterarMotivoFraude (long? id, MotivoFraudeUpdate motivoFraudeUpdate)
        {
             ApiResponse<MotivoFraudeResponse> localVarResponse = AlterarMotivoFraudeWithHttpInfo(id, motivoFraudeUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera motivo fraude Recurso altera\u00E7\u00F5es dos motivos fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="motivoFraudeUpdate">motivoFraudeUpdate</param> 
        /// <returns>ApiResponse of MotivoFraudeResponse</returns>
        public ApiResponse< MotivoFraudeResponse > AlterarMotivoFraudeWithHttpInfo (long? id, MotivoFraudeUpdate motivoFraudeUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FraudeApi->AlterarMotivoFraude");
            
            // verify the required parameter 'motivoFraudeUpdate' is set
            if (motivoFraudeUpdate == null)
                throw new ApiException(400, "Missing required parameter 'motivoFraudeUpdate' when calling FraudeApi->AlterarMotivoFraude");
            
    
            var localVarPath = "/api/fraudes/motivos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (motivoFraudeUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(motivoFraudeUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = motivoFraudeUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarMotivoFraude: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarMotivoFraude: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<MotivoFraudeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MotivoFraudeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MotivoFraudeResponse)));
            
        }

        
        /// <summary>
        /// Altera motivo fraude Recurso altera\u00E7\u00F5es dos motivos fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="motivoFraudeUpdate">motivoFraudeUpdate</param>
        /// <returns>Task of MotivoFraudeResponse</returns>
        public async System.Threading.Tasks.Task<MotivoFraudeResponse> AlterarMotivoFraudeAsync (long? id, MotivoFraudeUpdate motivoFraudeUpdate)
        {
             ApiResponse<MotivoFraudeResponse> localVarResponse = await AlterarMotivoFraudeAsyncWithHttpInfo(id, motivoFraudeUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera motivo fraude Recurso altera\u00E7\u00F5es dos motivos fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="motivoFraudeUpdate">motivoFraudeUpdate</param>
        /// <returns>Task of ApiResponse (MotivoFraudeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MotivoFraudeResponse>> AlterarMotivoFraudeAsyncWithHttpInfo (long? id, MotivoFraudeUpdate motivoFraudeUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarMotivoFraude");
            // verify the required parameter 'motivoFraudeUpdate' is set
            if (motivoFraudeUpdate == null) throw new ApiException(400, "Missing required parameter 'motivoFraudeUpdate' when calling AlterarMotivoFraude");
            
    
            var localVarPath = "/api/fraudes/motivos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (motivoFraudeUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(motivoFraudeUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = motivoFraudeUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarMotivoFraude: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarMotivoFraude: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MotivoFraudeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MotivoFraudeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MotivoFraudeResponse)));
            
        }
        
        /// <summary>
        /// Altera suspeita de fraude Recurso para alterar uma suspeita de fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da Suspeita de Fraude</param> 
        /// <param name="suspeitaFraudeUpdate">suspeitaFraudeUpdate</param> 
        /// <returns>SuspeitaFraudeResponse</returns>
        public SuspeitaFraudeResponse AlterarSuspeitaFraude (long? id, SuspeitaFraudeUpdate suspeitaFraudeUpdate)
        {
             ApiResponse<SuspeitaFraudeResponse> localVarResponse = AlterarSuspeitaFraudeWithHttpInfo(id, suspeitaFraudeUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera suspeita de fraude Recurso para alterar uma suspeita de fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da Suspeita de Fraude</param> 
        /// <param name="suspeitaFraudeUpdate">suspeitaFraudeUpdate</param> 
        /// <returns>ApiResponse of SuspeitaFraudeResponse</returns>
        public ApiResponse< SuspeitaFraudeResponse > AlterarSuspeitaFraudeWithHttpInfo (long? id, SuspeitaFraudeUpdate suspeitaFraudeUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FraudeApi->AlterarSuspeitaFraude");
            
            // verify the required parameter 'suspeitaFraudeUpdate' is set
            if (suspeitaFraudeUpdate == null)
                throw new ApiException(400, "Missing required parameter 'suspeitaFraudeUpdate' when calling FraudeApi->AlterarSuspeitaFraude");
            
    
            var localVarPath = "/api/fraudes/suspeitas/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (suspeitaFraudeUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(suspeitaFraudeUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = suspeitaFraudeUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarSuspeitaFraude: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarSuspeitaFraude: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<SuspeitaFraudeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuspeitaFraudeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuspeitaFraudeResponse)));
            
        }

        
        /// <summary>
        /// Altera suspeita de fraude Recurso para alterar uma suspeita de fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da Suspeita de Fraude</param>
        /// <param name="suspeitaFraudeUpdate">suspeitaFraudeUpdate</param>
        /// <returns>Task of SuspeitaFraudeResponse</returns>
        public async System.Threading.Tasks.Task<SuspeitaFraudeResponse> AlterarSuspeitaFraudeAsync (long? id, SuspeitaFraudeUpdate suspeitaFraudeUpdate)
        {
             ApiResponse<SuspeitaFraudeResponse> localVarResponse = await AlterarSuspeitaFraudeAsyncWithHttpInfo(id, suspeitaFraudeUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera suspeita de fraude Recurso para alterar uma suspeita de fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da Suspeita de Fraude</param>
        /// <param name="suspeitaFraudeUpdate">suspeitaFraudeUpdate</param>
        /// <returns>Task of ApiResponse (SuspeitaFraudeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SuspeitaFraudeResponse>> AlterarSuspeitaFraudeAsyncWithHttpInfo (long? id, SuspeitaFraudeUpdate suspeitaFraudeUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarSuspeitaFraude");
            // verify the required parameter 'suspeitaFraudeUpdate' is set
            if (suspeitaFraudeUpdate == null) throw new ApiException(400, "Missing required parameter 'suspeitaFraudeUpdate' when calling AlterarSuspeitaFraude");
            
    
            var localVarPath = "/api/fraudes/suspeitas/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (suspeitaFraudeUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(suspeitaFraudeUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = suspeitaFraudeUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarSuspeitaFraude: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarSuspeitaFraude: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SuspeitaFraudeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuspeitaFraudeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuspeitaFraudeResponse)));
            
        }
        
        /// <summary>
        /// Cadastra motivo fraude Recurso para cadastrar os motivos fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="motivoFraudePersist">motivoFraudePersist</param> 
        /// <returns>MotivoFraudeResponse</returns>
        public MotivoFraudeResponse CadastrarMotivoFraude (MotivoFraudePersist motivoFraudePersist)
        {
             ApiResponse<MotivoFraudeResponse> localVarResponse = CadastrarMotivoFraudeWithHttpInfo(motivoFraudePersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastra motivo fraude Recurso para cadastrar os motivos fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="motivoFraudePersist">motivoFraudePersist</param> 
        /// <returns>ApiResponse of MotivoFraudeResponse</returns>
        public ApiResponse< MotivoFraudeResponse > CadastrarMotivoFraudeWithHttpInfo (MotivoFraudePersist motivoFraudePersist)
        {
            
            // verify the required parameter 'motivoFraudePersist' is set
            if (motivoFraudePersist == null)
                throw new ApiException(400, "Missing required parameter 'motivoFraudePersist' when calling FraudeApi->CadastrarMotivoFraude");
            
    
            var localVarPath = "/api/fraudes/motivos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (motivoFraudePersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(motivoFraudePersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = motivoFraudePersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarMotivoFraude: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarMotivoFraude: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<MotivoFraudeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MotivoFraudeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MotivoFraudeResponse)));
            
        }

        
        /// <summary>
        /// Cadastra motivo fraude Recurso para cadastrar os motivos fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="motivoFraudePersist">motivoFraudePersist</param>
        /// <returns>Task of MotivoFraudeResponse</returns>
        public async System.Threading.Tasks.Task<MotivoFraudeResponse> CadastrarMotivoFraudeAsync (MotivoFraudePersist motivoFraudePersist)
        {
             ApiResponse<MotivoFraudeResponse> localVarResponse = await CadastrarMotivoFraudeAsyncWithHttpInfo(motivoFraudePersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastra motivo fraude Recurso para cadastrar os motivos fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="motivoFraudePersist">motivoFraudePersist</param>
        /// <returns>Task of ApiResponse (MotivoFraudeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MotivoFraudeResponse>> CadastrarMotivoFraudeAsyncWithHttpInfo (MotivoFraudePersist motivoFraudePersist)
        {
            // verify the required parameter 'motivoFraudePersist' is set
            if (motivoFraudePersist == null) throw new ApiException(400, "Missing required parameter 'motivoFraudePersist' when calling CadastrarMotivoFraude");
            
    
            var localVarPath = "/api/fraudes/motivos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (motivoFraudePersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(motivoFraudePersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = motivoFraudePersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarMotivoFraude: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarMotivoFraude: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MotivoFraudeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MotivoFraudeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MotivoFraudeResponse)));
            
        }
        
        /// <summary>
        /// Consulta motivo fraude Recurso para consultar os motivos fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>MotivoFraudeResponse</returns>
        public MotivoFraudeResponse ConsultarMotivoFraude (long? id)
        {
             ApiResponse<MotivoFraudeResponse> localVarResponse = ConsultarMotivoFraudeWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta motivo fraude Recurso para consultar os motivos fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>ApiResponse of MotivoFraudeResponse</returns>
        public ApiResponse< MotivoFraudeResponse > ConsultarMotivoFraudeWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FraudeApi->ConsultarMotivoFraude");
            
    
            var localVarPath = "/api/fraudes/motivos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarMotivoFraude: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarMotivoFraude: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<MotivoFraudeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MotivoFraudeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MotivoFraudeResponse)));
            
        }

        
        /// <summary>
        /// Consulta motivo fraude Recurso para consultar os motivos fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of MotivoFraudeResponse</returns>
        public async System.Threading.Tasks.Task<MotivoFraudeResponse> ConsultarMotivoFraudeAsync (long? id)
        {
             ApiResponse<MotivoFraudeResponse> localVarResponse = await ConsultarMotivoFraudeAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta motivo fraude Recurso para consultar os motivos fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (MotivoFraudeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MotivoFraudeResponse>> ConsultarMotivoFraudeAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarMotivoFraude");
            
    
            var localVarPath = "/api/fraudes/motivos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarMotivoFraude: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarMotivoFraude: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MotivoFraudeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MotivoFraudeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MotivoFraudeResponse)));
            
        }
        
        /// <summary>
        /// Consulta suspeita de fraude Recurso para consultar suspeitas de fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da Suspeita de Fraude</param> 
        /// <returns>SuspeitaFraudeResponse</returns>
        public SuspeitaFraudeResponse ConsultarSuspeitaFraude (long? id)
        {
             ApiResponse<SuspeitaFraudeResponse> localVarResponse = ConsultarSuspeitaFraudeWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta suspeita de fraude Recurso para consultar suspeitas de fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da Suspeita de Fraude</param> 
        /// <returns>ApiResponse of SuspeitaFraudeResponse</returns>
        public ApiResponse< SuspeitaFraudeResponse > ConsultarSuspeitaFraudeWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FraudeApi->ConsultarSuspeitaFraude");
            
    
            var localVarPath = "/api/fraudes/suspeitas/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarSuspeitaFraude: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarSuspeitaFraude: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<SuspeitaFraudeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuspeitaFraudeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuspeitaFraudeResponse)));
            
        }

        
        /// <summary>
        /// Consulta suspeita de fraude Recurso para consultar suspeitas de fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da Suspeita de Fraude</param>
        /// <returns>Task of SuspeitaFraudeResponse</returns>
        public async System.Threading.Tasks.Task<SuspeitaFraudeResponse> ConsultarSuspeitaFraudeAsync (long? id)
        {
             ApiResponse<SuspeitaFraudeResponse> localVarResponse = await ConsultarSuspeitaFraudeAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta suspeita de fraude Recurso para consultar suspeitas de fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da Suspeita de Fraude</param>
        /// <returns>Task of ApiResponse (SuspeitaFraudeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SuspeitaFraudeResponse>> ConsultarSuspeitaFraudeAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarSuspeitaFraude");
            
    
            var localVarPath = "/api/fraudes/suspeitas/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarSuspeitaFraude: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarSuspeitaFraude: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SuspeitaFraudeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuspeitaFraudeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuspeitaFraudeResponse)));
            
        }
        
        /// <summary>
        /// Lista motivo fraude Recurso que lista os motivos fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o motivo fraude (optional)</param> 
        /// <returns>PageMotivoFraudeResponse</returns>
        public PageMotivoFraudeResponse ListarMotivoFraude (List<string> sort = null, int? page = null, int? limit = null, string descricao = null)
        {
             ApiResponse<PageMotivoFraudeResponse> localVarResponse = ListarMotivoFraudeWithHttpInfo(sort, page, limit, descricao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista motivo fraude Recurso que lista os motivos fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o motivo fraude (optional)</param> 
        /// <returns>ApiResponse of PageMotivoFraudeResponse</returns>
        public ApiResponse< PageMotivoFraudeResponse > ListarMotivoFraudeWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/fraudes/motivos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ListarMotivoFraude: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarMotivoFraude: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageMotivoFraudeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageMotivoFraudeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageMotivoFraudeResponse)));
            
        }

        
        /// <summary>
        /// Lista motivo fraude Recurso que lista os motivos fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o motivo fraude (optional)</param>
        /// <returns>Task of PageMotivoFraudeResponse</returns>
        public async System.Threading.Tasks.Task<PageMotivoFraudeResponse> ListarMotivoFraudeAsync (List<string> sort = null, int? page = null, int? limit = null, string descricao = null)
        {
             ApiResponse<PageMotivoFraudeResponse> localVarResponse = await ListarMotivoFraudeAsyncWithHttpInfo(sort, page, limit, descricao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista motivo fraude Recurso que lista os motivos fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o motivo fraude (optional)</param>
        /// <returns>Task of ApiResponse (PageMotivoFraudeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageMotivoFraudeResponse>> ListarMotivoFraudeAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/fraudes/motivos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ListarMotivoFraude: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarMotivoFraude: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageMotivoFraudeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageMotivoFraudeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageMotivoFraudeResponse)));
            
        }
        
        /// <summary>
        /// Lista suspeitas de fraude Recursos para listagens das suspeitas de fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idMotivoFraude">C\u00F3digo de identifica\u00E7\u00E3o do motivo da suspeita de fraude (optional)</param> 
        /// <param name="idPessoa">C\u00F3digo de identifica\u00E7\u00E3o da pessoa com suspeita de fraude (optional)</param> 
        /// <param name="dataSuspeitaFraudeInicial">Data in\u00EDcio do per\u00EDodo da consulta (optional)</param> 
        /// <param name="dataSuspeitaFraudeFinal">Data fim do per\u00EDodo da consulta (optional)</param> 
        /// <returns>PageSuspeitaFraudeResponse</returns>
        public PageSuspeitaFraudeResponse ListarSuspeitaFraude (List<string> sort = null, int? page = null, int? limit = null, long? idMotivoFraude = null, long? idPessoa = null, string dataSuspeitaFraudeInicial = null, string dataSuspeitaFraudeFinal = null)
        {
             ApiResponse<PageSuspeitaFraudeResponse> localVarResponse = ListarSuspeitaFraudeWithHttpInfo(sort, page, limit, idMotivoFraude, idPessoa, dataSuspeitaFraudeInicial, dataSuspeitaFraudeFinal);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista suspeitas de fraude Recursos para listagens das suspeitas de fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idMotivoFraude">C\u00F3digo de identifica\u00E7\u00E3o do motivo da suspeita de fraude (optional)</param> 
        /// <param name="idPessoa">C\u00F3digo de identifica\u00E7\u00E3o da pessoa com suspeita de fraude (optional)</param> 
        /// <param name="dataSuspeitaFraudeInicial">Data in\u00EDcio do per\u00EDodo da consulta (optional)</param> 
        /// <param name="dataSuspeitaFraudeFinal">Data fim do per\u00EDodo da consulta (optional)</param> 
        /// <returns>ApiResponse of PageSuspeitaFraudeResponse</returns>
        public ApiResponse< PageSuspeitaFraudeResponse > ListarSuspeitaFraudeWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idMotivoFraude = null, long? idPessoa = null, string dataSuspeitaFraudeInicial = null, string dataSuspeitaFraudeFinal = null)
        {
            
    
            var localVarPath = "/api/fraudes/suspeitas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idMotivoFraude != null) localVarQueryParams.Add("idMotivoFraude", Configuration.ApiClient.ParameterToString(idMotivoFraude)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (dataSuspeitaFraudeInicial != null) localVarQueryParams.Add("dataSuspeitaFraudeInicial", Configuration.ApiClient.ParameterToString(dataSuspeitaFraudeInicial)); // query parameter
            if (dataSuspeitaFraudeFinal != null) localVarQueryParams.Add("dataSuspeitaFraudeFinal", Configuration.ApiClient.ParameterToString(dataSuspeitaFraudeFinal)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarSuspeitaFraude: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarSuspeitaFraude: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageSuspeitaFraudeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageSuspeitaFraudeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageSuspeitaFraudeResponse)));
            
        }

        
        /// <summary>
        /// Lista suspeitas de fraude Recursos para listagens das suspeitas de fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idMotivoFraude">C\u00F3digo de identifica\u00E7\u00E3o do motivo da suspeita de fraude (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de identifica\u00E7\u00E3o da pessoa com suspeita de fraude (optional)</param>
        /// <param name="dataSuspeitaFraudeInicial">Data in\u00EDcio do per\u00EDodo da consulta (optional)</param>
        /// <param name="dataSuspeitaFraudeFinal">Data fim do per\u00EDodo da consulta (optional)</param>
        /// <returns>Task of PageSuspeitaFraudeResponse</returns>
        public async System.Threading.Tasks.Task<PageSuspeitaFraudeResponse> ListarSuspeitaFraudeAsync (List<string> sort = null, int? page = null, int? limit = null, long? idMotivoFraude = null, long? idPessoa = null, string dataSuspeitaFraudeInicial = null, string dataSuspeitaFraudeFinal = null)
        {
             ApiResponse<PageSuspeitaFraudeResponse> localVarResponse = await ListarSuspeitaFraudeAsyncWithHttpInfo(sort, page, limit, idMotivoFraude, idPessoa, dataSuspeitaFraudeInicial, dataSuspeitaFraudeFinal);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista suspeitas de fraude Recursos para listagens das suspeitas de fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idMotivoFraude">C\u00F3digo de identifica\u00E7\u00E3o do motivo da suspeita de fraude (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de identifica\u00E7\u00E3o da pessoa com suspeita de fraude (optional)</param>
        /// <param name="dataSuspeitaFraudeInicial">Data in\u00EDcio do per\u00EDodo da consulta (optional)</param>
        /// <param name="dataSuspeitaFraudeFinal">Data fim do per\u00EDodo da consulta (optional)</param>
        /// <returns>Task of ApiResponse (PageSuspeitaFraudeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageSuspeitaFraudeResponse>> ListarSuspeitaFraudeAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idMotivoFraude = null, long? idPessoa = null, string dataSuspeitaFraudeInicial = null, string dataSuspeitaFraudeFinal = null)
        {
            
    
            var localVarPath = "/api/fraudes/suspeitas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idMotivoFraude != null) localVarQueryParams.Add("idMotivoFraude", Configuration.ApiClient.ParameterToString(idMotivoFraude)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (dataSuspeitaFraudeInicial != null) localVarQueryParams.Add("dataSuspeitaFraudeInicial", Configuration.ApiClient.ParameterToString(dataSuspeitaFraudeInicial)); // query parameter
            if (dataSuspeitaFraudeFinal != null) localVarQueryParams.Add("dataSuspeitaFraudeFinal", Configuration.ApiClient.ParameterToString(dataSuspeitaFraudeFinal)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarSuspeitaFraude: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarSuspeitaFraude: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageSuspeitaFraudeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageSuspeitaFraudeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageSuspeitaFraudeResponse)));
            
        }
        
        /// <summary>
        /// Cadastra suspeita de fraude Recurso para cadastrar as suspeitas de fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="suspeitaFraudePersist">suspeitaFraudePersist</param> 
        /// <returns>SuspeitaFraudeResponse</returns>
        public SuspeitaFraudeResponse SalvarSuspeitaFraude (SuspeitaFraudePersist suspeitaFraudePersist)
        {
             ApiResponse<SuspeitaFraudeResponse> localVarResponse = SalvarSuspeitaFraudeWithHttpInfo(suspeitaFraudePersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastra suspeita de fraude Recurso para cadastrar as suspeitas de fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="suspeitaFraudePersist">suspeitaFraudePersist</param> 
        /// <returns>ApiResponse of SuspeitaFraudeResponse</returns>
        public ApiResponse< SuspeitaFraudeResponse > SalvarSuspeitaFraudeWithHttpInfo (SuspeitaFraudePersist suspeitaFraudePersist)
        {
            
            // verify the required parameter 'suspeitaFraudePersist' is set
            if (suspeitaFraudePersist == null)
                throw new ApiException(400, "Missing required parameter 'suspeitaFraudePersist' when calling FraudeApi->SalvarSuspeitaFraude");
            
    
            var localVarPath = "/api/fraudes/suspeitas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (suspeitaFraudePersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(suspeitaFraudePersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = suspeitaFraudePersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarSuspeitaFraude: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarSuspeitaFraude: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<SuspeitaFraudeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuspeitaFraudeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuspeitaFraudeResponse)));
            
        }

        
        /// <summary>
        /// Cadastra suspeita de fraude Recurso para cadastrar as suspeitas de fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="suspeitaFraudePersist">suspeitaFraudePersist</param>
        /// <returns>Task of SuspeitaFraudeResponse</returns>
        public async System.Threading.Tasks.Task<SuspeitaFraudeResponse> SalvarSuspeitaFraudeAsync (SuspeitaFraudePersist suspeitaFraudePersist)
        {
             ApiResponse<SuspeitaFraudeResponse> localVarResponse = await SalvarSuspeitaFraudeAsyncWithHttpInfo(suspeitaFraudePersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastra suspeita de fraude Recurso para cadastrar as suspeitas de fraude
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="suspeitaFraudePersist">suspeitaFraudePersist</param>
        /// <returns>Task of ApiResponse (SuspeitaFraudeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SuspeitaFraudeResponse>> SalvarSuspeitaFraudeAsyncWithHttpInfo (SuspeitaFraudePersist suspeitaFraudePersist)
        {
            // verify the required parameter 'suspeitaFraudePersist' is set
            if (suspeitaFraudePersist == null) throw new ApiException(400, "Missing required parameter 'suspeitaFraudePersist' when calling SalvarSuspeitaFraude");
            
    
            var localVarPath = "/api/fraudes/suspeitas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (suspeitaFraudePersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(suspeitaFraudePersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = suspeitaFraudePersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarSuspeitaFraude: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarSuspeitaFraude: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SuspeitaFraudeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuspeitaFraudeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuspeitaFraudeResponse)));
            
        }
        
    }
    
}
