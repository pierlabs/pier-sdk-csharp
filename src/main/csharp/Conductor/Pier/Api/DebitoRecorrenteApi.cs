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
    public interface IDebitoRecorrenteApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Lista os d\u00E9bitos recorrentes de uma Conta
        /// </summary>
        /// <remarks>
        /// A entidade D\u00E9bito Recorrente trata dos registros contratados por um determinado cliente (idConta) onde a cobran\u00E7a dele se d\u00E1 de forma cont\u00EDnua, consistindo em uma \u201Cassinatura\u201D ou pagamento de mensalidades. Isso significa que, enquanto o servi\u00E7o continuar a ser prestado, o cliente dever\u00E1 continuar realizando os pagamentos. A determina\u00E7\u00E3o de quanto tempo essa rela\u00E7\u00E3o ir\u00E1 durar \u00E9 feita em contrato. Na maioria das vezes, existe um per\u00EDodo m\u00EDnimo e, caso o servi\u00E7o seja cancelado ou o pagamento n\u00E3o seja realizado, o status do D\u00E9bito Recorrente ter\u00E1 a FlagAtivo com valor false. Assim, este m\u00E9todo lista todas as opera\u00E7\u00F5es de D\u00E9bitos Recorrentes que um determinado idConta j\u00E1 contratou, esteja ele ativo ou n\u00E3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta (id)</param>
        /// <param name="idTipoDebitoRecorrente">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id) (optional)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataHoraInicio">Data inicio do d\u00E9bito recorrente. (optional)</param>
        /// <param name="dataHoraFim">Data fim do d\u00E9bito recorrente. (optional)</param>
        /// <param name="ativo">Identifica se o d\u00E9bito recorrente est\u00E1 ativo. (optional)</param>
        /// <param name="dataHoraUltimoPagamento">Data do \u00FAltimo pagamento efetuado. (optional)</param>
        /// <returns>PageTipoDebitoRecorrenteResponse</returns>
        PageTipoDebitoRecorrenteResponse ListarUsingGET16 (long? idConta, long? idTipoDebitoRecorrente = null, List<string> sort = null, int? page = null, int? limit = null, string dataHoraInicio = null, string dataHoraFim = null, bool? ativo = null, string dataHoraUltimoPagamento = null);
  
        /// <summary>
        /// Lista os d\u00E9bitos recorrentes de uma Conta
        /// </summary>
        /// <remarks>
        /// A entidade D\u00E9bito Recorrente trata dos registros contratados por um determinado cliente (idConta) onde a cobran\u00E7a dele se d\u00E1 de forma cont\u00EDnua, consistindo em uma \u201Cassinatura\u201D ou pagamento de mensalidades. Isso significa que, enquanto o servi\u00E7o continuar a ser prestado, o cliente dever\u00E1 continuar realizando os pagamentos. A determina\u00E7\u00E3o de quanto tempo essa rela\u00E7\u00E3o ir\u00E1 durar \u00E9 feita em contrato. Na maioria das vezes, existe um per\u00EDodo m\u00EDnimo e, caso o servi\u00E7o seja cancelado ou o pagamento n\u00E3o seja realizado, o status do D\u00E9bito Recorrente ter\u00E1 a FlagAtivo com valor false. Assim, este m\u00E9todo lista todas as opera\u00E7\u00F5es de D\u00E9bitos Recorrentes que um determinado idConta j\u00E1 contratou, esteja ele ativo ou n\u00E3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta (id)</param>
        /// <param name="idTipoDebitoRecorrente">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id) (optional)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataHoraInicio">Data inicio do d\u00E9bito recorrente. (optional)</param>
        /// <param name="dataHoraFim">Data fim do d\u00E9bito recorrente. (optional)</param>
        /// <param name="ativo">Identifica se o d\u00E9bito recorrente est\u00E1 ativo. (optional)</param>
        /// <param name="dataHoraUltimoPagamento">Data do \u00FAltimo pagamento efetuado. (optional)</param>
        /// <returns>ApiResponse of PageTipoDebitoRecorrenteResponse</returns>
        ApiResponse<PageTipoDebitoRecorrenteResponse> ListarUsingGET16WithHttpInfo (long? idConta, long? idTipoDebitoRecorrente = null, List<string> sort = null, int? page = null, int? limit = null, string dataHoraInicio = null, string dataHoraFim = null, bool? ativo = null, string dataHoraUltimoPagamento = null);
        
        /// <summary>
        /// Listar Tipos Debitos Recorrentes
        /// </summary>
        /// <remarks>
        /// Para os emissores que utilizam a entidade Debitos Recorrentes precisam previamente solicitar a Conductor o cadastro de quais Tipos eles poder\u00E3o comercializar. Por isso, este recurso tem como objetivo apresentar todos os Tipos de D\u00E9bitos Recorrentes que est\u00E3o cadastrados para um determinado Emissor, independente do status dele.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id). (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de d\u00E9bito recorrente. (optional)</param>
        /// <param name="valor">Valor do tipo de d\u00E9bito recorrente. (optional)</param>
        /// <param name="flagAtivo">Flag que identifica se o tipo d\u00E9bito recorrente est\u00E1 ativo. (optional)</param>
        /// <returns>PageTipoDebitoRecorrenteResponse</returns>
        PageTipoDebitoRecorrenteResponse ListarUsingGET43 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, double? valor = null, bool? flagAtivo = null);
  
        /// <summary>
        /// Listar Tipos Debitos Recorrentes
        /// </summary>
        /// <remarks>
        /// Para os emissores que utilizam a entidade Debitos Recorrentes precisam previamente solicitar a Conductor o cadastro de quais Tipos eles poder\u00E3o comercializar. Por isso, este recurso tem como objetivo apresentar todos os Tipos de D\u00E9bitos Recorrentes que est\u00E3o cadastrados para um determinado Emissor, independente do status dele.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id). (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de d\u00E9bito recorrente. (optional)</param>
        /// <param name="valor">Valor do tipo de d\u00E9bito recorrente. (optional)</param>
        /// <param name="flagAtivo">Flag que identifica se o tipo d\u00E9bito recorrente est\u00E1 ativo. (optional)</param>
        /// <returns>ApiResponse of PageTipoDebitoRecorrenteResponse</returns>
        ApiResponse<PageTipoDebitoRecorrenteResponse> ListarUsingGET43WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, double? valor = null, bool? flagAtivo = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Lista os d\u00E9bitos recorrentes de uma Conta
        /// </summary>
        /// <remarks>
        /// A entidade D\u00E9bito Recorrente trata dos registros contratados por um determinado cliente (idConta) onde a cobran\u00E7a dele se d\u00E1 de forma cont\u00EDnua, consistindo em uma \u201Cassinatura\u201D ou pagamento de mensalidades. Isso significa que, enquanto o servi\u00E7o continuar a ser prestado, o cliente dever\u00E1 continuar realizando os pagamentos. A determina\u00E7\u00E3o de quanto tempo essa rela\u00E7\u00E3o ir\u00E1 durar \u00E9 feita em contrato. Na maioria das vezes, existe um per\u00EDodo m\u00EDnimo e, caso o servi\u00E7o seja cancelado ou o pagamento n\u00E3o seja realizado, o status do D\u00E9bito Recorrente ter\u00E1 a FlagAtivo com valor false. Assim, este m\u00E9todo lista todas as opera\u00E7\u00F5es de D\u00E9bitos Recorrentes que um determinado idConta j\u00E1 contratou, esteja ele ativo ou n\u00E3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta (id)</param>
        /// <param name="idTipoDebitoRecorrente">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id) (optional)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataHoraInicio">Data inicio do d\u00E9bito recorrente. (optional)</param>
        /// <param name="dataHoraFim">Data fim do d\u00E9bito recorrente. (optional)</param>
        /// <param name="ativo">Identifica se o d\u00E9bito recorrente est\u00E1 ativo. (optional)</param>
        /// <param name="dataHoraUltimoPagamento">Data do \u00FAltimo pagamento efetuado. (optional)</param>
        /// <returns>Task of PageTipoDebitoRecorrenteResponse</returns>
        System.Threading.Tasks.Task<PageTipoDebitoRecorrenteResponse> ListarUsingGET16Async (long? idConta, long? idTipoDebitoRecorrente = null, List<string> sort = null, int? page = null, int? limit = null, string dataHoraInicio = null, string dataHoraFim = null, bool? ativo = null, string dataHoraUltimoPagamento = null);

        /// <summary>
        /// Lista os d\u00E9bitos recorrentes de uma Conta
        /// </summary>
        /// <remarks>
        /// A entidade D\u00E9bito Recorrente trata dos registros contratados por um determinado cliente (idConta) onde a cobran\u00E7a dele se d\u00E1 de forma cont\u00EDnua, consistindo em uma \u201Cassinatura\u201D ou pagamento de mensalidades. Isso significa que, enquanto o servi\u00E7o continuar a ser prestado, o cliente dever\u00E1 continuar realizando os pagamentos. A determina\u00E7\u00E3o de quanto tempo essa rela\u00E7\u00E3o ir\u00E1 durar \u00E9 feita em contrato. Na maioria das vezes, existe um per\u00EDodo m\u00EDnimo e, caso o servi\u00E7o seja cancelado ou o pagamento n\u00E3o seja realizado, o status do D\u00E9bito Recorrente ter\u00E1 a FlagAtivo com valor false. Assim, este m\u00E9todo lista todas as opera\u00E7\u00F5es de D\u00E9bitos Recorrentes que um determinado idConta j\u00E1 contratou, esteja ele ativo ou n\u00E3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta (id)</param>
        /// <param name="idTipoDebitoRecorrente">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id) (optional)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataHoraInicio">Data inicio do d\u00E9bito recorrente. (optional)</param>
        /// <param name="dataHoraFim">Data fim do d\u00E9bito recorrente. (optional)</param>
        /// <param name="ativo">Identifica se o d\u00E9bito recorrente est\u00E1 ativo. (optional)</param>
        /// <param name="dataHoraUltimoPagamento">Data do \u00FAltimo pagamento efetuado. (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoDebitoRecorrenteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoDebitoRecorrenteResponse>> ListarUsingGET16AsyncWithHttpInfo (long? idConta, long? idTipoDebitoRecorrente = null, List<string> sort = null, int? page = null, int? limit = null, string dataHoraInicio = null, string dataHoraFim = null, bool? ativo = null, string dataHoraUltimoPagamento = null);
        
        /// <summary>
        /// Listar Tipos Debitos Recorrentes
        /// </summary>
        /// <remarks>
        /// Para os emissores que utilizam a entidade Debitos Recorrentes precisam previamente solicitar a Conductor o cadastro de quais Tipos eles poder\u00E3o comercializar. Por isso, este recurso tem como objetivo apresentar todos os Tipos de D\u00E9bitos Recorrentes que est\u00E3o cadastrados para um determinado Emissor, independente do status dele.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id). (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de d\u00E9bito recorrente. (optional)</param>
        /// <param name="valor">Valor do tipo de d\u00E9bito recorrente. (optional)</param>
        /// <param name="flagAtivo">Flag que identifica se o tipo d\u00E9bito recorrente est\u00E1 ativo. (optional)</param>
        /// <returns>Task of PageTipoDebitoRecorrenteResponse</returns>
        System.Threading.Tasks.Task<PageTipoDebitoRecorrenteResponse> ListarUsingGET43Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, double? valor = null, bool? flagAtivo = null);

        /// <summary>
        /// Listar Tipos Debitos Recorrentes
        /// </summary>
        /// <remarks>
        /// Para os emissores que utilizam a entidade Debitos Recorrentes precisam previamente solicitar a Conductor o cadastro de quais Tipos eles poder\u00E3o comercializar. Por isso, este recurso tem como objetivo apresentar todos os Tipos de D\u00E9bitos Recorrentes que est\u00E3o cadastrados para um determinado Emissor, independente do status dele.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id). (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de d\u00E9bito recorrente. (optional)</param>
        /// <param name="valor">Valor do tipo de d\u00E9bito recorrente. (optional)</param>
        /// <param name="flagAtivo">Flag que identifica se o tipo d\u00E9bito recorrente est\u00E1 ativo. (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoDebitoRecorrenteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoDebitoRecorrenteResponse>> ListarUsingGET43AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, double? valor = null, bool? flagAtivo = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DebitoRecorrenteApi : IDebitoRecorrenteApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DebitoRecorrenteApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DebitoRecorrenteApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DebitoRecorrenteApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DebitoRecorrenteApi(Configuration configuration = null)
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
        /// Lista os d\u00E9bitos recorrentes de uma Conta A entidade D\u00E9bito Recorrente trata dos registros contratados por um determinado cliente (idConta) onde a cobran\u00E7a dele se d\u00E1 de forma cont\u00EDnua, consistindo em uma \u201Cassinatura\u201D ou pagamento de mensalidades. Isso significa que, enquanto o servi\u00E7o continuar a ser prestado, o cliente dever\u00E1 continuar realizando os pagamentos. A determina\u00E7\u00E3o de quanto tempo essa rela\u00E7\u00E3o ir\u00E1 durar \u00E9 feita em contrato. Na maioria das vezes, existe um per\u00EDodo m\u00EDnimo e, caso o servi\u00E7o seja cancelado ou o pagamento n\u00E3o seja realizado, o status do D\u00E9bito Recorrente ter\u00E1 a FlagAtivo com valor false. Assim, este m\u00E9todo lista todas as opera\u00E7\u00F5es de D\u00E9bitos Recorrentes que um determinado idConta j\u00E1 contratou, esteja ele ativo ou n\u00E3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta (id)</param> 
        /// <param name="idTipoDebitoRecorrente">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id) (optional)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="dataHoraInicio">Data inicio do d\u00E9bito recorrente. (optional)</param> 
        /// <param name="dataHoraFim">Data fim do d\u00E9bito recorrente. (optional)</param> 
        /// <param name="ativo">Identifica se o d\u00E9bito recorrente est\u00E1 ativo. (optional)</param> 
        /// <param name="dataHoraUltimoPagamento">Data do \u00FAltimo pagamento efetuado. (optional)</param> 
        /// <returns>PageTipoDebitoRecorrenteResponse</returns>
        public PageTipoDebitoRecorrenteResponse ListarUsingGET16 (long? idConta, long? idTipoDebitoRecorrente = null, List<string> sort = null, int? page = null, int? limit = null, string dataHoraInicio = null, string dataHoraFim = null, bool? ativo = null, string dataHoraUltimoPagamento = null)
        {
             ApiResponse<PageTipoDebitoRecorrenteResponse> localVarResponse = ListarUsingGET16WithHttpInfo(idConta, idTipoDebitoRecorrente, sort, page, limit, dataHoraInicio, dataHoraFim, ativo, dataHoraUltimoPagamento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os d\u00E9bitos recorrentes de uma Conta A entidade D\u00E9bito Recorrente trata dos registros contratados por um determinado cliente (idConta) onde a cobran\u00E7a dele se d\u00E1 de forma cont\u00EDnua, consistindo em uma \u201Cassinatura\u201D ou pagamento de mensalidades. Isso significa que, enquanto o servi\u00E7o continuar a ser prestado, o cliente dever\u00E1 continuar realizando os pagamentos. A determina\u00E7\u00E3o de quanto tempo essa rela\u00E7\u00E3o ir\u00E1 durar \u00E9 feita em contrato. Na maioria das vezes, existe um per\u00EDodo m\u00EDnimo e, caso o servi\u00E7o seja cancelado ou o pagamento n\u00E3o seja realizado, o status do D\u00E9bito Recorrente ter\u00E1 a FlagAtivo com valor false. Assim, este m\u00E9todo lista todas as opera\u00E7\u00F5es de D\u00E9bitos Recorrentes que um determinado idConta j\u00E1 contratou, esteja ele ativo ou n\u00E3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta (id)</param> 
        /// <param name="idTipoDebitoRecorrente">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id) (optional)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="dataHoraInicio">Data inicio do d\u00E9bito recorrente. (optional)</param> 
        /// <param name="dataHoraFim">Data fim do d\u00E9bito recorrente. (optional)</param> 
        /// <param name="ativo">Identifica se o d\u00E9bito recorrente est\u00E1 ativo. (optional)</param> 
        /// <param name="dataHoraUltimoPagamento">Data do \u00FAltimo pagamento efetuado. (optional)</param> 
        /// <returns>ApiResponse of PageTipoDebitoRecorrenteResponse</returns>
        public ApiResponse< PageTipoDebitoRecorrenteResponse > ListarUsingGET16WithHttpInfo (long? idConta, long? idTipoDebitoRecorrente = null, List<string> sort = null, int? page = null, int? limit = null, string dataHoraInicio = null, string dataHoraFim = null, bool? ativo = null, string dataHoraUltimoPagamento = null)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling DebitoRecorrenteApi->ListarUsingGET16");
            
    
            var localVarPath = "/api/debitos-recorrentes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (idTipoDebitoRecorrente != null) localVarQueryParams.Add("idTipoDebitoRecorrente", Configuration.ApiClient.ParameterToString(idTipoDebitoRecorrente)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (dataHoraInicio != null) localVarQueryParams.Add("dataHoraInicio", Configuration.ApiClient.ParameterToString(dataHoraInicio)); // query parameter
            if (dataHoraFim != null) localVarQueryParams.Add("dataHoraFim", Configuration.ApiClient.ParameterToString(dataHoraFim)); // query parameter
            if (ativo != null) localVarQueryParams.Add("ativo", Configuration.ApiClient.ParameterToString(ativo)); // query parameter
            if (dataHoraUltimoPagamento != null) localVarQueryParams.Add("dataHoraUltimoPagamento", Configuration.ApiClient.ParameterToString(dataHoraUltimoPagamento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET16: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET16: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoDebitoRecorrenteResponse)));
            
        }

        
        /// <summary>
        /// Lista os d\u00E9bitos recorrentes de uma Conta A entidade D\u00E9bito Recorrente trata dos registros contratados por um determinado cliente (idConta) onde a cobran\u00E7a dele se d\u00E1 de forma cont\u00EDnua, consistindo em uma \u201Cassinatura\u201D ou pagamento de mensalidades. Isso significa que, enquanto o servi\u00E7o continuar a ser prestado, o cliente dever\u00E1 continuar realizando os pagamentos. A determina\u00E7\u00E3o de quanto tempo essa rela\u00E7\u00E3o ir\u00E1 durar \u00E9 feita em contrato. Na maioria das vezes, existe um per\u00EDodo m\u00EDnimo e, caso o servi\u00E7o seja cancelado ou o pagamento n\u00E3o seja realizado, o status do D\u00E9bito Recorrente ter\u00E1 a FlagAtivo com valor false. Assim, este m\u00E9todo lista todas as opera\u00E7\u00F5es de D\u00E9bitos Recorrentes que um determinado idConta j\u00E1 contratou, esteja ele ativo ou n\u00E3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta (id)</param>
        /// <param name="idTipoDebitoRecorrente">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id) (optional)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataHoraInicio">Data inicio do d\u00E9bito recorrente. (optional)</param>
        /// <param name="dataHoraFim">Data fim do d\u00E9bito recorrente. (optional)</param>
        /// <param name="ativo">Identifica se o d\u00E9bito recorrente est\u00E1 ativo. (optional)</param>
        /// <param name="dataHoraUltimoPagamento">Data do \u00FAltimo pagamento efetuado. (optional)</param>
        /// <returns>Task of PageTipoDebitoRecorrenteResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoDebitoRecorrenteResponse> ListarUsingGET16Async (long? idConta, long? idTipoDebitoRecorrente = null, List<string> sort = null, int? page = null, int? limit = null, string dataHoraInicio = null, string dataHoraFim = null, bool? ativo = null, string dataHoraUltimoPagamento = null)
        {
             ApiResponse<PageTipoDebitoRecorrenteResponse> localVarResponse = await ListarUsingGET16AsyncWithHttpInfo(idConta, idTipoDebitoRecorrente, sort, page, limit, dataHoraInicio, dataHoraFim, ativo, dataHoraUltimoPagamento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os d\u00E9bitos recorrentes de uma Conta A entidade D\u00E9bito Recorrente trata dos registros contratados por um determinado cliente (idConta) onde a cobran\u00E7a dele se d\u00E1 de forma cont\u00EDnua, consistindo em uma \u201Cassinatura\u201D ou pagamento de mensalidades. Isso significa que, enquanto o servi\u00E7o continuar a ser prestado, o cliente dever\u00E1 continuar realizando os pagamentos. A determina\u00E7\u00E3o de quanto tempo essa rela\u00E7\u00E3o ir\u00E1 durar \u00E9 feita em contrato. Na maioria das vezes, existe um per\u00EDodo m\u00EDnimo e, caso o servi\u00E7o seja cancelado ou o pagamento n\u00E3o seja realizado, o status do D\u00E9bito Recorrente ter\u00E1 a FlagAtivo com valor false. Assim, este m\u00E9todo lista todas as opera\u00E7\u00F5es de D\u00E9bitos Recorrentes que um determinado idConta j\u00E1 contratou, esteja ele ativo ou n\u00E3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta (id)</param>
        /// <param name="idTipoDebitoRecorrente">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id) (optional)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataHoraInicio">Data inicio do d\u00E9bito recorrente. (optional)</param>
        /// <param name="dataHoraFim">Data fim do d\u00E9bito recorrente. (optional)</param>
        /// <param name="ativo">Identifica se o d\u00E9bito recorrente est\u00E1 ativo. (optional)</param>
        /// <param name="dataHoraUltimoPagamento">Data do \u00FAltimo pagamento efetuado. (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoDebitoRecorrenteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoDebitoRecorrenteResponse>> ListarUsingGET16AsyncWithHttpInfo (long? idConta, long? idTipoDebitoRecorrente = null, List<string> sort = null, int? page = null, int? limit = null, string dataHoraInicio = null, string dataHoraFim = null, bool? ativo = null, string dataHoraUltimoPagamento = null)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ListarUsingGET16");
            
    
            var localVarPath = "/api/debitos-recorrentes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (idTipoDebitoRecorrente != null) localVarQueryParams.Add("idTipoDebitoRecorrente", Configuration.ApiClient.ParameterToString(idTipoDebitoRecorrente)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (dataHoraInicio != null) localVarQueryParams.Add("dataHoraInicio", Configuration.ApiClient.ParameterToString(dataHoraInicio)); // query parameter
            if (dataHoraFim != null) localVarQueryParams.Add("dataHoraFim", Configuration.ApiClient.ParameterToString(dataHoraFim)); // query parameter
            if (ativo != null) localVarQueryParams.Add("ativo", Configuration.ApiClient.ParameterToString(ativo)); // query parameter
            if (dataHoraUltimoPagamento != null) localVarQueryParams.Add("dataHoraUltimoPagamento", Configuration.ApiClient.ParameterToString(dataHoraUltimoPagamento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET16: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET16: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoDebitoRecorrenteResponse)));
            
        }
        
        /// <summary>
        /// Listar Tipos Debitos Recorrentes Para os emissores que utilizam a entidade Debitos Recorrentes precisam previamente solicitar a Conductor o cadastro de quais Tipos eles poder\u00E3o comercializar. Por isso, este recurso tem como objetivo apresentar todos os Tipos de D\u00E9bitos Recorrentes que est\u00E3o cadastrados para um determinado Emissor, independente do status dele.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id). (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de d\u00E9bito recorrente. (optional)</param> 
        /// <param name="valor">Valor do tipo de d\u00E9bito recorrente. (optional)</param> 
        /// <param name="flagAtivo">Flag que identifica se o tipo d\u00E9bito recorrente est\u00E1 ativo. (optional)</param> 
        /// <returns>PageTipoDebitoRecorrenteResponse</returns>
        public PageTipoDebitoRecorrenteResponse ListarUsingGET43 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, double? valor = null, bool? flagAtivo = null)
        {
             ApiResponse<PageTipoDebitoRecorrenteResponse> localVarResponse = ListarUsingGET43WithHttpInfo(sort, page, limit, id, descricao, valor, flagAtivo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar Tipos Debitos Recorrentes Para os emissores que utilizam a entidade Debitos Recorrentes precisam previamente solicitar a Conductor o cadastro de quais Tipos eles poder\u00E3o comercializar. Por isso, este recurso tem como objetivo apresentar todos os Tipos de D\u00E9bitos Recorrentes que est\u00E3o cadastrados para um determinado Emissor, independente do status dele.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id). (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de d\u00E9bito recorrente. (optional)</param> 
        /// <param name="valor">Valor do tipo de d\u00E9bito recorrente. (optional)</param> 
        /// <param name="flagAtivo">Flag que identifica se o tipo d\u00E9bito recorrente est\u00E1 ativo. (optional)</param> 
        /// <returns>ApiResponse of PageTipoDebitoRecorrenteResponse</returns>
        public ApiResponse< PageTipoDebitoRecorrenteResponse > ListarUsingGET43WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, double? valor = null, bool? flagAtivo = null)
        {
            
    
            var localVarPath = "/api/tipos-debitos-recorrentes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (valor != null) localVarQueryParams.Add("valor", Configuration.ApiClient.ParameterToString(valor)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET43: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET43: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoDebitoRecorrenteResponse)));
            
        }

        
        /// <summary>
        /// Listar Tipos Debitos Recorrentes Para os emissores que utilizam a entidade Debitos Recorrentes precisam previamente solicitar a Conductor o cadastro de quais Tipos eles poder\u00E3o comercializar. Por isso, este recurso tem como objetivo apresentar todos os Tipos de D\u00E9bitos Recorrentes que est\u00E3o cadastrados para um determinado Emissor, independente do status dele.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id). (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de d\u00E9bito recorrente. (optional)</param>
        /// <param name="valor">Valor do tipo de d\u00E9bito recorrente. (optional)</param>
        /// <param name="flagAtivo">Flag que identifica se o tipo d\u00E9bito recorrente est\u00E1 ativo. (optional)</param>
        /// <returns>Task of PageTipoDebitoRecorrenteResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoDebitoRecorrenteResponse> ListarUsingGET43Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, double? valor = null, bool? flagAtivo = null)
        {
             ApiResponse<PageTipoDebitoRecorrenteResponse> localVarResponse = await ListarUsingGET43AsyncWithHttpInfo(sort, page, limit, id, descricao, valor, flagAtivo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar Tipos Debitos Recorrentes Para os emissores que utilizam a entidade Debitos Recorrentes precisam previamente solicitar a Conductor o cadastro de quais Tipos eles poder\u00E3o comercializar. Por isso, este recurso tem como objetivo apresentar todos os Tipos de D\u00E9bitos Recorrentes que est\u00E3o cadastrados para um determinado Emissor, independente do status dele.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id). (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de d\u00E9bito recorrente. (optional)</param>
        /// <param name="valor">Valor do tipo de d\u00E9bito recorrente. (optional)</param>
        /// <param name="flagAtivo">Flag que identifica se o tipo d\u00E9bito recorrente est\u00E1 ativo. (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoDebitoRecorrenteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoDebitoRecorrenteResponse>> ListarUsingGET43AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, double? valor = null, bool? flagAtivo = null)
        {
            
    
            var localVarPath = "/api/tipos-debitos-recorrentes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (valor != null) localVarQueryParams.Add("valor", Configuration.ApiClient.ParameterToString(valor)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET43: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET43: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoDebitoRecorrenteResponse)));
            
        }
        
    }
    
}
