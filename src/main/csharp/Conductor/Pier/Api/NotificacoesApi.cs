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
    public interface INotificacoesApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Atualizar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar o status do SMS do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00C3\u00BAmero (optional)</param>
        /// <param name="status">Status (optional)</param>
        /// <param name="data">Data (optional)</param>
        /// <param name="textoStatus">TextoStatus (optional)</param>
        /// <param name="operadora">Operadora (optional)</param>
        /// <returns>SMS</returns>
        SMS AtualizarSMSUsingPOST (string nsu = null, string status = null, string data = null, string textoStatus = null, string operadora = null);
  
        /// <summary>
        /// Atualizar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar o status do SMS do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00C3\u00BAmero (optional)</param>
        /// <param name="status">Status (optional)</param>
        /// <param name="data">Data (optional)</param>
        /// <param name="textoStatus">TextoStatus (optional)</param>
        /// <param name="operadora">Operadora (optional)</param>
        /// <returns>ApiResponse of SMS</returns>
        ApiResponse<SMS> AtualizarSMSUsingPOSTWithHttpInfo (string nsu = null, string status = null, string data = null, string textoStatus = null, string operadora = null);
        
        /// <summary>
        /// Listar Push
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os Pushes do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataEnvio">Apresenta a data e em que o registro foi enviado para o dispositivo. (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="plataforma">Plataforma de Push notifications. (optional)</param>
        /// <param name="protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es (optional)</param>
        /// <returns>PagePush</returns>
        PagePush ListarPushUsingGET (int? page = null, int? limit = null, DateTime? dataEnvio = null, string tipoEvento = null, string status = null, string plataforma = null, string protocolo = null);
  
        /// <summary>
        /// Listar Push
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os Pushes do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataEnvio">Apresenta a data e em que o registro foi enviado para o dispositivo. (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="plataforma">Plataforma de Push notifications. (optional)</param>
        /// <param name="protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es (optional)</param>
        /// <returns>ApiResponse of PagePush</returns>
        ApiResponse<PagePush> ListarPushUsingGETWithHttpInfo (int? page = null, int? limit = null, DateTime? dataEnvio = null, string tipoEvento = null, string status = null, string plataforma = null, string protocolo = null);
        
        /// <summary>
        /// Listar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os SMS do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataInclusao">Apresenta a data e em que o registro foi inclu\u00C3\u00ADdo na base para ser enviado (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="operadora">Nome da operadora a qual a notifica\u00C3\u00A7\u00C3\u00A3o foi enviada. (optional)</param>
        /// <param name="protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es (optional)</param>
        /// <returns>PageSMS</returns>
        PageSMS ListarSMSUsingGET (int? page = null, int? limit = null, DateTime? dataInclusao = null, string tipoEvento = null, string status = null, string operadora = null, string protocolo = null);
  
        /// <summary>
        /// Listar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os SMS do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataInclusao">Apresenta a data e em que o registro foi inclu\u00C3\u00ADdo na base para ser enviado (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="operadora">Nome da operadora a qual a notifica\u00C3\u00A7\u00C3\u00A3o foi enviada. (optional)</param>
        /// <param name="protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es (optional)</param>
        /// <returns>ApiResponse of PageSMS</returns>
        ApiResponse<PageSMS> ListarSMSUsingGETWithHttpInfo (int? page = null, int? limit = null, DateTime? dataInclusao = null, string tipoEvento = null, string status = null, string operadora = null, string protocolo = null);
        
        /// <summary>
        /// Responder SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar a resposta do SMS, fornecida pedo usu\u00C3\u00A1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00C3\u00BAmero (optional)</param>
        /// <param name="data">Data (optional)</param>
        /// <param name="resposta">TextoStatus (optional)</param>
        /// <returns>SMS</returns>
        SMS ResponderSMSUsingPOST (string nsu = null, string data = null, string resposta = null);
  
        /// <summary>
        /// Responder SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar a resposta do SMS, fornecida pedo usu\u00C3\u00A1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00C3\u00BAmero (optional)</param>
        /// <param name="data">Data (optional)</param>
        /// <param name="resposta">TextoStatus (optional)</param>
        /// <returns>ApiResponse of SMS</returns>
        ApiResponse<SMS> ResponderSMSUsingPOSTWithHttpInfo (string nsu = null, string data = null, string resposta = null);
        
        /// <summary>
        /// Enviar Push FCM
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma FCM (Firebase Cloud Messaging).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>NotificacaoSMSResponse</returns>
        NotificacaoSMSResponse SalvarPushFCMUsingPOST (List<PushFCMEGCM> pushPersists);
  
        /// <summary>
        /// Enviar Push FCM
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma FCM (Firebase Cloud Messaging).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>ApiResponse of NotificacaoSMSResponse</returns>
        ApiResponse<NotificacaoSMSResponse> SalvarPushFCMUsingPOSTWithHttpInfo (List<PushFCMEGCM> pushPersists);
        
        /// <summary>
        /// Enviar Push GCM
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma GCM (Google Cloud Messaging).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>NotificacaoSMSResponse</returns>
        NotificacaoSMSResponse SalvarPushGCMUsingPOST (List<PushFCMEGCM> pushPersists);
  
        /// <summary>
        /// Enviar Push GCM
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma GCM (Google Cloud Messaging).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>ApiResponse of NotificacaoSMSResponse</returns>
        ApiResponse<NotificacaoSMSResponse> SalvarPushGCMUsingPOSTWithHttpInfo (List<PushFCMEGCM> pushPersists);
        
        /// <summary>
        /// Enviar Push APNS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma APNS (Apple Push Notification Service).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>NotificacaoSMSResponse</returns>
        NotificacaoSMSResponse SalvarPushUsingPOST (List<PushAPNS> pushPersists);
  
        /// <summary>
        /// Enviar Push APNS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma APNS (Apple Push Notification Service).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>ApiResponse of NotificacaoSMSResponse</returns>
        ApiResponse<NotificacaoSMSResponse> SalvarPushUsingPOSTWithHttpInfo (List<PushAPNS> pushPersists);
        
        /// <summary>
        /// Enviar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar uma lista de SMS.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listaSMS">listaSMS</param>
        /// <returns>NotificacaoSMSResponse</returns>
        NotificacaoSMSResponse SalvarSMSUsingPOST (List<NotificacaoSMSBody> listaSMS);
  
        /// <summary>
        /// Enviar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar uma lista de SMS.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listaSMS">listaSMS</param>
        /// <returns>ApiResponse of NotificacaoSMSResponse</returns>
        ApiResponse<NotificacaoSMSResponse> SalvarSMSUsingPOSTWithHttpInfo (List<NotificacaoSMSBody> listaSMS);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Atualizar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar o status do SMS do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00C3\u00BAmero (optional)</param>
        /// <param name="status">Status (optional)</param>
        /// <param name="data">Data (optional)</param>
        /// <param name="textoStatus">TextoStatus (optional)</param>
        /// <param name="operadora">Operadora (optional)</param>
        /// <returns>Task of SMS</returns>
        System.Threading.Tasks.Task<SMS> AtualizarSMSUsingPOSTAsync (string nsu = null, string status = null, string data = null, string textoStatus = null, string operadora = null);

        /// <summary>
        /// Atualizar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar o status do SMS do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00C3\u00BAmero (optional)</param>
        /// <param name="status">Status (optional)</param>
        /// <param name="data">Data (optional)</param>
        /// <param name="textoStatus">TextoStatus (optional)</param>
        /// <param name="operadora">Operadora (optional)</param>
        /// <returns>Task of ApiResponse (SMS)</returns>
        System.Threading.Tasks.Task<ApiResponse<SMS>> AtualizarSMSUsingPOSTAsyncWithHttpInfo (string nsu = null, string status = null, string data = null, string textoStatus = null, string operadora = null);
        
        /// <summary>
        /// Listar Push
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os Pushes do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataEnvio">Apresenta a data e em que o registro foi enviado para o dispositivo. (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="plataforma">Plataforma de Push notifications. (optional)</param>
        /// <param name="protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es (optional)</param>
        /// <returns>Task of PagePush</returns>
        System.Threading.Tasks.Task<PagePush> ListarPushUsingGETAsync (int? page = null, int? limit = null, DateTime? dataEnvio = null, string tipoEvento = null, string status = null, string plataforma = null, string protocolo = null);

        /// <summary>
        /// Listar Push
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os Pushes do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataEnvio">Apresenta a data e em que o registro foi enviado para o dispositivo. (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="plataforma">Plataforma de Push notifications. (optional)</param>
        /// <param name="protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es (optional)</param>
        /// <returns>Task of ApiResponse (PagePush)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePush>> ListarPushUsingGETAsyncWithHttpInfo (int? page = null, int? limit = null, DateTime? dataEnvio = null, string tipoEvento = null, string status = null, string plataforma = null, string protocolo = null);
        
        /// <summary>
        /// Listar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os SMS do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataInclusao">Apresenta a data e em que o registro foi inclu\u00C3\u00ADdo na base para ser enviado (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="operadora">Nome da operadora a qual a notifica\u00C3\u00A7\u00C3\u00A3o foi enviada. (optional)</param>
        /// <param name="protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es (optional)</param>
        /// <returns>Task of PageSMS</returns>
        System.Threading.Tasks.Task<PageSMS> ListarSMSUsingGETAsync (int? page = null, int? limit = null, DateTime? dataInclusao = null, string tipoEvento = null, string status = null, string operadora = null, string protocolo = null);

        /// <summary>
        /// Listar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os SMS do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataInclusao">Apresenta a data e em que o registro foi inclu\u00C3\u00ADdo na base para ser enviado (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="operadora">Nome da operadora a qual a notifica\u00C3\u00A7\u00C3\u00A3o foi enviada. (optional)</param>
        /// <param name="protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es (optional)</param>
        /// <returns>Task of ApiResponse (PageSMS)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageSMS>> ListarSMSUsingGETAsyncWithHttpInfo (int? page = null, int? limit = null, DateTime? dataInclusao = null, string tipoEvento = null, string status = null, string operadora = null, string protocolo = null);
        
        /// <summary>
        /// Responder SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar a resposta do SMS, fornecida pedo usu\u00C3\u00A1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00C3\u00BAmero (optional)</param>
        /// <param name="data">Data (optional)</param>
        /// <param name="resposta">TextoStatus (optional)</param>
        /// <returns>Task of SMS</returns>
        System.Threading.Tasks.Task<SMS> ResponderSMSUsingPOSTAsync (string nsu = null, string data = null, string resposta = null);

        /// <summary>
        /// Responder SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar a resposta do SMS, fornecida pedo usu\u00C3\u00A1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00C3\u00BAmero (optional)</param>
        /// <param name="data">Data (optional)</param>
        /// <param name="resposta">TextoStatus (optional)</param>
        /// <returns>Task of ApiResponse (SMS)</returns>
        System.Threading.Tasks.Task<ApiResponse<SMS>> ResponderSMSUsingPOSTAsyncWithHttpInfo (string nsu = null, string data = null, string resposta = null);
        
        /// <summary>
        /// Enviar Push FCM
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma FCM (Firebase Cloud Messaging).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of NotificacaoSMSResponse</returns>
        System.Threading.Tasks.Task<NotificacaoSMSResponse> SalvarPushFCMUsingPOSTAsync (List<PushFCMEGCM> pushPersists);

        /// <summary>
        /// Enviar Push FCM
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma FCM (Firebase Cloud Messaging).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of ApiResponse (NotificacaoSMSResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<NotificacaoSMSResponse>> SalvarPushFCMUsingPOSTAsyncWithHttpInfo (List<PushFCMEGCM> pushPersists);
        
        /// <summary>
        /// Enviar Push GCM
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma GCM (Google Cloud Messaging).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of NotificacaoSMSResponse</returns>
        System.Threading.Tasks.Task<NotificacaoSMSResponse> SalvarPushGCMUsingPOSTAsync (List<PushFCMEGCM> pushPersists);

        /// <summary>
        /// Enviar Push GCM
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma GCM (Google Cloud Messaging).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of ApiResponse (NotificacaoSMSResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<NotificacaoSMSResponse>> SalvarPushGCMUsingPOSTAsyncWithHttpInfo (List<PushFCMEGCM> pushPersists);
        
        /// <summary>
        /// Enviar Push APNS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma APNS (Apple Push Notification Service).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of NotificacaoSMSResponse</returns>
        System.Threading.Tasks.Task<NotificacaoSMSResponse> SalvarPushUsingPOSTAsync (List<PushAPNS> pushPersists);

        /// <summary>
        /// Enviar Push APNS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma APNS (Apple Push Notification Service).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of ApiResponse (NotificacaoSMSResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<NotificacaoSMSResponse>> SalvarPushUsingPOSTAsyncWithHttpInfo (List<PushAPNS> pushPersists);
        
        /// <summary>
        /// Enviar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar uma lista de SMS.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listaSMS">listaSMS</param>
        /// <returns>Task of NotificacaoSMSResponse</returns>
        System.Threading.Tasks.Task<NotificacaoSMSResponse> SalvarSMSUsingPOSTAsync (List<NotificacaoSMSBody> listaSMS);

        /// <summary>
        /// Enviar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar uma lista de SMS.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listaSMS">listaSMS</param>
        /// <returns>Task of ApiResponse (NotificacaoSMSResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<NotificacaoSMSResponse>> SalvarSMSUsingPOSTAsyncWithHttpInfo (List<NotificacaoSMSBody> listaSMS);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class NotificacoesApi : INotificacoesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificacoesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NotificacoesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificacoesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public NotificacoesApi(Configuration configuration = null)
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
        /// Atualizar SMS Esse recurso permite atualizar o status do SMS do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00C3\u00BAmero (optional)</param> 
        /// <param name="status">Status (optional)</param> 
        /// <param name="data">Data (optional)</param> 
        /// <param name="textoStatus">TextoStatus (optional)</param> 
        /// <param name="operadora">Operadora (optional)</param> 
        /// <returns>SMS</returns>
        public SMS AtualizarSMSUsingPOST (string nsu = null, string status = null, string data = null, string textoStatus = null, string operadora = null)
        {
             ApiResponse<SMS> localVarResponse = AtualizarSMSUsingPOSTWithHttpInfo(nsu, status, data, textoStatus, operadora);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualizar SMS Esse recurso permite atualizar o status do SMS do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00C3\u00BAmero (optional)</param> 
        /// <param name="status">Status (optional)</param> 
        /// <param name="data">Data (optional)</param> 
        /// <param name="textoStatus">TextoStatus (optional)</param> 
        /// <param name="operadora">Operadora (optional)</param> 
        /// <returns>ApiResponse of SMS</returns>
        public ApiResponse< SMS > AtualizarSMSUsingPOSTWithHttpInfo (string nsu = null, string status = null, string data = null, string textoStatus = null, string operadora = null)
        {
            
    
            var localVarPath = "/api/notificacoes/sms/atualizar-status";
    
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
            
            if (nsu != null) localVarQueryParams.Add("nsu", Configuration.ApiClient.ParameterToString(nsu)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (data != null) localVarQueryParams.Add("data", Configuration.ApiClient.ParameterToString(data)); // query parameter
            if (textoStatus != null) localVarQueryParams.Add("texto_status", Configuration.ApiClient.ParameterToString(textoStatus)); // query parameter
            if (operadora != null) localVarQueryParams.Add("operadora", Configuration.ApiClient.ParameterToString(operadora)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AtualizarSMSUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarSMSUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<SMS>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SMS) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SMS)));
            
        }

        
        /// <summary>
        /// Atualizar SMS Esse recurso permite atualizar o status do SMS do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00C3\u00BAmero (optional)</param>
        /// <param name="status">Status (optional)</param>
        /// <param name="data">Data (optional)</param>
        /// <param name="textoStatus">TextoStatus (optional)</param>
        /// <param name="operadora">Operadora (optional)</param>
        /// <returns>Task of SMS</returns>
        public async System.Threading.Tasks.Task<SMS> AtualizarSMSUsingPOSTAsync (string nsu = null, string status = null, string data = null, string textoStatus = null, string operadora = null)
        {
             ApiResponse<SMS> localVarResponse = await AtualizarSMSUsingPOSTAsyncWithHttpInfo(nsu, status, data, textoStatus, operadora);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualizar SMS Esse recurso permite atualizar o status do SMS do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00C3\u00BAmero (optional)</param>
        /// <param name="status">Status (optional)</param>
        /// <param name="data">Data (optional)</param>
        /// <param name="textoStatus">TextoStatus (optional)</param>
        /// <param name="operadora">Operadora (optional)</param>
        /// <returns>Task of ApiResponse (SMS)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SMS>> AtualizarSMSUsingPOSTAsyncWithHttpInfo (string nsu = null, string status = null, string data = null, string textoStatus = null, string operadora = null)
        {
            
    
            var localVarPath = "/api/notificacoes/sms/atualizar-status";
    
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
            
            if (nsu != null) localVarQueryParams.Add("nsu", Configuration.ApiClient.ParameterToString(nsu)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (data != null) localVarQueryParams.Add("data", Configuration.ApiClient.ParameterToString(data)); // query parameter
            if (textoStatus != null) localVarQueryParams.Add("texto_status", Configuration.ApiClient.ParameterToString(textoStatus)); // query parameter
            if (operadora != null) localVarQueryParams.Add("operadora", Configuration.ApiClient.ParameterToString(operadora)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AtualizarSMSUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarSMSUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SMS>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SMS) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SMS)));
            
        }
        
        /// <summary>
        /// Listar Push Esse recurso permite listar os Pushes do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="dataEnvio">Apresenta a data e em que o registro foi enviado para o dispositivo. (optional)</param> 
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <param name="status">Status de envio da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <param name="plataforma">Plataforma de Push notifications. (optional)</param> 
        /// <param name="protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es (optional)</param> 
        /// <returns>PagePush</returns>
        public PagePush ListarPushUsingGET (int? page = null, int? limit = null, DateTime? dataEnvio = null, string tipoEvento = null, string status = null, string plataforma = null, string protocolo = null)
        {
             ApiResponse<PagePush> localVarResponse = ListarPushUsingGETWithHttpInfo(page, limit, dataEnvio, tipoEvento, status, plataforma, protocolo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar Push Esse recurso permite listar os Pushes do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="dataEnvio">Apresenta a data e em que o registro foi enviado para o dispositivo. (optional)</param> 
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <param name="status">Status de envio da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <param name="plataforma">Plataforma de Push notifications. (optional)</param> 
        /// <param name="protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es (optional)</param> 
        /// <returns>ApiResponse of PagePush</returns>
        public ApiResponse< PagePush > ListarPushUsingGETWithHttpInfo (int? page = null, int? limit = null, DateTime? dataEnvio = null, string tipoEvento = null, string status = null, string plataforma = null, string protocolo = null)
        {
            
    
            var localVarPath = "/api/notificacoes/push";
    
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
            if (dataEnvio != null) localVarQueryParams.Add("dataEnvio", Configuration.ApiClient.ParameterToString(dataEnvio)); // query parameter
            if (tipoEvento != null) localVarQueryParams.Add("tipoEvento", Configuration.ApiClient.ParameterToString(tipoEvento)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (plataforma != null) localVarQueryParams.Add("plataforma", Configuration.ApiClient.ParameterToString(plataforma)); // query parameter
            if (protocolo != null) localVarQueryParams.Add("protocolo", Configuration.ApiClient.ParameterToString(protocolo)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling ListarPushUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPushUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePush>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePush) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePush)));
            
        }

        
        /// <summary>
        /// Listar Push Esse recurso permite listar os Pushes do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataEnvio">Apresenta a data e em que o registro foi enviado para o dispositivo. (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="plataforma">Plataforma de Push notifications. (optional)</param>
        /// <param name="protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es (optional)</param>
        /// <returns>Task of PagePush</returns>
        public async System.Threading.Tasks.Task<PagePush> ListarPushUsingGETAsync (int? page = null, int? limit = null, DateTime? dataEnvio = null, string tipoEvento = null, string status = null, string plataforma = null, string protocolo = null)
        {
             ApiResponse<PagePush> localVarResponse = await ListarPushUsingGETAsyncWithHttpInfo(page, limit, dataEnvio, tipoEvento, status, plataforma, protocolo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar Push Esse recurso permite listar os Pushes do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataEnvio">Apresenta a data e em que o registro foi enviado para o dispositivo. (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="plataforma">Plataforma de Push notifications. (optional)</param>
        /// <param name="protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es (optional)</param>
        /// <returns>Task of ApiResponse (PagePush)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePush>> ListarPushUsingGETAsyncWithHttpInfo (int? page = null, int? limit = null, DateTime? dataEnvio = null, string tipoEvento = null, string status = null, string plataforma = null, string protocolo = null)
        {
            
    
            var localVarPath = "/api/notificacoes/push";
    
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
            if (dataEnvio != null) localVarQueryParams.Add("dataEnvio", Configuration.ApiClient.ParameterToString(dataEnvio)); // query parameter
            if (tipoEvento != null) localVarQueryParams.Add("tipoEvento", Configuration.ApiClient.ParameterToString(tipoEvento)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (plataforma != null) localVarQueryParams.Add("plataforma", Configuration.ApiClient.ParameterToString(plataforma)); // query parameter
            if (protocolo != null) localVarQueryParams.Add("protocolo", Configuration.ApiClient.ParameterToString(protocolo)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling ListarPushUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPushUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePush>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePush) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePush)));
            
        }
        
        /// <summary>
        /// Listar SMS Esse recurso permite listar os SMS do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="dataInclusao">Apresenta a data e em que o registro foi inclu\u00C3\u00ADdo na base para ser enviado (optional)</param> 
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <param name="status">Status de envio da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <param name="operadora">Nome da operadora a qual a notifica\u00C3\u00A7\u00C3\u00A3o foi enviada. (optional)</param> 
        /// <param name="protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es (optional)</param> 
        /// <returns>PageSMS</returns>
        public PageSMS ListarSMSUsingGET (int? page = null, int? limit = null, DateTime? dataInclusao = null, string tipoEvento = null, string status = null, string operadora = null, string protocolo = null)
        {
             ApiResponse<PageSMS> localVarResponse = ListarSMSUsingGETWithHttpInfo(page, limit, dataInclusao, tipoEvento, status, operadora, protocolo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar SMS Esse recurso permite listar os SMS do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="dataInclusao">Apresenta a data e em que o registro foi inclu\u00C3\u00ADdo na base para ser enviado (optional)</param> 
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <param name="status">Status de envio da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <param name="operadora">Nome da operadora a qual a notifica\u00C3\u00A7\u00C3\u00A3o foi enviada. (optional)</param> 
        /// <param name="protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es (optional)</param> 
        /// <returns>ApiResponse of PageSMS</returns>
        public ApiResponse< PageSMS > ListarSMSUsingGETWithHttpInfo (int? page = null, int? limit = null, DateTime? dataInclusao = null, string tipoEvento = null, string status = null, string operadora = null, string protocolo = null)
        {
            
    
            var localVarPath = "/api/notificacoes/sms";
    
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
            if (dataInclusao != null) localVarQueryParams.Add("dataInclusao", Configuration.ApiClient.ParameterToString(dataInclusao)); // query parameter
            if (tipoEvento != null) localVarQueryParams.Add("tipoEvento", Configuration.ApiClient.ParameterToString(tipoEvento)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (operadora != null) localVarQueryParams.Add("operadora", Configuration.ApiClient.ParameterToString(operadora)); // query parameter
            if (protocolo != null) localVarQueryParams.Add("protocolo", Configuration.ApiClient.ParameterToString(protocolo)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling ListarSMSUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarSMSUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageSMS>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageSMS) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageSMS)));
            
        }

        
        /// <summary>
        /// Listar SMS Esse recurso permite listar os SMS do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataInclusao">Apresenta a data e em que o registro foi inclu\u00C3\u00ADdo na base para ser enviado (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="operadora">Nome da operadora a qual a notifica\u00C3\u00A7\u00C3\u00A3o foi enviada. (optional)</param>
        /// <param name="protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es (optional)</param>
        /// <returns>Task of PageSMS</returns>
        public async System.Threading.Tasks.Task<PageSMS> ListarSMSUsingGETAsync (int? page = null, int? limit = null, DateTime? dataInclusao = null, string tipoEvento = null, string status = null, string operadora = null, string protocolo = null)
        {
             ApiResponse<PageSMS> localVarResponse = await ListarSMSUsingGETAsyncWithHttpInfo(page, limit, dataInclusao, tipoEvento, status, operadora, protocolo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar SMS Esse recurso permite listar os SMS do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="dataInclusao">Apresenta a data e em que o registro foi inclu\u00C3\u00ADdo na base para ser enviado (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="operadora">Nome da operadora a qual a notifica\u00C3\u00A7\u00C3\u00A3o foi enviada. (optional)</param>
        /// <param name="protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es (optional)</param>
        /// <returns>Task of ApiResponse (PageSMS)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageSMS>> ListarSMSUsingGETAsyncWithHttpInfo (int? page = null, int? limit = null, DateTime? dataInclusao = null, string tipoEvento = null, string status = null, string operadora = null, string protocolo = null)
        {
            
    
            var localVarPath = "/api/notificacoes/sms";
    
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
            if (dataInclusao != null) localVarQueryParams.Add("dataInclusao", Configuration.ApiClient.ParameterToString(dataInclusao)); // query parameter
            if (tipoEvento != null) localVarQueryParams.Add("tipoEvento", Configuration.ApiClient.ParameterToString(tipoEvento)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (operadora != null) localVarQueryParams.Add("operadora", Configuration.ApiClient.ParameterToString(operadora)); // query parameter
            if (protocolo != null) localVarQueryParams.Add("protocolo", Configuration.ApiClient.ParameterToString(protocolo)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling ListarSMSUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarSMSUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageSMS>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageSMS) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageSMS)));
            
        }
        
        /// <summary>
        /// Responder SMS Esse recurso permite atualizar a resposta do SMS, fornecida pedo usu\u00C3\u00A1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00C3\u00BAmero (optional)</param> 
        /// <param name="data">Data (optional)</param> 
        /// <param name="resposta">TextoStatus (optional)</param> 
        /// <returns>SMS</returns>
        public SMS ResponderSMSUsingPOST (string nsu = null, string data = null, string resposta = null)
        {
             ApiResponse<SMS> localVarResponse = ResponderSMSUsingPOSTWithHttpInfo(nsu, data, resposta);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Responder SMS Esse recurso permite atualizar a resposta do SMS, fornecida pedo usu\u00C3\u00A1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00C3\u00BAmero (optional)</param> 
        /// <param name="data">Data (optional)</param> 
        /// <param name="resposta">TextoStatus (optional)</param> 
        /// <returns>ApiResponse of SMS</returns>
        public ApiResponse< SMS > ResponderSMSUsingPOSTWithHttpInfo (string nsu = null, string data = null, string resposta = null)
        {
            
    
            var localVarPath = "/api/notificacoes/sms/responder";
    
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
            
            if (nsu != null) localVarQueryParams.Add("nsu", Configuration.ApiClient.ParameterToString(nsu)); // query parameter
            if (data != null) localVarQueryParams.Add("data", Configuration.ApiClient.ParameterToString(data)); // query parameter
            if (resposta != null) localVarQueryParams.Add("resposta", Configuration.ApiClient.ParameterToString(resposta)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling ResponderSMSUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ResponderSMSUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<SMS>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SMS) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SMS)));
            
        }

        
        /// <summary>
        /// Responder SMS Esse recurso permite atualizar a resposta do SMS, fornecida pedo usu\u00C3\u00A1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00C3\u00BAmero (optional)</param>
        /// <param name="data">Data (optional)</param>
        /// <param name="resposta">TextoStatus (optional)</param>
        /// <returns>Task of SMS</returns>
        public async System.Threading.Tasks.Task<SMS> ResponderSMSUsingPOSTAsync (string nsu = null, string data = null, string resposta = null)
        {
             ApiResponse<SMS> localVarResponse = await ResponderSMSUsingPOSTAsyncWithHttpInfo(nsu, data, resposta);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Responder SMS Esse recurso permite atualizar a resposta do SMS, fornecida pedo usu\u00C3\u00A1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00C3\u00BAmero (optional)</param>
        /// <param name="data">Data (optional)</param>
        /// <param name="resposta">TextoStatus (optional)</param>
        /// <returns>Task of ApiResponse (SMS)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SMS>> ResponderSMSUsingPOSTAsyncWithHttpInfo (string nsu = null, string data = null, string resposta = null)
        {
            
    
            var localVarPath = "/api/notificacoes/sms/responder";
    
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
            
            if (nsu != null) localVarQueryParams.Add("nsu", Configuration.ApiClient.ParameterToString(nsu)); // query parameter
            if (data != null) localVarQueryParams.Add("data", Configuration.ApiClient.ParameterToString(data)); // query parameter
            if (resposta != null) localVarQueryParams.Add("resposta", Configuration.ApiClient.ParameterToString(resposta)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling ResponderSMSUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ResponderSMSUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SMS>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SMS) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SMS)));
            
        }
        
        /// <summary>
        /// Enviar Push FCM Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma FCM (Firebase Cloud Messaging).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param> 
        /// <returns>NotificacaoSMSResponse</returns>
        public NotificacaoSMSResponse SalvarPushFCMUsingPOST (List<PushFCMEGCM> pushPersists)
        {
             ApiResponse<NotificacaoSMSResponse> localVarResponse = SalvarPushFCMUsingPOSTWithHttpInfo(pushPersists);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Enviar Push FCM Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma FCM (Firebase Cloud Messaging).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param> 
        /// <returns>ApiResponse of NotificacaoSMSResponse</returns>
        public ApiResponse< NotificacaoSMSResponse > SalvarPushFCMUsingPOSTWithHttpInfo (List<PushFCMEGCM> pushPersists)
        {
            
            // verify the required parameter 'pushPersists' is set
            if (pushPersists == null)
                throw new ApiException(400, "Missing required parameter 'pushPersists' when calling NotificacoesApi->SalvarPushFCMUsingPOST");
            
    
            var localVarPath = "/api/notificacoes/push/fcm";
    
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
            
            
            
            
            if (pushPersists.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(pushPersists); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pushPersists; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarPushFCMUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPushFCMUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<NotificacaoSMSResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificacaoSMSResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificacaoSMSResponse)));
            
        }

        
        /// <summary>
        /// Enviar Push FCM Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma FCM (Firebase Cloud Messaging).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of NotificacaoSMSResponse</returns>
        public async System.Threading.Tasks.Task<NotificacaoSMSResponse> SalvarPushFCMUsingPOSTAsync (List<PushFCMEGCM> pushPersists)
        {
             ApiResponse<NotificacaoSMSResponse> localVarResponse = await SalvarPushFCMUsingPOSTAsyncWithHttpInfo(pushPersists);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Enviar Push FCM Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma FCM (Firebase Cloud Messaging).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of ApiResponse (NotificacaoSMSResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NotificacaoSMSResponse>> SalvarPushFCMUsingPOSTAsyncWithHttpInfo (List<PushFCMEGCM> pushPersists)
        {
            // verify the required parameter 'pushPersists' is set
            if (pushPersists == null) throw new ApiException(400, "Missing required parameter 'pushPersists' when calling SalvarPushFCMUsingPOST");
            
    
            var localVarPath = "/api/notificacoes/push/fcm";
    
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
            
            
            
            
            if (pushPersists.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(pushPersists); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pushPersists; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarPushFCMUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPushFCMUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NotificacaoSMSResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificacaoSMSResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificacaoSMSResponse)));
            
        }
        
        /// <summary>
        /// Enviar Push GCM Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma GCM (Google Cloud Messaging).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param> 
        /// <returns>NotificacaoSMSResponse</returns>
        public NotificacaoSMSResponse SalvarPushGCMUsingPOST (List<PushFCMEGCM> pushPersists)
        {
             ApiResponse<NotificacaoSMSResponse> localVarResponse = SalvarPushGCMUsingPOSTWithHttpInfo(pushPersists);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Enviar Push GCM Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma GCM (Google Cloud Messaging).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param> 
        /// <returns>ApiResponse of NotificacaoSMSResponse</returns>
        public ApiResponse< NotificacaoSMSResponse > SalvarPushGCMUsingPOSTWithHttpInfo (List<PushFCMEGCM> pushPersists)
        {
            
            // verify the required parameter 'pushPersists' is set
            if (pushPersists == null)
                throw new ApiException(400, "Missing required parameter 'pushPersists' when calling NotificacoesApi->SalvarPushGCMUsingPOST");
            
    
            var localVarPath = "/api/notificacoes/push/gcm";
    
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
            
            
            
            
            if (pushPersists.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(pushPersists); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pushPersists; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarPushGCMUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPushGCMUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<NotificacaoSMSResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificacaoSMSResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificacaoSMSResponse)));
            
        }

        
        /// <summary>
        /// Enviar Push GCM Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma GCM (Google Cloud Messaging).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of NotificacaoSMSResponse</returns>
        public async System.Threading.Tasks.Task<NotificacaoSMSResponse> SalvarPushGCMUsingPOSTAsync (List<PushFCMEGCM> pushPersists)
        {
             ApiResponse<NotificacaoSMSResponse> localVarResponse = await SalvarPushGCMUsingPOSTAsyncWithHttpInfo(pushPersists);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Enviar Push GCM Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma GCM (Google Cloud Messaging).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of ApiResponse (NotificacaoSMSResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NotificacaoSMSResponse>> SalvarPushGCMUsingPOSTAsyncWithHttpInfo (List<PushFCMEGCM> pushPersists)
        {
            // verify the required parameter 'pushPersists' is set
            if (pushPersists == null) throw new ApiException(400, "Missing required parameter 'pushPersists' when calling SalvarPushGCMUsingPOST");
            
    
            var localVarPath = "/api/notificacoes/push/gcm";
    
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
            
            
            
            
            if (pushPersists.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(pushPersists); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pushPersists; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarPushGCMUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPushGCMUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NotificacaoSMSResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificacaoSMSResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificacaoSMSResponse)));
            
        }
        
        /// <summary>
        /// Enviar Push APNS Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma APNS (Apple Push Notification Service).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param> 
        /// <returns>NotificacaoSMSResponse</returns>
        public NotificacaoSMSResponse SalvarPushUsingPOST (List<PushAPNS> pushPersists)
        {
             ApiResponse<NotificacaoSMSResponse> localVarResponse = SalvarPushUsingPOSTWithHttpInfo(pushPersists);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Enviar Push APNS Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma APNS (Apple Push Notification Service).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param> 
        /// <returns>ApiResponse of NotificacaoSMSResponse</returns>
        public ApiResponse< NotificacaoSMSResponse > SalvarPushUsingPOSTWithHttpInfo (List<PushAPNS> pushPersists)
        {
            
            // verify the required parameter 'pushPersists' is set
            if (pushPersists == null)
                throw new ApiException(400, "Missing required parameter 'pushPersists' when calling NotificacoesApi->SalvarPushUsingPOST");
            
    
            var localVarPath = "/api/notificacoes/push/apns";
    
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
            
            
            
            
            if (pushPersists.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(pushPersists); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pushPersists; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarPushUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPushUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<NotificacaoSMSResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificacaoSMSResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificacaoSMSResponse)));
            
        }

        
        /// <summary>
        /// Enviar Push APNS Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma APNS (Apple Push Notification Service).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of NotificacaoSMSResponse</returns>
        public async System.Threading.Tasks.Task<NotificacaoSMSResponse> SalvarPushUsingPOSTAsync (List<PushAPNS> pushPersists)
        {
             ApiResponse<NotificacaoSMSResponse> localVarResponse = await SalvarPushUsingPOSTAsyncWithHttpInfo(pushPersists);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Enviar Push APNS Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma APNS (Apple Push Notification Service).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of ApiResponse (NotificacaoSMSResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NotificacaoSMSResponse>> SalvarPushUsingPOSTAsyncWithHttpInfo (List<PushAPNS> pushPersists)
        {
            // verify the required parameter 'pushPersists' is set
            if (pushPersists == null) throw new ApiException(400, "Missing required parameter 'pushPersists' when calling SalvarPushUsingPOST");
            
    
            var localVarPath = "/api/notificacoes/push/apns";
    
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
            
            
            
            
            if (pushPersists.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(pushPersists); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pushPersists; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarPushUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPushUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NotificacaoSMSResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificacaoSMSResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificacaoSMSResponse)));
            
        }
        
        /// <summary>
        /// Enviar SMS Esse recurso permite enviar uma lista de SMS.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listaSMS">listaSMS</param> 
        /// <returns>NotificacaoSMSResponse</returns>
        public NotificacaoSMSResponse SalvarSMSUsingPOST (List<NotificacaoSMSBody> listaSMS)
        {
             ApiResponse<NotificacaoSMSResponse> localVarResponse = SalvarSMSUsingPOSTWithHttpInfo(listaSMS);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Enviar SMS Esse recurso permite enviar uma lista de SMS.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listaSMS">listaSMS</param> 
        /// <returns>ApiResponse of NotificacaoSMSResponse</returns>
        public ApiResponse< NotificacaoSMSResponse > SalvarSMSUsingPOSTWithHttpInfo (List<NotificacaoSMSBody> listaSMS)
        {
            
            // verify the required parameter 'listaSMS' is set
            if (listaSMS == null)
                throw new ApiException(400, "Missing required parameter 'listaSMS' when calling NotificacoesApi->SalvarSMSUsingPOST");
            
    
            var localVarPath = "/api/notificacoes/sms";
    
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
            
            
            
            
            if (listaSMS.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(listaSMS); // http body (model) parameter
            }
            else
            {
                localVarPostBody = listaSMS; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarSMSUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarSMSUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<NotificacaoSMSResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificacaoSMSResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificacaoSMSResponse)));
            
        }

        
        /// <summary>
        /// Enviar SMS Esse recurso permite enviar uma lista de SMS.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listaSMS">listaSMS</param>
        /// <returns>Task of NotificacaoSMSResponse</returns>
        public async System.Threading.Tasks.Task<NotificacaoSMSResponse> SalvarSMSUsingPOSTAsync (List<NotificacaoSMSBody> listaSMS)
        {
             ApiResponse<NotificacaoSMSResponse> localVarResponse = await SalvarSMSUsingPOSTAsyncWithHttpInfo(listaSMS);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Enviar SMS Esse recurso permite enviar uma lista de SMS.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listaSMS">listaSMS</param>
        /// <returns>Task of ApiResponse (NotificacaoSMSResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NotificacaoSMSResponse>> SalvarSMSUsingPOSTAsyncWithHttpInfo (List<NotificacaoSMSBody> listaSMS)
        {
            // verify the required parameter 'listaSMS' is set
            if (listaSMS == null) throw new ApiException(400, "Missing required parameter 'listaSMS' when calling SalvarSMSUsingPOST");
            
    
            var localVarPath = "/api/notificacoes/sms";
    
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
            
            
            
            
            if (listaSMS.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(listaSMS); // http body (model) parameter
            }
            else
            {
                localVarPostBody = listaSMS; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarSMSUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarSMSUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NotificacaoSMSResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificacaoSMSResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificacaoSMSResponse)));
            
        }
        
    }
    
}
