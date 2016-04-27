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
    public interface ICartaoResponseApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/cancelar
        /// </summary>
        /// <remarks>
        /// Cancelar um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja cancelar</param>
        /// <param name="motivo">Motivo do cancelamento</param>
        /// <param name="observacao">Alguma observa\u00C3\u00A7\u00C3\u00A3o para o cancelamento</param>
        /// <returns>CancelarCartaoResponse</returns>
        CancelarCartaoResponse CancelarCartaoUsingPOST (int? idEmissor, int? idConta, int? idCartao, int? motivo, string observacao);
  
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/cancelar
        /// </summary>
        /// <remarks>
        /// Cancelar um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja cancelar</param>
        /// <param name="motivo">Motivo do cancelamento</param>
        /// <param name="observacao">Alguma observa\u00C3\u00A7\u00C3\u00A3o para o cancelamento</param>
        /// <returns>ApiResponse of CancelarCartaoResponse</returns>
        ApiResponse<CancelarCartaoResponse> CancelarCartaoUsingPOSTWithHttpInfo (int? idEmissor, int? idConta, int? idCartao, int? motivo, string observacao);
        
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}
        /// </summary>
        /// <remarks>
        /// Consultar as informa\u00C3\u00A7\u00C3\u00B5es de um determinado cart\u00C3\u00A3o de uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta que pertence o cart\u00C3\u00A3o</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar</param>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do Cart\u00C3\u00A3o que deseja consultar (opcional) (optional)</param>
        /// <returns>ConsultarCartaoResponse</returns>
        ConsultarCartaoResponse ConsultarCartaoUsingGET (int? idEmissor, int? idConta, int? idCartao, string numeroCartao = null);
  
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}
        /// </summary>
        /// <remarks>
        /// Consultar as informa\u00C3\u00A7\u00C3\u00B5es de um determinado cart\u00C3\u00A3o de uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta que pertence o cart\u00C3\u00A3o</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar</param>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do Cart\u00C3\u00A3o que deseja consultar (opcional) (optional)</param>
        /// <returns>ApiResponse of ConsultarCartaoResponse</returns>
        ApiResponse<ConsultarCartaoResponse> ConsultarCartaoUsingGETWithHttpInfo (int? idEmissor, int? idConta, int? idCartao, string numeroCartao = null);
        
        /// <summary>
        /// /contas/{idConta}/cartoes
        /// </summary>
        /// <remarks>
        /// Consultar todos os cart\u00C3\u00B5es de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>ConsultarCartaoResponse</returns>
        ConsultarCartaoResponse ConsultarCartoesUsingGET (int? idEmissor, int? idConta);
  
        /// <summary>
        /// /contas/{idConta}/cartoes
        /// </summary>
        /// <remarks>
        /// Consultar todos os cart\u00C3\u00B5es de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>ApiResponse of ConsultarCartaoResponse</returns>
        ApiResponse<ConsultarCartaoResponse> ConsultarCartoesUsingGETWithHttpInfo (int? idEmissor, int? idConta);
        
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/faturas
        /// </summary>
        /// <remarks>
        /// Consulte os extratos/faturas do cart\u00C3\u00A3o de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar o extrato</param>
        /// <param name="dataVencimento">Data limite para o vencimento das transa\u00C3\u00A7\u00C3\u00B5es</param>
        /// <returns>ConsultarExtratoContaResponse</returns>
        ConsultarExtratoContaResponse ConsultarExtratoFaturasUsingGET (int? idEmissor, int? idConta, int? idCartao, string dataVencimento);
  
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/faturas
        /// </summary>
        /// <remarks>
        /// Consulte os extratos/faturas do cart\u00C3\u00A3o de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar o extrato</param>
        /// <param name="dataVencimento">Data limite para o vencimento das transa\u00C3\u00A7\u00C3\u00B5es</param>
        /// <returns>ApiResponse of ConsultarExtratoContaResponse</returns>
        ApiResponse<ConsultarExtratoContaResponse> ConsultarExtratoFaturasUsingGETWithHttpInfo (int? idEmissor, int? idConta, int? idCartao, string dataVencimento);
        
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/limites
        /// </summary>
        /// <remarks>
        /// Consulte os limites de um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar o saldo/limite</param>
        /// <returns>ConsultarSaldoLimitesResponse</returns>
        ConsultarSaldoLimitesResponse ConsultarSaldosLimitesUsingGET (int? idEmissor, int? idConta, int? idCartao);
  
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/limites
        /// </summary>
        /// <remarks>
        /// Consulte os limites de um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar o saldo/limite</param>
        /// <returns>ApiResponse of ConsultarSaldoLimitesResponse</returns>
        ApiResponse<ConsultarSaldoLimitesResponse> ConsultarSaldosLimitesUsingGETWithHttpInfo (int? idEmissor, int? idConta, int? idCartao);
        
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/desbloquear
        /// </summary>
        /// <remarks>
        /// Desbloquear cart\u00C3\u00A3o de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar o saldo/limite</param>
        /// <param name="codigoSegurancao">C\u00C3\u00B3digo seguran\u00C3\u00A7a do cart\u00C3\u00A3o</param>
        /// <returns>DesbloquearCartaoResponse</returns>
        DesbloquearCartaoResponse DesbloquearCartaoUsingPOST (int? idEmissor, int? idConta, int? idCartao, string codigoSegurancao);
  
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/desbloquear
        /// </summary>
        /// <remarks>
        /// Desbloquear cart\u00C3\u00A3o de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar o saldo/limite</param>
        /// <param name="codigoSegurancao">C\u00C3\u00B3digo seguran\u00C3\u00A7a do cart\u00C3\u00A3o</param>
        /// <returns>ApiResponse of DesbloquearCartaoResponse</returns>
        ApiResponse<DesbloquearCartaoResponse> DesbloquearCartaoUsingPOSTWithHttpInfo (int? idEmissor, int? idConta, int? idCartao, string codigoSegurancao);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/cancelar
        /// </summary>
        /// <remarks>
        /// Cancelar um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja cancelar</param>
        /// <param name="motivo">Motivo do cancelamento</param>
        /// <param name="observacao">Alguma observa\u00C3\u00A7\u00C3\u00A3o para o cancelamento</param>
        /// <returns>Task of CancelarCartaoResponse</returns>
        System.Threading.Tasks.Task<CancelarCartaoResponse> CancelarCartaoUsingPOSTAsync (int? idEmissor, int? idConta, int? idCartao, int? motivo, string observacao);

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/cancelar
        /// </summary>
        /// <remarks>
        /// Cancelar um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja cancelar</param>
        /// <param name="motivo">Motivo do cancelamento</param>
        /// <param name="observacao">Alguma observa\u00C3\u00A7\u00C3\u00A3o para o cancelamento</param>
        /// <returns>Task of ApiResponse (CancelarCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CancelarCartaoResponse>> CancelarCartaoUsingPOSTAsyncWithHttpInfo (int? idEmissor, int? idConta, int? idCartao, int? motivo, string observacao);
        
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}
        /// </summary>
        /// <remarks>
        /// Consultar as informa\u00C3\u00A7\u00C3\u00B5es de um determinado cart\u00C3\u00A3o de uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta que pertence o cart\u00C3\u00A3o</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar</param>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do Cart\u00C3\u00A3o que deseja consultar (opcional) (optional)</param>
        /// <returns>Task of ConsultarCartaoResponse</returns>
        System.Threading.Tasks.Task<ConsultarCartaoResponse> ConsultarCartaoUsingGETAsync (int? idEmissor, int? idConta, int? idCartao, string numeroCartao = null);

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}
        /// </summary>
        /// <remarks>
        /// Consultar as informa\u00C3\u00A7\u00C3\u00B5es de um determinado cart\u00C3\u00A3o de uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta que pertence o cart\u00C3\u00A3o</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar</param>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do Cart\u00C3\u00A3o que deseja consultar (opcional) (optional)</param>
        /// <returns>Task of ApiResponse (ConsultarCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConsultarCartaoResponse>> ConsultarCartaoUsingGETAsyncWithHttpInfo (int? idEmissor, int? idConta, int? idCartao, string numeroCartao = null);
        
        /// <summary>
        /// /contas/{idConta}/cartoes
        /// </summary>
        /// <remarks>
        /// Consultar todos os cart\u00C3\u00B5es de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>Task of ConsultarCartaoResponse</returns>
        System.Threading.Tasks.Task<ConsultarCartaoResponse> ConsultarCartoesUsingGETAsync (int? idEmissor, int? idConta);

        /// <summary>
        /// /contas/{idConta}/cartoes
        /// </summary>
        /// <remarks>
        /// Consultar todos os cart\u00C3\u00B5es de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>Task of ApiResponse (ConsultarCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConsultarCartaoResponse>> ConsultarCartoesUsingGETAsyncWithHttpInfo (int? idEmissor, int? idConta);
        
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/faturas
        /// </summary>
        /// <remarks>
        /// Consulte os extratos/faturas do cart\u00C3\u00A3o de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar o extrato</param>
        /// <param name="dataVencimento">Data limite para o vencimento das transa\u00C3\u00A7\u00C3\u00B5es</param>
        /// <returns>Task of ConsultarExtratoContaResponse</returns>
        System.Threading.Tasks.Task<ConsultarExtratoContaResponse> ConsultarExtratoFaturasUsingGETAsync (int? idEmissor, int? idConta, int? idCartao, string dataVencimento);

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/faturas
        /// </summary>
        /// <remarks>
        /// Consulte os extratos/faturas do cart\u00C3\u00A3o de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar o extrato</param>
        /// <param name="dataVencimento">Data limite para o vencimento das transa\u00C3\u00A7\u00C3\u00B5es</param>
        /// <returns>Task of ApiResponse (ConsultarExtratoContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConsultarExtratoContaResponse>> ConsultarExtratoFaturasUsingGETAsyncWithHttpInfo (int? idEmissor, int? idConta, int? idCartao, string dataVencimento);
        
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/limites
        /// </summary>
        /// <remarks>
        /// Consulte os limites de um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar o saldo/limite</param>
        /// <returns>Task of ConsultarSaldoLimitesResponse</returns>
        System.Threading.Tasks.Task<ConsultarSaldoLimitesResponse> ConsultarSaldosLimitesUsingGETAsync (int? idEmissor, int? idConta, int? idCartao);

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/limites
        /// </summary>
        /// <remarks>
        /// Consulte os limites de um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar o saldo/limite</param>
        /// <returns>Task of ApiResponse (ConsultarSaldoLimitesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConsultarSaldoLimitesResponse>> ConsultarSaldosLimitesUsingGETAsyncWithHttpInfo (int? idEmissor, int? idConta, int? idCartao);
        
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/desbloquear
        /// </summary>
        /// <remarks>
        /// Desbloquear cart\u00C3\u00A3o de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar o saldo/limite</param>
        /// <param name="codigoSegurancao">C\u00C3\u00B3digo seguran\u00C3\u00A7a do cart\u00C3\u00A3o</param>
        /// <returns>Task of DesbloquearCartaoResponse</returns>
        System.Threading.Tasks.Task<DesbloquearCartaoResponse> DesbloquearCartaoUsingPOSTAsync (int? idEmissor, int? idConta, int? idCartao, string codigoSegurancao);

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/desbloquear
        /// </summary>
        /// <remarks>
        /// Desbloquear cart\u00C3\u00A3o de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar o saldo/limite</param>
        /// <param name="codigoSegurancao">C\u00C3\u00B3digo seguran\u00C3\u00A7a do cart\u00C3\u00A3o</param>
        /// <returns>Task of ApiResponse (DesbloquearCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DesbloquearCartaoResponse>> DesbloquearCartaoUsingPOSTAsyncWithHttpInfo (int? idEmissor, int? idConta, int? idCartao, string codigoSegurancao);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CartaoResponseApi : ICartaoResponseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoResponseApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CartaoResponseApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoResponseApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CartaoResponseApi(Configuration configuration = null)
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
        /// /contas/{idConta}/cartoes/{idCartao}/cancelar Cancelar um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param> 
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja cancelar</param> 
        /// <param name="motivo">Motivo do cancelamento</param> 
        /// <param name="observacao">Alguma observa\u00C3\u00A7\u00C3\u00A3o para o cancelamento</param> 
        /// <returns>CancelarCartaoResponse</returns>
        public CancelarCartaoResponse CancelarCartaoUsingPOST (int? idEmissor, int? idConta, int? idCartao, int? motivo, string observacao)
        {
             ApiResponse<CancelarCartaoResponse> localVarResponse = CancelarCartaoUsingPOSTWithHttpInfo(idEmissor, idConta, idCartao, motivo, observacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/cancelar Cancelar um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param> 
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja cancelar</param> 
        /// <param name="motivo">Motivo do cancelamento</param> 
        /// <param name="observacao">Alguma observa\u00C3\u00A7\u00C3\u00A3o para o cancelamento</param> 
        /// <returns>ApiResponse of CancelarCartaoResponse</returns>
        public ApiResponse< CancelarCartaoResponse > CancelarCartaoUsingPOSTWithHttpInfo (int? idEmissor, int? idConta, int? idCartao, int? motivo, string observacao)
        {
            
            // verify the required parameter 'idEmissor' is set
            if (idEmissor == null)
                throw new ApiException(400, "Missing required parameter 'idEmissor' when calling CartaoResponseApi->CancelarCartaoUsingPOST");
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling CartaoResponseApi->CancelarCartaoUsingPOST");
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling CartaoResponseApi->CancelarCartaoUsingPOST");
            
            // verify the required parameter 'motivo' is set
            if (motivo == null)
                throw new ApiException(400, "Missing required parameter 'motivo' when calling CartaoResponseApi->CancelarCartaoUsingPOST");
            
            // verify the required parameter 'observacao' is set
            if (observacao == null)
                throw new ApiException(400, "Missing required parameter 'observacao' when calling CartaoResponseApi->CancelarCartaoUsingPOST");
            
    
            var localVarPath = "/api/v1/contas/{idConta}/cartoes/{idCartao}/cancelar";
    
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
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            if (motivo != null) localVarQueryParams.Add("motivo", Configuration.ApiClient.ParameterToString(motivo)); // query parameter
            if (observacao != null) localVarQueryParams.Add("observacao", Configuration.ApiClient.ParameterToString(observacao)); // query parameter
            
            if (idEmissor != null) localVarHeaderParams.Add("idEmissor", Configuration.ApiClient.ParameterToString(idEmissor)); // header parameter
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling CancelarCartaoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarCartaoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CancelarCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CancelarCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CancelarCartaoResponse)));
            
        }

        
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/cancelar Cancelar um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja cancelar</param>
        /// <param name="motivo">Motivo do cancelamento</param>
        /// <param name="observacao">Alguma observa\u00C3\u00A7\u00C3\u00A3o para o cancelamento</param>
        /// <returns>Task of CancelarCartaoResponse</returns>
        public async System.Threading.Tasks.Task<CancelarCartaoResponse> CancelarCartaoUsingPOSTAsync (int? idEmissor, int? idConta, int? idCartao, int? motivo, string observacao)
        {
             ApiResponse<CancelarCartaoResponse> localVarResponse = await CancelarCartaoUsingPOSTAsyncWithHttpInfo(idEmissor, idConta, idCartao, motivo, observacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/cancelar Cancelar um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja cancelar</param>
        /// <param name="motivo">Motivo do cancelamento</param>
        /// <param name="observacao">Alguma observa\u00C3\u00A7\u00C3\u00A3o para o cancelamento</param>
        /// <returns>Task of ApiResponse (CancelarCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CancelarCartaoResponse>> CancelarCartaoUsingPOSTAsyncWithHttpInfo (int? idEmissor, int? idConta, int? idCartao, int? motivo, string observacao)
        {
            // verify the required parameter 'idEmissor' is set
            if (idEmissor == null) throw new ApiException(400, "Missing required parameter 'idEmissor' when calling CancelarCartaoUsingPOST");
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling CancelarCartaoUsingPOST");
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling CancelarCartaoUsingPOST");
            // verify the required parameter 'motivo' is set
            if (motivo == null) throw new ApiException(400, "Missing required parameter 'motivo' when calling CancelarCartaoUsingPOST");
            // verify the required parameter 'observacao' is set
            if (observacao == null) throw new ApiException(400, "Missing required parameter 'observacao' when calling CancelarCartaoUsingPOST");
            
    
            var localVarPath = "/api/v1/contas/{idConta}/cartoes/{idCartao}/cancelar";
    
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
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            if (motivo != null) localVarQueryParams.Add("motivo", Configuration.ApiClient.ParameterToString(motivo)); // query parameter
            if (observacao != null) localVarQueryParams.Add("observacao", Configuration.ApiClient.ParameterToString(observacao)); // query parameter
            
            if (idEmissor != null) localVarHeaderParams.Add("idEmissor", Configuration.ApiClient.ParameterToString(idEmissor)); // header parameter
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling CancelarCartaoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarCartaoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CancelarCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CancelarCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CancelarCartaoResponse)));
            
        }
        
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao} Consultar as informa\u00C3\u00A7\u00C3\u00B5es de um determinado cart\u00C3\u00A3o de uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param> 
        /// <param name="idConta">ID da Conta que pertence o cart\u00C3\u00A3o</param> 
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar</param> 
        /// <param name="numeroCartao">N\u00C3\u00BAmero do Cart\u00C3\u00A3o que deseja consultar (opcional) (optional)</param> 
        /// <returns>ConsultarCartaoResponse</returns>
        public ConsultarCartaoResponse ConsultarCartaoUsingGET (int? idEmissor, int? idConta, int? idCartao, string numeroCartao = null)
        {
             ApiResponse<ConsultarCartaoResponse> localVarResponse = ConsultarCartaoUsingGETWithHttpInfo(idEmissor, idConta, idCartao, numeroCartao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao} Consultar as informa\u00C3\u00A7\u00C3\u00B5es de um determinado cart\u00C3\u00A3o de uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param> 
        /// <param name="idConta">ID da Conta que pertence o cart\u00C3\u00A3o</param> 
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar</param> 
        /// <param name="numeroCartao">N\u00C3\u00BAmero do Cart\u00C3\u00A3o que deseja consultar (opcional) (optional)</param> 
        /// <returns>ApiResponse of ConsultarCartaoResponse</returns>
        public ApiResponse< ConsultarCartaoResponse > ConsultarCartaoUsingGETWithHttpInfo (int? idEmissor, int? idConta, int? idCartao, string numeroCartao = null)
        {
            
            // verify the required parameter 'idEmissor' is set
            if (idEmissor == null)
                throw new ApiException(400, "Missing required parameter 'idEmissor' when calling CartaoResponseApi->ConsultarCartaoUsingGET");
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling CartaoResponseApi->ConsultarCartaoUsingGET");
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling CartaoResponseApi->ConsultarCartaoUsingGET");
            
    
            var localVarPath = "/api/v1/contas/{idConta}/cartoes/{idCartao}";
    
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
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            if (idEmissor != null) localVarHeaderParams.Add("idEmissor", Configuration.ApiClient.ParameterToString(idEmissor)); // header parameter
            if (numeroCartao != null) localVarHeaderParams.Add("numeroCartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // header parameter
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCartaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCartaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConsultarCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultarCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultarCartaoResponse)));
            
        }

        
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao} Consultar as informa\u00C3\u00A7\u00C3\u00B5es de um determinado cart\u00C3\u00A3o de uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta que pertence o cart\u00C3\u00A3o</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar</param>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do Cart\u00C3\u00A3o que deseja consultar (opcional) (optional)</param>
        /// <returns>Task of ConsultarCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ConsultarCartaoResponse> ConsultarCartaoUsingGETAsync (int? idEmissor, int? idConta, int? idCartao, string numeroCartao = null)
        {
             ApiResponse<ConsultarCartaoResponse> localVarResponse = await ConsultarCartaoUsingGETAsyncWithHttpInfo(idEmissor, idConta, idCartao, numeroCartao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao} Consultar as informa\u00C3\u00A7\u00C3\u00B5es de um determinado cart\u00C3\u00A3o de uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta que pertence o cart\u00C3\u00A3o</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar</param>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do Cart\u00C3\u00A3o que deseja consultar (opcional) (optional)</param>
        /// <returns>Task of ApiResponse (ConsultarCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConsultarCartaoResponse>> ConsultarCartaoUsingGETAsyncWithHttpInfo (int? idEmissor, int? idConta, int? idCartao, string numeroCartao = null)
        {
            // verify the required parameter 'idEmissor' is set
            if (idEmissor == null) throw new ApiException(400, "Missing required parameter 'idEmissor' when calling ConsultarCartaoUsingGET");
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ConsultarCartaoUsingGET");
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling ConsultarCartaoUsingGET");
            
    
            var localVarPath = "/api/v1/contas/{idConta}/cartoes/{idCartao}";
    
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
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            if (idEmissor != null) localVarHeaderParams.Add("idEmissor", Configuration.ApiClient.ParameterToString(idEmissor)); // header parameter
            if (numeroCartao != null) localVarHeaderParams.Add("numeroCartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // header parameter
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCartaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCartaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConsultarCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultarCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultarCartaoResponse)));
            
        }
        
        /// <summary>
        /// /contas/{idConta}/cartoes Consultar todos os cart\u00C3\u00B5es de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param> 
        /// <param name="idConta">ID da Conta</param> 
        /// <returns>ConsultarCartaoResponse</returns>
        public ConsultarCartaoResponse ConsultarCartoesUsingGET (int? idEmissor, int? idConta)
        {
             ApiResponse<ConsultarCartaoResponse> localVarResponse = ConsultarCartoesUsingGETWithHttpInfo(idEmissor, idConta);
             return localVarResponse.Data;
        }

        /// <summary>
        /// /contas/{idConta}/cartoes Consultar todos os cart\u00C3\u00B5es de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param> 
        /// <param name="idConta">ID da Conta</param> 
        /// <returns>ApiResponse of ConsultarCartaoResponse</returns>
        public ApiResponse< ConsultarCartaoResponse > ConsultarCartoesUsingGETWithHttpInfo (int? idEmissor, int? idConta)
        {
            
            // verify the required parameter 'idEmissor' is set
            if (idEmissor == null)
                throw new ApiException(400, "Missing required parameter 'idEmissor' when calling CartaoResponseApi->ConsultarCartoesUsingGET");
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling CartaoResponseApi->ConsultarCartoesUsingGET");
            
    
            var localVarPath = "/api/v1/contas/{idConta}/cartoes";
    
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
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            
            
            if (idEmissor != null) localVarHeaderParams.Add("idEmissor", Configuration.ApiClient.ParameterToString(idEmissor)); // header parameter
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCartoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCartoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConsultarCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultarCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultarCartaoResponse)));
            
        }

        
        /// <summary>
        /// /contas/{idConta}/cartoes Consultar todos os cart\u00C3\u00B5es de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>Task of ConsultarCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ConsultarCartaoResponse> ConsultarCartoesUsingGETAsync (int? idEmissor, int? idConta)
        {
             ApiResponse<ConsultarCartaoResponse> localVarResponse = await ConsultarCartoesUsingGETAsyncWithHttpInfo(idEmissor, idConta);
             return localVarResponse.Data;

        }

        /// <summary>
        /// /contas/{idConta}/cartoes Consultar todos os cart\u00C3\u00B5es de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>Task of ApiResponse (ConsultarCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConsultarCartaoResponse>> ConsultarCartoesUsingGETAsyncWithHttpInfo (int? idEmissor, int? idConta)
        {
            // verify the required parameter 'idEmissor' is set
            if (idEmissor == null) throw new ApiException(400, "Missing required parameter 'idEmissor' when calling ConsultarCartoesUsingGET");
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ConsultarCartoesUsingGET");
            
    
            var localVarPath = "/api/v1/contas/{idConta}/cartoes";
    
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
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            
            
            if (idEmissor != null) localVarHeaderParams.Add("idEmissor", Configuration.ApiClient.ParameterToString(idEmissor)); // header parameter
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCartoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCartoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConsultarCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultarCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultarCartaoResponse)));
            
        }
        
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/faturas Consulte os extratos/faturas do cart\u00C3\u00A3o de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param> 
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar o extrato</param> 
        /// <param name="dataVencimento">Data limite para o vencimento das transa\u00C3\u00A7\u00C3\u00B5es</param> 
        /// <returns>ConsultarExtratoContaResponse</returns>
        public ConsultarExtratoContaResponse ConsultarExtratoFaturasUsingGET (int? idEmissor, int? idConta, int? idCartao, string dataVencimento)
        {
             ApiResponse<ConsultarExtratoContaResponse> localVarResponse = ConsultarExtratoFaturasUsingGETWithHttpInfo(idEmissor, idConta, idCartao, dataVencimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/faturas Consulte os extratos/faturas do cart\u00C3\u00A3o de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param> 
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar o extrato</param> 
        /// <param name="dataVencimento">Data limite para o vencimento das transa\u00C3\u00A7\u00C3\u00B5es</param> 
        /// <returns>ApiResponse of ConsultarExtratoContaResponse</returns>
        public ApiResponse< ConsultarExtratoContaResponse > ConsultarExtratoFaturasUsingGETWithHttpInfo (int? idEmissor, int? idConta, int? idCartao, string dataVencimento)
        {
            
            // verify the required parameter 'idEmissor' is set
            if (idEmissor == null)
                throw new ApiException(400, "Missing required parameter 'idEmissor' when calling CartaoResponseApi->ConsultarExtratoFaturasUsingGET");
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling CartaoResponseApi->ConsultarExtratoFaturasUsingGET");
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling CartaoResponseApi->ConsultarExtratoFaturasUsingGET");
            
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null)
                throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling CartaoResponseApi->ConsultarExtratoFaturasUsingGET");
            
    
            var localVarPath = "/api/v1/contas/{idConta}/cartoes/{idCartao}/faturas";
    
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
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            
            if (idEmissor != null) localVarHeaderParams.Add("idEmissor", Configuration.ApiClient.ParameterToString(idEmissor)); // header parameter
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarExtratoFaturasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarExtratoFaturasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConsultarExtratoContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultarExtratoContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultarExtratoContaResponse)));
            
        }

        
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/faturas Consulte os extratos/faturas do cart\u00C3\u00A3o de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar o extrato</param>
        /// <param name="dataVencimento">Data limite para o vencimento das transa\u00C3\u00A7\u00C3\u00B5es</param>
        /// <returns>Task of ConsultarExtratoContaResponse</returns>
        public async System.Threading.Tasks.Task<ConsultarExtratoContaResponse> ConsultarExtratoFaturasUsingGETAsync (int? idEmissor, int? idConta, int? idCartao, string dataVencimento)
        {
             ApiResponse<ConsultarExtratoContaResponse> localVarResponse = await ConsultarExtratoFaturasUsingGETAsyncWithHttpInfo(idEmissor, idConta, idCartao, dataVencimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/faturas Consulte os extratos/faturas do cart\u00C3\u00A3o de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar o extrato</param>
        /// <param name="dataVencimento">Data limite para o vencimento das transa\u00C3\u00A7\u00C3\u00B5es</param>
        /// <returns>Task of ApiResponse (ConsultarExtratoContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConsultarExtratoContaResponse>> ConsultarExtratoFaturasUsingGETAsyncWithHttpInfo (int? idEmissor, int? idConta, int? idCartao, string dataVencimento)
        {
            // verify the required parameter 'idEmissor' is set
            if (idEmissor == null) throw new ApiException(400, "Missing required parameter 'idEmissor' when calling ConsultarExtratoFaturasUsingGET");
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ConsultarExtratoFaturasUsingGET");
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling ConsultarExtratoFaturasUsingGET");
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null) throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling ConsultarExtratoFaturasUsingGET");
            
    
            var localVarPath = "/api/v1/contas/{idConta}/cartoes/{idCartao}/faturas";
    
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
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            
            if (idEmissor != null) localVarHeaderParams.Add("idEmissor", Configuration.ApiClient.ParameterToString(idEmissor)); // header parameter
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarExtratoFaturasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarExtratoFaturasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConsultarExtratoContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultarExtratoContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultarExtratoContaResponse)));
            
        }
        
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/limites Consulte os limites de um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param> 
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar o saldo/limite</param> 
        /// <returns>ConsultarSaldoLimitesResponse</returns>
        public ConsultarSaldoLimitesResponse ConsultarSaldosLimitesUsingGET (int? idEmissor, int? idConta, int? idCartao)
        {
             ApiResponse<ConsultarSaldoLimitesResponse> localVarResponse = ConsultarSaldosLimitesUsingGETWithHttpInfo(idEmissor, idConta, idCartao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/limites Consulte os limites de um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param> 
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar o saldo/limite</param> 
        /// <returns>ApiResponse of ConsultarSaldoLimitesResponse</returns>
        public ApiResponse< ConsultarSaldoLimitesResponse > ConsultarSaldosLimitesUsingGETWithHttpInfo (int? idEmissor, int? idConta, int? idCartao)
        {
            
            // verify the required parameter 'idEmissor' is set
            if (idEmissor == null)
                throw new ApiException(400, "Missing required parameter 'idEmissor' when calling CartaoResponseApi->ConsultarSaldosLimitesUsingGET");
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling CartaoResponseApi->ConsultarSaldosLimitesUsingGET");
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling CartaoResponseApi->ConsultarSaldosLimitesUsingGET");
            
    
            var localVarPath = "/api/v1/contas/{idConta}/cartoes/{idCartao}/limites";
    
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
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            if (idEmissor != null) localVarHeaderParams.Add("idEmissor", Configuration.ApiClient.ParameterToString(idEmissor)); // header parameter
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarSaldosLimitesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarSaldosLimitesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConsultarSaldoLimitesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultarSaldoLimitesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultarSaldoLimitesResponse)));
            
        }

        
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/limites Consulte os limites de um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar o saldo/limite</param>
        /// <returns>Task of ConsultarSaldoLimitesResponse</returns>
        public async System.Threading.Tasks.Task<ConsultarSaldoLimitesResponse> ConsultarSaldosLimitesUsingGETAsync (int? idEmissor, int? idConta, int? idCartao)
        {
             ApiResponse<ConsultarSaldoLimitesResponse> localVarResponse = await ConsultarSaldosLimitesUsingGETAsyncWithHttpInfo(idEmissor, idConta, idCartao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/limites Consulte os limites de um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar o saldo/limite</param>
        /// <returns>Task of ApiResponse (ConsultarSaldoLimitesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConsultarSaldoLimitesResponse>> ConsultarSaldosLimitesUsingGETAsyncWithHttpInfo (int? idEmissor, int? idConta, int? idCartao)
        {
            // verify the required parameter 'idEmissor' is set
            if (idEmissor == null) throw new ApiException(400, "Missing required parameter 'idEmissor' when calling ConsultarSaldosLimitesUsingGET");
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ConsultarSaldosLimitesUsingGET");
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling ConsultarSaldosLimitesUsingGET");
            
    
            var localVarPath = "/api/v1/contas/{idConta}/cartoes/{idCartao}/limites";
    
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
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            if (idEmissor != null) localVarHeaderParams.Add("idEmissor", Configuration.ApiClient.ParameterToString(idEmissor)); // header parameter
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarSaldosLimitesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarSaldosLimitesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConsultarSaldoLimitesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultarSaldoLimitesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultarSaldoLimitesResponse)));
            
        }
        
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/desbloquear Desbloquear cart\u00C3\u00A3o de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param> 
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar o saldo/limite</param> 
        /// <param name="codigoSegurancao">C\u00C3\u00B3digo seguran\u00C3\u00A7a do cart\u00C3\u00A3o</param> 
        /// <returns>DesbloquearCartaoResponse</returns>
        public DesbloquearCartaoResponse DesbloquearCartaoUsingPOST (int? idEmissor, int? idConta, int? idCartao, string codigoSegurancao)
        {
             ApiResponse<DesbloquearCartaoResponse> localVarResponse = DesbloquearCartaoUsingPOSTWithHttpInfo(idEmissor, idConta, idCartao, codigoSegurancao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/desbloquear Desbloquear cart\u00C3\u00A3o de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param> 
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar o saldo/limite</param> 
        /// <param name="codigoSegurancao">C\u00C3\u00B3digo seguran\u00C3\u00A7a do cart\u00C3\u00A3o</param> 
        /// <returns>ApiResponse of DesbloquearCartaoResponse</returns>
        public ApiResponse< DesbloquearCartaoResponse > DesbloquearCartaoUsingPOSTWithHttpInfo (int? idEmissor, int? idConta, int? idCartao, string codigoSegurancao)
        {
            
            // verify the required parameter 'idEmissor' is set
            if (idEmissor == null)
                throw new ApiException(400, "Missing required parameter 'idEmissor' when calling CartaoResponseApi->DesbloquearCartaoUsingPOST");
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling CartaoResponseApi->DesbloquearCartaoUsingPOST");
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling CartaoResponseApi->DesbloquearCartaoUsingPOST");
            
            // verify the required parameter 'codigoSegurancao' is set
            if (codigoSegurancao == null)
                throw new ApiException(400, "Missing required parameter 'codigoSegurancao' when calling CartaoResponseApi->DesbloquearCartaoUsingPOST");
            
    
            var localVarPath = "/api/v1/contas/{idConta}/cartoes/{idCartao}/desbloquear";
    
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
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            if (idEmissor != null) localVarHeaderParams.Add("idEmissor", Configuration.ApiClient.ParameterToString(idEmissor)); // header parameter
            if (codigoSegurancao != null) localVarHeaderParams.Add("codigoSegurancao", Configuration.ApiClient.ParameterToString(codigoSegurancao)); // header parameter
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearCartaoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearCartaoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DesbloquearCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DesbloquearCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DesbloquearCartaoResponse)));
            
        }

        
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/desbloquear Desbloquear cart\u00C3\u00A3o de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar o saldo/limite</param>
        /// <param name="codigoSegurancao">C\u00C3\u00B3digo seguran\u00C3\u00A7a do cart\u00C3\u00A3o</param>
        /// <returns>Task of DesbloquearCartaoResponse</returns>
        public async System.Threading.Tasks.Task<DesbloquearCartaoResponse> DesbloquearCartaoUsingPOSTAsync (int? idEmissor, int? idConta, int? idCartao, string codigoSegurancao)
        {
             ApiResponse<DesbloquearCartaoResponse> localVarResponse = await DesbloquearCartaoUsingPOSTAsyncWithHttpInfo(idEmissor, idConta, idCartao, codigoSegurancao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/desbloquear Desbloquear cart\u00C3\u00A3o de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar o saldo/limite</param>
        /// <param name="codigoSegurancao">C\u00C3\u00B3digo seguran\u00C3\u00A7a do cart\u00C3\u00A3o</param>
        /// <returns>Task of ApiResponse (DesbloquearCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DesbloquearCartaoResponse>> DesbloquearCartaoUsingPOSTAsyncWithHttpInfo (int? idEmissor, int? idConta, int? idCartao, string codigoSegurancao)
        {
            // verify the required parameter 'idEmissor' is set
            if (idEmissor == null) throw new ApiException(400, "Missing required parameter 'idEmissor' when calling DesbloquearCartaoUsingPOST");
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling DesbloquearCartaoUsingPOST");
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling DesbloquearCartaoUsingPOST");
            // verify the required parameter 'codigoSegurancao' is set
            if (codigoSegurancao == null) throw new ApiException(400, "Missing required parameter 'codigoSegurancao' when calling DesbloquearCartaoUsingPOST");
            
    
            var localVarPath = "/api/v1/contas/{idConta}/cartoes/{idCartao}/desbloquear";
    
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
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            if (idEmissor != null) localVarHeaderParams.Add("idEmissor", Configuration.ApiClient.ParameterToString(idEmissor)); // header parameter
            if (codigoSegurancao != null) localVarHeaderParams.Add("codigoSegurancao", Configuration.ApiClient.ParameterToString(codigoSegurancao)); // header parameter
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearCartaoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearCartaoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DesbloquearCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DesbloquearCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DesbloquearCartaoResponse)));
            
        }
        
    }
    
}
