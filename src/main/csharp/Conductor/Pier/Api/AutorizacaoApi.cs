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
    public interface IAutorizacaoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira pelo numero do cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o numero do cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autorizacaoOnUsRequest">autorizacaoOnUsRequest</param>
        /// <returns>TransacaoOnUsResponse</returns>
        TransacaoOnUsResponse Autorizar (AutorizacaoOnUsRequest autorizacaoOnUsRequest);
  
        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira pelo numero do cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o numero do cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autorizacaoOnUsRequest">autorizacaoOnUsRequest</param>
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        ApiResponse<TransacaoOnUsResponse> AutorizarWithHttpInfo (AutorizacaoOnUsRequest autorizacaoOnUsRequest);
        
        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira por idConta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o idConta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param>
        /// <returns>TransacaoOnUsResponse</returns>
        TransacaoOnUsResponse AutorizarPorConta (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest);
  
        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira por idConta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o idConta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param>
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        ApiResponse<TransacaoOnUsResponse> AutorizarPorContaWithHttpInfo (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest);
        
        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira pelo idCartao
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o idCartao
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param>
        /// <returns>TransacaoOnUsResponse</returns>
        TransacaoOnUsResponse Autorizar_0 (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest);
  
        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira pelo idCartao
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o idCartao
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param>
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        ApiResponse<TransacaoOnUsResponse> Autorizar_0WithHttpInfo (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest);
        
        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>TransacaoOnUsResponse</returns>
        TransacaoOnUsResponse Cancelar (CancelamentoTransacaoOnUsRequest cancelamentoRequest);
  
        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        ApiResponse<TransacaoOnUsResponse> CancelarWithHttpInfo (CancelamentoTransacaoOnUsRequest cancelamentoRequest);
        
        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira por idConta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o a partir do idConta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>TransacaoOnUsResponse</returns>
        TransacaoOnUsResponse CancelarPorIdConta (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest);
  
        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira por idConta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o a partir do idConta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        ApiResponse<TransacaoOnUsResponse> CancelarPorIdContaWithHttpInfo (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest);
        
        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira por idCartao
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o a partir do idCartao
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>TransacaoOnUsResponse</returns>
        TransacaoOnUsResponse Cancelar_0 (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest);
  
        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira por idCartao
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o a partir do idCartao
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        ApiResponse<TransacaoOnUsResponse> Cancelar_0WithHttpInfo (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest);
        
        /// <summary>
        /// Retorna c\u00F3digos de processamento de autoriza\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo retorna a lista dos c\u00F3digos de processamento para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es financeiras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        List<Object> ListarCodigosProcessamentoAutorizacao ();
  
        /// <summary>
        /// Retorna c\u00F3digos de processamento de autoriza\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo retorna a lista dos c\u00F3digos de processamento para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es financeiras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        ApiResponse<List<Object>> ListarCodigosProcessamentoAutorizacaoWithHttpInfo ();
        
        /// <summary>
        /// Lista os tipos de transa\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os tipos de transa\u00E7\u00F5es dispon\u00EDveis
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        List<Object> ListarTiposEventosTransacoes ();
  
        /// <summary>
        /// Lista os tipos de transa\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os tipos de transa\u00E7\u00F5es dispon\u00EDveis
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        ApiResponse<List<Object>> ListarTiposEventosTransacoesWithHttpInfo ();
        
        /// <summary>
        /// Simula planos de transa\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja simulada um plano de transa\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transacoesRequest">transacoesRequest</param>
        /// <returns>TransacaoOnUsResponse</returns>
        TransacaoOnUsResponse Simular (TransacaoOnUsRequest transacoesRequest);
  
        /// <summary>
        /// Simula planos de transa\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja simulada um plano de transa\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transacoesRequest">transacoesRequest</param>
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        ApiResponse<TransacaoOnUsResponse> SimularWithHttpInfo (TransacaoOnUsRequest transacoesRequest);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira pelo numero do cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o numero do cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autorizacaoOnUsRequest">autorizacaoOnUsRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        System.Threading.Tasks.Task<TransacaoOnUsResponse> AutorizarAsync (AutorizacaoOnUsRequest autorizacaoOnUsRequest);

        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira pelo numero do cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o numero do cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autorizacaoOnUsRequest">autorizacaoOnUsRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> AutorizarAsyncWithHttpInfo (AutorizacaoOnUsRequest autorizacaoOnUsRequest);
        
        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira por idConta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o idConta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        System.Threading.Tasks.Task<TransacaoOnUsResponse> AutorizarPorContaAsync (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest);

        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira por idConta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o idConta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> AutorizarPorContaAsyncWithHttpInfo (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest);
        
        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira pelo idCartao
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o idCartao
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        System.Threading.Tasks.Task<TransacaoOnUsResponse> Autorizar_0Async (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest);

        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira pelo idCartao
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o idCartao
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> Autorizar_0AsyncWithHttpInfo (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest);
        
        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        System.Threading.Tasks.Task<TransacaoOnUsResponse> CancelarAsync (CancelamentoTransacaoOnUsRequest cancelamentoRequest);

        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> CancelarAsyncWithHttpInfo (CancelamentoTransacaoOnUsRequest cancelamentoRequest);
        
        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira por idConta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o a partir do idConta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        System.Threading.Tasks.Task<TransacaoOnUsResponse> CancelarPorIdContaAsync (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest);

        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira por idConta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o a partir do idConta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> CancelarPorIdContaAsyncWithHttpInfo (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest);
        
        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira por idCartao
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o a partir do idCartao
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        System.Threading.Tasks.Task<TransacaoOnUsResponse> Cancelar_0Async (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest);

        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira por idCartao
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o a partir do idCartao
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> Cancelar_0AsyncWithHttpInfo (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest);
        
        /// <summary>
        /// Retorna c\u00F3digos de processamento de autoriza\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo retorna a lista dos c\u00F3digos de processamento para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es financeiras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Object&gt;</returns>
        System.Threading.Tasks.Task<List<Object>> ListarCodigosProcessamentoAutorizacaoAsync ();

        /// <summary>
        /// Retorna c\u00F3digos de processamento de autoriza\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo retorna a lista dos c\u00F3digos de processamento para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es financeiras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Object>>> ListarCodigosProcessamentoAutorizacaoAsyncWithHttpInfo ();
        
        /// <summary>
        /// Lista os tipos de transa\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os tipos de transa\u00E7\u00F5es dispon\u00EDveis
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Object&gt;</returns>
        System.Threading.Tasks.Task<List<Object>> ListarTiposEventosTransacoesAsync ();

        /// <summary>
        /// Lista os tipos de transa\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os tipos de transa\u00E7\u00F5es dispon\u00EDveis
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Object>>> ListarTiposEventosTransacoesAsyncWithHttpInfo ();
        
        /// <summary>
        /// Simula planos de transa\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja simulada um plano de transa\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transacoesRequest">transacoesRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        System.Threading.Tasks.Task<TransacaoOnUsResponse> SimularAsync (TransacaoOnUsRequest transacoesRequest);

        /// <summary>
        /// Simula planos de transa\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja simulada um plano de transa\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transacoesRequest">transacoesRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> SimularAsyncWithHttpInfo (TransacaoOnUsRequest transacoesRequest);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AutorizacaoApi : IAutorizacaoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutorizacaoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AutorizacaoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AutorizacaoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AutorizacaoApi(Configuration configuration = null)
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
        /// Autoriza transa\u00E7\u00E3o financeira pelo numero do cart\u00E3o Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o numero do cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autorizacaoOnUsRequest">autorizacaoOnUsRequest</param> 
        /// <returns>TransacaoOnUsResponse</returns>
        public TransacaoOnUsResponse Autorizar (AutorizacaoOnUsRequest autorizacaoOnUsRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = AutorizarWithHttpInfo(autorizacaoOnUsRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira pelo numero do cart\u00E3o Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o numero do cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autorizacaoOnUsRequest">autorizacaoOnUsRequest</param> 
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        public ApiResponse< TransacaoOnUsResponse > AutorizarWithHttpInfo (AutorizacaoOnUsRequest autorizacaoOnUsRequest)
        {
            
            // verify the required parameter 'autorizacaoOnUsRequest' is set
            if (autorizacaoOnUsRequest == null)
                throw new ApiException(400, "Missing required parameter 'autorizacaoOnUsRequest' when calling AutorizacaoApi->Autorizar");
            
    
            var localVarPath = "/api/autorizar-transacao";
    
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
            
            
            
            
            if (autorizacaoOnUsRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(autorizacaoOnUsRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = autorizacaoOnUsRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Autorizar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Autorizar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }

        
        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira pelo numero do cart\u00E3o Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o numero do cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autorizacaoOnUsRequest">autorizacaoOnUsRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        public async System.Threading.Tasks.Task<TransacaoOnUsResponse> AutorizarAsync (AutorizacaoOnUsRequest autorizacaoOnUsRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = await AutorizarAsyncWithHttpInfo(autorizacaoOnUsRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira pelo numero do cart\u00E3o Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o numero do cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autorizacaoOnUsRequest">autorizacaoOnUsRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> AutorizarAsyncWithHttpInfo (AutorizacaoOnUsRequest autorizacaoOnUsRequest)
        {
            // verify the required parameter 'autorizacaoOnUsRequest' is set
            if (autorizacaoOnUsRequest == null) throw new ApiException(400, "Missing required parameter 'autorizacaoOnUsRequest' when calling Autorizar");
            
    
            var localVarPath = "/api/autorizar-transacao";
    
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
            
            
            
            
            if (autorizacaoOnUsRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(autorizacaoOnUsRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = autorizacaoOnUsRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Autorizar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Autorizar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }
        
        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira por idConta Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o idConta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param> 
        /// <returns>TransacaoOnUsResponse</returns>
        public TransacaoOnUsResponse AutorizarPorConta (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = AutorizarPorContaWithHttpInfo(id, transacaoOnUsPorIdCartaoRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira por idConta Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o idConta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param> 
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        public ApiResponse< TransacaoOnUsResponse > AutorizarPorContaWithHttpInfo (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AutorizacaoApi->AutorizarPorConta");
            
            // verify the required parameter 'transacaoOnUsPorIdCartaoRequest' is set
            if (transacaoOnUsPorIdCartaoRequest == null)
                throw new ApiException(400, "Missing required parameter 'transacaoOnUsPorIdCartaoRequest' when calling AutorizacaoApi->AutorizarPorConta");
            
    
            var localVarPath = "/api/contas/{id}/autorizar-transacao";
    
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
            
            
            
            
            if (transacaoOnUsPorIdCartaoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(transacaoOnUsPorIdCartaoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transacaoOnUsPorIdCartaoRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AutorizarPorConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AutorizarPorConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }

        
        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira por idConta Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o idConta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        public async System.Threading.Tasks.Task<TransacaoOnUsResponse> AutorizarPorContaAsync (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = await AutorizarPorContaAsyncWithHttpInfo(id, transacaoOnUsPorIdCartaoRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira por idConta Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o idConta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> AutorizarPorContaAsyncWithHttpInfo (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AutorizarPorConta");
            // verify the required parameter 'transacaoOnUsPorIdCartaoRequest' is set
            if (transacaoOnUsPorIdCartaoRequest == null) throw new ApiException(400, "Missing required parameter 'transacaoOnUsPorIdCartaoRequest' when calling AutorizarPorConta");
            
    
            var localVarPath = "/api/contas/{id}/autorizar-transacao";
    
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
            
            
            
            
            if (transacaoOnUsPorIdCartaoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(transacaoOnUsPorIdCartaoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transacaoOnUsPorIdCartaoRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AutorizarPorConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AutorizarPorConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }
        
        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira pelo idCartao Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o idCartao
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param> 
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param> 
        /// <returns>TransacaoOnUsResponse</returns>
        public TransacaoOnUsResponse Autorizar_0 (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = Autorizar_0WithHttpInfo(id, transacaoOnUsPorIdCartaoRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira pelo idCartao Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o idCartao
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param> 
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param> 
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        public ApiResponse< TransacaoOnUsResponse > Autorizar_0WithHttpInfo (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AutorizacaoApi->Autorizar_0");
            
            // verify the required parameter 'transacaoOnUsPorIdCartaoRequest' is set
            if (transacaoOnUsPorIdCartaoRequest == null)
                throw new ApiException(400, "Missing required parameter 'transacaoOnUsPorIdCartaoRequest' when calling AutorizacaoApi->Autorizar_0");
            
    
            var localVarPath = "/api/cartoes/{id}/autorizar-transacao";
    
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
            
            
            
            
            if (transacaoOnUsPorIdCartaoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(transacaoOnUsPorIdCartaoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transacaoOnUsPorIdCartaoRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Autorizar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Autorizar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }

        
        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira pelo idCartao Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o idCartao
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        public async System.Threading.Tasks.Task<TransacaoOnUsResponse> Autorizar_0Async (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = await Autorizar_0AsyncWithHttpInfo(id, transacaoOnUsPorIdCartaoRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira pelo idCartao Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o idCartao
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> Autorizar_0AsyncWithHttpInfo (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Autorizar_0");
            // verify the required parameter 'transacaoOnUsPorIdCartaoRequest' is set
            if (transacaoOnUsPorIdCartaoRequest == null) throw new ApiException(400, "Missing required parameter 'transacaoOnUsPorIdCartaoRequest' when calling Autorizar_0");
            
    
            var localVarPath = "/api/cartoes/{id}/autorizar-transacao";
    
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
            
            
            
            
            if (transacaoOnUsPorIdCartaoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(transacaoOnUsPorIdCartaoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transacaoOnUsPorIdCartaoRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Autorizar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Autorizar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }
        
        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param> 
        /// <returns>TransacaoOnUsResponse</returns>
        public TransacaoOnUsResponse Cancelar (CancelamentoTransacaoOnUsRequest cancelamentoRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = CancelarWithHttpInfo(cancelamentoRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param> 
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        public ApiResponse< TransacaoOnUsResponse > CancelarWithHttpInfo (CancelamentoTransacaoOnUsRequest cancelamentoRequest)
        {
            
            // verify the required parameter 'cancelamentoRequest' is set
            if (cancelamentoRequest == null)
                throw new ApiException(400, "Missing required parameter 'cancelamentoRequest' when calling AutorizacaoApi->Cancelar");
            
    
            var localVarPath = "/api/cancelar-transacao";
    
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
            
            
            
            
            if (cancelamentoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cancelamentoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cancelamentoRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Cancelar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Cancelar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }

        
        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        public async System.Threading.Tasks.Task<TransacaoOnUsResponse> CancelarAsync (CancelamentoTransacaoOnUsRequest cancelamentoRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = await CancelarAsyncWithHttpInfo(cancelamentoRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> CancelarAsyncWithHttpInfo (CancelamentoTransacaoOnUsRequest cancelamentoRequest)
        {
            // verify the required parameter 'cancelamentoRequest' is set
            if (cancelamentoRequest == null) throw new ApiException(400, "Missing required parameter 'cancelamentoRequest' when calling Cancelar");
            
    
            var localVarPath = "/api/cancelar-transacao";
    
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
            
            
            
            
            if (cancelamentoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cancelamentoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cancelamentoRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Cancelar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Cancelar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }
        
        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira por idConta Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o a partir do idConta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="cancelamentoRequest">cancelamentoRequest</param> 
        /// <returns>TransacaoOnUsResponse</returns>
        public TransacaoOnUsResponse CancelarPorIdConta (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = CancelarPorIdContaWithHttpInfo(id, cancelamentoRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira por idConta Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o a partir do idConta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="cancelamentoRequest">cancelamentoRequest</param> 
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        public ApiResponse< TransacaoOnUsResponse > CancelarPorIdContaWithHttpInfo (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AutorizacaoApi->CancelarPorIdConta");
            
            // verify the required parameter 'cancelamentoRequest' is set
            if (cancelamentoRequest == null)
                throw new ApiException(400, "Missing required parameter 'cancelamentoRequest' when calling AutorizacaoApi->CancelarPorIdConta");
            
    
            var localVarPath = "/api/contas/{id}/cancelar-transacao";
    
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
            
            
            
            
            if (cancelamentoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cancelamentoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cancelamentoRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarPorIdConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarPorIdConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }

        
        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira por idConta Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o a partir do idConta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        public async System.Threading.Tasks.Task<TransacaoOnUsResponse> CancelarPorIdContaAsync (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = await CancelarPorIdContaAsyncWithHttpInfo(id, cancelamentoRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira por idConta Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o a partir do idConta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> CancelarPorIdContaAsyncWithHttpInfo (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CancelarPorIdConta");
            // verify the required parameter 'cancelamentoRequest' is set
            if (cancelamentoRequest == null) throw new ApiException(400, "Missing required parameter 'cancelamentoRequest' when calling CancelarPorIdConta");
            
    
            var localVarPath = "/api/contas/{id}/cancelar-transacao";
    
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
            
            
            
            
            if (cancelamentoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cancelamentoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cancelamentoRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarPorIdConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarPorIdConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }
        
        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira por idCartao Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o a partir do idCartao
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param> 
        /// <param name="cancelamentoRequest">cancelamentoRequest</param> 
        /// <returns>TransacaoOnUsResponse</returns>
        public TransacaoOnUsResponse Cancelar_0 (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = Cancelar_0WithHttpInfo(id, cancelamentoRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira por idCartao Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o a partir do idCartao
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param> 
        /// <param name="cancelamentoRequest">cancelamentoRequest</param> 
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        public ApiResponse< TransacaoOnUsResponse > Cancelar_0WithHttpInfo (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AutorizacaoApi->Cancelar_0");
            
            // verify the required parameter 'cancelamentoRequest' is set
            if (cancelamentoRequest == null)
                throw new ApiException(400, "Missing required parameter 'cancelamentoRequest' when calling AutorizacaoApi->Cancelar_0");
            
    
            var localVarPath = "/api/cartoes/{id}/cancelar-transacao";
    
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
            
            
            
            
            if (cancelamentoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cancelamentoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cancelamentoRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Cancelar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Cancelar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }

        
        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira por idCartao Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o a partir do idCartao
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        public async System.Threading.Tasks.Task<TransacaoOnUsResponse> Cancelar_0Async (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = await Cancelar_0AsyncWithHttpInfo(id, cancelamentoRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira por idCartao Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o a partir do idCartao
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> Cancelar_0AsyncWithHttpInfo (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Cancelar_0");
            // verify the required parameter 'cancelamentoRequest' is set
            if (cancelamentoRequest == null) throw new ApiException(400, "Missing required parameter 'cancelamentoRequest' when calling Cancelar_0");
            
    
            var localVarPath = "/api/cartoes/{id}/cancelar-transacao";
    
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
            
            
            
            
            if (cancelamentoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cancelamentoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cancelamentoRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Cancelar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Cancelar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }
        
        /// <summary>
        /// Retorna c\u00F3digos de processamento de autoriza\u00E7\u00E3o Este m\u00E9todo retorna a lista dos c\u00F3digos de processamento para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es financeiras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        public List<Object> ListarCodigosProcessamentoAutorizacao ()
        {
             ApiResponse<List<Object>> localVarResponse = ListarCodigosProcessamentoAutorizacaoWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retorna c\u00F3digos de processamento de autoriza\u00E7\u00E3o Este m\u00E9todo retorna a lista dos c\u00F3digos de processamento para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es financeiras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        public ApiResponse< List<Object> > ListarCodigosProcessamentoAutorizacaoWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/consultar-codigos-processamento-autorizacao";
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarCodigosProcessamentoAutorizacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarCodigosProcessamentoAutorizacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
            
        }

        
        /// <summary>
        /// Retorna c\u00F3digos de processamento de autoriza\u00E7\u00E3o Este m\u00E9todo retorna a lista dos c\u00F3digos de processamento para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es financeiras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Object&gt;</returns>
        public async System.Threading.Tasks.Task<List<Object>> ListarCodigosProcessamentoAutorizacaoAsync ()
        {
             ApiResponse<List<Object>> localVarResponse = await ListarCodigosProcessamentoAutorizacaoAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retorna c\u00F3digos de processamento de autoriza\u00E7\u00E3o Este m\u00E9todo retorna a lista dos c\u00F3digos de processamento para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es financeiras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Object>>> ListarCodigosProcessamentoAutorizacaoAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/consultar-codigos-processamento-autorizacao";
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarCodigosProcessamentoAutorizacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarCodigosProcessamentoAutorizacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
            
        }
        
        /// <summary>
        /// Lista os tipos de transa\u00E7\u00F5es Esse recurso permite listar os tipos de transa\u00E7\u00F5es dispon\u00EDveis
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        public List<Object> ListarTiposEventosTransacoes ()
        {
             ApiResponse<List<Object>> localVarResponse = ListarTiposEventosTransacoesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os tipos de transa\u00E7\u00F5es Esse recurso permite listar os tipos de transa\u00E7\u00F5es dispon\u00EDveis
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        public ApiResponse< List<Object> > ListarTiposEventosTransacoesWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/tipos-eventos-transacoes";
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposEventosTransacoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposEventosTransacoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
            
        }

        
        /// <summary>
        /// Lista os tipos de transa\u00E7\u00F5es Esse recurso permite listar os tipos de transa\u00E7\u00F5es dispon\u00EDveis
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Object&gt;</returns>
        public async System.Threading.Tasks.Task<List<Object>> ListarTiposEventosTransacoesAsync ()
        {
             ApiResponse<List<Object>> localVarResponse = await ListarTiposEventosTransacoesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os tipos de transa\u00E7\u00F5es Esse recurso permite listar os tipos de transa\u00E7\u00F5es dispon\u00EDveis
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Object>>> ListarTiposEventosTransacoesAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/tipos-eventos-transacoes";
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposEventosTransacoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposEventosTransacoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
            
        }
        
        /// <summary>
        /// Simula planos de transa\u00E7\u00F5es Este m\u00E9todo permite que seja simulada um plano de transa\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transacoesRequest">transacoesRequest</param> 
        /// <returns>TransacaoOnUsResponse</returns>
        public TransacaoOnUsResponse Simular (TransacaoOnUsRequest transacoesRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = SimularWithHttpInfo(transacoesRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Simula planos de transa\u00E7\u00F5es Este m\u00E9todo permite que seja simulada um plano de transa\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transacoesRequest">transacoesRequest</param> 
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        public ApiResponse< TransacaoOnUsResponse > SimularWithHttpInfo (TransacaoOnUsRequest transacoesRequest)
        {
            
            // verify the required parameter 'transacoesRequest' is set
            if (transacoesRequest == null)
                throw new ApiException(400, "Missing required parameter 'transacoesRequest' when calling AutorizacaoApi->Simular");
            
    
            var localVarPath = "/api/simular-transacao";
    
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
            
            
            
            
            if (transacoesRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(transacoesRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transacoesRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Simular: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Simular: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }

        
        /// <summary>
        /// Simula planos de transa\u00E7\u00F5es Este m\u00E9todo permite que seja simulada um plano de transa\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transacoesRequest">transacoesRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        public async System.Threading.Tasks.Task<TransacaoOnUsResponse> SimularAsync (TransacaoOnUsRequest transacoesRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = await SimularAsyncWithHttpInfo(transacoesRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Simula planos de transa\u00E7\u00F5es Este m\u00E9todo permite que seja simulada um plano de transa\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transacoesRequest">transacoesRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> SimularAsyncWithHttpInfo (TransacaoOnUsRequest transacoesRequest)
        {
            // verify the required parameter 'transacoesRequest' is set
            if (transacoesRequest == null) throw new ApiException(400, "Missing required parameter 'transacoesRequest' when calling Simular");
            
    
            var localVarPath = "/api/simular-transacao";
    
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
            
            
            
            
            if (transacoesRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(transacoesRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transacoesRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Simular: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Simular: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }
        
    }
    
}
