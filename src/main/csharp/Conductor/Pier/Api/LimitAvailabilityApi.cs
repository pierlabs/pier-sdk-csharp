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
    public interface ILimitAvailabilityApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Update the limits of the account
        /// </summary>
        /// <remarks>
        /// This resource allows to update the limits of a determdined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account</param>
        /// <param name="limiteGlobal">Show the Credit limit value that the cardholder has (optional)</param>
        /// <param name="limiteCompra">When it is used by the issuer, this field shows the limit credit value that the cardholder can use exclusively for national purchase (optional)</param>
        /// <param name="limiteParcelado">When used by the issuer, this field shows the credit limit value that the cardholder has to make transactions of parceled purchase (optional)</param>
        /// <param name="limiteParcelas">When it is used by the issuer, this field show the value of the credit limit that the cardholder can accumulate from the sum of the purchase parcels that were made in thos mode (optional)</param>
        /// <param name="limiteSaqueGlobal">When it is used by the issuer, this field presents the value of the credit limit that the cardholder can use to make National Withdrawal Transactions (optional)</param>
        /// <param name="limiteSaquePeriodo">When it is used by the issuer, this field shows the value of credit limit that the cardholder can use to make National Withdrawal Transactions inside of each billing cycle (optional)</param>
        /// <param name="limiteConsignado">When it is used by the issuer, this field shows the credit margin value that can be charged in a consignate form (payroll discout) in the salary/expiration (optional)</param>
        /// <param name="limiteInternacionalCompra">When it is used by the issuer, this field shows the value of the credit limit that the cardholder has to exclusively use in International Purchases (optional)</param>
        /// <param name="limiteInternacionalParcelado">When it is used by the issuer, this field presents the credit limit value that the cardholder has to make International transactions of Parceled Purchase (optional)</param>
        /// <param name="limiteInternacionalParcelas">When it is used by the issuer, this field show the value credit limit that the cardholder can accumulate using the sum of the parcels of the international purchases that are made in this modality (optional)</param>
        /// <param name="limiteInternacionalSaqueGlobal">When it is used by the issuer, this field show the limit credit value that the cardholder can use to make International Withdrawal Transactions (optional)</param>
        /// <param name="limiteInternacionalSaquePeriodo">When it is used by th issuer, this field presents the credit limit that the cardholder can use to makke Internation Withdrawal Transactions inside of each billing cycle (optional)</param>
        /// <param name="limiteMaximo">Maximum value of the credit limit for transactions (optional)</param>
        /// <returns>LimiteDisponibilidadeResponse</returns>
        LimiteDisponibilidadeResponse Alterar (long? idConta, double? limiteGlobal = null, double? limiteCompra = null, double? limiteParcelado = null, double? limiteParcelas = null, double? limiteSaqueGlobal = null, double? limiteSaquePeriodo = null, double? limiteConsignado = null, double? limiteInternacionalCompra = null, double? limiteInternacionalParcelado = null, double? limiteInternacionalParcelas = null, double? limiteInternacionalSaqueGlobal = null, double? limiteInternacionalSaquePeriodo = null, double? limiteMaximo = null);
  
        /// <summary>
        /// Update the limits of the account
        /// </summary>
        /// <remarks>
        /// This resource allows to update the limits of a determdined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account</param>
        /// <param name="limiteGlobal">Show the Credit limit value that the cardholder has (optional)</param>
        /// <param name="limiteCompra">When it is used by the issuer, this field shows the limit credit value that the cardholder can use exclusively for national purchase (optional)</param>
        /// <param name="limiteParcelado">When used by the issuer, this field shows the credit limit value that the cardholder has to make transactions of parceled purchase (optional)</param>
        /// <param name="limiteParcelas">When it is used by the issuer, this field show the value of the credit limit that the cardholder can accumulate from the sum of the purchase parcels that were made in thos mode (optional)</param>
        /// <param name="limiteSaqueGlobal">When it is used by the issuer, this field presents the value of the credit limit that the cardholder can use to make National Withdrawal Transactions (optional)</param>
        /// <param name="limiteSaquePeriodo">When it is used by the issuer, this field shows the value of credit limit that the cardholder can use to make National Withdrawal Transactions inside of each billing cycle (optional)</param>
        /// <param name="limiteConsignado">When it is used by the issuer, this field shows the credit margin value that can be charged in a consignate form (payroll discout) in the salary/expiration (optional)</param>
        /// <param name="limiteInternacionalCompra">When it is used by the issuer, this field shows the value of the credit limit that the cardholder has to exclusively use in International Purchases (optional)</param>
        /// <param name="limiteInternacionalParcelado">When it is used by the issuer, this field presents the credit limit value that the cardholder has to make International transactions of Parceled Purchase (optional)</param>
        /// <param name="limiteInternacionalParcelas">When it is used by the issuer, this field show the value credit limit that the cardholder can accumulate using the sum of the parcels of the international purchases that are made in this modality (optional)</param>
        /// <param name="limiteInternacionalSaqueGlobal">When it is used by the issuer, this field show the limit credit value that the cardholder can use to make International Withdrawal Transactions (optional)</param>
        /// <param name="limiteInternacionalSaquePeriodo">When it is used by th issuer, this field presents the credit limit that the cardholder can use to makke Internation Withdrawal Transactions inside of each billing cycle (optional)</param>
        /// <param name="limiteMaximo">Maximum value of the credit limit for transactions (optional)</param>
        /// <returns>ApiResponse of LimiteDisponibilidadeResponse</returns>
        ApiResponse<LimiteDisponibilidadeResponse> AlterarWithHttpInfo (long? idConta, double? limiteGlobal = null, double? limiteCompra = null, double? limiteParcelado = null, double? limiteParcelas = null, double? limiteSaqueGlobal = null, double? limiteSaquePeriodo = null, double? limiteConsignado = null, double? limiteInternacionalCompra = null, double? limiteInternacionalParcelado = null, double? limiteInternacionalParcelas = null, double? limiteInternacionalSaqueGlobal = null, double? limiteInternacionalSaquePeriodo = null, double? limiteMaximo = null);
        
        /// <summary>
        /// Show the limits of the account
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve the limits connfigurated for a determined account, using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Id Account</param>
        /// <returns>LimiteDisponibilidadeResponse</returns>
        LimiteDisponibilidadeResponse Consultar (long? idConta);
  
        /// <summary>
        /// Show the limits of the account
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve the limits connfigurated for a determined account, using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Id Account</param>
        /// <returns>ApiResponse of LimiteDisponibilidadeResponse</returns>
        ApiResponse<LimiteDisponibilidadeResponse> ConsultarWithHttpInfo (long? idConta);
        
        /// <summary>
        /// Increments the global credit quantity of a account
        /// </summary>
        /// <remarks>
        /// This resource permits increment, to more or to less, the global credit quantity of a account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account status (id)</param>
        /// <param name="sensibilizarSaldoGlobal">sensibilizarSaldoGlobal</param>
        /// <returns>LimiteDisponibilidadeResponse</returns>
        LimiteDisponibilidadeResponse SensibilizarSaldoDisponivelGlobal (long? id, SensibilizarSaldoGlobalUpdate sensibilizarSaldoGlobal);
  
        /// <summary>
        /// Increments the global credit quantity of a account
        /// </summary>
        /// <remarks>
        /// This resource permits increment, to more or to less, the global credit quantity of a account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account status (id)</param>
        /// <param name="sensibilizarSaldoGlobal">sensibilizarSaldoGlobal</param>
        /// <returns>ApiResponse of LimiteDisponibilidadeResponse</returns>
        ApiResponse<LimiteDisponibilidadeResponse> SensibilizarSaldoDisponivelGlobalWithHttpInfo (long? id, SensibilizarSaldoGlobalUpdate sensibilizarSaldoGlobal);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Update the limits of the account
        /// </summary>
        /// <remarks>
        /// This resource allows to update the limits of a determdined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account</param>
        /// <param name="limiteGlobal">Show the Credit limit value that the cardholder has (optional)</param>
        /// <param name="limiteCompra">When it is used by the issuer, this field shows the limit credit value that the cardholder can use exclusively for national purchase (optional)</param>
        /// <param name="limiteParcelado">When used by the issuer, this field shows the credit limit value that the cardholder has to make transactions of parceled purchase (optional)</param>
        /// <param name="limiteParcelas">When it is used by the issuer, this field show the value of the credit limit that the cardholder can accumulate from the sum of the purchase parcels that were made in thos mode (optional)</param>
        /// <param name="limiteSaqueGlobal">When it is used by the issuer, this field presents the value of the credit limit that the cardholder can use to make National Withdrawal Transactions (optional)</param>
        /// <param name="limiteSaquePeriodo">When it is used by the issuer, this field shows the value of credit limit that the cardholder can use to make National Withdrawal Transactions inside of each billing cycle (optional)</param>
        /// <param name="limiteConsignado">When it is used by the issuer, this field shows the credit margin value that can be charged in a consignate form (payroll discout) in the salary/expiration (optional)</param>
        /// <param name="limiteInternacionalCompra">When it is used by the issuer, this field shows the value of the credit limit that the cardholder has to exclusively use in International Purchases (optional)</param>
        /// <param name="limiteInternacionalParcelado">When it is used by the issuer, this field presents the credit limit value that the cardholder has to make International transactions of Parceled Purchase (optional)</param>
        /// <param name="limiteInternacionalParcelas">When it is used by the issuer, this field show the value credit limit that the cardholder can accumulate using the sum of the parcels of the international purchases that are made in this modality (optional)</param>
        /// <param name="limiteInternacionalSaqueGlobal">When it is used by the issuer, this field show the limit credit value that the cardholder can use to make International Withdrawal Transactions (optional)</param>
        /// <param name="limiteInternacionalSaquePeriodo">When it is used by th issuer, this field presents the credit limit that the cardholder can use to makke Internation Withdrawal Transactions inside of each billing cycle (optional)</param>
        /// <param name="limiteMaximo">Maximum value of the credit limit for transactions (optional)</param>
        /// <returns>Task of LimiteDisponibilidadeResponse</returns>
        System.Threading.Tasks.Task<LimiteDisponibilidadeResponse> AlterarAsync (long? idConta, double? limiteGlobal = null, double? limiteCompra = null, double? limiteParcelado = null, double? limiteParcelas = null, double? limiteSaqueGlobal = null, double? limiteSaquePeriodo = null, double? limiteConsignado = null, double? limiteInternacionalCompra = null, double? limiteInternacionalParcelado = null, double? limiteInternacionalParcelas = null, double? limiteInternacionalSaqueGlobal = null, double? limiteInternacionalSaquePeriodo = null, double? limiteMaximo = null);

        /// <summary>
        /// Update the limits of the account
        /// </summary>
        /// <remarks>
        /// This resource allows to update the limits of a determdined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account</param>
        /// <param name="limiteGlobal">Show the Credit limit value that the cardholder has (optional)</param>
        /// <param name="limiteCompra">When it is used by the issuer, this field shows the limit credit value that the cardholder can use exclusively for national purchase (optional)</param>
        /// <param name="limiteParcelado">When used by the issuer, this field shows the credit limit value that the cardholder has to make transactions of parceled purchase (optional)</param>
        /// <param name="limiteParcelas">When it is used by the issuer, this field show the value of the credit limit that the cardholder can accumulate from the sum of the purchase parcels that were made in thos mode (optional)</param>
        /// <param name="limiteSaqueGlobal">When it is used by the issuer, this field presents the value of the credit limit that the cardholder can use to make National Withdrawal Transactions (optional)</param>
        /// <param name="limiteSaquePeriodo">When it is used by the issuer, this field shows the value of credit limit that the cardholder can use to make National Withdrawal Transactions inside of each billing cycle (optional)</param>
        /// <param name="limiteConsignado">When it is used by the issuer, this field shows the credit margin value that can be charged in a consignate form (payroll discout) in the salary/expiration (optional)</param>
        /// <param name="limiteInternacionalCompra">When it is used by the issuer, this field shows the value of the credit limit that the cardholder has to exclusively use in International Purchases (optional)</param>
        /// <param name="limiteInternacionalParcelado">When it is used by the issuer, this field presents the credit limit value that the cardholder has to make International transactions of Parceled Purchase (optional)</param>
        /// <param name="limiteInternacionalParcelas">When it is used by the issuer, this field show the value credit limit that the cardholder can accumulate using the sum of the parcels of the international purchases that are made in this modality (optional)</param>
        /// <param name="limiteInternacionalSaqueGlobal">When it is used by the issuer, this field show the limit credit value that the cardholder can use to make International Withdrawal Transactions (optional)</param>
        /// <param name="limiteInternacionalSaquePeriodo">When it is used by th issuer, this field presents the credit limit that the cardholder can use to makke Internation Withdrawal Transactions inside of each billing cycle (optional)</param>
        /// <param name="limiteMaximo">Maximum value of the credit limit for transactions (optional)</param>
        /// <returns>Task of ApiResponse (LimiteDisponibilidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LimiteDisponibilidadeResponse>> AlterarAsyncWithHttpInfo (long? idConta, double? limiteGlobal = null, double? limiteCompra = null, double? limiteParcelado = null, double? limiteParcelas = null, double? limiteSaqueGlobal = null, double? limiteSaquePeriodo = null, double? limiteConsignado = null, double? limiteInternacionalCompra = null, double? limiteInternacionalParcelado = null, double? limiteInternacionalParcelas = null, double? limiteInternacionalSaqueGlobal = null, double? limiteInternacionalSaquePeriodo = null, double? limiteMaximo = null);
        
        /// <summary>
        /// Show the limits of the account
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve the limits connfigurated for a determined account, using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Id Account</param>
        /// <returns>Task of LimiteDisponibilidadeResponse</returns>
        System.Threading.Tasks.Task<LimiteDisponibilidadeResponse> ConsultarAsync (long? idConta);

        /// <summary>
        /// Show the limits of the account
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve the limits connfigurated for a determined account, using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Id Account</param>
        /// <returns>Task of ApiResponse (LimiteDisponibilidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LimiteDisponibilidadeResponse>> ConsultarAsyncWithHttpInfo (long? idConta);
        
        /// <summary>
        /// Increments the global credit quantity of a account
        /// </summary>
        /// <remarks>
        /// This resource permits increment, to more or to less, the global credit quantity of a account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account status (id)</param>
        /// <param name="sensibilizarSaldoGlobal">sensibilizarSaldoGlobal</param>
        /// <returns>Task of LimiteDisponibilidadeResponse</returns>
        System.Threading.Tasks.Task<LimiteDisponibilidadeResponse> SensibilizarSaldoDisponivelGlobalAsync (long? id, SensibilizarSaldoGlobalUpdate sensibilizarSaldoGlobal);

        /// <summary>
        /// Increments the global credit quantity of a account
        /// </summary>
        /// <remarks>
        /// This resource permits increment, to more or to less, the global credit quantity of a account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account status (id)</param>
        /// <param name="sensibilizarSaldoGlobal">sensibilizarSaldoGlobal</param>
        /// <returns>Task of ApiResponse (LimiteDisponibilidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LimiteDisponibilidadeResponse>> SensibilizarSaldoDisponivelGlobalAsyncWithHttpInfo (long? id, SensibilizarSaldoGlobalUpdate sensibilizarSaldoGlobal);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LimitAvailabilityApi : ILimitAvailabilityApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LimitAvailabilityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LimitAvailabilityApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LimitAvailabilityApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LimitAvailabilityApi(Configuration configuration = null)
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
        /// Update the limits of the account This resource allows to update the limits of a determdined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account</param> 
        /// <param name="limiteGlobal">Show the Credit limit value that the cardholder has (optional)</param> 
        /// <param name="limiteCompra">When it is used by the issuer, this field shows the limit credit value that the cardholder can use exclusively for national purchase (optional)</param> 
        /// <param name="limiteParcelado">When used by the issuer, this field shows the credit limit value that the cardholder has to make transactions of parceled purchase (optional)</param> 
        /// <param name="limiteParcelas">When it is used by the issuer, this field show the value of the credit limit that the cardholder can accumulate from the sum of the purchase parcels that were made in thos mode (optional)</param> 
        /// <param name="limiteSaqueGlobal">When it is used by the issuer, this field presents the value of the credit limit that the cardholder can use to make National Withdrawal Transactions (optional)</param> 
        /// <param name="limiteSaquePeriodo">When it is used by the issuer, this field shows the value of credit limit that the cardholder can use to make National Withdrawal Transactions inside of each billing cycle (optional)</param> 
        /// <param name="limiteConsignado">When it is used by the issuer, this field shows the credit margin value that can be charged in a consignate form (payroll discout) in the salary/expiration (optional)</param> 
        /// <param name="limiteInternacionalCompra">When it is used by the issuer, this field shows the value of the credit limit that the cardholder has to exclusively use in International Purchases (optional)</param> 
        /// <param name="limiteInternacionalParcelado">When it is used by the issuer, this field presents the credit limit value that the cardholder has to make International transactions of Parceled Purchase (optional)</param> 
        /// <param name="limiteInternacionalParcelas">When it is used by the issuer, this field show the value credit limit that the cardholder can accumulate using the sum of the parcels of the international purchases that are made in this modality (optional)</param> 
        /// <param name="limiteInternacionalSaqueGlobal">When it is used by the issuer, this field show the limit credit value that the cardholder can use to make International Withdrawal Transactions (optional)</param> 
        /// <param name="limiteInternacionalSaquePeriodo">When it is used by th issuer, this field presents the credit limit that the cardholder can use to makke Internation Withdrawal Transactions inside of each billing cycle (optional)</param> 
        /// <param name="limiteMaximo">Maximum value of the credit limit for transactions (optional)</param> 
        /// <returns>LimiteDisponibilidadeResponse</returns>
        public LimiteDisponibilidadeResponse Alterar (long? idConta, double? limiteGlobal = null, double? limiteCompra = null, double? limiteParcelado = null, double? limiteParcelas = null, double? limiteSaqueGlobal = null, double? limiteSaquePeriodo = null, double? limiteConsignado = null, double? limiteInternacionalCompra = null, double? limiteInternacionalParcelado = null, double? limiteInternacionalParcelas = null, double? limiteInternacionalSaqueGlobal = null, double? limiteInternacionalSaquePeriodo = null, double? limiteMaximo = null)
        {
             ApiResponse<LimiteDisponibilidadeResponse> localVarResponse = AlterarWithHttpInfo(idConta, limiteGlobal, limiteCompra, limiteParcelado, limiteParcelas, limiteSaqueGlobal, limiteSaquePeriodo, limiteConsignado, limiteInternacionalCompra, limiteInternacionalParcelado, limiteInternacionalParcelas, limiteInternacionalSaqueGlobal, limiteInternacionalSaquePeriodo, limiteMaximo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the limits of the account This resource allows to update the limits of a determdined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account</param> 
        /// <param name="limiteGlobal">Show the Credit limit value that the cardholder has (optional)</param> 
        /// <param name="limiteCompra">When it is used by the issuer, this field shows the limit credit value that the cardholder can use exclusively for national purchase (optional)</param> 
        /// <param name="limiteParcelado">When used by the issuer, this field shows the credit limit value that the cardholder has to make transactions of parceled purchase (optional)</param> 
        /// <param name="limiteParcelas">When it is used by the issuer, this field show the value of the credit limit that the cardholder can accumulate from the sum of the purchase parcels that were made in thos mode (optional)</param> 
        /// <param name="limiteSaqueGlobal">When it is used by the issuer, this field presents the value of the credit limit that the cardholder can use to make National Withdrawal Transactions (optional)</param> 
        /// <param name="limiteSaquePeriodo">When it is used by the issuer, this field shows the value of credit limit that the cardholder can use to make National Withdrawal Transactions inside of each billing cycle (optional)</param> 
        /// <param name="limiteConsignado">When it is used by the issuer, this field shows the credit margin value that can be charged in a consignate form (payroll discout) in the salary/expiration (optional)</param> 
        /// <param name="limiteInternacionalCompra">When it is used by the issuer, this field shows the value of the credit limit that the cardholder has to exclusively use in International Purchases (optional)</param> 
        /// <param name="limiteInternacionalParcelado">When it is used by the issuer, this field presents the credit limit value that the cardholder has to make International transactions of Parceled Purchase (optional)</param> 
        /// <param name="limiteInternacionalParcelas">When it is used by the issuer, this field show the value credit limit that the cardholder can accumulate using the sum of the parcels of the international purchases that are made in this modality (optional)</param> 
        /// <param name="limiteInternacionalSaqueGlobal">When it is used by the issuer, this field show the limit credit value that the cardholder can use to make International Withdrawal Transactions (optional)</param> 
        /// <param name="limiteInternacionalSaquePeriodo">When it is used by th issuer, this field presents the credit limit that the cardholder can use to makke Internation Withdrawal Transactions inside of each billing cycle (optional)</param> 
        /// <param name="limiteMaximo">Maximum value of the credit limit for transactions (optional)</param> 
        /// <returns>ApiResponse of LimiteDisponibilidadeResponse</returns>
        public ApiResponse< LimiteDisponibilidadeResponse > AlterarWithHttpInfo (long? idConta, double? limiteGlobal = null, double? limiteCompra = null, double? limiteParcelado = null, double? limiteParcelas = null, double? limiteSaqueGlobal = null, double? limiteSaquePeriodo = null, double? limiteConsignado = null, double? limiteInternacionalCompra = null, double? limiteInternacionalParcelado = null, double? limiteInternacionalParcelas = null, double? limiteInternacionalSaqueGlobal = null, double? limiteInternacionalSaquePeriodo = null, double? limiteMaximo = null)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling LimitAvailabilityApi->Alterar");
            
    
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
        /// Update the limits of the account This resource allows to update the limits of a determdined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account</param>
        /// <param name="limiteGlobal">Show the Credit limit value that the cardholder has (optional)</param>
        /// <param name="limiteCompra">When it is used by the issuer, this field shows the limit credit value that the cardholder can use exclusively for national purchase (optional)</param>
        /// <param name="limiteParcelado">When used by the issuer, this field shows the credit limit value that the cardholder has to make transactions of parceled purchase (optional)</param>
        /// <param name="limiteParcelas">When it is used by the issuer, this field show the value of the credit limit that the cardholder can accumulate from the sum of the purchase parcels that were made in thos mode (optional)</param>
        /// <param name="limiteSaqueGlobal">When it is used by the issuer, this field presents the value of the credit limit that the cardholder can use to make National Withdrawal Transactions (optional)</param>
        /// <param name="limiteSaquePeriodo">When it is used by the issuer, this field shows the value of credit limit that the cardholder can use to make National Withdrawal Transactions inside of each billing cycle (optional)</param>
        /// <param name="limiteConsignado">When it is used by the issuer, this field shows the credit margin value that can be charged in a consignate form (payroll discout) in the salary/expiration (optional)</param>
        /// <param name="limiteInternacionalCompra">When it is used by the issuer, this field shows the value of the credit limit that the cardholder has to exclusively use in International Purchases (optional)</param>
        /// <param name="limiteInternacionalParcelado">When it is used by the issuer, this field presents the credit limit value that the cardholder has to make International transactions of Parceled Purchase (optional)</param>
        /// <param name="limiteInternacionalParcelas">When it is used by the issuer, this field show the value credit limit that the cardholder can accumulate using the sum of the parcels of the international purchases that are made in this modality (optional)</param>
        /// <param name="limiteInternacionalSaqueGlobal">When it is used by the issuer, this field show the limit credit value that the cardholder can use to make International Withdrawal Transactions (optional)</param>
        /// <param name="limiteInternacionalSaquePeriodo">When it is used by th issuer, this field presents the credit limit that the cardholder can use to makke Internation Withdrawal Transactions inside of each billing cycle (optional)</param>
        /// <param name="limiteMaximo">Maximum value of the credit limit for transactions (optional)</param>
        /// <returns>Task of LimiteDisponibilidadeResponse</returns>
        public async System.Threading.Tasks.Task<LimiteDisponibilidadeResponse> AlterarAsync (long? idConta, double? limiteGlobal = null, double? limiteCompra = null, double? limiteParcelado = null, double? limiteParcelas = null, double? limiteSaqueGlobal = null, double? limiteSaquePeriodo = null, double? limiteConsignado = null, double? limiteInternacionalCompra = null, double? limiteInternacionalParcelado = null, double? limiteInternacionalParcelas = null, double? limiteInternacionalSaqueGlobal = null, double? limiteInternacionalSaquePeriodo = null, double? limiteMaximo = null)
        {
             ApiResponse<LimiteDisponibilidadeResponse> localVarResponse = await AlterarAsyncWithHttpInfo(idConta, limiteGlobal, limiteCompra, limiteParcelado, limiteParcelas, limiteSaqueGlobal, limiteSaquePeriodo, limiteConsignado, limiteInternacionalCompra, limiteInternacionalParcelado, limiteInternacionalParcelas, limiteInternacionalSaqueGlobal, limiteInternacionalSaquePeriodo, limiteMaximo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the limits of the account This resource allows to update the limits of a determdined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account</param>
        /// <param name="limiteGlobal">Show the Credit limit value that the cardholder has (optional)</param>
        /// <param name="limiteCompra">When it is used by the issuer, this field shows the limit credit value that the cardholder can use exclusively for national purchase (optional)</param>
        /// <param name="limiteParcelado">When used by the issuer, this field shows the credit limit value that the cardholder has to make transactions of parceled purchase (optional)</param>
        /// <param name="limiteParcelas">When it is used by the issuer, this field show the value of the credit limit that the cardholder can accumulate from the sum of the purchase parcels that were made in thos mode (optional)</param>
        /// <param name="limiteSaqueGlobal">When it is used by the issuer, this field presents the value of the credit limit that the cardholder can use to make National Withdrawal Transactions (optional)</param>
        /// <param name="limiteSaquePeriodo">When it is used by the issuer, this field shows the value of credit limit that the cardholder can use to make National Withdrawal Transactions inside of each billing cycle (optional)</param>
        /// <param name="limiteConsignado">When it is used by the issuer, this field shows the credit margin value that can be charged in a consignate form (payroll discout) in the salary/expiration (optional)</param>
        /// <param name="limiteInternacionalCompra">When it is used by the issuer, this field shows the value of the credit limit that the cardholder has to exclusively use in International Purchases (optional)</param>
        /// <param name="limiteInternacionalParcelado">When it is used by the issuer, this field presents the credit limit value that the cardholder has to make International transactions of Parceled Purchase (optional)</param>
        /// <param name="limiteInternacionalParcelas">When it is used by the issuer, this field show the value credit limit that the cardholder can accumulate using the sum of the parcels of the international purchases that are made in this modality (optional)</param>
        /// <param name="limiteInternacionalSaqueGlobal">When it is used by the issuer, this field show the limit credit value that the cardholder can use to make International Withdrawal Transactions (optional)</param>
        /// <param name="limiteInternacionalSaquePeriodo">When it is used by th issuer, this field presents the credit limit that the cardholder can use to makke Internation Withdrawal Transactions inside of each billing cycle (optional)</param>
        /// <param name="limiteMaximo">Maximum value of the credit limit for transactions (optional)</param>
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
        /// Show the limits of the account This method allows to retrieve the limits connfigurated for a determined account, using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Id Account</param> 
        /// <returns>LimiteDisponibilidadeResponse</returns>
        public LimiteDisponibilidadeResponse Consultar (long? idConta)
        {
             ApiResponse<LimiteDisponibilidadeResponse> localVarResponse = ConsultarWithHttpInfo(idConta);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Show the limits of the account This method allows to retrieve the limits connfigurated for a determined account, using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Id Account</param> 
        /// <returns>ApiResponse of LimiteDisponibilidadeResponse</returns>
        public ApiResponse< LimiteDisponibilidadeResponse > ConsultarWithHttpInfo (long? idConta)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling LimitAvailabilityApi->Consultar");
            
    
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
        /// Show the limits of the account This method allows to retrieve the limits connfigurated for a determined account, using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Id Account</param>
        /// <returns>Task of LimiteDisponibilidadeResponse</returns>
        public async System.Threading.Tasks.Task<LimiteDisponibilidadeResponse> ConsultarAsync (long? idConta)
        {
             ApiResponse<LimiteDisponibilidadeResponse> localVarResponse = await ConsultarAsyncWithHttpInfo(idConta);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Show the limits of the account This method allows to retrieve the limits connfigurated for a determined account, using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Id Account</param>
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
        /// Increments the global credit quantity of a account This resource permits increment, to more or to less, the global credit quantity of a account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account status (id)</param> 
        /// <param name="sensibilizarSaldoGlobal">sensibilizarSaldoGlobal</param> 
        /// <returns>LimiteDisponibilidadeResponse</returns>
        public LimiteDisponibilidadeResponse SensibilizarSaldoDisponivelGlobal (long? id, SensibilizarSaldoGlobalUpdate sensibilizarSaldoGlobal)
        {
             ApiResponse<LimiteDisponibilidadeResponse> localVarResponse = SensibilizarSaldoDisponivelGlobalWithHttpInfo(id, sensibilizarSaldoGlobal);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Increments the global credit quantity of a account This resource permits increment, to more or to less, the global credit quantity of a account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account status (id)</param> 
        /// <param name="sensibilizarSaldoGlobal">sensibilizarSaldoGlobal</param> 
        /// <returns>ApiResponse of LimiteDisponibilidadeResponse</returns>
        public ApiResponse< LimiteDisponibilidadeResponse > SensibilizarSaldoDisponivelGlobalWithHttpInfo (long? id, SensibilizarSaldoGlobalUpdate sensibilizarSaldoGlobal)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling LimitAvailabilityApi->SensibilizarSaldoDisponivelGlobal");
            
            // verify the required parameter 'sensibilizarSaldoGlobal' is set
            if (sensibilizarSaldoGlobal == null)
                throw new ApiException(400, "Missing required parameter 'sensibilizarSaldoGlobal' when calling LimitAvailabilityApi->SensibilizarSaldoDisponivelGlobal");
            
    
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
        /// Increments the global credit quantity of a account This resource permits increment, to more or to less, the global credit quantity of a account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account status (id)</param>
        /// <param name="sensibilizarSaldoGlobal">sensibilizarSaldoGlobal</param>
        /// <returns>Task of LimiteDisponibilidadeResponse</returns>
        public async System.Threading.Tasks.Task<LimiteDisponibilidadeResponse> SensibilizarSaldoDisponivelGlobalAsync (long? id, SensibilizarSaldoGlobalUpdate sensibilizarSaldoGlobal)
        {
             ApiResponse<LimiteDisponibilidadeResponse> localVarResponse = await SensibilizarSaldoDisponivelGlobalAsyncWithHttpInfo(id, sensibilizarSaldoGlobal);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Increments the global credit quantity of a account This resource permits increment, to more or to less, the global credit quantity of a account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account status (id)</param>
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
