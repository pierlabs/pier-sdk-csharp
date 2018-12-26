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
        /// Altera configura\u00E7\u00F5es de E-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite salvar altera\u00E7\u00F5es de configura\u00E7\u00F5es de E-mail
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o de e-mail</param>
        /// <param name="persist">persist</param>
        /// <returns>ConfiguracaoEmailResponse</returns>
        ConfiguracaoEmailResponse AlterarConfiguracao (long? id, ConfiguracaoEmailPersist persist);
  
        /// <summary>
        /// Altera configura\u00E7\u00F5es de E-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite salvar altera\u00E7\u00F5es de configura\u00E7\u00F5es de E-mail
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o de e-mail</param>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of ConfiguracaoEmailResponse</returns>
        ApiResponse<ConfiguracaoEmailResponse> AlterarConfiguracaoWithHttpInfo (long? id, ConfiguracaoEmailPersist persist);
        
        /// <summary>
        /// Alterar template de notifica\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite salvar altera\u00E7\u00F5es de templates notifica\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do layout de e-mail</param>
        /// <param name="conteudo">Template HTML</param>
        /// <param name="idConfiguracaoEmail">C\u00F3digo de identifica\u00E7\u00E3o da configra\u00E7\u00E3o de EMAIL (optional)</param>
        /// <param name="tipoLayout">Tipo do layout (optional)</param>
        /// <param name="tipoNotificacao">Tipo da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="remetente">Remetente (optional)</param>
        /// <param name="assunto">Assunto da Notificaca\u00E7\u00E3o (optional)</param>
        /// <param name="templatePadrao">Template Padr\u00E3o (optional)</param>
        /// <returns>TemplateNotificacaoDetalheResponse</returns>
        TemplateNotificacaoDetalheResponse AlterarTemplateNotificacao (long? id, string conteudo, long? idConfiguracaoEmail = null, string tipoLayout = null, string tipoNotificacao = null, string remetente = null, string assunto = null, bool? templatePadrao = null);
  
        /// <summary>
        /// Alterar template de notifica\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite salvar altera\u00E7\u00F5es de templates notifica\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do layout de e-mail</param>
        /// <param name="conteudo">Template HTML</param>
        /// <param name="idConfiguracaoEmail">C\u00F3digo de identifica\u00E7\u00E3o da configra\u00E7\u00E3o de EMAIL (optional)</param>
        /// <param name="tipoLayout">Tipo do layout (optional)</param>
        /// <param name="tipoNotificacao">Tipo da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="remetente">Remetente (optional)</param>
        /// <param name="assunto">Assunto da Notificaca\u00E7\u00E3o (optional)</param>
        /// <param name="templatePadrao">Template Padr\u00E3o (optional)</param>
        /// <returns>ApiResponse of TemplateNotificacaoDetalheResponse</returns>
        ApiResponse<TemplateNotificacaoDetalheResponse> AlterarTemplateNotificacaoWithHttpInfo (long? id, string conteudo, long? idConfiguracaoEmail = null, string tipoLayout = null, string tipoNotificacao = null, string remetente = null, string assunto = null, bool? templatePadrao = null);
        
        /// <summary>
        /// Atualizar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar o status do SMS do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00FAmero (optional)</param>
        /// <param name="status">Status (optional)</param>
        /// <param name="data">Data (optional)</param>
        /// <param name="textoStatus">TextoStatus (optional)</param>
        /// <param name="operadora">Operadora (optional)</param>
        /// <returns>NotificacaoSMSResponse</returns>
        NotificacaoSMSResponse AtualizarSMS (string nsu = null, string status = null, string data = null, string textoStatus = null, string operadora = null);
  
        /// <summary>
        /// Atualizar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar o status do SMS do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00FAmero (optional)</param>
        /// <param name="status">Status (optional)</param>
        /// <param name="data">Data (optional)</param>
        /// <param name="textoStatus">TextoStatus (optional)</param>
        /// <param name="operadora">Operadora (optional)</param>
        /// <returns>ApiResponse of NotificacaoSMSResponse</returns>
        ApiResponse<NotificacaoSMSResponse> AtualizarSMSWithHttpInfo (string nsu = null, string status = null, string data = null, string textoStatus = null, string operadora = null);
        
        /// <summary>
        /// Consulta configura\u00E7\u00E3o de E-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar uma configura\u00E7\u00E3o espec\u00EDfica por id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o de e-mail</param>
        /// <returns>ConfiguracaoEmailResponse</returns>
        ConfiguracaoEmailResponse ConsultarConfiguracao (long? id);
  
        /// <summary>
        /// Consulta configura\u00E7\u00E3o de E-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar uma configura\u00E7\u00E3o espec\u00EDfica por id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o de e-mail</param>
        /// <returns>ApiResponse of ConfiguracaoEmailResponse</returns>
        ApiResponse<ConfiguracaoEmailResponse> ConsultarConfiguracaoWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta c\u00F3digo de seguran\u00E7a E-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar um c\u00F3digo de seguran\u00E7a E-mail espec\u00EDfico por id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o de e-mail</param>
        /// <returns>CodigoSegurancaResponse</returns>
        CodigoSegurancaResponse ConsultarPorEmail (long? id);
  
        /// <summary>
        /// Consulta c\u00F3digo de seguran\u00E7a E-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar um c\u00F3digo de seguran\u00E7a E-mail espec\u00EDfico por id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o de e-mail</param>
        /// <returns>ApiResponse of CodigoSegurancaResponse</returns>
        ApiResponse<CodigoSegurancaResponse> ConsultarPorEmailWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta c\u00F3digo de seguran\u00E7a SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar um c\u00F3digo de seguran\u00E7a SMS espec\u00EDfico por id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o de e-mail</param>
        /// <returns>CodigoSegurancaResponse</returns>
        CodigoSegurancaResponse ConsultarPorSMS (long? id);
  
        /// <summary>
        /// Consulta c\u00F3digo de seguran\u00E7a SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar um c\u00F3digo de seguran\u00E7a SMS espec\u00EDfico por id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o de e-mail</param>
        /// <returns>ApiResponse of CodigoSegurancaResponse</returns>
        ApiResponse<CodigoSegurancaResponse> ConsultarPorSMSWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta template de notifica\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar uma configura\u00E7\u00E3o espec\u00EDfica por id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do layout de e-mail</param>
        /// <returns>TemplateNotificacaoDetalheResponse</returns>
        TemplateNotificacaoDetalheResponse ConsultarTemplateNotificacao (long? id);
  
        /// <summary>
        /// Consulta template de notifica\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar uma configura\u00E7\u00E3o espec\u00EDfica por id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do layout de e-mail</param>
        /// <returns>ApiResponse of TemplateNotificacaoDetalheResponse</returns>
        ApiResponse<TemplateNotificacaoDetalheResponse> ConsultarTemplateNotificacaoWithHttpInfo (long? id);
        
        /// <summary>
        /// Enviar OTP 3D Secure
        /// </summary>
        /// <remarks>
        /// Esse recursos permite enviar uma notifica\u00E7\u00E3o com o OTP do 3D Secure para um determinado cliente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="secure3dRequest">secure3dRequest</param>
        /// <returns>Object</returns>
        Object EnviarOTP (Secure3dRequest secure3dRequest);
  
        /// <summary>
        /// Enviar OTP 3D Secure
        /// </summary>
        /// <remarks>
        /// Esse recursos permite enviar uma notifica\u00E7\u00E3o com o OTP do 3D Secure para um determinado cliente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="secure3dRequest">secure3dRequest</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> EnviarOTPWithHttpInfo (Secure3dRequest secure3dRequest);
        
        /// <summary>
        /// Gerar c\u00F3digo de seguran\u00E7a e enviar por e-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite gerar e enviar c\u00F3digos de seguran\u00E7a por e-mail, para valida\u00E7\u00E3o de dispositivos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">email</param>
        /// <returns>string</returns>
        string GerarTokenEMAIL (string email);
  
        /// <summary>
        /// Gerar c\u00F3digo de seguran\u00E7a e enviar por e-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite gerar e enviar c\u00F3digos de seguran\u00E7a por e-mail, para valida\u00E7\u00E3o de dispositivos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">email</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> GerarTokenEMAILWithHttpInfo (string email);
        
        /// <summary>
        /// Gerar c\u00F3digo de seguran\u00E7a e enviar por sms
        /// </summary>
        /// <remarks>
        /// Esse recurso permite gerar e enviar c\u00F3digos de seguran\u00E7a por sms, para valida\u00E7\u00E3o de dispositivos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>string</returns>
        string GerarTokenSMS (CodigoSegurancaSMSPersist persist);
  
        /// <summary>
        /// Gerar c\u00F3digo de seguran\u00E7a e enviar por sms
        /// </summary>
        /// <remarks>
        /// Esse recurso permite gerar e enviar c\u00F3digos de seguran\u00E7a por sms, para valida\u00E7\u00E3o de dispositivos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> GerarTokenSMSWithHttpInfo (CodigoSegurancaSMSPersist persist);
        
        /// <summary>
        /// Lista configura\u00E7\u00F5es de E-mails
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar as configura\u00E7\u00F5es de E-mails
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageConfiguracaoEmailResponse</returns>
        PageConfiguracaoEmailResponse ListarConfiguracao (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista configura\u00E7\u00F5es de E-mails
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar as configura\u00E7\u00F5es de E-mails
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageConfiguracaoEmailResponse</returns>
        ApiResponse<PageConfiguracaoEmailResponse> ListarConfiguracaoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os c\u00F3digos de seguran\u00E7a E-Mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os codigos de seguran\u00E7a por E-Mail
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageCodigoSegurancaResponse</returns>
        PageCodigoSegurancaResponse ListarPorEmail (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista os c\u00F3digos de seguran\u00E7a E-Mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os codigos de seguran\u00E7a por E-Mail
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageCodigoSegurancaResponse</returns>
        ApiResponse<PageCodigoSegurancaResponse> ListarPorEmailWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os c\u00F3digos de seguran\u00E7a SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os codigos de seguran\u00E7a por SMS
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageCodigoSegurancaResponse</returns>
        PageCodigoSegurancaResponse ListarPorSMS (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista os c\u00F3digos de seguran\u00E7a SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os codigos de seguran\u00E7a por SMS
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageCodigoSegurancaResponse</returns>
        ApiResponse<PageCodigoSegurancaResponse> ListarPorSMSWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar Push
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os Pushes do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataEnvio">Apresenta a data e em que o registro foi enviado para o dispositivo (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="plataforma">Plataforma de Push notifications (optional)</param>
        /// <param name="protocolo">N\u00FAmero do protocolo de envio de notifica\u00E7\u00F5es (optional)</param>
        /// <returns>PagePushResponse</returns>
        PagePushResponse ListarPush (List<string> sort = null, int? page = null, int? limit = null, string dataEnvio = null, string tipoEvento = null, string status = null, string plataforma = null, string protocolo = null);
  
        /// <summary>
        /// Listar Push
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os Pushes do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataEnvio">Apresenta a data e em que o registro foi enviado para o dispositivo (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="plataforma">Plataforma de Push notifications (optional)</param>
        /// <param name="protocolo">N\u00FAmero do protocolo de envio de notifica\u00E7\u00F5es (optional)</param>
        /// <returns>ApiResponse of PagePushResponse</returns>
        ApiResponse<PagePushResponse> ListarPushWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataEnvio = null, string tipoEvento = null, string status = null, string plataforma = null, string protocolo = null);
        
        /// <summary>
        /// Listar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os SMS do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataInclusao">Apresenta a data e em que o registro foi inclu\u00EDdo na base para ser enviado (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="operadora">Nome da operadora a qual a notifica\u00E7\u00E3o foi enviada (optional)</param>
        /// <param name="protocolo">N\u00FAmero do protocolo de envio de notifica\u00E7\u00F5es (optional)</param>
        /// <param name="nsu">Apresenta o nsu da notifica\u00E7\u00E3o (optional)</param>
        /// <returns>PageSMSResponse</returns>
        PageSMSResponse ListarSMS (List<string> sort = null, int? page = null, int? limit = null, string dataInclusao = null, string tipoEvento = null, string status = null, string operadora = null, string protocolo = null, long? nsu = null);
  
        /// <summary>
        /// Listar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os SMS do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataInclusao">Apresenta a data e em que o registro foi inclu\u00EDdo na base para ser enviado (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="operadora">Nome da operadora a qual a notifica\u00E7\u00E3o foi enviada (optional)</param>
        /// <param name="protocolo">N\u00FAmero do protocolo de envio de notifica\u00E7\u00F5es (optional)</param>
        /// <param name="nsu">Apresenta o nsu da notifica\u00E7\u00E3o (optional)</param>
        /// <returns>ApiResponse of PageSMSResponse</returns>
        ApiResponse<PageSMSResponse> ListarSMSWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataInclusao = null, string tipoEvento = null, string status = null, string operadora = null, string protocolo = null, long? nsu = null);
        
        /// <summary>
        /// Lista templates de notifica\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar templates notifica\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageTemplateNotificacaoResponse</returns>
        PageTemplateNotificacaoResponse ListarTemplateNotificacao (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista templates de notifica\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar templates notifica\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageTemplateNotificacaoResponse</returns>
        ApiResponse<PageTemplateNotificacaoResponse> ListarTemplateNotificacaoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os tipos templates de notifica\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os tipos de templates dispon\u00EDveis os par\u00E2metros devem ser usados entre chaves. Ex: {{nomeParametro}} 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        List<Object> ListarTiposLayouts ();
  
        /// <summary>
        /// Lista os tipos templates de notifica\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os tipos de templates dispon\u00EDveis os par\u00E2metros devem ser usados entre chaves. Ex: {{nomeParametro}} 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        ApiResponse<List<Object>> ListarTiposLayoutsWithHttpInfo ();
        
        /// <summary>
        /// Enviar notifica\u00E7\u00E3o por email
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar uma mensagem de notifica\u00E7\u00E3o por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Object</returns>
        Object NotificacaoEmail (NotificacaoEmailRequest request);
  
        /// <summary>
        /// Enviar notifica\u00E7\u00E3o por email
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar uma mensagem de notifica\u00E7\u00E3o por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> NotificacaoEmailWithHttpInfo (NotificacaoEmailRequest request);
        
        /// <summary>
        /// Reenviar c\u00F3digo de seguran\u00E7a por sms
        /// </summary>
        /// <remarks>
        /// Esse recurso permite que seja reenviado para um determinado n\u00FAmero de telefone, atrav\u00E9s de SMS, o c\u00F3digo de seguran\u00E7a gerado previamente para ele. Caso o c\u00F3digo de seguran\u00E7a j\u00E1 n\u00E3o esteja mais v\u00E1lido, o recurso retornar\u00E1 uma mensagem orientando que seja solicitada uma nova gera\u00E7\u00E3o para o telefone em quest\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>string</returns>
        string ReenviarTokenSMS (CodigoSegurancaSMSPersist persist);
  
        /// <summary>
        /// Reenviar c\u00F3digo de seguran\u00E7a por sms
        /// </summary>
        /// <remarks>
        /// Esse recurso permite que seja reenviado para um determinado n\u00FAmero de telefone, atrav\u00E9s de SMS, o c\u00F3digo de seguran\u00E7a gerado previamente para ele. Caso o c\u00F3digo de seguran\u00E7a j\u00E1 n\u00E3o esteja mais v\u00E1lido, o recurso retornar\u00E1 uma mensagem orientando que seja solicitada uma nova gera\u00E7\u00E3o para o telefone em quest\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ReenviarTokenSMSWithHttpInfo (CodigoSegurancaSMSPersist persist);
        
        /// <summary>
        /// Responder SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar a resposta do SMS, fornecida pedo usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00FAmero (optional)</param>
        /// <param name="data">Data (optional)</param>
        /// <param name="resposta">TextoStatus (optional)</param>
        /// <returns>NotificacaoSMSResponse</returns>
        NotificacaoSMSResponse ResponderSMSGet (string nsu = null, string data = null, string resposta = null);
  
        /// <summary>
        /// Responder SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar a resposta do SMS, fornecida pedo usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00FAmero (optional)</param>
        /// <param name="data">Data (optional)</param>
        /// <param name="resposta">TextoStatus (optional)</param>
        /// <returns>ApiResponse of NotificacaoSMSResponse</returns>
        ApiResponse<NotificacaoSMSResponse> ResponderSMSGetWithHttpInfo (string nsu = null, string data = null, string resposta = null);
        
        /// <summary>
        /// Salva configura\u00E7\u00F5es de E-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso salvar configura\u00E7\u00F5es de E-mail
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ConfiguracaoEmailResponse</returns>
        ConfiguracaoEmailResponse SalvarConfiguracao (ConfiguracaoEmailPersist persist);
  
        /// <summary>
        /// Salva configura\u00E7\u00F5es de E-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso salvar configura\u00E7\u00F5es de E-mail
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of ConfiguracaoEmailResponse</returns>
        ApiResponse<ConfiguracaoEmailResponse> SalvarConfiguracaoWithHttpInfo (ConfiguracaoEmailPersist persist);
        
        /// <summary>
        /// Enviar Push APNS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00E9s da plataforma APNS (Apple Push Notification Service)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>NotificacaoResponse</returns>
        NotificacaoResponse SalvarPush (List<PushAPNS> pushPersists);
  
        /// <summary>
        /// Enviar Push APNS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00E9s da plataforma APNS (Apple Push Notification Service)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>ApiResponse of NotificacaoResponse</returns>
        ApiResponse<NotificacaoResponse> SalvarPushWithHttpInfo (List<PushAPNS> pushPersists);
        
        /// <summary>
        /// Enviar Push FCM
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00E9s da plataforma FCM (Firebase Cloud Messaging)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>NotificacaoResponse</returns>
        NotificacaoResponse SalvarPushFCM (List<PushFCMEGCM> pushPersists);
  
        /// <summary>
        /// Enviar Push FCM
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00E9s da plataforma FCM (Firebase Cloud Messaging)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>ApiResponse of NotificacaoResponse</returns>
        ApiResponse<NotificacaoResponse> SalvarPushFCMWithHttpInfo (List<PushFCMEGCM> pushPersists);
        
        /// <summary>
        /// Enviar Push GCM
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00E9s da plataforma GCM (Google Cloud Messaging)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>NotificacaoResponse</returns>
        NotificacaoResponse SalvarPushGCM (List<PushFCMEGCM> pushPersists);
  
        /// <summary>
        /// Enviar Push GCM
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00E9s da plataforma GCM (Google Cloud Messaging)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>ApiResponse of NotificacaoResponse</returns>
        ApiResponse<NotificacaoResponse> SalvarPushGCMWithHttpInfo (List<PushFCMEGCM> pushPersists);
        
        /// <summary>
        /// Enviar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar uma lista de SMS
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listaSMS">listaSMS</param>
        /// <returns>NotificacaoResponse</returns>
        NotificacaoResponse SalvarSMS (List<NotificacaoSMSBody> listaSMS);
  
        /// <summary>
        /// Enviar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar uma lista de SMS
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listaSMS">listaSMS</param>
        /// <returns>ApiResponse of NotificacaoResponse</returns>
        ApiResponse<NotificacaoResponse> SalvarSMSWithHttpInfo (List<NotificacaoSMSBody> listaSMS);
        
        /// <summary>
        /// Salva template de notifica\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Esse recurso salvar template notifica\u00E7\u00F5e
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conteudo">Template HTML</param>
        /// <param name="idConfiguracaoEmail">C\u00F3digo de identifica\u00E7\u00E3o da configra\u00E7\u00E3o de EMAIL (optional)</param>
        /// <param name="tipoLayout">Tipo do layout (optional)</param>
        /// <param name="tipoNotificacao">Tipo da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="remetente">Remetente (optional)</param>
        /// <param name="assunto">Assunto da Notificaca\u00E7\u00E3o (optional)</param>
        /// <param name="templatePadrao">Template Padr\u00E3o (optional)</param>
        /// <returns>TemplateNotificacaoDetalheResponse</returns>
        TemplateNotificacaoDetalheResponse SalvarTemplateNotificacao (string conteudo, long? idConfiguracaoEmail = null, string tipoLayout = null, string tipoNotificacao = null, string remetente = null, string assunto = null, bool? templatePadrao = null);
  
        /// <summary>
        /// Salva template de notifica\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Esse recurso salvar template notifica\u00E7\u00F5e
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conteudo">Template HTML</param>
        /// <param name="idConfiguracaoEmail">C\u00F3digo de identifica\u00E7\u00E3o da configra\u00E7\u00E3o de EMAIL (optional)</param>
        /// <param name="tipoLayout">Tipo do layout (optional)</param>
        /// <param name="tipoNotificacao">Tipo da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="remetente">Remetente (optional)</param>
        /// <param name="assunto">Assunto da Notificaca\u00E7\u00E3o (optional)</param>
        /// <param name="templatePadrao">Template Padr\u00E3o (optional)</param>
        /// <returns>ApiResponse of TemplateNotificacaoDetalheResponse</returns>
        ApiResponse<TemplateNotificacaoDetalheResponse> SalvarTemplateNotificacaoWithHttpInfo (string conteudo, long? idConfiguracaoEmail = null, string tipoLayout = null, string tipoNotificacao = null, string remetente = null, string assunto = null, bool? templatePadrao = null);
        
        /// <summary>
        /// Validar c\u00F3digo de seguran\u00E7a enviado por e-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite validar os c\u00F3digos de seguran\u00E7a enviador por e-mail, para valida\u00E7\u00E3o de dispositivos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>string</returns>
        string ValidarTokenEMAIL (CodigoSegurancaEMAILPersist request);
  
        /// <summary>
        /// Validar c\u00F3digo de seguran\u00E7a enviado por e-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite validar os c\u00F3digos de seguran\u00E7a enviador por e-mail, para valida\u00E7\u00E3o de dispositivos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ValidarTokenEMAILWithHttpInfo (CodigoSegurancaEMAILPersist request);
        
        /// <summary>
        /// Validar c\u00F3digo de seguran\u00E7a enviado por sms
        /// </summary>
        /// <remarks>
        /// Esse recurso permite validar os c\u00F3digos de seguran\u00E7a enviador por sms, para valida\u00E7\u00E3o de dispositivos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>string</returns>
        string ValidarTokenSMS (CodigoSegurancaSMSRequest request);
  
        /// <summary>
        /// Validar c\u00F3digo de seguran\u00E7a enviado por sms
        /// </summary>
        /// <remarks>
        /// Esse recurso permite validar os c\u00F3digos de seguran\u00E7a enviador por sms, para valida\u00E7\u00E3o de dispositivos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ValidarTokenSMSWithHttpInfo (CodigoSegurancaSMSRequest request);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Altera configura\u00E7\u00F5es de E-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite salvar altera\u00E7\u00F5es de configura\u00E7\u00F5es de E-mail
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o de e-mail</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ConfiguracaoEmailResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoEmailResponse> AlterarConfiguracaoAsync (long? id, ConfiguracaoEmailPersist persist);

        /// <summary>
        /// Altera configura\u00E7\u00F5es de E-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite salvar altera\u00E7\u00F5es de configura\u00E7\u00F5es de E-mail
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o de e-mail</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoEmailResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoEmailResponse>> AlterarConfiguracaoAsyncWithHttpInfo (long? id, ConfiguracaoEmailPersist persist);
        
        /// <summary>
        /// Alterar template de notifica\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite salvar altera\u00E7\u00F5es de templates notifica\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do layout de e-mail</param>
        /// <param name="conteudo">Template HTML</param>
        /// <param name="idConfiguracaoEmail">C\u00F3digo de identifica\u00E7\u00E3o da configra\u00E7\u00E3o de EMAIL (optional)</param>
        /// <param name="tipoLayout">Tipo do layout (optional)</param>
        /// <param name="tipoNotificacao">Tipo da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="remetente">Remetente (optional)</param>
        /// <param name="assunto">Assunto da Notificaca\u00E7\u00E3o (optional)</param>
        /// <param name="templatePadrao">Template Padr\u00E3o (optional)</param>
        /// <returns>Task of TemplateNotificacaoDetalheResponse</returns>
        System.Threading.Tasks.Task<TemplateNotificacaoDetalheResponse> AlterarTemplateNotificacaoAsync (long? id, string conteudo, long? idConfiguracaoEmail = null, string tipoLayout = null, string tipoNotificacao = null, string remetente = null, string assunto = null, bool? templatePadrao = null);

        /// <summary>
        /// Alterar template de notifica\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite salvar altera\u00E7\u00F5es de templates notifica\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do layout de e-mail</param>
        /// <param name="conteudo">Template HTML</param>
        /// <param name="idConfiguracaoEmail">C\u00F3digo de identifica\u00E7\u00E3o da configra\u00E7\u00E3o de EMAIL (optional)</param>
        /// <param name="tipoLayout">Tipo do layout (optional)</param>
        /// <param name="tipoNotificacao">Tipo da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="remetente">Remetente (optional)</param>
        /// <param name="assunto">Assunto da Notificaca\u00E7\u00E3o (optional)</param>
        /// <param name="templatePadrao">Template Padr\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (TemplateNotificacaoDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TemplateNotificacaoDetalheResponse>> AlterarTemplateNotificacaoAsyncWithHttpInfo (long? id, string conteudo, long? idConfiguracaoEmail = null, string tipoLayout = null, string tipoNotificacao = null, string remetente = null, string assunto = null, bool? templatePadrao = null);
        
        /// <summary>
        /// Atualizar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar o status do SMS do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00FAmero (optional)</param>
        /// <param name="status">Status (optional)</param>
        /// <param name="data">Data (optional)</param>
        /// <param name="textoStatus">TextoStatus (optional)</param>
        /// <param name="operadora">Operadora (optional)</param>
        /// <returns>Task of NotificacaoSMSResponse</returns>
        System.Threading.Tasks.Task<NotificacaoSMSResponse> AtualizarSMSAsync (string nsu = null, string status = null, string data = null, string textoStatus = null, string operadora = null);

        /// <summary>
        /// Atualizar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar o status do SMS do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00FAmero (optional)</param>
        /// <param name="status">Status (optional)</param>
        /// <param name="data">Data (optional)</param>
        /// <param name="textoStatus">TextoStatus (optional)</param>
        /// <param name="operadora">Operadora (optional)</param>
        /// <returns>Task of ApiResponse (NotificacaoSMSResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<NotificacaoSMSResponse>> AtualizarSMSAsyncWithHttpInfo (string nsu = null, string status = null, string data = null, string textoStatus = null, string operadora = null);
        
        /// <summary>
        /// Consulta configura\u00E7\u00E3o de E-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar uma configura\u00E7\u00E3o espec\u00EDfica por id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o de e-mail</param>
        /// <returns>Task of ConfiguracaoEmailResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoEmailResponse> ConsultarConfiguracaoAsync (long? id);

        /// <summary>
        /// Consulta configura\u00E7\u00E3o de E-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar uma configura\u00E7\u00E3o espec\u00EDfica por id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o de e-mail</param>
        /// <returns>Task of ApiResponse (ConfiguracaoEmailResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoEmailResponse>> ConsultarConfiguracaoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta c\u00F3digo de seguran\u00E7a E-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar um c\u00F3digo de seguran\u00E7a E-mail espec\u00EDfico por id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o de e-mail</param>
        /// <returns>Task of CodigoSegurancaResponse</returns>
        System.Threading.Tasks.Task<CodigoSegurancaResponse> ConsultarPorEmailAsync (long? id);

        /// <summary>
        /// Consulta c\u00F3digo de seguran\u00E7a E-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar um c\u00F3digo de seguran\u00E7a E-mail espec\u00EDfico por id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o de e-mail</param>
        /// <returns>Task of ApiResponse (CodigoSegurancaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CodigoSegurancaResponse>> ConsultarPorEmailAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta c\u00F3digo de seguran\u00E7a SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar um c\u00F3digo de seguran\u00E7a SMS espec\u00EDfico por id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o de e-mail</param>
        /// <returns>Task of CodigoSegurancaResponse</returns>
        System.Threading.Tasks.Task<CodigoSegurancaResponse> ConsultarPorSMSAsync (long? id);

        /// <summary>
        /// Consulta c\u00F3digo de seguran\u00E7a SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar um c\u00F3digo de seguran\u00E7a SMS espec\u00EDfico por id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o de e-mail</param>
        /// <returns>Task of ApiResponse (CodigoSegurancaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CodigoSegurancaResponse>> ConsultarPorSMSAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta template de notifica\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar uma configura\u00E7\u00E3o espec\u00EDfica por id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do layout de e-mail</param>
        /// <returns>Task of TemplateNotificacaoDetalheResponse</returns>
        System.Threading.Tasks.Task<TemplateNotificacaoDetalheResponse> ConsultarTemplateNotificacaoAsync (long? id);

        /// <summary>
        /// Consulta template de notifica\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar uma configura\u00E7\u00E3o espec\u00EDfica por id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do layout de e-mail</param>
        /// <returns>Task of ApiResponse (TemplateNotificacaoDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TemplateNotificacaoDetalheResponse>> ConsultarTemplateNotificacaoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Enviar OTP 3D Secure
        /// </summary>
        /// <remarks>
        /// Esse recursos permite enviar uma notifica\u00E7\u00E3o com o OTP do 3D Secure para um determinado cliente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="secure3dRequest">secure3dRequest</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> EnviarOTPAsync (Secure3dRequest secure3dRequest);

        /// <summary>
        /// Enviar OTP 3D Secure
        /// </summary>
        /// <remarks>
        /// Esse recursos permite enviar uma notifica\u00E7\u00E3o com o OTP do 3D Secure para um determinado cliente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="secure3dRequest">secure3dRequest</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> EnviarOTPAsyncWithHttpInfo (Secure3dRequest secure3dRequest);
        
        /// <summary>
        /// Gerar c\u00F3digo de seguran\u00E7a e enviar por e-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite gerar e enviar c\u00F3digos de seguran\u00E7a por e-mail, para valida\u00E7\u00E3o de dispositivos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">email</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> GerarTokenEMAILAsync (string email);

        /// <summary>
        /// Gerar c\u00F3digo de seguran\u00E7a e enviar por e-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite gerar e enviar c\u00F3digos de seguran\u00E7a por e-mail, para valida\u00E7\u00E3o de dispositivos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">email</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> GerarTokenEMAILAsyncWithHttpInfo (string email);
        
        /// <summary>
        /// Gerar c\u00F3digo de seguran\u00E7a e enviar por sms
        /// </summary>
        /// <remarks>
        /// Esse recurso permite gerar e enviar c\u00F3digos de seguran\u00E7a por sms, para valida\u00E7\u00E3o de dispositivos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> GerarTokenSMSAsync (CodigoSegurancaSMSPersist persist);

        /// <summary>
        /// Gerar c\u00F3digo de seguran\u00E7a e enviar por sms
        /// </summary>
        /// <remarks>
        /// Esse recurso permite gerar e enviar c\u00F3digos de seguran\u00E7a por sms, para valida\u00E7\u00E3o de dispositivos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> GerarTokenSMSAsyncWithHttpInfo (CodigoSegurancaSMSPersist persist);
        
        /// <summary>
        /// Lista configura\u00E7\u00F5es de E-mails
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar as configura\u00E7\u00F5es de E-mails
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageConfiguracaoEmailResponse</returns>
        System.Threading.Tasks.Task<PageConfiguracaoEmailResponse> ListarConfiguracaoAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista configura\u00E7\u00F5es de E-mails
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar as configura\u00E7\u00F5es de E-mails
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageConfiguracaoEmailResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageConfiguracaoEmailResponse>> ListarConfiguracaoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os c\u00F3digos de seguran\u00E7a E-Mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os codigos de seguran\u00E7a por E-Mail
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageCodigoSegurancaResponse</returns>
        System.Threading.Tasks.Task<PageCodigoSegurancaResponse> ListarPorEmailAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista os c\u00F3digos de seguran\u00E7a E-Mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os codigos de seguran\u00E7a por E-Mail
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCodigoSegurancaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCodigoSegurancaResponse>> ListarPorEmailAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os c\u00F3digos de seguran\u00E7a SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os codigos de seguran\u00E7a por SMS
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageCodigoSegurancaResponse</returns>
        System.Threading.Tasks.Task<PageCodigoSegurancaResponse> ListarPorSMSAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista os c\u00F3digos de seguran\u00E7a SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os codigos de seguran\u00E7a por SMS
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCodigoSegurancaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCodigoSegurancaResponse>> ListarPorSMSAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar Push
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os Pushes do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataEnvio">Apresenta a data e em que o registro foi enviado para o dispositivo (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="plataforma">Plataforma de Push notifications (optional)</param>
        /// <param name="protocolo">N\u00FAmero do protocolo de envio de notifica\u00E7\u00F5es (optional)</param>
        /// <returns>Task of PagePushResponse</returns>
        System.Threading.Tasks.Task<PagePushResponse> ListarPushAsync (List<string> sort = null, int? page = null, int? limit = null, string dataEnvio = null, string tipoEvento = null, string status = null, string plataforma = null, string protocolo = null);

        /// <summary>
        /// Listar Push
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os Pushes do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataEnvio">Apresenta a data e em que o registro foi enviado para o dispositivo (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="plataforma">Plataforma de Push notifications (optional)</param>
        /// <param name="protocolo">N\u00FAmero do protocolo de envio de notifica\u00E7\u00F5es (optional)</param>
        /// <returns>Task of ApiResponse (PagePushResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePushResponse>> ListarPushAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataEnvio = null, string tipoEvento = null, string status = null, string plataforma = null, string protocolo = null);
        
        /// <summary>
        /// Listar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os SMS do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataInclusao">Apresenta a data e em que o registro foi inclu\u00EDdo na base para ser enviado (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="operadora">Nome da operadora a qual a notifica\u00E7\u00E3o foi enviada (optional)</param>
        /// <param name="protocolo">N\u00FAmero do protocolo de envio de notifica\u00E7\u00F5es (optional)</param>
        /// <param name="nsu">Apresenta o nsu da notifica\u00E7\u00E3o (optional)</param>
        /// <returns>Task of PageSMSResponse</returns>
        System.Threading.Tasks.Task<PageSMSResponse> ListarSMSAsync (List<string> sort = null, int? page = null, int? limit = null, string dataInclusao = null, string tipoEvento = null, string status = null, string operadora = null, string protocolo = null, long? nsu = null);

        /// <summary>
        /// Listar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os SMS do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataInclusao">Apresenta a data e em que o registro foi inclu\u00EDdo na base para ser enviado (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="operadora">Nome da operadora a qual a notifica\u00E7\u00E3o foi enviada (optional)</param>
        /// <param name="protocolo">N\u00FAmero do protocolo de envio de notifica\u00E7\u00F5es (optional)</param>
        /// <param name="nsu">Apresenta o nsu da notifica\u00E7\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (PageSMSResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageSMSResponse>> ListarSMSAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataInclusao = null, string tipoEvento = null, string status = null, string operadora = null, string protocolo = null, long? nsu = null);
        
        /// <summary>
        /// Lista templates de notifica\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar templates notifica\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageTemplateNotificacaoResponse</returns>
        System.Threading.Tasks.Task<PageTemplateNotificacaoResponse> ListarTemplateNotificacaoAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista templates de notifica\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar templates notifica\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTemplateNotificacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTemplateNotificacaoResponse>> ListarTemplateNotificacaoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os tipos templates de notifica\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os tipos de templates dispon\u00EDveis os par\u00E2metros devem ser usados entre chaves. Ex: {{nomeParametro}} 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Object&gt;</returns>
        System.Threading.Tasks.Task<List<Object>> ListarTiposLayoutsAsync ();

        /// <summary>
        /// Lista os tipos templates de notifica\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os tipos de templates dispon\u00EDveis os par\u00E2metros devem ser usados entre chaves. Ex: {{nomeParametro}} 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Object>>> ListarTiposLayoutsAsyncWithHttpInfo ();
        
        /// <summary>
        /// Enviar notifica\u00E7\u00E3o por email
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar uma mensagem de notifica\u00E7\u00E3o por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> NotificacaoEmailAsync (NotificacaoEmailRequest request);

        /// <summary>
        /// Enviar notifica\u00E7\u00E3o por email
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar uma mensagem de notifica\u00E7\u00E3o por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> NotificacaoEmailAsyncWithHttpInfo (NotificacaoEmailRequest request);
        
        /// <summary>
        /// Reenviar c\u00F3digo de seguran\u00E7a por sms
        /// </summary>
        /// <remarks>
        /// Esse recurso permite que seja reenviado para um determinado n\u00FAmero de telefone, atrav\u00E9s de SMS, o c\u00F3digo de seguran\u00E7a gerado previamente para ele. Caso o c\u00F3digo de seguran\u00E7a j\u00E1 n\u00E3o esteja mais v\u00E1lido, o recurso retornar\u00E1 uma mensagem orientando que seja solicitada uma nova gera\u00E7\u00E3o para o telefone em quest\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ReenviarTokenSMSAsync (CodigoSegurancaSMSPersist persist);

        /// <summary>
        /// Reenviar c\u00F3digo de seguran\u00E7a por sms
        /// </summary>
        /// <remarks>
        /// Esse recurso permite que seja reenviado para um determinado n\u00FAmero de telefone, atrav\u00E9s de SMS, o c\u00F3digo de seguran\u00E7a gerado previamente para ele. Caso o c\u00F3digo de seguran\u00E7a j\u00E1 n\u00E3o esteja mais v\u00E1lido, o recurso retornar\u00E1 uma mensagem orientando que seja solicitada uma nova gera\u00E7\u00E3o para o telefone em quest\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ReenviarTokenSMSAsyncWithHttpInfo (CodigoSegurancaSMSPersist persist);
        
        /// <summary>
        /// Responder SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar a resposta do SMS, fornecida pedo usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00FAmero (optional)</param>
        /// <param name="data">Data (optional)</param>
        /// <param name="resposta">TextoStatus (optional)</param>
        /// <returns>Task of NotificacaoSMSResponse</returns>
        System.Threading.Tasks.Task<NotificacaoSMSResponse> ResponderSMSGetAsync (string nsu = null, string data = null, string resposta = null);

        /// <summary>
        /// Responder SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar a resposta do SMS, fornecida pedo usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00FAmero (optional)</param>
        /// <param name="data">Data (optional)</param>
        /// <param name="resposta">TextoStatus (optional)</param>
        /// <returns>Task of ApiResponse (NotificacaoSMSResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<NotificacaoSMSResponse>> ResponderSMSGetAsyncWithHttpInfo (string nsu = null, string data = null, string resposta = null);
        
        /// <summary>
        /// Salva configura\u00E7\u00F5es de E-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso salvar configura\u00E7\u00F5es de E-mail
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ConfiguracaoEmailResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoEmailResponse> SalvarConfiguracaoAsync (ConfiguracaoEmailPersist persist);

        /// <summary>
        /// Salva configura\u00E7\u00F5es de E-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso salvar configura\u00E7\u00F5es de E-mail
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoEmailResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoEmailResponse>> SalvarConfiguracaoAsyncWithHttpInfo (ConfiguracaoEmailPersist persist);
        
        /// <summary>
        /// Enviar Push APNS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00E9s da plataforma APNS (Apple Push Notification Service)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of NotificacaoResponse</returns>
        System.Threading.Tasks.Task<NotificacaoResponse> SalvarPushAsync (List<PushAPNS> pushPersists);

        /// <summary>
        /// Enviar Push APNS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00E9s da plataforma APNS (Apple Push Notification Service)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of ApiResponse (NotificacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<NotificacaoResponse>> SalvarPushAsyncWithHttpInfo (List<PushAPNS> pushPersists);
        
        /// <summary>
        /// Enviar Push FCM
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00E9s da plataforma FCM (Firebase Cloud Messaging)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of NotificacaoResponse</returns>
        System.Threading.Tasks.Task<NotificacaoResponse> SalvarPushFCMAsync (List<PushFCMEGCM> pushPersists);

        /// <summary>
        /// Enviar Push FCM
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00E9s da plataforma FCM (Firebase Cloud Messaging)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of ApiResponse (NotificacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<NotificacaoResponse>> SalvarPushFCMAsyncWithHttpInfo (List<PushFCMEGCM> pushPersists);
        
        /// <summary>
        /// Enviar Push GCM
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00E9s da plataforma GCM (Google Cloud Messaging)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of NotificacaoResponse</returns>
        System.Threading.Tasks.Task<NotificacaoResponse> SalvarPushGCMAsync (List<PushFCMEGCM> pushPersists);

        /// <summary>
        /// Enviar Push GCM
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00E9s da plataforma GCM (Google Cloud Messaging)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of ApiResponse (NotificacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<NotificacaoResponse>> SalvarPushGCMAsyncWithHttpInfo (List<PushFCMEGCM> pushPersists);
        
        /// <summary>
        /// Enviar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar uma lista de SMS
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listaSMS">listaSMS</param>
        /// <returns>Task of NotificacaoResponse</returns>
        System.Threading.Tasks.Task<NotificacaoResponse> SalvarSMSAsync (List<NotificacaoSMSBody> listaSMS);

        /// <summary>
        /// Enviar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite enviar uma lista de SMS
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listaSMS">listaSMS</param>
        /// <returns>Task of ApiResponse (NotificacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<NotificacaoResponse>> SalvarSMSAsyncWithHttpInfo (List<NotificacaoSMSBody> listaSMS);
        
        /// <summary>
        /// Salva template de notifica\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Esse recurso salvar template notifica\u00E7\u00F5e
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conteudo">Template HTML</param>
        /// <param name="idConfiguracaoEmail">C\u00F3digo de identifica\u00E7\u00E3o da configra\u00E7\u00E3o de EMAIL (optional)</param>
        /// <param name="tipoLayout">Tipo do layout (optional)</param>
        /// <param name="tipoNotificacao">Tipo da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="remetente">Remetente (optional)</param>
        /// <param name="assunto">Assunto da Notificaca\u00E7\u00E3o (optional)</param>
        /// <param name="templatePadrao">Template Padr\u00E3o (optional)</param>
        /// <returns>Task of TemplateNotificacaoDetalheResponse</returns>
        System.Threading.Tasks.Task<TemplateNotificacaoDetalheResponse> SalvarTemplateNotificacaoAsync (string conteudo, long? idConfiguracaoEmail = null, string tipoLayout = null, string tipoNotificacao = null, string remetente = null, string assunto = null, bool? templatePadrao = null);

        /// <summary>
        /// Salva template de notifica\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Esse recurso salvar template notifica\u00E7\u00F5e
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conteudo">Template HTML</param>
        /// <param name="idConfiguracaoEmail">C\u00F3digo de identifica\u00E7\u00E3o da configra\u00E7\u00E3o de EMAIL (optional)</param>
        /// <param name="tipoLayout">Tipo do layout (optional)</param>
        /// <param name="tipoNotificacao">Tipo da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="remetente">Remetente (optional)</param>
        /// <param name="assunto">Assunto da Notificaca\u00E7\u00E3o (optional)</param>
        /// <param name="templatePadrao">Template Padr\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (TemplateNotificacaoDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TemplateNotificacaoDetalheResponse>> SalvarTemplateNotificacaoAsyncWithHttpInfo (string conteudo, long? idConfiguracaoEmail = null, string tipoLayout = null, string tipoNotificacao = null, string remetente = null, string assunto = null, bool? templatePadrao = null);
        
        /// <summary>
        /// Validar c\u00F3digo de seguran\u00E7a enviado por e-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite validar os c\u00F3digos de seguran\u00E7a enviador por e-mail, para valida\u00E7\u00E3o de dispositivos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ValidarTokenEMAILAsync (CodigoSegurancaEMAILPersist request);

        /// <summary>
        /// Validar c\u00F3digo de seguran\u00E7a enviado por e-mail
        /// </summary>
        /// <remarks>
        /// Esse recurso permite validar os c\u00F3digos de seguran\u00E7a enviador por e-mail, para valida\u00E7\u00E3o de dispositivos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ValidarTokenEMAILAsyncWithHttpInfo (CodigoSegurancaEMAILPersist request);
        
        /// <summary>
        /// Validar c\u00F3digo de seguran\u00E7a enviado por sms
        /// </summary>
        /// <remarks>
        /// Esse recurso permite validar os c\u00F3digos de seguran\u00E7a enviador por sms, para valida\u00E7\u00E3o de dispositivos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ValidarTokenSMSAsync (CodigoSegurancaSMSRequest request);

        /// <summary>
        /// Validar c\u00F3digo de seguran\u00E7a enviado por sms
        /// </summary>
        /// <remarks>
        /// Esse recurso permite validar os c\u00F3digos de seguran\u00E7a enviador por sms, para valida\u00E7\u00E3o de dispositivos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ValidarTokenSMSAsyncWithHttpInfo (CodigoSegurancaSMSRequest request);
        
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
        /// Altera configura\u00E7\u00F5es de E-mail Esse recurso permite salvar altera\u00E7\u00F5es de configura\u00E7\u00F5es de E-mail
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o de e-mail</param> 
        /// <param name="persist">persist</param> 
        /// <returns>ConfiguracaoEmailResponse</returns>
        public ConfiguracaoEmailResponse AlterarConfiguracao (long? id, ConfiguracaoEmailPersist persist)
        {
             ApiResponse<ConfiguracaoEmailResponse> localVarResponse = AlterarConfiguracaoWithHttpInfo(id, persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera configura\u00E7\u00F5es de E-mail Esse recurso permite salvar altera\u00E7\u00F5es de configura\u00E7\u00F5es de E-mail
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o de e-mail</param> 
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of ConfiguracaoEmailResponse</returns>
        public ApiResponse< ConfiguracaoEmailResponse > AlterarConfiguracaoWithHttpInfo (long? id, ConfiguracaoEmailPersist persist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling NotificacaoApi->AlterarConfiguracao");
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling NotificacaoApi->AlterarConfiguracao");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarConfiguracao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarConfiguracao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConfiguracaoEmailResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoEmailResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoEmailResponse)));
            
        }

        
        /// <summary>
        /// Altera configura\u00E7\u00F5es de E-mail Esse recurso permite salvar altera\u00E7\u00F5es de configura\u00E7\u00F5es de E-mail
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o de e-mail</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ConfiguracaoEmailResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoEmailResponse> AlterarConfiguracaoAsync (long? id, ConfiguracaoEmailPersist persist)
        {
             ApiResponse<ConfiguracaoEmailResponse> localVarResponse = await AlterarConfiguracaoAsyncWithHttpInfo(id, persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera configura\u00E7\u00F5es de E-mail Esse recurso permite salvar altera\u00E7\u00F5es de configura\u00E7\u00F5es de E-mail
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o de e-mail</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoEmailResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfiguracaoEmailResponse>> AlterarConfiguracaoAsyncWithHttpInfo (long? id, ConfiguracaoEmailPersist persist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarConfiguracao");
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling AlterarConfiguracao");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarConfiguracao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarConfiguracao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfiguracaoEmailResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoEmailResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoEmailResponse)));
            
        }
        
        /// <summary>
        /// Alterar template de notifica\u00E7\u00E3o Esse recurso permite salvar altera\u00E7\u00F5es de templates notifica\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do layout de e-mail</param> 
        /// <param name="conteudo">Template HTML</param> 
        /// <param name="idConfiguracaoEmail">C\u00F3digo de identifica\u00E7\u00E3o da configra\u00E7\u00E3o de EMAIL (optional)</param> 
        /// <param name="tipoLayout">Tipo do layout (optional)</param> 
        /// <param name="tipoNotificacao">Tipo da notifica\u00E7\u00E3o (optional)</param> 
        /// <param name="remetente">Remetente (optional)</param> 
        /// <param name="assunto">Assunto da Notificaca\u00E7\u00E3o (optional)</param> 
        /// <param name="templatePadrao">Template Padr\u00E3o (optional)</param> 
        /// <returns>TemplateNotificacaoDetalheResponse</returns>
        public TemplateNotificacaoDetalheResponse AlterarTemplateNotificacao (long? id, string conteudo, long? idConfiguracaoEmail = null, string tipoLayout = null, string tipoNotificacao = null, string remetente = null, string assunto = null, bool? templatePadrao = null)
        {
             ApiResponse<TemplateNotificacaoDetalheResponse> localVarResponse = AlterarTemplateNotificacaoWithHttpInfo(id, conteudo, idConfiguracaoEmail, tipoLayout, tipoNotificacao, remetente, assunto, templatePadrao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar template de notifica\u00E7\u00E3o Esse recurso permite salvar altera\u00E7\u00F5es de templates notifica\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do layout de e-mail</param> 
        /// <param name="conteudo">Template HTML</param> 
        /// <param name="idConfiguracaoEmail">C\u00F3digo de identifica\u00E7\u00E3o da configra\u00E7\u00E3o de EMAIL (optional)</param> 
        /// <param name="tipoLayout">Tipo do layout (optional)</param> 
        /// <param name="tipoNotificacao">Tipo da notifica\u00E7\u00E3o (optional)</param> 
        /// <param name="remetente">Remetente (optional)</param> 
        /// <param name="assunto">Assunto da Notificaca\u00E7\u00E3o (optional)</param> 
        /// <param name="templatePadrao">Template Padr\u00E3o (optional)</param> 
        /// <returns>ApiResponse of TemplateNotificacaoDetalheResponse</returns>
        public ApiResponse< TemplateNotificacaoDetalheResponse > AlterarTemplateNotificacaoWithHttpInfo (long? id, string conteudo, long? idConfiguracaoEmail = null, string tipoLayout = null, string tipoNotificacao = null, string remetente = null, string assunto = null, bool? templatePadrao = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling NotificacaoApi->AlterarTemplateNotificacao");
            
            // verify the required parameter 'conteudo' is set
            if (conteudo == null)
                throw new ApiException(400, "Missing required parameter 'conteudo' when calling NotificacaoApi->AlterarTemplateNotificacao");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarTemplateNotificacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTemplateNotificacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TemplateNotificacaoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateNotificacaoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TemplateNotificacaoDetalheResponse)));
            
        }

        
        /// <summary>
        /// Alterar template de notifica\u00E7\u00E3o Esse recurso permite salvar altera\u00E7\u00F5es de templates notifica\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do layout de e-mail</param>
        /// <param name="conteudo">Template HTML</param>
        /// <param name="idConfiguracaoEmail">C\u00F3digo de identifica\u00E7\u00E3o da configra\u00E7\u00E3o de EMAIL (optional)</param>
        /// <param name="tipoLayout">Tipo do layout (optional)</param>
        /// <param name="tipoNotificacao">Tipo da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="remetente">Remetente (optional)</param>
        /// <param name="assunto">Assunto da Notificaca\u00E7\u00E3o (optional)</param>
        /// <param name="templatePadrao">Template Padr\u00E3o (optional)</param>
        /// <returns>Task of TemplateNotificacaoDetalheResponse</returns>
        public async System.Threading.Tasks.Task<TemplateNotificacaoDetalheResponse> AlterarTemplateNotificacaoAsync (long? id, string conteudo, long? idConfiguracaoEmail = null, string tipoLayout = null, string tipoNotificacao = null, string remetente = null, string assunto = null, bool? templatePadrao = null)
        {
             ApiResponse<TemplateNotificacaoDetalheResponse> localVarResponse = await AlterarTemplateNotificacaoAsyncWithHttpInfo(id, conteudo, idConfiguracaoEmail, tipoLayout, tipoNotificacao, remetente, assunto, templatePadrao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Alterar template de notifica\u00E7\u00E3o Esse recurso permite salvar altera\u00E7\u00F5es de templates notifica\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do layout de e-mail</param>
        /// <param name="conteudo">Template HTML</param>
        /// <param name="idConfiguracaoEmail">C\u00F3digo de identifica\u00E7\u00E3o da configra\u00E7\u00E3o de EMAIL (optional)</param>
        /// <param name="tipoLayout">Tipo do layout (optional)</param>
        /// <param name="tipoNotificacao">Tipo da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="remetente">Remetente (optional)</param>
        /// <param name="assunto">Assunto da Notificaca\u00E7\u00E3o (optional)</param>
        /// <param name="templatePadrao">Template Padr\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (TemplateNotificacaoDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TemplateNotificacaoDetalheResponse>> AlterarTemplateNotificacaoAsyncWithHttpInfo (long? id, string conteudo, long? idConfiguracaoEmail = null, string tipoLayout = null, string tipoNotificacao = null, string remetente = null, string assunto = null, bool? templatePadrao = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarTemplateNotificacao");
            // verify the required parameter 'conteudo' is set
            if (conteudo == null) throw new ApiException(400, "Missing required parameter 'conteudo' when calling AlterarTemplateNotificacao");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarTemplateNotificacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTemplateNotificacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TemplateNotificacaoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateNotificacaoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TemplateNotificacaoDetalheResponse)));
            
        }
        
        /// <summary>
        /// Atualizar SMS Esse recurso permite atualizar o status do SMS do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00FAmero (optional)</param> 
        /// <param name="status">Status (optional)</param> 
        /// <param name="data">Data (optional)</param> 
        /// <param name="textoStatus">TextoStatus (optional)</param> 
        /// <param name="operadora">Operadora (optional)</param> 
        /// <returns>NotificacaoSMSResponse</returns>
        public NotificacaoSMSResponse AtualizarSMS (string nsu = null, string status = null, string data = null, string textoStatus = null, string operadora = null)
        {
             ApiResponse<NotificacaoSMSResponse> localVarResponse = AtualizarSMSWithHttpInfo(nsu, status, data, textoStatus, operadora);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualizar SMS Esse recurso permite atualizar o status do SMS do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00FAmero (optional)</param> 
        /// <param name="status">Status (optional)</param> 
        /// <param name="data">Data (optional)</param> 
        /// <param name="textoStatus">TextoStatus (optional)</param> 
        /// <param name="operadora">Operadora (optional)</param> 
        /// <returns>ApiResponse of NotificacaoSMSResponse</returns>
        public ApiResponse< NotificacaoSMSResponse > AtualizarSMSWithHttpInfo (string nsu = null, string status = null, string data = null, string textoStatus = null, string operadora = null)
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
                throw new ApiException (localVarStatusCode, "Error calling AtualizarSMS: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarSMS: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<NotificacaoSMSResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificacaoSMSResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificacaoSMSResponse)));
            
        }

        
        /// <summary>
        /// Atualizar SMS Esse recurso permite atualizar o status do SMS do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00FAmero (optional)</param>
        /// <param name="status">Status (optional)</param>
        /// <param name="data">Data (optional)</param>
        /// <param name="textoStatus">TextoStatus (optional)</param>
        /// <param name="operadora">Operadora (optional)</param>
        /// <returns>Task of NotificacaoSMSResponse</returns>
        public async System.Threading.Tasks.Task<NotificacaoSMSResponse> AtualizarSMSAsync (string nsu = null, string status = null, string data = null, string textoStatus = null, string operadora = null)
        {
             ApiResponse<NotificacaoSMSResponse> localVarResponse = await AtualizarSMSAsyncWithHttpInfo(nsu, status, data, textoStatus, operadora);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualizar SMS Esse recurso permite atualizar o status do SMS do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00FAmero (optional)</param>
        /// <param name="status">Status (optional)</param>
        /// <param name="data">Data (optional)</param>
        /// <param name="textoStatus">TextoStatus (optional)</param>
        /// <param name="operadora">Operadora (optional)</param>
        /// <returns>Task of ApiResponse (NotificacaoSMSResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NotificacaoSMSResponse>> AtualizarSMSAsyncWithHttpInfo (string nsu = null, string status = null, string data = null, string textoStatus = null, string operadora = null)
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
                throw new ApiException (localVarStatusCode, "Error calling AtualizarSMS: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarSMS: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NotificacaoSMSResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificacaoSMSResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificacaoSMSResponse)));
            
        }
        
        /// <summary>
        /// Consulta configura\u00E7\u00E3o de E-mail Esse recurso permite consultar uma configura\u00E7\u00E3o espec\u00EDfica por id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o de e-mail</param> 
        /// <returns>ConfiguracaoEmailResponse</returns>
        public ConfiguracaoEmailResponse ConsultarConfiguracao (long? id)
        {
             ApiResponse<ConfiguracaoEmailResponse> localVarResponse = ConsultarConfiguracaoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta configura\u00E7\u00E3o de E-mail Esse recurso permite consultar uma configura\u00E7\u00E3o espec\u00EDfica por id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o de e-mail</param> 
        /// <returns>ApiResponse of ConfiguracaoEmailResponse</returns>
        public ApiResponse< ConfiguracaoEmailResponse > ConsultarConfiguracaoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling NotificacaoApi->ConsultarConfiguracao");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarConfiguracao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarConfiguracao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConfiguracaoEmailResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoEmailResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoEmailResponse)));
            
        }

        
        /// <summary>
        /// Consulta configura\u00E7\u00E3o de E-mail Esse recurso permite consultar uma configura\u00E7\u00E3o espec\u00EDfica por id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o de e-mail</param>
        /// <returns>Task of ConfiguracaoEmailResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoEmailResponse> ConsultarConfiguracaoAsync (long? id)
        {
             ApiResponse<ConfiguracaoEmailResponse> localVarResponse = await ConsultarConfiguracaoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta configura\u00E7\u00E3o de E-mail Esse recurso permite consultar uma configura\u00E7\u00E3o espec\u00EDfica por id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o de e-mail</param>
        /// <returns>Task of ApiResponse (ConfiguracaoEmailResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfiguracaoEmailResponse>> ConsultarConfiguracaoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarConfiguracao");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarConfiguracao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarConfiguracao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfiguracaoEmailResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoEmailResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoEmailResponse)));
            
        }
        
        /// <summary>
        /// Consulta c\u00F3digo de seguran\u00E7a E-mail Esse recurso permite consultar um c\u00F3digo de seguran\u00E7a E-mail espec\u00EDfico por id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o de e-mail</param> 
        /// <returns>CodigoSegurancaResponse</returns>
        public CodigoSegurancaResponse ConsultarPorEmail (long? id)
        {
             ApiResponse<CodigoSegurancaResponse> localVarResponse = ConsultarPorEmailWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta c\u00F3digo de seguran\u00E7a E-mail Esse recurso permite consultar um c\u00F3digo de seguran\u00E7a E-mail espec\u00EDfico por id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o de e-mail</param> 
        /// <returns>ApiResponse of CodigoSegurancaResponse</returns>
        public ApiResponse< CodigoSegurancaResponse > ConsultarPorEmailWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling NotificacaoApi->ConsultarPorEmail");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPorEmail: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPorEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CodigoSegurancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CodigoSegurancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CodigoSegurancaResponse)));
            
        }

        
        /// <summary>
        /// Consulta c\u00F3digo de seguran\u00E7a E-mail Esse recurso permite consultar um c\u00F3digo de seguran\u00E7a E-mail espec\u00EDfico por id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o de e-mail</param>
        /// <returns>Task of CodigoSegurancaResponse</returns>
        public async System.Threading.Tasks.Task<CodigoSegurancaResponse> ConsultarPorEmailAsync (long? id)
        {
             ApiResponse<CodigoSegurancaResponse> localVarResponse = await ConsultarPorEmailAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta c\u00F3digo de seguran\u00E7a E-mail Esse recurso permite consultar um c\u00F3digo de seguran\u00E7a E-mail espec\u00EDfico por id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o de e-mail</param>
        /// <returns>Task of ApiResponse (CodigoSegurancaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CodigoSegurancaResponse>> ConsultarPorEmailAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarPorEmail");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPorEmail: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPorEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CodigoSegurancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CodigoSegurancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CodigoSegurancaResponse)));
            
        }
        
        /// <summary>
        /// Consulta c\u00F3digo de seguran\u00E7a SMS Esse recurso permite consultar um c\u00F3digo de seguran\u00E7a SMS espec\u00EDfico por id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o de e-mail</param> 
        /// <returns>CodigoSegurancaResponse</returns>
        public CodigoSegurancaResponse ConsultarPorSMS (long? id)
        {
             ApiResponse<CodigoSegurancaResponse> localVarResponse = ConsultarPorSMSWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta c\u00F3digo de seguran\u00E7a SMS Esse recurso permite consultar um c\u00F3digo de seguran\u00E7a SMS espec\u00EDfico por id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o de e-mail</param> 
        /// <returns>ApiResponse of CodigoSegurancaResponse</returns>
        public ApiResponse< CodigoSegurancaResponse > ConsultarPorSMSWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling NotificacaoApi->ConsultarPorSMS");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPorSMS: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPorSMS: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CodigoSegurancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CodigoSegurancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CodigoSegurancaResponse)));
            
        }

        
        /// <summary>
        /// Consulta c\u00F3digo de seguran\u00E7a SMS Esse recurso permite consultar um c\u00F3digo de seguran\u00E7a SMS espec\u00EDfico por id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o de e-mail</param>
        /// <returns>Task of CodigoSegurancaResponse</returns>
        public async System.Threading.Tasks.Task<CodigoSegurancaResponse> ConsultarPorSMSAsync (long? id)
        {
             ApiResponse<CodigoSegurancaResponse> localVarResponse = await ConsultarPorSMSAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta c\u00F3digo de seguran\u00E7a SMS Esse recurso permite consultar um c\u00F3digo de seguran\u00E7a SMS espec\u00EDfico por id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o de e-mail</param>
        /// <returns>Task of ApiResponse (CodigoSegurancaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CodigoSegurancaResponse>> ConsultarPorSMSAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarPorSMS");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPorSMS: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPorSMS: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CodigoSegurancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CodigoSegurancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CodigoSegurancaResponse)));
            
        }
        
        /// <summary>
        /// Consulta template de notifica\u00E7\u00E3o Esse recurso permite consultar uma configura\u00E7\u00E3o espec\u00EDfica por id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do layout de e-mail</param> 
        /// <returns>TemplateNotificacaoDetalheResponse</returns>
        public TemplateNotificacaoDetalheResponse ConsultarTemplateNotificacao (long? id)
        {
             ApiResponse<TemplateNotificacaoDetalheResponse> localVarResponse = ConsultarTemplateNotificacaoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta template de notifica\u00E7\u00E3o Esse recurso permite consultar uma configura\u00E7\u00E3o espec\u00EDfica por id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do layout de e-mail</param> 
        /// <returns>ApiResponse of TemplateNotificacaoDetalheResponse</returns>
        public ApiResponse< TemplateNotificacaoDetalheResponse > ConsultarTemplateNotificacaoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling NotificacaoApi->ConsultarTemplateNotificacao");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTemplateNotificacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTemplateNotificacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TemplateNotificacaoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateNotificacaoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TemplateNotificacaoDetalheResponse)));
            
        }

        
        /// <summary>
        /// Consulta template de notifica\u00E7\u00E3o Esse recurso permite consultar uma configura\u00E7\u00E3o espec\u00EDfica por id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do layout de e-mail</param>
        /// <returns>Task of TemplateNotificacaoDetalheResponse</returns>
        public async System.Threading.Tasks.Task<TemplateNotificacaoDetalheResponse> ConsultarTemplateNotificacaoAsync (long? id)
        {
             ApiResponse<TemplateNotificacaoDetalheResponse> localVarResponse = await ConsultarTemplateNotificacaoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta template de notifica\u00E7\u00E3o Esse recurso permite consultar uma configura\u00E7\u00E3o espec\u00EDfica por id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do layout de e-mail</param>
        /// <returns>Task of ApiResponse (TemplateNotificacaoDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TemplateNotificacaoDetalheResponse>> ConsultarTemplateNotificacaoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarTemplateNotificacao");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTemplateNotificacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTemplateNotificacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TemplateNotificacaoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateNotificacaoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TemplateNotificacaoDetalheResponse)));
            
        }
        
        /// <summary>
        /// Enviar OTP 3D Secure Esse recursos permite enviar uma notifica\u00E7\u00E3o com o OTP do 3D Secure para um determinado cliente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="secure3dRequest">secure3dRequest</param> 
        /// <returns>Object</returns>
        public Object EnviarOTP (Secure3dRequest secure3dRequest)
        {
             ApiResponse<Object> localVarResponse = EnviarOTPWithHttpInfo(secure3dRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Enviar OTP 3D Secure Esse recursos permite enviar uma notifica\u00E7\u00E3o com o OTP do 3D Secure para um determinado cliente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="secure3dRequest">secure3dRequest</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > EnviarOTPWithHttpInfo (Secure3dRequest secure3dRequest)
        {
            
            // verify the required parameter 'secure3dRequest' is set
            if (secure3dRequest == null)
                throw new ApiException(400, "Missing required parameter 'secure3dRequest' when calling NotificacaoApi->EnviarOTP");
            
    
            var localVarPath = "/api/notificacoes/3d-secure";
    
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
            
            
            
            
            if (secure3dRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(secure3dRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = secure3dRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling EnviarOTP: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EnviarOTP: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Enviar OTP 3D Secure Esse recursos permite enviar uma notifica\u00E7\u00E3o com o OTP do 3D Secure para um determinado cliente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="secure3dRequest">secure3dRequest</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> EnviarOTPAsync (Secure3dRequest secure3dRequest)
        {
             ApiResponse<Object> localVarResponse = await EnviarOTPAsyncWithHttpInfo(secure3dRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Enviar OTP 3D Secure Esse recursos permite enviar uma notifica\u00E7\u00E3o com o OTP do 3D Secure para um determinado cliente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="secure3dRequest">secure3dRequest</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> EnviarOTPAsyncWithHttpInfo (Secure3dRequest secure3dRequest)
        {
            // verify the required parameter 'secure3dRequest' is set
            if (secure3dRequest == null) throw new ApiException(400, "Missing required parameter 'secure3dRequest' when calling EnviarOTP");
            
    
            var localVarPath = "/api/notificacoes/3d-secure";
    
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
            
            
            
            
            if (secure3dRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(secure3dRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = secure3dRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling EnviarOTP: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EnviarOTP: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Gerar c\u00F3digo de seguran\u00E7a e enviar por e-mail Esse recurso permite gerar e enviar c\u00F3digos de seguran\u00E7a por e-mail, para valida\u00E7\u00E3o de dispositivos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">email</param> 
        /// <returns>string</returns>
        public string GerarTokenEMAIL (string email)
        {
             ApiResponse<string> localVarResponse = GerarTokenEMAILWithHttpInfo(email);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gerar c\u00F3digo de seguran\u00E7a e enviar por e-mail Esse recurso permite gerar e enviar c\u00F3digos de seguran\u00E7a por e-mail, para valida\u00E7\u00E3o de dispositivos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">email</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > GerarTokenEMAILWithHttpInfo (string email)
        {
            
            // verify the required parameter 'email' is set
            if (email == null)
                throw new ApiException(400, "Missing required parameter 'email' when calling NotificacaoApi->GerarTokenEMAIL");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GerarTokenEMAIL: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarTokenEMAIL: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Gerar c\u00F3digo de seguran\u00E7a e enviar por e-mail Esse recurso permite gerar e enviar c\u00F3digos de seguran\u00E7a por e-mail, para valida\u00E7\u00E3o de dispositivos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">email</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> GerarTokenEMAILAsync (string email)
        {
             ApiResponse<string> localVarResponse = await GerarTokenEMAILAsyncWithHttpInfo(email);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gerar c\u00F3digo de seguran\u00E7a e enviar por e-mail Esse recurso permite gerar e enviar c\u00F3digos de seguran\u00E7a por e-mail, para valida\u00E7\u00E3o de dispositivos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">email</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> GerarTokenEMAILAsyncWithHttpInfo (string email)
        {
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling GerarTokenEMAIL");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GerarTokenEMAIL: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarTokenEMAIL: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Gerar c\u00F3digo de seguran\u00E7a e enviar por sms Esse recurso permite gerar e enviar c\u00F3digos de seguran\u00E7a por sms, para valida\u00E7\u00E3o de dispositivos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>string</returns>
        public string GerarTokenSMS (CodigoSegurancaSMSPersist persist)
        {
             ApiResponse<string> localVarResponse = GerarTokenSMSWithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gerar c\u00F3digo de seguran\u00E7a e enviar por sms Esse recurso permite gerar e enviar c\u00F3digos de seguran\u00E7a por sms, para valida\u00E7\u00E3o de dispositivos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > GerarTokenSMSWithHttpInfo (CodigoSegurancaSMSPersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling NotificacaoApi->GerarTokenSMS");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GerarTokenSMS: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarTokenSMS: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Gerar c\u00F3digo de seguran\u00E7a e enviar por sms Esse recurso permite gerar e enviar c\u00F3digos de seguran\u00E7a por sms, para valida\u00E7\u00E3o de dispositivos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> GerarTokenSMSAsync (CodigoSegurancaSMSPersist persist)
        {
             ApiResponse<string> localVarResponse = await GerarTokenSMSAsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gerar c\u00F3digo de seguran\u00E7a e enviar por sms Esse recurso permite gerar e enviar c\u00F3digos de seguran\u00E7a por sms, para valida\u00E7\u00E3o de dispositivos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> GerarTokenSMSAsyncWithHttpInfo (CodigoSegurancaSMSPersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling GerarTokenSMS");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GerarTokenSMS: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarTokenSMS: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Lista configura\u00E7\u00F5es de E-mails Esse recurso permite listar as configura\u00E7\u00F5es de E-mails
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageConfiguracaoEmailResponse</returns>
        public PageConfiguracaoEmailResponse ListarConfiguracao (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageConfiguracaoEmailResponse> localVarResponse = ListarConfiguracaoWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista configura\u00E7\u00F5es de E-mails Esse recurso permite listar as configura\u00E7\u00F5es de E-mails
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageConfiguracaoEmailResponse</returns>
        public ApiResponse< PageConfiguracaoEmailResponse > ListarConfiguracaoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarConfiguracao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarConfiguracao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageConfiguracaoEmailResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageConfiguracaoEmailResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageConfiguracaoEmailResponse)));
            
        }

        
        /// <summary>
        /// Lista configura\u00E7\u00F5es de E-mails Esse recurso permite listar as configura\u00E7\u00F5es de E-mails
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageConfiguracaoEmailResponse</returns>
        public async System.Threading.Tasks.Task<PageConfiguracaoEmailResponse> ListarConfiguracaoAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageConfiguracaoEmailResponse> localVarResponse = await ListarConfiguracaoAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista configura\u00E7\u00F5es de E-mails Esse recurso permite listar as configura\u00E7\u00F5es de E-mails
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageConfiguracaoEmailResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageConfiguracaoEmailResponse>> ListarConfiguracaoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarConfiguracao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarConfiguracao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageConfiguracaoEmailResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageConfiguracaoEmailResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageConfiguracaoEmailResponse)));
            
        }
        
        /// <summary>
        /// Lista os c\u00F3digos de seguran\u00E7a E-Mail Esse recurso permite listar os codigos de seguran\u00E7a por E-Mail
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageCodigoSegurancaResponse</returns>
        public PageCodigoSegurancaResponse ListarPorEmail (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCodigoSegurancaResponse> localVarResponse = ListarPorEmailWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os c\u00F3digos de seguran\u00E7a E-Mail Esse recurso permite listar os codigos de seguran\u00E7a por E-Mail
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageCodigoSegurancaResponse</returns>
        public ApiResponse< PageCodigoSegurancaResponse > ListarPorEmailWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarPorEmail: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPorEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCodigoSegurancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCodigoSegurancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCodigoSegurancaResponse)));
            
        }

        
        /// <summary>
        /// Lista os c\u00F3digos de seguran\u00E7a E-Mail Esse recurso permite listar os codigos de seguran\u00E7a por E-Mail
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageCodigoSegurancaResponse</returns>
        public async System.Threading.Tasks.Task<PageCodigoSegurancaResponse> ListarPorEmailAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCodigoSegurancaResponse> localVarResponse = await ListarPorEmailAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os c\u00F3digos de seguran\u00E7a E-Mail Esse recurso permite listar os codigos de seguran\u00E7a por E-Mail
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCodigoSegurancaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCodigoSegurancaResponse>> ListarPorEmailAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarPorEmail: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPorEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCodigoSegurancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCodigoSegurancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCodigoSegurancaResponse)));
            
        }
        
        /// <summary>
        /// Lista os c\u00F3digos de seguran\u00E7a SMS Esse recurso permite listar os codigos de seguran\u00E7a por SMS
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageCodigoSegurancaResponse</returns>
        public PageCodigoSegurancaResponse ListarPorSMS (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCodigoSegurancaResponse> localVarResponse = ListarPorSMSWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os c\u00F3digos de seguran\u00E7a SMS Esse recurso permite listar os codigos de seguran\u00E7a por SMS
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageCodigoSegurancaResponse</returns>
        public ApiResponse< PageCodigoSegurancaResponse > ListarPorSMSWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarPorSMS: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPorSMS: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCodigoSegurancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCodigoSegurancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCodigoSegurancaResponse)));
            
        }

        
        /// <summary>
        /// Lista os c\u00F3digos de seguran\u00E7a SMS Esse recurso permite listar os codigos de seguran\u00E7a por SMS
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageCodigoSegurancaResponse</returns>
        public async System.Threading.Tasks.Task<PageCodigoSegurancaResponse> ListarPorSMSAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCodigoSegurancaResponse> localVarResponse = await ListarPorSMSAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os c\u00F3digos de seguran\u00E7a SMS Esse recurso permite listar os codigos de seguran\u00E7a por SMS
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCodigoSegurancaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCodigoSegurancaResponse>> ListarPorSMSAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarPorSMS: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPorSMS: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCodigoSegurancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCodigoSegurancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCodigoSegurancaResponse)));
            
        }
        
        /// <summary>
        /// Listar Push Esse recurso permite listar os Pushes do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="dataEnvio">Apresenta a data e em que o registro foi enviado para o dispositivo (optional)</param> 
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00E7\u00E3o (optional)</param> 
        /// <param name="status">Status de envio da notifica\u00E7\u00E3o (optional)</param> 
        /// <param name="plataforma">Plataforma de Push notifications (optional)</param> 
        /// <param name="protocolo">N\u00FAmero do protocolo de envio de notifica\u00E7\u00F5es (optional)</param> 
        /// <returns>PagePushResponse</returns>
        public PagePushResponse ListarPush (List<string> sort = null, int? page = null, int? limit = null, string dataEnvio = null, string tipoEvento = null, string status = null, string plataforma = null, string protocolo = null)
        {
             ApiResponse<PagePushResponse> localVarResponse = ListarPushWithHttpInfo(sort, page, limit, dataEnvio, tipoEvento, status, plataforma, protocolo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar Push Esse recurso permite listar os Pushes do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="dataEnvio">Apresenta a data e em que o registro foi enviado para o dispositivo (optional)</param> 
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00E7\u00E3o (optional)</param> 
        /// <param name="status">Status de envio da notifica\u00E7\u00E3o (optional)</param> 
        /// <param name="plataforma">Plataforma de Push notifications (optional)</param> 
        /// <param name="protocolo">N\u00FAmero do protocolo de envio de notifica\u00E7\u00F5es (optional)</param> 
        /// <returns>ApiResponse of PagePushResponse</returns>
        public ApiResponse< PagePushResponse > ListarPushWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataEnvio = null, string tipoEvento = null, string status = null, string plataforma = null, string protocolo = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarPush: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPush: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePushResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePushResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePushResponse)));
            
        }

        
        /// <summary>
        /// Listar Push Esse recurso permite listar os Pushes do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataEnvio">Apresenta a data e em que o registro foi enviado para o dispositivo (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="plataforma">Plataforma de Push notifications (optional)</param>
        /// <param name="protocolo">N\u00FAmero do protocolo de envio de notifica\u00E7\u00F5es (optional)</param>
        /// <returns>Task of PagePushResponse</returns>
        public async System.Threading.Tasks.Task<PagePushResponse> ListarPushAsync (List<string> sort = null, int? page = null, int? limit = null, string dataEnvio = null, string tipoEvento = null, string status = null, string plataforma = null, string protocolo = null)
        {
             ApiResponse<PagePushResponse> localVarResponse = await ListarPushAsyncWithHttpInfo(sort, page, limit, dataEnvio, tipoEvento, status, plataforma, protocolo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar Push Esse recurso permite listar os Pushes do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataEnvio">Apresenta a data e em que o registro foi enviado para o dispositivo (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="plataforma">Plataforma de Push notifications (optional)</param>
        /// <param name="protocolo">N\u00FAmero do protocolo de envio de notifica\u00E7\u00F5es (optional)</param>
        /// <returns>Task of ApiResponse (PagePushResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePushResponse>> ListarPushAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataEnvio = null, string tipoEvento = null, string status = null, string plataforma = null, string protocolo = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarPush: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPush: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePushResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePushResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePushResponse)));
            
        }
        
        /// <summary>
        /// Listar SMS Esse recurso permite listar os SMS do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="dataInclusao">Apresenta a data e em que o registro foi inclu\u00EDdo na base para ser enviado (optional)</param> 
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00E7\u00E3o (optional)</param> 
        /// <param name="status">Status de envio da notifica\u00E7\u00E3o (optional)</param> 
        /// <param name="operadora">Nome da operadora a qual a notifica\u00E7\u00E3o foi enviada (optional)</param> 
        /// <param name="protocolo">N\u00FAmero do protocolo de envio de notifica\u00E7\u00F5es (optional)</param> 
        /// <param name="nsu">Apresenta o nsu da notifica\u00E7\u00E3o (optional)</param> 
        /// <returns>PageSMSResponse</returns>
        public PageSMSResponse ListarSMS (List<string> sort = null, int? page = null, int? limit = null, string dataInclusao = null, string tipoEvento = null, string status = null, string operadora = null, string protocolo = null, long? nsu = null)
        {
             ApiResponse<PageSMSResponse> localVarResponse = ListarSMSWithHttpInfo(sort, page, limit, dataInclusao, tipoEvento, status, operadora, protocolo, nsu);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar SMS Esse recurso permite listar os SMS do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="dataInclusao">Apresenta a data e em que o registro foi inclu\u00EDdo na base para ser enviado (optional)</param> 
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00E7\u00E3o (optional)</param> 
        /// <param name="status">Status de envio da notifica\u00E7\u00E3o (optional)</param> 
        /// <param name="operadora">Nome da operadora a qual a notifica\u00E7\u00E3o foi enviada (optional)</param> 
        /// <param name="protocolo">N\u00FAmero do protocolo de envio de notifica\u00E7\u00F5es (optional)</param> 
        /// <param name="nsu">Apresenta o nsu da notifica\u00E7\u00E3o (optional)</param> 
        /// <returns>ApiResponse of PageSMSResponse</returns>
        public ApiResponse< PageSMSResponse > ListarSMSWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataInclusao = null, string tipoEvento = null, string status = null, string operadora = null, string protocolo = null, long? nsu = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarSMS: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarSMS: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageSMSResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageSMSResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageSMSResponse)));
            
        }

        
        /// <summary>
        /// Listar SMS Esse recurso permite listar os SMS do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataInclusao">Apresenta a data e em que o registro foi inclu\u00EDdo na base para ser enviado (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="operadora">Nome da operadora a qual a notifica\u00E7\u00E3o foi enviada (optional)</param>
        /// <param name="protocolo">N\u00FAmero do protocolo de envio de notifica\u00E7\u00F5es (optional)</param>
        /// <param name="nsu">Apresenta o nsu da notifica\u00E7\u00E3o (optional)</param>
        /// <returns>Task of PageSMSResponse</returns>
        public async System.Threading.Tasks.Task<PageSMSResponse> ListarSMSAsync (List<string> sort = null, int? page = null, int? limit = null, string dataInclusao = null, string tipoEvento = null, string status = null, string operadora = null, string protocolo = null, long? nsu = null)
        {
             ApiResponse<PageSMSResponse> localVarResponse = await ListarSMSAsyncWithHttpInfo(sort, page, limit, dataInclusao, tipoEvento, status, operadora, protocolo, nsu);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar SMS Esse recurso permite listar os SMS do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataInclusao">Apresenta a data e em que o registro foi inclu\u00EDdo na base para ser enviado (optional)</param>
        /// <param name="tipoEvento">Nome do tipoEvento da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="status">Status de envio da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="operadora">Nome da operadora a qual a notifica\u00E7\u00E3o foi enviada (optional)</param>
        /// <param name="protocolo">N\u00FAmero do protocolo de envio de notifica\u00E7\u00F5es (optional)</param>
        /// <param name="nsu">Apresenta o nsu da notifica\u00E7\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (PageSMSResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageSMSResponse>> ListarSMSAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataInclusao = null, string tipoEvento = null, string status = null, string operadora = null, string protocolo = null, long? nsu = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarSMS: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarSMS: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageSMSResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageSMSResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageSMSResponse)));
            
        }
        
        /// <summary>
        /// Lista templates de notifica\u00E7\u00F5es Esse recurso permite listar templates notifica\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageTemplateNotificacaoResponse</returns>
        public PageTemplateNotificacaoResponse ListarTemplateNotificacao (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTemplateNotificacaoResponse> localVarResponse = ListarTemplateNotificacaoWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista templates de notifica\u00E7\u00F5es Esse recurso permite listar templates notifica\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageTemplateNotificacaoResponse</returns>
        public ApiResponse< PageTemplateNotificacaoResponse > ListarTemplateNotificacaoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTemplateNotificacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTemplateNotificacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTemplateNotificacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTemplateNotificacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTemplateNotificacaoResponse)));
            
        }

        
        /// <summary>
        /// Lista templates de notifica\u00E7\u00F5es Esse recurso permite listar templates notifica\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageTemplateNotificacaoResponse</returns>
        public async System.Threading.Tasks.Task<PageTemplateNotificacaoResponse> ListarTemplateNotificacaoAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTemplateNotificacaoResponse> localVarResponse = await ListarTemplateNotificacaoAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista templates de notifica\u00E7\u00F5es Esse recurso permite listar templates notifica\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTemplateNotificacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTemplateNotificacaoResponse>> ListarTemplateNotificacaoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTemplateNotificacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTemplateNotificacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTemplateNotificacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTemplateNotificacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTemplateNotificacaoResponse)));
            
        }
        
        /// <summary>
        /// Lista os tipos templates de notifica\u00E7\u00E3o Esse recurso permite listar os tipos de templates dispon\u00EDveis os par\u00E2metros devem ser usados entre chaves. Ex: {{nomeParametro}} 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        public List<Object> ListarTiposLayouts ()
        {
             ApiResponse<List<Object>> localVarResponse = ListarTiposLayoutsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os tipos templates de notifica\u00E7\u00E3o Esse recurso permite listar os tipos de templates dispon\u00EDveis os par\u00E2metros devem ser usados entre chaves. Ex: {{nomeParametro}} 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        public ApiResponse< List<Object> > ListarTiposLayoutsWithHttpInfo ()
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposLayouts: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposLayouts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
            
        }

        
        /// <summary>
        /// Lista os tipos templates de notifica\u00E7\u00E3o Esse recurso permite listar os tipos de templates dispon\u00EDveis os par\u00E2metros devem ser usados entre chaves. Ex: {{nomeParametro}} 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Object&gt;</returns>
        public async System.Threading.Tasks.Task<List<Object>> ListarTiposLayoutsAsync ()
        {
             ApiResponse<List<Object>> localVarResponse = await ListarTiposLayoutsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os tipos templates de notifica\u00E7\u00E3o Esse recurso permite listar os tipos de templates dispon\u00EDveis os par\u00E2metros devem ser usados entre chaves. Ex: {{nomeParametro}} 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Object>>> ListarTiposLayoutsAsyncWithHttpInfo ()
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposLayouts: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposLayouts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
            
        }
        
        /// <summary>
        /// Enviar notifica\u00E7\u00E3o por email Esse recurso permite enviar uma mensagem de notifica\u00E7\u00E3o por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>Object</returns>
        public Object NotificacaoEmail (NotificacaoEmailRequest request)
        {
             ApiResponse<Object> localVarResponse = NotificacaoEmailWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Enviar notifica\u00E7\u00E3o por email Esse recurso permite enviar uma mensagem de notifica\u00E7\u00E3o por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > NotificacaoEmailWithHttpInfo (NotificacaoEmailRequest request)
        {
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling NotificacaoApi->NotificacaoEmail");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling NotificacaoEmail: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NotificacaoEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Enviar notifica\u00E7\u00E3o por email Esse recurso permite enviar uma mensagem de notifica\u00E7\u00E3o por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> NotificacaoEmailAsync (NotificacaoEmailRequest request)
        {
             ApiResponse<Object> localVarResponse = await NotificacaoEmailAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Enviar notifica\u00E7\u00E3o por email Esse recurso permite enviar uma mensagem de notifica\u00E7\u00E3o por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> NotificacaoEmailAsyncWithHttpInfo (NotificacaoEmailRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling NotificacaoEmail");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling NotificacaoEmail: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NotificacaoEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Reenviar c\u00F3digo de seguran\u00E7a por sms Esse recurso permite que seja reenviado para um determinado n\u00FAmero de telefone, atrav\u00E9s de SMS, o c\u00F3digo de seguran\u00E7a gerado previamente para ele. Caso o c\u00F3digo de seguran\u00E7a j\u00E1 n\u00E3o esteja mais v\u00E1lido, o recurso retornar\u00E1 uma mensagem orientando que seja solicitada uma nova gera\u00E7\u00E3o para o telefone em quest\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>string</returns>
        public string ReenviarTokenSMS (CodigoSegurancaSMSPersist persist)
        {
             ApiResponse<string> localVarResponse = ReenviarTokenSMSWithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Reenviar c\u00F3digo de seguran\u00E7a por sms Esse recurso permite que seja reenviado para um determinado n\u00FAmero de telefone, atrav\u00E9s de SMS, o c\u00F3digo de seguran\u00E7a gerado previamente para ele. Caso o c\u00F3digo de seguran\u00E7a j\u00E1 n\u00E3o esteja mais v\u00E1lido, o recurso retornar\u00E1 uma mensagem orientando que seja solicitada uma nova gera\u00E7\u00E3o para o telefone em quest\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ReenviarTokenSMSWithHttpInfo (CodigoSegurancaSMSPersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling NotificacaoApi->ReenviarTokenSMS");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ReenviarTokenSMS: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ReenviarTokenSMS: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Reenviar c\u00F3digo de seguran\u00E7a por sms Esse recurso permite que seja reenviado para um determinado n\u00FAmero de telefone, atrav\u00E9s de SMS, o c\u00F3digo de seguran\u00E7a gerado previamente para ele. Caso o c\u00F3digo de seguran\u00E7a j\u00E1 n\u00E3o esteja mais v\u00E1lido, o recurso retornar\u00E1 uma mensagem orientando que seja solicitada uma nova gera\u00E7\u00E3o para o telefone em quest\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ReenviarTokenSMSAsync (CodigoSegurancaSMSPersist persist)
        {
             ApiResponse<string> localVarResponse = await ReenviarTokenSMSAsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Reenviar c\u00F3digo de seguran\u00E7a por sms Esse recurso permite que seja reenviado para um determinado n\u00FAmero de telefone, atrav\u00E9s de SMS, o c\u00F3digo de seguran\u00E7a gerado previamente para ele. Caso o c\u00F3digo de seguran\u00E7a j\u00E1 n\u00E3o esteja mais v\u00E1lido, o recurso retornar\u00E1 uma mensagem orientando que seja solicitada uma nova gera\u00E7\u00E3o para o telefone em quest\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ReenviarTokenSMSAsyncWithHttpInfo (CodigoSegurancaSMSPersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling ReenviarTokenSMS");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ReenviarTokenSMS: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ReenviarTokenSMS: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Responder SMS Esse recurso permite atualizar a resposta do SMS, fornecida pedo usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00FAmero (optional)</param> 
        /// <param name="data">Data (optional)</param> 
        /// <param name="resposta">TextoStatus (optional)</param> 
        /// <returns>NotificacaoSMSResponse</returns>
        public NotificacaoSMSResponse ResponderSMSGet (string nsu = null, string data = null, string resposta = null)
        {
             ApiResponse<NotificacaoSMSResponse> localVarResponse = ResponderSMSGetWithHttpInfo(nsu, data, resposta);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Responder SMS Esse recurso permite atualizar a resposta do SMS, fornecida pedo usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00FAmero (optional)</param> 
        /// <param name="data">Data (optional)</param> 
        /// <param name="resposta">TextoStatus (optional)</param> 
        /// <returns>ApiResponse of NotificacaoSMSResponse</returns>
        public ApiResponse< NotificacaoSMSResponse > ResponderSMSGetWithHttpInfo (string nsu = null, string data = null, string resposta = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ResponderSMSGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ResponderSMSGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<NotificacaoSMSResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificacaoSMSResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificacaoSMSResponse)));
            
        }

        
        /// <summary>
        /// Responder SMS Esse recurso permite atualizar a resposta do SMS, fornecida pedo usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00FAmero (optional)</param>
        /// <param name="data">Data (optional)</param>
        /// <param name="resposta">TextoStatus (optional)</param>
        /// <returns>Task of NotificacaoSMSResponse</returns>
        public async System.Threading.Tasks.Task<NotificacaoSMSResponse> ResponderSMSGetAsync (string nsu = null, string data = null, string resposta = null)
        {
             ApiResponse<NotificacaoSMSResponse> localVarResponse = await ResponderSMSGetAsyncWithHttpInfo(nsu, data, resposta);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Responder SMS Esse recurso permite atualizar a resposta do SMS, fornecida pedo usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nsu">Seu n\u00FAmero (optional)</param>
        /// <param name="data">Data (optional)</param>
        /// <param name="resposta">TextoStatus (optional)</param>
        /// <returns>Task of ApiResponse (NotificacaoSMSResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NotificacaoSMSResponse>> ResponderSMSGetAsyncWithHttpInfo (string nsu = null, string data = null, string resposta = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ResponderSMSGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ResponderSMSGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NotificacaoSMSResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificacaoSMSResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificacaoSMSResponse)));
            
        }
        
        /// <summary>
        /// Salva configura\u00E7\u00F5es de E-mail Esse recurso salvar configura\u00E7\u00F5es de E-mail
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ConfiguracaoEmailResponse</returns>
        public ConfiguracaoEmailResponse SalvarConfiguracao (ConfiguracaoEmailPersist persist)
        {
             ApiResponse<ConfiguracaoEmailResponse> localVarResponse = SalvarConfiguracaoWithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Salva configura\u00E7\u00F5es de E-mail Esse recurso salvar configura\u00E7\u00F5es de E-mail
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of ConfiguracaoEmailResponse</returns>
        public ApiResponse< ConfiguracaoEmailResponse > SalvarConfiguracaoWithHttpInfo (ConfiguracaoEmailPersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling NotificacaoApi->SalvarConfiguracao");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarConfiguracao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarConfiguracao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConfiguracaoEmailResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoEmailResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoEmailResponse)));
            
        }

        
        /// <summary>
        /// Salva configura\u00E7\u00F5es de E-mail Esse recurso salvar configura\u00E7\u00F5es de E-mail
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ConfiguracaoEmailResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoEmailResponse> SalvarConfiguracaoAsync (ConfiguracaoEmailPersist persist)
        {
             ApiResponse<ConfiguracaoEmailResponse> localVarResponse = await SalvarConfiguracaoAsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Salva configura\u00E7\u00F5es de E-mail Esse recurso salvar configura\u00E7\u00F5es de E-mail
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoEmailResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfiguracaoEmailResponse>> SalvarConfiguracaoAsyncWithHttpInfo (ConfiguracaoEmailPersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarConfiguracao");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarConfiguracao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarConfiguracao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfiguracaoEmailResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoEmailResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoEmailResponse)));
            
        }
        
        /// <summary>
        /// Enviar Push APNS Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00E9s da plataforma APNS (Apple Push Notification Service)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param> 
        /// <returns>NotificacaoResponse</returns>
        public NotificacaoResponse SalvarPush (List<PushAPNS> pushPersists)
        {
             ApiResponse<NotificacaoResponse> localVarResponse = SalvarPushWithHttpInfo(pushPersists);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Enviar Push APNS Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00E9s da plataforma APNS (Apple Push Notification Service)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param> 
        /// <returns>ApiResponse of NotificacaoResponse</returns>
        public ApiResponse< NotificacaoResponse > SalvarPushWithHttpInfo (List<PushAPNS> pushPersists)
        {
            
            // verify the required parameter 'pushPersists' is set
            if (pushPersists == null)
                throw new ApiException(400, "Missing required parameter 'pushPersists' when calling NotificacaoApi->SalvarPush");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarPush: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPush: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<NotificacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificacaoResponse)));
            
        }

        
        /// <summary>
        /// Enviar Push APNS Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00E9s da plataforma APNS (Apple Push Notification Service)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of NotificacaoResponse</returns>
        public async System.Threading.Tasks.Task<NotificacaoResponse> SalvarPushAsync (List<PushAPNS> pushPersists)
        {
             ApiResponse<NotificacaoResponse> localVarResponse = await SalvarPushAsyncWithHttpInfo(pushPersists);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Enviar Push APNS Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00E9s da plataforma APNS (Apple Push Notification Service)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of ApiResponse (NotificacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NotificacaoResponse>> SalvarPushAsyncWithHttpInfo (List<PushAPNS> pushPersists)
        {
            // verify the required parameter 'pushPersists' is set
            if (pushPersists == null) throw new ApiException(400, "Missing required parameter 'pushPersists' when calling SalvarPush");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarPush: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPush: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NotificacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificacaoResponse)));
            
        }
        
        /// <summary>
        /// Enviar Push FCM Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00E9s da plataforma FCM (Firebase Cloud Messaging)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param> 
        /// <returns>NotificacaoResponse</returns>
        public NotificacaoResponse SalvarPushFCM (List<PushFCMEGCM> pushPersists)
        {
             ApiResponse<NotificacaoResponse> localVarResponse = SalvarPushFCMWithHttpInfo(pushPersists);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Enviar Push FCM Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00E9s da plataforma FCM (Firebase Cloud Messaging)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param> 
        /// <returns>ApiResponse of NotificacaoResponse</returns>
        public ApiResponse< NotificacaoResponse > SalvarPushFCMWithHttpInfo (List<PushFCMEGCM> pushPersists)
        {
            
            // verify the required parameter 'pushPersists' is set
            if (pushPersists == null)
                throw new ApiException(400, "Missing required parameter 'pushPersists' when calling NotificacaoApi->SalvarPushFCM");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarPushFCM: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPushFCM: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<NotificacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificacaoResponse)));
            
        }

        
        /// <summary>
        /// Enviar Push FCM Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00E9s da plataforma FCM (Firebase Cloud Messaging)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of NotificacaoResponse</returns>
        public async System.Threading.Tasks.Task<NotificacaoResponse> SalvarPushFCMAsync (List<PushFCMEGCM> pushPersists)
        {
             ApiResponse<NotificacaoResponse> localVarResponse = await SalvarPushFCMAsyncWithHttpInfo(pushPersists);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Enviar Push FCM Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00E9s da plataforma FCM (Firebase Cloud Messaging)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of ApiResponse (NotificacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NotificacaoResponse>> SalvarPushFCMAsyncWithHttpInfo (List<PushFCMEGCM> pushPersists)
        {
            // verify the required parameter 'pushPersists' is set
            if (pushPersists == null) throw new ApiException(400, "Missing required parameter 'pushPersists' when calling SalvarPushFCM");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarPushFCM: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPushFCM: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NotificacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificacaoResponse)));
            
        }
        
        /// <summary>
        /// Enviar Push GCM Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00E9s da plataforma GCM (Google Cloud Messaging)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param> 
        /// <returns>NotificacaoResponse</returns>
        public NotificacaoResponse SalvarPushGCM (List<PushFCMEGCM> pushPersists)
        {
             ApiResponse<NotificacaoResponse> localVarResponse = SalvarPushGCMWithHttpInfo(pushPersists);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Enviar Push GCM Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00E9s da plataforma GCM (Google Cloud Messaging)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param> 
        /// <returns>ApiResponse of NotificacaoResponse</returns>
        public ApiResponse< NotificacaoResponse > SalvarPushGCMWithHttpInfo (List<PushFCMEGCM> pushPersists)
        {
            
            // verify the required parameter 'pushPersists' is set
            if (pushPersists == null)
                throw new ApiException(400, "Missing required parameter 'pushPersists' when calling NotificacaoApi->SalvarPushGCM");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarPushGCM: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPushGCM: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<NotificacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificacaoResponse)));
            
        }

        
        /// <summary>
        /// Enviar Push GCM Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00E9s da plataforma GCM (Google Cloud Messaging)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of NotificacaoResponse</returns>
        public async System.Threading.Tasks.Task<NotificacaoResponse> SalvarPushGCMAsync (List<PushFCMEGCM> pushPersists)
        {
             ApiResponse<NotificacaoResponse> localVarResponse = await SalvarPushGCMAsyncWithHttpInfo(pushPersists);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Enviar Push GCM Esse recurso permite enviar Push para um determinado dipositivo movel atrav\u00E9s da plataforma GCM (Google Cloud Messaging)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushPersists">pushPersists</param>
        /// <returns>Task of ApiResponse (NotificacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NotificacaoResponse>> SalvarPushGCMAsyncWithHttpInfo (List<PushFCMEGCM> pushPersists)
        {
            // verify the required parameter 'pushPersists' is set
            if (pushPersists == null) throw new ApiException(400, "Missing required parameter 'pushPersists' when calling SalvarPushGCM");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarPushGCM: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPushGCM: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NotificacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificacaoResponse)));
            
        }
        
        /// <summary>
        /// Enviar SMS Esse recurso permite enviar uma lista de SMS
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listaSMS">listaSMS</param> 
        /// <returns>NotificacaoResponse</returns>
        public NotificacaoResponse SalvarSMS (List<NotificacaoSMSBody> listaSMS)
        {
             ApiResponse<NotificacaoResponse> localVarResponse = SalvarSMSWithHttpInfo(listaSMS);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Enviar SMS Esse recurso permite enviar uma lista de SMS
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listaSMS">listaSMS</param> 
        /// <returns>ApiResponse of NotificacaoResponse</returns>
        public ApiResponse< NotificacaoResponse > SalvarSMSWithHttpInfo (List<NotificacaoSMSBody> listaSMS)
        {
            
            // verify the required parameter 'listaSMS' is set
            if (listaSMS == null)
                throw new ApiException(400, "Missing required parameter 'listaSMS' when calling NotificacaoApi->SalvarSMS");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarSMS: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarSMS: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<NotificacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificacaoResponse)));
            
        }

        
        /// <summary>
        /// Enviar SMS Esse recurso permite enviar uma lista de SMS
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listaSMS">listaSMS</param>
        /// <returns>Task of NotificacaoResponse</returns>
        public async System.Threading.Tasks.Task<NotificacaoResponse> SalvarSMSAsync (List<NotificacaoSMSBody> listaSMS)
        {
             ApiResponse<NotificacaoResponse> localVarResponse = await SalvarSMSAsyncWithHttpInfo(listaSMS);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Enviar SMS Esse recurso permite enviar uma lista de SMS
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listaSMS">listaSMS</param>
        /// <returns>Task of ApiResponse (NotificacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NotificacaoResponse>> SalvarSMSAsyncWithHttpInfo (List<NotificacaoSMSBody> listaSMS)
        {
            // verify the required parameter 'listaSMS' is set
            if (listaSMS == null) throw new ApiException(400, "Missing required parameter 'listaSMS' when calling SalvarSMS");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarSMS: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarSMS: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NotificacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificacaoResponse)));
            
        }
        
        /// <summary>
        /// Salva template de notifica\u00E7\u00E3o Esse recurso salvar template notifica\u00E7\u00F5e
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conteudo">Template HTML</param> 
        /// <param name="idConfiguracaoEmail">C\u00F3digo de identifica\u00E7\u00E3o da configra\u00E7\u00E3o de EMAIL (optional)</param> 
        /// <param name="tipoLayout">Tipo do layout (optional)</param> 
        /// <param name="tipoNotificacao">Tipo da notifica\u00E7\u00E3o (optional)</param> 
        /// <param name="remetente">Remetente (optional)</param> 
        /// <param name="assunto">Assunto da Notificaca\u00E7\u00E3o (optional)</param> 
        /// <param name="templatePadrao">Template Padr\u00E3o (optional)</param> 
        /// <returns>TemplateNotificacaoDetalheResponse</returns>
        public TemplateNotificacaoDetalheResponse SalvarTemplateNotificacao (string conteudo, long? idConfiguracaoEmail = null, string tipoLayout = null, string tipoNotificacao = null, string remetente = null, string assunto = null, bool? templatePadrao = null)
        {
             ApiResponse<TemplateNotificacaoDetalheResponse> localVarResponse = SalvarTemplateNotificacaoWithHttpInfo(conteudo, idConfiguracaoEmail, tipoLayout, tipoNotificacao, remetente, assunto, templatePadrao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Salva template de notifica\u00E7\u00E3o Esse recurso salvar template notifica\u00E7\u00F5e
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conteudo">Template HTML</param> 
        /// <param name="idConfiguracaoEmail">C\u00F3digo de identifica\u00E7\u00E3o da configra\u00E7\u00E3o de EMAIL (optional)</param> 
        /// <param name="tipoLayout">Tipo do layout (optional)</param> 
        /// <param name="tipoNotificacao">Tipo da notifica\u00E7\u00E3o (optional)</param> 
        /// <param name="remetente">Remetente (optional)</param> 
        /// <param name="assunto">Assunto da Notificaca\u00E7\u00E3o (optional)</param> 
        /// <param name="templatePadrao">Template Padr\u00E3o (optional)</param> 
        /// <returns>ApiResponse of TemplateNotificacaoDetalheResponse</returns>
        public ApiResponse< TemplateNotificacaoDetalheResponse > SalvarTemplateNotificacaoWithHttpInfo (string conteudo, long? idConfiguracaoEmail = null, string tipoLayout = null, string tipoNotificacao = null, string remetente = null, string assunto = null, bool? templatePadrao = null)
        {
            
            // verify the required parameter 'conteudo' is set
            if (conteudo == null)
                throw new ApiException(400, "Missing required parameter 'conteudo' when calling NotificacaoApi->SalvarTemplateNotificacao");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarTemplateNotificacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarTemplateNotificacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TemplateNotificacaoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateNotificacaoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TemplateNotificacaoDetalheResponse)));
            
        }

        
        /// <summary>
        /// Salva template de notifica\u00E7\u00E3o Esse recurso salvar template notifica\u00E7\u00F5e
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conteudo">Template HTML</param>
        /// <param name="idConfiguracaoEmail">C\u00F3digo de identifica\u00E7\u00E3o da configra\u00E7\u00E3o de EMAIL (optional)</param>
        /// <param name="tipoLayout">Tipo do layout (optional)</param>
        /// <param name="tipoNotificacao">Tipo da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="remetente">Remetente (optional)</param>
        /// <param name="assunto">Assunto da Notificaca\u00E7\u00E3o (optional)</param>
        /// <param name="templatePadrao">Template Padr\u00E3o (optional)</param>
        /// <returns>Task of TemplateNotificacaoDetalheResponse</returns>
        public async System.Threading.Tasks.Task<TemplateNotificacaoDetalheResponse> SalvarTemplateNotificacaoAsync (string conteudo, long? idConfiguracaoEmail = null, string tipoLayout = null, string tipoNotificacao = null, string remetente = null, string assunto = null, bool? templatePadrao = null)
        {
             ApiResponse<TemplateNotificacaoDetalheResponse> localVarResponse = await SalvarTemplateNotificacaoAsyncWithHttpInfo(conteudo, idConfiguracaoEmail, tipoLayout, tipoNotificacao, remetente, assunto, templatePadrao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Salva template de notifica\u00E7\u00E3o Esse recurso salvar template notifica\u00E7\u00F5e
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conteudo">Template HTML</param>
        /// <param name="idConfiguracaoEmail">C\u00F3digo de identifica\u00E7\u00E3o da configra\u00E7\u00E3o de EMAIL (optional)</param>
        /// <param name="tipoLayout">Tipo do layout (optional)</param>
        /// <param name="tipoNotificacao">Tipo da notifica\u00E7\u00E3o (optional)</param>
        /// <param name="remetente">Remetente (optional)</param>
        /// <param name="assunto">Assunto da Notificaca\u00E7\u00E3o (optional)</param>
        /// <param name="templatePadrao">Template Padr\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (TemplateNotificacaoDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TemplateNotificacaoDetalheResponse>> SalvarTemplateNotificacaoAsyncWithHttpInfo (string conteudo, long? idConfiguracaoEmail = null, string tipoLayout = null, string tipoNotificacao = null, string remetente = null, string assunto = null, bool? templatePadrao = null)
        {
            // verify the required parameter 'conteudo' is set
            if (conteudo == null) throw new ApiException(400, "Missing required parameter 'conteudo' when calling SalvarTemplateNotificacao");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarTemplateNotificacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarTemplateNotificacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TemplateNotificacaoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateNotificacaoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TemplateNotificacaoDetalheResponse)));
            
        }
        
        /// <summary>
        /// Validar c\u00F3digo de seguran\u00E7a enviado por e-mail Esse recurso permite validar os c\u00F3digos de seguran\u00E7a enviador por e-mail, para valida\u00E7\u00E3o de dispositivos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>string</returns>
        public string ValidarTokenEMAIL (CodigoSegurancaEMAILPersist request)
        {
             ApiResponse<string> localVarResponse = ValidarTokenEMAILWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Validar c\u00F3digo de seguran\u00E7a enviado por e-mail Esse recurso permite validar os c\u00F3digos de seguran\u00E7a enviador por e-mail, para valida\u00E7\u00E3o de dispositivos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ValidarTokenEMAILWithHttpInfo (CodigoSegurancaEMAILPersist request)
        {
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling NotificacaoApi->ValidarTokenEMAIL");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarTokenEMAIL: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarTokenEMAIL: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Validar c\u00F3digo de seguran\u00E7a enviado por e-mail Esse recurso permite validar os c\u00F3digos de seguran\u00E7a enviador por e-mail, para valida\u00E7\u00E3o de dispositivos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ValidarTokenEMAILAsync (CodigoSegurancaEMAILPersist request)
        {
             ApiResponse<string> localVarResponse = await ValidarTokenEMAILAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Validar c\u00F3digo de seguran\u00E7a enviado por e-mail Esse recurso permite validar os c\u00F3digos de seguran\u00E7a enviador por e-mail, para valida\u00E7\u00E3o de dispositivos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ValidarTokenEMAILAsyncWithHttpInfo (CodigoSegurancaEMAILPersist request)
        {
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling ValidarTokenEMAIL");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarTokenEMAIL: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarTokenEMAIL: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Validar c\u00F3digo de seguran\u00E7a enviado por sms Esse recurso permite validar os c\u00F3digos de seguran\u00E7a enviador por sms, para valida\u00E7\u00E3o de dispositivos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>string</returns>
        public string ValidarTokenSMS (CodigoSegurancaSMSRequest request)
        {
             ApiResponse<string> localVarResponse = ValidarTokenSMSWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Validar c\u00F3digo de seguran\u00E7a enviado por sms Esse recurso permite validar os c\u00F3digos de seguran\u00E7a enviador por sms, para valida\u00E7\u00E3o de dispositivos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ValidarTokenSMSWithHttpInfo (CodigoSegurancaSMSRequest request)
        {
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling NotificacaoApi->ValidarTokenSMS");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarTokenSMS: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarTokenSMS: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Validar c\u00F3digo de seguran\u00E7a enviado por sms Esse recurso permite validar os c\u00F3digos de seguran\u00E7a enviador por sms, para valida\u00E7\u00E3o de dispositivos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ValidarTokenSMSAsync (CodigoSegurancaSMSRequest request)
        {
             ApiResponse<string> localVarResponse = await ValidarTokenSMSAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Validar c\u00F3digo de seguran\u00E7a enviado por sms Esse recurso permite validar os c\u00F3digos de seguran\u00E7a enviador por sms, para valida\u00E7\u00E3o de dispositivos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ValidarTokenSMSAsyncWithHttpInfo (CodigoSegurancaSMSRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling ValidarTokenSMS");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ValidarTokenSMS: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarTokenSMS: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
    }
    
}
