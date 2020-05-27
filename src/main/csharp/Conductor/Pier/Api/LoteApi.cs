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
    public interface ILoteApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Atualiza um lote de cart\u00E3o Noname
        /// </summary>
        /// <remarks>
        /// Este recurso permite Atualiza um lote de cart\u00E3o Noname
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="loteCartaoUpdate">loteCartaoUpdate</param>
        /// <returns>LoteCartaoResponse</returns>
        LoteCartaoResponse AtualizarLotesCartoes (long? id, LoteCartaoUpdate loteCartaoUpdate);
  
        /// <summary>
        /// Atualiza um lote de cart\u00E3o Noname
        /// </summary>
        /// <remarks>
        /// Este recurso permite Atualiza um lote de cart\u00E3o Noname
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="loteCartaoUpdate">loteCartaoUpdate</param>
        /// <returns>ApiResponse of LoteCartaoResponse</returns>
        ApiResponse<LoteCartaoResponse> AtualizarLotesCartoesWithHttpInfo (long? id, LoteCartaoUpdate loteCartaoUpdate);
        
        /// <summary>
        /// Consulta um lote de cart\u00E3o Noname cadastrado
        /// </summary>
        /// <remarks>
        /// Este recurso permite Consulta um lote de cart\u00E3o Noname cadastrado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>LoteCartaoResponse</returns>
        LoteCartaoResponse ConsultarLotesCartoes (long? id);
  
        /// <summary>
        /// Consulta um lote de cart\u00E3o Noname cadastrado
        /// </summary>
        /// <remarks>
        /// Este recurso permite Consulta um lote de cart\u00E3o Noname cadastrado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>ApiResponse of LoteCartaoResponse</returns>
        ApiResponse<LoteCartaoResponse> ConsultarLotesCartoesWithHttpInfo (long? id);
        
        /// <summary>
        /// Remove um lote de cart\u00E3o Noname com status criado
        /// </summary>
        /// <remarks>
        /// Este recurso permite remover um lote de cart\u00E3o Noname com status criado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Object</returns>
        Object DeletarLotesCartoes (long? id);
  
        /// <summary>
        /// Remove um lote de cart\u00E3o Noname com status criado
        /// </summary>
        /// <remarks>
        /// Este recurso permite remover um lote de cart\u00E3o Noname com status criado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> DeletarLotesCartoesWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista os identificadores de lotes e cart\u00F5es
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os identificadores de lotes e de cart\u00F5es Noname cadastrados
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (optional)</param>
        /// <param name="idLote">C\u00F3digo de identifica\u00E7\u00E3o do lote (optional)</param>
        /// <param name="idCartaoPai">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o pai (optional)</param>
        /// <returns>PageCartaoLoteResponse</returns>
        PageCartaoLoteResponse ListarIdentificadoresCartoesLotes (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, long? idLote = null, long? idCartaoPai = null);
  
        /// <summary>
        /// Lista os identificadores de lotes e cart\u00F5es
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os identificadores de lotes e de cart\u00F5es Noname cadastrados
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (optional)</param>
        /// <param name="idLote">C\u00F3digo de identifica\u00E7\u00E3o do lote (optional)</param>
        /// <param name="idCartaoPai">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o pai (optional)</param>
        /// <returns>ApiResponse of PageCartaoLoteResponse</returns>
        ApiResponse<PageCartaoLoteResponse> ListarIdentificadoresCartoesLotesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, long? idLote = null, long? idCartaoPai = null);
        
        /// <summary>
        /// Lista os lotes de cart\u00F5es Noname cadastrados
        /// </summary>
        /// <remarks>
        /// Este recurso permite lista os lotes de cart\u00F5es Noname cadastrados
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="qtdSolicitada">Quantidade de cart\u00F5es a ser emitido (optional)</param>
        /// <param name="idProduto">C\u00F3digo identificador do produto (optional)</param>
        /// <param name="idSolicitante">C\u00F3digo identificador do solicitante (optional)</param>
        /// <param name="idOrigemComercial">C\u00F3digo identificador da origem comercial (optional)</param>
        /// <param name="idPlastico">C\u00F3digo identificador do tipo pl\u00E1stico associado ao produto (optional)</param>
        /// <param name="idImagem">C\u00F3digo identificador do tipo pl\u00E1stico imagem (optional)</param>
        /// <param name="idContaDefault">C\u00F3digo identificador da conta padr\u00E3o (optional)</param>
        /// <param name="flagMultiApp">Lote de cart\u00F5es m\u00FAltiplos (optional)</param>
        /// <param name="dataAgendamento">Data de agendamento do lote (optional)</param>
        /// <param name="tipoLote">Tipo do lote agendado (optional)</param>
        /// <param name="statusLote">Status do lote (optional)</param>
        /// <returns>PageLoteCartaoResponse</returns>
        PageLoteCartaoResponse ListarLotesCartoes (List<string> sort = null, int? page = null, int? limit = null, int? qtdSolicitada = null, long? idProduto = null, long? idSolicitante = null, long? idOrigemComercial = null, long? idPlastico = null, long? idImagem = null, long? idContaDefault = null, bool? flagMultiApp = null, string dataAgendamento = null, int? tipoLote = null, int? statusLote = null);
  
        /// <summary>
        /// Lista os lotes de cart\u00F5es Noname cadastrados
        /// </summary>
        /// <remarks>
        /// Este recurso permite lista os lotes de cart\u00F5es Noname cadastrados
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="qtdSolicitada">Quantidade de cart\u00F5es a ser emitido (optional)</param>
        /// <param name="idProduto">C\u00F3digo identificador do produto (optional)</param>
        /// <param name="idSolicitante">C\u00F3digo identificador do solicitante (optional)</param>
        /// <param name="idOrigemComercial">C\u00F3digo identificador da origem comercial (optional)</param>
        /// <param name="idPlastico">C\u00F3digo identificador do tipo pl\u00E1stico associado ao produto (optional)</param>
        /// <param name="idImagem">C\u00F3digo identificador do tipo pl\u00E1stico imagem (optional)</param>
        /// <param name="idContaDefault">C\u00F3digo identificador da conta padr\u00E3o (optional)</param>
        /// <param name="flagMultiApp">Lote de cart\u00F5es m\u00FAltiplos (optional)</param>
        /// <param name="dataAgendamento">Data de agendamento do lote (optional)</param>
        /// <param name="tipoLote">Tipo do lote agendado (optional)</param>
        /// <param name="statusLote">Status do lote (optional)</param>
        /// <returns>ApiResponse of PageLoteCartaoResponse</returns>
        ApiResponse<PageLoteCartaoResponse> ListarLotesCartoesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, int? qtdSolicitada = null, long? idProduto = null, long? idSolicitante = null, long? idOrigemComercial = null, long? idPlastico = null, long? idImagem = null, long? idContaDefault = null, bool? flagMultiApp = null, string dataAgendamento = null, int? tipoLote = null, int? statusLote = null);
        
        /// <summary>
        /// Cadastra um lote de cart\u00F5es Noname
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastra um lote de cart\u00F5es Noname
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loteCartaoPersist">loteCartaoPersist</param>
        /// <returns>LoteCartaoResponse</returns>
        LoteCartaoResponse SalvarLotesCartoes (LoteCartaoPersist loteCartaoPersist);
  
        /// <summary>
        /// Cadastra um lote de cart\u00F5es Noname
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastra um lote de cart\u00F5es Noname
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loteCartaoPersist">loteCartaoPersist</param>
        /// <returns>ApiResponse of LoteCartaoResponse</returns>
        ApiResponse<LoteCartaoResponse> SalvarLotesCartoesWithHttpInfo (LoteCartaoPersist loteCartaoPersist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Atualiza um lote de cart\u00E3o Noname
        /// </summary>
        /// <remarks>
        /// Este recurso permite Atualiza um lote de cart\u00E3o Noname
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="loteCartaoUpdate">loteCartaoUpdate</param>
        /// <returns>Task of LoteCartaoResponse</returns>
        System.Threading.Tasks.Task<LoteCartaoResponse> AtualizarLotesCartoesAsync (long? id, LoteCartaoUpdate loteCartaoUpdate);

        /// <summary>
        /// Atualiza um lote de cart\u00E3o Noname
        /// </summary>
        /// <remarks>
        /// Este recurso permite Atualiza um lote de cart\u00E3o Noname
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="loteCartaoUpdate">loteCartaoUpdate</param>
        /// <returns>Task of ApiResponse (LoteCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LoteCartaoResponse>> AtualizarLotesCartoesAsyncWithHttpInfo (long? id, LoteCartaoUpdate loteCartaoUpdate);
        
        /// <summary>
        /// Consulta um lote de cart\u00E3o Noname cadastrado
        /// </summary>
        /// <remarks>
        /// Este recurso permite Consulta um lote de cart\u00E3o Noname cadastrado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of LoteCartaoResponse</returns>
        System.Threading.Tasks.Task<LoteCartaoResponse> ConsultarLotesCartoesAsync (long? id);

        /// <summary>
        /// Consulta um lote de cart\u00E3o Noname cadastrado
        /// </summary>
        /// <remarks>
        /// Este recurso permite Consulta um lote de cart\u00E3o Noname cadastrado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (LoteCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LoteCartaoResponse>> ConsultarLotesCartoesAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Remove um lote de cart\u00E3o Noname com status criado
        /// </summary>
        /// <remarks>
        /// Este recurso permite remover um lote de cart\u00E3o Noname com status criado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> DeletarLotesCartoesAsync (long? id);

        /// <summary>
        /// Remove um lote de cart\u00E3o Noname com status criado
        /// </summary>
        /// <remarks>
        /// Este recurso permite remover um lote de cart\u00E3o Noname com status criado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeletarLotesCartoesAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista os identificadores de lotes e cart\u00F5es
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os identificadores de lotes e de cart\u00F5es Noname cadastrados
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (optional)</param>
        /// <param name="idLote">C\u00F3digo de identifica\u00E7\u00E3o do lote (optional)</param>
        /// <param name="idCartaoPai">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o pai (optional)</param>
        /// <returns>Task of PageCartaoLoteResponse</returns>
        System.Threading.Tasks.Task<PageCartaoLoteResponse> ListarIdentificadoresCartoesLotesAsync (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, long? idLote = null, long? idCartaoPai = null);

        /// <summary>
        /// Lista os identificadores de lotes e cart\u00F5es
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os identificadores de lotes e de cart\u00F5es Noname cadastrados
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (optional)</param>
        /// <param name="idLote">C\u00F3digo de identifica\u00E7\u00E3o do lote (optional)</param>
        /// <param name="idCartaoPai">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o pai (optional)</param>
        /// <returns>Task of ApiResponse (PageCartaoLoteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCartaoLoteResponse>> ListarIdentificadoresCartoesLotesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, long? idLote = null, long? idCartaoPai = null);
        
        /// <summary>
        /// Lista os lotes de cart\u00F5es Noname cadastrados
        /// </summary>
        /// <remarks>
        /// Este recurso permite lista os lotes de cart\u00F5es Noname cadastrados
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="qtdSolicitada">Quantidade de cart\u00F5es a ser emitido (optional)</param>
        /// <param name="idProduto">C\u00F3digo identificador do produto (optional)</param>
        /// <param name="idSolicitante">C\u00F3digo identificador do solicitante (optional)</param>
        /// <param name="idOrigemComercial">C\u00F3digo identificador da origem comercial (optional)</param>
        /// <param name="idPlastico">C\u00F3digo identificador do tipo pl\u00E1stico associado ao produto (optional)</param>
        /// <param name="idImagem">C\u00F3digo identificador do tipo pl\u00E1stico imagem (optional)</param>
        /// <param name="idContaDefault">C\u00F3digo identificador da conta padr\u00E3o (optional)</param>
        /// <param name="flagMultiApp">Lote de cart\u00F5es m\u00FAltiplos (optional)</param>
        /// <param name="dataAgendamento">Data de agendamento do lote (optional)</param>
        /// <param name="tipoLote">Tipo do lote agendado (optional)</param>
        /// <param name="statusLote">Status do lote (optional)</param>
        /// <returns>Task of PageLoteCartaoResponse</returns>
        System.Threading.Tasks.Task<PageLoteCartaoResponse> ListarLotesCartoesAsync (List<string> sort = null, int? page = null, int? limit = null, int? qtdSolicitada = null, long? idProduto = null, long? idSolicitante = null, long? idOrigemComercial = null, long? idPlastico = null, long? idImagem = null, long? idContaDefault = null, bool? flagMultiApp = null, string dataAgendamento = null, int? tipoLote = null, int? statusLote = null);

        /// <summary>
        /// Lista os lotes de cart\u00F5es Noname cadastrados
        /// </summary>
        /// <remarks>
        /// Este recurso permite lista os lotes de cart\u00F5es Noname cadastrados
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="qtdSolicitada">Quantidade de cart\u00F5es a ser emitido (optional)</param>
        /// <param name="idProduto">C\u00F3digo identificador do produto (optional)</param>
        /// <param name="idSolicitante">C\u00F3digo identificador do solicitante (optional)</param>
        /// <param name="idOrigemComercial">C\u00F3digo identificador da origem comercial (optional)</param>
        /// <param name="idPlastico">C\u00F3digo identificador do tipo pl\u00E1stico associado ao produto (optional)</param>
        /// <param name="idImagem">C\u00F3digo identificador do tipo pl\u00E1stico imagem (optional)</param>
        /// <param name="idContaDefault">C\u00F3digo identificador da conta padr\u00E3o (optional)</param>
        /// <param name="flagMultiApp">Lote de cart\u00F5es m\u00FAltiplos (optional)</param>
        /// <param name="dataAgendamento">Data de agendamento do lote (optional)</param>
        /// <param name="tipoLote">Tipo do lote agendado (optional)</param>
        /// <param name="statusLote">Status do lote (optional)</param>
        /// <returns>Task of ApiResponse (PageLoteCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageLoteCartaoResponse>> ListarLotesCartoesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, int? qtdSolicitada = null, long? idProduto = null, long? idSolicitante = null, long? idOrigemComercial = null, long? idPlastico = null, long? idImagem = null, long? idContaDefault = null, bool? flagMultiApp = null, string dataAgendamento = null, int? tipoLote = null, int? statusLote = null);
        
        /// <summary>
        /// Cadastra um lote de cart\u00F5es Noname
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastra um lote de cart\u00F5es Noname
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loteCartaoPersist">loteCartaoPersist</param>
        /// <returns>Task of LoteCartaoResponse</returns>
        System.Threading.Tasks.Task<LoteCartaoResponse> SalvarLotesCartoesAsync (LoteCartaoPersist loteCartaoPersist);

        /// <summary>
        /// Cadastra um lote de cart\u00F5es Noname
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastra um lote de cart\u00F5es Noname
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loteCartaoPersist">loteCartaoPersist</param>
        /// <returns>Task of ApiResponse (LoteCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LoteCartaoResponse>> SalvarLotesCartoesAsyncWithHttpInfo (LoteCartaoPersist loteCartaoPersist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LoteApi : ILoteApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoteApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LoteApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LoteApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LoteApi(Configuration configuration = null)
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
        /// Atualiza um lote de cart\u00E3o Noname Este recurso permite Atualiza um lote de cart\u00E3o Noname
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="loteCartaoUpdate">loteCartaoUpdate</param> 
        /// <returns>LoteCartaoResponse</returns>
        public LoteCartaoResponse AtualizarLotesCartoes (long? id, LoteCartaoUpdate loteCartaoUpdate)
        {
             ApiResponse<LoteCartaoResponse> localVarResponse = AtualizarLotesCartoesWithHttpInfo(id, loteCartaoUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualiza um lote de cart\u00E3o Noname Este recurso permite Atualiza um lote de cart\u00E3o Noname
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="loteCartaoUpdate">loteCartaoUpdate</param> 
        /// <returns>ApiResponse of LoteCartaoResponse</returns>
        public ApiResponse< LoteCartaoResponse > AtualizarLotesCartoesWithHttpInfo (long? id, LoteCartaoUpdate loteCartaoUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling LoteApi->AtualizarLotesCartoes");
            
            // verify the required parameter 'loteCartaoUpdate' is set
            if (loteCartaoUpdate == null)
                throw new ApiException(400, "Missing required parameter 'loteCartaoUpdate' when calling LoteApi->AtualizarLotesCartoes");
            
    
            var localVarPath = "/api/lotes/cartoes/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (loteCartaoUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(loteCartaoUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = loteCartaoUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarLotesCartoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarLotesCartoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LoteCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LoteCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LoteCartaoResponse)));
            
        }

        
        /// <summary>
        /// Atualiza um lote de cart\u00E3o Noname Este recurso permite Atualiza um lote de cart\u00E3o Noname
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="loteCartaoUpdate">loteCartaoUpdate</param>
        /// <returns>Task of LoteCartaoResponse</returns>
        public async System.Threading.Tasks.Task<LoteCartaoResponse> AtualizarLotesCartoesAsync (long? id, LoteCartaoUpdate loteCartaoUpdate)
        {
             ApiResponse<LoteCartaoResponse> localVarResponse = await AtualizarLotesCartoesAsyncWithHttpInfo(id, loteCartaoUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualiza um lote de cart\u00E3o Noname Este recurso permite Atualiza um lote de cart\u00E3o Noname
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="loteCartaoUpdate">loteCartaoUpdate</param>
        /// <returns>Task of ApiResponse (LoteCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LoteCartaoResponse>> AtualizarLotesCartoesAsyncWithHttpInfo (long? id, LoteCartaoUpdate loteCartaoUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarLotesCartoes");
            // verify the required parameter 'loteCartaoUpdate' is set
            if (loteCartaoUpdate == null) throw new ApiException(400, "Missing required parameter 'loteCartaoUpdate' when calling AtualizarLotesCartoes");
            
    
            var localVarPath = "/api/lotes/cartoes/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (loteCartaoUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(loteCartaoUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = loteCartaoUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarLotesCartoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarLotesCartoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LoteCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LoteCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LoteCartaoResponse)));
            
        }
        
        /// <summary>
        /// Consulta um lote de cart\u00E3o Noname cadastrado Este recurso permite Consulta um lote de cart\u00E3o Noname cadastrado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>LoteCartaoResponse</returns>
        public LoteCartaoResponse ConsultarLotesCartoes (long? id)
        {
             ApiResponse<LoteCartaoResponse> localVarResponse = ConsultarLotesCartoesWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta um lote de cart\u00E3o Noname cadastrado Este recurso permite Consulta um lote de cart\u00E3o Noname cadastrado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>ApiResponse of LoteCartaoResponse</returns>
        public ApiResponse< LoteCartaoResponse > ConsultarLotesCartoesWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling LoteApi->ConsultarLotesCartoes");
            
    
            var localVarPath = "/api/lotes/cartoes/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLotesCartoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLotesCartoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LoteCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LoteCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LoteCartaoResponse)));
            
        }

        
        /// <summary>
        /// Consulta um lote de cart\u00E3o Noname cadastrado Este recurso permite Consulta um lote de cart\u00E3o Noname cadastrado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of LoteCartaoResponse</returns>
        public async System.Threading.Tasks.Task<LoteCartaoResponse> ConsultarLotesCartoesAsync (long? id)
        {
             ApiResponse<LoteCartaoResponse> localVarResponse = await ConsultarLotesCartoesAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta um lote de cart\u00E3o Noname cadastrado Este recurso permite Consulta um lote de cart\u00E3o Noname cadastrado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (LoteCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LoteCartaoResponse>> ConsultarLotesCartoesAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarLotesCartoes");
            
    
            var localVarPath = "/api/lotes/cartoes/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLotesCartoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLotesCartoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LoteCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LoteCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LoteCartaoResponse)));
            
        }
        
        /// <summary>
        /// Remove um lote de cart\u00E3o Noname com status criado Este recurso permite remover um lote de cart\u00E3o Noname com status criado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>Object</returns>
        public Object DeletarLotesCartoes (long? id)
        {
             ApiResponse<Object> localVarResponse = DeletarLotesCartoesWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Remove um lote de cart\u00E3o Noname com status criado Este recurso permite remover um lote de cart\u00E3o Noname com status criado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > DeletarLotesCartoesWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling LoteApi->DeletarLotesCartoes");
            
    
            var localVarPath = "/api/lotes/cartoes/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling DeletarLotesCartoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletarLotesCartoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Remove um lote de cart\u00E3o Noname com status criado Este recurso permite remover um lote de cart\u00E3o Noname com status criado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> DeletarLotesCartoesAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await DeletarLotesCartoesAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Remove um lote de cart\u00E3o Noname com status criado Este recurso permite remover um lote de cart\u00E3o Noname com status criado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeletarLotesCartoesAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeletarLotesCartoes");
            
    
            var localVarPath = "/api/lotes/cartoes/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling DeletarLotesCartoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletarLotesCartoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Lista os identificadores de lotes e cart\u00F5es Este recurso permite listar os identificadores de lotes e de cart\u00F5es Noname cadastrados
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idCartao">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (optional)</param> 
        /// <param name="idLote">C\u00F3digo de identifica\u00E7\u00E3o do lote (optional)</param> 
        /// <param name="idCartaoPai">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o pai (optional)</param> 
        /// <returns>PageCartaoLoteResponse</returns>
        public PageCartaoLoteResponse ListarIdentificadoresCartoesLotes (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, long? idLote = null, long? idCartaoPai = null)
        {
             ApiResponse<PageCartaoLoteResponse> localVarResponse = ListarIdentificadoresCartoesLotesWithHttpInfo(sort, page, limit, idCartao, idLote, idCartaoPai);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os identificadores de lotes e cart\u00F5es Este recurso permite listar os identificadores de lotes e de cart\u00F5es Noname cadastrados
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idCartao">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (optional)</param> 
        /// <param name="idLote">C\u00F3digo de identifica\u00E7\u00E3o do lote (optional)</param> 
        /// <param name="idCartaoPai">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o pai (optional)</param> 
        /// <returns>ApiResponse of PageCartaoLoteResponse</returns>
        public ApiResponse< PageCartaoLoteResponse > ListarIdentificadoresCartoesLotesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, long? idLote = null, long? idCartaoPai = null)
        {
            
    
            var localVarPath = "/api/lotes/cartoes/identificadores";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idCartao != null) localVarQueryParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // query parameter
            if (idLote != null) localVarQueryParams.Add("idLote", Configuration.ApiClient.ParameterToString(idLote)); // query parameter
            if (idCartaoPai != null) localVarQueryParams.Add("idCartaoPai", Configuration.ApiClient.ParameterToString(idCartaoPai)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarIdentificadoresCartoesLotes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarIdentificadoresCartoesLotes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCartaoLoteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCartaoLoteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCartaoLoteResponse)));
            
        }

        
        /// <summary>
        /// Lista os identificadores de lotes e cart\u00F5es Este recurso permite listar os identificadores de lotes e de cart\u00F5es Noname cadastrados
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (optional)</param>
        /// <param name="idLote">C\u00F3digo de identifica\u00E7\u00E3o do lote (optional)</param>
        /// <param name="idCartaoPai">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o pai (optional)</param>
        /// <returns>Task of PageCartaoLoteResponse</returns>
        public async System.Threading.Tasks.Task<PageCartaoLoteResponse> ListarIdentificadoresCartoesLotesAsync (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, long? idLote = null, long? idCartaoPai = null)
        {
             ApiResponse<PageCartaoLoteResponse> localVarResponse = await ListarIdentificadoresCartoesLotesAsyncWithHttpInfo(sort, page, limit, idCartao, idLote, idCartaoPai);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os identificadores de lotes e cart\u00F5es Este recurso permite listar os identificadores de lotes e de cart\u00F5es Noname cadastrados
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (optional)</param>
        /// <param name="idLote">C\u00F3digo de identifica\u00E7\u00E3o do lote (optional)</param>
        /// <param name="idCartaoPai">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o pai (optional)</param>
        /// <returns>Task of ApiResponse (PageCartaoLoteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCartaoLoteResponse>> ListarIdentificadoresCartoesLotesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, long? idLote = null, long? idCartaoPai = null)
        {
            
    
            var localVarPath = "/api/lotes/cartoes/identificadores";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idCartao != null) localVarQueryParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // query parameter
            if (idLote != null) localVarQueryParams.Add("idLote", Configuration.ApiClient.ParameterToString(idLote)); // query parameter
            if (idCartaoPai != null) localVarQueryParams.Add("idCartaoPai", Configuration.ApiClient.ParameterToString(idCartaoPai)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarIdentificadoresCartoesLotes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarIdentificadoresCartoesLotes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCartaoLoteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCartaoLoteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCartaoLoteResponse)));
            
        }
        
        /// <summary>
        /// Lista os lotes de cart\u00F5es Noname cadastrados Este recurso permite lista os lotes de cart\u00F5es Noname cadastrados
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="qtdSolicitada">Quantidade de cart\u00F5es a ser emitido (optional)</param> 
        /// <param name="idProduto">C\u00F3digo identificador do produto (optional)</param> 
        /// <param name="idSolicitante">C\u00F3digo identificador do solicitante (optional)</param> 
        /// <param name="idOrigemComercial">C\u00F3digo identificador da origem comercial (optional)</param> 
        /// <param name="idPlastico">C\u00F3digo identificador do tipo pl\u00E1stico associado ao produto (optional)</param> 
        /// <param name="idImagem">C\u00F3digo identificador do tipo pl\u00E1stico imagem (optional)</param> 
        /// <param name="idContaDefault">C\u00F3digo identificador da conta padr\u00E3o (optional)</param> 
        /// <param name="flagMultiApp">Lote de cart\u00F5es m\u00FAltiplos (optional)</param> 
        /// <param name="dataAgendamento">Data de agendamento do lote (optional)</param> 
        /// <param name="tipoLote">Tipo do lote agendado (optional)</param> 
        /// <param name="statusLote">Status do lote (optional)</param> 
        /// <returns>PageLoteCartaoResponse</returns>
        public PageLoteCartaoResponse ListarLotesCartoes (List<string> sort = null, int? page = null, int? limit = null, int? qtdSolicitada = null, long? idProduto = null, long? idSolicitante = null, long? idOrigemComercial = null, long? idPlastico = null, long? idImagem = null, long? idContaDefault = null, bool? flagMultiApp = null, string dataAgendamento = null, int? tipoLote = null, int? statusLote = null)
        {
             ApiResponse<PageLoteCartaoResponse> localVarResponse = ListarLotesCartoesWithHttpInfo(sort, page, limit, qtdSolicitada, idProduto, idSolicitante, idOrigemComercial, idPlastico, idImagem, idContaDefault, flagMultiApp, dataAgendamento, tipoLote, statusLote);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os lotes de cart\u00F5es Noname cadastrados Este recurso permite lista os lotes de cart\u00F5es Noname cadastrados
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="qtdSolicitada">Quantidade de cart\u00F5es a ser emitido (optional)</param> 
        /// <param name="idProduto">C\u00F3digo identificador do produto (optional)</param> 
        /// <param name="idSolicitante">C\u00F3digo identificador do solicitante (optional)</param> 
        /// <param name="idOrigemComercial">C\u00F3digo identificador da origem comercial (optional)</param> 
        /// <param name="idPlastico">C\u00F3digo identificador do tipo pl\u00E1stico associado ao produto (optional)</param> 
        /// <param name="idImagem">C\u00F3digo identificador do tipo pl\u00E1stico imagem (optional)</param> 
        /// <param name="idContaDefault">C\u00F3digo identificador da conta padr\u00E3o (optional)</param> 
        /// <param name="flagMultiApp">Lote de cart\u00F5es m\u00FAltiplos (optional)</param> 
        /// <param name="dataAgendamento">Data de agendamento do lote (optional)</param> 
        /// <param name="tipoLote">Tipo do lote agendado (optional)</param> 
        /// <param name="statusLote">Status do lote (optional)</param> 
        /// <returns>ApiResponse of PageLoteCartaoResponse</returns>
        public ApiResponse< PageLoteCartaoResponse > ListarLotesCartoesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, int? qtdSolicitada = null, long? idProduto = null, long? idSolicitante = null, long? idOrigemComercial = null, long? idPlastico = null, long? idImagem = null, long? idContaDefault = null, bool? flagMultiApp = null, string dataAgendamento = null, int? tipoLote = null, int? statusLote = null)
        {
            
    
            var localVarPath = "/api/lotes/cartoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (qtdSolicitada != null) localVarQueryParams.Add("qtdSolicitada", Configuration.ApiClient.ParameterToString(qtdSolicitada)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (idSolicitante != null) localVarQueryParams.Add("idSolicitante", Configuration.ApiClient.ParameterToString(idSolicitante)); // query parameter
            if (idOrigemComercial != null) localVarQueryParams.Add("idOrigemComercial", Configuration.ApiClient.ParameterToString(idOrigemComercial)); // query parameter
            if (idPlastico != null) localVarQueryParams.Add("idPlastico", Configuration.ApiClient.ParameterToString(idPlastico)); // query parameter
            if (idImagem != null) localVarQueryParams.Add("idImagem", Configuration.ApiClient.ParameterToString(idImagem)); // query parameter
            if (idContaDefault != null) localVarQueryParams.Add("idContaDefault", Configuration.ApiClient.ParameterToString(idContaDefault)); // query parameter
            if (flagMultiApp != null) localVarQueryParams.Add("flagMultiApp", Configuration.ApiClient.ParameterToString(flagMultiApp)); // query parameter
            if (dataAgendamento != null) localVarQueryParams.Add("dataAgendamento", Configuration.ApiClient.ParameterToString(dataAgendamento)); // query parameter
            if (tipoLote != null) localVarQueryParams.Add("tipoLote", Configuration.ApiClient.ParameterToString(tipoLote)); // query parameter
            if (statusLote != null) localVarQueryParams.Add("statusLote", Configuration.ApiClient.ParameterToString(statusLote)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarLotesCartoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarLotesCartoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageLoteCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageLoteCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageLoteCartaoResponse)));
            
        }

        
        /// <summary>
        /// Lista os lotes de cart\u00F5es Noname cadastrados Este recurso permite lista os lotes de cart\u00F5es Noname cadastrados
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="qtdSolicitada">Quantidade de cart\u00F5es a ser emitido (optional)</param>
        /// <param name="idProduto">C\u00F3digo identificador do produto (optional)</param>
        /// <param name="idSolicitante">C\u00F3digo identificador do solicitante (optional)</param>
        /// <param name="idOrigemComercial">C\u00F3digo identificador da origem comercial (optional)</param>
        /// <param name="idPlastico">C\u00F3digo identificador do tipo pl\u00E1stico associado ao produto (optional)</param>
        /// <param name="idImagem">C\u00F3digo identificador do tipo pl\u00E1stico imagem (optional)</param>
        /// <param name="idContaDefault">C\u00F3digo identificador da conta padr\u00E3o (optional)</param>
        /// <param name="flagMultiApp">Lote de cart\u00F5es m\u00FAltiplos (optional)</param>
        /// <param name="dataAgendamento">Data de agendamento do lote (optional)</param>
        /// <param name="tipoLote">Tipo do lote agendado (optional)</param>
        /// <param name="statusLote">Status do lote (optional)</param>
        /// <returns>Task of PageLoteCartaoResponse</returns>
        public async System.Threading.Tasks.Task<PageLoteCartaoResponse> ListarLotesCartoesAsync (List<string> sort = null, int? page = null, int? limit = null, int? qtdSolicitada = null, long? idProduto = null, long? idSolicitante = null, long? idOrigemComercial = null, long? idPlastico = null, long? idImagem = null, long? idContaDefault = null, bool? flagMultiApp = null, string dataAgendamento = null, int? tipoLote = null, int? statusLote = null)
        {
             ApiResponse<PageLoteCartaoResponse> localVarResponse = await ListarLotesCartoesAsyncWithHttpInfo(sort, page, limit, qtdSolicitada, idProduto, idSolicitante, idOrigemComercial, idPlastico, idImagem, idContaDefault, flagMultiApp, dataAgendamento, tipoLote, statusLote);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os lotes de cart\u00F5es Noname cadastrados Este recurso permite lista os lotes de cart\u00F5es Noname cadastrados
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="qtdSolicitada">Quantidade de cart\u00F5es a ser emitido (optional)</param>
        /// <param name="idProduto">C\u00F3digo identificador do produto (optional)</param>
        /// <param name="idSolicitante">C\u00F3digo identificador do solicitante (optional)</param>
        /// <param name="idOrigemComercial">C\u00F3digo identificador da origem comercial (optional)</param>
        /// <param name="idPlastico">C\u00F3digo identificador do tipo pl\u00E1stico associado ao produto (optional)</param>
        /// <param name="idImagem">C\u00F3digo identificador do tipo pl\u00E1stico imagem (optional)</param>
        /// <param name="idContaDefault">C\u00F3digo identificador da conta padr\u00E3o (optional)</param>
        /// <param name="flagMultiApp">Lote de cart\u00F5es m\u00FAltiplos (optional)</param>
        /// <param name="dataAgendamento">Data de agendamento do lote (optional)</param>
        /// <param name="tipoLote">Tipo do lote agendado (optional)</param>
        /// <param name="statusLote">Status do lote (optional)</param>
        /// <returns>Task of ApiResponse (PageLoteCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageLoteCartaoResponse>> ListarLotesCartoesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, int? qtdSolicitada = null, long? idProduto = null, long? idSolicitante = null, long? idOrigemComercial = null, long? idPlastico = null, long? idImagem = null, long? idContaDefault = null, bool? flagMultiApp = null, string dataAgendamento = null, int? tipoLote = null, int? statusLote = null)
        {
            
    
            var localVarPath = "/api/lotes/cartoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (qtdSolicitada != null) localVarQueryParams.Add("qtdSolicitada", Configuration.ApiClient.ParameterToString(qtdSolicitada)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (idSolicitante != null) localVarQueryParams.Add("idSolicitante", Configuration.ApiClient.ParameterToString(idSolicitante)); // query parameter
            if (idOrigemComercial != null) localVarQueryParams.Add("idOrigemComercial", Configuration.ApiClient.ParameterToString(idOrigemComercial)); // query parameter
            if (idPlastico != null) localVarQueryParams.Add("idPlastico", Configuration.ApiClient.ParameterToString(idPlastico)); // query parameter
            if (idImagem != null) localVarQueryParams.Add("idImagem", Configuration.ApiClient.ParameterToString(idImagem)); // query parameter
            if (idContaDefault != null) localVarQueryParams.Add("idContaDefault", Configuration.ApiClient.ParameterToString(idContaDefault)); // query parameter
            if (flagMultiApp != null) localVarQueryParams.Add("flagMultiApp", Configuration.ApiClient.ParameterToString(flagMultiApp)); // query parameter
            if (dataAgendamento != null) localVarQueryParams.Add("dataAgendamento", Configuration.ApiClient.ParameterToString(dataAgendamento)); // query parameter
            if (tipoLote != null) localVarQueryParams.Add("tipoLote", Configuration.ApiClient.ParameterToString(tipoLote)); // query parameter
            if (statusLote != null) localVarQueryParams.Add("statusLote", Configuration.ApiClient.ParameterToString(statusLote)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarLotesCartoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarLotesCartoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageLoteCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageLoteCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageLoteCartaoResponse)));
            
        }
        
        /// <summary>
        /// Cadastra um lote de cart\u00F5es Noname Este recurso permite cadastra um lote de cart\u00F5es Noname
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loteCartaoPersist">loteCartaoPersist</param> 
        /// <returns>LoteCartaoResponse</returns>
        public LoteCartaoResponse SalvarLotesCartoes (LoteCartaoPersist loteCartaoPersist)
        {
             ApiResponse<LoteCartaoResponse> localVarResponse = SalvarLotesCartoesWithHttpInfo(loteCartaoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastra um lote de cart\u00F5es Noname Este recurso permite cadastra um lote de cart\u00F5es Noname
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loteCartaoPersist">loteCartaoPersist</param> 
        /// <returns>ApiResponse of LoteCartaoResponse</returns>
        public ApiResponse< LoteCartaoResponse > SalvarLotesCartoesWithHttpInfo (LoteCartaoPersist loteCartaoPersist)
        {
            
            // verify the required parameter 'loteCartaoPersist' is set
            if (loteCartaoPersist == null)
                throw new ApiException(400, "Missing required parameter 'loteCartaoPersist' when calling LoteApi->SalvarLotesCartoes");
            
    
            var localVarPath = "/api/lotes/cartoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (loteCartaoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(loteCartaoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = loteCartaoPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarLotesCartoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarLotesCartoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LoteCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LoteCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LoteCartaoResponse)));
            
        }

        
        /// <summary>
        /// Cadastra um lote de cart\u00F5es Noname Este recurso permite cadastra um lote de cart\u00F5es Noname
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loteCartaoPersist">loteCartaoPersist</param>
        /// <returns>Task of LoteCartaoResponse</returns>
        public async System.Threading.Tasks.Task<LoteCartaoResponse> SalvarLotesCartoesAsync (LoteCartaoPersist loteCartaoPersist)
        {
             ApiResponse<LoteCartaoResponse> localVarResponse = await SalvarLotesCartoesAsyncWithHttpInfo(loteCartaoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastra um lote de cart\u00F5es Noname Este recurso permite cadastra um lote de cart\u00F5es Noname
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loteCartaoPersist">loteCartaoPersist</param>
        /// <returns>Task of ApiResponse (LoteCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LoteCartaoResponse>> SalvarLotesCartoesAsyncWithHttpInfo (LoteCartaoPersist loteCartaoPersist)
        {
            // verify the required parameter 'loteCartaoPersist' is set
            if (loteCartaoPersist == null) throw new ApiException(400, "Missing required parameter 'loteCartaoPersist' when calling SalvarLotesCartoes");
            
    
            var localVarPath = "/api/lotes/cartoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (loteCartaoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(loteCartaoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = loteCartaoPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarLotesCartoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarLotesCartoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LoteCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LoteCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LoteCartaoResponse)));
            
        }
        
    }
    
}
