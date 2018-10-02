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
    public interface IGlobaltaglimitedisponibilidadeApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{limite_disponibilidade_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{limite_disponibilidade_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{limite_disponibilidade_update_id_conta_value}}}</param>
        /// <param name="limiteGlobal">{{{limite_disponibilidade_persist_limite_global_value}}} (optional)</param>
        /// <param name="limiteCompra">{{{limite_disponibilidade_persist_limite_compra_value}}} (optional)</param>
        /// <param name="limiteParcelado">{{{limite_disponibilidade_persist_limite_parcelado_value}}} (optional)</param>
        /// <param name="limiteParcelas">{{{limite_disponibilidade_persist_limite_parcelas_value}}} (optional)</param>
        /// <param name="limiteSaqueGlobal">{{{limite_disponibilidade_persist_limite_saque_global_value}}} (optional)</param>
        /// <param name="limiteSaquePeriodo">{{{limite_disponibilidade_persist_limite_saque_periodo_value}}} (optional)</param>
        /// <param name="limiteConsignado">{{{limite_disponibilidade_persist_limite_consignado_value}}} (optional)</param>
        /// <param name="limiteInternacionalCompra">{{{limite_disponibilidade_persist_limite_internacional_compra_value}}} (optional)</param>
        /// <param name="limiteInternacionalParcelado">{{{limite_disponibilidade_persist_limite_internacional_parcelado_value}}} (optional)</param>
        /// <param name="limiteInternacionalParcelas">{{{limite_disponibilidade_persist_limite_internacional_parcelas_value}}} (optional)</param>
        /// <param name="limiteInternacionalSaqueGlobal">{{{limite_disponibilidade_persist_limite_internacional_saque_global_value}}} (optional)</param>
        /// <param name="limiteInternacionalSaquePeriodo">{{{limite_disponibilidade_persist_limite_internacional_saque_periodo_value}}} (optional)</param>
        /// <param name="limiteMaximo">{{{limite_disponibilidade_persist_limite_maximo_value}}} (optional)</param>
        /// <returns>LimiteDisponibilidadeResponse</returns>
        LimiteDisponibilidadeResponse AlterarUsingPUT8 (long? idConta, double? limiteGlobal = null, double? limiteCompra = null, double? limiteParcelado = null, double? limiteParcelas = null, double? limiteSaqueGlobal = null, double? limiteSaquePeriodo = null, double? limiteConsignado = null, double? limiteInternacionalCompra = null, double? limiteInternacionalParcelado = null, double? limiteInternacionalParcelas = null, double? limiteInternacionalSaqueGlobal = null, double? limiteInternacionalSaquePeriodo = null, double? limiteMaximo = null);
  
        /// <summary>
        /// {{{limite_disponibilidade_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{limite_disponibilidade_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{limite_disponibilidade_update_id_conta_value}}}</param>
        /// <param name="limiteGlobal">{{{limite_disponibilidade_persist_limite_global_value}}} (optional)</param>
        /// <param name="limiteCompra">{{{limite_disponibilidade_persist_limite_compra_value}}} (optional)</param>
        /// <param name="limiteParcelado">{{{limite_disponibilidade_persist_limite_parcelado_value}}} (optional)</param>
        /// <param name="limiteParcelas">{{{limite_disponibilidade_persist_limite_parcelas_value}}} (optional)</param>
        /// <param name="limiteSaqueGlobal">{{{limite_disponibilidade_persist_limite_saque_global_value}}} (optional)</param>
        /// <param name="limiteSaquePeriodo">{{{limite_disponibilidade_persist_limite_saque_periodo_value}}} (optional)</param>
        /// <param name="limiteConsignado">{{{limite_disponibilidade_persist_limite_consignado_value}}} (optional)</param>
        /// <param name="limiteInternacionalCompra">{{{limite_disponibilidade_persist_limite_internacional_compra_value}}} (optional)</param>
        /// <param name="limiteInternacionalParcelado">{{{limite_disponibilidade_persist_limite_internacional_parcelado_value}}} (optional)</param>
        /// <param name="limiteInternacionalParcelas">{{{limite_disponibilidade_persist_limite_internacional_parcelas_value}}} (optional)</param>
        /// <param name="limiteInternacionalSaqueGlobal">{{{limite_disponibilidade_persist_limite_internacional_saque_global_value}}} (optional)</param>
        /// <param name="limiteInternacionalSaquePeriodo">{{{limite_disponibilidade_persist_limite_internacional_saque_periodo_value}}} (optional)</param>
        /// <param name="limiteMaximo">{{{limite_disponibilidade_persist_limite_maximo_value}}} (optional)</param>
        /// <returns>ApiResponse of LimiteDisponibilidadeResponse</returns>
        ApiResponse<LimiteDisponibilidadeResponse> AlterarUsingPUT8WithHttpInfo (long? idConta, double? limiteGlobal = null, double? limiteCompra = null, double? limiteParcelado = null, double? limiteParcelas = null, double? limiteSaqueGlobal = null, double? limiteSaquePeriodo = null, double? limiteConsignado = null, double? limiteInternacionalCompra = null, double? limiteInternacionalParcelado = null, double? limiteInternacionalParcelas = null, double? limiteInternacionalSaqueGlobal = null, double? limiteInternacionalSaquePeriodo = null, double? limiteMaximo = null);
        
        /// <summary>
        /// {{{limite_disponibilidade_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{limite_disponibilidade_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{limite_disponibilidade_resource_consultar_param_id_conta}}}</param>
        /// <returns>LimiteDisponibilidadeResponse</returns>
        LimiteDisponibilidadeResponse ConsultarUsingGET21 (long? idConta);
  
        /// <summary>
        /// {{{limite_disponibilidade_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{limite_disponibilidade_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{limite_disponibilidade_resource_consultar_param_id_conta}}}</param>
        /// <returns>ApiResponse of LimiteDisponibilidadeResponse</returns>
        ApiResponse<LimiteDisponibilidadeResponse> ConsultarUsingGET21WithHttpInfo (long? idConta);
        
        /// <summary>
        /// {{{limite_disponibilidade_resource_sensibilizar_credito_disponivel}}}
        /// </summary>
        /// <remarks>
        /// {{{limite_disponibilidade_resource_sensibilizar_credito_disponivel_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{sensibilizar_saldo_global_param_id}}}</param>
        /// <param name="sensibilizarSaldoGlobal">sensibilizarSaldoGlobal</param>
        /// <returns>LimiteDisponibilidadeResponse</returns>
        LimiteDisponibilidadeResponse SensibilizarSaldoDisponivelGlobalUsingPOST (long? id, SensibilizarSaldoGlobalUpdateValue sensibilizarSaldoGlobal);
  
        /// <summary>
        /// {{{limite_disponibilidade_resource_sensibilizar_credito_disponivel}}}
        /// </summary>
        /// <remarks>
        /// {{{limite_disponibilidade_resource_sensibilizar_credito_disponivel_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{sensibilizar_saldo_global_param_id}}}</param>
        /// <param name="sensibilizarSaldoGlobal">sensibilizarSaldoGlobal</param>
        /// <returns>ApiResponse of LimiteDisponibilidadeResponse</returns>
        ApiResponse<LimiteDisponibilidadeResponse> SensibilizarSaldoDisponivelGlobalUsingPOSTWithHttpInfo (long? id, SensibilizarSaldoGlobalUpdateValue sensibilizarSaldoGlobal);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{limite_disponibilidade_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{limite_disponibilidade_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{limite_disponibilidade_update_id_conta_value}}}</param>
        /// <param name="limiteGlobal">{{{limite_disponibilidade_persist_limite_global_value}}} (optional)</param>
        /// <param name="limiteCompra">{{{limite_disponibilidade_persist_limite_compra_value}}} (optional)</param>
        /// <param name="limiteParcelado">{{{limite_disponibilidade_persist_limite_parcelado_value}}} (optional)</param>
        /// <param name="limiteParcelas">{{{limite_disponibilidade_persist_limite_parcelas_value}}} (optional)</param>
        /// <param name="limiteSaqueGlobal">{{{limite_disponibilidade_persist_limite_saque_global_value}}} (optional)</param>
        /// <param name="limiteSaquePeriodo">{{{limite_disponibilidade_persist_limite_saque_periodo_value}}} (optional)</param>
        /// <param name="limiteConsignado">{{{limite_disponibilidade_persist_limite_consignado_value}}} (optional)</param>
        /// <param name="limiteInternacionalCompra">{{{limite_disponibilidade_persist_limite_internacional_compra_value}}} (optional)</param>
        /// <param name="limiteInternacionalParcelado">{{{limite_disponibilidade_persist_limite_internacional_parcelado_value}}} (optional)</param>
        /// <param name="limiteInternacionalParcelas">{{{limite_disponibilidade_persist_limite_internacional_parcelas_value}}} (optional)</param>
        /// <param name="limiteInternacionalSaqueGlobal">{{{limite_disponibilidade_persist_limite_internacional_saque_global_value}}} (optional)</param>
        /// <param name="limiteInternacionalSaquePeriodo">{{{limite_disponibilidade_persist_limite_internacional_saque_periodo_value}}} (optional)</param>
        /// <param name="limiteMaximo">{{{limite_disponibilidade_persist_limite_maximo_value}}} (optional)</param>
        /// <returns>Task of LimiteDisponibilidadeResponse</returns>
        System.Threading.Tasks.Task<LimiteDisponibilidadeResponse> AlterarUsingPUT8Async (long? idConta, double? limiteGlobal = null, double? limiteCompra = null, double? limiteParcelado = null, double? limiteParcelas = null, double? limiteSaqueGlobal = null, double? limiteSaquePeriodo = null, double? limiteConsignado = null, double? limiteInternacionalCompra = null, double? limiteInternacionalParcelado = null, double? limiteInternacionalParcelas = null, double? limiteInternacionalSaqueGlobal = null, double? limiteInternacionalSaquePeriodo = null, double? limiteMaximo = null);

        /// <summary>
        /// {{{limite_disponibilidade_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{limite_disponibilidade_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{limite_disponibilidade_update_id_conta_value}}}</param>
        /// <param name="limiteGlobal">{{{limite_disponibilidade_persist_limite_global_value}}} (optional)</param>
        /// <param name="limiteCompra">{{{limite_disponibilidade_persist_limite_compra_value}}} (optional)</param>
        /// <param name="limiteParcelado">{{{limite_disponibilidade_persist_limite_parcelado_value}}} (optional)</param>
        /// <param name="limiteParcelas">{{{limite_disponibilidade_persist_limite_parcelas_value}}} (optional)</param>
        /// <param name="limiteSaqueGlobal">{{{limite_disponibilidade_persist_limite_saque_global_value}}} (optional)</param>
        /// <param name="limiteSaquePeriodo">{{{limite_disponibilidade_persist_limite_saque_periodo_value}}} (optional)</param>
        /// <param name="limiteConsignado">{{{limite_disponibilidade_persist_limite_consignado_value}}} (optional)</param>
        /// <param name="limiteInternacionalCompra">{{{limite_disponibilidade_persist_limite_internacional_compra_value}}} (optional)</param>
        /// <param name="limiteInternacionalParcelado">{{{limite_disponibilidade_persist_limite_internacional_parcelado_value}}} (optional)</param>
        /// <param name="limiteInternacionalParcelas">{{{limite_disponibilidade_persist_limite_internacional_parcelas_value}}} (optional)</param>
        /// <param name="limiteInternacionalSaqueGlobal">{{{limite_disponibilidade_persist_limite_internacional_saque_global_value}}} (optional)</param>
        /// <param name="limiteInternacionalSaquePeriodo">{{{limite_disponibilidade_persist_limite_internacional_saque_periodo_value}}} (optional)</param>
        /// <param name="limiteMaximo">{{{limite_disponibilidade_persist_limite_maximo_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (LimiteDisponibilidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LimiteDisponibilidadeResponse>> AlterarUsingPUT8AsyncWithHttpInfo (long? idConta, double? limiteGlobal = null, double? limiteCompra = null, double? limiteParcelado = null, double? limiteParcelas = null, double? limiteSaqueGlobal = null, double? limiteSaquePeriodo = null, double? limiteConsignado = null, double? limiteInternacionalCompra = null, double? limiteInternacionalParcelado = null, double? limiteInternacionalParcelas = null, double? limiteInternacionalSaqueGlobal = null, double? limiteInternacionalSaquePeriodo = null, double? limiteMaximo = null);
        
        /// <summary>
        /// {{{limite_disponibilidade_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{limite_disponibilidade_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{limite_disponibilidade_resource_consultar_param_id_conta}}}</param>
        /// <returns>Task of LimiteDisponibilidadeResponse</returns>
        System.Threading.Tasks.Task<LimiteDisponibilidadeResponse> ConsultarUsingGET21Async (long? idConta);

        /// <summary>
        /// {{{limite_disponibilidade_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{limite_disponibilidade_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{limite_disponibilidade_resource_consultar_param_id_conta}}}</param>
        /// <returns>Task of ApiResponse (LimiteDisponibilidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LimiteDisponibilidadeResponse>> ConsultarUsingGET21AsyncWithHttpInfo (long? idConta);
        
        /// <summary>
        /// {{{limite_disponibilidade_resource_sensibilizar_credito_disponivel}}}
        /// </summary>
        /// <remarks>
        /// {{{limite_disponibilidade_resource_sensibilizar_credito_disponivel_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{sensibilizar_saldo_global_param_id}}}</param>
        /// <param name="sensibilizarSaldoGlobal">sensibilizarSaldoGlobal</param>
        /// <returns>Task of LimiteDisponibilidadeResponse</returns>
        System.Threading.Tasks.Task<LimiteDisponibilidadeResponse> SensibilizarSaldoDisponivelGlobalUsingPOSTAsync (long? id, SensibilizarSaldoGlobalUpdateValue sensibilizarSaldoGlobal);

        /// <summary>
        /// {{{limite_disponibilidade_resource_sensibilizar_credito_disponivel}}}
        /// </summary>
        /// <remarks>
        /// {{{limite_disponibilidade_resource_sensibilizar_credito_disponivel_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{sensibilizar_saldo_global_param_id}}}</param>
        /// <param name="sensibilizarSaldoGlobal">sensibilizarSaldoGlobal</param>
        /// <returns>Task of ApiResponse (LimiteDisponibilidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LimiteDisponibilidadeResponse>> SensibilizarSaldoDisponivelGlobalUsingPOSTAsyncWithHttpInfo (long? id, SensibilizarSaldoGlobalUpdateValue sensibilizarSaldoGlobal);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltaglimitedisponibilidadeApi : IGlobaltaglimitedisponibilidadeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltaglimitedisponibilidadeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltaglimitedisponibilidadeApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltaglimitedisponibilidadeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltaglimitedisponibilidadeApi(Configuration configuration = null)
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
        /// {{{limite_disponibilidade_resource_alterar}}} {{{limite_disponibilidade_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{limite_disponibilidade_update_id_conta_value}}}</param> 
        /// <param name="limiteGlobal">{{{limite_disponibilidade_persist_limite_global_value}}} (optional)</param> 
        /// <param name="limiteCompra">{{{limite_disponibilidade_persist_limite_compra_value}}} (optional)</param> 
        /// <param name="limiteParcelado">{{{limite_disponibilidade_persist_limite_parcelado_value}}} (optional)</param> 
        /// <param name="limiteParcelas">{{{limite_disponibilidade_persist_limite_parcelas_value}}} (optional)</param> 
        /// <param name="limiteSaqueGlobal">{{{limite_disponibilidade_persist_limite_saque_global_value}}} (optional)</param> 
        /// <param name="limiteSaquePeriodo">{{{limite_disponibilidade_persist_limite_saque_periodo_value}}} (optional)</param> 
        /// <param name="limiteConsignado">{{{limite_disponibilidade_persist_limite_consignado_value}}} (optional)</param> 
        /// <param name="limiteInternacionalCompra">{{{limite_disponibilidade_persist_limite_internacional_compra_value}}} (optional)</param> 
        /// <param name="limiteInternacionalParcelado">{{{limite_disponibilidade_persist_limite_internacional_parcelado_value}}} (optional)</param> 
        /// <param name="limiteInternacionalParcelas">{{{limite_disponibilidade_persist_limite_internacional_parcelas_value}}} (optional)</param> 
        /// <param name="limiteInternacionalSaqueGlobal">{{{limite_disponibilidade_persist_limite_internacional_saque_global_value}}} (optional)</param> 
        /// <param name="limiteInternacionalSaquePeriodo">{{{limite_disponibilidade_persist_limite_internacional_saque_periodo_value}}} (optional)</param> 
        /// <param name="limiteMaximo">{{{limite_disponibilidade_persist_limite_maximo_value}}} (optional)</param> 
        /// <returns>LimiteDisponibilidadeResponse</returns>
        public LimiteDisponibilidadeResponse AlterarUsingPUT8 (long? idConta, double? limiteGlobal = null, double? limiteCompra = null, double? limiteParcelado = null, double? limiteParcelas = null, double? limiteSaqueGlobal = null, double? limiteSaquePeriodo = null, double? limiteConsignado = null, double? limiteInternacionalCompra = null, double? limiteInternacionalParcelado = null, double? limiteInternacionalParcelas = null, double? limiteInternacionalSaqueGlobal = null, double? limiteInternacionalSaquePeriodo = null, double? limiteMaximo = null)
        {
             ApiResponse<LimiteDisponibilidadeResponse> localVarResponse = AlterarUsingPUT8WithHttpInfo(idConta, limiteGlobal, limiteCompra, limiteParcelado, limiteParcelas, limiteSaqueGlobal, limiteSaquePeriodo, limiteConsignado, limiteInternacionalCompra, limiteInternacionalParcelado, limiteInternacionalParcelas, limiteInternacionalSaqueGlobal, limiteInternacionalSaquePeriodo, limiteMaximo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{limite_disponibilidade_resource_alterar}}} {{{limite_disponibilidade_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{limite_disponibilidade_update_id_conta_value}}}</param> 
        /// <param name="limiteGlobal">{{{limite_disponibilidade_persist_limite_global_value}}} (optional)</param> 
        /// <param name="limiteCompra">{{{limite_disponibilidade_persist_limite_compra_value}}} (optional)</param> 
        /// <param name="limiteParcelado">{{{limite_disponibilidade_persist_limite_parcelado_value}}} (optional)</param> 
        /// <param name="limiteParcelas">{{{limite_disponibilidade_persist_limite_parcelas_value}}} (optional)</param> 
        /// <param name="limiteSaqueGlobal">{{{limite_disponibilidade_persist_limite_saque_global_value}}} (optional)</param> 
        /// <param name="limiteSaquePeriodo">{{{limite_disponibilidade_persist_limite_saque_periodo_value}}} (optional)</param> 
        /// <param name="limiteConsignado">{{{limite_disponibilidade_persist_limite_consignado_value}}} (optional)</param> 
        /// <param name="limiteInternacionalCompra">{{{limite_disponibilidade_persist_limite_internacional_compra_value}}} (optional)</param> 
        /// <param name="limiteInternacionalParcelado">{{{limite_disponibilidade_persist_limite_internacional_parcelado_value}}} (optional)</param> 
        /// <param name="limiteInternacionalParcelas">{{{limite_disponibilidade_persist_limite_internacional_parcelas_value}}} (optional)</param> 
        /// <param name="limiteInternacionalSaqueGlobal">{{{limite_disponibilidade_persist_limite_internacional_saque_global_value}}} (optional)</param> 
        /// <param name="limiteInternacionalSaquePeriodo">{{{limite_disponibilidade_persist_limite_internacional_saque_periodo_value}}} (optional)</param> 
        /// <param name="limiteMaximo">{{{limite_disponibilidade_persist_limite_maximo_value}}} (optional)</param> 
        /// <returns>ApiResponse of LimiteDisponibilidadeResponse</returns>
        public ApiResponse< LimiteDisponibilidadeResponse > AlterarUsingPUT8WithHttpInfo (long? idConta, double? limiteGlobal = null, double? limiteCompra = null, double? limiteParcelado = null, double? limiteParcelas = null, double? limiteSaqueGlobal = null, double? limiteSaquePeriodo = null, double? limiteConsignado = null, double? limiteInternacionalCompra = null, double? limiteInternacionalParcelado = null, double? limiteInternacionalParcelas = null, double? limiteInternacionalSaqueGlobal = null, double? limiteInternacionalSaquePeriodo = null, double? limiteMaximo = null)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling GlobaltaglimitedisponibilidadeApi->AlterarUsingPUT8");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT8: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT8: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LimiteDisponibilidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LimiteDisponibilidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimiteDisponibilidadeResponse)));
            
        }

        
        /// <summary>
        /// {{{limite_disponibilidade_resource_alterar}}} {{{limite_disponibilidade_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{limite_disponibilidade_update_id_conta_value}}}</param>
        /// <param name="limiteGlobal">{{{limite_disponibilidade_persist_limite_global_value}}} (optional)</param>
        /// <param name="limiteCompra">{{{limite_disponibilidade_persist_limite_compra_value}}} (optional)</param>
        /// <param name="limiteParcelado">{{{limite_disponibilidade_persist_limite_parcelado_value}}} (optional)</param>
        /// <param name="limiteParcelas">{{{limite_disponibilidade_persist_limite_parcelas_value}}} (optional)</param>
        /// <param name="limiteSaqueGlobal">{{{limite_disponibilidade_persist_limite_saque_global_value}}} (optional)</param>
        /// <param name="limiteSaquePeriodo">{{{limite_disponibilidade_persist_limite_saque_periodo_value}}} (optional)</param>
        /// <param name="limiteConsignado">{{{limite_disponibilidade_persist_limite_consignado_value}}} (optional)</param>
        /// <param name="limiteInternacionalCompra">{{{limite_disponibilidade_persist_limite_internacional_compra_value}}} (optional)</param>
        /// <param name="limiteInternacionalParcelado">{{{limite_disponibilidade_persist_limite_internacional_parcelado_value}}} (optional)</param>
        /// <param name="limiteInternacionalParcelas">{{{limite_disponibilidade_persist_limite_internacional_parcelas_value}}} (optional)</param>
        /// <param name="limiteInternacionalSaqueGlobal">{{{limite_disponibilidade_persist_limite_internacional_saque_global_value}}} (optional)</param>
        /// <param name="limiteInternacionalSaquePeriodo">{{{limite_disponibilidade_persist_limite_internacional_saque_periodo_value}}} (optional)</param>
        /// <param name="limiteMaximo">{{{limite_disponibilidade_persist_limite_maximo_value}}} (optional)</param>
        /// <returns>Task of LimiteDisponibilidadeResponse</returns>
        public async System.Threading.Tasks.Task<LimiteDisponibilidadeResponse> AlterarUsingPUT8Async (long? idConta, double? limiteGlobal = null, double? limiteCompra = null, double? limiteParcelado = null, double? limiteParcelas = null, double? limiteSaqueGlobal = null, double? limiteSaquePeriodo = null, double? limiteConsignado = null, double? limiteInternacionalCompra = null, double? limiteInternacionalParcelado = null, double? limiteInternacionalParcelas = null, double? limiteInternacionalSaqueGlobal = null, double? limiteInternacionalSaquePeriodo = null, double? limiteMaximo = null)
        {
             ApiResponse<LimiteDisponibilidadeResponse> localVarResponse = await AlterarUsingPUT8AsyncWithHttpInfo(idConta, limiteGlobal, limiteCompra, limiteParcelado, limiteParcelas, limiteSaqueGlobal, limiteSaquePeriodo, limiteConsignado, limiteInternacionalCompra, limiteInternacionalParcelado, limiteInternacionalParcelas, limiteInternacionalSaqueGlobal, limiteInternacionalSaquePeriodo, limiteMaximo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{limite_disponibilidade_resource_alterar}}} {{{limite_disponibilidade_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{limite_disponibilidade_update_id_conta_value}}}</param>
        /// <param name="limiteGlobal">{{{limite_disponibilidade_persist_limite_global_value}}} (optional)</param>
        /// <param name="limiteCompra">{{{limite_disponibilidade_persist_limite_compra_value}}} (optional)</param>
        /// <param name="limiteParcelado">{{{limite_disponibilidade_persist_limite_parcelado_value}}} (optional)</param>
        /// <param name="limiteParcelas">{{{limite_disponibilidade_persist_limite_parcelas_value}}} (optional)</param>
        /// <param name="limiteSaqueGlobal">{{{limite_disponibilidade_persist_limite_saque_global_value}}} (optional)</param>
        /// <param name="limiteSaquePeriodo">{{{limite_disponibilidade_persist_limite_saque_periodo_value}}} (optional)</param>
        /// <param name="limiteConsignado">{{{limite_disponibilidade_persist_limite_consignado_value}}} (optional)</param>
        /// <param name="limiteInternacionalCompra">{{{limite_disponibilidade_persist_limite_internacional_compra_value}}} (optional)</param>
        /// <param name="limiteInternacionalParcelado">{{{limite_disponibilidade_persist_limite_internacional_parcelado_value}}} (optional)</param>
        /// <param name="limiteInternacionalParcelas">{{{limite_disponibilidade_persist_limite_internacional_parcelas_value}}} (optional)</param>
        /// <param name="limiteInternacionalSaqueGlobal">{{{limite_disponibilidade_persist_limite_internacional_saque_global_value}}} (optional)</param>
        /// <param name="limiteInternacionalSaquePeriodo">{{{limite_disponibilidade_persist_limite_internacional_saque_periodo_value}}} (optional)</param>
        /// <param name="limiteMaximo">{{{limite_disponibilidade_persist_limite_maximo_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (LimiteDisponibilidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LimiteDisponibilidadeResponse>> AlterarUsingPUT8AsyncWithHttpInfo (long? idConta, double? limiteGlobal = null, double? limiteCompra = null, double? limiteParcelado = null, double? limiteParcelas = null, double? limiteSaqueGlobal = null, double? limiteSaquePeriodo = null, double? limiteConsignado = null, double? limiteInternacionalCompra = null, double? limiteInternacionalParcelado = null, double? limiteInternacionalParcelas = null, double? limiteInternacionalSaqueGlobal = null, double? limiteInternacionalSaquePeriodo = null, double? limiteMaximo = null)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling AlterarUsingPUT8");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT8: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT8: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LimiteDisponibilidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LimiteDisponibilidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimiteDisponibilidadeResponse)));
            
        }
        
        /// <summary>
        /// {{{limite_disponibilidade_resource_consultar}}} {{{limite_disponibilidade_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{limite_disponibilidade_resource_consultar_param_id_conta}}}</param> 
        /// <returns>LimiteDisponibilidadeResponse</returns>
        public LimiteDisponibilidadeResponse ConsultarUsingGET21 (long? idConta)
        {
             ApiResponse<LimiteDisponibilidadeResponse> localVarResponse = ConsultarUsingGET21WithHttpInfo(idConta);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{limite_disponibilidade_resource_consultar}}} {{{limite_disponibilidade_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{limite_disponibilidade_resource_consultar_param_id_conta}}}</param> 
        /// <returns>ApiResponse of LimiteDisponibilidadeResponse</returns>
        public ApiResponse< LimiteDisponibilidadeResponse > ConsultarUsingGET21WithHttpInfo (long? idConta)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling GlobaltaglimitedisponibilidadeApi->ConsultarUsingGET21");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET21: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET21: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LimiteDisponibilidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LimiteDisponibilidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimiteDisponibilidadeResponse)));
            
        }

        
        /// <summary>
        /// {{{limite_disponibilidade_resource_consultar}}} {{{limite_disponibilidade_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{limite_disponibilidade_resource_consultar_param_id_conta}}}</param>
        /// <returns>Task of LimiteDisponibilidadeResponse</returns>
        public async System.Threading.Tasks.Task<LimiteDisponibilidadeResponse> ConsultarUsingGET21Async (long? idConta)
        {
             ApiResponse<LimiteDisponibilidadeResponse> localVarResponse = await ConsultarUsingGET21AsyncWithHttpInfo(idConta);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{limite_disponibilidade_resource_consultar}}} {{{limite_disponibilidade_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{limite_disponibilidade_resource_consultar_param_id_conta}}}</param>
        /// <returns>Task of ApiResponse (LimiteDisponibilidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LimiteDisponibilidadeResponse>> ConsultarUsingGET21AsyncWithHttpInfo (long? idConta)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ConsultarUsingGET21");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET21: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET21: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LimiteDisponibilidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LimiteDisponibilidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimiteDisponibilidadeResponse)));
            
        }
        
        /// <summary>
        /// {{{limite_disponibilidade_resource_sensibilizar_credito_disponivel}}} {{{limite_disponibilidade_resource_sensibilizar_credito_disponivel_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{sensibilizar_saldo_global_param_id}}}</param> 
        /// <param name="sensibilizarSaldoGlobal">sensibilizarSaldoGlobal</param> 
        /// <returns>LimiteDisponibilidadeResponse</returns>
        public LimiteDisponibilidadeResponse SensibilizarSaldoDisponivelGlobalUsingPOST (long? id, SensibilizarSaldoGlobalUpdateValue sensibilizarSaldoGlobal)
        {
             ApiResponse<LimiteDisponibilidadeResponse> localVarResponse = SensibilizarSaldoDisponivelGlobalUsingPOSTWithHttpInfo(id, sensibilizarSaldoGlobal);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{limite_disponibilidade_resource_sensibilizar_credito_disponivel}}} {{{limite_disponibilidade_resource_sensibilizar_credito_disponivel_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{sensibilizar_saldo_global_param_id}}}</param> 
        /// <param name="sensibilizarSaldoGlobal">sensibilizarSaldoGlobal</param> 
        /// <returns>ApiResponse of LimiteDisponibilidadeResponse</returns>
        public ApiResponse< LimiteDisponibilidadeResponse > SensibilizarSaldoDisponivelGlobalUsingPOSTWithHttpInfo (long? id, SensibilizarSaldoGlobalUpdateValue sensibilizarSaldoGlobal)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltaglimitedisponibilidadeApi->SensibilizarSaldoDisponivelGlobalUsingPOST");
            
            // verify the required parameter 'sensibilizarSaldoGlobal' is set
            if (sensibilizarSaldoGlobal == null)
                throw new ApiException(400, "Missing required parameter 'sensibilizarSaldoGlobal' when calling GlobaltaglimitedisponibilidadeApi->SensibilizarSaldoDisponivelGlobalUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SensibilizarSaldoDisponivelGlobalUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SensibilizarSaldoDisponivelGlobalUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LimiteDisponibilidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LimiteDisponibilidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimiteDisponibilidadeResponse)));
            
        }

        
        /// <summary>
        /// {{{limite_disponibilidade_resource_sensibilizar_credito_disponivel}}} {{{limite_disponibilidade_resource_sensibilizar_credito_disponivel_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{sensibilizar_saldo_global_param_id}}}</param>
        /// <param name="sensibilizarSaldoGlobal">sensibilizarSaldoGlobal</param>
        /// <returns>Task of LimiteDisponibilidadeResponse</returns>
        public async System.Threading.Tasks.Task<LimiteDisponibilidadeResponse> SensibilizarSaldoDisponivelGlobalUsingPOSTAsync (long? id, SensibilizarSaldoGlobalUpdateValue sensibilizarSaldoGlobal)
        {
             ApiResponse<LimiteDisponibilidadeResponse> localVarResponse = await SensibilizarSaldoDisponivelGlobalUsingPOSTAsyncWithHttpInfo(id, sensibilizarSaldoGlobal);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{limite_disponibilidade_resource_sensibilizar_credito_disponivel}}} {{{limite_disponibilidade_resource_sensibilizar_credito_disponivel_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{sensibilizar_saldo_global_param_id}}}</param>
        /// <param name="sensibilizarSaldoGlobal">sensibilizarSaldoGlobal</param>
        /// <returns>Task of ApiResponse (LimiteDisponibilidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LimiteDisponibilidadeResponse>> SensibilizarSaldoDisponivelGlobalUsingPOSTAsyncWithHttpInfo (long? id, SensibilizarSaldoGlobalUpdateValue sensibilizarSaldoGlobal)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SensibilizarSaldoDisponivelGlobalUsingPOST");
            // verify the required parameter 'sensibilizarSaldoGlobal' is set
            if (sensibilizarSaldoGlobal == null) throw new ApiException(400, "Missing required parameter 'sensibilizarSaldoGlobal' when calling SensibilizarSaldoDisponivelGlobalUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SensibilizarSaldoDisponivelGlobalUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SensibilizarSaldoDisponivelGlobalUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LimiteDisponibilidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LimiteDisponibilidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimiteDisponibilidadeResponse)));
            
        }
        
    }
    
}
