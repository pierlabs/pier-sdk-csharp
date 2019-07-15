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
    public interface IArquivoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Consulta de arquivo no PIER Cloud
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar um determinado arquivo armazenado no PIER Cloud
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do arquivo</param>
        /// <returns>ArquivoDetalheResponse</returns>
        ArquivoDetalheResponse ConsultarArquivo (long? id);
  
        /// <summary>
        /// Consulta de arquivo no PIER Cloud
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar um determinado arquivo armazenado no PIER Cloud
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do arquivo</param>
        /// <returns>ApiResponse of ArquivoDetalheResponse</returns>
        ApiResponse<ArquivoDetalheResponse> ConsultarArquivoWithHttpInfo (long? id);
        
        /// <summary>
        /// Integrar Arquivos
        /// </summary>
        /// <remarks>
        /// Este recurso foi desenvolvido para realizar a integra\u00E7\u00E3o de arquivos do PIER Cloud junto a reposit\u00F3rios externos pr\u00E9-configurado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarArquivoRequest">integrarArquivoRequest</param>
        /// <returns>Object</returns>
        Object IntegrarArquivos (IntegrarArquivoRequest integrarArquivoRequest);
  
        /// <summary>
        /// Integrar Arquivos
        /// </summary>
        /// <remarks>
        /// Este recurso foi desenvolvido para realizar a integra\u00E7\u00E3o de arquivos do PIER Cloud junto a reposit\u00F3rios externos pr\u00E9-configurado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarArquivoRequest">integrarArquivoRequest</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> IntegrarArquivosWithHttpInfo (IntegrarArquivoRequest integrarArquivoRequest);
        
        /// <summary>
        /// Listar arquivos do Pier Cloud
        /// </summary>
        /// <remarks>
        /// Este recurso permite a listagem de todos os arquivos dispon\u00EDveis no Pier Cloud
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do arquivo (optional)</param>
        /// <param name="idTipoArquivo">Tipo do arquivo (optional)</param>
        /// <param name="idStatusArquivo">Identificador do status do arquivo (optional)</param>
        /// <param name="extensao">Extens\u00E3o do arquivo (optional)</param>
        /// <returns>PageArquivoResponse</returns>
        PageArquivoResponse ListarArquivos (List<string> sort = null, int? page = null, int? limit = null, string nome = null, long? idTipoArquivo = null, long? idStatusArquivo = null, string extensao = null);
  
        /// <summary>
        /// Listar arquivos do Pier Cloud
        /// </summary>
        /// <remarks>
        /// Este recurso permite a listagem de todos os arquivos dispon\u00EDveis no Pier Cloud
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do arquivo (optional)</param>
        /// <param name="idTipoArquivo">Tipo do arquivo (optional)</param>
        /// <param name="idStatusArquivo">Identificador do status do arquivo (optional)</param>
        /// <param name="extensao">Extens\u00E3o do arquivo (optional)</param>
        /// <returns>ApiResponse of PageArquivoResponse</returns>
        ApiResponse<PageArquivoResponse> ListarArquivosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, long? idTipoArquivo = null, long? idStatusArquivo = null, string extensao = null);
        
        /// <summary>
        /// Lista as auditorias de arquivos vinculadas a um N\u00FAmero da Receita Federal
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as auditorias de arquivos vinculadas a um N\u00FAmero da Receita Federal que ser\u00E1 passado como par\u00E2metro
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">Par\u00E2metro vinculado a um arquivo no ato de seu cadastro</param>
        /// <param name="page">P\u00E1gina solicitada (Default =0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageArquivoAUDResponse</returns>
        PageArquivoAUDResponse ListarAuditorias (string numeroReceitaFederal, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista as auditorias de arquivos vinculadas a um N\u00FAmero da Receita Federal
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as auditorias de arquivos vinculadas a um N\u00FAmero da Receita Federal que ser\u00E1 passado como par\u00E2metro
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">Par\u00E2metro vinculado a um arquivo no ato de seu cadastro</param>
        /// <param name="page">P\u00E1gina solicitada (Default =0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageArquivoAUDResponse</returns>
        ApiResponse<PageArquivoAUDResponse> ListarAuditoriasWithHttpInfo (string numeroReceitaFederal, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista as auditorias do arquivo
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as auditorias de um determinado arquivo a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do arquivo</param>
        /// <param name="page">P\u00E1gina solicitada (Default =0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageArquivoAUDResponse</returns>
        PageArquivoAUDResponse ListarAuditoriasDeArquivo (long? id, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista as auditorias do arquivo
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as auditorias de um determinado arquivo a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do arquivo</param>
        /// <param name="page">P\u00E1gina solicitada (Default =0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageArquivoAUDResponse</returns>
        ApiResponse<PageArquivoAUDResponse> ListarAuditoriasDeArquivoWithHttpInfo (long? id, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar Status de Arquivo
        /// </summary>
        /// <remarks>
        /// Este recurso permite a listagem de todos os Status de Arquivo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do status de arquivo (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do status de arquivo (optional)</param>
        /// <returns>PageStatusArquivoResponse</returns>
        PageStatusArquivoResponse ListarStatusArquivos (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null);
  
        /// <summary>
        /// Listar Status de Arquivo
        /// </summary>
        /// <remarks>
        /// Este recurso permite a listagem de todos os Status de Arquivo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do status de arquivo (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do status de arquivo (optional)</param>
        /// <returns>ApiResponse of PageStatusArquivoResponse</returns>
        ApiResponse<PageStatusArquivoResponse> ListarStatusArquivosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null);
        
        /// <summary>
        /// Listar Tipos de Arquivo
        /// </summary>
        /// <remarks>
        /// Este recurso permite a listagem de todos os Tipos de Arquivo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do tipo de arquivo (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de arquivo (optional)</param>
        /// <returns>PageTipoArquivoResponse</returns>
        PageTipoArquivoResponse ListarTiposArquivos (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null);
  
        /// <summary>
        /// Listar Tipos de Arquivo
        /// </summary>
        /// <remarks>
        /// Este recurso permite a listagem de todos os Tipos de Arquivo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do tipo de arquivo (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de arquivo (optional)</param>
        /// <returns>ApiResponse of PageTipoArquivoResponse</returns>
        ApiResponse<PageTipoArquivoResponse> ListarTiposArquivosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null);
        
        /// <summary>
        /// Permite armazenar arquivos no PIER Cloud
        /// </summary>
        /// <remarks>
        /// Este recurso permite o armazenamento de arquivos no PIER Cloud
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="arquivoPersist">arquivoPersist</param>
        /// <returns>ArquivoDetalheResponse</returns>
        ArquivoDetalheResponse SalvarArquivo (ArquivoPersist arquivoPersist);
  
        /// <summary>
        /// Permite armazenar arquivos no PIER Cloud
        /// </summary>
        /// <remarks>
        /// Este recurso permite o armazenamento de arquivos no PIER Cloud
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="arquivoPersist">arquivoPersist</param>
        /// <returns>ApiResponse of ArquivoDetalheResponse</returns>
        ApiResponse<ArquivoDetalheResponse> SalvarArquivoWithHttpInfo (ArquivoPersist arquivoPersist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Consulta de arquivo no PIER Cloud
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar um determinado arquivo armazenado no PIER Cloud
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do arquivo</param>
        /// <returns>Task of ArquivoDetalheResponse</returns>
        System.Threading.Tasks.Task<ArquivoDetalheResponse> ConsultarArquivoAsync (long? id);

        /// <summary>
        /// Consulta de arquivo no PIER Cloud
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar um determinado arquivo armazenado no PIER Cloud
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do arquivo</param>
        /// <returns>Task of ApiResponse (ArquivoDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ArquivoDetalheResponse>> ConsultarArquivoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Integrar Arquivos
        /// </summary>
        /// <remarks>
        /// Este recurso foi desenvolvido para realizar a integra\u00E7\u00E3o de arquivos do PIER Cloud junto a reposit\u00F3rios externos pr\u00E9-configurado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarArquivoRequest">integrarArquivoRequest</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> IntegrarArquivosAsync (IntegrarArquivoRequest integrarArquivoRequest);

        /// <summary>
        /// Integrar Arquivos
        /// </summary>
        /// <remarks>
        /// Este recurso foi desenvolvido para realizar a integra\u00E7\u00E3o de arquivos do PIER Cloud junto a reposit\u00F3rios externos pr\u00E9-configurado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarArquivoRequest">integrarArquivoRequest</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> IntegrarArquivosAsyncWithHttpInfo (IntegrarArquivoRequest integrarArquivoRequest);
        
        /// <summary>
        /// Listar arquivos do Pier Cloud
        /// </summary>
        /// <remarks>
        /// Este recurso permite a listagem de todos os arquivos dispon\u00EDveis no Pier Cloud
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do arquivo (optional)</param>
        /// <param name="idTipoArquivo">Tipo do arquivo (optional)</param>
        /// <param name="idStatusArquivo">Identificador do status do arquivo (optional)</param>
        /// <param name="extensao">Extens\u00E3o do arquivo (optional)</param>
        /// <returns>Task of PageArquivoResponse</returns>
        System.Threading.Tasks.Task<PageArquivoResponse> ListarArquivosAsync (List<string> sort = null, int? page = null, int? limit = null, string nome = null, long? idTipoArquivo = null, long? idStatusArquivo = null, string extensao = null);

        /// <summary>
        /// Listar arquivos do Pier Cloud
        /// </summary>
        /// <remarks>
        /// Este recurso permite a listagem de todos os arquivos dispon\u00EDveis no Pier Cloud
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do arquivo (optional)</param>
        /// <param name="idTipoArquivo">Tipo do arquivo (optional)</param>
        /// <param name="idStatusArquivo">Identificador do status do arquivo (optional)</param>
        /// <param name="extensao">Extens\u00E3o do arquivo (optional)</param>
        /// <returns>Task of ApiResponse (PageArquivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageArquivoResponse>> ListarArquivosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, long? idTipoArquivo = null, long? idStatusArquivo = null, string extensao = null);
        
        /// <summary>
        /// Lista as auditorias de arquivos vinculadas a um N\u00FAmero da Receita Federal
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as auditorias de arquivos vinculadas a um N\u00FAmero da Receita Federal que ser\u00E1 passado como par\u00E2metro
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">Par\u00E2metro vinculado a um arquivo no ato de seu cadastro</param>
        /// <param name="page">P\u00E1gina solicitada (Default =0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageArquivoAUDResponse</returns>
        System.Threading.Tasks.Task<PageArquivoAUDResponse> ListarAuditoriasAsync (string numeroReceitaFederal, int? page = null, int? limit = null);

        /// <summary>
        /// Lista as auditorias de arquivos vinculadas a um N\u00FAmero da Receita Federal
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as auditorias de arquivos vinculadas a um N\u00FAmero da Receita Federal que ser\u00E1 passado como par\u00E2metro
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">Par\u00E2metro vinculado a um arquivo no ato de seu cadastro</param>
        /// <param name="page">P\u00E1gina solicitada (Default =0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageArquivoAUDResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageArquivoAUDResponse>> ListarAuditoriasAsyncWithHttpInfo (string numeroReceitaFederal, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista as auditorias do arquivo
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as auditorias de um determinado arquivo a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do arquivo</param>
        /// <param name="page">P\u00E1gina solicitada (Default =0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageArquivoAUDResponse</returns>
        System.Threading.Tasks.Task<PageArquivoAUDResponse> ListarAuditoriasDeArquivoAsync (long? id, int? page = null, int? limit = null);

        /// <summary>
        /// Lista as auditorias do arquivo
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as auditorias de um determinado arquivo a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do arquivo</param>
        /// <param name="page">P\u00E1gina solicitada (Default =0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageArquivoAUDResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageArquivoAUDResponse>> ListarAuditoriasDeArquivoAsyncWithHttpInfo (long? id, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar Status de Arquivo
        /// </summary>
        /// <remarks>
        /// Este recurso permite a listagem de todos os Status de Arquivo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do status de arquivo (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do status de arquivo (optional)</param>
        /// <returns>Task of PageStatusArquivoResponse</returns>
        System.Threading.Tasks.Task<PageStatusArquivoResponse> ListarStatusArquivosAsync (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null);

        /// <summary>
        /// Listar Status de Arquivo
        /// </summary>
        /// <remarks>
        /// Este recurso permite a listagem de todos os Status de Arquivo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do status de arquivo (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do status de arquivo (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusArquivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageStatusArquivoResponse>> ListarStatusArquivosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null);
        
        /// <summary>
        /// Listar Tipos de Arquivo
        /// </summary>
        /// <remarks>
        /// Este recurso permite a listagem de todos os Tipos de Arquivo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do tipo de arquivo (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de arquivo (optional)</param>
        /// <returns>Task of PageTipoArquivoResponse</returns>
        System.Threading.Tasks.Task<PageTipoArquivoResponse> ListarTiposArquivosAsync (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null);

        /// <summary>
        /// Listar Tipos de Arquivo
        /// </summary>
        /// <remarks>
        /// Este recurso permite a listagem de todos os Tipos de Arquivo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do tipo de arquivo (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de arquivo (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoArquivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoArquivoResponse>> ListarTiposArquivosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null);
        
        /// <summary>
        /// Permite armazenar arquivos no PIER Cloud
        /// </summary>
        /// <remarks>
        /// Este recurso permite o armazenamento de arquivos no PIER Cloud
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="arquivoPersist">arquivoPersist</param>
        /// <returns>Task of ArquivoDetalheResponse</returns>
        System.Threading.Tasks.Task<ArquivoDetalheResponse> SalvarArquivoAsync (ArquivoPersist arquivoPersist);

        /// <summary>
        /// Permite armazenar arquivos no PIER Cloud
        /// </summary>
        /// <remarks>
        /// Este recurso permite o armazenamento de arquivos no PIER Cloud
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="arquivoPersist">arquivoPersist</param>
        /// <returns>Task of ApiResponse (ArquivoDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ArquivoDetalheResponse>> SalvarArquivoAsyncWithHttpInfo (ArquivoPersist arquivoPersist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ArquivoApi : IArquivoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArquivoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ArquivoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ArquivoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ArquivoApi(Configuration configuration = null)
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
        /// Consulta de arquivo no PIER Cloud Este recurso permite consultar um determinado arquivo armazenado no PIER Cloud
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do arquivo</param> 
        /// <returns>ArquivoDetalheResponse</returns>
        public ArquivoDetalheResponse ConsultarArquivo (long? id)
        {
             ApiResponse<ArquivoDetalheResponse> localVarResponse = ConsultarArquivoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta de arquivo no PIER Cloud Este recurso permite consultar um determinado arquivo armazenado no PIER Cloud
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do arquivo</param> 
        /// <returns>ApiResponse of ArquivoDetalheResponse</returns>
        public ApiResponse< ArquivoDetalheResponse > ConsultarArquivoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ArquivoApi->ConsultarArquivo");
            
    
            var localVarPath = "/api/arquivos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarArquivo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarArquivo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ArquivoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ArquivoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ArquivoDetalheResponse)));
            
        }

        
        /// <summary>
        /// Consulta de arquivo no PIER Cloud Este recurso permite consultar um determinado arquivo armazenado no PIER Cloud
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do arquivo</param>
        /// <returns>Task of ArquivoDetalheResponse</returns>
        public async System.Threading.Tasks.Task<ArquivoDetalheResponse> ConsultarArquivoAsync (long? id)
        {
             ApiResponse<ArquivoDetalheResponse> localVarResponse = await ConsultarArquivoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta de arquivo no PIER Cloud Este recurso permite consultar um determinado arquivo armazenado no PIER Cloud
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do arquivo</param>
        /// <returns>Task of ApiResponse (ArquivoDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ArquivoDetalheResponse>> ConsultarArquivoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarArquivo");
            
    
            var localVarPath = "/api/arquivos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarArquivo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarArquivo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ArquivoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ArquivoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ArquivoDetalheResponse)));
            
        }
        
        /// <summary>
        /// Integrar Arquivos Este recurso foi desenvolvido para realizar a integra\u00E7\u00E3o de arquivos do PIER Cloud junto a reposit\u00F3rios externos pr\u00E9-configurado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarArquivoRequest">integrarArquivoRequest</param> 
        /// <returns>Object</returns>
        public Object IntegrarArquivos (IntegrarArquivoRequest integrarArquivoRequest)
        {
             ApiResponse<Object> localVarResponse = IntegrarArquivosWithHttpInfo(integrarArquivoRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Integrar Arquivos Este recurso foi desenvolvido para realizar a integra\u00E7\u00E3o de arquivos do PIER Cloud junto a reposit\u00F3rios externos pr\u00E9-configurado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarArquivoRequest">integrarArquivoRequest</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > IntegrarArquivosWithHttpInfo (IntegrarArquivoRequest integrarArquivoRequest)
        {
            
            // verify the required parameter 'integrarArquivoRequest' is set
            if (integrarArquivoRequest == null)
                throw new ApiException(400, "Missing required parameter 'integrarArquivoRequest' when calling ArquivoApi->IntegrarArquivos");
            
    
            var localVarPath = "/api/arquivos/integrar";
    
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
            
            
            
            
            if (integrarArquivoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(integrarArquivoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = integrarArquivoRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling IntegrarArquivos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling IntegrarArquivos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Integrar Arquivos Este recurso foi desenvolvido para realizar a integra\u00E7\u00E3o de arquivos do PIER Cloud junto a reposit\u00F3rios externos pr\u00E9-configurado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarArquivoRequest">integrarArquivoRequest</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> IntegrarArquivosAsync (IntegrarArquivoRequest integrarArquivoRequest)
        {
             ApiResponse<Object> localVarResponse = await IntegrarArquivosAsyncWithHttpInfo(integrarArquivoRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Integrar Arquivos Este recurso foi desenvolvido para realizar a integra\u00E7\u00E3o de arquivos do PIER Cloud junto a reposit\u00F3rios externos pr\u00E9-configurado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarArquivoRequest">integrarArquivoRequest</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> IntegrarArquivosAsyncWithHttpInfo (IntegrarArquivoRequest integrarArquivoRequest)
        {
            // verify the required parameter 'integrarArquivoRequest' is set
            if (integrarArquivoRequest == null) throw new ApiException(400, "Missing required parameter 'integrarArquivoRequest' when calling IntegrarArquivos");
            
    
            var localVarPath = "/api/arquivos/integrar";
    
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
            
            
            
            
            if (integrarArquivoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(integrarArquivoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = integrarArquivoRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling IntegrarArquivos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling IntegrarArquivos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Listar arquivos do Pier Cloud Este recurso permite a listagem de todos os arquivos dispon\u00EDveis no Pier Cloud
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="nome">Nome do arquivo (optional)</param> 
        /// <param name="idTipoArquivo">Tipo do arquivo (optional)</param> 
        /// <param name="idStatusArquivo">Identificador do status do arquivo (optional)</param> 
        /// <param name="extensao">Extens\u00E3o do arquivo (optional)</param> 
        /// <returns>PageArquivoResponse</returns>
        public PageArquivoResponse ListarArquivos (List<string> sort = null, int? page = null, int? limit = null, string nome = null, long? idTipoArquivo = null, long? idStatusArquivo = null, string extensao = null)
        {
             ApiResponse<PageArquivoResponse> localVarResponse = ListarArquivosWithHttpInfo(sort, page, limit, nome, idTipoArquivo, idStatusArquivo, extensao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar arquivos do Pier Cloud Este recurso permite a listagem de todos os arquivos dispon\u00EDveis no Pier Cloud
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="nome">Nome do arquivo (optional)</param> 
        /// <param name="idTipoArquivo">Tipo do arquivo (optional)</param> 
        /// <param name="idStatusArquivo">Identificador do status do arquivo (optional)</param> 
        /// <param name="extensao">Extens\u00E3o do arquivo (optional)</param> 
        /// <returns>ApiResponse of PageArquivoResponse</returns>
        public ApiResponse< PageArquivoResponse > ListarArquivosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, long? idTipoArquivo = null, long? idStatusArquivo = null, string extensao = null)
        {
            
    
            var localVarPath = "/api/arquivos";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (idTipoArquivo != null) localVarQueryParams.Add("idTipoArquivo", Configuration.ApiClient.ParameterToString(idTipoArquivo)); // query parameter
            if (idStatusArquivo != null) localVarQueryParams.Add("idStatusArquivo", Configuration.ApiClient.ParameterToString(idStatusArquivo)); // query parameter
            if (extensao != null) localVarQueryParams.Add("extensao", Configuration.ApiClient.ParameterToString(extensao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarArquivos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarArquivos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageArquivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageArquivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageArquivoResponse)));
            
        }

        
        /// <summary>
        /// Listar arquivos do Pier Cloud Este recurso permite a listagem de todos os arquivos dispon\u00EDveis no Pier Cloud
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do arquivo (optional)</param>
        /// <param name="idTipoArquivo">Tipo do arquivo (optional)</param>
        /// <param name="idStatusArquivo">Identificador do status do arquivo (optional)</param>
        /// <param name="extensao">Extens\u00E3o do arquivo (optional)</param>
        /// <returns>Task of PageArquivoResponse</returns>
        public async System.Threading.Tasks.Task<PageArquivoResponse> ListarArquivosAsync (List<string> sort = null, int? page = null, int? limit = null, string nome = null, long? idTipoArquivo = null, long? idStatusArquivo = null, string extensao = null)
        {
             ApiResponse<PageArquivoResponse> localVarResponse = await ListarArquivosAsyncWithHttpInfo(sort, page, limit, nome, idTipoArquivo, idStatusArquivo, extensao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar arquivos do Pier Cloud Este recurso permite a listagem de todos os arquivos dispon\u00EDveis no Pier Cloud
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do arquivo (optional)</param>
        /// <param name="idTipoArquivo">Tipo do arquivo (optional)</param>
        /// <param name="idStatusArquivo">Identificador do status do arquivo (optional)</param>
        /// <param name="extensao">Extens\u00E3o do arquivo (optional)</param>
        /// <returns>Task of ApiResponse (PageArquivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageArquivoResponse>> ListarArquivosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, long? idTipoArquivo = null, long? idStatusArquivo = null, string extensao = null)
        {
            
    
            var localVarPath = "/api/arquivos";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (idTipoArquivo != null) localVarQueryParams.Add("idTipoArquivo", Configuration.ApiClient.ParameterToString(idTipoArquivo)); // query parameter
            if (idStatusArquivo != null) localVarQueryParams.Add("idStatusArquivo", Configuration.ApiClient.ParameterToString(idStatusArquivo)); // query parameter
            if (extensao != null) localVarQueryParams.Add("extensao", Configuration.ApiClient.ParameterToString(extensao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarArquivos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarArquivos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageArquivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageArquivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageArquivoResponse)));
            
        }
        
        /// <summary>
        /// Lista as auditorias de arquivos vinculadas a um N\u00FAmero da Receita Federal Este recurso permite listar as auditorias de arquivos vinculadas a um N\u00FAmero da Receita Federal que ser\u00E1 passado como par\u00E2metro
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">Par\u00E2metro vinculado a um arquivo no ato de seu cadastro</param> 
        /// <param name="page">P\u00E1gina solicitada (Default =0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageArquivoAUDResponse</returns>
        public PageArquivoAUDResponse ListarAuditorias (string numeroReceitaFederal, int? page = null, int? limit = null)
        {
             ApiResponse<PageArquivoAUDResponse> localVarResponse = ListarAuditoriasWithHttpInfo(numeroReceitaFederal, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as auditorias de arquivos vinculadas a um N\u00FAmero da Receita Federal Este recurso permite listar as auditorias de arquivos vinculadas a um N\u00FAmero da Receita Federal que ser\u00E1 passado como par\u00E2metro
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">Par\u00E2metro vinculado a um arquivo no ato de seu cadastro</param> 
        /// <param name="page">P\u00E1gina solicitada (Default =0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageArquivoAUDResponse</returns>
        public ApiResponse< PageArquivoAUDResponse > ListarAuditoriasWithHttpInfo (string numeroReceitaFederal, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'numeroReceitaFederal' is set
            if (numeroReceitaFederal == null)
                throw new ApiException(400, "Missing required parameter 'numeroReceitaFederal' when calling ArquivoApi->ListarAuditorias");
            
    
            var localVarPath = "/api/arquivos-auditorias";
    
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
            
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditorias: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditorias: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageArquivoAUDResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageArquivoAUDResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageArquivoAUDResponse)));
            
        }

        
        /// <summary>
        /// Lista as auditorias de arquivos vinculadas a um N\u00FAmero da Receita Federal Este recurso permite listar as auditorias de arquivos vinculadas a um N\u00FAmero da Receita Federal que ser\u00E1 passado como par\u00E2metro
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">Par\u00E2metro vinculado a um arquivo no ato de seu cadastro</param>
        /// <param name="page">P\u00E1gina solicitada (Default =0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageArquivoAUDResponse</returns>
        public async System.Threading.Tasks.Task<PageArquivoAUDResponse> ListarAuditoriasAsync (string numeroReceitaFederal, int? page = null, int? limit = null)
        {
             ApiResponse<PageArquivoAUDResponse> localVarResponse = await ListarAuditoriasAsyncWithHttpInfo(numeroReceitaFederal, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as auditorias de arquivos vinculadas a um N\u00FAmero da Receita Federal Este recurso permite listar as auditorias de arquivos vinculadas a um N\u00FAmero da Receita Federal que ser\u00E1 passado como par\u00E2metro
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">Par\u00E2metro vinculado a um arquivo no ato de seu cadastro</param>
        /// <param name="page">P\u00E1gina solicitada (Default =0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageArquivoAUDResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageArquivoAUDResponse>> ListarAuditoriasAsyncWithHttpInfo (string numeroReceitaFederal, int? page = null, int? limit = null)
        {
            // verify the required parameter 'numeroReceitaFederal' is set
            if (numeroReceitaFederal == null) throw new ApiException(400, "Missing required parameter 'numeroReceitaFederal' when calling ListarAuditorias");
            
    
            var localVarPath = "/api/arquivos-auditorias";
    
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
            
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditorias: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditorias: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageArquivoAUDResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageArquivoAUDResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageArquivoAUDResponse)));
            
        }
        
        /// <summary>
        /// Lista as auditorias do arquivo Este recurso permite listar as auditorias de um determinado arquivo a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do arquivo</param> 
        /// <param name="page">P\u00E1gina solicitada (Default =0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageArquivoAUDResponse</returns>
        public PageArquivoAUDResponse ListarAuditoriasDeArquivo (long? id, int? page = null, int? limit = null)
        {
             ApiResponse<PageArquivoAUDResponse> localVarResponse = ListarAuditoriasDeArquivoWithHttpInfo(id, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as auditorias do arquivo Este recurso permite listar as auditorias de um determinado arquivo a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do arquivo</param> 
        /// <param name="page">P\u00E1gina solicitada (Default =0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageArquivoAUDResponse</returns>
        public ApiResponse< PageArquivoAUDResponse > ListarAuditoriasDeArquivoWithHttpInfo (long? id, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ArquivoApi->ListarAuditoriasDeArquivo");
            
    
            var localVarPath = "/api/arquivos/{id}/auditorias";
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditoriasDeArquivo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditoriasDeArquivo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageArquivoAUDResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageArquivoAUDResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageArquivoAUDResponse)));
            
        }

        
        /// <summary>
        /// Lista as auditorias do arquivo Este recurso permite listar as auditorias de um determinado arquivo a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do arquivo</param>
        /// <param name="page">P\u00E1gina solicitada (Default =0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageArquivoAUDResponse</returns>
        public async System.Threading.Tasks.Task<PageArquivoAUDResponse> ListarAuditoriasDeArquivoAsync (long? id, int? page = null, int? limit = null)
        {
             ApiResponse<PageArquivoAUDResponse> localVarResponse = await ListarAuditoriasDeArquivoAsyncWithHttpInfo(id, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as auditorias do arquivo Este recurso permite listar as auditorias de um determinado arquivo a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do arquivo</param>
        /// <param name="page">P\u00E1gina solicitada (Default =0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageArquivoAUDResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageArquivoAUDResponse>> ListarAuditoriasDeArquivoAsyncWithHttpInfo (long? id, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarAuditoriasDeArquivo");
            
    
            var localVarPath = "/api/arquivos/{id}/auditorias";
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditoriasDeArquivo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditoriasDeArquivo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageArquivoAUDResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageArquivoAUDResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageArquivoAUDResponse)));
            
        }
        
        /// <summary>
        /// Listar Status de Arquivo Este recurso permite a listagem de todos os Status de Arquivo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="nome">Nome do status de arquivo (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do status de arquivo (optional)</param> 
        /// <returns>PageStatusArquivoResponse</returns>
        public PageStatusArquivoResponse ListarStatusArquivos (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null)
        {
             ApiResponse<PageStatusArquivoResponse> localVarResponse = ListarStatusArquivosWithHttpInfo(sort, page, limit, nome, descricao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar Status de Arquivo Este recurso permite a listagem de todos os Status de Arquivo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="nome">Nome do status de arquivo (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do status de arquivo (optional)</param> 
        /// <returns>ApiResponse of PageStatusArquivoResponse</returns>
        public ApiResponse< PageStatusArquivoResponse > ListarStatusArquivosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/status-arquivos";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusArquivos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusArquivos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageStatusArquivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusArquivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusArquivoResponse)));
            
        }

        
        /// <summary>
        /// Listar Status de Arquivo Este recurso permite a listagem de todos os Status de Arquivo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do status de arquivo (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do status de arquivo (optional)</param>
        /// <returns>Task of PageStatusArquivoResponse</returns>
        public async System.Threading.Tasks.Task<PageStatusArquivoResponse> ListarStatusArquivosAsync (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null)
        {
             ApiResponse<PageStatusArquivoResponse> localVarResponse = await ListarStatusArquivosAsyncWithHttpInfo(sort, page, limit, nome, descricao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar Status de Arquivo Este recurso permite a listagem de todos os Status de Arquivo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do status de arquivo (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do status de arquivo (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusArquivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageStatusArquivoResponse>> ListarStatusArquivosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/status-arquivos";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusArquivos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusArquivos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageStatusArquivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusArquivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusArquivoResponse)));
            
        }
        
        /// <summary>
        /// Listar Tipos de Arquivo Este recurso permite a listagem de todos os Tipos de Arquivo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="nome">Nome do tipo de arquivo (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de arquivo (optional)</param> 
        /// <returns>PageTipoArquivoResponse</returns>
        public PageTipoArquivoResponse ListarTiposArquivos (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null)
        {
             ApiResponse<PageTipoArquivoResponse> localVarResponse = ListarTiposArquivosWithHttpInfo(sort, page, limit, nome, descricao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar Tipos de Arquivo Este recurso permite a listagem de todos os Tipos de Arquivo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="nome">Nome do tipo de arquivo (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de arquivo (optional)</param> 
        /// <returns>ApiResponse of PageTipoArquivoResponse</returns>
        public ApiResponse< PageTipoArquivoResponse > ListarTiposArquivosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/tipos-arquivos";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposArquivos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposArquivos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoArquivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoArquivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoArquivoResponse)));
            
        }

        
        /// <summary>
        /// Listar Tipos de Arquivo Este recurso permite a listagem de todos os Tipos de Arquivo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do tipo de arquivo (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de arquivo (optional)</param>
        /// <returns>Task of PageTipoArquivoResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoArquivoResponse> ListarTiposArquivosAsync (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null)
        {
             ApiResponse<PageTipoArquivoResponse> localVarResponse = await ListarTiposArquivosAsyncWithHttpInfo(sort, page, limit, nome, descricao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar Tipos de Arquivo Este recurso permite a listagem de todos os Tipos de Arquivo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do tipo de arquivo (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de arquivo (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoArquivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoArquivoResponse>> ListarTiposArquivosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/tipos-arquivos";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposArquivos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposArquivos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoArquivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoArquivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoArquivoResponse)));
            
        }
        
        /// <summary>
        /// Permite armazenar arquivos no PIER Cloud Este recurso permite o armazenamento de arquivos no PIER Cloud
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="arquivoPersist">arquivoPersist</param> 
        /// <returns>ArquivoDetalheResponse</returns>
        public ArquivoDetalheResponse SalvarArquivo (ArquivoPersist arquivoPersist)
        {
             ApiResponse<ArquivoDetalheResponse> localVarResponse = SalvarArquivoWithHttpInfo(arquivoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite armazenar arquivos no PIER Cloud Este recurso permite o armazenamento de arquivos no PIER Cloud
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="arquivoPersist">arquivoPersist</param> 
        /// <returns>ApiResponse of ArquivoDetalheResponse</returns>
        public ApiResponse< ArquivoDetalheResponse > SalvarArquivoWithHttpInfo (ArquivoPersist arquivoPersist)
        {
            
            // verify the required parameter 'arquivoPersist' is set
            if (arquivoPersist == null)
                throw new ApiException(400, "Missing required parameter 'arquivoPersist' when calling ArquivoApi->SalvarArquivo");
            
    
            var localVarPath = "/api/arquivos";
    
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
            
            
            
            
            if (arquivoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(arquivoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = arquivoPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarArquivo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarArquivo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ArquivoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ArquivoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ArquivoDetalheResponse)));
            
        }

        
        /// <summary>
        /// Permite armazenar arquivos no PIER Cloud Este recurso permite o armazenamento de arquivos no PIER Cloud
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="arquivoPersist">arquivoPersist</param>
        /// <returns>Task of ArquivoDetalheResponse</returns>
        public async System.Threading.Tasks.Task<ArquivoDetalheResponse> SalvarArquivoAsync (ArquivoPersist arquivoPersist)
        {
             ApiResponse<ArquivoDetalheResponse> localVarResponse = await SalvarArquivoAsyncWithHttpInfo(arquivoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite armazenar arquivos no PIER Cloud Este recurso permite o armazenamento de arquivos no PIER Cloud
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="arquivoPersist">arquivoPersist</param>
        /// <returns>Task of ApiResponse (ArquivoDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ArquivoDetalheResponse>> SalvarArquivoAsyncWithHttpInfo (ArquivoPersist arquivoPersist)
        {
            // verify the required parameter 'arquivoPersist' is set
            if (arquivoPersist == null) throw new ApiException(400, "Missing required parameter 'arquivoPersist' when calling SalvarArquivo");
            
    
            var localVarPath = "/api/arquivos";
    
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
            
            
            
            
            if (arquivoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(arquivoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = arquivoPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarArquivo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarArquivo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ArquivoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ArquivoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ArquivoDetalheResponse)));
            
        }
        
    }
    
}
