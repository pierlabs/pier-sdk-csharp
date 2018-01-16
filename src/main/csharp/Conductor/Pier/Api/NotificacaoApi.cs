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
    public interface INotificacaoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Altera configura\u00C3\u00A7\u00C3\u00B5es de E-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite salvar altera\u00C3\u00A7\u00C3\u00B5es de configura\u00C3\u00A7\u00C3\u00B5es de E-mail.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de e-mail.</param>
        /// <param name="persist">persist</param>
        /// <returns>ConfiguracaoEmailResponse</returns>
        ConfiguracaoEmailResponse AlterarConfiguracaoUsingPUT (long? id, ConfiguracaoEmailPersist persist);
  
        /// <summary>
        /// Altera configura\u00C3\u00A7\u00C3\u00B5es de E-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite salvar altera\u00C3\u00A7\u00C3\u00B5es de configura\u00C3\u00A7\u00C3\u00B5es de E-mail.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de e-mail.</param>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of ConfiguracaoEmailResponse</returns>
        ApiResponse<ConfiguracaoEmailResponse> AlterarConfiguracaoUsingPUTWithHttpInfo (long? id, ConfiguracaoEmailPersist persist);
        
        /// <summary>
        /// Alterar template de notifica\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite salvar altera\u00C3\u00A7\u00C3\u00B5es de templates notifica\u00C3\u00A7\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do layout de e-mail.</param>
        /// <param name="conteudo">Template HTML</param>
        /// <param name="idConfiguracaoEmail">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da configra\u00C3\u00A7\u00C3\u00A3o de EMAIL. (optional)</param>
        /// <param name="tipoLayout">Tipo do layout. (optional)</param>
        /// <param name="tipoNotificacao">Tipo da notifica\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="remetente">Remetente (optional)</param>
        /// <param name="assunto">Assunto da Notificaca\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="templatePadrao">Template Padr\u00C3\u00A3o. (optional)</param>
        /// <returns>TemplateNotificacaoDetalheResponse</returns>
        TemplateNotificacaoDetalheResponse AlterarTemplateNotificacaoUsingPUT (long? id, string conteudo, long? idConfiguracaoEmail = null, string tipoLayout = null, string tipoNotificacao = null, string remetente = null, string assunto = null, bool? templatePadrao = null);
  
        /// <summary>
        /// Alterar template de notifica\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite salvar altera\u00C3\u00A7\u00C3\u00B5es de templates notifica\u00C3\u00A7\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do layout de e-mail.</param>
        /// <param name="conteudo">Template HTML</param>
        /// <param name="idConfiguracaoEmail">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da configra\u00C3\u00A7\u00C3\u00A3o de EMAIL. (optional)</param>
        /// <param name="tipoLayout">Tipo do layout. (optional)</param>
        /// <param name="tipoNotificacao">Tipo da notifica\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="remetente">Remetente (optional)</param>
        /// <param name="assunto">Assunto da Notificaca\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="templatePadrao">Template Padr\u00C3\u00A3o. (optional)</param>
        /// <returns>ApiResponse of TemplateNotificacaoDetalheResponse</returns>
        ApiResponse<TemplateNotificacaoDetalheResponse> AlterarTemplateNotificacaoUsingPUTWithHttpInfo (long? id, string conteudo, long? idConfiguracaoEmail = null, string tipoLayout = null, string tipoNotificacao = null, string remetente = null, string assunto = null, bool? templatePadrao = null);
        
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
        /// <returns>NotificacaoSMSResponse</returns>
        NotificacaoSMSResponse AtualizarSMSUsingPOST (string nsu = null, string status = null, string data = null, string textoStatus = null, string operadora = null);
  
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
        /// <returns>ApiResponse of NotificacaoSMSResponse</returns>
        ApiResponse<NotificacaoSMSResponse> AtualizarSMSUsingPOSTWithHttpInfo (string nsu = null, string status = null, string data = null, string textoStatus = null, string operadora = null);
        
        /// <summary>
        /// Consulta configura\u00C3\u00A7\u00C3\u00A3o de E-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar uma configura\u00C3\u00A7\u00C3\u00A3o espec\u00C3\u00ADfica por id.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de e-mail.</param>
        /// <returns>ConfiguracaoEmailResponse</returns>
        ConfiguracaoEmailResponse ConsultarConfiguracaoUsingGET (long? id);
  
        /// <summary>
        /// Consulta configura\u00C3\u00A7\u00C3\u00A3o de E-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar uma configura\u00C3\u00A7\u00C3\u00A3o espec\u00C3\u00ADfica por id.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de e-mail.</param>
        /// <returns>ApiResponse of ConfiguracaoEmailResponse</returns>
        ApiResponse<ConfiguracaoEmailResponse> ConsultarConfiguracaoUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta c\u00C3\u00B3digo de seguran\u00C3\u00A7a E-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar um c\u00C3\u00B3digo de seguran\u00C3\u00A7a E-mail espec\u00C3\u00ADfico por id.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de e-mail.</param>
        /// <returns>CodigoSegurancaResponse</returns>
        CodigoSegurancaResponse ConsultarPorEmailUsingGET (long? id);
  
        /// <summary>
        /// Consulta c\u00C3\u00B3digo de seguran\u00C3\u00A7a E-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar um c\u00C3\u00B3digo de seguran\u00C3\u00A7a E-mail espec\u00C3\u00ADfico por id.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de e-mail.</param>
        /// <returns>ApiResponse of CodigoSegurancaResponse</returns>
        ApiResponse<CodigoSegurancaResponse> ConsultarPorEmailUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta c\u00C3\u00B3digo de seguran\u00C3\u00A7a SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar um c\u00C3\u00B3digo de seguran\u00C3\u00A7a SMS espec\u00C3\u00ADfico por id.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de e-mail.</param>
        /// <returns>CodigoSegurancaResponse</returns>
        CodigoSegurancaResponse ConsultarPorSMSUsingGET (long? id);
  
        /// <summary>
        /// Consulta c\u00C3\u00B3digo de seguran\u00C3\u00A7a SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar um c\u00C3\u00B3digo de seguran\u00C3\u00A7a SMS espec\u00C3\u00ADfico por id.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de e-mail.</param>
        /// <returns>ApiResponse of CodigoSegurancaResponse</returns>
        ApiResponse<CodigoSegurancaResponse> ConsultarPorSMSUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta template de notifica\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar uma configura\u00C3\u00A7\u00C3\u00A3o espec\u00C3\u00ADfica por id.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do layout de e-mail.</param>
        /// <returns>TemplateNotificacaoDetalheResponse</returns>
        TemplateNotificacaoDetalheResponse ConsultarTemplateNotificacaoUsingGET (long? id);
  
        /// <summary>
        /// Consulta template de notifica\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar uma configura\u00C3\u00A7\u00C3\u00A3o espec\u00C3\u00ADfica por id.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do layout de e-mail.</param>
        /// <returns>ApiResponse of TemplateNotificacaoDetalheResponse</returns>
        ApiResponse<TemplateNotificacaoDetalheResponse> ConsultarTemplateNotificacaoUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// Gerar c\u00C3\u00B3digo de seguran\u00C3\u00A7a e enviar por e-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite gerar e enviar c\u00C3\u00B3digos de seguran\u00C3\u00A7a por e-mail, para valida\u00C3\u00A7\u00C3\u00A3o de dispositivos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">email</param>
        /// <returns>string</returns>
        string GerarTokenEMAILUsingPOST (string email);
  
        /// <summary>
        /// Gerar c\u00C3\u00B3digo de seguran\u00C3\u00A7a e enviar por e-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite gerar e enviar c\u00C3\u00B3digos de seguran\u00C3\u00A7a por e-mail, para valida\u00C3\u00A7\u00C3\u00A3o de dispositivos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">email</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> GerarTokenEMAILUsingPOSTWithHttpInfo (string email);
        
        /// <summary>
        /// Gerar c\u00C3\u00B3digo de seguran\u00C3\u00A7a e enviar por sms
        /// </summary>
        /// <remarks>
        /// Esse recurso permite gerar e enviar c\u00C3\u00B3digos de seguran\u00C3\u00A7a por sms, para valida\u00C3\u00A7\u00C3\u00A3o de dispositivos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>string</returns>
        string GerarTokenSMSUsingPOST (CodigoSegurancaSMSPersist persist);
  
        /// <summary>
        /// Gerar c\u00C3\u00B3digo de seguran\u00C3\u00A7a e enviar por sms
        /// </summary>
        /// <remarks>
        /// Esse recurso permite gerar e enviar c\u00C3\u00B3digos de seguran\u00C3\u00A7a por sms, para valida\u00C3\u00A7\u00C3\u00A3o de dispositivos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> GerarTokenSMSUsingPOSTWithHttpInfo (CodigoSegurancaSMSPersist persist);
        
        /// <summary>
        /// Lista configura\u00C3\u00A7\u00C3\u00B5es de E-mails
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar as configura\u00C3\u00A7\u00C3\u00B5es de E-mails.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageConfiguracaoEmailResponse</returns>
        PageConfiguracaoEmailResponse ListarConfiguracaoUsingGET (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista configura\u00C3\u00A7\u00C3\u00B5es de E-mails
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar as configura\u00C3\u00A7\u00C3\u00B5es de E-mails.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageConfiguracaoEmailResponse</returns>
        ApiResponse<PageConfiguracaoEmailResponse> ListarConfiguracaoUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os c\u00C3\u00B3digos de seguran\u00C3\u00A7a E-Mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os codigos de seguran\u00C3\u00A7a por E-Mail.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageCodigoSegurancaResponse</returns>
        PageCodigoSegurancaResponse ListarPorEmailUsingGET (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista os c\u00C3\u00B3digos de seguran\u00C3\u00A7a E-Mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os codigos de seguran\u00C3\u00A7a por E-Mail.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageCodigoSegurancaResponse</returns>
        ApiResponse<PageCodigoSegurancaResponse> ListarPorEmailUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os c\u00C3\u00B3digos de seguran\u00C3\u00A7a SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os codigos de seguran\u00C3\u00A7a por SMS.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageCodigoSegurancaResponse</returns>
        PageCodigoSegurancaResponse ListarPorSMSUsingGET (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista os c\u00C3\u00B3digos de seguran\u00C3\u00A7a SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os codigos de seguran\u00C3\u00A7a por SMS.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageCodigoSegurancaResponse</returns>
        ApiResponse<PageCodigoSegurancaResponse> ListarPorSMSUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar Push
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os Pushes do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataEnvio">Apresenta a data e em que o registro foi enviado para o dispositivo. (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="plataforma">Plataforma de Push notifications. (optional)</param>
        /// <param name="protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es (optional)</param>
        /// <returns>PagePushResponse</returns>
        PagePushResponse ListarPushUsingGET (List<string> sort = null, int? page = null, int? limit = null, string dataEnvio = null, string tipoEvento = null, string status = null, string plataforma = null, string protocolo = null);
  
        /// <summary>
        /// Listar Push
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os Pushes do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataEnvio">Apresenta a data e em que o registro foi enviado para o dispositivo. (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="plataforma">Plataforma de Push notifications. (optional)</param>
        /// <param name="protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es (optional)</param>
        /// <returns>ApiResponse of PagePushResponse</returns>
        ApiResponse<PagePushResponse> ListarPushUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataEnvio = null, string tipoEvento = null, string status = null, string plataforma = null, string protocolo = null);
        
        /// <summary>
        /// Listar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os SMS do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataInclusao">Apresenta a data e em que o registro foi inclu\u00C3\u00ADdo na base para ser enviado (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="operadora">Nome da operadora a qual a notifica\u00C3\u00A7\u00C3\u00A3o foi enviada. (optional)</param>
        /// <param name="protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es (optional)</param>
        /// <param name="nsu">Apresenta o nsu da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <returns>PageSMSResponse</returns>
        PageSMSResponse ListarSMSUsingGET (List<string> sort = null, int? page = null, int? limit = null, string dataInclusao = null, string tipoEvento = null, string status = null, string operadora = null, string protocolo = null, long? nsu = null);
  
        /// <summary>
        /// Listar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os SMS do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataInclusao">Apresenta a data e em que o registro foi inclu\u00C3\u00ADdo na base para ser enviado (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="operadora">Nome da operadora a qual a notifica\u00C3\u00A7\u00C3\u00A3o foi enviada. (optional)</param>
        /// <param name="protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es (optional)</param>
        /// <param name="nsu">Apresenta o nsu da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <returns>ApiResponse of PageSMSResponse</returns>
        ApiResponse<PageSMSResponse> ListarSMSUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataInclusao = null, string tipoEvento = null, string status = null, string operadora = null, string protocolo = null, long? nsu = null);
        
        /// <summary>
        /// Lista templates de notifica\u00C3\u00A7\u00C3\u00B5es
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar templates notifica\u00C3\u00A7\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageTemplateNotificacaoResponse</returns>
        PageTemplateNotificacaoResponse ListarTemplateNotificacaoUsingGET (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista templates de notifica\u00C3\u00A7\u00C3\u00B5es
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar templates notifica\u00C3\u00A7\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageTemplateNotificacaoResponse</returns>
        ApiResponse<PageTemplateNotificacaoResponse> ListarTemplateNotificacaoUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os tipos templates de notifica\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os tipos de templates dispon\u00C3\u00ADveis os par\u00C3\u00A2metros devem ser usados entre chaves. Ex: {{nomeParametro}} .
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        List<Object> ListarTiposLayoutsUsingGET ();
  
        /// <summary>
        /// Lista os tipos templates de notifica\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os tipos de templates dispon\u00C3\u00ADveis os par\u00C3\u00A2metros devem ser usados entre chaves. Ex: {{nomeParametro}} .
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        ApiResponse<List<Object>> ListarTiposLayoutsUsingGETWithHttpInfo ();
        
        /// <summary>
        /// Enviar notifica\u00C3\u00A7\u00C3\u00A3o por email
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar uma mensagem de notifica\u00C3\u00A7\u00C3\u00A3o por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Object</returns>
        Object NotificacaoEmailUsingPOST (NotificacaoEmailRequest request);
  
        /// <summary>
        /// Enviar notifica\u00C3\u00A7\u00C3\u00A3o por email
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar uma mensagem de notifica\u00C3\u00A7\u00C3\u00A3o por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> NotificacaoEmailUsingPOSTWithHttpInfo (NotificacaoEmailRequest request);
        
        /// <summary>
        /// Reenviar c\u00C3\u00B3digo de seguran\u00C3\u00A7a por sms
        /// </summary>
        /// <remarks>
        /// Esse recurso permite que seja reenviado para um determinado n\u00C3\u00BAmero de telefone, atrav\u00C3\u00A9s de SMS, o c\u00C3\u00B3digo de seguran\u00C3\u00A7a gerado previamente para ele. Caso o c\u00C3\u00B3digo de seguran\u00C3\u00A7a j\u00C3\u00A1 n\u00C3\u00A3o esteja mais v\u00C3\u00A1lido, o recurso retornar\u00C3\u00A1 uma mensagem orientando que seja solicitada uma nova gera\u00C3\u00A7\u00C3\u00A3o para o telefone em quest\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>string</returns>
        string ReenviarTokenSMSUsingPOST (CodigoSegurancaSMSPersist persist);
  
        /// <summary>
        /// Reenviar c\u00C3\u00B3digo de seguran\u00C3\u00A7a por sms
        /// </summary>
        /// <remarks>
        /// Esse recurso permite que seja reenviado para um determinado n\u00C3\u00BAmero de telefone, atrav\u00C3\u00A9s de SMS, o c\u00C3\u00B3digo de seguran\u00C3\u00A7a gerado previamente para ele. Caso o c\u00C3\u00B3digo de seguran\u00C3\u00A7a j\u00C3\u00A1 n\u00C3\u00A3o esteja mais v\u00C3\u00A1lido, o recurso retornar\u00C3\u00A1 uma mensagem orientando que seja solicitada uma nova gera\u00C3\u00A7\u00C3\u00A3o para o telefone em quest\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ReenviarTokenSMSUsingPOSTWithHttpInfo (CodigoSegurancaSMSPersist persist);
        
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
        /// <returns>NotificacaoSMSResponse</returns>
        NotificacaoSMSResponse ResponderSMSGetUsingGET (string nsu = null, string data = null, string resposta = null);
  
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
        /// <returns>ApiResponse of NotificacaoSMSResponse</returns>
        ApiResponse<NotificacaoSMSResponse> ResponderSMSGetUsingGETWithHttpInfo (string nsu = null, string data = null, string resposta = null);
        
        /// <summary>
        /// Salva configura\u00C3\u00A7\u00C3\u00B5es de E-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso salvar configura\u00C3\u00A7\u00C3\u00B5es de E-mail.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ConfiguracaoEmailResponse</returns>
        ConfiguracaoEmailResponse SalvarConfiguracaoUsingPOST (ConfiguracaoEmailPersist persist);
  
        /// <summary>
        /// Salva configura\u00C3\u00A7\u00C3\u00B5es de E-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso salvar configura\u00C3\u00A7\u00C3\u00B5es de E-mail.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of ConfiguracaoEmailResponse</returns>
        ApiResponse<ConfiguracaoEmailResponse> SalvarConfiguracaoUsingPOSTWithHttpInfo (ConfiguracaoEmailPersist persist);
        
        /// <summary>
        /// Enviar Push FCM
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma FCM (Firebase Cloud Messaging).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>NotificacaoResponse</returns>
        NotificacaoResponse SalvarPushFCMUsingPOST (List<PushFCMEGCM> pushPersists);
  
        /// <summary>
        /// Enviar Push FCM
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma FCM (Firebase Cloud Messaging).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>ApiResponse of NotificacaoResponse</returns>
        ApiResponse<NotificacaoResponse> SalvarPushFCMUsingPOSTWithHttpInfo (List<PushFCMEGCM> pushPersists);
        
        /// <summary>
        /// Enviar Push GCM
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma GCM (Google Cloud Messaging).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>NotificacaoResponse</returns>
        NotificacaoResponse SalvarPushGCMUsingPOST (List<PushFCMEGCM> pushPersists);
  
        /// <summary>
        /// Enviar Push GCM
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma GCM (Google Cloud Messaging).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>ApiResponse of NotificacaoResponse</returns>
        ApiResponse<NotificacaoResponse> SalvarPushGCMUsingPOSTWithHttpInfo (List<PushFCMEGCM> pushPersists);
        
        /// <summary>
        /// Enviar Push APNS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma APNS (Apple Push Notification Service).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>NotificacaoResponse</returns>
        NotificacaoResponse SalvarPushUsingPOST (List<PushAPNS> pushPersists);
  
        /// <summary>
        /// Enviar Push APNS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma APNS (Apple Push Notification Service).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>ApiResponse of NotificacaoResponse</returns>
        ApiResponse<NotificacaoResponse> SalvarPushUsingPOSTWithHttpInfo (List<PushAPNS> pushPersists);
        
        /// <summary>
        /// Enviar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar uma lista de SMS.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listaSMS">listaSMS</param>
        /// <returns>NotificacaoResponse</returns>
        NotificacaoResponse SalvarSMSUsingPOST (List<NotificacaoSMSBody> listaSMS);
  
        /// <summary>
        /// Enviar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar uma lista de SMS.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listaSMS">listaSMS</param>
        /// <returns>ApiResponse of NotificacaoResponse</returns>
        ApiResponse<NotificacaoResponse> SalvarSMSUsingPOSTWithHttpInfo (List<NotificacaoSMSBody> listaSMS);
        
        /// <summary>
        /// Salva template de notifica\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esse recurso salvar template notifica\u00C3\u00A7\u00C3\u00B5e.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conteudo">Template HTML</param>
        /// <param name="idConfiguracaoEmail">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da configra\u00C3\u00A7\u00C3\u00A3o de EMAIL. (optional)</param>
        /// <param name="tipoLayout">Tipo do layout. (optional)</param>
        /// <param name="tipoNotificacao">Tipo da notifica\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="remetente">Remetente (optional)</param>
        /// <param name="assunto">Assunto da Notificaca\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="templatePadrao">Template Padr\u00C3\u00A3o. (optional)</param>
        /// <returns>TemplateNotificacaoDetalheResponse</returns>
        TemplateNotificacaoDetalheResponse SalvarTemplateNotificacaoUsingPOST (string conteudo, long? idConfiguracaoEmail = null, string tipoLayout = null, string tipoNotificacao = null, string remetente = null, string assunto = null, bool? templatePadrao = null);
  
        /// <summary>
        /// Salva template de notifica\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esse recurso salvar template notifica\u00C3\u00A7\u00C3\u00B5e.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conteudo">Template HTML</param>
        /// <param name="idConfiguracaoEmail">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da configra\u00C3\u00A7\u00C3\u00A3o de EMAIL. (optional)</param>
        /// <param name="tipoLayout">Tipo do layout. (optional)</param>
        /// <param name="tipoNotificacao">Tipo da notifica\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="remetente">Remetente (optional)</param>
        /// <param name="assunto">Assunto da Notificaca\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="templatePadrao">Template Padr\u00C3\u00A3o. (optional)</param>
        /// <returns>ApiResponse of TemplateNotificacaoDetalheResponse</returns>
        ApiResponse<TemplateNotificacaoDetalheResponse> SalvarTemplateNotificacaoUsingPOSTWithHttpInfo (string conteudo, long? idConfiguracaoEmail = null, string tipoLayout = null, string tipoNotificacao = null, string remetente = null, string assunto = null, bool? templatePadrao = null);
        
        /// <summary>
        /// Validar c\u00C3\u00B3digo de seguran\u00C3\u00A7a enviado por e-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite validar os c\u00C3\u00B3digos de seguran\u00C3\u00A7a enviador por e-mail, para valida\u00C3\u00A7\u00C3\u00A3o de dispositivos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>string</returns>
        string ValidarTokenEMAILUsingPOST (CodigoSegurancaEMAILPersist request);
  
        /// <summary>
        /// Validar c\u00C3\u00B3digo de seguran\u00C3\u00A7a enviado por e-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite validar os c\u00C3\u00B3digos de seguran\u00C3\u00A7a enviador por e-mail, para valida\u00C3\u00A7\u00C3\u00A3o de dispositivos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ValidarTokenEMAILUsingPOSTWithHttpInfo (CodigoSegurancaEMAILPersist request);
        
        /// <summary>
        /// Validar c\u00C3\u00B3digo de seguran\u00C3\u00A7a enviado por sms
        /// </summary>
        /// <remarks>
        /// Esse recurso permite validar os c\u00C3\u00B3digos de seguran\u00C3\u00A7a enviador por sms, para valida\u00C3\u00A7\u00C3\u00A3o de dispositivos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>string</returns>
        string ValidarTokenSMSUsingPOST (CodigoSegurancaSMSRequest request);
  
        /// <summary>
        /// Validar c\u00C3\u00B3digo de seguran\u00C3\u00A7a enviado por sms
        /// </summary>
        /// <remarks>
        /// Esse recurso permite validar os c\u00C3\u00B3digos de seguran\u00C3\u00A7a enviador por sms, para valida\u00C3\u00A7\u00C3\u00A3o de dispositivos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ValidarTokenSMSUsingPOSTWithHttpInfo (CodigoSegurancaSMSRequest request);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Altera configura\u00C3\u00A7\u00C3\u00B5es de E-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite salvar altera\u00C3\u00A7\u00C3\u00B5es de configura\u00C3\u00A7\u00C3\u00B5es de E-mail.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de e-mail.</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ConfiguracaoEmailResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoEmailResponse> AlterarConfiguracaoUsingPUTAsync (long? id, ConfiguracaoEmailPersist persist);

        /// <summary>
        /// Altera configura\u00C3\u00A7\u00C3\u00B5es de E-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite salvar altera\u00C3\u00A7\u00C3\u00B5es de configura\u00C3\u00A7\u00C3\u00B5es de E-mail.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de e-mail.</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoEmailResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoEmailResponse>> AlterarConfiguracaoUsingPUTAsyncWithHttpInfo (long? id, ConfiguracaoEmailPersist persist);
        
        /// <summary>
        /// Alterar template de notifica\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite salvar altera\u00C3\u00A7\u00C3\u00B5es de templates notifica\u00C3\u00A7\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do layout de e-mail.</param>
        /// <param name="conteudo">Template HTML</param>
        /// <param name="idConfiguracaoEmail">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da configra\u00C3\u00A7\u00C3\u00A3o de EMAIL. (optional)</param>
        /// <param name="tipoLayout">Tipo do layout. (optional)</param>
        /// <param name="tipoNotificacao">Tipo da notifica\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="remetente">Remetente (optional)</param>
        /// <param name="assunto">Assunto da Notificaca\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="templatePadrao">Template Padr\u00C3\u00A3o. (optional)</param>
        /// <returns>Task of TemplateNotificacaoDetalheResponse</returns>
        System.Threading.Tasks.Task<TemplateNotificacaoDetalheResponse> AlterarTemplateNotificacaoUsingPUTAsync (long? id, string conteudo, long? idConfiguracaoEmail = null, string tipoLayout = null, string tipoNotificacao = null, string remetente = null, string assunto = null, bool? templatePadrao = null);

        /// <summary>
        /// Alterar template de notifica\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite salvar altera\u00C3\u00A7\u00C3\u00B5es de templates notifica\u00C3\u00A7\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do layout de e-mail.</param>
        /// <param name="conteudo">Template HTML</param>
        /// <param name="idConfiguracaoEmail">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da configra\u00C3\u00A7\u00C3\u00A3o de EMAIL. (optional)</param>
        /// <param name="tipoLayout">Tipo do layout. (optional)</param>
        /// <param name="tipoNotificacao">Tipo da notifica\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="remetente">Remetente (optional)</param>
        /// <param name="assunto">Assunto da Notificaca\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="templatePadrao">Template Padr\u00C3\u00A3o. (optional)</param>
        /// <returns>Task of ApiResponse (TemplateNotificacaoDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TemplateNotificacaoDetalheResponse>> AlterarTemplateNotificacaoUsingPUTAsyncWithHttpInfo (long? id, string conteudo, long? idConfiguracaoEmail = null, string tipoLayout = null, string tipoNotificacao = null, string remetente = null, string assunto = null, bool? templatePadrao = null);
        
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
        /// <returns>Task of NotificacaoSMSResponse</returns>
        System.Threading.Tasks.Task<NotificacaoSMSResponse> AtualizarSMSUsingPOSTAsync (string nsu = null, string status = null, string data = null, string textoStatus = null, string operadora = null);

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
        /// <returns>Task of ApiResponse (NotificacaoSMSResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<NotificacaoSMSResponse>> AtualizarSMSUsingPOSTAsyncWithHttpInfo (string nsu = null, string status = null, string data = null, string textoStatus = null, string operadora = null);
        
        /// <summary>
        /// Consulta configura\u00C3\u00A7\u00C3\u00A3o de E-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar uma configura\u00C3\u00A7\u00C3\u00A3o espec\u00C3\u00ADfica por id.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de e-mail.</param>
        /// <returns>Task of ConfiguracaoEmailResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoEmailResponse> ConsultarConfiguracaoUsingGETAsync (long? id);

        /// <summary>
        /// Consulta configura\u00C3\u00A7\u00C3\u00A3o de E-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar uma configura\u00C3\u00A7\u00C3\u00A3o espec\u00C3\u00ADfica por id.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de e-mail.</param>
        /// <returns>Task of ApiResponse (ConfiguracaoEmailResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoEmailResponse>> ConsultarConfiguracaoUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta c\u00C3\u00B3digo de seguran\u00C3\u00A7a E-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar um c\u00C3\u00B3digo de seguran\u00C3\u00A7a E-mail espec\u00C3\u00ADfico por id.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de e-mail.</param>
        /// <returns>Task of CodigoSegurancaResponse</returns>
        System.Threading.Tasks.Task<CodigoSegurancaResponse> ConsultarPorEmailUsingGETAsync (long? id);

        /// <summary>
        /// Consulta c\u00C3\u00B3digo de seguran\u00C3\u00A7a E-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar um c\u00C3\u00B3digo de seguran\u00C3\u00A7a E-mail espec\u00C3\u00ADfico por id.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de e-mail.</param>
        /// <returns>Task of ApiResponse (CodigoSegurancaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CodigoSegurancaResponse>> ConsultarPorEmailUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta c\u00C3\u00B3digo de seguran\u00C3\u00A7a SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar um c\u00C3\u00B3digo de seguran\u00C3\u00A7a SMS espec\u00C3\u00ADfico por id.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de e-mail.</param>
        /// <returns>Task of CodigoSegurancaResponse</returns>
        System.Threading.Tasks.Task<CodigoSegurancaResponse> ConsultarPorSMSUsingGETAsync (long? id);

        /// <summary>
        /// Consulta c\u00C3\u00B3digo de seguran\u00C3\u00A7a SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar um c\u00C3\u00B3digo de seguran\u00C3\u00A7a SMS espec\u00C3\u00ADfico por id.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de e-mail.</param>
        /// <returns>Task of ApiResponse (CodigoSegurancaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CodigoSegurancaResponse>> ConsultarPorSMSUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta template de notifica\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar uma configura\u00C3\u00A7\u00C3\u00A3o espec\u00C3\u00ADfica por id.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do layout de e-mail.</param>
        /// <returns>Task of TemplateNotificacaoDetalheResponse</returns>
        System.Threading.Tasks.Task<TemplateNotificacaoDetalheResponse> ConsultarTemplateNotificacaoUsingGETAsync (long? id);

        /// <summary>
        /// Consulta template de notifica\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar uma configura\u00C3\u00A7\u00C3\u00A3o espec\u00C3\u00ADfica por id.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do layout de e-mail.</param>
        /// <returns>Task of ApiResponse (TemplateNotificacaoDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TemplateNotificacaoDetalheResponse>> ConsultarTemplateNotificacaoUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Gerar c\u00C3\u00B3digo de seguran\u00C3\u00A7a e enviar por e-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite gerar e enviar c\u00C3\u00B3digos de seguran\u00C3\u00A7a por e-mail, para valida\u00C3\u00A7\u00C3\u00A3o de dispositivos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">email</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> GerarTokenEMAILUsingPOSTAsync (string email);

        /// <summary>
        /// Gerar c\u00C3\u00B3digo de seguran\u00C3\u00A7a e enviar por e-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite gerar e enviar c\u00C3\u00B3digos de seguran\u00C3\u00A7a por e-mail, para valida\u00C3\u00A7\u00C3\u00A3o de dispositivos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">email</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> GerarTokenEMAILUsingPOSTAsyncWithHttpInfo (string email);
        
        /// <summary>
        /// Gerar c\u00C3\u00B3digo de seguran\u00C3\u00A7a e enviar por sms
        /// </summary>
        /// <remarks>
        /// Esse recurso permite gerar e enviar c\u00C3\u00B3digos de seguran\u00C3\u00A7a por sms, para valida\u00C3\u00A7\u00C3\u00A3o de dispositivos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> GerarTokenSMSUsingPOSTAsync (CodigoSegurancaSMSPersist persist);

        /// <summary>
        /// Gerar c\u00C3\u00B3digo de seguran\u00C3\u00A7a e enviar por sms
        /// </summary>
        /// <remarks>
        /// Esse recurso permite gerar e enviar c\u00C3\u00B3digos de seguran\u00C3\u00A7a por sms, para valida\u00C3\u00A7\u00C3\u00A3o de dispositivos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> GerarTokenSMSUsingPOSTAsyncWithHttpInfo (CodigoSegurancaSMSPersist persist);
        
        /// <summary>
        /// Lista configura\u00C3\u00A7\u00C3\u00B5es de E-mails
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar as configura\u00C3\u00A7\u00C3\u00B5es de E-mails.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageConfiguracaoEmailResponse</returns>
        System.Threading.Tasks.Task<PageConfiguracaoEmailResponse> ListarConfiguracaoUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista configura\u00C3\u00A7\u00C3\u00B5es de E-mails
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar as configura\u00C3\u00A7\u00C3\u00B5es de E-mails.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageConfiguracaoEmailResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageConfiguracaoEmailResponse>> ListarConfiguracaoUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os c\u00C3\u00B3digos de seguran\u00C3\u00A7a E-Mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os codigos de seguran\u00C3\u00A7a por E-Mail.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageCodigoSegurancaResponse</returns>
        System.Threading.Tasks.Task<PageCodigoSegurancaResponse> ListarPorEmailUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista os c\u00C3\u00B3digos de seguran\u00C3\u00A7a E-Mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os codigos de seguran\u00C3\u00A7a por E-Mail.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCodigoSegurancaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCodigoSegurancaResponse>> ListarPorEmailUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os c\u00C3\u00B3digos de seguran\u00C3\u00A7a SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os codigos de seguran\u00C3\u00A7a por SMS.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageCodigoSegurancaResponse</returns>
        System.Threading.Tasks.Task<PageCodigoSegurancaResponse> ListarPorSMSUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista os c\u00C3\u00B3digos de seguran\u00C3\u00A7a SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os codigos de seguran\u00C3\u00A7a por SMS.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCodigoSegurancaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCodigoSegurancaResponse>> ListarPorSMSUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar Push
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os Pushes do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataEnvio">Apresenta a data e em que o registro foi enviado para o dispositivo. (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="plataforma">Plataforma de Push notifications. (optional)</param>
        /// <param name="protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es (optional)</param>
        /// <returns>Task of PagePushResponse</returns>
        System.Threading.Tasks.Task<PagePushResponse> ListarPushUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, string dataEnvio = null, string tipoEvento = null, string status = null, string plataforma = null, string protocolo = null);

        /// <summary>
        /// Listar Push
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os Pushes do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataEnvio">Apresenta a data e em que o registro foi enviado para o dispositivo. (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="plataforma">Plataforma de Push notifications. (optional)</param>
        /// <param name="protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es (optional)</param>
        /// <returns>Task of ApiResponse (PagePushResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePushResponse>> ListarPushUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataEnvio = null, string tipoEvento = null, string status = null, string plataforma = null, string protocolo = null);
        
        /// <summary>
        /// Listar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os SMS do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataInclusao">Apresenta a data e em que o registro foi inclu\u00C3\u00ADdo na base para ser enviado (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="operadora">Nome da operadora a qual a notifica\u00C3\u00A7\u00C3\u00A3o foi enviada. (optional)</param>
        /// <param name="protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es (optional)</param>
        /// <param name="nsu">Apresenta o nsu da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <returns>Task of PageSMSResponse</returns>
        System.Threading.Tasks.Task<PageSMSResponse> ListarSMSUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, string dataInclusao = null, string tipoEvento = null, string status = null, string operadora = null, string protocolo = null, long? nsu = null);

        /// <summary>
        /// Listar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os SMS do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataInclusao">Apresenta a data e em que o registro foi inclu\u00C3\u00ADdo na base para ser enviado (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="operadora">Nome da operadora a qual a notifica\u00C3\u00A7\u00C3\u00A3o foi enviada. (optional)</param>
        /// <param name="protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es (optional)</param>
        /// <param name="nsu">Apresenta o nsu da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <returns>Task of ApiResponse (PageSMSResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageSMSResponse>> ListarSMSUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataInclusao = null, string tipoEvento = null, string status = null, string operadora = null, string protocolo = null, long? nsu = null);
        
        /// <summary>
        /// Lista templates de notifica\u00C3\u00A7\u00C3\u00B5es
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar templates notifica\u00C3\u00A7\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageTemplateNotificacaoResponse</returns>
        System.Threading.Tasks.Task<PageTemplateNotificacaoResponse> ListarTemplateNotificacaoUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista templates de notifica\u00C3\u00A7\u00C3\u00B5es
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar templates notifica\u00C3\u00A7\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTemplateNotificacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTemplateNotificacaoResponse>> ListarTemplateNotificacaoUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os tipos templates de notifica\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os tipos de templates dispon\u00C3\u00ADveis os par\u00C3\u00A2metros devem ser usados entre chaves. Ex: {{nomeParametro}} .
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Object&gt;</returns>
        System.Threading.Tasks.Task<List<Object>> ListarTiposLayoutsUsingGETAsync ();

        /// <summary>
        /// Lista os tipos templates de notifica\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os tipos de templates dispon\u00C3\u00ADveis os par\u00C3\u00A2metros devem ser usados entre chaves. Ex: {{nomeParametro}} .
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Object>>> ListarTiposLayoutsUsingGETAsyncWithHttpInfo ();
        
        /// <summary>
        /// Enviar notifica\u00C3\u00A7\u00C3\u00A3o por email
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar uma mensagem de notifica\u00C3\u00A7\u00C3\u00A3o por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> NotificacaoEmailUsingPOSTAsync (NotificacaoEmailRequest request);

        /// <summary>
        /// Enviar notifica\u00C3\u00A7\u00C3\u00A3o por email
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar uma mensagem de notifica\u00C3\u00A7\u00C3\u00A3o por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> NotificacaoEmailUsingPOSTAsyncWithHttpInfo (NotificacaoEmailRequest request);
        
        /// <summary>
        /// Reenviar c\u00C3\u00B3digo de seguran\u00C3\u00A7a por sms
        /// </summary>
        /// <remarks>
        /// Esse recurso permite que seja reenviado para um determinado n\u00C3\u00BAmero de telefone, atrav\u00C3\u00A9s de SMS, o c\u00C3\u00B3digo de seguran\u00C3\u00A7a gerado previamente para ele. Caso o c\u00C3\u00B3digo de seguran\u00C3\u00A7a j\u00C3\u00A1 n\u00C3\u00A3o esteja mais v\u00C3\u00A1lido, o recurso retornar\u00C3\u00A1 uma mensagem orientando que seja solicitada uma nova gera\u00C3\u00A7\u00C3\u00A3o para o telefone em quest\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ReenviarTokenSMSUsingPOSTAsync (CodigoSegurancaSMSPersist persist);

        /// <summary>
        /// Reenviar c\u00C3\u00B3digo de seguran\u00C3\u00A7a por sms
        /// </summary>
        /// <remarks>
        /// Esse recurso permite que seja reenviado para um determinado n\u00C3\u00BAmero de telefone, atrav\u00C3\u00A9s de SMS, o c\u00C3\u00B3digo de seguran\u00C3\u00A7a gerado previamente para ele. Caso o c\u00C3\u00B3digo de seguran\u00C3\u00A7a j\u00C3\u00A1 n\u00C3\u00A3o esteja mais v\u00C3\u00A1lido, o recurso retornar\u00C3\u00A1 uma mensagem orientando que seja solicitada uma nova gera\u00C3\u00A7\u00C3\u00A3o para o telefone em quest\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ReenviarTokenSMSUsingPOSTAsyncWithHttpInfo (CodigoSegurancaSMSPersist persist);
        
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
        /// <returns>Task of NotificacaoSMSResponse</returns>
        System.Threading.Tasks.Task<NotificacaoSMSResponse> ResponderSMSGetUsingGETAsync (string nsu = null, string data = null, string resposta = null);

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
        /// <returns>Task of ApiResponse (NotificacaoSMSResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<NotificacaoSMSResponse>> ResponderSMSGetUsingGETAsyncWithHttpInfo (string nsu = null, string data = null, string resposta = null);
        
        /// <summary>
        /// Salva configura\u00C3\u00A7\u00C3\u00B5es de E-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso salvar configura\u00C3\u00A7\u00C3\u00B5es de E-mail.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ConfiguracaoEmailResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoEmailResponse> SalvarConfiguracaoUsingPOSTAsync (ConfiguracaoEmailPersist persist);

        /// <summary>
        /// Salva configura\u00C3\u00A7\u00C3\u00B5es de E-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso salvar configura\u00C3\u00A7\u00C3\u00B5es de E-mail.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoEmailResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoEmailResponse>> SalvarConfiguracaoUsingPOSTAsyncWithHttpInfo (ConfiguracaoEmailPersist persist);
        
        /// <summary>
        /// Enviar Push FCM
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma FCM (Firebase Cloud Messaging).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of NotificacaoResponse</returns>
        System.Threading.Tasks.Task<NotificacaoResponse> SalvarPushFCMUsingPOSTAsync (List<PushFCMEGCM> pushPersists);

        /// <summary>
        /// Enviar Push FCM
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma FCM (Firebase Cloud Messaging).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of ApiResponse (NotificacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<NotificacaoResponse>> SalvarPushFCMUsingPOSTAsyncWithHttpInfo (List<PushFCMEGCM> pushPersists);
        
        /// <summary>
        /// Enviar Push GCM
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma GCM (Google Cloud Messaging).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of NotificacaoResponse</returns>
        System.Threading.Tasks.Task<NotificacaoResponse> SalvarPushGCMUsingPOSTAsync (List<PushFCMEGCM> pushPersists);

        /// <summary>
        /// Enviar Push GCM
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma GCM (Google Cloud Messaging).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of ApiResponse (NotificacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<NotificacaoResponse>> SalvarPushGCMUsingPOSTAsyncWithHttpInfo (List<PushFCMEGCM> pushPersists);
        
        /// <summary>
        /// Enviar Push APNS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma APNS (Apple Push Notification Service).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of NotificacaoResponse</returns>
        System.Threading.Tasks.Task<NotificacaoResponse> SalvarPushUsingPOSTAsync (List<PushAPNS> pushPersists);

        /// <summary>
        /// Enviar Push APNS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma APNS (Apple Push Notification Service).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of ApiResponse (NotificacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<NotificacaoResponse>> SalvarPushUsingPOSTAsyncWithHttpInfo (List<PushAPNS> pushPersists);
        
        /// <summary>
        /// Enviar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar uma lista de SMS.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listaSMS">listaSMS</param>
        /// <returns>Task of NotificacaoResponse</returns>
        System.Threading.Tasks.Task<NotificacaoResponse> SalvarSMSUsingPOSTAsync (List<NotificacaoSMSBody> listaSMS);

        /// <summary>
        /// Enviar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar uma lista de SMS.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listaSMS">listaSMS</param>
        /// <returns>Task of ApiResponse (NotificacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<NotificacaoResponse>> SalvarSMSUsingPOSTAsyncWithHttpInfo (List<NotificacaoSMSBody> listaSMS);
        
        /// <summary>
        /// Salva template de notifica\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esse recurso salvar template notifica\u00C3\u00A7\u00C3\u00B5e.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conteudo">Template HTML</param>
        /// <param name="idConfiguracaoEmail">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da configra\u00C3\u00A7\u00C3\u00A3o de EMAIL. (optional)</param>
        /// <param name="tipoLayout">Tipo do layout. (optional)</param>
        /// <param name="tipoNotificacao">Tipo da notifica\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="remetente">Remetente (optional)</param>
        /// <param name="assunto">Assunto da Notificaca\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="templatePadrao">Template Padr\u00C3\u00A3o. (optional)</param>
        /// <returns>Task of TemplateNotificacaoDetalheResponse</returns>
        System.Threading.Tasks.Task<TemplateNotificacaoDetalheResponse> SalvarTemplateNotificacaoUsingPOSTAsync (string conteudo, long? idConfiguracaoEmail = null, string tipoLayout = null, string tipoNotificacao = null, string remetente = null, string assunto = null, bool? templatePadrao = null);

        /// <summary>
        /// Salva template de notifica\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Esse recurso salvar template notifica\u00C3\u00A7\u00C3\u00B5e.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conteudo">Template HTML</param>
        /// <param name="idConfiguracaoEmail">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da configra\u00C3\u00A7\u00C3\u00A3o de EMAIL. (optional)</param>
        /// <param name="tipoLayout">Tipo do layout. (optional)</param>
        /// <param name="tipoNotificacao">Tipo da notifica\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="remetente">Remetente (optional)</param>
        /// <param name="assunto">Assunto da Notificaca\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="templatePadrao">Template Padr\u00C3\u00A3o. (optional)</param>
        /// <returns>Task of ApiResponse (TemplateNotificacaoDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TemplateNotificacaoDetalheResponse>> SalvarTemplateNotificacaoUsingPOSTAsyncWithHttpInfo (string conteudo, long? idConfiguracaoEmail = null, string tipoLayout = null, string tipoNotificacao = null, string remetente = null, string assunto = null, bool? templatePadrao = null);
        
        /// <summary>
        /// Validar c\u00C3\u00B3digo de seguran\u00C3\u00A7a enviado por e-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite validar os c\u00C3\u00B3digos de seguran\u00C3\u00A7a enviador por e-mail, para valida\u00C3\u00A7\u00C3\u00A3o de dispositivos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ValidarTokenEMAILUsingPOSTAsync (CodigoSegurancaEMAILPersist request);

        /// <summary>
        /// Validar c\u00C3\u00B3digo de seguran\u00C3\u00A7a enviado por e-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite validar os c\u00C3\u00B3digos de seguran\u00C3\u00A7a enviador por e-mail, para valida\u00C3\u00A7\u00C3\u00A3o de dispositivos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ValidarTokenEMAILUsingPOSTAsyncWithHttpInfo (CodigoSegurancaEMAILPersist request);
        
        /// <summary>
        /// Validar c\u00C3\u00B3digo de seguran\u00C3\u00A7a enviado por sms
        /// </summary>
        /// <remarks>
        /// Esse recurso permite validar os c\u00C3\u00B3digos de seguran\u00C3\u00A7a enviador por sms, para valida\u00C3\u00A7\u00C3\u00A3o de dispositivos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ValidarTokenSMSUsingPOSTAsync (CodigoSegurancaSMSRequest request);

        /// <summary>
        /// Validar c\u00C3\u00B3digo de seguran\u00C3\u00A7a enviado por sms
        /// </summary>
        /// <remarks>
        /// Esse recurso permite validar os c\u00C3\u00B3digos de seguran\u00C3\u00A7a enviador por sms, para valida\u00C3\u00A7\u00C3\u00A3o de dispositivos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ValidarTokenSMSUsingPOSTAsyncWithHttpInfo (CodigoSegurancaSMSRequest request);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class NotificacaoApi : INotificacaoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificacaoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NotificacaoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificacaoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public NotificacaoApi(Configuration configuration = null)
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
        /// Altera configura\u00C3\u00A7\u00C3\u00B5es de E-mail Esse recurso permite salvar altera\u00C3\u00A7\u00C3\u00B5es de configura\u00C3\u00A7\u00C3\u00B5es de E-mail.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de e-mail.</param> 
        /// <param name="persist">persist</param> 
        /// <returns>ConfiguracaoEmailResponse</returns>
        public ConfiguracaoEmailResponse AlterarConfiguracaoUsingPUT (long? id, ConfiguracaoEmailPersist persist)
        {
             ApiResponse<ConfiguracaoEmailResponse> localVarResponse = AlterarConfiguracaoUsingPUTWithHttpInfo(id, persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera configura\u00C3\u00A7\u00C3\u00B5es de E-mail Esse recurso permite salvar altera\u00C3\u00A7\u00C3\u00B5es de configura\u00C3\u00A7\u00C3\u00B5es de E-mail.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de e-mail.</param> 
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of ConfiguracaoEmailResponse</returns>
        public ApiResponse< ConfiguracaoEmailResponse > AlterarConfiguracaoUsingPUTWithHttpInfo (long? id, ConfiguracaoEmailPersist persist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling NotificacaoApi->AlterarConfiguracaoUsingPUT");
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling NotificacaoApi->AlterarConfiguracaoUsingPUT");
            
    
            var localVarPath = "/api/configuracoes-email/{id}";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarConfiguracaoUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarConfiguracaoUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConfiguracaoEmailResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoEmailResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoEmailResponse)));
            
        }

        
        /// <summary>
        /// Altera configura\u00C3\u00A7\u00C3\u00B5es de E-mail Esse recurso permite salvar altera\u00C3\u00A7\u00C3\u00B5es de configura\u00C3\u00A7\u00C3\u00B5es de E-mail.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de e-mail.</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ConfiguracaoEmailResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoEmailResponse> AlterarConfiguracaoUsingPUTAsync (long? id, ConfiguracaoEmailPersist persist)
        {
             ApiResponse<ConfiguracaoEmailResponse> localVarResponse = await AlterarConfiguracaoUsingPUTAsyncWithHttpInfo(id, persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera configura\u00C3\u00A7\u00C3\u00B5es de E-mail Esse recurso permite salvar altera\u00C3\u00A7\u00C3\u00B5es de configura\u00C3\u00A7\u00C3\u00B5es de E-mail.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de e-mail.</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoEmailResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfiguracaoEmailResponse>> AlterarConfiguracaoUsingPUTAsyncWithHttpInfo (long? id, ConfiguracaoEmailPersist persist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarConfiguracaoUsingPUT");
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling AlterarConfiguracaoUsingPUT");
            
    
            var localVarPath = "/api/configuracoes-email/{id}";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarConfiguracaoUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarConfiguracaoUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfiguracaoEmailResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoEmailResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoEmailResponse)));
            
        }
        
        /// <summary>
        /// Alterar template de notifica\u00C3\u00A7\u00C3\u00A3o Esse recurso permite salvar altera\u00C3\u00A7\u00C3\u00B5es de templates notifica\u00C3\u00A7\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do layout de e-mail.</param> 
        /// <param name="conteudo">Template HTML</param> 
        /// <param name="idConfiguracaoEmail">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da configra\u00C3\u00A7\u00C3\u00A3o de EMAIL. (optional)</param> 
        /// <param name="tipoLayout">Tipo do layout. (optional)</param> 
        /// <param name="tipoNotificacao">Tipo da notifica\u00C3\u00A7\u00C3\u00A3o. (optional)</param> 
        /// <param name="remetente">Remetente (optional)</param> 
        /// <param name="assunto">Assunto da Notificaca\u00C3\u00A7\u00C3\u00A3o. (optional)</param> 
        /// <param name="templatePadrao">Template Padr\u00C3\u00A3o. (optional)</param> 
        /// <returns>TemplateNotificacaoDetalheResponse</returns>
        public TemplateNotificacaoDetalheResponse AlterarTemplateNotificacaoUsingPUT (long? id, string conteudo, long? idConfiguracaoEmail = null, string tipoLayout = null, string tipoNotificacao = null, string remetente = null, string assunto = null, bool? templatePadrao = null)
        {
             ApiResponse<TemplateNotificacaoDetalheResponse> localVarResponse = AlterarTemplateNotificacaoUsingPUTWithHttpInfo(id, conteudo, idConfiguracaoEmail, tipoLayout, tipoNotificacao, remetente, assunto, templatePadrao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar template de notifica\u00C3\u00A7\u00C3\u00A3o Esse recurso permite salvar altera\u00C3\u00A7\u00C3\u00B5es de templates notifica\u00C3\u00A7\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do layout de e-mail.</param> 
        /// <param name="conteudo">Template HTML</param> 
        /// <param name="idConfiguracaoEmail">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da configra\u00C3\u00A7\u00C3\u00A3o de EMAIL. (optional)</param> 
        /// <param name="tipoLayout">Tipo do layout. (optional)</param> 
        /// <param name="tipoNotificacao">Tipo da notifica\u00C3\u00A7\u00C3\u00A3o. (optional)</param> 
        /// <param name="remetente">Remetente (optional)</param> 
        /// <param name="assunto">Assunto da Notificaca\u00C3\u00A7\u00C3\u00A3o. (optional)</param> 
        /// <param name="templatePadrao">Template Padr\u00C3\u00A3o. (optional)</param> 
        /// <returns>ApiResponse of TemplateNotificacaoDetalheResponse</returns>
        public ApiResponse< TemplateNotificacaoDetalheResponse > AlterarTemplateNotificacaoUsingPUTWithHttpInfo (long? id, string conteudo, long? idConfiguracaoEmail = null, string tipoLayout = null, string tipoNotificacao = null, string remetente = null, string assunto = null, bool? templatePadrao = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling NotificacaoApi->AlterarTemplateNotificacaoUsingPUT");
            
            // verify the required parameter 'conteudo' is set
            if (conteudo == null)
                throw new ApiException(400, "Missing required parameter 'conteudo' when calling NotificacaoApi->AlterarTemplateNotificacaoUsingPUT");
            
    
            var localVarPath = "/api/templates-notificacoes/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "text/plain"
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
            
            if (idConfiguracaoEmail != null) localVarQueryParams.Add("idConfiguracaoEmail", Configuration.ApiClient.ParameterToString(idConfiguracaoEmail)); // query parameter
            if (tipoLayout != null) localVarQueryParams.Add("tipoLayout", Configuration.ApiClient.ParameterToString(tipoLayout)); // query parameter
            if (tipoNotificacao != null) localVarQueryParams.Add("tipoNotificacao", Configuration.ApiClient.ParameterToString(tipoNotificacao)); // query parameter
            if (remetente != null) localVarQueryParams.Add("remetente", Configuration.ApiClient.ParameterToString(remetente)); // query parameter
            if (assunto != null) localVarQueryParams.Add("assunto", Configuration.ApiClient.ParameterToString(assunto)); // query parameter
            if (templatePadrao != null) localVarQueryParams.Add("templatePadrao", Configuration.ApiClient.ParameterToString(templatePadrao)); // query parameter
            
            
            
            if (conteudo.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(conteudo); // http body (model) parameter
            }
            else
            {
                localVarPostBody = conteudo; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTemplateNotificacaoUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTemplateNotificacaoUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TemplateNotificacaoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateNotificacaoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TemplateNotificacaoDetalheResponse)));
            
        }

        
        /// <summary>
        /// Alterar template de notifica\u00C3\u00A7\u00C3\u00A3o Esse recurso permite salvar altera\u00C3\u00A7\u00C3\u00B5es de templates notifica\u00C3\u00A7\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do layout de e-mail.</param>
        /// <param name="conteudo">Template HTML</param>
        /// <param name="idConfiguracaoEmail">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da configra\u00C3\u00A7\u00C3\u00A3o de EMAIL. (optional)</param>
        /// <param name="tipoLayout">Tipo do layout. (optional)</param>
        /// <param name="tipoNotificacao">Tipo da notifica\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="remetente">Remetente (optional)</param>
        /// <param name="assunto">Assunto da Notificaca\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="templatePadrao">Template Padr\u00C3\u00A3o. (optional)</param>
        /// <returns>Task of TemplateNotificacaoDetalheResponse</returns>
        public async System.Threading.Tasks.Task<TemplateNotificacaoDetalheResponse> AlterarTemplateNotificacaoUsingPUTAsync (long? id, string conteudo, long? idConfiguracaoEmail = null, string tipoLayout = null, string tipoNotificacao = null, string remetente = null, string assunto = null, bool? templatePadrao = null)
        {
             ApiResponse<TemplateNotificacaoDetalheResponse> localVarResponse = await AlterarTemplateNotificacaoUsingPUTAsyncWithHttpInfo(id, conteudo, idConfiguracaoEmail, tipoLayout, tipoNotificacao, remetente, assunto, templatePadrao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Alterar template de notifica\u00C3\u00A7\u00C3\u00A3o Esse recurso permite salvar altera\u00C3\u00A7\u00C3\u00B5es de templates notifica\u00C3\u00A7\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do layout de e-mail.</param>
        /// <param name="conteudo">Template HTML</param>
        /// <param name="idConfiguracaoEmail">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da configra\u00C3\u00A7\u00C3\u00A3o de EMAIL. (optional)</param>
        /// <param name="tipoLayout">Tipo do layout. (optional)</param>
        /// <param name="tipoNotificacao">Tipo da notifica\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="remetente">Remetente (optional)</param>
        /// <param name="assunto">Assunto da Notificaca\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="templatePadrao">Template Padr\u00C3\u00A3o. (optional)</param>
        /// <returns>Task of ApiResponse (TemplateNotificacaoDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TemplateNotificacaoDetalheResponse>> AlterarTemplateNotificacaoUsingPUTAsyncWithHttpInfo (long? id, string conteudo, long? idConfiguracaoEmail = null, string tipoLayout = null, string tipoNotificacao = null, string remetente = null, string assunto = null, bool? templatePadrao = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarTemplateNotificacaoUsingPUT");
            // verify the required parameter 'conteudo' is set
            if (conteudo == null) throw new ApiException(400, "Missing required parameter 'conteudo' when calling AlterarTemplateNotificacaoUsingPUT");
            
    
            var localVarPath = "/api/templates-notificacoes/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "text/plain"
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
            
            if (idConfiguracaoEmail != null) localVarQueryParams.Add("idConfiguracaoEmail", Configuration.ApiClient.ParameterToString(idConfiguracaoEmail)); // query parameter
            if (tipoLayout != null) localVarQueryParams.Add("tipoLayout", Configuration.ApiClient.ParameterToString(tipoLayout)); // query parameter
            if (tipoNotificacao != null) localVarQueryParams.Add("tipoNotificacao", Configuration.ApiClient.ParameterToString(tipoNotificacao)); // query parameter
            if (remetente != null) localVarQueryParams.Add("remetente", Configuration.ApiClient.ParameterToString(remetente)); // query parameter
            if (assunto != null) localVarQueryParams.Add("assunto", Configuration.ApiClient.ParameterToString(assunto)); // query parameter
            if (templatePadrao != null) localVarQueryParams.Add("templatePadrao", Configuration.ApiClient.ParameterToString(templatePadrao)); // query parameter
            
            
            
            if (conteudo.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(conteudo); // http body (model) parameter
            }
            else
            {
                localVarPostBody = conteudo; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTemplateNotificacaoUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTemplateNotificacaoUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TemplateNotificacaoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateNotificacaoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TemplateNotificacaoDetalheResponse)));
            
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
        /// <returns>NotificacaoSMSResponse</returns>
        public NotificacaoSMSResponse AtualizarSMSUsingPOST (string nsu = null, string status = null, string data = null, string textoStatus = null, string operadora = null)
        {
             ApiResponse<NotificacaoSMSResponse> localVarResponse = AtualizarSMSUsingPOSTWithHttpInfo(nsu, status, data, textoStatus, operadora);
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
        /// <returns>ApiResponse of NotificacaoSMSResponse</returns>
        public ApiResponse< NotificacaoSMSResponse > AtualizarSMSUsingPOSTWithHttpInfo (string nsu = null, string status = null, string data = null, string textoStatus = null, string operadora = null)
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarSMSUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarSMSUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<NotificacaoSMSResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificacaoSMSResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificacaoSMSResponse)));
            
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
        /// <returns>Task of NotificacaoSMSResponse</returns>
        public async System.Threading.Tasks.Task<NotificacaoSMSResponse> AtualizarSMSUsingPOSTAsync (string nsu = null, string status = null, string data = null, string textoStatus = null, string operadora = null)
        {
             ApiResponse<NotificacaoSMSResponse> localVarResponse = await AtualizarSMSUsingPOSTAsyncWithHttpInfo(nsu, status, data, textoStatus, operadora);
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
        /// <returns>Task of ApiResponse (NotificacaoSMSResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NotificacaoSMSResponse>> AtualizarSMSUsingPOSTAsyncWithHttpInfo (string nsu = null, string status = null, string data = null, string textoStatus = null, string operadora = null)
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarSMSUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarSMSUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NotificacaoSMSResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificacaoSMSResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificacaoSMSResponse)));
            
        }
        
        /// <summary>
        /// Consulta configura\u00C3\u00A7\u00C3\u00A3o de E-mail Esse recurso permite consultar uma configura\u00C3\u00A7\u00C3\u00A3o espec\u00C3\u00ADfica por id.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de e-mail.</param> 
        /// <returns>ConfiguracaoEmailResponse</returns>
        public ConfiguracaoEmailResponse ConsultarConfiguracaoUsingGET (long? id)
        {
             ApiResponse<ConfiguracaoEmailResponse> localVarResponse = ConsultarConfiguracaoUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta configura\u00C3\u00A7\u00C3\u00A3o de E-mail Esse recurso permite consultar uma configura\u00C3\u00A7\u00C3\u00A3o espec\u00C3\u00ADfica por id.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de e-mail.</param> 
        /// <returns>ApiResponse of ConfiguracaoEmailResponse</returns>
        public ApiResponse< ConfiguracaoEmailResponse > ConsultarConfiguracaoUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling NotificacaoApi->ConsultarConfiguracaoUsingGET");
            
    
            var localVarPath = "/api/configuracoes-email/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarConfiguracaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarConfiguracaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConfiguracaoEmailResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoEmailResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoEmailResponse)));
            
        }

        
        /// <summary>
        /// Consulta configura\u00C3\u00A7\u00C3\u00A3o de E-mail Esse recurso permite consultar uma configura\u00C3\u00A7\u00C3\u00A3o espec\u00C3\u00ADfica por id.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de e-mail.</param>
        /// <returns>Task of ConfiguracaoEmailResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoEmailResponse> ConsultarConfiguracaoUsingGETAsync (long? id)
        {
             ApiResponse<ConfiguracaoEmailResponse> localVarResponse = await ConsultarConfiguracaoUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta configura\u00C3\u00A7\u00C3\u00A3o de E-mail Esse recurso permite consultar uma configura\u00C3\u00A7\u00C3\u00A3o espec\u00C3\u00ADfica por id.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de e-mail.</param>
        /// <returns>Task of ApiResponse (ConfiguracaoEmailResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfiguracaoEmailResponse>> ConsultarConfiguracaoUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarConfiguracaoUsingGET");
            
    
            var localVarPath = "/api/configuracoes-email/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarConfiguracaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarConfiguracaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfiguracaoEmailResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoEmailResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoEmailResponse)));
            
        }
        
        /// <summary>
        /// Consulta c\u00C3\u00B3digo de seguran\u00C3\u00A7a E-mail Esse recurso permite consultar um c\u00C3\u00B3digo de seguran\u00C3\u00A7a E-mail espec\u00C3\u00ADfico por id.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de e-mail.</param> 
        /// <returns>CodigoSegurancaResponse</returns>
        public CodigoSegurancaResponse ConsultarPorEmailUsingGET (long? id)
        {
             ApiResponse<CodigoSegurancaResponse> localVarResponse = ConsultarPorEmailUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta c\u00C3\u00B3digo de seguran\u00C3\u00A7a E-mail Esse recurso permite consultar um c\u00C3\u00B3digo de seguran\u00C3\u00A7a E-mail espec\u00C3\u00ADfico por id.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de e-mail.</param> 
        /// <returns>ApiResponse of CodigoSegurancaResponse</returns>
        public ApiResponse< CodigoSegurancaResponse > ConsultarPorEmailUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling NotificacaoApi->ConsultarPorEmailUsingGET");
            
    
            var localVarPath = "/api/codigos-seguranca-email/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPorEmailUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPorEmailUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CodigoSegurancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CodigoSegurancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CodigoSegurancaResponse)));
            
        }

        
        /// <summary>
        /// Consulta c\u00C3\u00B3digo de seguran\u00C3\u00A7a E-mail Esse recurso permite consultar um c\u00C3\u00B3digo de seguran\u00C3\u00A7a E-mail espec\u00C3\u00ADfico por id.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de e-mail.</param>
        /// <returns>Task of CodigoSegurancaResponse</returns>
        public async System.Threading.Tasks.Task<CodigoSegurancaResponse> ConsultarPorEmailUsingGETAsync (long? id)
        {
             ApiResponse<CodigoSegurancaResponse> localVarResponse = await ConsultarPorEmailUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta c\u00C3\u00B3digo de seguran\u00C3\u00A7a E-mail Esse recurso permite consultar um c\u00C3\u00B3digo de seguran\u00C3\u00A7a E-mail espec\u00C3\u00ADfico por id.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de e-mail.</param>
        /// <returns>Task of ApiResponse (CodigoSegurancaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CodigoSegurancaResponse>> ConsultarPorEmailUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarPorEmailUsingGET");
            
    
            var localVarPath = "/api/codigos-seguranca-email/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPorEmailUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPorEmailUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CodigoSegurancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CodigoSegurancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CodigoSegurancaResponse)));
            
        }
        
        /// <summary>
        /// Consulta c\u00C3\u00B3digo de seguran\u00C3\u00A7a SMS Esse recurso permite consultar um c\u00C3\u00B3digo de seguran\u00C3\u00A7a SMS espec\u00C3\u00ADfico por id.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de e-mail.</param> 
        /// <returns>CodigoSegurancaResponse</returns>
        public CodigoSegurancaResponse ConsultarPorSMSUsingGET (long? id)
        {
             ApiResponse<CodigoSegurancaResponse> localVarResponse = ConsultarPorSMSUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta c\u00C3\u00B3digo de seguran\u00C3\u00A7a SMS Esse recurso permite consultar um c\u00C3\u00B3digo de seguran\u00C3\u00A7a SMS espec\u00C3\u00ADfico por id.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de e-mail.</param> 
        /// <returns>ApiResponse of CodigoSegurancaResponse</returns>
        public ApiResponse< CodigoSegurancaResponse > ConsultarPorSMSUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling NotificacaoApi->ConsultarPorSMSUsingGET");
            
    
            var localVarPath = "/api/codigos-seguranca-sms/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPorSMSUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPorSMSUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CodigoSegurancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CodigoSegurancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CodigoSegurancaResponse)));
            
        }

        
        /// <summary>
        /// Consulta c\u00C3\u00B3digo de seguran\u00C3\u00A7a SMS Esse recurso permite consultar um c\u00C3\u00B3digo de seguran\u00C3\u00A7a SMS espec\u00C3\u00ADfico por id.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de e-mail.</param>
        /// <returns>Task of CodigoSegurancaResponse</returns>
        public async System.Threading.Tasks.Task<CodigoSegurancaResponse> ConsultarPorSMSUsingGETAsync (long? id)
        {
             ApiResponse<CodigoSegurancaResponse> localVarResponse = await ConsultarPorSMSUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta c\u00C3\u00B3digo de seguran\u00C3\u00A7a SMS Esse recurso permite consultar um c\u00C3\u00B3digo de seguran\u00C3\u00A7a SMS espec\u00C3\u00ADfico por id.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de e-mail.</param>
        /// <returns>Task of ApiResponse (CodigoSegurancaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CodigoSegurancaResponse>> ConsultarPorSMSUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarPorSMSUsingGET");
            
    
            var localVarPath = "/api/codigos-seguranca-sms/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPorSMSUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPorSMSUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CodigoSegurancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CodigoSegurancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CodigoSegurancaResponse)));
            
        }
        
        /// <summary>
        /// Consulta template de notifica\u00C3\u00A7\u00C3\u00A3o Esse recurso permite consultar uma configura\u00C3\u00A7\u00C3\u00A3o espec\u00C3\u00ADfica por id.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do layout de e-mail.</param> 
        /// <returns>TemplateNotificacaoDetalheResponse</returns>
        public TemplateNotificacaoDetalheResponse ConsultarTemplateNotificacaoUsingGET (long? id)
        {
             ApiResponse<TemplateNotificacaoDetalheResponse> localVarResponse = ConsultarTemplateNotificacaoUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta template de notifica\u00C3\u00A7\u00C3\u00A3o Esse recurso permite consultar uma configura\u00C3\u00A7\u00C3\u00A3o espec\u00C3\u00ADfica por id.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do layout de e-mail.</param> 
        /// <returns>ApiResponse of TemplateNotificacaoDetalheResponse</returns>
        public ApiResponse< TemplateNotificacaoDetalheResponse > ConsultarTemplateNotificacaoUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling NotificacaoApi->ConsultarTemplateNotificacaoUsingGET");
            
    
            var localVarPath = "/api/templates-notificacoes/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTemplateNotificacaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTemplateNotificacaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TemplateNotificacaoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateNotificacaoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TemplateNotificacaoDetalheResponse)));
            
        }

        
        /// <summary>
        /// Consulta template de notifica\u00C3\u00A7\u00C3\u00A3o Esse recurso permite consultar uma configura\u00C3\u00A7\u00C3\u00A3o espec\u00C3\u00ADfica por id.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do layout de e-mail.</param>
        /// <returns>Task of TemplateNotificacaoDetalheResponse</returns>
        public async System.Threading.Tasks.Task<TemplateNotificacaoDetalheResponse> ConsultarTemplateNotificacaoUsingGETAsync (long? id)
        {
             ApiResponse<TemplateNotificacaoDetalheResponse> localVarResponse = await ConsultarTemplateNotificacaoUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta template de notifica\u00C3\u00A7\u00C3\u00A3o Esse recurso permite consultar uma configura\u00C3\u00A7\u00C3\u00A3o espec\u00C3\u00ADfica por id.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do layout de e-mail.</param>
        /// <returns>Task of ApiResponse (TemplateNotificacaoDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TemplateNotificacaoDetalheResponse>> ConsultarTemplateNotificacaoUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarTemplateNotificacaoUsingGET");
            
    
            var localVarPath = "/api/templates-notificacoes/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTemplateNotificacaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTemplateNotificacaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TemplateNotificacaoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateNotificacaoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TemplateNotificacaoDetalheResponse)));
            
        }
        
        /// <summary>
        /// Gerar c\u00C3\u00B3digo de seguran\u00C3\u00A7a e enviar por e-mail Esse recurso permite gerar e enviar c\u00C3\u00B3digos de seguran\u00C3\u00A7a por e-mail, para valida\u00C3\u00A7\u00C3\u00A3o de dispositivos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">email</param> 
        /// <returns>string</returns>
        public string GerarTokenEMAILUsingPOST (string email)
        {
             ApiResponse<string> localVarResponse = GerarTokenEMAILUsingPOSTWithHttpInfo(email);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gerar c\u00C3\u00B3digo de seguran\u00C3\u00A7a e enviar por e-mail Esse recurso permite gerar e enviar c\u00C3\u00B3digos de seguran\u00C3\u00A7a por e-mail, para valida\u00C3\u00A7\u00C3\u00A3o de dispositivos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">email</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > GerarTokenEMAILUsingPOSTWithHttpInfo (string email)
        {
            
            // verify the required parameter 'email' is set
            if (email == null)
                throw new ApiException(400, "Missing required parameter 'email' when calling NotificacaoApi->GerarTokenEMAILUsingPOST");
            
    
            var localVarPath = "/api/notificacoes-email/gerar-codigo-seguranca";
    
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
            
            
            
            
            if (email.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(email); // http body (model) parameter
            }
            else
            {
                localVarPostBody = email; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarTokenEMAILUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarTokenEMAILUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Gerar c\u00C3\u00B3digo de seguran\u00C3\u00A7a e enviar por e-mail Esse recurso permite gerar e enviar c\u00C3\u00B3digos de seguran\u00C3\u00A7a por e-mail, para valida\u00C3\u00A7\u00C3\u00A3o de dispositivos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">email</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> GerarTokenEMAILUsingPOSTAsync (string email)
        {
             ApiResponse<string> localVarResponse = await GerarTokenEMAILUsingPOSTAsyncWithHttpInfo(email);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gerar c\u00C3\u00B3digo de seguran\u00C3\u00A7a e enviar por e-mail Esse recurso permite gerar e enviar c\u00C3\u00B3digos de seguran\u00C3\u00A7a por e-mail, para valida\u00C3\u00A7\u00C3\u00A3o de dispositivos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">email</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> GerarTokenEMAILUsingPOSTAsyncWithHttpInfo (string email)
        {
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling GerarTokenEMAILUsingPOST");
            
    
            var localVarPath = "/api/notificacoes-email/gerar-codigo-seguranca";
    
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
            
            
            
            
            if (email.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(email); // http body (model) parameter
            }
            else
            {
                localVarPostBody = email; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarTokenEMAILUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarTokenEMAILUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Gerar c\u00C3\u00B3digo de seguran\u00C3\u00A7a e enviar por sms Esse recurso permite gerar e enviar c\u00C3\u00B3digos de seguran\u00C3\u00A7a por sms, para valida\u00C3\u00A7\u00C3\u00A3o de dispositivos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>string</returns>
        public string GerarTokenSMSUsingPOST (CodigoSegurancaSMSPersist persist)
        {
             ApiResponse<string> localVarResponse = GerarTokenSMSUsingPOSTWithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gerar c\u00C3\u00B3digo de seguran\u00C3\u00A7a e enviar por sms Esse recurso permite gerar e enviar c\u00C3\u00B3digos de seguran\u00C3\u00A7a por sms, para valida\u00C3\u00A7\u00C3\u00A3o de dispositivos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > GerarTokenSMSUsingPOSTWithHttpInfo (CodigoSegurancaSMSPersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling NotificacaoApi->GerarTokenSMSUsingPOST");
            
    
            var localVarPath = "/api/notificacoes-sms/gerar-codigo-seguranca";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarTokenSMSUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarTokenSMSUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Gerar c\u00C3\u00B3digo de seguran\u00C3\u00A7a e enviar por sms Esse recurso permite gerar e enviar c\u00C3\u00B3digos de seguran\u00C3\u00A7a por sms, para valida\u00C3\u00A7\u00C3\u00A3o de dispositivos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> GerarTokenSMSUsingPOSTAsync (CodigoSegurancaSMSPersist persist)
        {
             ApiResponse<string> localVarResponse = await GerarTokenSMSUsingPOSTAsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gerar c\u00C3\u00B3digo de seguran\u00C3\u00A7a e enviar por sms Esse recurso permite gerar e enviar c\u00C3\u00B3digos de seguran\u00C3\u00A7a por sms, para valida\u00C3\u00A7\u00C3\u00A3o de dispositivos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> GerarTokenSMSUsingPOSTAsyncWithHttpInfo (CodigoSegurancaSMSPersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling GerarTokenSMSUsingPOST");
            
    
            var localVarPath = "/api/notificacoes-sms/gerar-codigo-seguranca";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarTokenSMSUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarTokenSMSUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Lista configura\u00C3\u00A7\u00C3\u00B5es de E-mails Esse recurso permite listar as configura\u00C3\u00A7\u00C3\u00B5es de E-mails.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageConfiguracaoEmailResponse</returns>
        public PageConfiguracaoEmailResponse ListarConfiguracaoUsingGET (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageConfiguracaoEmailResponse> localVarResponse = ListarConfiguracaoUsingGETWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista configura\u00C3\u00A7\u00C3\u00B5es de E-mails Esse recurso permite listar as configura\u00C3\u00A7\u00C3\u00B5es de E-mails.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageConfiguracaoEmailResponse</returns>
        public ApiResponse< PageConfiguracaoEmailResponse > ListarConfiguracaoUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/configuracoes-email";
    
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarConfiguracaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarConfiguracaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageConfiguracaoEmailResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageConfiguracaoEmailResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageConfiguracaoEmailResponse)));
            
        }

        
        /// <summary>
        /// Lista configura\u00C3\u00A7\u00C3\u00B5es de E-mails Esse recurso permite listar as configura\u00C3\u00A7\u00C3\u00B5es de E-mails.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageConfiguracaoEmailResponse</returns>
        public async System.Threading.Tasks.Task<PageConfiguracaoEmailResponse> ListarConfiguracaoUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageConfiguracaoEmailResponse> localVarResponse = await ListarConfiguracaoUsingGETAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista configura\u00C3\u00A7\u00C3\u00B5es de E-mails Esse recurso permite listar as configura\u00C3\u00A7\u00C3\u00B5es de E-mails.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageConfiguracaoEmailResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageConfiguracaoEmailResponse>> ListarConfiguracaoUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/configuracoes-email";
    
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarConfiguracaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarConfiguracaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageConfiguracaoEmailResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageConfiguracaoEmailResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageConfiguracaoEmailResponse)));
            
        }
        
        /// <summary>
        /// Lista os c\u00C3\u00B3digos de seguran\u00C3\u00A7a E-Mail Esse recurso permite listar os codigos de seguran\u00C3\u00A7a por E-Mail.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageCodigoSegurancaResponse</returns>
        public PageCodigoSegurancaResponse ListarPorEmailUsingGET (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCodigoSegurancaResponse> localVarResponse = ListarPorEmailUsingGETWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os c\u00C3\u00B3digos de seguran\u00C3\u00A7a E-Mail Esse recurso permite listar os codigos de seguran\u00C3\u00A7a por E-Mail.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageCodigoSegurancaResponse</returns>
        public ApiResponse< PageCodigoSegurancaResponse > ListarPorEmailUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/codigos-seguranca-email";
    
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarPorEmailUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPorEmailUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCodigoSegurancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCodigoSegurancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCodigoSegurancaResponse)));
            
        }

        
        /// <summary>
        /// Lista os c\u00C3\u00B3digos de seguran\u00C3\u00A7a E-Mail Esse recurso permite listar os codigos de seguran\u00C3\u00A7a por E-Mail.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageCodigoSegurancaResponse</returns>
        public async System.Threading.Tasks.Task<PageCodigoSegurancaResponse> ListarPorEmailUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCodigoSegurancaResponse> localVarResponse = await ListarPorEmailUsingGETAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os c\u00C3\u00B3digos de seguran\u00C3\u00A7a E-Mail Esse recurso permite listar os codigos de seguran\u00C3\u00A7a por E-Mail.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCodigoSegurancaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCodigoSegurancaResponse>> ListarPorEmailUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/codigos-seguranca-email";
    
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarPorEmailUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPorEmailUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCodigoSegurancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCodigoSegurancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCodigoSegurancaResponse)));
            
        }
        
        /// <summary>
        /// Lista os c\u00C3\u00B3digos de seguran\u00C3\u00A7a SMS Esse recurso permite listar os codigos de seguran\u00C3\u00A7a por SMS.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageCodigoSegurancaResponse</returns>
        public PageCodigoSegurancaResponse ListarPorSMSUsingGET (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCodigoSegurancaResponse> localVarResponse = ListarPorSMSUsingGETWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os c\u00C3\u00B3digos de seguran\u00C3\u00A7a SMS Esse recurso permite listar os codigos de seguran\u00C3\u00A7a por SMS.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageCodigoSegurancaResponse</returns>
        public ApiResponse< PageCodigoSegurancaResponse > ListarPorSMSUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/codigos-seguranca-sms";
    
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarPorSMSUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPorSMSUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCodigoSegurancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCodigoSegurancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCodigoSegurancaResponse)));
            
        }

        
        /// <summary>
        /// Lista os c\u00C3\u00B3digos de seguran\u00C3\u00A7a SMS Esse recurso permite listar os codigos de seguran\u00C3\u00A7a por SMS.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageCodigoSegurancaResponse</returns>
        public async System.Threading.Tasks.Task<PageCodigoSegurancaResponse> ListarPorSMSUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCodigoSegurancaResponse> localVarResponse = await ListarPorSMSUsingGETAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os c\u00C3\u00B3digos de seguran\u00C3\u00A7a SMS Esse recurso permite listar os codigos de seguran\u00C3\u00A7a por SMS.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCodigoSegurancaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCodigoSegurancaResponse>> ListarPorSMSUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/codigos-seguranca-sms";
    
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarPorSMSUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPorSMSUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCodigoSegurancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCodigoSegurancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCodigoSegurancaResponse)));
            
        }
        
        /// <summary>
        /// Listar Push Esse recurso permite listar os Pushes do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="dataEnvio">Apresenta a data e em que o registro foi enviado para o dispositivo. (optional)</param> 
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <param name="status">Status de envio da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <param name="plataforma">Plataforma de Push notifications. (optional)</param> 
        /// <param name="protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es (optional)</param> 
        /// <returns>PagePushResponse</returns>
        public PagePushResponse ListarPushUsingGET (List<string> sort = null, int? page = null, int? limit = null, string dataEnvio = null, string tipoEvento = null, string status = null, string plataforma = null, string protocolo = null)
        {
             ApiResponse<PagePushResponse> localVarResponse = ListarPushUsingGETWithHttpInfo(sort, page, limit, dataEnvio, tipoEvento, status, plataforma, protocolo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar Push Esse recurso permite listar os Pushes do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="dataEnvio">Apresenta a data e em que o registro foi enviado para o dispositivo. (optional)</param> 
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <param name="status">Status de envio da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <param name="plataforma">Plataforma de Push notifications. (optional)</param> 
        /// <param name="protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es (optional)</param> 
        /// <returns>ApiResponse of PagePushResponse</returns>
        public ApiResponse< PagePushResponse > ListarPushUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataEnvio = null, string tipoEvento = null, string status = null, string plataforma = null, string protocolo = null)
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (dataEnvio != null) localVarQueryParams.Add("dataEnvio", Configuration.ApiClient.ParameterToString(dataEnvio)); // query parameter
            if (tipoEvento != null) localVarQueryParams.Add("tipoEvento", Configuration.ApiClient.ParameterToString(tipoEvento)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (plataforma != null) localVarQueryParams.Add("plataforma", Configuration.ApiClient.ParameterToString(plataforma)); // query parameter
            if (protocolo != null) localVarQueryParams.Add("protocolo", Configuration.ApiClient.ParameterToString(protocolo)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarPushUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPushUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePushResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePushResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePushResponse)));
            
        }

        
        /// <summary>
        /// Listar Push Esse recurso permite listar os Pushes do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataEnvio">Apresenta a data e em que o registro foi enviado para o dispositivo. (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="plataforma">Plataforma de Push notifications. (optional)</param>
        /// <param name="protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es (optional)</param>
        /// <returns>Task of PagePushResponse</returns>
        public async System.Threading.Tasks.Task<PagePushResponse> ListarPushUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, string dataEnvio = null, string tipoEvento = null, string status = null, string plataforma = null, string protocolo = null)
        {
             ApiResponse<PagePushResponse> localVarResponse = await ListarPushUsingGETAsyncWithHttpInfo(sort, page, limit, dataEnvio, tipoEvento, status, plataforma, protocolo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar Push Esse recurso permite listar os Pushes do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataEnvio">Apresenta a data e em que o registro foi enviado para o dispositivo. (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="plataforma">Plataforma de Push notifications. (optional)</param>
        /// <param name="protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es (optional)</param>
        /// <returns>Task of ApiResponse (PagePushResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePushResponse>> ListarPushUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataEnvio = null, string tipoEvento = null, string status = null, string plataforma = null, string protocolo = null)
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (dataEnvio != null) localVarQueryParams.Add("dataEnvio", Configuration.ApiClient.ParameterToString(dataEnvio)); // query parameter
            if (tipoEvento != null) localVarQueryParams.Add("tipoEvento", Configuration.ApiClient.ParameterToString(tipoEvento)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (plataforma != null) localVarQueryParams.Add("plataforma", Configuration.ApiClient.ParameterToString(plataforma)); // query parameter
            if (protocolo != null) localVarQueryParams.Add("protocolo", Configuration.ApiClient.ParameterToString(protocolo)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarPushUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPushUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePushResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePushResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePushResponse)));
            
        }
        
        /// <summary>
        /// Listar SMS Esse recurso permite listar os SMS do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="dataInclusao">Apresenta a data e em que o registro foi inclu\u00C3\u00ADdo na base para ser enviado (optional)</param> 
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <param name="status">Status de envio da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <param name="operadora">Nome da operadora a qual a notifica\u00C3\u00A7\u00C3\u00A3o foi enviada. (optional)</param> 
        /// <param name="protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es (optional)</param> 
        /// <param name="nsu">Apresenta o nsu da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <returns>PageSMSResponse</returns>
        public PageSMSResponse ListarSMSUsingGET (List<string> sort = null, int? page = null, int? limit = null, string dataInclusao = null, string tipoEvento = null, string status = null, string operadora = null, string protocolo = null, long? nsu = null)
        {
             ApiResponse<PageSMSResponse> localVarResponse = ListarSMSUsingGETWithHttpInfo(sort, page, limit, dataInclusao, tipoEvento, status, operadora, protocolo, nsu);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar SMS Esse recurso permite listar os SMS do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="dataInclusao">Apresenta a data e em que o registro foi inclu\u00C3\u00ADdo na base para ser enviado (optional)</param> 
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <param name="status">Status de envio da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <param name="operadora">Nome da operadora a qual a notifica\u00C3\u00A7\u00C3\u00A3o foi enviada. (optional)</param> 
        /// <param name="protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es (optional)</param> 
        /// <param name="nsu">Apresenta o nsu da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <returns>ApiResponse of PageSMSResponse</returns>
        public ApiResponse< PageSMSResponse > ListarSMSUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataInclusao = null, string tipoEvento = null, string status = null, string operadora = null, string protocolo = null, long? nsu = null)
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (dataInclusao != null) localVarQueryParams.Add("dataInclusao", Configuration.ApiClient.ParameterToString(dataInclusao)); // query parameter
            if (tipoEvento != null) localVarQueryParams.Add("tipoEvento", Configuration.ApiClient.ParameterToString(tipoEvento)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (operadora != null) localVarQueryParams.Add("operadora", Configuration.ApiClient.ParameterToString(operadora)); // query parameter
            if (protocolo != null) localVarQueryParams.Add("protocolo", Configuration.ApiClient.ParameterToString(protocolo)); // query parameter
            if (nsu != null) localVarQueryParams.Add("nsu", Configuration.ApiClient.ParameterToString(nsu)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarSMSUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarSMSUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageSMSResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageSMSResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageSMSResponse)));
            
        }

        
        /// <summary>
        /// Listar SMS Esse recurso permite listar os SMS do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataInclusao">Apresenta a data e em que o registro foi inclu\u00C3\u00ADdo na base para ser enviado (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="operadora">Nome da operadora a qual a notifica\u00C3\u00A7\u00C3\u00A3o foi enviada. (optional)</param>
        /// <param name="protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es (optional)</param>
        /// <param name="nsu">Apresenta o nsu da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <returns>Task of PageSMSResponse</returns>
        public async System.Threading.Tasks.Task<PageSMSResponse> ListarSMSUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, string dataInclusao = null, string tipoEvento = null, string status = null, string operadora = null, string protocolo = null, long? nsu = null)
        {
             ApiResponse<PageSMSResponse> localVarResponse = await ListarSMSUsingGETAsyncWithHttpInfo(sort, page, limit, dataInclusao, tipoEvento, status, operadora, protocolo, nsu);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar SMS Esse recurso permite listar os SMS do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataInclusao">Apresenta a data e em que o registro foi inclu\u00C3\u00ADdo na base para ser enviado (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="operadora">Nome da operadora a qual a notifica\u00C3\u00A7\u00C3\u00A3o foi enviada. (optional)</param>
        /// <param name="protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es (optional)</param>
        /// <param name="nsu">Apresenta o nsu da notifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <returns>Task of ApiResponse (PageSMSResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageSMSResponse>> ListarSMSUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataInclusao = null, string tipoEvento = null, string status = null, string operadora = null, string protocolo = null, long? nsu = null)
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (dataInclusao != null) localVarQueryParams.Add("dataInclusao", Configuration.ApiClient.ParameterToString(dataInclusao)); // query parameter
            if (tipoEvento != null) localVarQueryParams.Add("tipoEvento", Configuration.ApiClient.ParameterToString(tipoEvento)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (operadora != null) localVarQueryParams.Add("operadora", Configuration.ApiClient.ParameterToString(operadora)); // query parameter
            if (protocolo != null) localVarQueryParams.Add("protocolo", Configuration.ApiClient.ParameterToString(protocolo)); // query parameter
            if (nsu != null) localVarQueryParams.Add("nsu", Configuration.ApiClient.ParameterToString(nsu)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarSMSUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarSMSUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageSMSResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageSMSResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageSMSResponse)));
            
        }
        
        /// <summary>
        /// Lista templates de notifica\u00C3\u00A7\u00C3\u00B5es Esse recurso permite listar templates notifica\u00C3\u00A7\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageTemplateNotificacaoResponse</returns>
        public PageTemplateNotificacaoResponse ListarTemplateNotificacaoUsingGET (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTemplateNotificacaoResponse> localVarResponse = ListarTemplateNotificacaoUsingGETWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista templates de notifica\u00C3\u00A7\u00C3\u00B5es Esse recurso permite listar templates notifica\u00C3\u00A7\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageTemplateNotificacaoResponse</returns>
        public ApiResponse< PageTemplateNotificacaoResponse > ListarTemplateNotificacaoUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/templates-notificacoes";
    
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTemplateNotificacaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTemplateNotificacaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTemplateNotificacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTemplateNotificacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTemplateNotificacaoResponse)));
            
        }

        
        /// <summary>
        /// Lista templates de notifica\u00C3\u00A7\u00C3\u00B5es Esse recurso permite listar templates notifica\u00C3\u00A7\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageTemplateNotificacaoResponse</returns>
        public async System.Threading.Tasks.Task<PageTemplateNotificacaoResponse> ListarTemplateNotificacaoUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTemplateNotificacaoResponse> localVarResponse = await ListarTemplateNotificacaoUsingGETAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista templates de notifica\u00C3\u00A7\u00C3\u00B5es Esse recurso permite listar templates notifica\u00C3\u00A7\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTemplateNotificacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTemplateNotificacaoResponse>> ListarTemplateNotificacaoUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/templates-notificacoes";
    
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTemplateNotificacaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTemplateNotificacaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTemplateNotificacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTemplateNotificacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTemplateNotificacaoResponse)));
            
        }
        
        /// <summary>
        /// Lista os tipos templates de notifica\u00C3\u00A7\u00C3\u00A3o Esse recurso permite listar os tipos de templates dispon\u00C3\u00ADveis os par\u00C3\u00A2metros devem ser usados entre chaves. Ex: {{nomeParametro}} .
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        public List<Object> ListarTiposLayoutsUsingGET ()
        {
             ApiResponse<List<Object>> localVarResponse = ListarTiposLayoutsUsingGETWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os tipos templates de notifica\u00C3\u00A7\u00C3\u00A3o Esse recurso permite listar os tipos de templates dispon\u00C3\u00ADveis os par\u00C3\u00A2metros devem ser usados entre chaves. Ex: {{nomeParametro}} .
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        public ApiResponse< List<Object> > ListarTiposLayoutsUsingGETWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/tipos-layouts";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposLayoutsUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposLayoutsUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
            
        }

        
        /// <summary>
        /// Lista os tipos templates de notifica\u00C3\u00A7\u00C3\u00A3o Esse recurso permite listar os tipos de templates dispon\u00C3\u00ADveis os par\u00C3\u00A2metros devem ser usados entre chaves. Ex: {{nomeParametro}} .
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Object&gt;</returns>
        public async System.Threading.Tasks.Task<List<Object>> ListarTiposLayoutsUsingGETAsync ()
        {
             ApiResponse<List<Object>> localVarResponse = await ListarTiposLayoutsUsingGETAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os tipos templates de notifica\u00C3\u00A7\u00C3\u00A3o Esse recurso permite listar os tipos de templates dispon\u00C3\u00ADveis os par\u00C3\u00A2metros devem ser usados entre chaves. Ex: {{nomeParametro}} .
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Object>>> ListarTiposLayoutsUsingGETAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/tipos-layouts";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposLayoutsUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposLayoutsUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
            
        }
        
        /// <summary>
        /// Enviar notifica\u00C3\u00A7\u00C3\u00A3o por email Esse recurso permite enviar uma mensagem de notifica\u00C3\u00A7\u00C3\u00A3o por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>Object</returns>
        public Object NotificacaoEmailUsingPOST (NotificacaoEmailRequest request)
        {
             ApiResponse<Object> localVarResponse = NotificacaoEmailUsingPOSTWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Enviar notifica\u00C3\u00A7\u00C3\u00A3o por email Esse recurso permite enviar uma mensagem de notifica\u00C3\u00A7\u00C3\u00A3o por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > NotificacaoEmailUsingPOSTWithHttpInfo (NotificacaoEmailRequest request)
        {
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling NotificacaoApi->NotificacaoEmailUsingPOST");
            
    
            var localVarPath = "/api/notificacoes-email";
    
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
            
            
            
            
            if (request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling NotificacaoEmailUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NotificacaoEmailUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Enviar notifica\u00C3\u00A7\u00C3\u00A3o por email Esse recurso permite enviar uma mensagem de notifica\u00C3\u00A7\u00C3\u00A3o por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> NotificacaoEmailUsingPOSTAsync (NotificacaoEmailRequest request)
        {
             ApiResponse<Object> localVarResponse = await NotificacaoEmailUsingPOSTAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Enviar notifica\u00C3\u00A7\u00C3\u00A3o por email Esse recurso permite enviar uma mensagem de notifica\u00C3\u00A7\u00C3\u00A3o por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> NotificacaoEmailUsingPOSTAsyncWithHttpInfo (NotificacaoEmailRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling NotificacaoEmailUsingPOST");
            
    
            var localVarPath = "/api/notificacoes-email";
    
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
            
            
            
            
            if (request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling NotificacaoEmailUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NotificacaoEmailUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Reenviar c\u00C3\u00B3digo de seguran\u00C3\u00A7a por sms Esse recurso permite que seja reenviado para um determinado n\u00C3\u00BAmero de telefone, atrav\u00C3\u00A9s de SMS, o c\u00C3\u00B3digo de seguran\u00C3\u00A7a gerado previamente para ele. Caso o c\u00C3\u00B3digo de seguran\u00C3\u00A7a j\u00C3\u00A1 n\u00C3\u00A3o esteja mais v\u00C3\u00A1lido, o recurso retornar\u00C3\u00A1 uma mensagem orientando que seja solicitada uma nova gera\u00C3\u00A7\u00C3\u00A3o para o telefone em quest\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>string</returns>
        public string ReenviarTokenSMSUsingPOST (CodigoSegurancaSMSPersist persist)
        {
             ApiResponse<string> localVarResponse = ReenviarTokenSMSUsingPOSTWithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Reenviar c\u00C3\u00B3digo de seguran\u00C3\u00A7a por sms Esse recurso permite que seja reenviado para um determinado n\u00C3\u00BAmero de telefone, atrav\u00C3\u00A9s de SMS, o c\u00C3\u00B3digo de seguran\u00C3\u00A7a gerado previamente para ele. Caso o c\u00C3\u00B3digo de seguran\u00C3\u00A7a j\u00C3\u00A1 n\u00C3\u00A3o esteja mais v\u00C3\u00A1lido, o recurso retornar\u00C3\u00A1 uma mensagem orientando que seja solicitada uma nova gera\u00C3\u00A7\u00C3\u00A3o para o telefone em quest\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ReenviarTokenSMSUsingPOSTWithHttpInfo (CodigoSegurancaSMSPersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling NotificacaoApi->ReenviarTokenSMSUsingPOST");
            
    
            var localVarPath = "/api/notificacoes-sms/reenviar-codigo-seguranca";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ReenviarTokenSMSUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ReenviarTokenSMSUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Reenviar c\u00C3\u00B3digo de seguran\u00C3\u00A7a por sms Esse recurso permite que seja reenviado para um determinado n\u00C3\u00BAmero de telefone, atrav\u00C3\u00A9s de SMS, o c\u00C3\u00B3digo de seguran\u00C3\u00A7a gerado previamente para ele. Caso o c\u00C3\u00B3digo de seguran\u00C3\u00A7a j\u00C3\u00A1 n\u00C3\u00A3o esteja mais v\u00C3\u00A1lido, o recurso retornar\u00C3\u00A1 uma mensagem orientando que seja solicitada uma nova gera\u00C3\u00A7\u00C3\u00A3o para o telefone em quest\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ReenviarTokenSMSUsingPOSTAsync (CodigoSegurancaSMSPersist persist)
        {
             ApiResponse<string> localVarResponse = await ReenviarTokenSMSUsingPOSTAsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Reenviar c\u00C3\u00B3digo de seguran\u00C3\u00A7a por sms Esse recurso permite que seja reenviado para um determinado n\u00C3\u00BAmero de telefone, atrav\u00C3\u00A9s de SMS, o c\u00C3\u00B3digo de seguran\u00C3\u00A7a gerado previamente para ele. Caso o c\u00C3\u00B3digo de seguran\u00C3\u00A7a j\u00C3\u00A1 n\u00C3\u00A3o esteja mais v\u00C3\u00A1lido, o recurso retornar\u00C3\u00A1 uma mensagem orientando que seja solicitada uma nova gera\u00C3\u00A7\u00C3\u00A3o para o telefone em quest\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ReenviarTokenSMSUsingPOSTAsyncWithHttpInfo (CodigoSegurancaSMSPersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling ReenviarTokenSMSUsingPOST");
            
    
            var localVarPath = "/api/notificacoes-sms/reenviar-codigo-seguranca";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ReenviarTokenSMSUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ReenviarTokenSMSUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Responder SMS Esse recurso permite atualizar a resposta do SMS, fornecida pedo usu\u00C3\u00A1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00C3\u00BAmero (optional)</param> 
        /// <param name="data">Data (optional)</param> 
        /// <param name="resposta">TextoStatus (optional)</param> 
        /// <returns>NotificacaoSMSResponse</returns>
        public NotificacaoSMSResponse ResponderSMSGetUsingGET (string nsu = null, string data = null, string resposta = null)
        {
             ApiResponse<NotificacaoSMSResponse> localVarResponse = ResponderSMSGetUsingGETWithHttpInfo(nsu, data, resposta);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Responder SMS Esse recurso permite atualizar a resposta do SMS, fornecida pedo usu\u00C3\u00A1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00C3\u00BAmero (optional)</param> 
        /// <param name="data">Data (optional)</param> 
        /// <param name="resposta">TextoStatus (optional)</param> 
        /// <returns>ApiResponse of NotificacaoSMSResponse</returns>
        public ApiResponse< NotificacaoSMSResponse > ResponderSMSGetUsingGETWithHttpInfo (string nsu = null, string data = null, string resposta = null)
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ResponderSMSGetUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ResponderSMSGetUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<NotificacaoSMSResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificacaoSMSResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificacaoSMSResponse)));
            
        }

        
        /// <summary>
        /// Responder SMS Esse recurso permite atualizar a resposta do SMS, fornecida pedo usu\u00C3\u00A1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00C3\u00BAmero (optional)</param>
        /// <param name="data">Data (optional)</param>
        /// <param name="resposta">TextoStatus (optional)</param>
        /// <returns>Task of NotificacaoSMSResponse</returns>
        public async System.Threading.Tasks.Task<NotificacaoSMSResponse> ResponderSMSGetUsingGETAsync (string nsu = null, string data = null, string resposta = null)
        {
             ApiResponse<NotificacaoSMSResponse> localVarResponse = await ResponderSMSGetUsingGETAsyncWithHttpInfo(nsu, data, resposta);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Responder SMS Esse recurso permite atualizar a resposta do SMS, fornecida pedo usu\u00C3\u00A1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00C3\u00BAmero (optional)</param>
        /// <param name="data">Data (optional)</param>
        /// <param name="resposta">TextoStatus (optional)</param>
        /// <returns>Task of ApiResponse (NotificacaoSMSResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NotificacaoSMSResponse>> ResponderSMSGetUsingGETAsyncWithHttpInfo (string nsu = null, string data = null, string resposta = null)
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ResponderSMSGetUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ResponderSMSGetUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NotificacaoSMSResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificacaoSMSResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificacaoSMSResponse)));
            
        }
        
        /// <summary>
        /// Salva configura\u00C3\u00A7\u00C3\u00B5es de E-mail Esse recurso salvar configura\u00C3\u00A7\u00C3\u00B5es de E-mail.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ConfiguracaoEmailResponse</returns>
        public ConfiguracaoEmailResponse SalvarConfiguracaoUsingPOST (ConfiguracaoEmailPersist persist)
        {
             ApiResponse<ConfiguracaoEmailResponse> localVarResponse = SalvarConfiguracaoUsingPOSTWithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Salva configura\u00C3\u00A7\u00C3\u00B5es de E-mail Esse recurso salvar configura\u00C3\u00A7\u00C3\u00B5es de E-mail.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of ConfiguracaoEmailResponse</returns>
        public ApiResponse< ConfiguracaoEmailResponse > SalvarConfiguracaoUsingPOSTWithHttpInfo (ConfiguracaoEmailPersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling NotificacaoApi->SalvarConfiguracaoUsingPOST");
            
    
            var localVarPath = "/api/configuracoes-email";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarConfiguracaoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarConfiguracaoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConfiguracaoEmailResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoEmailResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoEmailResponse)));
            
        }

        
        /// <summary>
        /// Salva configura\u00C3\u00A7\u00C3\u00B5es de E-mail Esse recurso salvar configura\u00C3\u00A7\u00C3\u00B5es de E-mail.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ConfiguracaoEmailResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoEmailResponse> SalvarConfiguracaoUsingPOSTAsync (ConfiguracaoEmailPersist persist)
        {
             ApiResponse<ConfiguracaoEmailResponse> localVarResponse = await SalvarConfiguracaoUsingPOSTAsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Salva configura\u00C3\u00A7\u00C3\u00B5es de E-mail Esse recurso salvar configura\u00C3\u00A7\u00C3\u00B5es de E-mail.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoEmailResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfiguracaoEmailResponse>> SalvarConfiguracaoUsingPOSTAsyncWithHttpInfo (ConfiguracaoEmailPersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarConfiguracaoUsingPOST");
            
    
            var localVarPath = "/api/configuracoes-email";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarConfiguracaoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarConfiguracaoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfiguracaoEmailResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoEmailResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoEmailResponse)));
            
        }
        
        /// <summary>
        /// Enviar Push FCM Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma FCM (Firebase Cloud Messaging).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param> 
        /// <returns>NotificacaoResponse</returns>
        public NotificacaoResponse SalvarPushFCMUsingPOST (List<PushFCMEGCM> pushPersists)
        {
             ApiResponse<NotificacaoResponse> localVarResponse = SalvarPushFCMUsingPOSTWithHttpInfo(pushPersists);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Enviar Push FCM Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma FCM (Firebase Cloud Messaging).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param> 
        /// <returns>ApiResponse of NotificacaoResponse</returns>
        public ApiResponse< NotificacaoResponse > SalvarPushFCMUsingPOSTWithHttpInfo (List<PushFCMEGCM> pushPersists)
        {
            
            // verify the required parameter 'pushPersists' is set
            if (pushPersists == null)
                throw new ApiException(400, "Missing required parameter 'pushPersists' when calling NotificacaoApi->SalvarPushFCMUsingPOST");
            
    
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

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPushFCMUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPushFCMUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<NotificacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificacaoResponse)));
            
        }

        
        /// <summary>
        /// Enviar Push FCM Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma FCM (Firebase Cloud Messaging).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of NotificacaoResponse</returns>
        public async System.Threading.Tasks.Task<NotificacaoResponse> SalvarPushFCMUsingPOSTAsync (List<PushFCMEGCM> pushPersists)
        {
             ApiResponse<NotificacaoResponse> localVarResponse = await SalvarPushFCMUsingPOSTAsyncWithHttpInfo(pushPersists);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Enviar Push FCM Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma FCM (Firebase Cloud Messaging).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of ApiResponse (NotificacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NotificacaoResponse>> SalvarPushFCMUsingPOSTAsyncWithHttpInfo (List<PushFCMEGCM> pushPersists)
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

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPushFCMUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPushFCMUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NotificacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificacaoResponse)));
            
        }
        
        /// <summary>
        /// Enviar Push GCM Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma GCM (Google Cloud Messaging).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param> 
        /// <returns>NotificacaoResponse</returns>
        public NotificacaoResponse SalvarPushGCMUsingPOST (List<PushFCMEGCM> pushPersists)
        {
             ApiResponse<NotificacaoResponse> localVarResponse = SalvarPushGCMUsingPOSTWithHttpInfo(pushPersists);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Enviar Push GCM Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma GCM (Google Cloud Messaging).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param> 
        /// <returns>ApiResponse of NotificacaoResponse</returns>
        public ApiResponse< NotificacaoResponse > SalvarPushGCMUsingPOSTWithHttpInfo (List<PushFCMEGCM> pushPersists)
        {
            
            // verify the required parameter 'pushPersists' is set
            if (pushPersists == null)
                throw new ApiException(400, "Missing required parameter 'pushPersists' when calling NotificacaoApi->SalvarPushGCMUsingPOST");
            
    
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

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPushGCMUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPushGCMUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<NotificacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificacaoResponse)));
            
        }

        
        /// <summary>
        /// Enviar Push GCM Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma GCM (Google Cloud Messaging).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of NotificacaoResponse</returns>
        public async System.Threading.Tasks.Task<NotificacaoResponse> SalvarPushGCMUsingPOSTAsync (List<PushFCMEGCM> pushPersists)
        {
             ApiResponse<NotificacaoResponse> localVarResponse = await SalvarPushGCMUsingPOSTAsyncWithHttpInfo(pushPersists);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Enviar Push GCM Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma GCM (Google Cloud Messaging).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of ApiResponse (NotificacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NotificacaoResponse>> SalvarPushGCMUsingPOSTAsyncWithHttpInfo (List<PushFCMEGCM> pushPersists)
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

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPushGCMUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPushGCMUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NotificacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificacaoResponse)));
            
        }
        
        /// <summary>
        /// Enviar Push APNS Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma APNS (Apple Push Notification Service).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param> 
        /// <returns>NotificacaoResponse</returns>
        public NotificacaoResponse SalvarPushUsingPOST (List<PushAPNS> pushPersists)
        {
             ApiResponse<NotificacaoResponse> localVarResponse = SalvarPushUsingPOSTWithHttpInfo(pushPersists);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Enviar Push APNS Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma APNS (Apple Push Notification Service).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param> 
        /// <returns>ApiResponse of NotificacaoResponse</returns>
        public ApiResponse< NotificacaoResponse > SalvarPushUsingPOSTWithHttpInfo (List<PushAPNS> pushPersists)
        {
            
            // verify the required parameter 'pushPersists' is set
            if (pushPersists == null)
                throw new ApiException(400, "Missing required parameter 'pushPersists' when calling NotificacaoApi->SalvarPushUsingPOST");
            
    
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

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPushUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPushUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<NotificacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificacaoResponse)));
            
        }

        
        /// <summary>
        /// Enviar Push APNS Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma APNS (Apple Push Notification Service).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of NotificacaoResponse</returns>
        public async System.Threading.Tasks.Task<NotificacaoResponse> SalvarPushUsingPOSTAsync (List<PushAPNS> pushPersists)
        {
             ApiResponse<NotificacaoResponse> localVarResponse = await SalvarPushUsingPOSTAsyncWithHttpInfo(pushPersists);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Enviar Push APNS Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00C3\u00A9s da plataforma APNS (Apple Push Notification Service).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of ApiResponse (NotificacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NotificacaoResponse>> SalvarPushUsingPOSTAsyncWithHttpInfo (List<PushAPNS> pushPersists)
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

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPushUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPushUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NotificacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificacaoResponse)));
            
        }
        
        /// <summary>
        /// Enviar SMS Esse recurso permite enviar uma lista de SMS.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listaSMS">listaSMS</param> 
        /// <returns>NotificacaoResponse</returns>
        public NotificacaoResponse SalvarSMSUsingPOST (List<NotificacaoSMSBody> listaSMS)
        {
             ApiResponse<NotificacaoResponse> localVarResponse = SalvarSMSUsingPOSTWithHttpInfo(listaSMS);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Enviar SMS Esse recurso permite enviar uma lista de SMS.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listaSMS">listaSMS</param> 
        /// <returns>ApiResponse of NotificacaoResponse</returns>
        public ApiResponse< NotificacaoResponse > SalvarSMSUsingPOSTWithHttpInfo (List<NotificacaoSMSBody> listaSMS)
        {
            
            // verify the required parameter 'listaSMS' is set
            if (listaSMS == null)
                throw new ApiException(400, "Missing required parameter 'listaSMS' when calling NotificacaoApi->SalvarSMSUsingPOST");
            
    
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

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarSMSUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarSMSUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<NotificacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificacaoResponse)));
            
        }

        
        /// <summary>
        /// Enviar SMS Esse recurso permite enviar uma lista de SMS.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listaSMS">listaSMS</param>
        /// <returns>Task of NotificacaoResponse</returns>
        public async System.Threading.Tasks.Task<NotificacaoResponse> SalvarSMSUsingPOSTAsync (List<NotificacaoSMSBody> listaSMS)
        {
             ApiResponse<NotificacaoResponse> localVarResponse = await SalvarSMSUsingPOSTAsyncWithHttpInfo(listaSMS);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Enviar SMS Esse recurso permite enviar uma lista de SMS.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listaSMS">listaSMS</param>
        /// <returns>Task of ApiResponse (NotificacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NotificacaoResponse>> SalvarSMSUsingPOSTAsyncWithHttpInfo (List<NotificacaoSMSBody> listaSMS)
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

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarSMSUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarSMSUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NotificacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificacaoResponse)));
            
        }
        
        /// <summary>
        /// Salva template de notifica\u00C3\u00A7\u00C3\u00A3o Esse recurso salvar template notifica\u00C3\u00A7\u00C3\u00B5e.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conteudo">Template HTML</param> 
        /// <param name="idConfiguracaoEmail">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da configra\u00C3\u00A7\u00C3\u00A3o de EMAIL. (optional)</param> 
        /// <param name="tipoLayout">Tipo do layout. (optional)</param> 
        /// <param name="tipoNotificacao">Tipo da notifica\u00C3\u00A7\u00C3\u00A3o. (optional)</param> 
        /// <param name="remetente">Remetente (optional)</param> 
        /// <param name="assunto">Assunto da Notificaca\u00C3\u00A7\u00C3\u00A3o. (optional)</param> 
        /// <param name="templatePadrao">Template Padr\u00C3\u00A3o. (optional)</param> 
        /// <returns>TemplateNotificacaoDetalheResponse</returns>
        public TemplateNotificacaoDetalheResponse SalvarTemplateNotificacaoUsingPOST (string conteudo, long? idConfiguracaoEmail = null, string tipoLayout = null, string tipoNotificacao = null, string remetente = null, string assunto = null, bool? templatePadrao = null)
        {
             ApiResponse<TemplateNotificacaoDetalheResponse> localVarResponse = SalvarTemplateNotificacaoUsingPOSTWithHttpInfo(conteudo, idConfiguracaoEmail, tipoLayout, tipoNotificacao, remetente, assunto, templatePadrao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Salva template de notifica\u00C3\u00A7\u00C3\u00A3o Esse recurso salvar template notifica\u00C3\u00A7\u00C3\u00B5e.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conteudo">Template HTML</param> 
        /// <param name="idConfiguracaoEmail">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da configra\u00C3\u00A7\u00C3\u00A3o de EMAIL. (optional)</param> 
        /// <param name="tipoLayout">Tipo do layout. (optional)</param> 
        /// <param name="tipoNotificacao">Tipo da notifica\u00C3\u00A7\u00C3\u00A3o. (optional)</param> 
        /// <param name="remetente">Remetente (optional)</param> 
        /// <param name="assunto">Assunto da Notificaca\u00C3\u00A7\u00C3\u00A3o. (optional)</param> 
        /// <param name="templatePadrao">Template Padr\u00C3\u00A3o. (optional)</param> 
        /// <returns>ApiResponse of TemplateNotificacaoDetalheResponse</returns>
        public ApiResponse< TemplateNotificacaoDetalheResponse > SalvarTemplateNotificacaoUsingPOSTWithHttpInfo (string conteudo, long? idConfiguracaoEmail = null, string tipoLayout = null, string tipoNotificacao = null, string remetente = null, string assunto = null, bool? templatePadrao = null)
        {
            
            // verify the required parameter 'conteudo' is set
            if (conteudo == null)
                throw new ApiException(400, "Missing required parameter 'conteudo' when calling NotificacaoApi->SalvarTemplateNotificacaoUsingPOST");
            
    
            var localVarPath = "/api/templates-notificacoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "text/plain"
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
            
            if (idConfiguracaoEmail != null) localVarQueryParams.Add("idConfiguracaoEmail", Configuration.ApiClient.ParameterToString(idConfiguracaoEmail)); // query parameter
            if (tipoLayout != null) localVarQueryParams.Add("tipoLayout", Configuration.ApiClient.ParameterToString(tipoLayout)); // query parameter
            if (tipoNotificacao != null) localVarQueryParams.Add("tipoNotificacao", Configuration.ApiClient.ParameterToString(tipoNotificacao)); // query parameter
            if (remetente != null) localVarQueryParams.Add("remetente", Configuration.ApiClient.ParameterToString(remetente)); // query parameter
            if (assunto != null) localVarQueryParams.Add("assunto", Configuration.ApiClient.ParameterToString(assunto)); // query parameter
            if (templatePadrao != null) localVarQueryParams.Add("templatePadrao", Configuration.ApiClient.ParameterToString(templatePadrao)); // query parameter
            
            
            
            if (conteudo.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(conteudo); // http body (model) parameter
            }
            else
            {
                localVarPostBody = conteudo; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarTemplateNotificacaoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarTemplateNotificacaoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TemplateNotificacaoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateNotificacaoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TemplateNotificacaoDetalheResponse)));
            
        }

        
        /// <summary>
        /// Salva template de notifica\u00C3\u00A7\u00C3\u00A3o Esse recurso salvar template notifica\u00C3\u00A7\u00C3\u00B5e.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conteudo">Template HTML</param>
        /// <param name="idConfiguracaoEmail">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da configra\u00C3\u00A7\u00C3\u00A3o de EMAIL. (optional)</param>
        /// <param name="tipoLayout">Tipo do layout. (optional)</param>
        /// <param name="tipoNotificacao">Tipo da notifica\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="remetente">Remetente (optional)</param>
        /// <param name="assunto">Assunto da Notificaca\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="templatePadrao">Template Padr\u00C3\u00A3o. (optional)</param>
        /// <returns>Task of TemplateNotificacaoDetalheResponse</returns>
        public async System.Threading.Tasks.Task<TemplateNotificacaoDetalheResponse> SalvarTemplateNotificacaoUsingPOSTAsync (string conteudo, long? idConfiguracaoEmail = null, string tipoLayout = null, string tipoNotificacao = null, string remetente = null, string assunto = null, bool? templatePadrao = null)
        {
             ApiResponse<TemplateNotificacaoDetalheResponse> localVarResponse = await SalvarTemplateNotificacaoUsingPOSTAsyncWithHttpInfo(conteudo, idConfiguracaoEmail, tipoLayout, tipoNotificacao, remetente, assunto, templatePadrao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Salva template de notifica\u00C3\u00A7\u00C3\u00A3o Esse recurso salvar template notifica\u00C3\u00A7\u00C3\u00B5e.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conteudo">Template HTML</param>
        /// <param name="idConfiguracaoEmail">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da configra\u00C3\u00A7\u00C3\u00A3o de EMAIL. (optional)</param>
        /// <param name="tipoLayout">Tipo do layout. (optional)</param>
        /// <param name="tipoNotificacao">Tipo da notifica\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="remetente">Remetente (optional)</param>
        /// <param name="assunto">Assunto da Notificaca\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="templatePadrao">Template Padr\u00C3\u00A3o. (optional)</param>
        /// <returns>Task of ApiResponse (TemplateNotificacaoDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TemplateNotificacaoDetalheResponse>> SalvarTemplateNotificacaoUsingPOSTAsyncWithHttpInfo (string conteudo, long? idConfiguracaoEmail = null, string tipoLayout = null, string tipoNotificacao = null, string remetente = null, string assunto = null, bool? templatePadrao = null)
        {
            // verify the required parameter 'conteudo' is set
            if (conteudo == null) throw new ApiException(400, "Missing required parameter 'conteudo' when calling SalvarTemplateNotificacaoUsingPOST");
            
    
            var localVarPath = "/api/templates-notificacoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "text/plain"
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
            
            if (idConfiguracaoEmail != null) localVarQueryParams.Add("idConfiguracaoEmail", Configuration.ApiClient.ParameterToString(idConfiguracaoEmail)); // query parameter
            if (tipoLayout != null) localVarQueryParams.Add("tipoLayout", Configuration.ApiClient.ParameterToString(tipoLayout)); // query parameter
            if (tipoNotificacao != null) localVarQueryParams.Add("tipoNotificacao", Configuration.ApiClient.ParameterToString(tipoNotificacao)); // query parameter
            if (remetente != null) localVarQueryParams.Add("remetente", Configuration.ApiClient.ParameterToString(remetente)); // query parameter
            if (assunto != null) localVarQueryParams.Add("assunto", Configuration.ApiClient.ParameterToString(assunto)); // query parameter
            if (templatePadrao != null) localVarQueryParams.Add("templatePadrao", Configuration.ApiClient.ParameterToString(templatePadrao)); // query parameter
            
            
            
            if (conteudo.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(conteudo); // http body (model) parameter
            }
            else
            {
                localVarPostBody = conteudo; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarTemplateNotificacaoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarTemplateNotificacaoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TemplateNotificacaoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateNotificacaoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TemplateNotificacaoDetalheResponse)));
            
        }
        
        /// <summary>
        /// Validar c\u00C3\u00B3digo de seguran\u00C3\u00A7a enviado por e-mail Esse recurso permite validar os c\u00C3\u00B3digos de seguran\u00C3\u00A7a enviador por e-mail, para valida\u00C3\u00A7\u00C3\u00A3o de dispositivos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>string</returns>
        public string ValidarTokenEMAILUsingPOST (CodigoSegurancaEMAILPersist request)
        {
             ApiResponse<string> localVarResponse = ValidarTokenEMAILUsingPOSTWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Validar c\u00C3\u00B3digo de seguran\u00C3\u00A7a enviado por e-mail Esse recurso permite validar os c\u00C3\u00B3digos de seguran\u00C3\u00A7a enviador por e-mail, para valida\u00C3\u00A7\u00C3\u00A3o de dispositivos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ValidarTokenEMAILUsingPOSTWithHttpInfo (CodigoSegurancaEMAILPersist request)
        {
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling NotificacaoApi->ValidarTokenEMAILUsingPOST");
            
    
            var localVarPath = "/api/notificacoes-email/validar-codigo-seguranca";
    
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
            
            
            
            
            if (request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarTokenEMAILUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarTokenEMAILUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Validar c\u00C3\u00B3digo de seguran\u00C3\u00A7a enviado por e-mail Esse recurso permite validar os c\u00C3\u00B3digos de seguran\u00C3\u00A7a enviador por e-mail, para valida\u00C3\u00A7\u00C3\u00A3o de dispositivos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ValidarTokenEMAILUsingPOSTAsync (CodigoSegurancaEMAILPersist request)
        {
             ApiResponse<string> localVarResponse = await ValidarTokenEMAILUsingPOSTAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Validar c\u00C3\u00B3digo de seguran\u00C3\u00A7a enviado por e-mail Esse recurso permite validar os c\u00C3\u00B3digos de seguran\u00C3\u00A7a enviador por e-mail, para valida\u00C3\u00A7\u00C3\u00A3o de dispositivos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ValidarTokenEMAILUsingPOSTAsyncWithHttpInfo (CodigoSegurancaEMAILPersist request)
        {
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling ValidarTokenEMAILUsingPOST");
            
    
            var localVarPath = "/api/notificacoes-email/validar-codigo-seguranca";
    
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
            
            
            
            
            if (request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarTokenEMAILUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarTokenEMAILUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Validar c\u00C3\u00B3digo de seguran\u00C3\u00A7a enviado por sms Esse recurso permite validar os c\u00C3\u00B3digos de seguran\u00C3\u00A7a enviador por sms, para valida\u00C3\u00A7\u00C3\u00A3o de dispositivos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>string</returns>
        public string ValidarTokenSMSUsingPOST (CodigoSegurancaSMSRequest request)
        {
             ApiResponse<string> localVarResponse = ValidarTokenSMSUsingPOSTWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Validar c\u00C3\u00B3digo de seguran\u00C3\u00A7a enviado por sms Esse recurso permite validar os c\u00C3\u00B3digos de seguran\u00C3\u00A7a enviador por sms, para valida\u00C3\u00A7\u00C3\u00A3o de dispositivos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ValidarTokenSMSUsingPOSTWithHttpInfo (CodigoSegurancaSMSRequest request)
        {
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling NotificacaoApi->ValidarTokenSMSUsingPOST");
            
    
            var localVarPath = "/api/notificacoes-sms/validar-codigo-seguranca";
    
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
            
            
            
            
            if (request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarTokenSMSUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarTokenSMSUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Validar c\u00C3\u00B3digo de seguran\u00C3\u00A7a enviado por sms Esse recurso permite validar os c\u00C3\u00B3digos de seguran\u00C3\u00A7a enviador por sms, para valida\u00C3\u00A7\u00C3\u00A3o de dispositivos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ValidarTokenSMSUsingPOSTAsync (CodigoSegurancaSMSRequest request)
        {
             ApiResponse<string> localVarResponse = await ValidarTokenSMSUsingPOSTAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Validar c\u00C3\u00B3digo de seguran\u00C3\u00A7a enviado por sms Esse recurso permite validar os c\u00C3\u00B3digos de seguran\u00C3\u00A7a enviador por sms, para valida\u00C3\u00A7\u00C3\u00A3o de dispositivos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ValidarTokenSMSUsingPOSTAsyncWithHttpInfo (CodigoSegurancaSMSRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling ValidarTokenSMSUsingPOST");
            
    
            var localVarPath = "/api/notificacoes-sms/validar-codigo-seguranca";
    
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
            
            
            
            
            if (request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarTokenSMSUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarTokenSMSUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
    }
    
}
