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
    public interface IEstabelecimentoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Alterar Origem Comercial
        /// </summary>
        /// <remarks>
        /// Altera uma origem comercial.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da origem comercial</param>
        /// <param name="origemComercialUpdate">origemComercialUpdate</param>
        /// <returns>OrigemComercialResponse</returns>
        OrigemComercialResponse AlterarOrigemComercialUsingPUT (long? id, OrigemComercialUpdate origemComercialUpdate);
  
        /// <summary>
        /// Alterar Origem Comercial
        /// </summary>
        /// <remarks>
        /// Altera uma origem comercial.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da origem comercial</param>
        /// <param name="origemComercialUpdate">origemComercialUpdate</param>
        /// <returns>ApiResponse of OrigemComercialResponse</returns>
        ApiResponse<OrigemComercialResponse> AlterarOrigemComercialUsingPUTWithHttpInfo (long? id, OrigemComercialUpdate origemComercialUpdate);
        
        /// <summary>
        /// Altera uma Maquineta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o das maquinetas dos estabelecimentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Maquineta (id).</param>
        /// <param name="maquinetaUpdate">maquinetaUpdate</param>
        /// <returns>MaquinetaResponse</returns>
        MaquinetaResponse AlterarUsingPUT10 (long? id, MaquinetaUpdate maquinetaUpdate);
  
        /// <summary>
        /// Altera uma Maquineta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o das maquinetas dos estabelecimentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Maquineta (id).</param>
        /// <param name="maquinetaUpdate">maquinetaUpdate</param>
        /// <returns>ApiResponse of MaquinetaResponse</returns>
        ApiResponse<MaquinetaResponse> AlterarUsingPUT10WithHttpInfo (long? id, MaquinetaUpdate maquinetaUpdate);
        
        /// <summary>
        /// Altera uma Regra Opera\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o de uma regra opera\u00C3\u00A7\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Regra Opera\u00C3\u00A7\u00C3\u00A3o (id).</param>
        /// <param name="operacaoCredorUpdate">operacaoCredorUpdate</param>
        /// <returns>OperacaoCredorResponse</returns>
        OperacaoCredorResponse AlterarUsingPUT11 (long? id, OperacaoCredorUpdate operacaoCredorUpdate);
  
        /// <summary>
        /// Altera uma Regra Opera\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o de uma regra opera\u00C3\u00A7\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Regra Opera\u00C3\u00A7\u00C3\u00A3o (id).</param>
        /// <param name="operacaoCredorUpdate">operacaoCredorUpdate</param>
        /// <returns>ApiResponse of OperacaoCredorResponse</returns>
        ApiResponse<OperacaoCredorResponse> AlterarUsingPUT11WithHttpInfo (long? id, OperacaoCredorUpdate operacaoCredorUpdate);
        
        /// <summary>
        /// Altera um Telefone do estabelecimento
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos telefones dos estabelecimentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone Estabelecimento (id).</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id).</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone.</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <returns>TelefoneEstabelecimentoResponse</returns>
        TelefoneEstabelecimentoResponse AlterarUsingPUT15 (long? id, string ddd, string telefone, string ramal = null);
  
        /// <summary>
        /// Altera um Telefone do estabelecimento
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos telefones dos estabelecimentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone Estabelecimento (id).</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id).</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone.</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <returns>ApiResponse of TelefoneEstabelecimentoResponse</returns>
        ApiResponse<TelefoneEstabelecimentoResponse> AlterarUsingPUT15WithHttpInfo (long? id, string ddd, string telefone, string ramal = null);
        
        /// <summary>
        /// Altera um Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos Terminais.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do terminal (id).</param>
        /// <param name="terminalUpdate">terminalUpdate</param>
        /// <returns>TerminalResponse</returns>
        TerminalResponse AlterarUsingPUT17 (long? id, TerminalUpdate terminalUpdate);
  
        /// <summary>
        /// Altera um Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos Terminais.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do terminal (id).</param>
        /// <param name="terminalUpdate">terminalUpdate</param>
        /// <returns>ApiResponse of TerminalResponse</returns>
        ApiResponse<TerminalResponse> AlterarUsingPUT17WithHttpInfo (long? id, TerminalUpdate terminalUpdate);
        
        /// <summary>
        /// Alterar um estabelecimento
        /// </summary>
        /// <remarks>
        /// Altera um estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="update">update</param>
        /// <returns>EstabelecimentoResponse</returns>
        EstabelecimentoResponse AlterarUsingPUT6 (long? id, EstabelecimentoUpdate update);
  
        /// <summary>
        /// Alterar um estabelecimento
        /// </summary>
        /// <remarks>
        /// Altera um estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of EstabelecimentoResponse</returns>
        ApiResponse<EstabelecimentoResponse> AlterarUsingPUT6WithHttpInfo (long? id, EstabelecimentoUpdate update);
        
        /// <summary>
        /// Alterar Grupo Econ\u00C3\u00B4mico
        /// </summary>
        /// <remarks>
        /// Altera um grupo econ\u00C3\u00B4mico.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do grupo econ\u00C3\u00B4mico</param>
        /// <param name="grupoEconomicoDTO">grupoEconomicoDTO</param>
        /// <returns>GrupoEconomicoResponse</returns>
        GrupoEconomicoResponse AlterarUsingPUT8 (long? id, GrupoEconomicoDTO grupoEconomicoDTO);
  
        /// <summary>
        /// Alterar Grupo Econ\u00C3\u00B4mico
        /// </summary>
        /// <remarks>
        /// Altera um grupo econ\u00C3\u00B4mico.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do grupo econ\u00C3\u00B4mico</param>
        /// <param name="grupoEconomicoDTO">grupoEconomicoDTO</param>
        /// <returns>ApiResponse of GrupoEconomicoResponse</returns>
        ApiResponse<GrupoEconomicoResponse> AlterarUsingPUT8WithHttpInfo (long? id, GrupoEconomicoDTO grupoEconomicoDTO);
        
        /// <summary>
        /// Cadastrar Origem Comercial
        /// </summary>
        /// <remarks>
        /// Cadastra uma origem comercial.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origemComercialPersist">origemComercialPersist</param>
        /// <returns>OrigemComercialResponse</returns>
        OrigemComercialResponse CadastrarOrigemComercialUsingPOST (OrigemComercialPersist origemComercialPersist);
  
        /// <summary>
        /// Cadastrar Origem Comercial
        /// </summary>
        /// <remarks>
        /// Cadastra uma origem comercial.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origemComercialPersist">origemComercialPersist</param>
        /// <returns>ApiResponse of OrigemComercialResponse</returns>
        ApiResponse<OrigemComercialResponse> CadastrarOrigemComercialUsingPOSTWithHttpInfo (OrigemComercialPersist origemComercialPersist);
        
        /// <summary>
        /// Cadastrar um estabelecimento
        /// </summary>
        /// <remarks>
        /// Cadastra um novo estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>EstabelecimentoResponse</returns>
        EstabelecimentoResponse CadastrarUsingPOST2 (EstabelecimentoPersist persist);
  
        /// <summary>
        /// Cadastrar um estabelecimento
        /// </summary>
        /// <remarks>
        /// Cadastra um novo estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of EstabelecimentoResponse</returns>
        ApiResponse<EstabelecimentoResponse> CadastrarUsingPOST2WithHttpInfo (EstabelecimentoPersist persist);
        
        /// <summary>
        /// Cadastrar Grupo Econ\u00C3\u00B4mico
        /// </summary>
        /// <remarks>
        /// Cadastra um grupo econ\u00C3\u00B4mico.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoEconomicoDTO">GrupoEconomicoDTO</param>
        /// <returns>GrupoEconomicoResponse</returns>
        GrupoEconomicoResponse CadastrarUsingPOST3 (GrupoEconomicoDTO grupoEconomicoDTO);
  
        /// <summary>
        /// Cadastrar Grupo Econ\u00C3\u00B4mico
        /// </summary>
        /// <remarks>
        /// Cadastra um grupo econ\u00C3\u00B4mico.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoEconomicoDTO">GrupoEconomicoDTO</param>
        /// <returns>ApiResponse of GrupoEconomicoResponse</returns>
        ApiResponse<GrupoEconomicoResponse> CadastrarUsingPOST3WithHttpInfo (GrupoEconomicoDTO grupoEconomicoDTO);
        
        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado tipo opera\u00C3\u00A7\u00C3\u00A3o a partir do idoperacao
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de processamento da opera\u00C3\u00A7\u00C3\u00A3o (idOperacao).</param>
        /// <returns>DetalheOperacaoResponse</returns>
        DetalheOperacaoResponse ConsultaOperacaoUsingGET (long? id);
  
        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado tipo opera\u00C3\u00A7\u00C3\u00A3o a partir do idoperacao
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de processamento da opera\u00C3\u00A7\u00C3\u00A3o (idOperacao).</param>
        /// <returns>ApiResponse of DetalheOperacaoResponse</returns>
        ApiResponse<DetalheOperacaoResponse> ConsultaOperacaoUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar Origem Comercial
        /// </summary>
        /// <remarks>
        /// Consulta uma origem comercial atrav\u00C3\u00A9s do seu identificador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da origem comercial</param>
        /// <returns>OrigemComercialResponse</returns>
        OrigemComercialResponse ConsultarOrigemComercialUsingGET (long? id);
  
        /// <summary>
        /// Consultar Origem Comercial
        /// </summary>
        /// <remarks>
        /// Consulta uma origem comercial atrav\u00C3\u00A9s do seu identificador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da origem comercial</param>
        /// <returns>ApiResponse of OrigemComercialResponse</returns>
        ApiResponse<OrigemComercialResponse> ConsultarOrigemComercialUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar estabelecimento por id
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de um determinado estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>EstabelecimentoResponse</returns>
        EstabelecimentoResponse ConsultarUsingGET16 (long? id);
  
        /// <summary>
        /// Consultar estabelecimento por id
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de um determinado estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>ApiResponse of EstabelecimentoResponse</returns>
        ApiResponse<EstabelecimentoResponse> ConsultarUsingGET16WithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar grupo econ\u00C3\u00B4mico
        /// </summary>
        /// <remarks>
        /// Consulta um grupo econ\u00C3\u00B4mico atrav\u00C3\u00A9s do seu identificador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do grupo econ\u00C3\u00B4mico</param>
        /// <returns>GrupoEconomicoResponse</returns>
        GrupoEconomicoResponse ConsultarUsingGET18 (long? id);
  
        /// <summary>
        /// Consultar grupo econ\u00C3\u00B4mico
        /// </summary>
        /// <remarks>
        /// Consulta um grupo econ\u00C3\u00B4mico atrav\u00C3\u00A9s do seu identificador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do grupo econ\u00C3\u00B4mico</param>
        /// <returns>ApiResponse of GrupoEconomicoResponse</returns>
        ApiResponse<GrupoEconomicoResponse> ConsultarUsingGET18WithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de uma determinada maquineta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar uma determinada maquineta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Maquineta (id).</param>
        /// <returns>MaquinetaResponse</returns>
        MaquinetaResponse ConsultarUsingGET20 (long? id);
  
        /// <summary>
        /// Apresenta os dados de uma determinada maquineta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar uma determinada maquineta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Maquineta (id).</param>
        /// <returns>ApiResponse of MaquinetaResponse</returns>
        ApiResponse<MaquinetaResponse> ConsultarUsingGET20WithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de uma determinada Regra Opera\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar uma determinada regra opera\u00C3\u00A7\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Regra Opera\u00C3\u00A7\u00C3\u00A3o (id).</param>
        /// <returns>OperacaoCredorResponse</returns>
        OperacaoCredorResponse ConsultarUsingGET21 (long? id);
  
        /// <summary>
        /// Apresenta os dados de uma determinada Regra Opera\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar uma determinada regra opera\u00C3\u00A7\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Regra Opera\u00C3\u00A7\u00C3\u00A3o (id).</param>
        /// <returns>ApiResponse of OperacaoCredorResponse</returns>
        ApiResponse<OperacaoCredorResponse> ConsultarUsingGET21WithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado telefone de um estabelecimento
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado telefone de um estabelecimento a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone Estabelecimento (id).</param>
        /// <returns>TelefoneEstabelecimentoResponse</returns>
        TelefoneEstabelecimentoResponse ConsultarUsingGET29 (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado telefone de um estabelecimento
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado telefone de um estabelecimento a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone Estabelecimento (id).</param>
        /// <returns>ApiResponse of TelefoneEstabelecimentoResponse</returns>
        ApiResponse<TelefoneEstabelecimentoResponse> ConsultarUsingGET29WithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Terminal a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id).</param>
        /// <returns>TerminalResponse</returns>
        TerminalResponse ConsultarUsingGET31 (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Terminal a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id).</param>
        /// <returns>ApiResponse of TerminalResponse</returns>
        ApiResponse<TerminalResponse> ConsultarUsingGET31WithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado V\u00C3\u00ADnculo
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado V\u00C3\u00ADnculo a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do V\u00C3\u008Dnculo (id).</param>
        /// <returns>VinculoEstabelecimentoAdquirenteResponse</returns>
        VinculoEstabelecimentoAdquirenteResponse ConsultarUsingGET43 (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado V\u00C3\u00ADnculo
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado V\u00C3\u00ADnculo a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do V\u00C3\u008Dnculo (id).</param>
        /// <returns>ApiResponse of VinculoEstabelecimentoAdquirenteResponse</returns>
        ApiResponse<VinculoEstabelecimentoAdquirenteResponse> ConsultarUsingGET43WithHttpInfo (long? id);
        
        /// <summary>
        /// Desabilitar um V\u00C3\u00ADnculo
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a desativa\u00C3\u00A7\u00C3\u00A3o de um v\u00C3\u00ADnculo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do V\u00C3\u00ADnculo (id).</param>
        /// <returns>Object</returns>
        Object DesabilitarVinculoUsingPOST (long? id);
  
        /// <summary>
        /// Desabilitar um V\u00C3\u00ADnculo
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a desativa\u00C3\u00A7\u00C3\u00A3o de um v\u00C3\u00ADnculo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do V\u00C3\u00ADnculo (id).</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> DesabilitarVinculoUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// Desabilitar um v\u00C3\u00ADnculo opera\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite desabilitar um v\u00C3\u00ADnculo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id).</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>Object</returns>
        Object DesabilitarVinculoUsingPOST1 (long? id, VinculoOperacaoPersist vinculoOperacaoPersist);
  
        /// <summary>
        /// Desabilitar um v\u00C3\u00ADnculo opera\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite desabilitar um v\u00C3\u00ADnculo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id).</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> DesabilitarVinculoUsingPOST1WithHttpInfo (long? id, VinculoOperacaoPersist vinculoOperacaoPersist);
        
        /// <summary>
        /// Habilitar um V\u00C3\u00ADnculo
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a ativa\u00C3\u00A7\u00C3\u00A3o de um v\u00C3\u00ADnculo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do V\u00C3\u00ADnculo (id).</param>
        /// <returns>Object</returns>
        Object HabilitarVinculoUsingPOST (long? id);
  
        /// <summary>
        /// Habilitar um V\u00C3\u00ADnculo
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a ativa\u00C3\u00A7\u00C3\u00A3o de um v\u00C3\u00ADnculo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do V\u00C3\u00ADnculo (id).</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> HabilitarVinculoUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// Habilitar um v\u00C3\u00ADnculo opera\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite habilitar um v\u00C3\u00ADnculo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id).</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>Object</returns>
        Object HabilitarVinculoUsingPOST1 (long? id, VinculoOperacaoPersist vinculoOperacaoPersist);
  
        /// <summary>
        /// Habilitar um v\u00C3\u00ADnculo opera\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite habilitar um v\u00C3\u00ADnculo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id).</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> HabilitarVinculoUsingPOST1WithHttpInfo (long? id, VinculoOperacaoPersist vinculoOperacaoPersist);
        
        /// <summary>
        /// Apresenta dados de opera\u00C3\u00A7\u00C3\u00B5es em uma lista
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as opera\u00C3\u00A7\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idOperacao">C\u00C3\u00B3digo que identifica a opera\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="codigoProcessamento">C\u00C3\u00B3digo de processamento usado em transa\u00C3\u00A7\u00C3\u00B5es com o autorizador (optional)</param>
        /// <returns>PageOperacaoResponse</returns>
        PageOperacaoResponse ListaOperacaoUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, string codigoProcessamento = null);
  
        /// <summary>
        /// Apresenta dados de opera\u00C3\u00A7\u00C3\u00B5es em uma lista
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as opera\u00C3\u00A7\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idOperacao">C\u00C3\u00B3digo que identifica a opera\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="codigoProcessamento">C\u00C3\u00B3digo de processamento usado em transa\u00C3\u00A7\u00C3\u00B5es com o autorizador (optional)</param>
        /// <returns>ApiResponse of PageOperacaoResponse</returns>
        ApiResponse<PageOperacaoResponse> ListaOperacaoUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, string codigoProcessamento = null);
        
        /// <summary>
        /// Lista os MCCs
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os MCCs existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageMCCResponse</returns>
        PageMCCResponse ListarMCCUsingGET (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista os MCCs
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os MCCs existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageMCCResponse</returns>
        ApiResponse<PageMCCResponse> ListarMCCUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar Origens Comerciais
        /// </summary>
        /// <remarks>
        /// Lista origens comerciais cadastradas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Id da origem comercial (optional)</param>
        /// <param name="nome">Nome da origem comercial (optional)</param>
        /// <param name="status">Indica o status da origem comercial (optional)</param>
        /// <param name="idEstabelecimento">Identificador do estabelecimento (optional)</param>
        /// <param name="idProduto">Identificador do produto (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o da origem comercial (optional)</param>
        /// <param name="idTipoOrigemComercial">Identificador do tipo de origem comercial (optional)</param>
        /// <param name="idGrupoOrigemComercial">Identificador do grupo de origem comercial (optional)</param>
        /// <param name="flagPreAprovado">Indica se permite pr\u00C3\u00A9 aprova\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="flagAprovacaoImediata">Indica se permite aprova\u00C3\u00A7\u00C3\u00A3o imediata (optional)</param>
        /// <param name="nomeFantasiaPlastico">Nome fantasia impresso no pl\u00C3\u00A1stico (optional)</param>
        /// <param name="flagCartaoProvisorio">Indica se permite cart\u00C3\u00A3o provis\u00C3\u00B3rio (optional)</param>
        /// <param name="flagCartaoDefinitivo">Indica se permite cart\u00C3\u00A3o definitivo (optional)</param>
        /// <param name="usuario">Usu\u00C3\u00A1rio para autentica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="senha">Senha para autentica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="flagOrigemExterna">Indica se \u00C3\u00A9 origem externa (optional)</param>
        /// <param name="flagModificado">Indica se h\u00C3\u00A1 modifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="flagEnviaFaturaUsuario">Indica se envia fatura (optional)</param>
        /// <param name="flagCreditoFaturamento">Indica se permite cr\u00C3\u00A9dito de faturamento (optional)</param>
        /// <param name="flagConcedeLimiteProvisorio">Indica se concede limite provis\u00C3\u00B3rio (optional)</param>
        /// <param name="flagDigitalizarDoc">Indica se digitaliza documento (optional)</param>
        /// <param name="flagEmbossingLoja">Indica se realiza embossing em loja (optional)</param>
        /// <param name="flagConsultaPrevia">Indica se realiza consulta pr\u00C3\u00A9via (optional)</param>
        /// <param name="tipoPessoa">Tipo de pessoa (optional)</param>
        /// <returns>PageOrigemComercialResponse</returns>
        PageOrigemComercialResponse ListarOrigensComerciaisUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null, long? idEstabelecimento = null, long? idProduto = null, string descricao = null, long? idTipoOrigemComercial = null, long? idGrupoOrigemComercial = null, bool? flagPreAprovado = null, bool? flagAprovacaoImediata = null, string nomeFantasiaPlastico = null, bool? flagCartaoProvisorio = null, bool? flagCartaoDefinitivo = null, string usuario = null, string senha = null, bool? flagOrigemExterna = null, bool? flagModificado = null, bool? flagEnviaFaturaUsuario = null, bool? flagCreditoFaturamento = null, bool? flagConcedeLimiteProvisorio = null, bool? flagDigitalizarDoc = null, bool? flagEmbossingLoja = null, bool? flagConsultaPrevia = null, string tipoPessoa = null);
  
        /// <summary>
        /// Listar Origens Comerciais
        /// </summary>
        /// <remarks>
        /// Lista origens comerciais cadastradas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Id da origem comercial (optional)</param>
        /// <param name="nome">Nome da origem comercial (optional)</param>
        /// <param name="status">Indica o status da origem comercial (optional)</param>
        /// <param name="idEstabelecimento">Identificador do estabelecimento (optional)</param>
        /// <param name="idProduto">Identificador do produto (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o da origem comercial (optional)</param>
        /// <param name="idTipoOrigemComercial">Identificador do tipo de origem comercial (optional)</param>
        /// <param name="idGrupoOrigemComercial">Identificador do grupo de origem comercial (optional)</param>
        /// <param name="flagPreAprovado">Indica se permite pr\u00C3\u00A9 aprova\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="flagAprovacaoImediata">Indica se permite aprova\u00C3\u00A7\u00C3\u00A3o imediata (optional)</param>
        /// <param name="nomeFantasiaPlastico">Nome fantasia impresso no pl\u00C3\u00A1stico (optional)</param>
        /// <param name="flagCartaoProvisorio">Indica se permite cart\u00C3\u00A3o provis\u00C3\u00B3rio (optional)</param>
        /// <param name="flagCartaoDefinitivo">Indica se permite cart\u00C3\u00A3o definitivo (optional)</param>
        /// <param name="usuario">Usu\u00C3\u00A1rio para autentica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="senha">Senha para autentica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="flagOrigemExterna">Indica se \u00C3\u00A9 origem externa (optional)</param>
        /// <param name="flagModificado">Indica se h\u00C3\u00A1 modifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="flagEnviaFaturaUsuario">Indica se envia fatura (optional)</param>
        /// <param name="flagCreditoFaturamento">Indica se permite cr\u00C3\u00A9dito de faturamento (optional)</param>
        /// <param name="flagConcedeLimiteProvisorio">Indica se concede limite provis\u00C3\u00B3rio (optional)</param>
        /// <param name="flagDigitalizarDoc">Indica se digitaliza documento (optional)</param>
        /// <param name="flagEmbossingLoja">Indica se realiza embossing em loja (optional)</param>
        /// <param name="flagConsultaPrevia">Indica se realiza consulta pr\u00C3\u00A9via (optional)</param>
        /// <param name="tipoPessoa">Tipo de pessoa (optional)</param>
        /// <returns>ApiResponse of PageOrigemComercialResponse</returns>
        ApiResponse<PageOrigemComercialResponse> ListarOrigensComerciaisUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null, long? idEstabelecimento = null, long? idProduto = null, string descricao = null, long? idTipoOrigemComercial = null, long? idGrupoOrigemComercial = null, bool? flagPreAprovado = null, bool? flagAprovacaoImediata = null, string nomeFantasiaPlastico = null, bool? flagCartaoProvisorio = null, bool? flagCartaoDefinitivo = null, string usuario = null, string senha = null, bool? flagOrigemExterna = null, bool? flagModificado = null, bool? flagEnviaFaturaUsuario = null, bool? flagCreditoFaturamento = null, bool? flagConcedeLimiteProvisorio = null, bool? flagDigitalizarDoc = null, bool? flagEmbossingLoja = null, bool? flagConsultaPrevia = null, string tipoPessoa = null);
        
        /// <summary>
        /// Lista os Tipos de adquirentes
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os tipos de adquirentes.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageEntidadeResponse</returns>
        PageEntidadeResponse ListarTiposAdquirentesUsingGET (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista os Tipos de adquirentes
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os tipos de adquirentes.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageEntidadeResponse</returns>
        ApiResponse<PageEntidadeResponse> ListarTiposAdquirentesUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os Tipos de  Maquinetas
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas os Tipos de maquinetas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        PageCampoCodificadoDescricaoResponse ListarTiposMaquinetasUsingGET (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista os Tipos de  Maquinetas
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas os Tipos de maquinetas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        ApiResponse<PageCampoCodificadoDescricaoResponse> ListarTiposMaquinetasUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os Tipos Terminais
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os tipos de terminais existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageTipoTerminalResponse</returns>
        PageTipoTerminalResponse ListarTiposTerminaisUsingGET1 (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista os Tipos Terminais
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os tipos de terminais existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageTipoTerminalResponse</returns>
        ApiResponse<PageTipoTerminalResponse> ListarTiposTerminaisUsingGET1WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista Estabelecimentos
        /// </summary>
        /// <remarks>
        /// Lista todas os Estabelecimentos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id). (optional)</param>
        /// <param name="idCredor">Apresenta o n\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Credor. (optional)</param>
        /// <param name="numeroReceitaFederal">Apresenta o n\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento na Receita Federal. (optional)</param>
        /// <param name="nome">Nome do Estabelecimento. (optional)</param>
        /// <param name="descricao">Raz\u00C3\u00A3o Social do Estabelecimento. (optional)</param>
        /// <param name="nomeFantasia">T\u00C3\u00ADtulo Comercial do Estabelecimento. (optional)</param>
        /// <param name="cep">C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP). (optional)</param>
        /// <param name="nomeLogradouro">Nome do Logradouro. (optional)</param>
        /// <param name="numeroEndereco">N\u00C3\u00BAmero do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="complemento">Descri\u00C3\u00A7\u00C3\u00B5es complementares referente ao endere\u00C3\u00A7o. (optional)</param>
        /// <param name="bairro">Nome do bairro do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="cidade">Nome da cidade do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="uf">Sigla de identifica\u00C3\u00A7\u00C3\u00A3o da Unidade Federativa do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="pais">Nome do pa\u00C3\u00ADs. (optional)</param>
        /// <param name="dataCadastramento">Data de Cadastro do Estabelecimento, no formato yyyy-MM-dd. (optional)</param>
        /// <param name="contato">Nome da pessoa para contato com o Estabelecimento. (optional)</param>
        /// <param name="email">E-mail da pessoa para contato com o Estabelecimento. (optional)</param>
        /// <param name="flagArquivoSecrFazenda">Indica se o estabelecimento ser\u00C3\u00A1 inclu\u00C3\u00ADdo no arquivo de registro para a Secretaria da Fazenda Estadual. (optional)</param>
        /// <param name="flagCartaoDigitado">Indica se o estabelecimento poder\u00C3\u00A1 originar transa\u00C3\u00A7\u00C3\u00B5es sem a leitura da tarja ou do chip do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="inativo">Indica se o estabelecimento est\u00C3\u00A1 inativo. (optional)</param>
        /// <param name="idPais">Identificador de Pa\u00C3\u00ADs. (optional)</param>
        /// <param name="mcc">C\u00C3\u00B3digo de Categoria de Mercado (optional)</param>
        /// <param name="idTipoEstabelecimento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento. (optional)</param>
        /// <param name="idMoeda">C\u00C3\u00B3digo identificador da moeda. (optional)</param>
        /// <param name="tipoPagamento">Tipo do regime de pagamento do estabelecimento. (optional)</param>
        /// <param name="numeroEstabelecimento">N\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento na Conductor. (optional)</param>
        /// <param name="cep2">C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP). (optional)</param>
        /// <param name="nomeLogradouro2">Nome do Logradouro. (optional)</param>
        /// <param name="numeroEndereco2">N\u00C3\u00BAmero do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="complemento2">Descri\u00C3\u00A7\u00C3\u00B5es complementares referente ao endere\u00C3\u00A7o. (optional)</param>
        /// <param name="bairro2">Nome do bairro do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="cidade2">Nome da cidade do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="uf2">Sigla de identifica\u00C3\u00A7\u00C3\u00A3o da Unidade Federativa do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="flagMatriz">Indica se \u00C3\u00A9 matriz ou filial. (optional)</param>
        /// <returns>PageEstabelecimentoResponse</returns>
        PageEstabelecimentoResponse ListarUsingGET21 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idCredor = null, string numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, int? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null, long? idPais = null, long? mcc = null, long? idTipoEstabelecimento = null, long? idMoeda = null, string tipoPagamento = null, string numeroEstabelecimento = null, string cep2 = null, string nomeLogradouro2 = null, int? numeroEndereco2 = null, string complemento2 = null, string bairro2 = null, string cidade2 = null, string uf2 = null, int? flagMatriz = null);
  
        /// <summary>
        /// Lista Estabelecimentos
        /// </summary>
        /// <remarks>
        /// Lista todas os Estabelecimentos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id). (optional)</param>
        /// <param name="idCredor">Apresenta o n\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Credor. (optional)</param>
        /// <param name="numeroReceitaFederal">Apresenta o n\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento na Receita Federal. (optional)</param>
        /// <param name="nome">Nome do Estabelecimento. (optional)</param>
        /// <param name="descricao">Raz\u00C3\u00A3o Social do Estabelecimento. (optional)</param>
        /// <param name="nomeFantasia">T\u00C3\u00ADtulo Comercial do Estabelecimento. (optional)</param>
        /// <param name="cep">C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP). (optional)</param>
        /// <param name="nomeLogradouro">Nome do Logradouro. (optional)</param>
        /// <param name="numeroEndereco">N\u00C3\u00BAmero do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="complemento">Descri\u00C3\u00A7\u00C3\u00B5es complementares referente ao endere\u00C3\u00A7o. (optional)</param>
        /// <param name="bairro">Nome do bairro do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="cidade">Nome da cidade do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="uf">Sigla de identifica\u00C3\u00A7\u00C3\u00A3o da Unidade Federativa do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="pais">Nome do pa\u00C3\u00ADs. (optional)</param>
        /// <param name="dataCadastramento">Data de Cadastro do Estabelecimento, no formato yyyy-MM-dd. (optional)</param>
        /// <param name="contato">Nome da pessoa para contato com o Estabelecimento. (optional)</param>
        /// <param name="email">E-mail da pessoa para contato com o Estabelecimento. (optional)</param>
        /// <param name="flagArquivoSecrFazenda">Indica se o estabelecimento ser\u00C3\u00A1 inclu\u00C3\u00ADdo no arquivo de registro para a Secretaria da Fazenda Estadual. (optional)</param>
        /// <param name="flagCartaoDigitado">Indica se o estabelecimento poder\u00C3\u00A1 originar transa\u00C3\u00A7\u00C3\u00B5es sem a leitura da tarja ou do chip do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="inativo">Indica se o estabelecimento est\u00C3\u00A1 inativo. (optional)</param>
        /// <param name="idPais">Identificador de Pa\u00C3\u00ADs. (optional)</param>
        /// <param name="mcc">C\u00C3\u00B3digo de Categoria de Mercado (optional)</param>
        /// <param name="idTipoEstabelecimento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento. (optional)</param>
        /// <param name="idMoeda">C\u00C3\u00B3digo identificador da moeda. (optional)</param>
        /// <param name="tipoPagamento">Tipo do regime de pagamento do estabelecimento. (optional)</param>
        /// <param name="numeroEstabelecimento">N\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento na Conductor. (optional)</param>
        /// <param name="cep2">C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP). (optional)</param>
        /// <param name="nomeLogradouro2">Nome do Logradouro. (optional)</param>
        /// <param name="numeroEndereco2">N\u00C3\u00BAmero do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="complemento2">Descri\u00C3\u00A7\u00C3\u00B5es complementares referente ao endere\u00C3\u00A7o. (optional)</param>
        /// <param name="bairro2">Nome do bairro do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="cidade2">Nome da cidade do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="uf2">Sigla de identifica\u00C3\u00A7\u00C3\u00A3o da Unidade Federativa do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="flagMatriz">Indica se \u00C3\u00A9 matriz ou filial. (optional)</param>
        /// <returns>ApiResponse of PageEstabelecimentoResponse</returns>
        ApiResponse<PageEstabelecimentoResponse> ListarUsingGET21WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idCredor = null, string numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, int? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null, long? idPais = null, long? mcc = null, long? idTipoEstabelecimento = null, long? idMoeda = null, string tipoPagamento = null, string numeroEstabelecimento = null, string cep2 = null, string nomeLogradouro2 = null, int? numeroEndereco2 = null, string complemento2 = null, string bairro2 = null, string cidade2 = null, string uf2 = null, int? flagMatriz = null);
        
        /// <summary>
        /// Listar grupos econ\u00C3\u00B4micos
        /// </summary>
        /// <remarks>
        /// Lista grupos econ\u00C3\u00B4micos cadastrados. 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="razaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="nomeCredor">Nome do credor (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00C3\u00BAmero da Receita Federal (optional)</param>
        /// <param name="inscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual (optional)</param>
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param>
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="digitoAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param>
        /// <param name="digitoContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param>
        /// <param name="periodicidade">Periodicidade do pagamento (optional)</param>
        /// <param name="pagamentoSemanal">Dia para pagamento semanal (optional)</param>
        /// <param name="pagamentoMensal">Dia da data para o pagamento mensal (optional)</param>
        /// <param name="pagamentoDecendialPrimeiro">Dia da data para o primeiro pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialSegundo">Dia da data para o segundo pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialTerceiro">Dia da data para o terceiro pagamento decendial (optional)</param>
        /// <param name="pagamentoQuinzenalPrimeiro">Dia da data para o primeiro pagamento quinzenal (optional)</param>
        /// <param name="pagamentoQuinzenalSegundo">Dia da data para o segundo pagamento quinzenal (optional)</param>
        /// <param name="percentualRAV">Valor percentual do RAV do credor (optional)</param>
        /// <param name="recebeRAV">Indica se o credor recebe RAV e o tipo (optional)</param>
        /// <param name="percentualMultiplica">Percentual Multiplica (optional)</param>
        /// <param name="taxaAdm">Taxa Administrativa (optional)</param>
        /// <param name="taxaBanco">Taxa do Banco (optional)</param>
        /// <param name="limiteRAV">Valor limite do RAV (optional)</param>
        /// <param name="idCredorRAV">C\u00C3\u00B3digo identificador do credor RAV (optional)</param>
        /// <returns>PageGrupoEconomicoResponse</returns>
        PageGrupoEconomicoResponse ListarUsingGET23 (List<string> sort = null, int? page = null, int? limit = null, string razaoSocial = null, string nomeCredor = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, string periodicidade = null, string pagamentoSemanal = null, int? pagamentoMensal = null, int? pagamentoDecendialPrimeiro = null, int? pagamentoDecendialSegundo = null, int? pagamentoDecendialTerceiro = null, int? pagamentoQuinzenalPrimeiro = null, int? pagamentoQuinzenalSegundo = null, double? percentualRAV = null, string recebeRAV = null, double? percentualMultiplica = null, double? taxaAdm = null, double? taxaBanco = null, double? limiteRAV = null, long? idCredorRAV = null);
  
        /// <summary>
        /// Listar grupos econ\u00C3\u00B4micos
        /// </summary>
        /// <remarks>
        /// Lista grupos econ\u00C3\u00B4micos cadastrados. 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="razaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="nomeCredor">Nome do credor (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00C3\u00BAmero da Receita Federal (optional)</param>
        /// <param name="inscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual (optional)</param>
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param>
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="digitoAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param>
        /// <param name="digitoContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param>
        /// <param name="periodicidade">Periodicidade do pagamento (optional)</param>
        /// <param name="pagamentoSemanal">Dia para pagamento semanal (optional)</param>
        /// <param name="pagamentoMensal">Dia da data para o pagamento mensal (optional)</param>
        /// <param name="pagamentoDecendialPrimeiro">Dia da data para o primeiro pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialSegundo">Dia da data para o segundo pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialTerceiro">Dia da data para o terceiro pagamento decendial (optional)</param>
        /// <param name="pagamentoQuinzenalPrimeiro">Dia da data para o primeiro pagamento quinzenal (optional)</param>
        /// <param name="pagamentoQuinzenalSegundo">Dia da data para o segundo pagamento quinzenal (optional)</param>
        /// <param name="percentualRAV">Valor percentual do RAV do credor (optional)</param>
        /// <param name="recebeRAV">Indica se o credor recebe RAV e o tipo (optional)</param>
        /// <param name="percentualMultiplica">Percentual Multiplica (optional)</param>
        /// <param name="taxaAdm">Taxa Administrativa (optional)</param>
        /// <param name="taxaBanco">Taxa do Banco (optional)</param>
        /// <param name="limiteRAV">Valor limite do RAV (optional)</param>
        /// <param name="idCredorRAV">C\u00C3\u00B3digo identificador do credor RAV (optional)</param>
        /// <returns>ApiResponse of PageGrupoEconomicoResponse</returns>
        ApiResponse<PageGrupoEconomicoResponse> ListarUsingGET23WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string razaoSocial = null, string nomeCredor = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, string periodicidade = null, string pagamentoSemanal = null, int? pagamentoMensal = null, int? pagamentoDecendialPrimeiro = null, int? pagamentoDecendialSegundo = null, int? pagamentoDecendialTerceiro = null, int? pagamentoQuinzenalPrimeiro = null, int? pagamentoQuinzenalSegundo = null, double? percentualRAV = null, string recebeRAV = null, double? percentualMultiplica = null, double? taxaAdm = null, double? taxaBanco = null, double? limiteRAV = null, long? idCredorRAV = null);
        
        /// <summary>
        /// Lista as Maquinetas
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as maquinetas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Estabelecimento (id). (optional)</param>
        /// <returns>PageMaquinetaResponse</returns>
        PageMaquinetaResponse ListarUsingGET25 (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null);
  
        /// <summary>
        /// Lista as Maquinetas
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as maquinetas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Estabelecimento (id). (optional)</param>
        /// <returns>ApiResponse of PageMaquinetaResponse</returns>
        ApiResponse<PageMaquinetaResponse> ListarUsingGET25WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null);
        
        /// <summary>
        /// Lista os tipos de moedas do emissor 
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os tipos de moedas existentes na base de dados do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="codigoMoeda">C\u00C3\u00B3digo identificador do tipo de moeda. (optional)</param>
        /// <param name="simbolo">S\u00C3\u00ADmbolo da Moeda. (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo da moeda. (optional)</param>
        /// <returns>PageMoedaResponse</returns>
        PageMoedaResponse ListarUsingGET26 (List<string> sort = null, int? page = null, int? limit = null, string codigoMoeda = null, string simbolo = null, string descricao = null);
  
        /// <summary>
        /// Lista os tipos de moedas do emissor 
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os tipos de moedas existentes na base de dados do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="codigoMoeda">C\u00C3\u00B3digo identificador do tipo de moeda. (optional)</param>
        /// <param name="simbolo">S\u00C3\u00ADmbolo da Moeda. (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo da moeda. (optional)</param>
        /// <returns>ApiResponse of PageMoedaResponse</returns>
        ApiResponse<PageMoedaResponse> ListarUsingGET26WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string codigoMoeda = null, string simbolo = null, string descricao = null);
        
        /// <summary>
        /// Lista as Regras Opera\u00C3\u00A7\u00C3\u00B5es
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados as Regras opera\u00C3\u00A7\u00C3\u00B5es existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idOperacao">Apresenta o id da Opera\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="idCredor">Apresenta o id do Credor. (optional)</param>
        /// <param name="idProduto">Apresenta o id do produto que vai ser alterado. (optional)</param>
        /// <returns>PageOperacaoCredorResponse</returns>
        PageOperacaoCredorResponse ListarUsingGET27 (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, long? idCredor = null, long? idProduto = null);
  
        /// <summary>
        /// Lista as Regras Opera\u00C3\u00A7\u00C3\u00B5es
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados as Regras opera\u00C3\u00A7\u00C3\u00B5es existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idOperacao">Apresenta o id da Opera\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="idCredor">Apresenta o id do Credor. (optional)</param>
        /// <param name="idProduto">Apresenta o id do produto que vai ser alterado. (optional)</param>
        /// <returns>ApiResponse of PageOperacaoCredorResponse</returns>
        ApiResponse<PageOperacaoCredorResponse> ListarUsingGET27WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, long? idCredor = null, long? idProduto = null);
        
        /// <summary>
        /// Lista os Telefones Estabelecimentos
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os telefones dos estabelecimentos existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Estabelecimento (id). (optional)</param>
        /// <returns>PageTelefoneEstabelecimentoResponse</returns>
        PageTelefoneEstabelecimentoResponse ListarUsingGET38 (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null);
  
        /// <summary>
        /// Lista os Telefones Estabelecimentos
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os telefones dos estabelecimentos existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Estabelecimento (id). (optional)</param>
        /// <returns>ApiResponse of PageTelefoneEstabelecimentoResponse</returns>
        ApiResponse<PageTelefoneEstabelecimentoResponse> ListarUsingGET38WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null);
        
        /// <summary>
        /// Lista os Terminais cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os terminais existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id). (optional)</param>
        /// <param name="terminal">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do terminal. (optional)</param>
        /// <param name="numeroEstabelecimento">N\u00C3\u00BAmero do estabelecimento a qual o terminal pertence. (optional)</param>
        /// <param name="idEstabelecimento">N\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento a qual o terminal pertence. (optional)</param>
        /// <returns>PageTerminalResponse</returns>
        PageTerminalResponse ListarUsingGET40 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null);
  
        /// <summary>
        /// Lista os Terminais cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os terminais existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id). (optional)</param>
        /// <param name="terminal">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do terminal. (optional)</param>
        /// <param name="numeroEstabelecimento">N\u00C3\u00BAmero do estabelecimento a qual o terminal pertence. (optional)</param>
        /// <param name="idEstabelecimento">N\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento a qual o terminal pertence. (optional)</param>
        /// <returns>ApiResponse of PageTerminalResponse</returns>
        ApiResponse<PageTerminalResponse> ListarUsingGET40WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null);
        
        /// <summary>
        /// Lista os V\u00C3\u00ADnculos dos estabelecimento com os adquirentes
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os V\u00C3\u00ADnculos dos estabelecimento com os adquirentes.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idAdquirente">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do adquirente (id). (optional)</param>
        /// <param name="idEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento. (optional)</param>
        /// <param name="codigoEstabelecimentoAdquirente">C\u00C3\u00B3digo do v\u00C3\u00ADnculo entre o estabelecimento e o adquirente. (optional)</param>
        /// <returns>PageVinculoEstabelecimentoAdquirenteResponse</returns>
        PageVinculoEstabelecimentoAdquirenteResponse ListarUsingGET51 (List<string> sort = null, int? page = null, int? limit = null, long? idAdquirente = null, long? idEstabelecimento = null, string codigoEstabelecimentoAdquirente = null);
  
        /// <summary>
        /// Lista os V\u00C3\u00ADnculos dos estabelecimento com os adquirentes
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os V\u00C3\u00ADnculos dos estabelecimento com os adquirentes.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idAdquirente">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do adquirente (id). (optional)</param>
        /// <param name="idEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento. (optional)</param>
        /// <param name="codigoEstabelecimentoAdquirente">C\u00C3\u00B3digo do v\u00C3\u00ADnculo entre o estabelecimento e o adquirente. (optional)</param>
        /// <returns>ApiResponse of PageVinculoEstabelecimentoAdquirenteResponse</returns>
        ApiResponse<PageVinculoEstabelecimentoAdquirenteResponse> ListarUsingGET51WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idAdquirente = null, long? idEstabelecimento = null, string codigoEstabelecimentoAdquirente = null);
        
        /// <summary>
        /// Lista os v\u00C3\u00ADnculos cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os v\u00C3\u00ADnculos opera\u00C3\u00A7\u00C3\u00B5es existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="idOperacao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Opera\u00C3\u00A7\u00C3\u00A3o (id). (optional)</param>
        /// <param name="codigoMCC">C\u00C3\u00B3digo MCC. (optional)</param>
        /// <returns>PageVinculoOperacaoResponse</returns>
        PageVinculoOperacaoResponse ListarUsingGET52 (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOperacao = null, int? codigoMCC = null);
  
        /// <summary>
        /// Lista os v\u00C3\u00ADnculos cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os v\u00C3\u00ADnculos opera\u00C3\u00A7\u00C3\u00B5es existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="idOperacao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Opera\u00C3\u00A7\u00C3\u00A3o (id). (optional)</param>
        /// <param name="codigoMCC">C\u00C3\u00B3digo MCC. (optional)</param>
        /// <returns>ApiResponse of PageVinculoOperacaoResponse</returns>
        ApiResponse<PageVinculoOperacaoResponse> ListarUsingGET52WithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOperacao = null, int? codigoMCC = null);
        
        /// <summary>
        /// Realiza o cadastro de uma nova maquineta para um estabelecimento 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrada uma nova maquineta para um estabelecimento.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maquinetaPersist">maquinetaPersist</param>
        /// <returns>MaquinetaResponse</returns>
        MaquinetaResponse SalvarUsingPOST16 (MaquinetaPersist maquinetaPersist);
  
        /// <summary>
        /// Realiza o cadastro de uma nova maquineta para um estabelecimento 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrada uma nova maquineta para um estabelecimento.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maquinetaPersist">maquinetaPersist</param>
        /// <returns>ApiResponse of MaquinetaResponse</returns>
        ApiResponse<MaquinetaResponse> SalvarUsingPOST16WithHttpInfo (MaquinetaPersist maquinetaPersist);
        
        /// <summary>
        /// Realiza o cadastro de uma nova Regra Opera\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrada uma nova Regra Opera\u00C3\u00A7\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oprecaoCredorPersist">oprecaoCredorPersist</param>
        /// <returns>OperacaoCredorResponse</returns>
        OperacaoCredorResponse SalvarUsingPOST17 (OperacaoCredorPersist oprecaoCredorPersist);
  
        /// <summary>
        /// Realiza o cadastro de uma nova Regra Opera\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrada uma nova Regra Opera\u00C3\u00A7\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oprecaoCredorPersist">oprecaoCredorPersist</param>
        /// <returns>ApiResponse of OperacaoCredorResponse</returns>
        ApiResponse<OperacaoCredorResponse> SalvarUsingPOST17WithHttpInfo (OperacaoCredorPersist oprecaoCredorPersist);
        
        /// <summary>
        /// Realiza o cadastro de um novo telefone para um estabelecimento 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado um novo telefone para um estabelecimento.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento (id).</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id).</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone.</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <returns>TelefoneEstabelecimentoResponse</returns>
        TelefoneEstabelecimentoResponse SalvarUsingPOST22 (long? idEstabelecimento, string ddd, string telefone, string ramal = null);
  
        /// <summary>
        /// Realiza o cadastro de um novo telefone para um estabelecimento 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado um novo telefone para um estabelecimento.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento (id).</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id).</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone.</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <returns>ApiResponse of TelefoneEstabelecimentoResponse</returns>
        ApiResponse<TelefoneEstabelecimentoResponse> SalvarUsingPOST22WithHttpInfo (long? idEstabelecimento, string ddd, string telefone, string ramal = null);
        
        /// <summary>
        /// Realiza o cadastro de um novo Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado um novo Terminal.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminalPersist">terminalPersist</param>
        /// <returns>TerminalResponse</returns>
        TerminalResponse SalvarUsingPOST24 (TerminalPersist terminalPersist);
  
        /// <summary>
        /// Realiza o cadastro de um novo Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado um novo Terminal.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminalPersist">terminalPersist</param>
        /// <returns>ApiResponse of TerminalResponse</returns>
        ApiResponse<TerminalResponse> SalvarUsingPOST24WithHttpInfo (TerminalPersist terminalPersist);
        
        /// <summary>
        /// Realiza o cadastro de um novo VinculoEstabelecimentoAdquirente
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado um novo VinculoEstabelecimentoAdquirente.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vinculoEstabelecimentoAdquirentePersist">vinculoEstabelecimentoAdquirentePersist</param>
        /// <returns>VinculoEstabelecimentoAdquirenteResponse</returns>
        VinculoEstabelecimentoAdquirenteResponse SalvarUsingPOST29 (VinculoEstabelecimentoAdquirentePersist vinculoEstabelecimentoAdquirentePersist);
  
        /// <summary>
        /// Realiza o cadastro de um novo VinculoEstabelecimentoAdquirente
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado um novo VinculoEstabelecimentoAdquirente.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vinculoEstabelecimentoAdquirentePersist">vinculoEstabelecimentoAdquirentePersist</param>
        /// <returns>ApiResponse of VinculoEstabelecimentoAdquirenteResponse</returns>
        ApiResponse<VinculoEstabelecimentoAdquirenteResponse> SalvarUsingPOST29WithHttpInfo (VinculoEstabelecimentoAdquirentePersist vinculoEstabelecimentoAdquirentePersist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Alterar Origem Comercial
        /// </summary>
        /// <remarks>
        /// Altera uma origem comercial.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da origem comercial</param>
        /// <param name="origemComercialUpdate">origemComercialUpdate</param>
        /// <returns>Task of OrigemComercialResponse</returns>
        System.Threading.Tasks.Task<OrigemComercialResponse> AlterarOrigemComercialUsingPUTAsync (long? id, OrigemComercialUpdate origemComercialUpdate);

        /// <summary>
        /// Alterar Origem Comercial
        /// </summary>
        /// <remarks>
        /// Altera uma origem comercial.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da origem comercial</param>
        /// <param name="origemComercialUpdate">origemComercialUpdate</param>
        /// <returns>Task of ApiResponse (OrigemComercialResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrigemComercialResponse>> AlterarOrigemComercialUsingPUTAsyncWithHttpInfo (long? id, OrigemComercialUpdate origemComercialUpdate);
        
        /// <summary>
        /// Altera uma Maquineta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o das maquinetas dos estabelecimentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Maquineta (id).</param>
        /// <param name="maquinetaUpdate">maquinetaUpdate</param>
        /// <returns>Task of MaquinetaResponse</returns>
        System.Threading.Tasks.Task<MaquinetaResponse> AlterarUsingPUT10Async (long? id, MaquinetaUpdate maquinetaUpdate);

        /// <summary>
        /// Altera uma Maquineta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o das maquinetas dos estabelecimentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Maquineta (id).</param>
        /// <param name="maquinetaUpdate">maquinetaUpdate</param>
        /// <returns>Task of ApiResponse (MaquinetaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MaquinetaResponse>> AlterarUsingPUT10AsyncWithHttpInfo (long? id, MaquinetaUpdate maquinetaUpdate);
        
        /// <summary>
        /// Altera uma Regra Opera\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o de uma regra opera\u00C3\u00A7\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Regra Opera\u00C3\u00A7\u00C3\u00A3o (id).</param>
        /// <param name="operacaoCredorUpdate">operacaoCredorUpdate</param>
        /// <returns>Task of OperacaoCredorResponse</returns>
        System.Threading.Tasks.Task<OperacaoCredorResponse> AlterarUsingPUT11Async (long? id, OperacaoCredorUpdate operacaoCredorUpdate);

        /// <summary>
        /// Altera uma Regra Opera\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o de uma regra opera\u00C3\u00A7\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Regra Opera\u00C3\u00A7\u00C3\u00A3o (id).</param>
        /// <param name="operacaoCredorUpdate">operacaoCredorUpdate</param>
        /// <returns>Task of ApiResponse (OperacaoCredorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperacaoCredorResponse>> AlterarUsingPUT11AsyncWithHttpInfo (long? id, OperacaoCredorUpdate operacaoCredorUpdate);
        
        /// <summary>
        /// Altera um Telefone do estabelecimento
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos telefones dos estabelecimentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone Estabelecimento (id).</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id).</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone.</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <returns>Task of TelefoneEstabelecimentoResponse</returns>
        System.Threading.Tasks.Task<TelefoneEstabelecimentoResponse> AlterarUsingPUT15Async (long? id, string ddd, string telefone, string ramal = null);

        /// <summary>
        /// Altera um Telefone do estabelecimento
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos telefones dos estabelecimentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone Estabelecimento (id).</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id).</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone.</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <returns>Task of ApiResponse (TelefoneEstabelecimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TelefoneEstabelecimentoResponse>> AlterarUsingPUT15AsyncWithHttpInfo (long? id, string ddd, string telefone, string ramal = null);
        
        /// <summary>
        /// Altera um Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos Terminais.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do terminal (id).</param>
        /// <param name="terminalUpdate">terminalUpdate</param>
        /// <returns>Task of TerminalResponse</returns>
        System.Threading.Tasks.Task<TerminalResponse> AlterarUsingPUT17Async (long? id, TerminalUpdate terminalUpdate);

        /// <summary>
        /// Altera um Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos Terminais.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do terminal (id).</param>
        /// <param name="terminalUpdate">terminalUpdate</param>
        /// <returns>Task of ApiResponse (TerminalResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TerminalResponse>> AlterarUsingPUT17AsyncWithHttpInfo (long? id, TerminalUpdate terminalUpdate);
        
        /// <summary>
        /// Alterar um estabelecimento
        /// </summary>
        /// <remarks>
        /// Altera um estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="update">update</param>
        /// <returns>Task of EstabelecimentoResponse</returns>
        System.Threading.Tasks.Task<EstabelecimentoResponse> AlterarUsingPUT6Async (long? id, EstabelecimentoUpdate update);

        /// <summary>
        /// Alterar um estabelecimento
        /// </summary>
        /// <remarks>
        /// Altera um estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (EstabelecimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EstabelecimentoResponse>> AlterarUsingPUT6AsyncWithHttpInfo (long? id, EstabelecimentoUpdate update);
        
        /// <summary>
        /// Alterar Grupo Econ\u00C3\u00B4mico
        /// </summary>
        /// <remarks>
        /// Altera um grupo econ\u00C3\u00B4mico.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do grupo econ\u00C3\u00B4mico</param>
        /// <param name="grupoEconomicoDTO">grupoEconomicoDTO</param>
        /// <returns>Task of GrupoEconomicoResponse</returns>
        System.Threading.Tasks.Task<GrupoEconomicoResponse> AlterarUsingPUT8Async (long? id, GrupoEconomicoDTO grupoEconomicoDTO);

        /// <summary>
        /// Alterar Grupo Econ\u00C3\u00B4mico
        /// </summary>
        /// <remarks>
        /// Altera um grupo econ\u00C3\u00B4mico.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do grupo econ\u00C3\u00B4mico</param>
        /// <param name="grupoEconomicoDTO">grupoEconomicoDTO</param>
        /// <returns>Task of ApiResponse (GrupoEconomicoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GrupoEconomicoResponse>> AlterarUsingPUT8AsyncWithHttpInfo (long? id, GrupoEconomicoDTO grupoEconomicoDTO);
        
        /// <summary>
        /// Cadastrar Origem Comercial
        /// </summary>
        /// <remarks>
        /// Cadastra uma origem comercial.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origemComercialPersist">origemComercialPersist</param>
        /// <returns>Task of OrigemComercialResponse</returns>
        System.Threading.Tasks.Task<OrigemComercialResponse> CadastrarOrigemComercialUsingPOSTAsync (OrigemComercialPersist origemComercialPersist);

        /// <summary>
        /// Cadastrar Origem Comercial
        /// </summary>
        /// <remarks>
        /// Cadastra uma origem comercial.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origemComercialPersist">origemComercialPersist</param>
        /// <returns>Task of ApiResponse (OrigemComercialResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrigemComercialResponse>> CadastrarOrigemComercialUsingPOSTAsyncWithHttpInfo (OrigemComercialPersist origemComercialPersist);
        
        /// <summary>
        /// Cadastrar um estabelecimento
        /// </summary>
        /// <remarks>
        /// Cadastra um novo estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of EstabelecimentoResponse</returns>
        System.Threading.Tasks.Task<EstabelecimentoResponse> CadastrarUsingPOST2Async (EstabelecimentoPersist persist);

        /// <summary>
        /// Cadastrar um estabelecimento
        /// </summary>
        /// <remarks>
        /// Cadastra um novo estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (EstabelecimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EstabelecimentoResponse>> CadastrarUsingPOST2AsyncWithHttpInfo (EstabelecimentoPersist persist);
        
        /// <summary>
        /// Cadastrar Grupo Econ\u00C3\u00B4mico
        /// </summary>
        /// <remarks>
        /// Cadastra um grupo econ\u00C3\u00B4mico.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoEconomicoDTO">GrupoEconomicoDTO</param>
        /// <returns>Task of GrupoEconomicoResponse</returns>
        System.Threading.Tasks.Task<GrupoEconomicoResponse> CadastrarUsingPOST3Async (GrupoEconomicoDTO grupoEconomicoDTO);

        /// <summary>
        /// Cadastrar Grupo Econ\u00C3\u00B4mico
        /// </summary>
        /// <remarks>
        /// Cadastra um grupo econ\u00C3\u00B4mico.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoEconomicoDTO">GrupoEconomicoDTO</param>
        /// <returns>Task of ApiResponse (GrupoEconomicoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GrupoEconomicoResponse>> CadastrarUsingPOST3AsyncWithHttpInfo (GrupoEconomicoDTO grupoEconomicoDTO);
        
        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado tipo opera\u00C3\u00A7\u00C3\u00A3o a partir do idoperacao
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de processamento da opera\u00C3\u00A7\u00C3\u00A3o (idOperacao).</param>
        /// <returns>Task of DetalheOperacaoResponse</returns>
        System.Threading.Tasks.Task<DetalheOperacaoResponse> ConsultaOperacaoUsingGETAsync (long? id);

        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado tipo opera\u00C3\u00A7\u00C3\u00A3o a partir do idoperacao
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de processamento da opera\u00C3\u00A7\u00C3\u00A3o (idOperacao).</param>
        /// <returns>Task of ApiResponse (DetalheOperacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DetalheOperacaoResponse>> ConsultaOperacaoUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar Origem Comercial
        /// </summary>
        /// <remarks>
        /// Consulta uma origem comercial atrav\u00C3\u00A9s do seu identificador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da origem comercial</param>
        /// <returns>Task of OrigemComercialResponse</returns>
        System.Threading.Tasks.Task<OrigemComercialResponse> ConsultarOrigemComercialUsingGETAsync (long? id);

        /// <summary>
        /// Consultar Origem Comercial
        /// </summary>
        /// <remarks>
        /// Consulta uma origem comercial atrav\u00C3\u00A9s do seu identificador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da origem comercial</param>
        /// <returns>Task of ApiResponse (OrigemComercialResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrigemComercialResponse>> ConsultarOrigemComercialUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar estabelecimento por id
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de um determinado estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of EstabelecimentoResponse</returns>
        System.Threading.Tasks.Task<EstabelecimentoResponse> ConsultarUsingGET16Async (long? id);

        /// <summary>
        /// Consultar estabelecimento por id
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de um determinado estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (EstabelecimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EstabelecimentoResponse>> ConsultarUsingGET16AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar grupo econ\u00C3\u00B4mico
        /// </summary>
        /// <remarks>
        /// Consulta um grupo econ\u00C3\u00B4mico atrav\u00C3\u00A9s do seu identificador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do grupo econ\u00C3\u00B4mico</param>
        /// <returns>Task of GrupoEconomicoResponse</returns>
        System.Threading.Tasks.Task<GrupoEconomicoResponse> ConsultarUsingGET18Async (long? id);

        /// <summary>
        /// Consultar grupo econ\u00C3\u00B4mico
        /// </summary>
        /// <remarks>
        /// Consulta um grupo econ\u00C3\u00B4mico atrav\u00C3\u00A9s do seu identificador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do grupo econ\u00C3\u00B4mico</param>
        /// <returns>Task of ApiResponse (GrupoEconomicoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GrupoEconomicoResponse>> ConsultarUsingGET18AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de uma determinada maquineta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar uma determinada maquineta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Maquineta (id).</param>
        /// <returns>Task of MaquinetaResponse</returns>
        System.Threading.Tasks.Task<MaquinetaResponse> ConsultarUsingGET20Async (long? id);

        /// <summary>
        /// Apresenta os dados de uma determinada maquineta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar uma determinada maquineta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Maquineta (id).</param>
        /// <returns>Task of ApiResponse (MaquinetaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MaquinetaResponse>> ConsultarUsingGET20AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de uma determinada Regra Opera\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar uma determinada regra opera\u00C3\u00A7\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Regra Opera\u00C3\u00A7\u00C3\u00A3o (id).</param>
        /// <returns>Task of OperacaoCredorResponse</returns>
        System.Threading.Tasks.Task<OperacaoCredorResponse> ConsultarUsingGET21Async (long? id);

        /// <summary>
        /// Apresenta os dados de uma determinada Regra Opera\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar uma determinada regra opera\u00C3\u00A7\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Regra Opera\u00C3\u00A7\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (OperacaoCredorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperacaoCredorResponse>> ConsultarUsingGET21AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado telefone de um estabelecimento
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado telefone de um estabelecimento a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone Estabelecimento (id).</param>
        /// <returns>Task of TelefoneEstabelecimentoResponse</returns>
        System.Threading.Tasks.Task<TelefoneEstabelecimentoResponse> ConsultarUsingGET29Async (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado telefone de um estabelecimento
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado telefone de um estabelecimento a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone Estabelecimento (id).</param>
        /// <returns>Task of ApiResponse (TelefoneEstabelecimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TelefoneEstabelecimentoResponse>> ConsultarUsingGET29AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Terminal a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id).</param>
        /// <returns>Task of TerminalResponse</returns>
        System.Threading.Tasks.Task<TerminalResponse> ConsultarUsingGET31Async (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Terminal a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id).</param>
        /// <returns>Task of ApiResponse (TerminalResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TerminalResponse>> ConsultarUsingGET31AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado V\u00C3\u00ADnculo
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado V\u00C3\u00ADnculo a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do V\u00C3\u008Dnculo (id).</param>
        /// <returns>Task of VinculoEstabelecimentoAdquirenteResponse</returns>
        System.Threading.Tasks.Task<VinculoEstabelecimentoAdquirenteResponse> ConsultarUsingGET43Async (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado V\u00C3\u00ADnculo
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado V\u00C3\u00ADnculo a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do V\u00C3\u008Dnculo (id).</param>
        /// <returns>Task of ApiResponse (VinculoEstabelecimentoAdquirenteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<VinculoEstabelecimentoAdquirenteResponse>> ConsultarUsingGET43AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Desabilitar um V\u00C3\u00ADnculo
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a desativa\u00C3\u00A7\u00C3\u00A3o de um v\u00C3\u00ADnculo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do V\u00C3\u00ADnculo (id).</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> DesabilitarVinculoUsingPOSTAsync (long? id);

        /// <summary>
        /// Desabilitar um V\u00C3\u00ADnculo
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a desativa\u00C3\u00A7\u00C3\u00A3o de um v\u00C3\u00ADnculo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do V\u00C3\u00ADnculo (id).</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DesabilitarVinculoUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Desabilitar um v\u00C3\u00ADnculo opera\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite desabilitar um v\u00C3\u00ADnculo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id).</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> DesabilitarVinculoUsingPOST1Async (long? id, VinculoOperacaoPersist vinculoOperacaoPersist);

        /// <summary>
        /// Desabilitar um v\u00C3\u00ADnculo opera\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite desabilitar um v\u00C3\u00ADnculo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id).</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DesabilitarVinculoUsingPOST1AsyncWithHttpInfo (long? id, VinculoOperacaoPersist vinculoOperacaoPersist);
        
        /// <summary>
        /// Habilitar um V\u00C3\u00ADnculo
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a ativa\u00C3\u00A7\u00C3\u00A3o de um v\u00C3\u00ADnculo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do V\u00C3\u00ADnculo (id).</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> HabilitarVinculoUsingPOSTAsync (long? id);

        /// <summary>
        /// Habilitar um V\u00C3\u00ADnculo
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a ativa\u00C3\u00A7\u00C3\u00A3o de um v\u00C3\u00ADnculo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do V\u00C3\u00ADnculo (id).</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> HabilitarVinculoUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Habilitar um v\u00C3\u00ADnculo opera\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite habilitar um v\u00C3\u00ADnculo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id).</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> HabilitarVinculoUsingPOST1Async (long? id, VinculoOperacaoPersist vinculoOperacaoPersist);

        /// <summary>
        /// Habilitar um v\u00C3\u00ADnculo opera\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite habilitar um v\u00C3\u00ADnculo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id).</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> HabilitarVinculoUsingPOST1AsyncWithHttpInfo (long? id, VinculoOperacaoPersist vinculoOperacaoPersist);
        
        /// <summary>
        /// Apresenta dados de opera\u00C3\u00A7\u00C3\u00B5es em uma lista
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as opera\u00C3\u00A7\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idOperacao">C\u00C3\u00B3digo que identifica a opera\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="codigoProcessamento">C\u00C3\u00B3digo de processamento usado em transa\u00C3\u00A7\u00C3\u00B5es com o autorizador (optional)</param>
        /// <returns>Task of PageOperacaoResponse</returns>
        System.Threading.Tasks.Task<PageOperacaoResponse> ListaOperacaoUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, string codigoProcessamento = null);

        /// <summary>
        /// Apresenta dados de opera\u00C3\u00A7\u00C3\u00B5es em uma lista
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as opera\u00C3\u00A7\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idOperacao">C\u00C3\u00B3digo que identifica a opera\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="codigoProcessamento">C\u00C3\u00B3digo de processamento usado em transa\u00C3\u00A7\u00C3\u00B5es com o autorizador (optional)</param>
        /// <returns>Task of ApiResponse (PageOperacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageOperacaoResponse>> ListaOperacaoUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, string codigoProcessamento = null);
        
        /// <summary>
        /// Lista os MCCs
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os MCCs existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageMCCResponse</returns>
        System.Threading.Tasks.Task<PageMCCResponse> ListarMCCUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista os MCCs
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os MCCs existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageMCCResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageMCCResponse>> ListarMCCUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar Origens Comerciais
        /// </summary>
        /// <remarks>
        /// Lista origens comerciais cadastradas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Id da origem comercial (optional)</param>
        /// <param name="nome">Nome da origem comercial (optional)</param>
        /// <param name="status">Indica o status da origem comercial (optional)</param>
        /// <param name="idEstabelecimento">Identificador do estabelecimento (optional)</param>
        /// <param name="idProduto">Identificador do produto (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o da origem comercial (optional)</param>
        /// <param name="idTipoOrigemComercial">Identificador do tipo de origem comercial (optional)</param>
        /// <param name="idGrupoOrigemComercial">Identificador do grupo de origem comercial (optional)</param>
        /// <param name="flagPreAprovado">Indica se permite pr\u00C3\u00A9 aprova\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="flagAprovacaoImediata">Indica se permite aprova\u00C3\u00A7\u00C3\u00A3o imediata (optional)</param>
        /// <param name="nomeFantasiaPlastico">Nome fantasia impresso no pl\u00C3\u00A1stico (optional)</param>
        /// <param name="flagCartaoProvisorio">Indica se permite cart\u00C3\u00A3o provis\u00C3\u00B3rio (optional)</param>
        /// <param name="flagCartaoDefinitivo">Indica se permite cart\u00C3\u00A3o definitivo (optional)</param>
        /// <param name="usuario">Usu\u00C3\u00A1rio para autentica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="senha">Senha para autentica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="flagOrigemExterna">Indica se \u00C3\u00A9 origem externa (optional)</param>
        /// <param name="flagModificado">Indica se h\u00C3\u00A1 modifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="flagEnviaFaturaUsuario">Indica se envia fatura (optional)</param>
        /// <param name="flagCreditoFaturamento">Indica se permite cr\u00C3\u00A9dito de faturamento (optional)</param>
        /// <param name="flagConcedeLimiteProvisorio">Indica se concede limite provis\u00C3\u00B3rio (optional)</param>
        /// <param name="flagDigitalizarDoc">Indica se digitaliza documento (optional)</param>
        /// <param name="flagEmbossingLoja">Indica se realiza embossing em loja (optional)</param>
        /// <param name="flagConsultaPrevia">Indica se realiza consulta pr\u00C3\u00A9via (optional)</param>
        /// <param name="tipoPessoa">Tipo de pessoa (optional)</param>
        /// <returns>Task of PageOrigemComercialResponse</returns>
        System.Threading.Tasks.Task<PageOrigemComercialResponse> ListarOrigensComerciaisUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null, long? idEstabelecimento = null, long? idProduto = null, string descricao = null, long? idTipoOrigemComercial = null, long? idGrupoOrigemComercial = null, bool? flagPreAprovado = null, bool? flagAprovacaoImediata = null, string nomeFantasiaPlastico = null, bool? flagCartaoProvisorio = null, bool? flagCartaoDefinitivo = null, string usuario = null, string senha = null, bool? flagOrigemExterna = null, bool? flagModificado = null, bool? flagEnviaFaturaUsuario = null, bool? flagCreditoFaturamento = null, bool? flagConcedeLimiteProvisorio = null, bool? flagDigitalizarDoc = null, bool? flagEmbossingLoja = null, bool? flagConsultaPrevia = null, string tipoPessoa = null);

        /// <summary>
        /// Listar Origens Comerciais
        /// </summary>
        /// <remarks>
        /// Lista origens comerciais cadastradas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Id da origem comercial (optional)</param>
        /// <param name="nome">Nome da origem comercial (optional)</param>
        /// <param name="status">Indica o status da origem comercial (optional)</param>
        /// <param name="idEstabelecimento">Identificador do estabelecimento (optional)</param>
        /// <param name="idProduto">Identificador do produto (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o da origem comercial (optional)</param>
        /// <param name="idTipoOrigemComercial">Identificador do tipo de origem comercial (optional)</param>
        /// <param name="idGrupoOrigemComercial">Identificador do grupo de origem comercial (optional)</param>
        /// <param name="flagPreAprovado">Indica se permite pr\u00C3\u00A9 aprova\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="flagAprovacaoImediata">Indica se permite aprova\u00C3\u00A7\u00C3\u00A3o imediata (optional)</param>
        /// <param name="nomeFantasiaPlastico">Nome fantasia impresso no pl\u00C3\u00A1stico (optional)</param>
        /// <param name="flagCartaoProvisorio">Indica se permite cart\u00C3\u00A3o provis\u00C3\u00B3rio (optional)</param>
        /// <param name="flagCartaoDefinitivo">Indica se permite cart\u00C3\u00A3o definitivo (optional)</param>
        /// <param name="usuario">Usu\u00C3\u00A1rio para autentica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="senha">Senha para autentica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="flagOrigemExterna">Indica se \u00C3\u00A9 origem externa (optional)</param>
        /// <param name="flagModificado">Indica se h\u00C3\u00A1 modifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="flagEnviaFaturaUsuario">Indica se envia fatura (optional)</param>
        /// <param name="flagCreditoFaturamento">Indica se permite cr\u00C3\u00A9dito de faturamento (optional)</param>
        /// <param name="flagConcedeLimiteProvisorio">Indica se concede limite provis\u00C3\u00B3rio (optional)</param>
        /// <param name="flagDigitalizarDoc">Indica se digitaliza documento (optional)</param>
        /// <param name="flagEmbossingLoja">Indica se realiza embossing em loja (optional)</param>
        /// <param name="flagConsultaPrevia">Indica se realiza consulta pr\u00C3\u00A9via (optional)</param>
        /// <param name="tipoPessoa">Tipo de pessoa (optional)</param>
        /// <returns>Task of ApiResponse (PageOrigemComercialResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageOrigemComercialResponse>> ListarOrigensComerciaisUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null, long? idEstabelecimento = null, long? idProduto = null, string descricao = null, long? idTipoOrigemComercial = null, long? idGrupoOrigemComercial = null, bool? flagPreAprovado = null, bool? flagAprovacaoImediata = null, string nomeFantasiaPlastico = null, bool? flagCartaoProvisorio = null, bool? flagCartaoDefinitivo = null, string usuario = null, string senha = null, bool? flagOrigemExterna = null, bool? flagModificado = null, bool? flagEnviaFaturaUsuario = null, bool? flagCreditoFaturamento = null, bool? flagConcedeLimiteProvisorio = null, bool? flagDigitalizarDoc = null, bool? flagEmbossingLoja = null, bool? flagConsultaPrevia = null, string tipoPessoa = null);
        
        /// <summary>
        /// Lista os Tipos de adquirentes
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os tipos de adquirentes.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageEntidadeResponse</returns>
        System.Threading.Tasks.Task<PageEntidadeResponse> ListarTiposAdquirentesUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista os Tipos de adquirentes
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os tipos de adquirentes.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageEntidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageEntidadeResponse>> ListarTiposAdquirentesUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os Tipos de  Maquinetas
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas os Tipos de maquinetas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarTiposMaquinetasUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista os Tipos de  Maquinetas
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas os Tipos de maquinetas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarTiposMaquinetasUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os Tipos Terminais
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os tipos de terminais existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageTipoTerminalResponse</returns>
        System.Threading.Tasks.Task<PageTipoTerminalResponse> ListarTiposTerminaisUsingGET1Async (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista os Tipos Terminais
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os tipos de terminais existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoTerminalResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoTerminalResponse>> ListarTiposTerminaisUsingGET1AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista Estabelecimentos
        /// </summary>
        /// <remarks>
        /// Lista todas os Estabelecimentos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id). (optional)</param>
        /// <param name="idCredor">Apresenta o n\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Credor. (optional)</param>
        /// <param name="numeroReceitaFederal">Apresenta o n\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento na Receita Federal. (optional)</param>
        /// <param name="nome">Nome do Estabelecimento. (optional)</param>
        /// <param name="descricao">Raz\u00C3\u00A3o Social do Estabelecimento. (optional)</param>
        /// <param name="nomeFantasia">T\u00C3\u00ADtulo Comercial do Estabelecimento. (optional)</param>
        /// <param name="cep">C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP). (optional)</param>
        /// <param name="nomeLogradouro">Nome do Logradouro. (optional)</param>
        /// <param name="numeroEndereco">N\u00C3\u00BAmero do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="complemento">Descri\u00C3\u00A7\u00C3\u00B5es complementares referente ao endere\u00C3\u00A7o. (optional)</param>
        /// <param name="bairro">Nome do bairro do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="cidade">Nome da cidade do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="uf">Sigla de identifica\u00C3\u00A7\u00C3\u00A3o da Unidade Federativa do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="pais">Nome do pa\u00C3\u00ADs. (optional)</param>
        /// <param name="dataCadastramento">Data de Cadastro do Estabelecimento, no formato yyyy-MM-dd. (optional)</param>
        /// <param name="contato">Nome da pessoa para contato com o Estabelecimento. (optional)</param>
        /// <param name="email">E-mail da pessoa para contato com o Estabelecimento. (optional)</param>
        /// <param name="flagArquivoSecrFazenda">Indica se o estabelecimento ser\u00C3\u00A1 inclu\u00C3\u00ADdo no arquivo de registro para a Secretaria da Fazenda Estadual. (optional)</param>
        /// <param name="flagCartaoDigitado">Indica se o estabelecimento poder\u00C3\u00A1 originar transa\u00C3\u00A7\u00C3\u00B5es sem a leitura da tarja ou do chip do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="inativo">Indica se o estabelecimento est\u00C3\u00A1 inativo. (optional)</param>
        /// <param name="idPais">Identificador de Pa\u00C3\u00ADs. (optional)</param>
        /// <param name="mcc">C\u00C3\u00B3digo de Categoria de Mercado (optional)</param>
        /// <param name="idTipoEstabelecimento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento. (optional)</param>
        /// <param name="idMoeda">C\u00C3\u00B3digo identificador da moeda. (optional)</param>
        /// <param name="tipoPagamento">Tipo do regime de pagamento do estabelecimento. (optional)</param>
        /// <param name="numeroEstabelecimento">N\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento na Conductor. (optional)</param>
        /// <param name="cep2">C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP). (optional)</param>
        /// <param name="nomeLogradouro2">Nome do Logradouro. (optional)</param>
        /// <param name="numeroEndereco2">N\u00C3\u00BAmero do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="complemento2">Descri\u00C3\u00A7\u00C3\u00B5es complementares referente ao endere\u00C3\u00A7o. (optional)</param>
        /// <param name="bairro2">Nome do bairro do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="cidade2">Nome da cidade do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="uf2">Sigla de identifica\u00C3\u00A7\u00C3\u00A3o da Unidade Federativa do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="flagMatriz">Indica se \u00C3\u00A9 matriz ou filial. (optional)</param>
        /// <returns>Task of PageEstabelecimentoResponse</returns>
        System.Threading.Tasks.Task<PageEstabelecimentoResponse> ListarUsingGET21Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idCredor = null, string numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, int? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null, long? idPais = null, long? mcc = null, long? idTipoEstabelecimento = null, long? idMoeda = null, string tipoPagamento = null, string numeroEstabelecimento = null, string cep2 = null, string nomeLogradouro2 = null, int? numeroEndereco2 = null, string complemento2 = null, string bairro2 = null, string cidade2 = null, string uf2 = null, int? flagMatriz = null);

        /// <summary>
        /// Lista Estabelecimentos
        /// </summary>
        /// <remarks>
        /// Lista todas os Estabelecimentos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id). (optional)</param>
        /// <param name="idCredor">Apresenta o n\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Credor. (optional)</param>
        /// <param name="numeroReceitaFederal">Apresenta o n\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento na Receita Federal. (optional)</param>
        /// <param name="nome">Nome do Estabelecimento. (optional)</param>
        /// <param name="descricao">Raz\u00C3\u00A3o Social do Estabelecimento. (optional)</param>
        /// <param name="nomeFantasia">T\u00C3\u00ADtulo Comercial do Estabelecimento. (optional)</param>
        /// <param name="cep">C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP). (optional)</param>
        /// <param name="nomeLogradouro">Nome do Logradouro. (optional)</param>
        /// <param name="numeroEndereco">N\u00C3\u00BAmero do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="complemento">Descri\u00C3\u00A7\u00C3\u00B5es complementares referente ao endere\u00C3\u00A7o. (optional)</param>
        /// <param name="bairro">Nome do bairro do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="cidade">Nome da cidade do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="uf">Sigla de identifica\u00C3\u00A7\u00C3\u00A3o da Unidade Federativa do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="pais">Nome do pa\u00C3\u00ADs. (optional)</param>
        /// <param name="dataCadastramento">Data de Cadastro do Estabelecimento, no formato yyyy-MM-dd. (optional)</param>
        /// <param name="contato">Nome da pessoa para contato com o Estabelecimento. (optional)</param>
        /// <param name="email">E-mail da pessoa para contato com o Estabelecimento. (optional)</param>
        /// <param name="flagArquivoSecrFazenda">Indica se o estabelecimento ser\u00C3\u00A1 inclu\u00C3\u00ADdo no arquivo de registro para a Secretaria da Fazenda Estadual. (optional)</param>
        /// <param name="flagCartaoDigitado">Indica se o estabelecimento poder\u00C3\u00A1 originar transa\u00C3\u00A7\u00C3\u00B5es sem a leitura da tarja ou do chip do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="inativo">Indica se o estabelecimento est\u00C3\u00A1 inativo. (optional)</param>
        /// <param name="idPais">Identificador de Pa\u00C3\u00ADs. (optional)</param>
        /// <param name="mcc">C\u00C3\u00B3digo de Categoria de Mercado (optional)</param>
        /// <param name="idTipoEstabelecimento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento. (optional)</param>
        /// <param name="idMoeda">C\u00C3\u00B3digo identificador da moeda. (optional)</param>
        /// <param name="tipoPagamento">Tipo do regime de pagamento do estabelecimento. (optional)</param>
        /// <param name="numeroEstabelecimento">N\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento na Conductor. (optional)</param>
        /// <param name="cep2">C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP). (optional)</param>
        /// <param name="nomeLogradouro2">Nome do Logradouro. (optional)</param>
        /// <param name="numeroEndereco2">N\u00C3\u00BAmero do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="complemento2">Descri\u00C3\u00A7\u00C3\u00B5es complementares referente ao endere\u00C3\u00A7o. (optional)</param>
        /// <param name="bairro2">Nome do bairro do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="cidade2">Nome da cidade do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="uf2">Sigla de identifica\u00C3\u00A7\u00C3\u00A3o da Unidade Federativa do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="flagMatriz">Indica se \u00C3\u00A9 matriz ou filial. (optional)</param>
        /// <returns>Task of ApiResponse (PageEstabelecimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageEstabelecimentoResponse>> ListarUsingGET21AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idCredor = null, string numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, int? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null, long? idPais = null, long? mcc = null, long? idTipoEstabelecimento = null, long? idMoeda = null, string tipoPagamento = null, string numeroEstabelecimento = null, string cep2 = null, string nomeLogradouro2 = null, int? numeroEndereco2 = null, string complemento2 = null, string bairro2 = null, string cidade2 = null, string uf2 = null, int? flagMatriz = null);
        
        /// <summary>
        /// Listar grupos econ\u00C3\u00B4micos
        /// </summary>
        /// <remarks>
        /// Lista grupos econ\u00C3\u00B4micos cadastrados. 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="razaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="nomeCredor">Nome do credor (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00C3\u00BAmero da Receita Federal (optional)</param>
        /// <param name="inscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual (optional)</param>
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param>
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="digitoAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param>
        /// <param name="digitoContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param>
        /// <param name="periodicidade">Periodicidade do pagamento (optional)</param>
        /// <param name="pagamentoSemanal">Dia para pagamento semanal (optional)</param>
        /// <param name="pagamentoMensal">Dia da data para o pagamento mensal (optional)</param>
        /// <param name="pagamentoDecendialPrimeiro">Dia da data para o primeiro pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialSegundo">Dia da data para o segundo pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialTerceiro">Dia da data para o terceiro pagamento decendial (optional)</param>
        /// <param name="pagamentoQuinzenalPrimeiro">Dia da data para o primeiro pagamento quinzenal (optional)</param>
        /// <param name="pagamentoQuinzenalSegundo">Dia da data para o segundo pagamento quinzenal (optional)</param>
        /// <param name="percentualRAV">Valor percentual do RAV do credor (optional)</param>
        /// <param name="recebeRAV">Indica se o credor recebe RAV e o tipo (optional)</param>
        /// <param name="percentualMultiplica">Percentual Multiplica (optional)</param>
        /// <param name="taxaAdm">Taxa Administrativa (optional)</param>
        /// <param name="taxaBanco">Taxa do Banco (optional)</param>
        /// <param name="limiteRAV">Valor limite do RAV (optional)</param>
        /// <param name="idCredorRAV">C\u00C3\u00B3digo identificador do credor RAV (optional)</param>
        /// <returns>Task of PageGrupoEconomicoResponse</returns>
        System.Threading.Tasks.Task<PageGrupoEconomicoResponse> ListarUsingGET23Async (List<string> sort = null, int? page = null, int? limit = null, string razaoSocial = null, string nomeCredor = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, string periodicidade = null, string pagamentoSemanal = null, int? pagamentoMensal = null, int? pagamentoDecendialPrimeiro = null, int? pagamentoDecendialSegundo = null, int? pagamentoDecendialTerceiro = null, int? pagamentoQuinzenalPrimeiro = null, int? pagamentoQuinzenalSegundo = null, double? percentualRAV = null, string recebeRAV = null, double? percentualMultiplica = null, double? taxaAdm = null, double? taxaBanco = null, double? limiteRAV = null, long? idCredorRAV = null);

        /// <summary>
        /// Listar grupos econ\u00C3\u00B4micos
        /// </summary>
        /// <remarks>
        /// Lista grupos econ\u00C3\u00B4micos cadastrados. 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="razaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="nomeCredor">Nome do credor (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00C3\u00BAmero da Receita Federal (optional)</param>
        /// <param name="inscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual (optional)</param>
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param>
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="digitoAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param>
        /// <param name="digitoContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param>
        /// <param name="periodicidade">Periodicidade do pagamento (optional)</param>
        /// <param name="pagamentoSemanal">Dia para pagamento semanal (optional)</param>
        /// <param name="pagamentoMensal">Dia da data para o pagamento mensal (optional)</param>
        /// <param name="pagamentoDecendialPrimeiro">Dia da data para o primeiro pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialSegundo">Dia da data para o segundo pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialTerceiro">Dia da data para o terceiro pagamento decendial (optional)</param>
        /// <param name="pagamentoQuinzenalPrimeiro">Dia da data para o primeiro pagamento quinzenal (optional)</param>
        /// <param name="pagamentoQuinzenalSegundo">Dia da data para o segundo pagamento quinzenal (optional)</param>
        /// <param name="percentualRAV">Valor percentual do RAV do credor (optional)</param>
        /// <param name="recebeRAV">Indica se o credor recebe RAV e o tipo (optional)</param>
        /// <param name="percentualMultiplica">Percentual Multiplica (optional)</param>
        /// <param name="taxaAdm">Taxa Administrativa (optional)</param>
        /// <param name="taxaBanco">Taxa do Banco (optional)</param>
        /// <param name="limiteRAV">Valor limite do RAV (optional)</param>
        /// <param name="idCredorRAV">C\u00C3\u00B3digo identificador do credor RAV (optional)</param>
        /// <returns>Task of ApiResponse (PageGrupoEconomicoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageGrupoEconomicoResponse>> ListarUsingGET23AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string razaoSocial = null, string nomeCredor = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, string periodicidade = null, string pagamentoSemanal = null, int? pagamentoMensal = null, int? pagamentoDecendialPrimeiro = null, int? pagamentoDecendialSegundo = null, int? pagamentoDecendialTerceiro = null, int? pagamentoQuinzenalPrimeiro = null, int? pagamentoQuinzenalSegundo = null, double? percentualRAV = null, string recebeRAV = null, double? percentualMultiplica = null, double? taxaAdm = null, double? taxaBanco = null, double? limiteRAV = null, long? idCredorRAV = null);
        
        /// <summary>
        /// Lista as Maquinetas
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as maquinetas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Estabelecimento (id). (optional)</param>
        /// <returns>Task of PageMaquinetaResponse</returns>
        System.Threading.Tasks.Task<PageMaquinetaResponse> ListarUsingGET25Async (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null);

        /// <summary>
        /// Lista as Maquinetas
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as maquinetas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Estabelecimento (id). (optional)</param>
        /// <returns>Task of ApiResponse (PageMaquinetaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageMaquinetaResponse>> ListarUsingGET25AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null);
        
        /// <summary>
        /// Lista os tipos de moedas do emissor 
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os tipos de moedas existentes na base de dados do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="codigoMoeda">C\u00C3\u00B3digo identificador do tipo de moeda. (optional)</param>
        /// <param name="simbolo">S\u00C3\u00ADmbolo da Moeda. (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo da moeda. (optional)</param>
        /// <returns>Task of PageMoedaResponse</returns>
        System.Threading.Tasks.Task<PageMoedaResponse> ListarUsingGET26Async (List<string> sort = null, int? page = null, int? limit = null, string codigoMoeda = null, string simbolo = null, string descricao = null);

        /// <summary>
        /// Lista os tipos de moedas do emissor 
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os tipos de moedas existentes na base de dados do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="codigoMoeda">C\u00C3\u00B3digo identificador do tipo de moeda. (optional)</param>
        /// <param name="simbolo">S\u00C3\u00ADmbolo da Moeda. (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo da moeda. (optional)</param>
        /// <returns>Task of ApiResponse (PageMoedaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageMoedaResponse>> ListarUsingGET26AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string codigoMoeda = null, string simbolo = null, string descricao = null);
        
        /// <summary>
        /// Lista as Regras Opera\u00C3\u00A7\u00C3\u00B5es
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados as Regras opera\u00C3\u00A7\u00C3\u00B5es existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idOperacao">Apresenta o id da Opera\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="idCredor">Apresenta o id do Credor. (optional)</param>
        /// <param name="idProduto">Apresenta o id do produto que vai ser alterado. (optional)</param>
        /// <returns>Task of PageOperacaoCredorResponse</returns>
        System.Threading.Tasks.Task<PageOperacaoCredorResponse> ListarUsingGET27Async (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, long? idCredor = null, long? idProduto = null);

        /// <summary>
        /// Lista as Regras Opera\u00C3\u00A7\u00C3\u00B5es
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados as Regras opera\u00C3\u00A7\u00C3\u00B5es existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idOperacao">Apresenta o id da Opera\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="idCredor">Apresenta o id do Credor. (optional)</param>
        /// <param name="idProduto">Apresenta o id do produto que vai ser alterado. (optional)</param>
        /// <returns>Task of ApiResponse (PageOperacaoCredorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageOperacaoCredorResponse>> ListarUsingGET27AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, long? idCredor = null, long? idProduto = null);
        
        /// <summary>
        /// Lista os Telefones Estabelecimentos
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os telefones dos estabelecimentos existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Estabelecimento (id). (optional)</param>
        /// <returns>Task of PageTelefoneEstabelecimentoResponse</returns>
        System.Threading.Tasks.Task<PageTelefoneEstabelecimentoResponse> ListarUsingGET38Async (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null);

        /// <summary>
        /// Lista os Telefones Estabelecimentos
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os telefones dos estabelecimentos existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Estabelecimento (id). (optional)</param>
        /// <returns>Task of ApiResponse (PageTelefoneEstabelecimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTelefoneEstabelecimentoResponse>> ListarUsingGET38AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null);
        
        /// <summary>
        /// Lista os Terminais cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os terminais existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id). (optional)</param>
        /// <param name="terminal">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do terminal. (optional)</param>
        /// <param name="numeroEstabelecimento">N\u00C3\u00BAmero do estabelecimento a qual o terminal pertence. (optional)</param>
        /// <param name="idEstabelecimento">N\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento a qual o terminal pertence. (optional)</param>
        /// <returns>Task of PageTerminalResponse</returns>
        System.Threading.Tasks.Task<PageTerminalResponse> ListarUsingGET40Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null);

        /// <summary>
        /// Lista os Terminais cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os terminais existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id). (optional)</param>
        /// <param name="terminal">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do terminal. (optional)</param>
        /// <param name="numeroEstabelecimento">N\u00C3\u00BAmero do estabelecimento a qual o terminal pertence. (optional)</param>
        /// <param name="idEstabelecimento">N\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento a qual o terminal pertence. (optional)</param>
        /// <returns>Task of ApiResponse (PageTerminalResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTerminalResponse>> ListarUsingGET40AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null);
        
        /// <summary>
        /// Lista os V\u00C3\u00ADnculos dos estabelecimento com os adquirentes
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os V\u00C3\u00ADnculos dos estabelecimento com os adquirentes.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idAdquirente">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do adquirente (id). (optional)</param>
        /// <param name="idEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento. (optional)</param>
        /// <param name="codigoEstabelecimentoAdquirente">C\u00C3\u00B3digo do v\u00C3\u00ADnculo entre o estabelecimento e o adquirente. (optional)</param>
        /// <returns>Task of PageVinculoEstabelecimentoAdquirenteResponse</returns>
        System.Threading.Tasks.Task<PageVinculoEstabelecimentoAdquirenteResponse> ListarUsingGET51Async (List<string> sort = null, int? page = null, int? limit = null, long? idAdquirente = null, long? idEstabelecimento = null, string codigoEstabelecimentoAdquirente = null);

        /// <summary>
        /// Lista os V\u00C3\u00ADnculos dos estabelecimento com os adquirentes
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os V\u00C3\u00ADnculos dos estabelecimento com os adquirentes.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idAdquirente">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do adquirente (id). (optional)</param>
        /// <param name="idEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento. (optional)</param>
        /// <param name="codigoEstabelecimentoAdquirente">C\u00C3\u00B3digo do v\u00C3\u00ADnculo entre o estabelecimento e o adquirente. (optional)</param>
        /// <returns>Task of ApiResponse (PageVinculoEstabelecimentoAdquirenteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageVinculoEstabelecimentoAdquirenteResponse>> ListarUsingGET51AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idAdquirente = null, long? idEstabelecimento = null, string codigoEstabelecimentoAdquirente = null);
        
        /// <summary>
        /// Lista os v\u00C3\u00ADnculos cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os v\u00C3\u00ADnculos opera\u00C3\u00A7\u00C3\u00B5es existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="idOperacao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Opera\u00C3\u00A7\u00C3\u00A3o (id). (optional)</param>
        /// <param name="codigoMCC">C\u00C3\u00B3digo MCC. (optional)</param>
        /// <returns>Task of PageVinculoOperacaoResponse</returns>
        System.Threading.Tasks.Task<PageVinculoOperacaoResponse> ListarUsingGET52Async (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOperacao = null, int? codigoMCC = null);

        /// <summary>
        /// Lista os v\u00C3\u00ADnculos cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os v\u00C3\u00ADnculos opera\u00C3\u00A7\u00C3\u00B5es existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="idOperacao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Opera\u00C3\u00A7\u00C3\u00A3o (id). (optional)</param>
        /// <param name="codigoMCC">C\u00C3\u00B3digo MCC. (optional)</param>
        /// <returns>Task of ApiResponse (PageVinculoOperacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageVinculoOperacaoResponse>> ListarUsingGET52AsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOperacao = null, int? codigoMCC = null);
        
        /// <summary>
        /// Realiza o cadastro de uma nova maquineta para um estabelecimento 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrada uma nova maquineta para um estabelecimento.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maquinetaPersist">maquinetaPersist</param>
        /// <returns>Task of MaquinetaResponse</returns>
        System.Threading.Tasks.Task<MaquinetaResponse> SalvarUsingPOST16Async (MaquinetaPersist maquinetaPersist);

        /// <summary>
        /// Realiza o cadastro de uma nova maquineta para um estabelecimento 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrada uma nova maquineta para um estabelecimento.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maquinetaPersist">maquinetaPersist</param>
        /// <returns>Task of ApiResponse (MaquinetaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MaquinetaResponse>> SalvarUsingPOST16AsyncWithHttpInfo (MaquinetaPersist maquinetaPersist);
        
        /// <summary>
        /// Realiza o cadastro de uma nova Regra Opera\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrada uma nova Regra Opera\u00C3\u00A7\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oprecaoCredorPersist">oprecaoCredorPersist</param>
        /// <returns>Task of OperacaoCredorResponse</returns>
        System.Threading.Tasks.Task<OperacaoCredorResponse> SalvarUsingPOST17Async (OperacaoCredorPersist oprecaoCredorPersist);

        /// <summary>
        /// Realiza o cadastro de uma nova Regra Opera\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrada uma nova Regra Opera\u00C3\u00A7\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oprecaoCredorPersist">oprecaoCredorPersist</param>
        /// <returns>Task of ApiResponse (OperacaoCredorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperacaoCredorResponse>> SalvarUsingPOST17AsyncWithHttpInfo (OperacaoCredorPersist oprecaoCredorPersist);
        
        /// <summary>
        /// Realiza o cadastro de um novo telefone para um estabelecimento 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado um novo telefone para um estabelecimento.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento (id).</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id).</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone.</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <returns>Task of TelefoneEstabelecimentoResponse</returns>
        System.Threading.Tasks.Task<TelefoneEstabelecimentoResponse> SalvarUsingPOST22Async (long? idEstabelecimento, string ddd, string telefone, string ramal = null);

        /// <summary>
        /// Realiza o cadastro de um novo telefone para um estabelecimento 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado um novo telefone para um estabelecimento.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento (id).</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id).</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone.</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <returns>Task of ApiResponse (TelefoneEstabelecimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TelefoneEstabelecimentoResponse>> SalvarUsingPOST22AsyncWithHttpInfo (long? idEstabelecimento, string ddd, string telefone, string ramal = null);
        
        /// <summary>
        /// Realiza o cadastro de um novo Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado um novo Terminal.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminalPersist">terminalPersist</param>
        /// <returns>Task of TerminalResponse</returns>
        System.Threading.Tasks.Task<TerminalResponse> SalvarUsingPOST24Async (TerminalPersist terminalPersist);

        /// <summary>
        /// Realiza o cadastro de um novo Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado um novo Terminal.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminalPersist">terminalPersist</param>
        /// <returns>Task of ApiResponse (TerminalResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TerminalResponse>> SalvarUsingPOST24AsyncWithHttpInfo (TerminalPersist terminalPersist);
        
        /// <summary>
        /// Realiza o cadastro de um novo VinculoEstabelecimentoAdquirente
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado um novo VinculoEstabelecimentoAdquirente.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vinculoEstabelecimentoAdquirentePersist">vinculoEstabelecimentoAdquirentePersist</param>
        /// <returns>Task of VinculoEstabelecimentoAdquirenteResponse</returns>
        System.Threading.Tasks.Task<VinculoEstabelecimentoAdquirenteResponse> SalvarUsingPOST29Async (VinculoEstabelecimentoAdquirentePersist vinculoEstabelecimentoAdquirentePersist);

        /// <summary>
        /// Realiza o cadastro de um novo VinculoEstabelecimentoAdquirente
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado um novo VinculoEstabelecimentoAdquirente.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vinculoEstabelecimentoAdquirentePersist">vinculoEstabelecimentoAdquirentePersist</param>
        /// <returns>Task of ApiResponse (VinculoEstabelecimentoAdquirenteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<VinculoEstabelecimentoAdquirenteResponse>> SalvarUsingPOST29AsyncWithHttpInfo (VinculoEstabelecimentoAdquirentePersist vinculoEstabelecimentoAdquirentePersist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EstabelecimentoApi : IEstabelecimentoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EstabelecimentoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EstabelecimentoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EstabelecimentoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EstabelecimentoApi(Configuration configuration = null)
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
        /// Alterar Origem Comercial Altera uma origem comercial.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da origem comercial</param> 
        /// <param name="origemComercialUpdate">origemComercialUpdate</param> 
        /// <returns>OrigemComercialResponse</returns>
        public OrigemComercialResponse AlterarOrigemComercialUsingPUT (long? id, OrigemComercialUpdate origemComercialUpdate)
        {
             ApiResponse<OrigemComercialResponse> localVarResponse = AlterarOrigemComercialUsingPUTWithHttpInfo(id, origemComercialUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar Origem Comercial Altera uma origem comercial.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da origem comercial</param> 
        /// <param name="origemComercialUpdate">origemComercialUpdate</param> 
        /// <returns>ApiResponse of OrigemComercialResponse</returns>
        public ApiResponse< OrigemComercialResponse > AlterarOrigemComercialUsingPUTWithHttpInfo (long? id, OrigemComercialUpdate origemComercialUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->AlterarOrigemComercialUsingPUT");
            
            // verify the required parameter 'origemComercialUpdate' is set
            if (origemComercialUpdate == null)
                throw new ApiException(400, "Missing required parameter 'origemComercialUpdate' when calling EstabelecimentoApi->AlterarOrigemComercialUsingPUT");
            
    
            var localVarPath = "/api/origens-comerciais/{id}";
    
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
            
            
            
            
            if (origemComercialUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(origemComercialUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = origemComercialUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarOrigemComercialUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarOrigemComercialUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OrigemComercialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrigemComercialResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrigemComercialResponse)));
            
        }

        
        /// <summary>
        /// Alterar Origem Comercial Altera uma origem comercial.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da origem comercial</param>
        /// <param name="origemComercialUpdate">origemComercialUpdate</param>
        /// <returns>Task of OrigemComercialResponse</returns>
        public async System.Threading.Tasks.Task<OrigemComercialResponse> AlterarOrigemComercialUsingPUTAsync (long? id, OrigemComercialUpdate origemComercialUpdate)
        {
             ApiResponse<OrigemComercialResponse> localVarResponse = await AlterarOrigemComercialUsingPUTAsyncWithHttpInfo(id, origemComercialUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Alterar Origem Comercial Altera uma origem comercial.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da origem comercial</param>
        /// <param name="origemComercialUpdate">origemComercialUpdate</param>
        /// <returns>Task of ApiResponse (OrigemComercialResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrigemComercialResponse>> AlterarOrigemComercialUsingPUTAsyncWithHttpInfo (long? id, OrigemComercialUpdate origemComercialUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarOrigemComercialUsingPUT");
            // verify the required parameter 'origemComercialUpdate' is set
            if (origemComercialUpdate == null) throw new ApiException(400, "Missing required parameter 'origemComercialUpdate' when calling AlterarOrigemComercialUsingPUT");
            
    
            var localVarPath = "/api/origens-comerciais/{id}";
    
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
            
            
            
            
            if (origemComercialUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(origemComercialUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = origemComercialUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarOrigemComercialUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarOrigemComercialUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrigemComercialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrigemComercialResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrigemComercialResponse)));
            
        }
        
        /// <summary>
        /// Altera uma Maquineta Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o das maquinetas dos estabelecimentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Maquineta (id).</param> 
        /// <param name="maquinetaUpdate">maquinetaUpdate</param> 
        /// <returns>MaquinetaResponse</returns>
        public MaquinetaResponse AlterarUsingPUT10 (long? id, MaquinetaUpdate maquinetaUpdate)
        {
             ApiResponse<MaquinetaResponse> localVarResponse = AlterarUsingPUT10WithHttpInfo(id, maquinetaUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera uma Maquineta Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o das maquinetas dos estabelecimentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Maquineta (id).</param> 
        /// <param name="maquinetaUpdate">maquinetaUpdate</param> 
        /// <returns>ApiResponse of MaquinetaResponse</returns>
        public ApiResponse< MaquinetaResponse > AlterarUsingPUT10WithHttpInfo (long? id, MaquinetaUpdate maquinetaUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->AlterarUsingPUT10");
            
            // verify the required parameter 'maquinetaUpdate' is set
            if (maquinetaUpdate == null)
                throw new ApiException(400, "Missing required parameter 'maquinetaUpdate' when calling EstabelecimentoApi->AlterarUsingPUT10");
            
    
            var localVarPath = "/api/maquinetas/{id}";
    
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
            
            
            
            
            if (maquinetaUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(maquinetaUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = maquinetaUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT10: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT10: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<MaquinetaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MaquinetaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaquinetaResponse)));
            
        }

        
        /// <summary>
        /// Altera uma Maquineta Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o das maquinetas dos estabelecimentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Maquineta (id).</param>
        /// <param name="maquinetaUpdate">maquinetaUpdate</param>
        /// <returns>Task of MaquinetaResponse</returns>
        public async System.Threading.Tasks.Task<MaquinetaResponse> AlterarUsingPUT10Async (long? id, MaquinetaUpdate maquinetaUpdate)
        {
             ApiResponse<MaquinetaResponse> localVarResponse = await AlterarUsingPUT10AsyncWithHttpInfo(id, maquinetaUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera uma Maquineta Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o das maquinetas dos estabelecimentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Maquineta (id).</param>
        /// <param name="maquinetaUpdate">maquinetaUpdate</param>
        /// <returns>Task of ApiResponse (MaquinetaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MaquinetaResponse>> AlterarUsingPUT10AsyncWithHttpInfo (long? id, MaquinetaUpdate maquinetaUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT10");
            // verify the required parameter 'maquinetaUpdate' is set
            if (maquinetaUpdate == null) throw new ApiException(400, "Missing required parameter 'maquinetaUpdate' when calling AlterarUsingPUT10");
            
    
            var localVarPath = "/api/maquinetas/{id}";
    
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
            
            
            
            
            if (maquinetaUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(maquinetaUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = maquinetaUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT10: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT10: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MaquinetaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MaquinetaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaquinetaResponse)));
            
        }
        
        /// <summary>
        /// Altera uma Regra Opera\u00C3\u00A7\u00C3\u00A3o Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o de uma regra opera\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Regra Opera\u00C3\u00A7\u00C3\u00A3o (id).</param> 
        /// <param name="operacaoCredorUpdate">operacaoCredorUpdate</param> 
        /// <returns>OperacaoCredorResponse</returns>
        public OperacaoCredorResponse AlterarUsingPUT11 (long? id, OperacaoCredorUpdate operacaoCredorUpdate)
        {
             ApiResponse<OperacaoCredorResponse> localVarResponse = AlterarUsingPUT11WithHttpInfo(id, operacaoCredorUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera uma Regra Opera\u00C3\u00A7\u00C3\u00A3o Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o de uma regra opera\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Regra Opera\u00C3\u00A7\u00C3\u00A3o (id).</param> 
        /// <param name="operacaoCredorUpdate">operacaoCredorUpdate</param> 
        /// <returns>ApiResponse of OperacaoCredorResponse</returns>
        public ApiResponse< OperacaoCredorResponse > AlterarUsingPUT11WithHttpInfo (long? id, OperacaoCredorUpdate operacaoCredorUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->AlterarUsingPUT11");
            
            // verify the required parameter 'operacaoCredorUpdate' is set
            if (operacaoCredorUpdate == null)
                throw new ApiException(400, "Missing required parameter 'operacaoCredorUpdate' when calling EstabelecimentoApi->AlterarUsingPUT11");
            
    
            var localVarPath = "/api/regras-operacoes-estabelecimentos/{id}";
    
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
            
            
            
            
            if (operacaoCredorUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(operacaoCredorUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = operacaoCredorUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT11: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT11: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OperacaoCredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OperacaoCredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperacaoCredorResponse)));
            
        }

        
        /// <summary>
        /// Altera uma Regra Opera\u00C3\u00A7\u00C3\u00A3o Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o de uma regra opera\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Regra Opera\u00C3\u00A7\u00C3\u00A3o (id).</param>
        /// <param name="operacaoCredorUpdate">operacaoCredorUpdate</param>
        /// <returns>Task of OperacaoCredorResponse</returns>
        public async System.Threading.Tasks.Task<OperacaoCredorResponse> AlterarUsingPUT11Async (long? id, OperacaoCredorUpdate operacaoCredorUpdate)
        {
             ApiResponse<OperacaoCredorResponse> localVarResponse = await AlterarUsingPUT11AsyncWithHttpInfo(id, operacaoCredorUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera uma Regra Opera\u00C3\u00A7\u00C3\u00A3o Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o de uma regra opera\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Regra Opera\u00C3\u00A7\u00C3\u00A3o (id).</param>
        /// <param name="operacaoCredorUpdate">operacaoCredorUpdate</param>
        /// <returns>Task of ApiResponse (OperacaoCredorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OperacaoCredorResponse>> AlterarUsingPUT11AsyncWithHttpInfo (long? id, OperacaoCredorUpdate operacaoCredorUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT11");
            // verify the required parameter 'operacaoCredorUpdate' is set
            if (operacaoCredorUpdate == null) throw new ApiException(400, "Missing required parameter 'operacaoCredorUpdate' when calling AlterarUsingPUT11");
            
    
            var localVarPath = "/api/regras-operacoes-estabelecimentos/{id}";
    
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
            
            
            
            
            if (operacaoCredorUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(operacaoCredorUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = operacaoCredorUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT11: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT11: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OperacaoCredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OperacaoCredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperacaoCredorResponse)));
            
        }
        
        /// <summary>
        /// Altera um Telefone do estabelecimento Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos telefones dos estabelecimentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone Estabelecimento (id).</param> 
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id).</param> 
        /// <param name="telefone">N\u00C3\u00BAmero do telefone.</param> 
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param> 
        /// <returns>TelefoneEstabelecimentoResponse</returns>
        public TelefoneEstabelecimentoResponse AlterarUsingPUT15 (long? id, string ddd, string telefone, string ramal = null)
        {
             ApiResponse<TelefoneEstabelecimentoResponse> localVarResponse = AlterarUsingPUT15WithHttpInfo(id, ddd, telefone, ramal);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera um Telefone do estabelecimento Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos telefones dos estabelecimentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone Estabelecimento (id).</param> 
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id).</param> 
        /// <param name="telefone">N\u00C3\u00BAmero do telefone.</param> 
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param> 
        /// <returns>ApiResponse of TelefoneEstabelecimentoResponse</returns>
        public ApiResponse< TelefoneEstabelecimentoResponse > AlterarUsingPUT15WithHttpInfo (long? id, string ddd, string telefone, string ramal = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->AlterarUsingPUT15");
            
            // verify the required parameter 'ddd' is set
            if (ddd == null)
                throw new ApiException(400, "Missing required parameter 'ddd' when calling EstabelecimentoApi->AlterarUsingPUT15");
            
            // verify the required parameter 'telefone' is set
            if (telefone == null)
                throw new ApiException(400, "Missing required parameter 'telefone' when calling EstabelecimentoApi->AlterarUsingPUT15");
            
    
            var localVarPath = "/api/telefones-estabelecimentos/{id}";
    
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
            
            if (ddd != null) localVarQueryParams.Add("ddd", Configuration.ApiClient.ParameterToString(ddd)); // query parameter
            if (telefone != null) localVarQueryParams.Add("telefone", Configuration.ApiClient.ParameterToString(telefone)); // query parameter
            if (ramal != null) localVarQueryParams.Add("ramal", Configuration.ApiClient.ParameterToString(ramal)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT15: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT15: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TelefoneEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneEstabelecimentoResponse)));
            
        }

        
        /// <summary>
        /// Altera um Telefone do estabelecimento Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos telefones dos estabelecimentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone Estabelecimento (id).</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id).</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone.</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <returns>Task of TelefoneEstabelecimentoResponse</returns>
        public async System.Threading.Tasks.Task<TelefoneEstabelecimentoResponse> AlterarUsingPUT15Async (long? id, string ddd, string telefone, string ramal = null)
        {
             ApiResponse<TelefoneEstabelecimentoResponse> localVarResponse = await AlterarUsingPUT15AsyncWithHttpInfo(id, ddd, telefone, ramal);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera um Telefone do estabelecimento Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos telefones dos estabelecimentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone Estabelecimento (id).</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id).</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone.</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <returns>Task of ApiResponse (TelefoneEstabelecimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TelefoneEstabelecimentoResponse>> AlterarUsingPUT15AsyncWithHttpInfo (long? id, string ddd, string telefone, string ramal = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT15");
            // verify the required parameter 'ddd' is set
            if (ddd == null) throw new ApiException(400, "Missing required parameter 'ddd' when calling AlterarUsingPUT15");
            // verify the required parameter 'telefone' is set
            if (telefone == null) throw new ApiException(400, "Missing required parameter 'telefone' when calling AlterarUsingPUT15");
            
    
            var localVarPath = "/api/telefones-estabelecimentos/{id}";
    
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
            
            if (ddd != null) localVarQueryParams.Add("ddd", Configuration.ApiClient.ParameterToString(ddd)); // query parameter
            if (telefone != null) localVarQueryParams.Add("telefone", Configuration.ApiClient.ParameterToString(telefone)); // query parameter
            if (ramal != null) localVarQueryParams.Add("ramal", Configuration.ApiClient.ParameterToString(ramal)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT15: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT15: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TelefoneEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneEstabelecimentoResponse)));
            
        }
        
        /// <summary>
        /// Altera um Terminal Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos Terminais.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do terminal (id).</param> 
        /// <param name="terminalUpdate">terminalUpdate</param> 
        /// <returns>TerminalResponse</returns>
        public TerminalResponse AlterarUsingPUT17 (long? id, TerminalUpdate terminalUpdate)
        {
             ApiResponse<TerminalResponse> localVarResponse = AlterarUsingPUT17WithHttpInfo(id, terminalUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera um Terminal Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos Terminais.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do terminal (id).</param> 
        /// <param name="terminalUpdate">terminalUpdate</param> 
        /// <returns>ApiResponse of TerminalResponse</returns>
        public ApiResponse< TerminalResponse > AlterarUsingPUT17WithHttpInfo (long? id, TerminalUpdate terminalUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->AlterarUsingPUT17");
            
            // verify the required parameter 'terminalUpdate' is set
            if (terminalUpdate == null)
                throw new ApiException(400, "Missing required parameter 'terminalUpdate' when calling EstabelecimentoApi->AlterarUsingPUT17");
            
    
            var localVarPath = "/api/terminais/{id}";
    
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
            
            
            
            
            if (terminalUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(terminalUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = terminalUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT17: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT17: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TerminalResponse)));
            
        }

        
        /// <summary>
        /// Altera um Terminal Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos Terminais.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do terminal (id).</param>
        /// <param name="terminalUpdate">terminalUpdate</param>
        /// <returns>Task of TerminalResponse</returns>
        public async System.Threading.Tasks.Task<TerminalResponse> AlterarUsingPUT17Async (long? id, TerminalUpdate terminalUpdate)
        {
             ApiResponse<TerminalResponse> localVarResponse = await AlterarUsingPUT17AsyncWithHttpInfo(id, terminalUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera um Terminal Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos Terminais.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do terminal (id).</param>
        /// <param name="terminalUpdate">terminalUpdate</param>
        /// <returns>Task of ApiResponse (TerminalResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TerminalResponse>> AlterarUsingPUT17AsyncWithHttpInfo (long? id, TerminalUpdate terminalUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT17");
            // verify the required parameter 'terminalUpdate' is set
            if (terminalUpdate == null) throw new ApiException(400, "Missing required parameter 'terminalUpdate' when calling AlterarUsingPUT17");
            
    
            var localVarPath = "/api/terminais/{id}";
    
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
            
            
            
            
            if (terminalUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(terminalUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = terminalUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT17: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT17: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TerminalResponse)));
            
        }
        
        /// <summary>
        /// Alterar um estabelecimento Altera um estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <param name="update">update</param> 
        /// <returns>EstabelecimentoResponse</returns>
        public EstabelecimentoResponse AlterarUsingPUT6 (long? id, EstabelecimentoUpdate update)
        {
             ApiResponse<EstabelecimentoResponse> localVarResponse = AlterarUsingPUT6WithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar um estabelecimento Altera um estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of EstabelecimentoResponse</returns>
        public ApiResponse< EstabelecimentoResponse > AlterarUsingPUT6WithHttpInfo (long? id, EstabelecimentoUpdate update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->AlterarUsingPUT6");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling EstabelecimentoApi->AlterarUsingPUT6");
            
    
            var localVarPath = "/api/estabelecimentos/{id}";
    
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
            
            
            
            
            if (update.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(update); // http body (model) parameter
            }
            else
            {
                localVarPostBody = update; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstabelecimentoResponse)));
            
        }

        
        /// <summary>
        /// Alterar um estabelecimento Altera um estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="update">update</param>
        /// <returns>Task of EstabelecimentoResponse</returns>
        public async System.Threading.Tasks.Task<EstabelecimentoResponse> AlterarUsingPUT6Async (long? id, EstabelecimentoUpdate update)
        {
             ApiResponse<EstabelecimentoResponse> localVarResponse = await AlterarUsingPUT6AsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Alterar um estabelecimento Altera um estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (EstabelecimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EstabelecimentoResponse>> AlterarUsingPUT6AsyncWithHttpInfo (long? id, EstabelecimentoUpdate update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT6");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AlterarUsingPUT6");
            
    
            var localVarPath = "/api/estabelecimentos/{id}";
    
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
            
            
            
            
            if (update.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(update); // http body (model) parameter
            }
            else
            {
                localVarPostBody = update; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstabelecimentoResponse)));
            
        }
        
        /// <summary>
        /// Alterar Grupo Econ\u00C3\u00B4mico Altera um grupo econ\u00C3\u00B4mico.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do grupo econ\u00C3\u00B4mico</param> 
        /// <param name="grupoEconomicoDTO">grupoEconomicoDTO</param> 
        /// <returns>GrupoEconomicoResponse</returns>
        public GrupoEconomicoResponse AlterarUsingPUT8 (long? id, GrupoEconomicoDTO grupoEconomicoDTO)
        {
             ApiResponse<GrupoEconomicoResponse> localVarResponse = AlterarUsingPUT8WithHttpInfo(id, grupoEconomicoDTO);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar Grupo Econ\u00C3\u00B4mico Altera um grupo econ\u00C3\u00B4mico.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do grupo econ\u00C3\u00B4mico</param> 
        /// <param name="grupoEconomicoDTO">grupoEconomicoDTO</param> 
        /// <returns>ApiResponse of GrupoEconomicoResponse</returns>
        public ApiResponse< GrupoEconomicoResponse > AlterarUsingPUT8WithHttpInfo (long? id, GrupoEconomicoDTO grupoEconomicoDTO)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->AlterarUsingPUT8");
            
            // verify the required parameter 'grupoEconomicoDTO' is set
            if (grupoEconomicoDTO == null)
                throw new ApiException(400, "Missing required parameter 'grupoEconomicoDTO' when calling EstabelecimentoApi->AlterarUsingPUT8");
            
    
            var localVarPath = "/api/grupos-economicos/{id}";
    
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
            
            
            
            
            if (grupoEconomicoDTO.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(grupoEconomicoDTO); // http body (model) parameter
            }
            else
            {
                localVarPostBody = grupoEconomicoDTO; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT8: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT8: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<GrupoEconomicoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GrupoEconomicoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GrupoEconomicoResponse)));
            
        }

        
        /// <summary>
        /// Alterar Grupo Econ\u00C3\u00B4mico Altera um grupo econ\u00C3\u00B4mico.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do grupo econ\u00C3\u00B4mico</param>
        /// <param name="grupoEconomicoDTO">grupoEconomicoDTO</param>
        /// <returns>Task of GrupoEconomicoResponse</returns>
        public async System.Threading.Tasks.Task<GrupoEconomicoResponse> AlterarUsingPUT8Async (long? id, GrupoEconomicoDTO grupoEconomicoDTO)
        {
             ApiResponse<GrupoEconomicoResponse> localVarResponse = await AlterarUsingPUT8AsyncWithHttpInfo(id, grupoEconomicoDTO);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Alterar Grupo Econ\u00C3\u00B4mico Altera um grupo econ\u00C3\u00B4mico.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do grupo econ\u00C3\u00B4mico</param>
        /// <param name="grupoEconomicoDTO">grupoEconomicoDTO</param>
        /// <returns>Task of ApiResponse (GrupoEconomicoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GrupoEconomicoResponse>> AlterarUsingPUT8AsyncWithHttpInfo (long? id, GrupoEconomicoDTO grupoEconomicoDTO)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT8");
            // verify the required parameter 'grupoEconomicoDTO' is set
            if (grupoEconomicoDTO == null) throw new ApiException(400, "Missing required parameter 'grupoEconomicoDTO' when calling AlterarUsingPUT8");
            
    
            var localVarPath = "/api/grupos-economicos/{id}";
    
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
            
            
            
            
            if (grupoEconomicoDTO.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(grupoEconomicoDTO); // http body (model) parameter
            }
            else
            {
                localVarPostBody = grupoEconomicoDTO; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT8: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT8: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GrupoEconomicoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GrupoEconomicoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GrupoEconomicoResponse)));
            
        }
        
        /// <summary>
        /// Cadastrar Origem Comercial Cadastra uma origem comercial.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origemComercialPersist">origemComercialPersist</param> 
        /// <returns>OrigemComercialResponse</returns>
        public OrigemComercialResponse CadastrarOrigemComercialUsingPOST (OrigemComercialPersist origemComercialPersist)
        {
             ApiResponse<OrigemComercialResponse> localVarResponse = CadastrarOrigemComercialUsingPOSTWithHttpInfo(origemComercialPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastrar Origem Comercial Cadastra uma origem comercial.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origemComercialPersist">origemComercialPersist</param> 
        /// <returns>ApiResponse of OrigemComercialResponse</returns>
        public ApiResponse< OrigemComercialResponse > CadastrarOrigemComercialUsingPOSTWithHttpInfo (OrigemComercialPersist origemComercialPersist)
        {
            
            // verify the required parameter 'origemComercialPersist' is set
            if (origemComercialPersist == null)
                throw new ApiException(400, "Missing required parameter 'origemComercialPersist' when calling EstabelecimentoApi->CadastrarOrigemComercialUsingPOST");
            
    
            var localVarPath = "/api/origens-comerciais";
    
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
            
            
            
            
            if (origemComercialPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(origemComercialPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = origemComercialPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarOrigemComercialUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarOrigemComercialUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OrigemComercialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrigemComercialResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrigemComercialResponse)));
            
        }

        
        /// <summary>
        /// Cadastrar Origem Comercial Cadastra uma origem comercial.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origemComercialPersist">origemComercialPersist</param>
        /// <returns>Task of OrigemComercialResponse</returns>
        public async System.Threading.Tasks.Task<OrigemComercialResponse> CadastrarOrigemComercialUsingPOSTAsync (OrigemComercialPersist origemComercialPersist)
        {
             ApiResponse<OrigemComercialResponse> localVarResponse = await CadastrarOrigemComercialUsingPOSTAsyncWithHttpInfo(origemComercialPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastrar Origem Comercial Cadastra uma origem comercial.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origemComercialPersist">origemComercialPersist</param>
        /// <returns>Task of ApiResponse (OrigemComercialResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrigemComercialResponse>> CadastrarOrigemComercialUsingPOSTAsyncWithHttpInfo (OrigemComercialPersist origemComercialPersist)
        {
            // verify the required parameter 'origemComercialPersist' is set
            if (origemComercialPersist == null) throw new ApiException(400, "Missing required parameter 'origemComercialPersist' when calling CadastrarOrigemComercialUsingPOST");
            
    
            var localVarPath = "/api/origens-comerciais";
    
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
            
            
            
            
            if (origemComercialPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(origemComercialPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = origemComercialPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarOrigemComercialUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarOrigemComercialUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrigemComercialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrigemComercialResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrigemComercialResponse)));
            
        }
        
        /// <summary>
        /// Cadastrar um estabelecimento Cadastra um novo estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>EstabelecimentoResponse</returns>
        public EstabelecimentoResponse CadastrarUsingPOST2 (EstabelecimentoPersist persist)
        {
             ApiResponse<EstabelecimentoResponse> localVarResponse = CadastrarUsingPOST2WithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastrar um estabelecimento Cadastra um novo estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of EstabelecimentoResponse</returns>
        public ApiResponse< EstabelecimentoResponse > CadastrarUsingPOST2WithHttpInfo (EstabelecimentoPersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling EstabelecimentoApi->CadastrarUsingPOST2");
            
    
            var localVarPath = "/api/estabelecimentos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstabelecimentoResponse)));
            
        }

        
        /// <summary>
        /// Cadastrar um estabelecimento Cadastra um novo estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of EstabelecimentoResponse</returns>
        public async System.Threading.Tasks.Task<EstabelecimentoResponse> CadastrarUsingPOST2Async (EstabelecimentoPersist persist)
        {
             ApiResponse<EstabelecimentoResponse> localVarResponse = await CadastrarUsingPOST2AsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastrar um estabelecimento Cadastra um novo estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (EstabelecimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EstabelecimentoResponse>> CadastrarUsingPOST2AsyncWithHttpInfo (EstabelecimentoPersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling CadastrarUsingPOST2");
            
    
            var localVarPath = "/api/estabelecimentos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstabelecimentoResponse)));
            
        }
        
        /// <summary>
        /// Cadastrar Grupo Econ\u00C3\u00B4mico Cadastra um grupo econ\u00C3\u00B4mico.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoEconomicoDTO">GrupoEconomicoDTO</param> 
        /// <returns>GrupoEconomicoResponse</returns>
        public GrupoEconomicoResponse CadastrarUsingPOST3 (GrupoEconomicoDTO grupoEconomicoDTO)
        {
             ApiResponse<GrupoEconomicoResponse> localVarResponse = CadastrarUsingPOST3WithHttpInfo(grupoEconomicoDTO);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastrar Grupo Econ\u00C3\u00B4mico Cadastra um grupo econ\u00C3\u00B4mico.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoEconomicoDTO">GrupoEconomicoDTO</param> 
        /// <returns>ApiResponse of GrupoEconomicoResponse</returns>
        public ApiResponse< GrupoEconomicoResponse > CadastrarUsingPOST3WithHttpInfo (GrupoEconomicoDTO grupoEconomicoDTO)
        {
            
            // verify the required parameter 'grupoEconomicoDTO' is set
            if (grupoEconomicoDTO == null)
                throw new ApiException(400, "Missing required parameter 'grupoEconomicoDTO' when calling EstabelecimentoApi->CadastrarUsingPOST3");
            
    
            var localVarPath = "/api/grupos-economicos";
    
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
            
            
            
            
            if (grupoEconomicoDTO.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(grupoEconomicoDTO); // http body (model) parameter
            }
            else
            {
                localVarPostBody = grupoEconomicoDTO; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<GrupoEconomicoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GrupoEconomicoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GrupoEconomicoResponse)));
            
        }

        
        /// <summary>
        /// Cadastrar Grupo Econ\u00C3\u00B4mico Cadastra um grupo econ\u00C3\u00B4mico.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoEconomicoDTO">GrupoEconomicoDTO</param>
        /// <returns>Task of GrupoEconomicoResponse</returns>
        public async System.Threading.Tasks.Task<GrupoEconomicoResponse> CadastrarUsingPOST3Async (GrupoEconomicoDTO grupoEconomicoDTO)
        {
             ApiResponse<GrupoEconomicoResponse> localVarResponse = await CadastrarUsingPOST3AsyncWithHttpInfo(grupoEconomicoDTO);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastrar Grupo Econ\u00C3\u00B4mico Cadastra um grupo econ\u00C3\u00B4mico.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoEconomicoDTO">GrupoEconomicoDTO</param>
        /// <returns>Task of ApiResponse (GrupoEconomicoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GrupoEconomicoResponse>> CadastrarUsingPOST3AsyncWithHttpInfo (GrupoEconomicoDTO grupoEconomicoDTO)
        {
            // verify the required parameter 'grupoEconomicoDTO' is set
            if (grupoEconomicoDTO == null) throw new ApiException(400, "Missing required parameter 'grupoEconomicoDTO' when calling CadastrarUsingPOST3");
            
    
            var localVarPath = "/api/grupos-economicos";
    
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
            
            
            
            
            if (grupoEconomicoDTO.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(grupoEconomicoDTO); // http body (model) parameter
            }
            else
            {
                localVarPostBody = grupoEconomicoDTO; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GrupoEconomicoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GrupoEconomicoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GrupoEconomicoResponse)));
            
        }
        
        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00C3\u00A7\u00C3\u00A3o Este recurso permite consultar dados de um determinado tipo opera\u00C3\u00A7\u00C3\u00A3o a partir do idoperacao
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de processamento da opera\u00C3\u00A7\u00C3\u00A3o (idOperacao).</param> 
        /// <returns>DetalheOperacaoResponse</returns>
        public DetalheOperacaoResponse ConsultaOperacaoUsingGET (long? id)
        {
             ApiResponse<DetalheOperacaoResponse> localVarResponse = ConsultaOperacaoUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00C3\u00A7\u00C3\u00A3o Este recurso permite consultar dados de um determinado tipo opera\u00C3\u00A7\u00C3\u00A3o a partir do idoperacao
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de processamento da opera\u00C3\u00A7\u00C3\u00A3o (idOperacao).</param> 
        /// <returns>ApiResponse of DetalheOperacaoResponse</returns>
        public ApiResponse< DetalheOperacaoResponse > ConsultaOperacaoUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->ConsultaOperacaoUsingGET");
            
    
            var localVarPath = "/api/tipos-operacoes-estabelecimentos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultaOperacaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultaOperacaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DetalheOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DetalheOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DetalheOperacaoResponse)));
            
        }

        
        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00C3\u00A7\u00C3\u00A3o Este recurso permite consultar dados de um determinado tipo opera\u00C3\u00A7\u00C3\u00A3o a partir do idoperacao
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de processamento da opera\u00C3\u00A7\u00C3\u00A3o (idOperacao).</param>
        /// <returns>Task of DetalheOperacaoResponse</returns>
        public async System.Threading.Tasks.Task<DetalheOperacaoResponse> ConsultaOperacaoUsingGETAsync (long? id)
        {
             ApiResponse<DetalheOperacaoResponse> localVarResponse = await ConsultaOperacaoUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00C3\u00A7\u00C3\u00A3o Este recurso permite consultar dados de um determinado tipo opera\u00C3\u00A7\u00C3\u00A3o a partir do idoperacao
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de processamento da opera\u00C3\u00A7\u00C3\u00A3o (idOperacao).</param>
        /// <returns>Task of ApiResponse (DetalheOperacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DetalheOperacaoResponse>> ConsultaOperacaoUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultaOperacaoUsingGET");
            
    
            var localVarPath = "/api/tipos-operacoes-estabelecimentos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultaOperacaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultaOperacaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DetalheOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DetalheOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DetalheOperacaoResponse)));
            
        }
        
        /// <summary>
        /// Consultar Origem Comercial Consulta uma origem comercial atrav\u00C3\u00A9s do seu identificador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da origem comercial</param> 
        /// <returns>OrigemComercialResponse</returns>
        public OrigemComercialResponse ConsultarOrigemComercialUsingGET (long? id)
        {
             ApiResponse<OrigemComercialResponse> localVarResponse = ConsultarOrigemComercialUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar Origem Comercial Consulta uma origem comercial atrav\u00C3\u00A9s do seu identificador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da origem comercial</param> 
        /// <returns>ApiResponse of OrigemComercialResponse</returns>
        public ApiResponse< OrigemComercialResponse > ConsultarOrigemComercialUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->ConsultarOrigemComercialUsingGET");
            
    
            var localVarPath = "/api/origens-comerciais/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarOrigemComercialUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarOrigemComercialUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OrigemComercialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrigemComercialResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrigemComercialResponse)));
            
        }

        
        /// <summary>
        /// Consultar Origem Comercial Consulta uma origem comercial atrav\u00C3\u00A9s do seu identificador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da origem comercial</param>
        /// <returns>Task of OrigemComercialResponse</returns>
        public async System.Threading.Tasks.Task<OrigemComercialResponse> ConsultarOrigemComercialUsingGETAsync (long? id)
        {
             ApiResponse<OrigemComercialResponse> localVarResponse = await ConsultarOrigemComercialUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar Origem Comercial Consulta uma origem comercial atrav\u00C3\u00A9s do seu identificador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da origem comercial</param>
        /// <returns>Task of ApiResponse (OrigemComercialResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrigemComercialResponse>> ConsultarOrigemComercialUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarOrigemComercialUsingGET");
            
    
            var localVarPath = "/api/origens-comerciais/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarOrigemComercialUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarOrigemComercialUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrigemComercialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrigemComercialResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrigemComercialResponse)));
            
        }
        
        /// <summary>
        /// Consultar estabelecimento por id Consulta os detalhes de um determinado estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <returns>EstabelecimentoResponse</returns>
        public EstabelecimentoResponse ConsultarUsingGET16 (long? id)
        {
             ApiResponse<EstabelecimentoResponse> localVarResponse = ConsultarUsingGET16WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar estabelecimento por id Consulta os detalhes de um determinado estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <returns>ApiResponse of EstabelecimentoResponse</returns>
        public ApiResponse< EstabelecimentoResponse > ConsultarUsingGET16WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->ConsultarUsingGET16");
            
    
            var localVarPath = "/api/estabelecimentos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET16: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET16: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstabelecimentoResponse)));
            
        }

        
        /// <summary>
        /// Consultar estabelecimento por id Consulta os detalhes de um determinado estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of EstabelecimentoResponse</returns>
        public async System.Threading.Tasks.Task<EstabelecimentoResponse> ConsultarUsingGET16Async (long? id)
        {
             ApiResponse<EstabelecimentoResponse> localVarResponse = await ConsultarUsingGET16AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar estabelecimento por id Consulta os detalhes de um determinado estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (EstabelecimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EstabelecimentoResponse>> ConsultarUsingGET16AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET16");
            
    
            var localVarPath = "/api/estabelecimentos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET16: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET16: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstabelecimentoResponse)));
            
        }
        
        /// <summary>
        /// Consultar grupo econ\u00C3\u00B4mico Consulta um grupo econ\u00C3\u00B4mico atrav\u00C3\u00A9s do seu identificador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do grupo econ\u00C3\u00B4mico</param> 
        /// <returns>GrupoEconomicoResponse</returns>
        public GrupoEconomicoResponse ConsultarUsingGET18 (long? id)
        {
             ApiResponse<GrupoEconomicoResponse> localVarResponse = ConsultarUsingGET18WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar grupo econ\u00C3\u00B4mico Consulta um grupo econ\u00C3\u00B4mico atrav\u00C3\u00A9s do seu identificador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do grupo econ\u00C3\u00B4mico</param> 
        /// <returns>ApiResponse of GrupoEconomicoResponse</returns>
        public ApiResponse< GrupoEconomicoResponse > ConsultarUsingGET18WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->ConsultarUsingGET18");
            
    
            var localVarPath = "/api/grupos-economicos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET18: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET18: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<GrupoEconomicoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GrupoEconomicoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GrupoEconomicoResponse)));
            
        }

        
        /// <summary>
        /// Consultar grupo econ\u00C3\u00B4mico Consulta um grupo econ\u00C3\u00B4mico atrav\u00C3\u00A9s do seu identificador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do grupo econ\u00C3\u00B4mico</param>
        /// <returns>Task of GrupoEconomicoResponse</returns>
        public async System.Threading.Tasks.Task<GrupoEconomicoResponse> ConsultarUsingGET18Async (long? id)
        {
             ApiResponse<GrupoEconomicoResponse> localVarResponse = await ConsultarUsingGET18AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar grupo econ\u00C3\u00B4mico Consulta um grupo econ\u00C3\u00B4mico atrav\u00C3\u00A9s do seu identificador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do grupo econ\u00C3\u00B4mico</param>
        /// <returns>Task of ApiResponse (GrupoEconomicoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GrupoEconomicoResponse>> ConsultarUsingGET18AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET18");
            
    
            var localVarPath = "/api/grupos-economicos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET18: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET18: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GrupoEconomicoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GrupoEconomicoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GrupoEconomicoResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de uma determinada maquineta Este m\u00C3\u00A9todo permite consultar uma determinada maquineta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Maquineta (id).</param> 
        /// <returns>MaquinetaResponse</returns>
        public MaquinetaResponse ConsultarUsingGET20 (long? id)
        {
             ApiResponse<MaquinetaResponse> localVarResponse = ConsultarUsingGET20WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de uma determinada maquineta Este m\u00C3\u00A9todo permite consultar uma determinada maquineta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Maquineta (id).</param> 
        /// <returns>ApiResponse of MaquinetaResponse</returns>
        public ApiResponse< MaquinetaResponse > ConsultarUsingGET20WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->ConsultarUsingGET20");
            
    
            var localVarPath = "/api/maquinetas/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET20: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET20: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<MaquinetaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MaquinetaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaquinetaResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de uma determinada maquineta Este m\u00C3\u00A9todo permite consultar uma determinada maquineta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Maquineta (id).</param>
        /// <returns>Task of MaquinetaResponse</returns>
        public async System.Threading.Tasks.Task<MaquinetaResponse> ConsultarUsingGET20Async (long? id)
        {
             ApiResponse<MaquinetaResponse> localVarResponse = await ConsultarUsingGET20AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de uma determinada maquineta Este m\u00C3\u00A9todo permite consultar uma determinada maquineta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Maquineta (id).</param>
        /// <returns>Task of ApiResponse (MaquinetaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MaquinetaResponse>> ConsultarUsingGET20AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET20");
            
    
            var localVarPath = "/api/maquinetas/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET20: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET20: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MaquinetaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MaquinetaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaquinetaResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de uma determinada Regra Opera\u00C3\u00A7\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar uma determinada regra opera\u00C3\u00A7\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Regra Opera\u00C3\u00A7\u00C3\u00A3o (id).</param> 
        /// <returns>OperacaoCredorResponse</returns>
        public OperacaoCredorResponse ConsultarUsingGET21 (long? id)
        {
             ApiResponse<OperacaoCredorResponse> localVarResponse = ConsultarUsingGET21WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de uma determinada Regra Opera\u00C3\u00A7\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar uma determinada regra opera\u00C3\u00A7\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Regra Opera\u00C3\u00A7\u00C3\u00A3o (id).</param> 
        /// <returns>ApiResponse of OperacaoCredorResponse</returns>
        public ApiResponse< OperacaoCredorResponse > ConsultarUsingGET21WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->ConsultarUsingGET21");
            
    
            var localVarPath = "/api/regras-operacoes-estabelecimentos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET21: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET21: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OperacaoCredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OperacaoCredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperacaoCredorResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de uma determinada Regra Opera\u00C3\u00A7\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar uma determinada regra opera\u00C3\u00A7\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Regra Opera\u00C3\u00A7\u00C3\u00A3o (id).</param>
        /// <returns>Task of OperacaoCredorResponse</returns>
        public async System.Threading.Tasks.Task<OperacaoCredorResponse> ConsultarUsingGET21Async (long? id)
        {
             ApiResponse<OperacaoCredorResponse> localVarResponse = await ConsultarUsingGET21AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de uma determinada Regra Opera\u00C3\u00A7\u00C3\u00A3o Este m\u00C3\u00A9todo permite consultar uma determinada regra opera\u00C3\u00A7\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Regra Opera\u00C3\u00A7\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (OperacaoCredorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OperacaoCredorResponse>> ConsultarUsingGET21AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET21");
            
    
            var localVarPath = "/api/regras-operacoes-estabelecimentos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET21: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET21: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OperacaoCredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OperacaoCredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperacaoCredorResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado telefone de um estabelecimento Este m\u00C3\u00A9todo permite consultar um determinado telefone de um estabelecimento a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone Estabelecimento (id).</param> 
        /// <returns>TelefoneEstabelecimentoResponse</returns>
        public TelefoneEstabelecimentoResponse ConsultarUsingGET29 (long? id)
        {
             ApiResponse<TelefoneEstabelecimentoResponse> localVarResponse = ConsultarUsingGET29WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado telefone de um estabelecimento Este m\u00C3\u00A9todo permite consultar um determinado telefone de um estabelecimento a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone Estabelecimento (id).</param> 
        /// <returns>ApiResponse of TelefoneEstabelecimentoResponse</returns>
        public ApiResponse< TelefoneEstabelecimentoResponse > ConsultarUsingGET29WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->ConsultarUsingGET29");
            
    
            var localVarPath = "/api/telefones-estabelecimentos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET29: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET29: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TelefoneEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneEstabelecimentoResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado telefone de um estabelecimento Este m\u00C3\u00A9todo permite consultar um determinado telefone de um estabelecimento a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone Estabelecimento (id).</param>
        /// <returns>Task of TelefoneEstabelecimentoResponse</returns>
        public async System.Threading.Tasks.Task<TelefoneEstabelecimentoResponse> ConsultarUsingGET29Async (long? id)
        {
             ApiResponse<TelefoneEstabelecimentoResponse> localVarResponse = await ConsultarUsingGET29AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado telefone de um estabelecimento Este m\u00C3\u00A9todo permite consultar um determinado telefone de um estabelecimento a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone Estabelecimento (id).</param>
        /// <returns>Task of ApiResponse (TelefoneEstabelecimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TelefoneEstabelecimentoResponse>> ConsultarUsingGET29AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET29");
            
    
            var localVarPath = "/api/telefones-estabelecimentos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET29: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET29: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TelefoneEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneEstabelecimentoResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado Terminal Este m\u00C3\u00A9todo permite consultar um determinado Terminal a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id).</param> 
        /// <returns>TerminalResponse</returns>
        public TerminalResponse ConsultarUsingGET31 (long? id)
        {
             ApiResponse<TerminalResponse> localVarResponse = ConsultarUsingGET31WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Terminal Este m\u00C3\u00A9todo permite consultar um determinado Terminal a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id).</param> 
        /// <returns>ApiResponse of TerminalResponse</returns>
        public ApiResponse< TerminalResponse > ConsultarUsingGET31WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->ConsultarUsingGET31");
            
    
            var localVarPath = "/api/terminais/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET31: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET31: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TerminalResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Terminal Este m\u00C3\u00A9todo permite consultar um determinado Terminal a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id).</param>
        /// <returns>Task of TerminalResponse</returns>
        public async System.Threading.Tasks.Task<TerminalResponse> ConsultarUsingGET31Async (long? id)
        {
             ApiResponse<TerminalResponse> localVarResponse = await ConsultarUsingGET31AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Terminal Este m\u00C3\u00A9todo permite consultar um determinado Terminal a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id).</param>
        /// <returns>Task of ApiResponse (TerminalResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TerminalResponse>> ConsultarUsingGET31AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET31");
            
    
            var localVarPath = "/api/terminais/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET31: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET31: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TerminalResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado V\u00C3\u00ADnculo Este m\u00C3\u00A9todo permite consultar um determinado V\u00C3\u00ADnculo a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do V\u00C3\u008Dnculo (id).</param> 
        /// <returns>VinculoEstabelecimentoAdquirenteResponse</returns>
        public VinculoEstabelecimentoAdquirenteResponse ConsultarUsingGET43 (long? id)
        {
             ApiResponse<VinculoEstabelecimentoAdquirenteResponse> localVarResponse = ConsultarUsingGET43WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado V\u00C3\u00ADnculo Este m\u00C3\u00A9todo permite consultar um determinado V\u00C3\u00ADnculo a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do V\u00C3\u008Dnculo (id).</param> 
        /// <returns>ApiResponse of VinculoEstabelecimentoAdquirenteResponse</returns>
        public ApiResponse< VinculoEstabelecimentoAdquirenteResponse > ConsultarUsingGET43WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->ConsultarUsingGET43");
            
    
            var localVarPath = "/api/adquirentes-estabelecimento/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET43: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET43: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<VinculoEstabelecimentoAdquirenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VinculoEstabelecimentoAdquirenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VinculoEstabelecimentoAdquirenteResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado V\u00C3\u00ADnculo Este m\u00C3\u00A9todo permite consultar um determinado V\u00C3\u00ADnculo a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do V\u00C3\u008Dnculo (id).</param>
        /// <returns>Task of VinculoEstabelecimentoAdquirenteResponse</returns>
        public async System.Threading.Tasks.Task<VinculoEstabelecimentoAdquirenteResponse> ConsultarUsingGET43Async (long? id)
        {
             ApiResponse<VinculoEstabelecimentoAdquirenteResponse> localVarResponse = await ConsultarUsingGET43AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado V\u00C3\u00ADnculo Este m\u00C3\u00A9todo permite consultar um determinado V\u00C3\u00ADnculo a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do V\u00C3\u008Dnculo (id).</param>
        /// <returns>Task of ApiResponse (VinculoEstabelecimentoAdquirenteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VinculoEstabelecimentoAdquirenteResponse>> ConsultarUsingGET43AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET43");
            
    
            var localVarPath = "/api/adquirentes-estabelecimento/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET43: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET43: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VinculoEstabelecimentoAdquirenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VinculoEstabelecimentoAdquirenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VinculoEstabelecimentoAdquirenteResponse)));
            
        }
        
        /// <summary>
        /// Desabilitar um V\u00C3\u00ADnculo Este m\u00C3\u00A9todo realiza a desativa\u00C3\u00A7\u00C3\u00A3o de um v\u00C3\u00ADnculo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do V\u00C3\u00ADnculo (id).</param> 
        /// <returns>Object</returns>
        public Object DesabilitarVinculoUsingPOST (long? id)
        {
             ApiResponse<Object> localVarResponse = DesabilitarVinculoUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Desabilitar um V\u00C3\u00ADnculo Este m\u00C3\u00A9todo realiza a desativa\u00C3\u00A7\u00C3\u00A3o de um v\u00C3\u00ADnculo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do V\u00C3\u00ADnculo (id).</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > DesabilitarVinculoUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->DesabilitarVinculoUsingPOST");
            
    
            var localVarPath = "/api/adquirentes-estabelecimento/{id}/desabilitar";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesabilitarVinculoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesabilitarVinculoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Desabilitar um V\u00C3\u00ADnculo Este m\u00C3\u00A9todo realiza a desativa\u00C3\u00A7\u00C3\u00A3o de um v\u00C3\u00ADnculo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do V\u00C3\u00ADnculo (id).</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> DesabilitarVinculoUsingPOSTAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await DesabilitarVinculoUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Desabilitar um V\u00C3\u00ADnculo Este m\u00C3\u00A9todo realiza a desativa\u00C3\u00A7\u00C3\u00A3o de um v\u00C3\u00ADnculo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do V\u00C3\u00ADnculo (id).</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DesabilitarVinculoUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesabilitarVinculoUsingPOST");
            
    
            var localVarPath = "/api/adquirentes-estabelecimento/{id}/desabilitar";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesabilitarVinculoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesabilitarVinculoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Desabilitar um v\u00C3\u00ADnculo opera\u00C3\u00A7\u00C3\u00A3o Este m\u00C3\u00A9todo permite desabilitar um v\u00C3\u00ADnculo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id).</param> 
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param> 
        /// <returns>Object</returns>
        public Object DesabilitarVinculoUsingPOST1 (long? id, VinculoOperacaoPersist vinculoOperacaoPersist)
        {
             ApiResponse<Object> localVarResponse = DesabilitarVinculoUsingPOST1WithHttpInfo(id, vinculoOperacaoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Desabilitar um v\u00C3\u00ADnculo opera\u00C3\u00A7\u00C3\u00A3o Este m\u00C3\u00A9todo permite desabilitar um v\u00C3\u00ADnculo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id).</param> 
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > DesabilitarVinculoUsingPOST1WithHttpInfo (long? id, VinculoOperacaoPersist vinculoOperacaoPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->DesabilitarVinculoUsingPOST1");
            
            // verify the required parameter 'vinculoOperacaoPersist' is set
            if (vinculoOperacaoPersist == null)
                throw new ApiException(400, "Missing required parameter 'vinculoOperacaoPersist' when calling EstabelecimentoApi->DesabilitarVinculoUsingPOST1");
            
    
            var localVarPath = "/api/estabelecimentos/{id}/desabilitar-operacao";
    
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
            
            
            
            
            if (vinculoOperacaoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(vinculoOperacaoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = vinculoOperacaoPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesabilitarVinculoUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesabilitarVinculoUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Desabilitar um v\u00C3\u00ADnculo opera\u00C3\u00A7\u00C3\u00A3o Este m\u00C3\u00A9todo permite desabilitar um v\u00C3\u00ADnculo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id).</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> DesabilitarVinculoUsingPOST1Async (long? id, VinculoOperacaoPersist vinculoOperacaoPersist)
        {
             ApiResponse<Object> localVarResponse = await DesabilitarVinculoUsingPOST1AsyncWithHttpInfo(id, vinculoOperacaoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Desabilitar um v\u00C3\u00ADnculo opera\u00C3\u00A7\u00C3\u00A3o Este m\u00C3\u00A9todo permite desabilitar um v\u00C3\u00ADnculo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id).</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DesabilitarVinculoUsingPOST1AsyncWithHttpInfo (long? id, VinculoOperacaoPersist vinculoOperacaoPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesabilitarVinculoUsingPOST1");
            // verify the required parameter 'vinculoOperacaoPersist' is set
            if (vinculoOperacaoPersist == null) throw new ApiException(400, "Missing required parameter 'vinculoOperacaoPersist' when calling DesabilitarVinculoUsingPOST1");
            
    
            var localVarPath = "/api/estabelecimentos/{id}/desabilitar-operacao";
    
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
            
            
            
            
            if (vinculoOperacaoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(vinculoOperacaoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = vinculoOperacaoPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesabilitarVinculoUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesabilitarVinculoUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Habilitar um V\u00C3\u00ADnculo Este m\u00C3\u00A9todo realiza a ativa\u00C3\u00A7\u00C3\u00A3o de um v\u00C3\u00ADnculo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do V\u00C3\u00ADnculo (id).</param> 
        /// <returns>Object</returns>
        public Object HabilitarVinculoUsingPOST (long? id)
        {
             ApiResponse<Object> localVarResponse = HabilitarVinculoUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Habilitar um V\u00C3\u00ADnculo Este m\u00C3\u00A9todo realiza a ativa\u00C3\u00A7\u00C3\u00A3o de um v\u00C3\u00ADnculo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do V\u00C3\u00ADnculo (id).</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > HabilitarVinculoUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->HabilitarVinculoUsingPOST");
            
    
            var localVarPath = "/api/adquirentes-estabelecimento/{id}/habilitar";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling HabilitarVinculoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling HabilitarVinculoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Habilitar um V\u00C3\u00ADnculo Este m\u00C3\u00A9todo realiza a ativa\u00C3\u00A7\u00C3\u00A3o de um v\u00C3\u00ADnculo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do V\u00C3\u00ADnculo (id).</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> HabilitarVinculoUsingPOSTAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await HabilitarVinculoUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Habilitar um V\u00C3\u00ADnculo Este m\u00C3\u00A9todo realiza a ativa\u00C3\u00A7\u00C3\u00A3o de um v\u00C3\u00ADnculo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do V\u00C3\u00ADnculo (id).</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> HabilitarVinculoUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling HabilitarVinculoUsingPOST");
            
    
            var localVarPath = "/api/adquirentes-estabelecimento/{id}/habilitar";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling HabilitarVinculoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling HabilitarVinculoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Habilitar um v\u00C3\u00ADnculo opera\u00C3\u00A7\u00C3\u00A3o Este m\u00C3\u00A9todo permite habilitar um v\u00C3\u00ADnculo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id).</param> 
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param> 
        /// <returns>Object</returns>
        public Object HabilitarVinculoUsingPOST1 (long? id, VinculoOperacaoPersist vinculoOperacaoPersist)
        {
             ApiResponse<Object> localVarResponse = HabilitarVinculoUsingPOST1WithHttpInfo(id, vinculoOperacaoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Habilitar um v\u00C3\u00ADnculo opera\u00C3\u00A7\u00C3\u00A3o Este m\u00C3\u00A9todo permite habilitar um v\u00C3\u00ADnculo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id).</param> 
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > HabilitarVinculoUsingPOST1WithHttpInfo (long? id, VinculoOperacaoPersist vinculoOperacaoPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->HabilitarVinculoUsingPOST1");
            
            // verify the required parameter 'vinculoOperacaoPersist' is set
            if (vinculoOperacaoPersist == null)
                throw new ApiException(400, "Missing required parameter 'vinculoOperacaoPersist' when calling EstabelecimentoApi->HabilitarVinculoUsingPOST1");
            
    
            var localVarPath = "/api/estabelecimentos/{id}/habilitar-operacao";
    
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
            
            
            
            
            if (vinculoOperacaoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(vinculoOperacaoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = vinculoOperacaoPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling HabilitarVinculoUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling HabilitarVinculoUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Habilitar um v\u00C3\u00ADnculo opera\u00C3\u00A7\u00C3\u00A3o Este m\u00C3\u00A9todo permite habilitar um v\u00C3\u00ADnculo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id).</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> HabilitarVinculoUsingPOST1Async (long? id, VinculoOperacaoPersist vinculoOperacaoPersist)
        {
             ApiResponse<Object> localVarResponse = await HabilitarVinculoUsingPOST1AsyncWithHttpInfo(id, vinculoOperacaoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Habilitar um v\u00C3\u00ADnculo opera\u00C3\u00A7\u00C3\u00A3o Este m\u00C3\u00A9todo permite habilitar um v\u00C3\u00ADnculo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id).</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> HabilitarVinculoUsingPOST1AsyncWithHttpInfo (long? id, VinculoOperacaoPersist vinculoOperacaoPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling HabilitarVinculoUsingPOST1");
            // verify the required parameter 'vinculoOperacaoPersist' is set
            if (vinculoOperacaoPersist == null) throw new ApiException(400, "Missing required parameter 'vinculoOperacaoPersist' when calling HabilitarVinculoUsingPOST1");
            
    
            var localVarPath = "/api/estabelecimentos/{id}/habilitar-operacao";
    
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
            
            
            
            
            if (vinculoOperacaoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(vinculoOperacaoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = vinculoOperacaoPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling HabilitarVinculoUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling HabilitarVinculoUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Apresenta dados de opera\u00C3\u00A7\u00C3\u00B5es em uma lista Este recurso permite listar as opera\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idOperacao">C\u00C3\u00B3digo que identifica a opera\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <param name="codigoProcessamento">C\u00C3\u00B3digo de processamento usado em transa\u00C3\u00A7\u00C3\u00B5es com o autorizador (optional)</param> 
        /// <returns>PageOperacaoResponse</returns>
        public PageOperacaoResponse ListaOperacaoUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, string codigoProcessamento = null)
        {
             ApiResponse<PageOperacaoResponse> localVarResponse = ListaOperacaoUsingGETWithHttpInfo(sort, page, limit, idOperacao, codigoProcessamento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta dados de opera\u00C3\u00A7\u00C3\u00B5es em uma lista Este recurso permite listar as opera\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idOperacao">C\u00C3\u00B3digo que identifica a opera\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <param name="codigoProcessamento">C\u00C3\u00B3digo de processamento usado em transa\u00C3\u00A7\u00C3\u00B5es com o autorizador (optional)</param> 
        /// <returns>ApiResponse of PageOperacaoResponse</returns>
        public ApiResponse< PageOperacaoResponse > ListaOperacaoUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, string codigoProcessamento = null)
        {
            
    
            var localVarPath = "/api/tipos-operacoes-estabelecimentos";
    
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
            if (idOperacao != null) localVarQueryParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // query parameter
            if (codigoProcessamento != null) localVarQueryParams.Add("codigoProcessamento", Configuration.ApiClient.ParameterToString(codigoProcessamento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListaOperacaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListaOperacaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOperacaoResponse)));
            
        }

        
        /// <summary>
        /// Apresenta dados de opera\u00C3\u00A7\u00C3\u00B5es em uma lista Este recurso permite listar as opera\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idOperacao">C\u00C3\u00B3digo que identifica a opera\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="codigoProcessamento">C\u00C3\u00B3digo de processamento usado em transa\u00C3\u00A7\u00C3\u00B5es com o autorizador (optional)</param>
        /// <returns>Task of PageOperacaoResponse</returns>
        public async System.Threading.Tasks.Task<PageOperacaoResponse> ListaOperacaoUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, string codigoProcessamento = null)
        {
             ApiResponse<PageOperacaoResponse> localVarResponse = await ListaOperacaoUsingGETAsyncWithHttpInfo(sort, page, limit, idOperacao, codigoProcessamento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta dados de opera\u00C3\u00A7\u00C3\u00B5es em uma lista Este recurso permite listar as opera\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idOperacao">C\u00C3\u00B3digo que identifica a opera\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="codigoProcessamento">C\u00C3\u00B3digo de processamento usado em transa\u00C3\u00A7\u00C3\u00B5es com o autorizador (optional)</param>
        /// <returns>Task of ApiResponse (PageOperacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageOperacaoResponse>> ListaOperacaoUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, string codigoProcessamento = null)
        {
            
    
            var localVarPath = "/api/tipos-operacoes-estabelecimentos";
    
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
            if (idOperacao != null) localVarQueryParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // query parameter
            if (codigoProcessamento != null) localVarQueryParams.Add("codigoProcessamento", Configuration.ApiClient.ParameterToString(codigoProcessamento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListaOperacaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListaOperacaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOperacaoResponse)));
            
        }
        
        /// <summary>
        /// Lista os MCCs Este m\u00C3\u00A9todo permite que sejam listados os MCCs existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageMCCResponse</returns>
        public PageMCCResponse ListarMCCUsingGET (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageMCCResponse> localVarResponse = ListarMCCUsingGETWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os MCCs Este m\u00C3\u00A9todo permite que sejam listados os MCCs existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageMCCResponse</returns>
        public ApiResponse< PageMCCResponse > ListarMCCUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/mcc-estabelecimentos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarMCCUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarMCCUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageMCCResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageMCCResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageMCCResponse)));
            
        }

        
        /// <summary>
        /// Lista os MCCs Este m\u00C3\u00A9todo permite que sejam listados os MCCs existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageMCCResponse</returns>
        public async System.Threading.Tasks.Task<PageMCCResponse> ListarMCCUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageMCCResponse> localVarResponse = await ListarMCCUsingGETAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os MCCs Este m\u00C3\u00A9todo permite que sejam listados os MCCs existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageMCCResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageMCCResponse>> ListarMCCUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/mcc-estabelecimentos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarMCCUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarMCCUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageMCCResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageMCCResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageMCCResponse)));
            
        }
        
        /// <summary>
        /// Listar Origens Comerciais Lista origens comerciais cadastradas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">Id da origem comercial (optional)</param> 
        /// <param name="nome">Nome da origem comercial (optional)</param> 
        /// <param name="status">Indica o status da origem comercial (optional)</param> 
        /// <param name="idEstabelecimento">Identificador do estabelecimento (optional)</param> 
        /// <param name="idProduto">Identificador do produto (optional)</param> 
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o da origem comercial (optional)</param> 
        /// <param name="idTipoOrigemComercial">Identificador do tipo de origem comercial (optional)</param> 
        /// <param name="idGrupoOrigemComercial">Identificador do grupo de origem comercial (optional)</param> 
        /// <param name="flagPreAprovado">Indica se permite pr\u00C3\u00A9 aprova\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <param name="flagAprovacaoImediata">Indica se permite aprova\u00C3\u00A7\u00C3\u00A3o imediata (optional)</param> 
        /// <param name="nomeFantasiaPlastico">Nome fantasia impresso no pl\u00C3\u00A1stico (optional)</param> 
        /// <param name="flagCartaoProvisorio">Indica se permite cart\u00C3\u00A3o provis\u00C3\u00B3rio (optional)</param> 
        /// <param name="flagCartaoDefinitivo">Indica se permite cart\u00C3\u00A3o definitivo (optional)</param> 
        /// <param name="usuario">Usu\u00C3\u00A1rio para autentica\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <param name="senha">Senha para autentica\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <param name="flagOrigemExterna">Indica se \u00C3\u00A9 origem externa (optional)</param> 
        /// <param name="flagModificado">Indica se h\u00C3\u00A1 modifica\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <param name="flagEnviaFaturaUsuario">Indica se envia fatura (optional)</param> 
        /// <param name="flagCreditoFaturamento">Indica se permite cr\u00C3\u00A9dito de faturamento (optional)</param> 
        /// <param name="flagConcedeLimiteProvisorio">Indica se concede limite provis\u00C3\u00B3rio (optional)</param> 
        /// <param name="flagDigitalizarDoc">Indica se digitaliza documento (optional)</param> 
        /// <param name="flagEmbossingLoja">Indica se realiza embossing em loja (optional)</param> 
        /// <param name="flagConsultaPrevia">Indica se realiza consulta pr\u00C3\u00A9via (optional)</param> 
        /// <param name="tipoPessoa">Tipo de pessoa (optional)</param> 
        /// <returns>PageOrigemComercialResponse</returns>
        public PageOrigemComercialResponse ListarOrigensComerciaisUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null, long? idEstabelecimento = null, long? idProduto = null, string descricao = null, long? idTipoOrigemComercial = null, long? idGrupoOrigemComercial = null, bool? flagPreAprovado = null, bool? flagAprovacaoImediata = null, string nomeFantasiaPlastico = null, bool? flagCartaoProvisorio = null, bool? flagCartaoDefinitivo = null, string usuario = null, string senha = null, bool? flagOrigemExterna = null, bool? flagModificado = null, bool? flagEnviaFaturaUsuario = null, bool? flagCreditoFaturamento = null, bool? flagConcedeLimiteProvisorio = null, bool? flagDigitalizarDoc = null, bool? flagEmbossingLoja = null, bool? flagConsultaPrevia = null, string tipoPessoa = null)
        {
             ApiResponse<PageOrigemComercialResponse> localVarResponse = ListarOrigensComerciaisUsingGETWithHttpInfo(sort, page, limit, id, nome, status, idEstabelecimento, idProduto, descricao, idTipoOrigemComercial, idGrupoOrigemComercial, flagPreAprovado, flagAprovacaoImediata, nomeFantasiaPlastico, flagCartaoProvisorio, flagCartaoDefinitivo, usuario, senha, flagOrigemExterna, flagModificado, flagEnviaFaturaUsuario, flagCreditoFaturamento, flagConcedeLimiteProvisorio, flagDigitalizarDoc, flagEmbossingLoja, flagConsultaPrevia, tipoPessoa);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar Origens Comerciais Lista origens comerciais cadastradas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">Id da origem comercial (optional)</param> 
        /// <param name="nome">Nome da origem comercial (optional)</param> 
        /// <param name="status">Indica o status da origem comercial (optional)</param> 
        /// <param name="idEstabelecimento">Identificador do estabelecimento (optional)</param> 
        /// <param name="idProduto">Identificador do produto (optional)</param> 
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o da origem comercial (optional)</param> 
        /// <param name="idTipoOrigemComercial">Identificador do tipo de origem comercial (optional)</param> 
        /// <param name="idGrupoOrigemComercial">Identificador do grupo de origem comercial (optional)</param> 
        /// <param name="flagPreAprovado">Indica se permite pr\u00C3\u00A9 aprova\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <param name="flagAprovacaoImediata">Indica se permite aprova\u00C3\u00A7\u00C3\u00A3o imediata (optional)</param> 
        /// <param name="nomeFantasiaPlastico">Nome fantasia impresso no pl\u00C3\u00A1stico (optional)</param> 
        /// <param name="flagCartaoProvisorio">Indica se permite cart\u00C3\u00A3o provis\u00C3\u00B3rio (optional)</param> 
        /// <param name="flagCartaoDefinitivo">Indica se permite cart\u00C3\u00A3o definitivo (optional)</param> 
        /// <param name="usuario">Usu\u00C3\u00A1rio para autentica\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <param name="senha">Senha para autentica\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <param name="flagOrigemExterna">Indica se \u00C3\u00A9 origem externa (optional)</param> 
        /// <param name="flagModificado">Indica se h\u00C3\u00A1 modifica\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <param name="flagEnviaFaturaUsuario">Indica se envia fatura (optional)</param> 
        /// <param name="flagCreditoFaturamento">Indica se permite cr\u00C3\u00A9dito de faturamento (optional)</param> 
        /// <param name="flagConcedeLimiteProvisorio">Indica se concede limite provis\u00C3\u00B3rio (optional)</param> 
        /// <param name="flagDigitalizarDoc">Indica se digitaliza documento (optional)</param> 
        /// <param name="flagEmbossingLoja">Indica se realiza embossing em loja (optional)</param> 
        /// <param name="flagConsultaPrevia">Indica se realiza consulta pr\u00C3\u00A9via (optional)</param> 
        /// <param name="tipoPessoa">Tipo de pessoa (optional)</param> 
        /// <returns>ApiResponse of PageOrigemComercialResponse</returns>
        public ApiResponse< PageOrigemComercialResponse > ListarOrigensComerciaisUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null, long? idEstabelecimento = null, long? idProduto = null, string descricao = null, long? idTipoOrigemComercial = null, long? idGrupoOrigemComercial = null, bool? flagPreAprovado = null, bool? flagAprovacaoImediata = null, string nomeFantasiaPlastico = null, bool? flagCartaoProvisorio = null, bool? flagCartaoDefinitivo = null, string usuario = null, string senha = null, bool? flagOrigemExterna = null, bool? flagModificado = null, bool? flagEnviaFaturaUsuario = null, bool? flagCreditoFaturamento = null, bool? flagConcedeLimiteProvisorio = null, bool? flagDigitalizarDoc = null, bool? flagEmbossingLoja = null, bool? flagConsultaPrevia = null, string tipoPessoa = null)
        {
            
    
            var localVarPath = "/api/origens-comerciais";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (idTipoOrigemComercial != null) localVarQueryParams.Add("idTipoOrigemComercial", Configuration.ApiClient.ParameterToString(idTipoOrigemComercial)); // query parameter
            if (idGrupoOrigemComercial != null) localVarQueryParams.Add("idGrupoOrigemComercial", Configuration.ApiClient.ParameterToString(idGrupoOrigemComercial)); // query parameter
            if (flagPreAprovado != null) localVarQueryParams.Add("flagPreAprovado", Configuration.ApiClient.ParameterToString(flagPreAprovado)); // query parameter
            if (flagAprovacaoImediata != null) localVarQueryParams.Add("flagAprovacaoImediata", Configuration.ApiClient.ParameterToString(flagAprovacaoImediata)); // query parameter
            if (nomeFantasiaPlastico != null) localVarQueryParams.Add("nomeFantasiaPlastico", Configuration.ApiClient.ParameterToString(nomeFantasiaPlastico)); // query parameter
            if (flagCartaoProvisorio != null) localVarQueryParams.Add("flagCartaoProvisorio", Configuration.ApiClient.ParameterToString(flagCartaoProvisorio)); // query parameter
            if (flagCartaoDefinitivo != null) localVarQueryParams.Add("flagCartaoDefinitivo", Configuration.ApiClient.ParameterToString(flagCartaoDefinitivo)); // query parameter
            if (usuario != null) localVarQueryParams.Add("usuario", Configuration.ApiClient.ParameterToString(usuario)); // query parameter
            if (senha != null) localVarQueryParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // query parameter
            if (flagOrigemExterna != null) localVarQueryParams.Add("flagOrigemExterna", Configuration.ApiClient.ParameterToString(flagOrigemExterna)); // query parameter
            if (flagModificado != null) localVarQueryParams.Add("flagModificado", Configuration.ApiClient.ParameterToString(flagModificado)); // query parameter
            if (flagEnviaFaturaUsuario != null) localVarQueryParams.Add("flagEnviaFaturaUsuario", Configuration.ApiClient.ParameterToString(flagEnviaFaturaUsuario)); // query parameter
            if (flagCreditoFaturamento != null) localVarQueryParams.Add("flagCreditoFaturamento", Configuration.ApiClient.ParameterToString(flagCreditoFaturamento)); // query parameter
            if (flagConcedeLimiteProvisorio != null) localVarQueryParams.Add("flagConcedeLimiteProvisorio", Configuration.ApiClient.ParameterToString(flagConcedeLimiteProvisorio)); // query parameter
            if (flagDigitalizarDoc != null) localVarQueryParams.Add("flagDigitalizarDoc", Configuration.ApiClient.ParameterToString(flagDigitalizarDoc)); // query parameter
            if (flagEmbossingLoja != null) localVarQueryParams.Add("flagEmbossingLoja", Configuration.ApiClient.ParameterToString(flagEmbossingLoja)); // query parameter
            if (flagConsultaPrevia != null) localVarQueryParams.Add("flagConsultaPrevia", Configuration.ApiClient.ParameterToString(flagConsultaPrevia)); // query parameter
            if (tipoPessoa != null) localVarQueryParams.Add("tipoPessoa", Configuration.ApiClient.ParameterToString(tipoPessoa)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarOrigensComerciaisUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarOrigensComerciaisUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageOrigemComercialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOrigemComercialResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOrigemComercialResponse)));
            
        }

        
        /// <summary>
        /// Listar Origens Comerciais Lista origens comerciais cadastradas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Id da origem comercial (optional)</param>
        /// <param name="nome">Nome da origem comercial (optional)</param>
        /// <param name="status">Indica o status da origem comercial (optional)</param>
        /// <param name="idEstabelecimento">Identificador do estabelecimento (optional)</param>
        /// <param name="idProduto">Identificador do produto (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o da origem comercial (optional)</param>
        /// <param name="idTipoOrigemComercial">Identificador do tipo de origem comercial (optional)</param>
        /// <param name="idGrupoOrigemComercial">Identificador do grupo de origem comercial (optional)</param>
        /// <param name="flagPreAprovado">Indica se permite pr\u00C3\u00A9 aprova\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="flagAprovacaoImediata">Indica se permite aprova\u00C3\u00A7\u00C3\u00A3o imediata (optional)</param>
        /// <param name="nomeFantasiaPlastico">Nome fantasia impresso no pl\u00C3\u00A1stico (optional)</param>
        /// <param name="flagCartaoProvisorio">Indica se permite cart\u00C3\u00A3o provis\u00C3\u00B3rio (optional)</param>
        /// <param name="flagCartaoDefinitivo">Indica se permite cart\u00C3\u00A3o definitivo (optional)</param>
        /// <param name="usuario">Usu\u00C3\u00A1rio para autentica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="senha">Senha para autentica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="flagOrigemExterna">Indica se \u00C3\u00A9 origem externa (optional)</param>
        /// <param name="flagModificado">Indica se h\u00C3\u00A1 modifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="flagEnviaFaturaUsuario">Indica se envia fatura (optional)</param>
        /// <param name="flagCreditoFaturamento">Indica se permite cr\u00C3\u00A9dito de faturamento (optional)</param>
        /// <param name="flagConcedeLimiteProvisorio">Indica se concede limite provis\u00C3\u00B3rio (optional)</param>
        /// <param name="flagDigitalizarDoc">Indica se digitaliza documento (optional)</param>
        /// <param name="flagEmbossingLoja">Indica se realiza embossing em loja (optional)</param>
        /// <param name="flagConsultaPrevia">Indica se realiza consulta pr\u00C3\u00A9via (optional)</param>
        /// <param name="tipoPessoa">Tipo de pessoa (optional)</param>
        /// <returns>Task of PageOrigemComercialResponse</returns>
        public async System.Threading.Tasks.Task<PageOrigemComercialResponse> ListarOrigensComerciaisUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null, long? idEstabelecimento = null, long? idProduto = null, string descricao = null, long? idTipoOrigemComercial = null, long? idGrupoOrigemComercial = null, bool? flagPreAprovado = null, bool? flagAprovacaoImediata = null, string nomeFantasiaPlastico = null, bool? flagCartaoProvisorio = null, bool? flagCartaoDefinitivo = null, string usuario = null, string senha = null, bool? flagOrigemExterna = null, bool? flagModificado = null, bool? flagEnviaFaturaUsuario = null, bool? flagCreditoFaturamento = null, bool? flagConcedeLimiteProvisorio = null, bool? flagDigitalizarDoc = null, bool? flagEmbossingLoja = null, bool? flagConsultaPrevia = null, string tipoPessoa = null)
        {
             ApiResponse<PageOrigemComercialResponse> localVarResponse = await ListarOrigensComerciaisUsingGETAsyncWithHttpInfo(sort, page, limit, id, nome, status, idEstabelecimento, idProduto, descricao, idTipoOrigemComercial, idGrupoOrigemComercial, flagPreAprovado, flagAprovacaoImediata, nomeFantasiaPlastico, flagCartaoProvisorio, flagCartaoDefinitivo, usuario, senha, flagOrigemExterna, flagModificado, flagEnviaFaturaUsuario, flagCreditoFaturamento, flagConcedeLimiteProvisorio, flagDigitalizarDoc, flagEmbossingLoja, flagConsultaPrevia, tipoPessoa);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar Origens Comerciais Lista origens comerciais cadastradas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Id da origem comercial (optional)</param>
        /// <param name="nome">Nome da origem comercial (optional)</param>
        /// <param name="status">Indica o status da origem comercial (optional)</param>
        /// <param name="idEstabelecimento">Identificador do estabelecimento (optional)</param>
        /// <param name="idProduto">Identificador do produto (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o da origem comercial (optional)</param>
        /// <param name="idTipoOrigemComercial">Identificador do tipo de origem comercial (optional)</param>
        /// <param name="idGrupoOrigemComercial">Identificador do grupo de origem comercial (optional)</param>
        /// <param name="flagPreAprovado">Indica se permite pr\u00C3\u00A9 aprova\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="flagAprovacaoImediata">Indica se permite aprova\u00C3\u00A7\u00C3\u00A3o imediata (optional)</param>
        /// <param name="nomeFantasiaPlastico">Nome fantasia impresso no pl\u00C3\u00A1stico (optional)</param>
        /// <param name="flagCartaoProvisorio">Indica se permite cart\u00C3\u00A3o provis\u00C3\u00B3rio (optional)</param>
        /// <param name="flagCartaoDefinitivo">Indica se permite cart\u00C3\u00A3o definitivo (optional)</param>
        /// <param name="usuario">Usu\u00C3\u00A1rio para autentica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="senha">Senha para autentica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="flagOrigemExterna">Indica se \u00C3\u00A9 origem externa (optional)</param>
        /// <param name="flagModificado">Indica se h\u00C3\u00A1 modifica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="flagEnviaFaturaUsuario">Indica se envia fatura (optional)</param>
        /// <param name="flagCreditoFaturamento">Indica se permite cr\u00C3\u00A9dito de faturamento (optional)</param>
        /// <param name="flagConcedeLimiteProvisorio">Indica se concede limite provis\u00C3\u00B3rio (optional)</param>
        /// <param name="flagDigitalizarDoc">Indica se digitaliza documento (optional)</param>
        /// <param name="flagEmbossingLoja">Indica se realiza embossing em loja (optional)</param>
        /// <param name="flagConsultaPrevia">Indica se realiza consulta pr\u00C3\u00A9via (optional)</param>
        /// <param name="tipoPessoa">Tipo de pessoa (optional)</param>
        /// <returns>Task of ApiResponse (PageOrigemComercialResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageOrigemComercialResponse>> ListarOrigensComerciaisUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null, long? idEstabelecimento = null, long? idProduto = null, string descricao = null, long? idTipoOrigemComercial = null, long? idGrupoOrigemComercial = null, bool? flagPreAprovado = null, bool? flagAprovacaoImediata = null, string nomeFantasiaPlastico = null, bool? flagCartaoProvisorio = null, bool? flagCartaoDefinitivo = null, string usuario = null, string senha = null, bool? flagOrigemExterna = null, bool? flagModificado = null, bool? flagEnviaFaturaUsuario = null, bool? flagCreditoFaturamento = null, bool? flagConcedeLimiteProvisorio = null, bool? flagDigitalizarDoc = null, bool? flagEmbossingLoja = null, bool? flagConsultaPrevia = null, string tipoPessoa = null)
        {
            
    
            var localVarPath = "/api/origens-comerciais";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (idTipoOrigemComercial != null) localVarQueryParams.Add("idTipoOrigemComercial", Configuration.ApiClient.ParameterToString(idTipoOrigemComercial)); // query parameter
            if (idGrupoOrigemComercial != null) localVarQueryParams.Add("idGrupoOrigemComercial", Configuration.ApiClient.ParameterToString(idGrupoOrigemComercial)); // query parameter
            if (flagPreAprovado != null) localVarQueryParams.Add("flagPreAprovado", Configuration.ApiClient.ParameterToString(flagPreAprovado)); // query parameter
            if (flagAprovacaoImediata != null) localVarQueryParams.Add("flagAprovacaoImediata", Configuration.ApiClient.ParameterToString(flagAprovacaoImediata)); // query parameter
            if (nomeFantasiaPlastico != null) localVarQueryParams.Add("nomeFantasiaPlastico", Configuration.ApiClient.ParameterToString(nomeFantasiaPlastico)); // query parameter
            if (flagCartaoProvisorio != null) localVarQueryParams.Add("flagCartaoProvisorio", Configuration.ApiClient.ParameterToString(flagCartaoProvisorio)); // query parameter
            if (flagCartaoDefinitivo != null) localVarQueryParams.Add("flagCartaoDefinitivo", Configuration.ApiClient.ParameterToString(flagCartaoDefinitivo)); // query parameter
            if (usuario != null) localVarQueryParams.Add("usuario", Configuration.ApiClient.ParameterToString(usuario)); // query parameter
            if (senha != null) localVarQueryParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // query parameter
            if (flagOrigemExterna != null) localVarQueryParams.Add("flagOrigemExterna", Configuration.ApiClient.ParameterToString(flagOrigemExterna)); // query parameter
            if (flagModificado != null) localVarQueryParams.Add("flagModificado", Configuration.ApiClient.ParameterToString(flagModificado)); // query parameter
            if (flagEnviaFaturaUsuario != null) localVarQueryParams.Add("flagEnviaFaturaUsuario", Configuration.ApiClient.ParameterToString(flagEnviaFaturaUsuario)); // query parameter
            if (flagCreditoFaturamento != null) localVarQueryParams.Add("flagCreditoFaturamento", Configuration.ApiClient.ParameterToString(flagCreditoFaturamento)); // query parameter
            if (flagConcedeLimiteProvisorio != null) localVarQueryParams.Add("flagConcedeLimiteProvisorio", Configuration.ApiClient.ParameterToString(flagConcedeLimiteProvisorio)); // query parameter
            if (flagDigitalizarDoc != null) localVarQueryParams.Add("flagDigitalizarDoc", Configuration.ApiClient.ParameterToString(flagDigitalizarDoc)); // query parameter
            if (flagEmbossingLoja != null) localVarQueryParams.Add("flagEmbossingLoja", Configuration.ApiClient.ParameterToString(flagEmbossingLoja)); // query parameter
            if (flagConsultaPrevia != null) localVarQueryParams.Add("flagConsultaPrevia", Configuration.ApiClient.ParameterToString(flagConsultaPrevia)); // query parameter
            if (tipoPessoa != null) localVarQueryParams.Add("tipoPessoa", Configuration.ApiClient.ParameterToString(tipoPessoa)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarOrigensComerciaisUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarOrigensComerciaisUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageOrigemComercialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOrigemComercialResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOrigemComercialResponse)));
            
        }
        
        /// <summary>
        /// Lista os Tipos de adquirentes Este m\u00C3\u00A9todo permite que sejam listados os tipos de adquirentes.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageEntidadeResponse</returns>
        public PageEntidadeResponse ListarTiposAdquirentesUsingGET (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageEntidadeResponse> localVarResponse = ListarTiposAdquirentesUsingGETWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Tipos de adquirentes Este m\u00C3\u00A9todo permite que sejam listados os tipos de adquirentes.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageEntidadeResponse</returns>
        public ApiResponse< PageEntidadeResponse > ListarTiposAdquirentesUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/tipos-adquirentes";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposAdquirentesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposAdquirentesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageEntidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEntidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEntidadeResponse)));
            
        }

        
        /// <summary>
        /// Lista os Tipos de adquirentes Este m\u00C3\u00A9todo permite que sejam listados os tipos de adquirentes.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageEntidadeResponse</returns>
        public async System.Threading.Tasks.Task<PageEntidadeResponse> ListarTiposAdquirentesUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageEntidadeResponse> localVarResponse = await ListarTiposAdquirentesUsingGETAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Tipos de adquirentes Este m\u00C3\u00A9todo permite que sejam listados os tipos de adquirentes.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageEntidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageEntidadeResponse>> ListarTiposAdquirentesUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/tipos-adquirentes";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposAdquirentesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposAdquirentesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageEntidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEntidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEntidadeResponse)));
            
        }
        
        /// <summary>
        /// Lista os Tipos de  Maquinetas Este m\u00C3\u00A9todo permite que sejam listadas os Tipos de maquinetas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        public PageCampoCodificadoDescricaoResponse ListarTiposMaquinetasUsingGET (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = ListarTiposMaquinetasUsingGETWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Tipos de  Maquinetas Este m\u00C3\u00A9todo permite que sejam listadas os Tipos de maquinetas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        public ApiResponse< PageCampoCodificadoDescricaoResponse > ListarTiposMaquinetasUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/tipos-maquinetas";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposMaquinetasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposMaquinetasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCampoCodificadoDescricaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCampoCodificadoDescricaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCampoCodificadoDescricaoResponse)));
            
        }

        
        /// <summary>
        /// Lista os Tipos de  Maquinetas Este m\u00C3\u00A9todo permite que sejam listadas os Tipos de maquinetas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        public async System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarTiposMaquinetasUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = await ListarTiposMaquinetasUsingGETAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Tipos de  Maquinetas Este m\u00C3\u00A9todo permite que sejam listadas os Tipos de maquinetas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarTiposMaquinetasUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/tipos-maquinetas";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposMaquinetasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposMaquinetasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCampoCodificadoDescricaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCampoCodificadoDescricaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCampoCodificadoDescricaoResponse)));
            
        }
        
        /// <summary>
        /// Lista os Tipos Terminais Este m\u00C3\u00A9todo permite que sejam listados os tipos de terminais existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageTipoTerminalResponse</returns>
        public PageTipoTerminalResponse ListarTiposTerminaisUsingGET1 (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTipoTerminalResponse> localVarResponse = ListarTiposTerminaisUsingGET1WithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Tipos Terminais Este m\u00C3\u00A9todo permite que sejam listados os tipos de terminais existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageTipoTerminalResponse</returns>
        public ApiResponse< PageTipoTerminalResponse > ListarTiposTerminaisUsingGET1WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/tipos-terminais-estabelecimento";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposTerminaisUsingGET1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposTerminaisUsingGET1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoTerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoTerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoTerminalResponse)));
            
        }

        
        /// <summary>
        /// Lista os Tipos Terminais Este m\u00C3\u00A9todo permite que sejam listados os tipos de terminais existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageTipoTerminalResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoTerminalResponse> ListarTiposTerminaisUsingGET1Async (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTipoTerminalResponse> localVarResponse = await ListarTiposTerminaisUsingGET1AsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Tipos Terminais Este m\u00C3\u00A9todo permite que sejam listados os tipos de terminais existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoTerminalResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoTerminalResponse>> ListarTiposTerminaisUsingGET1AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/tipos-terminais-estabelecimento";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposTerminaisUsingGET1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposTerminaisUsingGET1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoTerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoTerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoTerminalResponse)));
            
        }
        
        /// <summary>
        /// Lista Estabelecimentos Lista todas os Estabelecimentos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id). (optional)</param> 
        /// <param name="idCredor">Apresenta o n\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Credor. (optional)</param> 
        /// <param name="numeroReceitaFederal">Apresenta o n\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento na Receita Federal. (optional)</param> 
        /// <param name="nome">Nome do Estabelecimento. (optional)</param> 
        /// <param name="descricao">Raz\u00C3\u00A3o Social do Estabelecimento. (optional)</param> 
        /// <param name="nomeFantasia">T\u00C3\u00ADtulo Comercial do Estabelecimento. (optional)</param> 
        /// <param name="cep">C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP). (optional)</param> 
        /// <param name="nomeLogradouro">Nome do Logradouro. (optional)</param> 
        /// <param name="numeroEndereco">N\u00C3\u00BAmero do endere\u00C3\u00A7o. (optional)</param> 
        /// <param name="complemento">Descri\u00C3\u00A7\u00C3\u00B5es complementares referente ao endere\u00C3\u00A7o. (optional)</param> 
        /// <param name="bairro">Nome do bairro do endere\u00C3\u00A7o. (optional)</param> 
        /// <param name="cidade">Nome da cidade do endere\u00C3\u00A7o. (optional)</param> 
        /// <param name="uf">Sigla de identifica\u00C3\u00A7\u00C3\u00A3o da Unidade Federativa do endere\u00C3\u00A7o. (optional)</param> 
        /// <param name="pais">Nome do pa\u00C3\u00ADs. (optional)</param> 
        /// <param name="dataCadastramento">Data de Cadastro do Estabelecimento, no formato yyyy-MM-dd. (optional)</param> 
        /// <param name="contato">Nome da pessoa para contato com o Estabelecimento. (optional)</param> 
        /// <param name="email">E-mail da pessoa para contato com o Estabelecimento. (optional)</param> 
        /// <param name="flagArquivoSecrFazenda">Indica se o estabelecimento ser\u00C3\u00A1 inclu\u00C3\u00ADdo no arquivo de registro para a Secretaria da Fazenda Estadual. (optional)</param> 
        /// <param name="flagCartaoDigitado">Indica se o estabelecimento poder\u00C3\u00A1 originar transa\u00C3\u00A7\u00C3\u00B5es sem a leitura da tarja ou do chip do cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="inativo">Indica se o estabelecimento est\u00C3\u00A1 inativo. (optional)</param> 
        /// <param name="idPais">Identificador de Pa\u00C3\u00ADs. (optional)</param> 
        /// <param name="mcc">C\u00C3\u00B3digo de Categoria de Mercado (optional)</param> 
        /// <param name="idTipoEstabelecimento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento. (optional)</param> 
        /// <param name="idMoeda">C\u00C3\u00B3digo identificador da moeda. (optional)</param> 
        /// <param name="tipoPagamento">Tipo do regime de pagamento do estabelecimento. (optional)</param> 
        /// <param name="numeroEstabelecimento">N\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento na Conductor. (optional)</param> 
        /// <param name="cep2">C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP). (optional)</param> 
        /// <param name="nomeLogradouro2">Nome do Logradouro. (optional)</param> 
        /// <param name="numeroEndereco2">N\u00C3\u00BAmero do endere\u00C3\u00A7o. (optional)</param> 
        /// <param name="complemento2">Descri\u00C3\u00A7\u00C3\u00B5es complementares referente ao endere\u00C3\u00A7o. (optional)</param> 
        /// <param name="bairro2">Nome do bairro do endere\u00C3\u00A7o. (optional)</param> 
        /// <param name="cidade2">Nome da cidade do endere\u00C3\u00A7o. (optional)</param> 
        /// <param name="uf2">Sigla de identifica\u00C3\u00A7\u00C3\u00A3o da Unidade Federativa do endere\u00C3\u00A7o. (optional)</param> 
        /// <param name="flagMatriz">Indica se \u00C3\u00A9 matriz ou filial. (optional)</param> 
        /// <returns>PageEstabelecimentoResponse</returns>
        public PageEstabelecimentoResponse ListarUsingGET21 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idCredor = null, string numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, int? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null, long? idPais = null, long? mcc = null, long? idTipoEstabelecimento = null, long? idMoeda = null, string tipoPagamento = null, string numeroEstabelecimento = null, string cep2 = null, string nomeLogradouro2 = null, int? numeroEndereco2 = null, string complemento2 = null, string bairro2 = null, string cidade2 = null, string uf2 = null, int? flagMatriz = null)
        {
             ApiResponse<PageEstabelecimentoResponse> localVarResponse = ListarUsingGET21WithHttpInfo(sort, page, limit, id, idCredor, numeroReceitaFederal, nome, descricao, nomeFantasia, cep, nomeLogradouro, numeroEndereco, complemento, bairro, cidade, uf, pais, dataCadastramento, contato, email, flagArquivoSecrFazenda, flagCartaoDigitado, inativo, idPais, mcc, idTipoEstabelecimento, idMoeda, tipoPagamento, numeroEstabelecimento, cep2, nomeLogradouro2, numeroEndereco2, complemento2, bairro2, cidade2, uf2, flagMatriz);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista Estabelecimentos Lista todas os Estabelecimentos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id). (optional)</param> 
        /// <param name="idCredor">Apresenta o n\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Credor. (optional)</param> 
        /// <param name="numeroReceitaFederal">Apresenta o n\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento na Receita Federal. (optional)</param> 
        /// <param name="nome">Nome do Estabelecimento. (optional)</param> 
        /// <param name="descricao">Raz\u00C3\u00A3o Social do Estabelecimento. (optional)</param> 
        /// <param name="nomeFantasia">T\u00C3\u00ADtulo Comercial do Estabelecimento. (optional)</param> 
        /// <param name="cep">C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP). (optional)</param> 
        /// <param name="nomeLogradouro">Nome do Logradouro. (optional)</param> 
        /// <param name="numeroEndereco">N\u00C3\u00BAmero do endere\u00C3\u00A7o. (optional)</param> 
        /// <param name="complemento">Descri\u00C3\u00A7\u00C3\u00B5es complementares referente ao endere\u00C3\u00A7o. (optional)</param> 
        /// <param name="bairro">Nome do bairro do endere\u00C3\u00A7o. (optional)</param> 
        /// <param name="cidade">Nome da cidade do endere\u00C3\u00A7o. (optional)</param> 
        /// <param name="uf">Sigla de identifica\u00C3\u00A7\u00C3\u00A3o da Unidade Federativa do endere\u00C3\u00A7o. (optional)</param> 
        /// <param name="pais">Nome do pa\u00C3\u00ADs. (optional)</param> 
        /// <param name="dataCadastramento">Data de Cadastro do Estabelecimento, no formato yyyy-MM-dd. (optional)</param> 
        /// <param name="contato">Nome da pessoa para contato com o Estabelecimento. (optional)</param> 
        /// <param name="email">E-mail da pessoa para contato com o Estabelecimento. (optional)</param> 
        /// <param name="flagArquivoSecrFazenda">Indica se o estabelecimento ser\u00C3\u00A1 inclu\u00C3\u00ADdo no arquivo de registro para a Secretaria da Fazenda Estadual. (optional)</param> 
        /// <param name="flagCartaoDigitado">Indica se o estabelecimento poder\u00C3\u00A1 originar transa\u00C3\u00A7\u00C3\u00B5es sem a leitura da tarja ou do chip do cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="inativo">Indica se o estabelecimento est\u00C3\u00A1 inativo. (optional)</param> 
        /// <param name="idPais">Identificador de Pa\u00C3\u00ADs. (optional)</param> 
        /// <param name="mcc">C\u00C3\u00B3digo de Categoria de Mercado (optional)</param> 
        /// <param name="idTipoEstabelecimento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento. (optional)</param> 
        /// <param name="idMoeda">C\u00C3\u00B3digo identificador da moeda. (optional)</param> 
        /// <param name="tipoPagamento">Tipo do regime de pagamento do estabelecimento. (optional)</param> 
        /// <param name="numeroEstabelecimento">N\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento na Conductor. (optional)</param> 
        /// <param name="cep2">C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP). (optional)</param> 
        /// <param name="nomeLogradouro2">Nome do Logradouro. (optional)</param> 
        /// <param name="numeroEndereco2">N\u00C3\u00BAmero do endere\u00C3\u00A7o. (optional)</param> 
        /// <param name="complemento2">Descri\u00C3\u00A7\u00C3\u00B5es complementares referente ao endere\u00C3\u00A7o. (optional)</param> 
        /// <param name="bairro2">Nome do bairro do endere\u00C3\u00A7o. (optional)</param> 
        /// <param name="cidade2">Nome da cidade do endere\u00C3\u00A7o. (optional)</param> 
        /// <param name="uf2">Sigla de identifica\u00C3\u00A7\u00C3\u00A3o da Unidade Federativa do endere\u00C3\u00A7o. (optional)</param> 
        /// <param name="flagMatriz">Indica se \u00C3\u00A9 matriz ou filial. (optional)</param> 
        /// <returns>ApiResponse of PageEstabelecimentoResponse</returns>
        public ApiResponse< PageEstabelecimentoResponse > ListarUsingGET21WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idCredor = null, string numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, int? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null, long? idPais = null, long? mcc = null, long? idTipoEstabelecimento = null, long? idMoeda = null, string tipoPagamento = null, string numeroEstabelecimento = null, string cep2 = null, string nomeLogradouro2 = null, int? numeroEndereco2 = null, string complemento2 = null, string bairro2 = null, string cidade2 = null, string uf2 = null, int? flagMatriz = null)
        {
            
    
            var localVarPath = "/api/estabelecimentos";
    
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
            if (idCredor != null) localVarQueryParams.Add("idCredor", Configuration.ApiClient.ParameterToString(idCredor)); // query parameter
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (nomeFantasia != null) localVarQueryParams.Add("nomeFantasia", Configuration.ApiClient.ParameterToString(nomeFantasia)); // query parameter
            if (cep != null) localVarQueryParams.Add("cep", Configuration.ApiClient.ParameterToString(cep)); // query parameter
            if (nomeLogradouro != null) localVarQueryParams.Add("nomeLogradouro", Configuration.ApiClient.ParameterToString(nomeLogradouro)); // query parameter
            if (numeroEndereco != null) localVarQueryParams.Add("numeroEndereco", Configuration.ApiClient.ParameterToString(numeroEndereco)); // query parameter
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            if (bairro != null) localVarQueryParams.Add("bairro", Configuration.ApiClient.ParameterToString(bairro)); // query parameter
            if (cidade != null) localVarQueryParams.Add("cidade", Configuration.ApiClient.ParameterToString(cidade)); // query parameter
            if (uf != null) localVarQueryParams.Add("uf", Configuration.ApiClient.ParameterToString(uf)); // query parameter
            if (pais != null) localVarQueryParams.Add("pais", Configuration.ApiClient.ParameterToString(pais)); // query parameter
            if (dataCadastramento != null) localVarQueryParams.Add("dataCadastramento", Configuration.ApiClient.ParameterToString(dataCadastramento)); // query parameter
            if (contato != null) localVarQueryParams.Add("contato", Configuration.ApiClient.ParameterToString(contato)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (flagArquivoSecrFazenda != null) localVarQueryParams.Add("flagArquivoSecrFazenda", Configuration.ApiClient.ParameterToString(flagArquivoSecrFazenda)); // query parameter
            if (flagCartaoDigitado != null) localVarQueryParams.Add("flagCartaoDigitado", Configuration.ApiClient.ParameterToString(flagCartaoDigitado)); // query parameter
            if (inativo != null) localVarQueryParams.Add("inativo", Configuration.ApiClient.ParameterToString(inativo)); // query parameter
            if (idPais != null) localVarQueryParams.Add("idPais", Configuration.ApiClient.ParameterToString(idPais)); // query parameter
            if (mcc != null) localVarQueryParams.Add("mcc", Configuration.ApiClient.ParameterToString(mcc)); // query parameter
            if (idTipoEstabelecimento != null) localVarQueryParams.Add("idTipoEstabelecimento", Configuration.ApiClient.ParameterToString(idTipoEstabelecimento)); // query parameter
            if (idMoeda != null) localVarQueryParams.Add("idMoeda", Configuration.ApiClient.ParameterToString(idMoeda)); // query parameter
            if (tipoPagamento != null) localVarQueryParams.Add("tipoPagamento", Configuration.ApiClient.ParameterToString(tipoPagamento)); // query parameter
            if (numeroEstabelecimento != null) localVarQueryParams.Add("numeroEstabelecimento", Configuration.ApiClient.ParameterToString(numeroEstabelecimento)); // query parameter
            if (cep2 != null) localVarQueryParams.Add("cep2", Configuration.ApiClient.ParameterToString(cep2)); // query parameter
            if (nomeLogradouro2 != null) localVarQueryParams.Add("nomeLogradouro2", Configuration.ApiClient.ParameterToString(nomeLogradouro2)); // query parameter
            if (numeroEndereco2 != null) localVarQueryParams.Add("numeroEndereco2", Configuration.ApiClient.ParameterToString(numeroEndereco2)); // query parameter
            if (complemento2 != null) localVarQueryParams.Add("complemento2", Configuration.ApiClient.ParameterToString(complemento2)); // query parameter
            if (bairro2 != null) localVarQueryParams.Add("bairro2", Configuration.ApiClient.ParameterToString(bairro2)); // query parameter
            if (cidade2 != null) localVarQueryParams.Add("cidade2", Configuration.ApiClient.ParameterToString(cidade2)); // query parameter
            if (uf2 != null) localVarQueryParams.Add("uf2", Configuration.ApiClient.ParameterToString(uf2)); // query parameter
            if (flagMatriz != null) localVarQueryParams.Add("flagMatriz", Configuration.ApiClient.ParameterToString(flagMatriz)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET21: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET21: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEstabelecimentoResponse)));
            
        }

        
        /// <summary>
        /// Lista Estabelecimentos Lista todas os Estabelecimentos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id). (optional)</param>
        /// <param name="idCredor">Apresenta o n\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Credor. (optional)</param>
        /// <param name="numeroReceitaFederal">Apresenta o n\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento na Receita Federal. (optional)</param>
        /// <param name="nome">Nome do Estabelecimento. (optional)</param>
        /// <param name="descricao">Raz\u00C3\u00A3o Social do Estabelecimento. (optional)</param>
        /// <param name="nomeFantasia">T\u00C3\u00ADtulo Comercial do Estabelecimento. (optional)</param>
        /// <param name="cep">C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP). (optional)</param>
        /// <param name="nomeLogradouro">Nome do Logradouro. (optional)</param>
        /// <param name="numeroEndereco">N\u00C3\u00BAmero do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="complemento">Descri\u00C3\u00A7\u00C3\u00B5es complementares referente ao endere\u00C3\u00A7o. (optional)</param>
        /// <param name="bairro">Nome do bairro do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="cidade">Nome da cidade do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="uf">Sigla de identifica\u00C3\u00A7\u00C3\u00A3o da Unidade Federativa do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="pais">Nome do pa\u00C3\u00ADs. (optional)</param>
        /// <param name="dataCadastramento">Data de Cadastro do Estabelecimento, no formato yyyy-MM-dd. (optional)</param>
        /// <param name="contato">Nome da pessoa para contato com o Estabelecimento. (optional)</param>
        /// <param name="email">E-mail da pessoa para contato com o Estabelecimento. (optional)</param>
        /// <param name="flagArquivoSecrFazenda">Indica se o estabelecimento ser\u00C3\u00A1 inclu\u00C3\u00ADdo no arquivo de registro para a Secretaria da Fazenda Estadual. (optional)</param>
        /// <param name="flagCartaoDigitado">Indica se o estabelecimento poder\u00C3\u00A1 originar transa\u00C3\u00A7\u00C3\u00B5es sem a leitura da tarja ou do chip do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="inativo">Indica se o estabelecimento est\u00C3\u00A1 inativo. (optional)</param>
        /// <param name="idPais">Identificador de Pa\u00C3\u00ADs. (optional)</param>
        /// <param name="mcc">C\u00C3\u00B3digo de Categoria de Mercado (optional)</param>
        /// <param name="idTipoEstabelecimento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento. (optional)</param>
        /// <param name="idMoeda">C\u00C3\u00B3digo identificador da moeda. (optional)</param>
        /// <param name="tipoPagamento">Tipo do regime de pagamento do estabelecimento. (optional)</param>
        /// <param name="numeroEstabelecimento">N\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento na Conductor. (optional)</param>
        /// <param name="cep2">C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP). (optional)</param>
        /// <param name="nomeLogradouro2">Nome do Logradouro. (optional)</param>
        /// <param name="numeroEndereco2">N\u00C3\u00BAmero do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="complemento2">Descri\u00C3\u00A7\u00C3\u00B5es complementares referente ao endere\u00C3\u00A7o. (optional)</param>
        /// <param name="bairro2">Nome do bairro do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="cidade2">Nome da cidade do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="uf2">Sigla de identifica\u00C3\u00A7\u00C3\u00A3o da Unidade Federativa do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="flagMatriz">Indica se \u00C3\u00A9 matriz ou filial. (optional)</param>
        /// <returns>Task of PageEstabelecimentoResponse</returns>
        public async System.Threading.Tasks.Task<PageEstabelecimentoResponse> ListarUsingGET21Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idCredor = null, string numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, int? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null, long? idPais = null, long? mcc = null, long? idTipoEstabelecimento = null, long? idMoeda = null, string tipoPagamento = null, string numeroEstabelecimento = null, string cep2 = null, string nomeLogradouro2 = null, int? numeroEndereco2 = null, string complemento2 = null, string bairro2 = null, string cidade2 = null, string uf2 = null, int? flagMatriz = null)
        {
             ApiResponse<PageEstabelecimentoResponse> localVarResponse = await ListarUsingGET21AsyncWithHttpInfo(sort, page, limit, id, idCredor, numeroReceitaFederal, nome, descricao, nomeFantasia, cep, nomeLogradouro, numeroEndereco, complemento, bairro, cidade, uf, pais, dataCadastramento, contato, email, flagArquivoSecrFazenda, flagCartaoDigitado, inativo, idPais, mcc, idTipoEstabelecimento, idMoeda, tipoPagamento, numeroEstabelecimento, cep2, nomeLogradouro2, numeroEndereco2, complemento2, bairro2, cidade2, uf2, flagMatriz);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista Estabelecimentos Lista todas os Estabelecimentos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id). (optional)</param>
        /// <param name="idCredor">Apresenta o n\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Credor. (optional)</param>
        /// <param name="numeroReceitaFederal">Apresenta o n\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento na Receita Federal. (optional)</param>
        /// <param name="nome">Nome do Estabelecimento. (optional)</param>
        /// <param name="descricao">Raz\u00C3\u00A3o Social do Estabelecimento. (optional)</param>
        /// <param name="nomeFantasia">T\u00C3\u00ADtulo Comercial do Estabelecimento. (optional)</param>
        /// <param name="cep">C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP). (optional)</param>
        /// <param name="nomeLogradouro">Nome do Logradouro. (optional)</param>
        /// <param name="numeroEndereco">N\u00C3\u00BAmero do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="complemento">Descri\u00C3\u00A7\u00C3\u00B5es complementares referente ao endere\u00C3\u00A7o. (optional)</param>
        /// <param name="bairro">Nome do bairro do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="cidade">Nome da cidade do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="uf">Sigla de identifica\u00C3\u00A7\u00C3\u00A3o da Unidade Federativa do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="pais">Nome do pa\u00C3\u00ADs. (optional)</param>
        /// <param name="dataCadastramento">Data de Cadastro do Estabelecimento, no formato yyyy-MM-dd. (optional)</param>
        /// <param name="contato">Nome da pessoa para contato com o Estabelecimento. (optional)</param>
        /// <param name="email">E-mail da pessoa para contato com o Estabelecimento. (optional)</param>
        /// <param name="flagArquivoSecrFazenda">Indica se o estabelecimento ser\u00C3\u00A1 inclu\u00C3\u00ADdo no arquivo de registro para a Secretaria da Fazenda Estadual. (optional)</param>
        /// <param name="flagCartaoDigitado">Indica se o estabelecimento poder\u00C3\u00A1 originar transa\u00C3\u00A7\u00C3\u00B5es sem a leitura da tarja ou do chip do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="inativo">Indica se o estabelecimento est\u00C3\u00A1 inativo. (optional)</param>
        /// <param name="idPais">Identificador de Pa\u00C3\u00ADs. (optional)</param>
        /// <param name="mcc">C\u00C3\u00B3digo de Categoria de Mercado (optional)</param>
        /// <param name="idTipoEstabelecimento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento. (optional)</param>
        /// <param name="idMoeda">C\u00C3\u00B3digo identificador da moeda. (optional)</param>
        /// <param name="tipoPagamento">Tipo do regime de pagamento do estabelecimento. (optional)</param>
        /// <param name="numeroEstabelecimento">N\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento na Conductor. (optional)</param>
        /// <param name="cep2">C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP). (optional)</param>
        /// <param name="nomeLogradouro2">Nome do Logradouro. (optional)</param>
        /// <param name="numeroEndereco2">N\u00C3\u00BAmero do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="complemento2">Descri\u00C3\u00A7\u00C3\u00B5es complementares referente ao endere\u00C3\u00A7o. (optional)</param>
        /// <param name="bairro2">Nome do bairro do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="cidade2">Nome da cidade do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="uf2">Sigla de identifica\u00C3\u00A7\u00C3\u00A3o da Unidade Federativa do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="flagMatriz">Indica se \u00C3\u00A9 matriz ou filial. (optional)</param>
        /// <returns>Task of ApiResponse (PageEstabelecimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageEstabelecimentoResponse>> ListarUsingGET21AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idCredor = null, string numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, int? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null, long? idPais = null, long? mcc = null, long? idTipoEstabelecimento = null, long? idMoeda = null, string tipoPagamento = null, string numeroEstabelecimento = null, string cep2 = null, string nomeLogradouro2 = null, int? numeroEndereco2 = null, string complemento2 = null, string bairro2 = null, string cidade2 = null, string uf2 = null, int? flagMatriz = null)
        {
            
    
            var localVarPath = "/api/estabelecimentos";
    
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
            if (idCredor != null) localVarQueryParams.Add("idCredor", Configuration.ApiClient.ParameterToString(idCredor)); // query parameter
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (nomeFantasia != null) localVarQueryParams.Add("nomeFantasia", Configuration.ApiClient.ParameterToString(nomeFantasia)); // query parameter
            if (cep != null) localVarQueryParams.Add("cep", Configuration.ApiClient.ParameterToString(cep)); // query parameter
            if (nomeLogradouro != null) localVarQueryParams.Add("nomeLogradouro", Configuration.ApiClient.ParameterToString(nomeLogradouro)); // query parameter
            if (numeroEndereco != null) localVarQueryParams.Add("numeroEndereco", Configuration.ApiClient.ParameterToString(numeroEndereco)); // query parameter
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            if (bairro != null) localVarQueryParams.Add("bairro", Configuration.ApiClient.ParameterToString(bairro)); // query parameter
            if (cidade != null) localVarQueryParams.Add("cidade", Configuration.ApiClient.ParameterToString(cidade)); // query parameter
            if (uf != null) localVarQueryParams.Add("uf", Configuration.ApiClient.ParameterToString(uf)); // query parameter
            if (pais != null) localVarQueryParams.Add("pais", Configuration.ApiClient.ParameterToString(pais)); // query parameter
            if (dataCadastramento != null) localVarQueryParams.Add("dataCadastramento", Configuration.ApiClient.ParameterToString(dataCadastramento)); // query parameter
            if (contato != null) localVarQueryParams.Add("contato", Configuration.ApiClient.ParameterToString(contato)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (flagArquivoSecrFazenda != null) localVarQueryParams.Add("flagArquivoSecrFazenda", Configuration.ApiClient.ParameterToString(flagArquivoSecrFazenda)); // query parameter
            if (flagCartaoDigitado != null) localVarQueryParams.Add("flagCartaoDigitado", Configuration.ApiClient.ParameterToString(flagCartaoDigitado)); // query parameter
            if (inativo != null) localVarQueryParams.Add("inativo", Configuration.ApiClient.ParameterToString(inativo)); // query parameter
            if (idPais != null) localVarQueryParams.Add("idPais", Configuration.ApiClient.ParameterToString(idPais)); // query parameter
            if (mcc != null) localVarQueryParams.Add("mcc", Configuration.ApiClient.ParameterToString(mcc)); // query parameter
            if (idTipoEstabelecimento != null) localVarQueryParams.Add("idTipoEstabelecimento", Configuration.ApiClient.ParameterToString(idTipoEstabelecimento)); // query parameter
            if (idMoeda != null) localVarQueryParams.Add("idMoeda", Configuration.ApiClient.ParameterToString(idMoeda)); // query parameter
            if (tipoPagamento != null) localVarQueryParams.Add("tipoPagamento", Configuration.ApiClient.ParameterToString(tipoPagamento)); // query parameter
            if (numeroEstabelecimento != null) localVarQueryParams.Add("numeroEstabelecimento", Configuration.ApiClient.ParameterToString(numeroEstabelecimento)); // query parameter
            if (cep2 != null) localVarQueryParams.Add("cep2", Configuration.ApiClient.ParameterToString(cep2)); // query parameter
            if (nomeLogradouro2 != null) localVarQueryParams.Add("nomeLogradouro2", Configuration.ApiClient.ParameterToString(nomeLogradouro2)); // query parameter
            if (numeroEndereco2 != null) localVarQueryParams.Add("numeroEndereco2", Configuration.ApiClient.ParameterToString(numeroEndereco2)); // query parameter
            if (complemento2 != null) localVarQueryParams.Add("complemento2", Configuration.ApiClient.ParameterToString(complemento2)); // query parameter
            if (bairro2 != null) localVarQueryParams.Add("bairro2", Configuration.ApiClient.ParameterToString(bairro2)); // query parameter
            if (cidade2 != null) localVarQueryParams.Add("cidade2", Configuration.ApiClient.ParameterToString(cidade2)); // query parameter
            if (uf2 != null) localVarQueryParams.Add("uf2", Configuration.ApiClient.ParameterToString(uf2)); // query parameter
            if (flagMatriz != null) localVarQueryParams.Add("flagMatriz", Configuration.ApiClient.ParameterToString(flagMatriz)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET21: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET21: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEstabelecimentoResponse)));
            
        }
        
        /// <summary>
        /// Listar grupos econ\u00C3\u00B4micos Lista grupos econ\u00C3\u00B4micos cadastrados. 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="razaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param> 
        /// <param name="nomeCredor">Nome do credor (optional)</param> 
        /// <param name="numeroReceitaFederal">N\u00C3\u00BAmero da Receita Federal (optional)</param> 
        /// <param name="inscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual (optional)</param> 
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param> 
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param> 
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param> 
        /// <param name="digitoAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param> 
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param> 
        /// <param name="digitoContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param> 
        /// <param name="periodicidade">Periodicidade do pagamento (optional)</param> 
        /// <param name="pagamentoSemanal">Dia para pagamento semanal (optional)</param> 
        /// <param name="pagamentoMensal">Dia da data para o pagamento mensal (optional)</param> 
        /// <param name="pagamentoDecendialPrimeiro">Dia da data para o primeiro pagamento decendial (optional)</param> 
        /// <param name="pagamentoDecendialSegundo">Dia da data para o segundo pagamento decendial (optional)</param> 
        /// <param name="pagamentoDecendialTerceiro">Dia da data para o terceiro pagamento decendial (optional)</param> 
        /// <param name="pagamentoQuinzenalPrimeiro">Dia da data para o primeiro pagamento quinzenal (optional)</param> 
        /// <param name="pagamentoQuinzenalSegundo">Dia da data para o segundo pagamento quinzenal (optional)</param> 
        /// <param name="percentualRAV">Valor percentual do RAV do credor (optional)</param> 
        /// <param name="recebeRAV">Indica se o credor recebe RAV e o tipo (optional)</param> 
        /// <param name="percentualMultiplica">Percentual Multiplica (optional)</param> 
        /// <param name="taxaAdm">Taxa Administrativa (optional)</param> 
        /// <param name="taxaBanco">Taxa do Banco (optional)</param> 
        /// <param name="limiteRAV">Valor limite do RAV (optional)</param> 
        /// <param name="idCredorRAV">C\u00C3\u00B3digo identificador do credor RAV (optional)</param> 
        /// <returns>PageGrupoEconomicoResponse</returns>
        public PageGrupoEconomicoResponse ListarUsingGET23 (List<string> sort = null, int? page = null, int? limit = null, string razaoSocial = null, string nomeCredor = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, string periodicidade = null, string pagamentoSemanal = null, int? pagamentoMensal = null, int? pagamentoDecendialPrimeiro = null, int? pagamentoDecendialSegundo = null, int? pagamentoDecendialTerceiro = null, int? pagamentoQuinzenalPrimeiro = null, int? pagamentoQuinzenalSegundo = null, double? percentualRAV = null, string recebeRAV = null, double? percentualMultiplica = null, double? taxaAdm = null, double? taxaBanco = null, double? limiteRAV = null, long? idCredorRAV = null)
        {
             ApiResponse<PageGrupoEconomicoResponse> localVarResponse = ListarUsingGET23WithHttpInfo(sort, page, limit, razaoSocial, nomeCredor, numeroReceitaFederal, inscricaoEstadual, contato, banco, agencia, digitoAgencia, contaCorrente, digitoContaCorrente, periodicidade, pagamentoSemanal, pagamentoMensal, pagamentoDecendialPrimeiro, pagamentoDecendialSegundo, pagamentoDecendialTerceiro, pagamentoQuinzenalPrimeiro, pagamentoQuinzenalSegundo, percentualRAV, recebeRAV, percentualMultiplica, taxaAdm, taxaBanco, limiteRAV, idCredorRAV);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar grupos econ\u00C3\u00B4micos Lista grupos econ\u00C3\u00B4micos cadastrados. 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="razaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param> 
        /// <param name="nomeCredor">Nome do credor (optional)</param> 
        /// <param name="numeroReceitaFederal">N\u00C3\u00BAmero da Receita Federal (optional)</param> 
        /// <param name="inscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual (optional)</param> 
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param> 
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param> 
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param> 
        /// <param name="digitoAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param> 
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param> 
        /// <param name="digitoContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param> 
        /// <param name="periodicidade">Periodicidade do pagamento (optional)</param> 
        /// <param name="pagamentoSemanal">Dia para pagamento semanal (optional)</param> 
        /// <param name="pagamentoMensal">Dia da data para o pagamento mensal (optional)</param> 
        /// <param name="pagamentoDecendialPrimeiro">Dia da data para o primeiro pagamento decendial (optional)</param> 
        /// <param name="pagamentoDecendialSegundo">Dia da data para o segundo pagamento decendial (optional)</param> 
        /// <param name="pagamentoDecendialTerceiro">Dia da data para o terceiro pagamento decendial (optional)</param> 
        /// <param name="pagamentoQuinzenalPrimeiro">Dia da data para o primeiro pagamento quinzenal (optional)</param> 
        /// <param name="pagamentoQuinzenalSegundo">Dia da data para o segundo pagamento quinzenal (optional)</param> 
        /// <param name="percentualRAV">Valor percentual do RAV do credor (optional)</param> 
        /// <param name="recebeRAV">Indica se o credor recebe RAV e o tipo (optional)</param> 
        /// <param name="percentualMultiplica">Percentual Multiplica (optional)</param> 
        /// <param name="taxaAdm">Taxa Administrativa (optional)</param> 
        /// <param name="taxaBanco">Taxa do Banco (optional)</param> 
        /// <param name="limiteRAV">Valor limite do RAV (optional)</param> 
        /// <param name="idCredorRAV">C\u00C3\u00B3digo identificador do credor RAV (optional)</param> 
        /// <returns>ApiResponse of PageGrupoEconomicoResponse</returns>
        public ApiResponse< PageGrupoEconomicoResponse > ListarUsingGET23WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string razaoSocial = null, string nomeCredor = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, string periodicidade = null, string pagamentoSemanal = null, int? pagamentoMensal = null, int? pagamentoDecendialPrimeiro = null, int? pagamentoDecendialSegundo = null, int? pagamentoDecendialTerceiro = null, int? pagamentoQuinzenalPrimeiro = null, int? pagamentoQuinzenalSegundo = null, double? percentualRAV = null, string recebeRAV = null, double? percentualMultiplica = null, double? taxaAdm = null, double? taxaBanco = null, double? limiteRAV = null, long? idCredorRAV = null)
        {
            
    
            var localVarPath = "/api/grupos-economicos";
    
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
            if (razaoSocial != null) localVarQueryParams.Add("razaoSocial", Configuration.ApiClient.ParameterToString(razaoSocial)); // query parameter
            if (nomeCredor != null) localVarQueryParams.Add("nomeCredor", Configuration.ApiClient.ParameterToString(nomeCredor)); // query parameter
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (inscricaoEstadual != null) localVarQueryParams.Add("inscricaoEstadual", Configuration.ApiClient.ParameterToString(inscricaoEstadual)); // query parameter
            if (contato != null) localVarQueryParams.Add("contato", Configuration.ApiClient.ParameterToString(contato)); // query parameter
            if (banco != null) localVarQueryParams.Add("banco", Configuration.ApiClient.ParameterToString(banco)); // query parameter
            if (agencia != null) localVarQueryParams.Add("agencia", Configuration.ApiClient.ParameterToString(agencia)); // query parameter
            if (digitoAgencia != null) localVarQueryParams.Add("digitoAgencia", Configuration.ApiClient.ParameterToString(digitoAgencia)); // query parameter
            if (contaCorrente != null) localVarQueryParams.Add("contaCorrente", Configuration.ApiClient.ParameterToString(contaCorrente)); // query parameter
            if (digitoContaCorrente != null) localVarQueryParams.Add("digitoContaCorrente", Configuration.ApiClient.ParameterToString(digitoContaCorrente)); // query parameter
            if (periodicidade != null) localVarQueryParams.Add("periodicidade", Configuration.ApiClient.ParameterToString(periodicidade)); // query parameter
            if (pagamentoSemanal != null) localVarQueryParams.Add("pagamentoSemanal", Configuration.ApiClient.ParameterToString(pagamentoSemanal)); // query parameter
            if (pagamentoMensal != null) localVarQueryParams.Add("pagamentoMensal", Configuration.ApiClient.ParameterToString(pagamentoMensal)); // query parameter
            if (pagamentoDecendialPrimeiro != null) localVarQueryParams.Add("pagamentoDecendialPrimeiro", Configuration.ApiClient.ParameterToString(pagamentoDecendialPrimeiro)); // query parameter
            if (pagamentoDecendialSegundo != null) localVarQueryParams.Add("pagamentoDecendialSegundo", Configuration.ApiClient.ParameterToString(pagamentoDecendialSegundo)); // query parameter
            if (pagamentoDecendialTerceiro != null) localVarQueryParams.Add("pagamentoDecendialTerceiro", Configuration.ApiClient.ParameterToString(pagamentoDecendialTerceiro)); // query parameter
            if (pagamentoQuinzenalPrimeiro != null) localVarQueryParams.Add("pagamentoQuinzenalPrimeiro", Configuration.ApiClient.ParameterToString(pagamentoQuinzenalPrimeiro)); // query parameter
            if (pagamentoQuinzenalSegundo != null) localVarQueryParams.Add("pagamentoQuinzenalSegundo", Configuration.ApiClient.ParameterToString(pagamentoQuinzenalSegundo)); // query parameter
            if (percentualRAV != null) localVarQueryParams.Add("percentualRAV", Configuration.ApiClient.ParameterToString(percentualRAV)); // query parameter
            if (recebeRAV != null) localVarQueryParams.Add("recebeRAV", Configuration.ApiClient.ParameterToString(recebeRAV)); // query parameter
            if (percentualMultiplica != null) localVarQueryParams.Add("percentualMultiplica", Configuration.ApiClient.ParameterToString(percentualMultiplica)); // query parameter
            if (taxaAdm != null) localVarQueryParams.Add("taxaAdm", Configuration.ApiClient.ParameterToString(taxaAdm)); // query parameter
            if (taxaBanco != null) localVarQueryParams.Add("taxaBanco", Configuration.ApiClient.ParameterToString(taxaBanco)); // query parameter
            if (limiteRAV != null) localVarQueryParams.Add("limiteRAV", Configuration.ApiClient.ParameterToString(limiteRAV)); // query parameter
            if (idCredorRAV != null) localVarQueryParams.Add("idCredorRAV", Configuration.ApiClient.ParameterToString(idCredorRAV)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET23: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET23: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageGrupoEconomicoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageGrupoEconomicoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageGrupoEconomicoResponse)));
            
        }

        
        /// <summary>
        /// Listar grupos econ\u00C3\u00B4micos Lista grupos econ\u00C3\u00B4micos cadastrados. 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="razaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="nomeCredor">Nome do credor (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00C3\u00BAmero da Receita Federal (optional)</param>
        /// <param name="inscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual (optional)</param>
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param>
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="digitoAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param>
        /// <param name="digitoContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param>
        /// <param name="periodicidade">Periodicidade do pagamento (optional)</param>
        /// <param name="pagamentoSemanal">Dia para pagamento semanal (optional)</param>
        /// <param name="pagamentoMensal">Dia da data para o pagamento mensal (optional)</param>
        /// <param name="pagamentoDecendialPrimeiro">Dia da data para o primeiro pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialSegundo">Dia da data para o segundo pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialTerceiro">Dia da data para o terceiro pagamento decendial (optional)</param>
        /// <param name="pagamentoQuinzenalPrimeiro">Dia da data para o primeiro pagamento quinzenal (optional)</param>
        /// <param name="pagamentoQuinzenalSegundo">Dia da data para o segundo pagamento quinzenal (optional)</param>
        /// <param name="percentualRAV">Valor percentual do RAV do credor (optional)</param>
        /// <param name="recebeRAV">Indica se o credor recebe RAV e o tipo (optional)</param>
        /// <param name="percentualMultiplica">Percentual Multiplica (optional)</param>
        /// <param name="taxaAdm">Taxa Administrativa (optional)</param>
        /// <param name="taxaBanco">Taxa do Banco (optional)</param>
        /// <param name="limiteRAV">Valor limite do RAV (optional)</param>
        /// <param name="idCredorRAV">C\u00C3\u00B3digo identificador do credor RAV (optional)</param>
        /// <returns>Task of PageGrupoEconomicoResponse</returns>
        public async System.Threading.Tasks.Task<PageGrupoEconomicoResponse> ListarUsingGET23Async (List<string> sort = null, int? page = null, int? limit = null, string razaoSocial = null, string nomeCredor = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, string periodicidade = null, string pagamentoSemanal = null, int? pagamentoMensal = null, int? pagamentoDecendialPrimeiro = null, int? pagamentoDecendialSegundo = null, int? pagamentoDecendialTerceiro = null, int? pagamentoQuinzenalPrimeiro = null, int? pagamentoQuinzenalSegundo = null, double? percentualRAV = null, string recebeRAV = null, double? percentualMultiplica = null, double? taxaAdm = null, double? taxaBanco = null, double? limiteRAV = null, long? idCredorRAV = null)
        {
             ApiResponse<PageGrupoEconomicoResponse> localVarResponse = await ListarUsingGET23AsyncWithHttpInfo(sort, page, limit, razaoSocial, nomeCredor, numeroReceitaFederal, inscricaoEstadual, contato, banco, agencia, digitoAgencia, contaCorrente, digitoContaCorrente, periodicidade, pagamentoSemanal, pagamentoMensal, pagamentoDecendialPrimeiro, pagamentoDecendialSegundo, pagamentoDecendialTerceiro, pagamentoQuinzenalPrimeiro, pagamentoQuinzenalSegundo, percentualRAV, recebeRAV, percentualMultiplica, taxaAdm, taxaBanco, limiteRAV, idCredorRAV);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar grupos econ\u00C3\u00B4micos Lista grupos econ\u00C3\u00B4micos cadastrados. 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="razaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="nomeCredor">Nome do credor (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00C3\u00BAmero da Receita Federal (optional)</param>
        /// <param name="inscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual (optional)</param>
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param>
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="digitoAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param>
        /// <param name="digitoContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param>
        /// <param name="periodicidade">Periodicidade do pagamento (optional)</param>
        /// <param name="pagamentoSemanal">Dia para pagamento semanal (optional)</param>
        /// <param name="pagamentoMensal">Dia da data para o pagamento mensal (optional)</param>
        /// <param name="pagamentoDecendialPrimeiro">Dia da data para o primeiro pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialSegundo">Dia da data para o segundo pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialTerceiro">Dia da data para o terceiro pagamento decendial (optional)</param>
        /// <param name="pagamentoQuinzenalPrimeiro">Dia da data para o primeiro pagamento quinzenal (optional)</param>
        /// <param name="pagamentoQuinzenalSegundo">Dia da data para o segundo pagamento quinzenal (optional)</param>
        /// <param name="percentualRAV">Valor percentual do RAV do credor (optional)</param>
        /// <param name="recebeRAV">Indica se o credor recebe RAV e o tipo (optional)</param>
        /// <param name="percentualMultiplica">Percentual Multiplica (optional)</param>
        /// <param name="taxaAdm">Taxa Administrativa (optional)</param>
        /// <param name="taxaBanco">Taxa do Banco (optional)</param>
        /// <param name="limiteRAV">Valor limite do RAV (optional)</param>
        /// <param name="idCredorRAV">C\u00C3\u00B3digo identificador do credor RAV (optional)</param>
        /// <returns>Task of ApiResponse (PageGrupoEconomicoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageGrupoEconomicoResponse>> ListarUsingGET23AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string razaoSocial = null, string nomeCredor = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, string periodicidade = null, string pagamentoSemanal = null, int? pagamentoMensal = null, int? pagamentoDecendialPrimeiro = null, int? pagamentoDecendialSegundo = null, int? pagamentoDecendialTerceiro = null, int? pagamentoQuinzenalPrimeiro = null, int? pagamentoQuinzenalSegundo = null, double? percentualRAV = null, string recebeRAV = null, double? percentualMultiplica = null, double? taxaAdm = null, double? taxaBanco = null, double? limiteRAV = null, long? idCredorRAV = null)
        {
            
    
            var localVarPath = "/api/grupos-economicos";
    
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
            if (razaoSocial != null) localVarQueryParams.Add("razaoSocial", Configuration.ApiClient.ParameterToString(razaoSocial)); // query parameter
            if (nomeCredor != null) localVarQueryParams.Add("nomeCredor", Configuration.ApiClient.ParameterToString(nomeCredor)); // query parameter
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (inscricaoEstadual != null) localVarQueryParams.Add("inscricaoEstadual", Configuration.ApiClient.ParameterToString(inscricaoEstadual)); // query parameter
            if (contato != null) localVarQueryParams.Add("contato", Configuration.ApiClient.ParameterToString(contato)); // query parameter
            if (banco != null) localVarQueryParams.Add("banco", Configuration.ApiClient.ParameterToString(banco)); // query parameter
            if (agencia != null) localVarQueryParams.Add("agencia", Configuration.ApiClient.ParameterToString(agencia)); // query parameter
            if (digitoAgencia != null) localVarQueryParams.Add("digitoAgencia", Configuration.ApiClient.ParameterToString(digitoAgencia)); // query parameter
            if (contaCorrente != null) localVarQueryParams.Add("contaCorrente", Configuration.ApiClient.ParameterToString(contaCorrente)); // query parameter
            if (digitoContaCorrente != null) localVarQueryParams.Add("digitoContaCorrente", Configuration.ApiClient.ParameterToString(digitoContaCorrente)); // query parameter
            if (periodicidade != null) localVarQueryParams.Add("periodicidade", Configuration.ApiClient.ParameterToString(periodicidade)); // query parameter
            if (pagamentoSemanal != null) localVarQueryParams.Add("pagamentoSemanal", Configuration.ApiClient.ParameterToString(pagamentoSemanal)); // query parameter
            if (pagamentoMensal != null) localVarQueryParams.Add("pagamentoMensal", Configuration.ApiClient.ParameterToString(pagamentoMensal)); // query parameter
            if (pagamentoDecendialPrimeiro != null) localVarQueryParams.Add("pagamentoDecendialPrimeiro", Configuration.ApiClient.ParameterToString(pagamentoDecendialPrimeiro)); // query parameter
            if (pagamentoDecendialSegundo != null) localVarQueryParams.Add("pagamentoDecendialSegundo", Configuration.ApiClient.ParameterToString(pagamentoDecendialSegundo)); // query parameter
            if (pagamentoDecendialTerceiro != null) localVarQueryParams.Add("pagamentoDecendialTerceiro", Configuration.ApiClient.ParameterToString(pagamentoDecendialTerceiro)); // query parameter
            if (pagamentoQuinzenalPrimeiro != null) localVarQueryParams.Add("pagamentoQuinzenalPrimeiro", Configuration.ApiClient.ParameterToString(pagamentoQuinzenalPrimeiro)); // query parameter
            if (pagamentoQuinzenalSegundo != null) localVarQueryParams.Add("pagamentoQuinzenalSegundo", Configuration.ApiClient.ParameterToString(pagamentoQuinzenalSegundo)); // query parameter
            if (percentualRAV != null) localVarQueryParams.Add("percentualRAV", Configuration.ApiClient.ParameterToString(percentualRAV)); // query parameter
            if (recebeRAV != null) localVarQueryParams.Add("recebeRAV", Configuration.ApiClient.ParameterToString(recebeRAV)); // query parameter
            if (percentualMultiplica != null) localVarQueryParams.Add("percentualMultiplica", Configuration.ApiClient.ParameterToString(percentualMultiplica)); // query parameter
            if (taxaAdm != null) localVarQueryParams.Add("taxaAdm", Configuration.ApiClient.ParameterToString(taxaAdm)); // query parameter
            if (taxaBanco != null) localVarQueryParams.Add("taxaBanco", Configuration.ApiClient.ParameterToString(taxaBanco)); // query parameter
            if (limiteRAV != null) localVarQueryParams.Add("limiteRAV", Configuration.ApiClient.ParameterToString(limiteRAV)); // query parameter
            if (idCredorRAV != null) localVarQueryParams.Add("idCredorRAV", Configuration.ApiClient.ParameterToString(idCredorRAV)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET23: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET23: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageGrupoEconomicoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageGrupoEconomicoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageGrupoEconomicoResponse)));
            
        }
        
        /// <summary>
        /// Lista as Maquinetas Este m\u00C3\u00A9todo permite que sejam listadas as maquinetas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Estabelecimento (id). (optional)</param> 
        /// <returns>PageMaquinetaResponse</returns>
        public PageMaquinetaResponse ListarUsingGET25 (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null)
        {
             ApiResponse<PageMaquinetaResponse> localVarResponse = ListarUsingGET25WithHttpInfo(sort, page, limit, idEstabelecimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as Maquinetas Este m\u00C3\u00A9todo permite que sejam listadas as maquinetas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Estabelecimento (id). (optional)</param> 
        /// <returns>ApiResponse of PageMaquinetaResponse</returns>
        public ApiResponse< PageMaquinetaResponse > ListarUsingGET25WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null)
        {
            
    
            var localVarPath = "/api/maquinetas";
    
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
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET25: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET25: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageMaquinetaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageMaquinetaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageMaquinetaResponse)));
            
        }

        
        /// <summary>
        /// Lista as Maquinetas Este m\u00C3\u00A9todo permite que sejam listadas as maquinetas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Estabelecimento (id). (optional)</param>
        /// <returns>Task of PageMaquinetaResponse</returns>
        public async System.Threading.Tasks.Task<PageMaquinetaResponse> ListarUsingGET25Async (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null)
        {
             ApiResponse<PageMaquinetaResponse> localVarResponse = await ListarUsingGET25AsyncWithHttpInfo(sort, page, limit, idEstabelecimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as Maquinetas Este m\u00C3\u00A9todo permite que sejam listadas as maquinetas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Estabelecimento (id). (optional)</param>
        /// <returns>Task of ApiResponse (PageMaquinetaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageMaquinetaResponse>> ListarUsingGET25AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null)
        {
            
    
            var localVarPath = "/api/maquinetas";
    
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
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET25: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET25: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageMaquinetaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageMaquinetaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageMaquinetaResponse)));
            
        }
        
        /// <summary>
        /// Lista os tipos de moedas do emissor  Este recurso permite que sejam listados os tipos de moedas existentes na base de dados do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="codigoMoeda">C\u00C3\u00B3digo identificador do tipo de moeda. (optional)</param> 
        /// <param name="simbolo">S\u00C3\u00ADmbolo da Moeda. (optional)</param> 
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo da moeda. (optional)</param> 
        /// <returns>PageMoedaResponse</returns>
        public PageMoedaResponse ListarUsingGET26 (List<string> sort = null, int? page = null, int? limit = null, string codigoMoeda = null, string simbolo = null, string descricao = null)
        {
             ApiResponse<PageMoedaResponse> localVarResponse = ListarUsingGET26WithHttpInfo(sort, page, limit, codigoMoeda, simbolo, descricao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os tipos de moedas do emissor  Este recurso permite que sejam listados os tipos de moedas existentes na base de dados do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="codigoMoeda">C\u00C3\u00B3digo identificador do tipo de moeda. (optional)</param> 
        /// <param name="simbolo">S\u00C3\u00ADmbolo da Moeda. (optional)</param> 
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo da moeda. (optional)</param> 
        /// <returns>ApiResponse of PageMoedaResponse</returns>
        public ApiResponse< PageMoedaResponse > ListarUsingGET26WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string codigoMoeda = null, string simbolo = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/tipos-moedas";
    
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
            if (codigoMoeda != null) localVarQueryParams.Add("codigoMoeda", Configuration.ApiClient.ParameterToString(codigoMoeda)); // query parameter
            if (simbolo != null) localVarQueryParams.Add("simbolo", Configuration.ApiClient.ParameterToString(simbolo)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET26: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET26: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageMoedaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageMoedaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageMoedaResponse)));
            
        }

        
        /// <summary>
        /// Lista os tipos de moedas do emissor  Este recurso permite que sejam listados os tipos de moedas existentes na base de dados do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="codigoMoeda">C\u00C3\u00B3digo identificador do tipo de moeda. (optional)</param>
        /// <param name="simbolo">S\u00C3\u00ADmbolo da Moeda. (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo da moeda. (optional)</param>
        /// <returns>Task of PageMoedaResponse</returns>
        public async System.Threading.Tasks.Task<PageMoedaResponse> ListarUsingGET26Async (List<string> sort = null, int? page = null, int? limit = null, string codigoMoeda = null, string simbolo = null, string descricao = null)
        {
             ApiResponse<PageMoedaResponse> localVarResponse = await ListarUsingGET26AsyncWithHttpInfo(sort, page, limit, codigoMoeda, simbolo, descricao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os tipos de moedas do emissor  Este recurso permite que sejam listados os tipos de moedas existentes na base de dados do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="codigoMoeda">C\u00C3\u00B3digo identificador do tipo de moeda. (optional)</param>
        /// <param name="simbolo">S\u00C3\u00ADmbolo da Moeda. (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo da moeda. (optional)</param>
        /// <returns>Task of ApiResponse (PageMoedaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageMoedaResponse>> ListarUsingGET26AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string codigoMoeda = null, string simbolo = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/tipos-moedas";
    
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
            if (codigoMoeda != null) localVarQueryParams.Add("codigoMoeda", Configuration.ApiClient.ParameterToString(codigoMoeda)); // query parameter
            if (simbolo != null) localVarQueryParams.Add("simbolo", Configuration.ApiClient.ParameterToString(simbolo)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET26: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET26: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageMoedaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageMoedaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageMoedaResponse)));
            
        }
        
        /// <summary>
        /// Lista as Regras Opera\u00C3\u00A7\u00C3\u00B5es Este m\u00C3\u00A9todo permite que sejam listados as Regras opera\u00C3\u00A7\u00C3\u00B5es existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idOperacao">Apresenta o id da Opera\u00C3\u00A7\u00C3\u00A3o. (optional)</param> 
        /// <param name="idCredor">Apresenta o id do Credor. (optional)</param> 
        /// <param name="idProduto">Apresenta o id do produto que vai ser alterado. (optional)</param> 
        /// <returns>PageOperacaoCredorResponse</returns>
        public PageOperacaoCredorResponse ListarUsingGET27 (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, long? idCredor = null, long? idProduto = null)
        {
             ApiResponse<PageOperacaoCredorResponse> localVarResponse = ListarUsingGET27WithHttpInfo(sort, page, limit, idOperacao, idCredor, idProduto);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as Regras Opera\u00C3\u00A7\u00C3\u00B5es Este m\u00C3\u00A9todo permite que sejam listados as Regras opera\u00C3\u00A7\u00C3\u00B5es existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idOperacao">Apresenta o id da Opera\u00C3\u00A7\u00C3\u00A3o. (optional)</param> 
        /// <param name="idCredor">Apresenta o id do Credor. (optional)</param> 
        /// <param name="idProduto">Apresenta o id do produto que vai ser alterado. (optional)</param> 
        /// <returns>ApiResponse of PageOperacaoCredorResponse</returns>
        public ApiResponse< PageOperacaoCredorResponse > ListarUsingGET27WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, long? idCredor = null, long? idProduto = null)
        {
            
    
            var localVarPath = "/api/regras-operacoes-estabelecimentos";
    
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
            if (idOperacao != null) localVarQueryParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // query parameter
            if (idCredor != null) localVarQueryParams.Add("idCredor", Configuration.ApiClient.ParameterToString(idCredor)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET27: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET27: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageOperacaoCredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOperacaoCredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOperacaoCredorResponse)));
            
        }

        
        /// <summary>
        /// Lista as Regras Opera\u00C3\u00A7\u00C3\u00B5es Este m\u00C3\u00A9todo permite que sejam listados as Regras opera\u00C3\u00A7\u00C3\u00B5es existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idOperacao">Apresenta o id da Opera\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="idCredor">Apresenta o id do Credor. (optional)</param>
        /// <param name="idProduto">Apresenta o id do produto que vai ser alterado. (optional)</param>
        /// <returns>Task of PageOperacaoCredorResponse</returns>
        public async System.Threading.Tasks.Task<PageOperacaoCredorResponse> ListarUsingGET27Async (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, long? idCredor = null, long? idProduto = null)
        {
             ApiResponse<PageOperacaoCredorResponse> localVarResponse = await ListarUsingGET27AsyncWithHttpInfo(sort, page, limit, idOperacao, idCredor, idProduto);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as Regras Opera\u00C3\u00A7\u00C3\u00B5es Este m\u00C3\u00A9todo permite que sejam listados as Regras opera\u00C3\u00A7\u00C3\u00B5es existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idOperacao">Apresenta o id da Opera\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="idCredor">Apresenta o id do Credor. (optional)</param>
        /// <param name="idProduto">Apresenta o id do produto que vai ser alterado. (optional)</param>
        /// <returns>Task of ApiResponse (PageOperacaoCredorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageOperacaoCredorResponse>> ListarUsingGET27AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, long? idCredor = null, long? idProduto = null)
        {
            
    
            var localVarPath = "/api/regras-operacoes-estabelecimentos";
    
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
            if (idOperacao != null) localVarQueryParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // query parameter
            if (idCredor != null) localVarQueryParams.Add("idCredor", Configuration.ApiClient.ParameterToString(idCredor)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET27: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET27: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageOperacaoCredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOperacaoCredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOperacaoCredorResponse)));
            
        }
        
        /// <summary>
        /// Lista os Telefones Estabelecimentos Este m\u00C3\u00A9todo permite que sejam listados os telefones dos estabelecimentos existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Estabelecimento (id). (optional)</param> 
        /// <returns>PageTelefoneEstabelecimentoResponse</returns>
        public PageTelefoneEstabelecimentoResponse ListarUsingGET38 (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null)
        {
             ApiResponse<PageTelefoneEstabelecimentoResponse> localVarResponse = ListarUsingGET38WithHttpInfo(sort, page, limit, idEstabelecimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Telefones Estabelecimentos Este m\u00C3\u00A9todo permite que sejam listados os telefones dos estabelecimentos existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Estabelecimento (id). (optional)</param> 
        /// <returns>ApiResponse of PageTelefoneEstabelecimentoResponse</returns>
        public ApiResponse< PageTelefoneEstabelecimentoResponse > ListarUsingGET38WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null)
        {
            
    
            var localVarPath = "/api/telefones-estabelecimentos";
    
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
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET38: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET38: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTelefoneEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTelefoneEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTelefoneEstabelecimentoResponse)));
            
        }

        
        /// <summary>
        /// Lista os Telefones Estabelecimentos Este m\u00C3\u00A9todo permite que sejam listados os telefones dos estabelecimentos existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Estabelecimento (id). (optional)</param>
        /// <returns>Task of PageTelefoneEstabelecimentoResponse</returns>
        public async System.Threading.Tasks.Task<PageTelefoneEstabelecimentoResponse> ListarUsingGET38Async (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null)
        {
             ApiResponse<PageTelefoneEstabelecimentoResponse> localVarResponse = await ListarUsingGET38AsyncWithHttpInfo(sort, page, limit, idEstabelecimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Telefones Estabelecimentos Este m\u00C3\u00A9todo permite que sejam listados os telefones dos estabelecimentos existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Estabelecimento (id). (optional)</param>
        /// <returns>Task of ApiResponse (PageTelefoneEstabelecimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTelefoneEstabelecimentoResponse>> ListarUsingGET38AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null)
        {
            
    
            var localVarPath = "/api/telefones-estabelecimentos";
    
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
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET38: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET38: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTelefoneEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTelefoneEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTelefoneEstabelecimentoResponse)));
            
        }
        
        /// <summary>
        /// Lista os Terminais cadastrados no Emissor Este m\u00C3\u00A9todo permite que sejam listados os terminais existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id). (optional)</param> 
        /// <param name="terminal">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do terminal. (optional)</param> 
        /// <param name="numeroEstabelecimento">N\u00C3\u00BAmero do estabelecimento a qual o terminal pertence. (optional)</param> 
        /// <param name="idEstabelecimento">N\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento a qual o terminal pertence. (optional)</param> 
        /// <returns>PageTerminalResponse</returns>
        public PageTerminalResponse ListarUsingGET40 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null)
        {
             ApiResponse<PageTerminalResponse> localVarResponse = ListarUsingGET40WithHttpInfo(sort, page, limit, id, terminal, numeroEstabelecimento, idEstabelecimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Terminais cadastrados no Emissor Este m\u00C3\u00A9todo permite que sejam listados os terminais existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id). (optional)</param> 
        /// <param name="terminal">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do terminal. (optional)</param> 
        /// <param name="numeroEstabelecimento">N\u00C3\u00BAmero do estabelecimento a qual o terminal pertence. (optional)</param> 
        /// <param name="idEstabelecimento">N\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento a qual o terminal pertence. (optional)</param> 
        /// <returns>ApiResponse of PageTerminalResponse</returns>
        public ApiResponse< PageTerminalResponse > ListarUsingGET40WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null)
        {
            
    
            var localVarPath = "/api/terminais";
    
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
            if (terminal != null) localVarQueryParams.Add("terminal", Configuration.ApiClient.ParameterToString(terminal)); // query parameter
            if (numeroEstabelecimento != null) localVarQueryParams.Add("numeroEstabelecimento", Configuration.ApiClient.ParameterToString(numeroEstabelecimento)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET40: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET40: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTerminalResponse)));
            
        }

        
        /// <summary>
        /// Lista os Terminais cadastrados no Emissor Este m\u00C3\u00A9todo permite que sejam listados os terminais existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id). (optional)</param>
        /// <param name="terminal">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do terminal. (optional)</param>
        /// <param name="numeroEstabelecimento">N\u00C3\u00BAmero do estabelecimento a qual o terminal pertence. (optional)</param>
        /// <param name="idEstabelecimento">N\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento a qual o terminal pertence. (optional)</param>
        /// <returns>Task of PageTerminalResponse</returns>
        public async System.Threading.Tasks.Task<PageTerminalResponse> ListarUsingGET40Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null)
        {
             ApiResponse<PageTerminalResponse> localVarResponse = await ListarUsingGET40AsyncWithHttpInfo(sort, page, limit, id, terminal, numeroEstabelecimento, idEstabelecimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Terminais cadastrados no Emissor Este m\u00C3\u00A9todo permite que sejam listados os terminais existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id). (optional)</param>
        /// <param name="terminal">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do terminal. (optional)</param>
        /// <param name="numeroEstabelecimento">N\u00C3\u00BAmero do estabelecimento a qual o terminal pertence. (optional)</param>
        /// <param name="idEstabelecimento">N\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento a qual o terminal pertence. (optional)</param>
        /// <returns>Task of ApiResponse (PageTerminalResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTerminalResponse>> ListarUsingGET40AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null)
        {
            
    
            var localVarPath = "/api/terminais";
    
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
            if (terminal != null) localVarQueryParams.Add("terminal", Configuration.ApiClient.ParameterToString(terminal)); // query parameter
            if (numeroEstabelecimento != null) localVarQueryParams.Add("numeroEstabelecimento", Configuration.ApiClient.ParameterToString(numeroEstabelecimento)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET40: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET40: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTerminalResponse)));
            
        }
        
        /// <summary>
        /// Lista os V\u00C3\u00ADnculos dos estabelecimento com os adquirentes Este m\u00C3\u00A9todo permite que sejam listados os V\u00C3\u00ADnculos dos estabelecimento com os adquirentes.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idAdquirente">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do adquirente (id). (optional)</param> 
        /// <param name="idEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento. (optional)</param> 
        /// <param name="codigoEstabelecimentoAdquirente">C\u00C3\u00B3digo do v\u00C3\u00ADnculo entre o estabelecimento e o adquirente. (optional)</param> 
        /// <returns>PageVinculoEstabelecimentoAdquirenteResponse</returns>
        public PageVinculoEstabelecimentoAdquirenteResponse ListarUsingGET51 (List<string> sort = null, int? page = null, int? limit = null, long? idAdquirente = null, long? idEstabelecimento = null, string codigoEstabelecimentoAdquirente = null)
        {
             ApiResponse<PageVinculoEstabelecimentoAdquirenteResponse> localVarResponse = ListarUsingGET51WithHttpInfo(sort, page, limit, idAdquirente, idEstabelecimento, codigoEstabelecimentoAdquirente);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os V\u00C3\u00ADnculos dos estabelecimento com os adquirentes Este m\u00C3\u00A9todo permite que sejam listados os V\u00C3\u00ADnculos dos estabelecimento com os adquirentes.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idAdquirente">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do adquirente (id). (optional)</param> 
        /// <param name="idEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento. (optional)</param> 
        /// <param name="codigoEstabelecimentoAdquirente">C\u00C3\u00B3digo do v\u00C3\u00ADnculo entre o estabelecimento e o adquirente. (optional)</param> 
        /// <returns>ApiResponse of PageVinculoEstabelecimentoAdquirenteResponse</returns>
        public ApiResponse< PageVinculoEstabelecimentoAdquirenteResponse > ListarUsingGET51WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idAdquirente = null, long? idEstabelecimento = null, string codigoEstabelecimentoAdquirente = null)
        {
            
    
            var localVarPath = "/api/adquirentes-estabelecimento";
    
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
            if (idAdquirente != null) localVarQueryParams.Add("idAdquirente", Configuration.ApiClient.ParameterToString(idAdquirente)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            if (codigoEstabelecimentoAdquirente != null) localVarQueryParams.Add("codigoEstabelecimentoAdquirente", Configuration.ApiClient.ParameterToString(codigoEstabelecimentoAdquirente)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET51: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET51: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageVinculoEstabelecimentoAdquirenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageVinculoEstabelecimentoAdquirenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageVinculoEstabelecimentoAdquirenteResponse)));
            
        }

        
        /// <summary>
        /// Lista os V\u00C3\u00ADnculos dos estabelecimento com os adquirentes Este m\u00C3\u00A9todo permite que sejam listados os V\u00C3\u00ADnculos dos estabelecimento com os adquirentes.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idAdquirente">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do adquirente (id). (optional)</param>
        /// <param name="idEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento. (optional)</param>
        /// <param name="codigoEstabelecimentoAdquirente">C\u00C3\u00B3digo do v\u00C3\u00ADnculo entre o estabelecimento e o adquirente. (optional)</param>
        /// <returns>Task of PageVinculoEstabelecimentoAdquirenteResponse</returns>
        public async System.Threading.Tasks.Task<PageVinculoEstabelecimentoAdquirenteResponse> ListarUsingGET51Async (List<string> sort = null, int? page = null, int? limit = null, long? idAdquirente = null, long? idEstabelecimento = null, string codigoEstabelecimentoAdquirente = null)
        {
             ApiResponse<PageVinculoEstabelecimentoAdquirenteResponse> localVarResponse = await ListarUsingGET51AsyncWithHttpInfo(sort, page, limit, idAdquirente, idEstabelecimento, codigoEstabelecimentoAdquirente);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os V\u00C3\u00ADnculos dos estabelecimento com os adquirentes Este m\u00C3\u00A9todo permite que sejam listados os V\u00C3\u00ADnculos dos estabelecimento com os adquirentes.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idAdquirente">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do adquirente (id). (optional)</param>
        /// <param name="idEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento. (optional)</param>
        /// <param name="codigoEstabelecimentoAdquirente">C\u00C3\u00B3digo do v\u00C3\u00ADnculo entre o estabelecimento e o adquirente. (optional)</param>
        /// <returns>Task of ApiResponse (PageVinculoEstabelecimentoAdquirenteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageVinculoEstabelecimentoAdquirenteResponse>> ListarUsingGET51AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idAdquirente = null, long? idEstabelecimento = null, string codigoEstabelecimentoAdquirente = null)
        {
            
    
            var localVarPath = "/api/adquirentes-estabelecimento";
    
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
            if (idAdquirente != null) localVarQueryParams.Add("idAdquirente", Configuration.ApiClient.ParameterToString(idAdquirente)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            if (codigoEstabelecimentoAdquirente != null) localVarQueryParams.Add("codigoEstabelecimentoAdquirente", Configuration.ApiClient.ParameterToString(codigoEstabelecimentoAdquirente)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET51: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET51: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageVinculoEstabelecimentoAdquirenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageVinculoEstabelecimentoAdquirenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageVinculoEstabelecimentoAdquirenteResponse)));
            
        }
        
        /// <summary>
        /// Lista os v\u00C3\u00ADnculos cadastrados no Emissor Este m\u00C3\u00A9todo permite que sejam listados os v\u00C3\u00ADnculos opera\u00C3\u00A7\u00C3\u00B5es existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id).</param> 
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param> 
        /// <param name="idOperacao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Opera\u00C3\u00A7\u00C3\u00A3o (id). (optional)</param> 
        /// <param name="codigoMCC">C\u00C3\u00B3digo MCC. (optional)</param> 
        /// <returns>PageVinculoOperacaoResponse</returns>
        public PageVinculoOperacaoResponse ListarUsingGET52 (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOperacao = null, int? codigoMCC = null)
        {
             ApiResponse<PageVinculoOperacaoResponse> localVarResponse = ListarUsingGET52WithHttpInfo(id, sort, page, limit, idProduto, idOperacao, codigoMCC);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os v\u00C3\u00ADnculos cadastrados no Emissor Este m\u00C3\u00A9todo permite que sejam listados os v\u00C3\u00ADnculos opera\u00C3\u00A7\u00C3\u00B5es existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id).</param> 
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param> 
        /// <param name="idOperacao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Opera\u00C3\u00A7\u00C3\u00A3o (id). (optional)</param> 
        /// <param name="codigoMCC">C\u00C3\u00B3digo MCC. (optional)</param> 
        /// <returns>ApiResponse of PageVinculoOperacaoResponse</returns>
        public ApiResponse< PageVinculoOperacaoResponse > ListarUsingGET52WithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOperacao = null, int? codigoMCC = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->ListarUsingGET52");
            
    
            var localVarPath = "/api/estabelecimentos/{id}/operacoes";
    
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (idOperacao != null) localVarQueryParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // query parameter
            if (codigoMCC != null) localVarQueryParams.Add("codigoMCC", Configuration.ApiClient.ParameterToString(codigoMCC)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET52: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET52: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageVinculoOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageVinculoOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageVinculoOperacaoResponse)));
            
        }

        
        /// <summary>
        /// Lista os v\u00C3\u00ADnculos cadastrados no Emissor Este m\u00C3\u00A9todo permite que sejam listados os v\u00C3\u00ADnculos opera\u00C3\u00A7\u00C3\u00B5es existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="idOperacao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Opera\u00C3\u00A7\u00C3\u00A3o (id). (optional)</param>
        /// <param name="codigoMCC">C\u00C3\u00B3digo MCC. (optional)</param>
        /// <returns>Task of PageVinculoOperacaoResponse</returns>
        public async System.Threading.Tasks.Task<PageVinculoOperacaoResponse> ListarUsingGET52Async (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOperacao = null, int? codigoMCC = null)
        {
             ApiResponse<PageVinculoOperacaoResponse> localVarResponse = await ListarUsingGET52AsyncWithHttpInfo(id, sort, page, limit, idProduto, idOperacao, codigoMCC);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os v\u00C3\u00ADnculos cadastrados no Emissor Este m\u00C3\u00A9todo permite que sejam listados os v\u00C3\u00ADnculos opera\u00C3\u00A7\u00C3\u00B5es existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="idOperacao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Opera\u00C3\u00A7\u00C3\u00A3o (id). (optional)</param>
        /// <param name="codigoMCC">C\u00C3\u00B3digo MCC. (optional)</param>
        /// <returns>Task of ApiResponse (PageVinculoOperacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageVinculoOperacaoResponse>> ListarUsingGET52AsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOperacao = null, int? codigoMCC = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarUsingGET52");
            
    
            var localVarPath = "/api/estabelecimentos/{id}/operacoes";
    
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (idOperacao != null) localVarQueryParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // query parameter
            if (codigoMCC != null) localVarQueryParams.Add("codigoMCC", Configuration.ApiClient.ParameterToString(codigoMCC)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET52: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET52: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageVinculoOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageVinculoOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageVinculoOperacaoResponse)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro de uma nova maquineta para um estabelecimento  Este m\u00C3\u00A9todo permite que seja cadastrada uma nova maquineta para um estabelecimento.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maquinetaPersist">maquinetaPersist</param> 
        /// <returns>MaquinetaResponse</returns>
        public MaquinetaResponse SalvarUsingPOST16 (MaquinetaPersist maquinetaPersist)
        {
             ApiResponse<MaquinetaResponse> localVarResponse = SalvarUsingPOST16WithHttpInfo(maquinetaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro de uma nova maquineta para um estabelecimento  Este m\u00C3\u00A9todo permite que seja cadastrada uma nova maquineta para um estabelecimento.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maquinetaPersist">maquinetaPersist</param> 
        /// <returns>ApiResponse of MaquinetaResponse</returns>
        public ApiResponse< MaquinetaResponse > SalvarUsingPOST16WithHttpInfo (MaquinetaPersist maquinetaPersist)
        {
            
            // verify the required parameter 'maquinetaPersist' is set
            if (maquinetaPersist == null)
                throw new ApiException(400, "Missing required parameter 'maquinetaPersist' when calling EstabelecimentoApi->SalvarUsingPOST16");
            
    
            var localVarPath = "/api/maquinetas";
    
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
            
            
            
            
            if (maquinetaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(maquinetaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = maquinetaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST16: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST16: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<MaquinetaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MaquinetaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaquinetaResponse)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro de uma nova maquineta para um estabelecimento  Este m\u00C3\u00A9todo permite que seja cadastrada uma nova maquineta para um estabelecimento.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maquinetaPersist">maquinetaPersist</param>
        /// <returns>Task of MaquinetaResponse</returns>
        public async System.Threading.Tasks.Task<MaquinetaResponse> SalvarUsingPOST16Async (MaquinetaPersist maquinetaPersist)
        {
             ApiResponse<MaquinetaResponse> localVarResponse = await SalvarUsingPOST16AsyncWithHttpInfo(maquinetaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro de uma nova maquineta para um estabelecimento  Este m\u00C3\u00A9todo permite que seja cadastrada uma nova maquineta para um estabelecimento.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maquinetaPersist">maquinetaPersist</param>
        /// <returns>Task of ApiResponse (MaquinetaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MaquinetaResponse>> SalvarUsingPOST16AsyncWithHttpInfo (MaquinetaPersist maquinetaPersist)
        {
            // verify the required parameter 'maquinetaPersist' is set
            if (maquinetaPersist == null) throw new ApiException(400, "Missing required parameter 'maquinetaPersist' when calling SalvarUsingPOST16");
            
    
            var localVarPath = "/api/maquinetas";
    
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
            
            
            
            
            if (maquinetaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(maquinetaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = maquinetaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST16: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST16: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MaquinetaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MaquinetaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaquinetaResponse)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro de uma nova Regra Opera\u00C3\u00A7\u00C3\u00A3o Este m\u00C3\u00A9todo permite que seja cadastrada uma nova Regra Opera\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oprecaoCredorPersist">oprecaoCredorPersist</param> 
        /// <returns>OperacaoCredorResponse</returns>
        public OperacaoCredorResponse SalvarUsingPOST17 (OperacaoCredorPersist oprecaoCredorPersist)
        {
             ApiResponse<OperacaoCredorResponse> localVarResponse = SalvarUsingPOST17WithHttpInfo(oprecaoCredorPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro de uma nova Regra Opera\u00C3\u00A7\u00C3\u00A3o Este m\u00C3\u00A9todo permite que seja cadastrada uma nova Regra Opera\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oprecaoCredorPersist">oprecaoCredorPersist</param> 
        /// <returns>ApiResponse of OperacaoCredorResponse</returns>
        public ApiResponse< OperacaoCredorResponse > SalvarUsingPOST17WithHttpInfo (OperacaoCredorPersist oprecaoCredorPersist)
        {
            
            // verify the required parameter 'oprecaoCredorPersist' is set
            if (oprecaoCredorPersist == null)
                throw new ApiException(400, "Missing required parameter 'oprecaoCredorPersist' when calling EstabelecimentoApi->SalvarUsingPOST17");
            
    
            var localVarPath = "/api/regras-operacoes-estabelecimentos";
    
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
            
            
            
            
            if (oprecaoCredorPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(oprecaoCredorPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = oprecaoCredorPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST17: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST17: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OperacaoCredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OperacaoCredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperacaoCredorResponse)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro de uma nova Regra Opera\u00C3\u00A7\u00C3\u00A3o Este m\u00C3\u00A9todo permite que seja cadastrada uma nova Regra Opera\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oprecaoCredorPersist">oprecaoCredorPersist</param>
        /// <returns>Task of OperacaoCredorResponse</returns>
        public async System.Threading.Tasks.Task<OperacaoCredorResponse> SalvarUsingPOST17Async (OperacaoCredorPersist oprecaoCredorPersist)
        {
             ApiResponse<OperacaoCredorResponse> localVarResponse = await SalvarUsingPOST17AsyncWithHttpInfo(oprecaoCredorPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro de uma nova Regra Opera\u00C3\u00A7\u00C3\u00A3o Este m\u00C3\u00A9todo permite que seja cadastrada uma nova Regra Opera\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oprecaoCredorPersist">oprecaoCredorPersist</param>
        /// <returns>Task of ApiResponse (OperacaoCredorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OperacaoCredorResponse>> SalvarUsingPOST17AsyncWithHttpInfo (OperacaoCredorPersist oprecaoCredorPersist)
        {
            // verify the required parameter 'oprecaoCredorPersist' is set
            if (oprecaoCredorPersist == null) throw new ApiException(400, "Missing required parameter 'oprecaoCredorPersist' when calling SalvarUsingPOST17");
            
    
            var localVarPath = "/api/regras-operacoes-estabelecimentos";
    
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
            
            
            
            
            if (oprecaoCredorPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(oprecaoCredorPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = oprecaoCredorPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST17: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST17: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OperacaoCredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OperacaoCredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperacaoCredorResponse)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro de um novo telefone para um estabelecimento  Este m\u00C3\u00A9todo permite que seja cadastrado um novo telefone para um estabelecimento.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento (id).</param> 
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id).</param> 
        /// <param name="telefone">N\u00C3\u00BAmero do telefone.</param> 
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param> 
        /// <returns>TelefoneEstabelecimentoResponse</returns>
        public TelefoneEstabelecimentoResponse SalvarUsingPOST22 (long? idEstabelecimento, string ddd, string telefone, string ramal = null)
        {
             ApiResponse<TelefoneEstabelecimentoResponse> localVarResponse = SalvarUsingPOST22WithHttpInfo(idEstabelecimento, ddd, telefone, ramal);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro de um novo telefone para um estabelecimento  Este m\u00C3\u00A9todo permite que seja cadastrado um novo telefone para um estabelecimento.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento (id).</param> 
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id).</param> 
        /// <param name="telefone">N\u00C3\u00BAmero do telefone.</param> 
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param> 
        /// <returns>ApiResponse of TelefoneEstabelecimentoResponse</returns>
        public ApiResponse< TelefoneEstabelecimentoResponse > SalvarUsingPOST22WithHttpInfo (long? idEstabelecimento, string ddd, string telefone, string ramal = null)
        {
            
            // verify the required parameter 'idEstabelecimento' is set
            if (idEstabelecimento == null)
                throw new ApiException(400, "Missing required parameter 'idEstabelecimento' when calling EstabelecimentoApi->SalvarUsingPOST22");
            
            // verify the required parameter 'ddd' is set
            if (ddd == null)
                throw new ApiException(400, "Missing required parameter 'ddd' when calling EstabelecimentoApi->SalvarUsingPOST22");
            
            // verify the required parameter 'telefone' is set
            if (telefone == null)
                throw new ApiException(400, "Missing required parameter 'telefone' when calling EstabelecimentoApi->SalvarUsingPOST22");
            
    
            var localVarPath = "/api/telefones-estabelecimentos";
    
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
            
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            if (ddd != null) localVarQueryParams.Add("ddd", Configuration.ApiClient.ParameterToString(ddd)); // query parameter
            if (telefone != null) localVarQueryParams.Add("telefone", Configuration.ApiClient.ParameterToString(telefone)); // query parameter
            if (ramal != null) localVarQueryParams.Add("ramal", Configuration.ApiClient.ParameterToString(ramal)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST22: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST22: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TelefoneEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneEstabelecimentoResponse)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro de um novo telefone para um estabelecimento  Este m\u00C3\u00A9todo permite que seja cadastrado um novo telefone para um estabelecimento.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento (id).</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id).</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone.</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <returns>Task of TelefoneEstabelecimentoResponse</returns>
        public async System.Threading.Tasks.Task<TelefoneEstabelecimentoResponse> SalvarUsingPOST22Async (long? idEstabelecimento, string ddd, string telefone, string ramal = null)
        {
             ApiResponse<TelefoneEstabelecimentoResponse> localVarResponse = await SalvarUsingPOST22AsyncWithHttpInfo(idEstabelecimento, ddd, telefone, ramal);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro de um novo telefone para um estabelecimento  Este m\u00C3\u00A9todo permite que seja cadastrado um novo telefone para um estabelecimento.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento (id).</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id).</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone.</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <returns>Task of ApiResponse (TelefoneEstabelecimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TelefoneEstabelecimentoResponse>> SalvarUsingPOST22AsyncWithHttpInfo (long? idEstabelecimento, string ddd, string telefone, string ramal = null)
        {
            // verify the required parameter 'idEstabelecimento' is set
            if (idEstabelecimento == null) throw new ApiException(400, "Missing required parameter 'idEstabelecimento' when calling SalvarUsingPOST22");
            // verify the required parameter 'ddd' is set
            if (ddd == null) throw new ApiException(400, "Missing required parameter 'ddd' when calling SalvarUsingPOST22");
            // verify the required parameter 'telefone' is set
            if (telefone == null) throw new ApiException(400, "Missing required parameter 'telefone' when calling SalvarUsingPOST22");
            
    
            var localVarPath = "/api/telefones-estabelecimentos";
    
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
            
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            if (ddd != null) localVarQueryParams.Add("ddd", Configuration.ApiClient.ParameterToString(ddd)); // query parameter
            if (telefone != null) localVarQueryParams.Add("telefone", Configuration.ApiClient.ParameterToString(telefone)); // query parameter
            if (ramal != null) localVarQueryParams.Add("ramal", Configuration.ApiClient.ParameterToString(ramal)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST22: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST22: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TelefoneEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneEstabelecimentoResponse)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro de um novo Terminal Este m\u00C3\u00A9todo permite que seja cadastrado um novo Terminal.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminalPersist">terminalPersist</param> 
        /// <returns>TerminalResponse</returns>
        public TerminalResponse SalvarUsingPOST24 (TerminalPersist terminalPersist)
        {
             ApiResponse<TerminalResponse> localVarResponse = SalvarUsingPOST24WithHttpInfo(terminalPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro de um novo Terminal Este m\u00C3\u00A9todo permite que seja cadastrado um novo Terminal.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminalPersist">terminalPersist</param> 
        /// <returns>ApiResponse of TerminalResponse</returns>
        public ApiResponse< TerminalResponse > SalvarUsingPOST24WithHttpInfo (TerminalPersist terminalPersist)
        {
            
            // verify the required parameter 'terminalPersist' is set
            if (terminalPersist == null)
                throw new ApiException(400, "Missing required parameter 'terminalPersist' when calling EstabelecimentoApi->SalvarUsingPOST24");
            
    
            var localVarPath = "/api/terminais";
    
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
            
            
            
            
            if (terminalPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(terminalPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = terminalPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST24: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST24: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TerminalResponse)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro de um novo Terminal Este m\u00C3\u00A9todo permite que seja cadastrado um novo Terminal.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminalPersist">terminalPersist</param>
        /// <returns>Task of TerminalResponse</returns>
        public async System.Threading.Tasks.Task<TerminalResponse> SalvarUsingPOST24Async (TerminalPersist terminalPersist)
        {
             ApiResponse<TerminalResponse> localVarResponse = await SalvarUsingPOST24AsyncWithHttpInfo(terminalPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro de um novo Terminal Este m\u00C3\u00A9todo permite que seja cadastrado um novo Terminal.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminalPersist">terminalPersist</param>
        /// <returns>Task of ApiResponse (TerminalResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TerminalResponse>> SalvarUsingPOST24AsyncWithHttpInfo (TerminalPersist terminalPersist)
        {
            // verify the required parameter 'terminalPersist' is set
            if (terminalPersist == null) throw new ApiException(400, "Missing required parameter 'terminalPersist' when calling SalvarUsingPOST24");
            
    
            var localVarPath = "/api/terminais";
    
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
            
            
            
            
            if (terminalPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(terminalPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = terminalPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST24: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST24: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TerminalResponse)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro de um novo VinculoEstabelecimentoAdquirente Este m\u00C3\u00A9todo permite que seja cadastrado um novo VinculoEstabelecimentoAdquirente.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vinculoEstabelecimentoAdquirentePersist">vinculoEstabelecimentoAdquirentePersist</param> 
        /// <returns>VinculoEstabelecimentoAdquirenteResponse</returns>
        public VinculoEstabelecimentoAdquirenteResponse SalvarUsingPOST29 (VinculoEstabelecimentoAdquirentePersist vinculoEstabelecimentoAdquirentePersist)
        {
             ApiResponse<VinculoEstabelecimentoAdquirenteResponse> localVarResponse = SalvarUsingPOST29WithHttpInfo(vinculoEstabelecimentoAdquirentePersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro de um novo VinculoEstabelecimentoAdquirente Este m\u00C3\u00A9todo permite que seja cadastrado um novo VinculoEstabelecimentoAdquirente.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vinculoEstabelecimentoAdquirentePersist">vinculoEstabelecimentoAdquirentePersist</param> 
        /// <returns>ApiResponse of VinculoEstabelecimentoAdquirenteResponse</returns>
        public ApiResponse< VinculoEstabelecimentoAdquirenteResponse > SalvarUsingPOST29WithHttpInfo (VinculoEstabelecimentoAdquirentePersist vinculoEstabelecimentoAdquirentePersist)
        {
            
            // verify the required parameter 'vinculoEstabelecimentoAdquirentePersist' is set
            if (vinculoEstabelecimentoAdquirentePersist == null)
                throw new ApiException(400, "Missing required parameter 'vinculoEstabelecimentoAdquirentePersist' when calling EstabelecimentoApi->SalvarUsingPOST29");
            
    
            var localVarPath = "/api/adquirentes-estabelecimento";
    
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
            
            
            
            
            if (vinculoEstabelecimentoAdquirentePersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(vinculoEstabelecimentoAdquirentePersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = vinculoEstabelecimentoAdquirentePersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST29: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST29: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<VinculoEstabelecimentoAdquirenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VinculoEstabelecimentoAdquirenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VinculoEstabelecimentoAdquirenteResponse)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro de um novo VinculoEstabelecimentoAdquirente Este m\u00C3\u00A9todo permite que seja cadastrado um novo VinculoEstabelecimentoAdquirente.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vinculoEstabelecimentoAdquirentePersist">vinculoEstabelecimentoAdquirentePersist</param>
        /// <returns>Task of VinculoEstabelecimentoAdquirenteResponse</returns>
        public async System.Threading.Tasks.Task<VinculoEstabelecimentoAdquirenteResponse> SalvarUsingPOST29Async (VinculoEstabelecimentoAdquirentePersist vinculoEstabelecimentoAdquirentePersist)
        {
             ApiResponse<VinculoEstabelecimentoAdquirenteResponse> localVarResponse = await SalvarUsingPOST29AsyncWithHttpInfo(vinculoEstabelecimentoAdquirentePersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro de um novo VinculoEstabelecimentoAdquirente Este m\u00C3\u00A9todo permite que seja cadastrado um novo VinculoEstabelecimentoAdquirente.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vinculoEstabelecimentoAdquirentePersist">vinculoEstabelecimentoAdquirentePersist</param>
        /// <returns>Task of ApiResponse (VinculoEstabelecimentoAdquirenteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VinculoEstabelecimentoAdquirenteResponse>> SalvarUsingPOST29AsyncWithHttpInfo (VinculoEstabelecimentoAdquirentePersist vinculoEstabelecimentoAdquirentePersist)
        {
            // verify the required parameter 'vinculoEstabelecimentoAdquirentePersist' is set
            if (vinculoEstabelecimentoAdquirentePersist == null) throw new ApiException(400, "Missing required parameter 'vinculoEstabelecimentoAdquirentePersist' when calling SalvarUsingPOST29");
            
    
            var localVarPath = "/api/adquirentes-estabelecimento";
    
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
            
            
            
            
            if (vinculoEstabelecimentoAdquirentePersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(vinculoEstabelecimentoAdquirentePersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = vinculoEstabelecimentoAdquirentePersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST29: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST29: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VinculoEstabelecimentoAdquirenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VinculoEstabelecimentoAdquirenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VinculoEstabelecimentoAdquirenteResponse)));
            
        }
        
    }
    
}
