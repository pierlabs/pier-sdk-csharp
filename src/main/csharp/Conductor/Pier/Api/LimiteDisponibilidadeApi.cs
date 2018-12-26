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
    public interface ILimiteDisponibilidadeApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o dos limites da conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite realizar a altera\u00E7\u00E3o dos Limites de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta</param>
        /// <param name="limiteGlobal">Apresenta o valor do limite de cr\u00E9dito que o portador do cart\u00E3o possui (optional)</param>
        /// <param name="limiteCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para uso exclusivo em Compras Nacionais (optional)</param>
        /// <param name="limiteParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para realizar transa\u00E7\u00F5es de compras parceladas (optional)</param>
        /// <param name="limiteParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que portador pode acumular a partir da soma das parcelas das compras que forem realizadas nesta modalidade (optional)</param>
        /// <param name="limiteSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Nacional (optional)</param>
        /// <param name="limiteSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Nacional dentro de cada ciclo de faturamento (optional)</param>
        /// <param name="limiteConsignado">Quando utilizado pelo emissor, este campo apresenta o valor da margem de cr\u00E9dito que ele poder\u00E1 utilizar para ser cobrado de forma consignada (desconto em folha) em seu sal\u00E1rio/vencimentos (optional)</param>
        /// <param name="limiteInternacionalCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para uso exclusivo em Compras Internacionais (optional)</param>
        /// <param name="limiteInternacionalParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para realizar transa\u00E7\u00F5es Internacionais de Compras Parceladas (optional)</param>
        /// <param name="limiteInternacionalParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que portador pode acumular a partir da soma das parcelas das compras internacionais que forem realizadas nesta modalidade (optional)</param>
        /// <param name="limiteInternacionalSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Internacional (optional)</param>
        /// <param name="limiteInternacionalSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Internacional dentro de cada ciclo de faturamento (optional)</param>
        /// <param name="limiteMaximo">Valor m\u00E1ximo do limite de cr\u00E9dito para realizar transa\u00E7\u00F5es (optional)</param>
        /// <returns>LimiteDisponibilidadeResponse</returns>
        LimiteDisponibilidadeResponse Alterar (long? idConta, double? limiteGlobal = null, double? limiteCompra = null, double? limiteParcelado = null, double? limiteParcelas = null, double? limiteSaqueGlobal = null, double? limiteSaquePeriodo = null, double? limiteConsignado = null, double? limiteInternacionalCompra = null, double? limiteInternacionalParcelado = null, double? limiteInternacionalParcelas = null, double? limiteInternacionalSaqueGlobal = null, double? limiteInternacionalSaquePeriodo = null, double? limiteMaximo = null);
  
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o dos limites da conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite realizar a altera\u00E7\u00E3o dos Limites de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta</param>
        /// <param name="limiteGlobal">Apresenta o valor do limite de cr\u00E9dito que o portador do cart\u00E3o possui (optional)</param>
        /// <param name="limiteCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para uso exclusivo em Compras Nacionais (optional)</param>
        /// <param name="limiteParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para realizar transa\u00E7\u00F5es de compras parceladas (optional)</param>
        /// <param name="limiteParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que portador pode acumular a partir da soma das parcelas das compras que forem realizadas nesta modalidade (optional)</param>
        /// <param name="limiteSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Nacional (optional)</param>
        /// <param name="limiteSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Nacional dentro de cada ciclo de faturamento (optional)</param>
        /// <param name="limiteConsignado">Quando utilizado pelo emissor, este campo apresenta o valor da margem de cr\u00E9dito que ele poder\u00E1 utilizar para ser cobrado de forma consignada (desconto em folha) em seu sal\u00E1rio/vencimentos (optional)</param>
        /// <param name="limiteInternacionalCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para uso exclusivo em Compras Internacionais (optional)</param>
        /// <param name="limiteInternacionalParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para realizar transa\u00E7\u00F5es Internacionais de Compras Parceladas (optional)</param>
        /// <param name="limiteInternacionalParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que portador pode acumular a partir da soma das parcelas das compras internacionais que forem realizadas nesta modalidade (optional)</param>
        /// <param name="limiteInternacionalSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Internacional (optional)</param>
        /// <param name="limiteInternacionalSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Internacional dentro de cada ciclo de faturamento (optional)</param>
        /// <param name="limiteMaximo">Valor m\u00E1ximo do limite de cr\u00E9dito para realizar transa\u00E7\u00F5es (optional)</param>
        /// <returns>ApiResponse of LimiteDisponibilidadeResponse</returns>
        ApiResponse<LimiteDisponibilidadeResponse> AlterarWithHttpInfo (long? idConta, double? limiteGlobal = null, double? limiteCompra = null, double? limiteParcelado = null, double? limiteParcelas = null, double? limiteSaqueGlobal = null, double? limiteSaquePeriodo = null, double? limiteConsignado = null, double? limiteInternacionalCompra = null, double? limiteInternacionalParcelado = null, double? limiteInternacionalParcelas = null, double? limiteInternacionalSaqueGlobal = null, double? limiteInternacionalSaquePeriodo = null, double? limiteMaximo = null);
        
        /// <summary>
        /// Apresenta os limites da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os Limites configurados para uma determinada Conta, a partir do c\u00F3digo de identifica\u00E7\u00E3o da conta (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Id Conta</param>
        /// <returns>LimiteDisponibilidadeResponse</returns>
        LimiteDisponibilidadeResponse Consultar (long? idConta);
  
        /// <summary>
        /// Apresenta os limites da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os Limites configurados para uma determinada Conta, a partir do c\u00F3digo de identifica\u00E7\u00E3o da conta (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Id Conta</param>
        /// <returns>ApiResponse of LimiteDisponibilidadeResponse</returns>
        ApiResponse<LimiteDisponibilidadeResponse> ConsultarWithHttpInfo (long? idConta);
        
        /// <summary>
        /// Sensibilizar uma quantidade de cr\u00E9dito de global de uma conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite sensibilizar, para mais ou para menos, a quantidade de cr\u00E9dito global de uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sensibilizarSaldoGlobal">sensibilizarSaldoGlobal</param>
        /// <returns>LimiteDisponibilidadeResponse</returns>
        LimiteDisponibilidadeResponse SensibilizarSaldoDisponivelGlobal (long? id, SensibilizarSaldoGlobalUpdate sensibilizarSaldoGlobal);
  
        /// <summary>
        /// Sensibilizar uma quantidade de cr\u00E9dito de global de uma conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite sensibilizar, para mais ou para menos, a quantidade de cr\u00E9dito global de uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sensibilizarSaldoGlobal">sensibilizarSaldoGlobal</param>
        /// <returns>ApiResponse of LimiteDisponibilidadeResponse</returns>
        ApiResponse<LimiteDisponibilidadeResponse> SensibilizarSaldoDisponivelGlobalWithHttpInfo (long? id, SensibilizarSaldoGlobalUpdate sensibilizarSaldoGlobal);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o dos limites da conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite realizar a altera\u00E7\u00E3o dos Limites de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta</param>
        /// <param name="limiteGlobal">Apresenta o valor do limite de cr\u00E9dito que o portador do cart\u00E3o possui (optional)</param>
        /// <param name="limiteCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para uso exclusivo em Compras Nacionais (optional)</param>
        /// <param name="limiteParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para realizar transa\u00E7\u00F5es de compras parceladas (optional)</param>
        /// <param name="limiteParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que portador pode acumular a partir da soma das parcelas das compras que forem realizadas nesta modalidade (optional)</param>
        /// <param name="limiteSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Nacional (optional)</param>
        /// <param name="limiteSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Nacional dentro de cada ciclo de faturamento (optional)</param>
        /// <param name="limiteConsignado">Quando utilizado pelo emissor, este campo apresenta o valor da margem de cr\u00E9dito que ele poder\u00E1 utilizar para ser cobrado de forma consignada (desconto em folha) em seu sal\u00E1rio/vencimentos (optional)</param>
        /// <param name="limiteInternacionalCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para uso exclusivo em Compras Internacionais (optional)</param>
        /// <param name="limiteInternacionalParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para realizar transa\u00E7\u00F5es Internacionais de Compras Parceladas (optional)</param>
        /// <param name="limiteInternacionalParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que portador pode acumular a partir da soma das parcelas das compras internacionais que forem realizadas nesta modalidade (optional)</param>
        /// <param name="limiteInternacionalSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Internacional (optional)</param>
        /// <param name="limiteInternacionalSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Internacional dentro de cada ciclo de faturamento (optional)</param>
        /// <param name="limiteMaximo">Valor m\u00E1ximo do limite de cr\u00E9dito para realizar transa\u00E7\u00F5es (optional)</param>
        /// <returns>Task of LimiteDisponibilidadeResponse</returns>
        System.Threading.Tasks.Task<LimiteDisponibilidadeResponse> AlterarAsync (long? idConta, double? limiteGlobal = null, double? limiteCompra = null, double? limiteParcelado = null, double? limiteParcelas = null, double? limiteSaqueGlobal = null, double? limiteSaquePeriodo = null, double? limiteConsignado = null, double? limiteInternacionalCompra = null, double? limiteInternacionalParcelado = null, double? limiteInternacionalParcelas = null, double? limiteInternacionalSaqueGlobal = null, double? limiteInternacionalSaquePeriodo = null, double? limiteMaximo = null);

        /// <summary>
        /// Realiza a altera\u00E7\u00E3o dos limites da conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite realizar a altera\u00E7\u00E3o dos Limites de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta</param>
        /// <param name="limiteGlobal">Apresenta o valor do limite de cr\u00E9dito que o portador do cart\u00E3o possui (optional)</param>
        /// <param name="limiteCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para uso exclusivo em Compras Nacionais (optional)</param>
        /// <param name="limiteParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para realizar transa\u00E7\u00F5es de compras parceladas (optional)</param>
        /// <param name="limiteParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que portador pode acumular a partir da soma das parcelas das compras que forem realizadas nesta modalidade (optional)</param>
        /// <param name="limiteSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Nacional (optional)</param>
        /// <param name="limiteSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Nacional dentro de cada ciclo de faturamento (optional)</param>
        /// <param name="limiteConsignado">Quando utilizado pelo emissor, este campo apresenta o valor da margem de cr\u00E9dito que ele poder\u00E1 utilizar para ser cobrado de forma consignada (desconto em folha) em seu sal\u00E1rio/vencimentos (optional)</param>
        /// <param name="limiteInternacionalCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para uso exclusivo em Compras Internacionais (optional)</param>
        /// <param name="limiteInternacionalParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para realizar transa\u00E7\u00F5es Internacionais de Compras Parceladas (optional)</param>
        /// <param name="limiteInternacionalParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que portador pode acumular a partir da soma das parcelas das compras internacionais que forem realizadas nesta modalidade (optional)</param>
        /// <param name="limiteInternacionalSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Internacional (optional)</param>
        /// <param name="limiteInternacionalSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Internacional dentro de cada ciclo de faturamento (optional)</param>
        /// <param name="limiteMaximo">Valor m\u00E1ximo do limite de cr\u00E9dito para realizar transa\u00E7\u00F5es (optional)</param>
        /// <returns>Task of ApiResponse (LimiteDisponibilidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LimiteDisponibilidadeResponse>> AlterarAsyncWithHttpInfo (long? idConta, double? limiteGlobal = null, double? limiteCompra = null, double? limiteParcelado = null, double? limiteParcelas = null, double? limiteSaqueGlobal = null, double? limiteSaquePeriodo = null, double? limiteConsignado = null, double? limiteInternacionalCompra = null, double? limiteInternacionalParcelado = null, double? limiteInternacionalParcelas = null, double? limiteInternacionalSaqueGlobal = null, double? limiteInternacionalSaquePeriodo = null, double? limiteMaximo = null);
        
        /// <summary>
        /// Apresenta os limites da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os Limites configurados para uma determinada Conta, a partir do c\u00F3digo de identifica\u00E7\u00E3o da conta (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Id Conta</param>
        /// <returns>Task of LimiteDisponibilidadeResponse</returns>
        System.Threading.Tasks.Task<LimiteDisponibilidadeResponse> ConsultarAsync (long? idConta);

        /// <summary>
        /// Apresenta os limites da conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os Limites configurados para uma determinada Conta, a partir do c\u00F3digo de identifica\u00E7\u00E3o da conta (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Id Conta</param>
        /// <returns>Task of ApiResponse (LimiteDisponibilidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LimiteDisponibilidadeResponse>> ConsultarAsyncWithHttpInfo (long? idConta);
        
        /// <summary>
        /// Sensibilizar uma quantidade de cr\u00E9dito de global de uma conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite sensibilizar, para mais ou para menos, a quantidade de cr\u00E9dito global de uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sensibilizarSaldoGlobal">sensibilizarSaldoGlobal</param>
        /// <returns>Task of LimiteDisponibilidadeResponse</returns>
        System.Threading.Tasks.Task<LimiteDisponibilidadeResponse> SensibilizarSaldoDisponivelGlobalAsync (long? id, SensibilizarSaldoGlobalUpdate sensibilizarSaldoGlobal);

        /// <summary>
        /// Sensibilizar uma quantidade de cr\u00E9dito de global de uma conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite sensibilizar, para mais ou para menos, a quantidade de cr\u00E9dito global de uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sensibilizarSaldoGlobal">sensibilizarSaldoGlobal</param>
        /// <returns>Task of ApiResponse (LimiteDisponibilidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LimiteDisponibilidadeResponse>> SensibilizarSaldoDisponivelGlobalAsyncWithHttpInfo (long? id, SensibilizarSaldoGlobalUpdate sensibilizarSaldoGlobal);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LimiteDisponibilidadeApi : ILimiteDisponibilidadeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LimiteDisponibilidadeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LimiteDisponibilidadeApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LimiteDisponibilidadeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LimiteDisponibilidadeApi(Configuration configuration = null)
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
        /// Realiza a altera\u00E7\u00E3o dos limites da conta Esse recurso permite realizar a altera\u00E7\u00E3o dos Limites de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta</param> 
        /// <param name="limiteGlobal">Apresenta o valor do limite de cr\u00E9dito que o portador do cart\u00E3o possui (optional)</param> 
        /// <param name="limiteCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para uso exclusivo em Compras Nacionais (optional)</param> 
        /// <param name="limiteParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para realizar transa\u00E7\u00F5es de compras parceladas (optional)</param> 
        /// <param name="limiteParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que portador pode acumular a partir da soma das parcelas das compras que forem realizadas nesta modalidade (optional)</param> 
        /// <param name="limiteSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Nacional (optional)</param> 
        /// <param name="limiteSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Nacional dentro de cada ciclo de faturamento (optional)</param> 
        /// <param name="limiteConsignado">Quando utilizado pelo emissor, este campo apresenta o valor da margem de cr\u00E9dito que ele poder\u00E1 utilizar para ser cobrado de forma consignada (desconto em folha) em seu sal\u00E1rio/vencimentos (optional)</param> 
        /// <param name="limiteInternacionalCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para uso exclusivo em Compras Internacionais (optional)</param> 
        /// <param name="limiteInternacionalParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para realizar transa\u00E7\u00F5es Internacionais de Compras Parceladas (optional)</param> 
        /// <param name="limiteInternacionalParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que portador pode acumular a partir da soma das parcelas das compras internacionais que forem realizadas nesta modalidade (optional)</param> 
        /// <param name="limiteInternacionalSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Internacional (optional)</param> 
        /// <param name="limiteInternacionalSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Internacional dentro de cada ciclo de faturamento (optional)</param> 
        /// <param name="limiteMaximo">Valor m\u00E1ximo do limite de cr\u00E9dito para realizar transa\u00E7\u00F5es (optional)</param> 
        /// <returns>LimiteDisponibilidadeResponse</returns>
        public LimiteDisponibilidadeResponse Alterar (long? idConta, double? limiteGlobal = null, double? limiteCompra = null, double? limiteParcelado = null, double? limiteParcelas = null, double? limiteSaqueGlobal = null, double? limiteSaquePeriodo = null, double? limiteConsignado = null, double? limiteInternacionalCompra = null, double? limiteInternacionalParcelado = null, double? limiteInternacionalParcelas = null, double? limiteInternacionalSaqueGlobal = null, double? limiteInternacionalSaquePeriodo = null, double? limiteMaximo = null)
        {
             ApiResponse<LimiteDisponibilidadeResponse> localVarResponse = AlterarWithHttpInfo(idConta, limiteGlobal, limiteCompra, limiteParcelado, limiteParcelas, limiteSaqueGlobal, limiteSaquePeriodo, limiteConsignado, limiteInternacionalCompra, limiteInternacionalParcelado, limiteInternacionalParcelas, limiteInternacionalSaqueGlobal, limiteInternacionalSaquePeriodo, limiteMaximo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a altera\u00E7\u00E3o dos limites da conta Esse recurso permite realizar a altera\u00E7\u00E3o dos Limites de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta</param> 
        /// <param name="limiteGlobal">Apresenta o valor do limite de cr\u00E9dito que o portador do cart\u00E3o possui (optional)</param> 
        /// <param name="limiteCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para uso exclusivo em Compras Nacionais (optional)</param> 
        /// <param name="limiteParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para realizar transa\u00E7\u00F5es de compras parceladas (optional)</param> 
        /// <param name="limiteParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que portador pode acumular a partir da soma das parcelas das compras que forem realizadas nesta modalidade (optional)</param> 
        /// <param name="limiteSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Nacional (optional)</param> 
        /// <param name="limiteSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Nacional dentro de cada ciclo de faturamento (optional)</param> 
        /// <param name="limiteConsignado">Quando utilizado pelo emissor, este campo apresenta o valor da margem de cr\u00E9dito que ele poder\u00E1 utilizar para ser cobrado de forma consignada (desconto em folha) em seu sal\u00E1rio/vencimentos (optional)</param> 
        /// <param name="limiteInternacionalCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para uso exclusivo em Compras Internacionais (optional)</param> 
        /// <param name="limiteInternacionalParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para realizar transa\u00E7\u00F5es Internacionais de Compras Parceladas (optional)</param> 
        /// <param name="limiteInternacionalParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que portador pode acumular a partir da soma das parcelas das compras internacionais que forem realizadas nesta modalidade (optional)</param> 
        /// <param name="limiteInternacionalSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Internacional (optional)</param> 
        /// <param name="limiteInternacionalSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Internacional dentro de cada ciclo de faturamento (optional)</param> 
        /// <param name="limiteMaximo">Valor m\u00E1ximo do limite de cr\u00E9dito para realizar transa\u00E7\u00F5es (optional)</param> 
        /// <returns>ApiResponse of LimiteDisponibilidadeResponse</returns>
        public ApiResponse< LimiteDisponibilidadeResponse > AlterarWithHttpInfo (long? idConta, double? limiteGlobal = null, double? limiteCompra = null, double? limiteParcelado = null, double? limiteParcelas = null, double? limiteSaqueGlobal = null, double? limiteSaquePeriodo = null, double? limiteConsignado = null, double? limiteInternacionalCompra = null, double? limiteInternacionalParcelado = null, double? limiteInternacionalParcelas = null, double? limiteInternacionalSaqueGlobal = null, double? limiteInternacionalSaquePeriodo = null, double? limiteMaximo = null)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling LimiteDisponibilidadeApi->Alterar");
            
    
            var localVarPath = "/api/limites-disponibilidades";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (limiteGlobal != null) localVarQueryParams.Add("limiteGlobal", Configuration.ApiClient.ParameterToString(limiteGlobal)); // query parameter
            if (limiteCompra != null) localVarQueryParams.Add("limiteCompra", Configuration.ApiClient.ParameterToString(limiteCompra)); // query parameter
            if (limiteParcelado != null) localVarQueryParams.Add("limiteParcelado", Configuration.ApiClient.ParameterToString(limiteParcelado)); // query parameter
            if (limiteParcelas != null) localVarQueryParams.Add("limiteParcelas", Configuration.ApiClient.ParameterToString(limiteParcelas)); // query parameter
            if (limiteSaqueGlobal != null) localVarQueryParams.Add("limiteSaqueGlobal", Configuration.ApiClient.ParameterToString(limiteSaqueGlobal)); // query parameter
            if (limiteSaquePeriodo != null) localVarQueryParams.Add("limiteSaquePeriodo", Configuration.ApiClient.ParameterToString(limiteSaquePeriodo)); // query parameter
            if (limiteConsignado != null) localVarQueryParams.Add("limiteConsignado", Configuration.ApiClient.ParameterToString(limiteConsignado)); // query parameter
            if (limiteInternacionalCompra != null) localVarQueryParams.Add("limiteInternacionalCompra", Configuration.ApiClient.ParameterToString(limiteInternacionalCompra)); // query parameter
            if (limiteInternacionalParcelado != null) localVarQueryParams.Add("limiteInternacionalParcelado", Configuration.ApiClient.ParameterToString(limiteInternacionalParcelado)); // query parameter
            if (limiteInternacionalParcelas != null) localVarQueryParams.Add("limiteInternacionalParcelas", Configuration.ApiClient.ParameterToString(limiteInternacionalParcelas)); // query parameter
            if (limiteInternacionalSaqueGlobal != null) localVarQueryParams.Add("limiteInternacionalSaqueGlobal", Configuration.ApiClient.ParameterToString(limiteInternacionalSaqueGlobal)); // query parameter
            if (limiteInternacionalSaquePeriodo != null) localVarQueryParams.Add("limiteInternacionalSaquePeriodo", Configuration.ApiClient.ParameterToString(limiteInternacionalSaquePeriodo)); // query parameter
            if (limiteMaximo != null) localVarQueryParams.Add("limiteMaximo", Configuration.ApiClient.ParameterToString(limiteMaximo)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LimiteDisponibilidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LimiteDisponibilidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimiteDisponibilidadeResponse)));
            
        }

        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o dos limites da conta Esse recurso permite realizar a altera\u00E7\u00E3o dos Limites de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta</param>
        /// <param name="limiteGlobal">Apresenta o valor do limite de cr\u00E9dito que o portador do cart\u00E3o possui (optional)</param>
        /// <param name="limiteCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para uso exclusivo em Compras Nacionais (optional)</param>
        /// <param name="limiteParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para realizar transa\u00E7\u00F5es de compras parceladas (optional)</param>
        /// <param name="limiteParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que portador pode acumular a partir da soma das parcelas das compras que forem realizadas nesta modalidade (optional)</param>
        /// <param name="limiteSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Nacional (optional)</param>
        /// <param name="limiteSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Nacional dentro de cada ciclo de faturamento (optional)</param>
        /// <param name="limiteConsignado">Quando utilizado pelo emissor, este campo apresenta o valor da margem de cr\u00E9dito que ele poder\u00E1 utilizar para ser cobrado de forma consignada (desconto em folha) em seu sal\u00E1rio/vencimentos (optional)</param>
        /// <param name="limiteInternacionalCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para uso exclusivo em Compras Internacionais (optional)</param>
        /// <param name="limiteInternacionalParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para realizar transa\u00E7\u00F5es Internacionais de Compras Parceladas (optional)</param>
        /// <param name="limiteInternacionalParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que portador pode acumular a partir da soma das parcelas das compras internacionais que forem realizadas nesta modalidade (optional)</param>
        /// <param name="limiteInternacionalSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Internacional (optional)</param>
        /// <param name="limiteInternacionalSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Internacional dentro de cada ciclo de faturamento (optional)</param>
        /// <param name="limiteMaximo">Valor m\u00E1ximo do limite de cr\u00E9dito para realizar transa\u00E7\u00F5es (optional)</param>
        /// <returns>Task of LimiteDisponibilidadeResponse</returns>
        public async System.Threading.Tasks.Task<LimiteDisponibilidadeResponse> AlterarAsync (long? idConta, double? limiteGlobal = null, double? limiteCompra = null, double? limiteParcelado = null, double? limiteParcelas = null, double? limiteSaqueGlobal = null, double? limiteSaquePeriodo = null, double? limiteConsignado = null, double? limiteInternacionalCompra = null, double? limiteInternacionalParcelado = null, double? limiteInternacionalParcelas = null, double? limiteInternacionalSaqueGlobal = null, double? limiteInternacionalSaquePeriodo = null, double? limiteMaximo = null)
        {
             ApiResponse<LimiteDisponibilidadeResponse> localVarResponse = await AlterarAsyncWithHttpInfo(idConta, limiteGlobal, limiteCompra, limiteParcelado, limiteParcelas, limiteSaqueGlobal, limiteSaquePeriodo, limiteConsignado, limiteInternacionalCompra, limiteInternacionalParcelado, limiteInternacionalParcelas, limiteInternacionalSaqueGlobal, limiteInternacionalSaquePeriodo, limiteMaximo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a altera\u00E7\u00E3o dos limites da conta Esse recurso permite realizar a altera\u00E7\u00E3o dos Limites de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta</param>
        /// <param name="limiteGlobal">Apresenta o valor do limite de cr\u00E9dito que o portador do cart\u00E3o possui (optional)</param>
        /// <param name="limiteCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para uso exclusivo em Compras Nacionais (optional)</param>
        /// <param name="limiteParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para realizar transa\u00E7\u00F5es de compras parceladas (optional)</param>
        /// <param name="limiteParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que portador pode acumular a partir da soma das parcelas das compras que forem realizadas nesta modalidade (optional)</param>
        /// <param name="limiteSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Nacional (optional)</param>
        /// <param name="limiteSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Nacional dentro de cada ciclo de faturamento (optional)</param>
        /// <param name="limiteConsignado">Quando utilizado pelo emissor, este campo apresenta o valor da margem de cr\u00E9dito que ele poder\u00E1 utilizar para ser cobrado de forma consignada (desconto em folha) em seu sal\u00E1rio/vencimentos (optional)</param>
        /// <param name="limiteInternacionalCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para uso exclusivo em Compras Internacionais (optional)</param>
        /// <param name="limiteInternacionalParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para realizar transa\u00E7\u00F5es Internacionais de Compras Parceladas (optional)</param>
        /// <param name="limiteInternacionalParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que portador pode acumular a partir da soma das parcelas das compras internacionais que forem realizadas nesta modalidade (optional)</param>
        /// <param name="limiteInternacionalSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Internacional (optional)</param>
        /// <param name="limiteInternacionalSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Internacional dentro de cada ciclo de faturamento (optional)</param>
        /// <param name="limiteMaximo">Valor m\u00E1ximo do limite de cr\u00E9dito para realizar transa\u00E7\u00F5es (optional)</param>
        /// <returns>Task of ApiResponse (LimiteDisponibilidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LimiteDisponibilidadeResponse>> AlterarAsyncWithHttpInfo (long? idConta, double? limiteGlobal = null, double? limiteCompra = null, double? limiteParcelado = null, double? limiteParcelas = null, double? limiteSaqueGlobal = null, double? limiteSaquePeriodo = null, double? limiteConsignado = null, double? limiteInternacionalCompra = null, double? limiteInternacionalParcelado = null, double? limiteInternacionalParcelas = null, double? limiteInternacionalSaqueGlobal = null, double? limiteInternacionalSaquePeriodo = null, double? limiteMaximo = null)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling Alterar");
            
    
            var localVarPath = "/api/limites-disponibilidades";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (limiteGlobal != null) localVarQueryParams.Add("limiteGlobal", Configuration.ApiClient.ParameterToString(limiteGlobal)); // query parameter
            if (limiteCompra != null) localVarQueryParams.Add("limiteCompra", Configuration.ApiClient.ParameterToString(limiteCompra)); // query parameter
            if (limiteParcelado != null) localVarQueryParams.Add("limiteParcelado", Configuration.ApiClient.ParameterToString(limiteParcelado)); // query parameter
            if (limiteParcelas != null) localVarQueryParams.Add("limiteParcelas", Configuration.ApiClient.ParameterToString(limiteParcelas)); // query parameter
            if (limiteSaqueGlobal != null) localVarQueryParams.Add("limiteSaqueGlobal", Configuration.ApiClient.ParameterToString(limiteSaqueGlobal)); // query parameter
            if (limiteSaquePeriodo != null) localVarQueryParams.Add("limiteSaquePeriodo", Configuration.ApiClient.ParameterToString(limiteSaquePeriodo)); // query parameter
            if (limiteConsignado != null) localVarQueryParams.Add("limiteConsignado", Configuration.ApiClient.ParameterToString(limiteConsignado)); // query parameter
            if (limiteInternacionalCompra != null) localVarQueryParams.Add("limiteInternacionalCompra", Configuration.ApiClient.ParameterToString(limiteInternacionalCompra)); // query parameter
            if (limiteInternacionalParcelado != null) localVarQueryParams.Add("limiteInternacionalParcelado", Configuration.ApiClient.ParameterToString(limiteInternacionalParcelado)); // query parameter
            if (limiteInternacionalParcelas != null) localVarQueryParams.Add("limiteInternacionalParcelas", Configuration.ApiClient.ParameterToString(limiteInternacionalParcelas)); // query parameter
            if (limiteInternacionalSaqueGlobal != null) localVarQueryParams.Add("limiteInternacionalSaqueGlobal", Configuration.ApiClient.ParameterToString(limiteInternacionalSaqueGlobal)); // query parameter
            if (limiteInternacionalSaquePeriodo != null) localVarQueryParams.Add("limiteInternacionalSaquePeriodo", Configuration.ApiClient.ParameterToString(limiteInternacionalSaquePeriodo)); // query parameter
            if (limiteMaximo != null) localVarQueryParams.Add("limiteMaximo", Configuration.ApiClient.ParameterToString(limiteMaximo)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LimiteDisponibilidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LimiteDisponibilidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimiteDisponibilidadeResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os limites da conta Este m\u00E9todo permite consultar os Limites configurados para uma determinada Conta, a partir do c\u00F3digo de identifica\u00E7\u00E3o da conta (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Id Conta</param> 
        /// <returns>LimiteDisponibilidadeResponse</returns>
        public LimiteDisponibilidadeResponse Consultar (long? idConta)
        {
             ApiResponse<LimiteDisponibilidadeResponse> localVarResponse = ConsultarWithHttpInfo(idConta);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os limites da conta Este m\u00E9todo permite consultar os Limites configurados para uma determinada Conta, a partir do c\u00F3digo de identifica\u00E7\u00E3o da conta (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Id Conta</param> 
        /// <returns>ApiResponse of LimiteDisponibilidadeResponse</returns>
        public ApiResponse< LimiteDisponibilidadeResponse > ConsultarWithHttpInfo (long? idConta)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling LimiteDisponibilidadeApi->Consultar");
            
    
            var localVarPath = "/api/limites-disponibilidades";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LimiteDisponibilidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LimiteDisponibilidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimiteDisponibilidadeResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os limites da conta Este m\u00E9todo permite consultar os Limites configurados para uma determinada Conta, a partir do c\u00F3digo de identifica\u00E7\u00E3o da conta (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Id Conta</param>
        /// <returns>Task of LimiteDisponibilidadeResponse</returns>
        public async System.Threading.Tasks.Task<LimiteDisponibilidadeResponse> ConsultarAsync (long? idConta)
        {
             ApiResponse<LimiteDisponibilidadeResponse> localVarResponse = await ConsultarAsyncWithHttpInfo(idConta);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os limites da conta Este m\u00E9todo permite consultar os Limites configurados para uma determinada Conta, a partir do c\u00F3digo de identifica\u00E7\u00E3o da conta (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Id Conta</param>
        /// <returns>Task of ApiResponse (LimiteDisponibilidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LimiteDisponibilidadeResponse>> ConsultarAsyncWithHttpInfo (long? idConta)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling Consultar");
            
    
            var localVarPath = "/api/limites-disponibilidades";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LimiteDisponibilidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LimiteDisponibilidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimiteDisponibilidadeResponse)));
            
        }
        
        /// <summary>
        /// Sensibilizar uma quantidade de cr\u00E9dito de global de uma conta Este m\u00E9todo permite sensibilizar, para mais ou para menos, a quantidade de cr\u00E9dito global de uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="sensibilizarSaldoGlobal">sensibilizarSaldoGlobal</param> 
        /// <returns>LimiteDisponibilidadeResponse</returns>
        public LimiteDisponibilidadeResponse SensibilizarSaldoDisponivelGlobal (long? id, SensibilizarSaldoGlobalUpdate sensibilizarSaldoGlobal)
        {
             ApiResponse<LimiteDisponibilidadeResponse> localVarResponse = SensibilizarSaldoDisponivelGlobalWithHttpInfo(id, sensibilizarSaldoGlobal);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Sensibilizar uma quantidade de cr\u00E9dito de global de uma conta Este m\u00E9todo permite sensibilizar, para mais ou para menos, a quantidade de cr\u00E9dito global de uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="sensibilizarSaldoGlobal">sensibilizarSaldoGlobal</param> 
        /// <returns>ApiResponse of LimiteDisponibilidadeResponse</returns>
        public ApiResponse< LimiteDisponibilidadeResponse > SensibilizarSaldoDisponivelGlobalWithHttpInfo (long? id, SensibilizarSaldoGlobalUpdate sensibilizarSaldoGlobal)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling LimiteDisponibilidadeApi->SensibilizarSaldoDisponivelGlobal");
            
            // verify the required parameter 'sensibilizarSaldoGlobal' is set
            if (sensibilizarSaldoGlobal == null)
                throw new ApiException(400, "Missing required parameter 'sensibilizarSaldoGlobal' when calling LimiteDisponibilidadeApi->SensibilizarSaldoDisponivelGlobal");
            
    
            var localVarPath = "/api/contas/{id}/limites-disponibilidades/sensibilizar-saldo-disponivel-global";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (sensibilizarSaldoGlobal.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(sensibilizarSaldoGlobal); // http body (model) parameter
            }
            else
            {
                localVarPostBody = sensibilizarSaldoGlobal; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SensibilizarSaldoDisponivelGlobal: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SensibilizarSaldoDisponivelGlobal: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LimiteDisponibilidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LimiteDisponibilidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimiteDisponibilidadeResponse)));
            
        }

        
        /// <summary>
        /// Sensibilizar uma quantidade de cr\u00E9dito de global de uma conta Este m\u00E9todo permite sensibilizar, para mais ou para menos, a quantidade de cr\u00E9dito global de uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sensibilizarSaldoGlobal">sensibilizarSaldoGlobal</param>
        /// <returns>Task of LimiteDisponibilidadeResponse</returns>
        public async System.Threading.Tasks.Task<LimiteDisponibilidadeResponse> SensibilizarSaldoDisponivelGlobalAsync (long? id, SensibilizarSaldoGlobalUpdate sensibilizarSaldoGlobal)
        {
             ApiResponse<LimiteDisponibilidadeResponse> localVarResponse = await SensibilizarSaldoDisponivelGlobalAsyncWithHttpInfo(id, sensibilizarSaldoGlobal);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Sensibilizar uma quantidade de cr\u00E9dito de global de uma conta Este m\u00E9todo permite sensibilizar, para mais ou para menos, a quantidade de cr\u00E9dito global de uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sensibilizarSaldoGlobal">sensibilizarSaldoGlobal</param>
        /// <returns>Task of ApiResponse (LimiteDisponibilidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LimiteDisponibilidadeResponse>> SensibilizarSaldoDisponivelGlobalAsyncWithHttpInfo (long? id, SensibilizarSaldoGlobalUpdate sensibilizarSaldoGlobal)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SensibilizarSaldoDisponivelGlobal");
            // verify the required parameter 'sensibilizarSaldoGlobal' is set
            if (sensibilizarSaldoGlobal == null) throw new ApiException(400, "Missing required parameter 'sensibilizarSaldoGlobal' when calling SensibilizarSaldoDisponivelGlobal");
            
    
            var localVarPath = "/api/contas/{id}/limites-disponibilidades/sensibilizar-saldo-disponivel-global";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (sensibilizarSaldoGlobal.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(sensibilizarSaldoGlobal); // http body (model) parameter
            }
            else
            {
                localVarPostBody = sensibilizarSaldoGlobal; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SensibilizarSaldoDisponivelGlobal: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SensibilizarSaldoDisponivelGlobal: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LimiteDisponibilidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LimiteDisponibilidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimiteDisponibilidadeResponse)));
            
        }
        
    }
    
}
